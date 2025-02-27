param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"


pwsh init.ps1

. ../../polyglot/scripts/core.ps1

{ pwsh publish.ps1 } | Invoke-Block
