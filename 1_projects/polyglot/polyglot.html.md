
```custom-frames
urlSuffix: i574n.github.io/tictactoe
frame: https://
style: height:50vh
```

```custom-frames
urlSuffix: tictactoe.on.fleek.co
frame: https://
style: height:50vh
```

---

<http://127.0.0.1:8000/https://time.is>

---

```custom-frames
urlSuffix: github.com/fc1943s/FsClr/blob/main/src/FsClr/src/FileSystem.fs
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/notify-rs/notify
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/notify-rs/notify/blob/main/examples/hot_reload_tide/src/main.rs
frame: https://
style: height:20vh
```

```rs
use std::path::PathBuf;
use std::sync::mpsc::{channel, Sender};
use std::thread::{spawn, JoinHandle};
use std::time::Duration;

use notify::{RecommendedWatcher, RecursiveMode, Watcher};

#[derive(Debug)]
enum FileSystemChangeType {
    Error,
    Changed,
    Created,
    Deleted,
    Renamed,
}

#[derive(Debug)]
enum FileSystemChange {
    Error(std::io::Error),
    Changed(PathBuf),
    Created(PathBuf),
    Deleted(PathBuf),
    Renamed(PathBuf, PathBuf),
}

impl FileSystemChange {
    fn path(&self) -> Option<(PathBuf, PathBuf)> {
        match self {
            FileSystemChange::Error(_) => None,
            FileSystemChange::Changed(path)
            | FileSystemChange::Created(path)
            | FileSystemChange::Deleted(path) => (None, Some(path.clone())),
            FileSystemChange::Renamed(old_path, path) => Some((old_path.clone(), path.clone())),
        }
    }

    fn change_type(&self) -> FileSystemChangeType {
        match self {
            FileSystemChange::Error(_) => FileSystemChangeType::Error,
            FileSystemChange::Changed(_) => FileSystemChangeType::Changed,
            FileSystemChange::Created(_) => FileSystemChangeType::Created,
            FileSystemChange::Deleted(_) => FileSystemChangeType::Deleted,
            FileSystemChange::Renamed(_, _) => FileSystemChangeType::Renamed,
        }
    }
}

fn watch_with_filter(path: &str, filter: notify::RecommendedWatcher) -> Sender<FileSystemChange> {
    let (tx, rx) = channel();

    let mut watcher: RecommendedWatcher = filter.clone();
    watcher
        .watch(path, RecursiveMode::Recursive)
        .unwrap_or_else(|e| panic!("Failed to watch directory '{}': {:?}", path, e));

    let tx2 = tx.clone();
    let mut events = watcher
        .event_receiver()
        .unwrap_or_else(|e| panic!("Failed to receive events for directory '{}': {:?}", path, e));

    spawn(move || loop {
        match events.recv_timeout(Duration::from_secs(1)) {
            Ok(event) => match event {
                notify::DebouncedEvent::Write(path) => tx.send(FileSystemChange::Changed(path)).unwrap(),
                notify::DebouncedEvent::Create(path) => tx.send(FileSystemChange::Created(path)).unwrap(),
                notify::DebouncedEvent::Remove(path) => tx.send(FileSystemChange::Deleted(path)).unwrap(),
                notify::DebouncedEvent::Rename(old_path, path) => {
                    tx.send(FileSystemChange::Renamed(old_path, path)).unwrap()
                }
                _ => {}
            },
            Err(_) => {}
        }
    });

    tx2
}

fn watch(path: &str) -> Sender<FileSystemChange> {
    watch_with_filter(
        path,
        notify::Watcher::new(
            std::time::Duration::from_secs(2),
        ).unwrap_or_else(|e| panic!("Failed to create watcher for directory '{}': {:?}", path, e)),
    )
}
```

---

```custom-frames
urlSuffix: lib.rs/crates/indexed_db_futures
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/Alorel/rust-indexed-db/blob/master/src/idb_database.rs
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/Pauan/rust-dominator
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/search?q=into_js_array&type=code
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/Pauan/rust-dominator/blob/master/examples/todomvc/src/app.rs
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/Pauan/rust-dominator/blob/3c2ef41e78a2b7373e15be54cfb37860831ff71a/src/dom.rs#L1069
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/Pauan/rust-dominator/blob/3c2ef41e78a2b7373e15be54cfb37860831ff71a/src/macros.rs#L37
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/Pauan/rust-dominator/blob/3c2ef41e78a2b7373e15be54cfb37860831ff71a/examples/animation/src/lib.rs#L6
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/Pauan/rust-dominator/blob/3c2ef41e78a2b7373e15be54cfb37860831ff71a/examples/todomvc/src/todo.rs#L4
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/Pauan/rust-dominator/blob/3c2ef41e78a2b7373e15be54cfb37860831ff71a/examples/todomvc/src/app.rs#L5
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/search?q=repo%3APauan%2Frust-dominator%20signal&type=code
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/search?q=repo%3APauan%2Frust-dominator+dombuilder&type=code
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/orgs/lunatic-solutions/repositories
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/lunatic-solutions/chat
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/lunatic-solutions/submillisecond-live-view
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/lunatic-solutions/submillisecond
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/lunatic-solutions/lunatic
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/bakape/shamichan/blob/33ef96602afccf800d6ac70049cf8b6afebc3d6d/client/src/util.rs#L253
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/nucypher/nucypher-core/blob/5710d7d9238da0085b0936b3dbfa5aa4f5472072/nucypher-core-wasm/tests/wasm.rs#L39
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/zscole/meguca/blob/fc775f75b226adcabcf71b7a9c81d8f4c8dba496/client/src/util.rs#L237
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/nucypher/nucypher-core/blob/5710d7d9238da0085b0936b3dbfa5aa4f5472072/nucypher-core-wasm/src/lib.rs#L92
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/appaquet/exocore/blob/4cfbb5e437da38de9f765f0b8bece8ea28c5f6f7/core/src/futures/spawn_wasm.rs#L4
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/extraymond/rust-async-wasm-demo/blob/4c765dad1d17ef01f659a167ea9bbaea77539739/crate/src/connector.rs#L14
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/matrix-org/matrix-rust-sdk/blob/0af38d9a76a806223099ea9563945cf61197de98/crates/matrix-sdk-common/src/timeout.rs#L7
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/swimos/swim-rust/blob/e3dad2a1564237fb5e88c09f9206dbd2f3146a9e/runtime/swim_async_runtime/src/time.rs#L30
frame: https://
style: height:20vh
```

```custom-frames
urlSuffix: github.com/mvlabat/muddle-run/blob/028d8338b2aadb56228614ad751d71c39fcebda5/libs/client_lib/src/net/matchmaker.rs#L65
frame: https://
style: height:20vh
```
