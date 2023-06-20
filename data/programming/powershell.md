
```ps1
Get-ChildItem -Path . -Recurse -File | Where-Object { $_.Extension -eq '.md' } | ForEach-Object {
  $relativePath = $_.FullName.Replace((Resolve-Path .).Path + '\', '')
  Write-Output $relativePath
}
```
