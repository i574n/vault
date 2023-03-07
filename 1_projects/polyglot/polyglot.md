```spi
inl api_url = "https://api.telegram.org/bot" +\ token
inl url_get_updates = api_url +\ "/getUpdates"
```

```ps1
cargo run SpiFsxBuild -- --spi-path="./cli.spi"
"../../target/release/cli" SpiFsxBuild -- --spi-path="./cli.spi" --fsx-path="./cli.fsx"
```
