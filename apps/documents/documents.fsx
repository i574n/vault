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
and method38 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : string option) : string =
    v1
and method39 () : struct (string * string) =
    let v0 : string = ""
    struct (v0, v0)
and closure27 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure26 () (v0 : char) : (UH0 -> UH0) =
    closure27(v0)
and method40 () : (char -> (UH0 -> UH0)) =
    closure26()
and method41 (v0 : string, v1 : string, v2 : UH0, v3 : US8) : struct (string * string) =
    match v2 with
    | UH0_1(v4, v5) -> (* Cons *)
        let v6 : bool = '"' = v4
        if v6 then
            let v8 : bool = v1 = ""
            if v8 then
                let v9 : US9 = US9_0
                let v10 : US8 = US8_1(v9)
                method41(v0, v1, v5, v10)
            else
                match v3 with
                | US8_2 -> (* Arguments *)
                    let v38 : string = $"{v0}{v4}"
                    let v39 : US8 = US8_2
                    method41(v38, v1, v5, v39)
                | US8_1(v13) -> (* Path *)
                    match v13 with
                    | US9_0 -> (* Quoted *)
                        let v14 : US9 = US9_1
                        let v15 : US8 = US8_1(v14)
                        method41(v0, v1, v5, v15)
                    | _ ->
                        let v18 : bool = ' ' = v4
                        if v18 then
                            let v19 : US8 = US8_2
                            method41(v0, v1, v5, v19)
                        else
                            let v22 : string = $"{v1}{v4}"
                            method41(v0, v22, v5, v3)
                | US8_0 -> (* Start *)
                    let v29 : bool = ' ' = v4
                    if v29 then
                        let v30 : US8 = US8_2
                        method41(v0, v1, v5, v30)
                    else
                        let v33 : string = $"{v1}{v4}"
                        method41(v0, v33, v5, v3)
        else
            let v50 : bool = ''' = v4
            if v50 then
                let v52 : bool = v1 = ""
                if v52 then
                    let v53 : US9 = US9_0
                    let v54 : US8 = US8_1(v53)
                    method41(v0, v1, v5, v54)
                else
                    match v3 with
                    | US8_2 -> (* Arguments *)
                        let v82 : string = $"{v0}{v4}"
                        let v83 : US8 = US8_2
                        method41(v82, v1, v5, v83)
                    | US8_1(v57) -> (* Path *)
                        match v57 with
                        | US9_0 -> (* Quoted *)
                            let v58 : US9 = US9_1
                            let v59 : US8 = US8_1(v58)
                            method41(v0, v1, v5, v59)
                        | _ ->
                            let v62 : bool = ' ' = v4
                            if v62 then
                                let v63 : US8 = US8_2
                                method41(v0, v1, v5, v63)
                            else
                                let v66 : string = $"{v1}{v4}"
                                method41(v0, v66, v5, v3)
                    | US8_0 -> (* Start *)
                        let v73 : bool = ' ' = v4
                        if v73 then
                            let v74 : US8 = US8_2
                            method41(v0, v1, v5, v74)
                        else
                            let v77 : string = $"{v1}{v4}"
                            method41(v0, v77, v5, v3)
            else
                match v3 with
                | US8_2 -> (* Arguments *)
                    let v126 : string = $"{v0}{v4}"
                    let v127 : US8 = US8_2
                    method41(v126, v1, v5, v127)
                | US8_1(v94) -> (* Path *)
                    match v94 with
                    | US9_0 -> (* Quoted *)
                        let v95 : bool = ' ' = v4
                        if v95 then
                            let v96 : string = $"{v1} "
                            let v97 : US9 = US9_0
                            let v98 : US8 = US8_1(v97)
                            method41(v0, v96, v5, v98)
                        else
                            let v101 : string = $"{v1}{v4}"
                            method41(v0, v101, v5, v3)
                    | _ ->
                        let v106 : bool = ' ' = v4
                        if v106 then
                            let v107 : US8 = US8_2
                            method41(v0, v1, v5, v107)
                        else
                            let v110 : string = $"{v1}{v4}"
                            method41(v0, v110, v5, v3)
                | US8_0 -> (* Start *)
                    let v117 : bool = ' ' = v4
                    if v117 then
                        let v118 : US8 = US8_2
                        method41(v0, v1, v5, v118)
                    else
                        let v121 : string = $"{v1}{v4}"
                        method41(v0, v121, v5, v3)
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
and method45 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = method45(v3, v1)
        UH1_1(v2, v4)
    | UH1_0 -> (* Nil *)
        v1
and method44 (v0 : string, v1 : UH1, v2 : UH0, v3 : US10) : struct (UH1 * string) =
    match v3 with
    | US10_2(v44) -> (* Escaped *)
        match v2 with
        | UH0_1(v45, v46) -> (* Cons *)
            let v47 : bool = '\\' = v45
            if v47 then
                let v48 : char = '\\'
                let v49 : US10 = US10_1(v48)
                method43(v0, v1, v46, v3, v49)
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
                        method44(v0, v1, v46, v3)
                    else
                        let v57 : string = $"{v0}\""
                        let v58 : US10 = US10_2(v44)
                        method43(v57, v1, v46, v3, v58)
                else
                    let v63 : bool = ' ' = v45
                    if v63 then
                        let v64 : string = $"{v0} "
                        method44(v64, v1, v46, v3)
                    else
                        let v67 : bool = 1uy = v44
                        if v67 then
                            let v68 : bool = v3 <> v3
                            if v68 then
                                let v69 : string = $"{v0}\{v45}"
                                method44(v69, v1, v46, v3)
                            else
                                let v72 : string = $"{v0}{v45}"
                                method44(v72, v1, v46, v3)
                        else
                            let v77 : string = $"{v0}{v45}"
                            method44(v77, v1, v46, v3)
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
                        method45(v1, v92)
                struct (v94, v0)
            else
                let v96 : bool = v0 = ""
                let v100 : UH1 =
                    if v96 then
                        v1
                    else
                        let v97 : UH1 = UH1_0
                        let v98 : UH1 = UH1_1(v0, v97)
                        method45(v1, v98)
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
                        method43(v0, v1, v108, v3, v112)
                    else
                        let v115 : bool = '\\' = v105
                        if v115 then
                            let v116 : US10 = US10_2(0uy)
                            let v117 : bool = v3 <> v116
                            if v117 then
                                let v118 : string = $"{v0}\""
                                let v119 : char = '"'
                                let v120 : US10 = US10_1(v119)
                                method43(v118, v1, v108, v3, v120)
                            else
                                let v123 : US10 = US10_1('\\')
                                let v124 : bool = v3 = v123
                                if v124 then
                                    let v125 : string = $"{v0}\""
                                    let v126 : char = '"'
                                    let v127 : US10 = US10_1(v126)
                                    method43(v125, v1, v108, v3, v127)
                                else
                                    let v130 : US10 = US10_0
                                    method43(v0, v1, v108, v3, v130)
                        else
                            let v137 : bool = '\\' = v107
                            if v137 then
                                let v138 : uint8 = 1uy
                                let v139 : US10 = US10_2(v138)
                                method43(v0, v1, v108, v3, v139)
                            else
                                let v142 : US10 = US10_2(0uy)
                                let v143 : bool = v3 = v142
                                if v143 then
                                    let v144 : string = $"{v0}\""
                                    let v145 : char = '"'
                                    let v146 : US10 = US10_1(v145)
                                    method43(v144, v1, v108, v3, v146)
                                else
                                    let v149 : UH1 = UH1_0
                                    let v150 : UH1 = UH1_1(v0, v149)
                                    let v151 : UH1 = method45(v1, v150)
                                    let v152 : string = ""
                                    let v153 : US10 = US10_0
                                    method43(v152, v151, v108, v3, v153)
                else
                    let v164 : bool = '\\' = v105
                    if v164 then
                        let v165 : bool = '\\' = v107
                        if v165 then
                            let v166 : uint8 = 1uy
                            let v167 : US10 = US10_2(v166)
                            method43(v0, v1, v108, v3, v167)
                        else
                            let v170 : bool = ' ' = v107
                            if v170 then
                                let v171 : string = $"{v0} "
                                method44(v171, v1, v108, v3)
                            else
                                let v174 : string = $"{v0}{v107}"
                                method44(v174, v1, v108, v3)
                    else
                        let v181 : bool = '\\' = v107
                        if v181 then
                            let v182 : uint8 = 1uy
                            let v183 : US10 = US10_2(v182)
                            method43(v0, v1, v108, v3, v183)
                        else
                            let v186 : bool = ' ' = v107
                            if v186 then
                                let v187 : string = $"{v0} "
                                method44(v187, v1, v108, v3)
                            else
                                let v190 : string = $"{v0}{v107}"
                                method44(v190, v1, v108, v3)
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
                            method45(v1, v205)
                    struct (v207, v0)
                else
                    let v209 : bool = v0 = ""
                    let v213 : UH1 =
                        if v209 then
                            v1
                        else
                            let v210 : UH1 = UH1_0
                            let v211 : UH1 = UH1_1(v0, v210)
                            method45(v1, v211)
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
                            method43(v224, v1, v220, v3, v226)
                        else
                            let v229 : US10 = US10_1('\\')
                            let v230 : bool = v3 = v229
                            if v230 then
                                let v231 : string = $"{v0}\""
                                let v232 : char = '"'
                                let v233 : US10 = US10_1(v232)
                                method43(v231, v1, v220, v3, v233)
                            else
                                let v236 : US10 = US10_0
                                method43(v0, v1, v220, v3, v236)
                    else
                        let v243 : bool = '\\' = v219
                        if v243 then
                            let v244 : uint8 = 1uy
                            let v245 : US10 = US10_2(v244)
                            method43(v0, v1, v220, v3, v245)
                        else
                            let v248 : bool = ' ' = v219
                            if v248 then
                                let v249 : string = $"{v0} "
                                method44(v249, v1, v220, v3)
                            else
                                let v252 : string = $"{v0}{v219}"
                                method44(v252, v1, v220, v3)
                | _ ->
                    let v262 : bool = v0 = ""
                    let v266 : UH1 =
                        if v262 then
                            v1
                        else
                            let v263 : UH1 = UH1_0
                            let v264 : UH1 = UH1_1(v0, v263)
                            method45(v1, v264)
                    struct (v266, v0)
            else
                match v2 with
                | UH0_1(v269, v270) -> (* Cons *)
                    let v271 : bool = '\\' = v269
                    if v271 then
                        let v272 : uint8 = 1uy
                        let v273 : US10 = US10_2(v272)
                        method43(v0, v1, v270, v3, v273)
                    else
                        let v276 : bool = '"' = v269
                        if v276 then
                            let v277 : US10 = US10_2(0uy)
                            let v278 : bool = v3 = v277
                            if v278 then
                                let v279 : string = $"{v0}\""
                                let v280 : char = '"'
                                let v281 : US10 = US10_1(v280)
                                method43(v279, v1, v270, v3, v281)
                            else
                                let v284 : UH1 = UH1_0
                                let v285 : UH1 = UH1_1(v0, v284)
                                let v286 : UH1 = method45(v1, v285)
                                let v287 : string = ""
                                let v288 : US10 = US10_0
                                method43(v287, v286, v270, v3, v288)
                        else
                            let v293 : bool = ' ' = v269
                            if v293 then
                                let v294 : string = $"{v0} "
                                method44(v294, v1, v270, v3)
                            else
                                let v297 : string = $"{v0}{v269}"
                                method44(v297, v1, v270, v3)
                | _ ->
                    let v307 : bool = v0 = ""
                    let v311 : UH1 =
                        if v307 then
                            v1
                        else
                            let v308 : UH1 = UH1_0
                            let v309 : UH1 = UH1_1(v0, v308)
                            method45(v1, v309)
                    struct (v311, v0)
    | US10_0 -> (* Start *)
        match v2 with
        | UH0_1(v4, v5) -> (* Cons *)
            let v6 : bool = '"' = v4
            if v6 then
                let v7 : string = ""
                let v8 : char = '"'
                let v9 : US10 = US10_1(v8)
                method43(v7, v1, v5, v3, v9)
            else
                let v12 : bool = '\\' = v4
                if v12 then
                    let v13 : uint8 = 0uy
                    let v14 : US10 = US10_2(v13)
                    method43(v0, v1, v5, v3, v14)
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
                                method45(v1, v21)
                        let v24 : string = ""
                        method44(v24, v23, v5, v3)
                    else
                        let v27 : string = $"{v0}{v4}"
                        method44(v27, v1, v5, v3)
        | _ ->
            let v37 : bool = v0 = ""
            let v41 : UH1 =
                if v37 then
                    v1
                else
                    let v38 : UH1 = UH1_0
                    let v39 : UH1 = UH1_1(v0, v38)
                    method45(v1, v39)
            struct (v41, v0)
and method43 (v0 : string, v1 : UH1, v2 : UH0, v3 : US10, v4 : US10) : struct (UH1 * string) =
    match v4 with
    | US10_2(v45) -> (* Escaped *)
        match v2 with
        | UH0_1(v46, v47) -> (* Cons *)
            let v48 : bool = '\\' = v46
            if v48 then
                let v49 : char = '\\'
                let v50 : US10 = US10_1(v49)
                method43(v0, v1, v47, v4, v50)
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
                        method44(v0, v1, v47, v4)
                    else
                        let v58 : string = $"{v0}\""
                        let v59 : US10 = US10_2(v45)
                        method43(v58, v1, v47, v4, v59)
                else
                    let v64 : bool = ' ' = v46
                    if v64 then
                        let v65 : string = $"{v0} "
                        method44(v65, v1, v47, v4)
                    else
                        let v68 : bool = 1uy = v45
                        if v68 then
                            let v69 : bool = v3 <> v4
                            if v69 then
                                let v70 : string = $"{v0}\{v46}"
                                method43(v70, v1, v47, v4, v3)
                            else
                                let v73 : string = $"{v0}{v46}"
                                method44(v73, v1, v47, v4)
                        else
                            let v78 : string = $"{v0}{v46}"
                            method44(v78, v1, v47, v4)
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
                        method45(v1, v93)
                struct (v95, v0)
            else
                let v97 : bool = v0 = ""
                let v101 : UH1 =
                    if v97 then
                        v1
                    else
                        let v98 : UH1 = UH1_0
                        let v99 : UH1 = UH1_1(v0, v98)
                        method45(v1, v99)
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
                        method43(v0, v1, v109, v4, v113)
                    else
                        let v116 : bool = '\\' = v106
                        if v116 then
                            let v117 : US10 = US10_2(0uy)
                            let v118 : bool = v3 <> v117
                            if v118 then
                                let v119 : string = $"{v0}\""
                                let v120 : char = '"'
                                let v121 : US10 = US10_1(v120)
                                method43(v119, v1, v109, v4, v121)
                            else
                                let v124 : US10 = US10_1('\\')
                                let v125 : bool = v3 = v124
                                if v125 then
                                    let v126 : string = $"{v0}\""
                                    let v127 : char = '"'
                                    let v128 : US10 = US10_1(v127)
                                    method43(v126, v1, v109, v4, v128)
                                else
                                    let v131 : US10 = US10_0
                                    method43(v0, v1, v109, v4, v131)
                        else
                            let v138 : bool = '\\' = v108
                            if v138 then
                                let v139 : uint8 = 1uy
                                let v140 : US10 = US10_2(v139)
                                method43(v0, v1, v109, v4, v140)
                            else
                                let v143 : US10 = US10_2(0uy)
                                let v144 : bool = v3 = v143
                                if v144 then
                                    let v145 : string = $"{v0}\""
                                    let v146 : char = '"'
                                    let v147 : US10 = US10_1(v146)
                                    method43(v145, v1, v109, v4, v147)
                                else
                                    let v150 : UH1 = UH1_0
                                    let v151 : UH1 = UH1_1(v0, v150)
                                    let v152 : UH1 = method45(v1, v151)
                                    let v153 : string = ""
                                    let v154 : US10 = US10_0
                                    method43(v153, v152, v109, v4, v154)
                else
                    let v165 : bool = '\\' = v106
                    if v165 then
                        let v166 : bool = '\\' = v108
                        if v166 then
                            let v167 : uint8 = 1uy
                            let v168 : US10 = US10_2(v167)
                            method43(v0, v1, v109, v4, v168)
                        else
                            let v171 : bool = ' ' = v108
                            if v171 then
                                let v172 : string = $"{v0} "
                                method44(v172, v1, v109, v4)
                            else
                                let v175 : string = $"{v0}{v108}"
                                method44(v175, v1, v109, v4)
                    else
                        let v182 : bool = '\\' = v108
                        if v182 then
                            let v183 : uint8 = 1uy
                            let v184 : US10 = US10_2(v183)
                            method43(v0, v1, v109, v4, v184)
                        else
                            let v187 : bool = ' ' = v108
                            if v187 then
                                let v188 : string = $"{v0} "
                                method44(v188, v1, v109, v4)
                            else
                                let v191 : string = $"{v0}{v108}"
                                method44(v191, v1, v109, v4)
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
                            method45(v1, v206)
                    struct (v208, v0)
                else
                    let v210 : bool = v0 = ""
                    let v214 : UH1 =
                        if v210 then
                            v1
                        else
                            let v211 : UH1 = UH1_0
                            let v212 : UH1 = UH1_1(v0, v211)
                            method45(v1, v212)
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
                            method43(v225, v1, v221, v4, v227)
                        else
                            let v230 : US10 = US10_1('\\')
                            let v231 : bool = v3 = v230
                            if v231 then
                                let v232 : string = $"{v0}\""
                                let v233 : char = '"'
                                let v234 : US10 = US10_1(v233)
                                method43(v232, v1, v221, v4, v234)
                            else
                                let v237 : US10 = US10_0
                                method43(v0, v1, v221, v4, v237)
                    else
                        let v244 : bool = '\\' = v220
                        if v244 then
                            let v245 : uint8 = 1uy
                            let v246 : US10 = US10_2(v245)
                            method43(v0, v1, v221, v4, v246)
                        else
                            let v249 : bool = ' ' = v220
                            if v249 then
                                let v250 : string = $"{v0} "
                                method44(v250, v1, v221, v4)
                            else
                                let v253 : string = $"{v0}{v220}"
                                method44(v253, v1, v221, v4)
                | _ ->
                    let v263 : bool = v0 = ""
                    let v267 : UH1 =
                        if v263 then
                            v1
                        else
                            let v264 : UH1 = UH1_0
                            let v265 : UH1 = UH1_1(v0, v264)
                            method45(v1, v265)
                    struct (v267, v0)
            else
                match v2 with
                | UH0_1(v270, v271) -> (* Cons *)
                    let v272 : bool = '\\' = v270
                    if v272 then
                        let v273 : uint8 = 1uy
                        let v274 : US10 = US10_2(v273)
                        method43(v0, v1, v271, v4, v274)
                    else
                        let v277 : bool = '"' = v270
                        if v277 then
                            let v278 : US10 = US10_2(0uy)
                            let v279 : bool = v3 = v278
                            if v279 then
                                let v280 : string = $"{v0}\""
                                let v281 : char = '"'
                                let v282 : US10 = US10_1(v281)
                                method43(v280, v1, v271, v4, v282)
                            else
                                let v285 : UH1 = UH1_0
                                let v286 : UH1 = UH1_1(v0, v285)
                                let v287 : UH1 = method45(v1, v286)
                                let v288 : string = ""
                                let v289 : US10 = US10_0
                                method43(v288, v287, v271, v4, v289)
                        else
                            let v294 : bool = ' ' = v270
                            if v294 then
                                let v295 : string = $"{v0} "
                                method44(v295, v1, v271, v4)
                            else
                                let v298 : string = $"{v0}{v270}"
                                method44(v298, v1, v271, v4)
                | _ ->
                    let v308 : bool = v0 = ""
                    let v312 : UH1 =
                        if v308 then
                            v1
                        else
                            let v309 : UH1 = UH1_0
                            let v310 : UH1 = UH1_1(v0, v309)
                            method45(v1, v310)
                    struct (v312, v0)
    | US10_0 -> (* Start *)
        match v2 with
        | UH0_1(v5, v6) -> (* Cons *)
            let v7 : bool = '"' = v5
            if v7 then
                let v8 : string = ""
                let v9 : char = '"'
                let v10 : US10 = US10_1(v9)
                method43(v8, v1, v6, v4, v10)
            else
                let v13 : bool = '\\' = v5
                if v13 then
                    let v14 : uint8 = 0uy
                    let v15 : US10 = US10_2(v14)
                    method43(v0, v1, v6, v4, v15)
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
                                method45(v1, v22)
                        let v25 : string = ""
                        method44(v25, v24, v6, v4)
                    else
                        let v28 : string = $"{v0}{v5}"
                        method44(v28, v1, v6, v4)
        | _ ->
            let v38 : bool = v0 = ""
            let v42 : UH1 =
                if v38 then
                    v1
                else
                    let v39 : UH1 = UH1_0
                    let v40 : UH1 = UH1_1(v0, v39)
                    method45(v1, v40)
            struct (v42, v0)
and method46 (v0 : UH1, v1 : string list) : string list =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : string list = method46(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH1_0 -> (* Nil *)
        v1
and method42 (v0 : string) : (string []) =
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
    let v23 : (char -> (UH0 -> UH0)) = method40()
    let v24 : (char list -> (UH0 -> UH0)) = v22 v23
    let v25 : (UH0 -> UH0) = v24 v21
    let v26 : UH0 = UH0_0
    let v27 : UH0 = v25 v26
    let v28 : US10 = US10_0
    let v29 : US10 = US10_0
    let struct (v30 : UH1, v31 : string) = method43(v2, v1, v27, v29, v28)
    let v32 : string list = []
    let v33 : string list = method46(v30, v32)
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
and method47 () : (unit -> string) =
    closure6()
and method49 (v0 : string) : string =
    v0
and method51 (v0 : std_sync_Mutex<std_process_Child option>) : std_sync_Mutex<std_process_Child option> =
    v0
and closure30 () (v0 : std_process_Child) : std_sync_Arc<std_sync_Mutex<std_process_Child option>> =
    let v1 : std_process_Child option = Some v0 
    let v2 : string = "std::sync::Mutex::new($0)"
    let v3 : std_sync_Mutex<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : std_sync_Mutex<std_process_Child option> = method51(v3)
    let v5 : string = "std::sync::Arc::new(v4)"
    let v6 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr () v5
    v6
and method50 () : (std_process_Child -> std_sync_Arc<std_sync_Mutex<std_process_Child option>>) =
    closure30()
and method52 (v0 : Result<std_process_Child, std_io_Error>) : Result<std_process_Child, std_io_Error> =
    v0
and closure31 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : US11 =
    US11_0(v0)
and closure32 () (v0 : std_string_String) : US11 =
    US11_1(v0)
and closure33 (v0 : std_string_String) () : string =
    let v1 : string = $"execute_with_options -1 / error: {v0}"
    v1
and method53 (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : std_sync_Arc<std_sync_Mutex<std_process_Child option>> =
    v0
and method54 (v0 : std_sync_Mutex<std_process_ChildStdout option>) : std_sync_Mutex<std_process_ChildStdout option> =
    v0
and method55 (v0 : std_sync_Mutex<std_process_ChildStderr option>) : std_sync_Mutex<std_process_ChildStderr option> =
    v0
and method56 (v0 : std_sync_Mutex<std_process_ChildStdin option>) : std_sync_Mutex<std_process_ChildStdin option> =
    v0
and method57 (v0 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> =
    v0
and method58 (v0 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>) : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> =
    v0
and method59 (v0 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>) : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> =
    v0
and method60 (v0 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>>) : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> =
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
and method61 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) : (Result<std_string_String, std_io_Error> -> unit) =
    closure34(v0)
and method62 (v0 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>>) : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>> =
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
and method63 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) : (Result<std_string_String, std_io_Error> -> unit) =
    closure39(v0)
and closure41 () (v0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)) : US14 =
    US14_0(v0)
and method64 () : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US14) =
    closure41()
and method65 (v0 : std_sync_Mutex<std_process_ChildStdin>) : std_sync_Mutex<std_process_ChildStdin> =
    v0
and closure42 () (v0 : std_process_ChildStdin) : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> =
    let v1 : string = "std::sync::Mutex::new($0)"
    let v2 : std_sync_Mutex<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : std_sync_Mutex<std_process_ChildStdin> = method65(v2)
    let v4 : string = "std::sync::Arc::new(v3)"
    let v5 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr () v4
    v5
and closure43 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : US15 =
    US15_0(v0)
and method66 () : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US15) =
    closure43()
and method67 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
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
and method68 (v0 : (int32 * string)) : (int32 * string) =
    v0
and method48 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : string option, v6 : string, v7 : Vec<std_string_String>) : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> =
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
            let v31 : string = method49(v30)
            let v32 : string = "std::process::Command::current_dir(v26, &*v31)"
            let v33 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr () v32
            v33
    let v36 : string = "true; let mut v35 = v35"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : string = "std::process::Command::spawn(&mut $0)"
    let v39 : Result<std_process_Child, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v35 v38
    let v40 : (std_process_Child -> std_sync_Arc<std_sync_Mutex<std_process_Child option>>) = method50()
    let v41 : Result<std_process_Child, std_io_Error> = method52(v39)
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
            let v51 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method53(v50)
            let v52 : string = "v51.lock().unwrap().as_mut().unwrap().stdout.take().unwrap()"
            let v53 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr () v52
            let v54 : string = "v51.lock().unwrap().as_mut().unwrap().stderr.take().unwrap()"
            let v55 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr () v54
            let v56 : string = "v51.lock().unwrap().as_mut().unwrap().stdin.take().unwrap()"
            let v57 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr () v56
            let v58 : std_process_ChildStdout option = Some v53 
            let v59 : string = "std::sync::Mutex::new($0)"
            let v60 : std_sync_Mutex<std_process_ChildStdout option> = Fable.Core.RustInterop.emitRustExpr v58 v59
            let v61 : std_sync_Mutex<std_process_ChildStdout option> = method54(v60)
            let v62 : string = "std::sync::Arc::new(v61)"
            let v63 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdout option>> = Fable.Core.RustInterop.emitRustExpr () v62
            let v64 : std_process_ChildStderr option = Some v55 
            let v65 : string = "std::sync::Mutex::new($0)"
            let v66 : std_sync_Mutex<std_process_ChildStderr option> = Fable.Core.RustInterop.emitRustExpr v64 v65
            let v67 : std_sync_Mutex<std_process_ChildStderr option> = method55(v66)
            let v68 : string = "std::sync::Arc::new(v67)"
            let v69 : std_sync_Arc<std_sync_Mutex<std_process_ChildStderr option>> = Fable.Core.RustInterop.emitRustExpr () v68
            let v70 : std_process_ChildStdin option = Some v57 
            let v71 : string = "std::sync::Mutex::new($0)"
            let v72 : std_sync_Mutex<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v70 v71
            let v73 : std_sync_Mutex<std_process_ChildStdin option> = method56(v72)
            let v74 : string = "std::sync::Arc::new(v73)"
            let v75 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v74
            let v76 : string = "{ let (sender, receiver) = std::sync::mpsc::channel(); (sender, std::sync::Arc::new(receiver)) }"
            let struct (v77 : std_sync_mpsc_Sender<std_string_String>, v78 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = Fable.Core.RustInterop.emitRustExpr () v76
            let v79 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> = method57(v78)
            let v80 : string = "true; let v79 = v79"
            let v81 : bool = Fable.Core.RustInterop.emitRustExpr v79 v80
            let v82 : string = "std::sync::Mutex::new($0)"
            let v83 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v77 v82
            let v84 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = method58(v83)
            let v85 : string = "std::sync::Arc::new(v84)"
            let v86 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v85
            let v87 : string = "v86.clone()"
            let v88 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v87
            let v89 : string = "v86.clone()"
            let v90 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v89
            let v91 : string = "std::sync::Mutex::new($0)"
            let v92 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v79 v91
            let v93 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = method59(v92)
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
            let v106 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> = method60(v105)
            let v107 : string = "std::sync::Arc::new(v106)"
            let v108 : std_sync_Arc<std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>>> = Fable.Core.RustInterop.emitRustExpr () v107
            let v109 : (Result<std_string_String, std_io_Error> -> unit) = method61(v88)
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
            let v124 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>> = method62(v123)
            let v125 : string = "std::sync::Arc::new(v124)"
            let v126 : std_sync_Arc<std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>>> = Fable.Core.RustInterop.emitRustExpr () v125
            let v127 : (Result<std_string_String, std_io_Error> -> unit) = method63(v86)
            let v128 : string = "true; for line in $0.lock().unwrap().by_ref() { v127(line) }"
            let v129 : bool = Fable.Core.RustInterop.emitRustExpr v126 v128
            let v130 : string = "true; })"
            let v131 : bool = Fable.Core.RustInterop.emitRustExpr () v130
            let v132 : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US14) = method64()
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
                let v141 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US15) = method66()
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
                    let v149 : std_sync_MutexGuard<std_process_ChildStdin> = method67(v148)
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
    let v227 : (int32 * string) = method68(v226)
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
and method69 () : ((struct (bool * string * int32) -> Async<unit>) -> US17) =
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
        let v21 : ((struct (bool * string * int32) -> Async<unit>) -> US17) = method69()
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
        let v21 : ((struct (bool * string * int32) -> Async<unit>) -> US17) = method69()
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
and method70 () : (System.Threading.CancellationToken -> US18) =
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
and method71 () : string =
    let v0 : string = "\n"
    v0
and closure56 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"execute_with_options_async / exit_code: {v0} / output.Length: {v1.Length}"
    v2
and method72 (v0 : string, v1 : string, v2 : string) : struct (string * string) =
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
and method73 (v0 : string) : string =
    v0
and method75 (v0 : int32, v1 : Mut6) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method76 (v0 : string) : string =
    v0
and method77 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure61 (v0 : string) (v1 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : unit =
    let v2 : string = "$0.lock()"
    let v3 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "$0.unwrap()"
    let v5 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = method76(v0)
    let v7 : string = "v6.as_bytes()"
    let v8 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : std_sync_MutexGuard<std_process_ChildStdin> = method77(v5)
    let v10 : string = "true; let mut v9 = v9"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : string = "true; std::io::Write::write_all(&mut *$0, v8).unwrap()"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr v9 v12
    ()
and method78 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method79 (v0 : string) : string =
    v0
and closure62 () () : string =
    let v0 : string = "documents.hangul"
    v0
and closure63 (v0 : string, v1 : int32, v2 : string) () : string =
    let v3 : int32 = v2 |> String.length
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"exit_code: %A{v1} / result_len: {v3} / output_path: {v0} / {v4 ()}"
    v5
and method74 (v0 : string, v1 : string, v2 : string, v3 : string) : US21 =
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
    while method75(v40, v42) do
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
    let v60 : string = method71()
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
    let v92 : string = method38(v66, v87, v67, v68, v89, v65)
    let struct (v93 : string, v94 : string) = method39()
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
    let v105 : (char -> (UH0 -> UH0)) = method40()
    let v106 : (char list -> (UH0 -> UH0)) = v104 v105
    let v107 : (UH0 -> UH0) = v106 v103
    let v108 : UH0 = UH0_0
    let v109 : UH0 = v107 v108
    let v110 : US8 = US8_0
    let struct (v111 : string, v112 : string) = method41(v94, v93, v109, v110)
    let v113 : (string []) = method42(v112)
    let v114 : string = "$0.to_vec()"
    let v115 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v113 v114
    let v116 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v117 : (string -> std_string_String) = closure28()
    let v118 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v115, v117) v116
    let v119 : US0 = US0_1
    let v120 : (unit -> string) = closure29(v66, v87, v67, v68, v89, v65, v111, v118)
    let v121 : (unit -> string) = method47()
    method3(v119, v120, v121)
    let v122 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v66, v87, v67, v68, v89, v65, v111, v118)
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
    let struct (v150 : string, v151 : string) = method39()
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
    let v162 : (char -> (UH0 -> UH0)) = method40()
    let v163 : (char list -> (UH0 -> UH0)) = v161 v162
    let v164 : (UH0 -> UH0) = v163 v160
    let v165 : UH0 = UH0_0
    let v166 : UH0 = v164 v165
    let v167 : US8 = US8_0
    let struct (v168 : string, v169 : string) = method41(v151, v150, v166, v167)
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
    let v179 : (unit -> string) = method47()
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
    let v201 : (System.Threading.CancellationToken -> US18) = method70()
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
    let v272 : (unit -> string) = method47()
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
    let v278 : string = method71()
    let v279 : (string -> (string seq -> string)) = String.concat
    let v280 : (string seq -> string) = v279 v278
    let v281 : string = v280 v277
    let v282 : US0 = US0_1
    let v283 : (unit -> string) = closure56(v275, v281)
    let v284 : (unit -> string) = method47()
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
    while method78(v40, v310) do
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
    let v341 : string = method79(v335)
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
    let struct (v6 : string, v7 : string) = method72(v5, v4, v0)
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
            let v87 : string = method38(v80, v84, v81, v82, v83, v79)
            let struct (v88 : string, v89 : string) = method39()
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
            let v100 : (char -> (UH0 -> UH0)) = method40()
            let v101 : (char list -> (UH0 -> UH0)) = v99 v100
            let v102 : (UH0 -> UH0) = v101 v98
            let v103 : UH0 = UH0_0
            let v104 : UH0 = v102 v103
            let v105 : US8 = US8_0
            let struct (v106 : string, v107 : string) = method41(v89, v88, v104, v105)
            let v108 : (string []) = method42(v107)
            let v109 : string = "$0.to_vec()"
            let v110 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v108 v109
            let v111 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v112 : (string -> std_string_String) = closure28()
            let v113 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v110, v112) v111
            let v114 : US0 = US0_1
            let v115 : (unit -> string) = closure29(v80, v84, v81, v82, v83, v79, v106, v113)
            let v116 : (unit -> string) = method47()
            method3(v114, v115, v116)
            let v117 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v80, v84, v81, v82, v83, v79, v106, v113)
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
            let struct (v145 : string, v146 : string) = method39()
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
            let v157 : (char -> (UH0 -> UH0)) = method40()
            let v158 : (char list -> (UH0 -> UH0)) = v156 v157
            let v159 : (UH0 -> UH0) = v158 v155
            let v160 : UH0 = UH0_0
            let v161 : UH0 = v159 v160
            let v162 : US8 = US8_0
            let struct (v163 : string, v164 : string) = method41(v146, v145, v161, v162)
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
            let v173 : (unit -> string) = method47()
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
            let v195 : (System.Threading.CancellationToken -> US18) = method70()
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
            let v266 : (unit -> string) = method47()
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
            let v272 : string = method71()
            let v273 : (string -> (string seq -> string)) = String.concat
            let v274 : (string seq -> string) = v273 v272
            let v275 : string = v274 v271
            let v276 : US0 = US0_1
            let v277 : (unit -> string) = closure56(v269, v275)
            let v278 : (unit -> string) = method47()
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
            let v338 : string = method38(v331, v335, v332, v333, v334, v330)
            let struct (v339 : string, v340 : string) = method39()
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
            let v351 : (char -> (UH0 -> UH0)) = method40()
            let v352 : (char list -> (UH0 -> UH0)) = v350 v351
            let v353 : (UH0 -> UH0) = v352 v349
            let v354 : UH0 = UH0_0
            let v355 : UH0 = v353 v354
            let v356 : US8 = US8_0
            let struct (v357 : string, v358 : string) = method41(v340, v339, v355, v356)
            let v359 : (string []) = method42(v358)
            let v360 : string = "$0.to_vec()"
            let v361 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v359 v360
            let v362 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v363 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v361, v112) v362
            let v364 : US0 = US0_1
            let v365 : (unit -> string) = closure29(v331, v335, v332, v333, v334, v330, v357, v363)
            let v366 : (unit -> string) = method47()
            method3(v364, v365, v366)
            let v367 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v331, v335, v332, v333, v334, v330, v357, v363)
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
            let struct (v395 : string, v396 : string) = method39()
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
            let v407 : (char -> (UH0 -> UH0)) = method40()
            let v408 : (char list -> (UH0 -> UH0)) = v406 v407
            let v409 : (UH0 -> UH0) = v408 v405
            let v410 : UH0 = UH0_0
            let v411 : UH0 = v409 v410
            let v412 : US8 = US8_0
            let struct (v413 : string, v414 : string) = method41(v396, v395, v411, v412)
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
            let v423 : (unit -> string) = method47()
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
            let v445 : (System.Threading.CancellationToken -> US18) = method70()
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
            let v516 : (unit -> string) = method47()
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
            let v522 : string = method71()
            let v523 : (string -> (string seq -> string)) = String.concat
            let v524 : (string seq -> string) = v523 v522
            let v525 : string = v524 v521
            let v526 : US0 = US0_1
            let v527 : (unit -> string) = closure56(v519, v525)
            let v528 : (unit -> string) = method47()
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
        let v564 : US21 = method74(v2, v3, v7, v4)
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
                    let v599 : string = method73(v6)
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
and method80 (v0 : string, v1 : string, v2 : string, v3 : string) : US21 =
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
    let v13 : string = method38(v6, v4, v7, v8, v9, v10)
    let struct (v14 : string, v15 : string) = method39()
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
    let v26 : (char -> (UH0 -> UH0)) = method40()
    let v27 : (char list -> (UH0 -> UH0)) = v25 v26
    let v28 : (UH0 -> UH0) = v27 v24
    let v29 : UH0 = UH0_0
    let v30 : UH0 = v28 v29
    let v31 : US8 = US8_0
    let struct (v32 : string, v33 : string) = method41(v15, v14, v30, v31)
    let v34 : (string []) = method42(v33)
    let v35 : string = "$0.to_vec()"
    let v36 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v34 v35
    let v37 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v38 : (string -> std_string_String) = closure28()
    let v39 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v36, v38) v37
    let v40 : US0 = US0_1
    let v41 : (unit -> string) = closure29(v6, v4, v7, v8, v9, v10, v32, v39)
    let v42 : (unit -> string) = method47()
    method3(v40, v41, v42)
    let v43 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v6, v4, v7, v8, v9, v10, v32, v39)
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
    let struct (v71 : string, v72 : string) = method39()
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
    let v83 : (char -> (UH0 -> UH0)) = method40()
    let v84 : (char list -> (UH0 -> UH0)) = v82 v83
    let v85 : (UH0 -> UH0) = v84 v81
    let v86 : UH0 = UH0_0
    let v87 : UH0 = v85 v86
    let v88 : US8 = US8_0
    let struct (v89 : string, v90 : string) = method41(v72, v71, v87, v88)
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
    let v100 : (unit -> string) = method47()
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
    let v122 : (System.Threading.CancellationToken -> US18) = method70()
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
    let v193 : (unit -> string) = method47()
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
    let v199 : string = method71()
    let v200 : (string -> (string seq -> string)) = String.concat
    let v201 : (string seq -> string) = v200 v199
    let v202 : string = v201 v198
    let v203 : US0 = US0_1
    let v204 : (unit -> string) = closure56(v196, v202)
    let v205 : (unit -> string) = method47()
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
    let struct (v4 : string, v5 : string) = method72(v3, v2, v0)
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
            let v85 : string = method38(v78, v82, v79, v80, v81, v77)
            let struct (v86 : string, v87 : string) = method39()
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
            let v98 : (char -> (UH0 -> UH0)) = method40()
            let v99 : (char list -> (UH0 -> UH0)) = v97 v98
            let v100 : (UH0 -> UH0) = v99 v96
            let v101 : UH0 = UH0_0
            let v102 : UH0 = v100 v101
            let v103 : US8 = US8_0
            let struct (v104 : string, v105 : string) = method41(v87, v86, v102, v103)
            let v106 : (string []) = method42(v105)
            let v107 : string = "$0.to_vec()"
            let v108 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v106 v107
            let v109 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v110 : (string -> std_string_String) = closure28()
            let v111 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v108, v110) v109
            let v112 : US0 = US0_1
            let v113 : (unit -> string) = closure29(v78, v82, v79, v80, v81, v77, v104, v111)
            let v114 : (unit -> string) = method47()
            method3(v112, v113, v114)
            let v115 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v78, v82, v79, v80, v81, v77, v104, v111)
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
            let struct (v143 : string, v144 : string) = method39()
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
            let v155 : (char -> (UH0 -> UH0)) = method40()
            let v156 : (char list -> (UH0 -> UH0)) = v154 v155
            let v157 : (UH0 -> UH0) = v156 v153
            let v158 : UH0 = UH0_0
            let v159 : UH0 = v157 v158
            let v160 : US8 = US8_0
            let struct (v161 : string, v162 : string) = method41(v144, v143, v159, v160)
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
            let v171 : (unit -> string) = method47()
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
            let v193 : (System.Threading.CancellationToken -> US18) = method70()
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
            let v264 : (unit -> string) = method47()
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
            let v270 : string = method71()
            let v271 : (string -> (string seq -> string)) = String.concat
            let v272 : (string seq -> string) = v271 v270
            let v273 : string = v272 v269
            let v274 : US0 = US0_1
            let v275 : (unit -> string) = closure56(v267, v273)
            let v276 : (unit -> string) = method47()
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
            let v336 : string = method38(v329, v333, v330, v331, v332, v328)
            let struct (v337 : string, v338 : string) = method39()
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
            let v349 : (char -> (UH0 -> UH0)) = method40()
            let v350 : (char list -> (UH0 -> UH0)) = v348 v349
            let v351 : (UH0 -> UH0) = v350 v347
            let v352 : UH0 = UH0_0
            let v353 : UH0 = v351 v352
            let v354 : US8 = US8_0
            let struct (v355 : string, v356 : string) = method41(v338, v337, v353, v354)
            let v357 : (string []) = method42(v356)
            let v358 : string = "$0.to_vec()"
            let v359 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v357 v358
            let v360 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v361 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v359, v110) v360
            let v362 : US0 = US0_1
            let v363 : (unit -> string) = closure29(v329, v333, v330, v331, v332, v328, v355, v361)
            let v364 : (unit -> string) = method47()
            method3(v362, v363, v364)
            let v365 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v329, v333, v330, v331, v332, v328, v355, v361)
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
            let struct (v393 : string, v394 : string) = method39()
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
            let v405 : (char -> (UH0 -> UH0)) = method40()
            let v406 : (char list -> (UH0 -> UH0)) = v404 v405
            let v407 : (UH0 -> UH0) = v406 v403
            let v408 : UH0 = UH0_0
            let v409 : UH0 = v407 v408
            let v410 : US8 = US8_0
            let struct (v411 : string, v412 : string) = method41(v394, v393, v409, v410)
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
            let v421 : (unit -> string) = method47()
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
            let v443 : (System.Threading.CancellationToken -> US18) = method70()
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
            let v514 : (unit -> string) = method47()
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
            let v520 : string = method71()
            let v521 : (string -> (string seq -> string)) = String.concat
            let v522 : (string seq -> string) = v521 v520
            let v523 : string = v522 v519
            let v524 : US0 = US0_1
            let v525 : (unit -> string) = closure56(v517, v523)
            let v526 : (unit -> string) = method47()
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
        let v562 : US21 = method80(v5, v2, v1, v3)
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
                    let v597 : string = method73(v4)
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
and method81 (v0 : UH2, v1 : UH3 list) : UH3 list =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : UH3 list = method81(v3, v1)
        let v5 : UH3 list = v2 :: v4 
        v5
    | UH2_0 -> (* Nil *)
        v1
and method82 (v0 : int32, v1 : Mut8) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method83 (v0 : UH3, v1 : struct (string * string * (string -> (string -> US19))) list) : struct (string * string * (string -> (string -> US19))) list =
    match v0 with
    | UH3_1(v2, v3, v4, v5) -> (* Cons *)
        let v6 : struct (string * string * (string -> (string -> US19))) list = method83(v5, v1)
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
and method84 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method85 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
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
    let v227 : string option = None
    let v228 : bool = true in let mutable _v227 = v227
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v229 : string = method22()
    let v230 : string = method23(v226)
    let v231 : string = method24()
    let v232 : string = $"regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
    let v233 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v229, v230, v231) v232
    let v234 : string = "String::from($0)"
    let v235 : std_string_String = Fable.Core.RustInterop.emitRustExpr v233 v234
    let v236 : string = "fable_library_rust::String_::fromString($0)"
    let v237 : string = Fable.Core.RustInterop.emitRustExpr v235 v236
    v237
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v238 : string = null |> unbox<string>
    v238
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v239 : string = null |> unbox<string>
    v239
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v240 : string = null |> unbox<string>
    v240
#endif
    
#if FABLE_COMPILER_PYTHON
    let v241 : string = null |> unbox<string>
    v241
#endif
    
#else
    let v242 : string = System.Text.RegularExpressions.Regex.Replace (v226, v221, v200)
    v242
#endif
    |> fun x -> _v227 <- Some x
    let v243 : string = _v227.Value
    let v244 : string = $"{v243.[0] |> string |> _.ToLower()}{v243.[1..]}"
    let v245 : string = v244.Replace (v202, v203)
    let v246 : string option = None
    let v247 : System.Threading.CancellationToken option = None
    let v248 : (struct (string * string) []) = [||]
    let v249 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v250 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v251 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v245}\""
    let v252 : string option = Some v2 
    let v253 : struct (int32 * string) option = None
    let v254 : bool = true in let mutable _v253 = v253
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v255 : string = method38(v247, v251, v248, v249, v250, v252)
    let struct (v256 : string, v257 : string) = method39()
    let v258 : int32 = v255.Length
    let v259 : (char []) = Array.zeroCreate<char> (v258)
    let v260 : Mut5 = {l0 = 0} : Mut5
    while method26(v258, v260) do
        let v262 : int32 = v260.l0
        let v263 : char = v255.[int v262]
        v259.[int v262] <- v263
        let v264 : int32 = v262 + 1
        v260.l0 <- v264
        ()
    let v265 : ((char []) -> char list) = Array.toList
    let v266 : char list = v265 v259
    let v267 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v268 : (char -> (UH0 -> UH0)) = method40()
    let v269 : (char list -> (UH0 -> UH0)) = v267 v268
    let v270 : (UH0 -> UH0) = v269 v266
    let v271 : UH0 = UH0_0
    let v272 : UH0 = v270 v271
    let v273 : US8 = US8_0
    let struct (v274 : string, v275 : string) = method41(v257, v256, v272, v273)
    let v276 : (string []) = method42(v275)
    let v277 : string = "$0.to_vec()"
    let v278 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v276 v277
    let v279 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v280 : (string -> std_string_String) = closure28()
    let v281 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v278, v280) v279
    let v282 : US0 = US0_1
    let v283 : (unit -> string) = closure29(v247, v251, v248, v249, v250, v252, v274, v281)
    let v284 : (unit -> string) = method47()
    method3(v282, v283, v284)
    let v285 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v247, v251, v248, v249, v250, v252, v274, v281)
    let v286 : string = "futures_lite::future::block_on($0)"
    let v287 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v285 v286
    let (a, b) = v287
    let v288 : int32 = a
    let v289 : string = b
    struct (v288, v289)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v290 : int32, v291 : string) = null |> unbox<struct (int32 * string)>
    struct (v290, v291)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v292 : int32, v293 : string) = null |> unbox<struct (int32 * string)>
    struct (v292, v293)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v294 : int32, v295 : string) = null |> unbox<struct (int32 * string)>
    struct (v294, v295)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v296 : int32, v297 : string) = null |> unbox<struct (int32 * string)>
    struct (v296, v297)
#endif
    
#else
    let v298 : Async<struct (int32 * string)> option = None
    let v299 : bool = true in let mutable _v298 = v298
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v300 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v300
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v301 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v301
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v302 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v302
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v303 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v303
#endif
    
#if FABLE_COMPILER_PYTHON
    let v304 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v304
#endif
    
#else
    let v305 : Async<struct (int32 * string)> option = None
    let v306 : bool = true in let mutable _v305 = v305
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v307 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v307
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v308 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v308
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v309 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v309
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v310 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v310
#endif
    
#if FABLE_COMPILER_PYTHON
    let v311 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v311
#endif
    
#else
    let v312 : Async<struct (int32 * string)> option = None
    let mutable _v312 = v312
    async {
    let struct (v313 : string, v314 : string) = method39()
    let v315 : int32 = v251.Length
    let v316 : (char []) = Array.zeroCreate<char> (v315)
    let v317 : Mut5 = {l0 = 0} : Mut5
    while method26(v315, v317) do
        let v319 : int32 = v317.l0
        let v320 : char = v251.[int v319]
        v316.[int v319] <- v320
        let v321 : int32 = v319 + 1
        v317.l0 <- v321
        ()
    let v322 : ((char []) -> char list) = Array.toList
    let v323 : char list = v322 v316
    let v324 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v325 : (char -> (UH0 -> UH0)) = method40()
    let v326 : (char list -> (UH0 -> UH0)) = v324 v325
    let v327 : (UH0 -> UH0) = v326 v323
    let v328 : UH0 = UH0_0
    let v329 : UH0 = v327 v328
    let v330 : US8 = US8_0
    let struct (v331 : string, v332 : string) = method41(v314, v313, v329, v330)
    let v333 : (string -> US4) = method19()
    let v334 : US4 = US4_1
    let v335 : US4 = v252 |> Option.map v333 |> Option.defaultValue v334 
    let v338 : string =
        match v335 with
        | US4_1 -> (* None *)
            v200
        | US4_0(v336) -> (* Some *)
            v336
    let v339 : US0 = US0_1
    let v340 : (unit -> string) = closure48(v247, v251, v248, v249, v250, v252)
    let v341 : (unit -> string) = method47()
    method3(v339, v340, v341)
    let v342 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v343 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v332, StandardOutputEncoding = v342, WorkingDirectory = v338, FileName = v331, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v344 : int32 = v248.Length
    let v345 : Mut5 = {l0 = 0} : Mut5
    while method26(v344, v345) do
        let v347 : int32 = v345.l0
        let struct (v348 : string, v349 : string) = v248.[int v347]
        v343.EnvironmentVariables.[v348] <- v349 
        let v350 : int32 = v347 + 1
        v345.l0 <- v350
        ()
    let v351 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v343)
    use v351 = v351 
    let v352 : System.Diagnostics.Process = v351 
    let v353 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v354 : System.Collections.Concurrent.ConcurrentStack<string> = v353 ()
    let v355 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v247, v251, v248, v249, v250, v252, v352, v354)
    v352.OutputDataReceived.Add v355 
    let v356 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v247, v251, v248, v249, v250, v252, v352, v354)
    v352.ErrorDataReceived.Add v356 
    let v357 : (unit -> bool) = v352.Start
    let v358 : bool = v357 ()
    let v359 : bool = v358 = false
    if v359 then
        let v360 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v360
    let v361 : (unit -> unit) = v352.BeginErrorReadLine
    v361 ()
    let v362 : (unit -> unit) = v352.BeginOutputReadLine
    v362 ()
    let v363 : (System.Threading.CancellationToken -> US18) = method70()
    let v364 : US18 = US18_1
    let v365 : US18 = v247 |> Option.map v363 |> Option.defaultValue v364 
    let v369 : System.Threading.CancellationToken =
        match v365 with
        | US18_1 -> (* None *)
            let v367 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v367
        | US18_0(v366) -> (* Some *)
            v366
    let v370 : Async<System.Threading.CancellationToken> option = None
    let v371 : bool = true in let mutable _v370 = v370
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v372 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v372
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v373 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v373
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v374 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v374
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v375 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v375
#endif
    
#if FABLE_COMPILER_PYTHON
    let v376 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v376
#endif
    
#else
    let v377 : Async<System.Threading.CancellationToken> option = None
    let v378 : bool = true in let mutable _v377 = v377
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v379 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v379
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v380 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v380
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v381 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v381
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v382 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v382
#endif
    
#if FABLE_COMPILER_PYTHON
    let v383 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v383
#endif
    
#else
    let v384 : Async<System.Threading.CancellationToken> option = None
    let mutable _v384 = v384
    async {
    let v385 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v385 = v385 
    let v386 : System.Threading.CancellationToken = v385 
    let v387 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v388 : (System.Threading.CancellationToken []) = [|v386; v387; v369|]
    let v389 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v390 : System.Threading.CancellationTokenSource = v389 v388
    let v391 : System.Threading.CancellationToken = v390.Token
    return v391 
    }
    |> fun x -> _v384 <- Some x
    let v392 : Async<System.Threading.CancellationToken> = _v384 |> Option.get
    v392
#endif
    |> fun x -> _v377 <- Some x
    let v393 : Async<System.Threading.CancellationToken> = _v377.Value
    v393
#endif
    |> fun x -> _v370 <- Some x
    let v394 : Async<System.Threading.CancellationToken> = _v370.Value
    let! v394 = v394 
    let v395 : System.Threading.CancellationToken = v394 
    let v396 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v395.Register
    let v397 : (unit -> unit) = closure54(v352)
    let v398 : System.Threading.CancellationTokenRegistration = v396 v397
    use v398 = v398 
    let v399 : System.Threading.CancellationTokenRegistration = v398 
    let v400 : Async<int32> option = None
    let v401 : bool = true in let mutable _v400 = v400
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v402 : Async<int32> = null |> unbox<Async<int32>>
    v402
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v403 : Async<int32> = null |> unbox<Async<int32>>
    v403
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v404 : Async<int32> = null |> unbox<Async<int32>>
    v404
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v405 : Async<int32> = null |> unbox<Async<int32>>
    v405
#endif
    
#if FABLE_COMPILER_PYTHON
    let v406 : Async<int32> = null |> unbox<Async<int32>>
    v406
#endif
    
#else
    let v407 : Async<int32> option = None
    let mutable _v407 = v407
    async {
    try
    let v408 : System.Threading.Tasks.Task = v352.WaitForExitAsync v395 
    let v409 : Async<unit> option = None
    let v410 : bool = true in let mutable _v409 = v409
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v411 : Async<unit> = null |> unbox<Async<unit>>
    v411
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v412 : Async<unit> = null |> unbox<Async<unit>>
    v412
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v413 : Async<unit> = null |> unbox<Async<unit>>
    v413
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v414 : Async<unit> = null |> unbox<Async<unit>>
    v414
#endif
    
#if FABLE_COMPILER_PYTHON
    let v415 : Async<unit> = null |> unbox<Async<unit>>
    v415
#endif
    
#else
    let v416 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v417 : Async<unit> = v416 v408
    v417
#endif
    |> fun x -> _v409 <- Some x
    let v418 : Async<unit> = _v409.Value
    do! v418 
    let v419 : int32 = v352.ExitCode
    return v419 
    with ex ->
    let v420 : exn = ex
    let v421 : string option = None
    let v422 : bool = true in let mutable _v421 = v421
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v423 : string = $"%A{v420}"
    v423
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v424 : string = $"%A{v420}"
    v424
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v425 : string = $"%A{v420}"
    v425
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v426 : string = $"%A{v420}"
    v426
#endif
    
#if FABLE_COMPILER_PYTHON
    let v427 : string = $"%A{v420}"
    v427
#endif
    
#else
    let v428 : string = $"{v420.GetType ()}: {v420.Message}"
    v428
#endif
    |> fun x -> _v421 <- Some x
    let v429 : string = _v421.Value
    let v430 : (string -> unit) = v354.Push
    v430 v429
    let v431 : System.Threading.Tasks.TaskCanceledException = v420 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v432 : US0 = US0_3
    let v433 : (unit -> string) = closure55(v431)
    let v434 : (unit -> string) = method47()
    method3(v432, v433, v434)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v407 <- Some x
    let v435 : Async<int32> = _v407 |> Option.get
    v435
#endif
    |> fun x -> _v400 <- Some x
    let v436 : Async<int32> = _v400.Value
    let! v436 = v436 
    let v437 : int32 = v436 
    let v438 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v439 : string seq = v438 v354
    let v440 : string = method71()
    let v441 : (string -> (string seq -> string)) = String.concat
    let v442 : (string seq -> string) = v441 v440
    let v443 : string = v442 v439
    let v444 : US0 = US0_1
    let v445 : (unit -> string) = closure56(v437, v443)
    let v446 : (unit -> string) = method47()
    method3(v444, v445, v446)
    return struct (v437, v443) 
    }
    |> fun x -> _v312 <- Some x
    let v447 : Async<struct (int32 * string)> = _v312 |> Option.get
    v447
#endif
    |> fun x -> _v305 <- Some x
    let v448 : Async<struct (int32 * string)> = _v305.Value
    v448
#endif
    |> fun x -> _v298 <- Some x
    let v449 : Async<struct (int32 * string)> = _v298.Value
    let v450 : struct (int32 * string) option = None
    let v451 : bool = true in let mutable _v450 = v450
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v452 : int32, v453 : string) = null |> unbox<struct (int32 * string)>
    struct (v452, v453)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v454 : int32, v455 : string) = null |> unbox<struct (int32 * string)>
    struct (v454, v455)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v456 : int32, v457 : string) = null |> unbox<struct (int32 * string)>
    struct (v456, v457)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v458 : int32, v459 : string) = null |> unbox<struct (int32 * string)>
    struct (v458, v459)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v460 : int32, v461 : string) = null |> unbox<struct (int32 * string)>
    struct (v460, v461)
#endif
    
#else
    let v462 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v463 : int32, v464 : string) = v462 v449
    struct (v463, v464)
#endif
    |> fun x -> _v450 <- Some x
    let struct (v465 : int32, v466 : string) = _v450.Value
    struct (v465, v466)
#endif
    |> fun x -> _v253 <- Some x
    let struct (v467 : int32, v468 : string) = _v253.Value
    let v469 : string = method13(v3, v205)
    let v470 : string option = None
    let v471 : bool = true in let mutable _v470 = v470
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v472 : string = method22()
    let v473 : string = method23(v469)
    let v474 : string = method24()
    let v475 : string = $"regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
    let v476 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v472, v473, v474) v475
    let v477 : string = "String::from($0)"
    let v478 : std_string_String = Fable.Core.RustInterop.emitRustExpr v476 v477
    let v479 : string = "fable_library_rust::String_::fromString($0)"
    let v480 : string = Fable.Core.RustInterop.emitRustExpr v478 v479
    v480
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v481 : string = null |> unbox<string>
    v481
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v482 : string = null |> unbox<string>
    v482
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v483 : string = null |> unbox<string>
    v483
#endif
    
#if FABLE_COMPILER_PYTHON
    let v484 : string = null |> unbox<string>
    v484
#endif
    
#else
    let v485 : string = System.Text.RegularExpressions.Regex.Replace (v469, v221, v200)
    v485
#endif
    |> fun x -> _v470 <- Some x
    let v486 : string = _v470.Value
    let v487 : string = $"{v486.[0] |> string |> _.ToLower()}{v486.[1..]}"
    let v488 : string = v487.Replace (v202, v203)
    let v489 : string option = None
    let v490 : System.Threading.CancellationToken option = None
    let v491 : (struct (string * string) []) = [||]
    let v492 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v493 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v494 : string = $"git hash-object \"{v488}\""
    let v495 : string option = Some v3 
    let v496 : struct (int32 * string) option = None
    let v497 : bool = true in let mutable _v496 = v496
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v498 : string = method38(v490, v494, v491, v492, v493, v495)
    let struct (v499 : string, v500 : string) = method39()
    let v501 : int32 = v498.Length
    let v502 : (char []) = Array.zeroCreate<char> (v501)
    let v503 : Mut5 = {l0 = 0} : Mut5
    while method26(v501, v503) do
        let v505 : int32 = v503.l0
        let v506 : char = v498.[int v505]
        v502.[int v505] <- v506
        let v507 : int32 = v505 + 1
        v503.l0 <- v507
        ()
    let v508 : ((char []) -> char list) = Array.toList
    let v509 : char list = v508 v502
    let v510 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v511 : (char -> (UH0 -> UH0)) = method40()
    let v512 : (char list -> (UH0 -> UH0)) = v510 v511
    let v513 : (UH0 -> UH0) = v512 v509
    let v514 : UH0 = UH0_0
    let v515 : UH0 = v513 v514
    let v516 : US8 = US8_0
    let struct (v517 : string, v518 : string) = method41(v500, v499, v515, v516)
    let v519 : (string []) = method42(v518)
    let v520 : string = "$0.to_vec()"
    let v521 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v519 v520
    let v522 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v523 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v521, v280) v522
    let v524 : US0 = US0_1
    let v525 : (unit -> string) = closure29(v490, v494, v491, v492, v493, v495, v517, v523)
    let v526 : (unit -> string) = method47()
    method3(v524, v525, v526)
    let v527 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v490, v494, v491, v492, v493, v495, v517, v523)
    let v528 : string = "futures_lite::future::block_on($0)"
    let v529 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v527 v528
    let (a, b) = v529
    let v530 : int32 = a
    let v531 : string = b
    struct (v530, v531)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v532 : int32, v533 : string) = null |> unbox<struct (int32 * string)>
    struct (v532, v533)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v534 : int32, v535 : string) = null |> unbox<struct (int32 * string)>
    struct (v534, v535)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v536 : int32, v537 : string) = null |> unbox<struct (int32 * string)>
    struct (v536, v537)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v538 : int32, v539 : string) = null |> unbox<struct (int32 * string)>
    struct (v538, v539)
#endif
    
#else
    let v540 : Async<struct (int32 * string)> option = None
    let v541 : bool = true in let mutable _v540 = v540
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v542 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v542
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v543 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v543
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v544 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v544
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v545 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v545
#endif
    
#if FABLE_COMPILER_PYTHON
    let v546 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v546
#endif
    
#else
    let v547 : Async<struct (int32 * string)> option = None
    let v548 : bool = true in let mutable _v547 = v547
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v549 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v549
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v550 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v550
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v551 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v551
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v552 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v552
#endif
    
#if FABLE_COMPILER_PYTHON
    let v553 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v553
#endif
    
#else
    let v554 : Async<struct (int32 * string)> option = None
    let mutable _v554 = v554
    async {
    let struct (v555 : string, v556 : string) = method39()
    let v557 : int32 = v494.Length
    let v558 : (char []) = Array.zeroCreate<char> (v557)
    let v559 : Mut5 = {l0 = 0} : Mut5
    while method26(v557, v559) do
        let v561 : int32 = v559.l0
        let v562 : char = v494.[int v561]
        v558.[int v561] <- v562
        let v563 : int32 = v561 + 1
        v559.l0 <- v563
        ()
    let v564 : ((char []) -> char list) = Array.toList
    let v565 : char list = v564 v558
    let v566 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v567 : (char -> (UH0 -> UH0)) = method40()
    let v568 : (char list -> (UH0 -> UH0)) = v566 v567
    let v569 : (UH0 -> UH0) = v568 v565
    let v570 : UH0 = UH0_0
    let v571 : UH0 = v569 v570
    let v572 : US8 = US8_0
    let struct (v573 : string, v574 : string) = method41(v556, v555, v571, v572)
    let v575 : (string -> US4) = method19()
    let v576 : US4 = US4_1
    let v577 : US4 = v495 |> Option.map v575 |> Option.defaultValue v576 
    let v580 : string =
        match v577 with
        | US4_1 -> (* None *)
            v200
        | US4_0(v578) -> (* Some *)
            v578
    let v581 : US0 = US0_1
    let v582 : (unit -> string) = closure48(v490, v494, v491, v492, v493, v495)
    let v583 : (unit -> string) = method47()
    method3(v581, v582, v583)
    let v584 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v585 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v574, StandardOutputEncoding = v584, WorkingDirectory = v580, FileName = v573, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v586 : int32 = v491.Length
    let v587 : Mut5 = {l0 = 0} : Mut5
    while method26(v586, v587) do
        let v589 : int32 = v587.l0
        let struct (v590 : string, v591 : string) = v491.[int v589]
        v585.EnvironmentVariables.[v590] <- v591 
        let v592 : int32 = v589 + 1
        v587.l0 <- v592
        ()
    let v593 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v585)
    use v593 = v593 
    let v594 : System.Diagnostics.Process = v593 
    let v595 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v596 : System.Collections.Concurrent.ConcurrentStack<string> = v595 ()
    let v597 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v490, v494, v491, v492, v493, v495, v594, v596)
    v594.OutputDataReceived.Add v597 
    let v598 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v490, v494, v491, v492, v493, v495, v594, v596)
    v594.ErrorDataReceived.Add v598 
    let v599 : (unit -> bool) = v594.Start
    let v600 : bool = v599 ()
    let v601 : bool = v600 = false
    if v601 then
        let v602 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v602
    let v603 : (unit -> unit) = v594.BeginErrorReadLine
    v603 ()
    let v604 : (unit -> unit) = v594.BeginOutputReadLine
    v604 ()
    let v605 : (System.Threading.CancellationToken -> US18) = method70()
    let v606 : US18 = US18_1
    let v607 : US18 = v490 |> Option.map v605 |> Option.defaultValue v606 
    let v611 : System.Threading.CancellationToken =
        match v607 with
        | US18_1 -> (* None *)
            let v609 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v609
        | US18_0(v608) -> (* Some *)
            v608
    let v612 : Async<System.Threading.CancellationToken> option = None
    let v613 : bool = true in let mutable _v612 = v612
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v614 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v614
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v615 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v615
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v616 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v616
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v617 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v617
#endif
    
#if FABLE_COMPILER_PYTHON
    let v618 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v618
#endif
    
#else
    let v619 : Async<System.Threading.CancellationToken> option = None
    let v620 : bool = true in let mutable _v619 = v619
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v621 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v621
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v622 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v622
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v623 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v623
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v624 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v624
#endif
    
#if FABLE_COMPILER_PYTHON
    let v625 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v625
#endif
    
#else
    let v626 : Async<System.Threading.CancellationToken> option = None
    let mutable _v626 = v626
    async {
    let v627 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v627 = v627 
    let v628 : System.Threading.CancellationToken = v627 
    let v629 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v630 : (System.Threading.CancellationToken []) = [|v628; v629; v611|]
    let v631 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v632 : System.Threading.CancellationTokenSource = v631 v630
    let v633 : System.Threading.CancellationToken = v632.Token
    return v633 
    }
    |> fun x -> _v626 <- Some x
    let v634 : Async<System.Threading.CancellationToken> = _v626 |> Option.get
    v634
#endif
    |> fun x -> _v619 <- Some x
    let v635 : Async<System.Threading.CancellationToken> = _v619.Value
    v635
#endif
    |> fun x -> _v612 <- Some x
    let v636 : Async<System.Threading.CancellationToken> = _v612.Value
    let! v636 = v636 
    let v637 : System.Threading.CancellationToken = v636 
    let v638 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v637.Register
    let v639 : (unit -> unit) = closure54(v594)
    let v640 : System.Threading.CancellationTokenRegistration = v638 v639
    use v640 = v640 
    let v641 : System.Threading.CancellationTokenRegistration = v640 
    let v642 : Async<int32> option = None
    let v643 : bool = true in let mutable _v642 = v642
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v644 : Async<int32> = null |> unbox<Async<int32>>
    v644
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v645 : Async<int32> = null |> unbox<Async<int32>>
    v645
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v646 : Async<int32> = null |> unbox<Async<int32>>
    v646
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v647 : Async<int32> = null |> unbox<Async<int32>>
    v647
#endif
    
#if FABLE_COMPILER_PYTHON
    let v648 : Async<int32> = null |> unbox<Async<int32>>
    v648
#endif
    
#else
    let v649 : Async<int32> option = None
    let mutable _v649 = v649
    async {
    try
    let v650 : System.Threading.Tasks.Task = v594.WaitForExitAsync v637 
    let v651 : Async<unit> option = None
    let v652 : bool = true in let mutable _v651 = v651
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v653 : Async<unit> = null |> unbox<Async<unit>>
    v653
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v654 : Async<unit> = null |> unbox<Async<unit>>
    v654
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v655 : Async<unit> = null |> unbox<Async<unit>>
    v655
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v656 : Async<unit> = null |> unbox<Async<unit>>
    v656
#endif
    
#if FABLE_COMPILER_PYTHON
    let v657 : Async<unit> = null |> unbox<Async<unit>>
    v657
#endif
    
#else
    let v658 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v659 : Async<unit> = v658 v650
    v659
#endif
    |> fun x -> _v651 <- Some x
    let v660 : Async<unit> = _v651.Value
    do! v660 
    let v661 : int32 = v594.ExitCode
    return v661 
    with ex ->
    let v662 : exn = ex
    let v663 : string option = None
    let v664 : bool = true in let mutable _v663 = v663
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v665 : string = $"%A{v662}"
    v665
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v666 : string = $"%A{v662}"
    v666
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v667 : string = $"%A{v662}"
    v667
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v668 : string = $"%A{v662}"
    v668
#endif
    
#if FABLE_COMPILER_PYTHON
    let v669 : string = $"%A{v662}"
    v669
#endif
    
#else
    let v670 : string = $"{v662.GetType ()}: {v662.Message}"
    v670
#endif
    |> fun x -> _v663 <- Some x
    let v671 : string = _v663.Value
    let v672 : (string -> unit) = v596.Push
    v672 v671
    let v673 : System.Threading.Tasks.TaskCanceledException = v662 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v674 : US0 = US0_3
    let v675 : (unit -> string) = closure55(v673)
    let v676 : (unit -> string) = method47()
    method3(v674, v675, v676)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v649 <- Some x
    let v677 : Async<int32> = _v649 |> Option.get
    v677
#endif
    |> fun x -> _v642 <- Some x
    let v678 : Async<int32> = _v642.Value
    let! v678 = v678 
    let v679 : int32 = v678 
    let v680 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v681 : string seq = v680 v596
    let v682 : string = method71()
    let v683 : (string -> (string seq -> string)) = String.concat
    let v684 : (string seq -> string) = v683 v682
    let v685 : string = v684 v681
    let v686 : US0 = US0_1
    let v687 : (unit -> string) = closure56(v679, v685)
    let v688 : (unit -> string) = method47()
    method3(v686, v687, v688)
    return struct (v679, v685) 
    }
    |> fun x -> _v554 <- Some x
    let v689 : Async<struct (int32 * string)> = _v554 |> Option.get
    v689
#endif
    |> fun x -> _v547 <- Some x
    let v690 : Async<struct (int32 * string)> = _v547.Value
    v690
#endif
    |> fun x -> _v540 <- Some x
    let v691 : Async<struct (int32 * string)> = _v540.Value
    let v692 : struct (int32 * string) option = None
    let v693 : bool = true in let mutable _v692 = v692
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v694 : int32, v695 : string) = null |> unbox<struct (int32 * string)>
    struct (v694, v695)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v696 : int32, v697 : string) = null |> unbox<struct (int32 * string)>
    struct (v696, v697)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v698 : int32, v699 : string) = null |> unbox<struct (int32 * string)>
    struct (v698, v699)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v700 : int32, v701 : string) = null |> unbox<struct (int32 * string)>
    struct (v700, v701)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v702 : int32, v703 : string) = null |> unbox<struct (int32 * string)>
    struct (v702, v703)
#endif
    
#else
    let v704 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v705 : int32, v706 : string) = v704 v691
    struct (v705, v706)
#endif
    |> fun x -> _v692 <- Some x
    let struct (v707 : int32, v708 : string) = _v692.Value
    struct (v707, v708)
#endif
    |> fun x -> _v496 <- Some x
    let struct (v709 : int32, v710 : string) = _v496.Value
    let v711 : string = method13(v4, v205)
    let v712 : string option = None
    let v713 : bool = true in let mutable _v712 = v712
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v714 : string = method22()
    let v715 : string = method23(v711)
    let v716 : string = method24()
    let v717 : string = $"regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
    let v718 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v714, v715, v716) v717
    let v719 : string = "String::from($0)"
    let v720 : std_string_String = Fable.Core.RustInterop.emitRustExpr v718 v719
    let v721 : string = "fable_library_rust::String_::fromString($0)"
    let v722 : string = Fable.Core.RustInterop.emitRustExpr v720 v721
    v722
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v723 : string = null |> unbox<string>
    v723
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v724 : string = null |> unbox<string>
    v724
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v725 : string = null |> unbox<string>
    v725
#endif
    
#if FABLE_COMPILER_PYTHON
    let v726 : string = null |> unbox<string>
    v726
#endif
    
#else
    let v727 : string = System.Text.RegularExpressions.Regex.Replace (v711, v221, v200)
    v727
#endif
    |> fun x -> _v712 <- Some x
    let v728 : string = _v712.Value
    let v729 : string = $"{v728.[0] |> string |> _.ToLower()}{v728.[1..]}"
    let v730 : string = v729.Replace (v202, v203)
    let v731 : string = "hangul.md"
    let struct (v732 : string, v733 : string) = method72(v731, v488, v4)
    let v734 : bool = v468.Contains v710
    let v735 : bool = v734 = false
    let v1300 : UH2 =
        if v735 then
            let v736 : string option = None
            let v737 : bool = true in let mutable _v736 = v736
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v738 : string = method22()
            let v739 : string = method23(v488)
            let v740 : string = method24()
            let v741 : string = $"regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v742 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v738, v739, v740) v741
            let v743 : string = "String::from($0)"
            let v744 : std_string_String = Fable.Core.RustInterop.emitRustExpr v742 v743
            let v745 : string = "fable_library_rust::String_::fromString($0)"
            let v746 : string = Fable.Core.RustInterop.emitRustExpr v744 v745
            v746
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v747 : string = null |> unbox<string>
            v747
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v748 : string = null |> unbox<string>
            v748
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v749 : string = null |> unbox<string>
            v749
#endif
            
#if FABLE_COMPILER_PYTHON
            let v750 : string = null |> unbox<string>
            v750
#endif
            
#else
            let v751 : string = System.Text.RegularExpressions.Regex.Replace (v488, v221, v200)
            v751
#endif
            |> fun x -> _v736 <- Some x
            let v752 : string = _v736.Value
            let v753 : string = $"{v752.[0] |> string |> _.ToLower()}{v752.[1..]}"
            let v754 : string = v753.Replace (v202, v203)
            let v755 : string option = None
            let v756 : System.Threading.CancellationToken option = None
            let v757 : (struct (string * string) []) = [||]
            let v758 : (struct (bool * string * int32) -> Async<unit>) option = None
            let v759 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
            let v760 : string = $"pwsh -c \"(Get-FileHash \\\"{v754}\\\" -Algorithm SHA256).Hash\""
            let v761 : struct (int32 * string) option = None
            let v762 : bool = true in let mutable _v761 = v761
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v763 : string = method38(v756, v760, v757, v758, v759, v755)
            let struct (v764 : string, v765 : string) = method39()
            let v766 : int32 = v763.Length
            let v767 : (char []) = Array.zeroCreate<char> (v766)
            let v768 : Mut5 = {l0 = 0} : Mut5
            while method26(v766, v768) do
                let v770 : int32 = v768.l0
                let v771 : char = v763.[int v770]
                v767.[int v770] <- v771
                let v772 : int32 = v770 + 1
                v768.l0 <- v772
                ()
            let v773 : ((char []) -> char list) = Array.toList
            let v774 : char list = v773 v767
            let v775 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v776 : (char -> (UH0 -> UH0)) = method40()
            let v777 : (char list -> (UH0 -> UH0)) = v775 v776
            let v778 : (UH0 -> UH0) = v777 v774
            let v779 : UH0 = UH0_0
            let v780 : UH0 = v778 v779
            let v781 : US8 = US8_0
            let struct (v782 : string, v783 : string) = method41(v765, v764, v780, v781)
            let v784 : (string []) = method42(v783)
            let v785 : string = "$0.to_vec()"
            let v786 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v784 v785
            let v787 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v788 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v786, v280) v787
            let v789 : US0 = US0_1
            let v790 : (unit -> string) = closure29(v756, v760, v757, v758, v759, v755, v782, v788)
            let v791 : (unit -> string) = method47()
            method3(v789, v790, v791)
            let v792 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v756, v760, v757, v758, v759, v755, v782, v788)
            let v793 : string = "futures_lite::future::block_on($0)"
            let v794 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v792 v793
            let (a, b) = v794
            let v795 : int32 = a
            let v796 : string = b
            struct (v795, v796)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v797 : int32, v798 : string) = null |> unbox<struct (int32 * string)>
            struct (v797, v798)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v799 : int32, v800 : string) = null |> unbox<struct (int32 * string)>
            struct (v799, v800)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v801 : int32, v802 : string) = null |> unbox<struct (int32 * string)>
            struct (v801, v802)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v803 : int32, v804 : string) = null |> unbox<struct (int32 * string)>
            struct (v803, v804)
#endif
            
#else
            let v805 : Async<struct (int32 * string)> option = None
            let v806 : bool = true in let mutable _v805 = v805
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v807 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v807
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v808 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v808
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v809 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v809
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v810 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v810
#endif
            
#if FABLE_COMPILER_PYTHON
            let v811 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v811
#endif
            
#else
            let v812 : Async<struct (int32 * string)> option = None
            let v813 : bool = true in let mutable _v812 = v812
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v814 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v814
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v815 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v815
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v816 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v816
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v817 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v817
#endif
            
#if FABLE_COMPILER_PYTHON
            let v818 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v818
#endif
            
#else
            let v819 : Async<struct (int32 * string)> option = None
            let mutable _v819 = v819
            async {
            let struct (v820 : string, v821 : string) = method39()
            let v822 : int32 = v760.Length
            let v823 : (char []) = Array.zeroCreate<char> (v822)
            let v824 : Mut5 = {l0 = 0} : Mut5
            while method26(v822, v824) do
                let v826 : int32 = v824.l0
                let v827 : char = v760.[int v826]
                v823.[int v826] <- v827
                let v828 : int32 = v826 + 1
                v824.l0 <- v828
                ()
            let v829 : ((char []) -> char list) = Array.toList
            let v830 : char list = v829 v823
            let v831 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v832 : (char -> (UH0 -> UH0)) = method40()
            let v833 : (char list -> (UH0 -> UH0)) = v831 v832
            let v834 : (UH0 -> UH0) = v833 v830
            let v835 : UH0 = UH0_0
            let v836 : UH0 = v834 v835
            let v837 : US8 = US8_0
            let struct (v838 : string, v839 : string) = method41(v821, v820, v836, v837)
            let v840 : (string -> US4) = method19()
            let v841 : US4 = US4_1
            let v842 : US4 = v755 |> Option.map v840 |> Option.defaultValue v841 
            let v845 : string =
                match v842 with
                | US4_1 -> (* None *)
                    v200
                | US4_0(v843) -> (* Some *)
                    v843
            let v846 : US0 = US0_1
            let v847 : (unit -> string) = closure48(v756, v760, v757, v758, v759, v755)
            let v848 : (unit -> string) = method47()
            method3(v846, v847, v848)
            let v849 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v850 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v839, StandardOutputEncoding = v849, WorkingDirectory = v845, FileName = v838, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v851 : int32 = v757.Length
            let v852 : Mut5 = {l0 = 0} : Mut5
            while method26(v851, v852) do
                let v854 : int32 = v852.l0
                let struct (v855 : string, v856 : string) = v757.[int v854]
                v850.EnvironmentVariables.[v855] <- v856 
                let v857 : int32 = v854 + 1
                v852.l0 <- v857
                ()
            let v858 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v850)
            use v858 = v858 
            let v859 : System.Diagnostics.Process = v858 
            let v860 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v861 : System.Collections.Concurrent.ConcurrentStack<string> = v860 ()
            let v862 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v756, v760, v757, v758, v759, v755, v859, v861)
            v859.OutputDataReceived.Add v862 
            let v863 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v756, v760, v757, v758, v759, v755, v859, v861)
            v859.ErrorDataReceived.Add v863 
            let v864 : (unit -> bool) = v859.Start
            let v865 : bool = v864 ()
            let v866 : bool = v865 = false
            if v866 then
                let v867 : string = $"execute_with_options_async / process_start error"
                failwith<unit> v867
            let v868 : (unit -> unit) = v859.BeginErrorReadLine
            v868 ()
            let v869 : (unit -> unit) = v859.BeginOutputReadLine
            v869 ()
            let v870 : (System.Threading.CancellationToken -> US18) = method70()
            let v871 : US18 = US18_1
            let v872 : US18 = v756 |> Option.map v870 |> Option.defaultValue v871 
            let v876 : System.Threading.CancellationToken =
                match v872 with
                | US18_1 -> (* None *)
                    let v874 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v874
                | US18_0(v873) -> (* Some *)
                    v873
            let v877 : Async<System.Threading.CancellationToken> option = None
            let v878 : bool = true in let mutable _v877 = v877
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v879 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v879
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v880 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v880
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v881 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v881
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v882 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v882
#endif
            
#if FABLE_COMPILER_PYTHON
            let v883 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v883
#endif
            
#else
            let v884 : Async<System.Threading.CancellationToken> option = None
            let v885 : bool = true in let mutable _v884 = v884
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v886 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v886
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v887 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v887
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v888 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v888
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v889 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v889
#endif
            
#if FABLE_COMPILER_PYTHON
            let v890 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v890
#endif
            
#else
            let v891 : Async<System.Threading.CancellationToken> option = None
            let mutable _v891 = v891
            async {
            let v892 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v892 = v892 
            let v893 : System.Threading.CancellationToken = v892 
            let v894 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v895 : (System.Threading.CancellationToken []) = [|v893; v894; v876|]
            let v896 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v897 : System.Threading.CancellationTokenSource = v896 v895
            let v898 : System.Threading.CancellationToken = v897.Token
            return v898 
            }
            |> fun x -> _v891 <- Some x
            let v899 : Async<System.Threading.CancellationToken> = _v891 |> Option.get
            v899
#endif
            |> fun x -> _v884 <- Some x
            let v900 : Async<System.Threading.CancellationToken> = _v884.Value
            v900
#endif
            |> fun x -> _v877 <- Some x
            let v901 : Async<System.Threading.CancellationToken> = _v877.Value
            let! v901 = v901 
            let v902 : System.Threading.CancellationToken = v901 
            let v903 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v902.Register
            let v904 : (unit -> unit) = closure54(v859)
            let v905 : System.Threading.CancellationTokenRegistration = v903 v904
            use v905 = v905 
            let v906 : System.Threading.CancellationTokenRegistration = v905 
            let v907 : Async<int32> option = None
            let v908 : bool = true in let mutable _v907 = v907
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v909 : Async<int32> = null |> unbox<Async<int32>>
            v909
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v910 : Async<int32> = null |> unbox<Async<int32>>
            v910
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v911 : Async<int32> = null |> unbox<Async<int32>>
            v911
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v912 : Async<int32> = null |> unbox<Async<int32>>
            v912
#endif
            
#if FABLE_COMPILER_PYTHON
            let v913 : Async<int32> = null |> unbox<Async<int32>>
            v913
#endif
            
#else
            let v914 : Async<int32> option = None
            let mutable _v914 = v914
            async {
            try
            let v915 : System.Threading.Tasks.Task = v859.WaitForExitAsync v902 
            let v916 : Async<unit> option = None
            let v917 : bool = true in let mutable _v916 = v916
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v918 : Async<unit> = null |> unbox<Async<unit>>
            v918
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v919 : Async<unit> = null |> unbox<Async<unit>>
            v919
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v920 : Async<unit> = null |> unbox<Async<unit>>
            v920
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v921 : Async<unit> = null |> unbox<Async<unit>>
            v921
#endif
            
#if FABLE_COMPILER_PYTHON
            let v922 : Async<unit> = null |> unbox<Async<unit>>
            v922
#endif
            
#else
            let v923 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v924 : Async<unit> = v923 v915
            v924
#endif
            |> fun x -> _v916 <- Some x
            let v925 : Async<unit> = _v916.Value
            do! v925 
            let v926 : int32 = v859.ExitCode
            return v926 
            with ex ->
            let v927 : exn = ex
            let v928 : string option = None
            let v929 : bool = true in let mutable _v928 = v928
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v930 : string = $"%A{v927}"
            v930
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v931 : string = $"%A{v927}"
            v931
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v932 : string = $"%A{v927}"
            v932
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v933 : string = $"%A{v927}"
            v933
#endif
            
#if FABLE_COMPILER_PYTHON
            let v934 : string = $"%A{v927}"
            v934
#endif
            
#else
            let v935 : string = $"{v927.GetType ()}: {v927.Message}"
            v935
#endif
            |> fun x -> _v928 <- Some x
            let v936 : string = _v928.Value
            let v937 : (string -> unit) = v861.Push
            v937 v936
            let v938 : System.Threading.Tasks.TaskCanceledException = v927 |> unbox<System.Threading.Tasks.TaskCanceledException>
            let v939 : US0 = US0_3
            let v940 : (unit -> string) = closure55(v938)
            let v941 : (unit -> string) = method47()
            method3(v939, v940, v941)
            return -2147483648 
            (*
            *)
            }
            |> fun x -> _v914 <- Some x
            let v942 : Async<int32> = _v914 |> Option.get
            v942
#endif
            |> fun x -> _v907 <- Some x
            let v943 : Async<int32> = _v907.Value
            let! v943 = v943 
            let v944 : int32 = v943 
            let v945 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v946 : string seq = v945 v861
            let v947 : string = method71()
            let v948 : (string -> (string seq -> string)) = String.concat
            let v949 : (string seq -> string) = v948 v947
            let v950 : string = v949 v946
            let v951 : US0 = US0_1
            let v952 : (unit -> string) = closure56(v944, v950)
            let v953 : (unit -> string) = method47()
            method3(v951, v952, v953)
            return struct (v944, v950) 
            }
            |> fun x -> _v819 <- Some x
            let v954 : Async<struct (int32 * string)> = _v819 |> Option.get
            v954
#endif
            |> fun x -> _v812 <- Some x
            let v955 : Async<struct (int32 * string)> = _v812.Value
            v955
#endif
            |> fun x -> _v805 <- Some x
            let v956 : Async<struct (int32 * string)> = _v805.Value
            let v957 : struct (int32 * string) option = None
            let v958 : bool = true in let mutable _v957 = v957
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v959 : int32, v960 : string) = null |> unbox<struct (int32 * string)>
            struct (v959, v960)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v961 : int32, v962 : string) = null |> unbox<struct (int32 * string)>
            struct (v961, v962)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v963 : int32, v964 : string) = null |> unbox<struct (int32 * string)>
            struct (v963, v964)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v965 : int32, v966 : string) = null |> unbox<struct (int32 * string)>
            struct (v965, v966)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v967 : int32, v968 : string) = null |> unbox<struct (int32 * string)>
            struct (v967, v968)
#endif
            
#else
            let v969 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
            let struct (v970 : int32, v971 : string) = v969 v956
            struct (v970, v971)
#endif
            |> fun x -> _v957 <- Some x
            let struct (v972 : int32, v973 : string) = _v957.Value
            struct (v972, v973)
#endif
            |> fun x -> _v761 <- Some x
            let struct (v974 : int32, v975 : string) = _v761.Value
            let v976 : bool = v974 = 0
            let v979 : US20 =
                if v976 then
                    US20_0(v975)
                else
                    US20_1(v975)
            let v985 : string =
                match v979 with
                | US20_1(v981) -> (* Error *)
                    let v982 : string = $"resultm.get / Result value was Error: {v981}"
                    failwith<string> v982
                | US20_0(v980) -> (* Ok *)
                    v980
            let v986 : bool option = None
            let v987 : bool = true in let mutable _v986 = v986
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v988 : string = method14(v730)
            let v989 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v990 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v988 v989
            let v991 : string = "String::from($0)"
            let v992 : std_string_String = Fable.Core.RustInterop.emitRustExpr v990 v991
            let v993 : string = "std::path::PathBuf::from($0)"
            let v994 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v992 v993
            let v995 : string = "$0.exists()"
            let v996 : bool = Fable.Core.RustInterop.emitRustExpr v994 v995
            let v999 : bool =
                if v996 then
                    let v997 : string = "$0.is_file()"
                    let v998 : bool = Fable.Core.RustInterop.emitRustExpr v994 v997
                    v998
                else
                    false
            v999
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1000 : bool = null |> unbox<bool>
            v1000
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1001 : bool = null |> unbox<bool>
            v1001
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1002 : string = "fs"
            let v1003 : IFsExistsSync = Fable.Core.JsInterop.importAll v1002
            let v1004 : string = "$0.existsSync($1)"
            let v1005 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1003, v730) v1004
            v1005
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1006 : bool = null |> unbox<bool>
            v1006
#endif
            
#else
            let v1007 : (string -> bool) = System.IO.File.Exists
            let v1008 : bool = v1007 v730
            v1008
#endif
            |> fun x -> _v986 <- Some x
            let v1009 : bool = _v986.Value
            let v1261 : US4 =
                if v1009 then
                    let v1010 : string option = None
                    let v1011 : bool = true in let mutable _v1010 = v1010
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1012 : string = method22()
                    let v1013 : string = method23(v730)
                    let v1014 : string = method24()
                    let v1015 : string = $"regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v1016 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1012, v1013, v1014) v1015
                    let v1017 : string = "String::from($0)"
                    let v1018 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1016 v1017
                    let v1019 : string = "fable_library_rust::String_::fromString($0)"
                    let v1020 : string = Fable.Core.RustInterop.emitRustExpr v1018 v1019
                    v1020
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1021 : string = null |> unbox<string>
                    v1021
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1022 : string = null |> unbox<string>
                    v1022
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1023 : string = null |> unbox<string>
                    v1023
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1024 : string = null |> unbox<string>
                    v1024
#endif
                    
#else
                    let v1025 : string = System.Text.RegularExpressions.Regex.Replace (v730, v221, v200)
                    v1025
#endif
                    |> fun x -> _v1010 <- Some x
                    let v1026 : string = _v1010.Value
                    let v1027 : string = $"{v1026.[0] |> string |> _.ToLower()}{v1026.[1..]}"
                    let v1028 : string = v1027.Replace (v202, v203)
                    let v1029 : string option = None
                    let v1030 : System.Threading.CancellationToken option = None
                    let v1031 : (struct (string * string) []) = [||]
                    let v1032 : (struct (bool * string * int32) -> Async<unit>) option = None
                    let v1033 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                    let v1034 : string = $"pwsh -c \"(Get-FileHash \\\"{v1028}\\\" -Algorithm SHA256).Hash\""
                    let v1035 : struct (int32 * string) option = None
                    let v1036 : bool = true in let mutable _v1035 = v1035
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1037 : string = method38(v1030, v1034, v1031, v1032, v1033, v1029)
                    let struct (v1038 : string, v1039 : string) = method39()
                    let v1040 : int32 = v1037.Length
                    let v1041 : (char []) = Array.zeroCreate<char> (v1040)
                    let v1042 : Mut5 = {l0 = 0} : Mut5
                    while method26(v1040, v1042) do
                        let v1044 : int32 = v1042.l0
                        let v1045 : char = v1037.[int v1044]
                        v1041.[int v1044] <- v1045
                        let v1046 : int32 = v1044 + 1
                        v1042.l0 <- v1046
                        ()
                    let v1047 : ((char []) -> char list) = Array.toList
                    let v1048 : char list = v1047 v1041
                    let v1049 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                    let v1050 : (char -> (UH0 -> UH0)) = method40()
                    let v1051 : (char list -> (UH0 -> UH0)) = v1049 v1050
                    let v1052 : (UH0 -> UH0) = v1051 v1048
                    let v1053 : UH0 = UH0_0
                    let v1054 : UH0 = v1052 v1053
                    let v1055 : US8 = US8_0
                    let struct (v1056 : string, v1057 : string) = method41(v1039, v1038, v1054, v1055)
                    let v1058 : (string []) = method42(v1057)
                    let v1059 : string = "$0.to_vec()"
                    let v1060 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v1058 v1059
                    let v1061 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                    let v1062 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1060, v280) v1061
                    let v1063 : US0 = US0_1
                    let v1064 : (unit -> string) = closure29(v1030, v1034, v1031, v1032, v1033, v1029, v1056, v1062)
                    let v1065 : (unit -> string) = method47()
                    method3(v1063, v1064, v1065)
                    let v1066 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v1030, v1034, v1031, v1032, v1033, v1029, v1056, v1062)
                    let v1067 : string = "futures_lite::future::block_on($0)"
                    let v1068 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v1066 v1067
                    let (a, b) = v1068
                    let v1069 : int32 = a
                    let v1070 : string = b
                    struct (v1069, v1070)
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let struct (v1071 : int32, v1072 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1071, v1072)
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let struct (v1073 : int32, v1074 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1073, v1074)
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let struct (v1075 : int32, v1076 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1075, v1076)
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let struct (v1077 : int32, v1078 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1077, v1078)
#endif
                    
#else
                    let v1079 : Async<struct (int32 * string)> option = None
                    let v1080 : bool = true in let mutable _v1079 = v1079
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1081 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1081
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1082 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1082
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1083 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1083
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1084 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1084
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1085 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1085
#endif
                    
#else
                    let v1086 : Async<struct (int32 * string)> option = None
                    let v1087 : bool = true in let mutable _v1086 = v1086
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1088 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1088
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1089 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1089
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1090 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1090
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1091 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1091
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1092 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1092
#endif
                    
#else
                    let v1093 : Async<struct (int32 * string)> option = None
                    let mutable _v1093 = v1093
                    async {
                    let struct (v1094 : string, v1095 : string) = method39()
                    let v1096 : int32 = v1034.Length
                    let v1097 : (char []) = Array.zeroCreate<char> (v1096)
                    let v1098 : Mut5 = {l0 = 0} : Mut5
                    while method26(v1096, v1098) do
                        let v1100 : int32 = v1098.l0
                        let v1101 : char = v1034.[int v1100]
                        v1097.[int v1100] <- v1101
                        let v1102 : int32 = v1100 + 1
                        v1098.l0 <- v1102
                        ()
                    let v1103 : ((char []) -> char list) = Array.toList
                    let v1104 : char list = v1103 v1097
                    let v1105 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                    let v1106 : (char -> (UH0 -> UH0)) = method40()
                    let v1107 : (char list -> (UH0 -> UH0)) = v1105 v1106
                    let v1108 : (UH0 -> UH0) = v1107 v1104
                    let v1109 : UH0 = UH0_0
                    let v1110 : UH0 = v1108 v1109
                    let v1111 : US8 = US8_0
                    let struct (v1112 : string, v1113 : string) = method41(v1095, v1094, v1110, v1111)
                    let v1114 : (string -> US4) = method19()
                    let v1115 : US4 = US4_1
                    let v1116 : US4 = v1029 |> Option.map v1114 |> Option.defaultValue v1115 
                    let v1119 : string =
                        match v1116 with
                        | US4_1 -> (* None *)
                            v200
                        | US4_0(v1117) -> (* Some *)
                            v1117
                    let v1120 : US0 = US0_1
                    let v1121 : (unit -> string) = closure48(v1030, v1034, v1031, v1032, v1033, v1029)
                    let v1122 : (unit -> string) = method47()
                    method3(v1120, v1121, v1122)
                    let v1123 : System.Text.Encoding = System.Text.Encoding.UTF8
                    let v1124 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v1113, StandardOutputEncoding = v1123, WorkingDirectory = v1119, FileName = v1112, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                    let v1125 : int32 = v1031.Length
                    let v1126 : Mut5 = {l0 = 0} : Mut5
                    while method26(v1125, v1126) do
                        let v1128 : int32 = v1126.l0
                        let struct (v1129 : string, v1130 : string) = v1031.[int v1128]
                        v1124.EnvironmentVariables.[v1129] <- v1130 
                        let v1131 : int32 = v1128 + 1
                        v1126.l0 <- v1131
                        ()
                    let v1132 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1124)
                    use v1132 = v1132 
                    let v1133 : System.Diagnostics.Process = v1132 
                    let v1134 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                    let v1135 : System.Collections.Concurrent.ConcurrentStack<string> = v1134 ()
                    let v1136 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v1030, v1034, v1031, v1032, v1033, v1029, v1133, v1135)
                    v1133.OutputDataReceived.Add v1136 
                    let v1137 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v1030, v1034, v1031, v1032, v1033, v1029, v1133, v1135)
                    v1133.ErrorDataReceived.Add v1137 
                    let v1138 : (unit -> bool) = v1133.Start
                    let v1139 : bool = v1138 ()
                    let v1140 : bool = v1139 = false
                    if v1140 then
                        let v1141 : string = $"execute_with_options_async / process_start error"
                        failwith<unit> v1141
                    let v1142 : (unit -> unit) = v1133.BeginErrorReadLine
                    v1142 ()
                    let v1143 : (unit -> unit) = v1133.BeginOutputReadLine
                    v1143 ()
                    let v1144 : (System.Threading.CancellationToken -> US18) = method70()
                    let v1145 : US18 = US18_1
                    let v1146 : US18 = v1030 |> Option.map v1144 |> Option.defaultValue v1145 
                    let v1150 : System.Threading.CancellationToken =
                        match v1146 with
                        | US18_1 -> (* None *)
                            let v1148 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                            v1148
                        | US18_0(v1147) -> (* Some *)
                            v1147
                    let v1151 : Async<System.Threading.CancellationToken> option = None
                    let v1152 : bool = true in let mutable _v1151 = v1151
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1153 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1153
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1154 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1154
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1155 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1155
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1156 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1156
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1157 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1157
#endif
                    
#else
                    let v1158 : Async<System.Threading.CancellationToken> option = None
                    let v1159 : bool = true in let mutable _v1158 = v1158
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1160 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1160
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1161 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1161
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1162 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1162
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1163 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1163
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1164 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1164
#endif
                    
#else
                    let v1165 : Async<System.Threading.CancellationToken> option = None
                    let mutable _v1165 = v1165
                    async {
                    let v1166 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v1166 = v1166 
                    let v1167 : System.Threading.CancellationToken = v1166 
                    let v1168 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v1169 : (System.Threading.CancellationToken []) = [|v1167; v1168; v1150|]
                    let v1170 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v1171 : System.Threading.CancellationTokenSource = v1170 v1169
                    let v1172 : System.Threading.CancellationToken = v1171.Token
                    return v1172 
                    }
                    |> fun x -> _v1165 <- Some x
                    let v1173 : Async<System.Threading.CancellationToken> = _v1165 |> Option.get
                    v1173
#endif
                    |> fun x -> _v1158 <- Some x
                    let v1174 : Async<System.Threading.CancellationToken> = _v1158.Value
                    v1174
#endif
                    |> fun x -> _v1151 <- Some x
                    let v1175 : Async<System.Threading.CancellationToken> = _v1151.Value
                    let! v1175 = v1175 
                    let v1176 : System.Threading.CancellationToken = v1175 
                    let v1177 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1176.Register
                    let v1178 : (unit -> unit) = closure54(v1133)
                    let v1179 : System.Threading.CancellationTokenRegistration = v1177 v1178
                    use v1179 = v1179 
                    let v1180 : System.Threading.CancellationTokenRegistration = v1179 
                    let v1181 : Async<int32> option = None
                    let v1182 : bool = true in let mutable _v1181 = v1181
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1183 : Async<int32> = null |> unbox<Async<int32>>
                    v1183
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1184 : Async<int32> = null |> unbox<Async<int32>>
                    v1184
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1185 : Async<int32> = null |> unbox<Async<int32>>
                    v1185
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1186 : Async<int32> = null |> unbox<Async<int32>>
                    v1186
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1187 : Async<int32> = null |> unbox<Async<int32>>
                    v1187
#endif
                    
#else
                    let v1188 : Async<int32> option = None
                    let mutable _v1188 = v1188
                    async {
                    try
                    let v1189 : System.Threading.Tasks.Task = v1133.WaitForExitAsync v1176 
                    let v1190 : Async<unit> option = None
                    let v1191 : bool = true in let mutable _v1190 = v1190
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1192 : Async<unit> = null |> unbox<Async<unit>>
                    v1192
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1193 : Async<unit> = null |> unbox<Async<unit>>
                    v1193
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1194 : Async<unit> = null |> unbox<Async<unit>>
                    v1194
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1195 : Async<unit> = null |> unbox<Async<unit>>
                    v1195
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1196 : Async<unit> = null |> unbox<Async<unit>>
                    v1196
#endif
                    
#else
                    let v1197 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1198 : Async<unit> = v1197 v1189
                    v1198
#endif
                    |> fun x -> _v1190 <- Some x
                    let v1199 : Async<unit> = _v1190.Value
                    do! v1199 
                    let v1200 : int32 = v1133.ExitCode
                    return v1200 
                    with ex ->
                    let v1201 : exn = ex
                    let v1202 : string option = None
                    let v1203 : bool = true in let mutable _v1202 = v1202
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1204 : string = $"%A{v1201}"
                    v1204
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1205 : string = $"%A{v1201}"
                    v1205
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1206 : string = $"%A{v1201}"
                    v1206
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1207 : string = $"%A{v1201}"
                    v1207
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1208 : string = $"%A{v1201}"
                    v1208
#endif
                    
#else
                    let v1209 : string = $"{v1201.GetType ()}: {v1201.Message}"
                    v1209
#endif
                    |> fun x -> _v1202 <- Some x
                    let v1210 : string = _v1202.Value
                    let v1211 : (string -> unit) = v1135.Push
                    v1211 v1210
                    let v1212 : System.Threading.Tasks.TaskCanceledException = v1201 |> unbox<System.Threading.Tasks.TaskCanceledException>
                    let v1213 : US0 = US0_3
                    let v1214 : (unit -> string) = closure55(v1212)
                    let v1215 : (unit -> string) = method47()
                    method3(v1213, v1214, v1215)
                    return -2147483648 
                    (*
                    *)
                    }
                    |> fun x -> _v1188 <- Some x
                    let v1216 : Async<int32> = _v1188 |> Option.get
                    v1216
#endif
                    |> fun x -> _v1181 <- Some x
                    let v1217 : Async<int32> = _v1181.Value
                    let! v1217 = v1217 
                    let v1218 : int32 = v1217 
                    let v1219 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                    let v1220 : string seq = v1219 v1135
                    let v1221 : string = method71()
                    let v1222 : (string -> (string seq -> string)) = String.concat
                    let v1223 : (string seq -> string) = v1222 v1221
                    let v1224 : string = v1223 v1220
                    let v1225 : US0 = US0_1
                    let v1226 : (unit -> string) = closure56(v1218, v1224)
                    let v1227 : (unit -> string) = method47()
                    method3(v1225, v1226, v1227)
                    return struct (v1218, v1224) 
                    }
                    |> fun x -> _v1093 <- Some x
                    let v1228 : Async<struct (int32 * string)> = _v1093 |> Option.get
                    v1228
#endif
                    |> fun x -> _v1086 <- Some x
                    let v1229 : Async<struct (int32 * string)> = _v1086.Value
                    v1229
#endif
                    |> fun x -> _v1079 <- Some x
                    let v1230 : Async<struct (int32 * string)> = _v1079.Value
                    let v1231 : struct (int32 * string) option = None
                    let v1232 : bool = true in let mutable _v1231 = v1231
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let struct (v1233 : int32, v1234 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1233, v1234)
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let struct (v1235 : int32, v1236 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1235, v1236)
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let struct (v1237 : int32, v1238 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1237, v1238)
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let struct (v1239 : int32, v1240 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1239, v1240)
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let struct (v1241 : int32, v1242 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1241, v1242)
#endif
                    
#else
                    let v1243 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                    let struct (v1244 : int32, v1245 : string) = v1243 v1230
                    struct (v1244, v1245)
#endif
                    |> fun x -> _v1231 <- Some x
                    let struct (v1246 : int32, v1247 : string) = _v1231.Value
                    struct (v1246, v1247)
#endif
                    |> fun x -> _v1035 <- Some x
                    let struct (v1248 : int32, v1249 : string) = _v1035.Value
                    let v1250 : bool = v1248 = 0
                    let v1253 : US20 =
                        if v1250 then
                            US20_0(v1249)
                        else
                            US20_1(v1249)
                    match v1253 with
                    | US20_1(v1256) -> (* Error *)
                        US4_1
                    | US20_0(v1254) -> (* Ok *)
                        US4_0(v1254)
                else
                    US4_1
            let v1263 : bool =
                match v1261 with
                | US4_1 -> (* None *)
                    true
                | _ ->
                    false
            let v1269 : bool =
                if v1263 then
                    true
                else
                    let v1267 : string =
                        match v1261 with
                        | US4_1 -> (* None *)
                            failwith<string> "Option does not have a value."
                        | US4_0(v1264) -> (* Some *)
                            v1264
                    let v1268 : bool = v985 <> v1267
                    v1268
            if v1269 then
                let v1270 : US0 = US0_2
                let v1271 : (unit -> string) = closure57()
                let v1272 : (unit -> string) = closure58(v205, v225, v245, v468, v467, v488, v710, v709, v730, v985, v1261)
                method3(v1270, v1271, v1272)
                let v1273 : unit option = None
                let v1274 : bool = true in let mutable _v1273 = v1273
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1275 : string = method73(v730)
                let v1276 : string = "std::fs::copy(&*$0, &*v1275)"
                let v1277 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v488 v1276
                let v1278 : string = "$0.unwrap()"
                let v1279 : uint64 = Fable.Core.RustInterop.emitRustExpr v1277 v1278
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
                System.IO.File.Copy (v488, v730, true)
                ()
#endif
                |> fun x -> _v1273 <- Some x
                _v1273.Value
                let v1280 : (string -> (string -> US19)) = closure59(v4, v3, v1, v0)
                let v1281 : UH3 = UH3_0
                let v1282 : UH3 = UH3_1(v731, v488, v1280, v1281)
                let v1283 : string = "html"
                let v1284 : (string -> (string -> US19)) = closure66(v4, v3)
                let v1285 : string = "pdf"
                let v1286 : string = "epub"
                let v1287 : UH3 = UH3_0
                let v1288 : UH3 = UH3_1(v1286, v733, v1284, v1287)
                let v1289 : UH3 = UH3_1(v1285, v733, v1284, v1288)
                let v1290 : UH3 = UH3_1(v1283, v733, v1284, v1289)
                let v1291 : UH3 = UH3_1(v1286, v488, v1284, v1290)
                let v1292 : UH3 = UH3_1(v1285, v488, v1284, v1291)
                let v1293 : UH3 = UH3_1(v1283, v488, v1284, v1292)
                let v1294 : UH2 = UH2_0
                let v1295 : UH2 = UH2_1(v1293, v1294)
                UH2_1(v1282, v1295)
            else
                UH2_0
        else
            UH2_0
    let v1302 : bool =
        match v1300 with
        | UH2_0 -> (* Nil *)
            true
        | _ ->
            false
    let v1303 : bool = v1302 <> true
    let v1763 : UH2 =
        if v1303 then
            v1300
        else
            let v1304 : string = "epub"
            let struct (v1305 : string, v1306 : string) = method72(v1304, v733, v4)
            let v1307 : bool option = None
            let v1308 : bool = true in let mutable _v1307 = v1307
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1309 : string = method14(v1306)
            let v1310 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1311 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1309 v1310
            let v1312 : string = "String::from($0)"
            let v1313 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1311 v1312
            let v1314 : string = "std::path::PathBuf::from($0)"
            let v1315 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1313 v1314
            let v1316 : string = "$0.exists()"
            let v1317 : bool = Fable.Core.RustInterop.emitRustExpr v1315 v1316
            let v1320 : bool =
                if v1317 then
                    let v1318 : string = "$0.is_file()"
                    let v1319 : bool = Fable.Core.RustInterop.emitRustExpr v1315 v1318
                    v1319
                else
                    false
            v1320
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1321 : bool = null |> unbox<bool>
            v1321
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1322 : bool = null |> unbox<bool>
            v1322
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1323 : string = "fs"
            let v1324 : IFsExistsSync = Fable.Core.JsInterop.importAll v1323
            let v1325 : string = "$0.existsSync($1)"
            let v1326 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1324, v1306) v1325
            v1326
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1327 : bool = null |> unbox<bool>
            v1327
#endif
            
#else
            let v1328 : (string -> bool) = System.IO.File.Exists
            let v1329 : bool = v1328 v1306
            v1329
#endif
            |> fun x -> _v1307 <- Some x
            let v1330 : bool = _v1307.Value
            let v1331 : bool = v1330 = false
            let v1366 : bool =
                if v1331 then
                    let v1332 : bool option = None
                    let v1333 : bool = true in let mutable _v1332 = v1332
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1334 : string = method14(v1305)
                    let v1335 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v1336 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1334 v1335
                    let v1337 : string = "String::from($0)"
                    let v1338 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1336 v1337
                    let v1339 : string = "std::path::PathBuf::from($0)"
                    let v1340 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1338 v1339
                    let v1341 : string = "$0.exists()"
                    let v1342 : bool = Fable.Core.RustInterop.emitRustExpr v1340 v1341
                    let v1345 : bool =
                        if v1342 then
                            let v1343 : string = "$0.is_file()"
                            let v1344 : bool = Fable.Core.RustInterop.emitRustExpr v1340 v1343
                            v1344
                        else
                            false
                    v1345
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1346 : bool = null |> unbox<bool>
                    v1346
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1347 : bool = null |> unbox<bool>
                    v1347
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1348 : IFsExistsSync = Fable.Core.JsInterop.importAll v1323
                    let v1349 : string = "$0.existsSync($1)"
                    let v1350 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1348, v1305) v1349
                    v1350
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1351 : bool = null |> unbox<bool>
                    v1351
#endif
                    
#else
                    let v1352 : (string -> bool) = System.IO.File.Exists
                    let v1353 : bool = v1352 v1305
                    v1353
#endif
                    |> fun x -> _v1332 <- Some x
                    let v1354 : bool = _v1332.Value
                    if v1354 then
                        let v1355 : US0 = US0_2
                        let v1356 : (unit -> string) = closure70()
                        let v1357 : (unit -> string) = closure71(v1305, v1306)
                        method3(v1355, v1356, v1357)
                        let v1358 : unit option = None
                        let v1359 : bool = true in let mutable _v1358 = v1358
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1360 : string = method73(v1306)
                        let v1361 : string = "std::fs::copy(&*$0, &*v1360)"
                        let v1362 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1305 v1361
                        let v1363 : string = "$0.unwrap()"
                        let v1364 : uint64 = Fable.Core.RustInterop.emitRustExpr v1362 v1363
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
                        System.IO.File.Copy (v1305, v1306, true)
                        ()
#endif
                        |> fun x -> _v1358 <- Some x
                        _v1358.Value
                        false
                    else
                        true
                else
                    true
            let v1371 : UH3 =
                if v1366 then
                    let v1367 : (string -> (string -> US19)) = closure66(v4, v3)
                    let v1368 : UH3 = UH3_0
                    UH3_1(v1304, v733, v1367, v1368)
                else
                    UH3_0
            let v1372 : string = "pdf"
            let struct (v1373 : string, v1374 : string) = method72(v1372, v733, v4)
            let v1375 : bool option = None
            let v1376 : bool = true in let mutable _v1375 = v1375
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1377 : string = method14(v1374)
            let v1378 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1379 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1377 v1378
            let v1380 : string = "String::from($0)"
            let v1381 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1379 v1380
            let v1382 : string = "std::path::PathBuf::from($0)"
            let v1383 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1381 v1382
            let v1384 : string = "$0.exists()"
            let v1385 : bool = Fable.Core.RustInterop.emitRustExpr v1383 v1384
            let v1388 : bool =
                if v1385 then
                    let v1386 : string = "$0.is_file()"
                    let v1387 : bool = Fable.Core.RustInterop.emitRustExpr v1383 v1386
                    v1387
                else
                    false
            v1388
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1389 : bool = null |> unbox<bool>
            v1389
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1390 : bool = null |> unbox<bool>
            v1390
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1391 : IFsExistsSync = Fable.Core.JsInterop.importAll v1323
            let v1392 : string = "$0.existsSync($1)"
            let v1393 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1391, v1374) v1392
            v1393
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1394 : bool = null |> unbox<bool>
            v1394
#endif
            
#else
            let v1395 : (string -> bool) = System.IO.File.Exists
            let v1396 : bool = v1395 v1374
            v1396
#endif
            |> fun x -> _v1375 <- Some x
            let v1397 : bool = _v1375.Value
            let v1398 : bool = v1397 = false
            let v1433 : bool =
                if v1398 then
                    let v1399 : bool option = None
                    let v1400 : bool = true in let mutable _v1399 = v1399
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1401 : string = method14(v1373)
                    let v1402 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v1403 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1401 v1402
                    let v1404 : string = "String::from($0)"
                    let v1405 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1403 v1404
                    let v1406 : string = "std::path::PathBuf::from($0)"
                    let v1407 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1405 v1406
                    let v1408 : string = "$0.exists()"
                    let v1409 : bool = Fable.Core.RustInterop.emitRustExpr v1407 v1408
                    let v1412 : bool =
                        if v1409 then
                            let v1410 : string = "$0.is_file()"
                            let v1411 : bool = Fable.Core.RustInterop.emitRustExpr v1407 v1410
                            v1411
                        else
                            false
                    v1412
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1413 : bool = null |> unbox<bool>
                    v1413
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1414 : bool = null |> unbox<bool>
                    v1414
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1415 : IFsExistsSync = Fable.Core.JsInterop.importAll v1323
                    let v1416 : string = "$0.existsSync($1)"
                    let v1417 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1415, v1373) v1416
                    v1417
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1418 : bool = null |> unbox<bool>
                    v1418
#endif
                    
#else
                    let v1419 : (string -> bool) = System.IO.File.Exists
                    let v1420 : bool = v1419 v1373
                    v1420
#endif
                    |> fun x -> _v1399 <- Some x
                    let v1421 : bool = _v1399.Value
                    if v1421 then
                        let v1422 : US0 = US0_2
                        let v1423 : (unit -> string) = closure70()
                        let v1424 : (unit -> string) = closure71(v1373, v1374)
                        method3(v1422, v1423, v1424)
                        let v1425 : unit option = None
                        let v1426 : bool = true in let mutable _v1425 = v1425
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1427 : string = method73(v1374)
                        let v1428 : string = "std::fs::copy(&*$0, &*v1427)"
                        let v1429 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1373 v1428
                        let v1430 : string = "$0.unwrap()"
                        let v1431 : uint64 = Fable.Core.RustInterop.emitRustExpr v1429 v1430
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
                        System.IO.File.Copy (v1373, v1374, true)
                        ()
#endif
                        |> fun x -> _v1425 <- Some x
                        _v1425.Value
                        false
                    else
                        true
                else
                    true
            let v1436 : UH3 =
                if v1433 then
                    let v1434 : (string -> (string -> US19)) = closure66(v4, v3)
                    UH3_1(v1372, v733, v1434, v1371)
                else
                    v1371
            let v1437 : string = "html"
            let struct (v1438 : string, v1439 : string) = method72(v1437, v733, v4)
            let v1440 : bool option = None
            let v1441 : bool = true in let mutable _v1440 = v1440
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1442 : string = method14(v1439)
            let v1443 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1444 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1442 v1443
            let v1445 : string = "String::from($0)"
            let v1446 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1444 v1445
            let v1447 : string = "std::path::PathBuf::from($0)"
            let v1448 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1446 v1447
            let v1449 : string = "$0.exists()"
            let v1450 : bool = Fable.Core.RustInterop.emitRustExpr v1448 v1449
            let v1453 : bool =
                if v1450 then
                    let v1451 : string = "$0.is_file()"
                    let v1452 : bool = Fable.Core.RustInterop.emitRustExpr v1448 v1451
                    v1452
                else
                    false
            v1453
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1454 : bool = null |> unbox<bool>
            v1454
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1455 : bool = null |> unbox<bool>
            v1455
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1456 : IFsExistsSync = Fable.Core.JsInterop.importAll v1323
            let v1457 : string = "$0.existsSync($1)"
            let v1458 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1456, v1439) v1457
            v1458
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1459 : bool = null |> unbox<bool>
            v1459
#endif
            
#else
            let v1460 : (string -> bool) = System.IO.File.Exists
            let v1461 : bool = v1460 v1439
            v1461
#endif
            |> fun x -> _v1440 <- Some x
            let v1462 : bool = _v1440.Value
            let v1463 : bool = v1462 = false
            let v1498 : bool =
                if v1463 then
                    let v1464 : bool option = None
                    let v1465 : bool = true in let mutable _v1464 = v1464
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1466 : string = method14(v1438)
                    let v1467 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v1468 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1466 v1467
                    let v1469 : string = "String::from($0)"
                    let v1470 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1468 v1469
                    let v1471 : string = "std::path::PathBuf::from($0)"
                    let v1472 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1470 v1471
                    let v1473 : string = "$0.exists()"
                    let v1474 : bool = Fable.Core.RustInterop.emitRustExpr v1472 v1473
                    let v1477 : bool =
                        if v1474 then
                            let v1475 : string = "$0.is_file()"
                            let v1476 : bool = Fable.Core.RustInterop.emitRustExpr v1472 v1475
                            v1476
                        else
                            false
                    v1477
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1478 : bool = null |> unbox<bool>
                    v1478
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1479 : bool = null |> unbox<bool>
                    v1479
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1480 : IFsExistsSync = Fable.Core.JsInterop.importAll v1323
                    let v1481 : string = "$0.existsSync($1)"
                    let v1482 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1480, v1438) v1481
                    v1482
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1483 : bool = null |> unbox<bool>
                    v1483
#endif
                    
#else
                    let v1484 : (string -> bool) = System.IO.File.Exists
                    let v1485 : bool = v1484 v1438
                    v1485
#endif
                    |> fun x -> _v1464 <- Some x
                    let v1486 : bool = _v1464.Value
                    if v1486 then
                        let v1487 : US0 = US0_2
                        let v1488 : (unit -> string) = closure70()
                        let v1489 : (unit -> string) = closure71(v1438, v1439)
                        method3(v1487, v1488, v1489)
                        let v1490 : unit option = None
                        let v1491 : bool = true in let mutable _v1490 = v1490
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1492 : string = method73(v1439)
                        let v1493 : string = "std::fs::copy(&*$0, &*v1492)"
                        let v1494 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1438 v1493
                        let v1495 : string = "$0.unwrap()"
                        let v1496 : uint64 = Fable.Core.RustInterop.emitRustExpr v1494 v1495
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
                        System.IO.File.Copy (v1438, v1439, true)
                        ()
#endif
                        |> fun x -> _v1490 <- Some x
                        _v1490.Value
                        false
                    else
                        true
                else
                    true
            let v1501 : UH3 =
                if v1498 then
                    let v1499 : (string -> (string -> US19)) = closure66(v4, v3)
                    UH3_1(v1437, v733, v1499, v1436)
                else
                    v1436
            let struct (v1502 : string, v1503 : string) = method72(v1304, v488, v4)
            let v1504 : bool option = None
            let v1505 : bool = true in let mutable _v1504 = v1504
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1506 : string = method14(v1503)
            let v1507 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1508 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1506 v1507
            let v1509 : string = "String::from($0)"
            let v1510 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1508 v1509
            let v1511 : string = "std::path::PathBuf::from($0)"
            let v1512 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1510 v1511
            let v1513 : string = "$0.exists()"
            let v1514 : bool = Fable.Core.RustInterop.emitRustExpr v1512 v1513
            let v1517 : bool =
                if v1514 then
                    let v1515 : string = "$0.is_file()"
                    let v1516 : bool = Fable.Core.RustInterop.emitRustExpr v1512 v1515
                    v1516
                else
                    false
            v1517
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1518 : bool = null |> unbox<bool>
            v1518
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1519 : bool = null |> unbox<bool>
            v1519
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1520 : IFsExistsSync = Fable.Core.JsInterop.importAll v1323
            let v1521 : string = "$0.existsSync($1)"
            let v1522 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1520, v1503) v1521
            v1522
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1523 : bool = null |> unbox<bool>
            v1523
#endif
            
#else
            let v1524 : (string -> bool) = System.IO.File.Exists
            let v1525 : bool = v1524 v1503
            v1525
#endif
            |> fun x -> _v1504 <- Some x
            let v1526 : bool = _v1504.Value
            let v1527 : bool = v1526 = false
            let v1562 : bool =
                if v1527 then
                    let v1528 : bool option = None
                    let v1529 : bool = true in let mutable _v1528 = v1528
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1530 : string = method14(v1502)
                    let v1531 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v1532 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1530 v1531
                    let v1533 : string = "String::from($0)"
                    let v1534 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1532 v1533
                    let v1535 : string = "std::path::PathBuf::from($0)"
                    let v1536 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1534 v1535
                    let v1537 : string = "$0.exists()"
                    let v1538 : bool = Fable.Core.RustInterop.emitRustExpr v1536 v1537
                    let v1541 : bool =
                        if v1538 then
                            let v1539 : string = "$0.is_file()"
                            let v1540 : bool = Fable.Core.RustInterop.emitRustExpr v1536 v1539
                            v1540
                        else
                            false
                    v1541
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1542 : bool = null |> unbox<bool>
                    v1542
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1543 : bool = null |> unbox<bool>
                    v1543
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1544 : IFsExistsSync = Fable.Core.JsInterop.importAll v1323
                    let v1545 : string = "$0.existsSync($1)"
                    let v1546 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1544, v1502) v1545
                    v1546
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1547 : bool = null |> unbox<bool>
                    v1547
#endif
                    
#else
                    let v1548 : (string -> bool) = System.IO.File.Exists
                    let v1549 : bool = v1548 v1502
                    v1549
#endif
                    |> fun x -> _v1528 <- Some x
                    let v1550 : bool = _v1528.Value
                    if v1550 then
                        let v1551 : US0 = US0_2
                        let v1552 : (unit -> string) = closure70()
                        let v1553 : (unit -> string) = closure71(v1502, v1503)
                        method3(v1551, v1552, v1553)
                        let v1554 : unit option = None
                        let v1555 : bool = true in let mutable _v1554 = v1554
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1556 : string = method73(v1503)
                        let v1557 : string = "std::fs::copy(&*$0, &*v1556)"
                        let v1558 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1502 v1557
                        let v1559 : string = "$0.unwrap()"
                        let v1560 : uint64 = Fable.Core.RustInterop.emitRustExpr v1558 v1559
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
                        System.IO.File.Copy (v1502, v1503, true)
                        ()
#endif
                        |> fun x -> _v1554 <- Some x
                        _v1554.Value
                        false
                    else
                        true
                else
                    true
            let v1565 : UH3 =
                if v1562 then
                    let v1563 : (string -> (string -> US19)) = closure66(v4, v3)
                    UH3_1(v1304, v488, v1563, v1501)
                else
                    v1501
            let struct (v1566 : string, v1567 : string) = method72(v1372, v488, v4)
            let v1568 : bool option = None
            let v1569 : bool = true in let mutable _v1568 = v1568
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1570 : string = method14(v1567)
            let v1571 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1572 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1570 v1571
            let v1573 : string = "String::from($0)"
            let v1574 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1572 v1573
            let v1575 : string = "std::path::PathBuf::from($0)"
            let v1576 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1574 v1575
            let v1577 : string = "$0.exists()"
            let v1578 : bool = Fable.Core.RustInterop.emitRustExpr v1576 v1577
            let v1581 : bool =
                if v1578 then
                    let v1579 : string = "$0.is_file()"
                    let v1580 : bool = Fable.Core.RustInterop.emitRustExpr v1576 v1579
                    v1580
                else
                    false
            v1581
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1582 : bool = null |> unbox<bool>
            v1582
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1583 : bool = null |> unbox<bool>
            v1583
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1584 : IFsExistsSync = Fable.Core.JsInterop.importAll v1323
            let v1585 : string = "$0.existsSync($1)"
            let v1586 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1584, v1567) v1585
            v1586
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1587 : bool = null |> unbox<bool>
            v1587
#endif
            
#else
            let v1588 : (string -> bool) = System.IO.File.Exists
            let v1589 : bool = v1588 v1567
            v1589
#endif
            |> fun x -> _v1568 <- Some x
            let v1590 : bool = _v1568.Value
            let v1591 : bool = v1590 = false
            let v1626 : bool =
                if v1591 then
                    let v1592 : bool option = None
                    let v1593 : bool = true in let mutable _v1592 = v1592
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1594 : string = method14(v1566)
                    let v1595 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v1596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1594 v1595
                    let v1597 : string = "String::from($0)"
                    let v1598 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1596 v1597
                    let v1599 : string = "std::path::PathBuf::from($0)"
                    let v1600 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1598 v1599
                    let v1601 : string = "$0.exists()"
                    let v1602 : bool = Fable.Core.RustInterop.emitRustExpr v1600 v1601
                    let v1605 : bool =
                        if v1602 then
                            let v1603 : string = "$0.is_file()"
                            let v1604 : bool = Fable.Core.RustInterop.emitRustExpr v1600 v1603
                            v1604
                        else
                            false
                    v1605
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1606 : bool = null |> unbox<bool>
                    v1606
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1607 : bool = null |> unbox<bool>
                    v1607
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1608 : IFsExistsSync = Fable.Core.JsInterop.importAll v1323
                    let v1609 : string = "$0.existsSync($1)"
                    let v1610 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1608, v1566) v1609
                    v1610
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1611 : bool = null |> unbox<bool>
                    v1611
#endif
                    
#else
                    let v1612 : (string -> bool) = System.IO.File.Exists
                    let v1613 : bool = v1612 v1566
                    v1613
#endif
                    |> fun x -> _v1592 <- Some x
                    let v1614 : bool = _v1592.Value
                    if v1614 then
                        let v1615 : US0 = US0_2
                        let v1616 : (unit -> string) = closure70()
                        let v1617 : (unit -> string) = closure71(v1566, v1567)
                        method3(v1615, v1616, v1617)
                        let v1618 : unit option = None
                        let v1619 : bool = true in let mutable _v1618 = v1618
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1620 : string = method73(v1567)
                        let v1621 : string = "std::fs::copy(&*$0, &*v1620)"
                        let v1622 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1566 v1621
                        let v1623 : string = "$0.unwrap()"
                        let v1624 : uint64 = Fable.Core.RustInterop.emitRustExpr v1622 v1623
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
                        System.IO.File.Copy (v1566, v1567, true)
                        ()
#endif
                        |> fun x -> _v1618 <- Some x
                        _v1618.Value
                        false
                    else
                        true
                else
                    true
            let v1629 : UH3 =
                if v1626 then
                    let v1627 : (string -> (string -> US19)) = closure66(v4, v3)
                    UH3_1(v1372, v488, v1627, v1565)
                else
                    v1565
            let struct (v1630 : string, v1631 : string) = method72(v1437, v488, v4)
            let v1632 : bool option = None
            let v1633 : bool = true in let mutable _v1632 = v1632
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1634 : string = method14(v1631)
            let v1635 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1636 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1634 v1635
            let v1637 : string = "String::from($0)"
            let v1638 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1636 v1637
            let v1639 : string = "std::path::PathBuf::from($0)"
            let v1640 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1638 v1639
            let v1641 : string = "$0.exists()"
            let v1642 : bool = Fable.Core.RustInterop.emitRustExpr v1640 v1641
            let v1645 : bool =
                if v1642 then
                    let v1643 : string = "$0.is_file()"
                    let v1644 : bool = Fable.Core.RustInterop.emitRustExpr v1640 v1643
                    v1644
                else
                    false
            v1645
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1646 : bool = null |> unbox<bool>
            v1646
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1647 : bool = null |> unbox<bool>
            v1647
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1648 : IFsExistsSync = Fable.Core.JsInterop.importAll v1323
            let v1649 : string = "$0.existsSync($1)"
            let v1650 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1648, v1631) v1649
            v1650
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1651 : bool = null |> unbox<bool>
            v1651
#endif
            
#else
            let v1652 : (string -> bool) = System.IO.File.Exists
            let v1653 : bool = v1652 v1631
            v1653
#endif
            |> fun x -> _v1632 <- Some x
            let v1654 : bool = _v1632.Value
            let v1655 : bool = v1654 = false
            let v1690 : bool =
                if v1655 then
                    let v1656 : bool option = None
                    let v1657 : bool = true in let mutable _v1656 = v1656
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1658 : string = method14(v1630)
                    let v1659 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v1660 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1658 v1659
                    let v1661 : string = "String::from($0)"
                    let v1662 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1660 v1661
                    let v1663 : string = "std::path::PathBuf::from($0)"
                    let v1664 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1662 v1663
                    let v1665 : string = "$0.exists()"
                    let v1666 : bool = Fable.Core.RustInterop.emitRustExpr v1664 v1665
                    let v1669 : bool =
                        if v1666 then
                            let v1667 : string = "$0.is_file()"
                            let v1668 : bool = Fable.Core.RustInterop.emitRustExpr v1664 v1667
                            v1668
                        else
                            false
                    v1669
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1670 : bool = null |> unbox<bool>
                    v1670
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1671 : bool = null |> unbox<bool>
                    v1671
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1672 : IFsExistsSync = Fable.Core.JsInterop.importAll v1323
                    let v1673 : string = "$0.existsSync($1)"
                    let v1674 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1672, v1630) v1673
                    v1674
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1675 : bool = null |> unbox<bool>
                    v1675
#endif
                    
#else
                    let v1676 : (string -> bool) = System.IO.File.Exists
                    let v1677 : bool = v1676 v1630
                    v1677
#endif
                    |> fun x -> _v1656 <- Some x
                    let v1678 : bool = _v1656.Value
                    if v1678 then
                        let v1679 : US0 = US0_2
                        let v1680 : (unit -> string) = closure70()
                        let v1681 : (unit -> string) = closure71(v1630, v1631)
                        method3(v1679, v1680, v1681)
                        let v1682 : unit option = None
                        let v1683 : bool = true in let mutable _v1682 = v1682
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1684 : string = method73(v1631)
                        let v1685 : string = "std::fs::copy(&*$0, &*v1684)"
                        let v1686 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1630 v1685
                        let v1687 : string = "$0.unwrap()"
                        let v1688 : uint64 = Fable.Core.RustInterop.emitRustExpr v1686 v1687
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
                        System.IO.File.Copy (v1630, v1631, true)
                        ()
#endif
                        |> fun x -> _v1682 <- Some x
                        _v1682.Value
                        false
                    else
                        true
                else
                    true
            let v1693 : UH3 =
                if v1690 then
                    let v1691 : (string -> (string -> US19)) = closure66(v4, v3)
                    UH3_1(v1437, v488, v1691, v1629)
                else
                    v1629
            let struct (v1694 : string, v1695 : string) = method72(v731, v488, v4)
            let v1696 : bool option = None
            let v1697 : bool = true in let mutable _v1696 = v1696
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1698 : string = method14(v1695)
            let v1699 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1700 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1698 v1699
            let v1701 : string = "String::from($0)"
            let v1702 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1700 v1701
            let v1703 : string = "std::path::PathBuf::from($0)"
            let v1704 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1702 v1703
            let v1705 : string = "$0.exists()"
            let v1706 : bool = Fable.Core.RustInterop.emitRustExpr v1704 v1705
            let v1709 : bool =
                if v1706 then
                    let v1707 : string = "$0.is_file()"
                    let v1708 : bool = Fable.Core.RustInterop.emitRustExpr v1704 v1707
                    v1708
                else
                    false
            v1709
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1710 : bool = null |> unbox<bool>
            v1710
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1711 : bool = null |> unbox<bool>
            v1711
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1712 : IFsExistsSync = Fable.Core.JsInterop.importAll v1323
            let v1713 : string = "$0.existsSync($1)"
            let v1714 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1712, v1695) v1713
            v1714
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1715 : bool = null |> unbox<bool>
            v1715
#endif
            
#else
            let v1716 : (string -> bool) = System.IO.File.Exists
            let v1717 : bool = v1716 v1695
            v1717
#endif
            |> fun x -> _v1696 <- Some x
            let v1718 : bool = _v1696.Value
            let v1719 : bool = v1718 = false
            let v1754 : bool =
                if v1719 then
                    let v1720 : bool option = None
                    let v1721 : bool = true in let mutable _v1720 = v1720
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1722 : string = method14(v1694)
                    let v1723 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v1724 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1722 v1723
                    let v1725 : string = "String::from($0)"
                    let v1726 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1724 v1725
                    let v1727 : string = "std::path::PathBuf::from($0)"
                    let v1728 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1726 v1727
                    let v1729 : string = "$0.exists()"
                    let v1730 : bool = Fable.Core.RustInterop.emitRustExpr v1728 v1729
                    let v1733 : bool =
                        if v1730 then
                            let v1731 : string = "$0.is_file()"
                            let v1732 : bool = Fable.Core.RustInterop.emitRustExpr v1728 v1731
                            v1732
                        else
                            false
                    v1733
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1734 : bool = null |> unbox<bool>
                    v1734
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1735 : bool = null |> unbox<bool>
                    v1735
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1736 : IFsExistsSync = Fable.Core.JsInterop.importAll v1323
                    let v1737 : string = "$0.existsSync($1)"
                    let v1738 : bool = Fable.Core.JsInterop.emitJsExpr struct (v1736, v1694) v1737
                    v1738
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1739 : bool = null |> unbox<bool>
                    v1739
#endif
                    
#else
                    let v1740 : (string -> bool) = System.IO.File.Exists
                    let v1741 : bool = v1740 v1694
                    v1741
#endif
                    |> fun x -> _v1720 <- Some x
                    let v1742 : bool = _v1720.Value
                    if v1742 then
                        let v1743 : US0 = US0_2
                        let v1744 : (unit -> string) = closure70()
                        let v1745 : (unit -> string) = closure71(v1694, v1695)
                        method3(v1743, v1744, v1745)
                        let v1746 : unit option = None
                        let v1747 : bool = true in let mutable _v1746 = v1746
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1748 : string = method73(v1695)
                        let v1749 : string = "std::fs::copy(&*$0, &*v1748)"
                        let v1750 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1694 v1749
                        let v1751 : string = "$0.unwrap()"
                        let v1752 : uint64 = Fable.Core.RustInterop.emitRustExpr v1750 v1751
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
                        System.IO.File.Copy (v1694, v1695, true)
                        ()
#endif
                        |> fun x -> _v1746 <- Some x
                        _v1746.Value
                        false
                    else
                        true
                else
                    true
            let v1759 : UH3 =
                if v1754 then
                    let v1755 : (string -> (string -> US19)) = closure59(v4, v3, v1, v0)
                    let v1756 : UH3 = UH3_0
                    UH3_1(v731, v488, v1755, v1756)
                else
                    UH3_0
            let v1760 : UH2 = UH2_0
            let v1761 : UH2 = UH2_1(v1693, v1760)
            UH2_1(v1759, v1761)
    let v1764 : UH3 list = []
    let v1765 : UH3 list = method81(v1763, v1764)
    let v1766 : (UH3 list -> (UH3 [])) = List.toArray
    let v1767 : (UH3 []) = v1766 v1765
    let v1768 : string = "$0.to_vec()"
    let v1769 : Vec<UH3> = Fable.Core.RustInterop.emitRustExpr v1767 v1768
    let v1770 : (Result<string, (string * string)> option []) = [||]
    let v1771 : string = "$0.to_vec()"
    let v1772 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1770 v1771
    let v1773 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v1774 : (UH3 []) = Fable.Core.RustInterop.emitRustExpr v1769 v1773
    let v1775 : int32 = v1774.Length
    let v1776 : Mut8 = {l0 = 0; l1 = v1772} : Mut8
    while method82(v1775, v1776) do
        let v1778 : int32 = v1776.l0
        let v1779 : Vec<Result<string, (string * string)> option> = v1776.l1
        let v1780 : UH3 = v1774.[int v1778]
        let v1781 : struct (string * string * (string -> (string -> US19))) list = []
        let v1782 : struct (string * string * (string -> (string -> US19))) list = method83(v1780, v1781)
        let v1783 : (struct (string * string * (string -> (string -> US19))) list -> (struct (string * string * (string -> (string -> US19))) [])) = List.toArray
        let v1784 : (struct (string * string * (string -> (string -> US19))) []) = v1783 v1782
        let v1785 : string = "$0.to_vec()"
        let v1786 : Vec<struct (string * string * (string -> (string -> US19)))> = Fable.Core.RustInterop.emitRustExpr v1784 v1785
        let v1787 : string = "rayon::iter::IntoParallelIterator::into_par_iter(v1786)"
        let v1788 : rayon_vec_IntoIter<struct (string * string * (string -> (string -> US19)))> = Fable.Core.RustInterop.emitRustExpr () v1787
        let v1789 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
        let v1790 : (struct (string * string * (string -> (string -> US19))) -> Result<string, (string * string)> option) = closure72()
        let v1791 : rayon_iter_Map<rayon_vec_IntoIter<struct (string * string * (string -> (string -> US19)))>> = Fable.Core.RustInterop.emitRustExpr struct (v1788, v1790) v1789
        let v1792 : string = "rayon::iter::ParallelIterator::collect($0)"
        let v1793 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1791 v1792
        let v1794 : Vec<Result<string, (string * string)> option> = method84(v1793)
        let v1795 : Vec<Result<string, (string * string)> option> = method85(v1779)
        let v1796 : string = "let mut v1795 = v1795"
        Fable.Core.RustInterop.emitRustExpr () v1796
        let v1797 : string = "v1795.extend(v1794)"
        Fable.Core.RustInterop.emitRustExpr () v1797
        let v1798 : string = "v1795"
        let v1799 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr () v1798
        let v1800 : int32 = v1778 + 1
        v1776.l0 <- v1800
        v1776.l1 <- v1799
        ()
    let v1801 : Vec<Result<string, (string * string)> option> = v1776.l1
    let v1802 : (string * Vec<Result<string, (string * string)> option>) = v225, v1801
    let v1803 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v1802
    v1803
and closure73 () () : string =
    let v0 : string = "documents.run"
    v0
and closure74 (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) () : string =
    let v1 : string = "$0.len()"
    let v2 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"result_len: {v2} / {v3 ()}"
    v4
and method86 (v0 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>) : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> =
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
    let v28 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = method86(v27)
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
