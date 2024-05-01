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
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Error")>]
#endif
type std_io_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Lines<$0>")>]
#endif
type std_io_Lines<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_std::io::BufReader<$0>")>]
#endif
type async_std_io_BufReader<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::BufReader<$0>")>]
#endif
type std_io_BufReader<'T> = class end
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
and closure5 (v0 : (string []), v1 : string) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"args: {v0} / current_dir: {v1} / {v2 ()}"
    v3
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
    let v22 : string = "v21.existsSync($0)"
    let v23 : bool = Fable.Core.JsInterop.emitJsExpr v3 v22
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
    let v21 : string = "v20.existsSync($0)"
    let v22 : bool = Fable.Core.JsInterop.emitJsExpr v2 v21
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
    let struct (v184 : int32, v185 : US3, v186 : US12) =
        match v49 with
        | US11_1(v175) -> (* Error *)
            let v176 : US0 = US0_4
            let v177 : (unit -> string) = closure33(v175)
            let v178 : (unit -> string) = closure6()
            method3(v176, v177, v178)
            let v179 : US3 = US3_0(v175)
            let v180 : US12 = US12_1
            struct (-1, v179, v180)
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
            let v98 : string = "std::io::BufRead::lines(std::io::BufReader::new(v63.lock().unwrap().take().unwrap()))"
            let v99 : std_io_Lines<std_io_BufReader<std_process_ChildStdout>> = Fable.Core.RustInterop.emitRustExpr () v98
            let v100 : string = "std::sync::Mutex::new($0)"
            let v101 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> = Fable.Core.RustInterop.emitRustExpr v99 v100
            let v102 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> = method60(v101)
            let v103 : string = "std::sync::Arc::new(v102)"
            let v104 : std_sync_Arc<std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>>> = Fable.Core.RustInterop.emitRustExpr () v103
            let v105 : (Result<std_string_String, std_io_Error> -> unit) = method61(v88)
            let v106 : string = "true; for line in $0.lock().unwrap().by_ref() { v105(line) }"
            let v107 : bool = Fable.Core.RustInterop.emitRustExpr v104 v106
            let v108 : string = "true; })"
            let v109 : bool = Fable.Core.RustInterop.emitRustExpr () v108
            let v110 : string = "std::thread::spawn(move || { //"
            let v111 : std_thread_JoinHandle<unit> = Fable.Core.RustInterop.emitRustExpr () v110
            let v112 : string = "std::io::BufRead::lines(std::io::BufReader::new(v69.lock().unwrap().take().unwrap()))"
            let v113 : std_io_Lines<std_io_BufReader<std_process_ChildStderr>> = Fable.Core.RustInterop.emitRustExpr () v112
            let v114 : string = "std::sync::Mutex::new($0)"
            let v115 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>> = Fable.Core.RustInterop.emitRustExpr v113 v114
            let v116 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>> = method62(v115)
            let v117 : string = "std::sync::Arc::new(v116)"
            let v118 : std_sync_Arc<std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>>> = Fable.Core.RustInterop.emitRustExpr () v117
            let v119 : (Result<std_string_String, std_io_Error> -> unit) = method63(v86)
            let v120 : string = "true; for line in $0.lock().unwrap().by_ref() { v119(line) }"
            let v121 : bool = Fable.Core.RustInterop.emitRustExpr v118 v120
            let v122 : string = "true; })"
            let v123 : bool = Fable.Core.RustInterop.emitRustExpr () v122
            let v124 : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US14) = method64()
            let v125 : US14 = US14_1
            let v126 : US14 = v4 |> Option.map v124 |> Option.defaultValue v125 
            match v126 with
            | US14_1 -> (* None *)
                ()
            | US14_0(v127) -> (* Some *)
                let v128 : string = "v75.lock().unwrap().take()"
                let v129 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr () v128
                let v130 : string = "$0.map(|x| $1(x))"
                let v131 : (std_process_ChildStdin -> std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) = closure42()
                let v132 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> option = Fable.Core.RustInterop.emitRustExpr struct (v129, v131) v130
                let v133 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US15) = method66()
                let v134 : US15 = US15_1
                let v135 : US15 = v132 |> Option.map v133 |> Option.defaultValue v134 
                match v135 with
                | US15_1 -> (* None *)
                    ()
                | US15_0(v136) -> (* Some *)
                    v127 v136
                    let v137 : string = "$0.lock()"
                    let v138 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr v136 v137
                    let v139 : string = "$0.unwrap()"
                    let v140 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v138 v139
                    let v141 : std_sync_MutexGuard<std_process_ChildStdin> = method67(v140)
                    let v142 : string = "true; let mut v141 = v141"
                    let v143 : bool = Fable.Core.RustInterop.emitRustExpr () v142
                    let v144 : string = "true; std::io::Write::flush(&mut *$0).unwrap()"
                    let v145 : bool = Fable.Core.RustInterop.emitRustExpr v141 v144
                    ()
            let v146 : string = "v51.lock().unwrap().take().unwrap().wait_with_output()"
            let v147 : Result<std_process_Output, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v146
            let v148 : (std_io_Error -> std_string_String) = method33()
            let v149 : string = "$0.map_err(|x| $1(x))"
            let v150 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v147, v148) v149
            let v151 : string = "true; v97.join().unwrap()"
            let v152 : bool = Fable.Core.RustInterop.emitRustExpr () v151
            let v153 : string = "true; v111.join().unwrap()"
            let v154 : bool = Fable.Core.RustInterop.emitRustExpr () v153
            let v155 : (std_process_Output -> US16) = closure44()
            let v156 : (std_string_String -> US16) = closure45()
            let v157 : US16 = match v150 with Ok x -> v155 x | Error x -> v156 x
            match v157 with
            | US16_1(v163) -> (* Error *)
                let v164 : US0 = US0_4
                let v165 : (unit -> string) = closure46(v163)
                let v166 : (unit -> string) = closure6()
                method3(v164, v165, v166)
                let v167 : US3 = US3_0(v163)
                let v168 : US12 = US12_1
                struct (-2, v167, v168)
            | US16_0(v158) -> (* Ok *)
                let v159 : string = "$0.status.code().unwrap()"
                let v160 : int32 = Fable.Core.RustInterop.emitRustExpr v158 v159
                let v161 : US3 = US3_1
                let v162 : US12 = US12_0(v95)
                struct (v160, v161, v162)
    let v193 : US3 =
        match v186 with
        | US12_1 -> (* None *)
            US3_1
        | US12_0(v187) -> (* Some *)
            let v188 : string = "$0.lock().unwrap().iter().collect::<Vec<String>>().join(\"\\n\")"
            let v189 : std_string_String = Fable.Core.RustInterop.emitRustExpr v187 v188
            US3_0(v189)
    let v200 : US4 =
        match v193 with
        | US3_1 -> (* None *)
            US4_1
        | US3_0(v194) -> (* Some *)
            let v195 : string = "fable_library_rust::String_::fromString($0)"
            let v196 : string = Fable.Core.RustInterop.emitRustExpr v194 v195
            US4_0(v196)
    let v207 : US4 =
        match v185 with
        | US3_1 -> (* None *)
            US4_1
        | US3_0(v201) -> (* Some *)
            let v202 : string = "fable_library_rust::String_::fromString($0)"
            let v203 : string = Fable.Core.RustInterop.emitRustExpr v201 v202
            US4_0(v203)
    let v211 : string =
        match v207 with
        | US4_1 -> (* None *)
            let v209 : string = ""
            v209
        | US4_0(v208) -> (* Some *)
            v208
    let v214 : string =
        match v200 with
        | US4_1 -> (* None *)
            v211
        | US4_0(v212) -> (* Some *)
            v212
    let v215 : US0 = US0_0
    let v216 : (unit -> string) = closure47(v184, v214)
    let v217 : (unit -> string) = closure6()
    method3(v215, v216, v217)
    let v218 : (int32 * string) = v184, v214
    let v219 : (int32 * string) = method68(v218)
    let v220 : string = "v219 }}})"
    Fable.Core.RustInterop.emitRustExpr () v220
    let v221 : string = "{{ //"
    Fable.Core.RustInterop.emitRustExpr () v221
    let v222 : string = "__result"
    let v223 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = Fable.Core.RustInterop.emitRustExpr () v222
    v223
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
and closure63 (v0 : int32, v1 : string) () : string =
    let v2 : int32 = v1 |> String.length
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"exit_code: %A{v0} / result_len: {v2} / {v3 ()}"
    v4
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
    let v344 : (unit -> string) = closure63(v305, v335)
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
    let v26 : string = "v25.existsSync($0)"
    let v27 : bool = Fable.Core.JsInterop.emitJsExpr v7 v26
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
            let v49 : string = "v48.existsSync($0)"
            let v50 : bool = Fable.Core.JsInterop.emitJsExpr v6 v49
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
            let v61 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v58, v59, v60) v61
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
            let v316 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v317 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v313, v314, v315) v316
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
                let v591 : string = "v590.existsSync($0)"
                let v592 : bool = Fable.Core.JsInterop.emitJsExpr v7 v591
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
and closure69 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: %A{v1} / result: {v0} / {v2 ()}"
    v3
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
        let v232 : (unit -> string) = closure69(v227, v226)
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
    let v24 : string = "v23.existsSync($0)"
    let v25 : bool = Fable.Core.JsInterop.emitJsExpr v5 v24
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
            let v47 : string = "v46.existsSync($0)"
            let v48 : bool = Fable.Core.JsInterop.emitJsExpr v4 v47
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
            let v59 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v56, v57, v58) v59
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
            let v314 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v315 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v311, v312, v313) v314
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
                let v589 : string = "v588.existsSync($0)"
                let v590 : bool = Fable.Core.JsInterop.emitJsExpr v5 v589
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
    let v165 : string =
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
            let v54 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v51, v52, v53) v54
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
                let struct (v123 : int32, v124 : (string [])) =
                    if v84 then
                        let v85 : int32 = v81 + 1
                        struct (v85, v82)
                    else
                        let v86 : bool = 0 = v81
                        if v86 then
                            let v87 : string = ":"
                            let v88 : bool = v83.EndsWith v87
                            if v88 then
                                let v89 : string = $"{v47.[0]}:"
                                let v90 : (string []) = [|v89|]
                                let v91 : int32 = v90.Length
                                let v92 : int32 = v82.Length
                                let v93 : int32 = v91 + v92
                                let v94 : (string []) = Array.zeroCreate<string> (v93)
                                let v95 : Mut5 = {l0 = 0} : Mut5
                                while method26(v93, v95) do
                                    let v97 : int32 = v95.l0
                                    let v98 : bool = v97 < v91
                                    let v102 : string =
                                        if v98 then
                                            let v99 : string = v90.[int v97]
                                            v99
                                        else
                                            let v100 : int32 = v97 - v91
                                            let v101 : string = v82.[int v100]
                                            v101
                                    v94.[int v97] <- v102
                                    let v103 : int32 = v97 + 1
                                    v95.l0 <- v103
                                    ()
                                struct (0, v94)
                            else
                                let v104 : (string []) = [|v83|]
                                let v105 : int32 = v104.Length
                                let v106 : int32 = v82.Length
                                let v107 : int32 = v105 + v106
                                let v108 : (string []) = Array.zeroCreate<string> (v107)
                                let v109 : Mut5 = {l0 = 0} : Mut5
                                while method26(v107, v109) do
                                    let v111 : int32 = v109.l0
                                    let v112 : bool = v111 < v105
                                    let v116 : string =
                                        if v112 then
                                            let v113 : string = v104.[int v111]
                                            v113
                                        else
                                            let v114 : int32 = v111 - v105
                                            let v115 : string = v82.[int v114]
                                            v115
                                    v108.[int v111] <- v116
                                    let v117 : int32 = v111 + 1
                                    v109.l0 <- v117
                                    ()
                                struct (0, v108)
                        else
                            let v120 : int32 = v81 - 1
                            struct (v120, v82)
                let v125 : int32 = v77 + 1
                v75.l0 <- v125
                v75.l1 <- v123
                v75.l2 <- v124
                ()
            let struct (v126 : int32, v127 : (string [])) = v75.l1, v75.l2
            let v128 : string seq = seq { for i = 0 to v127.Length - 1 do yield v127.[i] }
            let v129 : char option = None
            let v130 : bool = true in let mutable _v129 = v129
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v131 : string = "std::path::MAIN_SEPARATOR"
            let v132 : char = Fable.Core.RustInterop.emitRustExpr () v131
            v132
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v133 : char = null |> unbox<char>
            v133
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v134 : char = null |> unbox<char>
            v134
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v135 : char = null |> unbox<char>
            v135
#endif
            
#if FABLE_COMPILER_PYTHON
            let v136 : char = null |> unbox<char>
            v136
#endif
            
#else
            let v137 : char = System.IO.Path.DirectorySeparatorChar
            v137
#endif
            |> fun x -> _v129 <- Some x
            let v138 : char = _v129.Value
            let v139 : (char -> string) = _.ToString()
            let v140 : string = v139 v138
            let v141 : string = method27(v140)
            let v142 : (string -> (string seq -> string)) = String.concat
            let v143 : (string seq -> string) = v142 v141
            v143 v128
        else
            let v145 : string = "std::fs::canonicalize(&*$0)"
            let v146 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v8 v145
            let v147 : string = "$0.unwrap()"
            let v148 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v146 v147
            let v149 : string = "$0.display()"
            let v150 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v148 v149
            let v151 : std_string_String option = None
            let v152 : bool = true in let mutable _v151 = v151
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v153 : string = @$"format!(""{{}}"", $0)"
            let v154 : std_string_String = Fable.Core.RustInterop.emitRustExpr v150 v153
            v154
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v155 : string = @$"format!(""{{}}"", $0)"
            let v156 : std_string_String = Fable.Core.RustInterop.emitRustExpr v150 v155
            v156
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v157 : string = @$"format!(""{{}}"", $0)"
            let v158 : std_string_String = Fable.Core.RustInterop.emitRustExpr v150 v157
            v158
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v159 : std_string_String = null |> unbox<std_string_String>
            v159
#endif
            
#if FABLE_COMPILER_PYTHON
            let v160 : std_string_String = null |> unbox<std_string_String>
            v160
#endif
            
#else
            let v161 : std_string_String = null |> unbox<std_string_String>
            v161
#endif
            |> fun x -> _v151 <- Some x
            let v162 : std_string_String = _v151.Value
            let v163 : string = "fable_library_rust::String_::fromString($0)"
            let v164 : string = Fable.Core.RustInterop.emitRustExpr v162 v163
            v164
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
    let v170 : string = method28(v5)
    let v171 : (string -> string) = System.IO.Path.GetFullPath
    let v172 : string = v171 v170
    v172
#endif
    |> fun x -> _v6 <- Some x
    let v173 : string = _v6.Value
    let v174 : string = method14(v173)
    let v175 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v176 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v174 v175
    let v177 : string = "String::from($0)"
    let v178 : std_string_String = Fable.Core.RustInterop.emitRustExpr v176 v177
    let v179 : string = "std::path::PathBuf::from($0)"
    let v180 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v178 v179
    let v181 : string = "$0.display()"
    let v182 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v180 v181
    let v183 : std_string_String option = None
    let v184 : bool = true in let mutable _v183 = v183
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v185 : string = @$"format!(""{{}}"", $0)"
    let v186 : std_string_String = Fable.Core.RustInterop.emitRustExpr v182 v185
    v186
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v187 : string = @$"format!(""{{}}"", $0)"
    let v188 : std_string_String = Fable.Core.RustInterop.emitRustExpr v182 v187
    v188
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v189 : string = @$"format!(""{{}}"", $0)"
    let v190 : std_string_String = Fable.Core.RustInterop.emitRustExpr v182 v189
    v190
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v191 : std_string_String = null |> unbox<std_string_String>
    v191
#endif
    
#if FABLE_COMPILER_PYTHON
    let v192 : std_string_String = null |> unbox<std_string_String>
    v192
#endif
    
#else
    let v193 : std_string_String = null |> unbox<std_string_String>
    v193
#endif
    |> fun x -> _v183 <- Some x
    let v194 : std_string_String = _v183.Value
    let v195 : string = "fable_library_rust::String_::fromString($0)"
    let v196 : string = Fable.Core.RustInterop.emitRustExpr v194 v195
    let v197 : string = ""
    let v198 : string = v196.Replace (v3, v197)
    let v199 : string = "\\"
    let v200 : string = "/"
    let v201 : string = v198.Replace (v199, v200)
    let v202 : string = $".{v201}"
    let v203 : string option = None
    let v204 : bool = true in let mutable _v203 = v203
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v205 : string = method22()
    let v206 : string = method23(v173)
    let v207 : string = method24()
    let v208 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
    let v209 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v205, v206, v207) v208
    let v210 : string = "String::from($0)"
    let v211 : std_string_String = Fable.Core.RustInterop.emitRustExpr v209 v210
    let v212 : string = "fable_library_rust::String_::fromString($0)"
    let v213 : string = Fable.Core.RustInterop.emitRustExpr v211 v212
    v213
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v214 : string = null |> unbox<string>
    v214
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v215 : string = null |> unbox<string>
    v215
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v216 : string = null |> unbox<string>
    v216
#endif
    
#if FABLE_COMPILER_PYTHON
    let v217 : string = null |> unbox<string>
    v217
#endif
    
#else
    let v218 : string = "^\\\\\\\\\\?\\\\"
    let v219 : string = System.Text.RegularExpressions.Regex.Replace (v173, v218, v197)
    v219
