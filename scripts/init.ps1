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
    Set-Location $ScriptDir
    . ../../polyglot/scripts/init.ps1
}

. ../../polyglot/scripts/core.ps1

{ . ../../polyglot/apps/builder/build.ps1 -fast 1 } | Invoke-Block -Location $ScriptDir
{ . ../../polyglot/apps/parser/build.ps1 -fast 1 } | Invoke-Block -Location $ScriptDir
{ . ../../polyglot/apps/spiral/build.ps1 -fast 1 } | Invoke-Block -Location $ScriptDir
{ . ../../polyglot/lib/rust/fable/build.ps1 } | Invoke-Block -Location $ScriptDir
{ . ../../polyglot/lib/fsharp/build.ps1 -fast 1 } | Invoke-Block -Location $ScriptDir
{ . ../../polyglot/lib/spiral/build.ps1 -fast 1 } | Invoke-Block -Location $ScriptDir
{ . ../../polyglot/apps/dir-tree-html/build.ps1 -fast 1 } | Invoke-Block -Location $ScriptDir

{ . dep_hangulize.ps1 -fast 1 } | Invoke-Block
{ . ../apps/documents/build.ps1 } | Invoke-Block

{ sudo apt-get update } | Invoke-Block -Linux -Distro ubuntu
{ sudo apt install -y texlive-xetex } | Invoke-Block -Linux -Distro ubuntu

{ cargo +nightly install crowbook } | Invoke-Block -OnError Continue
