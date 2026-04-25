using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Synchronizes game time between host and clients.
/// </summary>
public class TimeSync
{
    #region Constants
    
    /// <summary>
    /// How often to sync time.
    /// </summary>
    private const float TIME_SYNC_RATE = 1.0f;
    
    /// <summary>
    /// Maximum allowed time difference before forcing correction.
    /// </summary>
    private const float MAX_TIME_DRIFT = 5f; // seconds of game time
    
    #endregion
    
    #region Properties
    
    /// <summary>
    /// Current synced game time.
    /// </summary>
    public float SyncedGameTime { get; private set; }
    
    /// <summary>
    /// Current synced day.
    /// </summary>
    public int SyncedDay { get; private set; }
    
    /// <summary>
    /// Current synced hour.
    /// </summary>
    public int SyncedHour { get; private set; }
    
    /// <summary>
    /// Current synced minute.
    /// </summary>
    public int SyncedMinute { get; private set; }
    
    /// <summary>
    /// Whether game is paused.
    /// </summary>
    public bool IsPaused { get; private set; }
    
    #endregion
    
    #region Private Fields
    
    private float _lastSyncTime;
    private readonly NetDataWriter _writer = new();
    
    #endregion
    
    public void Update()
    {
        // MVP: time sync disabled — each client runs its own clock.
        return;
    }
    
    private void SyncTime()
    {
        // Get current game time from game's time system
        // This needs to be adapted to match the actual game's time controller
        var gameTime = GetCurrentGameTime();
        
        var packet = new TimeSyncPacket
        {
            GameTime = gameTime.TotalSeconds,
            Day = gameTime.Day,
            Hour = gameTime.Hour,
            Minute = gameTime.Minute,
            IsPaused = IsGamePaused()
        };
        
        _writer.Reset();
        packet.Serialize(_writer);
        
        NetworkManager.SendToAll(PacketType.TimeSync, _writer, DeliveryMethod.ReliableOrdered);
    }
    
    public void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        // Client-side: receive time sync from host
        if (NetworkManager.IsHost) return;
        
        if (type == PacketType.TimeSync)
        {
            var packet = new TimeSyncPacket();
            packet.Deserialize(reader);
            OnTimeSyncReceived(packet);
        }
    }
    
    public void OnTimeSyncReceived(TimeSyncPacket packet)
    {
        if (NetworkManager.IsHost) return;
        
        SyncedGameTime = packet.GameTime;
        SyncedDay = packet.Day;
        SyncedHour = packet.Hour;
        SyncedMinute = packet.Minute;
        IsPaused = packet.IsPaused;
        
        // Check for significant drift and correct if needed
        var currentTime = GetCurrentGameTime();
        float drift = Mathf.Abs(currentTime.TotalSeconds - packet.GameTime);
        
        if (drift > MAX_TIME_DRIFT)
        {
            Plugin.Log.LogWarning($"Time drift detected: {drift}s. Correcting...");
            SetGameTime(packet);
        }
    }
    
    #region Game Time Helpers
    
    private GameTimeInfo GetCurrentGameTime()
    {
        try
        {
            var session = SessionData.Instance;
            if (session != null)
            {
                // session.gameTime is minutes since midnight (SessionData.FloatMinutes24H uses it that way)
                float gt = session.gameTime;
                int hour = ((int)(gt / 60f)) % 24;
                int minute = ((int)gt) % 60;
                return new GameTimeInfo
                {
                    TotalSeconds = gt,
                    Day = (int)session.day,
                    Hour = hour,
                    Minute = minute
                };
            }
        }
        catch { }
        
        return new GameTimeInfo
        {
            TotalSeconds = Time.time,
            Day = 1,
            Hour = 12,
            Minute = 0
        };
    }
    
    private bool IsGamePaused()
    {
        return Time.timeScale == 0f;
    }
    
    private void SetGameTime(TimeSyncPacket packet)
    {
        try
        {
            var session = SessionData.Instance;
            if (session != null)
            {
                // Correct time drift by adjusting game time
                session.gameTime = packet.GameTime;
                Plugin.Log.LogInfo($"Time corrected to Day {packet.Day}, {packet.Hour}:{packet.Minute:D2}");
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"Failed to set game time: {ex.Message}");
        }
    }
    
    #endregion
}

/// <summary>
/// Helper struct for game time data.
/// </summary>
public struct GameTimeInfo
{
    public float TotalSeconds;
    public int Day;
    public int Hour;
    public int Minute;
}
