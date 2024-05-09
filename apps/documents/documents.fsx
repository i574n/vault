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
[<Fable.Core.Erase; Fable.Core.Emit("std::future::Future<Output = $0>")>]
#endif
type std_future_Future<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("futures::future::TryJoinAll<$0>")>]
#endif
type futures_future_TryJoinAll<'T> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type Any = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("$0 + Send")>]
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
[<Fable.Core.Erase; Fable.Core.Emit("&'static $0")>]
#endif
type StaticRef<'T> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("core::iter::Fuse<$0>")>]
#endif
type core_iter_Fuse<'T> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Output")>]
#endif
type std_process_Output = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Stdio")>]
#endif
type std_process_Stdio = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Receiver<$0>")>]
#endif
type std_sync_mpsc_Receiver<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Sender<$0>")>]
#endif
type std_sync_mpsc_Sender<'T> = class end
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
type Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : bool}
and [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
    | US0_4
and Mut2 = {mutable l0 : US0}
and Mut3 = {mutable l0 : (string -> unit)}
and [<Struct>] US1 =
    | US1_0 of f0_0 : int64
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : int64
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : std_string_String
    | US3_1
and [<Struct>] US4 =
    | US4_0 of f0_0 : string
    | US4_1
and Mut4 = {mutable l0 : int32; mutable l1 : int32; mutable l2 : (string [])}
and Mut5 = {mutable l0 : int32}
and [<Struct>] US5 =
    | US5_0
    | US5_1
    | US5_2
and [<Struct>] US6 =
    | US6_0 of f0_0 : std_fs_FileType
    | US6_1 of f1_0 : std_string_String
and [<Struct>] US7 =
    | US7_0 of f0_0 : async_walkdir_DirEntry
    | US7_1 of f1_0 : std_string_String
and UH0 =
    | UH0_0
    | UH0_1 of char * UH0
and [<Struct>] US9 =
    | US9_0
    | US9_1
and [<Struct>] US8 =
    | US8_0
    | US8_1 of f1_0 : US9
    | US8_2
and UH1 =
    | UH1_0
    | UH1_1 of string * UH1
and [<Struct>] US10 =
    | US10_0
    | US10_1 of f1_0 : char
    | US10_2 of f2_0 : uint8
and [<Struct>] US11 =
    | US11_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>
    | US11_1 of f1_0 : std_string_String
and [<Struct>] US12 =
    | US12_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>
    | US12_1
and [<Struct>] US13 =
    | US13_0 of f0_0 : std_string_String
    | US13_1 of f1_0 : std_string_String
and [<Struct>] US14 =
    | US14_0 of f0_0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)
    | US14_1
and [<Struct>] US15 =
    | US15_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>
    | US15_1
and [<Struct>] US16 =
    | US16_0 of f0_0 : std_process_Output
    | US16_1 of f1_0 : std_string_String
and [<Struct>] US17 =
    | US17_0 of f0_0 : (struct (bool * string * int32) -> Async<unit>)
    | US17_1
and [<Struct>] US18 =
    | US18_0 of f0_0 : System.Threading.CancellationToken
    | US18_1
and [<Struct>] US19 =
    | US19_0 of f0_0 : Result<string, (string * string)>
    | US19_1
and UH3 =
    | UH3_0
    | UH3_1 of string * string * (string -> (string -> US19)) * UH3
and UH2 =
    | UH2_0
    | UH2_1 of UH3 * UH2
and [<Struct>] US20 =
    | US20_0 of f0_0 : int32 * f0_1 : string
    | US20_1 of f1_0 : int32 * f1_1 : string
and Mut6 = {mutable l0 : int32; mutable l1 : int32}
and Mut7 = {mutable l0 : int32; mutable l1 : string; mutable l2 : int32; mutable l3 : int32}
and Mut8 = {mutable l0 : int32; mutable l1 : Vec<Result<string, (string * string)> option>}
let rec method0 () : clap_Command =
    let v0 : string = "command"
    let v1 : string = "r#\"" + v0 + "\"#"
    let v2 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v1
    let v3 : string = "clap::Command::new($0)"
    let v4 : clap_Command = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "source-dir"
    let v6 : string = "r#\"" + v5 + "\"#"
    let v7 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v6
    let v8 : string = "clap::Arg::new($0)"
    let v9 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "$0.short($1)"
    let v11 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v9, 's') v10
    let v12 : string = "r#\"" + v5 + "\"#"
    let v13 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : string = "$0.long($1)"
    let v15 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v11, v13) v14
    let v16 : string = "$0.required($1)"
    let v17 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v15, true) v16
    let v18 : string = "clap::Command::arg($0, $1)"
    let v19 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v4, v17) v18
    let v20 : string = "dist-dir"
    let v21 : string = "r#\"" + v20 + "\"#"
    let v22 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : string = "clap::Arg::new($0)"
    let v24 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "$0.short($1)"
    let v26 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v24, 'd') v25
    let v27 : string = "r#\"" + v20 + "\"#"
    let v28 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v27
    let v29 : string = "$0.long($1)"
    let v30 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v26, v28) v29
    let v31 : string = "$0.required($1)"
    let v32 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v30, true) v31
    let v33 : string = "clap::Command::arg($0, $1)"
    let v34 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v19, v32) v33
    let v35 : string = "cache-dir"
    let v36 : string = "r#\"" + v35 + "\"#"
    let v37 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : string = "clap::Arg::new($0)"
    let v39 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v37 v38
    let v40 : string = "$0.short($1)"
    let v41 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v39, 'c') v40
    let v42 : string = "r#\"" + v35 + "\"#"
    let v43 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : string = "$0.long($1)"
    let v45 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v41, v43) v44
    let v46 : string = "$0.required($1)"
    let v47 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v45, true) v46
    let v48 : string = "clap::Command::arg($0, $1)"
    let v49 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v34, v47) v48
    let v50 : string = "hangul-spec"
    let v51 : string = "r#\"" + v50 + "\"#"
    let v52 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : string = "clap::Arg::new($0)"
    let v54 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v52 v53
    let v55 : string = "$0.short($1)"
    let v56 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v54, 's') v55
    let v57 : string = "r#\"" + v50 + "\"#"
    let v58 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v57
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
and method1 (v0 : int64 option) : int64 option =
    v0
and method2 (v0 : int64 option) : int64 option =
    v0
and closure2 () () : struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3) =
    let v0 : Mut1 = {l0 = true} : Mut1
    let v1 : Mut0 = {l0 = 0L} : Mut0
    let v2 : US0 = US0_0
    let v3 : Mut2 = {l0 = v2} : Mut2
    let v4 : (string -> unit) = closure3()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v6 : int64 option option = None
    let mutable _v6 = v6
    #if INTERACTIVE || !FABLE_COMPILER
    let v7 : bool = true
    let mutable _v7 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "env!(\"CARGO_PKG_NAME\").into()"
    let v9 : string = Fable.Core.RustInterop.emitRustExpr () v8
    v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : string = null |> unbox<string>
    v10 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v11 : string = null |> unbox<string>
    v11 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : string = null |> unbox<string>
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v13 : string = null |> unbox<string>
    v13 
    #endif
#else
    let v14 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v14 
    #endif
    |> fun x -> _v7 <- Some x
    let v15 : string = _v7.Value
    let v17 : bool = v15 = "Microsoft.DotNet.Interactive.App"
    let v18 : bool = v17 <> true
    let v24 : US1 =
        if v18 then
            let v19 : System.DateTime = System.DateTime.Now
            let v20 : (System.DateTime -> int64) = _.Ticks
            let v21 : int64 = v20 v19
            US1_0(v21)
        else
            US1_1
    let v29 : int64 option =
        match v24 with
        | US1_1 -> (* None *)
            let v27 : int64 option = None
            v27
        | US1_0(v25) -> (* Some *)
            let v26 : int64 option = Some v25 
            v26
    let v30 : int64 option = method1(v29)
    v30 
    #else
    let v31 : int64 option = None
    let v32 : int64 option = method2(v31)
    v32 
    #endif
    |> fun x -> _v6 <- Some x
    let v33 : int64 option = _v6.Value
    struct (v1, v0, v3, v33, v5)
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
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure2()
    if State.trace_state.IsNone then State.trace_state <- v3 () |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut2, v7 : int64 option, v8 : Mut3) = State.trace_state.Value
    let v9 : bool = true
    let mutable _v9 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : US2 option = None
    let _v10 = ref v10 
    match v7 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v11 : int64 = x
    let v12 : US2 = US2_0(v11)
    v12 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v10.Value <- x
    let v13 : US2 option = _v10.Value 
    let v14 : US2 = US2_1
    let v15 : US2 = v13 |> Option.defaultValue v14 
    let v33 : System.DateTime =
        match v15 with
        | US2_1 -> (* None *)
            let v31 : System.DateTime = System.DateTime.Now
            v31
        | US2_0(v16) -> (* Some *)
            let v17 : System.DateTime = System.DateTime.Now
            let v18 : (System.DateTime -> int64) = _.Ticks
            let v19 : int64 = v18 v17
            let v20 : int64 = v19 - v16
            let v21 : System.TimeSpan = System.TimeSpan v20 
            let v22 : (System.TimeSpan -> int32) = _.Hours
            let v23 : int32 = v22 v21
            let v24 : (System.TimeSpan -> int32) = _.Minutes
            let v25 : int32 = v24 v21
            let v26 : (System.TimeSpan -> int32) = _.Seconds
            let v27 : int32 = v26 v21
            let v28 : (System.TimeSpan -> int32) = _.Milliseconds
            let v29 : int32 = v28 v21
            let v30 : System.DateTime = System.DateTime (1, 1, 1, v23, v25, v27, v29)
            v30
    let v34 : string = "hh:mm:ss"
    let v35 : string = v33.ToString v34 
    v35 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = method4()
    v36 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v37 : string = method4()
    v37 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v38 : string = method4()
    v38 
    #endif
#if FABLE_COMPILER_PYTHON
    let v39 : string = method4()
    v39 
    #endif
#else
    let v40 : US2 option = None
    let _v40 = ref v40 
    match v7 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v41 : int64 = x
    let v42 : US2 = US2_0(v41)
    v42 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v40.Value <- x
    let v43 : US2 option = _v40.Value 
    let v44 : US2 = US2_1
    let v45 : US2 = v43 |> Option.defaultValue v44 
    let v63 : System.DateTime =
        match v45 with
        | US2_1 -> (* None *)
            let v61 : System.DateTime = System.DateTime.Now
            v61
        | US2_0(v46) -> (* Some *)
            let v47 : System.DateTime = System.DateTime.Now
            let v48 : (System.DateTime -> int64) = _.Ticks
            let v49 : int64 = v48 v47
            let v50 : int64 = v49 - v46
            let v51 : System.TimeSpan = System.TimeSpan v50 
            let v52 : (System.TimeSpan -> int32) = _.Hours
            let v53 : int32 = v52 v51
            let v54 : (System.TimeSpan -> int32) = _.Minutes
            let v55 : int32 = v54 v51
            let v56 : (System.TimeSpan -> int32) = _.Seconds
            let v57 : int32 = v56 v51
            let v58 : (System.TimeSpan -> int32) = _.Milliseconds
            let v59 : int32 = v58 v51
            let v60 : System.DateTime = System.DateTime (1, 1, 1, v53, v55, v57, v59)
            v60
    let v64 : string = "HH:mm:ss"
    let v65 : string = v63.ToString v64 
    v65 
    #endif
    |> fun x -> _v9 <- Some x
    let v66 : string = _v9.Value
    let v67 : int64 = v4.l0
    let v77 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v72 : string = "Critical"
            v72
        | US0_1 -> (* Debug *)
            let v69 : string = "Debug"
            v69
        | US0_2 -> (* Info *)
            let v70 : string = "Info"
            v70
        | US0_0 -> (* Verbose *)
            let v68 : string = "Verbose"
            v68
        | US0_3 -> (* Warning *)
            let v71 : string = "Warning"
            v71
    let v78 : string = v77.ToLower ()
    let v79 : string = v78.PadLeft (7, ' ')
    let v80 : bool = true
    let mutable _v80 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v95 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v89 : string = "inline_colorization::color_bright_red"
            let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89
            v90
        | US0_1 -> (* Debug *)
            let v83 : string = "inline_colorization::color_bright_blue"
            let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v83
            v84
        | US0_2 -> (* Info *)
            let v85 : string = "inline_colorization::color_bright_green"
            let v86 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v85
            v86
        | US0_0 -> (* Verbose *)
            let v81 : string = "inline_colorization::color_bright_black"
            let v82 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v81
            v82
        | US0_3 -> (* Warning *)
            let v87 : string = "inline_colorization::color_yellow"
            let v88 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v87
            v88
    let v96 : string = "&*$0"
    let v97 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v79 v96
    let v98 : string = "inline_colorization::color_reset"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v98
    let v100 : string = "\"{v95}{v97}{v99}\""
    let v101 : string = @$"format!(" + v100 + ")"
    let v102 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v101
    let v103 : string = "fable_library_rust::String_::fromString($0)"
    let v104 : string = Fable.Core.RustInterop.emitRustExpr v102 v103
    v104 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v119 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v113 : string = "inline_colorization::color_bright_red"
            let v114 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v113
            v114
        | US0_1 -> (* Debug *)
            let v107 : string = "inline_colorization::color_bright_blue"
            let v108 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v107
            v108
        | US0_2 -> (* Info *)
            let v109 : string = "inline_colorization::color_bright_green"
            let v110 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v109
            v110
        | US0_0 -> (* Verbose *)
            let v105 : string = "inline_colorization::color_bright_black"
            let v106 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v105
            v106
        | US0_3 -> (* Warning *)
            let v111 : string = "inline_colorization::color_yellow"
            let v112 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v111
            v112
    let v120 : string = "&*$0"
    let v121 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v79 v120
    let v122 : string = "inline_colorization::color_reset"
    let v123 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v122
    let v124 : string = "\"{v119}{v121}{v123}\""
    let v125 : string = @$"format!(" + v124 + ")"
    let v126 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v125
    let v127 : string = "fable_library_rust::String_::fromString($0)"
    let v128 : string = Fable.Core.RustInterop.emitRustExpr v126 v127
    v128 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v143 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v137 : string = "inline_colorization::color_bright_red"
            let v138 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v137
            v138
        | US0_1 -> (* Debug *)
            let v131 : string = "inline_colorization::color_bright_blue"
            let v132 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v131
            v132
        | US0_2 -> (* Info *)
            let v133 : string = "inline_colorization::color_bright_green"
            let v134 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v133
            v134
        | US0_0 -> (* Verbose *)
            let v129 : string = "inline_colorization::color_bright_black"
            let v130 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v129
            v130
        | US0_3 -> (* Warning *)
            let v135 : string = "inline_colorization::color_yellow"
            let v136 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v135
            v136
    let v144 : string = "&*$0"
    let v145 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v79 v144
    let v146 : string = "inline_colorization::color_reset"
    let v147 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v146
    let v148 : string = "\"{v143}{v145}{v147}\""
    let v149 : string = @$"format!(" + v148 + ")"
    let v150 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v149
    let v151 : string = "fable_library_rust::String_::fromString($0)"
    let v152 : string = Fable.Core.RustInterop.emitRustExpr v150 v151
    v152 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v79 
    #endif
#if FABLE_COMPILER_PYTHON
    v79 
    #endif
#else
    v79 
    #endif
    |> fun x -> _v80 <- Some x
    let v153 : string = _v80.Value
    let v154 : string = $"{v66} {v153} #{v67} %s{v1 ()} / %s{v2 ()}"
    let v155 : (char []) = [||]
    let v156 : string = v154.TrimStart v155
    let v157 : (char []) = [|' '; '/'|]
    let v158 : string = v156.TrimEnd v157
    v158
and method5 (v0 : US0, v1 : (unit -> string)) : unit =
    let v2 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure2()
    if State.trace_state.IsNone then State.trace_state <- v2 () |> Some
    let struct (v3 : Mut0, v4 : Mut1, v5 : Mut2, v6 : int64 option, v7 : Mut3) = State.trace_state.Value
    if State.trace_state.IsNone then State.trace_state <- v2 () |> Some
    let struct (v8 : Mut0, v9 : Mut1, v10 : Mut2, v11 : int64 option, v12 : Mut3) = State.trace_state.Value
    let v13 : US0 = v10.l0
    let v14 : bool = v9.l0
    let v15 : bool = v14 = false
    let v19 : bool =
        if v15 then
            false
        else
            let v16 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
            let v17 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v13
            let v18 : bool = v16 >= v17
            v18
    if v19 then
        let v20 : int64 = v3.l0
        let v21 : int64 = v20 + 1L
        v3.l0 <- v21
        let v22 : string = $"%s{v1 ()}"
        let v23 : bool = true
        let mutable _v23 : unit option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v24 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v22 v24
        () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v25 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v22 v25
        () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v26 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v22 v26
        () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v22 
        () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v22 
        () 
        #endif
#else
        System.Console.WriteLine v22 
        () 
        #endif
        |> fun x -> _v23 <- Some x
        _v23.Value
        let v27 : (string -> unit) = v7.l0
        v27 v22
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
    let mutable _v1 : US4 option = None 
    
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
    let v27 : US4 = US4_0(v26)
    v27 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v28 : US4 = null |> unbox<US4>
    v28 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : US4 = null |> unbox<US4>
    v29 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v30 : string = "path"
    let v31 : IPathDirname = Fable.Core.JsInterop.importAll v30
    let v32 : string = "v31.dirname($0)"
    let v33 : string = Fable.Core.JsInterop.emitJsExpr v0 v32
    let v34 : US4 = US4_0(v33)
    v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v35 : US4 = null |> unbox<US4>
    v35 
    #endif
#else
    let v36 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.GetParent
    let v37 : System.IO.DirectoryInfo = v36 v0
    let v38 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let v39 : bool = v37 = v38
    let v50 : US4 =
        if v39 then
            US4_1
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
            US4_0(v48)
    v50 
    #endif
    |> fun x -> _v1 <- Some x
    let v51 : US4 = _v1.Value
    match v51 with
    | US4_1 -> (* None *)
        let v54 : string option = None
        v54
    | US4_0(v52) -> (* Some *)
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
        let v28 : US4 option = None
        let _v28 = ref v28 
        match v27 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v29 : string = x
        let v30 : US4 = US4_0(v29)
        v30 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v28.Value <- x
        let v31 : US4 option = _v28.Value 
        let v32 : US4 = US4_1
        let v33 : US4 = v31 |> Option.defaultValue v32 
        match v33 with
        | US4_1 -> (* None *)
            let v36 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            failwith<string> v36
        | US4_0(v34) -> (* Some *)
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
        let v27 : US4 option = None
        let _v27 = ref v27 
        match v26 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v28 : string = x
        let v29 : US4 = US4_0(v28)
        v29 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v27.Value <- x
        let v30 : US4 option = _v27.Value 
        let v31 : US4 = US4_1
        let v32 : US4 = v30 |> Option.defaultValue v31 
        match v32 with
        | US4_1 -> (* None *)
            let v35 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            failwith<string> v35
        | US4_0(v33) -> (* Some *)
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
and closure13 () (v0 : std_fs_FileType) : US6 =
    US6_0(v0)
and closure14 () (v0 : std_string_String) : US6 =
    US6_1(v0)
and method30 (v0 : std_fs_FileType) : std_fs_FileType =
    v0
and method31 (v0 : US5) : US5 =
    v0
