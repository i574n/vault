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

$url = "https://i574n.github.io/polyglot/scripts/core.ps1"
$path = "../target/scripts/core.ps1"
Invoke-WebRequest $url -OutFile $path -ErrorAction SilentlyContinue

. ../target/scripts/core.ps1

$url = "https://i574n.github.io/polyglot/apps/dir-tree-html/target/dist/DirTreeHtml"
$path = "../target/DirTreeHtml"
Invoke-WebRequest $url -OutFile $path -ErrorAction SilentlyContinue

{ chmod +x $path } | Invoke-Block -Linux

{ . $path --dir ../dist --html ../dist/index.html } | Invoke-Block -Linux
