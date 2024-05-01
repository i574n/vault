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
and method72 (v0 : int32, v1 : Mut6) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method73 (v0 : string) : string =
    v0
and method74 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure58 (v0 : string) (v1 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : unit =
    let v2 : string = "$0.lock()"
    let v3 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "$0.unwrap()"
    let v5 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v3 v4
    let v6 : string = method73(v0)
    let v7 : string = "v6.as_bytes()"
    let v8 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : std_sync_MutexGuard<std_process_ChildStdin> = method74(v5)
    let v10 : string = "true; let mut v9 = v9"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : string = "true; std::io::Write::write_all(&mut *$0, v8).unwrap()"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr v9 v12
    ()
and method75 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method76 (v0 : string) : string =
    v0
and closure59 () () : string =
    let v0 : string = "documents.run / par_map / files_fn"
    v0
and closure60 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: %A{v1} / result: {v0} / {v2 ()}"
    v3
and method77 (v0 : string) : string =
    v0
and closure57 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : string) : US19 =
    let v5 : string = ".hangul.md"
    let v6 : bool = v1.EndsWith v5
    let v7 : string = ".md"
    let v8 : bool = v4.EndsWith v7
    let v9 : string = "."
    let v10 : int32 = v1.LastIndexOf v9
    let v11 : int32 = v10 - 1
    let v12 : string = v1.[int 0..int v11]
    let v13 : int32 = v0.LastIndexOf v9
    let v14 : int32 = v13 - 1
    let v15 : string = v0.[int 0..int v14]
    let v16 : bool = v8 = false
    let v19 : string =
        if v16 then
            let v17 : string = $"{v1}.{v4}"
            v17
        else
            let v18 : string = $"{v12}.{v4}"
            v18
    let v22 : string =
        if v16 then
            let v20 : string = $"{v0}.{v4}"
            v20
        else
            let v21 : string = $"{v15}.{v4}"
            v21
    let v23 : bool option = None
    let v24 : bool = true in let mutable _v23 = v23
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v25 : string = method14(v19)
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
    let v42 : bool = Fable.Core.JsInterop.emitJsExpr v19 v41
    v42
#endif
    
#if FABLE_COMPILER_PYTHON
    let v43 : bool = null |> unbox<bool>
    v43
#endif
    
#else
    let v44 : (string -> bool) = System.IO.File.Exists
    let v45 : bool = v44 v19
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
            let v49 : string = method14(v22)
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
                    v19
                else
                    let v84 : string option = None
                    let v85 : bool = true in let mutable _v84 = v84
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v86 : string = method22()
                    let v87 : string = method23(v19)
                    let v88 : string = method24()
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
                    let v101 : string = System.Text.RegularExpressions.Regex.Replace (v19, v99, v100)
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
            let v116 : string = method38(v109, v113, v110, v111, v112, v108)
            let struct (v117 : string, v118 : string) = method39()
            let v119 : int32 = v116.Length
            let v120 : (char []) = Array.zeroCreate<char> (v119)
            let v121 : Mut5 = {l0 = 0} : Mut5
            while method26(v119, v121) do
                let v123 : int32 = v121.l0
                let v124 : char = v116.[int v123]
                v120.[int v123] <- v124
                let v125 : int32 = v123 + 1
                v121.l0 <- v125
                ()
            let v126 : ((char []) -> char list) = Array.toList
            let v127 : char list = v126 v120
            let v128 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v129 : (char -> (UH0 -> UH0)) = method40()
            let v130 : (char list -> (UH0 -> UH0)) = v128 v129
            let v131 : (UH0 -> UH0) = v130 v127
            let v132 : UH0 = UH0_0
            let v133 : UH0 = v131 v132
            let v134 : US8 = US8_0
            let struct (v135 : string, v136 : string) = method41(v118, v117, v133, v134)
            let v137 : (string []) = method42(v136)
            let v138 : string = "$0.to_vec()"
            let v139 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v137 v138
            let v140 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v141 : (string -> std_string_String) = closure28()
            let v142 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v139, v141) v140
            let v143 : US0 = US0_1
            let v144 : (unit -> string) = closure29(v109, v113, v110, v111, v112, v108, v135, v142)
            let v145 : (unit -> string) = method47()
            method3(v143, v144, v145)
            let v146 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v109, v113, v110, v111, v112, v108, v135, v142)
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
            let struct (v174 : string, v175 : string) = method39()
            let v176 : int32 = v113.Length
            let v177 : (char []) = Array.zeroCreate<char> (v176)
            let v178 : Mut5 = {l0 = 0} : Mut5
            while method26(v176, v178) do
                let v180 : int32 = v178.l0
                let v181 : char = v113.[int v180]
                v177.[int v180] <- v181
                let v182 : int32 = v180 + 1
                v178.l0 <- v182
                ()
            let v183 : ((char []) -> char list) = Array.toList
            let v184 : char list = v183 v177
            let v185 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v186 : (char -> (UH0 -> UH0)) = method40()
            let v187 : (char list -> (UH0 -> UH0)) = v185 v186
            let v188 : (UH0 -> UH0) = v187 v184
            let v189 : UH0 = UH0_0
            let v190 : UH0 = v188 v189
            let v191 : US8 = US8_0
            let struct (v192 : string, v193 : string) = method41(v175, v174, v190, v191)
            let v194 : (string -> US4) = method19()
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
            let v203 : (unit -> string) = method47()
            method3(v201, v202, v203)
            let v204 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v205 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v193, StandardOutputEncoding = v204, WorkingDirectory = v200, FileName = v192, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v206 : int32 = v110.Length
            let v207 : Mut5 = {l0 = 0} : Mut5
            while method26(v206, v207) do
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
            let v225 : (System.Threading.CancellationToken -> US18) = method70()
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
            let v296 : (unit -> string) = method47()
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
            let v302 : string = method71()
            let v303 : (string -> (string seq -> string)) = String.concat
            let v304 : (string seq -> string) = v303 v302
            let v305 : string = v304 v301
            let v306 : US0 = US0_1
            let v307 : (unit -> string) = closure56(v299, v305)
            let v308 : (unit -> string) = method47()
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
                    let v346 : string = method22()
                    let v347 : string = method23(v22)
                    let v348 : string = method24()
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
            let v376 : string = method38(v369, v373, v370, v371, v372, v368)
            let struct (v377 : string, v378 : string) = method39()
            let v379 : int32 = v376.Length
            let v380 : (char []) = Array.zeroCreate<char> (v379)
            let v381 : Mut5 = {l0 = 0} : Mut5
            while method26(v379, v381) do
                let v383 : int32 = v381.l0
                let v384 : char = v376.[int v383]
                v380.[int v383] <- v384
                let v385 : int32 = v383 + 1
                v381.l0 <- v385
                ()
            let v386 : ((char []) -> char list) = Array.toList
            let v387 : char list = v386 v380
            let v388 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v389 : (char -> (UH0 -> UH0)) = method40()
            let v390 : (char list -> (UH0 -> UH0)) = v388 v389
            let v391 : (UH0 -> UH0) = v390 v387
            let v392 : UH0 = UH0_0
            let v393 : UH0 = v391 v392
            let v394 : US8 = US8_0
            let struct (v395 : string, v396 : string) = method41(v378, v377, v393, v394)
            let v397 : (string []) = method42(v396)
            let v398 : string = "$0.to_vec()"
            let v399 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v397 v398
            let v400 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v401 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v399, v141) v400
            let v402 : US0 = US0_1
            let v403 : (unit -> string) = closure29(v369, v373, v370, v371, v372, v368, v395, v401)
            let v404 : (unit -> string) = method47()
            method3(v402, v403, v404)
            let v405 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v369, v373, v370, v371, v372, v368, v395, v401)
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
            let struct (v433 : string, v434 : string) = method39()
            let v435 : int32 = v373.Length
            let v436 : (char []) = Array.zeroCreate<char> (v435)
            let v437 : Mut5 = {l0 = 0} : Mut5
            while method26(v435, v437) do
                let v439 : int32 = v437.l0
                let v440 : char = v373.[int v439]
                v436.[int v439] <- v440
                let v441 : int32 = v439 + 1
                v437.l0 <- v441
                ()
            let v442 : ((char []) -> char list) = Array.toList
            let v443 : char list = v442 v436
            let v444 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v445 : (char -> (UH0 -> UH0)) = method40()
            let v446 : (char list -> (UH0 -> UH0)) = v444 v445
            let v447 : (UH0 -> UH0) = v446 v443
            let v448 : UH0 = UH0_0
            let v449 : UH0 = v447 v448
            let v450 : US8 = US8_0
            let struct (v451 : string, v452 : string) = method41(v434, v433, v449, v450)
            let v453 : (string -> US4) = method19()
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
            let v462 : (unit -> string) = method47()
            method3(v460, v461, v462)
            let v463 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v464 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v452, StandardOutputEncoding = v463, WorkingDirectory = v459, FileName = v451, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v465 : int32 = v370.Length
            let v466 : Mut5 = {l0 = 0} : Mut5
            while method26(v465, v466) do
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
            let v484 : (System.Threading.CancellationToken -> US18) = method70()
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
            let v555 : (unit -> string) = method47()
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
            let v561 : string = method71()
            let v562 : (string -> (string seq -> string)) = String.concat
            let v563 : (string seq -> string) = v562 v561
            let v564 : string = v563 v560
            let v565 : US0 = US0_1
            let v566 : (unit -> string) = closure56(v558, v564)
            let v567 : (unit -> string) = method47()
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
        let v593 : string option = None
        let v594 : bool = true in let mutable _v593 = v593
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v595 : Vec<uint8> option = None
        let v596 : bool = true in let mutable _v595 = v595
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v597 : string = "std::fs::read(&*$0).unwrap()"
        let v598 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1 v597
        v598
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v599 : Vec<uint8> = null |> unbox<Vec<uint8>>
        v599
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v600 : Vec<uint8> = null |> unbox<Vec<uint8>>
        v600
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v601 : Vec<uint8> = null |> unbox<Vec<uint8>>
        v601
#endif
        
#if FABLE_COMPILER_PYTHON
        let v602 : Vec<uint8> = null |> unbox<Vec<uint8>>
        v602
#endif
        
#else
        let v603 : (uint8 []) = v1 |> System.IO.File.ReadAllBytes
        let v604 : string = "$0.to_vec()"
        let v605 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v603 v604
        v605
#endif
        |> fun x -> _v595 <- Some x
        let v606 : Vec<uint8> = _v595.Value
        let v607 : string = "std::string::String::from_utf8(v606)"
        let v608 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v607
        let v609 : string = "$0.unwrap()"
        let v610 : std_string_String = Fable.Core.RustInterop.emitRustExpr v608 v609
        let v611 : string = "fable_library_rust::String_::fromString($0)"
        let v612 : string = Fable.Core.RustInterop.emitRustExpr v610 v611
        v612
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v613 : string = null |> unbox<string>
        v613
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v614 : string = null |> unbox<string>
        v614
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v615 : string = null |> unbox<string>
        v615
#endif
        
#if FABLE_COMPILER_PYTHON
        let v616 : string = null |> unbox<string>
        v616
#endif
        
#else
        let v617 : string = v1 |> System.IO.File.ReadAllText
        v617
#endif
        |> fun x -> _v593 <- Some x
        let v618 : string = _v593.Value
        let v619 : string = "\n"
        let v620 : (string []) = v618.Split v619
        let v621 : int32 = v620.Length
        let v622 : (string []) = Array.zeroCreate<string> (v621)
        let v623 : Mut5 = {l0 = 0} : Mut5
        while method26(v621, v623) do
            let v625 : int32 = v623.l0
            let v626 : string = v620.[int v625]
            let v627 : string = v626.Trim ()
            v622.[int v625] <- v627
            let v628 : int32 = v625 + 1
            v623.l0 <- v628
            ()
        let v629 : int32 = v622.Length
        let v630 : (string []) = Array.zeroCreate<string> (v629)
        let v631 : Mut6 = {l0 = 0; l1 = 0} : Mut6
        while method72(v629, v631) do
            let v633 : int32 = v631.l0
            let v634 : int32 = v631.l1
            let v635 : string = v622.[int v633]
            let v636 : string = ""
            let v637 : bool = v636 <> v635
            let v639 : int32 =
                if v637 then
                    v630.[int v634] <- v635
                    let v638 : int32 = v634 + 1
                    v638
                else
                    v634
            let v640 : int32 = v633 + 1
            v631.l0 <- v640
            v631.l1 <- v639
            ()
        let v641 : int32 = v631.l1
        let v642 : (string []) = Array.zeroCreate<string> (v641)
        let v643 : Mut5 = {l0 = 0} : Mut5
        while method26(v641, v643) do
            let v645 : int32 = v643.l0
            let v646 : string = v630.[int v645]
            v642.[int v645] <- v646
            let v647 : int32 = v645 + 1
            v643.l0 <- v647
            ()
        let v648 : string seq = seq { for i = 0 to v642.Length - 1 do yield v642.[i] }
        let v649 : string = method71()
        let v650 : (string -> (string seq -> string)) = String.concat
        let v651 : (string seq -> string) = v650 v649
        let v652 : string = v651 v648
        let v653 : string = $"{v652}

"
        let v654 : string option = None
        let v655 : System.Threading.CancellationToken option = None
        let v656 : (struct (string * string) []) = [||]
        let v657 : (struct (bool * string * int32) -> Async<unit>) option = None
        let v658 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
        let v659 : bool option = None
        let v660 : bool = true in let mutable _v659 = v659
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v661 : string = "cfg!(windows)"
        let v662 : bool = Fable.Core.RustInterop.emitRustExpr () v661
        v662
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v663 : bool = null |> unbox<bool>
        v663
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v664 : bool = null |> unbox<bool>
        v664
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v665 : bool = null |> unbox<bool>
        v665
#endif
        
#if FABLE_COMPILER_PYTHON
        let v666 : bool = null |> unbox<bool>
        v666
#endif
        
#else
        let v667 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
        let v668 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
        let v669 : bool = v668 v667
        v669
#endif
        |> fun x -> _v659 <- Some x
        let v670 : bool = _v659.Value
        let v673 : string =
            if v670 then
                let v671 : string = ".exe"
                v671
            else
                let v672 : string = ""
                v672
        let v674 : string = $"../vault/deps/hangulize/cmd/hangulize/hangulize{v673}"
        let v675 : string = method13(v3, v674)
        let v676 : string = $"{v675} {v2}"
        let v677 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = closure58(v653)
        let v678 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = Some v677 
        let v679 : struct (int32 * string) option = None
        let v680 : bool = true in let mutable _v679 = v679
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v681 : string = method38(v655, v676, v656, v657, v678, v654)
        let struct (v682 : string, v683 : string) = method39()
        let v684 : int32 = v681.Length
        let v685 : (char []) = Array.zeroCreate<char> (v684)
        let v686 : Mut5 = {l0 = 0} : Mut5
        while method26(v684, v686) do
            let v688 : int32 = v686.l0
            let v689 : char = v681.[int v688]
            v685.[int v688] <- v689
            let v690 : int32 = v688 + 1
            v686.l0 <- v690
            ()
        let v691 : ((char []) -> char list) = Array.toList
        let v692 : char list = v691 v685
        let v693 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
        let v694 : (char -> (UH0 -> UH0)) = method40()
        let v695 : (char list -> (UH0 -> UH0)) = v693 v694
        let v696 : (UH0 -> UH0) = v695 v692
        let v697 : UH0 = UH0_0
        let v698 : UH0 = v696 v697
        let v699 : US8 = US8_0
        let struct (v700 : string, v701 : string) = method41(v683, v682, v698, v699)
        let v702 : (string []) = method42(v701)
        let v703 : string = "$0.to_vec()"
        let v704 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v702 v703
        let v705 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
        let v706 : (string -> std_string_String) = closure28()
        let v707 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v704, v706) v705
        let v708 : US0 = US0_1
        let v709 : (unit -> string) = closure29(v655, v676, v656, v657, v678, v654, v700, v707)
        let v710 : (unit -> string) = method47()
        method3(v708, v709, v710)
        let v711 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v655, v676, v656, v657, v678, v654, v700, v707)
        let v712 : string = "futures_lite::future::block_on($0)"
        let v713 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v711 v712
        let (a, b) = v713
        let v714 : int32 = a
        let v715 : string = b
        struct (v714, v715)
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let struct (v716 : int32, v717 : string) = null |> unbox<struct (int32 * string)>
        struct (v716, v717)
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let struct (v718 : int32, v719 : string) = null |> unbox<struct (int32 * string)>
        struct (v718, v719)
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let struct (v720 : int32, v721 : string) = null |> unbox<struct (int32 * string)>
        struct (v720, v721)
#endif
        
#if FABLE_COMPILER_PYTHON
        let struct (v722 : int32, v723 : string) = null |> unbox<struct (int32 * string)>
        struct (v722, v723)
#endif
        
#else
        let v724 : Async<struct (int32 * string)> option = None
        let v725 : bool = true in let mutable _v724 = v724
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v726 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v726
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v727 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v727
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v728 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v728
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v729 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v729
#endif
        
#if FABLE_COMPILER_PYTHON
        let v730 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v730
#endif
        
#else
        let v731 : Async<struct (int32 * string)> option = None
        let v732 : bool = true in let mutable _v731 = v731
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v733 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v733
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v734 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v734
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v735 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v735
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v736 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v736
#endif
        
#if FABLE_COMPILER_PYTHON
        let v737 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v737
#endif
        
#else
        let v738 : Async<struct (int32 * string)> option = None
        let mutable _v738 = v738
        async {
        let struct (v739 : string, v740 : string) = method39()
        let v741 : int32 = v676.Length
        let v742 : (char []) = Array.zeroCreate<char> (v741)
        let v743 : Mut5 = {l0 = 0} : Mut5
        while method26(v741, v743) do
            let v745 : int32 = v743.l0
            let v746 : char = v676.[int v745]
            v742.[int v745] <- v746
            let v747 : int32 = v745 + 1
            v743.l0 <- v747
            ()
        let v748 : ((char []) -> char list) = Array.toList
        let v749 : char list = v748 v742
        let v750 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
        let v751 : (char -> (UH0 -> UH0)) = method40()
        let v752 : (char list -> (UH0 -> UH0)) = v750 v751
        let v753 : (UH0 -> UH0) = v752 v749
        let v754 : UH0 = UH0_0
        let v755 : UH0 = v753 v754
        let v756 : US8 = US8_0
        let struct (v757 : string, v758 : string) = method41(v740, v739, v755, v756)
        let v759 : (string -> US4) = method19()
        let v760 : US4 = US4_1
        let v761 : US4 = v654 |> Option.map v759 |> Option.defaultValue v760 
        let v765 : string =
            match v761 with
            | US4_1 -> (* None *)
                let v763 : string = ""
                v763
            | US4_0(v762) -> (* Some *)
                v762
        let v766 : US0 = US0_1
        let v767 : (unit -> string) = closure48(v655, v676, v656, v657, v678, v654)
        let v768 : (unit -> string) = method47()
        method3(v766, v767, v768)
        let v769 : System.Text.Encoding = System.Text.Encoding.UTF8
        let v770 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v758, StandardOutputEncoding = v769, WorkingDirectory = v765, FileName = v757, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
        let v771 : int32 = v656.Length
        let v772 : Mut5 = {l0 = 0} : Mut5
        while method26(v771, v772) do
            let v774 : int32 = v772.l0
            let struct (v775 : string, v776 : string) = v656.[int v774]
            v770.EnvironmentVariables.[v775] <- v776 
            let v777 : int32 = v774 + 1
            v772.l0 <- v777
            ()
        let v778 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v770)
        use v778 = v778 
        let v779 : System.Diagnostics.Process = v778 
        let v780 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
        let v781 : System.Collections.Concurrent.ConcurrentStack<string> = v780 ()
        let v782 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v655, v676, v656, v657, v678, v654, v779, v781)
        v779.OutputDataReceived.Add v782 
        let v783 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v655, v676, v656, v657, v678, v654, v779, v781)
        v779.ErrorDataReceived.Add v783 
        let v784 : (unit -> bool) = v779.Start
        let v785 : bool = v784 ()
        let v786 : bool = v785 = false
        if v786 then
            let v787 : string = $"execute_with_options_async / process_start error"
            failwith<unit> v787
        let v788 : (unit -> unit) = v779.BeginErrorReadLine
        v788 ()
        let v789 : (unit -> unit) = v779.BeginOutputReadLine
        v789 ()
        let v790 : (System.Threading.CancellationToken -> US18) = method70()
        let v791 : US18 = US18_1
        let v792 : US18 = v655 |> Option.map v790 |> Option.defaultValue v791 
        let v796 : System.Threading.CancellationToken =
            match v792 with
            | US18_1 -> (* None *)
                let v794 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                v794
            | US18_0(v793) -> (* Some *)
                v793
        let v797 : Async<System.Threading.CancellationToken> option = None
        let v798 : bool = true in let mutable _v797 = v797
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v799 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v799
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v800 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v800
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v801 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v801
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v802 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v802
#endif
        
#if FABLE_COMPILER_PYTHON
        let v803 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v803
#endif
        
#else
        let v804 : Async<System.Threading.CancellationToken> option = None
        let v805 : bool = true in let mutable _v804 = v804
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v806 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v806
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v807 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v807
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v808 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v808
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v809 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v809
#endif
        
#if FABLE_COMPILER_PYTHON
        let v810 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v810
#endif
        
#else
        let v811 : Async<System.Threading.CancellationToken> option = None
        let mutable _v811 = v811
        async {
        let v812 : Async<System.Threading.CancellationToken> = Async.CancellationToken
        let! v812 = v812 
        let v813 : System.Threading.CancellationToken = v812 
        let v814 : System.Threading.CancellationToken = Async.DefaultCancellationToken
        let v815 : (System.Threading.CancellationToken []) = [|v813; v814; v796|]
        let v816 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
        let v817 : System.Threading.CancellationTokenSource = v816 v815
        let v818 : System.Threading.CancellationToken = v817.Token
        return v818 
        }
        |> fun x -> _v811 <- Some x
        let v819 : Async<System.Threading.CancellationToken> = _v811 |> Option.get
        v819
#endif
        |> fun x -> _v804 <- Some x
        let v820 : Async<System.Threading.CancellationToken> = _v804.Value
        v820
#endif
        |> fun x -> _v797 <- Some x
        let v821 : Async<System.Threading.CancellationToken> = _v797.Value
        let! v821 = v821 
        let v822 : System.Threading.CancellationToken = v821 
        let v823 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v822.Register
        let v824 : (unit -> unit) = closure54(v779)
        let v825 : System.Threading.CancellationTokenRegistration = v823 v824
        use v825 = v825 
        let v826 : System.Threading.CancellationTokenRegistration = v825 
        let v827 : Async<int32> option = None
        let v828 : bool = true in let mutable _v827 = v827
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v829 : Async<int32> = null |> unbox<Async<int32>>
        v829
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v830 : Async<int32> = null |> unbox<Async<int32>>
        v830
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v831 : Async<int32> = null |> unbox<Async<int32>>
        v831
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v832 : Async<int32> = null |> unbox<Async<int32>>
        v832
#endif
        
#if FABLE_COMPILER_PYTHON
        let v833 : Async<int32> = null |> unbox<Async<int32>>
        v833
#endif
        
