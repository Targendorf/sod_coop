using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Switches animator root motion off on a network-driven body and puts back
/// exactly what was there before.
///
/// <para><b>Why:</b> anything that drives a citizen's transform from the network
/// (<see cref="CitizenPositionSync"/> for pedestrians, <c>RemotePlayer</c> for a
/// remote player's twin) also feeds its locomotion parameters — moveSpeed /
/// walkAnimSpeed — so the legs animate. With root motion on, that same
/// animation writes its own displacement into the transform after our Update
/// has placed it: every frame the body steps ahead of the interpolated position
/// and is yanked back the next, which reads as jitter, and at a low host frame
/// rate a very visible one. The retired NavMesh sync already knew this and
/// disabled root motion for the citizens it drove; the position-driven paths
/// that replaced it did not.</para>
///
/// <para>The original value is recorded per animator and restored rather than
/// forced to true, so a rig that never used root motion is left as it was.</para>
/// </summary>
internal sealed class RootMotionGuard
{
    private Animator[] _anims;
    private bool[] _prev;

    public bool Active => _anims != null;

    /// <summary>Record and disable root motion on every animator under
    /// <paramref name="root"/> (inactive children included — SoD keeps parts of
    /// the rig disabled until needed). Idempotent while active.</summary>
    public void Suppress(Component root)
    {
        if (_anims != null || root == null) return;
        try
        {
            var found = root.GetComponentsInChildren<Animator>(true);
            if (found == null || found.Length == 0) return;
            _anims = new Animator[found.Length];
            _prev  = new bool[found.Length];
            for (int i = 0; i < found.Length; i++)
            {
                var a = found[i];
                _anims[i] = a;
                if (a == null) continue;
                _prev[i] = a.applyRootMotion;
                if (a.applyRootMotion) a.applyRootMotion = false;
            }
        }
        catch
        {
            // Partial state is worse than none: forget what we recorded rather
            // than "restore" values we never captured.
            _anims = null;
            _prev = null;
        }
    }

    /// <summary>Put every recorded animator back the way it was.</summary>
    public void Restore()
    {
        if (_anims == null) return;
        try
        {
            for (int i = 0; i < _anims.Length; i++)
            {
                var a = _anims[i];
                if (a == null) continue;   // destroyed with its world — nothing to restore
                if (a.applyRootMotion != _prev[i]) a.applyRootMotion = _prev[i];
            }
        }
        catch { /* animator torn down mid-restore */ }
        _anims = null;
        _prev = null;
    }
}
