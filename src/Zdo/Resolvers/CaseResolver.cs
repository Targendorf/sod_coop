using System;

namespace SoDCoop.Zdo.Resolvers;

/// <summary>
/// Apply <see cref="ZdoTypeTag.Case"/> ZDO state to the live <c>Case</c>
/// looked up by <c>__sodId = caseID</c>.
///
/// <para>Phase G.5 (Wave 1.2): currently handles the
/// <see cref="ZdoKeys.CaseStatus"/> key. Future waves extend this to
/// hidden facts, resolve-answer progress, final-resolve, and per-fact
/// custom names — each on the same per-case ZDO.</para>
/// </summary>
public sealed class CaseResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.Case;

    public void Apply(Zdo z)
    {
        if (z == null) return;
        if (SoDCoop.Network.NetworkManager.IsHost) return;

        int caseId = z.GetInt(ZdoKeys.SodId, int.MinValue);
        if (caseId == int.MinValue) return;

        try
        {
            if (z.HasKey(ZdoKeys.CaseStatus))
            {
                byte status = z.GetByte(ZdoKeys.CaseStatus, 0);
                SoDCoop.Sync.CaseBoardSync.ApplyStatusFromZdo(caseId, status, cancelObjectives: false);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CaseResolver] status apply: {ex.Message}"); }
    }
}