#endif
    |> fun x -> _v203 <- Some x
    let v220 : string = _v203.Value
    let v221 : string = $"{v220.[0] |> string |> _.ToLower()}{v220.[1..]}"
    let v222 : string = v221.Replace (v199, v200)
    let v223 : string = method13(v2, v202)
    let v224 : string option = None
    let v225 : bool = true in let mutable _v224 = v224
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v226 : string = method22()
    let v227 : string = method23(v223)
    let v228 : string = method24()
    let v229 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
    let v230 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v226, v227, v228) v229
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
    let v239 : string = System.Text.RegularExpressions.Regex.Replace (v223, v218, v197)
    v239
#endif
    |> fun x -> _v224 <- Some x
    let v240 : string = _v224.Value
    let v241 : string = $"{v240.[0] |> string |> _.ToLower()}{v240.[1..]}"
    let v242 : string = v241.Replace (v199, v200)
    let v243 : string option = None
    let v244 : System.Threading.CancellationToken option = None
    let v245 : (struct (string * string) []) = [||]
    let v246 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v247 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v248 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v242}\""
    let v249 : string option = Some v2 
    let v250 : struct (int32 * string) option = None
    let v251 : bool = true in let mutable _v250 = v250
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v252 : string = method38(v244, v248, v245, v246, v247, v249)
    let struct (v253 : string, v254 : string) = method39()
    let v255 : int32 = v252.Length
    let v256 : (char []) = Array.zeroCreate<char> (v255)
    let v257 : Mut5 = {l0 = 0} : Mut5
    while method26(v255, v257) do
        let v259 : int32 = v257.l0
        let v260 : char = v252.[int v259]
        v256.[int v259] <- v260
        let v261 : int32 = v259 + 1
        v257.l0 <- v261
        ()
    let v262 : ((char []) -> char list) = Array.toList
    let v263 : char list = v262 v256
    let v264 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v265 : (char -> (UH0 -> UH0)) = method40()
    let v266 : (char list -> (UH0 -> UH0)) = v264 v265
    let v267 : (UH0 -> UH0) = v266 v263
    let v268 : UH0 = UH0_0
    let v269 : UH0 = v267 v268
    let v270 : US8 = US8_0
    let struct (v271 : string, v272 : string) = method41(v254, v253, v269, v270)
    let v273 : (string []) = method42(v272)
    let v274 : string = "$0.to_vec()"
    let v275 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v273 v274
    let v276 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v277 : (string -> std_string_String) = closure28()
    let v278 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v275, v277) v276
    let v279 : US0 = US0_1
    let v280 : (unit -> string) = closure29(v244, v248, v245, v246, v247, v249, v271, v278)
    let v281 : (unit -> string) = method47()
    method3(v279, v280, v281)
    let v282 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v244, v248, v245, v246, v247, v249, v271, v278)
    let v283 : string = "futures_lite::future::block_on($0)"
    let v284 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v282 v283
    let (a, b) = v284
    let v285 : int32 = a
    let v286 : string = b
    struct (v285, v286)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v287 : int32, v288 : string) = null |> unbox<struct (int32 * string)>
    struct (v287, v288)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v289 : int32, v290 : string) = null |> unbox<struct (int32 * string)>
    struct (v289, v290)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v291 : int32, v292 : string) = null |> unbox<struct (int32 * string)>
    struct (v291, v292)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v293 : int32, v294 : string) = null |> unbox<struct (int32 * string)>
    struct (v293, v294)
#endif
    
#else
    let v295 : Async<struct (int32 * string)> option = None
    let v296 : bool = true in let mutable _v295 = v295
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v297 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v297
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v298 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v298
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v299 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v299
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v300 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v300
#endif
    
#if FABLE_COMPILER_PYTHON
    let v301 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v301
#endif
    
#else
    let v302 : Async<struct (int32 * string)> option = None
    let v303 : bool = true in let mutable _v302 = v302
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v304 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v304
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v305 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v305
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v306 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v306
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v307 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v307
#endif
    
#if FABLE_COMPILER_PYTHON
    let v308 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v308
#endif
    
#else
    let v309 : Async<struct (int32 * string)> option = None
    let mutable _v309 = v309
    async {
    let struct (v310 : string, v311 : string) = method39()
    let v312 : int32 = v248.Length
    let v313 : (char []) = Array.zeroCreate<char> (v312)
    let v314 : Mut5 = {l0 = 0} : Mut5
    while method26(v312, v314) do
        let v316 : int32 = v314.l0
        let v317 : char = v248.[int v316]
        v313.[int v316] <- v317
        let v318 : int32 = v316 + 1
        v314.l0 <- v318
        ()
    let v319 : ((char []) -> char list) = Array.toList
    let v320 : char list = v319 v313
    let v321 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v322 : (char -> (UH0 -> UH0)) = method40()
    let v323 : (char list -> (UH0 -> UH0)) = v321 v322
    let v324 : (UH0 -> UH0) = v323 v320
    let v325 : UH0 = UH0_0
    let v326 : UH0 = v324 v325
    let v327 : US8 = US8_0
    let struct (v328 : string, v329 : string) = method41(v311, v310, v326, v327)
    let v330 : (string -> US4) = method19()
    let v331 : US4 = US4_1
    let v332 : US4 = v249 |> Option.map v330 |> Option.defaultValue v331 
    let v335 : string =
        match v332 with
        | US4_1 -> (* None *)
            v197
        | US4_0(v333) -> (* Some *)
            v333
    let v336 : US0 = US0_1
    let v337 : (unit -> string) = closure48(v244, v248, v245, v246, v247, v249)
    let v338 : (unit -> string) = method47()
    method3(v336, v337, v338)
    let v339 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v340 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v329, StandardOutputEncoding = v339, WorkingDirectory = v335, FileName = v328, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v341 : int32 = v245.Length
    let v342 : Mut5 = {l0 = 0} : Mut5
    while method26(v341, v342) do
        let v344 : int32 = v342.l0
        let struct (v345 : string, v346 : string) = v245.[int v344]
        v340.EnvironmentVariables.[v345] <- v346 
        let v347 : int32 = v344 + 1
        v342.l0 <- v347
        ()
    let v348 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v340)
    use v348 = v348 
    let v349 : System.Diagnostics.Process = v348 
    let v350 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v351 : System.Collections.Concurrent.ConcurrentStack<string> = v350 ()
    let v352 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v244, v248, v245, v246, v247, v249, v349, v351)
    v349.OutputDataReceived.Add v352 
    let v353 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v244, v248, v245, v246, v247, v249, v349, v351)
    v349.ErrorDataReceived.Add v353 
    let v354 : (unit -> bool) = v349.Start
    let v355 : bool = v354 ()
    let v356 : bool = v355 = false
    if v356 then
        let v357 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v357
    let v358 : (unit -> unit) = v349.BeginErrorReadLine
    v358 ()
    let v359 : (unit -> unit) = v349.BeginOutputReadLine
    v359 ()
    let v360 : (System.Threading.CancellationToken -> US18) = method70()
    let v361 : US18 = US18_1
    let v362 : US18 = v244 |> Option.map v360 |> Option.defaultValue v361 
    let v366 : System.Threading.CancellationToken =
        match v362 with
        | US18_1 -> (* None *)
            let v364 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v364
        | US18_0(v363) -> (* Some *)
            v363
    let v367 : Async<System.Threading.CancellationToken> option = None
    let v368 : bool = true in let mutable _v367 = v367
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v369 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v369
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v370 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v370
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v371 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v371
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v372 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v372
#endif
    
#if FABLE_COMPILER_PYTHON
    let v373 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v373
#endif
    
#else
    let v374 : Async<System.Threading.CancellationToken> option = None
    let v375 : bool = true in let mutable _v374 = v374
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v376 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v376
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v377 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v377
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v378 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v378
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v379 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v379
#endif
    
#if FABLE_COMPILER_PYTHON
    let v380 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v380
#endif
    
#else
    let v381 : Async<System.Threading.CancellationToken> option = None
    let mutable _v381 = v381
    async {
    let v382 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v382 = v382 
    let v383 : System.Threading.CancellationToken = v382 
    let v384 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v385 : (System.Threading.CancellationToken []) = [|v383; v384; v366|]
    let v386 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v387 : System.Threading.CancellationTokenSource = v386 v385
    let v388 : System.Threading.CancellationToken = v387.Token
    return v388 
    }
    |> fun x -> _v381 <- Some x
    let v389 : Async<System.Threading.CancellationToken> = _v381 |> Option.get
    v389
#endif
    |> fun x -> _v374 <- Some x
    let v390 : Async<System.Threading.CancellationToken> = _v374.Value
    v390
#endif
    |> fun x -> _v367 <- Some x
    let v391 : Async<System.Threading.CancellationToken> = _v367.Value
    let! v391 = v391 
    let v392 : System.Threading.CancellationToken = v391 
    let v393 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v392.Register
    let v394 : (unit -> unit) = closure54(v349)
    let v395 : System.Threading.CancellationTokenRegistration = v393 v394
    use v395 = v395 
    let v396 : System.Threading.CancellationTokenRegistration = v395 
    let v397 : Async<int32> option = None
    let v398 : bool = true in let mutable _v397 = v397
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v399 : Async<int32> = null |> unbox<Async<int32>>
    v399
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v400 : Async<int32> = null |> unbox<Async<int32>>
    v400
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v401 : Async<int32> = null |> unbox<Async<int32>>
    v401
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v402 : Async<int32> = null |> unbox<Async<int32>>
    v402
#endif
    
#if FABLE_COMPILER_PYTHON
    let v403 : Async<int32> = null |> unbox<Async<int32>>
    v403
#endif
    
#else
    let v404 : Async<int32> option = None
    let mutable _v404 = v404
    async {
    try
    let v405 : System.Threading.Tasks.Task = v349.WaitForExitAsync v392 
    let v406 : Async<unit> option = None
    let v407 : bool = true in let mutable _v406 = v406
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v408 : Async<unit> = null |> unbox<Async<unit>>
    v408
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v409 : Async<unit> = null |> unbox<Async<unit>>
    v409
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v410 : Async<unit> = null |> unbox<Async<unit>>
    v410
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v411 : Async<unit> = null |> unbox<Async<unit>>
    v411
#endif
    
#if FABLE_COMPILER_PYTHON
    let v412 : Async<unit> = null |> unbox<Async<unit>>
    v412
#endif
    
#else
    let v413 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v414 : Async<unit> = v413 v405
    v414
#endif
    |> fun x -> _v406 <- Some x
    let v415 : Async<unit> = _v406.Value
    do! v415 
    let v416 : int32 = v349.ExitCode
    return v416 
    with ex ->
    let v417 : exn = ex
    let v418 : string option = None
    let v419 : bool = true in let mutable _v418 = v418
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v420 : string = $"%A{v417}"
    v420
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v421 : string = $"%A{v417}"
    v421
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v422 : string = $"%A{v417}"
    v422
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v423 : string = $"%A{v417}"
    v423
#endif
    
#if FABLE_COMPILER_PYTHON
    let v424 : string = $"%A{v417}"
    v424
#endif
    
#else
    let v425 : string = $"{v417.GetType ()}: {v417.Message}"
    v425
#endif
    |> fun x -> _v418 <- Some x
    let v426 : string = _v418.Value
    let v427 : (string -> unit) = v351.Push
    v427 v426
    let v428 : System.Threading.Tasks.TaskCanceledException = v417 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v429 : US0 = US0_3
    let v430 : (unit -> string) = closure55(v428)
    let v431 : (unit -> string) = method47()
    method3(v429, v430, v431)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v404 <- Some x
    let v432 : Async<int32> = _v404 |> Option.get
    v432
#endif
    |> fun x -> _v397 <- Some x
    let v433 : Async<int32> = _v397.Value
    let! v433 = v433 
    let v434 : int32 = v433 
    let v435 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v436 : string seq = v435 v351
    let v437 : string = method71()
    let v438 : (string -> (string seq -> string)) = String.concat
    let v439 : (string seq -> string) = v438 v437
    let v440 : string = v439 v436
    let v441 : US0 = US0_1
    let v442 : (unit -> string) = closure56(v434, v440)
    let v443 : (unit -> string) = method47()
    method3(v441, v442, v443)
    return struct (v434, v440) 
    }
    |> fun x -> _v309 <- Some x
    let v444 : Async<struct (int32 * string)> = _v309 |> Option.get
    v444
#endif
    |> fun x -> _v302 <- Some x
    let v445 : Async<struct (int32 * string)> = _v302.Value
    v445
#endif
    |> fun x -> _v295 <- Some x
    let v446 : Async<struct (int32 * string)> = _v295.Value
    let v447 : struct (int32 * string) option = None
    let v448 : bool = true in let mutable _v447 = v447
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v449 : int32, v450 : string) = null |> unbox<struct (int32 * string)>
    struct (v449, v450)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v451 : int32, v452 : string) = null |> unbox<struct (int32 * string)>
    struct (v451, v452)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v453 : int32, v454 : string) = null |> unbox<struct (int32 * string)>
    struct (v453, v454)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v455 : int32, v456 : string) = null |> unbox<struct (int32 * string)>
    struct (v455, v456)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v457 : int32, v458 : string) = null |> unbox<struct (int32 * string)>
    struct (v457, v458)
#endif
    
#else
    let v459 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v460 : int32, v461 : string) = v459 v446
    struct (v460, v461)
#endif
    |> fun x -> _v447 <- Some x
    let struct (v462 : int32, v463 : string) = _v447.Value
    struct (v462, v463)
#endif
    |> fun x -> _v250 <- Some x
    let struct (v464 : int32, v465 : string) = _v250.Value
    let v466 : string = method13(v3, v202)
    let v467 : string option = None
    let v468 : bool = true in let mutable _v467 = v467
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v469 : string = method22()
    let v470 : string = method23(v466)
    let v471 : string = method24()
    let v472 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
    let v473 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v469, v470, v471) v472
    let v474 : string = "String::from($0)"
    let v475 : std_string_String = Fable.Core.RustInterop.emitRustExpr v473 v474
    let v476 : string = "fable_library_rust::String_::fromString($0)"
    let v477 : string = Fable.Core.RustInterop.emitRustExpr v475 v476
    v477
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v478 : string = null |> unbox<string>
    v478
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v479 : string = null |> unbox<string>
    v479
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v480 : string = null |> unbox<string>
    v480
#endif
    
#if FABLE_COMPILER_PYTHON
    let v481 : string = null |> unbox<string>
    v481
#endif
    
#else
    let v482 : string = System.Text.RegularExpressions.Regex.Replace (v466, v218, v197)
    v482
#endif
    |> fun x -> _v467 <- Some x
    let v483 : string = _v467.Value
    let v484 : string = $"{v483.[0] |> string |> _.ToLower()}{v483.[1..]}"
    let v485 : string = v484.Replace (v199, v200)
    let v486 : string option = None
    let v487 : System.Threading.CancellationToken option = None
    let v488 : (struct (string * string) []) = [||]
    let v489 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v490 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v491 : string = $"git hash-object \"{v485}\""
    let v492 : string option = Some v3 
    let v493 : struct (int32 * string) option = None
    let v494 : bool = true in let mutable _v493 = v493
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v495 : string = method38(v487, v491, v488, v489, v490, v492)
    let struct (v496 : string, v497 : string) = method39()
    let v498 : int32 = v495.Length
    let v499 : (char []) = Array.zeroCreate<char> (v498)
    let v500 : Mut5 = {l0 = 0} : Mut5
    while method26(v498, v500) do
        let v502 : int32 = v500.l0
        let v503 : char = v495.[int v502]
        v499.[int v502] <- v503
        let v504 : int32 = v502 + 1
        v500.l0 <- v504
        ()
    let v505 : ((char []) -> char list) = Array.toList
    let v506 : char list = v505 v499
    let v507 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v508 : (char -> (UH0 -> UH0)) = method40()
    let v509 : (char list -> (UH0 -> UH0)) = v507 v508
    let v510 : (UH0 -> UH0) = v509 v506
    let v511 : UH0 = UH0_0
    let v512 : UH0 = v510 v511
    let v513 : US8 = US8_0
    let struct (v514 : string, v515 : string) = method41(v497, v496, v512, v513)
    let v516 : (string []) = method42(v515)
    let v517 : string = "$0.to_vec()"
    let v518 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v516 v517
    let v519 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v520 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v518, v277) v519
    let v521 : US0 = US0_1
    let v522 : (unit -> string) = closure29(v487, v491, v488, v489, v490, v492, v514, v520)
    let v523 : (unit -> string) = method47()
    method3(v521, v522, v523)
    let v524 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v487, v491, v488, v489, v490, v492, v514, v520)
    let v525 : string = "futures_lite::future::block_on($0)"
    let v526 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v524 v525
    let (a, b) = v526
    let v527 : int32 = a
    let v528 : string = b
    struct (v527, v528)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v529 : int32, v530 : string) = null |> unbox<struct (int32 * string)>
    struct (v529, v530)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v531 : int32, v532 : string) = null |> unbox<struct (int32 * string)>
    struct (v531, v532)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v533 : int32, v534 : string) = null |> unbox<struct (int32 * string)>
    struct (v533, v534)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v535 : int32, v536 : string) = null |> unbox<struct (int32 * string)>
    struct (v535, v536)
#endif
    
#else
    let v537 : Async<struct (int32 * string)> option = None
    let v538 : bool = true in let mutable _v537 = v537
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v539 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v539
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v540 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v540
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v541 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v541
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v542 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v542
#endif
    
#if FABLE_COMPILER_PYTHON
    let v543 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v543
#endif
    
#else
    let v544 : Async<struct (int32 * string)> option = None
    let v545 : bool = true in let mutable _v544 = v544
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v546 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v546
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v547 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v547
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v548 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v548
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v549 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v549
#endif
    
#if FABLE_COMPILER_PYTHON
    let v550 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v550
#endif
    
