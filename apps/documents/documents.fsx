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
and Mut6 = {mutable l0 : int32; mutable l1 : int32}
and Mut7 = {mutable l0 : int32; mutable l1 : string; mutable l2 : int32; mutable l3 : int32}
and [<Struct>] US20 =
    | US20_0 of f0_0 : int32 * f0_1 : string
    | US20_1 of f1_0 : int32 * f1_1 : string
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
and method13 () : string =
    let v0 : string = "polyglot"
    v0
and method14 () : string =
    let v0 : string = ".paket"
    v0
and method15 () : string =
    let v0 : string = "polyglot"
    v0
and method16 () : string =
    let v0 : string = ".paket"
    v0
and method18 (v0 : string) : string =
    v0
and method19 (v0 : string) : string =
    v0
and method20 (v0 : string) : string =
    v0
and closure10 () (v0 : string) : string option =
    let v1 : US4 option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method18(v0)
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
and method21 () : (string -> string option) =
    closure10()
and closure11 () (v0 : string) : US4 =
    US4_0(v0)
and method22 () : (string -> US4) =
    closure11()
and method23 (v0 : string, v1 : string, v2 : string) : string =
    let v3 : string option = None
    let v4 : bool = true in let mutable _v3 = v3
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = method18(v2)
    let v6 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v7 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "String::from($0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "std::path::PathBuf::from($0)"
    let v11 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = method18(v0)
    let v13 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "String::from($0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "$0.join($1)"
    let v18 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v11, v16) v17
    let v19 : string = "$0.display()"
    let v20 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v18 v19
    let v21 : std_string_String option = None
    let v22 : bool = true in let mutable _v21 = v21
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v23 : string = @$"format!(""{{}}"", $0)"
    let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr v20 v23
    v24
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v25 : string = @$"format!(""{{}}"", $0)"
    let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v20 v25
    v26
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v27 : string = @$"format!(""{{}}"", $0)"
    let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v20 v27
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
    |> fun x -> _v21 <- Some x
    let v32 : std_string_String = _v21.Value
    let v33 : string = "fable_library_rust::String_::fromString($0)"
    let v34 : string = Fable.Core.RustInterop.emitRustExpr v32 v33
    v34
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v35 : string = null |> unbox<string>
    v35
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v36 : string = null |> unbox<string>
    v36
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v37 : string = "path"
    let v38 : IPathJoin = Fable.Core.JsInterop.importAll v37
    let v39 : string = method19(v2)
    let v40 : string = method20(v0)
    let v41 : string = "v38.join(v39, v40)"
    let v42 : string = Fable.Core.JsInterop.emitJsExpr () v41
    v42
#endif
    
#if FABLE_COMPILER_PYTHON
    let v43 : string = null |> unbox<string>
    v43
#endif
    
#else
    let v44 : string = System.IO.Path.Combine (v2, v0)
    v44
#endif
    |> fun x -> _v3 <- Some x
    let v45 : string = _v3.Value
    let v46 : bool option = None
    let v47 : bool = true in let mutable _v46 = v46
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v48 : string = method18(v45)
    let v49 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v48 v49
    let v51 : string = "String::from($0)"
    let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr v50 v51
    let v53 : string = "std::path::PathBuf::from($0)"
    let v54 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v52 v53
    let v55 : string = "$0.exists()"
    let v56 : bool = Fable.Core.RustInterop.emitRustExpr v54 v55
    let v59 : bool =
        if v56 then
            let v57 : string = "$0.is_dir()"
            let v58 : bool = Fable.Core.RustInterop.emitRustExpr v54 v57
            v58
        else
            false
    v59
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v60 : bool = null |> unbox<bool>
    v60
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v61 : bool = null |> unbox<bool>
    v61
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v62 : string = "fs"
    let v63 : IFsExistsSync = Fable.Core.JsInterop.importAll v62
    let v64 : string = "v63.existsSync($0)"
    let v65 : bool = Fable.Core.JsInterop.emitJsExpr v45 v64
    v65
#endif
    
#if FABLE_COMPILER_PYTHON
    let v66 : bool = null |> unbox<bool>
    v66
#endif
    
#else
    let v67 : (string -> bool) = System.IO.Directory.Exists
    let v68 : bool = v67 v45
    v68
#endif
    |> fun x -> _v46 <- Some x
    let v69 : bool = _v46.Value
    if v69 then
        v2
    else
        let v70 : (string -> string option) = method21()
        let v71 : string option = v70 v2
        let v72 : (string -> US4) = method22()
        let v73 : US4 = US4_1
        let v74 : US4 = v71 |> Option.map v72 |> Option.defaultValue v73 
        match v74 with
        | US4_1 -> (* None *)
            let v77 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            failwith<string> v77
        | US4_0(v75) -> (* Some *)
            method23(v0, v1, v75)
and method17 (v0 : string, v1 : string) : string =
    let v2 : string option = None
    let v3 : bool = true in let mutable _v2 = v2
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method18(v1)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "std::path::PathBuf::from($0)"
    let v10 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = method18(v0)
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
    let v38 : string = method19(v1)
    let v39 : string = method20(v0)
    let v40 : string = "v37.join(v38, v39)"
    let v41 : string = Fable.Core.JsInterop.emitJsExpr () v40
    v41
#endif
    
#if FABLE_COMPILER_PYTHON
    let v42 : string = null |> unbox<string>
    v42
#endif
    
#else
    let v43 : string = System.IO.Path.Combine (v1, v0)
    v43
#endif
    |> fun x -> _v2 <- Some x
    let v44 : string = _v2.Value
    let v45 : bool option = None
    let v46 : bool = true in let mutable _v45 = v45
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v47 : string = method18(v44)
    let v48 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v47 v48
    let v50 : string = "String::from($0)"
    let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr v49 v50
    let v52 : string = "std::path::PathBuf::from($0)"
    let v53 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v51 v52
    let v54 : string = "$0.exists()"
    let v55 : bool = Fable.Core.RustInterop.emitRustExpr v53 v54
    let v58 : bool =
        if v55 then
            let v56 : string = "$0.is_dir()"
            let v57 : bool = Fable.Core.RustInterop.emitRustExpr v53 v56
            v57
        else
            false
    v58
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v59 : bool = null |> unbox<bool>
    v59
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v60 : bool = null |> unbox<bool>
    v60
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v61 : string = "fs"
    let v62 : IFsExistsSync = Fable.Core.JsInterop.importAll v61
    let v63 : string = "v62.existsSync($0)"
    let v64 : bool = Fable.Core.JsInterop.emitJsExpr v44 v63
    v64
#endif
    
#if FABLE_COMPILER_PYTHON
    let v65 : bool = null |> unbox<bool>
    v65
#endif
    
#else
    let v66 : (string -> bool) = System.IO.Directory.Exists
    let v67 : bool = v66 v44
    v67
#endif
    |> fun x -> _v45 <- Some x
    let v68 : bool = _v45.Value
    if v68 then
        v1
    else
        let v69 : (string -> string option) = method21()
        let v70 : string option = v69 v1
        let v71 : (string -> US4) = method22()
        let v72 : US4 = US4_1
        let v73 : US4 = v70 |> Option.map v71 |> Option.defaultValue v72 
        match v73 with
        | US4_1 -> (* None *)
            let v76 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            failwith<string> v76
        | US4_0(v74) -> (* Some *)
            method23(v0, v1, v74)
and method24 () : string =
    let v0 : string = "polyglot"
    v0
and method25 (v0 : string) : string =
    v0
and method26 () : string =
    let v0 : string = "^\\\\\\\\\\?\\\\"
    v0
and method27 (v0 : string) : string =
    v0
and method28 () : string =
    let v0 : string = ""
    v0
and method29 (v0 : int32, v1 : Mut4) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method30 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method31 (v0 : string) : string =
    v0
and method32 (v0 : string) : string =
    v0
and closure12 () () : string =
    let v0 : string = "documents.run"
    v0
and closure13 (v0 : string, v1 : string, v2 : string, v3 : string) () : string =
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"source_dir: {v1} / dist_dir: {v2} / cache_dir: {v3} / hangul_spec: %A{v0} / {v4 ()}"
    v5
and method36 (v0 : async_walkdir_DirEntry) : async_walkdir_DirEntry =
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
and method37 () : (std_io_Error -> std_string_String) =
    closure15()
and closure16 () (v0 : std_fs_FileType) : US6 =
    US6_0(v0)
and closure17 () (v0 : std_string_String) : US6 =
    US6_1(v0)
and method38 (v0 : std_fs_FileType) : std_fs_FileType =
    v0
and method39 (v0 : US5) : US5 =
    v0
and method35 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<Send<Dyn<std_future_Future<US5>>>>> =
    let v1 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : async_walkdir_DirEntry = method36(v0)
    let v3 : string = "Box::pin(async_walkdir::DirEntry::file_type(&v2))"
    let v4 : std_pin_Pin<Box<Send<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>>>> = Fable.Core.RustInterop.emitRustExpr () v3
    let v5 : string = "v4.await"
    let v6 : Result<std_fs_FileType, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v5
    let v7 : (std_io_Error -> std_string_String) = method37()
    let v8 : string = "$0.map_err(|x| $1(x))"
    let v9 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6, v7) v8
    let v10 : (std_fs_FileType -> US6) = closure16()
    let v11 : (std_string_String -> US6) = closure17()
    let v12 : US6 = match v9 with Ok x -> v10 x | Error x -> v11 x
    let v73 : US5 =
        match v12 with
        | US6_0(v13) -> (* Ok *)
            let v14 : std_fs_FileType = method38(v13)
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
    let v74 : US5 = method39(v73)
    let v75 : string = "v74 }})"
    Fable.Core.RustInterop.emitRustExpr () v75
    let v76 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v76
    let v77 : string = "__result"
    let v78 : std_pin_Pin<Box<Send<Dyn<std_future_Future<US5>>>>> = Fable.Core.RustInterop.emitRustExpr () v77
    v78
and method40 (v0 : async_walkdir_Filtering) : async_walkdir_Filtering =
    v0
and method34 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>> =
    let v1 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : std_pin_Pin<Box<Send<Dyn<std_future_Future<US5>>>>> = method35(v0)
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
    let v14 : async_walkdir_Filtering = method40(v13)
    let v15 : string = "v14 }})"
    Fable.Core.RustInterop.emitRustExpr () v15
    let v16 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v16
    let v17 : string = "__result"
    let v18 : std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>> = Fable.Core.RustInterop.emitRustExpr () v17
    v18
and closure14 () (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>> =
    method34(v0)
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
    let v1 : (std_io_Error -> std_string_String) = method37()
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
and method41 () : (Result<async_walkdir_DirEntry, std_io_Error> -> string option) =
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
and method42 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : string option) : string =
    v1
and method43 () : struct (string * string) =
    let v0 : string = ""
    struct (v0, v0)
and closure27 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure26 () (v0 : char) : (UH0 -> UH0) =
    closure27(v0)
and method44 () : (char -> (UH0 -> UH0)) =
    closure26()
