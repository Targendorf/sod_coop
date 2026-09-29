using System;
using System.Collections.Generic;

namespace SoDCoop.Zdo.Resolvers;

/// <summary>
/// Apply <see cref="ZdoTypeTag.Fingerprint"/> ZDOs to live SoD state via
/// <see cref="SoDCoop.Sync.FingerprintSync.ApplyAddDirect"/>.
///
/// <para><b>At most once per print.</b> <c>AddNewDynamicFingerprint</c>
/// appends; it is not idempotent. A print ZDO can reach a client more than once
/// — snapshot restore after a delta, a reconnect resume, the post-load
/// ApplyAllToLiveWorld pass — and every extra application was a duplicate
/// print. Applied ZDO ids are remembered for the session.</para>
///
/// <para><b>Own echoes are skipped.</b> A client reports its own prints to the
/// host (FingerprintPoller, client side); the host remaps them to that client's
/// twin and they come back as ordinary host prints. The originating client
/// already has the print locally, under its own player, so re-adding it under
/// its twin would double it.</para>
/// </summary>
public sealed class FingerprintResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.Fingerprint;

    private static readonly HashSet<ZDOID> _applied = new();

    /// <summary>Forget applied prints. Called when the world goes away, so a
    /// fresh world (with fresh ZDO ids) starts clean.</summary>
    public static void Reset() => _applied.Clear();

    public void Apply(Zdo z)
    {
        if (z == null) return;
        if (SoDCoop.Network.NetworkManager.IsHost) return;   // host originates; never replay
        try
        {
            int interactableId = z.GetInt(ZdoKeys.InteractableId, -1);
            if (interactableId < 0) return;   // keys not all here yet — a later delta completes it

            if (!_applied.Add(z.Id)) return;

            int humanId = z.GetInt(ZdoKeys.HumanId, 0);
            int myTwin  = SoDCoop.Network.NetworkManager.MyTwinHumanID;
            if (myTwin > 0 && humanId == myTwin) return;   // our own print, echoed back

            byte life = z.GetByte(ZdoKeys.Life, 0);
            SoDCoop.Sync.FingerprintSync.ApplyAddDirect(interactableId, humanId, life);
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[FingerprintResolver] apply: {ex.Message}"); }
    }
}
