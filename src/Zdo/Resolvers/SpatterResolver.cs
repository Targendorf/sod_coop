namespace SoDCoop.Zdo.Resolvers;

public sealed class SpatterResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.Spatter;
    public void Apply(Zdo z) { _ = z; }
}
