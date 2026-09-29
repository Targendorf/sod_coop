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
/// Save-Transfer bootstrap: the host ships its world to a joining client via a
/// chunked reliable stream, and the client loads it through SoD's normal
/// Load Game path. This replaces the share-code city-regeneration pipeline
/// (<c>WorldAutoLoad.TriggerSoDGeneration</c>) when the host's
/// <c>CoopSettings.WorldBootstrap</c> is <c>SaveTransfer</c> and the client
/// advertised support in its bootstrap packet.
///
/// <para><b>Why:</b> the share-code path regenerates the city from a seed at
/// its INITIAL state, so the joiner's world starts at day one — no murders,
/// no moved items, a different clock — and only the handful of ZDO-tracked
/// keys get layered on top. Shipping the host's actual save makes the two
/// worlds identical by construction.</para>
///
/// <para><b>What is shipped (2026-09-29):</b></para>
/// <list type="bullet">
///   <item><description><b>A fresh capture of the live world</b>, taken the
///   moment the peer joins (<c>CoopSettings.SaveTransferCaptureOnJoin</c>,
///   default on) — not the host's last save/load, which could be hours of play
///   behind. The July playtest never exercised this path at all: the host had
///   neither saved nor loaded, so every join fell back to share-code.</description></item>
///   <item><description><b>The city file</b> (<c>Cities/&lt;shareCode&gt;.citb</c>
///   plus its <c>.txt</c> info) when the client does not already have an
///   identical copy. A SoD save only holds the STATE of a city; the city itself
///   is a separate file the save refers to by share code. A joiner who never
///   played that city has nothing to load the save into.</description></item>
/// </list>
///
/// <para><b>Wire format</b> (all ReliableOrdered):
/// <list type="bullet">
///   <item><description><see cref="PacketType.SaveTransferHeader"/> (host→client):
///   <c>uint size + ushort totalChunks + byte[32] sha256</c>, then trailing
///   <c>byte kind + string fileName</c> (kind 0 = save to load, 1 = file for
///   the Cities folder).</description></item>
///   <item><description><see cref="PacketType.SaveTransferChunk"/> (host→client):
///   <c>ushort chunkIndex + ushort chunkLen + byte[chunkLen]</c>.</description></item>
///   <item><description><see cref="PacketType.SaveTransferComplete"/> (client→host):
///   empty. Sent after the save verified and <c>LoadGame()</c> was invoked.</description></item>
/// </list>
/// City files always precede the save on the same ordered channel, so by the
/// time the save completes the city it needs is on disk.</para>
///
/// <para>Single-threaded (Unity main). A peer is either host or client, never
/// both, so the static state below is safe.</para>
/// </summary>
public static class SaveTransfer
{
    // ── Tunables ────────────────────────────────────────────────────────

    /// <summary>Raw chunk size per <see cref="PacketType.SaveTransferChunk"/>.</summary>
    private const int CHUNK_SIZE = 32 * 1024;

    /// <summary>Max bytes shipped per frame per pending transfer. 128 KB/frame
    /// at 60 fps = ~7.5 MB/s — a multi-MB save plus a ~10 MB city file drain in
    /// a couple of seconds while per-frame main-thread cost stays small.</summary>
    private const int MAX_CHUNK_BYTES_PER_FRAME = 128 * 1024;

    /// <summary>Header kind: the save the client must load.</summary>
    private const byte KIND_SAVE = 0;
    /// <summary>Header kind: a file for the client's <c>Cities</c> folder.</summary>
    private const byte KIND_CITY = 1;

    // ── Host-side pending transfer state ────────────────────────────────

    private struct PendingTransfer
    {
        public SteamPeer Peer;
        public byte[] Bytes;
        public int Len;
        public byte[] Sha256;
        public int Cursor;
        public ushort NextChunkIndex;
        public ushort TotalChunks;
        public ulong PeerSteamId;
        public float EnqueuedAt;
        public byte Kind;
        public string FileName;
        /// <summary>Wall-clock of the last frame on which the transport
        /// accepted at least one byte. Drives <see cref="STALL_TIMEOUT_S"/>.</summary>
        public float LastProgressAt;
        /// <summary>Earliest time the next send attempt may run. Set on a
        /// rejected send so we back off instead of hammering a saturated send
        /// buffer every frame.</summary>
        public float NextAttemptAt;
    }

    /// <summary>Abort a transfer that has made zero forward progress for this
    /// long. Only a dead peer or a permanently wedged send buffer trips it.</summary>
    private const float STALL_TIMEOUT_S = 60f;

    /// <summary>Backoff applied after the transport rejects a chunk.</summary>
    private const float SEND_BACKOFF_S = 0.25f;

    /// <summary>Sanity cap on an announced file size. Saves are single-digit MB
    /// and city files ~15 MB; 256 MB still refuses a corrupt or hostile header
    /// that would otherwise grow the reassembly buffer until the process dies.</summary>
    private const int MAX_SAVE_BYTES = 256 * 1024 * 1024;

    /// <summary>Host-side queue of in-flight transfers, drained chunk-by-chunk
    /// per frame by <see cref="PumpPendingTransfers"/>. Strictly FIFO per
    /// peer: a peer's city files are enqueued before its save.</summary>
    private static readonly List<PendingTransfer> _pending = new();

    private static readonly NetDataWriter _sendScratch = new();

    // ── Client-side reassembly state ────────────────────────────────────

