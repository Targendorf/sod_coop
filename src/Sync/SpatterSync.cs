using System.Collections.Generic;
using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Blood / dirt spatter decals.
///
/// Architecture mirrors <see cref="FootprintSync"/>:
///   • Host broadcasts spatter from any source (NPC violence, host-player attacks).
///   • Clients broadcast spatter only from local-player actions. NPC-driven
///     spatter on clients can only fire from synced animator events, and any
///     such fire would duplicate what the host already broadcast.
///   • Receiver reconstructs the spatter via SoD's world-position ctor (which
///     internally registers it with GameplayController.Instance.spatter and
///     runs Execute()), guarded by <see cref="IsApplyingRemote"/>.
///
/// Cross-machine preset resolution: <c>SpatterPatternPreset.name</c> (the
/// Unity ScriptableObject asset name) is the wire identifier. We build a
/// lazy registry on first use via <c>Resources.FindObjectsOfTypeAll</c>.
/// </summary>
public static class SpatterSync
{
    public static bool IsApplyingRemote { get; private set; }

    /// <summary>
    /// Suppresses broadcasts when ANY sync system is mid-Apply. Spatter is a
    /// frequent side-effect of murders, gun shots, item-pickup of bloody
    /// weapons, etc — every other sync's apply path can trigger Execute().
    /// </summary>
    public static bool ShouldSuppressBroadcast =>
        IsApplyingRemote
        || WorldStateSync.IsApplyingRemote
        || ItemSync.IsApplyingRemote
        || CitizenDeathSync.IsApplyingRemote
        || CaseBoardSync.IsApplyingRemote
        || FingerprintSync.IsApplyingRemote
        || FootprintSync.IsApplyingRemote;

    private static readonly NetDataWriter _writer = new();

    /// <summary>
    /// Each <c>SpatterSimulation</c> we've already broadcast for. Keyed by
    /// IL2CPP pointer (cheap, stable for the life of the object). Prevents
    /// double-broadcast if Execute() is invoked more than once per sim
    /// (e.g. via UpdateSpawning re-entrancy).
    /// </summary>
    private static readonly HashSet<System.IntPtr> _broadcastedSims = new();

    // Lazy preset registry: name → preset.
    private static Dictionary<string, SpatterPatternPreset> _presetByName;

    // ─────────────────────────────────────────────────────────────────────────
    //  Outbound
    // ─────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Broadcast a spatter described by an existing SpatterSimulation. Caller
    /// (the Harmony patch on Execute postfix) is expected to have already
    /// filtered by host vs client + suppress flags.
    /// </summary>
    public static void BroadcastFromSim(SpatterSimulation sim)
    {
        if (!NetworkManager.IsConnected) return;
        if (ShouldSuppressBroadcast) return;
        if (sim == null) return;

        try
        {
            // Dedup if Execute fires more than once on the same sim.
            var ptr = sim.Pointer;
            if (_broadcastedSims.Contains(ptr)) return;
            _broadcastedSims.Add(ptr);

            // Resolve preset name. Prefer the cached presetStr (set by ctor),
            // fall back to the live preset.name if empty.
            string presetName = sim.presetStr;
            if (string.IsNullOrEmpty(presetName))
            {
                try { presetName = sim.preset?.name; } catch { }
            }
            if (string.IsNullOrEmpty(presetName)) return;   // no usable preset

            var packet = new SpatterAddPacket
            {
                WorldOrigin     = sim.worldOrigin,
                WorldTarget     = sim.worldTarget,
                PresetName      = presetName,
                EraseMode       = (byte)sim.eraseMode,
                Force           = (byte)sim.force,
                CountMultiplier = sim.spatterCountMultiplier,
                StickToActors   = sim.stickToActors,
                SenderId        = NetworkManager.LocalPlayerId,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.SpatterAdd, _writer, DeliveryMethod.ReliableOrdered);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"SpatterSync.BroadcastFromSim: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Inbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        if (type != PacketType.SpatterAdd) return;

        try
        {
            var p = new SpatterAddPacket();
            p.Deserialize(reader);
            if (p.SenderId == NetworkManager.LocalPlayerId) return;
            ApplyAdd(p);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"SpatterSync.OnPacketReceived: {ex.Message}");
        }
    }

    private static void ApplyAdd(SpatterAddPacket p)
    {
        try
        {
            var preset = ResolvePreset(p.PresetName);
            if (preset == null)
            {
                Plugin.Log.LogWarning($"[SpatterSync] ApplyAdd: preset \"{p.PresetName}\" not found");
                return;
            }

            IsApplyingRemote = true;
            try
            {
                // World-position ctor — internally adds to GameplayController.spatter
                // and (in most SoD builds) auto-Executes.
                var sim = new SpatterSimulation(
                    p.WorldOrigin,
                    p.WorldTarget,
                    preset,
                    (SpatterSimulation.EraseMode)p.EraseMode,
                    p.CountMultiplier,
                    p.StickToActors);

                // Ensure force matches the originator (ctor doesn't take force).
                try { sim.force = (SpatterSimulation.ForceType)p.Force; } catch { }

                // Backstop: if the ctor didn't auto-execute, do it now.
                try
                {
                    if (!sim.isExecuted) sim.Execute();
                }
                catch { /* SoD versions vary on auto-execute behaviour; second call is a no-op */ }

                // Register against our broadcast-dedup set so the postfix from
                // the apply path doesn't try to broadcast it back out (the
                // ShouldSuppressBroadcast flag already handles this, but
                // belt-and-braces).
                _broadcastedSims.Add(sim.Pointer);
            }
            finally
            {
                IsApplyingRemote = false;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"SpatterSync.ApplyAdd failed: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Preset registry
    // ─────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Lazily build a name→preset map from all SpatterPatternPreset assets
    /// loaded by Unity. Cached after first scan; if a preset is added later
    /// (mods?) the cache is rebuilt on miss.
    /// </summary>
    private static SpatterPatternPreset ResolvePreset(string name)
    {
        if (string.IsNullOrEmpty(name)) return null;

        if (_presetByName != null && _presetByName.TryGetValue(name, out var cached))
            return cached;

        RebuildPresetCache();

        if (_presetByName != null && _presetByName.TryGetValue(name, out var fresh))
            return fresh;

        return null;
    }

    private static void RebuildPresetCache()
    {
        try
        {
            _presetByName = new Dictionary<string, SpatterPatternPreset>();
            var all = Resources.FindObjectsOfTypeAll<SpatterPatternPreset>();
            if (all == null) return;
            for (int i = 0; i < all.Length; i++)
            {
                var p = all[i];
                if (p == null) continue;
                var n = p.name;
                if (string.IsNullOrEmpty(n)) continue;
                _presetByName[n] = p;
            }
            Plugin.Log.LogInfo($"[SpatterSync] indexed {_presetByName.Count} SpatterPatternPreset assets");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"SpatterSync.RebuildPresetCache: {ex.Message}");
        }
    }
}