#else
        let v834 : Async<int32> option = None
        let mutable _v834 = v834
        async {
        try
        let v835 : System.Threading.Tasks.Task = v779.WaitForExitAsync v822 
        let v836 : Async<unit> option = None
        let v837 : bool = true in let mutable _v836 = v836
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v838 : Async<unit> = null |> unbox<Async<unit>>
        v838
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v839 : Async<unit> = null |> unbox<Async<unit>>
        v839
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v840 : Async<unit> = null |> unbox<Async<unit>>
        v840
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v841 : Async<unit> = null |> unbox<Async<unit>>
        v841
#endif
        
#if FABLE_COMPILER_PYTHON
        let v842 : Async<unit> = null |> unbox<Async<unit>>
        v842
#endif
        
#else
        let v843 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
        let v844 : Async<unit> = v843 v835
        v844
#endif
        |> fun x -> _v836 <- Some x
        let v845 : Async<unit> = _v836.Value
        do! v845 
        let v846 : int32 = v779.ExitCode
        return v846 
        with ex ->
        let v847 : exn = ex
        let v848 : string option = None
        let v849 : bool = true in let mutable _v848 = v848
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v850 : string = $"%A{v847}"
        v850
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v851 : string = $"%A{v847}"
        v851
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v852 : string = $"%A{v847}"
        v852
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v853 : string = $"%A{v847}"
        v853
#endif
        
#if FABLE_COMPILER_PYTHON
        let v854 : string = $"%A{v847}"
        v854
#endif
        
#else
        let v855 : string = $"{v847.GetType ()}: {v847.Message}"
        v855
#endif
        |> fun x -> _v848 <- Some x
        let v856 : string = _v848.Value
        let v857 : (string -> unit) = v781.Push
        v857 v856
        let v858 : System.Threading.Tasks.TaskCanceledException = v847 |> unbox<System.Threading.Tasks.TaskCanceledException>
        let v859 : US0 = US0_3
        let v860 : (unit -> string) = closure55(v858)
        let v861 : (unit -> string) = method47()
        method3(v859, v860, v861)
        return -2147483648 
        (*
        *)
        }
        |> fun x -> _v834 <- Some x
        let v862 : Async<int32> = _v834 |> Option.get
        v862
#endif
        |> fun x -> _v827 <- Some x
        let v863 : Async<int32> = _v827.Value
        let! v863 = v863 
        let v864 : int32 = v863 
        let v865 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
        let v866 : string seq = v865 v781
        let v867 : string = method71()
        let v868 : (string -> (string seq -> string)) = String.concat
        let v869 : (string seq -> string) = v868 v867
        let v870 : string = v869 v866
        let v871 : US0 = US0_1
        let v872 : (unit -> string) = closure56(v864, v870)
        let v873 : (unit -> string) = method47()
        method3(v871, v872, v873)
        return struct (v864, v870) 
        }
        |> fun x -> _v738 <- Some x
        let v874 : Async<struct (int32 * string)> = _v738 |> Option.get
        v874
#endif
        |> fun x -> _v731 <- Some x
        let v875 : Async<struct (int32 * string)> = _v731.Value
        v875
#endif
        |> fun x -> _v724 <- Some x
        let v876 : Async<struct (int32 * string)> = _v724.Value
        let v877 : struct (int32 * string) option = None
        let v878 : bool = true in let mutable _v877 = v877
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let struct (v879 : int32, v880 : string) = null |> unbox<struct (int32 * string)>
        struct (v879, v880)
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let struct (v881 : int32, v882 : string) = null |> unbox<struct (int32 * string)>
        struct (v881, v882)
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let struct (v883 : int32, v884 : string) = null |> unbox<struct (int32 * string)>
        struct (v883, v884)
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let struct (v885 : int32, v886 : string) = null |> unbox<struct (int32 * string)>
        struct (v885, v886)
#endif
        
#if FABLE_COMPILER_PYTHON
        let struct (v887 : int32, v888 : string) = null |> unbox<struct (int32 * string)>
        struct (v887, v888)
#endif
        
#else
        let v889 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
        let struct (v890 : int32, v891 : string) = v889 v876
        struct (v890, v891)
#endif
        |> fun x -> _v877 <- Some x
        let struct (v892 : int32, v893 : string) = _v877.Value
        struct (v892, v893)
#endif
        |> fun x -> _v679 <- Some x
        let struct (v894 : int32, v895 : string) = _v679.Value
        let v896 : (string []) = v895.Split v619
        let v897 : int32 = v896.Length
        let v898 : string = ""
        let v899 : Mut7 = {l0 = 0; l1 = v898; l2 = 0; l3 = 0} : Mut7
        while method75(v629, v899) do
            let v901 : int32 = v899.l0
            let struct (v902 : string, v903 : int32, v904 : int32) = v899.l1, v899.l2, v899.l3
            let v905 : string = v622.[int v901]
            let v906 : bool = v905 = ""
            let struct (v920 : string, v921 : int32, v922 : int32) =
                if v906 then
                    let v907 : string = $"{v902}
"
                    let v908 : int32 = v903 + 1
                    let v909 : int32 = v904 + 1
                    struct (v907, v908, v909)
                else
                    let v910 : int32 = v903 - v904
                    let v911 : bool = v910 >= v897
                    let v918 : string =
                        if v911 then
                            v902
                        else
                            let v912 : string = v896.[int v910]
                            let v913 : int32 = v897 - 1
                            let v914 : bool = v910 = v913
                            if v914 then
                                let v915 : string = $"{v902}{v912}"
                                v915
                            else
                                let v916 : string = $"{v902}{v912}
"
                                v916
                    let v919 : int32 = v903 + 1
                    struct (v918, v919, v904)
            let v923 : int32 = v901 + 1
            v899.l0 <- v923
            v899.l1 <- v920
            v899.l2 <- v921
            v899.l3 <- v922
            ()
        let struct (v924 : string, v925 : int32, v926 : int32) = v899.l1, v899.l2, v899.l3
        let v927 : unit option = None
        let v928 : bool = true in let mutable _v927 = v927
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v929 : string = "std::fs::write(&*$0, &*$1).unwrap()"
        Fable.Core.RustInterop.emitRustExpr struct (v19, v924) v929
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
        let v930 : string = method76(v924)
        System.IO.File.WriteAllText (v19, v930)
        ()
#endif
        |> fun x -> _v927 <- Some x
        _v927.Value
        let v931 : bool = v894 <> 0
        if v931 then
            let v932 : US0 = US0_2
            let v933 : (unit -> string) = closure59()
            let v934 : (unit -> string) = closure60(v924, v894)
            method3(v932, v933, v934)
            let v935 : (string * string) = v19, v924
            let v936 : Result<string, (string * string)> = Error v935
            US19_0(v936)
        else
            let v938 : bool option = None
            let v939 : bool = true in let mutable _v938 = v938
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v940 : string = method14(v19)
            let v941 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v942 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v940 v941
            let v943 : string = "String::from($0)"
            let v944 : std_string_String = Fable.Core.RustInterop.emitRustExpr v942 v943
            let v945 : string = "std::path::PathBuf::from($0)"
            let v946 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v944 v945
            let v947 : string = "$0.exists()"
            let v948 : bool = Fable.Core.RustInterop.emitRustExpr v946 v947
            let v951 : bool =
                if v948 then
                    let v949 : string = "$0.is_file()"
                    let v950 : bool = Fable.Core.RustInterop.emitRustExpr v946 v949
                    v950
                else
                    false
            v951
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v952 : bool = null |> unbox<bool>
            v952
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v953 : bool = null |> unbox<bool>
            v953
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v954 : IFsExistsSync = Fable.Core.JsInterop.importAll v39
            let v955 : string = "v954.existsSync($0)"
            let v956 : bool = Fable.Core.JsInterop.emitJsExpr v19 v955
            v956
#endif
            
#if FABLE_COMPILER_PYTHON
            let v957 : bool = null |> unbox<bool>
            v957
#endif
            
#else
            let v958 : (string -> bool) = System.IO.File.Exists
            let v959 : bool = v958 v19
            v959
#endif
            |> fun x -> _v938 <- Some x
            let v960 : bool = _v938.Value
            if v960 then
                let v961 : unit option = None
                let v962 : bool = true in let mutable _v961 = v961
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v963 : string = method77(v22)
                let v964 : string = "std::fs::copy(&*v19, &*v963)"
                let v965 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v964
                let v966 : string = "$0.unwrap()"
                let v967 : uint64 = Fable.Core.RustInterop.emitRustExpr v965 v966
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
                System.IO.File.Copy (v19, v22, true)
                ()
#endif
                |> fun x -> _v961 <- Some x
                _v961.Value
                ()
            else
                let v968 : string = $"documents.run / files_fn / {v19} should exist"
                failwith<unit> v968
            let v969 : Result<string, (string * string)> = Ok v19
            US19_0(v969)
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
    let v4 : string = ".hangul.md"
    let v5 : bool = v1.EndsWith v4
    let v6 : string = ".md"
    let v7 : bool = v3.EndsWith v6
    let v8 : string = "."
    let v9 : int32 = v1.LastIndexOf v8
    let v10 : int32 = v9 - 1
    let v11 : string = v1.[int 0..int v10]
    let v12 : int32 = v0.LastIndexOf v8
    let v13 : int32 = v12 - 1
    let v14 : string = v0.[int 0..int v13]
    let v15 : bool = v7 = false
    let v18 : string =
        if v15 then
            let v16 : string = $"{v1}.{v3}"
            v16
        else
            let v17 : string = $"{v11}.{v3}"
            v17
    let v21 : string =
        if v15 then
            let v19 : string = $"{v0}.{v3}"
            v19
        else
            let v20 : string = $"{v14}.{v3}"
            v20
    let v22 : bool option = None
    let v23 : bool = true in let mutable _v22 = v22
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v24 : string = method14(v18)
    let v25 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v26 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v24 v25
    let v27 : string = "String::from($0)"
    let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v26 v27
    let v29 : string = "std::path::PathBuf::from($0)"
    let v30 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v28 v29
    let v31 : string = "$0.exists()"
    let v32 : bool = Fable.Core.RustInterop.emitRustExpr v30 v31
    let v35 : bool =
        if v32 then
            let v33 : string = "$0.is_file()"
            let v34 : bool = Fable.Core.RustInterop.emitRustExpr v30 v33
            v34
        else
            false
    v35
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v36 : bool = null |> unbox<bool>
    v36
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v37 : bool = null |> unbox<bool>
    v37
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v38 : string = "fs"
    let v39 : IFsExistsSync = Fable.Core.JsInterop.importAll v38
    let v40 : string = "v39.existsSync($0)"
    let v41 : bool = Fable.Core.JsInterop.emitJsExpr v18 v40
    v41
#endif
    
#if FABLE_COMPILER_PYTHON
    let v42 : bool = null |> unbox<bool>
    v42
#endif
    
#else
    let v43 : (string -> bool) = System.IO.File.Exists
    let v44 : bool = v43 v18
    v44
#endif
    |> fun x -> _v22 <- Some x
    let v45 : bool = _v22.Value
    let v69 : bool =
        if v45 then
            let v46 : bool option = None
            let v47 : bool = true in let mutable _v46 = v46
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = method14(v21)
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
                    let v57 : string = "$0.is_file()"
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
            let v62 : IFsExistsSync = Fable.Core.JsInterop.importAll v38
            let v63 : string = "v62.existsSync($0)"
            let v64 : bool = Fable.Core.JsInterop.emitJsExpr v21 v63
            v64
#endif
            
#if FABLE_COMPILER_PYTHON
            let v65 : bool = null |> unbox<bool>
            v65
#endif
            
#else
            let v66 : (string -> bool) = System.IO.File.Exists
            let v67 : bool = v66 v21
            v67
#endif
            |> fun x -> _v46 <- Some x
            let v68 : bool = _v46.Value
            v68
        else
            false
    let v590 : bool =
        if v69 then
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
            let v82 : bool = v81 = false
            let v106 : string =
                if v82 then
                    v18
                else
                    let v83 : string option = None
                    let v84 : bool = true in let mutable _v83 = v83
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v85 : string = method22()
                    let v86 : string = method23(v18)
                    let v87 : string = method24()
                    let v88 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v89 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v85, v86, v87) v88
                    let v90 : string = "String::from($0)"
                    let v91 : std_string_String = Fable.Core.RustInterop.emitRustExpr v89 v90
                    let v92 : string = "fable_library_rust::String_::fromString($0)"
                    let v93 : string = Fable.Core.RustInterop.emitRustExpr v91 v92
                    v93
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v94 : string = null |> unbox<string>
                    v94
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v95 : string = null |> unbox<string>
                    v95
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v96 : string = null |> unbox<string>
                    v96
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v97 : string = null |> unbox<string>
                    v97
#endif
                    
#else
                    let v98 : string = "^\\\\\\\\\\?\\\\"
                    let v99 : string = ""
                    let v100 : string = System.Text.RegularExpressions.Regex.Replace (v18, v98, v99)
                    v100
#endif
                    |> fun x -> _v83 <- Some x
                    let v101 : string = _v83.Value
                    let v102 : string = $"{v101.[0] |> string |> _.ToLower()}{v101.[1..]}"
                    let v103 : string = "\\"
                    let v104 : string = "/"
                    let v105 : string = v102.Replace (v103, v104)
                    v105
            let v107 : string option = None
            let v108 : System.Threading.CancellationToken option = None
            let v109 : (struct (string * string) []) = [||]
            let v110 : (struct (bool * string * int32) -> Async<unit>) option = None
            let v111 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
            let v112 : string = $"pwsh -c \"(Get-FileHash \\\"{v106}\\\" -Algorithm SHA256).Hash\""
            let v113 : struct (int32 * string) option = None
            let v114 : bool = true in let mutable _v113 = v113
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v115 : string = method38(v108, v112, v109, v110, v111, v107)
            let struct (v116 : string, v117 : string) = method39()
            let v118 : int32 = v115.Length
            let v119 : (char []) = Array.zeroCreate<char> (v118)
            let v120 : Mut5 = {l0 = 0} : Mut5
            while method26(v118, v120) do
                let v122 : int32 = v120.l0
                let v123 : char = v115.[int v122]
                v119.[int v122] <- v123
                let v124 : int32 = v122 + 1
                v120.l0 <- v124
                ()
            let v125 : ((char []) -> char list) = Array.toList
            let v126 : char list = v125 v119
            let v127 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v128 : (char -> (UH0 -> UH0)) = method40()
            let v129 : (char list -> (UH0 -> UH0)) = v127 v128
            let v130 : (UH0 -> UH0) = v129 v126
            let v131 : UH0 = UH0_0
            let v132 : UH0 = v130 v131
            let v133 : US8 = US8_0
            let struct (v134 : string, v135 : string) = method41(v117, v116, v132, v133)
            let v136 : (string []) = method42(v135)
            let v137 : string = "$0.to_vec()"
            let v138 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v136 v137
            let v139 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v140 : (string -> std_string_String) = closure28()
            let v141 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v138, v140) v139
            let v142 : US0 = US0_1
            let v143 : (unit -> string) = closure29(v108, v112, v109, v110, v111, v107, v134, v141)
            let v144 : (unit -> string) = method47()
            method3(v142, v143, v144)
            let v145 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v108, v112, v109, v110, v111, v107, v134, v141)
            let v146 : string = "futures_lite::future::block_on($0)"
            let v147 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v145 v146
            let (a, b) = v147
            let v148 : int32 = a
            let v149 : string = b
            struct (v148, v149)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v150 : int32, v151 : string) = null |> unbox<struct (int32 * string)>
            struct (v150, v151)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v152 : int32, v153 : string) = null |> unbox<struct (int32 * string)>
            struct (v152, v153)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v154 : int32, v155 : string) = null |> unbox<struct (int32 * string)>
            struct (v154, v155)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v156 : int32, v157 : string) = null |> unbox<struct (int32 * string)>
            struct (v156, v157)
#endif
            
#else
            let v158 : Async<struct (int32 * string)> option = None
            let v159 : bool = true in let mutable _v158 = v158
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v160 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v160
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v161 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v161
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v162 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v162
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v163 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v163
#endif
            
#if FABLE_COMPILER_PYTHON
            let v164 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v164
#endif
            
#else
            let v165 : Async<struct (int32 * string)> option = None
            let v166 : bool = true in let mutable _v165 = v165
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v167 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v167
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v168 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v168
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v169 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v169
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v170 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v170
#endif
            
#if FABLE_COMPILER_PYTHON
            let v171 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v171
#endif
            
#else
            let v172 : Async<struct (int32 * string)> option = None
            let mutable _v172 = v172
            async {
            let struct (v173 : string, v174 : string) = method39()
            let v175 : int32 = v112.Length
            let v176 : (char []) = Array.zeroCreate<char> (v175)
            let v177 : Mut5 = {l0 = 0} : Mut5
            while method26(v175, v177) do
                let v179 : int32 = v177.l0
                let v180 : char = v112.[int v179]
                v176.[int v179] <- v180
                let v181 : int32 = v179 + 1
                v177.l0 <- v181
                ()
            let v182 : ((char []) -> char list) = Array.toList
            let v183 : char list = v182 v176
            let v184 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v185 : (char -> (UH0 -> UH0)) = method40()
            let v186 : (char list -> (UH0 -> UH0)) = v184 v185
            let v187 : (UH0 -> UH0) = v186 v183
            let v188 : UH0 = UH0_0
            let v189 : UH0 = v187 v188
            let v190 : US8 = US8_0
            let struct (v191 : string, v192 : string) = method41(v174, v173, v189, v190)
            let v193 : (string -> US4) = method19()
            let v194 : US4 = US4_1
            let v195 : US4 = v107 |> Option.map v193 |> Option.defaultValue v194 
            let v199 : string =
                match v195 with
                | US4_1 -> (* None *)
                    let v197 : string = ""
                    v197
                | US4_0(v196) -> (* Some *)
                    v196
            let v200 : US0 = US0_1
            let v201 : (unit -> string) = closure48(v108, v112, v109, v110, v111, v107)
            let v202 : (unit -> string) = method47()
            method3(v200, v201, v202)
            let v203 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v204 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v192, StandardOutputEncoding = v203, WorkingDirectory = v199, FileName = v191, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v205 : int32 = v109.Length
            let v206 : Mut5 = {l0 = 0} : Mut5
            while method26(v205, v206) do
                let v208 : int32 = v206.l0
                let struct (v209 : string, v210 : string) = v109.[int v208]
                v204.EnvironmentVariables.[v209] <- v210 
                let v211 : int32 = v208 + 1
                v206.l0 <- v211
                ()
            let v212 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v204)
            use v212 = v212 
            let v213 : System.Diagnostics.Process = v212 
            let v214 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v215 : System.Collections.Concurrent.ConcurrentStack<string> = v214 ()
            let v216 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v108, v112, v109, v110, v111, v107, v213, v215)
            v213.OutputDataReceived.Add v216 
            let v217 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v108, v112, v109, v110, v111, v107, v213, v215)
            v213.ErrorDataReceived.Add v217 
            let v218 : (unit -> bool) = v213.Start
            let v219 : bool = v218 ()
            let v220 : bool = v219 = false
            if v220 then
                let v221 : string = $"execute_with_options_async / process_start error"
                failwith<unit> v221
            let v222 : (unit -> unit) = v213.BeginErrorReadLine
            v222 ()
            let v223 : (unit -> unit) = v213.BeginOutputReadLine
            v223 ()
            let v224 : (System.Threading.CancellationToken -> US18) = method70()
            let v225 : US18 = US18_1
            let v226 : US18 = v108 |> Option.map v224 |> Option.defaultValue v225 
            let v230 : System.Threading.CancellationToken =
                match v226 with
                | US18_1 -> (* None *)
                    let v228 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v228
                | US18_0(v227) -> (* Some *)
                    v227
            let v231 : Async<System.Threading.CancellationToken> option = None
            let v232 : bool = true in let mutable _v231 = v231
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v233 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v233
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v234 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v234
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v235 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v235
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v236 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v236
#endif
            
#if FABLE_COMPILER_PYTHON
            let v237 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v237
#endif
            
#else
            let v238 : Async<System.Threading.CancellationToken> option = None
            let v239 : bool = true in let mutable _v238 = v238
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v240 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v240
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v241 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v241
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v242 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v242
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v243 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v243
#endif
            
#if FABLE_COMPILER_PYTHON
            let v244 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v244
#endif
            
#else
            let v245 : Async<System.Threading.CancellationToken> option = None
            let mutable _v245 = v245
            async {
            let v246 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v246 = v246 
            let v247 : System.Threading.CancellationToken = v246 
            let v248 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v249 : (System.Threading.CancellationToken []) = [|v247; v248; v230|]
            let v250 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v251 : System.Threading.CancellationTokenSource = v250 v249
            let v252 : System.Threading.CancellationToken = v251.Token
            return v252 
            }
            |> fun x -> _v245 <- Some x
            let v253 : Async<System.Threading.CancellationToken> = _v245 |> Option.get
            v253
#endif
            |> fun x -> _v238 <- Some x
            let v254 : Async<System.Threading.CancellationToken> = _v238.Value
            v254
#endif
            |> fun x -> _v231 <- Some x
            let v255 : Async<System.Threading.CancellationToken> = _v231.Value
            let! v255 = v255 
            let v256 : System.Threading.CancellationToken = v255 
            let v257 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v256.Register
            let v258 : (unit -> unit) = closure54(v213)
            let v259 : System.Threading.CancellationTokenRegistration = v257 v258
            use v259 = v259 
            let v260 : System.Threading.CancellationTokenRegistration = v259 
            let v261 : Async<int32> option = None
            let v262 : bool = true in let mutable _v261 = v261
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v263 : Async<int32> = null |> unbox<Async<int32>>
            v263
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v264 : Async<int32> = null |> unbox<Async<int32>>
            v264
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v265 : Async<int32> = null |> unbox<Async<int32>>
            v265
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v266 : Async<int32> = null |> unbox<Async<int32>>
            v266
#endif
            
#if FABLE_COMPILER_PYTHON
            let v267 : Async<int32> = null |> unbox<Async<int32>>
            v267
#endif
            
#else
            let v268 : Async<int32> option = None
            let mutable _v268 = v268
            async {
            try
            let v269 : System.Threading.Tasks.Task = v213.WaitForExitAsync v256 
            let v270 : Async<unit> option = None
            let v271 : bool = true in let mutable _v270 = v270
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v272 : Async<unit> = null |> unbox<Async<unit>>
            v272
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v273 : Async<unit> = null |> unbox<Async<unit>>
            v273
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v274 : Async<unit> = null |> unbox<Async<unit>>
            v274
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v275 : Async<unit> = null |> unbox<Async<unit>>
            v275
#endif
            
#if FABLE_COMPILER_PYTHON
            let v276 : Async<unit> = null |> unbox<Async<unit>>
            v276
#endif
            
#else
            let v277 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v278 : Async<unit> = v277 v269
            v278
#endif
            |> fun x -> _v270 <- Some x
            let v279 : Async<unit> = _v270.Value
            do! v279 
            let v280 : int32 = v213.ExitCode
            return v280 
            with ex ->
            let v281 : exn = ex
            let v282 : string option = None
            let v283 : bool = true in let mutable _v282 = v282
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v284 : string = $"%A{v281}"
            v284
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v285 : string = $"%A{v281}"
            v285
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v286 : string = $"%A{v281}"
            v286
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v287 : string = $"%A{v281}"
            v287
#endif
            
#if FABLE_COMPILER_PYTHON
            let v288 : string = $"%A{v281}"
            v288
#endif
            
#else
            let v289 : string = $"{v281.GetType ()}: {v281.Message}"
            v289
#endif
            |> fun x -> _v282 <- Some x
            let v290 : string = _v282.Value
            let v291 : (string -> unit) = v215.Push
            v291 v290
            let v292 : System.Threading.Tasks.TaskCanceledException = v281 |> unbox<System.Threading.Tasks.TaskCanceledException>
            let v293 : US0 = US0_3
            let v294 : (unit -> string) = closure55(v292)
            let v295 : (unit -> string) = method47()
            method3(v293, v294, v295)
            return -2147483648 
            (*
            *)
            }
            |> fun x -> _v268 <- Some x
            let v296 : Async<int32> = _v268 |> Option.get
            v296
