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
    | US14_0 of f0_0 : std_process_Output
    | US14_1 of f1_0 : std_string_String
and [<Struct>] US15 =
    | US15_0 of f0_0 : (struct (bool * string * int32) -> Async<unit>)
    | US15_1
and [<Struct>] US16 =
    | US16_0 of f0_0 : System.Threading.CancellationToken
    | US16_1
and [<Struct>] US17 =
    | US17_0 of f0_0 : Result<string, (string * string)>
    | US17_1
and [<Struct>] US18 =
    | US18_0 of f0_0 : int32 * f0_1 : string
    | US18_1 of f1_0 : int32 * f1_1 : string
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
and method42 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : string option) : string =
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
and closure29 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : string option, v5 : string, v6 : Vec<std_string_String>) () : string =
    let v7 : string = $"execute_with_options / file_name: {v5} / arguments: %A{v6} / options: %A{struct (v0, v1, v2, v3, v4)}"
    v7
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
and method68 () : string =
    let v0 : string = "test\\n\\n"
    v0
and closure41 () (v0 : std_process_Output) : US14 =
    US14_0(v0)
and closure42 () (v0 : std_string_String) : US14 =
    US14_1(v0)
and closure43 (v0 : std_string_String) () : string =
    let v1 : string = $"execute_with_options -2 / error: {v0}"
    v1
and closure44 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"execute_with_options / exit_code: {v0} / std_trace.Length: {v1.Length}"
    v2
and method69 (v0 : (int32 * string)) : (int32 * string) =
    v0
and method52 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : string option, v5 : string, v6 : Vec<std_string_String>) : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> =
    let v7 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "std::process::Command::new(&*$0)"
    let v9 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v5 v8
    let v10 : string = "true; let mut v9 = v9"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : string = "std::process::Command::args(&mut $0, &*$1)"
    let v13 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr struct (v9, v6) v12
    let v14 : string = "true; let mut v13 = v13"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : string = "std::process::Command::stdout(&mut $0, std::process::Stdio::piped())"
    let v17 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v13 v16
    let v18 : string = "true; let mut v17 = v17"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : string = "std::process::Command::stderr(&mut $0, std::process::Stdio::piped())"
    let v21 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v17 v20
    let v22 : string = "true; let mut v21 = v21"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr () v22
    let v24 : string = "std::process::Command::stdin(&mut $0, std::process::Stdio::piped())"
    let v25 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v21 v24
    let v26 : (string -> US4) = method22()
    let v27 : US4 = US4_1
    let v28 : US4 = v4 |> Option.map v26 |> Option.defaultValue v27 
    let v34 : Ref<Mut<std_process_Command>> =
        match v28 with
        | US4_1 -> (* None *)
            v25
        | US4_0(v29) -> (* Some *)
            let v30 : string = method53(v29)
            let v31 : string = "std::process::Command::current_dir(v25, &*v30)"
            let v32 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr () v31
            v32
    let v35 : string = "true; let mut v34 = v34"
    let v36 : bool = Fable.Core.RustInterop.emitRustExpr () v35
    let v37 : string = "std::process::Command::spawn(&mut $0)"
    let v38 : Result<std_process_Child, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v34 v37
    let v39 : (std_process_Child -> std_sync_Arc<std_sync_Mutex<std_process_Child option>>) = method54()
    let v40 : Result<std_process_Child, std_io_Error> = method56(v38)
    let v41 : string = "v40.map(|x| v39(x))"
    let v42 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v41
    let v43 : (std_io_Error -> std_string_String) = method37()
    let v44 : string = "$0.map_err(|x| $1(x))"
    let v45 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v42, v43) v44
    let v46 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US11) = closure31()
    let v47 : (std_string_String -> US11) = closure32()
    let v48 : US11 = match v45 with Ok x -> v46 x | Error x -> v47 x
    let struct (v166 : int32, v167 : US3, v168 : US12) =
        match v48 with
        | US11_1(v157) -> (* Error *)
            let v158 : US0 = US0_4
            let v159 : (unit -> string) = closure33(v157)
            let v160 : (unit -> string) = closure6()
            method3(v158, v159, v160)
            let v161 : US3 = US3_0(v157)
            let v162 : US12 = US12_1
            struct (-1, v161, v162)
        | US11_0(v49) -> (* Ok *)
            let v50 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method57(v49)
            let v51 : string = "v50.lock().unwrap().as_mut().unwrap().stdout.take().unwrap()"
            let v52 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr () v51
            let v53 : string = "v50.lock().unwrap().as_mut().unwrap().stderr.take().unwrap()"
            let v54 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr () v53
            let v55 : string = "v50.lock().unwrap().as_mut().unwrap().stdin.take().unwrap()"
            let v56 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr () v55
            let v57 : std_process_ChildStdout option = Some v52 
            let v58 : string = "std::sync::Mutex::new($0)"
            let v59 : std_sync_Mutex<std_process_ChildStdout option> = Fable.Core.RustInterop.emitRustExpr v57 v58
            let v60 : std_sync_Mutex<std_process_ChildStdout option> = method58(v59)
            let v61 : string = "std::sync::Arc::new(v60)"
            let v62 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdout option>> = Fable.Core.RustInterop.emitRustExpr () v61
            let v63 : std_process_ChildStderr option = Some v54 
            let v64 : string = "std::sync::Mutex::new($0)"
            let v65 : std_sync_Mutex<std_process_ChildStderr option> = Fable.Core.RustInterop.emitRustExpr v63 v64
            let v66 : std_sync_Mutex<std_process_ChildStderr option> = method59(v65)
            let v67 : string = "std::sync::Arc::new(v66)"
            let v68 : std_sync_Arc<std_sync_Mutex<std_process_ChildStderr option>> = Fable.Core.RustInterop.emitRustExpr () v67
            let v69 : std_process_ChildStdin option = Some v56 
            let v70 : string = "std::sync::Mutex::new($0)"
            let v71 : std_sync_Mutex<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v69 v70
            let v72 : std_sync_Mutex<std_process_ChildStdin option> = method60(v71)
            let v73 : string = "std::sync::Arc::new(v72)"
            let v74 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v73
            let v75 : string = "{ let (sender, receiver) = std::sync::mpsc::channel(); (sender, std::sync::Arc::new(receiver)) }"
            let struct (v76 : std_sync_mpsc_Sender<std_string_String>, v77 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = Fable.Core.RustInterop.emitRustExpr () v75
            let v78 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> = method61(v77)
            let v79 : string = "true; let v78 = v78"
            let v80 : bool = Fable.Core.RustInterop.emitRustExpr v78 v79
            let v81 : string = "std::sync::Mutex::new($0)"
            let v82 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v76 v81
            let v83 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = method62(v82)
            let v84 : string = "std::sync::Arc::new(v83)"
            let v85 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v84
            let v86 : string = "v85.clone()"
            let v87 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v86
            let v88 : string = "v85.clone()"
            let v89 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v88
            let v90 : string = "std::sync::Mutex::new($0)"
            let v91 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v78 v90
            let v92 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = method63(v91)
            let v93 : string = "std::sync::Arc::new(v92)"
            let v94 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v93
            let v95 : string = "std::thread::spawn(move || { //"
            let v96 : std_thread_JoinHandle<unit> = Fable.Core.RustInterop.emitRustExpr () v95
            let v97 : string = "std::io::BufRead::lines(std::io::BufReader::new(v62.lock().unwrap().take().unwrap()))"
            let v98 : std_io_Lines<std_io_BufReader<std_process_ChildStdout>> = Fable.Core.RustInterop.emitRustExpr () v97
            let v99 : string = "std::sync::Mutex::new($0)"
            let v100 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> = Fable.Core.RustInterop.emitRustExpr v98 v99
            let v101 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> = method64(v100)
            let v102 : string = "std::sync::Arc::new(v101)"
            let v103 : std_sync_Arc<std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>>> = Fable.Core.RustInterop.emitRustExpr () v102
            let v104 : (Result<std_string_String, std_io_Error> -> unit) = method65(v87)
            let v105 : string = "true; for line in $0.lock().unwrap().by_ref() { v104(line) }"
            let v106 : bool = Fable.Core.RustInterop.emitRustExpr v103 v105
            let v107 : string = "true; })"
            let v108 : bool = Fable.Core.RustInterop.emitRustExpr () v107
            let v109 : string = "std::thread::spawn(move || { //"
            let v110 : std_thread_JoinHandle<unit> = Fable.Core.RustInterop.emitRustExpr () v109
            let v111 : string = "std::io::BufRead::lines(std::io::BufReader::new(v68.lock().unwrap().take().unwrap()))"
            let v112 : std_io_Lines<std_io_BufReader<std_process_ChildStderr>> = Fable.Core.RustInterop.emitRustExpr () v111
            let v113 : string = "std::sync::Mutex::new($0)"
            let v114 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>> = Fable.Core.RustInterop.emitRustExpr v112 v113
            let v115 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>> = method66(v114)
            let v116 : string = "std::sync::Arc::new(v115)"
            let v117 : std_sync_Arc<std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>>> = Fable.Core.RustInterop.emitRustExpr () v116
            let v118 : (Result<std_string_String, std_io_Error> -> unit) = method67(v85)
            let v119 : string = "true; for line in $0.lock().unwrap().by_ref() { v118(line) }"
            let v120 : bool = Fable.Core.RustInterop.emitRustExpr v117 v119
            let v121 : string = "true; })"
            let v122 : bool = Fable.Core.RustInterop.emitRustExpr () v121
            let v123 : string = method68()
            let v124 : string = "v123.as_bytes()"
            let v125 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v124
            let v126 : string = "true; std::io::Write::write_all(&mut v74.lock().unwrap().take().unwrap(), v125).unwrap()"
            let v127 : bool = Fable.Core.RustInterop.emitRustExpr () v126
            let v128 : string = "v50.lock().unwrap().take().unwrap().wait_with_output()"
            let v129 : Result<std_process_Output, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v128
            let v130 : (std_io_Error -> std_string_String) = method37()
            let v131 : string = "$0.map_err(|x| $1(x))"
            let v132 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v129, v130) v131
            let v133 : string = "true; v96.join().unwrap()"
            let v134 : bool = Fable.Core.RustInterop.emitRustExpr () v133
            let v135 : string = "true; v110.join().unwrap()"
            let v136 : bool = Fable.Core.RustInterop.emitRustExpr () v135
            let v137 : (std_process_Output -> US14) = closure41()
            let v138 : (std_string_String -> US14) = closure42()
            let v139 : US14 = match v132 with Ok x -> v137 x | Error x -> v138 x
            match v139 with
            | US14_1(v145) -> (* Error *)
                let v146 : US0 = US0_4
                let v147 : (unit -> string) = closure43(v145)
                let v148 : (unit -> string) = closure6()
                method3(v146, v147, v148)
                let v149 : US3 = US3_0(v145)
                let v150 : US12 = US12_1
                struct (-2, v149, v150)
            | US14_0(v140) -> (* Ok *)
                let v141 : string = "$0.status.code().unwrap()"
                let v142 : int32 = Fable.Core.RustInterop.emitRustExpr v140 v141
                let v143 : US3 = US3_1
                let v144 : US12 = US12_0(v94)
                struct (v142, v143, v144)
    let v175 : US3 =
        match v168 with
        | US12_1 -> (* None *)
            US3_1
        | US12_0(v169) -> (* Some *)
            let v170 : string = "$0.lock().unwrap().iter().collect::<Vec<String>>().join(\"\\n\")"
            let v171 : std_string_String = Fable.Core.RustInterop.emitRustExpr v169 v170
            US3_0(v171)
    let v182 : US4 =
        match v175 with
        | US3_1 -> (* None *)
            US4_1
        | US3_0(v176) -> (* Some *)
            let v177 : string = "fable_library_rust::String_::fromString($0)"
            let v178 : string = Fable.Core.RustInterop.emitRustExpr v176 v177
            US4_0(v178)
    let v189 : US4 =
        match v167 with
        | US3_1 -> (* None *)
            US4_1
        | US3_0(v183) -> (* Some *)
            let v184 : string = "fable_library_rust::String_::fromString($0)"
            let v185 : string = Fable.Core.RustInterop.emitRustExpr v183 v184
            US4_0(v185)
    let v193 : string =
        match v189 with
        | US4_1 -> (* None *)
            let v191 : string = ""
            v191
        | US4_0(v190) -> (* Some *)
            v190
    let v196 : string =
        match v182 with
        | US4_1 -> (* None *)
            v193
        | US4_0(v194) -> (* Some *)
            v194
    let v197 : US0 = US0_0
    let v198 : (unit -> string) = closure44(v166, v196)
    let v199 : (unit -> string) = closure6()
    method3(v197, v198, v199)
    let v200 : (int32 * string) = v166, v196
    let v201 : (int32 * string) = method69(v200)
    let v202 : string = "v201 }}})"
    Fable.Core.RustInterop.emitRustExpr () v202
    let v203 : string = "{{ //"
    Fable.Core.RustInterop.emitRustExpr () v203
    let v204 : string = "__result"
    let v205 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = Fable.Core.RustInterop.emitRustExpr () v204
    v205
and closure45 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : string option) () : string =
    let v5 : string = $"execute_with_options_async / options: %A{struct (v0, v1, v2, v3, v4)}"
    v5
and closure47 () (v0 : (struct (bool * string * int32) -> Async<unit>)) : US15 =
    US15_0(v0)
and method70 () : ((struct (bool * string * int32) -> Async<unit>) -> US15) =
    closure47()
and closure48 (v0 : string) () : string =
    let v1 : string = $"> {v0}"
    v1
and closure46 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : string option, v5 : System.Diagnostics.Process, v6 : System.Collections.Concurrent.ConcurrentStack<string>) (v7 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v8 : Async<unit> option = None
    let v9 : bool = true in let mutable _v8 = v8
    
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
    let v16 : string = v7.Data
    let v17 : string = null |> unbox<string>
    let v18 : bool = v16 = v17
    let v19 : bool = v18 <> true
    if v19 then
        let v20 : ((struct (bool * string * int32) -> Async<unit>) -> US15) = method70()
        let v21 : US15 = US15_1
        let v22 : US15 = v3 |> Option.map v20 |> Option.defaultValue v21 
        match v22 with
        | US15_1 -> (* None *)
            ()
        | US15_0(v23) -> (* Some *)
            let v24 : int32 = v5.Id
            let v25 : Async<unit> = v23 struct (false, v16, v24)
            do! v25 
            ()
        let v26 : US0 = US0_0
        let v27 : (unit -> string) = closure48(v16)
        let v28 : (unit -> string) = closure6()
        method3(v26, v27, v28)
        let v29 : string = ""
        let v30 : string = $"{v29}{v16}{v29}"
        let v31 : (string -> unit) = v6.Push
        v31 v30
    }
    |> fun x -> _v15 <- Some x
    let v32 : Async<unit> = _v15 |> Option.get
    v32
#endif
    |> fun x -> _v8 <- Some x
    let v33 : Async<unit> = _v8.Value
    let v34 : unit option = None
    let v35 : bool = true in let mutable _v34 = v34
    
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
    let v36 : (Async<unit> -> unit) = Async.StartImmediate
    v36 v33
    ()
#endif
    |> fun x -> _v34 <- Some x
    _v34.Value
    ()
and closure49 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : string option, v5 : System.Diagnostics.Process, v6 : System.Collections.Concurrent.ConcurrentStack<string>) (v7 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v8 : Async<unit> option = None
    let v9 : bool = true in let mutable _v8 = v8
    
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
    let v16 : string = v7.Data
    let v17 : string = null |> unbox<string>
    let v18 : bool = v16 = v17
    let v19 : bool = v18 <> true
    if v19 then
        let v20 : ((struct (bool * string * int32) -> Async<unit>) -> US15) = method70()
        let v21 : US15 = US15_1
        let v22 : US15 = v3 |> Option.map v20 |> Option.defaultValue v21 
        match v22 with
        | US15_1 -> (* None *)
            ()
        | US15_0(v23) -> (* Some *)
            let v24 : int32 = v5.Id
            let v25 : Async<unit> = v23 struct (true, v16, v24)
            do! v25 
            ()
        let v26 : US0 = US0_0
        let v27 : (unit -> string) = closure48(v16)
        let v28 : (unit -> string) = closure6()
        method3(v26, v27, v28)
        let v29 : string = "["
        let v30 : string = "]"
        let v31 : string = $"{v29}{v16}{v30}"
        let v32 : (string -> unit) = v6.Push
        v32 v31
    }
    |> fun x -> _v15 <- Some x
    let v33 : Async<unit> = _v15 |> Option.get
    v33
#endif
    |> fun x -> _v8 <- Some x
    let v34 : Async<unit> = _v8.Value
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
and closure50 () (v0 : System.Threading.CancellationToken) : US16 =
    US16_0(v0)
and method71 () : (System.Threading.CancellationToken -> US16) =
    closure50()
and closure51 (v0 : System.Diagnostics.Process) () : unit =
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
and closure52 (v0 : System.Threading.Tasks.TaskCanceledException) () : string =
    let v1 : string = $"execute_with_options_async / WaitForExitAsync / ex: %A{v0}"
    v1
and method72 () : string =
    let v0 : string = "\n"
    v0
and closure53 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"execute_with_options_async / exit_code: {v0} / output.Length: {v1.Length}"
    v2
and closure55 () () : string =
    let v0 : string = "documents.run / par_map / files_fn"
    v0
and closure56 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: %A{v1} / result: {v0} / {v2 ()}"
    v3
and method73 (v0 : string) : string =
    v0
