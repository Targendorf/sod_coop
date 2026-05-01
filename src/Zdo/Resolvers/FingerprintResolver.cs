namespace SoDCoop.Zdo.Resolvers;

public sealed class FingerprintResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.Fingerprint;
    public void Apply(Zdo z) { _ = z; }
}
