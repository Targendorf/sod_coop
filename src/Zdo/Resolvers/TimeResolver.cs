namespace SoDCoop.Zdo.Resolvers;

public sealed class TimeResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.Time;

    public void Apply(Zdo z)
    {
        // Time tick replication — TimeSync legacy path handles the SoD-side
        // application. ZDO singleton carries gameTime/dayIndex for snapshot.
        _ = z;
    }
}
