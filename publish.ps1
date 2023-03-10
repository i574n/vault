fleek sites deploy | grep "Site IPFS CID" | ForEach-Object { $_.ToString().Split('')[4] } | xargs fleek ipns publish k51qzi5uqu5dhcucwwd09yny2mnx4uz14ws3gdvfpea5s1nescnx2kufio1x0c
