using System;
using LiteNetLib.Utils;
using SoDCoop.Network;
using SoDCoop.Network.Steam;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Joiner-side automatic world generation. When the friend's client
/// connects to a host, the host pushes a <see cref="WorldDescriptorPacket"/>
/// describing its in-game world (share-code + seed + cityName + citySize).
/// This class parses that packet and calls SoD's
/// <c>MainMenuController.ParseShareCode</c> +
/// <c>ConfirmCityGeneration</c> pipeline to bootstrap the joiner's own
/// city — same seed, same buildings, same NPCs — before the ZDO snapshot
/// is applied on top to align the live state.
///
/// <para><b>Pre-conditions</b>: the joiner must be on SoD's main menu
/// when the descriptor arrives (<c>MainMenuController.Instance != null</c>).
/// The Coop UI's Join panel already enforces this gate
/// (<c>WorldReadyGate.IsWorldReady == false</c>).</para>
///
/// <para><b>Post-condition</b>: SoD's normal "Generate city" loading
/// screen takes over for ~30s. <see cref="WorldReadyGate"/> fires once
/// generation completes; <see cref="NetworkManager"/> then notifies the
/// host via <see cref="PacketType.ClientWorldReady"/> to request the ZDO
/// snapshot.</para>
/// </summary>
public static class WorldAutoLoad
{
    /// <summary>True between receiving the descriptor and the WorldReady
    /// event firing — used to suppress the auto-character-submit panel,
    /// snapshot apply, etc., while the joiner is still on the loading
    /// screen.</summary>
    public static bool IsBootstrappingWorld { get; private set; }

    /// <summary>Cached descriptor for the in-flight join. Cleared after
    /// SoD's WorldReady fires.</summary>
    public static WorldDescriptorPacket Pending { get; private set; }

    /// <summary>
    /// Called by <see cref="NetworkManager.HandleTransportMessage"/> when
    /// the host's <see cref="PacketType.WorldDescriptor"/> arrives.
    /// </summary>
    public static void OnDescriptorReceived(WorldDescriptorPacket d)
    {
        Pending = d;
        IsBootstrappingWorld = true;

        Plugin.Log.LogInfo(
            $"[WorldAutoLoad] descriptor: seed='{d.Seed}' cityName='{d.CityName}' " +
            $"shareCode='{d.ShareCode}' size=({d.CitySizeX}x{d.CitySizeY})");

        try
        {
            // If we're already in a city, abort: nothing we can do safely.
            // The Join UI is supposed to enforce main-menu, but defensively
            // check anyway.
            if (WorldReadyGate.IsWorldReady)
            {
                Plugin.Log.LogWarning(
                    "[WorldAutoLoad] joiner is already in a city — auto-load skipped. " +
                    "Hand-shake will continue but world state may not match the host.");
                IsBootstrappingWorld = false;
                return;
            }

            TriggerSoDGeneration(d);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[WorldAutoLoad] OnDescriptorReceived: {ex}");
            IsBootstrappingWorld = false;
        }
    }

