param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../polyglot/scripts/core.ps1


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
    --include '*.epub' `
    --include '*.gitignore' `
    --include '*.json' `
    --include '*.html' `
    --include '*.md' `
    --include '*.pdf' `
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

git fetch --prune --all --verbose

$ghPages = "../target/gh-pages"
if (!(Test-Path $ghPages)) {
    git clone $(git ls-remote --get-url origin) --branch gh-pages "$ghPages"
    if (!(Test-Path $ghPages)) {
        exit 1
    }
}

$distRoot = (Resolve-Path ../dist/).Path

Get-ChildItem -Path ../dist -Recurse -Force `
| Where-Object { $_.Extension -eq ".md" } `
| ForEach-Object {
    $relative = $_.FullName.Replace($distRoot, '').Replace("\", "/")

    $originHash = git ls-tree --format='%(objectname)' origin/gh-pages ../$relative
    $localGitHash = git hash-object $_.FullName

    if ($localGitHash -ne $originHash) {
        Write-Output "$($_.FullName)"
        crowbook --single "$($_.FullName)" --output "$($_.FullName).html" --to html --set rendering.num_depth 6 html.css.add ''' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; } '''
        crowbook --single "$($_.FullName)" --output "$($_.FullName).pdf" --to pdf --set rendering.num_depth 6 html.css.add ''' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; } '''
        crowbook --single "$($_.FullName)" --output "$($_.FullName).epub" --to epub --set rendering.num_depth 6 html.css.add ''' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; } '''
    } else {
        $files = @(
            @("$ghPages/$relative.html", "../dist/$relative.html"),
            @("$ghPages/$relative.pdf", "../dist/$relative.pdf"),
            @("$ghPages/$relative.epub", "../dist/$relative.epub")
        )

        foreach ($file in $files) {
            if ((Test-Path $file[0]) -and !(Test-Path $file[1])) {
                Copy-Item $file[0] $file[1]
            }
        }
    }
}

$fileName = "DirTreeHtml$(GetExecutableSuffix)"
{ . ../../polyglot/apps/dir-tree-html/dist/$fileName --dir ../dist --html ../dist/index.html } | Invoke-Block
