param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"


Remove-Item ../dist -Recurse -Force -ErrorAction Ignore

rsync -av `
    --exclude '.git' `
    --exclude '.history' `
    --exclude '.vscode' `
    --exclude 'file_cache' `
    --exclude 'target' `
`
    --include 'LICENSE' `
    --include '*.editorconfig' `
    --include '*.edn' `
    --include '*.gitignore' `
    --include '*.json' `
    --include '*.md' `
    --include '*.ps1' `
    --include '*.toml' `
`
    --include '*/' `
    --exclude '*' `
    --no-links `
    --prune-empty-dirs `
    ../ `
    ../dist/

Get-ChildItem -Path ../dist -Recurse -Force | Where-Object { $_.Name.StartsWith(".") } | ForEach-Object {
    Rename-Item -Path $_.FullName -NewName "_$($_.Name)"
}

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

    $fileName = "DirTreeHtml$(GetExecutableSuffix)"
    $cidUrl = "https://i574n.github.io/polyglot/apps/dir-tree-html/target/dist/$fileName.cid"
    Write-Output "cidUrl: '$cidUrl'"
    try {
        $cid = Invoke-WebRequest $cidUrl
    } catch {
        Write-Host "Exception: '$_' / Error: '$Error'"
        $retryCount++
        continue
    }
    $cid = $cid.ToString().Trim()
    Write-Output "cid: '$cid'"

    $dwebUrl = "https://dweb.link/ipfs/$cid"
    $path = "../target/$fileName"
    try {
        Invoke-WebRequest $dwebUrl -OutFile $path
    } catch {
        Write-Host "Exception: '$_' / Error: '$Error'"
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

{ chmod +x $path } | Invoke-Block -Linux

{ . $path --dir ../dist --html ../dist/index.html } | Invoke-Block