#endif
            |> fun x -> _v261 <- Some x
            let v297 : Async<int32> = _v261.Value
            let! v297 = v297 
            let v298 : int32 = v297 
            let v299 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v300 : string seq = v299 v215
            let v301 : string = method71()
            let v302 : (string -> (string seq -> string)) = String.concat
            let v303 : (string seq -> string) = v302 v301
            let v304 : string = v303 v300
            let v305 : US0 = US0_1
            let v306 : (unit -> string) = closure56(v298, v304)
            let v307 : (unit -> string) = method47()
            method3(v305, v306, v307)
            return struct (v298, v304) 
            }
            |> fun x -> _v172 <- Some x
            let v308 : Async<struct (int32 * string)> = _v172 |> Option.get
            v308
#endif
            |> fun x -> _v165 <- Some x
            let v309 : Async<struct (int32 * string)> = _v165.Value
            v309
#endif
            |> fun x -> _v158 <- Some x
            let v310 : Async<struct (int32 * string)> = _v158.Value
            let v311 : struct (int32 * string) option = None
            let v312 : bool = true in let mutable _v311 = v311
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v313 : int32, v314 : string) = null |> unbox<struct (int32 * string)>
            struct (v313, v314)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v315 : int32, v316 : string) = null |> unbox<struct (int32 * string)>
            struct (v315, v316)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v317 : int32, v318 : string) = null |> unbox<struct (int32 * string)>
            struct (v317, v318)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v319 : int32, v320 : string) = null |> unbox<struct (int32 * string)>
            struct (v319, v320)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v321 : int32, v322 : string) = null |> unbox<struct (int32 * string)>
            struct (v321, v322)
#endif
            
#else
            let v323 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
            let struct (v324 : int32, v325 : string) = v323 v310
            struct (v324, v325)
#endif
            |> fun x -> _v311 <- Some x
            let struct (v326 : int32, v327 : string) = _v311.Value
            struct (v326, v327)
#endif
            |> fun x -> _v113 <- Some x
            let struct (v328 : int32, v329 : string) = _v113.Value
            let v330 : bool option = None
            let v331 : bool = true in let mutable _v330 = v330
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v332 : string = "cfg!(windows)"
            let v333 : bool = Fable.Core.RustInterop.emitRustExpr () v332
            v333
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v334 : bool = null |> unbox<bool>
            v334
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v335 : bool = null |> unbox<bool>
            v335
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v336 : bool = null |> unbox<bool>
            v336
#endif
            
#if FABLE_COMPILER_PYTHON
            let v337 : bool = null |> unbox<bool>
            v337
#endif
            
#else
            let v338 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v339 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v340 : bool = v339 v338
            v340
#endif
            |> fun x -> _v330 <- Some x
            let v341 : bool = _v330.Value
            let v342 : bool = v341 = false
            let v366 : string =
                if v342 then
                    v21
                else
                    let v343 : string option = None
                    let v344 : bool = true in let mutable _v343 = v343
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v345 : string = method22()
                    let v346 : string = method23(v21)
                    let v347 : string = method24()
                    let v348 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v349 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v345, v346, v347) v348
                    let v350 : string = "String::from($0)"
                    let v351 : std_string_String = Fable.Core.RustInterop.emitRustExpr v349 v350
                    let v352 : string = "fable_library_rust::String_::fromString($0)"
                    let v353 : string = Fable.Core.RustInterop.emitRustExpr v351 v352
                    v353
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v354 : string = null |> unbox<string>
                    v354
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v355 : string = null |> unbox<string>
                    v355
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v356 : string = null |> unbox<string>
                    v356
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v357 : string = null |> unbox<string>
                    v357
#endif
                    
#else
                    let v358 : string = "^\\\\\\\\\\?\\\\"
                    let v359 : string = ""
                    let v360 : string = System.Text.RegularExpressions.Regex.Replace (v21, v358, v359)
                    v360
#endif
                    |> fun x -> _v343 <- Some x
                    let v361 : string = _v343.Value
                    let v362 : string = $"{v361.[0] |> string |> _.ToLower()}{v361.[1..]}"
                    let v363 : string = "\\"
                    let v364 : string = "/"
                    let v365 : string = v362.Replace (v363, v364)
                    v365
            let v367 : string option = None
            let v368 : System.Threading.CancellationToken option = None
            let v369 : (struct (string * string) []) = [||]
            let v370 : (struct (bool * string * int32) -> Async<unit>) option = None
            let v371 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
            let v372 : string = $"pwsh -c \"(Get-FileHash \\\"{v366}\\\" -Algorithm SHA256).Hash\""
            let v373 : struct (int32 * string) option = None
            let v374 : bool = true in let mutable _v373 = v373
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v375 : string = method38(v368, v372, v369, v370, v371, v367)
            let struct (v376 : string, v377 : string) = method39()
            let v378 : int32 = v375.Length
            let v379 : (char []) = Array.zeroCreate<char> (v378)
            let v380 : Mut5 = {l0 = 0} : Mut5
            while method26(v378, v380) do
                let v382 : int32 = v380.l0
                let v383 : char = v375.[int v382]
                v379.[int v382] <- v383
                let v384 : int32 = v382 + 1
                v380.l0 <- v384
                ()
            let v385 : ((char []) -> char list) = Array.toList
            let v386 : char list = v385 v379
            let v387 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v388 : (char -> (UH0 -> UH0)) = method40()
            let v389 : (char list -> (UH0 -> UH0)) = v387 v388
            let v390 : (UH0 -> UH0) = v389 v386
            let v391 : UH0 = UH0_0
            let v392 : UH0 = v390 v391
            let v393 : US8 = US8_0
            let struct (v394 : string, v395 : string) = method41(v377, v376, v392, v393)
            let v396 : (string []) = method42(v395)
            let v397 : string = "$0.to_vec()"
            let v398 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v396 v397
            let v399 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v400 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v398, v140) v399
            let v401 : US0 = US0_1
            let v402 : (unit -> string) = closure29(v368, v372, v369, v370, v371, v367, v394, v400)
            let v403 : (unit -> string) = method47()
            method3(v401, v402, v403)
            let v404 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v368, v372, v369, v370, v371, v367, v394, v400)
            let v405 : string = "futures_lite::future::block_on($0)"
            let v406 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v404 v405
            let (a, b) = v406
            let v407 : int32 = a
            let v408 : string = b
            struct (v407, v408)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v409 : int32, v410 : string) = null |> unbox<struct (int32 * string)>
            struct (v409, v410)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v411 : int32, v412 : string) = null |> unbox<struct (int32 * string)>
            struct (v411, v412)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v413 : int32, v414 : string) = null |> unbox<struct (int32 * string)>
            struct (v413, v414)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v415 : int32, v416 : string) = null |> unbox<struct (int32 * string)>
            struct (v415, v416)
#endif
            
#else
            let v417 : Async<struct (int32 * string)> option = None
            let v418 : bool = true in let mutable _v417 = v417
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v419 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v419
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v420 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v420
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v421 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v421
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v422 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v422
#endif
            
#if FABLE_COMPILER_PYTHON
            let v423 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v423
#endif
            
#else
            let v424 : Async<struct (int32 * string)> option = None
            let v425 : bool = true in let mutable _v424 = v424
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v426 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v426
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v427 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v427
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v428 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v428
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v429 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v429
#endif
            
#if FABLE_COMPILER_PYTHON
            let v430 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v430
#endif
            
#else
            let v431 : Async<struct (int32 * string)> option = None
            let mutable _v431 = v431
            async {
            let struct (v432 : string, v433 : string) = method39()
            let v434 : int32 = v372.Length
            let v435 : (char []) = Array.zeroCreate<char> (v434)
            let v436 : Mut5 = {l0 = 0} : Mut5
            while method26(v434, v436) do
                let v438 : int32 = v436.l0
                let v439 : char = v372.[int v438]
                v435.[int v438] <- v439
                let v440 : int32 = v438 + 1
                v436.l0 <- v440
                ()
            let v441 : ((char []) -> char list) = Array.toList
            let v442 : char list = v441 v435
            let v443 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v444 : (char -> (UH0 -> UH0)) = method40()
            let v445 : (char list -> (UH0 -> UH0)) = v443 v444
            let v446 : (UH0 -> UH0) = v445 v442
            let v447 : UH0 = UH0_0
            let v448 : UH0 = v446 v447
            let v449 : US8 = US8_0
            let struct (v450 : string, v451 : string) = method41(v433, v432, v448, v449)
            let v452 : (string -> US4) = method19()
            let v453 : US4 = US4_1
            let v454 : US4 = v367 |> Option.map v452 |> Option.defaultValue v453 
            let v458 : string =
                match v454 with
                | US4_1 -> (* None *)
                    let v456 : string = ""
                    v456
                | US4_0(v455) -> (* Some *)
                    v455
            let v459 : US0 = US0_1
            let v460 : (unit -> string) = closure48(v368, v372, v369, v370, v371, v367)
            let v461 : (unit -> string) = method47()
            method3(v459, v460, v461)
            let v462 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v463 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v451, StandardOutputEncoding = v462, WorkingDirectory = v458, FileName = v450, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v464 : int32 = v369.Length
            let v465 : Mut5 = {l0 = 0} : Mut5
            while method26(v464, v465) do
                let v467 : int32 = v465.l0
                let struct (v468 : string, v469 : string) = v369.[int v467]
                v463.EnvironmentVariables.[v468] <- v469 
                let v470 : int32 = v467 + 1
                v465.l0 <- v470
                ()
            let v471 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v463)
            use v471 = v471 
            let v472 : System.Diagnostics.Process = v471 
            let v473 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v474 : System.Collections.Concurrent.ConcurrentStack<string> = v473 ()
            let v475 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v368, v372, v369, v370, v371, v367, v472, v474)
            v472.OutputDataReceived.Add v475 
            let v476 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v368, v372, v369, v370, v371, v367, v472, v474)
            v472.ErrorDataReceived.Add v476 
            let v477 : (unit -> bool) = v472.Start
            let v478 : bool = v477 ()
            let v479 : bool = v478 = false
            if v479 then
                let v480 : string = $"execute_with_options_async / process_start error"
                failwith<unit> v480
            let v481 : (unit -> unit) = v472.BeginErrorReadLine
            v481 ()
            let v482 : (unit -> unit) = v472.BeginOutputReadLine
            v482 ()
            let v483 : (System.Threading.CancellationToken -> US18) = method70()
            let v484 : US18 = US18_1
            let v485 : US18 = v368 |> Option.map v483 |> Option.defaultValue v484 
            let v489 : System.Threading.CancellationToken =
                match v485 with
                | US18_1 -> (* None *)
                    let v487 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v487
                | US18_0(v486) -> (* Some *)
                    v486
            let v490 : Async<System.Threading.CancellationToken> option = None
            let v491 : bool = true in let mutable _v490 = v490
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v492 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v492
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v493 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v493
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v494 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v494
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v495 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v495
#endif
            
#if FABLE_COMPILER_PYTHON
            let v496 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v496
#endif
            
#else
            let v497 : Async<System.Threading.CancellationToken> option = None
            let v498 : bool = true in let mutable _v497 = v497
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v499 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v499
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v500 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v500
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v501 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v501
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v502 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v502
#endif
            
#if FABLE_COMPILER_PYTHON
            let v503 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v503
#endif
            
#else
            let v504 : Async<System.Threading.CancellationToken> option = None
            let mutable _v504 = v504
            async {
            let v505 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v505 = v505 
            let v506 : System.Threading.CancellationToken = v505 
            let v507 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v508 : (System.Threading.CancellationToken []) = [|v506; v507; v489|]
            let v509 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v510 : System.Threading.CancellationTokenSource = v509 v508
            let v511 : System.Threading.CancellationToken = v510.Token
            return v511 
            }
            |> fun x -> _v504 <- Some x
            let v512 : Async<System.Threading.CancellationToken> = _v504 |> Option.get
            v512
#endif
            |> fun x -> _v497 <- Some x
            let v513 : Async<System.Threading.CancellationToken> = _v497.Value
            v513
#endif
            |> fun x -> _v490 <- Some x
            let v514 : Async<System.Threading.CancellationToken> = _v490.Value
            let! v514 = v514 
            let v515 : System.Threading.CancellationToken = v514 
            let v516 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v515.Register
            let v517 : (unit -> unit) = closure54(v472)
            let v518 : System.Threading.CancellationTokenRegistration = v516 v517
            use v518 = v518 
            let v519 : System.Threading.CancellationTokenRegistration = v518 
            let v520 : Async<int32> option = None
            let v521 : bool = true in let mutable _v520 = v520
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v522 : Async<int32> = null |> unbox<Async<int32>>
            v522
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v523 : Async<int32> = null |> unbox<Async<int32>>
            v523
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v524 : Async<int32> = null |> unbox<Async<int32>>
            v524
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v525 : Async<int32> = null |> unbox<Async<int32>>
            v525
#endif
            
#if FABLE_COMPILER_PYTHON
            let v526 : Async<int32> = null |> unbox<Async<int32>>
            v526
#endif
            
#else
            let v527 : Async<int32> option = None
            let mutable _v527 = v527
            async {
            try
            let v528 : System.Threading.Tasks.Task = v472.WaitForExitAsync v515 
            let v529 : Async<unit> option = None
            let v530 : bool = true in let mutable _v529 = v529
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v531 : Async<unit> = null |> unbox<Async<unit>>
            v531
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v532 : Async<unit> = null |> unbox<Async<unit>>
            v532
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v533 : Async<unit> = null |> unbox<Async<unit>>
            v533
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v534 : Async<unit> = null |> unbox<Async<unit>>
            v534
#endif
            
#if FABLE_COMPILER_PYTHON
            let v535 : Async<unit> = null |> unbox<Async<unit>>
            v535
#endif
            
#else
            let v536 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v537 : Async<unit> = v536 v528
            v537
#endif
            |> fun x -> _v529 <- Some x
            let v538 : Async<unit> = _v529.Value
            do! v538 
            let v539 : int32 = v472.ExitCode
            return v539 
            with ex ->
            let v540 : exn = ex
            let v541 : string option = None
            let v542 : bool = true in let mutable _v541 = v541
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v543 : string = $"%A{v540}"
            v543
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v544 : string = $"%A{v540}"
            v544
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v545 : string = $"%A{v540}"
            v545
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v546 : string = $"%A{v540}"
            v546
#endif
            
#if FABLE_COMPILER_PYTHON
            let v547 : string = $"%A{v540}"
            v547
#endif
            
#else
            let v548 : string = $"{v540.GetType ()}: {v540.Message}"
            v548
#endif
            |> fun x -> _v541 <- Some x
            let v549 : string = _v541.Value
            let v550 : (string -> unit) = v474.Push
            v550 v549
            let v551 : System.Threading.Tasks.TaskCanceledException = v540 |> unbox<System.Threading.Tasks.TaskCanceledException>
            let v552 : US0 = US0_3
            let v553 : (unit -> string) = closure55(v551)
            let v554 : (unit -> string) = method47()
            method3(v552, v553, v554)
            return -2147483648 
            (*
            *)
            }
            |> fun x -> _v527 <- Some x
            let v555 : Async<int32> = _v527 |> Option.get
            v555
#endif
            |> fun x -> _v520 <- Some x
            let v556 : Async<int32> = _v520.Value
            let! v556 = v556 
            let v557 : int32 = v556 
            let v558 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v559 : string seq = v558 v474
            let v560 : string = method71()
            let v561 : (string -> (string seq -> string)) = String.concat
            let v562 : (string seq -> string) = v561 v560
            let v563 : string = v562 v559
            let v564 : US0 = US0_1
            let v565 : (unit -> string) = closure56(v557, v563)
            let v566 : (unit -> string) = method47()
            method3(v564, v565, v566)
            return struct (v557, v563) 
            }
            |> fun x -> _v431 <- Some x
            let v567 : Async<struct (int32 * string)> = _v431 |> Option.get
            v567
#endif
            |> fun x -> _v424 <- Some x
            let v568 : Async<struct (int32 * string)> = _v424.Value
            v568
#endif
            |> fun x -> _v417 <- Some x
            let v569 : Async<struct (int32 * string)> = _v417.Value
            let v570 : struct (int32 * string) option = None
            let v571 : bool = true in let mutable _v570 = v570
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v572 : int32, v573 : string) = null |> unbox<struct (int32 * string)>
            struct (v572, v573)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v574 : int32, v575 : string) = null |> unbox<struct (int32 * string)>
            struct (v574, v575)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v576 : int32, v577 : string) = null |> unbox<struct (int32 * string)>
            struct (v576, v577)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v578 : int32, v579 : string) = null |> unbox<struct (int32 * string)>
            struct (v578, v579)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v580 : int32, v581 : string) = null |> unbox<struct (int32 * string)>
            struct (v580, v581)
#endif
            
#else
            let v582 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
            let struct (v583 : int32, v584 : string) = v582 v569
            struct (v583, v584)
#endif
            |> fun x -> _v570 <- Some x
            let struct (v585 : int32, v586 : string) = _v570.Value
            struct (v585, v586)
#endif
            |> fun x -> _v373 <- Some x
            let struct (v587 : int32, v588 : string) = _v373.Value
            let v589 : bool = v329 = v588
            v589
        else
            false
    let v591 : bool = v590 = false
    if v591 then
        let v592 : string = $"crowbook --single \"{v1}\" --output \"{v18}\" --to {v3} --set rendering.num_depth 6 html.css.add \\\"''' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} '''\\\""
        let v593 : string option = None
        let v594 : System.Threading.CancellationToken option = None
        let v595 : (struct (string * string) []) = [||]
        let v596 : (struct (bool * string * int32) -> Async<unit>) option = None
        let v597 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
        let v598 : string option = Some v2 
        let v599 : struct (int32 * string) option = None
        let v600 : bool = true in let mutable _v599 = v599
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v601 : string = method38(v594, v592, v595, v596, v597, v598)
        let struct (v602 : string, v603 : string) = method39()
        let v604 : int32 = v601.Length
        let v605 : (char []) = Array.zeroCreate<char> (v604)
        let v606 : Mut5 = {l0 = 0} : Mut5
        while method26(v604, v606) do
            let v608 : int32 = v606.l0
            let v609 : char = v601.[int v608]
            v605.[int v608] <- v609
            let v610 : int32 = v608 + 1
            v606.l0 <- v610
            ()
        let v611 : ((char []) -> char list) = Array.toList
        let v612 : char list = v611 v605
        let v613 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
        let v614 : (char -> (UH0 -> UH0)) = method40()
        let v615 : (char list -> (UH0 -> UH0)) = v613 v614
        let v616 : (UH0 -> UH0) = v615 v612
        let v617 : UH0 = UH0_0
        let v618 : UH0 = v616 v617
        let v619 : US8 = US8_0
        let struct (v620 : string, v621 : string) = method41(v603, v602, v618, v619)
        let v622 : (string []) = method42(v621)
        let v623 : string = "$0.to_vec()"
        let v624 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v622 v623
        let v625 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
        let v626 : (string -> std_string_String) = closure28()
        let v627 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v624, v626) v625
        let v628 : US0 = US0_1
        let v629 : (unit -> string) = closure29(v594, v592, v595, v596, v597, v598, v620, v627)
        let v630 : (unit -> string) = method47()
        method3(v628, v629, v630)
        let v631 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v594, v592, v595, v596, v597, v598, v620, v627)
        let v632 : string = "futures_lite::future::block_on($0)"
        let v633 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v631 v632
        let (a, b) = v633
        let v634 : int32 = a
        let v635 : string = b
        struct (v634, v635)
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let struct (v636 : int32, v637 : string) = null |> unbox<struct (int32 * string)>
        struct (v636, v637)
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let struct (v638 : int32, v639 : string) = null |> unbox<struct (int32 * string)>
        struct (v638, v639)
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let struct (v640 : int32, v641 : string) = null |> unbox<struct (int32 * string)>
        struct (v640, v641)
#endif
        
#if FABLE_COMPILER_PYTHON
        let struct (v642 : int32, v643 : string) = null |> unbox<struct (int32 * string)>
        struct (v642, v643)
#endif
        
#else
        let v644 : Async<struct (int32 * string)> option = None
        let v645 : bool = true in let mutable _v644 = v644
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v646 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v646
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v647 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v647
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v648 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v648
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v649 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v649
#endif
        
#if FABLE_COMPILER_PYTHON
        let v650 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v650
#endif
        
#else
        let v651 : Async<struct (int32 * string)> option = None
        let v652 : bool = true in let mutable _v651 = v651
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v653 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v653
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v654 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v654
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v655 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v655
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v656 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v656
#endif
        
#if FABLE_COMPILER_PYTHON
        let v657 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v657
#endif
        
#else
        let v658 : Async<struct (int32 * string)> option = None
        let mutable _v658 = v658
        async {
        let struct (v659 : string, v660 : string) = method39()
        let v661 : int32 = v592.Length
        let v662 : (char []) = Array.zeroCreate<char> (v661)
        let v663 : Mut5 = {l0 = 0} : Mut5
        while method26(v661, v663) do
            let v665 : int32 = v663.l0
            let v666 : char = v592.[int v665]
            v662.[int v665] <- v666
            let v667 : int32 = v665 + 1
            v663.l0 <- v667
            ()
        let v668 : ((char []) -> char list) = Array.toList
        let v669 : char list = v668 v662
        let v670 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
        let v671 : (char -> (UH0 -> UH0)) = method40()
        let v672 : (char list -> (UH0 -> UH0)) = v670 v671
        let v673 : (UH0 -> UH0) = v672 v669
        let v674 : UH0 = UH0_0
        let v675 : UH0 = v673 v674
        let v676 : US8 = US8_0
        let struct (v677 : string, v678 : string) = method41(v660, v659, v675, v676)
        let v679 : (string -> US4) = method19()
        let v680 : US4 = US4_1
        let v681 : US4 = v598 |> Option.map v679 |> Option.defaultValue v680 
        let v685 : string =
            match v681 with
            | US4_1 -> (* None *)
                let v683 : string = ""
                v683
            | US4_0(v682) -> (* Some *)
                v682
        let v686 : US0 = US0_1
        let v687 : (unit -> string) = closure48(v594, v592, v595, v596, v597, v598)
        let v688 : (unit -> string) = method47()
        method3(v686, v687, v688)
        let v689 : System.Text.Encoding = System.Text.Encoding.UTF8
        let v690 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v678, StandardOutputEncoding = v689, WorkingDirectory = v685, FileName = v677, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
        let v691 : int32 = v595.Length
        let v692 : Mut5 = {l0 = 0} : Mut5
        while method26(v691, v692) do
            let v694 : int32 = v692.l0
            let struct (v695 : string, v696 : string) = v595.[int v694]
            v690.EnvironmentVariables.[v695] <- v696 
            let v697 : int32 = v694 + 1
            v692.l0 <- v697
            ()
        let v698 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v690)
        use v698 = v698 
        let v699 : System.Diagnostics.Process = v698 
        let v700 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
        let v701 : System.Collections.Concurrent.ConcurrentStack<string> = v700 ()
        let v702 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v594, v592, v595, v596, v597, v598, v699, v701)
        v699.OutputDataReceived.Add v702 
        let v703 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v594, v592, v595, v596, v597, v598, v699, v701)
        v699.ErrorDataReceived.Add v703 
        let v704 : (unit -> bool) = v699.Start
        let v705 : bool = v704 ()
        let v706 : bool = v705 = false
        if v706 then
            let v707 : string = $"execute_with_options_async / process_start error"
            failwith<unit> v707
        let v708 : (unit -> unit) = v699.BeginErrorReadLine
        v708 ()
        let v709 : (unit -> unit) = v699.BeginOutputReadLine
        v709 ()
        let v710 : (System.Threading.CancellationToken -> US18) = method70()
        let v711 : US18 = US18_1
        let v712 : US18 = v594 |> Option.map v710 |> Option.defaultValue v711 
        let v716 : System.Threading.CancellationToken =
            match v712 with
            | US18_1 -> (* None *)
                let v714 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                v714
            | US18_0(v713) -> (* Some *)
                v713
        let v717 : Async<System.Threading.CancellationToken> option = None
        let v718 : bool = true in let mutable _v717 = v717
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v719 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v719
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v720 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v720
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v721 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v721
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v722 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v722
#endif
        
