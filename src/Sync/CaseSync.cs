using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Synchronizes case/investigation progress between players.
/// </summary>
public class CaseSync
{
    #region Constants
    
    private const float CASE_SYNC_RATE = 0.5f;
    
    #endregion
    
    #region Private Fields
    
    private float _lastSyncTime;
    private readonly NetDataWriter _writer = new();
    
    #endregion
    
    public void Update()
    {
        if (!NetworkManager.IsConnected) return;
        
        // Only host sends case state
        if (!NetworkManager.IsHost) return;
        
        if (Time.time - _lastSyncTime < CASE_SYNC_RATE) return;
        _lastSyncTime = Time.time;
        
        // Sync case state if there's an active case
        // Implementation depends on game's case system
    }
    
    public void OnPacketReceived(PacketType type, NetDataReader reader, int senderId)
    {
        // Handle case-related packets
        if (type == PacketType.EvidenceFound)
        {
            // evidenceId, locationId, position, time
            int evidenceId = reader.GetInt();
            int locationId = reader.GetInt();
            Vector3 position = reader.GetVector3();
            // Store/Log
            Plugin.Log.LogDebug($"Received Evidence: ID {evidenceId} at {locationId}");
        }
        else if (type == PacketType.Interrogation)
        {
            // citizenId, questionId, responseId, time
            int citizenId = reader.GetInt();
            int questionId = reader.GetInt();
            int responseId = reader.GetInt();
            Plugin.Log.LogDebug($"Received Interrogation: Cit {citizenId} Q {questionId} A {responseId}");
        }
        else if (type == PacketType.Arrest)
        {
            int citizenId = reader.GetInt();
            bool correct = reader.GetBool();
            Plugin.Log.LogDebug($"Received Arrest: Cit {citizenId} Correct? {correct}");
        }
        else if (type == PacketType.CaseResult)
        {
            bool solved = reader.GetBool();
            int suspectId = reader.GetInt();
            Plugin.Log.LogDebug($"Received Case Result: Solved? {solved}");
        }
    }
    
    /// <summary>
    /// Called when evidence is found to sync it to other players.
    /// </summary>
    public void OnEvidenceFound(int evidenceId, int locationId, Vector3 position)
    {
        if (!NetworkManager.IsConnected) return;
        
        _writer.Reset();
        _writer.Put(evidenceId);
        _writer.Put(locationId);
        _writer.Put(position);
        _writer.Put(Time.time);
        
        NetworkManager.SendToAll(PacketType.EvidenceFound, _writer, DeliveryMethod.ReliableOrdered);
        
        Plugin.Log.LogDebug($"Evidence {evidenceId} synced to other players.");
    }
    
    /// <summary>
    /// Called when a citizen is interrogated.
    /// </summary>
    public void OnInterrogation(int citizenId, int questionId, int responseId)
    {
        if (!NetworkManager.IsConnected) return;
        
        _writer.Reset();
        _writer.Put(citizenId);
        _writer.Put(questionId);
        _writer.Put(responseId);
        _writer.Put(Time.time);
        
        NetworkManager.SendToAll(PacketType.Interrogation, _writer, DeliveryMethod.ReliableOrdered);
    }
    
    /// <summary>
    /// Called when the case board is updated.
    /// </summary>
    public void OnCaseBoardUpdate()
    {
        if (!NetworkManager.IsConnected) return;
        
        // Serialize the entire case board state
        // This is complex and depends on the game's case board implementation
        
        // Placeholder: send a notification that board changed
        _writer.Reset();
        _writer.Put(Time.time);
        
        NetworkManager.SendToAll(PacketType.CaseBoard, _writer, DeliveryMethod.ReliableOrdered);
    }
    
    /// <summary>
    /// Called when a suspect is arrested.
    /// </summary>
    public void OnArrest(int citizenId, bool isCorrectSuspect)
    {
        if (!NetworkManager.IsConnected) return;
        
        _writer.Reset();
        _writer.Put(citizenId);
        _writer.Put(isCorrectSuspect);
        _writer.Put(Time.time);
        
        NetworkManager.SendToAll(PacketType.Arrest, _writer, DeliveryMethod.ReliableOrdered);
        
        Plugin.Log.LogDebug($"Arrest synced: Citizen {citizenId}, Correct: {isCorrectSuspect}");
    }
    
    /// <summary>
    /// Called when the case is resolved (solved or failed).
    /// </summary>
    public void OnCaseResult(bool solved, int suspectId)
    {
        if (!NetworkManager.IsConnected) return;
        
        _writer.Reset();
        _writer.Put(solved);
        _writer.Put(suspectId);
        _writer.Put(Time.time);
        
        NetworkManager.SendToAll(PacketType.CaseResult, _writer, DeliveryMethod.ReliableOrdered);
        
        Plugin.Log.LogDebug($"Case result synced: {(solved ? "SOLVED" : "FAILED")}");
    }
}
