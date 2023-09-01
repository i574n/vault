param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"


Set-Location ..

$dir = Split-Path -Leaf (Get-Location)
if ($dir -ne "dist" -and $dir -ne "gh-pages") {
    throw "Invalid location (dir <> dist && dir <> gh-pages): $(Get-Location)"
    exit 1
}

npm i -g @fleekxyz/cli@dev

$output = fleek sites deploy
Write-Output $output
$output = $output | grep "Site IPFS CID"
$cid = $output | ForEach-Object { $_.ToString().Split(' ')[4] }
Write-Output "CID: $cid"
fleek ipns publish --name k51qzi5uqu5dmg05gnqt02fmke0xnobp0psyve0dsgcq0bjso97u1btto2hbfc --hash $cid
