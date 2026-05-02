namespace SoDCoop.Zdo;

/// <summary>
/// Per-feature toggles for atomic legacy↔ZDO swap during phased migration.
/// All flags default <c>true</c> after their corresponding migration phase
/// lands. The flag itself is removed in Phase H along with the legacy code.
///
/// <para>Reading these is cheap (static field). Legacy Broadcast methods
/// gate at the top: <c>if (ZdoFeatureFlags.UseZdoForX) return;</c>. Pollers
/// gate symmetrically: <c>if (!ZdoFeatureFlags.UseZdoForX) return;</c>.</para>
///
/// <para>During an in-flight migration phase a flag may be flipped at
/// runtime via <see cref="UI.CoopSettings"/> for diagnostic A/B testing,
/// but the production setting is always the corresponding compile-time
/// default once the phase is complete.</para>
/// </summary>
public static class ZdoFeatureFlags
{
    public static bool UseZdoForDoors      = true;
    public static bool UseZdoForLights     = true;
    public static bool UseZdoForSwitches   = true;
    public static bool UseZdoForCitizens   = true;
    public static bool UseZdoForPhoneCalls = true;
    public static bool UseZdoForFingerprints = true;
    public static bool UseZdoForFootprints   = true;
    public static bool UseZdoForSpatter      = true;
    public static bool UseZdoForVmail        = true;
    public static bool UseZdoForEvidenceNote = true;
    public static bool UseZdoForCaseBoard  = true;
    public static bool UseZdoForPlayerState = true;
    public static bool UseZdoForEvents     = true;

    // ── Round 2 (combat / surveillance / weather / elevator / sidejob / case status) ──
    public static bool UseZdoForWeather           = true;
    public static bool UseZdoForElevators         = true;
    public static bool UseZdoForEvidenceCreation  = true;
    public static bool UseZdoForCaseStatus        = true;
    public static bool UseZdoForSideJobs          = true;
}