#else
    let v551 : Async<struct (int32 * string)> option = None
    let mutable _v551 = v551
    async {
    let struct (v552 : string, v553 : string) = method39()
    let v554 : int32 = v491.Length
    let v555 : (char []) = Array.zeroCreate<char> (v554)
    let v556 : Mut5 = {l0 = 0} : Mut5
    while method26(v554, v556) do
        let v558 : int32 = v556.l0
        let v559 : char = v491.[int v558]
        v555.[int v558] <- v559
        let v560 : int32 = v558 + 1
        v556.l0 <- v560
        ()
    let v561 : ((char []) -> char list) = Array.toList
    let v562 : char list = v561 v555
    let v563 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v564 : (char -> (UH0 -> UH0)) = method40()
    let v565 : (char list -> (UH0 -> UH0)) = v563 v564
    let v566 : (UH0 -> UH0) = v565 v562
    let v567 : UH0 = UH0_0
    let v568 : UH0 = v566 v567
    let v569 : US8 = US8_0
    let struct (v570 : string, v571 : string) = method41(v553, v552, v568, v569)
    let v572 : (string -> US4) = method19()
    let v573 : US4 = US4_1
    let v574 : US4 = v492 |> Option.map v572 |> Option.defaultValue v573 
    let v577 : string =
        match v574 with
        | US4_1 -> (* None *)
            v197
        | US4_0(v575) -> (* Some *)
            v575
    let v578 : US0 = US0_1
    let v579 : (unit -> string) = closure48(v487, v491, v488, v489, v490, v492)
    let v580 : (unit -> string) = method47()
    method3(v578, v579, v580)
    let v581 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v582 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v571, StandardOutputEncoding = v581, WorkingDirectory = v577, FileName = v570, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v583 : int32 = v488.Length
    let v584 : Mut5 = {l0 = 0} : Mut5
    while method26(v583, v584) do
        let v586 : int32 = v584.l0
        let struct (v587 : string, v588 : string) = v488.[int v586]
        v582.EnvironmentVariables.[v587] <- v588 
        let v589 : int32 = v586 + 1
        v584.l0 <- v589
        ()
    let v590 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v582)
    use v590 = v590 
    let v591 : System.Diagnostics.Process = v590 
    let v592 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v593 : System.Collections.Concurrent.ConcurrentStack<string> = v592 ()
    let v594 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v487, v491, v488, v489, v490, v492, v591, v593)
    v591.OutputDataReceived.Add v594 
    let v595 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v487, v491, v488, v489, v490, v492, v591, v593)
    v591.ErrorDataReceived.Add v595 
    let v596 : (unit -> bool) = v591.Start
    let v597 : bool = v596 ()
    let v598 : bool = v597 = false
    if v598 then
        let v599 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v599
    let v600 : (unit -> unit) = v591.BeginErrorReadLine
    v600 ()
    let v601 : (unit -> unit) = v591.BeginOutputReadLine
    v601 ()
    let v602 : (System.Threading.CancellationToken -> US18) = method70()
    let v603 : US18 = US18_1
    let v604 : US18 = v487 |> Option.map v602 |> Option.defaultValue v603 
    let v608 : System.Threading.CancellationToken =
        match v604 with
        | US18_1 -> (* None *)
            let v606 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v606
        | US18_0(v605) -> (* Some *)
            v605
    let v609 : Async<System.Threading.CancellationToken> option = None
    let v610 : bool = true in let mutable _v609 = v609
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v611 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v611
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v612 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v612
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v613 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v613
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v614 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v614
#endif
    
#if FABLE_COMPILER_PYTHON
    let v615 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v615
#endif
    
#else
    let v616 : Async<System.Threading.CancellationToken> option = None
    let v617 : bool = true in let mutable _v616 = v616
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v618 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v618
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v619 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v619
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v620 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v620
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v621 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v621
#endif
    
#if FABLE_COMPILER_PYTHON
    let v622 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v622
#endif
    
#else
    let v623 : Async<System.Threading.CancellationToken> option = None
    let mutable _v623 = v623
    async {
    let v624 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v624 = v624 
    let v625 : System.Threading.CancellationToken = v624 
    let v626 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v627 : (System.Threading.CancellationToken []) = [|v625; v626; v608|]
    let v628 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v629 : System.Threading.CancellationTokenSource = v628 v627
    let v630 : System.Threading.CancellationToken = v629.Token
    return v630 
    }
    |> fun x -> _v623 <- Some x
    let v631 : Async<System.Threading.CancellationToken> = _v623 |> Option.get
    v631
#endif
    |> fun x -> _v616 <- Some x
    let v632 : Async<System.Threading.CancellationToken> = _v616.Value
    v632
#endif
    |> fun x -> _v609 <- Some x
    let v633 : Async<System.Threading.CancellationToken> = _v609.Value
    let! v633 = v633 
    let v634 : System.Threading.CancellationToken = v633 
    let v635 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v634.Register
    let v636 : (unit -> unit) = closure54(v591)
    let v637 : System.Threading.CancellationTokenRegistration = v635 v636
    use v637 = v637 
    let v638 : System.Threading.CancellationTokenRegistration = v637 
    let v639 : Async<int32> option = None
    let v640 : bool = true in let mutable _v639 = v639
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v641 : Async<int32> = null |> unbox<Async<int32>>
    v641
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v642 : Async<int32> = null |> unbox<Async<int32>>
    v642
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v643 : Async<int32> = null |> unbox<Async<int32>>
    v643
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v644 : Async<int32> = null |> unbox<Async<int32>>
    v644
#endif
    
#if FABLE_COMPILER_PYTHON
    let v645 : Async<int32> = null |> unbox<Async<int32>>
    v645
#endif
    
#else
    let v646 : Async<int32> option = None
    let mutable _v646 = v646
    async {
    try
    let v647 : System.Threading.Tasks.Task = v591.WaitForExitAsync v634 
    let v648 : Async<unit> option = None
    let v649 : bool = true in let mutable _v648 = v648
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v650 : Async<unit> = null |> unbox<Async<unit>>
    v650
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v651 : Async<unit> = null |> unbox<Async<unit>>
    v651
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v652 : Async<unit> = null |> unbox<Async<unit>>
    v652
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v653 : Async<unit> = null |> unbox<Async<unit>>
    v653
#endif
    
#if FABLE_COMPILER_PYTHON
    let v654 : Async<unit> = null |> unbox<Async<unit>>
    v654
#endif
    
#else
    let v655 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v656 : Async<unit> = v655 v647
    v656
#endif
    |> fun x -> _v648 <- Some x
    let v657 : Async<unit> = _v648.Value
    do! v657 
    let v658 : int32 = v591.ExitCode
    return v658 
    with ex ->
    let v659 : exn = ex
    let v660 : string option = None
    let v661 : bool = true in let mutable _v660 = v660
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v662 : string = $"%A{v659}"
    v662
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v663 : string = $"%A{v659}"
    v663
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v664 : string = $"%A{v659}"
    v664
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v665 : string = $"%A{v659}"
    v665
#endif
    
#if FABLE_COMPILER_PYTHON
    let v666 : string = $"%A{v659}"
    v666
#endif
    
#else
    let v667 : string = $"{v659.GetType ()}: {v659.Message}"
    v667
#endif
    |> fun x -> _v660 <- Some x
    let v668 : string = _v660.Value
    let v669 : (string -> unit) = v593.Push
    v669 v668
    let v670 : System.Threading.Tasks.TaskCanceledException = v659 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v671 : US0 = US0_3
    let v672 : (unit -> string) = closure55(v670)
    let v673 : (unit -> string) = method47()
    method3(v671, v672, v673)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v646 <- Some x
    let v674 : Async<int32> = _v646 |> Option.get
    v674
#endif
    |> fun x -> _v639 <- Some x
    let v675 : Async<int32> = _v639.Value
    let! v675 = v675 
    let v676 : int32 = v675 
    let v677 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v678 : string seq = v677 v593
    let v679 : string = method71()
    let v680 : (string -> (string seq -> string)) = String.concat
    let v681 : (string seq -> string) = v680 v679
    let v682 : string = v681 v678
    let v683 : US0 = US0_1
    let v684 : (unit -> string) = closure56(v676, v682)
    let v685 : (unit -> string) = method47()
    method3(v683, v684, v685)
    return struct (v676, v682) 
    }
    |> fun x -> _v551 <- Some x
    let v686 : Async<struct (int32 * string)> = _v551 |> Option.get
    v686
#endif
    |> fun x -> _v544 <- Some x
    let v687 : Async<struct (int32 * string)> = _v544.Value
    v687
#endif
    |> fun x -> _v537 <- Some x
    let v688 : Async<struct (int32 * string)> = _v537.Value
    let v689 : struct (int32 * string) option = None
    let v690 : bool = true in let mutable _v689 = v689
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v691 : int32, v692 : string) = null |> unbox<struct (int32 * string)>
    struct (v691, v692)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v693 : int32, v694 : string) = null |> unbox<struct (int32 * string)>
    struct (v693, v694)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v695 : int32, v696 : string) = null |> unbox<struct (int32 * string)>
    struct (v695, v696)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v697 : int32, v698 : string) = null |> unbox<struct (int32 * string)>
    struct (v697, v698)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v699 : int32, v700 : string) = null |> unbox<struct (int32 * string)>
    struct (v699, v700)
#endif
    
#else
    let v701 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v702 : int32, v703 : string) = v701 v688
    struct (v702, v703)
#endif
    |> fun x -> _v689 <- Some x
    let struct (v704 : int32, v705 : string) = _v689.Value
    struct (v704, v705)
#endif
    |> fun x -> _v493 <- Some x
    let struct (v706 : int32, v707 : string) = _v493.Value
    let v708 : string = method13(v4, v202)
    let v709 : string option = None
    let v710 : bool = true in let mutable _v709 = v709
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v711 : string = method22()
    let v712 : string = method23(v708)
    let v713 : string = method24()
    let v714 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
    let v715 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v711, v712, v713) v714
    let v716 : string = "String::from($0)"
    let v717 : std_string_String = Fable.Core.RustInterop.emitRustExpr v715 v716
    let v718 : string = "fable_library_rust::String_::fromString($0)"
    let v719 : string = Fable.Core.RustInterop.emitRustExpr v717 v718
    v719
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v720 : string = null |> unbox<string>
    v720
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v721 : string = null |> unbox<string>
    v721
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v722 : string = null |> unbox<string>
    v722
#endif
    
#if FABLE_COMPILER_PYTHON
    let v723 : string = null |> unbox<string>
    v723
#endif
    
#else
    let v724 : string = System.Text.RegularExpressions.Regex.Replace (v708, v218, v197)
    v724
#endif
    |> fun x -> _v709 <- Some x
    let v725 : string = _v709.Value
    let v726 : string = $"{v725.[0] |> string |> _.ToLower()}{v725.[1..]}"
    let v727 : string = v726.Replace (v199, v200)
    let v728 : string = "hangul.md"
    let struct (v729 : string, v730 : string) = method72(v728, v485, v4)
    let v731 : bool = v465.Contains v707
    let v732 : bool = v731 = false
    let v1297 : UH2 =
        if v732 then
            let v733 : string option = None
            let v734 : bool = true in let mutable _v733 = v733
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v735 : string = method22()
            let v736 : string = method23(v485)
            let v737 : string = method24()
            let v738 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v739 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v735, v736, v737) v738
            let v740 : string = "String::from($0)"
            let v741 : std_string_String = Fable.Core.RustInterop.emitRustExpr v739 v740
            let v742 : string = "fable_library_rust::String_::fromString($0)"
            let v743 : string = Fable.Core.RustInterop.emitRustExpr v741 v742
            v743
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v744 : string = null |> unbox<string>
            v744
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v745 : string = null |> unbox<string>
            v745
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v746 : string = null |> unbox<string>
            v746
#endif
            
#if FABLE_COMPILER_PYTHON
            let v747 : string = null |> unbox<string>
            v747
#endif
            
#else
            let v748 : string = System.Text.RegularExpressions.Regex.Replace (v485, v218, v197)
            v748
#endif
            |> fun x -> _v733 <- Some x
            let v749 : string = _v733.Value
            let v750 : string = $"{v749.[0] |> string |> _.ToLower()}{v749.[1..]}"
            let v751 : string = v750.Replace (v199, v200)
            let v752 : string option = None
            let v753 : System.Threading.CancellationToken option = None
            let v754 : (struct (string * string) []) = [||]
            let v755 : (struct (bool * string * int32) -> Async<unit>) option = None
            let v756 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
            let v757 : string = $"pwsh -c \"(Get-FileHash \\\"{v751}\\\" -Algorithm SHA256).Hash\""
            let v758 : struct (int32 * string) option = None
            let v759 : bool = true in let mutable _v758 = v758
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v760 : string = method38(v753, v757, v754, v755, v756, v752)
            let struct (v761 : string, v762 : string) = method39()
            let v763 : int32 = v760.Length
            let v764 : (char []) = Array.zeroCreate<char> (v763)
            let v765 : Mut5 = {l0 = 0} : Mut5
            while method26(v763, v765) do
                let v767 : int32 = v765.l0
                let v768 : char = v760.[int v767]
                v764.[int v767] <- v768
                let v769 : int32 = v767 + 1
                v765.l0 <- v769
                ()
            let v770 : ((char []) -> char list) = Array.toList
            let v771 : char list = v770 v764
            let v772 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v773 : (char -> (UH0 -> UH0)) = method40()
            let v774 : (char list -> (UH0 -> UH0)) = v772 v773
            let v775 : (UH0 -> UH0) = v774 v771
            let v776 : UH0 = UH0_0
            let v777 : UH0 = v775 v776
            let v778 : US8 = US8_0
            let struct (v779 : string, v780 : string) = method41(v762, v761, v777, v778)
            let v781 : (string []) = method42(v780)
            let v782 : string = "$0.to_vec()"
            let v783 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v781 v782
            let v784 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v785 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v783, v277) v784
            let v786 : US0 = US0_1
            let v787 : (unit -> string) = closure29(v753, v757, v754, v755, v756, v752, v779, v785)
            let v788 : (unit -> string) = method47()
            method3(v786, v787, v788)
            let v789 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v753, v757, v754, v755, v756, v752, v779, v785)
            let v790 : string = "futures_lite::future::block_on($0)"
            let v791 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v789 v790
            let (a, b) = v791
            let v792 : int32 = a
            let v793 : string = b
            struct (v792, v793)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v794 : int32, v795 : string) = null |> unbox<struct (int32 * string)>
            struct (v794, v795)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v796 : int32, v797 : string) = null |> unbox<struct (int32 * string)>
            struct (v796, v797)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v798 : int32, v799 : string) = null |> unbox<struct (int32 * string)>
            struct (v798, v799)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v800 : int32, v801 : string) = null |> unbox<struct (int32 * string)>
            struct (v800, v801)
#endif
            
#else
            let v802 : Async<struct (int32 * string)> option = None
            let v803 : bool = true in let mutable _v802 = v802
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v804 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v804
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v805 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v805
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v806 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v806
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v807 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v807
#endif
            
#if FABLE_COMPILER_PYTHON
            let v808 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v808
#endif
            
#else
            let v809 : Async<struct (int32 * string)> option = None
            let v810 : bool = true in let mutable _v809 = v809
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v811 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v811
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v812 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v812
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v813 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v813
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v814 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v814
#endif
            
#if FABLE_COMPILER_PYTHON
            let v815 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v815
#endif
            
#else
            let v816 : Async<struct (int32 * string)> option = None
            let mutable _v816 = v816
            async {
            let struct (v817 : string, v818 : string) = method39()
            let v819 : int32 = v757.Length
            let v820 : (char []) = Array.zeroCreate<char> (v819)
            let v821 : Mut5 = {l0 = 0} : Mut5
            while method26(v819, v821) do
                let v823 : int32 = v821.l0
                let v824 : char = v757.[int v823]
                v820.[int v823] <- v824
                let v825 : int32 = v823 + 1
                v821.l0 <- v825
                ()
            let v826 : ((char []) -> char list) = Array.toList
            let v827 : char list = v826 v820
            let v828 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v829 : (char -> (UH0 -> UH0)) = method40()
            let v830 : (char list -> (UH0 -> UH0)) = v828 v829
            let v831 : (UH0 -> UH0) = v830 v827
            let v832 : UH0 = UH0_0
            let v833 : UH0 = v831 v832
            let v834 : US8 = US8_0
            let struct (v835 : string, v836 : string) = method41(v818, v817, v833, v834)
            let v837 : (string -> US4) = method19()
            let v838 : US4 = US4_1
            let v839 : US4 = v752 |> Option.map v837 |> Option.defaultValue v838 
            let v842 : string =
                match v839 with
                | US4_1 -> (* None *)
                    v197
                | US4_0(v840) -> (* Some *)
                    v840
            let v843 : US0 = US0_1
            let v844 : (unit -> string) = closure48(v753, v757, v754, v755, v756, v752)
            let v845 : (unit -> string) = method47()
            method3(v843, v844, v845)
            let v846 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v847 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v836, StandardOutputEncoding = v846, WorkingDirectory = v842, FileName = v835, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v848 : int32 = v754.Length
            let v849 : Mut5 = {l0 = 0} : Mut5
            while method26(v848, v849) do
                let v851 : int32 = v849.l0
                let struct (v852 : string, v853 : string) = v754.[int v851]
                v847.EnvironmentVariables.[v852] <- v853 
                let v854 : int32 = v851 + 1
                v849.l0 <- v854
                ()
            let v855 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v847)
            use v855 = v855 
            let v856 : System.Diagnostics.Process = v855 
            let v857 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v858 : System.Collections.Concurrent.ConcurrentStack<string> = v857 ()
            let v859 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v753, v757, v754, v755, v756, v752, v856, v858)
            v856.OutputDataReceived.Add v859 
            let v860 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v753, v757, v754, v755, v756, v752, v856, v858)
            v856.ErrorDataReceived.Add v860 
            let v861 : (unit -> bool) = v856.Start
            let v862 : bool = v861 ()
            let v863 : bool = v862 = false
            if v863 then
                let v864 : string = $"execute_with_options_async / process_start error"
                failwith<unit> v864
            let v865 : (unit -> unit) = v856.BeginErrorReadLine
            v865 ()
            let v866 : (unit -> unit) = v856.BeginOutputReadLine
            v866 ()
            let v867 : (System.Threading.CancellationToken -> US18) = method70()
            let v868 : US18 = US18_1
            let v869 : US18 = v753 |> Option.map v867 |> Option.defaultValue v868 
            let v873 : System.Threading.CancellationToken =
                match v869 with
                | US18_1 -> (* None *)
                    let v871 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v871
                | US18_0(v870) -> (* Some *)
                    v870
            let v874 : Async<System.Threading.CancellationToken> option = None
            let v875 : bool = true in let mutable _v874 = v874
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v876 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v876
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v877 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v877
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v878 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v878
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v879 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v879
#endif
            
