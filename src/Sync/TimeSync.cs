using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Host-authoritative game clock. The host broadcasts its time at 2 Hz; clients
/// snap to it when they drift more than a few game minutes.
///
/// <para><b>What the game's clock actually is (2026-09-29).</b> This class was
/// written believing <c>SessionData.gameTime</c> held "minutes since midnight".
/// It doesn't. SessionData derives the decimal hour, the day, date, month and
/// year from one running value — <c>ParseTimeData(float newTime, out
/// decimalHour, out dayInt, out dateInt, out month, out year, …)</c> — so
/// <c>gameTime</c> is a cumulative running clock (most likely in hours, going by
/// that shape). And the real master is <c>gameTimeDouble</c>: the float
/// <c>gameTime</c> is its per-frame mirror. Consequences, all consistent with
/// the 2026-07-30 client log:</para>
/// <list type="bullet">
///   <item><description><b>The sync never worked.</b> It wrote the float
///   mirror, which the game rebuilt from the double on the next frame. Thirty
///   snaps in one session, and the drift never closed.</description></item>
///   <item><description><b>The "constant 00:42" was garbage, not a frozen
///   host.</b> The host formatted the clock as <c>(int)(gt/60)%24 :
///   (int)gt%60</c> — minutes arithmetic on a running cumulative clock, which
///   prints nonsense whatever the real time. The display now comes from
///   <c>decimalClock</c>.</description></item>
///   <item><description><b>The drift and threshold units were a guess</b>
///   ("5.4 min" was most likely 5.4 game hours). The snap threshold is now
///   measured in real seconds of the clock's own movement, so it is right
///   whatever the unit turns out to be. NPC schedules run on this clock —
///   hours apart means citizens in completely different places.</description></item>
/// </list>
/// <para>Now: the host sends <c>gameTimeDouble</c> plus the leap-year cycle, and
/// the client sets its clock with the game's own <c>SetGameTime(float, int)</c>
/// — which re-derives hour, date, weekday, month and year consistently — and
/// then restores full precision on <c>gameTimeDouble</c>. The host's time speed
/// is mirrored too, so while the host sleeps or waits the client fast-forwards
/// with it instead of being yanked forward twice a second.</para>
/// </summary>
public class TimeSync
{
    #region Constants

    private const float TIME_SYNC_RATE = 0.5f;   // s between host broadcasts (2 Hz)

    /// <summary>Snap when the clocks differ by more than this many REAL seconds'
    /// worth of clock movement. Expressed in real time rather than game units on
    /// purpose: the static dump can't pin down the unit of gameTime (hours per
    /// ParseTimeData's shape, but the 2026-07-30 log is ambiguous), and a
    /// fixed game-unit threshold would either snap on packet latency twice a
    /// second or never fire at all if the guess were wrong. Measuring the
    /// clock's own rate makes the threshold correct in any unit, and it widens
    /// automatically while the host fast-forwards (sleep/wait).</summary>
    private const double SNAP_REAL_SECONDS = 3.0;

    /// <summary>Threshold used until the clock rate has been measured — only the
    /// first packet or two after joining, when a large snap is exactly what we
    /// want anyway.</summary>
    private const double FALLBACK_THRESHOLD = 0.05;

    #endregion

    #region Properties

    public float SyncedGameTime { get; private set; }
    public int   SyncedDay      { get; private set; }
    public int   SyncedHour     { get; private set; }
    public int   SyncedMinute   { get; private set; }
    public bool  IsPaused       { get; private set; }

    #endregion

    private float _lastSyncTime;
    private readonly NetDataWriter _writer = new();

    /// <summary>Snaps are coalesced into one log line per interval.</summary>
    private const float SNAP_LOG_INTERVAL_S = 10f;
    private float _lastSnapLogTime = -SNAP_LOG_INTERVAL_S;
    private int   _snapsSinceLog;
    private double _worstDriftSinceLog;
    private bool  _firstSnapVerified;

    // Local clock-rate estimate (game units per real second), EMA-smoothed.
    private double _rate = double.NaN;
    private double _rateLastGame;
    private float  _rateLastReal = -1f;

    /// <summary>Fold one reading of the local clock into the rate estimate.
    /// Reset after every snap, since a snap is a discontinuity, not motion.</summary>
    private void SampleRate(double current)
    {
        float now = Time.unscaledTime;
        if (_rateLastReal >= 0f)
        {
            float dt = now - _rateLastReal;
            if (dt < 0.2f) return;   // too short to measure; keep the older anchor
            double r = (current - _rateLastGame) / dt;
            if (r >= 0 && !double.IsInfinity(r))
                _rate = double.IsNaN(_rate) ? r : _rate * 0.8 + r * 0.2;
        }
        _rateLastReal = now;
        _rateLastGame = current;
    }

