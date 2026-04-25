using HarmonyLib;

namespace SoDCoop.Patches;

/// <summary>
/// Harmony patches placeholder. Intentionally empty for the MVP:
/// we only sync player positions, no need to hook into game systems yet.
/// Patches for pickup / doors / NPC death / evidence / pause sync will be
/// added once their IL2CPP signatures are verified against the game build.
/// </summary>
[HarmonyPatch]
public static class GamePatches
{
}