#if FABLE_COMPILER_PYTHON
        let v723 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v723
#endif
        
#else
        let v724 : Async<System.Threading.CancellationToken> option = None
        let v725 : bool = true in let mutable _v724 = v724
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v726 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v726
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v727 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v727
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v728 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v728
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v729 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v729
#endif
        
#if FABLE_COMPILER_PYTHON
        let v730 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v730
#endif
        
#else
        let v731 : Async<System.Threading.CancellationToken> option = None
        let mutable _v731 = v731
        async {
        let v732 : Async<System.Threading.CancellationToken> = Async.CancellationToken
        let! v732 = v732 
        let v733 : System.Threading.CancellationToken = v732 
        let v734 : System.Threading.CancellationToken = Async.DefaultCancellationToken
        let v735 : (System.Threading.CancellationToken []) = [|v733; v734; v716|]
        let v736 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
        let v737 : System.Threading.CancellationTokenSource = v736 v735
        let v738 : System.Threading.CancellationToken = v737.Token
        return v738 
        }
        |> fun x -> _v731 <- Some x
        let v739 : Async<System.Threading.CancellationToken> = _v731 |> Option.get
        v739
#endif
        |> fun x -> _v724 <- Some x
        let v740 : Async<System.Threading.CancellationToken> = _v724.Value
        v740
#endif
        |> fun x -> _v717 <- Some x
        let v741 : Async<System.Threading.CancellationToken> = _v717.Value
        let! v741 = v741 
        let v742 : System.Threading.CancellationToken = v741 
        let v743 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v742.Register
        let v744 : (unit -> unit) = closure54(v699)
        let v745 : System.Threading.CancellationTokenRegistration = v743 v744
        use v745 = v745 
        let v746 : System.Threading.CancellationTokenRegistration = v745 
        let v747 : Async<int32> option = None
        let v748 : bool = true in let mutable _v747 = v747
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v749 : Async<int32> = null |> unbox<Async<int32>>
        v749
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v750 : Async<int32> = null |> unbox<Async<int32>>
        v750
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v751 : Async<int32> = null |> unbox<Async<int32>>
        v751
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v752 : Async<int32> = null |> unbox<Async<int32>>
        v752
#endif
        
#if FABLE_COMPILER_PYTHON
        let v753 : Async<int32> = null |> unbox<Async<int32>>
        v753
#endif
        
#else
        let v754 : Async<int32> option = None
        let mutable _v754 = v754
        async {
        try
        let v755 : System.Threading.Tasks.Task = v699.WaitForExitAsync v742 
        let v756 : Async<unit> option = None
        let v757 : bool = true in let mutable _v756 = v756
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v758 : Async<unit> = null |> unbox<Async<unit>>
        v758
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v759 : Async<unit> = null |> unbox<Async<unit>>
        v759
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v760 : Async<unit> = null |> unbox<Async<unit>>
        v760
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v761 : Async<unit> = null |> unbox<Async<unit>>
        v761
#endif
        
#if FABLE_COMPILER_PYTHON
        let v762 : Async<unit> = null |> unbox<Async<unit>>
        v762
#endif
        
#else
        let v763 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
        let v764 : Async<unit> = v763 v755
        v764
#endif
        |> fun x -> _v756 <- Some x
        let v765 : Async<unit> = _v756.Value
        do! v765 
        let v766 : int32 = v699.ExitCode
        return v766 
        with ex ->
        let v767 : exn = ex
        let v768 : string option = None
        let v769 : bool = true in let mutable _v768 = v768
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v770 : string = $"%A{v767}"
        v770
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v771 : string = $"%A{v767}"
        v771
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v772 : string = $"%A{v767}"
        v772
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v773 : string = $"%A{v767}"
        v773
#endif
        
#if FABLE_COMPILER_PYTHON
        let v774 : string = $"%A{v767}"
        v774
#endif
        
#else
        let v775 : string = $"{v767.GetType ()}: {v767.Message}"
        v775
#endif
        |> fun x -> _v768 <- Some x
        let v776 : string = _v768.Value
        let v777 : (string -> unit) = v701.Push
        v777 v776
        let v778 : System.Threading.Tasks.TaskCanceledException = v767 |> unbox<System.Threading.Tasks.TaskCanceledException>
        let v779 : US0 = US0_3
        let v780 : (unit -> string) = closure55(v778)
        let v781 : (unit -> string) = method47()
        method3(v779, v780, v781)
        return -2147483648 
        (*
        *)
        }
        |> fun x -> _v754 <- Some x
        let v782 : Async<int32> = _v754 |> Option.get
        v782
#endif
        |> fun x -> _v747 <- Some x
        let v783 : Async<int32> = _v747.Value
        let! v783 = v783 
        let v784 : int32 = v783 
        let v785 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
        let v786 : string seq = v785 v701
        let v787 : string = method71()
        let v788 : (string -> (string seq -> string)) = String.concat
        let v789 : (string seq -> string) = v788 v787
        let v790 : string = v789 v786
        let v791 : US0 = US0_1
        let v792 : (unit -> string) = closure56(v784, v790)
        let v793 : (unit -> string) = method47()
        method3(v791, v792, v793)
        return struct (v784, v790) 
        }
        |> fun x -> _v658 <- Some x
        let v794 : Async<struct (int32 * string)> = _v658 |> Option.get
        v794
#endif
        |> fun x -> _v651 <- Some x
        let v795 : Async<struct (int32 * string)> = _v651.Value
        v795
#endif
        |> fun x -> _v644 <- Some x
        let v796 : Async<struct (int32 * string)> = _v644.Value
        let v797 : struct (int32 * string) option = None
        let v798 : bool = true in let mutable _v797 = v797
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let struct (v799 : int32, v800 : string) = null |> unbox<struct (int32 * string)>
        struct (v799, v800)
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let struct (v801 : int32, v802 : string) = null |> unbox<struct (int32 * string)>
        struct (v801, v802)
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let struct (v803 : int32, v804 : string) = null |> unbox<struct (int32 * string)>
        struct (v803, v804)
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let struct (v805 : int32, v806 : string) = null |> unbox<struct (int32 * string)>
        struct (v805, v806)
#endif
        
#if FABLE_COMPILER_PYTHON
        let struct (v807 : int32, v808 : string) = null |> unbox<struct (int32 * string)>
        struct (v807, v808)
#endif
        
#else
        let v809 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
        let struct (v810 : int32, v811 : string) = v809 v796
        struct (v810, v811)
#endif
        |> fun x -> _v797 <- Some x
        let struct (v812 : int32, v813 : string) = _v797.Value
        struct (v812, v813)
#endif
        |> fun x -> _v599 <- Some x
        let struct (v814 : int32, v815 : string) = _v599.Value
        let v816 : string = "ERROR"
        let v817 : bool = v815.Contains v816
        let v823 : US20 =
            if v817 then
                let v818 : US0 = US0_2
                let v819 : (unit -> string) = closure62()
                let v820 : (unit -> string) = closure63(v815, v814)
                method3(v818, v819, v820)
                US20_1(v814, v815)
            else
                US20_0(v814, v815)
        match v823 with
        | US20_1(v867, v868) -> (* Error *)
            let v869 : (string * string) = v18, v868
            let v870 : Result<string, (string * string)> = Error v869
            US19_0(v870)
        | US20_0(v824, v825) -> (* Ok *)
            let v826 : bool = v824 <> 0
            if v826 then
                let v827 : US0 = US0_2
                let v828 : (unit -> string) = closure59()
                let v829 : (unit -> string) = closure60(v825, v824)
                method3(v827, v828, v829)
                let v830 : (string * string) = v18, v825
                let v831 : Result<string, (string * string)> = Error v830
                US19_0(v831)
            else
                let v833 : bool option = None
                let v834 : bool = true in let mutable _v833 = v833
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v835 : string = method14(v18)
                let v836 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                let v837 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v835 v836
                let v838 : string = "String::from($0)"
                let v839 : std_string_String = Fable.Core.RustInterop.emitRustExpr v837 v838
                let v840 : string = "std::path::PathBuf::from($0)"
                let v841 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v839 v840
                let v842 : string = "$0.exists()"
                let v843 : bool = Fable.Core.RustInterop.emitRustExpr v841 v842
                let v846 : bool =
                    if v843 then
                        let v844 : string = "$0.is_file()"
                        let v845 : bool = Fable.Core.RustInterop.emitRustExpr v841 v844
                        v845
                    else
                        false
                v846
#endif
                
#if FABLE_COMPILER_RUST && WASM
                let v847 : bool = null |> unbox<bool>
                v847
#endif
                
#if FABLE_COMPILER_RUST && CONTRACT
                let v848 : bool = null |> unbox<bool>
                v848
#endif
                
#if FABLE_COMPILER_TYPESCRIPT
                let v849 : IFsExistsSync = Fable.Core.JsInterop.importAll v38
                let v850 : string = "v849.existsSync($0)"
                let v851 : bool = Fable.Core.JsInterop.emitJsExpr v18 v850
                v851
#endif
                
#if FABLE_COMPILER_PYTHON
                let v852 : bool = null |> unbox<bool>
                v852
#endif
                
#else
                let v853 : (string -> bool) = System.IO.File.Exists
                let v854 : bool = v853 v18
                v854
#endif
                |> fun x -> _v833 <- Some x
                let v855 : bool = _v833.Value
                if v855 then
                    let v856 : unit option = None
                    let v857 : bool = true in let mutable _v856 = v856
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v858 : string = method77(v21)
                    let v859 : string = "std::fs::copy(&*v18, &*v858)"
                    let v860 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v859
                    let v861 : string = "$0.unwrap()"
                    let v862 : uint64 = Fable.Core.RustInterop.emitRustExpr v860 v861
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
                    System.IO.File.Copy (v18, v21, true)
                    ()
#endif
                    |> fun x -> _v856 <- Some x
                    _v856.Value
                    ()
                else
                    let v863 : string = $"documents.run / files_fn / {v18} should exist"
                    failwith<unit> v863
                let v864 : Result<string, (string * string)> = Ok v18
                US19_0(v864)
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
and method78 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method79 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
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
    let v180 : string =
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
            let v49 : bool option = None
            let v50 : bool = true in let mutable _v49 = v49
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v51 : string = "cfg!(windows)"
            let v52 : bool = Fable.Core.RustInterop.emitRustExpr () v51
            v52
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v53 : bool = null |> unbox<bool>
            v53
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v54 : bool = null |> unbox<bool>
            v54
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v55 : bool = null |> unbox<bool>
            v55
#endif
            
#if FABLE_COMPILER_PYTHON
            let v56 : bool = null |> unbox<bool>
            v56
#endif
            
#else
            let v57 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v58 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v59 : bool = v58 v57
            v59
#endif
            |> fun x -> _v49 <- Some x
            let v60 : bool = _v49.Value
            let v61 : bool = v60 = false
            let v85 : string =
                if v61 then
                    v48
                else
                    let v62 : string option = None
                    let v63 : bool = true in let mutable _v62 = v62
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v64 : string = method22()
                    let v65 : string = method23(v48)
                    let v66 : string = method24()
                    let v67 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v68 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v64, v65, v66) v67
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
                    let v77 : string = "^\\\\\\\\\\?\\\\"
                    let v78 : string = ""
                    let v79 : string = System.Text.RegularExpressions.Regex.Replace (v48, v77, v78)
                    v79
#endif
                    |> fun x -> _v62 <- Some x
                    let v80 : string = _v62.Value
                    let v81 : string = $"{v80.[0] |> string |> _.ToLower()}{v80.[1..]}"
                    let v82 : string = "\\"
                    let v83 : string = "/"
                    let v84 : string = v81.Replace (v82, v83)
                    v84
            let v86 : string = "/"
            let v87 : (string []) = v85.Split v86
            let v88 : (string []) = [||]
            let v89 : int32 = v87.Length
            let v90 : Mut4 = {l0 = 0; l1 = 0; l2 = v88} : Mut4
            while method25(v89, v90) do
                let v92 : int32 = v90.l0
                let v93 : int32 =  -v92
                let v94 : int32 = v93 + v89
                let v95 : int32 = v94 - 1
                let struct (v96 : int32, v97 : (string [])) = v90.l1, v90.l2
                let v98 : string = v87.[int v95]
                let v99 : bool = ".." = v98
                let struct (v138 : int32, v139 : (string [])) =
                    if v99 then
                        let v100 : int32 = v96 + 1
                        struct (v100, v97)
                    else
                        let v101 : bool = 0 = v96
                        if v101 then
                            let v102 : string = ":"
                            let v103 : bool = v98.EndsWith v102
                            if v103 then
                                let v104 : string = $"{v47.[0]}:"
                                let v105 : (string []) = [|v104|]
                                let v106 : int32 = v105.Length
                                let v107 : int32 = v97.Length
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
                                            let v116 : string = v97.[int v115]
                                            v116
                                    v109.[int v112] <- v117
                                    let v118 : int32 = v112 + 1
                                    v110.l0 <- v118
                                    ()
                                struct (0, v109)
                            else
                                let v119 : (string []) = [|v98|]
                                let v120 : int32 = v119.Length
                                let v121 : int32 = v97.Length
                                let v122 : int32 = v120 + v121
                                let v123 : (string []) = Array.zeroCreate<string> (v122)
                                let v124 : Mut5 = {l0 = 0} : Mut5
                                while method26(v122, v124) do
                                    let v126 : int32 = v124.l0
                                    let v127 : bool = v126 < v120
                                    let v131 : string =
                                        if v127 then
                                            let v128 : string = v119.[int v126]
                                            v128
                                        else
                                            let v129 : int32 = v126 - v120
                                            let v130 : string = v97.[int v129]
                                            v130
                                    v123.[int v126] <- v131
                                    let v132 : int32 = v126 + 1
                                    v124.l0 <- v132
                                    ()
                                struct (0, v123)
                        else
                            let v135 : int32 = v96 - 1
                            struct (v135, v97)
                let v140 : int32 = v92 + 1
                v90.l0 <- v140
                v90.l1 <- v138
                v90.l2 <- v139
                ()
            let struct (v141 : int32, v142 : (string [])) = v90.l1, v90.l2
            let v143 : string seq = seq { for i = 0 to v142.Length - 1 do yield v142.[i] }
            let v144 : char option = None
            let v145 : bool = true in let mutable _v144 = v144
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v146 : string = "std::path::MAIN_SEPARATOR"
            let v147 : char = Fable.Core.RustInterop.emitRustExpr () v146
            v147
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v148 : char = null |> unbox<char>
            v148
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v149 : char = null |> unbox<char>
            v149
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v150 : char = null |> unbox<char>
            v150
#endif
            
#if FABLE_COMPILER_PYTHON
            let v151 : char = null |> unbox<char>
            v151
#endif
            
#else
            let v152 : char = System.IO.Path.DirectorySeparatorChar
            v152
#endif
            |> fun x -> _v144 <- Some x
            let v153 : char = _v144.Value
            let v154 : (char -> string) = _.ToString()
            let v155 : string = v154 v153
            let v156 : string = method27(v155)
            let v157 : (string -> (string seq -> string)) = String.concat
            let v158 : (string seq -> string) = v157 v156
            v158 v143
        else
            let v160 : string = "std::fs::canonicalize(&*$0)"
            let v161 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v8 v160
            let v162 : string = "$0.unwrap()"
            let v163 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v161 v162
            let v164 : string = "$0.display()"
            let v165 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v163 v164
            let v166 : std_string_String option = None
            let v167 : bool = true in let mutable _v166 = v166
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v168 : string = @$"format!(""{{}}"", $0)"
            let v169 : std_string_String = Fable.Core.RustInterop.emitRustExpr v165 v168
            v169
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v170 : string = @$"format!(""{{}}"", $0)"
            let v171 : std_string_String = Fable.Core.RustInterop.emitRustExpr v165 v170
            v171
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v172 : string = @$"format!(""{{}}"", $0)"
            let v173 : std_string_String = Fable.Core.RustInterop.emitRustExpr v165 v172
            v173
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v174 : std_string_String = null |> unbox<std_string_String>
            v174
#endif
            
#if FABLE_COMPILER_PYTHON
            let v175 : std_string_String = null |> unbox<std_string_String>
            v175
#endif
            
#else
            let v176 : std_string_String = null |> unbox<std_string_String>
            v176
#endif
            |> fun x -> _v166 <- Some x
            let v177 : std_string_String = _v166.Value
            let v178 : string = "fable_library_rust::String_::fromString($0)"
            let v179 : string = Fable.Core.RustInterop.emitRustExpr v177 v178
            v179
    v180
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v181 : string = null |> unbox<string>
    v181
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v182 : string = null |> unbox<string>
    v182
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v183 : string = null |> unbox<string>
    v183
#endif
    
#if FABLE_COMPILER_PYTHON
    let v184 : string = null |> unbox<string>
    v184
#endif
    
#else
    let v185 : string = method28(v5)
    let v186 : (string -> string) = System.IO.Path.GetFullPath
    let v187 : string = v186 v185
    v187
#endif
    |> fun x -> _v6 <- Some x
    let v188 : string = _v6.Value
    let v189 : string = method14(v188)
    let v190 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v191 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v189 v190
    let v192 : string = "String::from($0)"
    let v193 : std_string_String = Fable.Core.RustInterop.emitRustExpr v191 v192
    let v194 : string = "std::path::PathBuf::from($0)"
    let v195 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v193 v194
    let v196 : string = "$0.display()"
    let v197 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v195 v196
    let v198 : std_string_String option = None
    let v199 : bool = true in let mutable _v198 = v198
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v200 : string = @$"format!(""{{}}"", $0)"
    let v201 : std_string_String = Fable.Core.RustInterop.emitRustExpr v197 v200
    v201
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v202 : string = @$"format!(""{{}}"", $0)"
    let v203 : std_string_String = Fable.Core.RustInterop.emitRustExpr v197 v202
    v203
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v204 : string = @$"format!(""{{}}"", $0)"
    let v205 : std_string_String = Fable.Core.RustInterop.emitRustExpr v197 v204
    v205
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v206 : std_string_String = null |> unbox<std_string_String>
    v206
#endif
    
#if FABLE_COMPILER_PYTHON
    let v207 : std_string_String = null |> unbox<std_string_String>
    v207
#endif
    
#else
    let v208 : std_string_String = null |> unbox<std_string_String>
    v208
#endif
    |> fun x -> _v198 <- Some x
    let v209 : std_string_String = _v198.Value
    let v210 : string = "fable_library_rust::String_::fromString($0)"
    let v211 : string = Fable.Core.RustInterop.emitRustExpr v209 v210
    let v212 : string = ""
    let v213 : string = v211.Replace (v3, v212)
    let v214 : string = "\\"
    let v215 : string = "/"
    let v216 : string = v213.Replace (v214, v215)
    let v217 : string = $".{v216}"
    let v218 : bool option = None
    let v219 : bool = true in let mutable _v218 = v218
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v220 : string = "cfg!(windows)"
    let v221 : bool = Fable.Core.RustInterop.emitRustExpr () v220
    v221
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v222 : bool = null |> unbox<bool>
    v222
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v223 : bool = null |> unbox<bool>
    v223
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v224 : bool = null |> unbox<bool>
    v224
#endif
    
#if FABLE_COMPILER_PYTHON
    let v225 : bool = null |> unbox<bool>
    v225
#endif
    
#else
    let v226 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v227 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v228 : bool = v227 v226
    v228
#endif
    |> fun x -> _v218 <- Some x
    let v229 : bool = _v218.Value
    let v230 : bool = v229 = false
    let v251 : string =
        if v230 then
            v188
        else
            let v231 : string option = None
            let v232 : bool = true in let mutable _v231 = v231
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v233 : string = method22()
            let v234 : string = method23(v188)
            let v235 : string = method24()
            let v236 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v237 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v233, v234, v235) v236
            let v238 : string = "String::from($0)"
            let v239 : std_string_String = Fable.Core.RustInterop.emitRustExpr v237 v238
            let v240 : string = "fable_library_rust::String_::fromString($0)"
            let v241 : string = Fable.Core.RustInterop.emitRustExpr v239 v240
            v241
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v242 : string = null |> unbox<string>
            v242
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v243 : string = null |> unbox<string>
            v243
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v244 : string = null |> unbox<string>
            v244
#endif
            
#if FABLE_COMPILER_PYTHON
            let v245 : string = null |> unbox<string>
            v245
#endif
            
#else
            let v246 : string = "^\\\\\\\\\\?\\\\"
            let v247 : string = System.Text.RegularExpressions.Regex.Replace (v188, v246, v212)
            v247
#endif
            |> fun x -> _v231 <- Some x
            let v248 : string = _v231.Value
            let v249 : string = $"{v248.[0] |> string |> _.ToLower()}{v248.[1..]}"
            let v250 : string = v249.Replace (v214, v215)
            v250
    let v252 : string = method13(v2, v217)
    let v253 : bool option = None
    let v254 : bool = true in let mutable _v253 = v253
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v255 : string = "cfg!(windows)"
    let v256 : bool = Fable.Core.RustInterop.emitRustExpr () v255
    v256
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v257 : bool = null |> unbox<bool>
    v257
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v258 : bool = null |> unbox<bool>
    v258
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v259 : bool = null |> unbox<bool>
    v259
#endif
    
#if FABLE_COMPILER_PYTHON
    let v260 : bool = null |> unbox<bool>
    v260
#endif
    
#else
    let v261 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v262 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v263 : bool = v262 v261
    v263
#endif
    |> fun x -> _v253 <- Some x
    let v264 : bool = _v253.Value
    let v265 : bool = v264 = false
    let v286 : string =
        if v265 then
            v252
        else
            let v266 : string option = None
            let v267 : bool = true in let mutable _v266 = v266
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v268 : string = method22()
            let v269 : string = method23(v252)
            let v270 : string = method24()
            let v271 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v272 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v268, v269, v270) v271
            let v273 : string = "String::from($0)"
            let v274 : std_string_String = Fable.Core.RustInterop.emitRustExpr v272 v273
            let v275 : string = "fable_library_rust::String_::fromString($0)"
            let v276 : string = Fable.Core.RustInterop.emitRustExpr v274 v275
            v276
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v277 : string = null |> unbox<string>
            v277
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v278 : string = null |> unbox<string>
            v278
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v279 : string = null |> unbox<string>
            v279
#endif
            
#if FABLE_COMPILER_PYTHON
            let v280 : string = null |> unbox<string>
            v280
#endif
            
#else
            let v281 : string = "^\\\\\\\\\\?\\\\"
            let v282 : string = System.Text.RegularExpressions.Regex.Replace (v252, v281, v212)
            v282
