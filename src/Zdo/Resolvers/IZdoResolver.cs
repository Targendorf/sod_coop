namespace SoDCoop.Zdo.Resolvers;

/// <summary>
/// A resolver knows how to translate ZDO state into live SoD-side mutations
/// for one <see cref="ZdoTypeTag"/>. Called after every applied delta and
/// after snapshot restore.
///
/// <para>Implementations must be idempotent — Apply can run multiple times
/// for the same ZDO state without ill effect.</para>
/// </summary>
public interface IZdoResolver
{
    ZdoTypeTag Tag { get; }

    /// <summary>Apply the ZDO's current property state to the corresponding
    /// live SoD object. Lookup by reserved <c>__sodId</c> / <c>__sodIdStr</c>
    /// keys; resolver implementations cache reflection at static init.</summary>
    void Apply(Zdo z);
}
