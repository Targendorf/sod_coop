$path = 'src/Patches/GamePatches.cs'
$t = Get-Content -Raw -Path $path

$nl = [Environment]::NewLine

# Inject `if (!SyncGate.IsOpen) return;` for VOID Postfix/Prefix bodies that
# go straight to try-block without an existing early-bail.
$voidPattern = '(?ms)(public static void (?:Post|Pre)fix\([^)]*\))\s*\r?\n\s*\{\s*\r?\n(?!\s*if \(!SyncGate)\s*try\s*\r?\n\s*\{'
$voidReplace = '$1' + $nl + '        {' + $nl + '            if (!SyncGate.IsOpen) return;' + $nl + '            try' + $nl + '            {'
$voidCount = ([regex]::Matches($t, $voidPattern)).Count
$t = [regex]::Replace($t, $voidPattern, $voidReplace)

# Inject `if (!SyncGate.IsOpen) return true;` for BOOL Prefix bodies (Harmony
# convention: returning true means "let the original method run", which is
# exactly what we want when the gate is closed).
$boolPattern = '(?ms)(public static bool Prefix\([^)]*\))\s*\r?\n\s*\{\s*\r?\n(?!\s*if \(!SyncGate)\s*try\s*\r?\n\s*\{'
$boolReplace = '$1' + $nl + '        {' + $nl + '            if (!SyncGate.IsOpen) return true;' + $nl + '            try' + $nl + '            {'
$boolCount = ([regex]::Matches($t, $boolPattern)).Count
$t = [regex]::Replace($t, $boolPattern, $boolReplace)

Set-Content -Path $path -NoNewline -Value $t -Encoding UTF8
Write-Host ("Injected gate into {0} void + {1} bool bodies." -f $voidCount, $boolCount)
