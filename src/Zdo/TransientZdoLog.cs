using System.Collections.Generic;

namespace SoDCoop.Zdo;

/// <summary>
/// Bounded lifetime for one-shot "event" ZDOs — a footprint was left, blood
/// spattered — that are carried as ZDOs only so the change rides the normal
/// replication path.
///
/// <para><b>Why:</b> those pollers created a persistent ZDO per event and
/// nothing ever destroyed one (only the phone-call poller calls
/// <see cref="ZdoMan.Destroy"/>). NPCs leave footprints constantly, so over a
/// session the host registry accumulated every footprint and spatter ever
/// made — including ones SoD itself had long since faded — and all of it rode
/// along in every join snapshot, in <c>SerializeAllForSnapshot</c>'s main-thread
/// cost, and in the on-disk ZDO save. Receivers registered each one too and
/// kept them forever.</para>
///
/// <para>Keeps the most recent <c>cap</c> ids and destroys the oldest beyond
/// that. Destruction is local (it is not replicated), which is exactly right:
/// the event has already been applied wherever it was going to be.
/// <see cref="Track"/> also answers "seen this one already?", which receivers
/// use to avoid applying the same event twice — the apply paths append, and a
/// ZDO can arrive more than once (snapshot after a delta, reconnect resume).</para>
/// </summary>
internal sealed class TransientZdoLog
{
    private readonly Queue<ZDOID> _order = new();
    private readonly HashSet<ZDOID> _set = new();
    private readonly int _cap;

    public TransientZdoLog(int cap) { _cap = cap < 1 ? 1 : cap; }

    /// <summary>Record <paramref name="id"/>. Returns false if it is already
    /// tracked — the caller should not apply it again.</summary>
    public bool Track(ZDOID id)
    {
        if (!_set.Add(id)) return false;
        _order.Enqueue(id);
        while (_order.Count > _cap)
        {
            var old = _order.Dequeue();
            _set.Remove(old);
            ZdoMan.Destroy(old);
        }
        return true;
    }

    /// <summary>Forget everything without destroying — used when the registry
    /// itself is being cleared with the world.</summary>
    public void Clear()
    {
        _order.Clear();
        _set.Clear();
    }
}