#if FABLE_COMPILER_PYTHON
            let v880 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v880
#endif
            
#else
            let v881 : Async<System.Threading.CancellationToken> option = None
            let v882 : bool = true in let mutable _v881 = v881
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v883 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v883
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v884 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v884
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v885 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v885
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v886 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v886
#endif
            
#if FABLE_COMPILER_PYTHON
            let v887 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v887
#endif
            
#else
            let v888 : Async<System.Threading.CancellationToken> option = None
            let mutable _v888 = v888
            async {
            let v889 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v889 = v889 
            let v890 : System.Threading.CancellationToken = v889 
            let v891 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v892 : (System.Threading.CancellationToken []) = [|v890; v891; v873|]
            let v893 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v894 : System.Threading.CancellationTokenSource = v893 v892
            let v895 : System.Threading.CancellationToken = v894.Token
            return v895 
            }
            |> fun x -> _v888 <- Some x
            let v896 : Async<System.Threading.CancellationToken> = _v888 |> Option.get
            v896
#endif
            |> fun x -> _v881 <- Some x
            let v897 : Async<System.Threading.CancellationToken> = _v881.Value
            v897
#endif
            |> fun x -> _v874 <- Some x
            let v898 : Async<System.Threading.CancellationToken> = _v874.Value
            let! v898 = v898 
            let v899 : System.Threading.CancellationToken = v898 
            let v900 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v899.Register
            let v901 : (unit -> unit) = closure54(v856)
            let v902 : System.Threading.CancellationTokenRegistration = v900 v901
            use v902 = v902 
            let v903 : System.Threading.CancellationTokenRegistration = v902 
            let v904 : Async<int32> option = None
            let v905 : bool = true in let mutable _v904 = v904
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v906 : Async<int32> = null |> unbox<Async<int32>>
            v906
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v907 : Async<int32> = null |> unbox<Async<int32>>
            v907
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v908 : Async<int32> = null |> unbox<Async<int32>>
            v908
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v909 : Async<int32> = null |> unbox<Async<int32>>
            v909
#endif
            
#if FABLE_COMPILER_PYTHON
            let v910 : Async<int32> = null |> unbox<Async<int32>>
            v910
#endif
            
#else
            let v911 : Async<int32> option = None
            let mutable _v911 = v911
            async {
            try
            let v912 : System.Threading.Tasks.Task = v856.WaitForExitAsync v899 
            let v913 : Async<unit> option = None
            let v914 : bool = true in let mutable _v913 = v913
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v915 : Async<unit> = null |> unbox<Async<unit>>
            v915
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v916 : Async<unit> = null |> unbox<Async<unit>>
            v916
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v917 : Async<unit> = null |> unbox<Async<unit>>
            v917
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v918 : Async<unit> = null |> unbox<Async<unit>>
            v918
#endif
            
#if FABLE_COMPILER_PYTHON
            let v919 : Async<unit> = null |> unbox<Async<unit>>
            v919
#endif
            
#else
            let v920 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v921 : Async<unit> = v920 v912
            v921
#endif
            |> fun x -> _v913 <- Some x
            let v922 : Async<unit> = _v913.Value
            do! v922 
            let v923 : int32 = v856.ExitCode
            return v923 
            with ex ->
            let v924 : exn = ex
            let v925 : string option = None
            let v926 : bool = true in let mutable _v925 = v925
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v927 : string = $"%A{v924}"
            v927
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v928 : string = $"%A{v924}"
            v928
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v929 : string = $"%A{v924}"
            v929
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v930 : string = $"%A{v924}"
            v930
#endif
            
#if FABLE_COMPILER_PYTHON
            let v931 : string = $"%A{v924}"
            v931
#endif
            
#else
            let v932 : string = $"{v924.GetType ()}: {v924.Message}"
            v932
#endif
            |> fun x -> _v925 <- Some x
            let v933 : string = _v925.Value
            let v934 : (string -> unit) = v858.Push
            v934 v933
            let v935 : System.Threading.Tasks.TaskCanceledException = v924 |> unbox<System.Threading.Tasks.TaskCanceledException>
            let v936 : US0 = US0_3
            let v937 : (unit -> string) = closure55(v935)
            let v938 : (unit -> string) = method47()
            method3(v936, v937, v938)
            return -2147483648 
            (*
            *)
            }
            |> fun x -> _v911 <- Some x
            let v939 : Async<int32> = _v911 |> Option.get
            v939
#endif
            |> fun x -> _v904 <- Some x
            let v940 : Async<int32> = _v904.Value
            let! v940 = v940 
            let v941 : int32 = v940 
            let v942 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v943 : string seq = v942 v858
            let v944 : string = method71()
            let v945 : (string -> (string seq -> string)) = String.concat
            let v946 : (string seq -> string) = v945 v944
            let v947 : string = v946 v943
            let v948 : US0 = US0_1
            let v949 : (unit -> string) = closure56(v941, v947)
            let v950 : (unit -> string) = method47()
            method3(v948, v949, v950)
            return struct (v941, v947) 
            }
            |> fun x -> _v816 <- Some x
            let v951 : Async<struct (int32 * string)> = _v816 |> Option.get
            v951
#endif
            |> fun x -> _v809 <- Some x
            let v952 : Async<struct (int32 * string)> = _v809.Value
            v952
#endif
            |> fun x -> _v802 <- Some x
            let v953 : Async<struct (int32 * string)> = _v802.Value
            let v954 : struct (int32 * string) option = None
            let v955 : bool = true in let mutable _v954 = v954
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v956 : int32, v957 : string) = null |> unbox<struct (int32 * string)>
            struct (v956, v957)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v958 : int32, v959 : string) = null |> unbox<struct (int32 * string)>
            struct (v958, v959)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v960 : int32, v961 : string) = null |> unbox<struct (int32 * string)>
            struct (v960, v961)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v962 : int32, v963 : string) = null |> unbox<struct (int32 * string)>
            struct (v962, v963)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v964 : int32, v965 : string) = null |> unbox<struct (int32 * string)>
            struct (v964, v965)
#endif
            
#else
            let v966 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
            let struct (v967 : int32, v968 : string) = v966 v953
            struct (v967, v968)
#endif
            |> fun x -> _v954 <- Some x
            let struct (v969 : int32, v970 : string) = _v954.Value
            struct (v969, v970)
#endif
            |> fun x -> _v758 <- Some x
            let struct (v971 : int32, v972 : string) = _v758.Value
            let v973 : bool = v971 = 0
            let v976 : US20 =
                if v973 then
                    US20_0(v972)
                else
                    US20_1(v972)
            let v982 : string =
                match v976 with
                | US20_1(v978) -> (* Error *)
                    let v979 : string = $"resultm.get / Result value was Error: {v978}"
                    failwith<string> v979
                | US20_0(v977) -> (* Ok *)
                    v977
            let v983 : bool option = None
            let v984 : bool = true in let mutable _v983 = v983
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v985 : string = method14(v727)
            let v986 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v987 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v985 v986
            let v988 : string = "String::from($0)"
            let v989 : std_string_String = Fable.Core.RustInterop.emitRustExpr v987 v988
            let v990 : string = "std::path::PathBuf::from($0)"
            let v991 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v989 v990
            let v992 : string = "$0.exists()"
            let v993 : bool = Fable.Core.RustInterop.emitRustExpr v991 v992
            let v996 : bool =
                if v993 then
                    let v994 : string = "$0.is_file()"
                    let v995 : bool = Fable.Core.RustInterop.emitRustExpr v991 v994
                    v995
                else
                    false
            v996
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v997 : bool = null |> unbox<bool>
            v997
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v998 : bool = null |> unbox<bool>
            v998
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v999 : string = "fs"
            let v1000 : IFsExistsSync = Fable.Core.JsInterop.importAll v999
            let v1001 : string = "v1000.existsSync($0)"
            let v1002 : bool = Fable.Core.JsInterop.emitJsExpr v727 v1001
            v1002
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1003 : bool = null |> unbox<bool>
            v1003
#endif
            
#else
            let v1004 : (string -> bool) = System.IO.File.Exists
            let v1005 : bool = v1004 v727
            v1005
#endif
            |> fun x -> _v983 <- Some x
            let v1006 : bool = _v983.Value
            let v1258 : US4 =
                if v1006 then
                    let v1007 : string option = None
                    let v1008 : bool = true in let mutable _v1007 = v1007
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1009 : string = method22()
                    let v1010 : string = method23(v727)
                    let v1011 : string = method24()
                    let v1012 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v1013 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1009, v1010, v1011) v1012
                    let v1014 : string = "String::from($0)"
                    let v1015 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1013 v1014
                    let v1016 : string = "fable_library_rust::String_::fromString($0)"
                    let v1017 : string = Fable.Core.RustInterop.emitRustExpr v1015 v1016
                    v1017
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1018 : string = null |> unbox<string>
                    v1018
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1019 : string = null |> unbox<string>
                    v1019
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1020 : string = null |> unbox<string>
                    v1020
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1021 : string = null |> unbox<string>
                    v1021
#endif
                    
#else
                    let v1022 : string = System.Text.RegularExpressions.Regex.Replace (v727, v218, v197)
                    v1022
#endif
                    |> fun x -> _v1007 <- Some x
                    let v1023 : string = _v1007.Value
                    let v1024 : string = $"{v1023.[0] |> string |> _.ToLower()}{v1023.[1..]}"
                    let v1025 : string = v1024.Replace (v199, v200)
                    let v1026 : string option = None
                    let v1027 : System.Threading.CancellationToken option = None
                    let v1028 : (struct (string * string) []) = [||]
                    let v1029 : (struct (bool * string * int32) -> Async<unit>) option = None
                    let v1030 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                    let v1031 : string = $"pwsh -c \"(Get-FileHash \\\"{v1025}\\\" -Algorithm SHA256).Hash\""
                    let v1032 : struct (int32 * string) option = None
                    let v1033 : bool = true in let mutable _v1032 = v1032
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1034 : string = method38(v1027, v1031, v1028, v1029, v1030, v1026)
                    let struct (v1035 : string, v1036 : string) = method39()
                    let v1037 : int32 = v1034.Length
                    let v1038 : (char []) = Array.zeroCreate<char> (v1037)
                    let v1039 : Mut5 = {l0 = 0} : Mut5
                    while method26(v1037, v1039) do
                        let v1041 : int32 = v1039.l0
                        let v1042 : char = v1034.[int v1041]
                        v1038.[int v1041] <- v1042
                        let v1043 : int32 = v1041 + 1
                        v1039.l0 <- v1043
                        ()
                    let v1044 : ((char []) -> char list) = Array.toList
                    let v1045 : char list = v1044 v1038
                    let v1046 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                    let v1047 : (char -> (UH0 -> UH0)) = method40()
                    let v1048 : (char list -> (UH0 -> UH0)) = v1046 v1047
                    let v1049 : (UH0 -> UH0) = v1048 v1045
                    let v1050 : UH0 = UH0_0
                    let v1051 : UH0 = v1049 v1050
                    let v1052 : US8 = US8_0
                    let struct (v1053 : string, v1054 : string) = method41(v1036, v1035, v1051, v1052)
                    let v1055 : (string []) = method42(v1054)
                    let v1056 : string = "$0.to_vec()"
                    let v1057 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v1055 v1056
                    let v1058 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                    let v1059 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1057, v277) v1058
                    let v1060 : US0 = US0_1
                    let v1061 : (unit -> string) = closure29(v1027, v1031, v1028, v1029, v1030, v1026, v1053, v1059)
                    let v1062 : (unit -> string) = method47()
                    method3(v1060, v1061, v1062)
                    let v1063 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v1027, v1031, v1028, v1029, v1030, v1026, v1053, v1059)
                    let v1064 : string = "futures_lite::future::block_on($0)"
                    let v1065 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v1063 v1064
                    let (a, b) = v1065
                    let v1066 : int32 = a
                    let v1067 : string = b
                    struct (v1066, v1067)
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let struct (v1068 : int32, v1069 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1068, v1069)
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let struct (v1070 : int32, v1071 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1070, v1071)
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let struct (v1072 : int32, v1073 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1072, v1073)
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let struct (v1074 : int32, v1075 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1074, v1075)
#endif
                    
#else
                    let v1076 : Async<struct (int32 * string)> option = None
                    let v1077 : bool = true in let mutable _v1076 = v1076
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1078 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1078
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1079 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1079
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1080 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1080
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1081 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1081
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1082 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1082
#endif
                    
#else
                    let v1083 : Async<struct (int32 * string)> option = None
                    let v1084 : bool = true in let mutable _v1083 = v1083
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1085 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1085
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1086 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1086
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1087 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1087
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1088 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1088
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1089 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1089
#endif
                    
#else
                    let v1090 : Async<struct (int32 * string)> option = None
                    let mutable _v1090 = v1090
                    async {
                    let struct (v1091 : string, v1092 : string) = method39()
                    let v1093 : int32 = v1031.Length
                    let v1094 : (char []) = Array.zeroCreate<char> (v1093)
                    let v1095 : Mut5 = {l0 = 0} : Mut5
                    while method26(v1093, v1095) do
                        let v1097 : int32 = v1095.l0
                        let v1098 : char = v1031.[int v1097]
                        v1094.[int v1097] <- v1098
                        let v1099 : int32 = v1097 + 1
                        v1095.l0 <- v1099
                        ()
                    let v1100 : ((char []) -> char list) = Array.toList
                    let v1101 : char list = v1100 v1094
                    let v1102 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                    let v1103 : (char -> (UH0 -> UH0)) = method40()
                    let v1104 : (char list -> (UH0 -> UH0)) = v1102 v1103
                    let v1105 : (UH0 -> UH0) = v1104 v1101
                    let v1106 : UH0 = UH0_0
                    let v1107 : UH0 = v1105 v1106
                    let v1108 : US8 = US8_0
                    let struct (v1109 : string, v1110 : string) = method41(v1092, v1091, v1107, v1108)
                    let v1111 : (string -> US4) = method19()
                    let v1112 : US4 = US4_1
                    let v1113 : US4 = v1026 |> Option.map v1111 |> Option.defaultValue v1112 
                    let v1116 : string =
                        match v1113 with
                        | US4_1 -> (* None *)
                            v197
                        | US4_0(v1114) -> (* Some *)
                            v1114
                    let v1117 : US0 = US0_1
                    let v1118 : (unit -> string) = closure48(v1027, v1031, v1028, v1029, v1030, v1026)
                    let v1119 : (unit -> string) = method47()
                    method3(v1117, v1118, v1119)
                    let v1120 : System.Text.Encoding = System.Text.Encoding.UTF8
                    let v1121 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v1110, StandardOutputEncoding = v1120, WorkingDirectory = v1116, FileName = v1109, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                    let v1122 : int32 = v1028.Length
                    let v1123 : Mut5 = {l0 = 0} : Mut5
                    while method26(v1122, v1123) do
                        let v1125 : int32 = v1123.l0
                        let struct (v1126 : string, v1127 : string) = v1028.[int v1125]
                        v1121.EnvironmentVariables.[v1126] <- v1127 
                        let v1128 : int32 = v1125 + 1
                        v1123.l0 <- v1128
                        ()
                    let v1129 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1121)
                    use v1129 = v1129 
                    let v1130 : System.Diagnostics.Process = v1129 
                    let v1131 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                    let v1132 : System.Collections.Concurrent.ConcurrentStack<string> = v1131 ()
                    let v1133 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v1027, v1031, v1028, v1029, v1030, v1026, v1130, v1132)
                    v1130.OutputDataReceived.Add v1133 
                    let v1134 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v1027, v1031, v1028, v1029, v1030, v1026, v1130, v1132)
                    v1130.ErrorDataReceived.Add v1134 
                    let v1135 : (unit -> bool) = v1130.Start
                    let v1136 : bool = v1135 ()
                    let v1137 : bool = v1136 = false
                    if v1137 then
                        let v1138 : string = $"execute_with_options_async / process_start error"
                        failwith<unit> v1138
                    let v1139 : (unit -> unit) = v1130.BeginErrorReadLine
                    v1139 ()
                    let v1140 : (unit -> unit) = v1130.BeginOutputReadLine
                    v1140 ()
                    let v1141 : (System.Threading.CancellationToken -> US18) = method70()
                    let v1142 : US18 = US18_1
                    let v1143 : US18 = v1027 |> Option.map v1141 |> Option.defaultValue v1142 
                    let v1147 : System.Threading.CancellationToken =
                        match v1143 with
                        | US18_1 -> (* None *)
                            let v1145 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                            v1145
                        | US18_0(v1144) -> (* Some *)
                            v1144
                    let v1148 : Async<System.Threading.CancellationToken> option = None
                    let v1149 : bool = true in let mutable _v1148 = v1148
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1150 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1150
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1151 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1151
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1152 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1152
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1153 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1153
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1154 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1154
#endif
                    
