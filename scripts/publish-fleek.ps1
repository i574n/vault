param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"


npm i -g @fleekxyz/cli@dev

Set-Location ..

Write-Output "Location: $(Get-Location)"

$a = fleek sites deploy
Write-Output $a
$a = $a | grep "Site IPFS CID"
$cid = $a | ForEach-Object { $_.ToString().Split(' ')[4] }
Write-Output "CID: $cid"
fleek ipns publish --name k51qzi5uqu5dmg05gnqt02fmke0xnobp0psyve0dsgcq0bjso97u1btto2hbfc --hash $cid
