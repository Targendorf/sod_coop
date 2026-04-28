using LiteNetLib;
using LiteNetLib.Utils;
using SoDCoop.Network;
using SoDCoop.UI;

namespace SoDCoop.Sync;

/// <summary>
/// Side-job awareness sync (Phase SJ.1).
///
/// <para><b>Scope:</b> host broadcasts a chat-banner-only notification when
/// a side job is created, posted to a corkboard, or ends. Clients see the
/// banner but do NOT have a corresponding <c>SideJob</c> object reconstructed
/// in their game — host-authoritative interaction (accept / objectives /
/// hand-in / reward) is deferred to phases SJ.2 + SJ.3.</para>
///
/// <para>Client-side <see cref="SideJobController.JobCreationCheck"/> is
/// neutered via a Harmony prefix in <c>GamePatches.cs</c> so the client
/// doesn't manufacture its own divergent set of jobs that the host has no
/// idea about. Result: client's corkboards stay empty; only host's posted
/// jobs are observable as banners until later phases enable interaction.</para>
/// </summary>
public static class SideJobSync
{
    /// <summary>Wire <c>Kind</c> values for <see cref="SideJobNotificationPacket"/>.</summary>
    public const byte KIND_CREATED = 0;
    public const byte KIND_POSTED  = 1;
    public const byte KIND_ENDED   = 2;

    public static bool IsApplyingRemote { get; private set; }

    private static readonly NetDataWriter _writer = new();

    // ─────────────────────────────────────────────────────────────────────
    //  Outbound (host-only)
    // ─────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Called from the <c>SideJob</c> ctor postfix on the host. Resolves the
    /// poster citizen's name and broadcasts a Created notification.
    /// </summary>
    public static void BroadcastFromCtor(SideJob job)
    {
        if (!NetworkManager.IsHost) return;
        Broadcast(KIND_CREATED, job);
    }

    /// <summary>
    /// Called from the <c>SetJobState</c> postfix on the host. Maps the
    /// JobState enum to a wire kind:
    ///   posted → KIND_POSTED, ended → KIND_ENDED.
    /// "generated" transitions are skipped — the ctor path already
    /// broadcasts on initial creation.
    /// </summary>
    public static void BroadcastStateChange(SideJob job, SideJob.JobState newState)
    {
        if (!NetworkManager.IsHost) return;
        if (job == null) return;

        byte kind;
        switch (newState)
        {
            case SideJob.JobState.posted: kind = KIND_POSTED; break;
            case SideJob.JobState.ended:  kind = KIND_ENDED;  break;
            default: return;
        }
        Broadcast(kind, job);
    }

    private static void Broadcast(byte kind, SideJob job)
    {
        if (!NetworkManager.IsConnected) return;
        if (job == null) return;
        if (IsApplyingRemote) return;

        try
        {
            string posterName = ResolvePosterName(job);
            string presetName = "";
            try { presetName = string.IsNullOrEmpty(job.presetStr) ? (job.preset?.name ?? "") : job.presetStr; } catch { }

            int reward = 0;
            try { reward = job.reward; } catch { }

            int jobId = 0;
            try { jobId = job.jobID; } catch { }

            var packet = new SideJobNotificationPacket
            {
                Kind       = kind,
                JobId      = jobId,
                PresetName = presetName,
                PosterName = posterName,
                Reward     = reward,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.SideJobNotification, _writer, DeliveryMethod.ReliableOrdered);

            Plugin.Log.LogInfo($"[SideJobSync] broadcast kind={kind} jobID={jobId} preset=\"{presetName}\" poster=\"{posterName}\" reward={reward}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"SideJobSync.Broadcast: {ex.Message}");
        }
    }

    private static string ResolvePosterName(SideJob job)
    {
        try
        {
            var poster = job.poster;
            if (poster == null) return "";
            string fn = poster.firstName ?? "";
            string sn = poster.surName ?? "";
            return string.IsNullOrEmpty(sn) ? fn : $"{fn} {sn}";
        }
        catch { return ""; }
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Inbound (clients render as chat banner)
    // ─────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        if (type != PacketType.SideJobNotification) return;

        try
        {
            var p = new SideJobNotificationPacket();
            p.Deserialize(reader);
            ApplyNotification(p);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"SideJobSync.OnPacketReceived: {ex.Message}");
        }
    }

    private static void ApplyNotification(SideJobNotificationPacket p)
    {
        // Host echoes its own broadcasts back to itself via SendToAll's
        // self-echo path? Actually no — SendToAll on host iterates _clients,
        // doesn't include self. So a host receiving its own packet shouldn't
        // happen. Defensive skip anyway:
        if (NetworkManager.IsHost) return;

        string preset = string.IsNullOrEmpty(p.PresetName) ? "(unknown)" : p.PresetName;
        string poster = string.IsNullOrEmpty(p.PosterName) ? "someone"   : p.PosterName;
        string reward = p.Reward > 0 ? $" — ₠{p.Reward}" : "";

        string banner;
        switch (p.Kind)
        {
            case KIND_CREATED:
                banner = $"📋 New side job generated: {preset} (poster {poster}){reward}";
                break;
            case KIND_POSTED:
                banner = $"📌 Side job on the corkboard: {preset} (poster {poster}){reward}";
                break;
            case KIND_ENDED:
                banner = $"🏁 Side job ended: {preset}{reward}";
                break;
            default:
                banner = $"❓ Side job event kind={p.Kind} — {preset}";
                break;
        }
        try { CoopUI.AddChatMessage(-1, "Jobs", banner); } catch { }
        Plugin.Log.LogInfo($"[SideJobSync] applied {banner}");
    }
}