and method27 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<Send<Dyn<std_future_Future<US5>>>>> =
    let v1 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : async_walkdir_DirEntry = method28(v0)
    let v3 : string = "Box::pin(async_walkdir::DirEntry::file_type(&v2))"
    let v4 : std_pin_Pin<Box<Send<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>>>> = Fable.Core.RustInterop.emitRustExpr () v3
    let v5 : string = "v4.await"
    let v6 : Result<std_fs_FileType, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v5
    let v7 : (std_io_Error -> std_string_String) = method29()
    let v8 : string = "$0.map_err(|x| $1(x))"
    let v9 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6, v7) v8
    let v10 : (std_fs_FileType -> US6) = closure13()
    let v11 : (std_string_String -> US6) = closure14()
    let v12 : US6 = match v9 with Ok x -> v10 x | Error x -> v11 x
    let v71 : US5 =
        match v12 with
        | US6_0(v13) -> (* Ok *)
            let v14 : std_fs_FileType = method30(v13)
            let v15 : string = "std::fs::FileType::is_dir(&v14)"
            let v16 : bool = Fable.Core.RustInterop.emitRustExpr () v15
            if v16 then
                US5_0
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
                    US5_0
                else
                    US5_2
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
                US5_0
            else
                US5_2
    let v72 : US5 = method31(v71)
    let v73 : string = "v72 }})"
    Fable.Core.RustInterop.emitRustExpr () v73
    let v74 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v74
    let v75 : string = "__result"
    let v76 : std_pin_Pin<Box<Send<Dyn<std_future_Future<US5>>>>> = Fable.Core.RustInterop.emitRustExpr () v75
    v76
and method32 (v0 : async_walkdir_Filtering) : async_walkdir_Filtering =
    v0
and method26 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>> =
    let v1 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : std_pin_Pin<Box<Send<Dyn<std_future_Future<US5>>>>> = method27(v0)
    let v3 : string = "v2.await"
    let v4 : US5 = Fable.Core.RustInterop.emitRustExpr () v3
    let v13 : async_walkdir_Filtering =
        match v4 with
        | US5_2 -> (* Continue *)
            let v9 : string = "async_walkdir::Filtering::Continue"
            let v10 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v9
            v10
        | US5_0 -> (* Ignore *)
            let v5 : string = "async_walkdir::Filtering::Ignore"
            let v6 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v5
            v6
        | US5_1 -> (* IgnoreDir *)
            let v7 : string = "async_walkdir::Filtering::IgnoreDir"
            let v8 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v7
            v8
    let v14 : async_walkdir_Filtering = method32(v13)
    let v15 : string = "v14 }})"
    Fable.Core.RustInterop.emitRustExpr () v15
    let v16 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v16
    let v17 : string = "__result"
    let v18 : std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>> = Fable.Core.RustInterop.emitRustExpr () v17
    v18
