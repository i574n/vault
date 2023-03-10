$a = fleek sites deploy
Write-Output $a
$a = $a | grep "Site IPFS CID"
$a = $a | ForEach-Object { $_.ToString().Split(' ')[4] }
fleek ipns publish k51qzi5uqu5dhcucwwd09yny2mnx4uz14ws3gdvfpea5s1nescnx2kufio1x0c $a