    private static MemoryStream _reassemblyStream;
    private static byte[] _expectedSha256;
    private static int _expectedSaveSize;
    private static ushort _expectedChunks;
    private static int _receivedChunks;
    private static float _transferStartedAt;
    private static byte _expectedKind;
    private static string _expectedName;

    /// <summary>Set when this client declined a live re-sync. Acted on from
    /// <see cref="PumpPendingTransfers"/> rather than inside the packet handler
    /// that discovers it, so the disconnect never tears the transport down
    /// in the middle of its own receive loop.</summary>
    private static string _pendingDisconnectReason;

    // ════════════════════════════════════════════════════════════════════
    // Host side
    // ════════════════════════════════════════════════════════════════════

    /// <summary>Ship the host's world to <paramref name="peer"/>: city files the
    /// peer lacks, then the save. With <c>SaveTransferCaptureOnJoin</c> (the
    /// default) the save is a fresh capture of the live world taken now, and
    /// this returns true once the capture has STARTED — the transfer is
    /// enqueued when it lands, and a failed capture falls back to the existing
    /// file or, failing that, to share-code on its own.
    ///
    /// <para>Returns false only when nothing could be shipped synchronously;
    /// the caller then falls back to share-code.</para></summary>
    /// <param name="allowForcedCapture">False suppresses the capture.
    /// <see cref="FinishCapture"/> passes false when it ships to the peers that
    /// were queued behind a capture: without it a capture that FAILED would
    /// start another capture for the same peer, and each failure would kick off
    /// the next one — an unbounded capture loop.</param>
    public static bool SendSaveToPeer(SteamPeer peer, bool allowForcedCapture = true)
    {
        if (peer == null) return false;
        if (!NetworkManager.IsHost) return false;

        // Capture FIRST, before looking for an existing file: a host on a
        // freshly generated city has no save at all, and that was precisely the
        // case that silently dropped every join to share-code.
        if (allowForcedCapture && CoopSettings.SaveTransferCaptureOnJoin?.Value != false)
        {
            if (BeginForcedCapture(peer)) return true;   // peer queued; ships when the capture lands
            Plugin.Log.LogWarning("[SaveTransfer] join-time capture could not start — shipping the existing save instead.");
        }

        string savePath = HostSavePath;
        if (string.IsNullOrEmpty(savePath) || !File.Exists(savePath))
        {
            Plugin.Log.LogWarning($"[SaveTransfer] no host save file to send (path='{savePath}') — falling back to share-code for {peer.DisplayName}.");
            return false;
        }

        if (!HostSavePathIsFresh)
        {
            Plugin.Log.LogInfo(
                $"[SaveTransfer] shipping '{Path.GetFileName(savePath)}', which came from a LOAD, not from the live world — " +
                "the joiner's base world will match that file and the ZDO snapshot will layer live state on top.");
        }

        byte[] saveBytes;
        try { saveBytes = File.ReadAllBytes(savePath); }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SaveTransfer] SendSaveToPeer failed reading '{savePath}': {ex.Message}");
            return false;
        }
        if (saveBytes.Length <= 0)
        {
            Plugin.Log.LogWarning($"[SaveTransfer] host save file is empty: '{savePath}'.");
            return false;
        }

        EnqueueCityFilesFor(peer);
        Enqueue(peer, saveBytes, Sha256Of(saveBytes), KIND_SAVE, Path.GetFileName(savePath));
        Plugin.Log.LogInfo(
            $"[SaveTransfer] enqueued save for {peer.DisplayName}: '{savePath}' {saveBytes.Length} bytes " +
            $"({saveBytes.Length / 1024.0:F1} KB).");
        return true;
    }

    /// <summary>The most recently observed host save file path, captured from
    /// SOD.Common's OnAfterSave and OnAfterLoad hooks (set by SodCommonBridge)
    /// and from our own join-time capture. Only the fallback source now: with
    /// <c>SaveTransferCaptureOnJoin</c> every join ships a fresh capture.</summary>
    public static string HostSavePath { get; set; }

    /// <summary>True when <see cref="HostSavePath"/> was written by a save this
    /// session, false when it came from a LOAD. Drives the host-facing log.</summary>
    public static bool HostSavePathIsFresh { get; set; }

    /// <summary>SHA-256 (hex) of the last save pushed to any peer.</summary>
    public static string LastPushedSha256Hex { get; internal set; }

    /// <summary>Host: the host just LOADED a save while peers are connected —
    /// its world was replaced underneath them. Push the loaded save (and any
    /// city file a peer lacks) to every client so they reload into the same
    /// world, and drop every transfer still shipping the world that no longer
    /// exists.
    ///
    /// <para><b>History:</b> this used to run from OnAfterSave, which had it
    /// backwards on both ends. A save does not change the world — clients were
    /// already in sync through the ZDO stream — yet every host save (manual or
    /// quick) threw every client into a 30-110 s reload that respawned them at
    /// the host's position. And SOD.Common raises OnAfterSave from a POSTFIX on
    /// the async <c>CaptureSaveStateAsync</c>, i.e. when the Task is handed
    /// back, before the file is written, so the push read the previous or a
    /// half-written file. Meanwhile a host LOAD, which really does replace the
    /// world, pushed nothing and left clients in the old one.</para></summary>
    /// <returns>Number of clients the re-sync was pushed to.</returns>
    public static int ResyncToAllClients()
    {
        if (!NetworkManager.IsHost) return 0;
        if (!NetworkManager.HasPeers) return 0;

        string savePath = HostSavePath;
        if (string.IsNullOrEmpty(savePath) || !File.Exists(savePath))
        {
            Plugin.Log.LogWarning("[SaveTransfer] ResyncToAllClients: no host save file — clients stay in the old world.");
            return 0;
        }

        byte[] saveBytes;
        try { saveBytes = File.ReadAllBytes(savePath); }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SaveTransfer] ResyncToAllClients: failed to read '{savePath}': {ex.Message}");
            return 0;
        }
        if (saveBytes.Length <= 0) return 0;

        // Anything still draining ships the world the host just left.
        if (_pending.Count > 0)
        {
            Plugin.Log.LogInfo($"[SaveTransfer] ResyncToAllClients: dropping {_pending.Count} in-flight transfer(s) of the previous world.");
            _pending.Clear();
        }

        byte[] sha = Sha256Of(saveBytes);
        var clients = NetworkManager.Clients;
        int pushed = 0;
        for (int i = 0; i < clients.Count; i++)
        {
            var peer = clients[i];
            if (peer == null) continue;
            NetworkManager.MarkPeerWorldNotReady(peer, "host loaded a save — re-syncing");
            EnqueueCityFilesFor(peer);
            Enqueue(peer, saveBytes, sha, KIND_SAVE, Path.GetFileName(savePath));
            pushed++;
        }

        if (pushed > 0)
        {
            Plugin.Log.LogInfo(
                $"[SaveTransfer] ResyncToAllClients: host loaded '{Path.GetFileName(savePath)}' — pushed it to {pushed} client(s) " +
                $"({saveBytes.Length} bytes).");
        }
        return pushed;
    }

    private static byte[] Sha256Of(byte[] bytes)
    {
        using var sha256 = SHA256.Create();
        return sha256.ComputeHash(bytes);
    }

    private static void Enqueue(SteamPeer peer, byte[] bytes, byte[] sha, byte kind, string fileName)
    {
        int dataChunks = (bytes.Length + CHUNK_SIZE - 1) / CHUNK_SIZE;
        float now = UnityEngine.Time.unscaledTime;
        _pending.Add(new PendingTransfer
        {
            Peer           = peer,
            Bytes          = bytes,
            Len            = bytes.Length,
            Sha256         = sha,
            Cursor         = 0,
            NextChunkIndex = 0,
            TotalChunks    = (ushort)Math.Min(ushort.MaxValue, dataChunks),
            PeerSteamId    = peer.SteamId.m_SteamID,
            EnqueuedAt     = now,
            Kind           = kind,
            FileName       = fileName ?? "",
            LastProgressAt = now,
            NextAttemptAt  = 0f,
        });
    }

    // ── City files ──────────────────────────────────────────────────────

    /// <summary>Enqueue the host's city file (and its <c>.txt</c> info) for
    /// <paramref name="peer"/> unless the peer advertised an identical copy
    /// (same name and size) at bootstrap.</summary>
    private static void EnqueueCityFilesFor(SteamPeer peer)
    {
        try
        {
            var files = FindHostCityFiles();
            if (files.Count == 0)
            {
                Plugin.Log.LogWarning(
                    "[SaveTransfer] host city file not found under Cities/ — the joiner must already have this city, " +
                    "or its load of the save will fail.");
                return;
            }

            int peerId = NetworkManager.GetPlayerIdByPeer(peer);
            PlayerNetInfo info = null;
            if (peerId >= 0) NetworkManager.Players?.TryGetValue(peerId, out info);

            for (int i = 0; i < files.Count; i++)
            {
                var fi = new FileInfo(files[i]);
                if (info?.KnownCityFiles != null
                    && info.KnownCityFiles.TryGetValue(fi.Name, out long theirSize)
                    && theirSize == fi.Length)
                {
                    Plugin.Log.LogInfo($"[SaveTransfer] {peer.DisplayName} already has '{fi.Name}' — not shipping it.");
                    continue;
                }
                byte[] bytes = File.ReadAllBytes(fi.FullName);
                if (bytes.Length <= 0) continue;
                Enqueue(peer, bytes, Sha256Of(bytes), KIND_CITY, fi.Name);
                Plugin.Log.LogInfo($"[SaveTransfer] enqueued city file '{fi.Name}' ({bytes.Length / 1024.0:F1} KB) for {peer.DisplayName}.");
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SaveTransfer] city file for {peer?.DisplayName}: {ex.Message}"); }
    }

    /// <summary>The host's city file(s): <c>Cities/&lt;shareCode&gt;.citb|.cit</c>
    /// and the matching <c>.txt</c>. SoD names a city file after its share code
    /// (e.g. <c>Vietnam.1.4104.SfTh5mUh16yzIwcf.citb</c>).</summary>
    private static List<string> FindHostCityFiles()
    {
        var result = new List<string>(2);
        string dir = CitiesDirectory();
        if (!Directory.Exists(dir)) return result;

        string shareCode = null;
        try
        {
            var city = global::CityData.Instance;
            var tb = global::Toolbox.Instance;
            if (city != null && tb != null)
            {
                string version = !string.IsNullOrEmpty(city.cityBuiltWith) ? city.cityBuiltWith : UnityEngine.Application.version;
                shareCode = tb.GetShareCode(city.cityName ?? "", (int)city.citySize.x, (int)city.citySize.y, version, city.seed ?? "");
            }
        }
        catch { }
        if (string.IsNullOrEmpty(shareCode)) return result;

        foreach (var ext in new[] { ".citb", ".cit" })
        {
            string p = Path.Combine(dir, shareCode + ext);
            if (File.Exists(p)) { result.Add(p); break; }
        }
        if (result.Count == 0) return result;

        string txt = Path.Combine(dir, shareCode + ".txt");
        if (File.Exists(txt)) result.Add(txt);
        return result;
    }

    private static string CitiesDirectory() => Path.Combine(UnityEngine.Application.persistentDataPath, "Cities");
    private static string SavesDirectory()  => Path.Combine(UnityEngine.Application.persistentDataPath, "Save");

    /// <summary>Client: the files in our Cities folder, written into the
    /// bootstrap packet so the host can skip shipping a city we already have.
    /// Format: <c>ushort count</c> then <c>count × (string name, long size)</c>.</summary>
    public static void WriteKnownCityFiles(NetDataWriter w)
    {
        var names = new List<(string, long)>();
        try
        {
            var dir = new DirectoryInfo(CitiesDirectory());
            if (dir.Exists)
            {
                foreach (var f in dir.GetFiles())
                {
                    string ext = f.Extension.ToLowerInvariant();
                    if (ext != ".cit" && ext != ".citb" && ext != ".txt") continue;
                    names.Add((f.Name, f.Length));
                    if (names.Count >= 256) break;
                }
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SaveTransfer] listing Cities/: {ex.Message}"); }

        w.Put((ushort)names.Count);
        foreach (var (name, size) in names) { w.Put(name); w.Put(size); }
    }

    /// <summary>Host: read what <see cref="WriteKnownCityFiles"/> wrote.
    /// Tolerates an older client that wrote nothing.</summary>
    public static Dictionary<string, long> ReadKnownCityFiles(NetDataReader r)
    {
        var map = new Dictionary<string, long>(StringComparer.OrdinalIgnoreCase);
        try
        {
            if (r.AvailableBytes < 2) return map;
            int n = r.GetUShort();
            for (int i = 0; i < n && i < 256; i++)
            {
                if (r.AvailableBytes < 4) break;
                string name = r.GetString();
                if (r.AvailableBytes < 8) break;
                long size = r.GetLong();
                if (!string.IsNullOrEmpty(name)) map[name] = size;
            }
        }
        catch { }
        return map;
    }

    // ── Join-time capture (host) ────────────────────────────────────────
    //
    // Peers that arrive while a capture is in flight are queued and shipped
    // when it completes. Completion is observed by polling the returned Task:
    // SOD.Common's OnAfterSave is a postfix on the async method, so it fires
    // when the Task is handed back — before the file is written — and cannot
    // be used as the "done" signal.
    //
    // The capture writes to a DEDICATED file, never over the player's saves.

    private static Il2CppSystem.Threading.Tasks.Task _captureTask;
    private static string _capturePath;
    private static float _captureStartedAt;
    private static readonly List<SteamPeer> _awaitingCapture = new();

    /// <summary>Give up on a capture that never completes and ship the existing
    /// file instead. Saves take a couple of seconds on a big city.</summary>
    private const float CAPTURE_TIMEOUT_S = 30f;

    /// <summary>Base name of the capture under <c>Application.persistentDataPath</c>.
    /// It MUST end in <c>.sod</c>: SoD's saver appends a <c>b</c> when save
    /// compression is on (SOD.Common documents the same), so the file on disk is
    /// <c>.sod</c> or <c>.sodb</c>. The old <c>.save</c> name would have been
    /// written somewhere the completion check never looked.</summary>
    private const string CAPTURE_FILENAME = "sodcoop_hostpush.sod";

    private static bool BeginForcedCapture(SteamPeer peer)
    {
        if (_captureTask != null)
        {
            if (!_awaitingCapture.Contains(peer)) _awaitingCapture.Add(peer);
            Plugin.Log.LogInfo($"[SaveTransfer] {peer.DisplayName} queued behind an in-flight capture.");
            return true;
        }

        try
        {
            var ssc = global::SaveStateController.Instance;
            if (ssc == null)
            {
                Plugin.Log.LogWarning("[SaveTransfer] SaveStateController.Instance is null — cannot capture.");
                return false;
            }

            string path = Path.Combine(UnityEngine.Application.persistentDataPath, CAPTURE_FILENAME);
            // A leftover from an earlier join must not be mistaken for this one.
            TryDelete(path);
            TryDelete(path + "b");

            var task = ssc.CaptureSaveStateAsync(path, true);
            if (task == null)
            {
                Plugin.Log.LogWarning("[SaveTransfer] CaptureSaveStateAsync returned null — cannot capture.");
                return false;
            }

            _captureTask = task;
            _capturePath = path;
            _captureStartedAt = UnityEngine.Time.unscaledTime;
            _awaitingCapture.Clear();
            _awaitingCapture.Add(peer);

            Plugin.Log.LogInfo($"[SaveTransfer] capturing the live world → '{path}' ({peer.DisplayName} waiting).");
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

    private static void TryDelete(string path)
    {
        try { if (File.Exists(path)) File.Delete(path); } catch { }
    }

    /// <summary>The file the capture actually produced: <c>.sodb</c> when
    /// compression is on, <c>.sod</c> otherwise. Null if neither exists.</summary>
    private static string ResolveCaptureOutput(string path)
    {
        if (string.IsNullOrEmpty(path)) return null;
        if (File.Exists(path + "b")) return path + "b";
        if (File.Exists(path)) return path;
        return null;
    }

    private static void PumpForcedCapture()
    {
        if (_captureTask == null) return;

        bool done;
        try { done = _captureTask.IsCompleted; }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[SaveTransfer] capture task poll threw: {ex.Message} — falling back to the existing save.");
            FinishCapture(null);
            return;
        }

        if (!done)
        {
            if (UnityEngine.Time.unscaledTime - _captureStartedAt > CAPTURE_TIMEOUT_S)
            {
                Plugin.Log.LogWarning(
                    $"[SaveTransfer] capture did not finish within {CAPTURE_TIMEOUT_S:F0} s — shipping the existing save instead.");
                FinishCapture(null);
            }
            return;
        }

        string output = ResolveCaptureOutput(_capturePath);
        if (output == null)
            Plugin.Log.LogWarning($"[SaveTransfer] capture completed but neither '{_capturePath}' nor its .sodb exists — shipping the existing save.");
        FinishCapture(output);
    }

    private static void FinishCapture(string capturedFile)
    {
        if (capturedFile != null)
        {
            HostSavePath = capturedFile;
            HostSavePathIsFresh = true;
            Plugin.Log.LogInfo(
                $"[SaveTransfer] capture complete → '{capturedFile}' ({new FileInfo(capturedFile).Length} bytes, " +
                $"{(UnityEngine.Time.unscaledTime - _captureStartedAt) * 1000f:F0} ms); shipping to {_awaitingCapture.Count} peer(s).");
        }

        // Clear the in-flight state BEFORE shipping: SendSaveToPeer re-enters
        // this class and must not see a capture as still running.
        _captureTask = null;
        _capturePath = null;

        var waiting = _awaitingCapture.ToArray();
        _awaitingCapture.Clear();
        for (int i = 0; i < waiting.Length; i++)
        {
            var peer = waiting[i];
            if (peer == null || !IsPeerStillConnected(peer)) continue;
            // allowForcedCapture:false — see the param doc on SendSaveToPeer.
            if (SendSaveToPeer(peer, allowForcedCapture: false)) continue;

            // Nothing to ship at all: the peer is sitting on its main menu
            // waiting for a world. Give it the share-code path rather than
            // leaving it there.
            Plugin.Log.LogWarning($"[SaveTransfer] no save to ship to {peer.DisplayName} — falling back to share-code.");
            try { NetworkManager.SendWorldDescriptorFallback(peer); }
            catch (Exception ex) { Plugin.Log.LogError($"[SaveTransfer] share-code fallback for {peer.DisplayName}: {ex.Message}"); }
        }
    }

    /// <summary>True while <paramref name="peer"/> is still in the host's
    /// client roster.</summary>
    private static bool IsPeerStillConnected(SteamPeer peer)
    {
        var clients = NetworkManager.Clients;
        for (int i = 0; i < clients.Count; i++)
            if (ReferenceEquals(clients[i], peer)) return true;
        return false;
    }

    /// <summary>Drain pending transfers chunk-by-chunk. Called once per frame
    /// from <c>CoopUpdateRunner.Update</c> on every peer. A peer's transfers are
    /// sent strictly in enqueue order (city files before the save): only the
    /// first pending entry per peer advances each frame.</summary>
    public static void PumpPendingTransfers()
    {
        if (_pendingDisconnectReason != null)
        {
            string reason = _pendingDisconnectReason;
            _pendingDisconnectReason = null;
            Plugin.Log.LogWarning($"[SaveTransfer] leaving the session: {reason}");
            try { NetworkManager.Disconnect(); } catch (Exception ex) { Plugin.Log.LogWarning($"[SaveTransfer] disconnect: {ex.Message}"); }
        }

        // Poll the capture FIRST and before the empty-queue early-out — while a
        // capture is in flight there is by definition nothing in _pending yet.
        PumpForcedCapture();

        if (_pending.Count == 0) return;

        float now = UnityEngine.Time.unscaledTime;
        var servedThisFrame = _servedScratch;
        servedThisFrame.Clear();

        for (int i = 0; i < _pending.Count; i++)
        {
            var p = _pending[i];
            if (p.Peer == null) { _pending.RemoveAt(i--); continue; }

            // One transfer per peer at a time, in order: the later entries for
            // this peer wait until this one has fully shipped.
            if (!servedThisFrame.Add(p.Peer)) continue;

            // SteamPeer stays non-null after a disconnect; without this a peer
            // that left keeps "receiving" chunks forever while its entry pins a
            // multi-MB byte[].
            if (!IsPeerStillConnected(p.Peer))
            {
                Plugin.Log.LogInfo($"[SaveTransfer] peer {p.PeerSteamId} left mid-transfer at {p.Cursor}/{p.Len} B — dropping its transfers.");
                DropTransfersFor(p.Peer);
                i = -1;   // list changed; restart the walk (peer is in the served set)
                continue;
            }

            if (now < p.NextAttemptAt) continue;

            try
            {
                int sentThisFrame = 0;
                // A rejected chunk must be RE-SENT, not skipped: Steam drops the
                // message outright when its send buffer is saturated, and a hole
                // surfaces only as a SHA-256 mismatch after the whole transfer.
                bool accepted = true;

                if (p.NextChunkIndex == 0)
                {
                    _sendScratch.Reset();
                    _sendScratch.Put((uint)p.Len);
                    _sendScratch.Put(p.TotalChunks);
                    _sendScratch.Put(p.Sha256, 0, 32);
                    _sendScratch.Put(p.Kind);
                    _sendScratch.Put(p.FileName ?? "");
                    if (NetworkManager.SendTo(p.Peer, PacketType.SaveTransferHeader, _sendScratch, DeliveryMethod.ReliableOrdered))
                    {
                        p.NextChunkIndex = 1;
                        p.LastProgressAt = now;
                    }
                    else accepted = false;
                }

                while (accepted && p.Cursor < p.Len && sentThisFrame < MAX_CHUNK_BYTES_PER_FRAME)
                {
                    int chunkLen = Math.Min(CHUNK_SIZE, p.Len - p.Cursor);
                    _sendScratch.Reset();
                    _sendScratch.Put(p.NextChunkIndex);
                    _sendScratch.Put((ushort)chunkLen);
                    _sendScratch.Put(p.Bytes, p.Cursor, chunkLen);

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

                if (!accepted) p.NextAttemptAt = now + SEND_BACKOFF_S;
                _pending[i] = p;

                if (p.Cursor >= p.Len)
                {
                    Plugin.Log.LogInfo(
                        $"[SaveTransfer] sent '{p.FileName}' ({(p.Kind == KIND_CITY ? "city file" : "save")}, {p.Len} bytes, " +
                        $"{p.TotalChunks} chunks, {(now - p.EnqueuedAt) * 1000f:F0} ms) to {p.Peer.DisplayName}" +
                        (p.Kind == KIND_SAVE ? " — awaiting client load + ACK." : "."));
                    if (p.Kind == KIND_SAVE)
                        LastPushedSha256Hex = BitConverter.ToString(p.Sha256).Replace("-", "").ToLowerInvariant();
                    _pending.RemoveAt(i--);
                    continue;
                }

                if (now - p.LastProgressAt > STALL_TIMEOUT_S)
                {
                    Plugin.Log.LogError(
                        $"[SaveTransfer] transfer of '{p.FileName}' to {p.Peer.DisplayName} STALLED at {p.Cursor}/{p.Len} B " +
                        $"for {STALL_TIMEOUT_S:F0} s — aborting. The client will not load the host's world; they must rejoin.");
                    DropTransfersFor(p.Peer);
                    i = -1;
                }
            }
            catch (Exception ex)
            {
                Plugin.Log.LogError($"[SaveTransfer] PumpPendingTransfers: {ex.Message}");
                DropTransfersFor(p.Peer);
                i = -1;
            }
        }
    }

    private static readonly HashSet<SteamPeer> _servedScratch = new();

    /// <summary>Drop every pending transfer for <paramref name="peer"/>. A city
    /// file without its save (or the reverse) is useless, so they go together.</summary>
    private static void DropTransfersFor(SteamPeer peer)
    {
        for (int i = _pending.Count - 1; i >= 0; i--)
            if (ReferenceEquals(_pending[i].Peer, peer)) _pending.RemoveAt(i);
    }

    // ════════════════════════════════════════════════════════════════════
    // Client side
    // ════════════════════════════════════════════════════════════════════

    /// <summary>Handle <see cref="PacketType.SaveTransferHeader"/>.</summary>
    public static void HandleHeader(NetDataReader r, int senderId)
    {
        try
        {
            uint saveSize = r.GetUInt();
            ushort totalChunks = r.GetUShort();
            byte[] sha = new byte[32];
            for (int i = 0; i < 32; i++) sha[i] = r.GetByte();
            byte kind = KIND_SAVE;
            string name = "";
            if (r.AvailableBytes >= 1) kind = r.GetByte();
            if (r.AvailableBytes >= 2) name = r.GetString() ?? "";

            if (saveSize == 0 || saveSize > MAX_SAVE_BYTES || totalChunks == 0)
            {
                Plugin.Log.LogError(
                    $"[SaveTransfer] header rejected: size={saveSize} totalChunks={totalChunks} " +
                    $"(cap {MAX_SAVE_BYTES} bytes). No reassembly started.");
                ResetReassembly();
                return;
            }

            if (_expectedChunks > 0 && _receivedChunks < _expectedChunks)
            {
                Plugin.Log.LogWarning(
                    $"[SaveTransfer] new header received while '{_expectedName}' was incomplete " +
                    $"({_receivedChunks}/{_expectedChunks} chunks) — discarding it.");
            }

            if (_reassemblyStream == null) _reassemblyStream = new MemoryStream();
            else _reassemblyStream.SetLength(0);

            _expectedSaveSize = (int)saveSize;
            _expectedSha256 = sha;
            _expectedChunks = totalChunks;
            _receivedChunks = 0;
            _expectedKind = kind;
            _expectedName = name;
            _transferStartedAt = UnityEngine.Time.unscaledTime;

            Plugin.Log.LogInfo(
                $"[SaveTransfer] header received: '{name}' ({(kind == KIND_CITY ? "city file" : "save")}) " +
                $"{saveSize} bytes ({saveSize / 1024.0:F1} KB), {totalChunks} chunks — buffering.");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SaveTransfer] HandleHeader: {ex.Message}");
        }
    }

    /// <summary>Handle <see cref="PacketType.SaveTransferChunk"/>.</summary>
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

            if (_reassemblyStream.Length + chunkLen > _expectedSaveSize)
            {
                Plugin.Log.LogError(
                    $"[SaveTransfer] overrun: have {_reassemblyStream.Length} B + {chunkLen} B exceeds " +
                    $"announced {_expectedSaveSize} B — aborting reassembly.");
                ResetReassembly();
                return;
            }

            _reassemblyStream.Write(r.RawData, r.Position, chunkLen);
            r.SkipBytes(chunkLen);
            _receivedChunks++;

            // Byte-driven completion: a duplicate or short chunk must never
            // finalise a partial buffer.
            if (_reassemblyStream.Length >= _expectedSaveSize)
                FinalizeTransfer();
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SaveTransfer] HandleChunk: {ex.Message}");
        }
    }

    /// <summary>Reassembly complete: verify, then either store a city file or
    /// write the save and load it.</summary>
    private static void FinalizeTransfer()
    {
        byte[] bytes = _reassemblyStream.ToArray();
        byte[] expectedSha = _expectedSha256;
        int expectedSize = _expectedSaveSize;
        byte kind = _expectedKind;
        string name = _expectedName;
        ushort chunks = (ushort)_receivedChunks;
        float elapsedMs = (UnityEngine.Time.unscaledTime - _transferStartedAt) * 1000f;

        // Reset first so no completion predicate stays satisfied while the
        // (long) load below runs.
        ResetReassembly();

        Plugin.Log.LogInfo($"[SaveTransfer] reassembled '{name}': {bytes.Length} bytes ({chunks} chunks, {elapsedMs:F0} ms) — verifying.");

        if (bytes.Length != expectedSize)
        {
            Plugin.Log.LogError($"[SaveTransfer] size mismatch: received {bytes.Length}, expected {expectedSize} — discarding '{name}'.");
            return;
        }

        byte[] actualSha = Sha256Of(bytes);
        for (int i = 0; i < 32; i++)
        {
            if (actualSha[i] != expectedSha[i])
            {
                Plugin.Log.LogError($"[SaveTransfer] SHA-256 mismatch — discarding '{name}' (corruption or version skew).");
                return;
            }
        }

        if (kind == KIND_CITY) StoreCityFile(name, bytes);
        else                   WriteAndLoadSave(bytes);
    }

    /// <summary>Write a host city file into our <c>Cities</c> folder, where the
    /// save that follows expects to find it.</summary>
    private static void StoreCityFile(string name, byte[] bytes)
    {
        // Never trust a path from the wire: bare file name, known extensions only.
        string safe = Path.GetFileName(name ?? "");
        string ext = Path.GetExtension(safe).ToLowerInvariant();
        if (string.IsNullOrEmpty(safe) || safe != name || (ext != ".cit" && ext != ".citb" && ext != ".txt"))
        {
            Plugin.Log.LogError($"[SaveTransfer] refusing city file with unexpected name '{name}'.");
            return;
        }

        try
        {
            string dir = CitiesDirectory();
            Directory.CreateDirectory(dir);
            string dest = Path.Combine(dir, safe);
            File.WriteAllBytes(dest, bytes);
            Plugin.Log.LogInfo($"[SaveTransfer] stored host city file '{dest}' ({bytes.Length} bytes).");
        }
        catch (Exception ex) { Plugin.Log.LogError($"[SaveTransfer] writing city file '{safe}': {ex.Message}"); }
    }

    /// <summary>Name of the save file the joiner loads. Lives in SoD's own Save
    /// folder with SoD's own extension, so the game treats it exactly like a
    /// save the player picked from the Load menu.</summary>
    private const string CLIENT_SAVE_BASENAME = "SoDCoop - host world";

    private static void WriteAndLoadSave(byte[] saveBytes)
    {
        // SoD picks the decoder by extension: .sod is plain JSON, .sodb is
        // compressed. Sniff instead of trusting the host's file name — the
        // capture's extension depends on the host's compression setting.
        string ext = LooksLikeJson(saveBytes) ? ".sod" : ".sodb";

        string destPath;
        try
        {
            string dir = SavesDirectory();
            Directory.CreateDirectory(dir);
            destPath = Path.Combine(dir, CLIENT_SAVE_BASENAME + ext);
            // Drop the other variant so the Load menu never shows two.
            TryDelete(Path.Combine(dir, CLIENT_SAVE_BASENAME + (ext == ".sod" ? ".sodb" : ".sod")));
            File.WriteAllBytes(destPath, saveBytes);
            Plugin.Log.LogInfo($"[SaveTransfer] wrote host save to '{destPath}' ({saveBytes.Length} bytes).");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SaveTransfer] failed to write save file: {ex.Message}");
            return;
        }

        // First join runs on the main menu (IsWorldReady false); a live re-sync
        // arrives while we are IN GAME.
        bool isResync = WorldReadyGate.IsWorldReady;

        if (isResync && CoopSettings.SaveTransferAutoAccept?.Value == false)
        {
            // Staying connected in the world the host just abandoned is a
            // guaranteed desync, so declining means leaving.
            _pendingDisconnectReason =
                "the host loaded a different save and SaveTransferAutoAccept=false declined the re-sync " +
                $"(the host's world is in '{destPath}' if you want it).";
            return;
        }

        if (!WorldAutoLoad.BeginSaveTransferLoad(allowReload: isResync))
        {
            Plugin.Log.LogError("[SaveTransfer] BeginSaveTransferLoad failed — not loading.");
            return;
        }

        if (!StartSaveLoad(destPath))
            return;

        Plugin.Log.LogInfo($"[SaveTransfer] LoadGame() invoked ({(isResync ? "live re-sync" : "first join")}) — SoD's loading screen should take over.");

        // ACK: the load started. The host suspends live traffic to us until our
        // post-load ClientWorldReady triggers a fresh snapshot.
        try { NetworkManager.SendToHost(PacketType.SaveTransferComplete, new NetDataWriter()); }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SaveTransfer] failed to send Complete ACK: {ex.Message}"); }
    }

    private static bool LooksLikeJson(byte[] b)
    {
        int i = 0;
        if (b.Length >= 3 && b[0] == 0xEF && b[1] == 0xBB && b[2] == 0xBF) i = 3;   // UTF-8 BOM
        for (; i < b.Length && i < 64; i++)
        {
            byte c = b[i];
            if (c == (byte)' ' || c == (byte)'\t' || c == (byte)'\r' || c == (byte)'\n') continue;
            return c == (byte)'{';
        }
        return false;
    }

    /// <summary>Hidden stand-in for the Load menu row the player would have
    /// clicked. Kept for the session; recreated if a scene change destroyed it.</summary>
    private static UnityEngine.GameObject _saveEntryGo;

    /// <summary>Drive SoD's Load Game exactly as the Load menu does: a selected
    /// <c>SaveGameEntryController</c> whose <c>info</c> is our file, then
    /// <c>MainMenuController.LoadGame()</c>.
    ///
    /// <para><b>What this replaced:</b> the old code called
    /// <c>LoadCityInfo(saveFile)</c> believing it set <c>selectedSave</c>. It
    /// does not — it is the NEW-GAME city picker, it fills
    /// <c>selectedCityInfoData</c> from a city info file. <c>LoadGame()</c>
    /// reads <c>selectedSave</c>, which was null (nothing loads) or whatever row
    /// the player last clicked (the joiner loads THEIR OWN save).</para></summary>
    private static bool StartSaveLoad(string path)
    {
        try
        {
            var mmc = global::MainMenuController.Instance;
            if (mmc == null)
            {
                Plugin.Log.LogError("[SaveTransfer] MainMenuController.Instance is null — cannot trigger LoadGame.");
                return false;
            }

            var fi = new Il2CppSystem.IO.FileInfo(path);

            global::SaveGameEntryController entry = null;
            try
            {
                if (_saveEntryGo == null)
                {
                    _saveEntryGo = new UnityEngine.GameObject("SoDCoop_HostSaveEntry");
                    // Inactive before AddComponent: the row's Awake/OnEnable
                    // expect menu UI we don't have, and never need to run.
                    _saveEntryGo.SetActive(false);
                    UnityEngine.Object.DontDestroyOnLoad(_saveEntryGo);
                }
                entry = _saveEntryGo.GetComponent<global::SaveGameEntryController>();
                if (entry == null) entry = _saveEntryGo.AddComponent<global::SaveGameEntryController>();
                if (entry != null) entry.info = fi;
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[SaveTransfer] building the save entry: {ex.Message}"); }

            if (entry != null)
            {
                // SelectNewSave also refreshes the menu's text for the row; that
                // part may throw without the UI, the selection is set below anyway.
                try { mmc.SelectNewSave(entry); } catch (Exception ex) { Plugin.Log.LogDebug($"[SaveTransfer] SelectNewSave: {ex.Message}"); }
                mmc.selectedSave = entry;
            }

            // Belt and braces: the fields CityConstructor.StartLoading reads for
            // a save load (SOD.Common reads the same ones to raise OnBeforeLoad).
            try
            {
                var rsc = global::RestartSafeController.Instance;
                if (rsc != null)
                {
                    rsc.saveStateFileInfo = fi;
                    rsc.loadSaveGame = true;
                    rsc.generateNew = false;
                    rsc.newGameLoadCity = false;
                }
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[SaveTransfer] RestartSafeController: {ex.Message}"); }

            mmc.LoadGame();
            return true;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SaveTransfer] LoadGame invocation failed: {ex.Message}");
            return false;
        }
    }

    /// <summary>Handle <see cref="PacketType.SaveTransferComplete"/> (host):
    /// the client began LoadGame and is about to spend 30-110 s with no world.
    /// Suspend live traffic to it until its post-load ClientWorldReady triggers
    /// a fresh snapshot, which re-arms the flag.</summary>
    public static void HandleComplete(NetDataReader r, int senderId)
    {
        Plugin.Log.LogInfo($"[SaveTransfer] client {senderId} ACKed the save + started loading.");
        try { NetworkManager.MarkPeerWorldNotReady(senderId, "save-transfer load started"); }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SaveTransfer] HandleComplete: {ex.Message}"); }
    }

    /// <summary>Drop all in-flight state. Called on disconnect.</summary>
    public static void Reset()
    {
        _pending.Clear();
        ResetReassembly();
        LastPushedSha256Hex = null;
        // Abandon any in-flight capture. The Task itself keeps running inside
        // SoD — we just stop waiting on it.
        _captureTask = null;
        _capturePath = null;
        _awaitingCapture.Clear();
    }

    /// <summary>Drop the CLIENT-side reassembly state only.</summary>
    private static void ResetReassembly()
    {
        _reassemblyStream?.SetLength(0);
        _expectedSha256 = null;
        _expectedSaveSize = 0;
        _expectedChunks = 0;
        _receivedChunks = 0;
        _expectedKind = KIND_SAVE;
        _expectedName = null;
    }
}
