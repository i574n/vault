param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"


if (!$fast) {
    Set-Location (New-Item -ItemType Directory -Path "../.." -Force)
    git clone --recurse-submodules https://github.com/i574n/polyglot.git
    Set-Location polyglot
    git pull

    pwsh scripts/init.ps1
} else {
    Set-Location ../../polyglot
}

. ./scripts/core.ps1

pwsh apps/builder/build.ps1 -fast 1
pwsh apps/parser/build.ps1 -fast 1
pwsh lib/fsharp/build.ps1 -fast 1
pwsh apps/dir-tree-html/build.ps1 -fast 1

Set-Location $ScriptDir

pwsh dep_hangulize.ps1 -fast 1

{ sudo apt-get update } | Invoke-Block -Linux -Distro ubuntu
{ sudo apt install -y texlive-xetex } | Invoke-Block -Linux -Distro ubuntu

{ cargo +nightly install crowbook } | Invoke-Block -OnError Continue