and closure54 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : string) : US17 =
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
    let v590 : bool =
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
            let v113 : string = $"pwsh -c \"(Get-FileHash \\\"{v108}\\\" -Algorithm SHA256).Hash\""
            let v114 : struct (int32 * string) option = None
            let v115 : bool = true in let mutable _v114 = v114
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v116 : string = method42(v110, v113, v111, v112, v109)
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
            let v144 : (unit -> string) = closure29(v110, v113, v111, v112, v109, v135, v142)
            let v145 : (unit -> string) = method51()
            method3(v143, v144, v145)
            let v146 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method52(v110, v113, v111, v112, v109, v135, v142)
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
            let v196 : US4 = v109 |> Option.map v194 |> Option.defaultValue v195 
            let v200 : string =
                match v196 with
                | US4_1 -> (* None *)
                    let v198 : string = ""
                    v198
                | US4_0(v197) -> (* Some *)
                    v197
            let v201 : US0 = US0_1
            let v202 : (unit -> string) = closure45(v110, v113, v111, v112, v109)
            let v203 : (unit -> string) = method51()
            method3(v201, v202, v203)
            let v204 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v205 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v193, StandardOutputEncoding = v204, WorkingDirectory = v200, FileName = v192, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v206 : int32 = v111.Length
            let v207 : Mut5 = {l0 = 0} : Mut5
            while method30(v206, v207) do
                let v209 : int32 = v207.l0
                let struct (v210 : string, v211 : string) = v111.[int v209]
                v205.EnvironmentVariables.[v210] <- v211 
                let v212 : int32 = v209 + 1
                v207.l0 <- v212
                ()
            let v213 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v205)
            use v213 = v213 
            let v214 : System.Diagnostics.Process = v213 
            let v215 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v216 : System.Collections.Concurrent.ConcurrentStack<string> = v215 ()
            let v217 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure46(v110, v113, v111, v112, v109, v214, v216)
            v214.OutputDataReceived.Add v217 
            let v218 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v110, v113, v111, v112, v109, v214, v216)
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
            let v225 : (System.Threading.CancellationToken -> US16) = method71()
            let v226 : US16 = US16_1
            let v227 : US16 = v110 |> Option.map v225 |> Option.defaultValue v226 
            let v231 : System.Threading.CancellationToken =
                match v227 with
                | US16_1 -> (* None *)
                    let v229 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v229
                | US16_0(v228) -> (* Some *)
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
            let v259 : (unit -> unit) = closure51(v214)
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
            let v295 : (unit -> string) = closure52(v293)
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
            let v302 : string = method72()
            let v303 : (string -> (string seq -> string)) = String.concat
            let v304 : (string seq -> string) = v303 v302
            let v305 : string = v304 v301
            let v306 : US0 = US0_1
            let v307 : (unit -> string) = closure53(v299, v305)
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
                    v23
                else
                    let v344 : string option = None
                    let v345 : bool = true in let mutable _v344 = v344
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v346 : string = method26()
                    let v347 : string = method27(v23)
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
                    let v361 : string = System.Text.RegularExpressions.Regex.Replace (v23, v359, v360)
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
            let v372 : string = $"pwsh -c \"(Get-FileHash \\\"{v367}\\\" -Algorithm SHA256).Hash\""
            let v373 : struct (int32 * string) option = None
            let v374 : bool = true in let mutable _v373 = v373
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v375 : string = method42(v369, v372, v370, v371, v368)
            let struct (v376 : string, v377 : string) = method43()
            let v378 : int32 = v375.Length
            let v379 : (char []) = Array.zeroCreate<char> (v378)
            let v380 : Mut5 = {l0 = 0} : Mut5
            while method30(v378, v380) do
                let v382 : int32 = v380.l0
                let v383 : char = v375.[int v382]
                v379.[int v382] <- v383
                let v384 : int32 = v382 + 1
                v380.l0 <- v384
                ()
            let v385 : ((char []) -> char list) = Array.toList
            let v386 : char list = v385 v379
            let v387 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v388 : (char -> (UH0 -> UH0)) = method44()
            let v389 : (char list -> (UH0 -> UH0)) = v387 v388
            let v390 : (UH0 -> UH0) = v389 v386
            let v391 : UH0 = UH0_0
            let v392 : UH0 = v390 v391
            let v393 : US8 = US8_0
            let struct (v394 : string, v395 : string) = method45(v377, v376, v392, v393)
            let v396 : (string []) = method46(v395)
            let v397 : string = "$0.to_vec()"
            let v398 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v396 v397
            let v399 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v400 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v398, v141) v399
            let v401 : US0 = US0_1
            let v402 : (unit -> string) = closure29(v369, v372, v370, v371, v368, v394, v400)
            let v403 : (unit -> string) = method51()
            method3(v401, v402, v403)
            let v404 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method52(v369, v372, v370, v371, v368, v394, v400)
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
            let struct (v432 : string, v433 : string) = method43()
            let v434 : int32 = v372.Length
            let v435 : (char []) = Array.zeroCreate<char> (v434)
            let v436 : Mut5 = {l0 = 0} : Mut5
            while method30(v434, v436) do
                let v438 : int32 = v436.l0
                let v439 : char = v372.[int v438]
                v435.[int v438] <- v439
                let v440 : int32 = v438 + 1
                v436.l0 <- v440
                ()
            let v441 : ((char []) -> char list) = Array.toList
            let v442 : char list = v441 v435
            let v443 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v444 : (char -> (UH0 -> UH0)) = method44()
            let v445 : (char list -> (UH0 -> UH0)) = v443 v444
            let v446 : (UH0 -> UH0) = v445 v442
            let v447 : UH0 = UH0_0
            let v448 : UH0 = v446 v447
            let v449 : US8 = US8_0
            let struct (v450 : string, v451 : string) = method45(v433, v432, v448, v449)
            let v452 : (string -> US4) = method22()
            let v453 : US4 = US4_1
            let v454 : US4 = v368 |> Option.map v452 |> Option.defaultValue v453 
            let v458 : string =
                match v454 with
                | US4_1 -> (* None *)
                    let v456 : string = ""
                    v456
                | US4_0(v455) -> (* Some *)
                    v455
            let v459 : US0 = US0_1
            let v460 : (unit -> string) = closure45(v369, v372, v370, v371, v368)
            let v461 : (unit -> string) = method51()
            method3(v459, v460, v461)
            let v462 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v463 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v451, StandardOutputEncoding = v462, WorkingDirectory = v458, FileName = v450, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v464 : int32 = v370.Length
            let v465 : Mut5 = {l0 = 0} : Mut5
            while method30(v464, v465) do
                let v467 : int32 = v465.l0
                let struct (v468 : string, v469 : string) = v370.[int v467]
                v463.EnvironmentVariables.[v468] <- v469 
                let v470 : int32 = v467 + 1
                v465.l0 <- v470
                ()
            let v471 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v463)
            use v471 = v471 
            let v472 : System.Diagnostics.Process = v471 
            let v473 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v474 : System.Collections.Concurrent.ConcurrentStack<string> = v473 ()
            let v475 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure46(v369, v372, v370, v371, v368, v472, v474)
            v472.OutputDataReceived.Add v475 
            let v476 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v369, v372, v370, v371, v368, v472, v474)
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
            let v483 : (System.Threading.CancellationToken -> US16) = method71()
            let v484 : US16 = US16_1
            let v485 : US16 = v369 |> Option.map v483 |> Option.defaultValue v484 
            let v489 : System.Threading.CancellationToken =
                match v485 with
                | US16_1 -> (* None *)
                    let v487 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v487
                | US16_0(v486) -> (* Some *)
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
            let v517 : (unit -> unit) = closure51(v472)
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
            let v553 : (unit -> string) = closure52(v551)
            let v554 : (unit -> string) = method51()
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
            let v560 : string = method72()
            let v561 : (string -> (string seq -> string)) = String.concat
            let v562 : (string seq -> string) = v561 v560
            let v563 : string = v562 v559
            let v564 : US0 = US0_1
            let v565 : (unit -> string) = closure53(v557, v563)
            let v566 : (unit -> string) = method51()
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
            let v589 : bool = v330 = v588
            v589
        else
            false
    let v591 : bool = v590 = false
    if v591 then
        let v592 : string option = None
        let v593 : System.Threading.CancellationToken option = None
        let v594 : (struct (string * string) []) = [||]
        let v595 : (struct (bool * string * int32) -> Async<unit>) option = None
        let v596 : bool option = None
        let v597 : bool = true in let mutable _v596 = v596
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v598 : string = "cfg!(windows)"
        let v599 : bool = Fable.Core.RustInterop.emitRustExpr () v598
        v599
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v600 : bool = null |> unbox<bool>
        v600
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v601 : bool = null |> unbox<bool>
        v601
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v602 : bool = null |> unbox<bool>
        v602
#endif
        
#if FABLE_COMPILER_PYTHON
        let v603 : bool = null |> unbox<bool>
        v603
#endif
        
#else
        let v604 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
        let v605 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
        let v606 : bool = v605 v604
        v606
#endif
        |> fun x -> _v596 <- Some x
        let v607 : bool = _v596.Value
        let v610 : string =
            if v607 then
                let v608 : string = ".exe"
                v608
            else
                let v609 : string = ""
                v609
        let v611 : string = $"../vault/deps/hangulize/cmd/hangulize/hangulize{v610}"
        let v612 : string option = None
        let v613 : bool = true in let mutable _v612 = v612
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v614 : string = method18(v3)
        let v615 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
        let v616 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v614 v615
        let v617 : string = "String::from($0)"
        let v618 : std_string_String = Fable.Core.RustInterop.emitRustExpr v616 v617
        let v619 : string = "std::path::PathBuf::from($0)"
        let v620 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v618 v619
        let v621 : string = method18(v611)
        let v622 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
        let v623 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v621 v622
        let v624 : string = "String::from($0)"
        let v625 : std_string_String = Fable.Core.RustInterop.emitRustExpr v623 v624
        let v626 : string = "$0.join($1)"
        let v627 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v620, v625) v626
        let v628 : string = "$0.display()"
        let v629 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v627 v628
        let v630 : std_string_String option = None
        let v631 : bool = true in let mutable _v630 = v630
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v632 : string = @$"format!(""{{}}"", $0)"
        let v633 : std_string_String = Fable.Core.RustInterop.emitRustExpr v629 v632
        v633
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v634 : string = @$"format!(""{{}}"", $0)"
        let v635 : std_string_String = Fable.Core.RustInterop.emitRustExpr v629 v634
        v635
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v636 : string = @$"format!(""{{}}"", $0)"
        let v637 : std_string_String = Fable.Core.RustInterop.emitRustExpr v629 v636
        v637
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v638 : std_string_String = null |> unbox<std_string_String>
        v638
#endif
        
#if FABLE_COMPILER_PYTHON
        let v639 : std_string_String = null |> unbox<std_string_String>
        v639
#endif
        
#else
        let v640 : std_string_String = null |> unbox<std_string_String>
        v640
#endif
        |> fun x -> _v630 <- Some x
        let v641 : std_string_String = _v630.Value
        let v642 : string = "fable_library_rust::String_::fromString($0)"
        let v643 : string = Fable.Core.RustInterop.emitRustExpr v641 v642
        v643
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v644 : string = null |> unbox<string>
        v644
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v645 : string = null |> unbox<string>
        v645
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v646 : string = "path"
        let v647 : IPathJoin = Fable.Core.JsInterop.importAll v646
        let v648 : string = method19(v3)
        let v649 : string = method20(v611)
        let v650 : string = "v647.join(v648, v649)"
        let v651 : string = Fable.Core.JsInterop.emitJsExpr () v650
        v651
#endif
        
#if FABLE_COMPILER_PYTHON
        let v652 : string = null |> unbox<string>
        v652
#endif
        
#else
        let v653 : string = System.IO.Path.Combine (v3, v611)
        v653
#endif
        |> fun x -> _v612 <- Some x
        let v654 : string = _v612.Value
        let v655 : string = $"{v654} {v2}"
        let v656 : struct (int32 * string) option = None
        let v657 : bool = true in let mutable _v656 = v656
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v658 : string = method42(v593, v655, v594, v595, v592)
        let struct (v659 : string, v660 : string) = method43()
        let v661 : int32 = v658.Length
        let v662 : (char []) = Array.zeroCreate<char> (v661)
        let v663 : Mut5 = {l0 = 0} : Mut5
        while method30(v661, v663) do
            let v665 : int32 = v663.l0
            let v666 : char = v658.[int v665]
            v662.[int v665] <- v666
            let v667 : int32 = v665 + 1
            v663.l0 <- v667
            ()
        let v668 : ((char []) -> char list) = Array.toList
        let v669 : char list = v668 v662
        let v670 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
        let v671 : (char -> (UH0 -> UH0)) = method44()
        let v672 : (char list -> (UH0 -> UH0)) = v670 v671
        let v673 : (UH0 -> UH0) = v672 v669
        let v674 : UH0 = UH0_0
        let v675 : UH0 = v673 v674
        let v676 : US8 = US8_0
        let struct (v677 : string, v678 : string) = method45(v660, v659, v675, v676)
        let v679 : (string []) = method46(v678)
        let v680 : string = "$0.to_vec()"
        let v681 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v679 v680
        let v682 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
        let v683 : (string -> std_string_String) = closure28()
        let v684 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v681, v683) v682
        let v685 : US0 = US0_1
        let v686 : (unit -> string) = closure29(v593, v655, v594, v595, v592, v677, v684)
        let v687 : (unit -> string) = method51()
        method3(v685, v686, v687)
        let v688 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method52(v593, v655, v594, v595, v592, v677, v684)
        let v689 : string = "futures_lite::future::block_on($0)"
        let v690 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v688 v689
        let (a, b) = v690
        let v691 : int32 = a
        let v692 : string = b
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
        let v701 : Async<struct (int32 * string)> option = None
        let v702 : bool = true in let mutable _v701 = v701
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v703 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v703
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v704 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v704
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v705 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v705
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v706 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v706
#endif
        
#if FABLE_COMPILER_PYTHON
        let v707 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v707
#endif
        
#else
        let v708 : Async<struct (int32 * string)> option = None
        let v709 : bool = true in let mutable _v708 = v708
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v710 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v710
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v711 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v711
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v712 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v712
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v713 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v713
#endif
        
#if FABLE_COMPILER_PYTHON
        let v714 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v714
#endif
        
#else
        let v715 : Async<struct (int32 * string)> option = None
        let mutable _v715 = v715
        async {
        let struct (v716 : string, v717 : string) = method43()
        let v718 : int32 = v655.Length
        let v719 : (char []) = Array.zeroCreate<char> (v718)
        let v720 : Mut5 = {l0 = 0} : Mut5
        while method30(v718, v720) do
            let v722 : int32 = v720.l0
            let v723 : char = v655.[int v722]
            v719.[int v722] <- v723
            let v724 : int32 = v722 + 1
            v720.l0 <- v724
            ()
        let v725 : ((char []) -> char list) = Array.toList
        let v726 : char list = v725 v719
        let v727 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
        let v728 : (char -> (UH0 -> UH0)) = method44()
        let v729 : (char list -> (UH0 -> UH0)) = v727 v728
        let v730 : (UH0 -> UH0) = v729 v726
        let v731 : UH0 = UH0_0
        let v732 : UH0 = v730 v731
        let v733 : US8 = US8_0
        let struct (v734 : string, v735 : string) = method45(v717, v716, v732, v733)
        let v736 : (string -> US4) = method22()
        let v737 : US4 = US4_1
        let v738 : US4 = v592 |> Option.map v736 |> Option.defaultValue v737 
        let v742 : string =
            match v738 with
            | US4_1 -> (* None *)
                let v740 : string = ""
                v740
            | US4_0(v739) -> (* Some *)
                v739
        let v743 : US0 = US0_1
        let v744 : (unit -> string) = closure45(v593, v655, v594, v595, v592)
        let v745 : (unit -> string) = method51()
        method3(v743, v744, v745)
        let v746 : System.Text.Encoding = System.Text.Encoding.UTF8
        let v747 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v735, StandardOutputEncoding = v746, WorkingDirectory = v742, FileName = v734, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
        let v748 : int32 = v594.Length
        let v749 : Mut5 = {l0 = 0} : Mut5
        while method30(v748, v749) do
            let v751 : int32 = v749.l0
            let struct (v752 : string, v753 : string) = v594.[int v751]
            v747.EnvironmentVariables.[v752] <- v753 
            let v754 : int32 = v751 + 1
            v749.l0 <- v754
            ()
        let v755 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v747)
        use v755 = v755 
        let v756 : System.Diagnostics.Process = v755 
        let v757 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
        let v758 : System.Collections.Concurrent.ConcurrentStack<string> = v757 ()
        let v759 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure46(v593, v655, v594, v595, v592, v756, v758)
        v756.OutputDataReceived.Add v759 
        let v760 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v593, v655, v594, v595, v592, v756, v758)
        v756.ErrorDataReceived.Add v760 
        let v761 : (unit -> bool) = v756.Start
        let v762 : bool = v761 ()
        let v763 : bool = v762 = false
        if v763 then
            let v764 : string = $"execute_with_options_async / process_start error"
            failwith<unit> v764
        let v765 : (unit -> unit) = v756.BeginErrorReadLine
        v765 ()
        let v766 : (unit -> unit) = v756.BeginOutputReadLine
        v766 ()
        let v767 : (System.Threading.CancellationToken -> US16) = method71()
        let v768 : US16 = US16_1
        let v769 : US16 = v593 |> Option.map v767 |> Option.defaultValue v768 
        let v773 : System.Threading.CancellationToken =
            match v769 with
            | US16_1 -> (* None *)
                let v771 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                v771
            | US16_0(v770) -> (* Some *)
                v770
        let v774 : Async<System.Threading.CancellationToken> option = None
        let v775 : bool = true in let mutable _v774 = v774
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v776 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v776
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v777 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v777
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v778 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v778
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v779 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v779
#endif
        
#if FABLE_COMPILER_PYTHON
        let v780 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v780
#endif
        
#else
        let v781 : Async<System.Threading.CancellationToken> option = None
        let v782 : bool = true in let mutable _v781 = v781
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v783 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v783
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v784 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v784
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v785 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v785
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v786 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v786
#endif
        
#if FABLE_COMPILER_PYTHON
        let v787 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v787
#endif
        
#else
        let v788 : Async<System.Threading.CancellationToken> option = None
        let mutable _v788 = v788
        async {
        let v789 : Async<System.Threading.CancellationToken> = Async.CancellationToken
        let! v789 = v789 
        let v790 : System.Threading.CancellationToken = v789 
        let v791 : System.Threading.CancellationToken = Async.DefaultCancellationToken
        let v792 : (System.Threading.CancellationToken []) = [|v790; v791; v773|]
        let v793 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
        let v794 : System.Threading.CancellationTokenSource = v793 v792
        let v795 : System.Threading.CancellationToken = v794.Token
        return v795 
        }
        |> fun x -> _v788 <- Some x
        let v796 : Async<System.Threading.CancellationToken> = _v788 |> Option.get
        v796
#endif
        |> fun x -> _v781 <- Some x
        let v797 : Async<System.Threading.CancellationToken> = _v781.Value
        v797
#endif
        |> fun x -> _v774 <- Some x
        let v798 : Async<System.Threading.CancellationToken> = _v774.Value
        let! v798 = v798 
        let v799 : System.Threading.CancellationToken = v798 
        let v800 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v799.Register
        let v801 : (unit -> unit) = closure51(v756)
        let v802 : System.Threading.CancellationTokenRegistration = v800 v801
        use v802 = v802 
        let v803 : System.Threading.CancellationTokenRegistration = v802 
        let v804 : Async<int32> option = None
        let v805 : bool = true in let mutable _v804 = v804
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v806 : Async<int32> = null |> unbox<Async<int32>>
        v806
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v807 : Async<int32> = null |> unbox<Async<int32>>
        v807
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v808 : Async<int32> = null |> unbox<Async<int32>>
        v808
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v809 : Async<int32> = null |> unbox<Async<int32>>
        v809
#endif
        
#if FABLE_COMPILER_PYTHON
        let v810 : Async<int32> = null |> unbox<Async<int32>>
        v810
#endif
        