#else
                    let v1155 : Async<System.Threading.CancellationToken> option = None
                    let v1156 : bool = true in let mutable _v1155 = v1155
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1157 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1157
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1158 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1158
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1159 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1159
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1160 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1160
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1161 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1161
#endif
                    
#else
                    let v1162 : Async<System.Threading.CancellationToken> option = None
                    let mutable _v1162 = v1162
                    async {
                    let v1163 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v1163 = v1163 
                    let v1164 : System.Threading.CancellationToken = v1163 
                    let v1165 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v1166 : (System.Threading.CancellationToken []) = [|v1164; v1165; v1147|]
                    let v1167 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v1168 : System.Threading.CancellationTokenSource = v1167 v1166
                    let v1169 : System.Threading.CancellationToken = v1168.Token
                    return v1169 
                    }
                    |> fun x -> _v1162 <- Some x
                    let v1170 : Async<System.Threading.CancellationToken> = _v1162 |> Option.get
                    v1170
#endif
                    |> fun x -> _v1155 <- Some x
                    let v1171 : Async<System.Threading.CancellationToken> = _v1155.Value
                    v1171
#endif
                    |> fun x -> _v1148 <- Some x
                    let v1172 : Async<System.Threading.CancellationToken> = _v1148.Value
                    let! v1172 = v1172 
                    let v1173 : System.Threading.CancellationToken = v1172 
                    let v1174 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1173.Register
                    let v1175 : (unit -> unit) = closure54(v1130)
                    let v1176 : System.Threading.CancellationTokenRegistration = v1174 v1175
                    use v1176 = v1176 
                    let v1177 : System.Threading.CancellationTokenRegistration = v1176 
                    let v1178 : Async<int32> option = None
                    let v1179 : bool = true in let mutable _v1178 = v1178
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1180 : Async<int32> = null |> unbox<Async<int32>>
                    v1180
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1181 : Async<int32> = null |> unbox<Async<int32>>
                    v1181
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1182 : Async<int32> = null |> unbox<Async<int32>>
                    v1182
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1183 : Async<int32> = null |> unbox<Async<int32>>
                    v1183
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1184 : Async<int32> = null |> unbox<Async<int32>>
                    v1184
#endif
                    
#else
                    let v1185 : Async<int32> option = None
                    let mutable _v1185 = v1185
                    async {
                    try
                    let v1186 : System.Threading.Tasks.Task = v1130.WaitForExitAsync v1173 
                    let v1187 : Async<unit> option = None
                    let v1188 : bool = true in let mutable _v1187 = v1187
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1189 : Async<unit> = null |> unbox<Async<unit>>
                    v1189
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1190 : Async<unit> = null |> unbox<Async<unit>>
                    v1190
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1191 : Async<unit> = null |> unbox<Async<unit>>
                    v1191
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1192 : Async<unit> = null |> unbox<Async<unit>>
                    v1192
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1193 : Async<unit> = null |> unbox<Async<unit>>
                    v1193
#endif
                    
#else
                    let v1194 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1195 : Async<unit> = v1194 v1186
                    v1195
#endif
                    |> fun x -> _v1187 <- Some x
                    let v1196 : Async<unit> = _v1187.Value
                    do! v1196 
                    let v1197 : int32 = v1130.ExitCode
                    return v1197 
                    with ex ->
                    let v1198 : exn = ex
                    let v1199 : string option = None
                    let v1200 : bool = true in let mutable _v1199 = v1199
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1201 : string = $"%A{v1198}"
                    v1201
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1202 : string = $"%A{v1198}"
                    v1202
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1203 : string = $"%A{v1198}"
                    v1203
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1204 : string = $"%A{v1198}"
                    v1204
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1205 : string = $"%A{v1198}"
                    v1205
#endif
                    
#else
                    let v1206 : string = $"{v1198.GetType ()}: {v1198.Message}"
                    v1206
#endif
                    |> fun x -> _v1199 <- Some x
                    let v1207 : string = _v1199.Value
                    let v1208 : (string -> unit) = v1132.Push
                    v1208 v1207
                    let v1209 : System.Threading.Tasks.TaskCanceledException = v1198 |> unbox<System.Threading.Tasks.TaskCanceledException>
                    let v1210 : US0 = US0_3
                    let v1211 : (unit -> string) = closure55(v1209)
                    let v1212 : (unit -> string) = method47()
                    method3(v1210, v1211, v1212)
                    return -2147483648 
                    (*
                    *)
                    }
                    |> fun x -> _v1185 <- Some x
                    let v1213 : Async<int32> = _v1185 |> Option.get
                    v1213
#endif
                    |> fun x -> _v1178 <- Some x
                    let v1214 : Async<int32> = _v1178.Value
                    let! v1214 = v1214 
                    let v1215 : int32 = v1214 
                    let v1216 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                    let v1217 : string seq = v1216 v1132
                    let v1218 : string = method71()
                    let v1219 : (string -> (string seq -> string)) = String.concat
                    let v1220 : (string seq -> string) = v1219 v1218
                    let v1221 : string = v1220 v1217
                    let v1222 : US0 = US0_1
                    let v1223 : (unit -> string) = closure56(v1215, v1221)
                    let v1224 : (unit -> string) = method47()
                    method3(v1222, v1223, v1224)
                    return struct (v1215, v1221) 
                    }
                    |> fun x -> _v1090 <- Some x
                    let v1225 : Async<struct (int32 * string)> = _v1090 |> Option.get
                    v1225
#endif
                    |> fun x -> _v1083 <- Some x
                    let v1226 : Async<struct (int32 * string)> = _v1083.Value
                    v1226
#endif
                    |> fun x -> _v1076 <- Some x
                    let v1227 : Async<struct (int32 * string)> = _v1076.Value
                    let v1228 : struct (int32 * string) option = None
                    let v1229 : bool = true in let mutable _v1228 = v1228
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let struct (v1230 : int32, v1231 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1230, v1231)
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let struct (v1232 : int32, v1233 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1232, v1233)
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let struct (v1234 : int32, v1235 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1234, v1235)
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let struct (v1236 : int32, v1237 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1236, v1237)
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let struct (v1238 : int32, v1239 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1238, v1239)
#endif
                    
#else
                    let v1240 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                    let struct (v1241 : int32, v1242 : string) = v1240 v1227
                    struct (v1241, v1242)
#endif
                    |> fun x -> _v1228 <- Some x
                    let struct (v1243 : int32, v1244 : string) = _v1228.Value
                    struct (v1243, v1244)
#endif
                    |> fun x -> _v1032 <- Some x
                    let struct (v1245 : int32, v1246 : string) = _v1032.Value
                    let v1247 : bool = v1245 = 0
                    let v1250 : US20 =
                        if v1247 then
                            US20_0(v1246)
                        else
                            US20_1(v1246)
                    match v1250 with
                    | US20_1(v1253) -> (* Error *)
                        US4_1
                    | US20_0(v1251) -> (* Ok *)
                        US4_0(v1251)
                else
                    US4_1
            let v1260 : bool =
                match v1258 with
                | US4_1 -> (* None *)
                    true
                | _ ->
                    false
            let v1266 : bool =
                if v1260 then
                    true
                else
                    let v1264 : string =
                        match v1258 with
                        | US4_1 -> (* None *)
                            failwith<string> "Option does not have a value."
                        | US4_0(v1261) -> (* Some *)
                            v1261
                    let v1265 : bool = v982 <> v1264
                    v1265
            if v1266 then
                let v1267 : US0 = US0_2
                let v1268 : (unit -> string) = closure57()
                let v1269 : (unit -> string) = closure58(v202, v222, v242, v465, v464, v485, v707, v706, v727, v982, v1258)
                method3(v1267, v1268, v1269)
                let v1270 : unit option = None
                let v1271 : bool = true in let mutable _v1270 = v1270
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1272 : string = method73(v727)
                let v1273 : string = "std::fs::copy(&*$0, &*v1272)"
                let v1274 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v485 v1273
                let v1275 : string = "$0.unwrap()"
                let v1276 : uint64 = Fable.Core.RustInterop.emitRustExpr v1274 v1275
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
                System.IO.File.Copy (v485, v727, true)
                ()
#endif
                |> fun x -> _v1270 <- Some x
                _v1270.Value
                let v1277 : (string -> (string -> US19)) = closure59(v4, v3, v1, v0)
                let v1278 : UH3 = UH3_0
                let v1279 : UH3 = UH3_1(v728, v485, v1277, v1278)
                let v1280 : string = "html"
                let v1281 : (string -> (string -> US19)) = closure66(v4, v3)
                let v1282 : string = "pdf"
                let v1283 : string = "epub"
                let v1284 : UH3 = UH3_0
                let v1285 : UH3 = UH3_1(v1283, v730, v1281, v1284)
                let v1286 : UH3 = UH3_1(v1282, v730, v1281, v1285)
                let v1287 : UH3 = UH3_1(v1280, v730, v1281, v1286)
                let v1288 : UH3 = UH3_1(v1283, v485, v1281, v1287)
                let v1289 : UH3 = UH3_1(v1282, v485, v1281, v1288)
                let v1290 : UH3 = UH3_1(v1280, v485, v1281, v1289)
                let v1291 : UH2 = UH2_0
                let v1292 : UH2 = UH2_1(v1290, v1291)
                UH2_1(v1279, v1292)
            else
                UH2_0
        else
            UH2_0
    let v1299 : bool =
        match v1297 with
        | UH2_0 -> (* Nil *)
            true
        | _ ->
            false
    let v1300 : bool = v1299 <> true
    let v1760 : UH2 =
        if v1300 then
            v1297
        else
            let v1301 : string = "epub"
            let struct (v1302 : string, v1303 : string) = method72(v1301, v730, v4)
            let v1304 : bool option = None
            let v1305 : bool = true in let mutable _v1304 = v1304
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1306 : string = method14(v1303)
            let v1307 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1308 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1306 v1307
            let v1309 : string = "String::from($0)"
            let v1310 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1308 v1309
            let v1311 : string = "std::path::PathBuf::from($0)"
            let v1312 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1310 v1311
            let v1313 : string = "$0.exists()"
            let v1314 : bool = Fable.Core.RustInterop.emitRustExpr v1312 v1313
            let v1317 : bool =
                if v1314 then
                    let v1315 : string = "$0.is_file()"
                    let v1316 : bool = Fable.Core.RustInterop.emitRustExpr v1312 v1315
                    v1316
                else
                    false
            v1317
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1318 : bool = null |> unbox<bool>
            v1318
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1319 : bool = null |> unbox<bool>
            v1319
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1320 : string = "fs"
            let v1321 : IFsExistsSync = Fable.Core.JsInterop.importAll v1320
            let v1322 : string = "v1321.existsSync($0)"
            let v1323 : bool = Fable.Core.JsInterop.emitJsExpr v1303 v1322
            v1323
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1324 : bool = null |> unbox<bool>
            v1324
#endif
            
#else
            let v1325 : (string -> bool) = System.IO.File.Exists
            let v1326 : bool = v1325 v1303
            v1326
#endif
            |> fun x -> _v1304 <- Some x
            let v1327 : bool = _v1304.Value
            let v1328 : bool = v1327 = false
            let v1363 : bool =
                if v1328 then
                    let v1329 : bool option = None
                    let v1330 : bool = true in let mutable _v1329 = v1329
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1331 : string = method14(v1302)
                    let v1332 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v1333 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1331 v1332
                    let v1334 : string = "String::from($0)"
                    let v1335 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1333 v1334
                    let v1336 : string = "std::path::PathBuf::from($0)"
                    let v1337 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1335 v1336
                    let v1338 : string = "$0.exists()"
                    let v1339 : bool = Fable.Core.RustInterop.emitRustExpr v1337 v1338
                    let v1342 : bool =
                        if v1339 then
                            let v1340 : string = "$0.is_file()"
                            let v1341 : bool = Fable.Core.RustInterop.emitRustExpr v1337 v1340
                            v1341
                        else
                            false
                    v1342
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1343 : bool = null |> unbox<bool>
                    v1343
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1344 : bool = null |> unbox<bool>
                    v1344
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1345 : IFsExistsSync = Fable.Core.JsInterop.importAll v1320
                    let v1346 : string = "v1345.existsSync($0)"
                    let v1347 : bool = Fable.Core.JsInterop.emitJsExpr v1302 v1346
                    v1347
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1348 : bool = null |> unbox<bool>
                    v1348
#endif
                    
#else
                    let v1349 : (string -> bool) = System.IO.File.Exists
                    let v1350 : bool = v1349 v1302
                    v1350
#endif
                    |> fun x -> _v1329 <- Some x
                    let v1351 : bool = _v1329.Value
                    if v1351 then
                        let v1352 : US0 = US0_2
                        let v1353 : (unit -> string) = closure70()
                        let v1354 : (unit -> string) = closure71(v1302, v1303)
                        method3(v1352, v1353, v1354)
                        let v1355 : unit option = None
                        let v1356 : bool = true in let mutable _v1355 = v1355
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1357 : string = method73(v1303)
                        let v1358 : string = "std::fs::copy(&*$0, &*v1357)"
                        let v1359 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1302 v1358
                        let v1360 : string = "$0.unwrap()"
                        let v1361 : uint64 = Fable.Core.RustInterop.emitRustExpr v1359 v1360
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
                        System.IO.File.Copy (v1302, v1303, true)
                        ()
#endif
                        |> fun x -> _v1355 <- Some x
                        _v1355.Value
                        false
                    else
                        true
                else
                    true
            let v1368 : UH3 =
                if v1363 then
                    let v1364 : (string -> (string -> US19)) = closure66(v4, v3)
                    let v1365 : UH3 = UH3_0
                    UH3_1(v1301, v730, v1364, v1365)
                else
                    UH3_0
            let v1369 : string = "pdf"
            let struct (v1370 : string, v1371 : string) = method72(v1369, v730, v4)
            let v1372 : bool option = None
            let v1373 : bool = true in let mutable _v1372 = v1372
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1374 : string = method14(v1371)
            let v1375 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1376 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1374 v1375
            let v1377 : string = "String::from($0)"
            let v1378 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1376 v1377
            let v1379 : string = "std::path::PathBuf::from($0)"
            let v1380 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1378 v1379
            let v1381 : string = "$0.exists()"
            let v1382 : bool = Fable.Core.RustInterop.emitRustExpr v1380 v1381
            let v1385 : bool =
                if v1382 then
                    let v1383 : string = "$0.is_file()"
                    let v1384 : bool = Fable.Core.RustInterop.emitRustExpr v1380 v1383
                    v1384
                else
                    false
            v1385
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1386 : bool = null |> unbox<bool>
            v1386
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1387 : bool = null |> unbox<bool>
            v1387
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1388 : IFsExistsSync = Fable.Core.JsInterop.importAll v1320
            let v1389 : string = "v1388.existsSync($0)"
            let v1390 : bool = Fable.Core.JsInterop.emitJsExpr v1371 v1389
            v1390
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1391 : bool = null |> unbox<bool>
            v1391
#endif
            
#else
            let v1392 : (string -> bool) = System.IO.File.Exists
            let v1393 : bool = v1392 v1371
            v1393
#endif
            |> fun x -> _v1372 <- Some x
            let v1394 : bool = _v1372.Value
            let v1395 : bool = v1394 = false
            let v1430 : bool =
                if v1395 then
                    let v1396 : bool option = None
                    let v1397 : bool = true in let mutable _v1396 = v1396
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1398 : string = method14(v1370)
                    let v1399 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v1400 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1398 v1399
                    let v1401 : string = "String::from($0)"
                    let v1402 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1400 v1401
                    let v1403 : string = "std::path::PathBuf::from($0)"
                    let v1404 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1402 v1403
                    let v1405 : string = "$0.exists()"
                    let v1406 : bool = Fable.Core.RustInterop.emitRustExpr v1404 v1405
                    let v1409 : bool =
                        if v1406 then
                            let v1407 : string = "$0.is_file()"
                            let v1408 : bool = Fable.Core.RustInterop.emitRustExpr v1404 v1407
                            v1408
                        else
                            false
                    v1409
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1410 : bool = null |> unbox<bool>
                    v1410
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1411 : bool = null |> unbox<bool>
                    v1411
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1412 : IFsExistsSync = Fable.Core.JsInterop.importAll v1320
                    let v1413 : string = "v1412.existsSync($0)"
                    let v1414 : bool = Fable.Core.JsInterop.emitJsExpr v1370 v1413
                    v1414
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1415 : bool = null |> unbox<bool>
                    v1415
#endif
                    
#else
                    let v1416 : (string -> bool) = System.IO.File.Exists
                    let v1417 : bool = v1416 v1370
                    v1417
#endif
                    |> fun x -> _v1396 <- Some x
                    let v1418 : bool = _v1396.Value
                    if v1418 then
                        let v1419 : US0 = US0_2
                        let v1420 : (unit -> string) = closure70()
                        let v1421 : (unit -> string) = closure71(v1370, v1371)
                        method3(v1419, v1420, v1421)
                        let v1422 : unit option = None
                        let v1423 : bool = true in let mutable _v1422 = v1422
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1424 : string = method73(v1371)
                        let v1425 : string = "std::fs::copy(&*$0, &*v1424)"
                        let v1426 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1370 v1425
                        let v1427 : string = "$0.unwrap()"
                        let v1428 : uint64 = Fable.Core.RustInterop.emitRustExpr v1426 v1427
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
                        System.IO.File.Copy (v1370, v1371, true)
                        ()
