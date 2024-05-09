param(
    $fast,
    $SkipNotebook,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../polyglot/scripts/core.ps1
. ../../../polyglot/lib/spiral/lib.ps1


$projectName = "documents"

if (!$fast -and !$SkipNotebook) {
    { . apps/spiral/dist/Supervisor$(_exe) --execute-command "pwsh -c `"scripts/invoke-dib.ps1 ../vault/apps/$projectName/$projectName.dib`"" } | Invoke-Block -Retries 5 -Location ../../../polyglot
}

{ . ../../../polyglot/apps/parser/dist/DibParser$(_exe) "$projectName.dib" spi } | Invoke-Block

{ . ../../../polyglot/apps/spiral/dist/Supervisor$(_exe) --build-file "$projectName.spi" "$projectName.fsx" --timeout 60000 } | Invoke-Block

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("$projectName.fsx", "--persist-only", $runtime, "--packages", "Fable.Core", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs")
{ . ../../../polyglot/apps/builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block

$targetDir = GetTargetDir $projectName

{ BuildFable $targetDir $projectName "rs" } | Invoke-Block -Location ../../../polyglot
(Get-Content "$targetDir/target/rs/$projectName.rs") `
    -replace "../../../../lib", "../../../polyglot/lib" `
    -replace ".fsx`"]", ".rs`"]" `
    | FixRust `
    | FixRust2 `
    | Set-Content "$projectName.rs"

cargo +nightly fmt --

if (!$fast) {
    { cargo +nightly test --release -- --show-output } | Invoke-Block
}

{ cargo +nightly build --release } | Invoke-Block

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