#else
        let v811 : Async<int32> option = None
        let mutable _v811 = v811
        async {
        try
        let v812 : System.Threading.Tasks.Task = v756.WaitForExitAsync v799 
        let v813 : Async<unit> option = None
        let v814 : bool = true in let mutable _v813 = v813
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v815 : Async<unit> = null |> unbox<Async<unit>>
        v815
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v816 : Async<unit> = null |> unbox<Async<unit>>
        v816
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v817 : Async<unit> = null |> unbox<Async<unit>>
        v817
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v818 : Async<unit> = null |> unbox<Async<unit>>
        v818
#endif
        
#if FABLE_COMPILER_PYTHON
        let v819 : Async<unit> = null |> unbox<Async<unit>>
        v819
#endif
        
#else
        let v820 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
        let v821 : Async<unit> = v820 v812
        v821
#endif
        |> fun x -> _v813 <- Some x
        let v822 : Async<unit> = _v813.Value
        do! v822 
        let v823 : int32 = v756.ExitCode
        return v823 
        with ex ->
        let v824 : exn = ex
        let v825 : string option = None
        let v826 : bool = true in let mutable _v825 = v825
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v827 : string = $"%A{v824}"
        v827
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v828 : string = $"%A{v824}"
        v828
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v829 : string = $"%A{v824}"
        v829
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v830 : string = $"%A{v824}"
        v830
#endif
        
#if FABLE_COMPILER_PYTHON
        let v831 : string = $"%A{v824}"
        v831
#endif
        
#else
        let v832 : string = $"{v824.GetType ()}: {v824.Message}"
        v832
#endif
        |> fun x -> _v825 <- Some x
        let v833 : string = _v825.Value
        let v834 : (string -> unit) = v758.Push
        v834 v833
        let v835 : System.Threading.Tasks.TaskCanceledException = v824 |> unbox<System.Threading.Tasks.TaskCanceledException>
        let v836 : US0 = US0_3
        let v837 : (unit -> string) = closure52(v835)
        let v838 : (unit -> string) = method51()
        method3(v836, v837, v838)
        return -2147483648 
        (*
        *)
        }
        |> fun x -> _v811 <- Some x
        let v839 : Async<int32> = _v811 |> Option.get
        v839
#endif
        |> fun x -> _v804 <- Some x
        let v840 : Async<int32> = _v804.Value
        let! v840 = v840 
        let v841 : int32 = v840 
        let v842 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
        let v843 : string seq = v842 v758
        let v844 : string = method72()
        let v845 : (string -> (string seq -> string)) = String.concat
        let v846 : (string seq -> string) = v845 v844
        let v847 : string = v846 v843
        let v848 : US0 = US0_1
        let v849 : (unit -> string) = closure53(v841, v847)
        let v850 : (unit -> string) = method51()
        method3(v848, v849, v850)
        return struct (v841, v847) 
        }
        |> fun x -> _v715 <- Some x
        let v851 : Async<struct (int32 * string)> = _v715 |> Option.get
        v851
#endif
        |> fun x -> _v708 <- Some x
        let v852 : Async<struct (int32 * string)> = _v708.Value
        v852
#endif
        |> fun x -> _v701 <- Some x
        let v853 : Async<struct (int32 * string)> = _v701.Value
        let v854 : struct (int32 * string) option = None
        let v855 : bool = true in let mutable _v854 = v854
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let struct (v856 : int32, v857 : string) = null |> unbox<struct (int32 * string)>
        struct (v856, v857)
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let struct (v858 : int32, v859 : string) = null |> unbox<struct (int32 * string)>
        struct (v858, v859)
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let struct (v860 : int32, v861 : string) = null |> unbox<struct (int32 * string)>
        struct (v860, v861)
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let struct (v862 : int32, v863 : string) = null |> unbox<struct (int32 * string)>
        struct (v862, v863)
#endif
        
#if FABLE_COMPILER_PYTHON
        let struct (v864 : int32, v865 : string) = null |> unbox<struct (int32 * string)>
        struct (v864, v865)
#endif
        
#else
        let v866 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
        let struct (v867 : int32, v868 : string) = v866 v853
        struct (v867, v868)
#endif
        |> fun x -> _v854 <- Some x
        let struct (v869 : int32, v870 : string) = _v854.Value
        struct (v869, v870)
#endif
        |> fun x -> _v656 <- Some x
        let struct (v871 : int32, v872 : string) = _v656.Value
        let v873 : bool = v871 <> 0
        if v873 then
            let v874 : US0 = US0_2
            let v875 : (unit -> string) = closure55()
            let v876 : (unit -> string) = closure56(v872, v871)
            method3(v874, v875, v876)
            let v877 : (string * string) = v14, v872
            let v878 : Result<string, (string * string)> = Error v877
            US17_0(v878)
        else
            let v880 : bool option = None
            let v881 : bool = true in let mutable _v880 = v880
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v882 : string = method18(v14)
            let v883 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v884 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v882 v883
            let v885 : string = "String::from($0)"
            let v886 : std_string_String = Fable.Core.RustInterop.emitRustExpr v884 v885
            let v887 : string = "std::path::PathBuf::from($0)"
            let v888 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v886 v887
            let v889 : string = "$0.exists()"
            let v890 : bool = Fable.Core.RustInterop.emitRustExpr v888 v889
            let v893 : bool =
                if v890 then
                    let v891 : string = "$0.is_file()"
                    let v892 : bool = Fable.Core.RustInterop.emitRustExpr v888 v891
                    v892
                else
                    false
            v893
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v894 : bool = null |> unbox<bool>
            v894
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v895 : bool = null |> unbox<bool>
            v895
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v896 : IFsExistsSync = Fable.Core.JsInterop.importAll v40
            let v897 : string = "v896.existsSync($0)"
            let v898 : bool = Fable.Core.JsInterop.emitJsExpr v14 v897
            v898
#endif
            
#if FABLE_COMPILER_PYTHON
            let v899 : bool = null |> unbox<bool>
            v899
#endif
            
#else
            let v900 : (string -> bool) = System.IO.File.Exists
            let v901 : bool = v900 v14
            v901
#endif
            |> fun x -> _v880 <- Some x
            let v902 : bool = _v880.Value
            if v902 then
                let v903 : unit option = None
                let v904 : bool = true in let mutable _v903 = v903
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v905 : string = method73(v23)
                let v906 : string = "std::fs::copy(&*v14, &*v905)"
                let v907 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v906
                let v908 : string = "$0.unwrap()"
                let v909 : uint64 = Fable.Core.RustInterop.emitRustExpr v907 v908
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
                |> fun x -> _v903 <- Some x
                _v903.Value
                ()
            let v910 : Result<string, (string * string)> = Ok v14
            US17_0(v910)
    else
        US17_1
and closure58 () () : string =
    let v0 : string = "documents.run / par_map / crowbook"
    v0
and closure59 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: %A{v1} / result: {v0} / {v2 ()}"
    v3
and closure57 (v0 : string, v1 : string, v2 : string) (v3 : string) : US17 =
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
    let v589 : bool =
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
            let v112 : string = $"pwsh -c \"(Get-FileHash \\\"{v107}\\\" -Algorithm SHA256).Hash\""
            let v113 : struct (int32 * string) option = None
            let v114 : bool = true in let mutable _v113 = v113
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v115 : string = method42(v109, v112, v110, v111, v108)
            let struct (v116 : string, v117 : string) = method43()
            let v118 : int32 = v115.Length
            let v119 : (char []) = Array.zeroCreate<char> (v118)
            let v120 : Mut5 = {l0 = 0} : Mut5
            while method30(v118, v120) do
                let v122 : int32 = v120.l0
                let v123 : char = v115.[int v122]
                v119.[int v122] <- v123
                let v124 : int32 = v122 + 1
                v120.l0 <- v124
                ()
            let v125 : ((char []) -> char list) = Array.toList
            let v126 : char list = v125 v119
            let v127 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v128 : (char -> (UH0 -> UH0)) = method44()
            let v129 : (char list -> (UH0 -> UH0)) = v127 v128
            let v130 : (UH0 -> UH0) = v129 v126
            let v131 : UH0 = UH0_0
            let v132 : UH0 = v130 v131
            let v133 : US8 = US8_0
            let struct (v134 : string, v135 : string) = method45(v117, v116, v132, v133)
            let v136 : (string []) = method46(v135)
            let v137 : string = "$0.to_vec()"
            let v138 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v136 v137
            let v139 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v140 : (string -> std_string_String) = closure28()
            let v141 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v138, v140) v139
            let v142 : US0 = US0_1
            let v143 : (unit -> string) = closure29(v109, v112, v110, v111, v108, v134, v141)
            let v144 : (unit -> string) = method51()
            method3(v142, v143, v144)
            let v145 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method52(v109, v112, v110, v111, v108, v134, v141)
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
            let struct (v173 : string, v174 : string) = method43()
            let v175 : int32 = v112.Length
            let v176 : (char []) = Array.zeroCreate<char> (v175)
            let v177 : Mut5 = {l0 = 0} : Mut5
            while method30(v175, v177) do
                let v179 : int32 = v177.l0
                let v180 : char = v112.[int v179]
                v176.[int v179] <- v180
                let v181 : int32 = v179 + 1
                v177.l0 <- v181
                ()
            let v182 : ((char []) -> char list) = Array.toList
            let v183 : char list = v182 v176
            let v184 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v185 : (char -> (UH0 -> UH0)) = method44()
            let v186 : (char list -> (UH0 -> UH0)) = v184 v185
            let v187 : (UH0 -> UH0) = v186 v183
            let v188 : UH0 = UH0_0
            let v189 : UH0 = v187 v188
            let v190 : US8 = US8_0
            let struct (v191 : string, v192 : string) = method45(v174, v173, v189, v190)
            let v193 : (string -> US4) = method22()
            let v194 : US4 = US4_1
            let v195 : US4 = v108 |> Option.map v193 |> Option.defaultValue v194 
            let v199 : string =
                match v195 with
                | US4_1 -> (* None *)
                    let v197 : string = ""
                    v197
                | US4_0(v196) -> (* Some *)
                    v196
            let v200 : US0 = US0_1
            let v201 : (unit -> string) = closure45(v109, v112, v110, v111, v108)
            let v202 : (unit -> string) = method51()
            method3(v200, v201, v202)
            let v203 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v204 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v192, StandardOutputEncoding = v203, WorkingDirectory = v199, FileName = v191, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v205 : int32 = v110.Length
            let v206 : Mut5 = {l0 = 0} : Mut5
            while method30(v205, v206) do
                let v208 : int32 = v206.l0
                let struct (v209 : string, v210 : string) = v110.[int v208]
                v204.EnvironmentVariables.[v209] <- v210 
                let v211 : int32 = v208 + 1
                v206.l0 <- v211
                ()
            let v212 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v204)
            use v212 = v212 
            let v213 : System.Diagnostics.Process = v212 
            let v214 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v215 : System.Collections.Concurrent.ConcurrentStack<string> = v214 ()
            let v216 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure46(v109, v112, v110, v111, v108, v213, v215)
            v213.OutputDataReceived.Add v216 
            let v217 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v109, v112, v110, v111, v108, v213, v215)
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
            let v224 : (System.Threading.CancellationToken -> US16) = method71()
            let v225 : US16 = US16_1
            let v226 : US16 = v109 |> Option.map v224 |> Option.defaultValue v225 
            let v230 : System.Threading.CancellationToken =
                match v226 with
                | US16_1 -> (* None *)
                    let v228 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v228
                | US16_0(v227) -> (* Some *)
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
            let v258 : (unit -> unit) = closure51(v213)
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
            let v294 : (unit -> string) = closure52(v292)
            let v295 : (unit -> string) = method51()
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
            let v301 : string = method72()
            let v302 : (string -> (string seq -> string)) = String.concat
            let v303 : (string seq -> string) = v302 v301
            let v304 : string = v303 v300
            let v305 : US0 = US0_1
            let v306 : (unit -> string) = closure53(v298, v304)
            let v307 : (unit -> string) = method51()
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
                    v22
                else
                    let v343 : string option = None
                    let v344 : bool = true in let mutable _v343 = v343
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v345 : string = method26()
                    let v346 : string = method27(v22)
                    let v347 : string = method28()
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
                    let v360 : string = System.Text.RegularExpressions.Regex.Replace (v22, v358, v359)
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
            let v371 : string = $"pwsh -c \"(Get-FileHash \\\"{v366}\\\" -Algorithm SHA256).Hash\""
            let v372 : struct (int32 * string) option = None
            let v373 : bool = true in let mutable _v372 = v372
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v374 : string = method42(v368, v371, v369, v370, v367)
            let struct (v375 : string, v376 : string) = method43()
            let v377 : int32 = v374.Length
            let v378 : (char []) = Array.zeroCreate<char> (v377)
            let v379 : Mut5 = {l0 = 0} : Mut5
            while method30(v377, v379) do
                let v381 : int32 = v379.l0
                let v382 : char = v374.[int v381]
                v378.[int v381] <- v382
                let v383 : int32 = v381 + 1
                v379.l0 <- v383
                ()
            let v384 : ((char []) -> char list) = Array.toList
            let v385 : char list = v384 v378
            let v386 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v387 : (char -> (UH0 -> UH0)) = method44()
            let v388 : (char list -> (UH0 -> UH0)) = v386 v387
            let v389 : (UH0 -> UH0) = v388 v385
            let v390 : UH0 = UH0_0
            let v391 : UH0 = v389 v390
            let v392 : US8 = US8_0
            let struct (v393 : string, v394 : string) = method45(v376, v375, v391, v392)
            let v395 : (string []) = method46(v394)
            let v396 : string = "$0.to_vec()"
            let v397 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v395 v396
            let v398 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v399 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v397, v140) v398
            let v400 : US0 = US0_1
            let v401 : (unit -> string) = closure29(v368, v371, v369, v370, v367, v393, v399)
            let v402 : (unit -> string) = method51()
            method3(v400, v401, v402)
            let v403 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method52(v368, v371, v369, v370, v367, v393, v399)
            let v404 : string = "futures_lite::future::block_on($0)"
            let v405 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v403 v404
            let (a, b) = v405
            let v406 : int32 = a
            let v407 : string = b
            struct (v406, v407)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v408 : int32, v409 : string) = null |> unbox<struct (int32 * string)>
            struct (v408, v409)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v410 : int32, v411 : string) = null |> unbox<struct (int32 * string)>
            struct (v410, v411)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v412 : int32, v413 : string) = null |> unbox<struct (int32 * string)>
            struct (v412, v413)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v414 : int32, v415 : string) = null |> unbox<struct (int32 * string)>
            struct (v414, v415)
#endif
            
#else
            let v416 : Async<struct (int32 * string)> option = None
            let v417 : bool = true in let mutable _v416 = v416
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v418 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v418
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v419 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v419
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v420 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v420
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v421 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v421
#endif
            
#if FABLE_COMPILER_PYTHON
            let v422 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v422
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
            let mutable _v430 = v430
            async {
            let struct (v431 : string, v432 : string) = method43()
            let v433 : int32 = v371.Length
            let v434 : (char []) = Array.zeroCreate<char> (v433)
            let v435 : Mut5 = {l0 = 0} : Mut5
            while method30(v433, v435) do
                let v437 : int32 = v435.l0
                let v438 : char = v371.[int v437]
                v434.[int v437] <- v438
                let v439 : int32 = v437 + 1
                v435.l0 <- v439
                ()
            let v440 : ((char []) -> char list) = Array.toList
            let v441 : char list = v440 v434
            let v442 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v443 : (char -> (UH0 -> UH0)) = method44()
            let v444 : (char list -> (UH0 -> UH0)) = v442 v443
            let v445 : (UH0 -> UH0) = v444 v441
            let v446 : UH0 = UH0_0
            let v447 : UH0 = v445 v446
            let v448 : US8 = US8_0
            let struct (v449 : string, v450 : string) = method45(v432, v431, v447, v448)
            let v451 : (string -> US4) = method22()
            let v452 : US4 = US4_1
            let v453 : US4 = v367 |> Option.map v451 |> Option.defaultValue v452 
            let v457 : string =
                match v453 with
                | US4_1 -> (* None *)
                    let v455 : string = ""
                    v455
                | US4_0(v454) -> (* Some *)
                    v454
            let v458 : US0 = US0_1
            let v459 : (unit -> string) = closure45(v368, v371, v369, v370, v367)
            let v460 : (unit -> string) = method51()
            method3(v458, v459, v460)
            let v461 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v462 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v450, StandardOutputEncoding = v461, WorkingDirectory = v457, FileName = v449, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v463 : int32 = v369.Length
            let v464 : Mut5 = {l0 = 0} : Mut5
            while method30(v463, v464) do
                let v466 : int32 = v464.l0
                let struct (v467 : string, v468 : string) = v369.[int v466]
                v462.EnvironmentVariables.[v467] <- v468 
                let v469 : int32 = v466 + 1
                v464.l0 <- v469
                ()
            let v470 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v462)
            use v470 = v470 
            let v471 : System.Diagnostics.Process = v470 
            let v472 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v473 : System.Collections.Concurrent.ConcurrentStack<string> = v472 ()
            let v474 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure46(v368, v371, v369, v370, v367, v471, v473)
            v471.OutputDataReceived.Add v474 
            let v475 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v368, v371, v369, v370, v367, v471, v473)
            v471.ErrorDataReceived.Add v475 
            let v476 : (unit -> bool) = v471.Start
            let v477 : bool = v476 ()
            let v478 : bool = v477 = false
            if v478 then
                let v479 : string = $"execute_with_options_async / process_start error"
                failwith<unit> v479
            let v480 : (unit -> unit) = v471.BeginErrorReadLine
            v480 ()
            let v481 : (unit -> unit) = v471.BeginOutputReadLine
            v481 ()
            let v482 : (System.Threading.CancellationToken -> US16) = method71()
            let v483 : US16 = US16_1
            let v484 : US16 = v368 |> Option.map v482 |> Option.defaultValue v483 
            let v488 : System.Threading.CancellationToken =
                match v484 with
                | US16_1 -> (* None *)
                    let v486 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v486
                | US16_0(v485) -> (* Some *)
                    v485
            let v489 : Async<System.Threading.CancellationToken> option = None
            let v490 : bool = true in let mutable _v489 = v489
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v491 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v491
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v492 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v492
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v493 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v493
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v494 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v494
#endif
            
#if FABLE_COMPILER_PYTHON
            let v495 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v495
#endif
            
#else
            let v496 : Async<System.Threading.CancellationToken> option = None
            let v497 : bool = true in let mutable _v496 = v496
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v498 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v498
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v499 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v499
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v500 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v500
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v501 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v501
#endif
            
#if FABLE_COMPILER_PYTHON
            let v502 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v502
#endif
            
#else
            let v503 : Async<System.Threading.CancellationToken> option = None
            let mutable _v503 = v503
            async {
            let v504 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v504 = v504 
            let v505 : System.Threading.CancellationToken = v504 
            let v506 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v507 : (System.Threading.CancellationToken []) = [|v505; v506; v488|]
            let v508 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v509 : System.Threading.CancellationTokenSource = v508 v507
            let v510 : System.Threading.CancellationToken = v509.Token
            return v510 
            }
            |> fun x -> _v503 <- Some x
            let v511 : Async<System.Threading.CancellationToken> = _v503 |> Option.get
            v511
