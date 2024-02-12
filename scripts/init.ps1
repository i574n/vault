param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"


{ sudo apt-get update } | Invoke-Block -Linux -Distro ubuntu
{ sudo apt install -y texlive-xetex } | Invoke-Block -Linux -Distro ubuntu

{ cargo +nightly install crowbook } | Invoke-Block -OnError Continue


Set-Location (New-Item -ItemType Directory -Path "../.." -Force)
git clone --recurse-submodules https://github.com/i574n/polyglot.git
Set-Location polyglot
git pull

pwsh scripts/init.ps1

pwsh apps/dir-tree-html/build.ps1

Set-Location $ScriptDir
