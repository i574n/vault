param(
    $fast,
    $SkipSync,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../polyglot/scripts/core.ps1


if (!$SkipSync) {
    Remove-Item ../dist -Recurse -Force -ErrorAction Ignore

    rsync -av `
        --exclude '.git' `
        --exclude '.history' `
        --exclude '.vscode' `
        --exclude 'file_cache' `
        --exclude 'target' `
        --exclude 'deps' `
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
        Move-Item $_.FullName "$($_.FullName | Split-Path)/_$($_.Name)" -Force
    }
}
$targetDir = "../target/gh-pages"
Set-Location (New-Item -ItemType Directory -Path "../target" -Force)
git clone $(git ls-remote --get-url origin) --branch gh-pages gh-pages
if (!(Test-Path $targetDir)) {
    exit 1
}
$targetDir = (Resolve-Path $targetDir).Path
Write-Output "targetDir: $targetDir"
Set-Location $targetDir
if (!$fast) {
    git reset --hard
    git clean -fd
}
git pull --rebase -Xtheirs
Set-Location $ScriptDir

Get-ChildItem -Path ../dist -Recurse -Force `
| Where-Object { $_.Extension -eq ".md" -and !$_.Name.EndsWith(".hangul.md") } `
| ForEach-Object {
    . ../../polyglot/scripts/core.ps1

    $distDir = (Resolve-Path ../dist).Path
    $targetDir = (Resolve-Path "../target/gh-pages").Path
    # $hangulize = $(Resolve-Path "../deps/hangulize/cmd/hangulize/hangulize$(GetExecutableSuffix)").Path

    $relativePath = $_.FullName.Replace($distDir, "").Replace("\", "/")
    $relativePathWithoutExt = $relativePath.Substring(0, $relativePath.LastIndexOf("."))
    $fullPath = "$distDir$relativePath"
    $originHash = git ls-tree --format='%(objectname)' origin/gh-pages ../$relativePath
    $localGitHash = git hash-object $fullPath

    $files = @(
        "$relativePath.html",
        "$relativePath.pdf",
        "$relativePath.epub"
        # "$relativePathWithoutExt.hangul.md"
    )

    if ($localGitHash -ne $originHash) {
        $hash1 = (Get-FileHash $fullPath -Algorithm SHA256).Hash
        $targetPath = "$targetDir$relativePath"
        if (Test-Path $targetPath) {
            $hash2 = (Get-FileHash $targetPath -Algorithm SHA256).Hash
        }

        if (!$hash2 -or $hash1 -ne $hash2) {
            Write-Output "relativePathWithoutExt: $relativePathWithoutExt / relativePath: $relativePath / fullPath: $fullPath / targetPath: $targetPath / originHash: $originHash / localGitHash: $localGitHash / hash1: $hash1 / hash2: $hash2"
            crowbook --single "$fullPath" --output "$fullPath.html" --to html --set rendering.num_depth 6 html.css.add ''' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; } '''
            crowbook --single "$fullPath" --output "$fullPath.pdf" --to pdf --set rendering.num_depth 6 html.css.add ''' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; } '''
            crowbook --single "$fullPath" --output "$fullPath.epub" --to epub --set rendering.num_depth 6 html.css.add ''' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; } '''

            # Write-Output "#1"
            # $lines = Get-Content $fullPath
            # Write-Output "#2"
            # $linesTrim = $lines | Where-Object { $_.Trim() -ne "" }
            # Write-Output "#3"

            # $chunkSize = 10
            # $linesChunks = $linesTrim | Group-Object -Property { [math]::Floor($i++ / $chunkSize) }
            # Write-Output "#4"

            # $encoding = [System.Text.Encoding]::UTF8

            # $_i = 0
            # $linesChunks | ForEach-Object {
            #     $linesChunk = $_

            #     $process = New-Object System.Diagnostics.Process
            #     $ProcessStartInfoParam = [ordered]@{
            #         FileName = $hangulize.Replace("\", "/")
            #         Arguments = "por-br"
            #         RedirectStandardOutput = $true
            #         RedirectStandardInput = $true
            #         UseShellExecute = $false
            #         CreateNoWindow = $true
            #         StandardOutputEncoding = $encoding
            #     }
            #     $ProcessStartInfo = New-Object -TypeName 'System.Diagnostics.ProcessStartInfo' -Property $ProcessStartInfoParam
            #     $process.StartInfo = $ProcessStartInfo
            #     Write-Output "#5"
            #     $start = $process.Start() | Out-Null
            #     Write-Output "#6 / start: $start"

            #     $i = 0
            #     $linesChunk.Group | ForEach-Object {
            #         $text = $_.Trim()
            #         # only keep letters
            #         $text = $text
            #         Write-Output "#6.1 / i: $i / text: $text"
            #         $process.StandardInput.WriteLine($text)
            #         $i++
            #     }
            #     Write-Output "#7"
            #     $process.StandardInput.Close()
            #     Write-Output "#8"
            #     $exit = $process.WaitForExit(5000)
            #     Write-Output "#9"

            #     if ($exit) {
            #         $output = $process.StandardOutput.ReadToEnd()
            #         $output = $output.Split("`n")

            #         $i = 0
            #         $n = 0
            #         $lines | ForEach-Object {
            #             if ($_.Trim() -ne "") {
            #                 $lines[$i + ($_i * $chunkSize)] = $output[$i - $n]
            #             } else {
            #                 $n++
            #             }
            #             $i++
            #         }
            #     } else {
            #         $process.Kill()
            #     }

            #     $_i++
            # }

            # Set-Content -Encoding Default "$distDir$relativePathWithoutExt.hangul.md" $lines

            Copy-Item $fullPath $targetPath
            foreach ($file in $files) {
                $targetFile = "$targetDir$file"
                $sourceFile = "$distDir$file"
                if (Test-Path $sourceFile) {
                    Copy-Item $sourceFile $targetFile
                }
            }
        }
    } else {
        foreach ($file in $files) {
            $targetFile = "$targetDir$file"
            $distFile = "$distDir$file"
            if ((Test-Path $targetFile) -and !(Test-Path $distFile)) {
                Copy-Item $targetFile $distFile
            }
        }
    }
}

$fileName = "DirTreeHtml$(GetExecutableSuffix)"
{ . ../../polyglot/apps/dir-tree-html/dist/$fileName --dir ../dist --html ../dist/index.html } | Invoke-Block