#endif
            |> fun x -> _v496 <- Some x
            let v512 : Async<System.Threading.CancellationToken> = _v496.Value
            v512
#endif
            |> fun x -> _v489 <- Some x
            let v513 : Async<System.Threading.CancellationToken> = _v489.Value
            let! v513 = v513 
            let v514 : System.Threading.CancellationToken = v513 
            let v515 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v514.Register
            let v516 : (unit -> unit) = closure51(v471)
            let v517 : System.Threading.CancellationTokenRegistration = v515 v516
            use v517 = v517 
            let v518 : System.Threading.CancellationTokenRegistration = v517 
            let v519 : Async<int32> option = None
            let v520 : bool = true in let mutable _v519 = v519
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v521 : Async<int32> = null |> unbox<Async<int32>>
            v521
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v522 : Async<int32> = null |> unbox<Async<int32>>
            v522
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v523 : Async<int32> = null |> unbox<Async<int32>>
            v523
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v524 : Async<int32> = null |> unbox<Async<int32>>
            v524
#endif
            
#if FABLE_COMPILER_PYTHON
            let v525 : Async<int32> = null |> unbox<Async<int32>>
            v525
#endif
            
#else
            let v526 : Async<int32> option = None
            let mutable _v526 = v526
            async {
            try
            let v527 : System.Threading.Tasks.Task = v471.WaitForExitAsync v514 
            let v528 : Async<unit> option = None
            let v529 : bool = true in let mutable _v528 = v528
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v530 : Async<unit> = null |> unbox<Async<unit>>
            v530
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v531 : Async<unit> = null |> unbox<Async<unit>>
            v531
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v532 : Async<unit> = null |> unbox<Async<unit>>
            v532
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v533 : Async<unit> = null |> unbox<Async<unit>>
            v533
#endif
            
#if FABLE_COMPILER_PYTHON
            let v534 : Async<unit> = null |> unbox<Async<unit>>
            v534
#endif
            
#else
            let v535 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v536 : Async<unit> = v535 v527
            v536
#endif
            |> fun x -> _v528 <- Some x
            let v537 : Async<unit> = _v528.Value
            do! v537 
            let v538 : int32 = v471.ExitCode
            return v538 
            with ex ->
            let v539 : exn = ex
            let v540 : string option = None
            let v541 : bool = true in let mutable _v540 = v540
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v542 : string = $"%A{v539}"
            v542
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v543 : string = $"%A{v539}"
            v543
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v544 : string = $"%A{v539}"
            v544
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v545 : string = $"%A{v539}"
            v545
#endif
            
#if FABLE_COMPILER_PYTHON
            let v546 : string = $"%A{v539}"
            v546
#endif
            
#else
            let v547 : string = $"{v539.GetType ()}: {v539.Message}"
            v547
#endif
            |> fun x -> _v540 <- Some x
            let v548 : string = _v540.Value
            let v549 : (string -> unit) = v473.Push
            v549 v548
            let v550 : System.Threading.Tasks.TaskCanceledException = v539 |> unbox<System.Threading.Tasks.TaskCanceledException>
            let v551 : US0 = US0_3
            let v552 : (unit -> string) = closure52(v550)
            let v553 : (unit -> string) = method51()
            method3(v551, v552, v553)
            return -2147483648 
            (*
            *)
            }
            |> fun x -> _v526 <- Some x
            let v554 : Async<int32> = _v526 |> Option.get
            v554
#endif
            |> fun x -> _v519 <- Some x
            let v555 : Async<int32> = _v519.Value
            let! v555 = v555 
            let v556 : int32 = v555 
            let v557 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v558 : string seq = v557 v473
            let v559 : string = method72()
            let v560 : (string -> (string seq -> string)) = String.concat
            let v561 : (string seq -> string) = v560 v559
            let v562 : string = v561 v558
            let v563 : US0 = US0_1
            let v564 : (unit -> string) = closure53(v556, v562)
            let v565 : (unit -> string) = method51()
            method3(v563, v564, v565)
            return struct (v556, v562) 
            }
            |> fun x -> _v430 <- Some x
            let v566 : Async<struct (int32 * string)> = _v430 |> Option.get
            v566
#endif
            |> fun x -> _v423 <- Some x
            let v567 : Async<struct (int32 * string)> = _v423.Value
            v567
#endif
            |> fun x -> _v416 <- Some x
            let v568 : Async<struct (int32 * string)> = _v416.Value
            let v569 : struct (int32 * string) option = None
            let v570 : bool = true in let mutable _v569 = v569
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v571 : int32, v572 : string) = null |> unbox<struct (int32 * string)>
            struct (v571, v572)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v573 : int32, v574 : string) = null |> unbox<struct (int32 * string)>
            struct (v573, v574)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v575 : int32, v576 : string) = null |> unbox<struct (int32 * string)>
            struct (v575, v576)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v577 : int32, v578 : string) = null |> unbox<struct (int32 * string)>
            struct (v577, v578)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v579 : int32, v580 : string) = null |> unbox<struct (int32 * string)>
            struct (v579, v580)
#endif
            
#else
            let v581 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
            let struct (v582 : int32, v583 : string) = v581 v568
            struct (v582, v583)
#endif
            |> fun x -> _v569 <- Some x
            let struct (v584 : int32, v585 : string) = _v569.Value
            struct (v584, v585)
#endif
            |> fun x -> _v372 <- Some x
            let struct (v586 : int32, v587 : string) = _v372.Value
            let v588 : bool = v329 = v587
            v588
        else
            false
    let v590 : bool = v589 = false
    if v590 then
        let v591 : string = $"crowbook --single \"{v0}\" --output \"{v13}\" --to {v3} --set rendering.num_depth 6 html.css.add \\\"''' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} '''\\\""
        let v592 : string option = None
        let v593 : System.Threading.CancellationToken option = None
        let v594 : (struct (string * string) []) = [||]
        let v595 : (struct (bool * string * int32) -> Async<unit>) option = None
        let v596 : string option = Some v2 
        let v597 : struct (int32 * string) option = None
        let v598 : bool = true in let mutable _v597 = v597
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v599 : string = method42(v593, v591, v594, v595, v596)
        let struct (v600 : string, v601 : string) = method43()
        let v602 : int32 = v599.Length
        let v603 : (char []) = Array.zeroCreate<char> (v602)
        let v604 : Mut5 = {l0 = 0} : Mut5
        while method30(v602, v604) do
            let v606 : int32 = v604.l0
            let v607 : char = v599.[int v606]
            v603.[int v606] <- v607
            let v608 : int32 = v606 + 1
            v604.l0 <- v608
            ()
        let v609 : ((char []) -> char list) = Array.toList
        let v610 : char list = v609 v603
        let v611 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
        let v612 : (char -> (UH0 -> UH0)) = method44()
        let v613 : (char list -> (UH0 -> UH0)) = v611 v612
        let v614 : (UH0 -> UH0) = v613 v610
        let v615 : UH0 = UH0_0
        let v616 : UH0 = v614 v615
        let v617 : US8 = US8_0
        let struct (v618 : string, v619 : string) = method45(v601, v600, v616, v617)
        let v620 : (string []) = method46(v619)
        let v621 : string = "$0.to_vec()"
        let v622 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v620 v621
        let v623 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
        let v624 : (string -> std_string_String) = closure28()
        let v625 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v622, v624) v623
        let v626 : US0 = US0_1
        let v627 : (unit -> string) = closure29(v593, v591, v594, v595, v596, v618, v625)
        let v628 : (unit -> string) = method51()
        method3(v626, v627, v628)
        let v629 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method52(v593, v591, v594, v595, v596, v618, v625)
        let v630 : string = "futures_lite::future::block_on($0)"
        let v631 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v629 v630
        let (a, b) = v631
        let v632 : int32 = a
        let v633 : string = b
        struct (v632, v633)
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let struct (v634 : int32, v635 : string) = null |> unbox<struct (int32 * string)>
        struct (v634, v635)
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let struct (v636 : int32, v637 : string) = null |> unbox<struct (int32 * string)>
        struct (v636, v637)
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let struct (v638 : int32, v639 : string) = null |> unbox<struct (int32 * string)>
        struct (v638, v639)
#endif
        
#if FABLE_COMPILER_PYTHON
        let struct (v640 : int32, v641 : string) = null |> unbox<struct (int32 * string)>
        struct (v640, v641)
#endif
        
#else
        let v642 : Async<struct (int32 * string)> option = None
        let v643 : bool = true in let mutable _v642 = v642
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v644 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v644
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v645 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v645
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v646 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v646
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v647 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v647
#endif
        
#if FABLE_COMPILER_PYTHON
        let v648 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v648
#endif
        
#else
        let v649 : Async<struct (int32 * string)> option = None
        let v650 : bool = true in let mutable _v649 = v649
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v651 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v651
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v652 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v652
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v653 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v653
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v654 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v654
#endif
        
#if FABLE_COMPILER_PYTHON
        let v655 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
        v655
#endif
        
#else
        let v656 : Async<struct (int32 * string)> option = None
        let mutable _v656 = v656
        async {
        let struct (v657 : string, v658 : string) = method43()
        let v659 : int32 = v591.Length
        let v660 : (char []) = Array.zeroCreate<char> (v659)
        let v661 : Mut5 = {l0 = 0} : Mut5
        while method30(v659, v661) do
            let v663 : int32 = v661.l0
            let v664 : char = v591.[int v663]
            v660.[int v663] <- v664
            let v665 : int32 = v663 + 1
            v661.l0 <- v665
            ()
        let v666 : ((char []) -> char list) = Array.toList
        let v667 : char list = v666 v660
        let v668 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
        let v669 : (char -> (UH0 -> UH0)) = method44()
        let v670 : (char list -> (UH0 -> UH0)) = v668 v669
        let v671 : (UH0 -> UH0) = v670 v667
        let v672 : UH0 = UH0_0
        let v673 : UH0 = v671 v672
        let v674 : US8 = US8_0
        let struct (v675 : string, v676 : string) = method45(v658, v657, v673, v674)
        let v677 : (string -> US4) = method22()
        let v678 : US4 = US4_1
        let v679 : US4 = v596 |> Option.map v677 |> Option.defaultValue v678 
        let v683 : string =
            match v679 with
            | US4_1 -> (* None *)
                let v681 : string = ""
                v681
            | US4_0(v680) -> (* Some *)
                v680
        let v684 : US0 = US0_1
        let v685 : (unit -> string) = closure45(v593, v591, v594, v595, v596)
        let v686 : (unit -> string) = method51()
        method3(v684, v685, v686)
        let v687 : System.Text.Encoding = System.Text.Encoding.UTF8
        let v688 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v676, StandardOutputEncoding = v687, WorkingDirectory = v683, FileName = v675, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
        let v689 : int32 = v594.Length
        let v690 : Mut5 = {l0 = 0} : Mut5
        while method30(v689, v690) do
            let v692 : int32 = v690.l0
            let struct (v693 : string, v694 : string) = v594.[int v692]
            v688.EnvironmentVariables.[v693] <- v694 
            let v695 : int32 = v692 + 1
            v690.l0 <- v695
            ()
        let v696 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v688)
        use v696 = v696 
        let v697 : System.Diagnostics.Process = v696 
        let v698 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
        let v699 : System.Collections.Concurrent.ConcurrentStack<string> = v698 ()
        let v700 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure46(v593, v591, v594, v595, v596, v697, v699)
        v697.OutputDataReceived.Add v700 
        let v701 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v593, v591, v594, v595, v596, v697, v699)
        v697.ErrorDataReceived.Add v701 
        let v702 : (unit -> bool) = v697.Start
        let v703 : bool = v702 ()
        let v704 : bool = v703 = false
        if v704 then
            let v705 : string = $"execute_with_options_async / process_start error"
            failwith<unit> v705
        let v706 : (unit -> unit) = v697.BeginErrorReadLine
        v706 ()
        let v707 : (unit -> unit) = v697.BeginOutputReadLine
        v707 ()
        let v708 : (System.Threading.CancellationToken -> US16) = method71()
        let v709 : US16 = US16_1
        let v710 : US16 = v593 |> Option.map v708 |> Option.defaultValue v709 
        let v714 : System.Threading.CancellationToken =
            match v710 with
            | US16_1 -> (* None *)
                let v712 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                v712
            | US16_0(v711) -> (* Some *)
                v711
        let v715 : Async<System.Threading.CancellationToken> option = None
        let v716 : bool = true in let mutable _v715 = v715
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v717 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v717
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v718 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v718
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v719 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v719
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v720 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v720
#endif
        
#if FABLE_COMPILER_PYTHON
        let v721 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v721
#endif
        
#else
        let v722 : Async<System.Threading.CancellationToken> option = None
        let v723 : bool = true in let mutable _v722 = v722
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v724 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v724
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v725 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v725
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v726 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v726
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v727 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v727
#endif
        
#if FABLE_COMPILER_PYTHON
        let v728 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
        v728
#endif
        
#else
        let v729 : Async<System.Threading.CancellationToken> option = None
        let mutable _v729 = v729
        async {
        let v730 : Async<System.Threading.CancellationToken> = Async.CancellationToken
        let! v730 = v730 
        let v731 : System.Threading.CancellationToken = v730 
        let v732 : System.Threading.CancellationToken = Async.DefaultCancellationToken
        let v733 : (System.Threading.CancellationToken []) = [|v731; v732; v714|]
        let v734 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
        let v735 : System.Threading.CancellationTokenSource = v734 v733
        let v736 : System.Threading.CancellationToken = v735.Token
        return v736 
        }
        |> fun x -> _v729 <- Some x
        let v737 : Async<System.Threading.CancellationToken> = _v729 |> Option.get
        v737
#endif
        |> fun x -> _v722 <- Some x
        let v738 : Async<System.Threading.CancellationToken> = _v722.Value
        v738
#endif
        |> fun x -> _v715 <- Some x
        let v739 : Async<System.Threading.CancellationToken> = _v715.Value
        let! v739 = v739 
        let v740 : System.Threading.CancellationToken = v739 
        let v741 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v740.Register
        let v742 : (unit -> unit) = closure51(v697)
        let v743 : System.Threading.CancellationTokenRegistration = v741 v742
        use v743 = v743 
        let v744 : System.Threading.CancellationTokenRegistration = v743 
        let v745 : Async<int32> option = None
        let v746 : bool = true in let mutable _v745 = v745
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v747 : Async<int32> = null |> unbox<Async<int32>>
        v747
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v748 : Async<int32> = null |> unbox<Async<int32>>
        v748
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v749 : Async<int32> = null |> unbox<Async<int32>>
        v749
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v750 : Async<int32> = null |> unbox<Async<int32>>
        v750
#endif
        
#if FABLE_COMPILER_PYTHON
        let v751 : Async<int32> = null |> unbox<Async<int32>>
        v751
#endif
        
#else
        let v752 : Async<int32> option = None
        let mutable _v752 = v752
        async {
        try
        let v753 : System.Threading.Tasks.Task = v697.WaitForExitAsync v740 
        let v754 : Async<unit> option = None
        let v755 : bool = true in let mutable _v754 = v754
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v756 : Async<unit> = null |> unbox<Async<unit>>
        v756
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v757 : Async<unit> = null |> unbox<Async<unit>>
        v757
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v758 : Async<unit> = null |> unbox<Async<unit>>
        v758
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v759 : Async<unit> = null |> unbox<Async<unit>>
        v759
#endif
        
#if FABLE_COMPILER_PYTHON
        let v760 : Async<unit> = null |> unbox<Async<unit>>
        v760
#endif
        
#else
        let v761 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
        let v762 : Async<unit> = v761 v753
        v762
#endif
        |> fun x -> _v754 <- Some x
        let v763 : Async<unit> = _v754.Value
        do! v763 
        let v764 : int32 = v697.ExitCode
        return v764 
        with ex ->
        let v765 : exn = ex
        let v766 : string option = None
        let v767 : bool = true in let mutable _v766 = v766
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v768 : string = $"%A{v765}"
        v768
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v769 : string = $"%A{v765}"
        v769
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v770 : string = $"%A{v765}"
        v770
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let v771 : string = $"%A{v765}"
        v771
#endif
        
#if FABLE_COMPILER_PYTHON
        let v772 : string = $"%A{v765}"
        v772
#endif
        
#else
        let v773 : string = $"{v765.GetType ()}: {v765.Message}"
        v773
#endif
        |> fun x -> _v766 <- Some x
        let v774 : string = _v766.Value
        let v775 : (string -> unit) = v699.Push
        v775 v774
        let v776 : System.Threading.Tasks.TaskCanceledException = v765 |> unbox<System.Threading.Tasks.TaskCanceledException>
        let v777 : US0 = US0_3
        let v778 : (unit -> string) = closure52(v776)
        let v779 : (unit -> string) = method51()
        method3(v777, v778, v779)
        return -2147483648 
        (*
        *)
        }
        |> fun x -> _v752 <- Some x
        let v780 : Async<int32> = _v752 |> Option.get
        v780
#endif
        |> fun x -> _v745 <- Some x
        let v781 : Async<int32> = _v745.Value
        let! v781 = v781 
        let v782 : int32 = v781 
        let v783 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
        let v784 : string seq = v783 v699
        let v785 : string = method72()
        let v786 : (string -> (string seq -> string)) = String.concat
        let v787 : (string seq -> string) = v786 v785
        let v788 : string = v787 v784
        let v789 : US0 = US0_1
        let v790 : (unit -> string) = closure53(v782, v788)
        let v791 : (unit -> string) = method51()
        method3(v789, v790, v791)
        return struct (v782, v788) 
        }
        |> fun x -> _v656 <- Some x
        let v792 : Async<struct (int32 * string)> = _v656 |> Option.get
        v792
#endif
        |> fun x -> _v649 <- Some x
        let v793 : Async<struct (int32 * string)> = _v649.Value
        v793
#endif
        |> fun x -> _v642 <- Some x
        let v794 : Async<struct (int32 * string)> = _v642.Value
        let v795 : struct (int32 * string) option = None
        let v796 : bool = true in let mutable _v795 = v795
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let struct (v797 : int32, v798 : string) = null |> unbox<struct (int32 * string)>
        struct (v797, v798)
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let struct (v799 : int32, v800 : string) = null |> unbox<struct (int32 * string)>
        struct (v799, v800)
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let struct (v801 : int32, v802 : string) = null |> unbox<struct (int32 * string)>
        struct (v801, v802)
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        let struct (v803 : int32, v804 : string) = null |> unbox<struct (int32 * string)>
        struct (v803, v804)
#endif
        
#if FABLE_COMPILER_PYTHON
        let struct (v805 : int32, v806 : string) = null |> unbox<struct (int32 * string)>
        struct (v805, v806)
#endif
        
#else
        let v807 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
        let struct (v808 : int32, v809 : string) = v807 v794
        struct (v808, v809)