    // -------------------------------------------------------------------------

    public void Update()
    {
        if (!NetworkManager.IsConnected) return;
        if (!WorldReadyGate.IsWorldReady) return;

        if (NetworkManager.IsHost)
        {
            float now = Time.unscaledTime;
            if (now - _lastSyncTime >= TIME_SYNC_RATE)
            {
                _lastSyncTime = now;
                SyncTime();
            }
        }
    }

    // -------------------------------------------------------------------------

    private void SyncTime()
    {
        var info = GetCurrentGameTime();

        var packet = new TimeSyncPacket
        {
            GameTime       = info.GameTime,
            Day            = info.Day,
            Hour           = info.Hour,
            Minute         = info.Minute,
            IsPaused       = IsGamePaused(),
            DayInt         = info.DayInt,
            Month          = info.Month,
            GameTimeDouble = info.GameTimeDouble,
            LeapYearCycle  = info.LeapYearCycle,
            TimeSpeed      = info.TimeSpeed,
        };

        _writer.Reset();
        packet.Serialize(_writer);
        // Sequenced, not ReliableOrdered: this re-sends the ABSOLUTE clock
        // every TIME_SYNC_RATE (0.5 s) unconditionally, so a dropped packet
        // self-corrects on the next tick. Keeping it off the reliable channel
        // avoids head-of-line-stalling genuine state transitions (door/evidence
        // /money events) behind a retransmitted clock packet.
        NetworkManager.SendToAll(PacketType.TimeSync, _writer, DeliveryMethod.Sequenced);
    }

    // -------------------------------------------------------------------------

    public void OnPacketReceived(PacketType type, NetDataReader reader, int senderId)
    {
        if (NetworkManager.IsHost) return;
        if (type != PacketType.TimeSync) return;

        var packet = new TimeSyncPacket();
        packet.Deserialize(reader);
        ApplyTimePacket(packet);
    }

