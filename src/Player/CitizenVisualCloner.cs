using System;
using System.Text;
using UnityEngine;

namespace SoDCoop.Player;

/// <summary>
/// Best-effort cloner that grabs a random citizen's body model from the live city,
/// strips all logic components, and returns a pure-visual GameObject suitable for
/// parenting under a RemotePlayer. Returns null on any failure — caller falls back
/// to the default capsule.
///
/// Renderer search order:
///   1. SkinnedMeshRenderer (rigged/animated body)
///   2. MeshRenderer (static-mesh fallback — some SoD citizen parts use this)
///
/// On first call, dumps every component type found on the chosen citizen to the
/// log so we can identify what SoD's citizen hierarchy looks like.
/// </summary>
public static class CitizenVisualCloner
{
    private static bool _diagnosticDone;

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

            // One-time diagnostic: dump the full component tree of this citizen.
            if (!_diagnosticDone)
            {
                _diagnosticDone = true;
                DumpCitizenComponents(pick);
            }

            // ── Find the visual root ──────────────────────────────────────────
            // Try SkinnedMeshRenderer first (animated rig), then plain MeshRenderer.
            Transform visualRoot = FindVisualRoot<SkinnedMeshRenderer>(pick)
                                ?? FindVisualRoot<MeshRenderer>(pick);

            if (visualRoot == null)
            {
                Plugin.Log.LogWarning(
                    "CitizenVisualCloner: no renderer found on citizen — check diagnostic above. Fallback.");
                return null;
            }

            var clone = UnityEngine.Object.Instantiate(visualRoot.gameObject);
            clone.name = $"CitizenVisual_clone_{pick.humanID}";

            // ── Strip physics joints first (order matters for Unity deps) ─────
            foreach (var joint in clone.GetComponentsInChildren<CharacterJoint>(true))
                UnityEngine.Object.Destroy(joint);
            foreach (var joint2 in clone.GetComponentsInChildren<Joint>(true))
                UnityEngine.Object.Destroy(joint2);
            foreach (var col in clone.GetComponentsInChildren<Collider>(true))
                UnityEngine.Object.Destroy(col);
            foreach (var rb in clone.GetComponentsInChildren<Rigidbody>(true))
                UnityEngine.Object.Destroy(rb);

            // ── Strip AI / behaviour components ───────────────────────────────
            StripComponents(clone);

            clone.transform.localPosition = Vector3.zero;
            clone.transform.localRotation = Quaternion.identity;
            clone.transform.localScale    = Vector3.one;

            Plugin.Log.LogInfo(
                $"CitizenVisualCloner: cloned citizen #{pick.humanID} " +
                $"(root: {visualRoot.name}) for remote player.");
            return clone;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"CitizenVisualCloner failed: {ex.GetType().Name}: {ex.Message}");
            return null;
        }
    }

    // -------------------------------------------------------------------------

    /// <summary>
    /// Find the highest transform ancestor (direct child of citizen.gameObject, or deeper)
    /// that contains a renderer of type T anywhere in its subtree.
    /// Returns the direct-child-of-citizen ancestor so we clone the whole visual sub-tree.
    /// </summary>
    private static Transform FindVisualRoot<T>(Human human) where T : Component
    {
        try
        {
            var renderer = human.GetComponentInChildren<T>(true);
            if (renderer == null) return null;

            // Walk up until we hit a direct child of the citizen's transform.
            Transform t = renderer.transform;
            while (t.parent != null && t.parent != human.transform)
                t = t.parent;

            return t;
        }
        catch
        {
            return null;
        }
    }

    /// <summary>
    /// Destroy all MonoBehaviours/AI components on the clone tree, keeping only
    /// rendering-essential things (Transform, Renderer subclasses, MeshFilter, Animator).
    ///
    /// IL2CPP note: C# `is` type checks do NOT work for Unity-native types (Transform,
    /// Renderer, MeshFilter, Animator) when running under BepInEx IL2CPP interop.
    /// We use GetIl2CppType().Name instead, which always returns the correct native type name.
    /// </summary>
    private static void StripComponents(GameObject root)
    {
        var all = root.GetComponentsInChildren<Component>(true);
        foreach (var comp in all)
        {
            if (comp == null) continue;

            // IL2CPP-safe type checks — `comp is Transform` etc. do NOT work here.
            var typeName = comp.GetIl2CppType()?.Name ?? "";
            if (typeName == "Transform") continue;
            if (typeName == "MeshRenderer" || typeName == "SkinnedMeshRenderer") continue;
            if (typeName == "MeshFilter") continue;
            if (typeName == "Animator") continue;  // keep skeleton driver; applyRootMotion=false below

            try { UnityEngine.Object.Destroy(comp); }
            catch { /* some components refuse — ignore */ }
        }

        // Disable root motion on whatever Animator survived.
        foreach (var anim in root.GetComponentsInChildren<Animator>(true))
        {
            if (anim != null) anim.applyRootMotion = false;
        }
    }

    // -------------------------------------------------------------------------

    /// <summary>
    /// One-time log dump of everything attached to a citizen and its children.
    /// Helps identify the SoD citizen hierarchy when SkinnedMeshRenderer is missing.
    /// </summary>
    private static void DumpCitizenComponents(Human human)
    {
        try
        {
            var sb = new StringBuilder();
            sb.AppendLine($"[CitizenDiag] Citizen #{human.humanID} component tree:");

            DumpGO(human.gameObject, sb, 0);

            Plugin.Log.LogInfo(sb.ToString());
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"DumpCitizenComponents failed: {ex.Message}");
        }
    }

    private static void DumpGO(GameObject go, StringBuilder sb, int depth)
    {
        if (go == null || depth > 6) return;

        string indent = new string(' ', depth * 2);
        sb.Append($"{indent}[{go.name}] active={go.activeSelf}");

        try
        {
            var comps = go.GetComponents<Component>();
            if (comps != null)
            {
                sb.Append(" → ");
                for (int i = 0; i < comps.Count; i++)
                {
                    var c = comps[i];
                    if (c == null) continue;
                    try { sb.Append(c.GetIl2CppType().Name); }
                    catch { sb.Append("?"); }
                    if (i < comps.Count - 1) sb.Append(", ");
                }
            }
        }
        catch { sb.Append(" [comps-err]"); }

        sb.AppendLine();

        try
        {
            for (int c = 0; c < go.transform.childCount; c++)
            {
                var child = go.transform.GetChild(c);
                if (child != null)
                    DumpGO(child.gameObject, sb, depth + 1);
            }
        }
        catch { }
    }
}