and closure11 () (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>> =
    method26(v0)
and closure16 () (v0 : async_walkdir_DirEntry) : US7 =
    US7_0(v0)
and closure17 () (v0 : std_string_String) : US7 =
    US7_1(v0)
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
    let v4 : (async_walkdir_DirEntry -> US7) = closure16()
    let v5 : (std_string_String -> US7) = closure17()
    let v6 : US7 = match v3 with Ok x -> v4 x | Error x -> v5 x
    let v32 : US4 =
        match v6 with
        | US7_1(v26) -> (* Error *)
            let v27 : US0 = US0_4
            let v28 : (unit -> string) = closure18()
            let v29 : (unit -> string) = closure19(v26)
            method3(v27, v28, v29)
            US4_1
        | US7_0(v7) -> (* Ok *)
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
            US4_0(v24)
    match v32 with
    | US4_1 -> (* None *)
        let v35 : string option = None
        v35
    | US4_0(v33) -> (* Some *)
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
and method36 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : string option) : string =
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
and method39 (v0 : string, v1 : string, v2 : UH0, v3 : US8) : struct (string * string) =
    match v2 with
    | UH0_1(v4, v5) -> (* Cons *)
        let v6 : bool = '"' = v4
        if v6 then
            let v8 : bool = v1 = ""
            if v8 then
                let v9 : US9 = US9_0
                let v10 : US8 = US8_1(v9)
                method39(v0, v1, v5, v10)
            else
                match v3 with
                | US8_2 -> (* Arguments *)
                    let v38 : string = $"{v0}{v4}"
                    let v39 : US8 = US8_2
                    method39(v38, v1, v5, v39)
                | US8_1(v13) -> (* Path *)
                    match v13 with
                    | US9_0 -> (* Quoted *)
                        let v14 : US9 = US9_1
                        let v15 : US8 = US8_1(v14)
                        method39(v0, v1, v5, v15)
                    | _ ->
                        let v18 : bool = ' ' = v4
                        if v18 then
                            let v19 : US8 = US8_2
                            method39(v0, v1, v5, v19)
                        else
                            let v22 : string = $"{v1}{v4}"
                            method39(v0, v22, v5, v3)
                | US8_0 -> (* Start *)
                    let v29 : bool = ' ' = v4
                    if v29 then
                        let v30 : US8 = US8_2
                        method39(v0, v1, v5, v30)
                    else
                        let v33 : string = $"{v1}{v4}"
                        method39(v0, v33, v5, v3)
        else
            let v50 : bool = ''' = v4
            if v50 then
                let v52 : bool = v1 = ""
                if v52 then
                    let v53 : US9 = US9_0
                    let v54 : US8 = US8_1(v53)
                    method39(v0, v1, v5, v54)
                else
                    match v3 with
                    | US8_2 -> (* Arguments *)
                        let v82 : string = $"{v0}{v4}"
                        let v83 : US8 = US8_2
                        method39(v82, v1, v5, v83)
                    | US8_1(v57) -> (* Path *)
                        match v57 with
                        | US9_0 -> (* Quoted *)
                            let v58 : US9 = US9_1
                            let v59 : US8 = US8_1(v58)
                            method39(v0, v1, v5, v59)
                        | _ ->
                            let v62 : bool = ' ' = v4
                            if v62 then
                                let v63 : US8 = US8_2
                                method39(v0, v1, v5, v63)
                            else
                                let v66 : string = $"{v1}{v4}"
                                method39(v0, v66, v5, v3)
                    | US8_0 -> (* Start *)
                        let v73 : bool = ' ' = v4
                        if v73 then
                            let v74 : US8 = US8_2
                            method39(v0, v1, v5, v74)
                        else
                            let v77 : string = $"{v1}{v4}"
                            method39(v0, v77, v5, v3)
            else
                match v3 with
                | US8_2 -> (* Arguments *)
                    let v126 : string = $"{v0}{v4}"
                    let v127 : US8 = US8_2
                    method39(v126, v1, v5, v127)
                | US8_1(v94) -> (* Path *)
                    match v94 with
                    | US9_0 -> (* Quoted *)
                        let v95 : bool = ' ' = v4
                        if v95 then
                            let v96 : string = $"{v1} "
                            let v97 : US9 = US9_0
                            let v98 : US8 = US8_1(v97)
                            method39(v0, v96, v5, v98)
                        else
                            let v101 : string = $"{v1}{v4}"
                            method39(v0, v101, v5, v3)
                    | _ ->
                        let v106 : bool = ' ' = v4
                        if v106 then
                            let v107 : US8 = US8_2
                            method39(v0, v1, v5, v107)
                        else
                            let v110 : string = $"{v1}{v4}"
                            method39(v0, v110, v5, v3)
                | US8_0 -> (* Start *)
                    let v117 : bool = ' ' = v4
                    if v117 then
                        let v118 : US8 = US8_2
                        method39(v0, v1, v5, v118)
                    else
                        let v121 : string = $"{v1}{v4}"
                        method39(v0, v121, v5, v3)
    | _ ->
        match v3 with
        | US8_2 -> (* Arguments *)
            let v152 : string = "\\"
            let v153 : string = "/"
            let v154 : string = v1.Replace (v152, v153)
            struct (v154, v0)
        | US8_1(v140) -> (* Path *)
            match v140 with
            | US9_0 -> (* Quoted *)
                let v141 : string = "\\"
                let v142 : string = "/"
                let v143 : string = v1.Replace (v141, v142)
                struct (v143, v0)
            | _ ->
                let v144 : string = "\\"
                let v145 : string = "/"
                let v146 : string = v1.Replace (v144, v145)
                struct (v146, v0)
        | US8_0 -> (* Start *)
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
and method42 (v0 : string, v1 : UH1, v2 : UH0, v3 : US10) : struct (UH1 * string) =
    match v3 with
    | US10_2(v44) -> (* Escaped *)
        match v2 with
        | UH0_1(v45, v46) -> (* Cons *)
            let v47 : bool = '\\' = v45
            if v47 then
                let v48 : char = '\\'
                let v49 : US10 = US10_1(v48)
                method41(v0, v1, v46, v3, v49)
            else
                let v52 : bool = '"' = v45
                if v52 then
                    let v54 : bool =
                        match v3 with
                        | US10_0 -> (* Start *)
                            true
                        | _ ->
                            false
                    if v54 then
                        method42(v0, v1, v46, v3)
                    else
                        let v57 : string = $"{v0}\""
                        let v58 : US10 = US10_2(v44)
                        method41(v57, v1, v46, v3, v58)
                else
                    let v63 : bool = ' ' = v45
                    if v63 then
                        let v64 : string = $"{v0} "
                        method42(v64, v1, v46, v3)
                    else
                        let v67 : bool = 1uy = v44
                        if v67 then
                            let v68 : bool = v3 <> v3
                            if v68 then
                                let v69 : string = $"{v0}\{v45}"
                                method42(v69, v1, v46, v3)
                            else
                                let v72 : string = $"{v0}{v45}"
                                method42(v72, v1, v46, v3)
                        else
                            let v77 : string = $"{v0}{v45}"
                            method42(v77, v1, v46, v3)
        | _ ->
            let v88 : bool = 1uy = v44
            if v88 then
                let v90 : bool = v0 = ""
                let v94 : UH1 =
                    if v90 then
                        v1
                    else
                        let v91 : UH1 = UH1_0
                        let v92 : UH1 = UH1_1(v0, v91)
                        method43(v1, v92)
                struct (v94, v0)
            else
                let v96 : bool = v0 = ""
                let v100 : UH1 =
                    if v96 then
                        v1
                    else
                        let v97 : UH1 = UH1_0
                        let v98 : UH1 = UH1_1(v0, v97)
                        method43(v1, v98)
                struct (v100, v0)
    | US10_1(v105) -> (* Quoted *)
        let v106 : bool = '"' = v105
        if v106 then
            match v2 with
            | UH0_1(v107, v108) -> (* Cons *)
                let v109 : bool = '"' = v107
                if v109 then
                    let v110 : US10 = US10_1('\\')
                    let v111 : bool = v3 = v110
                    if v111 then
                        let v112 : US10 = US10_0
                        method41(v0, v1, v108, v3, v112)
                    else
                        let v115 : bool = '\\' = v105
                        if v115 then
                            let v116 : US10 = US10_2(0uy)
                            let v117 : bool = v3 <> v116
                            if v117 then
                                let v118 : string = $"{v0}\""
                                let v119 : char = '"'
                                let v120 : US10 = US10_1(v119)
                                method41(v118, v1, v108, v3, v120)
                            else
                                let v123 : US10 = US10_1('\\')
                                let v124 : bool = v3 = v123
                                if v124 then
                                    let v125 : string = $"{v0}\""
                                    let v126 : char = '"'
                                    let v127 : US10 = US10_1(v126)
                                    method41(v125, v1, v108, v3, v127)
                                else
                                    let v130 : US10 = US10_0
                                    method41(v0, v1, v108, v3, v130)
                        else
                            let v137 : bool = '\\' = v107
                            if v137 then
                                let v138 : uint8 = 1uy
                                let v139 : US10 = US10_2(v138)
                                method41(v0, v1, v108, v3, v139)
                            else
                                let v142 : US10 = US10_2(0uy)
                                let v143 : bool = v3 = v142
                                if v143 then
                                    let v144 : string = $"{v0}\""
                                    let v145 : char = '"'
                                    let v146 : US10 = US10_1(v145)
                                    method41(v144, v1, v108, v3, v146)
                                else
                                    let v149 : UH1 = UH1_0
                                    let v150 : UH1 = UH1_1(v0, v149)
                                    let v151 : UH1 = method43(v1, v150)
                                    let v152 : string = ""
                                    let v153 : US10 = US10_0
                                    method41(v152, v151, v108, v3, v153)
                else
                    let v164 : bool = '\\' = v105
                    if v164 then
                        let v165 : bool = '\\' = v107
                        if v165 then
                            let v166 : uint8 = 1uy
                            let v167 : US10 = US10_2(v166)
                            method41(v0, v1, v108, v3, v167)
                        else
                            let v170 : bool = ' ' = v107
                            if v170 then
                                let v171 : string = $"{v0} "
                                method42(v171, v1, v108, v3)
                            else
                                let v174 : string = $"{v0}{v107}"
                                method42(v174, v1, v108, v3)
                    else
                        let v181 : bool = '\\' = v107
                        if v181 then
                            let v182 : uint8 = 1uy
                            let v183 : US10 = US10_2(v182)
                            method41(v0, v1, v108, v3, v183)
                        else
                            let v186 : bool = ' ' = v107
                            if v186 then
                                let v187 : string = $"{v0} "
                                method42(v187, v1, v108, v3)
                            else
                                let v190 : string = $"{v0}{v107}"
                                method42(v190, v1, v108, v3)
            | _ ->
                let v201 : bool = '\\' = v105
                if v201 then
                    let v203 : bool = v0 = ""
                    let v207 : UH1 =
                        if v203 then
                            v1
                        else
                            let v204 : UH1 = UH1_0
                            let v205 : UH1 = UH1_1(v0, v204)
                            method43(v1, v205)
                    struct (v207, v0)
                else
                    let v209 : bool = v0 = ""
                    let v213 : UH1 =
                        if v209 then
                            v1
                        else
                            let v210 : UH1 = UH1_0
                            let v211 : UH1 = UH1_1(v0, v210)
                            method43(v1, v211)
                    struct (v213, v0)
        else
            let v218 : bool = '\\' = v105
            if v218 then
                match v2 with
                | UH0_1(v219, v220) -> (* Cons *)
                    let v221 : bool = '"' = v219
                    if v221 then
                        let v222 : US10 = US10_2(0uy)
                        let v223 : bool = v3 <> v222
                        if v223 then
                            let v224 : string = $"{v0}\""
                            let v225 : char = '"'
                            let v226 : US10 = US10_1(v225)
                            method41(v224, v1, v220, v3, v226)
                        else
                            let v229 : US10 = US10_1('\\')
                            let v230 : bool = v3 = v229
                            if v230 then
                                let v231 : string = $"{v0}\""
                                let v232 : char = '"'
                                let v233 : US10 = US10_1(v232)
                                method41(v231, v1, v220, v3, v233)
                            else
                                let v236 : US10 = US10_0
                                method41(v0, v1, v220, v3, v236)
                    else
                        let v243 : bool = '\\' = v219
                        if v243 then
                            let v244 : uint8 = 1uy
                            let v245 : US10 = US10_2(v244)
                            method41(v0, v1, v220, v3, v245)
                        else
                            let v248 : bool = ' ' = v219
                            if v248 then
                                let v249 : string = $"{v0} "
                                method42(v249, v1, v220, v3)
                            else
                                let v252 : string = $"{v0}{v219}"
                                method42(v252, v1, v220, v3)
                | _ ->
                    let v262 : bool = v0 = ""
                    let v266 : UH1 =
                        if v262 then
                            v1
                        else
                            let v263 : UH1 = UH1_0
                            let v264 : UH1 = UH1_1(v0, v263)
                            method43(v1, v264)
                    struct (v266, v0)
            else
                match v2 with
                | UH0_1(v269, v270) -> (* Cons *)
                    let v271 : bool = '\\' = v269
                    if v271 then
                        let v272 : uint8 = 1uy
                        let v273 : US10 = US10_2(v272)
                        method41(v0, v1, v270, v3, v273)
                    else
                        let v276 : bool = '"' = v269
                        if v276 then
                            let v277 : US10 = US10_2(0uy)
                            let v278 : bool = v3 = v277
                            if v278 then
                                let v279 : string = $"{v0}\""
                                let v280 : char = '"'
                                let v281 : US10 = US10_1(v280)
                                method41(v279, v1, v270, v3, v281)
                            else
                                let v284 : UH1 = UH1_0
                                let v285 : UH1 = UH1_1(v0, v284)
                                let v286 : UH1 = method43(v1, v285)
                                let v287 : string = ""
                                let v288 : US10 = US10_0
                                method41(v287, v286, v270, v3, v288)
                        else
                            let v293 : bool = ' ' = v269
                            if v293 then
                                let v294 : string = $"{v0} "
                                method42(v294, v1, v270, v3)
                            else
                                let v297 : string = $"{v0}{v269}"
                                method42(v297, v1, v270, v3)
                | _ ->
                    let v307 : bool = v0 = ""
                    let v311 : UH1 =
                        if v307 then
                            v1
                        else
                            let v308 : UH1 = UH1_0
                            let v309 : UH1 = UH1_1(v0, v308)
                            method43(v1, v309)
                    struct (v311, v0)
    | US10_0 -> (* Start *)
        match v2 with
        | UH0_1(v4, v5) -> (* Cons *)
            let v6 : bool = '"' = v4
            if v6 then
                let v7 : string = ""
                let v8 : char = '"'
                let v9 : US10 = US10_1(v8)
                method41(v7, v1, v5, v3, v9)
            else
                let v12 : bool = '\\' = v4
                if v12 then
                    let v13 : uint8 = 0uy
                    let v14 : US10 = US10_2(v13)
                    method41(v0, v1, v5, v3, v14)
                else
                    let v17 : bool = ' ' = v4
                    if v17 then
                        let v19 : bool = v0 = ""
                        let v23 : UH1 =
                            if v19 then
                                v1
                            else
                                let v20 : UH1 = UH1_0
                                let v21 : UH1 = UH1_1(v0, v20)
                                method43(v1, v21)
                        let v24 : string = ""
                        method42(v24, v23, v5, v3)
                    else
                        let v27 : string = $"{v0}{v4}"
                        method42(v27, v1, v5, v3)
        | _ ->
            let v37 : bool = v0 = ""
            let v41 : UH1 =
                if v37 then
                    v1
                else
                    let v38 : UH1 = UH1_0
                    let v39 : UH1 = UH1_1(v0, v38)
                    method43(v1, v39)
            struct (v41, v0)
and method41 (v0 : string, v1 : UH1, v2 : UH0, v3 : US10, v4 : US10) : struct (UH1 * string) =
    match v4 with
    | US10_2(v45) -> (* Escaped *)
        match v2 with
        | UH0_1(v46, v47) -> (* Cons *)
            let v48 : bool = '\\' = v46
            if v48 then
                let v49 : char = '\\'
                let v50 : US10 = US10_1(v49)
                method41(v0, v1, v47, v4, v50)
            else
                let v53 : bool = '"' = v46
                if v53 then
                    let v55 : bool =
                        match v3 with
                        | US10_0 -> (* Start *)
                            true
                        | _ ->
                            false
                    if v55 then
                        method42(v0, v1, v47, v4)
                    else
                        let v58 : string = $"{v0}\""
                        let v59 : US10 = US10_2(v45)
                        method41(v58, v1, v47, v4, v59)
                else
                    let v64 : bool = ' ' = v46
                    if v64 then
                        let v65 : string = $"{v0} "
                        method42(v65, v1, v47, v4)
                    else
                        let v68 : bool = 1uy = v45
                        if v68 then
                            let v69 : bool = v3 <> v4
                            if v69 then
                                let v70 : string = $"{v0}\{v46}"
                                method41(v70, v1, v47, v4, v3)
                            else
                                let v73 : string = $"{v0}{v46}"
                                method42(v73, v1, v47, v4)
                        else
                            let v78 : string = $"{v0}{v46}"
                            method42(v78, v1, v47, v4)
        | _ ->
            let v89 : bool = 1uy = v45
            if v89 then
                let v91 : bool = v0 = ""
                let v95 : UH1 =
                    if v91 then
                        v1
                    else
                        let v92 : UH1 = UH1_0
                        let v93 : UH1 = UH1_1(v0, v92)
                        method43(v1, v93)
                struct (v95, v0)
            else
                let v97 : bool = v0 = ""
                let v101 : UH1 =
                    if v97 then
                        v1
                    else
                        let v98 : UH1 = UH1_0
                        let v99 : UH1 = UH1_1(v0, v98)
                        method43(v1, v99)
                struct (v101, v0)
    | US10_1(v106) -> (* Quoted *)
        let v107 : bool = '"' = v106
        if v107 then
            match v2 with
            | UH0_1(v108, v109) -> (* Cons *)
                let v110 : bool = '"' = v108
                if v110 then
                    let v111 : US10 = US10_1('\\')
                    let v112 : bool = v3 = v111
                    if v112 then
                        let v113 : US10 = US10_0
                        method41(v0, v1, v109, v4, v113)
                    else
                        let v116 : bool = '\\' = v106
                        if v116 then
                            let v117 : US10 = US10_2(0uy)
                            let v118 : bool = v3 <> v117
                            if v118 then
                                let v119 : string = $"{v0}\""
                                let v120 : char = '"'
                                let v121 : US10 = US10_1(v120)
                                method41(v119, v1, v109, v4, v121)
                            else
                                let v124 : US10 = US10_1('\\')
                                let v125 : bool = v3 = v124
                                if v125 then
                                    let v126 : string = $"{v0}\""
                                    let v127 : char = '"'
                                    let v128 : US10 = US10_1(v127)
                                    method41(v126, v1, v109, v4, v128)
                                else
                                    let v131 : US10 = US10_0
                                    method41(v0, v1, v109, v4, v131)
                        else
                            let v138 : bool = '\\' = v108
                            if v138 then
                                let v139 : uint8 = 1uy
                                let v140 : US10 = US10_2(v139)
                                method41(v0, v1, v109, v4, v140)
                            else
                                let v143 : US10 = US10_2(0uy)
                                let v144 : bool = v3 = v143
                                if v144 then
                                    let v145 : string = $"{v0}\""
                                    let v146 : char = '"'
                                    let v147 : US10 = US10_1(v146)
                                    method41(v145, v1, v109, v4, v147)
                                else
                                    let v150 : UH1 = UH1_0
                                    let v151 : UH1 = UH1_1(v0, v150)
                                    let v152 : UH1 = method43(v1, v151)
                                    let v153 : string = ""
                                    let v154 : US10 = US10_0
                                    method41(v153, v152, v109, v4, v154)
                else
                    let v165 : bool = '\\' = v106
                    if v165 then
                        let v166 : bool = '\\' = v108
                        if v166 then
                            let v167 : uint8 = 1uy
                            let v168 : US10 = US10_2(v167)
                            method41(v0, v1, v109, v4, v168)
                        else
                            let v171 : bool = ' ' = v108
                            if v171 then
                                let v172 : string = $"{v0} "
                                method42(v172, v1, v109, v4)
                            else
                                let v175 : string = $"{v0}{v108}"
                                method42(v175, v1, v109, v4)
                    else
                        let v182 : bool = '\\' = v108
                        if v182 then
                            let v183 : uint8 = 1uy
                            let v184 : US10 = US10_2(v183)
                            method41(v0, v1, v109, v4, v184)
                        else
                            let v187 : bool = ' ' = v108
                            if v187 then
                                let v188 : string = $"{v0} "
                                method42(v188, v1, v109, v4)
                            else
                                let v191 : string = $"{v0}{v108}"
                                method42(v191, v1, v109, v4)
            | _ ->
                let v202 : bool = '\\' = v106
                if v202 then
                    let v204 : bool = v0 = ""
                    let v208 : UH1 =
                        if v204 then
                            v1
                        else
                            let v205 : UH1 = UH1_0
                            let v206 : UH1 = UH1_1(v0, v205)
                            method43(v1, v206)
                    struct (v208, v0)
                else
                    let v210 : bool = v0 = ""
                    let v214 : UH1 =
                        if v210 then
                            v1
                        else
                            let v211 : UH1 = UH1_0
                            let v212 : UH1 = UH1_1(v0, v211)
                            method43(v1, v212)
                    struct (v214, v0)
        else
            let v219 : bool = '\\' = v106
            if v219 then
                match v2 with
                | UH0_1(v220, v221) -> (* Cons *)
                    let v222 : bool = '"' = v220
                    if v222 then
                        let v223 : US10 = US10_2(0uy)
                        let v224 : bool = v3 <> v223
                        if v224 then
                            let v225 : string = $"{v0}\""
                            let v226 : char = '"'
                            let v227 : US10 = US10_1(v226)
                            method41(v225, v1, v221, v4, v227)
                        else
                            let v230 : US10 = US10_1('\\')
                            let v231 : bool = v3 = v230
                            if v231 then
                                let v232 : string = $"{v0}\""
                                let v233 : char = '"'
                                let v234 : US10 = US10_1(v233)
                                method41(v232, v1, v221, v4, v234)
                            else
                                let v237 : US10 = US10_0
                                method41(v0, v1, v221, v4, v237)
                    else
                        let v244 : bool = '\\' = v220
                        if v244 then
                            let v245 : uint8 = 1uy
                            let v246 : US10 = US10_2(v245)
                            method41(v0, v1, v221, v4, v246)
                        else
                            let v249 : bool = ' ' = v220
                            if v249 then
                                let v250 : string = $"{v0} "
                                method42(v250, v1, v221, v4)
                            else
                                let v253 : string = $"{v0}{v220}"
                                method42(v253, v1, v221, v4)
                | _ ->
                    let v263 : bool = v0 = ""
                    let v267 : UH1 =
                        if v263 then
                            v1
                        else
                            let v264 : UH1 = UH1_0
                            let v265 : UH1 = UH1_1(v0, v264)
                            method43(v1, v265)
                    struct (v267, v0)
            else
                match v2 with
                | UH0_1(v270, v271) -> (* Cons *)
                    let v272 : bool = '\\' = v270
                    if v272 then
                        let v273 : uint8 = 1uy
                        let v274 : US10 = US10_2(v273)
                        method41(v0, v1, v271, v4, v274)
                    else
                        let v277 : bool = '"' = v270
                        if v277 then
                            let v278 : US10 = US10_2(0uy)
                            let v279 : bool = v3 = v278
                            if v279 then
                                let v280 : string = $"{v0}\""
                                let v281 : char = '"'
                                let v282 : US10 = US10_1(v281)
                                method41(v280, v1, v271, v4, v282)
                            else
                                let v285 : UH1 = UH1_0
                                let v286 : UH1 = UH1_1(v0, v285)
                                let v287 : UH1 = method43(v1, v286)
                                let v288 : string = ""
                                let v289 : US10 = US10_0
                                method41(v288, v287, v271, v4, v289)
                        else
                            let v294 : bool = ' ' = v270
                            if v294 then
                                let v295 : string = $"{v0} "
                                method42(v295, v1, v271, v4)
                            else
                                let v298 : string = $"{v0}{v270}"
                                method42(v298, v1, v271, v4)
                | _ ->
                    let v308 : bool = v0 = ""
                    let v312 : UH1 =
                        if v308 then
                            v1
                        else
                            let v309 : UH1 = UH1_0
                            let v310 : UH1 = UH1_1(v0, v309)
                            method43(v1, v310)
                    struct (v312, v0)
    | US10_0 -> (* Start *)
        match v2 with
        | UH0_1(v5, v6) -> (* Cons *)
            let v7 : bool = '"' = v5
            if v7 then
                let v8 : string = ""
                let v9 : char = '"'
                let v10 : US10 = US10_1(v9)
                method41(v8, v1, v6, v4, v10)
            else
                let v13 : bool = '\\' = v5
                if v13 then
                    let v14 : uint8 = 0uy
                    let v15 : US10 = US10_2(v14)
                    method41(v0, v1, v6, v4, v15)
                else
                    let v18 : bool = ' ' = v5
                    if v18 then
                        let v20 : bool = v0 = ""
                        let v24 : UH1 =
                            if v20 then
                                v1
                            else
                                let v21 : UH1 = UH1_0
                                let v22 : UH1 = UH1_1(v0, v21)
                                method43(v1, v22)
                        let v25 : string = ""
                        method42(v25, v24, v6, v4)
                    else
                        let v28 : string = $"{v0}{v5}"
                        method42(v28, v1, v6, v4)
        | _ ->
            let v38 : bool = v0 = ""
            let v42 : UH1 =
                if v38 then
                    v1
                else
                    let v39 : UH1 = UH1_0
                    let v40 : UH1 = UH1_1(v0, v39)
                    method43(v1, v40)
            struct (v42, v0)
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
    let v6 : US4 option = None
    let _v6 = ref v6 
    match v5 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v7 : string = x
    let v8 : US4 = US4_0(v7)
    v8 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v6.Value <- x
    let v9 : US4 option = _v6.Value 
    let v10 : US4 = US4_1
    let v11 : US4 = v9 |> Option.defaultValue v10 
    let v14 : string =
        match v11 with
        | US4_1 -> (* None *)
            v2
        | US4_0(v12) -> (* Some *)
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
    let v30 : US10 = US10_0
    let v31 : US10 = US10_0
    let struct (v32 : UH1, v33 : string) = method41(v2, v1, v29, v31, v30)
    let v34 : string list = []
    let v35 : string list = method44(v32, v34)
    let v36 : (string list -> (string [])) = List.toArray
    let v37 : (string []) = v36 v35
    v37
and closure25 () () : string =
    let v0 : string = $"runtime.execute_with_options"
    v0
and closure26 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : string option, v6 : string, v7 : Vec<std_string_String>) () : string =
    let v8 : (unit -> string) = closure6()
    let v9 : string = $"file_name: {v6} / arguments: %A{v7} / options: %A{struct (v0, v1, v2, v3, v4, v5)} / {v8 ()}"
    v9
and method45 (v0 : string) : string =
    v0
and closure27 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : US11 =
    US11_0(v0)
and closure28 () (v0 : std_string_String) : US11 =
    US11_1(v0)
and closure29 () () : string =
    let v0 : string = $"runtime.execute_with_options / child error"
    v0
and closure30 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and method46 (v0 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> =
    v0
and closure32 () (v0 : std_string_String) : US13 =
    US13_0(v0)
and closure33 () (v0 : std_string_String) : US13 =
    US13_1(v0)
and closure34 () () : string =
    let v0 : string = $"runtime.execute_with_options / std_line"
    v0
and closure35 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"e: {v0} / {v1 ()}"
    v2
and closure36 (v0 : std_string_String) () : string =
    let v1 : string = $"> {v0}"
    v1
and closure31 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) (v1 : Result<std_string_String, std_io_Error>) : unit =
    let v2 : bool = true
    let mutable _v2 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : (std_io_Error -> std_string_String) = method29()
    let v4 : string = "$0.map_err(|x| $1(x))"
    let v5 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1, v3) v4
    let v6 : (std_string_String -> US13) = closure32()
    let v7 : (std_string_String -> US13) = closure33()
    let v8 : US13 = match v5 with Ok x -> v6 x | Error x -> v7 x
    let v23 : std_string_String =
        match v8 with
        | US13_1(v13) -> (* Error *)
            let v14 : US0 = US0_4
            let v15 : (unit -> string) = closure34()
            let v16 : (unit -> string) = closure35(v13)
            method3(v14, v15, v16)
            let v17 : string = $"[{v13}]"
            let v18 : string = "&*$0"
            let v19 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v17 v18
            let v20 : string = "String::from($0)"
            let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v20
            v21
        | US13_0(v9) -> (* Ok *)
            let v10 : US0 = US0_0
            let v11 : (unit -> string) = closure36(v9)
            let v12 : (unit -> string) = closure6()
            method3(v10, v11, v12)
            v9
    let v24 : string = "true; $0.lock().unwrap().send($1).unwrap()"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr struct (v0, v23) v24
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
    null |> unbox<unit>
    () 
    #endif
    |> fun x -> _v2 <- Some x
    _v2.Value
    ()
and method47 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure37 () (v0 : std_process_Output) : US16 =
    US16_0(v0)
and closure38 () (v0 : std_string_String) : US16 =
    US16_1(v0)
and closure39 () () : string =
    let v0 : string = $"runtime.execute_with_options / output error"
    v0
and closure40 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and closure41 () () : string =
    let v0 : string = $"runtime.execute_with_options / result"
    v0
and closure42 (v0 : int32, v1 : string) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: {v0} / std_trace.Length: {v1.Length} / {v2 ()}"
    v3
and method48 (v0 : (int32 * string)) : (int32 * string) =
    v0
and closure43 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : string option) () : string =
    let v6 : string = $"execute_with_options_async / options: %A{struct (v0, v1, v2, v3, v4, v5)}"
    v6
and method50 () : (unit -> string) =
    closure6()
and closure45 (v0 : string) () : string =
    let v1 : string = $"> {v0}"
    v1
and closure44 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : string option, v6 : System.Diagnostics.Process, v7 : System.Collections.Concurrent.ConcurrentStack<string>) (v8 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v9 : bool = true
    let mutable _v9 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : Async<unit> = null |> unbox<Async<unit>>
    v10 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : Async<unit> = null |> unbox<Async<unit>>
    v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : Async<unit> = null |> unbox<Async<unit>>
    v12 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : Async<unit> = null |> unbox<Async<unit>>
    v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : Async<unit> = null |> unbox<Async<unit>>
    v14 
    #endif
#else
    let v15 : Async<unit> option = None
    let mutable _v15 = v15
    async {
    let v16 : string = v8.Data
    let v17 : string = null |> unbox<string>
    let v18 : bool = v16 = v17
    let v19 : bool = v18 <> true
    if v19 then
        let v20 : US17 option = None
        let _v20 = ref v20 
        match v3 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v21 : (struct (bool * string * int32) -> Async<unit>) = x
        let v22 : US17 = US17_0(v21)
        v22 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v20.Value <- x
        let v23 : US17 option = _v20.Value 
        let v24 : US17 = US17_1
        let v25 : US17 = v23 |> Option.defaultValue v24 
        match v25 with
        | US17_1 -> (* None *)
            ()
        | US17_0(v26) -> (* Some *)
            let v27 : int32 = v6.Id
            let v28 : Async<unit> = v26 struct (false, v16, v27)
            do! v28 
            ()
        let v29 : US0 = US0_0
        let v30 : (unit -> string) = closure45(v16)
        let v31 : (unit -> string) = closure6()
        method3(v29, v30, v31)
        let v32 : string = ""
        let v33 : string = $"{v32}{v16}{v32}"
        let v34 : (string -> unit) = v7.Push
        v34 v33
    }
    |> fun x -> _v15 <- Some x
    let v35 : Async<unit> = _v15 |> Option.get
    v35 
    #endif
    |> fun x -> _v9 <- Some x
    let v36 : Async<unit> = _v9.Value
    let v37 : bool = true
    let mutable _v37 : unit option = None 
    
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
    let v38 : (Async<unit> -> unit) = Async.StartImmediate
    v38 v36
    () 
    #endif
    |> fun x -> _v37 <- Some x
    _v37.Value
    ()
and closure46 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : string option, v6 : System.Diagnostics.Process, v7 : System.Collections.Concurrent.ConcurrentStack<string>) (v8 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v9 : bool = true
    let mutable _v9 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : Async<unit> = null |> unbox<Async<unit>>
    v10 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : Async<unit> = null |> unbox<Async<unit>>
    v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : Async<unit> = null |> unbox<Async<unit>>
    v12 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : Async<unit> = null |> unbox<Async<unit>>
    v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : Async<unit> = null |> unbox<Async<unit>>
    v14 
    #endif
#else
    let v15 : Async<unit> option = None
    let mutable _v15 = v15
    async {
    let v16 : string = v8.Data
    let v17 : string = null |> unbox<string>
    let v18 : bool = v16 = v17
    let v19 : bool = v18 <> true
    if v19 then
        let v20 : US17 option = None
        let _v20 = ref v20 
        match v3 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v21 : (struct (bool * string * int32) -> Async<unit>) = x
        let v22 : US17 = US17_0(v21)
        v22 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v20.Value <- x
        let v23 : US17 option = _v20.Value 
        let v24 : US17 = US17_1
        let v25 : US17 = v23 |> Option.defaultValue v24 
        match v25 with
        | US17_1 -> (* None *)
            ()
        | US17_0(v26) -> (* Some *)
            let v27 : int32 = v6.Id
            let v28 : Async<unit> = v26 struct (true, v16, v27)
            do! v28 
            ()
        let v29 : US0 = US0_0
        let v30 : (unit -> string) = closure45(v16)
        let v31 : (unit -> string) = closure6()
        method3(v29, v30, v31)
        let v32 : string = "["
        let v33 : string = "]"
        let v34 : string = $"{v32}{v16}{v33}"
        let v35 : (string -> unit) = v7.Push
        v35 v34
    }
    |> fun x -> _v15 <- Some x
    let v36 : Async<unit> = _v15 |> Option.get
    v36 
    #endif
    |> fun x -> _v9 <- Some x
    let v37 : Async<unit> = _v9.Value
    let v38 : bool = true
    let mutable _v38 : unit option = None 
    
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
    let v39 : (Async<unit> -> unit) = Async.StartImmediate
    v39 v37
    () 
    #endif
    |> fun x -> _v38 <- Some x
    _v38.Value
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
and method51 () : string =
    let v0 : string = "\n"
    v0
and closure49 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"execute_with_options_async / exit_code: {v0} / output.Length: {v1.Length}"
    v2
and method49 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : string option) : Async<struct (int32 * string)> =
    let v6 : bool = true
    let mutable _v6 : Async<struct (int32 * string)> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v8 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v10 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v11 
    #endif
#else
    let v12 : bool = true
    let mutable _v12 : Async<struct (int32 * string)> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v13 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v14 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v15 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v16 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v16 
    #endif
#if FABLE_COMPILER_PYTHON
    let v17 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v17 
    #endif
#else
    let v18 : Async<struct (int32 * string)> option = None
    let mutable _v18 = v18
    async {
    let struct (v19 : string, v20 : string) = method37()
    let v21 : int32 = v1.Length
    let v22 : (char []) = Array.zeroCreate<char> (v21)
    let v23 : Mut5 = {l0 = 0} : Mut5
    while method23(v21, v23) do
        let v25 : int32 = v23.l0
        let v26 : char = v1.[int v25]
        v22.[int v25] <- v26
        let v27 : int32 = v25 + 1
        v23.l0 <- v27
        ()
    let v28 : ((char []) -> char list) = Array.toList
    let v29 : char list = v28 v22
    let v30 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v31 : (char -> (UH0 -> UH0)) = method38()
    let v32 : (char list -> (UH0 -> UH0)) = v30 v31
    let v33 : (UH0 -> UH0) = v32 v29
    let v34 : UH0 = UH0_0
    let v35 : UH0 = v33 v34
    let v36 : US8 = US8_0
    let struct (v37 : string, v38 : string) = method39(v20, v19, v35, v36)
    let v39 : US4 option = None
    let _v39 = ref v39 
    match v5 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v40 : string = x
    let v41 : US4 = US4_0(v40)
    v41 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v39.Value <- x
    let v42 : US4 option = _v39.Value 
    let v43 : US4 = US4_1
    let v44 : US4 = v42 |> Option.defaultValue v43 
    let v48 : string =
        match v44 with
        | US4_1 -> (* None *)
            let v46 : string = ""
            v46
        | US4_0(v45) -> (* Some *)
            v45
    let v49 : US0 = US0_1
    let v50 : (unit -> string) = closure43(v0, v1, v2, v3, v4, v5)
    let v51 : (unit -> string) = method50()
    method3(v49, v50, v51)
    let v52 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v53 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v38, StandardOutputEncoding = v52, WorkingDirectory = v48, FileName = v37, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v54 : int32 = v2.Length
    let v55 : Mut5 = {l0 = 0} : Mut5
    while method23(v54, v55) do
        let v57 : int32 = v55.l0
        let struct (v58 : string, v59 : string) = v2.[int v57]
        v53.EnvironmentVariables.[v58] <- v59 
        let v60 : int32 = v57 + 1
        v55.l0 <- v60
        ()
    let v61 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v53)
    use v61 = v61 
    let v62 : System.Diagnostics.Process = v61 
    let v63 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v64 : System.Collections.Concurrent.ConcurrentStack<string> = v63 ()
    let v65 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure44(v0, v1, v2, v3, v4, v5, v62, v64)
    v62.OutputDataReceived.Add v65 
    let v66 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure46(v0, v1, v2, v3, v4, v5, v62, v64)
    v62.ErrorDataReceived.Add v66 
    let v67 : (unit -> bool) = v62.Start
    let v68 : bool = v67 ()
    let v69 : bool = v68 = false
    if v69 then
        let v70 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v70
    let v71 : (unit -> unit) = v62.BeginErrorReadLine
    v71 ()
    let v72 : (unit -> unit) = v62.BeginOutputReadLine
    v72 ()
    let v73 : US18 option = None
    let _v73 = ref v73 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v74 : System.Threading.CancellationToken = x
    let v75 : US18 = US18_0(v74)
    v75 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v73.Value <- x
    let v76 : US18 option = _v73.Value 
    let v77 : US18 = US18_1
    let v78 : US18 = v76 |> Option.defaultValue v77 
    let v82 : System.Threading.CancellationToken =
        match v78 with
        | US18_1 -> (* None *)
            let v80 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v80
        | US18_0(v79) -> (* Some *)
            v79
    let v83 : bool = true
    let mutable _v83 : Async<System.Threading.CancellationToken> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v84 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v84 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v85 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v85 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v86 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v86 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v87 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v87 
    #endif
#if FABLE_COMPILER_PYTHON
    let v88 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v88 
    #endif
#else
    let v89 : bool = true
    let mutable _v89 : Async<System.Threading.CancellationToken> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v90 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v90 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v91 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v91 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v92 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v92 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v93 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v93 
    #endif
#if FABLE_COMPILER_PYTHON
    let v94 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v94 
    #endif
#else
    let v95 : Async<System.Threading.CancellationToken> option = None
    let mutable _v95 = v95
    async {
    let v96 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v96 = v96 
    let v97 : System.Threading.CancellationToken = v96 
    let v98 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v99 : (System.Threading.CancellationToken []) = [|v97; v98; v82|]
    let v100 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v101 : System.Threading.CancellationTokenSource = v100 v99
    let v102 : System.Threading.CancellationToken = v101.Token
    return v102 
    }
    |> fun x -> _v95 <- Some x
    let v103 : Async<System.Threading.CancellationToken> = _v95 |> Option.get
    v103 
    #endif
    |> fun x -> _v89 <- Some x
    let v104 : Async<System.Threading.CancellationToken> = _v89.Value
    v104 
    #endif
    |> fun x -> _v83 <- Some x
    let v105 : Async<System.Threading.CancellationToken> = _v83.Value
    let! v105 = v105 
    let v106 : System.Threading.CancellationToken = v105 
    let v107 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v106.Register
    let v108 : (unit -> unit) = closure47(v62)
    let v109 : System.Threading.CancellationTokenRegistration = v107 v108
    use v109 = v109 
    let v110 : System.Threading.CancellationTokenRegistration = v109 
    let v111 : bool = true
    let mutable _v111 : Async<int32> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v112 : Async<int32> = null |> unbox<Async<int32>>
    v112 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v113 : Async<int32> = null |> unbox<Async<int32>>
    v113 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v114 : Async<int32> = null |> unbox<Async<int32>>
    v114 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v115 : Async<int32> = null |> unbox<Async<int32>>
    v115 
    #endif
#if FABLE_COMPILER_PYTHON
    let v116 : Async<int32> = null |> unbox<Async<int32>>
    v116 
    #endif
#else
    let v117 : Async<int32> option = None
    let mutable _v117 = v117
    async {
    try
    let v118 : System.Threading.Tasks.Task = v62.WaitForExitAsync v106 
    let v119 : bool = true
    let mutable _v119 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v120 : Async<unit> = null |> unbox<Async<unit>>
    v120 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v121 : Async<unit> = null |> unbox<Async<unit>>
    v121 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v122 : Async<unit> = null |> unbox<Async<unit>>
    v122 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v123 : Async<unit> = null |> unbox<Async<unit>>
    v123 
    #endif
#if FABLE_COMPILER_PYTHON
    let v124 : Async<unit> = null |> unbox<Async<unit>>
    v124 
    #endif
#else
    let v125 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v126 : Async<unit> = v125 v118
    v126 
    #endif
    |> fun x -> _v119 <- Some x
    let v127 : Async<unit> = _v119.Value
    do! v127 
    let v128 : int32 = v62.ExitCode
    return v128 
    with ex ->
    let v129 : exn = ex
    let v130 : bool = true
    let mutable _v130 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v131 : string = $"%A{v129}"
    v131 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v132 : string = $"%A{v129}"
    v132 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v133 : string = $"%A{v129}"
    v133 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v134 : string = $"%A{v129}"
    v134 
    #endif
#if FABLE_COMPILER_PYTHON
    let v135 : string = $"%A{v129}"
    v135 
    #endif
#else
    let v136 : string = $"{v129.GetType ()}: {v129.Message}"
    v136 
    #endif
    |> fun x -> _v130 <- Some x
    let v137 : string = _v130.Value
    let v138 : (string -> unit) = v64.Push
    v138 v137
    let v139 : System.Threading.Tasks.TaskCanceledException = v129 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v140 : US0 = US0_3
    let v141 : (unit -> string) = closure48(v139)
    let v142 : (unit -> string) = method50()
    method3(v140, v141, v142)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v117 <- Some x
    let v143 : Async<int32> = _v117 |> Option.get
    v143 
    #endif
    |> fun x -> _v111 <- Some x
    let v144 : Async<int32> = _v111.Value
    let! v144 = v144 
    let v145 : int32 = v144 
    let v146 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v147 : string seq = v146 v64
    let v148 : string = method51()
    let v149 : (string -> (string seq -> string)) = String.concat
    let v150 : (string seq -> string) = v149 v148
    let v151 : string = v150 v147
    let v152 : US0 = US0_1
    let v153 : (unit -> string) = closure49(v145, v151)
    let v154 : (unit -> string) = method50()
    method3(v152, v153, v154)
    return struct (v145, v151) 
    }
    |> fun x -> _v18 <- Some x
    let v155 : Async<struct (int32 * string)> = _v18 |> Option.get
    v155 
    #endif
    |> fun x -> _v12 <- Some x
    let v156 : Async<struct (int32 * string)> = _v12.Value
    v156 
    #endif
    |> fun x -> _v6 <- Some x
    let v157 : Async<struct (int32 * string)> = _v6.Value
    v157
and method35 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : string option) : struct (int32 * string) =
    let v6 : bool = true
    let mutable _v6 : struct (int32 * string) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = method36(v0, v1, v2, v3, v4, v5)
    let struct (v8 : string, v9 : string) = method37()
    let v10 : int32 = v7.Length
    let v11 : (char []) = Array.zeroCreate<char> (v10)
    let v12 : Mut5 = {l0 = 0} : Mut5
    while method23(v10, v12) do
        let v14 : int32 = v12.l0
        let v15 : char = v7.[int v14]
        v11.[int v14] <- v15
        let v16 : int32 = v14 + 1
        v12.l0 <- v16
        ()
    let v17 : ((char []) -> char list) = Array.toList
    let v18 : char list = v17 v11
    let v19 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v20 : (char -> (UH0 -> UH0)) = method38()
    let v21 : (char list -> (UH0 -> UH0)) = v19 v20
    let v22 : (UH0 -> UH0) = v21 v18
    let v23 : UH0 = UH0_0
    let v24 : UH0 = v22 v23
    let v25 : US8 = US8_0
    let struct (v26 : string, v27 : string) = method39(v9, v8, v24, v25)
    let v28 : (string []) = method40(v27)
    let v29 : string = "$0.to_vec()"
    let v30 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v28 v29
    let v31 : string = "true; let _result = v30.into_iter().map(|x| { //"
    let v32 : bool = Fable.Core.RustInterop.emitRustExpr () v31
    let v33 : string = "x"
    let v34 : string = Fable.Core.RustInterop.emitRustExpr () v33
    let v35 : string = "&*$0"
    let v36 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v34 v35
    let v37 : string = "String::from($0)"
    let v38 : std_string_String = Fable.Core.RustInterop.emitRustExpr v36 v37
    let v39 : string = "true; $0 }).collect()"
    let v40 : bool = Fable.Core.RustInterop.emitRustExpr v38 v39
    let v41 : string = "_result"
    let v42 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v41
    let v43 : US0 = US0_1
    let v44 : (unit -> string) = closure25()
    let v45 : (unit -> string) = closure26(v0, v1, v2, v3, v4, v5, v26, v42)
    method3(v43, v44, v45)
    let v46 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v46
    let v47 : bool = true
    let mutable _v47 : (int32 * string) option = None 
    (
    (fun () ->
    (fun () ->
    let v48 : string = "std::process::Command::new(&*$0)"
    let v49 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v26 v48
    let v50 : string = "true; let mut v49 = v49"
    let v51 : bool = Fable.Core.RustInterop.emitRustExpr () v50
    let v52 : string = "std::process::Command::args(&mut $0, &*$1)"
    let v53 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr struct (v49, v42) v52
    let v54 : string = "true; let mut v53 = v53"
    let v55 : bool = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : string = "std::process::Command::stdout(&mut $0, std::process::Stdio::piped())"
    let v57 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v53 v56
    let v58 : string = "true; let mut v57 = v57"
    let v59 : bool = Fable.Core.RustInterop.emitRustExpr () v58
    let v60 : string = "std::process::Command::stderr(&mut $0, std::process::Stdio::piped())"
    let v61 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v57 v60
    let v62 : string = "true; let mut v61 = v61"
    let v63 : bool = Fable.Core.RustInterop.emitRustExpr () v62
    let v64 : string = "std::process::Command::stdin(&mut $0, std::process::Stdio::piped())"
    let v65 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v61 v64
    let v66 : US4 option = None
    let _v66 = ref v66 
    match v5 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v67 : string = x
    let v68 : US4 = US4_0(v67)
    v68 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v66.Value <- x
    let v69 : US4 option = _v66.Value 
    let v70 : US4 = US4_1
    let v71 : US4 = v69 |> Option.defaultValue v70 
    let v77 : Ref<Mut<std_process_Command>> =
        match v71 with
        | US4_1 -> (* None *)
            v65
        | US4_0(v72) -> (* Some *)
            let v73 : string = method45(v72)
            let v74 : string = "std::process::Command::current_dir(v65, &*v73)"
            let v75 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr () v74
            v75
    let v78 : string = "true; let mut v77 = v77"
    let v79 : bool = Fable.Core.RustInterop.emitRustExpr () v78
    let v80 : string = "std::process::Command::spawn(&mut $0)"
    let v81 : Result<std_process_Child, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v77 v80
    let v82 : (std_io_Error -> std_string_String) = method29()
    let v83 : string = "$0.map_err(|x| $1(x))"
    let v84 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v81, v82) v83
    let v85 : string = "true; let _result = v84.map(|x| { //"
    let v86 : bool = Fable.Core.RustInterop.emitRustExpr () v85
    let v87 : string = "x"
    let v88 : std_process_Child = Fable.Core.RustInterop.emitRustExpr () v87
    let v89 : std_process_Child option = Some v88 
    let v90 : string = "std::sync::Mutex::new($0)"
    let v91 : std_sync_Mutex<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v89 v90
    let v92 : string = "std::sync::Arc::new($0)"
    let v93 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v91 v92
    let v94 : string = "true; $0 })"
    let v95 : bool = Fable.Core.RustInterop.emitRustExpr v93 v94
    let v96 : string = "_result"
    let v97 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v96
    let v98 : string = "match v97 { Ok(x) => $0(x), Err(e) => $1(e) }"
    let v99 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US11) = closure27()
    let v100 : (std_string_String -> US11) = closure28()
    let v101 : US11 = Fable.Core.RustInterop.emitRustExpr struct (v99, v100) v98
    let struct (v251 : int32, v252 : US3, v253 : US12) =
        match v101 with
        | US11_1(v242) -> (* Error *)
            let v243 : US0 = US0_4
            let v244 : (unit -> string) = closure29()
            let v245 : (unit -> string) = closure30(v242)
            method3(v243, v244, v245)
            let v246 : US3 = US3_0(v242)
            let v247 : US12 = US12_1
            struct (-1, v246, v247)
        | US11_0(v102) -> (* Ok *)
            let v103 : string = "$0.lock().unwrap().as_mut().unwrap().stdout.take().unwrap()"
            let v104 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr v102 v103
            let v105 : string = "$0.lock().unwrap().as_mut().unwrap().stderr.take().unwrap()"
            let v106 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr v102 v105
            let v107 : string = "$0.lock().unwrap().as_mut().unwrap().stdin.take().unwrap()"
            let v108 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr v102 v107
            let v109 : std_process_ChildStdout option = Some v104 
            let v110 : string = "std::sync::Mutex::new($0)"
            let v111 : std_sync_Mutex<std_process_ChildStdout option> = Fable.Core.RustInterop.emitRustExpr v109 v110
            let v112 : string = "std::sync::Arc::new($0)"
            let v113 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdout option>> = Fable.Core.RustInterop.emitRustExpr v111 v112
            let v114 : std_process_ChildStderr option = Some v106 
            let v115 : string = "std::sync::Mutex::new($0)"
            let v116 : std_sync_Mutex<std_process_ChildStderr option> = Fable.Core.RustInterop.emitRustExpr v114 v115
            let v117 : string = "std::sync::Arc::new($0)"
            let v118 : std_sync_Arc<std_sync_Mutex<std_process_ChildStderr option>> = Fable.Core.RustInterop.emitRustExpr v116 v117
            let v119 : std_process_ChildStdin option = Some v108 
            let v120 : string = "std::sync::Mutex::new($0)"
            let v121 : std_sync_Mutex<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v119 v120
            let v122 : string = "std::sync::Arc::new($0)"
            let v123 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v121 v122
            let v124 : string = "{ let (sender, receiver) = std::sync::mpsc::channel(); (sender, std::sync::Arc::new(receiver)) }"
            let struct (v125 : std_sync_mpsc_Sender<std_string_String>, v126 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = Fable.Core.RustInterop.emitRustExpr () v124
            let v127 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> = method46(v126)
            let v128 : string = "true; let v127 = v127"
            let v129 : bool = Fable.Core.RustInterop.emitRustExpr v127 v128
            let v130 : string = "std::sync::Mutex::new($0)"
            let v131 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v125 v130
            let v132 : string = "std::sync::Arc::new($0)"
            let v133 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v131 v132
            let v134 : string = "v133.clone()"
            let v135 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v134
            let v136 : string = "v133.clone()"
            let v137 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v136
            let v138 : string = "std::sync::Mutex::new($0)"
            let v139 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v127 v138
            let v140 : string = "std::sync::Arc::new($0)"
            let v141 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr v139 v140
            let v142 : string = "std::thread::spawn(move || { //"
            let v143 : std_thread_JoinHandle<unit> = Fable.Core.RustInterop.emitRustExpr () v142
            let v144 : string = "v113.lock().unwrap().take().unwrap()"
            let v145 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr () v144
            let v146 : string = "std::io::BufReader::new(v145)"
            let v147 : std_io_BufReader<std_process_ChildStdout> = Fable.Core.RustInterop.emitRustExpr () v146
            let v148 : string = "std::io::BufRead::lines(v147)"
            let v149 : std_io_Lines<std_io_BufReader<std_process_ChildStdout>> = Fable.Core.RustInterop.emitRustExpr () v148
            let v150 : string = "std::sync::Mutex::new($0)"
            let v151 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> = Fable.Core.RustInterop.emitRustExpr v149 v150
            let v152 : string = "std::sync::Arc::new($0)"
            let v153 : std_sync_Arc<std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>>> = Fable.Core.RustInterop.emitRustExpr v151 v152
            let v154 : string = "true; for line in $0.lock().unwrap().by_ref() { $1(line) }"
            let v155 : (Result<std_string_String, std_io_Error> -> unit) = closure31(v135)
            let v156 : bool = Fable.Core.RustInterop.emitRustExpr struct (v153, v155) v154
            let v157 : string = "true; })"
            let v158 : bool = Fable.Core.RustInterop.emitRustExpr () v157
            let v159 : string = "std::thread::spawn(move || { //"
            let v160 : std_thread_JoinHandle<unit> = Fable.Core.RustInterop.emitRustExpr () v159
            let v161 : string = "v118.lock().unwrap().take().unwrap()"
            let v162 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr () v161
            let v163 : string = "std::io::BufReader::new(v162)"
            let v164 : std_io_BufReader<std_process_ChildStderr> = Fable.Core.RustInterop.emitRustExpr () v163
            let v165 : string = "std::io::BufRead::lines(v164)"
            let v166 : std_io_Lines<std_io_BufReader<std_process_ChildStderr>> = Fable.Core.RustInterop.emitRustExpr () v165
            let v167 : string = "std::sync::Mutex::new($0)"
            let v168 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>> = Fable.Core.RustInterop.emitRustExpr v166 v167
            let v169 : string = "std::sync::Arc::new($0)"
            let v170 : std_sync_Arc<std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>>> = Fable.Core.RustInterop.emitRustExpr v168 v169
            let v171 : string = "true; for line in $0.lock().unwrap().by_ref() { $1(line) }"
            let v172 : (Result<std_string_String, std_io_Error> -> unit) = closure31(v133)
            let v173 : bool = Fable.Core.RustInterop.emitRustExpr struct (v170, v172) v171
            let v174 : string = "true; })"
            let v175 : bool = Fable.Core.RustInterop.emitRustExpr () v174
            let v176 : US14 option = None
            let _v176 = ref v176 
            match v4 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v177 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = x
            let v178 : US14 = US14_0(v177)
            v178 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v176.Value <- x
            let v179 : US14 option = _v176.Value 
            let v180 : US14 = US14_1
            let v181 : US14 = v179 |> Option.defaultValue v180 
            match v181 with
            | US14_1 -> (* None *)
                ()
            | US14_0(v182) -> (* Some *)
                let v183 : string = "v123.lock().unwrap().take()"
                let v184 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr () v183
                let v185 : string = "true; let _result = v184.map(|x| { //"
                let v186 : bool = Fable.Core.RustInterop.emitRustExpr () v185
                let v187 : string = "x"
                let v188 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr () v187
                let v189 : string = "std::sync::Mutex::new($0)"
                let v190 : std_sync_Mutex<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v188 v189
                let v191 : string = "std::sync::Arc::new($0)"
                let v192 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr v190 v191
                let v193 : string = "true; $0 })"
                let v194 : bool = Fable.Core.RustInterop.emitRustExpr v192 v193
                let v195 : string = "_result"
                let v196 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> option = Fable.Core.RustInterop.emitRustExpr () v195
                let v197 : US15 option = None
                let _v197 = ref v197 
                match v196 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v198 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = x
                let v199 : US15 = US15_0(v198)
                v199 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v197.Value <- x
                let v200 : US15 option = _v197.Value 
                let v201 : US15 = US15_1
                let v202 : US15 = v200 |> Option.defaultValue v201 
                match v202 with
                | US15_1 -> (* None *)
                    ()
                | US15_0(v203) -> (* Some *)
                    v182 v203
                    let v204 : string = "$0.lock()"
                    let v205 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr v203 v204
                    let v206 : string = "$0.unwrap()"
                    let v207 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v205 v206
                    let v208 : std_sync_MutexGuard<std_process_ChildStdin> = method47(v207)
                    let v209 : string = "true; let mut v208 = v208"
                    let v210 : bool = Fable.Core.RustInterop.emitRustExpr () v209
                    let v211 : string = "true; std::io::Write::flush(&mut *$0).unwrap()"
                    let v212 : bool = Fable.Core.RustInterop.emitRustExpr v208 v211
                    ()
            let v213 : string = "$0.lock().unwrap().take().unwrap().wait_with_output()"
            let v214 : Result<std_process_Output, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v102 v213
            let v215 : (std_io_Error -> std_string_String) = method29()
            let v216 : string = "$0.map_err(|x| $1(x))"
            let v217 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v214, v215) v216
            let v218 : string = "true; v143.join().unwrap()"
            let v219 : bool = Fable.Core.RustInterop.emitRustExpr () v218
            let v220 : string = "true; v160.join().unwrap()"
            let v221 : bool = Fable.Core.RustInterop.emitRustExpr () v220
            let v222 : (std_process_Output -> US16) = closure37()
            let v223 : (std_string_String -> US16) = closure38()
            let v224 : US16 = match v217 with Ok x -> v222 x | Error x -> v223 x
            match v224 with
            | US16_1(v230) -> (* Error *)
                let v231 : US0 = US0_4
                let v232 : (unit -> string) = closure39()
                let v233 : (unit -> string) = closure40(v230)
                method3(v231, v232, v233)
                let v234 : US3 = US3_0(v230)
                let v235 : US12 = US12_1
                struct (-2, v234, v235)
            | US16_0(v225) -> (* Ok *)
                let v226 : string = "$0.status.code().unwrap()"
                let v227 : int32 = Fable.Core.RustInterop.emitRustExpr v225 v226
                let v228 : US3 = US3_1
                let v229 : US12 = US12_0(v141)
                struct (v227, v228, v229)
    let v260 : US3 =
        match v253 with
        | US12_1 -> (* None *)
            US3_1
        | US12_0(v254) -> (* Some *)
            let v255 : string = "$0.lock().unwrap().iter().collect::<Vec<String>>().join(\"\\n\")"
            let v256 : std_string_String = Fable.Core.RustInterop.emitRustExpr v254 v255
            US3_0(v256)
    let v267 : US4 =
        match v260 with
        | US3_1 -> (* None *)
            US4_1
        | US3_0(v261) -> (* Some *)
            let v262 : string = "fable_library_rust::String_::fromString($0)"
            let v263 : string = Fable.Core.RustInterop.emitRustExpr v261 v262
            US4_0(v263)
    let v274 : US4 =
        match v252 with
        | US3_1 -> (* None *)
            US4_1
        | US3_0(v268) -> (* Some *)
            let v269 : string = "fable_library_rust::String_::fromString($0)"
            let v270 : string = Fable.Core.RustInterop.emitRustExpr v268 v269
            US4_0(v270)
    let v278 : string =
        match v274 with
        | US4_1 -> (* None *)
            let v276 : string = ""
            v276
        | US4_0(v275) -> (* Some *)
            v275
    let v281 : string =
        match v267 with
        | US4_1 -> (* None *)
            v278
        | US4_0(v279) -> (* Some *)
            v279
    let v282 : US0 = US0_0
    let v283 : (unit -> string) = closure41()
    let v284 : (unit -> string) = closure42(v251, v281)
    method3(v282, v283, v284)
    let v285 : (int32 * string) = v251, v281
    v285 
    )
    |> fun x -> x ()
    ) () )
    |> fun x -> _v47 <- Some x
    let v286 : (int32 * string) = _v47.Value 
    let v287 : (int32 * string) = method48(v286)
    let v288 : string = "v287 }}})"
    Fable.Core.RustInterop.emitRustExpr () v288
    let v289 : string = "{{ //"
    Fable.Core.RustInterop.emitRustExpr () v289
    let v290 : string = "__result"
    let v291 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = Fable.Core.RustInterop.emitRustExpr () v290
    let v292 : string = "futures_lite::future::block_on($0)"
    let v293 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v291 v292
    let (a, b) = v293
    let v294 : int32 = a
    let v295 : string = b
    struct (v294, v295) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v296 : int32, v297 : string) = null |> unbox<struct (int32 * string)>
    struct (v296, v297) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v298 : int32, v299 : string) = null |> unbox<struct (int32 * string)>
    struct (v298, v299) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v300 : int32, v301 : string) = null |> unbox<struct (int32 * string)>
    struct (v300, v301) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v302 : int32, v303 : string) = null |> unbox<struct (int32 * string)>
    struct (v302, v303) 
    #endif
#else
    let v304 : Async<struct (int32 * string)> = method49(v0, v1, v2, v3, v4, v5)
    let v305 : bool = true
    let mutable _v305 : struct (int32 * string) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v306 : int32, v307 : string) = null |> unbox<struct (int32 * string)>
    struct (v306, v307) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v308 : int32, v309 : string) = null |> unbox<struct (int32 * string)>
    struct (v308, v309) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v310 : int32, v311 : string) = null |> unbox<struct (int32 * string)>
    struct (v310, v311) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v312 : int32, v313 : string) = null |> unbox<struct (int32 * string)>
    struct (v312, v313) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v314 : int32, v315 : string) = null |> unbox<struct (int32 * string)>
    struct (v314, v315) 
    #endif
#else
    let v316 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v317 : int32, v318 : string) = v316 v304
    struct (v317, v318) 
    #endif
    |> fun x -> _v305 <- Some x
    let struct (v319 : int32, v320 : string) = _v305.Value
    struct (v319, v320) 
    #endif
    |> fun x -> _v6 <- Some x
    let struct (v321 : int32, v322 : string) = _v6.Value
    struct (v321, v322)
and method52 (v0 : string, v1 : string, v2 : string) : struct (string * string) =
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
and method53 () : string =
    let v0 : string = ""
    v0
and closure51 () () : string =
    let v0 : string = "documents.run / par_map / origin_hash |> sm'.contains local_git_hash |> not / hash2 = None || hash1 <>. (hash2 |> optionm.value)"
    v0
and closure52 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : int32, v5 : string, v6 : string, v7 : int32, v8 : string, v9 : string, v10 : US4) () : string =
    let v11 : (unit -> string) = closure6()
    let v12 : string = $"file: {v1} / real_path: {v2} / relative_path: {v0} / origin_hash_exit_code: {v4} / origin_hash: {v3} / local_git_hash_exit_code: {v7} / local_git_hash: {v6} / hash1: {v9} / hash2: %A{v10} / dist_path: {v5} / cache_path: {v8} / {v11 ()}"
    v12
and method54 (v0 : string) : string =
    v0
and method56 (v0 : int32, v1 : Mut6) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method57 (v0 : string) : string =
    v0
and method58 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure55 (v0 : string) (v1 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : unit =
    let v2 : string = "$0.lock()"
    let v3 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "$0.unwrap()"
    let v5 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = method57(v0)
    let v7 : string = "v6.as_bytes()"
    let v8 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : std_sync_MutexGuard<std_process_ChildStdin> = method58(v5)
    let v10 : string = "true; let mut v9 = v9"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : string = "true; std::io::Write::write_all(&mut *$0, v8).unwrap()"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr v9 v12
    ()
and method59 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method60 (v0 : string) : string =
    v0
and closure56 () () : string =
    let v0 : string = "documents.hangul"
    v0
and closure57 (v0 : string, v1 : int32, v2 : string) () : string =
    let v3 : int32 = v2 |> String.length
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"exit_code: %A{v1} / result_len: {v3} / output_path: {v0} / {v4 ()}"
    v5
and method55 (v0 : string, v1 : string, v2 : string, v3 : string) : US20 =
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
    while method56(v38, v40) do
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
    let v58 : string = method51()
    let v59 : (string -> (string seq -> string)) = String.concat
    let v60 : (string seq -> string) = v59 v58
    let v61 : string = v60 v57
    let v62 : string = $"{v61}

"
    let v63 : string option = None
    let v64 : System.Threading.CancellationToken option = None
    let v65 : (struct (string * string) []) = [||]
    let v66 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v67 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
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
    let struct (v87 : int32, v88 : string) = method35(v64, v84, v65, v66, v86, v63)
    let v89 : (string []) = v88.Split v28
    let v90 : int32 = v89.Length
    let v91 : string = ""
    let v92 : Mut7 = {l0 = 0; l1 = v91; l2 = 0; l3 = 0} : Mut7
    while method59(v38, v92) do
        let v94 : int32 = v92.l0
        let struct (v95 : string, v96 : int32, v97 : int32) = v92.l1, v92.l2, v92.l3
        let v98 : string = v31.[int v94]
        let v99 : bool = v98 = ""
        let struct (v113 : string, v114 : int32, v115 : int32) =
            if v99 then
                let v100 : string = $"{v95}
"
                let v101 : int32 = v96 + 1
                let v102 : int32 = v97 + 1
                struct (v100, v101, v102)
            else
                let v103 : int32 = v96 - v97
                let v104 : bool = v103 >= v90
                let v111 : string =
                    if v104 then
                        v95
                    else
                        let v105 : string = v89.[int v103]
                        let v106 : int32 = v90 - 1
                        let v107 : bool = v103 = v106
                        if v107 then
                            let v108 : string = $"{v95}{v105}"
                            v108
                        else
                            let v109 : string = $"{v95}{v105}
"
                            v109
                let v112 : int32 = v96 + 1
                struct (v111, v112, v97)
        let v116 : int32 = v94 + 1
        v92.l0 <- v116
        v92.l1 <- v113
        v92.l2 <- v114
        v92.l3 <- v115
        ()
    let struct (v117 : string, v118 : int32, v119 : int32) = v92.l1, v92.l2, v92.l3
    let v120 : bool = true
    let mutable _v120 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v121 : string = "std::fs::write(&*$0, &*$1).unwrap()"
    Fable.Core.RustInterop.emitRustExpr struct (v2, v117) v121
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
    let v122 : string = method60(v117)
    System.IO.File.WriteAllText (v2, v122)
    () 
    #endif
    |> fun x -> _v120 <- Some x
    _v120.Value
    let v123 : US0 = US0_2
    let v124 : (unit -> string) = closure56()
    let v125 : (unit -> string) = closure57(v2, v87, v117)
    method3(v123, v124, v125)
    US20_0(v87, v117)
and closure58 () () : string =
    let v0 : string = "documents.files_fn / error"
    v0
and closure59 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: %A{v1} / result: {v0} / {v2 ()}"
    v3
and closure54 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : US19 =
    let struct (v6 : string, v7 : string) = method52(v5, v4, v0)
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
            let v135 : string = "$0.iter().map(|x| *x).collect()"
            let v136 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v134 v135
            let v137 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
            let v138 : (uint8 -> string) = closure50()
            let v139 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v136, v138) v137
            let v140 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v141 : (string []) = Fable.Core.RustInterop.emitRustExpr v139 v140
            let v142 : string seq = seq { for i = 0 to v141.Length - 1 do yield v141.[i] }
            let v143 : string = method53()
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
            let v227 : string = "$0.iter().map(|x| *x).collect()"
            let v228 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v226 v227
            let v229 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
            let v230 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v228, v138) v229
            let v231 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v232 : (string []) = Fable.Core.RustInterop.emitRustExpr v230 v231
            let v233 : string seq = seq { for i = 0 to v232.Length - 1 do yield v232.[i] }
            let v234 : string = method53()
            let v235 : (string -> (string seq -> string)) = String.concat
            let v236 : (string seq -> string) = v235 v234
            let v237 : string = v236 v233
            let v238 : bool = v146 = v237
            v238
        else
            false
    let v240 : bool = v239 = false
    if v240 then
        let v241 : US20 = method55(v2, v3, v7, v4)
        match v241 with
        | US20_1(v282, v283) -> (* Error *)
            let v284 : (string * string) = v7, v283
            let v285 : Result<string, (string * string)> = Error v284
            US19_0(v285)
        | US20_0(v242, v243) -> (* Ok *)
            let v244 : bool = v242 <> 0
            if v244 then
                let v245 : US0 = US0_2
                let v246 : (unit -> string) = closure58()
                let v247 : (unit -> string) = closure59(v243, v242)
                method3(v245, v246, v247)
                let v248 : (string * string) = v7, v243
                let v249 : Result<string, (string * string)> = Error v248
                US19_0(v249)
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
                    let v273 : string = method54(v6)
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
                US19_0(v279)
    else
        US19_1
and closure53 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : string) : (string -> US19) =
    closure54(v0, v1, v2, v3, v4)
and closure62 () () : string =
    let v0 : string = "documents.crowbook / result contains ERROR"
    v0
and closure63 (v0 : string, v1 : string, v2 : int32) () : string =
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"exit_code: %A{v2} / output_path: {v0} / result: {v1} / {v3 ()}"
    v4
and method61 (v0 : string, v1 : string, v2 : string, v3 : string) : US20 =
    let v4 : string = $"crowbook --single \"{v1}\" --output \"{v0}\" --to {v3} --set rendering.num_depth 6 html.css.add \\\"' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} '\\\""
    let v5 : string option = None
    let v6 : System.Threading.CancellationToken option = None
    let v7 : (struct (string * string) []) = [||]
    let v8 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v9 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v10 : string option = Some v2 
    let struct (v11 : int32, v12 : string) = method35(v6, v4, v7, v8, v9, v10)
    let v13 : string = "ERROR"
    let v14 : bool = v12.Contains v13
    if v14 then
        let v15 : US0 = US0_3
        let v16 : (unit -> string) = closure62()
        let v17 : (unit -> string) = closure63(v0, v12, v11)
        method3(v15, v16, v17)
        US20_1(v11, v12)
    else
        US20_0(v11, v12)
and closure61 (v0 : string, v1 : string, v2 : string) (v3 : string) : US19 =
    let struct (v4 : string, v5 : string) = method52(v3, v2, v0)
    let v6 : bool = true
    let mutable _v6 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = "&*$0"
    let v8 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v7
    let v9 : string = "String::from($0)"
    let v10 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "std::path::PathBuf::from($0)"
    let v12 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "$0.exists()"
    let v14 : bool = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v17 : bool =
        if v14 then
            let v15 : string = "$0.is_file()"
            let v16 : bool = Fable.Core.RustInterop.emitRustExpr v12 v15
            v16
        else
            false
    v17 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v18 : bool = null |> unbox<bool>
    v18 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : bool = null |> unbox<bool>
    v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : string = "fs"
    let v21 : IFsExistsSync = Fable.Core.JsInterop.importAll v20
    let v22 : string = "$0.existsSync($1)"
    let v23 : bool = Fable.Core.JsInterop.emitJsExpr struct (v21, v5) v22
    v23 
    #endif
#if FABLE_COMPILER_PYTHON
    let v24 : bool = null |> unbox<bool>
    v24 
    #endif
#else
    let v25 : (string -> bool) = System.IO.File.Exists
    let v26 : bool = v25 v5
    v26 
    #endif
    |> fun x -> _v6 <- Some x
    let v27 : bool = _v6.Value
    let v49 : bool =
        if v27 then
            let v28 : bool = true
            let mutable _v28 : bool option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v29 : string = "&*$0"
            let v30 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v29
            let v31 : string = "String::from($0)"
            let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v30 v31
            let v33 : string = "std::path::PathBuf::from($0)"
            let v34 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v32 v33
            let v35 : string = "$0.exists()"
            let v36 : bool = Fable.Core.RustInterop.emitRustExpr v34 v35
            let v39 : bool =
                if v36 then
                    let v37 : string = "$0.is_file()"
                    let v38 : bool = Fable.Core.RustInterop.emitRustExpr v34 v37
                    v38
                else
                    false
            v39 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v40 : bool = null |> unbox<bool>
            v40 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v41 : bool = null |> unbox<bool>
            v41 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v42 : IFsExistsSync = Fable.Core.JsInterop.importAll v20
            let v43 : string = "$0.existsSync($1)"
            let v44 : bool = Fable.Core.JsInterop.emitJsExpr struct (v42, v4) v43
            v44 
            #endif
#if FABLE_COMPILER_PYTHON
            let v45 : bool = null |> unbox<bool>
            v45 
            #endif
#else
            let v46 : (string -> bool) = System.IO.File.Exists
            let v47 : bool = v46 v4
            v47 
            #endif
            |> fun x -> _v28 <- Some x
            let v48 : bool = _v28.Value
            v48
        else
            false
    let v237 : bool =
        if v49 then
            let v50 : bool = true
            let mutable _v50 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v51 : string = method18(v5)
            let v52 : string = method19()
            let v53 : bool = true
            let mutable _v53 : Result<regex_Regex, regex_Error> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v54 : string = method20()
            let v55 : string = $"regex::Regex::new(&$0)"
            let v56 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v54 v55
            v56 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v57 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v57 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v58 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v58 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v59 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v59 
            #endif
#if FABLE_COMPILER_PYTHON
            let v60 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v60 
            #endif
#else
            let v61 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v61 
            #endif
            |> fun x -> _v53 <- Some x
            let v62 : Result<regex_Regex, regex_Error> = _v53.Value
            let v63 : string = "$0.unwrap()"
            let v64 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v62 v63
            let v65 : string = $"$0.replace_all(&$1, &*$2)"
            let v66 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v64, v51, v52) v65
            let v67 : string = "String::from($0)"
            let v68 : std_string_String = Fable.Core.RustInterop.emitRustExpr v66 v67
            let v69 : string = "fable_library_rust::String_::fromString($0)"
            let v70 : string = Fable.Core.RustInterop.emitRustExpr v68 v69
            v70 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v71 : string = null |> unbox<string>
            v71 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v72 : string = null |> unbox<string>
            v72 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v73 : string = null |> unbox<string>
            v73 
            #endif
#if FABLE_COMPILER_PYTHON
            let v74 : string = null |> unbox<string>
            v74 
            #endif
#else
            let v75 : string = method21()
            let v76 : string = "^\\\\\\\\\\?\\\\"
            let v77 : string = System.Text.RegularExpressions.Regex.Replace (v5, v76, v75)
            v77 
            #endif
            |> fun x -> _v50 <- Some x
            let v78 : string = _v50.Value
            let v79 : string = $"{v78.[0] |> string |> _.ToLower()}{v78.[1..]}"
            let v80 : string = "\\"
            let v81 : string = "/"
            let v82 : string = v79.Replace (v80, v81)
            let v83 : string = "std::fs::File::open(&*v82)"
            let v84 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v83
            let v85 : string = "$0.unwrap()"
            let v86 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v84 v85
            let v87 : string = "std::io::BufReader::new(v86)"
            let v88 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v87
            let v89 : string = "true; let mut v88 = v88"
            let v90 : bool = Fable.Core.RustInterop.emitRustExpr () v89
            let v91 : string = "sha2::Digest::new()"
            let v92 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v91
            let v93 : string = "true; let mut v92 = v92"
            let v94 : bool = Fable.Core.RustInterop.emitRustExpr () v93
            let v95 : unativeint = unativeint 0
            let v96 : string = "[$0; 1024]"
            let v97 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v96
            let v98 : string = "true; loop { // rust.loop"
            let v99 : bool = Fable.Core.RustInterop.emitRustExpr () v98
            let v100 : string = "true; let mut v97 = v97"
            let v101 : bool = Fable.Core.RustInterop.emitRustExpr () v100
            let v102 : string = "std::io::Read::read(&mut v88, &mut v97)"
            let v103 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v102
            let v104 : string = "$0.unwrap()"
            let v105 : unativeint = Fable.Core.RustInterop.emitRustExpr v103 v104
            let v106 : bool = v105 = v95
            if v106 then
                let v107 : string = "true; break"
                let v108 : bool = Fable.Core.RustInterop.emitRustExpr () v107
                ()
            let v109 : string = "v97.len()"
            let v110 : unativeint = Fable.Core.RustInterop.emitRustExpr () v109
            let v111 : uint8 = uint8 v110 
            let v112 : unativeint = unativeint v105
            let v113 : unativeint = v112 |> unbox<unativeint>
            let v114 : bool = v113 = v110
            let v119 : Ref<Slice'<uint8>> =
                if v114 then
                    let v115 : string = "&v97[v95..]"
                    let v116 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v115
                    v116
                else
                    let v117 : string = "&v97[$0..$1]"
                    let v118 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v95, v112) v117
                    v118
            let v120 : string = "sha2::Digest::update(&mut v92, v119)"
            Fable.Core.RustInterop.emitRustExpr () v120
            let v121 : string = "true; } // rust.loop"
            let v122 : bool = Fable.Core.RustInterop.emitRustExpr () v121
            let v123 : string = "true; } // rust.loop"
            let v124 : bool = Fable.Core.RustInterop.emitRustExpr () v123
            let v125 : string = "true; } // rust.loop"
            let v126 : bool = Fable.Core.RustInterop.emitRustExpr () v125
            let v127 : string = "true; { // rust.loop"
            let v128 : bool = Fable.Core.RustInterop.emitRustExpr () v127
            let v129 : string = "true; { // rust.loop"
            let v130 : bool = Fable.Core.RustInterop.emitRustExpr () v129
            let v131 : string = "&sha2::Digest::finalize(v92)"
            let v132 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v131
            let v133 : string = "$0.iter().map(|x| *x).collect()"
            let v134 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v132 v133
            let v135 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
            let v136 : (uint8 -> string) = closure50()
            let v137 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v134, v136) v135
            let v138 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v139 : (string []) = Fable.Core.RustInterop.emitRustExpr v137 v138
            let v140 : string seq = seq { for i = 0 to v139.Length - 1 do yield v139.[i] }
            let v141 : string = method53()
            let v142 : (string -> (string seq -> string)) = String.concat
            let v143 : (string seq -> string) = v142 v141
            let v144 : string = v143 v140
            let v145 : bool = true
            let mutable _v145 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v146 : string = method18(v4)
            let v147 : string = method19()
            let v148 : bool = true
            let mutable _v148 : Result<regex_Regex, regex_Error> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v149 : string = method20()
            let v150 : string = $"regex::Regex::new(&$0)"
            let v151 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v149 v150
            v151 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v152 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v152 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v153 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v153 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v154 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v154 
            #endif
#if FABLE_COMPILER_PYTHON
            let v155 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v155 
            #endif
#else
            let v156 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v156 
            #endif
            |> fun x -> _v148 <- Some x
            let v157 : Result<regex_Regex, regex_Error> = _v148.Value
            let v158 : string = "$0.unwrap()"
            let v159 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v157 v158
            let v160 : string = $"$0.replace_all(&$1, &*$2)"
            let v161 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v159, v146, v147) v160
            let v162 : string = "String::from($0)"
            let v163 : std_string_String = Fable.Core.RustInterop.emitRustExpr v161 v162
            let v164 : string = "fable_library_rust::String_::fromString($0)"
            let v165 : string = Fable.Core.RustInterop.emitRustExpr v163 v164
            v165 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v166 : string = null |> unbox<string>
            v166 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v167 : string = null |> unbox<string>
            v167 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v168 : string = null |> unbox<string>
            v168 
            #endif
#if FABLE_COMPILER_PYTHON
            let v169 : string = null |> unbox<string>
            v169 
            #endif
#else
            let v170 : string = method21()
            let v171 : string = System.Text.RegularExpressions.Regex.Replace (v4, v76, v170)
            v171 
            #endif
            |> fun x -> _v145 <- Some x
            let v172 : string = _v145.Value
            let v173 : string = $"{v172.[0] |> string |> _.ToLower()}{v172.[1..]}"
            let v174 : string = v173.Replace (v80, v81)
            let v175 : string = "std::fs::File::open(&*v174)"
            let v176 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v175
            let v177 : string = "$0.unwrap()"
            let v178 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v176 v177
            let v179 : string = "std::io::BufReader::new(v178)"
            let v180 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v179
            let v181 : string = "true; let mut v180 = v180"
            let v182 : bool = Fable.Core.RustInterop.emitRustExpr () v181
            let v183 : string = "sha2::Digest::new()"
            let v184 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v183
            let v185 : string = "true; let mut v184 = v184"
            let v186 : bool = Fable.Core.RustInterop.emitRustExpr () v185
            let v187 : unativeint = unativeint 0
            let v188 : string = "[$0; 1024]"
            let v189 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v188
            let v190 : string = "true; loop { // rust.loop"
            let v191 : bool = Fable.Core.RustInterop.emitRustExpr () v190
            let v192 : string = "true; let mut v189 = v189"
            let v193 : bool = Fable.Core.RustInterop.emitRustExpr () v192
            let v194 : string = "std::io::Read::read(&mut v180, &mut v189)"
            let v195 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v194
            let v196 : string = "$0.unwrap()"
            let v197 : unativeint = Fable.Core.RustInterop.emitRustExpr v195 v196
            let v198 : bool = v197 = v187
            if v198 then
                let v199 : string = "true; break"
                let v200 : bool = Fable.Core.RustInterop.emitRustExpr () v199
                ()
            let v201 : string = "v189.len()"
            let v202 : unativeint = Fable.Core.RustInterop.emitRustExpr () v201
            let v203 : uint8 = uint8 v202 
            let v204 : unativeint = unativeint v197
            let v205 : unativeint = v204 |> unbox<unativeint>
            let v206 : bool = v205 = v202
            let v211 : Ref<Slice'<uint8>> =
                if v206 then
                    let v207 : string = "&v189[v187..]"
                    let v208 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v207
                    v208
                else
                    let v209 : string = "&v189[$0..$1]"
                    let v210 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v187, v204) v209
                    v210
            let v212 : string = "sha2::Digest::update(&mut v184, v211)"
            Fable.Core.RustInterop.emitRustExpr () v212
            let v213 : string = "true; } // rust.loop"
            let v214 : bool = Fable.Core.RustInterop.emitRustExpr () v213
            let v215 : string = "true; } // rust.loop"
            let v216 : bool = Fable.Core.RustInterop.emitRustExpr () v215
            let v217 : string = "true; } // rust.loop"
            let v218 : bool = Fable.Core.RustInterop.emitRustExpr () v217
            let v219 : string = "true; { // rust.loop"
            let v220 : bool = Fable.Core.RustInterop.emitRustExpr () v219
            let v221 : string = "true; { // rust.loop"
            let v222 : bool = Fable.Core.RustInterop.emitRustExpr () v221
            let v223 : string = "&sha2::Digest::finalize(v184)"
            let v224 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v223
            let v225 : string = "$0.iter().map(|x| *x).collect()"
            let v226 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v224 v225
            let v227 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
            let v228 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v226, v136) v227
            let v229 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v230 : (string []) = Fable.Core.RustInterop.emitRustExpr v228 v229
            let v231 : string seq = seq { for i = 0 to v230.Length - 1 do yield v230.[i] }
            let v232 : string = method53()
            let v233 : (string -> (string seq -> string)) = String.concat
            let v234 : (string seq -> string) = v233 v232
            let v235 : string = v234 v231
            let v236 : bool = v144 = v235
            v236
        else
            false
    let v238 : bool = v237 = false
    if v238 then
        let v239 : US20 = method61(v5, v2, v1, v3)
        match v239 with
        | US20_1(v280, v281) -> (* Error *)
            let v282 : (string * string) = v5, v281
            let v283 : Result<string, (string * string)> = Error v282
            US19_0(v283)
        | US20_0(v240, v241) -> (* Ok *)
            let v242 : bool = v240 <> 0
            if v242 then
                let v243 : US0 = US0_2
                let v244 : (unit -> string) = closure58()
                let v245 : (unit -> string) = closure59(v241, v240)
                method3(v243, v244, v245)
                let v246 : (string * string) = v5, v241
                let v247 : Result<string, (string * string)> = Error v246
                US19_0(v247)
            else
                let v249 : bool = true
                let mutable _v249 : bool option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v250 : string = "&*$0"
                let v251 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v250
                let v252 : string = "String::from($0)"
                let v253 : std_string_String = Fable.Core.RustInterop.emitRustExpr v251 v252
                let v254 : string = "std::path::PathBuf::from($0)"
                let v255 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v253 v254
                let v256 : string = "$0.exists()"
                let v257 : bool = Fable.Core.RustInterop.emitRustExpr v255 v256
                let v260 : bool =
                    if v257 then
                        let v258 : string = "$0.is_file()"
                        let v259 : bool = Fable.Core.RustInterop.emitRustExpr v255 v258
                        v259
                    else
                        false
                v260 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v261 : bool = null |> unbox<bool>
                v261 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v262 : bool = null |> unbox<bool>
                v262 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v263 : IFsExistsSync = Fable.Core.JsInterop.importAll v20
                let v264 : string = "$0.existsSync($1)"
                let v265 : bool = Fable.Core.JsInterop.emitJsExpr struct (v263, v5) v264
                v265 
                #endif
#if FABLE_COMPILER_PYTHON
                let v266 : bool = null |> unbox<bool>
                v266 
                #endif
#else
                let v267 : (string -> bool) = System.IO.File.Exists
                let v268 : bool = v267 v5
                v268 
                #endif
                |> fun x -> _v249 <- Some x
                let v269 : bool = _v249.Value
                if v269 then
                    let v270 : bool = true
                    let mutable _v270 : unit option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v271 : string = method54(v4)
                    let v272 : string = "std::fs::copy(&*$0, &*v271)"
                    let v273 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v5 v272
                    let v274 : string = "$0.unwrap()"
                    let v275 : uint64 = Fable.Core.RustInterop.emitRustExpr v273 v274
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
                    System.IO.File.Copy (v5, v4, true)
                    () 
                    #endif
                    |> fun x -> _v270 <- Some x
                    _v270.Value
                    ()
                else
                    let v276 : string = $"documents.files_fn / {v5} should exist"
                    failwith<unit> v276
                let v277 : Result<string, (string * string)> = Ok v5
                US19_0(v277)
    else
        US19_1
and closure60 (v0 : string, v1 : string) (v2 : string) : (string -> US19) =
    closure61(v0, v1, v2)
and closure64 () () : string =
    let v0 : string = "documents.run / par_map / files' = [] / listm.iter"
    v0
and closure65 (v0 : string, v1 : string) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"output_path: %A{v1} / output_cache_path: {v0} / {v2 ()}"
    v3
and method62 (v0 : UH2, v1 : UH3 list) : UH3 list =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : UH3 list = method62(v3, v1)
        let v5 : UH3 list = v2 :: v4 
        v5
    | UH2_0 -> (* Nil *)
        v1
and method63 (v0 : int32, v1 : Mut8) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method64 (v0 : UH3, v1 : struct (string * string * (string -> (string -> US19))) list) : struct (string * string * (string -> (string -> US19))) list =
    match v0 with
    | UH3_1(v2, v3, v4, v5) -> (* Cons *)
        let v6 : struct (string * string * (string -> (string -> US19))) list = method64(v5, v1)
        let v7 : struct (string * string * (string -> (string -> US19))) list = struct (v2, v3, v4) :: v6 
        v7
    | UH3_0 -> (* Nil *)
        v1
and closure66 () struct (v0 : string, v1 : string, v2 : (string -> (string -> US19))) : Result<string, (string * string)> option =
    let v3 : (string -> US19) = v2 v1
    let v4 : US19 = v3 v0
    match v4 with
    | US19_1 -> (* None *)
        let v7 : Result<string, (string * string)> option = None
        v7
    | US19_0(v5) -> (* Some *)
        let v6 : Result<string, (string * string)> option = Some v5 
        v6
and method65 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method66 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
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
    let v241 : string option = None
    let v242 : System.Threading.CancellationToken option = None
    let v243 : (struct (string * string) []) = [||]
    let v244 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v245 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v246 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v240}\""
    let v247 : string option = Some v2 
    let struct (v248 : int32, v249 : string) = method35(v242, v246, v243, v244, v245, v247)
    let v250 : string = method11(v3, v207)
    let v251 : string = method34(v250)
    let v252 : string option = None
    let v253 : System.Threading.CancellationToken option = None
    let v254 : (struct (string * string) []) = [||]
    let v255 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v256 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v257 : string = $"git hash-object \"{v251}\""
    let v258 : string option = Some v3 
    let struct (v259 : int32, v260 : string) = method35(v253, v257, v254, v255, v256, v258)
    let v261 : string = method11(v4, v207)
    let v262 : string = method34(v261)
    let v263 : string = "hangul.md"
    let struct (v264 : string, v265 : string) = method52(v263, v251, v4)
    let v266 : bool = v249.Contains v260
    let v267 : bool = v266 = false
    let v513 : UH2 =
        if v267 then
            let v268 : bool = true
            let mutable _v268 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v269 : string = method18(v251)
            let v270 : string = method19()
            let v271 : bool = true
            let mutable _v271 : Result<regex_Regex, regex_Error> option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v272 : string = method20()
            let v273 : string = $"regex::Regex::new(&$0)"
            let v274 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v272 v273
            v274 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v275 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v275 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v276 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v276 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v277 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v277 
            #endif
#if FABLE_COMPILER_PYTHON
            let v278 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v278 
            #endif
#else
            let v279 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
            v279 
            #endif
            |> fun x -> _v271 <- Some x
            let v280 : Result<regex_Regex, regex_Error> = _v271.Value
            let v281 : string = "$0.unwrap()"
            let v282 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v280 v281
            let v283 : string = $"$0.replace_all(&$1, &*$2)"
            let v284 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v282, v269, v270) v283
            let v285 : string = "String::from($0)"
            let v286 : std_string_String = Fable.Core.RustInterop.emitRustExpr v284 v285
            let v287 : string = "fable_library_rust::String_::fromString($0)"
            let v288 : string = Fable.Core.RustInterop.emitRustExpr v286 v287
            v288 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v289 : string = null |> unbox<string>
            v289 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v290 : string = null |> unbox<string>
            v290 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v291 : string = null |> unbox<string>
            v291 
            #endif
#if FABLE_COMPILER_PYTHON
            let v292 : string = null |> unbox<string>
            v292 
            #endif
#else
            let v293 : string = method21()
            let v294 : string = System.Text.RegularExpressions.Regex.Replace (v251, v234, v293)
            v294 
            #endif
            |> fun x -> _v268 <- Some x
            let v295 : string = _v268.Value
            let v296 : string = $"{v295.[0] |> string |> _.ToLower()}{v295.[1..]}"
            let v297 : string = v296.Replace (v204, v205)
            let v298 : string = "std::fs::File::open(&*v297)"
            let v299 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v298
            let v300 : string = "$0.unwrap()"
            let v301 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v299 v300
            let v302 : string = "std::io::BufReader::new(v301)"
            let v303 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v302
            let v304 : string = "true; let mut v303 = v303"
            let v305 : bool = Fable.Core.RustInterop.emitRustExpr () v304
            let v306 : string = "sha2::Digest::new()"
            let v307 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v306
            let v308 : string = "true; let mut v307 = v307"
            let v309 : bool = Fable.Core.RustInterop.emitRustExpr () v308
            let v310 : unativeint = unativeint 0
            let v311 : string = "[$0; 1024]"
            let v312 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v311
            let v313 : string = "true; loop { // rust.loop"
            let v314 : bool = Fable.Core.RustInterop.emitRustExpr () v313
            let v315 : string = "true; let mut v312 = v312"
            let v316 : bool = Fable.Core.RustInterop.emitRustExpr () v315
            let v317 : string = "std::io::Read::read(&mut v303, &mut v312)"
            let v318 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v317
            let v319 : string = "$0.unwrap()"
            let v320 : unativeint = Fable.Core.RustInterop.emitRustExpr v318 v319
            let v321 : bool = v320 = v310
            if v321 then
                let v322 : string = "true; break"
                let v323 : bool = Fable.Core.RustInterop.emitRustExpr () v322
                ()
            let v324 : string = "v312.len()"
            let v325 : unativeint = Fable.Core.RustInterop.emitRustExpr () v324
            let v326 : uint8 = uint8 v325 
            let v327 : unativeint = unativeint v320
            let v328 : unativeint = v327 |> unbox<unativeint>
            let v329 : bool = v328 = v325
            let v334 : Ref<Slice'<uint8>> =
                if v329 then
                    let v330 : string = "&v312[v310..]"
                    let v331 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v330
                    v331
                else
                    let v332 : string = "&v312[$0..$1]"
                    let v333 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v310, v327) v332
                    v333
            let v335 : string = "sha2::Digest::update(&mut v307, v334)"
            Fable.Core.RustInterop.emitRustExpr () v335
            let v336 : string = "true; } // rust.loop"
            let v337 : bool = Fable.Core.RustInterop.emitRustExpr () v336
            let v338 : string = "true; } // rust.loop"
            let v339 : bool = Fable.Core.RustInterop.emitRustExpr () v338
            let v340 : string = "true; } // rust.loop"
            let v341 : bool = Fable.Core.RustInterop.emitRustExpr () v340
            let v342 : string = "true; { // rust.loop"
            let v343 : bool = Fable.Core.RustInterop.emitRustExpr () v342
            let v344 : string = "true; { // rust.loop"
            let v345 : bool = Fable.Core.RustInterop.emitRustExpr () v344
            let v346 : string = "&sha2::Digest::finalize(v307)"
            let v347 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v346
            let v348 : string = "$0.iter().map(|x| *x).collect()"
            let v349 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v347 v348
            let v350 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
            let v351 : (uint8 -> string) = closure50()
            let v352 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v349, v351) v350
            let v353 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v354 : (string []) = Fable.Core.RustInterop.emitRustExpr v352 v353
            let v355 : string seq = seq { for i = 0 to v354.Length - 1 do yield v354.[i] }
            let v356 : string = method53()
            let v357 : (string -> (string seq -> string)) = String.concat
            let v358 : (string seq -> string) = v357 v356
            let v359 : string = v358 v355
            let v360 : bool = true
            let mutable _v360 : bool option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v361 : string = "&*$0"
            let v362 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v262 v361
            let v363 : string = "String::from($0)"
            let v364 : std_string_String = Fable.Core.RustInterop.emitRustExpr v362 v363
            let v365 : string = "std::path::PathBuf::from($0)"
            let v366 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v364 v365
            let v367 : string = "$0.exists()"
            let v368 : bool = Fable.Core.RustInterop.emitRustExpr v366 v367
            let v371 : bool =
                if v368 then
                    let v369 : string = "$0.is_file()"
                    let v370 : bool = Fable.Core.RustInterop.emitRustExpr v366 v369
                    v370
                else
                    false
            v371 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v372 : bool = null |> unbox<bool>
            v372 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v373 : bool = null |> unbox<bool>
            v373 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v374 : string = "fs"
            let v375 : IFsExistsSync = Fable.Core.JsInterop.importAll v374
            let v376 : string = "$0.existsSync($1)"
            let v377 : bool = Fable.Core.JsInterop.emitJsExpr struct (v375, v262) v376
            v377 
            #endif
#if FABLE_COMPILER_PYTHON
            let v378 : bool = null |> unbox<bool>
            v378 
            #endif
#else
            let v379 : (string -> bool) = System.IO.File.Exists
            let v380 : bool = v379 v262
            v380 
            #endif
            |> fun x -> _v360 <- Some x
            let v381 : bool = _v360.Value
            let v475 : US4 =
                if v381 then
                    let v382 : bool = true
                    let mutable _v382 : string option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v383 : string = method18(v262)
                    let v384 : string = method19()
                    let v385 : bool = true
                    let mutable _v385 : Result<regex_Regex, regex_Error> option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v386 : string = method20()
                    let v387 : string = $"regex::Regex::new(&$0)"
                    let v388 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v386 v387
                    v388 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v389 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
                    v389 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v390 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
                    v390 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v391 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
                    v391 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v392 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
                    v392 
                    #endif
#else
                    let v393 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
                    v393 
                    #endif
                    |> fun x -> _v385 <- Some x
                    let v394 : Result<regex_Regex, regex_Error> = _v385.Value
                    let v395 : string = "$0.unwrap()"
                    let v396 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v394 v395
                    let v397 : string = $"$0.replace_all(&$1, &*$2)"
                    let v398 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v396, v383, v384) v397
                    let v399 : string = "String::from($0)"
                    let v400 : std_string_String = Fable.Core.RustInterop.emitRustExpr v398 v399
                    let v401 : string = "fable_library_rust::String_::fromString($0)"
                    let v402 : string = Fable.Core.RustInterop.emitRustExpr v400 v401
                    v402 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v403 : string = null |> unbox<string>
                    v403 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v404 : string = null |> unbox<string>
                    v404 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v405 : string = null |> unbox<string>
                    v405 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v406 : string = null |> unbox<string>
                    v406 
                    #endif
#else
                    let v407 : string = method21()
                    let v408 : string = System.Text.RegularExpressions.Regex.Replace (v262, v234, v407)
                    v408 
                    #endif
                    |> fun x -> _v382 <- Some x
                    let v409 : string = _v382.Value
                    let v410 : string = $"{v409.[0] |> string |> _.ToLower()}{v409.[1..]}"
                    let v411 : string = v410.Replace (v204, v205)
                    let v412 : string = "std::fs::File::open(&*v411)"
                    let v413 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v412
                    let v414 : string = "$0.unwrap()"
                    let v415 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v413 v414
                    let v416 : string = "std::io::BufReader::new(v415)"
                    let v417 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v416
                    let v418 : string = "true; let mut v417 = v417"
                    let v419 : bool = Fable.Core.RustInterop.emitRustExpr () v418
                    let v420 : string = "sha2::Digest::new()"
                    let v421 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v420
                    let v422 : string = "true; let mut v421 = v421"
                    let v423 : bool = Fable.Core.RustInterop.emitRustExpr () v422
                    let v424 : unativeint = unativeint 0
                    let v425 : string = "[$0; 1024]"
                    let v426 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v425
                    let v427 : string = "true; loop { // rust.loop"
                    let v428 : bool = Fable.Core.RustInterop.emitRustExpr () v427
                    let v429 : string = "true; let mut v426 = v426"
                    let v430 : bool = Fable.Core.RustInterop.emitRustExpr () v429
                    let v431 : string = "std::io::Read::read(&mut v417, &mut v426)"
                    let v432 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v431
                    let v433 : string = "$0.unwrap()"
                    let v434 : unativeint = Fable.Core.RustInterop.emitRustExpr v432 v433
                    let v435 : bool = v434 = v424
                    if v435 then
                        let v436 : string = "true; break"
                        let v437 : bool = Fable.Core.RustInterop.emitRustExpr () v436
                        ()
                    let v438 : string = "v426.len()"
                    let v439 : unativeint = Fable.Core.RustInterop.emitRustExpr () v438
                    let v440 : uint8 = uint8 v439 
                    let v441 : unativeint = unativeint v434
                    let v442 : unativeint = v441 |> unbox<unativeint>
                    let v443 : bool = v442 = v439
                    let v448 : Ref<Slice'<uint8>> =
                        if v443 then
                            let v444 : string = "&v426[v424..]"
                            let v445 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v444
                            v445
                        else
                            let v446 : string = "&v426[$0..$1]"
                            let v447 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v424, v441) v446
                            v447
                    let v449 : string = "sha2::Digest::update(&mut v421, v448)"
                    Fable.Core.RustInterop.emitRustExpr () v449
                    let v450 : string = "true; } // rust.loop"
                    let v451 : bool = Fable.Core.RustInterop.emitRustExpr () v450
                    let v452 : string = "true; } // rust.loop"
                    let v453 : bool = Fable.Core.RustInterop.emitRustExpr () v452
                    let v454 : string = "true; } // rust.loop"
                    let v455 : bool = Fable.Core.RustInterop.emitRustExpr () v454
                    let v456 : string = "true; { // rust.loop"
                    let v457 : bool = Fable.Core.RustInterop.emitRustExpr () v456
                    let v458 : string = "true; { // rust.loop"
                    let v459 : bool = Fable.Core.RustInterop.emitRustExpr () v458
                    let v460 : string = "&sha2::Digest::finalize(v421)"
                    let v461 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v460
                    let v462 : string = "$0.iter().map(|x| *x).collect()"
                    let v463 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v461 v462
                    let v464 : string = "$0.into_iter().map(|x| $1(x.clone())).collect()"
                    let v465 : Vec<string> = Fable.Core.RustInterop.emitRustExpr struct (v463, v351) v464
                    let v466 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v467 : (string []) = Fable.Core.RustInterop.emitRustExpr v465 v466
                    let v468 : string seq = seq { for i = 0 to v467.Length - 1 do yield v467.[i] }
                    let v469 : string = method53()
                    let v470 : (string -> (string seq -> string)) = String.concat
                    let v471 : (string seq -> string) = v470 v469
                    let v472 : string = v471 v468
                    US4_0(v472)
                else
                    US4_1
            let v477 : bool =
                match v475 with
                | US4_1 -> (* None *)
                    true
                | _ ->
                    false
            let v483 : bool =
                if v477 then
                    true
                else
                    let v481 : string =
                        match v475 with
                        | US4_1 -> (* None *)
                            failwith<string> "Option does not have a value."
                        | US4_0(v478) -> (* Some *)
                            v478
                    let v482 : bool = v359 <> v481
                    v482
            if v483 then
                let v484 : US0 = US0_2
                let v485 : (unit -> string) = closure51()
                let v486 : (unit -> string) = closure52(v207, v238, v240, v249, v248, v251, v260, v259, v262, v359, v475)
                method3(v484, v485, v486)
                let v487 : bool = true
                let mutable _v487 : unit option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v488 : string = method54(v262)
                let v489 : string = "std::fs::copy(&*$0, &*v488)"
                let v490 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v251 v489
                let v491 : string = "$0.unwrap()"
                let v492 : uint64 = Fable.Core.RustInterop.emitRustExpr v490 v491
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
                System.IO.File.Copy (v251, v262, true)
                () 
                #endif
                |> fun x -> _v487 <- Some x
                _v487.Value
                let v493 : (string -> (string -> US19)) = closure53(v4, v3, v1, v0)
                let v494 : UH3 = UH3_0
                let v495 : UH3 = UH3_1(v263, v251, v493, v494)
                let v496 : string = "html"
                let v497 : (string -> (string -> US19)) = closure60(v4, v3)
                let v498 : string = "pdf"
                let v499 : string = "epub"
                let v500 : UH3 = UH3_0
                let v501 : UH3 = UH3_1(v499, v265, v497, v500)
                let v502 : UH3 = UH3_1(v498, v265, v497, v501)
                let v503 : UH3 = UH3_1(v496, v265, v497, v502)
                let v504 : UH3 = UH3_1(v499, v251, v497, v503)
                let v505 : UH3 = UH3_1(v498, v251, v497, v504)
                let v506 : UH3 = UH3_1(v496, v251, v497, v505)
                let v507 : UH2 = UH2_0
                let v508 : UH2 = UH2_1(v506, v507)
                UH2_1(v495, v508)
            else
                UH2_0
        else
            UH2_0
    let v515 : bool =
        match v513 with
        | UH2_0 -> (* Nil *)
            true
        | _ ->
            false
    let v516 : bool = v515 <> true
    let v941 : UH2 =
        if v516 then
            v513
        else
            let v517 : string = "epub"
            let struct (v518 : string, v519 : string) = method52(v517, v265, v4)
            let v520 : bool = true
            let mutable _v520 : bool option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v521 : string = "&*$0"
            let v522 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v519 v521
            let v523 : string = "String::from($0)"
            let v524 : std_string_String = Fable.Core.RustInterop.emitRustExpr v522 v523
            let v525 : string = "std::path::PathBuf::from($0)"
            let v526 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v524 v525
            let v527 : string = "$0.exists()"
            let v528 : bool = Fable.Core.RustInterop.emitRustExpr v526 v527
            let v531 : bool =
                if v528 then
                    let v529 : string = "$0.is_file()"
                    let v530 : bool = Fable.Core.RustInterop.emitRustExpr v526 v529
                    v530
                else
                    false
            v531 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v532 : bool = null |> unbox<bool>
            v532 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v533 : bool = null |> unbox<bool>
            v533 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v534 : string = "fs"
            let v535 : IFsExistsSync = Fable.Core.JsInterop.importAll v534
            let v536 : string = "$0.existsSync($1)"
            let v537 : bool = Fable.Core.JsInterop.emitJsExpr struct (v535, v519) v536
            v537 
            #endif
#if FABLE_COMPILER_PYTHON
            let v538 : bool = null |> unbox<bool>
            v538 
            #endif
#else
            let v539 : (string -> bool) = System.IO.File.Exists
            let v540 : bool = v539 v519
            v540 
            #endif
            |> fun x -> _v520 <- Some x
            let v541 : bool = _v520.Value
            let v542 : bool = v541 = false
            let v574 : bool =
                if v542 then
                    let v543 : bool = true
                    let mutable _v543 : bool option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v544 : string = "&*$0"
                    let v545 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v518 v544
                    let v546 : string = "String::from($0)"
                    let v547 : std_string_String = Fable.Core.RustInterop.emitRustExpr v545 v546
                    let v548 : string = "std::path::PathBuf::from($0)"
                    let v549 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v547 v548
                    let v550 : string = "$0.exists()"
                    let v551 : bool = Fable.Core.RustInterop.emitRustExpr v549 v550
                    let v554 : bool =
                        if v551 then
                            let v552 : string = "$0.is_file()"
                            let v553 : bool = Fable.Core.RustInterop.emitRustExpr v549 v552
                            v553
                        else
                            false
                    v554 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v555 : bool = null |> unbox<bool>
                    v555 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v556 : bool = null |> unbox<bool>
                    v556 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v557 : IFsExistsSync = Fable.Core.JsInterop.importAll v534
                    let v558 : string = "$0.existsSync($1)"
                    let v559 : bool = Fable.Core.JsInterop.emitJsExpr struct (v557, v518) v558
                    v559 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v560 : bool = null |> unbox<bool>
                    v560 
                    #endif
#else
                    let v561 : (string -> bool) = System.IO.File.Exists
                    let v562 : bool = v561 v518
                    v562 
                    #endif
                    |> fun x -> _v543 <- Some x
                    let v563 : bool = _v543.Value
                    if v563 then
                        let v564 : US0 = US0_2
                        let v565 : (unit -> string) = closure64()
                        let v566 : (unit -> string) = closure65(v518, v519)
                        method3(v564, v565, v566)
                        let v567 : bool = true
                        let mutable _v567 : unit option = None 
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v568 : string = method54(v519)
                        let v569 : string = "std::fs::copy(&*$0, &*v568)"
                        let v570 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v518 v569
                        let v571 : string = "$0.unwrap()"
                        let v572 : uint64 = Fable.Core.RustInterop.emitRustExpr v570 v571
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
                        System.IO.File.Copy (v518, v519, true)
                        () 
                        #endif
                        |> fun x -> _v567 <- Some x
                        _v567.Value
                        false
                    else
                        true
                else
                    true
            let v579 : UH3 =
                if v574 then
                    let v575 : (string -> (string -> US19)) = closure60(v4, v3)
                    let v576 : UH3 = UH3_0
                    UH3_1(v517, v265, v575, v576)
                else
                    UH3_0
            let v580 : string = "pdf"
            let struct (v581 : string, v582 : string) = method52(v580, v265, v4)
            let v583 : bool = true
            let mutable _v583 : bool option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v584 : string = "&*$0"
            let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v582 v584
            let v586 : string = "String::from($0)"
            let v587 : std_string_String = Fable.Core.RustInterop.emitRustExpr v585 v586
            let v588 : string = "std::path::PathBuf::from($0)"
            let v589 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v587 v588
            let v590 : string = "$0.exists()"
            let v591 : bool = Fable.Core.RustInterop.emitRustExpr v589 v590
            let v594 : bool =
                if v591 then
                    let v592 : string = "$0.is_file()"
                    let v593 : bool = Fable.Core.RustInterop.emitRustExpr v589 v592
                    v593
                else
                    false
            v594 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v595 : bool = null |> unbox<bool>
            v595 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v596 : bool = null |> unbox<bool>
            v596 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v597 : IFsExistsSync = Fable.Core.JsInterop.importAll v534
            let v598 : string = "$0.existsSync($1)"
            let v599 : bool = Fable.Core.JsInterop.emitJsExpr struct (v597, v582) v598
            v599 
            #endif
#if FABLE_COMPILER_PYTHON
            let v600 : bool = null |> unbox<bool>
            v600 
            #endif
#else
            let v601 : (string -> bool) = System.IO.File.Exists
            let v602 : bool = v601 v582
            v602 
            #endif
            |> fun x -> _v583 <- Some x
            let v603 : bool = _v583.Value
            let v604 : bool = v603 = false
            let v636 : bool =
                if v604 then
                    let v605 : bool = true
                    let mutable _v605 : bool option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v606 : string = "&*$0"
                    let v607 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v581 v606
                    let v608 : string = "String::from($0)"
                    let v609 : std_string_String = Fable.Core.RustInterop.emitRustExpr v607 v608
                    let v610 : string = "std::path::PathBuf::from($0)"
                    let v611 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v609 v610
                    let v612 : string = "$0.exists()"
                    let v613 : bool = Fable.Core.RustInterop.emitRustExpr v611 v612
                    let v616 : bool =
                        if v613 then
                            let v614 : string = "$0.is_file()"
                            let v615 : bool = Fable.Core.RustInterop.emitRustExpr v611 v614
                            v615
                        else
                            false
                    v616 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v617 : bool = null |> unbox<bool>
                    v617 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v618 : bool = null |> unbox<bool>
                    v618 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v619 : IFsExistsSync = Fable.Core.JsInterop.importAll v534
                    let v620 : string = "$0.existsSync($1)"
                    let v621 : bool = Fable.Core.JsInterop.emitJsExpr struct (v619, v581) v620
                    v621 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v622 : bool = null |> unbox<bool>
                    v622 
                    #endif
#else
                    let v623 : (string -> bool) = System.IO.File.Exists
                    let v624 : bool = v623 v581
                    v624 
                    #endif
                    |> fun x -> _v605 <- Some x
                    let v625 : bool = _v605.Value
                    if v625 then
                        let v626 : US0 = US0_2
                        let v627 : (unit -> string) = closure64()
                        let v628 : (unit -> string) = closure65(v581, v582)
                        method3(v626, v627, v628)
                        let v629 : bool = true
                        let mutable _v629 : unit option = None 
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v630 : string = method54(v582)
                        let v631 : string = "std::fs::copy(&*$0, &*v630)"
                        let v632 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v581 v631
                        let v633 : string = "$0.unwrap()"
                        let v634 : uint64 = Fable.Core.RustInterop.emitRustExpr v632 v633
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
                        System.IO.File.Copy (v581, v582, true)
                        () 
                        #endif
                        |> fun x -> _v629 <- Some x
                        _v629.Value
                        false
                    else
                        true
                else
                    true
            let v639 : UH3 =
                if v636 then
                    let v637 : (string -> (string -> US19)) = closure60(v4, v3)
                    UH3_1(v580, v265, v637, v579)
                else
                    v579
            let v640 : string = "html"
            let struct (v641 : string, v642 : string) = method52(v640, v265, v4)
            let v643 : bool = true
            let mutable _v643 : bool option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v644 : string = "&*$0"
            let v645 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v642 v644
            let v646 : string = "String::from($0)"
            let v647 : std_string_String = Fable.Core.RustInterop.emitRustExpr v645 v646
            let v648 : string = "std::path::PathBuf::from($0)"
            let v649 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v647 v648
            let v650 : string = "$0.exists()"
            let v651 : bool = Fable.Core.RustInterop.emitRustExpr v649 v650
            let v654 : bool =
                if v651 then
                    let v652 : string = "$0.is_file()"
                    let v653 : bool = Fable.Core.RustInterop.emitRustExpr v649 v652
                    v653
                else
                    false
            v654 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v655 : bool = null |> unbox<bool>
            v655 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v656 : bool = null |> unbox<bool>
            v656 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v657 : IFsExistsSync = Fable.Core.JsInterop.importAll v534
            let v658 : string = "$0.existsSync($1)"
            let v659 : bool = Fable.Core.JsInterop.emitJsExpr struct (v657, v642) v658
            v659 
            #endif
#if FABLE_COMPILER_PYTHON
            let v660 : bool = null |> unbox<bool>
            v660 
            #endif
#else
            let v661 : (string -> bool) = System.IO.File.Exists
            let v662 : bool = v661 v642
            v662 
            #endif
            |> fun x -> _v643 <- Some x
            let v663 : bool = _v643.Value
            let v664 : bool = v663 = false
            let v696 : bool =
                if v664 then
                    let v665 : bool = true
                    let mutable _v665 : bool option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v666 : string = "&*$0"
                    let v667 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v641 v666
                    let v668 : string = "String::from($0)"
                    let v669 : std_string_String = Fable.Core.RustInterop.emitRustExpr v667 v668
                    let v670 : string = "std::path::PathBuf::from($0)"
                    let v671 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v669 v670
                    let v672 : string = "$0.exists()"
                    let v673 : bool = Fable.Core.RustInterop.emitRustExpr v671 v672
                    let v676 : bool =
                        if v673 then
                            let v674 : string = "$0.is_file()"
                            let v675 : bool = Fable.Core.RustInterop.emitRustExpr v671 v674
                            v675
                        else
                            false
                    v676 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v677 : bool = null |> unbox<bool>
                    v677 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v678 : bool = null |> unbox<bool>
                    v678 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v679 : IFsExistsSync = Fable.Core.JsInterop.importAll v534
                    let v680 : string = "$0.existsSync($1)"
                    let v681 : bool = Fable.Core.JsInterop.emitJsExpr struct (v679, v641) v680
                    v681 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v682 : bool = null |> unbox<bool>
                    v682 
                    #endif
#else
                    let v683 : (string -> bool) = System.IO.File.Exists
                    let v684 : bool = v683 v641
                    v684 
                    #endif
                    |> fun x -> _v665 <- Some x
                    let v685 : bool = _v665.Value
                    if v685 then
                        let v686 : US0 = US0_2
                        let v687 : (unit -> string) = closure64()
                        let v688 : (unit -> string) = closure65(v641, v642)
                        method3(v686, v687, v688)
                        let v689 : bool = true
                        let mutable _v689 : unit option = None 
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v690 : string = method54(v642)
                        let v691 : string = "std::fs::copy(&*$0, &*v690)"
                        let v692 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v641 v691
                        let v693 : string = "$0.unwrap()"
                        let v694 : uint64 = Fable.Core.RustInterop.emitRustExpr v692 v693
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
                        System.IO.File.Copy (v641, v642, true)
                        () 
                        #endif
                        |> fun x -> _v689 <- Some x
                        _v689.Value
                        false
                    else
                        true
                else
                    true
            let v699 : UH3 =
                if v696 then
                    let v697 : (string -> (string -> US19)) = closure60(v4, v3)
                    UH3_1(v640, v265, v697, v639)
                else
                    v639
            let struct (v700 : string, v701 : string) = method52(v517, v251, v4)
            let v702 : bool = true
            let mutable _v702 : bool option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v703 : string = "&*$0"
            let v704 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v701 v703
            let v705 : string = "String::from($0)"
            let v706 : std_string_String = Fable.Core.RustInterop.emitRustExpr v704 v705
            let v707 : string = "std::path::PathBuf::from($0)"
            let v708 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v706 v707
            let v709 : string = "$0.exists()"
            let v710 : bool = Fable.Core.RustInterop.emitRustExpr v708 v709
            let v713 : bool =
                if v710 then
                    let v711 : string = "$0.is_file()"
                    let v712 : bool = Fable.Core.RustInterop.emitRustExpr v708 v711
                    v712
                else
                    false
            v713 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v714 : bool = null |> unbox<bool>
            v714 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v715 : bool = null |> unbox<bool>
            v715 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v716 : IFsExistsSync = Fable.Core.JsInterop.importAll v534
            let v717 : string = "$0.existsSync($1)"
            let v718 : bool = Fable.Core.JsInterop.emitJsExpr struct (v716, v701) v717
            v718 
            #endif
#if FABLE_COMPILER_PYTHON
            let v719 : bool = null |> unbox<bool>
            v719 
            #endif
#else
            let v720 : (string -> bool) = System.IO.File.Exists
            let v721 : bool = v720 v701
            v721 
            #endif
            |> fun x -> _v702 <- Some x
            let v722 : bool = _v702.Value
            let v723 : bool = v722 = false
            let v755 : bool =
                if v723 then
                    let v724 : bool = true
                    let mutable _v724 : bool option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v725 : string = "&*$0"
                    let v726 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v700 v725
                    let v727 : string = "String::from($0)"
                    let v728 : std_string_String = Fable.Core.RustInterop.emitRustExpr v726 v727
                    let v729 : string = "std::path::PathBuf::from($0)"
                    let v730 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v728 v729
                    let v731 : string = "$0.exists()"
                    let v732 : bool = Fable.Core.RustInterop.emitRustExpr v730 v731
                    let v735 : bool =
                        if v732 then
                            let v733 : string = "$0.is_file()"
                            let v734 : bool = Fable.Core.RustInterop.emitRustExpr v730 v733
                            v734
                        else
                            false
                    v735 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v736 : bool = null |> unbox<bool>
                    v736 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v737 : bool = null |> unbox<bool>
                    v737 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v738 : IFsExistsSync = Fable.Core.JsInterop.importAll v534
                    let v739 : string = "$0.existsSync($1)"
                    let v740 : bool = Fable.Core.JsInterop.emitJsExpr struct (v738, v700) v739
                    v740 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v741 : bool = null |> unbox<bool>
                    v741 
                    #endif
#else
                    let v742 : (string -> bool) = System.IO.File.Exists
                    let v743 : bool = v742 v700
                    v743 
                    #endif
                    |> fun x -> _v724 <- Some x
                    let v744 : bool = _v724.Value
                    if v744 then
                        let v745 : US0 = US0_2
                        let v746 : (unit -> string) = closure64()
                        let v747 : (unit -> string) = closure65(v700, v701)
                        method3(v745, v746, v747)
                        let v748 : bool = true
                        let mutable _v748 : unit option = None 
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v749 : string = method54(v701)
                        let v750 : string = "std::fs::copy(&*$0, &*v749)"
                        let v751 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v700 v750
                        let v752 : string = "$0.unwrap()"
                        let v753 : uint64 = Fable.Core.RustInterop.emitRustExpr v751 v752
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
                        System.IO.File.Copy (v700, v701, true)
                        () 
                        #endif
                        |> fun x -> _v748 <- Some x
                        _v748.Value
                        false
                    else
                        true
                else
                    true
            let v758 : UH3 =
                if v755 then
                    let v756 : (string -> (string -> US19)) = closure60(v4, v3)
                    UH3_1(v517, v251, v756, v699)
                else
                    v699
            let struct (v759 : string, v760 : string) = method52(v580, v251, v4)
            let v761 : bool = true
            let mutable _v761 : bool option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v762 : string = "&*$0"
            let v763 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v760 v762
            let v764 : string = "String::from($0)"
            let v765 : std_string_String = Fable.Core.RustInterop.emitRustExpr v763 v764
            let v766 : string = "std::path::PathBuf::from($0)"
            let v767 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v765 v766
            let v768 : string = "$0.exists()"
            let v769 : bool = Fable.Core.RustInterop.emitRustExpr v767 v768
            let v772 : bool =
                if v769 then
                    let v770 : string = "$0.is_file()"
                    let v771 : bool = Fable.Core.RustInterop.emitRustExpr v767 v770
                    v771
                else
                    false
            v772 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v773 : bool = null |> unbox<bool>
            v773 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v774 : bool = null |> unbox<bool>
            v774 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v775 : IFsExistsSync = Fable.Core.JsInterop.importAll v534
            let v776 : string = "$0.existsSync($1)"
            let v777 : bool = Fable.Core.JsInterop.emitJsExpr struct (v775, v760) v776
            v777 
            #endif
#if FABLE_COMPILER_PYTHON
            let v778 : bool = null |> unbox<bool>
            v778 
            #endif
#else
            let v779 : (string -> bool) = System.IO.File.Exists
            let v780 : bool = v779 v760
            v780 
            #endif
            |> fun x -> _v761 <- Some x
            let v781 : bool = _v761.Value
            let v782 : bool = v781 = false
            let v814 : bool =
                if v782 then
                    let v783 : bool = true
                    let mutable _v783 : bool option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v784 : string = "&*$0"
                    let v785 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v759 v784
                    let v786 : string = "String::from($0)"
                    let v787 : std_string_String = Fable.Core.RustInterop.emitRustExpr v785 v786
                    let v788 : string = "std::path::PathBuf::from($0)"
                    let v789 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v787 v788
                    let v790 : string = "$0.exists()"
                    let v791 : bool = Fable.Core.RustInterop.emitRustExpr v789 v790
                    let v794 : bool =
                        if v791 then
                            let v792 : string = "$0.is_file()"
                            let v793 : bool = Fable.Core.RustInterop.emitRustExpr v789 v792
                            v793
                        else
                            false
                    v794 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v795 : bool = null |> unbox<bool>
                    v795 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v796 : bool = null |> unbox<bool>
                    v796 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v797 : IFsExistsSync = Fable.Core.JsInterop.importAll v534
                    let v798 : string = "$0.existsSync($1)"
                    let v799 : bool = Fable.Core.JsInterop.emitJsExpr struct (v797, v759) v798
                    v799 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v800 : bool = null |> unbox<bool>
                    v800 
                    #endif
#else
                    let v801 : (string -> bool) = System.IO.File.Exists
                    let v802 : bool = v801 v759
                    v802 
                    #endif
                    |> fun x -> _v783 <- Some x
                    let v803 : bool = _v783.Value
                    if v803 then
                        let v804 : US0 = US0_2
                        let v805 : (unit -> string) = closure64()
                        let v806 : (unit -> string) = closure65(v759, v760)
                        method3(v804, v805, v806)
                        let v807 : bool = true
                        let mutable _v807 : unit option = None 
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v808 : string = method54(v760)
                        let v809 : string = "std::fs::copy(&*$0, &*v808)"
                        let v810 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v759 v809
                        let v811 : string = "$0.unwrap()"
                        let v812 : uint64 = Fable.Core.RustInterop.emitRustExpr v810 v811
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
                        System.IO.File.Copy (v759, v760, true)
                        () 
                        #endif
                        |> fun x -> _v807 <- Some x
                        _v807.Value
                        false
                    else
                        true
                else
                    true
            let v817 : UH3 =
                if v814 then
                    let v815 : (string -> (string -> US19)) = closure60(v4, v3)
                    UH3_1(v580, v251, v815, v758)
                else
                    v758
            let struct (v818 : string, v819 : string) = method52(v640, v251, v4)
            let v820 : bool = true
            let mutable _v820 : bool option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v821 : string = "&*$0"
            let v822 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v819 v821
            let v823 : string = "String::from($0)"
            let v824 : std_string_String = Fable.Core.RustInterop.emitRustExpr v822 v823
            let v825 : string = "std::path::PathBuf::from($0)"
            let v826 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v824 v825
            let v827 : string = "$0.exists()"
            let v828 : bool = Fable.Core.RustInterop.emitRustExpr v826 v827
            let v831 : bool =
                if v828 then
                    let v829 : string = "$0.is_file()"
                    let v830 : bool = Fable.Core.RustInterop.emitRustExpr v826 v829
                    v830
                else
                    false
            v831 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v832 : bool = null |> unbox<bool>
            v832 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v833 : bool = null |> unbox<bool>
            v833 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v834 : IFsExistsSync = Fable.Core.JsInterop.importAll v534
            let v835 : string = "$0.existsSync($1)"
            let v836 : bool = Fable.Core.JsInterop.emitJsExpr struct (v834, v819) v835
            v836 
            #endif
#if FABLE_COMPILER_PYTHON
            let v837 : bool = null |> unbox<bool>
            v837 
            #endif
#else
            let v838 : (string -> bool) = System.IO.File.Exists
            let v839 : bool = v838 v819
            v839 
            #endif
            |> fun x -> _v820 <- Some x
            let v840 : bool = _v820.Value
            let v841 : bool = v840 = false
            let v873 : bool =
                if v841 then
                    let v842 : bool = true
                    let mutable _v842 : bool option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v843 : string = "&*$0"
                    let v844 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v818 v843
                    let v845 : string = "String::from($0)"
                    let v846 : std_string_String = Fable.Core.RustInterop.emitRustExpr v844 v845
                    let v847 : string = "std::path::PathBuf::from($0)"
                    let v848 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v846 v847
                    let v849 : string = "$0.exists()"
                    let v850 : bool = Fable.Core.RustInterop.emitRustExpr v848 v849
                    let v853 : bool =
                        if v850 then
                            let v851 : string = "$0.is_file()"
                            let v852 : bool = Fable.Core.RustInterop.emitRustExpr v848 v851
                            v852
                        else
                            false
                    v853 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v854 : bool = null |> unbox<bool>
                    v854 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v855 : bool = null |> unbox<bool>
                    v855 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v856 : IFsExistsSync = Fable.Core.JsInterop.importAll v534
                    let v857 : string = "$0.existsSync($1)"
                    let v858 : bool = Fable.Core.JsInterop.emitJsExpr struct (v856, v818) v857
                    v858 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v859 : bool = null |> unbox<bool>
                    v859 
                    #endif
#else
                    let v860 : (string -> bool) = System.IO.File.Exists
                    let v861 : bool = v860 v818
                    v861 
                    #endif
                    |> fun x -> _v842 <- Some x
                    let v862 : bool = _v842.Value
                    if v862 then
                        let v863 : US0 = US0_2
                        let v864 : (unit -> string) = closure64()
                        let v865 : (unit -> string) = closure65(v818, v819)
                        method3(v863, v864, v865)
                        let v866 : bool = true
                        let mutable _v866 : unit option = None 
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v867 : string = method54(v819)
                        let v868 : string = "std::fs::copy(&*$0, &*v867)"
                        let v869 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v818 v868
                        let v870 : string = "$0.unwrap()"
                        let v871 : uint64 = Fable.Core.RustInterop.emitRustExpr v869 v870
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
                        System.IO.File.Copy (v818, v819, true)
                        () 
                        #endif
                        |> fun x -> _v866 <- Some x
                        _v866.Value
                        false
                    else
                        true
                else
                    true
            let v876 : UH3 =
                if v873 then
                    let v874 : (string -> (string -> US19)) = closure60(v4, v3)
                    UH3_1(v640, v251, v874, v817)
                else
                    v817
            let struct (v877 : string, v878 : string) = method52(v263, v251, v4)
            let v879 : bool = true
            let mutable _v879 : bool option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v880 : string = "&*$0"
            let v881 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v878 v880
            let v882 : string = "String::from($0)"
            let v883 : std_string_String = Fable.Core.RustInterop.emitRustExpr v881 v882
            let v884 : string = "std::path::PathBuf::from($0)"
            let v885 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v883 v884
            let v886 : string = "$0.exists()"
            let v887 : bool = Fable.Core.RustInterop.emitRustExpr v885 v886
            let v890 : bool =
                if v887 then
                    let v888 : string = "$0.is_file()"
                    let v889 : bool = Fable.Core.RustInterop.emitRustExpr v885 v888
                    v889
                else
                    false
            v890 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v891 : bool = null |> unbox<bool>
            v891 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v892 : bool = null |> unbox<bool>
            v892 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v893 : IFsExistsSync = Fable.Core.JsInterop.importAll v534
            let v894 : string = "$0.existsSync($1)"
            let v895 : bool = Fable.Core.JsInterop.emitJsExpr struct (v893, v878) v894
            v895 
            #endif
#if FABLE_COMPILER_PYTHON
            let v896 : bool = null |> unbox<bool>
            v896 
            #endif
#else
            let v897 : (string -> bool) = System.IO.File.Exists
            let v898 : bool = v897 v878
            v898 
            #endif
            |> fun x -> _v879 <- Some x
            let v899 : bool = _v879.Value
            let v900 : bool = v899 = false
            let v932 : bool =
                if v900 then
                    let v901 : bool = true
                    let mutable _v901 : bool option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v902 : string = "&*$0"
                    let v903 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v877 v902
                    let v904 : string = "String::from($0)"
                    let v905 : std_string_String = Fable.Core.RustInterop.emitRustExpr v903 v904
                    let v906 : string = "std::path::PathBuf::from($0)"
                    let v907 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v905 v906
                    let v908 : string = "$0.exists()"
                    let v909 : bool = Fable.Core.RustInterop.emitRustExpr v907 v908
                    let v912 : bool =
                        if v909 then
                            let v910 : string = "$0.is_file()"
                            let v911 : bool = Fable.Core.RustInterop.emitRustExpr v907 v910
                            v911
                        else
                            false
                    v912 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v913 : bool = null |> unbox<bool>
                    v913 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v914 : bool = null |> unbox<bool>
                    v914 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v915 : IFsExistsSync = Fable.Core.JsInterop.importAll v534
                    let v916 : string = "$0.existsSync($1)"
                    let v917 : bool = Fable.Core.JsInterop.emitJsExpr struct (v915, v877) v916
                    v917 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v918 : bool = null |> unbox<bool>
                    v918 
                    #endif
#else
                    let v919 : (string -> bool) = System.IO.File.Exists
                    let v920 : bool = v919 v877
                    v920 
                    #endif
                    |> fun x -> _v901 <- Some x
                    let v921 : bool = _v901.Value
                    if v921 then
                        let v922 : US0 = US0_2
                        let v923 : (unit -> string) = closure64()
                        let v924 : (unit -> string) = closure65(v877, v878)
                        method3(v922, v923, v924)
                        let v925 : bool = true
                        let mutable _v925 : unit option = None 
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v926 : string = method54(v878)
                        let v927 : string = "std::fs::copy(&*$0, &*v926)"
                        let v928 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v877 v927
                        let v929 : string = "$0.unwrap()"
                        let v930 : uint64 = Fable.Core.RustInterop.emitRustExpr v928 v929
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
                        System.IO.File.Copy (v877, v878, true)
                        () 
                        #endif
                        |> fun x -> _v925 <- Some x
                        _v925.Value
                        false
                    else
                        true
                else
                    true
            let v937 : UH3 =
                if v932 then
                    let v933 : (string -> (string -> US19)) = closure53(v4, v3, v1, v0)
                    let v934 : UH3 = UH3_0
                    UH3_1(v263, v251, v933, v934)
                else
                    UH3_0
            let v938 : UH2 = UH2_0
            let v939 : UH2 = UH2_1(v876, v938)
            UH2_1(v937, v939)
    let v942 : UH3 list = []
    let v943 : UH3 list = method62(v941, v942)
    let v944 : (UH3 list -> (UH3 [])) = List.toArray
    let v945 : (UH3 []) = v944 v943
    let v946 : string = "$0.to_vec()"
    let v947 : Vec<UH3> = Fable.Core.RustInterop.emitRustExpr v945 v946
    let v948 : (Result<string, (string * string)> option []) = [||]
    let v949 : string = "$0.to_vec()"
    let v950 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v948 v949
    let v951 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v952 : (UH3 []) = Fable.Core.RustInterop.emitRustExpr v947 v951
    let v953 : int32 = v952.Length
    let v954 : Mut8 = {l0 = 0; l1 = v950} : Mut8
    while method63(v953, v954) do
        let v956 : int32 = v954.l0
        let v957 : Vec<Result<string, (string * string)> option> = v954.l1
        let v958 : UH3 = v952.[int v956]
        let v959 : struct (string * string * (string -> (string -> US19))) list = []
        let v960 : struct (string * string * (string -> (string -> US19))) list = method64(v958, v959)
        let v961 : (struct (string * string * (string -> (string -> US19))) list -> (struct (string * string * (string -> (string -> US19))) [])) = List.toArray
        let v962 : (struct (string * string * (string -> (string -> US19))) []) = v961 v960
        let v963 : string = "$0.to_vec()"
        let v964 : Vec<struct (string * string * (string -> (string -> US19)))> = Fable.Core.RustInterop.emitRustExpr v962 v963
        let v965 : string = "rayon::iter::IntoParallelIterator::into_par_iter(v964)"
        let v966 : rayon_vec_IntoIter<struct (string * string * (string -> (string -> US19)))> = Fable.Core.RustInterop.emitRustExpr () v965
        let v967 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
        let v968 : (struct (string * string * (string -> (string -> US19))) -> Result<string, (string * string)> option) = closure66()
        let v969 : rayon_iter_Map<rayon_vec_IntoIter<struct (string * string * (string -> (string -> US19)))>> = Fable.Core.RustInterop.emitRustExpr struct (v966, v968) v967
        let v970 : string = "rayon::iter::ParallelIterator::collect($0)"
        let v971 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v969 v970
        let v972 : Vec<Result<string, (string * string)> option> = method65(v971)
        let v973 : Vec<Result<string, (string * string)> option> = method66(v957)
        let v974 : string = "true; let mut v973 = v973"
        let v975 : bool = Fable.Core.RustInterop.emitRustExpr () v974
        let v976 : string = "true; v973.extend(v972)"
        let v977 : bool = Fable.Core.RustInterop.emitRustExpr () v976
        let v978 : string = "v973"
        let v979 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr () v978
        let v980 : int32 = v956 + 1
        v954.l0 <- v980
        v954.l1 <- v979
        ()
    let v981 : Vec<Result<string, (string * string)> option> = v954.l1
    let v982 : (string * Vec<Result<string, (string * string)> option>) = v238, v981
    let v983 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v982
    v983
and closure67 () () : string =
    let v0 : string = "documents.run"
    v0
and closure68 (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) () : string =
    let v1 : string = "$0.len()"
    let v2 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"result_len: {v2} / {v3 ()}"
    v4
and method67 (v0 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>) : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> =
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
    let v542 : (async_walkdir_DirEntry -> std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>) = closure11()
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
    let v557 : US0 = US0_1
    let v558 : (unit -> string) = closure67()
    let v559 : (unit -> string) = closure68(v556)
    method3(v557, v558, v559)
    let v560 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Ok v556
    let v561 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = method67(v560)
    let v562 : string = "v561 }}}})"
    Fable.Core.RustInterop.emitRustExpr () v562
    let v563 : string = "{{{ //"
    Fable.Core.RustInterop.emitRustExpr () v563
    let v564 : string = "__result"
    let v565 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v564
    v565
and closure1 () (v0 : (string [])) : int32 =
    let v1 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure2()
    if State.trace_state.IsNone then State.trace_state <- v1 () |> Some
    let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : int64 option, v6 : Mut3) = State.trace_state.Value
    let v7 : US0 = US0_2
    v4.l0 <- v7
    let v8 : US0 = US0_2
    let v9 : (unit -> string) = closure4()
    let v10 : (unit -> string) = closure5(v0)
    method3(v8, v9, v10)
    let v11 : clap_Command = method0()
    let v12 : string = "clap::Command::get_matches($0)"
    let v13 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = method6()
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "clap::ArgMatches::get_one(&v13, v16).cloned()"
    let v18 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : US3 option = None
    let _v19 = ref v19 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v20 : std_string_String = x
    let v21 : US3 = US3_0(v20)
    v21 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v19.Value <- x
    let v22 : US3 option = _v19.Value 
    let v23 : US3 = US3_1
    let v24 : US3 = v22 |> Option.defaultValue v23 
    let v28 : std_string_String =
        match v24 with
        | US3_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US3_0(v25) -> (* Some *)
            v25
    let v29 : string = "fable_library_rust::String_::fromString($0)"
    let v30 : string = Fable.Core.RustInterop.emitRustExpr v28 v29
    let v31 : string = method7()
    let v32 : string = "&*$0"
    let v33 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v31 v32
    let v34 : string = "clap::ArgMatches::get_one(&v13, v33).cloned()"
    let v35 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v34
    let v36 : US3 option = None
    let _v36 = ref v36 
    match v35 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v37 : std_string_String = x
    let v38 : US3 = US3_0(v37)
    v38 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v36.Value <- x
    let v39 : US3 option = _v36.Value 
    let v40 : US3 = US3_1
    let v41 : US3 = v39 |> Option.defaultValue v40 
    let v45 : std_string_String =
        match v41 with
        | US3_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US3_0(v42) -> (* Some *)
            v42
    let v46 : string = "fable_library_rust::String_::fromString($0)"
    let v47 : string = Fable.Core.RustInterop.emitRustExpr v45 v46
    let v48 : string = method8()
    let v49 : string = "&*$0"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v48 v49
    let v51 : string = "clap::ArgMatches::get_one(&v13, v50).cloned()"
    let v52 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : US3 option = None
    let _v53 = ref v53 
    match v52 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v54 : std_string_String = x
    let v55 : US3 = US3_0(v54)
    v55 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v53.Value <- x
    let v56 : US3 option = _v53.Value 
    let v57 : US3 = US3_1
    let v58 : US3 = v56 |> Option.defaultValue v57 
    let v62 : std_string_String =
        match v58 with
        | US3_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US3_0(v59) -> (* Some *)
            v59
    let v63 : string = "fable_library_rust::String_::fromString($0)"
    let v64 : string = Fable.Core.RustInterop.emitRustExpr v62 v63
    let v65 : string = method9()
    let v66 : string = "&*$0"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v65 v66
    let v68 : string = "clap::ArgMatches::get_one(&v13, v67).cloned()"
    let v69 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v68
    let v70 : US3 option = None
    let _v70 = ref v70 
    match v69 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v71 : std_string_String = x
    let v72 : US3 = US3_0(v71)
    v72 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v70.Value <- x
    let v73 : US3 option = _v70.Value 
    let v74 : US3 = US3_1
    let v75 : US3 = v73 |> Option.defaultValue v74 
    let v79 : std_string_String =
        match v75 with
        | US3_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US3_0(v76) -> (* Some *)
            v76
    let v80 : string = "fable_library_rust::String_::fromString($0)"
    let v81 : string = Fable.Core.RustInterop.emitRustExpr v79 v80
    let v82 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = method10(v81, v64, v47, v30)
    let v83 : string = "futures_lite::future::block_on($0)"
    let v84 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr v82 v83
    let v85 : string = "$0.unwrap()"
    let v86 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = Fable.Core.RustInterop.emitRustExpr v84 v85
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
