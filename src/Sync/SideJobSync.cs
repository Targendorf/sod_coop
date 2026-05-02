using System;
using LiteNetLib;
using LiteNetLib.Utils;
using Il2CppInterop.Runtime;
using SoDCoop.Network;
using SoDCoop.UI;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Side-job sync (Phase SJ.2).
///
/// <para><b>Wire:</b> a single <see cref="SideJobUpsertPacket"/> carries the
/// full scalar state of a job, plus a <c>Kind</c> discriminator (Created /
/// Posted / Ended / Snapshot). Host broadcasts on ctor + state-change, and
/// also pushes a Snapshot of every active job to each freshly-joined client
/// so mid-session joiners catch up.</para>
///
/// <para><b>Client behaviour:</b> banner first (always works), then a
/// best-effort skeleton SideJob reconstruction via
/// <c>il2cpp_object_new</c>. The skeleton has scalar fields stamped, the
/// preset / poster / purp / case references resolved when possible, and
/// the dynamic List&lt;&gt; fields initialised to empty so reads don't NRE.
/// Many computed fields (chosenIntro, appliedBasicLeads contents, leadKeys)
/// remain unpopulated — corkboard rendering should work, but interactive
/// flows (dialog, phone, objectives) will stay degraded until SJ.2.b /
/// SJ.3 ship.</para>
///
/// <para>Client-side <c>SideJobController.JobCreationCheck</c> stays
/// neutered (Harmony prefix in GamePatches.cs) so the client doesn't fight
/// us by inventing its own jobs.</para>
/// </summary>
public static class SideJobSync
{
    public const byte KIND_CREATED  = 0;
    public const byte KIND_POSTED   = 1;
    public const byte KIND_ENDED    = 2;
    public const byte KIND_SNAPSHOT = 3;
    public const byte KIND_UPDATED  = 4; // generic state-changed (e.g. after accept)

    public static bool IsApplyingRemote { get; private set; }

    private static readonly NetDataWriter _writer = new();

    /// <summary>Lazy preset registry — JobPreset by name.</summary>
    private static System.Collections.Generic.Dictionary<string, JobPreset> _presetByName;

    // ─────────────────────────────────────────────────────────────────────
    //  Outbound (host)
    // ─────────────────────────────────────────────────────────────────────

    public static void BroadcastFromCtor(SideJob job)
        => Broadcast(KIND_CREATED, job, peer: null);

    public static void BroadcastStateChange(SideJob job, SideJob.JobState newState)
    {
        if (job == null) return;
        byte kind;
        switch (newState)
        {
            case SideJob.JobState.posted: kind = KIND_POSTED; break;
            case SideJob.JobState.ended:  kind = KIND_ENDED;  break;
            default: return; // skip "generated" — ctor handles initial broadcast
        }
        Broadcast(kind, job, peer: null);
    }

