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
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("[$0; $1]")>]
#endif
type Slice'<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("core::iter::Fuse<$0>")>]
#endif
type core_iter_Fuse<'T> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("clap::Arg")>]
#endif
type clap_Arg = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::Command")>]
#endif
type clap_Command = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::ArgMatches")>]
#endif
type clap_ArgMatches = class end
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
    | US20_0 of f0_0 : string
    | US20_1 of f1_0 : string
and [<Struct>] US21 =
    | US21_0 of f0_0 : int32 * f0_1 : string
    | US21_1 of f1_0 : int32 * f1_1 : string
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
    let v7 : string option = None
    let v8 : bool = true in let mutable _v7 = v7
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : string = "env!(\"CARGO_PKG_NAME\").into()"
    let v10 : string = Fable.Core.RustInterop.emitRustExpr () v9
    v10
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v11 : string = null |> unbox<string>
    v11
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = null |> unbox<string>
    v12
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : string = null |> unbox<string>
    v13
#endif
    
#if FABLE_COMPILER_PYTHON
    let v14 : string = null |> unbox<string>
    v14
#endif
    
#else
    let v15 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v15
#endif
    |> fun x -> _v7 <- Some x
    let v16 : string = _v7.Value
    let v18 : bool = v16 = "Microsoft.DotNet.Interactive.App"
    let v19 : bool = v18 <> true
    let v25 : US1 =
        if v19 then
            let v20 : System.DateTime = System.DateTime.Now
            let v21 : (System.DateTime -> int64) = _.Ticks
            let v22 : int64 = v21 v20
            US1_0(v22)
        else
            US1_1
    let v30 : int64 option =
        match v25 with
        | US1_1 -> (* None *)
            let v28 : int64 option = None
            v28
        | US1_0(v26) -> (* Some *)
            let v27 : int64 option = Some v26 
            v27
    let v31 : int64 option = method1(v30)
    v31 
    #else
    let v32 : int64 option = None
    let v33 : int64 option = method2(v32)
    v33 
    #endif
    |> fun x -> _v6 <- Some x
    let v34 : int64 option = _v6.Value
    struct (v1, v0, v3, v34, v5)
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
and closure8 () (v0 : int64) : US2 =
    US2_0(v0)
and method4 () : (int64 -> US2) =
    closure8()
and method5 () : string =
    let v0 : string = ""
    v0
and closure7 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure2()
    if State.trace_state.IsNone then State.trace_state <- v3 () |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut2, v7 : int64 option, v8 : Mut3) = State.trace_state.Value
    let v9 : string option = None
    let v10 : bool = true in let mutable _v9 = v9
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : (int64 -> US2) = method4()
    let v12 : US2 = US2_1
    let v13 : US2 = v7 |> Option.map v11 |> Option.defaultValue v12 
    let v31 : System.DateTime =
        match v13 with
        | US2_1 -> (* None *)
            let v29 : System.DateTime = System.DateTime.Now
            v29
        | US2_0(v14) -> (* Some *)
            let v15 : System.DateTime = System.DateTime.Now
            let v16 : (System.DateTime -> int64) = _.Ticks
            let v17 : int64 = v16 v15
            let v18 : int64 = v17 - v14
            let v19 : System.TimeSpan = System.TimeSpan v18 
            let v20 : (System.TimeSpan -> int32) = _.Hours
            let v21 : int32 = v20 v19
            let v22 : (System.TimeSpan -> int32) = _.Minutes
            let v23 : int32 = v22 v19
            let v24 : (System.TimeSpan -> int32) = _.Seconds
            let v25 : int32 = v24 v19
            let v26 : (System.TimeSpan -> int32) = _.Milliseconds
            let v27 : int32 = v26 v19
            let v28 : System.DateTime = System.DateTime (1, 1, 1, v21, v23, v25, v27)
            v28
    let v32 : string = "hh:mm:ss"
    let v33 : string = v31.ToString v32 
    v33
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v34 : string = method5()
    v34
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v35 : string = method5()
    v35
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v36 : string = method5()
    v36
#endif
    
#if FABLE_COMPILER_PYTHON
    let v37 : string = method5()
    v37
#endif
    
#else
    let v38 : (int64 -> US2) = method4()
    let v39 : US2 = US2_1
    let v40 : US2 = v7 |> Option.map v38 |> Option.defaultValue v39 
    let v58 : System.DateTime =
        match v40 with
        | US2_1 -> (* None *)
            let v56 : System.DateTime = System.DateTime.Now
            v56
        | US2_0(v41) -> (* Some *)
            let v42 : System.DateTime = System.DateTime.Now
            let v43 : (System.DateTime -> int64) = _.Ticks
            let v44 : int64 = v43 v42
            let v45 : int64 = v44 - v41
            let v46 : System.TimeSpan = System.TimeSpan v45 
            let v47 : (System.TimeSpan -> int32) = _.Hours
            let v48 : int32 = v47 v46
            let v49 : (System.TimeSpan -> int32) = _.Minutes
            let v50 : int32 = v49 v46
            let v51 : (System.TimeSpan -> int32) = _.Seconds
            let v52 : int32 = v51 v46
            let v53 : (System.TimeSpan -> int32) = _.Milliseconds
            let v54 : int32 = v53 v46
            let v55 : System.DateTime = System.DateTime (1, 1, 1, v48, v50, v52, v54)
            v55
    let v59 : string = "HH:mm:ss"
    let v60 : string = v58.ToString v59 
    v60
#endif
    |> fun x -> _v9 <- Some x
    let v61 : string = _v9.Value
    let v62 : int64 = v4.l0
    let v72 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v67 : string = "Critical"
            v67
        | US0_1 -> (* Debug *)
            let v64 : string = "Debug"
            v64
        | US0_2 -> (* Info *)
            let v65 : string = "Info"
            v65
        | US0_0 -> (* Verbose *)
            let v63 : string = "Verbose"
            v63
        | US0_3 -> (* Warning *)
            let v66 : string = "Warning"
            v66
    let v73 : string = v72.ToLower ()
    let v74 : string = v73.PadLeft (7, ' ')
    let v75 : string option = None
    let v76 : bool = true in let mutable _v75 = v75
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v91 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v85 : string = "inline_colorization::color_bright_red"
            let v86 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v85
            v86
        | US0_1 -> (* Debug *)
            let v79 : string = "inline_colorization::color_bright_blue"
            let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v79
            v80
        | US0_2 -> (* Info *)
            let v81 : string = "inline_colorization::color_bright_green"
            let v82 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v81
            v82
        | US0_0 -> (* Verbose *)
            let v77 : string = "inline_colorization::color_bright_black"
            let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v77
            v78
        | US0_3 -> (* Warning *)
            let v83 : string = "inline_colorization::color_bright_yellow"
            let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v83
            v84
    let v92 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v93 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v74 v92
    let v94 : string = "inline_colorization::color_reset"
    let v95 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v94
    let v96 : string = "\"{v91}{v93}{v95}\""
    let v97 : string = @$"format!(" + v96 + ")"
    let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v97
    let v99 : string = "fable_library_rust::String_::fromString($0)"
    let v100 : string = Fable.Core.RustInterop.emitRustExpr v98 v99
    v100
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v115 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v109 : string = "inline_colorization::color_bright_red"
            let v110 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v109
            v110
        | US0_1 -> (* Debug *)
            let v103 : string = "inline_colorization::color_bright_blue"
            let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v103
            v104
        | US0_2 -> (* Info *)
            let v105 : string = "inline_colorization::color_bright_green"
            let v106 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v105
            v106
        | US0_0 -> (* Verbose *)
            let v101 : string = "inline_colorization::color_bright_black"
            let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v101
            v102
        | US0_3 -> (* Warning *)
            let v107 : string = "inline_colorization::color_bright_yellow"
            let v108 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v107
            v108
    let v116 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v74 v116
    let v118 : string = "inline_colorization::color_reset"
    let v119 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v118
    let v120 : string = "\"{v115}{v117}{v119}\""
    let v121 : string = @$"format!(" + v120 + ")"
    let v122 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v121
    let v123 : string = "fable_library_rust::String_::fromString($0)"
    let v124 : string = Fable.Core.RustInterop.emitRustExpr v122 v123
    v124
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v139 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v133 : string = "inline_colorization::color_bright_red"
            let v134 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v133
            v134
        | US0_1 -> (* Debug *)
            let v127 : string = "inline_colorization::color_bright_blue"
            let v128 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v127
            v128
        | US0_2 -> (* Info *)
            let v129 : string = "inline_colorization::color_bright_green"
            let v130 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v129
            v130
        | US0_0 -> (* Verbose *)
            let v125 : string = "inline_colorization::color_bright_black"
            let v126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v125
            v126
        | US0_3 -> (* Warning *)
            let v131 : string = "inline_colorization::color_bright_yellow"
            let v132 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v131
            v132
    let v140 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v74 v140
    let v142 : string = "inline_colorization::color_reset"
    let v143 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v142
    let v144 : string = "\"{v139}{v141}{v143}\""
    let v145 : string = @$"format!(" + v144 + ")"
    let v146 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v145
    let v147 : string = "fable_library_rust::String_::fromString($0)"
    let v148 : string = Fable.Core.RustInterop.emitRustExpr v146 v147
    v148
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    v74
#endif
    
#if FABLE_COMPILER_PYTHON
    v74
#endif
    
#else
    v74
#endif
    |> fun x -> _v75 <- Some x
    let v149 : string = _v75.Value
    let v150 : string = v1 ()
    let v151 : string = $"{v61} {v149} #{v62} %s{v150} / %s{v2 ()}"
    let v152 : (char []) = [||]
    let v153 : string = v151.TrimStart v152
    let v154 : (char []) = [|' '; '/'|]
    let v155 : string = v153.TrimEnd v154
    v155
and method6 (v0 : US0, v1 : (unit -> string)) : unit =
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
        let v23 : unit option = None
        let v24 : bool = true in let mutable _v23 = v23
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v25 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v22 v25
        ()
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v26 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v22 v26
        ()
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v27 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v22 v27
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
        let v28 : (string -> unit) = v7.l0
        v28 v22
and method3 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> string) = closure7(v0, v1, v2)
    method6(v0, v3)
and method7 () : string =
    let v0 : string = "source-dir"
    v0
and closure9 () (v0 : std_string_String) : US3 =
    US3_0(v0)
and method8 () : (std_string_String -> US3) =
    closure9()
and method9 () : string =
    let v0 : string = "dist-dir"
    v0
and method10 () : string =
    let v0 : string = "cache-dir"
    v0
and method11 () : string =
    let v0 : string = "hangul-spec"
    v0
and method14 (v0 : string) : string =
    v0
and method15 (v0 : string) : string =
    v0
and method16 (v0 : string) : string =
    v0
and method13 (v0 : string, v1 : string) : string =
    let v2 : string option = None
    let v3 : bool = true in let mutable _v2 = v2
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method14(v0)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "std::path::PathBuf::from($0)"
    let v10 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = method14(v1)
    let v12 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "String::from($0)"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "$0.join($1)"
    let v17 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v10, v15) v16
    let v18 : string = "$0.display()"
    let v19 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : std_string_String option = None
    let v21 : bool = true in let mutable _v20 = v20
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v22 : string = @$"format!(""{{}}"", $0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v22
    v23
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v24 : string = @$"format!(""{{}}"", $0)"
    let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v24
    v25
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : string = @$"format!(""{{}}"", $0)"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v26
    v27
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : std_string_String = null |> unbox<std_string_String>
    v28
#endif
    
#if FABLE_COMPILER_PYTHON
    let v29 : std_string_String = null |> unbox<std_string_String>
    v29
#endif
    
#else
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30
#endif
    |> fun x -> _v20 <- Some x
    let v31 : std_string_String = _v20.Value
    let v32 : string = "fable_library_rust::String_::fromString($0)"
    let v33 : string = Fable.Core.RustInterop.emitRustExpr v31 v32
    v33
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v34 : string = null |> unbox<string>
    v34
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v35 : string = null |> unbox<string>
    v35
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v36 : string = "path"
    let v37 : IPathJoin = Fable.Core.JsInterop.importAll v36
    let v38 : string = method15(v0)
    let v39 : string = method16(v1)
    let v40 : string = "v37.join(v38, v39)"
    let v41 : string = Fable.Core.JsInterop.emitJsExpr () v40
    v41
#endif
    
#if FABLE_COMPILER_PYTHON
    let v42 : string = null |> unbox<string>
    v42
#endif
    
#else
    let v43 : string = System.IO.Path.Combine (v0, v1)
    v43
#endif
    |> fun x -> _v2 <- Some x
    let v44 : string = _v2.Value
    v44
and closure10 () (v0 : string) : string option =
    let v1 : US4 option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method14(v0)
    let v4 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = "String::from($0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "std::path::PathBuf::from($0)"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "$0.parent().map(std::path::PathBuf::from)"
    let v11 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "$0?"
    let v13 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "$0.display()"
    let v15 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : std_string_String option = None
    let v17 : bool = true in let mutable _v16 = v16
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = @$"format!(""{{}}"", $0)"
    let v19 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v18
    v19
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = @$"format!(""{{}}"", $0)"
    let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v20
    v21
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = @$"format!(""{{}}"", $0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v22
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
    |> fun x -> _v16 <- Some x
    let v27 : std_string_String = _v16.Value
    let v28 : string = "fable_library_rust::String_::fromString($0)"
    let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : US4 = US4_0(v29)
    v30
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v31 : US4 = null |> unbox<US4>
    v31
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : US4 = null |> unbox<US4>
    v32
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : string = "path"
    let v34 : IPathDirname = Fable.Core.JsInterop.importAll v33
    let v35 : string = "v34.dirname($0)"
    let v36 : string = Fable.Core.JsInterop.emitJsExpr v0 v35
    let v37 : US4 = US4_0(v36)
    v37
#endif
    
#if FABLE_COMPILER_PYTHON
    let v38 : US4 = null |> unbox<US4>
    v38
#endif
    
#else
    let v39 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.GetParent
    let v40 : System.IO.DirectoryInfo = v39 v0
    let v41 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let v42 : bool = v40 = v41
    let v54 : US4 =
        if v42 then
            US4_1
        else
            let v44 : string option = None
            let v45 : bool = true in let mutable _v44 = v44
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v46 : string = null |> unbox<string>
            v46
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v47 : string = null |> unbox<string>
            v47
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v48 : string = null |> unbox<string>
            v48
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v49 : string = null |> unbox<string>
            v49
#endif
            
#if FABLE_COMPILER_PYTHON
            let v50 : string = null |> unbox<string>
            v50
#endif
            
#else
            let v51 : string = v40.FullName
            v51
#endif
            |> fun x -> _v44 <- Some x
            let v52 : string = _v44.Value
            US4_0(v52)
    v54
#endif
    |> fun x -> _v1 <- Some x
    let v55 : US4 = _v1.Value
    match v55 with
    | US4_1 -> (* None *)
        let v58 : string option = None
        v58
    | US4_0(v56) -> (* Some *)
        let v57 : string option = Some v56 
        v57
and method18 () : (string -> string option) =
    closure10()
and closure11 () (v0 : string) : US4 =
    US4_0(v0)
and method19 () : (string -> US4) =
    closure11()
and method20 (v0 : string, v1 : string, v2 : string) : string =
    let v3 : string = method13(v2, v0)
    let v4 : bool option = None
    let v5 : bool = true in let mutable _v4 = v4
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = method14(v3)
    let v7 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v8 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "String::from($0)"
    let v10 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "std::path::PathBuf::from($0)"
    let v12 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "$0.exists()"
    let v14 : bool = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v17 : bool =
        if v14 then
            let v15 : string = "$0.is_dir()"
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
    let v23 : bool = Fable.Core.JsInterop.emitJsExpr struct (v21, v3) v22
    v23
#endif
    
#if FABLE_COMPILER_PYTHON
    let v24 : bool = null |> unbox<bool>
    v24
#endif
    
#else
    let v25 : (string -> bool) = System.IO.Directory.Exists
    let v26 : bool = v25 v3
    v26
#endif
    |> fun x -> _v4 <- Some x
    let v27 : bool = _v4.Value
    if v27 then
        v2
    else
        let v28 : (string -> string option) = method18()
        let v29 : string option = v28 v2
        let v30 : (string -> US4) = method19()
        let v31 : US4 = US4_1
        let v32 : US4 = v29 |> Option.map v30 |> Option.defaultValue v31 
        match v32 with
        | US4_1 -> (* None *)
            let v35 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            failwith<string> v35
        | US4_0(v33) -> (* Some *)
            method20(v0, v1, v33)
and method17 (v0 : string, v1 : string) : string =
    let v2 : string = method13(v1, v0)
    let v3 : bool option = None
    let v4 : bool = true in let mutable _v3 = v3
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = method14(v2)
    let v6 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v7 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "String::from($0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "std::path::PathBuf::from($0)"
    let v11 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "$0.exists()"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v16 : bool =
        if v13 then
            let v14 : string = "$0.is_dir()"
            let v15 : bool = Fable.Core.RustInterop.emitRustExpr v11 v14
            v15
        else
            false
    v16
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v17 : bool = null |> unbox<bool>
    v17
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v18 : bool = null |> unbox<bool>
    v18
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : string = "fs"
    let v20 : IFsExistsSync = Fable.Core.JsInterop.importAll v19
    let v21 : string = "$0.existsSync($1)"
    let v22 : bool = Fable.Core.JsInterop.emitJsExpr struct (v20, v2) v21
    v22
#endif
    
#if FABLE_COMPILER_PYTHON
    let v23 : bool = null |> unbox<bool>
    v23
#endif
    
#else
    let v24 : (string -> bool) = System.IO.Directory.Exists
    let v25 : bool = v24 v2
    v25
#endif
    |> fun x -> _v3 <- Some x
    let v26 : bool = _v3.Value
    if v26 then
        v1
    else
        let v27 : (string -> string option) = method18()
        let v28 : string option = v27 v1
        let v29 : (string -> US4) = method19()
        let v30 : US4 = US4_1
        let v31 : US4 = v28 |> Option.map v29 |> Option.defaultValue v30 
        match v31 with
        | US4_1 -> (* None *)
            let v34 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            failwith<string> v34
        | US4_0(v32) -> (* Some *)
            method20(v0, v1, v32)
and method21 (v0 : string) : string =
    v0
and method22 () : string =
    let v0 : string = "^\\\\\\\\\\?\\\\"
    v0
and method23 (v0 : string) : string =
    v0
and method24 () : string =
    let v0 : string = ""
    v0
and method25 (v0 : int32, v1 : Mut4) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method26 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method27 (v0 : string) : string =
    v0
and method28 (v0 : string) : string =
    v0
and closure12 () () : string =
    let v0 : string = "documents.run"
    v0
and closure13 (v0 : string, v1 : string, v2 : string, v3 : string) () : string =
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"source_dir: {v1} / dist_dir: {v2} / cache_dir: {v3} / hangul_spec: %A{v0} / {v4 ()}"
    v5
and method32 (v0 : async_walkdir_DirEntry) : async_walkdir_DirEntry =
    v0
and closure15 () (v0 : std_io_Error) : std_string_String =
    let v1 : std_string_String option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = @$"format!(""{{}}"", $0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    v4
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = @$"format!(""{{}}"", $0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v5
    v6
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = @$"format!(""{{}}"", $0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v7
    v8
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9
#endif
    
#if FABLE_COMPILER_PYTHON
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10
#endif
    
#else
    let v11 : std_string_String = null |> unbox<std_string_String>
    v11
#endif
    |> fun x -> _v1 <- Some x
    let v12 : std_string_String = _v1.Value
    v12
and method33 () : (std_io_Error -> std_string_String) =
    closure15()
and closure16 () (v0 : std_fs_FileType) : US6 =
    US6_0(v0)
and closure17 () (v0 : std_string_String) : US6 =
    US6_1(v0)
and method34 (v0 : std_fs_FileType) : std_fs_FileType =
    v0
and method35 (v0 : US5) : US5 =
    v0
and method31 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<Send<Dyn<std_future_Future<US5>>>>> =
    let v1 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : async_walkdir_DirEntry = method32(v0)
    let v3 : string = "Box::pin(async_walkdir::DirEntry::file_type(&v2))"
    let v4 : std_pin_Pin<Box<Send<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>>>> = Fable.Core.RustInterop.emitRustExpr () v3
    let v5 : string = "v4.await"
    let v6 : Result<std_fs_FileType, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v5
    let v7 : (std_io_Error -> std_string_String) = method33()
    let v8 : string = "$0.map_err(|x| $1(x))"
    let v9 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6, v7) v8
    let v10 : (std_fs_FileType -> US6) = closure16()
    let v11 : (std_string_String -> US6) = closure17()
    let v12 : US6 = match v9 with Ok x -> v10 x | Error x -> v11 x
    let v73 : US5 =
        match v12 with
        | US6_0(v13) -> (* Ok *)
            let v14 : std_fs_FileType = method34(v13)
            let v15 : string = "std::fs::FileType::is_dir(&v14)"
            let v16 : bool = Fable.Core.RustInterop.emitRustExpr () v15
            if v16 then
                US5_0
            else
                let v18 : string = "async_walkdir::DirEntry::path(&$0)"
                let v19 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v0 v18
                let v20 : string = "$0.display()"
                let v21 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v19 v20
                let v22 : std_string_String option = None
                let v23 : bool = true in let mutable _v22 = v22
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v24 : string = @$"format!(""{{}}"", $0)"
                let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v24
                v25
#endif
                
#if FABLE_COMPILER_RUST && WASM
                let v26 : string = @$"format!(""{{}}"", $0)"
                let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v26
                v27
#endif
                
#if FABLE_COMPILER_RUST && CONTRACT
                let v28 : string = @$"format!(""{{}}"", $0)"
                let v29 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v28
                v29
#endif
                
#if FABLE_COMPILER_TYPESCRIPT
                let v30 : std_string_String = null |> unbox<std_string_String>
                v30
#endif
                
#if FABLE_COMPILER_PYTHON
                let v31 : std_string_String = null |> unbox<std_string_String>
                v31
#endif
                
#else
                let v32 : std_string_String = null |> unbox<std_string_String>
                v32
#endif
                |> fun x -> _v22 <- Some x
                let v33 : std_string_String = _v22.Value
                let v34 : string = "fable_library_rust::String_::fromString($0)"
                let v35 : string = Fable.Core.RustInterop.emitRustExpr v33 v34
                let v36 : string = ".md"
                let v37 : bool = v35.EndsWith v36
                let v38 : bool = v37 = false
                let v41 : bool =
                    if v38 then
                        true
                    else
                        let v39 : string = ".hangul.md"
                        let v40 : bool = v35.EndsWith v39
                        v40
                if v41 then
                    US5_0
                else
                    US5_2
        | _ ->
            let v46 : string = "async_walkdir::DirEntry::path(&$0)"
            let v47 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v0 v46
            let v48 : string = "$0.display()"
            let v49 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v47 v48
            let v50 : std_string_String option = None
            let v51 : bool = true in let mutable _v50 = v50
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v52 : string = @$"format!(""{{}}"", $0)"
            let v53 : std_string_String = Fable.Core.RustInterop.emitRustExpr v49 v52
            v53
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v54 : string = @$"format!(""{{}}"", $0)"
            let v55 : std_string_String = Fable.Core.RustInterop.emitRustExpr v49 v54
            v55
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v56 : string = @$"format!(""{{}}"", $0)"
            let v57 : std_string_String = Fable.Core.RustInterop.emitRustExpr v49 v56
            v57
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v58 : std_string_String = null |> unbox<std_string_String>
            v58
#endif
            
#if FABLE_COMPILER_PYTHON
            let v59 : std_string_String = null |> unbox<std_string_String>
            v59
#endif
            
#else
            let v60 : std_string_String = null |> unbox<std_string_String>
            v60
#endif
            |> fun x -> _v50 <- Some x
            let v61 : std_string_String = _v50.Value
            let v62 : string = "fable_library_rust::String_::fromString($0)"
            let v63 : string = Fable.Core.RustInterop.emitRustExpr v61 v62
            let v64 : string = ".md"
            let v65 : bool = v63.EndsWith v64
            let v66 : bool = v65 = false
            let v69 : bool =
                if v66 then
                    true
                else
                    let v67 : string = ".hangul.md"
                    let v68 : bool = v63.EndsWith v67
                    v68
            if v69 then
                US5_0
            else
                US5_2
    let v74 : US5 = method35(v73)
    let v75 : string = "v74 }})"
    Fable.Core.RustInterop.emitRustExpr () v75
    let v76 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v76
    let v77 : string = "__result"
    let v78 : std_pin_Pin<Box<Send<Dyn<std_future_Future<US5>>>>> = Fable.Core.RustInterop.emitRustExpr () v77
    v78
and method36 (v0 : async_walkdir_Filtering) : async_walkdir_Filtering =
    v0
and method30 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>> =
    let v1 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : std_pin_Pin<Box<Send<Dyn<std_future_Future<US5>>>>> = method31(v0)
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
    let v14 : async_walkdir_Filtering = method36(v13)
    let v15 : string = "v14 }})"
    Fable.Core.RustInterop.emitRustExpr () v15
    let v16 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v16
    let v17 : string = "__result"
    let v18 : std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>> = Fable.Core.RustInterop.emitRustExpr () v17
    v18
and closure14 () (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>> =
    method30(v0)
and closure19 () (v0 : async_walkdir_DirEntry) : US7 =
    US7_0(v0)
and closure20 () (v0 : std_string_String) : US7 =
    US7_1(v0)
and closure21 () () : string =
    let v0 : string = "documents.run / stream_filter_map"
    v0
and closure22 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and closure18 () (v0 : Result<async_walkdir_DirEntry, std_io_Error>) : string option =
    let v1 : (std_io_Error -> std_string_String) = method33()
    let v2 : string = "$0.map_err(|x| $1(x))"
    let v3 : Result<async_walkdir_DirEntry, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v2
    let v4 : (async_walkdir_DirEntry -> US7) = closure19()
    let v5 : (std_string_String -> US7) = closure20()
    let v6 : US7 = match v3 with Ok x -> v4 x | Error x -> v5 x
    let v33 : US4 =
        match v6 with
        | US7_1(v27) -> (* Error *)
            let v28 : US0 = US0_4
            let v29 : (unit -> string) = closure21()
            let v30 : (unit -> string) = closure22(v27)
            method3(v28, v29, v30)
            US4_1
        | US7_0(v7) -> (* Ok *)
            let v8 : string = "async_walkdir::DirEntry::path(&$0)"
            let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8
            let v10 : string = "$0.display()"
            let v11 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v9 v10
            let v12 : std_string_String option = None
            let v13 : bool = true in let mutable _v12 = v12
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v14 : string = @$"format!(""{{}}"", $0)"
            let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v14
            v15
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v16 : string = @$"format!(""{{}}"", $0)"
            let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v16
            v17
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v18 : string = @$"format!(""{{}}"", $0)"
            let v19 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v18
            v19
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v20 : std_string_String = null |> unbox<std_string_String>
            v20
#endif
            
#if FABLE_COMPILER_PYTHON
            let v21 : std_string_String = null |> unbox<std_string_String>
            v21
#endif
            
#else
            let v22 : std_string_String = null |> unbox<std_string_String>
            v22
#endif
            |> fun x -> _v12 <- Some x
            let v23 : std_string_String = _v12.Value
            let v24 : string = "fable_library_rust::String_::fromString($0)"
            let v25 : string = Fable.Core.RustInterop.emitRustExpr v23 v24
            US4_0(v25)
    match v33 with
    | US4_1 -> (* None *)
        let v36 : string option = None
        v36
    | US4_0(v34) -> (* Some *)
        let v35 : string option = Some v34 
        v35
and method37 () : (Result<async_walkdir_DirEntry, std_io_Error> -> string option) =
    closure18()
and closure23 () () : string =
    let v0 : string = "documents.run"
    v0
and closure24 (v0 : Vec<string>) () : string =
    let v1 : string = "$0.len()"
    let v2 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"files_len: {v2} / {v3 ()}"
    v4
and method38 (v0 : string) : string =
    let v1 : string option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method21(v0)
    let v4 : string = method14(v3)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "std::path::PathBuf::from($0)"
    let v10 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "$0.exists()"
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : bool = v12 = false
    let v163 : string =
        if v13 then
            let v14 : string option = None
            let v15 : bool = true in let mutable _v14 = v14
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16 : string = "std::env::current_dir()"
            let v17 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v16
            let v18 : string = "$0.unwrap()"
            let v19 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v17 v18
            let v20 : string = "$0.display()"
            let v21 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v19 v20
            let v22 : std_string_String option = None
            let v23 : bool = true in let mutable _v22 = v22
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v24 : string = @$"format!(""{{}}"", $0)"
            let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v24
            v25
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v26 : string = @$"format!(""{{}}"", $0)"
            let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v26
            v27
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v28 : string = @$"format!(""{{}}"", $0)"
            let v29 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v28
            v29
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v30 : std_string_String = null |> unbox<std_string_String>
            v30
#endif
            
#if FABLE_COMPILER_PYTHON
            let v31 : std_string_String = null |> unbox<std_string_String>
            v31
#endif
            
#else
            let v32 : std_string_String = null |> unbox<std_string_String>
            v32
#endif
            |> fun x -> _v22 <- Some x
            let v33 : std_string_String = _v22.Value
            let v34 : string = "fable_library_rust::String_::fromString($0)"
            let v35 : string = Fable.Core.RustInterop.emitRustExpr v33 v34
            v35
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v36 : string = null |> unbox<string>
            v36
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v37 : string = null |> unbox<string>
            v37
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v38 : string = null |> unbox<string>
            v38
#endif
            
#if FABLE_COMPILER_PYTHON
            let v39 : string = null |> unbox<string>
            v39
#endif
            
#else
            let v40 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v41 : string = v40 ()
            v41
#endif
            |> fun x -> _v14 <- Some x
            let v42 : string = _v14.Value
            let v43 : string = method13(v42, v3)
            let v44 : string option = None
            let v45 : bool = true in let mutable _v44 = v44
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v46 : string = method22()
            let v47 : string = method23(v43)
            let v48 : string = method24()
            let v49 : string = $"regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v50 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v46, v47, v48) v49
            let v51 : string = "String::from($0)"
            let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr v50 v51
            let v53 : string = "fable_library_rust::String_::fromString($0)"
            let v54 : string = Fable.Core.RustInterop.emitRustExpr v52 v53
            v54
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v55 : string = null |> unbox<string>
            v55
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v56 : string = null |> unbox<string>
            v56
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v57 : string = null |> unbox<string>
            v57
#endif
            
#if FABLE_COMPILER_PYTHON
            let v58 : string = null |> unbox<string>
            v58
#endif
            
#else
            let v59 : string = "^\\\\\\\\\\?\\\\"
            let v60 : string = ""
            let v61 : string = System.Text.RegularExpressions.Regex.Replace (v43, v59, v60)
            v61
#endif
            |> fun x -> _v44 <- Some x
            let v62 : string = _v44.Value
            let v63 : string = $"{v62.[0] |> string |> _.ToLower()}{v62.[1..]}"
            let v64 : string = "\\"
            let v65 : string = "/"
            let v66 : string = v63.Replace (v64, v65)
            let v67 : (string []) = v66.Split v65
            let v68 : (string []) = [||]
            let v69 : int32 = v67.Length
            let v70 : Mut4 = {l0 = 0; l1 = 0; l2 = v68} : Mut4
            while method25(v69, v70) do
                let v72 : int32 = v70.l0
                let v73 : int32 =  -v72
                let v74 : int32 = v73 + v69
                let v75 : int32 = v74 - 1
                let struct (v76 : int32, v77 : (string [])) = v70.l1, v70.l2
                let v78 : string = v67.[int v75]
                let v79 : bool = ".." = v78
                let struct (v121 : int32, v122 : (string [])) =
                    if v79 then
                        let v80 : int32 = v76 + 1
                        struct (v80, v77)
                    else
                        let v81 : bool = "." = v78
                        if v81 then
                            struct (v76, v77)
                        else
                            let v82 : bool = 0 = v76
                            if v82 then
                                let v83 : string = ":"
                                let v84 : bool = v78.EndsWith v83
                                if v84 then
                                    let v85 : string = $"{v42.[0]}:"
                                    let v86 : (string []) = [|v85|]
                                    let v87 : int32 = v86.Length
                                    let v88 : int32 = v77.Length
                                    let v89 : int32 = v87 + v88
                                    let v90 : (string []) = Array.zeroCreate<string> (v89)
                                    let v91 : Mut5 = {l0 = 0} : Mut5
                                    while method26(v89, v91) do
                                        let v93 : int32 = v91.l0
                                        let v94 : bool = v93 < v87
                                        let v98 : string =
                                            if v94 then
                                                let v95 : string = v86.[int v93]
                                                v95
                                            else
                                                let v96 : int32 = v93 - v87
                                                let v97 : string = v77.[int v96]
                                                v97
                                        v90.[int v93] <- v98
                                        let v99 : int32 = v93 + 1
                                        v91.l0 <- v99
                                        ()
                                    struct (0, v90)
                                else
                                    let v100 : (string []) = [|v78|]
                                    let v101 : int32 = v100.Length
                                    let v102 : int32 = v77.Length
                                    let v103 : int32 = v101 + v102
                                    let v104 : (string []) = Array.zeroCreate<string> (v103)
                                    let v105 : Mut5 = {l0 = 0} : Mut5
                                    while method26(v103, v105) do
                                        let v107 : int32 = v105.l0
                                        let v108 : bool = v107 < v101
                                        let v112 : string =
                                            if v108 then
                                                let v109 : string = v100.[int v107]
                                                v109
                                            else
                                                let v110 : int32 = v107 - v101
                                                let v111 : string = v77.[int v110]
                                                v111
                                        v104.[int v107] <- v112
                                        let v113 : int32 = v107 + 1
                                        v105.l0 <- v113
                                        ()
                                    struct (0, v104)
                            else
                                let v116 : int32 = v76 - 1
                                struct (v116, v77)
                let v123 : int32 = v72 + 1
                v70.l0 <- v123
                v70.l1 <- v121
                v70.l2 <- v122
                ()
            let struct (v124 : int32, v125 : (string [])) = v70.l1, v70.l2
            let v126 : string seq = seq { for i = 0 to v125.Length - 1 do yield v125.[i] }
            let v127 : char option = None
            let v128 : bool = true in let mutable _v127 = v127
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v129 : string = "std::path::MAIN_SEPARATOR"
            let v130 : char = Fable.Core.RustInterop.emitRustExpr () v129
            v130
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v131 : char = null |> unbox<char>
            v131
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v132 : char = null |> unbox<char>
            v132
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v133 : char = null |> unbox<char>
            v133
#endif
            
#if FABLE_COMPILER_PYTHON
            let v134 : char = null |> unbox<char>
            v134
#endif
            
#else
            let v135 : char = System.IO.Path.DirectorySeparatorChar
            v135
#endif
            |> fun x -> _v127 <- Some x
            let v136 : char = _v127.Value
            let v137 : (char -> string) = _.ToString()
            let v138 : string = v137 v136
            let v139 : string = method27(v138)
            let v140 : (string -> (string seq -> string)) = String.concat
            let v141 : (string seq -> string) = v140 v139
            v141 v126
        else
            let v143 : string = "std::fs::canonicalize(&*$0)"
            let v144 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v3 v143
            let v145 : string = "$0.unwrap()"
            let v146 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v144 v145
            let v147 : string = "$0.display()"
            let v148 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v146 v147
            let v149 : std_string_String option = None
            let v150 : bool = true in let mutable _v149 = v149
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v151 : string = @$"format!(""{{}}"", $0)"
            let v152 : std_string_String = Fable.Core.RustInterop.emitRustExpr v148 v151
            v152
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v153 : string = @$"format!(""{{}}"", $0)"
            let v154 : std_string_String = Fable.Core.RustInterop.emitRustExpr v148 v153
            v154
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v155 : string = @$"format!(""{{}}"", $0)"
            let v156 : std_string_String = Fable.Core.RustInterop.emitRustExpr v148 v155
            v156
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v157 : std_string_String = null |> unbox<std_string_String>
            v157
#endif
            
#if FABLE_COMPILER_PYTHON
            let v158 : std_string_String = null |> unbox<std_string_String>
            v158
#endif
            
#else
            let v159 : std_string_String = null |> unbox<std_string_String>
            v159
#endif
            |> fun x -> _v149 <- Some x
            let v160 : std_string_String = _v149.Value
            let v161 : string = "fable_library_rust::String_::fromString($0)"
            let v162 : string = Fable.Core.RustInterop.emitRustExpr v160 v161
            v162
    v163
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v164 : string = null |> unbox<string>
    v164
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v165 : string = null |> unbox<string>
    v165
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v166 : string = null |> unbox<string>
    v166
#endif
    
#if FABLE_COMPILER_PYTHON
    let v167 : string = null |> unbox<string>
    v167
#endif
    
#else
    let v168 : string = method28(v0)
    let v169 : (string -> string) = System.IO.Path.GetFullPath
    let v170 : string = v169 v168
    v170
#endif
    |> fun x -> _v1 <- Some x
    let v171 : string = _v1.Value
    let v172 : string option = None
    let v173 : bool = true in let mutable _v172 = v172
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v174 : string = method22()
    let v175 : string = method23(v171)
    let v176 : string = method24()
    let v177 : string = $"regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
    let v178 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v174, v175, v176) v177
    let v179 : string = "String::from($0)"
    let v180 : std_string_String = Fable.Core.RustInterop.emitRustExpr v178 v179
    let v181 : string = "fable_library_rust::String_::fromString($0)"
    let v182 : string = Fable.Core.RustInterop.emitRustExpr v180 v181
    v182
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v183 : string = null |> unbox<string>
    v183
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v184 : string = null |> unbox<string>
    v184
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v185 : string = null |> unbox<string>
    v185
#endif
    
#if FABLE_COMPILER_PYTHON
    let v186 : string = null |> unbox<string>
    v186
#endif
    
#else
    let v187 : string = "^\\\\\\\\\\?\\\\"
    let v188 : string = ""
    let v189 : string = System.Text.RegularExpressions.Regex.Replace (v171, v187, v188)
    v189
#endif
    |> fun x -> _v172 <- Some x
    let v190 : string = _v172.Value
    let v191 : string = $"{v190.[0] |> string |> _.ToLower()}{v190.[1..]}"
    let v192 : string = "\\"
    let v193 : string = "/"
    let v194 : string = v191.Replace (v192, v193)
    v194
and method39 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : string option) : string =
    v1
and method40 () : struct (string * string) =
    let v0 : string = ""
    struct (v0, v0)
and closure27 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure26 () (v0 : char) : (UH0 -> UH0) =
    closure27(v0)
and method41 () : (char -> (UH0 -> UH0)) =
    closure26()
and method42 (v0 : string, v1 : string, v2 : UH0, v3 : US8) : struct (string * string) =
    match v2 with
    | UH0_1(v4, v5) -> (* Cons *)
        let v6 : bool = '"' = v4
        if v6 then
            let v8 : bool = v1 = ""
            if v8 then
                let v9 : US9 = US9_0
                let v10 : US8 = US8_1(v9)
                method42(v0, v1, v5, v10)
            else
                match v3 with
                | US8_2 -> (* Arguments *)
                    let v38 : string = $"{v0}{v4}"
                    let v39 : US8 = US8_2
                    method42(v38, v1, v5, v39)
                | US8_1(v13) -> (* Path *)
                    match v13 with
                    | US9_0 -> (* Quoted *)
                        let v14 : US9 = US9_1
                        let v15 : US8 = US8_1(v14)
                        method42(v0, v1, v5, v15)
                    | _ ->
                        let v18 : bool = ' ' = v4
                        if v18 then
                            let v19 : US8 = US8_2
                            method42(v0, v1, v5, v19)
                        else
                            let v22 : string = $"{v1}{v4}"
                            method42(v0, v22, v5, v3)
                | US8_0 -> (* Start *)
                    let v29 : bool = ' ' = v4
                    if v29 then
                        let v30 : US8 = US8_2
                        method42(v0, v1, v5, v30)
                    else
                        let v33 : string = $"{v1}{v4}"
                        method42(v0, v33, v5, v3)
        else
            let v50 : bool = ''' = v4
            if v50 then
                let v52 : bool = v1 = ""
                if v52 then
                    let v53 : US9 = US9_0
                    let v54 : US8 = US8_1(v53)
                    method42(v0, v1, v5, v54)
                else
                    match v3 with
                    | US8_2 -> (* Arguments *)
                        let v82 : string = $"{v0}{v4}"
                        let v83 : US8 = US8_2
                        method42(v82, v1, v5, v83)
                    | US8_1(v57) -> (* Path *)
                        match v57 with
                        | US9_0 -> (* Quoted *)
                            let v58 : US9 = US9_1
                            let v59 : US8 = US8_1(v58)
                            method42(v0, v1, v5, v59)
                        | _ ->
                            let v62 : bool = ' ' = v4
                            if v62 then
                                let v63 : US8 = US8_2
                                method42(v0, v1, v5, v63)
                            else
                                let v66 : string = $"{v1}{v4}"
                                method42(v0, v66, v5, v3)
                    | US8_0 -> (* Start *)
                        let v73 : bool = ' ' = v4
                        if v73 then
                            let v74 : US8 = US8_2
                            method42(v0, v1, v5, v74)
                        else
                            let v77 : string = $"{v1}{v4}"
                            method42(v0, v77, v5, v3)
            else
                match v3 with
                | US8_2 -> (* Arguments *)
                    let v126 : string = $"{v0}{v4}"
                    let v127 : US8 = US8_2
                    method42(v126, v1, v5, v127)
                | US8_1(v94) -> (* Path *)
                    match v94 with
                    | US9_0 -> (* Quoted *)
                        let v95 : bool = ' ' = v4
                        if v95 then
                            let v96 : string = $"{v1} "
                            let v97 : US9 = US9_0
                            let v98 : US8 = US8_1(v97)
                            method42(v0, v96, v5, v98)
                        else
                            let v101 : string = $"{v1}{v4}"
                            method42(v0, v101, v5, v3)
                    | _ ->
                        let v106 : bool = ' ' = v4
                        if v106 then
                            let v107 : US8 = US8_2
                            method42(v0, v1, v5, v107)
                        else
                            let v110 : string = $"{v1}{v4}"
                            method42(v0, v110, v5, v3)
                | US8_0 -> (* Start *)
                    let v117 : bool = ' ' = v4
                    if v117 then
                        let v118 : US8 = US8_2
                        method42(v0, v1, v5, v118)
                    else
                        let v121 : string = $"{v1}{v4}"
                        method42(v0, v121, v5, v3)
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
and method46 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = method46(v3, v1)
        UH1_1(v2, v4)
    | UH1_0 -> (* Nil *)
        v1
and method45 (v0 : string, v1 : UH1, v2 : UH0, v3 : US10) : struct (UH1 * string) =
    match v3 with
    | US10_2(v44) -> (* Escaped *)
        match v2 with
        | UH0_1(v45, v46) -> (* Cons *)
            let v47 : bool = '\\' = v45
            if v47 then
                let v48 : char = '\\'
                let v49 : US10 = US10_1(v48)
                method44(v0, v1, v46, v3, v49)
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
                        method45(v0, v1, v46, v3)
                    else
                        let v57 : string = $"{v0}\""
                        let v58 : US10 = US10_2(v44)
                        method44(v57, v1, v46, v3, v58)
                else
                    let v63 : bool = ' ' = v45
                    if v63 then
                        let v64 : string = $"{v0} "
                        method45(v64, v1, v46, v3)
                    else
                        let v67 : bool = 1uy = v44
                        if v67 then
                            let v68 : bool = v3 <> v3
                            if v68 then
                                let v69 : string = $"{v0}\{v45}"
                                method45(v69, v1, v46, v3)
                            else
                                let v72 : string = $"{v0}{v45}"
                                method45(v72, v1, v46, v3)
                        else
                            let v77 : string = $"{v0}{v45}"
                            method45(v77, v1, v46, v3)
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
                        method46(v1, v92)
                struct (v94, v0)
            else
                let v96 : bool = v0 = ""
                let v100 : UH1 =
                    if v96 then
                        v1
                    else
                        let v97 : UH1 = UH1_0
                        let v98 : UH1 = UH1_1(v0, v97)
                        method46(v1, v98)
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
                        method44(v0, v1, v108, v3, v112)
                    else
                        let v115 : bool = '\\' = v105
                        if v115 then
                            let v116 : US10 = US10_2(0uy)
                            let v117 : bool = v3 <> v116
                            if v117 then
                                let v118 : string = $"{v0}\""
                                let v119 : char = '"'
                                let v120 : US10 = US10_1(v119)
                                method44(v118, v1, v108, v3, v120)
                            else
                                let v123 : US10 = US10_1('\\')
                                let v124 : bool = v3 = v123
                                if v124 then
                                    let v125 : string = $"{v0}\""
                                    let v126 : char = '"'
                                    let v127 : US10 = US10_1(v126)
                                    method44(v125, v1, v108, v3, v127)
                                else
                                    let v130 : US10 = US10_0
                                    method44(v0, v1, v108, v3, v130)
                        else
                            let v137 : bool = '\\' = v107
                            if v137 then
                                let v138 : uint8 = 1uy
                                let v139 : US10 = US10_2(v138)
                                method44(v0, v1, v108, v3, v139)
                            else
                                let v142 : US10 = US10_2(0uy)
                                let v143 : bool = v3 = v142
                                if v143 then
                                    let v144 : string = $"{v0}\""
                                    let v145 : char = '"'
                                    let v146 : US10 = US10_1(v145)
                                    method44(v144, v1, v108, v3, v146)
                                else
                                    let v149 : UH1 = UH1_0
                                    let v150 : UH1 = UH1_1(v0, v149)
                                    let v151 : UH1 = method46(v1, v150)
                                    let v152 : string = ""
                                    let v153 : US10 = US10_0
                                    method44(v152, v151, v108, v3, v153)
                else
                    let v164 : bool = '\\' = v105
                    if v164 then
                        let v165 : bool = '\\' = v107
                        if v165 then
                            let v166 : uint8 = 1uy
                            let v167 : US10 = US10_2(v166)
                            method44(v0, v1, v108, v3, v167)
                        else
                            let v170 : bool = ' ' = v107
                            if v170 then
                                let v171 : string = $"{v0} "
                                method45(v171, v1, v108, v3)
                            else
                                let v174 : string = $"{v0}{v107}"
                                method45(v174, v1, v108, v3)
                    else
                        let v181 : bool = '\\' = v107
                        if v181 then
                            let v182 : uint8 = 1uy
                            let v183 : US10 = US10_2(v182)
                            method44(v0, v1, v108, v3, v183)
                        else
                            let v186 : bool = ' ' = v107
                            if v186 then
                                let v187 : string = $"{v0} "
                                method45(v187, v1, v108, v3)
                            else
                                let v190 : string = $"{v0}{v107}"
                                method45(v190, v1, v108, v3)
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
                            method46(v1, v205)
                    struct (v207, v0)
                else
                    let v209 : bool = v0 = ""
                    let v213 : UH1 =
                        if v209 then
                            v1
                        else
                            let v210 : UH1 = UH1_0
                            let v211 : UH1 = UH1_1(v0, v210)
                            method46(v1, v211)
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
                            method44(v224, v1, v220, v3, v226)
                        else
                            let v229 : US10 = US10_1('\\')
                            let v230 : bool = v3 = v229
                            if v230 then
                                let v231 : string = $"{v0}\""
                                let v232 : char = '"'
                                let v233 : US10 = US10_1(v232)
                                method44(v231, v1, v220, v3, v233)
                            else
                                let v236 : US10 = US10_0
                                method44(v0, v1, v220, v3, v236)
                    else
                        let v243 : bool = '\\' = v219
                        if v243 then
                            let v244 : uint8 = 1uy
                            let v245 : US10 = US10_2(v244)
                            method44(v0, v1, v220, v3, v245)
                        else
                            let v248 : bool = ' ' = v219
                            if v248 then
                                let v249 : string = $"{v0} "
                                method45(v249, v1, v220, v3)
                            else
                                let v252 : string = $"{v0}{v219}"
                                method45(v252, v1, v220, v3)
                | _ ->
                    let v262 : bool = v0 = ""
                    let v266 : UH1 =
                        if v262 then
                            v1
                        else
                            let v263 : UH1 = UH1_0
                            let v264 : UH1 = UH1_1(v0, v263)
                            method46(v1, v264)
                    struct (v266, v0)
            else
                match v2 with
                | UH0_1(v269, v270) -> (* Cons *)
                    let v271 : bool = '\\' = v269
                    if v271 then
                        let v272 : uint8 = 1uy
                        let v273 : US10 = US10_2(v272)
                        method44(v0, v1, v270, v3, v273)
                    else
                        let v276 : bool = '"' = v269
                        if v276 then
                            let v277 : US10 = US10_2(0uy)
                            let v278 : bool = v3 = v277
                            if v278 then
                                let v279 : string = $"{v0}\""
                                let v280 : char = '"'
                                let v281 : US10 = US10_1(v280)
                                method44(v279, v1, v270, v3, v281)
                            else
                                let v284 : UH1 = UH1_0
                                let v285 : UH1 = UH1_1(v0, v284)
                                let v286 : UH1 = method46(v1, v285)
                                let v287 : string = ""
                                let v288 : US10 = US10_0
                                method44(v287, v286, v270, v3, v288)
                        else
                            let v293 : bool = ' ' = v269
                            if v293 then
                                let v294 : string = $"{v0} "
                                method45(v294, v1, v270, v3)
                            else
                                let v297 : string = $"{v0}{v269}"
                                method45(v297, v1, v270, v3)
                | _ ->
                    let v307 : bool = v0 = ""
                    let v311 : UH1 =
                        if v307 then
                            v1
                        else
                            let v308 : UH1 = UH1_0
                            let v309 : UH1 = UH1_1(v0, v308)
                            method46(v1, v309)
                    struct (v311, v0)
    | US10_0 -> (* Start *)
        match v2 with
        | UH0_1(v4, v5) -> (* Cons *)
            let v6 : bool = '"' = v4
            if v6 then
                let v7 : string = ""
                let v8 : char = '"'
                let v9 : US10 = US10_1(v8)
                method44(v7, v1, v5, v3, v9)
            else
                let v12 : bool = '\\' = v4
                if v12 then
                    let v13 : uint8 = 0uy
                    let v14 : US10 = US10_2(v13)
                    method44(v0, v1, v5, v3, v14)
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
                                method46(v1, v21)
                        let v24 : string = ""
                        method45(v24, v23, v5, v3)
                    else
                        let v27 : string = $"{v0}{v4}"
                        method45(v27, v1, v5, v3)
        | _ ->
            let v37 : bool = v0 = ""
            let v41 : UH1 =
                if v37 then
                    v1
                else
                    let v38 : UH1 = UH1_0
                    let v39 : UH1 = UH1_1(v0, v38)
                    method46(v1, v39)
            struct (v41, v0)
and method44 (v0 : string, v1 : UH1, v2 : UH0, v3 : US10, v4 : US10) : struct (UH1 * string) =
    match v4 with
    | US10_2(v45) -> (* Escaped *)
        match v2 with
        | UH0_1(v46, v47) -> (* Cons *)
            let v48 : bool = '\\' = v46
            if v48 then
                let v49 : char = '\\'
                let v50 : US10 = US10_1(v49)
                method44(v0, v1, v47, v4, v50)
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
                        method45(v0, v1, v47, v4)
                    else
                        let v58 : string = $"{v0}\""
                        let v59 : US10 = US10_2(v45)
                        method44(v58, v1, v47, v4, v59)
                else
                    let v64 : bool = ' ' = v46
                    if v64 then
                        let v65 : string = $"{v0} "
                        method45(v65, v1, v47, v4)
                    else
                        let v68 : bool = 1uy = v45
                        if v68 then
                            let v69 : bool = v3 <> v4
                            if v69 then
                                let v70 : string = $"{v0}\{v46}"
                                method44(v70, v1, v47, v4, v3)
                            else
                                let v73 : string = $"{v0}{v46}"
                                method45(v73, v1, v47, v4)
                        else
                            let v78 : string = $"{v0}{v46}"
                            method45(v78, v1, v47, v4)
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
                        method46(v1, v93)
                struct (v95, v0)
            else
                let v97 : bool = v0 = ""
                let v101 : UH1 =
                    if v97 then
                        v1
                    else
                        let v98 : UH1 = UH1_0
                        let v99 : UH1 = UH1_1(v0, v98)
                        method46(v1, v99)
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
                        method44(v0, v1, v109, v4, v113)
                    else
                        let v116 : bool = '\\' = v106
                        if v116 then
                            let v117 : US10 = US10_2(0uy)
                            let v118 : bool = v3 <> v117
                            if v118 then
                                let v119 : string = $"{v0}\""
                                let v120 : char = '"'
                                let v121 : US10 = US10_1(v120)
                                method44(v119, v1, v109, v4, v121)
                            else
                                let v124 : US10 = US10_1('\\')
                                let v125 : bool = v3 = v124
                                if v125 then
                                    let v126 : string = $"{v0}\""
                                    let v127 : char = '"'
                                    let v128 : US10 = US10_1(v127)
                                    method44(v126, v1, v109, v4, v128)
                                else
                                    let v131 : US10 = US10_0
                                    method44(v0, v1, v109, v4, v131)
                        else
                            let v138 : bool = '\\' = v108
                            if v138 then
                                let v139 : uint8 = 1uy
                                let v140 : US10 = US10_2(v139)
                                method44(v0, v1, v109, v4, v140)
                            else
                                let v143 : US10 = US10_2(0uy)
                                let v144 : bool = v3 = v143
                                if v144 then
                                    let v145 : string = $"{v0}\""
                                    let v146 : char = '"'
                                    let v147 : US10 = US10_1(v146)
                                    method44(v145, v1, v109, v4, v147)
                                else
                                    let v150 : UH1 = UH1_0
                                    let v151 : UH1 = UH1_1(v0, v150)
                                    let v152 : UH1 = method46(v1, v151)
                                    let v153 : string = ""
                                    let v154 : US10 = US10_0
                                    method44(v153, v152, v109, v4, v154)
                else
                    let v165 : bool = '\\' = v106
                    if v165 then
                        let v166 : bool = '\\' = v108
                        if v166 then
                            let v167 : uint8 = 1uy
                            let v168 : US10 = US10_2(v167)
                            method44(v0, v1, v109, v4, v168)
                        else
                            let v171 : bool = ' ' = v108
                            if v171 then
                                let v172 : string = $"{v0} "
                                method45(v172, v1, v109, v4)
                            else
                                let v175 : string = $"{v0}{v108}"
                                method45(v175, v1, v109, v4)
                    else
                        let v182 : bool = '\\' = v108
                        if v182 then
                            let v183 : uint8 = 1uy
                            let v184 : US10 = US10_2(v183)
                            method44(v0, v1, v109, v4, v184)
                        else
                            let v187 : bool = ' ' = v108
                            if v187 then
                                let v188 : string = $"{v0} "
                                method45(v188, v1, v109, v4)
                            else
                                let v191 : string = $"{v0}{v108}"
                                method45(v191, v1, v109, v4)
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
                            method46(v1, v206)
                    struct (v208, v0)
                else
                    let v210 : bool = v0 = ""
                    let v214 : UH1 =
                        if v210 then
                            v1
                        else
                            let v211 : UH1 = UH1_0
                            let v212 : UH1 = UH1_1(v0, v211)
                            method46(v1, v212)
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
                            method44(v225, v1, v221, v4, v227)
                        else
                            let v230 : US10 = US10_1('\\')
                            let v231 : bool = v3 = v230
                            if v231 then
                                let v232 : string = $"{v0}\""
                                let v233 : char = '"'
                                let v234 : US10 = US10_1(v233)
                                method44(v232, v1, v221, v4, v234)
                            else
                                let v237 : US10 = US10_0
                                method44(v0, v1, v221, v4, v237)
                    else
                        let v244 : bool = '\\' = v220
                        if v244 then
                            let v245 : uint8 = 1uy
                            let v246 : US10 = US10_2(v245)
                            method44(v0, v1, v221, v4, v246)
                        else
                            let v249 : bool = ' ' = v220
                            if v249 then
                                let v250 : string = $"{v0} "
                                method45(v250, v1, v221, v4)
                            else
                                let v253 : string = $"{v0}{v220}"
                                method45(v253, v1, v221, v4)
                | _ ->
                    let v263 : bool = v0 = ""
                    let v267 : UH1 =
                        if v263 then
                            v1
                        else
                            let v264 : UH1 = UH1_0
                            let v265 : UH1 = UH1_1(v0, v264)
                            method46(v1, v265)
                    struct (v267, v0)
            else
                match v2 with
                | UH0_1(v270, v271) -> (* Cons *)
                    let v272 : bool = '\\' = v270
                    if v272 then
                        let v273 : uint8 = 1uy
                        let v274 : US10 = US10_2(v273)
                        method44(v0, v1, v271, v4, v274)
                    else
                        let v277 : bool = '"' = v270
                        if v277 then
                            let v278 : US10 = US10_2(0uy)
                            let v279 : bool = v3 = v278
                            if v279 then
                                let v280 : string = $"{v0}\""
                                let v281 : char = '"'
                                let v282 : US10 = US10_1(v281)
                                method44(v280, v1, v271, v4, v282)
                            else
                                let v285 : UH1 = UH1_0
                                let v286 : UH1 = UH1_1(v0, v285)
                                let v287 : UH1 = method46(v1, v286)
                                let v288 : string = ""
                                let v289 : US10 = US10_0
                                method44(v288, v287, v271, v4, v289)
                        else
                            let v294 : bool = ' ' = v270
                            if v294 then
                                let v295 : string = $"{v0} "
                                method45(v295, v1, v271, v4)
                            else
                                let v298 : string = $"{v0}{v270}"
                                method45(v298, v1, v271, v4)
                | _ ->
                    let v308 : bool = v0 = ""
                    let v312 : UH1 =
                        if v308 then
                            v1
                        else
                            let v309 : UH1 = UH1_0
                            let v310 : UH1 = UH1_1(v0, v309)
                            method46(v1, v310)
                    struct (v312, v0)
    | US10_0 -> (* Start *)
        match v2 with
        | UH0_1(v5, v6) -> (* Cons *)
            let v7 : bool = '"' = v5
            if v7 then
                let v8 : string = ""
                let v9 : char = '"'
                let v10 : US10 = US10_1(v9)
                method44(v8, v1, v6, v4, v10)
            else
                let v13 : bool = '\\' = v5
                if v13 then
                    let v14 : uint8 = 0uy
                    let v15 : US10 = US10_2(v14)
                    method44(v0, v1, v6, v4, v15)
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
                                method46(v1, v22)
                        let v25 : string = ""
                        method45(v25, v24, v6, v4)
                    else
                        let v28 : string = $"{v0}{v5}"
                        method45(v28, v1, v6, v4)
        | _ ->
            let v38 : bool = v0 = ""
            let v42 : UH1 =
                if v38 then
                    v1
                else
                    let v39 : UH1 = UH1_0
                    let v40 : UH1 = UH1_1(v0, v39)
                    method46(v1, v40)
            struct (v42, v0)
and method47 (v0 : UH1, v1 : string list) : string list =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : string list = method47(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH1_0 -> (* Nil *)
        v1
and method43 (v0 : string) : (string []) =
    let v1 : UH1 = UH1_0
    let v2 : string = ""
    let v3 : bool = true in let mutable _v0 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v4 : (string -> string option) = Option.ofObj
    let v5 : string option = v4 v0
    v5 
    #else
    Some v0 
    #endif
    |> fun x -> _v0 <- Some x
    let v6 : string option = _v0.Value
    let v7 : (string -> US4) = method19()
    let v8 : US4 = US4_1
    let v9 : US4 = v6 |> Option.map v7 |> Option.defaultValue v8 
    let v12 : string =
        match v9 with
        | US4_1 -> (* None *)
            v2
        | US4_0(v10) -> (* Some *)
            v10
    let v13 : int32 = v12.Length
    let v14 : (char []) = Array.zeroCreate<char> (v13)
    let v15 : Mut5 = {l0 = 0} : Mut5
    while method26(v13, v15) do
        let v17 : int32 = v15.l0
        let v18 : char = v12.[int v17]
        v14.[int v17] <- v18
        let v19 : int32 = v17 + 1
        v15.l0 <- v19
        ()
    let v20 : ((char []) -> char list) = Array.toList
    let v21 : char list = v20 v14
    let v22 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v23 : (char -> (UH0 -> UH0)) = method41()
    let v24 : (char list -> (UH0 -> UH0)) = v22 v23
    let v25 : (UH0 -> UH0) = v24 v21
    let v26 : UH0 = UH0_0
    let v27 : UH0 = v25 v26
    let v28 : US10 = US10_0
    let v29 : US10 = US10_0
    let struct (v30 : UH1, v31 : string) = method44(v2, v1, v27, v29, v28)
    let v32 : string list = []
    let v33 : string list = method47(v30, v32)
    let v34 : (string list -> (string [])) = List.toArray
    let v35 : (string []) = v34 v33
    v35
and closure28 () (v0 : string) : std_string_String =
    let v1 : string = method14(v0)
    let v2 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    v5
and closure29 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : string option, v6 : string, v7 : Vec<std_string_String>) () : string =
    let v8 : string = $"execute_with_options / file_name: {v6} / arguments: %A{v7} / options: %A{struct (v0, v1, v2, v3, v4, v5)}"
    v8
and method48 () : (unit -> string) =
    closure6()
and method50 (v0 : string) : string =
    v0
and method52 (v0 : std_sync_Mutex<std_process_Child option>) : std_sync_Mutex<std_process_Child option> =
    v0
and closure30 () (v0 : std_process_Child) : std_sync_Arc<std_sync_Mutex<std_process_Child option>> =
    let v1 : std_process_Child option = Some v0 
    let v2 : string = "std::sync::Mutex::new($0)"
    let v3 : std_sync_Mutex<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : std_sync_Mutex<std_process_Child option> = method52(v3)
    let v5 : string = "std::sync::Arc::new(v4)"
    let v6 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr () v5
    v6
and method51 () : (std_process_Child -> std_sync_Arc<std_sync_Mutex<std_process_Child option>>) =
    closure30()
and method53 (v0 : Result<std_process_Child, std_io_Error>) : Result<std_process_Child, std_io_Error> =
    v0
and closure31 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : US11 =
    US11_0(v0)
and closure32 () (v0 : std_string_String) : US11 =
    US11_1(v0)
and closure33 (v0 : std_string_String) () : string =
    let v1 : string = $"execute_with_options -1 / error: {v0}"
    v1
and method54 (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : std_sync_Arc<std_sync_Mutex<std_process_Child option>> =
    v0
and method55 (v0 : std_sync_Mutex<std_process_ChildStdout option>) : std_sync_Mutex<std_process_ChildStdout option> =
    v0
and method56 (v0 : std_sync_Mutex<std_process_ChildStderr option>) : std_sync_Mutex<std_process_ChildStderr option> =
    v0
and method57 (v0 : std_sync_Mutex<std_process_ChildStdin option>) : std_sync_Mutex<std_process_ChildStdin option> =
    v0
and method58 (v0 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> =
    v0
and method59 (v0 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>) : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> =
    v0
and method60 (v0 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>) : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> =
    v0
and method61 (v0 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>>) : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> =
    v0
and closure35 () (v0 : std_string_String) : US13 =
    US13_0(v0)
and closure36 () (v0 : std_string_String) : US13 =
    US13_1(v0)
and closure37 (v0 : std_string_String) () : string =
    let v1 : string = $"execute_with_options / stdout_line / stdout: {true} / e: {v0}"
    v1
and closure38 (v0 : std_string_String) () : string =
    let v1 : string = $"> {v0}"
    v1
and closure34 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) (v1 : Result<std_string_String, std_io_Error>) : unit =
    let v2 : (std_io_Error -> std_string_String) = method33()
    let v3 : string = "$0.map_err(|x| $1(x))"
    let v4 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1, v2) v3
    let v5 : (std_string_String -> US13) = closure35()
    let v6 : (std_string_String -> US13) = closure36()
    let v7 : US13 = match v4 with Ok x -> v5 x | Error x -> v6 x
    let v23 : std_string_String =
        match v7 with
        | US13_1(v12) -> (* Error *)
            let v13 : US0 = US0_4
            let v14 : (unit -> string) = closure37(v12)
            let v15 : (unit -> string) = closure6()
            method3(v13, v14, v15)
            let v16 : string = $"[{v12}]"
            let v17 : string = method14(v16)
            let v18 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v19 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v17 v18
            let v20 : string = "String::from($0)"
            let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v20
            v21
        | US13_0(v8) -> (* Ok *)
            let v9 : US0 = US0_0
            let v10 : (unit -> string) = closure38(v8)
            let v11 : (unit -> string) = closure6()
            method3(v9, v10, v11)
            v8
    let v24 : string = "true; $0.lock().unwrap().send($1).unwrap()"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr struct (v0, v23) v24
    ()
and method62 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) : (Result<std_string_String, std_io_Error> -> unit) =
    closure34(v0)
and method63 (v0 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>>) : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>> =
    v0
and closure40 (v0 : std_string_String) () : string =
    let v1 : string = $"execute_with_options / stdout_line / stdout: {false} / e: {v0}"
    v1
and closure39 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) (v1 : Result<std_string_String, std_io_Error>) : unit =
    let v2 : (std_io_Error -> std_string_String) = method33()
    let v3 : string = "$0.map_err(|x| $1(x))"
    let v4 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1, v2) v3
    let v5 : (std_string_String -> US13) = closure35()
    let v6 : (std_string_String -> US13) = closure36()
    let v7 : US13 = match v4 with Ok x -> v5 x | Error x -> v6 x
    let v23 : std_string_String =
        match v7 with
        | US13_1(v12) -> (* Error *)
            let v13 : US0 = US0_4
            let v14 : (unit -> string) = closure40(v12)
            let v15 : (unit -> string) = closure6()
            method3(v13, v14, v15)
            let v16 : string = $"[{v12}]"
            let v17 : string = method14(v16)
            let v18 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v19 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v17 v18
            let v20 : string = "String::from($0)"
            let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v20
            v21
        | US13_0(v8) -> (* Ok *)
            let v9 : US0 = US0_0
            let v10 : (unit -> string) = closure38(v8)
            let v11 : (unit -> string) = closure6()
            method3(v9, v10, v11)
            v8
    let v24 : string = "true; $0.lock().unwrap().send($1).unwrap()"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr struct (v0, v23) v24
    ()
and method64 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) : (Result<std_string_String, std_io_Error> -> unit) =
    closure39(v0)
and closure41 () (v0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)) : US14 =
    US14_0(v0)
and method65 () : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US14) =
    closure41()
and method66 (v0 : std_sync_Mutex<std_process_ChildStdin>) : std_sync_Mutex<std_process_ChildStdin> =
    v0
and closure42 () (v0 : std_process_ChildStdin) : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> =
    let v1 : string = "std::sync::Mutex::new($0)"
    let v2 : std_sync_Mutex<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : std_sync_Mutex<std_process_ChildStdin> = method66(v2)
    let v4 : string = "std::sync::Arc::new(v3)"
    let v5 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr () v4
    v5
and closure43 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : US15 =
    US15_0(v0)
and method67 () : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US15) =
    closure43()
and method68 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure44 () (v0 : std_process_Output) : US16 =
    US16_0(v0)
and closure45 () (v0 : std_string_String) : US16 =
    US16_1(v0)
and closure46 (v0 : std_string_String) () : string =
    let v1 : string = $"execute_with_options -2 / error: {v0}"
    v1
and closure47 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"execute_with_options / exit_code: {v0} / std_trace.Length: {v1.Length}"
    v2
and method69 (v0 : (int32 * string)) : (int32 * string) =
    v0
and method49 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : string option, v6 : string, v7 : Vec<std_string_String>) : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> =
    let v8 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v8
    let v9 : string = "std::process::Command::new(&*$0)"
    let v10 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v6 v9
    let v11 : string = "true; let mut v10 = v10"
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr () v11
    let v13 : string = "std::process::Command::args(&mut $0, &*$1)"
    let v14 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr struct (v10, v7) v13
    let v15 : string = "true; let mut v14 = v14"
    let v16 : bool = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : string = "std::process::Command::stdout(&mut $0, std::process::Stdio::piped())"
    let v18 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v14 v17
    let v19 : string = "true; let mut v18 = v18"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : string = "std::process::Command::stderr(&mut $0, std::process::Stdio::piped())"
    let v22 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v18 v21
    let v23 : string = "true; let mut v22 = v22"
    let v24 : bool = Fable.Core.RustInterop.emitRustExpr () v23
    let v25 : string = "std::process::Command::stdin(&mut $0, std::process::Stdio::piped())"
    let v26 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v22 v25
    let v27 : (string -> US4) = method19()
    let v28 : US4 = US4_1
    let v29 : US4 = v5 |> Option.map v27 |> Option.defaultValue v28 
    let v35 : Ref<Mut<std_process_Command>> =
        match v29 with
        | US4_1 -> (* None *)
            v26
        | US4_0(v30) -> (* Some *)
            let v31 : string = method50(v30)
            let v32 : string = "std::process::Command::current_dir(v26, &*v31)"
            let v33 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr () v32
            v33
    let v36 : string = "true; let mut v35 = v35"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : string = "std::process::Command::spawn(&mut $0)"
    let v39 : Result<std_process_Child, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v35 v38
    let v40 : (std_process_Child -> std_sync_Arc<std_sync_Mutex<std_process_Child option>>) = method51()
    let v41 : Result<std_process_Child, std_io_Error> = method53(v39)
    let v42 : string = "v41.map(|x| v40(x))"
    let v43 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : (std_io_Error -> std_string_String) = method33()
    let v45 : string = "$0.map_err(|x| $1(x))"
    let v46 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v43, v44) v45
    let v47 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US11) = closure31()
    let v48 : (std_string_String -> US11) = closure32()
    let v49 : US11 = match v46 with Ok x -> v47 x | Error x -> v48 x
    let struct (v192 : int32, v193 : US3, v194 : US12) =
        match v49 with
        | US11_1(v183) -> (* Error *)
            let v184 : US0 = US0_4
            let v185 : (unit -> string) = closure33(v183)
            let v186 : (unit -> string) = closure6()
            method3(v184, v185, v186)
            let v187 : US3 = US3_0(v183)
            let v188 : US12 = US12_1
            struct (-1, v187, v188)
        | US11_0(v50) -> (* Ok *)
            let v51 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method54(v50)
            let v52 : string = "v51.lock().unwrap().as_mut().unwrap().stdout.take().unwrap()"
            let v53 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr () v52
            let v54 : string = "v51.lock().unwrap().as_mut().unwrap().stderr.take().unwrap()"
            let v55 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr () v54
            let v56 : string = "v51.lock().unwrap().as_mut().unwrap().stdin.take().unwrap()"
            let v57 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr () v56
            let v58 : std_process_ChildStdout option = Some v53 
            let v59 : string = "std::sync::Mutex::new($0)"
            let v60 : std_sync_Mutex<std_process_ChildStdout option> = Fable.Core.RustInterop.emitRustExpr v58 v59
            let v61 : std_sync_Mutex<std_process_ChildStdout option> = method55(v60)
            let v62 : string = "std::sync::Arc::new(v61)"
            let v63 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdout option>> = Fable.Core.RustInterop.emitRustExpr () v62
            let v64 : std_process_ChildStderr option = Some v55 
            let v65 : string = "std::sync::Mutex::new($0)"
            let v66 : std_sync_Mutex<std_process_ChildStderr option> = Fable.Core.RustInterop.emitRustExpr v64 v65
            let v67 : std_sync_Mutex<std_process_ChildStderr option> = method56(v66)
            let v68 : string = "std::sync::Arc::new(v67)"
            let v69 : std_sync_Arc<std_sync_Mutex<std_process_ChildStderr option>> = Fable.Core.RustInterop.emitRustExpr () v68
            let v70 : std_process_ChildStdin option = Some v57 
            let v71 : string = "std::sync::Mutex::new($0)"
            let v72 : std_sync_Mutex<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v70 v71
            let v73 : std_sync_Mutex<std_process_ChildStdin option> = method57(v72)
            let v74 : string = "std::sync::Arc::new(v73)"
            let v75 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v74
            let v76 : string = "{ let (sender, receiver) = std::sync::mpsc::channel(); (sender, std::sync::Arc::new(receiver)) }"
            let struct (v77 : std_sync_mpsc_Sender<std_string_String>, v78 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = Fable.Core.RustInterop.emitRustExpr () v76
            let v79 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> = method58(v78)
            let v80 : string = "true; let v79 = v79"
            let v81 : bool = Fable.Core.RustInterop.emitRustExpr v79 v80
            let v82 : string = "std::sync::Mutex::new($0)"
            let v83 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v77 v82
            let v84 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = method59(v83)
            let v85 : string = "std::sync::Arc::new(v84)"
            let v86 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v85
            let v87 : string = "v86.clone()"
            let v88 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v87
            let v89 : string = "v86.clone()"
            let v90 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v89
            let v91 : string = "std::sync::Mutex::new($0)"
            let v92 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v79 v91
            let v93 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = method60(v92)
            let v94 : string = "std::sync::Arc::new(v93)"
            let v95 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v94
            let v96 : string = "std::thread::spawn(move || { //"
            let v97 : std_thread_JoinHandle<unit> = Fable.Core.RustInterop.emitRustExpr () v96
            let v98 : string = "v63.lock().unwrap().take().unwrap()"
            let v99 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr () v98
            let v100 : string = "std::io::BufReader::new(v99)"
            let v101 : std_io_BufReader<std_process_ChildStdout> = Fable.Core.RustInterop.emitRustExpr () v100
            let v102 : string = "std::io::BufRead::lines(v101)"
            let v103 : std_io_Lines<std_io_BufReader<std_process_ChildStdout>> = Fable.Core.RustInterop.emitRustExpr () v102
            let v104 : string = "std::sync::Mutex::new($0)"
            let v105 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> = Fable.Core.RustInterop.emitRustExpr v103 v104
            let v106 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> = method61(v105)
            let v107 : string = "std::sync::Arc::new(v106)"
            let v108 : std_sync_Arc<std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>>> = Fable.Core.RustInterop.emitRustExpr () v107
            let v109 : (Result<std_string_String, std_io_Error> -> unit) = method62(v88)
            let v110 : string = "true; for line in $0.lock().unwrap().by_ref() { v109(line) }"
            let v111 : bool = Fable.Core.RustInterop.emitRustExpr v108 v110
            let v112 : string = "true; })"
            let v113 : bool = Fable.Core.RustInterop.emitRustExpr () v112
            let v114 : string = "std::thread::spawn(move || { //"
            let v115 : std_thread_JoinHandle<unit> = Fable.Core.RustInterop.emitRustExpr () v114
            let v116 : string = "v69.lock().unwrap().take().unwrap()"
            let v117 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr () v116
            let v118 : string = "std::io::BufReader::new(v117)"
            let v119 : std_io_BufReader<std_process_ChildStderr> = Fable.Core.RustInterop.emitRustExpr () v118
            let v120 : string = "std::io::BufRead::lines(v119)"
            let v121 : std_io_Lines<std_io_BufReader<std_process_ChildStderr>> = Fable.Core.RustInterop.emitRustExpr () v120
            let v122 : string = "std::sync::Mutex::new($0)"
            let v123 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>> = Fable.Core.RustInterop.emitRustExpr v121 v122
            let v124 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>> = method63(v123)
            let v125 : string = "std::sync::Arc::new(v124)"
            let v126 : std_sync_Arc<std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>>> = Fable.Core.RustInterop.emitRustExpr () v125
            let v127 : (Result<std_string_String, std_io_Error> -> unit) = method64(v86)
            let v128 : string = "true; for line in $0.lock().unwrap().by_ref() { v127(line) }"
            let v129 : bool = Fable.Core.RustInterop.emitRustExpr v126 v128
            let v130 : string = "true; })"
            let v131 : bool = Fable.Core.RustInterop.emitRustExpr () v130
            let v132 : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US14) = method65()
            let v133 : US14 = US14_1
            let v134 : US14 = v4 |> Option.map v132 |> Option.defaultValue v133 
            match v134 with
            | US14_1 -> (* None *)
                ()
            | US14_0(v135) -> (* Some *)
                let v136 : string = "v75.lock().unwrap().take()"
                let v137 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr () v136
                let v138 : string = "$0.map(|x| $1(x))"
                let v139 : (std_process_ChildStdin -> std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) = closure42()
                let v140 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> option = Fable.Core.RustInterop.emitRustExpr struct (v137, v139) v138
                let v141 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US15) = method67()
                let v142 : US15 = US15_1
                let v143 : US15 = v140 |> Option.map v141 |> Option.defaultValue v142 
                match v143 with
                | US15_1 -> (* None *)
                    ()
                | US15_0(v144) -> (* Some *)
                    v135 v144
                    let v145 : string = "$0.lock()"
                    let v146 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr v144 v145
                    let v147 : string = "$0.unwrap()"
                    let v148 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v146 v147
                    let v149 : std_sync_MutexGuard<std_process_ChildStdin> = method68(v148)
                    let v150 : string = "true; let mut v149 = v149"
                    let v151 : bool = Fable.Core.RustInterop.emitRustExpr () v150
                    let v152 : string = "true; std::io::Write::flush(&mut *$0).unwrap()"
                    let v153 : bool = Fable.Core.RustInterop.emitRustExpr v149 v152
                    ()
            let v154 : string = "v51.lock().unwrap().take().unwrap().wait_with_output()"
            let v155 : Result<std_process_Output, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v154
            let v156 : (std_io_Error -> std_string_String) = method33()
            let v157 : string = "$0.map_err(|x| $1(x))"
            let v158 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v155, v156) v157
            let v159 : string = "true; v97.join().unwrap()"
            let v160 : bool = Fable.Core.RustInterop.emitRustExpr () v159
            let v161 : string = "true; v115.join().unwrap()"
            let v162 : bool = Fable.Core.RustInterop.emitRustExpr () v161
            let v163 : (std_process_Output -> US16) = closure44()
            let v164 : (std_string_String -> US16) = closure45()
            let v165 : US16 = match v158 with Ok x -> v163 x | Error x -> v164 x
            match v165 with
            | US16_1(v171) -> (* Error *)
                let v172 : US0 = US0_4
                let v173 : (unit -> string) = closure46(v171)
                let v174 : (unit -> string) = closure6()
                method3(v172, v173, v174)
                let v175 : US3 = US3_0(v171)
                let v176 : US12 = US12_1
                struct (-2, v175, v176)
            | US16_0(v166) -> (* Ok *)
                let v167 : string = "$0.status.code().unwrap()"
                let v168 : int32 = Fable.Core.RustInterop.emitRustExpr v166 v167
                let v169 : US3 = US3_1
                let v170 : US12 = US12_0(v95)
                struct (v168, v169, v170)
    let v201 : US3 =
        match v194 with
        | US12_1 -> (* None *)
            US3_1
        | US12_0(v195) -> (* Some *)
            let v196 : string = "$0.lock().unwrap().iter().collect::<Vec<String>>().join(\"\\n\")"
            let v197 : std_string_String = Fable.Core.RustInterop.emitRustExpr v195 v196
            US3_0(v197)
    let v208 : US4 =
        match v201 with
        | US3_1 -> (* None *)
            US4_1
        | US3_0(v202) -> (* Some *)
            let v203 : string = "fable_library_rust::String_::fromString($0)"
            let v204 : string = Fable.Core.RustInterop.emitRustExpr v202 v203
            US4_0(v204)
    let v215 : US4 =
        match v193 with
        | US3_1 -> (* None *)
            US4_1
        | US3_0(v209) -> (* Some *)
            let v210 : string = "fable_library_rust::String_::fromString($0)"
            let v211 : string = Fable.Core.RustInterop.emitRustExpr v209 v210
            US4_0(v211)
    let v219 : string =
        match v215 with
        | US4_1 -> (* None *)
            let v217 : string = ""
            v217
        | US4_0(v216) -> (* Some *)
            v216
    let v222 : string =
        match v208 with
        | US4_1 -> (* None *)
            v219
        | US4_0(v220) -> (* Some *)
            v220
    let v223 : US0 = US0_0
    let v224 : (unit -> string) = closure47(v192, v222)
    let v225 : (unit -> string) = closure6()
    method3(v223, v224, v225)
    let v226 : (int32 * string) = v192, v222
    let v227 : (int32 * string) = method69(v226)
    let v228 : string = "v227 }}})"
    Fable.Core.RustInterop.emitRustExpr () v228
    let v229 : string = "{{ //"
    Fable.Core.RustInterop.emitRustExpr () v229
    let v230 : string = "__result"
    let v231 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = Fable.Core.RustInterop.emitRustExpr () v230
    v231
and closure48 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : string option) () : string =
    let v6 : string = $"execute_with_options_async / options: %A{struct (v0, v1, v2, v3, v4, v5)}"
    v6
and closure50 () (v0 : (struct (bool * string * int32) -> Async<unit>)) : US17 =
    US17_0(v0)
and method70 () : ((struct (bool * string * int32) -> Async<unit>) -> US17) =
    closure50()
and closure51 (v0 : string) () : string =
    let v1 : string = $"> {v0}"
    v1
and closure49 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : string option, v6 : System.Diagnostics.Process, v7 : System.Collections.Concurrent.ConcurrentStack<string>) (v8 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v9 : Async<unit> option = None
    let v10 : bool = true in let mutable _v9 = v9
    
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
    let v17 : string = v8.Data
    let v18 : string = null |> unbox<string>
    let v19 : bool = v17 = v18
    let v20 : bool = v19 <> true
    if v20 then
        let v21 : ((struct (bool * string * int32) -> Async<unit>) -> US17) = method70()
        let v22 : US17 = US17_1
        let v23 : US17 = v3 |> Option.map v21 |> Option.defaultValue v22 
        match v23 with
        | US17_1 -> (* None *)
            ()
        | US17_0(v24) -> (* Some *)
            let v25 : int32 = v6.Id
            let v26 : Async<unit> = v24 struct (false, v17, v25)
            do! v26 
            ()
        let v27 : US0 = US0_0
        let v28 : (unit -> string) = closure51(v17)
        let v29 : (unit -> string) = closure6()
        method3(v27, v28, v29)
        let v30 : string = ""
        let v31 : string = $"{v30}{v17}{v30}"
        let v32 : (string -> unit) = v7.Push
        v32 v31
    }
    |> fun x -> _v16 <- Some x
    let v33 : Async<unit> = _v16 |> Option.get
    v33
#endif
    |> fun x -> _v9 <- Some x
    let v34 : Async<unit> = _v9.Value
    let v35 : unit option = None
    let v36 : bool = true in let mutable _v35 = v35
    
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
    let v37 : (Async<unit> -> unit) = Async.StartImmediate
    v37 v34
    ()
#endif
    |> fun x -> _v35 <- Some x
    _v35.Value
    ()
and closure52 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : string option, v6 : System.Diagnostics.Process, v7 : System.Collections.Concurrent.ConcurrentStack<string>) (v8 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v9 : Async<unit> option = None
    let v10 : bool = true in let mutable _v9 = v9
    
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
    let v17 : string = v8.Data
    let v18 : string = null |> unbox<string>
    let v19 : bool = v17 = v18
    let v20 : bool = v19 <> true
    if v20 then
        let v21 : ((struct (bool * string * int32) -> Async<unit>) -> US17) = method70()
        let v22 : US17 = US17_1
        let v23 : US17 = v3 |> Option.map v21 |> Option.defaultValue v22 
        match v23 with
        | US17_1 -> (* None *)
            ()
        | US17_0(v24) -> (* Some *)
            let v25 : int32 = v6.Id
            let v26 : Async<unit> = v24 struct (true, v17, v25)
            do! v26 
            ()
        let v27 : US0 = US0_0
        let v28 : (unit -> string) = closure51(v17)
        let v29 : (unit -> string) = closure6()
        method3(v27, v28, v29)
        let v30 : string = "["
        let v31 : string = "]"
        let v32 : string = $"{v30}{v17}{v31}"
        let v33 : (string -> unit) = v7.Push
        v33 v32
    }
    |> fun x -> _v16 <- Some x
    let v34 : Async<unit> = _v16 |> Option.get
    v34
#endif
    |> fun x -> _v9 <- Some x
    let v35 : Async<unit> = _v9.Value
    let v36 : unit option = None
    let v37 : bool = true in let mutable _v36 = v36
    
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
    v38 v35
    ()
#endif
    |> fun x -> _v36 <- Some x
    _v36.Value
    ()
and closure53 () (v0 : System.Threading.CancellationToken) : US18 =
    US18_0(v0)
and method71 () : (System.Threading.CancellationToken -> US18) =
    closure53()
and closure54 (v0 : System.Diagnostics.Process) () : unit =
    let v1 : bool option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : bool = null |> unbox<bool>
    v3
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v4 : bool = null |> unbox<bool>
    v4
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v5 : bool = null |> unbox<bool>
    v5
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v6 : bool = null |> unbox<bool>
    v6
#endif
    
#if FABLE_COMPILER_PYTHON
    let v7 : bool = null |> unbox<bool>
    v7
#endif
    
#else
    let v8 : bool = v0.HasExited
    v8
#endif
    |> fun x -> _v1 <- Some x
    let v9 : bool = _v1.Value
    let v10 : bool = v9 = false
    if v10 then
        let v11 : unit option = None
        let v12 : bool = true in let mutable _v11 = v11
        
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
        let v13 : (unit -> unit) = v0.Kill
        v13 ()
        ()
#endif
        |> fun x -> _v11 <- Some x
        _v11.Value
        ()
and closure55 (v0 : System.Threading.Tasks.TaskCanceledException) () : string =
    let v1 : string = $"execute_with_options_async / WaitForExitAsync / ex: %A{v0}"
    v1
and method72 () : string =
    let v0 : string = "\n"
    v0
and closure56 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"execute_with_options_async / exit_code: {v0} / output.Length: {v1.Length}"
    v2
and method73 (v0 : string, v1 : string, v2 : string) : struct (string * string) =
    let v3 : string option = None
    let v4 : bool = true in let mutable _v3 = v3
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = method14(v1)
    let v6 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v7 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "String::from($0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "std::path::PathBuf::from($0)"
    let v11 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "$0.file_name()"
    let v13 : Ref<std_ffi_OsStr> option = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "$0.unwrap()"
    let v15 : Ref<std_ffi_OsStr> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "$0.to_os_string()"
    let v17 : std_ffi_OsString = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "$0.to_str()"
    let v19 : Ref<Str> option = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "$0.unwrap()"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : string = "String::from($0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : string = "fable_library_rust::String_::fromString($0)"
    let v25 : string = Fable.Core.RustInterop.emitRustExpr v23 v24
    v25
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v26 : string = null |> unbox<string>
    v26
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v27 : string = null |> unbox<string>
    v27
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : string = null |> unbox<string>
    v28
#endif
    
#if FABLE_COMPILER_PYTHON
    let v29 : string = null |> unbox<string>
    v29
#endif
    
#else
    let v30 : (string -> string) = System.IO.Path.GetFileName
    let v31 : string = v30 v1
    v31
#endif
    |> fun x -> _v3 <- Some x
    let v32 : string = _v3.Value
    let v33 : string = method13(v2, v32)
    let v34 : string = "."
    let v35 : int32 = v1.LastIndexOf v34
    let v36 : int32 = v35 - 1
    let v37 : string = v1.[int 0..int v36]
    let v38 : int32 = v33.LastIndexOf v34
    let v39 : int32 = v38 - 1
    let v40 : string = v33.[int 0..int v39]
    let v41 : string = ".md"
    let v42 : bool = v0.EndsWith v41
    let v43 : bool = v42 = false
    let v46 : string =
        if v43 then
            let v44 : string = $"{v1}.{v0}"
            v44
        else
            let v45 : string = $"{v37}.{v0}"
            v45
    let v49 : string =
        if v43 then
            let v47 : string = $"{v33}.{v0}"
            v47
        else
            let v48 : string = $"{v40}.{v0}"
            v48
    struct (v49, v46)
and closure57 () () : string =
    let v0 : string = "documents.run / par_map / origin_hash |> sm'.contains local_git_hash |> not / hash2 = None || hash1 <>. (hash2 |> optionm.value)"
    v0
and closure58 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : int32, v5 : string, v6 : string, v7 : int32, v8 : string, v9 : string, v10 : US4) () : string =
    let v11 : (unit -> string) = closure6()
    let v12 : string = $"file: {v1} / real_path: {v2} / relative_path: {v0} / origin_hash_exit_code: {v4} / origin_hash: {v3} / local_git_hash_exit_code: {v7} / local_git_hash: {v6} / hash1: {v9} / hash2: %A{v10} / dist_path: {v5} / cache_path: {v8} / {v11 ()}"
    v12
and method74 (v0 : string) : string =
    v0
and method76 (v0 : int32, v1 : Mut6) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method77 (v0 : string) : string =
    v0
and method78 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure61 (v0 : string) (v1 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : unit =
    let v2 : string = "$0.lock()"
    let v3 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "$0.unwrap()"
    let v5 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = method77(v0)
    let v7 : string = "v6.as_bytes()"
    let v8 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : std_sync_MutexGuard<std_process_ChildStdin> = method78(v5)
    let v10 : string = "true; let mut v9 = v9"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : string = "true; std::io::Write::write_all(&mut *$0, v8).unwrap()"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr v9 v12
    ()
and method79 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method80 (v0 : string) : string =
    v0
and closure62 () () : string =
    let v0 : string = "documents.hangul"
    v0
and closure63 (v0 : string, v1 : int32, v2 : string) () : string =
    let v3 : int32 = v2 |> String.length
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"exit_code: %A{v1} / result_len: {v3} / output_path: {v0} / {v4 ()}"
    v5
and method75 (v0 : string, v1 : string, v2 : string, v3 : string) : US21 =
    let v4 : string option = None
    let v5 : bool = true in let mutable _v4 = v4
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : Vec<uint8> option = None
    let v7 : bool = true in let mutable _v6 = v6
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "std::fs::read(&*$0).unwrap()"
    let v9 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v3 v8
    v9
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v10 : Vec<uint8> = null |> unbox<Vec<uint8>>
    v10
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v11 : Vec<uint8> = null |> unbox<Vec<uint8>>
    v11
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : Vec<uint8> = null |> unbox<Vec<uint8>>
    v12
#endif
    
#if FABLE_COMPILER_PYTHON
    let v13 : Vec<uint8> = null |> unbox<Vec<uint8>>
    v13
#endif
    
#else
    let v14 : (uint8 []) = v3 |> System.IO.File.ReadAllBytes
    let v15 : string = "$0.to_vec()"
    let v16 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v14 v15
    v16
#endif
    |> fun x -> _v6 <- Some x
    let v17 : Vec<uint8> = _v6.Value
    let v18 : string = "std::string::String::from_utf8(v17)"
    let v19 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : string = "$0.unwrap()"
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
    let v28 : string = v3 |> System.IO.File.ReadAllText
    v28
#endif
    |> fun x -> _v4 <- Some x
    let v29 : string = _v4.Value
    let v30 : string = "\n"
    let v31 : (string []) = v29.Split v30
    let v32 : int32 = v31.Length
    let v33 : (string []) = Array.zeroCreate<string> (v32)
    let v34 : Mut5 = {l0 = 0} : Mut5
    while method26(v32, v34) do
        let v36 : int32 = v34.l0
        let v37 : string = v31.[int v36]
        let v38 : string = v37.Trim ()
        v33.[int v36] <- v38
        let v39 : int32 = v36 + 1
        v34.l0 <- v39
        ()
    let v40 : int32 = v33.Length
    let v41 : (string []) = Array.zeroCreate<string> (v40)
    let v42 : Mut6 = {l0 = 0; l1 = 0} : Mut6
    while method76(v40, v42) do
        let v44 : int32 = v42.l0
        let v45 : int32 = v42.l1
        let v46 : string = v33.[int v44]
        let v47 : string = ""
        let v48 : bool = v47 <> v46
        let v50 : int32 =
            if v48 then
                v41.[int v45] <- v46
                let v49 : int32 = v45 + 1
                v49
            else
                v45
        let v51 : int32 = v44 + 1
        v42.l0 <- v51
        v42.l1 <- v50
        ()
    let v52 : int32 = v42.l1
    let v53 : (string []) = Array.zeroCreate<string> (v52)
    let v54 : Mut5 = {l0 = 0} : Mut5
    while method26(v52, v54) do
        let v56 : int32 = v54.l0
        let v57 : string = v41.[int v56]
        v53.[int v56] <- v57
        let v58 : int32 = v56 + 1
        v54.l0 <- v58
        ()
    let v59 : string seq = seq { for i = 0 to v53.Length - 1 do yield v53.[i] }
    let v60 : string = method72()
    let v61 : (string -> (string seq -> string)) = String.concat
    let v62 : (string seq -> string) = v61 v60
    let v63 : string = v62 v59
    let v64 : string = $"{v63}

"
    let v65 : string option = None
    let v66 : System.Threading.CancellationToken option = None
    let v67 : (struct (string * string) []) = [||]
    let v68 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v69 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v70 : bool option = None
    let v71 : bool = true in let mutable _v70 = v70
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v72 : string = "cfg!(windows)"
    let v73 : bool = Fable.Core.RustInterop.emitRustExpr () v72
    v73
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v74 : bool = null |> unbox<bool>
    v74
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v75 : bool = null |> unbox<bool>
    v75
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v76 : bool = null |> unbox<bool>
    v76
#endif
    
#if FABLE_COMPILER_PYTHON
    let v77 : bool = null |> unbox<bool>
    v77
#endif
    
#else
    let v78 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v79 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v80 : bool = v79 v78
    v80
#endif
    |> fun x -> _v70 <- Some x
    let v81 : bool = _v70.Value
    let v84 : string =
        if v81 then
            let v82 : string = ".exe"
            v82
        else
            let v83 : string = ""
            v83
    let v85 : string = $"../vault/deps/hangulize/cmd/hangulize/hangulize{v84}"
    let v86 : string = method13(v0, v85)
    let v87 : string = $"{v86} {v1}"
    let v88 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = closure61(v64)
    let v89 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = Some v88 
    let v90 : struct (int32 * string) option = None
    let v91 : bool = true in let mutable _v90 = v90
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v92 : string = method39(v66, v87, v67, v68, v89, v65)
    let struct (v93 : string, v94 : string) = method40()
    let v95 : int32 = v92.Length
    let v96 : (char []) = Array.zeroCreate<char> (v95)
    let v97 : Mut5 = {l0 = 0} : Mut5
    while method26(v95, v97) do
        let v99 : int32 = v97.l0
        let v100 : char = v92.[int v99]
        v96.[int v99] <- v100
        let v101 : int32 = v99 + 1
        v97.l0 <- v101
        ()
    let v102 : ((char []) -> char list) = Array.toList
    let v103 : char list = v102 v96
    let v104 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v105 : (char -> (UH0 -> UH0)) = method41()
    let v106 : (char list -> (UH0 -> UH0)) = v104 v105
    let v107 : (UH0 -> UH0) = v106 v103
    let v108 : UH0 = UH0_0
    let v109 : UH0 = v107 v108
    let v110 : US8 = US8_0
    let struct (v111 : string, v112 : string) = method42(v94, v93, v109, v110)
    let v113 : (string []) = method43(v112)
    let v114 : string = "$0.to_vec()"
    let v115 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v113 v114
    let v116 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v117 : (string -> std_string_String) = closure28()
    let v118 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v115, v117) v116
    let v119 : US0 = US0_1
    let v120 : (unit -> string) = closure29(v66, v87, v67, v68, v89, v65, v111, v118)
    let v121 : (unit -> string) = method48()
    method3(v119, v120, v121)
    let v122 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method49(v66, v87, v67, v68, v89, v65, v111, v118)
    let v123 : string = "futures_lite::future::block_on($0)"
    let v124 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v122 v123
    let (a, b) = v124
    let v125 : int32 = a
    let v126 : string = b
    struct (v125, v126)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v127 : int32, v128 : string) = null |> unbox<struct (int32 * string)>
    struct (v127, v128)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v129 : int32, v130 : string) = null |> unbox<struct (int32 * string)>
    struct (v129, v130)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v131 : int32, v132 : string) = null |> unbox<struct (int32 * string)>
    struct (v131, v132)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v133 : int32, v134 : string) = null |> unbox<struct (int32 * string)>
    struct (v133, v134)
#endif
    
#else
    let v135 : Async<struct (int32 * string)> option = None
    let v136 : bool = true in let mutable _v135 = v135
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v137 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v137
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v138 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v138
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v139 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v139
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v140 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v140
#endif
    
#if FABLE_COMPILER_PYTHON
    let v141 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v141
#endif
    
#else
    let v142 : Async<struct (int32 * string)> option = None
    let v143 : bool = true in let mutable _v142 = v142
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v144 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v144
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v145 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v145
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v146 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v146
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v147 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v147
#endif
    
#if FABLE_COMPILER_PYTHON
    let v148 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v148
#endif
    
#else
    let v149 : Async<struct (int32 * string)> option = None
    let mutable _v149 = v149
    async {
    let struct (v150 : string, v151 : string) = method40()
    let v152 : int32 = v87.Length
    let v153 : (char []) = Array.zeroCreate<char> (v152)
    let v154 : Mut5 = {l0 = 0} : Mut5
    while method26(v152, v154) do
        let v156 : int32 = v154.l0
        let v157 : char = v87.[int v156]
        v153.[int v156] <- v157
        let v158 : int32 = v156 + 1
        v154.l0 <- v158
        ()
    let v159 : ((char []) -> char list) = Array.toList
    let v160 : char list = v159 v153
    let v161 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v162 : (char -> (UH0 -> UH0)) = method41()
    let v163 : (char list -> (UH0 -> UH0)) = v161 v162
    let v164 : (UH0 -> UH0) = v163 v160
    let v165 : UH0 = UH0_0
    let v166 : UH0 = v164 v165
    let v167 : US8 = US8_0
    let struct (v168 : string, v169 : string) = method42(v151, v150, v166, v167)
    let v170 : (string -> US4) = method19()
    let v171 : US4 = US4_1
    let v172 : US4 = v65 |> Option.map v170 |> Option.defaultValue v171 
    let v176 : string =
        match v172 with
        | US4_1 -> (* None *)
            let v174 : string = ""
            v174
        | US4_0(v173) -> (* Some *)
            v173
    let v177 : US0 = US0_1
    let v178 : (unit -> string) = closure48(v66, v87, v67, v68, v89, v65)
    let v179 : (unit -> string) = method48()
    method3(v177, v178, v179)
    let v180 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v181 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v169, StandardOutputEncoding = v180, WorkingDirectory = v176, FileName = v168, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v182 : int32 = v67.Length
    let v183 : Mut5 = {l0 = 0} : Mut5
    while method26(v182, v183) do
        let v185 : int32 = v183.l0
        let struct (v186 : string, v187 : string) = v67.[int v185]
        v181.EnvironmentVariables.[v186] <- v187 
        let v188 : int32 = v185 + 1
        v183.l0 <- v188
        ()
    let v189 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v181)
    use v189 = v189 
    let v190 : System.Diagnostics.Process = v189 
    let v191 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v192 : System.Collections.Concurrent.ConcurrentStack<string> = v191 ()
    let v193 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v66, v87, v67, v68, v89, v65, v190, v192)
    v190.OutputDataReceived.Add v193 
    let v194 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v66, v87, v67, v68, v89, v65, v190, v192)
    v190.ErrorDataReceived.Add v194 
    let v195 : (unit -> bool) = v190.Start
    let v196 : bool = v195 ()
    let v197 : bool = v196 = false
    if v197 then
        let v198 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v198
    let v199 : (unit -> unit) = v190.BeginErrorReadLine
    v199 ()
    let v200 : (unit -> unit) = v190.BeginOutputReadLine
    v200 ()
    let v201 : (System.Threading.CancellationToken -> US18) = method71()
    let v202 : US18 = US18_1
    let v203 : US18 = v66 |> Option.map v201 |> Option.defaultValue v202 
    let v207 : System.Threading.CancellationToken =
        match v203 with
        | US18_1 -> (* None *)
            let v205 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v205
        | US18_0(v204) -> (* Some *)
            v204
    let v208 : Async<System.Threading.CancellationToken> option = None
    let v209 : bool = true in let mutable _v208 = v208
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v210 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v210
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v211 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v211
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v212 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v212
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v213 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v213
#endif
    
#if FABLE_COMPILER_PYTHON
    let v214 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v214
#endif
    
#else
    let v215 : Async<System.Threading.CancellationToken> option = None
    let v216 : bool = true in let mutable _v215 = v215
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v217 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v217
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v218 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v218
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v219 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v219
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v220 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v220
#endif
    
#if FABLE_COMPILER_PYTHON
    let v221 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v221
#endif
    
#else
    let v222 : Async<System.Threading.CancellationToken> option = None
    let mutable _v222 = v222
    async {
    let v223 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v223 = v223 
    let v224 : System.Threading.CancellationToken = v223 
    let v225 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v226 : (System.Threading.CancellationToken []) = [|v224; v225; v207|]
    let v227 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v228 : System.Threading.CancellationTokenSource = v227 v226
    let v229 : System.Threading.CancellationToken = v228.Token
    return v229 
    }
    |> fun x -> _v222 <- Some x
    let v230 : Async<System.Threading.CancellationToken> = _v222 |> Option.get
    v230
#endif
    |> fun x -> _v215 <- Some x
    let v231 : Async<System.Threading.CancellationToken> = _v215.Value
    v231
#endif
    |> fun x -> _v208 <- Some x
    let v232 : Async<System.Threading.CancellationToken> = _v208.Value
    let! v232 = v232 
    let v233 : System.Threading.CancellationToken = v232 
    let v234 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v233.Register
    let v235 : (unit -> unit) = closure54(v190)
    let v236 : System.Threading.CancellationTokenRegistration = v234 v235
    use v236 = v236 
    let v237 : System.Threading.CancellationTokenRegistration = v236 
    let v238 : Async<int32> option = None
    let v239 : bool = true in let mutable _v238 = v238
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v240 : Async<int32> = null |> unbox<Async<int32>>
    v240
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v241 : Async<int32> = null |> unbox<Async<int32>>
    v241
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v242 : Async<int32> = null |> unbox<Async<int32>>
    v242
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v243 : Async<int32> = null |> unbox<Async<int32>>
    v243
#endif
    
#if FABLE_COMPILER_PYTHON
    let v244 : Async<int32> = null |> unbox<Async<int32>>
    v244
#endif
    
#else
    let v245 : Async<int32> option = None
    let mutable _v245 = v245
    async {
    try
    let v246 : System.Threading.Tasks.Task = v190.WaitForExitAsync v233 
    let v247 : Async<unit> option = None
    let v248 : bool = true in let mutable _v247 = v247
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v249 : Async<unit> = null |> unbox<Async<unit>>
    v249
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v250 : Async<unit> = null |> unbox<Async<unit>>
    v250
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v251 : Async<unit> = null |> unbox<Async<unit>>
    v251
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v252 : Async<unit> = null |> unbox<Async<unit>>
    v252
#endif
    
#if FABLE_COMPILER_PYTHON
    let v253 : Async<unit> = null |> unbox<Async<unit>>
    v253
#endif
    
#else
    let v254 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v255 : Async<unit> = v254 v246
    v255
#endif
    |> fun x -> _v247 <- Some x
    let v256 : Async<unit> = _v247.Value
    do! v256 
    let v257 : int32 = v190.ExitCode
    return v257 
    with ex ->
    let v258 : exn = ex
    let v259 : string option = None
    let v260 : bool = true in let mutable _v259 = v259
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v261 : string = $"%A{v258}"
    v261
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v262 : string = $"%A{v258}"
    v262
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v263 : string = $"%A{v258}"
    v263
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v264 : string = $"%A{v258}"
    v264
#endif
    
#if FABLE_COMPILER_PYTHON
    let v265 : string = $"%A{v258}"
    v265
#endif
    
#else
    let v266 : string = $"{v258.GetType ()}: {v258.Message}"
    v266
#endif
    |> fun x -> _v259 <- Some x
    let v267 : string = _v259.Value
    let v268 : (string -> unit) = v192.Push
    v268 v267
    let v269 : System.Threading.Tasks.TaskCanceledException = v258 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v270 : US0 = US0_3
    let v271 : (unit -> string) = closure55(v269)
    let v272 : (unit -> string) = method48()
    method3(v270, v271, v272)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v245 <- Some x
    let v273 : Async<int32> = _v245 |> Option.get
    v273
#endif
    |> fun x -> _v238 <- Some x
    let v274 : Async<int32> = _v238.Value
    let! v274 = v274 
    let v275 : int32 = v274 
    let v276 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v277 : string seq = v276 v192
    let v278 : string = method72()
    let v279 : (string -> (string seq -> string)) = String.concat
    let v280 : (string seq -> string) = v279 v278
    let v281 : string = v280 v277
    let v282 : US0 = US0_1
    let v283 : (unit -> string) = closure56(v275, v281)
    let v284 : (unit -> string) = method48()
    method3(v282, v283, v284)
    return struct (v275, v281) 
    }
    |> fun x -> _v149 <- Some x
    let v285 : Async<struct (int32 * string)> = _v149 |> Option.get
    v285
#endif
    |> fun x -> _v142 <- Some x
    let v286 : Async<struct (int32 * string)> = _v142.Value
    v286
#endif
    |> fun x -> _v135 <- Some x
    let v287 : Async<struct (int32 * string)> = _v135.Value
    let v288 : struct (int32 * string) option = None
    let v289 : bool = true in let mutable _v288 = v288
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v290 : int32, v291 : string) = null |> unbox<struct (int32 * string)>
    struct (v290, v291)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v292 : int32, v293 : string) = null |> unbox<struct (int32 * string)>
    struct (v292, v293)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v294 : int32, v295 : string) = null |> unbox<struct (int32 * string)>
    struct (v294, v295)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v296 : int32, v297 : string) = null |> unbox<struct (int32 * string)>
    struct (v296, v297)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v298 : int32, v299 : string) = null |> unbox<struct (int32 * string)>
    struct (v298, v299)
#endif
    
#else
    let v300 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v301 : int32, v302 : string) = v300 v287
    struct (v301, v302)
#endif
    |> fun x -> _v288 <- Some x
    let struct (v303 : int32, v304 : string) = _v288.Value
    struct (v303, v304)
#endif
    |> fun x -> _v90 <- Some x
    let struct (v305 : int32, v306 : string) = _v90.Value
    let v307 : (string []) = v306.Split v30
    let v308 : int32 = v307.Length
    let v309 : string = ""
    let v310 : Mut7 = {l0 = 0; l1 = v309; l2 = 0; l3 = 0} : Mut7
    while method79(v40, v310) do
        let v312 : int32 = v310.l0
        let struct (v313 : string, v314 : int32, v315 : int32) = v310.l1, v310.l2, v310.l3
        let v316 : string = v33.[int v312]
        let v317 : bool = v316 = ""
        let struct (v331 : string, v332 : int32, v333 : int32) =
            if v317 then
                let v318 : string = $"{v313}
"
                let v319 : int32 = v314 + 1
                let v320 : int32 = v315 + 1
                struct (v318, v319, v320)
            else
                let v321 : int32 = v314 - v315
                let v322 : bool = v321 >= v308
                let v329 : string =
                    if v322 then
                        v313
                    else
                        let v323 : string = v307.[int v321]
                        let v324 : int32 = v308 - 1
                        let v325 : bool = v321 = v324
                        if v325 then
                            let v326 : string = $"{v313}{v323}"
                            v326
                        else
                            let v327 : string = $"{v313}{v323}
"
                            v327
                let v330 : int32 = v314 + 1
                struct (v329, v330, v315)
        let v334 : int32 = v312 + 1
        v310.l0 <- v334
        v310.l1 <- v331
        v310.l2 <- v332
        v310.l3 <- v333
        ()
    let struct (v335 : string, v336 : int32, v337 : int32) = v310.l1, v310.l2, v310.l3
    let v338 : unit option = None
    let v339 : bool = true in let mutable _v338 = v338
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v340 : string = "std::fs::write(&*$0, &*$1).unwrap()"
    Fable.Core.RustInterop.emitRustExpr struct (v2, v335) v340
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
    let v341 : string = method80(v335)
    System.IO.File.WriteAllText (v2, v341)
    ()
#endif
    |> fun x -> _v338 <- Some x
    _v338.Value
    let v342 : US0 = US0_2
    let v343 : (unit -> string) = closure62()
    let v344 : (unit -> string) = closure63(v2, v305, v335)
    method3(v342, v343, v344)
    US21_0(v305, v335)
and closure64 () () : string =
    let v0 : string = "documents.files_fn / error"
    v0
and closure65 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: %A{v1} / result: {v0} / {v2 ()}"
    v3
and closure60 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : US19 =
    let struct (v6 : string, v7 : string) = method73(v5, v4, v0)
    let v8 : bool option = None
    let v9 : bool = true in let mutable _v8 = v8
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : string = method14(v7)
    let v11 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v10 v11
    let v13 : string = "String::from($0)"
    let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "std::path::PathBuf::from($0)"
    let v16 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "$0.exists()"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v21 : bool =
        if v18 then
            let v19 : string = "$0.is_file()"
            let v20 : bool = Fable.Core.RustInterop.emitRustExpr v16 v19
            v20
        else
            false
    v21
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v22 : bool = null |> unbox<bool>
    v22
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : bool = null |> unbox<bool>
    v23
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v24 : string = "fs"
    let v25 : IFsExistsSync = Fable.Core.JsInterop.importAll v24
    let v26 : string = "$0.existsSync($1)"
    let v27 : bool = Fable.Core.JsInterop.emitJsExpr struct (v25, v7) v26
    v27
#endif
    
#if FABLE_COMPILER_PYTHON
    let v28 : bool = null |> unbox<bool>
    v28
#endif
    
#else
    let v29 : (string -> bool) = System.IO.File.Exists
    let v30 : bool = v29 v7
    v30
#endif
    |> fun x -> _v8 <- Some x
    let v31 : bool = _v8.Value
    let v55 : bool =
        if v31 then
            let v32 : bool option = None
            let v33 : bool = true in let mutable _v32 = v32
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v34 : string = method14(v6)
            let v35 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v36 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v34 v35
            let v37 : string = "String::from($0)"
            let v38 : std_string_String = Fable.Core.RustInterop.emitRustExpr v36 v37
            let v39 : string = "std::path::PathBuf::from($0)"
            let v40 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v38 v39
            let v41 : string = "$0.exists()"
            let v42 : bool = Fable.Core.RustInterop.emitRustExpr v40 v41
            let v45 : bool =
                if v42 then
                    let v43 : string = "$0.is_file()"
                    let v44 : bool = Fable.Core.RustInterop.emitRustExpr v40 v43
                    v44
                else
                    false
            v45
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v46 : bool = null |> unbox<bool>
            v46
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v47 : bool = null |> unbox<bool>
            v47
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v48 : IFsExistsSync = Fable.Core.JsInterop.importAll v24
            let v49 : string = "$0.existsSync($1)"
            let v50 : bool = Fable.Core.JsInterop.emitJsExpr struct (v48, v6) v49
            v50
#endif
            
#if FABLE_COMPILER_PYTHON
            let v51 : bool = null |> unbox<bool>
            v51
#endif
            
#else
            let v52 : (string -> bool) = System.IO.File.Exists
            let v53 : bool = v52 v6
            v53
#endif
            |> fun x -> _v32 <- Some x
            let v54 : bool = _v32.Value
            v54
        else
            false
    let v562 : bool =
        if v55 then
            let v56 : string option = None
            let v57 : bool = true in let mutable _v56 = v56
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v58 : string = method22()
            let v59 : string = method23(v7)
            let v60 : string = method24()
            let v61 : string = $"regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v62 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v58, v59, v60) v61
            let v63 : string = "String::from($0)"
            let v64 : std_string_String = Fable.Core.RustInterop.emitRustExpr v62 v63
            let v65 : string = "fable_library_rust::String_::fromString($0)"
            let v66 : string = Fable.Core.RustInterop.emitRustExpr v64 v65
            v66
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v67 : string = null |> unbox<string>
            v67
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v68 : string = null |> unbox<string>
            v68
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v69 : string = null |> unbox<string>
            v69
#endif
            
#if FABLE_COMPILER_PYTHON
            let v70 : string = null |> unbox<string>
            v70
#endif
            
#else
            let v71 : string = "^\\\\\\\\\\?\\\\"
            let v72 : string = ""
            let v73 : string = System.Text.RegularExpressions.Regex.Replace (v7, v71, v72)
            v73
#endif
            |> fun x -> _v56 <- Some x
            let v74 : string = _v56.Value
            let v75 : string = $"{v74.[0] |> string |> _.ToLower()}{v74.[1..]}"
            let v76 : string = "\\"
            let v77 : string = "/"
            let v78 : string = v75.Replace (v76, v77)
            let v79 : string option = None
            let v80 : System.Threading.CancellationToken option = None
            let v81 : (struct (string * string) []) = [||]
            let v82 : (struct (bool * string * int32) -> Async<unit>) option = None
            let v83 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
            let v84 : string = $"pwsh -c \"(Get-FileHash \\\"{v78}\\\" -Algorithm SHA256).Hash\""
            let v85 : struct (int32 * string) option = None
            let v86 : bool = true in let mutable _v85 = v85
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v87 : string = method39(v80, v84, v81, v82, v83, v79)
            let struct (v88 : string, v89 : string) = method40()
            let v90 : int32 = v87.Length
            let v91 : (char []) = Array.zeroCreate<char> (v90)
            let v92 : Mut5 = {l0 = 0} : Mut5
            while method26(v90, v92) do
                let v94 : int32 = v92.l0
                let v95 : char = v87.[int v94]
                v91.[int v94] <- v95
                let v96 : int32 = v94 + 1
                v92.l0 <- v96
                ()
            let v97 : ((char []) -> char list) = Array.toList
            let v98 : char list = v97 v91
            let v99 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v100 : (char -> (UH0 -> UH0)) = method41()
            let v101 : (char list -> (UH0 -> UH0)) = v99 v100
            let v102 : (UH0 -> UH0) = v101 v98
            let v103 : UH0 = UH0_0
            let v104 : UH0 = v102 v103
            let v105 : US8 = US8_0
            let struct (v106 : string, v107 : string) = method42(v89, v88, v104, v105)
            let v108 : (string []) = method43(v107)
            let v109 : string = "$0.to_vec()"
            let v110 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v108 v109
            let v111 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v112 : (string -> std_string_String) = closure28()
            let v113 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v110, v112) v111
            let v114 : US0 = US0_1
            let v115 : (unit -> string) = closure29(v80, v84, v81, v82, v83, v79, v106, v113)
            let v116 : (unit -> string) = method48()
            method3(v114, v115, v116)
            let v117 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method49(v80, v84, v81, v82, v83, v79, v106, v113)
            let v118 : string = "futures_lite::future::block_on($0)"
            let v119 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v117 v118
            let (a, b) = v119
            let v120 : int32 = a
            let v121 : string = b
            struct (v120, v121)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v122 : int32, v123 : string) = null |> unbox<struct (int32 * string)>
            struct (v122, v123)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v124 : int32, v125 : string) = null |> unbox<struct (int32 * string)>
            struct (v124, v125)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v126 : int32, v127 : string) = null |> unbox<struct (int32 * string)>
            struct (v126, v127)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v128 : int32, v129 : string) = null |> unbox<struct (int32 * string)>
            struct (v128, v129)
#endif
            
#else
            let v130 : Async<struct (int32 * string)> option = None
            let v131 : bool = true in let mutable _v130 = v130
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v132 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v132
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v133 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v133
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v134 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v134
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v135 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v135
#endif
            
#if FABLE_COMPILER_PYTHON
            let v136 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v136
#endif
            
#else
            let v137 : Async<struct (int32 * string)> option = None
            let v138 : bool = true in let mutable _v137 = v137
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v139 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v139
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v140 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v140
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v141 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v141
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v142 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v142
#endif
            
#if FABLE_COMPILER_PYTHON
            let v143 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v143
#endif
            
#else
            let v144 : Async<struct (int32 * string)> option = None
            let mutable _v144 = v144
            async {
            let struct (v145 : string, v146 : string) = method40()
            let v147 : int32 = v84.Length
            let v148 : (char []) = Array.zeroCreate<char> (v147)
            let v149 : Mut5 = {l0 = 0} : Mut5
            while method26(v147, v149) do
                let v151 : int32 = v149.l0
                let v152 : char = v84.[int v151]
                v148.[int v151] <- v152
                let v153 : int32 = v151 + 1
                v149.l0 <- v153
                ()
            let v154 : ((char []) -> char list) = Array.toList
            let v155 : char list = v154 v148
            let v156 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v157 : (char -> (UH0 -> UH0)) = method41()
            let v158 : (char list -> (UH0 -> UH0)) = v156 v157
            let v159 : (UH0 -> UH0) = v158 v155
            let v160 : UH0 = UH0_0
            let v161 : UH0 = v159 v160
            let v162 : US8 = US8_0
            let struct (v163 : string, v164 : string) = method42(v146, v145, v161, v162)
            let v165 : (string -> US4) = method19()
            let v166 : US4 = US4_1
            let v167 : US4 = v79 |> Option.map v165 |> Option.defaultValue v166 
            let v170 : string =
                match v167 with
                | US4_1 -> (* None *)
                    v72
                | US4_0(v168) -> (* Some *)
                    v168
            let v171 : US0 = US0_1
            let v172 : (unit -> string) = closure48(v80, v84, v81, v82, v83, v79)
            let v173 : (unit -> string) = method48()
            method3(v171, v172, v173)
            let v174 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v175 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v164, StandardOutputEncoding = v174, WorkingDirectory = v170, FileName = v163, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v176 : int32 = v81.Length
            let v177 : Mut5 = {l0 = 0} : Mut5
            while method26(v176, v177) do
                let v179 : int32 = v177.l0
                let struct (v180 : string, v181 : string) = v81.[int v179]
                v175.EnvironmentVariables.[v180] <- v181 
                let v182 : int32 = v179 + 1
                v177.l0 <- v182
                ()
            let v183 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v175)
            use v183 = v183 
            let v184 : System.Diagnostics.Process = v183 
            let v185 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v186 : System.Collections.Concurrent.ConcurrentStack<string> = v185 ()
            let v187 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v80, v84, v81, v82, v83, v79, v184, v186)
            v184.OutputDataReceived.Add v187 
            let v188 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v80, v84, v81, v82, v83, v79, v184, v186)
            v184.ErrorDataReceived.Add v188 
            let v189 : (unit -> bool) = v184.Start
            let v190 : bool = v189 ()
            let v191 : bool = v190 = false
            if v191 then
                let v192 : string = $"execute_with_options_async / process_start error"
                failwith<unit> v192
            let v193 : (unit -> unit) = v184.BeginErrorReadLine
            v193 ()
            let v194 : (unit -> unit) = v184.BeginOutputReadLine
            v194 ()
            let v195 : (System.Threading.CancellationToken -> US18) = method71()
            let v196 : US18 = US18_1
            let v197 : US18 = v80 |> Option.map v195 |> Option.defaultValue v196 
            let v201 : System.Threading.CancellationToken =
                match v197 with
                | US18_1 -> (* None *)
                    let v199 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v199
                | US18_0(v198) -> (* Some *)
                    v198
            let v202 : Async<System.Threading.CancellationToken> option = None
            let v203 : bool = true in let mutable _v202 = v202
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v204 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v204
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v205 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v205
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v206 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v206
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v207 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v207
#endif
            
#if FABLE_COMPILER_PYTHON
            let v208 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v208
#endif
            
#else
            let v209 : Async<System.Threading.CancellationToken> option = None
            let v210 : bool = true in let mutable _v209 = v209
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v211 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v211
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v212 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v212
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v213 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v213
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v214 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v214
#endif
            
#if FABLE_COMPILER_PYTHON
            let v215 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v215
#endif
            
#else
            let v216 : Async<System.Threading.CancellationToken> option = None
            let mutable _v216 = v216
            async {
            let v217 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v217 = v217 
            let v218 : System.Threading.CancellationToken = v217 
            let v219 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v220 : (System.Threading.CancellationToken []) = [|v218; v219; v201|]
            let v221 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v222 : System.Threading.CancellationTokenSource = v221 v220
            let v223 : System.Threading.CancellationToken = v222.Token
            return v223 
            }
            |> fun x -> _v216 <- Some x
            let v224 : Async<System.Threading.CancellationToken> = _v216 |> Option.get
            v224
#endif
            |> fun x -> _v209 <- Some x
            let v225 : Async<System.Threading.CancellationToken> = _v209.Value
            v225
#endif
            |> fun x -> _v202 <- Some x
            let v226 : Async<System.Threading.CancellationToken> = _v202.Value
            let! v226 = v226 
            let v227 : System.Threading.CancellationToken = v226 
            let v228 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v227.Register
            let v229 : (unit -> unit) = closure54(v184)
            let v230 : System.Threading.CancellationTokenRegistration = v228 v229
            use v230 = v230 
            let v231 : System.Threading.CancellationTokenRegistration = v230 
            let v232 : Async<int32> option = None
            let v233 : bool = true in let mutable _v232 = v232
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v234 : Async<int32> = null |> unbox<Async<int32>>
            v234
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v235 : Async<int32> = null |> unbox<Async<int32>>
            v235
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v236 : Async<int32> = null |> unbox<Async<int32>>
            v236
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v237 : Async<int32> = null |> unbox<Async<int32>>
            v237
#endif
            
#if FABLE_COMPILER_PYTHON
            let v238 : Async<int32> = null |> unbox<Async<int32>>
            v238
#endif
            
#else
            let v239 : Async<int32> option = None
            let mutable _v239 = v239
            async {
            try
            let v240 : System.Threading.Tasks.Task = v184.WaitForExitAsync v227 
            let v241 : Async<unit> option = None
            let v242 : bool = true in let mutable _v241 = v241
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v243 : Async<unit> = null |> unbox<Async<unit>>
            v243
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v244 : Async<unit> = null |> unbox<Async<unit>>
            v244
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v245 : Async<unit> = null |> unbox<Async<unit>>
            v245
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v246 : Async<unit> = null |> unbox<Async<unit>>
            v246
#endif
            
#if FABLE_COMPILER_PYTHON
            let v247 : Async<unit> = null |> unbox<Async<unit>>
            v247
#endif
            
#else
            let v248 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v249 : Async<unit> = v248 v240
            v249
#endif
            |> fun x -> _v241 <- Some x
            let v250 : Async<unit> = _v241.Value
            do! v250 
            let v251 : int32 = v184.ExitCode
            return v251 
            with ex ->
            let v252 : exn = ex
            let v253 : string option = None
            let v254 : bool = true in let mutable _v253 = v253
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v255 : string = $"%A{v252}"
            v255
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v256 : string = $"%A{v252}"
            v256
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v257 : string = $"%A{v252}"
            v257
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v258 : string = $"%A{v252}"
            v258
#endif
            
#if FABLE_COMPILER_PYTHON
            let v259 : string = $"%A{v252}"
            v259
#endif
            
#else
            let v260 : string = $"{v252.GetType ()}: {v252.Message}"
            v260
#endif
            |> fun x -> _v253 <- Some x
            let v261 : string = _v253.Value
            let v262 : (string -> unit) = v186.Push
            v262 v261
            let v263 : System.Threading.Tasks.TaskCanceledException = v252 |> unbox<System.Threading.Tasks.TaskCanceledException>
            let v264 : US0 = US0_3
            let v265 : (unit -> string) = closure55(v263)
            let v266 : (unit -> string) = method48()
            method3(v264, v265, v266)
            return -2147483648 
            (*
            *)
            }
            |> fun x -> _v239 <- Some x
            let v267 : Async<int32> = _v239 |> Option.get
            v267
#endif
            |> fun x -> _v232 <- Some x
            let v268 : Async<int32> = _v232.Value
            let! v268 = v268 
            let v269 : int32 = v268 
            let v270 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v271 : string seq = v270 v186
            let v272 : string = method72()
            let v273 : (string -> (string seq -> string)) = String.concat
            let v274 : (string seq -> string) = v273 v272
            let v275 : string = v274 v271
            let v276 : US0 = US0_1
            let v277 : (unit -> string) = closure56(v269, v275)
            let v278 : (unit -> string) = method48()
            method3(v276, v277, v278)
            return struct (v269, v275) 
            }
            |> fun x -> _v144 <- Some x
            let v279 : Async<struct (int32 * string)> = _v144 |> Option.get
            v279
#endif
            |> fun x -> _v137 <- Some x
            let v280 : Async<struct (int32 * string)> = _v137.Value
            v280
#endif
            |> fun x -> _v130 <- Some x
            let v281 : Async<struct (int32 * string)> = _v130.Value
            let v282 : struct (int32 * string) option = None
            let v283 : bool = true in let mutable _v282 = v282
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v284 : int32, v285 : string) = null |> unbox<struct (int32 * string)>
            struct (v284, v285)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v286 : int32, v287 : string) = null |> unbox<struct (int32 * string)>
            struct (v286, v287)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v288 : int32, v289 : string) = null |> unbox<struct (int32 * string)>
            struct (v288, v289)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v290 : int32, v291 : string) = null |> unbox<struct (int32 * string)>
            struct (v290, v291)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v292 : int32, v293 : string) = null |> unbox<struct (int32 * string)>
            struct (v292, v293)
#endif
            
#else
            let v294 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
            let struct (v295 : int32, v296 : string) = v294 v281
            struct (v295, v296)
#endif
            |> fun x -> _v282 <- Some x
            let struct (v297 : int32, v298 : string) = _v282.Value
            struct (v297, v298)
#endif
            |> fun x -> _v85 <- Some x
            let struct (v299 : int32, v300 : string) = _v85.Value
            let v301 : bool = v299 = 0
            let v304 : US20 =
                if v301 then
                    US20_0(v300)
                else
                    US20_1(v300)
            let v310 : string =
                match v304 with
                | US20_1(v306) -> (* Error *)
                    let v307 : string = $"resultm.get / Result value was Error: {v306}"
                    failwith<string> v307
                | US20_0(v305) -> (* Ok *)
                    v305
            let v311 : string option = None
            let v312 : bool = true in let mutable _v311 = v311
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v313 : string = method22()
            let v314 : string = method23(v6)
            let v315 : string = method24()
            let v316 : string = $"regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v317 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v313, v314, v315) v316
            let v318 : string = "String::from($0)"
            let v319 : std_string_String = Fable.Core.RustInterop.emitRustExpr v317 v318
            let v320 : string = "fable_library_rust::String_::fromString($0)"
            let v321 : string = Fable.Core.RustInterop.emitRustExpr v319 v320
            v321
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v322 : string = null |> unbox<string>
            v322
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v323 : string = null |> unbox<string>
            v323
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v324 : string = null |> unbox<string>
            v324
#endif
            
#if FABLE_COMPILER_PYTHON
            let v325 : string = null |> unbox<string>
            v325
#endif
            
#else
            let v326 : string = System.Text.RegularExpressions.Regex.Replace (v6, v71, v72)
            v326
#endif
            |> fun x -> _v311 <- Some x
            let v327 : string = _v311.Value
            let v328 : string = $"{v327.[0] |> string |> _.ToLower()}{v327.[1..]}"
            let v329 : string = v328.Replace (v76, v77)
            let v330 : string option = None
            let v331 : System.Threading.CancellationToken option = None
            let v332 : (struct (string * string) []) = [||]
            let v333 : (struct (bool * string * int32) -> Async<unit>) option = None
            let v334 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
            let v335 : string = $"pwsh -c \"(Get-FileHash \\\"{v329}\\\" -Algorithm SHA256).Hash\""
            let v336 : struct (int32 * string) option = None
            let v337 : bool = true in let mutable _v336 = v336
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v338 : string = method39(v331, v335, v332, v333, v334, v330)
            let struct (v339 : string, v340 : string) = method40()
            let v341 : int32 = v338.Length
            let v342 : (char []) = Array.zeroCreate<char> (v341)
            let v343 : Mut5 = {l0 = 0} : Mut5
            while method26(v341, v343) do
                let v345 : int32 = v343.l0
                let v346 : char = v338.[int v345]
                v342.[int v345] <- v346
                let v347 : int32 = v345 + 1
                v343.l0 <- v347
                ()
            let v348 : ((char []) -> char list) = Array.toList
            let v349 : char list = v348 v342
            let v350 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v351 : (char -> (UH0 -> UH0)) = method41()
            let v352 : (char list -> (UH0 -> UH0)) = v350 v351
            let v353 : (UH0 -> UH0) = v352 v349
            let v354 : UH0 = UH0_0
            let v355 : UH0 = v353 v354
            let v356 : US8 = US8_0
            let struct (v357 : string, v358 : string) = method42(v340, v339, v355, v356)
            let v359 : (string []) = method43(v358)
            let v360 : string = "$0.to_vec()"
            let v361 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v359 v360
            let v362 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v363 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v361, v112) v362
            let v364 : US0 = US0_1
            let v365 : (unit -> string) = closure29(v331, v335, v332, v333, v334, v330, v357, v363)
            let v366 : (unit -> string) = method48()
            method3(v364, v365, v366)
            let v367 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method49(v331, v335, v332, v333, v334, v330, v357, v363)
            let v368 : string = "futures_lite::future::block_on($0)"
            let v369 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v367 v368
            let (a, b) = v369
            let v370 : int32 = a
            let v371 : string = b
            struct (v370, v371)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v372 : int32, v373 : string) = null |> unbox<struct (int32 * string)>
            struct (v372, v373)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v374 : int32, v375 : string) = null |> unbox<struct (int32 * string)>
            struct (v374, v375)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v376 : int32, v377 : string) = null |> unbox<struct (int32 * string)>
            struct (v376, v377)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v378 : int32, v379 : string) = null |> unbox<struct (int32 * string)>
            struct (v378, v379)
#endif
            
#else
            let v380 : Async<struct (int32 * string)> option = None
            let v381 : bool = true in let mutable _v380 = v380
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v382 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v382
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v383 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v383
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v384 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v384
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v385 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v385
#endif
            
#if FABLE_COMPILER_PYTHON
            let v386 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v386
#endif
            
#else
            let v387 : Async<struct (int32 * string)> option = None
            let v388 : bool = true in let mutable _v387 = v387
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v389 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v389
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v390 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v390
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v391 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v391
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v392 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v392
#endif
            
#if FABLE_COMPILER_PYTHON
            let v393 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v393
#endif
            
#else
            let v394 : Async<struct (int32 * string)> option = None
            let mutable _v394 = v394
            async {
            let struct (v395 : string, v396 : string) = method40()
            let v397 : int32 = v335.Length
            let v398 : (char []) = Array.zeroCreate<char> (v397)
            let v399 : Mut5 = {l0 = 0} : Mut5
            while method26(v397, v399) do
                let v401 : int32 = v399.l0
                let v402 : char = v335.[int v401]
                v398.[int v401] <- v402
                let v403 : int32 = v401 + 1
                v399.l0 <- v403
                ()
            let v404 : ((char []) -> char list) = Array.toList
            let v405 : char list = v404 v398
            let v406 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v407 : (char -> (UH0 -> UH0)) = method41()
            let v408 : (char list -> (UH0 -> UH0)) = v406 v407
            let v409 : (UH0 -> UH0) = v408 v405
            let v410 : UH0 = UH0_0
            let v411 : UH0 = v409 v410
            let v412 : US8 = US8_0
            let struct (v413 : string, v414 : string) = method42(v396, v395, v411, v412)
            let v415 : (string -> US4) = method19()
            let v416 : US4 = US4_1
            let v417 : US4 = v330 |> Option.map v415 |> Option.defaultValue v416 
            let v420 : string =
                match v417 with
                | US4_1 -> (* None *)
                    v72
                | US4_0(v418) -> (* Some *)
                    v418
            let v421 : US0 = US0_1
            let v422 : (unit -> string) = closure48(v331, v335, v332, v333, v334, v330)
            let v423 : (unit -> string) = method48()
            method3(v421, v422, v423)
            let v424 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v425 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v414, StandardOutputEncoding = v424, WorkingDirectory = v420, FileName = v413, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v426 : int32 = v332.Length
            let v427 : Mut5 = {l0 = 0} : Mut5
            while method26(v426, v427) do
                let v429 : int32 = v427.l0
                let struct (v430 : string, v431 : string) = v332.[int v429]
                v425.EnvironmentVariables.[v430] <- v431 
                let v432 : int32 = v429 + 1
                v427.l0 <- v432
                ()
            let v433 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v425)
            use v433 = v433 
            let v434 : System.Diagnostics.Process = v433 
            let v435 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v436 : System.Collections.Concurrent.ConcurrentStack<string> = v435 ()
            let v437 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v331, v335, v332, v333, v334, v330, v434, v436)
            v434.OutputDataReceived.Add v437 
            let v438 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v331, v335, v332, v333, v334, v330, v434, v436)
            v434.ErrorDataReceived.Add v438 
            let v439 : (unit -> bool) = v434.Start
            let v440 : bool = v439 ()
            let v441 : bool = v440 = false
            if v441 then
                let v442 : string = $"execute_with_options_async / process_start error"
                failwith<unit> v442
            let v443 : (unit -> unit) = v434.BeginErrorReadLine
            v443 ()
            let v444 : (unit -> unit) = v434.BeginOutputReadLine
            v444 ()
            let v445 : (System.Threading.CancellationToken -> US18) = method71()
            let v446 : US18 = US18_1
            let v447 : US18 = v331 |> Option.map v445 |> Option.defaultValue v446 
            let v451 : System.Threading.CancellationToken =
                match v447 with
                | US18_1 -> (* None *)
                    let v449 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v449
                | US18_0(v448) -> (* Some *)
                    v448
            let v452 : Async<System.Threading.CancellationToken> option = None
            let v453 : bool = true in let mutable _v452 = v452
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v454 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v454
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v455 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v455
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v456 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v456
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v457 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v457
#endif
            
#if FABLE_COMPILER_PYTHON
            let v458 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v458
#endif
            
#else
            let v459 : Async<System.Threading.CancellationToken> option = None
            let v460 : bool = true in let mutable _v459 = v459
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v461 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v461
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v462 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v462
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v463 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v463
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v464 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v464
#endif
            
#if FABLE_COMPILER_PYTHON
            let v465 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v465
#endif
            
#else
            let v466 : Async<System.Threading.CancellationToken> option = None
            let mutable _v466 = v466
            async {
            let v467 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v467 = v467 
            let v468 : System.Threading.CancellationToken = v467 
            let v469 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v470 : (System.Threading.CancellationToken []) = [|v468; v469; v451|]
            let v471 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v472 : System.Threading.CancellationTokenSource = v471 v470
            let v473 : System.Threading.CancellationToken = v472.Token
            return v473 
            }
            |> fun x -> _v466 <- Some x
            let v474 : Async<System.Threading.CancellationToken> = _v466 |> Option.get
            v474
#endif
            |> fun x -> _v459 <- Some x
            let v475 : Async<System.Threading.CancellationToken> = _v459.Value
            v475
#endif
            |> fun x -> _v452 <- Some x
            let v476 : Async<System.Threading.CancellationToken> = _v452.Value
            let! v476 = v476 
            let v477 : System.Threading.CancellationToken = v476 
            let v478 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v477.Register
            let v479 : (unit -> unit) = closure54(v434)
            let v480 : System.Threading.CancellationTokenRegistration = v478 v479
            use v480 = v480 
            let v481 : System.Threading.CancellationTokenRegistration = v480 
            let v482 : Async<int32> option = None
            let v483 : bool = true in let mutable _v482 = v482
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v484 : Async<int32> = null |> unbox<Async<int32>>
            v484
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v485 : Async<int32> = null |> unbox<Async<int32>>
            v485
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v486 : Async<int32> = null |> unbox<Async<int32>>
            v486
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v487 : Async<int32> = null |> unbox<Async<int32>>
            v487
#endif
            
#if FABLE_COMPILER_PYTHON
            let v488 : Async<int32> = null |> unbox<Async<int32>>
            v488
#endif
            
#else
            let v489 : Async<int32> option = None
            let mutable _v489 = v489
            async {
            try
            let v490 : System.Threading.Tasks.Task = v434.WaitForExitAsync v477 
            let v491 : Async<unit> option = None
            let v492 : bool = true in let mutable _v491 = v491
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v493 : Async<unit> = null |> unbox<Async<unit>>
            v493
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v494 : Async<unit> = null |> unbox<Async<unit>>
            v494
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v495 : Async<unit> = null |> unbox<Async<unit>>
            v495
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v496 : Async<unit> = null |> unbox<Async<unit>>
            v496
#endif
            
#if FABLE_COMPILER_PYTHON
            let v497 : Async<unit> = null |> unbox<Async<unit>>
            v497
#endif
            
#else
            let v498 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v499 : Async<unit> = v498 v490
            v499
#endif
            |> fun x -> _v491 <- Some x
            let v500 : Async<unit> = _v491.Value
            do! v500 
            let v501 : int32 = v434.ExitCode
            return v501 
            with ex ->
            let v502 : exn = ex
            let v503 : string option = None
            let v504 : bool = true in let mutable _v503 = v503
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v505 : string = $"%A{v502}"
            v505
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v506 : string = $"%A{v502}"
            v506
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v507 : string = $"%A{v502}"
            v507
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v508 : string = $"%A{v502}"
            v508
#endif
            
#if FABLE_COMPILER_PYTHON
            let v509 : string = $"%A{v502}"
            v509
#endif
            
#else
            let v510 : string = $"{v502.GetType ()}: {v502.Message}"
            v510
#endif
            |> fun x -> _v503 <- Some x
            let v511 : string = _v503.Value
            let v512 : (string -> unit) = v436.Push
            v512 v511
            let v513 : System.Threading.Tasks.TaskCanceledException = v502 |> unbox<System.Threading.Tasks.TaskCanceledException>
            let v514 : US0 = US0_3
            let v515 : (unit -> string) = closure55(v513)
            let v516 : (unit -> string) = method48()
            method3(v514, v515, v516)
            return -2147483648 
            (*
            *)
            }
            |> fun x -> _v489 <- Some x
            let v517 : Async<int32> = _v489 |> Option.get
            v517
#endif
            |> fun x -> _v482 <- Some x
            let v518 : Async<int32> = _v482.Value
            let! v518 = v518 
            let v519 : int32 = v518 
            let v520 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v521 : string seq = v520 v436
            let v522 : string = method72()
            let v523 : (string -> (string seq -> string)) = String.concat
            let v524 : (string seq -> string) = v523 v522
            let v525 : string = v524 v521
            let v526 : US0 = US0_1
            let v527 : (unit -> string) = closure56(v519, v525)
            let v528 : (unit -> string) = method48()
            method3(v526, v527, v528)
            return struct (v519, v525) 
            }
            |> fun x -> _v394 <- Some x
            let v529 : Async<struct (int32 * string)> = _v394 |> Option.get
            v529
#endif
            |> fun x -> _v387 <- Some x
            let v530 : Async<struct (int32 * string)> = _v387.Value
            v530
#endif
            |> fun x -> _v380 <- Some x
            let v531 : Async<struct (int32 * string)> = _v380.Value
            let v532 : struct (int32 * string) option = None
            let v533 : bool = true in let mutable _v532 = v532
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v534 : int32, v535 : string) = null |> unbox<struct (int32 * string)>
            struct (v534, v535)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v536 : int32, v537 : string) = null |> unbox<struct (int32 * string)>
            struct (v536, v537)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v538 : int32, v539 : string) = null |> unbox<struct (int32 * string)>
            struct (v538, v539)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v540 : int32, v541 : string) = null |> unbox<struct (int32 * string)>
            struct (v540, v541)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v542 : int32, v543 : string) = null |> unbox<struct (int32 * string)>
            struct (v542, v543)
#endif
            
#else
            let v544 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
            let struct (v545 : int32, v546 : string) = v544 v531
            struct (v545, v546)
#endif
            |> fun x -> _v532 <- Some x
            let struct (v547 : int32, v548 : string) = _v532.Value
            struct (v547, v548)
#endif
            |> fun x -> _v336 <- Some x
            let struct (v549 : int32, v550 : string) = _v336.Value
            let v551 : bool = v549 = 0
            let v554 : US20 =
                if v551 then
                    US20_0(v550)
                else
                    US20_1(v550)
            let v560 : string =
                match v554 with
                | US20_1(v556) -> (* Error *)
                    let v557 : string = $"resultm.get / Result value was Error: {v556}"
                    failwith<string> v557
                | US20_0(v555) -> (* Ok *)
                    v555
            let v561 : bool = v310 = v560
            v561
        else
            false
    let v563 : bool = v562 = false
    if v563 then
        let v564 : US21 = method75(v2, v3, v7, v4)
        match v564 with
        | US21_1(v608, v609) -> (* Error *)
            let v610 : (string * string) = v7, v609
            let v611 : Result<string, (string * string)> = Error v610
            US19_0(v611)
        | US21_0(v565, v566) -> (* Ok *)
            let v567 : bool = v565 <> 0
            if v567 then
                let v568 : US0 = US0_2
                let v569 : (unit -> string) = closure64()
                let v570 : (unit -> string) = closure65(v566, v565)
                method3(v568, v569, v570)
                let v571 : (string * string) = v7, v566
                let v572 : Result<string, (string * string)> = Error v571
                US19_0(v572)
            else
                let v574 : bool option = None
                let v575 : bool = true in let mutable _v574 = v574
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v576 : string = method14(v7)
                let v577 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                let v578 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v576 v577
                let v579 : string = "String::from($0)"
                let v580 : std_string_String = Fable.Core.RustInterop.emitRustExpr v578 v579
                let v581 : string = "std::path::PathBuf::from($0)"
                let v582 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v580 v581
                let v583 : string = "$0.exists()"
                let v584 : bool = Fable.Core.RustInterop.emitRustExpr v582 v583
                let v587 : bool =
                    if v584 then
                        let v585 : string = "$0.is_file()"
                        let v586 : bool = Fable.Core.RustInterop.emitRustExpr v582 v585
                        v586
                    else
                        false
                v587
#endif
                
#if FABLE_COMPILER_RUST && WASM
                let v588 : bool = null |> unbox<bool>
                v588
#endif
                
#if FABLE_COMPILER_RUST && CONTRACT
                let v589 : bool = null |> unbox<bool>
                v589
#endif
                
#if FABLE_COMPILER_TYPESCRIPT
                let v590 : IFsExistsSync = Fable.Core.JsInterop.importAll v24
                let v591 : string = "$0.existsSync($1)"
                let v592 : bool = Fable.Core.JsInterop.emitJsExpr struct (v590, v7) v591
                v592
#endif
                
#if FABLE_COMPILER_PYTHON
                let v593 : bool = null |> unbox<bool>
                v593
#endif
                
#else
                let v594 : (string -> bool) = System.IO.File.Exists
                let v595 : bool = v594 v7
                v595
#endif
                |> fun x -> _v574 <- Some x
                let v596 : bool = _v574.Value
                if v596 then
                    let v597 : unit option = None
                    let v598 : bool = true in let mutable _v597 = v597
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v599 : string = method74(v6)
                    let v600 : string = "std::fs::copy(&*$0, &*v599)"
                    let v601 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v7 v600
                    let v602 : string = "$0.unwrap()"
                    let v603 : uint64 = Fable.Core.RustInterop.emitRustExpr v601 v602
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
                    |> fun x -> _v597 <- Some x
                    _v597.Value
                    ()
                else
                    let v604 : string = $"documents.files_fn / {v7} should exist"
                    failwith<unit> v604
                let v605 : Result<string, (string * string)> = Ok v7
                US19_0(v605)
    else
        US19_1
and closure59 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : string) : (string -> US19) =
    closure60(v0, v1, v2, v3, v4)
and closure68 () () : string =
    let v0 : string = "documents.crowbook / result contains ERROR"
    v0
and closure69 (v0 : string, v1 : string, v2 : int32) () : string =
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"exit_code: %A{v2} / result: {v1} / output_path: {v0} / {v3 ()}"
    v4
and method81 (v0 : string, v1 : string, v2 : string, v3 : string) : US21 =
    let v4 : string = $"crowbook --single \"{v1}\" --output \"{v0}\" --to {v3} --set rendering.num_depth 6 html.css.add \\\"''' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} '''\\\""
    let v5 : string option = None
    let v6 : System.Threading.CancellationToken option = None
    let v7 : (struct (string * string) []) = [||]
    let v8 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v9 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v10 : string option = Some v2 
    let v11 : struct (int32 * string) option = None
    let v12 : bool = true in let mutable _v11 = v11
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : string = method39(v6, v4, v7, v8, v9, v10)
    let struct (v14 : string, v15 : string) = method40()
    let v16 : int32 = v13.Length
    let v17 : (char []) = Array.zeroCreate<char> (v16)
    let v18 : Mut5 = {l0 = 0} : Mut5
    while method26(v16, v18) do
        let v20 : int32 = v18.l0
        let v21 : char = v13.[int v20]
        v17.[int v20] <- v21
        let v22 : int32 = v20 + 1
        v18.l0 <- v22
        ()
    let v23 : ((char []) -> char list) = Array.toList
    let v24 : char list = v23 v17
    let v25 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v26 : (char -> (UH0 -> UH0)) = method41()
    let v27 : (char list -> (UH0 -> UH0)) = v25 v26
    let v28 : (UH0 -> UH0) = v27 v24
    let v29 : UH0 = UH0_0
    let v30 : UH0 = v28 v29
    let v31 : US8 = US8_0
    let struct (v32 : string, v33 : string) = method42(v15, v14, v30, v31)
    let v34 : (string []) = method43(v33)
    let v35 : string = "$0.to_vec()"
    let v36 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v34 v35
    let v37 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v38 : (string -> std_string_String) = closure28()
    let v39 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v36, v38) v37
    let v40 : US0 = US0_1
    let v41 : (unit -> string) = closure29(v6, v4, v7, v8, v9, v10, v32, v39)
    let v42 : (unit -> string) = method48()
    method3(v40, v41, v42)
    let v43 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method49(v6, v4, v7, v8, v9, v10, v32, v39)
    let v44 : string = "futures_lite::future::block_on($0)"
    let v45 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v43 v44
    let (a, b) = v45
    let v46 : int32 = a
    let v47 : string = b
    struct (v46, v47)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v48 : int32, v49 : string) = null |> unbox<struct (int32 * string)>
    struct (v48, v49)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v50 : int32, v51 : string) = null |> unbox<struct (int32 * string)>
    struct (v50, v51)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v52 : int32, v53 : string) = null |> unbox<struct (int32 * string)>
    struct (v52, v53)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v54 : int32, v55 : string) = null |> unbox<struct (int32 * string)>
    struct (v54, v55)
#endif
    
#else
    let v56 : Async<struct (int32 * string)> option = None
    let v57 : bool = true in let mutable _v56 = v56
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v58 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v58
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v59 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v59
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v60 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v60
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v61 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v61
#endif
    
#if FABLE_COMPILER_PYTHON
    let v62 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v62
#endif
    
#else
    let v63 : Async<struct (int32 * string)> option = None
    let v64 : bool = true in let mutable _v63 = v63
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v65 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v65
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v66 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v66
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v67
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v68 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v68
#endif
    
#if FABLE_COMPILER_PYTHON
    let v69 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v69
#endif
    
#else
    let v70 : Async<struct (int32 * string)> option = None
    let mutable _v70 = v70
    async {
    let struct (v71 : string, v72 : string) = method40()
    let v73 : int32 = v4.Length
    let v74 : (char []) = Array.zeroCreate<char> (v73)
    let v75 : Mut5 = {l0 = 0} : Mut5
    while method26(v73, v75) do
        let v77 : int32 = v75.l0
        let v78 : char = v4.[int v77]
        v74.[int v77] <- v78
        let v79 : int32 = v77 + 1
        v75.l0 <- v79
        ()
    let v80 : ((char []) -> char list) = Array.toList
    let v81 : char list = v80 v74
    let v82 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v83 : (char -> (UH0 -> UH0)) = method41()
    let v84 : (char list -> (UH0 -> UH0)) = v82 v83
    let v85 : (UH0 -> UH0) = v84 v81
    let v86 : UH0 = UH0_0
    let v87 : UH0 = v85 v86
    let v88 : US8 = US8_0
    let struct (v89 : string, v90 : string) = method42(v72, v71, v87, v88)
    let v91 : (string -> US4) = method19()
    let v92 : US4 = US4_1
    let v93 : US4 = v10 |> Option.map v91 |> Option.defaultValue v92 
    let v97 : string =
        match v93 with
        | US4_1 -> (* None *)
            let v95 : string = ""
            v95
        | US4_0(v94) -> (* Some *)
            v94
    let v98 : US0 = US0_1
    let v99 : (unit -> string) = closure48(v6, v4, v7, v8, v9, v10)
    let v100 : (unit -> string) = method48()
    method3(v98, v99, v100)
    let v101 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v102 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v90, StandardOutputEncoding = v101, WorkingDirectory = v97, FileName = v89, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v103 : int32 = v7.Length
    let v104 : Mut5 = {l0 = 0} : Mut5
    while method26(v103, v104) do
        let v106 : int32 = v104.l0
        let struct (v107 : string, v108 : string) = v7.[int v106]
        v102.EnvironmentVariables.[v107] <- v108 
        let v109 : int32 = v106 + 1
        v104.l0 <- v109
        ()
    let v110 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v102)
    use v110 = v110 
    let v111 : System.Diagnostics.Process = v110 
    let v112 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v113 : System.Collections.Concurrent.ConcurrentStack<string> = v112 ()
    let v114 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v6, v4, v7, v8, v9, v10, v111, v113)
    v111.OutputDataReceived.Add v114 
    let v115 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v6, v4, v7, v8, v9, v10, v111, v113)
    v111.ErrorDataReceived.Add v115 
    let v116 : (unit -> bool) = v111.Start
    let v117 : bool = v116 ()
    let v118 : bool = v117 = false
    if v118 then
        let v119 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v119
    let v120 : (unit -> unit) = v111.BeginErrorReadLine
    v120 ()
    let v121 : (unit -> unit) = v111.BeginOutputReadLine
    v121 ()
    let v122 : (System.Threading.CancellationToken -> US18) = method71()
    let v123 : US18 = US18_1
    let v124 : US18 = v6 |> Option.map v122 |> Option.defaultValue v123 
    let v128 : System.Threading.CancellationToken =
        match v124 with
        | US18_1 -> (* None *)
            let v126 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v126
        | US18_0(v125) -> (* Some *)
            v125
    let v129 : Async<System.Threading.CancellationToken> option = None
    let v130 : bool = true in let mutable _v129 = v129
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v131 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v131
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v132 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v132
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v133 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v133
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v134 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v134
#endif
    
#if FABLE_COMPILER_PYTHON
    let v135 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v135
#endif
    
#else
    let v136 : Async<System.Threading.CancellationToken> option = None
    let v137 : bool = true in let mutable _v136 = v136
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v138 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v138
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v139 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v139
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v140 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v140
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v141 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v141
#endif
    
#if FABLE_COMPILER_PYTHON
    let v142 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v142
#endif
    
#else
    let v143 : Async<System.Threading.CancellationToken> option = None
    let mutable _v143 = v143
    async {
    let v144 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v144 = v144 
    let v145 : System.Threading.CancellationToken = v144 
    let v146 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v147 : (System.Threading.CancellationToken []) = [|v145; v146; v128|]
    let v148 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v149 : System.Threading.CancellationTokenSource = v148 v147
    let v150 : System.Threading.CancellationToken = v149.Token
    return v150 
    }
    |> fun x -> _v143 <- Some x
    let v151 : Async<System.Threading.CancellationToken> = _v143 |> Option.get
    v151
#endif
    |> fun x -> _v136 <- Some x
    let v152 : Async<System.Threading.CancellationToken> = _v136.Value
    v152
#endif
    |> fun x -> _v129 <- Some x
    let v153 : Async<System.Threading.CancellationToken> = _v129.Value
    let! v153 = v153 
    let v154 : System.Threading.CancellationToken = v153 
    let v155 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v154.Register
    let v156 : (unit -> unit) = closure54(v111)
    let v157 : System.Threading.CancellationTokenRegistration = v155 v156
    use v157 = v157 
    let v158 : System.Threading.CancellationTokenRegistration = v157 
    let v159 : Async<int32> option = None
    let v160 : bool = true in let mutable _v159 = v159
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v161 : Async<int32> = null |> unbox<Async<int32>>
    v161
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v162 : Async<int32> = null |> unbox<Async<int32>>
    v162
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v163 : Async<int32> = null |> unbox<Async<int32>>
    v163
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v164 : Async<int32> = null |> unbox<Async<int32>>
    v164
#endif
    
#if FABLE_COMPILER_PYTHON
    let v165 : Async<int32> = null |> unbox<Async<int32>>
    v165
#endif
    
#else
    let v166 : Async<int32> option = None
    let mutable _v166 = v166
    async {
    try
    let v167 : System.Threading.Tasks.Task = v111.WaitForExitAsync v154 
    let v168 : Async<unit> option = None
    let v169 : bool = true in let mutable _v168 = v168
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v170 : Async<unit> = null |> unbox<Async<unit>>
    v170
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v171 : Async<unit> = null |> unbox<Async<unit>>
    v171
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v172 : Async<unit> = null |> unbox<Async<unit>>
    v172
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v173 : Async<unit> = null |> unbox<Async<unit>>
    v173
#endif
    
#if FABLE_COMPILER_PYTHON
    let v174 : Async<unit> = null |> unbox<Async<unit>>
    v174
#endif
    
#else
    let v175 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v176 : Async<unit> = v175 v167
    v176
#endif
    |> fun x -> _v168 <- Some x
    let v177 : Async<unit> = _v168.Value
    do! v177 
    let v178 : int32 = v111.ExitCode
    return v178 
    with ex ->
    let v179 : exn = ex
    let v180 : string option = None
    let v181 : bool = true in let mutable _v180 = v180
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v182 : string = $"%A{v179}"
    v182
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v183 : string = $"%A{v179}"
    v183
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v184 : string = $"%A{v179}"
    v184
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v185 : string = $"%A{v179}"
    v185
#endif
    
#if FABLE_COMPILER_PYTHON
    let v186 : string = $"%A{v179}"
    v186
#endif
    
#else
    let v187 : string = $"{v179.GetType ()}: {v179.Message}"
    v187
#endif
    |> fun x -> _v180 <- Some x
    let v188 : string = _v180.Value
    let v189 : (string -> unit) = v113.Push
    v189 v188
    let v190 : System.Threading.Tasks.TaskCanceledException = v179 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v191 : US0 = US0_3
    let v192 : (unit -> string) = closure55(v190)
    let v193 : (unit -> string) = method48()
    method3(v191, v192, v193)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v166 <- Some x
    let v194 : Async<int32> = _v166 |> Option.get
    v194
#endif
    |> fun x -> _v159 <- Some x
    let v195 : Async<int32> = _v159.Value
    let! v195 = v195 
    let v196 : int32 = v195 
    let v197 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v198 : string seq = v197 v113
    let v199 : string = method72()
    let v200 : (string -> (string seq -> string)) = String.concat
    let v201 : (string seq -> string) = v200 v199
    let v202 : string = v201 v198
    let v203 : US0 = US0_1
    let v204 : (unit -> string) = closure56(v196, v202)
    let v205 : (unit -> string) = method48()
    method3(v203, v204, v205)
    return struct (v196, v202) 
    }
    |> fun x -> _v70 <- Some x
    let v206 : Async<struct (int32 * string)> = _v70 |> Option.get
    v206
#endif
    |> fun x -> _v63 <- Some x
    let v207 : Async<struct (int32 * string)> = _v63.Value
    v207
#endif
    |> fun x -> _v56 <- Some x
    let v208 : Async<struct (int32 * string)> = _v56.Value
    let v209 : struct (int32 * string) option = None
    let v210 : bool = true in let mutable _v209 = v209
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v211 : int32, v212 : string) = null |> unbox<struct (int32 * string)>
    struct (v211, v212)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v213 : int32, v214 : string) = null |> unbox<struct (int32 * string)>
    struct (v213, v214)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v215 : int32, v216 : string) = null |> unbox<struct (int32 * string)>
    struct (v215, v216)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v217 : int32, v218 : string) = null |> unbox<struct (int32 * string)>
    struct (v217, v218)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v219 : int32, v220 : string) = null |> unbox<struct (int32 * string)>
    struct (v219, v220)
#endif
    
#else
    let v221 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v222 : int32, v223 : string) = v221 v208
    struct (v222, v223)
#endif
    |> fun x -> _v209 <- Some x
    let struct (v224 : int32, v225 : string) = _v209.Value
    struct (v224, v225)
#endif
    |> fun x -> _v11 <- Some x
    let struct (v226 : int32, v227 : string) = _v11.Value
    let v228 : string = "ERROR"
    let v229 : bool = v227.Contains v228
    if v229 then
        let v230 : US0 = US0_2
        let v231 : (unit -> string) = closure68()
        let v232 : (unit -> string) = closure69(v0, v227, v226)
        method3(v230, v231, v232)
        US21_1(v226, v227)
    else
        US21_0(v226, v227)
and closure67 (v0 : string, v1 : string, v2 : string) (v3 : string) : US19 =
    let struct (v4 : string, v5 : string) = method73(v3, v2, v0)
    let v6 : bool option = None
    let v7 : bool = true in let mutable _v6 = v6
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = method14(v5)
    let v9 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v10 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8 v9
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
    let v25 : bool = Fable.Core.JsInterop.emitJsExpr struct (v23, v5) v24
    v25
#endif
    
#if FABLE_COMPILER_PYTHON
    let v26 : bool = null |> unbox<bool>
    v26
#endif
    
#else
    let v27 : (string -> bool) = System.IO.File.Exists
    let v28 : bool = v27 v5
    v28
#endif
    |> fun x -> _v6 <- Some x
    let v29 : bool = _v6.Value
    let v53 : bool =
        if v29 then
            let v30 : bool option = None
            let v31 : bool = true in let mutable _v30 = v30
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v32 : string = method14(v4)
            let v33 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v34 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v32 v33
            let v35 : string = "String::from($0)"
            let v36 : std_string_String = Fable.Core.RustInterop.emitRustExpr v34 v35
            let v37 : string = "std::path::PathBuf::from($0)"
            let v38 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v36 v37
            let v39 : string = "$0.exists()"
            let v40 : bool = Fable.Core.RustInterop.emitRustExpr v38 v39
            let v43 : bool =
                if v40 then
                    let v41 : string = "$0.is_file()"
                    let v42 : bool = Fable.Core.RustInterop.emitRustExpr v38 v41
                    v42
                else
                    false
            v43
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v44 : bool = null |> unbox<bool>
            v44
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v45 : bool = null |> unbox<bool>
            v45
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v46 : IFsExistsSync = Fable.Core.JsInterop.importAll v22
            let v47 : string = "$0.existsSync($1)"
            let v48 : bool = Fable.Core.JsInterop.emitJsExpr struct (v46, v4) v47
            v48
#endif
            
#if FABLE_COMPILER_PYTHON
            let v49 : bool = null |> unbox<bool>
            v49
#endif
            
#else
            let v50 : (string -> bool) = System.IO.File.Exists
            let v51 : bool = v50 v4
            v51
#endif
            |> fun x -> _v30 <- Some x
            let v52 : bool = _v30.Value
            v52
        else
            false
    let v560 : bool =
        if v53 then
            let v54 : string option = None
            let v55 : bool = true in let mutable _v54 = v54
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v56 : string = method22()
            let v57 : string = method23(v5)
            let v58 : string = method24()
            let v59 : string = $"regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v60 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v56, v57, v58) v59
            let v61 : string = "String::from($0)"
            let v62 : std_string_String = Fable.Core.RustInterop.emitRustExpr v60 v61
            let v63 : string = "fable_library_rust::String_::fromString($0)"
            let v64 : string = Fable.Core.RustInterop.emitRustExpr v62 v63
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
            let v69 : string = "^\\\\\\\\\\?\\\\"
            let v70 : string = ""
            let v71 : string = System.Text.RegularExpressions.Regex.Replace (v5, v69, v70)
            v71
#endif
            |> fun x -> _v54 <- Some x
            let v72 : string = _v54.Value
            let v73 : string = $"{v72.[0] |> string |> _.ToLower()}{v72.[1..]}"
            let v74 : string = "\\"
            let v75 : string = "/"
            let v76 : string = v73.Replace (v74, v75)
            let v77 : string option = None
            let v78 : System.Threading.CancellationToken option = None
            let v79 : (struct (string * string) []) = [||]
            let v80 : (struct (bool * string * int32) -> Async<unit>) option = None
            let v81 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
            let v82 : string = $"pwsh -c \"(Get-FileHash \\\"{v76}\\\" -Algorithm SHA256).Hash\""
            let v83 : struct (int32 * string) option = None
            let v84 : bool = true in let mutable _v83 = v83
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v85 : string = method39(v78, v82, v79, v80, v81, v77)
            let struct (v86 : string, v87 : string) = method40()
            let v88 : int32 = v85.Length
            let v89 : (char []) = Array.zeroCreate<char> (v88)
            let v90 : Mut5 = {l0 = 0} : Mut5
            while method26(v88, v90) do
                let v92 : int32 = v90.l0
                let v93 : char = v85.[int v92]
                v89.[int v92] <- v93
                let v94 : int32 = v92 + 1
                v90.l0 <- v94
                ()
            let v95 : ((char []) -> char list) = Array.toList
            let v96 : char list = v95 v89
            let v97 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v98 : (char -> (UH0 -> UH0)) = method41()
            let v99 : (char list -> (UH0 -> UH0)) = v97 v98
            let v100 : (UH0 -> UH0) = v99 v96
            let v101 : UH0 = UH0_0
            let v102 : UH0 = v100 v101
            let v103 : US8 = US8_0
            let struct (v104 : string, v105 : string) = method42(v87, v86, v102, v103)
            let v106 : (string []) = method43(v105)
            let v107 : string = "$0.to_vec()"
            let v108 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v106 v107
            let v109 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v110 : (string -> std_string_String) = closure28()
            let v111 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v108, v110) v109
            let v112 : US0 = US0_1
            let v113 : (unit -> string) = closure29(v78, v82, v79, v80, v81, v77, v104, v111)
            let v114 : (unit -> string) = method48()
            method3(v112, v113, v114)
            let v115 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method49(v78, v82, v79, v80, v81, v77, v104, v111)
            let v116 : string = "futures_lite::future::block_on($0)"
            let v117 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v115 v116
            let (a, b) = v117
            let v118 : int32 = a
            let v119 : string = b
            struct (v118, v119)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v120 : int32, v121 : string) = null |> unbox<struct (int32 * string)>
            struct (v120, v121)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v122 : int32, v123 : string) = null |> unbox<struct (int32 * string)>
            struct (v122, v123)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v124 : int32, v125 : string) = null |> unbox<struct (int32 * string)>
            struct (v124, v125)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v126 : int32, v127 : string) = null |> unbox<struct (int32 * string)>
            struct (v126, v127)
#endif
            
#else
            let v128 : Async<struct (int32 * string)> option = None
            let v129 : bool = true in let mutable _v128 = v128
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v130 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v130
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v131 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v131
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v132 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v132
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v133 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v133
#endif
            
#if FABLE_COMPILER_PYTHON
            let v134 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v134
#endif
            
#else
            let v135 : Async<struct (int32 * string)> option = None
            let v136 : bool = true in let mutable _v135 = v135
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v137 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v137
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v138 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v138
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v139 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v139
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v140 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v140
#endif
            
#if FABLE_COMPILER_PYTHON
            let v141 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v141
#endif
            
#else
            let v142 : Async<struct (int32 * string)> option = None
            let mutable _v142 = v142
            async {
            let struct (v143 : string, v144 : string) = method40()
            let v145 : int32 = v82.Length
            let v146 : (char []) = Array.zeroCreate<char> (v145)
            let v147 : Mut5 = {l0 = 0} : Mut5
            while method26(v145, v147) do
                let v149 : int32 = v147.l0
                let v150 : char = v82.[int v149]
                v146.[int v149] <- v150
                let v151 : int32 = v149 + 1
                v147.l0 <- v151
                ()
            let v152 : ((char []) -> char list) = Array.toList
            let v153 : char list = v152 v146
            let v154 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v155 : (char -> (UH0 -> UH0)) = method41()
            let v156 : (char list -> (UH0 -> UH0)) = v154 v155
            let v157 : (UH0 -> UH0) = v156 v153
            let v158 : UH0 = UH0_0
            let v159 : UH0 = v157 v158
            let v160 : US8 = US8_0
            let struct (v161 : string, v162 : string) = method42(v144, v143, v159, v160)
            let v163 : (string -> US4) = method19()
            let v164 : US4 = US4_1
            let v165 : US4 = v77 |> Option.map v163 |> Option.defaultValue v164 
            let v168 : string =
                match v165 with
                | US4_1 -> (* None *)
                    v70
                | US4_0(v166) -> (* Some *)
                    v166
            let v169 : US0 = US0_1
            let v170 : (unit -> string) = closure48(v78, v82, v79, v80, v81, v77)
            let v171 : (unit -> string) = method48()
            method3(v169, v170, v171)
            let v172 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v173 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v162, StandardOutputEncoding = v172, WorkingDirectory = v168, FileName = v161, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v174 : int32 = v79.Length
            let v175 : Mut5 = {l0 = 0} : Mut5
            while method26(v174, v175) do
                let v177 : int32 = v175.l0
                let struct (v178 : string, v179 : string) = v79.[int v177]
                v173.EnvironmentVariables.[v178] <- v179 
                let v180 : int32 = v177 + 1
                v175.l0 <- v180
                ()
            let v181 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v173)
            use v181 = v181 
            let v182 : System.Diagnostics.Process = v181 
            let v183 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v184 : System.Collections.Concurrent.ConcurrentStack<string> = v183 ()
            let v185 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v78, v82, v79, v80, v81, v77, v182, v184)
            v182.OutputDataReceived.Add v185 
            let v186 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v78, v82, v79, v80, v81, v77, v182, v184)
            v182.ErrorDataReceived.Add v186 
            let v187 : (unit -> bool) = v182.Start
            let v188 : bool = v187 ()
            let v189 : bool = v188 = false
            if v189 then
                let v190 : string = $"execute_with_options_async / process_start error"
                failwith<unit> v190
            let v191 : (unit -> unit) = v182.BeginErrorReadLine
            v191 ()
            let v192 : (unit -> unit) = v182.BeginOutputReadLine
            v192 ()
            let v193 : (System.Threading.CancellationToken -> US18) = method71()
            let v194 : US18 = US18_1
            let v195 : US18 = v78 |> Option.map v193 |> Option.defaultValue v194 
            let v199 : System.Threading.CancellationToken =
                match v195 with
                | US18_1 -> (* None *)
                    let v197 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v197
                | US18_0(v196) -> (* Some *)
                    v196
            let v200 : Async<System.Threading.CancellationToken> option = None
            let v201 : bool = true in let mutable _v200 = v200
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v202 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v202
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v203 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v203
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v204 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v204
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v205 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v205
#endif
            
#if FABLE_COMPILER_PYTHON
            let v206 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v206
#endif
            
#else
            let v207 : Async<System.Threading.CancellationToken> option = None
            let v208 : bool = true in let mutable _v207 = v207
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v209 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v209
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v210 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v210
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v211 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v211
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v212 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v212
#endif
            
#if FABLE_COMPILER_PYTHON
            let v213 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v213
#endif
            
#else
            let v214 : Async<System.Threading.CancellationToken> option = None
            let mutable _v214 = v214
            async {
            let v215 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v215 = v215 
            let v216 : System.Threading.CancellationToken = v215 
            let v217 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v218 : (System.Threading.CancellationToken []) = [|v216; v217; v199|]
            let v219 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v220 : System.Threading.CancellationTokenSource = v219 v218
            let v221 : System.Threading.CancellationToken = v220.Token
            return v221 
            }
            |> fun x -> _v214 <- Some x
            let v222 : Async<System.Threading.CancellationToken> = _v214 |> Option.get
            v222
#endif
            |> fun x -> _v207 <- Some x
            let v223 : Async<System.Threading.CancellationToken> = _v207.Value
            v223
#endif
            |> fun x -> _v200 <- Some x
            let v224 : Async<System.Threading.CancellationToken> = _v200.Value
            let! v224 = v224 
            let v225 : System.Threading.CancellationToken = v224 
            let v226 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v225.Register
            let v227 : (unit -> unit) = closure54(v182)
            let v228 : System.Threading.CancellationTokenRegistration = v226 v227
            use v228 = v228 
            let v229 : System.Threading.CancellationTokenRegistration = v228 
            let v230 : Async<int32> option = None
            let v231 : bool = true in let mutable _v230 = v230
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v232 : Async<int32> = null |> unbox<Async<int32>>
            v232
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v233 : Async<int32> = null |> unbox<Async<int32>>
            v233
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v234 : Async<int32> = null |> unbox<Async<int32>>
            v234
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v235 : Async<int32> = null |> unbox<Async<int32>>
            v235
#endif
            
#if FABLE_COMPILER_PYTHON
            let v236 : Async<int32> = null |> unbox<Async<int32>>
            v236
#endif
            
#else
            let v237 : Async<int32> option = None
            let mutable _v237 = v237
            async {
            try
            let v238 : System.Threading.Tasks.Task = v182.WaitForExitAsync v225 
            let v239 : Async<unit> option = None
            let v240 : bool = true in let mutable _v239 = v239
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v241 : Async<unit> = null |> unbox<Async<unit>>
            v241
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v242 : Async<unit> = null |> unbox<Async<unit>>
            v242
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v243 : Async<unit> = null |> unbox<Async<unit>>
            v243
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v244 : Async<unit> = null |> unbox<Async<unit>>
            v244
#endif
            
#if FABLE_COMPILER_PYTHON
            let v245 : Async<unit> = null |> unbox<Async<unit>>
            v245
#endif
            
#else
            let v246 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v247 : Async<unit> = v246 v238
            v247
#endif
            |> fun x -> _v239 <- Some x
            let v248 : Async<unit> = _v239.Value
            do! v248 
            let v249 : int32 = v182.ExitCode
            return v249 
            with ex ->
            let v250 : exn = ex
            let v251 : string option = None
            let v252 : bool = true in let mutable _v251 = v251
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v253 : string = $"%A{v250}"
            v253
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v254 : string = $"%A{v250}"
            v254
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v255 : string = $"%A{v250}"
            v255
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v256 : string = $"%A{v250}"
            v256
#endif
            
#if FABLE_COMPILER_PYTHON
            let v257 : string = $"%A{v250}"
            v257
#endif
            
#else
            let v258 : string = $"{v250.GetType ()}: {v250.Message}"
            v258
#endif
            |> fun x -> _v251 <- Some x
            let v259 : string = _v251.Value
            let v260 : (string -> unit) = v184.Push
            v260 v259
            let v261 : System.Threading.Tasks.TaskCanceledException = v250 |> unbox<System.Threading.Tasks.TaskCanceledException>
            let v262 : US0 = US0_3
            let v263 : (unit -> string) = closure55(v261)
            let v264 : (unit -> string) = method48()
            method3(v262, v263, v264)
            return -2147483648 
            (*
            *)
            }
            |> fun x -> _v237 <- Some x
            let v265 : Async<int32> = _v237 |> Option.get
            v265
#endif
            |> fun x -> _v230 <- Some x
            let v266 : Async<int32> = _v230.Value
            let! v266 = v266 
            let v267 : int32 = v266 
            let v268 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v269 : string seq = v268 v184
            let v270 : string = method72()
            let v271 : (string -> (string seq -> string)) = String.concat
            let v272 : (string seq -> string) = v271 v270
            let v273 : string = v272 v269
            let v274 : US0 = US0_1
            let v275 : (unit -> string) = closure56(v267, v273)
            let v276 : (unit -> string) = method48()
            method3(v274, v275, v276)
            return struct (v267, v273) 
            }
            |> fun x -> _v142 <- Some x
            let v277 : Async<struct (int32 * string)> = _v142 |> Option.get
            v277
#endif
            |> fun x -> _v135 <- Some x
            let v278 : Async<struct (int32 * string)> = _v135.Value
            v278
#endif
            |> fun x -> _v128 <- Some x
            let v279 : Async<struct (int32 * string)> = _v128.Value
            let v280 : struct (int32 * string) option = None
            let v281 : bool = true in let mutable _v280 = v280
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v282 : int32, v283 : string) = null |> unbox<struct (int32 * string)>
            struct (v282, v283)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v284 : int32, v285 : string) = null |> unbox<struct (int32 * string)>
            struct (v284, v285)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v286 : int32, v287 : string) = null |> unbox<struct (int32 * string)>
            struct (v286, v287)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v288 : int32, v289 : string) = null |> unbox<struct (int32 * string)>
            struct (v288, v289)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v290 : int32, v291 : string) = null |> unbox<struct (int32 * string)>
            struct (v290, v291)
#endif
            
#else
            let v292 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
            let struct (v293 : int32, v294 : string) = v292 v279
            struct (v293, v294)
#endif
            |> fun x -> _v280 <- Some x
            let struct (v295 : int32, v296 : string) = _v280.Value
            struct (v295, v296)
#endif
            |> fun x -> _v83 <- Some x
            let struct (v297 : int32, v298 : string) = _v83.Value
            let v299 : bool = v297 = 0
            let v302 : US20 =
                if v299 then
                    US20_0(v298)
                else
                    US20_1(v298)
            let v308 : string =
                match v302 with
                | US20_1(v304) -> (* Error *)
                    let v305 : string = $"resultm.get / Result value was Error: {v304}"
                    failwith<string> v305
                | US20_0(v303) -> (* Ok *)
                    v303
            let v309 : string option = None
            let v310 : bool = true in let mutable _v309 = v309
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v311 : string = method22()
            let v312 : string = method23(v4)
            let v313 : string = method24()
            let v314 : string = $"regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v315 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v311, v312, v313) v314
            let v316 : string = "String::from($0)"
            let v317 : std_string_String = Fable.Core.RustInterop.emitRustExpr v315 v316
            let v318 : string = "fable_library_rust::String_::fromString($0)"
            let v319 : string = Fable.Core.RustInterop.emitRustExpr v317 v318
            v319
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v320 : string = null |> unbox<string>
            v320
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v321 : string = null |> unbox<string>
            v321
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v322 : string = null |> unbox<string>
            v322
#endif
            
#if FABLE_COMPILER_PYTHON
            let v323 : string = null |> unbox<string>
            v323
#endif
            
#else
            let v324 : string = System.Text.RegularExpressions.Regex.Replace (v4, v69, v70)
            v324
#endif
            |> fun x -> _v309 <- Some x
            let v325 : string = _v309.Value
            let v326 : string = $"{v325.[0] |> string |> _.ToLower()}{v325.[1..]}"
            let v327 : string = v326.Replace (v74, v75)
            let v328 : string option = None
            let v329 : System.Threading.CancellationToken option = None
            let v330 : (struct (string * string) []) = [||]
            let v331 : (struct (bool * string * int32) -> Async<unit>) option = None
            let v332 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
            let v333 : string = $"pwsh -c \"(Get-FileHash \\\"{v327}\\\" -Algorithm SHA256).Hash\""
            let v334 : struct (int32 * string) option = None
            let v335 : bool = true in let mutable _v334 = v334
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v336 : string = method39(v329, v333, v330, v331, v332, v328)
            let struct (v337 : string, v338 : string) = method40()
            let v339 : int32 = v336.Length
            let v340 : (char []) = Array.zeroCreate<char> (v339)
            let v341 : Mut5 = {l0 = 0} : Mut5
            while method26(v339, v341) do
                let v343 : int32 = v341.l0
                let v344 : char = v336.[int v343]
                v340.[int v343] <- v344
                let v345 : int32 = v343 + 1
                v341.l0 <- v345
                ()
            let v346 : ((char []) -> char list) = Array.toList
            let v347 : char list = v346 v340
            let v348 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v349 : (char -> (UH0 -> UH0)) = method41()
            let v350 : (char list -> (UH0 -> UH0)) = v348 v349
            let v351 : (UH0 -> UH0) = v350 v347
            let v352 : UH0 = UH0_0
            let v353 : UH0 = v351 v352
            let v354 : US8 = US8_0
            let struct (v355 : string, v356 : string) = method42(v338, v337, v353, v354)
            let v357 : (string []) = method43(v356)
            let v358 : string = "$0.to_vec()"
            let v359 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v357 v358
            let v360 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v361 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v359, v110) v360
            let v362 : US0 = US0_1
            let v363 : (unit -> string) = closure29(v329, v333, v330, v331, v332, v328, v355, v361)
            let v364 : (unit -> string) = method48()
            method3(v362, v363, v364)
            let v365 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method49(v329, v333, v330, v331, v332, v328, v355, v361)
            let v366 : string = "futures_lite::future::block_on($0)"
            let v367 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v365 v366
            let (a, b) = v367
            let v368 : int32 = a
            let v369 : string = b
            struct (v368, v369)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v370 : int32, v371 : string) = null |> unbox<struct (int32 * string)>
            struct (v370, v371)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v372 : int32, v373 : string) = null |> unbox<struct (int32 * string)>
            struct (v372, v373)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v374 : int32, v375 : string) = null |> unbox<struct (int32 * string)>
            struct (v374, v375)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v376 : int32, v377 : string) = null |> unbox<struct (int32 * string)>
            struct (v376, v377)
#endif
            
#else
            let v378 : Async<struct (int32 * string)> option = None
            let v379 : bool = true in let mutable _v378 = v378
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v380 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v380
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v381 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v381
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v382 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v382
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v383 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v383
#endif
            
#if FABLE_COMPILER_PYTHON
            let v384 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v384
#endif
            
#else
            let v385 : Async<struct (int32 * string)> option = None
            let v386 : bool = true in let mutable _v385 = v385
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v387 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v387
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v388 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v388
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v389 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v389
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v390 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v390
#endif
            
#if FABLE_COMPILER_PYTHON
            let v391 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v391
#endif
            
#else
            let v392 : Async<struct (int32 * string)> option = None
            let mutable _v392 = v392
            async {
            let struct (v393 : string, v394 : string) = method40()
            let v395 : int32 = v333.Length
            let v396 : (char []) = Array.zeroCreate<char> (v395)
            let v397 : Mut5 = {l0 = 0} : Mut5
            while method26(v395, v397) do
                let v399 : int32 = v397.l0
                let v400 : char = v333.[int v399]
                v396.[int v399] <- v400
                let v401 : int32 = v399 + 1
                v397.l0 <- v401
                ()
            let v402 : ((char []) -> char list) = Array.toList
            let v403 : char list = v402 v396
            let v404 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v405 : (char -> (UH0 -> UH0)) = method41()
            let v406 : (char list -> (UH0 -> UH0)) = v404 v405
            let v407 : (UH0 -> UH0) = v406 v403
            let v408 : UH0 = UH0_0
            let v409 : UH0 = v407 v408
            let v410 : US8 = US8_0
            let struct (v411 : string, v412 : string) = method42(v394, v393, v409, v410)
            let v413 : (string -> US4) = method19()
            let v414 : US4 = US4_1
            let v415 : US4 = v328 |> Option.map v413 |> Option.defaultValue v414 
            let v418 : string =
                match v415 with
                | US4_1 -> (* None *)
                    v70
                | US4_0(v416) -> (* Some *)
                    v416
            let v419 : US0 = US0_1
            let v420 : (unit -> string) = closure48(v329, v333, v330, v331, v332, v328)
            let v421 : (unit -> string) = method48()
            method3(v419, v420, v421)
            let v422 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v423 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v412, StandardOutputEncoding = v422, WorkingDirectory = v418, FileName = v411, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v424 : int32 = v330.Length
            let v425 : Mut5 = {l0 = 0} : Mut5
            while method26(v424, v425) do
                let v427 : int32 = v425.l0
                let struct (v428 : string, v429 : string) = v330.[int v427]
                v423.EnvironmentVariables.[v428] <- v429 
                let v430 : int32 = v427 + 1
                v425.l0 <- v430
                ()
            let v431 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v423)
            use v431 = v431 
            let v432 : System.Diagnostics.Process = v431 
            let v433 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v434 : System.Collections.Concurrent.ConcurrentStack<string> = v433 ()
            let v435 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v329, v333, v330, v331, v332, v328, v432, v434)
            v432.OutputDataReceived.Add v435 
            let v436 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v329, v333, v330, v331, v332, v328, v432, v434)
            v432.ErrorDataReceived.Add v436 
            let v437 : (unit -> bool) = v432.Start
            let v438 : bool = v437 ()
            let v439 : bool = v438 = false
            if v439 then
                let v440 : string = $"execute_with_options_async / process_start error"
                failwith<unit> v440
            let v441 : (unit -> unit) = v432.BeginErrorReadLine
            v441 ()
            let v442 : (unit -> unit) = v432.BeginOutputReadLine
            v442 ()
            let v443 : (System.Threading.CancellationToken -> US18) = method71()
            let v444 : US18 = US18_1
            let v445 : US18 = v329 |> Option.map v443 |> Option.defaultValue v444 
            let v449 : System.Threading.CancellationToken =
                match v445 with
                | US18_1 -> (* None *)
                    let v447 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v447
                | US18_0(v446) -> (* Some *)
                    v446
            let v450 : Async<System.Threading.CancellationToken> option = None
            let v451 : bool = true in let mutable _v450 = v450
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v452 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v452
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v453 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v453
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v454 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v454
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v455 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v455
#endif
            
#if FABLE_COMPILER_PYTHON
            let v456 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v456
#endif
            
#else
            let v457 : Async<System.Threading.CancellationToken> option = None
            let v458 : bool = true in let mutable _v457 = v457
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v459 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v459
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v460 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v460
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v461 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v461
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v462 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v462
#endif
            
#if FABLE_COMPILER_PYTHON
            let v463 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v463
#endif
            
#else
            let v464 : Async<System.Threading.CancellationToken> option = None
            let mutable _v464 = v464
            async {
            let v465 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v465 = v465 
            let v466 : System.Threading.CancellationToken = v465 
            let v467 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v468 : (System.Threading.CancellationToken []) = [|v466; v467; v449|]
            let v469 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v470 : System.Threading.CancellationTokenSource = v469 v468
            let v471 : System.Threading.CancellationToken = v470.Token
            return v471 
            }
            |> fun x -> _v464 <- Some x
            let v472 : Async<System.Threading.CancellationToken> = _v464 |> Option.get
            v472
#endif
            |> fun x -> _v457 <- Some x
            let v473 : Async<System.Threading.CancellationToken> = _v457.Value
            v473
#endif
            |> fun x -> _v450 <- Some x
            let v474 : Async<System.Threading.CancellationToken> = _v450.Value
            let! v474 = v474 
            let v475 : System.Threading.CancellationToken = v474 
            let v476 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v475.Register
            let v477 : (unit -> unit) = closure54(v432)
            let v478 : System.Threading.CancellationTokenRegistration = v476 v477
            use v478 = v478 
            let v479 : System.Threading.CancellationTokenRegistration = v478 
            let v480 : Async<int32> option = None
            let v481 : bool = true in let mutable _v480 = v480
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v482 : Async<int32> = null |> unbox<Async<int32>>
            v482
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v483 : Async<int32> = null |> unbox<Async<int32>>
            v483
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v484 : Async<int32> = null |> unbox<Async<int32>>
            v484
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v485 : Async<int32> = null |> unbox<Async<int32>>
            v485
#endif
            
#if FABLE_COMPILER_PYTHON
            let v486 : Async<int32> = null |> unbox<Async<int32>>
            v486
#endif
            
#else
            let v487 : Async<int32> option = None
            let mutable _v487 = v487
            async {
            try
            let v488 : System.Threading.Tasks.Task = v432.WaitForExitAsync v475 
            let v489 : Async<unit> option = None
            let v490 : bool = true in let mutable _v489 = v489
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v491 : Async<unit> = null |> unbox<Async<unit>>
            v491
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v492 : Async<unit> = null |> unbox<Async<unit>>
            v492
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v493 : Async<unit> = null |> unbox<Async<unit>>
            v493
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v494 : Async<unit> = null |> unbox<Async<unit>>
            v494
#endif
            
#if FABLE_COMPILER_PYTHON
            let v495 : Async<unit> = null |> unbox<Async<unit>>
            v495
#endif
            
#else
            let v496 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v497 : Async<unit> = v496 v488
            v497
#endif
            |> fun x -> _v489 <- Some x
            let v498 : Async<unit> = _v489.Value
            do! v498 
            let v499 : int32 = v432.ExitCode
            return v499 
            with ex ->
            let v500 : exn = ex
            let v501 : string option = None
            let v502 : bool = true in let mutable _v501 = v501
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v503 : string = $"%A{v500}"
            v503
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v504 : string = $"%A{v500}"
            v504
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v505 : string = $"%A{v500}"
            v505
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v506 : string = $"%A{v500}"
            v506
#endif
            
#if FABLE_COMPILER_PYTHON
            let v507 : string = $"%A{v500}"
            v507
#endif
            
#else
            let v508 : string = $"{v500.GetType ()}: {v500.Message}"
            v508
#endif
            |> fun x -> _v501 <- Some x
            let v509 : string = _v501.Value
            let v510 : (string -> unit) = v434.Push
            v510 v509
            let v511 : System.Threading.Tasks.TaskCanceledException = v500 |> unbox<System.Threading.Tasks.TaskCanceledException>
            let v512 : US0 = US0_3
            let v513 : (unit -> string) = closure55(v511)
            let v514 : (unit -> string) = method48()
            method3(v512, v513, v514)
            return -2147483648 
            (*
            *)
            }
            |> fun x -> _v487 <- Some x
            let v515 : Async<int32> = _v487 |> Option.get
            v515
#endif
            |> fun x -> _v480 <- Some x
            let v516 : Async<int32> = _v480.Value
            let! v516 = v516 
            let v517 : int32 = v516 
            let v518 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v519 : string seq = v518 v434
            let v520 : string = method72()
            let v521 : (string -> (string seq -> string)) = String.concat
            let v522 : (string seq -> string) = v521 v520
            let v523 : string = v522 v519
            let v524 : US0 = US0_1
            let v525 : (unit -> string) = closure56(v517, v523)
            let v526 : (unit -> string) = method48()
            method3(v524, v525, v526)
            return struct (v517, v523) 
            }
            |> fun x -> _v392 <- Some x
            let v527 : Async<struct (int32 * string)> = _v392 |> Option.get
            v527
#endif
            |> fun x -> _v385 <- Some x
            let v528 : Async<struct (int32 * string)> = _v385.Value
            v528
#endif
            |> fun x -> _v378 <- Some x
            let v529 : Async<struct (int32 * string)> = _v378.Value
            let v530 : struct (int32 * string) option = None
            let v531 : bool = true in let mutable _v530 = v530
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v532 : int32, v533 : string) = null |> unbox<struct (int32 * string)>
            struct (v532, v533)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v534 : int32, v535 : string) = null |> unbox<struct (int32 * string)>
            struct (v534, v535)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v536 : int32, v537 : string) = null |> unbox<struct (int32 * string)>
            struct (v536, v537)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v538 : int32, v539 : string) = null |> unbox<struct (int32 * string)>
            struct (v538, v539)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v540 : int32, v541 : string) = null |> unbox<struct (int32 * string)>
            struct (v540, v541)
#endif
            
#else
            let v542 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
            let struct (v543 : int32, v544 : string) = v542 v529
            struct (v543, v544)
#endif
            |> fun x -> _v530 <- Some x
            let struct (v545 : int32, v546 : string) = _v530.Value
            struct (v545, v546)
#endif
            |> fun x -> _v334 <- Some x
            let struct (v547 : int32, v548 : string) = _v334.Value
            let v549 : bool = v547 = 0
            let v552 : US20 =
                if v549 then
                    US20_0(v548)
                else
                    US20_1(v548)
            let v558 : string =
                match v552 with
                | US20_1(v554) -> (* Error *)
                    let v555 : string = $"resultm.get / Result value was Error: {v554}"
                    failwith<string> v555
                | US20_0(v553) -> (* Ok *)
                    v553
            let v559 : bool = v308 = v558
            v559
        else
            false
    let v561 : bool = v560 = false
    if v561 then
        let v562 : US21 = method81(v5, v2, v1, v3)
        match v562 with
        | US21_1(v606, v607) -> (* Error *)
            let v608 : (string * string) = v5, v607
            let v609 : Result<string, (string * string)> = Error v608
            US19_0(v609)
        | US21_0(v563, v564) -> (* Ok *)
            let v565 : bool = v563 <> 0
            if v565 then
                let v566 : US0 = US0_2
                let v567 : (unit -> string) = closure64()
                let v568 : (unit -> string) = closure65(v564, v563)
                method3(v566, v567, v568)
                let v569 : (string * string) = v5, v564
                let v570 : Result<string, (string * string)> = Error v569
                US19_0(v570)
            else
                let v572 : bool option = None
                let v573 : bool = true in let mutable _v572 = v572
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v574 : string = method14(v5)
                let v575 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                let v576 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v574 v575
                let v577 : string = "String::from($0)"
                let v578 : std_string_String = Fable.Core.RustInterop.emitRustExpr v576 v577
                let v579 : string = "std::path::PathBuf::from($0)"
                let v580 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v578 v579
                let v581 : string = "$0.exists()"
                let v582 : bool = Fable.Core.RustInterop.emitRustExpr v580 v581
                let v585 : bool =
                    if v582 then
                        let v583 : string = "$0.is_file()"
                        let v584 : bool = Fable.Core.RustInterop.emitRustExpr v580 v583
                        v584
                    else
                        false
                v585
#endif
                
#if FABLE_COMPILER_RUST && WASM
                let v586 : bool = null |> unbox<bool>
                v586
#endif
                
#if FABLE_COMPILER_RUST && CONTRACT
                let v587 : bool = null |> unbox<bool>
                v587
#endif
                
#if FABLE_COMPILER_TYPESCRIPT
                let v588 : IFsExistsSync = Fable.Core.JsInterop.importAll v22
                let v589 : string = "$0.existsSync($1)"
                let v590 : bool = Fable.Core.JsInterop.emitJsExpr struct (v588, v5) v589
                v590
#endif
                
#if FABLE_COMPILER_PYTHON
                let v591 : bool = null |> unbox<bool>
                v591
#endif
                
#else
                let v592 : (string -> bool) = System.IO.File.Exists
                let v593 : bool = v592 v5
                v593
#endif
                |> fun x -> _v572 <- Some x
                let v594 : bool = _v572.Value
                if v594 then
                    let v595 : unit option = None
                    let v596 : bool = true in let mutable _v595 = v595
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v597 : string = method74(v4)
                    let v598 : string = "std::fs::copy(&*$0, &*v597)"
                    let v599 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v5 v598
                    let v600 : string = "$0.unwrap()"
                    let v601 : uint64 = Fable.Core.RustInterop.emitRustExpr v599 v600
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
                    |> fun x -> _v595 <- Some x
                    _v595.Value
                    ()
                else
                    let v602 : string = $"documents.files_fn / {v5} should exist"
                    failwith<unit> v602
                let v603 : Result<string, (string * string)> = Ok v5
                US19_0(v603)
    else
        US19_1
and closure66 (v0 : string, v1 : string) (v2 : string) : (string -> US19) =
    closure67(v0, v1, v2)
and closure70 () () : string =
    let v0 : string = "documents.run / par_map / files' = [] / listm.iter"
    v0
and closure71 (v0 : string, v1 : string) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"output_path: %A{v1} / output_cache_path: {v0} / {v2 ()}"
    v3
and method82 (v0 : UH2, v1 : UH3 list) : UH3 list =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : UH3 list = method82(v3, v1)
        let v5 : UH3 list = v2 :: v4 
        v5
    | UH2_0 -> (* Nil *)
        v1
and method83 (v0 : int32, v1 : Mut8) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method84 (v0 : UH3, v1 : struct (string * string * (string -> (string -> US19))) list) : struct (string * string * (string -> (string -> US19))) list =
    match v0 with
    | UH3_1(v2, v3, v4, v5) -> (* Cons *)
        let v6 : struct (string * string * (string -> (string -> US19))) list = method84(v5, v1)
        let v7 : struct (string * string * (string -> (string -> US19))) list = struct (v2, v3, v4) :: v6 
        v7
    | UH3_0 -> (* Nil *)
        v1
and closure72 () struct (v0 : string, v1 : string, v2 : (string -> (string -> US19))) : Result<string, (string * string)> option =
    let v3 : (string -> US19) = v2 v1
    let v4 : US19 = v3 v0
    match v4 with
    | US19_1 -> (* None *)
        let v7 : Result<string, (string * string)> option = None
        v7
    | US19_0(v5) -> (* Some *)
        let v6 : Result<string, (string * string)> option = Some v5 
        v6
and method85 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method86 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and closure25 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> =
    let v6 : string option = None
    let v7 : bool = true in let mutable _v6 = v6
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = method21(v5)
    let v9 : string = method14(v8)
    let v10 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v11 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "String::from($0)"
    let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "std::path::PathBuf::from($0)"
    let v15 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "$0.exists()"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : bool = v17 = false
    let v168 : string =
        if v18 then
            let v19 : string option = None
            let v20 : bool = true in let mutable _v19 = v19
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v21 : string = "std::env::current_dir()"
            let v22 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v21
            let v23 : string = "$0.unwrap()"
            let v24 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v22 v23
            let v25 : string = "$0.display()"
            let v26 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v24 v25
            let v27 : std_string_String option = None
            let v28 : bool = true in let mutable _v27 = v27
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v29 : string = @$"format!(""{{}}"", $0)"
            let v30 : std_string_String = Fable.Core.RustInterop.emitRustExpr v26 v29
            v30
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v31 : string = @$"format!(""{{}}"", $0)"
            let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v26 v31
            v32
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v33 : string = @$"format!(""{{}}"", $0)"
            let v34 : std_string_String = Fable.Core.RustInterop.emitRustExpr v26 v33
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
            |> fun x -> _v27 <- Some x
            let v38 : std_string_String = _v27.Value
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
            |> fun x -> _v19 <- Some x
            let v47 : string = _v19.Value
            let v48 : string = method13(v47, v8)
            let v49 : string option = None
            let v50 : bool = true in let mutable _v49 = v49
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v51 : string = method22()
            let v52 : string = method23(v48)
            let v53 : string = method24()
            let v54 : string = $"regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v55 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v51, v52, v53) v54
            let v56 : string = "String::from($0)"
            let v57 : std_string_String = Fable.Core.RustInterop.emitRustExpr v55 v56
            let v58 : string = "fable_library_rust::String_::fromString($0)"
            let v59 : string = Fable.Core.RustInterop.emitRustExpr v57 v58
            v59
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v60 : string = null |> unbox<string>
            v60
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v61 : string = null |> unbox<string>
            v61
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v62 : string = null |> unbox<string>
            v62
#endif
            
#if FABLE_COMPILER_PYTHON
            let v63 : string = null |> unbox<string>
            v63
#endif
            
#else
            let v64 : string = "^\\\\\\\\\\?\\\\"
            let v65 : string = ""
            let v66 : string = System.Text.RegularExpressions.Regex.Replace (v48, v64, v65)
            v66
#endif
            |> fun x -> _v49 <- Some x
            let v67 : string = _v49.Value
            let v68 : string = $"{v67.[0] |> string |> _.ToLower()}{v67.[1..]}"
            let v69 : string = "\\"
            let v70 : string = "/"
            let v71 : string = v68.Replace (v69, v70)
            let v72 : (string []) = v71.Split v70
            let v73 : (string []) = [||]
            let v74 : int32 = v72.Length
            let v75 : Mut4 = {l0 = 0; l1 = 0; l2 = v73} : Mut4
            while method25(v74, v75) do
                let v77 : int32 = v75.l0
                let v78 : int32 =  -v77
                let v79 : int32 = v78 + v74
                let v80 : int32 = v79 - 1
                let struct (v81 : int32, v82 : (string [])) = v75.l1, v75.l2
                let v83 : string = v72.[int v80]
                let v84 : bool = ".." = v83
                let struct (v126 : int32, v127 : (string [])) =
                    if v84 then
                        let v85 : int32 = v81 + 1
                        struct (v85, v82)
                    else
                        let v86 : bool = "." = v83
                        if v86 then
                            struct (v81, v82)
                        else
                            let v87 : bool = 0 = v81
                            if v87 then
                                let v88 : string = ":"
                                let v89 : bool = v83.EndsWith v88
                                if v89 then
                                    let v90 : string = $"{v47.[0]}:"
                                    let v91 : (string []) = [|v90|]
                                    let v92 : int32 = v91.Length
                                    let v93 : int32 = v82.Length
                                    let v94 : int32 = v92 + v93
                                    let v95 : (string []) = Array.zeroCreate<string> (v94)
                                    let v96 : Mut5 = {l0 = 0} : Mut5
                                    while method26(v94, v96) do
                                        let v98 : int32 = v96.l0
                                        let v99 : bool = v98 < v92
                                        let v103 : string =
                                            if v99 then
                                                let v100 : string = v91.[int v98]
                                                v100
                                            else
                                                let v101 : int32 = v98 - v92
                                                let v102 : string = v82.[int v101]
                                                v102
                                        v95.[int v98] <- v103
                                        let v104 : int32 = v98 + 1
                                        v96.l0 <- v104
                                        ()
                                    struct (0, v95)
                                else
                                    let v105 : (string []) = [|v83|]
                                    let v106 : int32 = v105.Length
                                    let v107 : int32 = v82.Length
                                    let v108 : int32 = v106 + v107
                                    let v109 : (string []) = Array.zeroCreate<string> (v108)
                                    let v110 : Mut5 = {l0 = 0} : Mut5
                                    while method26(v108, v110) do
                                        let v112 : int32 = v110.l0
                                        let v113 : bool = v112 < v106
                                        let v117 : string =
                                            if v113 then
                                                let v114 : string = v105.[int v112]
                                                v114
                                            else
                                                let v115 : int32 = v112 - v106
                                                let v116 : string = v82.[int v115]
                                                v116
                                        v109.[int v112] <- v117
                                        let v118 : int32 = v112 + 1
                                        v110.l0 <- v118
                                        ()
                                    struct (0, v109)
                            else
                                let v121 : int32 = v81 - 1
                                struct (v121, v82)
                let v128 : int32 = v77 + 1
                v75.l0 <- v128
                v75.l1 <- v126
                v75.l2 <- v127
                ()
            let struct (v129 : int32, v130 : (string [])) = v75.l1, v75.l2
            let v131 : string seq = seq { for i = 0 to v130.Length - 1 do yield v130.[i] }
            let v132 : char option = None
            let v133 : bool = true in let mutable _v132 = v132
            
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
            |> fun x -> _v132 <- Some x
            let v141 : char = _v132.Value
            let v142 : (char -> string) = _.ToString()
            let v143 : string = v142 v141
            let v144 : string = method27(v143)
            let v145 : (string -> (string seq -> string)) = String.concat
            let v146 : (string seq -> string) = v145 v144
            v146 v131
        else
            let v148 : string = "std::fs::canonicalize(&*$0)"
            let v149 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v8 v148
            let v150 : string = "$0.unwrap()"
            let v151 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v149 v150
            let v152 : string = "$0.display()"
            let v153 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v151 v152
            let v154 : std_string_String option = None
            let v155 : bool = true in let mutable _v154 = v154
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v156 : string = @$"format!(""{{}}"", $0)"
            let v157 : std_string_String = Fable.Core.RustInterop.emitRustExpr v153 v156
            v157
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v158 : string = @$"format!(""{{}}"", $0)"
            let v159 : std_string_String = Fable.Core.RustInterop.emitRustExpr v153 v158
            v159
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v160 : string = @$"format!(""{{}}"", $0)"
            let v161 : std_string_String = Fable.Core.RustInterop.emitRustExpr v153 v160
            v161
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v162 : std_string_String = null |> unbox<std_string_String>
            v162
#endif
            
#if FABLE_COMPILER_PYTHON
            let v163 : std_string_String = null |> unbox<std_string_String>
            v163
#endif
            
#else
            let v164 : std_string_String = null |> unbox<std_string_String>
            v164
#endif
            |> fun x -> _v154 <- Some x
            let v165 : std_string_String = _v154.Value
            let v166 : string = "fable_library_rust::String_::fromString($0)"
            let v167 : string = Fable.Core.RustInterop.emitRustExpr v165 v166
            v167
    v168
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v169 : string = null |> unbox<string>
    v169
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v170 : string = null |> unbox<string>
    v170
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v171 : string = null |> unbox<string>
    v171
#endif
    
#if FABLE_COMPILER_PYTHON
    let v172 : string = null |> unbox<string>
    v172
#endif
    
#else
    let v173 : string = method28(v5)
    let v174 : (string -> string) = System.IO.Path.GetFullPath
    let v175 : string = v174 v173
    v175
#endif
    |> fun x -> _v6 <- Some x
    let v176 : string = _v6.Value
    let v177 : string = method14(v176)
    let v178 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v179 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v177 v178
    let v180 : string = "String::from($0)"
    let v181 : std_string_String = Fable.Core.RustInterop.emitRustExpr v179 v180
    let v182 : string = "std::path::PathBuf::from($0)"
    let v183 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v181 v182
    let v184 : string = "$0.display()"
    let v185 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v183 v184
    let v186 : std_string_String option = None
    let v187 : bool = true in let mutable _v186 = v186
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v188 : string = @$"format!(""{{}}"", $0)"
    let v189 : std_string_String = Fable.Core.RustInterop.emitRustExpr v185 v188
    v189
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v190 : string = @$"format!(""{{}}"", $0)"
    let v191 : std_string_String = Fable.Core.RustInterop.emitRustExpr v185 v190
    v191
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v192 : string = @$"format!(""{{}}"", $0)"
    let v193 : std_string_String = Fable.Core.RustInterop.emitRustExpr v185 v192
    v193
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v194 : std_string_String = null |> unbox<std_string_String>
    v194
#endif
    
#if FABLE_COMPILER_PYTHON
    let v195 : std_string_String = null |> unbox<std_string_String>
    v195
#endif
    
#else
    let v196 : std_string_String = null |> unbox<std_string_String>
    v196
#endif
    |> fun x -> _v186 <- Some x
    let v197 : std_string_String = _v186.Value
    let v198 : string = "fable_library_rust::String_::fromString($0)"
    let v199 : string = Fable.Core.RustInterop.emitRustExpr v197 v198
    let v200 : string = ""
    let v201 : string = v199.Replace (v3, v200)
    let v202 : string = "\\"
    let v203 : string = "/"
    let v204 : string = v201.Replace (v202, v203)
    let v205 : string = $".{v204}"
    let v206 : string option = None
    let v207 : bool = true in let mutable _v206 = v206
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v208 : string = method22()
    let v209 : string = method23(v176)
    let v210 : string = method24()
    let v211 : string = $"regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
    let v212 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v208, v209, v210) v211
    let v213 : string = "String::from($0)"
    let v214 : std_string_String = Fable.Core.RustInterop.emitRustExpr v212 v213
    let v215 : string = "fable_library_rust::String_::fromString($0)"
    let v216 : string = Fable.Core.RustInterop.emitRustExpr v214 v215
    v216
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v217 : string = null |> unbox<string>
    v217
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v218 : string = null |> unbox<string>
    v218
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v219 : string = null |> unbox<string>
    v219
#endif
    
#if FABLE_COMPILER_PYTHON
    let v220 : string = null |> unbox<string>
    v220
#endif
    
#else
    let v221 : string = "^\\\\\\\\\\?\\\\"
    let v222 : string = System.Text.RegularExpressions.Regex.Replace (v176, v221, v200)
    v222
#endif
    |> fun x -> _v206 <- Some x
    let v223 : string = _v206.Value
    let v224 : string = $"{v223.[0] |> string |> _.ToLower()}{v223.[1..]}"
    let v225 : string = v224.Replace (v202, v203)
    let v226 : string = method13(v2, v205)
    let v227 : string = method38(v226)
    let v228 : string option = None
    let v229 : System.Threading.CancellationToken option = None
    let v230 : (struct (string * string) []) = [||]
    let v231 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v232 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v233 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v227}\""
    let v234 : string option = Some v2 
    let v235 : struct (int32 * string) option = None
    let v236 : bool = true in let mutable _v235 = v235
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v237 : string = method39(v229, v233, v230, v231, v232, v234)
    let struct (v238 : string, v239 : string) = method40()
    let v240 : int32 = v237.Length
    let v241 : (char []) = Array.zeroCreate<char> (v240)
    let v242 : Mut5 = {l0 = 0} : Mut5
    while method26(v240, v242) do
        let v244 : int32 = v242.l0
        let v245 : char = v237.[int v244]
        v241.[int v244] <- v245
        let v246 : int32 = v244 + 1
        v242.l0 <- v246
        ()
    let v247 : ((char []) -> char list) = Array.toList
    let v248 : char list = v247 v241
    let v249 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v250 : (char -> (UH0 -> UH0)) = method41()
    let v251 : (char list -> (UH0 -> UH0)) = v249 v250
    let v252 : (UH0 -> UH0) = v251 v248
    let v253 : UH0 = UH0_0
    let v254 : UH0 = v252 v253
    let v255 : US8 = US8_0
    let struct (v256 : string, v257 : string) = method42(v239, v238, v254, v255)
    let v258 : (string []) = method43(v257)
    let v259 : string = "$0.to_vec()"
    let v260 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v258 v259
    let v261 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v262 : (string -> std_string_String) = closure28()
    let v263 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v260, v262) v261
    let v264 : US0 = US0_1
    let v265 : (unit -> string) = closure29(v229, v233, v230, v231, v232, v234, v256, v263)
    let v266 : (unit -> string) = method48()
    method3(v264, v265, v266)
    let v267 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method49(v229, v233, v230, v231, v232, v234, v256, v263)
    let v268 : string = "futures_lite::future::block_on($0)"
    let v269 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v267 v268
    let (a, b) = v269
    let v270 : int32 = a
    let v271 : string = b
    struct (v270, v271)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v272 : int32, v273 : string) = null |> unbox<struct (int32 * string)>
    struct (v272, v273)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v274 : int32, v275 : string) = null |> unbox<struct (int32 * string)>
    struct (v274, v275)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v276 : int32, v277 : string) = null |> unbox<struct (int32 * string)>
    struct (v276, v277)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v278 : int32, v279 : string) = null |> unbox<struct (int32 * string)>
    struct (v278, v279)
#endif
    
#else
    let v280 : Async<struct (int32 * string)> option = None
    let v281 : bool = true in let mutable _v280 = v280
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v282 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v282
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v283 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v283
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v284 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v284
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v285 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v285
#endif
    
#if FABLE_COMPILER_PYTHON
    let v286 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v286
#endif
    
#else
    let v287 : Async<struct (int32 * string)> option = None
    let v288 : bool = true in let mutable _v287 = v287
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v289 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v289
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v290 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v290
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v291 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v291
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v292 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v292
#endif
    
#if FABLE_COMPILER_PYTHON
    let v293 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v293
#endif
    
#else
    let v294 : Async<struct (int32 * string)> option = None
    let mutable _v294 = v294
    async {
    let struct (v295 : string, v296 : string) = method40()
    let v297 : int32 = v233.Length
    let v298 : (char []) = Array.zeroCreate<char> (v297)
    let v299 : Mut5 = {l0 = 0} : Mut5
    while method26(v297, v299) do
        let v301 : int32 = v299.l0
        let v302 : char = v233.[int v301]
        v298.[int v301] <- v302
        let v303 : int32 = v301 + 1
        v299.l0 <- v303
        ()
    let v304 : ((char []) -> char list) = Array.toList
    let v305 : char list = v304 v298
    let v306 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v307 : (char -> (UH0 -> UH0)) = method41()
    let v308 : (char list -> (UH0 -> UH0)) = v306 v307
    let v309 : (UH0 -> UH0) = v308 v305
    let v310 : UH0 = UH0_0
    let v311 : UH0 = v309 v310
    let v312 : US8 = US8_0
    let struct (v313 : string, v314 : string) = method42(v296, v295, v311, v312)
    let v315 : (string -> US4) = method19()
    let v316 : US4 = US4_1
    let v317 : US4 = v234 |> Option.map v315 |> Option.defaultValue v316 
    let v320 : string =
        match v317 with
        | US4_1 -> (* None *)
            v200
        | US4_0(v318) -> (* Some *)
            v318
    let v321 : US0 = US0_1
    let v322 : (unit -> string) = closure48(v229, v233, v230, v231, v232, v234)
    let v323 : (unit -> string) = method48()
    method3(v321, v322, v323)
    let v324 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v325 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v314, StandardOutputEncoding = v324, WorkingDirectory = v320, FileName = v313, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v326 : int32 = v230.Length
    let v327 : Mut5 = {l0 = 0} : Mut5
    while method26(v326, v327) do
        let v329 : int32 = v327.l0
        let struct (v330 : string, v331 : string) = v230.[int v329]
        v325.EnvironmentVariables.[v330] <- v331 
        let v332 : int32 = v329 + 1
        v327.l0 <- v332
        ()
    let v333 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v325)
    use v333 = v333 
    let v334 : System.Diagnostics.Process = v333 
    let v335 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v336 : System.Collections.Concurrent.ConcurrentStack<string> = v335 ()
    let v337 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v229, v233, v230, v231, v232, v234, v334, v336)
    v334.OutputDataReceived.Add v337 
    let v338 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v229, v233, v230, v231, v232, v234, v334, v336)
    v334.ErrorDataReceived.Add v338 
    let v339 : (unit -> bool) = v334.Start
    let v340 : bool = v339 ()
    let v341 : bool = v340 = false
    if v341 then
        let v342 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v342
    let v343 : (unit -> unit) = v334.BeginErrorReadLine
    v343 ()
    let v344 : (unit -> unit) = v334.BeginOutputReadLine
    v344 ()
    let v345 : (System.Threading.CancellationToken -> US18) = method71()
    let v346 : US18 = US18_1
    let v347 : US18 = v229 |> Option.map v345 |> Option.defaultValue v346 
    let v351 : System.Threading.CancellationToken =
        match v347 with
        | US18_1 -> (* None *)
            let v349 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v349
        | US18_0(v348) -> (* Some *)
            v348
    let v352 : Async<System.Threading.CancellationToken> option = None
    let v353 : bool = true in let mutable _v352 = v352
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v354 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v354
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v355 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v355
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v356 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v356
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v357 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v357
#endif
    
#if FABLE_COMPILER_PYTHON
    let v358 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v358
#endif
    
#else
    let v359 : Async<System.Threading.CancellationToken> option = None
    let v360 : bool = true in let mutable _v359 = v359
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v361 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v361
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v362 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v362
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v363 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v363
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v364 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v364
#endif
    
#if FABLE_COMPILER_PYTHON
    let v365 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v365
#endif
    
#else
    let v366 : Async<System.Threading.CancellationToken> option = None
    let mutable _v366 = v366
    async {
    let v367 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v367 = v367 
    let v368 : System.Threading.CancellationToken = v367 
    let v369 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v370 : (System.Threading.CancellationToken []) = [|v368; v369; v351|]
    let v371 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v372 : System.Threading.CancellationTokenSource = v371 v370
    let v373 : System.Threading.CancellationToken = v372.Token
    return v373 
    }
    |> fun x -> _v366 <- Some x
    let v374 : Async<System.Threading.CancellationToken> = _v366 |> Option.get
    v374
#endif
    |> fun x -> _v359 <- Some x
    let v375 : Async<System.Threading.CancellationToken> = _v359.Value
    v375
#endif
    |> fun x -> _v352 <- Some x
    let v376 : Async<System.Threading.CancellationToken> = _v352.Value
    let! v376 = v376 
    let v377 : System.Threading.CancellationToken = v376 
    let v378 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v377.Register
    let v379 : (unit -> unit) = closure54(v334)
    let v380 : System.Threading.CancellationTokenRegistration = v378 v379
    use v380 = v380 
    let v381 : System.Threading.CancellationTokenRegistration = v380 
    let v382 : Async<int32> option = None
    let v383 : bool = true in let mutable _v382 = v382
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v384 : Async<int32> = null |> unbox<Async<int32>>
    v384
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v385 : Async<int32> = null |> unbox<Async<int32>>
    v385
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v386 : Async<int32> = null |> unbox<Async<int32>>
    v386
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : Async<int32> = null |> unbox<Async<int32>>
    v387
#endif
    
#if FABLE_COMPILER_PYTHON
    let v388 : Async<int32> = null |> unbox<Async<int32>>
    v388
#endif
    
#else
    let v389 : Async<int32> option = None
    let mutable _v389 = v389
    async {
    try
    let v390 : System.Threading.Tasks.Task = v334.WaitForExitAsync v377 
    let v391 : Async<unit> option = None
    let v392 : bool = true in let mutable _v391 = v391
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v393 : Async<unit> = null |> unbox<Async<unit>>
    v393
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v394 : Async<unit> = null |> unbox<Async<unit>>
    v394
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v395 : Async<unit> = null |> unbox<Async<unit>>
    v395
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v396 : Async<unit> = null |> unbox<Async<unit>>
    v396
#endif
    
#if FABLE_COMPILER_PYTHON
    let v397 : Async<unit> = null |> unbox<Async<unit>>
    v397
#endif
    
#else
    let v398 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v399 : Async<unit> = v398 v390
    v399
#endif
    |> fun x -> _v391 <- Some x
    let v400 : Async<unit> = _v391.Value
    do! v400 
    let v401 : int32 = v334.ExitCode
    return v401 
    with ex ->
    let v402 : exn = ex
    let v403 : string option = None
    let v404 : bool = true in let mutable _v403 = v403
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v405 : string = $"%A{v402}"
    v405
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v406 : string = $"%A{v402}"
    v406
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v407 : string = $"%A{v402}"
    v407
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v408 : string = $"%A{v402}"
    v408
#endif
    
#if FABLE_COMPILER_PYTHON
    let v409 : string = $"%A{v402}"
    v409
#endif
    
#else
    let v410 : string = $"{v402.GetType ()}: {v402.Message}"
    v410
#endif
    |> fun x -> _v403 <- Some x
    let v411 : string = _v403.Value
    let v412 : (string -> unit) = v336.Push
    v412 v411
    let v413 : System.Threading.Tasks.TaskCanceledException = v402 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v414 : US0 = US0_3
    let v415 : (unit -> string) = closure55(v413)
    let v416 : (unit -> string) = method48()
    method3(v414, v415, v416)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v389 <- Some x
    let v417 : Async<int32> = _v389 |> Option.get
    v417
#endif
    |> fun x -> _v382 <- Some x
    let v418 : Async<int32> = _v382.Value
    let! v418 = v418 
    let v419 : int32 = v418 
    let v420 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v421 : string seq = v420 v336
    let v422 : string = method72()
    let v423 : (string -> (string seq -> string)) = String.concat
    let v424 : (string seq -> string) = v423 v422
    let v425 : string = v424 v421
    let v426 : US0 = US0_1
    let v427 : (unit -> string) = closure56(v419, v425)
    let v428 : (unit -> string) = method48()
    method3(v426, v427, v428)
    return struct (v419, v425) 
    }
    |> fun x -> _v294 <- Some x
    let v429 : Async<struct (int32 * string)> = _v294 |> Option.get
    v429
#endif
    |> fun x -> _v287 <- Some x
    let v430 : Async<struct (int32 * string)> = _v287.Value
    v430
#endif
    |> fun x -> _v280 <- Some x
    let v431 : Async<struct (int32 * string)> = _v280.Value
    let v432 : struct (int32 * string) option = None
    let v433 : bool = true in let mutable _v432 = v432
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v434 : int32, v435 : string) = null |> unbox<struct (int32 * string)>
    struct (v434, v435)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v436 : int32, v437 : string) = null |> unbox<struct (int32 * string)>
    struct (v436, v437)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v438 : int32, v439 : string) = null |> unbox<struct (int32 * string)>
    struct (v438, v439)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v440 : int32, v441 : string) = null |> unbox<struct (int32 * string)>
    struct (v440, v441)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v442 : int32, v443 : string) = null |> unbox<struct (int32 * string)>
    struct (v442, v443)
#endif
    
#else
    let v444 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v445 : int32, v446 : string) = v444 v431
    struct (v445, v446)
#endif
    |> fun x -> _v432 <- Some x
    let struct (v447 : int32, v448 : string) = _v432.Value
    struct (v447, v448)
#endif
    |> fun x -> _v235 <- Some x
    let struct (v449 : int32, v450 : string) = _v235.Value
    let v451 : string = method13(v3, v205)
    let v452 : string = method38(v451)
    let v453 : string option = None
    let v454 : System.Threading.CancellationToken option = None
    let v455 : (struct (string * string) []) = [||]
    let v456 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v457 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v458 : string = $"git hash-object \"{v452}\""
    let v459 : string option = Some v3 
    let v460 : struct (int32 * string) option = None
    let v461 : bool = true in let mutable _v460 = v460
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v462 : string = method39(v454, v458, v455, v456, v457, v459)
    let struct (v463 : string, v464 : string) = method40()
    let v465 : int32 = v462.Length
    let v466 : (char []) = Array.zeroCreate<char> (v465)
    let v467 : Mut5 = {l0 = 0} : Mut5
    while method26(v465, v467) do
        let v469 : int32 = v467.l0
        let v470 : char = v462.[int v469]
        v466.[int v469] <- v470
        let v471 : int32 = v469 + 1
        v467.l0 <- v471
        ()
    let v472 : ((char []) -> char list) = Array.toList
    let v473 : char list = v472 v466
    let v474 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v475 : (char -> (UH0 -> UH0)) = method41()
    let v476 : (char list -> (UH0 -> UH0)) = v474 v475
    let v477 : (UH0 -> UH0) = v476 v473
    let v478 : UH0 = UH0_0
    let v479 : UH0 = v477 v478
    let v480 : US8 = US8_0
    let struct (v481 : string, v482 : string) = method42(v464, v463, v479, v480)
    let v483 : (string []) = method43(v482)
    let v484 : string = "$0.to_vec()"
    let v485 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v483 v484
    let v486 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v487 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v485, v262) v486
    let v488 : US0 = US0_1
    let v489 : (unit -> string) = closure29(v454, v458, v455, v456, v457, v459, v481, v487)
    let v490 : (unit -> string) = method48()
    method3(v488, v489, v490)
    let v491 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method49(v454, v458, v455, v456, v457, v459, v481, v487)
    let v492 : string = "futures_lite::future::block_on($0)"
    let v493 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v491 v492
    let (a, b) = v493
    let v494 : int32 = a
    let v495 : string = b
    struct (v494, v495)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v496 : int32, v497 : string) = null |> unbox<struct (int32 * string)>
    struct (v496, v497)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v498 : int32, v499 : string) = null |> unbox<struct (int32 * string)>
    struct (v498, v499)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v500 : int32, v501 : string) = null |> unbox<struct (int32 * string)>
    struct (v500, v501)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v502 : int32, v503 : string) = null |> unbox<struct (int32 * string)>
    struct (v502, v503)
#endif
    
#else
    let v504 : Async<struct (int32 * string)> option = None
    let v505 : bool = true in let mutable _v504 = v504
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v506 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v506
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v507 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v507
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v508 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v508
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v509 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v509
#endif
    
#if FABLE_COMPILER_PYTHON
    let v510 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v510
#endif
    
#else
    let v511 : Async<struct (int32 * string)> option = None
    let v512 : bool = true in let mutable _v511 = v511
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v513 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v513
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v514 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v514
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v515 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v515
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v516 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v516
#endif
    
#if FABLE_COMPILER_PYTHON
    let v517 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v517
#endif
    
#else
    let v518 : Async<struct (int32 * string)> option = None
    let mutable _v518 = v518
    async {
    let struct (v519 : string, v520 : string) = method40()
    let v521 : int32 = v458.Length
    let v522 : (char []) = Array.zeroCreate<char> (v521)
    let v523 : Mut5 = {l0 = 0} : Mut5
    while method26(v521, v523) do
        let v525 : int32 = v523.l0
        let v526 : char = v458.[int v525]
        v522.[int v525] <- v526
        let v527 : int32 = v525 + 1
        v523.l0 <- v527
        ()
    let v528 : ((char []) -> char list) = Array.toList
    let v529 : char list = v528 v522
    let v530 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v531 : (char -> (UH0 -> UH0)) = method41()
    let v532 : (char list -> (UH0 -> UH0)) = v530 v531
    let v533 : (UH0 -> UH0) = v532 v529
    let v534 : UH0 = UH0_0
    let v535 : UH0 = v533 v534
    let v536 : US8 = US8_0
    let struct (v537 : string, v538 : string) = method42(v520, v519, v535, v536)
    let v539 : (string -> US4) = method19()
    let v540 : US4 = US4_1
    let v541 : US4 = v459 |> Option.map v539 |> Option.defaultValue v540 
    let v544 : string =
        match v541 with
        | US4_1 -> (* None *)
            v200
        | US4_0(v542) -> (* Some *)
            v542
    let v545 : US0 = US0_1
    let v546 : (unit -> string) = closure48(v454, v458, v455, v456, v457, v459)
    let v547 : (unit -> string) = method48()
    method3(v545, v546, v547)
    let v548 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v549 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v538, StandardOutputEncoding = v548, WorkingDirectory = v544, FileName = v537, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v550 : int32 = v455.Length
    let v551 : Mut5 = {l0 = 0} : Mut5
    while method26(v550, v551) do
        let v553 : int32 = v551.l0
        let struct (v554 : string, v555 : string) = v455.[int v553]
        v549.EnvironmentVariables.[v554] <- v555 
        let v556 : int32 = v553 + 1
        v551.l0 <- v556
        ()
    let v557 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v549)
    use v557 = v557 
    let v558 : System.Diagnostics.Process = v557 
    let v559 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v560 : System.Collections.Concurrent.ConcurrentStack<string> = v559 ()
    let v561 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v454, v458, v455, v456, v457, v459, v558, v560)
    v558.OutputDataReceived.Add v561 
    let v562 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v454, v458, v455, v456, v457, v459, v558, v560)
    v558.ErrorDataReceived.Add v562 
    let v563 : (unit -> bool) = v558.Start
    let v564 : bool = v563 ()
    let v565 : bool = v564 = false
    if v565 then
        let v566 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v566
    let v567 : (unit -> unit) = v558.BeginErrorReadLine
    v567 ()
    let v568 : (unit -> unit) = v558.BeginOutputReadLine
    v568 ()
    let v569 : (System.Threading.CancellationToken -> US18) = method71()
    let v570 : US18 = US18_1
    let v571 : US18 = v454 |> Option.map v569 |> Option.defaultValue v570 
    let v575 : System.Threading.CancellationToken =
        match v571 with
        | US18_1 -> (* None *)
            let v573 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v573
        | US18_0(v572) -> (* Some *)
            v572
    let v576 : Async<System.Threading.CancellationToken> option = None
    let v577 : bool = true in let mutable _v576 = v576
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v578 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v578
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v579 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v579
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v580 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v580
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v581 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v581
#endif
    
#if FABLE_COMPILER_PYTHON
    let v582 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v582
#endif
    
#else
    let v583 : Async<System.Threading.CancellationToken> option = None
    let v584 : bool = true in let mutable _v583 = v583
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v585 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v585
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v586 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v586
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v587 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v587
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v588 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v588
#endif
    
#if FABLE_COMPILER_PYTHON
    let v589 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v589
#endif
    
#else
    let v590 : Async<System.Threading.CancellationToken> option = None
    let mutable _v590 = v590
    async {
    let v591 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v591 = v591 
    let v592 : System.Threading.CancellationToken = v591 
    let v593 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v594 : (System.Threading.CancellationToken []) = [|v592; v593; v575|]
    let v595 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v596 : System.Threading.CancellationTokenSource = v595 v594
    let v597 : System.Threading.CancellationToken = v596.Token
    return v597 
    }
    |> fun x -> _v590 <- Some x
    let v598 : Async<System.Threading.CancellationToken> = _v590 |> Option.get
    v598
#endif
    |> fun x -> _v583 <- Some x
    let v599 : Async<System.Threading.CancellationToken> = _v583.Value
    v599
#endif
    |> fun x -> _v576 <- Some x
    let v600 : Async<System.Threading.CancellationToken> = _v576.Value
    let! v600 = v600 
    let v601 : System.Threading.CancellationToken = v600 
    let v602 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v601.Register
    let v603 : (unit -> unit) = closure54(v558)
    let v604 : System.Threading.CancellationTokenRegistration = v602 v603
    use v604 = v604 
    let v605 : System.Threading.CancellationTokenRegistration = v604 
    let v606 : Async<int32> option = None
    let v607 : bool = true in let mutable _v606 = v606
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v608 : Async<int32> = null |> unbox<Async<int32>>
    v608
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v609 : Async<int32> = null |> unbox<Async<int32>>
    v609
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v610 : Async<int32> = null |> unbox<Async<int32>>
    v610
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v611 : Async<int32> = null |> unbox<Async<int32>>
    v611
#endif
    
#if FABLE_COMPILER_PYTHON
    let v612 : Async<int32> = null |> unbox<Async<int32>>
    v612
#endif
    
#else
    let v613 : Async<int32> option = None
    let mutable _v613 = v613
    async {
    try
    let v614 : System.Threading.Tasks.Task = v558.WaitForExitAsync v601 
    let v615 : Async<unit> option = None
    let v616 : bool = true in let mutable _v615 = v615
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v617 : Async<unit> = null |> unbox<Async<unit>>
    v617
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v618 : Async<unit> = null |> unbox<Async<unit>>
    v618
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v619 : Async<unit> = null |> unbox<Async<unit>>
    v619
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v620 : Async<unit> = null |> unbox<Async<unit>>
    v620
#endif
    
#if FABLE_COMPILER_PYTHON
    let v621 : Async<unit> = null |> unbox<Async<unit>>
    v621
#endif
    
#else
    let v622 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v623 : Async<unit> = v622 v614
    v623
#endif
    |> fun x -> _v615 <- Some x
    let v624 : Async<unit> = _v615.Value
    do! v624 
    let v625 : int32 = v558.ExitCode
    return v625 
    with ex ->
    let v626 : exn = ex
    let v627 : string option = None
    let v628 : bool = true in let mutable _v627 = v627
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v629 : string = $"%A{v626}"
    v629
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v630 : string = $"%A{v626}"
    v630
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v631 : string = $"%A{v626}"
    v631
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v632 : string = $"%A{v626}"
    v632
#endif
    
#if FABLE_COMPILER_PYTHON
    let v633 : string = $"%A{v626}"
    v633
#endif
    
#else
    let v634 : string = $"{v626.GetType ()}: {v626.Message}"
    v634
#endif
    |> fun x -> _v627 <- Some x
    let v635 : string = _v627.Value
    let v636 : (string -> unit) = v560.Push
    v636 v635
    let v637 : System.Threading.Tasks.TaskCanceledException = v626 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v638 : US0 = US0_3
    let v639 : (unit -> string) = closure55(v637)
    let v640 : (unit -> string) = method48()
    method3(v638, v639, v640)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v613 <- Some x
    let v641 : Async<int32> = _v613 |> Option.get
    v641
#endif
    |> fun x -> _v606 <- Some x
    let v642 : Async<int32> = _v606.Value
    let! v642 = v642 
    let v643 : int32 = v642 
    let v644 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v645 : string seq = v644 v560
    let v646 : string = method72()
    let v647 : (string -> (string seq -> string)) = String.concat
    let v648 : (string seq -> string) = v647 v646
    let v649 : string = v648 v645
    let v650 : US0 = US0_1
    let v651 : (unit -> string) = closure56(v643, v649)
    let v652 : (unit -> string) = method48()
    method3(v650, v651, v652)
    return struct (v643, v649) 
    }
    |> fun x -> _v518 <- Some x
    let v653 : Async<struct (int32 * string)> = _v518 |> Option.get
    v653
#endif
    |> fun x -> _v511 <- Some x
    let v654 : Async<struct (int32 * string)> = _v511.Value
    v654
#endif
    |> fun x -> _v504 <- Some x
    let v655 : Async<struct (int32 * string)> = _v504.Value
    let v656 : struct (int32 * string) option = None
    let v657 : bool = true in let mutable _v656 = v656
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v658 : int32, v659 : string) = null |> unbox<struct (int32 * string)>
    struct (v658, v659)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v660 : int32, v661 : string) = null |> unbox<struct (int32 * string)>
    struct (v660, v661)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v662 : int32, v663 : string) = null |> unbox<struct (int32 * string)>
    struct (v662, v663)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v664 : int32, v665 : string) = null |> unbox<struct (int32 * string)>
    struct (v664, v665)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v666 : int32, v667 : string) = null |> unbox<struct (int32 * string)>
    struct (v666, v667)
#endif
    
#else
    let v668 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v669 : int32, v670 : string) = v668 v655
    struct (v669, v670)
#endif
    |> fun x -> _v656 <- Some x
    let struct (v671 : int32, v672 : string) = _v656.Value
    struct (v671, v672)
#endif
    |> fun x -> _v460 <- Some x
    let struct (v673 : int32, v674 : string) = _v460.Value
    let v675 : string = method13(v4, v205)
    let v676 : string = method38(v675)
    let v677 : string = "hangul.md"
    let struct (v678 : string, v679 : string) = method73(v677, v452, v4)
    let v680 : bool = v450.Contains v674
    let v681 : bool = v680 = false
    let v1246 : UH2 =
        if v681 then
            let v682 : string option = None
            let v683 : bool = true in let mutable _v682 = v682
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v684 : string = method22()
            let v685 : string = method23(v452)
            let v686 : string = method24()
            let v687 : string = $"regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v688 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v684, v685, v686) v687
            let v689 : string = "String::from($0)"
            let v690 : std_string_String = Fable.Core.RustInterop.emitRustExpr v688 v689
            let v691 : string = "fable_library_rust::String_::fromString($0)"
            let v692 : string = Fable.Core.RustInterop.emitRustExpr v690 v691
            v692
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v693 : string = null |> unbox<string>
            v693
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v694 : string = null |> unbox<string>
            v694
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v695 : string = null |> unbox<string>
            v695
#endif
            
#if FABLE_COMPILER_PYTHON
            let v696 : string = null |> unbox<string>
            v696
#endif
            
#else
            let v697 : string = System.Text.RegularExpressions.Regex.Replace (v452, v221, v200)
            v697
#endif
            |> fun x -> _v682 <- Some x
            let v698 : string = _v682.Value
            let v699 : string = $"{v698.[0] |> string |> _.ToLower()}{v698.[1..]}"
            let v700 : string = v699.Replace (v202, v203)
            let v701 : string option = None
            let v702 : System.Threading.CancellationToken option = None
            let v703 : (struct (string * string) []) = [||]
            let v704 : (struct (bool * string * int32) -> Async<unit>) option = None
            let v705 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
            let v706 : string = $"pwsh -c \"(Get-FileHash \\\"{v700}\\\" -Algorithm SHA256).Hash\""
            let v707 : struct (int32 * string) option = None
            let v708 : bool = true in let mutable _v707 = v707
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v709 : string = method39(v702, v706, v703, v704, v705, v701)
            let struct (v710 : string, v711 : string) = method40()
            let v712 : int32 = v709.Length
            let v713 : (char []) = Array.zeroCreate<char> (v712)
            let v714 : Mut5 = {l0 = 0} : Mut5
            while method26(v712, v714) do
                let v716 : int32 = v714.l0
                let v717 : char = v709.[int v716]
                v713.[int v716] <- v717
                let v718 : int32 = v716 + 1
                v714.l0 <- v718
                ()
            let v719 : ((char []) -> char list) = Array.toList
            let v720 : char list = v719 v713
            let v721 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v722 : (char -> (UH0 -> UH0)) = method41()
            let v723 : (char list -> (UH0 -> UH0)) = v721 v722
            let v724 : (UH0 -> UH0) = v723 v720
            let v725 : UH0 = UH0_0
            let v726 : UH0 = v724 v725
            let v727 : US8 = US8_0
            let struct (v728 : string, v729 : string) = method42(v711, v710, v726, v727)
            let v730 : (string []) = method43(v729)
            let v731 : string = "$0.to_vec()"
            let v732 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v730 v731
            let v733 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v734 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v732, v262) v733
            let v735 : US0 = US0_1
            let v736 : (unit -> string) = closure29(v702, v706, v703, v704, v705, v701, v728, v734)
            let v737 : (unit -> string) = method48()
            method3(v735, v736, v737)
            let v738 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method49(v702, v706, v703, v704, v705, v701, v728, v734)
            let v739 : string = "futures_lite::future::block_on($0)"
            let v740 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v738 v739
            let (a, b) = v740
            let v741 : int32 = a
            let v742 : string = b
            struct (v741, v742)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v743 : int32, v744 : string) = null |> unbox<struct (int32 * string)>
            struct (v743, v744)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v745 : int32, v746 : string) = null |> unbox<struct (int32 * string)>
            struct (v745, v746)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v747 : int32, v748 : string) = null |> unbox<struct (int32 * string)>
            struct (v747, v748)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v749 : int32, v750 : string) = null |> unbox<struct (int32 * string)>
            struct (v749, v750)
#endif
            
#else
            let v751 : Async<struct (int32 * string)> option = None
            let v752 : bool = true in let mutable _v751 = v751
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v753 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v753
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v754 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v754
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v755 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v755
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v756 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v756
#endif
            
#if FABLE_COMPILER_PYTHON
            let v757 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v757
#endif
            
#else
            let v758 : Async<struct (int32 * string)> option = None
            let v759 : bool = true in let mutable _v758 = v758
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v760 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v760
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v761 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v761
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v762 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v762
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v763 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v763
#endif
            
#if FABLE_COMPILER_PYTHON
            let v764 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v764
#endif
            
#else
            let v765 : Async<struct (int32 * string)> option = None
            let mutable _v765 = v765
            async {
            let struct (v766 : string, v767 : string) = method40()
            let v768 : int32 = v706.Length
            let v769 : (char []) = Array.zeroCreate<char> (v768)
            let v770 : Mut5 = {l0 = 0} : Mut5
            while method26(v768, v770) do
                let v772 : int32 = v770.l0
                let v773 : char = v706.[int v772]
                v769.[int v772] <- v773
                let v774 : int32 = v772 + 1
                v770.l0 <- v774
                ()
            let v775 : ((char []) -> char list) = Array.toList
            let v776 : char list = v775 v769
            let v777 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v778 : (char -> (UH0 -> UH0)) = method41()
            let v779 : (char list -> (UH0 -> UH0)) = v777 v778
            let v780 : (UH0 -> UH0) = v779 v776
            let v781 : UH0 = UH0_0
            let v782 : UH0 = v780 v781
            let v783 : US8 = US8_0
            let struct (v784 : string, v785 : string) = method42(v767, v766, v782, v783)
            let v786 : (string -> US4) = method19()
            let v787 : US4 = US4_1
            let v788 : US4 = v701 |> Option.map v786 |> Option.defaultValue v787 
            let v791 : string =
                match v788 with
                | US4_1 -> (* None *)
                    v200
                | US4_0(v789) -> (* Some *)
                    v789
            let v792 : US0 = US0_1
            let v793 : (unit -> string) = closure48(v702, v706, v703, v704, v705, v701)
            let v794 : (unit -> string) = method48()
            method3(v792, v793, v794)
            let v795 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v796 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v785, StandardOutputEncoding = v795, WorkingDirectory = v791, FileName = v784, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v797 : int32 = v703.Length
            let v798 : Mut5 = {l0 = 0} : Mut5
            while method26(v797, v798) do
                let v800 : int32 = v798.l0
                let struct (v801 : string, v802 : string) = v703.[int v800]
                v796.EnvironmentVariables.[v801] <- v802 
                let v803 : int32 = v800 + 1
                v798.l0 <- v803
                ()
            let v804 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v796)
            use v804 = v804 
            let v805 : System.Diagnostics.Process = v804 
            let v806 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v807 : System.Collections.Concurrent.ConcurrentStack<string> = v806 ()
            let v808 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v702, v706, v703, v704, v705, v701, v805, v807)
            v805.OutputDataReceived.Add v808 
            let v809 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v702, v706, v703, v704, v705, v701, v805, v807)
            v805.ErrorDataReceived.Add v809 
            let v810 : (unit -> bool) = v805.Start
            let v811 : bool = v810 ()
            let v812 : bool = v811 = false
            if v812 then
                let v813 : string = $"execute_with_options_async / process_start error"
                failwith<unit> v813
            let v814 : (unit -> unit) = v805.BeginErrorReadLine
            v814 ()
            let v815 : (unit -> unit) = v805.BeginOutputReadLine
            v815 ()
            let v816 : (System.Threading.CancellationToken -> US18) = method71()
            let v817 : US18 = US18_1
            let v818 : US18 = v702 |> Option.map v816 |> Option.defaultValue v817 
            let v822 : System.Threading.CancellationToken =
                match v818 with
                | US18_1 -> (* None *)
                    let v820 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v820
                | US18_0(v819) -> (* Some *)
                    v819
            let v823 : Async<System.Threading.CancellationToken> option = None
            let v824 : bool = true in let mutable _v823 = v823
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v825 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v825
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v826 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v826
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v827 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v827
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v828 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v828
#endif
            
#if FABLE_COMPILER_PYTHON
            let v829 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v829
#endif
            
#else
            let v830 : Async<System.Threading.CancellationToken> option = None
            let v831 : bool = true in let mutable _v830 = v830
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v832 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v832
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v833 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v833
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v834 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v834
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v835 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v835
#endif
            
#if FABLE_COMPILER_PYTHON
            let v836 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v836
#endif
            
#else
            let v837 : Async<System.Threading.CancellationToken> option = None
            let mutable _v837 = v837
            async {
            let v838 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v838 = v838 
            let v839 : System.Threading.CancellationToken = v838 
            let v840 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v841 : (System.Threading.CancellationToken []) = [|v839; v840; v822|]
            let v842 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v843 : System.Threading.CancellationTokenSource = v842 v841
            let v844 : System.Threading.CancellationToken = v843.Token
            return v844 
            }
            |> fun x -> _v837 <- Some x
            let v845 : Async<System.Threading.CancellationToken> = _v837 |> Option.get
            v845
#endif
            |> fun x -> _v830 <- Some x
            let v846 : Async<System.Threading.CancellationToken> = _v830.Value
            v846
#endif
            |> fun x -> _v823 <- Some x
            let v847 : Async<System.Threading.CancellationToken> = _v823.Value
            let! v847 = v847 
            let v848 : System.Threading.CancellationToken = v847 
            let v849 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v848.Register
            let v850 : (unit -> unit) = closure54(v805)
            let v851 : System.Threading.CancellationTokenRegistration = v849 v850
            use v851 = v851 
            let v852 : System.Threading.CancellationTokenRegistration = v851 
            let v853 : Async<int32> option = None
            let v854 : bool = true in let mutable _v853 = v853
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v855 : Async<int32> = null |> unbox<Async<int32>>
            v855
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v856 : Async<int32> = null |> unbox<Async<int32>>
            v856
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v857 : Async<int32> = null |> unbox<Async<int32>>
            v857
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v858 : Async<int32> = null |> unbox<Async<int32>>
            v858
#endif
            
#if FABLE_COMPILER_PYTHON
            let v859 : Async<int32> = null |> unbox<Async<int32>>
            v859
#endif
            
#else
            let v860 : Async<int32> option = None
            let mutable _v860 = v860
            async {
            try
            let v861 : System.Threading.Tasks.Task = v805.WaitForExitAsync v848 
            let v862 : Async<unit> option = None
            let v863 : bool = true in let mutable _v862 = v862
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v864 : Async<unit> = null |> unbox<Async<unit>>
            v864
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v865 : Async<unit> = null |> unbox<Async<unit>>
            v865
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v866 : Async<unit> = null |> unbox<Async<unit>>
            v866
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v867 : Async<unit> = null |> unbox<Async<unit>>
            v867
#endif
            
#if FABLE_COMPILER_PYTHON
            let v868 : Async<unit> = null |> unbox<Async<unit>>
            v868
#endif
            
#else
            let v869 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v870 : Async<unit> = v869 v861
            v870
#endif
            |> fun x -> _v862 <- Some x
            let v871 : Async<unit> = _v862.Value
            do! v871 
            let v872 : int32 = v805.ExitCode
            return v872 
            with ex ->
            let v873 : exn = ex
            let v874 : string option = None
            let v875 : bool = true in let mutable _v874 = v874
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v876 : string = $"%A{v873}"
            v876
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v877 : string = $"%A{v873}"
            v877
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v878 : string = $"%A{v873}"
            v878
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v879 : string = $"%A{v873}"
            v879
#endif
            
#if FABLE_COMPILER_PYTHON
            let v880 : string = $"%A{v873}"
            v880
#endif
            
#else
            let v881 : string = $"{v873.GetType ()}: {v873.Message}"
            v881
#endif
            |> fun x -> _v874 <- Some x
            let v882 : string = _v874.Value
            let v883 : (string -> unit) = v807.Push
            v883 v882
            let v884 : System.Threading.Tasks.TaskCanceledException = v873 |> unbox<System.Threading.Tasks.TaskCanceledException>
            let v885 : US0 = US0_3
            let v886 : (unit -> string) = closure55(v884)
            let v887 : (unit -> string) = method48()
            method3(v885, v886, v887)
            return -2147483648 
            (*
            *)
            }
            |> fun x -> _v860 <- Some x
            let v888 : Async<int32> = _v860 |> Option.get
            v888
#endif
            |> fun x -> _v853 <- Some x
            let v889 : Async<int32> = _v853.Value
            let! v889 = v889 
            let v890 : int32 = v889 
            let v891 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v892 : string seq = v891 v807
            let v893 : string = method72()
            let v894 : (string -> (string seq -> string)) = String.concat
            let v895 : (string seq -> string) = v894 v893
            let v896 : string = v895 v892
            let v897 : US0 = US0_1
            let v898 : (unit -> string) = closure56(v890, v896)
            let v899 : (unit -> string) = method48()
            method3(v897, v898, v899)
            return struct (v890, v896) 
            }
            |> fun x -> _v765 <- Some x
            let v900 : Async<struct (int32 * string)> = _v765 |> Option.get
            v900
#endif
            |> fun x -> _v758 <- Some x
            let v901 : Async<struct (int32 * string)> = _v758.Value
            v901
#endif
            |> fun x -> _v751 <- Some x
            let v902 : Async<struct (int32 * string)> = _v751.Value
            let v903 : struct (int32 * string) option = None
            let v904 : bool = true in let mutable _v903 = v903
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v905 : int32, v906 : string) = null |> unbox<struct (int32 * string)>
            struct (v905, v906)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v907 : int32, v908 : string) = null |> unbox<struct (int32 * string)>
            struct (v907, v908)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v909 : int32, v910 : string) = null |> unbox<struct (int32 * string)>
            struct (v909, v910)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v911 : int32, v912 : string) = null |> unbox<struct (int32 * string)>
            struct (v911, v912)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v913 : int32, v914 : string) = null |> unbox<struct (int32 * string)>
            struct (v913, v914)
#endif
            
#else
            let v915 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
            let struct (v916 : int32, v917 : string) = v915 v902
            struct (v916, v917)
#endif
            |> fun x -> _v903 <- Some x
            let struct (v918 : int32, v919 : string) = _v903.Value
            struct (v918, v919)
#endif
            |> fun x -> _v707 <- Some x
            let struct (v920 : int32, v921 : string) = _v707.Value
            let v922 : bool = v920 = 0
            let v925 : US20 =
                if v922 then
                    US20_0(v921)
                else
                    US20_1(v921)
            let v931 : string =
                match v925 with
                | US20_1(v927) -> (* Error *)
                    let v928 : string = $"resultm.get / Result value was Error: {v927}"
                    failwith<string> v928
                | US20_0(v926) -> (* Ok *)
                    v926
            let v932 : bool option = None
            let v933 : bool = true in let mutable _v932 = v932
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v934 : string = method14(v676)
            let v935 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v936 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v934 v935
            let v937 : string = "String::from($0)"
            let v938 : std_string_String = Fable.Core.RustInterop.emitRustExpr v936 v937
            let v939 : string = "std::path::PathBuf::from($0)"
            let v940 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v938 v939
            let v941 : string = "$0.exists()"
            let v942 : bool = Fable.Core.RustInterop.emitRustExpr v940 v941
            let v945 : bool =
                if v942 then
                    let v943 : string = "$0.is_file()"
                    let v944 : bool = Fable.Core.RustInterop.emitRustExpr v940 v943
                    v944
                else
                    false
            v945
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v946 : bool = null |> unbox<bool>
            v946
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v947 : bool = null |> unbox<bool>
            v947
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v948 : string = "fs"
            let v949 : IFsExistsSync = Fable.Core.JsInterop.importAll v948
            let v950 : string = "$0.existsSync($1)"
            let v951 : bool = Fable.Core.JsInterop.emitJsExpr struct (v949, v676) v950
            v951
#endif
            
#if FABLE_COMPILER_PYTHON
            let v952 : bool = null |> unbox<bool>
            v952
#endif
            
#else
            let v953 : (string -> bool) = System.IO.File.Exists
            let v954 : bool = v953 v676
            v954
#endif
            |> fun x -> _v932 <- Some x
            let v955 : bool = _v932.Value
            let v1207 : US4 =
                if v955 then
                    let v956 : string option = None
                    let v957 : bool = true in let mutable _v956 = v956
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v958 : string = method22()
                    let v959 : string = method23(v676)
                    let v960 : string = method24()
                    let v961 : string = $"regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v962 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v958, v959, v960) v961
                    let v963 : string = "String::from($0)"
                    let v964 : std_string_String = Fable.Core.RustInterop.emitRustExpr v962 v963
                    let v965 : string = "fable_library_rust::String_::fromString($0)"
                    let v966 : string = Fable.Core.RustInterop.emitRustExpr v964 v965
                    v966
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v967 : string = null |> unbox<string>
                    v967
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v968 : string = null |> unbox<string>
                    v968
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v969 : string = null |> unbox<string>
                    v969
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v970 : string = null |> unbox<string>
                    v970
#endif
                    
#else
                    let v971 : string = System.Text.RegularExpressions.Regex.Replace (v676, v221, v200)
                    v971
#endif
                    |> fun x -> _v956 <- Some x
                    let v972 : string = _v956.Value
                    let v973 : string = $"{v972.[0] |> string |> _.ToLower()}{v972.[1..]}"
                    let v974 : string = v973.Replace (v202, v203)
                    let v975 : string option = None
                    let v976 : System.Threading.CancellationToken option = None
                    let v977 : (struct (string * string) []) = [||]
                    let v978 : (struct (bool * string * int32) -> Async<unit>) option = None
                    let v979 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                    let v980 : string = $"pwsh -c \"(Get-FileHash \\\"{v974}\\\" -Algorithm SHA256).Hash\""
                    let v981 : struct (int32 * string) option = None
                    let v982 : bool = true in let mutable _v981 = v981
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v983 : string = method39(v976, v980, v977, v978, v979, v975)
                    let struct (v984 : string, v985 : string) = method40()
                    let v986 : int32 = v983.Length
                    let v987 : (char []) = Array.zeroCreate<char> (v986)
                    let v988 : Mut5 = {l0 = 0} : Mut5
                    while method26(v986, v988) do
                        let v990 : int32 = v988.l0
                        let v991 : char = v983.[int v990]
                        v987.[int v990] <- v991
                        let v992 : int32 = v990 + 1
                        v988.l0 <- v992
                        ()
                    let v993 : ((char []) -> char list) = Array.toList
                    let v994 : char list = v993 v987
                    let v995 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                    let v996 : (char -> (UH0 -> UH0)) = method41()
                    let v997 : (char list -> (UH0 -> UH0)) = v995 v996
                    let v998 : (UH0 -> UH0) = v997 v994
                    let v999 : UH0 = UH0_0
                    let v1000 : UH0 = v998 v999
                    let v1001 : US8 = US8_0
                    let struct (v1002 : string, v1003 : string) = method42(v985, v984, v1000, v1001)
                    let v1004 : (string []) = method43(v1003)
                    let v1005 : string = "$0.to_vec()"
                    let v1006 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v1004 v1005
                    let v1007 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                    let v1008 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1006, v262) v1007
                    let v1009 : US0 = US0_1
                    let v1010 : (unit -> string) = closure29(v976, v980, v977, v978, v979, v975, v1002, v1008)
                    let v1011 : (unit -> string) = method48()
                    method3(v1009, v1010, v1011)
                    let v1012 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method49(v976, v980, v977, v978, v979, v975, v1002, v1008)
                    let v1013 : string = "futures_lite::future::block_on($0)"
                    let v1014 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v1012 v1013
                    let (a, b) = v1014
                    let v1015 : int32 = a
                    let v1016 : string = b
                    struct (v1015, v1016)
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let struct (v1017 : int32, v1018 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1017, v1018)
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let struct (v1019 : int32, v1020 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1019, v1020)
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let struct (v1021 : int32, v1022 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1021, v1022)
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let struct (v1023 : int32, v1024 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1023, v1024)
#endif
                    
#else
                    let v1025 : Async<struct (int32 * string)> option = None
                    let v1026 : bool = true in let mutable _v1025 = v1025
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1027 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1027
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1028 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1028
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1029 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1029
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1030 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1030
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1031 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1031
#endif
                    
#else
                    let v1032 : Async<struct (int32 * string)> option = None
                    let v1033 : bool = true in let mutable _v1032 = v1032
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1034 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1034
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1035 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1035
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1036 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1036
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1037 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1037
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1038 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1038
#endif
                    
#else
                    let v1039 : Async<struct (int32 * string)> option = None
                    let mutable _v1039 = v1039
                    async {
                    let struct (v1040 : string, v1041 : string) = method40()
                    let v1042 : int32 = v980.Length
                    let v1043 : (char []) = Array.zeroCreate<char> (v1042)
                    let v1044 : Mut5 = {l0 = 0} : Mut5
                    while method26(v1042, v1044) do
                        let v1046 : int32 = v1044.l0
                        let v1047 : char = v980.[int v1046]
                        v1043.[int v1046] <- v1047
                        let v1048 : int32 = v1046 + 1
                        v1044.l0 <- v1048
                        ()
                    let v1049 : ((char []) -> char list) = Array.toList
                    let v1050 : char list = v1049 v1043
                    let v1051 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                    let v1052 : (char -> (UH0 -> UH0)) = method41()
                    let v1053 : (char list -> (UH0 -> UH0)) = v1051 v1052
                    let v1054 : (UH0 -> UH0) = v1053 v1050
                    let v1055 : UH0 = UH0_0
                    let v1056 : UH0 = v1054 v1055
                    let v1057 : US8 = US8_0
                    let struct (v1058 : string, v1059 : string) = method42(v1041, v1040, v1056, v1057)
                    let v1060 : (string -> US4) = method19()
                    let v1061 : US4 = US4_1
                    let v1062 : US4 = v975 |> Option.map v1060 |> Option.defaultValue v1061 
                    let v1065 : string =
                        match v1062 with
                        | US4_1 -> (* None *)
                            v200
                        | US4_0(v1063) -> (* Some *)
                            v1063
                    let v1066 : US0 = US0_1
                    let v1067 : (unit -> string) = closure48(v976, v980, v977, v978, v979, v975)
                    let v1068 : (unit -> string) = method48()
                    method3(v1066, v1067, v1068)
                    let v1069 : System.Text.Encoding = System.Text.Encoding.UTF8
                    let v1070 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v1059, StandardOutputEncoding = v1069, WorkingDirectory = v1065, FileName = v1058, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                    let v1071 : int32 = v977.Length
                    let v1072 : Mut5 = {l0 = 0} : Mut5
                    while method26(v1071, v1072) do
                        let v1074 : int32 = v1072.l0
                        let struct (v1075 : string, v1076 : string) = v977.[int v1074]
                        v1070.EnvironmentVariables.[v1075] <- v1076 
                        let v1077 : int32 = v1074 + 1
                        v1072.l0 <- v1077
                        ()
                    let v1078 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1070)
                    use v1078 = v1078 
                    let v1079 : System.Diagnostics.Process = v1078 
                    let v1080 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                    let v1081 : System.Collections.Concurrent.ConcurrentStack<string> = v1080 ()
                    let v1082 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v976, v980, v977, v978, v979, v975, v1079, v1081)
                    v1079.OutputDataReceived.Add v1082 
                    let v1083 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v976, v980, v977, v978, v979, v975, v1079, v1081)
                    v1079.ErrorDataReceived.Add v1083 
                    let v1084 : (unit -> bool) = v1079.Start
                    let v1085 : bool = v1084 ()
                    let v1086 : bool = v1085 = false
                    if v1086 then
                        let v1087 : string = $"execute_with_options_async / process_start error"
                        failwith<unit> v1087
                    let v1088 : (unit -> unit) = v1079.BeginErrorReadLine
                    v1088 ()
                    let v1089 : (unit -> unit) = v1079.BeginOutputReadLine
                    v1089 ()
                    let v1090 : (System.Threading.CancellationToken -> US18) = method71()
                    let v1091 : US18 = US18_1
                    let v1092 : US18 = v976 |> Option.map v1090 |> Option.defaultValue v1091 
                    let v1096 : System.Threading.CancellationToken =
                        match v1092 with
                        | US18_1 -> (* None *)
                            let v1094 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                            v1094
                        | US18_0(v1093) -> (* Some *)
                            v1093
                    let v1097 : Async<System.Threading.CancellationToken> option = None
                    let v1098 : bool = true in let mutable _v1097 = v1097
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1099 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1099
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1100 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1100
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1101 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1101
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1102 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1102
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1103 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1103
#endif
                    
#else
                    let v1104 : Async<System.Threading.CancellationToken> option = None
                    let v1105 : bool = true in let mutable _v1104 = v1104
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1106 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1106
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1107 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1107
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1108 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1108
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1109 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1109
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1110 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1110
#endif
                    
#else
                    let v1111 : Async<System.Threading.CancellationToken> option = None
                    let mutable _v1111 = v1111
                    async {
                    let v1112 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v1112 = v1112 
                    let v1113 : System.Threading.CancellationToken = v1112 
                    let v1114 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v1115 : (System.Threading.CancellationToken []) = [|v1113; v1114; v1096|]
                    let v1116 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v1117 : System.Threading.CancellationTokenSource = v1116 v1115
                    let v1118 : System.Threading.CancellationToken = v1117.Token
                    return v1118 
                    }
                    |> fun x -> _v1111 <- Some x
                    let v1119 : Async<System.Threading.CancellationToken> = _v1111 |> Option.get
                    v1119
#endif
                    |> fun x -> _v1104 <- Some x
                    let v1120 : Async<System.Threading.CancellationToken> = _v1104.Value
                    v1120
#endif
                    |> fun x -> _v1097 <- Some x
                    let v1121 : Async<System.Threading.CancellationToken> = _v1097.Value
                    let! v1121 = v1121 
                    let v1122 : System.Threading.CancellationToken = v1121 
                    let v1123 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1122.Register
                    let v1124 : (unit -> unit) = closure54(v1079)
                    let v1125 : System.Threading.CancellationTokenRegistration = v1123 v1124
                    use v1125 = v1125 
                    let v1126 : System.Threading.CancellationTokenRegistration = v1125 
                    let v1127 : Async<int32> option = None
                    let v1128 : bool = true in let mutable _v1127 = v1127
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1129 : Async<int32> = null |> unbox<Async<int32>>
                    v1129
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1130 : Async<int32> = null |> unbox<Async<int32>>
                    v1130
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1131 : Async<int32> = null |> unbox<Async<int32>>
                    v1131
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1132 : Async<int32> = null |> unbox<Async<int32>>
                    v1132
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1133 : Async<int32> = null |> unbox<Async<int32>>
                    v1133
#endif
                    
#else
                    let v1134 : Async<int32> option = None
                    let mutable _v1134 = v1134
                    async {
                    try
                    let v1135 : System.Threading.Tasks.Task = v1079.WaitForExitAsync v1122 
                    let v1136 : Async<unit> option = None
                    let v1137 : bool = true in let mutable _v1136 = v1136
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1138 : Async<unit> = null |> unbox<Async<unit>>
                    v1138
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1139 : Async<unit> = null |> unbox<Async<unit>>
                    v1139
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1140 : Async<unit> = null |> unbox<Async<unit>>
                    v1140
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1141 : Async<unit> = null |> unbox<Async<unit>>
                    v1141
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1142 : Async<unit> = null |> unbox<Async<unit>>
                    v1142
#endif
                    
#else
                    let v1143 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1144 : Async<unit> = v1143 v1135
                    v1144
#endif
                    |> fun x -> _v1136 <- Some x
                    let v1145 : Async<unit> = _v1136.Value
                    do! v1145 
                    let v1146 : int32 = v1079.ExitCode
                    return v1146 
                    with ex ->
                    let v1147 : exn = ex
                    let v1148 : string option = None
                    let v1149 : bool = true in let mutable _v1148 = v1148
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1150 : string = $"%A{v1147}"
                    v1150
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1151 : string = $"%A{v1147}"
                    v1151
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1152 : string = $"%A{v1147}"
                    v1152
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1153 : string = $"%A{v1147}"
                    v1153
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1154 : string = $"%A{v1147}"
                    v1154
#endif
                    
#else
                    let v1155 : string = $"{v1147.GetType ()}: {v1147.Message}"
                    v1155
#endif
                    |> fun x -> _v1148 <- Some x
                    let v1156 : string = _v1148.Value
                    let v1157 : (string -> unit) = v1081.Push
                    v1157 v1156
                    let v1158 : System.Threading.Tasks.TaskCanceledException = v1147 |> unbox<System.Threading.Tasks.TaskCanceledException>
                    let v1159 : US0 = US0_3
                    let v1160 : (unit -> string) = closure55(v1158)
                    let v1161 : (unit -> string) = method48()
                    method3(v1159, v1160, v1161)
                    return -2147483648 
                    (*
                    *)
                    }
                    |> fun x -> _v1134 <- Some x
                    let v1162 : Async<int32> = _v1134 |> Option.get
                    v1162
#endif
                    |> fun x -> _v1127 <- Some x
                    let v1163 : Async<int32> = _v1127.Value
                    let! v1163 = v1163 
                    let v1164 : int32 = v1163 
                    let v1165 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                    let v1166 : string seq = v1165 v1081
                    let v1167 : string = method72()
                    let v1168 : (string -> (string seq -> string)) = String.concat
                    let v1169 : (string seq -> string) = v1168 v1167
                    let v1170 : string = v1169 v1166
                    let v1171 : US0 = US0_1
                    let v1172 : (unit -> string) = closure56(v1164, v1170)
                    let v1173 : (unit -> string) = method48()
                    method3(v1171, v1172, v1173)
                    return struct (v1164, v1170) 
                    }
                    |> fun x -> _v1039 <- Some x
                    let v1174 : Async<struct (int32 * string)> = _v1039 |> Option.get
                    v1174
#endif
                    |> fun x -> _v1032 <- Some x
                    let v1175 : Async<struct (int32 * string)> = _v1032.Value
                    v1175
#endif
                    |> fun x -> _v1025 <- Some x
                    let v1176 : Async<struct (int32 * string)> = _v1025.Value
                    let v1177 : struct (int32 * string) option = None
                    let v1178 : bool = true in let mutable _v1177 = v1177
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let struct (v1179 : int32, v1180 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1179, v1180)
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let struct (v1181 : int32, v1182 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1181, v1182)
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let struct (v1183 : int32, v1184 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1183, v1184)
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let struct (v1185 : int32, v1186 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1185, v1186)
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let struct (v1187 : int32, v1188 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1187, v1188)
#endif
                    
#else
                    let v1189 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                    let struct (v1190 : int32, v1191 : string) = v1189 v1176
                    struct (v1190, v1191)
#endif
                    |> fun x -> _v1177 <- Some x
                    let struct (v1192 : int32, v1193 : string) = _v1177.Value
                    struct (v1192, v1193)
#endif
                    |> fun x -> _v981 <- Some x
                    let struct (v1194 : int32, v1195 : string) = _v981.Value
                    let v1196 : bool = v1194 = 0
                    let v1199 : US20 =
                        if v1196 then
                            US20_0(v1195)
                        else
                            US20_1(v1195)
                    match v1199 with
                    | US20_1(v1202) -> (* Error *)
                        US4_1
                    | US20_0(v1200) -> (* Ok *)
                        US4_0(v1200)
                else
                    US4_1
            let v1209 : bool =
                match v1207 with
                | US4_1 -> (* None *)
                    true
                | _ ->
                    false
            let v1215 : bool =
                if v1209 then
                    true
                else
                    let v1213 : string =
                        match v1207 with
                        | US4_1 -> (* None *)
                            failwith<string> "Option does not have a value."
                        | US4_0(v1210) -> (* Some *)
                            v1210
                    let v1214 : bool = v931 <> v1213
                    v1214
            if v1215 then
                let v1216 : US0 = US0_2
                let v1217 : (unit -> string) = closure57()
                let v1218 : (unit -> string) = closure58(v205, v225, v227, v450, v449, v452, v674, v673, v676, v931, v1207)
                method3(v1216, v1217, v1218)
                let v1219 : unit option = None
                let v1220 : bool = true in let mutable _v1219 = v1219
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1221 : string = method74(v676)
                let v1222 : string = "std::fs::copy(&*$0, &*v1221)"
                let v1223 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v452 v1222
                let v1224 : string = "$0.unwrap()"
                let v1225 : uint64 = Fable.Core.RustInterop.emitRustExpr v1223 v1224
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
                System.IO.File.Copy (v452, v676, true)
                ()
#endif
                |> fun x -> _v1219 <- Some x
                _v1219.Value
                let v1226 : (string -> (string -> US19)) = closure59(v4, v3, v1, v0)
                let v1227 : UH3 = UH3_0
                let v1228 : UH3 = UH3_1(v677, v452, v1226, v1227)
                let v1229 : string = "html"
                let v1230 : (string -> (string -> US19)) = closure66(v4, v3)
                let v1231 : string = "pdf"
                let v1232 : string = "epub"
                let v1233 : UH3 = UH3_0
                let v1234 : UH3 = UH3_1(v1232, v679, v1230, v1233)
                let v1235 : UH3 = UH3_1(v1231, v679, v1230, v1234)
                let v1236 : UH3 = UH3_1(v1229, v679, v1230, v1235)
                let v1237 : UH3 = UH3_1(v1232, v452, v1230, v1236)
                let v1238 : UH3 = UH3_1(v1231, v452, v1230, v1237)
                let v1239 : UH3 = UH3_1(v1229, v452, v1230, v1238)
                let v1240 : UH2 = UH2_0
                let v1241 : UH2 = UH2_1(v1239, v1240)
                UH2_1(v1228, v1241)
            else
                UH2_0
        else
            UH2_0
    let v1248 : bool =
        match v1246 with
        | UH2_0 -> (* Nil *)
            true
        | _ ->
            false
    let v1249 : bool = v1248 <> true
    let v1709 : UH2 =
        if v1249 then
            v1246
        else
            let v1250 : string = "epub"
            let struct (v1251 : string, v1252 : string) = method73(v1250, v679, v4)
            let v1253 : bool option = None
            let v1254 : bool = true in let mutable _v1253 = v1253
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1255 : string = method14(v1252)
            let v1256 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1257 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1255 v1256
            let v1258 : string = "String::from($0)"
            let v1259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1257 v1258
            let v1260 : string = "std::path::PathBuf::from($0)"
            let v1261 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1259 v1260
            let v1262 : string = "$0.exists()"
            let v1263 : bool = Fable.Core.RustInterop.emitRustExpr v1261 v1262
            let v1266 : bool =
                if v1263 then
                    let v1264 : string = "$0.is_file()"
                    let v1265 : bool = Fable.Core.RustInterop.emitRustExpr v1261 v1264
                    v1265
                else
                    false
            v1266
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1267 : bool = null |> unbox<bool>
            v1267
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1268 : bool = null |> unbox<bool>
            v1268
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1269 : string = "fs"
            let v1270 : IFsExistsSync = Fable.Core.JsInterop.importAll v1269
            let v1271 : string = "$0.existsSync($1)"
            let v1272 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1270, v1252) v1271
            v1272
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1273 : bool = null |> unbox<bool>
            v1273
#endif
            
#else
            let v1274 : (string -> bool) = System.IO.File.Exists
            let v1275 : bool = v1274 v1252
            v1275
#endif
            |> fun x -> _v1253 <- Some x
            let v1276 : bool = _v1253.Value
            let v1277 : bool = v1276 = false
            let v1312 : bool =
                if v1277 then
                    let v1278 : bool option = None
                    let v1279 : bool = true in let mutable _v1278 = v1278
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1280 : string = method14(v1251)
                    let v1281 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v1282 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1280 v1281
                    let v1283 : string = "String::from($0)"
                    let v1284 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1282 v1283
                    let v1285 : string = "std::path::PathBuf::from($0)"
                    let v1286 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1284 v1285
                    let v1287 : string = "$0.exists()"
                    let v1288 : bool = Fable.Core.RustInterop.emitRustExpr v1286 v1287
                    let v1291 : bool =
                        if v1288 then
                            let v1289 : string = "$0.is_file()"
                            let v1290 : bool = Fable.Core.RustInterop.emitRustExpr v1286 v1289
                            v1290
                        else
                            false
                    v1291
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1292 : bool = null |> unbox<bool>
                    v1292
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1293 : bool = null |> unbox<bool>
                    v1293
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1294 : IFsExistsSync = Fable.Core.JsInterop.importAll v1269
                    let v1295 : string = "$0.existsSync($1)"
                    let v1296 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1294, v1251) v1295
                    v1296
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1297 : bool = null |> unbox<bool>
                    v1297
#endif
                    
#else
                    let v1298 : (string -> bool) = System.IO.File.Exists
                    let v1299 : bool = v1298 v1251
                    v1299
#endif
                    |> fun x -> _v1278 <- Some x
                    let v1300 : bool = _v1278.Value
                    if v1300 then
                        let v1301 : US0 = US0_2
                        let v1302 : (unit -> string) = closure70()
                        let v1303 : (unit -> string) = closure71(v1251, v1252)
                        method3(v1301, v1302, v1303)
                        let v1304 : unit option = None
                        let v1305 : bool = true in let mutable _v1304 = v1304
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1306 : string = method74(v1252)
                        let v1307 : string = "std::fs::copy(&*$0, &*v1306)"
                        let v1308 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1251 v1307
                        let v1309 : string = "$0.unwrap()"
                        let v1310 : uint64 = Fable.Core.RustInterop.emitRustExpr v1308 v1309
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
                        System.IO.File.Copy (v1251, v1252, true)
                        ()
#endif
                        |> fun x -> _v1304 <- Some x
                        _v1304.Value
                        false
                    else
                        true
                else
                    true
            let v1317 : UH3 =
                if v1312 then
                    let v1313 : (string -> (string -> US19)) = closure66(v4, v3)
                    let v1314 : UH3 = UH3_0
                    UH3_1(v1250, v679, v1313, v1314)
                else
                    UH3_0
            let v1318 : string = "pdf"
            let struct (v1319 : string, v1320 : string) = method73(v1318, v679, v4)
            let v1321 : bool option = None
            let v1322 : bool = true in let mutable _v1321 = v1321
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1323 : string = method14(v1320)
            let v1324 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1325 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1323 v1324
            let v1326 : string = "String::from($0)"
            let v1327 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1325 v1326
            let v1328 : string = "std::path::PathBuf::from($0)"
            let v1329 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1327 v1328
            let v1330 : string = "$0.exists()"
            let v1331 : bool = Fable.Core.RustInterop.emitRustExpr v1329 v1330
            let v1334 : bool =
                if v1331 then
                    let v1332 : string = "$0.is_file()"
                    let v1333 : bool = Fable.Core.RustInterop.emitRustExpr v1329 v1332
                    v1333
                else
                    false
            v1334
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1335 : bool = null |> unbox<bool>
            v1335
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1336 : bool = null |> unbox<bool>
            v1336
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1337 : IFsExistsSync = Fable.Core.JsInterop.importAll v1269
            let v1338 : string = "$0.existsSync($1)"
            let v1339 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1337, v1320) v1338
            v1339
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1340 : bool = null |> unbox<bool>
            v1340
#endif
            
#else
            let v1341 : (string -> bool) = System.IO.File.Exists
            let v1342 : bool = v1341 v1320
            v1342
#endif
            |> fun x -> _v1321 <- Some x
            let v1343 : bool = _v1321.Value
            let v1344 : bool = v1343 = false
            let v1379 : bool =
                if v1344 then
                    let v1345 : bool option = None
                    let v1346 : bool = true in let mutable _v1345 = v1345
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1347 : string = method14(v1319)
                    let v1348 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v1349 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1347 v1348
                    let v1350 : string = "String::from($0)"
                    let v1351 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1349 v1350
                    let v1352 : string = "std::path::PathBuf::from($0)"
                    let v1353 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1351 v1352
                    let v1354 : string = "$0.exists()"
                    let v1355 : bool = Fable.Core.RustInterop.emitRustExpr v1353 v1354
                    let v1358 : bool =
                        if v1355 then
                            let v1356 : string = "$0.is_file()"
                            let v1357 : bool = Fable.Core.RustInterop.emitRustExpr v1353 v1356
                            v1357
                        else
                            false
                    v1358
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1359 : bool = null |> unbox<bool>
                    v1359
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1360 : bool = null |> unbox<bool>
                    v1360
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1361 : IFsExistsSync = Fable.Core.JsInterop.importAll v1269
                    let v1362 : string = "$0.existsSync($1)"
                    let v1363 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1361, v1319) v1362
                    v1363
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1364 : bool = null |> unbox<bool>
                    v1364
#endif
                    
#else
                    let v1365 : (string -> bool) = System.IO.File.Exists
                    let v1366 : bool = v1365 v1319
                    v1366
#endif
                    |> fun x -> _v1345 <- Some x
                    let v1367 : bool = _v1345.Value
                    if v1367 then
                        let v1368 : US0 = US0_2
                        let v1369 : (unit -> string) = closure70()
                        let v1370 : (unit -> string) = closure71(v1319, v1320)
                        method3(v1368, v1369, v1370)
                        let v1371 : unit option = None
                        let v1372 : bool = true in let mutable _v1371 = v1371
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1373 : string = method74(v1320)
                        let v1374 : string = "std::fs::copy(&*$0, &*v1373)"
                        let v1375 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1319 v1374
                        let v1376 : string = "$0.unwrap()"
                        let v1377 : uint64 = Fable.Core.RustInterop.emitRustExpr v1375 v1376
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
                        System.IO.File.Copy (v1319, v1320, true)
                        ()
#endif
                        |> fun x -> _v1371 <- Some x
                        _v1371.Value
                        false
                    else
                        true
                else
                    true
            let v1382 : UH3 =
                if v1379 then
                    let v1380 : (string -> (string -> US19)) = closure66(v4, v3)
                    UH3_1(v1318, v679, v1380, v1317)
                else
                    v1317
            let v1383 : string = "html"
            let struct (v1384 : string, v1385 : string) = method73(v1383, v679, v4)
            let v1386 : bool option = None
            let v1387 : bool = true in let mutable _v1386 = v1386
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1388 : string = method14(v1385)
            let v1389 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1390 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1388 v1389
            let v1391 : string = "String::from($0)"
            let v1392 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1390 v1391
            let v1393 : string = "std::path::PathBuf::from($0)"
            let v1394 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1392 v1393
            let v1395 : string = "$0.exists()"
            let v1396 : bool = Fable.Core.RustInterop.emitRustExpr v1394 v1395
            let v1399 : bool =
                if v1396 then
                    let v1397 : string = "$0.is_file()"
                    let v1398 : bool = Fable.Core.RustInterop.emitRustExpr v1394 v1397
                    v1398
                else
                    false
            v1399
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1400 : bool = null |> unbox<bool>
            v1400
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1401 : bool = null |> unbox<bool>
            v1401
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1402 : IFsExistsSync = Fable.Core.JsInterop.importAll v1269
            let v1403 : string = "$0.existsSync($1)"
            let v1404 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1402, v1385) v1403
            v1404
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1405 : bool = null |> unbox<bool>
            v1405
#endif
            
#else
            let v1406 : (string -> bool) = System.IO.File.Exists
            let v1407 : bool = v1406 v1385
            v1407
#endif
            |> fun x -> _v1386 <- Some x
            let v1408 : bool = _v1386.Value
            let v1409 : bool = v1408 = false
            let v1444 : bool =
                if v1409 then
                    let v1410 : bool option = None
                    let v1411 : bool = true in let mutable _v1410 = v1410
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1412 : string = method14(v1384)
                    let v1413 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v1414 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1412 v1413
                    let v1415 : string = "String::from($0)"
                    let v1416 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1414 v1415
                    let v1417 : string = "std::path::PathBuf::from($0)"
                    let v1418 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1416 v1417
                    let v1419 : string = "$0.exists()"
                    let v1420 : bool = Fable.Core.RustInterop.emitRustExpr v1418 v1419
                    let v1423 : bool =
                        if v1420 then
                            let v1421 : string = "$0.is_file()"
                            let v1422 : bool = Fable.Core.RustInterop.emitRustExpr v1418 v1421
                            v1422
                        else
                            false
                    v1423
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1424 : bool = null |> unbox<bool>
                    v1424
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1425 : bool = null |> unbox<bool>
                    v1425
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1426 : IFsExistsSync = Fable.Core.JsInterop.importAll v1269
                    let v1427 : string = "$0.existsSync($1)"
                    let v1428 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1426, v1384) v1427
                    v1428
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1429 : bool = null |> unbox<bool>
                    v1429
#endif
                    
#else
                    let v1430 : (string -> bool) = System.IO.File.Exists
                    let v1431 : bool = v1430 v1384
                    v1431
#endif
                    |> fun x -> _v1410 <- Some x
                    let v1432 : bool = _v1410.Value
                    if v1432 then
                        let v1433 : US0 = US0_2
                        let v1434 : (unit -> string) = closure70()
                        let v1435 : (unit -> string) = closure71(v1384, v1385)
                        method3(v1433, v1434, v1435)
                        let v1436 : unit option = None
                        let v1437 : bool = true in let mutable _v1436 = v1436
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1438 : string = method74(v1385)
                        let v1439 : string = "std::fs::copy(&*$0, &*v1438)"
                        let v1440 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1384 v1439
                        let v1441 : string = "$0.unwrap()"
                        let v1442 : uint64 = Fable.Core.RustInterop.emitRustExpr v1440 v1441
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
                        System.IO.File.Copy (v1384, v1385, true)
                        ()
#endif
                        |> fun x -> _v1436 <- Some x
                        _v1436.Value
                        false
                    else
                        true
                else
                    true
            let v1447 : UH3 =
                if v1444 then
                    let v1445 : (string -> (string -> US19)) = closure66(v4, v3)
                    UH3_1(v1383, v679, v1445, v1382)
                else
                    v1382
            let struct (v1448 : string, v1449 : string) = method73(v1250, v452, v4)
            let v1450 : bool option = None
            let v1451 : bool = true in let mutable _v1450 = v1450
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1452 : string = method14(v1449)
            let v1453 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1454 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1452 v1453
            let v1455 : string = "String::from($0)"
            let v1456 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1454 v1455
            let v1457 : string = "std::path::PathBuf::from($0)"
            let v1458 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1456 v1457
            let v1459 : string = "$0.exists()"
            let v1460 : bool = Fable.Core.RustInterop.emitRustExpr v1458 v1459
            let v1463 : bool =
                if v1460 then
                    let v1461 : string = "$0.is_file()"
                    let v1462 : bool = Fable.Core.RustInterop.emitRustExpr v1458 v1461
                    v1462
                else
                    false
            v1463
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1464 : bool = null |> unbox<bool>
            v1464
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1465 : bool = null |> unbox<bool>
            v1465
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1466 : IFsExistsSync = Fable.Core.JsInterop.importAll v1269
            let v1467 : string = "$0.existsSync($1)"
            let v1468 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1466, v1449) v1467
            v1468
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1469 : bool = null |> unbox<bool>
            v1469
#endif
            
#else
            let v1470 : (string -> bool) = System.IO.File.Exists
            let v1471 : bool = v1470 v1449
            v1471
#endif
            |> fun x -> _v1450 <- Some x
            let v1472 : bool = _v1450.Value
            let v1473 : bool = v1472 = false
            let v1508 : bool =
                if v1473 then
                    let v1474 : bool option = None
                    let v1475 : bool = true in let mutable _v1474 = v1474
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1476 : string = method14(v1448)
                    let v1477 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v1478 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1476 v1477
                    let v1479 : string = "String::from($0)"
                    let v1480 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1478 v1479
                    let v1481 : string = "std::path::PathBuf::from($0)"
                    let v1482 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1480 v1481
                    let v1483 : string = "$0.exists()"
                    let v1484 : bool = Fable.Core.RustInterop.emitRustExpr v1482 v1483
                    let v1487 : bool =
                        if v1484 then
                            let v1485 : string = "$0.is_file()"
                            let v1486 : bool = Fable.Core.RustInterop.emitRustExpr v1482 v1485
                            v1486
                        else
                            false
                    v1487
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1488 : bool = null |> unbox<bool>
                    v1488
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1489 : bool = null |> unbox<bool>
                    v1489
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1490 : IFsExistsSync = Fable.Core.JsInterop.importAll v1269
                    let v1491 : string = "$0.existsSync($1)"
                    let v1492 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1490, v1448) v1491
                    v1492
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1493 : bool = null |> unbox<bool>
                    v1493
#endif
                    
#else
                    let v1494 : (string -> bool) = System.IO.File.Exists
                    let v1495 : bool = v1494 v1448
                    v1495
#endif
                    |> fun x -> _v1474 <- Some x
                    let v1496 : bool = _v1474.Value
                    if v1496 then
                        let v1497 : US0 = US0_2
                        let v1498 : (unit -> string) = closure70()
                        let v1499 : (unit -> string) = closure71(v1448, v1449)
                        method3(v1497, v1498, v1499)
                        let v1500 : unit option = None
                        let v1501 : bool = true in let mutable _v1500 = v1500
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1502 : string = method74(v1449)
                        let v1503 : string = "std::fs::copy(&*$0, &*v1502)"
                        let v1504 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1448 v1503
                        let v1505 : string = "$0.unwrap()"
                        let v1506 : uint64 = Fable.Core.RustInterop.emitRustExpr v1504 v1505
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
                        System.IO.File.Copy (v1448, v1449, true)
                        ()
#endif
                        |> fun x -> _v1500 <- Some x
                        _v1500.Value
                        false
                    else
                        true
                else
                    true
            let v1511 : UH3 =
                if v1508 then
                    let v1509 : (string -> (string -> US19)) = closure66(v4, v3)
                    UH3_1(v1250, v452, v1509, v1447)
                else
                    v1447
            let struct (v1512 : string, v1513 : string) = method73(v1318, v452, v4)
            let v1514 : bool option = None
            let v1515 : bool = true in let mutable _v1514 = v1514
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1516 : string = method14(v1513)
            let v1517 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1518 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1516 v1517
            let v1519 : string = "String::from($0)"
            let v1520 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1518 v1519
            let v1521 : string = "std::path::PathBuf::from($0)"
            let v1522 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1520 v1521
            let v1523 : string = "$0.exists()"
            let v1524 : bool = Fable.Core.RustInterop.emitRustExpr v1522 v1523
            let v1527 : bool =
                if v1524 then
                    let v1525 : string = "$0.is_file()"
                    let v1526 : bool = Fable.Core.RustInterop.emitRustExpr v1522 v1525
                    v1526
                else
                    false
            v1527
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1528 : bool = null |> unbox<bool>
            v1528
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1529 : bool = null |> unbox<bool>
            v1529
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1530 : IFsExistsSync = Fable.Core.JsInterop.importAll v1269
            let v1531 : string = "$0.existsSync($1)"
            let v1532 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1530, v1513) v1531
            v1532
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1533 : bool = null |> unbox<bool>
            v1533
#endif
            
#else
            let v1534 : (string -> bool) = System.IO.File.Exists
            let v1535 : bool = v1534 v1513
            v1535
#endif
            |> fun x -> _v1514 <- Some x
            let v1536 : bool = _v1514.Value
            let v1537 : bool = v1536 = false
            let v1572 : bool =
                if v1537 then
                    let v1538 : bool option = None
                    let v1539 : bool = true in let mutable _v1538 = v1538
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1540 : string = method14(v1512)
                    let v1541 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v1542 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1540 v1541
                    let v1543 : string = "String::from($0)"
                    let v1544 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1542 v1543
                    let v1545 : string = "std::path::PathBuf::from($0)"
                    let v1546 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1544 v1545
                    let v1547 : string = "$0.exists()"
                    let v1548 : bool = Fable.Core.RustInterop.emitRustExpr v1546 v1547
                    let v1551 : bool =
                        if v1548 then
                            let v1549 : string = "$0.is_file()"
                            let v1550 : bool = Fable.Core.RustInterop.emitRustExpr v1546 v1549
                            v1550
                        else
                            false
                    v1551
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1552 : bool = null |> unbox<bool>
                    v1552
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1553 : bool = null |> unbox<bool>
                    v1553
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1554 : IFsExistsSync = Fable.Core.JsInterop.importAll v1269
                    let v1555 : string = "$0.existsSync($1)"
                    let v1556 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1554, v1512) v1555
                    v1556
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1557 : bool = null |> unbox<bool>
                    v1557
#endif
                    
#else
                    let v1558 : (string -> bool) = System.IO.File.Exists
                    let v1559 : bool = v1558 v1512
                    v1559
#endif
                    |> fun x -> _v1538 <- Some x
                    let v1560 : bool = _v1538.Value
                    if v1560 then
                        let v1561 : US0 = US0_2
                        let v1562 : (unit -> string) = closure70()
                        let v1563 : (unit -> string) = closure71(v1512, v1513)
                        method3(v1561, v1562, v1563)
                        let v1564 : unit option = None
                        let v1565 : bool = true in let mutable _v1564 = v1564
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1566 : string = method74(v1513)
                        let v1567 : string = "std::fs::copy(&*$0, &*v1566)"
                        let v1568 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1512 v1567
                        let v1569 : string = "$0.unwrap()"
                        let v1570 : uint64 = Fable.Core.RustInterop.emitRustExpr v1568 v1569
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
                        System.IO.File.Copy (v1512, v1513, true)
                        ()
#endif
                        |> fun x -> _v1564 <- Some x
                        _v1564.Value
                        false
                    else
                        true
                else
                    true
            let v1575 : UH3 =
                if v1572 then
                    let v1573 : (string -> (string -> US19)) = closure66(v4, v3)
                    UH3_1(v1318, v452, v1573, v1511)
                else
                    v1511
            let struct (v1576 : string, v1577 : string) = method73(v1383, v452, v4)
            let v1578 : bool option = None
            let v1579 : bool = true in let mutable _v1578 = v1578
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1580 : string = method14(v1577)
            let v1581 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1582 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1580 v1581
            let v1583 : string = "String::from($0)"
            let v1584 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1582 v1583
            let v1585 : string = "std::path::PathBuf::from($0)"
            let v1586 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1584 v1585
            let v1587 : string = "$0.exists()"
            let v1588 : bool = Fable.Core.RustInterop.emitRustExpr v1586 v1587
            let v1591 : bool =
                if v1588 then
                    let v1589 : string = "$0.is_file()"
                    let v1590 : bool = Fable.Core.RustInterop.emitRustExpr v1586 v1589
                    v1590
                else
                    false
            v1591
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1592 : bool = null |> unbox<bool>
            v1592
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1593 : bool = null |> unbox<bool>
            v1593
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1594 : IFsExistsSync = Fable.Core.JsInterop.importAll v1269
            let v1595 : string = "$0.existsSync($1)"
            let v1596 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1594, v1577) v1595
            v1596
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1597 : bool = null |> unbox<bool>
            v1597
#endif
            
#else
            let v1598 : (string -> bool) = System.IO.File.Exists
            let v1599 : bool = v1598 v1577
            v1599
#endif
            |> fun x -> _v1578 <- Some x
            let v1600 : bool = _v1578.Value
            let v1601 : bool = v1600 = false
            let v1636 : bool =
                if v1601 then
                    let v1602 : bool option = None
                    let v1603 : bool = true in let mutable _v1602 = v1602
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1604 : string = method14(v1576)
                    let v1605 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v1606 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1604 v1605
                    let v1607 : string = "String::from($0)"
                    let v1608 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1606 v1607
                    let v1609 : string = "std::path::PathBuf::from($0)"
                    let v1610 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1608 v1609
                    let v1611 : string = "$0.exists()"
                    let v1612 : bool = Fable.Core.RustInterop.emitRustExpr v1610 v1611
                    let v1615 : bool =
                        if v1612 then
                            let v1613 : string = "$0.is_file()"
                            let v1614 : bool = Fable.Core.RustInterop.emitRustExpr v1610 v1613
                            v1614
                        else
                            false
                    v1615
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1616 : bool = null |> unbox<bool>
                    v1616
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1617 : bool = null |> unbox<bool>
                    v1617
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1618 : IFsExistsSync = Fable.Core.JsInterop.importAll v1269
                    let v1619 : string = "$0.existsSync($1)"
                    let v1620 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1618, v1576) v1619
                    v1620
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1621 : bool = null |> unbox<bool>
                    v1621
#endif
                    
#else
                    let v1622 : (string -> bool) = System.IO.File.Exists
                    let v1623 : bool = v1622 v1576
                    v1623
#endif
                    |> fun x -> _v1602 <- Some x
                    let v1624 : bool = _v1602.Value
                    if v1624 then
                        let v1625 : US0 = US0_2
                        let v1626 : (unit -> string) = closure70()
                        let v1627 : (unit -> string) = closure71(v1576, v1577)
                        method3(v1625, v1626, v1627)
                        let v1628 : unit option = None
                        let v1629 : bool = true in let mutable _v1628 = v1628
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1630 : string = method74(v1577)
                        let v1631 : string = "std::fs::copy(&*$0, &*v1630)"
                        let v1632 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1576 v1631
                        let v1633 : string = "$0.unwrap()"
                        let v1634 : uint64 = Fable.Core.RustInterop.emitRustExpr v1632 v1633
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
                        System.IO.File.Copy (v1576, v1577, true)
                        ()
#endif
                        |> fun x -> _v1628 <- Some x
                        _v1628.Value
                        false
                    else
                        true
                else
                    true
            let v1639 : UH3 =
                if v1636 then
                    let v1637 : (string -> (string -> US19)) = closure66(v4, v3)
                    UH3_1(v1383, v452, v1637, v1575)
                else
                    v1575
            let struct (v1640 : string, v1641 : string) = method73(v677, v452, v4)
            let v1642 : bool option = None
            let v1643 : bool = true in let mutable _v1642 = v1642
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1644 : string = method14(v1641)
            let v1645 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1646 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1644 v1645
            let v1647 : string = "String::from($0)"
            let v1648 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1646 v1647
            let v1649 : string = "std::path::PathBuf::from($0)"
            let v1650 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1648 v1649
            let v1651 : string = "$0.exists()"
            let v1652 : bool = Fable.Core.RustInterop.emitRustExpr v1650 v1651
            let v1655 : bool =
                if v1652 then
                    let v1653 : string = "$0.is_file()"
                    let v1654 : bool = Fable.Core.RustInterop.emitRustExpr v1650 v1653
                    v1654
                else
                    false
            v1655
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1656 : bool = null |> unbox<bool>
            v1656
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1657 : bool = null |> unbox<bool>
            v1657
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1658 : IFsExistsSync = Fable.Core.JsInterop.importAll v1269
            let v1659 : string = "$0.existsSync($1)"
            let v1660 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1658, v1641) v1659
            v1660
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1661 : bool = null |> unbox<bool>
            v1661
#endif
            
#else
            let v1662 : (string -> bool) = System.IO.File.Exists
            let v1663 : bool = v1662 v1641
            v1663
#endif
            |> fun x -> _v1642 <- Some x
            let v1664 : bool = _v1642.Value
            let v1665 : bool = v1664 = false
            let v1700 : bool =
                if v1665 then
                    let v1666 : bool option = None
                    let v1667 : bool = true in let mutable _v1666 = v1666
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1668 : string = method14(v1640)
                    let v1669 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v1670 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1668 v1669
                    let v1671 : string = "String::from($0)"
                    let v1672 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1670 v1671
                    let v1673 : string = "std::path::PathBuf::from($0)"
                    let v1674 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1672 v1673
                    let v1675 : string = "$0.exists()"
                    let v1676 : bool = Fable.Core.RustInterop.emitRustExpr v1674 v1675
                    let v1679 : bool =
                        if v1676 then
                            let v1677 : string = "$0.is_file()"
                            let v1678 : bool = Fable.Core.RustInterop.emitRustExpr v1674 v1677
                            v1678
                        else
                            false
                    v1679
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1680 : bool = null |> unbox<bool>
                    v1680
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1681 : bool = null |> unbox<bool>
                    v1681
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1682 : IFsExistsSync = Fable.Core.JsInterop.importAll v1269
                    let v1683 : string = "$0.existsSync($1)"
                    let v1684 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1682, v1640) v1683
                    v1684
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1685 : bool = null |> unbox<bool>
                    v1685
#endif
                    
#else
                    let v1686 : (string -> bool) = System.IO.File.Exists
                    let v1687 : bool = v1686 v1640
                    v1687
#endif
                    |> fun x -> _v1666 <- Some x
                    let v1688 : bool = _v1666.Value
                    if v1688 then
                        let v1689 : US0 = US0_2
                        let v1690 : (unit -> string) = closure70()
                        let v1691 : (unit -> string) = closure71(v1640, v1641)
                        method3(v1689, v1690, v1691)
                        let v1692 : unit option = None
                        let v1693 : bool = true in let mutable _v1692 = v1692
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1694 : string = method74(v1641)
                        let v1695 : string = "std::fs::copy(&*$0, &*v1694)"
                        let v1696 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1640 v1695
                        let v1697 : string = "$0.unwrap()"
                        let v1698 : uint64 = Fable.Core.RustInterop.emitRustExpr v1696 v1697
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
                        System.IO.File.Copy (v1640, v1641, true)
                        ()
#endif
                        |> fun x -> _v1692 <- Some x
                        _v1692.Value
                        false
                    else
                        true
                else
                    true
            let v1705 : UH3 =
                if v1700 then
                    let v1701 : (string -> (string -> US19)) = closure59(v4, v3, v1, v0)
                    let v1702 : UH3 = UH3_0
                    UH3_1(v677, v452, v1701, v1702)
                else
                    UH3_0
            let v1706 : UH2 = UH2_0
            let v1707 : UH2 = UH2_1(v1639, v1706)
            UH2_1(v1705, v1707)
    let v1710 : UH3 list = []
    let v1711 : UH3 list = method82(v1709, v1710)
    let v1712 : (UH3 list -> (UH3 [])) = List.toArray
    let v1713 : (UH3 []) = v1712 v1711
    let v1714 : string = "$0.to_vec()"
    let v1715 : Vec<UH3> = Fable.Core.RustInterop.emitRustExpr v1713 v1714
    let v1716 : (Result<string, (string * string)> option []) = [||]
    let v1717 : string = "$0.to_vec()"
    let v1718 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1716 v1717
    let v1719 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v1720 : (UH3 []) = Fable.Core.RustInterop.emitRustExpr v1715 v1719
    let v1721 : int32 = v1720.Length
    let v1722 : Mut8 = {l0 = 0; l1 = v1718} : Mut8
    while method83(v1721, v1722) do
        let v1724 : int32 = v1722.l0
        let v1725 : Vec<Result<string, (string * string)> option> = v1722.l1
        let v1726 : UH3 = v1720.[int v1724]
        let v1727 : struct (string * string * (string -> (string -> US19))) list = []
        let v1728 : struct (string * string * (string -> (string -> US19))) list = method84(v1726, v1727)
        let v1729 : (struct (string * string * (string -> (string -> US19))) list -> (struct (string * string * (string -> (string -> US19))) [])) = List.toArray
        let v1730 : (struct (string * string * (string -> (string -> US19))) []) = v1729 v1728
        let v1731 : string = "$0.to_vec()"
        let v1732 : Vec<struct (string * string * (string -> (string -> US19)))> = Fable.Core.RustInterop.emitRustExpr v1730 v1731
        let v1733 : string = "rayon::iter::IntoParallelIterator::into_par_iter(v1732)"
        let v1734 : rayon_vec_IntoIter<struct (string * string * (string -> (string -> US19)))> = Fable.Core.RustInterop.emitRustExpr () v1733
        let v1735 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
        let v1736 : (struct (string * string * (string -> (string -> US19))) -> Result<string, (string * string)> option) = closure72()
        let v1737 : rayon_iter_Map<rayon_vec_IntoIter<struct (string * string * (string -> (string -> US19)))>> = Fable.Core.RustInterop.emitRustExpr struct (v1734, v1736) v1735
        let v1738 : string = "rayon::iter::ParallelIterator::collect($0)"
        let v1739 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1737 v1738
        let v1740 : Vec<Result<string, (string * string)> option> = method85(v1739)
        let v1741 : Vec<Result<string, (string * string)> option> = method86(v1725)
        let v1742 : string = "let mut v1741 = v1741"
        Fable.Core.RustInterop.emitRustExpr () v1742
        let v1743 : string = "v1741.extend(v1740)"
        Fable.Core.RustInterop.emitRustExpr () v1743
        let v1744 : string = "v1741"
        let v1745 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr () v1744
        let v1746 : int32 = v1724 + 1
        v1722.l0 <- v1746
        v1722.l1 <- v1745
        ()
    let v1747 : Vec<Result<string, (string * string)> option> = v1722.l1
    let v1748 : (string * Vec<Result<string, (string * string)> option>) = v225, v1747
    let v1749 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v1748
    v1749
and closure73 () () : string =
    let v0 : string = "documents.run"
    v0
and closure74 (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) () : string =
    let v1 : string = "$0.len()"
    let v2 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"result_len: {v2} / {v3 ()}"
    v4
and method87 (v0 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>) : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> =
    v0
and method29 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> =
    let v5 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v5
    let v6 : string = "async_walkdir::WalkDir::new(&*$0)"
    let v7 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr v3 v6
    let v8 : string = "async_walkdir::WalkDir::filter($0, |x| $1(x))"
    let v9 : (async_walkdir_DirEntry -> std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>) = closure14()
    let v10 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr struct (v7, v9) v8
    let v11 : (Result<async_walkdir_DirEntry, std_io_Error> -> string option) = method37()
    let v12 : string = "futures_lite::stream::StreamExt::collect(futures_lite::stream::StreamExt::filter_map(v10, |x| v11(x))).await"
    let v13 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : US0 = US0_1
    let v15 : (unit -> string) = closure23()
    let v16 : (unit -> string) = closure24(v13)
    method3(v14, v15, v16)
    let v17 : string = "rayon::iter::IntoParallelIterator::into_par_iter(v13)"
    let v18 : rayon_vec_IntoIter<string> = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
    let v20 : (string -> Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>) = closure25(v0, v1, v2, v3, v4)
    let v21 : rayon_iter_Map<rayon_vec_IntoIter<string>> = Fable.Core.RustInterop.emitRustExpr struct (v18, v20) v19
    let v22 : string = "rayon::iter::ParallelIterator::collect($0)"
    let v23 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = Fable.Core.RustInterop.emitRustExpr v21 v22
    let v24 : US0 = US0_1
    let v25 : (unit -> string) = closure73()
    let v26 : (unit -> string) = closure74(v23)
    method3(v24, v25, v26)
    let v27 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Ok v23
    let v28 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = method87(v27)
    let v29 : string = "v28 }}}})"
    Fable.Core.RustInterop.emitRustExpr () v29
    let v30 : string = "{{{ //"
    Fable.Core.RustInterop.emitRustExpr () v30
    let v31 : string = "__result"
    let v32 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v31
    v32
and method12 (v0 : string, v1 : string, v2 : string, v3 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> =
    let v4 : string = __SOURCE_DIRECTORY__
    let v5 : string = "polyglot"
    let v6 : string = ".paket"
    let v7 : string = method13(v5, v6)
    let v8 : string = method17(v7, v4)
    let v9 : string = method13(v8, v5)
    let v10 : string option = None
    let v11 : bool = true in let mutable _v10 = v10
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : string = method21(v3)
    let v13 : string = method14(v12)
    let v14 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v15 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "String::from($0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : string = "std::path::PathBuf::from($0)"
    let v19 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v17 v18
    let v20 : string = "$0.exists()"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : bool = v21 = false
    let v172 : string =
        if v22 then
            let v23 : string option = None
            let v24 : bool = true in let mutable _v23 = v23
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v25 : string = "std::env::current_dir()"
            let v26 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v25
            let v27 : string = "$0.unwrap()"
            let v28 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v26 v27
            let v29 : string = "$0.display()"
            let v30 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v28 v29
            let v31 : std_string_String option = None
            let v32 : bool = true in let mutable _v31 = v31
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v33 : string = @$"format!(""{{}}"", $0)"
            let v34 : std_string_String = Fable.Core.RustInterop.emitRustExpr v30 v33
            v34
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v35 : string = @$"format!(""{{}}"", $0)"
            let v36 : std_string_String = Fable.Core.RustInterop.emitRustExpr v30 v35
            v36
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v37 : string = @$"format!(""{{}}"", $0)"
            let v38 : std_string_String = Fable.Core.RustInterop.emitRustExpr v30 v37
            v38
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v39 : std_string_String = null |> unbox<std_string_String>
            v39
#endif
            
#if FABLE_COMPILER_PYTHON
            let v40 : std_string_String = null |> unbox<std_string_String>
            v40
#endif
            
#else
            let v41 : std_string_String = null |> unbox<std_string_String>
            v41
#endif
            |> fun x -> _v31 <- Some x
            let v42 : std_string_String = _v31.Value
            let v43 : string = "fable_library_rust::String_::fromString($0)"
            let v44 : string = Fable.Core.RustInterop.emitRustExpr v42 v43
            v44
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v45 : string = null |> unbox<string>
            v45
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v46 : string = null |> unbox<string>
            v46
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v47 : string = null |> unbox<string>
            v47
#endif
            
#if FABLE_COMPILER_PYTHON
            let v48 : string = null |> unbox<string>
            v48
#endif
            
#else
            let v49 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v50 : string = v49 ()
            v50
#endif
            |> fun x -> _v23 <- Some x
            let v51 : string = _v23.Value
            let v52 : string = method13(v51, v12)
            let v53 : string option = None
            let v54 : bool = true in let mutable _v53 = v53
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v55 : string = method22()
            let v56 : string = method23(v52)
            let v57 : string = method24()
            let v58 : string = $"regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v59 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v55, v56, v57) v58
            let v60 : string = "String::from($0)"
            let v61 : std_string_String = Fable.Core.RustInterop.emitRustExpr v59 v60
            let v62 : string = "fable_library_rust::String_::fromString($0)"
            let v63 : string = Fable.Core.RustInterop.emitRustExpr v61 v62
            v63
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v64 : string = null |> unbox<string>
            v64
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v65 : string = null |> unbox<string>
            v65
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : string = null |> unbox<string>
            v66
#endif
            
#if FABLE_COMPILER_PYTHON
            let v67 : string = null |> unbox<string>
            v67
#endif
            
#else
            let v68 : string = "^\\\\\\\\\\?\\\\"
            let v69 : string = ""
            let v70 : string = System.Text.RegularExpressions.Regex.Replace (v52, v68, v69)
            v70
#endif
            |> fun x -> _v53 <- Some x
            let v71 : string = _v53.Value
            let v72 : string = $"{v71.[0] |> string |> _.ToLower()}{v71.[1..]}"
            let v73 : string = "\\"
            let v74 : string = "/"
            let v75 : string = v72.Replace (v73, v74)
            let v76 : (string []) = v75.Split v74
            let v77 : (string []) = [||]
            let v78 : int32 = v76.Length
            let v79 : Mut4 = {l0 = 0; l1 = 0; l2 = v77} : Mut4
            while method25(v78, v79) do
                let v81 : int32 = v79.l0
                let v82 : int32 =  -v81
                let v83 : int32 = v82 + v78
                let v84 : int32 = v83 - 1
                let struct (v85 : int32, v86 : (string [])) = v79.l1, v79.l2
                let v87 : string = v76.[int v84]
                let v88 : bool = ".." = v87
                let struct (v130 : int32, v131 : (string [])) =
                    if v88 then
                        let v89 : int32 = v85 + 1
                        struct (v89, v86)
                    else
                        let v90 : bool = "." = v87
                        if v90 then
                            struct (v85, v86)
                        else
                            let v91 : bool = 0 = v85
                            if v91 then
                                let v92 : string = ":"
                                let v93 : bool = v87.EndsWith v92
                                if v93 then
                                    let v94 : string = $"{v51.[0]}:"
                                    let v95 : (string []) = [|v94|]
                                    let v96 : int32 = v95.Length
                                    let v97 : int32 = v86.Length
                                    let v98 : int32 = v96 + v97
                                    let v99 : (string []) = Array.zeroCreate<string> (v98)
                                    let v100 : Mut5 = {l0 = 0} : Mut5
                                    while method26(v98, v100) do
                                        let v102 : int32 = v100.l0
                                        let v103 : bool = v102 < v96
                                        let v107 : string =
                                            if v103 then
                                                let v104 : string = v95.[int v102]
                                                v104
                                            else
                                                let v105 : int32 = v102 - v96
                                                let v106 : string = v86.[int v105]
                                                v106
                                        v99.[int v102] <- v107
                                        let v108 : int32 = v102 + 1
                                        v100.l0 <- v108
                                        ()
                                    struct (0, v99)
                                else
                                    let v109 : (string []) = [|v87|]
                                    let v110 : int32 = v109.Length
                                    let v111 : int32 = v86.Length
                                    let v112 : int32 = v110 + v111
                                    let v113 : (string []) = Array.zeroCreate<string> (v112)
                                    let v114 : Mut5 = {l0 = 0} : Mut5
                                    while method26(v112, v114) do
                                        let v116 : int32 = v114.l0
                                        let v117 : bool = v116 < v110
                                        let v121 : string =
                                            if v117 then
                                                let v118 : string = v109.[int v116]
                                                v118
                                            else
                                                let v119 : int32 = v116 - v110
                                                let v120 : string = v86.[int v119]
                                                v120
                                        v113.[int v116] <- v121
                                        let v122 : int32 = v116 + 1
                                        v114.l0 <- v122
                                        ()
                                    struct (0, v113)
                            else
                                let v125 : int32 = v85 - 1
                                struct (v125, v86)
                let v132 : int32 = v81 + 1
                v79.l0 <- v132
                v79.l1 <- v130
                v79.l2 <- v131
                ()
            let struct (v133 : int32, v134 : (string [])) = v79.l1, v79.l2
            let v135 : string seq = seq { for i = 0 to v134.Length - 1 do yield v134.[i] }
            let v136 : char option = None
            let v137 : bool = true in let mutable _v136 = v136
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v138 : string = "std::path::MAIN_SEPARATOR"
            let v139 : char = Fable.Core.RustInterop.emitRustExpr () v138
            v139
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v140 : char = null |> unbox<char>
            v140
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v141 : char = null |> unbox<char>
            v141
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v142 : char = null |> unbox<char>
            v142
#endif
            
#if FABLE_COMPILER_PYTHON
            let v143 : char = null |> unbox<char>
            v143
#endif
            
#else
            let v144 : char = System.IO.Path.DirectorySeparatorChar
            v144
#endif
            |> fun x -> _v136 <- Some x
            let v145 : char = _v136.Value
            let v146 : (char -> string) = _.ToString()
            let v147 : string = v146 v145
            let v148 : string = method27(v147)
            let v149 : (string -> (string seq -> string)) = String.concat
            let v150 : (string seq -> string) = v149 v148
            v150 v135
        else
            let v152 : string = "std::fs::canonicalize(&*$0)"
            let v153 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v12 v152
            let v154 : string = "$0.unwrap()"
            let v155 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v153 v154
            let v156 : string = "$0.display()"
            let v157 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v155 v156
            let v158 : std_string_String option = None
            let v159 : bool = true in let mutable _v158 = v158
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v160 : string = @$"format!(""{{}}"", $0)"
            let v161 : std_string_String = Fable.Core.RustInterop.emitRustExpr v157 v160
            v161
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v162 : string = @$"format!(""{{}}"", $0)"
            let v163 : std_string_String = Fable.Core.RustInterop.emitRustExpr v157 v162
            v163
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v164 : string = @$"format!(""{{}}"", $0)"
            let v165 : std_string_String = Fable.Core.RustInterop.emitRustExpr v157 v164
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
            |> fun x -> _v158 <- Some x
            let v169 : std_string_String = _v158.Value
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
    let v177 : string = method28(v3)
    let v178 : (string -> string) = System.IO.Path.GetFullPath
    let v179 : string = v178 v177
    v179
#endif
    |> fun x -> _v10 <- Some x
    let v180 : string = _v10.Value
    let v181 : string option = None
    let v182 : bool = true in let mutable _v181 = v181
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v183 : string = method21(v2)
    let v184 : string = method14(v183)
    let v185 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v186 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v184 v185
    let v187 : string = "String::from($0)"
    let v188 : std_string_String = Fable.Core.RustInterop.emitRustExpr v186 v187
    let v189 : string = "std::path::PathBuf::from($0)"
    let v190 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v188 v189
    let v191 : string = "$0.exists()"
    let v192 : bool = Fable.Core.RustInterop.emitRustExpr v190 v191
    let v193 : bool = v192 = false
    let v343 : string =
        if v193 then
            let v194 : string option = None
            let v195 : bool = true in let mutable _v194 = v194
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v196 : string = "std::env::current_dir()"
            let v197 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v196
            let v198 : string = "$0.unwrap()"
            let v199 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v197 v198
            let v200 : string = "$0.display()"
            let v201 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v199 v200
            let v202 : std_string_String option = None
            let v203 : bool = true in let mutable _v202 = v202
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v204 : string = @$"format!(""{{}}"", $0)"
            let v205 : std_string_String = Fable.Core.RustInterop.emitRustExpr v201 v204
            v205
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v206 : string = @$"format!(""{{}}"", $0)"
            let v207 : std_string_String = Fable.Core.RustInterop.emitRustExpr v201 v206
            v207
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v208 : string = @$"format!(""{{}}"", $0)"
            let v209 : std_string_String = Fable.Core.RustInterop.emitRustExpr v201 v208
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
            |> fun x -> _v202 <- Some x
            let v213 : std_string_String = _v202.Value
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
            |> fun x -> _v194 <- Some x
            let v222 : string = _v194.Value
            let v223 : string = method13(v222, v183)
            let v224 : string option = None
            let v225 : bool = true in let mutable _v224 = v224
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v226 : string = method22()
            let v227 : string = method23(v223)
            let v228 : string = method24()
            let v229 : string = $"regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v230 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v226, v227, v228) v229
            let v231 : string = "String::from($0)"
            let v232 : std_string_String = Fable.Core.RustInterop.emitRustExpr v230 v231
            let v233 : string = "fable_library_rust::String_::fromString($0)"
            let v234 : string = Fable.Core.RustInterop.emitRustExpr v232 v233
            v234
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v235 : string = null |> unbox<string>
            v235
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v236 : string = null |> unbox<string>
            v236
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v237 : string = null |> unbox<string>
            v237
#endif
            
#if FABLE_COMPILER_PYTHON
            let v238 : string = null |> unbox<string>
            v238
#endif
            
#else
            let v239 : string = "^\\\\\\\\\\?\\\\"
            let v240 : string = ""
            let v241 : string = System.Text.RegularExpressions.Regex.Replace (v223, v239, v240)
            v241
#endif
            |> fun x -> _v224 <- Some x
            let v242 : string = _v224.Value
            let v243 : string = $"{v242.[0] |> string |> _.ToLower()}{v242.[1..]}"
            let v244 : string = "\\"
            let v245 : string = "/"
            let v246 : string = v243.Replace (v244, v245)
            let v247 : (string []) = v246.Split v245
            let v248 : (string []) = [||]
            let v249 : int32 = v247.Length
            let v250 : Mut4 = {l0 = 0; l1 = 0; l2 = v248} : Mut4
            while method25(v249, v250) do
                let v252 : int32 = v250.l0
                let v253 : int32 =  -v252
                let v254 : int32 = v253 + v249
                let v255 : int32 = v254 - 1
                let struct (v256 : int32, v257 : (string [])) = v250.l1, v250.l2
                let v258 : string = v247.[int v255]
                let v259 : bool = ".." = v258
                let struct (v301 : int32, v302 : (string [])) =
                    if v259 then
                        let v260 : int32 = v256 + 1
                        struct (v260, v257)
                    else
                        let v261 : bool = "." = v258
                        if v261 then
                            struct (v256, v257)
                        else
                            let v262 : bool = 0 = v256
                            if v262 then
                                let v263 : string = ":"
                                let v264 : bool = v258.EndsWith v263
                                if v264 then
                                    let v265 : string = $"{v222.[0]}:"
                                    let v266 : (string []) = [|v265|]
                                    let v267 : int32 = v266.Length
                                    let v268 : int32 = v257.Length
                                    let v269 : int32 = v267 + v268
                                    let v270 : (string []) = Array.zeroCreate<string> (v269)
                                    let v271 : Mut5 = {l0 = 0} : Mut5
                                    while method26(v269, v271) do
                                        let v273 : int32 = v271.l0
                                        let v274 : bool = v273 < v267
                                        let v278 : string =
                                            if v274 then
                                                let v275 : string = v266.[int v273]
                                                v275
                                            else
                                                let v276 : int32 = v273 - v267
                                                let v277 : string = v257.[int v276]
                                                v277
                                        v270.[int v273] <- v278
                                        let v279 : int32 = v273 + 1
                                        v271.l0 <- v279
                                        ()
                                    struct (0, v270)
                                else
                                    let v280 : (string []) = [|v258|]
                                    let v281 : int32 = v280.Length
                                    let v282 : int32 = v257.Length
                                    let v283 : int32 = v281 + v282
                                    let v284 : (string []) = Array.zeroCreate<string> (v283)
                                    let v285 : Mut5 = {l0 = 0} : Mut5
                                    while method26(v283, v285) do
                                        let v287 : int32 = v285.l0
                                        let v288 : bool = v287 < v281
                                        let v292 : string =
                                            if v288 then
                                                let v289 : string = v280.[int v287]
                                                v289
                                            else
                                                let v290 : int32 = v287 - v281
                                                let v291 : string = v257.[int v290]
                                                v291
                                        v284.[int v287] <- v292
                                        let v293 : int32 = v287 + 1
                                        v285.l0 <- v293
                                        ()
                                    struct (0, v284)
                            else
                                let v296 : int32 = v256 - 1
                                struct (v296, v257)
                let v303 : int32 = v252 + 1
                v250.l0 <- v303
                v250.l1 <- v301
                v250.l2 <- v302
                ()
            let struct (v304 : int32, v305 : (string [])) = v250.l1, v250.l2
            let v306 : string seq = seq { for i = 0 to v305.Length - 1 do yield v305.[i] }
            let v307 : char option = None
            let v308 : bool = true in let mutable _v307 = v307
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v309 : string = "std::path::MAIN_SEPARATOR"
            let v310 : char = Fable.Core.RustInterop.emitRustExpr () v309
            v310
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v311 : char = null |> unbox<char>
            v311
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v312 : char = null |> unbox<char>
            v312
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v313 : char = null |> unbox<char>
            v313
#endif
            
#if FABLE_COMPILER_PYTHON
            let v314 : char = null |> unbox<char>
            v314
#endif
            
#else
            let v315 : char = System.IO.Path.DirectorySeparatorChar
            v315
#endif
            |> fun x -> _v307 <- Some x
            let v316 : char = _v307.Value
            let v317 : (char -> string) = _.ToString()
            let v318 : string = v317 v316
            let v319 : string = method27(v318)
            let v320 : (string -> (string seq -> string)) = String.concat
            let v321 : (string seq -> string) = v320 v319
            v321 v306
        else
            let v323 : string = "std::fs::canonicalize(&*$0)"
            let v324 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v183 v323
            let v325 : string = "$0.unwrap()"
            let v326 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v324 v325
            let v327 : string = "$0.display()"
            let v328 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v326 v327
            let v329 : std_string_String option = None
            let v330 : bool = true in let mutable _v329 = v329
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v331 : string = @$"format!(""{{}}"", $0)"
            let v332 : std_string_String = Fable.Core.RustInterop.emitRustExpr v328 v331
            v332
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v333 : string = @$"format!(""{{}}"", $0)"
            let v334 : std_string_String = Fable.Core.RustInterop.emitRustExpr v328 v333
            v334
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v335 : string = @$"format!(""{{}}"", $0)"
            let v336 : std_string_String = Fable.Core.RustInterop.emitRustExpr v328 v335
            v336
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v337 : std_string_String = null |> unbox<std_string_String>
            v337
#endif
            
#if FABLE_COMPILER_PYTHON
            let v338 : std_string_String = null |> unbox<std_string_String>
            v338
#endif
            
#else
            let v339 : std_string_String = null |> unbox<std_string_String>
            v339
#endif
            |> fun x -> _v329 <- Some x
            let v340 : std_string_String = _v329.Value
            let v341 : string = "fable_library_rust::String_::fromString($0)"
            let v342 : string = Fable.Core.RustInterop.emitRustExpr v340 v341
            v342
    v343
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v344 : string = null |> unbox<string>
    v344
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v345 : string = null |> unbox<string>
    v345
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v346 : string = null |> unbox<string>
    v346
#endif
    
#if FABLE_COMPILER_PYTHON
    let v347 : string = null |> unbox<string>
    v347
#endif
    
#else
    let v348 : string = method28(v2)
    let v349 : (string -> string) = System.IO.Path.GetFullPath
    let v350 : string = v349 v348
    v350
#endif
    |> fun x -> _v181 <- Some x
    let v351 : string = _v181.Value
    let v352 : string option = None
    let v353 : bool = true in let mutable _v352 = v352
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v354 : string = method21(v1)
    let v355 : string = method14(v354)
    let v356 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v357 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v355 v356
    let v358 : string = "String::from($0)"
    let v359 : std_string_String = Fable.Core.RustInterop.emitRustExpr v357 v358
    let v360 : string = "std::path::PathBuf::from($0)"
    let v361 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v359 v360
    let v362 : string = "$0.exists()"
    let v363 : bool = Fable.Core.RustInterop.emitRustExpr v361 v362
    let v364 : bool = v363 = false
    let v514 : string =
        if v364 then
            let v365 : string option = None
            let v366 : bool = true in let mutable _v365 = v365
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v367 : string = "std::env::current_dir()"
            let v368 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v367
            let v369 : string = "$0.unwrap()"
            let v370 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v368 v369
            let v371 : string = "$0.display()"
            let v372 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v370 v371
            let v373 : std_string_String option = None
            let v374 : bool = true in let mutable _v373 = v373
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v375 : string = @$"format!(""{{}}"", $0)"
            let v376 : std_string_String = Fable.Core.RustInterop.emitRustExpr v372 v375
            v376
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v377 : string = @$"format!(""{{}}"", $0)"
            let v378 : std_string_String = Fable.Core.RustInterop.emitRustExpr v372 v377
            v378
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v379 : string = @$"format!(""{{}}"", $0)"
            let v380 : std_string_String = Fable.Core.RustInterop.emitRustExpr v372 v379
            v380
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v381 : std_string_String = null |> unbox<std_string_String>
            v381
#endif
            
#if FABLE_COMPILER_PYTHON
            let v382 : std_string_String = null |> unbox<std_string_String>
            v382
#endif
            
#else
            let v383 : std_string_String = null |> unbox<std_string_String>
            v383
#endif
            |> fun x -> _v373 <- Some x
            let v384 : std_string_String = _v373.Value
            let v385 : string = "fable_library_rust::String_::fromString($0)"
            let v386 : string = Fable.Core.RustInterop.emitRustExpr v384 v385
            v386
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v387 : string = null |> unbox<string>
            v387
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v388 : string = null |> unbox<string>
            v388
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v389 : string = null |> unbox<string>
            v389
#endif
            
#if FABLE_COMPILER_PYTHON
            let v390 : string = null |> unbox<string>
            v390
#endif
            
#else
            let v391 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v392 : string = v391 ()
            v392
#endif
            |> fun x -> _v365 <- Some x
            let v393 : string = _v365.Value
            let v394 : string = method13(v393, v354)
            let v395 : string option = None
            let v396 : bool = true in let mutable _v395 = v395
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v397 : string = method22()
            let v398 : string = method23(v394)
            let v399 : string = method24()
            let v400 : string = $"regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v401 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v397, v398, v399) v400
            let v402 : string = "String::from($0)"
            let v403 : std_string_String = Fable.Core.RustInterop.emitRustExpr v401 v402
            let v404 : string = "fable_library_rust::String_::fromString($0)"
            let v405 : string = Fable.Core.RustInterop.emitRustExpr v403 v404
            v405
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v406 : string = null |> unbox<string>
            v406
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v407 : string = null |> unbox<string>
            v407
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v408 : string = null |> unbox<string>
            v408
#endif
            
#if FABLE_COMPILER_PYTHON
            let v409 : string = null |> unbox<string>
            v409
#endif
            
#else
            let v410 : string = "^\\\\\\\\\\?\\\\"
            let v411 : string = ""
            let v412 : string = System.Text.RegularExpressions.Regex.Replace (v394, v410, v411)
            v412
#endif
            |> fun x -> _v395 <- Some x
            let v413 : string = _v395.Value
            let v414 : string = $"{v413.[0] |> string |> _.ToLower()}{v413.[1..]}"
            let v415 : string = "\\"
            let v416 : string = "/"
            let v417 : string = v414.Replace (v415, v416)
            let v418 : (string []) = v417.Split v416
            let v419 : (string []) = [||]
            let v420 : int32 = v418.Length
            let v421 : Mut4 = {l0 = 0; l1 = 0; l2 = v419} : Mut4
            while method25(v420, v421) do
                let v423 : int32 = v421.l0
                let v424 : int32 =  -v423
                let v425 : int32 = v424 + v420
                let v426 : int32 = v425 - 1
                let struct (v427 : int32, v428 : (string [])) = v421.l1, v421.l2
                let v429 : string = v418.[int v426]
                let v430 : bool = ".." = v429
                let struct (v472 : int32, v473 : (string [])) =
                    if v430 then
                        let v431 : int32 = v427 + 1
                        struct (v431, v428)
                    else
                        let v432 : bool = "." = v429
                        if v432 then
                            struct (v427, v428)
                        else
                            let v433 : bool = 0 = v427
                            if v433 then
                                let v434 : string = ":"
                                let v435 : bool = v429.EndsWith v434
                                if v435 then
                                    let v436 : string = $"{v393.[0]}:"
                                    let v437 : (string []) = [|v436|]
                                    let v438 : int32 = v437.Length
                                    let v439 : int32 = v428.Length
                                    let v440 : int32 = v438 + v439
                                    let v441 : (string []) = Array.zeroCreate<string> (v440)
                                    let v442 : Mut5 = {l0 = 0} : Mut5
                                    while method26(v440, v442) do
                                        let v444 : int32 = v442.l0
                                        let v445 : bool = v444 < v438
                                        let v449 : string =
                                            if v445 then
                                                let v446 : string = v437.[int v444]
                                                v446
                                            else
                                                let v447 : int32 = v444 - v438
                                                let v448 : string = v428.[int v447]
                                                v448
                                        v441.[int v444] <- v449
                                        let v450 : int32 = v444 + 1
                                        v442.l0 <- v450
                                        ()
                                    struct (0, v441)
                                else
                                    let v451 : (string []) = [|v429|]
                                    let v452 : int32 = v451.Length
                                    let v453 : int32 = v428.Length
                                    let v454 : int32 = v452 + v453
                                    let v455 : (string []) = Array.zeroCreate<string> (v454)
                                    let v456 : Mut5 = {l0 = 0} : Mut5
                                    while method26(v454, v456) do
                                        let v458 : int32 = v456.l0
                                        let v459 : bool = v458 < v452
                                        let v463 : string =
                                            if v459 then
                                                let v460 : string = v451.[int v458]
                                                v460
                                            else
                                                let v461 : int32 = v458 - v452
                                                let v462 : string = v428.[int v461]
                                                v462
                                        v455.[int v458] <- v463
                                        let v464 : int32 = v458 + 1
                                        v456.l0 <- v464
                                        ()
                                    struct (0, v455)
                            else
                                let v467 : int32 = v427 - 1
                                struct (v467, v428)
                let v474 : int32 = v423 + 1
                v421.l0 <- v474
                v421.l1 <- v472
                v421.l2 <- v473
                ()
            let struct (v475 : int32, v476 : (string [])) = v421.l1, v421.l2
            let v477 : string seq = seq { for i = 0 to v476.Length - 1 do yield v476.[i] }
            let v478 : char option = None
            let v479 : bool = true in let mutable _v478 = v478
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v480 : string = "std::path::MAIN_SEPARATOR"
            let v481 : char = Fable.Core.RustInterop.emitRustExpr () v480
            v481
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v482 : char = null |> unbox<char>
            v482
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v483 : char = null |> unbox<char>
            v483
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v484 : char = null |> unbox<char>
            v484
#endif
            
#if FABLE_COMPILER_PYTHON
            let v485 : char = null |> unbox<char>
            v485
#endif
            
#else
            let v486 : char = System.IO.Path.DirectorySeparatorChar
            v486
#endif
            |> fun x -> _v478 <- Some x
            let v487 : char = _v478.Value
            let v488 : (char -> string) = _.ToString()
            let v489 : string = v488 v487
            let v490 : string = method27(v489)
            let v491 : (string -> (string seq -> string)) = String.concat
            let v492 : (string seq -> string) = v491 v490
            v492 v477
        else
            let v494 : string = "std::fs::canonicalize(&*$0)"
            let v495 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v354 v494
            let v496 : string = "$0.unwrap()"
            let v497 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v495 v496
            let v498 : string = "$0.display()"
            let v499 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v497 v498
            let v500 : std_string_String option = None
            let v501 : bool = true in let mutable _v500 = v500
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v502 : string = @$"format!(""{{}}"", $0)"
            let v503 : std_string_String = Fable.Core.RustInterop.emitRustExpr v499 v502
            v503
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v504 : string = @$"format!(""{{}}"", $0)"
            let v505 : std_string_String = Fable.Core.RustInterop.emitRustExpr v499 v504
            v505
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v506 : string = @$"format!(""{{}}"", $0)"
            let v507 : std_string_String = Fable.Core.RustInterop.emitRustExpr v499 v506
            v507
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v508 : std_string_String = null |> unbox<std_string_String>
            v508
#endif
            
#if FABLE_COMPILER_PYTHON
            let v509 : std_string_String = null |> unbox<std_string_String>
            v509
#endif
            
#else
            let v510 : std_string_String = null |> unbox<std_string_String>
            v510
#endif
            |> fun x -> _v500 <- Some x
            let v511 : std_string_String = _v500.Value
            let v512 : string = "fable_library_rust::String_::fromString($0)"
            let v513 : string = Fable.Core.RustInterop.emitRustExpr v511 v512
            v513
    v514
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v515 : string = null |> unbox<string>
    v515
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v516 : string = null |> unbox<string>
    v516
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v517 : string = null |> unbox<string>
    v517
#endif
    
#if FABLE_COMPILER_PYTHON
    let v518 : string = null |> unbox<string>
    v518
#endif
    
#else
    let v519 : string = method28(v1)
    let v520 : (string -> string) = System.IO.Path.GetFullPath
    let v521 : string = v520 v519
    v521
#endif
    |> fun x -> _v352 <- Some x
    let v522 : string = _v352.Value
    let v523 : US0 = US0_1
    let v524 : (unit -> string) = closure12()
    let v525 : (unit -> string) = closure13(v0, v180, v351, v522)
    method3(v523, v524, v525)
    method29(v0, v9, v180, v351, v522)
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
    let v14 : string = method7()
    let v15 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "clap::ArgMatches::get_one(&v13, v16).cloned()"
    let v18 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : (std_string_String -> US3) = method8()
    let v20 : US3 = US3_1
    let v21 : US3 = v18 |> Option.map v19 |> Option.defaultValue v20 
    let v25 : std_string_String =
        match v21 with
        | US3_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US3_0(v22) -> (* Some *)
            v22
    let v26 : string = "fable_library_rust::String_::fromString($0)"
    let v27 : string = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : string = method9()
    let v29 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v30 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v28 v29
    let v31 : string = "clap::ArgMatches::get_one(&v13, v30).cloned()"
    let v32 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v31
    let v33 : (std_string_String -> US3) = method8()
    let v34 : US3 = US3_1
    let v35 : US3 = v32 |> Option.map v33 |> Option.defaultValue v34 
    let v39 : std_string_String =
        match v35 with
        | US3_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US3_0(v36) -> (* Some *)
            v36
    let v40 : string = "fable_library_rust::String_::fromString($0)"
    let v41 : string = Fable.Core.RustInterop.emitRustExpr v39 v40
    let v42 : string = method10()
    let v43 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v42 v43
    let v45 : string = "clap::ArgMatches::get_one(&v13, v44).cloned()"
    let v46 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v45
    let v47 : (std_string_String -> US3) = method8()
    let v48 : US3 = US3_1
    let v49 : US3 = v46 |> Option.map v47 |> Option.defaultValue v48 
    let v53 : std_string_String =
        match v49 with
        | US3_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US3_0(v50) -> (* Some *)
            v50
    let v54 : string = "fable_library_rust::String_::fromString($0)"
    let v55 : string = Fable.Core.RustInterop.emitRustExpr v53 v54
    let v56 : string = method11()
    let v57 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v58 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v57
    let v59 : string = "clap::ArgMatches::get_one(&v13, v58).cloned()"
    let v60 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v59
    let v61 : (std_string_String -> US3) = method8()
    let v62 : US3 = US3_1
    let v63 : US3 = v60 |> Option.map v61 |> Option.defaultValue v62 
    let v67 : std_string_String =
        match v63 with
        | US3_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US3_0(v64) -> (* Some *)
            v64
    let v68 : string = "fable_library_rust::String_::fromString($0)"
    let v69 : string = Fable.Core.RustInterop.emitRustExpr v67 v68
    let v70 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = method12(v69, v55, v41, v27)
    let v71 : string = "futures_lite::future::block_on($0)"
    let v72 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr v70 v71
    let v73 : string = "$0.unwrap()"
    let v74 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = Fable.Core.RustInterop.emitRustExpr v72 v73
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