#endif
                        |> fun x -> _v1422 <- Some x
                        _v1422.Value
                        false
                    else
                        true
                else
                    true
            let v1433 : UH3 =
                if v1430 then
                    let v1431 : (string -> (string -> US19)) = closure66(v4, v3)
                    UH3_1(v1369, v730, v1431, v1368)
                else
                    v1368
            let v1434 : string = "html"
            let struct (v1435 : string, v1436 : string) = method72(v1434, v730, v4)
            let v1437 : bool option = None
            let v1438 : bool = true in let mutable _v1437 = v1437
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1439 : string = method14(v1436)
            let v1440 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1441 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1439 v1440
            let v1442 : string = "String::from($0)"
            let v1443 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1441 v1442
            let v1444 : string = "std::path::PathBuf::from($0)"
            let v1445 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1443 v1444
            let v1446 : string = "$0.exists()"
            let v1447 : bool = Fable.Core.RustInterop.emitRustExpr v1445 v1446
            let v1450 : bool =
                if v1447 then
                    let v1448 : string = "$0.is_file()"
                    let v1449 : bool = Fable.Core.RustInterop.emitRustExpr v1445 v1448
                    v1449
                else
                    false
            v1450
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1451 : bool = null |> unbox<bool>
            v1451
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1452 : bool = null |> unbox<bool>
            v1452
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1453 : IFsExistsSync = Fable.Core.JsInterop.importAll v1320
            let v1454 : string = "v1453.existsSync($0)"
            let v1455 : bool = Fable.Core.JsInterop.emitJsExpr v1436 v1454
            v1455
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1456 : bool = null |> unbox<bool>
            v1456
#endif
            
#else
            let v1457 : (string -> bool) = System.IO.File.Exists
            let v1458 : bool = v1457 v1436
            v1458
#endif
            |> fun x -> _v1437 <- Some x
            let v1459 : bool = _v1437.Value
            let v1460 : bool = v1459 = false
            let v1495 : bool =
                if v1460 then
                    let v1461 : bool option = None
                    let v1462 : bool = true in let mutable _v1461 = v1461
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1463 : string = method14(v1435)
                    let v1464 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v1465 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1463 v1464
                    let v1466 : string = "String::from($0)"
                    let v1467 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1465 v1466
                    let v1468 : string = "std::path::PathBuf::from($0)"
                    let v1469 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1467 v1468
                    let v1470 : string = "$0.exists()"
                    let v1471 : bool = Fable.Core.RustInterop.emitRustExpr v1469 v1470
                    let v1474 : bool =
                        if v1471 then
                            let v1472 : string = "$0.is_file()"
                            let v1473 : bool = Fable.Core.RustInterop.emitRustExpr v1469 v1472
                            v1473
                        else
                            false
                    v1474
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1475 : bool = null |> unbox<bool>
                    v1475
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1476 : bool = null |> unbox<bool>
                    v1476
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1477 : IFsExistsSync = Fable.Core.JsInterop.importAll v1320
                    let v1478 : string = "v1477.existsSync($0)"
                    let v1479 : bool = Fable.Core.JsInterop.emitJsExpr v1435 v1478
                    v1479
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1480 : bool = null |> unbox<bool>
                    v1480
#endif
                    
#else
                    let v1481 : (string -> bool) = System.IO.File.Exists
                    let v1482 : bool = v1481 v1435
                    v1482
#endif
                    |> fun x -> _v1461 <- Some x
                    let v1483 : bool = _v1461.Value
                    if v1483 then
                        let v1484 : US0 = US0_2
                        let v1485 : (unit -> string) = closure70()
                        let v1486 : (unit -> string) = closure71(v1435, v1436)
                        method3(v1484, v1485, v1486)
                        let v1487 : unit option = None
                        let v1488 : bool = true in let mutable _v1487 = v1487
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1489 : string = method73(v1436)
                        let v1490 : string = "std::fs::copy(&*$0, &*v1489)"
                        let v1491 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1435 v1490
                        let v1492 : string = "$0.unwrap()"
                        let v1493 : uint64 = Fable.Core.RustInterop.emitRustExpr v1491 v1492
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
                        System.IO.File.Copy (v1435, v1436, true)
                        ()
#endif
                        |> fun x -> _v1487 <- Some x
                        _v1487.Value
                        false
                    else
                        true
                else
                    true
            let v1498 : UH3 =
                if v1495 then
                    let v1496 : (string -> (string -> US19)) = closure66(v4, v3)
                    UH3_1(v1434, v730, v1496, v1433)
                else
                    v1433
            let struct (v1499 : string, v1500 : string) = method72(v1301, v485, v4)
            let v1501 : bool option = None
            let v1502 : bool = true in let mutable _v1501 = v1501
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1503 : string = method14(v1500)
            let v1504 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1505 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1503 v1504
            let v1506 : string = "String::from($0)"
            let v1507 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1505 v1506
            let v1508 : string = "std::path::PathBuf::from($0)"
            let v1509 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1507 v1508
            let v1510 : string = "$0.exists()"
            let v1511 : bool = Fable.Core.RustInterop.emitRustExpr v1509 v1510
            let v1514 : bool =
                if v1511 then
                    let v1512 : string = "$0.is_file()"
                    let v1513 : bool = Fable.Core.RustInterop.emitRustExpr v1509 v1512
                    v1513
                else
                    false
            v1514
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1515 : bool = null |> unbox<bool>
            v1515
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1516 : bool = null |> unbox<bool>
            v1516
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1517 : IFsExistsSync = Fable.Core.JsInterop.importAll v1320
            let v1518 : string = "v1517.existsSync($0)"
            let v1519 : bool = Fable.Core.JsInterop.emitJsExpr v1500 v1518
            v1519
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1520 : bool = null |> unbox<bool>
            v1520
#endif
            
#else
            let v1521 : (string -> bool) = System.IO.File.Exists
            let v1522 : bool = v1521 v1500
            v1522
#endif
            |> fun x -> _v1501 <- Some x
            let v1523 : bool = _v1501.Value
            let v1524 : bool = v1523 = false
            let v1559 : bool =
                if v1524 then
                    let v1525 : bool option = None
                    let v1526 : bool = true in let mutable _v1525 = v1525
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1527 : string = method14(v1499)
                    let v1528 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v1529 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1527 v1528
                    let v1530 : string = "String::from($0)"
                    let v1531 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1529 v1530
                    let v1532 : string = "std::path::PathBuf::from($0)"
                    let v1533 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1531 v1532
                    let v1534 : string = "$0.exists()"
                    let v1535 : bool = Fable.Core.RustInterop.emitRustExpr v1533 v1534
                    let v1538 : bool =
                        if v1535 then
                            let v1536 : string = "$0.is_file()"
                            let v1537 : bool = Fable.Core.RustInterop.emitRustExpr v1533 v1536
                            v1537
                        else
                            false
                    v1538
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1539 : bool = null |> unbox<bool>
                    v1539
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1540 : bool = null |> unbox<bool>
                    v1540
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1541 : IFsExistsSync = Fable.Core.JsInterop.importAll v1320
                    let v1542 : string = "v1541.existsSync($0)"
                    let v1543 : bool = Fable.Core.JsInterop.emitJsExpr v1499 v1542
                    v1543
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1544 : bool = null |> unbox<bool>
                    v1544
#endif
                    
#else
                    let v1545 : (string -> bool) = System.IO.File.Exists
                    let v1546 : bool = v1545 v1499
                    v1546
#endif
                    |> fun x -> _v1525 <- Some x
                    let v1547 : bool = _v1525.Value
                    if v1547 then
                        let v1548 : US0 = US0_2
                        let v1549 : (unit -> string) = closure70()
                        let v1550 : (unit -> string) = closure71(v1499, v1500)
                        method3(v1548, v1549, v1550)
                        let v1551 : unit option = None
                        let v1552 : bool = true in let mutable _v1551 = v1551
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1553 : string = method73(v1500)
                        let v1554 : string = "std::fs::copy(&*$0, &*v1553)"
                        let v1555 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1499 v1554
                        let v1556 : string = "$0.unwrap()"
                        let v1557 : uint64 = Fable.Core.RustInterop.emitRustExpr v1555 v1556
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
                        System.IO.File.Copy (v1499, v1500, true)
                        ()
#endif
                        |> fun x -> _v1551 <- Some x
                        _v1551.Value
                        false
                    else
                        true
                else
                    true
            let v1562 : UH3 =
                if v1559 then
                    let v1560 : (string -> (string -> US19)) = closure66(v4, v3)
                    UH3_1(v1301, v485, v1560, v1498)
                else
                    v1498
            let struct (v1563 : string, v1564 : string) = method72(v1369, v485, v4)
            let v1565 : bool option = None
            let v1566 : bool = true in let mutable _v1565 = v1565
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1567 : string = method14(v1564)
            let v1568 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1569 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1567 v1568
            let v1570 : string = "String::from($0)"
            let v1571 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1569 v1570
            let v1572 : string = "std::path::PathBuf::from($0)"
            let v1573 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1571 v1572
            let v1574 : string = "$0.exists()"
            let v1575 : bool = Fable.Core.RustInterop.emitRustExpr v1573 v1574
            let v1578 : bool =
                if v1575 then
                    let v1576 : string = "$0.is_file()"
                    let v1577 : bool = Fable.Core.RustInterop.emitRustExpr v1573 v1576
                    v1577
                else
                    false
            v1578
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1579 : bool = null |> unbox<bool>
            v1579
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1580 : bool = null |> unbox<bool>
            v1580
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1581 : IFsExistsSync = Fable.Core.JsInterop.importAll v1320
            let v1582 : string = "v1581.existsSync($0)"
            let v1583 : bool = Fable.Core.JsInterop.emitJsExpr v1564 v1582
            v1583
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1584 : bool = null |> unbox<bool>
            v1584
#endif
            
#else
            let v1585 : (string -> bool) = System.IO.File.Exists
            let v1586 : bool = v1585 v1564
            v1586
#endif
            |> fun x -> _v1565 <- Some x
            let v1587 : bool = _v1565.Value
            let v1588 : bool = v1587 = false
            let v1623 : bool =
                if v1588 then
                    let v1589 : bool option = None
                    let v1590 : bool = true in let mutable _v1589 = v1589
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1591 : string = method14(v1563)
                    let v1592 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v1593 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1591 v1592
                    let v1594 : string = "String::from($0)"
                    let v1595 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1593 v1594
                    let v1596 : string = "std::path::PathBuf::from($0)"
                    let v1597 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1595 v1596
                    let v1598 : string = "$0.exists()"
                    let v1599 : bool = Fable.Core.RustInterop.emitRustExpr v1597 v1598
                    let v1602 : bool =
                        if v1599 then
                            let v1600 : string = "$0.is_file()"
                            let v1601 : bool = Fable.Core.RustInterop.emitRustExpr v1597 v1600
                            v1601
                        else
                            false
                    v1602
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1603 : bool = null |> unbox<bool>
                    v1603
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1604 : bool = null |> unbox<bool>
                    v1604
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1605 : IFsExistsSync = Fable.Core.JsInterop.importAll v1320
                    let v1606 : string = "v1605.existsSync($0)"
                    let v1607 : bool = Fable.Core.JsInterop.emitJsExpr v1563 v1606
                    v1607
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1608 : bool = null |> unbox<bool>
                    v1608
#endif
                    
#else
                    let v1609 : (string -> bool) = System.IO.File.Exists
                    let v1610 : bool = v1609 v1563
                    v1610
#endif
                    |> fun x -> _v1589 <- Some x
                    let v1611 : bool = _v1589.Value
                    if v1611 then
                        let v1612 : US0 = US0_2
                        let v1613 : (unit -> string) = closure70()
                        let v1614 : (unit -> string) = closure71(v1563, v1564)
                        method3(v1612, v1613, v1614)
                        let v1615 : unit option = None
                        let v1616 : bool = true in let mutable _v1615 = v1615
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1617 : string = method73(v1564)
                        let v1618 : string = "std::fs::copy(&*$0, &*v1617)"
                        let v1619 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1563 v1618
                        let v1620 : string = "$0.unwrap()"
                        let v1621 : uint64 = Fable.Core.RustInterop.emitRustExpr v1619 v1620
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
                        System.IO.File.Copy (v1563, v1564, true)
                        ()
#endif
                        |> fun x -> _v1615 <- Some x
                        _v1615.Value
                        false
                    else
                        true
                else
                    true
            let v1626 : UH3 =
                if v1623 then
                    let v1624 : (string -> (string -> US19)) = closure66(v4, v3)
                    UH3_1(v1369, v485, v1624, v1562)
                else
                    v1562
            let struct (v1627 : string, v1628 : string) = method72(v1434, v485, v4)
            let v1629 : bool option = None
            let v1630 : bool = true in let mutable _v1629 = v1629
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1631 : string = method14(v1628)
            let v1632 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1633 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1631 v1632
            let v1634 : string = "String::from($0)"
            let v1635 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1633 v1634
            let v1636 : string = "std::path::PathBuf::from($0)"
            let v1637 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1635 v1636
            let v1638 : string = "$0.exists()"
            let v1639 : bool = Fable.Core.RustInterop.emitRustExpr v1637 v1638
            let v1642 : bool =
                if v1639 then
                    let v1640 : string = "$0.is_file()"
                    let v1641 : bool = Fable.Core.RustInterop.emitRustExpr v1637 v1640
                    v1641
                else
                    false
            v1642
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1643 : bool = null |> unbox<bool>
            v1643
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1644 : bool = null |> unbox<bool>
            v1644
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1645 : IFsExistsSync = Fable.Core.JsInterop.importAll v1320
            let v1646 : string = "v1645.existsSync($0)"
            let v1647 : bool = Fable.Core.JsInterop.emitJsExpr v1628 v1646
            v1647
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1648 : bool = null |> unbox<bool>
            v1648
#endif
            
#else
            let v1649 : (string -> bool) = System.IO.File.Exists
            let v1650 : bool = v1649 v1628
            v1650
#endif
            |> fun x -> _v1629 <- Some x
            let v1651 : bool = _v1629.Value
            let v1652 : bool = v1651 = false
            let v1687 : bool =
                if v1652 then
                    let v1653 : bool option = None
                    let v1654 : bool = true in let mutable _v1653 = v1653
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1655 : string = method14(v1627)
                    let v1656 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v1657 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1655 v1656
                    let v1658 : string = "String::from($0)"
                    let v1659 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1657 v1658
                    let v1660 : string = "std::path::PathBuf::from($0)"
                    let v1661 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1659 v1660
                    let v1662 : string = "$0.exists()"
                    let v1663 : bool = Fable.Core.RustInterop.emitRustExpr v1661 v1662
                    let v1666 : bool =
                        if v1663 then
                            let v1664 : string = "$0.is_file()"
                            let v1665 : bool = Fable.Core.RustInterop.emitRustExpr v1661 v1664
                            v1665
                        else
                            false
                    v1666
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1667 : bool = null |> unbox<bool>
                    v1667
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1668 : bool = null |> unbox<bool>
                    v1668
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1669 : IFsExistsSync = Fable.Core.JsInterop.importAll v1320
                    let v1670 : string = "v1669.existsSync($0)"
                    let v1671 : bool = Fable.Core.JsInterop.emitJsExpr v1627 v1670
                    v1671
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1672 : bool = null |> unbox<bool>
                    v1672
#endif
                    
#else
                    let v1673 : (string -> bool) = System.IO.File.Exists
                    let v1674 : bool = v1673 v1627
                    v1674
#endif
                    |> fun x -> _v1653 <- Some x
                    let v1675 : bool = _v1653.Value
                    if v1675 then
                        let v1676 : US0 = US0_2
                        let v1677 : (unit -> string) = closure70()
                        let v1678 : (unit -> string) = closure71(v1627, v1628)
                        method3(v1676, v1677, v1678)
                        let v1679 : unit option = None
                        let v1680 : bool = true in let mutable _v1679 = v1679
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1681 : string = method73(v1628)
                        let v1682 : string = "std::fs::copy(&*$0, &*v1681)"
                        let v1683 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1627 v1682
                        let v1684 : string = "$0.unwrap()"
                        let v1685 : uint64 = Fable.Core.RustInterop.emitRustExpr v1683 v1684
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
                        System.IO.File.Copy (v1627, v1628, true)
                        ()
#endif
                        |> fun x -> _v1679 <- Some x
                        _v1679.Value
                        false
                    else
                        true
                else
                    true
            let v1690 : UH3 =
                if v1687 then
                    let v1688 : (string -> (string -> US19)) = closure66(v4, v3)
                    UH3_1(v1434, v485, v1688, v1626)
                else
                    v1626
            let struct (v1691 : string, v1692 : string) = method72(v728, v485, v4)
            let v1693 : bool option = None
            let v1694 : bool = true in let mutable _v1693 = v1693
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1695 : string = method14(v1692)
            let v1696 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1697 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1695 v1696
            let v1698 : string = "String::from($0)"
            let v1699 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1697 v1698
            let v1700 : string = "std::path::PathBuf::from($0)"
            let v1701 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1699 v1700
            let v1702 : string = "$0.exists()"
            let v1703 : bool = Fable.Core.RustInterop.emitRustExpr v1701 v1702
            let v1706 : bool =
                if v1703 then
                    let v1704 : string = "$0.is_file()"
                    let v1705 : bool = Fable.Core.RustInterop.emitRustExpr v1701 v1704
                    v1705
                else
                    false
            v1706
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1707 : bool = null |> unbox<bool>
            v1707
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1708 : bool = null |> unbox<bool>
            v1708
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1709 : IFsExistsSync = Fable.Core.JsInterop.importAll v1320
            let v1710 : string = "v1709.existsSync($0)"
            let v1711 : bool = Fable.Core.JsInterop.emitJsExpr v1692 v1710
            v1711
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1712 : bool = null |> unbox<bool>
            v1712
