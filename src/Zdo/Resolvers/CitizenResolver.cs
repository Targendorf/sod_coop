namespace SoDCoop.Zdo.Resolvers;

/// <summary>
/// Apply <see cref="ZdoTypeTag.Citizen"/> state to the matching live
/// <c>Citizen</c>. The legacy <c>NpcOutfitSync</c> /
/// <c>InventorySync</c> Apply paths still own the SoD-side mutation
/// during the migration window — this resolver is currently a state
/// receiver only (the ZDO state is preserved across snapshot/disk).
/// </summary>
public sealed class CitizenResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.Citizen;
    public void Apply(Zdo z) { _ = z; }
}
