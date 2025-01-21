param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"


if (!$fast) {
    Set-Location (New-Item -ItemType Directory -Path "../.." -Force)
    git clone --recurse-submodules https://github.com/i574n/alphabet.git # --branch gh-pages
    Set-Location alphabet
    git pull
    Set-Location $ScriptDir
    pwsh ../../alphabet/scripts/init.ps1
}

. ../../polyglot/scripts/core.ps1

EnsureSymbolicLink -Path "../deps/alphabet" -Target "../../alphabet"

{ pwsh ../deps/alphabet/apps/documents/build.ps1 -fast 1 } | Invoke-Block
