using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using LiteNetLib;
using LiteNetLib.Utils;
using SoDCoop.Network;
using SoDCoop.Network.Steam;

namespace SoDCoop.Sync;

/// <summary>
/// Save-Transfer bootstrap: the host ships its full save file to a joining
/// client via a chunked reliable stream, and the client loads it through
/// SoD's normal <c>MainMenuController.LoadGame()</c> path. This replaces
/// the legacy share-code city-regeneration pipeline
/// (<c>WorldAutoLoad.TriggerSoDGeneration</c>) when the host's
/// <c>CoopSettings.WorldBootstrap</c> is <c>SaveTransfer</c> and the client
/// advertised support in its bootstrap packet.
///
/// <para><b>Why:</b> the share-code path regenerates the city from a seed,
/// so the two worlds can diverge on any non-deterministic SoD state (NPC
/// schedule jitter, murder RNG, citizen roster ordering) that the ZDO
/// snapshot doesn't cover. Shipping the host's actual save file guarantees
/// byte-identical worlds by construction — every NPC, every door state,
/// every murder state matches. It also kills the tutorial automatically
/// (loading a save never fires <c>ChapterIntro.OnGameStart</c> as a new-
/// game event), though we still apply the suppression layers because
/// <c>CityConstructor</c>'s finalize invokes <c>OnGameStart</c> regardless.
/// </para>
///
/// <para><b>Wire format</b> (three packet types, all ReliableOrdered):
/// <list type="bullet">
///   <item><description><see cref="PacketType.SaveTransferHeader"/> (host→client):
///   <c>uint saveSize + ushort totalChunks + byte[32] sha256</c>. Client
///   initialises a reassembly buffer sized to <c>saveSize</c>.</description></item>
///   <item><description><see cref="PacketType.SaveTransferChunk"/> (host→client):
///   <c>ushort chunkIndex + ushort chunkLen + byte[chunkLen]</c>. Client
///   appends <c>chunkLen</c> bytes at the stream tail.</description></item>
///   <item><description><see cref="PacketType.SaveTransferComplete"/> (client→host):
///   empty. Sent after SHA-256 verifies and <c>LoadGame()</c> is
///   invoked. Host uses it to confirm the transfer landed (and in Phase 4
///   live re-sync, that the re-sync was accepted).</description></item>
/// </list></para>
///
/// <para>Single-threaded (Unity main). Host send and client receive never
/// overlap on the same machine (a peer is either host or client, not
/// both), so the static state below is safe.</para>
/// </summary>
public static class SaveTransfer
{
    // ── Tunables ────────────────────────────────────────────────────────

    /// <summary>Uncompressed chunk size shipped per
    /// <see cref="PacketType.SaveTransferChunk"/> packet. 32 KB balances
    /// per-chunk zstd overhead (we ship raw, not compressed — saves are
    /// already JSON which compresses poorly per-chunk) against per-frame
    /// cost and drop resilience. A 2 MB save at 32 KB/chunk = ~64 chunks;
    /// at <see cref="MAX_CHUNK_BYTES_PER_FRAME"/> that drains in ~4 frames.</summary>
    private const int CHUNK_SIZE = 32 * 1024;

    /// <summary>Max bytes shipped per frame per pending transfer. 128 KB/frame
    /// at 60 fps = ~7.5 MB/s — fast enough that a typical multi-MB save
    /// drains in well under a second, slow enough that per-frame main-
    /// thread cost stays sub-millisecond.</summary>
    private const int MAX_CHUNK_BYTES_PER_FRAME = 128 * 1024;

    // ── Host-side pending transfer state ────────────────────────────────

    private struct PendingTransfer
    {
        public SteamPeer Peer;
        public byte[] SaveBytes;     // full save file contents
        public int SaveLen;
        public byte[] Sha256;        // 32-byte hash of SaveBytes
        public int Cursor;           // byte offset of next chunk to send
        public ushort NextChunkIndex;
        public ushort TotalChunks;
        public ulong PeerSteamId;
        public float EnqueuedAt;
        /// <summary>Wall-clock of the last frame on which the transport
        /// accepted at least one byte. Drives <see cref="STALL_TIMEOUT_S"/>.</summary>
        public float LastProgressAt;
        /// <summary>Earliest time the next send attempt may run. Set on a
        /// rejected send so we back off instead of hammering (and log-spamming)
        /// a saturated send buffer every frame. See the backpressure note in
        /// <see cref="PumpPendingTransfers"/>.</summary>
        public float NextAttemptAt;
    }

    /// <summary>Abort a transfer that has made zero forward progress for this
    /// long. A multi-MB save over a slow uplink legitimately takes many
    /// seconds, and the joiner is on a loading screen, so this is generous —
    /// only a dead peer or a permanently wedged send buffer should trip it.</summary>
    private const float STALL_TIMEOUT_S = 60f;

    /// <summary>Backoff applied after the transport rejects a chunk (send
    /// buffer saturated). Long enough for the buffer to drain meaningfully,
    /// short enough that throughput stays close to the link rate.</summary>
    private const float SEND_BACKOFF_S = 0.25f;