#endif
            
#else
            let v1713 : (string -> bool) = System.IO.File.Exists
            let v1714 : bool = v1713 v1692
            v1714
#endif
            |> fun x -> _v1693 <- Some x
            let v1715 : bool = _v1693.Value
            let v1716 : bool = v1715 = false
            let v1751 : bool =
                if v1716 then
                    let v1717 : bool option = None
                    let v1718 : bool = true in let mutable _v1717 = v1717
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1719 : string = method14(v1691)
                    let v1720 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                    let v1721 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1719 v1720
                    let v1722 : string = "String::from($0)"
                    let v1723 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1721 v1722
                    let v1724 : string = "std::path::PathBuf::from($0)"
                    let v1725 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1723 v1724
                    let v1726 : string = "$0.exists()"
                    let v1727 : bool = Fable.Core.RustInterop.emitRustExpr v1725 v1726
                    let v1730 : bool =
                        if v1727 then
                            let v1728 : string = "$0.is_file()"
                            let v1729 : bool = Fable.Core.RustInterop.emitRustExpr v1725 v1728
                            v1729
                        else
                            false
                    v1730
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1731 : bool = null |> unbox<bool>
                    v1731
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1732 : bool = null |> unbox<bool>
                    v1732
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1733 : IFsExistsSync = Fable.Core.JsInterop.importAll v1320
                    let v1734 : string = "v1733.existsSync($0)"
                    let v1735 : bool = Fable.Core.JsInterop.emitJsExpr v1691 v1734
                    v1735
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1736 : bool = null |> unbox<bool>
                    v1736
#endif
                    
#else
                    let v1737 : (string -> bool) = System.IO.File.Exists
                    let v1738 : bool = v1737 v1691
                    v1738
#endif
                    |> fun x -> _v1717 <- Some x
                    let v1739 : bool = _v1717.Value
                    if v1739 then
                        let v1740 : US0 = US0_2
                        let v1741 : (unit -> string) = closure70()
                        let v1742 : (unit -> string) = closure71(v1691, v1692)
                        method3(v1740, v1741, v1742)
                        let v1743 : unit option = None
                        let v1744 : bool = true in let mutable _v1743 = v1743
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1745 : string = method73(v1692)
                        let v1746 : string = "std::fs::copy(&*$0, &*v1745)"
                        let v1747 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1691 v1746
                        let v1748 : string = "$0.unwrap()"
                        let v1749 : uint64 = Fable.Core.RustInterop.emitRustExpr v1747 v1748
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
                        System.IO.File.Copy (v1691, v1692, true)
                        ()
#endif
                        |> fun x -> _v1743 <- Some x
                        _v1743.Value
                        false
                    else
                        true
                else
                    true
            let v1756 : UH3 =
                if v1751 then
                    let v1752 : (string -> (string -> US19)) = closure59(v4, v3, v1, v0)
                    let v1753 : UH3 = UH3_0
                    UH3_1(v728, v485, v1752, v1753)
                else
                    UH3_0
            let v1757 : UH2 = UH2_0
            let v1758 : UH2 = UH2_1(v1690, v1757)
            UH2_1(v1756, v1758)
    let v1761 : UH3 list = []
    let v1762 : UH3 list = method81(v1760, v1761)
    let v1763 : (UH3 list -> (UH3 [])) = List.toArray
    let v1764 : (UH3 []) = v1763 v1762
    let v1765 : string = "$0.to_vec()"
    let v1766 : Vec<UH3> = Fable.Core.RustInterop.emitRustExpr v1764 v1765
    let v1767 : (Result<string, (string * string)> option []) = [||]
    let v1768 : string = "$0.to_vec()"
    let v1769 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1767 v1768
    let v1770 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v1771 : (UH3 []) = Fable.Core.RustInterop.emitRustExpr v1766 v1770
    let v1772 : int32 = v1771.Length
    let v1773 : Mut8 = {l0 = 0; l1 = v1769} : Mut8
    while method82(v1772, v1773) do
        let v1775 : int32 = v1773.l0
        let v1776 : Vec<Result<string, (string * string)> option> = v1773.l1
        let v1777 : UH3 = v1771.[int v1775]
        let v1778 : struct (string * string * (string -> (string -> US19))) list = []
        let v1779 : struct (string * string * (string -> (string -> US19))) list = method83(v1777, v1778)
        let v1780 : (struct (string * string * (string -> (string -> US19))) list -> (struct (string * string * (string -> (string -> US19))) [])) = List.toArray
        let v1781 : (struct (string * string * (string -> (string -> US19))) []) = v1780 v1779
        let v1782 : string = "$0.to_vec()"
        let v1783 : Vec<struct (string * string * (string -> (string -> US19)))> = Fable.Core.RustInterop.emitRustExpr v1781 v1782
        let v1784 : string = "rayon::iter::IntoParallelIterator::into_par_iter(v1783)"
        let v1785 : rayon_vec_IntoIter<struct (string * string * (string -> (string -> US19)))> = Fable.Core.RustInterop.emitRustExpr () v1784
        let v1786 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
        let v1787 : (struct (string * string * (string -> (string -> US19))) -> Result<string, (string * string)> option) = closure72()
        let v1788 : rayon_iter_Map<rayon_vec_IntoIter<struct (string * string * (string -> (string -> US19)))>> = Fable.Core.RustInterop.emitRustExpr struct (v1785, v1787) v1786
        let v1789 : string = "rayon::iter::ParallelIterator::collect($0)"
        let v1790 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1788 v1789
        let v1791 : Vec<Result<string, (string * string)> option> = method84(v1790)
        let v1792 : Vec<Result<string, (string * string)> option> = method85(v1776)
        let v1793 : string = "let mut v1792 = v1792"
        Fable.Core.RustInterop.emitRustExpr () v1793
        let v1794 : string = "v1792.extend(v1791)"
        Fable.Core.RustInterop.emitRustExpr () v1794
        let v1795 : string = "v1792"
        let v1796 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr () v1795
        let v1797 : int32 = v1775 + 1
        v1773.l0 <- v1797
        v1773.l1 <- v1796
        ()
    let v1798 : Vec<Result<string, (string * string)> option> = v1773.l1
    let v1799 : (string * Vec<Result<string, (string * string)> option>) = v222, v1798
    let v1800 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v1799
    v1800
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
    let v169 : string =
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
            let v58 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v59 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v55, v56, v57) v58
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
                let struct (v127 : int32, v128 : (string [])) =
                    if v88 then
                        let v89 : int32 = v85 + 1
                        struct (v89, v86)
                    else
                        let v90 : bool = 0 = v85
                        if v90 then
                            let v91 : string = ":"
                            let v92 : bool = v87.EndsWith v91
                            if v92 then
                                let v93 : string = $"{v51.[0]}:"
                                let v94 : (string []) = [|v93|]
                                let v95 : int32 = v94.Length
                                let v96 : int32 = v86.Length
                                let v97 : int32 = v95 + v96
                                let v98 : (string []) = Array.zeroCreate<string> (v97)
                                let v99 : Mut5 = {l0 = 0} : Mut5
                                while method26(v97, v99) do
                                    let v101 : int32 = v99.l0
                                    let v102 : bool = v101 < v95
                                    let v106 : string =
                                        if v102 then
                                            let v103 : string = v94.[int v101]
                                            v103
                                        else
                                            let v104 : int32 = v101 - v95
                                            let v105 : string = v86.[int v104]
                                            v105
                                    v98.[int v101] <- v106
                                    let v107 : int32 = v101 + 1
                                    v99.l0 <- v107
                                    ()
                                struct (0, v98)
                            else
                                let v108 : (string []) = [|v87|]
                                let v109 : int32 = v108.Length
                                let v110 : int32 = v86.Length
                                let v111 : int32 = v109 + v110
                                let v112 : (string []) = Array.zeroCreate<string> (v111)
                                let v113 : Mut5 = {l0 = 0} : Mut5
                                while method26(v111, v113) do
                                    let v115 : int32 = v113.l0
                                    let v116 : bool = v115 < v109
                                    let v120 : string =
                                        if v116 then
                                            let v117 : string = v108.[int v115]
                                            v117
                                        else
                                            let v118 : int32 = v115 - v109
                                            let v119 : string = v86.[int v118]
                                            v119
                                    v112.[int v115] <- v120
                                    let v121 : int32 = v115 + 1
                                    v113.l0 <- v121
                                    ()
                                struct (0, v112)
                        else
                            let v124 : int32 = v85 - 1
                            struct (v124, v86)
                let v129 : int32 = v81 + 1
                v79.l0 <- v129
                v79.l1 <- v127
                v79.l2 <- v128
                ()
            let struct (v130 : int32, v131 : (string [])) = v79.l1, v79.l2
            let v132 : string seq = seq { for i = 0 to v131.Length - 1 do yield v131.[i] }
            let v133 : char option = None
            let v134 : bool = true in let mutable _v133 = v133
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v135 : string = "std::path::MAIN_SEPARATOR"
            let v136 : char = Fable.Core.RustInterop.emitRustExpr () v135
            v136
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v137 : char = null |> unbox<char>
            v137
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v138 : char = null |> unbox<char>
            v138
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v139 : char = null |> unbox<char>
            v139
#endif
            
#if FABLE_COMPILER_PYTHON
            let v140 : char = null |> unbox<char>
            v140
#endif
            
#else
            let v141 : char = System.IO.Path.DirectorySeparatorChar
            v141
#endif
            |> fun x -> _v133 <- Some x
            let v142 : char = _v133.Value
            let v143 : (char -> string) = _.ToString()
            let v144 : string = v143 v142
            let v145 : string = method27(v144)
            let v146 : (string -> (string seq -> string)) = String.concat
            let v147 : (string seq -> string) = v146 v145
            v147 v132
        else
            let v149 : string = "std::fs::canonicalize(&*$0)"
            let v150 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v12 v149
            let v151 : string = "$0.unwrap()"
            let v152 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v150 v151
            let v153 : string = "$0.display()"
            let v154 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v152 v153
            let v155 : std_string_String option = None
            let v156 : bool = true in let mutable _v155 = v155
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v157 : string = @$"format!(""{{}}"", $0)"
            let v158 : std_string_String = Fable.Core.RustInterop.emitRustExpr v154 v157
            v158
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v159 : string = @$"format!(""{{}}"", $0)"
            let v160 : std_string_String = Fable.Core.RustInterop.emitRustExpr v154 v159
            v160
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v161 : string = @$"format!(""{{}}"", $0)"
            let v162 : std_string_String = Fable.Core.RustInterop.emitRustExpr v154 v161
            v162
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v163 : std_string_String = null |> unbox<std_string_String>
            v163
#endif
            
#if FABLE_COMPILER_PYTHON
            let v164 : std_string_String = null |> unbox<std_string_String>
            v164
#endif
            
#else
            let v165 : std_string_String = null |> unbox<std_string_String>
            v165
#endif
            |> fun x -> _v155 <- Some x
            let v166 : std_string_String = _v155.Value
            let v167 : string = "fable_library_rust::String_::fromString($0)"
            let v168 : string = Fable.Core.RustInterop.emitRustExpr v166 v167
            v168
    v169
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v170 : string = null |> unbox<string>
    v170
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v171 : string = null |> unbox<string>
    v171
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v172 : string = null |> unbox<string>
    v172
#endif
    
#if FABLE_COMPILER_PYTHON
    let v173 : string = null |> unbox<string>
    v173
#endif
    
#else
    let v174 : string = method28(v3)
    let v175 : (string -> string) = System.IO.Path.GetFullPath
    let v176 : string = v175 v174
    v176
#endif
    |> fun x -> _v10 <- Some x
    let v177 : string = _v10.Value
    let v178 : string option = None
    let v179 : bool = true in let mutable _v178 = v178
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v180 : string = method21(v2)
    let v181 : string = method14(v180)
    let v182 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v183 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v181 v182
    let v184 : string = "String::from($0)"
    let v185 : std_string_String = Fable.Core.RustInterop.emitRustExpr v183 v184
    let v186 : string = "std::path::PathBuf::from($0)"
    let v187 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v185 v186
    let v188 : string = "$0.exists()"
    let v189 : bool = Fable.Core.RustInterop.emitRustExpr v187 v188
    let v190 : bool = v189 = false
    let v337 : string =
        if v190 then
            let v191 : string option = None
            let v192 : bool = true in let mutable _v191 = v191
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v193 : string = "std::env::current_dir()"
            let v194 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v193
            let v195 : string = "$0.unwrap()"
            let v196 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v194 v195
            let v197 : string = "$0.display()"
            let v198 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v196 v197
            let v199 : std_string_String option = None
            let v200 : bool = true in let mutable _v199 = v199
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v201 : string = @$"format!(""{{}}"", $0)"
            let v202 : std_string_String = Fable.Core.RustInterop.emitRustExpr v198 v201
            v202
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v203 : string = @$"format!(""{{}}"", $0)"
            let v204 : std_string_String = Fable.Core.RustInterop.emitRustExpr v198 v203
            v204
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v205 : string = @$"format!(""{{}}"", $0)"
            let v206 : std_string_String = Fable.Core.RustInterop.emitRustExpr v198 v205
            v206
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v207 : std_string_String = null |> unbox<std_string_String>
            v207
#endif
            
#if FABLE_COMPILER_PYTHON
            let v208 : std_string_String = null |> unbox<std_string_String>
            v208
#endif
            
#else
            let v209 : std_string_String = null |> unbox<std_string_String>
            v209
#endif
            |> fun x -> _v199 <- Some x
            let v210 : std_string_String = _v199.Value
            let v211 : string = "fable_library_rust::String_::fromString($0)"
            let v212 : string = Fable.Core.RustInterop.emitRustExpr v210 v211
            v212
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v213 : string = null |> unbox<string>
            v213
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v214 : string = null |> unbox<string>
            v214
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v215 : string = null |> unbox<string>
            v215
#endif
            
#if FABLE_COMPILER_PYTHON
            let v216 : string = null |> unbox<string>
            v216
#endif
            
#else
            let v217 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v218 : string = v217 ()
            v218
#endif
            |> fun x -> _v191 <- Some x
            let v219 : string = _v191.Value
            let v220 : string = method13(v219, v180)
            let v221 : string option = None
            let v222 : bool = true in let mutable _v221 = v221
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v223 : string = method22()
            let v224 : string = method23(v220)
            let v225 : string = method24()
            let v226 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v227 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v223, v224, v225) v226
            let v228 : string = "String::from($0)"
            let v229 : std_string_String = Fable.Core.RustInterop.emitRustExpr v227 v228
            let v230 : string = "fable_library_rust::String_::fromString($0)"
            let v231 : string = Fable.Core.RustInterop.emitRustExpr v229 v230
            v231
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v232 : string = null |> unbox<string>
            v232
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v233 : string = null |> unbox<string>
            v233
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v234 : string = null |> unbox<string>
            v234
#endif
            
#if FABLE_COMPILER_PYTHON
            let v235 : string = null |> unbox<string>
            v235
#endif
            
#else
            let v236 : string = "^\\\\\\\\\\?\\\\"
            let v237 : string = ""
            let v238 : string = System.Text.RegularExpressions.Regex.Replace (v220, v236, v237)
            v238
#endif
            |> fun x -> _v221 <- Some x
            let v239 : string = _v221.Value
            let v240 : string = $"{v239.[0] |> string |> _.ToLower()}{v239.[1..]}"
            let v241 : string = "\\"
            let v242 : string = "/"
            let v243 : string = v240.Replace (v241, v242)
            let v244 : (string []) = v243.Split v242
            let v245 : (string []) = [||]
            let v246 : int32 = v244.Length
            let v247 : Mut4 = {l0 = 0; l1 = 0; l2 = v245} : Mut4
            while method25(v246, v247) do
                let v249 : int32 = v247.l0
                let v250 : int32 =  -v249
                let v251 : int32 = v250 + v246
                let v252 : int32 = v251 - 1
                let struct (v253 : int32, v254 : (string [])) = v247.l1, v247.l2
                let v255 : string = v244.[int v252]
                let v256 : bool = ".." = v255
                let struct (v295 : int32, v296 : (string [])) =
                    if v256 then
                        let v257 : int32 = v253 + 1
                        struct (v257, v254)
                    else
                        let v258 : bool = 0 = v253
                        if v258 then
                            let v259 : string = ":"
                            let v260 : bool = v255.EndsWith v259
                            if v260 then
                                let v261 : string = $"{v219.[0]}:"
                                let v262 : (string []) = [|v261|]
                                let v263 : int32 = v262.Length
                                let v264 : int32 = v254.Length
                                let v265 : int32 = v263 + v264
                                let v266 : (string []) = Array.zeroCreate<string> (v265)
                                let v267 : Mut5 = {l0 = 0} : Mut5
                                while method26(v265, v267) do
                                    let v269 : int32 = v267.l0
                                    let v270 : bool = v269 < v263
                                    let v274 : string =
                                        if v270 then
                                            let v271 : string = v262.[int v269]
                                            v271
                                        else
                                            let v272 : int32 = v269 - v263
                                            let v273 : string = v254.[int v272]
                                            v273
                                    v266.[int v269] <- v274
                                    let v275 : int32 = v269 + 1
                                    v267.l0 <- v275
                                    ()
                                struct (0, v266)
                            else
                                let v276 : (string []) = [|v255|]
                                let v277 : int32 = v276.Length
                                let v278 : int32 = v254.Length
                                let v279 : int32 = v277 + v278
                                let v280 : (string []) = Array.zeroCreate<string> (v279)
                                let v281 : Mut5 = {l0 = 0} : Mut5
                                while method26(v279, v281) do
                                    let v283 : int32 = v281.l0
                                    let v284 : bool = v283 < v277
                                    let v288 : string =
                                        if v284 then
                                            let v285 : string = v276.[int v283]
                                            v285
                                        else
                                            let v286 : int32 = v283 - v277
                                            let v287 : string = v254.[int v286]
                                            v287
                                    v280.[int v283] <- v288
                                    let v289 : int32 = v283 + 1
                                    v281.l0 <- v289
                                    ()
                                struct (0, v280)
                        else
                            let v292 : int32 = v253 - 1
                            struct (v292, v254)
                let v297 : int32 = v249 + 1
                v247.l0 <- v297
                v247.l1 <- v295
                v247.l2 <- v296
                ()
            let struct (v298 : int32, v299 : (string [])) = v247.l1, v247.l2
            let v300 : string seq = seq { for i = 0 to v299.Length - 1 do yield v299.[i] }
            let v301 : char option = None
            let v302 : bool = true in let mutable _v301 = v301
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v303 : string = "std::path::MAIN_SEPARATOR"
            let v304 : char = Fable.Core.RustInterop.emitRustExpr () v303
            v304
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v305 : char = null |> unbox<char>
            v305
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v306 : char = null |> unbox<char>
            v306
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v307 : char = null |> unbox<char>
            v307