    /// <summary>
    /// Pokes SoD's <c>MainMenuController</c> through the same code path
    /// the user would normally walk: paste a share-code, then confirm
    /// generation. The internal pipeline starts loading on the next frame.
    /// </summary>
    private static void TriggerSoDGeneration(WorldDescriptorPacket d)
    {
        var mmc = global::MainMenuController.Instance;
        if (mmc == null)
        {
            Plugin.Log.LogError(
                "[WorldAutoLoad] MainMenuController.Instance is null — joiner is not on the main menu. " +
                "Cannot auto-launch generation.");
            IsBootstrappingWorld = false;
            return;
        }

        // Listen for WorldReady up-front so we don't miss the signal even if
        // generation kicks off synchronously inside ConfirmCityGeneration.
        WorldReadyGate.OnWorldReady -= OnWorldReadyAfterAutoLoad;
        WorldReadyGate.OnWorldReady += OnWorldReadyAfterAutoLoad;

        // ── Step 1: navigate the menu into the "Generate New City" panel ─
        // ConfirmCityGeneration is the Yes-button handler of a popup that
        // only fires from the generateCity panel; calling it from the
        // top-level main menu silently no-ops (which is what we observed on
        // the first test — ParseShareCode "applied" then nothing).
        try
        {
            mmc.SelectGenNewCity();
            Plugin.Log.LogInfo("[WorldAutoLoad] SelectGenNewCity() — moved to generateCity panel.");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[WorldAutoLoad] SelectGenNewCity threw: {ex.Message}");
            // Not fatal — we'll fall back to a direct CityConstructor call.
        }

        // ── Step 2: feed the share-code through SoD's parser ──────────────
        // ParseShareCode populates name + size + version + seed from the
        // encoded string. The host now sends a real `Toolbox.GetShareCode`
        // result (not a bare seed), so this round-trips back to a valid
        // CityControls state.
        string code = !string.IsNullOrEmpty(d.ShareCode) ? d.ShareCode : d.Seed;
        try
        {
            mmc.ParseShareCode(code);
            Plugin.Log.LogInfo($"[WorldAutoLoad] ParseShareCode applied: '{code}'.");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[WorldAutoLoad] ParseShareCode threw: {ex}");
        }

        // ── Step 2.5: suppress ChapterIntro / tutorial ───────────────────
        // SoD's first-run flow plays ChapterIntro on a fresh city — that's
        // what the player sees as "tutorial" (cinematic + scripted clue
        // spawns + scripted mission setup). For a coop joiner we never want
        // this: the host has already played through (or is sandbox), so the
        // intro on the joiner just blocks input and shuffles cameras while
        // the ZDO snapshot streams in. Worse, the intro's scripted spawns
        // (kidnapper / notewriter / killer clues) compete with the host's
        // already-spawned versions arriving through EvidenceSync.
        //
        // Force Game.skipIntro=true and Game.loadChapter=-1 BEFORE
        // ConfirmCityGeneration so SoD's chapter selector picks "no chapter"
        // when the city loads. ChapterController will short-circuit and the
        // player drops straight into sandbox-style play. The host-driven
        // world state then arrives via ZDOs and is applied on top.
        try
        {
            var game = global::Game.Instance;
            if (game != null)
            {
                game.skipIntro = true;
                game.loadChapter = -1;
                Plugin.Log.LogInfo(
                    "[WorldAutoLoad] forced Game.skipIntro=true, Game.loadChapter=-1 (suppress tutorial intro for coop joiner).");
            }
            else
            {
                Plugin.Log.LogWarning(
                    "[WorldAutoLoad] Game.Instance was null while preparing intro-skip — tutorial may still play.");
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning(
                $"[WorldAutoLoad] failed to set Game.skipIntro / loadChapter: {ex.Message} — tutorial may still play.");
        }

        // ── Step 3: kick off generation ──────────────────────────────────
        // SoD's normal flow is: user clicks Generate → OnContinueCityGeneration
        // (popup appears) → user clicks Yes → ConfirmCityGeneration (loading
        // screen). Call both so we're walking the same code path.
        bool generationStarted = false;
        try
        {
            mmc.ConfirmCityGeneration();
            Plugin.Log.LogInfo("[WorldAutoLoad] ConfirmCityGeneration() invoked.");
            generationStarted = true;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[WorldAutoLoad] ConfirmCityGeneration threw: {ex.Message}");
        }

        // No direct CityConstructor fallback. ConfirmCityGeneration is
        // async — it queues the load and returns immediately, so the
        // CityConstructor.loadingOperationActive flag isn't necessarily
        // set the same frame. The earlier fallback "if not loading after
        // ConfirmCityGeneration, call GenerateCityFromShareCode directly"
        // was triggering a SECOND call to the same internal method
        // (ConfirmCityGeneration → CityConstructor.GenerateCityFromShareCode
        // is the same code path internally), which raced with the first
        // and NRE'd on a half-initialized CityControls state. Logged in
        // the joiner test:
        //   [WorldAutoLoad] ConfirmCityGeneration() invoked.
        //   [WorldAutoLoad] CityConstructor not loading ... invoking GenerateCityFromShareCode() directly.
        //   [WorldAutoLoad] direct CityConstructor invoke threw: NullReferenceException
        // Despite that NRE, the world still loaded successfully a few
        // seconds later (WorldReadyGate fired) — confirming
        // ConfirmCityGeneration was sufficient on its own.
        if (!generationStarted)
        {
            Plugin.Log.LogError("[WorldAutoLoad] ConfirmCityGeneration() did not start — joiner will sit on main menu.");
            IsBootstrappingWorld = false;
        }
    }

    private static void OnWorldReadyAfterAutoLoad()
    {
        WorldReadyGate.OnWorldReady -= OnWorldReadyAfterAutoLoad;
        if (!IsBootstrappingWorld) return;

        IsBootstrappingWorld = false;
        Plugin.Log.LogInfo("[WorldAutoLoad] WorldReady — notifying host to send ZDO snapshot.");

        // Catch up: any ZDOs that streamed in via real-time deltas while
        // we were on the loading screen had their resolver-apply skipped
        // (live SoD refs didn't exist yet). Now that the world is up, walk
        // the registry once and apply everything.
        try { SoDCoop.Zdo.ZdoMan.ApplyAllToLiveWorld(); }
        catch (Exception ex) { Plugin.Log.LogWarning($"[WorldAutoLoad] ApplyAllToLiveWorld: {ex.Message}"); }

        // Tell the host: "I'm in the city, please send ZDO state now".
        try
        {
            var w = new NetDataWriter();
            NetworkManager.SendToHost(PacketType.ClientWorldReady, w);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[WorldAutoLoad] failed to notify host of ready state: {ex.Message}");
        }
    }

    /// <summary>Reset for re-use on next session.</summary>
    public static void Reset()
    {
        IsBootstrappingWorld = false;
        Pending = default;
        WorldReadyGate.OnWorldReady -= OnWorldReadyAfterAutoLoad;
    }
}

/// <summary>
/// Wire-format payload for <see cref="PacketType.WorldDescriptor"/>.
/// Mirrors the few <c>CityData.Instance</c> fields the joiner needs to
/// reproduce the host's city generation result.
/// </summary>
public struct WorldDescriptorPacket
{
    /// <summary>Internal RNG seed string from <c>CityData.seed</c>.</summary>
    public string Seed;
    /// <summary>Pretty city name for log/UX (e.g. "Vietnam").</summary>
    public string CityName;
    /// <summary>The share-code the city was generated from (encodes seed +
    /// size + custom generation parameters). When non-empty, prefer this
    /// over <see cref="Seed"/> for deterministic regeneration.</summary>
    public string ShareCode;
    /// <summary>City size in tiles (X = horizontal blocks).</summary>
    public int CitySizeX;
    /// <summary>City size in tiles (Y = vertical blocks).</summary>
    public int CitySizeY;

    public void Serialize(NetDataWriter w)
    {
        w.Put(Seed ?? "");
        w.Put(CityName ?? "");
        w.Put(ShareCode ?? "");
        w.Put(CitySizeX);
        w.Put(CitySizeY);
    }

    public void Deserialize(NetDataReader r)
    {
        Seed       = r.GetString();
        CityName   = r.GetString();
        ShareCode  = r.GetString();
        CitySizeX  = r.GetInt();
        CitySizeY  = r.GetInt();
    }
}
