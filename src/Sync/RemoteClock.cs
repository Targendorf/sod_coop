using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Maps a remote sender's clock onto ours, for snapshot interpolation that
/// is timed by when a sample was TAKEN rather than when it happened to ARRIVE.
///
/// <para><b>Why arrival time was not good enough.</b> Samples are taken by a
/// poller and shipped by the ZDO flush, two schedules that are not phase
/// locked, then cross a network that bunches and spreads packets. Interpolating
/// on arrival time replays every one of those wobbles as a speed change: two
/// samples that land in the same frame make the body jump the whole span at
/// once, a sample that is a frame late makes it stall. Sender timestamps carry
/// the true spacing, so playback is as even as the movement was.</para>
///
/// <para><b>Offset.</b> <c>local − remote</c> for the fastest sample seen is
/// the best estimate of "remote clock + minimum latency"; anything slower was
/// delayed in transit. It creeps upward slowly so a lasting route change (relay
/// switch) is followed instead of leaving the estimate permanently too low.</para>
///
/// <para><b>Delay.</b> Render far enough behind that the sample after the
/// render time has normally arrived: one sample gap plus twice the smoothed
/// lateness. Eased, never stepped — a step in delay is a visible jump.</para>
/// </summary>
internal sealed class RemoteClock
{
    /// <summary>Per-sample fraction of the gap the offset closes when samples
    /// arrive slower than the fastest seen. ~5 s to follow a route change at
    /// 20 samples/s.</summary>
    private const float OFFSET_CREEP = 0.01f;

    /// <summary>A sample this far off the current estimate means the sender's
    /// clock restarted (game restart, new session), not jitter.</summary>
    private const float RESET_JUMP_S = 2f;

    /// <summary>How fast the render delay may change, seconds per second —
    /// playback runs at most this much faster or slower while it adapts.</summary>
    private const float DELAY_SLEW = 0.06f;

    private float _offset;
    private float _lateness;

    public bool HasSample { get; private set; }

    /// <summary>Current render delay, seconds.</summary>
    public float Delay { get; private set; }

    /// <summary>Feed one sample's sender time and our arrival time. Returns
    /// true when the sender's clock jumped (the caller should drop its
    /// buffered samples — their times are on the old clock).</summary>
    public bool Observe(float remoteTime, float localNow)
    {
        float o = localNow - remoteTime;
        if (!HasSample || Mathf.Abs(o - _offset) > RESET_JUMP_S)
        {
            bool reset = HasSample;
            _offset = o;
            _lateness = 0f;
            HasSample = true;
            return reset;
        }

        if (o < _offset) _offset = o;
        else _offset += (o - _offset) * OFFSET_CREEP;

        float late = o - _offset;
        // Fast attack, slow release: one late burst widens the delay at once,
        // a calm spell only narrows it gradually.
        _lateness += (late - _lateness) * (late > _lateness ? 0.3f : 0.02f);
        return false;
    }

    /// <summary>Ease the render delay toward what the current lateness needs.
    /// Call once per frame before <see cref="RenderTime"/>.</summary>
    public void Advance(float dt, float sampleGap, float minDelay, float maxDelay)
    {
        float target = Mathf.Clamp(sampleGap + 2f * _lateness + 0.015f, minDelay, maxDelay);
        Delay = Delay <= 0f ? target : Mathf.MoveTowards(Delay, target, DELAY_SLEW * Mathf.Max(dt, 0f));
    }

    /// <summary>The sender-clock time to render at now.</summary>
    public float RenderTime(float localNow) => localNow - _offset - Delay;

    public void Reset()
    {
        HasSample = false;
        _offset = 0f;
        _lateness = 0f;
        Delay = 0f;
    }
}