#endif
            |> fun x -> _v266 <- Some x
            let v283 : string = _v266.Value
            let v284 : string = $"{v283.[0] |> string |> _.ToLower()}{v283.[1..]}"
            let v285 : string = v284.Replace (v214, v215)
            v285
    let v287 : string option = None
    let v288 : System.Threading.CancellationToken option = None
    let v289 : (struct (string * string) []) = [||]
    let v290 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v291 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v292 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v286}\""
    let v293 : string option = Some v2 
    let v294 : struct (int32 * string) option = None
    let v295 : bool = true in let mutable _v294 = v294
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v296 : string = method38(v288, v292, v289, v290, v291, v293)
    let struct (v297 : string, v298 : string) = method39()
    let v299 : int32 = v296.Length
    let v300 : (char []) = Array.zeroCreate<char> (v299)
    let v301 : Mut5 = {l0 = 0} : Mut5
    while method26(v299, v301) do
        let v303 : int32 = v301.l0
        let v304 : char = v296.[int v303]
        v300.[int v303] <- v304
        let v305 : int32 = v303 + 1
        v301.l0 <- v305
        ()
    let v306 : ((char []) -> char list) = Array.toList
    let v307 : char list = v306 v300
    let v308 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v309 : (char -> (UH0 -> UH0)) = method40()
    let v310 : (char list -> (UH0 -> UH0)) = v308 v309
    let v311 : (UH0 -> UH0) = v310 v307
    let v312 : UH0 = UH0_0
    let v313 : UH0 = v311 v312
    let v314 : US8 = US8_0
    let struct (v315 : string, v316 : string) = method41(v298, v297, v313, v314)
    let v317 : (string []) = method42(v316)
    let v318 : string = "$0.to_vec()"
    let v319 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v317 v318
    let v320 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v321 : (string -> std_string_String) = closure28()
    let v322 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v319, v321) v320
    let v323 : US0 = US0_1
    let v324 : (unit -> string) = closure29(v288, v292, v289, v290, v291, v293, v315, v322)
    let v325 : (unit -> string) = method47()
    method3(v323, v324, v325)
    let v326 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v288, v292, v289, v290, v291, v293, v315, v322)
    let v327 : string = "futures_lite::future::block_on($0)"
    let v328 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v326 v327
    let (a, b) = v328
    let v329 : int32 = a
    let v330 : string = b
    struct (v329, v330)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v331 : int32, v332 : string) = null |> unbox<struct (int32 * string)>
    struct (v331, v332)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v333 : int32, v334 : string) = null |> unbox<struct (int32 * string)>
    struct (v333, v334)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v335 : int32, v336 : string) = null |> unbox<struct (int32 * string)>
    struct (v335, v336)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v337 : int32, v338 : string) = null |> unbox<struct (int32 * string)>
    struct (v337, v338)
#endif
    
#else
    let v339 : Async<struct (int32 * string)> option = None
    let v340 : bool = true in let mutable _v339 = v339
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v341 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v341
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v342 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v342
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v343 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v343
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v344 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v344
#endif
    
#if FABLE_COMPILER_PYTHON
    let v345 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v345
#endif
    
#else
    let v346 : Async<struct (int32 * string)> option = None
    let v347 : bool = true in let mutable _v346 = v346
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v348 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v348
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v349 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v349
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v350 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v350
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v351 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v351
#endif
    
#if FABLE_COMPILER_PYTHON
    let v352 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v352
#endif
    
#else
    let v353 : Async<struct (int32 * string)> option = None
    let mutable _v353 = v353
    async {
    let struct (v354 : string, v355 : string) = method39()
    let v356 : int32 = v292.Length
    let v357 : (char []) = Array.zeroCreate<char> (v356)
    let v358 : Mut5 = {l0 = 0} : Mut5
    while method26(v356, v358) do
        let v360 : int32 = v358.l0
        let v361 : char = v292.[int v360]
        v357.[int v360] <- v361
        let v362 : int32 = v360 + 1
        v358.l0 <- v362
        ()
    let v363 : ((char []) -> char list) = Array.toList
    let v364 : char list = v363 v357
    let v365 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v366 : (char -> (UH0 -> UH0)) = method40()
    let v367 : (char list -> (UH0 -> UH0)) = v365 v366
    let v368 : (UH0 -> UH0) = v367 v364
    let v369 : UH0 = UH0_0
    let v370 : UH0 = v368 v369
    let v371 : US8 = US8_0
    let struct (v372 : string, v373 : string) = method41(v355, v354, v370, v371)
    let v374 : (string -> US4) = method19()
    let v375 : US4 = US4_1
    let v376 : US4 = v293 |> Option.map v374 |> Option.defaultValue v375 
    let v379 : string =
        match v376 with
        | US4_1 -> (* None *)
            v212
        | US4_0(v377) -> (* Some *)
            v377
    let v380 : US0 = US0_1
    let v381 : (unit -> string) = closure48(v288, v292, v289, v290, v291, v293)
    let v382 : (unit -> string) = method47()
    method3(v380, v381, v382)
    let v383 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v384 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v373, StandardOutputEncoding = v383, WorkingDirectory = v379, FileName = v372, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v385 : int32 = v289.Length
    let v386 : Mut5 = {l0 = 0} : Mut5
    while method26(v385, v386) do
        let v388 : int32 = v386.l0
        let struct (v389 : string, v390 : string) = v289.[int v388]
        v384.EnvironmentVariables.[v389] <- v390 
        let v391 : int32 = v388 + 1
        v386.l0 <- v391
        ()
    let v392 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v384)
    use v392 = v392 
    let v393 : System.Diagnostics.Process = v392 
    let v394 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v395 : System.Collections.Concurrent.ConcurrentStack<string> = v394 ()
    let v396 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v288, v292, v289, v290, v291, v293, v393, v395)
    v393.OutputDataReceived.Add v396 
    let v397 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v288, v292, v289, v290, v291, v293, v393, v395)
    v393.ErrorDataReceived.Add v397 
    let v398 : (unit -> bool) = v393.Start
    let v399 : bool = v398 ()
    let v400 : bool = v399 = false
    if v400 then
        let v401 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v401
    let v402 : (unit -> unit) = v393.BeginErrorReadLine
    v402 ()
    let v403 : (unit -> unit) = v393.BeginOutputReadLine
    v403 ()
    let v404 : (System.Threading.CancellationToken -> US18) = method70()
    let v405 : US18 = US18_1
    let v406 : US18 = v288 |> Option.map v404 |> Option.defaultValue v405 
    let v410 : System.Threading.CancellationToken =
        match v406 with
        | US18_1 -> (* None *)
            let v408 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v408
        | US18_0(v407) -> (* Some *)
            v407
    let v411 : Async<System.Threading.CancellationToken> option = None
    let v412 : bool = true in let mutable _v411 = v411
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v413 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v413
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v414 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v414
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v415 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v415
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v416 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v416
#endif
    
#if FABLE_COMPILER_PYTHON
    let v417 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v417
#endif
    
#else
    let v418 : Async<System.Threading.CancellationToken> option = None
    let v419 : bool = true in let mutable _v418 = v418
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v420 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v420
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v421 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v421
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v422 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v422
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v423 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v423
#endif
    
#if FABLE_COMPILER_PYTHON
    let v424 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v424
#endif
    
#else
    let v425 : Async<System.Threading.CancellationToken> option = None
    let mutable _v425 = v425
    async {
    let v426 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v426 = v426 
    let v427 : System.Threading.CancellationToken = v426 
    let v428 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v429 : (System.Threading.CancellationToken []) = [|v427; v428; v410|]
    let v430 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v431 : System.Threading.CancellationTokenSource = v430 v429
    let v432 : System.Threading.CancellationToken = v431.Token
    return v432 
    }
    |> fun x -> _v425 <- Some x
    let v433 : Async<System.Threading.CancellationToken> = _v425 |> Option.get
    v433
#endif
    |> fun x -> _v418 <- Some x
    let v434 : Async<System.Threading.CancellationToken> = _v418.Value
    v434
#endif
    |> fun x -> _v411 <- Some x
    let v435 : Async<System.Threading.CancellationToken> = _v411.Value
    let! v435 = v435 
    let v436 : System.Threading.CancellationToken = v435 
    let v437 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v436.Register
    let v438 : (unit -> unit) = closure54(v393)
    let v439 : System.Threading.CancellationTokenRegistration = v437 v438
    use v439 = v439 
    let v440 : System.Threading.CancellationTokenRegistration = v439 
    let v441 : Async<int32> option = None
    let v442 : bool = true in let mutable _v441 = v441
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v443 : Async<int32> = null |> unbox<Async<int32>>
    v443
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v444 : Async<int32> = null |> unbox<Async<int32>>
    v444
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v445 : Async<int32> = null |> unbox<Async<int32>>
    v445
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v446 : Async<int32> = null |> unbox<Async<int32>>
    v446
#endif
    
#if FABLE_COMPILER_PYTHON
    let v447 : Async<int32> = null |> unbox<Async<int32>>
    v447
#endif
    
#else
    let v448 : Async<int32> option = None
    let mutable _v448 = v448
    async {
    try
    let v449 : System.Threading.Tasks.Task = v393.WaitForExitAsync v436 
    let v450 : Async<unit> option = None
    let v451 : bool = true in let mutable _v450 = v450
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v452 : Async<unit> = null |> unbox<Async<unit>>
    v452
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v453 : Async<unit> = null |> unbox<Async<unit>>
    v453
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v454 : Async<unit> = null |> unbox<Async<unit>>
    v454
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v455 : Async<unit> = null |> unbox<Async<unit>>
    v455
#endif
    
#if FABLE_COMPILER_PYTHON
    let v456 : Async<unit> = null |> unbox<Async<unit>>
    v456
#endif
    
#else
    let v457 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v458 : Async<unit> = v457 v449
    v458
#endif
    |> fun x -> _v450 <- Some x
    let v459 : Async<unit> = _v450.Value
    do! v459 
    let v460 : int32 = v393.ExitCode
    return v460 
    with ex ->
    let v461 : exn = ex
    let v462 : string option = None
    let v463 : bool = true in let mutable _v462 = v462
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v464 : string = $"%A{v461}"
    v464
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v465 : string = $"%A{v461}"
    v465
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v466 : string = $"%A{v461}"
    v466
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v467 : string = $"%A{v461}"
    v467
#endif
    
#if FABLE_COMPILER_PYTHON
    let v468 : string = $"%A{v461}"
    v468
#endif
    
#else
    let v469 : string = $"{v461.GetType ()}: {v461.Message}"
    v469
#endif
    |> fun x -> _v462 <- Some x
    let v470 : string = _v462.Value
    let v471 : (string -> unit) = v395.Push
    v471 v470
    let v472 : System.Threading.Tasks.TaskCanceledException = v461 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v473 : US0 = US0_3
    let v474 : (unit -> string) = closure55(v472)
    let v475 : (unit -> string) = method47()
    method3(v473, v474, v475)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v448 <- Some x
    let v476 : Async<int32> = _v448 |> Option.get
    v476
#endif
    |> fun x -> _v441 <- Some x
    let v477 : Async<int32> = _v441.Value
    let! v477 = v477 
    let v478 : int32 = v477 
    let v479 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v480 : string seq = v479 v395
    let v481 : string = method71()
    let v482 : (string -> (string seq -> string)) = String.concat
    let v483 : (string seq -> string) = v482 v481
    let v484 : string = v483 v480
    let v485 : US0 = US0_1
    let v486 : (unit -> string) = closure56(v478, v484)
    let v487 : (unit -> string) = method47()
    method3(v485, v486, v487)
    return struct (v478, v484) 
    }
    |> fun x -> _v353 <- Some x
    let v488 : Async<struct (int32 * string)> = _v353 |> Option.get
    v488
#endif
    |> fun x -> _v346 <- Some x
    let v489 : Async<struct (int32 * string)> = _v346.Value
    v489
#endif
    |> fun x -> _v339 <- Some x
    let v490 : Async<struct (int32 * string)> = _v339.Value
    let v491 : struct (int32 * string) option = None
    let v492 : bool = true in let mutable _v491 = v491
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v493 : int32, v494 : string) = null |> unbox<struct (int32 * string)>
    struct (v493, v494)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v495 : int32, v496 : string) = null |> unbox<struct (int32 * string)>
    struct (v495, v496)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v497 : int32, v498 : string) = null |> unbox<struct (int32 * string)>
    struct (v497, v498)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v499 : int32, v500 : string) = null |> unbox<struct (int32 * string)>
    struct (v499, v500)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v501 : int32, v502 : string) = null |> unbox<struct (int32 * string)>
    struct (v501, v502)
#endif
    
#else
    let v503 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v504 : int32, v505 : string) = v503 v490
    struct (v504, v505)
#endif
    |> fun x -> _v491 <- Some x
    let struct (v506 : int32, v507 : string) = _v491.Value
    struct (v506, v507)
#endif
    |> fun x -> _v294 <- Some x
    let struct (v508 : int32, v509 : string) = _v294.Value
    let v510 : string = method13(v3, v217)
    let v511 : bool option = None
    let v512 : bool = true in let mutable _v511 = v511
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v513 : string = "cfg!(windows)"
    let v514 : bool = Fable.Core.RustInterop.emitRustExpr () v513
    v514
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v515 : bool = null |> unbox<bool>
    v515
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v516 : bool = null |> unbox<bool>
    v516
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v517 : bool = null |> unbox<bool>
    v517
#endif
    
#if FABLE_COMPILER_PYTHON
    let v518 : bool = null |> unbox<bool>
    v518
#endif
    
#else
    let v519 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v520 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v521 : bool = v520 v519
    v521
#endif
    |> fun x -> _v511 <- Some x
    let v522 : bool = _v511.Value
    let v523 : bool = v522 = false
    let v544 : string =
        if v523 then
            v510
        else
            let v524 : string option = None
            let v525 : bool = true in let mutable _v524 = v524
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v526 : string = method22()
            let v527 : string = method23(v510)
            let v528 : string = method24()
            let v529 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v530 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v526, v527, v528) v529
            let v531 : string = "String::from($0)"
            let v532 : std_string_String = Fable.Core.RustInterop.emitRustExpr v530 v531
            let v533 : string = "fable_library_rust::String_::fromString($0)"
            let v534 : string = Fable.Core.RustInterop.emitRustExpr v532 v533
            v534
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v535 : string = null |> unbox<string>
            v535
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v536 : string = null |> unbox<string>
            v536
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v537 : string = null |> unbox<string>
            v537
#endif
            
#if FABLE_COMPILER_PYTHON
            let v538 : string = null |> unbox<string>
            v538
#endif
            
#else
            let v539 : string = "^\\\\\\\\\\?\\\\"
            let v540 : string = System.Text.RegularExpressions.Regex.Replace (v510, v539, v212)
            v540
#endif
            |> fun x -> _v524 <- Some x
            let v541 : string = _v524.Value
            let v542 : string = $"{v541.[0] |> string |> _.ToLower()}{v541.[1..]}"
            let v543 : string = v542.Replace (v214, v215)
            v543
    let v545 : string option = None
    let v546 : System.Threading.CancellationToken option = None
    let v547 : (struct (string * string) []) = [||]
    let v548 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v549 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v550 : string = $"git hash-object \"{v544}\""
    let v551 : string option = Some v3 
    let v552 : struct (int32 * string) option = None
    let v553 : bool = true in let mutable _v552 = v552
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v554 : string = method38(v546, v550, v547, v548, v549, v551)
    let struct (v555 : string, v556 : string) = method39()
    let v557 : int32 = v554.Length
    let v558 : (char []) = Array.zeroCreate<char> (v557)
    let v559 : Mut5 = {l0 = 0} : Mut5
    while method26(v557, v559) do
        let v561 : int32 = v559.l0
        let v562 : char = v554.[int v561]
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
    let v575 : (string []) = method42(v574)
    let v576 : string = "$0.to_vec()"
    let v577 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v575 v576
    let v578 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v579 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v577, v321) v578
    let v580 : US0 = US0_1
    let v581 : (unit -> string) = closure29(v546, v550, v547, v548, v549, v551, v573, v579)
    let v582 : (unit -> string) = method47()
    method3(v580, v581, v582)
    let v583 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v546, v550, v547, v548, v549, v551, v573, v579)
    let v584 : string = "futures_lite::future::block_on($0)"
    let v585 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v583 v584
    let (a, b) = v585
    let v586 : int32 = a
    let v587 : string = b
    struct (v586, v587)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v588 : int32, v589 : string) = null |> unbox<struct (int32 * string)>
    struct (v588, v589)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v590 : int32, v591 : string) = null |> unbox<struct (int32 * string)>
    struct (v590, v591)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v592 : int32, v593 : string) = null |> unbox<struct (int32 * string)>
    struct (v592, v593)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v594 : int32, v595 : string) = null |> unbox<struct (int32 * string)>
    struct (v594, v595)
#endif
    
#else
    let v596 : Async<struct (int32 * string)> option = None
    let v597 : bool = true in let mutable _v596 = v596
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v598 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v598
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v599 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v599
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v600 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v600
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v601 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v601
#endif
    
#if FABLE_COMPILER_PYTHON
    let v602 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v602
#endif
    
#else
    let v603 : Async<struct (int32 * string)> option = None
    let v604 : bool = true in let mutable _v603 = v603
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v605 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v605
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v606 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v606
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v607 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v607
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v608 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v608
#endif
    
#if FABLE_COMPILER_PYTHON
    let v609 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v609
#endif
    
#else
    let v610 : Async<struct (int32 * string)> option = None
    let mutable _v610 = v610
    async {
    let struct (v611 : string, v612 : string) = method39()
    let v613 : int32 = v550.Length
    let v614 : (char []) = Array.zeroCreate<char> (v613)
    let v615 : Mut5 = {l0 = 0} : Mut5
    while method26(v613, v615) do
        let v617 : int32 = v615.l0
        let v618 : char = v550.[int v617]
        v614.[int v617] <- v618
        let v619 : int32 = v617 + 1
        v615.l0 <- v619
        ()
    let v620 : ((char []) -> char list) = Array.toList
    let v621 : char list = v620 v614
    let v622 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v623 : (char -> (UH0 -> UH0)) = method40()
    let v624 : (char list -> (UH0 -> UH0)) = v622 v623
    let v625 : (UH0 -> UH0) = v624 v621
    let v626 : UH0 = UH0_0
    let v627 : UH0 = v625 v626
    let v628 : US8 = US8_0
    let struct (v629 : string, v630 : string) = method41(v612, v611, v627, v628)
    let v631 : (string -> US4) = method19()
    let v632 : US4 = US4_1
    let v633 : US4 = v551 |> Option.map v631 |> Option.defaultValue v632 
    let v636 : string =
        match v633 with
        | US4_1 -> (* None *)
            v212
        | US4_0(v634) -> (* Some *)
            v634
    let v637 : US0 = US0_1
    let v638 : (unit -> string) = closure48(v546, v550, v547, v548, v549, v551)
    let v639 : (unit -> string) = method47()
    method3(v637, v638, v639)
    let v640 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v641 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v630, StandardOutputEncoding = v640, WorkingDirectory = v636, FileName = v629, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v642 : int32 = v547.Length
    let v643 : Mut5 = {l0 = 0} : Mut5
    while method26(v642, v643) do
        let v645 : int32 = v643.l0
        let struct (v646 : string, v647 : string) = v547.[int v645]
        v641.EnvironmentVariables.[v646] <- v647 
        let v648 : int32 = v645 + 1
        v643.l0 <- v648
        ()
    let v649 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v641)
    use v649 = v649 
    let v650 : System.Diagnostics.Process = v649 
    let v651 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v652 : System.Collections.Concurrent.ConcurrentStack<string> = v651 ()
    let v653 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v546, v550, v547, v548, v549, v551, v650, v652)
    v650.OutputDataReceived.Add v653 
    let v654 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v546, v550, v547, v548, v549, v551, v650, v652)
    v650.ErrorDataReceived.Add v654 
    let v655 : (unit -> bool) = v650.Start
    let v656 : bool = v655 ()
    let v657 : bool = v656 = false
    if v657 then
        let v658 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v658
    let v659 : (unit -> unit) = v650.BeginErrorReadLine
    v659 ()
    let v660 : (unit -> unit) = v650.BeginOutputReadLine
    v660 ()
    let v661 : (System.Threading.CancellationToken -> US18) = method70()
    let v662 : US18 = US18_1
    let v663 : US18 = v546 |> Option.map v661 |> Option.defaultValue v662 
    let v667 : System.Threading.CancellationToken =
        match v663 with
        | US18_1 -> (* None *)
            let v665 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v665
        | US18_0(v664) -> (* Some *)
            v664
    let v668 : Async<System.Threading.CancellationToken> option = None
    let v669 : bool = true in let mutable _v668 = v668
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v670 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v670
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v671 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v671
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v672 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v672
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v673 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v673
#endif
    
#if FABLE_COMPILER_PYTHON
    let v674 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v674
#endif
    
#else
    let v675 : Async<System.Threading.CancellationToken> option = None
    let v676 : bool = true in let mutable _v675 = v675
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v677 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v677
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v678 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v678
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v679 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v679
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v680 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v680
#endif
    
#if FABLE_COMPILER_PYTHON
    let v681 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v681
#endif
    
#else
    let v682 : Async<System.Threading.CancellationToken> option = None
    let mutable _v682 = v682
    async {
    let v683 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v683 = v683 
    let v684 : System.Threading.CancellationToken = v683 
    let v685 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v686 : (System.Threading.CancellationToken []) = [|v684; v685; v667|]
    let v687 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v688 : System.Threading.CancellationTokenSource = v687 v686
    let v689 : System.Threading.CancellationToken = v688.Token
    return v689 
    }
    |> fun x -> _v682 <- Some x
    let v690 : Async<System.Threading.CancellationToken> = _v682 |> Option.get
    v690
#endif
    |> fun x -> _v675 <- Some x
    let v691 : Async<System.Threading.CancellationToken> = _v675.Value
    v691
#endif
    |> fun x -> _v668 <- Some x
    let v692 : Async<System.Threading.CancellationToken> = _v668.Value
    let! v692 = v692 
    let v693 : System.Threading.CancellationToken = v692 
    let v694 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v693.Register
    let v695 : (unit -> unit) = closure54(v650)
    let v696 : System.Threading.CancellationTokenRegistration = v694 v695
    use v696 = v696 
    let v697 : System.Threading.CancellationTokenRegistration = v696 
    let v698 : Async<int32> option = None
    let v699 : bool = true in let mutable _v698 = v698
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v700 : Async<int32> = null |> unbox<Async<int32>>
    v700
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v701 : Async<int32> = null |> unbox<Async<int32>>
    v701
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v702 : Async<int32> = null |> unbox<Async<int32>>
    v702
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v703 : Async<int32> = null |> unbox<Async<int32>>
    v703
#endif
    
#if FABLE_COMPILER_PYTHON
    let v704 : Async<int32> = null |> unbox<Async<int32>>
    v704
#endif
    
#else
    let v705 : Async<int32> option = None
    let mutable _v705 = v705
    async {
    try
    let v706 : System.Threading.Tasks.Task = v650.WaitForExitAsync v693 
    let v707 : Async<unit> option = None
    let v708 : bool = true in let mutable _v707 = v707
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v709 : Async<unit> = null |> unbox<Async<unit>>
    v709
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v710 : Async<unit> = null |> unbox<Async<unit>>
    v710
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v711 : Async<unit> = null |> unbox<Async<unit>>
    v711
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v712 : Async<unit> = null |> unbox<Async<unit>>
    v712
#endif
    
#if FABLE_COMPILER_PYTHON
    let v713 : Async<unit> = null |> unbox<Async<unit>>
    v713
#endif
    
#else
    let v714 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v715 : Async<unit> = v714 v706
    v715
#endif
    |> fun x -> _v707 <- Some x
    let v716 : Async<unit> = _v707.Value
    do! v716 
    let v717 : int32 = v650.ExitCode
    return v717 
    with ex ->
    let v718 : exn = ex
    let v719 : string option = None
    let v720 : bool = true in let mutable _v719 = v719
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v721 : string = $"%A{v718}"
    v721
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v722 : string = $"%A{v718}"
    v722
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v723 : string = $"%A{v718}"
    v723
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v724 : string = $"%A{v718}"
    v724
#endif
    
#if FABLE_COMPILER_PYTHON
    let v725 : string = $"%A{v718}"
    v725
#endif
    
#else
    let v726 : string = $"{v718.GetType ()}: {v718.Message}"
    v726
#endif
    |> fun x -> _v719 <- Some x
    let v727 : string = _v719.Value
    let v728 : (string -> unit) = v652.Push
    v728 v727
    let v729 : System.Threading.Tasks.TaskCanceledException = v718 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v730 : US0 = US0_3
    let v731 : (unit -> string) = closure55(v729)
    let v732 : (unit -> string) = method47()
    method3(v730, v731, v732)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v705 <- Some x
    let v733 : Async<int32> = _v705 |> Option.get
    v733
#endif
    |> fun x -> _v698 <- Some x
    let v734 : Async<int32> = _v698.Value
    let! v734 = v734 
    let v735 : int32 = v734 
    let v736 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v737 : string seq = v736 v652
    let v738 : string = method71()
    let v739 : (string -> (string seq -> string)) = String.concat
    let v740 : (string seq -> string) = v739 v738
    let v741 : string = v740 v737
    let v742 : US0 = US0_1
    let v743 : (unit -> string) = closure56(v735, v741)
    let v744 : (unit -> string) = method47()
    method3(v742, v743, v744)
    return struct (v735, v741) 
    }
    |> fun x -> _v610 <- Some x
    let v745 : Async<struct (int32 * string)> = _v610 |> Option.get
    v745