    /// <summary>Sanity cap on an announced save size, both when reading a
    /// header and when appending chunks. SoD saves are single-digit MB; 256 MB
    /// is absurd headroom while still refusing a corrupt or hostile header
    /// that would otherwise grow the reassembly buffer until the process
    /// dies.</summary>
    private const int MAX_SAVE_BYTES = 256 * 1024 * 1024;

    /// <summary>Host-side queue of in-flight save transfers. Typically 0–1
    /// (one joiner at a time); drained chunk-by-chunk per frame by
    /// <see cref="PumpPendingTransfers"/>.</summary>
    private static readonly List<PendingTransfer> _pending = new();

    private static readonly NetDataWriter _sendScratch = new();

    // ── Client-side reassembly state ────────────────────────────────────

    private static MemoryStream _reassemblyStream;
    private static byte[] _expectedSha256;
    private static int _expectedSaveSize;
    private static ushort _expectedChunks;
    private static int _receivedChunks;
    private static float _transferStartedAt;

    // ════════════════════════════════════════════════════════════════════
    // Host side
    // ════════════════════════════════════════════════════════════════════

    /// <summary>Read the host's current save file, compute its SHA-256,
    /// and enqueue a chunked transfer to <paramref name="peer"/>. The
    /// actual wire send is drained over subsequent frames by
    /// <see cref="PumpPendingTransfers"/>. Returns false (and logs) if the
    /// save file can't be read — caller should fall back to share-code.
    ///
    /// <para>The save path is resolved from <see cref="HostSavePath"/>,
    /// which is populated from the SOD.Common <c>OnAfterSave</c> hook
    /// (see <c>SodCommonBridge</c>). If no save has been observed yet,
    /// returns false.</para></summary>
    /// <param name="allowForcedCapture">False suppresses the opt-in
    /// fresh-save capture. <see cref="FinishCapture"/> passes false when it
    /// ships to the peers that were queued behind a capture: without it a
    /// capture that FAILED would leave <see cref="HostSavePathIsFresh"/> false,
    /// this method would start another capture for the same peer, and each
    /// failure would kick off the next one — an unbounded capture loop.</param>
    public static bool SendSaveToPeer(SteamPeer peer, bool allowForcedCapture = true)
    {
        if (peer == null) return false;
        if (!NetworkManager.IsHost) return false;

        string savePath = HostSavePath;
        if (string.IsNullOrEmpty(savePath) || !File.Exists(savePath))
        {
            Plugin.Log.LogWarning($"[SaveTransfer] no host save file to send (path='{savePath}') — falling back to share-code for {peer.DisplayName}.");
            return false;
        }

        // Opt-in: capture a fresh save first so the shipped base world matches
        // the host's live state exactly. Off by default because
        // SaveStateController.CaptureSaveStateAsync is called mid-session here
        // and we have not yet confirmed (needs a playtest) that it leaves the
        // game's notion of "current save" untouched. When it's off we ship the
        // known file as-is and say so.
        if (allowForcedCapture && !HostSavePathIsFresh
            && CoopSettings.SaveTransferForceSaveOnJoin?.Value == true)
        {
            if (BeginForcedCapture(peer)) return true;   // peer queued; ships when the capture lands
            Plugin.Log.LogWarning("[SaveTransfer] forced capture could not start — shipping the existing (not live-current) save instead.");
        }

        if (!HostSavePathIsFresh)
        {
            Plugin.Log.LogInfo(
                $"[SaveTransfer] shipping '{Path.GetFileName(savePath)}' which came from a LOAD, not a save — " +
                "the joiner's base world will match this file and the ZDO snapshot will layer live state on top. " +
                "Save the game before friends join (or set SaveTransferForceSaveOnJoin=true) for an exact base state.");
        }

        try
        {
            byte[] saveBytes = File.ReadAllBytes(savePath);
            int saveLen = saveBytes.Length;
            if (saveLen <= 0)
            {
                Plugin.Log.LogWarning($"[SaveTransfer] host save file is empty: '{savePath}'.");
                return false;
            }

            byte[] sha;
            using (var sha256 = SHA256.Create())
                sha = sha256.ComputeHash(saveBytes);

            int dataChunks = (saveLen + CHUNK_SIZE - 1) / CHUNK_SIZE;
            ushort totalChunks = (ushort)Math.Min(ushort.MaxValue, dataChunks);
            int peerId = NetworkManager.GetPlayerIdByPeer(peer);

            _pending.Add(new PendingTransfer
            {
                Peer           = peer,
                SaveBytes      = saveBytes,
                SaveLen        = saveLen,
                Sha256         = sha,
                Cursor         = 0,
                NextChunkIndex = 0,
                TotalChunks    = totalChunks,
                PeerSteamId    = peer.SteamId.m_SteamID,
                EnqueuedAt     = UnityEngine.Time.unscaledTime,
                LastProgressAt = UnityEngine.Time.unscaledTime,
                NextAttemptAt  = 0f,
            });

            Plugin.Log.LogInfo(
                $"[SaveTransfer] enqueued save transfer to {peer.DisplayName}: " +
                $"'{savePath}' {saveLen} bytes ({saveLen / 1024.0:F1} KB), {totalChunks} chunks, " +
                $"sha256={BitConverter.ToString(sha).Replace("-", "").Substring(0, 16)}…");
            return true;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SaveTransfer] SendSaveToPeer failed reading '{savePath}': {ex.Message}");
            return false;
        }
    }

    /// <summary>The most recently observed host save file path, captured from
    /// SOD.Common's OnAfterSave <b>and OnAfterLoad</b> hooks (set by
    /// SodCommonBridge). Null only until the host has either saved or loaded
    /// this session — i.e. essentially always non-null once a world is up,
    /// since hosting requires a loaded world.
    ///
    /// <para><b>History:</b> this used to be set from OnAfterSave alone, which
    /// meant the overwhelmingly common flow — host loads their save, then
    /// hosts — left it null. <see cref="SendSaveToPeer"/> then returned false
    /// and the handshake silently fell back to share-code, so Save-Transfer
    /// (and the divergence + tutorial guarantees that motivate it) was off for
    /// most sessions with only a log warning to show for it.</para></summary>
    public static string HostSavePath { get; set; }

    /// <summary>True when <see cref="HostSavePath"/> points at a file written
    /// by a SAVE this session (OnAfterSave), false when it came from a LOAD
    /// (OnAfterLoad).
    ///
    /// <para>Matters because a loaded file reflects the world as it was at
    /// load time, not the host's current live state. Shipping it is still
    /// clearly better than share-code — the joiner gets a byte-identical base
    /// world and the ZDO snapshot layers current state on top, whereas
    /// share-code regenerates a world that can differ structurally — but a
    /// fresh save makes the base state exact. Drives the host-facing log and
    /// the opt-in force-save path.</para></summary>
    public static bool HostSavePathIsFresh { get; set; }

    /// <summary>SHA-256 (hex) of the last save we pushed to any peer. Phase 4
    /// live re-sync compares a freshly-saved file's hash against this to
    /// decide whether anything actually changed since the last push (a save
    /// that byte-identical to what clients already have would just reload
    /// their world for nothing). Updated by <see cref="SendSaveToPeer"/>
    /// when the last chunk ships.</summary>
    public static string LastPushedSha256Hex { get; internal set; }

    /// <summary>Host-side Phase 4 entry: called from
    /// <c>SodCommonBridge.OnAfterSave</c>. Reads the freshly-written save,
    /// hashes it, and if the hash differs from <see cref="LastPushedSha256Hex"/>
    /// re-pushes the save to every connected client via
    /// <see cref="SendSaveToPeer"/>. Skipped if no clients are connected
    /// (solo host) or the save is byte-identical to the last push (no-op
    /// save, e.g. SoD auto-save with no state change).
    ///
    /// <para>Each client receives the save stream asynchronously; they ACK
    /// via <see cref="PacketType.SaveTransferComplete"/> once their reload
    /// starts. The host does NOT pause simulation during re-sync — clients
    /// may briefly diverge until their reload completes, but the next ZDO
    /// snapshot (fired by their post-reload <c>ClientWorldReady</c>)
    /// re-aligns state.</para></summary>
    /// <returns>Number of clients the re-sync was pushed to (0 = no clients
    /// or no change).</returns>
    public static int ResyncToAllClients()
    {
        if (!NetworkManager.IsHost) return 0;
        if (!NetworkManager.HasPeers) return 0;

        string savePath = HostSavePath;
        if (string.IsNullOrEmpty(savePath) || !File.Exists(savePath))
        {
            Plugin.Log.LogWarning("[SaveTransfer] ResyncToAllClients: no host save file - skipping.");
            return 0;
        }

        // Read + hash the save ONCE here, then reuse the bytes for every peer.
        // SendSaveToPeer re-reads the file per call, so for N peers that's N+1
        // reads of a multi-MB file — wasteful. Instead we pre-read, hash, and
        // push directly via the internal enqueue.
        byte[] saveBytes;
        byte[] newSha;
        string newShaHex;
        try
        {
            saveBytes = File.ReadAllBytes(savePath);
            if (saveBytes.Length <= 0)
            {
                Plugin.Log.LogWarning($"[SaveTransfer] ResyncToAllClients: save file empty: '{savePath}'.");
                return 0;
            }
            using (var sha256 = SHA256.Create())
            {
                newSha = sha256.ComputeHash(saveBytes);
                newShaHex = BitConverter.ToString(newSha).Replace("-", "").ToLowerInvariant();
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SaveTransfer] ResyncToAllClients: failed to read/hash '{savePath}': {ex.Message}");
            return 0;
        }

        // Hash-compare against the last push to skip no-op saves. Also guards
        // against a re-entrancy loop: if a previous resync is still draining
        // (chunks in flight), LastPushedSha256Hex hasn't been updated yet
        // (it's stamped in PumpPendingTransfers when the last chunk ships).
        // Without this check, an OnAfterSave that fires during a drain would
        // enqueue a SECOND transfer of the same bytes. The in-flight check
        // below is the belt-and-braces version.
        if (newShaHex == LastPushedSha256Hex)
        {
            Plugin.Log.LogInfo("[SaveTransfer] ResyncToAllClients: save unchanged since last push (sha256 match) - skipping.");
            return 0;
        }
        if (_pending.Count > 0)
        {
            Plugin.Log.LogInfo($"[SaveTransfer] ResyncToAllClients: {_pending.Count} transfer(s) already in flight - deferring this push to avoid pile-up.");
            return 0;
        }

        // Push to every connected client using the pre-read bytes (no
        // per-peer re-read).
        var clients = NetworkManager.Clients;
        int pushed = 0;
        int saveLen = saveBytes.Length;
        int dataChunks = (saveLen + CHUNK_SIZE - 1) / CHUNK_SIZE;
        ushort totalChunks = (ushort)Math.Min(ushort.MaxValue, dataChunks);

        for (int i = 0; i < clients.Count; i++)
        {
            var peer = clients[i];
            if (peer == null) continue;

            _pending.Add(new PendingTransfer
            {
                Peer           = peer,
                SaveBytes      = saveBytes,
                SaveLen        = saveLen,
                Sha256         = newSha,
                Cursor         = 0,
                NextChunkIndex = 0,
                TotalChunks    = totalChunks,
                PeerSteamId    = peer.SteamId.m_SteamID,
                EnqueuedAt     = UnityEngine.Time.unscaledTime,
                LastProgressAt = UnityEngine.Time.unscaledTime,
                NextAttemptAt  = 0f,
            });
            pushed++;
        }

        if (pushed > 0)
        {
            Plugin.Log.LogInfo(
                $"[SaveTransfer] ResyncToAllClients: pushed save to {pushed} client(s) " +
                $"({saveLen} bytes, sha256={newShaHex.Substring(0, Math.Min(16, newShaHex.Length))}…).");
        }
        return pushed;
    }

    /// <summary>Drain pending save transfers chunk-by-chunk. Called once
    /// per frame from <c>CoopUpdateRunner.Update</c>. Each frame ships the
    /// header (once) + as many data chunks as fit in
    /// <see cref="MAX_CHUNK_BYTES_PER_FRAME"/>. When the last chunk ships,
    /// the entry is removed (the client will ACK via
    /// <see cref="PacketType.SaveTransferComplete"/> once it has loaded).</summary>
    // ── Opt-in forced capture (host) ────────────────────────────────────
    //
    // When SaveTransferForceSaveOnJoin is on and the known save file did not
    // come from a save this session, we ask SoD to write a fresh one to a
    // coop-owned path before shipping. Peers that arrive while the capture is
    // in flight are queued here and shipped when it completes.
    //
    // Completion is observed by polling the returned Task's IsCompleted rather
    // than by waiting on SOD.Common's OnAfterSave: the hook wraps the game's
    // own save flow and it is not established that a direct
    // CaptureSaveStateAsync call routes through it. The Task is the direct,
    // dependency-free signal.
    //
    // The capture writes to a DEDICATED file, never over the player's own
    // saves — shipping a coop snapshot must not be able to clobber user data.

    private static Il2CppSystem.Threading.Tasks.Task _captureTask;
    private static string _capturePath;
    private static float _captureStartedAt;
    private static readonly List<SteamPeer> _awaitingCapture = new();

    /// <summary>Give up on a forced capture that never completes and ship the
    /// existing file instead. Saves take a couple of seconds on a big city.</summary>
    private const float CAPTURE_TIMEOUT_S = 30f;

    /// <summary>Filename (under <c>Application.persistentDataPath</c>) the
    /// forced capture writes to. Deliberately distinct from anything SoD would
    /// pick so a capture can never overwrite one of the player's own saves.</summary>
    private const string CAPTURE_FILENAME = "sodcoop_hostpush.save";

    /// <summary>Start (or join) a forced save capture and queue
    /// <paramref name="peer"/> to be shipped once it lands. Returns false if a
    /// capture can't be started at all, in which case the caller should ship
    /// the existing file.</summary>
    private static bool BeginForcedCapture(SteamPeer peer)
    {
        // A capture is already running — just join the queue.
        if (_captureTask != null)
        {
            if (!_awaitingCapture.Contains(peer)) _awaitingCapture.Add(peer);
            Plugin.Log.LogInfo($"[SaveTransfer] {peer.DisplayName} queued behind an in-flight forced capture.");
            return true;
        }

        try
        {
            var ssc = global::SaveStateController.Instance;
            if (ssc == null)
            {
                Plugin.Log.LogWarning("[SaveTransfer] SaveStateController.Instance is null — cannot force a capture.");
                return false;
            }

            string path = Path.Combine(UnityEngine.Application.persistentDataPath, CAPTURE_FILENAME);
            var task = ssc.CaptureSaveStateAsync(path, true);
            if (task == null)
            {
                Plugin.Log.LogWarning("[SaveTransfer] CaptureSaveStateAsync returned null — cannot force a capture.");
                return false;
            }

            _captureTask = task;
            _capturePath = path;
            _captureStartedAt = UnityEngine.Time.unscaledTime;
            _awaitingCapture.Clear();
            _awaitingCapture.Add(peer);

            Plugin.Log.LogInfo($"[SaveTransfer] forced capture started → '{path}' ({peer.DisplayName} waiting).");
            return true;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[SaveTransfer] BeginForcedCapture failed: {ex.Message}");
            _captureTask = null;
            _capturePath = null;
            return false;
        }
    }

    /// <summary>Poll the in-flight forced capture. On completion, repoint
    /// <see cref="HostSavePath"/> at the freshly-written file and ship it to
    /// every queued peer. On timeout / failure, ship the pre-existing file so a
    /// waiting joiner is never left hanging.</summary>
    private static void PumpForcedCapture()
    {
        if (_captureTask == null) return;

        bool done;
        try { done = _captureTask.IsCompleted; }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[SaveTransfer] capture task poll threw: {ex.Message} — falling back to the existing save.");
            FinishCapture(useCaptured: false);
            return;
        }

        if (!done)
        {
            if (UnityEngine.Time.unscaledTime - _captureStartedAt > CAPTURE_TIMEOUT_S)
            {
                Plugin.Log.LogWarning(
                    $"[SaveTransfer] forced capture did not finish within {CAPTURE_TIMEOUT_S:F0} s — " +
                    "shipping the existing save instead.");
                FinishCapture(useCaptured: false);
            }
            return;
        }

        bool ok = !string.IsNullOrEmpty(_capturePath) && File.Exists(_capturePath);
        if (!ok)
            Plugin.Log.LogWarning($"[SaveTransfer] forced capture completed but '{_capturePath}' is missing — shipping the existing save.");
        FinishCapture(useCaptured: ok);
    }

    private static void FinishCapture(bool useCaptured)
    {
        if (useCaptured)
        {
            HostSavePath = _capturePath;
            HostSavePathIsFresh = true;
            Plugin.Log.LogInfo(
                $"[SaveTransfer] forced capture complete → '{_capturePath}' " +
                $"({new FileInfo(_capturePath).Length} bytes); shipping to {_awaitingCapture.Count} peer(s).");
        }

        // Clear the in-flight state BEFORE shipping: SendSaveToPeer re-enters
        // this class and must not see a capture as still running (it would
        // re-queue the peer we're about to ship to and stall forever).
        _captureTask = null;
        _capturePath = null;

        var waiting = _awaitingCapture.ToArray();
        _awaitingCapture.Clear();
        for (int i = 0; i < waiting.Length; i++)
        {
            var peer = waiting[i];
            if (peer == null || !IsPeerStillConnected(peer)) continue;
            // allowForcedCapture:false — see the param doc on SendSaveToPeer.
            if (!SendSaveToPeer(peer, allowForcedCapture: false))
            {
                Plugin.Log.LogWarning(
                    $"[SaveTransfer] could not ship the save to {peer.DisplayName} after the capture — " +
                    "that peer has no world source and will need to rejoin.");
            }
        }
    }

    /// <summary>True while <paramref name="peer"/> is still in the host's
    /// client roster. Plain index loop rather than LINQ: this runs per pending
    /// transfer per frame, and the roster is 1–3 entries.</summary>
    private static bool IsPeerStillConnected(SteamPeer peer)
    {
        var clients = NetworkManager.Clients;
        for (int i = 0; i < clients.Count; i++)
            if (ReferenceEquals(clients[i], peer)) return true;
        return false;
    }

    public static void PumpPendingTransfers()
    {
        // Poll the forced capture FIRST and before the empty-queue early-out —
        // while a capture is in flight there is by definition nothing in
        // _pending yet, so an early return would never let it complete.
        PumpForcedCapture();

        if (_pending.Count == 0) return;

        float now = UnityEngine.Time.unscaledTime;

        for (int i = _pending.Count - 1; i >= 0; i--)
        {
            var p = _pending[i];
            if (p.Peer == null) { _pending.RemoveAt(i); continue; }

            // Peer still in the session? Without this a peer that disconnected
            // mid-transfer keeps "receiving" chunks every frame forever while
            // its entry pins a multi-MB byte[]. SteamPeer stays non-null after
            // a disconnect, so the null check above does not cover this.
            if (!IsPeerStillConnected(p.Peer))
            {
                Plugin.Log.LogInfo(
                    $"[SaveTransfer] peer {p.PeerSteamId} left mid-transfer at " +
                    $"{p.Cursor}/{p.SaveLen} B — dropping transfer.");
                _pending.RemoveAt(i);
                continue;
            }

            // Backoff after a rejected send (see below).
            if (now < p.NextAttemptAt) continue;

            try
            {
                int sentThisFrame = 0;
                // Cleared by the first rejected send this frame. A rejected
                // chunk must be RE-SENT, not skipped: Steam drops the message
                // outright when its send buffer is saturated, and a hole in the
                // stream surfaces only as a SHA-256 mismatch after the whole
                // multi-MB transfer has completed.
                bool accepted = true;

                // ── Header chunk (chunk 0) ───────────────────────────────
                if (p.NextChunkIndex == 0)
                {
                    _sendScratch.Reset();
                    _sendScratch.Put((uint)p.SaveLen);
                    _sendScratch.Put(p.TotalChunks);
                    _sendScratch.Put(p.Sha256, 0, 32);
                    if (NetworkManager.SendTo(p.Peer, PacketType.SaveTransferHeader, _sendScratch, DeliveryMethod.ReliableOrdered))
                    {
                        p.NextChunkIndex = 1;
                        sentThisFrame += 32; // header is tiny; negligible against the budget
                        p.LastProgressAt = now;
                    }
                    else
                    {
                        // Retry the header next attempt — data chunks must
                        // never precede it.
                        accepted = false;
                    }
                }

                // ── Data chunks ──────────────────────────────────────────
                while (accepted && p.Cursor < p.SaveLen && sentThisFrame < MAX_CHUNK_BYTES_PER_FRAME)
                {
                    int remaining = p.SaveLen - p.Cursor;
                    int chunkLen = Math.Min(CHUNK_SIZE, remaining);

                    _sendScratch.Reset();
                    _sendScratch.Put(p.NextChunkIndex);
                    _sendScratch.Put((ushort)chunkLen);
                    _sendScratch.Put(p.SaveBytes, p.Cursor, chunkLen);

                    if (!NetworkManager.SendTo(p.Peer, PacketType.SaveTransferChunk, _sendScratch, DeliveryMethod.ReliableOrdered))
                    {
                        accepted = false;
                        break;   // cursor deliberately NOT advanced
                    }

                    p.Cursor += chunkLen;
                    p.NextChunkIndex++;
                    sentThisFrame += chunkLen;
                    p.LastProgressAt = now;
                }

                // Back off on rejection so a saturated buffer isn't hammered
                // (and warning-spammed) every single frame.
                if (!accepted) p.NextAttemptAt = now + SEND_BACKOFF_S;

                _pending[i] = p;

                if (p.Cursor >= p.SaveLen)
                {
                    float elapsedMs = (now - p.EnqueuedAt) * 1000f;
                    Plugin.Log.LogInfo(
                        $"[SaveTransfer] all {p.TotalChunks} chunks sent to {p.Peer.DisplayName} " +
                        $"({p.SaveLen} bytes, {elapsedMs:F0} ms drain) — awaiting client load + ACK.");
                    LastPushedSha256Hex = BitConverter.ToString(p.Sha256).Replace("-", "").ToLowerInvariant();
                    _pending.RemoveAt(i);
                    continue;
                }

                if (now - p.LastProgressAt > STALL_TIMEOUT_S)
                {
                    Plugin.Log.LogError(
                        $"[SaveTransfer] transfer to {p.Peer.DisplayName} STALLED at " +
                        $"{p.Cursor}/{p.SaveLen} B for {STALL_TIMEOUT_S:F0} s — aborting. " +
                        "The client will not load the host's save; they must rejoin.");
                    _pending.RemoveAt(i);
                }
            }
            catch (Exception ex)
            {
                Plugin.Log.LogError($"[SaveTransfer] PumpPendingTransfers: {ex.Message}");
                _pending.RemoveAt(i);
            }
        }
    }

    // ════════════════════════════════════════════════════════════════════
    // Client side
    // ════════════════════════════════════════════════════════════════════

    /// <summary>Handle <see cref="PacketType.SaveTransferHeader"/>: read
    /// the expected save size + total chunks + SHA-256, and initialise the
    /// reassembly buffer.</summary>
    public static void HandleHeader(NetDataReader r, int senderId)
    {
        try
        {
            uint saveSize = r.GetUInt();
            ushort totalChunks = r.GetUShort();
            byte[] sha = new byte[32];
            for (int i = 0; i < 32; i++) sha[i] = r.GetByte();

            // Refuse an implausible announced size before allocating anything.
            // A zero size can never complete (nothing to reassemble), and an
            // over-cap size from a corrupt header or a hostile peer would have
            // us grow the reassembly buffer until the process dies.
            if (saveSize == 0 || saveSize > MAX_SAVE_BYTES || totalChunks == 0)
            {
                Plugin.Log.LogError(
                    $"[SaveTransfer] header rejected: saveSize={saveSize} totalChunks={totalChunks} " +
                    $"(cap {MAX_SAVE_BYTES} bytes). No reassembly started.");
                ResetReassembly();
                return;
            }

            // Warn if a previous transfer was still mid-reassembly — its
            // buffered bytes are about to be discarded by the SetLength(0)
            // below. ReliableOrdered shouldn't reorder, so this only happens
            // if the host sent a second header before the first stream
            // completed (e.g. a rapid save → re-save cycle). The new stream
            // wins; the partial old one is dropped.
            if (_expectedChunks > 0 && _receivedChunks < _expectedChunks)
            {
                Plugin.Log.LogWarning(
                    $"[SaveTransfer] new header received while previous transfer incomplete " +
                    $"({_receivedChunks}/{_expectedChunks} chunks) - discarding partial buffer.");
            }

            // (Re)initialise reassembly state. MemoryStream keeps its grown
            // capacity across transfers, avoiding a fresh multi-MB alloc
            // per join / re-sync.
            if (_reassemblyStream == null) _reassemblyStream = new MemoryStream();
            else _reassemblyStream.SetLength(0);

            _expectedSaveSize = (int)saveSize;
            _expectedSha256 = sha;
            _expectedChunks = totalChunks;
            _receivedChunks = 0;
            _transferStartedAt = UnityEngine.Time.unscaledTime;

            Plugin.Log.LogInfo(
                $"[SaveTransfer] header received: {saveSize} bytes ({saveSize / 1024.0:F1} KB), " +
                $"{totalChunks} chunks, sha256={BitConverter.ToString(sha).Replace("-", "").Substring(0, 16)}… — buffering.");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SaveTransfer] HandleHeader: {ex.Message}");
        }
    }

    /// <summary>Handle <see cref="PacketType.SaveTransferChunk"/>: append the
    /// chunk body to the reassembly buffer. When the announced total chunk
    /// count is reached, verify SHA-256, write the file to disk, and kick
    /// off SoD's Load Game path.</summary>
    public static void HandleChunk(NetDataReader r, int senderId)
    {
        if (_reassemblyStream == null || _expectedSha256 == null || _expectedSaveSize <= 0)
        {
            Plugin.Log.LogWarning("[SaveTransfer] data chunk with no active reassembly — dropping.");
            return;
        }

        try
        {
            ushort chunkIndex = r.GetUShort();
            ushort chunkLen = r.GetUShort();
            if (chunkLen <= 0) return;

            // Bounds-check against the reader's logical size (LiteNetLib
            // reuses oversized receive buffers).
            if (chunkLen > r.AvailableBytes)
            {
                Plugin.Log.LogWarning($"[SaveTransfer] chunk {chunkIndex} truncated: chunkLen={chunkLen} > available={r.AvailableBytes}");
                return;
            }

            // Refuse to buffer past the size the header announced. Without
            // this the stream grows on whatever the sender chooses to send —
            // a peer that announces 1 KB and then streams 500 MB takes the
            // client out with an OOM. The SHA-256 check at the end would catch
            // the corruption, but only after the damage.
            if (_reassemblyStream.Length + chunkLen > _expectedSaveSize)
            {
                Plugin.Log.LogError(
                    $"[SaveTransfer] overrun: have {_reassemblyStream.Length} B + {chunkLen} B exceeds " +
                    $"announced {_expectedSaveSize} B — aborting reassembly.");
                ResetReassembly();
                return;
            }

            // Append raw bytes to the reassembly stream. Write() handles
            // capacity growth automatically.
            _reassemblyStream.Write(r.RawData, r.Position, chunkLen);
            r.SkipBytes(chunkLen);
            _receivedChunks++;

            // Byte-driven completion. The chunk COUNT is only a diagnostic:
            // basing the test on it means a duplicate or short chunk silently
            // finalises a partial buffer.
            if (_reassemblyStream.Length >= _expectedSaveSize)
            {
                FinalizeAndLoad();
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SaveTransfer] HandleChunk: {ex.Message}");
        }
    }

    /// <summary>Reassembly complete: verify SHA-256, write the save file to
    /// a temp path under <see cref="UnityEngine.Application.persistentDataPath"/>,
    /// apply tutorial suppression, and invoke SoD's Load Game pipeline.</summary>
    private static void FinalizeAndLoad()
    {
        byte[] saveBytes = _reassemblyStream.ToArray();
        int receivedLen = saveBytes.Length;
        byte[] expectedSha = _expectedSha256;
        int expectedSize = _expectedSaveSize;
        ushort chunks = (ushort)_receivedChunks;
        float elapsedMs = (UnityEngine.Time.unscaledTime - _transferStartedAt) * 1000f;

        // Reset reassembly state so a subsequent header starts clean — and so
        // no completion predicate stays satisfied while the (long) load below
        // runs.
        ResetReassembly();

        Plugin.Log.LogInfo(
            $"[SaveTransfer] reassembled {receivedLen} bytes ({chunks} chunks, {elapsedMs:F0} ms) — verifying hash.");

        if (receivedLen != expectedSize)
        {
            Plugin.Log.LogError($"[SaveTransfer] size mismatch: received {receivedLen}, expected {expectedSize} — aborting load.");
            return;
        }

        // Verify SHA-256. A mismatch means corruption (ReliableOrdered
        // shouldn't lose bytes, but a version-mismatched or malicious peer
        // could send garbage). Abort rather than load a corrupt save.
        byte[] actualSha;
        using (var sha256 = SHA256.Create())
            actualSha = sha256.ComputeHash(saveBytes);
        bool hashOk = true;
        for (int i = 0; i < 32; i++)
        {
            if (actualSha[i] != expectedSha[i]) { hashOk = false; break; }
        }
        if (!hashOk)
        {
            Plugin.Log.LogError("[SaveTransfer] SHA-256 mismatch — aborting load (corruption or version skew).");
            return;
        }

        // Write the save to a temp file in SoD's persistent data path so
        // MainMenuController.LoadCityInfo can find it. Use a distinctive
        // name so we can clean it up later and avoid colliding with the
        // player's own saves.
        string destPath;
        try
        {
            string dir = UnityEngine.Application.persistentDataPath;
            destPath = Path.Combine(dir, "sodcoop_hostsave.save");
            File.WriteAllBytes(destPath, saveBytes);
            Plugin.Log.LogInfo($"[SaveTransfer] wrote host save to '{destPath}' ({saveBytes.Length} bytes).");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SaveTransfer] failed to write save file: {ex.Message}");
            return;
        }

        // Determine first-join vs live re-sync by whether the world is
        // already up. A first-join runs on the main menu (IsWorldReady
        // false); a Phase 4 re-sync arrives while the client is IN GAME
        // (IsWorldReady true) and must reload via the same LoadGame path.
        bool isResync = SoDCoop.Sync.WorldReadyGate.IsWorldReady;

        // Phase 4 auto-accept gate. On first-join we always load (the client
        // is on the main menu, nothing to lose). On resync, respect the
        // user's SaveTransferAutoAccept setting — a player who set it false
        // wants a confirmation before the host's save overwrites their
        // in-progress world. TODO: surface a real UI dialog; for now we
        // honour the config flag and skip silently when false (logged).
        if (isResync && CoopSettings.SaveTransferAutoAccept?.Value == false)
        {
            Plugin.Log.LogInfo(
                "[SaveTransfer] live re-sync received but SaveTransferAutoAccept=false — skipping reload " +
                "(set [Networking] SaveTransferAutoAccept=true to accept automatically).");
            return;
        }

        // Apply tutorial suppression + arm the WorldReady handler BEFORE
        // kicking off the load (CityConstructor may fire OnGameStart
        // synchronously inside LoadGame on fast machines). allowReload=true
        // on resync so the IsWorldReady guard in BeginSaveTransferLoad
        // doesn't refuse the reload.
        if (!WorldAutoLoad.BeginSaveTransferLoad(allowReload: isResync))
        {
            Plugin.Log.LogError("[SaveTransfer] BeginSaveTransferLoad failed — aborting LoadGame (world may already be loaded?).");
            return;
        }

        // Drive SoD's Load Game pipeline. LoadCityInfo populates
        // MainMenuController.selectedSave from the FileInfo; LoadGame then
        // runs CityConstructor.LoadSaveGame() which reads that path. This
        // is the exact path a user walks when clicking a save in the list.
        try
        {
            var mmc = global::MainMenuController.Instance;
            if (mmc == null)
            {
                Plugin.Log.LogError("[SaveTransfer] MainMenuController.Instance is null — cannot trigger LoadGame. Joiner will sit on main menu.");
                return;
            }

            // LoadCityInfo takes an Il2CppSystem.IO.FileInfo (the IL2CPP-
            // projected mirror of System.IO.FileInfo), not the managed type.
            // Construct the Il2Cpp variant — its ctor accepts a string path
            // the same way the managed one does.
            var fi = new Il2CppSystem.IO.FileInfo(destPath);
            mmc.LoadCityInfo(fi);
            Plugin.Log.LogInfo($"[SaveTransfer] LoadCityInfo('{destPath}') — selectedSave populated.");

            mmc.LoadGame();
            Plugin.Log.LogInfo(
                $"[SaveTransfer] LoadGame() invoked ({(isResync ? "live re-sync" : "first-join")}) — " +
                "SoD loading screen should take over.");

            // ACK to host: transfer landed, load started. Host uses this to
            // confirm the save-transfer path completed (vs silently failing
            // and the joiner never reaching ClientWorldReady).
            try
            {
                var w = new NetDataWriter();
                NetworkManager.SendToHost(PacketType.SaveTransferComplete, w);
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[SaveTransfer] failed to send Complete ACK: {ex.Message}"); }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SaveTransfer] LoadGame invocation failed: {ex.Message}");
        }
    }

    /// <summary>Handle <see cref="PacketType.SaveTransferComplete"/> (host
    /// side): the client received the save and started loading. Currently
    /// informational; Phase 4 live re-sync will use it to confirm a re-push
    /// was accepted rather than silently dropped.</summary>
    public static void HandleComplete(NetDataReader r, int senderId)
    {
        Plugin.Log.LogInfo($"[SaveTransfer] client {senderId} ACKed save transfer + started load.");

        // This ACK means "I have begun LoadGame" — the client is about to spend
        // 30-110 s with no world at all. Suspend live traffic to it until its
        // post-reload ClientWorldReady triggers a fresh snapshot, which re-arms
        // the flag. Without this the host keeps streaming deltas, ZDO events,
        // ownership transfers and citizen positions at a peer that cannot apply
        // any of them — wasted host main-thread serialise plus a reliable-channel
        // head-of-line stall, i.e. exactly the failure the WorldReady gate was
        // introduced to fix, reintroduced through the live re-sync path.
        try { NetworkManager.MarkPeerWorldNotReady(senderId, "save-transfer reload started"); }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SaveTransfer] HandleComplete: {ex.Message}"); }
    }

    /// <summary>Drop all in-flight state. Called on disconnect / world
    /// unload so a half-shipped transfer doesn't leak across sessions.
    /// Also clears <see cref="LastPushedSha256Hex"/> so a reconnect's first
    /// resync isn't incorrectly skipped against a stale hash.</summary>
    public static void Reset()
    {
        _pending.Clear();
        ResetReassembly();
        LastPushedSha256Hex = null;
        // Abandon any in-flight forced capture. The Task itself keeps running
        // inside SoD — we simply stop waiting on it and drop the peers that
        // were queued behind it (they belong to the session being torn down).
        _captureTask = null;
        _capturePath = null;
        _awaitingCapture.Clear();
    }

    /// <summary>Drop the CLIENT-side reassembly state only, leaving host-side
    /// queue state untouched. Separate from <see cref="Reset"/> because the
    /// receive handlers must be able to abandon a bad stream without also
    /// clearing <see cref="LastPushedSha256Hex"/> and the pending-send queue,
    /// which belong to the host role.</summary>
    private static void ResetReassembly()
    {
        _reassemblyStream?.SetLength(0);
        _expectedSha256 = null;
        _expectedSaveSize = 0;
        _expectedChunks = 0;
        _receivedChunks = 0;
    }
}
