using System;
using UnityEngine;

namespace SoDCoop.Player;

/// <summary>
/// Stable per-installation identifier used to recognise a returning client
/// across reconnections. LiteNetLib only gives us IPs, which can change
/// (NAT, network swap, port), so we mint a GUID once and store it in
/// PlayerPrefs. The host keeps a (worldSeed → clientGuid → character)
/// map so the same human always lands in the same in-game character.
///
/// This is purely an identifier — no character info lives here. The
/// character record (first name / surname) is owned by the host's
/// <see cref="SoDCoop.Sync.CharacterStore"/>.
/// </summary>
public static class CharacterIdentity
{
    private const string PREF_KEY = "SoDCoop_ClientGuid";

    private static string _cached;

    /// <summary>
    /// Returns this installation's stable client GUID. Generated on first
    /// access and persisted in PlayerPrefs forever (until the player
    /// manually wipes it).
    /// </summary>
    public static string ClientGuid
    {
        get
        {
            if (!string.IsNullOrEmpty(_cached)) return _cached;
            try
            {
                _cached = PlayerPrefs.GetString(PREF_KEY, "");
                if (string.IsNullOrEmpty(_cached))
                {
                    _cached = Guid.NewGuid().ToString("N");
                    PlayerPrefs.SetString(PREF_KEY, _cached);
                    PlayerPrefs.Save();
                    Plugin.Log.LogInfo($"[CharacterIdentity] new clientGuid minted: {_cached}");
                }
            }
            catch (Exception ex)
            {
                Plugin.Log.LogWarning($"[CharacterIdentity] PlayerPrefs failed: {ex.Message} — falling back to in-memory GUID (will reset on game restart).");
                _cached = Guid.NewGuid().ToString("N");
            }
            return _cached;
        }
    }

    /// <summary>
    /// Drops the cached identity. Used by the future "Reset character"
    /// button in the menu when the player wants to be a different person
    /// in the host's world.
    /// </summary>
    public static void Reset()
    {
        try
        {
            PlayerPrefs.DeleteKey(PREF_KEY);
            PlayerPrefs.Save();
        }
        catch { }
        _cached = null;
        Plugin.Log.LogInfo("[CharacterIdentity] reset — next access will mint a new GUID.");
    }
}
