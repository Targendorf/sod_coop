namespace SoDCoop.Zdo.Resolvers;

public sealed class EvidenceObjectResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.EvidenceObject;
    public void Apply(Zdo z) { _ = z; }
}
