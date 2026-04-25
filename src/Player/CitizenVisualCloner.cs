using System;
using UnityEngine;

namespace SoDCoop.Player;

/// <summary>
/// Best-effort cloner that grabs a random citizen's body model from the live city,
/// strips all logic components, and returns a pure-visual GameObject suitable for
/// parenting under a RemotePlayer. Returns null on any failure — caller falls back
/// to the default capsule.
/// </summary>
public static class CitizenVisualCloner
{
    /// <summary>
    /// Try to clone a random citizen's visual hierarchy. Returns null if no citizens
    /// are loaded yet, or if the clone/strip pipeline throws.
    /// </summary>
    public static GameObject TryCloneRandomCitizenVisual(int seed)
    {
        try
        {
            var city = CityData.Instance;
            if (city == null || city.citizenDictionary == null || city.citizenDictionary.Count == 0)
            {
                Plugin.Log.LogInfo("CitizenVisualCloner: no citizens loaded yet, using fallback.");
                return null;
            }

            // Pick a deterministic citizen by seed (so each player gets a stable look).
            Human pick = null;
            int target = Mathf.Abs(seed) % city.citizenDictionary.Count;
            int i = 0;
            foreach (var kv in city.citizenDictionary)
            {
                if (i++ == target) { pick = kv.Value; break; }
            }
            if (pick == null || pick.gameObject == null)
            {
                Plugin.Log.LogInfo("CitizenVisualCloner: chosen citizen is null, fallback.");
                return null;
            }

            // Find the visual root. SoD citizens have a child holding the SkinnedMeshRenderer rig.
            // Strategy: find FIRST descendant with a SkinnedMeshRenderer; clone its top-level ancestor
            // under the citizen (so we get the full skeleton), then strip components.
            var smr = pick.gameObject.GetComponentInChildren<SkinnedMeshRenderer>(true);
            if (smr == null)
            {
                Plugin.Log.LogInfo("CitizenVisualCloner: no SkinnedMeshRenderer on citizen, fallback.");
                return null;
            }

            // Walk up to citizen root child (direct child of citizen.gameObject).
            Transform visualRoot = smr.transform;
            while (visualRoot.parent != null && visualRoot.parent != pick.transform)
                visualRoot = visualRoot.parent;

            var clone = UnityEngine.Object.Instantiate(visualRoot.gameObject);
            clone.name = $"CitizenVisual_clone_{pick.humanID}";

            // Strip every component except Transform / Renderer / MeshFilter / Animator-skeleton bones.
            // We allow Animator to stay so the rig pose stays valid; but we won't drive it.
            StripComponents(clone);

            // Ensure no leftover physics/colliders.
            foreach (var col in clone.GetComponentsInChildren<Collider>(true))
                UnityEngine.Object.Destroy(col);
            foreach (var rb in clone.GetComponentsInChildren<Rigidbody>(true))
                UnityEngine.Object.Destroy(rb);

            clone.transform.localPosition = Vector3.zero;
            clone.transform.localRotation = Quaternion.identity;
            clone.transform.localScale    = Vector3.one;

            Plugin.Log.LogInfo($"CitizenVisualCloner: cloned citizen #{pick.humanID} for remote player.");
            return clone;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"CitizenVisualCloner failed: {ex.GetType().Name}: {ex.Message}");
            return null;
        }
    }

    /// <summary>
    /// Destroy all MonoBehaviours/AI components on the clone tree, keeping only
    /// rendering-essential things (Transform, Renderer subclasses, MeshFilter, Animator).
    /// </summary>
    private static void StripComponents(GameObject root)
    {
        var all = root.GetComponentsInChildren<Component>(true);
        foreach (var comp in all)
        {
            if (comp == null) continue;
            if (comp is Transform) continue;
            if (comp is Renderer) continue;          // SkinnedMeshRenderer / MeshRenderer
            if (comp is MeshFilter) continue;
            if (comp is Animator) continue;          // keep skeleton driver, just don't feed it params
            try { UnityEngine.Object.Destroy(comp); }
            catch { /* some components refuse — ignore */ }
        }
    }
}