    private void ApplyTimePacket(TimeSyncPacket packet)
    {
        SyncedGameTime = packet.GameTime;
        SyncedDay      = packet.Day;
        SyncedHour     = packet.Hour;
        SyncedMinute   = packet.Minute;
        IsPaused       = packet.IsPaused;

        // Never write the clock of a world that is still loading — the load
        // rebuilds SessionData right after. (The 2026-07-30 log's first snap
        // landed mid-load, before the city even existed.)
        if (!WorldReadyGate.IsWorldReady) return;

        try
        {
            var session = SessionData.Instance;
            if (session == null) return;

            ApplyTimeSpeed(packet, session);

            // Prefer the double master; fall back to the float for an older host.
            double target = double.IsNaN(packet.GameTimeDouble) ? packet.GameTime : packet.GameTimeDouble;
            double current;
            try { current = session.gameTimeDouble; }
            catch { current = session.gameTime; }

            SampleRate(current);
            double threshold = double.IsNaN(_rate)
                ? FALLBACK_THRESHOLD
                : System.Math.Max(_rate * SNAP_REAL_SECONDS, 1e-4);

            double drift = System.Math.Abs(target - current);
            if (drift > threshold)
            {
                int leap = packet.LeapYearCycle;
                if (leap < 0) { try { leap = session.leapYearCycle; } catch { leap = 0; } }

                // The game's own setter re-derives decimal hour, date, weekday,
                // month and year from the new value. Then put full precision
                // back on the double master (the setter takes a float).
                session.SetGameTime((float)target, leap);
                try { session.gameTimeDouble = target; } catch { }
                _rateLastReal = -1f;   // discontinuity — restart the rate anchor

                _snapsSinceLog++;
                if (drift > _worstDriftSinceLog) _worstDriftSinceLog = drift;
                VerifyFirstSnap(session, target, drift);
                LogSnaps(packet);
            }

            ApplyDate(packet, session);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"TimeSync.ApplyTimePacket: {ex.Message}");
        }
    }

    /// <summary>Mirror the host's time speed (sleep / wait fast-forward), so the
    /// client's clock moves at the same rate instead of being snapped forward
    /// every half second while the host sleeps.</summary>
    private static void ApplyTimeSpeed(TimeSyncPacket packet, SessionData session)
    {
        if (packet.TimeSpeed < 0) return;
        try
        {
            var want = (SessionData.TimeSpeed)packet.TimeSpeed;
            // "simulation" is the city-generation pre-sim, never a live state.
            if (want == SessionData.TimeSpeed.simulation) return;
            if (session.currentTimeSpeed != want) session.SetTimeSpeed(want);
        }
        catch (System.Exception ex) { Plugin.Log.LogWarning($"[TimeSync] SetTimeSpeed: {ex.Message}"); }
    }

    /// <summary>Once per session, confirm the snap actually stuck — the reading
    /// of SessionData's clock this class now depends on.</summary>
    private void VerifyFirstSnap(SessionData session, double target, double drift)
    {
        if (_firstSnapVerified) return;
        _firstSnapVerified = true;
        try
        {
            double readD = session.gameTimeDouble;
            float readF = session.gameTime;
            float dec = 0f;
            try { dec = session.decimalClock; } catch { }
            Plugin.Log.LogInfo(
                $"[TimeSync] first snap: drift {drift:F3} → set {target:F3}; readback " +
                $"double={readD:F3} float={readF:F3} (stuck={System.Math.Abs(readD - target) < 0.01}) " +
                $"decimalClock={dec:F2} dayInt={session.dayInt}");
        }
        catch { }
    }

    private void LogSnaps(TimeSyncPacket packet)
    {
        float now = Time.unscaledTime;
        if (now - _lastSnapLogTime < SNAP_LOG_INTERVAL_S) return;
        Plugin.Log.LogDebug(
            $"TimeSync: {_snapsSinceLog} snap(s), worst drift {_worstDriftSinceLog:F3} (rate {_rate:F4}/s) → " +
            $"host day {packet.DayInt} {packet.Hour:D2}:{packet.Minute:D2}");
        _lastSnapLogTime = now;
        _snapsSinceLog = 0;
        _worstDriftSinceLog = 0;
    }

    /// <summary>Fallback date correction, only on an actual mismatch.
    /// <c>SetGameTime</c> re-derives the date from the clock, so normally this
    /// finds nothing to do; it stays for an older host that doesn't send the
    /// double master, where the float path can't be trusted to carry the date.</summary>
    private void ApplyDate(TimeSyncPacket packet, SessionData session)
    {
        if (packet.DayInt < 0) return;   // older sender without the date

        try
        {
            if (session.dayInt != packet.DayInt)
            {
                int before = session.dayInt;
                session.dayInt = packet.DayInt;
                Plugin.Log.LogInfo(
                    $"[TimeSync] date corrected: dayInt {before} → {packet.DayInt} " +
                    "(NPC schedules are weekday-driven).");
            }
            if ((int)session.day != packet.Day)
                session.day = (global::SessionData.WeekDay)packet.Day;
            if (packet.Month >= 0 && (int)session.month != packet.Month)
                session.month = (global::SessionData.Month)packet.Month;
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"[TimeSync] ApplyDate: {ex.Message}");
        }
    }

    // -------------------------------------------------------------------------

    private static GameTimeInfo GetCurrentGameTime()
    {
        var info = new GameTimeInfo
        {
            GameTime = 0f, GameTimeDouble = double.NaN, Day = 1,
            DayInt = -1, Month = -1, LeapYearCycle = -1, TimeSpeed = -1,
        };
        try
        {
            var session = SessionData.Instance;
            if (session == null) return info;

            info.GameTime = session.gameTime;
            try { info.GameTimeDouble = session.gameTimeDouble; } catch { }
            try { info.LeapYearCycle  = session.leapYearCycle; } catch { }
            try { info.TimeSpeed      = (int)session.currentTimeSpeed; } catch { }
            try { info.DayInt         = session.dayInt; } catch { }
            try { info.Month          = (int)session.month; } catch { }
            try { info.Day            = (int)session.day; } catch { }

            // Hour/minute for display and logs come from the decimal clock
            // (0-24). The old code did minutes arithmetic on gameTime, which is
            // a cumulative HOUR count — hence the permanent "00:42".
            float dec = 0f;
            try { dec = session.decimalClock; } catch { }
            info.Hour   = Mathf.Clamp((int)dec, 0, 23);
            info.Minute = Mathf.Clamp((int)((dec - (int)dec) * 60f), 0, 59);
        }
        catch { }
        return info;
    }

    private static bool IsGamePaused() => Time.timeScale == 0f;
}

/// <summary>Helper struct for game time data.</summary>
public struct GameTimeInfo
{
    public float  GameTime;        // session.gameTime — float mirror of the cumulative hour count
    public double GameTimeDouble;  // session.gameTimeDouble — the real master (NaN = unknown)
    public int    LeapYearCycle;   // session.leapYearCycle (-1 = unknown)
    public int    TimeSpeed;       // session.currentTimeSpeed (-1 = unknown)
    public int    Day;             // session.day — WeekDay enum, not a counter
    public int    Hour;            // from decimalClock
    public int    Minute;          // from decimalClock
    public int    DayInt;          // session.dayInt — absolute day counter (-1 = unknown)
    public int    Month;           // session.month enum (-1 = unknown)
}
