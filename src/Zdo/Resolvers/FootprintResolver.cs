namespace SoDCoop.Zdo.Resolvers;

public sealed class FootprintResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.Footprint;
    public void Apply(Zdo z) { _ = z; }
}