#endif
    |> fun x -> _v603 <- Some x
    let v746 : Async<struct (int32 * string)> = _v603.Value
    v746
#endif
    |> fun x -> _v596 <- Some x
    let v747 : Async<struct (int32 * string)> = _v596.Value
    let v748 : struct (int32 * string) option = None
    let v749 : bool = true in let mutable _v748 = v748
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v750 : int32, v751 : string) = null |> unbox<struct (int32 * string)>
    struct (v750, v751)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v752 : int32, v753 : string) = null |> unbox<struct (int32 * string)>
    struct (v752, v753)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v754 : int32, v755 : string) = null |> unbox<struct (int32 * string)>
    struct (v754, v755)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v756 : int32, v757 : string) = null |> unbox<struct (int32 * string)>
    struct (v756, v757)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v758 : int32, v759 : string) = null |> unbox<struct (int32 * string)>
    struct (v758, v759)
#endif
    
#else
    let v760 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v761 : int32, v762 : string) = v760 v747
    struct (v761, v762)
#endif
    |> fun x -> _v748 <- Some x
    let struct (v763 : int32, v764 : string) = _v748.Value
    struct (v763, v764)
#endif
    |> fun x -> _v552 <- Some x
    let struct (v765 : int32, v766 : string) = _v552.Value
    let v767 : bool = v509.Contains v766
    let v768 : bool = v767 = false
    let v1405 : Vec<Result<string, (string * string)> option> =
        if v768 then
            let v769 : bool option = None
            let v770 : bool = true in let mutable _v769 = v769
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v771 : string = "cfg!(windows)"
            let v772 : bool = Fable.Core.RustInterop.emitRustExpr () v771
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
            let v775 : bool = null |> unbox<bool>
            v775
#endif
            
#if FABLE_COMPILER_PYTHON
            let v776 : bool = null |> unbox<bool>
            v776
#endif
            
#else
            let v777 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v778 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v779 : bool = v778 v777
            v779
#endif
            |> fun x -> _v769 <- Some x
            let v780 : bool = _v769.Value
            let v781 : bool = v780 = false
            let v802 : string =
                if v781 then
                    v544
                else
                    let v782 : string option = None
                    let v783 : bool = true in let mutable _v782 = v782
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v784 : string = method22()
                    let v785 : string = method23(v544)
                    let v786 : string = method24()
                    let v787 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v788 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v784, v785, v786) v787
                    let v789 : string = "String::from($0)"
                    let v790 : std_string_String = Fable.Core.RustInterop.emitRustExpr v788 v789
                    let v791 : string = "fable_library_rust::String_::fromString($0)"
                    let v792 : string = Fable.Core.RustInterop.emitRustExpr v790 v791
                    v792
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v793 : string = null |> unbox<string>
                    v793
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v794 : string = null |> unbox<string>
                    v794
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v795 : string = null |> unbox<string>
                    v795
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v796 : string = null |> unbox<string>
                    v796
#endif
                    
#else
                    let v797 : string = "^\\\\\\\\\\?\\\\"
                    let v798 : string = System.Text.RegularExpressions.Regex.Replace (v544, v797, v212)
                    v798
#endif
                    |> fun x -> _v782 <- Some x
                    let v799 : string = _v782.Value
                    let v800 : string = $"{v799.[0] |> string |> _.ToLower()}{v799.[1..]}"
                    let v801 : string = v800.Replace (v214, v215)
                    v801
            let v803 : string option = None
            let v804 : System.Threading.CancellationToken option = None
            let v805 : (struct (string * string) []) = [||]
            let v806 : (struct (bool * string * int32) -> Async<unit>) option = None
            let v807 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
            let v808 : string = $"pwsh -c \"(Get-FileHash \\\"{v802}\\\" -Algorithm SHA256).Hash\""
            let v809 : struct (int32 * string) option = None
            let v810 : bool = true in let mutable _v809 = v809
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v811 : string = method38(v804, v808, v805, v806, v807, v803)
            let struct (v812 : string, v813 : string) = method39()
            let v814 : int32 = v811.Length
            let v815 : (char []) = Array.zeroCreate<char> (v814)
            let v816 : Mut5 = {l0 = 0} : Mut5
            while method26(v814, v816) do
                let v818 : int32 = v816.l0
                let v819 : char = v811.[int v818]
                v815.[int v818] <- v819
                let v820 : int32 = v818 + 1
                v816.l0 <- v820
                ()
            let v821 : ((char []) -> char list) = Array.toList
            let v822 : char list = v821 v815
            let v823 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v824 : (char -> (UH0 -> UH0)) = method40()
            let v825 : (char list -> (UH0 -> UH0)) = v823 v824
            let v826 : (UH0 -> UH0) = v825 v822
            let v827 : UH0 = UH0_0
            let v828 : UH0 = v826 v827
            let v829 : US8 = US8_0
            let struct (v830 : string, v831 : string) = method41(v813, v812, v828, v829)
            let v832 : (string []) = method42(v831)
            let v833 : string = "$0.to_vec()"
            let v834 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v832 v833
            let v835 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v836 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v834, v321) v835
            let v837 : US0 = US0_1
            let v838 : (unit -> string) = closure29(v804, v808, v805, v806, v807, v803, v830, v836)
            let v839 : (unit -> string) = method47()
            method3(v837, v838, v839)
            let v840 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v804, v808, v805, v806, v807, v803, v830, v836)
            let v841 : string = "futures_lite::future::block_on($0)"
            let v842 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v840 v841
            let (a, b) = v842
            let v843 : int32 = a
            let v844 : string = b
            struct (v843, v844)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v845 : int32, v846 : string) = null |> unbox<struct (int32 * string)>
            struct (v845, v846)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v847 : int32, v848 : string) = null |> unbox<struct (int32 * string)>
            struct (v847, v848)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v849 : int32, v850 : string) = null |> unbox<struct (int32 * string)>
            struct (v849, v850)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v851 : int32, v852 : string) = null |> unbox<struct (int32 * string)>
            struct (v851, v852)
#endif
            
#else
            let v853 : Async<struct (int32 * string)> option = None
            let v854 : bool = true in let mutable _v853 = v853
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v855 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v855
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v856 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v856
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v857 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v857
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v858 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v858
#endif
            
#if FABLE_COMPILER_PYTHON
            let v859 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v859
#endif
            
#else
            let v860 : Async<struct (int32 * string)> option = None
            let v861 : bool = true in let mutable _v860 = v860
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v862 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v862
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v863 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v863
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v864 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v864
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v865 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v865
#endif
            
#if FABLE_COMPILER_PYTHON
            let v866 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v866
#endif
            
#else
            let v867 : Async<struct (int32 * string)> option = None
            let mutable _v867 = v867
            async {
            let struct (v868 : string, v869 : string) = method39()
            let v870 : int32 = v808.Length
            let v871 : (char []) = Array.zeroCreate<char> (v870)
            let v872 : Mut5 = {l0 = 0} : Mut5
            while method26(v870, v872) do
                let v874 : int32 = v872.l0
                let v875 : char = v808.[int v874]
                v871.[int v874] <- v875
                let v876 : int32 = v874 + 1
                v872.l0 <- v876
                ()
            let v877 : ((char []) -> char list) = Array.toList
            let v878 : char list = v877 v871
            let v879 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v880 : (char -> (UH0 -> UH0)) = method40()
            let v881 : (char list -> (UH0 -> UH0)) = v879 v880
            let v882 : (UH0 -> UH0) = v881 v878
            let v883 : UH0 = UH0_0
            let v884 : UH0 = v882 v883
            let v885 : US8 = US8_0
            let struct (v886 : string, v887 : string) = method41(v869, v868, v884, v885)
            let v888 : (string -> US4) = method19()
            let v889 : US4 = US4_1
            let v890 : US4 = v803 |> Option.map v888 |> Option.defaultValue v889 
            let v893 : string =
                match v890 with
                | US4_1 -> (* None *)
                    v212
                | US4_0(v891) -> (* Some *)
                    v891
            let v894 : US0 = US0_1
            let v895 : (unit -> string) = closure48(v804, v808, v805, v806, v807, v803)
            let v896 : (unit -> string) = method47()
            method3(v894, v895, v896)
            let v897 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v898 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v887, StandardOutputEncoding = v897, WorkingDirectory = v893, FileName = v886, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v899 : int32 = v805.Length
            let v900 : Mut5 = {l0 = 0} : Mut5
            while method26(v899, v900) do
                let v902 : int32 = v900.l0
                let struct (v903 : string, v904 : string) = v805.[int v902]
                v898.EnvironmentVariables.[v903] <- v904 
                let v905 : int32 = v902 + 1
                v900.l0 <- v905
                ()
            let v906 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v898)
            use v906 = v906 
            let v907 : System.Diagnostics.Process = v906 
            let v908 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v909 : System.Collections.Concurrent.ConcurrentStack<string> = v908 ()
            let v910 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v804, v808, v805, v806, v807, v803, v907, v909)
            v907.OutputDataReceived.Add v910 
            let v911 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v804, v808, v805, v806, v807, v803, v907, v909)
            v907.ErrorDataReceived.Add v911 
            let v912 : (unit -> bool) = v907.Start
            let v913 : bool = v912 ()
            let v914 : bool = v913 = false
            if v914 then
                let v915 : string = $"execute_with_options_async / process_start error"
                failwith<unit> v915
            let v916 : (unit -> unit) = v907.BeginErrorReadLine
            v916 ()
            let v917 : (unit -> unit) = v907.BeginOutputReadLine
            v917 ()
            let v918 : (System.Threading.CancellationToken -> US18) = method70()
            let v919 : US18 = US18_1
            let v920 : US18 = v804 |> Option.map v918 |> Option.defaultValue v919 
            let v924 : System.Threading.CancellationToken =
                match v920 with
                | US18_1 -> (* None *)
                    let v922 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v922
                | US18_0(v921) -> (* Some *)
                    v921
            let v925 : Async<System.Threading.CancellationToken> option = None
            let v926 : bool = true in let mutable _v925 = v925
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v927 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v927
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v928 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v928
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v929 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v929
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v930 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v930
#endif
            
#if FABLE_COMPILER_PYTHON
            let v931 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v931
#endif
            
#else
            let v932 : Async<System.Threading.CancellationToken> option = None
            let v933 : bool = true in let mutable _v932 = v932
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v934 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v934
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v935 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v935
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v936 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v936
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v937 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v937
#endif
            
#if FABLE_COMPILER_PYTHON
            let v938 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v938
#endif
            
#else
            let v939 : Async<System.Threading.CancellationToken> option = None
            let mutable _v939 = v939
            async {
            let v940 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v940 = v940 
            let v941 : System.Threading.CancellationToken = v940 
            let v942 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v943 : (System.Threading.CancellationToken []) = [|v941; v942; v924|]
            let v944 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v945 : System.Threading.CancellationTokenSource = v944 v943
            let v946 : System.Threading.CancellationToken = v945.Token
            return v946 
            }
            |> fun x -> _v939 <- Some x
            let v947 : Async<System.Threading.CancellationToken> = _v939 |> Option.get
            v947
#endif
            |> fun x -> _v932 <- Some x
            let v948 : Async<System.Threading.CancellationToken> = _v932.Value
            v948
#endif
            |> fun x -> _v925 <- Some x
            let v949 : Async<System.Threading.CancellationToken> = _v925.Value
            let! v949 = v949 
            let v950 : System.Threading.CancellationToken = v949 
            let v951 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v950.Register
            let v952 : (unit -> unit) = closure54(v907)
            let v953 : System.Threading.CancellationTokenRegistration = v951 v952
            use v953 = v953 
            let v954 : System.Threading.CancellationTokenRegistration = v953 
            let v955 : Async<int32> option = None
            let v956 : bool = true in let mutable _v955 = v955
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v957 : Async<int32> = null |> unbox<Async<int32>>
            v957
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v958 : Async<int32> = null |> unbox<Async<int32>>
            v958
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v959 : Async<int32> = null |> unbox<Async<int32>>
            v959
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v960 : Async<int32> = null |> unbox<Async<int32>>
            v960
#endif
            
#if FABLE_COMPILER_PYTHON
            let v961 : Async<int32> = null |> unbox<Async<int32>>
            v961
#endif
            
#else
            let v962 : Async<int32> option = None
            let mutable _v962 = v962
            async {
            try
            let v963 : System.Threading.Tasks.Task = v907.WaitForExitAsync v950 
            let v964 : Async<unit> option = None
            let v965 : bool = true in let mutable _v964 = v964
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v966 : Async<unit> = null |> unbox<Async<unit>>
            v966
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v967 : Async<unit> = null |> unbox<Async<unit>>
            v967
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v968 : Async<unit> = null |> unbox<Async<unit>>
            v968
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v969 : Async<unit> = null |> unbox<Async<unit>>
            v969
#endif
            
#if FABLE_COMPILER_PYTHON
            let v970 : Async<unit> = null |> unbox<Async<unit>>
            v970
#endif
            
#else
            let v971 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v972 : Async<unit> = v971 v963
            v972
#endif
            |> fun x -> _v964 <- Some x
            let v973 : Async<unit> = _v964.Value
            do! v973 
            let v974 : int32 = v907.ExitCode
            return v974 
            with ex ->
            let v975 : exn = ex
            let v976 : string option = None
            let v977 : bool = true in let mutable _v976 = v976
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v978 : string = $"%A{v975}"
            v978
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v979 : string = $"%A{v975}"
            v979
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v980 : string = $"%A{v975}"
            v980
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v981 : string = $"%A{v975}"
            v981
#endif
            
#if FABLE_COMPILER_PYTHON
            let v982 : string = $"%A{v975}"
            v982
#endif
            
#else
            let v983 : string = $"{v975.GetType ()}: {v975.Message}"
            v983
#endif
            |> fun x -> _v976 <- Some x
            let v984 : string = _v976.Value
            let v985 : (string -> unit) = v909.Push
            v985 v984
            let v986 : System.Threading.Tasks.TaskCanceledException = v975 |> unbox<System.Threading.Tasks.TaskCanceledException>
            let v987 : US0 = US0_3
            let v988 : (unit -> string) = closure55(v986)
            let v989 : (unit -> string) = method47()
            method3(v987, v988, v989)
            return -2147483648 
            (*
            *)
            }
            |> fun x -> _v962 <- Some x
            let v990 : Async<int32> = _v962 |> Option.get
            v990
#endif
            |> fun x -> _v955 <- Some x
            let v991 : Async<int32> = _v955.Value
            let! v991 = v991 
            let v992 : int32 = v991 
            let v993 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v994 : string seq = v993 v909
            let v995 : string = method71()
            let v996 : (string -> (string seq -> string)) = String.concat
            let v997 : (string seq -> string) = v996 v995
            let v998 : string = v997 v994
            let v999 : US0 = US0_1
            let v1000 : (unit -> string) = closure56(v992, v998)
            let v1001 : (unit -> string) = method47()
            method3(v999, v1000, v1001)
            return struct (v992, v998) 
            }
            |> fun x -> _v867 <- Some x
            let v1002 : Async<struct (int32 * string)> = _v867 |> Option.get
            v1002
#endif
            |> fun x -> _v860 <- Some x
            let v1003 : Async<struct (int32 * string)> = _v860.Value
            v1003
#endif
            |> fun x -> _v853 <- Some x
            let v1004 : Async<struct (int32 * string)> = _v853.Value
            let v1005 : struct (int32 * string) option = None
            let v1006 : bool = true in let mutable _v1005 = v1005
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v1007 : int32, v1008 : string) = null |> unbox<struct (int32 * string)>
            struct (v1007, v1008)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v1009 : int32, v1010 : string) = null |> unbox<struct (int32 * string)>
            struct (v1009, v1010)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v1011 : int32, v1012 : string) = null |> unbox<struct (int32 * string)>
            struct (v1011, v1012)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v1013 : int32, v1014 : string) = null |> unbox<struct (int32 * string)>
            struct (v1013, v1014)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v1015 : int32, v1016 : string) = null |> unbox<struct (int32 * string)>
            struct (v1015, v1016)
#endif
            
#else
            let v1017 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
            let struct (v1018 : int32, v1019 : string) = v1017 v1004
            struct (v1018, v1019)
#endif
            |> fun x -> _v1005 <- Some x
            let struct (v1020 : int32, v1021 : string) = _v1005.Value
            struct (v1020, v1021)
#endif
            |> fun x -> _v809 <- Some x
            let struct (v1022 : int32, v1023 : string) = _v809.Value
            let v1024 : string = method13(v4, v217)
            let v1025 : bool option = None
            let v1026 : bool = true in let mutable _v1025 = v1025
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1027 : string = "cfg!(windows)"
            let v1028 : bool = Fable.Core.RustInterop.emitRustExpr () v1027
            v1028
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1029 : bool = null |> unbox<bool>
            v1029
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1030 : bool = null |> unbox<bool>
            v1030
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1031 : bool = null |> unbox<bool>
            v1031
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1032 : bool = null |> unbox<bool>
            v1032
#endif
            
#else
            let v1033 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v1034 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v1035 : bool = v1034 v1033
            v1035
#endif
            |> fun x -> _v1025 <- Some x
            let v1036 : bool = _v1025.Value
            let v1037 : bool = v1036 = false
            let v1058 : string =
                if v1037 then
                    v1024
                else
                    let v1038 : string option = None
                    let v1039 : bool = true in let mutable _v1038 = v1038
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1040 : string = method22()
                    let v1041 : string = method23(v1024)
                    let v1042 : string = method24()
                    let v1043 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v1044 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1040, v1041, v1042) v1043
                    let v1045 : string = "String::from($0)"
                    let v1046 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1044 v1045
                    let v1047 : string = "fable_library_rust::String_::fromString($0)"
                    let v1048 : string = Fable.Core.RustInterop.emitRustExpr v1046 v1047
                    v1048
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1049 : string = null |> unbox<string>
                    v1049
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1050 : string = null |> unbox<string>
                    v1050
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1051 : string = null |> unbox<string>
                    v1051
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1052 : string = null |> unbox<string>
                    v1052
#endif
                    
#else
                    let v1053 : string = "^\\\\\\\\\\?\\\\"
                    let v1054 : string = System.Text.RegularExpressions.Regex.Replace (v1024, v1053, v212)
                    v1054
#endif
                    |> fun x -> _v1038 <- Some x
                    let v1055 : string = _v1038.Value
                    let v1056 : string = $"{v1055.[0] |> string |> _.ToLower()}{v1055.[1..]}"
                    let v1057 : string = v1056.Replace (v214, v215)
                    v1057
            let v1059 : bool option = None
            let v1060 : bool = true in let mutable _v1059 = v1059
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1061 : string = method14(v1058)
            let v1062 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1063 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1061 v1062
            let v1064 : string = "String::from($0)"
            let v1065 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1063 v1064
            let v1066 : string = "std::path::PathBuf::from($0)"
            let v1067 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1065 v1066
            let v1068 : string = "$0.exists()"
            let v1069 : bool = Fable.Core.RustInterop.emitRustExpr v1067 v1068
            let v1072 : bool =
                if v1069 then
                    let v1070 : string = "$0.is_file()"
                    let v1071 : bool = Fable.Core.RustInterop.emitRustExpr v1067 v1070
                    v1071
                else
                    false
            v1072
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1073 : bool = null |> unbox<bool>
            v1073
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1074 : bool = null |> unbox<bool>
            v1074
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1075 : string = "fs"
            let v1076 : IFsExistsSync = Fable.Core.JsInterop.importAll v1075
            let v1077 : string = "v1076.existsSync($0)"
            let v1078 : bool = Fable.Core.JsInterop.emitJsExpr v1058 v1077
            v1078
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1079 : bool = null |> unbox<bool>
            v1079
#endif
            
#else
            let v1080 : (string -> bool) = System.IO.File.Exists
            let v1081 : bool = v1080 v1058
            v1081
#endif
            |> fun x -> _v1059 <- Some x
            let v1082 : bool = _v1059.Value
            let v1338 : string =
                if v1082 then
                    let v1083 : bool option = None
                    let v1084 : bool = true in let mutable _v1083 = v1083
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1085 : string = "cfg!(windows)"
                    let v1086 : bool = Fable.Core.RustInterop.emitRustExpr () v1085
                    v1086
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1087 : bool = null |> unbox<bool>
                    v1087
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1088 : bool = null |> unbox<bool>
                    v1088
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1089 : bool = null |> unbox<bool>
                    v1089
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1090 : bool = null |> unbox<bool>
                    v1090
#endif
                    
#else
                    let v1091 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                    let v1092 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                    let v1093 : bool = v1092 v1091
                    v1093
#endif
                    |> fun x -> _v1083 <- Some x
                    let v1094 : bool = _v1083.Value
                    let v1095 : bool = v1094 = false
                    let v1116 : string =
                        if v1095 then
                            v1058
                        else
                            let v1096 : string option = None
                            let v1097 : bool = true in let mutable _v1096 = v1096
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v1098 : string = method22()
                            let v1099 : string = method23(v1058)
                            let v1100 : string = method24()
                            let v1101 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                            let v1102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1098, v1099, v1100) v1101
                            let v1103 : string = "String::from($0)"
                            let v1104 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1102 v1103
                            let v1105 : string = "fable_library_rust::String_::fromString($0)"
                            let v1106 : string = Fable.Core.RustInterop.emitRustExpr v1104 v1105
                            v1106
#endif
                            
#if FABLE_COMPILER_RUST && WASM
                            let v1107 : string = null |> unbox<string>
                            v1107
#endif
                            
#if FABLE_COMPILER_RUST && CONTRACT
                            let v1108 : string = null |> unbox<string>
                            v1108
#endif
                            
#if FABLE_COMPILER_TYPESCRIPT
                            let v1109 : string = null |> unbox<string>
                            v1109
#endif
                            
#if FABLE_COMPILER_PYTHON
                            let v1110 : string = null |> unbox<string>
                            v1110
#endif
                            
#else
                            let v1111 : string = "^\\\\\\\\\\?\\\\"
                            let v1112 : string = System.Text.RegularExpressions.Regex.Replace (v1058, v1111, v212)
                            v1112