#endif
        |> fun x -> _v795 <- Some x
        let struct (v810 : int32, v811 : string) = _v795.Value
        struct (v810, v811)
#endif
        |> fun x -> _v597 <- Some x
        let struct (v812 : int32, v813 : string) = _v597.Value
        let v814 : string = "ERROR"
        let v815 : bool = v813.Contains v814
        let v821 : US18 =
            if v815 then
                let v816 : US0 = US0_2
                let v817 : (unit -> string) = closure58()
                let v818 : (unit -> string) = closure59(v813, v812)
                method3(v816, v817, v818)
                US18_1(v812, v813)
            else
                US18_0(v812, v813)
        match v821 with
        | US18_0(v822, v823) -> (* Ok *)
            let v824 : bool = v822 <> 0
            if v824 then
                let v825 : US0 = US0_2
                let v826 : (unit -> string) = closure55()
                let v827 : (unit -> string) = closure56(v823, v822)
                method3(v825, v826, v827)
                let v828 : (string * string) = v13, v823
                let v829 : Result<string, (string * string)> = Error v828
                US17_0(v829)
            else
                let v831 : bool option = None
                let v832 : bool = true in let mutable _v831 = v831
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v833 : string = method18(v13)
                let v834 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                let v835 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v833 v834
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
                let v847 : IFsExistsSync = Fable.Core.JsInterop.importAll v39
                let v848 : string = "v847.existsSync($0)"
                let v849 : bool = Fable.Core.JsInterop.emitJsExpr v13 v848
                v849
#endif
                
#if FABLE_COMPILER_PYTHON
                let v850 : bool = null |> unbox<bool>
                v850
#endif
                
#else
                let v851 : (string -> bool) = System.IO.File.Exists
                let v852 : bool = v851 v13
                v852
#endif
                |> fun x -> _v831 <- Some x
                let v853 : bool = _v831.Value
                if v853 then
                    let v854 : unit option = None
                    let v855 : bool = true in let mutable _v854 = v854
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v856 : string = method73(v22)
                    let v857 : string = "std::fs::copy(&*v13, &*v856)"
                    let v858 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v857
                    let v859 : string = "$0.unwrap()"
                    let v860 : uint64 = Fable.Core.RustInterop.emitRustExpr v858 v859
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
                    |> fun x -> _v854 <- Some x
                    _v854.Value
                    ()
                let v861 : Result<string, (string * string)> = Ok v13
                US17_0(v861)
        | _ ->
            let v864 : bool option = None
            let v865 : bool = true in let mutable _v864 = v864
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v866 : string = method18(v13)
            let v867 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v868 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v866 v867
            let v869 : string = "String::from($0)"
            let v870 : std_string_String = Fable.Core.RustInterop.emitRustExpr v868 v869
            let v871 : string = "std::path::PathBuf::from($0)"
            let v872 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v870 v871
            let v873 : string = "$0.exists()"
            let v874 : bool = Fable.Core.RustInterop.emitRustExpr v872 v873
            let v877 : bool =
                if v874 then
                    let v875 : string = "$0.is_file()"
                    let v876 : bool = Fable.Core.RustInterop.emitRustExpr v872 v875
                    v876
                else
                    false
            v877
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v878 : bool = null |> unbox<bool>
            v878
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v879 : bool = null |> unbox<bool>
            v879
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v880 : IFsExistsSync = Fable.Core.JsInterop.importAll v39
            let v881 : string = "v880.existsSync($0)"
            let v882 : bool = Fable.Core.JsInterop.emitJsExpr v13 v881
            v882
#endif
            
#if FABLE_COMPILER_PYTHON
            let v883 : bool = null |> unbox<bool>
            v883
#endif
            
#else
            let v884 : (string -> bool) = System.IO.File.Exists
            let v885 : bool = v884 v13
            v885
#endif
            |> fun x -> _v864 <- Some x
            let v886 : bool = _v864.Value
            if v886 then
                let v887 : unit option = None
                let v888 : bool = true in let mutable _v887 = v887
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v889 : string = method73(v22)
                let v890 : string = "std::fs::copy(&*v13, &*v889)"
                let v891 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v890
                let v892 : string = "$0.unwrap()"
                let v893 : uint64 = Fable.Core.RustInterop.emitRustExpr v891 v892
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
                |> fun x -> _v887 <- Some x
                _v887.Value
                ()
            let v894 : Result<string, (string * string)> = Ok v13
            US17_0(v894)
    else
        US17_1
and closure60 () struct (v0 : string, v1 : (string -> US17)) : Result<string, (string * string)> option =
    let v2 : US17 = v1 v0
    match v2 with
    | US17_1 -> (* None *)
        let v5 : Result<string, (string * string)> option = None
        v5
    | US17_0(v3) -> (* Some *)
        let v4 : Result<string, (string * string)> option = Some v3 
        v4
and closure61 () () : string =
    let v0 : string = "documents.run / par_map"
    v0
and closure62 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : int32, v5 : string, v6 : int32, v7 : string, v8 : string, v9 : Vec<Result<string, (string * string)> option>) () : string =
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
    let v375 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v370}\""
    let v376 : string option = Some v2 
    let v377 : struct (int32 * string) option = None
    let v378 : bool = true in let mutable _v377 = v377
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v379 : string = method42(v372, v375, v373, v374, v376)
    let struct (v380 : string, v381 : string) = method43()
    let v382 : int32 = v379.Length
    let v383 : (char []) = Array.zeroCreate<char> (v382)
    let v384 : Mut5 = {l0 = 0} : Mut5
    while method30(v382, v384) do
        let v386 : int32 = v384.l0
        let v387 : char = v379.[int v386]
        v383.[int v386] <- v387
        let v388 : int32 = v386 + 1
        v384.l0 <- v388
        ()
    let v389 : ((char []) -> char list) = Array.toList
    let v390 : char list = v389 v383
    let v391 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v392 : (char -> (UH0 -> UH0)) = method44()
    let v393 : (char list -> (UH0 -> UH0)) = v391 v392
    let v394 : (UH0 -> UH0) = v393 v390
    let v395 : UH0 = UH0_0
    let v396 : UH0 = v394 v395
    let v397 : US8 = US8_0
    let struct (v398 : string, v399 : string) = method45(v381, v380, v396, v397)
    let v400 : (string []) = method46(v399)
    let v401 : string = "$0.to_vec()"
    let v402 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v400 v401
    let v403 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v404 : (string -> std_string_String) = closure28()
    let v405 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v402, v404) v403
    let v406 : US0 = US0_1
    let v407 : (unit -> string) = closure29(v372, v375, v373, v374, v376, v398, v405)
    let v408 : (unit -> string) = method51()
    method3(v406, v407, v408)
    let v409 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method52(v372, v375, v373, v374, v376, v398, v405)
    let v410 : string = "futures_lite::future::block_on($0)"
    let v411 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v409 v410
    let (a, b) = v411
    let v412 : int32 = a
    let v413 : string = b
    struct (v412, v413)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v414 : int32, v415 : string) = null |> unbox<struct (int32 * string)>
    struct (v414, v415)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v416 : int32, v417 : string) = null |> unbox<struct (int32 * string)>
    struct (v416, v417)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v418 : int32, v419 : string) = null |> unbox<struct (int32 * string)>
    struct (v418, v419)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v420 : int32, v421 : string) = null |> unbox<struct (int32 * string)>
    struct (v420, v421)
#endif
    
#else
    let v422 : Async<struct (int32 * string)> option = None
    let v423 : bool = true in let mutable _v422 = v422
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v424 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v424
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v425 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v425
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v426 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v426
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v427 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v427
#endif
    
#if FABLE_COMPILER_PYTHON
    let v428 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v428
#endif
    
#else
    let v429 : Async<struct (int32 * string)> option = None
    let v430 : bool = true in let mutable _v429 = v429
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v431 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v431
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v432 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v432
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v433 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v433
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v434 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v434
#endif
    
#if FABLE_COMPILER_PYTHON
    let v435 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v435
#endif
    
#else
    let v436 : Async<struct (int32 * string)> option = None
    let mutable _v436 = v436
    async {
    let struct (v437 : string, v438 : string) = method43()
    let v439 : int32 = v375.Length
    let v440 : (char []) = Array.zeroCreate<char> (v439)
    let v441 : Mut5 = {l0 = 0} : Mut5
    while method30(v439, v441) do
        let v443 : int32 = v441.l0
        let v444 : char = v375.[int v443]
        v440.[int v443] <- v444
        let v445 : int32 = v443 + 1
        v441.l0 <- v445
        ()
    let v446 : ((char []) -> char list) = Array.toList
    let v447 : char list = v446 v440
    let v448 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v449 : (char -> (UH0 -> UH0)) = method44()
    let v450 : (char list -> (UH0 -> UH0)) = v448 v449
    let v451 : (UH0 -> UH0) = v450 v447
    let v452 : UH0 = UH0_0
    let v453 : UH0 = v451 v452
    let v454 : US8 = US8_0
    let struct (v455 : string, v456 : string) = method45(v438, v437, v453, v454)
    let v457 : (string -> US4) = method22()
    let v458 : US4 = US4_1
    let v459 : US4 = v376 |> Option.map v457 |> Option.defaultValue v458 
    let v462 : string =
        match v459 with
        | US4_1 -> (* None *)
            v254
        | US4_0(v460) -> (* Some *)
            v460
    let v463 : US0 = US0_1
    let v464 : (unit -> string) = closure45(v372, v375, v373, v374, v376)
    let v465 : (unit -> string) = method51()
    method3(v463, v464, v465)
    let v466 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v467 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v456, StandardOutputEncoding = v466, WorkingDirectory = v462, FileName = v455, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v468 : int32 = v373.Length
    let v469 : Mut5 = {l0 = 0} : Mut5
    while method30(v468, v469) do
        let v471 : int32 = v469.l0
        let struct (v472 : string, v473 : string) = v373.[int v471]
        v467.EnvironmentVariables.[v472] <- v473 
        let v474 : int32 = v471 + 1
        v469.l0 <- v474
        ()
    let v475 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v467)
    use v475 = v475 
    let v476 : System.Diagnostics.Process = v475 
    let v477 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v478 : System.Collections.Concurrent.ConcurrentStack<string> = v477 ()
    let v479 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure46(v372, v375, v373, v374, v376, v476, v478)
    v476.OutputDataReceived.Add v479 
    let v480 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v372, v375, v373, v374, v376, v476, v478)
    v476.ErrorDataReceived.Add v480 
    let v481 : (unit -> bool) = v476.Start
    let v482 : bool = v481 ()
    let v483 : bool = v482 = false
    if v483 then
        let v484 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v484
    let v485 : (unit -> unit) = v476.BeginErrorReadLine
    v485 ()
    let v486 : (unit -> unit) = v476.BeginOutputReadLine
    v486 ()
    let v487 : (System.Threading.CancellationToken -> US16) = method71()
    let v488 : US16 = US16_1
    let v489 : US16 = v372 |> Option.map v487 |> Option.defaultValue v488 
    let v493 : System.Threading.CancellationToken =
        match v489 with
        | US16_1 -> (* None *)
            let v491 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v491
        | US16_0(v490) -> (* Some *)
            v490
    let v494 : Async<System.Threading.CancellationToken> option = None
    let v495 : bool = true in let mutable _v494 = v494
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v496 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v496
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v497 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v497
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v498 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v498
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v499 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v499
#endif
    
#if FABLE_COMPILER_PYTHON
    let v500 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v500
#endif
    
#else
    let v501 : Async<System.Threading.CancellationToken> option = None
    let v502 : bool = true in let mutable _v501 = v501
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v503 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v503
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v504 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v504
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v505 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v505
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v506 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v506
#endif
    
#if FABLE_COMPILER_PYTHON
    let v507 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v507
#endif
    
#else
    let v508 : Async<System.Threading.CancellationToken> option = None
    let mutable _v508 = v508
    async {
    let v509 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v509 = v509 
    let v510 : System.Threading.CancellationToken = v509 
    let v511 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v512 : (System.Threading.CancellationToken []) = [|v510; v511; v493|]
    let v513 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v514 : System.Threading.CancellationTokenSource = v513 v512
    let v515 : System.Threading.CancellationToken = v514.Token
    return v515 
    }
    |> fun x -> _v508 <- Some x
    let v516 : Async<System.Threading.CancellationToken> = _v508 |> Option.get
    v516
#endif
    |> fun x -> _v501 <- Some x
    let v517 : Async<System.Threading.CancellationToken> = _v501.Value
    v517
#endif
    |> fun x -> _v494 <- Some x
    let v518 : Async<System.Threading.CancellationToken> = _v494.Value
    let! v518 = v518 
    let v519 : System.Threading.CancellationToken = v518 
    let v520 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v519.Register
    let v521 : (unit -> unit) = closure51(v476)
    let v522 : System.Threading.CancellationTokenRegistration = v520 v521
    use v522 = v522 
    let v523 : System.Threading.CancellationTokenRegistration = v522 
    let v524 : Async<int32> option = None
    let v525 : bool = true in let mutable _v524 = v524
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v526 : Async<int32> = null |> unbox<Async<int32>>
    v526
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v527 : Async<int32> = null |> unbox<Async<int32>>
    v527
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v528 : Async<int32> = null |> unbox<Async<int32>>
    v528
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v529 : Async<int32> = null |> unbox<Async<int32>>
    v529
#endif
    
#if FABLE_COMPILER_PYTHON
    let v530 : Async<int32> = null |> unbox<Async<int32>>
    v530
#endif
    
#else
    let v531 : Async<int32> option = None
    let mutable _v531 = v531
    async {
    try
    let v532 : System.Threading.Tasks.Task = v476.WaitForExitAsync v519 
    let v533 : Async<unit> option = None
    let v534 : bool = true in let mutable _v533 = v533
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v535 : Async<unit> = null |> unbox<Async<unit>>
    v535
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v536 : Async<unit> = null |> unbox<Async<unit>>
    v536
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v537 : Async<unit> = null |> unbox<Async<unit>>
    v537
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v538 : Async<unit> = null |> unbox<Async<unit>>
    v538
#endif
    
#if FABLE_COMPILER_PYTHON
    let v539 : Async<unit> = null |> unbox<Async<unit>>
    v539
#endif
    
#else
    let v540 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v541 : Async<unit> = v540 v532
    v541
#endif
    |> fun x -> _v533 <- Some x
    let v542 : Async<unit> = _v533.Value
    do! v542 
    let v543 : int32 = v476.ExitCode
    return v543 
    with ex ->
    let v544 : exn = ex
    let v545 : string option = None
    let v546 : bool = true in let mutable _v545 = v545
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v547 : string = $"%A{v544}"
    v547
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v548 : string = $"%A{v544}"
    v548
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v549 : string = $"%A{v544}"
    v549
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v550 : string = $"%A{v544}"
    v550
#endif
    
#if FABLE_COMPILER_PYTHON
    let v551 : string = $"%A{v544}"
    v551
#endif
    
#else
    let v552 : string = $"{v544.GetType ()}: {v544.Message}"
    v552
#endif
    |> fun x -> _v545 <- Some x
    let v553 : string = _v545.Value
    let v554 : (string -> unit) = v478.Push
    v554 v553
    let v555 : System.Threading.Tasks.TaskCanceledException = v544 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v556 : US0 = US0_3
    let v557 : (unit -> string) = closure52(v555)
    let v558 : (unit -> string) = method51()
    method3(v556, v557, v558)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v531 <- Some x
    let v559 : Async<int32> = _v531 |> Option.get
    v559
#endif
    |> fun x -> _v524 <- Some x
    let v560 : Async<int32> = _v524.Value
    let! v560 = v560 
    let v561 : int32 = v560 
    let v562 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v563 : string seq = v562 v478
    let v564 : string = method72()
    let v565 : (string -> (string seq -> string)) = String.concat
    let v566 : (string seq -> string) = v565 v564
    let v567 : string = v566 v563
    let v568 : US0 = US0_1
    let v569 : (unit -> string) = closure53(v561, v567)
    let v570 : (unit -> string) = method51()
    method3(v568, v569, v570)
    return struct (v561, v567) 
    }
    |> fun x -> _v436 <- Some x
    let v571 : Async<struct (int32 * string)> = _v436 |> Option.get
    v571
#endif
    |> fun x -> _v429 <- Some x
    let v572 : Async<struct (int32 * string)> = _v429.Value
    v572
#endif
    |> fun x -> _v422 <- Some x
    let v573 : Async<struct (int32 * string)> = _v422.Value
    let v574 : struct (int32 * string) option = None
    let v575 : bool = true in let mutable _v574 = v574
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v576 : int32, v577 : string) = null |> unbox<struct (int32 * string)>
    struct (v576, v577)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v578 : int32, v579 : string) = null |> unbox<struct (int32 * string)>
    struct (v578, v579)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v580 : int32, v581 : string) = null |> unbox<struct (int32 * string)>
    struct (v580, v581)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v582 : int32, v583 : string) = null |> unbox<struct (int32 * string)>
    struct (v582, v583)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v584 : int32, v585 : string) = null |> unbox<struct (int32 * string)>
    struct (v584, v585)
#endif
    
#else
    let v586 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v587 : int32, v588 : string) = v586 v573
    struct (v587, v588)
#endif
    |> fun x -> _v574 <- Some x
    let struct (v589 : int32, v590 : string) = _v574.Value
    struct (v589, v590)
#endif
    |> fun x -> _v377 <- Some x
    let struct (v591 : int32, v592 : string) = _v377.Value
    let v593 : string option = None
    let v594 : bool = true in let mutable _v593 = v593
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v595 : string = method18(v3)
    let v596 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v597 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v595 v596
    let v598 : string = "String::from($0)"
    let v599 : std_string_String = Fable.Core.RustInterop.emitRustExpr v597 v598
    let v600 : string = "std::path::PathBuf::from($0)"
    let v601 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v599 v600
    let v602 : string = method18(v259)
    let v603 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v604 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v602 v603
    let v605 : string = "String::from($0)"
    let v606 : std_string_String = Fable.Core.RustInterop.emitRustExpr v604 v605
    let v607 : string = "$0.join($1)"
    let v608 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v601, v606) v607
    let v609 : string = "$0.display()"
    let v610 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v608 v609
    let v611 : std_string_String option = None
    let v612 : bool = true in let mutable _v611 = v611
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v613 : string = @$"format!(""{{}}"", $0)"
    let v614 : std_string_String = Fable.Core.RustInterop.emitRustExpr v610 v613
    v614
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v615 : string = @$"format!(""{{}}"", $0)"
    let v616 : std_string_String = Fable.Core.RustInterop.emitRustExpr v610 v615
    v616
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v617 : string = @$"format!(""{{}}"", $0)"
    let v618 : std_string_String = Fable.Core.RustInterop.emitRustExpr v610 v617
    v618
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v619 : std_string_String = null |> unbox<std_string_String>
    v619
#endif
    
#if FABLE_COMPILER_PYTHON
    let v620 : std_string_String = null |> unbox<std_string_String>
    v620
#endif
    
#else
    let v621 : std_string_String = null |> unbox<std_string_String>
    v621