    /// <summary>
    /// Snapshot push: send every active job in <c>SideJobController.allJobsDictionary</c>
    /// to a single freshly-joined peer. Called from NetworkManager when a
    /// client completes its handshake.
    /// </summary>
    public static void SendSnapshotTo(NetPeer peer)
    {
        if (peer == null) return;
        if (!NetworkManager.IsHost) return;

        try
        {
            var ctrl = global::SideJobController.Instance;
            if (ctrl == null) { Plugin.Log.LogInfo("[SideJobSync] no SideJobController.Instance — skipping snapshot."); return; }

            var dict = ctrl.allJobsDictionary;
            if (dict == null || dict.Count == 0)
            {
                Plugin.Log.LogInfo("[SideJobSync] snapshot: 0 active jobs.");
                return;
            }

            int sent = 0;
            foreach (var kv in dict)
            {
                Broadcast(KIND_SNAPSHOT, kv.Value, peer);
                sent++;
            }
            Plugin.Log.LogInfo($"[SideJobSync] snapshot: sent {sent} job(s) to peer {peer.Address}:{peer.Port}.");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"SideJobSync.SendSnapshotTo: {ex.Message}");
        }
    }

    /// <summary>
    /// Build the upsert packet from the live SideJob. If <paramref name="peer"/>
    /// is non-null, send only to that peer (snapshot path); otherwise
    /// broadcast to all.
    /// </summary>
    private static void Broadcast(byte kind, SideJob job, NetPeer peer)
    {
        if (!NetworkManager.IsHost) return;
        if (!NetworkManager.IsConnected) return;
        if (job == null) return;
        if (IsApplyingRemote) return;

        try
        {
            var packet = BuildUpsertFromJob(kind, job);

            _writer.Reset();
            packet.Serialize(_writer);

            if (peer != null)
            {
                NetworkManager.SendTo(peer, PacketType.SideJobNotification, _writer, DeliveryMethod.ReliableOrdered);
            }
            else
            {
                NetworkManager.SendToAll(PacketType.SideJobNotification, _writer, DeliveryMethod.ReliableOrdered);
            }

            Plugin.Log.LogInfo($"[SideJobSync] {(peer != null ? "snapshot-to-peer" : "broadcast")} kind={kind} jobID={packet.JobId} preset=\"{packet.PresetName}\" state={packet.State} accepted={packet.Accepted}");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"SideJobSync.Broadcast: {ex.Message}");
        }
    }

    private static SideJobUpsertPacket BuildUpsertFromJob(byte kind, SideJob job)
    {
        string presetName = "";
        try { presetName = string.IsNullOrEmpty(job.presetStr) ? (job.preset?.name ?? "") : job.presetStr; } catch { }

        string posterName = "";
        try
        {
            var poster = job.poster;
            if (poster != null)
            {
                string fn = poster.firstName ?? "";
                string sn = poster.surName ?? "";
                posterName = string.IsNullOrEmpty(sn) ? fn : $"{fn} {sn}";
            }
        }
        catch { }

        return new SideJobUpsertPacket
        {
            Kind                = kind,
            JobId               = TryReadInt(() => job.jobID),
            PresetName          = presetName,
            MotiveStr           = TryReadString(() => job.motiveStr),
            State               = (byte)TryReadInt(() => (int)job.state),
            Accepted            = TryReadBool(() => job.accepted),
            CaseId              = TryReadInt(() => job.caseID),
            Phase               = TryReadInt(() => job.phase),
            PostId              = TryReadInt(() => job.postID),
            PosterHumanId       = TryReadInt(() => job.poster?.humanID ?? -1),
            PurpHumanId         = TryReadInt(() => job.purp?.humanID ?? -1),
            Reward              = TryReadInt(() => job.reward),
            RewardSyncDisk      = TryReadString(() => job.rewardSyncDisk),
            JobInfoDialogMsg    = TryReadString(() => job.jobInfoDialogMsg),
            PosterName          = posterName,
            Intro               = TryReadString(() => job.intro),
            HandIn              = TryReadString(() => job.handIn),
            PostImmediately     = TryReadBool(() => job.postImmediately),
            FakeNumber          = TryReadInt(() => job.fakeNumber),
            FakeNumberStr       = TryReadString(() => job.fakeNumberStr),
            GooseChasePhone     = TryReadInt(() => job.gooseChasePhone),
            GooseChaseFromPhone = TryReadInt(() => job.gooseChaseFromPhone),
            TriggerHandIn       = TryReadBool(() => job.triggerHandIn),
        };
    }

    private static int    TryReadInt   (Func<int> f)    { try { return f(); } catch { return 0; } }
    private static bool   TryReadBool  (Func<bool> f)   { try { return f(); } catch { return false; } }
    private static string TryReadString(Func<string> f) { try { return f() ?? ""; } catch { return ""; } }

    // ─────────────────────────────────────────────────────────────────────
    //  Inbound (clients)
    // ─────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        try
        {
            switch (type)
            {
                case PacketType.SideJobNotification:
                {
                    var p = new SideJobUpsertPacket();
                    p.Deserialize(reader);
                    ApplyUpsert(p);
                    break;
                }
                case PacketType.SideJobAcceptRequest:
                {
                    int jobID = reader.GetInt();
                    HandleAcceptRequest(jobID, senderId);
                    break;
                }
                case PacketType.SideJobHandInRequest:
                {
                    int jobID = reader.GetInt();
                    HandleHandInRequest(jobID, senderId);
                    break;
                }
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"SideJobSync.OnPacketReceived: {ex.Message}");
        }
    }

    /// <summary>
    /// Client → host. Sent from the client's <c>SideJob.OnPlayerCall</c>
    /// Harmony prefix when the local invocation is suppressed.
    /// </summary>
    public static void RequestAccept(int jobID)
    {
        if (NetworkManager.IsHost) return;
        if (!NetworkManager.IsConnected) return;

        try
        {
            _writer.Reset();
            _writer.Put(jobID);
            NetworkManager.SendToHost(PacketType.SideJobAcceptRequest, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogInfo($"[SideJobSync] sent accept-request for jobID={jobID}");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"SideJobSync.RequestAccept: {ex.Message}");
        }
    }

    /// <summary>
    /// Client → host. Sent from the client's <c>SideJob.OnRewarded</c>
    /// Harmony prefix. Host runs vanilla OnRewarded on the real job,
    /// which dispatches reward via paths that already self-sync (money,
    /// evidence creation, SetJobState transition).
    /// </summary>
    public static void RequestHandIn(int jobID)
    {
        if (NetworkManager.IsHost) return;
        if (!NetworkManager.IsConnected) return;

        try
        {
            _writer.Reset();
            _writer.Put(jobID);
            NetworkManager.SendToHost(PacketType.SideJobHandInRequest, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogInfo($"[SideJobSync] sent hand-in-request for jobID={jobID}");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"SideJobSync.RequestHandIn: {ex.Message}");
        }
    }

    /// <summary>
    /// Host-side. Run vanilla <c>OnRewarded</c> on the real SideJob. Reward
    /// dispatch runs natively: money via <c>GameplayController.AddMoney</c>
    /// (synced by MoneySync), sync-disk reward as Evidence (synced by
    /// EvidenceSync's diff path), and the typical SetJobState(ended)
    /// transition (synced by our existing patch). We also broadcast a
    /// fresh upsert at the end with KIND_ENDED so peers re-stamp scalar
    /// fields belt-and-braces.
    /// </summary>
    private static void HandleHandInRequest(int jobID, int senderId)
    {
        if (!NetworkManager.IsHost) return;

        try
        {
            var ctrl = global::SideJobController.Instance;
            if (ctrl == null) { Plugin.Log.LogWarning($"[SideJobSync] handin-request jobID={jobID}: no SideJobController.Instance"); return; }
            var dict = ctrl.allJobsDictionary;
            if (dict == null || !dict.TryGetValue(jobID, out var job) || job == null)
            {
                Plugin.Log.LogWarning($"[SideJobSync] handin-request: jobID={jobID} not in allJobsDictionary on host.");
                return;
            }

            IsApplyingRemote = true;
            try
            {
                job.OnRewarded();
                Plugin.Log.LogInfo($"[SideJobSync] applied hand-in for jobID={jobID} from playerId={senderId}; state={TryReadInt(() => (int)job.state)}");
            }
            finally
            {
                IsApplyingRemote = false;
            }

            // Final upsert to peers — OnRewarded internals may flip fields
            // that aren't already covered by SetJobState's existing patch.
            Broadcast(KIND_ENDED, job, peer: null);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"SideJobSync.HandleHandInRequest: {ex.Message}");
        }
    }

    /// <summary>
    /// ZDO entry-point: invoked from <c>ZdoEvents.OnSideJobPlayerCall</c>
    /// after looking up the job. Runs vanilla OnPlayerCall under the
    /// IsApplyingRemote guard and re-broadcasts the upsert.
    /// </summary>
    public static void RunOnPlayerCallAndRebroadcast(SideJob job, int senderId)
    {
        if (!NetworkManager.IsHost) return;
        if (job == null) return;
        try
        {
            IsApplyingRemote = true;
            try
            {
                job.OnPlayerCall();
                Plugin.Log.LogInfo($"[SideJobSync] applied accept (zdo) for jobID={job.jobID} from playerId={senderId}; accepted={TryReadBool(() => job.accepted)} state={TryReadInt(() => (int)job.state)}");
            }
            finally { IsApplyingRemote = false; }
            Broadcast(KIND_UPDATED, job, peer: null);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"SideJobSync.RunOnPlayerCallAndRebroadcast: {ex.Message}");
        }
    }

    /// <summary>
    /// ZDO entry-point: invoked from <c>ZdoEvents.OnSideJobRewarded</c>.
    /// Runs vanilla OnRewarded under the IsApplyingRemote guard and
    /// re-broadcasts the upsert.
    /// </summary>
    public static void RunOnRewardedAndRebroadcast(SideJob job, int senderId)
    {
        if (!NetworkManager.IsHost) return;
        if (job == null) return;
        try
        {
            IsApplyingRemote = true;
            try
            {
                job.OnRewarded();
                Plugin.Log.LogInfo($"[SideJobSync] applied hand-in (zdo) for jobID={job.jobID} from playerId={senderId}; state={TryReadInt(() => (int)job.state)}");
            }
            finally { IsApplyingRemote = false; }
            Broadcast(KIND_ENDED, job, peer: null);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"SideJobSync.RunOnRewardedAndRebroadcast: {ex.Message}");
        }
    }

    /// <summary>
    /// Host-side. Look up the live SideJob in <c>allJobsDictionary</c> and
    /// invoke vanilla <c>OnPlayerCall</c> — which flips <c>accepted=true</c>,
    /// transitions phase, etc. Then broadcast a fresh upsert so all peers
    /// (including the requester) see the new state.
    /// </summary>
    private static void HandleAcceptRequest(int jobID, int senderId)
    {
        if (!NetworkManager.IsHost) return;

        try
        {
            var ctrl = global::SideJobController.Instance;
            if (ctrl == null) { Plugin.Log.LogWarning($"[SideJobSync] accept-request jobID={jobID}: no SideJobController.Instance"); return; }
            var dict = ctrl.allJobsDictionary;
            if (dict == null || !dict.TryGetValue(jobID, out var job) || job == null)
            {
                Plugin.Log.LogWarning($"[SideJobSync] accept-request: jobID={jobID} not in allJobsDictionary on host.");
                return;
            }

            IsApplyingRemote = true;
            try
            {
                job.OnPlayerCall();
                Plugin.Log.LogInfo($"[SideJobSync] applied accept for jobID={jobID} from playerId={senderId}; accepted={TryReadBool(() => job.accepted)} state={TryReadInt(() => (int)job.state)}");
            }
            finally
            {
                IsApplyingRemote = false;
            }

            // Broadcast updated state to all peers — OnPlayerCall may flip
            // accepted / phase / state without going through SetJobState
            // (which would have hit our existing patch).
            Broadcast(KIND_UPDATED, job, peer: null);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"SideJobSync.HandleAcceptRequest: {ex.Message}");
        }
    }


    private static void ApplyUpsert(SideJobUpsertPacket p)
    {
        // Defensive — host doesn't deliver to itself, but guard anyway.
        if (NetworkManager.IsHost) return;

        // 1. Banner (always works, irrespective of skeleton-reconstruction success).
        ShowBanner(p);

        // 2. Best-effort skeleton SideJob reconstruction so the case board /
        // corkboard / "did I accept this" reads have something to look at.
        try
        {
            IsApplyingRemote = true;
            ReconstructOrUpdateSkeleton(p);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[SideJobSync] skeleton reconstruction for jobID={p.JobId} failed: {ex.GetType().Name}: {ex.Message}");
        }
        finally
        {
            IsApplyingRemote = false;
        }
    }

    private static void ShowBanner(SideJobUpsertPacket p)
    {
        string preset = string.IsNullOrEmpty(p.PresetName) ? "(unknown)" : p.PresetName;
        string poster = string.IsNullOrEmpty(p.PosterName) ? "someone"   : p.PosterName;
        string reward = p.Reward > 0 ? $" — ₠{p.Reward}" : "";

        // Snapshot pushes are silent (no banner spam on join).
        if (p.Kind == KIND_SNAPSHOT) return;

        string banner;
        switch (p.Kind)
        {
            case KIND_CREATED: banner = $"📋 New side job generated: {preset} (poster {poster}){reward}";    break;
            case KIND_POSTED:  banner = $"📌 Side job on the corkboard: {preset} (poster {poster}){reward}"; break;
            case KIND_ENDED:   banner = $"🏁 Side job ended: {preset}{reward}";                              break;
            default:           banner = $"❓ Side job event kind={p.Kind} — {preset}";                       break;
        }
        try { CoopUI.AddChatMessage(-1, "Jobs", banner); } catch { }
    }

    /// <summary>
    /// If the client's <c>allJobsDictionary</c> already has this jobID, just
    /// update the mutable scalar fields. Otherwise allocate a new SideJob via
    /// <c>il2cpp_object_new</c> (skip the C# ctor — it'd require JobPickData
    /// internal state we don't have), stamp scalar fields, resolve preset /
    /// poster / purp / case references, init the List&lt;&gt; fields to empty
    /// so reads don't NRE, and add to the dictionary.
    /// </summary>
    private static void ReconstructOrUpdateSkeleton(SideJobUpsertPacket p)
    {
        var ctrl = global::SideJobController.Instance;
        if (ctrl == null) { Plugin.Log.LogInfo("[SideJobSync] no SideJobController.Instance on client — banner only."); return; }

        var dict = ctrl.allJobsDictionary;
        if (dict == null) { Plugin.Log.LogInfo("[SideJobSync] allJobsDictionary is null — banner only."); return; }

        SideJob existing = null;
        try { dict.TryGetValue(p.JobId, out existing); } catch { }

        if (existing != null)
        {
            UpdateScalarFields(existing, p);
            Plugin.Log.LogInfo($"[SideJobSync] updated existing skeleton jobID={p.JobId} state={p.State} accepted={p.Accepted}");
            return;
        }

        var preset = ResolvePreset(p.PresetName);

        SideJob fresh;
        try
        {
            IntPtr ptr = IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SideJob>.NativeClassPtr);
            fresh = new SideJob(ptr);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[SideJobSync] il2cpp_object_new(SideJob) failed: {ex.Message}");
            return;
        }

        try { fresh.preset = preset; } catch { }
        UpdateScalarFields(fresh, p);

        // Resolve references.
        try
        {
            if (p.PosterHumanId > 0)
            {
                var poster = ResolveHuman(p.PosterHumanId);
                if (poster != null) fresh.poster = poster;
            }
        }
        catch { }
        try
        {
            if (p.PurpHumanId > 0)
            {
                var purp = ResolveHuman(p.PurpHumanId);
                if (purp != null) fresh.purp = purp;
            }
        }
        catch { }
        try
        {
            if (p.CaseId > 0)
            {
                var c = ResolveCase(p.CaseId);
                if (c != null) fresh.thisCase = c;
            }
        }
        catch { }

        // Initialise list fields to empty so any code that iterates them
        // (UI, ObjectiveStateLoop, etc.) doesn't NRE on first access.
        try { fresh.appliedBasicLeads = new Il2CppSystem.Collections.Generic.List<JobPreset.BasicLeadPool>(); } catch { }
        try { fresh.leadKeys          = new Il2CppSystem.Collections.Generic.List<Evidence.DataKey>(); } catch { }
        try { fresh.confine           = new Il2CppSystem.Collections.Generic.List<SideJob.ConfineLocation>(); } catch { }
        try { fresh.dialog            = new Il2CppSystem.Collections.Generic.List<SideJob.AddedDialog>(); } catch { }

        // Register in the controller's master dictionary.
        try
        {
            dict[p.JobId] = fresh;
            Plugin.Log.LogInfo($"[SideJobSync] reconstructed skeleton jobID={p.JobId} preset=\"{p.PresetName}\" added to allJobsDictionary.");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[SideJobSync] failed adding skeleton to allJobsDictionary: {ex.Message}");
        }
    }

    private static void UpdateScalarFields(SideJob job, SideJobUpsertPacket p)
    {
        try { job.jobID               = p.JobId; }              catch { }
        try { job.presetStr           = p.PresetName; }         catch { }
        try { job.motiveStr           = p.MotiveStr; }          catch { }
        try { job.state               = (SideJob.JobState)p.State; } catch { }
        try { job.accepted            = p.Accepted; }           catch { }
        try { job.caseID              = p.CaseId; }             catch { }
        try { job.phase               = p.Phase; }              catch { }
        try { job.postID              = p.PostId; }             catch { }
        try { job.reward              = p.Reward; }             catch { }
        try { job.rewardSyncDisk      = p.RewardSyncDisk; }     catch { }
        try { job.jobInfoDialogMsg    = p.JobInfoDialogMsg; }   catch { }
        try { job.intro               = p.Intro; }              catch { }
        try { job.handIn              = p.HandIn; }             catch { }
        try { job.postImmediately     = p.PostImmediately; }    catch { }
        try { job.fakeNumber          = p.FakeNumber; }         catch { }
        try { job.fakeNumberStr       = p.FakeNumberStr; }      catch { }
        try { job.gooseChasePhone     = p.GooseChasePhone; }    catch { }
        try { job.gooseChaseFromPhone = p.GooseChaseFromPhone; }catch { }
        try { job.triggerHandIn       = p.TriggerHandIn; }      catch { }
        try { job.purpID              = p.PurpHumanId; }        catch { }
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Resolution helpers
    // ─────────────────────────────────────────────────────────────────────

    private static JobPreset ResolvePreset(string name)
    {
        if (string.IsNullOrEmpty(name)) return null;

        if (_presetByName != null && _presetByName.TryGetValue(name, out var cached)) return cached;

        try
        {
            _presetByName = new System.Collections.Generic.Dictionary<string, JobPreset>();
            var all = Resources.FindObjectsOfTypeAll<JobPreset>();
            if (all == null) return null;
            for (int i = 0; i < all.Length; i++)
            {
                var pr = all[i];
                if (pr == null) continue;
                var n = pr.name;
                if (string.IsNullOrEmpty(n)) continue;
                _presetByName[n] = pr;
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"SideJobSync.ResolvePreset: {ex.Message}");
            return null;
        }

        return _presetByName.TryGetValue(name, out var fresh) ? fresh : null;
    }

    private static Human ResolveHuman(int humanId)
    {
        try
        {
            var dict = global::CityData.Instance?.citizenDictionary;
            if (dict != null && dict.TryGetValue(humanId, out var h)) return h;
        }
        catch { }
        return null;
    }

    private static Case ResolveCase(int caseId)
    {
        try
        {
            var cpc = global::CasePanelController.Instance;
            if (cpc == null) return null;
            var cases = cpc.activeCases;
            if (cases == null) return null;
            for (int i = 0; i < cases.Count; i++)
            {
                var c = cases[i];
                if (c != null && c.id == caseId) return c;
            }
        }
        catch { }
        return null;
    }
}
