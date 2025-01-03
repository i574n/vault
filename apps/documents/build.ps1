param(
    $fast,
    $SkipNotebook,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../deps/polyglot/scripts/core.ps1
. ../../deps/polyglot/lib/spiral/lib.ps1


$projectName = "documents"

if (!$fast -and !$SkipNotebook) {
    { . apps/spiral/dist/Supervisor$(_exe) --execute-command "deps/spiral/workspace/target/release/spiral$(_exe) dib --path ../vault/apps/$projectName/$projectName.dib" } | Invoke-Block -Retries 3 -Location ../../../polyglot
}

{ . ../../deps/polyglot/apps/parser/dist/DibParser$(_exe) "$projectName.dib" spi } | Invoke-Block

{ . ../../deps/polyglot/apps/spiral/dist/Supervisor$(_exe) --build-file "$projectName.spi" "$projectName.fsx" --timeout 60000 } | Invoke-Block

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("$projectName.fsx", "--persist-only", $runtime, "--packages", "Fable.Core", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs")
{ . ../../deps/polyglot/apps/builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block

$targetDir = GetTargetDir $projectName

{ BuildFable $targetDir $projectName "rs" } | Invoke-Block -Location ../../deps/polyglot
(Get-Content "$targetDir/target/rs/$projectName.rs") `
    -replace "../../../lib", "../polyglot/lib" `
    -replace "`"./lib", "`"../../../polyglot/lib" `
    -replace ".fsx`"]", ".rs`"]" `
    | FixRust `
    | Set-Content "$projectName.rs"

cargo fmt --

if (!$fast) {
    { cargo test --release -- --show-output } | Invoke-Block
}

{ cargo build --release } | Invoke-Block

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
