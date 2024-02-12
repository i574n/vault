param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"


New-Item -ItemType Directory -Path "../target/scripts" -Force | Out-Null

$retryCount = 0
Write-Host "## 1"
while ($retryCount -lt 5) {
    if ($retryCount -gt 0) {
        Write-Host "Retry $retryCount / Error: '$Error'"
    }
    $Error.Clear()
    Write-Host "## 2"


    $url = "https://i574n.github.io/polyglot/scripts/core.ps1"
    $path = "../target/scripts/core.ps1"
    try {
        Invoke-WebRequest $url -OutFile $path
        . ../target/scripts/core.ps1
    } catch {
        Write-Host "Exception: '$_' / Error: '$Error'"
        $retryCount++
        continue
    }

    Write-Host "## 3"

    if ($Error.Count -eq 0) {
        Write-Host "## 3.1"
        break
    }

    Write-Host "## 4"
    $retryCount++
}
Write-Host "## 5"
if ($Error.Count -gt 0) {
    throw "Failed to download files / Error: '$Error'"
    exit 1
}


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