#endif
    |> fun x -> _v611 <- Some x
    let v622 : std_string_String = _v611.Value
    let v623 : string = "fable_library_rust::String_::fromString($0)"
    let v624 : string = Fable.Core.RustInterop.emitRustExpr v622 v623
    v624
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v625 : string = null |> unbox<string>
    v625
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v626 : string = null |> unbox<string>
    v626
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v627 : IPathJoin = Fable.Core.JsInterop.importAll v328
    let v628 : string = method19(v3)
    let v629 : string = method20(v259)
    let v630 : string = "v627.join(v628, v629)"
    let v631 : string = Fable.Core.JsInterop.emitJsExpr () v630
    v631
#endif
    
#if FABLE_COMPILER_PYTHON
    let v632 : string = null |> unbox<string>
    v632
#endif
    
#else
    let v633 : string = System.IO.Path.Combine (v3, v259)
    v633
#endif
    |> fun x -> _v593 <- Some x
    let v634 : string = _v593.Value
    let v635 : bool option = None
    let v636 : bool = true in let mutable _v635 = v635
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v637 : string = "cfg!(windows)"
    let v638 : bool = Fable.Core.RustInterop.emitRustExpr () v637
    v638
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v639 : bool = null |> unbox<bool>
    v639
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v640 : bool = null |> unbox<bool>
    v640
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v641 : bool = null |> unbox<bool>
    v641
#endif
    
#if FABLE_COMPILER_PYTHON
    let v642 : bool = null |> unbox<bool>
    v642
#endif
    
#else
    let v643 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v644 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v645 : bool = v644 v643
    v645
#endif
    |> fun x -> _v635 <- Some x
    let v646 : bool = _v635.Value
    let v647 : bool = v646 = false
    let v668 : string =
        if v647 then
            v634
        else
            let v648 : string option = None
            let v649 : bool = true in let mutable _v648 = v648
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v650 : string = method26()
            let v651 : string = method27(v634)
            let v652 : string = method28()
            let v653 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v654 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v650, v651, v652) v653
            let v655 : string = "String::from($0)"
            let v656 : std_string_String = Fable.Core.RustInterop.emitRustExpr v654 v655
            let v657 : string = "fable_library_rust::String_::fromString($0)"
            let v658 : string = Fable.Core.RustInterop.emitRustExpr v656 v657
            v658
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v659 : string = null |> unbox<string>
            v659
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v660 : string = null |> unbox<string>
            v660
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v661 : string = null |> unbox<string>
            v661
#endif
            
#if FABLE_COMPILER_PYTHON
            let v662 : string = null |> unbox<string>
            v662
#endif
            
#else
            let v663 : string = "^\\\\\\\\\\?\\\\"
            let v664 : string = System.Text.RegularExpressions.Regex.Replace (v634, v663, v254)
            v664
#endif
            |> fun x -> _v648 <- Some x
            let v665 : string = _v648.Value
            let v666 : string = $"{v665.[0] |> string |> _.ToLower()}{v665.[1..]}"
            let v667 : string = v666.Replace (v256, v257)
            v667
    let v669 : string option = None
    let v670 : System.Threading.CancellationToken option = None
    let v671 : (struct (string * string) []) = [||]
    let v672 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v673 : string = $"git hash-object \"{v668}\""
    let v674 : string option = Some v3 
    let v675 : struct (int32 * string) option = None
    let v676 : bool = true in let mutable _v675 = v675
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v677 : string = method42(v670, v673, v671, v672, v674)
    let struct (v678 : string, v679 : string) = method43()
    let v680 : int32 = v677.Length
    let v681 : (char []) = Array.zeroCreate<char> (v680)
    let v682 : Mut5 = {l0 = 0} : Mut5
    while method30(v680, v682) do
        let v684 : int32 = v682.l0
        let v685 : char = v677.[int v684]
        v681.[int v684] <- v685
        let v686 : int32 = v684 + 1
        v682.l0 <- v686
        ()
    let v687 : ((char []) -> char list) = Array.toList
    let v688 : char list = v687 v681
    let v689 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v690 : (char -> (UH0 -> UH0)) = method44()
    let v691 : (char list -> (UH0 -> UH0)) = v689 v690
    let v692 : (UH0 -> UH0) = v691 v688
    let v693 : UH0 = UH0_0
    let v694 : UH0 = v692 v693
    let v695 : US8 = US8_0
    let struct (v696 : string, v697 : string) = method45(v679, v678, v694, v695)
    let v698 : (string []) = method46(v697)
    let v699 : string = "$0.to_vec()"
    let v700 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v698 v699
    let v701 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v702 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v700, v404) v701
    let v703 : US0 = US0_1
    let v704 : (unit -> string) = closure29(v670, v673, v671, v672, v674, v696, v702)
    let v705 : (unit -> string) = method51()
    method3(v703, v704, v705)
    let v706 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method52(v670, v673, v671, v672, v674, v696, v702)
    let v707 : string = "futures_lite::future::block_on($0)"
    let v708 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v706 v707
    let (a, b) = v708
    let v709 : int32 = a
    let v710 : string = b
    struct (v709, v710)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v711 : int32, v712 : string) = null |> unbox<struct (int32 * string)>
    struct (v711, v712)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v713 : int32, v714 : string) = null |> unbox<struct (int32 * string)>
    struct (v713, v714)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v715 : int32, v716 : string) = null |> unbox<struct (int32 * string)>
    struct (v715, v716)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v717 : int32, v718 : string) = null |> unbox<struct (int32 * string)>
    struct (v717, v718)
#endif
    
#else
    let v719 : Async<struct (int32 * string)> option = None
    let v720 : bool = true in let mutable _v719 = v719
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v721 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v721
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v722 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v722
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v723 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v723
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v724 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v724
#endif
    
#if FABLE_COMPILER_PYTHON
    let v725 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v725
#endif
    
#else
    let v726 : Async<struct (int32 * string)> option = None
    let v727 : bool = true in let mutable _v726 = v726
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v728 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v728
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v729 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v729
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v730 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v730
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v731 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v731
#endif
    
#if FABLE_COMPILER_PYTHON
    let v732 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v732
#endif
    
#else
    let v733 : Async<struct (int32 * string)> option = None
    let mutable _v733 = v733
    async {
    let struct (v734 : string, v735 : string) = method43()
    let v736 : int32 = v673.Length
    let v737 : (char []) = Array.zeroCreate<char> (v736)
    let v738 : Mut5 = {l0 = 0} : Mut5
    while method30(v736, v738) do
        let v740 : int32 = v738.l0
        let v741 : char = v673.[int v740]
        v737.[int v740] <- v741
        let v742 : int32 = v740 + 1
        v738.l0 <- v742
        ()
    let v743 : ((char []) -> char list) = Array.toList
    let v744 : char list = v743 v737
    let v745 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v746 : (char -> (UH0 -> UH0)) = method44()
    let v747 : (char list -> (UH0 -> UH0)) = v745 v746
    let v748 : (UH0 -> UH0) = v747 v744
    let v749 : UH0 = UH0_0
    let v750 : UH0 = v748 v749
    let v751 : US8 = US8_0
    let struct (v752 : string, v753 : string) = method45(v735, v734, v750, v751)
    let v754 : (string -> US4) = method22()
    let v755 : US4 = US4_1
    let v756 : US4 = v674 |> Option.map v754 |> Option.defaultValue v755 
    let v759 : string =
        match v756 with
        | US4_1 -> (* None *)
            v254
        | US4_0(v757) -> (* Some *)
            v757
    let v760 : US0 = US0_1
    let v761 : (unit -> string) = closure45(v670, v673, v671, v672, v674)
    let v762 : (unit -> string) = method51()
    method3(v760, v761, v762)
    let v763 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v764 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v753, StandardOutputEncoding = v763, WorkingDirectory = v759, FileName = v752, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v765 : int32 = v671.Length
    let v766 : Mut5 = {l0 = 0} : Mut5
    while method30(v765, v766) do
        let v768 : int32 = v766.l0
        let struct (v769 : string, v770 : string) = v671.[int v768]
        v764.EnvironmentVariables.[v769] <- v770 
        let v771 : int32 = v768 + 1
        v766.l0 <- v771
        ()
    let v772 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v764)
    use v772 = v772 
    let v773 : System.Diagnostics.Process = v772 
    let v774 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v775 : System.Collections.Concurrent.ConcurrentStack<string> = v774 ()
    let v776 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure46(v670, v673, v671, v672, v674, v773, v775)
    v773.OutputDataReceived.Add v776 
    let v777 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v670, v673, v671, v672, v674, v773, v775)
    v773.ErrorDataReceived.Add v777 
    let v778 : (unit -> bool) = v773.Start
    let v779 : bool = v778 ()
    let v780 : bool = v779 = false
    if v780 then
        let v781 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v781
    let v782 : (unit -> unit) = v773.BeginErrorReadLine
    v782 ()
    let v783 : (unit -> unit) = v773.BeginOutputReadLine
    v783 ()
    let v784 : (System.Threading.CancellationToken -> US16) = method71()
    let v785 : US16 = US16_1
    let v786 : US16 = v670 |> Option.map v784 |> Option.defaultValue v785 
    let v790 : System.Threading.CancellationToken =
        match v786 with
        | US16_1 -> (* None *)
            let v788 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v788
        | US16_0(v787) -> (* Some *)
            v787
    let v791 : Async<System.Threading.CancellationToken> option = None
    let v792 : bool = true in let mutable _v791 = v791
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v793 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v793
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v794 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v794
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v795 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v795
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v796 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v796
#endif
    
#if FABLE_COMPILER_PYTHON
    let v797 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v797
#endif
    
#else
    let v798 : Async<System.Threading.CancellationToken> option = None
    let v799 : bool = true in let mutable _v798 = v798
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v800 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v800
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v801 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v801
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v802 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v802
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v803 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v803
#endif
    
#if FABLE_COMPILER_PYTHON
    let v804 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v804
#endif
    
#else
    let v805 : Async<System.Threading.CancellationToken> option = None
    let mutable _v805 = v805
    async {
    let v806 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v806 = v806 
    let v807 : System.Threading.CancellationToken = v806 
    let v808 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v809 : (System.Threading.CancellationToken []) = [|v807; v808; v790|]
    let v810 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v811 : System.Threading.CancellationTokenSource = v810 v809
    let v812 : System.Threading.CancellationToken = v811.Token
    return v812 
    }
    |> fun x -> _v805 <- Some x
    let v813 : Async<System.Threading.CancellationToken> = _v805 |> Option.get
    v813
#endif
    |> fun x -> _v798 <- Some x
    let v814 : Async<System.Threading.CancellationToken> = _v798.Value
    v814
#endif
    |> fun x -> _v791 <- Some x
    let v815 : Async<System.Threading.CancellationToken> = _v791.Value
    let! v815 = v815 
    let v816 : System.Threading.CancellationToken = v815 
    let v817 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v816.Register
    let v818 : (unit -> unit) = closure51(v773)
    let v819 : System.Threading.CancellationTokenRegistration = v817 v818
    use v819 = v819 
    let v820 : System.Threading.CancellationTokenRegistration = v819 
    let v821 : Async<int32> option = None
    let v822 : bool = true in let mutable _v821 = v821
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v823 : Async<int32> = null |> unbox<Async<int32>>
    v823
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v824 : Async<int32> = null |> unbox<Async<int32>>
    v824
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v825 : Async<int32> = null |> unbox<Async<int32>>
    v825
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v826 : Async<int32> = null |> unbox<Async<int32>>
    v826
#endif
    
#if FABLE_COMPILER_PYTHON
    let v827 : Async<int32> = null |> unbox<Async<int32>>
    v827
#endif
    
#else
    let v828 : Async<int32> option = None
    let mutable _v828 = v828
    async {
    try
    let v829 : System.Threading.Tasks.Task = v773.WaitForExitAsync v816 
    let v830 : Async<unit> option = None
    let v831 : bool = true in let mutable _v830 = v830
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v832 : Async<unit> = null |> unbox<Async<unit>>
    v832
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v833 : Async<unit> = null |> unbox<Async<unit>>
    v833
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v834 : Async<unit> = null |> unbox<Async<unit>>
    v834
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v835 : Async<unit> = null |> unbox<Async<unit>>
    v835
#endif
    
#if FABLE_COMPILER_PYTHON
    let v836 : Async<unit> = null |> unbox<Async<unit>>
    v836
#endif
    
#else
    let v837 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v838 : Async<unit> = v837 v829
    v838
#endif
    |> fun x -> _v830 <- Some x
    let v839 : Async<unit> = _v830.Value
    do! v839 
    let v840 : int32 = v773.ExitCode
    return v840 
    with ex ->
    let v841 : exn = ex
    let v842 : string option = None
    let v843 : bool = true in let mutable _v842 = v842
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v844 : string = $"%A{v841}"
    v844
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v845 : string = $"%A{v841}"
    v845
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v846 : string = $"%A{v841}"
    v846
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v847 : string = $"%A{v841}"
    v847
#endif
    
#if FABLE_COMPILER_PYTHON
    let v848 : string = $"%A{v841}"
    v848
#endif
    
#else
    let v849 : string = $"{v841.GetType ()}: {v841.Message}"
    v849
#endif
    |> fun x -> _v842 <- Some x
    let v850 : string = _v842.Value
    let v851 : (string -> unit) = v775.Push
    v851 v850
    let v852 : System.Threading.Tasks.TaskCanceledException = v841 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v853 : US0 = US0_3
    let v854 : (unit -> string) = closure52(v852)
    let v855 : (unit -> string) = method51()
    method3(v853, v854, v855)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v828 <- Some x
    let v856 : Async<int32> = _v828 |> Option.get
    v856
#endif
    |> fun x -> _v821 <- Some x
    let v857 : Async<int32> = _v821.Value
    let! v857 = v857 
    let v858 : int32 = v857 
    let v859 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v860 : string seq = v859 v775
    let v861 : string = method72()
    let v862 : (string -> (string seq -> string)) = String.concat
    let v863 : (string seq -> string) = v862 v861
    let v864 : string = v863 v860
    let v865 : US0 = US0_1
    let v866 : (unit -> string) = closure53(v858, v864)
    let v867 : (unit -> string) = method51()
    method3(v865, v866, v867)
    return struct (v858, v864) 
    }
    |> fun x -> _v733 <- Some x
    let v868 : Async<struct (int32 * string)> = _v733 |> Option.get
    v868
#endif
    |> fun x -> _v726 <- Some x
    let v869 : Async<struct (int32 * string)> = _v726.Value
    v869
#endif
    |> fun x -> _v719 <- Some x
    let v870 : Async<struct (int32 * string)> = _v719.Value
    let v871 : struct (int32 * string) option = None
    let v872 : bool = true in let mutable _v871 = v871
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v873 : int32, v874 : string) = null |> unbox<struct (int32 * string)>
    struct (v873, v874)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v875 : int32, v876 : string) = null |> unbox<struct (int32 * string)>
    struct (v875, v876)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v877 : int32, v878 : string) = null |> unbox<struct (int32 * string)>
    struct (v877, v878)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v879 : int32, v880 : string) = null |> unbox<struct (int32 * string)>
    struct (v879, v880)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v881 : int32, v882 : string) = null |> unbox<struct (int32 * string)>
    struct (v881, v882)
#endif
    
#else
    let v883 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v884 : int32, v885 : string) = v883 v870
    struct (v884, v885)
#endif
    |> fun x -> _v871 <- Some x
    let struct (v886 : int32, v887 : string) = _v871.Value
    struct (v886, v887)
#endif
    |> fun x -> _v675 <- Some x
    let struct (v888 : int32, v889 : string) = _v675.Value
    let v890 : bool = v592.Contains v889
    let v891 : bool = v890 = false
    let v1541 : Vec<Result<string, (string * string)> option> =
        if v891 then
            let v892 : bool option = None
            let v893 : bool = true in let mutable _v892 = v892
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v894 : string = "cfg!(windows)"
            let v895 : bool = Fable.Core.RustInterop.emitRustExpr () v894
            v895
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v896 : bool = null |> unbox<bool>
            v896
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v897 : bool = null |> unbox<bool>
            v897
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v898 : bool = null |> unbox<bool>
            v898
#endif
            
#if FABLE_COMPILER_PYTHON
            let v899 : bool = null |> unbox<bool>
            v899
#endif
            
#else
            let v900 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v901 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v902 : bool = v901 v900
            v902
#endif
            |> fun x -> _v892 <- Some x
            let v903 : bool = _v892.Value
            let v904 : bool = v903 = false
            let v925 : string =
                if v904 then
                    v668
                else
                    let v905 : string option = None
                    let v906 : bool = true in let mutable _v905 = v905
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v907 : string = method26()
                    let v908 : string = method27(v668)
                    let v909 : string = method28()
                    let v910 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v911 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v907, v908, v909) v910
                    let v912 : string = "String::from($0)"
                    let v913 : std_string_String = Fable.Core.RustInterop.emitRustExpr v911 v912
                    let v914 : string = "fable_library_rust::String_::fromString($0)"
                    let v915 : string = Fable.Core.RustInterop.emitRustExpr v913 v914
                    v915
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v916 : string = null |> unbox<string>
                    v916
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v917 : string = null |> unbox<string>
                    v917
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v918 : string = null |> unbox<string>
                    v918
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v919 : string = null |> unbox<string>
                    v919
#endif
                    
#else
                    let v920 : string = "^\\\\\\\\\\?\\\\"
                    let v921 : string = System.Text.RegularExpressions.Regex.Replace (v668, v920, v254)
                    v921
#endif
                    |> fun x -> _v905 <- Some x
                    let v922 : string = _v905.Value
                    let v923 : string = $"{v922.[0] |> string |> _.ToLower()}{v922.[1..]}"
                    let v924 : string = v923.Replace (v256, v257)
                    v924
            let v926 : string option = None
            let v927 : System.Threading.CancellationToken option = None
            let v928 : (struct (string * string) []) = [||]
            let v929 : (struct (bool * string * int32) -> Async<unit>) option = None
            let v930 : string = $"pwsh -c \"(Get-FileHash \\\"{v925}\\\" -Algorithm SHA256).Hash\""
            let v931 : struct (int32 * string) option = None
            let v932 : bool = true in let mutable _v931 = v931
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v933 : string = method42(v927, v930, v928, v929, v926)
            let struct (v934 : string, v935 : string) = method43()
            let v936 : int32 = v933.Length
            let v937 : (char []) = Array.zeroCreate<char> (v936)
            let v938 : Mut5 = {l0 = 0} : Mut5
            while method30(v936, v938) do
                let v940 : int32 = v938.l0
                let v941 : char = v933.[int v940]
                v937.[int v940] <- v941
                let v942 : int32 = v940 + 1
                v938.l0 <- v942
                ()
            let v943 : ((char []) -> char list) = Array.toList
            let v944 : char list = v943 v937
            let v945 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v946 : (char -> (UH0 -> UH0)) = method44()
            let v947 : (char list -> (UH0 -> UH0)) = v945 v946
            let v948 : (UH0 -> UH0) = v947 v944
            let v949 : UH0 = UH0_0
            let v950 : UH0 = v948 v949
            let v951 : US8 = US8_0
            let struct (v952 : string, v953 : string) = method45(v935, v934, v950, v951)
            let v954 : (string []) = method46(v953)
            let v955 : string = "$0.to_vec()"
            let v956 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v954 v955
            let v957 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v958 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v956, v404) v957
            let v959 : US0 = US0_1
            let v960 : (unit -> string) = closure29(v927, v930, v928, v929, v926, v952, v958)
            let v961 : (unit -> string) = method51()
            method3(v959, v960, v961)
            let v962 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method52(v927, v930, v928, v929, v926, v952, v958)
            let v963 : string = "futures_lite::future::block_on($0)"
            let v964 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v962 v963
            let (a, b) = v964
            let v965 : int32 = a
            let v966 : string = b
            struct (v965, v966)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v967 : int32, v968 : string) = null |> unbox<struct (int32 * string)>
            struct (v967, v968)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v969 : int32, v970 : string) = null |> unbox<struct (int32 * string)>
            struct (v969, v970)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v971 : int32, v972 : string) = null |> unbox<struct (int32 * string)>
            struct (v971, v972)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v973 : int32, v974 : string) = null |> unbox<struct (int32 * string)>
            struct (v973, v974)
