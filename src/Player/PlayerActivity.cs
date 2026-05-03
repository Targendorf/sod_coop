namespace SoDCoop.Player;

/// <summary>
/// Coarse-grained "what's the FPS player doing" tag pushed via the
/// LocalPlayer ZDO and resolved on the host into the twin citizen's
/// existing NPC anim states (<c>armsBoolAnimationState</c> +
/// <c>idleAnimationState</c>). Each NPC anim already exists in SoD's
/// rig, so we don't ship new clips — just trigger the matching one when
/// the player engages in the equivalent activity.
///
/// <para>Stance / combat / sleep / held-item / KO have their own ZDO
/// fields and aren't represented here — this enum covers the remaining
/// gap of "interactable-driven" activities the player can be in.</para>
/// </summary>
public enum PlayerActivity : byte
{
    /// <summary>No specific activity — fall back to walk/idle/run derived
    /// from speed.</summary>
    None        = 0,

    /// <summary>Lockpicking a door / safe / drawer. NPC equivalent:
    /// <c>ArmsBoolSate.armsLocking</c>.</summary>
    Lockpicking = 1,

    /// <summary>Standing at a computer terminal. NPC equivalent:
    /// <c>ArmsBoolSate.armsTyping</c>.</summary>
    ComputerUse = 2,

    /// <summary>On the phone. NPC equivalent:
    /// <c>IdleAnimationState.telephone</c>.</summary>
    PhoneCall   = 3,

    /// <summary>Hand-searching a container / desk / cabinet. NPC equivalent:
    /// <c>ArmsBoolSate.armsUse</c>.</summary>
    Searching   = 4,

    /// <summary>Hiding inside a cabinet / under a bed. No specific NPC
    /// anim — the position teleport into the hiding interactable is the
    /// visible part. Tag is still synced for HUD / lobby readouts.</summary>
    Hiding      = 5,
}
