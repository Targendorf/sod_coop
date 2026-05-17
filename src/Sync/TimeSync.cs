using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Synchronizes game time between host and clients.
///
/// Host: every TIME_SYNC_RATE seconds reads SessionData.gameTime (minutes)
///       and broadcasts via PacketType.TimeSync (ReliableOrdered).
///
/// Client: receives the packet and immediately applies the host's time.
///         Small drifts (< SNAP_THRESHOLD) are smoothed over SMOOTH_RATE
///         seconds; larger drifts are snapped instantly to avoid clocks
///         running visually ahead/behind.
/// </summary>
public class TimeSync
{
    #region Constants

    private const float TIME_SYNC_RATE  = 0.5f;   // s between host broadcasts (2 Hz)
    private const float SNAP_THRESHOLD  = 0.5f;   // game-minutes — snap directly above this
    private const float SMOOTH_RATE     = 0.5f;   // fraction per call for small corrections (50%)

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

    // Snap-log throttle: snaps fire at the broadcast rate (2 Hz). Logging every
    // one of them at LogInfo floods BepInEx's console — 120 lines/min just for
    // time sync, and the BepInEx writer is noticeably hot in IL2CPP. Coalesce
    // identical-day snaps into one log line per 5 seconds.
    private const float SNAP_LOG_INTERVAL_S = 5f;
    private float _lastSnapLogTime = -SNAP_LOG_INTERVAL_S;
    private int   _snapsSinceLog;
    private int   _lastLoggedDay = int.MinValue;
    private int   _lastLoggedHour = -1;
    private int   _lastLoggedMin = -1;

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
            GameTime = info.GameMinutes,
            Day      = info.Day,
            Hour     = info.Hour,
            Minute   = info.Minute,
            IsPaused = IsGamePaused(),
        };

        _writer.Reset();
        packet.Serialize(_writer);
        NetworkManager.SendToAll(PacketType.TimeSync, _writer, DeliveryMethod.ReliableOrdered);
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

        try
        {
            var session = SessionData.Instance;
            if (session == null) return;

            float current = session.gameTime;         // minutes
            float target  = packet.GameTime;          // minutes from host
            float drift   = Mathf.Abs(target - current);

            if (drift > SNAP_THRESHOLD)
            {
                // Large drift — snap immediately.
                session.gameTime = target;
                _snapsSinceLog++;

                // Throttle: log at most every SNAP_LOG_INTERVAL_S, or when the
                // displayed Day/Hour/Minute changes (so the player still gets
                // visible time-change feedback in the log without it spamming).
                float now = Time.unscaledTime;
                bool clockChanged = packet.Day != _lastLoggedDay
                                 || packet.Hour != _lastLoggedHour
                                 || packet.Minute != _lastLoggedMin;
                if (clockChanged || now - _lastSnapLogTime >= SNAP_LOG_INTERVAL_S)
                {
                    if (_snapsSinceLog > 1)
                        Plugin.Log.LogDebug(
                            $"TimeSync: snapped clock {drift:F1} min → " +
                            $"Day {packet.Day} {packet.Hour:D2}:{packet.Minute:D2} " +
                            $"(coalesced ×{_snapsSinceLog})");
                    else
                        Plugin.Log.LogDebug(
                            $"TimeSync: snapped clock {drift:F1} min → " +
                            $"Day {packet.Day} {packet.Hour:D2}:{packet.Minute:D2}");

                    _lastSnapLogTime = now;
                    _snapsSinceLog = 0;
                    _lastLoggedDay = packet.Day;
                    _lastLoggedHour = packet.Hour;
                    _lastLoggedMin = packet.Minute;
                }
            }
            else if (drift > 0.05f)
            {
                // Small drift — nudge 50% toward target per call (called 2 Hz).
                session.gameTime = Mathf.Lerp(current, target, SMOOTH_RATE);
            }
            // else within noise — do nothing
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"TimeSync.ApplyTimePacket: {ex.Message}");
        }
    }

    // -------------------------------------------------------------------------

    private static GameTimeInfo GetCurrentGameTime()
    {
        try
        {
            var session = SessionData.Instance;
            if (session != null)
            {
                float gt     = session.gameTime;   // minutes since midnight (float)
                int   hour   = ((int)(gt / 60f)) % 24;
                int   minute = ((int)gt) % 60;
                return new GameTimeInfo
                {
                    GameMinutes = gt,
                    Day         = (int)session.day,
                    Hour        = hour,
                    Minute      = minute,
                };
            }
        }
        catch { }

        return new GameTimeInfo { GameMinutes = 0f, Day = 1, Hour = 0, Minute = 0 };
    }

    private static bool IsGamePaused() => Time.timeScale == 0f;
}

/// <summary>Helper struct for game time data.</summary>
public struct GameTimeInfo
{
    public float GameMinutes;   // session.gameTime (minutes since midnight, float)
    public int   Day;
    public int   Hour;
    public int   Minute;
}