#endif
                            |> fun x -> _v1096 <- Some x
                            let v1113 : string = _v1096.Value
                            let v1114 : string = $"{v1113.[0] |> string |> _.ToLower()}{v1113.[1..]}"
                            let v1115 : string = v1114.Replace (v214, v215)
                            v1115
                    let v1117 : string option = None
                    let v1118 : System.Threading.CancellationToken option = None
                    let v1119 : (struct (string * string) []) = [||]
                    let v1120 : (struct (bool * string * int32) -> Async<unit>) option = None
                    let v1121 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
                    let v1122 : string = $"pwsh -c \"(Get-FileHash \\\"{v1116}\\\" -Algorithm SHA256).Hash\""
                    let v1123 : struct (int32 * string) option = None
                    let v1124 : bool = true in let mutable _v1123 = v1123
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1125 : string = method38(v1118, v1122, v1119, v1120, v1121, v1117)
                    let struct (v1126 : string, v1127 : string) = method39()
                    let v1128 : int32 = v1125.Length
                    let v1129 : (char []) = Array.zeroCreate<char> (v1128)
                    let v1130 : Mut5 = {l0 = 0} : Mut5
                    while method26(v1128, v1130) do
                        let v1132 : int32 = v1130.l0
                        let v1133 : char = v1125.[int v1132]
                        v1129.[int v1132] <- v1133
                        let v1134 : int32 = v1132 + 1
                        v1130.l0 <- v1134
                        ()
                    let v1135 : ((char []) -> char list) = Array.toList
                    let v1136 : char list = v1135 v1129
                    let v1137 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                    let v1138 : (char -> (UH0 -> UH0)) = method40()
                    let v1139 : (char list -> (UH0 -> UH0)) = v1137 v1138
                    let v1140 : (UH0 -> UH0) = v1139 v1136
                    let v1141 : UH0 = UH0_0
                    let v1142 : UH0 = v1140 v1141
                    let v1143 : US8 = US8_0
                    let struct (v1144 : string, v1145 : string) = method41(v1127, v1126, v1142, v1143)
                    let v1146 : (string []) = method42(v1145)
                    let v1147 : string = "$0.to_vec()"
                    let v1148 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v1146 v1147
                    let v1149 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                    let v1150 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1148, v321) v1149
                    let v1151 : US0 = US0_1
                    let v1152 : (unit -> string) = closure29(v1118, v1122, v1119, v1120, v1121, v1117, v1144, v1150)
                    let v1153 : (unit -> string) = method47()
                    method3(v1151, v1152, v1153)
                    let v1154 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method48(v1118, v1122, v1119, v1120, v1121, v1117, v1144, v1150)
                    let v1155 : string = "futures_lite::future::block_on($0)"
                    let v1156 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v1154 v1155
                    let (a, b) = v1156
                    let v1157 : int32 = a
                    let v1158 : string = b
                    struct (v1157, v1158)
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let struct (v1159 : int32, v1160 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1159, v1160)
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let struct (v1161 : int32, v1162 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1161, v1162)
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let struct (v1163 : int32, v1164 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1163, v1164)
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let struct (v1165 : int32, v1166 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1165, v1166)
#endif
                    
#else
                    let v1167 : Async<struct (int32 * string)> option = None
                    let v1168 : bool = true in let mutable _v1167 = v1167
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1169 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1169
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1170 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1170
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1171 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1171
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1172 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1172
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1173 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1173
#endif
                    
#else
                    let v1174 : Async<struct (int32 * string)> option = None
                    let v1175 : bool = true in let mutable _v1174 = v1174
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1176 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1176
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1177 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1177
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1178 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1178
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1179 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1179
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1180 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1180
#endif
                    
#else
                    let v1181 : Async<struct (int32 * string)> option = None
                    let mutable _v1181 = v1181
                    async {
                    let struct (v1182 : string, v1183 : string) = method39()
                    let v1184 : int32 = v1122.Length
                    let v1185 : (char []) = Array.zeroCreate<char> (v1184)
                    let v1186 : Mut5 = {l0 = 0} : Mut5
                    while method26(v1184, v1186) do
                        let v1188 : int32 = v1186.l0
                        let v1189 : char = v1122.[int v1188]
                        v1185.[int v1188] <- v1189
                        let v1190 : int32 = v1188 + 1
                        v1186.l0 <- v1190
                        ()
                    let v1191 : ((char []) -> char list) = Array.toList
                    let v1192 : char list = v1191 v1185
                    let v1193 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                    let v1194 : (char -> (UH0 -> UH0)) = method40()
                    let v1195 : (char list -> (UH0 -> UH0)) = v1193 v1194
                    let v1196 : (UH0 -> UH0) = v1195 v1192
                    let v1197 : UH0 = UH0_0
                    let v1198 : UH0 = v1196 v1197
                    let v1199 : US8 = US8_0
                    let struct (v1200 : string, v1201 : string) = method41(v1183, v1182, v1198, v1199)
                    let v1202 : (string -> US4) = method19()
                    let v1203 : US4 = US4_1
                    let v1204 : US4 = v1117 |> Option.map v1202 |> Option.defaultValue v1203 
                    let v1207 : string =
                        match v1204 with
                        | US4_1 -> (* None *)
                            v212
                        | US4_0(v1205) -> (* Some *)
                            v1205
                    let v1208 : US0 = US0_1
                    let v1209 : (unit -> string) = closure48(v1118, v1122, v1119, v1120, v1121, v1117)
                    let v1210 : (unit -> string) = method47()
                    method3(v1208, v1209, v1210)
                    let v1211 : System.Text.Encoding = System.Text.Encoding.UTF8
                    let v1212 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v1201, StandardOutputEncoding = v1211, WorkingDirectory = v1207, FileName = v1200, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                    let v1213 : int32 = v1119.Length
                    let v1214 : Mut5 = {l0 = 0} : Mut5
                    while method26(v1213, v1214) do
                        let v1216 : int32 = v1214.l0
                        let struct (v1217 : string, v1218 : string) = v1119.[int v1216]
                        v1212.EnvironmentVariables.[v1217] <- v1218 
                        let v1219 : int32 = v1216 + 1
                        v1214.l0 <- v1219
                        ()
                    let v1220 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1212)
                    use v1220 = v1220 
                    let v1221 : System.Diagnostics.Process = v1220 
                    let v1222 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                    let v1223 : System.Collections.Concurrent.ConcurrentStack<string> = v1222 ()
                    let v1224 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v1118, v1122, v1119, v1120, v1121, v1117, v1221, v1223)
                    v1221.OutputDataReceived.Add v1224 
                    let v1225 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure52(v1118, v1122, v1119, v1120, v1121, v1117, v1221, v1223)
                    v1221.ErrorDataReceived.Add v1225 
                    let v1226 : (unit -> bool) = v1221.Start
                    let v1227 : bool = v1226 ()
                    let v1228 : bool = v1227 = false
                    if v1228 then
                        let v1229 : string = $"execute_with_options_async / process_start error"
                        failwith<unit> v1229
                    let v1230 : (unit -> unit) = v1221.BeginErrorReadLine
                    v1230 ()
                    let v1231 : (unit -> unit) = v1221.BeginOutputReadLine
                    v1231 ()
                    let v1232 : (System.Threading.CancellationToken -> US18) = method70()
                    let v1233 : US18 = US18_1
                    let v1234 : US18 = v1118 |> Option.map v1232 |> Option.defaultValue v1233 
                    let v1238 : System.Threading.CancellationToken =
                        match v1234 with
                        | US18_1 -> (* None *)
                            let v1236 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                            v1236
                        | US18_0(v1235) -> (* Some *)
                            v1235
                    let v1239 : Async<System.Threading.CancellationToken> option = None
                    let v1240 : bool = true in let mutable _v1239 = v1239
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1241 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1241
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1242 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1242
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1243 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1243
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1244 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1244
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1245 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1245
#endif
                    
#else
                    let v1246 : Async<System.Threading.CancellationToken> option = None
                    let v1247 : bool = true in let mutable _v1246 = v1246
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1248 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1248
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1249 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1249
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1250 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1250
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1251 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1251
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1252 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1252
#endif
                    
#else
                    let v1253 : Async<System.Threading.CancellationToken> option = None
                    let mutable _v1253 = v1253
                    async {
                    let v1254 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v1254 = v1254 
                    let v1255 : System.Threading.CancellationToken = v1254 
                    let v1256 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v1257 : (System.Threading.CancellationToken []) = [|v1255; v1256; v1238|]
                    let v1258 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v1259 : System.Threading.CancellationTokenSource = v1258 v1257
                    let v1260 : System.Threading.CancellationToken = v1259.Token
                    return v1260 
                    }
                    |> fun x -> _v1253 <- Some x
                    let v1261 : Async<System.Threading.CancellationToken> = _v1253 |> Option.get
                    v1261
#endif
                    |> fun x -> _v1246 <- Some x
                    let v1262 : Async<System.Threading.CancellationToken> = _v1246.Value
                    v1262
#endif
                    |> fun x -> _v1239 <- Some x
                    let v1263 : Async<System.Threading.CancellationToken> = _v1239.Value
                    let! v1263 = v1263 
                    let v1264 : System.Threading.CancellationToken = v1263 
                    let v1265 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1264.Register
                    let v1266 : (unit -> unit) = closure54(v1221)
                    let v1267 : System.Threading.CancellationTokenRegistration = v1265 v1266
                    use v1267 = v1267 
                    let v1268 : System.Threading.CancellationTokenRegistration = v1267 
                    let v1269 : Async<int32> option = None
                    let v1270 : bool = true in let mutable _v1269 = v1269
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1271 : Async<int32> = null |> unbox<Async<int32>>
                    v1271
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1272 : Async<int32> = null |> unbox<Async<int32>>
                    v1272
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1273 : Async<int32> = null |> unbox<Async<int32>>
                    v1273
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1274 : Async<int32> = null |> unbox<Async<int32>>
                    v1274
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1275 : Async<int32> = null |> unbox<Async<int32>>
                    v1275
#endif
                    
#else
                    let v1276 : Async<int32> option = None
                    let mutable _v1276 = v1276
                    async {
                    try
                    let v1277 : System.Threading.Tasks.Task = v1221.WaitForExitAsync v1264 
                    let v1278 : Async<unit> option = None
                    let v1279 : bool = true in let mutable _v1278 = v1278
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1280 : Async<unit> = null |> unbox<Async<unit>>
                    v1280
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1281 : Async<unit> = null |> unbox<Async<unit>>
                    v1281
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1282 : Async<unit> = null |> unbox<Async<unit>>
                    v1282
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1283 : Async<unit> = null |> unbox<Async<unit>>
                    v1283
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1284 : Async<unit> = null |> unbox<Async<unit>>
                    v1284
#endif
                    
#else
                    let v1285 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1286 : Async<unit> = v1285 v1277
                    v1286
#endif
                    |> fun x -> _v1278 <- Some x
                    let v1287 : Async<unit> = _v1278.Value
                    do! v1287 
                    let v1288 : int32 = v1221.ExitCode
                    return v1288 
                    with ex ->
                    let v1289 : exn = ex
                    let v1290 : string option = None
                    let v1291 : bool = true in let mutable _v1290 = v1290
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1292 : string = $"%A{v1289}"
                    v1292
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1293 : string = $"%A{v1289}"
                    v1293
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1294 : string = $"%A{v1289}"
                    v1294
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1295 : string = $"%A{v1289}"
                    v1295
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1296 : string = $"%A{v1289}"
                    v1296
#endif
                    
#else
                    let v1297 : string = $"{v1289.GetType ()}: {v1289.Message}"
                    v1297
#endif
                    |> fun x -> _v1290 <- Some x
                    let v1298 : string = _v1290.Value
                    let v1299 : (string -> unit) = v1223.Push
                    v1299 v1298
                    let v1300 : System.Threading.Tasks.TaskCanceledException = v1289 |> unbox<System.Threading.Tasks.TaskCanceledException>
                    let v1301 : US0 = US0_3
                    let v1302 : (unit -> string) = closure55(v1300)
                    let v1303 : (unit -> string) = method47()
                    method3(v1301, v1302, v1303)
                    return -2147483648 
                    (*
                    *)
                    }
                    |> fun x -> _v1276 <- Some x
                    let v1304 : Async<int32> = _v1276 |> Option.get
                    v1304
#endif
                    |> fun x -> _v1269 <- Some x
                    let v1305 : Async<int32> = _v1269.Value
                    let! v1305 = v1305 
                    let v1306 : int32 = v1305 
                    let v1307 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                    let v1308 : string seq = v1307 v1223
                    let v1309 : string = method71()
                    let v1310 : (string -> (string seq -> string)) = String.concat
                    let v1311 : (string seq -> string) = v1310 v1309
                    let v1312 : string = v1311 v1308
                    let v1313 : US0 = US0_1
                    let v1314 : (unit -> string) = closure56(v1306, v1312)
                    let v1315 : (unit -> string) = method47()
                    method3(v1313, v1314, v1315)
                    return struct (v1306, v1312) 
                    }
                    |> fun x -> _v1181 <- Some x
                    let v1316 : Async<struct (int32 * string)> = _v1181 |> Option.get
                    v1316
#endif
                    |> fun x -> _v1174 <- Some x
                    let v1317 : Async<struct (int32 * string)> = _v1174.Value
                    v1317
#endif
                    |> fun x -> _v1167 <- Some x
                    let v1318 : Async<struct (int32 * string)> = _v1167.Value
                    let v1319 : struct (int32 * string) option = None
                    let v1320 : bool = true in let mutable _v1319 = v1319
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let struct (v1321 : int32, v1322 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1321, v1322)
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let struct (v1323 : int32, v1324 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1323, v1324)
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let struct (v1325 : int32, v1326 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1325, v1326)
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let struct (v1327 : int32, v1328 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1327, v1328)
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let struct (v1329 : int32, v1330 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1329, v1330)
#endif
                    
#else
                    let v1331 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                    let struct (v1332 : int32, v1333 : string) = v1331 v1318
                    struct (v1332, v1333)
#endif
                    |> fun x -> _v1319 <- Some x
                    let struct (v1334 : int32, v1335 : string) = _v1319.Value
                    struct (v1334, v1335)
#endif
                    |> fun x -> _v1123 <- Some x
                    let struct (v1336 : int32, v1337 : string) = _v1123.Value
                    v1337
                else
                    v212
            let v1339 : bool = v1023 <> v1338
            if v1339 then
                let v1340 : struct (string * (string -> US19)) list = []
                let v1341 : string = "hangul.md"
                let v1342 : (string -> US19) = closure57(v1058, v544, v0, v1)
                let v1343 : struct (string * (string -> US19)) list = struct (v1341, v1342) :: v1340 
                let v1344 : string = "epub"
                let v1345 : (string -> US19) = closure61(v1058, v544, v3)
                let v1346 : struct (string * (string -> US19)) list = struct (v1344, v1345) :: v1343 
                let v1347 : string = "pdf"
                let v1348 : struct (string * (string -> US19)) list = struct (v1347, v1345) :: v1346 
                let v1349 : string = "html"
                let v1350 : struct (string * (string -> US19)) list = struct (v1349, v1345) :: v1348 
                let v1351 : (struct (string * (string -> US19)) list -> (struct (string * (string -> US19)) [])) = List.toArray
                let v1352 : (struct (string * (string -> US19)) []) = v1351 v1350
                let v1353 : string = "$0.to_vec()"
                let v1354 : Vec<struct (string * (string -> US19))> = Fable.Core.RustInterop.emitRustExpr v1352 v1353
                let v1355 : string = "rayon::iter::IntoParallelIterator::into_par_iter(v1354)"
                let v1356 : rayon_vec_IntoIter<struct (string * (string -> US19))> = Fable.Core.RustInterop.emitRustExpr () v1355
                let v1357 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
                let v1358 : (struct (string * (string -> US19)) -> Result<string, (string * string)> option) = closure64()
                let v1359 : rayon_iter_Map<rayon_vec_IntoIter<struct (string * (string -> US19))>> = Fable.Core.RustInterop.emitRustExpr struct (v1356, v1358) v1357
                let v1360 : string = "rayon::iter::ParallelIterator::collect($0)"
                let v1361 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1359 v1360
                let v1362 : string = "."
                let v1363 : int32 = v544.LastIndexOf v1362
                let v1364 : int32 = v1363 - 1
                let v1365 : string = v544.[int 0..int v1364]
                let v1366 : string = $"{v1365}.hangul.md"
                let v1367 : struct (string * (string -> US19)) list = []
                let v1368 : (string -> US19) = closure61(v1058, v1366, v3)
                let v1369 : struct (string * (string -> US19)) list = struct (v1344, v1368) :: v1367 
                let v1370 : struct (string * (string -> US19)) list = struct (v1347, v1368) :: v1369 
                let v1371 : struct (string * (string -> US19)) list = struct (v1349, v1368) :: v1370 
                let v1372 : (struct (string * (string -> US19)) list -> (struct (string * (string -> US19)) [])) = List.toArray
                let v1373 : (struct (string * (string -> US19)) []) = v1372 v1371
                let v1374 : string = "$0.to_vec()"
                let v1375 : Vec<struct (string * (string -> US19))> = Fable.Core.RustInterop.emitRustExpr v1373 v1374
                let v1376 : string = "rayon::iter::IntoParallelIterator::into_par_iter(v1375)"
                let v1377 : rayon_vec_IntoIter<struct (string * (string -> US19))> = Fable.Core.RustInterop.emitRustExpr () v1376
                let v1378 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
                let v1379 : rayon_iter_Map<rayon_vec_IntoIter<struct (string * (string -> US19))>> = Fable.Core.RustInterop.emitRustExpr struct (v1377, v1358) v1378
                let v1380 : string = "rayon::iter::ParallelIterator::collect($0)"
                let v1381 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1379 v1380
                let v1382 : Vec<Result<string, (string * string)> option> = method78(v1381)
                let v1383 : Vec<Result<string, (string * string)> option> = method79(v1361)
                let v1384 : string = "let mut v1383 = v1383"
                Fable.Core.RustInterop.emitRustExpr () v1384
                let v1385 : string = "v1383.extend(v1382)"
                Fable.Core.RustInterop.emitRustExpr () v1385
                let v1386 : string = "v1383"
                let v1387 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr () v1386
                let v1388 : US0 = US0_2
                let v1389 : (unit -> string) = closure65()
                let v1390 : (unit -> string) = closure66(v217, v251, v286, v509, v508, v766, v765, v1023, v1338, v1387)
                method3(v1388, v1389, v1390)
                let v1391 : unit option = None
                let v1392 : bool = true in let mutable _v1391 = v1391
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1393 : string = method77(v1058)
                let v1394 : string = "std::fs::copy(&*v544, &*v1393)"
                let v1395 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v1394
                let v1396 : string = "$0.unwrap()"
                let v1397 : uint64 = Fable.Core.RustInterop.emitRustExpr v1395 v1396
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
                System.IO.File.Copy (v544, v1058, true)
                ()
#endif
                |> fun x -> _v1391 <- Some x
                _v1391.Value
                v1387
            else
                let v1398 : (Result<string, (string * string)> option []) = [||]
                let v1399 : string = "$0.to_vec()"
                let v1400 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1398 v1399
                v1400
        else
            let v1402 : (Result<string, (string * string)> option []) = [||]
            let v1403 : string = "$0.to_vec()"
            let v1404 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1402 v1403
            v1404
    let v1406 : (string * Vec<Result<string, (string * string)> option>) = v251, v1405
    let v1407 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v1406
    v1407
and closure67 () () : string =
    let v0 : string = "documents.run"
    v0
and closure68 (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) () : string =
    let v1 : string = "$0.len()"
    let v2 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"result_len: {v2} / {v3 ()}"
    v4
and method80 (v0 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>) : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> =
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
    let v25 : (unit -> string) = closure67()
    let v26 : (unit -> string) = closure68(v23)
    method3(v24, v25, v26)
    let v27 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Ok v23
    let v28 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = method80(v27)
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
    let v184 : string =
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
            let v53 : bool option = None
            let v54 : bool = true in let mutable _v53 = v53
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v55 : string = "cfg!(windows)"
            let v56 : bool = Fable.Core.RustInterop.emitRustExpr () v55
            v56
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v57 : bool = null |> unbox<bool>
            v57
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v58 : bool = null |> unbox<bool>
            v58
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v59 : bool = null |> unbox<bool>
            v59
#endif
            
#if FABLE_COMPILER_PYTHON
            let v60 : bool = null |> unbox<bool>
            v60
#endif
            
#else
            let v61 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v62 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v63 : bool = v62 v61
            v63
#endif
            |> fun x -> _v53 <- Some x
            let v64 : bool = _v53.Value
            let v65 : bool = v64 = false
            let v89 : string =
                if v65 then
                    v52
                else
                    let v66 : string option = None
                    let v67 : bool = true in let mutable _v66 = v66
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v68 : string = method22()
                    let v69 : string = method23(v52)
                    let v70 : string = method24()
                    let v71 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v72 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v68, v69, v70) v71
                    let v73 : string = "String::from($0)"
                    let v74 : std_string_String = Fable.Core.RustInterop.emitRustExpr v72 v73
                    let v75 : string = "fable_library_rust::String_::fromString($0)"
                    let v76 : string = Fable.Core.RustInterop.emitRustExpr v74 v75
                    v76
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v77 : string = null |> unbox<string>
                    v77
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v78 : string = null |> unbox<string>
                    v78
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v79 : string = null |> unbox<string>
                    v79
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v80 : string = null |> unbox<string>
                    v80
#endif
                    
#else
                    let v81 : string = "^\\\\\\\\\\?\\\\"
                    let v82 : string = ""
                    let v83 : string = System.Text.RegularExpressions.Regex.Replace (v52, v81, v82)
                    v83
#endif
                    |> fun x -> _v66 <- Some x
                    let v84 : string = _v66.Value
                    let v85 : string = $"{v84.[0] |> string |> _.ToLower()}{v84.[1..]}"
                    let v86 : string = "\\"
                    let v87 : string = "/"
                    let v88 : string = v85.Replace (v86, v87)
                    v88
            let v90 : string = "/"
            let v91 : (string []) = v89.Split v90
            let v92 : (string []) = [||]
            let v93 : int32 = v91.Length
            let v94 : Mut4 = {l0 = 0; l1 = 0; l2 = v92} : Mut4
            while method25(v93, v94) do
                let v96 : int32 = v94.l0
                let v97 : int32 =  -v96
                let v98 : int32 = v97 + v93
                let v99 : int32 = v98 - 1
                let struct (v100 : int32, v101 : (string [])) = v94.l1, v94.l2
                let v102 : string = v91.[int v99]
                let v103 : bool = ".." = v102
                let struct (v142 : int32, v143 : (string [])) =
                    if v103 then
                        let v104 : int32 = v100 + 1
                        struct (v104, v101)
                    else
                        let v105 : bool = 0 = v100
                        if v105 then
                            let v106 : string = ":"
                            let v107 : bool = v102.EndsWith v106
                            if v107 then
                                let v108 : string = $"{v51.[0]}:"
                                let v109 : (string []) = [|v108|]
                                let v110 : int32 = v109.Length
                                let v111 : int32 = v101.Length
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
                                            let v120 : string = v101.[int v119]
                                            v120
                                    v113.[int v116] <- v121
                                    let v122 : int32 = v116 + 1
                                    v114.l0 <- v122
                                    ()
                                struct (0, v113)
                            else
                                let v123 : (string []) = [|v102|]
                                let v124 : int32 = v123.Length
                                let v125 : int32 = v101.Length
                                let v126 : int32 = v124 + v125
                                let v127 : (string []) = Array.zeroCreate<string> (v126)
                                let v128 : Mut5 = {l0 = 0} : Mut5
                                while method26(v126, v128) do
                                    let v130 : int32 = v128.l0
                                    let v131 : bool = v130 < v124
                                    let v135 : string =
                                        if v131 then
                                            let v132 : string = v123.[int v130]
                                            v132
                                        else
                                            let v133 : int32 = v130 - v124
                                            let v134 : string = v101.[int v133]
                                            v134
                                    v127.[int v130] <- v135
                                    let v136 : int32 = v130 + 1
                                    v128.l0 <- v136
                                    ()
                                struct (0, v127)
                        else
                            let v139 : int32 = v100 - 1
                            struct (v139, v101)
                let v144 : int32 = v96 + 1
                v94.l0 <- v144
                v94.l1 <- v142
                v94.l2 <- v143
                ()
            let struct (v145 : int32, v146 : (string [])) = v94.l1, v94.l2
            let v147 : string seq = seq { for i = 0 to v146.Length - 1 do yield v146.[i] }
            let v148 : char option = None
            let v149 : bool = true in let mutable _v148 = v148
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v150 : string = "std::path::MAIN_SEPARATOR"
            let v151 : char = Fable.Core.RustInterop.emitRustExpr () v150
            v151
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v152 : char = null |> unbox<char>
            v152
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v153 : char = null |> unbox<char>
            v153
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v154 : char = null |> unbox<char>
            v154
