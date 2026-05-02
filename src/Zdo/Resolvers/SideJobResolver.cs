using System;

namespace SoDCoop.Zdo.Resolvers;

/// <summary>
/// Apply <see cref="ZdoTypeTag.SideJob"/> ZDO state to the live SideJob
/// on receivers. Each side-job is one ZDO keyed by
/// <c>__sodId = jobID</c>; the resolver hands the full upsert payload
/// to <see cref="SoDCoop.Sync.SideJobSync.ApplyFromZdo"/> which
/// reconstructs the skeleton SideJob in the client's
/// <c>SideJobController.allJobsDictionary</c> via the existing
/// reflection-based path.
///
/// <para>Phase G.5 (Wave 3.2): replaces the legacy
/// <c>SideJobNotification</c> packet wire. Late-join snapshot replays
/// every active job through this same resolver, so a third client
/// joining a 30-minute session walks in with the full job board.</para>
///
/// <para>Field set is the same 22-field upsert the legacy packet
/// carried; see <see cref="ZdoKeys"/> for the per-key hash table and
/// <c>SideJobSync.WriteUpsertToZdo</c> for the host-side serialise path.</para>
/// </summary>
public sealed class SideJobResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.SideJob;

    public void Apply(Zdo z)
    {
        if (z == null) return;
        if (SoDCoop.Network.NetworkManager.IsHost) return;
        try { SoDCoop.Sync.SideJobSync.ApplyFromZdo(z); }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SideJobResolver] apply: {ex.Message}"); }
    }
}
