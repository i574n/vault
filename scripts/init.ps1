param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"


try {
    cargo +nightly install crowbook
} catch {
    Write-Host "Exception: '$_' / Error: '$Error'"
}