#endif
            
#else
            let v975 : Async<struct (int32 * string)> option = None
            let v976 : bool = true in let mutable _v975 = v975
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v977 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v977
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v978 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v978
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v979 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v979
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v980 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v980
#endif
            
#if FABLE_COMPILER_PYTHON
            let v981 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v981
#endif
            
#else
            let v982 : Async<struct (int32 * string)> option = None
            let v983 : bool = true in let mutable _v982 = v982
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v984 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v984
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v985 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v985
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v986 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v986
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v987 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v987
#endif
            
#if FABLE_COMPILER_PYTHON
            let v988 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v988
#endif
            
#else
            let v989 : Async<struct (int32 * string)> option = None
            let mutable _v989 = v989
            async {
            let struct (v990 : string, v991 : string) = method43()
            let v992 : int32 = v930.Length
            let v993 : (char []) = Array.zeroCreate<char> (v992)
            let v994 : Mut5 = {l0 = 0} : Mut5
            while method30(v992, v994) do
                let v996 : int32 = v994.l0
                let v997 : char = v930.[int v996]
                v993.[int v996] <- v997
                let v998 : int32 = v996 + 1
                v994.l0 <- v998
                ()
            let v999 : ((char []) -> char list) = Array.toList
            let v1000 : char list = v999 v993
            let v1001 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v1002 : (char -> (UH0 -> UH0)) = method44()
            let v1003 : (char list -> (UH0 -> UH0)) = v1001 v1002
            let v1004 : (UH0 -> UH0) = v1003 v1000
            let v1005 : UH0 = UH0_0
            let v1006 : UH0 = v1004 v1005
            let v1007 : US8 = US8_0
            let struct (v1008 : string, v1009 : string) = method45(v991, v990, v1006, v1007)
            let v1010 : (string -> US4) = method22()
            let v1011 : US4 = US4_1
            let v1012 : US4 = v926 |> Option.map v1010 |> Option.defaultValue v1011 
            let v1015 : string =
                match v1012 with
                | US4_1 -> (* None *)
                    v254
                | US4_0(v1013) -> (* Some *)
                    v1013
            let v1016 : US0 = US0_1
            let v1017 : (unit -> string) = closure45(v927, v930, v928, v929, v926)
            let v1018 : (unit -> string) = method51()
            method3(v1016, v1017, v1018)
            let v1019 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v1020 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v1009, StandardOutputEncoding = v1019, WorkingDirectory = v1015, FileName = v1008, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v1021 : int32 = v928.Length
            let v1022 : Mut5 = {l0 = 0} : Mut5
            while method30(v1021, v1022) do
                let v1024 : int32 = v1022.l0
                let struct (v1025 : string, v1026 : string) = v928.[int v1024]
                v1020.EnvironmentVariables.[v1025] <- v1026 
                let v1027 : int32 = v1024 + 1
                v1022.l0 <- v1027
                ()
            let v1028 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1020)
            use v1028 = v1028 
            let v1029 : System.Diagnostics.Process = v1028 
            let v1030 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v1031 : System.Collections.Concurrent.ConcurrentStack<string> = v1030 ()
            let v1032 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure46(v927, v930, v928, v929, v926, v1029, v1031)
            v1029.OutputDataReceived.Add v1032 
            let v1033 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v927, v930, v928, v929, v926, v1029, v1031)
            v1029.ErrorDataReceived.Add v1033 
            let v1034 : (unit -> bool) = v1029.Start
            let v1035 : bool = v1034 ()
            let v1036 : bool = v1035 = false
            if v1036 then
                let v1037 : string = $"execute_with_options_async / process_start error"
                failwith<unit> v1037
            let v1038 : (unit -> unit) = v1029.BeginErrorReadLine
            v1038 ()
            let v1039 : (unit -> unit) = v1029.BeginOutputReadLine
            v1039 ()
            let v1040 : (System.Threading.CancellationToken -> US16) = method71()
            let v1041 : US16 = US16_1
            let v1042 : US16 = v927 |> Option.map v1040 |> Option.defaultValue v1041 
            let v1046 : System.Threading.CancellationToken =
                match v1042 with
                | US16_1 -> (* None *)
                    let v1044 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v1044
                | US16_0(v1043) -> (* Some *)
                    v1043
            let v1047 : Async<System.Threading.CancellationToken> option = None
            let v1048 : bool = true in let mutable _v1047 = v1047
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1049 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1049
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1050 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1050
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1051 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1051
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1052 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1052
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1053 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1053
#endif
            
#else
            let v1054 : Async<System.Threading.CancellationToken> option = None
            let v1055 : bool = true in let mutable _v1054 = v1054
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1056 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1056
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1057 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1057
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1058 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1058
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1059 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1059
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1060 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1060
#endif
            
#else
            let v1061 : Async<System.Threading.CancellationToken> option = None
            let mutable _v1061 = v1061
            async {
            let v1062 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v1062 = v1062 
            let v1063 : System.Threading.CancellationToken = v1062 
            let v1064 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v1065 : (System.Threading.CancellationToken []) = [|v1063; v1064; v1046|]
            let v1066 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v1067 : System.Threading.CancellationTokenSource = v1066 v1065
            let v1068 : System.Threading.CancellationToken = v1067.Token
            return v1068 
            }
            |> fun x -> _v1061 <- Some x
            let v1069 : Async<System.Threading.CancellationToken> = _v1061 |> Option.get
            v1069
#endif
            |> fun x -> _v1054 <- Some x
            let v1070 : Async<System.Threading.CancellationToken> = _v1054.Value
            v1070
#endif
            |> fun x -> _v1047 <- Some x
            let v1071 : Async<System.Threading.CancellationToken> = _v1047.Value
            let! v1071 = v1071 
            let v1072 : System.Threading.CancellationToken = v1071 
            let v1073 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1072.Register
            let v1074 : (unit -> unit) = closure51(v1029)
            let v1075 : System.Threading.CancellationTokenRegistration = v1073 v1074
            use v1075 = v1075 
            let v1076 : System.Threading.CancellationTokenRegistration = v1075 
            let v1077 : Async<int32> option = None
            let v1078 : bool = true in let mutable _v1077 = v1077
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1079 : Async<int32> = null |> unbox<Async<int32>>
            v1079
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1080 : Async<int32> = null |> unbox<Async<int32>>
            v1080
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1081 : Async<int32> = null |> unbox<Async<int32>>
            v1081
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1082 : Async<int32> = null |> unbox<Async<int32>>
            v1082
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1083 : Async<int32> = null |> unbox<Async<int32>>
            v1083
#endif
            
#else
            let v1084 : Async<int32> option = None
            let mutable _v1084 = v1084
            async {
            try
            let v1085 : System.Threading.Tasks.Task = v1029.WaitForExitAsync v1072 
            let v1086 : Async<unit> option = None
            let v1087 : bool = true in let mutable _v1086 = v1086
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1088 : Async<unit> = null |> unbox<Async<unit>>
            v1088
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1089 : Async<unit> = null |> unbox<Async<unit>>
            v1089
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1090 : Async<unit> = null |> unbox<Async<unit>>
            v1090
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1091 : Async<unit> = null |> unbox<Async<unit>>
            v1091
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1092 : Async<unit> = null |> unbox<Async<unit>>
            v1092
#endif
            
#else
            let v1093 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v1094 : Async<unit> = v1093 v1085
            v1094
#endif
            |> fun x -> _v1086 <- Some x
            let v1095 : Async<unit> = _v1086.Value
            do! v1095 
            let v1096 : int32 = v1029.ExitCode
            return v1096 
            with ex ->
            let v1097 : exn = ex
            let v1098 : string option = None
            let v1099 : bool = true in let mutable _v1098 = v1098
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1100 : string = $"%A{v1097}"
            v1100
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1101 : string = $"%A{v1097}"
            v1101
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1102 : string = $"%A{v1097}"
            v1102
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1103 : string = $"%A{v1097}"
            v1103
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1104 : string = $"%A{v1097}"
            v1104
#endif
            
#else
            let v1105 : string = $"{v1097.GetType ()}: {v1097.Message}"
            v1105
#endif
            |> fun x -> _v1098 <- Some x
            let v1106 : string = _v1098.Value
            let v1107 : (string -> unit) = v1031.Push
            v1107 v1106
            let v1108 : System.Threading.Tasks.TaskCanceledException = v1097 |> unbox<System.Threading.Tasks.TaskCanceledException>
            let v1109 : US0 = US0_3
            let v1110 : (unit -> string) = closure52(v1108)
            let v1111 : (unit -> string) = method51()
            method3(v1109, v1110, v1111)
            return -2147483648 
            (*
            *)
            }
            |> fun x -> _v1084 <- Some x
            let v1112 : Async<int32> = _v1084 |> Option.get
            v1112
#endif
            |> fun x -> _v1077 <- Some x
            let v1113 : Async<int32> = _v1077.Value
            let! v1113 = v1113 
            let v1114 : int32 = v1113 
            let v1115 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v1116 : string seq = v1115 v1031
            let v1117 : string = method72()
            let v1118 : (string -> (string seq -> string)) = String.concat
            let v1119 : (string seq -> string) = v1118 v1117
            let v1120 : string = v1119 v1116
            let v1121 : US0 = US0_1
            let v1122 : (unit -> string) = closure53(v1114, v1120)
            let v1123 : (unit -> string) = method51()
            method3(v1121, v1122, v1123)
            return struct (v1114, v1120) 
            }
            |> fun x -> _v989 <- Some x
            let v1124 : Async<struct (int32 * string)> = _v989 |> Option.get
            v1124
#endif
            |> fun x -> _v982 <- Some x
            let v1125 : Async<struct (int32 * string)> = _v982.Value
            v1125
#endif
            |> fun x -> _v975 <- Some x
            let v1126 : Async<struct (int32 * string)> = _v975.Value
            let v1127 : struct (int32 * string) option = None
            let v1128 : bool = true in let mutable _v1127 = v1127
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v1129 : int32, v1130 : string) = null |> unbox<struct (int32 * string)>
            struct (v1129, v1130)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v1131 : int32, v1132 : string) = null |> unbox<struct (int32 * string)>
            struct (v1131, v1132)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v1133 : int32, v1134 : string) = null |> unbox<struct (int32 * string)>
            struct (v1133, v1134)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v1135 : int32, v1136 : string) = null |> unbox<struct (int32 * string)>
            struct (v1135, v1136)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v1137 : int32, v1138 : string) = null |> unbox<struct (int32 * string)>
            struct (v1137, v1138)
#endif
            
#else
            let v1139 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
            let struct (v1140 : int32, v1141 : string) = v1139 v1126
            struct (v1140, v1141)
#endif
            |> fun x -> _v1127 <- Some x
            let struct (v1142 : int32, v1143 : string) = _v1127.Value
            struct (v1142, v1143)
#endif
            |> fun x -> _v931 <- Some x
            let struct (v1144 : int32, v1145 : string) = _v931.Value
            let v1146 : string option = None
            let v1147 : bool = true in let mutable _v1146 = v1146
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1148 : string = method18(v4)
            let v1149 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1150 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1148 v1149
            let v1151 : string = "String::from($0)"
            let v1152 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1150 v1151
            let v1153 : string = "std::path::PathBuf::from($0)"
            let v1154 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1152 v1153
            let v1155 : string = method18(v259)
            let v1156 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1157 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1155 v1156
            let v1158 : string = "String::from($0)"
            let v1159 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1157 v1158
            let v1160 : string = "$0.join($1)"
            let v1161 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v1154, v1159) v1160
            let v1162 : string = "$0.display()"
            let v1163 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v1161 v1162
            let v1164 : std_string_String option = None
            let v1165 : bool = true in let mutable _v1164 = v1164
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1166 : string = @$"format!(""{{}}"", $0)"
            let v1167 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1163 v1166
            v1167
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1168 : string = @$"format!(""{{}}"", $0)"
            let v1169 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1163 v1168
            v1169
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1170 : string = @$"format!(""{{}}"", $0)"
            let v1171 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1163 v1170
            v1171
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1172 : std_string_String = null |> unbox<std_string_String>
            v1172
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1173 : std_string_String = null |> unbox<std_string_String>
            v1173
#endif
            
#else
            let v1174 : std_string_String = null |> unbox<std_string_String>
            v1174
#endif
            |> fun x -> _v1164 <- Some x
            let v1175 : std_string_String = _v1164.Value
            let v1176 : string = "fable_library_rust::String_::fromString($0)"
            let v1177 : string = Fable.Core.RustInterop.emitRustExpr v1175 v1176
            v1177
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1178 : string = null |> unbox<string>
            v1178
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1179 : string = null |> unbox<string>
            v1179
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1180 : IPathJoin = Fable.Core.JsInterop.importAll v328
            let v1181 : string = method19(v4)
            let v1182 : string = method20(v259)
            let v1183 : string = "v1180.join(v1181, v1182)"
            let v1184 : string = Fable.Core.JsInterop.emitJsExpr () v1183
            v1184
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1185 : string = null |> unbox<string>
            v1185
#endif
            
#else
            let v1186 : string = System.IO.Path.Combine (v4, v259)
            v1186
#endif
            |> fun x -> _v1146 <- Some x
            let v1187 : string = _v1146.Value
            let v1188 : bool option = None
            let v1189 : bool = true in let mutable _v1188 = v1188
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1190 : string = "cfg!(windows)"
            let v1191 : bool = Fable.Core.RustInterop.emitRustExpr () v1190
            v1191
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1192 : bool = null |> unbox<bool>
            v1192
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1193 : bool = null |> unbox<bool>
            v1193
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1194 : bool = null |> unbox<bool>
            v1194
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1195 : bool = null |> unbox<bool>
            v1195
#endif
            
#else
            let v1196 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v1197 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v1198 : bool = v1197 v1196
            v1198
#endif
            |> fun x -> _v1188 <- Some x
            let v1199 : bool = _v1188.Value
            let v1200 : bool = v1199 = false
            let v1221 : string =
                if v1200 then
                    v1187
                else
                    let v1201 : string option = None
                    let v1202 : bool = true in let mutable _v1201 = v1201
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1203 : string = method26()
                    let v1204 : string = method27(v1187)
                    let v1205 : string = method28()
                    let v1206 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v1207 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1203, v1204, v1205) v1206
                    let v1208 : string = "String::from($0)"
                    let v1209 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1207 v1208
                    let v1210 : string = "fable_library_rust::String_::fromString($0)"
                    let v1211 : string = Fable.Core.RustInterop.emitRustExpr v1209 v1210
                    v1211
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1212 : string = null |> unbox<string>
                    v1212
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1213 : string = null |> unbox<string>
                    v1213
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1214 : string = null |> unbox<string>
                    v1214
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1215 : string = null |> unbox<string>
                    v1215
#endif
                    
#else
                    let v1216 : string = "^\\\\\\\\\\?\\\\"
                    let v1217 : string = System.Text.RegularExpressions.Regex.Replace (v1187, v1216, v254)
                    v1217
#endif
                    |> fun x -> _v1201 <- Some x
                    let v1218 : string = _v1201.Value
                    let v1219 : string = $"{v1218.[0] |> string |> _.ToLower()}{v1218.[1..]}"
                    let v1220 : string = v1219.Replace (v256, v257)
                    v1220
            let v1222 : bool option = None
            let v1223 : bool = true in let mutable _v1222 = v1222
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1224 : string = method18(v1221)
            let v1225 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1226 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1224 v1225
            let v1227 : string = "String::from($0)"
            let v1228 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1226 v1227
            let v1229 : string = "std::path::PathBuf::from($0)"
            let v1230 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1228 v1229
            let v1231 : string = "$0.exists()"
            let v1232 : bool = Fable.Core.RustInterop.emitRustExpr v1230 v1231
            let v1235 : bool =
                if v1232 then
                    let v1233 : string = "$0.is_file()"
                    let v1234 : bool = Fable.Core.RustInterop.emitRustExpr v1230 v1233
                    v1234
                else
                    false
            v1235
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1236 : bool = null |> unbox<bool>
            v1236
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1237 : bool = null |> unbox<bool>
            v1237
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1238 : string = "fs"
            let v1239 : IFsExistsSync = Fable.Core.JsInterop.importAll v1238
            let v1240 : string = "v1239.existsSync($0)"
            let v1241 : bool = Fable.Core.JsInterop.emitJsExpr v1221 v1240
            v1241
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1242 : bool = null |> unbox<bool>
            v1242
#endif
            
#else
            let v1243 : (string -> bool) = System.IO.File.Exists
            let v1244 : bool = v1243 v1221
            v1244
#endif
            |> fun x -> _v1222 <- Some x
            let v1245 : bool = _v1222.Value
            let v1500 : string =
                if v1245 then
                    let v1246 : bool option = None
                    let v1247 : bool = true in let mutable _v1246 = v1246
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1248 : string = "cfg!(windows)"
                    let v1249 : bool = Fable.Core.RustInterop.emitRustExpr () v1248
                    v1249
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1250 : bool = null |> unbox<bool>
                    v1250
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1251 : bool = null |> unbox<bool>
                    v1251
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1252 : bool = null |> unbox<bool>
                    v1252
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1253 : bool = null |> unbox<bool>
                    v1253
#endif
                    
#else
                    let v1254 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                    let v1255 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                    let v1256 : bool = v1255 v1254
                    v1256