and method45 (v0 : string, v1 : string, v2 : UH0, v3 : US8) : struct (string * string) =
    match v2 with
    | UH0_1(v4, v5) -> (* Cons *)
        let v6 : bool = '"' = v4
        if v6 then
            let v8 : bool = v1 = ""
            if v8 then
                let v9 : US9 = US9_0
                let v10 : US8 = US8_1(v9)
                method45(v0, v1, v5, v10)
            else
                match v3 with
                | US8_2 -> (* Arguments *)
                    let v38 : string = $"{v0}{v4}"
                    let v39 : US8 = US8_2
                    method45(v38, v1, v5, v39)
                | US8_1(v13) -> (* Path *)
                    match v13 with
                    | US9_0 -> (* Quoted *)
                        let v14 : US9 = US9_1
                        let v15 : US8 = US8_1(v14)
                        method45(v0, v1, v5, v15)
                    | _ ->
                        let v18 : bool = ' ' = v4
                        if v18 then
                            let v19 : US8 = US8_2
                            method45(v0, v1, v5, v19)
                        else
                            let v22 : string = $"{v1}{v4}"
                            method45(v0, v22, v5, v3)
                | US8_0 -> (* Start *)
                    let v29 : bool = ' ' = v4
                    if v29 then
                        let v30 : US8 = US8_2
                        method45(v0, v1, v5, v30)
                    else
                        let v33 : string = $"{v1}{v4}"
                        method45(v0, v33, v5, v3)
        else
            let v50 : bool = ''' = v4
            if v50 then
                let v52 : bool = v1 = ""
                if v52 then
                    let v53 : US9 = US9_0
                    let v54 : US8 = US8_1(v53)
                    method45(v0, v1, v5, v54)
                else
                    match v3 with
                    | US8_2 -> (* Arguments *)
                        let v82 : string = $"{v0}{v4}"
                        let v83 : US8 = US8_2
                        method45(v82, v1, v5, v83)
                    | US8_1(v57) -> (* Path *)
                        match v57 with
                        | US9_0 -> (* Quoted *)
                            let v58 : US9 = US9_1
                            let v59 : US8 = US8_1(v58)
                            method45(v0, v1, v5, v59)
                        | _ ->
                            let v62 : bool = ' ' = v4
                            if v62 then
                                let v63 : US8 = US8_2
                                method45(v0, v1, v5, v63)
                            else
                                let v66 : string = $"{v1}{v4}"
                                method45(v0, v66, v5, v3)
                    | US8_0 -> (* Start *)
                        let v73 : bool = ' ' = v4
                        if v73 then
                            let v74 : US8 = US8_2
                            method45(v0, v1, v5, v74)
                        else
                            let v77 : string = $"{v1}{v4}"
                            method45(v0, v77, v5, v3)
            else
                match v3 with
                | US8_2 -> (* Arguments *)
                    let v126 : string = $"{v0}{v4}"
                    let v127 : US8 = US8_2
                    method45(v126, v1, v5, v127)
                | US8_1(v94) -> (* Path *)
                    match v94 with
                    | US9_0 -> (* Quoted *)
                        let v95 : bool = ' ' = v4
                        if v95 then
                            let v96 : string = $"{v1} "
                            let v97 : US9 = US9_0
                            let v98 : US8 = US8_1(v97)
                            method45(v0, v96, v5, v98)
                        else
                            let v101 : string = $"{v1}{v4}"
                            method45(v0, v101, v5, v3)
                    | _ ->
                        let v106 : bool = ' ' = v4
                        if v106 then
                            let v107 : US8 = US8_2
                            method45(v0, v1, v5, v107)
                        else
                            let v110 : string = $"{v1}{v4}"
                            method45(v0, v110, v5, v3)
                | US8_0 -> (* Start *)
                    let v117 : bool = ' ' = v4
                    if v117 then
                        let v118 : US8 = US8_2
                        method45(v0, v1, v5, v118)
                    else
                        let v121 : string = $"{v1}{v4}"
                        method45(v0, v121, v5, v3)
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
and method49 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = method49(v3, v1)
        UH1_1(v2, v4)
    | UH1_0 -> (* Nil *)
        v1
and method48 (v0 : string, v1 : UH1, v2 : UH0, v3 : US10) : struct (UH1 * string) =
    match v3 with
    | US10_2(v44) -> (* Escaped *)
        match v2 with
        | UH0_1(v45, v46) -> (* Cons *)
            let v47 : bool = '\\' = v45
            if v47 then
                let v48 : char = '\\'
                let v49 : US10 = US10_1(v48)
                method47(v0, v1, v46, v3, v49)
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
                        method48(v0, v1, v46, v3)
                    else
                        let v57 : string = $"{v0}\""
                        let v58 : US10 = US10_2(v44)
                        method47(v57, v1, v46, v3, v58)
                else
                    let v63 : bool = ' ' = v45
                    if v63 then
                        let v64 : string = $"{v0} "
                        method48(v64, v1, v46, v3)
                    else
                        let v67 : bool = 1uy = v44
                        if v67 then
                            let v68 : bool = v3 <> v3
                            if v68 then
                                let v69 : string = $"{v0}\{v45}"
                                method48(v69, v1, v46, v3)
                            else
                                let v72 : string = $"{v0}{v45}"
                                method48(v72, v1, v46, v3)
                        else
                            let v77 : string = $"{v0}{v45}"
                            method48(v77, v1, v46, v3)
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
                        method49(v1, v92)
                struct (v94, v0)
            else
                let v96 : bool = v0 = ""
                let v100 : UH1 =
                    if v96 then
                        v1
                    else
                        let v97 : UH1 = UH1_0
                        let v98 : UH1 = UH1_1(v0, v97)
                        method49(v1, v98)
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
                        method47(v0, v1, v108, v3, v112)
                    else
                        let v115 : bool = '\\' = v105
                        if v115 then
                            let v116 : US10 = US10_2(0uy)
                            let v117 : bool = v3 <> v116
                            if v117 then
                                let v118 : string = $"{v0}\""
                                let v119 : char = '"'
                                let v120 : US10 = US10_1(v119)
                                method47(v118, v1, v108, v3, v120)
                            else
                                let v123 : US10 = US10_1('\\')
                                let v124 : bool = v3 = v123
                                if v124 then
                                    let v125 : string = $"{v0}\""
                                    let v126 : char = '"'
                                    let v127 : US10 = US10_1(v126)
                                    method47(v125, v1, v108, v3, v127)
                                else
                                    let v130 : US10 = US10_0
                                    method47(v0, v1, v108, v3, v130)
                        else
                            let v137 : bool = '\\' = v107
                            if v137 then
                                let v138 : uint8 = 1uy
                                let v139 : US10 = US10_2(v138)
                                method47(v0, v1, v108, v3, v139)
                            else
                                let v142 : US10 = US10_2(0uy)
                                let v143 : bool = v3 = v142
                                if v143 then
                                    let v144 : string = $"{v0}\""
                                    let v145 : char = '"'
                                    let v146 : US10 = US10_1(v145)
                                    method47(v144, v1, v108, v3, v146)
                                else
                                    let v149 : UH1 = UH1_0
                                    let v150 : UH1 = UH1_1(v0, v149)
                                    let v151 : UH1 = method49(v1, v150)
                                    let v152 : string = ""
                                    let v153 : US10 = US10_0
                                    method47(v152, v151, v108, v3, v153)
                else
                    let v164 : bool = '\\' = v105
                    if v164 then
                        let v165 : bool = '\\' = v107
                        if v165 then
                            let v166 : uint8 = 1uy
                            let v167 : US10 = US10_2(v166)
                            method47(v0, v1, v108, v3, v167)
                        else
                            let v170 : bool = ' ' = v107
                            if v170 then
                                let v171 : string = $"{v0} "
                                method48(v171, v1, v108, v3)
                            else
                                let v174 : string = $"{v0}{v107}"
                                method48(v174, v1, v108, v3)
                    else
                        let v181 : bool = '\\' = v107
                        if v181 then
                            let v182 : uint8 = 1uy
                            let v183 : US10 = US10_2(v182)
                            method47(v0, v1, v108, v3, v183)
                        else
                            let v186 : bool = ' ' = v107
                            if v186 then
                                let v187 : string = $"{v0} "
                                method48(v187, v1, v108, v3)
                            else
                                let v190 : string = $"{v0}{v107}"
                                method48(v190, v1, v108, v3)
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
                            method49(v1, v205)
                    struct (v207, v0)
                else
                    let v209 : bool = v0 = ""
                    let v213 : UH1 =
                        if v209 then
                            v1
                        else
                            let v210 : UH1 = UH1_0
                            let v211 : UH1 = UH1_1(v0, v210)
                            method49(v1, v211)
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
                            method47(v224, v1, v220, v3, v226)
                        else
                            let v229 : US10 = US10_1('\\')
                            let v230 : bool = v3 = v229
                            if v230 then
                                let v231 : string = $"{v0}\""
                                let v232 : char = '"'
                                let v233 : US10 = US10_1(v232)
                                method47(v231, v1, v220, v3, v233)
                            else
                                let v236 : US10 = US10_0
                                method47(v0, v1, v220, v3, v236)
                    else
                        let v243 : bool = '\\' = v219
                        if v243 then
                            let v244 : uint8 = 1uy
                            let v245 : US10 = US10_2(v244)
                            method47(v0, v1, v220, v3, v245)
                        else
                            let v248 : bool = ' ' = v219
                            if v248 then
                                let v249 : string = $"{v0} "
                                method48(v249, v1, v220, v3)
                            else
                                let v252 : string = $"{v0}{v219}"
                                method48(v252, v1, v220, v3)
                | _ ->
                    let v262 : bool = v0 = ""
                    let v266 : UH1 =
                        if v262 then
                            v1
                        else
                            let v263 : UH1 = UH1_0
                            let v264 : UH1 = UH1_1(v0, v263)
                            method49(v1, v264)
                    struct (v266, v0)
            else
                match v2 with
                | UH0_1(v269, v270) -> (* Cons *)
                    let v271 : bool = '\\' = v269
                    if v271 then
                        let v272 : uint8 = 1uy
                        let v273 : US10 = US10_2(v272)
                        method47(v0, v1, v270, v3, v273)
                    else
                        let v276 : bool = '"' = v269
                        if v276 then
                            let v277 : US10 = US10_2(0uy)
                            let v278 : bool = v3 = v277
                            if v278 then
                                let v279 : string = $"{v0}\""
                                let v280 : char = '"'
                                let v281 : US10 = US10_1(v280)
                                method47(v279, v1, v270, v3, v281)
                            else
                                let v284 : UH1 = UH1_0
                                let v285 : UH1 = UH1_1(v0, v284)
                                let v286 : UH1 = method49(v1, v285)
                                let v287 : string = ""
                                let v288 : US10 = US10_0
                                method47(v287, v286, v270, v3, v288)
                        else
                            let v293 : bool = ' ' = v269
                            if v293 then
                                let v294 : string = $"{v0} "
                                method48(v294, v1, v270, v3)
                            else
                                let v297 : string = $"{v0}{v269}"
                                method48(v297, v1, v270, v3)
                | _ ->
                    let v307 : bool = v0 = ""
                    let v311 : UH1 =
                        if v307 then
                            v1
                        else
                            let v308 : UH1 = UH1_0
                            let v309 : UH1 = UH1_1(v0, v308)
                            method49(v1, v309)
                    struct (v311, v0)
    | US10_0 -> (* Start *)
        match v2 with
        | UH0_1(v4, v5) -> (* Cons *)
            let v6 : bool = '"' = v4
            if v6 then
                let v7 : string = ""
                let v8 : char = '"'
                let v9 : US10 = US10_1(v8)
                method47(v7, v1, v5, v3, v9)
            else
                let v12 : bool = '\\' = v4
                if v12 then
                    let v13 : uint8 = 0uy
                    let v14 : US10 = US10_2(v13)
                    method47(v0, v1, v5, v3, v14)
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
                                method49(v1, v21)
                        let v24 : string = ""
                        method48(v24, v23, v5, v3)
                    else
                        let v27 : string = $"{v0}{v4}"
                        method48(v27, v1, v5, v3)
        | _ ->
            let v37 : bool = v0 = ""
            let v41 : UH1 =
                if v37 then
                    v1
                else
                    let v38 : UH1 = UH1_0
                    let v39 : UH1 = UH1_1(v0, v38)
                    method49(v1, v39)
            struct (v41, v0)
and method47 (v0 : string, v1 : UH1, v2 : UH0, v3 : US10, v4 : US10) : struct (UH1 * string) =
    match v4 with
    | US10_2(v45) -> (* Escaped *)
        match v2 with
        | UH0_1(v46, v47) -> (* Cons *)
            let v48 : bool = '\\' = v46
            if v48 then
                let v49 : char = '\\'
                let v50 : US10 = US10_1(v49)
                method47(v0, v1, v47, v4, v50)
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
                        method48(v0, v1, v47, v4)
                    else
                        let v58 : string = $"{v0}\""
                        let v59 : US10 = US10_2(v45)
                        method47(v58, v1, v47, v4, v59)
                else
                    let v64 : bool = ' ' = v46
                    if v64 then
                        let v65 : string = $"{v0} "
                        method48(v65, v1, v47, v4)
                    else
                        let v68 : bool = 1uy = v45
                        if v68 then
                            let v69 : bool = v3 <> v4
                            if v69 then
                                let v70 : string = $"{v0}\{v46}"
                                method47(v70, v1, v47, v4, v3)
                            else
                                let v73 : string = $"{v0}{v46}"
                                method48(v73, v1, v47, v4)
                        else
                            let v78 : string = $"{v0}{v46}"
                            method48(v78, v1, v47, v4)
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
                        method49(v1, v93)
                struct (v95, v0)
            else
                let v97 : bool = v0 = ""
                let v101 : UH1 =
                    if v97 then
                        v1
                    else
                        let v98 : UH1 = UH1_0
                        let v99 : UH1 = UH1_1(v0, v98)
                        method49(v1, v99)
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
                        method47(v0, v1, v109, v4, v113)
                    else
                        let v116 : bool = '\\' = v106
                        if v116 then
                            let v117 : US10 = US10_2(0uy)
                            let v118 : bool = v3 <> v117
                            if v118 then
                                let v119 : string = $"{v0}\""
                                let v120 : char = '"'
                                let v121 : US10 = US10_1(v120)
                                method47(v119, v1, v109, v4, v121)
                            else
                                let v124 : US10 = US10_1('\\')
                                let v125 : bool = v3 = v124
                                if v125 then
                                    let v126 : string = $"{v0}\""
                                    let v127 : char = '"'
                                    let v128 : US10 = US10_1(v127)
                                    method47(v126, v1, v109, v4, v128)
                                else
                                    let v131 : US10 = US10_0
                                    method47(v0, v1, v109, v4, v131)
                        else
                            let v138 : bool = '\\' = v108
                            if v138 then
                                let v139 : uint8 = 1uy
                                let v140 : US10 = US10_2(v139)
                                method47(v0, v1, v109, v4, v140)
                            else
                                let v143 : US10 = US10_2(0uy)
                                let v144 : bool = v3 = v143
                                if v144 then
                                    let v145 : string = $"{v0}\""
                                    let v146 : char = '"'
                                    let v147 : US10 = US10_1(v146)
                                    method47(v145, v1, v109, v4, v147)
                                else
                                    let v150 : UH1 = UH1_0
                                    let v151 : UH1 = UH1_1(v0, v150)
                                    let v152 : UH1 = method49(v1, v151)
                                    let v153 : string = ""
                                    let v154 : US10 = US10_0
                                    method47(v153, v152, v109, v4, v154)
                else
                    let v165 : bool = '\\' = v106
                    if v165 then
                        let v166 : bool = '\\' = v108
                        if v166 then
                            let v167 : uint8 = 1uy
                            let v168 : US10 = US10_2(v167)
                            method47(v0, v1, v109, v4, v168)
                        else
                            let v171 : bool = ' ' = v108
                            if v171 then
                                let v172 : string = $"{v0} "
                                method48(v172, v1, v109, v4)
                            else
                                let v175 : string = $"{v0}{v108}"
                                method48(v175, v1, v109, v4)
                    else
                        let v182 : bool = '\\' = v108
                        if v182 then
                            let v183 : uint8 = 1uy
                            let v184 : US10 = US10_2(v183)
                            method47(v0, v1, v109, v4, v184)
                        else
                            let v187 : bool = ' ' = v108
                            if v187 then
                                let v188 : string = $"{v0} "
                                method48(v188, v1, v109, v4)
                            else
                                let v191 : string = $"{v0}{v108}"
                                method48(v191, v1, v109, v4)
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
                            method49(v1, v206)
                    struct (v208, v0)
                else
                    let v210 : bool = v0 = ""
                    let v214 : UH1 =
                        if v210 then
                            v1
                        else
                            let v211 : UH1 = UH1_0
                            let v212 : UH1 = UH1_1(v0, v211)
                            method49(v1, v212)
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
                            method47(v225, v1, v221, v4, v227)
                        else
                            let v230 : US10 = US10_1('\\')
                            let v231 : bool = v3 = v230
                            if v231 then
                                let v232 : string = $"{v0}\""
                                let v233 : char = '"'
                                let v234 : US10 = US10_1(v233)
                                method47(v232, v1, v221, v4, v234)
                            else
                                let v237 : US10 = US10_0
                                method47(v0, v1, v221, v4, v237)
                    else
                        let v244 : bool = '\\' = v220
                        if v244 then
                            let v245 : uint8 = 1uy
                            let v246 : US10 = US10_2(v245)
                            method47(v0, v1, v221, v4, v246)
                        else
                            let v249 : bool = ' ' = v220
                            if v249 then
                                let v250 : string = $"{v0} "
                                method48(v250, v1, v221, v4)
                            else
                                let v253 : string = $"{v0}{v220}"
                                method48(v253, v1, v221, v4)
                | _ ->
                    let v263 : bool = v0 = ""
                    let v267 : UH1 =
                        if v263 then
                            v1
                        else
                            let v264 : UH1 = UH1_0
                            let v265 : UH1 = UH1_1(v0, v264)
                            method49(v1, v265)
                    struct (v267, v0)
            else
                match v2 with
                | UH0_1(v270, v271) -> (* Cons *)
                    let v272 : bool = '\\' = v270
                    if v272 then
                        let v273 : uint8 = 1uy
                        let v274 : US10 = US10_2(v273)
                        method47(v0, v1, v271, v4, v274)
                    else
                        let v277 : bool = '"' = v270
                        if v277 then
                            let v278 : US10 = US10_2(0uy)
                            let v279 : bool = v3 = v278
                            if v279 then
                                let v280 : string = $"{v0}\""
                                let v281 : char = '"'
                                let v282 : US10 = US10_1(v281)
                                method47(v280, v1, v271, v4, v282)
                            else
                                let v285 : UH1 = UH1_0
                                let v286 : UH1 = UH1_1(v0, v285)
                                let v287 : UH1 = method49(v1, v286)
                                let v288 : string = ""
                                let v289 : US10 = US10_0
                                method47(v288, v287, v271, v4, v289)
                        else
                            let v294 : bool = ' ' = v270
                            if v294 then
                                let v295 : string = $"{v0} "
                                method48(v295, v1, v271, v4)
                            else
                                let v298 : string = $"{v0}{v270}"
                                method48(v298, v1, v271, v4)
                | _ ->
                    let v308 : bool = v0 = ""
                    let v312 : UH1 =
                        if v308 then
                            v1
                        else
                            let v309 : UH1 = UH1_0
                            let v310 : UH1 = UH1_1(v0, v309)
                            method49(v1, v310)
                    struct (v312, v0)
    | US10_0 -> (* Start *)
        match v2 with
        | UH0_1(v5, v6) -> (* Cons *)
            let v7 : bool = '"' = v5
            if v7 then
                let v8 : string = ""
                let v9 : char = '"'
                let v10 : US10 = US10_1(v9)
                method47(v8, v1, v6, v4, v10)
            else
                let v13 : bool = '\\' = v5
                if v13 then
                    let v14 : uint8 = 0uy
                    let v15 : US10 = US10_2(v14)
                    method47(v0, v1, v6, v4, v15)
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
                                method49(v1, v22)
                        let v25 : string = ""
                        method48(v25, v24, v6, v4)
                    else
                        let v28 : string = $"{v0}{v5}"
                        method48(v28, v1, v6, v4)
        | _ ->
            let v38 : bool = v0 = ""
            let v42 : UH1 =
                if v38 then
                    v1
                else
                    let v39 : UH1 = UH1_0
                    let v40 : UH1 = UH1_1(v0, v39)
                    method49(v1, v40)
            struct (v42, v0)
and method50 (v0 : UH1, v1 : string list) : string list =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : string list = method50(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH1_0 -> (* Nil *)
        v1
and method46 (v0 : string) : (string []) =
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
    let v7 : (string -> US4) = method22()
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
    while method30(v13, v15) do
        let v17 : int32 = v15.l0
        let v18 : char = v12.[int v17]
        v14.[int v17] <- v18
        let v19 : int32 = v17 + 1
        v15.l0 <- v19
        ()
    let v20 : ((char []) -> char list) = Array.toList
    let v21 : char list = v20 v14
    let v22 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v23 : (char -> (UH0 -> UH0)) = method44()
    let v24 : (char list -> (UH0 -> UH0)) = v22 v23
    let v25 : (UH0 -> UH0) = v24 v21
    let v26 : UH0 = UH0_0
    let v27 : UH0 = v25 v26
    let v28 : US10 = US10_0
    let v29 : US10 = US10_0
    let struct (v30 : UH1, v31 : string) = method47(v2, v1, v27, v29, v28)
    let v32 : string list = []
    let v33 : string list = method50(v30, v32)
    let v34 : (string list -> (string [])) = List.toArray
    let v35 : (string []) = v34 v33
    v35
and closure28 () (v0 : string) : std_string_String =
    let v1 : string = method18(v0)
    let v2 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    v5
and closure29 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : string option, v6 : string, v7 : Vec<std_string_String>) () : string =
    let v8 : string = $"execute_with_options / file_name: {v6} / arguments: %A{v7} / options: %A{struct (v0, v1, v2, v3, v4, v5)}"
    v8
and method51 () : (unit -> string) =
    closure6()
and method53 (v0 : string) : string =
    v0
and method55 (v0 : std_sync_Mutex<std_process_Child option>) : std_sync_Mutex<std_process_Child option> =
    v0
and closure30 () (v0 : std_process_Child) : std_sync_Arc<std_sync_Mutex<std_process_Child option>> =
    let v1 : std_process_Child option = Some v0 
    let v2 : string = "std::sync::Mutex::new($0)"
    let v3 : std_sync_Mutex<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : std_sync_Mutex<std_process_Child option> = method55(v3)
    let v5 : string = "std::sync::Arc::new(v4)"
    let v6 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr () v5
    v6
and method54 () : (std_process_Child -> std_sync_Arc<std_sync_Mutex<std_process_Child option>>) =
    closure30()
and method56 (v0 : Result<std_process_Child, std_io_Error>) : Result<std_process_Child, std_io_Error> =
    v0
and closure31 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : US11 =
    US11_0(v0)
and closure32 () (v0 : std_string_String) : US11 =
    US11_1(v0)
and closure33 (v0 : std_string_String) () : string =
    let v1 : string = $"execute_with_options -1 / error: {v0}"
    v1
and method57 (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : std_sync_Arc<std_sync_Mutex<std_process_Child option>> =
    v0
and method58 (v0 : std_sync_Mutex<std_process_ChildStdout option>) : std_sync_Mutex<std_process_ChildStdout option> =
    v0
and method59 (v0 : std_sync_Mutex<std_process_ChildStderr option>) : std_sync_Mutex<std_process_ChildStderr option> =
    v0
and method60 (v0 : std_sync_Mutex<std_process_ChildStdin option>) : std_sync_Mutex<std_process_ChildStdin option> =
    v0
and method61 (v0 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> =
    v0
and method62 (v0 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>) : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> =
    v0
and method63 (v0 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>) : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> =
    v0
and method64 (v0 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>>) : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> =
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
    let v2 : (std_io_Error -> std_string_String) = method37()
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
            let v17 : string = method18(v16)
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
and method65 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) : (Result<std_string_String, std_io_Error> -> unit) =
    closure34(v0)
and method66 (v0 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>>) : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>> =
    v0
and closure40 (v0 : std_string_String) () : string =
    let v1 : string = $"execute_with_options / stdout_line / stdout: {false} / e: {v0}"
    v1
and closure39 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) (v1 : Result<std_string_String, std_io_Error>) : unit =
    let v2 : (std_io_Error -> std_string_String) = method37()
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
            let v17 : string = method18(v16)
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
and method67 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) : (Result<std_string_String, std_io_Error> -> unit) =
    closure39(v0)
and closure41 () (v0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)) : US14 =
    US14_0(v0)
and method68 () : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US14) =
    closure41()
and method69 (v0 : std_sync_Mutex<std_process_ChildStdin>) : std_sync_Mutex<std_process_ChildStdin> =
    v0
and closure42 () (v0 : std_process_ChildStdin) : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> =
    let v1 : string = "std::sync::Mutex::new($0)"
    let v2 : std_sync_Mutex<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : std_sync_Mutex<std_process_ChildStdin> = method69(v2)
    let v4 : string = "std::sync::Arc::new(v3)"
    let v5 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr () v4
    v5
and closure43 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : US15 =
    US15_0(v0)
and method70 () : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US15) =
    closure43()
and method71 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
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
and method72 (v0 : (int32 * string)) : (int32 * string) =
    v0
and method52 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : string option, v6 : string, v7 : Vec<std_string_String>) : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> =
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
    let v27 : (string -> US4) = method22()
    let v28 : US4 = US4_1
    let v29 : US4 = v5 |> Option.map v27 |> Option.defaultValue v28 
    let v35 : Ref<Mut<std_process_Command>> =
        match v29 with
        | US4_1 -> (* None *)
            v26
        | US4_0(v30) -> (* Some *)
            let v31 : string = method53(v30)
            let v32 : string = "std::process::Command::current_dir(v26, &*v31)"
            let v33 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr () v32
            v33
    let v36 : string = "true; let mut v35 = v35"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : string = "std::process::Command::spawn(&mut $0)"
    let v39 : Result<std_process_Child, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v35 v38
    let v40 : (std_process_Child -> std_sync_Arc<std_sync_Mutex<std_process_Child option>>) = method54()
    let v41 : Result<std_process_Child, std_io_Error> = method56(v39)
    let v42 : string = "v41.map(|x| v40(x))"
    let v43 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : (std_io_Error -> std_string_String) = method37()
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
            let v51 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method57(v50)
            let v52 : string = "v51.lock().unwrap().as_mut().unwrap().stdout.take().unwrap()"
            let v53 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr () v52
            let v54 : string = "v51.lock().unwrap().as_mut().unwrap().stderr.take().unwrap()"
            let v55 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr () v54
            let v56 : string = "v51.lock().unwrap().as_mut().unwrap().stdin.take().unwrap()"
            let v57 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr () v56
            let v58 : std_process_ChildStdout option = Some v53 
            let v59 : string = "std::sync::Mutex::new($0)"
            let v60 : std_sync_Mutex<std_process_ChildStdout option> = Fable.Core.RustInterop.emitRustExpr v58 v59
            let v61 : std_sync_Mutex<std_process_ChildStdout option> = method58(v60)
            let v62 : string = "std::sync::Arc::new(v61)"
            let v63 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdout option>> = Fable.Core.RustInterop.emitRustExpr () v62
            let v64 : std_process_ChildStderr option = Some v55 
            let v65 : string = "std::sync::Mutex::new($0)"
            let v66 : std_sync_Mutex<std_process_ChildStderr option> = Fable.Core.RustInterop.emitRustExpr v64 v65
            let v67 : std_sync_Mutex<std_process_ChildStderr option> = method59(v66)
            let v68 : string = "std::sync::Arc::new(v67)"
            let v69 : std_sync_Arc<std_sync_Mutex<std_process_ChildStderr option>> = Fable.Core.RustInterop.emitRustExpr () v68
            let v70 : std_process_ChildStdin option = Some v57 
            let v71 : string = "std::sync::Mutex::new($0)"
            let v72 : std_sync_Mutex<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v70 v71
            let v73 : std_sync_Mutex<std_process_ChildStdin option> = method60(v72)
            let v74 : string = "std::sync::Arc::new(v73)"
            let v75 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v74
            let v76 : string = "{ let (sender, receiver) = std::sync::mpsc::channel(); (sender, std::sync::Arc::new(receiver)) }"
            let struct (v77 : std_sync_mpsc_Sender<std_string_String>, v78 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = Fable.Core.RustInterop.emitRustExpr () v76
            let v79 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> = method61(v78)
            let v80 : string = "true; let v79 = v79"
            let v81 : bool = Fable.Core.RustInterop.emitRustExpr v79 v80
            let v82 : string = "std::sync::Mutex::new($0)"
            let v83 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v77 v82
            let v84 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = method62(v83)
            let v85 : string = "std::sync::Arc::new(v84)"
            let v86 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v85
            let v87 : string = "v86.clone()"
            let v88 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v87
            let v89 : string = "v86.clone()"
            let v90 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v89
            let v91 : string = "std::sync::Mutex::new($0)"
            let v92 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v79 v91
            let v93 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = method63(v92)
            let v94 : string = "std::sync::Arc::new(v93)"
            let v95 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v94
            let v96 : string = "std::thread::spawn(move || { //"
            let v97 : std_thread_JoinHandle<unit> = Fable.Core.RustInterop.emitRustExpr () v96
            let v98 : string = "std::io::BufRead::lines(std::io::BufReader::new(v63.lock().unwrap().take().unwrap()))"
            let v99 : std_io_Lines<std_io_BufReader<std_process_ChildStdout>> = Fable.Core.RustInterop.emitRustExpr () v98
            let v100 : string = "std::sync::Mutex::new($0)"
            let v101 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> = Fable.Core.RustInterop.emitRustExpr v99 v100
            let v102 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> = method64(v101)
            let v103 : string = "std::sync::Arc::new(v102)"
            let v104 : std_sync_Arc<std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>>> = Fable.Core.RustInterop.emitRustExpr () v103
            let v105 : (Result<std_string_String, std_io_Error> -> unit) = method65(v88)
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
            let v116 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>> = method66(v115)
            let v117 : string = "std::sync::Arc::new(v116)"
            let v118 : std_sync_Arc<std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>>> = Fable.Core.RustInterop.emitRustExpr () v117
            let v119 : (Result<std_string_String, std_io_Error> -> unit) = method67(v86)
            let v120 : string = "true; for line in $0.lock().unwrap().by_ref() { v119(line) }"
            let v121 : bool = Fable.Core.RustInterop.emitRustExpr v118 v120
            let v122 : string = "true; })"
            let v123 : bool = Fable.Core.RustInterop.emitRustExpr () v122
            let v124 : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US14) = method68()
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
                let v133 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US15) = method70()
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
                    let v141 : std_sync_MutexGuard<std_process_ChildStdin> = method71(v140)
                    let v142 : string = "true; let mut v141 = v141"
                    let v143 : bool = Fable.Core.RustInterop.emitRustExpr () v142
                    let v144 : string = "true; std::io::Write::flush(&mut *$0).unwrap()"
                    let v145 : bool = Fable.Core.RustInterop.emitRustExpr v141 v144
                    ()
            let v146 : string = "v51.lock().unwrap().take().unwrap().wait_with_output()"
            let v147 : Result<std_process_Output, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v146
            let v148 : (std_io_Error -> std_string_String) = method37()
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
    let v219 : (int32 * string) = method72(v218)
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
and method73 () : ((struct (bool * string * int32) -> Async<unit>) -> US17) =
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
        let v21 : ((struct (bool * string * int32) -> Async<unit>) -> US17) = method73()
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
        let v21 : ((struct (bool * string * int32) -> Async<unit>) -> US17) = method73()
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
and method74 () : (System.Threading.CancellationToken -> US18) =
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
and method75 () : string =
    let v0 : string = "\n"
    v0
and closure56 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"execute_with_options_async / exit_code: {v0} / output.Length: {v1.Length}"
    v2
and method76 (v0 : int32, v1 : Mut6) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method77 (v0 : string) : string =
    v0
and method78 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure58 (v0 : string) (v1 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : unit =
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
and closure59 () () : string =
    let v0 : string = "documents.run / par_map / files_fn"
    v0
and closure60 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: %A{v1} / result: {v0} / {v2 ()}"
    v3
and method81 (v0 : string) : string =
    v0
and closure57 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : string) : US19 =
    let v5 : string = ".md"
    let v6 : bool = v4.EndsWith v5
    let v7 : bool = v6 = false
    let v14 : string =
        if v7 then
            let v8 : string = $"{v0}.{v4}"
            v8
        else
            let v9 : string = "."
            let v10 : int32 = v0.LastIndexOf v9
            let v11 : int32 = v10 - 1
            let v12 : string = v0.[int 0..int v11]
            let v13 : string = $"{v12}.{v4}"
            v13
    let v15 : bool = v4.EndsWith v5
    let v16 : bool = v15 = false
    let v23 : string =
        if v16 then
            let v17 : string = $"{v1}.{v4}"
            v17
        else
            let v18 : string = "."
            let v19 : int32 = v1.LastIndexOf v18
            let v20 : int32 = v19 - 1
            let v21 : string = v1.[int 0..int v20]
            let v22 : string = $"{v21}.{v4}"
            v22
    let v24 : bool option = None
    let v25 : bool = true in let mutable _v24 = v24
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v26 : string = method18(v14)
    let v27 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v28 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v26 v27
    let v29 : string = "String::from($0)"
    let v30 : std_string_String = Fable.Core.RustInterop.emitRustExpr v28 v29
    let v31 : string = "std::path::PathBuf::from($0)"
    let v32 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v33 : string = "$0.exists()"
    let v34 : bool = Fable.Core.RustInterop.emitRustExpr v32 v33
    let v37 : bool =
        if v34 then
            let v35 : string = "$0.is_file()"
            let v36 : bool = Fable.Core.RustInterop.emitRustExpr v32 v35
            v36
        else
            false
    v37
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v38 : bool = null |> unbox<bool>
    v38
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : bool = null |> unbox<bool>
    v39
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v40 : string = "fs"
    let v41 : IFsExistsSync = Fable.Core.JsInterop.importAll v40
    let v42 : string = "v41.existsSync($0)"
    let v43 : bool = Fable.Core.JsInterop.emitJsExpr v14 v42
    v43
#endif
    
#if FABLE_COMPILER_PYTHON
    let v44 : bool = null |> unbox<bool>
    v44
#endif
    
#else
    let v45 : (string -> bool) = System.IO.File.Exists
    let v46 : bool = v45 v14
    v46
#endif
    |> fun x -> _v24 <- Some x
    let v47 : bool = _v24.Value
    let v71 : bool =
        if v47 then
            let v48 : bool option = None
            let v49 : bool = true in let mutable _v48 = v48
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v50 : string = method18(v23)
            let v51 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v52 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v50 v51
            let v53 : string = "String::from($0)"
            let v54 : std_string_String = Fable.Core.RustInterop.emitRustExpr v52 v53
            let v55 : string = "std::path::PathBuf::from($0)"
            let v56 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v54 v55
            let v57 : string = "$0.exists()"
            let v58 : bool = Fable.Core.RustInterop.emitRustExpr v56 v57
            let v61 : bool =
                if v58 then
                    let v59 : string = "$0.is_file()"
                    let v60 : bool = Fable.Core.RustInterop.emitRustExpr v56 v59
                    v60
                else
                    false
            v61
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v62 : bool = null |> unbox<bool>
            v62
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v63 : bool = null |> unbox<bool>
            v63
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v64 : IFsExistsSync = Fable.Core.JsInterop.importAll v40
            let v65 : string = "v64.existsSync($0)"
            let v66 : bool = Fable.Core.JsInterop.emitJsExpr v23 v65
            v66
#endif
            
#if FABLE_COMPILER_PYTHON
            let v67 : bool = null |> unbox<bool>
            v67
#endif
            
#else
            let v68 : (string -> bool) = System.IO.File.Exists
            let v69 : bool = v68 v23
            v69
#endif
            |> fun x -> _v48 <- Some x
            let v70 : bool = _v48.Value
            v70
        else
            false
    let v592 : bool =
        if v71 then
            let v72 : bool option = None
            let v73 : bool = true in let mutable _v72 = v72
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v74 : string = "cfg!(windows)"
            let v75 : bool = Fable.Core.RustInterop.emitRustExpr () v74
            v75
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v76 : bool = null |> unbox<bool>
            v76
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v77 : bool = null |> unbox<bool>
            v77
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v78 : bool = null |> unbox<bool>
            v78
#endif
            
#if FABLE_COMPILER_PYTHON
            let v79 : bool = null |> unbox<bool>
            v79
#endif
            
#else
            let v80 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v81 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v82 : bool = v81 v80
            v82
#endif
            |> fun x -> _v72 <- Some x
            let v83 : bool = _v72.Value
            let v84 : bool = v83 = false
            let v108 : string =
                if v84 then
                    v14
                else
                    let v85 : string option = None
                    let v86 : bool = true in let mutable _v85 = v85
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v87 : string = method26()
                    let v88 : string = method27(v14)
                    let v89 : string = method28()
                    let v90 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v91 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v87, v88, v89) v90
                    let v92 : string = "String::from($0)"
                    let v93 : std_string_String = Fable.Core.RustInterop.emitRustExpr v91 v92
                    let v94 : string = "fable_library_rust::String_::fromString($0)"
                    let v95 : string = Fable.Core.RustInterop.emitRustExpr v93 v94
                    v95
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v96 : string = null |> unbox<string>
                    v96
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v97 : string = null |> unbox<string>
                    v97
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v98 : string = null |> unbox<string>
                    v98
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v99 : string = null |> unbox<string>
                    v99
#endif
                    
#else
                    let v100 : string = "^\\\\\\\\\\?\\\\"
                    let v101 : string = ""
                    let v102 : string = System.Text.RegularExpressions.Regex.Replace (v14, v100, v101)
                    v102
#endif
                    |> fun x -> _v85 <- Some x
                    let v103 : string = _v85.Value
                    let v104 : string = $"{v103.[0] |> string |> _.ToLower()}{v103.[1..]}"
                    let v105 : string = "\\"
                    let v106 : string = "/"
                    let v107 : string = v104.Replace (v105, v106)
                    v107
            let v109 : string option = None
            let v110 : System.Threading.CancellationToken option = None
            let v111 : (struct (string * string) []) = [||]
            let v112 : (struct (bool * string * int32) -> Async<unit>) option = None
            let v113 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
            let v114 : string = $"pwsh -c \"(Get-FileHash \\\"{v108}\\\" -Algorithm SHA256).Hash\""
            let v115 : struct (int32 * string) option = None
            let v116 : bool = true in let mutable _v115 = v115
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v117 : string = method42(v110, v114, v111, v112, v113, v109)
            let struct (v118 : string, v119 : string) = method43()
            let v120 : int32 = v117.Length
            let v121 : (char []) = Array.zeroCreate<char> (v120)
            let v122 : Mut5 = {l0 = 0} : Mut5
            while method30(v120, v122) do
                let v124 : int32 = v122.l0
                let v125 : char = v117.[int v124]
                v121.[int v124] <- v125
                let v126 : int32 = v124 + 1
                v122.l0 <- v126
                ()
            let v127 : ((char []) -> char list) = Array.toList
            let v128 : char list = v127 v121
            let v129 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v130 : (char -> (UH0 -> UH0)) = method44()
            let v131 : (char list -> (UH0 -> UH0)) = v129 v130
            let v132 : (UH0 -> UH0) = v131 v128
            let v133 : UH0 = UH0_0
            let v134 : UH0 = v132 v133
            let v135 : US8 = US8_0
            let struct (v136 : string, v137 : string) = method45(v119, v118, v134, v135)
            let v138 : (string []) = method46(v137)
            let v139 : string = "$0.to_vec()"
            let v140 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v138 v139
            let v141 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v142 : (string -> std_string_String) = closure28()
            let v143 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v140, v142) v141
            let v144 : US0 = US0_1
            let v145 : (unit -> string) = closure29(v110, v114, v111, v112, v113, v109, v136, v143)
            let v146 : (unit -> string) = method51()
            method3(v144, v145, v146)
            let v147 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method52(v110, v114, v111, v112, v113, v109, v136, v143)
            let v148 : string = "futures_lite::future::block_on($0)"
            let v149 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v147 v148
            let (a, b) = v149
            let v150 : int32 = a
            let v151 : string = b
            struct (v150, v151)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v152 : int32, v153 : string) = null |> unbox<struct (int32 * string)>
            struct (v152, v153)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v154 : int32, v155 : string) = null |> unbox<struct (int32 * string)>
            struct (v154, v155)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v156 : int32, v157 : string) = null |> unbox<struct (int32 * string)>
            struct (v156, v157)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v158 : int32, v159 : string) = null |> unbox<struct (int32 * string)>
            struct (v158, v159)
#endif
            
#else
            let v160 : Async<struct (int32 * string)> option = None
            let v161 : bool = true in let mutable _v160 = v160
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v162 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v162
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v163 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v163
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v164 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v164
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v165 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v165
#endif
            
#if FABLE_COMPILER_PYTHON
            let v166 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v166
#endif
            
#else
            let v167 : Async<struct (int32 * string)> option = None
            let v168 : bool = true in let mutable _v167 = v167
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v169 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v169
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v170 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v170
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v171 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v171
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v172 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v172
#endif
            
#if FABLE_COMPILER_PYTHON
            let v173 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v173
#endif
            
#else
            let v174 : Async<struct (int32 * string)> option = None
            let mutable _v174 = v174
            async {
            let struct (v175 : string, v176 : string) = method43()
            let v177 : int32 = v114.Length
            let v178 : (char []) = Array.zeroCreate<char> (v177)
            let v179 : Mut5 = {l0 = 0} : Mut5
            while method30(v177, v179) do
                let v181 : int32 = v179.l0
                let v182 : char = v114.[int v181]
                v178.[int v181] <- v182
                let v183 : int32 = v181 + 1
                v179.l0 <- v183
                ()
            let v184 : ((char []) -> char list) = Array.toList
            let v185 : char list = v184 v178
            let v186 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v187 : (char -> (UH0 -> UH0)) = method44()
            let v188 : (char list -> (UH0 -> UH0)) = v186 v187
            let v189 : (UH0 -> UH0) = v188 v185
            let v190 : UH0 = UH0_0
            let v191 : UH0 = v189 v190
            let v192 : US8 = US8_0
            let struct (v193 : string, v194 : string) = method45(v176, v175, v191, v192)
            let v195 : (string -> US4) = method22()
            let v196 : US4 = US4_1
            let v197 : US4 = v109 |> Option.map v195 |> Option.defaultValue v196 
            let v201 : string =
                match v197 with
                | US4_1 -> (* None *)
                    let v199 : string = ""
                    v199
                | US4_0(v198) -> (* Some *)
                    v198
            let v202 : US0 = US0_1
            let v203 : (unit -> string) = closure48(v110, v114, v111, v112, v113, v109)
            let v204 : (unit -> string) = method51()
            method3(v202, v203, v204)
            let v205 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v206 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v194, StandardOutputEncoding = v205, WorkingDirectory = v201, FileName = v193, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v207 : int32 = v111.Length
            let v208 : Mut5 = {l0 = 0} : Mut5
            while method30(v207, v208) do
                let v210 : int32 = v208.l0
                let struct (v211 : string, v212 : string) = v111.[int v210]
                v206.EnvironmentVariables.[v211] <- v212 
                let v213 : int32 = v210 + 1
                v208.l0 <- v213
                ()
            let v214 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v206)
            use v214 = v214 
            let v215 : System.Diagnostics.Process = v214 
            let v216 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v217 : System.Collections.Concurrent.ConcurrentStack<string> = v216 ()
            let v218 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v110, v114, v111, v112, v113, v109, v215, v217)
            v215.OutputDataReceived.Add v218 
            let v219 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v110, v114, v111, v112, v113, v109, v215, v217)
            v215.ErrorDataReceived.Add v219 
            let v220 : (unit -> bool) = v215.Start
            let v221 : bool = v220 ()
            let v222 : bool = v221 = false
            if v222 then
                let v223 : string = $"execute_with_options_async / process_start error"
                failwith<unit> v223
            let v224 : (unit -> unit) = v215.BeginErrorReadLine
            v224 ()
            let v225 : (unit -> unit) = v215.BeginOutputReadLine
            v225 ()
            let v226 : (System.Threading.CancellationToken -> US18) = method74()
            let v227 : US18 = US18_1
            let v228 : US18 = v110 |> Option.map v226 |> Option.defaultValue v227 
            let v232 : System.Threading.CancellationToken =
                match v228 with
                | US18_1 -> (* None *)
                    let v230 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v230
                | US18_0(v229) -> (* Some *)
                    v229
            let v233 : Async<System.Threading.CancellationToken> option = None
            let v234 : bool = true in let mutable _v233 = v233
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v235 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v235
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v236 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v236
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v237 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v237
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v238 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v238
#endif
            
#if FABLE_COMPILER_PYTHON
            let v239 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v239
#endif
            
#else
            let v240 : Async<System.Threading.CancellationToken> option = None
            let v241 : bool = true in let mutable _v240 = v240
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v242 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v242
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v243 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v243
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v244 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v244
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v245 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v245
#endif
            
#if FABLE_COMPILER_PYTHON
            let v246 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v246
#endif
            
#else
            let v247 : Async<System.Threading.CancellationToken> option = None
            let mutable _v247 = v247
            async {
            let v248 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v248 = v248 
            let v249 : System.Threading.CancellationToken = v248 
            let v250 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v251 : (System.Threading.CancellationToken []) = [|v249; v250; v232|]
            let v252 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v253 : System.Threading.CancellationTokenSource = v252 v251
            let v254 : System.Threading.CancellationToken = v253.Token
            return v254 
            }
            |> fun x -> _v247 <- Some x
            let v255 : Async<System.Threading.CancellationToken> = _v247 |> Option.get
            v255
#endif
            |> fun x -> _v240 <- Some x
            let v256 : Async<System.Threading.CancellationToken> = _v240.Value
            v256
#endif
            |> fun x -> _v233 <- Some x
            let v257 : Async<System.Threading.CancellationToken> = _v233.Value
            let! v257 = v257 
            let v258 : System.Threading.CancellationToken = v257 
            let v259 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v258.Register
            let v260 : (unit -> unit) = closure54(v215)
            let v261 : System.Threading.CancellationTokenRegistration = v259 v260
            use v261 = v261 
            let v262 : System.Threading.CancellationTokenRegistration = v261 
            let v263 : Async<int32> option = None
            let v264 : bool = true in let mutable _v263 = v263
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v265 : Async<int32> = null |> unbox<Async<int32>>
            v265
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v266 : Async<int32> = null |> unbox<Async<int32>>
            v266
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v267 : Async<int32> = null |> unbox<Async<int32>>
            v267
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v268 : Async<int32> = null |> unbox<Async<int32>>
            v268
#endif
            
#if FABLE_COMPILER_PYTHON
            let v269 : Async<int32> = null |> unbox<Async<int32>>
            v269
#endif
            
#else
            let v270 : Async<int32> option = None
            let mutable _v270 = v270
            async {
            try
            let v271 : System.Threading.Tasks.Task = v215.WaitForExitAsync v258 
            let v272 : Async<unit> option = None
            let v273 : bool = true in let mutable _v272 = v272
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v274 : Async<unit> = null |> unbox<Async<unit>>
            v274
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v275 : Async<unit> = null |> unbox<Async<unit>>
            v275
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v276 : Async<unit> = null |> unbox<Async<unit>>
            v276
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v277 : Async<unit> = null |> unbox<Async<unit>>
            v277
#endif
            
#if FABLE_COMPILER_PYTHON
            let v278 : Async<unit> = null |> unbox<Async<unit>>
            v278
#endif
            
#else
            let v279 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v280 : Async<unit> = v279 v271
            v280
#endif
            |> fun x -> _v272 <- Some x
            let v281 : Async<unit> = _v272.Value
            do! v281 
            let v282 : int32 = v215.ExitCode
            return v282 
            with ex ->
            let v283 : exn = ex
            let v284 : string option = None
            let v285 : bool = true in let mutable _v284 = v284
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v286 : string = $"%A{v283}"
            v286
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v287 : string = $"%A{v283}"
            v287
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v288 : string = $"%A{v283}"
            v288
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v289 : string = $"%A{v283}"
            v289
#endif
            
#if FABLE_COMPILER_PYTHON
            let v290 : string = $"%A{v283}"
            v290
#endif
            
#else
            let v291 : string = $"{v283.GetType ()}: {v283.Message}"
            v291
#endif
            |> fun x -> _v284 <- Some x
            let v292 : string = _v284.Value
            let v293 : (string -> unit) = v217.Push
            v293 v292
            let v294 : System.Threading.Tasks.TaskCanceledException = v283 |> unbox<System.Threading.Tasks.TaskCanceledException>
            let v295 : US0 = US0_3
            let v296 : (unit -> string) = closure55(v294)
            let v297 : (unit -> string) = method51()
            method3(v295, v296, v297)
            return -2147483648 
            (*
            *)
            }
            |> fun x -> _v270 <- Some x
            let v298 : Async<int32> = _v270 |> Option.get
            v298
#endif
            |> fun x -> _v263 <- Some x
            let v299 : Async<int32> = _v263.Value
            let! v299 = v299 
            let v300 : int32 = v299 
            let v301 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v302 : string seq = v301 v217
            let v303 : string = method75()
            let v304 : (string -> (string seq -> string)) = String.concat
            let v305 : (string seq -> string) = v304 v303
            let v306 : string = v305 v302
            let v307 : US0 = US0_1
            let v308 : (unit -> string) = closure56(v300, v306)
            let v309 : (unit -> string) = method51()
            method3(v307, v308, v309)
            return struct (v300, v306) 
            }
            |> fun x -> _v174 <- Some x
            let v310 : Async<struct (int32 * string)> = _v174 |> Option.get
            v310
#endif
            |> fun x -> _v167 <- Some x
            let v311 : Async<struct (int32 * string)> = _v167.Value
            v311
#endif
            |> fun x -> _v160 <- Some x
            let v312 : Async<struct (int32 * string)> = _v160.Value
            let v313 : struct (int32 * string) option = None
            let v314 : bool = true in let mutable _v313 = v313
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v315 : int32, v316 : string) = null |> unbox<struct (int32 * string)>
            struct (v315, v316)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v317 : int32, v318 : string) = null |> unbox<struct (int32 * string)>
            struct (v317, v318)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v319 : int32, v320 : string) = null |> unbox<struct (int32 * string)>
            struct (v319, v320)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v321 : int32, v322 : string) = null |> unbox<struct (int32 * string)>
            struct (v321, v322)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v323 : int32, v324 : string) = null |> unbox<struct (int32 * string)>
            struct (v323, v324)
#endif
            
#else
            let v325 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
            let struct (v326 : int32, v327 : string) = v325 v312
            struct (v326, v327)
#endif
            |> fun x -> _v313 <- Some x
            let struct (v328 : int32, v329 : string) = _v313.Value
            struct (v328, v329)
#endif
            |> fun x -> _v115 <- Some x
            let struct (v330 : int32, v331 : string) = _v115.Value
            let v332 : bool option = None
            let v333 : bool = true in let mutable _v332 = v332
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v334 : string = "cfg!(windows)"
            let v335 : bool = Fable.Core.RustInterop.emitRustExpr () v334
            v335
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v336 : bool = null |> unbox<bool>
            v336
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v337 : bool = null |> unbox<bool>
            v337
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v338 : bool = null |> unbox<bool>
            v338
#endif
            
#if FABLE_COMPILER_PYTHON
            let v339 : bool = null |> unbox<bool>
            v339
#endif
            
#else
            let v340 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v341 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v342 : bool = v341 v340
            v342
#endif
            |> fun x -> _v332 <- Some x
            let v343 : bool = _v332.Value
            let v344 : bool = v343 = false
            let v368 : string =
                if v344 then
                    v23
                else
                    let v345 : string option = None
                    let v346 : bool = true in let mutable _v345 = v345
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v347 : string = method26()
                    let v348 : string = method27(v23)
                    let v349 : string = method28()
                    let v350 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v351 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v347, v348, v349) v350
                    let v352 : string = "String::from($0)"
                    let v353 : std_string_String = Fable.Core.RustInterop.emitRustExpr v351 v352
                    let v354 : string = "fable_library_rust::String_::fromString($0)"
                    let v355 : string = Fable.Core.RustInterop.emitRustExpr v353 v354
                    v355
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v356 : string = null |> unbox<string>
                    v356
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v357 : string = null |> unbox<string>
                    v357
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v358 : string = null |> unbox<string>
                    v358
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v359 : string = null |> unbox<string>
                    v359
#endif
                    
#else
                    let v360 : string = "^\\\\\\\\\\?\\\\"
                    let v361 : string = ""
                    let v362 : string = System.Text.RegularExpressions.Regex.Replace (v23, v360, v361)
                    v362
#endif
                    |> fun x -> _v345 <- Some x
                    let v363 : string = _v345.Value
                    let v364 : string = $"{v363.[0] |> string |> _.ToLower()}{v363.[1..]}"
                    let v365 : string = "\\"
                    let v366 : string = "/"
                    let v367 : string = v364.Replace (v365, v366)
                    v367
            let v369 : string option = None
            let v370 : System.Threading.CancellationToken option = None
            let v371 : (struct (string * string) []) = [||]
            let v372 : (struct (bool * string * int32) -> Async<unit>) option = None
            let v373 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
            let v374 : string = $"pwsh -c \"(Get-FileHash \\\"{v368}\\\" -Algorithm SHA256).Hash\""
            let v375 : struct (int32 * string) option = None
            let v376 : bool = true in let mutable _v375 = v375
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v377 : string = method42(v370, v374, v371, v372, v373, v369)
            let struct (v378 : string, v379 : string) = method43()
            let v380 : int32 = v377.Length
            let v381 : (char []) = Array.zeroCreate<char> (v380)
            let v382 : Mut5 = {l0 = 0} : Mut5
            while method30(v380, v382) do
                let v384 : int32 = v382.l0
                let v385 : char = v377.[int v384]
                v381.[int v384] <- v385
                let v386 : int32 = v384 + 1
                v382.l0 <- v386
                ()
            let v387 : ((char []) -> char list) = Array.toList
            let v388 : char list = v387 v381
            let v389 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v390 : (char -> (UH0 -> UH0)) = method44()
            let v391 : (char list -> (UH0 -> UH0)) = v389 v390
            let v392 : (UH0 -> UH0) = v391 v388
            let v393 : UH0 = UH0_0
            let v394 : UH0 = v392 v393
            let v395 : US8 = US8_0
            let struct (v396 : string, v397 : string) = method45(v379, v378, v394, v395)
            let v398 : (string []) = method46(v397)
            let v399 : string = "$0.to_vec()"
            let v400 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v398 v399
            let v401 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v402 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v400, v142) v401
            let v403 : US0 = US0_1
            let v404 : (unit -> string) = closure29(v370, v374, v371, v372, v373, v369, v396, v402)
            let v405 : (unit -> string) = method51()
            method3(v403, v404, v405)
            let v406 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method52(v370, v374, v371, v372, v373, v369, v396, v402)
            let v407 : string = "futures_lite::future::block_on($0)"
            let v408 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v406 v407
            let (a, b) = v408
            let v409 : int32 = a
            let v410 : string = b
            struct (v409, v410)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v411 : int32, v412 : string) = null |> unbox<struct (int32 * string)>
            struct (v411, v412)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v413 : int32, v414 : string) = null |> unbox<struct (int32 * string)>
            struct (v413, v414)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v415 : int32, v416 : string) = null |> unbox<struct (int32 * string)>
            struct (v415, v416)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v417 : int32, v418 : string) = null |> unbox<struct (int32 * string)>
            struct (v417, v418)
#endif
            
#else
            let v419 : Async<struct (int32 * string)> option = None
            let v420 : bool = true in let mutable _v419 = v419
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v421 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v421
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v422 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v422
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v423 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v423
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v424 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v424
#endif
            
#if FABLE_COMPILER_PYTHON
            let v425 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v425
#endif
            
#else
            let v426 : Async<struct (int32 * string)> option = None
            let v427 : bool = true in let mutable _v426 = v426
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v428 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v428
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v429 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v429
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v430 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v430
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v431 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v431
#endif
            
#if FABLE_COMPILER_PYTHON
            let v432 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v432
#endif
            
#else
            let v433 : Async<struct (int32 * string)> option = None
            let mutable _v433 = v433
            async {
            let struct (v434 : string, v435 : string) = method43()
            let v436 : int32 = v374.Length
            let v437 : (char []) = Array.zeroCreate<char> (v436)
            let v438 : Mut5 = {l0 = 0} : Mut5
            while method30(v436, v438) do
                let v440 : int32 = v438.l0
                let v441 : char = v374.[int v440]
                v437.[int v440] <- v441
                let v442 : int32 = v440 + 1
                v438.l0 <- v442
                ()
            let v443 : ((char []) -> char list) = Array.toList
            let v444 : char list = v443 v437
            let v445 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v446 : (char -> (UH0 -> UH0)) = method44()
            let v447 : (char list -> (UH0 -> UH0)) = v445 v446
            let v448 : (UH0 -> UH0) = v447 v444
            let v449 : UH0 = UH0_0
            let v450 : UH0 = v448 v449
            let v451 : US8 = US8_0
            let struct (v452 : string, v453 : string) = method45(v435, v434, v450, v451)
            let v454 : (string -> US4) = method22()
            let v455 : US4 = US4_1
            let v456 : US4 = v369 |> Option.map v454 |> Option.defaultValue v455 
            let v460 : string =
                match v456 with
                | US4_1 -> (* None *)
                    let v458 : string = ""
                    v458
                | US4_0(v457) -> (* Some *)
                    v457
            let v461 : US0 = US0_1
            let v462 : (unit -> string) = closure48(v370, v374, v371, v372, v373, v369)
            let v463 : (unit -> string) = method51()
            method3(v461, v462, v463)
            let v464 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v465 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v453, StandardOutputEncoding = v464, WorkingDirectory = v460, FileName = v452, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v466 : int32 = v371.Length
            let v467 : Mut5 = {l0 = 0} : Mut5
            while method30(v466, v467) do
                let v469 : int32 = v467.l0
                let struct (v470 : string, v471 : string) = v371.[int v469]
                v465.EnvironmentVariables.[v470] <- v471 
                let v472 : int32 = v469 + 1
                v467.l0 <- v472
                ()
            let v473 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v465)
            use v473 = v473 
            let v474 : System.Diagnostics.Process = v473 
            let v475 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v476 : System.Collections.Concurrent.ConcurrentStack<string> = v475 ()
            let v477 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v370, v374, v371, v372, v373, v369, v474, v476)
            v474.OutputDataReceived.Add v477 
            let v478 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v370, v374, v371, v372, v373, v369, v474, v476)
            v474.ErrorDataReceived.Add v478 
            let v479 : (unit -> bool) = v474.Start
            let v480 : bool = v479 ()
            let v481 : bool = v480 = false
            if v481 then
                let v482 : string = $"execute_with_options_async / process_start error"
                failwith<unit> v482
            let v483 : (unit -> unit) = v474.BeginErrorReadLine
            v483 ()
            let v484 : (unit -> unit) = v474.BeginOutputReadLine
            v484 ()
            let v485 : (System.Threading.CancellationToken -> US18) = method74()
            let v486 : US18 = US18_1
            let v487 : US18 = v370 |> Option.map v485 |> Option.defaultValue v486 
            let v491 : System.Threading.CancellationToken =
                match v487 with
                | US18_1 -> (* None *)
                    let v489 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v489
                | US18_0(v488) -> (* Some *)
                    v488
            let v492 : Async<System.Threading.CancellationToken> option = None
            let v493 : bool = true in let mutable _v492 = v492
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v494 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v494
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v495 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v495
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v496 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v496
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v497 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v497
#endif
            
#if FABLE_COMPILER_PYTHON
            let v498 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v498
#endif
            
#else
            let v499 : Async<System.Threading.CancellationToken> option = None
            let v500 : bool = true in let mutable _v499 = v499
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v501 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v501
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v502 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v502
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v503 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v503
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v504 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v504
#endif
            
#if FABLE_COMPILER_PYTHON
            let v505 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v505
#endif
            
#else
            let v506 : Async<System.Threading.CancellationToken> option = None
            let mutable _v506 = v506
            async {
            let v507 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v507 = v507 
            let v508 : System.Threading.CancellationToken = v507 
            let v509 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v510 : (System.Threading.CancellationToken []) = [|v508; v509; v491|]
            let v511 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v512 : System.Threading.CancellationTokenSource = v511 v510
            let v513 : System.Threading.CancellationToken = v512.Token
            return v513 
            }
            |> fun x -> _v506 <- Some x
            let v514 : Async<System.Threading.CancellationToken> = _v506 |> Option.get
            v514
#endif
            |> fun x -> _v499 <- Some x
            let v515 : Async<System.Threading.CancellationToken> = _v499.Value
            v515
#endif
            |> fun x -> _v492 <- Some x
            let v516 : Async<System.Threading.CancellationToken> = _v492.Value
            let! v516 = v516 
            let v517 : System.Threading.CancellationToken = v516 
            let v518 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v517.Register
            let v519 : (unit -> unit) = closure54(v474)
            let v520 : System.Threading.CancellationTokenRegistration = v518 v519
            use v520 = v520 
            let v521 : System.Threading.CancellationTokenRegistration = v520 
            let v522 : Async<int32> option = None
            let v523 : bool = true in let mutable _v522 = v522
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v524 : Async<int32> = null |> unbox<Async<int32>>
            v524
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v525 : Async<int32> = null |> unbox<Async<int32>>
            v525
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v526 : Async<int32> = null |> unbox<Async<int32>>
            v526
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v527 : Async<int32> = null |> unbox<Async<int32>>
            v527
#endif
            
#if FABLE_COMPILER_PYTHON
            let v528 : Async<int32> = null |> unbox<Async<int32>>
            v528
#endif
            
#else
            let v529 : Async<int32> option = None
            let mutable _v529 = v529
            async {
            try
            let v530 : System.Threading.Tasks.Task = v474.WaitForExitAsync v517 
            let v531 : Async<unit> option = None
            let v532 : bool = true in let mutable _v531 = v531
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v533 : Async<unit> = null |> unbox<Async<unit>>
            v533
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v534 : Async<unit> = null |> unbox<Async<unit>>
            v534
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v535 : Async<unit> = null |> unbox<Async<unit>>
            v535
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v536 : Async<unit> = null |> unbox<Async<unit>>
            v536
#endif
            
#if FABLE_COMPILER_PYTHON
            let v537 : Async<unit> = null |> unbox<Async<unit>>
            v537
#endif
            
#else
            let v538 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v539 : Async<unit> = v538 v530
            v539
#endif
            |> fun x -> _v531 <- Some x
            let v540 : Async<unit> = _v531.Value
            do! v540 
            let v541 : int32 = v474.ExitCode
            return v541 
            with ex ->
            let v542 : exn = ex
            let v543 : string option = None
            let v544 : bool = true in let mutable _v543 = v543
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v545 : string = $"%A{v542}"
            v545
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v546 : string = $"%A{v542}"
            v546
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v547 : string = $"%A{v542}"
            v547
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v548 : string = $"%A{v542}"
            v548
#endif
            
#if FABLE_COMPILER_PYTHON
            let v549 : string = $"%A{v542}"
            v549
#endif
            
#else
            let v550 : string = $"{v542.GetType ()}: {v542.Message}"
            v550
#endif
            |> fun x -> _v543 <- Some x
            let v551 : string = _v543.Value
            let v552 : (string -> unit) = v476.Push
            v552 v551
            let v553 : System.Threading.Tasks.TaskCanceledException = v542 |> unbox<System.Threading.Tasks.TaskCanceledException>
            let v554 : US0 = US0_3
            let v555 : (unit -> string) = closure55(v553)
            let v556 : (unit -> string) = method51()
            method3(v554, v555, v556)
            return -2147483648 
            (*
            *)
            }
            |> fun x -> _v529 <- Some x
            let v557 : Async<int32> = _v529 |> Option.get
            v557
#endif
            |> fun x -> _v522 <- Some x
            let v558 : Async<int32> = _v522.Value
            let! v558 = v558 
            let v559 : int32 = v558 
            let v560 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v561 : string seq = v560 v476
            let v562 : string = method75()
            let v563 : (string -> (string seq -> string)) = String.concat
            let v564 : (string seq -> string) = v563 v562
            let v565 : string = v564 v561
            let v566 : US0 = US0_1
            let v567 : (unit -> string) = closure56(v559, v565)
            let v568 : (unit -> string) = method51()
            method3(v566, v567, v568)
            return struct (v559, v565) 
            }
            |> fun x -> _v433 <- Some x
            let v569 : Async<struct (int32 * string)> = _v433 |> Option.get
            v569
#endif
            |> fun x -> _v426 <- Some x
            let v570 : Async<struct (int32 * string)> = _v426.Value
            v570
#endif
            |> fun x -> _v419 <- Some x
            let v571 : Async<struct (int32 * string)> = _v419.Value
            let v572 : struct (int32 * string) option = None
            let v573 : bool = true in let mutable _v572 = v572
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v574 : int32, v575 : string) = null |> unbox<struct (int32 * string)>
            struct (v574, v575)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v576 : int32, v577 : string) = null |> unbox<struct (int32 * string)>
            struct (v576, v577)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v578 : int32, v579 : string) = null |> unbox<struct (int32 * string)>
            struct (v578, v579)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v580 : int32, v581 : string) = null |> unbox<struct (int32 * string)>
            struct (v580, v581)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v582 : int32, v583 : string) = null |> unbox<struct (int32 * string)>
            struct (v582, v583)
#endif
            
#else
            let v584 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
            let struct (v585 : int32, v586 : string) = v584 v571
            struct (v585, v586)
#endif
            |> fun x -> _v572 <- Some x
            let struct (v587 : int32, v588 : string) = _v572.Value
            struct (v587, v588)
#endif
            |> fun x -> _v375 <- Some x
            let struct (v589 : int32, v590 : string) = _v375.Value
            let v591 : bool = v331 = v590
            v591
        else
            false
    let v593 : bool = v592 = false
    if v593 then
        let v594 : string option = None
        let v595 : bool = true in let mutable _v594 = v594
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v596 : Vec<uint8> option = None
        let v597 : bool = true in let mutable _v596 = v596
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v598 : string = "std::fs::read(&*$0).unwrap()"
        let v599 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v0 v598
        v599
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v600 : Vec<uint8> = null |> unbox<Vec<uint8>>
        v600
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v601 : Vec<uint8> = null |> unbox<Vec<uint8>>
        v601
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v602 : Vec<uint8> = null |> unbox<Vec<uint8>>
        v602
#endif
        
#if FABLE_COMPILER_PYTHON
        let v603 : Vec<uint8> = null |> unbox<Vec<uint8>>
        v603
#endif
        
#else
        let v604 : (uint8 []) = v0 |> System.IO.File.ReadAllBytes
        let v605 : string = "$0.to_vec()"
        let v606 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v604 v605
        v606
#endif
        |> fun x -> _v596 <- Some x
        let v607 : Vec<uint8> = _v596.Value
        let v608 : string = "std::string::String::from_utf8(v607)"
        let v609 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v608
        let v610 : string = "$0.unwrap()"
        let v611 : std_string_String = Fable.Core.RustInterop.emitRustExpr v609 v610
        let v612 : string = "fable_library_rust::String_::fromString($0)"
        let v613 : string = Fable.Core.RustInterop.emitRustExpr v611 v612
        v613
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v614 : string = null |> unbox<string>
        v614
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v615 : string = null |> unbox<string>
        v615
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v616 : string = null |> unbox<string>
        v616
#endif
        
#if FABLE_COMPILER_PYTHON
        let v617 : string = null |> unbox<string>
        v617
#endif
        
#else
        let v618 : string = v0 |> System.IO.File.ReadAllText
        v618
#endif
        |> fun x -> _v594 <- Some x
        let v619 : string = _v594.Value
        let v620 : string = "\n"
        let v621 : (string []) = v619.Split v620
        let v622 : int32 = v621.Length
        let v623 : (string []) = Array.zeroCreate<string> (v622)
        let v624 : Mut5 = {l0 = 0} : Mut5
        while method30(v622, v624) do
            let v626 : int32 = v624.l0
            let v627 : string = v621.[int v626]
            let v628 : string = v627.Trim ()
            v623.[int v626] <- v628
            let v629 : int32 = v626 + 1
            v624.l0 <- v629
            ()
        let v630 : int32 = v623.Length
        let v631 : (string []) = Array.zeroCreate<string> (v630)
        let v632 : Mut6 = {l0 = 0; l1 = 0} : Mut6
        while method76(v630, v632) do
            let v634 : int32 = v632.l0
            let v635 : int32 = v632.l1
            let v636 : string = v623.[int v634]
            let v637 : string = ""
            let v638 : bool = v637 <> v636
            let v640 : int32 =
                if v638 then
                    v631.[int v635] <- v636
                    let v639 : int32 = v635 + 1
                    v639
                else
                    v635
            let v641 : int32 = v634 + 1
            v632.l0 <- v641
            v632.l1 <- v640
            ()
        let v642 : int32 = v632.l1
        let v643 : (string []) = Array.zeroCreate<string> (v642)
        let v644 : Mut5 = {l0 = 0} : Mut5
        while method30(v642, v644) do
            let v646 : int32 = v644.l0
            let v647 : string = v631.[int v646]
            v643.[int v646] <- v647
            let v648 : int32 = v646 + 1
            v644.l0 <- v648
            ()
        let v649 : string seq = seq { for i = 0 to v643.Length - 1 do yield v643.[i] }
        let v650 : string = method75()
        let v651 : (string -> (string seq -> string)) = String.concat
        let v652 : (string seq -> string) = v651 v650
        let v653 : string = v652 v649
        let v654 : string = $"{v653}

"
        let v655 : string option = None
        let v656 : System.Threading.CancellationToken option = None
        let v657 : (struct (string * string) []) = [||]
        let v658 : (struct (bool * string * int32) -> Async<unit>) option = None
        let v659 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
        let v660 : bool option = None
        let v661 : bool = true in let mutable _v660 = v660
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v662 : string = "cfg!(windows)"
        let v663 : bool = Fable.Core.RustInterop.emitRustExpr () v662
        v663
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v664 : bool = null |> unbox<bool>
        v664
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v665 : bool = null |> unbox<bool>
        v665
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v666 : bool = null |> unbox<bool>
        v666
#endif
        
#if FABLE_COMPILER_PYTHON
        let v667 : bool = null |> unbox<bool>
        v667
#endif
        
#else
        let v668 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
        let v669 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
        let v670 : bool = v669 v668
        v670
#endif
        |> fun x -> _v660 <- Some x
        let v671 : bool = _v660.Value
        let v674 : string =
            if v671 then
                let v672 : string = ".exe"
                v672
            else
                let v673 : string = ""
                v673
        let v675 : string = $"../vault/deps/hangulize/cmd/hangulize/hangulize{v674}"
        let v676 : string option = None
        let v677 : bool = true in let mutable _v676 = v676
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v678 : string = method18(v3)
        let v679 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
        let v680 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v678 v679
        let v681 : string = "String::from($0)"
        let v682 : std_string_String = Fable.Core.RustInterop.emitRustExpr v680 v681
        let v683 : string = "std::path::PathBuf::from($0)"
        let v684 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v682 v683
        let v685 : string = method18(v675)
        let v686 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
        let v687 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v685 v686
        let v688 : string = "String::from($0)"
        let v689 : std_string_String = Fable.Core.RustInterop.emitRustExpr v687 v688
        let v690 : string = "$0.join($1)"
        let v691 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v684, v689) v690
        let v692 : string = "$0.display()"
        let v693 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v691 v692
        let v694 : std_string_String option = None
        let v695 : bool = true in let mutable _v694 = v694
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v696 : string = @$"format!(""{{}}"", $0)"
        let v697 : std_string_String = Fable.Core.RustInterop.emitRustExpr v693 v696
        v697
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v698 : string = @$"format!(""{{}}"", $0)"
        let v699 : std_string_String = Fable.Core.RustInterop.emitRustExpr v693 v698
        v699
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v700 : string = @$"format!(""{{}}"", $0)"
        let v701 : std_string_String = Fable.Core.RustInterop.emitRustExpr v693 v700
        v701
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v702 : std_string_String = null |> unbox<std_string_String>
        v702
#endif
        
#if FABLE_COMPILER_PYTHON
        let v703 : std_string_String = null |> unbox<std_string_String>
        v703
#endif
        
#else
        let v704 : std_string_String = null |> unbox<std_string_String>
        v704
#endif
        |> fun x -> _v694 <- Some x
        let v705 : std_string_String = _v694.Value
        let v706 : string = "fable_library_rust::String_::fromString($0)"
        let v707 : string = Fable.Core.RustInterop.emitRustExpr v705 v706
        v707
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v708 : string = null |> unbox<string>
        v708
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v709 : string = null |> unbox<string>
        v709
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v710 : string = "path"
        let v711 : IPathJoin = Fable.Core.JsInterop.importAll v710
        let v712 : string = method19(v3)
        let v713 : string = method20(v675)
        let v714 : string = "v711.join(v712, v713)"
        let v715 : string = Fable.Core.JsInterop.emitJsExpr () v714
        v715
#endif
        
#if FABLE_COMPILER_PYTHON
        let v716 : string = null |> unbox<string>
        v716
#endif
        
#else
        let v717 : string = System.IO.Path.Combine (v3, v675)
        v717
#endif
        |> fun x -> _v676 <- Some x
        let v718 : string = _v676.Value
        let v719 : string = $"{v718} {v2}"
        let v720 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = closure58(v654)
        let v721 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = Some v720 
        let v722 : struct (int32 * string) option = None
        let v723 : bool = true in let mutable _v722 = v722
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v724 : string = method42(v656, v719, v657, v658, v721, v655)
        let struct (v725 : string, v726 : string) = method43()
        let v727 : int32 = v724.Length
        let v728 : (char []) = Array.zeroCreate<char> (v727)
        let v729 : Mut5 = {l0 = 0} : Mut5
        while method30(v727, v729) do
            let v731 : int32 = v729.l0
            let v732 : char = v724.[int v731]
            v728.[int v731] <- v732
            let v733 : int32 = v731 + 1
            v729.l0 <- v733
            ()
        let v734 : ((char []) -> char list) = Array.toList
        let v735 : char list = v734 v728
        let v736 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
        let v737 : (char -> (UH0 -> UH0)) = method44()
        let v738 : (char list -> (UH0 -> UH0)) = v736 v737
        let v739 : (UH0 -> UH0) = v738 v735
        let v740 : UH0 = UH0_0
        let v741 : UH0 = v739 v740
        let v742 : US8 = US8_0
        let struct (v743 : string, v744 : string) = method45(v726, v725, v741, v742)
        let v745 : (string []) = method46(v744)
        let v746 : string = "$0.to_vec()"
        let v747 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v745 v746
        let v748 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
        let v749 : (string -> std_string_String) = closure28()
        let v750 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v747, v749) v748
        let v751 : US0 = US0_1
        let v752 : (unit -> string) = closure29(v656, v719, v657, v658, v721, v655, v743, v750)
        let v753 : (unit -> string) = method51()
        method3(v751, v752, v753)
        let v754 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method52(v656, v719, v657, v658, v721, v655, v743, v750)
        let v755 : string = "futures_lite::future::block_on($0)"
        let v756 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v754 v755
        let (a, b) = v756
        let v757 : int32 = a
        let v758 : string = b
        struct (v757, v758)
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let struct (v759 : int32, v760 : string) = null |> unbox<struct (int32 * string)>
        struct (v759, v760)
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let struct (v761 : int32, v762 : string) = null |> unbox<struct (int32 * string)>
        struct (v761, v762)
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let struct (v763 : int32, v764 : string) = null |> unbox<struct (int32 * string)>
        struct (v763, v764)
#endif
        
#if FABLE_COMPILER_PYTHON
        let struct (v765 : int32, v766 : string) = null |> unbox<struct (int32 * string)>
        struct (v765, v766)
#endif
        
#else
        let v767 : Async<struct (int32 * string)> option = None
        let v768 : bool = true in let mutable _v767 = v767
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v769 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v769
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v770 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v770
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v771 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v771
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v772 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v772
#endif
        
#if FABLE_COMPILER_PYTHON
        let v773 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v773
#endif
        
#else
        let v774 : Async<struct (int32 * string)> option = None
        let v775 : bool = true in let mutable _v774 = v774
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v776 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v776
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v777 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v777
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v778 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v778
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v779 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v779
#endif
        
#if FABLE_COMPILER_PYTHON
        let v780 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v780
#endif
        
#else
        let v781 : Async<struct (int32 * string)> option = None
        let mutable _v781 = v781
        async {
        let struct (v782 : string, v783 : string) = method43()
        let v784 : int32 = v719.Length
        let v785 : (char []) = Array.zeroCreate<char> (v784)
        let v786 : Mut5 = {l0 = 0} : Mut5
        while method30(v784, v786) do
            let v788 : int32 = v786.l0
            let v789 : char = v719.[int v788]
            v785.[int v788] <- v789
            let v790 : int32 = v788 + 1
            v786.l0 <- v790
            ()
        let v791 : ((char []) -> char list) = Array.toList
        let v792 : char list = v791 v785
        let v793 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
        let v794 : (char -> (UH0 -> UH0)) = method44()
        let v795 : (char list -> (UH0 -> UH0)) = v793 v794
        let v796 : (UH0 -> UH0) = v795 v792
        let v797 : UH0 = UH0_0
        let v798 : UH0 = v796 v797
        let v799 : US8 = US8_0
        let struct (v800 : string, v801 : string) = method45(v783, v782, v798, v799)
        let v802 : (string -> US4) = method22()
        let v803 : US4 = US4_1
        let v804 : US4 = v655 |> Option.map v802 |> Option.defaultValue v803 
        let v808 : string =
            match v804 with
            | US4_1 -> (* None *)
                let v806 : string = ""
                v806
            | US4_0(v805) -> (* Some *)
                v805
        let v809 : US0 = US0_1
        let v810 : (unit -> string) = closure48(v656, v719, v657, v658, v721, v655)
        let v811 : (unit -> string) = method51()
        method3(v809, v810, v811)
        let v812 : System.Text.Encoding = System.Text.Encoding.UTF8
        let v813 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v801, StandardOutputEncoding = v812, WorkingDirectory = v808, FileName = v800, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
        let v814 : int32 = v657.Length
        let v815 : Mut5 = {l0 = 0} : Mut5
        while method30(v814, v815) do
            let v817 : int32 = v815.l0
            let struct (v818 : string, v819 : string) = v657.[int v817]
            v813.EnvironmentVariables.[v818] <- v819 
            let v820 : int32 = v817 + 1
            v815.l0 <- v820
            ()
        let v821 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v813)
        use v821 = v821 
        let v822 : System.Diagnostics.Process = v821 
        let v823 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
        let v824 : System.Collections.Concurrent.ConcurrentStack<string> = v823 ()
        let v825 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v656, v719, v657, v658, v721, v655, v822, v824)
        v822.OutputDataReceived.Add v825 
        let v826 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v656, v719, v657, v658, v721, v655, v822, v824)
        v822.ErrorDataReceived.Add v826 
        let v827 : (unit -> bool) = v822.Start
        let v828 : bool = v827 ()
        let v829 : bool = v828 = false
        if v829 then
            let v830 : string = $"execute_with_options_async / process_start error"
            failwith<unit> v830
        let v831 : (unit -> unit) = v822.BeginErrorReadLine
        v831 ()
        let v832 : (unit -> unit) = v822.BeginOutputReadLine
        v832 ()
        let v833 : (System.Threading.CancellationToken -> US18) = method74()
        let v834 : US18 = US18_1
        let v835 : US18 = v656 |> Option.map v833 |> Option.defaultValue v834 
        let v839 : System.Threading.CancellationToken =
            match v835 with
            | US18_1 -> (* None *)
                let v837 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                v837
            | US18_0(v836) -> (* Some *)
                v836
        let v840 : Async<System.Threading.CancellationToken> option = None
        let v841 : bool = true in let mutable _v840 = v840
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v842 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v842
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v843 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v843
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v844 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v844
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v845 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v845
#endif
        
#if FABLE_COMPILER_PYTHON
        let v846 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v846
#endif
        
#else
        let v847 : Async<System.Threading.CancellationToken> option = None
        let v848 : bool = true in let mutable _v847 = v847
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v849 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v849
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v850 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v850
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v851 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v851
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v852 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v852
#endif
        
#if FABLE_COMPILER_PYTHON
        let v853 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v853
#endif
        
#else
        let v854 : Async<System.Threading.CancellationToken> option = None
        let mutable _v854 = v854
        async {
        let v855 : Async<System.Threading.CancellationToken> = Async.CancellationToken
        let! v855 = v855 
        let v856 : System.Threading.CancellationToken = v855 
        let v857 : System.Threading.CancellationToken = Async.DefaultCancellationToken
        let v858 : (System.Threading.CancellationToken []) = [|v856; v857; v839|]
        let v859 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
        let v860 : System.Threading.CancellationTokenSource = v859 v858
        let v861 : System.Threading.CancellationToken = v860.Token
        return v861 
        }
        |> fun x -> _v854 <- Some x
        let v862 : Async<System.Threading.CancellationToken> = _v854 |> Option.get
        v862
#endif
        |> fun x -> _v847 <- Some x
        let v863 : Async<System.Threading.CancellationToken> = _v847.Value
        v863
#endif
        |> fun x -> _v840 <- Some x
        let v864 : Async<System.Threading.CancellationToken> = _v840.Value
        let! v864 = v864 
        let v865 : System.Threading.CancellationToken = v864 
        let v866 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v865.Register
        let v867 : (unit -> unit) = closure54(v822)
        let v868 : System.Threading.CancellationTokenRegistration = v866 v867
        use v868 = v868 
        let v869 : System.Threading.CancellationTokenRegistration = v868 
        let v870 : Async<int32> option = None
        let v871 : bool = true in let mutable _v870 = v870
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v872 : Async<int32> = null |> unbox<Async<int32>>
        v872
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v873 : Async<int32> = null |> unbox<Async<int32>>
        v873
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v874 : Async<int32> = null |> unbox<Async<int32>>
        v874
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v875 : Async<int32> = null |> unbox<Async<int32>>
        v875
#endif
        
#if FABLE_COMPILER_PYTHON
        let v876 : Async<int32> = null |> unbox<Async<int32>>
        v876
#endif
        
#else
        let v877 : Async<int32> option = None
        let mutable _v877 = v877
        async {
        try
        let v878 : System.Threading.Tasks.Task = v822.WaitForExitAsync v865 
        let v879 : Async<unit> option = None
        let v880 : bool = true in let mutable _v879 = v879
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v881 : Async<unit> = null |> unbox<Async<unit>>
        v881
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v882 : Async<unit> = null |> unbox<Async<unit>>
        v882
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v883 : Async<unit> = null |> unbox<Async<unit>>
        v883
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v884 : Async<unit> = null |> unbox<Async<unit>>
        v884
#endif
        
#if FABLE_COMPILER_PYTHON
        let v885 : Async<unit> = null |> unbox<Async<unit>>
        v885
#endif
        
#else
        let v886 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
        let v887 : Async<unit> = v886 v878
        v887
#endif
        |> fun x -> _v879 <- Some x
        let v888 : Async<unit> = _v879.Value
        do! v888 
        let v889 : int32 = v822.ExitCode
        return v889 
        with ex ->
        let v890 : exn = ex
        let v891 : string option = None
        let v892 : bool = true in let mutable _v891 = v891
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v893 : string = $"%A{v890}"
        v893
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v894 : string = $"%A{v890}"
        v894
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v895 : string = $"%A{v890}"
        v895
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v896 : string = $"%A{v890}"
        v896
#endif
        
#if FABLE_COMPILER_PYTHON
        let v897 : string = $"%A{v890}"
        v897
#endif
        
#else
        let v898 : string = $"{v890.GetType ()}: {v890.Message}"
        v898
#endif
        |> fun x -> _v891 <- Some x
        let v899 : string = _v891.Value
        let v900 : (string -> unit) = v824.Push
        v900 v899
        let v901 : System.Threading.Tasks.TaskCanceledException = v890 |> unbox<System.Threading.Tasks.TaskCanceledException>
        let v902 : US0 = US0_3
        let v903 : (unit -> string) = closure55(v901)
        let v904 : (unit -> string) = method51()
        method3(v902, v903, v904)
        return -2147483648 
        (*
        *)
        }
        |> fun x -> _v877 <- Some x
        let v905 : Async<int32> = _v877 |> Option.get
        v905
#endif
        |> fun x -> _v870 <- Some x
        let v906 : Async<int32> = _v870.Value
        let! v906 = v906 
        let v907 : int32 = v906 
        let v908 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
        let v909 : string seq = v908 v824
        let v910 : string = method75()
        let v911 : (string -> (string seq -> string)) = String.concat
        let v912 : (string seq -> string) = v911 v910
        let v913 : string = v912 v909
        let v914 : US0 = US0_1
        let v915 : (unit -> string) = closure56(v907, v913)
        let v916 : (unit -> string) = method51()
        method3(v914, v915, v916)
        return struct (v907, v913) 
        }
        |> fun x -> _v781 <- Some x
        let v917 : Async<struct (int32 * string)> = _v781 |> Option.get
        v917
#endif
        |> fun x -> _v774 <- Some x
        let v918 : Async<struct (int32 * string)> = _v774.Value
        v918
#endif
        |> fun x -> _v767 <- Some x
        let v919 : Async<struct (int32 * string)> = _v767.Value
        let v920 : struct (int32 * string) option = None
        let v921 : bool = true in let mutable _v920 = v920
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let struct (v922 : int32, v923 : string) = null |> unbox<struct (int32 * string)>
        struct (v922, v923)
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let struct (v924 : int32, v925 : string) = null |> unbox<struct (int32 * string)>
        struct (v924, v925)
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let struct (v926 : int32, v927 : string) = null |> unbox<struct (int32 * string)>
        struct (v926, v927)
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let struct (v928 : int32, v929 : string) = null |> unbox<struct (int32 * string)>
        struct (v928, v929)
#endif
        
#if FABLE_COMPILER_PYTHON
        let struct (v930 : int32, v931 : string) = null |> unbox<struct (int32 * string)>
        struct (v930, v931)
#endif
        
#else
        let v932 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
        let struct (v933 : int32, v934 : string) = v932 v919
        struct (v933, v934)
#endif
        |> fun x -> _v920 <- Some x
        let struct (v935 : int32, v936 : string) = _v920.Value
        struct (v935, v936)
#endif
        |> fun x -> _v722 <- Some x
        let struct (v937 : int32, v938 : string) = _v722.Value
        let v939 : (string []) = v938.Split v620
        let v940 : int32 = v939.Length
        let v941 : string = ""
        let v942 : Mut7 = {l0 = 0; l1 = v941; l2 = 0; l3 = 0} : Mut7
        while method79(v630, v942) do
            let v944 : int32 = v942.l0
            let struct (v945 : string, v946 : int32, v947 : int32) = v942.l1, v942.l2, v942.l3
            let v948 : string = v623.[int v944]
            let v949 : bool = v948 = ""
            let struct (v963 : string, v964 : int32, v965 : int32) =
                if v949 then
                    let v950 : string = $"{v945}
"
                    let v951 : int32 = v946 + 1
                    let v952 : int32 = v947 + 1
                    struct (v950, v951, v952)
                else
                    let v953 : int32 = v946 - v947
                    let v954 : bool = v953 >= v940
                    let v961 : string =
                        if v954 then
                            v945
                        else
                            let v955 : string = v939.[int v953]
                            let v956 : int32 = v940 - 1
                            let v957 : bool = v953 = v956
                            if v957 then
                                let v958 : string = $"{v945}{v955}"
                                v958
                            else
                                let v959 : string = $"{v945}{v955}
"
                                v959
                    let v962 : int32 = v946 + 1
                    struct (v961, v962, v947)
            let v966 : int32 = v944 + 1
            v942.l0 <- v966
            v942.l1 <- v963
            v942.l2 <- v964
            v942.l3 <- v965
            ()
        let struct (v967 : string, v968 : int32, v969 : int32) = v942.l1, v942.l2, v942.l3
        let v970 : unit option = None
        let v971 : bool = true in let mutable _v970 = v970
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v972 : string = "std::fs::write(&*$0, &*$1).unwrap()"
        Fable.Core.RustInterop.emitRustExpr struct (v14, v967) v972
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
        let v973 : string = method80(v967)
        System.IO.File.WriteAllText (v14, v973)
        ()
#endif
        |> fun x -> _v970 <- Some x
        _v970.Value
        let v974 : bool = v937 <> 0
        if v974 then
            let v975 : US0 = US0_2
            let v976 : (unit -> string) = closure59()
            let v977 : (unit -> string) = closure60(v967, v937)
            method3(v975, v976, v977)
            let v978 : (string * string) = v14, v967
            let v979 : Result<string, (string * string)> = Error v978
            US19_0(v979)
        else
            let v981 : bool option = None
            let v982 : bool = true in let mutable _v981 = v981
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v983 : string = method18(v14)
            let v984 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v985 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v983 v984
            let v986 : string = "String::from($0)"
            let v987 : std_string_String = Fable.Core.RustInterop.emitRustExpr v985 v986
            let v988 : string = "std::path::PathBuf::from($0)"
            let v989 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v987 v988
            let v990 : string = "$0.exists()"
            let v991 : bool = Fable.Core.RustInterop.emitRustExpr v989 v990
            let v994 : bool =
                if v991 then
                    let v992 : string = "$0.is_file()"
                    let v993 : bool = Fable.Core.RustInterop.emitRustExpr v989 v992
                    v993
                else
                    false
            v994
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v995 : bool = null |> unbox<bool>
            v995
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v996 : bool = null |> unbox<bool>
            v996
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v997 : IFsExistsSync = Fable.Core.JsInterop.importAll v40
            let v998 : string = "v997.existsSync($0)"
            let v999 : bool = Fable.Core.JsInterop.emitJsExpr v14 v998
            v999
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1000 : bool = null |> unbox<bool>
            v1000
#endif
            
#else
            let v1001 : (string -> bool) = System.IO.File.Exists
            let v1002 : bool = v1001 v14
            v1002
#endif
            |> fun x -> _v981 <- Some x
            let v1003 : bool = _v981.Value
            if v1003 then
                let v1004 : unit option = None
                let v1005 : bool = true in let mutable _v1004 = v1004
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1006 : string = method81(v23)
                let v1007 : string = "std::fs::copy(&*v14, &*v1006)"
                let v1008 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v1007
                let v1009 : string = "$0.unwrap()"
                let v1010 : uint64 = Fable.Core.RustInterop.emitRustExpr v1008 v1009
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
                System.IO.File.Copy (v14, v23, true)
                ()
#endif
                |> fun x -> _v1004 <- Some x
                _v1004.Value
                ()
            else
                let v1011 : string = $"documents.run / files_fn / {v14} should exist"
                failwith<unit> v1011
            let v1012 : Result<string, (string * string)> = Ok v14
            US19_0(v1012)
    else
        US19_1
and closure62 () () : string =
    let v0 : string = "documents.run / par_map / crowbook"
    v0
and closure63 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: %A{v1} / result: {v0} / {v2 ()}"
    v3
and closure61 (v0 : string, v1 : string, v2 : string) (v3 : string) : US19 =
    let v4 : string = ".md"
    let v5 : bool = v3.EndsWith v4
    let v6 : bool = v5 = false
    let v13 : string =
        if v6 then
            let v7 : string = $"{v0}.{v3}"
            v7
        else
            let v8 : string = "."
            let v9 : int32 = v0.LastIndexOf v8
            let v10 : int32 = v9 - 1
            let v11 : string = v0.[int 0..int v10]
            let v12 : string = $"{v11}.{v3}"
            v12
    let v14 : bool = v3.EndsWith v4
    let v15 : bool = v14 = false
    let v22 : string =
        if v15 then
            let v16 : string = $"{v1}.{v3}"
            v16
        else
            let v17 : string = "."
            let v18 : int32 = v1.LastIndexOf v17
            let v19 : int32 = v18 - 1
            let v20 : string = v1.[int 0..int v19]
            let v21 : string = $"{v20}.{v3}"
            v21
    let v23 : bool option = None
    let v24 : bool = true in let mutable _v23 = v23
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v25 : string = method18(v13)
    let v26 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v27 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v26
    let v28 : string = "String::from($0)"
    let v29 : std_string_String = Fable.Core.RustInterop.emitRustExpr v27 v28
    let v30 : string = "std::path::PathBuf::from($0)"
    let v31 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v29 v30
    let v32 : string = "$0.exists()"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr v31 v32
    let v36 : bool =
        if v33 then
            let v34 : string = "$0.is_file()"
            let v35 : bool = Fable.Core.RustInterop.emitRustExpr v31 v34
            v35
        else
            false
    v36
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v37 : bool = null |> unbox<bool>
    v37
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v38 : bool = null |> unbox<bool>
    v38
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v39 : string = "fs"
    let v40 : IFsExistsSync = Fable.Core.JsInterop.importAll v39
    let v41 : string = "v40.existsSync($0)"
    let v42 : bool = Fable.Core.JsInterop.emitJsExpr v13 v41
    v42
#endif
    
#if FABLE_COMPILER_PYTHON
    let v43 : bool = null |> unbox<bool>
    v43
#endif
    
#else
    let v44 : (string -> bool) = System.IO.File.Exists
    let v45 : bool = v44 v13
    v45
#endif
    |> fun x -> _v23 <- Some x
    let v46 : bool = _v23.Value
    let v70 : bool =
        if v46 then
            let v47 : bool option = None
            let v48 : bool = true in let mutable _v47 = v47
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v49 : string = method18(v22)
            let v50 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v51 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v49 v50
            let v52 : string = "String::from($0)"
            let v53 : std_string_String = Fable.Core.RustInterop.emitRustExpr v51 v52
            let v54 : string = "std::path::PathBuf::from($0)"
            let v55 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v53 v54
            let v56 : string = "$0.exists()"
            let v57 : bool = Fable.Core.RustInterop.emitRustExpr v55 v56
            let v60 : bool =
                if v57 then
                    let v58 : string = "$0.is_file()"
                    let v59 : bool = Fable.Core.RustInterop.emitRustExpr v55 v58
                    v59
                else
                    false
            v60
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v61 : bool = null |> unbox<bool>
            v61
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v62 : bool = null |> unbox<bool>
            v62
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v63 : IFsExistsSync = Fable.Core.JsInterop.importAll v39
            let v64 : string = "v63.existsSync($0)"
            let v65 : bool = Fable.Core.JsInterop.emitJsExpr v22 v64
            v65
#endif
            
#if FABLE_COMPILER_PYTHON
            let v66 : bool = null |> unbox<bool>
            v66
#endif
            
#else
            let v67 : (string -> bool) = System.IO.File.Exists
            let v68 : bool = v67 v22
            v68
#endif
            |> fun x -> _v47 <- Some x
            let v69 : bool = _v47.Value
            v69
        else
            false
    let v591 : bool =
        if v70 then
            let v71 : bool option = None
            let v72 : bool = true in let mutable _v71 = v71
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v73 : string = "cfg!(windows)"
            let v74 : bool = Fable.Core.RustInterop.emitRustExpr () v73
            v74
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v75 : bool = null |> unbox<bool>
            v75
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v76 : bool = null |> unbox<bool>
            v76
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v77 : bool = null |> unbox<bool>
            v77
#endif
            
#if FABLE_COMPILER_PYTHON
            let v78 : bool = null |> unbox<bool>
            v78
#endif
            
#else
            let v79 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v80 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v81 : bool = v80 v79
            v81
#endif
            |> fun x -> _v71 <- Some x
            let v82 : bool = _v71.Value
            let v83 : bool = v82 = false
            let v107 : string =
                if v83 then
                    v13
                else
                    let v84 : string option = None
                    let v85 : bool = true in let mutable _v84 = v84
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v86 : string = method26()
                    let v87 : string = method27(v13)
                    let v88 : string = method28()
                    let v89 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v86, v87, v88) v89
                    let v91 : string = "String::from($0)"
                    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr v90 v91
                    let v93 : string = "fable_library_rust::String_::fromString($0)"
                    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93
                    v94
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v95 : string = null |> unbox<string>
                    v95
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v96 : string = null |> unbox<string>
                    v96
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v97 : string = null |> unbox<string>
                    v97
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v98 : string = null |> unbox<string>
                    v98
#endif
                    
#else
                    let v99 : string = "^\\\\\\\\\\?\\\\"
                    let v100 : string = ""
                    let v101 : string = System.Text.RegularExpressions.Regex.Replace (v13, v99, v100)
                    v101
#endif
                    |> fun x -> _v84 <- Some x
                    let v102 : string = _v84.Value
                    let v103 : string = $"{v102.[0] |> string |> _.ToLower()}{v102.[1..]}"
                    let v104 : string = "\\"
                    let v105 : string = "/"
                    let v106 : string = v103.Replace (v104, v105)
                    v106
            let v108 : string option = None
            let v109 : System.Threading.CancellationToken option = None
            let v110 : (struct (string * string) []) = [||]
            let v111 : (struct (bool * string * int32) -> Async<unit>) option = None
            let v112 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
            let v113 : string = $"pwsh -c \"(Get-FileHash \\\"{v107}\\\" -Algorithm SHA256).Hash\""
            let v114 : struct (int32 * string) option = None
            let v115 : bool = true in let mutable _v114 = v114
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v116 : string = method42(v109, v113, v110, v111, v112, v108)
            let struct (v117 : string, v118 : string) = method43()
            let v119 : int32 = v116.Length
            let v120 : (char []) = Array.zeroCreate<char> (v119)
            let v121 : Mut5 = {l0 = 0} : Mut5
            while method30(v119, v121) do
                let v123 : int32 = v121.l0
                let v124 : char = v116.[int v123]
                v120.[int v123] <- v124
                let v125 : int32 = v123 + 1
                v121.l0 <- v125
                ()
            let v126 : ((char []) -> char list) = Array.toList
            let v127 : char list = v126 v120
            let v128 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v129 : (char -> (UH0 -> UH0)) = method44()
            let v130 : (char list -> (UH0 -> UH0)) = v128 v129
            let v131 : (UH0 -> UH0) = v130 v127
            let v132 : UH0 = UH0_0
            let v133 : UH0 = v131 v132
            let v134 : US8 = US8_0
            let struct (v135 : string, v136 : string) = method45(v118, v117, v133, v134)
            let v137 : (string []) = method46(v136)
            let v138 : string = "$0.to_vec()"
            let v139 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v137 v138
            let v140 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v141 : (string -> std_string_String) = closure28()
            let v142 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v139, v141) v140
            let v143 : US0 = US0_1
            let v144 : (unit -> string) = closure29(v109, v113, v110, v111, v112, v108, v135, v142)
            let v145 : (unit -> string) = method51()
            method3(v143, v144, v145)
            let v146 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method52(v109, v113, v110, v111, v112, v108, v135, v142)
            let v147 : string = "futures_lite::future::block_on($0)"
            let v148 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v146 v147
            let (a, b) = v148
            let v149 : int32 = a
            let v150 : string = b
            struct (v149, v150)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v151 : int32, v152 : string) = null |> unbox<struct (int32 * string)>
            struct (v151, v152)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v153 : int32, v154 : string) = null |> unbox<struct (int32 * string)>
            struct (v153, v154)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v155 : int32, v156 : string) = null |> unbox<struct (int32 * string)>
            struct (v155, v156)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v157 : int32, v158 : string) = null |> unbox<struct (int32 * string)>
            struct (v157, v158)
#endif
            
#else
            let v159 : Async<struct (int32 * string)> option = None
            let v160 : bool = true in let mutable _v159 = v159
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v161 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v161
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v162 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v162
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v163 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v163
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v164 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v164
#endif
            
#if FABLE_COMPILER_PYTHON
            let v165 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v165
#endif
            
#else
            let v166 : Async<struct (int32 * string)> option = None
            let v167 : bool = true in let mutable _v166 = v166
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v168 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v168
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v169 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v169
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v170 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v170
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v171 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v171
#endif
            
#if FABLE_COMPILER_PYTHON
            let v172 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v172
#endif
            
#else
            let v173 : Async<struct (int32 * string)> option = None
            let mutable _v173 = v173
            async {
            let struct (v174 : string, v175 : string) = method43()
            let v176 : int32 = v113.Length
            let v177 : (char []) = Array.zeroCreate<char> (v176)
            let v178 : Mut5 = {l0 = 0} : Mut5
            while method30(v176, v178) do
                let v180 : int32 = v178.l0
                let v181 : char = v113.[int v180]
                v177.[int v180] <- v181
                let v182 : int32 = v180 + 1
                v178.l0 <- v182
                ()
            let v183 : ((char []) -> char list) = Array.toList
            let v184 : char list = v183 v177
            let v185 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v186 : (char -> (UH0 -> UH0)) = method44()
            let v187 : (char list -> (UH0 -> UH0)) = v185 v186
            let v188 : (UH0 -> UH0) = v187 v184
            let v189 : UH0 = UH0_0
            let v190 : UH0 = v188 v189
            let v191 : US8 = US8_0
            let struct (v192 : string, v193 : string) = method45(v175, v174, v190, v191)
            let v194 : (string -> US4) = method22()
            let v195 : US4 = US4_1
            let v196 : US4 = v108 |> Option.map v194 |> Option.defaultValue v195 
            let v200 : string =
                match v196 with
                | US4_1 -> (* None *)
                    let v198 : string = ""
                    v198
                | US4_0(v197) -> (* Some *)
                    v197
            let v201 : US0 = US0_1
            let v202 : (unit -> string) = closure48(v109, v113, v110, v111, v112, v108)
            let v203 : (unit -> string) = method51()
            method3(v201, v202, v203)
            let v204 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v205 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v193, StandardOutputEncoding = v204, WorkingDirectory = v200, FileName = v192, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v206 : int32 = v110.Length
            let v207 : Mut5 = {l0 = 0} : Mut5
            while method30(v206, v207) do
                let v209 : int32 = v207.l0
                let struct (v210 : string, v211 : string) = v110.[int v209]
                v205.EnvironmentVariables.[v210] <- v211 
                let v212 : int32 = v209 + 1
                v207.l0 <- v212
                ()
            let v213 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v205)
            use v213 = v213 
            let v214 : System.Diagnostics.Process = v213 
            let v215 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v216 : System.Collections.Concurrent.ConcurrentStack<string> = v215 ()
            let v217 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v109, v113, v110, v111, v112, v108, v214, v216)
            v214.OutputDataReceived.Add v217 
            let v218 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v109, v113, v110, v111, v112, v108, v214, v216)
            v214.ErrorDataReceived.Add v218 
            let v219 : (unit -> bool) = v214.Start
            let v220 : bool = v219 ()
            let v221 : bool = v220 = false
            if v221 then
                let v222 : string = $"execute_with_options_async / process_start error"
                failwith<unit> v222
            let v223 : (unit -> unit) = v214.BeginErrorReadLine
            v223 ()
            let v224 : (unit -> unit) = v214.BeginOutputReadLine
            v224 ()
            let v225 : (System.Threading.CancellationToken -> US18) = method74()
            let v226 : US18 = US18_1
            let v227 : US18 = v109 |> Option.map v225 |> Option.defaultValue v226 
            let v231 : System.Threading.CancellationToken =
                match v227 with
                | US18_1 -> (* None *)
                    let v229 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v229
                | US18_0(v228) -> (* Some *)
                    v228
            let v232 : Async<System.Threading.CancellationToken> option = None
            let v233 : bool = true in let mutable _v232 = v232
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v234 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v234
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v235 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v235
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v236 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v236
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v237 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v237
#endif
            
#if FABLE_COMPILER_PYTHON
            let v238 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v238
#endif
            
#else
            let v239 : Async<System.Threading.CancellationToken> option = None
            let v240 : bool = true in let mutable _v239 = v239
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v241 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v241
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v242 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v242
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v243 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v243
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v244 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v244
#endif
            
#if FABLE_COMPILER_PYTHON
            let v245 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v245
#endif
            
#else
            let v246 : Async<System.Threading.CancellationToken> option = None
            let mutable _v246 = v246
            async {
            let v247 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v247 = v247 
            let v248 : System.Threading.CancellationToken = v247 
            let v249 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v250 : (System.Threading.CancellationToken []) = [|v248; v249; v231|]
            let v251 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v252 : System.Threading.CancellationTokenSource = v251 v250
            let v253 : System.Threading.CancellationToken = v252.Token
            return v253 
            }
            |> fun x -> _v246 <- Some x
            let v254 : Async<System.Threading.CancellationToken> = _v246 |> Option.get
            v254
#endif
            |> fun x -> _v239 <- Some x
            let v255 : Async<System.Threading.CancellationToken> = _v239.Value
            v255
#endif
            |> fun x -> _v232 <- Some x
            let v256 : Async<System.Threading.CancellationToken> = _v232.Value
            let! v256 = v256 
            let v257 : System.Threading.CancellationToken = v256 
            let v258 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v257.Register
            let v259 : (unit -> unit) = closure54(v214)
            let v260 : System.Threading.CancellationTokenRegistration = v258 v259
            use v260 = v260 
            let v261 : System.Threading.CancellationTokenRegistration = v260 
            let v262 : Async<int32> option = None
            let v263 : bool = true in let mutable _v262 = v262
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v264 : Async<int32> = null |> unbox<Async<int32>>
            v264
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v265 : Async<int32> = null |> unbox<Async<int32>>
            v265
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v266 : Async<int32> = null |> unbox<Async<int32>>
            v266
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v267 : Async<int32> = null |> unbox<Async<int32>>
            v267
#endif
            
#if FABLE_COMPILER_PYTHON
            let v268 : Async<int32> = null |> unbox<Async<int32>>
            v268
#endif
            
#else
            let v269 : Async<int32> option = None
            let mutable _v269 = v269
            async {
            try
            let v270 : System.Threading.Tasks.Task = v214.WaitForExitAsync v257 
            let v271 : Async<unit> option = None
            let v272 : bool = true in let mutable _v271 = v271
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v273 : Async<unit> = null |> unbox<Async<unit>>
            v273
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v274 : Async<unit> = null |> unbox<Async<unit>>
            v274
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v275 : Async<unit> = null |> unbox<Async<unit>>
            v275
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v276 : Async<unit> = null |> unbox<Async<unit>>
            v276
#endif
            
#if FABLE_COMPILER_PYTHON
            let v277 : Async<unit> = null |> unbox<Async<unit>>
            v277
#endif
            
#else
            let v278 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v279 : Async<unit> = v278 v270
            v279
#endif
            |> fun x -> _v271 <- Some x
            let v280 : Async<unit> = _v271.Value
            do! v280 
            let v281 : int32 = v214.ExitCode
            return v281 
            with ex ->
            let v282 : exn = ex
            let v283 : string option = None
            let v284 : bool = true in let mutable _v283 = v283
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v285 : string = $"%A{v282}"
            v285
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v286 : string = $"%A{v282}"
            v286
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v287 : string = $"%A{v282}"
            v287
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v288 : string = $"%A{v282}"
            v288
#endif
            
#if FABLE_COMPILER_PYTHON
            let v289 : string = $"%A{v282}"
            v289
#endif
            
#else
            let v290 : string = $"{v282.GetType ()}: {v282.Message}"
            v290
#endif
            |> fun x -> _v283 <- Some x
            let v291 : string = _v283.Value
            let v292 : (string -> unit) = v216.Push
            v292 v291
            let v293 : System.Threading.Tasks.TaskCanceledException = v282 |> unbox<System.Threading.Tasks.TaskCanceledException>
            let v294 : US0 = US0_3
            let v295 : (unit -> string) = closure55(v293)
            let v296 : (unit -> string) = method51()
            method3(v294, v295, v296)
            return -2147483648 
            (*
            *)
            }
            |> fun x -> _v269 <- Some x
            let v297 : Async<int32> = _v269 |> Option.get
            v297
#endif
            |> fun x -> _v262 <- Some x
            let v298 : Async<int32> = _v262.Value
            let! v298 = v298 
            let v299 : int32 = v298 
            let v300 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v301 : string seq = v300 v216
            let v302 : string = method75()
            let v303 : (string -> (string seq -> string)) = String.concat
            let v304 : (string seq -> string) = v303 v302
            let v305 : string = v304 v301
            let v306 : US0 = US0_1
            let v307 : (unit -> string) = closure56(v299, v305)
            let v308 : (unit -> string) = method51()
            method3(v306, v307, v308)
            return struct (v299, v305) 
            }
            |> fun x -> _v173 <- Some x
            let v309 : Async<struct (int32 * string)> = _v173 |> Option.get
            v309
#endif
            |> fun x -> _v166 <- Some x
            let v310 : Async<struct (int32 * string)> = _v166.Value
            v310
#endif
            |> fun x -> _v159 <- Some x
            let v311 : Async<struct (int32 * string)> = _v159.Value
            let v312 : struct (int32 * string) option = None
            let v313 : bool = true in let mutable _v312 = v312
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v314 : int32, v315 : string) = null |> unbox<struct (int32 * string)>
            struct (v314, v315)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v316 : int32, v317 : string) = null |> unbox<struct (int32 * string)>
            struct (v316, v317)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v318 : int32, v319 : string) = null |> unbox<struct (int32 * string)>
            struct (v318, v319)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v320 : int32, v321 : string) = null |> unbox<struct (int32 * string)>
            struct (v320, v321)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v322 : int32, v323 : string) = null |> unbox<struct (int32 * string)>
            struct (v322, v323)
#endif
            
#else
            let v324 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
            let struct (v325 : int32, v326 : string) = v324 v311
            struct (v325, v326)
#endif
            |> fun x -> _v312 <- Some x
            let struct (v327 : int32, v328 : string) = _v312.Value
            struct (v327, v328)
#endif
            |> fun x -> _v114 <- Some x
            let struct (v329 : int32, v330 : string) = _v114.Value
            let v331 : bool option = None
            let v332 : bool = true in let mutable _v331 = v331
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v333 : string = "cfg!(windows)"
            let v334 : bool = Fable.Core.RustInterop.emitRustExpr () v333
            v334
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v335 : bool = null |> unbox<bool>
            v335
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v336 : bool = null |> unbox<bool>
            v336
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v337 : bool = null |> unbox<bool>
            v337
#endif
            
#if FABLE_COMPILER_PYTHON
            let v338 : bool = null |> unbox<bool>
            v338
#endif
            
#else
            let v339 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v340 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v341 : bool = v340 v339
            v341
#endif
            |> fun x -> _v331 <- Some x
            let v342 : bool = _v331.Value
            let v343 : bool = v342 = false
            let v367 : string =
                if v343 then
                    v22
                else
                    let v344 : string option = None
                    let v345 : bool = true in let mutable _v344 = v344
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v346 : string = method26()
                    let v347 : string = method27(v22)
                    let v348 : string = method28()
                    let v349 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v350 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v346, v347, v348) v349
                    let v351 : string = "String::from($0)"
                    let v352 : std_string_String = Fable.Core.RustInterop.emitRustExpr v350 v351
                    let v353 : string = "fable_library_rust::String_::fromString($0)"
                    let v354 : string = Fable.Core.RustInterop.emitRustExpr v352 v353
                    v354
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v355 : string = null |> unbox<string>
                    v355
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v356 : string = null |> unbox<string>
                    v356
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v357 : string = null |> unbox<string>
                    v357
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v358 : string = null |> unbox<string>
                    v358
#endif
                    
#else
                    let v359 : string = "^\\\\\\\\\\?\\\\"
                    let v360 : string = ""
                    let v361 : string = System.Text.RegularExpressions.Regex.Replace (v22, v359, v360)
                    v361
#endif
                    |> fun x -> _v344 <- Some x
                    let v362 : string = _v344.Value
                    let v363 : string = $"{v362.[0] |> string |> _.ToLower()}{v362.[1..]}"
                    let v364 : string = "\\"
                    let v365 : string = "/"
                    let v366 : string = v363.Replace (v364, v365)
                    v366
            let v368 : string option = None
            let v369 : System.Threading.CancellationToken option = None
            let v370 : (struct (string * string) []) = [||]
            let v371 : (struct (bool * string * int32) -> Async<unit>) option = None
            let v372 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
            let v373 : string = $"pwsh -c \"(Get-FileHash \\\"{v367}\\\" -Algorithm SHA256).Hash\""
            let v374 : struct (int32 * string) option = None
            let v375 : bool = true in let mutable _v374 = v374
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v376 : string = method42(v369, v373, v370, v371, v372, v368)
            let struct (v377 : string, v378 : string) = method43()
            let v379 : int32 = v376.Length
            let v380 : (char []) = Array.zeroCreate<char> (v379)
            let v381 : Mut5 = {l0 = 0} : Mut5
            while method30(v379, v381) do
                let v383 : int32 = v381.l0
                let v384 : char = v376.[int v383]
                v380.[int v383] <- v384
                let v385 : int32 = v383 + 1
                v381.l0 <- v385
                ()
            let v386 : ((char []) -> char list) = Array.toList
            let v387 : char list = v386 v380
            let v388 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v389 : (char -> (UH0 -> UH0)) = method44()
            let v390 : (char list -> (UH0 -> UH0)) = v388 v389
            let v391 : (UH0 -> UH0) = v390 v387
            let v392 : UH0 = UH0_0
            let v393 : UH0 = v391 v392
            let v394 : US8 = US8_0
            let struct (v395 : string, v396 : string) = method45(v378, v377, v393, v394)
            let v397 : (string []) = method46(v396)
            let v398 : string = "$0.to_vec()"
            let v399 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v397 v398
            let v400 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v401 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v399, v141) v400
            let v402 : US0 = US0_1
            let v403 : (unit -> string) = closure29(v369, v373, v370, v371, v372, v368, v395, v401)
            let v404 : (unit -> string) = method51()
            method3(v402, v403, v404)
            let v405 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method52(v369, v373, v370, v371, v372, v368, v395, v401)
            let v406 : string = "futures_lite::future::block_on($0)"
            let v407 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v405 v406
            let (a, b) = v407
            let v408 : int32 = a
            let v409 : string = b
            struct (v408, v409)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v410 : int32, v411 : string) = null |> unbox<struct (int32 * string)>
            struct (v410, v411)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v412 : int32, v413 : string) = null |> unbox<struct (int32 * string)>
            struct (v412, v413)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v414 : int32, v415 : string) = null |> unbox<struct (int32 * string)>
            struct (v414, v415)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v416 : int32, v417 : string) = null |> unbox<struct (int32 * string)>
            struct (v416, v417)
#endif
            
#else
            let v418 : Async<struct (int32 * string)> option = None
            let v419 : bool = true in let mutable _v418 = v418
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v420 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v420
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v421 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v421
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v422 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v422
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v423 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v423
#endif
            
#if FABLE_COMPILER_PYTHON
            let v424 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v424
#endif
            
#else
            let v425 : Async<struct (int32 * string)> option = None
            let v426 : bool = true in let mutable _v425 = v425
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v427 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v427
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v428 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v428
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v429 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v429
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v430 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v430
#endif
            
#if FABLE_COMPILER_PYTHON
            let v431 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v431
#endif
            
#else
            let v432 : Async<struct (int32 * string)> option = None
            let mutable _v432 = v432
            async {
            let struct (v433 : string, v434 : string) = method43()
            let v435 : int32 = v373.Length
            let v436 : (char []) = Array.zeroCreate<char> (v435)
            let v437 : Mut5 = {l0 = 0} : Mut5
            while method30(v435, v437) do
                let v439 : int32 = v437.l0
                let v440 : char = v373.[int v439]
                v436.[int v439] <- v440
                let v441 : int32 = v439 + 1
                v437.l0 <- v441
                ()
            let v442 : ((char []) -> char list) = Array.toList
            let v443 : char list = v442 v436
            let v444 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v445 : (char -> (UH0 -> UH0)) = method44()
            let v446 : (char list -> (UH0 -> UH0)) = v444 v445
            let v447 : (UH0 -> UH0) = v446 v443
            let v448 : UH0 = UH0_0
            let v449 : UH0 = v447 v448
            let v450 : US8 = US8_0
            let struct (v451 : string, v452 : string) = method45(v434, v433, v449, v450)
            let v453 : (string -> US4) = method22()
            let v454 : US4 = US4_1
            let v455 : US4 = v368 |> Option.map v453 |> Option.defaultValue v454 
            let v459 : string =
                match v455 with
                | US4_1 -> (* None *)
                    let v457 : string = ""
                    v457
                | US4_0(v456) -> (* Some *)
                    v456
            let v460 : US0 = US0_1
            let v461 : (unit -> string) = closure48(v369, v373, v370, v371, v372, v368)
            let v462 : (unit -> string) = method51()
            method3(v460, v461, v462)
            let v463 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v464 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v452, StandardOutputEncoding = v463, WorkingDirectory = v459, FileName = v451, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v465 : int32 = v370.Length
            let v466 : Mut5 = {l0 = 0} : Mut5
            while method30(v465, v466) do
                let v468 : int32 = v466.l0
                let struct (v469 : string, v470 : string) = v370.[int v468]
                v464.EnvironmentVariables.[v469] <- v470 
                let v471 : int32 = v468 + 1
                v466.l0 <- v471
                ()
            let v472 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v464)
            use v472 = v472 
            let v473 : System.Diagnostics.Process = v472 
            let v474 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v475 : System.Collections.Concurrent.ConcurrentStack<string> = v474 ()
            let v476 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v369, v373, v370, v371, v372, v368, v473, v475)
            v473.OutputDataReceived.Add v476 
            let v477 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v369, v373, v370, v371, v372, v368, v473, v475)
            v473.ErrorDataReceived.Add v477 
            let v478 : (unit -> bool) = v473.Start
            let v479 : bool = v478 ()
            let v480 : bool = v479 = false
            if v480 then
                let v481 : string = $"execute_with_options_async / process_start error"
                failwith<unit> v481
            let v482 : (unit -> unit) = v473.BeginErrorReadLine
            v482 ()
            let v483 : (unit -> unit) = v473.BeginOutputReadLine
            v483 ()
            let v484 : (System.Threading.CancellationToken -> US18) = method74()
            let v485 : US18 = US18_1
            let v486 : US18 = v369 |> Option.map v484 |> Option.defaultValue v485 
            let v490 : System.Threading.CancellationToken =
                match v486 with
                | US18_1 -> (* None *)
                    let v488 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v488
                | US18_0(v487) -> (* Some *)
                    v487
            let v491 : Async<System.Threading.CancellationToken> option = None
            let v492 : bool = true in let mutable _v491 = v491
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v493 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v493
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v494 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v494
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v495 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v495
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v496 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v496
#endif
            
#if FABLE_COMPILER_PYTHON
            let v497 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v497
#endif
            
#else
            let v498 : Async<System.Threading.CancellationToken> option = None
            let v499 : bool = true in let mutable _v498 = v498
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v500 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v500
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v501 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v501
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v502 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v502
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v503 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v503
#endif
            
#if FABLE_COMPILER_PYTHON
            let v504 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v504
#endif
            
#else
            let v505 : Async<System.Threading.CancellationToken> option = None
            let mutable _v505 = v505
            async {
            let v506 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v506 = v506 
            let v507 : System.Threading.CancellationToken = v506 
            let v508 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v509 : (System.Threading.CancellationToken []) = [|v507; v508; v490|]
            let v510 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v511 : System.Threading.CancellationTokenSource = v510 v509
            let v512 : System.Threading.CancellationToken = v511.Token
            return v512 
            }
            |> fun x -> _v505 <- Some x
            let v513 : Async<System.Threading.CancellationToken> = _v505 |> Option.get
            v513
#endif
            |> fun x -> _v498 <- Some x
            let v514 : Async<System.Threading.CancellationToken> = _v498.Value
            v514
#endif
            |> fun x -> _v491 <- Some x
            let v515 : Async<System.Threading.CancellationToken> = _v491.Value
            let! v515 = v515 
            let v516 : System.Threading.CancellationToken = v515 
            let v517 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v516.Register
            let v518 : (unit -> unit) = closure54(v473)
            let v519 : System.Threading.CancellationTokenRegistration = v517 v518
            use v519 = v519 
            let v520 : System.Threading.CancellationTokenRegistration = v519 
            let v521 : Async<int32> option = None
            let v522 : bool = true in let mutable _v521 = v521
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v523 : Async<int32> = null |> unbox<Async<int32>>
            v523
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v524 : Async<int32> = null |> unbox<Async<int32>>
            v524
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v525 : Async<int32> = null |> unbox<Async<int32>>
            v525
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v526 : Async<int32> = null |> unbox<Async<int32>>
            v526
#endif
            
#if FABLE_COMPILER_PYTHON
            let v527 : Async<int32> = null |> unbox<Async<int32>>
            v527
#endif
            
#else
            let v528 : Async<int32> option = None
            let mutable _v528 = v528
            async {
            try
            let v529 : System.Threading.Tasks.Task = v473.WaitForExitAsync v516 
            let v530 : Async<unit> option = None
            let v531 : bool = true in let mutable _v530 = v530
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v532 : Async<unit> = null |> unbox<Async<unit>>
            v532
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v533 : Async<unit> = null |> unbox<Async<unit>>
            v533
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v534 : Async<unit> = null |> unbox<Async<unit>>
            v534
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v535 : Async<unit> = null |> unbox<Async<unit>>
            v535
#endif
            
#if FABLE_COMPILER_PYTHON
            let v536 : Async<unit> = null |> unbox<Async<unit>>
            v536
#endif
            
#else
            let v537 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v538 : Async<unit> = v537 v529
            v538
#endif
            |> fun x -> _v530 <- Some x
            let v539 : Async<unit> = _v530.Value
            do! v539 
            let v540 : int32 = v473.ExitCode
            return v540 
            with ex ->
            let v541 : exn = ex
            let v542 : string option = None
            let v543 : bool = true in let mutable _v542 = v542
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v544 : string = $"%A{v541}"
            v544
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v545 : string = $"%A{v541}"
            v545
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v546 : string = $"%A{v541}"
            v546
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v547 : string = $"%A{v541}"
            v547
#endif
            
#if FABLE_COMPILER_PYTHON
            let v548 : string = $"%A{v541}"
            v548
#endif
            
#else
            let v549 : string = $"{v541.GetType ()}: {v541.Message}"
            v549
#endif
            |> fun x -> _v542 <- Some x
            let v550 : string = _v542.Value
            let v551 : (string -> unit) = v475.Push
            v551 v550
            let v552 : System.Threading.Tasks.TaskCanceledException = v541 |> unbox<System.Threading.Tasks.TaskCanceledException>
            let v553 : US0 = US0_3
            let v554 : (unit -> string) = closure55(v552)
            let v555 : (unit -> string) = method51()
            method3(v553, v554, v555)
            return -2147483648 
            (*
            *)
            }
            |> fun x -> _v528 <- Some x
            let v556 : Async<int32> = _v528 |> Option.get
            v556
#endif
            |> fun x -> _v521 <- Some x
            let v557 : Async<int32> = _v521.Value
            let! v557 = v557 
            let v558 : int32 = v557 
            let v559 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v560 : string seq = v559 v475
            let v561 : string = method75()
            let v562 : (string -> (string seq -> string)) = String.concat
            let v563 : (string seq -> string) = v562 v561
            let v564 : string = v563 v560
            let v565 : US0 = US0_1
            let v566 : (unit -> string) = closure56(v558, v564)
            let v567 : (unit -> string) = method51()
            method3(v565, v566, v567)
            return struct (v558, v564) 
            }
            |> fun x -> _v432 <- Some x
            let v568 : Async<struct (int32 * string)> = _v432 |> Option.get
            v568
#endif
            |> fun x -> _v425 <- Some x
            let v569 : Async<struct (int32 * string)> = _v425.Value
            v569
#endif
            |> fun x -> _v418 <- Some x
            let v570 : Async<struct (int32 * string)> = _v418.Value
            let v571 : struct (int32 * string) option = None
            let v572 : bool = true in let mutable _v571 = v571
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v573 : int32, v574 : string) = null |> unbox<struct (int32 * string)>
            struct (v573, v574)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v575 : int32, v576 : string) = null |> unbox<struct (int32 * string)>
            struct (v575, v576)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v577 : int32, v578 : string) = null |> unbox<struct (int32 * string)>
            struct (v577, v578)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v579 : int32, v580 : string) = null |> unbox<struct (int32 * string)>
            struct (v579, v580)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v581 : int32, v582 : string) = null |> unbox<struct (int32 * string)>
            struct (v581, v582)
#endif
            
#else
            let v583 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
            let struct (v584 : int32, v585 : string) = v583 v570
            struct (v584, v585)
#endif
            |> fun x -> _v571 <- Some x
            let struct (v586 : int32, v587 : string) = _v571.Value
            struct (v586, v587)
#endif
            |> fun x -> _v374 <- Some x
            let struct (v588 : int32, v589 : string) = _v374.Value
            let v590 : bool = v330 = v589
            v590
        else
            false
    let v592 : bool = v591 = false
    if v592 then
        let v593 : string = $"crowbook --single \"{v0}\" --output \"{v13}\" --to {v3} --set rendering.num_depth 6 html.css.add \\\"''' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} '''\\\""
        let v594 : string option = None
        let v595 : System.Threading.CancellationToken option = None
        let v596 : (struct (string * string) []) = [||]
        let v597 : (struct (bool * string * int32) -> Async<unit>) option = None
        let v598 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
        let v599 : string option = Some v2 
        let v600 : struct (int32 * string) option = None
        let v601 : bool = true in let mutable _v600 = v600
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v602 : string = method42(v595, v593, v596, v597, v598, v599)
        let struct (v603 : string, v604 : string) = method43()
        let v605 : int32 = v602.Length
        let v606 : (char []) = Array.zeroCreate<char> (v605)
        let v607 : Mut5 = {l0 = 0} : Mut5
        while method30(v605, v607) do
            let v609 : int32 = v607.l0
            let v610 : char = v602.[int v609]
            v606.[int v609] <- v610
            let v611 : int32 = v609 + 1
            v607.l0 <- v611
            ()
        let v612 : ((char []) -> char list) = Array.toList
        let v613 : char list = v612 v606
        let v614 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
        let v615 : (char -> (UH0 -> UH0)) = method44()
        let v616 : (char list -> (UH0 -> UH0)) = v614 v615
        let v617 : (UH0 -> UH0) = v616 v613
        let v618 : UH0 = UH0_0
        let v619 : UH0 = v617 v618
        let v620 : US8 = US8_0
        let struct (v621 : string, v622 : string) = method45(v604, v603, v619, v620)
        let v623 : (string []) = method46(v622)
        let v624 : string = "$0.to_vec()"
        let v625 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v623 v624
        let v626 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
        let v627 : (string -> std_string_String) = closure28()
        let v628 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v625, v627) v626
        let v629 : US0 = US0_1
        let v630 : (unit -> string) = closure29(v595, v593, v596, v597, v598, v599, v621, v628)
        let v631 : (unit -> string) = method51()
        method3(v629, v630, v631)
        let v632 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method52(v595, v593, v596, v597, v598, v599, v621, v628)
        let v633 : string = "futures_lite::future::block_on($0)"
        let v634 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v632 v633
        let (a, b) = v634
        let v635 : int32 = a
        let v636 : string = b
        struct (v635, v636)
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let struct (v637 : int32, v638 : string) = null |> unbox<struct (int32 * string)>
        struct (v637, v638)
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let struct (v639 : int32, v640 : string) = null |> unbox<struct (int32 * string)>
        struct (v639, v640)
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let struct (v641 : int32, v642 : string) = null |> unbox<struct (int32 * string)>
        struct (v641, v642)
#endif
        
#if FABLE_COMPILER_PYTHON
        let struct (v643 : int32, v644 : string) = null |> unbox<struct (int32 * string)>
        struct (v643, v644)
#endif
        
#else
        let v645 : Async<struct (int32 * string)> option = None
        let v646 : bool = true in let mutable _v645 = v645
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v647 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v647
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v648 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v648
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v649 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v649
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v650 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v650
#endif
        
#if FABLE_COMPILER_PYTHON
        let v651 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v651
#endif
        
#else
        let v652 : Async<struct (int32 * string)> option = None
        let v653 : bool = true in let mutable _v652 = v652
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v654 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v654
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v655 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v655
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v656 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v656
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v657 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v657
#endif
        
#if FABLE_COMPILER_PYTHON
        let v658 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v658
#endif
        
#else
        let v659 : Async<struct (int32 * string)> option = None
        let mutable _v659 = v659
        async {
        let struct (v660 : string, v661 : string) = method43()
        let v662 : int32 = v593.Length
        let v663 : (char []) = Array.zeroCreate<char> (v662)
        let v664 : Mut5 = {l0 = 0} : Mut5
        while method30(v662, v664) do
            let v666 : int32 = v664.l0
            let v667 : char = v593.[int v666]
            v663.[int v666] <- v667
            let v668 : int32 = v666 + 1
            v664.l0 <- v668
            ()
        let v669 : ((char []) -> char list) = Array.toList
        let v670 : char list = v669 v663
        let v671 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
        let v672 : (char -> (UH0 -> UH0)) = method44()
        let v673 : (char list -> (UH0 -> UH0)) = v671 v672
        let v674 : (UH0 -> UH0) = v673 v670
        let v675 : UH0 = UH0_0
        let v676 : UH0 = v674 v675
        let v677 : US8 = US8_0
        let struct (v678 : string, v679 : string) = method45(v661, v660, v676, v677)
        let v680 : (string -> US4) = method22()
        let v681 : US4 = US4_1
        let v682 : US4 = v599 |> Option.map v680 |> Option.defaultValue v681 
        let v686 : string =
            match v682 with
            | US4_1 -> (* None *)
                let v684 : string = ""
                v684
            | US4_0(v683) -> (* Some *)
                v683
        let v687 : US0 = US0_1
        let v688 : (unit -> string) = closure48(v595, v593, v596, v597, v598, v599)
        let v689 : (unit -> string) = method51()
        method3(v687, v688, v689)
        let v690 : System.Text.Encoding = System.Text.Encoding.UTF8
        let v691 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v679, StandardOutputEncoding = v690, WorkingDirectory = v686, FileName = v678, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
        let v692 : int32 = v596.Length
        let v693 : Mut5 = {l0 = 0} : Mut5
        while method30(v692, v693) do
            let v695 : int32 = v693.l0
            let struct (v696 : string, v697 : string) = v596.[int v695]
            v691.EnvironmentVariables.[v696] <- v697 
            let v698 : int32 = v695 + 1
            v693.l0 <- v698
            ()
        let v699 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v691)
        use v699 = v699 
        let v700 : System.Diagnostics.Process = v699 
        let v701 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
        let v702 : System.Collections.Concurrent.ConcurrentStack<string> = v701 ()
        let v703 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v595, v593, v596, v597, v598, v599, v700, v702)
        v700.OutputDataReceived.Add v703 
        let v704 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v595, v593, v596, v597, v598, v599, v700, v702)
        v700.ErrorDataReceived.Add v704 
        let v705 : (unit -> bool) = v700.Start
        let v706 : bool = v705 ()
        let v707 : bool = v706 = false
        if v707 then
            let v708 : string = $"execute_with_options_async / process_start error"
            failwith<unit> v708
        let v709 : (unit -> unit) = v700.BeginErrorReadLine
        v709 ()
        let v710 : (unit -> unit) = v700.BeginOutputReadLine
        v710 ()
        let v711 : (System.Threading.CancellationToken -> US18) = method74()
        let v712 : US18 = US18_1
        let v713 : US18 = v595 |> Option.map v711 |> Option.defaultValue v712 
        let v717 : System.Threading.CancellationToken =
            match v713 with
            | US18_1 -> (* None *)
                let v715 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                v715
            | US18_0(v714) -> (* Some *)
                v714
        let v718 : Async<System.Threading.CancellationToken> option = None
        let v719 : bool = true in let mutable _v718 = v718
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v720 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v720
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v721 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v721
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v722 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v722
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v723 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v723
#endif
        
#if FABLE_COMPILER_PYTHON
        let v724 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v724
#endif
        
#else
        let v725 : Async<System.Threading.CancellationToken> option = None
        let v726 : bool = true in let mutable _v725 = v725
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v727 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v727
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v728 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v728
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v729 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v729
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v730 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v730
#endif
        
#if FABLE_COMPILER_PYTHON
        let v731 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v731
#endif
        
#else
        let v732 : Async<System.Threading.CancellationToken> option = None
        let mutable _v732 = v732
        async {
        let v733 : Async<System.Threading.CancellationToken> = Async.CancellationToken
        let! v733 = v733 
        let v734 : System.Threading.CancellationToken = v733 
        let v735 : System.Threading.CancellationToken = Async.DefaultCancellationToken
        let v736 : (System.Threading.CancellationToken []) = [|v734; v735; v717|]
        let v737 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
        let v738 : System.Threading.CancellationTokenSource = v737 v736
        let v739 : System.Threading.CancellationToken = v738.Token
        return v739 
        }
        |> fun x -> _v732 <- Some x
        let v740 : Async<System.Threading.CancellationToken> = _v732 |> Option.get
        v740
#endif
        |> fun x -> _v725 <- Some x
        let v741 : Async<System.Threading.CancellationToken> = _v725.Value
        v741
#endif
        |> fun x -> _v718 <- Some x
        let v742 : Async<System.Threading.CancellationToken> = _v718.Value
        let! v742 = v742 
        let v743 : System.Threading.CancellationToken = v742 
        let v744 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v743.Register
        let v745 : (unit -> unit) = closure54(v700)
        let v746 : System.Threading.CancellationTokenRegistration = v744 v745
        use v746 = v746 
        let v747 : System.Threading.CancellationTokenRegistration = v746 
        let v748 : Async<int32> option = None
        let v749 : bool = true in let mutable _v748 = v748
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v750 : Async<int32> = null |> unbox<Async<int32>>
        v750
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v751 : Async<int32> = null |> unbox<Async<int32>>
        v751
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v752 : Async<int32> = null |> unbox<Async<int32>>
        v752
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v753 : Async<int32> = null |> unbox<Async<int32>>
        v753
#endif
        
#if FABLE_COMPILER_PYTHON
        let v754 : Async<int32> = null |> unbox<Async<int32>>
        v754
#endif
        
#else
        let v755 : Async<int32> option = None
        let mutable _v755 = v755
        async {
        try
        let v756 : System.Threading.Tasks.Task = v700.WaitForExitAsync v743 
        let v757 : Async<unit> option = None
        let v758 : bool = true in let mutable _v757 = v757
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v759 : Async<unit> = null |> unbox<Async<unit>>
        v759
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v760 : Async<unit> = null |> unbox<Async<unit>>
        v760
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v761 : Async<unit> = null |> unbox<Async<unit>>
        v761
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v762 : Async<unit> = null |> unbox<Async<unit>>
        v762
#endif
        
#if FABLE_COMPILER_PYTHON
        let v763 : Async<unit> = null |> unbox<Async<unit>>
        v763
#endif
        
#else
        let v764 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
        let v765 : Async<unit> = v764 v756
        v765
#endif
        |> fun x -> _v757 <- Some x
        let v766 : Async<unit> = _v757.Value
        do! v766 
        let v767 : int32 = v700.ExitCode
        return v767 
        with ex ->
        let v768 : exn = ex
        let v769 : string option = None
        let v770 : bool = true in let mutable _v769 = v769
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v771 : string = $"%A{v768}"
        v771
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v772 : string = $"%A{v768}"
        v772
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v773 : string = $"%A{v768}"
        v773
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v774 : string = $"%A{v768}"
        v774
#endif
        
#if FABLE_COMPILER_PYTHON
        let v775 : string = $"%A{v768}"
        v775
#endif
        
#else
        let v776 : string = $"{v768.GetType ()}: {v768.Message}"
        v776
#endif
        |> fun x -> _v769 <- Some x
        let v777 : string = _v769.Value
        let v778 : (string -> unit) = v702.Push
        v778 v777
        let v779 : System.Threading.Tasks.TaskCanceledException = v768 |> unbox<System.Threading.Tasks.TaskCanceledException>
        let v780 : US0 = US0_3
        let v781 : (unit -> string) = closure55(v779)
        let v782 : (unit -> string) = method51()
        method3(v780, v781, v782)
        return -2147483648 
        (*
        *)
        }
        |> fun x -> _v755 <- Some x
        let v783 : Async<int32> = _v755 |> Option.get
        v783
#endif
        |> fun x -> _v748 <- Some x
        let v784 : Async<int32> = _v748.Value
        let! v784 = v784 
        let v785 : int32 = v784 
        let v786 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
        let v787 : string seq = v786 v702
        let v788 : string = method75()
        let v789 : (string -> (string seq -> string)) = String.concat
        let v790 : (string seq -> string) = v789 v788
        let v791 : string = v790 v787
        let v792 : US0 = US0_1
        let v793 : (unit -> string) = closure56(v785, v791)
        let v794 : (unit -> string) = method51()
        method3(v792, v793, v794)
        return struct (v785, v791) 
        }
        |> fun x -> _v659 <- Some x
        let v795 : Async<struct (int32 * string)> = _v659 |> Option.get
        v795
#endif
        |> fun x -> _v652 <- Some x
        let v796 : Async<struct (int32 * string)> = _v652.Value
        v796
#endif
        |> fun x -> _v645 <- Some x
        let v797 : Async<struct (int32 * string)> = _v645.Value
        let v798 : struct (int32 * string) option = None
        let v799 : bool = true in let mutable _v798 = v798
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let struct (v800 : int32, v801 : string) = null |> unbox<struct (int32 * string)>
        struct (v800, v801)
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let struct (v802 : int32, v803 : string) = null |> unbox<struct (int32 * string)>
        struct (v802, v803)
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let struct (v804 : int32, v805 : string) = null |> unbox<struct (int32 * string)>
        struct (v804, v805)
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let struct (v806 : int32, v807 : string) = null |> unbox<struct (int32 * string)>
        struct (v806, v807)
#endif
        
#if FABLE_COMPILER_PYTHON
        let struct (v808 : int32, v809 : string) = null |> unbox<struct (int32 * string)>
        struct (v808, v809)
#endif
        
#else
        let v810 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
        let struct (v811 : int32, v812 : string) = v810 v797
        struct (v811, v812)
#endif
        |> fun x -> _v798 <- Some x
        let struct (v813 : int32, v814 : string) = _v798.Value
        struct (v813, v814)
#endif
        |> fun x -> _v600 <- Some x
        let struct (v815 : int32, v816 : string) = _v600.Value
        let v817 : string = "ERROR"
        let v818 : bool = v816.Contains v817
        let v824 : US20 =
            if v818 then
                let v819 : US0 = US0_2
                let v820 : (unit -> string) = closure62()
                let v821 : (unit -> string) = closure63(v816, v815)
                method3(v819, v820, v821)
                US20_1(v815, v816)
            else
                US20_0(v815, v816)
        match v824 with
        | US20_1(v868, v869) -> (* Error *)
            let v870 : (string * string) = v13, v869
            let v871 : Result<string, (string * string)> = Error v870
            US19_0(v871)
        | US20_0(v825, v826) -> (* Ok *)
            let v827 : bool = v825 <> 0
            if v827 then
                let v828 : US0 = US0_2
                let v829 : (unit -> string) = closure59()
                let v830 : (unit -> string) = closure60(v826, v825)
                method3(v828, v829, v830)
                let v831 : (string * string) = v13, v826
                let v832 : Result<string, (string * string)> = Error v831
                US19_0(v832)
            else
                let v834 : bool option = None
                let v835 : bool = true in let mutable _v834 = v834
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v836 : string = method18(v13)
                let v837 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                let v838 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v836 v837
                let v839 : string = "String::from($0)"
                let v840 : std_string_String = Fable.Core.RustInterop.emitRustExpr v838 v839
                let v841 : string = "std::path::PathBuf::from($0)"
                let v842 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v840 v841
                let v843 : string = "$0.exists()"
                let v844 : bool = Fable.Core.RustInterop.emitRustExpr v842 v843
                let v847 : bool =
                    if v844 then
                        let v845 : string = "$0.is_file()"
                        let v846 : bool = Fable.Core.RustInterop.emitRustExpr v842 v845
                        v846
                    else
                        false
                v847
#endif
                
#if FABLE_COMPILER_RUST && WASM
                let v848 : bool = null |> unbox<bool>
                v848
#endif
                
#if FABLE_COMPILER_RUST && CONTRACT
                let v849 : bool = null |> unbox<bool>
                v849
#endif
                
#if FABLE_COMPILER_TYPESCRIPT
                let v850 : IFsExistsSync = Fable.Core.JsInterop.importAll v39
                let v851 : string = "v850.existsSync($0)"
                let v852 : bool = Fable.Core.JsInterop.emitJsExpr v13 v851
                v852
#endif
                
#if FABLE_COMPILER_PYTHON
                let v853 : bool = null |> unbox<bool>
                v853
#endif
                
#else
                let v854 : (string -> bool) = System.IO.File.Exists
                let v855 : bool = v854 v13
                v855
#endif
                |> fun x -> _v834 <- Some x
                let v856 : bool = _v834.Value
                if v856 then
                    let v857 : unit option = None
                    let v858 : bool = true in let mutable _v857 = v857
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v859 : string = method81(v22)
                    let v860 : string = "std::fs::copy(&*v13, &*v859)"
                    let v861 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v860
                    let v862 : string = "$0.unwrap()"
                    let v863 : uint64 = Fable.Core.RustInterop.emitRustExpr v861 v862
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
                    System.IO.File.Copy (v13, v22, true)
                    ()
#endif
                    |> fun x -> _v857 <- Some x
                    _v857.Value
                    ()
                else
                    let v864 : string = $"documents.run / files_fn / {v13} should exist"
                    failwith<unit> v864
                let v865 : Result<string, (string * string)> = Ok v13
                US19_0(v865)
    else
        US19_1
and closure64 () struct (v0 : string, v1 : (string -> US19)) : Result<string, (string * string)> option =
    let v2 : US19 = v1 v0
    match v2 with
    | US19_1 -> (* None *)
        let v5 : Result<string, (string * string)> option = None
        v5
    | US19_0(v3) -> (* Some *)
        let v4 : Result<string, (string * string)> option = Some v3 
        v4
and closure65 () () : string =
    let v0 : string = "documents.run / par_map"
    v0
and closure66 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : int32, v5 : string, v6 : int32, v7 : string, v8 : string, v9 : Vec<Result<string, (string * string)> option>) () : string =
    let v10 : (unit -> string) = closure6()
    let v11 : string = $"file: {v1} / real_path: {v2} / relative_path: {v0} / origin_hash_exit_code: {v4} / origin_hash: {v3} / local_git_hash_exit_code: {v6} / local_git_hash: {v5} / hash1: {v7} / hash2: %A{v8} / files: %A{v9} / {v10 ()}"
    v11
and closure25 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> =
    let v6 : string option = None
    let v7 : bool = true in let mutable _v6 = v6
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = method25(v5)
    let v9 : string = method18(v8)
    let v10 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v11 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "String::from($0)"
    let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "std::path::PathBuf::from($0)"
    let v15 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "$0.exists()"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : bool = v17 = false
    let v222 : string =
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
            let v48 : string option = None
            let v49 : bool = true in let mutable _v48 = v48
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v50 : string = method18(v47)
            let v51 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v52 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v50 v51
            let v53 : string = "String::from($0)"
            let v54 : std_string_String = Fable.Core.RustInterop.emitRustExpr v52 v53
            let v55 : string = "std::path::PathBuf::from($0)"
            let v56 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v54 v55
            let v57 : string = method18(v8)
            let v58 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v59 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v57 v58
            let v60 : string = "String::from($0)"
            let v61 : std_string_String = Fable.Core.RustInterop.emitRustExpr v59 v60
            let v62 : string = "$0.join($1)"
            let v63 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v56, v61) v62
            let v64 : string = "$0.display()"
            let v65 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v63 v64
            let v66 : std_string_String option = None
            let v67 : bool = true in let mutable _v66 = v66
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v68 : string = @$"format!(""{{}}"", $0)"
            let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v68
            v69
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v70 : string = @$"format!(""{{}}"", $0)"
            let v71 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v70
            v71
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v72 : string = @$"format!(""{{}}"", $0)"
            let v73 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v72
            v73
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v74 : std_string_String = null |> unbox<std_string_String>
            v74
#endif
            
#if FABLE_COMPILER_PYTHON
            let v75 : std_string_String = null |> unbox<std_string_String>
            v75
#endif
            
#else
            let v76 : std_string_String = null |> unbox<std_string_String>
            v76
#endif
            |> fun x -> _v66 <- Some x
            let v77 : std_string_String = _v66.Value
            let v78 : string = "fable_library_rust::String_::fromString($0)"
            let v79 : string = Fable.Core.RustInterop.emitRustExpr v77 v78
            v79
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v80 : string = null |> unbox<string>
            v80
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v81 : string = null |> unbox<string>
            v81
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v82 : string = "path"
            let v83 : IPathJoin = Fable.Core.JsInterop.importAll v82
            let v84 : string = method19(v47)
            let v85 : string = method20(v8)
            let v86 : string = "v83.join(v84, v85)"
            let v87 : string = Fable.Core.JsInterop.emitJsExpr () v86
            v87
#endif
            
#if FABLE_COMPILER_PYTHON
            let v88 : string = null |> unbox<string>
            v88
#endif
            
#else
            let v89 : string = System.IO.Path.Combine (v47, v8)
            v89
#endif
            |> fun x -> _v48 <- Some x
            let v90 : string = _v48.Value
            let v91 : bool option = None
            let v92 : bool = true in let mutable _v91 = v91
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v93 : string = "cfg!(windows)"
            let v94 : bool = Fable.Core.RustInterop.emitRustExpr () v93
            v94
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v95 : bool = null |> unbox<bool>
            v95
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v96 : bool = null |> unbox<bool>
            v96
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v97 : bool = null |> unbox<bool>
            v97
#endif
            
#if FABLE_COMPILER_PYTHON
            let v98 : bool = null |> unbox<bool>
            v98
#endif
            
#else
            let v99 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v100 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v101 : bool = v100 v99
            v101
#endif
            |> fun x -> _v91 <- Some x
            let v102 : bool = _v91.Value
            let v103 : bool = v102 = false
            let v127 : string =
                if v103 then
                    v90
                else
                    let v104 : string option = None
                    let v105 : bool = true in let mutable _v104 = v104
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v106 : string = method26()
                    let v107 : string = method27(v90)
                    let v108 : string = method28()
                    let v109 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v110 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v106, v107, v108) v109
                    let v111 : string = "String::from($0)"
                    let v112 : std_string_String = Fable.Core.RustInterop.emitRustExpr v110 v111
                    let v113 : string = "fable_library_rust::String_::fromString($0)"
                    let v114 : string = Fable.Core.RustInterop.emitRustExpr v112 v113
                    v114
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v115 : string = null |> unbox<string>
                    v115
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v116 : string = null |> unbox<string>
                    v116
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v117 : string = null |> unbox<string>
                    v117
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v118 : string = null |> unbox<string>
                    v118
#endif
                    
#else
                    let v119 : string = "^\\\\\\\\\\?\\\\"
                    let v120 : string = ""
                    let v121 : string = System.Text.RegularExpressions.Regex.Replace (v90, v119, v120)
                    v121
#endif
                    |> fun x -> _v104 <- Some x
                    let v122 : string = _v104.Value
                    let v123 : string = $"{v122.[0] |> string |> _.ToLower()}{v122.[1..]}"
                    let v124 : string = "\\"
                    let v125 : string = "/"
                    let v126 : string = v123.Replace (v124, v125)
                    v126
            let v128 : string = "/"
            let v129 : (string []) = v127.Split v128
            let v130 : (string []) = [||]
            let v131 : int32 = v129.Length
            let v132 : Mut4 = {l0 = 0; l1 = 0; l2 = v130} : Mut4
            while method29(v131, v132) do
                let v134 : int32 = v132.l0
                let v135 : int32 =  -v134
                let v136 : int32 = v135 + v131
                let v137 : int32 = v136 - 1
                let struct (v138 : int32, v139 : (string [])) = v132.l1, v132.l2
                let v140 : string = v129.[int v137]
                let v141 : bool = ".." = v140
                let struct (v180 : int32, v181 : (string [])) =
                    if v141 then
                        let v142 : int32 = v138 + 1
                        struct (v142, v139)
                    else
                        let v143 : bool = 0 = v138
                        if v143 then
                            let v144 : string = ":"
                            let v145 : bool = v140.EndsWith v144
                            if v145 then
                                let v146 : string = $"{v47.[0]}:"
                                let v147 : (string []) = [|v146|]
                                let v148 : int32 = v147.Length
                                let v149 : int32 = v139.Length
                                let v150 : int32 = v148 + v149
                                let v151 : (string []) = Array.zeroCreate<string> (v150)
                                let v152 : Mut5 = {l0 = 0} : Mut5
                                while method30(v150, v152) do
                                    let v154 : int32 = v152.l0
                                    let v155 : bool = v154 < v148
                                    let v159 : string =
                                        if v155 then
                                            let v156 : string = v147.[int v154]
                                            v156
                                        else
                                            let v157 : int32 = v154 - v148
                                            let v158 : string = v139.[int v157]
                                            v158
                                    v151.[int v154] <- v159
                                    let v160 : int32 = v154 + 1
                                    v152.l0 <- v160
                                    ()
                                struct (0, v151)
                            else
                                let v161 : (string []) = [|v140|]
                                let v162 : int32 = v161.Length
                                let v163 : int32 = v139.Length
                                let v164 : int32 = v162 + v163
                                let v165 : (string []) = Array.zeroCreate<string> (v164)
                                let v166 : Mut5 = {l0 = 0} : Mut5
                                while method30(v164, v166) do
                                    let v168 : int32 = v166.l0
                                    let v169 : bool = v168 < v162
                                    let v173 : string =
                                        if v169 then
                                            let v170 : string = v161.[int v168]
                                            v170
                                        else
                                            let v171 : int32 = v168 - v162
                                            let v172 : string = v139.[int v171]
                                            v172
                                    v165.[int v168] <- v173
                                    let v174 : int32 = v168 + 1
                                    v166.l0 <- v174
                                    ()
                                struct (0, v165)
                        else
                            let v177 : int32 = v138 - 1
                            struct (v177, v139)
                let v182 : int32 = v134 + 1
                v132.l0 <- v182
                v132.l1 <- v180
                v132.l2 <- v181
                ()
            let struct (v183 : int32, v184 : (string [])) = v132.l1, v132.l2
            let v185 : string seq = seq { for i = 0 to v184.Length - 1 do yield v184.[i] }
            let v186 : char option = None
            let v187 : bool = true in let mutable _v186 = v186
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v188 : string = "std::path::MAIN_SEPARATOR"
            let v189 : char = Fable.Core.RustInterop.emitRustExpr () v188
            v189
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v190 : char = null |> unbox<char>
            v190
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v191 : char = null |> unbox<char>
            v191
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v192 : char = null |> unbox<char>
            v192
#endif
            
#if FABLE_COMPILER_PYTHON
            let v193 : char = null |> unbox<char>
            v193
#endif
            
#else
            let v194 : char = System.IO.Path.DirectorySeparatorChar
            v194
#endif
            |> fun x -> _v186 <- Some x
            let v195 : char = _v186.Value
            let v196 : (char -> string) = _.ToString()
            let v197 : string = v196 v195
            let v198 : string = method31(v197)
            let v199 : (string -> (string seq -> string)) = String.concat
            let v200 : (string seq -> string) = v199 v198
            v200 v185
        else
            let v202 : string = "std::fs::canonicalize(&*$0)"
            let v203 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v8 v202
            let v204 : string = "$0.unwrap()"
            let v205 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v203 v204
            let v206 : string = "$0.display()"
            let v207 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v205 v206
            let v208 : std_string_String option = None
            let v209 : bool = true in let mutable _v208 = v208
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v210 : string = @$"format!(""{{}}"", $0)"
            let v211 : std_string_String = Fable.Core.RustInterop.emitRustExpr v207 v210
            v211
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v212 : string = @$"format!(""{{}}"", $0)"
            let v213 : std_string_String = Fable.Core.RustInterop.emitRustExpr v207 v212
            v213
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v214 : string = @$"format!(""{{}}"", $0)"
            let v215 : std_string_String = Fable.Core.RustInterop.emitRustExpr v207 v214
            v215
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v216 : std_string_String = null |> unbox<std_string_String>
            v216
#endif
            
#if FABLE_COMPILER_PYTHON
            let v217 : std_string_String = null |> unbox<std_string_String>
            v217
#endif
            
#else
            let v218 : std_string_String = null |> unbox<std_string_String>
            v218
#endif
            |> fun x -> _v208 <- Some x
            let v219 : std_string_String = _v208.Value
            let v220 : string = "fable_library_rust::String_::fromString($0)"
            let v221 : string = Fable.Core.RustInterop.emitRustExpr v219 v220
            v221
    v222
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v223 : string = null |> unbox<string>
    v223
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v224 : string = null |> unbox<string>
    v224
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v225 : string = null |> unbox<string>
    v225
#endif
    
#if FABLE_COMPILER_PYTHON
    let v226 : string = null |> unbox<string>
    v226
#endif
    
#else
    let v227 : string = method32(v5)
    let v228 : (string -> string) = System.IO.Path.GetFullPath
    let v229 : string = v228 v227
    v229
#endif
    |> fun x -> _v6 <- Some x
    let v230 : string = _v6.Value
    let v231 : string = method18(v230)
    let v232 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v233 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v231 v232
    let v234 : string = "String::from($0)"
    let v235 : std_string_String = Fable.Core.RustInterop.emitRustExpr v233 v234
    let v236 : string = "std::path::PathBuf::from($0)"
    let v237 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v235 v236
    let v238 : string = "$0.display()"
    let v239 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v237 v238
    let v240 : std_string_String option = None
    let v241 : bool = true in let mutable _v240 = v240
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v242 : string = @$"format!(""{{}}"", $0)"
    let v243 : std_string_String = Fable.Core.RustInterop.emitRustExpr v239 v242
    v243
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v244 : string = @$"format!(""{{}}"", $0)"
    let v245 : std_string_String = Fable.Core.RustInterop.emitRustExpr v239 v244
    v245
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v246 : string = @$"format!(""{{}}"", $0)"
    let v247 : std_string_String = Fable.Core.RustInterop.emitRustExpr v239 v246
    v247
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v248 : std_string_String = null |> unbox<std_string_String>
    v248
#endif
    
#if FABLE_COMPILER_PYTHON
    let v249 : std_string_String = null |> unbox<std_string_String>
    v249
#endif
    
#else
    let v250 : std_string_String = null |> unbox<std_string_String>
    v250
#endif
    |> fun x -> _v240 <- Some x
    let v251 : std_string_String = _v240.Value
    let v252 : string = "fable_library_rust::String_::fromString($0)"
    let v253 : string = Fable.Core.RustInterop.emitRustExpr v251 v252
    let v254 : string = ""
    let v255 : string = v253.Replace (v3, v254)
    let v256 : string = "\\"
    let v257 : string = "/"
    let v258 : string = v255.Replace (v256, v257)
    let v259 : string = $".{v258}"
    let v260 : bool option = None
    let v261 : bool = true in let mutable _v260 = v260
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v262 : string = "cfg!(windows)"
    let v263 : bool = Fable.Core.RustInterop.emitRustExpr () v262
    v263
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v264 : bool = null |> unbox<bool>
    v264
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v265 : bool = null |> unbox<bool>
    v265
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v266 : bool = null |> unbox<bool>
    v266
#endif
    
#if FABLE_COMPILER_PYTHON
    let v267 : bool = null |> unbox<bool>
    v267
#endif
    
#else
    let v268 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v269 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v270 : bool = v269 v268
    v270
#endif
    |> fun x -> _v260 <- Some x
    let v271 : bool = _v260.Value
    let v272 : bool = v271 = false
    let v293 : string =
        if v272 then
            v230
        else
            let v273 : string option = None
            let v274 : bool = true in let mutable _v273 = v273
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v275 : string = method26()
            let v276 : string = method27(v230)
            let v277 : string = method28()
            let v278 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v279 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v275, v276, v277) v278
            let v280 : string = "String::from($0)"
            let v281 : std_string_String = Fable.Core.RustInterop.emitRustExpr v279 v280
            let v282 : string = "fable_library_rust::String_::fromString($0)"
            let v283 : string = Fable.Core.RustInterop.emitRustExpr v281 v282
            v283
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v284 : string = null |> unbox<string>
            v284
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v285 : string = null |> unbox<string>
            v285
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v286 : string = null |> unbox<string>
            v286
#endif
            
#if FABLE_COMPILER_PYTHON
            let v287 : string = null |> unbox<string>
            v287
#endif
            
#else
            let v288 : string = "^\\\\\\\\\\?\\\\"
            let v289 : string = System.Text.RegularExpressions.Regex.Replace (v230, v288, v254)
            v289
#endif
            |> fun x -> _v273 <- Some x
            let v290 : string = _v273.Value
            let v291 : string = $"{v290.[0] |> string |> _.ToLower()}{v290.[1..]}"
            let v292 : string = v291.Replace (v256, v257)
            v292
    let v294 : string option = None
    let v295 : bool = true in let mutable _v294 = v294
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v296 : string = method18(v2)
    let v297 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v298 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v296 v297
    let v299 : string = "String::from($0)"
    let v300 : std_string_String = Fable.Core.RustInterop.emitRustExpr v298 v299
    let v301 : string = "std::path::PathBuf::from($0)"
    let v302 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v300 v301
    let v303 : string = method18(v259)
    let v304 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v305 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v303 v304
    let v306 : string = "String::from($0)"
    let v307 : std_string_String = Fable.Core.RustInterop.emitRustExpr v305 v306
    let v308 : string = "$0.join($1)"
    let v309 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v302, v307) v308
    let v310 : string = "$0.display()"
    let v311 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v309 v310
    let v312 : std_string_String option = None
    let v313 : bool = true in let mutable _v312 = v312
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v314 : string = @$"format!(""{{}}"", $0)"
    let v315 : std_string_String = Fable.Core.RustInterop.emitRustExpr v311 v314
    v315
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v316 : string = @$"format!(""{{}}"", $0)"
    let v317 : std_string_String = Fable.Core.RustInterop.emitRustExpr v311 v316
    v317
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v318 : string = @$"format!(""{{}}"", $0)"
    let v319 : std_string_String = Fable.Core.RustInterop.emitRustExpr v311 v318
    v319
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v320 : std_string_String = null |> unbox<std_string_String>
    v320
#endif
    
#if FABLE_COMPILER_PYTHON
    let v321 : std_string_String = null |> unbox<std_string_String>
    v321
#endif
    
#else
    let v322 : std_string_String = null |> unbox<std_string_String>
    v322
#endif
    |> fun x -> _v312 <- Some x
    let v323 : std_string_String = _v312.Value
    let v324 : string = "fable_library_rust::String_::fromString($0)"
    let v325 : string = Fable.Core.RustInterop.emitRustExpr v323 v324
    v325
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v326 : string = null |> unbox<string>
    v326
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v327 : string = null |> unbox<string>
    v327
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v328 : string = "path"
    let v329 : IPathJoin = Fable.Core.JsInterop.importAll v328
    let v330 : string = method19(v2)
    let v331 : string = method20(v259)
    let v332 : string = "v329.join(v330, v331)"
    let v333 : string = Fable.Core.JsInterop.emitJsExpr () v332
    v333
#endif
    
#if FABLE_COMPILER_PYTHON
    let v334 : string = null |> unbox<string>
    v334
#endif
    
#else
    let v335 : string = System.IO.Path.Combine (v2, v259)
    v335
#endif
    |> fun x -> _v294 <- Some x
    let v336 : string = _v294.Value
    let v337 : bool option = None
    let v338 : bool = true in let mutable _v337 = v337
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v339 : string = "cfg!(windows)"
    let v340 : bool = Fable.Core.RustInterop.emitRustExpr () v339
    v340
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v341 : bool = null |> unbox<bool>
    v341
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v342 : bool = null |> unbox<bool>
    v342
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v343 : bool = null |> unbox<bool>
    v343
#endif
    
#if FABLE_COMPILER_PYTHON
    let v344 : bool = null |> unbox<bool>
    v344
#endif
    
#else
    let v345 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v346 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v347 : bool = v346 v345
    v347
#endif
    |> fun x -> _v337 <- Some x
    let v348 : bool = _v337.Value
    let v349 : bool = v348 = false
    let v370 : string =
        if v349 then
            v336
        else
            let v350 : string option = None
            let v351 : bool = true in let mutable _v350 = v350
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v352 : string = method26()
            let v353 : string = method27(v336)
            let v354 : string = method28()
            let v355 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v356 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v352, v353, v354) v355
            let v357 : string = "String::from($0)"
            let v358 : std_string_String = Fable.Core.RustInterop.emitRustExpr v356 v357
            let v359 : string = "fable_library_rust::String_::fromString($0)"
            let v360 : string = Fable.Core.RustInterop.emitRustExpr v358 v359
            v360
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v361 : string = null |> unbox<string>
            v361
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v362 : string = null |> unbox<string>
            v362
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v363 : string = null |> unbox<string>
            v363
#endif
            
#if FABLE_COMPILER_PYTHON
            let v364 : string = null |> unbox<string>
            v364
#endif
            
#else
            let v365 : string = "^\\\\\\\\\\?\\\\"
            let v366 : string = System.Text.RegularExpressions.Regex.Replace (v336, v365, v254)
            v366
#endif
            |> fun x -> _v350 <- Some x
            let v367 : string = _v350.Value
            let v368 : string = $"{v367.[0] |> string |> _.ToLower()}{v367.[1..]}"
            let v369 : string = v368.Replace (v256, v257)
            v369
    let v371 : string option = None
    let v372 : System.Threading.CancellationToken option = None
    let v373 : (struct (string * string) []) = [||]
    let v374 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v375 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v376 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v370}\""
    let v377 : string option = Some v2 
    let v378 : struct (int32 * string) option = None
    let v379 : bool = true in let mutable _v378 = v378
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v380 : string = method42(v372, v376, v373, v374, v375, v377)
    let struct (v381 : string, v382 : string) = method43()
    let v383 : int32 = v380.Length
    let v384 : (char []) = Array.zeroCreate<char> (v383)
    let v385 : Mut5 = {l0 = 0} : Mut5
    while method30(v383, v385) do
        let v387 : int32 = v385.l0
        let v388 : char = v380.[int v387]
        v384.[int v387] <- v388
        let v389 : int32 = v387 + 1
        v385.l0 <- v389
        ()
    let v390 : ((char []) -> char list) = Array.toList
    let v391 : char list = v390 v384
    let v392 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v393 : (char -> (UH0 -> UH0)) = method44()
    let v394 : (char list -> (UH0 -> UH0)) = v392 v393
    let v395 : (UH0 -> UH0) = v394 v391
    let v396 : UH0 = UH0_0
    let v397 : UH0 = v395 v396
    let v398 : US8 = US8_0
    let struct (v399 : string, v400 : string) = method45(v382, v381, v397, v398)
    let v401 : (string []) = method46(v400)
    let v402 : string = "$0.to_vec()"
    let v403 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v401 v402
    let v404 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v405 : (string -> std_string_String) = closure28()
    let v406 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v403, v405) v404
    let v407 : US0 = US0_1
    let v408 : (unit -> string) = closure29(v372, v376, v373, v374, v375, v377, v399, v406)
    let v409 : (unit -> string) = method51()
    method3(v407, v408, v409)
    let v410 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method52(v372, v376, v373, v374, v375, v377, v399, v406)
    let v411 : string = "futures_lite::future::block_on($0)"
    let v412 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v410 v411
    let (a, b) = v412
    let v413 : int32 = a
    let v414 : string = b
    struct (v413, v414)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v415 : int32, v416 : string) = null |> unbox<struct (int32 * string)>
    struct (v415, v416)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v417 : int32, v418 : string) = null |> unbox<struct (int32 * string)>
    struct (v417, v418)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v419 : int32, v420 : string) = null |> unbox<struct (int32 * string)>
    struct (v419, v420)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v421 : int32, v422 : string) = null |> unbox<struct (int32 * string)>
    struct (v421, v422)
#endif
    
#else
    let v423 : Async<struct (int32 * string)> option = None
    let v424 : bool = true in let mutable _v423 = v423
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v425 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v425
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v426 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v426
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v427 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v427
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v428 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v428
#endif
    
#if FABLE_COMPILER_PYTHON
    let v429 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v429
#endif
    
#else
    let v430 : Async<struct (int32 * string)> option = None
    let v431 : bool = true in let mutable _v430 = v430
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v432 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v432
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v433 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v433
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v434 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v434
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v435 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v435
#endif
    
#if FABLE_COMPILER_PYTHON
    let v436 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v436
#endif
    
#else
    let v437 : Async<struct (int32 * string)> option = None
    let mutable _v437 = v437
    async {
    let struct (v438 : string, v439 : string) = method43()
    let v440 : int32 = v376.Length
    let v441 : (char []) = Array.zeroCreate<char> (v440)
    let v442 : Mut5 = {l0 = 0} : Mut5
    while method30(v440, v442) do
        let v444 : int32 = v442.l0
        let v445 : char = v376.[int v444]
        v441.[int v444] <- v445
        let v446 : int32 = v444 + 1
        v442.l0 <- v446
        ()
    let v447 : ((char []) -> char list) = Array.toList
    let v448 : char list = v447 v441
    let v449 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v450 : (char -> (UH0 -> UH0)) = method44()
    let v451 : (char list -> (UH0 -> UH0)) = v449 v450
    let v452 : (UH0 -> UH0) = v451 v448
    let v453 : UH0 = UH0_0
    let v454 : UH0 = v452 v453
    let v455 : US8 = US8_0
    let struct (v456 : string, v457 : string) = method45(v439, v438, v454, v455)
    let v458 : (string -> US4) = method22()
    let v459 : US4 = US4_1
    let v460 : US4 = v377 |> Option.map v458 |> Option.defaultValue v459 
    let v463 : string =
        match v460 with
        | US4_1 -> (* None *)
            v254
        | US4_0(v461) -> (* Some *)
            v461
    let v464 : US0 = US0_1
    let v465 : (unit -> string) = closure48(v372, v376, v373, v374, v375, v377)
    let v466 : (unit -> string) = method51()
    method3(v464, v465, v466)
    let v467 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v468 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v457, StandardOutputEncoding = v467, WorkingDirectory = v463, FileName = v456, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v469 : int32 = v373.Length
    let v470 : Mut5 = {l0 = 0} : Mut5
    while method30(v469, v470) do
        let v472 : int32 = v470.l0
        let struct (v473 : string, v474 : string) = v373.[int v472]
        v468.EnvironmentVariables.[v473] <- v474 
        let v475 : int32 = v472 + 1
        v470.l0 <- v475
        ()
    let v476 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v468)
    use v476 = v476 
    let v477 : System.Diagnostics.Process = v476 
    let v478 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v479 : System.Collections.Concurrent.ConcurrentStack<string> = v478 ()
    let v480 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v372, v376, v373, v374, v375, v377, v477, v479)
    v477.OutputDataReceived.Add v480 
    let v481 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v372, v376, v373, v374, v375, v377, v477, v479)
    v477.ErrorDataReceived.Add v481 
    let v482 : (unit -> bool) = v477.Start
    let v483 : bool = v482 ()
    let v484 : bool = v483 = false
    if v484 then
        let v485 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v485
    let v486 : (unit -> unit) = v477.BeginErrorReadLine
    v486 ()
    let v487 : (unit -> unit) = v477.BeginOutputReadLine
    v487 ()
    let v488 : (System.Threading.CancellationToken -> US18) = method74()
    let v489 : US18 = US18_1
    let v490 : US18 = v372 |> Option.map v488 |> Option.defaultValue v489 
    let v494 : System.Threading.CancellationToken =
        match v490 with
        | US18_1 -> (* None *)
            let v492 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v492
        | US18_0(v491) -> (* Some *)
            v491
    let v495 : Async<System.Threading.CancellationToken> option = None
    let v496 : bool = true in let mutable _v495 = v495
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v497 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v497
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v498 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v498
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v499 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v499
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v500 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v500
#endif
    
#if FABLE_COMPILER_PYTHON
    let v501 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v501
#endif
    
#else
    let v502 : Async<System.Threading.CancellationToken> option = None
    let v503 : bool = true in let mutable _v502 = v502
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v504 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v504
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v505 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v505
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v506 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v506
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v507 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v507
#endif
    
#if FABLE_COMPILER_PYTHON
    let v508 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v508
#endif
    
#else
    let v509 : Async<System.Threading.CancellationToken> option = None
    let mutable _v509 = v509
    async {
    let v510 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v510 = v510 
    let v511 : System.Threading.CancellationToken = v510 
    let v512 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v513 : (System.Threading.CancellationToken []) = [|v511; v512; v494|]
    let v514 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v515 : System.Threading.CancellationTokenSource = v514 v513
    let v516 : System.Threading.CancellationToken = v515.Token
    return v516 
    }
    |> fun x -> _v509 <- Some x
    let v517 : Async<System.Threading.CancellationToken> = _v509 |> Option.get
    v517
#endif
    |> fun x -> _v502 <- Some x
    let v518 : Async<System.Threading.CancellationToken> = _v502.Value
    v518
#endif
    |> fun x -> _v495 <- Some x
    let v519 : Async<System.Threading.CancellationToken> = _v495.Value
    let! v519 = v519 
    let v520 : System.Threading.CancellationToken = v519 
    let v521 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v520.Register
    let v522 : (unit -> unit) = closure54(v477)
    let v523 : System.Threading.CancellationTokenRegistration = v521 v522
    use v523 = v523 
    let v524 : System.Threading.CancellationTokenRegistration = v523 
    let v525 : Async<int32> option = None
    let v526 : bool = true in let mutable _v525 = v525
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v527 : Async<int32> = null |> unbox<Async<int32>>
    v527
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v528 : Async<int32> = null |> unbox<Async<int32>>
    v528
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v529 : Async<int32> = null |> unbox<Async<int32>>
    v529
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v530 : Async<int32> = null |> unbox<Async<int32>>
    v530
#endif
    
#if FABLE_COMPILER_PYTHON
    let v531 : Async<int32> = null |> unbox<Async<int32>>
    v531
#endif
    
#else
    let v532 : Async<int32> option = None
    let mutable _v532 = v532
    async {
    try
    let v533 : System.Threading.Tasks.Task = v477.WaitForExitAsync v520 
    let v534 : Async<unit> option = None
    let v535 : bool = true in let mutable _v534 = v534
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v536 : Async<unit> = null |> unbox<Async<unit>>
    v536
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v537 : Async<unit> = null |> unbox<Async<unit>>
    v537
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v538 : Async<unit> = null |> unbox<Async<unit>>
    v538
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v539 : Async<unit> = null |> unbox<Async<unit>>
    v539
#endif
    
#if FABLE_COMPILER_PYTHON
    let v540 : Async<unit> = null |> unbox<Async<unit>>
    v540
#endif
    
#else
    let v541 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v542 : Async<unit> = v541 v533
    v542
#endif
    |> fun x -> _v534 <- Some x
    let v543 : Async<unit> = _v534.Value
    do! v543 
    let v544 : int32 = v477.ExitCode
    return v544 
    with ex ->
    let v545 : exn = ex
    let v546 : string option = None
    let v547 : bool = true in let mutable _v546 = v546
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v548 : string = $"%A{v545}"
    v548
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v549 : string = $"%A{v545}"
    v549
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v550 : string = $"%A{v545}"
    v550
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v551 : string = $"%A{v545}"
    v551
#endif
    
#if FABLE_COMPILER_PYTHON
    let v552 : string = $"%A{v545}"
    v552
#endif
    
#else
    let v553 : string = $"{v545.GetType ()}: {v545.Message}"
    v553
#endif
    |> fun x -> _v546 <- Some x
    let v554 : string = _v546.Value
    let v555 : (string -> unit) = v479.Push
    v555 v554
    let v556 : System.Threading.Tasks.TaskCanceledException = v545 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v557 : US0 = US0_3
    let v558 : (unit -> string) = closure55(v556)
    let v559 : (unit -> string) = method51()
    method3(v557, v558, v559)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v532 <- Some x
    let v560 : Async<int32> = _v532 |> Option.get
    v560
#endif
    |> fun x -> _v525 <- Some x
    let v561 : Async<int32> = _v525.Value
    let! v561 = v561 
    let v562 : int32 = v561 
    let v563 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v564 : string seq = v563 v479
    let v565 : string = method75()
    let v566 : (string -> (string seq -> string)) = String.concat
    let v567 : (string seq -> string) = v566 v565
    let v568 : string = v567 v564
    let v569 : US0 = US0_1
    let v570 : (unit -> string) = closure56(v562, v568)
    let v571 : (unit -> string) = method51()
    method3(v569, v570, v571)
    return struct (v562, v568) 
    }
    |> fun x -> _v437 <- Some x
    let v572 : Async<struct (int32 * string)> = _v437 |> Option.get
    v572
#endif
    |> fun x -> _v430 <- Some x
    let v573 : Async<struct (int32 * string)> = _v430.Value
    v573
#endif
    |> fun x -> _v423 <- Some x
    let v574 : Async<struct (int32 * string)> = _v423.Value
    let v575 : struct (int32 * string) option = None
    let v576 : bool = true in let mutable _v575 = v575
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v577 : int32, v578 : string) = null |> unbox<struct (int32 * string)>
    struct (v577, v578)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v579 : int32, v580 : string) = null |> unbox<struct (int32 * string)>
    struct (v579, v580)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v581 : int32, v582 : string) = null |> unbox<struct (int32 * string)>
    struct (v581, v582)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v583 : int32, v584 : string) = null |> unbox<struct (int32 * string)>
    struct (v583, v584)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v585 : int32, v586 : string) = null |> unbox<struct (int32 * string)>
    struct (v585, v586)
#endif
    
#else
    let v587 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v588 : int32, v589 : string) = v587 v574
    struct (v588, v589)
#endif
    |> fun x -> _v575 <- Some x
    let struct (v590 : int32, v591 : string) = _v575.Value
    struct (v590, v591)
#endif
    |> fun x -> _v378 <- Some x
    let struct (v592 : int32, v593 : string) = _v378.Value
    let v594 : string option = None
    let v595 : bool = true in let mutable _v594 = v594
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v596 : string = method18(v3)
    let v597 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v596 v597
    let v599 : string = "String::from($0)"
    let v600 : std_string_String = Fable.Core.RustInterop.emitRustExpr v598 v599
    let v601 : string = "std::path::PathBuf::from($0)"
    let v602 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v600 v601
    let v603 : string = method18(v259)
    let v604 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v605 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v603 v604
    let v606 : string = "String::from($0)"
    let v607 : std_string_String = Fable.Core.RustInterop.emitRustExpr v605 v606
    let v608 : string = "$0.join($1)"
    let v609 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v602, v607) v608
    let v610 : string = "$0.display()"
    let v611 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v609 v610
    let v612 : std_string_String option = None
    let v613 : bool = true in let mutable _v612 = v612
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v614 : string = @$"format!(""{{}}"", $0)"
    let v615 : std_string_String = Fable.Core.RustInterop.emitRustExpr v611 v614
    v615
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v616 : string = @$"format!(""{{}}"", $0)"
    let v617 : std_string_String = Fable.Core.RustInterop.emitRustExpr v611 v616
    v617
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v618 : string = @$"format!(""{{}}"", $0)"
    let v619 : std_string_String = Fable.Core.RustInterop.emitRustExpr v611 v618
    v619
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v620 : std_string_String = null |> unbox<std_string_String>
    v620
#endif
    
#if FABLE_COMPILER_PYTHON
    let v621 : std_string_String = null |> unbox<std_string_String>
    v621
#endif
    
#else
    let v622 : std_string_String = null |> unbox<std_string_String>
    v622
#endif
    |> fun x -> _v612 <- Some x
    let v623 : std_string_String = _v612.Value
    let v624 : string = "fable_library_rust::String_::fromString($0)"
    let v625 : string = Fable.Core.RustInterop.emitRustExpr v623 v624
    v625
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v626 : string = null |> unbox<string>
    v626
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v627 : string = null |> unbox<string>
    v627
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v628 : IPathJoin = Fable.Core.JsInterop.importAll v328
    let v629 : string = method19(v3)
    let v630 : string = method20(v259)
    let v631 : string = "v628.join(v629, v630)"
    let v632 : string = Fable.Core.JsInterop.emitJsExpr () v631
    v632
#endif
    
#if FABLE_COMPILER_PYTHON
    let v633 : string = null |> unbox<string>
    v633
#endif
    
#else
    let v634 : string = System.IO.Path.Combine (v3, v259)
    v634
#endif
    |> fun x -> _v594 <- Some x
    let v635 : string = _v594.Value
    let v636 : bool option = None
    let v637 : bool = true in let mutable _v636 = v636
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v638 : string = "cfg!(windows)"
    let v639 : bool = Fable.Core.RustInterop.emitRustExpr () v638
    v639
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v640 : bool = null |> unbox<bool>
    v640
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v641 : bool = null |> unbox<bool>
    v641
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v642 : bool = null |> unbox<bool>
    v642
#endif
    
#if FABLE_COMPILER_PYTHON
    let v643 : bool = null |> unbox<bool>
    v643
#endif
    
#else
    let v644 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v645 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v646 : bool = v645 v644
    v646
#endif
    |> fun x -> _v636 <- Some x
    let v647 : bool = _v636.Value
    let v648 : bool = v647 = false
    let v669 : string =
        if v648 then
            v635
        else
            let v649 : string option = None
            let v650 : bool = true in let mutable _v649 = v649
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v651 : string = method26()
            let v652 : string = method27(v635)
            let v653 : string = method28()
            let v654 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v655 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v651, v652, v653) v654
            let v656 : string = "String::from($0)"
            let v657 : std_string_String = Fable.Core.RustInterop.emitRustExpr v655 v656
            let v658 : string = "fable_library_rust::String_::fromString($0)"
            let v659 : string = Fable.Core.RustInterop.emitRustExpr v657 v658
            v659
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v660 : string = null |> unbox<string>
            v660
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v661 : string = null |> unbox<string>
            v661
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v662 : string = null |> unbox<string>
            v662
#endif
            
#if FABLE_COMPILER_PYTHON
            let v663 : string = null |> unbox<string>
            v663
#endif
            
#else
            let v664 : string = "^\\\\\\\\\\?\\\\"
            let v665 : string = System.Text.RegularExpressions.Regex.Replace (v635, v664, v254)
            v665
#endif
            |> fun x -> _v649 <- Some x
            let v666 : string = _v649.Value
            let v667 : string = $"{v666.[0] |> string |> _.ToLower()}{v666.[1..]}"
            let v668 : string = v667.Replace (v256, v257)
            v668
    let v670 : string option = None
    let v671 : System.Threading.CancellationToken option = None
    let v672 : (struct (string * string) []) = [||]
    let v673 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v674 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v675 : string = $"git hash-object \"{v669}\""
    let v676 : string option = Some v3 
    let v677 : struct (int32 * string) option = None
    let v678 : bool = true in let mutable _v677 = v677
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v679 : string = method42(v671, v675, v672, v673, v674, v676)
    let struct (v680 : string, v681 : string) = method43()
    let v682 : int32 = v679.Length
    let v683 : (char []) = Array.zeroCreate<char> (v682)
    let v684 : Mut5 = {l0 = 0} : Mut5
    while method30(v682, v684) do
        let v686 : int32 = v684.l0
        let v687 : char = v679.[int v686]
        v683.[int v686] <- v687
        let v688 : int32 = v686 + 1
        v684.l0 <- v688
        ()
    let v689 : ((char []) -> char list) = Array.toList
    let v690 : char list = v689 v683
    let v691 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v692 : (char -> (UH0 -> UH0)) = method44()
    let v693 : (char list -> (UH0 -> UH0)) = v691 v692
    let v694 : (UH0 -> UH0) = v693 v690
    let v695 : UH0 = UH0_0
    let v696 : UH0 = v694 v695
    let v697 : US8 = US8_0
    let struct (v698 : string, v699 : string) = method45(v681, v680, v696, v697)
    let v700 : (string []) = method46(v699)
    let v701 : string = "$0.to_vec()"
    let v702 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v700 v701
    let v703 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v704 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v702, v405) v703
    let v705 : US0 = US0_1
    let v706 : (unit -> string) = closure29(v671, v675, v672, v673, v674, v676, v698, v704)
    let v707 : (unit -> string) = method51()
    method3(v705, v706, v707)
    let v708 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method52(v671, v675, v672, v673, v674, v676, v698, v704)
    let v709 : string = "futures_lite::future::block_on($0)"
    let v710 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v708 v709
    let (a, b) = v710
    let v711 : int32 = a
    let v712 : string = b
    struct (v711, v712)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v713 : int32, v714 : string) = null |> unbox<struct (int32 * string)>
    struct (v713, v714)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v715 : int32, v716 : string) = null |> unbox<struct (int32 * string)>
    struct (v715, v716)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v717 : int32, v718 : string) = null |> unbox<struct (int32 * string)>
    struct (v717, v718)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v719 : int32, v720 : string) = null |> unbox<struct (int32 * string)>
    struct (v719, v720)
#endif
    
#else
    let v721 : Async<struct (int32 * string)> option = None
    let v722 : bool = true in let mutable _v721 = v721
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v723 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v723
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v724 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v724
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v725 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v725
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v726 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v726
#endif
    
#if FABLE_COMPILER_PYTHON
    let v727 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v727
#endif
    
#else
    let v728 : Async<struct (int32 * string)> option = None
    let v729 : bool = true in let mutable _v728 = v728
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v730 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v730
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v731 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v731
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v732 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v732
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v733 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v733
#endif
    
#if FABLE_COMPILER_PYTHON
    let v734 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v734
#endif
    
#else
    let v735 : Async<struct (int32 * string)> option = None
    let mutable _v735 = v735
    async {
    let struct (v736 : string, v737 : string) = method43()
    let v738 : int32 = v675.Length
    let v739 : (char []) = Array.zeroCreate<char> (v738)
    let v740 : Mut5 = {l0 = 0} : Mut5
    while method30(v738, v740) do
        let v742 : int32 = v740.l0
        let v743 : char = v675.[int v742]
        v739.[int v742] <- v743
        let v744 : int32 = v742 + 1
        v740.l0 <- v744
        ()
    let v745 : ((char []) -> char list) = Array.toList
    let v746 : char list = v745 v739
    let v747 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v748 : (char -> (UH0 -> UH0)) = method44()
    let v749 : (char list -> (UH0 -> UH0)) = v747 v748
    let v750 : (UH0 -> UH0) = v749 v746
    let v751 : UH0 = UH0_0
    let v752 : UH0 = v750 v751
    let v753 : US8 = US8_0
    let struct (v754 : string, v755 : string) = method45(v737, v736, v752, v753)
    let v756 : (string -> US4) = method22()
    let v757 : US4 = US4_1
    let v758 : US4 = v676 |> Option.map v756 |> Option.defaultValue v757 
    let v761 : string =
        match v758 with
        | US4_1 -> (* None *)
            v254
        | US4_0(v759) -> (* Some *)
            v759
    let v762 : US0 = US0_1
    let v763 : (unit -> string) = closure48(v671, v675, v672, v673, v674, v676)
    let v764 : (unit -> string) = method51()
    method3(v762, v763, v764)
    let v765 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v766 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v755, StandardOutputEncoding = v765, WorkingDirectory = v761, FileName = v754, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v767 : int32 = v672.Length
    let v768 : Mut5 = {l0 = 0} : Mut5
    while method30(v767, v768) do
        let v770 : int32 = v768.l0
        let struct (v771 : string, v772 : string) = v672.[int v770]
        v766.EnvironmentVariables.[v771] <- v772 
        let v773 : int32 = v770 + 1
        v768.l0 <- v773
        ()
    let v774 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v766)
    use v774 = v774 
    let v775 : System.Diagnostics.Process = v774 
    let v776 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v777 : System.Collections.Concurrent.ConcurrentStack<string> = v776 ()
    let v778 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v671, v675, v672, v673, v674, v676, v775, v777)
    v775.OutputDataReceived.Add v778 
    let v779 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v671, v675, v672, v673, v674, v676, v775, v777)
    v775.ErrorDataReceived.Add v779 
    let v780 : (unit -> bool) = v775.Start
    let v781 : bool = v780 ()
    let v782 : bool = v781 = false
    if v782 then
        let v783 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v783
    let v784 : (unit -> unit) = v775.BeginErrorReadLine
    v784 ()
    let v785 : (unit -> unit) = v775.BeginOutputReadLine
    v785 ()
    let v786 : (System.Threading.CancellationToken -> US18) = method74()
    let v787 : US18 = US18_1
    let v788 : US18 = v671 |> Option.map v786 |> Option.defaultValue v787 
    let v792 : System.Threading.CancellationToken =
        match v788 with
        | US18_1 -> (* None *)
            let v790 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v790
        | US18_0(v789) -> (* Some *)
            v789
    let v793 : Async<System.Threading.CancellationToken> option = None
    let v794 : bool = true in let mutable _v793 = v793
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v795 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v795
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v796 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v796
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v797 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v797
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v798 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v798
#endif
    
#if FABLE_COMPILER_PYTHON
    let v799 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v799
#endif
    
#else
    let v800 : Async<System.Threading.CancellationToken> option = None
    let v801 : bool = true in let mutable _v800 = v800
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v802 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v802
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v803 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v803
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v804 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v804
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v805 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v805
#endif
    
#if FABLE_COMPILER_PYTHON
    let v806 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v806
#endif
    
#else
    let v807 : Async<System.Threading.CancellationToken> option = None
    let mutable _v807 = v807
    async {
    let v808 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v808 = v808 
    let v809 : System.Threading.CancellationToken = v808 
    let v810 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v811 : (System.Threading.CancellationToken []) = [|v809; v810; v792|]
    let v812 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v813 : System.Threading.CancellationTokenSource = v812 v811
    let v814 : System.Threading.CancellationToken = v813.Token
    return v814 
    }
    |> fun x -> _v807 <- Some x
    let v815 : Async<System.Threading.CancellationToken> = _v807 |> Option.get
    v815
#endif
    |> fun x -> _v800 <- Some x
    let v816 : Async<System.Threading.CancellationToken> = _v800.Value
    v816
#endif
    |> fun x -> _v793 <- Some x
    let v817 : Async<System.Threading.CancellationToken> = _v793.Value
    let! v817 = v817 
    let v818 : System.Threading.CancellationToken = v817 
    let v819 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v818.Register
    let v820 : (unit -> unit) = closure54(v775)
    let v821 : System.Threading.CancellationTokenRegistration = v819 v820
    use v821 = v821 
    let v822 : System.Threading.CancellationTokenRegistration = v821 
    let v823 : Async<int32> option = None
    let v824 : bool = true in let mutable _v823 = v823
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v825 : Async<int32> = null |> unbox<Async<int32>>
    v825
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v826 : Async<int32> = null |> unbox<Async<int32>>
    v826
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v827 : Async<int32> = null |> unbox<Async<int32>>
    v827
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v828 : Async<int32> = null |> unbox<Async<int32>>
    v828
#endif
    
#if FABLE_COMPILER_PYTHON
    let v829 : Async<int32> = null |> unbox<Async<int32>>
    v829
#endif
    
#else
    let v830 : Async<int32> option = None
    let mutable _v830 = v830
    async {
    try
    let v831 : System.Threading.Tasks.Task = v775.WaitForExitAsync v818 
    let v832 : Async<unit> option = None
    let v833 : bool = true in let mutable _v832 = v832
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v834 : Async<unit> = null |> unbox<Async<unit>>
    v834
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v835 : Async<unit> = null |> unbox<Async<unit>>
    v835
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v836 : Async<unit> = null |> unbox<Async<unit>>
    v836
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v837 : Async<unit> = null |> unbox<Async<unit>>
    v837
#endif
    
#if FABLE_COMPILER_PYTHON
    let v838 : Async<unit> = null |> unbox<Async<unit>>
    v838
#endif
    
#else
    let v839 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v840 : Async<unit> = v839 v831
    v840
#endif
    |> fun x -> _v832 <- Some x
    let v841 : Async<unit> = _v832.Value
    do! v841 
    let v842 : int32 = v775.ExitCode
    return v842 
    with ex ->
    let v843 : exn = ex
    let v844 : string option = None
    let v845 : bool = true in let mutable _v844 = v844
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v846 : string = $"%A{v843}"
    v846
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v847 : string = $"%A{v843}"
    v847
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v848 : string = $"%A{v843}"
    v848
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v849 : string = $"%A{v843}"
    v849
#endif
    
#if FABLE_COMPILER_PYTHON
    let v850 : string = $"%A{v843}"
    v850
#endif
    
#else
    let v851 : string = $"{v843.GetType ()}: {v843.Message}"
    v851
#endif
    |> fun x -> _v844 <- Some x
    let v852 : string = _v844.Value
    let v853 : (string -> unit) = v777.Push
    v853 v852
    let v854 : System.Threading.Tasks.TaskCanceledException = v843 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v855 : US0 = US0_3
    let v856 : (unit -> string) = closure55(v854)
    let v857 : (unit -> string) = method51()
    method3(v855, v856, v857)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v830 <- Some x
    let v858 : Async<int32> = _v830 |> Option.get
    v858
#endif
    |> fun x -> _v823 <- Some x
    let v859 : Async<int32> = _v823.Value
    let! v859 = v859 
    let v860 : int32 = v859 
    let v861 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v862 : string seq = v861 v777
    let v863 : string = method75()
    let v864 : (string -> (string seq -> string)) = String.concat
    let v865 : (string seq -> string) = v864 v863
    let v866 : string = v865 v862
    let v867 : US0 = US0_1
    let v868 : (unit -> string) = closure56(v860, v866)
    let v869 : (unit -> string) = method51()
    method3(v867, v868, v869)
    return struct (v860, v866) 
    }
    |> fun x -> _v735 <- Some x
    let v870 : Async<struct (int32 * string)> = _v735 |> Option.get
    v870
#endif
    |> fun x -> _v728 <- Some x
    let v871 : Async<struct (int32 * string)> = _v728.Value
    v871
#endif
    |> fun x -> _v721 <- Some x
    let v872 : Async<struct (int32 * string)> = _v721.Value
    let v873 : struct (int32 * string) option = None
    let v874 : bool = true in let mutable _v873 = v873
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v875 : int32, v876 : string) = null |> unbox<struct (int32 * string)>
    struct (v875, v876)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v877 : int32, v878 : string) = null |> unbox<struct (int32 * string)>
    struct (v877, v878)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v879 : int32, v880 : string) = null |> unbox<struct (int32 * string)>
    struct (v879, v880)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v881 : int32, v882 : string) = null |> unbox<struct (int32 * string)>
    struct (v881, v882)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v883 : int32, v884 : string) = null |> unbox<struct (int32 * string)>
    struct (v883, v884)
#endif
    
#else
    let v885 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v886 : int32, v887 : string) = v885 v872
    struct (v886, v887)
#endif
    |> fun x -> _v873 <- Some x
    let struct (v888 : int32, v889 : string) = _v873.Value
    struct (v888, v889)
#endif
    |> fun x -> _v677 <- Some x
    let struct (v890 : int32, v891 : string) = _v677.Value
    let v892 : bool = v593.Contains v891
    let v893 : bool = v892 = false
    let v1545 : Vec<Result<string, (string * string)> option> =
        if v893 then
            let v894 : bool option = None
            let v895 : bool = true in let mutable _v894 = v894
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v896 : string = "cfg!(windows)"
            let v897 : bool = Fable.Core.RustInterop.emitRustExpr () v896
            v897
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v898 : bool = null |> unbox<bool>
            v898
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v899 : bool = null |> unbox<bool>
            v899
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v900 : bool = null |> unbox<bool>
            v900
#endif
            
#if FABLE_COMPILER_PYTHON
            let v901 : bool = null |> unbox<bool>
            v901
#endif
            
#else
            let v902 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v903 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v904 : bool = v903 v902
            v904
#endif
            |> fun x -> _v894 <- Some x
            let v905 : bool = _v894.Value
            let v906 : bool = v905 = false
            let v927 : string =
                if v906 then
                    v669
                else
                    let v907 : string option = None
                    let v908 : bool = true in let mutable _v907 = v907
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v909 : string = method26()
                    let v910 : string = method27(v669)
                    let v911 : string = method28()
                    let v912 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v913 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v909, v910, v911) v912
                    let v914 : string = "String::from($0)"
                    let v915 : std_string_String = Fable.Core.RustInterop.emitRustExpr v913 v914
                    let v916 : string = "fable_library_rust::String_::fromString($0)"
                    let v917 : string = Fable.Core.RustInterop.emitRustExpr v915 v916
                    v917
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v918 : string = null |> unbox<string>
                    v918
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v919 : string = null |> unbox<string>
                    v919
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v920 : string = null |> unbox<string>
                    v920
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v921 : string = null |> unbox<string>
                    v921
#endif
                    
#else
                    let v922 : string = "^\\\\\\\\\\?\\\\"
                    let v923 : string = System.Text.RegularExpressions.Regex.Replace (v669, v922, v254)
                    v923
#endif
                    |> fun x -> _v907 <- Some x
                    let v924 : string = _v907.Value
                    let v925 : string = $"{v924.[0] |> string |> _.ToLower()}{v924.[1..]}"
                    let v926 : string = v925.Replace (v256, v257)
                    v926
            let v928 : string option = None
            let v929 : System.Threading.CancellationToken option = None
            let v930 : (struct (string * string) []) = [||]
            let v931 : (struct (bool * string * int32) -> Async<unit>) option = None
            let v932 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
            let v933 : string = $"pwsh -c \"(Get-FileHash \\\"{v927}\\\" -Algorithm SHA256).Hash\""
            let v934 : struct (int32 * string) option = None
            let v935 : bool = true in let mutable _v934 = v934
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v936 : string = method42(v929, v933, v930, v931, v932, v928)
            let struct (v937 : string, v938 : string) = method43()
            let v939 : int32 = v936.Length
            let v940 : (char []) = Array.zeroCreate<char> (v939)
            let v941 : Mut5 = {l0 = 0} : Mut5
            while method30(v939, v941) do
                let v943 : int32 = v941.l0
                let v944 : char = v936.[int v943]
                v940.[int v943] <- v944
                let v945 : int32 = v943 + 1
                v941.l0 <- v945
                ()
            let v946 : ((char []) -> char list) = Array.toList
            let v947 : char list = v946 v940
            let v948 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v949 : (char -> (UH0 -> UH0)) = method44()
            let v950 : (char list -> (UH0 -> UH0)) = v948 v949
            let v951 : (UH0 -> UH0) = v950 v947
            let v952 : UH0 = UH0_0
            let v953 : UH0 = v951 v952
            let v954 : US8 = US8_0
            let struct (v955 : string, v956 : string) = method45(v938, v937, v953, v954)
            let v957 : (string []) = method46(v956)
            let v958 : string = "$0.to_vec()"
            let v959 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v957 v958
            let v960 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v961 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v959, v405) v960
            let v962 : US0 = US0_1
            let v963 : (unit -> string) = closure29(v929, v933, v930, v931, v932, v928, v955, v961)
            let v964 : (unit -> string) = method51()
            method3(v962, v963, v964)
            let v965 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method52(v929, v933, v930, v931, v932, v928, v955, v961)
            let v966 : string = "futures_lite::future::block_on($0)"
            let v967 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v965 v966
            let (a, b) = v967
            let v968 : int32 = a
            let v969 : string = b
            struct (v968, v969)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v970 : int32, v971 : string) = null |> unbox<struct (int32 * string)>
            struct (v970, v971)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v972 : int32, v973 : string) = null |> unbox<struct (int32 * string)>
            struct (v972, v973)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v974 : int32, v975 : string) = null |> unbox<struct (int32 * string)>
            struct (v974, v975)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v976 : int32, v977 : string) = null |> unbox<struct (int32 * string)>
            struct (v976, v977)
#endif
            
#else
            let v978 : Async<struct (int32 * string)> option = None
            let v979 : bool = true in let mutable _v978 = v978
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v980 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v980
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v981 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v981
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v982 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v982
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v983 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v983
#endif
            
#if FABLE_COMPILER_PYTHON
            let v984 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v984
#endif
            
#else
            let v985 : Async<struct (int32 * string)> option = None
            let v986 : bool = true in let mutable _v985 = v985
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v987 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v987
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v988 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v988
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v989 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v989
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v990 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v990
#endif
            
#if FABLE_COMPILER_PYTHON
            let v991 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v991
#endif
            
#else
            let v992 : Async<struct (int32 * string)> option = None
            let mutable _v992 = v992
            async {
            let struct (v993 : string, v994 : string) = method43()
            let v995 : int32 = v933.Length
            let v996 : (char []) = Array.zeroCreate<char> (v995)
            let v997 : Mut5 = {l0 = 0} : Mut5
            while method30(v995, v997) do
                let v999 : int32 = v997.l0
                let v1000 : char = v933.[int v999]
                v996.[int v999] <- v1000
                let v1001 : int32 = v999 + 1
                v997.l0 <- v1001
                ()
            let v1002 : ((char []) -> char list) = Array.toList
            let v1003 : char list = v1002 v996
            let v1004 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v1005 : (char -> (UH0 -> UH0)) = method44()
            let v1006 : (char list -> (UH0 -> UH0)) = v1004 v1005
            let v1007 : (UH0 -> UH0) = v1006 v1003
            let v1008 : UH0 = UH0_0
            let v1009 : UH0 = v1007 v1008
            let v1010 : US8 = US8_0
            let struct (v1011 : string, v1012 : string) = method45(v994, v993, v1009, v1010)
            let v1013 : (string -> US4) = method22()
            let v1014 : US4 = US4_1
            let v1015 : US4 = v928 |> Option.map v1013 |> Option.defaultValue v1014 
            let v1018 : string =
                match v1015 with
                | US4_1 -> (* None *)
                    v254
                | US4_0(v1016) -> (* Some *)
                    v1016
            let v1019 : US0 = US0_1
            let v1020 : (unit -> string) = closure48(v929, v933, v930, v931, v932, v928)
            let v1021 : (unit -> string) = method51()
            method3(v1019, v1020, v1021)
            let v1022 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v1023 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v1012, StandardOutputEncoding = v1022, WorkingDirectory = v1018, FileName = v1011, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v1024 : int32 = v930.Length
            let v1025 : Mut5 = {l0 = 0} : Mut5
            while method30(v1024, v1025) do
                let v1027 : int32 = v1025.l0
                let struct (v1028 : string, v1029 : string) = v930.[int v1027]
                v1023.EnvironmentVariables.[v1028] <- v1029 
                let v1030 : int32 = v1027 + 1
                v1025.l0 <- v1030
                ()
            let v1031 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1023)
            use v1031 = v1031 
            let v1032 : System.Diagnostics.Process = v1031 
            let v1033 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v1034 : System.Collections.Concurrent.ConcurrentStack<string> = v1033 ()
            let v1035 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v929, v933, v930, v931, v932, v928, v1032, v1034)
            v1032.OutputDataReceived.Add v1035 
            let v1036 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v929, v933, v930, v931, v932, v928, v1032, v1034)
            v1032.ErrorDataReceived.Add v1036 
            let v1037 : (unit -> bool) = v1032.Start
            let v1038 : bool = v1037 ()
            let v1039 : bool = v1038 = false
            if v1039 then
                let v1040 : string = $"execute_with_options_async / process_start error"
                failwith<unit> v1040
            let v1041 : (unit -> unit) = v1032.BeginErrorReadLine
            v1041 ()
            let v1042 : (unit -> unit) = v1032.BeginOutputReadLine
            v1042 ()
            let v1043 : (System.Threading.CancellationToken -> US18) = method74()
            let v1044 : US18 = US18_1
            let v1045 : US18 = v929 |> Option.map v1043 |> Option.defaultValue v1044 
            let v1049 : System.Threading.CancellationToken =
                match v1045 with
                | US18_1 -> (* None *)
                    let v1047 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v1047
                | US18_0(v1046) -> (* Some *)
                    v1046
            let v1050 : Async<System.Threading.CancellationToken> option = None
            let v1051 : bool = true in let mutable _v1050 = v1050
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1052 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1052
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1053 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1053
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1054 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1054
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1055 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1055
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1056 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1056
#endif
            
#else
            let v1057 : Async<System.Threading.CancellationToken> option = None
            let v1058 : bool = true in let mutable _v1057 = v1057
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1059 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1059
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1060 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1060
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1061 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1061
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1062 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1062
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1063 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1063
#endif
            
#else
            let v1064 : Async<System.Threading.CancellationToken> option = None
            let mutable _v1064 = v1064
            async {
            let v1065 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v1065 = v1065 
            let v1066 : System.Threading.CancellationToken = v1065 
            let v1067 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v1068 : (System.Threading.CancellationToken []) = [|v1066; v1067; v1049|]
            let v1069 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v1070 : System.Threading.CancellationTokenSource = v1069 v1068
            let v1071 : System.Threading.CancellationToken = v1070.Token
            return v1071 
            }
            |> fun x -> _v1064 <- Some x
            let v1072 : Async<System.Threading.CancellationToken> = _v1064 |> Option.get
            v1072
#endif
            |> fun x -> _v1057 <- Some x
            let v1073 : Async<System.Threading.CancellationToken> = _v1057.Value
            v1073
#endif
            |> fun x -> _v1050 <- Some x
            let v1074 : Async<System.Threading.CancellationToken> = _v1050.Value
            let! v1074 = v1074 
            let v1075 : System.Threading.CancellationToken = v1074 
            let v1076 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1075.Register
            let v1077 : (unit -> unit) = closure54(v1032)
            let v1078 : System.Threading.CancellationTokenRegistration = v1076 v1077
            use v1078 = v1078 
            let v1079 : System.Threading.CancellationTokenRegistration = v1078 
            let v1080 : Async<int32> option = None
            let v1081 : bool = true in let mutable _v1080 = v1080
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1082 : Async<int32> = null |> unbox<Async<int32>>
            v1082
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1083 : Async<int32> = null |> unbox<Async<int32>>
            v1083
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1084 : Async<int32> = null |> unbox<Async<int32>>
            v1084
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1085 : Async<int32> = null |> unbox<Async<int32>>
            v1085
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1086 : Async<int32> = null |> unbox<Async<int32>>
            v1086
#endif
            
#else
            let v1087 : Async<int32> option = None
            let mutable _v1087 = v1087
            async {
            try
            let v1088 : System.Threading.Tasks.Task = v1032.WaitForExitAsync v1075 
            let v1089 : Async<unit> option = None
            let v1090 : bool = true in let mutable _v1089 = v1089
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1091 : Async<unit> = null |> unbox<Async<unit>>
            v1091
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1092 : Async<unit> = null |> unbox<Async<unit>>
            v1092
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1093 : Async<unit> = null |> unbox<Async<unit>>
            v1093
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1094 : Async<unit> = null |> unbox<Async<unit>>
            v1094
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1095 : Async<unit> = null |> unbox<Async<unit>>
            v1095
#endif
            
#else
            let v1096 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v1097 : Async<unit> = v1096 v1088
            v1097
#endif
            |> fun x -> _v1089 <- Some x
            let v1098 : Async<unit> = _v1089.Value
            do! v1098 
            let v1099 : int32 = v1032.ExitCode
            return v1099 
            with ex ->
            let v1100 : exn = ex
            let v1101 : string option = None
            let v1102 : bool = true in let mutable _v1101 = v1101
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1103 : string = $"%A{v1100}"
            v1103
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1104 : string = $"%A{v1100}"
            v1104
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1105 : string = $"%A{v1100}"
            v1105
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1106 : string = $"%A{v1100}"
            v1106
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1107 : string = $"%A{v1100}"
            v1107
#endif
            
#else
            let v1108 : string = $"{v1100.GetType ()}: {v1100.Message}"
            v1108
#endif
            |> fun x -> _v1101 <- Some x
            let v1109 : string = _v1101.Value
            let v1110 : (string -> unit) = v1034.Push
            v1110 v1109
            let v1111 : System.Threading.Tasks.TaskCanceledException = v1100 |> unbox<System.Threading.Tasks.TaskCanceledException>
            let v1112 : US0 = US0_3
            let v1113 : (unit -> string) = closure55(v1111)
            let v1114 : (unit -> string) = method51()
            method3(v1112, v1113, v1114)
            return -2147483648 
            (*
            *)
            }
            |> fun x -> _v1087 <- Some x
            let v1115 : Async<int32> = _v1087 |> Option.get
            v1115
#endif
            |> fun x -> _v1080 <- Some x
            let v1116 : Async<int32> = _v1080.Value
            let! v1116 = v1116 
            let v1117 : int32 = v1116 
            let v1118 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v1119 : string seq = v1118 v1034
            let v1120 : string = method75()
            let v1121 : (string -> (string seq -> string)) = String.concat
            let v1122 : (string seq -> string) = v1121 v1120
            let v1123 : string = v1122 v1119
            let v1124 : US0 = US0_1
            let v1125 : (unit -> string) = closure56(v1117, v1123)
            let v1126 : (unit -> string) = method51()
            method3(v1124, v1125, v1126)
            return struct (v1117, v1123) 
            }
            |> fun x -> _v992 <- Some x
            let v1127 : Async<struct (int32 * string)> = _v992 |> Option.get
            v1127
#endif
            |> fun x -> _v985 <- Some x
            let v1128 : Async<struct (int32 * string)> = _v985.Value
            v1128
#endif
            |> fun x -> _v978 <- Some x
            let v1129 : Async<struct (int32 * string)> = _v978.Value
            let v1130 : struct (int32 * string) option = None
            let v1131 : bool = true in let mutable _v1130 = v1130
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v1132 : int32, v1133 : string) = null |> unbox<struct (int32 * string)>
            struct (v1132, v1133)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v1134 : int32, v1135 : string) = null |> unbox<struct (int32 * string)>
            struct (v1134, v1135)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v1136 : int32, v1137 : string) = null |> unbox<struct (int32 * string)>
            struct (v1136, v1137)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v1138 : int32, v1139 : string) = null |> unbox<struct (int32 * string)>
            struct (v1138, v1139)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v1140 : int32, v1141 : string) = null |> unbox<struct (int32 * string)>
            struct (v1140, v1141)
#endif
            
#else
            let v1142 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
            let struct (v1143 : int32, v1144 : string) = v1142 v1129
            struct (v1143, v1144)
#endif
            |> fun x -> _v1130 <- Some x
            let struct (v1145 : int32, v1146 : string) = _v1130.Value
            struct (v1145, v1146)
#endif
            |> fun x -> _v934 <- Some x
            let struct (v1147 : int32, v1148 : string) = _v934.Value
            let v1149 : string option = None
            let v1150 : bool = true in let mutable _v1149 = v1149
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1151 : string = method18(v4)
            let v1152 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1153 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1151 v1152
            let v1154 : string = "String::from($0)"
            let v1155 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1153 v1154
            let v1156 : string = "std::path::PathBuf::from($0)"
            let v1157 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1155 v1156
            let v1158 : string = method18(v259)
            let v1159 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1160 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1158 v1159
            let v1161 : string = "String::from($0)"
            let v1162 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1160 v1161
            let v1163 : string = "$0.join($1)"
            let v1164 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v1157, v1162) v1163
            let v1165 : string = "$0.display()"
            let v1166 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v1164 v1165
            let v1167 : std_string_String option = None
            let v1168 : bool = true in let mutable _v1167 = v1167
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1169 : string = @$"format!(""{{}}"", $0)"
            let v1170 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1166 v1169
            v1170
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1171 : string = @$"format!(""{{}}"", $0)"
            let v1172 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1166 v1171
            v1172
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1173 : string = @$"format!(""{{}}"", $0)"
            let v1174 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1166 v1173
            v1174
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1175 : std_string_String = null |> unbox<std_string_String>
            v1175
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1176 : std_string_String = null |> unbox<std_string_String>
            v1176
#endif
            
#else
            let v1177 : std_string_String = null |> unbox<std_string_String>
            v1177
#endif
            |> fun x -> _v1167 <- Some x
            let v1178 : std_string_String = _v1167.Value
            let v1179 : string = "fable_library_rust::String_::fromString($0)"
            let v1180 : string = Fable.Core.RustInterop.emitRustExpr v1178 v1179
            v1180
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1181 : string = null |> unbox<string>
            v1181
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1182 : string = null |> unbox<string>
            v1182
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1183 : IPathJoin = Fable.Core.JsInterop.importAll v328
            let v1184 : string = method19(v4)
            let v1185 : string = method20(v259)
            let v1186 : string = "v1183.join(v1184, v1185)"
            let v1187 : string = Fable.Core.JsInterop.emitJsExpr () v1186
            v1187
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1188 : string = null |> unbox<string>
            v1188
#endif
            
#else
            let v1189 : string = System.IO.Path.Combine (v4, v259)
            v1189
#endif
            |> fun x -> _v1149 <- Some x
            let v1190 : string = _v1149.Value
            let v1191 : bool option = None
            let v1192 : bool = true in let mutable _v1191 = v1191
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1193 : string = "cfg!(windows)"
            let v1194 : bool = Fable.Core.RustInterop.emitRustExpr () v1193
            v1194
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1195 : bool = null |> unbox<bool>
            v1195
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1196 : bool = null |> unbox<bool>
            v1196
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1197 : bool = null |> unbox<bool>
            v1197
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1198 : bool = null |> unbox<bool>
            v1198
#endif
            
#else
            let v1199 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v1200 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v1201 : bool = v1200 v1199
            v1201
#endif
            |> fun x -> _v1191 <- Some x
            let v1202 : bool = _v1191.Value
            let v1203 : bool = v1202 = false
            let v1224 : string =
                if v1203 then
                    v1190
                else
                    let v1204 : string option = None
                    let v1205 : bool = true in let mutable _v1204 = v1204
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1206 : string = method26()
                    let v1207 : string = method27(v1190)
                    let v1208 : string = method28()
                    let v1209 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v1210 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1206, v1207, v1208) v1209
                    let v1211 : string = "String::from($0)"
                    let v1212 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1210 v1211
                    let v1213 : string = "fable_library_rust::String_::fromString($0)"
                    let v1214 : string = Fable.Core.RustInterop.emitRustExpr v1212 v1213
                    v1214
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1215 : string = null |> unbox<string>
                    v1215
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1216 : string = null |> unbox<string>
                    v1216
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1217 : string = null |> unbox<string>
                    v1217
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1218 : string = null |> unbox<string>
                    v1218
#endif
                    
#else
                    let v1219 : string = "^\\\\\\\\\\?\\\\"
                    let v1220 : string = System.Text.RegularExpressions.Regex.Replace (v1190, v1219, v254)
                    v1220
#endif
                    |> fun x -> _v1204 <- Some x
                    let v1221 : string = _v1204.Value
                    let v1222 : string = $"{v1221.[0] |> string |> _.ToLower()}{v1221.[1..]}"
                    let v1223 : string = v1222.Replace (v256, v257)
                    v1223
            let v1225 : bool option = None
            let v1226 : bool = true in let mutable _v1225 = v1225
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1227 : string = method18(v1224)
            let v1228 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1229 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1227 v1228
            let v1230 : string = "String::from($0)"
            let v1231 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1229 v1230
            let v1232 : string = "std::path::PathBuf::from($0)"
            let v1233 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1231 v1232
            let v1234 : string = "$0.exists()"
            let v1235 : bool = Fable.Core.RustInterop.emitRustExpr v1233 v1234
            let v1238 : bool =
                if v1235 then
                    let v1236 : string = "$0.is_file()"
                    let v1237 : bool = Fable.Core.RustInterop.emitRustExpr v1233 v1236
                    v1237
                else
                    false
            v1238
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1239 : bool = null |> unbox<bool>
            v1239
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1240 : bool = null |> unbox<bool>
            v1240
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1241 : string = "fs"
            let v1242 : IFsExistsSync = Fable.Core.JsInterop.importAll v1241
            let v1243 : string = "v1242.existsSync($0)"
            let v1244 : bool = Fable.Core.JsInterop.emitJsExpr v1224 v1243
            v1244
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1245 : bool = null |> unbox<bool>
            v1245
#endif
            
#else
            let v1246 : (string -> bool) = System.IO.File.Exists
            let v1247 : bool = v1246 v1224
            v1247
#endif
            |> fun x -> _v1225 <- Some x
            let v1248 : bool = _v1225.Value
            let v1504 : string =
                if v1248 then
                    let v1249 : bool option = None
                    let v1250 : bool = true in let mutable _v1249 = v1249
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1251 : string = "cfg!(windows)"
                    let v1252 : bool = Fable.Core.RustInterop.emitRustExpr () v1251
                    v1252
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1253 : bool = null |> unbox<bool>
                    v1253
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1254 : bool = null |> unbox<bool>
                    v1254
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1255 : bool = null |> unbox<bool>
                    v1255
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1256 : bool = null |> unbox<bool>
                    v1256
#endif
                    
#else
                    let v1257 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                    let v1258 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                    let v1259 : bool = v1258 v1257
                    v1259
#endif
                    |> fun x -> _v1249 <- Some x
                    let v1260 : bool = _v1249.Value
                    let v1261 : bool = v1260 = false
                    let v1282 : string =
                        if v1261 then
                            v1224
                        else
                            let v1262 : string option = None
                            let v1263 : bool = true in let mutable _v1262 = v1262
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v1264 : string = method26()
                            let v1265 : string = method27(v1224)
                            let v1266 : string = method28()
                            let v1267 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                            let v1268 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1264, v1265, v1266) v1267
                            let v1269 : string = "String::from($0)"
                            let v1270 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1268 v1269
                            let v1271 : string = "fable_library_rust::String_::fromString($0)"
                            let v1272 : string = Fable.Core.RustInterop.emitRustExpr v1270 v1271
                            v1272
#endif
                            
#if FABLE_COMPILER_RUST && WASM
                            let v1273 : string = null |> unbox<string>
                            v1273
#endif
                            
#if FABLE_COMPILER_RUST && CONTRACT
                            let v1274 : string = null |> unbox<string>
                            v1274
#endif
                            
#if FABLE_COMPILER_TYPESCRIPT
                            let v1275 : string = null |> unbox<string>
                            v1275
#endif
                            
#if FABLE_COMPILER_PYTHON
                            let v1276 : string = null |> unbox<string>
                            v1276
#endif
                            
#else
                            let v1277 : string = "^\\\\\\\\\\?\\\\"
                            let v1278 : string = System.Text.RegularExpressions.Regex.Replace (v1224, v1277, v254)
                            v1278
#endif
                            |> fun x -> _v1262 <- Some x
                            let v1279 : string = _v1262.Value
                            let v1280 : string = $"{v1279.[0] |> string |> _.ToLower()}{v1279.[1..]}"
                            let v1281 : string = v1280.Replace (v256, v257)
                            v1281
                    let v1283 : string option = None
                    let v1284 : System.Threading.CancellationToken option = None
                    let v1285 : (struct (string * string) []) = [||]
                    let v1286 : (struct (bool * string * int32) -> Async<unit>) option = None
                    let v1287 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                    let v1288 : string = $"pwsh -c \"(Get-FileHash \\\"{v1282}\\\" -Algorithm SHA256).Hash\""
                    let v1289 : struct (int32 * string) option = None
                    let v1290 : bool = true in let mutable _v1289 = v1289
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1291 : string = method42(v1284, v1288, v1285, v1286, v1287, v1283)
                    let struct (v1292 : string, v1293 : string) = method43()
                    let v1294 : int32 = v1291.Length
                    let v1295 : (char []) = Array.zeroCreate<char> (v1294)
                    let v1296 : Mut5 = {l0 = 0} : Mut5
                    while method30(v1294, v1296) do
                        let v1298 : int32 = v1296.l0
                        let v1299 : char = v1291.[int v1298]
                        v1295.[int v1298] <- v1299
                        let v1300 : int32 = v1298 + 1
                        v1296.l0 <- v1300
                        ()
                    let v1301 : ((char []) -> char list) = Array.toList
                    let v1302 : char list = v1301 v1295
                    let v1303 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                    let v1304 : (char -> (UH0 -> UH0)) = method44()
                    let v1305 : (char list -> (UH0 -> UH0)) = v1303 v1304
                    let v1306 : (UH0 -> UH0) = v1305 v1302
                    let v1307 : UH0 = UH0_0
                    let v1308 : UH0 = v1306 v1307
                    let v1309 : US8 = US8_0
                    let struct (v1310 : string, v1311 : string) = method45(v1293, v1292, v1308, v1309)
                    let v1312 : (string []) = method46(v1311)
                    let v1313 : string = "$0.to_vec()"
                    let v1314 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v1312 v1313
                    let v1315 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                    let v1316 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1314, v405) v1315
                    let v1317 : US0 = US0_1
                    let v1318 : (unit -> string) = closure29(v1284, v1288, v1285, v1286, v1287, v1283, v1310, v1316)
                    let v1319 : (unit -> string) = method51()
                    method3(v1317, v1318, v1319)
                    let v1320 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method52(v1284, v1288, v1285, v1286, v1287, v1283, v1310, v1316)
                    let v1321 : string = "futures_lite::future::block_on($0)"
                    let v1322 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v1320 v1321
                    let (a, b) = v1322
                    let v1323 : int32 = a
                    let v1324 : string = b
                    struct (v1323, v1324)
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let struct (v1325 : int32, v1326 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1325, v1326)
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let struct (v1327 : int32, v1328 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1327, v1328)
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let struct (v1329 : int32, v1330 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1329, v1330)
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let struct (v1331 : int32, v1332 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1331, v1332)
#endif
                    
#else
                    let v1333 : Async<struct (int32 * string)> option = None
                    let v1334 : bool = true in let mutable _v1333 = v1333
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1335 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1335
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1336 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1336
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1337 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1337
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1338 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1338
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1339 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1339
#endif
                    
#else
                    let v1340 : Async<struct (int32 * string)> option = None
                    let v1341 : bool = true in let mutable _v1340 = v1340
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1342 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1342
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1343 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1343
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1344 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1344
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1345 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1345
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1346 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1346
#endif
                    
#else
                    let v1347 : Async<struct (int32 * string)> option = None
                    let mutable _v1347 = v1347
                    async {
                    let struct (v1348 : string, v1349 : string) = method43()
                    let v1350 : int32 = v1288.Length
                    let v1351 : (char []) = Array.zeroCreate<char> (v1350)
                    let v1352 : Mut5 = {l0 = 0} : Mut5
                    while method30(v1350, v1352) do
                        let v1354 : int32 = v1352.l0
                        let v1355 : char = v1288.[int v1354]
                        v1351.[int v1354] <- v1355
                        let v1356 : int32 = v1354 + 1
                        v1352.l0 <- v1356
                        ()
                    let v1357 : ((char []) -> char list) = Array.toList
                    let v1358 : char list = v1357 v1351
                    let v1359 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                    let v1360 : (char -> (UH0 -> UH0)) = method44()
                    let v1361 : (char list -> (UH0 -> UH0)) = v1359 v1360
                    let v1362 : (UH0 -> UH0) = v1361 v1358
                    let v1363 : UH0 = UH0_0
                    let v1364 : UH0 = v1362 v1363
                    let v1365 : US8 = US8_0
                    let struct (v1366 : string, v1367 : string) = method45(v1349, v1348, v1364, v1365)
                    let v1368 : (string -> US4) = method22()
                    let v1369 : US4 = US4_1
                    let v1370 : US4 = v1283 |> Option.map v1368 |> Option.defaultValue v1369 
                    let v1373 : string =
                        match v1370 with
                        | US4_1 -> (* None *)
                            v254
                        | US4_0(v1371) -> (* Some *)
                            v1371
                    let v1374 : US0 = US0_1
                    let v1375 : (unit -> string) = closure48(v1284, v1288, v1285, v1286, v1287, v1283)
                    let v1376 : (unit -> string) = method51()
                    method3(v1374, v1375, v1376)
                    let v1377 : System.Text.Encoding = System.Text.Encoding.UTF8
                    let v1378 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v1367, StandardOutputEncoding = v1377, WorkingDirectory = v1373, FileName = v1366, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                    let v1379 : int32 = v1285.Length
                    let v1380 : Mut5 = {l0 = 0} : Mut5
                    while method30(v1379, v1380) do
                        let v1382 : int32 = v1380.l0
                        let struct (v1383 : string, v1384 : string) = v1285.[int v1382]
                        v1378.EnvironmentVariables.[v1383] <- v1384 
                        let v1385 : int32 = v1382 + 1
                        v1380.l0 <- v1385
                        ()
                    let v1386 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1378)
                    use v1386 = v1386 
                    let v1387 : System.Diagnostics.Process = v1386 
                    let v1388 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                    let v1389 : System.Collections.Concurrent.ConcurrentStack<string> = v1388 ()
                    let v1390 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v1284, v1288, v1285, v1286, v1287, v1283, v1387, v1389)
                    v1387.OutputDataReceived.Add v1390 
                    let v1391 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v1284, v1288, v1285, v1286, v1287, v1283, v1387, v1389)
                    v1387.ErrorDataReceived.Add v1391 
                    let v1392 : (unit -> bool) = v1387.Start
                    let v1393 : bool = v1392 ()
                    let v1394 : bool = v1393 = false
                    if v1394 then
                        let v1395 : string = $"execute_with_options_async / process_start error"
                        failwith<unit> v1395
                    let v1396 : (unit -> unit) = v1387.BeginErrorReadLine
                    v1396 ()
                    let v1397 : (unit -> unit) = v1387.BeginOutputReadLine
                    v1397 ()
                    let v1398 : (System.Threading.CancellationToken -> US18) = method74()
                    let v1399 : US18 = US18_1
                    let v1400 : US18 = v1284 |> Option.map v1398 |> Option.defaultValue v1399 
                    let v1404 : System.Threading.CancellationToken =
                        match v1400 with
                        | US18_1 -> (* None *)
                            let v1402 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                            v1402
                        | US18_0(v1401) -> (* Some *)
                            v1401
                    let v1405 : Async<System.Threading.CancellationToken> option = None
                    let v1406 : bool = true in let mutable _v1405 = v1405
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1407 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1407
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1408 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1408
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1409 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1409
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1410 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1410
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1411 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1411
#endif
                    
#else
                    let v1412 : Async<System.Threading.CancellationToken> option = None
                    let v1413 : bool = true in let mutable _v1412 = v1412
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1414 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1414
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1415 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1415
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1416 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1416
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1417 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1417
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1418 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1418
#endif
                    
#else
                    let v1419 : Async<System.Threading.CancellationToken> option = None
                    let mutable _v1419 = v1419
                    async {
                    let v1420 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v1420 = v1420 
                    let v1421 : System.Threading.CancellationToken = v1420 
                    let v1422 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v1423 : (System.Threading.CancellationToken []) = [|v1421; v1422; v1404|]
                    let v1424 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v1425 : System.Threading.CancellationTokenSource = v1424 v1423
                    let v1426 : System.Threading.CancellationToken = v1425.Token
                    return v1426 
                    }
                    |> fun x -> _v1419 <- Some x
                    let v1427 : Async<System.Threading.CancellationToken> = _v1419 |> Option.get
                    v1427
#endif
                    |> fun x -> _v1412 <- Some x
                    let v1428 : Async<System.Threading.CancellationToken> = _v1412.Value
                    v1428
#endif
                    |> fun x -> _v1405 <- Some x
                    let v1429 : Async<System.Threading.CancellationToken> = _v1405.Value
                    let! v1429 = v1429 
                    let v1430 : System.Threading.CancellationToken = v1429 
                    let v1431 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1430.Register
                    let v1432 : (unit -> unit) = closure54(v1387)
                    let v1433 : System.Threading.CancellationTokenRegistration = v1431 v1432
                    use v1433 = v1433 
                    let v1434 : System.Threading.CancellationTokenRegistration = v1433 
                    let v1435 : Async<int32> option = None
                    let v1436 : bool = true in let mutable _v1435 = v1435
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1437 : Async<int32> = null |> unbox<Async<int32>>
                    v1437
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1438 : Async<int32> = null |> unbox<Async<int32>>
                    v1438
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1439 : Async<int32> = null |> unbox<Async<int32>>
                    v1439
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1440 : Async<int32> = null |> unbox<Async<int32>>
                    v1440
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1441 : Async<int32> = null |> unbox<Async<int32>>
                    v1441
#endif
                    
#else
                    let v1442 : Async<int32> option = None
                    let mutable _v1442 = v1442
                    async {
                    try
                    let v1443 : System.Threading.Tasks.Task = v1387.WaitForExitAsync v1430 
                    let v1444 : Async<unit> option = None
                    let v1445 : bool = true in let mutable _v1444 = v1444
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1446 : Async<unit> = null |> unbox<Async<unit>>
                    v1446
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1447 : Async<unit> = null |> unbox<Async<unit>>
                    v1447
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1448 : Async<unit> = null |> unbox<Async<unit>>
                    v1448
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1449 : Async<unit> = null |> unbox<Async<unit>>
                    v1449
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1450 : Async<unit> = null |> unbox<Async<unit>>
                    v1450
#endif
                    
#else
                    let v1451 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1452 : Async<unit> = v1451 v1443
                    v1452
#endif
                    |> fun x -> _v1444 <- Some x
                    let v1453 : Async<unit> = _v1444.Value
                    do! v1453 
                    let v1454 : int32 = v1387.ExitCode
                    return v1454 
                    with ex ->
                    let v1455 : exn = ex
                    let v1456 : string option = None
                    let v1457 : bool = true in let mutable _v1456 = v1456
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1458 : string = $"%A{v1455}"
                    v1458
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1459 : string = $"%A{v1455}"
                    v1459
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1460 : string = $"%A{v1455}"
                    v1460
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1461 : string = $"%A{v1455}"
                    v1461
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1462 : string = $"%A{v1455}"
                    v1462
#endif
                    
#else
                    let v1463 : string = $"{v1455.GetType ()}: {v1455.Message}"
                    v1463
#endif
                    |> fun x -> _v1456 <- Some x
                    let v1464 : string = _v1456.Value
                    let v1465 : (string -> unit) = v1389.Push
                    v1465 v1464
                    let v1466 : System.Threading.Tasks.TaskCanceledException = v1455 |> unbox<System.Threading.Tasks.TaskCanceledException>
                    let v1467 : US0 = US0_3
                    let v1468 : (unit -> string) = closure55(v1466)
                    let v1469 : (unit -> string) = method51()
                    method3(v1467, v1468, v1469)
                    return -2147483648 
                    (*
                    *)
                    }
                    |> fun x -> _v1442 <- Some x
                    let v1470 : Async<int32> = _v1442 |> Option.get
                    v1470
#endif
                    |> fun x -> _v1435 <- Some x
                    let v1471 : Async<int32> = _v1435.Value
                    let! v1471 = v1471 
                    let v1472 : int32 = v1471 
                    let v1473 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                    let v1474 : string seq = v1473 v1389
                    let v1475 : string = method75()
                    let v1476 : (string -> (string seq -> string)) = String.concat
                    let v1477 : (string seq -> string) = v1476 v1475
                    let v1478 : string = v1477 v1474
                    let v1479 : US0 = US0_1
                    let v1480 : (unit -> string) = closure56(v1472, v1478)
                    let v1481 : (unit -> string) = method51()
                    method3(v1479, v1480, v1481)
                    return struct (v1472, v1478) 
                    }
                    |> fun x -> _v1347 <- Some x
                    let v1482 : Async<struct (int32 * string)> = _v1347 |> Option.get
                    v1482
#endif
                    |> fun x -> _v1340 <- Some x
                    let v1483 : Async<struct (int32 * string)> = _v1340.Value
                    v1483
#endif
                    |> fun x -> _v1333 <- Some x
                    let v1484 : Async<struct (int32 * string)> = _v1333.Value
                    let v1485 : struct (int32 * string) option = None
                    let v1486 : bool = true in let mutable _v1485 = v1485
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let struct (v1487 : int32, v1488 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1487, v1488)
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let struct (v1489 : int32, v1490 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1489, v1490)
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let struct (v1491 : int32, v1492 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1491, v1492)
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let struct (v1493 : int32, v1494 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1493, v1494)
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let struct (v1495 : int32, v1496 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1495, v1496)
#endif
                    
#else
                    let v1497 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                    let struct (v1498 : int32, v1499 : string) = v1497 v1484
                    struct (v1498, v1499)
#endif
                    |> fun x -> _v1485 <- Some x
                    let struct (v1500 : int32, v1501 : string) = _v1485.Value
                    struct (v1500, v1501)
#endif
                    |> fun x -> _v1289 <- Some x
                    let struct (v1502 : int32, v1503 : string) = _v1289.Value
                    v1503
                else
                    v254
            let v1505 : bool = v1148 <> v1504
            if v1505 then
                let v1506 : struct (string * (string -> US19)) list = []
                let v1507 : string = "hangul.md"
                let v1508 : (string -> US19) = closure57(v669, v1224, v0, v1)
                let v1509 : struct (string * (string -> US19)) list = struct (v1507, v1508) :: v1506 
                let v1510 : string = "epub"
                let v1511 : (string -> US19) = closure61(v669, v1224, v3)
                let v1512 : struct (string * (string -> US19)) list = struct (v1510, v1511) :: v1509 
                let v1513 : string = "pdf"
                let v1514 : struct (string * (string -> US19)) list = struct (v1513, v1511) :: v1512 
                let v1515 : string = "html"
                let v1516 : struct (string * (string -> US19)) list = struct (v1515, v1511) :: v1514 
                let v1517 : (struct (string * (string -> US19)) list -> (struct (string * (string -> US19)) [])) = List.toArray
                let v1518 : (struct (string * (string -> US19)) []) = v1517 v1516
                let v1519 : string = "$0.to_vec()"
                let v1520 : Vec<struct (string * (string -> US19))> = Fable.Core.RustInterop.emitRustExpr v1518 v1519
                let v1521 : string = "rayon::iter::IntoParallelIterator::into_par_iter(v1520)"
                let v1522 : rayon_vec_IntoIter<struct (string * (string -> US19))> = Fable.Core.RustInterop.emitRustExpr () v1521
                let v1523 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
                let v1524 : (struct (string * (string -> US19)) -> Result<string, (string * string)> option) = closure64()
                let v1525 : rayon_iter_Map<rayon_vec_IntoIter<struct (string * (string -> US19))>> = Fable.Core.RustInterop.emitRustExpr struct (v1522, v1524) v1523
                let v1526 : string = "rayon::iter::ParallelIterator::collect($0)"
                let v1527 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1525 v1526
                let v1528 : US0 = US0_2
                let v1529 : (unit -> string) = closure65()
                let v1530 : (unit -> string) = closure66(v259, v293, v370, v593, v592, v891, v890, v1148, v1504, v1527)
                method3(v1528, v1529, v1530)
                let v1531 : unit option = None
                let v1532 : bool = true in let mutable _v1531 = v1531
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1533 : string = method81(v1224)
                let v1534 : string = "std::fs::copy(&*v669, &*v1533)"
                let v1535 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v1534
                let v1536 : string = "$0.unwrap()"
                let v1537 : uint64 = Fable.Core.RustInterop.emitRustExpr v1535 v1536
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
                System.IO.File.Copy (v669, v1224, true)
                ()
#endif
                |> fun x -> _v1531 <- Some x
                _v1531.Value
                v1527
            else
                let v1538 : (Result<string, (string * string)> option []) = [||]
                let v1539 : string = "$0.to_vec()"
                let v1540 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1538 v1539
                v1540
        else
            let v1542 : (Result<string, (string * string)> option []) = [||]
            let v1543 : string = "$0.to_vec()"
            let v1544 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1542 v1543
            v1544
    let v1546 : (string * Vec<Result<string, (string * string)> option>) = v293, v1545
    let v1547 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v1546
    v1547
and closure67 () () : string =
    let v0 : string = "documents.run"
    v0
and closure68 (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) () : string =
    let v1 : string = "$0.len()"
    let v2 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"result_len: {v2} / {v3 ()}"
    v4
and method82 (v0 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>) : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> =
    v0
and method33 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> =
    let v5 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v5
    let v6 : string = "async_walkdir::WalkDir::new(&*$0)"
    let v7 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr v3 v6
    let v8 : string = "async_walkdir::WalkDir::filter($0, |x| $1(x))"
    let v9 : (async_walkdir_DirEntry -> std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>) = closure14()
    let v10 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr struct (v7, v9) v8
    let v11 : (Result<async_walkdir_DirEntry, std_io_Error> -> string option) = method41()
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
    let v25 : (unit -> string) = closure67()
    let v26 : (unit -> string) = closure68(v23)
    method3(v24, v25, v26)
    let v27 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Ok v23
    let v28 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = method82(v27)
    let v29 : string = "v28 }}}})"
    Fable.Core.RustInterop.emitRustExpr () v29
    let v30 : string = "{{{ //"
    Fable.Core.RustInterop.emitRustExpr () v30
    let v31 : string = "__result"
    let v32 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v31
    v32
and method12 (v0 : string, v1 : string, v2 : string, v3 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> =
    let v4 : string = __SOURCE_DIRECTORY__
    let v5 : string option = None
    let v6 : bool = true in let mutable _v5 = v5
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = method13()
    let v8 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "String::from($0)"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "std::path::PathBuf::from($0)"
    let v13 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = method14()
    let v15 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "String::from($0)"
    let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v17
    let v19 : string = "$0.join($1)"
    let v20 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v13, v18) v19
    let v21 : string = "$0.display()"
    let v22 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v20 v21
    let v23 : std_string_String option = None
    let v24 : bool = true in let mutable _v23 = v23
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v25 : string = @$"format!(""{{}}"", $0)"
    let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v25
    v26
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v27 : string = @$"format!(""{{}}"", $0)"
    let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v27
    v28
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : string = @$"format!(""{{}}"", $0)"
    let v30 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v29
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
    |> fun x -> _v23 <- Some x
    let v34 : std_string_String = _v23.Value
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
    let v39 : string = "path"
    let v40 : IPathJoin = Fable.Core.JsInterop.importAll v39
    let v41 : string = method15()
    let v42 : string = method16()
    let v43 : string = "v40.join(v41, v42)"
    let v44 : string = Fable.Core.JsInterop.emitJsExpr () v43
    v44
#endif
    
#if FABLE_COMPILER_PYTHON
    let v45 : string = null |> unbox<string>
    v45
#endif
    
#else
    let v46 : string = "polyglot"
    let v47 : string = ".paket"
    let v48 : string = System.IO.Path.Combine (v46, v47)
    v48
#endif
    |> fun x -> _v5 <- Some x
    let v49 : string = _v5.Value
    let v50 : string = method17(v49, v4)
    let v51 : string option = None
    let v52 : bool = true in let mutable _v51 = v51
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v53 : string = method18(v50)
    let v54 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v54
    let v56 : string = "String::from($0)"
    let v57 : std_string_String = Fable.Core.RustInterop.emitRustExpr v55 v56
    let v58 : string = "std::path::PathBuf::from($0)"
    let v59 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v57 v58
    let v60 : string = method13()
    let v61 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v61
    let v63 : string = "String::from($0)"
    let v64 : std_string_String = Fable.Core.RustInterop.emitRustExpr v62 v63
    let v65 : string = "$0.join($1)"
    let v66 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v59, v64) v65
    let v67 : string = "$0.display()"
    let v68 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v66 v67
    let v69 : std_string_String option = None
    let v70 : bool = true in let mutable _v69 = v69
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v71 : string = @$"format!(""{{}}"", $0)"
    let v72 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v71
    v72
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v73 : string = @$"format!(""{{}}"", $0)"
    let v74 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v73
    v74
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v75 : string = @$"format!(""{{}}"", $0)"
    let v76 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v75
    v76
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v77 : std_string_String = null |> unbox<std_string_String>
    v77
#endif
    
#if FABLE_COMPILER_PYTHON
    let v78 : std_string_String = null |> unbox<std_string_String>
    v78
#endif
    
#else
    let v79 : std_string_String = null |> unbox<std_string_String>
    v79
#endif
    |> fun x -> _v69 <- Some x
    let v80 : std_string_String = _v69.Value
    let v81 : string = "fable_library_rust::String_::fromString($0)"
    let v82 : string = Fable.Core.RustInterop.emitRustExpr v80 v81
    v82
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v83 : string = null |> unbox<string>
    v83
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v84 : string = null |> unbox<string>
    v84
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v85 : IPathJoin = Fable.Core.JsInterop.importAll v39
    let v86 : string = method19(v50)
    let v87 : string = method24()
    let v88 : string = "v85.join(v86, v87)"
    let v89 : string = Fable.Core.JsInterop.emitJsExpr () v88
    v89
#endif
    
#if FABLE_COMPILER_PYTHON
    let v90 : string = null |> unbox<string>
    v90
#endif
    
#else
    let v91 : string = System.IO.Path.Combine (v50, v46)
    v91
#endif
    |> fun x -> _v51 <- Some x
    let v92 : string = _v51.Value
    let v93 : string option = None
    let v94 : bool = true in let mutable _v93 = v93
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v95 : string = method25(v3)
    let v96 : string = method18(v95)
    let v97 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v98 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v96 v97
    let v99 : string = "String::from($0)"
    let v100 : std_string_String = Fable.Core.RustInterop.emitRustExpr v98 v99
    let v101 : string = "std::path::PathBuf::from($0)"
    let v102 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v100 v101
    let v103 : string = "$0.exists()"
    let v104 : bool = Fable.Core.RustInterop.emitRustExpr v102 v103
    let v105 : bool = v104 = false
    let v308 : string =
        if v105 then
            let v106 : string option = None
            let v107 : bool = true in let mutable _v106 = v106
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v108 : string = "std::env::current_dir()"
            let v109 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v108
            let v110 : string = "$0.unwrap()"
            let v111 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v109 v110
            let v112 : string = "$0.display()"
            let v113 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v111 v112
            let v114 : std_string_String option = None
            let v115 : bool = true in let mutable _v114 = v114
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v116 : string = @$"format!(""{{}}"", $0)"
            let v117 : std_string_String = Fable.Core.RustInterop.emitRustExpr v113 v116
            v117
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v118 : string = @$"format!(""{{}}"", $0)"
            let v119 : std_string_String = Fable.Core.RustInterop.emitRustExpr v113 v118
            v119
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v120 : string = @$"format!(""{{}}"", $0)"
            let v121 : std_string_String = Fable.Core.RustInterop.emitRustExpr v113 v120
            v121
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v122 : std_string_String = null |> unbox<std_string_String>
            v122
#endif
            
#if FABLE_COMPILER_PYTHON
            let v123 : std_string_String = null |> unbox<std_string_String>
            v123
#endif
            
#else
            let v124 : std_string_String = null |> unbox<std_string_String>
            v124
#endif
            |> fun x -> _v114 <- Some x
            let v125 : std_string_String = _v114.Value
            let v126 : string = "fable_library_rust::String_::fromString($0)"
            let v127 : string = Fable.Core.RustInterop.emitRustExpr v125 v126
            v127
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v128 : string = null |> unbox<string>
            v128
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v129 : string = null |> unbox<string>
            v129
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v130 : string = null |> unbox<string>
            v130
#endif
            
#if FABLE_COMPILER_PYTHON
            let v131 : string = null |> unbox<string>
            v131
#endif
            
#else
            let v132 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v133 : string = v132 ()
            v133
#endif
            |> fun x -> _v106 <- Some x
            let v134 : string = _v106.Value
            let v135 : string option = None
            let v136 : bool = true in let mutable _v135 = v135
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v137 : string = method18(v134)
            let v138 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v137 v138
            let v140 : string = "String::from($0)"
            let v141 : std_string_String = Fable.Core.RustInterop.emitRustExpr v139 v140
            let v142 : string = "std::path::PathBuf::from($0)"
            let v143 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v141 v142
            let v144 : string = method18(v95)
            let v145 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v146 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v144 v145
            let v147 : string = "String::from($0)"
            let v148 : std_string_String = Fable.Core.RustInterop.emitRustExpr v146 v147
            let v149 : string = "$0.join($1)"
            let v150 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v143, v148) v149
            let v151 : string = "$0.display()"
            let v152 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v150 v151
            let v153 : std_string_String option = None
            let v154 : bool = true in let mutable _v153 = v153
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v155 : string = @$"format!(""{{}}"", $0)"
            let v156 : std_string_String = Fable.Core.RustInterop.emitRustExpr v152 v155
            v156
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v157 : string = @$"format!(""{{}}"", $0)"
            let v158 : std_string_String = Fable.Core.RustInterop.emitRustExpr v152 v157
            v158
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v159 : string = @$"format!(""{{}}"", $0)"
            let v160 : std_string_String = Fable.Core.RustInterop.emitRustExpr v152 v159
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
            |> fun x -> _v153 <- Some x
            let v164 : std_string_String = _v153.Value
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
            let v169 : IPathJoin = Fable.Core.JsInterop.importAll v39
            let v170 : string = method19(v134)
            let v171 : string = method20(v95)
            let v172 : string = "v169.join(v170, v171)"
            let v173 : string = Fable.Core.JsInterop.emitJsExpr () v172
            v173
#endif
            
#if FABLE_COMPILER_PYTHON
            let v174 : string = null |> unbox<string>
            v174
#endif
            
#else
            let v175 : string = System.IO.Path.Combine (v134, v95)
            v175
#endif
            |> fun x -> _v135 <- Some x
            let v176 : string = _v135.Value
            let v177 : bool option = None
            let v178 : bool = true in let mutable _v177 = v177
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v179 : string = "cfg!(windows)"
            let v180 : bool = Fable.Core.RustInterop.emitRustExpr () v179
            v180
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v181 : bool = null |> unbox<bool>
            v181
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v182 : bool = null |> unbox<bool>
            v182
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v183 : bool = null |> unbox<bool>
            v183
#endif
            
#if FABLE_COMPILER_PYTHON
            let v184 : bool = null |> unbox<bool>
            v184
#endif
            
#else
            let v185 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v186 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v187 : bool = v186 v185
            v187
#endif
            |> fun x -> _v177 <- Some x
            let v188 : bool = _v177.Value
            let v189 : bool = v188 = false
            let v213 : string =
                if v189 then
                    v176
                else
                    let v190 : string option = None
                    let v191 : bool = true in let mutable _v190 = v190
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v192 : string = method26()
                    let v193 : string = method27(v176)
                    let v194 : string = method28()
                    let v195 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v196 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v192, v193, v194) v195
                    let v197 : string = "String::from($0)"
                    let v198 : std_string_String = Fable.Core.RustInterop.emitRustExpr v196 v197
                    let v199 : string = "fable_library_rust::String_::fromString($0)"
                    let v200 : string = Fable.Core.RustInterop.emitRustExpr v198 v199
                    v200
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v201 : string = null |> unbox<string>
                    v201
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v202 : string = null |> unbox<string>
                    v202
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v203 : string = null |> unbox<string>
                    v203
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v204 : string = null |> unbox<string>
                    v204
#endif
                    
#else
                    let v205 : string = "^\\\\\\\\\\?\\\\"
                    let v206 : string = ""
                    let v207 : string = System.Text.RegularExpressions.Regex.Replace (v176, v205, v206)
                    v207
#endif
                    |> fun x -> _v190 <- Some x
                    let v208 : string = _v190.Value
                    let v209 : string = $"{v208.[0] |> string |> _.ToLower()}{v208.[1..]}"
                    let v210 : string = "\\"
                    let v211 : string = "/"
                    let v212 : string = v209.Replace (v210, v211)
                    v212
            let v214 : string = "/"
            let v215 : (string []) = v213.Split v214
            let v216 : (string []) = [||]
            let v217 : int32 = v215.Length
            let v218 : Mut4 = {l0 = 0; l1 = 0; l2 = v216} : Mut4
            while method29(v217, v218) do
                let v220 : int32 = v218.l0
                let v221 : int32 =  -v220
                let v222 : int32 = v221 + v217
                let v223 : int32 = v222 - 1
                let struct (v224 : int32, v225 : (string [])) = v218.l1, v218.l2
                let v226 : string = v215.[int v223]
                let v227 : bool = ".." = v226
                let struct (v266 : int32, v267 : (string [])) =
                    if v227 then
                        let v228 : int32 = v224 + 1
                        struct (v228, v225)
                    else
                        let v229 : bool = 0 = v224
                        if v229 then
                            let v230 : string = ":"
                            let v231 : bool = v226.EndsWith v230
                            if v231 then
                                let v232 : string = $"{v134.[0]}:"
                                let v233 : (string []) = [|v232|]
                                let v234 : int32 = v233.Length
                                let v235 : int32 = v225.Length
                                let v236 : int32 = v234 + v235
                                let v237 : (string []) = Array.zeroCreate<string> (v236)
                                let v238 : Mut5 = {l0 = 0} : Mut5
                                while method30(v236, v238) do
                                    let v240 : int32 = v238.l0
                                    let v241 : bool = v240 < v234
                                    let v245 : string =
                                        if v241 then
                                            let v242 : string = v233.[int v240]
                                            v242
                                        else
                                            let v243 : int32 = v240 - v234
                                            let v244 : string = v225.[int v243]
                                            v244
                                    v237.[int v240] <- v245
                                    let v246 : int32 = v240 + 1
                                    v238.l0 <- v246
                                    ()
                                struct (0, v237)
                            else
                                let v247 : (string []) = [|v226|]
                                let v248 : int32 = v247.Length
                                let v249 : int32 = v225.Length
                                let v250 : int32 = v248 + v249
                                let v251 : (string []) = Array.zeroCreate<string> (v250)
                                let v252 : Mut5 = {l0 = 0} : Mut5
                                while method30(v250, v252) do
                                    let v254 : int32 = v252.l0
                                    let v255 : bool = v254 < v248
                                    let v259 : string =
                                        if v255 then
                                            let v256 : string = v247.[int v254]
                                            v256
                                        else
                                            let v257 : int32 = v254 - v248
                                            let v258 : string = v225.[int v257]
                                            v258
                                    v251.[int v254] <- v259
                                    let v260 : int32 = v254 + 1
                                    v252.l0 <- v260
                                    ()
                                struct (0, v251)
                        else
                            let v263 : int32 = v224 - 1
                            struct (v263, v225)
                let v268 : int32 = v220 + 1
                v218.l0 <- v268
                v218.l1 <- v266
                v218.l2 <- v267
                ()
            let struct (v269 : int32, v270 : (string [])) = v218.l1, v218.l2
            let v271 : string seq = seq { for i = 0 to v270.Length - 1 do yield v270.[i] }
            let v272 : char option = None
            let v273 : bool = true in let mutable _v272 = v272
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v274 : string = "std::path::MAIN_SEPARATOR"
            let v275 : char = Fable.Core.RustInterop.emitRustExpr () v274
            v275
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v276 : char = null |> unbox<char>
            v276
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v277 : char = null |> unbox<char>
            v277
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v278 : char = null |> unbox<char>
            v278
#endif
            
#if FABLE_COMPILER_PYTHON
            let v279 : char = null |> unbox<char>
            v279
#endif
            
#else
            let v280 : char = System.IO.Path.DirectorySeparatorChar
            v280
#endif
            |> fun x -> _v272 <- Some x
            let v281 : char = _v272.Value
            let v282 : (char -> string) = _.ToString()
            let v283 : string = v282 v281
            let v284 : string = method31(v283)
            let v285 : (string -> (string seq -> string)) = String.concat
            let v286 : (string seq -> string) = v285 v284
            v286 v271
        else
            let v288 : string = "std::fs::canonicalize(&*$0)"
            let v289 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v95 v288
            let v290 : string = "$0.unwrap()"
            let v291 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v289 v290
            let v292 : string = "$0.display()"
            let v293 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v291 v292
            let v294 : std_string_String option = None
            let v295 : bool = true in let mutable _v294 = v294
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v296 : string = @$"format!(""{{}}"", $0)"
            let v297 : std_string_String = Fable.Core.RustInterop.emitRustExpr v293 v296
            v297
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v298 : string = @$"format!(""{{}}"", $0)"
            let v299 : std_string_String = Fable.Core.RustInterop.emitRustExpr v293 v298
            v299
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v300 : string = @$"format!(""{{}}"", $0)"
            let v301 : std_string_String = Fable.Core.RustInterop.emitRustExpr v293 v300
            v301
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v302 : std_string_String = null |> unbox<std_string_String>
            v302
#endif
            
#if FABLE_COMPILER_PYTHON
            let v303 : std_string_String = null |> unbox<std_string_String>
            v303
#endif
            
#else
            let v304 : std_string_String = null |> unbox<std_string_String>
            v304
#endif
            |> fun x -> _v294 <- Some x
            let v305 : std_string_String = _v294.Value
            let v306 : string = "fable_library_rust::String_::fromString($0)"
            let v307 : string = Fable.Core.RustInterop.emitRustExpr v305 v306
            v307
    v308
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v309 : string = null |> unbox<string>
    v309
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v310 : string = null |> unbox<string>
    v310
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v311 : string = null |> unbox<string>
    v311
#endif
    
#if FABLE_COMPILER_PYTHON
    let v312 : string = null |> unbox<string>
    v312
#endif
    
#else
    let v313 : string = method32(v3)
    let v314 : (string -> string) = System.IO.Path.GetFullPath
    let v315 : string = v314 v313
    v315
#endif
    |> fun x -> _v93 <- Some x
    let v316 : string = _v93.Value
    let v317 : string option = None
    let v318 : bool = true in let mutable _v317 = v317
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v319 : string = method25(v2)
    let v320 : string = method18(v319)
    let v321 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v322 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v320 v321
    let v323 : string = "String::from($0)"
    let v324 : std_string_String = Fable.Core.RustInterop.emitRustExpr v322 v323
    let v325 : string = "std::path::PathBuf::from($0)"
    let v326 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v324 v325
    let v327 : string = "$0.exists()"
    let v328 : bool = Fable.Core.RustInterop.emitRustExpr v326 v327
    let v329 : bool = v328 = false
    let v532 : string =
        if v329 then
            let v330 : string option = None
            let v331 : bool = true in let mutable _v330 = v330
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v332 : string = "std::env::current_dir()"
            let v333 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v332
            let v334 : string = "$0.unwrap()"
            let v335 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v333 v334
            let v336 : string = "$0.display()"
            let v337 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v335 v336
            let v338 : std_string_String option = None
            let v339 : bool = true in let mutable _v338 = v338
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v340 : string = @$"format!(""{{}}"", $0)"
            let v341 : std_string_String = Fable.Core.RustInterop.emitRustExpr v337 v340
            v341
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v342 : string = @$"format!(""{{}}"", $0)"
            let v343 : std_string_String = Fable.Core.RustInterop.emitRustExpr v337 v342
            v343
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v344 : string = @$"format!(""{{}}"", $0)"
            let v345 : std_string_String = Fable.Core.RustInterop.emitRustExpr v337 v344
            v345
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v346 : std_string_String = null |> unbox<std_string_String>
            v346
#endif
            
#if FABLE_COMPILER_PYTHON
            let v347 : std_string_String = null |> unbox<std_string_String>
            v347
#endif
            
#else
            let v348 : std_string_String = null |> unbox<std_string_String>
            v348
#endif
            |> fun x -> _v338 <- Some x
            let v349 : std_string_String = _v338.Value
            let v350 : string = "fable_library_rust::String_::fromString($0)"
            let v351 : string = Fable.Core.RustInterop.emitRustExpr v349 v350
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
            let v356 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v357 : string = v356 ()
            v357
#endif
            |> fun x -> _v330 <- Some x
            let v358 : string = _v330.Value
            let v359 : string option = None
            let v360 : bool = true in let mutable _v359 = v359
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v361 : string = method18(v358)
            let v362 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v363 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v361 v362
            let v364 : string = "String::from($0)"
            let v365 : std_string_String = Fable.Core.RustInterop.emitRustExpr v363 v364
            let v366 : string = "std::path::PathBuf::from($0)"
            let v367 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v365 v366
            let v368 : string = method18(v319)
            let v369 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v370 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v368 v369
            let v371 : string = "String::from($0)"
            let v372 : std_string_String = Fable.Core.RustInterop.emitRustExpr v370 v371
            let v373 : string = "$0.join($1)"
            let v374 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v367, v372) v373
            let v375 : string = "$0.display()"
            let v376 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v374 v375
            let v377 : std_string_String option = None
            let v378 : bool = true in let mutable _v377 = v377
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v379 : string = @$"format!(""{{}}"", $0)"
            let v380 : std_string_String = Fable.Core.RustInterop.emitRustExpr v376 v379
            v380
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v381 : string = @$"format!(""{{}}"", $0)"
            let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr v376 v381
            v382
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v383 : string = @$"format!(""{{}}"", $0)"
            let v384 : std_string_String = Fable.Core.RustInterop.emitRustExpr v376 v383
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
            |> fun x -> _v377 <- Some x
            let v388 : std_string_String = _v377.Value
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
            let v393 : IPathJoin = Fable.Core.JsInterop.importAll v39
            let v394 : string = method19(v358)
            let v395 : string = method20(v319)
            let v396 : string = "v393.join(v394, v395)"
            let v397 : string = Fable.Core.JsInterop.emitJsExpr () v396
            v397
#endif
            
#if FABLE_COMPILER_PYTHON
            let v398 : string = null |> unbox<string>
            v398
#endif
            
#else
            let v399 : string = System.IO.Path.Combine (v358, v319)
            v399
#endif
            |> fun x -> _v359 <- Some x
            let v400 : string = _v359.Value
            let v401 : bool option = None
            let v402 : bool = true in let mutable _v401 = v401
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v403 : string = "cfg!(windows)"
            let v404 : bool = Fable.Core.RustInterop.emitRustExpr () v403
            v404
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v405 : bool = null |> unbox<bool>
            v405
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v406 : bool = null |> unbox<bool>
            v406
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v407 : bool = null |> unbox<bool>
            v407
#endif
            
#if FABLE_COMPILER_PYTHON
            let v408 : bool = null |> unbox<bool>
            v408
#endif
            
#else
            let v409 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v410 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v411 : bool = v410 v409
            v411
#endif
            |> fun x -> _v401 <- Some x
            let v412 : bool = _v401.Value
            let v413 : bool = v412 = false
            let v437 : string =
                if v413 then
                    v400
                else
                    let v414 : string option = None
                    let v415 : bool = true in let mutable _v414 = v414
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v416 : string = method26()
                    let v417 : string = method27(v400)
                    let v418 : string = method28()
                    let v419 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v420 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v416, v417, v418) v419
                    let v421 : string = "String::from($0)"
                    let v422 : std_string_String = Fable.Core.RustInterop.emitRustExpr v420 v421
                    let v423 : string = "fable_library_rust::String_::fromString($0)"
                    let v424 : string = Fable.Core.RustInterop.emitRustExpr v422 v423
                    v424
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v425 : string = null |> unbox<string>
                    v425
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v426 : string = null |> unbox<string>
                    v426
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v427 : string = null |> unbox<string>
                    v427
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v428 : string = null |> unbox<string>
                    v428
#endif
                    
#else
                    let v429 : string = "^\\\\\\\\\\?\\\\"
                    let v430 : string = ""
                    let v431 : string = System.Text.RegularExpressions.Regex.Replace (v400, v429, v430)
                    v431
#endif
                    |> fun x -> _v414 <- Some x
                    let v432 : string = _v414.Value
                    let v433 : string = $"{v432.[0] |> string |> _.ToLower()}{v432.[1..]}"
                    let v434 : string = "\\"
                    let v435 : string = "/"
                    let v436 : string = v433.Replace (v434, v435)
                    v436
            let v438 : string = "/"
            let v439 : (string []) = v437.Split v438
            let v440 : (string []) = [||]
            let v441 : int32 = v439.Length
            let v442 : Mut4 = {l0 = 0; l1 = 0; l2 = v440} : Mut4
            while method29(v441, v442) do
                let v444 : int32 = v442.l0
                let v445 : int32 =  -v444
                let v446 : int32 = v445 + v441
                let v447 : int32 = v446 - 1
                let struct (v448 : int32, v449 : (string [])) = v442.l1, v442.l2
                let v450 : string = v439.[int v447]
                let v451 : bool = ".." = v450
                let struct (v490 : int32, v491 : (string [])) =
                    if v451 then
                        let v452 : int32 = v448 + 1
                        struct (v452, v449)
                    else
                        let v453 : bool = 0 = v448
                        if v453 then
                            let v454 : string = ":"
                            let v455 : bool = v450.EndsWith v454
                            if v455 then
                                let v456 : string = $"{v358.[0]}:"
                                let v457 : (string []) = [|v456|]
                                let v458 : int32 = v457.Length
                                let v459 : int32 = v449.Length
                                let v460 : int32 = v458 + v459
                                let v461 : (string []) = Array.zeroCreate<string> (v460)
                                let v462 : Mut5 = {l0 = 0} : Mut5
                                while method30(v460, v462) do
                                    let v464 : int32 = v462.l0
                                    let v465 : bool = v464 < v458
                                    let v469 : string =
                                        if v465 then
                                            let v466 : string = v457.[int v464]
                                            v466
                                        else
                                            let v467 : int32 = v464 - v458
                                            let v468 : string = v449.[int v467]
                                            v468
                                    v461.[int v464] <- v469
                                    let v470 : int32 = v464 + 1
                                    v462.l0 <- v470
                                    ()
                                struct (0, v461)
                            else
                                let v471 : (string []) = [|v450|]
                                let v472 : int32 = v471.Length
                                let v473 : int32 = v449.Length
                                let v474 : int32 = v472 + v473
                                let v475 : (string []) = Array.zeroCreate<string> (v474)
                                let v476 : Mut5 = {l0 = 0} : Mut5
                                while method30(v474, v476) do
                                    let v478 : int32 = v476.l0
                                    let v479 : bool = v478 < v472
                                    let v483 : string =
                                        if v479 then
                                            let v480 : string = v471.[int v478]
                                            v480
                                        else
                                            let v481 : int32 = v478 - v472
                                            let v482 : string = v449.[int v481]
                                            v482
                                    v475.[int v478] <- v483
                                    let v484 : int32 = v478 + 1
                                    v476.l0 <- v484
                                    ()
                                struct (0, v475)
                        else
                            let v487 : int32 = v448 - 1
                            struct (v487, v449)
                let v492 : int32 = v444 + 1
                v442.l0 <- v492
                v442.l1 <- v490
                v442.l2 <- v491
                ()
            let struct (v493 : int32, v494 : (string [])) = v442.l1, v442.l2
            let v495 : string seq = seq { for i = 0 to v494.Length - 1 do yield v494.[i] }
            let v496 : char option = None
            let v497 : bool = true in let mutable _v496 = v496
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v498 : string = "std::path::MAIN_SEPARATOR"
            let v499 : char = Fable.Core.RustInterop.emitRustExpr () v498
            v499
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v500 : char = null |> unbox<char>
            v500
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v501 : char = null |> unbox<char>
            v501
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v502 : char = null |> unbox<char>
            v502
#endif
            
#if FABLE_COMPILER_PYTHON
            let v503 : char = null |> unbox<char>
            v503
#endif
            
#else
            let v504 : char = System.IO.Path.DirectorySeparatorChar
            v504
#endif
            |> fun x -> _v496 <- Some x
            let v505 : char = _v496.Value
            let v506 : (char -> string) = _.ToString()
            let v507 : string = v506 v505
            let v508 : string = method31(v507)
            let v509 : (string -> (string seq -> string)) = String.concat
            let v510 : (string seq -> string) = v509 v508
            v510 v495
        else
            let v512 : string = "std::fs::canonicalize(&*$0)"
            let v513 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v319 v512
            let v514 : string = "$0.unwrap()"
            let v515 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v513 v514
            let v516 : string = "$0.display()"
            let v517 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v515 v516
            let v518 : std_string_String option = None
            let v519 : bool = true in let mutable _v518 = v518
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v520 : string = @$"format!(""{{}}"", $0)"
            let v521 : std_string_String = Fable.Core.RustInterop.emitRustExpr v517 v520
            v521
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v522 : string = @$"format!(""{{}}"", $0)"
            let v523 : std_string_String = Fable.Core.RustInterop.emitRustExpr v517 v522
            v523
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v524 : string = @$"format!(""{{}}"", $0)"
            let v525 : std_string_String = Fable.Core.RustInterop.emitRustExpr v517 v524
            v525
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v526 : std_string_String = null |> unbox<std_string_String>
            v526
#endif
            
#if FABLE_COMPILER_PYTHON
            let v527 : std_string_String = null |> unbox<std_string_String>
            v527
#endif
            
#else
            let v528 : std_string_String = null |> unbox<std_string_String>
            v528
#endif
            |> fun x -> _v518 <- Some x
            let v529 : std_string_String = _v518.Value
            let v530 : string = "fable_library_rust::String_::fromString($0)"
            let v531 : string = Fable.Core.RustInterop.emitRustExpr v529 v530
            v531
    v532
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v533 : string = null |> unbox<string>
    v533
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v534 : string = null |> unbox<string>
    v534
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v535 : string = null |> unbox<string>
    v535
#endif
    
#if FABLE_COMPILER_PYTHON
    let v536 : string = null |> unbox<string>
    v536
#endif
    
#else
    let v537 : string = method32(v2)
    let v538 : (string -> string) = System.IO.Path.GetFullPath
    let v539 : string = v538 v537
    v539
#endif
    |> fun x -> _v317 <- Some x
    let v540 : string = _v317.Value
    let v541 : string option = None
    let v542 : bool = true in let mutable _v541 = v541
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v543 : string = method25(v1)
    let v544 : string = method18(v543)
    let v545 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v546 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v544 v545
    let v547 : string = "String::from($0)"
    let v548 : std_string_String = Fable.Core.RustInterop.emitRustExpr v546 v547
    let v549 : string = "std::path::PathBuf::from($0)"
    let v550 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v548 v549
    let v551 : string = "$0.exists()"
    let v552 : bool = Fable.Core.RustInterop.emitRustExpr v550 v551
    let v553 : bool = v552 = false
    let v756 : string =
        if v553 then
            let v554 : string option = None
            let v555 : bool = true in let mutable _v554 = v554
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v556 : string = "std::env::current_dir()"
            let v557 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v556
            let v558 : string = "$0.unwrap()"
            let v559 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v557 v558
            let v560 : string = "$0.display()"
            let v561 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v559 v560
            let v562 : std_string_String option = None
            let v563 : bool = true in let mutable _v562 = v562
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v564 : string = @$"format!(""{{}}"", $0)"
            let v565 : std_string_String = Fable.Core.RustInterop.emitRustExpr v561 v564
            v565
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v566 : string = @$"format!(""{{}}"", $0)"
            let v567 : std_string_String = Fable.Core.RustInterop.emitRustExpr v561 v566
            v567
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v568 : string = @$"format!(""{{}}"", $0)"
            let v569 : std_string_String = Fable.Core.RustInterop.emitRustExpr v561 v568
            v569
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v570 : std_string_String = null |> unbox<std_string_String>
            v570
#endif
            
#if FABLE_COMPILER_PYTHON
            let v571 : std_string_String = null |> unbox<std_string_String>
            v571
#endif
            
#else
            let v572 : std_string_String = null |> unbox<std_string_String>
            v572
#endif
            |> fun x -> _v562 <- Some x
            let v573 : std_string_String = _v562.Value
            let v574 : string = "fable_library_rust::String_::fromString($0)"
            let v575 : string = Fable.Core.RustInterop.emitRustExpr v573 v574
            v575
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v576 : string = null |> unbox<string>
            v576
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v577 : string = null |> unbox<string>
            v577
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v578 : string = null |> unbox<string>
            v578
#endif
            
#if FABLE_COMPILER_PYTHON
            let v579 : string = null |> unbox<string>
            v579
#endif
            
#else
            let v580 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v581 : string = v580 ()
            v581
#endif
            |> fun x -> _v554 <- Some x
            let v582 : string = _v554.Value
            let v583 : string option = None
            let v584 : bool = true in let mutable _v583 = v583
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v585 : string = method18(v582)
            let v586 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v585 v586
            let v588 : string = "String::from($0)"
            let v589 : std_string_String = Fable.Core.RustInterop.emitRustExpr v587 v588
            let v590 : string = "std::path::PathBuf::from($0)"
            let v591 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v589 v590
            let v592 : string = method18(v543)
            let v593 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v594 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v592 v593
            let v595 : string = "String::from($0)"
            let v596 : std_string_String = Fable.Core.RustInterop.emitRustExpr v594 v595
            let v597 : string = "$0.join($1)"
            let v598 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v591, v596) v597
            let v599 : string = "$0.display()"
            let v600 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v598 v599
            let v601 : std_string_String option = None
            let v602 : bool = true in let mutable _v601 = v601
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v603 : string = @$"format!(""{{}}"", $0)"
            let v604 : std_string_String = Fable.Core.RustInterop.emitRustExpr v600 v603
            v604
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v605 : string = @$"format!(""{{}}"", $0)"
            let v606 : std_string_String = Fable.Core.RustInterop.emitRustExpr v600 v605
            v606
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v607 : string = @$"format!(""{{}}"", $0)"
            let v608 : std_string_String = Fable.Core.RustInterop.emitRustExpr v600 v607
            v608
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v609 : std_string_String = null |> unbox<std_string_String>
            v609
#endif
            
#if FABLE_COMPILER_PYTHON
            let v610 : std_string_String = null |> unbox<std_string_String>
            v610
#endif
            
#else
            let v611 : std_string_String = null |> unbox<std_string_String>
            v611
#endif
            |> fun x -> _v601 <- Some x
            let v612 : std_string_String = _v601.Value
            let v613 : string = "fable_library_rust::String_::fromString($0)"
            let v614 : string = Fable.Core.RustInterop.emitRustExpr v612 v613
            v614
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v615 : string = null |> unbox<string>
            v615
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v616 : string = null |> unbox<string>
            v616
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v617 : IPathJoin = Fable.Core.JsInterop.importAll v39
            let v618 : string = method19(v582)
            let v619 : string = method20(v543)
            let v620 : string = "v617.join(v618, v619)"
            let v621 : string = Fable.Core.JsInterop.emitJsExpr () v620
            v621
#endif
            
#if FABLE_COMPILER_PYTHON
            let v622 : string = null |> unbox<string>
            v622
#endif
            
#else
            let v623 : string = System.IO.Path.Combine (v582, v543)
            v623
#endif
            |> fun x -> _v583 <- Some x
            let v624 : string = _v583.Value
            let v625 : bool option = None
            let v626 : bool = true in let mutable _v625 = v625
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v627 : string = "cfg!(windows)"
            let v628 : bool = Fable.Core.RustInterop.emitRustExpr () v627
            v628
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v629 : bool = null |> unbox<bool>
            v629
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v630 : bool = null |> unbox<bool>
            v630
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v631 : bool = null |> unbox<bool>
            v631
#endif
            
#if FABLE_COMPILER_PYTHON
            let v632 : bool = null |> unbox<bool>
            v632
#endif
            
#else
            let v633 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v634 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v635 : bool = v634 v633
            v635
#endif
            |> fun x -> _v625 <- Some x
            let v636 : bool = _v625.Value
            let v637 : bool = v636 = false
            let v661 : string =
                if v637 then
                    v624
                else
                    let v638 : string option = None
                    let v639 : bool = true in let mutable _v638 = v638
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v640 : string = method26()
                    let v641 : string = method27(v624)
                    let v642 : string = method28()
                    let v643 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v644 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v640, v641, v642) v643
                    let v645 : string = "String::from($0)"
                    let v646 : std_string_String = Fable.Core.RustInterop.emitRustExpr v644 v645
                    let v647 : string = "fable_library_rust::String_::fromString($0)"
                    let v648 : string = Fable.Core.RustInterop.emitRustExpr v646 v647
                    v648
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v649 : string = null |> unbox<string>
                    v649
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v650 : string = null |> unbox<string>
                    v650
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v651 : string = null |> unbox<string>
                    v651
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v652 : string = null |> unbox<string>
                    v652
#endif
                    
#else
                    let v653 : string = "^\\\\\\\\\\?\\\\"
                    let v654 : string = ""
                    let v655 : string = System.Text.RegularExpressions.Regex.Replace (v624, v653, v654)
                    v655
#endif
                    |> fun x -> _v638 <- Some x
                    let v656 : string = _v638.Value
                    let v657 : string = $"{v656.[0] |> string |> _.ToLower()}{v656.[1..]}"
                    let v658 : string = "\\"
                    let v659 : string = "/"
                    let v660 : string = v657.Replace (v658, v659)
                    v660
            let v662 : string = "/"
            let v663 : (string []) = v661.Split v662
            let v664 : (string []) = [||]
            let v665 : int32 = v663.Length
            let v666 : Mut4 = {l0 = 0; l1 = 0; l2 = v664} : Mut4
            while method29(v665, v666) do
                let v668 : int32 = v666.l0
                let v669 : int32 =  -v668
                let v670 : int32 = v669 + v665
                let v671 : int32 = v670 - 1
                let struct (v672 : int32, v673 : (string [])) = v666.l1, v666.l2
                let v674 : string = v663.[int v671]
                let v675 : bool = ".." = v674
                let struct (v714 : int32, v715 : (string [])) =
                    if v675 then
                        let v676 : int32 = v672 + 1
                        struct (v676, v673)
                    else
                        let v677 : bool = 0 = v672
                        if v677 then
                            let v678 : string = ":"
                            let v679 : bool = v674.EndsWith v678
                            if v679 then
                                let v680 : string = $"{v582.[0]}:"
                                let v681 : (string []) = [|v680|]
                                let v682 : int32 = v681.Length
                                let v683 : int32 = v673.Length
                                let v684 : int32 = v682 + v683
                                let v685 : (string []) = Array.zeroCreate<string> (v684)
                                let v686 : Mut5 = {l0 = 0} : Mut5
                                while method30(v684, v686) do
                                    let v688 : int32 = v686.l0
                                    let v689 : bool = v688 < v682
                                    let v693 : string =
                                        if v689 then
                                            let v690 : string = v681.[int v688]
                                            v690
                                        else
                                            let v691 : int32 = v688 - v682
                                            let v692 : string = v673.[int v691]
                                            v692
                                    v685.[int v688] <- v693
                                    let v694 : int32 = v688 + 1
                                    v686.l0 <- v694
                                    ()
                                struct (0, v685)
                            else
                                let v695 : (string []) = [|v674|]
                                let v696 : int32 = v695.Length
                                let v697 : int32 = v673.Length
                                let v698 : int32 = v696 + v697
                                let v699 : (string []) = Array.zeroCreate<string> (v698)
                                let v700 : Mut5 = {l0 = 0} : Mut5
                                while method30(v698, v700) do
                                    let v702 : int32 = v700.l0
                                    let v703 : bool = v702 < v696
                                    let v707 : string =
                                        if v703 then
                                            let v704 : string = v695.[int v702]
                                            v704
                                        else
                                            let v705 : int32 = v702 - v696
                                            let v706 : string = v673.[int v705]
                                            v706
                                    v699.[int v702] <- v707
                                    let v708 : int32 = v702 + 1
                                    v700.l0 <- v708
                                    ()
                                struct (0, v699)
                        else
                            let v711 : int32 = v672 - 1
                            struct (v711, v673)
                let v716 : int32 = v668 + 1
                v666.l0 <- v716
                v666.l1 <- v714
                v666.l2 <- v715
                ()
            let struct (v717 : int32, v718 : (string [])) = v666.l1, v666.l2
            let v719 : string seq = seq { for i = 0 to v718.Length - 1 do yield v718.[i] }
            let v720 : char option = None
            let v721 : bool = true in let mutable _v720 = v720
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v722 : string = "std::path::MAIN_SEPARATOR"
            let v723 : char = Fable.Core.RustInterop.emitRustExpr () v722
            v723
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v724 : char = null |> unbox<char>
            v724
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v725 : char = null |> unbox<char>
            v725
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v726 : char = null |> unbox<char>
            v726
#endif
            
#if FABLE_COMPILER_PYTHON
            let v727 : char = null |> unbox<char>
            v727
#endif
            
#else
            let v728 : char = System.IO.Path.DirectorySeparatorChar
            v728
#endif
            |> fun x -> _v720 <- Some x
            let v729 : char = _v720.Value
            let v730 : (char -> string) = _.ToString()
            let v731 : string = v730 v729
            let v732 : string = method31(v731)
            let v733 : (string -> (string seq -> string)) = String.concat
            let v734 : (string seq -> string) = v733 v732
            v734 v719
        else
            let v736 : string = "std::fs::canonicalize(&*$0)"
            let v737 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v543 v736
            let v738 : string = "$0.unwrap()"
            let v739 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v737 v738
            let v740 : string = "$0.display()"
            let v741 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v739 v740
            let v742 : std_string_String option = None
            let v743 : bool = true in let mutable _v742 = v742
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v744 : string = @$"format!(""{{}}"", $0)"
            let v745 : std_string_String = Fable.Core.RustInterop.emitRustExpr v741 v744
            v745
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v746 : string = @$"format!(""{{}}"", $0)"
            let v747 : std_string_String = Fable.Core.RustInterop.emitRustExpr v741 v746
            v747
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v748 : string = @$"format!(""{{}}"", $0)"
            let v749 : std_string_String = Fable.Core.RustInterop.emitRustExpr v741 v748
            v749
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v750 : std_string_String = null |> unbox<std_string_String>
            v750
#endif
            
#if FABLE_COMPILER_PYTHON
            let v751 : std_string_String = null |> unbox<std_string_String>
            v751
#endif
            
#else
            let v752 : std_string_String = null |> unbox<std_string_String>
            v752
#endif
            |> fun x -> _v742 <- Some x
            let v753 : std_string_String = _v742.Value
            let v754 : string = "fable_library_rust::String_::fromString($0)"
            let v755 : string = Fable.Core.RustInterop.emitRustExpr v753 v754
            v755
    v756
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v757 : string = null |> unbox<string>
    v757
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v758 : string = null |> unbox<string>
    v758
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v759 : string = null |> unbox<string>
    v759
#endif
    
#if FABLE_COMPILER_PYTHON
    let v760 : string = null |> unbox<string>
    v760
#endif
    
#else
    let v761 : string = method32(v1)
    let v762 : (string -> string) = System.IO.Path.GetFullPath
    let v763 : string = v762 v761
    v763
#endif
    |> fun x -> _v541 <- Some x
    let v764 : string = _v541.Value
    let v765 : US0 = US0_1
    let v766 : (unit -> string) = closure12()
    let v767 : (unit -> string) = closure13(v0, v316, v540, v764)
    method3(v765, v766, v767)
    method33(v0, v92, v316, v540, v764)
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
