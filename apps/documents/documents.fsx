#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type Slice'<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_std::task::JoinHandle<$0>")>]
#endif
type async_std_task_JoinHandle<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::future::Future<Output = $0>")>]
#endif
type std_future_Future<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::vec::IntoIter<$0>")>]
#endif
type rayon_vec_IntoIter<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::iter::Map<$0, _>")>]
#endif
type rayon_iter_Map<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("futures_lite::stream::StreamExt")>]
#endif
type futures_lite_stream_StreamExt = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("futures::future::TryJoinAll<$0>")>]
#endif
type futures_future_TryJoinAll<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("futures::future::Fuse<$0>")>]
#endif
type futures_future_Fuse<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("futures::future::JoinAll<$0>")>]
#endif
type futures_future_JoinAll<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("core::any::Any")>]
#endif
type core_any_Any = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type core_ops_Try<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Func0<$0>")>]
#endif
type Func0<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Func1<$0, $1>")>]
#endif
type Func0<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>]
#endif
type Box<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>]
#endif
type Dyn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Send")>]
#endif
type Send<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn() -> $0")>]
#endif
type Fn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn()")>]
#endif
type FnUnit = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("FnOnce() -> $0")>]
#endif
type FnOnce<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn($0)")>]
#endif
type ActionFn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn($0, $1)")>]
#endif
type ActionFn2<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("impl $0")>]
#endif
type Impl<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
#endif
type Ref<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 + $1")>]
#endif
type LifetimeJoin<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("'static")>]
#endif
type StaticLifetime = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0")>]
#endif
type LifetimeRef<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 $1")>]
#endif
type Lifetime<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("MutCell<$0>")>]
#endif
type MutCell<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::any::Any")>]
#endif
type std_any_Any = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::borrow::Cow<$0>")>]
#endif
type std_borrow_Cow<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::cell::RefCell<$0>")>]
#endif
type std_cell_RefCell<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::pin::Pin<$0>")>]
#endif
type std_pin_Pin<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Rc<$0>")>]
#endif
type std_rc_Rc<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Weak<$0>")>]
#endif
type std_rc_Weak<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::collections::HashMap<$0, $1>")>]
#endif
type std_collections_HashMap<'K, 'V> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::collections::BTreeMap<$0, $1>")>]
#endif
type std_collections_BTreeMap<'K, 'V> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
#endif
type Str = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("base64::DecodeError")>]
#endif
type base64_DecodeError = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("borsh::io::Error")>]
#endif
type borsh_io_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("encoding_rs::Encoding")>]
#endif
type encoding_rs_Encoding = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("js_sys::JsString")>]
#endif
type js_sys_JsString = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Error")>]
#endif
type serde_json_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Value")>]
#endif
type serde_json_Value = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("serde_wasm_bindgen::Error")>]
#endif
type serde_wasm_bindgen_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsStr")>]
#endif
type std_ffi_OsStr = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsString")>]
#endif
type std_ffi_OsString = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::fmt::Display<$0>")>]
#endif
type std_fmt_Display<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::str::Utf8Error")>]
#endif
type std_str_Utf8Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::FromUtf8Error")>]
#endif
type std_string_FromUtf8Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
#endif
type std_string_String = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::slice::Windows<$0>")>]
#endif
type std_slice_Windows<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Regex")>]
#endif
type regex_Regex = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Captures")>]
#endif
type regex_Captures = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureMatches")>]
#endif
type regex_CaptureMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Error")>]
#endif
type regex_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::thread::JoinHandle<$0>")>]
#endif
type std_thread_JoinHandle<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Arc<$0>")>]
#endif
type std_sync_Arc<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Mutex<$0>")>]
#endif
type std_sync_Mutex<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::MutexGuard<$0>")>]
#endif
type std_sync_MutexGuard<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::PoisonError<$0>")>]
#endif
type std_sync_PoisonError<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Receiver<$0>")>]
#endif
type std_sync_mpsc_Receiver<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::SendError<$0>")>]
#endif
type std_sync_mpsc_SendError<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Sender<$0>")>]
#endif
type std_sync_mpsc_Sender<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::DateTime<$0>")>]
#endif
type chrono_DateTime<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::Local")>]
#endif
type chrono_Local = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::NaiveDateTime")>]
#endif
type chrono_NaiveDateTime = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("chrono::Utc")>]
#endif
type chrono_Utc = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::time::Duration")>]
#endif
type std_time_Duration = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::fs::File")>]
#endif
type std_fs_File = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::fs::FileType")>]
#endif
type std_fs_FileType = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::path::Display")>]
#endif
type std_path_Display = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::path::Path")>]
#endif
type std_path_Path = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::path::PathBuf")>]
#endif
type std_path_PathBuf = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::DirEntry")>]
#endif
type async_walkdir_DirEntry = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::Filtering")>]
#endif
type async_walkdir_Filtering = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::WalkDir")>]
#endif
type async_walkdir_WalkDir = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_std::io::BufReader<$0>")>]
#endif
type async_std_io_BufReader<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::BufReader<$0>")>]
#endif
type std_io_BufReader<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Error")>]
#endif
type std_io_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Lines<$0>")>]
#endif
type std_io_Lines<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("encoding_rs_io::DecodeReaderBytes<$0, $1>")>]
#endif
type encoding_rs_io_DecodeReaderBytes<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::Arg")>]
#endif
type clap_Arg = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::ArgAction")>]
#endif
type clap_ArgAction = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::Command")>]
#endif
type clap_Command = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::ArgMatches")>]
#endif
type clap_ArgMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::builder::ValueRange")>]
#endif
type clap_builder_ValueRange = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::builder::ValueParser")>]
#endif
type clap_builder_ValueParser = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::builder::PossibleValue")>]
#endif
type clap_builder_PossibleValue = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Child")>]
#endif
type std_process_Child = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ChildStderr")>]
#endif
type std_process_ChildStderr = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ChildStdout")>]
#endif
type std_process_ChildStdout = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ChildStdin")>]
#endif
type std_process_ChildStdin = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Command")>]
#endif
type std_process_Command = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ExitStatus")>]
#endif
type std_process_ExitStatus = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Output")>]
#endif
type std_process_Output = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Stdio")>]
#endif
type std_process_Stdio = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("core::iter::Fuse<$0>")>]
#endif
type core_iter_Fuse<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("sha2::Sha256")>]
#endif
type sha2_Sha256 = class end
module State = let mutable trace_state = None
type IPathJoin = abstract join: [<System.ParamArray>] paths: string[] -> string
type IFsExistsSync = abstract existsSync: path: string -> bool
type IPathDirname = abstract dirname: path: string -> string
#if FABLE_COMPILER
[<CompilationRepresentation (CompilationRepresentationFlags.ModuleSuffix)>]
module System =
 module Diagnostics =
  type Process = unit
  type DataReceivedEventArgs = unit
#endif
type [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
    | US0_4
and Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : bool}
and Mut2 = {mutable l0 : US0}
and Mut3 = {mutable l0 : (string -> unit)}
and [<Struct>] US1 =
    | US1_0 of f0_0 : int64
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : std_string_String
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : string
    | US3_1
and Mut4 = {mutable l0 : int32; mutable l1 : int32; mutable l2 : (string [])}
and Mut5 = {mutable l0 : int32}
and [<Struct>] US4 =
    | US4_0
    | US4_1
    | US4_2
and [<Struct>] US5 =
    | US5_0 of f0_0 : std_fs_FileType
    | US5_1 of f1_0 : std_string_String
and [<Struct>] US6 =
    | US6_0 of f0_0 : async_walkdir_DirEntry
    | US6_1 of f1_0 : std_string_String
and UH0 =
    | UH0_0
    | UH0_1 of char * UH0
and [<Struct>] US8 =
    | US8_0
    | US8_1
and [<Struct>] US7 =
    | US7_0
    | US7_1 of f1_0 : US8
    | US7_2
and UH1 =
    | UH1_0
    | UH1_1 of string * UH1
and [<Struct>] US9 =
    | US9_0
    | US9_1 of f1_0 : char
    | US9_2 of f2_0 : uint8 * f2_1 : char
and [<Struct>] US10 =
    | US10_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>
    | US10_1 of f1_0 : std_string_String
and [<Struct>] US11 =
    | US11_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>
    | US11_1
and [<Struct>] US12 =
    | US12_0 of f0_0 : std_string_String
    | US12_1 of f1_0 : std_string_String
and [<Struct>] US13 =
    | US13_0 of f0_0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)
    | US13_1
and [<Struct>] US14 =
    | US14_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>
    | US14_1
and [<Struct>] US15 =
    | US15_0 of f0_0 : std_process_Output
    | US15_1 of f1_0 : std_string_String
and [<Struct>] US16 =
    | US16_0 of f0_0 : (struct (bool * string * int32) -> Async<unit>)
    | US16_1
and [<Struct>] US17 =
    | US17_0 of f0_0 : System.Threading.CancellationToken
    | US17_1
and [<Struct>] US18 =
    | US18_0 of f0_0 : Result<string, (string * string)>
    | US18_1
and UH3 =
    | UH3_0
    | UH3_1 of string * string * (string -> (string -> US18)) * UH3
and UH2 =
    | UH2_0
    | UH2_1 of UH3 * UH2
and [<Struct>] US19 =
    | US19_0 of f0_0 : int32 * f0_1 : string
    | US19_1 of f1_0 : int32 * f1_1 : string
and Mut6 = {mutable l0 : int32; mutable l1 : int32}
and Mut7 = {mutable l0 : int32; mutable l1 : string; mutable l2 : int32; mutable l3 : int32}
and Mut8 = {mutable l0 : int32; mutable l1 : Vec<Result<string, (string * string)> option>}
let rec method0 () : clap_Command =
    let v0 : string = "command"
    let v1 : string = "r#\"" + v0 + "\"#"
    let v2 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v1
    let v3 : string = "clap::Command::new($0)"
    let v4 : clap_Command = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "source-dir"
    let v6 : string = "r#\"" + v5 + "\"#"
    let v7 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v6
    let v8 : string = "clap::Arg::new($0)"
    let v9 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "$0.short($1)"
    let v11 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v9, 's') v10
    let v12 : string = "r#\"" + v5 + "\"#"
    let v13 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : string = "$0.long($1)"
    let v15 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v11, v13) v14
    let v16 : string = "$0.required($1)"
    let v17 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v15, true) v16
    let v18 : string = "clap::Command::arg($0, $1)"
    let v19 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v4, v17) v18
    let v20 : string = "dist-dir"
    let v21 : string = "r#\"" + v20 + "\"#"
    let v22 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : string = "clap::Arg::new($0)"
    let v24 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "$0.short($1)"
    let v26 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v24, 'd') v25
    let v27 : string = "r#\"" + v20 + "\"#"
    let v28 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v27
    let v29 : string = "$0.long($1)"
    let v30 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v26, v28) v29
    let v31 : string = "$0.required($1)"
    let v32 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v30, true) v31
    let v33 : string = "clap::Command::arg($0, $1)"
    let v34 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v19, v32) v33
    let v35 : string = "cache-dir"
    let v36 : string = "r#\"" + v35 + "\"#"
    let v37 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : string = "clap::Arg::new($0)"
    let v39 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v37 v38
    let v40 : string = "$0.short($1)"
    let v41 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v39, 'c') v40
    let v42 : string = "r#\"" + v35 + "\"#"
    let v43 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : string = "$0.long($1)"
    let v45 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v41, v43) v44
    let v46 : string = "$0.required($1)"
    let v47 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v45, true) v46
    let v48 : string = "clap::Command::arg($0, $1)"
    let v49 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v34, v47) v48
    let v50 : string = "hangul-spec"
    let v51 : string = "r#\"" + v50 + "\"#"
    let v52 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : string = "clap::Arg::new($0)"
    let v54 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v52 v53
    let v55 : string = "$0.short($1)"
    let v56 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v54, 's') v55
    let v57 : string = "r#\"" + v50 + "\"#"
    let v58 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v57
    let v59 : string = "$0.long($1)"
    let v60 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v56, v58) v59
    let v61 : string = "$0.required($1)"
    let v62 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v60, true) v61
    let v63 : string = "clap::Command::arg($0, $1)"
    let v64 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v49, v62) v63
    v64
and closure0 () () : unit =
    let v0 : string = "true; () //"
    let v1 : bool = Fable.Core.RustInterop.emitRustExpr () v0
    let v2 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v2
    let v3 : string = "verify_app"
    let v4 : string = $"*/ #[test] fn " + v3 + "() { //"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : clap_Command = method0()
    let v7 : string = "clap::Command::debug_assert($0)"
    Fable.Core.RustInterop.emitRustExpr v6 v7
    let v8 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v8
    ()
and closure3 () (v0 : string) : unit =
    ()
and method1 () : string =
    let v0 : string = ""
    v0
and method2 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure2 () (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3) =
    let v1 : Mut1 = {l0 = true} : Mut1
    let v2 : Mut0 = {l0 = 0L} : Mut0
    let v3 : Mut2 = {l0 = v0} : Mut2
    let v4 : (string -> unit) = closure3()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v6 : bool = true
    let mutable _v6 : int64 option option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : bool = true
    let mutable _v7 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "std::env::var(&*$0)"
    let v9 : string = "AUTOMATION"
    let v10 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v9 v8
    let v11 : string = "true; let _result = $0.map(|x| { //"
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "x"
    let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = "fable_library_rust::String_::fromString($0)"
    let v16 : string = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "true; $0 })"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "_result"
    let v20 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : string = method1()
    let v22 : string = "$0.unwrap_or($1)"
    let v23 : string = Fable.Core.RustInterop.emitRustExpr struct (v20, v21) v22
    v23 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v24 : string = null |> unbox<string>
    v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : string = null |> unbox<string>
    v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v26 : string = null |> unbox<string>
    v26 
    #endif
#if FABLE_COMPILER_PYTHON
    let v27 : string = null |> unbox<string>
    v27 
    #endif
#else
    let v28 : string = method2()
    let v29 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v30 : string = v29 v28
    v30 
    #endif
    |> fun x -> _v7 <- Some x
    let v31 : string = _v7.Value
    let v33 : bool = v31 = "True"
    let v39 : US1 =
        if v33 then
            let v34 : System.DateTime = System.DateTime.Now
            let v35 : (System.DateTime -> int64) = _.Ticks
            let v36 : int64 = v35 v34
            US1_0(v36)
        else
            US1_1
    let v44 : int64 option =
        match v39 with
        | US1_1 -> (* None *)
            let v42 : int64 option = None
            v42
        | US1_0(v40) -> (* Some *)
            let v41 : int64 option = Some v40 
            v41
    v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : int64 option = None
    v45 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v46 : int64 option = None
    v46 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v47 : int64 option = None
    v47 
    #endif
#if FABLE_COMPILER_PYTHON
    let v48 : int64 option = None
    v48 
    #endif
#else
    let v49 : bool = true
    let mutable _v49 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v50 : string = "std::env::var(&*$0)"
    let v51 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v9 v50
    let v52 : string = "true; let _result = $0.map(|x| { //"
    let v53 : bool = Fable.Core.RustInterop.emitRustExpr v51 v52
    let v54 : string = "x"
    let v55 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : string = "fable_library_rust::String_::fromString($0)"
    let v57 : string = Fable.Core.RustInterop.emitRustExpr v55 v56
    let v58 : string = "true; $0 })"
    let v59 : bool = Fable.Core.RustInterop.emitRustExpr v57 v58
    let v60 : string = "_result"
    let v61 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v60
    let v62 : string = method1()
    let v63 : string = "$0.unwrap_or($1)"
    let v64 : string = Fable.Core.RustInterop.emitRustExpr struct (v61, v62) v63
    v64 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v65 : string = null |> unbox<string>
    v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v66 : string = null |> unbox<string>
    v66 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v67 : string = null |> unbox<string>
    v67 
    #endif
#if FABLE_COMPILER_PYTHON
    let v68 : string = null |> unbox<string>
    v68 
    #endif
#else
    let v69 : string = method2()
    let v70 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v71 : string = v70 v69
    v71 
    #endif
    |> fun x -> _v49 <- Some x
    let v72 : string = _v49.Value
    let v74 : bool = v72 = "True"
    let v80 : US1 =
        if v74 then
            let v75 : System.DateTime = System.DateTime.Now
            let v76 : (System.DateTime -> int64) = _.Ticks
            let v77 : int64 = v76 v75
            US1_0(v77)
        else
            US1_1
    let v85 : int64 option =
        match v80 with
        | US1_1 -> (* None *)
            let v83 : int64 option = None
            v83
        | US1_0(v81) -> (* Some *)
            let v82 : int64 option = Some v81 
            v82
    v85 
    #endif
    |> fun x -> _v6 <- Some x
    let v86 : int64 option = _v6.Value
    struct (v2, v1, v3, v86, v5)
and closure4 () () : string =
    let v0 : string = $"documents.main"
    v0
and closure6 () () : string =
    let v0 : string = ""
    v0
and closure5 (v0 : (string [])) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"args: {v0} / {v1 ()}"
    v2
and method4 () : string =
    let v0 : string = ""
    v0
and closure7 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (US0 -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure2()
    let v4 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v3 v4 |> Some
    let struct (v5 : Mut0, v6 : Mut1, v7 : Mut2, v8 : int64 option, v9 : Mut3) = State.trace_state.Value
    let v10 : bool = true
    let mutable _v10 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : US1 option = None
    let _v11 = ref v11 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v12 : int64 = x
    let v13 : US1 = US1_0(v12)
    v13 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v11.Value <- x
    let v14 : US1 option = _v11.Value 
    let v15 : US1 = US1_1
    let v16 : US1 = v14 |> Option.defaultValue v15 
    let v34 : System.DateTime =
        match v16 with
        | US1_1 -> (* None *)
            let v32 : System.DateTime = System.DateTime.Now
            v32
        | US1_0(v17) -> (* Some *)
            let v18 : System.DateTime = System.DateTime.Now
            let v19 : (System.DateTime -> int64) = _.Ticks
            let v20 : int64 = v19 v18
            let v21 : int64 = v20 - v17
            let v22 : System.TimeSpan = System.TimeSpan v21 
            let v23 : (System.TimeSpan -> int32) = _.Hours
            let v24 : int32 = v23 v22
            let v25 : (System.TimeSpan -> int32) = _.Minutes
            let v26 : int32 = v25 v22
            let v27 : (System.TimeSpan -> int32) = _.Seconds
            let v28 : int32 = v27 v22
            let v29 : (System.TimeSpan -> int32) = _.Milliseconds
            let v30 : int32 = v29 v22
            let v31 : System.DateTime = System.DateTime (1, 1, 1, v24, v26, v28, v30)
            v31
    let v35 : string = "hh:mm:ss"
    let v36 : string = v34.ToString v35 
    v36 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v37 : string = method4()
    v37 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v38 : string = method4()
    v38 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v39 : string = method4()
    v39 
    #endif
#if FABLE_COMPILER_PYTHON
    let v40 : string = method4()
    v40 
    #endif
#else
    let v41 : US1 option = None
    let _v41 = ref v41 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v42 : int64 = x
    let v43 : US1 = US1_0(v42)
    v43 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v41.Value <- x
    let v44 : US1 option = _v41.Value 
    let v45 : US1 = US1_1
    let v46 : US1 = v44 |> Option.defaultValue v45 
    let v64 : System.DateTime =
        match v46 with
        | US1_1 -> (* None *)
            let v62 : System.DateTime = System.DateTime.Now
            v62
        | US1_0(v47) -> (* Some *)
            let v48 : System.DateTime = System.DateTime.Now
            let v49 : (System.DateTime -> int64) = _.Ticks
            let v50 : int64 = v49 v48
            let v51 : int64 = v50 - v47
            let v52 : System.TimeSpan = System.TimeSpan v51 
            let v53 : (System.TimeSpan -> int32) = _.Hours
            let v54 : int32 = v53 v52
            let v55 : (System.TimeSpan -> int32) = _.Minutes
            let v56 : int32 = v55 v52
            let v57 : (System.TimeSpan -> int32) = _.Seconds
            let v58 : int32 = v57 v52
            let v59 : (System.TimeSpan -> int32) = _.Milliseconds
            let v60 : int32 = v59 v52
            let v61 : System.DateTime = System.DateTime (1, 1, 1, v54, v56, v58, v60)
            v61
    let v65 : string = "HH:mm:ss"
    let v66 : string = v64.ToString v65 
    v66 
    #endif
    |> fun x -> _v10 <- Some x
    let v67 : string = _v10.Value
    let v68 : int64 = v5.l0
    let v78 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v73 : string = "Critical"
            v73
        | US0_1 -> (* Debug *)
            let v70 : string = "Debug"
            v70
        | US0_2 -> (* Info *)
            let v71 : string = "Info"
            v71
        | US0_0 -> (* Verbose *)
            let v69 : string = "Verbose"
            v69
        | US0_3 -> (* Warning *)
            let v72 : string = "Warning"
            v72
    let v79 : string = v78.ToLower ()
    let v80 : string = v79.PadLeft (7, ' ')
    let v81 : bool = true
    let mutable _v81 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v96 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v90 : string = "inline_colorization::color_bright_red"
            let v91 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v90
            v91
        | US0_1 -> (* Debug *)
            let v84 : string = "inline_colorization::color_bright_blue"
            let v85 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v84
            v85
        | US0_2 -> (* Info *)
            let v86 : string = "inline_colorization::color_bright_green"
            let v87 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v86
            v87
        | US0_0 -> (* Verbose *)
            let v82 : string = "inline_colorization::color_bright_black"
            let v83 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v82
            v83
        | US0_3 -> (* Warning *)
            let v88 : string = "inline_colorization::color_yellow"
            let v89 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v88
            v89
    let v97 : string = "&*$0"
    let v98 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v80 v97
    let v99 : string = "inline_colorization::color_reset"
    let v100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v99
    let v101 : string = "\"{v96}{v98}{v100}\""
    let v102 : string = @$"format!(" + v101 + ")"
    let v103 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v102
    let v104 : string = "fable_library_rust::String_::fromString($0)"
    let v105 : string = Fable.Core.RustInterop.emitRustExpr v103 v104
    v105 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v120 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v114 : string = "inline_colorization::color_bright_red"
            let v115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v114
            v115
        | US0_1 -> (* Debug *)
            let v108 : string = "inline_colorization::color_bright_blue"
            let v109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v108
            v109
        | US0_2 -> (* Info *)
            let v110 : string = "inline_colorization::color_bright_green"
            let v111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v110
            v111
        | US0_0 -> (* Verbose *)
            let v106 : string = "inline_colorization::color_bright_black"
            let v107 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v106
            v107
        | US0_3 -> (* Warning *)
            let v112 : string = "inline_colorization::color_yellow"
            let v113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v112
            v113
    let v121 : string = "&*$0"
    let v122 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v80 v121
    let v123 : string = "inline_colorization::color_reset"
    let v124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v123
    let v125 : string = "\"{v120}{v122}{v124}\""
    let v126 : string = @$"format!(" + v125 + ")"
    let v127 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v126
    let v128 : string = "fable_library_rust::String_::fromString($0)"
    let v129 : string = Fable.Core.RustInterop.emitRustExpr v127 v128
    v129 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v144 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v138 : string = "inline_colorization::color_bright_red"
            let v139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v138
            v139
        | US0_1 -> (* Debug *)
            let v132 : string = "inline_colorization::color_bright_blue"
            let v133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v132
            v133
        | US0_2 -> (* Info *)
            let v134 : string = "inline_colorization::color_bright_green"
            let v135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v134
            v135
        | US0_0 -> (* Verbose *)
            let v130 : string = "inline_colorization::color_bright_black"
            let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130
            v131
        | US0_3 -> (* Warning *)
            let v136 : string = "inline_colorization::color_yellow"
            let v137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v136
            v137
    let v145 : string = "&*$0"
    let v146 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v80 v145
    let v147 : string = "inline_colorization::color_reset"
    let v148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v147
    let v149 : string = "\"{v144}{v146}{v148}\""
    let v150 : string = @$"format!(" + v149 + ")"
    let v151 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v150
    let v152 : string = "fable_library_rust::String_::fromString($0)"
    let v153 : string = Fable.Core.RustInterop.emitRustExpr v151 v152
    v153 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v80 
    #endif
#if FABLE_COMPILER_PYTHON
    v80 
    #endif
#else
    v80 
    #endif
    |> fun x -> _v81 <- Some x
    let v154 : string = _v81.Value
    let v155 : string = $"{v67} {v154} #{v68} %s{v1 ()} / %s{v2 ()}"
    let v156 : (char []) = [||]
    let v157 : string = v155.TrimStart v156
    let v158 : (char []) = [|' '; '/'|]
    let v159 : string = v157.TrimEnd v158
    v159
and method5 (v0 : US0, v1 : (unit -> string)) : unit =
    let v2 : (US0 -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure2()
    let v3 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v2 v3 |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut2, v7 : int64 option, v8 : Mut3) = State.trace_state.Value
    let v9 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v2 v9 |> Some
    let struct (v10 : Mut0, v11 : Mut1, v12 : Mut2, v13 : int64 option, v14 : Mut3) = State.trace_state.Value
    let v15 : US0 = v12.l0
    let v16 : bool = v11.l0
    let v17 : bool = v16 = false
    let v21 : bool =
        if v17 then
            false
        else
            let v18 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
            let v19 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v15
            let v20 : bool = v18 >= v19
            v20
    if v21 then
        let v22 : int64 = v4.l0
        let v23 : int64 = v22 + 1L
        v4.l0 <- v23
        let v24 : string = $"%s{v1 ()}"
        let v25 : bool = true
        let mutable _v25 : unit option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v26 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v24 v26
        () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v27 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v24 v27
        () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v28 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v24 v28
        () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v24 
        () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v24 
        () 
        #endif
#else
        System.Console.WriteLine v24 
        () 
        #endif
        |> fun x -> _v25 <- Some x
        _v25.Value
        let v29 : (string -> unit) = v8.l0
        v29 v24
and method3 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> string) = closure7(v0, v1, v2)
    method5(v0, v3)
and method6 () : string =
    let v0 : string = "source-dir"
    v0
and method7 () : string =
    let v0 : string = "dist-dir"
    v0
and method8 () : string =
    let v0 : string = "cache-dir"
    v0
and method9 () : string =
    let v0 : string = "hangul-spec"
    v0
and method12 (v0 : string) : string =
    v0
and method13 (v0 : string) : string =
    v0
and method11 (v0 : string, v1 : string) : string =
    let v2 : bool = true
    let mutable _v2 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "&*$0"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v3
    let v5 : string = "String::from($0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "std::path::PathBuf::from($0)"
    let v8 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "&*$0"
    let v10 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v9
    let v11 : string = "String::from($0)"
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "$0.join($1)"
    let v14 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v8, v12) v13
    let v15 : string = "$0.display()"
    let v16 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : bool = true
    let mutable _v17 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = "format!(\"{}\", $0)"
    let v19 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v18
    v19 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = "format!(\"{}\", $0)"
    let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v20
    v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = "format!(\"{}\", $0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v22
    v23 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v24 : std_string_String = null |> unbox<std_string_String>
    v24 
    #endif
#if FABLE_COMPILER_PYTHON
    let v25 : std_string_String = null |> unbox<std_string_String>
    v25 
    #endif
#else
    let v26 : std_string_String = null |> unbox<std_string_String>
    v26 
    #endif
    |> fun x -> _v17 <- Some x
    let v27 : std_string_String = _v17.Value
    let v28 : string = "fable_library_rust::String_::fromString($0)"
    let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28
    v29 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = null |> unbox<string>
    v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = null |> unbox<string>
    v31 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v32 : string = "path"
    let v33 : IPathJoin = Fable.Core.JsInterop.importAll v32
    let v34 : string = method12(v0)
    let v35 : string = method13(v1)
    let v36 : string = "v33.join(v34, v35)"
    let v37 : string = Fable.Core.JsInterop.emitJsExpr () v36
    v37 
    #endif
#if FABLE_COMPILER_PYTHON
    let v38 : string = null |> unbox<string>
    v38 
    #endif
#else
    let v39 : string = System.IO.Path.Combine (v0, v1)
    v39 
    #endif
    |> fun x -> _v2 <- Some x
    let v40 : string = _v2.Value
    v40
and closure8 () (v0 : string) : string option =
    let v1 : bool = true
    let mutable _v1 : US3 option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "&*$0"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v2
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "std::path::PathBuf::from($0)"
    let v7 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "$0.parent().map(std::path::PathBuf::from)"
    let v9 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "$0?"
    let v11 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "$0.display()"
    let v13 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : bool = true
    let mutable _v14 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = "format!(\"{}\", $0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v15
    v16 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = "format!(\"{}\", $0)"
    let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v17
    v18 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : string = "format!(\"{}\", $0)"
    let v20 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v19
    v20 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : std_string_String = null |> unbox<std_string_String>
    v21 
    #endif
#if FABLE_COMPILER_PYTHON
    let v22 : std_string_String = null |> unbox<std_string_String>
    v22 
    #endif
#else
    let v23 : std_string_String = null |> unbox<std_string_String>
    v23 
    #endif
    |> fun x -> _v14 <- Some x
    let v24 : std_string_String = _v14.Value
    let v25 : string = "fable_library_rust::String_::fromString($0)"
    let v26 : string = Fable.Core.RustInterop.emitRustExpr v24 v25
    let v27 : US3 = US3_0(v26)
    v27 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v28 : US3 = null |> unbox<US3>
    v28 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : US3 = null |> unbox<US3>
    v29 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v30 : string = "path"
    let v31 : IPathDirname = Fable.Core.JsInterop.importAll v30
    let v32 : string = "v31.dirname($0)"
    let v33 : string = Fable.Core.JsInterop.emitJsExpr v0 v32
    let v34 : US3 = US3_0(v33)
    v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v35 : US3 = null |> unbox<US3>
    v35 
    #endif
#else
    let v36 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.GetParent
    let v37 : System.IO.DirectoryInfo = v36 v0
    let v38 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let v39 : bool = v37 = v38
    let v50 : US3 =
        if v39 then
            US3_1
        else
            let v41 : bool = true
            let mutable _v41 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v42 : string = null |> unbox<string>
            v42 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v43 : string = null |> unbox<string>
            v43 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v44 : string = null |> unbox<string>
            v44 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v45 : string = null |> unbox<string>
            v45 
            #endif
#if FABLE_COMPILER_PYTHON
            let v46 : string = null |> unbox<string>
            v46 
            #endif
#else
            let v47 : string = v37.FullName
            v47 
            #endif
            |> fun x -> _v41 <- Some x
            let v48 : string = _v41.Value
            US3_0(v48)
    v50 
    #endif
    |> fun x -> _v1 <- Some x
    let v51 : US3 = _v1.Value
    match v51 with
    | US3_1 -> (* None *)
        let v54 : string option = None
        v54
    | US3_0(v52) -> (* Some *)
        let v53 : string option = Some v52 
        v53
and method15 () : (string -> string option) =
    closure8()
and method16 (v0 : string, v1 : string, v2 : string) : string =
    let v3 : string = method11(v2, v0)
    let v4 : bool = true
    let mutable _v4 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = "&*$0"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "std::path::PathBuf::from($0)"
    let v10 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "$0.exists()"
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v15 : bool =
        if v12 then
            let v13 : string = "$0.is_dir()"
            let v14 : bool = Fable.Core.RustInterop.emitRustExpr v10 v13
            v14
        else
            false
    v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : bool = null |> unbox<bool>
    v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17 : bool = null |> unbox<bool>
    v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : string = "fs"
    let v19 : IFsExistsSync = Fable.Core.JsInterop.importAll v18
    let v20 : string = "$0.existsSync($1)"
    let v21 : bool = Fable.Core.JsInterop.emitJsExpr struct (v19, v3) v20
    v21 
    #endif
#if FABLE_COMPILER_PYTHON
    let v22 : bool = null |> unbox<bool>
    v22 
    #endif
#else
    let v23 : (string -> bool) = System.IO.Directory.Exists
    let v24 : bool = v23 v3
    v24 
    #endif
    |> fun x -> _v4 <- Some x
    let v25 : bool = _v4.Value
    if v25 then
        v2
    else
        let v26 : (string -> string option) = method15()
        let v27 : string option = v26 v2
        let v28 : US3 option = None
        let _v28 = ref v28 
        match v27 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v29 : string = x
        let v30 : US3 = US3_0(v29)
        v30 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v28.Value <- x
        let v31 : US3 option = _v28.Value 
        let v32 : US3 = US3_1
        let v33 : US3 = v31 |> Option.defaultValue v32 
        match v33 with
        | US3_1 -> (* None *)
            let v36 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            failwith<string> v36
        | US3_0(v34) -> (* Some *)
            method16(v0, v1, v34)
and method14 (v0 : string, v1 : string) : string =
    let v2 : string = method11(v1, v0)
    let v3 : bool = true
    let mutable _v3 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "std::path::PathBuf::from($0)"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "$0.exists()"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v14 : bool =
        if v11 then
            let v12 : string = "$0.is_dir()"
            let v13 : bool = Fable.Core.RustInterop.emitRustExpr v9 v12
            v13
        else
            false
    v14 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : bool = null |> unbox<bool>
    v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : bool = null |> unbox<bool>
    v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : string = "fs"
    let v18 : IFsExistsSync = Fable.Core.JsInterop.importAll v17
    let v19 : string = "$0.existsSync($1)"
    let v20 : bool = Fable.Core.JsInterop.emitJsExpr struct (v18, v2) v19
    v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : bool = null |> unbox<bool>
    v21 
    #endif
#else
    let v22 : (string -> bool) = System.IO.Directory.Exists
    let v23 : bool = v22 v2
    v23 
    #endif
    |> fun x -> _v3 <- Some x
    let v24 : bool = _v3.Value
    if v24 then
        v1
    else
        let v25 : (string -> string option) = method15()
        let v26 : string option = v25 v1
        let v27 : US3 option = None
        let _v27 = ref v27 
        match v26 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v28 : string = x
        let v29 : US3 = US3_0(v28)
        v29 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v27.Value <- x
        let v30 : US3 option = _v27.Value 
        let v31 : US3 = US3_1
        let v32 : US3 = v30 |> Option.defaultValue v31 
        match v32 with
        | US3_1 -> (* None *)
            let v35 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            failwith<string> v35
        | US3_0(v33) -> (* Some *)
            method16(v0, v1, v33)
and method17 (v0 : string) : string =
    v0
and method18 (v0 : string) : string =
    v0
and method19 () : string =
    let v0 : string = ""
    v0
and method20 () : string =
    let v0 : string = "^\\\\\\\\\\?\\\\"
    v0
and method21 () : string =
    let v0 : string = ""
    v0
and method22 (v0 : int32, v1 : Mut4) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method23 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method24 (v0 : string) : string =
    v0
and method25 (v0 : string) : string =
    v0
and closure9 () () : string =
    let v0 : string = "documents.run"
    v0
and closure10 (v0 : string, v1 : string, v2 : string, v3 : string) () : string =
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"source_dir: {v1} / dist_dir: {v2} / cache_dir: {v3} / hangul_spec: %A{v0} / {v4 ()}"
    v5
and method28 (v0 : async_walkdir_DirEntry) : async_walkdir_DirEntry =
    v0
and closure12 () (v0 : std_io_Error) : std_string_String =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = _v1.Value
    v11
and method29 () : (std_io_Error -> std_string_String) =
    closure12()
and closure13 () (v0 : std_fs_FileType) : US5 =
    US5_0(v0)
and closure14 () (v0 : std_string_String) : US5 =
    US5_1(v0)
and method30 (v0 : std_fs_FileType) : std_fs_FileType =
    v0
and method31 (v0 : US4) : US4 =
    v0
and method27 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US4>>, Send<Dyn<std_future_Future<US4>>>>>> =
    let v1 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : async_walkdir_DirEntry = method28(v0)
    let v3 : string = "Box::pin(async_walkdir::DirEntry::file_type(&v2))"
    let v4 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>, Send<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>>>>> = Fable.Core.RustInterop.emitRustExpr () v3
    let v5 : string = "v4.await"
    let v6 : Result<std_fs_FileType, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v5
    let v7 : (std_io_Error -> std_string_String) = method29()
    let v8 : string = "$0.map_err(|x| $1(x))"
    let v9 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6, v7) v8
    let v10 : (std_fs_FileType -> US5) = closure13()
    let v11 : (std_string_String -> US5) = closure14()
    let v12 : US5 = match v9 with Ok x -> v10 x | Error x -> v11 x
    let v71 : US4 =
        match v12 with
        | US5_0(v13) -> (* Ok *)
            let v14 : std_fs_FileType = method30(v13)
            let v15 : string = "std::fs::FileType::is_dir(&v14)"
            let v16 : bool = Fable.Core.RustInterop.emitRustExpr () v15
            if v16 then
                US4_0
            else
                let v18 : string = "async_walkdir::DirEntry::path(&$0)"
                let v19 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v0 v18
                let v20 : string = "$0.display()"
                let v21 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v19 v20
                let v22 : bool = true
                let mutable _v22 : std_string_String option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v23 : string = "format!(\"{}\", $0)"
                let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v23
                v24 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v25 : string = "format!(\"{}\", $0)"
                let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v25
                v26 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v27 : string = "format!(\"{}\", $0)"
                let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v27
                v28 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v29 : std_string_String = null |> unbox<std_string_String>
                v29 
                #endif
#if FABLE_COMPILER_PYTHON
                let v30 : std_string_String = null |> unbox<std_string_String>
                v30 
                #endif
#else
                let v31 : std_string_String = null |> unbox<std_string_String>
                v31 
                #endif
                |> fun x -> _v22 <- Some x
                let v32 : std_string_String = _v22.Value
                let v33 : string = "fable_library_rust::String_::fromString($0)"
                let v34 : string = Fable.Core.RustInterop.emitRustExpr v32 v33
                let v35 : string = ".md"
                let v36 : bool = v34.EndsWith v35
                let v37 : bool = v36 = false
                let v40 : bool =
                    if v37 then
                        true
                    else
                        let v38 : string = ".hangul.md"
                        let v39 : bool = v34.EndsWith v38
                        v39
                if v40 then
                    US4_0
                else
                    US4_2
        | _ ->
            let v45 : string = "async_walkdir::DirEntry::path(&$0)"
            let v46 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v0 v45
            let v47 : string = "$0.display()"
            let v48 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v46 v47
            let v49 : bool = true
            let mutable _v49 : std_string_String option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v50 : string = "format!(\"{}\", $0)"
            let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr v48 v50
            v51 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v52 : string = "format!(\"{}\", $0)"
            let v53 : std_string_String = Fable.Core.RustInterop.emitRustExpr v48 v52
            v53 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v54 : string = "format!(\"{}\", $0)"
            let v55 : std_string_String = Fable.Core.RustInterop.emitRustExpr v48 v54
            v55 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v56 : std_string_String = null |> unbox<std_string_String>
            v56 
            #endif
#if FABLE_COMPILER_PYTHON
            let v57 : std_string_String = null |> unbox<std_string_String>
            v57 
            #endif
#else
            let v58 : std_string_String = null |> unbox<std_string_String>
            v58 
            #endif
            |> fun x -> _v49 <- Some x
            let v59 : std_string_String = _v49.Value
            let v60 : string = "fable_library_rust::String_::fromString($0)"
            let v61 : string = Fable.Core.RustInterop.emitRustExpr v59 v60
            let v62 : string = ".md"
            let v63 : bool = v61.EndsWith v62
            let v64 : bool = v63 = false
            let v67 : bool =
                if v64 then
                    true
                else
                    let v65 : string = ".hangul.md"
                    let v66 : bool = v61.EndsWith v65
                    v66
            if v67 then
                US4_0
            else
                US4_2
    let v72 : US4 = method31(v71)
    let v73 : string = ""
    let v74 : string = "}"
    let v75 : string = v73 + v74
    let v76 : string = v75 + v74
    let v77 : string = "{"
    let v78 : string = v73 + v77
    let v79 : string = "v72 " + v76 + "); " + v78 + " //"
    Fable.Core.RustInterop.emitRustExpr () v79
    let v80 : string = "__result"
    let v81 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US4>>, Send<Dyn<std_future_Future<US4>>>>>> = Fable.Core.RustInterop.emitRustExpr () v80
    v81
and method32 (v0 : async_walkdir_Filtering) : async_walkdir_Filtering =
    v0
and method26 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> =
    let v1 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US4>>, Send<Dyn<std_future_Future<US4>>>>>> = method27(v0)
    let v3 : string = "v2.await"
    let v4 : US4 = Fable.Core.RustInterop.emitRustExpr () v3
    let v13 : async_walkdir_Filtering =
        match v4 with
        | US4_2 -> (* Continue *)
            let v9 : string = "async_walkdir::Filtering::Continue"
            let v10 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v9
            v10
        | US4_0 -> (* Ignore *)
            let v5 : string = "async_walkdir::Filtering::Ignore"
            let v6 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v5
            v6
        | US4_1 -> (* IgnoreDir *)
            let v7 : string = "async_walkdir::Filtering::IgnoreDir"
            let v8 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v7
            v8
    let v14 : async_walkdir_Filtering = method32(v13)
    let v15 : string = ""
    let v16 : string = "}"
    let v17 : string = v15 + v16
    let v18 : string = v17 + v16
    let v19 : string = "{"
    let v20 : string = v15 + v19
    let v21 : string = "v14 " + v18 + "); " + v20 + " //"
    Fable.Core.RustInterop.emitRustExpr () v21
    let v22 : string = "__result"
    let v23 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> = Fable.Core.RustInterop.emitRustExpr () v22
    v23
and closure11 () (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> =
    method26(v0)
and closure16 () (v0 : async_walkdir_DirEntry) : US6 =
    US6_0(v0)
and closure17 () (v0 : std_string_String) : US6 =
    US6_1(v0)
and closure18 () () : string =
    let v0 : string = "documents.run / stream_filter_map"
    v0
and closure19 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and closure15 () (v0 : Result<async_walkdir_DirEntry, std_io_Error>) : string option =
    let v1 : (std_io_Error -> std_string_String) = method29()
    let v2 : string = "$0.map_err(|x| $1(x))"
    let v3 : Result<async_walkdir_DirEntry, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v2
    let v4 : (async_walkdir_DirEntry -> US6) = closure16()
    let v5 : (std_string_String -> US6) = closure17()
    let v6 : US6 = match v3 with Ok x -> v4 x | Error x -> v5 x
    let v32 : US3 =
        match v6 with
        | US6_1(v26) -> (* Error *)
            let v27 : US0 = US0_4
            let v28 : (unit -> string) = closure18()
            let v29 : (unit -> string) = closure19(v26)
            method3(v27, v28, v29)
            US3_1
        | US6_0(v7) -> (* Ok *)
            let v8 : string = "async_walkdir::DirEntry::path(&$0)"
            let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8
            let v10 : string = "$0.display()"
            let v11 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v9 v10
            let v12 : bool = true
            let mutable _v12 : std_string_String option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v13 : string = "format!(\"{}\", $0)"
            let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v13
            v14 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v15 : string = "format!(\"{}\", $0)"
            let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v15
            v16 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v17 : string = "format!(\"{}\", $0)"
            let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v17
            v18 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v19 : std_string_String = null |> unbox<std_string_String>
            v19 
            #endif
#if FABLE_COMPILER_PYTHON
            let v20 : std_string_String = null |> unbox<std_string_String>
            v20 
            #endif
#else
            let v21 : std_string_String = null |> unbox<std_string_String>
            v21 
            #endif
            |> fun x -> _v12 <- Some x
            let v22 : std_string_String = _v12.Value
            let v23 : string = "fable_library_rust::String_::fromString($0)"
            let v24 : string = Fable.Core.RustInterop.emitRustExpr v22 v23
            US3_0(v24)
    match v32 with
    | US3_1 -> (* None *)
        let v35 : string option = None
        v35
    | US3_0(v33) -> (* Some *)
        let v34 : string option = Some v33 
        v34
and method33 () : (Result<async_walkdir_DirEntry, std_io_Error> -> string option) =
    closure15()
and closure20 () () : string =
    let v0 : string = "documents.run"
    v0
and closure21 (v0 : Vec<string>) () : string =
    let v1 : string = "$0.len()"
    let v2 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"files_len: {v2} / {v3 ()}"
    v4
and method34 (v0 : string) : string =
    let v1 : bool = true
    let mutable _v1 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method17(v0)
    let v3 : string = "&*$0"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "String::from($0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "std::path::PathBuf::from($0)"
    let v8 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "$0.exists()"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : bool = v10 = false
    let v167 : string =
        if v11 then
            let v12 : bool = true
            let mutable _v12 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v13 : string = "std::env::current_dir()"
            let v14 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v13
            let v15 : string = "$0.unwrap()"
            let v16 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v14 v15
            let v17 : string = "$0.display()"
            let v18 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v16 v17
            let v19 : bool = true
            let mutable _v19 : std_string_String option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v20 : string = "format!(\"{}\", $0)"
            let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v20
            v21 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v22 : string = "format!(\"{}\", $0)"
            let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v22
            v23 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v24 : string = "format!(\"{}\", $0)"
            let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v24
            v25 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v26 : std_string_String = null |> unbox<std_string_String>
            v26 
            #endif
#if FABLE_COMPILER_PYTHON
            let v27 : std_string_String = null |> unbox<std_string_String>
            v27 
            #endif
#else
            let v28 : std_string_String = null |> unbox<std_string_String>
            v28 
            #endif
            |> fun x -> _v19 <- Some x
            let v29 : std_string_String = _v19.Value
            let v30 : string = "fable_library_rust::String_::fromString($0)"
            let v31 : string = Fable.Core.RustInterop.emitRustExpr v29 v30
            v31 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v32 : string = null |> unbox<string>
            v32 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v33 : string = null |> unbox<string>
            v33 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v34 : string = null |> unbox<string>
            v34 
            #endif
#if FABLE_COMPILER_PYTHON
            let v35 : string = null |> unbox<string>
            v35 
            #endif
#else
            let v36 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v37 : string = v36 ()
            v37 
            #endif
            |> fun x -> _v12 <- Some x
            let v38 : string = _v12.Value
            let v39 : string = method11(v38, v2)
            let v40 : bool = true
            let mutable _v40 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v41 : string = method18(v39)
            let v42 : string = method19()
            let v43 : bool = true
            let mutable _v43 : Result<regex_Regex, regex_Error> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v44 : string = method20()
            let v45 : string = $"regex::Regex::new(&$0)"
            let v46 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v44 v45
            v46 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v47 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v47 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v48 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v48 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v49 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v49 
            #endif
#if FABLE_COMPILER_PYTHON
            let v50 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v50 
            #endif
#else
            let v51 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v51 
            #endif
            |> fun x -> _v43 <- Some x
            let v52 : Result<regex_Regex, regex_Error> = _v43.Value
            let v53 : string = "$0.unwrap()"
            let v54 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v52 v53
            let v55 : string = $"$0.replace_all(&$1, &*$2)"
            let v56 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v54, v41, v42) v55
            let v57 : string = "String::from($0)"
            let v58 : std_string_String = Fable.Core.RustInterop.emitRustExpr v56 v57
            let v59 : string = "fable_library_rust::String_::fromString($0)"
            let v60 : string = Fable.Core.RustInterop.emitRustExpr v58 v59
            v60 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v61 : string = null |> unbox<string>
            v61 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v62 : string = null |> unbox<string>
            v62 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v63 : string = null |> unbox<string>
            v63 
            #endif
#if FABLE_COMPILER_PYTHON
            let v64 : string = null |> unbox<string>
            v64 
            #endif
#else
            let v65 : string = method21()
            let v66 : string = "^\\\\\\\\\\?\\\\"
            let v67 : string = System.Text.RegularExpressions.Regex.Replace (v39, v66, v65)
            v67 
            #endif
            |> fun x -> _v40 <- Some x
            let v68 : string = _v40.Value
            let v69 : string = $"{v68.[0] |> string |> _.ToLower()}{v68.[1..]}"
            let v70 : string = "\\"
            let v71 : string = "/"
            let v72 : string = v69.Replace (v70, v71)
            let v73 : (string []) = v72.Split v71
            let v74 : (string []) = [||]
            let v75 : int32 = v73.Length
            let v76 : Mut4 = {l0 = 0; l1 = 0; l2 = v74} : Mut4
            while method22(v75, v76) do
                let v78 : int32 = v76.l0
                let v79 : int32 =  -v78
                let v80 : int32 = v79 + v75
                let v81 : int32 = v80 - 1
                let struct (v82 : int32, v83 : (string [])) = v76.l1, v76.l2
                let v84 : string = v73.[int v81]
                let v85 : bool = ".." = v84
                let struct (v127 : int32, v128 : (string [])) =
                    if v85 then
                        let v86 : int32 = v82 + 1
                        struct (v86, v83)
                    else
                        let v87 : bool = "." = v84
                        if v87 then
                            struct (v82, v83)
                        else
                            let v88 : bool = 0 = v82
                            if v88 then
                                let v89 : string = ":"
                                let v90 : bool = v84.EndsWith v89
                                if v90 then
                                    let v91 : string = $"{v38.[0]}:"
                                    let v92 : (string []) = [|v91|]
                                    let v93 : int32 = v92.Length
                                    let v94 : int32 = v83.Length
                                    let v95 : int32 = v93 + v94
                                    let v96 : (string []) = Array.zeroCreate<string> (v95)
                                    let v97 : Mut5 = {l0 = 0} : Mut5
                                    while method23(v95, v97) do
                                        let v99 : int32 = v97.l0
                                        let v100 : bool = v99 < v93
                                        let v104 : string =
                                            if v100 then
                                                let v101 : string = v92.[int v99]
                                                v101
                                            else
                                                let v102 : int32 = v99 - v93
                                                let v103 : string = v83.[int v102]
                                                v103
                                        v96.[int v99] <- v104
                                        let v105 : int32 = v99 + 1
                                        v97.l0 <- v105
                                        ()
                                    struct (0, v96)
                                else
                                    let v106 : (string []) = [|v84|]
                                    let v107 : int32 = v106.Length
                                    let v108 : int32 = v83.Length
                                    let v109 : int32 = v107 + v108
                                    let v110 : (string []) = Array.zeroCreate<string> (v109)
                                    let v111 : Mut5 = {l0 = 0} : Mut5
                                    while method23(v109, v111) do
                                        let v113 : int32 = v111.l0
                                        let v114 : bool = v113 < v107
                                        let v118 : string =
                                            if v114 then
                                                let v115 : string = v106.[int v113]
                                                v115
                                            else
                                                let v116 : int32 = v113 - v107
                                                let v117 : string = v83.[int v116]
                                                v117
                                        v110.[int v113] <- v118
                                        let v119 : int32 = v113 + 1
                                        v111.l0 <- v119
                                        ()
                                    struct (0, v110)
                            else
                                let v122 : int32 = v82 - 1
                                struct (v122, v83)
                let v129 : int32 = v78 + 1
                v76.l0 <- v129
                v76.l1 <- v127
                v76.l2 <- v128
                ()
            let struct (v130 : int32, v131 : (string [])) = v76.l1, v76.l2
            let v132 : string seq = seq { for i = 0 to v131.Length - 1 do yield v131.[i] }
            let v133 : bool = true
            let mutable _v133 : char option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v134 : string = "std::path::MAIN_SEPARATOR"
            let v135 : char = Fable.Core.RustInterop.emitRustExpr () v134
            v135 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v136 : char = null |> unbox<char>
            v136 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v137 : char = null |> unbox<char>
            v137 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v138 : char = null |> unbox<char>
            v138 
            #endif
#if FABLE_COMPILER_PYTHON
            let v139 : char = null |> unbox<char>
            v139 
            #endif
#else
            let v140 : char = System.IO.Path.DirectorySeparatorChar
            v140 
            #endif
            |> fun x -> _v133 <- Some x
            let v141 : char = _v133.Value
            let v142 : (char -> string) = _.ToString()
            let v143 : string = v142 v141
            let v144 : string = method24(v143)
            let v145 : (string -> (string seq -> string)) = String.concat
            let v146 : (string seq -> string) = v145 v144
            v146 v132
        else
            let v148 : string = "std::fs::canonicalize(&*$0)"
            let v149 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v148
            let v150 : string = "$0.unwrap()"
            let v151 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v149 v150
            let v152 : string = "$0.display()"
            let v153 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v151 v152
            let v154 : bool = true
            let mutable _v154 : std_string_String option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v155 : string = "format!(\"{}\", $0)"
            let v156 : std_string_String = Fable.Core.RustInterop.emitRustExpr v153 v155
            v156 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v157 : string = "format!(\"{}\", $0)"
            let v158 : std_string_String = Fable.Core.RustInterop.emitRustExpr v153 v157
            v158 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v159 : string = "format!(\"{}\", $0)"
            let v160 : std_string_String = Fable.Core.RustInterop.emitRustExpr v153 v159
            v160 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v161 : std_string_String = null |> unbox<std_string_String>
            v161 
            #endif
#if FABLE_COMPILER_PYTHON
            let v162 : std_string_String = null |> unbox<std_string_String>
            v162 
            #endif
#else
            let v163 : std_string_String = null |> unbox<std_string_String>
            v163 
            #endif
            |> fun x -> _v154 <- Some x
            let v164 : std_string_String = _v154.Value
            let v165 : string = "fable_library_rust::String_::fromString($0)"
            let v166 : string = Fable.Core.RustInterop.emitRustExpr v164 v165
            v166
    v167 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v168 : string = null |> unbox<string>
    v168 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v169 : string = null |> unbox<string>
    v169 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v170 : string = null |> unbox<string>
    v170 
    #endif
#if FABLE_COMPILER_PYTHON
    let v171 : string = null |> unbox<string>
    v171 
    #endif
#else
    let v172 : string = method25(v0)
    let v173 : (string -> string) = System.IO.Path.GetFullPath
    let v174 : string = v173 v172
    v174 
    #endif
    |> fun x -> _v1 <- Some x
    let v175 : string = _v1.Value
    let v176 : bool = true
    let mutable _v176 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v177 : string = method18(v175)
    let v178 : string = method19()
    let v179 : bool = true
    let mutable _v179 : Result<regex_Regex, regex_Error> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v180 : string = method20()
    let v181 : string = $"regex::Regex::new(&$0)"
    let v182 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v180 v181
    v182 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v183 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
    v183 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v184 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
    v184 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v185 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
    v185 
    #endif
#if FABLE_COMPILER_PYTHON
    let v186 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
    v186 
    #endif
#else
    let v187 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
    v187 
    #endif
    |> fun x -> _v179 <- Some x
    let v188 : Result<regex_Regex, regex_Error> = _v179.Value
    let v189 : string = "$0.unwrap()"
    let v190 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v188 v189
    let v191 : string = $"$0.replace_all(&$1, &*$2)"
    let v192 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v190, v177, v178) v191
    let v193 : string = "String::from($0)"
    let v194 : std_string_String = Fable.Core.RustInterop.emitRustExpr v192 v193
    let v195 : string = "fable_library_rust::String_::fromString($0)"
    let v196 : string = Fable.Core.RustInterop.emitRustExpr v194 v195
    v196 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v197 : string = null |> unbox<string>
    v197 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v198 : string = null |> unbox<string>
    v198 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v199 : string = null |> unbox<string>
    v199 
    #endif
#if FABLE_COMPILER_PYTHON
    let v200 : string = null |> unbox<string>
    v200 
    #endif
#else
    let v201 : string = method21()
    let v202 : string = "^\\\\\\\\\\?\\\\"
    let v203 : string = System.Text.RegularExpressions.Regex.Replace (v175, v202, v201)
    v203 
    #endif
    |> fun x -> _v176 <- Some x
    let v204 : string = _v176.Value
    let v205 : string = $"{v204.[0] |> string |> _.ToLower()}{v204.[1..]}"
    let v206 : string = "\\"
    let v207 : string = "/"
    let v208 : string = v205.Replace (v206, v207)
    v208
and method36 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : string =
    v1
and method37 () : struct (string * string) =
    let v0 : string = ""
    struct (v0, v0)
and closure24 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure23 () (v0 : char) : (UH0 -> UH0) =
    closure24(v0)
and method38 () : (char -> (UH0 -> UH0)) =
    closure23()
and method39 (v0 : string, v1 : string, v2 : UH0, v3 : US7) : struct (string * string) =
    match v2 with
    | UH0_1(v4, v5) -> (* Cons *)
        let v6 : bool = '"' = v4
        if v6 then
            let v8 : bool = v1 = ""
            if v8 then
                let v9 : US8 = US8_0
                let v10 : US7 = US7_1(v9)
                method39(v0, v1, v5, v10)
            else
                match v3 with
                | US7_2 -> (* Arguments *)
                    let v38 : string = $"{v0}{v4}"
                    let v39 : US7 = US7_2
                    method39(v38, v1, v5, v39)
                | US7_1(v13) -> (* Path *)
                    match v13 with
                    | US8_0 -> (* Quoted *)
                        let v14 : US8 = US8_1
                        let v15 : US7 = US7_1(v14)
                        method39(v0, v1, v5, v15)
                    | _ ->
                        let v18 : bool = ' ' = v4
                        if v18 then
                            let v19 : US7 = US7_2
                            method39(v0, v1, v5, v19)
                        else
                            let v22 : string = $"{v1}{v4}"
                            method39(v0, v22, v5, v3)
                | US7_0 -> (* Start *)
                    let v29 : bool = ' ' = v4
                    if v29 then
                        let v30 : US7 = US7_2
                        method39(v0, v1, v5, v30)
                    else
                        let v33 : string = $"{v1}{v4}"
                        method39(v0, v33, v5, v3)
        else
            let v50 : bool = ''' = v4
            if v50 then
                let v52 : bool = v1 = ""
                if v52 then
                    let v53 : US8 = US8_0
                    let v54 : US7 = US7_1(v53)
                    method39(v0, v1, v5, v54)
                else
                    match v3 with
                    | US7_2 -> (* Arguments *)
                        let v82 : string = $"{v0}{v4}"
                        let v83 : US7 = US7_2
                        method39(v82, v1, v5, v83)
                    | US7_1(v57) -> (* Path *)
                        match v57 with
                        | US8_0 -> (* Quoted *)
                            let v58 : US8 = US8_1
                            let v59 : US7 = US7_1(v58)
                            method39(v0, v1, v5, v59)
                        | _ ->
                            let v62 : bool = ' ' = v4
                            if v62 then
                                let v63 : US7 = US7_2
                                method39(v0, v1, v5, v63)
                            else
                                let v66 : string = $"{v1}{v4}"
                                method39(v0, v66, v5, v3)
                    | US7_0 -> (* Start *)
                        let v73 : bool = ' ' = v4
                        if v73 then
                            let v74 : US7 = US7_2
                            method39(v0, v1, v5, v74)
                        else
                            let v77 : string = $"{v1}{v4}"
                            method39(v0, v77, v5, v3)
            else
                match v3 with
                | US7_2 -> (* Arguments *)
                    let v126 : string = $"{v0}{v4}"
                    let v127 : US7 = US7_2
                    method39(v126, v1, v5, v127)
                | US7_1(v94) -> (* Path *)
                    match v94 with
                    | US8_0 -> (* Quoted *)
                        let v95 : bool = ' ' = v4
                        if v95 then
                            let v96 : string = $"{v1} "
                            let v97 : US8 = US8_0
                            let v98 : US7 = US7_1(v97)
                            method39(v0, v96, v5, v98)
                        else
                            let v101 : string = $"{v1}{v4}"
                            method39(v0, v101, v5, v3)
                    | _ ->
                        let v106 : bool = ' ' = v4
                        if v106 then
                            let v107 : US7 = US7_2
                            method39(v0, v1, v5, v107)
                        else
                            let v110 : string = $"{v1}{v4}"
                            method39(v0, v110, v5, v3)
                | US7_0 -> (* Start *)
                    let v117 : bool = ' ' = v4
                    if v117 then
                        let v118 : US7 = US7_2
                        method39(v0, v1, v5, v118)
                    else
                        let v121 : string = $"{v1}{v4}"
                        method39(v0, v121, v5, v3)
    | _ ->
        match v3 with
        | US7_2 -> (* Arguments *)
            let v152 : string = "\\"
            let v153 : string = "/"
            let v154 : string = v1.Replace (v152, v153)
            struct (v154, v0)
        | US7_1(v140) -> (* Path *)
            match v140 with
            | US8_0 -> (* Quoted *)
                let v141 : string = "\\"
                let v142 : string = "/"
                let v143 : string = v1.Replace (v141, v142)
                struct (v143, v0)
            | _ ->
                let v144 : string = "\\"
                let v145 : string = "/"
                let v146 : string = v1.Replace (v144, v145)
                struct (v146, v0)
        | US7_0 -> (* Start *)
            let v149 : string = "\\"
            let v150 : string = "/"
            let v151 : string = v1.Replace (v149, v150)
            struct (v151, v0)
and method43 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = method43(v3, v1)
        UH1_1(v2, v4)
    | UH1_0 -> (* Nil *)
        v1
and method42 (v0 : string, v1 : UH1, v2 : UH0, v3 : US9) : struct (UH1 * string) =
    match v3 with
    | US9_2(v51, v52) -> (* Escaped *)
        match v2 with
        | UH0_1(v53, v54) -> (* Cons *)
            let v55 : bool = '\\' = v53
            if v55 then
                let v56 : US9 = US9_1(v53)
                method41(v0, v1, v54, v3, v56)
            else
                let v59 : bool = '`' = v53
                if v59 then
                    let v60 : US9 = US9_1(v53)
                    method41(v0, v1, v54, v3, v60)
                else
                    let v63 : bool = 0uy = v51
                    if v63 then
                        let v64 : bool = '\\' = v52
                        if v64 then
                            let v65 : bool = '"' = v53
                            if v65 then
                                let v66 : string = $"{v0}{v52}\""
                                let v67 : US9 = US9_2(v51, v52)
                                method41(v66, v1, v54, v3, v67)
                            else
                                let v70 : bool = ' ' = v53
                                if v70 then
                                    let v71 : string = $"{v0} "
                                    method42(v71, v1, v54, v3)
                                else
                                    let v74 : bool = 1uy = v51
                                    if v74 then
                                        let v75 : bool = v3 <> v3
                                        if v75 then
                                            let v76 : string = $"{v0}\{v53}"
                                            method42(v76, v1, v54, v3)
                                        else
                                            let v79 : string = $"{v0}{v53}"
                                            method42(v79, v1, v54, v3)
                                    else
                                        let v84 : string = $"{v0}{v53}"
                                        method42(v84, v1, v54, v3)
                        else
                            let v93 : bool = '`' = v52
                            if v93 then
                                let v94 : bool = '"' = v53
                                if v94 then
                                    let v95 : string = $"{v0}{v52}\""
                                    let v96 : US9 = US9_2(v51, v52)
                                    method41(v95, v1, v54, v3, v96)
                                else
                                    let v99 : bool = ' ' = v53
                                    if v99 then
                                        let v100 : string = $"{v0} "
                                        method42(v100, v1, v54, v3)
                                    else
                                        let v103 : bool = 1uy = v51
                                        if v103 then
                                            let v104 : bool = v3 <> v3
                                            if v104 then
                                                let v105 : string = $"{v0}\{v53}"
                                                method42(v105, v1, v54, v3)
                                            else
                                                let v108 : string = $"{v0}{v53}"
                                                method42(v108, v1, v54, v3)
                                        else
                                            let v113 : string = $"{v0}{v53}"
                                            method42(v113, v1, v54, v3)
                            else
                                let v122 : bool = '"' = v53
                                if v122 then
                                    let v123 : string = $"{v0}{v52}\""
                                    let v124 : US9 = US9_2(v51, v52)
                                    method41(v123, v1, v54, v3, v124)
                                else
                                    let v127 : bool = ' ' = v53
                                    if v127 then
                                        let v128 : string = $"{v0} "
                                        method42(v128, v1, v54, v3)
                                    else
                                        let v131 : bool = 1uy = v51
                                        if v131 then
                                            let v132 : bool = v3 <> v3
                                            if v132 then
                                                let v133 : string = $"{v0}\{v53}"
                                                method42(v133, v1, v54, v3)
                                            else
                                                let v136 : string = $"{v0}{v53}"
                                                method42(v136, v1, v54, v3)
                                        else
                                            let v141 : string = $"{v0}{v53}"
                                            method42(v141, v1, v54, v3)
                    else
                        let v154 : bool = '"' = v53
                        if v154 then
                            let v155 : string = $"{v0}{v52}\""
                            let v156 : US9 = US9_2(v51, v52)
                            method41(v155, v1, v54, v3, v156)
                        else
                            let v159 : bool = ' ' = v53
                            if v159 then
                                let v160 : string = $"{v0} "
                                method42(v160, v1, v54, v3)
                            else
                                let v163 : bool = 1uy = v51
                                if v163 then
                                    let v164 : bool = v3 <> v3
                                    if v164 then
                                        let v165 : string = $"{v0}\{v53}"
                                        method42(v165, v1, v54, v3)
                                    else
                                        let v168 : string = $"{v0}{v53}"
                                        method42(v168, v1, v54, v3)
                                else
                                    let v173 : string = $"{v0}{v53}"
                                    method42(v173, v1, v54, v3)
        | _ ->
            let v188 : bool = 0uy = v51
            if v188 then
                let v189 : bool = '\\' = v52
                if v189 then
                    let v190 : bool = 1uy = v51
                    if v190 then
                        let v192 : bool = v0 = ""
                        let v196 : UH1 =
                            if v192 then
                                v1
                            else
                                let v193 : UH1 = UH1_0
                                let v194 : UH1 = UH1_1(v0, v193)
                                method43(v1, v194)
                        struct (v196, v0)
                    else
                        let v198 : bool = v0 = ""
                        let v202 : UH1 =
                            if v198 then
                                v1
                            else
                                let v199 : UH1 = UH1_0
                                let v200 : UH1 = UH1_1(v0, v199)
                                method43(v1, v200)
                        struct (v202, v0)
                else
                    let v205 : bool = '`' = v52
                    if v205 then
                        let v206 : bool = 1uy = v51
                        if v206 then
                            let v208 : bool = v0 = ""
                            let v212 : UH1 =
                                if v208 then
                                    v1
                                else
                                    let v209 : UH1 = UH1_0
                                    let v210 : UH1 = UH1_1(v0, v209)
                                    method43(v1, v210)
                            struct (v212, v0)
                        else
                            let v214 : bool = v0 = ""
                            let v218 : UH1 =
                                if v214 then
                                    v1
                                else
                                    let v215 : UH1 = UH1_0
                                    let v216 : UH1 = UH1_1(v0, v215)
                                    method43(v1, v216)
                            struct (v218, v0)
                    else
                        let v221 : bool = 1uy = v51
                        if v221 then
                            let v223 : bool = v0 = ""
                            let v227 : UH1 =
                                if v223 then
                                    v1
                                else
                                    let v224 : UH1 = UH1_0
                                    let v225 : UH1 = UH1_1(v0, v224)
                                    method43(v1, v225)
                            struct (v227, v0)
                        else
                            let v229 : bool = v0 = ""
                            let v233 : UH1 =
                                if v229 then
                                    v1
                                else
                                    let v230 : UH1 = UH1_0
                                    let v231 : UH1 = UH1_1(v0, v230)
                                    method43(v1, v231)
                            struct (v233, v0)
            else
                let v240 : bool = 1uy = v51
                if v240 then
                    let v242 : bool = v0 = ""
                    let v246 : UH1 =
                        if v242 then
                            v1
                        else
                            let v243 : UH1 = UH1_0
                            let v244 : UH1 = UH1_1(v0, v243)
                            method43(v1, v244)
                    struct (v246, v0)
                else
                    let v248 : bool = v0 = ""
                    let v252 : UH1 =
                        if v248 then
                            v1
                        else
                            let v249 : UH1 = UH1_0
                            let v250 : UH1 = UH1_1(v0, v249)
                            method43(v1, v250)
                    struct (v252, v0)
    | US9_1(v259) -> (* Quoted *)
        let v260 : bool = '"' = v259
        if v260 then
            match v2 with
            | UH0_1(v261, v262) -> (* Cons *)
                let v263 : bool = '"' = v261
                if v263 then
                    let v264 : US9 = US9_0
                    method41(v0, v1, v262, v3, v264)
                else
                    let v267 : bool = '\\' = v259
                    if v267 then
                        let v268 : bool = '\\' = v261
                        if v268 then
                            let v269 : uint8 = 0uy
                            let v270 : US9 = US9_2(v269, v261)
                            method41(v0, v1, v262, v3, v270)
                        else
                            let v273 : bool = '`' = v261
                            if v273 then
                                let v274 : uint8 = 0uy
                                let v275 : US9 = US9_2(v274, v261)
                                method41(v0, v1, v262, v3, v275)
                            else
                                let v278 : bool = ' ' = v261
                                if v278 then
                                    let v279 : string = $"{v0} "
                                    method42(v279, v1, v262, v3)
                                else
                                    let v282 : string = $"{v0}{v261}"
                                    method42(v282, v1, v262, v3)
                    else
                        let v291 : bool = '`' = v259
                        if v291 then
                            let v292 : bool = '\\' = v261
                            if v292 then
                                let v293 : uint8 = 0uy
                                let v294 : US9 = US9_2(v293, v261)
                                method41(v0, v1, v262, v3, v294)
                            else
                                let v297 : bool = '`' = v261
                                if v297 then
                                    let v298 : uint8 = 0uy
                                    let v299 : US9 = US9_2(v298, v261)
                                    method41(v0, v1, v262, v3, v299)
                                else
                                    let v302 : bool = ' ' = v261
                                    if v302 then
                                        let v303 : string = $"{v0} "
                                        method42(v303, v1, v262, v3)
                                    else
                                        let v306 : string = $"{v0}{v261}"
                                        method42(v306, v1, v262, v3)
                        else
                            let v315 : bool = '\\' = v261
                            if v315 then
                                let v316 : uint8 = 0uy
                                let v317 : US9 = US9_2(v316, v261)
                                method41(v0, v1, v262, v3, v317)
                            else
                                let v320 : bool = '`' = v261
                                if v320 then
                                    let v321 : uint8 = 0uy
                                    let v322 : US9 = US9_2(v321, v261)
                                    method41(v0, v1, v262, v3, v322)
                                else
                                    let v325 : bool = ' ' = v261
                                    if v325 then
                                        let v326 : string = $"{v0} "
                                        method42(v326, v1, v262, v3)
                                    else
                                        let v329 : string = $"{v0}{v261}"
                                        method42(v329, v1, v262, v3)
            | _ ->
                let v344 : bool = '\\' = v259
                if v344 then
                    let v346 : bool = v0 = ""
                    let v350 : UH1 =
                        if v346 then
                            v1
                        else
                            let v347 : UH1 = UH1_0
                            let v348 : UH1 = UH1_1(v0, v347)
                            method43(v1, v348)
                    struct (v350, v0)
                else
                    let v351 : bool = '`' = v259
                    if v351 then
                        let v353 : bool = v0 = ""
                        let v357 : UH1 =
                            if v353 then
                                v1
                            else
                                let v354 : UH1 = UH1_0
                                let v355 : UH1 = UH1_1(v0, v354)
                                method43(v1, v355)
                        struct (v357, v0)
                    else
                        let v359 : bool = v0 = ""
                        let v363 : UH1 =
                            if v359 then
                                v1
                            else
                                let v360 : UH1 = UH1_0
                                let v361 : UH1 = UH1_1(v0, v360)
                                method43(v1, v361)
                        struct (v363, v0)
        else
            let v370 : bool = '\\' = v259
            if v370 then
                match v2 with
                | UH0_1(v371, v372) -> (* Cons *)
                    let v373 : bool = '"' = v371
                    if v373 then
                        let v374 : US9 = US9_2(0uy, '\\')
                        let v375 : bool = v3 <> v374
                        let v378 : bool =
                            if v375 then
                                let v376 : US9 = US9_2(0uy, '`')
                                let v377 : bool = v3 <> v376
                                v377
                            else
                                false
                        if v378 then
                            let v379 : string = $"{v0}{v259}\""
                            let v380 : char = '"'
                            let v381 : US9 = US9_1(v380)
                            method41(v379, v1, v372, v3, v381)
                        else
                            let v384 : string = $"{v0}{v259}\""
                            let v385 : char = '"'
                            let v386 : US9 = US9_1(v385)
                            method41(v384, v1, v372, v3, v386)
                    else
                        let v391 : bool = '\\' = v371
                        if v391 then
                            let v392 : uint8 = 0uy
                            let v393 : US9 = US9_2(v392, v371)
                            method41(v0, v1, v372, v3, v393)
                        else
                            let v396 : bool = '`' = v371
                            if v396 then
                                let v397 : uint8 = 0uy
                                let v398 : US9 = US9_2(v397, v371)
                                method41(v0, v1, v372, v3, v398)
                            else
                                let v401 : bool = ' ' = v371
                                if v401 then
                                    let v402 : string = $"{v0} "
                                    method42(v402, v1, v372, v3)
                                else
                                    let v405 : string = $"{v0}{v371}"
                                    method42(v405, v1, v372, v3)
                | _ ->
                    let v417 : bool = v0 = ""
                    let v421 : UH1 =
                        if v417 then
                            v1
                        else
                            let v418 : UH1 = UH1_0
                            let v419 : UH1 = UH1_1(v0, v418)
                            method43(v1, v419)
                    struct (v421, v0)
            else
                let v424 : bool = '`' = v259
                if v424 then
                    match v2 with
                    | UH0_1(v425, v426) -> (* Cons *)
                        let v427 : bool = '"' = v425
                        if v427 then
                            let v428 : US9 = US9_2(0uy, '\\')
                            let v429 : bool = v3 <> v428
                            let v432 : bool =
                                if v429 then
                                    let v430 : US9 = US9_2(0uy, '`')
                                    let v431 : bool = v3 <> v430
                                    v431
                                else
                                    false
                            if v432 then
                                let v433 : string = $"{v0}{v259}\""
                                let v434 : char = '"'
                                let v435 : US9 = US9_1(v434)
                                method41(v433, v1, v426, v3, v435)
                            else
                                let v438 : string = $"{v0}{v259}\""
                                let v439 : char = '"'
                                let v440 : US9 = US9_1(v439)
                                method41(v438, v1, v426, v3, v440)
                        else
                            let v445 : bool = '\\' = v425
                            if v445 then
                                let v446 : uint8 = 0uy
                                let v447 : US9 = US9_2(v446, v425)
                                method41(v0, v1, v426, v3, v447)
                            else
                                let v450 : bool = '`' = v425
                                if v450 then
                                    let v451 : uint8 = 0uy
                                    let v452 : US9 = US9_2(v451, v425)
                                    method41(v0, v1, v426, v3, v452)
                                else
                                    let v455 : bool = ' ' = v425
                                    if v455 then
                                        let v456 : string = $"{v0} "
                                        method42(v456, v1, v426, v3)
                                    else
                                        let v459 : string = $"{v0}{v425}"
                                        method42(v459, v1, v426, v3)
                    | _ ->
                        let v471 : bool = v0 = ""
                        let v475 : UH1 =
                            if v471 then
                                v1
                            else
                                let v472 : UH1 = UH1_0
                                let v473 : UH1 = UH1_1(v0, v472)
                                method43(v1, v473)
                        struct (v475, v0)
                else
                    match v2 with
                    | UH0_1(v478, v479) -> (* Cons *)
                        let v480 : bool = '\\' = v478
                        if v480 then
                            let v481 : uint8 = 0uy
                            let v482 : US9 = US9_2(v481, v478)
                            method41(v0, v1, v479, v3, v482)
                        else
                            let v485 : bool = '`' = v478
                            if v485 then
                                let v486 : uint8 = 0uy
                                let v487 : US9 = US9_2(v486, v478)
                                method41(v0, v1, v479, v3, v487)
                            else
                                let v490 : bool = '"' = v478
                                if v490 then
                                    let v491 : UH1 = UH1_0
                                    let v492 : UH1 = UH1_1(v0, v491)
                                    let v493 : UH1 = method43(v1, v492)
                                    let v494 : string = ""
                                    let v495 : US9 = US9_0
                                    method41(v494, v493, v479, v3, v495)
                                else
                                    let v498 : bool = ' ' = v478
                                    if v498 then
                                        let v499 : string = $"{v0} "
                                        method42(v499, v1, v479, v3)
                                    else
                                        let v502 : string = $"{v0}{v478}"
                                        method42(v502, v1, v479, v3)
                    | _ ->
                        let v514 : bool = v0 = ""
                        let v518 : UH1 =
                            if v514 then
                                v1
                            else
                                let v515 : UH1 = UH1_0
                                let v516 : UH1 = UH1_1(v0, v515)
                                method43(v1, v516)
                        struct (v518, v0)
    | US9_0 -> (* Start *)
        match v2 with
        | UH0_1(v4, v5) -> (* Cons *)
            let v6 : bool = '"' = v4
            if v6 then
                let v7 : string = ""
                let v8 : char = '"'
                let v9 : US9 = US9_1(v8)
                method41(v7, v1, v5, v3, v9)
            else
                let v12 : bool = '\\' = v4
                if v12 then
                    let v13 : uint8 = 0uy
                    let v14 : US9 = US9_2(v13, v4)
                    method41(v0, v1, v5, v3, v14)
                else
                    let v17 : bool = '`' = v4
                    if v17 then
                        let v18 : uint8 = 0uy
                        let v19 : US9 = US9_2(v18, v4)
                        method41(v0, v1, v5, v3, v19)
                    else
                        let v22 : bool = ' ' = v4
                        if v22 then
                            let v24 : bool = v0 = ""
                            let v28 : UH1 =
                                if v24 then
                                    v1
                                else
                                    let v25 : UH1 = UH1_0
                                    let v26 : UH1 = UH1_1(v0, v25)
                                    method43(v1, v26)
                            let v29 : string = ""
                            method42(v29, v28, v5, v3)
                        else
                            let v32 : string = $"{v0}{v4}"
                            method42(v32, v1, v5, v3)
        | _ ->
            let v44 : bool = v0 = ""
            let v48 : UH1 =
                if v44 then
                    v1
                else
                    let v45 : UH1 = UH1_0
                    let v46 : UH1 = UH1_1(v0, v45)
                    method43(v1, v46)
            struct (v48, v0)
and method41 (v0 : string, v1 : UH1, v2 : UH0, v3 : US9, v4 : US9) : struct (UH1 * string) =
    match v4 with
    | US9_2(v52, v53) -> (* Escaped *)
        match v2 with
        | UH0_1(v54, v55) -> (* Cons *)
            let v56 : bool = '\\' = v54
            if v56 then
                let v57 : US9 = US9_1(v54)
                method41(v0, v1, v55, v4, v57)
            else
                let v60 : bool = '`' = v54
                if v60 then
                    let v61 : US9 = US9_1(v54)
                    method41(v0, v1, v55, v4, v61)
                else
                    match v3 with
                    | US9_0 -> (* Start *)
                        let v64 : bool = '"' = v54
                        if v64 then
                            method42(v0, v1, v55, v4)
                        else
                            let v67 : bool = 0uy = v52
                            if v67 then
                                let v68 : bool = '\\' = v53
                                if v68 then
                                    let v69 : bool = ' ' = v54
                                    if v69 then
                                        let v70 : string = $"{v0} "
                                        method42(v70, v1, v55, v4)
                                    else
                                        let v73 : bool = 1uy = v52
                                        if v73 then
                                            let v74 : bool = v3 <> v4
                                            if v74 then
                                                let v75 : string = $"{v0}\{v54}"
                                                method41(v75, v1, v55, v4, v3)
                                            else
                                                let v78 : string = $"{v0}{v54}"
                                                method42(v78, v1, v55, v4)
                                        else
                                            let v83 : string = $"{v0}{v54}"
                                            method42(v83, v1, v55, v4)
                                else
                                    let v90 : bool = '`' = v53
                                    if v90 then
                                        let v91 : bool = ' ' = v54
                                        if v91 then
                                            let v92 : string = $"{v0} "
                                            method42(v92, v1, v55, v4)
                                        else
                                            let v95 : bool = 1uy = v52
                                            if v95 then
                                                let v96 : bool = v3 <> v4
                                                if v96 then
                                                    let v97 : string = $"{v0}\{v54}"
                                                    method41(v97, v1, v55, v4, v3)
                                                else
                                                    let v100 : string = $"{v0}{v54}"
                                                    method42(v100, v1, v55, v4)
                                            else
                                                let v105 : string = $"{v0}{v54}"
                                                method42(v105, v1, v55, v4)
                                    else
                                        let v112 : bool = ' ' = v54
                                        if v112 then
                                            let v113 : string = $"{v0} "
                                            method42(v113, v1, v55, v4)
                                        else
                                            let v116 : bool = 1uy = v52
                                            if v116 then
                                                let v117 : bool = v3 <> v4
                                                if v117 then
                                                    let v118 : string = $"{v0}\{v54}"
                                                    method41(v118, v1, v55, v4, v3)
                                                else
                                                    let v121 : string = $"{v0}{v54}"
                                                    method42(v121, v1, v55, v4)
                                            else
                                                let v126 : string = $"{v0}{v54}"
                                                method42(v126, v1, v55, v4)
                            else
                                let v137 : bool = ' ' = v54
                                if v137 then
                                    let v138 : string = $"{v0} "
                                    method42(v138, v1, v55, v4)
                                else
                                    let v141 : bool = 1uy = v52
                                    if v141 then
                                        let v142 : bool = v3 <> v4
                                        if v142 then
                                            let v143 : string = $"{v0}\{v54}"
                                            method41(v143, v1, v55, v4, v3)
                                        else
                                            let v146 : string = $"{v0}{v54}"
                                            method42(v146, v1, v55, v4)
                                    else
                                        let v151 : string = $"{v0}{v54}"
                                        method42(v151, v1, v55, v4)
                    | _ ->
                        let v162 : bool = 0uy = v52
                        if v162 then
                            let v163 : bool = '\\' = v53
                            if v163 then
                                match v3 with
                                | US9_1(v164) -> (* Quoted *)
                                    let v165 : bool = '"' = v164
                                    if v165 then
                                        let v166 : string = $"{v0}{v53}{v54}"
                                        let v167 : char = '"'
                                        let v168 : US9 = US9_1(v167)
                                        method41(v166, v1, v55, v4, v168)
                                    else
                                        let v171 : bool = '"' = v54
                                        if v171 then
                                            let v172 : string = $"{v0}{v53}\""
                                            let v173 : US9 = US9_2(v52, v53)
                                            method41(v172, v1, v55, v4, v173)
                                        else
                                            let v176 : bool = ' ' = v54
                                            if v176 then
                                                let v177 : string = $"{v0} "
                                                method42(v177, v1, v55, v4)
                                            else
                                                let v180 : bool = 1uy = v52
                                                if v180 then
                                                    let v181 : bool = v3 <> v4
                                                    if v181 then
                                                        let v182 : string = $"{v0}\{v54}"
                                                        method41(v182, v1, v55, v4, v3)
                                                    else
                                                        let v185 : string = $"{v0}{v54}"
                                                        method42(v185, v1, v55, v4)
                                                else
                                                    let v190 : string = $"{v0}{v54}"
                                                    method42(v190, v1, v55, v4)
                                | _ ->
                                    let v201 : bool = '"' = v54
                                    if v201 then
                                        let v202 : string = $"{v0}{v53}\""
                                        let v203 : US9 = US9_2(v52, v53)
                                        method41(v202, v1, v55, v4, v203)
                                    else
                                        let v206 : bool = ' ' = v54
                                        if v206 then
                                            let v207 : string = $"{v0} "
                                            method42(v207, v1, v55, v4)
                                        else
                                            let v210 : bool = 1uy = v52
                                            if v210 then
                                                let v211 : bool = v3 <> v4
                                                if v211 then
                                                    let v212 : string = $"{v0}\{v54}"
                                                    method41(v212, v1, v55, v4, v3)
                                                else
                                                    let v215 : string = $"{v0}{v54}"
                                                    method42(v215, v1, v55, v4)
                                            else
                                                let v220 : string = $"{v0}{v54}"
                                                method42(v220, v1, v55, v4)
                            else
                                let v231 : bool = '`' = v53
                                if v231 then
                                    match v3 with
                                    | US9_1(v232) -> (* Quoted *)
                                        let v233 : bool = '"' = v232
                                        if v233 then
                                            let v234 : string = $"{v0}{v53}{v54}"
                                            let v235 : char = '"'
                                            let v236 : US9 = US9_1(v235)
                                            method41(v234, v1, v55, v4, v236)
                                        else
                                            let v239 : bool = '"' = v54
                                            if v239 then
                                                let v240 : string = $"{v0}{v53}\""
                                                let v241 : US9 = US9_2(v52, v53)
                                                method41(v240, v1, v55, v4, v241)
                                            else
                                                let v244 : bool = ' ' = v54
                                                if v244 then
                                                    let v245 : string = $"{v0} "
                                                    method42(v245, v1, v55, v4)
                                                else
                                                    let v248 : bool = 1uy = v52
                                                    if v248 then
                                                        let v249 : bool = v3 <> v4
                                                        if v249 then
                                                            let v250 : string = $"{v0}\{v54}"
                                                            method41(v250, v1, v55, v4, v3)
                                                        else
                                                            let v253 : string = $"{v0}{v54}"
                                                            method42(v253, v1, v55, v4)
                                                    else
                                                        let v258 : string = $"{v0}{v54}"
                                                        method42(v258, v1, v55, v4)
                                    | _ ->
                                        let v269 : bool = '"' = v54
                                        if v269 then
                                            let v270 : string = $"{v0}{v53}\""
                                            let v271 : US9 = US9_2(v52, v53)
                                            method41(v270, v1, v55, v4, v271)
                                        else
                                            let v274 : bool = ' ' = v54
                                            if v274 then
                                                let v275 : string = $"{v0} "
                                                method42(v275, v1, v55, v4)
                                            else
                                                let v278 : bool = 1uy = v52
                                                if v278 then
                                                    let v279 : bool = v3 <> v4
                                                    if v279 then
                                                        let v280 : string = $"{v0}\{v54}"
                                                        method41(v280, v1, v55, v4, v3)
                                                    else
                                                        let v283 : string = $"{v0}{v54}"
                                                        method42(v283, v1, v55, v4)
                                                else
                                                    let v288 : string = $"{v0}{v54}"
                                                    method42(v288, v1, v55, v4)
                                else
                                    let v299 : bool = '"' = v54
                                    if v299 then
                                        let v300 : string = $"{v0}{v53}\""
                                        let v301 : US9 = US9_2(v52, v53)
                                        method41(v300, v1, v55, v4, v301)
                                    else
                                        let v304 : bool = ' ' = v54
                                        if v304 then
                                            let v305 : string = $"{v0} "
                                            method42(v305, v1, v55, v4)
                                        else
                                            let v308 : bool = 1uy = v52
                                            if v308 then
                                                let v309 : bool = v3 <> v4
                                                if v309 then
                                                    let v310 : string = $"{v0}\{v54}"
                                                    method41(v310, v1, v55, v4, v3)
                                                else
                                                    let v313 : string = $"{v0}{v54}"
                                                    method42(v313, v1, v55, v4)
                                            else
                                                let v318 : string = $"{v0}{v54}"
                                                method42(v318, v1, v55, v4)
                        else
                            let v331 : bool = '"' = v54
                            if v331 then
                                let v332 : string = $"{v0}{v53}\""
                                let v333 : US9 = US9_2(v52, v53)
                                method41(v332, v1, v55, v4, v333)
                            else
                                let v336 : bool = ' ' = v54
                                if v336 then
                                    let v337 : string = $"{v0} "
                                    method42(v337, v1, v55, v4)
                                else
                                    let v340 : bool = 1uy = v52
                                    if v340 then
                                        let v341 : bool = v3 <> v4
                                        if v341 then
                                            let v342 : string = $"{v0}\{v54}"
                                            method41(v342, v1, v55, v4, v3)
                                        else
                                            let v345 : string = $"{v0}{v54}"
                                            method42(v345, v1, v55, v4)
                                    else
                                        let v350 : string = $"{v0}{v54}"
                                        method42(v350, v1, v55, v4)
        | _ ->
            match v3 with
            | US9_0 -> (* Start *)
                let v367 : bool = 0uy = v52
                if v367 then
                    let v368 : bool = '\\' = v53
                    if v368 then
                        let v369 : bool = 1uy = v52
                        if v369 then
                            let v371 : bool = v0 = ""
                            let v375 : UH1 =
                                if v371 then
                                    v1
                                else
                                    let v372 : UH1 = UH1_0
                                    let v373 : UH1 = UH1_1(v0, v372)
                                    method43(v1, v373)
                            struct (v375, v0)
                        else
                            let v377 : bool = v0 = ""
                            let v381 : UH1 =
                                if v377 then
                                    v1
                                else
                                    let v378 : UH1 = UH1_0
                                    let v379 : UH1 = UH1_1(v0, v378)
                                    method43(v1, v379)
                            struct (v381, v0)
                    else
                        let v384 : bool = '`' = v53
                        if v384 then
                            let v385 : bool = 1uy = v52
                            if v385 then
                                let v387 : bool = v0 = ""
                                let v391 : UH1 =
                                    if v387 then
                                        v1
                                    else
                                        let v388 : UH1 = UH1_0
                                        let v389 : UH1 = UH1_1(v0, v388)
                                        method43(v1, v389)
                                struct (v391, v0)
                            else
                                let v393 : bool = v0 = ""
                                let v397 : UH1 =
                                    if v393 then
                                        v1
                                    else
                                        let v394 : UH1 = UH1_0
                                        let v395 : UH1 = UH1_1(v0, v394)
                                        method43(v1, v395)
                                struct (v397, v0)
                        else
                            let v400 : bool = 1uy = v52
                            if v400 then
                                let v402 : bool = v0 = ""
                                let v406 : UH1 =
                                    if v402 then
                                        v1
                                    else
                                        let v403 : UH1 = UH1_0
                                        let v404 : UH1 = UH1_1(v0, v403)
                                        method43(v1, v404)
                                struct (v406, v0)
                            else
                                let v408 : bool = v0 = ""
                                let v412 : UH1 =
                                    if v408 then
                                        v1
                                    else
                                        let v409 : UH1 = UH1_0
                                        let v410 : UH1 = UH1_1(v0, v409)
                                        method43(v1, v410)
                                struct (v412, v0)
                else
                    let v419 : bool = 1uy = v52
                    if v419 then
                        let v421 : bool = v0 = ""
                        let v425 : UH1 =
                            if v421 then
                                v1
                            else
                                let v422 : UH1 = UH1_0
                                let v423 : UH1 = UH1_1(v0, v422)
                                method43(v1, v423)
                        struct (v425, v0)
                    else
                        let v427 : bool = v0 = ""
                        let v431 : UH1 =
                            if v427 then
                                v1
                            else
                                let v428 : UH1 = UH1_0
                                let v429 : UH1 = UH1_1(v0, v428)
                                method43(v1, v429)
                        struct (v431, v0)
            | _ ->
                let v436 : bool = 0uy = v52
                if v436 then
                    let v437 : bool = '\\' = v53
                    if v437 then
                        match v3 with
                        | US9_1(v438) -> (* Quoted *)
                            let v439 : bool = '"' = v438
                            if v439 then
                                let v440 : bool = 1uy = v52
                                if v440 then
                                    let v442 : bool = v0 = ""
                                    let v446 : UH1 =
                                        if v442 then
                                            v1
                                        else
                                            let v443 : UH1 = UH1_0
                                            let v444 : UH1 = UH1_1(v0, v443)
                                            method43(v1, v444)
                                    struct (v446, v0)
                                else
                                    let v448 : bool = v0 = ""
                                    let v452 : UH1 =
                                        if v448 then
                                            v1
                                        else
                                            let v449 : UH1 = UH1_0
                                            let v450 : UH1 = UH1_1(v0, v449)
                                            method43(v1, v450)
                                    struct (v452, v0)
                            else
                                let v455 : bool = 1uy = v52
                                if v455 then
                                    let v457 : bool = v0 = ""
                                    let v461 : UH1 =
                                        if v457 then
                                            v1
                                        else
                                            let v458 : UH1 = UH1_0
                                            let v459 : UH1 = UH1_1(v0, v458)
                                            method43(v1, v459)
                                    struct (v461, v0)
                                else
                                    let v463 : bool = v0 = ""
                                    let v467 : UH1 =
                                        if v463 then
                                            v1
                                        else
                                            let v464 : UH1 = UH1_0
                                            let v465 : UH1 = UH1_1(v0, v464)
                                            method43(v1, v465)
                                    struct (v467, v0)
                        | _ ->
                            let v472 : bool = 1uy = v52
                            if v472 then
                                let v474 : bool = v0 = ""
                                let v478 : UH1 =
                                    if v474 then
                                        v1
                                    else
                                        let v475 : UH1 = UH1_0
                                        let v476 : UH1 = UH1_1(v0, v475)
                                        method43(v1, v476)
                                struct (v478, v0)
                            else
                                let v480 : bool = v0 = ""
                                let v484 : UH1 =
                                    if v480 then
                                        v1
                                    else
                                        let v481 : UH1 = UH1_0
                                        let v482 : UH1 = UH1_1(v0, v481)
                                        method43(v1, v482)
                                struct (v484, v0)
                    else
                        let v489 : bool = '`' = v53
                        if v489 then
                            match v3 with
                            | US9_1(v490) -> (* Quoted *)
                                let v491 : bool = '"' = v490
                                if v491 then
                                    let v492 : bool = 1uy = v52
                                    if v492 then
                                        let v494 : bool = v0 = ""
                                        let v498 : UH1 =
                                            if v494 then
                                                v1
                                            else
                                                let v495 : UH1 = UH1_0
                                                let v496 : UH1 = UH1_1(v0, v495)
                                                method43(v1, v496)
                                        struct (v498, v0)
                                    else
                                        let v500 : bool = v0 = ""
                                        let v504 : UH1 =
                                            if v500 then
                                                v1
                                            else
                                                let v501 : UH1 = UH1_0
                                                let v502 : UH1 = UH1_1(v0, v501)
                                                method43(v1, v502)
                                        struct (v504, v0)
                                else
                                    let v507 : bool = 1uy = v52
                                    if v507 then
                                        let v509 : bool = v0 = ""
                                        let v513 : UH1 =
                                            if v509 then
                                                v1
                                            else
                                                let v510 : UH1 = UH1_0
                                                let v511 : UH1 = UH1_1(v0, v510)
                                                method43(v1, v511)
                                        struct (v513, v0)
                                    else
                                        let v515 : bool = v0 = ""
                                        let v519 : UH1 =
                                            if v515 then
                                                v1
                                            else
                                                let v516 : UH1 = UH1_0
                                                let v517 : UH1 = UH1_1(v0, v516)
                                                method43(v1, v517)
                                        struct (v519, v0)
                            | _ ->
                                let v524 : bool = 1uy = v52
                                if v524 then
                                    let v526 : bool = v0 = ""
                                    let v530 : UH1 =
                                        if v526 then
                                            v1
                                        else
                                            let v527 : UH1 = UH1_0
                                            let v528 : UH1 = UH1_1(v0, v527)
                                            method43(v1, v528)
                                    struct (v530, v0)
                                else
                                    let v532 : bool = v0 = ""
                                    let v536 : UH1 =
                                        if v532 then
                                            v1
                                        else
                                            let v533 : UH1 = UH1_0
                                            let v534 : UH1 = UH1_1(v0, v533)
                                            method43(v1, v534)
                                    struct (v536, v0)
                        else
                            let v541 : bool = 1uy = v52
                            if v541 then
                                let v543 : bool = v0 = ""
                                let v547 : UH1 =
                                    if v543 then
                                        v1
                                    else
                                        let v544 : UH1 = UH1_0
                                        let v545 : UH1 = UH1_1(v0, v544)
                                        method43(v1, v545)
                                struct (v547, v0)
                            else
                                let v549 : bool = v0 = ""
                                let v553 : UH1 =
                                    if v549 then
                                        v1
                                    else
                                        let v550 : UH1 = UH1_0
                                        let v551 : UH1 = UH1_1(v0, v550)
                                        method43(v1, v551)
                                struct (v553, v0)
                else
                    let v560 : bool = 1uy = v52
                    if v560 then
                        let v562 : bool = v0 = ""
                        let v566 : UH1 =
                            if v562 then
                                v1
                            else
                                let v563 : UH1 = UH1_0
                                let v564 : UH1 = UH1_1(v0, v563)
                                method43(v1, v564)
                        struct (v566, v0)
                    else
                        let v568 : bool = v0 = ""
                        let v572 : UH1 =
                            if v568 then
                                v1
                            else
                                let v569 : UH1 = UH1_0
                                let v570 : UH1 = UH1_1(v0, v569)
                                method43(v1, v570)
                        struct (v572, v0)
    | US9_1(v581) -> (* Quoted *)
        let v582 : bool = '"' = v581
        if v582 then
            match v3 with
            | US9_1(v583) -> (* Quoted *)
                match v2 with
                | UH0_1(v584, v585) -> (* Cons *)
                    let v586 : bool = '"' = v584
                    if v586 then
                        let v587 : US9 = US9_0
                        method41(v0, v1, v585, v4, v587)
                    else
                        let v590 : bool = '\\' = v581
                        if v590 then
                            let v591 : bool = '\\' = v584
                            if v591 then
                                let v592 : uint8 = 0uy
                                let v593 : US9 = US9_2(v592, v584)
                                method41(v0, v1, v585, v4, v593)
                            else
                                let v596 : bool = '`' = v584
                                if v596 then
                                    let v597 : uint8 = 0uy
                                    let v598 : US9 = US9_2(v597, v584)
                                    method41(v0, v1, v585, v4, v598)
                                else
                                    let v601 : bool = ' ' = v584
                                    if v601 then
                                        let v602 : string = $"{v0} "
                                        method42(v602, v1, v585, v4)
                                    else
                                        let v605 : string = $"{v0}{v584}"
                                        method42(v605, v1, v585, v4)
                        else
                            let v614 : bool = '`' = v581
                            if v614 then
                                let v615 : bool = '\\' = v584
                                if v615 then
                                    let v616 : uint8 = 0uy
                                    let v617 : US9 = US9_2(v616, v584)
                                    method41(v0, v1, v585, v4, v617)
                                else
                                    let v620 : bool = '`' = v584
                                    if v620 then
                                        let v621 : uint8 = 0uy
                                        let v622 : US9 = US9_2(v621, v584)
                                        method41(v0, v1, v585, v4, v622)
                                    else
                                        let v625 : bool = ' ' = v584
                                        if v625 then
                                            let v626 : string = $"{v0} "
                                            method42(v626, v1, v585, v4)
                                        else
                                            let v629 : string = $"{v0}{v584}"
                                            method42(v629, v1, v585, v4)
                            else
                                let v638 : bool = '\\' = v584
                                if v638 then
                                    let v639 : uint8 = 0uy
                                    let v640 : US9 = US9_2(v639, v584)
                                    method41(v0, v1, v585, v4, v640)
                                else
                                    let v643 : bool = '`' = v584
                                    if v643 then
                                        let v644 : uint8 = 0uy
                                        let v645 : US9 = US9_2(v644, v584)
                                        method41(v0, v1, v585, v4, v645)
                                    else
                                        let v648 : bool = ' ' = v584
                                        if v648 then
                                            let v649 : string = $"{v0} "
                                            method42(v649, v1, v585, v4)
                                        else
                                            let v652 : string = $"{v0}{v584}"
                                            method42(v652, v1, v585, v4)
                | _ ->
                    let v667 : bool = '\\' = v581
                    if v667 then
                        let v669 : bool = v0 = ""
                        let v673 : UH1 =
                            if v669 then
                                v1
                            else
                                let v670 : UH1 = UH1_0
                                let v671 : UH1 = UH1_1(v0, v670)
                                method43(v1, v671)
                        struct (v673, v0)
                    else
                        let v674 : bool = '`' = v581
                        if v674 then
                            let v676 : bool = v0 = ""
                            let v680 : UH1 =
                                if v676 then
                                    v1
                                else
                                    let v677 : UH1 = UH1_0
                                    let v678 : UH1 = UH1_1(v0, v677)
                                    method43(v1, v678)
                            struct (v680, v0)
                        else
                            let v682 : bool = v0 = ""
                            let v686 : UH1 =
                                if v682 then
                                    v1
                                else
                                    let v683 : UH1 = UH1_0
                                    let v684 : UH1 = UH1_1(v0, v683)
                                    method43(v1, v684)
                            struct (v686, v0)
            | _ ->
                let v693 : bool = '\\' = v581
                if v693 then
                    match v2 with
                    | UH0_1(v694, v695) -> (* Cons *)
                        let v696 : bool = '"' = v694
                        if v696 then
                            let v697 : US9 = US9_2(0uy, '\\')
                            let v698 : bool = v3 <> v697
                            let v701 : bool =
                                if v698 then
                                    let v699 : US9 = US9_2(0uy, '`')
                                    let v700 : bool = v3 <> v699
                                    v700
                                else
                                    false
                            if v701 then
                                let v702 : string = $"{v0}{v581}\""
                                let v703 : char = '"'
                                let v704 : US9 = US9_1(v703)
                                method41(v702, v1, v695, v4, v704)
                            else
                                let v707 : US9 = US9_0
                                method41(v0, v1, v695, v4, v707)
                        else
                            let v712 : bool = '\\' = v694
                            if v712 then
                                let v713 : uint8 = 1uy
                                let v714 : US9 = US9_2(v713, v694)
                                method41(v0, v1, v695, v4, v714)
                            else
                                let v717 : bool = '`' = v694
                                if v717 then
                                    let v718 : uint8 = 1uy
                                    let v719 : US9 = US9_2(v718, v694)
                                    method41(v0, v1, v695, v4, v719)
                                else
                                    match v3 with
                                    | US9_2(v722, v723) -> (* Escaped *)
                                        let v724 : bool = 0uy = v722
                                        if v724 then
                                            let v725 : bool = ' ' = v694
                                            if v725 then
                                                let v726 : string = $"{v0} "
                                                method42(v726, v1, v695, v4)
                                            else
                                                let v729 : string = $"{v0}{v694}"
                                                method42(v729, v1, v695, v4)
                                        else
                                            let v734 : bool = ' ' = v694
                                            if v734 then
                                                let v735 : string = $"{v0} "
                                                method42(v735, v1, v695, v4)
                                            else
                                                let v738 : string = $"{v0}{v694}"
                                                method42(v738, v1, v695, v4)
                                    | _ ->
                                        let v745 : bool = ' ' = v694
                                        if v745 then
                                            let v746 : string = $"{v0} "
                                            method42(v746, v1, v695, v4)
                                        else
                                            let v749 : string = $"{v0}{v694}"
                                            method42(v749, v1, v695, v4)
                    | _ ->
                        match v3 with
                        | US9_2(v762, v763) -> (* Escaped *)
                            let v764 : bool = 0uy = v762
                            if v764 then
                                let v766 : bool = v0 = ""
                                let v770 : UH1 =
                                    if v766 then
                                        v1
                                    else
                                        let v767 : UH1 = UH1_0
                                        let v768 : UH1 = UH1_1(v0, v767)
                                        method43(v1, v768)
                                struct (v770, v0)
                            else
                                let v772 : bool = v0 = ""
                                let v776 : UH1 =
                                    if v772 then
                                        v1
                                    else
                                        let v773 : UH1 = UH1_0
                                        let v774 : UH1 = UH1_1(v0, v773)
                                        method43(v1, v774)
                                struct (v776, v0)
                        | _ ->
                            let v780 : bool = v0 = ""
                            let v784 : UH1 =
                                if v780 then
                                    v1
                                else
                                    let v781 : UH1 = UH1_0
                                    let v782 : UH1 = UH1_1(v0, v781)
                                    method43(v1, v782)
                            struct (v784, v0)
                else
                    let v789 : bool = '`' = v581
                    if v789 then
                        match v2 with
                        | UH0_1(v790, v791) -> (* Cons *)
                            let v792 : bool = '"' = v790
                            if v792 then
                                let v793 : US9 = US9_2(0uy, '\\')
                                let v794 : bool = v3 <> v793
                                let v797 : bool =
                                    if v794 then
                                        let v795 : US9 = US9_2(0uy, '`')
                                        let v796 : bool = v3 <> v795
                                        v796
                                    else
                                        false
                                if v797 then
                                    let v798 : string = $"{v0}{v581}\""
                                    let v799 : char = '"'
                                    let v800 : US9 = US9_1(v799)
                                    method41(v798, v1, v791, v4, v800)
                                else
                                    let v803 : US9 = US9_0
                                    method41(v0, v1, v791, v4, v803)
                            else
                                let v808 : bool = '\\' = v790
                                if v808 then
                                    let v809 : uint8 = 1uy
                                    let v810 : US9 = US9_2(v809, v790)
                                    method41(v0, v1, v791, v4, v810)
                                else
                                    let v813 : bool = '`' = v790
                                    if v813 then
                                        let v814 : uint8 = 1uy
                                        let v815 : US9 = US9_2(v814, v790)
                                        method41(v0, v1, v791, v4, v815)
                                    else
                                        match v3 with
                                        | US9_2(v818, v819) -> (* Escaped *)
                                            let v820 : bool = 0uy = v818
                                            if v820 then
                                                let v821 : bool = ' ' = v790
                                                if v821 then
                                                    let v822 : string = $"{v0} "
                                                    method42(v822, v1, v791, v4)
                                                else
                                                    let v825 : string = $"{v0}{v790}"
                                                    method42(v825, v1, v791, v4)
                                            else
                                                let v830 : bool = ' ' = v790
                                                if v830 then
                                                    let v831 : string = $"{v0} "
                                                    method42(v831, v1, v791, v4)
                                                else
                                                    let v834 : string = $"{v0}{v790}"
                                                    method42(v834, v1, v791, v4)
                                        | _ ->
                                            let v841 : bool = ' ' = v790
                                            if v841 then
                                                let v842 : string = $"{v0} "
                                                method42(v842, v1, v791, v4)
                                            else
                                                let v845 : string = $"{v0}{v790}"
                                                method42(v845, v1, v791, v4)
                        | _ ->
                            match v3 with
                            | US9_2(v858, v859) -> (* Escaped *)
                                let v860 : bool = 0uy = v858
                                if v860 then
                                    let v862 : bool = v0 = ""
                                    let v866 : UH1 =
                                        if v862 then
                                            v1
                                        else
                                            let v863 : UH1 = UH1_0
                                            let v864 : UH1 = UH1_1(v0, v863)
                                            method43(v1, v864)
                                    struct (v866, v0)
                                else
                                    let v868 : bool = v0 = ""
                                    let v872 : UH1 =
                                        if v868 then
                                            v1
                                        else
                                            let v869 : UH1 = UH1_0
                                            let v870 : UH1 = UH1_1(v0, v869)
                                            method43(v1, v870)
                                    struct (v872, v0)
                            | _ ->
                                let v876 : bool = v0 = ""
                                let v880 : UH1 =
                                    if v876 then
                                        v1
                                    else
                                        let v877 : UH1 = UH1_0
                                        let v878 : UH1 = UH1_1(v0, v877)
                                        method43(v1, v878)
                                struct (v880, v0)
                    else
                        match v2 with
                        | UH0_1(v885, v886) -> (* Cons *)
                            let v887 : bool = '\\' = v885
                            if v887 then
                                let v888 : uint8 = 1uy
                                let v889 : US9 = US9_2(v888, v885)
                                method41(v0, v1, v886, v4, v889)
                            else
                                let v892 : bool = '`' = v885
                                if v892 then
                                    let v893 : uint8 = 1uy
                                    let v894 : US9 = US9_2(v893, v885)
                                    method41(v0, v1, v886, v4, v894)
                                else
                                    match v3 with
                                    | US9_2(v897, v898) -> (* Escaped *)
                                        let v899 : bool = 0uy = v897
                                        if v899 then
                                            let v900 : bool = '"' = v885
                                            if v900 then
                                                let v901 : string = $"{v0}"
                                                let v902 : char = '"'
                                                let v903 : US9 = US9_1(v902)
                                                method41(v901, v1, v886, v4, v903)
                                            else
                                                let v906 : bool = ' ' = v885
                                                if v906 then
                                                    let v907 : string = $"{v0} "
                                                    method42(v907, v1, v886, v4)
                                                else
                                                    let v910 : string = $"{v0}{v885}"
                                                    method42(v910, v1, v886, v4)
                                        else
                                            let v917 : bool = '"' = v885
                                            if v917 then
                                                let v918 : UH1 = UH1_0
                                                let v919 : UH1 = UH1_1(v0, v918)
                                                let v920 : UH1 = method43(v1, v919)
                                                let v921 : string = ""
                                                let v922 : US9 = US9_0
                                                method41(v921, v920, v886, v4, v922)
                                            else
                                                let v925 : bool = ' ' = v885
                                                if v925 then
                                                    let v926 : string = $"{v0} "
                                                    method42(v926, v1, v886, v4)
                                                else
                                                    let v929 : string = $"{v0}{v885}"
                                                    method42(v929, v1, v886, v4)
                                    | _ ->
                                        let v938 : bool = '"' = v885
                                        if v938 then
                                            let v939 : UH1 = UH1_0
                                            let v940 : UH1 = UH1_1(v0, v939)
                                            let v941 : UH1 = method43(v1, v940)
                                            let v942 : string = ""
                                            let v943 : US9 = US9_0
                                            method41(v942, v941, v886, v4, v943)
                                        else
                                            let v946 : bool = ' ' = v885
                                            if v946 then
                                                let v947 : string = $"{v0} "
                                                method42(v947, v1, v886, v4)
                                            else
                                                let v950 : string = $"{v0}{v885}"
                                                method42(v950, v1, v886, v4)
                        | _ ->
                            match v3 with
                            | US9_2(v963, v964) -> (* Escaped *)
                                let v965 : bool = 0uy = v963
                                if v965 then
                                    let v967 : bool = v0 = ""
                                    let v971 : UH1 =
                                        if v967 then
                                            v1
                                        else
                                            let v968 : UH1 = UH1_0
                                            let v969 : UH1 = UH1_1(v0, v968)
                                            method43(v1, v969)
                                    struct (v971, v0)
                                else
                                    let v973 : bool = v0 = ""
                                    let v977 : UH1 =
                                        if v973 then
                                            v1
                                        else
                                            let v974 : UH1 = UH1_0
                                            let v975 : UH1 = UH1_1(v0, v974)
                                            method43(v1, v975)
                                    struct (v977, v0)
                            | _ ->
                                let v981 : bool = v0 = ""
                                let v985 : UH1 =
                                    if v981 then
                                        v1
                                    else
                                        let v982 : UH1 = UH1_0
                                        let v983 : UH1 = UH1_1(v0, v982)
                                        method43(v1, v983)
                                struct (v985, v0)
        else
            let v996 : bool = '\\' = v581
            if v996 then
                match v2 with
                | UH0_1(v997, v998) -> (* Cons *)
                    let v999 : bool = '"' = v997
                    if v999 then
                        let v1000 : US9 = US9_2(0uy, '\\')
                        let v1001 : bool = v3 <> v1000
                        let v1004 : bool =
                            if v1001 then
                                let v1002 : US9 = US9_2(0uy, '`')
                                let v1003 : bool = v3 <> v1002
                                v1003
                            else
                                false
                        if v1004 then
                            let v1005 : string = $"{v0}{v581}\""
                            let v1006 : char = '"'
                            let v1007 : US9 = US9_1(v1006)
                            method41(v1005, v1, v998, v4, v1007)
                        else
                            match v3 with
                            | US9_1(v1010) -> (* Quoted *)
                                let v1011 : string = $"{v0}{v581}\""
                                let v1012 : char = '"'
                                let v1013 : US9 = US9_1(v1012)
                                method41(v1011, v1, v998, v4, v1013)
                            | _ ->
                                let v1016 : US9 = US9_0
                                method41(v0, v1, v998, v4, v1016)
                    else
                        match v3 with
                        | US9_1(v1023) -> (* Quoted *)
                            let v1024 : bool = '\\' = v997
                            if v1024 then
                                let v1025 : uint8 = 0uy
                                let v1026 : US9 = US9_2(v1025, v997)
                                method41(v0, v1, v998, v4, v1026)
                            else
                                let v1029 : bool = '`' = v997
                                if v1029 then
                                    let v1030 : uint8 = 0uy
                                    let v1031 : US9 = US9_2(v1030, v997)
                                    method41(v0, v1, v998, v4, v1031)
                                else
                                    let v1034 : bool = ' ' = v997
                                    if v1034 then
                                        let v1035 : string = $"{v0} "
                                        method42(v1035, v1, v998, v4)
                                    else
                                        let v1038 : string = $"{v0}{v997}"
                                        method42(v1038, v1, v998, v4)
                        | _ ->
                            let v1047 : bool = '\\' = v997
                            if v1047 then
                                let v1048 : uint8 = 1uy
                                let v1049 : US9 = US9_2(v1048, v997)
                                method41(v0, v1, v998, v4, v1049)
                            else
                                let v1052 : bool = '`' = v997
                                if v1052 then
                                    let v1053 : uint8 = 1uy
                                    let v1054 : US9 = US9_2(v1053, v997)
                                    method41(v0, v1, v998, v4, v1054)
                                else
                                    match v3 with
                                    | US9_2(v1057, v1058) -> (* Escaped *)
                                        let v1059 : bool = 0uy = v1057
                                        if v1059 then
                                            let v1060 : bool = ' ' = v997
                                            if v1060 then
                                                let v1061 : string = $"{v0} "
                                                method42(v1061, v1, v998, v4)
                                            else
                                                let v1064 : string = $"{v0}{v997}"
                                                method42(v1064, v1, v998, v4)
                                        else
                                            let v1069 : bool = ' ' = v997
                                            if v1069 then
                                                let v1070 : string = $"{v0} "
                                                method42(v1070, v1, v998, v4)
                                            else
                                                let v1073 : string = $"{v0}{v997}"
                                                method42(v1073, v1, v998, v4)
                                    | _ ->
                                        let v1080 : bool = ' ' = v997
                                        if v1080 then
                                            let v1081 : string = $"{v0} "
                                            method42(v1081, v1, v998, v4)
                                        else
                                            let v1084 : string = $"{v0}{v997}"
                                            method42(v1084, v1, v998, v4)
                | _ ->
                    match v3 with
                    | US9_2(v1106, v1107) -> (* Escaped *)
                        let v1108 : bool = 0uy = v1106
                        if v1108 then
                            let v1110 : bool = v0 = ""
                            let v1114 : UH1 =
                                if v1110 then
                                    v1
                                else
                                    let v1111 : UH1 = UH1_0
                                    let v1112 : UH1 = UH1_1(v0, v1111)
                                    method43(v1, v1112)
                            struct (v1114, v0)
                        else
                            let v1116 : bool = v0 = ""
                            let v1120 : UH1 =
                                if v1116 then
                                    v1
                                else
                                    let v1117 : UH1 = UH1_0
                                    let v1118 : UH1 = UH1_1(v0, v1117)
                                    method43(v1, v1118)
                            struct (v1120, v0)
                    | US9_1(v1099) -> (* Quoted *)
                        let v1101 : bool = v0 = ""
                        let v1105 : UH1 =
                            if v1101 then
                                v1
                            else
                                let v1102 : UH1 = UH1_0
                                let v1103 : UH1 = UH1_1(v0, v1102)
                                method43(v1, v1103)
                        struct (v1105, v0)
                    | _ ->
                        let v1124 : bool = v0 = ""
                        let v1128 : UH1 =
                            if v1124 then
                                v1
                            else
                                let v1125 : UH1 = UH1_0
                                let v1126 : UH1 = UH1_1(v0, v1125)
                                method43(v1, v1126)
                        struct (v1128, v0)
            else
                let v1135 : bool = '`' = v581
                if v1135 then
                    match v2 with
                    | UH0_1(v1136, v1137) -> (* Cons *)
                        let v1138 : bool = '"' = v1136
                        if v1138 then
                            let v1139 : US9 = US9_2(0uy, '\\')
                            let v1140 : bool = v3 <> v1139
                            let v1143 : bool =
                                if v1140 then
                                    let v1141 : US9 = US9_2(0uy, '`')
                                    let v1142 : bool = v3 <> v1141
                                    v1142
                                else
                                    false
                            if v1143 then
                                let v1144 : string = $"{v0}{v581}\""
                                let v1145 : char = '"'
                                let v1146 : US9 = US9_1(v1145)
                                method41(v1144, v1, v1137, v4, v1146)
                            else
                                match v3 with
                                | US9_1(v1149) -> (* Quoted *)
                                    let v1150 : string = $"{v0}{v581}\""
                                    let v1151 : char = '"'
                                    let v1152 : US9 = US9_1(v1151)
                                    method41(v1150, v1, v1137, v4, v1152)
                                | _ ->
                                    let v1155 : US9 = US9_0
                                    method41(v0, v1, v1137, v4, v1155)
                        else
                            match v3 with
                            | US9_1(v1162) -> (* Quoted *)
                                let v1163 : bool = '\\' = v1136
                                if v1163 then
                                    let v1164 : uint8 = 0uy
                                    let v1165 : US9 = US9_2(v1164, v1136)
                                    method41(v0, v1, v1137, v4, v1165)
                                else
                                    let v1168 : bool = '`' = v1136
                                    if v1168 then
                                        let v1169 : uint8 = 0uy
                                        let v1170 : US9 = US9_2(v1169, v1136)
                                        method41(v0, v1, v1137, v4, v1170)
                                    else
                                        let v1173 : bool = ' ' = v1136
                                        if v1173 then
                                            let v1174 : string = $"{v0} "
                                            method42(v1174, v1, v1137, v4)
                                        else
                                            let v1177 : string = $"{v0}{v1136}"
                                            method42(v1177, v1, v1137, v4)
                            | _ ->
                                let v1186 : bool = '\\' = v1136
                                if v1186 then
                                    let v1187 : uint8 = 1uy
                                    let v1188 : US9 = US9_2(v1187, v1136)
                                    method41(v0, v1, v1137, v4, v1188)
                                else
                                    let v1191 : bool = '`' = v1136
                                    if v1191 then
                                        let v1192 : uint8 = 1uy
                                        let v1193 : US9 = US9_2(v1192, v1136)
                                        method41(v0, v1, v1137, v4, v1193)
                                    else
                                        match v3 with
                                        | US9_2(v1196, v1197) -> (* Escaped *)
                                            let v1198 : bool = 0uy = v1196
                                            if v1198 then
                                                let v1199 : bool = ' ' = v1136
                                                if v1199 then
                                                    let v1200 : string = $"{v0} "
                                                    method42(v1200, v1, v1137, v4)
                                                else
                                                    let v1203 : string = $"{v0}{v1136}"
                                                    method42(v1203, v1, v1137, v4)
                                            else
                                                let v1208 : bool = ' ' = v1136
                                                if v1208 then
                                                    let v1209 : string = $"{v0} "
                                                    method42(v1209, v1, v1137, v4)
                                                else
                                                    let v1212 : string = $"{v0}{v1136}"
                                                    method42(v1212, v1, v1137, v4)
                                        | _ ->
                                            let v1219 : bool = ' ' = v1136
                                            if v1219 then
                                                let v1220 : string = $"{v0} "
                                                method42(v1220, v1, v1137, v4)
                                            else
                                                let v1223 : string = $"{v0}{v1136}"
                                                method42(v1223, v1, v1137, v4)
                    | _ ->
                        match v3 with
                        | US9_2(v1245, v1246) -> (* Escaped *)
                            let v1247 : bool = 0uy = v1245
                            if v1247 then
                                let v1249 : bool = v0 = ""
                                let v1253 : UH1 =
                                    if v1249 then
                                        v1
                                    else
                                        let v1250 : UH1 = UH1_0
                                        let v1251 : UH1 = UH1_1(v0, v1250)
                                        method43(v1, v1251)
                                struct (v1253, v0)
                            else
                                let v1255 : bool = v0 = ""
                                let v1259 : UH1 =
                                    if v1255 then
                                        v1
                                    else
                                        let v1256 : UH1 = UH1_0
                                        let v1257 : UH1 = UH1_1(v0, v1256)
                                        method43(v1, v1257)
                                struct (v1259, v0)
                        | US9_1(v1238) -> (* Quoted *)
                            let v1240 : bool = v0 = ""
                            let v1244 : UH1 =
                                if v1240 then
                                    v1
                                else
                                    let v1241 : UH1 = UH1_0
                                    let v1242 : UH1 = UH1_1(v0, v1241)
                                    method43(v1, v1242)
                            struct (v1244, v0)
                        | _ ->
                            let v1263 : bool = v0 = ""
                            let v1267 : UH1 =
                                if v1263 then
                                    v1
                                else
                                    let v1264 : UH1 = UH1_0
                                    let v1265 : UH1 = UH1_1(v0, v1264)
                                    method43(v1, v1265)
                            struct (v1267, v0)
                else
                    match v3 with
                    | US9_1(v1274) -> (* Quoted *)
                        match v2 with
                        | UH0_1(v1275, v1276) -> (* Cons *)
                            let v1277 : bool = '\\' = v1275
                            if v1277 then
                                let v1278 : uint8 = 0uy
                                let v1279 : US9 = US9_2(v1278, v1275)
                                method41(v0, v1, v1276, v4, v1279)
                            else
                                let v1282 : bool = '`' = v1275
                                if v1282 then
                                    let v1283 : uint8 = 0uy
                                    let v1284 : US9 = US9_2(v1283, v1275)
                                    method41(v0, v1, v1276, v4, v1284)
                                else
                                    let v1287 : bool = '"' = v1275
                                    if v1287 then
                                        let v1288 : UH1 = UH1_0
                                        let v1289 : UH1 = UH1_1(v0, v1288)
                                        let v1290 : UH1 = method43(v1, v1289)
                                        let v1291 : string = ""
                                        let v1292 : US9 = US9_0
                                        method41(v1291, v1290, v1276, v4, v1292)
                                    else
                                        let v1295 : bool = ' ' = v1275
                                        if v1295 then
                                            let v1296 : string = $"{v0} "
                                            method42(v1296, v1, v1276, v4)
                                        else
                                            let v1299 : string = $"{v0}{v1275}"
                                            method42(v1299, v1, v1276, v4)
                        | _ ->
                            let v1311 : bool = v0 = ""
                            let v1315 : UH1 =
                                if v1311 then
                                    v1
                                else
                                    let v1312 : UH1 = UH1_0
                                    let v1313 : UH1 = UH1_1(v0, v1312)
                                    method43(v1, v1313)
                            struct (v1315, v0)
                    | _ ->
                        match v2 with
                        | UH0_1(v1318, v1319) -> (* Cons *)
                            let v1320 : bool = '\\' = v1318
                            if v1320 then
                                let v1321 : uint8 = 1uy
                                let v1322 : US9 = US9_2(v1321, v1318)
                                method41(v0, v1, v1319, v4, v1322)
                            else
                                let v1325 : bool = '`' = v1318
                                if v1325 then
                                    let v1326 : uint8 = 1uy
                                    let v1327 : US9 = US9_2(v1326, v1318)
                                    method41(v0, v1, v1319, v4, v1327)
                                else
                                    match v3 with
                                    | US9_2(v1330, v1331) -> (* Escaped *)
                                        let v1332 : bool = 0uy = v1330
                                        if v1332 then
                                            let v1333 : bool = '"' = v1318
                                            if v1333 then
                                                let v1334 : string = $"{v0}"
                                                let v1335 : char = '"'
                                                let v1336 : US9 = US9_1(v1335)
                                                method41(v1334, v1, v1319, v4, v1336)
                                            else
                                                let v1339 : bool = ' ' = v1318
                                                if v1339 then
                                                    let v1340 : string = $"{v0} "
                                                    method42(v1340, v1, v1319, v4)
                                                else
                                                    let v1343 : string = $"{v0}{v1318}"
                                                    method42(v1343, v1, v1319, v4)
                                        else
                                            let v1350 : bool = '"' = v1318
                                            if v1350 then
                                                let v1351 : UH1 = UH1_0
                                                let v1352 : UH1 = UH1_1(v0, v1351)
                                                let v1353 : UH1 = method43(v1, v1352)
                                                let v1354 : string = ""
                                                let v1355 : US9 = US9_0
                                                method41(v1354, v1353, v1319, v4, v1355)
                                            else
                                                let v1358 : bool = ' ' = v1318
                                                if v1358 then
                                                    let v1359 : string = $"{v0} "
                                                    method42(v1359, v1, v1319, v4)
                                                else
                                                    let v1362 : string = $"{v0}{v1318}"
                                                    method42(v1362, v1, v1319, v4)
                                    | _ ->
                                        let v1371 : bool = '"' = v1318
                                        if v1371 then
                                            let v1372 : UH1 = UH1_0
                                            let v1373 : UH1 = UH1_1(v0, v1372)
                                            let v1374 : UH1 = method43(v1, v1373)
                                            let v1375 : string = ""
                                            let v1376 : US9 = US9_0
                                            method41(v1375, v1374, v1319, v4, v1376)
                                        else
                                            let v1379 : bool = ' ' = v1318
                                            if v1379 then
                                                let v1380 : string = $"{v0} "
                                                method42(v1380, v1, v1319, v4)
                                            else
                                                let v1383 : string = $"{v0}{v1318}"
                                                method42(v1383, v1, v1319, v4)
                        | _ ->
                            match v3 with
                            | US9_2(v1396, v1397) -> (* Escaped *)
                                let v1398 : bool = 0uy = v1396
                                if v1398 then
                                    let v1400 : bool = v0 = ""
                                    let v1404 : UH1 =
                                        if v1400 then
                                            v1
                                        else
                                            let v1401 : UH1 = UH1_0
                                            let v1402 : UH1 = UH1_1(v0, v1401)
                                            method43(v1, v1402)
                                    struct (v1404, v0)
                                else
                                    let v1406 : bool = v0 = ""
                                    let v1410 : UH1 =
                                        if v1406 then
                                            v1
                                        else
                                            let v1407 : UH1 = UH1_0
                                            let v1408 : UH1 = UH1_1(v0, v1407)
                                            method43(v1, v1408)
                                    struct (v1410, v0)
                            | _ ->
                                let v1414 : bool = v0 = ""
                                let v1418 : UH1 =
                                    if v1414 then
                                        v1
                                    else
                                        let v1415 : UH1 = UH1_0
                                        let v1416 : UH1 = UH1_1(v0, v1415)
                                        method43(v1, v1416)
                                struct (v1418, v0)
    | US9_0 -> (* Start *)
        match v2 with
        | UH0_1(v5, v6) -> (* Cons *)
            let v7 : bool = '"' = v5
            if v7 then
                let v8 : string = ""
                let v9 : char = '"'
                let v10 : US9 = US9_1(v9)
                method41(v8, v1, v6, v4, v10)
            else
                let v13 : bool = '\\' = v5
                if v13 then
                    let v14 : uint8 = 0uy
                    let v15 : US9 = US9_2(v14, v5)
                    method41(v0, v1, v6, v4, v15)
                else
                    let v18 : bool = '`' = v5
                    if v18 then
                        let v19 : uint8 = 0uy
                        let v20 : US9 = US9_2(v19, v5)
                        method41(v0, v1, v6, v4, v20)
                    else
                        let v23 : bool = ' ' = v5
                        if v23 then
                            let v25 : bool = v0 = ""
                            let v29 : UH1 =
                                if v25 then
                                    v1
                                else
                                    let v26 : UH1 = UH1_0
                                    let v27 : UH1 = UH1_1(v0, v26)
                                    method43(v1, v27)
                            let v30 : string = ""
                            method42(v30, v29, v6, v4)
                        else
                            let v33 : string = $"{v0}{v5}"
                            method42(v33, v1, v6, v4)
        | _ ->
            let v45 : bool = v0 = ""
            let v49 : UH1 =
                if v45 then
                    v1
                else
                    let v46 : UH1 = UH1_0
                    let v47 : UH1 = UH1_1(v0, v46)
                    method43(v1, v47)
            struct (v49, v0)
and method44 (v0 : UH1, v1 : string list) : string list =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : string list = method44(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH1_0 -> (* Nil *)
        v1
and method40 (v0 : string) : (string []) =
    let v1 : UH1 = UH1_0
    let v2 : string = ""
    let mutable _v0 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v3 : (string -> string option) = Option.ofObj
    let v4 : string option = v3 v0
    v4 
    #else
    Some v0 
    #endif
    |> fun x -> _v0 <- Some x
    let v5 : string option = _v0.Value
    let v6 : US3 option = None
    let _v6 = ref v6 
    match v5 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v7 : string = x
    let v8 : US3 = US3_0(v7)
    v8 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v6.Value <- x
    let v9 : US3 option = _v6.Value 
    let v10 : US3 = US3_1
    let v11 : US3 = v9 |> Option.defaultValue v10 
    let v14 : string =
        match v11 with
        | US3_1 -> (* None *)
            v2
        | US3_0(v12) -> (* Some *)
            v12
    let v15 : int32 = v14.Length
    let v16 : (char []) = Array.zeroCreate<char> (v15)
    let v17 : Mut5 = {l0 = 0} : Mut5
    while method23(v15, v17) do
        let v19 : int32 = v17.l0
        let v20 : char = v14.[int v19]
        v16.[int v19] <- v20
        let v21 : int32 = v19 + 1
        v17.l0 <- v21
        ()
    let v22 : ((char []) -> char list) = Array.toList
    let v23 : char list = v22 v16
    let v24 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v25 : (char -> (UH0 -> UH0)) = method38()
    let v26 : (char list -> (UH0 -> UH0)) = v24 v25
    let v27 : (UH0 -> UH0) = v26 v23
    let v28 : UH0 = UH0_0
    let v29 : UH0 = v27 v28
    let v30 : US9 = US9_0
    let v31 : US9 = US9_0
    let struct (v32 : UH1, v33 : string) = method41(v2, v1, v29, v31, v30)
    let v34 : string list = []
    let v35 : string list = method44(v32, v34)
    let v36 : (string list -> (string [])) = List.toArray
    let v37 : (string []) = v36 v35
    v37
and closure25 () () : string =
    let v0 : string = $"runtime.execute_with_options"
    v0
and closure26 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : string, v8 : Vec<std_string_String>) () : string =
    let v9 : (unit -> string) = closure6()
    let v10 : string = $"file_name: {v7} / arguments: %A{v8} / options: %A{struct (v0, v1, v2, v3, v4, v5, v6)} / {v9 ()}"
    v10
and closure27 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : US10 =
    US10_0(v0)
and method45 () : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US10) =
    closure27()
and closure28 () (v0 : std_string_String) : US10 =
    US10_1(v0)
and method46 () : (std_string_String -> US10) =
    closure28()
and closure29 () () : string =
    let v0 : string = $"runtime.execute_with_options / child error"
    v0
and closure30 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and closure31 () (v0 : std_string_String) : US12 =
    US12_0(v0)
and method47 () : (std_string_String -> US12) =
    closure31()
and closure32 () (v0 : std_string_String) : US12 =
    US12_1(v0)
and method48 () : (std_string_String -> US12) =
    closure32()
and closure33 () () : string =
    let v0 : string = $"runtime.stdio_line"
    v0
and closure34 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"e: {v0} / {v1 ()}"
    v2
and closure35 (v0 : string) () : string =
    v0
and closure36 () (v0 : std_sync_mpsc_SendError<std_string_String>) : std_string_String =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = _v1.Value
    v11
and method49 () : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) =
    closure36()
and method50 (v0 : Result<unit, std_string_String>) : Result<unit, std_string_String> =
    v0
and method51 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and method52 (v0 : std_thread_JoinHandle<Result<unit, std_string_String>>) : std_thread_JoinHandle<Result<unit, std_string_String>> =
    v0
and closure37 () (v0 : std_process_Output) : US15 =
    US15_0(v0)
and closure38 () (v0 : std_string_String) : US15 =
    US15_1(v0)
and closure39 () () : string =
    let v0 : string = $"runtime.execute_with_options / output error"
    v0
and closure40 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and method53 () : string =
    let v0 : string = "\n"
    v0
and closure41 () () : string =
    let v0 : string = $"runtime.execute_with_options / result"
    v0
and closure42 (v0 : int32, v1 : string) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: {v0} / std_trace.Length: {v1.Length} / {v2 ()}"
    v3
and method54 (v0 : (int32 * string)) : (int32 * string) =
    v0
and closure43 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) () : string =
    let v7 : string = $"execute_with_options_async / options: %A{struct (v0, v1, v2, v3, v4, v5, v6)}"
    v7
and method56 () : (unit -> string) =
    closure6()
and closure45 (v0 : string) () : string =
    v0
and closure44 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>) (v9 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v10 : bool = true
    let mutable _v10 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : Async<unit> = null |> unbox<Async<unit>>
    v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : Async<unit> = null |> unbox<Async<unit>>
    v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v13 : Async<unit> = null |> unbox<Async<unit>>
    v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : Async<unit> = null |> unbox<Async<unit>>
    v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : Async<unit> = null |> unbox<Async<unit>>
    v15 
    #endif
#else
    let v16 : Async<unit> option = None
    let mutable _v16 = v16
    async {
    let v17 : string = v9.Data
    let v18 : string = null |> unbox<string>
    let v19 : bool = v17 = v18
    let v20 : bool = v19 <> true
    if v20 then
        let v21 : US16 option = None
        let _v21 = ref v21 
        match v3 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v22 : (struct (bool * string * int32) -> Async<unit>) = x
        let v23 : US16 = US16_0(v22)
        v23 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v21.Value <- x
        let v24 : US16 option = _v21.Value 
        let v25 : US16 = US16_1
        let v26 : US16 = v24 |> Option.defaultValue v25 
        match v26 with
        | US16_1 -> (* None *)
            ()
        | US16_0(v27) -> (* Some *)
            let v28 : int32 = v7.Id
            let v29 : Async<unit> = v27 struct (false, v17, v28)
            do! v29 
            ()
        let v30 : string = $"> {v17}"
        if v5 then
            let v31 : US0 = US0_0
            let v32 : (unit -> string) = closure45(v30)
            let v33 : (unit -> string) = closure6()
            method3(v31, v32, v33)
        else
            System.Console.WriteLine v30
            ()
        let v34 : string = ""
        let v35 : string = $"{v34}{v17}{v34}"
        let v36 : (string -> unit) = v8.Push
        v36 v35
    }
    |> fun x -> _v16 <- Some x
    let v37 : Async<unit> = _v16 |> Option.get
    v37 
    #endif
    |> fun x -> _v10 <- Some x
    let v38 : Async<unit> = _v10.Value
    let v39 : bool = true
    let mutable _v39 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    () 
    #endif
#else
    let v40 : (Async<unit> -> unit) = Async.StartImmediate
    v40 v38
    () 
    #endif
    |> fun x -> _v39 <- Some x
    _v39.Value
    ()
and closure46 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>) (v9 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v10 : bool = true
    let mutable _v10 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : Async<unit> = null |> unbox<Async<unit>>
    v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : Async<unit> = null |> unbox<Async<unit>>
    v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v13 : Async<unit> = null |> unbox<Async<unit>>
    v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : Async<unit> = null |> unbox<Async<unit>>
    v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : Async<unit> = null |> unbox<Async<unit>>
    v15 
    #endif
#else
    let v16 : Async<unit> option = None
    let mutable _v16 = v16
    async {
    let v17 : string = v9.Data
    let v18 : string = null |> unbox<string>
    let v19 : bool = v17 = v18
    let v20 : bool = v19 <> true
    if v20 then
        let v21 : US16 option = None
        let _v21 = ref v21 
        match v3 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v22 : (struct (bool * string * int32) -> Async<unit>) = x
        let v23 : US16 = US16_0(v22)
        v23 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v21.Value <- x
        let v24 : US16 option = _v21.Value 
        let v25 : US16 = US16_1
        let v26 : US16 = v24 |> Option.defaultValue v25 
        match v26 with
        | US16_1 -> (* None *)
            ()
        | US16_0(v27) -> (* Some *)
            let v28 : int32 = v7.Id
            let v29 : Async<unit> = v27 struct (true, v17, v28)
            do! v29 
            ()
        let v30 : string = $"! {v17}"
        if v5 then
            let v31 : US0 = US0_0
            let v32 : (unit -> string) = closure45(v30)
            let v33 : (unit -> string) = closure6()
            method3(v31, v32, v33)
        else
            System.Console.WriteLine v30
            ()
        let v34 : string = "\u001b[7;4m"
        let v35 : string = "\u001b[0m"
        let v36 : string = $"{v34}{v17}{v35}"
        let v37 : (string -> unit) = v8.Push
        v37 v36
    }
    |> fun x -> _v16 <- Some x
    let v38 : Async<unit> = _v16 |> Option.get
    v38 
    #endif
    |> fun x -> _v10 <- Some x
    let v39 : Async<unit> = _v10.Value
    let v40 : bool = true
    let mutable _v40 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    () 
    #endif
#else
    let v41 : (Async<unit> -> unit) = Async.StartImmediate
    v41 v39
    () 
    #endif
    |> fun x -> _v40 <- Some x
    _v40.Value
    ()
and closure47 (v0 : System.Diagnostics.Process) () : unit =
    let v1 : bool = true
    let mutable _v1 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : bool = null |> unbox<bool>
    v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : bool = null |> unbox<bool>
    v3 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v4 : bool = null |> unbox<bool>
    v4 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v5 : bool = null |> unbox<bool>
    v5 
    #endif
#if FABLE_COMPILER_PYTHON
    let v6 : bool = null |> unbox<bool>
    v6 
    #endif
#else
    let v7 : bool = v0.HasExited
    v7 
    #endif
    |> fun x -> _v1 <- Some x
    let v8 : bool = _v1.Value
    let v9 : bool = v8 = false
    if v9 then
        let v10 : bool = true
        let mutable _v10 : unit option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        null |> unbox<unit>
        () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        null |> unbox<unit>
        () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        null |> unbox<unit>
        () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        null |> unbox<unit>
        () 
        #endif
#if FABLE_COMPILER_PYTHON
        null |> unbox<unit>
        () 
        #endif
#else
        let v11 : (unit -> unit) = v0.Kill
        v11 ()
        () 
        #endif
        |> fun x -> _v10 <- Some x
        _v10.Value
        ()
and closure48 (v0 : System.Threading.Tasks.TaskCanceledException) () : string =
    let v1 : string = $"execute_with_options_async / WaitForExitAsync / ex: %A{v0}"
    v1
and closure49 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"execute_with_options_async / exit_code: {v0} / output.Length: {v1.Length}"
    v2
and method55 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    let v7 : bool = true
    let mutable _v7 : Async<struct (int32 * string)> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v9 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v10 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v12 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v12 
    #endif
#else
    let v13 : bool = true
    let mutable _v13 : Async<struct (int32 * string)> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v14 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v18 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v18 
    #endif
#else
    let v19 : Async<struct (int32 * string)> option = None
    let mutable _v19 = v19
    async {
    let struct (v20 : string, v21 : string) = method37()
    let v22 : int32 = v1.Length
    let v23 : (char []) = Array.zeroCreate<char> (v22)
    let v24 : Mut5 = {l0 = 0} : Mut5
    while method23(v22, v24) do
        let v26 : int32 = v24.l0
        let v27 : char = v1.[int v26]
        v23.[int v26] <- v27
        let v28 : int32 = v26 + 1
        v24.l0 <- v28
        ()
    let v29 : ((char []) -> char list) = Array.toList
    let v30 : char list = v29 v23
    let v31 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v32 : (char -> (UH0 -> UH0)) = method38()
    let v33 : (char list -> (UH0 -> UH0)) = v31 v32
    let v34 : (UH0 -> UH0) = v33 v30
    let v35 : UH0 = UH0_0
    let v36 : UH0 = v34 v35
    let v37 : US7 = US7_0
    let struct (v38 : string, v39 : string) = method39(v21, v20, v36, v37)
    let v40 : US3 option = None
    let _v40 = ref v40 
    match v6 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v41 : string = x
    let v42 : US3 = US3_0(v41)
    v42 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v40.Value <- x
    let v43 : US3 option = _v40.Value 
    let v44 : US3 = US3_1
    let v45 : US3 = v43 |> Option.defaultValue v44 
    let v49 : string =
        match v45 with
        | US3_1 -> (* None *)
            let v47 : string = ""
            v47
        | US3_0(v46) -> (* Some *)
            v46
    let v50 : US0 = US0_1
    let v51 : (unit -> string) = closure43(v0, v1, v2, v3, v4, v5, v6)
    let v52 : (unit -> string) = method56()
    method3(v50, v51, v52)
    let v53 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v54 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v39, StandardOutputEncoding = v53, WorkingDirectory = v49, FileName = v38, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v55 : int32 = v2.Length
    let v56 : Mut5 = {l0 = 0} : Mut5
    while method23(v55, v56) do
        let v58 : int32 = v56.l0
        let struct (v59 : string, v60 : string) = v2.[int v58]
        v54.EnvironmentVariables.[v59] <- v60 
        let v61 : int32 = v58 + 1
        v56.l0 <- v61
        ()
    let v62 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v54)
    use v62 = v62 
    let v63 : System.Diagnostics.Process = v62 
    let v64 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v65 : System.Collections.Concurrent.ConcurrentStack<string> = v64 ()
    let v66 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure44(v0, v1, v2, v3, v4, v5, v6, v63, v65)
    v63.OutputDataReceived.Add v66 
    let v67 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure46(v0, v1, v2, v3, v4, v5, v6, v63, v65)
    v63.ErrorDataReceived.Add v67 
    let v68 : (unit -> bool) = v63.Start
    let v69 : bool = v68 ()
    let v70 : bool = v69 = false
    if v70 then
        let v71 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v71
    let v72 : (unit -> unit) = v63.BeginErrorReadLine
    v72 ()
    let v73 : (unit -> unit) = v63.BeginOutputReadLine
    v73 ()
    let v74 : US17 option = None
    let _v74 = ref v74 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v75 : System.Threading.CancellationToken = x
    let v76 : US17 = US17_0(v75)
    v76 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v74.Value <- x
    let v77 : US17 option = _v74.Value 
    let v78 : US17 = US17_1
    let v79 : US17 = v77 |> Option.defaultValue v78 
    let v83 : System.Threading.CancellationToken =
        match v79 with
        | US17_1 -> (* None *)
            let v81 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v81
        | US17_0(v80) -> (* Some *)
            v80
    let v84 : bool = true
    let mutable _v84 : Async<System.Threading.CancellationToken> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v85 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v85 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v86 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v86 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v87 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v87 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v88 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v88 
    #endif
#if FABLE_COMPILER_PYTHON
    let v89 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v89 
    #endif
#else
    let v90 : bool = true
    let mutable _v90 : Async<System.Threading.CancellationToken> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v91 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v91 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v92 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v92 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v93 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v93 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v94 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v94 
    #endif
#if FABLE_COMPILER_PYTHON
    let v95 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v95 
    #endif
#else
    let v96 : Async<System.Threading.CancellationToken> option = None
    let mutable _v96 = v96
    async {
    let v97 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v97 = v97 
    let v98 : System.Threading.CancellationToken = v97 
    let v99 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v100 : (System.Threading.CancellationToken []) = [|v98; v99; v83|]
    let v101 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v102 : System.Threading.CancellationTokenSource = v101 v100
    let v103 : System.Threading.CancellationToken = v102.Token
    return v103 
    }
    |> fun x -> _v96 <- Some x
    let v104 : Async<System.Threading.CancellationToken> = _v96 |> Option.get
    v104 
    #endif
    |> fun x -> _v90 <- Some x
    let v105 : Async<System.Threading.CancellationToken> = _v90.Value
    v105 
    #endif
    |> fun x -> _v84 <- Some x
    let v106 : Async<System.Threading.CancellationToken> = _v84.Value
    let! v106 = v106 
    let v107 : System.Threading.CancellationToken = v106 
    let v108 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v107.Register
    let v109 : (unit -> unit) = closure47(v63)
    let v110 : System.Threading.CancellationTokenRegistration = v108 v109
    use v110 = v110 
    let v111 : System.Threading.CancellationTokenRegistration = v110 
    let v112 : bool = true
    let mutable _v112 : Async<int32> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v113 : Async<int32> = null |> unbox<Async<int32>>
    v113 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v114 : Async<int32> = null |> unbox<Async<int32>>
    v114 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v115 : Async<int32> = null |> unbox<Async<int32>>
    v115 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v116 : Async<int32> = null |> unbox<Async<int32>>
    v116 
    #endif
#if FABLE_COMPILER_PYTHON
    let v117 : Async<int32> = null |> unbox<Async<int32>>
    v117 
    #endif
#else
    let v118 : Async<int32> option = None
    let mutable _v118 = v118
    async {
    try
    let v119 : System.Threading.Tasks.Task = v63.WaitForExitAsync v107 
    let v120 : bool = true
    let mutable _v120 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v121 : Async<unit> = null |> unbox<Async<unit>>
    v121 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v122 : Async<unit> = null |> unbox<Async<unit>>
    v122 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v123 : Async<unit> = null |> unbox<Async<unit>>
    v123 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v124 : Async<unit> = null |> unbox<Async<unit>>
    v124 
    #endif
#if FABLE_COMPILER_PYTHON
    let v125 : Async<unit> = null |> unbox<Async<unit>>
    v125 
    #endif
#else
    let v126 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v127 : Async<unit> = v126 v119
    v127 
    #endif
    |> fun x -> _v120 <- Some x
    let v128 : Async<unit> = _v120.Value
    do! v128 
    let v129 : int32 = v63.ExitCode
    return v129 
    with ex ->
    let v130 : exn = ex
    let v131 : bool = true
    let mutable _v131 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v132 : string = $"%A{v130}"
    v132 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v133 : string = $"%A{v130}"
    v133 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v134 : string = $"%A{v130}"
    v134 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v135 : string = $"%A{v130}"
    v135 
    #endif
#if FABLE_COMPILER_PYTHON
    let v136 : string = $"%A{v130}"
    v136 
    #endif
#else
    let v137 : string = $"{v130.GetType ()}: {v130.Message}"
    v137 
    #endif
    |> fun x -> _v131 <- Some x
    let v138 : string = _v131.Value
    let v139 : (string -> unit) = v65.Push
    v139 v138
    let v140 : System.Threading.Tasks.TaskCanceledException = v130 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v141 : US0 = US0_3
    let v142 : (unit -> string) = closure48(v140)
    let v143 : (unit -> string) = method56()
    method3(v141, v142, v143)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v118 <- Some x
    let v144 : Async<int32> = _v118 |> Option.get
    v144 
    #endif
    |> fun x -> _v112 <- Some x
    let v145 : Async<int32> = _v112.Value
    let! v145 = v145 
    let v146 : int32 = v145 
    let v147 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v148 : string seq = v147 v65
    let v149 : string = method53()
    let v150 : (string -> (string seq -> string)) = String.concat
    let v151 : (string seq -> string) = v150 v149
    let v152 : string = v151 v148
    let v153 : US0 = US0_1
    let v154 : (unit -> string) = closure49(v146, v152)
    let v155 : (unit -> string) = method56()
    method3(v153, v154, v155)
    return struct (v146, v152) 
    }
    |> fun x -> _v19 <- Some x
    let v156 : Async<struct (int32 * string)> = _v19 |> Option.get
    v156 
    #endif
    |> fun x -> _v13 <- Some x
    let v157 : Async<struct (int32 * string)> = _v13.Value
    v157 
    #endif
    |> fun x -> _v7 <- Some x
    let v158 : Async<struct (int32 * string)> = _v7.Value
    v158
and method35 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : struct (int32 * string) =
    let v7 : bool = true
    let mutable _v7 : struct (int32 * string) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = method36(v0, v1, v2, v3, v4, v5, v6)
    let struct (v9 : string, v10 : string) = method37()
    let v11 : int32 = v8.Length
    let v12 : (char []) = Array.zeroCreate<char> (v11)
    let v13 : Mut5 = {l0 = 0} : Mut5
    while method23(v11, v13) do
        let v15 : int32 = v13.l0
        let v16 : char = v8.[int v15]
        v12.[int v15] <- v16
        let v17 : int32 = v15 + 1
        v13.l0 <- v17
        ()
    let v18 : ((char []) -> char list) = Array.toList
    let v19 : char list = v18 v12
    let v20 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v21 : (char -> (UH0 -> UH0)) = method38()
    let v22 : (char list -> (UH0 -> UH0)) = v20 v21
    let v23 : (UH0 -> UH0) = v22 v19
    let v24 : UH0 = UH0_0
    let v25 : UH0 = v23 v24
    let v26 : US7 = US7_0
    let struct (v27 : string, v28 : string) = method39(v10, v9, v25, v26)
    let v29 : (string []) = method40(v28)
    let v30 : string = "$0.to_vec()"
    let v31 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v29 v30
    let v32 : string = "true; let _result = v31.into_iter().map(|x| { //"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : string = "x"
    let v35 : string = Fable.Core.RustInterop.emitRustExpr () v34
    let v36 : string = "&*$0"
    let v37 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v35 v36
    let v38 : string = "String::from($0)"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v38
    let v40 : string = "true; $0 }).collect::<Vec<_>>()"
    let v41 : bool = Fable.Core.RustInterop.emitRustExpr v39 v40
    let v42 : string = "_result"
    let v43 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : US0 = US0_1
    let v45 : (unit -> string) = closure25()
    let v46 : (unit -> string) = closure26(v0, v1, v2, v3, v4, v5, v6, v27, v43)
    method3(v44, v45, v46)
    let v47 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v47
    let v48 : bool = true
    let mutable _v48 : (int32 * string) option = None 
    (
    (fun () ->
    (fun () ->
    let v49 : string = "std::process::Command::new(&*$0)"
    let v50 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v27 v49
    let v51 : string = "true; let mut v50 = v50"
    let v52 : bool = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : string = "std::process::Command::args(&mut $0, &*$1)"
    let v54 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr struct (v50, v43) v53
    let v55 : string = "std::process::Stdio::piped()"
    let v56 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v55
    let v57 : string = "std::process::Command::stdout($0, std::process::Stdio::piped())"
    let v58 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v54 v57
    let v59 : string = "std::process::Stdio::piped()"
    let v60 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v59
    let v61 : string = "std::process::Command::stderr($0, std::process::Stdio::piped())"
    let v62 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v58 v61
    let v63 : string = "std::process::Stdio::piped()"
    let v64 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v63
    let v65 : string = "std::process::Command::stdin($0, std::process::Stdio::piped())"
    let v66 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v62 v65
    let v67 : US3 option = None
    let _v67 = ref v67 
    match v6 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v68 : string = x
    let v69 : US3 = US3_0(v68)
    v69 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v67.Value <- x
    let v70 : US3 option = _v67.Value 
    let v71 : US3 = US3_1
    let v72 : US3 = v70 |> Option.defaultValue v71 
    let v77 : Ref<Mut<std_process_Command>> =
        match v72 with
        | US3_1 -> (* None *)
            v66
        | US3_0(v73) -> (* Some *)
            let v74 : string = "std::process::Command::current_dir(v66, &*$0)"
            let v75 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v73 v74
            v75
    let v78 : uint64 = System.Convert.ToUInt64 v2.Length
    let v79 : bool = v78 = 0UL
    let v95 : Ref<Mut<std_process_Command>> =
        if v79 then
            v77
        else
            let v80 : string = "$0.to_vec()"
            let v81 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr v2 v80
            let v82 : string = "true; let _result = $0.into_iter().fold(v77, |acc, x| { //"
            let v83 : bool = Fable.Core.RustInterop.emitRustExpr v81 v82
            let v84 : string = "acc"
            let v85 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr () v84
            let v86 : string = "x"
            let struct (v87 : string, v88 : string) = Fable.Core.RustInterop.emitRustExpr () v86
            let v89 : string = "std::process::Command::env(v85, &*$0, &*$1)"
            let v90 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr struct (v87, v88) v89
            let v91 : string = "true; $0 })"
            let v92 : bool = Fable.Core.RustInterop.emitRustExpr v90 v91
            let v93 : string = "_result"
            let v94 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr () v93
            v94
    let v96 : string = "std::process::Command::spawn($0)"
    let v97 : Result<std_process_Child, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v95 v96
    let v98 : (std_io_Error -> std_string_String) = method29()
    let v99 : string = "$0.map_err(|x| $1(x))"
    let v100 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v97, v98) v99
    let v101 : string = "true; let _result = $0.map(|x| { //"
    let v102 : bool = Fable.Core.RustInterop.emitRustExpr v100 v101
    let v103 : string = "x"
    let v104 : std_process_Child = Fable.Core.RustInterop.emitRustExpr () v103
    let v105 : std_process_Child option = Some v104 
    let v106 : string = "std::sync::Mutex::new($0)"
    let v107 : std_sync_Mutex<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v105 v106
    let v108 : string = "std::sync::Arc::new($0)"
    let v109 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v107 v108
    let v110 : string = "true; $0 })"
    let v111 : bool = Fable.Core.RustInterop.emitRustExpr v109 v110
    let v112 : string = "_result"
    let v113 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v112
    let v114 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US10) = method45()
    let v115 : (std_string_String -> US10) = method46()
    let v116 : string = "match v113 { Ok(x) => $0(x), Err(e) => $1(e) }"
    let v117 : US10 = Fable.Core.RustInterop.emitRustExpr struct (v114, v115) v116
    let struct (v443 : int32, v444 : US2, v445 : US11) =
        match v117 with
        | US10_1(v434) -> (* Error *)
            let v435 : US0 = US0_4
            let v436 : (unit -> string) = closure29()
            let v437 : (unit -> string) = closure30(v434)
            method3(v435, v436, v437)
            let v438 : US2 = US2_0(v434)
            let v439 : US11 = US11_1
            struct (-1, v438, v439)
        | US10_0(v118) -> (* Ok *)
            let v119 : string = "$0.lock().unwrap().as_mut().unwrap().stdout.take().unwrap()"
            let v120 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr v118 v119
            let v121 : string = "$0.lock().unwrap().as_mut().unwrap().stderr.take().unwrap()"
            let v122 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr v118 v121
            let v123 : string = "$0.lock().unwrap().as_mut().unwrap().stdin.take().unwrap()"
            let v124 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr v118 v123
            let v125 : string = "std::sync::Mutex::new($0)"
            let v126 : std_sync_Mutex<std_process_ChildStdout> = Fable.Core.RustInterop.emitRustExpr v120 v125
            let v127 : string = "std::sync::Arc::new($0)"
            let v128 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdout>> = Fable.Core.RustInterop.emitRustExpr v126 v127
            let v129 : string = "std::sync::Mutex::new($0)"
            let v130 : std_sync_Mutex<std_process_ChildStderr> = Fable.Core.RustInterop.emitRustExpr v122 v129
            let v131 : string = "std::sync::Arc::new($0)"
            let v132 : std_sync_Arc<std_sync_Mutex<std_process_ChildStderr>> = Fable.Core.RustInterop.emitRustExpr v130 v131
            let v133 : std_process_ChildStdin option = Some v124 
            let v134 : string = "std::sync::Mutex::new($0)"
            let v135 : std_sync_Mutex<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v133 v134
            let v136 : string = "std::sync::Arc::new($0)"
            let v137 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v135 v136
            let v138 : string = "{ let (sender, receiver) = std::sync::mpsc::channel(); (sender, std::sync::Arc::new(receiver)) }"
            let struct (v139 : std_sync_mpsc_Sender<std_string_String>, v140 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = Fable.Core.RustInterop.emitRustExpr () v138
            let v141 : string = "std::sync::Mutex::new($0)"
            let v142 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v139 v141
            let v143 : string = "std::sync::Arc::new($0)"
            let v144 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v142 v143
            let v145 : string = "std::sync::Mutex::new($0)"
            let v146 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v139 v145
            let v147 : string = "std::sync::Arc::new($0)"
            let v148 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v146 v147
            let v149 : string = "std::sync::Mutex::new($0)"
            let v150 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v140 v149
            let v151 : string = "std::sync::Arc::new($0)"
            let v152 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr v150 v151
            let v153 : string = "true; let __result = std::thread::spawn(move || { //"
            let v154 : bool = Fable.Core.RustInterop.emitRustExpr () v153
            let v155 : string = "$0.lock()"
            let v156 : Result<std_sync_MutexGuard<std_process_ChildStdout>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdout>>> = Fable.Core.RustInterop.emitRustExpr v128 v155
            let v157 : string = "$0.unwrap()"
            let v158 : std_sync_MutexGuard<std_process_ChildStdout> = Fable.Core.RustInterop.emitRustExpr v156 v157
            let v159 : string = "true; let mut v158 = v158"
            let v160 : bool = Fable.Core.RustInterop.emitRustExpr () v159
            let v161 : string = "&mut $0"
            let v162 : Ref<Mut<std_process_ChildStdout>> = Fable.Core.RustInterop.emitRustExpr v158 v161
            let v163 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v164 : encoding_rs_io_DecodeReaderBytes<Ref<Mut<std_process_ChildStdout>>, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v162 v163
            let v165 : string = "std::io::BufReader::new(v164)"
            let v166 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<Ref<Mut<std_process_ChildStdout>>, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v165
            let v167 : string = "std::io::BufRead::lines(v166)"
            let v168 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<Ref<Mut<std_process_ChildStdout>>, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v167
            let v169 : string = "true; let mut v168 = v168; let _result = v168.try_for_each(|x| { //"
            let v170 : bool = Fable.Core.RustInterop.emitRustExpr () v169
            let v171 : string = "x"
            let v172 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v171
            let v173 : string = "$0.clone()"
            let v174 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v144 v173
            let v175 : (std_io_Error -> std_string_String) = method29()
            let v176 : string = "$0.map_err(|x| $1(x))"
            let v177 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v172, v175) v176
            let v178 : (std_string_String -> US12) = method47()
            let v179 : (std_string_String -> US12) = method48()
            let v180 : string = "match v177 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v181 : US12 = Fable.Core.RustInterop.emitRustExpr struct (v178, v179) v180
            let v213 : std_string_String =
                match v181 with
                | US12_1(v203) -> (* Error *)
                    let v204 : US0 = US0_4
                    let v205 : (unit -> string) = closure33()
                    let v206 : (unit -> string) = closure34(v203)
                    method3(v204, v205, v206)
                    let v207 : string = $"\u001b[4;7m{v203}\u001b[0m"
                    let v208 : string = "&*$0"
                    let v209 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v207 v208
                    let v210 : string = "String::from($0)"
                    let v211 : std_string_String = Fable.Core.RustInterop.emitRustExpr v209 v210
                    v211
                | US12_0(v182) -> (* Ok *)
                    let v183 : string = "fable_library_rust::String_::fromString($0)"
                    let v184 : string = Fable.Core.RustInterop.emitRustExpr v182 v183
                    let v185 : string = "encoding_rs::UTF_8"
                    let v186 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v185
                    let v187 : string = "$0.encode(&*$1).0"
                    let v188 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v186, v184) v187
                    let v189 : string = "$0.as_ref()"
                    let v190 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v188 v189
                    let v191 : string = "std::str::from_utf8(v190)"
                    let v192 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr () v191
                    let v193 : string = "$0.unwrap()"
                    let v194 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v192 v193
                    let v195 : string = "String::from($0)"
                    let v196 : std_string_String = Fable.Core.RustInterop.emitRustExpr v194 v195
                    let v197 : string = "fable_library_rust::String_::fromString($0)"
                    let v198 : string = Fable.Core.RustInterop.emitRustExpr v196 v197
                    let v199 : string = $"> {v198}"
                    if v5 then
                        let v200 : US0 = US0_0
                        let v201 : (unit -> string) = closure35(v199)
                        let v202 : (unit -> string) = closure6()
                        method3(v200, v201, v202)
                    else
                        System.Console.WriteLine v199
                        ()
                    v196
            let v214 : string = "$0.lock()"
            let v215 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr v174 v214
            let v216 : string = "$0.unwrap()"
            let v217 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v215 v216
            let v218 : string = "&$0"
            let v219 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v217 v218
            let v220 : string = "$0.send($1)"
            let v221 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v219, v213) v220
            let v222 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method49()
            let v223 : string = "$0.map_err(|x| $1(x))"
            let v224 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v221, v222) v223
            let v225 : string = "$0"
            let v226 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v224 v225
            let v227 : string = "true; $0 }); //"
            let v228 : bool = Fable.Core.RustInterop.emitRustExpr v226 v227
            let v229 : string = "_result"
            let v230 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v229
            let v231 : Result<unit, std_string_String> = method50(v230)
            let v232 : string = ""
            let v233 : string = "}"
            let v234 : string = v232 + v233
            let v235 : string = "v231 " + v234 + "); " + v232 + " //"
            Fable.Core.RustInterop.emitRustExpr () v235
            let v236 : string = "__result"
            let v237 : std_thread_JoinHandle<Result<unit, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v236
            let v238 : string = "true; let __result = std::thread::spawn(move || { //"
            let v239 : bool = Fable.Core.RustInterop.emitRustExpr () v238
            let v240 : string = "$0.lock()"
            let v241 : Result<std_sync_MutexGuard<std_process_ChildStderr>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStderr>>> = Fable.Core.RustInterop.emitRustExpr v132 v240
            let v242 : string = "$0.unwrap()"
            let v243 : std_sync_MutexGuard<std_process_ChildStderr> = Fable.Core.RustInterop.emitRustExpr v241 v242
            let v244 : string = "true; let mut v243 = v243"
            let v245 : bool = Fable.Core.RustInterop.emitRustExpr () v244
            let v246 : string = "&mut $0"
            let v247 : Ref<Mut<std_process_ChildStderr>> = Fable.Core.RustInterop.emitRustExpr v243 v246
            let v248 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v249 : encoding_rs_io_DecodeReaderBytes<Ref<Mut<std_process_ChildStderr>>, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v247 v248
            let v250 : string = "std::io::BufReader::new(v249)"
            let v251 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<Ref<Mut<std_process_ChildStderr>>, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v250
            let v252 : string = "std::io::BufRead::lines(v251)"
            let v253 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<Ref<Mut<std_process_ChildStderr>>, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v252
            let v254 : string = "true; let mut v253 = v253; let _result = v253.try_for_each(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr () v254
            let v256 : string = "x"
            let v257 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v256
            let v258 : string = "$0.clone()"
            let v259 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v148 v258
            let v260 : (std_io_Error -> std_string_String) = method29()
            let v261 : string = "$0.map_err(|x| $1(x))"
            let v262 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v257, v260) v261
            let v263 : (std_string_String -> US12) = method47()
            let v264 : (std_string_String -> US12) = method48()
            let v265 : string = "match v262 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v266 : US12 = Fable.Core.RustInterop.emitRustExpr struct (v263, v264) v265
            let v303 : std_string_String =
                match v266 with
                | US12_1(v293) -> (* Error *)
                    let v294 : US0 = US0_4
                    let v295 : (unit -> string) = closure33()
                    let v296 : (unit -> string) = closure34(v293)
                    method3(v294, v295, v296)
                    let v297 : string = $"\u001b[4;7m{v293}\u001b[0m"
                    let v298 : string = "&*$0"
                    let v299 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v297 v298
                    let v300 : string = "String::from($0)"
                    let v301 : std_string_String = Fable.Core.RustInterop.emitRustExpr v299 v300
                    v301
                | US12_0(v267) -> (* Ok *)
                    let v268 : string = "fable_library_rust::String_::fromString($0)"
                    let v269 : string = Fable.Core.RustInterop.emitRustExpr v267 v268
                    let v270 : string = "encoding_rs::UTF_8"
                    let v271 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v270
                    let v272 : string = "$0.encode(&*$1).0"
                    let v273 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v271, v269) v272
                    let v274 : string = "$0.as_ref()"
                    let v275 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v273 v274
                    let v276 : string = "std::str::from_utf8(v275)"
                    let v277 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr () v276
                    let v278 : string = "$0.unwrap()"
                    let v279 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v277 v278
                    let v280 : string = "String::from($0)"
                    let v281 : std_string_String = Fable.Core.RustInterop.emitRustExpr v279 v280
                    let v282 : string = "fable_library_rust::String_::fromString($0)"
                    let v283 : string = Fable.Core.RustInterop.emitRustExpr v281 v282
                    let v284 : string = $"! {v283}"
                    if v5 then
                        let v285 : US0 = US0_0
                        let v286 : (unit -> string) = closure35(v284)
                        let v287 : (unit -> string) = closure6()
                        method3(v285, v286, v287)
                    else
                        System.Console.WriteLine v284
                        ()
                    let v288 : string = $"\u001b[4;7m{v281}\u001b[0m"
                    let v289 : string = "&*$0"
                    let v290 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v288 v289
                    let v291 : string = "String::from($0)"
                    let v292 : std_string_String = Fable.Core.RustInterop.emitRustExpr v290 v291
                    v292
            let v304 : string = "$0.lock()"
            let v305 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr v259 v304
            let v306 : string = "$0.unwrap()"
            let v307 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v305 v306
            let v308 : string = "&$0"
            let v309 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v307 v308
            let v310 : string = "$0.send($1)"
            let v311 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v309, v303) v310
            let v312 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method49()
            let v313 : string = "$0.map_err(|x| $1(x))"
            let v314 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v311, v312) v313
            let v315 : string = "$0"
            let v316 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v314 v315
            let v317 : string = "true; $0 }); //"
            let v318 : bool = Fable.Core.RustInterop.emitRustExpr v316 v317
            let v319 : string = "_result"
            let v320 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v319
            let v321 : Result<unit, std_string_String> = method50(v320)
            let v322 : string = v232 + v233
            let v323 : string = "v321 " + v322 + "); " + v232 + " //"
            Fable.Core.RustInterop.emitRustExpr () v323
            let v324 : string = "__result"
            let v325 : std_thread_JoinHandle<Result<unit, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v324
            let v326 : US13 option = None
            let _v326 = ref v326 
            match v4 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v327 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = x
            let v328 : US13 = US13_0(v327)
            v328 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v326.Value <- x
            let v329 : US13 option = _v326.Value 
            let v330 : US13 = US13_1
            let v331 : US13 = v329 |> Option.defaultValue v330 
            match v331 with
            | US13_1 -> (* None *)
                ()
            | US13_0(v332) -> (* Some *)
                let v333 : string = "$0.lock()"
                let v334 : Result<std_sync_MutexGuard<std_process_ChildStdin option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin option>>> = Fable.Core.RustInterop.emitRustExpr v137 v333
                let v335 : string = "$0.unwrap()"
                let v336 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v334 v335
                let v337 : string = "true; let mut v336 = v336"
                let v338 : bool = Fable.Core.RustInterop.emitRustExpr () v337
                let v339 : string = "&mut $0"
                let v340 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v336 v339
                let v341 : string = "Option::take($0)"
                let v342 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v340 v341
                let v343 : string = "true; let _result = v342.map(|x| { //"
                let v344 : bool = Fable.Core.RustInterop.emitRustExpr () v343
                let v345 : string = "x"
                let v346 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr () v345
                let v347 : string = "std::sync::Mutex::new($0)"
                let v348 : std_sync_Mutex<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v346 v347
                let v349 : string = "std::sync::Arc::new($0)"
                let v350 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr v348 v349
                let v351 : string = "true; $0 })"
                let v352 : bool = Fable.Core.RustInterop.emitRustExpr v350 v351
                let v353 : string = "_result"
                let v354 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> option = Fable.Core.RustInterop.emitRustExpr () v353
                let v355 : US14 option = None
                let _v355 = ref v355 
                match v354 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v356 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = x
                let v357 : US14 = US14_0(v356)
                v357 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v355.Value <- x
                let v358 : US14 option = _v355.Value 
                let v359 : US14 = US14_1
                let v360 : US14 = v358 |> Option.defaultValue v359 
                match v360 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v361) -> (* Some *)
                    v332 v361
                    let v362 : string = "$0.lock()"
                    let v363 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr v361 v362
                    let v364 : string = "$0.unwrap()"
                    let v365 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v363 v364
                    let v366 : std_sync_MutexGuard<std_process_ChildStdin> = method51(v365)
                    let v367 : string = "true; let mut v366 = v366"
                    let v368 : bool = Fable.Core.RustInterop.emitRustExpr () v367
                    let v369 : string = "true; std::io::Write::flush(&mut *$0).unwrap()"
                    let v370 : bool = Fable.Core.RustInterop.emitRustExpr v366 v369
                    ()
            let v371 : string = "$0.lock()"
            let v372 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr v118 v371
            let v373 : string = "$0.unwrap()"
            let v374 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v372 v373
            let v375 : string = "true; let mut v374 = v374"
            let v376 : bool = Fable.Core.RustInterop.emitRustExpr () v375
            let v377 : string = "&mut $0"
            let v378 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v374 v377
            let v379 : string = "Option::take($0)"
            let v380 : std_process_Child option = Fable.Core.RustInterop.emitRustExpr v378 v379
            let v381 : string = "$0.unwrap()"
            let v382 : std_process_Child = Fable.Core.RustInterop.emitRustExpr v380 v381
            let v383 : string = "$0.wait_with_output()"
            let v384 : Result<std_process_Output, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v382 v383
            let v385 : (std_io_Error -> std_string_String) = method29()
            let v386 : string = "$0.map_err(|x| $1(x))"
            let v387 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v384, v385) v386
            let v388 : std_thread_JoinHandle<Result<unit, std_string_String>> = method52(v325)
            let v389 : string = "v388"
            let v390 : string = v389 + v232
            let v391 : string = v390 + v232
            let v392 : std_thread_JoinHandle<Result<unit, std_string_String>> = method52(v237)
            let v393 : string = "v392"
            let v394 : string = ","
            let v395 : string = v393 + v394
            let v396 : string = v395 + v391
            let v397 : string = "vec![" + v396 + "]"
            let v398 : Vec<std_thread_JoinHandle<Result<unit, std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v397
            let v399 : string = "true; v398.into_iter().for_each(|x| { //"
            let v400 : bool = Fable.Core.RustInterop.emitRustExpr () v399
            let v401 : string = "x"
            let v402 : std_thread_JoinHandle<Result<unit, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v401
            let v403 : string = "std::thread::JoinHandle::join($0)"
            let v404 : Result<Result<unit, std_string_String>, Box<LifetimeRef<Dyn<LifetimeJoin<core_any_Any, LifetimeRef<LifetimeJoin<StaticLifetime, Send<StaticLifetime>>>>>>>> = Fable.Core.RustInterop.emitRustExpr v402 v403
            let v405 : string = "$0.unwrap()"
            let v406 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr v404 v405
            let v407 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v406 v407
            let v408 : string = "true; () }}); { //"
            let v409 : bool = Fable.Core.RustInterop.emitRustExpr () v408
            let v410 : (std_process_Output -> US15) = closure37()
            let v411 : (std_string_String -> US15) = closure38()
            let v412 : US15 = match v387 with Ok x -> v410 x | Error x -> v411 x
            match v412 with
            | US15_1(v422) -> (* Error *)
                let v423 : US0 = US0_4
                let v424 : (unit -> string) = closure39()
                let v425 : (unit -> string) = closure40(v422)
                method3(v423, v424, v425)
                let v426 : US2 = US2_0(v422)
                let v427 : US11 = US11_1
                struct (-2, v426, v427)
            | US15_0(v413) -> (* Ok *)
                let v414 : string = "$0.status"
                let v415 : std_process_ExitStatus = Fable.Core.RustInterop.emitRustExpr v413 v414
                let v416 : string = "$0.code()"
                let v417 : int32 option = Fable.Core.RustInterop.emitRustExpr v415 v416
                let v418 : string = "$0.unwrap()"
                let v419 : int32 = Fable.Core.RustInterop.emitRustExpr v417 v418
                let v420 : US2 = US2_1
                let v421 : US11 = US11_0(v152)
                struct (v419, v420, v421)
    let v450 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option =
        match v445 with
        | US11_1 -> (* None *)
            let v448 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = None
            v448
        | US11_0(v446) -> (* Some *)
            let v447 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = Some v446 
            v447
    let v451 : string = "true; let _result = v450.map(|x| { //"
    let v452 : bool = Fable.Core.RustInterop.emitRustExpr () v451
    let v453 : string = "x"
    let v454 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v453
    let v455 : string = "$0.lock()"
    let v456 : Result<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr v454 v455
    let v457 : string = "$0.unwrap()"
    let v458 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v456 v457
    let v459 : string = "v458.iter()"
    let v460 : _ = Fable.Core.RustInterop.emitRustExpr () v459
    let v461 : string = "v460.collect::<Vec<_>>()"
    let v462 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v461
    let v463 : string = "true; let _result = v462.into_iter().map(|x| { //"
    let v464 : bool = Fable.Core.RustInterop.emitRustExpr () v463
    let v465 : string = "x"
    let v466 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v465
    let v467 : string = "fable_library_rust::String_::fromString($0)"
    let v468 : string = Fable.Core.RustInterop.emitRustExpr v466 v467
    let v469 : string = "true; $0 }).collect::<Vec<_>>()"
    let v470 : bool = Fable.Core.RustInterop.emitRustExpr v468 v469
    let v471 : string = "_result"
    let v472 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v471
    let v473 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v474 : (string []) = Fable.Core.RustInterop.emitRustExpr v472 v473
    let v475 : ((string []) -> string seq) = Seq.ofArray
    let v476 : string seq = v475 v474
    let v477 : string = method53()
    let v478 : (string -> (string seq -> string)) = String.concat
    let v479 : (string seq -> string) = v478 v477
    let v480 : string = v479 v476
    let v481 : string = "true; $0 })"
    let v482 : bool = Fable.Core.RustInterop.emitRustExpr v480 v481
    let v483 : string = "_result"
    let v484 : string option = Fable.Core.RustInterop.emitRustExpr () v483
    let v491 : US3 =
        match v444 with
        | US2_1 -> (* None *)
            US3_1
        | US2_0(v485) -> (* Some *)
            let v486 : string = "fable_library_rust::String_::fromString($0)"
            let v487 : string = Fable.Core.RustInterop.emitRustExpr v485 v486
            US3_0(v487)
    let v495 : string =
        match v491 with
        | US3_1 -> (* None *)
            let v493 : string = ""
            v493
        | US3_0(v492) -> (* Some *)
            v492
    let v496 : string = v484 |> Option.defaultValue v495 
    let v497 : US0 = US0_0
    let v498 : (unit -> string) = closure41()
    let v499 : (unit -> string) = closure42(v443, v496)
    method3(v497, v498, v499)
    let v500 : (int32 * string) = v443, v496
    v500 
    )
    |> fun x -> x ()
    ) () )
    |> fun x -> _v48 <- Some x
    let v501 : (int32 * string) = _v48.Value 
    let v502 : (int32 * string) = method54(v501)
    let v503 : string = ""
    let v504 : string = "}"
    let v505 : string = v503 + v504
    let v506 : string = v505 + v504
    let v507 : string = v506 + v504
    let v508 : string = "{"
    let v509 : string = v503 + v508
    let v510 : string = v509 + v508
    let v511 : string = "v502 " + v507 + "); " + v510 + " //"
    Fable.Core.RustInterop.emitRustExpr () v511
    let v512 : string = "__result"
    let v513 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = Fable.Core.RustInterop.emitRustExpr () v512
    let v514 : string = "futures_lite::future::block_on($0)"
    let v515 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v513 v514
    let (a, b) = v515
    let v516 : int32 = a
    let v517 : string = b
    struct (v516, v517) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v518 : int32, v519 : string) = null |> unbox<struct (int32 * string)>
    struct (v518, v519) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v520 : int32, v521 : string) = null |> unbox<struct (int32 * string)>
    struct (v520, v521) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v522 : int32, v523 : string) = null |> unbox<struct (int32 * string)>
    struct (v522, v523) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v524 : int32, v525 : string) = null |> unbox<struct (int32 * string)>
    struct (v524, v525) 
    #endif
#else
    let v526 : Async<struct (int32 * string)> = method55(v0, v1, v2, v3, v4, v5, v6)
    let v527 : bool = true
    let mutable _v527 : struct (int32 * string) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v528 : int32, v529 : string) = null |> unbox<struct (int32 * string)>
    struct (v528, v529) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v530 : int32, v531 : string) = null |> unbox<struct (int32 * string)>
    struct (v530, v531) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v532 : int32, v533 : string) = null |> unbox<struct (int32 * string)>
    struct (v532, v533) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v534 : int32, v535 : string) = null |> unbox<struct (int32 * string)>
    struct (v534, v535) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v536 : int32, v537 : string) = null |> unbox<struct (int32 * string)>
    struct (v536, v537) 
    #endif
#else
    let v538 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v539 : int32, v540 : string) = v538 v526
    struct (v539, v540) 
    #endif
    |> fun x -> _v527 <- Some x
    let struct (v541 : int32, v542 : string) = _v527.Value
    struct (v541, v542) 
    #endif
    |> fun x -> _v7 <- Some x
    let struct (v543 : int32, v544 : string) = _v7.Value
    struct (v543, v544)
and method57 (v0 : string, v1 : string, v2 : string) : struct (string * string) =
    let v3 : bool = true
    let mutable _v3 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "std::path::PathBuf::from($0)"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "$0.file_name()"
    let v11 : Ref<std_ffi_OsStr> option = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "$0.unwrap()"
    let v13 : Ref<std_ffi_OsStr> = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "$0.to_os_string()"
    let v15 : std_ffi_OsString = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "$0.to_str()"
    let v17 : Ref<Str> option = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.unwrap()"
    let v19 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "String::from($0)"
    let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : string = "fable_library_rust::String_::fromString($0)"
    let v23 : string = Fable.Core.RustInterop.emitRustExpr v21 v22
    v23 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v24 : string = null |> unbox<string>
    v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : string = null |> unbox<string>
    v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v26 : string = null |> unbox<string>
    v26 
    #endif
#if FABLE_COMPILER_PYTHON
    let v27 : string = null |> unbox<string>
    v27 
    #endif
#else
    let v28 : (string -> string) = System.IO.Path.GetFileName
    let v29 : string = v28 v1
    v29 
    #endif
    |> fun x -> _v3 <- Some x
    let v30 : string = _v3.Value
    let v31 : string = method11(v2, v30)
    let v32 : string = "."
    let v33 : int32 = v1.LastIndexOf v32
    let v34 : int32 = v33 - 1
    let v35 : string = v1.[int 0..int v34]
    let v36 : int32 = v31.LastIndexOf v32
    let v37 : int32 = v36 - 1
    let v38 : string = v31.[int 0..int v37]
    let v39 : string = ".md"
    let v40 : bool = v0.EndsWith v39
    let v41 : bool = v40 = false
    let v44 : string =
        if v41 then
            let v42 : string = $"{v1}.{v0}"
            v42
        else
            let v43 : string = $"{v35}.{v0}"
            v43
    let v47 : string =
        if v41 then
            let v45 : string = $"{v31}.{v0}"
            v45
        else
            let v46 : string = $"{v38}.{v0}"
            v46
    struct (v47, v44)
and closure50 () (v0 : uint8) : string =
    let v1 : string = "{:02x}"
    let v2 : string = "format!(\"" + v1 + "\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2
    let v4 : string = "fable_library_rust::String_::fromString($0)"
    let v5 : string = Fable.Core.RustInterop.emitRustExpr v3 v4
    v5
and method58 () : string =
    let v0 : string = ""
    v0
and closure51 () () : string =
    let v0 : string = "documents.run / par_map / origin_hash |> sm'.contains local_git_hash |> not / hash2 = None || hash1 <>. (hash2 |> optionm.value)"
    v0
and closure52 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : int32, v5 : string, v6 : string, v7 : int32, v8 : string, v9 : string, v10 : US3) () : string =
    let v11 : (unit -> string) = closure6()
    let v12 : string = $"file: {v1} / real_path: {v2} / relative_path: {v0} / origin_hash_exit_code: {v4} / origin_hash: {v3} / local_git_hash_exit_code: {v7} / local_git_hash: {v6} / hash1: {v9} / hash2: %A{v10} / dist_path: {v5} / cache_path: {v8} / {v11 ()}"
    v12
and method59 (v0 : string) : string =
    v0
and method61 (v0 : int32, v1 : Mut6) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method62 (v0 : string) : string =
    v0
and method63 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure55 (v0 : string) (v1 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : unit =
    let v2 : string = "$0.lock()"
    let v3 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "$0.unwrap()"
    let v5 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = method62(v0)
    let v7 : string = "v6.as_bytes()"
    let v8 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : std_sync_MutexGuard<std_process_ChildStdin> = method63(v5)
    let v10 : string = "true; let mut v9 = v9"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : string = "true; std::io::Write::write_all(&mut *$0, v8).unwrap()"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr v9 v12
    ()
and method64 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method65 (v0 : string) : string =
    v0
and closure56 () () : string =
    let v0 : string = "documents.hangul"
    v0
and closure57 (v0 : string, v1 : int32, v2 : string) () : string =
    let v3 : int32 = v2.Length
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"exit_code: %A{v1} / result_len: {v3} / output_path: {v0} / {v4 ()}"
    v5
and method60 (v0 : string, v1 : string, v2 : string, v3 : string) : US19 =
    let v4 : bool = true
    let mutable _v4 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : bool = true
    let mutable _v5 : Vec<uint8> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = "std::fs::read(&*$0).unwrap()"
    let v7 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v3 v6
    v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : Vec<uint8> = null |> unbox<Vec<uint8>>
    v8 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Vec<uint8> = null |> unbox<Vec<uint8>>
    v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v10 : Vec<uint8> = null |> unbox<Vec<uint8>>
    v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : Vec<uint8> = null |> unbox<Vec<uint8>>
    v11 
    #endif
#else
    let v12 : (uint8 []) = v3 |> System.IO.File.ReadAllBytes
    let v13 : string = "$0.to_vec()"
    let v14 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v12 v13
    v14 
    #endif
    |> fun x -> _v5 <- Some x
    let v15 : Vec<uint8> = _v5.Value
    let v16 : string = "std::string::String::from_utf8(v15)"
    let v17 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v16
    let v18 : string = "$0.unwrap()"
    let v19 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "fable_library_rust::String_::fromString($0)"
    let v21 : string = Fable.Core.RustInterop.emitRustExpr v19 v20
    v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : string = null |> unbox<string>
    v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : string = null |> unbox<string>
    v23 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v24 : string = null |> unbox<string>
    v24 
    #endif
#if FABLE_COMPILER_PYTHON
    let v25 : string = null |> unbox<string>
    v25 
    #endif
#else
    let v26 : string = v3 |> System.IO.File.ReadAllText
    v26 
    #endif
    |> fun x -> _v4 <- Some x
    let v27 : string = _v4.Value
    let v28 : string = "\n"
    let v29 : (string []) = v27.Split v28
    let v30 : int32 = v29.Length
    let v31 : (string []) = Array.zeroCreate<string> (v30)
    let v32 : Mut5 = {l0 = 0} : Mut5
    while method23(v30, v32) do
        let v34 : int32 = v32.l0
        let v35 : string = v29.[int v34]
        let v36 : string = v35.Trim ()
        v31.[int v34] <- v36
        let v37 : int32 = v34 + 1
        v32.l0 <- v37
        ()
    let v38 : int32 = v31.Length
    let v39 : (string []) = Array.zeroCreate<string> (v38)
    let v40 : Mut6 = {l0 = 0; l1 = 0} : Mut6
    while method61(v38, v40) do
        let v42 : int32 = v40.l0
        let v43 : int32 = v40.l1
        let v44 : string = v31.[int v42]
        let v45 : string = ""
        let v46 : bool = v45 <> v44
        let v48 : int32 =
            if v46 then
                v39.[int v43] <- v44
                let v47 : int32 = v43 + 1
                v47
            else
                v43
        let v49 : int32 = v42 + 1
        v40.l0 <- v49
        v40.l1 <- v48
        ()
    let v50 : int32 = v40.l1
    let v51 : (string []) = Array.zeroCreate<string> (v50)
    let v52 : Mut5 = {l0 = 0} : Mut5
    while method23(v50, v52) do
        let v54 : int32 = v52.l0
        let v55 : string = v39.[int v54]
        v51.[int v54] <- v55
        let v56 : int32 = v54 + 1
        v52.l0 <- v56
        ()
    let v57 : string seq = seq { for i = 0 to v51.Length - 1 do yield v51.[i] }
    let v58 : string = method53()
    let v59 : (string -> (string seq -> string)) = String.concat
    let v60 : (string seq -> string) = v59 v58
    let v61 : string = v60 v57
    let v62 : string = $"{v61}

"
    let v63 : System.Threading.CancellationToken option = None
    let v64 : (struct (string * string) []) = [||]
    let v65 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v66 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v67 : string option = None
    let v68 : bool = true
    let mutable _v68 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v69 : string = "cfg!(windows)"
    let v70 : bool = Fable.Core.RustInterop.emitRustExpr () v69
    v70 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v71 : bool = null |> unbox<bool>
    v71 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v72 : bool = null |> unbox<bool>
    v72 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v73 : bool = null |> unbox<bool>
    v73 
    #endif
#if FABLE_COMPILER_PYTHON
    let v74 : bool = null |> unbox<bool>
    v74 
    #endif
#else
    let v75 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v76 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v77 : bool = v76 v75
    v77 
    #endif
    |> fun x -> _v68 <- Some x
    let v78 : bool = _v68.Value
    let v81 : string =
        if v78 then
            let v79 : string = ".exe"
            v79
        else
            let v80 : string = ""
            v80
    let v82 : string = $"../vault/deps/hangulize/cmd/hangulize/hangulize{v81}"
    let v83 : string = method11(v0, v82)
    let v84 : string = $"{v83} {v1}"
    let v85 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = closure55(v62)
    let v86 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = Some v85 
    let v87 : bool = true
    let struct (v88 : int32, v89 : string) = method35(v63, v84, v64, v65, v86, v87, v67)
    let v90 : (string []) = v89.Split v28
    let v91 : int32 = v90.Length
    let v92 : string = ""
    let v93 : Mut7 = {l0 = 0; l1 = v92; l2 = 0; l3 = 0} : Mut7
    while method64(v38, v93) do
        let v95 : int32 = v93.l0
        let struct (v96 : string, v97 : int32, v98 : int32) = v93.l1, v93.l2, v93.l3
        let v99 : string = v31.[int v95]
        let v100 : bool = v99 = ""
        let struct (v114 : string, v115 : int32, v116 : int32) =
            if v100 then
                let v101 : string = $"{v96}
"
                let v102 : int32 = v97 + 1
                let v103 : int32 = v98 + 1
                struct (v101, v102, v103)
            else
                let v104 : int32 = v97 - v98
                let v105 : bool = v104 >= v91
                let v112 : string =
                    if v105 then
                        v96
                    else
                        let v106 : string = v90.[int v104]
                        let v107 : int32 = v91 - 1
                        let v108 : bool = v104 = v107
                        if v108 then
                            let v109 : string = $"{v96}{v106}"
                            v109
                        else
                            let v110 : string = $"{v96}{v106}
"
                            v110
                let v113 : int32 = v97 + 1
                struct (v112, v113, v98)
        let v117 : int32 = v95 + 1
        v93.l0 <- v117
        v93.l1 <- v114
        v93.l2 <- v115
        v93.l3 <- v116
        ()
    let struct (v118 : string, v119 : int32, v120 : int32) = v93.l1, v93.l2, v93.l3
    let v121 : bool = true
    let mutable _v121 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v122 : string = "std::fs::write(&*$0, &*$1).unwrap()"
    Fable.Core.RustInterop.emitRustExpr struct (v2, v118) v122
    () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    () 
    #endif
#else
    let v123 : string = method65(v118)
    System.IO.File.WriteAllText (v2, v123)
    () 
    #endif
    |> fun x -> _v121 <- Some x
    _v121.Value
    let v124 : US0 = US0_2
    let v125 : (unit -> string) = closure56()
    let v126 : (unit -> string) = closure57(v2, v88, v118)
    method3(v124, v125, v126)
    US19_0(v88, v118)
and closure58 () () : string =
    let v0 : string = "documents.files_fn / error"
    v0
and closure59 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: %A{v1} / result: {v0} / {v2 ()}"
    v3
and closure54 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : US18 =
    let struct (v6 : string, v7 : string) = method57(v5, v4, v0)
    let v8 : bool = true
    let mutable _v8 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : string = "&*$0"
    let v10 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v9
    let v11 : string = "String::from($0)"
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "std::path::PathBuf::from($0)"
    let v14 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "$0.exists()"
    let v16 : bool = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v19 : bool =
        if v16 then
            let v17 : string = "$0.is_file()"
            let v18 : bool = Fable.Core.RustInterop.emitRustExpr v14 v17
            v18
        else
            false
    v19 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : bool = null |> unbox<bool>
    v20 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v21 : bool = null |> unbox<bool>
    v21 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v22 : string = "fs"
    let v23 : IFsExistsSync = Fable.Core.JsInterop.importAll v22
    let v24 : string = "$0.existsSync($1)"
    let v25 : bool = Fable.Core.JsInterop.emitJsExpr struct (v23, v7) v24
    v25 
    #endif
#if FABLE_COMPILER_PYTHON
    let v26 : bool = null |> unbox<bool>
    v26 
    #endif
#else
    let v27 : (string -> bool) = System.IO.File.Exists
    let v28 : bool = v27 v7
    v28 
    #endif
    |> fun x -> _v8 <- Some x
    let v29 : bool = _v8.Value
    let v51 : bool =
        if v29 then
            let v30 : bool = true
            let mutable _v30 : bool option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v31 : string = "&*$0"
            let v32 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v31
            let v33 : string = "String::from($0)"
            let v34 : std_string_String = Fable.Core.RustInterop.emitRustExpr v32 v33
            let v35 : string = "std::path::PathBuf::from($0)"
            let v36 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v34 v35
            let v37 : string = "$0.exists()"
            let v38 : bool = Fable.Core.RustInterop.emitRustExpr v36 v37
            let v41 : bool =
                if v38 then
                    let v39 : string = "$0.is_file()"
                    let v40 : bool = Fable.Core.RustInterop.emitRustExpr v36 v39
                    v40
                else
                    false
            v41 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v42 : bool = null |> unbox<bool>
            v42 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v43 : bool = null |> unbox<bool>
            v43 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v44 : IFsExistsSync = Fable.Core.JsInterop.importAll v22
            let v45 : string = "$0.existsSync($1)"
            let v46 : bool = Fable.Core.JsInterop.emitJsExpr struct (v44, v6) v45
            v46 
            #endif
#if FABLE_COMPILER_PYTHON
            let v47 : bool = null |> unbox<bool>
            v47 
            #endif
#else
            let v48 : (string -> bool) = System.IO.File.Exists
            let v49 : bool = v48 v6
            v49 
            #endif
            |> fun x -> _v30 <- Some x
            let v50 : bool = _v30.Value
            v50
        else
            false
    let v239 : bool =
        if v51 then
            let v52 : bool = true
            let mutable _v52 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v53 : string = method18(v7)
            let v54 : string = method19()
            let v55 : bool = true
            let mutable _v55 : Result<regex_Regex, regex_Error> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v56 : string = method20()
            let v57 : string = $"regex::Regex::new(&$0)"
            let v58 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v56 v57
            v58 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v59 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v59 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v60 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v60 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v61 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v61 
            #endif
#if FABLE_COMPILER_PYTHON
            let v62 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v62 
            #endif
#else
            let v63 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v63 
            #endif
            |> fun x -> _v55 <- Some x
            let v64 : Result<regex_Regex, regex_Error> = _v55.Value
            let v65 : string = "$0.unwrap()"
            let v66 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v64 v65
            let v67 : string = $"$0.replace_all(&$1, &*$2)"
            let v68 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v66, v53, v54) v67
            let v69 : string = "String::from($0)"
            let v70 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v69
            let v71 : string = "fable_library_rust::String_::fromString($0)"
            let v72 : string = Fable.Core.RustInterop.emitRustExpr v70 v71
            v72 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v73 : string = null |> unbox<string>
            v73 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v74 : string = null |> unbox<string>
            v74 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v75 : string = null |> unbox<string>
            v75 
            #endif
#if FABLE_COMPILER_PYTHON
            let v76 : string = null |> unbox<string>
            v76 
            #endif
#else
            let v77 : string = method21()
            let v78 : string = "^\\\\\\\\\\?\\\\"
            let v79 : string = System.Text.RegularExpressions.Regex.Replace (v7, v78, v77)
            v79 
            #endif
            |> fun x -> _v52 <- Some x
            let v80 : string = _v52.Value
            let v81 : string = $"{v80.[0] |> string |> _.ToLower()}{v80.[1..]}"
            let v82 : string = "\\"
            let v83 : string = "/"
            let v84 : string = v81.Replace (v82, v83)
            let v85 : string = "std::fs::File::open(&*v84)"
            let v86 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v85
            let v87 : string = "$0.unwrap()"
            let v88 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v86 v87
            let v89 : string = "std::io::BufReader::new(v88)"
            let v90 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v89
            let v91 : string = "true; let mut v90 = v90"
            let v92 : bool = Fable.Core.RustInterop.emitRustExpr () v91
            let v93 : string = "sha2::Digest::new()"
            let v94 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v93
            let v95 : string = "true; let mut v94 = v94"
            let v96 : bool = Fable.Core.RustInterop.emitRustExpr () v95
            let v97 : unativeint = unativeint 0
            let v98 : string = "[$0; 1024]"
            let v99 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v98
            let v100 : string = "true; loop { // rust.loop"
            let v101 : bool = Fable.Core.RustInterop.emitRustExpr () v100
            let v102 : string = "true; let mut v99 = v99"
            let v103 : bool = Fable.Core.RustInterop.emitRustExpr () v102
            let v104 : string = "std::io::Read::read(&mut v90, &mut v99)"
            let v105 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v104
            let v106 : string = "$0.unwrap()"
            let v107 : unativeint = Fable.Core.RustInterop.emitRustExpr v105 v106
            let v108 : bool = v107 = v97
            if v108 then
                let v109 : string = "true; break"
                let v110 : bool = Fable.Core.RustInterop.emitRustExpr () v109
                ()
            let v111 : string = "v99.len()"
            let v112 : unativeint = Fable.Core.RustInterop.emitRustExpr () v111
            let v113 : uint8 = uint8 v112 
            let v114 : unativeint = unativeint v107
            let v115 : unativeint = v114 |> unbox<unativeint>
            let v116 : bool = v115 = v112
            let v121 : Ref<Slice'<uint8>> =
                if v116 then
                    let v117 : string = "&v99[v97..]"
                    let v118 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v117
                    v118
                else
                    let v119 : string = "&v99[$0..$1]"
                    let v120 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v97, v114) v119
                    v120
            let v122 : string = "sha2::Digest::update(&mut v94, v121)"
            Fable.Core.RustInterop.emitRustExpr () v122
            let v123 : string = "true; } // rust.loop"
            let v124 : bool = Fable.Core.RustInterop.emitRustExpr () v123
            let v125 : string = "true; } // rust.loop"
            let v126 : bool = Fable.Core.RustInterop.emitRustExpr () v125
            let v127 : string = "true; } // rust.loop"
            let v128 : bool = Fable.Core.RustInterop.emitRustExpr () v127
            let v129 : string = "true; { // rust.loop"
            let v130 : bool = Fable.Core.RustInterop.emitRustExpr () v129
            let v131 : string = "true; { // rust.loop"
            let v132 : bool = Fable.Core.RustInterop.emitRustExpr () v131
            let v133 : string = "&sha2::Digest::finalize(v94)"
            let v134 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v133
            let v135 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v136 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v134 v135
            let v137 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
            let v138 : (uint8 -> string) = closure50()
            let v139 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v136, v138) v137
            let v140 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v141 : (string []) = Fable.Core.RustInterop.emitRustExpr v139 v140
            let v142 : string seq = seq { for i = 0 to v141.Length - 1 do yield v141.[i] }
            let v143 : string = method58()
            let v144 : (string -> (string seq -> string)) = String.concat
            let v145 : (string seq -> string) = v144 v143
            let v146 : string = v145 v142
            let v147 : bool = true
            let mutable _v147 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v148 : string = method18(v6)
            let v149 : string = method19()
            let v150 : bool = true
            let mutable _v150 : Result<regex_Regex, regex_Error> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v151 : string = method20()
            let v152 : string = $"regex::Regex::new(&$0)"
            let v153 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v151 v152
            v153 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v154 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v154 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v155 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v155 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v156 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v156 
            #endif
#if FABLE_COMPILER_PYTHON
            let v157 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v157 
            #endif
#else
            let v158 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v158 
            #endif
            |> fun x -> _v150 <- Some x
            let v159 : Result<regex_Regex, regex_Error> = _v150.Value
            let v160 : string = "$0.unwrap()"
            let v161 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v159 v160
            let v162 : string = $"$0.replace_all(&$1, &*$2)"
            let v163 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v161, v148, v149) v162
            let v164 : string = "String::from($0)"
            let v165 : std_string_String = Fable.Core.RustInterop.emitRustExpr v163 v164
            let v166 : string = "fable_library_rust::String_::fromString($0)"
            let v167 : string = Fable.Core.RustInterop.emitRustExpr v165 v166
            v167 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v168 : string = null |> unbox<string>
            v168 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v169 : string = null |> unbox<string>
            v169 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v170 : string = null |> unbox<string>
            v170 
            #endif
#if FABLE_COMPILER_PYTHON
            let v171 : string = null |> unbox<string>
            v171 
            #endif
#else
            let v172 : string = method21()
            let v173 : string = System.Text.RegularExpressions.Regex.Replace (v6, v78, v172)
            v173 
            #endif
            |> fun x -> _v147 <- Some x
            let v174 : string = _v147.Value
            let v175 : string = $"{v174.[0] |> string |> _.ToLower()}{v174.[1..]}"
            let v176 : string = v175.Replace (v82, v83)
            let v177 : string = "std::fs::File::open(&*v176)"
            let v178 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v177
            let v179 : string = "$0.unwrap()"
            let v180 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v178 v179
            let v181 : string = "std::io::BufReader::new(v180)"
            let v182 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v181
            let v183 : string = "true; let mut v182 = v182"
            let v184 : bool = Fable.Core.RustInterop.emitRustExpr () v183
            let v185 : string = "sha2::Digest::new()"
            let v186 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v185
            let v187 : string = "true; let mut v186 = v186"
            let v188 : bool = Fable.Core.RustInterop.emitRustExpr () v187
            let v189 : unativeint = unativeint 0
            let v190 : string = "[$0; 1024]"
            let v191 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v190
            let v192 : string = "true; loop { // rust.loop"
            let v193 : bool = Fable.Core.RustInterop.emitRustExpr () v192
            let v194 : string = "true; let mut v191 = v191"
            let v195 : bool = Fable.Core.RustInterop.emitRustExpr () v194
            let v196 : string = "std::io::Read::read(&mut v182, &mut v191)"
            let v197 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v196
            let v198 : string = "$0.unwrap()"
            let v199 : unativeint = Fable.Core.RustInterop.emitRustExpr v197 v198
            let v200 : bool = v199 = v189
            if v200 then
                let v201 : string = "true; break"
                let v202 : bool = Fable.Core.RustInterop.emitRustExpr () v201
                ()
            let v203 : string = "v191.len()"
            let v204 : unativeint = Fable.Core.RustInterop.emitRustExpr () v203
            let v205 : uint8 = uint8 v204 
            let v206 : unativeint = unativeint v199
            let v207 : unativeint = v206 |> unbox<unativeint>
            let v208 : bool = v207 = v204
            let v213 : Ref<Slice'<uint8>> =
                if v208 then
                    let v209 : string = "&v191[v189..]"
                    let v210 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v209
                    v210
                else
                    let v211 : string = "&v191[$0..$1]"
                    let v212 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v189, v206) v211
                    v212
            let v214 : string = "sha2::Digest::update(&mut v186, v213)"
            Fable.Core.RustInterop.emitRustExpr () v214
            let v215 : string = "true; } // rust.loop"
            let v216 : bool = Fable.Core.RustInterop.emitRustExpr () v215
            let v217 : string = "true; } // rust.loop"
            let v218 : bool = Fable.Core.RustInterop.emitRustExpr () v217
            let v219 : string = "true; } // rust.loop"
            let v220 : bool = Fable.Core.RustInterop.emitRustExpr () v219
            let v221 : string = "true; { // rust.loop"
            let v222 : bool = Fable.Core.RustInterop.emitRustExpr () v221
            let v223 : string = "true; { // rust.loop"
            let v224 : bool = Fable.Core.RustInterop.emitRustExpr () v223
            let v225 : string = "&sha2::Digest::finalize(v186)"
            let v226 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v225
            let v227 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v228 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v226 v227
            let v229 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
            let v230 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v228, v138) v229
            let v231 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v232 : (string []) = Fable.Core.RustInterop.emitRustExpr v230 v231
            let v233 : string seq = seq { for i = 0 to v232.Length - 1 do yield v232.[i] }
            let v234 : string = method58()
            let v235 : (string -> (string seq -> string)) = String.concat
            let v236 : (string seq -> string) = v235 v234
            let v237 : string = v236 v233
            let v238 : bool = v146 = v237
            v238
        else
            false
    let v240 : bool = v239 = false
    if v240 then
        let v241 : US19 = method60(v2, v3, v7, v4)
        match v241 with
        | US19_1(v282, v283) -> (* Error *)
            let v284 : (string * string) = v7, v283
            let v285 : Result<string, (string * string)> = Error v284
            US18_0(v285)
        | US19_0(v242, v243) -> (* Ok *)
            let v244 : bool = v242 <> 0
            if v244 then
                let v245 : US0 = US0_2
                let v246 : (unit -> string) = closure58()
                let v247 : (unit -> string) = closure59(v243, v242)
                method3(v245, v246, v247)
                let v248 : (string * string) = v7, v243
                let v249 : Result<string, (string * string)> = Error v248
                US18_0(v249)
            else
                let v251 : bool = true
                let mutable _v251 : bool option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v252 : string = "&*$0"
                let v253 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v252
                let v254 : string = "String::from($0)"
                let v255 : std_string_String = Fable.Core.RustInterop.emitRustExpr v253 v254
                let v256 : string = "std::path::PathBuf::from($0)"
                let v257 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v255 v256
                let v258 : string = "$0.exists()"
                let v259 : bool = Fable.Core.RustInterop.emitRustExpr v257 v258
                let v262 : bool =
                    if v259 then
                        let v260 : string = "$0.is_file()"
                        let v261 : bool = Fable.Core.RustInterop.emitRustExpr v257 v260
                        v261
                    else
                        false
                v262 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v263 : bool = null |> unbox<bool>
                v263 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v264 : bool = null |> unbox<bool>
                v264 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v265 : IFsExistsSync = Fable.Core.JsInterop.importAll v22
                let v266 : string = "$0.existsSync($1)"
                let v267 : bool = Fable.Core.JsInterop.emitJsExpr struct (v265, v7) v266
                v267 
                #endif
#if FABLE_COMPILER_PYTHON
                let v268 : bool = null |> unbox<bool>
                v268 
                #endif
#else
                let v269 : (string -> bool) = System.IO.File.Exists
                let v270 : bool = v269 v7
                v270 
                #endif
                |> fun x -> _v251 <- Some x
                let v271 : bool = _v251.Value
                if v271 then
                    let v272 : bool = true
                    let mutable _v272 : unit option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v273 : string = method59(v6)
                    let v274 : string = "std::fs::copy(&*$0, &*v273)"
                    let v275 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v7 v274
                    let v276 : string = "$0.unwrap()"
                    let v277 : uint64 = Fable.Core.RustInterop.emitRustExpr v275 v276
                    () 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    null |> unbox<unit>
                    () 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    null |> unbox<unit>
                    () 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    null |> unbox<unit>
                    () 
                    #endif
#if FABLE_COMPILER_PYTHON
                    null |> unbox<unit>
                    () 
                    #endif
#else
                    System.IO.File.Copy (v7, v6, true)
                    () 
                    #endif
                    |> fun x -> _v272 <- Some x
                    _v272.Value
                    ()
                else
                    let v278 : string = $"documents.files_fn / {v7} should exist"
                    failwith<unit> v278
                let v279 : Result<string, (string * string)> = Ok v7
                US18_0(v279)
    else
        US18_1
and closure53 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : string) : (string -> US18) =
    closure54(v0, v1, v2, v3, v4)
and closure62 () () : string =
    let v0 : string = "documents.crowbook / result contains ERROR"
    v0
and closure63 (v0 : string, v1 : string, v2 : int32) () : string =
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"exit_code: %A{v2} / output_path: {v0} / result: {v1} / {v3 ()}"
    v4
and method66 (v0 : bool, v1 : string, v2 : string, v3 : string, v4 : string) : US19 =
    let v5 : bool = "html" = v4
    let v47 : string =
        if v5 then
            let v6 : string = $"--set"
            let v7 : string = $" html.css.add \\\"' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} pre {{ background-color: #1b1b1b; padding: 10px; }} '\\\""
            let v8 : string = v6 + v7
            let v9 : string = $" rendering.num_depth 6"
            let v10 : string = $" rendering.highlight.theme \\\"Solarized (dark)\\\""
            let v11 : string = v9 + v10
            let v12 : string = v8 + v11
            v12
        else
            let v13 : bool = "pdf" = v4
            if v13 then
                let v14 : string = $"--set"
                let v15 : string = $" tex.paper.size a4paper"
                let v16 : string = v14 + v15
                let v17 : string = $" tex.template.add \"\\pagenumbering{{gobble}}\""
                let v18 : string = v16 + v17
                let v19 : bool = v0 = false
                let v28 : string =
                    if v19 then
                        let v20 : string = ""
                        v20
                    else
                        let v21 : string = $" tex.template.add \"\\usepackage{{polyglossia}}\""
                        let v22 : string = $" tex.template.add \"\\setmainlanguage{{korean}}\""
                        let v23 : string = v21 + v22
                        let v24 : string = $" tex.template.add \"\\setmainfont{{NanumGothicCoding}}\""
                        let v25 : string = v23 + v24
                        let v26 : string = $" tex.font.size 12"
                        let v27 : string = v25 + v26
                        v27
                let v29 : string = v18 + v28
                let v30 : string = $" rendering.num_depth 6"
                let v31 : string = $" rendering.highlight.theme \\\"Solarized (dark)\\\""
                let v32 : string = v30 + v31
                let v33 : string = v29 + v32
                v33
            else
                let v34 : bool = "epub" = v4
                if v34 then
                    let v35 : string = $"--set"
                    let v36 : string = $" epub.version 3"
                    let v37 : string = v35 + v36
                    let v38 : string = $" html.css.add \\\"' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} '\\\""
                    let v39 : string = v37 + v38
                    let v40 : string = $" rendering.num_depth 6"
                    let v41 : string = $" rendering.highlight.theme \\\"Solarized (dark)\\\""
                    let v42 : string = v40 + v41
                    let v43 : string = v39 + v42
                    v43
                else
                    let v44 : string = ""
                    v44
    let v48 : System.Threading.CancellationToken option = None
    let v49 : (struct (string * string) []) = [||]
    let v50 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v51 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v52 : string option = None
    let v53 : string = $"crowbook --verbose --to {v4}"
    let v54 : string = $" --single \"{v2}\" --output \"{v1}\" {v47}"
    let v55 : string = v53 + v54
    let v56 : string option = Some v3 
    let v57 : bool = true
    let struct (v58 : int32, v59 : string) = method35(v48, v55, v49, v50, v51, v57, v56)
    let v60 : string = "ERROR"
    let v61 : bool = v59.Contains v60
    if v61 then
        let v62 : US0 = US0_3
        let v63 : (unit -> string) = closure62()
        let v64 : (unit -> string) = closure63(v1, v59, v58)
        method3(v62, v63, v64)
        US19_1(v58, v59)
    else
        US19_0(v58, v59)
and closure61 (v0 : string, v1 : string, v2 : bool, v3 : string) (v4 : string) : US18 =
    let struct (v5 : string, v6 : string) = method57(v4, v3, v0)
    let v7 : bool = true
    let mutable _v7 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "&*$0"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v8
    let v10 : string = "String::from($0)"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "std::path::PathBuf::from($0)"
    let v13 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "$0.exists()"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v18 : bool =
        if v15 then
            let v16 : string = "$0.is_file()"
            let v17 : bool = Fable.Core.RustInterop.emitRustExpr v13 v16
            v17
        else
            false
    v18 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v19 : bool = null |> unbox<bool>
    v19 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v20 : bool = null |> unbox<bool>
    v20 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : string = "fs"
    let v22 : IFsExistsSync = Fable.Core.JsInterop.importAll v21
    let v23 : string = "$0.existsSync($1)"
    let v24 : bool = Fable.Core.JsInterop.emitJsExpr struct (v22, v6) v23
    v24 
    #endif
#if FABLE_COMPILER_PYTHON
    let v25 : bool = null |> unbox<bool>
    v25 
    #endif
#else
    let v26 : (string -> bool) = System.IO.File.Exists
    let v27 : bool = v26 v6
    v27 
    #endif
    |> fun x -> _v7 <- Some x
    let v28 : bool = _v7.Value
    let v50 : bool =
        if v28 then
            let v29 : bool = true
            let mutable _v29 : bool option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v30 : string = "&*$0"
            let v31 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v30
            let v32 : string = "String::from($0)"
            let v33 : std_string_String = Fable.Core.RustInterop.emitRustExpr v31 v32
            let v34 : string = "std::path::PathBuf::from($0)"
            let v35 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v33 v34
            let v36 : string = "$0.exists()"
            let v37 : bool = Fable.Core.RustInterop.emitRustExpr v35 v36
            let v40 : bool =
                if v37 then
                    let v38 : string = "$0.is_file()"
                    let v39 : bool = Fable.Core.RustInterop.emitRustExpr v35 v38
                    v39
                else
                    false
            v40 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v41 : bool = null |> unbox<bool>
            v41 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v42 : bool = null |> unbox<bool>
            v42 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v43 : IFsExistsSync = Fable.Core.JsInterop.importAll v21
            let v44 : string = "$0.existsSync($1)"
            let v45 : bool = Fable.Core.JsInterop.emitJsExpr struct (v43, v5) v44
            v45 
            #endif
#if FABLE_COMPILER_PYTHON
            let v46 : bool = null |> unbox<bool>
            v46 
            #endif
#else
            let v47 : (string -> bool) = System.IO.File.Exists
            let v48 : bool = v47 v5
            v48 
            #endif
            |> fun x -> _v29 <- Some x
            let v49 : bool = _v29.Value
            v49
        else
            false
    let v238 : bool =
        if v50 then
            let v51 : bool = true
            let mutable _v51 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v52 : string = method18(v6)
            let v53 : string = method19()
            let v54 : bool = true
            let mutable _v54 : Result<regex_Regex, regex_Error> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v55 : string = method20()
            let v56 : string = $"regex::Regex::new(&$0)"
            let v57 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v55 v56
            v57 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v58 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v58 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v59 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v59 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v60 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v60 
            #endif
#if FABLE_COMPILER_PYTHON
            let v61 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v61 
            #endif
#else
            let v62 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v62 
            #endif
            |> fun x -> _v54 <- Some x
            let v63 : Result<regex_Regex, regex_Error> = _v54.Value
            let v64 : string = "$0.unwrap()"
            let v65 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v63 v64
            let v66 : string = $"$0.replace_all(&$1, &*$2)"
            let v67 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v65, v52, v53) v66
            let v68 : string = "String::from($0)"
            let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr v67 v68
            let v70 : string = "fable_library_rust::String_::fromString($0)"
            let v71 : string = Fable.Core.RustInterop.emitRustExpr v69 v70
            v71 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v72 : string = null |> unbox<string>
            v72 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v73 : string = null |> unbox<string>
            v73 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v74 : string = null |> unbox<string>
            v74 
            #endif
#if FABLE_COMPILER_PYTHON
            let v75 : string = null |> unbox<string>
            v75 
            #endif
#else
            let v76 : string = method21()
            let v77 : string = "^\\\\\\\\\\?\\\\"
            let v78 : string = System.Text.RegularExpressions.Regex.Replace (v6, v77, v76)
            v78 
            #endif
            |> fun x -> _v51 <- Some x
            let v79 : string = _v51.Value
            let v80 : string = $"{v79.[0] |> string |> _.ToLower()}{v79.[1..]}"
            let v81 : string = "\\"
            let v82 : string = "/"
            let v83 : string = v80.Replace (v81, v82)
            let v84 : string = "std::fs::File::open(&*v83)"
            let v85 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v84
            let v86 : string = "$0.unwrap()"
            let v87 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v85 v86
            let v88 : string = "std::io::BufReader::new(v87)"
            let v89 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v88
            let v90 : string = "true; let mut v89 = v89"
            let v91 : bool = Fable.Core.RustInterop.emitRustExpr () v90
            let v92 : string = "sha2::Digest::new()"
            let v93 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v92
            let v94 : string = "true; let mut v93 = v93"
            let v95 : bool = Fable.Core.RustInterop.emitRustExpr () v94
            let v96 : unativeint = unativeint 0
            let v97 : string = "[$0; 1024]"
            let v98 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v97
            let v99 : string = "true; loop { // rust.loop"
            let v100 : bool = Fable.Core.RustInterop.emitRustExpr () v99
            let v101 : string = "true; let mut v98 = v98"
            let v102 : bool = Fable.Core.RustInterop.emitRustExpr () v101
            let v103 : string = "std::io::Read::read(&mut v89, &mut v98)"
            let v104 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v103
            let v105 : string = "$0.unwrap()"
            let v106 : unativeint = Fable.Core.RustInterop.emitRustExpr v104 v105
            let v107 : bool = v106 = v96
            if v107 then
                let v108 : string = "true; break"
                let v109 : bool = Fable.Core.RustInterop.emitRustExpr () v108
                ()
            let v110 : string = "v98.len()"
            let v111 : unativeint = Fable.Core.RustInterop.emitRustExpr () v110
            let v112 : uint8 = uint8 v111 
            let v113 : unativeint = unativeint v106
            let v114 : unativeint = v113 |> unbox<unativeint>
            let v115 : bool = v114 = v111
            let v120 : Ref<Slice'<uint8>> =
                if v115 then
                    let v116 : string = "&v98[v96..]"
                    let v117 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v116
                    v117
                else
                    let v118 : string = "&v98[$0..$1]"
                    let v119 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v96, v113) v118
                    v119
            let v121 : string = "sha2::Digest::update(&mut v93, v120)"
            Fable.Core.RustInterop.emitRustExpr () v121
            let v122 : string = "true; } // rust.loop"
            let v123 : bool = Fable.Core.RustInterop.emitRustExpr () v122
            let v124 : string = "true; } // rust.loop"
            let v125 : bool = Fable.Core.RustInterop.emitRustExpr () v124
            let v126 : string = "true; } // rust.loop"
            let v127 : bool = Fable.Core.RustInterop.emitRustExpr () v126
            let v128 : string = "true; { // rust.loop"
            let v129 : bool = Fable.Core.RustInterop.emitRustExpr () v128
            let v130 : string = "true; { // rust.loop"
            let v131 : bool = Fable.Core.RustInterop.emitRustExpr () v130
            let v132 : string = "&sha2::Digest::finalize(v93)"
            let v133 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v132
            let v134 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v135 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v133 v134
            let v136 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
            let v137 : (uint8 -> string) = closure50()
            let v138 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v135, v137) v136
            let v139 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v140 : (string []) = Fable.Core.RustInterop.emitRustExpr v138 v139
            let v141 : string seq = seq { for i = 0 to v140.Length - 1 do yield v140.[i] }
            let v142 : string = method58()
            let v143 : (string -> (string seq -> string)) = String.concat
            let v144 : (string seq -> string) = v143 v142
            let v145 : string = v144 v141
            let v146 : bool = true
            let mutable _v146 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v147 : string = method18(v5)
            let v148 : string = method19()
            let v149 : bool = true
            let mutable _v149 : Result<regex_Regex, regex_Error> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v150 : string = method20()
            let v151 : string = $"regex::Regex::new(&$0)"
            let v152 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v150 v151
            v152 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v153 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v153 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v154 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v154 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v155 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v155 
            #endif
#if FABLE_COMPILER_PYTHON
            let v156 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v156 
            #endif
#else
            let v157 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v157 
            #endif
            |> fun x -> _v149 <- Some x
            let v158 : Result<regex_Regex, regex_Error> = _v149.Value
            let v159 : string = "$0.unwrap()"
            let v160 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v158 v159
            let v161 : string = $"$0.replace_all(&$1, &*$2)"
            let v162 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v160, v147, v148) v161
            let v163 : string = "String::from($0)"
            let v164 : std_string_String = Fable.Core.RustInterop.emitRustExpr v162 v163
            let v165 : string = "fable_library_rust::String_::fromString($0)"
            let v166 : string = Fable.Core.RustInterop.emitRustExpr v164 v165
            v166 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v167 : string = null |> unbox<string>
            v167 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v168 : string = null |> unbox<string>
            v168 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v169 : string = null |> unbox<string>
            v169 
            #endif
#if FABLE_COMPILER_PYTHON
            let v170 : string = null |> unbox<string>
            v170 
            #endif
#else
            let v171 : string = method21()
            let v172 : string = System.Text.RegularExpressions.Regex.Replace (v5, v77, v171)
            v172 
            #endif
            |> fun x -> _v146 <- Some x
            let v173 : string = _v146.Value
            let v174 : string = $"{v173.[0] |> string |> _.ToLower()}{v173.[1..]}"
            let v175 : string = v174.Replace (v81, v82)
            let v176 : string = "std::fs::File::open(&*v175)"
            let v177 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v176
            let v178 : string = "$0.unwrap()"
            let v179 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v177 v178
            let v180 : string = "std::io::BufReader::new(v179)"
            let v181 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v180
            let v182 : string = "true; let mut v181 = v181"
            let v183 : bool = Fable.Core.RustInterop.emitRustExpr () v182
            let v184 : string = "sha2::Digest::new()"
            let v185 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v184
            let v186 : string = "true; let mut v185 = v185"
            let v187 : bool = Fable.Core.RustInterop.emitRustExpr () v186
            let v188 : unativeint = unativeint 0
            let v189 : string = "[$0; 1024]"
            let v190 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v189
            let v191 : string = "true; loop { // rust.loop"
            let v192 : bool = Fable.Core.RustInterop.emitRustExpr () v191
            let v193 : string = "true; let mut v190 = v190"
            let v194 : bool = Fable.Core.RustInterop.emitRustExpr () v193
            let v195 : string = "std::io::Read::read(&mut v181, &mut v190)"
            let v196 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v195
            let v197 : string = "$0.unwrap()"
            let v198 : unativeint = Fable.Core.RustInterop.emitRustExpr v196 v197
            let v199 : bool = v198 = v188
            if v199 then
                let v200 : string = "true; break"
                let v201 : bool = Fable.Core.RustInterop.emitRustExpr () v200
                ()
            let v202 : string = "v190.len()"
            let v203 : unativeint = Fable.Core.RustInterop.emitRustExpr () v202
            let v204 : uint8 = uint8 v203 
            let v205 : unativeint = unativeint v198
            let v206 : unativeint = v205 |> unbox<unativeint>
            let v207 : bool = v206 = v203
            let v212 : Ref<Slice'<uint8>> =
                if v207 then
                    let v208 : string = "&v190[v188..]"
                    let v209 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v208
                    v209
                else
                    let v210 : string = "&v190[$0..$1]"
                    let v211 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v188, v205) v210
                    v211
            let v213 : string = "sha2::Digest::update(&mut v185, v212)"
            Fable.Core.RustInterop.emitRustExpr () v213
            let v214 : string = "true; } // rust.loop"
            let v215 : bool = Fable.Core.RustInterop.emitRustExpr () v214
            let v216 : string = "true; } // rust.loop"
            let v217 : bool = Fable.Core.RustInterop.emitRustExpr () v216
            let v218 : string = "true; } // rust.loop"
            let v219 : bool = Fable.Core.RustInterop.emitRustExpr () v218
            let v220 : string = "true; { // rust.loop"
            let v221 : bool = Fable.Core.RustInterop.emitRustExpr () v220
            let v222 : string = "true; { // rust.loop"
            let v223 : bool = Fable.Core.RustInterop.emitRustExpr () v222
            let v224 : string = "&sha2::Digest::finalize(v185)"
            let v225 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v224
            let v226 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v227 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v225 v226
            let v228 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
            let v229 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v227, v137) v228
            let v230 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v231 : (string []) = Fable.Core.RustInterop.emitRustExpr v229 v230
            let v232 : string seq = seq { for i = 0 to v231.Length - 1 do yield v231.[i] }
            let v233 : string = method58()
            let v234 : (string -> (string seq -> string)) = String.concat
            let v235 : (string seq -> string) = v234 v233
            let v236 : string = v235 v232
            let v237 : bool = v145 = v236
            v237
        else
            false
    let v239 : bool = v238 = false
    if v239 then
        let v240 : US19 = method66(v2, v6, v3, v1, v4)
        match v240 with
        | US19_1(v281, v282) -> (* Error *)
            let v283 : (string * string) = v6, v282
            let v284 : Result<string, (string * string)> = Error v283
            US18_0(v284)
        | US19_0(v241, v242) -> (* Ok *)
            let v243 : bool = v241 <> 0
            if v243 then
                let v244 : US0 = US0_2
                let v245 : (unit -> string) = closure58()
                let v246 : (unit -> string) = closure59(v242, v241)
                method3(v244, v245, v246)
                let v247 : (string * string) = v6, v242
                let v248 : Result<string, (string * string)> = Error v247
                US18_0(v248)
            else
                let v250 : bool = true
                let mutable _v250 : bool option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v251 : string = "&*$0"
                let v252 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v251
                let v253 : string = "String::from($0)"
                let v254 : std_string_String = Fable.Core.RustInterop.emitRustExpr v252 v253
                let v255 : string = "std::path::PathBuf::from($0)"
                let v256 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v254 v255
                let v257 : string = "$0.exists()"
                let v258 : bool = Fable.Core.RustInterop.emitRustExpr v256 v257
                let v261 : bool =
                    if v258 then
                        let v259 : string = "$0.is_file()"
                        let v260 : bool = Fable.Core.RustInterop.emitRustExpr v256 v259
                        v260
                    else
                        false
                v261 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v262 : bool = null |> unbox<bool>
                v262 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v263 : bool = null |> unbox<bool>
                v263 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v264 : IFsExistsSync = Fable.Core.JsInterop.importAll v21
                let v265 : string = "$0.existsSync($1)"
                let v266 : bool = Fable.Core.JsInterop.emitJsExpr struct (v264, v6) v265
                v266 
                #endif
#if FABLE_COMPILER_PYTHON
                let v267 : bool = null |> unbox<bool>
                v267 
                #endif
#else
                let v268 : (string -> bool) = System.IO.File.Exists
                let v269 : bool = v268 v6
                v269 
                #endif
                |> fun x -> _v250 <- Some x
                let v270 : bool = _v250.Value
                if v270 then
                    let v271 : bool = true
                    let mutable _v271 : unit option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v272 : string = method59(v5)
                    let v273 : string = "std::fs::copy(&*$0, &*v272)"
                    let v274 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v6 v273
                    let v275 : string = "$0.unwrap()"
                    let v276 : uint64 = Fable.Core.RustInterop.emitRustExpr v274 v275
                    () 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    null |> unbox<unit>
                    () 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    null |> unbox<unit>
                    () 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    null |> unbox<unit>
                    () 
                    #endif
#if FABLE_COMPILER_PYTHON
                    null |> unbox<unit>
                    () 
                    #endif
#else
                    System.IO.File.Copy (v6, v5, true)
                    () 
                    #endif
                    |> fun x -> _v271 <- Some x
                    _v271.Value
                    ()
                else
                    let v277 : string = $"documents.files_fn / {v6} should exist"
                    failwith<unit> v277
                let v278 : Result<string, (string * string)> = Ok v6
                US18_0(v278)
    else
        US18_1
and closure60 (v0 : string, v1 : string, v2 : bool) (v3 : string) : (string -> US18) =
    closure61(v0, v1, v2, v3)
and closure64 () () : string =
    let v0 : string = "documents.run / par_map / files' = [] / listm.iter"
    v0
and closure65 (v0 : string, v1 : string) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"output_path: %A{v1} / output_cache_path: {v0} / {v2 ()}"
    v3
and method67 (v0 : UH2, v1 : UH3 list) : UH3 list =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : UH3 list = method67(v3, v1)
        let v5 : UH3 list = v2 :: v4 
        v5
    | UH2_0 -> (* Nil *)
        v1
and method68 (v0 : int32, v1 : Mut8) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method69 (v0 : UH3, v1 : struct (string * string * (string -> (string -> US18))) list) : struct (string * string * (string -> (string -> US18))) list =
    match v0 with
    | UH3_1(v2, v3, v4, v5) -> (* Cons *)
        let v6 : struct (string * string * (string -> (string -> US18))) list = method69(v5, v1)
        let v7 : struct (string * string * (string -> (string -> US18))) list = struct (v2, v3, v4) :: v6 
        v7
    | UH3_0 -> (* Nil *)
        v1
and closure66 () struct (v0 : string, v1 : string, v2 : (string -> (string -> US18))) : Result<string, (string * string)> option =
    let v3 : (string -> US18) = v2 v1
    let v4 : US18 = v3 v0
    match v4 with
    | US18_1 -> (* None *)
        let v7 : Result<string, (string * string)> option = None
        v7
    | US18_0(v5) -> (* Some *)
        let v6 : Result<string, (string * string)> option = Some v5 
        v6
and method70 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method71 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and closure22 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> =
    let v6 : bool = true
    let mutable _v6 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = method17(v5)
    let v8 : string = "&*$0"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "String::from($0)"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "std::path::PathBuf::from($0)"
    let v13 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "$0.exists()"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : bool = v15 = false
    let v172 : string =
        if v16 then
            let v17 : bool = true
            let mutable _v17 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18 : string = "std::env::current_dir()"
            let v19 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v18
            let v20 : string = "$0.unwrap()"
            let v21 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v19 v20
            let v22 : string = "$0.display()"
            let v23 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v21 v22
            let v24 : bool = true
            let mutable _v24 : std_string_String option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v25 : string = "format!(\"{}\", $0)"
            let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v23 v25
            v26 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v27 : string = "format!(\"{}\", $0)"
            let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v23 v27
            v28 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v29 : string = "format!(\"{}\", $0)"
            let v30 : std_string_String = Fable.Core.RustInterop.emitRustExpr v23 v29
            v30 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v31 : std_string_String = null |> unbox<std_string_String>
            v31 
            #endif
#if FABLE_COMPILER_PYTHON
            let v32 : std_string_String = null |> unbox<std_string_String>
            v32 
            #endif
#else
            let v33 : std_string_String = null |> unbox<std_string_String>
            v33 
            #endif
            |> fun x -> _v24 <- Some x
            let v34 : std_string_String = _v24.Value
            let v35 : string = "fable_library_rust::String_::fromString($0)"
            let v36 : string = Fable.Core.RustInterop.emitRustExpr v34 v35
            v36 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v37 : string = null |> unbox<string>
            v37 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v38 : string = null |> unbox<string>
            v38 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v39 : string = null |> unbox<string>
            v39 
            #endif
#if FABLE_COMPILER_PYTHON
            let v40 : string = null |> unbox<string>
            v40 
            #endif
#else
            let v41 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v42 : string = v41 ()
            v42 
            #endif
            |> fun x -> _v17 <- Some x
            let v43 : string = _v17.Value
            let v44 : string = method11(v43, v7)
            let v45 : bool = true
            let mutable _v45 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v46 : string = method18(v44)
            let v47 : string = method19()
            let v48 : bool = true
            let mutable _v48 : Result<regex_Regex, regex_Error> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v49 : string = method20()
            let v50 : string = $"regex::Regex::new(&$0)"
            let v51 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v49 v50
            v51 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v52 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v52 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v53 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v53 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v54 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v54 
            #endif
#if FABLE_COMPILER_PYTHON
            let v55 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v55 
            #endif
#else
            let v56 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v56 
            #endif
            |> fun x -> _v48 <- Some x
            let v57 : Result<regex_Regex, regex_Error> = _v48.Value
            let v58 : string = "$0.unwrap()"
            let v59 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v57 v58
            let v60 : string = $"$0.replace_all(&$1, &*$2)"
            let v61 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v59, v46, v47) v60
            let v62 : string = "String::from($0)"
            let v63 : std_string_String = Fable.Core.RustInterop.emitRustExpr v61 v62
            let v64 : string = "fable_library_rust::String_::fromString($0)"
            let v65 : string = Fable.Core.RustInterop.emitRustExpr v63 v64
            v65 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v66 : string = null |> unbox<string>
            v66 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v67 : string = null |> unbox<string>
            v67 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v68 : string = null |> unbox<string>
            v68 
            #endif
#if FABLE_COMPILER_PYTHON
            let v69 : string = null |> unbox<string>
            v69 
            #endif
#else
            let v70 : string = method21()
            let v71 : string = "^\\\\\\\\\\?\\\\"
            let v72 : string = System.Text.RegularExpressions.Regex.Replace (v44, v71, v70)
            v72 
            #endif
            |> fun x -> _v45 <- Some x
            let v73 : string = _v45.Value
            let v74 : string = $"{v73.[0] |> string |> _.ToLower()}{v73.[1..]}"
            let v75 : string = "\\"
            let v76 : string = "/"
            let v77 : string = v74.Replace (v75, v76)
            let v78 : (string []) = v77.Split v76
            let v79 : (string []) = [||]
            let v80 : int32 = v78.Length
            let v81 : Mut4 = {l0 = 0; l1 = 0; l2 = v79} : Mut4
            while method22(v80, v81) do
                let v83 : int32 = v81.l0
                let v84 : int32 =  -v83
                let v85 : int32 = v84 + v80
                let v86 : int32 = v85 - 1
                let struct (v87 : int32, v88 : (string [])) = v81.l1, v81.l2
                let v89 : string = v78.[int v86]
                let v90 : bool = ".." = v89
                let struct (v132 : int32, v133 : (string [])) =
                    if v90 then
                        let v91 : int32 = v87 + 1
                        struct (v91, v88)
                    else
                        let v92 : bool = "." = v89
                        if v92 then
                            struct (v87, v88)
                        else
                            let v93 : bool = 0 = v87
                            if v93 then
                                let v94 : string = ":"
                                let v95 : bool = v89.EndsWith v94
                                if v95 then
                                    let v96 : string = $"{v43.[0]}:"
                                    let v97 : (string []) = [|v96|]
                                    let v98 : int32 = v97.Length
                                    let v99 : int32 = v88.Length
                                    let v100 : int32 = v98 + v99
                                    let v101 : (string []) = Array.zeroCreate<string> (v100)
                                    let v102 : Mut5 = {l0 = 0} : Mut5
                                    while method23(v100, v102) do
                                        let v104 : int32 = v102.l0
                                        let v105 : bool = v104 < v98
                                        let v109 : string =
                                            if v105 then
                                                let v106 : string = v97.[int v104]
                                                v106
                                            else
                                                let v107 : int32 = v104 - v98
                                                let v108 : string = v88.[int v107]
                                                v108
                                        v101.[int v104] <- v109
                                        let v110 : int32 = v104 + 1
                                        v102.l0 <- v110
                                        ()
                                    struct (0, v101)
                                else
                                    let v111 : (string []) = [|v89|]
                                    let v112 : int32 = v111.Length
                                    let v113 : int32 = v88.Length
                                    let v114 : int32 = v112 + v113
                                    let v115 : (string []) = Array.zeroCreate<string> (v114)
                                    let v116 : Mut5 = {l0 = 0} : Mut5
                                    while method23(v114, v116) do
                                        let v118 : int32 = v116.l0
                                        let v119 : bool = v118 < v112
                                        let v123 : string =
                                            if v119 then
                                                let v120 : string = v111.[int v118]
                                                v120
                                            else
                                                let v121 : int32 = v118 - v112
                                                let v122 : string = v88.[int v121]
                                                v122
                                        v115.[int v118] <- v123
                                        let v124 : int32 = v118 + 1
                                        v116.l0 <- v124
                                        ()
                                    struct (0, v115)
                            else
                                let v127 : int32 = v87 - 1
                                struct (v127, v88)
                let v134 : int32 = v83 + 1
                v81.l0 <- v134
                v81.l1 <- v132
                v81.l2 <- v133
                ()
            let struct (v135 : int32, v136 : (string [])) = v81.l1, v81.l2
            let v137 : string seq = seq { for i = 0 to v136.Length - 1 do yield v136.[i] }
            let v138 : bool = true
            let mutable _v138 : char option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v139 : string = "std::path::MAIN_SEPARATOR"
            let v140 : char = Fable.Core.RustInterop.emitRustExpr () v139
            v140 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v141 : char = null |> unbox<char>
            v141 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v142 : char = null |> unbox<char>
            v142 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v143 : char = null |> unbox<char>
            v143 
            #endif
#if FABLE_COMPILER_PYTHON
            let v144 : char = null |> unbox<char>
            v144 
            #endif
#else
            let v145 : char = System.IO.Path.DirectorySeparatorChar
            v145 
            #endif
            |> fun x -> _v138 <- Some x
            let v146 : char = _v138.Value
            let v147 : (char -> string) = _.ToString()
            let v148 : string = v147 v146
            let v149 : string = method24(v148)
            let v150 : (string -> (string seq -> string)) = String.concat
            let v151 : (string seq -> string) = v150 v149
            v151 v137
        else
            let v153 : string = "std::fs::canonicalize(&*$0)"
            let v154 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v7 v153
            let v155 : string = "$0.unwrap()"
            let v156 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v154 v155
            let v157 : string = "$0.display()"
            let v158 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v156 v157
            let v159 : bool = true
            let mutable _v159 : std_string_String option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v160 : string = "format!(\"{}\", $0)"
            let v161 : std_string_String = Fable.Core.RustInterop.emitRustExpr v158 v160
            v161 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v162 : string = "format!(\"{}\", $0)"
            let v163 : std_string_String = Fable.Core.RustInterop.emitRustExpr v158 v162
            v163 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v164 : string = "format!(\"{}\", $0)"
            let v165 : std_string_String = Fable.Core.RustInterop.emitRustExpr v158 v164
            v165 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v166 : std_string_String = null |> unbox<std_string_String>
            v166 
            #endif
#if FABLE_COMPILER_PYTHON
            let v167 : std_string_String = null |> unbox<std_string_String>
            v167 
            #endif
#else
            let v168 : std_string_String = null |> unbox<std_string_String>
            v168 
            #endif
            |> fun x -> _v159 <- Some x
            let v169 : std_string_String = _v159.Value
            let v170 : string = "fable_library_rust::String_::fromString($0)"
            let v171 : string = Fable.Core.RustInterop.emitRustExpr v169 v170
            v171
    v172 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v173 : string = null |> unbox<string>
    v173 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v174 : string = null |> unbox<string>
    v174 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v175 : string = null |> unbox<string>
    v175 
    #endif
#if FABLE_COMPILER_PYTHON
    let v176 : string = null |> unbox<string>
    v176 
    #endif
#else
    let v177 : string = method25(v5)
    let v178 : (string -> string) = System.IO.Path.GetFullPath
    let v179 : string = v178 v177
    v179 
    #endif
    |> fun x -> _v6 <- Some x
    let v180 : string = _v6.Value
    let v181 : string = "&*$0"
    let v182 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v180 v181
    let v183 : string = "String::from($0)"
    let v184 : std_string_String = Fable.Core.RustInterop.emitRustExpr v182 v183
    let v185 : string = "std::path::PathBuf::from($0)"
    let v186 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v184 v185
    let v187 : string = "$0.display()"
    let v188 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v186 v187
    let v189 : bool = true
    let mutable _v189 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v190 : string = "format!(\"{}\", $0)"
    let v191 : std_string_String = Fable.Core.RustInterop.emitRustExpr v188 v190
    v191 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v192 : string = "format!(\"{}\", $0)"
    let v193 : std_string_String = Fable.Core.RustInterop.emitRustExpr v188 v192
    v193 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v194 : string = "format!(\"{}\", $0)"
    let v195 : std_string_String = Fable.Core.RustInterop.emitRustExpr v188 v194
    v195 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v196 : std_string_String = null |> unbox<std_string_String>
    v196 
    #endif
#if FABLE_COMPILER_PYTHON
    let v197 : std_string_String = null |> unbox<std_string_String>
    v197 
    #endif
#else
    let v198 : std_string_String = null |> unbox<std_string_String>
    v198 
    #endif
    |> fun x -> _v189 <- Some x
    let v199 : std_string_String = _v189.Value
    let v200 : string = "fable_library_rust::String_::fromString($0)"
    let v201 : string = Fable.Core.RustInterop.emitRustExpr v199 v200
    let v202 : string = ""
    let v203 : string = v201.Replace (v3, v202)
    let v204 : string = "\\"
    let v205 : string = "/"
    let v206 : string = v203.Replace (v204, v205)
    let v207 : string = $".{v206}"
    let v208 : bool = true
    let mutable _v208 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v209 : string = method18(v180)
    let v210 : string = method19()
    let v211 : bool = true
    let mutable _v211 : Result<regex_Regex, regex_Error> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v212 : string = method20()
    let v213 : string = $"regex::Regex::new(&$0)"
    let v214 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v212 v213
    v214 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v215 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
    v215 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v216 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
    v216 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v217 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
    v217 
    #endif
#if FABLE_COMPILER_PYTHON
    let v218 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
    v218 
    #endif
#else
    let v219 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
    v219 
    #endif
    |> fun x -> _v211 <- Some x
    let v220 : Result<regex_Regex, regex_Error> = _v211.Value
    let v221 : string = "$0.unwrap()"
    let v222 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v220 v221
    let v223 : string = $"$0.replace_all(&$1, &*$2)"
    let v224 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v222, v209, v210) v223
    let v225 : string = "String::from($0)"
    let v226 : std_string_String = Fable.Core.RustInterop.emitRustExpr v224 v225
    let v227 : string = "fable_library_rust::String_::fromString($0)"
    let v228 : string = Fable.Core.RustInterop.emitRustExpr v226 v227
    v228 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v229 : string = null |> unbox<string>
    v229 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v230 : string = null |> unbox<string>
    v230 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v231 : string = null |> unbox<string>
    v231 
    #endif
#if FABLE_COMPILER_PYTHON
    let v232 : string = null |> unbox<string>
    v232 
    #endif
#else
    let v233 : string = method21()
    let v234 : string = "^\\\\\\\\\\?\\\\"
    let v235 : string = System.Text.RegularExpressions.Regex.Replace (v180, v234, v233)
    v235 
    #endif
    |> fun x -> _v208 <- Some x
    let v236 : string = _v208.Value
    let v237 : string = $"{v236.[0] |> string |> _.ToLower()}{v236.[1..]}"
    let v238 : string = v237.Replace (v204, v205)
    let v239 : string = method11(v2, v207)
    let v240 : string = method34(v239)
    let v241 : System.Threading.CancellationToken option = None
    let v242 : (struct (string * string) []) = [||]
    let v243 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v244 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v245 : string option = None
    let v246 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v240}\""
    let v247 : string option = Some v2 
    let v248 : bool = true
    let struct (v249 : int32, v250 : string) = method35(v241, v246, v242, v243, v244, v248, v247)
    let v251 : string = method11(v3, v207)
    let v252 : string = method34(v251)
    let v253 : System.Threading.CancellationToken option = None
    let v254 : (struct (string * string) []) = [||]
    let v255 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v256 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v257 : string option = None
    let v258 : string = $"git hash-object \"{v252}\""
    let v259 : string option = Some v3 
    let v260 : bool = true
    let struct (v261 : int32, v262 : string) = method35(v253, v258, v254, v255, v256, v260, v259)
    let v263 : string = method11(v4, v207)
    let v264 : string = method34(v263)
    let v265 : string = "hangul.md"
    let struct (v266 : string, v267 : string) = method57(v265, v252, v4)
    let v268 : bool = false
    let v269 : bool = false
    let v270 : bool = false
    let v271 : bool = true
    let v272 : bool = true
    let v273 : bool = true
    let v274 : bool = v250.Contains v262
    let v275 : bool = v274 = false
    let v526 : UH2 =
        if v275 then
            let v276 : bool = true
            let mutable _v276 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v277 : string = method18(v252)
            let v278 : string = method19()
            let v279 : bool = true
            let mutable _v279 : Result<regex_Regex, regex_Error> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v280 : string = method20()
            let v281 : string = $"regex::Regex::new(&$0)"
            let v282 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v280 v281
            v282 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v283 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v283 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v284 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v284 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v285 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v285 
            #endif
#if FABLE_COMPILER_PYTHON
            let v286 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v286 
            #endif
#else
            let v287 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v287 
            #endif
            |> fun x -> _v279 <- Some x
            let v288 : Result<regex_Regex, regex_Error> = _v279.Value
            let v289 : string = "$0.unwrap()"
            let v290 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v288 v289
            let v291 : string = $"$0.replace_all(&$1, &*$2)"
            let v292 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v290, v277, v278) v291
            let v293 : string = "String::from($0)"
            let v294 : std_string_String = Fable.Core.RustInterop.emitRustExpr v292 v293
            let v295 : string = "fable_library_rust::String_::fromString($0)"
            let v296 : string = Fable.Core.RustInterop.emitRustExpr v294 v295
            v296 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v297 : string = null |> unbox<string>
            v297 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v298 : string = null |> unbox<string>
            v298 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v299 : string = null |> unbox<string>
            v299 
            #endif
#if FABLE_COMPILER_PYTHON
            let v300 : string = null |> unbox<string>
            v300 
            #endif
#else
            let v301 : string = method21()
            let v302 : string = System.Text.RegularExpressions.Regex.Replace (v252, v234, v301)
            v302 
            #endif
            |> fun x -> _v276 <- Some x
            let v303 : string = _v276.Value
            let v304 : string = $"{v303.[0] |> string |> _.ToLower()}{v303.[1..]}"
            let v305 : string = v304.Replace (v204, v205)
            let v306 : string = "std::fs::File::open(&*v305)"
            let v307 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v306
            let v308 : string = "$0.unwrap()"
            let v309 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v307 v308
            let v310 : string = "std::io::BufReader::new(v309)"
            let v311 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v310
            let v312 : string = "true; let mut v311 = v311"
            let v313 : bool = Fable.Core.RustInterop.emitRustExpr () v312
            let v314 : string = "sha2::Digest::new()"
            let v315 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v314
            let v316 : string = "true; let mut v315 = v315"
            let v317 : bool = Fable.Core.RustInterop.emitRustExpr () v316
            let v318 : unativeint = unativeint 0
            let v319 : string = "[$0; 1024]"
            let v320 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v319
            let v321 : string = "true; loop { // rust.loop"
            let v322 : bool = Fable.Core.RustInterop.emitRustExpr () v321
            let v323 : string = "true; let mut v320 = v320"
            let v324 : bool = Fable.Core.RustInterop.emitRustExpr () v323
            let v325 : string = "std::io::Read::read(&mut v311, &mut v320)"
            let v326 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v325
            let v327 : string = "$0.unwrap()"
            let v328 : unativeint = Fable.Core.RustInterop.emitRustExpr v326 v327
            let v329 : bool = v328 = v318
            if v329 then
                let v330 : string = "true; break"
                let v331 : bool = Fable.Core.RustInterop.emitRustExpr () v330
                ()
            let v332 : string = "v320.len()"
            let v333 : unativeint = Fable.Core.RustInterop.emitRustExpr () v332
            let v334 : uint8 = uint8 v333 
            let v335 : unativeint = unativeint v328
            let v336 : unativeint = v335 |> unbox<unativeint>
            let v337 : bool = v336 = v333
            let v342 : Ref<Slice'<uint8>> =
                if v337 then
                    let v338 : string = "&v320[v318..]"
                    let v339 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v338
                    v339
                else
                    let v340 : string = "&v320[$0..$1]"
                    let v341 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v318, v335) v340
                    v341
            let v343 : string = "sha2::Digest::update(&mut v315, v342)"
            Fable.Core.RustInterop.emitRustExpr () v343
            let v344 : string = "true; } // rust.loop"
            let v345 : bool = Fable.Core.RustInterop.emitRustExpr () v344
            let v346 : string = "true; } // rust.loop"
            let v347 : bool = Fable.Core.RustInterop.emitRustExpr () v346
            let v348 : string = "true; } // rust.loop"
            let v349 : bool = Fable.Core.RustInterop.emitRustExpr () v348
            let v350 : string = "true; { // rust.loop"
            let v351 : bool = Fable.Core.RustInterop.emitRustExpr () v350
            let v352 : string = "true; { // rust.loop"
            let v353 : bool = Fable.Core.RustInterop.emitRustExpr () v352
            let v354 : string = "&sha2::Digest::finalize(v315)"
            let v355 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v354
            let v356 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v357 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v355 v356
            let v358 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
            let v359 : (uint8 -> string) = closure50()
            let v360 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v357, v359) v358
            let v361 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v362 : (string []) = Fable.Core.RustInterop.emitRustExpr v360 v361
            let v363 : string seq = seq { for i = 0 to v362.Length - 1 do yield v362.[i] }
            let v364 : string = method58()
            let v365 : (string -> (string seq -> string)) = String.concat
            let v366 : (string seq -> string) = v365 v364
            let v367 : string = v366 v363
            let v368 : bool = true
            let mutable _v368 : bool option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v369 : string = "&*$0"
            let v370 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v264 v369
            let v371 : string = "String::from($0)"
            let v372 : std_string_String = Fable.Core.RustInterop.emitRustExpr v370 v371
            let v373 : string = "std::path::PathBuf::from($0)"
            let v374 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v372 v373
            let v375 : string = "$0.exists()"
            let v376 : bool = Fable.Core.RustInterop.emitRustExpr v374 v375
            let v379 : bool =
                if v376 then
                    let v377 : string = "$0.is_file()"
                    let v378 : bool = Fable.Core.RustInterop.emitRustExpr v374 v377
                    v378
                else
                    false
            v379 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v380 : bool = null |> unbox<bool>
            v380 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v381 : bool = null |> unbox<bool>
            v381 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v382 : string = "fs"
            let v383 : IFsExistsSync = Fable.Core.JsInterop.importAll v382
            let v384 : string = "$0.existsSync($1)"
            let v385 : bool = Fable.Core.JsInterop.emitJsExpr struct (v383, v264) v384
            v385 
            #endif
#if FABLE_COMPILER_PYTHON
            let v386 : bool = null |> unbox<bool>
            v386 
            #endif
#else
            let v387 : (string -> bool) = System.IO.File.Exists
            let v388 : bool = v387 v264
            v388 
            #endif
            |> fun x -> _v368 <- Some x
            let v389 : bool = _v368.Value
            let v483 : US3 =
                if v389 then
                    let v390 : bool = true
                    let mutable _v390 : string option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v391 : string = method18(v264)
                    let v392 : string = method19()
                    let v393 : bool = true
                    let mutable _v393 : Result<regex_Regex, regex_Error> option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v394 : string = method20()
                    let v395 : string = $"regex::Regex::new(&$0)"
                    let v396 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v394 v395
                    v396 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v397 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
                    v397 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v398 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
                    v398 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v399 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
                    v399 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v400 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
                    v400 
                    #endif
#else
                    let v401 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
                    v401 
                    #endif
                    |> fun x -> _v393 <- Some x
                    let v402 : Result<regex_Regex, regex_Error> = _v393.Value
                    let v403 : string = "$0.unwrap()"
                    let v404 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v402 v403
                    let v405 : string = $"$0.replace_all(&$1, &*$2)"
                    let v406 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v404, v391, v392) v405
                    let v407 : string = "String::from($0)"
                    let v408 : std_string_String = Fable.Core.RustInterop.emitRustExpr v406 v407
                    let v409 : string = "fable_library_rust::String_::fromString($0)"
                    let v410 : string = Fable.Core.RustInterop.emitRustExpr v408 v409
                    v410 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v411 : string = null |> unbox<string>
                    v411 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v412 : string = null |> unbox<string>
                    v412 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v413 : string = null |> unbox<string>
                    v413 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v414 : string = null |> unbox<string>
                    v414 
                    #endif
#else
                    let v415 : string = method21()
                    let v416 : string = System.Text.RegularExpressions.Regex.Replace (v264, v234, v415)
                    v416 
                    #endif
                    |> fun x -> _v390 <- Some x
                    let v417 : string = _v390.Value
                    let v418 : string = $"{v417.[0] |> string |> _.ToLower()}{v417.[1..]}"
                    let v419 : string = v418.Replace (v204, v205)
                    let v420 : string = "std::fs::File::open(&*v419)"
                    let v421 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v420
                    let v422 : string = "$0.unwrap()"
                    let v423 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v421 v422
                    let v424 : string = "std::io::BufReader::new(v423)"
                    let v425 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v424
                    let v426 : string = "true; let mut v425 = v425"
                    let v427 : bool = Fable.Core.RustInterop.emitRustExpr () v426
                    let v428 : string = "sha2::Digest::new()"
                    let v429 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v428
                    let v430 : string = "true; let mut v429 = v429"
                    let v431 : bool = Fable.Core.RustInterop.emitRustExpr () v430
                    let v432 : unativeint = unativeint 0
                    let v433 : string = "[$0; 1024]"
                    let v434 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v433
                    let v435 : string = "true; loop { // rust.loop"
                    let v436 : bool = Fable.Core.RustInterop.emitRustExpr () v435
                    let v437 : string = "true; let mut v434 = v434"
                    let v438 : bool = Fable.Core.RustInterop.emitRustExpr () v437
                    let v439 : string = "std::io::Read::read(&mut v425, &mut v434)"
                    let v440 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v439
                    let v441 : string = "$0.unwrap()"
                    let v442 : unativeint = Fable.Core.RustInterop.emitRustExpr v440 v441
                    let v443 : bool = v442 = v432
                    if v443 then
                        let v444 : string = "true; break"
                        let v445 : bool = Fable.Core.RustInterop.emitRustExpr () v444
                        ()
                    let v446 : string = "v434.len()"
                    let v447 : unativeint = Fable.Core.RustInterop.emitRustExpr () v446
                    let v448 : uint8 = uint8 v447 
                    let v449 : unativeint = unativeint v442
                    let v450 : unativeint = v449 |> unbox<unativeint>
                    let v451 : bool = v450 = v447
                    let v456 : Ref<Slice'<uint8>> =
                        if v451 then
                            let v452 : string = "&v434[v432..]"
                            let v453 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v452
                            v453
                        else
                            let v454 : string = "&v434[$0..$1]"
                            let v455 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v432, v449) v454
                            v455
                    let v457 : string = "sha2::Digest::update(&mut v429, v456)"
                    Fable.Core.RustInterop.emitRustExpr () v457
                    let v458 : string = "true; } // rust.loop"
                    let v459 : bool = Fable.Core.RustInterop.emitRustExpr () v458
                    let v460 : string = "true; } // rust.loop"
                    let v461 : bool = Fable.Core.RustInterop.emitRustExpr () v460
                    let v462 : string = "true; } // rust.loop"
                    let v463 : bool = Fable.Core.RustInterop.emitRustExpr () v462
                    let v464 : string = "true; { // rust.loop"
                    let v465 : bool = Fable.Core.RustInterop.emitRustExpr () v464
                    let v466 : string = "true; { // rust.loop"
                    let v467 : bool = Fable.Core.RustInterop.emitRustExpr () v466
                    let v468 : string = "&sha2::Digest::finalize(v429)"
                    let v469 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v468
                    let v470 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
                    let v471 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v469 v470
                    let v472 : string = "$0.into_iter().map(|x| $1(x.clone())).collect::<Vec<_>>()"
                    let v473 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v471, v359) v472
                    let v474 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v475 : (string []) = Fable.Core.RustInterop.emitRustExpr v473 v474
                    let v476 : string seq = seq { for i = 0 to v475.Length - 1 do yield v475.[i] }
                    let v477 : string = method58()
                    let v478 : (string -> (string seq -> string)) = String.concat
                    let v479 : (string seq -> string) = v478 v477
                    let v480 : string = v479 v476
                    US3_0(v480)
                else
                    US3_1
            let v485 : bool =
                match v483 with
                | US3_1 -> (* None *)
                    true
                | _ ->
                    false
            let v491 : bool =
                if v485 then
                    true
                else
                    let v489 : string =
                        match v483 with
                        | US3_1 -> (* None *)
                            failwith<string> "Option does not have a value."
                        | US3_0(v486) -> (* Some *)
                            v486
                    let v490 : bool = v367 <> v489
                    v490
            if v491 then
                let v492 : US0 = US0_2
                let v493 : (unit -> string) = closure51()
                let v494 : (unit -> string) = closure52(v207, v238, v240, v250, v249, v252, v262, v261, v264, v367, v483)
                method3(v492, v493, v494)
                let v495 : bool = true
                let mutable _v495 : unit option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v496 : string = method59(v264)
                let v497 : string = "std::fs::copy(&*$0, &*v496)"
                let v498 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v252 v497
                let v499 : string = "$0.unwrap()"
                let v500 : uint64 = Fable.Core.RustInterop.emitRustExpr v498 v499
                () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                null |> unbox<unit>
                () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                null |> unbox<unit>
                () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                null |> unbox<unit>
                () 
                #endif
#if FABLE_COMPILER_PYTHON
                null |> unbox<unit>
                () 
                #endif
#else
                System.IO.File.Copy (v252, v264, true)
                () 
                #endif
                |> fun x -> _v495 <- Some x
                _v495.Value
                let v501 : (string -> (string -> US18)) = closure53(v4, v3, v1, v0)
                let v502 : UH3 = UH3_0
                let v503 : UH3 = UH3_1(v265, v252, v501, v502)
                let v504 : string = "html"
                let v505 : (string -> (string -> US18)) = closure60(v4, v3, v268)
                let v506 : string = "pdf"
                let v507 : (string -> (string -> US18)) = closure60(v4, v3, v269)
                let v508 : string = "epub"
                let v509 : (string -> (string -> US18)) = closure60(v4, v3, v270)
                let v510 : (string -> (string -> US18)) = closure60(v4, v3, v271)
                let v511 : (string -> (string -> US18)) = closure60(v4, v3, v272)
                let v512 : (string -> (string -> US18)) = closure60(v4, v3, v273)
                let v513 : UH3 = UH3_0
                let v514 : UH3 = UH3_1(v508, v267, v512, v513)
                let v515 : UH3 = UH3_1(v506, v267, v511, v514)
                let v516 : UH3 = UH3_1(v504, v267, v510, v515)
                let v517 : UH3 = UH3_1(v508, v252, v509, v516)
                let v518 : UH3 = UH3_1(v506, v252, v507, v517)
                let v519 : UH3 = UH3_1(v504, v252, v505, v518)
                let v520 : UH2 = UH2_0
                let v521 : UH2 = UH2_1(v519, v520)
                UH2_1(v503, v521)
            else
                UH2_0
        else
            UH2_0
    let v528 : bool =
        match v526 with
        | UH2_0 -> (* Nil *)
            true
        | _ ->
            false
    let v529 : bool = v528 <> true
    let v954 : UH2 =
        if v529 then
            v526
        else
            let v530 : string = "epub"
            let struct (v531 : string, v532 : string) = method57(v530, v267, v4)
            let v533 : bool = true
            let mutable _v533 : bool option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v534 : string = "&*$0"
            let v535 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v532 v534
            let v536 : string = "String::from($0)"
            let v537 : std_string_String = Fable.Core.RustInterop.emitRustExpr v535 v536
            let v538 : string = "std::path::PathBuf::from($0)"
            let v539 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v537 v538
            let v540 : string = "$0.exists()"
            let v541 : bool = Fable.Core.RustInterop.emitRustExpr v539 v540
            let v544 : bool =
                if v541 then
                    let v542 : string = "$0.is_file()"
                    let v543 : bool = Fable.Core.RustInterop.emitRustExpr v539 v542
                    v543
                else
                    false
            v544 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v545 : bool = null |> unbox<bool>
            v545 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v546 : bool = null |> unbox<bool>
            v546 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v547 : string = "fs"
            let v548 : IFsExistsSync = Fable.Core.JsInterop.importAll v547
            let v549 : string = "$0.existsSync($1)"
            let v550 : bool = Fable.Core.JsInterop.emitJsExpr struct (v548, v532) v549
            v550 
            #endif
#if FABLE_COMPILER_PYTHON
            let v551 : bool = null |> unbox<bool>
            v551 
            #endif
#else
            let v552 : (string -> bool) = System.IO.File.Exists
            let v553 : bool = v552 v532
            v553 
            #endif
            |> fun x -> _v533 <- Some x
            let v554 : bool = _v533.Value
            let v555 : bool = v554 = false
            let v587 : bool =
                if v555 then
                    let v556 : bool = true
                    let mutable _v556 : bool option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v557 : string = "&*$0"
                    let v558 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v531 v557
                    let v559 : string = "String::from($0)"
                    let v560 : std_string_String = Fable.Core.RustInterop.emitRustExpr v558 v559
                    let v561 : string = "std::path::PathBuf::from($0)"
                    let v562 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v560 v561
                    let v563 : string = "$0.exists()"
                    let v564 : bool = Fable.Core.RustInterop.emitRustExpr v562 v563
                    let v567 : bool =
                        if v564 then
                            let v565 : string = "$0.is_file()"
                            let v566 : bool = Fable.Core.RustInterop.emitRustExpr v562 v565
                            v566
                        else
                            false
                    v567 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v568 : bool = null |> unbox<bool>
                    v568 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v569 : bool = null |> unbox<bool>
                    v569 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v570 : IFsExistsSync = Fable.Core.JsInterop.importAll v547
                    let v571 : string = "$0.existsSync($1)"
                    let v572 : bool = Fable.Core.JsInterop.emitJsExpr struct (v570, v531) v571
                    v572 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v573 : bool = null |> unbox<bool>
                    v573 
                    #endif
#else
                    let v574 : (string -> bool) = System.IO.File.Exists
                    let v575 : bool = v574 v531
                    v575 
                    #endif
                    |> fun x -> _v556 <- Some x
                    let v576 : bool = _v556.Value
                    if v576 then
                        let v577 : US0 = US0_2
                        let v578 : (unit -> string) = closure64()
                        let v579 : (unit -> string) = closure65(v531, v532)
                        method3(v577, v578, v579)
                        let v580 : bool = true
                        let mutable _v580 : unit option = None 
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v581 : string = method59(v532)
                        let v582 : string = "std::fs::copy(&*$0, &*v581)"
                        let v583 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v531 v582
                        let v584 : string = "$0.unwrap()"
                        let v585 : uint64 = Fable.Core.RustInterop.emitRustExpr v583 v584
                        () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        null |> unbox<unit>
                        () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        null |> unbox<unit>
                        () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        null |> unbox<unit>
                        () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        null |> unbox<unit>
                        () 
                        #endif
#else
                        System.IO.File.Copy (v531, v532, true)
                        () 
                        #endif
                        |> fun x -> _v580 <- Some x
                        _v580.Value
                        false
                    else
                        true
                else
                    true
            let v592 : UH3 =
                if v587 then
                    let v588 : (string -> (string -> US18)) = closure60(v4, v3, v273)
                    let v589 : UH3 = UH3_0
                    UH3_1(v530, v267, v588, v589)
                else
                    UH3_0
            let v593 : string = "pdf"
            let struct (v594 : string, v595 : string) = method57(v593, v267, v4)
            let v596 : bool = true
            let mutable _v596 : bool option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v597 : string = "&*$0"
            let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v595 v597
            let v599 : string = "String::from($0)"
            let v600 : std_string_String = Fable.Core.RustInterop.emitRustExpr v598 v599
            let v601 : string = "std::path::PathBuf::from($0)"
            let v602 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v600 v601
            let v603 : string = "$0.exists()"
            let v604 : bool = Fable.Core.RustInterop.emitRustExpr v602 v603
            let v607 : bool =
                if v604 then
                    let v605 : string = "$0.is_file()"
                    let v606 : bool = Fable.Core.RustInterop.emitRustExpr v602 v605
                    v606
                else
                    false
            v607 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v608 : bool = null |> unbox<bool>
            v608 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v609 : bool = null |> unbox<bool>
            v609 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v610 : IFsExistsSync = Fable.Core.JsInterop.importAll v547
            let v611 : string = "$0.existsSync($1)"
            let v612 : bool = Fable.Core.JsInterop.emitJsExpr struct (v610, v595) v611
            v612 
            #endif
#if FABLE_COMPILER_PYTHON
            let v613 : bool = null |> unbox<bool>
            v613 
            #endif
#else
            let v614 : (string -> bool) = System.IO.File.Exists
            let v615 : bool = v614 v595
            v615 
            #endif
            |> fun x -> _v596 <- Some x
            let v616 : bool = _v596.Value
            let v617 : bool = v616 = false
            let v649 : bool =
                if v617 then
                    let v618 : bool = true
                    let mutable _v618 : bool option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v619 : string = "&*$0"
                    let v620 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v594 v619
                    let v621 : string = "String::from($0)"
                    let v622 : std_string_String = Fable.Core.RustInterop.emitRustExpr v620 v621
                    let v623 : string = "std::path::PathBuf::from($0)"
                    let v624 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v622 v623
                    let v625 : string = "$0.exists()"
                    let v626 : bool = Fable.Core.RustInterop.emitRustExpr v624 v625
                    let v629 : bool =
                        if v626 then
                            let v627 : string = "$0.is_file()"
                            let v628 : bool = Fable.Core.RustInterop.emitRustExpr v624 v627
                            v628
                        else
                            false
                    v629 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v630 : bool = null |> unbox<bool>
                    v630 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v631 : bool = null |> unbox<bool>
                    v631 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v632 : IFsExistsSync = Fable.Core.JsInterop.importAll v547
                    let v633 : string = "$0.existsSync($1)"
                    let v634 : bool = Fable.Core.JsInterop.emitJsExpr struct (v632, v594) v633
                    v634 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v635 : bool = null |> unbox<bool>
                    v635 
                    #endif
#else
                    let v636 : (string -> bool) = System.IO.File.Exists
                    let v637 : bool = v636 v594
                    v637 
                    #endif
                    |> fun x -> _v618 <- Some x
                    let v638 : bool = _v618.Value
                    if v638 then
                        let v639 : US0 = US0_2
                        let v640 : (unit -> string) = closure64()
                        let v641 : (unit -> string) = closure65(v594, v595)
                        method3(v639, v640, v641)
                        let v642 : bool = true
                        let mutable _v642 : unit option = None 
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v643 : string = method59(v595)
                        let v644 : string = "std::fs::copy(&*$0, &*v643)"
                        let v645 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v594 v644
                        let v646 : string = "$0.unwrap()"
                        let v647 : uint64 = Fable.Core.RustInterop.emitRustExpr v645 v646
                        () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        null |> unbox<unit>
                        () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        null |> unbox<unit>
                        () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        null |> unbox<unit>
                        () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        null |> unbox<unit>
                        () 
                        #endif
#else
                        System.IO.File.Copy (v594, v595, true)
                        () 
                        #endif
                        |> fun x -> _v642 <- Some x
                        _v642.Value
                        false
                    else
                        true
                else
                    true
            let v652 : UH3 =
                if v649 then
                    let v650 : (string -> (string -> US18)) = closure60(v4, v3, v272)
                    UH3_1(v593, v267, v650, v592)
                else
                    v592
            let v653 : string = "html"
            let struct (v654 : string, v655 : string) = method57(v653, v267, v4)
            let v656 : bool = true
            let mutable _v656 : bool option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v657 : string = "&*$0"
            let v658 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v655 v657
            let v659 : string = "String::from($0)"
            let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v658 v659
            let v661 : string = "std::path::PathBuf::from($0)"
            let v662 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v660 v661
            let v663 : string = "$0.exists()"
            let v664 : bool = Fable.Core.RustInterop.emitRustExpr v662 v663
            let v667 : bool =
                if v664 then
                    let v665 : string = "$0.is_file()"
                    let v666 : bool = Fable.Core.RustInterop.emitRustExpr v662 v665
                    v666
                else
                    false
            v667 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v668 : bool = null |> unbox<bool>
            v668 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v669 : bool = null |> unbox<bool>
            v669 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v670 : IFsExistsSync = Fable.Core.JsInterop.importAll v547
            let v671 : string = "$0.existsSync($1)"
            let v672 : bool = Fable.Core.JsInterop.emitJsExpr struct (v670, v655) v671
            v672 
            #endif
#if FABLE_COMPILER_PYTHON
            let v673 : bool = null |> unbox<bool>
            v673 
            #endif
#else
            let v674 : (string -> bool) = System.IO.File.Exists
            let v675 : bool = v674 v655
            v675 
            #endif
            |> fun x -> _v656 <- Some x
            let v676 : bool = _v656.Value
            let v677 : bool = v676 = false
            let v709 : bool =
                if v677 then
                    let v678 : bool = true
                    let mutable _v678 : bool option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v679 : string = "&*$0"
                    let v680 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v654 v679
                    let v681 : string = "String::from($0)"
                    let v682 : std_string_String = Fable.Core.RustInterop.emitRustExpr v680 v681
                    let v683 : string = "std::path::PathBuf::from($0)"
                    let v684 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v682 v683
                    let v685 : string = "$0.exists()"
                    let v686 : bool = Fable.Core.RustInterop.emitRustExpr v684 v685
                    let v689 : bool =
                        if v686 then
                            let v687 : string = "$0.is_file()"
                            let v688 : bool = Fable.Core.RustInterop.emitRustExpr v684 v687
                            v688
                        else
                            false
                    v689 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v690 : bool = null |> unbox<bool>
                    v690 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v691 : bool = null |> unbox<bool>
                    v691 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v692 : IFsExistsSync = Fable.Core.JsInterop.importAll v547
                    let v693 : string = "$0.existsSync($1)"
                    let v694 : bool = Fable.Core.JsInterop.emitJsExpr struct (v692, v654) v693
                    v694 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v695 : bool = null |> unbox<bool>
                    v695 
                    #endif
#else
                    let v696 : (string -> bool) = System.IO.File.Exists
                    let v697 : bool = v696 v654
                    v697 
                    #endif
                    |> fun x -> _v678 <- Some x
                    let v698 : bool = _v678.Value
                    if v698 then
                        let v699 : US0 = US0_2
                        let v700 : (unit -> string) = closure64()
                        let v701 : (unit -> string) = closure65(v654, v655)
                        method3(v699, v700, v701)
                        let v702 : bool = true
                        let mutable _v702 : unit option = None 
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v703 : string = method59(v655)
                        let v704 : string = "std::fs::copy(&*$0, &*v703)"
                        let v705 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v654 v704
                        let v706 : string = "$0.unwrap()"
                        let v707 : uint64 = Fable.Core.RustInterop.emitRustExpr v705 v706
                        () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        null |> unbox<unit>
                        () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        null |> unbox<unit>
                        () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        null |> unbox<unit>
                        () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        null |> unbox<unit>
                        () 
                        #endif
#else
                        System.IO.File.Copy (v654, v655, true)
                        () 
                        #endif
                        |> fun x -> _v702 <- Some x
                        _v702.Value
                        false
                    else
                        true
                else
                    true
            let v712 : UH3 =
                if v709 then
                    let v710 : (string -> (string -> US18)) = closure60(v4, v3, v271)
                    UH3_1(v653, v267, v710, v652)
                else
                    v652
            let struct (v713 : string, v714 : string) = method57(v530, v252, v4)
            let v715 : bool = true
            let mutable _v715 : bool option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v716 : string = "&*$0"
            let v717 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v714 v716
            let v718 : string = "String::from($0)"
            let v719 : std_string_String = Fable.Core.RustInterop.emitRustExpr v717 v718
            let v720 : string = "std::path::PathBuf::from($0)"
            let v721 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v719 v720
            let v722 : string = "$0.exists()"
            let v723 : bool = Fable.Core.RustInterop.emitRustExpr v721 v722
            let v726 : bool =
                if v723 then
                    let v724 : string = "$0.is_file()"
                    let v725 : bool = Fable.Core.RustInterop.emitRustExpr v721 v724
                    v725
                else
                    false
            v726 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v727 : bool = null |> unbox<bool>
            v727 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v728 : bool = null |> unbox<bool>
            v728 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v729 : IFsExistsSync = Fable.Core.JsInterop.importAll v547
            let v730 : string = "$0.existsSync($1)"
            let v731 : bool = Fable.Core.JsInterop.emitJsExpr struct (v729, v714) v730
            v731 
            #endif
#if FABLE_COMPILER_PYTHON
            let v732 : bool = null |> unbox<bool>
            v732 
            #endif
#else
            let v733 : (string -> bool) = System.IO.File.Exists
            let v734 : bool = v733 v714
            v734 
            #endif
            |> fun x -> _v715 <- Some x
            let v735 : bool = _v715.Value
            let v736 : bool = v735 = false
            let v768 : bool =
                if v736 then
                    let v737 : bool = true
                    let mutable _v737 : bool option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v738 : string = "&*$0"
                    let v739 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v713 v738
                    let v740 : string = "String::from($0)"
                    let v741 : std_string_String = Fable.Core.RustInterop.emitRustExpr v739 v740
                    let v742 : string = "std::path::PathBuf::from($0)"
                    let v743 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v741 v742
                    let v744 : string = "$0.exists()"
                    let v745 : bool = Fable.Core.RustInterop.emitRustExpr v743 v744
                    let v748 : bool =
                        if v745 then
                            let v746 : string = "$0.is_file()"
                            let v747 : bool = Fable.Core.RustInterop.emitRustExpr v743 v746
                            v747
                        else
                            false
                    v748 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v749 : bool = null |> unbox<bool>
                    v749 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v750 : bool = null |> unbox<bool>
                    v750 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v751 : IFsExistsSync = Fable.Core.JsInterop.importAll v547
                    let v752 : string = "$0.existsSync($1)"
                    let v753 : bool = Fable.Core.JsInterop.emitJsExpr struct (v751, v713) v752
                    v753 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v754 : bool = null |> unbox<bool>
                    v754 
                    #endif
#else
                    let v755 : (string -> bool) = System.IO.File.Exists
                    let v756 : bool = v755 v713
                    v756 
                    #endif
                    |> fun x -> _v737 <- Some x
                    let v757 : bool = _v737.Value
                    if v757 then
                        let v758 : US0 = US0_2
                        let v759 : (unit -> string) = closure64()
                        let v760 : (unit -> string) = closure65(v713, v714)
                        method3(v758, v759, v760)
                        let v761 : bool = true
                        let mutable _v761 : unit option = None 
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v762 : string = method59(v714)
                        let v763 : string = "std::fs::copy(&*$0, &*v762)"
                        let v764 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v713 v763
                        let v765 : string = "$0.unwrap()"
                        let v766 : uint64 = Fable.Core.RustInterop.emitRustExpr v764 v765
                        () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        null |> unbox<unit>
                        () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        null |> unbox<unit>
                        () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        null |> unbox<unit>
                        () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        null |> unbox<unit>
                        () 
                        #endif
#else
                        System.IO.File.Copy (v713, v714, true)
                        () 
                        #endif
                        |> fun x -> _v761 <- Some x
                        _v761.Value
                        false
                    else
                        true
                else
                    true
            let v771 : UH3 =
                if v768 then
                    let v769 : (string -> (string -> US18)) = closure60(v4, v3, v270)
                    UH3_1(v530, v252, v769, v712)
                else
                    v712
            let struct (v772 : string, v773 : string) = method57(v593, v252, v4)
            let v774 : bool = true
            let mutable _v774 : bool option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v775 : string = "&*$0"
            let v776 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v773 v775
            let v777 : string = "String::from($0)"
            let v778 : std_string_String = Fable.Core.RustInterop.emitRustExpr v776 v777
            let v779 : string = "std::path::PathBuf::from($0)"
            let v780 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v778 v779
            let v781 : string = "$0.exists()"
            let v782 : bool = Fable.Core.RustInterop.emitRustExpr v780 v781
            let v785 : bool =
                if v782 then
                    let v783 : string = "$0.is_file()"
                    let v784 : bool = Fable.Core.RustInterop.emitRustExpr v780 v783
                    v784
                else
                    false
            v785 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v786 : bool = null |> unbox<bool>
            v786 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v787 : bool = null |> unbox<bool>
            v787 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v788 : IFsExistsSync = Fable.Core.JsInterop.importAll v547
            let v789 : string = "$0.existsSync($1)"
            let v790 : bool = Fable.Core.JsInterop.emitJsExpr struct (v788, v773) v789
            v790 
            #endif
#if FABLE_COMPILER_PYTHON
            let v791 : bool = null |> unbox<bool>
            v791 
            #endif
#else
            let v792 : (string -> bool) = System.IO.File.Exists
            let v793 : bool = v792 v773
            v793 
            #endif
            |> fun x -> _v774 <- Some x
            let v794 : bool = _v774.Value
            let v795 : bool = v794 = false
            let v827 : bool =
                if v795 then
                    let v796 : bool = true
                    let mutable _v796 : bool option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v797 : string = "&*$0"
                    let v798 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v772 v797
                    let v799 : string = "String::from($0)"
                    let v800 : std_string_String = Fable.Core.RustInterop.emitRustExpr v798 v799
                    let v801 : string = "std::path::PathBuf::from($0)"
                    let v802 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v800 v801
                    let v803 : string = "$0.exists()"
                    let v804 : bool = Fable.Core.RustInterop.emitRustExpr v802 v803
                    let v807 : bool =
                        if v804 then
                            let v805 : string = "$0.is_file()"
                            let v806 : bool = Fable.Core.RustInterop.emitRustExpr v802 v805
                            v806
                        else
                            false
                    v807 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v808 : bool = null |> unbox<bool>
                    v808 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v809 : bool = null |> unbox<bool>
                    v809 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v810 : IFsExistsSync = Fable.Core.JsInterop.importAll v547
                    let v811 : string = "$0.existsSync($1)"
                    let v812 : bool = Fable.Core.JsInterop.emitJsExpr struct (v810, v772) v811
                    v812 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v813 : bool = null |> unbox<bool>
                    v813 
                    #endif
#else
                    let v814 : (string -> bool) = System.IO.File.Exists
                    let v815 : bool = v814 v772
                    v815 
                    #endif
                    |> fun x -> _v796 <- Some x
                    let v816 : bool = _v796.Value
                    if v816 then
                        let v817 : US0 = US0_2
                        let v818 : (unit -> string) = closure64()
                        let v819 : (unit -> string) = closure65(v772, v773)
                        method3(v817, v818, v819)
                        let v820 : bool = true
                        let mutable _v820 : unit option = None 
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v821 : string = method59(v773)
                        let v822 : string = "std::fs::copy(&*$0, &*v821)"
                        let v823 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v772 v822
                        let v824 : string = "$0.unwrap()"
                        let v825 : uint64 = Fable.Core.RustInterop.emitRustExpr v823 v824
                        () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        null |> unbox<unit>
                        () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        null |> unbox<unit>
                        () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        null |> unbox<unit>
                        () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        null |> unbox<unit>
                        () 
                        #endif
#else
                        System.IO.File.Copy (v772, v773, true)
                        () 
                        #endif
                        |> fun x -> _v820 <- Some x
                        _v820.Value
                        false
                    else
                        true
                else
                    true
            let v830 : UH3 =
                if v827 then
                    let v828 : (string -> (string -> US18)) = closure60(v4, v3, v269)
                    UH3_1(v593, v252, v828, v771)
                else
                    v771
            let struct (v831 : string, v832 : string) = method57(v653, v252, v4)
            let v833 : bool = true
            let mutable _v833 : bool option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v834 : string = "&*$0"
            let v835 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v832 v834
            let v836 : string = "String::from($0)"
            let v837 : std_string_String = Fable.Core.RustInterop.emitRustExpr v835 v836
            let v838 : string = "std::path::PathBuf::from($0)"
            let v839 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v837 v838
            let v840 : string = "$0.exists()"
            let v841 : bool = Fable.Core.RustInterop.emitRustExpr v839 v840
            let v844 : bool =
                if v841 then
                    let v842 : string = "$0.is_file()"
                    let v843 : bool = Fable.Core.RustInterop.emitRustExpr v839 v842
                    v843
                else
                    false
            v844 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v845 : bool = null |> unbox<bool>
            v845 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v846 : bool = null |> unbox<bool>
            v846 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v847 : IFsExistsSync = Fable.Core.JsInterop.importAll v547
            let v848 : string = "$0.existsSync($1)"
            let v849 : bool = Fable.Core.JsInterop.emitJsExpr struct (v847, v832) v848
            v849 
            #endif
#if FABLE_COMPILER_PYTHON
            let v850 : bool = null |> unbox<bool>
            v850 
            #endif
#else
            let v851 : (string -> bool) = System.IO.File.Exists
            let v852 : bool = v851 v832
            v852 
            #endif
            |> fun x -> _v833 <- Some x
            let v853 : bool = _v833.Value
            let v854 : bool = v853 = false
            let v886 : bool =
                if v854 then
                    let v855 : bool = true
                    let mutable _v855 : bool option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v856 : string = "&*$0"
                    let v857 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v831 v856
                    let v858 : string = "String::from($0)"
                    let v859 : std_string_String = Fable.Core.RustInterop.emitRustExpr v857 v858
                    let v860 : string = "std::path::PathBuf::from($0)"
                    let v861 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v859 v860
                    let v862 : string = "$0.exists()"
                    let v863 : bool = Fable.Core.RustInterop.emitRustExpr v861 v862
                    let v866 : bool =
                        if v863 then
                            let v864 : string = "$0.is_file()"
                            let v865 : bool = Fable.Core.RustInterop.emitRustExpr v861 v864
                            v865
                        else
                            false
                    v866 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v867 : bool = null |> unbox<bool>
                    v867 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v868 : bool = null |> unbox<bool>
                    v868 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v869 : IFsExistsSync = Fable.Core.JsInterop.importAll v547
                    let v870 : string = "$0.existsSync($1)"
                    let v871 : bool = Fable.Core.JsInterop.emitJsExpr struct (v869, v831) v870
                    v871 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v872 : bool = null |> unbox<bool>
                    v872 
                    #endif
#else
                    let v873 : (string -> bool) = System.IO.File.Exists
                    let v874 : bool = v873 v831
                    v874 
                    #endif
                    |> fun x -> _v855 <- Some x
                    let v875 : bool = _v855.Value
                    if v875 then
                        let v876 : US0 = US0_2
                        let v877 : (unit -> string) = closure64()
                        let v878 : (unit -> string) = closure65(v831, v832)
                        method3(v876, v877, v878)
                        let v879 : bool = true
                        let mutable _v879 : unit option = None 
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v880 : string = method59(v832)
                        let v881 : string = "std::fs::copy(&*$0, &*v880)"
                        let v882 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v831 v881
                        let v883 : string = "$0.unwrap()"
                        let v884 : uint64 = Fable.Core.RustInterop.emitRustExpr v882 v883
                        () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        null |> unbox<unit>
                        () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        null |> unbox<unit>
                        () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        null |> unbox<unit>
                        () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        null |> unbox<unit>
                        () 
                        #endif
#else
                        System.IO.File.Copy (v831, v832, true)
                        () 
                        #endif
                        |> fun x -> _v879 <- Some x
                        _v879.Value
                        false
                    else
                        true
                else
                    true
            let v889 : UH3 =
                if v886 then
                    let v887 : (string -> (string -> US18)) = closure60(v4, v3, v268)
                    UH3_1(v653, v252, v887, v830)
                else
                    v830
            let struct (v890 : string, v891 : string) = method57(v265, v252, v4)
            let v892 : bool = true
            let mutable _v892 : bool option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v893 : string = "&*$0"
            let v894 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v891 v893
            let v895 : string = "String::from($0)"
            let v896 : std_string_String = Fable.Core.RustInterop.emitRustExpr v894 v895
            let v897 : string = "std::path::PathBuf::from($0)"
            let v898 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v896 v897
            let v899 : string = "$0.exists()"
            let v900 : bool = Fable.Core.RustInterop.emitRustExpr v898 v899
            let v903 : bool =
                if v900 then
                    let v901 : string = "$0.is_file()"
                    let v902 : bool = Fable.Core.RustInterop.emitRustExpr v898 v901
                    v902
                else
                    false
            v903 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v904 : bool = null |> unbox<bool>
            v904 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v905 : bool = null |> unbox<bool>
            v905 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v906 : IFsExistsSync = Fable.Core.JsInterop.importAll v547
            let v907 : string = "$0.existsSync($1)"
            let v908 : bool = Fable.Core.JsInterop.emitJsExpr struct (v906, v891) v907
            v908 
            #endif
#if FABLE_COMPILER_PYTHON
            let v909 : bool = null |> unbox<bool>
            v909 
            #endif
#else
            let v910 : (string -> bool) = System.IO.File.Exists
            let v911 : bool = v910 v891
            v911 
            #endif
            |> fun x -> _v892 <- Some x
            let v912 : bool = _v892.Value
            let v913 : bool = v912 = false
            let v945 : bool =
                if v913 then
                    let v914 : bool = true
                    let mutable _v914 : bool option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v915 : string = "&*$0"
                    let v916 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v890 v915
                    let v917 : string = "String::from($0)"
                    let v918 : std_string_String = Fable.Core.RustInterop.emitRustExpr v916 v917
                    let v919 : string = "std::path::PathBuf::from($0)"
                    let v920 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v918 v919
                    let v921 : string = "$0.exists()"
                    let v922 : bool = Fable.Core.RustInterop.emitRustExpr v920 v921
                    let v925 : bool =
                        if v922 then
                            let v923 : string = "$0.is_file()"
                            let v924 : bool = Fable.Core.RustInterop.emitRustExpr v920 v923
                            v924
                        else
                            false
                    v925 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v926 : bool = null |> unbox<bool>
                    v926 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v927 : bool = null |> unbox<bool>
                    v927 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v928 : IFsExistsSync = Fable.Core.JsInterop.importAll v547
                    let v929 : string = "$0.existsSync($1)"
                    let v930 : bool = Fable.Core.JsInterop.emitJsExpr struct (v928, v890) v929
                    v930 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v931 : bool = null |> unbox<bool>
                    v931 
                    #endif
#else
                    let v932 : (string -> bool) = System.IO.File.Exists
                    let v933 : bool = v932 v890
                    v933 
                    #endif
                    |> fun x -> _v914 <- Some x
                    let v934 : bool = _v914.Value
                    if v934 then
                        let v935 : US0 = US0_2
                        let v936 : (unit -> string) = closure64()
                        let v937 : (unit -> string) = closure65(v890, v891)
                        method3(v935, v936, v937)
                        let v938 : bool = true
                        let mutable _v938 : unit option = None 
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v939 : string = method59(v891)
                        let v940 : string = "std::fs::copy(&*$0, &*v939)"
                        let v941 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v890 v940
                        let v942 : string = "$0.unwrap()"
                        let v943 : uint64 = Fable.Core.RustInterop.emitRustExpr v941 v942
                        () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        null |> unbox<unit>
                        () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        null |> unbox<unit>
                        () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        null |> unbox<unit>
                        () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        null |> unbox<unit>
                        () 
                        #endif
#else
                        System.IO.File.Copy (v890, v891, true)
                        () 
                        #endif
                        |> fun x -> _v938 <- Some x
                        _v938.Value
                        false
                    else
                        true
                else
                    true
            let v950 : UH3 =
                if v945 then
                    let v946 : (string -> (string -> US18)) = closure53(v4, v3, v1, v0)
                    let v947 : UH3 = UH3_0
                    UH3_1(v265, v252, v946, v947)
                else
                    UH3_0
            let v951 : UH2 = UH2_0
            let v952 : UH2 = UH2_1(v889, v951)
            UH2_1(v950, v952)
    let v955 : UH3 list = []
    let v956 : UH3 list = method67(v954, v955)
    let v957 : (UH3 list -> (UH3 [])) = List.toArray
    let v958 : (UH3 []) = v957 v956
    let v959 : string = "$0.to_vec()"
    let v960 : Vec<UH3> = Fable.Core.RustInterop.emitRustExpr v958 v959
    let v961 : (Result<string, (string * string)> option []) = [||]
    let v962 : string = "$0.to_vec()"
    let v963 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v961 v962
    let v964 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v965 : (UH3 []) = Fable.Core.RustInterop.emitRustExpr v960 v964
    let v966 : int32 = v965.Length
    let v967 : Mut8 = {l0 = 0; l1 = v963} : Mut8
    while method68(v966, v967) do
        let v969 : int32 = v967.l0
        let v970 : Vec<Result<string, (string * string)> option> = v967.l1
        let v971 : UH3 = v965.[int v969]
        let v972 : struct (string * string * (string -> (string -> US18))) list = []
        let v973 : struct (string * string * (string -> (string -> US18))) list = method69(v971, v972)
        let v974 : (struct (string * string * (string -> (string -> US18))) list -> (struct (string * string * (string -> (string -> US18))) [])) = List.toArray
        let v975 : (struct (string * string * (string -> (string -> US18))) []) = v974 v973
        let v976 : string = "$0.to_vec()"
        let v977 : Vec<struct (string * string * (string -> (string -> US18)))> = Fable.Core.RustInterop.emitRustExpr v975 v976
        let v978 : string = "rayon::iter::IntoParallelIterator::into_par_iter(v977)"
        let v979 : rayon_vec_IntoIter<struct (string * string * (string -> (string -> US18)))> = Fable.Core.RustInterop.emitRustExpr () v978
        let v980 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
        let v981 : (struct (string * string * (string -> (string -> US18))) -> Result<string, (string * string)> option) = closure66()
        let v982 : rayon_iter_Map<rayon_vec_IntoIter<struct (string * string * (string -> (string -> US18)))>> = Fable.Core.RustInterop.emitRustExpr struct (v979, v981) v980
        let v983 : string = "rayon::iter::ParallelIterator::collect($0)"
        let v984 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v982 v983
        let v985 : Vec<Result<string, (string * string)> option> = method70(v984)
        let v986 : Vec<Result<string, (string * string)> option> = method71(v970)
        let v987 : string = "true; let mut v986 = v986"
        let v988 : bool = Fable.Core.RustInterop.emitRustExpr () v987
        let v989 : string = "true; v986.extend(v985)"
        let v990 : bool = Fable.Core.RustInterop.emitRustExpr () v989
        let v991 : string = "v986"
        let v992 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr () v991
        let v993 : int32 = v969 + 1
        v967.l0 <- v993
        v967.l1 <- v992
        ()
    let v994 : Vec<Result<string, (string * string)> option> = v967.l1
    let v995 : (string * Vec<Result<string, (string * string)> option>) = v238, v994
    let v996 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v995
    v996
and closure67 () () : string =
    let v0 : string = "documents.run"
    v0
and closure68 (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) () : string =
    let v1 : string = "$0.len()"
    let v2 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"result_len: {v2} / {v3 ()}"
    v4
and method72 (v0 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>) : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> =
    v0
and method10 (v0 : string, v1 : string, v2 : string, v3 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> =
    let v4 : string = __SOURCE_DIRECTORY__
    let v5 : string = "polyglot"
    let v6 : string = ".paket"
    let v7 : string = method11(v5, v6)
    let v8 : string = method14(v7, v4)
    let v9 : string = method11(v8, v5)
    let v10 : bool = true
    let mutable _v10 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = method17(v3)
    let v12 : string = "&*$0"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "String::from($0)"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "std::path::PathBuf::from($0)"
    let v17 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.exists()"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : bool = v19 = false
    let v176 : string =
        if v20 then
            let v21 : bool = true
            let mutable _v21 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v22 : string = "std::env::current_dir()"
            let v23 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v22
            let v24 : string = "$0.unwrap()"
            let v25 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v23 v24
            let v26 : string = "$0.display()"
            let v27 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v25 v26
            let v28 : bool = true
            let mutable _v28 : std_string_String option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v29 : string = "format!(\"{}\", $0)"
            let v30 : std_string_String = Fable.Core.RustInterop.emitRustExpr v27 v29
            v30 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v31 : string = "format!(\"{}\", $0)"
            let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v27 v31
            v32 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v33 : string = "format!(\"{}\", $0)"
            let v34 : std_string_String = Fable.Core.RustInterop.emitRustExpr v27 v33
            v34 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v35 : std_string_String = null |> unbox<std_string_String>
            v35 
            #endif
#if FABLE_COMPILER_PYTHON
            let v36 : std_string_String = null |> unbox<std_string_String>
            v36 
            #endif
#else
            let v37 : std_string_String = null |> unbox<std_string_String>
            v37 
            #endif
            |> fun x -> _v28 <- Some x
            let v38 : std_string_String = _v28.Value
            let v39 : string = "fable_library_rust::String_::fromString($0)"
            let v40 : string = Fable.Core.RustInterop.emitRustExpr v38 v39
            v40 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v41 : string = null |> unbox<string>
            v41 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v42 : string = null |> unbox<string>
            v42 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v43 : string = null |> unbox<string>
            v43 
            #endif
#if FABLE_COMPILER_PYTHON
            let v44 : string = null |> unbox<string>
            v44 
            #endif
#else
            let v45 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v46 : string = v45 ()
            v46 
            #endif
            |> fun x -> _v21 <- Some x
            let v47 : string = _v21.Value
            let v48 : string = method11(v47, v11)
            let v49 : bool = true
            let mutable _v49 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v50 : string = method18(v48)
            let v51 : string = method19()
            let v52 : bool = true
            let mutable _v52 : Result<regex_Regex, regex_Error> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v53 : string = method20()
            let v54 : string = $"regex::Regex::new(&$0)"
            let v55 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v53 v54
            v55 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v56 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v56 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v57 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v57 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v58 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v58 
            #endif
#if FABLE_COMPILER_PYTHON
            let v59 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v59 
            #endif
#else
            let v60 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v60 
            #endif
            |> fun x -> _v52 <- Some x
            let v61 : Result<regex_Regex, regex_Error> = _v52.Value
            let v62 : string = "$0.unwrap()"
            let v63 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v61 v62
            let v64 : string = $"$0.replace_all(&$1, &*$2)"
            let v65 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v63, v50, v51) v64
            let v66 : string = "String::from($0)"
            let v67 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v66
            let v68 : string = "fable_library_rust::String_::fromString($0)"
            let v69 : string = Fable.Core.RustInterop.emitRustExpr v67 v68
            v69 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v70 : string = null |> unbox<string>
            v70 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v71 : string = null |> unbox<string>
            v71 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v72 : string = null |> unbox<string>
            v72 
            #endif
#if FABLE_COMPILER_PYTHON
            let v73 : string = null |> unbox<string>
            v73 
            #endif
#else
            let v74 : string = method21()
            let v75 : string = "^\\\\\\\\\\?\\\\"
            let v76 : string = System.Text.RegularExpressions.Regex.Replace (v48, v75, v74)
            v76 
            #endif
            |> fun x -> _v49 <- Some x
            let v77 : string = _v49.Value
            let v78 : string = $"{v77.[0] |> string |> _.ToLower()}{v77.[1..]}"
            let v79 : string = "\\"
            let v80 : string = "/"
            let v81 : string = v78.Replace (v79, v80)
            let v82 : (string []) = v81.Split v80
            let v83 : (string []) = [||]
            let v84 : int32 = v82.Length
            let v85 : Mut4 = {l0 = 0; l1 = 0; l2 = v83} : Mut4
            while method22(v84, v85) do
                let v87 : int32 = v85.l0
                let v88 : int32 =  -v87
                let v89 : int32 = v88 + v84
                let v90 : int32 = v89 - 1
                let struct (v91 : int32, v92 : (string [])) = v85.l1, v85.l2
                let v93 : string = v82.[int v90]
                let v94 : bool = ".." = v93
                let struct (v136 : int32, v137 : (string [])) =
                    if v94 then
                        let v95 : int32 = v91 + 1
                        struct (v95, v92)
                    else
                        let v96 : bool = "." = v93
                        if v96 then
                            struct (v91, v92)
                        else
                            let v97 : bool = 0 = v91
                            if v97 then
                                let v98 : string = ":"
                                let v99 : bool = v93.EndsWith v98
                                if v99 then
                                    let v100 : string = $"{v47.[0]}:"
                                    let v101 : (string []) = [|v100|]
                                    let v102 : int32 = v101.Length
                                    let v103 : int32 = v92.Length
                                    let v104 : int32 = v102 + v103
                                    let v105 : (string []) = Array.zeroCreate<string> (v104)
                                    let v106 : Mut5 = {l0 = 0} : Mut5
                                    while method23(v104, v106) do
                                        let v108 : int32 = v106.l0
                                        let v109 : bool = v108 < v102
                                        let v113 : string =
                                            if v109 then
                                                let v110 : string = v101.[int v108]
                                                v110
                                            else
                                                let v111 : int32 = v108 - v102
                                                let v112 : string = v92.[int v111]
                                                v112
                                        v105.[int v108] <- v113
                                        let v114 : int32 = v108 + 1
                                        v106.l0 <- v114
                                        ()
                                    struct (0, v105)
                                else
                                    let v115 : (string []) = [|v93|]
                                    let v116 : int32 = v115.Length
                                    let v117 : int32 = v92.Length
                                    let v118 : int32 = v116 + v117
                                    let v119 : (string []) = Array.zeroCreate<string> (v118)
                                    let v120 : Mut5 = {l0 = 0} : Mut5
                                    while method23(v118, v120) do
                                        let v122 : int32 = v120.l0
                                        let v123 : bool = v122 < v116
                                        let v127 : string =
                                            if v123 then
                                                let v124 : string = v115.[int v122]
                                                v124
                                            else
                                                let v125 : int32 = v122 - v116
                                                let v126 : string = v92.[int v125]
                                                v126
                                        v119.[int v122] <- v127
                                        let v128 : int32 = v122 + 1
                                        v120.l0 <- v128
                                        ()
                                    struct (0, v119)
                            else
                                let v131 : int32 = v91 - 1
                                struct (v131, v92)
                let v138 : int32 = v87 + 1
                v85.l0 <- v138
                v85.l1 <- v136
                v85.l2 <- v137
                ()
            let struct (v139 : int32, v140 : (string [])) = v85.l1, v85.l2
            let v141 : string seq = seq { for i = 0 to v140.Length - 1 do yield v140.[i] }
            let v142 : bool = true
            let mutable _v142 : char option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v143 : string = "std::path::MAIN_SEPARATOR"
            let v144 : char = Fable.Core.RustInterop.emitRustExpr () v143
            v144 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v145 : char = null |> unbox<char>
            v145 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v146 : char = null |> unbox<char>
            v146 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v147 : char = null |> unbox<char>
            v147 
            #endif
#if FABLE_COMPILER_PYTHON
            let v148 : char = null |> unbox<char>
            v148 
            #endif
#else
            let v149 : char = System.IO.Path.DirectorySeparatorChar
            v149 
            #endif
            |> fun x -> _v142 <- Some x
            let v150 : char = _v142.Value
            let v151 : (char -> string) = _.ToString()
            let v152 : string = v151 v150
            let v153 : string = method24(v152)
            let v154 : (string -> (string seq -> string)) = String.concat
            let v155 : (string seq -> string) = v154 v153
            v155 v141
        else
            let v157 : string = "std::fs::canonicalize(&*$0)"
            let v158 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v11 v157
            let v159 : string = "$0.unwrap()"
            let v160 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v158 v159
            let v161 : string = "$0.display()"
            let v162 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v160 v161
            let v163 : bool = true
            let mutable _v163 : std_string_String option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v164 : string = "format!(\"{}\", $0)"
            let v165 : std_string_String = Fable.Core.RustInterop.emitRustExpr v162 v164
            v165 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v166 : string = "format!(\"{}\", $0)"
            let v167 : std_string_String = Fable.Core.RustInterop.emitRustExpr v162 v166
            v167 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v168 : string = "format!(\"{}\", $0)"
            let v169 : std_string_String = Fable.Core.RustInterop.emitRustExpr v162 v168
            v169 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v170 : std_string_String = null |> unbox<std_string_String>
            v170 
            #endif
#if FABLE_COMPILER_PYTHON
            let v171 : std_string_String = null |> unbox<std_string_String>
            v171 
            #endif
#else
            let v172 : std_string_String = null |> unbox<std_string_String>
            v172 
            #endif
            |> fun x -> _v163 <- Some x
            let v173 : std_string_String = _v163.Value
            let v174 : string = "fable_library_rust::String_::fromString($0)"
            let v175 : string = Fable.Core.RustInterop.emitRustExpr v173 v174
            v175
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v177 : string = null |> unbox<string>
    v177 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v178 : string = null |> unbox<string>
    v178 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v179 : string = null |> unbox<string>
    v179 
    #endif
#if FABLE_COMPILER_PYTHON
    let v180 : string = null |> unbox<string>
    v180 
    #endif
#else
    let v181 : string = method25(v3)
    let v182 : (string -> string) = System.IO.Path.GetFullPath
    let v183 : string = v182 v181
    v183 
    #endif
    |> fun x -> _v10 <- Some x
    let v184 : string = _v10.Value
    let v185 : bool = true
    let mutable _v185 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v186 : string = method17(v2)
    let v187 : string = "&*$0"
    let v188 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v186 v187
    let v189 : string = "String::from($0)"
    let v190 : std_string_String = Fable.Core.RustInterop.emitRustExpr v188 v189
    let v191 : string = "std::path::PathBuf::from($0)"
    let v192 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v190 v191
    let v193 : string = "$0.exists()"
    let v194 : bool = Fable.Core.RustInterop.emitRustExpr v192 v193
    let v195 : bool = v194 = false
    let v351 : string =
        if v195 then
            let v196 : bool = true
            let mutable _v196 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v197 : string = "std::env::current_dir()"
            let v198 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v197
            let v199 : string = "$0.unwrap()"
            let v200 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v198 v199
            let v201 : string = "$0.display()"
            let v202 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v200 v201
            let v203 : bool = true
            let mutable _v203 : std_string_String option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v204 : string = "format!(\"{}\", $0)"
            let v205 : std_string_String = Fable.Core.RustInterop.emitRustExpr v202 v204
            v205 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v206 : string = "format!(\"{}\", $0)"
            let v207 : std_string_String = Fable.Core.RustInterop.emitRustExpr v202 v206
            v207 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v208 : string = "format!(\"{}\", $0)"
            let v209 : std_string_String = Fable.Core.RustInterop.emitRustExpr v202 v208
            v209 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v210 : std_string_String = null |> unbox<std_string_String>
            v210 
            #endif
#if FABLE_COMPILER_PYTHON
            let v211 : std_string_String = null |> unbox<std_string_String>
            v211 
            #endif
#else
            let v212 : std_string_String = null |> unbox<std_string_String>
            v212 
            #endif
            |> fun x -> _v203 <- Some x
            let v213 : std_string_String = _v203.Value
            let v214 : string = "fable_library_rust::String_::fromString($0)"
            let v215 : string = Fable.Core.RustInterop.emitRustExpr v213 v214
            v215 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v216 : string = null |> unbox<string>
            v216 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v217 : string = null |> unbox<string>
            v217 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v218 : string = null |> unbox<string>
            v218 
            #endif
#if FABLE_COMPILER_PYTHON
            let v219 : string = null |> unbox<string>
            v219 
            #endif
#else
            let v220 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v221 : string = v220 ()
            v221 
            #endif
            |> fun x -> _v196 <- Some x
            let v222 : string = _v196.Value
            let v223 : string = method11(v222, v186)
            let v224 : bool = true
            let mutable _v224 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v225 : string = method18(v223)
            let v226 : string = method19()
            let v227 : bool = true
            let mutable _v227 : Result<regex_Regex, regex_Error> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v228 : string = method20()
            let v229 : string = $"regex::Regex::new(&$0)"
            let v230 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v228 v229
            v230 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v231 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v231 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v232 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v232 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v233 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v233 
            #endif
#if FABLE_COMPILER_PYTHON
            let v234 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v234 
            #endif
#else
            let v235 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v235 
            #endif
            |> fun x -> _v227 <- Some x
            let v236 : Result<regex_Regex, regex_Error> = _v227.Value
            let v237 : string = "$0.unwrap()"
            let v238 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v236 v237
            let v239 : string = $"$0.replace_all(&$1, &*$2)"
            let v240 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v238, v225, v226) v239
            let v241 : string = "String::from($0)"
            let v242 : std_string_String = Fable.Core.RustInterop.emitRustExpr v240 v241
            let v243 : string = "fable_library_rust::String_::fromString($0)"
            let v244 : string = Fable.Core.RustInterop.emitRustExpr v242 v243
            v244 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v245 : string = null |> unbox<string>
            v245 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v246 : string = null |> unbox<string>
            v246 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v247 : string = null |> unbox<string>
            v247 
            #endif
#if FABLE_COMPILER_PYTHON
            let v248 : string = null |> unbox<string>
            v248 
            #endif
#else
            let v249 : string = method21()
            let v250 : string = "^\\\\\\\\\\?\\\\"
            let v251 : string = System.Text.RegularExpressions.Regex.Replace (v223, v250, v249)
            v251 
            #endif
            |> fun x -> _v224 <- Some x
            let v252 : string = _v224.Value
            let v253 : string = $"{v252.[0] |> string |> _.ToLower()}{v252.[1..]}"
            let v254 : string = "\\"
            let v255 : string = "/"
            let v256 : string = v253.Replace (v254, v255)
            let v257 : (string []) = v256.Split v255
            let v258 : (string []) = [||]
            let v259 : int32 = v257.Length
            let v260 : Mut4 = {l0 = 0; l1 = 0; l2 = v258} : Mut4
            while method22(v259, v260) do
                let v262 : int32 = v260.l0
                let v263 : int32 =  -v262
                let v264 : int32 = v263 + v259
                let v265 : int32 = v264 - 1
                let struct (v266 : int32, v267 : (string [])) = v260.l1, v260.l2
                let v268 : string = v257.[int v265]
                let v269 : bool = ".." = v268
                let struct (v311 : int32, v312 : (string [])) =
                    if v269 then
                        let v270 : int32 = v266 + 1
                        struct (v270, v267)
                    else
                        let v271 : bool = "." = v268
                        if v271 then
                            struct (v266, v267)
                        else
                            let v272 : bool = 0 = v266
                            if v272 then
                                let v273 : string = ":"
                                let v274 : bool = v268.EndsWith v273
                                if v274 then
                                    let v275 : string = $"{v222.[0]}:"
                                    let v276 : (string []) = [|v275|]
                                    let v277 : int32 = v276.Length
                                    let v278 : int32 = v267.Length
                                    let v279 : int32 = v277 + v278
                                    let v280 : (string []) = Array.zeroCreate<string> (v279)
                                    let v281 : Mut5 = {l0 = 0} : Mut5
                                    while method23(v279, v281) do
                                        let v283 : int32 = v281.l0
                                        let v284 : bool = v283 < v277
                                        let v288 : string =
                                            if v284 then
                                                let v285 : string = v276.[int v283]
                                                v285
                                            else
                                                let v286 : int32 = v283 - v277
                                                let v287 : string = v267.[int v286]
                                                v287
                                        v280.[int v283] <- v288
                                        let v289 : int32 = v283 + 1
                                        v281.l0 <- v289
                                        ()
                                    struct (0, v280)
                                else
                                    let v290 : (string []) = [|v268|]
                                    let v291 : int32 = v290.Length
                                    let v292 : int32 = v267.Length
                                    let v293 : int32 = v291 + v292
                                    let v294 : (string []) = Array.zeroCreate<string> (v293)
                                    let v295 : Mut5 = {l0 = 0} : Mut5
                                    while method23(v293, v295) do
                                        let v297 : int32 = v295.l0
                                        let v298 : bool = v297 < v291
                                        let v302 : string =
                                            if v298 then
                                                let v299 : string = v290.[int v297]
                                                v299
                                            else
                                                let v300 : int32 = v297 - v291
                                                let v301 : string = v267.[int v300]
                                                v301
                                        v294.[int v297] <- v302
                                        let v303 : int32 = v297 + 1
                                        v295.l0 <- v303
                                        ()
                                    struct (0, v294)
                            else
                                let v306 : int32 = v266 - 1
                                struct (v306, v267)
                let v313 : int32 = v262 + 1
                v260.l0 <- v313
                v260.l1 <- v311
                v260.l2 <- v312
                ()
            let struct (v314 : int32, v315 : (string [])) = v260.l1, v260.l2
            let v316 : string seq = seq { for i = 0 to v315.Length - 1 do yield v315.[i] }
            let v317 : bool = true
            let mutable _v317 : char option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v318 : string = "std::path::MAIN_SEPARATOR"
            let v319 : char = Fable.Core.RustInterop.emitRustExpr () v318
            v319 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v320 : char = null |> unbox<char>
            v320 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v321 : char = null |> unbox<char>
            v321 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v322 : char = null |> unbox<char>
            v322 
            #endif
#if FABLE_COMPILER_PYTHON
            let v323 : char = null |> unbox<char>
            v323 
            #endif
#else
            let v324 : char = System.IO.Path.DirectorySeparatorChar
            v324 
            #endif
            |> fun x -> _v317 <- Some x
            let v325 : char = _v317.Value
            let v326 : (char -> string) = _.ToString()
            let v327 : string = v326 v325
            let v328 : string = method24(v327)
            let v329 : (string -> (string seq -> string)) = String.concat
            let v330 : (string seq -> string) = v329 v328
            v330 v316
        else
            let v332 : string = "std::fs::canonicalize(&*$0)"
            let v333 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v186 v332
            let v334 : string = "$0.unwrap()"
            let v335 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v333 v334
            let v336 : string = "$0.display()"
            let v337 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v335 v336
            let v338 : bool = true
            let mutable _v338 : std_string_String option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v339 : string = "format!(\"{}\", $0)"
            let v340 : std_string_String = Fable.Core.RustInterop.emitRustExpr v337 v339
            v340 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v341 : string = "format!(\"{}\", $0)"
            let v342 : std_string_String = Fable.Core.RustInterop.emitRustExpr v337 v341
            v342 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v343 : string = "format!(\"{}\", $0)"
            let v344 : std_string_String = Fable.Core.RustInterop.emitRustExpr v337 v343
            v344 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v345 : std_string_String = null |> unbox<std_string_String>
            v345 
            #endif
#if FABLE_COMPILER_PYTHON
            let v346 : std_string_String = null |> unbox<std_string_String>
            v346 
            #endif
#else
            let v347 : std_string_String = null |> unbox<std_string_String>
            v347 
            #endif
            |> fun x -> _v338 <- Some x
            let v348 : std_string_String = _v338.Value
            let v349 : string = "fable_library_rust::String_::fromString($0)"
            let v350 : string = Fable.Core.RustInterop.emitRustExpr v348 v349
            v350
    v351 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v352 : string = null |> unbox<string>
    v352 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v353 : string = null |> unbox<string>
    v353 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v354 : string = null |> unbox<string>
    v354 
    #endif
#if FABLE_COMPILER_PYTHON
    let v355 : string = null |> unbox<string>
    v355 
    #endif
#else
    let v356 : string = method25(v2)
    let v357 : (string -> string) = System.IO.Path.GetFullPath
    let v358 : string = v357 v356
    v358 
    #endif
    |> fun x -> _v185 <- Some x
    let v359 : string = _v185.Value
    let v360 : bool = true
    let mutable _v360 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v361 : string = method17(v1)
    let v362 : string = "&*$0"
    let v363 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v361 v362
    let v364 : string = "String::from($0)"
    let v365 : std_string_String = Fable.Core.RustInterop.emitRustExpr v363 v364
    let v366 : string = "std::path::PathBuf::from($0)"
    let v367 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v365 v366
    let v368 : string = "$0.exists()"
    let v369 : bool = Fable.Core.RustInterop.emitRustExpr v367 v368
    let v370 : bool = v369 = false
    let v526 : string =
        if v370 then
            let v371 : bool = true
            let mutable _v371 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v372 : string = "std::env::current_dir()"
            let v373 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v372
            let v374 : string = "$0.unwrap()"
            let v375 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v373 v374
            let v376 : string = "$0.display()"
            let v377 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v375 v376
            let v378 : bool = true
            let mutable _v378 : std_string_String option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v379 : string = "format!(\"{}\", $0)"
            let v380 : std_string_String = Fable.Core.RustInterop.emitRustExpr v377 v379
            v380 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v381 : string = "format!(\"{}\", $0)"
            let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr v377 v381
            v382 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v383 : string = "format!(\"{}\", $0)"
            let v384 : std_string_String = Fable.Core.RustInterop.emitRustExpr v377 v383
            v384 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v385 : std_string_String = null |> unbox<std_string_String>
            v385 
            #endif
#if FABLE_COMPILER_PYTHON
            let v386 : std_string_String = null |> unbox<std_string_String>
            v386 
            #endif
#else
            let v387 : std_string_String = null |> unbox<std_string_String>
            v387 
            #endif
            |> fun x -> _v378 <- Some x
            let v388 : std_string_String = _v378.Value
            let v389 : string = "fable_library_rust::String_::fromString($0)"
            let v390 : string = Fable.Core.RustInterop.emitRustExpr v388 v389
            v390 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v391 : string = null |> unbox<string>
            v391 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v392 : string = null |> unbox<string>
            v392 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v393 : string = null |> unbox<string>
            v393 
            #endif
#if FABLE_COMPILER_PYTHON
            let v394 : string = null |> unbox<string>
            v394 
            #endif
#else
            let v395 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v396 : string = v395 ()
            v396 
            #endif
            |> fun x -> _v371 <- Some x
            let v397 : string = _v371.Value
            let v398 : string = method11(v397, v361)
            let v399 : bool = true
            let mutable _v399 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v400 : string = method18(v398)
            let v401 : string = method19()
            let v402 : bool = true
            let mutable _v402 : Result<regex_Regex, regex_Error> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v403 : string = method20()
            let v404 : string = $"regex::Regex::new(&$0)"
            let v405 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v403 v404
            v405 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v406 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v406 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v407 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v407 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v408 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v408 
            #endif
#if FABLE_COMPILER_PYTHON
            let v409 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v409 
            #endif
#else
            let v410 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v410 
            #endif
            |> fun x -> _v402 <- Some x
            let v411 : Result<regex_Regex, regex_Error> = _v402.Value
            let v412 : string = "$0.unwrap()"
            let v413 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v411 v412
            let v414 : string = $"$0.replace_all(&$1, &*$2)"
            let v415 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v413, v400, v401) v414
            let v416 : string = "String::from($0)"
            let v417 : std_string_String = Fable.Core.RustInterop.emitRustExpr v415 v416
            let v418 : string = "fable_library_rust::String_::fromString($0)"
            let v419 : string = Fable.Core.RustInterop.emitRustExpr v417 v418
            v419 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v420 : string = null |> unbox<string>
            v420 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v421 : string = null |> unbox<string>
            v421 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v422 : string = null |> unbox<string>
            v422 
            #endif
#if FABLE_COMPILER_PYTHON
            let v423 : string = null |> unbox<string>
            v423 
            #endif
#else
            let v424 : string = method21()
            let v425 : string = "^\\\\\\\\\\?\\\\"
            let v426 : string = System.Text.RegularExpressions.Regex.Replace (v398, v425, v424)
            v426 
            #endif
            |> fun x -> _v399 <- Some x
            let v427 : string = _v399.Value
            let v428 : string = $"{v427.[0] |> string |> _.ToLower()}{v427.[1..]}"
            let v429 : string = "\\"
            let v430 : string = "/"
            let v431 : string = v428.Replace (v429, v430)
            let v432 : (string []) = v431.Split v430
            let v433 : (string []) = [||]
            let v434 : int32 = v432.Length
            let v435 : Mut4 = {l0 = 0; l1 = 0; l2 = v433} : Mut4
            while method22(v434, v435) do
                let v437 : int32 = v435.l0
                let v438 : int32 =  -v437
                let v439 : int32 = v438 + v434
                let v440 : int32 = v439 - 1
                let struct (v441 : int32, v442 : (string [])) = v435.l1, v435.l2
                let v443 : string = v432.[int v440]
                let v444 : bool = ".." = v443
                let struct (v486 : int32, v487 : (string [])) =
                    if v444 then
                        let v445 : int32 = v441 + 1
                        struct (v445, v442)
                    else
                        let v446 : bool = "." = v443
                        if v446 then
                            struct (v441, v442)
                        else
                            let v447 : bool = 0 = v441
                            if v447 then
                                let v448 : string = ":"
                                let v449 : bool = v443.EndsWith v448
                                if v449 then
                                    let v450 : string = $"{v397.[0]}:"
                                    let v451 : (string []) = [|v450|]
                                    let v452 : int32 = v451.Length
                                    let v453 : int32 = v442.Length
                                    let v454 : int32 = v452 + v453
                                    let v455 : (string []) = Array.zeroCreate<string> (v454)
                                    let v456 : Mut5 = {l0 = 0} : Mut5
                                    while method23(v454, v456) do
                                        let v458 : int32 = v456.l0
                                        let v459 : bool = v458 < v452
                                        let v463 : string =
                                            if v459 then
                                                let v460 : string = v451.[int v458]
                                                v460
                                            else
                                                let v461 : int32 = v458 - v452
                                                let v462 : string = v442.[int v461]
                                                v462
                                        v455.[int v458] <- v463
                                        let v464 : int32 = v458 + 1
                                        v456.l0 <- v464
                                        ()
                                    struct (0, v455)
                                else
                                    let v465 : (string []) = [|v443|]
                                    let v466 : int32 = v465.Length
                                    let v467 : int32 = v442.Length
                                    let v468 : int32 = v466 + v467
                                    let v469 : (string []) = Array.zeroCreate<string> (v468)
                                    let v470 : Mut5 = {l0 = 0} : Mut5
                                    while method23(v468, v470) do
                                        let v472 : int32 = v470.l0
                                        let v473 : bool = v472 < v466
                                        let v477 : string =
                                            if v473 then
                                                let v474 : string = v465.[int v472]
                                                v474
                                            else
                                                let v475 : int32 = v472 - v466
                                                let v476 : string = v442.[int v475]
                                                v476
                                        v469.[int v472] <- v477
                                        let v478 : int32 = v472 + 1
                                        v470.l0 <- v478
                                        ()
                                    struct (0, v469)
                            else
                                let v481 : int32 = v441 - 1
                                struct (v481, v442)
                let v488 : int32 = v437 + 1
                v435.l0 <- v488
                v435.l1 <- v486
                v435.l2 <- v487
                ()
            let struct (v489 : int32, v490 : (string [])) = v435.l1, v435.l2
            let v491 : string seq = seq { for i = 0 to v490.Length - 1 do yield v490.[i] }
            let v492 : bool = true
            let mutable _v492 : char option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v493 : string = "std::path::MAIN_SEPARATOR"
            let v494 : char = Fable.Core.RustInterop.emitRustExpr () v493
            v494 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v495 : char = null |> unbox<char>
            v495 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v496 : char = null |> unbox<char>
            v496 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v497 : char = null |> unbox<char>
            v497 
            #endif
#if FABLE_COMPILER_PYTHON
            let v498 : char = null |> unbox<char>
            v498 
            #endif
#else
            let v499 : char = System.IO.Path.DirectorySeparatorChar
            v499 
            #endif
            |> fun x -> _v492 <- Some x
            let v500 : char = _v492.Value
            let v501 : (char -> string) = _.ToString()
            let v502 : string = v501 v500
            let v503 : string = method24(v502)
            let v504 : (string -> (string seq -> string)) = String.concat
            let v505 : (string seq -> string) = v504 v503
            v505 v491
        else
            let v507 : string = "std::fs::canonicalize(&*$0)"
            let v508 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v361 v507
            let v509 : string = "$0.unwrap()"
            let v510 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v508 v509
            let v511 : string = "$0.display()"
            let v512 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v510 v511
            let v513 : bool = true
            let mutable _v513 : std_string_String option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v514 : string = "format!(\"{}\", $0)"
            let v515 : std_string_String = Fable.Core.RustInterop.emitRustExpr v512 v514
            v515 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v516 : string = "format!(\"{}\", $0)"
            let v517 : std_string_String = Fable.Core.RustInterop.emitRustExpr v512 v516
            v517 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v518 : string = "format!(\"{}\", $0)"
            let v519 : std_string_String = Fable.Core.RustInterop.emitRustExpr v512 v518
            v519 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v520 : std_string_String = null |> unbox<std_string_String>
            v520 
            #endif
#if FABLE_COMPILER_PYTHON
            let v521 : std_string_String = null |> unbox<std_string_String>
            v521 
            #endif
#else
            let v522 : std_string_String = null |> unbox<std_string_String>
            v522 
            #endif
            |> fun x -> _v513 <- Some x
            let v523 : std_string_String = _v513.Value
            let v524 : string = "fable_library_rust::String_::fromString($0)"
            let v525 : string = Fable.Core.RustInterop.emitRustExpr v523 v524
            v525
    v526 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v527 : string = null |> unbox<string>
    v527 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v528 : string = null |> unbox<string>
    v528 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v529 : string = null |> unbox<string>
    v529 
    #endif
#if FABLE_COMPILER_PYTHON
    let v530 : string = null |> unbox<string>
    v530 
    #endif
#else
    let v531 : string = method25(v1)
    let v532 : (string -> string) = System.IO.Path.GetFullPath
    let v533 : string = v532 v531
    v533 
    #endif
    |> fun x -> _v360 <- Some x
    let v534 : string = _v360.Value
    let v535 : US0 = US0_1
    let v536 : (unit -> string) = closure9()
    let v537 : (unit -> string) = closure10(v0, v184, v359, v534)
    method3(v535, v536, v537)
    let v538 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v538
    let v539 : string = "async_walkdir::WalkDir::new(&*$0)"
    let v540 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr v359 v539
    let v541 : string = "async_walkdir::WalkDir::filter($0, |x| $1(x))"
    let v542 : (async_walkdir_DirEntry -> std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>>) = closure11()
    let v543 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr struct (v540, v542) v541
    let v544 : (Result<async_walkdir_DirEntry, std_io_Error> -> string option) = method33()
    let v545 : string = "futures_lite::stream::StreamExt::collect(futures_lite::stream::StreamExt::filter_map(v543, |x| v544(x))).await"
    let v546 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v545
    let v547 : US0 = US0_1
    let v548 : (unit -> string) = closure20()
    let v549 : (unit -> string) = closure21(v546)
    method3(v547, v548, v549)
    let v550 : string = "rayon::iter::IntoParallelIterator::into_par_iter(v546)"
    let v551 : rayon_vec_IntoIter<string> = Fable.Core.RustInterop.emitRustExpr () v550
    let v552 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
    let v553 : (string -> Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>) = closure22(v0, v9, v184, v359, v534)
    let v554 : rayon_iter_Map<rayon_vec_IntoIter<string>> = Fable.Core.RustInterop.emitRustExpr struct (v551, v553) v552
    let v555 : string = "rayon::iter::ParallelIterator::collect($0)"
    let v556 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = Fable.Core.RustInterop.emitRustExpr v554 v555
    let v557 : US0 = US0_2
    let v558 : (unit -> string) = closure67()
    let v559 : (unit -> string) = closure68(v556)
    method3(v557, v558, v559)
    let v560 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Ok v556
    let v561 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = method72(v560)
    let v562 : string = ""
    let v563 : string = "}"
    let v564 : string = v562 + v563
    let v565 : string = v564 + v563
    let v566 : string = v565 + v563
    let v567 : string = v566 + v563
    let v568 : string = "{"
    let v569 : string = v562 + v568
    let v570 : string = v569 + v568
    let v571 : string = v570 + v568
    let v572 : string = "v561 " + v567 + "); " + v571 + " //"
    Fable.Core.RustInterop.emitRustExpr () v572
    let v573 : string = "__result"
    let v574 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v573
    v574
and closure1 () (v0 : (string [])) : int32 =
    let v1 : (US0 -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure2()
    let v2 : US0 = US0_2
    if State.trace_state.IsNone then State.trace_state <- v1 v2 |> Some
    let v3 : US0 = US0_2
    let v4 : (unit -> string) = closure4()
    let v5 : (unit -> string) = closure5(v0)
    method3(v3, v4, v5)
    let v6 : clap_Command = method0()
    let v7 : string = "clap::Command::get_matches($0)"
    let v8 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = method6()
    let v10 : string = "&*$0"
    let v11 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "clap::ArgMatches::get_one(&$0, v11).cloned()"
    let v13 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v8 v12
    let v14 : US2 option = None
    let _v14 = ref v14 
    match v13 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v15 : std_string_String = x
    let v16 : US2 = US2_0(v15)
    v16 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v14.Value <- x
    let v17 : US2 option = _v14.Value 
    let v18 : US2 = US2_1
    let v19 : US2 = v17 |> Option.defaultValue v18 
    let v23 : std_string_String =
        match v19 with
        | US2_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US2_0(v20) -> (* Some *)
            v20
    let v24 : string = "fable_library_rust::String_::fromString($0)"
    let v25 : string = Fable.Core.RustInterop.emitRustExpr v23 v24
    let v26 : string = method7()
    let v27 : string = "&*$0"
    let v28 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v26 v27
    let v29 : string = "clap::ArgMatches::get_one(&$0, v28).cloned()"
    let v30 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v8 v29
    let v31 : US2 option = None
    let _v31 = ref v31 
    match v30 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v32 : std_string_String = x
    let v33 : US2 = US2_0(v32)
    v33 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v31.Value <- x
    let v34 : US2 option = _v31.Value 
    let v35 : US2 = US2_1
    let v36 : US2 = v34 |> Option.defaultValue v35 
    let v40 : std_string_String =
        match v36 with
        | US2_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US2_0(v37) -> (* Some *)
            v37
    let v41 : string = "fable_library_rust::String_::fromString($0)"
    let v42 : string = Fable.Core.RustInterop.emitRustExpr v40 v41
    let v43 : string = method8()
    let v44 : string = "&*$0"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v43 v44
    let v46 : string = "clap::ArgMatches::get_one(&$0, v45).cloned()"
    let v47 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v8 v46
    let v48 : US2 option = None
    let _v48 = ref v48 
    match v47 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v49 : std_string_String = x
    let v50 : US2 = US2_0(v49)
    v50 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v48.Value <- x
    let v51 : US2 option = _v48.Value 
    let v52 : US2 = US2_1
    let v53 : US2 = v51 |> Option.defaultValue v52 
    let v57 : std_string_String =
        match v53 with
        | US2_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US2_0(v54) -> (* Some *)
            v54
    let v58 : string = "fable_library_rust::String_::fromString($0)"
    let v59 : string = Fable.Core.RustInterop.emitRustExpr v57 v58
    let v60 : string = method9()
    let v61 : string = "&*$0"
    let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v61
    let v63 : string = "clap::ArgMatches::get_one(&$0, v62).cloned()"
    let v64 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v8 v63
    let v65 : US2 option = None
    let _v65 = ref v65 
    match v64 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v66 : std_string_String = x
    let v67 : US2 = US2_0(v66)
    v67 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v65.Value <- x
    let v68 : US2 option = _v65.Value 
    let v69 : US2 = US2_1
    let v70 : US2 = v68 |> Option.defaultValue v69 
    let v74 : std_string_String =
        match v70 with
        | US2_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US2_0(v71) -> (* Some *)
            v71
    let v75 : string = "fable_library_rust::String_::fromString($0)"
    let v76 : string = Fable.Core.RustInterop.emitRustExpr v74 v75
    let v77 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = method10(v76, v59, v42, v25)
    let v78 : string = "futures_lite::future::block_on($0)"
    let v79 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr v77 v78
    let v80 : string = "$0.unwrap()"
    let v81 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = Fable.Core.RustInterop.emitRustExpr v79 v80
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