#endif
                    |> fun x -> _v1246 <- Some x
                    let v1257 : bool = _v1246.Value
                    let v1258 : bool = v1257 = false
                    let v1279 : string =
                        if v1258 then
                            v1221
                        else
                            let v1259 : string option = None
                            let v1260 : bool = true in let mutable _v1259 = v1259
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v1261 : string = method26()
                            let v1262 : string = method27(v1221)
                            let v1263 : string = method28()
                            let v1264 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                            let v1265 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1261, v1262, v1263) v1264
                            let v1266 : string = "String::from($0)"
                            let v1267 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1265 v1266
                            let v1268 : string = "fable_library_rust::String_::fromString($0)"
                            let v1269 : string = Fable.Core.RustInterop.emitRustExpr v1267 v1268
                            v1269
#endif
                            
#if FABLE_COMPILER_RUST && WASM
                            let v1270 : string = null |> unbox<string>
                            v1270
#endif
                            
#if FABLE_COMPILER_RUST && CONTRACT
                            let v1271 : string = null |> unbox<string>
                            v1271
#endif
                            
#if FABLE_COMPILER_TYPESCRIPT
                            let v1272 : string = null |> unbox<string>
                            v1272
#endif
                            
#if FABLE_COMPILER_PYTHON
                            let v1273 : string = null |> unbox<string>
                            v1273
#endif
                            
#else
                            let v1274 : string = "^\\\\\\\\\\?\\\\"
                            let v1275 : string = System.Text.RegularExpressions.Regex.Replace (v1221, v1274, v254)
                            v1275
#endif
                            |> fun x -> _v1259 <- Some x
                            let v1276 : string = _v1259.Value
                            let v1277 : string = $"{v1276.[0] |> string |> _.ToLower()}{v1276.[1..]}"
                            let v1278 : string = v1277.Replace (v256, v257)
                            v1278
                    let v1280 : string option = None
                    let v1281 : System.Threading.CancellationToken option = None
                    let v1282 : (struct (string * string) []) = [||]
                    let v1283 : (struct (bool * string * int32) -> Async<unit>) option = None
                    let v1284 : string = $"pwsh -c \"(Get-FileHash \\\"{v1279}\\\" -Algorithm SHA256).Hash\""
                    let v1285 : struct (int32 * string) option = None
                    let v1286 : bool = true in let mutable _v1285 = v1285
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1287 : string = method42(v1281, v1284, v1282, v1283, v1280)
                    let struct (v1288 : string, v1289 : string) = method43()
                    let v1290 : int32 = v1287.Length
                    let v1291 : (char []) = Array.zeroCreate<char> (v1290)
                    let v1292 : Mut5 = {l0 = 0} : Mut5
                    while method30(v1290, v1292) do
                        let v1294 : int32 = v1292.l0
                        let v1295 : char = v1287.[int v1294]
                        v1291.[int v1294] <- v1295
                        let v1296 : int32 = v1294 + 1
                        v1292.l0 <- v1296
                        ()
                    let v1297 : ((char []) -> char list) = Array.toList
                    let v1298 : char list = v1297 v1291
                    let v1299 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                    let v1300 : (char -> (UH0 -> UH0)) = method44()
                    let v1301 : (char list -> (UH0 -> UH0)) = v1299 v1300
                    let v1302 : (UH0 -> UH0) = v1301 v1298
                    let v1303 : UH0 = UH0_0
                    let v1304 : UH0 = v1302 v1303
                    let v1305 : US8 = US8_0
                    let struct (v1306 : string, v1307 : string) = method45(v1289, v1288, v1304, v1305)
                    let v1308 : (string []) = method46(v1307)
                    let v1309 : string = "$0.to_vec()"
                    let v1310 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v1308 v1309
                    let v1311 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                    let v1312 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1310, v404) v1311
                    let v1313 : US0 = US0_1
                    let v1314 : (unit -> string) = closure29(v1281, v1284, v1282, v1283, v1280, v1306, v1312)
                    let v1315 : (unit -> string) = method51()
                    method3(v1313, v1314, v1315)
                    let v1316 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method52(v1281, v1284, v1282, v1283, v1280, v1306, v1312)
                    let v1317 : string = "futures_lite::future::block_on($0)"
                    let v1318 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v1316 v1317
                    let (a, b) = v1318
                    let v1319 : int32 = a
                    let v1320 : string = b
                    struct (v1319, v1320)
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let struct (v1321 : int32, v1322 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1321, v1322)
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let struct (v1323 : int32, v1324 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1323, v1324)
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let struct (v1325 : int32, v1326 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1325, v1326)
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let struct (v1327 : int32, v1328 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1327, v1328)
#endif
                    
#else
                    let v1329 : Async<struct (int32 * string)> option = None
                    let v1330 : bool = true in let mutable _v1329 = v1329
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1331 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1331
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1332 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1332
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1333 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1333
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1334 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1334
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1335 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1335
#endif
                    
#else
                    let v1336 : Async<struct (int32 * string)> option = None
                    let v1337 : bool = true in let mutable _v1336 = v1336
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1338 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1338
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1339 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1339
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1340 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1340
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1341 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1341
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1342 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1342
#endif
                    
#else
                    let v1343 : Async<struct (int32 * string)> option = None
                    let mutable _v1343 = v1343
                    async {
                    let struct (v1344 : string, v1345 : string) = method43()
                    let v1346 : int32 = v1284.Length
                    let v1347 : (char []) = Array.zeroCreate<char> (v1346)
                    let v1348 : Mut5 = {l0 = 0} : Mut5
                    while method30(v1346, v1348) do
                        let v1350 : int32 = v1348.l0
                        let v1351 : char = v1284.[int v1350]
                        v1347.[int v1350] <- v1351
                        let v1352 : int32 = v1350 + 1
                        v1348.l0 <- v1352
                        ()
                    let v1353 : ((char []) -> char list) = Array.toList
                    let v1354 : char list = v1353 v1347
                    let v1355 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                    let v1356 : (char -> (UH0 -> UH0)) = method44()
                    let v1357 : (char list -> (UH0 -> UH0)) = v1355 v1356
                    let v1358 : (UH0 -> UH0) = v1357 v1354
                    let v1359 : UH0 = UH0_0
                    let v1360 : UH0 = v1358 v1359
                    let v1361 : US8 = US8_0
                    let struct (v1362 : string, v1363 : string) = method45(v1345, v1344, v1360, v1361)
                    let v1364 : (string -> US4) = method22()
                    let v1365 : US4 = US4_1
                    let v1366 : US4 = v1280 |> Option.map v1364 |> Option.defaultValue v1365 
                    let v1369 : string =
                        match v1366 with
                        | US4_1 -> (* None *)
                            v254
                        | US4_0(v1367) -> (* Some *)
                            v1367
                    let v1370 : US0 = US0_1
                    let v1371 : (unit -> string) = closure45(v1281, v1284, v1282, v1283, v1280)
                    let v1372 : (unit -> string) = method51()
                    method3(v1370, v1371, v1372)
                    let v1373 : System.Text.Encoding = System.Text.Encoding.UTF8
                    let v1374 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v1363, StandardOutputEncoding = v1373, WorkingDirectory = v1369, FileName = v1362, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                    let v1375 : int32 = v1282.Length
                    let v1376 : Mut5 = {l0 = 0} : Mut5
                    while method30(v1375, v1376) do
                        let v1378 : int32 = v1376.l0
                        let struct (v1379 : string, v1380 : string) = v1282.[int v1378]
                        v1374.EnvironmentVariables.[v1379] <- v1380 
                        let v1381 : int32 = v1378 + 1
                        v1376.l0 <- v1381
                        ()
                    let v1382 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1374)
                    use v1382 = v1382 
                    let v1383 : System.Diagnostics.Process = v1382 
                    let v1384 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                    let v1385 : System.Collections.Concurrent.ConcurrentStack<string> = v1384 ()
                    let v1386 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure46(v1281, v1284, v1282, v1283, v1280, v1383, v1385)
                    v1383.OutputDataReceived.Add v1386 
                    let v1387 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure49(v1281, v1284, v1282, v1283, v1280, v1383, v1385)
                    v1383.ErrorDataReceived.Add v1387 
                    let v1388 : (unit -> bool) = v1383.Start
                    let v1389 : bool = v1388 ()
                    let v1390 : bool = v1389 = false
                    if v1390 then
                        let v1391 : string = $"execute_with_options_async / process_start error"
                        failwith<unit> v1391
                    let v1392 : (unit -> unit) = v1383.BeginErrorReadLine
                    v1392 ()
                    let v1393 : (unit -> unit) = v1383.BeginOutputReadLine
                    v1393 ()
                    let v1394 : (System.Threading.CancellationToken -> US16) = method71()
                    let v1395 : US16 = US16_1
                    let v1396 : US16 = v1281 |> Option.map v1394 |> Option.defaultValue v1395 
                    let v1400 : System.Threading.CancellationToken =
                        match v1396 with
                        | US16_1 -> (* None *)
                            let v1398 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                            v1398
                        | US16_0(v1397) -> (* Some *)
                            v1397
                    let v1401 : Async<System.Threading.CancellationToken> option = None
                    let v1402 : bool = true in let mutable _v1401 = v1401
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1403 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1403
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1404 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1404
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1405 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1405
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1406 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1406
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1407 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1407
#endif
                    
#else
                    let v1408 : Async<System.Threading.CancellationToken> option = None
                    let v1409 : bool = true in let mutable _v1408 = v1408
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1410 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1410
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1411 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1411
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1412 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1412
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1413 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1413
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1414 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1414
#endif
                    
#else
                    let v1415 : Async<System.Threading.CancellationToken> option = None
                    let mutable _v1415 = v1415
                    async {
                    let v1416 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v1416 = v1416 
                    let v1417 : System.Threading.CancellationToken = v1416 
                    let v1418 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v1419 : (System.Threading.CancellationToken []) = [|v1417; v1418; v1400|]
                    let v1420 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v1421 : System.Threading.CancellationTokenSource = v1420 v1419
                    let v1422 : System.Threading.CancellationToken = v1421.Token
                    return v1422 
                    }
                    |> fun x -> _v1415 <- Some x
                    let v1423 : Async<System.Threading.CancellationToken> = _v1415 |> Option.get
                    v1423
#endif
                    |> fun x -> _v1408 <- Some x
                    let v1424 : Async<System.Threading.CancellationToken> = _v1408.Value
                    v1424
#endif
                    |> fun x -> _v1401 <- Some x
                    let v1425 : Async<System.Threading.CancellationToken> = _v1401.Value
                    let! v1425 = v1425 
                    let v1426 : System.Threading.CancellationToken = v1425 
                    let v1427 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1426.Register
                    let v1428 : (unit -> unit) = closure51(v1383)
                    let v1429 : System.Threading.CancellationTokenRegistration = v1427 v1428
                    use v1429 = v1429 
                    let v1430 : System.Threading.CancellationTokenRegistration = v1429 
                    let v1431 : Async<int32> option = None
                    let v1432 : bool = true in let mutable _v1431 = v1431
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1433 : Async<int32> = null |> unbox<Async<int32>>
                    v1433
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1434 : Async<int32> = null |> unbox<Async<int32>>
                    v1434
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1435 : Async<int32> = null |> unbox<Async<int32>>
                    v1435
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1436 : Async<int32> = null |> unbox<Async<int32>>
                    v1436
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1437 : Async<int32> = null |> unbox<Async<int32>>
                    v1437
#endif
                    
#else
                    let v1438 : Async<int32> option = None
                    let mutable _v1438 = v1438
                    async {
                    try
                    let v1439 : System.Threading.Tasks.Task = v1383.WaitForExitAsync v1426 
                    let v1440 : Async<unit> option = None
                    let v1441 : bool = true in let mutable _v1440 = v1440
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1442 : Async<unit> = null |> unbox<Async<unit>>
                    v1442
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1443 : Async<unit> = null |> unbox<Async<unit>>
                    v1443
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1444 : Async<unit> = null |> unbox<Async<unit>>
                    v1444
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1445 : Async<unit> = null |> unbox<Async<unit>>
                    v1445
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1446 : Async<unit> = null |> unbox<Async<unit>>
                    v1446
#endif
                    
#else
                    let v1447 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1448 : Async<unit> = v1447 v1439
                    v1448
#endif
                    |> fun x -> _v1440 <- Some x
                    let v1449 : Async<unit> = _v1440.Value
                    do! v1449 
                    let v1450 : int32 = v1383.ExitCode
                    return v1450 
                    with ex ->
                    let v1451 : exn = ex
                    let v1452 : string option = None
                    let v1453 : bool = true in let mutable _v1452 = v1452
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1454 : string = $"%A{v1451}"
                    v1454
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1455 : string = $"%A{v1451}"
                    v1455
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1456 : string = $"%A{v1451}"
                    v1456
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1457 : string = $"%A{v1451}"
                    v1457
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1458 : string = $"%A{v1451}"
                    v1458
#endif
                    
#else
                    let v1459 : string = $"{v1451.GetType ()}: {v1451.Message}"
                    v1459
#endif
                    |> fun x -> _v1452 <- Some x
                    let v1460 : string = _v1452.Value
                    let v1461 : (string -> unit) = v1385.Push
                    v1461 v1460
                    let v1462 : System.Threading.Tasks.TaskCanceledException = v1451 |> unbox<System.Threading.Tasks.TaskCanceledException>
                    let v1463 : US0 = US0_3
                    let v1464 : (unit -> string) = closure52(v1462)
                    let v1465 : (unit -> string) = method51()
                    method3(v1463, v1464, v1465)
                    return -2147483648 
                    (*
                    *)
                    }
                    |> fun x -> _v1438 <- Some x
                    let v1466 : Async<int32> = _v1438 |> Option.get
                    v1466
#endif
                    |> fun x -> _v1431 <- Some x
                    let v1467 : Async<int32> = _v1431.Value
                    let! v1467 = v1467 
                    let v1468 : int32 = v1467 
                    let v1469 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                    let v1470 : string seq = v1469 v1385
                    let v1471 : string = method72()
                    let v1472 : (string -> (string seq -> string)) = String.concat
                    let v1473 : (string seq -> string) = v1472 v1471
                    let v1474 : string = v1473 v1470
                    let v1475 : US0 = US0_1
                    let v1476 : (unit -> string) = closure53(v1468, v1474)
                    let v1477 : (unit -> string) = method51()
                    method3(v1475, v1476, v1477)
                    return struct (v1468, v1474) 
                    }
                    |> fun x -> _v1343 <- Some x
                    let v1478 : Async<struct (int32 * string)> = _v1343 |> Option.get
                    v1478
#endif
                    |> fun x -> _v1336 <- Some x
                    let v1479 : Async<struct (int32 * string)> = _v1336.Value
                    v1479
#endif
                    |> fun x -> _v1329 <- Some x
                    let v1480 : Async<struct (int32 * string)> = _v1329.Value
                    let v1481 : struct (int32 * string) option = None
                    let v1482 : bool = true in let mutable _v1481 = v1481
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let struct (v1483 : int32, v1484 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1483, v1484)
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let struct (v1485 : int32, v1486 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1485, v1486)
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let struct (v1487 : int32, v1488 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1487, v1488)
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let struct (v1489 : int32, v1490 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1489, v1490)
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let struct (v1491 : int32, v1492 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1491, v1492)
#endif
                    
#else
                    let v1493 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                    let struct (v1494 : int32, v1495 : string) = v1493 v1480
                    struct (v1494, v1495)
#endif
                    |> fun x -> _v1481 <- Some x
                    let struct (v1496 : int32, v1497 : string) = _v1481.Value
                    struct (v1496, v1497)
#endif
                    |> fun x -> _v1285 <- Some x
                    let struct (v1498 : int32, v1499 : string) = _v1285.Value
                    v1499
                else
                    v254
            let v1501 : bool = v1145 <> v1500
            if v1501 then
                let v1502 : struct (string * (string -> US17)) list = []
                let v1503 : string = "hangul.md"
                let v1504 : (string -> US17) = closure54(v668, v1221, v0, v1)
                let v1505 : struct (string * (string -> US17)) list = struct (v1503, v1504) :: v1502 
                let v1506 : string = "epub"
                let v1507 : (string -> US17) = closure57(v668, v1221, v3)
                let v1508 : struct (string * (string -> US17)) list = struct (v1506, v1507) :: v1505 
                let v1509 : string = "pdf"
                let v1510 : struct (string * (string -> US17)) list = struct (v1509, v1507) :: v1508 
                let v1511 : string = "html"
                let v1512 : struct (string * (string -> US17)) list = struct (v1511, v1507) :: v1510 
                let v1513 : (struct (string * (string -> US17)) list -> (struct (string * (string -> US17)) [])) = List.toArray
                let v1514 : (struct (string * (string -> US17)) []) = v1513 v1512
                let v1515 : string = "$0.to_vec()"
                let v1516 : Vec<struct (string * (string -> US17))> = Fable.Core.RustInterop.emitRustExpr v1514 v1515
                let v1517 : string = "rayon::iter::IntoParallelIterator::into_par_iter(v1516)"
                let v1518 : rayon_vec_IntoIter<struct (string * (string -> US17))> = Fable.Core.RustInterop.emitRustExpr () v1517
                let v1519 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
                let v1520 : (struct (string * (string -> US17)) -> Result<string, (string * string)> option) = closure60()
                let v1521 : rayon_iter_Map<rayon_vec_IntoIter<struct (string * (string -> US17))>> = Fable.Core.RustInterop.emitRustExpr struct (v1518, v1520) v1519
                let v1522 : string = "rayon::iter::ParallelIterator::collect($0)"
                let v1523 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1521 v1522
                let v1524 : US0 = US0_2
                let v1525 : (unit -> string) = closure61()
                let v1526 : (unit -> string) = closure62(v259, v293, v370, v592, v591, v889, v888, v1145, v1500, v1523)
                method3(v1524, v1525, v1526)
                let v1527 : unit option = None
                let v1528 : bool = true in let mutable _v1527 = v1527
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1529 : string = method73(v1221)
                let v1530 : string = "std::fs::copy(&*v668, &*v1529)"
                let v1531 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v1530
                let v1532 : string = "$0.unwrap()"
                let v1533 : uint64 = Fable.Core.RustInterop.emitRustExpr v1531 v1532
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
                System.IO.File.Copy (v668, v1221, true)
                ()
#endif
                |> fun x -> _v1527 <- Some x
                _v1527.Value
                v1523
            else
                let v1534 : (Result<string, (string * string)> option []) = [||]
                let v1535 : string = "$0.to_vec()"
                let v1536 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1534 v1535
                v1536
        else
            let v1538 : (Result<string, (string * string)> option []) = [||]
            let v1539 : string = "$0.to_vec()"
            let v1540 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1538 v1539
            v1540
    let v1542 : (string * Vec<Result<string, (string * string)> option>) = v293, v1541
    let v1543 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v1542
    v1543
and closure63 () () : string =
    let v0 : string = "documents.run"
    v0
and closure64 (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) () : string =
    let v1 : string = "$0.len()"
    let v2 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"result_len: {v2} / {v3 ()}"
    v4
and method74 (v0 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>) : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> =
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
    let v25 : (unit -> string) = closure63()
    let v26 : (unit -> string) = closure64(v23)
    method3(v24, v25, v26)
    let v27 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Ok v23
    let v28 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = method74(v27)
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
