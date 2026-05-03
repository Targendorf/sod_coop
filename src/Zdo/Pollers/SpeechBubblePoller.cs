using System;
using System.Collections.Generic;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Per-tick speech-bubble diff. Walks every Actor in the live city plus
/// the local <c>Player.Instance</c>; when an Actor's
/// <c>speechController.activeSpeechBubble</c> transitions from null /
/// typewriting → "final text revealed", broadcasts that bubble's resolved
/// text via <see cref="ZdoEvents.SPEECH_BUBBLE"/>. Receivers replay the
/// same line via <c>speechController.Speak</c> so sideline players see
/// what NPCs and other players are saying.
///
/// <para><b>Authority split</b>: this poller runs on every peer (host AND
/// clients) but each peer only broadcasts bubbles for actors whose
/// authoritative SpeechController lives on its own machine:
/// <list type="bullet">
///   <item><b>Host</b>: every citizen + host's own Player.Instance.</item>
///   <item><b>Client</b>: only its own Player.Instance, broadcast under
///         <see cref="SoDCoop.Network.NetworkManager.MyTwinHumanID"/> so
///         the receiver finds the same Actor in its citizenDictionary.</item>
/// </list>
/// </para>
///
/// <para><b>Final-text trigger</b>: SoD's bubble runs a typewriter effect
/// (<c>setFinalText = true</c> once typing is done). We only broadcast
/// once per bubble — at the transition into final-text — to avoid
/// shipping every typewriter frame. A per-actor (humanId, lastText) pair
/// dedups against re-broadcasts when the same actor speaks the same line
/// twice in a row (rare but possible).</para>
///
/// <para>Field discovery (Assembly-CSharp_Dump):
/// <list type="bullet">
///   <item><c>Actor.speechController : SpeechController</c> (Actor.cs:1551)</item>
///   <item><c>SpeechController.activeSpeechBubble</c> (SpeechController.cs:906)</item>
///   <item><c>SpeechBubbleController.actualString : string</c> (108)</item>
///   <item><c>SpeechBubbleController.setFinalText : bool</c> (228)</item>
///   <item><c>SpeechController.Speak(string, bool, bool, ...)</c> (1045)</item>
///   <item><c>QueueElement.shouting : bool</c> (145)</item>
/// </list></para>
/// </summary>
public static class SpeechBubblePoller
{
    public const float TICK_HZ = 10f;
    public const string NAME = "speech-bubble";

    /// <summary>Last broadcast (humanId, text) per Actor — diff baseline so
    /// a single line never goes out twice.</summary>
    private static readonly Dictionary<int, string> _last = new();

    /// <summary>True for the FIRST tick we observed an actor's bubble in
    /// the final-text state — used to detect the transition out of
    /// typewriting (the only valid moment to broadcast).</summary>
    private static readonly Dictionary<int, bool> _finalSeen = new();

    public static void Register() => ZdoPollerHost.RegisterAnyPeer(NAME, 1f / TICK_HZ, Tick);

    public static void ResetBaseline() { _last.Clear(); _finalSeen.Clear(); }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        if (!SoDCoop.Network.NetworkManager.HasPeers) return;

        try
        {
            // 1. Local Player.Instance — every peer broadcasts its own.
            try
            {
                var p = global::Player.Instance;
                if (p != null)
                {
                    int speakerId;
                    if (SoDCoop.Network.NetworkManager.IsHost)
                    {
                        // Host's player IS its own citizen — its humanID is
                        // already in citizenDictionary on every peer.
                        try { speakerId = p.humanID; } catch { speakerId = 0; }
                    }
                    else
                    {
                        // Client's local Player.Instance.humanID doesn't exist
                        // on host's machine — the host knows the player as
                        // their twin citizen. MyTwinHumanID is the host-stamped
                        // citizen humanId carried in Handshake/PlayerJoined.
                        speakerId = SoDCoop.Network.NetworkManager.MyTwinHumanID;
                    }
                    if (speakerId > 0) ProbeAndBroadcast(speakerId, p);
                }
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[SpeechBubblePoller] local-player: {ex.Message}"); }

            // 2. All citizens — host only, since host owns the NPC simulation.
            if (!SoDCoop.Network.NetworkManager.IsHost) return;
            var dict = CityData.Instance?.citizenDictionary;
            if (dict == null) return;

            foreach (var kv in dict)
            {
                var c = kv.Value;
                if (c == null) continue;
                int id = c.humanID;
                if (id == 0) continue;
                ProbeAndBroadcast(id, c);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SpeechBubblePoller] tick: {ex.Message}"); }
    }

    private static void ProbeAndBroadcast(int humanId, global::Actor actor)
    {
        try
        {
            var sc = actor.speechController;
            if (sc == null) return;
            var sb = sc.activeSpeechBubble;
            if (sb == null)
            {
                // Bubble cleared — reset transition flag so the NEXT bubble
                // gets broadcast at its final-text transition.
                _finalSeen[humanId] = false;
                return;
            }

            bool isFinal = false;
            try { isFinal = sb.setFinalText; } catch { return; }
            if (!isFinal)
            {
                // Still typewriting. Wait.
                _finalSeen[humanId] = false;
                return;
            }

            // We've already broadcast this transition.
            if (_finalSeen.TryGetValue(humanId, out var seen) && seen) return;

            string text = null;
            try { text = sb.actualString; } catch { }
            if (string.IsNullOrEmpty(text)) { _finalSeen[humanId] = true; return; }

            // Dedup against the most recently sent line for this actor.
            if (_last.TryGetValue(humanId, out var prev) && string.Equals(prev, text, StringComparison.Ordinal))
            {
                _finalSeen[humanId] = true;
                return;
            }

            bool shouting = false;
            try { shouting = sb.speech?.shouting ?? false; } catch { }

            try
            {
                SoDCoop.Zdo.ZdoEvents.SendSpeechBubble(humanId, text, shouting);
                _last[humanId] = text;
                _finalSeen[humanId] = true;
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[SpeechBubblePoller] send {humanId}: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SpeechBubblePoller] probe {humanId}: {ex.Message}"); }
    }
}