#endif
            
#if FABLE_COMPILER_PYTHON
            let v155 : char = null |> unbox<char>
            v155
#endif
            
#else
            let v156 : char = System.IO.Path.DirectorySeparatorChar
            v156
#endif
            |> fun x -> _v148 <- Some x
            let v157 : char = _v148.Value
            let v158 : (char -> string) = _.ToString()
            let v159 : string = v158 v157
            let v160 : string = method27(v159)
            let v161 : (string -> (string seq -> string)) = String.concat
            let v162 : (string seq -> string) = v161 v160
            v162 v147
        else
            let v164 : string = "std::fs::canonicalize(&*$0)"
            let v165 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v12 v164
            let v166 : string = "$0.unwrap()"
            let v167 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v165 v166
            let v168 : string = "$0.display()"
            let v169 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v167 v168
            let v170 : std_string_String option = None
            let v171 : bool = true in let mutable _v170 = v170
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v172 : string = @$"format!(""{{}}"", $0)"
            let v173 : std_string_String = Fable.Core.RustInterop.emitRustExpr v169 v172
            v173
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v174 : string = @$"format!(""{{}}"", $0)"
            let v175 : std_string_String = Fable.Core.RustInterop.emitRustExpr v169 v174
            v175
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v176 : string = @$"format!(""{{}}"", $0)"
            let v177 : std_string_String = Fable.Core.RustInterop.emitRustExpr v169 v176
            v177
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v178 : std_string_String = null |> unbox<std_string_String>
            v178
#endif
            
#if FABLE_COMPILER_PYTHON
            let v179 : std_string_String = null |> unbox<std_string_String>
            v179
#endif
            
#else
            let v180 : std_string_String = null |> unbox<std_string_String>
            v180
#endif
            |> fun x -> _v170 <- Some x
            let v181 : std_string_String = _v170.Value
            let v182 : string = "fable_library_rust::String_::fromString($0)"
            let v183 : string = Fable.Core.RustInterop.emitRustExpr v181 v182
            v183
    v184
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v185 : string = null |> unbox<string>
    v185
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v186 : string = null |> unbox<string>
    v186
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v187 : string = null |> unbox<string>
    v187
#endif
    
#if FABLE_COMPILER_PYTHON
    let v188 : string = null |> unbox<string>
    v188
#endif
    
#else
    let v189 : string = method28(v3)
    let v190 : (string -> string) = System.IO.Path.GetFullPath
    let v191 : string = v190 v189
    v191
#endif
    |> fun x -> _v10 <- Some x
    let v192 : string = _v10.Value
    let v193 : string option = None
    let v194 : bool = true in let mutable _v193 = v193
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v195 : string = method21(v2)
    let v196 : string = method14(v195)
    let v197 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v198 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v196 v197
    let v199 : string = "String::from($0)"
    let v200 : std_string_String = Fable.Core.RustInterop.emitRustExpr v198 v199
    let v201 : string = "std::path::PathBuf::from($0)"
    let v202 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v200 v201
    let v203 : string = "$0.exists()"
    let v204 : bool = Fable.Core.RustInterop.emitRustExpr v202 v203
    let v205 : bool = v204 = false
    let v367 : string =
        if v205 then
            let v206 : string option = None
            let v207 : bool = true in let mutable _v206 = v206
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v208 : string = "std::env::current_dir()"
            let v209 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v208
            let v210 : string = "$0.unwrap()"
            let v211 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v209 v210
            let v212 : string = "$0.display()"
            let v213 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v211 v212
            let v214 : std_string_String option = None
            let v215 : bool = true in let mutable _v214 = v214
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v216 : string = @$"format!(""{{}}"", $0)"
            let v217 : std_string_String = Fable.Core.RustInterop.emitRustExpr v213 v216
            v217
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v218 : string = @$"format!(""{{}}"", $0)"
            let v219 : std_string_String = Fable.Core.RustInterop.emitRustExpr v213 v218
            v219
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : string = @$"format!(""{{}}"", $0)"
            let v221 : std_string_String = Fable.Core.RustInterop.emitRustExpr v213 v220
            v221
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v222 : std_string_String = null |> unbox<std_string_String>
            v222
#endif
            
#if FABLE_COMPILER_PYTHON
            let v223 : std_string_String = null |> unbox<std_string_String>
            v223
#endif
            
#else
            let v224 : std_string_String = null |> unbox<std_string_String>
            v224
#endif
            |> fun x -> _v214 <- Some x
            let v225 : std_string_String = _v214.Value
            let v226 : string = "fable_library_rust::String_::fromString($0)"
            let v227 : string = Fable.Core.RustInterop.emitRustExpr v225 v226
            v227
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v228 : string = null |> unbox<string>
            v228
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v229 : string = null |> unbox<string>
            v229
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v230 : string = null |> unbox<string>
            v230
#endif
            
#if FABLE_COMPILER_PYTHON
            let v231 : string = null |> unbox<string>
            v231
#endif
            
#else
            let v232 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v233 : string = v232 ()
            v233
#endif
            |> fun x -> _v206 <- Some x
            let v234 : string = _v206.Value
            let v235 : string = method13(v234, v195)
            let v236 : bool option = None
            let v237 : bool = true in let mutable _v236 = v236
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v238 : string = "cfg!(windows)"
            let v239 : bool = Fable.Core.RustInterop.emitRustExpr () v238
            v239
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v240 : bool = null |> unbox<bool>
            v240
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v241 : bool = null |> unbox<bool>
            v241
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v242 : bool = null |> unbox<bool>
            v242
#endif
            
#if FABLE_COMPILER_PYTHON
            let v243 : bool = null |> unbox<bool>
            v243
#endif
            
#else
            let v244 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v245 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v246 : bool = v245 v244
            v246
#endif
            |> fun x -> _v236 <- Some x
            let v247 : bool = _v236.Value
            let v248 : bool = v247 = false
            let v272 : string =
                if v248 then
                    v235
                else
                    let v249 : string option = None
                    let v250 : bool = true in let mutable _v249 = v249
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v251 : string = method22()
                    let v252 : string = method23(v235)
                    let v253 : string = method24()
                    let v254 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v255 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v251, v252, v253) v254
                    let v256 : string = "String::from($0)"
                    let v257 : std_string_String = Fable.Core.RustInterop.emitRustExpr v255 v256
                    let v258 : string = "fable_library_rust::String_::fromString($0)"
                    let v259 : string = Fable.Core.RustInterop.emitRustExpr v257 v258
                    v259
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v260 : string = null |> unbox<string>
                    v260
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v261 : string = null |> unbox<string>
                    v261
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v262 : string = null |> unbox<string>
                    v262
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v263 : string = null |> unbox<string>
                    v263
#endif
                    
#else
                    let v264 : string = "^\\\\\\\\\\?\\\\"
                    let v265 : string = ""
                    let v266 : string = System.Text.RegularExpressions.Regex.Replace (v235, v264, v265)
                    v266
#endif
                    |> fun x -> _v249 <- Some x
                    let v267 : string = _v249.Value
                    let v268 : string = $"{v267.[0] |> string |> _.ToLower()}{v267.[1..]}"
                    let v269 : string = "\\"
                    let v270 : string = "/"
                    let v271 : string = v268.Replace (v269, v270)
                    v271
            let v273 : string = "/"
            let v274 : (string []) = v272.Split v273
            let v275 : (string []) = [||]
            let v276 : int32 = v274.Length
            let v277 : Mut4 = {l0 = 0; l1 = 0; l2 = v275} : Mut4
            while method25(v276, v277) do
                let v279 : int32 = v277.l0
                let v280 : int32 =  -v279
                let v281 : int32 = v280 + v276
                let v282 : int32 = v281 - 1
                let struct (v283 : int32, v284 : (string [])) = v277.l1, v277.l2
                let v285 : string = v274.[int v282]
                let v286 : bool = ".." = v285
                let struct (v325 : int32, v326 : (string [])) =
                    if v286 then
                        let v287 : int32 = v283 + 1
                        struct (v287, v284)
                    else
                        let v288 : bool = 0 = v283
                        if v288 then
                            let v289 : string = ":"
                            let v290 : bool = v285.EndsWith v289
                            if v290 then
                                let v291 : string = $"{v234.[0]}:"
                                let v292 : (string []) = [|v291|]
                                let v293 : int32 = v292.Length
                                let v294 : int32 = v284.Length
                                let v295 : int32 = v293 + v294
                                let v296 : (string []) = Array.zeroCreate<string> (v295)
                                let v297 : Mut5 = {l0 = 0} : Mut5
                                while method26(v295, v297) do
                                    let v299 : int32 = v297.l0
                                    let v300 : bool = v299 < v293
                                    let v304 : string =
                                        if v300 then
                                            let v301 : string = v292.[int v299]
                                            v301
                                        else
                                            let v302 : int32 = v299 - v293
                                            let v303 : string = v284.[int v302]
                                            v303
                                    v296.[int v299] <- v304
                                    let v305 : int32 = v299 + 1
                                    v297.l0 <- v305
                                    ()
                                struct (0, v296)
                            else
                                let v306 : (string []) = [|v285|]
                                let v307 : int32 = v306.Length
                                let v308 : int32 = v284.Length
                                let v309 : int32 = v307 + v308
                                let v310 : (string []) = Array.zeroCreate<string> (v309)
                                let v311 : Mut5 = {l0 = 0} : Mut5
                                while method26(v309, v311) do
                                    let v313 : int32 = v311.l0
                                    let v314 : bool = v313 < v307
                                    let v318 : string =
                                        if v314 then
                                            let v315 : string = v306.[int v313]
                                            v315
                                        else
                                            let v316 : int32 = v313 - v307
                                            let v317 : string = v284.[int v316]
                                            v317
                                    v310.[int v313] <- v318
                                    let v319 : int32 = v313 + 1
                                    v311.l0 <- v319
                                    ()
                                struct (0, v310)
                        else
                            let v322 : int32 = v283 - 1
                            struct (v322, v284)
                let v327 : int32 = v279 + 1
                v277.l0 <- v327
                v277.l1 <- v325
                v277.l2 <- v326
                ()
            let struct (v328 : int32, v329 : (string [])) = v277.l1, v277.l2
            let v330 : string seq = seq { for i = 0 to v329.Length - 1 do yield v329.[i] }
            let v331 : char option = None
            let v332 : bool = true in let mutable _v331 = v331
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v333 : string = "std::path::MAIN_SEPARATOR"
            let v334 : char = Fable.Core.RustInterop.emitRustExpr () v333
            v334
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v335 : char = null |> unbox<char>
            v335
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v336 : char = null |> unbox<char>
            v336
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v337 : char = null |> unbox<char>
            v337
#endif
            
#if FABLE_COMPILER_PYTHON
            let v338 : char = null |> unbox<char>
            v338
#endif
            
#else
            let v339 : char = System.IO.Path.DirectorySeparatorChar
            v339
#endif
            |> fun x -> _v331 <- Some x
            let v340 : char = _v331.Value
            let v341 : (char -> string) = _.ToString()
            let v342 : string = v341 v340
            let v343 : string = method27(v342)
            let v344 : (string -> (string seq -> string)) = String.concat
            let v345 : (string seq -> string) = v344 v343
            v345 v330
        else
            let v347 : string = "std::fs::canonicalize(&*$0)"
            let v348 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v195 v347
            let v349 : string = "$0.unwrap()"
            let v350 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v348 v349
            let v351 : string = "$0.display()"
            let v352 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v350 v351
            let v353 : std_string_String option = None
            let v354 : bool = true in let mutable _v353 = v353
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v355 : string = @$"format!(""{{}}"", $0)"
            let v356 : std_string_String = Fable.Core.RustInterop.emitRustExpr v352 v355
            v356
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v357 : string = @$"format!(""{{}}"", $0)"
            let v358 : std_string_String = Fable.Core.RustInterop.emitRustExpr v352 v357
            v358
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v359 : string = @$"format!(""{{}}"", $0)"
            let v360 : std_string_String = Fable.Core.RustInterop.emitRustExpr v352 v359
            v360
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v361 : std_string_String = null |> unbox<std_string_String>
            v361
#endif
            
#if FABLE_COMPILER_PYTHON
            let v362 : std_string_String = null |> unbox<std_string_String>
            v362
#endif
            
#else
            let v363 : std_string_String = null |> unbox<std_string_String>
            v363
#endif
            |> fun x -> _v353 <- Some x
            let v364 : std_string_String = _v353.Value
            let v365 : string = "fable_library_rust::String_::fromString($0)"
            let v366 : string = Fable.Core.RustInterop.emitRustExpr v364 v365
            v366
    v367
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v368 : string = null |> unbox<string>
    v368
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v369 : string = null |> unbox<string>
    v369
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v370 : string = null |> unbox<string>
    v370
#endif
    
#if FABLE_COMPILER_PYTHON
    let v371 : string = null |> unbox<string>
    v371
#endif
    
#else
    let v372 : string = method28(v2)
    let v373 : (string -> string) = System.IO.Path.GetFullPath
    let v374 : string = v373 v372
    v374
#endif
    |> fun x -> _v193 <- Some x
    let v375 : string = _v193.Value
    let v376 : string option = None
    let v377 : bool = true in let mutable _v376 = v376
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v378 : string = method21(v1)
    let v379 : string = method14(v378)
    let v380 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v381 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v379 v380
    let v382 : string = "String::from($0)"
    let v383 : std_string_String = Fable.Core.RustInterop.emitRustExpr v381 v382
    let v384 : string = "std::path::PathBuf::from($0)"
    let v385 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v383 v384
    let v386 : string = "$0.exists()"
    let v387 : bool = Fable.Core.RustInterop.emitRustExpr v385 v386
    let v388 : bool = v387 = false
    let v550 : string =
        if v388 then
            let v389 : string option = None
            let v390 : bool = true in let mutable _v389 = v389
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v391 : string = "std::env::current_dir()"
            let v392 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v391
            let v393 : string = "$0.unwrap()"
            let v394 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v392 v393
            let v395 : string = "$0.display()"
            let v396 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v394 v395
            let v397 : std_string_String option = None
            let v398 : bool = true in let mutable _v397 = v397
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v399 : string = @$"format!(""{{}}"", $0)"
            let v400 : std_string_String = Fable.Core.RustInterop.emitRustExpr v396 v399
            v400
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v401 : string = @$"format!(""{{}}"", $0)"
            let v402 : std_string_String = Fable.Core.RustInterop.emitRustExpr v396 v401
            v402
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v403 : string = @$"format!(""{{}}"", $0)"
            let v404 : std_string_String = Fable.Core.RustInterop.emitRustExpr v396 v403
            v404
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v405 : std_string_String = null |> unbox<std_string_String>
            v405
#endif
            
#if FABLE_COMPILER_PYTHON
            let v406 : std_string_String = null |> unbox<std_string_String>
            v406
#endif
            
#else
            let v407 : std_string_String = null |> unbox<std_string_String>
            v407
#endif
            |> fun x -> _v397 <- Some x
            let v408 : std_string_String = _v397.Value
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
            let v415 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v416 : string = v415 ()
            v416
#endif
            |> fun x -> _v389 <- Some x
            let v417 : string = _v389.Value
            let v418 : string = method13(v417, v378)
            let v419 : bool option = None
            let v420 : bool = true in let mutable _v419 = v419
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v421 : string = "cfg!(windows)"
            let v422 : bool = Fable.Core.RustInterop.emitRustExpr () v421
            v422
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v423 : bool = null |> unbox<bool>
            v423
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v424 : bool = null |> unbox<bool>
            v424
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v425 : bool = null |> unbox<bool>
            v425
#endif
            
#if FABLE_COMPILER_PYTHON
            let v426 : bool = null |> unbox<bool>
            v426
#endif
            
#else
            let v427 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v428 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v429 : bool = v428 v427
            v429
#endif
            |> fun x -> _v419 <- Some x
            let v430 : bool = _v419.Value
            let v431 : bool = v430 = false
            let v455 : string =
                if v431 then
                    v418
                else
                    let v432 : string option = None
                    let v433 : bool = true in let mutable _v432 = v432
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v434 : string = method22()
                    let v435 : string = method23(v418)
                    let v436 : string = method24()
                    let v437 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v438 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v434, v435, v436) v437
                    let v439 : string = "String::from($0)"
                    let v440 : std_string_String = Fable.Core.RustInterop.emitRustExpr v438 v439
                    let v441 : string = "fable_library_rust::String_::fromString($0)"
                    let v442 : string = Fable.Core.RustInterop.emitRustExpr v440 v441
                    v442
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v443 : string = null |> unbox<string>
                    v443
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v444 : string = null |> unbox<string>
                    v444
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v445 : string = null |> unbox<string>
                    v445
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v446 : string = null |> unbox<string>
                    v446
#endif
                    
#else
                    let v447 : string = "^\\\\\\\\\\?\\\\"
                    let v448 : string = ""
                    let v449 : string = System.Text.RegularExpressions.Regex.Replace (v418, v447, v448)
                    v449
#endif
                    |> fun x -> _v432 <- Some x
                    let v450 : string = _v432.Value
                    let v451 : string = $"{v450.[0] |> string |> _.ToLower()}{v450.[1..]}"
                    let v452 : string = "\\"
                    let v453 : string = "/"
                    let v454 : string = v451.Replace (v452, v453)
                    v454
            let v456 : string = "/"
            let v457 : (string []) = v455.Split v456
            let v458 : (string []) = [||]
            let v459 : int32 = v457.Length
            let v460 : Mut4 = {l0 = 0; l1 = 0; l2 = v458} : Mut4
            while method25(v459, v460) do
                let v462 : int32 = v460.l0
                let v463 : int32 =  -v462
                let v464 : int32 = v463 + v459
                let v465 : int32 = v464 - 1
                let struct (v466 : int32, v467 : (string [])) = v460.l1, v460.l2
                let v468 : string = v457.[int v465]
                let v469 : bool = ".." = v468
                let struct (v508 : int32, v509 : (string [])) =
                    if v469 then
                        let v470 : int32 = v466 + 1
                        struct (v470, v467)
                    else
                        let v471 : bool = 0 = v466
                        if v471 then
                            let v472 : string = ":"
                            let v473 : bool = v468.EndsWith v472
                            if v473 then
                                let v474 : string = $"{v417.[0]}:"
                                let v475 : (string []) = [|v474|]
                                let v476 : int32 = v475.Length
                                let v477 : int32 = v467.Length
                                let v478 : int32 = v476 + v477
                                let v479 : (string []) = Array.zeroCreate<string> (v478)
                                let v480 : Mut5 = {l0 = 0} : Mut5
                                while method26(v478, v480) do
                                    let v482 : int32 = v480.l0
                                    let v483 : bool = v482 < v476
                                    let v487 : string =
                                        if v483 then
                                            let v484 : string = v475.[int v482]
                                            v484
                                        else
                                            let v485 : int32 = v482 - v476
                                            let v486 : string = v467.[int v485]
                                            v486
                                    v479.[int v482] <- v487
                                    let v488 : int32 = v482 + 1
                                    v480.l0 <- v488
                                    ()
                                struct (0, v479)
                            else
                                let v489 : (string []) = [|v468|]
                                let v490 : int32 = v489.Length
                                let v491 : int32 = v467.Length
                                let v492 : int32 = v490 + v491
                                let v493 : (string []) = Array.zeroCreate<string> (v492)
                                let v494 : Mut5 = {l0 = 0} : Mut5
                                while method26(v492, v494) do
                                    let v496 : int32 = v494.l0
                                    let v497 : bool = v496 < v490
                                    let v501 : string =
                                        if v497 then
                                            let v498 : string = v489.[int v496]
                                            v498
                                        else
                                            let v499 : int32 = v496 - v490
                                            let v500 : string = v467.[int v499]
                                            v500
                                    v493.[int v496] <- v501
                                    let v502 : int32 = v496 + 1
                                    v494.l0 <- v502
                                    ()
                                struct (0, v493)
                        else
                            let v505 : int32 = v466 - 1
                            struct (v505, v467)
                let v510 : int32 = v462 + 1
                v460.l0 <- v510
                v460.l1 <- v508
                v460.l2 <- v509
                ()
            let struct (v511 : int32, v512 : (string [])) = v460.l1, v460.l2
            let v513 : string seq = seq { for i = 0 to v512.Length - 1 do yield v512.[i] }
            let v514 : char option = None
            let v515 : bool = true in let mutable _v514 = v514
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v516 : string = "std::path::MAIN_SEPARATOR"
            let v517 : char = Fable.Core.RustInterop.emitRustExpr () v516
            v517
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v518 : char = null |> unbox<char>
            v518
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v519 : char = null |> unbox<char>
            v519
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v520 : char = null |> unbox<char>
            v520
#endif
            
#if FABLE_COMPILER_PYTHON
            let v521 : char = null |> unbox<char>
            v521
#endif
            
#else
            let v522 : char = System.IO.Path.DirectorySeparatorChar
            v522
#endif
            |> fun x -> _v514 <- Some x
            let v523 : char = _v514.Value
            let v524 : (char -> string) = _.ToString()
            let v525 : string = v524 v523
            let v526 : string = method27(v525)
            let v527 : (string -> (string seq -> string)) = String.concat
            let v528 : (string seq -> string) = v527 v526
            v528 v513
        else
            let v530 : string = "std::fs::canonicalize(&*$0)"
            let v531 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v378 v530
            let v532 : string = "$0.unwrap()"
            let v533 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v531 v532
            let v534 : string = "$0.display()"
            let v535 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v533 v534
            let v536 : std_string_String option = None
            let v537 : bool = true in let mutable _v536 = v536
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v538 : string = @$"format!(""{{}}"", $0)"
            let v539 : std_string_String = Fable.Core.RustInterop.emitRustExpr v535 v538
            v539
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v540 : string = @$"format!(""{{}}"", $0)"
            let v541 : std_string_String = Fable.Core.RustInterop.emitRustExpr v535 v540
            v541
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v542 : string = @$"format!(""{{}}"", $0)"
            let v543 : std_string_String = Fable.Core.RustInterop.emitRustExpr v535 v542
            v543
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v544 : std_string_String = null |> unbox<std_string_String>
            v544
#endif
            
#if FABLE_COMPILER_PYTHON
            let v545 : std_string_String = null |> unbox<std_string_String>
            v545
#endif
            
#else
            let v546 : std_string_String = null |> unbox<std_string_String>
            v546
#endif
            |> fun x -> _v536 <- Some x
            let v547 : std_string_String = _v536.Value
            let v548 : string = "fable_library_rust::String_::fromString($0)"
            let v549 : string = Fable.Core.RustInterop.emitRustExpr v547 v548
            v549
    v550
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v551 : string = null |> unbox<string>
    v551
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v552 : string = null |> unbox<string>
    v552
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v553 : string = null |> unbox<string>
    v553
#endif
    
#if FABLE_COMPILER_PYTHON
    let v554 : string = null |> unbox<string>
    v554
#endif
    
#else
    let v555 : string = method28(v1)
    let v556 : (string -> string) = System.IO.Path.GetFullPath
    let v557 : string = v556 v555
    v557
#endif
    |> fun x -> _v376 <- Some x
    let v558 : string = _v376.Value
    let v559 : US0 = US0_1
    let v560 : (unit -> string) = closure12()
    let v561 : (unit -> string) = closure13(v0, v192, v375, v558)
    method3(v559, v560, v561)
    method29(v0, v9, v192, v375, v558)
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