#endif
            
#if FABLE_COMPILER_PYTHON
            let v308 : char = null |> unbox<char>
            v308
#endif
            
#else
            let v309 : char = System.IO.Path.DirectorySeparatorChar
            v309
#endif
            |> fun x -> _v301 <- Some x
            let v310 : char = _v301.Value
            let v311 : (char -> string) = _.ToString()
            let v312 : string = v311 v310
            let v313 : string = method27(v312)
            let v314 : (string -> (string seq -> string)) = String.concat
            let v315 : (string seq -> string) = v314 v313
            v315 v300
        else
            let v317 : string = "std::fs::canonicalize(&*$0)"
            let v318 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v180 v317
            let v319 : string = "$0.unwrap()"
            let v320 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v318 v319
            let v321 : string = "$0.display()"
            let v322 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v320 v321
            let v323 : std_string_String option = None
            let v324 : bool = true in let mutable _v323 = v323
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v325 : string = @$"format!(""{{}}"", $0)"
            let v326 : std_string_String = Fable.Core.RustInterop.emitRustExpr v322 v325
            v326
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v327 : string = @$"format!(""{{}}"", $0)"
            let v328 : std_string_String = Fable.Core.RustInterop.emitRustExpr v322 v327
            v328
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v329 : string = @$"format!(""{{}}"", $0)"
            let v330 : std_string_String = Fable.Core.RustInterop.emitRustExpr v322 v329
            v330
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v331 : std_string_String = null |> unbox<std_string_String>
            v331
#endif
            
#if FABLE_COMPILER_PYTHON
            let v332 : std_string_String = null |> unbox<std_string_String>
            v332
#endif
            
#else
            let v333 : std_string_String = null |> unbox<std_string_String>
            v333
#endif
            |> fun x -> _v323 <- Some x
            let v334 : std_string_String = _v323.Value
            let v335 : string = "fable_library_rust::String_::fromString($0)"
            let v336 : string = Fable.Core.RustInterop.emitRustExpr v334 v335
            v336
    v337
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v338 : string = null |> unbox<string>
    v338
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v339 : string = null |> unbox<string>
    v339
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v340 : string = null |> unbox<string>
    v340
#endif
    
#if FABLE_COMPILER_PYTHON
    let v341 : string = null |> unbox<string>
    v341
#endif
    
#else
    let v342 : string = method28(v2)
    let v343 : (string -> string) = System.IO.Path.GetFullPath
    let v344 : string = v343 v342
    v344
#endif
    |> fun x -> _v178 <- Some x
    let v345 : string = _v178.Value
    let v346 : string option = None
    let v347 : bool = true in let mutable _v346 = v346
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v348 : string = method21(v1)
    let v349 : string = method14(v348)
    let v350 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v351 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v349 v350
    let v352 : string = "String::from($0)"
    let v353 : std_string_String = Fable.Core.RustInterop.emitRustExpr v351 v352
    let v354 : string = "std::path::PathBuf::from($0)"
    let v355 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v353 v354
    let v356 : string = "$0.exists()"
    let v357 : bool = Fable.Core.RustInterop.emitRustExpr v355 v356
    let v358 : bool = v357 = false
    let v505 : string =
        if v358 then
            let v359 : string option = None
            let v360 : bool = true in let mutable _v359 = v359
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v361 : string = "std::env::current_dir()"
            let v362 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v361
            let v363 : string = "$0.unwrap()"
            let v364 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v362 v363
            let v365 : string = "$0.display()"
            let v366 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v364 v365
            let v367 : std_string_String option = None
            let v368 : bool = true in let mutable _v367 = v367
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v369 : string = @$"format!(""{{}}"", $0)"
            let v370 : std_string_String = Fable.Core.RustInterop.emitRustExpr v366 v369
            v370
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v371 : string = @$"format!(""{{}}"", $0)"
            let v372 : std_string_String = Fable.Core.RustInterop.emitRustExpr v366 v371
            v372
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v373 : string = @$"format!(""{{}}"", $0)"
            let v374 : std_string_String = Fable.Core.RustInterop.emitRustExpr v366 v373
            v374
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v375 : std_string_String = null |> unbox<std_string_String>
            v375
#endif
            
#if FABLE_COMPILER_PYTHON
            let v376 : std_string_String = null |> unbox<std_string_String>
            v376
#endif
            
#else
            let v377 : std_string_String = null |> unbox<std_string_String>
            v377
#endif
            |> fun x -> _v367 <- Some x
            let v378 : std_string_String = _v367.Value
            let v379 : string = "fable_library_rust::String_::fromString($0)"
            let v380 : string = Fable.Core.RustInterop.emitRustExpr v378 v379
            v380
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v381 : string = null |> unbox<string>
            v381
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v382 : string = null |> unbox<string>
            v382
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v383 : string = null |> unbox<string>
            v383
#endif
            
#if FABLE_COMPILER_PYTHON
            let v384 : string = null |> unbox<string>
            v384
#endif
            
#else
            let v385 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v386 : string = v385 ()
            v386
#endif
            |> fun x -> _v359 <- Some x
            let v387 : string = _v359.Value
            let v388 : string = method13(v387, v348)
            let v389 : string option = None
            let v390 : bool = true in let mutable _v389 = v389
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v391 : string = method22()
            let v392 : string = method23(v388)
            let v393 : string = method24()
            let v394 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v395 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v391, v392, v393) v394
            let v396 : string = "String::from($0)"
            let v397 : std_string_String = Fable.Core.RustInterop.emitRustExpr v395 v396
            let v398 : string = "fable_library_rust::String_::fromString($0)"
            let v399 : string = Fable.Core.RustInterop.emitRustExpr v397 v398
            v399
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v400 : string = null |> unbox<string>
            v400
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v401 : string = null |> unbox<string>
            v401
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v402 : string = null |> unbox<string>
            v402
#endif
            
#if FABLE_COMPILER_PYTHON
            let v403 : string = null |> unbox<string>
            v403
#endif
            
#else
            let v404 : string = "^\\\\\\\\\\?\\\\"
            let v405 : string = ""
            let v406 : string = System.Text.RegularExpressions.Regex.Replace (v388, v404, v405)
            v406
#endif
            |> fun x -> _v389 <- Some x
            let v407 : string = _v389.Value
            let v408 : string = $"{v407.[0] |> string |> _.ToLower()}{v407.[1..]}"
            let v409 : string = "\\"
            let v410 : string = "/"
            let v411 : string = v408.Replace (v409, v410)
            let v412 : (string []) = v411.Split v410
            let v413 : (string []) = [||]
            let v414 : int32 = v412.Length
            let v415 : Mut4 = {l0 = 0; l1 = 0; l2 = v413} : Mut4
            while method25(v414, v415) do
                let v417 : int32 = v415.l0
                let v418 : int32 =  -v417
                let v419 : int32 = v418 + v414
                let v420 : int32 = v419 - 1
                let struct (v421 : int32, v422 : (string [])) = v415.l1, v415.l2
                let v423 : string = v412.[int v420]
                let v424 : bool = ".." = v423
                let struct (v463 : int32, v464 : (string [])) =
                    if v424 then
                        let v425 : int32 = v421 + 1
                        struct (v425, v422)
                    else
                        let v426 : bool = 0 = v421
                        if v426 then
                            let v427 : string = ":"
                            let v428 : bool = v423.EndsWith v427
                            if v428 then
                                let v429 : string = $"{v387.[0]}:"
                                let v430 : (string []) = [|v429|]
                                let v431 : int32 = v430.Length
                                let v432 : int32 = v422.Length
                                let v433 : int32 = v431 + v432
                                let v434 : (string []) = Array.zeroCreate<string> (v433)
                                let v435 : Mut5 = {l0 = 0} : Mut5
                                while method26(v433, v435) do
                                    let v437 : int32 = v435.l0
                                    let v438 : bool = v437 < v431
                                    let v442 : string =
                                        if v438 then
                                            let v439 : string = v430.[int v437]
                                            v439
                                        else
                                            let v440 : int32 = v437 - v431
                                            let v441 : string = v422.[int v440]
                                            v441
                                    v434.[int v437] <- v442
                                    let v443 : int32 = v437 + 1
                                    v435.l0 <- v443
                                    ()
                                struct (0, v434)
                            else
                                let v444 : (string []) = [|v423|]
                                let v445 : int32 = v444.Length
                                let v446 : int32 = v422.Length
                                let v447 : int32 = v445 + v446
                                let v448 : (string []) = Array.zeroCreate<string> (v447)
                                let v449 : Mut5 = {l0 = 0} : Mut5
                                while method26(v447, v449) do
                                    let v451 : int32 = v449.l0
                                    let v452 : bool = v451 < v445
                                    let v456 : string =
                                        if v452 then
                                            let v453 : string = v444.[int v451]
                                            v453
                                        else
                                            let v454 : int32 = v451 - v445
                                            let v455 : string = v422.[int v454]
                                            v455
                                    v448.[int v451] <- v456
                                    let v457 : int32 = v451 + 1
                                    v449.l0 <- v457
                                    ()
                                struct (0, v448)
                        else
                            let v460 : int32 = v421 - 1
                            struct (v460, v422)
                let v465 : int32 = v417 + 1
                v415.l0 <- v465
                v415.l1 <- v463
                v415.l2 <- v464
                ()
            let struct (v466 : int32, v467 : (string [])) = v415.l1, v415.l2
            let v468 : string seq = seq { for i = 0 to v467.Length - 1 do yield v467.[i] }
            let v469 : char option = None
            let v470 : bool = true in let mutable _v469 = v469
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v471 : string = "std::path::MAIN_SEPARATOR"
            let v472 : char = Fable.Core.RustInterop.emitRustExpr () v471
            v472
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v473 : char = null |> unbox<char>
            v473
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v474 : char = null |> unbox<char>
            v474
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v475 : char = null |> unbox<char>
            v475
#endif
            
#if FABLE_COMPILER_PYTHON
            let v476 : char = null |> unbox<char>
            v476
#endif
            
#else
            let v477 : char = System.IO.Path.DirectorySeparatorChar
            v477
#endif
            |> fun x -> _v469 <- Some x
            let v478 : char = _v469.Value
            let v479 : (char -> string) = _.ToString()
            let v480 : string = v479 v478
            let v481 : string = method27(v480)
            let v482 : (string -> (string seq -> string)) = String.concat
            let v483 : (string seq -> string) = v482 v481
            v483 v468
        else
            let v485 : string = "std::fs::canonicalize(&*$0)"
            let v486 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v348 v485
            let v487 : string = "$0.unwrap()"
            let v488 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v486 v487
            let v489 : string = "$0.display()"
            let v490 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v488 v489
            let v491 : std_string_String option = None
            let v492 : bool = true in let mutable _v491 = v491
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v493 : string = @$"format!(""{{}}"", $0)"
            let v494 : std_string_String = Fable.Core.RustInterop.emitRustExpr v490 v493
            v494
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v495 : string = @$"format!(""{{}}"", $0)"
            let v496 : std_string_String = Fable.Core.RustInterop.emitRustExpr v490 v495
            v496
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v497 : string = @$"format!(""{{}}"", $0)"
            let v498 : std_string_String = Fable.Core.RustInterop.emitRustExpr v490 v497
            v498
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v499 : std_string_String = null |> unbox<std_string_String>
            v499
#endif
            
#if FABLE_COMPILER_PYTHON
            let v500 : std_string_String = null |> unbox<std_string_String>
            v500
#endif
            
#else
            let v501 : std_string_String = null |> unbox<std_string_String>
            v501
#endif
            |> fun x -> _v491 <- Some x
            let v502 : std_string_String = _v491.Value
            let v503 : string = "fable_library_rust::String_::fromString($0)"
            let v504 : string = Fable.Core.RustInterop.emitRustExpr v502 v503
            v504
    v505
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v506 : string = null |> unbox<string>
    v506
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v507 : string = null |> unbox<string>
    v507
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v508 : string = null |> unbox<string>
    v508
#endif
    
#if FABLE_COMPILER_PYTHON
    let v509 : string = null |> unbox<string>
    v509
#endif
    
#else
    let v510 : string = method28(v1)
    let v511 : (string -> string) = System.IO.Path.GetFullPath
    let v512 : string = v511 v510
    v512
#endif
    |> fun x -> _v346 <- Some x
    let v513 : string = _v346.Value
    let v514 : US0 = US0_1
    let v515 : (unit -> string) = closure12()
    let v516 : (unit -> string) = closure13(v0, v177, v345, v513)
    method3(v514, v515, v516)
    method29(v0, v9, v177, v345, v513)
and closure1 () (v0 : (string [])) : int32 =
    let v1 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure2()
    if State.trace_state.IsNone then State.trace_state <- v1 () |> Some
    let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : int64 option, v6 : Mut3) = State.trace_state.Value
    let v7 : US0 = US0_2
    v4.l0 <- v7
    let v8 : string option = None
    let v9 : bool = true in let mutable _v8 = v8
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : string = "std::env::current_dir()"
    let v11 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : string = "$0.unwrap()"
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
    let v32 : string = null |> unbox<string>
    v32
#endif
    
#if FABLE_COMPILER_PYTHON
    let v33 : string = null |> unbox<string>
    v33
#endif
    
#else
    let v34 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v35 : string = v34 ()
    v35
#endif
    |> fun x -> _v8 <- Some x
    let v36 : string = _v8.Value
    let v37 : US0 = US0_2
    let v38 : (unit -> string) = closure4()
    let v39 : (unit -> string) = closure5(v0, v36)
    method3(v37, v38, v39)
    let v40 : clap_Command = method0()
    let v41 : string = "clap::Command::get_matches($0)"
    let v42 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v40 v41
    let v43 : string = method7()
    let v44 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v43 v44
    let v46 : string = "clap::ArgMatches::get_one(&v42, v45).cloned()"
    let v47 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v46
    let v48 : (std_string_String -> US3) = method8()
    let v49 : US3 = US3_1
    let v50 : US3 = v47 |> Option.map v48 |> Option.defaultValue v49 
    let v54 : std_string_String =
        match v50 with
        | US3_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US3_0(v51) -> (* Some *)
            v51
    let v55 : string = "fable_library_rust::String_::fromString($0)"
    let v56 : string = Fable.Core.RustInterop.emitRustExpr v54 v55
    let v57 : string = method9()
    let v58 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v59 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v57 v58
    let v60 : string = "clap::ArgMatches::get_one(&v42, v59).cloned()"
    let v61 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v60
    let v62 : (std_string_String -> US3) = method8()
    let v63 : US3 = US3_1
    let v64 : US3 = v61 |> Option.map v62 |> Option.defaultValue v63 
    let v68 : std_string_String =
        match v64 with
        | US3_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US3_0(v65) -> (* Some *)
            v65
    let v69 : string = "fable_library_rust::String_::fromString($0)"
    let v70 : string = Fable.Core.RustInterop.emitRustExpr v68 v69
    let v71 : string = method10()
    let v72 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v71 v72
    let v74 : string = "clap::ArgMatches::get_one(&v42, v73).cloned()"
    let v75 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v74
    let v76 : (std_string_String -> US3) = method8()
    let v77 : US3 = US3_1
    let v78 : US3 = v75 |> Option.map v76 |> Option.defaultValue v77 
    let v82 : std_string_String =
        match v78 with
        | US3_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US3_0(v79) -> (* Some *)
            v79
    let v83 : string = "fable_library_rust::String_::fromString($0)"
    let v84 : string = Fable.Core.RustInterop.emitRustExpr v82 v83
    let v85 : string = method11()
    let v86 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v87 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v85 v86
    let v88 : string = "clap::ArgMatches::get_one(&v42, v87).cloned()"
    let v89 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v88
    let v90 : (std_string_String -> US3) = method8()
    let v91 : US3 = US3_1
    let v92 : US3 = v89 |> Option.map v90 |> Option.defaultValue v91 
    let v96 : std_string_String =
        match v92 with
        | US3_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US3_0(v93) -> (* Some *)
            v93
    let v97 : string = "fable_library_rust::String_::fromString($0)"
    let v98 : string = Fable.Core.RustInterop.emitRustExpr v96 v97
    let v99 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = method12(v98, v84, v70, v56)
    let v100 : string = "futures_lite::future::block_on($0)"
    let v101 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr v99 v100
    let v102 : string = "$0.unwrap()"
    let v103 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = Fable.Core.RustInterop.emitRustExpr v101 v102
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
