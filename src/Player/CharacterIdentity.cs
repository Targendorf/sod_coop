using System;
using UnityEngine;

namespace SoDCoop.Player;

/// <summary>
/// Stable per-profile identifier used to recognise a returning client across
/// reconnections. With the multi-profile refactor, this is a thin proxy
/// over <see cref="ProfileStore.Active"/>.<c>ClientGuid</c> — each profile
/// owns its own guid so the host treats them as separate identities.
///
/// <para>Backwards compatibility: the legacy single-installation guid
/// (PlayerPrefs key <c>SoDCoop_ClientGuid</c>) is migrated into a starter
/// profile by <see cref="ProfileStore"/> on first access. If no profile
/// has been created yet (e.g. the user wiped their config), an in-memory
/// fallback guid is minted so connection logic doesn't crash; the user
/// will be steered to create a profile in the menu.</para>
/// </summary>
public static class CharacterIdentity
{
    private const string LEGACY_PREF_KEY = "SoDCoop_ClientGuid";

    private static string _fallback;

    /// <summary>
    /// Active profile's guid, or a one-shot fallback if no profile exists.
    /// </summary>
    public static string ClientGuid
    {
        get
        {
            try
            {
                var p = ProfileStore.Active;
                if (p != null && !string.IsNullOrEmpty(p.ClientGuid)) return p.ClientGuid;
            }
            catch (Exception ex)
            {
                Plugin.Log.LogWarning($"[CharacterIdentity] ProfileStore lookup failed: {ex.Message}");
            }

            if (string.IsNullOrEmpty(_fallback))
            {
                _fallback = Guid.NewGuid().ToString("N");
                Plugin.Log.LogWarning($"[CharacterIdentity] no active profile — using volatile fallback guid {_fallback}");
            }
            return _fallback;
        }
    }

    /// <summary>
    /// Wipes the legacy PlayerPrefs guid. Profiles themselves are managed
    /// via <see cref="ProfileStore"/>; this remains for the existing
    /// "Reset coop identity" UI button which now nudges the user back to
    /// the profile picker.
    /// </summary>
    public static void Reset()
    {
        try
        {
            PlayerPrefs.DeleteKey(LEGACY_PREF_KEY);
            PlayerPrefs.Save();
        }
        catch { }
        _fallback = null;
        Plugin.Log.LogInfo("[CharacterIdentity] legacy clientGuid wiped.");
    }
}
