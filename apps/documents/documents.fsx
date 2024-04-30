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
#if FABLE_COMPILER
[<CompilationRepresentation (CompilationRepresentationFlags.ModuleSuffix)>]
module System =
 module Diagnostics =
  type Process = unit
  type DataReceivedEventArgs = unit
#endif
type IFsExistsSync = abstract existsSync: path: string -> bool
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
and [<Struct>] US7 =
    | US7_0 of f0_0 : string
    | US7_1
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v13 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v13
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : string = null |> unbox<string>
    v14
#endif
    
#if FABLE_COMPILER_PYTHON
    let v15 : string = null |> unbox<string>
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v36 : (int64 -> US2) = method4()
    let v37 : US2 = US2_1
    let v38 : US2 = v7 |> Option.map v36 |> Option.defaultValue v37 
    let v56 : System.DateTime =
        match v38 with
        | US2_1 -> (* None *)
            let v54 : System.DateTime = System.DateTime.Now
            v54
        | US2_0(v39) -> (* Some *)
            let v40 : System.DateTime = System.DateTime.Now
            let v41 : (System.DateTime -> int64) = _.Ticks
            let v42 : int64 = v41 v40
            let v43 : int64 = v42 - v39
            let v44 : System.TimeSpan = System.TimeSpan v43 
            let v45 : (System.TimeSpan -> int32) = _.Hours
            let v46 : int32 = v45 v44
            let v47 : (System.TimeSpan -> int32) = _.Minutes
            let v48 : int32 = v47 v44
            let v49 : (System.TimeSpan -> int32) = _.Seconds
            let v50 : int32 = v49 v44
            let v51 : (System.TimeSpan -> int32) = _.Milliseconds
            let v52 : int32 = v51 v44
            let v53 : System.DateTime = System.DateTime (1, 1, 1, v46, v48, v50, v52)
            v53
    let v57 : string = "HH:mm:ss"
    let v58 : string = v56.ToString v57 
    v58
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v59 : string = method5()
    v59
#endif
    
#if FABLE_COMPILER_PYTHON
    let v60 : string = method5()
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
    let v74 : string = v73.PadRight (7, ' ')
    let v75 : string option = None
    let v76 : bool = true in let mutable _v75 = v75
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    v74
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    v74
#endif
    
#if FABLE_COMPILER_PYTHON
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
        System.Console.WriteLine v22 
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
and method13 (v0 : string) : string =
    v0
and method14 (v0 : string) : string =
    v0
and method15 (v0 : string) : string =
    v0
and method16 (v0 : string) : string =
    v0
and method17 () : string =
    let v0 : string = "^\\\\\\\\\\?\\\\"
    v0
and method18 (v0 : string) : string =
    v0
and method19 () : string =
    let v0 : string = ""
    v0
and method20 (v0 : int32, v1 : Mut4) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method21 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method22 (v0 : string) : string =
    v0
and method23 (v0 : string) : string =
    v0
and closure10 () () : string =
    let v0 : string = "documents.run"
    v0
and closure11 (v0 : string, v1 : string, v2 : string, v3 : string) () : string =
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"source_dir: {v1} / dist_dir: {v2} / cache_dir: {v3} / hangul_spec: %A{v0} / {v4 ()}"
    v5
and method27 (v0 : async_walkdir_DirEntry) : async_walkdir_DirEntry =
    v0
and closure13 () (v0 : std_io_Error) : std_string_String =
    let v1 : std_string_String option = None
    let v2 : bool = true in let mutable _v1 = v1
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10
#endif
    
#if FABLE_COMPILER_PYTHON
    let v11 : std_string_String = null |> unbox<std_string_String>
    v11
#endif
    |> fun x -> _v1 <- Some x
    let v12 : std_string_String = _v1.Value
    v12
and method28 () : (std_io_Error -> std_string_String) =
    closure13()
and closure14 () (v0 : std_fs_FileType) : US5 =
    US5_0(v0)
and closure15 () (v0 : std_string_String) : US5 =
    US5_1(v0)
and method29 (v0 : std_fs_FileType) : std_fs_FileType =
    v0
and method30 (v0 : US4) : US4 =
    v0
and method26 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<Send<Dyn<std_future_Future<US4>>>>> =
    let v1 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : async_walkdir_DirEntry = method27(v0)
    let v3 : string = "Box::pin(async_walkdir::DirEntry::file_type(&v2))"
    let v4 : std_pin_Pin<Box<Send<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>>>> = Fable.Core.RustInterop.emitRustExpr () v3
    let v5 : string = "v4.await"
    let v6 : Result<std_fs_FileType, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v5
    let v7 : (std_io_Error -> std_string_String) = method28()
    let v8 : string = "$0.map_err(|x| $1(x))"
    let v9 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6, v7) v8
    let v10 : (std_fs_FileType -> US5) = closure14()
    let v11 : (std_string_String -> US5) = closure15()
    let v12 : US5 = match v9 with Ok x -> v10 x | Error x -> v11 x
    let v73 : US4 =
        match v12 with
        | US5_0(v13) -> (* Ok *)
            let v14 : std_fs_FileType = method29(v13)
            let v15 : string = "std::fs::FileType::is_dir(&v14)"
            let v16 : bool = Fable.Core.RustInterop.emitRustExpr () v15
            if v16 then
                US4_0
            else
                let v18 : string = "async_walkdir::DirEntry::path(&$0)"
                let v19 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v0 v18
                let v20 : string = "$0.display()"
                let v21 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v19 v20
                let v22 : std_string_String option = None
                let v23 : bool = true in let mutable _v22 = v22
                
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
                
#if !FABLE_COMPILER && !WASM && !CONTRACT
                let v30 : std_string_String = null |> unbox<std_string_String>
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
                    US4_0
                else
                    US4_2
        | _ ->
            let v46 : string = "async_walkdir::DirEntry::path(&$0)"
            let v47 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v0 v46
            let v48 : string = "$0.display()"
            let v49 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v47 v48
            let v50 : std_string_String option = None
            let v51 : bool = true in let mutable _v50 = v50
            
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
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v58 : std_string_String = null |> unbox<std_string_String>
            v58
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v59 : std_string_String = null |> unbox<std_string_String>
            v59
#endif
            
#if FABLE_COMPILER_PYTHON
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
                US4_0
            else
                US4_2
    let v74 : US4 = method30(v73)
    let v75 : string = "v74 }})"
    Fable.Core.RustInterop.emitRustExpr () v75
    let v76 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v76
    let v77 : string = "__result"
    let v78 : std_pin_Pin<Box<Send<Dyn<std_future_Future<US4>>>>> = Fable.Core.RustInterop.emitRustExpr () v77
    v78
and method31 (v0 : async_walkdir_Filtering) : async_walkdir_Filtering =
    v0
and method25 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>> =
    let v1 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : std_pin_Pin<Box<Send<Dyn<std_future_Future<US4>>>>> = method26(v0)
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
    let v14 : async_walkdir_Filtering = method31(v13)
    let v15 : string = "v14 }})"
    Fable.Core.RustInterop.emitRustExpr () v15
    let v16 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v16
    let v17 : string = "__result"
    let v18 : std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>> = Fable.Core.RustInterop.emitRustExpr () v17
    v18
and closure12 () (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>> =
    method25(v0)
and closure17 () (v0 : async_walkdir_DirEntry) : US6 =
    US6_0(v0)
and closure18 () (v0 : std_string_String) : US6 =
    US6_1(v0)
and closure19 () () : string =
    let v0 : string = "documents.run / stream_filter_map"
    v0
and closure20 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and closure16 () (v0 : Result<async_walkdir_DirEntry, std_io_Error>) : string option =
    let v1 : (std_io_Error -> std_string_String) = method28()
    let v2 : string = "$0.map_err(|x| $1(x))"
    let v3 : Result<async_walkdir_DirEntry, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v2
    let v4 : (async_walkdir_DirEntry -> US6) = closure17()
    let v5 : (std_string_String -> US6) = closure18()
    let v6 : US6 = match v3 with Ok x -> v4 x | Error x -> v5 x
    let v33 : US7 =
        match v6 with
        | US6_1(v27) -> (* Error *)
            let v28 : US0 = US0_4
            let v29 : (unit -> string) = closure19()
            let v30 : (unit -> string) = closure20(v27)
            method3(v28, v29, v30)
            US7_1
        | US6_0(v7) -> (* Ok *)
            let v8 : string = "async_walkdir::DirEntry::path(&$0)"
            let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8
            let v10 : string = "$0.display()"
            let v11 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v9 v10
            let v12 : std_string_String option = None
            let v13 : bool = true in let mutable _v12 = v12
            
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
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v20 : std_string_String = null |> unbox<std_string_String>
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
            |> fun x -> _v12 <- Some x
            let v23 : std_string_String = _v12.Value
            let v24 : string = "fable_library_rust::String_::fromString($0)"
            let v25 : string = Fable.Core.RustInterop.emitRustExpr v23 v24
            US7_0(v25)
    match v33 with
    | US7_1 -> (* None *)
        let v36 : string option = None
        v36
    | US7_0(v34) -> (* Some *)
        let v35 : string option = Some v34 
        v35
and method32 () : (Result<async_walkdir_DirEntry, std_io_Error> -> string option) =
    closure16()
and closure21 () () : string =
    let v0 : string = "documents.run"
    v0
and closure22 (v0 : Vec<string>) () : string =
    let v1 : string = "$0.len()"
    let v2 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"files_len: {v2} / {v3 ()}"
    v4
and method33 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : string option) : string =
    v1
and method34 () : struct (string * string) =
    let v0 : string = ""
    struct (v0, v0)
and closure25 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure24 () (v0 : char) : (UH0 -> UH0) =
    closure25(v0)
and method35 () : (char -> (UH0 -> UH0)) =
    closure24()
and method36 (v0 : string, v1 : string, v2 : UH0, v3 : US8) : struct (string * string) =
    match v2 with
    | UH0_1(v4, v5) -> (* Cons *)
        let v6 : bool = '"' = v4
        if v6 then
            let v8 : bool = v1 = ""
            if v8 then
                let v9 : US9 = US9_0
                let v10 : US8 = US8_1(v9)
                method36(v0, v1, v5, v10)
            else
                match v3 with
                | US8_2 -> (* Arguments *)
                    let v38 : string = $"{v0}{v4}"
                    let v39 : US8 = US8_2
                    method36(v38, v1, v5, v39)
                | US8_1(v13) -> (* Path *)
                    match v13 with
                    | US9_0 -> (* Quoted *)
                        let v14 : US9 = US9_1
                        let v15 : US8 = US8_1(v14)
                        method36(v0, v1, v5, v15)
                    | _ ->
                        let v18 : bool = ' ' = v4
                        if v18 then
                            let v19 : US8 = US8_2
                            method36(v0, v1, v5, v19)
                        else
                            let v22 : string = $"{v1}{v4}"
                            method36(v0, v22, v5, v3)
                | US8_0 -> (* Start *)
                    let v29 : bool = ' ' = v4
                    if v29 then
                        let v30 : US8 = US8_2
                        method36(v0, v1, v5, v30)
                    else
                        let v33 : string = $"{v1}{v4}"
                        method36(v0, v33, v5, v3)
        else
            let v50 : bool = ''' = v4
            if v50 then
                let v52 : bool = v1 = ""
                if v52 then
                    let v53 : US9 = US9_0
                    let v54 : US8 = US8_1(v53)
                    method36(v0, v1, v5, v54)
                else
                    match v3 with
                    | US8_2 -> (* Arguments *)
                        let v82 : string = $"{v0}{v4}"
                        let v83 : US8 = US8_2
                        method36(v82, v1, v5, v83)
                    | US8_1(v57) -> (* Path *)
                        match v57 with
                        | US9_0 -> (* Quoted *)
                            let v58 : US9 = US9_1
                            let v59 : US8 = US8_1(v58)
                            method36(v0, v1, v5, v59)
                        | _ ->
                            let v62 : bool = ' ' = v4
                            if v62 then
                                let v63 : US8 = US8_2
                                method36(v0, v1, v5, v63)
                            else
                                let v66 : string = $"{v1}{v4}"
                                method36(v0, v66, v5, v3)
                    | US8_0 -> (* Start *)
                        let v73 : bool = ' ' = v4
                        if v73 then
                            let v74 : US8 = US8_2
                            method36(v0, v1, v5, v74)
                        else
                            let v77 : string = $"{v1}{v4}"
                            method36(v0, v77, v5, v3)
            else
                match v3 with
                | US8_2 -> (* Arguments *)
                    let v126 : string = $"{v0}{v4}"
                    let v127 : US8 = US8_2
                    method36(v126, v1, v5, v127)
                | US8_1(v94) -> (* Path *)
                    match v94 with
                    | US9_0 -> (* Quoted *)
                        let v95 : bool = ' ' = v4
                        if v95 then
                            let v96 : string = $"{v1} "
                            let v97 : US9 = US9_0
                            let v98 : US8 = US8_1(v97)
                            method36(v0, v96, v5, v98)
                        else
                            let v101 : string = $"{v1}{v4}"
                            method36(v0, v101, v5, v3)
                    | _ ->
                        let v106 : bool = ' ' = v4
                        if v106 then
                            let v107 : US8 = US8_2
                            method36(v0, v1, v5, v107)
                        else
                            let v110 : string = $"{v1}{v4}"
                            method36(v0, v110, v5, v3)
                | US8_0 -> (* Start *)
                    let v117 : bool = ' ' = v4
                    if v117 then
                        let v118 : US8 = US8_2
                        method36(v0, v1, v5, v118)
                    else
                        let v121 : string = $"{v1}{v4}"
                        method36(v0, v121, v5, v3)
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
and closure26 () (v0 : string) : US7 =
    US7_0(v0)
and method38 () : (string -> US7) =
    closure26()
and method41 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = method41(v3, v1)
        UH1_1(v2, v4)
    | UH1_0 -> (* Nil *)
        v1
and method40 (v0 : string, v1 : UH1, v2 : UH0, v3 : US10) : struct (UH1 * string) =
    match v3 with
    | US10_2(v44) -> (* Escaped *)
        match v2 with
        | UH0_1(v45, v46) -> (* Cons *)
            let v47 : bool = '\\' = v45
            if v47 then
                let v48 : char = '\\'
                let v49 : US10 = US10_1(v48)
                method39(v0, v1, v46, v3, v49)
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
                        method40(v0, v1, v46, v3)
                    else
                        let v57 : string = $"{v0}\""
                        let v58 : US10 = US10_2(v44)
                        method39(v57, v1, v46, v3, v58)
                else
                    let v63 : bool = ' ' = v45
                    if v63 then
                        let v64 : string = $"{v0} "
                        method40(v64, v1, v46, v3)
                    else
                        let v67 : bool = 1uy = v44
                        if v67 then
                            let v68 : bool = v3 <> v3
                            if v68 then
                                let v69 : string = $"{v0}\{v45}"
                                method40(v69, v1, v46, v3)
                            else
                                let v72 : string = $"{v0}{v45}"
                                method40(v72, v1, v46, v3)
                        else
                            let v77 : string = $"{v0}{v45}"
                            method40(v77, v1, v46, v3)
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
                        method41(v1, v92)
                struct (v94, v0)
            else
                let v96 : bool = v0 = ""
                let v100 : UH1 =
                    if v96 then
                        v1
                    else
                        let v97 : UH1 = UH1_0
                        let v98 : UH1 = UH1_1(v0, v97)
                        method41(v1, v98)
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
                        method39(v0, v1, v108, v3, v112)
                    else
                        let v115 : bool = '\\' = v105
                        if v115 then
                            let v116 : US10 = US10_2(0uy)
                            let v117 : bool = v3 <> v116
                            if v117 then
                                let v118 : string = $"{v0}\""
                                let v119 : char = '"'
                                let v120 : US10 = US10_1(v119)
                                method39(v118, v1, v108, v3, v120)
                            else
                                let v123 : US10 = US10_1('\\')
                                let v124 : bool = v3 = v123
                                if v124 then
                                    let v125 : string = $"{v0}\""
                                    let v126 : char = '"'
                                    let v127 : US10 = US10_1(v126)
                                    method39(v125, v1, v108, v3, v127)
                                else
                                    let v130 : US10 = US10_0
                                    method39(v0, v1, v108, v3, v130)
                        else
                            let v137 : bool = '\\' = v107
                            if v137 then
                                let v138 : uint8 = 1uy
                                let v139 : US10 = US10_2(v138)
                                method39(v0, v1, v108, v3, v139)
                            else
                                let v142 : US10 = US10_2(0uy)
                                let v143 : bool = v3 = v142
                                if v143 then
                                    let v144 : string = $"{v0}\""
                                    let v145 : char = '"'
                                    let v146 : US10 = US10_1(v145)
                                    method39(v144, v1, v108, v3, v146)
                                else
                                    let v149 : UH1 = UH1_0
                                    let v150 : UH1 = UH1_1(v0, v149)
                                    let v151 : UH1 = method41(v1, v150)
                                    let v152 : string = ""
                                    let v153 : US10 = US10_0
                                    method39(v152, v151, v108, v3, v153)
                else
                    let v164 : bool = '\\' = v105
                    if v164 then
                        let v165 : bool = '\\' = v107
                        if v165 then
                            let v166 : uint8 = 1uy
                            let v167 : US10 = US10_2(v166)
                            method39(v0, v1, v108, v3, v167)
                        else
                            let v170 : bool = ' ' = v107
                            if v170 then
                                let v171 : string = $"{v0} "
                                method40(v171, v1, v108, v3)
                            else
                                let v174 : string = $"{v0}{v107}"
                                method40(v174, v1, v108, v3)
                    else
                        let v181 : bool = '\\' = v107
                        if v181 then
                            let v182 : uint8 = 1uy
                            let v183 : US10 = US10_2(v182)
                            method39(v0, v1, v108, v3, v183)
                        else
                            let v186 : bool = ' ' = v107
                            if v186 then
                                let v187 : string = $"{v0} "
                                method40(v187, v1, v108, v3)
                            else
                                let v190 : string = $"{v0}{v107}"
                                method40(v190, v1, v108, v3)
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
                            method41(v1, v205)
                    struct (v207, v0)
                else
                    let v209 : bool = v0 = ""
                    let v213 : UH1 =
                        if v209 then
                            v1
                        else
                            let v210 : UH1 = UH1_0
                            let v211 : UH1 = UH1_1(v0, v210)
                            method41(v1, v211)
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
                            method39(v224, v1, v220, v3, v226)
                        else
                            let v229 : US10 = US10_1('\\')
                            let v230 : bool = v3 = v229
                            if v230 then
                                let v231 : string = $"{v0}\""
                                let v232 : char = '"'
                                let v233 : US10 = US10_1(v232)
                                method39(v231, v1, v220, v3, v233)
                            else
                                let v236 : US10 = US10_0
                                method39(v0, v1, v220, v3, v236)
                    else
                        let v243 : bool = '\\' = v219
                        if v243 then
                            let v244 : uint8 = 1uy
                            let v245 : US10 = US10_2(v244)
                            method39(v0, v1, v220, v3, v245)
                        else
                            let v248 : bool = ' ' = v219
                            if v248 then
                                let v249 : string = $"{v0} "
                                method40(v249, v1, v220, v3)
                            else
                                let v252 : string = $"{v0}{v219}"
                                method40(v252, v1, v220, v3)
                | _ ->
                    let v262 : bool = v0 = ""
                    let v266 : UH1 =
                        if v262 then
                            v1
                        else
                            let v263 : UH1 = UH1_0
                            let v264 : UH1 = UH1_1(v0, v263)
                            method41(v1, v264)
                    struct (v266, v0)
            else
                match v2 with
                | UH0_1(v269, v270) -> (* Cons *)
                    let v271 : bool = '\\' = v269
                    if v271 then
                        let v272 : uint8 = 1uy
                        let v273 : US10 = US10_2(v272)
                        method39(v0, v1, v270, v3, v273)
                    else
                        let v276 : bool = '"' = v269
                        if v276 then
                            let v277 : US10 = US10_2(0uy)
                            let v278 : bool = v3 = v277
                            if v278 then
                                let v279 : string = $"{v0}\""
                                let v280 : char = '"'
                                let v281 : US10 = US10_1(v280)
                                method39(v279, v1, v270, v3, v281)
                            else
                                let v284 : UH1 = UH1_0
                                let v285 : UH1 = UH1_1(v0, v284)
                                let v286 : UH1 = method41(v1, v285)
                                let v287 : string = ""
                                let v288 : US10 = US10_0
                                method39(v287, v286, v270, v3, v288)
                        else
                            let v293 : bool = ' ' = v269
                            if v293 then
                                let v294 : string = $"{v0} "
                                method40(v294, v1, v270, v3)
                            else
                                let v297 : string = $"{v0}{v269}"
                                method40(v297, v1, v270, v3)
                | _ ->
                    let v307 : bool = v0 = ""
                    let v311 : UH1 =
                        if v307 then
                            v1
                        else
                            let v308 : UH1 = UH1_0
                            let v309 : UH1 = UH1_1(v0, v308)
                            method41(v1, v309)
                    struct (v311, v0)
    | US10_0 -> (* Start *)
        match v2 with
        | UH0_1(v4, v5) -> (* Cons *)
            let v6 : bool = '"' = v4
            if v6 then
                let v7 : string = ""
                let v8 : char = '"'
                let v9 : US10 = US10_1(v8)
                method39(v7, v1, v5, v3, v9)
            else
                let v12 : bool = '\\' = v4
                if v12 then
                    let v13 : uint8 = 0uy
                    let v14 : US10 = US10_2(v13)
                    method39(v0, v1, v5, v3, v14)
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
                                method41(v1, v21)
                        let v24 : string = ""
                        method40(v24, v23, v5, v3)
                    else
                        let v27 : string = $"{v0}{v4}"
                        method40(v27, v1, v5, v3)
        | _ ->
            let v37 : bool = v0 = ""
            let v41 : UH1 =
                if v37 then
                    v1
                else
                    let v38 : UH1 = UH1_0
                    let v39 : UH1 = UH1_1(v0, v38)
                    method41(v1, v39)
            struct (v41, v0)
and method39 (v0 : string, v1 : UH1, v2 : UH0, v3 : US10, v4 : US10) : struct (UH1 * string) =
    match v4 with
    | US10_2(v45) -> (* Escaped *)
        match v2 with
        | UH0_1(v46, v47) -> (* Cons *)
            let v48 : bool = '\\' = v46
            if v48 then
                let v49 : char = '\\'
                let v50 : US10 = US10_1(v49)
                method39(v0, v1, v47, v4, v50)
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
                        method40(v0, v1, v47, v4)
                    else
                        let v58 : string = $"{v0}\""
                        let v59 : US10 = US10_2(v45)
                        method39(v58, v1, v47, v4, v59)
                else
                    let v64 : bool = ' ' = v46
                    if v64 then
                        let v65 : string = $"{v0} "
                        method40(v65, v1, v47, v4)
                    else
                        let v68 : bool = 1uy = v45
                        if v68 then
                            let v69 : bool = v3 <> v4
                            if v69 then
                                let v70 : string = $"{v0}\{v46}"
                                method39(v70, v1, v47, v4, v3)
                            else
                                let v73 : string = $"{v0}{v46}"
                                method40(v73, v1, v47, v4)
                        else
                            let v78 : string = $"{v0}{v46}"
                            method40(v78, v1, v47, v4)
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
                        method41(v1, v93)
                struct (v95, v0)
            else
                let v97 : bool = v0 = ""
                let v101 : UH1 =
                    if v97 then
                        v1
                    else
                        let v98 : UH1 = UH1_0
                        let v99 : UH1 = UH1_1(v0, v98)
                        method41(v1, v99)
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
                        method39(v0, v1, v109, v4, v113)
                    else
                        let v116 : bool = '\\' = v106
                        if v116 then
                            let v117 : US10 = US10_2(0uy)
                            let v118 : bool = v3 <> v117
                            if v118 then
                                let v119 : string = $"{v0}\""
                                let v120 : char = '"'
                                let v121 : US10 = US10_1(v120)
                                method39(v119, v1, v109, v4, v121)
                            else
                                let v124 : US10 = US10_1('\\')
                                let v125 : bool = v3 = v124
                                if v125 then
                                    let v126 : string = $"{v0}\""
                                    let v127 : char = '"'
                                    let v128 : US10 = US10_1(v127)
                                    method39(v126, v1, v109, v4, v128)
                                else
                                    let v131 : US10 = US10_0
                                    method39(v0, v1, v109, v4, v131)
                        else
                            let v138 : bool = '\\' = v108
                            if v138 then
                                let v139 : uint8 = 1uy
                                let v140 : US10 = US10_2(v139)
                                method39(v0, v1, v109, v4, v140)
                            else
                                let v143 : US10 = US10_2(0uy)
                                let v144 : bool = v3 = v143
                                if v144 then
                                    let v145 : string = $"{v0}\""
                                    let v146 : char = '"'
                                    let v147 : US10 = US10_1(v146)
                                    method39(v145, v1, v109, v4, v147)
                                else
                                    let v150 : UH1 = UH1_0
                                    let v151 : UH1 = UH1_1(v0, v150)
                                    let v152 : UH1 = method41(v1, v151)
                                    let v153 : string = ""
                                    let v154 : US10 = US10_0
                                    method39(v153, v152, v109, v4, v154)
                else
                    let v165 : bool = '\\' = v106
                    if v165 then
                        let v166 : bool = '\\' = v108
                        if v166 then
                            let v167 : uint8 = 1uy
                            let v168 : US10 = US10_2(v167)
                            method39(v0, v1, v109, v4, v168)
                        else
                            let v171 : bool = ' ' = v108
                            if v171 then
                                let v172 : string = $"{v0} "
                                method40(v172, v1, v109, v4)
                            else
                                let v175 : string = $"{v0}{v108}"
                                method40(v175, v1, v109, v4)
                    else
                        let v182 : bool = '\\' = v108
                        if v182 then
                            let v183 : uint8 = 1uy
                            let v184 : US10 = US10_2(v183)
                            method39(v0, v1, v109, v4, v184)
                        else
                            let v187 : bool = ' ' = v108
                            if v187 then
                                let v188 : string = $"{v0} "
                                method40(v188, v1, v109, v4)
                            else
                                let v191 : string = $"{v0}{v108}"
                                method40(v191, v1, v109, v4)
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
                            method41(v1, v206)
                    struct (v208, v0)
                else
                    let v210 : bool = v0 = ""
                    let v214 : UH1 =
                        if v210 then
                            v1
                        else
                            let v211 : UH1 = UH1_0
                            let v212 : UH1 = UH1_1(v0, v211)
                            method41(v1, v212)
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
                            method39(v225, v1, v221, v4, v227)
                        else
                            let v230 : US10 = US10_1('\\')
                            let v231 : bool = v3 = v230
                            if v231 then
                                let v232 : string = $"{v0}\""
                                let v233 : char = '"'
                                let v234 : US10 = US10_1(v233)
                                method39(v232, v1, v221, v4, v234)
                            else
                                let v237 : US10 = US10_0
                                method39(v0, v1, v221, v4, v237)
                    else
                        let v244 : bool = '\\' = v220
                        if v244 then
                            let v245 : uint8 = 1uy
                            let v246 : US10 = US10_2(v245)
                            method39(v0, v1, v221, v4, v246)
                        else
                            let v249 : bool = ' ' = v220
                            if v249 then
                                let v250 : string = $"{v0} "
                                method40(v250, v1, v221, v4)
                            else
                                let v253 : string = $"{v0}{v220}"
                                method40(v253, v1, v221, v4)
                | _ ->
                    let v263 : bool = v0 = ""
                    let v267 : UH1 =
                        if v263 then
                            v1
                        else
                            let v264 : UH1 = UH1_0
                            let v265 : UH1 = UH1_1(v0, v264)
                            method41(v1, v265)
                    struct (v267, v0)
            else
                match v2 with
                | UH0_1(v270, v271) -> (* Cons *)
                    let v272 : bool = '\\' = v270
                    if v272 then
                        let v273 : uint8 = 1uy
                        let v274 : US10 = US10_2(v273)
                        method39(v0, v1, v271, v4, v274)
                    else
                        let v277 : bool = '"' = v270
                        if v277 then
                            let v278 : US10 = US10_2(0uy)
                            let v279 : bool = v3 = v278
                            if v279 then
                                let v280 : string = $"{v0}\""
                                let v281 : char = '"'
                                let v282 : US10 = US10_1(v281)
                                method39(v280, v1, v271, v4, v282)
                            else
                                let v285 : UH1 = UH1_0
                                let v286 : UH1 = UH1_1(v0, v285)
                                let v287 : UH1 = method41(v1, v286)
                                let v288 : string = ""
                                let v289 : US10 = US10_0
                                method39(v288, v287, v271, v4, v289)
                        else
                            let v294 : bool = ' ' = v270
                            if v294 then
                                let v295 : string = $"{v0} "
                                method40(v295, v1, v271, v4)
                            else
                                let v298 : string = $"{v0}{v270}"
                                method40(v298, v1, v271, v4)
                | _ ->
                    let v308 : bool = v0 = ""
                    let v312 : UH1 =
                        if v308 then
                            v1
                        else
                            let v309 : UH1 = UH1_0
                            let v310 : UH1 = UH1_1(v0, v309)
                            method41(v1, v310)
                    struct (v312, v0)
    | US10_0 -> (* Start *)
        match v2 with
        | UH0_1(v5, v6) -> (* Cons *)
            let v7 : bool = '"' = v5
            if v7 then
                let v8 : string = ""
                let v9 : char = '"'
                let v10 : US10 = US10_1(v9)
                method39(v8, v1, v6, v4, v10)
            else
                let v13 : bool = '\\' = v5
                if v13 then
                    let v14 : uint8 = 0uy
                    let v15 : US10 = US10_2(v14)
                    method39(v0, v1, v6, v4, v15)
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
                                method41(v1, v22)
                        let v25 : string = ""
                        method40(v25, v24, v6, v4)
                    else
                        let v28 : string = $"{v0}{v5}"
                        method40(v28, v1, v6, v4)
        | _ ->
            let v38 : bool = v0 = ""
            let v42 : UH1 =
                if v38 then
                    v1
                else
                    let v39 : UH1 = UH1_0
                    let v40 : UH1 = UH1_1(v0, v39)
                    method41(v1, v40)
            struct (v42, v0)
and method42 (v0 : UH1, v1 : string list) : string list =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : string list = method42(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH1_0 -> (* Nil *)
        v1
and method37 (v0 : string) : (string []) =
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
    let v7 : (string -> US7) = method38()
    let v8 : US7 = US7_1
    let v9 : US7 = v6 |> Option.map v7 |> Option.defaultValue v8 
    let v12 : string =
        match v9 with
        | US7_1 -> (* None *)
            v2
        | US7_0(v10) -> (* Some *)
            v10
    let v13 : int32 = v12.Length
    let v14 : (char []) = Array.zeroCreate<char> (v13)
    let v15 : Mut5 = {l0 = 0} : Mut5
    while method21(v13, v15) do
        let v17 : int32 = v15.l0
        let v18 : char = v12.[int v17]
        v14.[int v17] <- v18
        let v19 : int32 = v17 + 1
        v15.l0 <- v19
        ()
    let v20 : ((char []) -> char list) = Array.toList
    let v21 : char list = v20 v14
    let v22 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v23 : (char -> (UH0 -> UH0)) = method35()
    let v24 : (char list -> (UH0 -> UH0)) = v22 v23
    let v25 : (UH0 -> UH0) = v24 v21
    let v26 : UH0 = UH0_0
    let v27 : UH0 = v25 v26
    let v28 : US10 = US10_0
    let v29 : US10 = US10_0
    let struct (v30 : UH1, v31 : string) = method39(v2, v1, v27, v29, v28)
    let v32 : string list = []
    let v33 : string list = method42(v30, v32)
    let v34 : (string list -> (string [])) = List.toArray
    let v35 : (string []) = v34 v33
    v35
and closure27 () (v0 : string) : std_string_String =
    let v1 : string = method14(v0)
    let v2 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    v5
and closure28 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : string option, v5 : string, v6 : Vec<std_string_String>) () : string =
    let v7 : string = $"execute_with_options / file_name: {v5} / arguments: %A{v6} / options: %A{struct (v0, v1, v2, v3, v4)}"
    v7
and method43 () : (unit -> string) =
    closure6()
and method45 (v0 : string) : string =
    v0
and method47 (v0 : std_sync_Mutex<std_process_Child option>) : std_sync_Mutex<std_process_Child option> =
    v0
and closure29 () (v0 : std_process_Child) : std_sync_Arc<std_sync_Mutex<std_process_Child option>> =
    let v1 : std_process_Child option = Some v0 
    let v2 : string = "std::sync::Mutex::new($0)"
    let v3 : std_sync_Mutex<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : std_sync_Mutex<std_process_Child option> = method47(v3)
    let v5 : string = "std::sync::Arc::new(v4)"
    let v6 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr () v5
    v6
and method46 () : (std_process_Child -> std_sync_Arc<std_sync_Mutex<std_process_Child option>>) =
    closure29()
and method48 (v0 : Result<std_process_Child, std_io_Error>) : Result<std_process_Child, std_io_Error> =
    v0
and closure30 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : US11 =
    US11_0(v0)
and closure31 () (v0 : std_string_String) : US11 =
    US11_1(v0)
and closure32 (v0 : std_string_String) () : string =
    let v1 : string = $"execute_with_options -1 / error: {v0}"
    v1
and method49 (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : std_sync_Arc<std_sync_Mutex<std_process_Child option>> =
    v0
and method50 (v0 : std_sync_Mutex<std_process_ChildStdout option>) : std_sync_Mutex<std_process_ChildStdout option> =
    v0
and method51 (v0 : std_sync_Mutex<std_process_ChildStderr option>) : std_sync_Mutex<std_process_ChildStderr option> =
    v0
and method52 (v0 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> =
    v0
and method53 (v0 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>) : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> =
    v0
and method54 (v0 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>) : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> =
    v0
and method55 (v0 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>>) : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> =
    v0
and closure34 () (v0 : std_string_String) : US13 =
    US13_0(v0)
and closure35 () (v0 : std_string_String) : US13 =
    US13_1(v0)
and closure36 (v0 : std_string_String) () : string =
    let v1 : string = $"execute_with_options / stdout_line / stdout: {true} / e: {v0}"
    v1
and closure37 (v0 : std_string_String) () : string =
    let v1 : string = $"> {v0}"
    v1
and closure33 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) (v1 : Result<std_string_String, std_io_Error>) : unit =
    let v2 : (std_io_Error -> std_string_String) = method28()
    let v3 : string = "$0.map_err(|x| $1(x))"
    let v4 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1, v2) v3
    let v5 : (std_string_String -> US13) = closure34()
    let v6 : (std_string_String -> US13) = closure35()
    let v7 : US13 = match v4 with Ok x -> v5 x | Error x -> v6 x
    let v23 : std_string_String =
        match v7 with
        | US13_1(v12) -> (* Error *)
            let v13 : US0 = US0_4
            let v14 : (unit -> string) = closure36(v12)
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
            let v10 : (unit -> string) = closure37(v8)
            let v11 : (unit -> string) = closure6()
            method3(v9, v10, v11)
            v8
    let v24 : string = "true; $0.lock().unwrap().send($1).unwrap()"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr struct (v0, v23) v24
    ()
and method56 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) : (Result<std_string_String, std_io_Error> -> unit) =
    closure33(v0)
and method57 (v0 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>>) : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>> =
    v0
and closure39 (v0 : std_string_String) () : string =
    let v1 : string = $"execute_with_options / stdout_line / stdout: {false} / e: {v0}"
    v1
and closure38 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) (v1 : Result<std_string_String, std_io_Error>) : unit =
    let v2 : (std_io_Error -> std_string_String) = method28()
    let v3 : string = "$0.map_err(|x| $1(x))"
    let v4 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1, v2) v3
    let v5 : (std_string_String -> US13) = closure34()
    let v6 : (std_string_String -> US13) = closure35()
    let v7 : US13 = match v4 with Ok x -> v5 x | Error x -> v6 x
    let v23 : std_string_String =
        match v7 with
        | US13_1(v12) -> (* Error *)
            let v13 : US0 = US0_4
            let v14 : (unit -> string) = closure39(v12)
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
            let v10 : (unit -> string) = closure37(v8)
            let v11 : (unit -> string) = closure6()
            method3(v9, v10, v11)
            v8
    let v24 : string = "true; $0.lock().unwrap().send($1).unwrap()"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr struct (v0, v23) v24
    ()
and method58 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) : (Result<std_string_String, std_io_Error> -> unit) =
    closure38(v0)
and closure40 () (v0 : std_process_Output) : US14 =
    US14_0(v0)
and closure41 () (v0 : std_string_String) : US14 =
    US14_1(v0)
and closure42 (v0 : std_string_String) () : string =
    let v1 : string = $"execute_with_options -2 / error: {v0}"
    v1
and closure43 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"execute_with_options / exit_code: {v0} / std_trace.Length: {v1.Length}"
    v2
and method59 (v0 : (int32 * string)) : (int32 * string) =
    v0
and method44 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : string option, v5 : string, v6 : Vec<std_string_String>) : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> =
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
    let v22 : (string -> US7) = method38()
    let v23 : US7 = US7_1
    let v24 : US7 = v4 |> Option.map v22 |> Option.defaultValue v23 
    let v30 : Ref<Mut<std_process_Command>> =
        match v24 with
        | US7_1 -> (* None *)
            v21
        | US7_0(v25) -> (* Some *)
            let v26 : string = method45(v25)
            let v27 : string = "std::process::Command::current_dir(v21, &*v26)"
            let v28 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr () v27
            v28
    let v31 : string = "true; let mut v30 = v30"
    let v32 : bool = Fable.Core.RustInterop.emitRustExpr () v31
    let v33 : string = "std::process::Command::spawn(&mut $0)"
    let v34 : Result<std_process_Child, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v30 v33
    let v35 : (std_process_Child -> std_sync_Arc<std_sync_Mutex<std_process_Child option>>) = method46()
    let v36 : Result<std_process_Child, std_io_Error> = method48(v34)
    let v37 : string = "v36.map(|x| v35(x))"
    let v38 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v37
    let v39 : (std_io_Error -> std_string_String) = method28()
    let v40 : string = "$0.map_err(|x| $1(x))"
    let v41 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v38, v39) v40
    let v42 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US11) = closure30()
    let v43 : (std_string_String -> US11) = closure31()
    let v44 : US11 = match v41 with Ok x -> v42 x | Error x -> v43 x
    let struct (v149 : int32, v150 : US3, v151 : US12) =
        match v44 with
        | US11_1(v140) -> (* Error *)
            let v141 : US0 = US0_4
            let v142 : (unit -> string) = closure32(v140)
            let v143 : (unit -> string) = closure6()
            method3(v141, v142, v143)
            let v144 : US3 = US3_0(v140)
            let v145 : US12 = US12_1
            struct (-1, v144, v145)
        | US11_0(v45) -> (* Ok *)
            let v46 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method49(v45)
            let v47 : string = "v46.lock().unwrap().as_mut().unwrap().stdout.take().unwrap()"
            let v48 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr () v47
            let v49 : string = "v46.lock().unwrap().as_mut().unwrap().stderr.take().unwrap()"
            let v50 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr () v49
            let v51 : std_process_ChildStdout option = Some v48 
            let v52 : string = "std::sync::Mutex::new($0)"
            let v53 : std_sync_Mutex<std_process_ChildStdout option> = Fable.Core.RustInterop.emitRustExpr v51 v52
            let v54 : std_sync_Mutex<std_process_ChildStdout option> = method50(v53)
            let v55 : string = "std::sync::Arc::new(v54)"
            let v56 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdout option>> = Fable.Core.RustInterop.emitRustExpr () v55
            let v57 : std_process_ChildStderr option = Some v50 
            let v58 : string = "std::sync::Mutex::new($0)"
            let v59 : std_sync_Mutex<std_process_ChildStderr option> = Fable.Core.RustInterop.emitRustExpr v57 v58
            let v60 : std_sync_Mutex<std_process_ChildStderr option> = method51(v59)
            let v61 : string = "std::sync::Arc::new(v60)"
            let v62 : std_sync_Arc<std_sync_Mutex<std_process_ChildStderr option>> = Fable.Core.RustInterop.emitRustExpr () v61
            let v63 : string = "{ let (sender, receiver) = std::sync::mpsc::channel(); (sender, std::sync::Arc::new(receiver)) }"
            let struct (v64 : std_sync_mpsc_Sender<std_string_String>, v65 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = Fable.Core.RustInterop.emitRustExpr () v63
            let v66 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> = method52(v65)
            let v67 : string = "true; let v66 = v66"
            let v68 : bool = Fable.Core.RustInterop.emitRustExpr v66 v67
            let v69 : string = "std::sync::Mutex::new($0)"
            let v70 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v64 v69
            let v71 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = method53(v70)
            let v72 : string = "std::sync::Arc::new(v71)"
            let v73 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v72
            let v74 : string = "v73.clone()"
            let v75 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v74
            let v76 : string = "v73.clone()"
            let v77 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v76
            let v78 : string = "std::sync::Mutex::new($0)"
            let v79 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v66 v78
            let v80 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = method54(v79)
            let v81 : string = "std::sync::Arc::new(v80)"
            let v82 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v81
            let v83 : string = "std::thread::spawn(move || { //"
            let v84 : std_thread_JoinHandle<unit> = Fable.Core.RustInterop.emitRustExpr () v83
            let v85 : string = "std::io::BufRead::lines(std::io::BufReader::new(v56.lock().unwrap().take().unwrap()))"
            let v86 : std_io_Lines<std_io_BufReader<std_process_ChildStdout>> = Fable.Core.RustInterop.emitRustExpr () v85
            let v87 : string = "std::sync::Mutex::new($0)"
            let v88 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> = Fable.Core.RustInterop.emitRustExpr v86 v87
            let v89 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> = method55(v88)
            let v90 : string = "std::sync::Arc::new(v89)"
            let v91 : std_sync_Arc<std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>>> = Fable.Core.RustInterop.emitRustExpr () v90
            let v92 : (Result<std_string_String, std_io_Error> -> unit) = method56(v75)
            let v93 : string = "true; for line in $0.lock().unwrap().by_ref() { v92(line) }"
            let v94 : bool = Fable.Core.RustInterop.emitRustExpr v91 v93
            let v95 : string = "true; })"
            let v96 : bool = Fable.Core.RustInterop.emitRustExpr () v95
            let v97 : string = "std::thread::spawn(move || { //"
            let v98 : std_thread_JoinHandle<unit> = Fable.Core.RustInterop.emitRustExpr () v97
            let v99 : string = "std::io::BufRead::lines(std::io::BufReader::new(v62.lock().unwrap().take().unwrap()))"
            let v100 : std_io_Lines<std_io_BufReader<std_process_ChildStderr>> = Fable.Core.RustInterop.emitRustExpr () v99
            let v101 : string = "std::sync::Mutex::new($0)"
            let v102 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>> = Fable.Core.RustInterop.emitRustExpr v100 v101
            let v103 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>> = method57(v102)
            let v104 : string = "std::sync::Arc::new(v103)"
            let v105 : std_sync_Arc<std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>>> = Fable.Core.RustInterop.emitRustExpr () v104
            let v106 : (Result<std_string_String, std_io_Error> -> unit) = method58(v73)
            let v107 : string = "true; for line in $0.lock().unwrap().by_ref() { v106(line) }"
            let v108 : bool = Fable.Core.RustInterop.emitRustExpr v105 v107
            let v109 : string = "true; })"
            let v110 : bool = Fable.Core.RustInterop.emitRustExpr () v109
            let v111 : string = "v46.lock().unwrap().take().unwrap().wait_with_output()"
            let v112 : Result<std_process_Output, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v111
            let v113 : (std_io_Error -> std_string_String) = method28()
            let v114 : string = "$0.map_err(|x| $1(x))"
            let v115 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v112, v113) v114
            let v116 : string = "true; v84.join().unwrap()"
            let v117 : bool = Fable.Core.RustInterop.emitRustExpr () v116
            let v118 : string = "true; v98.join().unwrap()"
            let v119 : bool = Fable.Core.RustInterop.emitRustExpr () v118
            let v120 : (std_process_Output -> US14) = closure40()
            let v121 : (std_string_String -> US14) = closure41()
            let v122 : US14 = match v115 with Ok x -> v120 x | Error x -> v121 x
            match v122 with
            | US14_1(v128) -> (* Error *)
                let v129 : US0 = US0_4
                let v130 : (unit -> string) = closure42(v128)
                let v131 : (unit -> string) = closure6()
                method3(v129, v130, v131)
                let v132 : US3 = US3_0(v128)
                let v133 : US12 = US12_1
                struct (-2, v132, v133)
            | US14_0(v123) -> (* Ok *)
                let v124 : string = "$0.status.code().unwrap()"
                let v125 : int32 = Fable.Core.RustInterop.emitRustExpr v123 v124
                let v126 : US3 = US3_1
                let v127 : US12 = US12_0(v82)
                struct (v125, v126, v127)
    let v158 : US3 =
        match v151 with
        | US12_1 -> (* None *)
            US3_1
        | US12_0(v152) -> (* Some *)
            let v153 : string = "$0.lock().unwrap().iter().collect::<Vec<String>>().join(\"\\n\")"
            let v154 : std_string_String = Fable.Core.RustInterop.emitRustExpr v152 v153
            US3_0(v154)
    let v165 : US7 =
        match v158 with
        | US3_1 -> (* None *)
            US7_1
        | US3_0(v159) -> (* Some *)
            let v160 : string = "fable_library_rust::String_::fromString($0)"
            let v161 : string = Fable.Core.RustInterop.emitRustExpr v159 v160
            US7_0(v161)
    let v172 : US7 =
        match v150 with
        | US3_1 -> (* None *)
            US7_1
        | US3_0(v166) -> (* Some *)
            let v167 : string = "fable_library_rust::String_::fromString($0)"
            let v168 : string = Fable.Core.RustInterop.emitRustExpr v166 v167
            US7_0(v168)
    let v176 : string =
        match v172 with
        | US7_1 -> (* None *)
            let v174 : string = ""
            v174
        | US7_0(v173) -> (* Some *)
            v173
    let v179 : string =
        match v165 with
        | US7_1 -> (* None *)
            v176
        | US7_0(v177) -> (* Some *)
            v177
    let v180 : US0 = US0_0
    let v181 : (unit -> string) = closure43(v149, v179)
    let v182 : (unit -> string) = closure6()
    method3(v180, v181, v182)
    let v183 : (int32 * string) = v149, v179
    let v184 : (int32 * string) = method59(v183)
    let v185 : string = "v184 }}})"
    Fable.Core.RustInterop.emitRustExpr () v185
    let v186 : string = "{{ //"
    Fable.Core.RustInterop.emitRustExpr () v186
    let v187 : string = "__result"
    let v188 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = Fable.Core.RustInterop.emitRustExpr () v187
    v188
and closure44 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : string option) () : string =
    let v5 : string = $"execute_with_options_async / options: %A{struct (v0, v1, v2, v3, v4)}"
    v5
and closure46 () (v0 : (struct (bool * string * int32) -> Async<unit>)) : US15 =
    US15_0(v0)
and method60 () : ((struct (bool * string * int32) -> Async<unit>) -> US15) =
    closure46()
and closure47 (v0 : string) () : string =
    let v1 : string = $"> {v0}"
    v1
and closure45 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : string option, v5 : System.Diagnostics.Process, v6 : System.Collections.Concurrent.ConcurrentStack<string>) (v7 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v8 : Async<unit> option = None
    let v9 : bool = true in let mutable _v8 = v8
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v13 : Async<unit> option = None
    let mutable _v13 = v13
    async {
    let v14 : string = v7.Data
    let v15 : string = null |> unbox<string>
    let v16 : bool = v14 = v15
    let v17 : bool = v16 <> true
    if v17 then
        let v18 : ((struct (bool * string * int32) -> Async<unit>) -> US15) = method60()
        let v19 : US15 = US15_1
        let v20 : US15 = v3 |> Option.map v18 |> Option.defaultValue v19 
        match v20 with
        | US15_1 -> (* None *)
            ()
        | US15_0(v21) -> (* Some *)
            let v22 : int32 = v5.Id
            let v23 : Async<unit> = v21 struct (false, v14, v22)
            do! v23 
            ()
        let v24 : US0 = US0_0
        let v25 : (unit -> string) = closure47(v14)
        let v26 : (unit -> string) = closure6()
        method3(v24, v25, v26)
        let v27 : string = ""
        let v28 : string = $"{v27}{v14}{v27}"
        let v29 : (string -> unit) = v6.Push
        v29 v28
    }
    |> fun x -> _v13 <- Some x
    let v30 : Async<unit> = _v13 |> Option.get
    v30
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v31 : Async<unit> = null |> unbox<Async<unit>>
    v31
#endif
    
#if FABLE_COMPILER_PYTHON
    let v32 : Async<unit> = null |> unbox<Async<unit>>
    v32
#endif
    |> fun x -> _v8 <- Some x
    let v33 : Async<unit> = _v8.Value
    let v34 : unit option = None
    let v35 : bool = true in let mutable _v34 = v34
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v36 : (Async<unit> -> unit) = Async.StartImmediate
    v36 v33
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
    |> fun x -> _v34 <- Some x
    _v34.Value
    ()
and closure48 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : string option, v5 : System.Diagnostics.Process, v6 : System.Collections.Concurrent.ConcurrentStack<string>) (v7 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v8 : Async<unit> option = None
    let v9 : bool = true in let mutable _v8 = v8
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v13 : Async<unit> option = None
    let mutable _v13 = v13
    async {
    let v14 : string = v7.Data
    let v15 : string = null |> unbox<string>
    let v16 : bool = v14 = v15
    let v17 : bool = v16 <> true
    if v17 then
        let v18 : ((struct (bool * string * int32) -> Async<unit>) -> US15) = method60()
        let v19 : US15 = US15_1
        let v20 : US15 = v3 |> Option.map v18 |> Option.defaultValue v19 
        match v20 with
        | US15_1 -> (* None *)
            ()
        | US15_0(v21) -> (* Some *)
            let v22 : int32 = v5.Id
            let v23 : Async<unit> = v21 struct (true, v14, v22)
            do! v23 
            ()
        let v24 : US0 = US0_0
        let v25 : (unit -> string) = closure47(v14)
        let v26 : (unit -> string) = closure6()
        method3(v24, v25, v26)
        let v27 : string = "["
        let v28 : string = "]"
        let v29 : string = $"{v27}{v14}{v28}"
        let v30 : (string -> unit) = v6.Push
        v30 v29
    }
    |> fun x -> _v13 <- Some x
    let v31 : Async<unit> = _v13 |> Option.get
    v31
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v32 : Async<unit> = null |> unbox<Async<unit>>
    v32
#endif
    
#if FABLE_COMPILER_PYTHON
    let v33 : Async<unit> = null |> unbox<Async<unit>>
    v33
#endif
    |> fun x -> _v8 <- Some x
    let v34 : Async<unit> = _v8.Value
    let v35 : unit option = None
    let v36 : bool = true in let mutable _v35 = v35
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v37 : (Async<unit> -> unit) = Async.StartImmediate
    v37 v34
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
    |> fun x -> _v35 <- Some x
    _v35.Value
    ()
and closure49 () (v0 : System.Threading.CancellationToken) : US16 =
    US16_0(v0)
and method61 () : (System.Threading.CancellationToken -> US16) =
    closure49()
and closure50 (v0 : System.Diagnostics.Process) () : unit =
    let v1 : bool option = None
    let v2 : bool = true in let mutable _v1 = v1
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v6 : bool = v0.HasExited
    v6
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : bool = null |> unbox<bool>
    v7
#endif
    
#if FABLE_COMPILER_PYTHON
    let v8 : bool = null |> unbox<bool>
    v8
#endif
    |> fun x -> _v1 <- Some x
    let v9 : bool = _v1.Value
    let v10 : bool = v9 = false
    if v10 then
        let v11 : unit option = None
        let v12 : bool = true in let mutable _v11 = v11
        
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
        let v13 : (unit -> unit) = v0.Kill
        v13 ()
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
        |> fun x -> _v11 <- Some x
        _v11.Value
        ()
and closure51 (v0 : System.Threading.Tasks.TaskCanceledException) () : string =
    let v1 : string = $"execute_with_options_async / WaitForExitAsync / ex: %A{v0}"
    v1
and method62 () : string =
    let v0 : string = "\n"
    v0
and closure52 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"execute_with_options_async / exit_code: {v0} / output.Length: {v1.Length}"
    v2
and closure53 () () : string =
    let v0 : string = "documents.run / par_map / crowbook"
    v0
and closure54 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: %A{v1} / result: {v0} / {v2 ()}"
    v3
and method63 (v0 : string) : string =
    v0
and closure55 () () : string =
    let v0 : string = "documents.run / par_map"
    v0
and closure56 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : int32, v5 : string, v6 : int32, v7 : string, v8 : string, v9 : (Result<string, (string * string)> option [])) () : string =
    let v10 : (unit -> string) = closure6()
    let v11 : string = $"file: {v1} / real_path: {v2} / relative_path: {v0} / origin_hash_exit_code: {v4} / origin_hash: {v3} / local_git_hash_exit_code: {v6} / local_git_hash: {v5} / hash1: {v7} / hash2: %A{v8} / files: %A{v9} / {v10 ()}"
    v11
and closure23 (v0 : string, v1 : string, v2 : string) (v3 : string) : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> =
    let v4 : string option = None
    let v5 : bool = true in let mutable _v4 = v4
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = method13(v3)
    let v7 : string = method14(v6)
    let v8 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "String::from($0)"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "std::path::PathBuf::from($0)"
    let v13 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "$0.exists()"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : bool = v15 = false
    let v201 : string =
        if v16 then
            let v17 : string option = None
            let v18 : bool = true in let mutable _v17 = v17
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v19 : string = "std::env::current_dir()"
            let v20 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v19
            let v21 : string = "$0.unwrap()"
            let v22 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v20 v21
            let v23 : string = "$0.display()"
            let v24 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v22 v23
            let v25 : std_string_String option = None
            let v26 : bool = true in let mutable _v25 = v25
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v27 : string = @$"format!(""{{}}"", $0)"
            let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v24 v27
            v28
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v29 : string = @$"format!(""{{}}"", $0)"
            let v30 : std_string_String = Fable.Core.RustInterop.emitRustExpr v24 v29
            v30
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v31 : string = @$"format!(""{{}}"", $0)"
            let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v24 v31
            v32
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v33 : std_string_String = null |> unbox<std_string_String>
            v33
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v34 : std_string_String = null |> unbox<std_string_String>
            v34
#endif
            
#if FABLE_COMPILER_PYTHON
            let v35 : std_string_String = null |> unbox<std_string_String>
            v35
#endif
            |> fun x -> _v25 <- Some x
            let v36 : std_string_String = _v25.Value
            let v37 : string = "fable_library_rust::String_::fromString($0)"
            let v38 : string = Fable.Core.RustInterop.emitRustExpr v36 v37
            v38
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v39 : string = null |> unbox<string>
            v39
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v40 : string = null |> unbox<string>
            v40
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v41 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v42 : string = v41 ()
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
            |> fun x -> _v17 <- Some x
            let v45 : string = _v17.Value
            let v46 : string option = None
            let v47 : bool = true in let mutable _v46 = v46
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = method14(v45)
            let v49 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v48 v49
            let v51 : string = "String::from($0)"
            let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr v50 v51
            let v53 : string = "std::path::PathBuf::from($0)"
            let v54 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v52 v53
            let v55 : string = method14(v6)
            let v56 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v57 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v55 v56
            let v58 : string = "String::from($0)"
            let v59 : std_string_String = Fable.Core.RustInterop.emitRustExpr v57 v58
            let v60 : string = "$0.join($1)"
            let v61 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v54, v59) v60
            let v62 : string = "$0.display()"
            let v63 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v61 v62
            let v64 : std_string_String option = None
            let v65 : bool = true in let mutable _v64 = v64
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v66 : string = @$"format!(""{{}}"", $0)"
            let v67 : std_string_String = Fable.Core.RustInterop.emitRustExpr v63 v66
            v67
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v68 : string = @$"format!(""{{}}"", $0)"
            let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr v63 v68
            v69
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v70 : string = @$"format!(""{{}}"", $0)"
            let v71 : std_string_String = Fable.Core.RustInterop.emitRustExpr v63 v70
            v71
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v72 : std_string_String = null |> unbox<std_string_String>
            v72
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v73 : std_string_String = null |> unbox<std_string_String>
            v73
#endif
            
#if FABLE_COMPILER_PYTHON
            let v74 : std_string_String = null |> unbox<std_string_String>
            v74
#endif
            |> fun x -> _v64 <- Some x
            let v75 : std_string_String = _v64.Value
            let v76 : string = "fable_library_rust::String_::fromString($0)"
            let v77 : string = Fable.Core.RustInterop.emitRustExpr v75 v76
            v77
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v78 : string = null |> unbox<string>
            v78
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v79 : string = null |> unbox<string>
            v79
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v80 : string = System.IO.Path.Combine (v45, v6)
            v80
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v81 : string = "path"
            let v82 : IPathJoin = Fable.Core.JsInterop.importAll v81
            let v83 : string = method15(v45)
            let v84 : string = method16(v6)
            let v85 : string = "v82.join(v83, v84)"
            let v86 : string = Fable.Core.JsInterop.emitJsExpr () v85
            v86
#endif
            
#if FABLE_COMPILER_PYTHON
            let v87 : string = null |> unbox<string>
            v87
#endif
            |> fun x -> _v46 <- Some x
            let v88 : string = _v46.Value
            let v89 : bool option = None
            let v90 : bool = true in let mutable _v89 = v89
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v91 : string = "cfg!(windows)"
            let v92 : bool = Fable.Core.RustInterop.emitRustExpr () v91
            v92
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v93 : bool = null |> unbox<bool>
            v93
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v94 : bool = null |> unbox<bool>
            v94
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v95 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v96 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v97 : bool = v96 v95
            v97
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v98 : bool = null |> unbox<bool>
            v98
#endif
            
#if FABLE_COMPILER_PYTHON
            let v99 : bool = null |> unbox<bool>
            v99
#endif
            |> fun x -> _v89 <- Some x
            let v100 : bool = _v89.Value
            let v101 : bool = v100 = false
            let v125 : string =
                if v101 then
                    v88
                else
                    let v102 : string option = None
                    let v103 : bool = true in let mutable _v102 = v102
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v104 : string = method17()
                    let v105 : string = method18(v88)
                    let v106 : string = method19()
                    let v107 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v108 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v104, v105, v106) v107
                    let v109 : string = "String::from($0)"
                    let v110 : std_string_String = Fable.Core.RustInterop.emitRustExpr v108 v109
                    let v111 : string = "fable_library_rust::String_::fromString($0)"
                    let v112 : string = Fable.Core.RustInterop.emitRustExpr v110 v111
                    v112
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v113 : string = null |> unbox<string>
                    v113
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v114 : string = null |> unbox<string>
                    v114
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v115 : string = "^\\\\\\\\\\?\\\\"
                    let v116 : string = ""
                    let v117 : string = System.Text.RegularExpressions.Regex.Replace (v88, v115, v116)
                    v117
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v118 : string = null |> unbox<string>
                    v118
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v119 : string = null |> unbox<string>
                    v119
#endif
                    |> fun x -> _v102 <- Some x
                    let v120 : string = _v102.Value
                    let v121 : string = $"{v120.[0] |> string |> _.ToLower()}{v120.[1..]}"
                    let v122 : string = "\\"
                    let v123 : string = "/"
                    let v124 : string = v121.Replace (v122, v123)
                    v124
            let v126 : string = "/"
            let v127 : (string []) = v125.Split v126
            let v128 : (string []) = [||]
            let v129 : int32 = v127.Length
            let v130 : Mut4 = {l0 = 0; l1 = 0; l2 = v128} : Mut4
            while method20(v129, v130) do
                let v132 : int32 = v130.l0
                let v133 : int32 =  -v132
                let v134 : int32 = v133 + v129
                let v135 : int32 = v134 - 1
                let struct (v136 : int32, v137 : (string [])) = v130.l1, v130.l2
                let v138 : string = v127.[int v135]
                let v139 : bool = ".." = v138
                let struct (v159 : int32, v160 : (string [])) =
                    if v139 then
                        let v140 : int32 = v136 + 1
                        struct (v140, v137)
                    else
                        let v141 : bool = 0 = v136
                        if v141 then
                            let v142 : (string []) = [|v138|]
                            let v143 : int32 = v142.Length
                            let v144 : int32 = v137.Length
                            let v145 : int32 = v143 + v144
                            let v146 : (string []) = Array.zeroCreate<string> (v145)
                            let v147 : Mut5 = {l0 = 0} : Mut5
                            while method21(v145, v147) do
                                let v149 : int32 = v147.l0
                                let v150 : bool = v149 < v143
                                let v154 : string =
                                    if v150 then
                                        let v151 : string = v142.[int v149]
                                        v151
                                    else
                                        let v152 : int32 = v149 - v143
                                        let v153 : string = v137.[int v152]
                                        v153
                                v146.[int v149] <- v154
                                let v155 : int32 = v149 + 1
                                v147.l0 <- v155
                                ()
                            struct (0, v146)
                        else
                            let v156 : int32 = v136 - 1
                            struct (v156, v137)
                let v161 : int32 = v132 + 1
                v130.l0 <- v161
                v130.l1 <- v159
                v130.l2 <- v160
                ()
            let struct (v162 : int32, v163 : (string [])) = v130.l1, v130.l2
            let v164 : string seq = seq { for i = 0 to v163.Length - 1 do yield v163.[i] }
            let v165 : char option = None
            let v166 : bool = true in let mutable _v165 = v165
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v167 : string = "std::path::MAIN_SEPARATOR"
            let v168 : char = Fable.Core.RustInterop.emitRustExpr () v167
            v168
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v169 : char = null |> unbox<char>
            v169
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v170 : char = null |> unbox<char>
            v170
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v171 : char = System.IO.Path.DirectorySeparatorChar
            v171
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v172 : char = null |> unbox<char>
            v172
#endif
            
#if FABLE_COMPILER_PYTHON
            let v173 : char = null |> unbox<char>
            v173
#endif
            |> fun x -> _v165 <- Some x
            let v174 : char = _v165.Value
            let v175 : (char -> string) = _.ToString()
            let v176 : string = v175 v174
            let v177 : string = method22(v176)
            let v178 : (string -> (string seq -> string)) = String.concat
            let v179 : (string seq -> string) = v178 v177
            v179 v164
        else
            let v181 : string = "std::fs::canonicalize(&*$0)"
            let v182 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v6 v181
            let v183 : string = "$0.unwrap()"
            let v184 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v182 v183
            let v185 : string = "$0.display()"
            let v186 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v184 v185
            let v187 : std_string_String option = None
            let v188 : bool = true in let mutable _v187 = v187
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v189 : string = @$"format!(""{{}}"", $0)"
            let v190 : std_string_String = Fable.Core.RustInterop.emitRustExpr v186 v189
            v190
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v191 : string = @$"format!(""{{}}"", $0)"
            let v192 : std_string_String = Fable.Core.RustInterop.emitRustExpr v186 v191
            v192
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = @$"format!(""{{}}"", $0)"
            let v194 : std_string_String = Fable.Core.RustInterop.emitRustExpr v186 v193
            v194
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v195 : std_string_String = null |> unbox<std_string_String>
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
            |> fun x -> _v187 <- Some x
            let v198 : std_string_String = _v187.Value
            let v199 : string = "fable_library_rust::String_::fromString($0)"
            let v200 : string = Fable.Core.RustInterop.emitRustExpr v198 v199
            v200
    v201
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v202 : string = null |> unbox<string>
    v202
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v203 : string = null |> unbox<string>
    v203
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v204 : string = method23(v3)
    let v205 : (string -> string) = System.IO.Path.GetFullPath
    let v206 : string = v205 v204
    v206
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v207 : string = null |> unbox<string>
    v207
#endif
    
#if FABLE_COMPILER_PYTHON
    let v208 : string = null |> unbox<string>
    v208
#endif
    |> fun x -> _v4 <- Some x
    let v209 : string = _v4.Value
    let v210 : string = method14(v209)
    let v211 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v212 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v211
    let v213 : string = "String::from($0)"
    let v214 : std_string_String = Fable.Core.RustInterop.emitRustExpr v212 v213
    let v215 : string = "std::path::PathBuf::from($0)"
    let v216 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v214 v215
    let v217 : string = "$0.display()"
    let v218 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v216 v217
    let v219 : std_string_String option = None
    let v220 : bool = true in let mutable _v219 = v219
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v221 : string = @$"format!(""{{}}"", $0)"
    let v222 : std_string_String = Fable.Core.RustInterop.emitRustExpr v218 v221
    v222
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v223 : string = @$"format!(""{{}}"", $0)"
    let v224 : std_string_String = Fable.Core.RustInterop.emitRustExpr v218 v223
    v224
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v225 : string = @$"format!(""{{}}"", $0)"
    let v226 : std_string_String = Fable.Core.RustInterop.emitRustExpr v218 v225
    v226
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v227 : std_string_String = null |> unbox<std_string_String>
    v227
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v228 : std_string_String = null |> unbox<std_string_String>
    v228
#endif
    
#if FABLE_COMPILER_PYTHON
    let v229 : std_string_String = null |> unbox<std_string_String>
    v229
#endif
    |> fun x -> _v219 <- Some x
    let v230 : std_string_String = _v219.Value
    let v231 : string = "fable_library_rust::String_::fromString($0)"
    let v232 : string = Fable.Core.RustInterop.emitRustExpr v230 v231
    let v233 : string = ""
    let v234 : string = v232.Replace (v1, v233)
    let v235 : string = "\\"
    let v236 : string = "/"
    let v237 : string = v234.Replace (v235, v236)
    let v238 : string = $".{v237}"
    let v239 : bool option = None
    let v240 : bool = true in let mutable _v239 = v239
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v241 : string = "cfg!(windows)"
    let v242 : bool = Fable.Core.RustInterop.emitRustExpr () v241
    v242
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v243 : bool = null |> unbox<bool>
    v243
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v244 : bool = null |> unbox<bool>
    v244
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v245 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v246 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v247 : bool = v246 v245
    v247
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v248 : bool = null |> unbox<bool>
    v248
#endif
    
#if FABLE_COMPILER_PYTHON
    let v249 : bool = null |> unbox<bool>
    v249
#endif
    |> fun x -> _v239 <- Some x
    let v250 : bool = _v239.Value
    let v251 : bool = v250 = false
    let v272 : string =
        if v251 then
            v209
        else
            let v252 : string option = None
            let v253 : bool = true in let mutable _v252 = v252
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v254 : string = method17()
            let v255 : string = method18(v209)
            let v256 : string = method19()
            let v257 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v258 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v254, v255, v256) v257
            let v259 : string = "String::from($0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259
            let v261 : string = "fable_library_rust::String_::fromString($0)"
            let v262 : string = Fable.Core.RustInterop.emitRustExpr v260 v261
            v262
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v263 : string = null |> unbox<string>
            v263
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v264 : string = null |> unbox<string>
            v264
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v265 : string = "^\\\\\\\\\\?\\\\"
            let v266 : string = System.Text.RegularExpressions.Regex.Replace (v209, v265, v233)
            v266
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v267 : string = null |> unbox<string>
            v267
#endif
            
#if FABLE_COMPILER_PYTHON
            let v268 : string = null |> unbox<string>
            v268
#endif
            |> fun x -> _v252 <- Some x
            let v269 : string = _v252.Value
            let v270 : string = $"{v269.[0] |> string |> _.ToLower()}{v269.[1..]}"
            let v271 : string = v270.Replace (v235, v236)
            v271
    let v273 : string option = None
    let v274 : bool = true in let mutable _v273 = v273
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v275 : string = method14(v0)
    let v276 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v277 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v275 v276
    let v278 : string = "String::from($0)"
    let v279 : std_string_String = Fable.Core.RustInterop.emitRustExpr v277 v278
    let v280 : string = "std::path::PathBuf::from($0)"
    let v281 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v279 v280
    let v282 : string = method14(v238)
    let v283 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v284 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v282 v283
    let v285 : string = "String::from($0)"
    let v286 : std_string_String = Fable.Core.RustInterop.emitRustExpr v284 v285
    let v287 : string = "$0.join($1)"
    let v288 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v281, v286) v287
    let v289 : string = "$0.display()"
    let v290 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v288 v289
    let v291 : std_string_String option = None
    let v292 : bool = true in let mutable _v291 = v291
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v293 : string = @$"format!(""{{}}"", $0)"
    let v294 : std_string_String = Fable.Core.RustInterop.emitRustExpr v290 v293
    v294
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v295 : string = @$"format!(""{{}}"", $0)"
    let v296 : std_string_String = Fable.Core.RustInterop.emitRustExpr v290 v295
    v296
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v297 : string = @$"format!(""{{}}"", $0)"
    let v298 : std_string_String = Fable.Core.RustInterop.emitRustExpr v290 v297
    v298
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v299 : std_string_String = null |> unbox<std_string_String>
    v299
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v300 : std_string_String = null |> unbox<std_string_String>
    v300
#endif
    
#if FABLE_COMPILER_PYTHON
    let v301 : std_string_String = null |> unbox<std_string_String>
    v301
#endif
    |> fun x -> _v291 <- Some x
    let v302 : std_string_String = _v291.Value
    let v303 : string = "fable_library_rust::String_::fromString($0)"
    let v304 : string = Fable.Core.RustInterop.emitRustExpr v302 v303
    v304
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v305 : string = null |> unbox<string>
    v305
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v306 : string = null |> unbox<string>
    v306
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v307 : string = System.IO.Path.Combine (v0, v238)
    v307
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v308 : string = "path"
    let v309 : IPathJoin = Fable.Core.JsInterop.importAll v308
    let v310 : string = method15(v0)
    let v311 : string = method16(v238)
    let v312 : string = "v309.join(v310, v311)"
    let v313 : string = Fable.Core.JsInterop.emitJsExpr () v312
    v313
#endif
    
#if FABLE_COMPILER_PYTHON
    let v314 : string = null |> unbox<string>
    v314
#endif
    |> fun x -> _v273 <- Some x
    let v315 : string = _v273.Value
    let v316 : bool option = None
    let v317 : bool = true in let mutable _v316 = v316
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v318 : string = "cfg!(windows)"
    let v319 : bool = Fable.Core.RustInterop.emitRustExpr () v318
    v319
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v320 : bool = null |> unbox<bool>
    v320
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v321 : bool = null |> unbox<bool>
    v321
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v322 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v323 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v324 : bool = v323 v322
    v324
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v325 : bool = null |> unbox<bool>
    v325
#endif
    
#if FABLE_COMPILER_PYTHON
    let v326 : bool = null |> unbox<bool>
    v326
#endif
    |> fun x -> _v316 <- Some x
    let v327 : bool = _v316.Value
    let v328 : bool = v327 = false
    let v349 : string =
        if v328 then
            v315
        else
            let v329 : string option = None
            let v330 : bool = true in let mutable _v329 = v329
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v331 : string = method17()
            let v332 : string = method18(v315)
            let v333 : string = method19()
            let v334 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v335 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v331, v332, v333) v334
            let v336 : string = "String::from($0)"
            let v337 : std_string_String = Fable.Core.RustInterop.emitRustExpr v335 v336
            let v338 : string = "fable_library_rust::String_::fromString($0)"
            let v339 : string = Fable.Core.RustInterop.emitRustExpr v337 v338
            v339
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v340 : string = null |> unbox<string>
            v340
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v341 : string = null |> unbox<string>
            v341
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v342 : string = "^\\\\\\\\\\?\\\\"
            let v343 : string = System.Text.RegularExpressions.Regex.Replace (v315, v342, v233)
            v343
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v344 : string = null |> unbox<string>
            v344
#endif
            
#if FABLE_COMPILER_PYTHON
            let v345 : string = null |> unbox<string>
            v345
#endif
            |> fun x -> _v329 <- Some x
            let v346 : string = _v329.Value
            let v347 : string = $"{v346.[0] |> string |> _.ToLower()}{v346.[1..]}"
            let v348 : string = v347.Replace (v235, v236)
            v348
    let v350 : string option = None
    let v351 : System.Threading.CancellationToken option = None
    let v352 : (struct (string * string) []) = [||]
    let v353 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v354 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v349}\""
    let v355 : string option = Some v0 
    let v356 : struct (int32 * string) option = None
    let v357 : bool = true in let mutable _v356 = v356
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v358 : string = method33(v351, v354, v352, v353, v355)
    let struct (v359 : string, v360 : string) = method34()
    let v361 : int32 = v358.Length
    let v362 : (char []) = Array.zeroCreate<char> (v361)
    let v363 : Mut5 = {l0 = 0} : Mut5
    while method21(v361, v363) do
        let v365 : int32 = v363.l0
        let v366 : char = v358.[int v365]
        v362.[int v365] <- v366
        let v367 : int32 = v365 + 1
        v363.l0 <- v367
        ()
    let v368 : ((char []) -> char list) = Array.toList
    let v369 : char list = v368 v362
    let v370 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v371 : (char -> (UH0 -> UH0)) = method35()
    let v372 : (char list -> (UH0 -> UH0)) = v370 v371
    let v373 : (UH0 -> UH0) = v372 v369
    let v374 : UH0 = UH0_0
    let v375 : UH0 = v373 v374
    let v376 : US8 = US8_0
    let struct (v377 : string, v378 : string) = method36(v360, v359, v375, v376)
    let v379 : (string []) = method37(v378)
    let v380 : string = "$0.to_vec()"
    let v381 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v379 v380
    let v382 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v383 : (string -> std_string_String) = closure27()
    let v384 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v381, v383) v382
    let v385 : US0 = US0_1
    let v386 : (unit -> string) = closure28(v351, v354, v352, v353, v355, v377, v384)
    let v387 : (unit -> string) = method43()
    method3(v385, v386, v387)
    let v388 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method44(v351, v354, v352, v353, v355, v377, v384)
    let v389 : string = "futures_lite::future::block_on($0)"
    let v390 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v388 v389
    let (a, b) = v390
    let v391 : int32 = a
    let v392 : string = b
    struct (v391, v392)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v393 : int32, v394 : string) = null |> unbox<struct (int32 * string)>
    struct (v393, v394)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v395 : int32, v396 : string) = null |> unbox<struct (int32 * string)>
    struct (v395, v396)
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v397 : Async<struct (int32 * string)> option = None
    let v398 : bool = true in let mutable _v397 = v397
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v399 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v399
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v400 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v400
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v401 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v401
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v402 : Async<struct (int32 * string)> option = None
    let v403 : bool = true in let mutable _v402 = v402
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v404 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v404
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v405 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v405
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v406 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v406
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v407 : Async<struct (int32 * string)> option = None
    let mutable _v407 = v407
    async {
    let struct (v408 : string, v409 : string) = method34()
    let v410 : int32 = v354.Length
    let v411 : (char []) = Array.zeroCreate<char> (v410)
    let v412 : Mut5 = {l0 = 0} : Mut5
    while method21(v410, v412) do
        let v414 : int32 = v412.l0
        let v415 : char = v354.[int v414]
        v411.[int v414] <- v415
        let v416 : int32 = v414 + 1
        v412.l0 <- v416
        ()
    let v417 : ((char []) -> char list) = Array.toList
    let v418 : char list = v417 v411
    let v419 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v420 : (char -> (UH0 -> UH0)) = method35()
    let v421 : (char list -> (UH0 -> UH0)) = v419 v420
    let v422 : (UH0 -> UH0) = v421 v418
    let v423 : UH0 = UH0_0
    let v424 : UH0 = v422 v423
    let v425 : US8 = US8_0
    let struct (v426 : string, v427 : string) = method36(v409, v408, v424, v425)
    let v428 : (string -> US7) = method38()
    let v429 : US7 = US7_1
    let v430 : US7 = v355 |> Option.map v428 |> Option.defaultValue v429 
    let v433 : string =
        match v430 with
        | US7_1 -> (* None *)
            v233
        | US7_0(v431) -> (* Some *)
            v431
    let v434 : US0 = US0_1
    let v435 : (unit -> string) = closure44(v351, v354, v352, v353, v355)
    let v436 : (unit -> string) = method43()
    method3(v434, v435, v436)
    let v437 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v438 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v427, StandardOutputEncoding = v437, WorkingDirectory = v433, FileName = v426, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v439 : int32 = v352.Length
    let v440 : Mut5 = {l0 = 0} : Mut5
    while method21(v439, v440) do
        let v442 : int32 = v440.l0
        let struct (v443 : string, v444 : string) = v352.[int v442]
        v438.EnvironmentVariables.[v443] <- v444 
        let v445 : int32 = v442 + 1
        v440.l0 <- v445
        ()
    let v446 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v438)
    use v446 = v446 
    let v447 : System.Diagnostics.Process = v446 
    let v448 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v449 : System.Collections.Concurrent.ConcurrentStack<string> = v448 ()
    let v450 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v351, v354, v352, v353, v355, v447, v449)
    v447.OutputDataReceived.Add v450 
    let v451 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v351, v354, v352, v353, v355, v447, v449)
    v447.ErrorDataReceived.Add v451 
    let v452 : (unit -> bool) = v447.Start
    let v453 : bool = v452 ()
    let v454 : bool = v453 = false
    if v454 then
        let v455 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v455
    let v456 : (unit -> unit) = v447.BeginErrorReadLine
    v456 ()
    let v457 : (unit -> unit) = v447.BeginOutputReadLine
    v457 ()
    let v458 : (System.Threading.CancellationToken -> US16) = method61()
    let v459 : US16 = US16_1
    let v460 : US16 = v351 |> Option.map v458 |> Option.defaultValue v459 
    let v464 : System.Threading.CancellationToken =
        match v460 with
        | US16_1 -> (* None *)
            let v462 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v462
        | US16_0(v461) -> (* Some *)
            v461
    let v465 : Async<System.Threading.CancellationToken> option = None
    let v466 : bool = true in let mutable _v465 = v465
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v467 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v467
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v468 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v468
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v469 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v469
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v470 : Async<System.Threading.CancellationToken> option = None
    let v471 : bool = true in let mutable _v470 = v470
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v472 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v472
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v473 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v473
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v474 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v474
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v475 : Async<System.Threading.CancellationToken> option = None
    let mutable _v475 = v475
    async {
    let v476 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v476 = v476 
    let v477 : System.Threading.CancellationToken = v476 
    let v478 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v479 : (System.Threading.CancellationToken []) = [|v477; v478; v464|]
    let v480 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v481 : System.Threading.CancellationTokenSource = v480 v479
    let v482 : System.Threading.CancellationToken = v481.Token
    return v482 
    }
    |> fun x -> _v475 <- Some x
    let v483 : Async<System.Threading.CancellationToken> = _v475 |> Option.get
    v483
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v484 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v484
#endif
    
#if FABLE_COMPILER_PYTHON
    let v485 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v485
#endif
    |> fun x -> _v470 <- Some x
    let v486 : Async<System.Threading.CancellationToken> = _v470.Value
    v486
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v487 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v487
#endif
    
#if FABLE_COMPILER_PYTHON
    let v488 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v488
#endif
    |> fun x -> _v465 <- Some x
    let v489 : Async<System.Threading.CancellationToken> = _v465.Value
    let! v489 = v489 
    let v490 : System.Threading.CancellationToken = v489 
    let v491 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v490.Register
    let v492 : (unit -> unit) = closure50(v447)
    let v493 : System.Threading.CancellationTokenRegistration = v491 v492
    use v493 = v493 
    let v494 : System.Threading.CancellationTokenRegistration = v493 
    let v495 : Async<int32> option = None
    let v496 : bool = true in let mutable _v495 = v495
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v497 : Async<int32> = null |> unbox<Async<int32>>
    v497
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v498 : Async<int32> = null |> unbox<Async<int32>>
    v498
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v499 : Async<int32> = null |> unbox<Async<int32>>
    v499
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v500 : Async<int32> option = None
    let mutable _v500 = v500
    async {
    try
    let v501 : System.Threading.Tasks.Task = v447.WaitForExitAsync v490 
    let v502 : Async<unit> option = None
    let v503 : bool = true in let mutable _v502 = v502
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v504 : Async<unit> = null |> unbox<Async<unit>>
    v504
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v505 : Async<unit> = null |> unbox<Async<unit>>
    v505
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v506 : Async<unit> = null |> unbox<Async<unit>>
    v506
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v507 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v508 : Async<unit> = v507 v501
    v508
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v509 : Async<unit> = null |> unbox<Async<unit>>
    v509
#endif
    
#if FABLE_COMPILER_PYTHON
    let v510 : Async<unit> = null |> unbox<Async<unit>>
    v510
#endif
    |> fun x -> _v502 <- Some x
    let v511 : Async<unit> = _v502.Value
    do! v511 
    let v512 : int32 = v447.ExitCode
    return v512 
    with ex ->
    let v513 : exn = ex
    let v514 : string option = None
    let v515 : bool = true in let mutable _v514 = v514
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v516 : string = $"%A{v513}"
    v516
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v517 : string = $"%A{v513}"
    v517
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v518 : string = $"%A{v513}"
    v518
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v519 : string = $"{v513.GetType ()}: {v513.Message}"
    v519
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v520 : string = $"%A{v513}"
    v520
#endif
    
#if FABLE_COMPILER_PYTHON
    let v521 : string = $"%A{v513}"
    v521
#endif
    |> fun x -> _v514 <- Some x
    let v522 : string = _v514.Value
    let v523 : (string -> unit) = v449.Push
    v523 v522
    let v524 : System.Threading.Tasks.TaskCanceledException = v513 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v525 : US0 = US0_3
    let v526 : (unit -> string) = closure51(v524)
    let v527 : (unit -> string) = method43()
    method3(v525, v526, v527)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v500 <- Some x
    let v528 : Async<int32> = _v500 |> Option.get
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
    |> fun x -> _v495 <- Some x
    let v531 : Async<int32> = _v495.Value
    let! v531 = v531 
    let v532 : int32 = v531 
    let v533 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v534 : string seq = v533 v449
    let v535 : string = method62()
    let v536 : (string -> (string seq -> string)) = String.concat
    let v537 : (string seq -> string) = v536 v535
    let v538 : string = v537 v534
    let v539 : US0 = US0_1
    let v540 : (unit -> string) = closure52(v532, v538)
    let v541 : (unit -> string) = method43()
    method3(v539, v540, v541)
    return struct (v532, v538) 
    }
    |> fun x -> _v407 <- Some x
    let v542 : Async<struct (int32 * string)> = _v407 |> Option.get
    v542
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v543 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v543
#endif
    
#if FABLE_COMPILER_PYTHON
    let v544 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v544
#endif
    |> fun x -> _v402 <- Some x
    let v545 : Async<struct (int32 * string)> = _v402.Value
    v545
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v546 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v546
#endif
    
#if FABLE_COMPILER_PYTHON
    let v547 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v547
#endif
    |> fun x -> _v397 <- Some x
    let v548 : Async<struct (int32 * string)> = _v397.Value
    let v549 : struct (int32 * string) option = None
    let v550 : bool = true in let mutable _v549 = v549
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v551 : int32, v552 : string) = null |> unbox<struct (int32 * string)>
    struct (v551, v552)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v553 : int32, v554 : string) = null |> unbox<struct (int32 * string)>
    struct (v553, v554)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v555 : int32, v556 : string) = null |> unbox<struct (int32 * string)>
    struct (v555, v556)
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v557 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v558 : int32, v559 : string) = v557 v548
    struct (v558, v559)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v560 : int32, v561 : string) = null |> unbox<struct (int32 * string)>
    struct (v560, v561)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v562 : int32, v563 : string) = null |> unbox<struct (int32 * string)>
    struct (v562, v563)
#endif
    |> fun x -> _v549 <- Some x
    let struct (v564 : int32, v565 : string) = _v549.Value
    struct (v564, v565)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v566 : int32, v567 : string) = null |> unbox<struct (int32 * string)>
    struct (v566, v567)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v568 : int32, v569 : string) = null |> unbox<struct (int32 * string)>
    struct (v568, v569)
#endif
    |> fun x -> _v356 <- Some x
    let struct (v570 : int32, v571 : string) = _v356.Value
    let v572 : string option = None
    let v573 : bool = true in let mutable _v572 = v572
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v574 : string = method14(v1)
    let v575 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v576 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v574 v575
    let v577 : string = "String::from($0)"
    let v578 : std_string_String = Fable.Core.RustInterop.emitRustExpr v576 v577
    let v579 : string = "std::path::PathBuf::from($0)"
    let v580 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v578 v579
    let v581 : string = method14(v238)
    let v582 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v583 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v581 v582
    let v584 : string = "String::from($0)"
    let v585 : std_string_String = Fable.Core.RustInterop.emitRustExpr v583 v584
    let v586 : string = "$0.join($1)"
    let v587 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v580, v585) v586
    let v588 : string = "$0.display()"
    let v589 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v587 v588
    let v590 : std_string_String option = None
    let v591 : bool = true in let mutable _v590 = v590
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v592 : string = @$"format!(""{{}}"", $0)"
    let v593 : std_string_String = Fable.Core.RustInterop.emitRustExpr v589 v592
    v593
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v594 : string = @$"format!(""{{}}"", $0)"
    let v595 : std_string_String = Fable.Core.RustInterop.emitRustExpr v589 v594
    v595
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v596 : string = @$"format!(""{{}}"", $0)"
    let v597 : std_string_String = Fable.Core.RustInterop.emitRustExpr v589 v596
    v597
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v598 : std_string_String = null |> unbox<std_string_String>
    v598
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v599 : std_string_String = null |> unbox<std_string_String>
    v599
#endif
    
#if FABLE_COMPILER_PYTHON
    let v600 : std_string_String = null |> unbox<std_string_String>
    v600
#endif
    |> fun x -> _v590 <- Some x
    let v601 : std_string_String = _v590.Value
    let v602 : string = "fable_library_rust::String_::fromString($0)"
    let v603 : string = Fable.Core.RustInterop.emitRustExpr v601 v602
    v603
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v604 : string = null |> unbox<string>
    v604
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v605 : string = null |> unbox<string>
    v605
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v606 : string = System.IO.Path.Combine (v1, v238)
    v606
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v607 : IPathJoin = Fable.Core.JsInterop.importAll v308
    let v608 : string = method15(v1)
    let v609 : string = method16(v238)
    let v610 : string = "v607.join(v608, v609)"
    let v611 : string = Fable.Core.JsInterop.emitJsExpr () v610
    v611
#endif
    
#if FABLE_COMPILER_PYTHON
    let v612 : string = null |> unbox<string>
    v612
#endif
    |> fun x -> _v572 <- Some x
    let v613 : string = _v572.Value
    let v614 : bool option = None
    let v615 : bool = true in let mutable _v614 = v614
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v616 : string = "cfg!(windows)"
    let v617 : bool = Fable.Core.RustInterop.emitRustExpr () v616
    v617
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v618 : bool = null |> unbox<bool>
    v618
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v619 : bool = null |> unbox<bool>
    v619
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v620 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v621 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v622 : bool = v621 v620
    v622
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v623 : bool = null |> unbox<bool>
    v623
#endif
    
#if FABLE_COMPILER_PYTHON
    let v624 : bool = null |> unbox<bool>
    v624
#endif
    |> fun x -> _v614 <- Some x
    let v625 : bool = _v614.Value
    let v626 : bool = v625 = false
    let v647 : string =
        if v626 then
            v613
        else
            let v627 : string option = None
            let v628 : bool = true in let mutable _v627 = v627
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v629 : string = method17()
            let v630 : string = method18(v613)
            let v631 : string = method19()
            let v632 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v633 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v629, v630, v631) v632
            let v634 : string = "String::from($0)"
            let v635 : std_string_String = Fable.Core.RustInterop.emitRustExpr v633 v634
            let v636 : string = "fable_library_rust::String_::fromString($0)"
            let v637 : string = Fable.Core.RustInterop.emitRustExpr v635 v636
            v637
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v638 : string = null |> unbox<string>
            v638
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v639 : string = null |> unbox<string>
            v639
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v640 : string = "^\\\\\\\\\\?\\\\"
            let v641 : string = System.Text.RegularExpressions.Regex.Replace (v613, v640, v233)
            v641
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v642 : string = null |> unbox<string>
            v642
#endif
            
#if FABLE_COMPILER_PYTHON
            let v643 : string = null |> unbox<string>
            v643
#endif
            |> fun x -> _v627 <- Some x
            let v644 : string = _v627.Value
            let v645 : string = $"{v644.[0] |> string |> _.ToLower()}{v644.[1..]}"
            let v646 : string = v645.Replace (v235, v236)
            v646
    let v648 : string option = None
    let v649 : System.Threading.CancellationToken option = None
    let v650 : (struct (string * string) []) = [||]
    let v651 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v652 : string = $"git hash-object \"{v647}\""
    let v653 : string option = Some v1 
    let v654 : struct (int32 * string) option = None
    let v655 : bool = true in let mutable _v654 = v654
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v656 : string = method33(v649, v652, v650, v651, v653)
    let struct (v657 : string, v658 : string) = method34()
    let v659 : int32 = v656.Length
    let v660 : (char []) = Array.zeroCreate<char> (v659)
    let v661 : Mut5 = {l0 = 0} : Mut5
    while method21(v659, v661) do
        let v663 : int32 = v661.l0
        let v664 : char = v656.[int v663]
        v660.[int v663] <- v664
        let v665 : int32 = v663 + 1
        v661.l0 <- v665
        ()
    let v666 : ((char []) -> char list) = Array.toList
    let v667 : char list = v666 v660
    let v668 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v669 : (char -> (UH0 -> UH0)) = method35()
    let v670 : (char list -> (UH0 -> UH0)) = v668 v669
    let v671 : (UH0 -> UH0) = v670 v667
    let v672 : UH0 = UH0_0
    let v673 : UH0 = v671 v672
    let v674 : US8 = US8_0
    let struct (v675 : string, v676 : string) = method36(v658, v657, v673, v674)
    let v677 : (string []) = method37(v676)
    let v678 : string = "$0.to_vec()"
    let v679 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v677 v678
    let v680 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v681 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v679, v383) v680
    let v682 : US0 = US0_1
    let v683 : (unit -> string) = closure28(v649, v652, v650, v651, v653, v675, v681)
    let v684 : (unit -> string) = method43()
    method3(v682, v683, v684)
    let v685 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method44(v649, v652, v650, v651, v653, v675, v681)
    let v686 : string = "futures_lite::future::block_on($0)"
    let v687 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v685 v686
    let (a, b) = v687
    let v688 : int32 = a
    let v689 : string = b
    struct (v688, v689)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v690 : int32, v691 : string) = null |> unbox<struct (int32 * string)>
    struct (v690, v691)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v692 : int32, v693 : string) = null |> unbox<struct (int32 * string)>
    struct (v692, v693)
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v694 : Async<struct (int32 * string)> option = None
    let v695 : bool = true in let mutable _v694 = v694
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v696 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v696
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v697 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v697
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v698 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v698
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v699 : Async<struct (int32 * string)> option = None
    let v700 : bool = true in let mutable _v699 = v699
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v701 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v701
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v702 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v702
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v703 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v703
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v704 : Async<struct (int32 * string)> option = None
    let mutable _v704 = v704
    async {
    let struct (v705 : string, v706 : string) = method34()
    let v707 : int32 = v652.Length
    let v708 : (char []) = Array.zeroCreate<char> (v707)
    let v709 : Mut5 = {l0 = 0} : Mut5
    while method21(v707, v709) do
        let v711 : int32 = v709.l0
        let v712 : char = v652.[int v711]
        v708.[int v711] <- v712
        let v713 : int32 = v711 + 1
        v709.l0 <- v713
        ()
    let v714 : ((char []) -> char list) = Array.toList
    let v715 : char list = v714 v708
    let v716 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v717 : (char -> (UH0 -> UH0)) = method35()
    let v718 : (char list -> (UH0 -> UH0)) = v716 v717
    let v719 : (UH0 -> UH0) = v718 v715
    let v720 : UH0 = UH0_0
    let v721 : UH0 = v719 v720
    let v722 : US8 = US8_0
    let struct (v723 : string, v724 : string) = method36(v706, v705, v721, v722)
    let v725 : (string -> US7) = method38()
    let v726 : US7 = US7_1
    let v727 : US7 = v653 |> Option.map v725 |> Option.defaultValue v726 
    let v730 : string =
        match v727 with
        | US7_1 -> (* None *)
            v233
        | US7_0(v728) -> (* Some *)
            v728
    let v731 : US0 = US0_1
    let v732 : (unit -> string) = closure44(v649, v652, v650, v651, v653)
    let v733 : (unit -> string) = method43()
    method3(v731, v732, v733)
    let v734 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v735 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v724, StandardOutputEncoding = v734, WorkingDirectory = v730, FileName = v723, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v736 : int32 = v650.Length
    let v737 : Mut5 = {l0 = 0} : Mut5
    while method21(v736, v737) do
        let v739 : int32 = v737.l0
        let struct (v740 : string, v741 : string) = v650.[int v739]
        v735.EnvironmentVariables.[v740] <- v741 
        let v742 : int32 = v739 + 1
        v737.l0 <- v742
        ()
    let v743 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v735)
    use v743 = v743 
    let v744 : System.Diagnostics.Process = v743 
    let v745 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v746 : System.Collections.Concurrent.ConcurrentStack<string> = v745 ()
    let v747 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v649, v652, v650, v651, v653, v744, v746)
    v744.OutputDataReceived.Add v747 
    let v748 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v649, v652, v650, v651, v653, v744, v746)
    v744.ErrorDataReceived.Add v748 
    let v749 : (unit -> bool) = v744.Start
    let v750 : bool = v749 ()
    let v751 : bool = v750 = false
    if v751 then
        let v752 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v752
    let v753 : (unit -> unit) = v744.BeginErrorReadLine
    v753 ()
    let v754 : (unit -> unit) = v744.BeginOutputReadLine
    v754 ()
    let v755 : (System.Threading.CancellationToken -> US16) = method61()
    let v756 : US16 = US16_1
    let v757 : US16 = v649 |> Option.map v755 |> Option.defaultValue v756 
    let v761 : System.Threading.CancellationToken =
        match v757 with
        | US16_1 -> (* None *)
            let v759 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v759
        | US16_0(v758) -> (* Some *)
            v758
    let v762 : Async<System.Threading.CancellationToken> option = None
    let v763 : bool = true in let mutable _v762 = v762
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v764 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v764
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v765 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v765
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v766 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v766
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v767 : Async<System.Threading.CancellationToken> option = None
    let v768 : bool = true in let mutable _v767 = v767
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v769 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v769
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v770 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v770
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v771 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v771
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v772 : Async<System.Threading.CancellationToken> option = None
    let mutable _v772 = v772
    async {
    let v773 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v773 = v773 
    let v774 : System.Threading.CancellationToken = v773 
    let v775 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v776 : (System.Threading.CancellationToken []) = [|v774; v775; v761|]
    let v777 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v778 : System.Threading.CancellationTokenSource = v777 v776
    let v779 : System.Threading.CancellationToken = v778.Token
    return v779 
    }
    |> fun x -> _v772 <- Some x
    let v780 : Async<System.Threading.CancellationToken> = _v772 |> Option.get
    v780
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v781 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v781
#endif
    
#if FABLE_COMPILER_PYTHON
    let v782 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v782
#endif
    |> fun x -> _v767 <- Some x
    let v783 : Async<System.Threading.CancellationToken> = _v767.Value
    v783
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v784 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v784
#endif
    
#if FABLE_COMPILER_PYTHON
    let v785 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v785
#endif
    |> fun x -> _v762 <- Some x
    let v786 : Async<System.Threading.CancellationToken> = _v762.Value
    let! v786 = v786 
    let v787 : System.Threading.CancellationToken = v786 
    let v788 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v787.Register
    let v789 : (unit -> unit) = closure50(v744)
    let v790 : System.Threading.CancellationTokenRegistration = v788 v789
    use v790 = v790 
    let v791 : System.Threading.CancellationTokenRegistration = v790 
    let v792 : Async<int32> option = None
    let v793 : bool = true in let mutable _v792 = v792
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v794 : Async<int32> = null |> unbox<Async<int32>>
    v794
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v795 : Async<int32> = null |> unbox<Async<int32>>
    v795
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v796 : Async<int32> = null |> unbox<Async<int32>>
    v796
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v797 : Async<int32> option = None
    let mutable _v797 = v797
    async {
    try
    let v798 : System.Threading.Tasks.Task = v744.WaitForExitAsync v787 
    let v799 : Async<unit> option = None
    let v800 : bool = true in let mutable _v799 = v799
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v801 : Async<unit> = null |> unbox<Async<unit>>
    v801
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v802 : Async<unit> = null |> unbox<Async<unit>>
    v802
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v803 : Async<unit> = null |> unbox<Async<unit>>
    v803
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v804 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v805 : Async<unit> = v804 v798
    v805
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v806 : Async<unit> = null |> unbox<Async<unit>>
    v806
#endif
    
#if FABLE_COMPILER_PYTHON
    let v807 : Async<unit> = null |> unbox<Async<unit>>
    v807
#endif
    |> fun x -> _v799 <- Some x
    let v808 : Async<unit> = _v799.Value
    do! v808 
    let v809 : int32 = v744.ExitCode
    return v809 
    with ex ->
    let v810 : exn = ex
    let v811 : string option = None
    let v812 : bool = true in let mutable _v811 = v811
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v813 : string = $"%A{v810}"
    v813
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v814 : string = $"%A{v810}"
    v814
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v815 : string = $"%A{v810}"
    v815
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v816 : string = $"{v810.GetType ()}: {v810.Message}"
    v816
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v817 : string = $"%A{v810}"
    v817
#endif
    
#if FABLE_COMPILER_PYTHON
    let v818 : string = $"%A{v810}"
    v818
#endif
    |> fun x -> _v811 <- Some x
    let v819 : string = _v811.Value
    let v820 : (string -> unit) = v746.Push
    v820 v819
    let v821 : System.Threading.Tasks.TaskCanceledException = v810 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v822 : US0 = US0_3
    let v823 : (unit -> string) = closure51(v821)
    let v824 : (unit -> string) = method43()
    method3(v822, v823, v824)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v797 <- Some x
    let v825 : Async<int32> = _v797 |> Option.get
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
    |> fun x -> _v792 <- Some x
    let v828 : Async<int32> = _v792.Value
    let! v828 = v828 
    let v829 : int32 = v828 
    let v830 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v831 : string seq = v830 v746
    let v832 : string = method62()
    let v833 : (string -> (string seq -> string)) = String.concat
    let v834 : (string seq -> string) = v833 v832
    let v835 : string = v834 v831
    let v836 : US0 = US0_1
    let v837 : (unit -> string) = closure52(v829, v835)
    let v838 : (unit -> string) = method43()
    method3(v836, v837, v838)
    return struct (v829, v835) 
    }
    |> fun x -> _v704 <- Some x
    let v839 : Async<struct (int32 * string)> = _v704 |> Option.get
    v839
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v840 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v840
#endif
    
#if FABLE_COMPILER_PYTHON
    let v841 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v841
#endif
    |> fun x -> _v699 <- Some x
    let v842 : Async<struct (int32 * string)> = _v699.Value
    v842
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v843 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v843
#endif
    
#if FABLE_COMPILER_PYTHON
    let v844 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v844
#endif
    |> fun x -> _v694 <- Some x
    let v845 : Async<struct (int32 * string)> = _v694.Value
    let v846 : struct (int32 * string) option = None
    let v847 : bool = true in let mutable _v846 = v846
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v848 : int32, v849 : string) = null |> unbox<struct (int32 * string)>
    struct (v848, v849)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v850 : int32, v851 : string) = null |> unbox<struct (int32 * string)>
    struct (v850, v851)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v852 : int32, v853 : string) = null |> unbox<struct (int32 * string)>
    struct (v852, v853)
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v854 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v855 : int32, v856 : string) = v854 v845
    struct (v855, v856)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v857 : int32, v858 : string) = null |> unbox<struct (int32 * string)>
    struct (v857, v858)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v859 : int32, v860 : string) = null |> unbox<struct (int32 * string)>
    struct (v859, v860)
#endif
    |> fun x -> _v846 <- Some x
    let struct (v861 : int32, v862 : string) = _v846.Value
    struct (v861, v862)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v863 : int32, v864 : string) = null |> unbox<struct (int32 * string)>
    struct (v863, v864)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v865 : int32, v866 : string) = null |> unbox<struct (int32 * string)>
    struct (v865, v866)
#endif
    |> fun x -> _v654 <- Some x
    let struct (v867 : int32, v868 : string) = _v654.Value
    let v869 : bool = v571.Contains v868
    let v870 : bool = v869 = false
    let v3929 : (Result<string, (string * string)> option []) =
        if v870 then
            let v871 : bool option = None
            let v872 : bool = true in let mutable _v871 = v871
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v873 : string = "cfg!(windows)"
            let v874 : bool = Fable.Core.RustInterop.emitRustExpr () v873
            v874
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v875 : bool = null |> unbox<bool>
            v875
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v876 : bool = null |> unbox<bool>
            v876
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v877 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v878 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v879 : bool = v878 v877
            v879
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v880 : bool = null |> unbox<bool>
            v880
#endif
            
#if FABLE_COMPILER_PYTHON
            let v881 : bool = null |> unbox<bool>
            v881
#endif
            |> fun x -> _v871 <- Some x
            let v882 : bool = _v871.Value
            let v883 : bool = v882 = false
            let v904 : string =
                if v883 then
                    v647
                else
                    let v884 : string option = None
                    let v885 : bool = true in let mutable _v884 = v884
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v886 : string = method17()
                    let v887 : string = method18(v647)
                    let v888 : string = method19()
                    let v889 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v890 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v886, v887, v888) v889
                    let v891 : string = "String::from($0)"
                    let v892 : std_string_String = Fable.Core.RustInterop.emitRustExpr v890 v891
                    let v893 : string = "fable_library_rust::String_::fromString($0)"
                    let v894 : string = Fable.Core.RustInterop.emitRustExpr v892 v893
                    v894
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v895 : string = null |> unbox<string>
                    v895
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v896 : string = null |> unbox<string>
                    v896
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v897 : string = "^\\\\\\\\\\?\\\\"
                    let v898 : string = System.Text.RegularExpressions.Regex.Replace (v647, v897, v233)
                    v898
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v899 : string = null |> unbox<string>
                    v899
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v900 : string = null |> unbox<string>
                    v900
#endif
                    |> fun x -> _v884 <- Some x
                    let v901 : string = _v884.Value
                    let v902 : string = $"{v901.[0] |> string |> _.ToLower()}{v901.[1..]}"
                    let v903 : string = v902.Replace (v235, v236)
                    v903
            let v905 : string option = None
            let v906 : System.Threading.CancellationToken option = None
            let v907 : (struct (string * string) []) = [||]
            let v908 : (struct (bool * string * int32) -> Async<unit>) option = None
            let v909 : string = $"pwsh -c \"(Get-FileHash \\\"{v904}\\\" -Algorithm SHA256).Hash\""
            let v910 : struct (int32 * string) option = None
            let v911 : bool = true in let mutable _v910 = v910
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v912 : string = method33(v906, v909, v907, v908, v905)
            let struct (v913 : string, v914 : string) = method34()
            let v915 : int32 = v912.Length
            let v916 : (char []) = Array.zeroCreate<char> (v915)
            let v917 : Mut5 = {l0 = 0} : Mut5
            while method21(v915, v917) do
                let v919 : int32 = v917.l0
                let v920 : char = v912.[int v919]
                v916.[int v919] <- v920
                let v921 : int32 = v919 + 1
                v917.l0 <- v921
                ()
            let v922 : ((char []) -> char list) = Array.toList
            let v923 : char list = v922 v916
            let v924 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v925 : (char -> (UH0 -> UH0)) = method35()
            let v926 : (char list -> (UH0 -> UH0)) = v924 v925
            let v927 : (UH0 -> UH0) = v926 v923
            let v928 : UH0 = UH0_0
            let v929 : UH0 = v927 v928
            let v930 : US8 = US8_0
            let struct (v931 : string, v932 : string) = method36(v914, v913, v929, v930)
            let v933 : (string []) = method37(v932)
            let v934 : string = "$0.to_vec()"
            let v935 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v933 v934
            let v936 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v937 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v935, v383) v936
            let v938 : US0 = US0_1
            let v939 : (unit -> string) = closure28(v906, v909, v907, v908, v905, v931, v937)
            let v940 : (unit -> string) = method43()
            method3(v938, v939, v940)
            let v941 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method44(v906, v909, v907, v908, v905, v931, v937)
            let v942 : string = "futures_lite::future::block_on($0)"
            let v943 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v941 v942
            let (a, b) = v943
            let v944 : int32 = a
            let v945 : string = b
            struct (v944, v945)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v946 : int32, v947 : string) = null |> unbox<struct (int32 * string)>
            struct (v946, v947)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v948 : int32, v949 : string) = null |> unbox<struct (int32 * string)>
            struct (v948, v949)
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v950 : Async<struct (int32 * string)> option = None
            let v951 : bool = true in let mutable _v950 = v950
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v952 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v952
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v953 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v953
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v954 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v954
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v955 : Async<struct (int32 * string)> option = None
            let v956 : bool = true in let mutable _v955 = v955
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v957 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v957
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v958 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v958
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v959 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v959
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v960 : Async<struct (int32 * string)> option = None
            let mutable _v960 = v960
            async {
            let struct (v961 : string, v962 : string) = method34()
            let v963 : int32 = v909.Length
            let v964 : (char []) = Array.zeroCreate<char> (v963)
            let v965 : Mut5 = {l0 = 0} : Mut5
            while method21(v963, v965) do
                let v967 : int32 = v965.l0
                let v968 : char = v909.[int v967]
                v964.[int v967] <- v968
                let v969 : int32 = v967 + 1
                v965.l0 <- v969
                ()
            let v970 : ((char []) -> char list) = Array.toList
            let v971 : char list = v970 v964
            let v972 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v973 : (char -> (UH0 -> UH0)) = method35()
            let v974 : (char list -> (UH0 -> UH0)) = v972 v973
            let v975 : (UH0 -> UH0) = v974 v971
            let v976 : UH0 = UH0_0
            let v977 : UH0 = v975 v976
            let v978 : US8 = US8_0
            let struct (v979 : string, v980 : string) = method36(v962, v961, v977, v978)
            let v981 : (string -> US7) = method38()
            let v982 : US7 = US7_1
            let v983 : US7 = v905 |> Option.map v981 |> Option.defaultValue v982 
            let v986 : string =
                match v983 with
                | US7_1 -> (* None *)
                    v233
                | US7_0(v984) -> (* Some *)
                    v984
            let v987 : US0 = US0_1
            let v988 : (unit -> string) = closure44(v906, v909, v907, v908, v905)
            let v989 : (unit -> string) = method43()
            method3(v987, v988, v989)
            let v990 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v991 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v980, StandardOutputEncoding = v990, WorkingDirectory = v986, FileName = v979, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v992 : int32 = v907.Length
            let v993 : Mut5 = {l0 = 0} : Mut5
            while method21(v992, v993) do
                let v995 : int32 = v993.l0
                let struct (v996 : string, v997 : string) = v907.[int v995]
                v991.EnvironmentVariables.[v996] <- v997 
                let v998 : int32 = v995 + 1
                v993.l0 <- v998
                ()
            let v999 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v991)
            use v999 = v999 
            let v1000 : System.Diagnostics.Process = v999 
            let v1001 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v1002 : System.Collections.Concurrent.ConcurrentStack<string> = v1001 ()
            let v1003 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v906, v909, v907, v908, v905, v1000, v1002)
            v1000.OutputDataReceived.Add v1003 
            let v1004 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v906, v909, v907, v908, v905, v1000, v1002)
            v1000.ErrorDataReceived.Add v1004 
            let v1005 : (unit -> bool) = v1000.Start
            let v1006 : bool = v1005 ()
            let v1007 : bool = v1006 = false
            if v1007 then
                let v1008 : string = $"execute_with_options_async / process_start error"
                failwith<unit> v1008
            let v1009 : (unit -> unit) = v1000.BeginErrorReadLine
            v1009 ()
            let v1010 : (unit -> unit) = v1000.BeginOutputReadLine
            v1010 ()
            let v1011 : (System.Threading.CancellationToken -> US16) = method61()
            let v1012 : US16 = US16_1
            let v1013 : US16 = v906 |> Option.map v1011 |> Option.defaultValue v1012 
            let v1017 : System.Threading.CancellationToken =
                match v1013 with
                | US16_1 -> (* None *)
                    let v1015 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v1015
                | US16_0(v1014) -> (* Some *)
                    v1014
            let v1018 : Async<System.Threading.CancellationToken> option = None
            let v1019 : bool = true in let mutable _v1018 = v1018
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1020 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1020
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1021 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1021
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1022 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1022
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v1023 : Async<System.Threading.CancellationToken> option = None
            let v1024 : bool = true in let mutable _v1023 = v1023
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1025 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1025
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1026 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1026
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1027 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1027
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v1028 : Async<System.Threading.CancellationToken> option = None
            let mutable _v1028 = v1028
            async {
            let v1029 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v1029 = v1029 
            let v1030 : System.Threading.CancellationToken = v1029 
            let v1031 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v1032 : (System.Threading.CancellationToken []) = [|v1030; v1031; v1017|]
            let v1033 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v1034 : System.Threading.CancellationTokenSource = v1033 v1032
            let v1035 : System.Threading.CancellationToken = v1034.Token
            return v1035 
            }
            |> fun x -> _v1028 <- Some x
            let v1036 : Async<System.Threading.CancellationToken> = _v1028 |> Option.get
            v1036
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1037 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1037
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1038 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1038
#endif
            |> fun x -> _v1023 <- Some x
            let v1039 : Async<System.Threading.CancellationToken> = _v1023.Value
            v1039
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1040 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1040
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1041 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1041
#endif
            |> fun x -> _v1018 <- Some x
            let v1042 : Async<System.Threading.CancellationToken> = _v1018.Value
            let! v1042 = v1042 
            let v1043 : System.Threading.CancellationToken = v1042 
            let v1044 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1043.Register
            let v1045 : (unit -> unit) = closure50(v1000)
            let v1046 : System.Threading.CancellationTokenRegistration = v1044 v1045
            use v1046 = v1046 
            let v1047 : System.Threading.CancellationTokenRegistration = v1046 
            let v1048 : Async<int32> option = None
            let v1049 : bool = true in let mutable _v1048 = v1048
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1050 : Async<int32> = null |> unbox<Async<int32>>
            v1050
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1051 : Async<int32> = null |> unbox<Async<int32>>
            v1051
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1052 : Async<int32> = null |> unbox<Async<int32>>
            v1052
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v1053 : Async<int32> option = None
            let mutable _v1053 = v1053
            async {
            try
            let v1054 : System.Threading.Tasks.Task = v1000.WaitForExitAsync v1043 
            let v1055 : Async<unit> option = None
            let v1056 : bool = true in let mutable _v1055 = v1055
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1057 : Async<unit> = null |> unbox<Async<unit>>
            v1057
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1058 : Async<unit> = null |> unbox<Async<unit>>
            v1058
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1059 : Async<unit> = null |> unbox<Async<unit>>
            v1059
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v1060 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v1061 : Async<unit> = v1060 v1054
            v1061
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1062 : Async<unit> = null |> unbox<Async<unit>>
            v1062
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1063 : Async<unit> = null |> unbox<Async<unit>>
            v1063
#endif
            |> fun x -> _v1055 <- Some x
            let v1064 : Async<unit> = _v1055.Value
            do! v1064 
            let v1065 : int32 = v1000.ExitCode
            return v1065 
            with ex ->
            let v1066 : exn = ex
            let v1067 : string option = None
            let v1068 : bool = true in let mutable _v1067 = v1067
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1069 : string = $"%A{v1066}"
            v1069
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1070 : string = $"%A{v1066}"
            v1070
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1071 : string = $"%A{v1066}"
            v1071
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v1072 : string = $"{v1066.GetType ()}: {v1066.Message}"
            v1072
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1073 : string = $"%A{v1066}"
            v1073
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1074 : string = $"%A{v1066}"
            v1074
#endif
            |> fun x -> _v1067 <- Some x
            let v1075 : string = _v1067.Value
            let v1076 : (string -> unit) = v1002.Push
            v1076 v1075
            let v1077 : System.Threading.Tasks.TaskCanceledException = v1066 |> unbox<System.Threading.Tasks.TaskCanceledException>
            let v1078 : US0 = US0_3
            let v1079 : (unit -> string) = closure51(v1077)
            let v1080 : (unit -> string) = method43()
            method3(v1078, v1079, v1080)
            return -2147483648 
            (*
            *)
            }
            |> fun x -> _v1053 <- Some x
            let v1081 : Async<int32> = _v1053 |> Option.get
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
            |> fun x -> _v1048 <- Some x
            let v1084 : Async<int32> = _v1048.Value
            let! v1084 = v1084 
            let v1085 : int32 = v1084 
            let v1086 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v1087 : string seq = v1086 v1002
            let v1088 : string = method62()
            let v1089 : (string -> (string seq -> string)) = String.concat
            let v1090 : (string seq -> string) = v1089 v1088
            let v1091 : string = v1090 v1087
            let v1092 : US0 = US0_1
            let v1093 : (unit -> string) = closure52(v1085, v1091)
            let v1094 : (unit -> string) = method43()
            method3(v1092, v1093, v1094)
            return struct (v1085, v1091) 
            }
            |> fun x -> _v960 <- Some x
            let v1095 : Async<struct (int32 * string)> = _v960 |> Option.get
            v1095
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1096 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v1096
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1097 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v1097
#endif
            |> fun x -> _v955 <- Some x
            let v1098 : Async<struct (int32 * string)> = _v955.Value
            v1098
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1099 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v1099
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1100 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v1100
#endif
            |> fun x -> _v950 <- Some x
            let v1101 : Async<struct (int32 * string)> = _v950.Value
            let v1102 : struct (int32 * string) option = None
            let v1103 : bool = true in let mutable _v1102 = v1102
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v1104 : int32, v1105 : string) = null |> unbox<struct (int32 * string)>
            struct (v1104, v1105)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v1106 : int32, v1107 : string) = null |> unbox<struct (int32 * string)>
            struct (v1106, v1107)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v1108 : int32, v1109 : string) = null |> unbox<struct (int32 * string)>
            struct (v1108, v1109)
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v1110 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
            let struct (v1111 : int32, v1112 : string) = v1110 v1101
            struct (v1111, v1112)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v1113 : int32, v1114 : string) = null |> unbox<struct (int32 * string)>
            struct (v1113, v1114)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v1115 : int32, v1116 : string) = null |> unbox<struct (int32 * string)>
            struct (v1115, v1116)
#endif
            |> fun x -> _v1102 <- Some x
            let struct (v1117 : int32, v1118 : string) = _v1102.Value
            struct (v1117, v1118)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v1119 : int32, v1120 : string) = null |> unbox<struct (int32 * string)>
            struct (v1119, v1120)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v1121 : int32, v1122 : string) = null |> unbox<struct (int32 * string)>
            struct (v1121, v1122)
#endif
            |> fun x -> _v910 <- Some x
            let struct (v1123 : int32, v1124 : string) = _v910.Value
            let v1125 : string option = None
            let v1126 : bool = true in let mutable _v1125 = v1125
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1127 : string = method14(v2)
            let v1128 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1129 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1127 v1128
            let v1130 : string = "String::from($0)"
            let v1131 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1129 v1130
            let v1132 : string = "std::path::PathBuf::from($0)"
            let v1133 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1131 v1132
            let v1134 : string = method14(v238)
            let v1135 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1136 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1134 v1135
            let v1137 : string = "String::from($0)"
            let v1138 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1136 v1137
            let v1139 : string = "$0.join($1)"
            let v1140 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v1133, v1138) v1139
            let v1141 : string = "$0.display()"
            let v1142 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v1140 v1141
            let v1143 : std_string_String option = None
            let v1144 : bool = true in let mutable _v1143 = v1143
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1145 : string = @$"format!(""{{}}"", $0)"
            let v1146 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1142 v1145
            v1146
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1147 : string = @$"format!(""{{}}"", $0)"
            let v1148 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1142 v1147
            v1148
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1149 : string = @$"format!(""{{}}"", $0)"
            let v1150 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1142 v1149
            v1150
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v1151 : std_string_String = null |> unbox<std_string_String>
            v1151
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1152 : std_string_String = null |> unbox<std_string_String>
            v1152
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1153 : std_string_String = null |> unbox<std_string_String>
            v1153
#endif
            |> fun x -> _v1143 <- Some x
            let v1154 : std_string_String = _v1143.Value
            let v1155 : string = "fable_library_rust::String_::fromString($0)"
            let v1156 : string = Fable.Core.RustInterop.emitRustExpr v1154 v1155
            v1156
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1157 : string = null |> unbox<string>
            v1157
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1158 : string = null |> unbox<string>
            v1158
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v1159 : string = System.IO.Path.Combine (v2, v238)
            v1159
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1160 : IPathJoin = Fable.Core.JsInterop.importAll v308
            let v1161 : string = method15(v2)
            let v1162 : string = method16(v238)
            let v1163 : string = "v1160.join(v1161, v1162)"
            let v1164 : string = Fable.Core.JsInterop.emitJsExpr () v1163
            v1164
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1165 : string = null |> unbox<string>
            v1165
#endif
            |> fun x -> _v1125 <- Some x
            let v1166 : string = _v1125.Value
            let v1167 : bool option = None
            let v1168 : bool = true in let mutable _v1167 = v1167
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1169 : string = "cfg!(windows)"
            let v1170 : bool = Fable.Core.RustInterop.emitRustExpr () v1169
            v1170
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1171 : bool = null |> unbox<bool>
            v1171
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1172 : bool = null |> unbox<bool>
            v1172
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v1173 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v1174 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v1175 : bool = v1174 v1173
            v1175
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1176 : bool = null |> unbox<bool>
            v1176
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1177 : bool = null |> unbox<bool>
            v1177
#endif
            |> fun x -> _v1167 <- Some x
            let v1178 : bool = _v1167.Value
            let v1179 : bool = v1178 = false
            let v1200 : string =
                if v1179 then
                    v1166
                else
                    let v1180 : string option = None
                    let v1181 : bool = true in let mutable _v1180 = v1180
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1182 : string = method17()
                    let v1183 : string = method18(v1166)
                    let v1184 : string = method19()
                    let v1185 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v1186 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1182, v1183, v1184) v1185
                    let v1187 : string = "String::from($0)"
                    let v1188 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1186 v1187
                    let v1189 : string = "fable_library_rust::String_::fromString($0)"
                    let v1190 : string = Fable.Core.RustInterop.emitRustExpr v1188 v1189
                    v1190
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1191 : string = null |> unbox<string>
                    v1191
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1192 : string = null |> unbox<string>
                    v1192
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1193 : string = "^\\\\\\\\\\?\\\\"
                    let v1194 : string = System.Text.RegularExpressions.Regex.Replace (v1166, v1193, v233)
                    v1194
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1195 : string = null |> unbox<string>
                    v1195
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1196 : string = null |> unbox<string>
                    v1196
#endif
                    |> fun x -> _v1180 <- Some x
                    let v1197 : string = _v1180.Value
                    let v1198 : string = $"{v1197.[0] |> string |> _.ToLower()}{v1197.[1..]}"
                    let v1199 : string = v1198.Replace (v235, v236)
                    v1199
            let v1201 : bool option = None
            let v1202 : bool = true in let mutable _v1201 = v1201
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1203 : string = method14(v1200)
            let v1204 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1205 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1203 v1204
            let v1206 : string = "String::from($0)"
            let v1207 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1205 v1206
            let v1208 : string = "std::path::PathBuf::from($0)"
            let v1209 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1207 v1208
            let v1210 : string = "$0.exists()"
            let v1211 : bool = Fable.Core.RustInterop.emitRustExpr v1209 v1210
            let v1214 : bool =
                if v1211 then
                    let v1212 : string = "$0.is_file()"
                    let v1213 : bool = Fable.Core.RustInterop.emitRustExpr v1209 v1212
                    v1213
                else
                    false
            v1214
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1215 : bool = null |> unbox<bool>
            v1215
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1216 : bool = null |> unbox<bool>
            v1216
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v1217 : (string -> bool) = System.IO.File.Exists
            let v1218 : bool = v1217 v1200
            v1218
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1219 : string = "fs"
            let v1220 : IFsExistsSync = Fable.Core.JsInterop.importAll v1219
            let v1221 : string = "v1220.existsSync($0)"
            let v1222 : bool = Fable.Core.JsInterop.emitJsExpr v1200 v1221
            v1222
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1223 : bool = null |> unbox<bool>
            v1223
#endif
            |> fun x -> _v1201 <- Some x
            let v1224 : bool = _v1201.Value
            let v1479 : string =
                if v1224 then
                    let v1225 : bool option = None
                    let v1226 : bool = true in let mutable _v1225 = v1225
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1227 : string = "cfg!(windows)"
                    let v1228 : bool = Fable.Core.RustInterop.emitRustExpr () v1227
                    v1228
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1229 : bool = null |> unbox<bool>
                    v1229
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1230 : bool = null |> unbox<bool>
                    v1230
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1231 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                    let v1232 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                    let v1233 : bool = v1232 v1231
                    v1233
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1234 : bool = null |> unbox<bool>
                    v1234
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1235 : bool = null |> unbox<bool>
                    v1235
#endif
                    |> fun x -> _v1225 <- Some x
                    let v1236 : bool = _v1225.Value
                    let v1237 : bool = v1236 = false
                    let v1258 : string =
                        if v1237 then
                            v1200
                        else
                            let v1238 : string option = None
                            let v1239 : bool = true in let mutable _v1238 = v1238
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v1240 : string = method17()
                            let v1241 : string = method18(v1200)
                            let v1242 : string = method19()
                            let v1243 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                            let v1244 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1240, v1241, v1242) v1243
                            let v1245 : string = "String::from($0)"
                            let v1246 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1244 v1245
                            let v1247 : string = "fable_library_rust::String_::fromString($0)"
                            let v1248 : string = Fable.Core.RustInterop.emitRustExpr v1246 v1247
                            v1248
#endif
                            
#if FABLE_COMPILER_RUST && WASM
                            let v1249 : string = null |> unbox<string>
                            v1249
#endif
                            
#if FABLE_COMPILER_RUST && CONTRACT
                            let v1250 : string = null |> unbox<string>
                            v1250
#endif
                            
#if !FABLE_COMPILER && !WASM && !CONTRACT
                            let v1251 : string = "^\\\\\\\\\\?\\\\"
                            let v1252 : string = System.Text.RegularExpressions.Regex.Replace (v1200, v1251, v233)
                            v1252
#endif
                            
#if FABLE_COMPILER_TYPESCRIPT
                            let v1253 : string = null |> unbox<string>
                            v1253
#endif
                            
#if FABLE_COMPILER_PYTHON
                            let v1254 : string = null |> unbox<string>
                            v1254
#endif
                            |> fun x -> _v1238 <- Some x
                            let v1255 : string = _v1238.Value
                            let v1256 : string = $"{v1255.[0] |> string |> _.ToLower()}{v1255.[1..]}"
                            let v1257 : string = v1256.Replace (v235, v236)
                            v1257
                    let v1259 : string option = None
                    let v1260 : System.Threading.CancellationToken option = None
                    let v1261 : (struct (string * string) []) = [||]
                    let v1262 : (struct (bool * string * int32) -> Async<unit>) option = None
                    let v1263 : string = $"pwsh -c \"(Get-FileHash \\\"{v1258}\\\" -Algorithm SHA256).Hash\""
                    let v1264 : struct (int32 * string) option = None
                    let v1265 : bool = true in let mutable _v1264 = v1264
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1266 : string = method33(v1260, v1263, v1261, v1262, v1259)
                    let struct (v1267 : string, v1268 : string) = method34()
                    let v1269 : int32 = v1266.Length
                    let v1270 : (char []) = Array.zeroCreate<char> (v1269)
                    let v1271 : Mut5 = {l0 = 0} : Mut5
                    while method21(v1269, v1271) do
                        let v1273 : int32 = v1271.l0
                        let v1274 : char = v1266.[int v1273]
                        v1270.[int v1273] <- v1274
                        let v1275 : int32 = v1273 + 1
                        v1271.l0 <- v1275
                        ()
                    let v1276 : ((char []) -> char list) = Array.toList
                    let v1277 : char list = v1276 v1270
                    let v1278 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                    let v1279 : (char -> (UH0 -> UH0)) = method35()
                    let v1280 : (char list -> (UH0 -> UH0)) = v1278 v1279
                    let v1281 : (UH0 -> UH0) = v1280 v1277
                    let v1282 : UH0 = UH0_0
                    let v1283 : UH0 = v1281 v1282
                    let v1284 : US8 = US8_0
                    let struct (v1285 : string, v1286 : string) = method36(v1268, v1267, v1283, v1284)
                    let v1287 : (string []) = method37(v1286)
                    let v1288 : string = "$0.to_vec()"
                    let v1289 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v1287 v1288
                    let v1290 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                    let v1291 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1289, v383) v1290
                    let v1292 : US0 = US0_1
                    let v1293 : (unit -> string) = closure28(v1260, v1263, v1261, v1262, v1259, v1285, v1291)
                    let v1294 : (unit -> string) = method43()
                    method3(v1292, v1293, v1294)
                    let v1295 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method44(v1260, v1263, v1261, v1262, v1259, v1285, v1291)
                    let v1296 : string = "futures_lite::future::block_on($0)"
                    let v1297 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v1295 v1296
                    let (a, b) = v1297
                    let v1298 : int32 = a
                    let v1299 : string = b
                    struct (v1298, v1299)
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let struct (v1300 : int32, v1301 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1300, v1301)
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let struct (v1302 : int32, v1303 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1302, v1303)
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1304 : Async<struct (int32 * string)> option = None
                    let v1305 : bool = true in let mutable _v1304 = v1304
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1306 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1306
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1307 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1307
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1308 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1308
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1309 : Async<struct (int32 * string)> option = None
                    let v1310 : bool = true in let mutable _v1309 = v1309
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1311 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1311
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1312 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1312
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1313 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1313
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1314 : Async<struct (int32 * string)> option = None
                    let mutable _v1314 = v1314
                    async {
                    let struct (v1315 : string, v1316 : string) = method34()
                    let v1317 : int32 = v1263.Length
                    let v1318 : (char []) = Array.zeroCreate<char> (v1317)
                    let v1319 : Mut5 = {l0 = 0} : Mut5
                    while method21(v1317, v1319) do
                        let v1321 : int32 = v1319.l0
                        let v1322 : char = v1263.[int v1321]
                        v1318.[int v1321] <- v1322
                        let v1323 : int32 = v1321 + 1
                        v1319.l0 <- v1323
                        ()
                    let v1324 : ((char []) -> char list) = Array.toList
                    let v1325 : char list = v1324 v1318
                    let v1326 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                    let v1327 : (char -> (UH0 -> UH0)) = method35()
                    let v1328 : (char list -> (UH0 -> UH0)) = v1326 v1327
                    let v1329 : (UH0 -> UH0) = v1328 v1325
                    let v1330 : UH0 = UH0_0
                    let v1331 : UH0 = v1329 v1330
                    let v1332 : US8 = US8_0
                    let struct (v1333 : string, v1334 : string) = method36(v1316, v1315, v1331, v1332)
                    let v1335 : (string -> US7) = method38()
                    let v1336 : US7 = US7_1
                    let v1337 : US7 = v1259 |> Option.map v1335 |> Option.defaultValue v1336 
                    let v1340 : string =
                        match v1337 with
                        | US7_1 -> (* None *)
                            v233
                        | US7_0(v1338) -> (* Some *)
                            v1338
                    let v1341 : US0 = US0_1
                    let v1342 : (unit -> string) = closure44(v1260, v1263, v1261, v1262, v1259)
                    let v1343 : (unit -> string) = method43()
                    method3(v1341, v1342, v1343)
                    let v1344 : System.Text.Encoding = System.Text.Encoding.UTF8
                    let v1345 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v1334, StandardOutputEncoding = v1344, WorkingDirectory = v1340, FileName = v1333, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                    let v1346 : int32 = v1261.Length
                    let v1347 : Mut5 = {l0 = 0} : Mut5
                    while method21(v1346, v1347) do
                        let v1349 : int32 = v1347.l0
                        let struct (v1350 : string, v1351 : string) = v1261.[int v1349]
                        v1345.EnvironmentVariables.[v1350] <- v1351 
                        let v1352 : int32 = v1349 + 1
                        v1347.l0 <- v1352
                        ()
                    let v1353 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1345)
                    use v1353 = v1353 
                    let v1354 : System.Diagnostics.Process = v1353 
                    let v1355 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                    let v1356 : System.Collections.Concurrent.ConcurrentStack<string> = v1355 ()
                    let v1357 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v1260, v1263, v1261, v1262, v1259, v1354, v1356)
                    v1354.OutputDataReceived.Add v1357 
                    let v1358 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v1260, v1263, v1261, v1262, v1259, v1354, v1356)
                    v1354.ErrorDataReceived.Add v1358 
                    let v1359 : (unit -> bool) = v1354.Start
                    let v1360 : bool = v1359 ()
                    let v1361 : bool = v1360 = false
                    if v1361 then
                        let v1362 : string = $"execute_with_options_async / process_start error"
                        failwith<unit> v1362
                    let v1363 : (unit -> unit) = v1354.BeginErrorReadLine
                    v1363 ()
                    let v1364 : (unit -> unit) = v1354.BeginOutputReadLine
                    v1364 ()
                    let v1365 : (System.Threading.CancellationToken -> US16) = method61()
                    let v1366 : US16 = US16_1
                    let v1367 : US16 = v1260 |> Option.map v1365 |> Option.defaultValue v1366 
                    let v1371 : System.Threading.CancellationToken =
                        match v1367 with
                        | US16_1 -> (* None *)
                            let v1369 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                            v1369
                        | US16_0(v1368) -> (* Some *)
                            v1368
                    let v1372 : Async<System.Threading.CancellationToken> option = None
                    let v1373 : bool = true in let mutable _v1372 = v1372
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1374 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1374
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1375 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1375
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1376 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1376
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1377 : Async<System.Threading.CancellationToken> option = None
                    let v1378 : bool = true in let mutable _v1377 = v1377
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1379 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1379
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1380 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1380
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1381 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1381
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1382 : Async<System.Threading.CancellationToken> option = None
                    let mutable _v1382 = v1382
                    async {
                    let v1383 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v1383 = v1383 
                    let v1384 : System.Threading.CancellationToken = v1383 
                    let v1385 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v1386 : (System.Threading.CancellationToken []) = [|v1384; v1385; v1371|]
                    let v1387 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v1388 : System.Threading.CancellationTokenSource = v1387 v1386
                    let v1389 : System.Threading.CancellationToken = v1388.Token
                    return v1389 
                    }
                    |> fun x -> _v1382 <- Some x
                    let v1390 : Async<System.Threading.CancellationToken> = _v1382 |> Option.get
                    v1390
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1391 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1391
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1392 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1392
#endif
                    |> fun x -> _v1377 <- Some x
                    let v1393 : Async<System.Threading.CancellationToken> = _v1377.Value
                    v1393
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1394 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1394
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1395 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1395
#endif
                    |> fun x -> _v1372 <- Some x
                    let v1396 : Async<System.Threading.CancellationToken> = _v1372.Value
                    let! v1396 = v1396 
                    let v1397 : System.Threading.CancellationToken = v1396 
                    let v1398 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1397.Register
                    let v1399 : (unit -> unit) = closure50(v1354)
                    let v1400 : System.Threading.CancellationTokenRegistration = v1398 v1399
                    use v1400 = v1400 
                    let v1401 : System.Threading.CancellationTokenRegistration = v1400 
                    let v1402 : Async<int32> option = None
                    let v1403 : bool = true in let mutable _v1402 = v1402
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1404 : Async<int32> = null |> unbox<Async<int32>>
                    v1404
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1405 : Async<int32> = null |> unbox<Async<int32>>
                    v1405
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1406 : Async<int32> = null |> unbox<Async<int32>>
                    v1406
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1407 : Async<int32> option = None
                    let mutable _v1407 = v1407
                    async {
                    try
                    let v1408 : System.Threading.Tasks.Task = v1354.WaitForExitAsync v1397 
                    let v1409 : Async<unit> option = None
                    let v1410 : bool = true in let mutable _v1409 = v1409
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1411 : Async<unit> = null |> unbox<Async<unit>>
                    v1411
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1412 : Async<unit> = null |> unbox<Async<unit>>
                    v1412
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1413 : Async<unit> = null |> unbox<Async<unit>>
                    v1413
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1414 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1415 : Async<unit> = v1414 v1408
                    v1415
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1416 : Async<unit> = null |> unbox<Async<unit>>
                    v1416
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1417 : Async<unit> = null |> unbox<Async<unit>>
                    v1417
#endif
                    |> fun x -> _v1409 <- Some x
                    let v1418 : Async<unit> = _v1409.Value
                    do! v1418 
                    let v1419 : int32 = v1354.ExitCode
                    return v1419 
                    with ex ->
                    let v1420 : exn = ex
                    let v1421 : string option = None
                    let v1422 : bool = true in let mutable _v1421 = v1421
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1423 : string = $"%A{v1420}"
                    v1423
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1424 : string = $"%A{v1420}"
                    v1424
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1425 : string = $"%A{v1420}"
                    v1425
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1426 : string = $"{v1420.GetType ()}: {v1420.Message}"
                    v1426
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1427 : string = $"%A{v1420}"
                    v1427
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1428 : string = $"%A{v1420}"
                    v1428
#endif
                    |> fun x -> _v1421 <- Some x
                    let v1429 : string = _v1421.Value
                    let v1430 : (string -> unit) = v1356.Push
                    v1430 v1429
                    let v1431 : System.Threading.Tasks.TaskCanceledException = v1420 |> unbox<System.Threading.Tasks.TaskCanceledException>
                    let v1432 : US0 = US0_3
                    let v1433 : (unit -> string) = closure51(v1431)
                    let v1434 : (unit -> string) = method43()
                    method3(v1432, v1433, v1434)
                    return -2147483648 
                    (*
                    *)
                    }
                    |> fun x -> _v1407 <- Some x
                    let v1435 : Async<int32> = _v1407 |> Option.get
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
                    |> fun x -> _v1402 <- Some x
                    let v1438 : Async<int32> = _v1402.Value
                    let! v1438 = v1438 
                    let v1439 : int32 = v1438 
                    let v1440 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                    let v1441 : string seq = v1440 v1356
                    let v1442 : string = method62()
                    let v1443 : (string -> (string seq -> string)) = String.concat
                    let v1444 : (string seq -> string) = v1443 v1442
                    let v1445 : string = v1444 v1441
                    let v1446 : US0 = US0_1
                    let v1447 : (unit -> string) = closure52(v1439, v1445)
                    let v1448 : (unit -> string) = method43()
                    method3(v1446, v1447, v1448)
                    return struct (v1439, v1445) 
                    }
                    |> fun x -> _v1314 <- Some x
                    let v1449 : Async<struct (int32 * string)> = _v1314 |> Option.get
                    v1449
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1450 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1450
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1451 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1451
#endif
                    |> fun x -> _v1309 <- Some x
                    let v1452 : Async<struct (int32 * string)> = _v1309.Value
                    v1452
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1453 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1453
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1454 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1454
#endif
                    |> fun x -> _v1304 <- Some x
                    let v1455 : Async<struct (int32 * string)> = _v1304.Value
                    let v1456 : struct (int32 * string) option = None
                    let v1457 : bool = true in let mutable _v1456 = v1456
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let struct (v1458 : int32, v1459 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1458, v1459)
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let struct (v1460 : int32, v1461 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1460, v1461)
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let struct (v1462 : int32, v1463 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1462, v1463)
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1464 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                    let struct (v1465 : int32, v1466 : string) = v1464 v1455
                    struct (v1465, v1466)
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let struct (v1467 : int32, v1468 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1467, v1468)
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let struct (v1469 : int32, v1470 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1469, v1470)
#endif
                    |> fun x -> _v1456 <- Some x
                    let struct (v1471 : int32, v1472 : string) = _v1456.Value
                    struct (v1471, v1472)
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let struct (v1473 : int32, v1474 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1473, v1474)
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let struct (v1475 : int32, v1476 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1475, v1476)
#endif
                    |> fun x -> _v1264 <- Some x
                    let struct (v1477 : int32, v1478 : string) = _v1264.Value
                    v1478
                else
                    v233
            let v1480 : bool = v1124 <> v1479
            if v1480 then
                let v1481 : Result<string, (string * string)> option = None
                let v1482 : string = "epub"
                let v1483 : string = $"{v647}.{v1482}"
                let v1484 : string = $"{v1200}.{v1482}"
                let v1485 : bool option = None
                let v1486 : bool = true in let mutable _v1485 = v1485
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1487 : string = method14(v1483)
                let v1488 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                let v1489 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1487 v1488
                let v1490 : string = "String::from($0)"
                let v1491 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1489 v1490
                let v1492 : string = "std::path::PathBuf::from($0)"
                let v1493 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1491 v1492
                let v1494 : string = "$0.exists()"
                let v1495 : bool = Fable.Core.RustInterop.emitRustExpr v1493 v1494
                let v1498 : bool =
                    if v1495 then
                        let v1496 : string = "$0.is_file()"
                        let v1497 : bool = Fable.Core.RustInterop.emitRustExpr v1493 v1496
                        v1497
                    else
                        false
                v1498
#endif
                
#if FABLE_COMPILER_RUST && WASM
                let v1499 : bool = null |> unbox<bool>
                v1499
#endif
                
#if FABLE_COMPILER_RUST && CONTRACT
                let v1500 : bool = null |> unbox<bool>
                v1500
#endif
                
#if !FABLE_COMPILER && !WASM && !CONTRACT
                let v1501 : (string -> bool) = System.IO.File.Exists
                let v1502 : bool = v1501 v1483
                v1502
#endif
                
#if FABLE_COMPILER_TYPESCRIPT
                let v1503 : IFsExistsSync = Fable.Core.JsInterop.importAll v1219
                let v1504 : string = "v1503.existsSync($0)"
                let v1505 : bool = Fable.Core.JsInterop.emitJsExpr v1483 v1504
                v1505
#endif
                
#if FABLE_COMPILER_PYTHON
                let v1506 : bool = null |> unbox<bool>
                v1506
#endif
                |> fun x -> _v1485 <- Some x
                let v1507 : bool = _v1485.Value
                let v1531 : bool =
                    if v1507 then
                        let v1508 : bool option = None
                        let v1509 : bool = true in let mutable _v1508 = v1508
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1510 : string = method14(v1484)
                        let v1511 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                        let v1512 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1510 v1511
                        let v1513 : string = "String::from($0)"
                        let v1514 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1512 v1513
                        let v1515 : string = "std::path::PathBuf::from($0)"
                        let v1516 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1514 v1515
                        let v1517 : string = "$0.exists()"
                        let v1518 : bool = Fable.Core.RustInterop.emitRustExpr v1516 v1517
                        let v1521 : bool =
                            if v1518 then
                                let v1519 : string = "$0.is_file()"
                                let v1520 : bool = Fable.Core.RustInterop.emitRustExpr v1516 v1519
                                v1520
                            else
                                false
                        v1521
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1522 : bool = null |> unbox<bool>
                        v1522
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1523 : bool = null |> unbox<bool>
                        v1523
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1524 : (string -> bool) = System.IO.File.Exists
                        let v1525 : bool = v1524 v1484
                        v1525
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1526 : IFsExistsSync = Fable.Core.JsInterop.importAll v1219
                        let v1527 : string = "v1526.existsSync($0)"
                        let v1528 : bool = Fable.Core.JsInterop.emitJsExpr v1484 v1527
                        v1528
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1529 : bool = null |> unbox<bool>
                        v1529
#endif
                        |> fun x -> _v1508 <- Some x
                        let v1530 : bool = _v1508.Value
                        v1530
                    else
                        false
                let v2041 : bool =
                    if v1531 then
                        let v1532 : bool option = None
                        let v1533 : bool = true in let mutable _v1532 = v1532
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1534 : string = "cfg!(windows)"
                        let v1535 : bool = Fable.Core.RustInterop.emitRustExpr () v1534
                        v1535
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1536 : bool = null |> unbox<bool>
                        v1536
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1537 : bool = null |> unbox<bool>
                        v1537
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1538 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                        let v1539 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                        let v1540 : bool = v1539 v1538
                        v1540
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1541 : bool = null |> unbox<bool>
                        v1541
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1542 : bool = null |> unbox<bool>
                        v1542
#endif
                        |> fun x -> _v1532 <- Some x
                        let v1543 : bool = _v1532.Value
                        let v1544 : bool = v1543 = false
                        let v1565 : string =
                            if v1544 then
                                v1483
                            else
                                let v1545 : string option = None
                                let v1546 : bool = true in let mutable _v1545 = v1545
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v1547 : string = method17()
                                let v1548 : string = method18(v1483)
                                let v1549 : string = method19()
                                let v1550 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                                let v1551 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1547, v1548, v1549) v1550
                                let v1552 : string = "String::from($0)"
                                let v1553 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1551 v1552
                                let v1554 : string = "fable_library_rust::String_::fromString($0)"
                                let v1555 : string = Fable.Core.RustInterop.emitRustExpr v1553 v1554
                                v1555
#endif
                                
#if FABLE_COMPILER_RUST && WASM
                                let v1556 : string = null |> unbox<string>
                                v1556
#endif
                                
#if FABLE_COMPILER_RUST && CONTRACT
                                let v1557 : string = null |> unbox<string>
                                v1557
#endif
                                
#if !FABLE_COMPILER && !WASM && !CONTRACT
                                let v1558 : string = "^\\\\\\\\\\?\\\\"
                                let v1559 : string = System.Text.RegularExpressions.Regex.Replace (v1483, v1558, v233)
                                v1559
#endif
                                
#if FABLE_COMPILER_TYPESCRIPT
                                let v1560 : string = null |> unbox<string>
                                v1560
#endif
                                
#if FABLE_COMPILER_PYTHON
                                let v1561 : string = null |> unbox<string>
                                v1561
#endif
                                |> fun x -> _v1545 <- Some x
                                let v1562 : string = _v1545.Value
                                let v1563 : string = $"{v1562.[0] |> string |> _.ToLower()}{v1562.[1..]}"
                                let v1564 : string = v1563.Replace (v235, v236)
                                v1564
                        let v1566 : string option = None
                        let v1567 : System.Threading.CancellationToken option = None
                        let v1568 : (struct (string * string) []) = [||]
                        let v1569 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v1570 : string = $"pwsh -c \"(Get-FileHash \\\"{v1565}\\\" -Algorithm SHA256).Hash\""
                        let v1571 : struct (int32 * string) option = None
                        let v1572 : bool = true in let mutable _v1571 = v1571
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1573 : string = method33(v1567, v1570, v1568, v1569, v1566)
                        let struct (v1574 : string, v1575 : string) = method34()
                        let v1576 : int32 = v1573.Length
                        let v1577 : (char []) = Array.zeroCreate<char> (v1576)
                        let v1578 : Mut5 = {l0 = 0} : Mut5
                        while method21(v1576, v1578) do
                            let v1580 : int32 = v1578.l0
                            let v1581 : char = v1573.[int v1580]
                            v1577.[int v1580] <- v1581
                            let v1582 : int32 = v1580 + 1
                            v1578.l0 <- v1582
                            ()
                        let v1583 : ((char []) -> char list) = Array.toList
                        let v1584 : char list = v1583 v1577
                        let v1585 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v1586 : (char -> (UH0 -> UH0)) = method35()
                        let v1587 : (char list -> (UH0 -> UH0)) = v1585 v1586
                        let v1588 : (UH0 -> UH0) = v1587 v1584
                        let v1589 : UH0 = UH0_0
                        let v1590 : UH0 = v1588 v1589
                        let v1591 : US8 = US8_0
                        let struct (v1592 : string, v1593 : string) = method36(v1575, v1574, v1590, v1591)
                        let v1594 : (string []) = method37(v1593)
                        let v1595 : string = "$0.to_vec()"
                        let v1596 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v1594 v1595
                        let v1597 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v1598 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1596, v383) v1597
                        let v1599 : US0 = US0_1
                        let v1600 : (unit -> string) = closure28(v1567, v1570, v1568, v1569, v1566, v1592, v1598)
                        let v1601 : (unit -> string) = method43()
                        method3(v1599, v1600, v1601)
                        let v1602 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method44(v1567, v1570, v1568, v1569, v1566, v1592, v1598)
                        let v1603 : string = "futures_lite::future::block_on($0)"
                        let v1604 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v1602 v1603
                        let (a, b) = v1604
                        let v1605 : int32 = a
                        let v1606 : string = b
                        struct (v1605, v1606)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v1607 : int32, v1608 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1607, v1608)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v1609 : int32, v1610 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1609, v1610)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1611 : Async<struct (int32 * string)> option = None
                        let v1612 : bool = true in let mutable _v1611 = v1611
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1613 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1613
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1614 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1614
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1615 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1615
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1616 : Async<struct (int32 * string)> option = None
                        let v1617 : bool = true in let mutable _v1616 = v1616
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1618 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1618
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1619 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1619
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1620 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1620
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1621 : Async<struct (int32 * string)> option = None
                        let mutable _v1621 = v1621
                        async {
                        let struct (v1622 : string, v1623 : string) = method34()
                        let v1624 : int32 = v1570.Length
                        let v1625 : (char []) = Array.zeroCreate<char> (v1624)
                        let v1626 : Mut5 = {l0 = 0} : Mut5
                        while method21(v1624, v1626) do
                            let v1628 : int32 = v1626.l0
                            let v1629 : char = v1570.[int v1628]
                            v1625.[int v1628] <- v1629
                            let v1630 : int32 = v1628 + 1
                            v1626.l0 <- v1630
                            ()
                        let v1631 : ((char []) -> char list) = Array.toList
                        let v1632 : char list = v1631 v1625
                        let v1633 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v1634 : (char -> (UH0 -> UH0)) = method35()
                        let v1635 : (char list -> (UH0 -> UH0)) = v1633 v1634
                        let v1636 : (UH0 -> UH0) = v1635 v1632
                        let v1637 : UH0 = UH0_0
                        let v1638 : UH0 = v1636 v1637
                        let v1639 : US8 = US8_0
                        let struct (v1640 : string, v1641 : string) = method36(v1623, v1622, v1638, v1639)
                        let v1642 : (string -> US7) = method38()
                        let v1643 : US7 = US7_1
                        let v1644 : US7 = v1566 |> Option.map v1642 |> Option.defaultValue v1643 
                        let v1647 : string =
                            match v1644 with
                            | US7_1 -> (* None *)
                                v233
                            | US7_0(v1645) -> (* Some *)
                                v1645
                        let v1648 : US0 = US0_1
                        let v1649 : (unit -> string) = closure44(v1567, v1570, v1568, v1569, v1566)
                        let v1650 : (unit -> string) = method43()
                        method3(v1648, v1649, v1650)
                        let v1651 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v1652 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v1641, StandardOutputEncoding = v1651, WorkingDirectory = v1647, FileName = v1640, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v1653 : int32 = v1568.Length
                        let v1654 : Mut5 = {l0 = 0} : Mut5
                        while method21(v1653, v1654) do
                            let v1656 : int32 = v1654.l0
                            let struct (v1657 : string, v1658 : string) = v1568.[int v1656]
                            v1652.EnvironmentVariables.[v1657] <- v1658 
                            let v1659 : int32 = v1656 + 1
                            v1654.l0 <- v1659
                            ()
                        let v1660 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1652)
                        use v1660 = v1660 
                        let v1661 : System.Diagnostics.Process = v1660 
                        let v1662 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v1663 : System.Collections.Concurrent.ConcurrentStack<string> = v1662 ()
                        let v1664 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v1567, v1570, v1568, v1569, v1566, v1661, v1663)
                        v1661.OutputDataReceived.Add v1664 
                        let v1665 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v1567, v1570, v1568, v1569, v1566, v1661, v1663)
                        v1661.ErrorDataReceived.Add v1665 
                        let v1666 : (unit -> bool) = v1661.Start
                        let v1667 : bool = v1666 ()
                        let v1668 : bool = v1667 = false
                        if v1668 then
                            let v1669 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v1669
                        let v1670 : (unit -> unit) = v1661.BeginErrorReadLine
                        v1670 ()
                        let v1671 : (unit -> unit) = v1661.BeginOutputReadLine
                        v1671 ()
                        let v1672 : (System.Threading.CancellationToken -> US16) = method61()
                        let v1673 : US16 = US16_1
                        let v1674 : US16 = v1567 |> Option.map v1672 |> Option.defaultValue v1673 
                        let v1678 : System.Threading.CancellationToken =
                            match v1674 with
                            | US16_1 -> (* None *)
                                let v1676 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v1676
                            | US16_0(v1675) -> (* Some *)
                                v1675
                        let v1679 : Async<System.Threading.CancellationToken> option = None
                        let v1680 : bool = true in let mutable _v1679 = v1679
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1681 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1681
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1682 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1682
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1683 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1683
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1684 : Async<System.Threading.CancellationToken> option = None
                        let v1685 : bool = true in let mutable _v1684 = v1684
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1686 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1686
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1687 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1687
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1688 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1688
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1689 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v1689 = v1689
                        async {
                        let v1690 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v1690 = v1690 
                        let v1691 : System.Threading.CancellationToken = v1690 
                        let v1692 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v1693 : (System.Threading.CancellationToken []) = [|v1691; v1692; v1678|]
                        let v1694 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v1695 : System.Threading.CancellationTokenSource = v1694 v1693
                        let v1696 : System.Threading.CancellationToken = v1695.Token
                        return v1696 
                        }
                        |> fun x -> _v1689 <- Some x
                        let v1697 : Async<System.Threading.CancellationToken> = _v1689 |> Option.get
                        v1697
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1698 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1698
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1699 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1699
#endif
                        |> fun x -> _v1684 <- Some x
                        let v1700 : Async<System.Threading.CancellationToken> = _v1684.Value
                        v1700
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1701 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1701
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1702 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1702
#endif
                        |> fun x -> _v1679 <- Some x
                        let v1703 : Async<System.Threading.CancellationToken> = _v1679.Value
                        let! v1703 = v1703 
                        let v1704 : System.Threading.CancellationToken = v1703 
                        let v1705 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1704.Register
                        let v1706 : (unit -> unit) = closure50(v1661)
                        let v1707 : System.Threading.CancellationTokenRegistration = v1705 v1706
                        use v1707 = v1707 
                        let v1708 : System.Threading.CancellationTokenRegistration = v1707 
                        let v1709 : Async<int32> option = None
                        let v1710 : bool = true in let mutable _v1709 = v1709
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1711 : Async<int32> = null |> unbox<Async<int32>>
                        v1711
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1712 : Async<int32> = null |> unbox<Async<int32>>
                        v1712
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1713 : Async<int32> = null |> unbox<Async<int32>>
                        v1713
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1714 : Async<int32> option = None
                        let mutable _v1714 = v1714
                        async {
                        try
                        let v1715 : System.Threading.Tasks.Task = v1661.WaitForExitAsync v1704 
                        let v1716 : Async<unit> option = None
                        let v1717 : bool = true in let mutable _v1716 = v1716
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1718 : Async<unit> = null |> unbox<Async<unit>>
                        v1718
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1719 : Async<unit> = null |> unbox<Async<unit>>
                        v1719
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1720 : Async<unit> = null |> unbox<Async<unit>>
                        v1720
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1721 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v1722 : Async<unit> = v1721 v1715
                        v1722
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1723 : Async<unit> = null |> unbox<Async<unit>>
                        v1723
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1724 : Async<unit> = null |> unbox<Async<unit>>
                        v1724
#endif
                        |> fun x -> _v1716 <- Some x
                        let v1725 : Async<unit> = _v1716.Value
                        do! v1725 
                        let v1726 : int32 = v1661.ExitCode
                        return v1726 
                        with ex ->
                        let v1727 : exn = ex
                        let v1728 : string option = None
                        let v1729 : bool = true in let mutable _v1728 = v1728
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1730 : string = $"%A{v1727}"
                        v1730
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1731 : string = $"%A{v1727}"
                        v1731
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1732 : string = $"%A{v1727}"
                        v1732
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1733 : string = $"{v1727.GetType ()}: {v1727.Message}"
                        v1733
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1734 : string = $"%A{v1727}"
                        v1734
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1735 : string = $"%A{v1727}"
                        v1735
#endif
                        |> fun x -> _v1728 <- Some x
                        let v1736 : string = _v1728.Value
                        let v1737 : (string -> unit) = v1663.Push
                        v1737 v1736
                        let v1738 : System.Threading.Tasks.TaskCanceledException = v1727 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v1739 : US0 = US0_3
                        let v1740 : (unit -> string) = closure51(v1738)
                        let v1741 : (unit -> string) = method43()
                        method3(v1739, v1740, v1741)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v1714 <- Some x
                        let v1742 : Async<int32> = _v1714 |> Option.get
                        v1742
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1743 : Async<int32> = null |> unbox<Async<int32>>
                        v1743
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1744 : Async<int32> = null |> unbox<Async<int32>>
                        v1744
#endif
                        |> fun x -> _v1709 <- Some x
                        let v1745 : Async<int32> = _v1709.Value
                        let! v1745 = v1745 
                        let v1746 : int32 = v1745 
                        let v1747 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v1748 : string seq = v1747 v1663
                        let v1749 : string = method62()
                        let v1750 : (string -> (string seq -> string)) = String.concat
                        let v1751 : (string seq -> string) = v1750 v1749
                        let v1752 : string = v1751 v1748
                        let v1753 : US0 = US0_1
                        let v1754 : (unit -> string) = closure52(v1746, v1752)
                        let v1755 : (unit -> string) = method43()
                        method3(v1753, v1754, v1755)
                        return struct (v1746, v1752) 
                        }
                        |> fun x -> _v1621 <- Some x
                        let v1756 : Async<struct (int32 * string)> = _v1621 |> Option.get
                        v1756
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1757 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1757
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1758 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1758
#endif
                        |> fun x -> _v1616 <- Some x
                        let v1759 : Async<struct (int32 * string)> = _v1616.Value
                        v1759
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1760 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1760
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1761 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1761
#endif
                        |> fun x -> _v1611 <- Some x
                        let v1762 : Async<struct (int32 * string)> = _v1611.Value
                        let v1763 : struct (int32 * string) option = None
                        let v1764 : bool = true in let mutable _v1763 = v1763
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v1765 : int32, v1766 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1765, v1766)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v1767 : int32, v1768 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1767, v1768)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v1769 : int32, v1770 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1769, v1770)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1771 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v1772 : int32, v1773 : string) = v1771 v1762
                        struct (v1772, v1773)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v1774 : int32, v1775 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1774, v1775)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v1776 : int32, v1777 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1776, v1777)
#endif
                        |> fun x -> _v1763 <- Some x
                        let struct (v1778 : int32, v1779 : string) = _v1763.Value
                        struct (v1778, v1779)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v1780 : int32, v1781 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1780, v1781)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v1782 : int32, v1783 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1782, v1783)
#endif
                        |> fun x -> _v1571 <- Some x
                        let struct (v1784 : int32, v1785 : string) = _v1571.Value
                        let v1786 : bool option = None
                        let v1787 : bool = true in let mutable _v1786 = v1786
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1788 : string = "cfg!(windows)"
                        let v1789 : bool = Fable.Core.RustInterop.emitRustExpr () v1788
                        v1789
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1790 : bool = null |> unbox<bool>
                        v1790
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1791 : bool = null |> unbox<bool>
                        v1791
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1792 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                        let v1793 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                        let v1794 : bool = v1793 v1792
                        v1794
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1795 : bool = null |> unbox<bool>
                        v1795
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1796 : bool = null |> unbox<bool>
                        v1796
#endif
                        |> fun x -> _v1786 <- Some x
                        let v1797 : bool = _v1786.Value
                        let v1798 : bool = v1797 = false
                        let v1819 : string =
                            if v1798 then
                                v1484
                            else
                                let v1799 : string option = None
                                let v1800 : bool = true in let mutable _v1799 = v1799
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v1801 : string = method17()
                                let v1802 : string = method18(v1484)
                                let v1803 : string = method19()
                                let v1804 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                                let v1805 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1801, v1802, v1803) v1804
                                let v1806 : string = "String::from($0)"
                                let v1807 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1805 v1806
                                let v1808 : string = "fable_library_rust::String_::fromString($0)"
                                let v1809 : string = Fable.Core.RustInterop.emitRustExpr v1807 v1808
                                v1809
#endif
                                
#if FABLE_COMPILER_RUST && WASM
                                let v1810 : string = null |> unbox<string>
                                v1810
#endif
                                
#if FABLE_COMPILER_RUST && CONTRACT
                                let v1811 : string = null |> unbox<string>
                                v1811
#endif
                                
#if !FABLE_COMPILER && !WASM && !CONTRACT
                                let v1812 : string = "^\\\\\\\\\\?\\\\"
                                let v1813 : string = System.Text.RegularExpressions.Regex.Replace (v1484, v1812, v233)
                                v1813
#endif
                                
#if FABLE_COMPILER_TYPESCRIPT
                                let v1814 : string = null |> unbox<string>
                                v1814
#endif
                                
#if FABLE_COMPILER_PYTHON
                                let v1815 : string = null |> unbox<string>
                                v1815
#endif
                                |> fun x -> _v1799 <- Some x
                                let v1816 : string = _v1799.Value
                                let v1817 : string = $"{v1816.[0] |> string |> _.ToLower()}{v1816.[1..]}"
                                let v1818 : string = v1817.Replace (v235, v236)
                                v1818
                        let v1820 : string option = None
                        let v1821 : System.Threading.CancellationToken option = None
                        let v1822 : (struct (string * string) []) = [||]
                        let v1823 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v1824 : string = $"pwsh -c \"(Get-FileHash \\\"{v1819}\\\" -Algorithm SHA256).Hash\""
                        let v1825 : struct (int32 * string) option = None
                        let v1826 : bool = true in let mutable _v1825 = v1825
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1827 : string = method33(v1821, v1824, v1822, v1823, v1820)
                        let struct (v1828 : string, v1829 : string) = method34()
                        let v1830 : int32 = v1827.Length
                        let v1831 : (char []) = Array.zeroCreate<char> (v1830)
                        let v1832 : Mut5 = {l0 = 0} : Mut5
                        while method21(v1830, v1832) do
                            let v1834 : int32 = v1832.l0
                            let v1835 : char = v1827.[int v1834]
                            v1831.[int v1834] <- v1835
                            let v1836 : int32 = v1834 + 1
                            v1832.l0 <- v1836
                            ()
                        let v1837 : ((char []) -> char list) = Array.toList
                        let v1838 : char list = v1837 v1831
                        let v1839 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v1840 : (char -> (UH0 -> UH0)) = method35()
                        let v1841 : (char list -> (UH0 -> UH0)) = v1839 v1840
                        let v1842 : (UH0 -> UH0) = v1841 v1838
                        let v1843 : UH0 = UH0_0
                        let v1844 : UH0 = v1842 v1843
                        let v1845 : US8 = US8_0
                        let struct (v1846 : string, v1847 : string) = method36(v1829, v1828, v1844, v1845)
                        let v1848 : (string []) = method37(v1847)
                        let v1849 : string = "$0.to_vec()"
                        let v1850 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v1848 v1849
                        let v1851 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v1852 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1850, v383) v1851
                        let v1853 : US0 = US0_1
                        let v1854 : (unit -> string) = closure28(v1821, v1824, v1822, v1823, v1820, v1846, v1852)
                        let v1855 : (unit -> string) = method43()
                        method3(v1853, v1854, v1855)
                        let v1856 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method44(v1821, v1824, v1822, v1823, v1820, v1846, v1852)
                        let v1857 : string = "futures_lite::future::block_on($0)"
                        let v1858 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v1856 v1857
                        let (a, b) = v1858
                        let v1859 : int32 = a
                        let v1860 : string = b
                        struct (v1859, v1860)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v1861 : int32, v1862 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1861, v1862)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v1863 : int32, v1864 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1863, v1864)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1865 : Async<struct (int32 * string)> option = None
                        let v1866 : bool = true in let mutable _v1865 = v1865
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1867 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1867
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1868 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1868
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1869 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1869
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1870 : Async<struct (int32 * string)> option = None
                        let v1871 : bool = true in let mutable _v1870 = v1870
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1872 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1872
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1873 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1873
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1874 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1874
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1875 : Async<struct (int32 * string)> option = None
                        let mutable _v1875 = v1875
                        async {
                        let struct (v1876 : string, v1877 : string) = method34()
                        let v1878 : int32 = v1824.Length
                        let v1879 : (char []) = Array.zeroCreate<char> (v1878)
                        let v1880 : Mut5 = {l0 = 0} : Mut5
                        while method21(v1878, v1880) do
                            let v1882 : int32 = v1880.l0
                            let v1883 : char = v1824.[int v1882]
                            v1879.[int v1882] <- v1883
                            let v1884 : int32 = v1882 + 1
                            v1880.l0 <- v1884
                            ()
                        let v1885 : ((char []) -> char list) = Array.toList
                        let v1886 : char list = v1885 v1879
                        let v1887 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v1888 : (char -> (UH0 -> UH0)) = method35()
                        let v1889 : (char list -> (UH0 -> UH0)) = v1887 v1888
                        let v1890 : (UH0 -> UH0) = v1889 v1886
                        let v1891 : UH0 = UH0_0
                        let v1892 : UH0 = v1890 v1891
                        let v1893 : US8 = US8_0
                        let struct (v1894 : string, v1895 : string) = method36(v1877, v1876, v1892, v1893)
                        let v1896 : (string -> US7) = method38()
                        let v1897 : US7 = US7_1
                        let v1898 : US7 = v1820 |> Option.map v1896 |> Option.defaultValue v1897 
                        let v1901 : string =
                            match v1898 with
                            | US7_1 -> (* None *)
                                v233
                            | US7_0(v1899) -> (* Some *)
                                v1899
                        let v1902 : US0 = US0_1
                        let v1903 : (unit -> string) = closure44(v1821, v1824, v1822, v1823, v1820)
                        let v1904 : (unit -> string) = method43()
                        method3(v1902, v1903, v1904)
                        let v1905 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v1906 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v1895, StandardOutputEncoding = v1905, WorkingDirectory = v1901, FileName = v1894, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v1907 : int32 = v1822.Length
                        let v1908 : Mut5 = {l0 = 0} : Mut5
                        while method21(v1907, v1908) do
                            let v1910 : int32 = v1908.l0
                            let struct (v1911 : string, v1912 : string) = v1822.[int v1910]
                            v1906.EnvironmentVariables.[v1911] <- v1912 
                            let v1913 : int32 = v1910 + 1
                            v1908.l0 <- v1913
                            ()
                        let v1914 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1906)
                        use v1914 = v1914 
                        let v1915 : System.Diagnostics.Process = v1914 
                        let v1916 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v1917 : System.Collections.Concurrent.ConcurrentStack<string> = v1916 ()
                        let v1918 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v1821, v1824, v1822, v1823, v1820, v1915, v1917)
                        v1915.OutputDataReceived.Add v1918 
                        let v1919 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v1821, v1824, v1822, v1823, v1820, v1915, v1917)
                        v1915.ErrorDataReceived.Add v1919 
                        let v1920 : (unit -> bool) = v1915.Start
                        let v1921 : bool = v1920 ()
                        let v1922 : bool = v1921 = false
                        if v1922 then
                            let v1923 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v1923
                        let v1924 : (unit -> unit) = v1915.BeginErrorReadLine
                        v1924 ()
                        let v1925 : (unit -> unit) = v1915.BeginOutputReadLine
                        v1925 ()
                        let v1926 : (System.Threading.CancellationToken -> US16) = method61()
                        let v1927 : US16 = US16_1
                        let v1928 : US16 = v1821 |> Option.map v1926 |> Option.defaultValue v1927 
                        let v1932 : System.Threading.CancellationToken =
                            match v1928 with
                            | US16_1 -> (* None *)
                                let v1930 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v1930
                            | US16_0(v1929) -> (* Some *)
                                v1929
                        let v1933 : Async<System.Threading.CancellationToken> option = None
                        let v1934 : bool = true in let mutable _v1933 = v1933
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1935 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1935
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1936 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1936
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1937 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1937
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1938 : Async<System.Threading.CancellationToken> option = None
                        let v1939 : bool = true in let mutable _v1938 = v1938
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1940 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1940
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1941 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1941
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1942 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1942
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1943 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v1943 = v1943
                        async {
                        let v1944 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v1944 = v1944 
                        let v1945 : System.Threading.CancellationToken = v1944 
                        let v1946 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v1947 : (System.Threading.CancellationToken []) = [|v1945; v1946; v1932|]
                        let v1948 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v1949 : System.Threading.CancellationTokenSource = v1948 v1947
                        let v1950 : System.Threading.CancellationToken = v1949.Token
                        return v1950 
                        }
                        |> fun x -> _v1943 <- Some x
                        let v1951 : Async<System.Threading.CancellationToken> = _v1943 |> Option.get
                        v1951
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1952 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1952
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1953 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1953
#endif
                        |> fun x -> _v1938 <- Some x
                        let v1954 : Async<System.Threading.CancellationToken> = _v1938.Value
                        v1954
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1955 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1955
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1956 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1956
#endif
                        |> fun x -> _v1933 <- Some x
                        let v1957 : Async<System.Threading.CancellationToken> = _v1933.Value
                        let! v1957 = v1957 
                        let v1958 : System.Threading.CancellationToken = v1957 
                        let v1959 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1958.Register
                        let v1960 : (unit -> unit) = closure50(v1915)
                        let v1961 : System.Threading.CancellationTokenRegistration = v1959 v1960
                        use v1961 = v1961 
                        let v1962 : System.Threading.CancellationTokenRegistration = v1961 
                        let v1963 : Async<int32> option = None
                        let v1964 : bool = true in let mutable _v1963 = v1963
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1965 : Async<int32> = null |> unbox<Async<int32>>
                        v1965
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1966 : Async<int32> = null |> unbox<Async<int32>>
                        v1966
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1967 : Async<int32> = null |> unbox<Async<int32>>
                        v1967
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1968 : Async<int32> option = None
                        let mutable _v1968 = v1968
                        async {
                        try
                        let v1969 : System.Threading.Tasks.Task = v1915.WaitForExitAsync v1958 
                        let v1970 : Async<unit> option = None
                        let v1971 : bool = true in let mutable _v1970 = v1970
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1972 : Async<unit> = null |> unbox<Async<unit>>
                        v1972
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1973 : Async<unit> = null |> unbox<Async<unit>>
                        v1973
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1974 : Async<unit> = null |> unbox<Async<unit>>
                        v1974
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1975 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v1976 : Async<unit> = v1975 v1969
                        v1976
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1977 : Async<unit> = null |> unbox<Async<unit>>
                        v1977
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1978 : Async<unit> = null |> unbox<Async<unit>>
                        v1978
#endif
                        |> fun x -> _v1970 <- Some x
                        let v1979 : Async<unit> = _v1970.Value
                        do! v1979 
                        let v1980 : int32 = v1915.ExitCode
                        return v1980 
                        with ex ->
                        let v1981 : exn = ex
                        let v1982 : string option = None
                        let v1983 : bool = true in let mutable _v1982 = v1982
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1984 : string = $"%A{v1981}"
                        v1984
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1985 : string = $"%A{v1981}"
                        v1985
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1986 : string = $"%A{v1981}"
                        v1986
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1987 : string = $"{v1981.GetType ()}: {v1981.Message}"
                        v1987
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1988 : string = $"%A{v1981}"
                        v1988
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1989 : string = $"%A{v1981}"
                        v1989
#endif
                        |> fun x -> _v1982 <- Some x
                        let v1990 : string = _v1982.Value
                        let v1991 : (string -> unit) = v1917.Push
                        v1991 v1990
                        let v1992 : System.Threading.Tasks.TaskCanceledException = v1981 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v1993 : US0 = US0_3
                        let v1994 : (unit -> string) = closure51(v1992)
                        let v1995 : (unit -> string) = method43()
                        method3(v1993, v1994, v1995)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v1968 <- Some x
                        let v1996 : Async<int32> = _v1968 |> Option.get
                        v1996
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1997 : Async<int32> = null |> unbox<Async<int32>>
                        v1997
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1998 : Async<int32> = null |> unbox<Async<int32>>
                        v1998
#endif
                        |> fun x -> _v1963 <- Some x
                        let v1999 : Async<int32> = _v1963.Value
                        let! v1999 = v1999 
                        let v2000 : int32 = v1999 
                        let v2001 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v2002 : string seq = v2001 v1917
                        let v2003 : string = method62()
                        let v2004 : (string -> (string seq -> string)) = String.concat
                        let v2005 : (string seq -> string) = v2004 v2003
                        let v2006 : string = v2005 v2002
                        let v2007 : US0 = US0_1
                        let v2008 : (unit -> string) = closure52(v2000, v2006)
                        let v2009 : (unit -> string) = method43()
                        method3(v2007, v2008, v2009)
                        return struct (v2000, v2006) 
                        }
                        |> fun x -> _v1875 <- Some x
                        let v2010 : Async<struct (int32 * string)> = _v1875 |> Option.get
                        v2010
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2011 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2011
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2012 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2012
#endif
                        |> fun x -> _v1870 <- Some x
                        let v2013 : Async<struct (int32 * string)> = _v1870.Value
                        v2013
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2014 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2014
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2015 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2015
#endif
                        |> fun x -> _v1865 <- Some x
                        let v2016 : Async<struct (int32 * string)> = _v1865.Value
                        let v2017 : struct (int32 * string) option = None
                        let v2018 : bool = true in let mutable _v2017 = v2017
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v2019 : int32, v2020 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2019, v2020)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v2021 : int32, v2022 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2021, v2022)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2023 : int32, v2024 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2023, v2024)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2025 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v2026 : int32, v2027 : string) = v2025 v2016
                        struct (v2026, v2027)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2028 : int32, v2029 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2028, v2029)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v2030 : int32, v2031 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2030, v2031)
#endif
                        |> fun x -> _v2017 <- Some x
                        let struct (v2032 : int32, v2033 : string) = _v2017.Value
                        struct (v2032, v2033)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2034 : int32, v2035 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2034, v2035)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v2036 : int32, v2037 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2036, v2037)
#endif
                        |> fun x -> _v1825 <- Some x
                        let struct (v2038 : int32, v2039 : string) = _v1825.Value
                        let v2040 : bool = v1785 = v2039
                        v2040
                    else
                        false
                let v2042 : bool = v2041 = false
                let v2285 : US17 =
                    if v2042 then
                        let v2043 : string = $"crowbook --single \"{v647}\" --output \"{v1483}\" --to {v1482} --set rendering.num_depth 6 html.css.add \\\"''' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} '''\\\""
                        let v2044 : string option = None
                        let v2045 : System.Threading.CancellationToken option = None
                        let v2046 : (struct (string * string) []) = [||]
                        let v2047 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v2048 : string option = Some v1 
                        let v2049 : struct (int32 * string) option = None
                        let v2050 : bool = true in let mutable _v2049 = v2049
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2051 : string = method33(v2045, v2043, v2046, v2047, v2048)
                        let struct (v2052 : string, v2053 : string) = method34()
                        let v2054 : int32 = v2051.Length
                        let v2055 : (char []) = Array.zeroCreate<char> (v2054)
                        let v2056 : Mut5 = {l0 = 0} : Mut5
                        while method21(v2054, v2056) do
                            let v2058 : int32 = v2056.l0
                            let v2059 : char = v2051.[int v2058]
                            v2055.[int v2058] <- v2059
                            let v2060 : int32 = v2058 + 1
                            v2056.l0 <- v2060
                            ()
                        let v2061 : ((char []) -> char list) = Array.toList
                        let v2062 : char list = v2061 v2055
                        let v2063 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2064 : (char -> (UH0 -> UH0)) = method35()
                        let v2065 : (char list -> (UH0 -> UH0)) = v2063 v2064
                        let v2066 : (UH0 -> UH0) = v2065 v2062
                        let v2067 : UH0 = UH0_0
                        let v2068 : UH0 = v2066 v2067
                        let v2069 : US8 = US8_0
                        let struct (v2070 : string, v2071 : string) = method36(v2053, v2052, v2068, v2069)
                        let v2072 : (string []) = method37(v2071)
                        let v2073 : string = "$0.to_vec()"
                        let v2074 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v2072 v2073
                        let v2075 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v2076 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2074, v383) v2075
                        let v2077 : US0 = US0_1
                        let v2078 : (unit -> string) = closure28(v2045, v2043, v2046, v2047, v2048, v2070, v2076)
                        let v2079 : (unit -> string) = method43()
                        method3(v2077, v2078, v2079)
                        let v2080 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method44(v2045, v2043, v2046, v2047, v2048, v2070, v2076)
                        let v2081 : string = "futures_lite::future::block_on($0)"
                        let v2082 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v2080 v2081
                        let (a, b) = v2082
                        let v2083 : int32 = a
                        let v2084 : string = b
                        struct (v2083, v2084)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v2085 : int32, v2086 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2085, v2086)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2087 : int32, v2088 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2087, v2088)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2089 : Async<struct (int32 * string)> option = None
                        let v2090 : bool = true in let mutable _v2089 = v2089
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2091 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2091
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2092 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2092
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2093 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2093
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2094 : Async<struct (int32 * string)> option = None
                        let v2095 : bool = true in let mutable _v2094 = v2094
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2096 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2096
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2097 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2097
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2098 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2098
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2099 : Async<struct (int32 * string)> option = None
                        let mutable _v2099 = v2099
                        async {
                        let struct (v2100 : string, v2101 : string) = method34()
                        let v2102 : int32 = v2043.Length
                        let v2103 : (char []) = Array.zeroCreate<char> (v2102)
                        let v2104 : Mut5 = {l0 = 0} : Mut5
                        while method21(v2102, v2104) do
                            let v2106 : int32 = v2104.l0
                            let v2107 : char = v2043.[int v2106]
                            v2103.[int v2106] <- v2107
                            let v2108 : int32 = v2106 + 1
                            v2104.l0 <- v2108
                            ()
                        let v2109 : ((char []) -> char list) = Array.toList
                        let v2110 : char list = v2109 v2103
                        let v2111 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2112 : (char -> (UH0 -> UH0)) = method35()
                        let v2113 : (char list -> (UH0 -> UH0)) = v2111 v2112
                        let v2114 : (UH0 -> UH0) = v2113 v2110
                        let v2115 : UH0 = UH0_0
                        let v2116 : UH0 = v2114 v2115
                        let v2117 : US8 = US8_0
                        let struct (v2118 : string, v2119 : string) = method36(v2101, v2100, v2116, v2117)
                        let v2120 : (string -> US7) = method38()
                        let v2121 : US7 = US7_1
                        let v2122 : US7 = v2048 |> Option.map v2120 |> Option.defaultValue v2121 
                        let v2125 : string =
                            match v2122 with
                            | US7_1 -> (* None *)
                                v233
                            | US7_0(v2123) -> (* Some *)
                                v2123
                        let v2126 : US0 = US0_1
                        let v2127 : (unit -> string) = closure44(v2045, v2043, v2046, v2047, v2048)
                        let v2128 : (unit -> string) = method43()
                        method3(v2126, v2127, v2128)
                        let v2129 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v2130 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v2119, StandardOutputEncoding = v2129, WorkingDirectory = v2125, FileName = v2118, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v2131 : int32 = v2046.Length
                        let v2132 : Mut5 = {l0 = 0} : Mut5
                        while method21(v2131, v2132) do
                            let v2134 : int32 = v2132.l0
                            let struct (v2135 : string, v2136 : string) = v2046.[int v2134]
                            v2130.EnvironmentVariables.[v2135] <- v2136 
                            let v2137 : int32 = v2134 + 1
                            v2132.l0 <- v2137
                            ()
                        let v2138 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v2130)
                        use v2138 = v2138 
                        let v2139 : System.Diagnostics.Process = v2138 
                        let v2140 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v2141 : System.Collections.Concurrent.ConcurrentStack<string> = v2140 ()
                        let v2142 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v2045, v2043, v2046, v2047, v2048, v2139, v2141)
                        v2139.OutputDataReceived.Add v2142 
                        let v2143 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v2045, v2043, v2046, v2047, v2048, v2139, v2141)
                        v2139.ErrorDataReceived.Add v2143 
                        let v2144 : (unit -> bool) = v2139.Start
                        let v2145 : bool = v2144 ()
                        let v2146 : bool = v2145 = false
                        if v2146 then
                            let v2147 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v2147
                        let v2148 : (unit -> unit) = v2139.BeginErrorReadLine
                        v2148 ()
                        let v2149 : (unit -> unit) = v2139.BeginOutputReadLine
                        v2149 ()
                        let v2150 : (System.Threading.CancellationToken -> US16) = method61()
                        let v2151 : US16 = US16_1
                        let v2152 : US16 = v2045 |> Option.map v2150 |> Option.defaultValue v2151 
                        let v2156 : System.Threading.CancellationToken =
                            match v2152 with
                            | US16_1 -> (* None *)
                                let v2154 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v2154
                            | US16_0(v2153) -> (* Some *)
                                v2153
                        let v2157 : Async<System.Threading.CancellationToken> option = None
                        let v2158 : bool = true in let mutable _v2157 = v2157
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2159 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2159
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2160 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2160
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2161 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2161
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2162 : Async<System.Threading.CancellationToken> option = None
                        let v2163 : bool = true in let mutable _v2162 = v2162
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2164 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2164
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2165 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2165
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2166 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2166
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2167 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v2167 = v2167
                        async {
                        let v2168 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v2168 = v2168 
                        let v2169 : System.Threading.CancellationToken = v2168 
                        let v2170 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v2171 : (System.Threading.CancellationToken []) = [|v2169; v2170; v2156|]
                        let v2172 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v2173 : System.Threading.CancellationTokenSource = v2172 v2171
                        let v2174 : System.Threading.CancellationToken = v2173.Token
                        return v2174 
                        }
                        |> fun x -> _v2167 <- Some x
                        let v2175 : Async<System.Threading.CancellationToken> = _v2167 |> Option.get
                        v2175
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2176 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2176
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2177 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2177
#endif
                        |> fun x -> _v2162 <- Some x
                        let v2178 : Async<System.Threading.CancellationToken> = _v2162.Value
                        v2178
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2179 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2179
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2180 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2180
#endif
                        |> fun x -> _v2157 <- Some x
                        let v2181 : Async<System.Threading.CancellationToken> = _v2157.Value
                        let! v2181 = v2181 
                        let v2182 : System.Threading.CancellationToken = v2181 
                        let v2183 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v2182.Register
                        let v2184 : (unit -> unit) = closure50(v2139)
                        let v2185 : System.Threading.CancellationTokenRegistration = v2183 v2184
                        use v2185 = v2185 
                        let v2186 : System.Threading.CancellationTokenRegistration = v2185 
                        let v2187 : Async<int32> option = None
                        let v2188 : bool = true in let mutable _v2187 = v2187
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2189 : Async<int32> = null |> unbox<Async<int32>>
                        v2189
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2190 : Async<int32> = null |> unbox<Async<int32>>
                        v2190
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2191 : Async<int32> = null |> unbox<Async<int32>>
                        v2191
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2192 : Async<int32> option = None
                        let mutable _v2192 = v2192
                        async {
                        try
                        let v2193 : System.Threading.Tasks.Task = v2139.WaitForExitAsync v2182 
                        let v2194 : Async<unit> option = None
                        let v2195 : bool = true in let mutable _v2194 = v2194
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2196 : Async<unit> = null |> unbox<Async<unit>>
                        v2196
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2197 : Async<unit> = null |> unbox<Async<unit>>
                        v2197
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2198 : Async<unit> = null |> unbox<Async<unit>>
                        v2198
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2199 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v2200 : Async<unit> = v2199 v2193
                        v2200
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2201 : Async<unit> = null |> unbox<Async<unit>>
                        v2201
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2202 : Async<unit> = null |> unbox<Async<unit>>
                        v2202
#endif
                        |> fun x -> _v2194 <- Some x
                        let v2203 : Async<unit> = _v2194.Value
                        do! v2203 
                        let v2204 : int32 = v2139.ExitCode
                        return v2204 
                        with ex ->
                        let v2205 : exn = ex
                        let v2206 : string option = None
                        let v2207 : bool = true in let mutable _v2206 = v2206
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2208 : string = $"%A{v2205}"
                        v2208
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2209 : string = $"%A{v2205}"
                        v2209
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2210 : string = $"%A{v2205}"
                        v2210
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2211 : string = $"{v2205.GetType ()}: {v2205.Message}"
                        v2211
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2212 : string = $"%A{v2205}"
                        v2212
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2213 : string = $"%A{v2205}"
                        v2213
#endif
                        |> fun x -> _v2206 <- Some x
                        let v2214 : string = _v2206.Value
                        let v2215 : (string -> unit) = v2141.Push
                        v2215 v2214
                        let v2216 : System.Threading.Tasks.TaskCanceledException = v2205 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v2217 : US0 = US0_3
                        let v2218 : (unit -> string) = closure51(v2216)
                        let v2219 : (unit -> string) = method43()
                        method3(v2217, v2218, v2219)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v2192 <- Some x
                        let v2220 : Async<int32> = _v2192 |> Option.get
                        v2220
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2221 : Async<int32> = null |> unbox<Async<int32>>
                        v2221
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2222 : Async<int32> = null |> unbox<Async<int32>>
                        v2222
#endif
                        |> fun x -> _v2187 <- Some x
                        let v2223 : Async<int32> = _v2187.Value
                        let! v2223 = v2223 
                        let v2224 : int32 = v2223 
                        let v2225 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v2226 : string seq = v2225 v2141
                        let v2227 : string = method62()
                        let v2228 : (string -> (string seq -> string)) = String.concat
                        let v2229 : (string seq -> string) = v2228 v2227
                        let v2230 : string = v2229 v2226
                        let v2231 : US0 = US0_1
                        let v2232 : (unit -> string) = closure52(v2224, v2230)
                        let v2233 : (unit -> string) = method43()
                        method3(v2231, v2232, v2233)
                        return struct (v2224, v2230) 
                        }
                        |> fun x -> _v2099 <- Some x
                        let v2234 : Async<struct (int32 * string)> = _v2099 |> Option.get
                        v2234
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2235 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2235
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2236 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2236
#endif
                        |> fun x -> _v2094 <- Some x
                        let v2237 : Async<struct (int32 * string)> = _v2094.Value
                        v2237
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2238 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2238
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2239 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2239
#endif
                        |> fun x -> _v2089 <- Some x
                        let v2240 : Async<struct (int32 * string)> = _v2089.Value
                        let v2241 : struct (int32 * string) option = None
                        let v2242 : bool = true in let mutable _v2241 = v2241
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v2243 : int32, v2244 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2243, v2244)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v2245 : int32, v2246 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2245, v2246)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2247 : int32, v2248 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2247, v2248)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2249 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v2250 : int32, v2251 : string) = v2249 v2240
                        struct (v2250, v2251)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2252 : int32, v2253 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2252, v2253)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v2254 : int32, v2255 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2254, v2255)
#endif
                        |> fun x -> _v2241 <- Some x
                        let struct (v2256 : int32, v2257 : string) = _v2241.Value
                        struct (v2256, v2257)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2258 : int32, v2259 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2258, v2259)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v2260 : int32, v2261 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2260, v2261)
#endif
                        |> fun x -> _v2049 <- Some x
                        let struct (v2262 : int32, v2263 : string) = _v2049.Value
                        let v2264 : bool = v2262 <> 0
                        let v2267 : bool =
                            if v2264 then
                                true
                            else
                                let v2265 : string = "ERROR"
                                let v2266 : bool = v2263.Contains v2265
                                v2266
                        if v2267 then
                            let v2268 : US0 = US0_2
                            let v2269 : (unit -> string) = closure53()
                            let v2270 : (unit -> string) = closure54(v2263, v2262)
                            method3(v2268, v2269, v2270)
                            let v2271 : (string * string) = v1483, v2263
                            let v2272 : Result<string, (string * string)> = Error v2271
                            US17_0(v2272)
                        else
                            let v2274 : unit option = None
                            let v2275 : bool = true in let mutable _v2274 = v2274
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v2276 : string = method63(v1484)
                            let v2277 : string = "std::fs::copy(&*v1483, &*v2276)"
                            let v2278 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v2277
                            let v2279 : string = "$0.unwrap()"
                            let v2280 : uint64 = Fable.Core.RustInterop.emitRustExpr v2278 v2279
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
                            
#if !FABLE_COMPILER && !WASM && !CONTRACT
                            System.IO.File.Copy (v1483, v1484, true)
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
                            |> fun x -> _v2274 <- Some x
                            _v2274.Value
                            let v2281 : Result<string, (string * string)> = Ok v1483
                            US17_0(v2281)
                    else
                        US17_1
                let v2290 : Result<string, (string * string)> option =
                    match v2285 with
                    | US17_1 -> (* None *)
                        let v2288 : Result<string, (string * string)> option = None
                        v2288
                    | US17_0(v2286) -> (* Some *)
                        let v2287 : Result<string, (string * string)> option = Some v2286 
                        v2287
                let v2291 : string = "pdf"
                let v2292 : string = $"{v647}.{v2291}"
                let v2293 : string = $"{v1200}.{v2291}"
                let v2294 : bool option = None
                let v2295 : bool = true in let mutable _v2294 = v2294
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v2296 : string = method14(v2292)
                let v2297 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                let v2298 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2296 v2297
                let v2299 : string = "String::from($0)"
                let v2300 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2298 v2299
                let v2301 : string = "std::path::PathBuf::from($0)"
                let v2302 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v2300 v2301
                let v2303 : string = "$0.exists()"
                let v2304 : bool = Fable.Core.RustInterop.emitRustExpr v2302 v2303
                let v2307 : bool =
                    if v2304 then
                        let v2305 : string = "$0.is_file()"
                        let v2306 : bool = Fable.Core.RustInterop.emitRustExpr v2302 v2305
                        v2306
                    else
                        false
                v2307
#endif
                
#if FABLE_COMPILER_RUST && WASM
                let v2308 : bool = null |> unbox<bool>
                v2308
#endif
                
#if FABLE_COMPILER_RUST && CONTRACT
                let v2309 : bool = null |> unbox<bool>
                v2309
#endif
                
#if !FABLE_COMPILER && !WASM && !CONTRACT
                let v2310 : (string -> bool) = System.IO.File.Exists
                let v2311 : bool = v2310 v2292
                v2311
#endif
                
#if FABLE_COMPILER_TYPESCRIPT
                let v2312 : IFsExistsSync = Fable.Core.JsInterop.importAll v1219
                let v2313 : string = "v2312.existsSync($0)"
                let v2314 : bool = Fable.Core.JsInterop.emitJsExpr v2292 v2313
                v2314
#endif
                
#if FABLE_COMPILER_PYTHON
                let v2315 : bool = null |> unbox<bool>
                v2315
#endif
                |> fun x -> _v2294 <- Some x
                let v2316 : bool = _v2294.Value
                let v2340 : bool =
                    if v2316 then
                        let v2317 : bool option = None
                        let v2318 : bool = true in let mutable _v2317 = v2317
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2319 : string = method14(v2293)
                        let v2320 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                        let v2321 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2319 v2320
                        let v2322 : string = "String::from($0)"
                        let v2323 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2321 v2322
                        let v2324 : string = "std::path::PathBuf::from($0)"
                        let v2325 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v2323 v2324
                        let v2326 : string = "$0.exists()"
                        let v2327 : bool = Fable.Core.RustInterop.emitRustExpr v2325 v2326
                        let v2330 : bool =
                            if v2327 then
                                let v2328 : string = "$0.is_file()"
                                let v2329 : bool = Fable.Core.RustInterop.emitRustExpr v2325 v2328
                                v2329
                            else
                                false
                        v2330
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2331 : bool = null |> unbox<bool>
                        v2331
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2332 : bool = null |> unbox<bool>
                        v2332
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2333 : (string -> bool) = System.IO.File.Exists
                        let v2334 : bool = v2333 v2293
                        v2334
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2335 : IFsExistsSync = Fable.Core.JsInterop.importAll v1219
                        let v2336 : string = "v2335.existsSync($0)"
                        let v2337 : bool = Fable.Core.JsInterop.emitJsExpr v2293 v2336
                        v2337
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2338 : bool = null |> unbox<bool>
                        v2338
#endif
                        |> fun x -> _v2317 <- Some x
                        let v2339 : bool = _v2317.Value
                        v2339
                    else
                        false
                let v2850 : bool =
                    if v2340 then
                        let v2341 : bool option = None
                        let v2342 : bool = true in let mutable _v2341 = v2341
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2343 : string = "cfg!(windows)"
                        let v2344 : bool = Fable.Core.RustInterop.emitRustExpr () v2343
                        v2344
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2345 : bool = null |> unbox<bool>
                        v2345
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2346 : bool = null |> unbox<bool>
                        v2346
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2347 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                        let v2348 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                        let v2349 : bool = v2348 v2347
                        v2349
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2350 : bool = null |> unbox<bool>
                        v2350
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2351 : bool = null |> unbox<bool>
                        v2351
#endif
                        |> fun x -> _v2341 <- Some x
                        let v2352 : bool = _v2341.Value
                        let v2353 : bool = v2352 = false
                        let v2374 : string =
                            if v2353 then
                                v2292
                            else
                                let v2354 : string option = None
                                let v2355 : bool = true in let mutable _v2354 = v2354
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v2356 : string = method17()
                                let v2357 : string = method18(v2292)
                                let v2358 : string = method19()
                                let v2359 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                                let v2360 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v2356, v2357, v2358) v2359
                                let v2361 : string = "String::from($0)"
                                let v2362 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2360 v2361
                                let v2363 : string = "fable_library_rust::String_::fromString($0)"
                                let v2364 : string = Fable.Core.RustInterop.emitRustExpr v2362 v2363
                                v2364
#endif
                                
#if FABLE_COMPILER_RUST && WASM
                                let v2365 : string = null |> unbox<string>
                                v2365
#endif
                                
#if FABLE_COMPILER_RUST && CONTRACT
                                let v2366 : string = null |> unbox<string>
                                v2366
#endif
                                
#if !FABLE_COMPILER && !WASM && !CONTRACT
                                let v2367 : string = "^\\\\\\\\\\?\\\\"
                                let v2368 : string = System.Text.RegularExpressions.Regex.Replace (v2292, v2367, v233)
                                v2368
#endif
                                
#if FABLE_COMPILER_TYPESCRIPT
                                let v2369 : string = null |> unbox<string>
                                v2369
#endif
                                
#if FABLE_COMPILER_PYTHON
                                let v2370 : string = null |> unbox<string>
                                v2370
#endif
                                |> fun x -> _v2354 <- Some x
                                let v2371 : string = _v2354.Value
                                let v2372 : string = $"{v2371.[0] |> string |> _.ToLower()}{v2371.[1..]}"
                                let v2373 : string = v2372.Replace (v235, v236)
                                v2373
                        let v2375 : string option = None
                        let v2376 : System.Threading.CancellationToken option = None
                        let v2377 : (struct (string * string) []) = [||]
                        let v2378 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v2379 : string = $"pwsh -c \"(Get-FileHash \\\"{v2374}\\\" -Algorithm SHA256).Hash\""
                        let v2380 : struct (int32 * string) option = None
                        let v2381 : bool = true in let mutable _v2380 = v2380
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2382 : string = method33(v2376, v2379, v2377, v2378, v2375)
                        let struct (v2383 : string, v2384 : string) = method34()
                        let v2385 : int32 = v2382.Length
                        let v2386 : (char []) = Array.zeroCreate<char> (v2385)
                        let v2387 : Mut5 = {l0 = 0} : Mut5
                        while method21(v2385, v2387) do
                            let v2389 : int32 = v2387.l0
                            let v2390 : char = v2382.[int v2389]
                            v2386.[int v2389] <- v2390
                            let v2391 : int32 = v2389 + 1
                            v2387.l0 <- v2391
                            ()
                        let v2392 : ((char []) -> char list) = Array.toList
                        let v2393 : char list = v2392 v2386
                        let v2394 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2395 : (char -> (UH0 -> UH0)) = method35()
                        let v2396 : (char list -> (UH0 -> UH0)) = v2394 v2395
                        let v2397 : (UH0 -> UH0) = v2396 v2393
                        let v2398 : UH0 = UH0_0
                        let v2399 : UH0 = v2397 v2398
                        let v2400 : US8 = US8_0
                        let struct (v2401 : string, v2402 : string) = method36(v2384, v2383, v2399, v2400)
                        let v2403 : (string []) = method37(v2402)
                        let v2404 : string = "$0.to_vec()"
                        let v2405 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v2403 v2404
                        let v2406 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v2407 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2405, v383) v2406
                        let v2408 : US0 = US0_1
                        let v2409 : (unit -> string) = closure28(v2376, v2379, v2377, v2378, v2375, v2401, v2407)
                        let v2410 : (unit -> string) = method43()
                        method3(v2408, v2409, v2410)
                        let v2411 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method44(v2376, v2379, v2377, v2378, v2375, v2401, v2407)
                        let v2412 : string = "futures_lite::future::block_on($0)"
                        let v2413 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v2411 v2412
                        let (a, b) = v2413
                        let v2414 : int32 = a
                        let v2415 : string = b
                        struct (v2414, v2415)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v2416 : int32, v2417 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2416, v2417)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2418 : int32, v2419 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2418, v2419)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2420 : Async<struct (int32 * string)> option = None
                        let v2421 : bool = true in let mutable _v2420 = v2420
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2422 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2422
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2423 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2423
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2424 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2424
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2425 : Async<struct (int32 * string)> option = None
                        let v2426 : bool = true in let mutable _v2425 = v2425
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2427 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2427
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2428 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2428
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2429 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2429
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2430 : Async<struct (int32 * string)> option = None
                        let mutable _v2430 = v2430
                        async {
                        let struct (v2431 : string, v2432 : string) = method34()
                        let v2433 : int32 = v2379.Length
                        let v2434 : (char []) = Array.zeroCreate<char> (v2433)
                        let v2435 : Mut5 = {l0 = 0} : Mut5
                        while method21(v2433, v2435) do
                            let v2437 : int32 = v2435.l0
                            let v2438 : char = v2379.[int v2437]
                            v2434.[int v2437] <- v2438
                            let v2439 : int32 = v2437 + 1
                            v2435.l0 <- v2439
                            ()
                        let v2440 : ((char []) -> char list) = Array.toList
                        let v2441 : char list = v2440 v2434
                        let v2442 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2443 : (char -> (UH0 -> UH0)) = method35()
                        let v2444 : (char list -> (UH0 -> UH0)) = v2442 v2443
                        let v2445 : (UH0 -> UH0) = v2444 v2441
                        let v2446 : UH0 = UH0_0
                        let v2447 : UH0 = v2445 v2446
                        let v2448 : US8 = US8_0
                        let struct (v2449 : string, v2450 : string) = method36(v2432, v2431, v2447, v2448)
                        let v2451 : (string -> US7) = method38()
                        let v2452 : US7 = US7_1
                        let v2453 : US7 = v2375 |> Option.map v2451 |> Option.defaultValue v2452 
                        let v2456 : string =
                            match v2453 with
                            | US7_1 -> (* None *)
                                v233
                            | US7_0(v2454) -> (* Some *)
                                v2454
                        let v2457 : US0 = US0_1
                        let v2458 : (unit -> string) = closure44(v2376, v2379, v2377, v2378, v2375)
                        let v2459 : (unit -> string) = method43()
                        method3(v2457, v2458, v2459)
                        let v2460 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v2461 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v2450, StandardOutputEncoding = v2460, WorkingDirectory = v2456, FileName = v2449, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v2462 : int32 = v2377.Length
                        let v2463 : Mut5 = {l0 = 0} : Mut5
                        while method21(v2462, v2463) do
                            let v2465 : int32 = v2463.l0
                            let struct (v2466 : string, v2467 : string) = v2377.[int v2465]
                            v2461.EnvironmentVariables.[v2466] <- v2467 
                            let v2468 : int32 = v2465 + 1
                            v2463.l0 <- v2468
                            ()
                        let v2469 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v2461)
                        use v2469 = v2469 
                        let v2470 : System.Diagnostics.Process = v2469 
                        let v2471 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v2472 : System.Collections.Concurrent.ConcurrentStack<string> = v2471 ()
                        let v2473 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v2376, v2379, v2377, v2378, v2375, v2470, v2472)
                        v2470.OutputDataReceived.Add v2473 
                        let v2474 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v2376, v2379, v2377, v2378, v2375, v2470, v2472)
                        v2470.ErrorDataReceived.Add v2474 
                        let v2475 : (unit -> bool) = v2470.Start
                        let v2476 : bool = v2475 ()
                        let v2477 : bool = v2476 = false
                        if v2477 then
                            let v2478 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v2478
                        let v2479 : (unit -> unit) = v2470.BeginErrorReadLine
                        v2479 ()
                        let v2480 : (unit -> unit) = v2470.BeginOutputReadLine
                        v2480 ()
                        let v2481 : (System.Threading.CancellationToken -> US16) = method61()
                        let v2482 : US16 = US16_1
                        let v2483 : US16 = v2376 |> Option.map v2481 |> Option.defaultValue v2482 
                        let v2487 : System.Threading.CancellationToken =
                            match v2483 with
                            | US16_1 -> (* None *)
                                let v2485 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v2485
                            | US16_0(v2484) -> (* Some *)
                                v2484
                        let v2488 : Async<System.Threading.CancellationToken> option = None
                        let v2489 : bool = true in let mutable _v2488 = v2488
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2490 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2490
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2491 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2491
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2492 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2492
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2493 : Async<System.Threading.CancellationToken> option = None
                        let v2494 : bool = true in let mutable _v2493 = v2493
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2495 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2495
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2496 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2496
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2497 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2497
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2498 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v2498 = v2498
                        async {
                        let v2499 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v2499 = v2499 
                        let v2500 : System.Threading.CancellationToken = v2499 
                        let v2501 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v2502 : (System.Threading.CancellationToken []) = [|v2500; v2501; v2487|]
                        let v2503 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v2504 : System.Threading.CancellationTokenSource = v2503 v2502
                        let v2505 : System.Threading.CancellationToken = v2504.Token
                        return v2505 
                        }
                        |> fun x -> _v2498 <- Some x
                        let v2506 : Async<System.Threading.CancellationToken> = _v2498 |> Option.get
                        v2506
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2507 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2507
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2508 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2508
#endif
                        |> fun x -> _v2493 <- Some x
                        let v2509 : Async<System.Threading.CancellationToken> = _v2493.Value
                        v2509
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2510 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2510
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2511 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2511
#endif
                        |> fun x -> _v2488 <- Some x
                        let v2512 : Async<System.Threading.CancellationToken> = _v2488.Value
                        let! v2512 = v2512 
                        let v2513 : System.Threading.CancellationToken = v2512 
                        let v2514 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v2513.Register
                        let v2515 : (unit -> unit) = closure50(v2470)
                        let v2516 : System.Threading.CancellationTokenRegistration = v2514 v2515
                        use v2516 = v2516 
                        let v2517 : System.Threading.CancellationTokenRegistration = v2516 
                        let v2518 : Async<int32> option = None
                        let v2519 : bool = true in let mutable _v2518 = v2518
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2520 : Async<int32> = null |> unbox<Async<int32>>
                        v2520
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2521 : Async<int32> = null |> unbox<Async<int32>>
                        v2521
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2522 : Async<int32> = null |> unbox<Async<int32>>
                        v2522
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2523 : Async<int32> option = None
                        let mutable _v2523 = v2523
                        async {
                        try
                        let v2524 : System.Threading.Tasks.Task = v2470.WaitForExitAsync v2513 
                        let v2525 : Async<unit> option = None
                        let v2526 : bool = true in let mutable _v2525 = v2525
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2527 : Async<unit> = null |> unbox<Async<unit>>
                        v2527
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2528 : Async<unit> = null |> unbox<Async<unit>>
                        v2528
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2529 : Async<unit> = null |> unbox<Async<unit>>
                        v2529
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2530 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v2531 : Async<unit> = v2530 v2524
                        v2531
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2532 : Async<unit> = null |> unbox<Async<unit>>
                        v2532
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2533 : Async<unit> = null |> unbox<Async<unit>>
                        v2533
#endif
                        |> fun x -> _v2525 <- Some x
                        let v2534 : Async<unit> = _v2525.Value
                        do! v2534 
                        let v2535 : int32 = v2470.ExitCode
                        return v2535 
                        with ex ->
                        let v2536 : exn = ex
                        let v2537 : string option = None
                        let v2538 : bool = true in let mutable _v2537 = v2537
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2539 : string = $"%A{v2536}"
                        v2539
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2540 : string = $"%A{v2536}"
                        v2540
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2541 : string = $"%A{v2536}"
                        v2541
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2542 : string = $"{v2536.GetType ()}: {v2536.Message}"
                        v2542
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2543 : string = $"%A{v2536}"
                        v2543
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2544 : string = $"%A{v2536}"
                        v2544
#endif
                        |> fun x -> _v2537 <- Some x
                        let v2545 : string = _v2537.Value
                        let v2546 : (string -> unit) = v2472.Push
                        v2546 v2545
                        let v2547 : System.Threading.Tasks.TaskCanceledException = v2536 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v2548 : US0 = US0_3
                        let v2549 : (unit -> string) = closure51(v2547)
                        let v2550 : (unit -> string) = method43()
                        method3(v2548, v2549, v2550)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v2523 <- Some x
                        let v2551 : Async<int32> = _v2523 |> Option.get
                        v2551
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2552 : Async<int32> = null |> unbox<Async<int32>>
                        v2552
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2553 : Async<int32> = null |> unbox<Async<int32>>
                        v2553
#endif
                        |> fun x -> _v2518 <- Some x
                        let v2554 : Async<int32> = _v2518.Value
                        let! v2554 = v2554 
                        let v2555 : int32 = v2554 
                        let v2556 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v2557 : string seq = v2556 v2472
                        let v2558 : string = method62()
                        let v2559 : (string -> (string seq -> string)) = String.concat
                        let v2560 : (string seq -> string) = v2559 v2558
                        let v2561 : string = v2560 v2557
                        let v2562 : US0 = US0_1
                        let v2563 : (unit -> string) = closure52(v2555, v2561)
                        let v2564 : (unit -> string) = method43()
                        method3(v2562, v2563, v2564)
                        return struct (v2555, v2561) 
                        }
                        |> fun x -> _v2430 <- Some x
                        let v2565 : Async<struct (int32 * string)> = _v2430 |> Option.get
                        v2565
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2566 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2566
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2567 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2567
#endif
                        |> fun x -> _v2425 <- Some x
                        let v2568 : Async<struct (int32 * string)> = _v2425.Value
                        v2568
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2569 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2569
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2570 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2570
#endif
                        |> fun x -> _v2420 <- Some x
                        let v2571 : Async<struct (int32 * string)> = _v2420.Value
                        let v2572 : struct (int32 * string) option = None
                        let v2573 : bool = true in let mutable _v2572 = v2572
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v2574 : int32, v2575 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2574, v2575)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v2576 : int32, v2577 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2576, v2577)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2578 : int32, v2579 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2578, v2579)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2580 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v2581 : int32, v2582 : string) = v2580 v2571
                        struct (v2581, v2582)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2583 : int32, v2584 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2583, v2584)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v2585 : int32, v2586 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2585, v2586)
#endif
                        |> fun x -> _v2572 <- Some x
                        let struct (v2587 : int32, v2588 : string) = _v2572.Value
                        struct (v2587, v2588)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2589 : int32, v2590 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2589, v2590)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v2591 : int32, v2592 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2591, v2592)
#endif
                        |> fun x -> _v2380 <- Some x
                        let struct (v2593 : int32, v2594 : string) = _v2380.Value
                        let v2595 : bool option = None
                        let v2596 : bool = true in let mutable _v2595 = v2595
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2597 : string = "cfg!(windows)"
                        let v2598 : bool = Fable.Core.RustInterop.emitRustExpr () v2597
                        v2598
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2599 : bool = null |> unbox<bool>
                        v2599
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2600 : bool = null |> unbox<bool>
                        v2600
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2601 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                        let v2602 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                        let v2603 : bool = v2602 v2601
                        v2603
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2604 : bool = null |> unbox<bool>
                        v2604
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2605 : bool = null |> unbox<bool>
                        v2605
#endif
                        |> fun x -> _v2595 <- Some x
                        let v2606 : bool = _v2595.Value
                        let v2607 : bool = v2606 = false
                        let v2628 : string =
                            if v2607 then
                                v2293
                            else
                                let v2608 : string option = None
                                let v2609 : bool = true in let mutable _v2608 = v2608
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v2610 : string = method17()
                                let v2611 : string = method18(v2293)
                                let v2612 : string = method19()
                                let v2613 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                                let v2614 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v2610, v2611, v2612) v2613
                                let v2615 : string = "String::from($0)"
                                let v2616 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2614 v2615
                                let v2617 : string = "fable_library_rust::String_::fromString($0)"
                                let v2618 : string = Fable.Core.RustInterop.emitRustExpr v2616 v2617
                                v2618
#endif
                                
#if FABLE_COMPILER_RUST && WASM
                                let v2619 : string = null |> unbox<string>
                                v2619
#endif
                                
#if FABLE_COMPILER_RUST && CONTRACT
                                let v2620 : string = null |> unbox<string>
                                v2620
#endif
                                
#if !FABLE_COMPILER && !WASM && !CONTRACT
                                let v2621 : string = "^\\\\\\\\\\?\\\\"
                                let v2622 : string = System.Text.RegularExpressions.Regex.Replace (v2293, v2621, v233)
                                v2622
#endif
                                
#if FABLE_COMPILER_TYPESCRIPT
                                let v2623 : string = null |> unbox<string>
                                v2623
#endif
                                
#if FABLE_COMPILER_PYTHON
                                let v2624 : string = null |> unbox<string>
                                v2624
#endif
                                |> fun x -> _v2608 <- Some x
                                let v2625 : string = _v2608.Value
                                let v2626 : string = $"{v2625.[0] |> string |> _.ToLower()}{v2625.[1..]}"
                                let v2627 : string = v2626.Replace (v235, v236)
                                v2627
                        let v2629 : string option = None
                        let v2630 : System.Threading.CancellationToken option = None
                        let v2631 : (struct (string * string) []) = [||]
                        let v2632 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v2633 : string = $"pwsh -c \"(Get-FileHash \\\"{v2628}\\\" -Algorithm SHA256).Hash\""
                        let v2634 : struct (int32 * string) option = None
                        let v2635 : bool = true in let mutable _v2634 = v2634
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2636 : string = method33(v2630, v2633, v2631, v2632, v2629)
                        let struct (v2637 : string, v2638 : string) = method34()
                        let v2639 : int32 = v2636.Length
                        let v2640 : (char []) = Array.zeroCreate<char> (v2639)
                        let v2641 : Mut5 = {l0 = 0} : Mut5
                        while method21(v2639, v2641) do
                            let v2643 : int32 = v2641.l0
                            let v2644 : char = v2636.[int v2643]
                            v2640.[int v2643] <- v2644
                            let v2645 : int32 = v2643 + 1
                            v2641.l0 <- v2645
                            ()
                        let v2646 : ((char []) -> char list) = Array.toList
                        let v2647 : char list = v2646 v2640
                        let v2648 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2649 : (char -> (UH0 -> UH0)) = method35()
                        let v2650 : (char list -> (UH0 -> UH0)) = v2648 v2649
                        let v2651 : (UH0 -> UH0) = v2650 v2647
                        let v2652 : UH0 = UH0_0
                        let v2653 : UH0 = v2651 v2652
                        let v2654 : US8 = US8_0
                        let struct (v2655 : string, v2656 : string) = method36(v2638, v2637, v2653, v2654)
                        let v2657 : (string []) = method37(v2656)
                        let v2658 : string = "$0.to_vec()"
                        let v2659 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v2657 v2658
                        let v2660 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v2661 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2659, v383) v2660
                        let v2662 : US0 = US0_1
                        let v2663 : (unit -> string) = closure28(v2630, v2633, v2631, v2632, v2629, v2655, v2661)
                        let v2664 : (unit -> string) = method43()
                        method3(v2662, v2663, v2664)
                        let v2665 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method44(v2630, v2633, v2631, v2632, v2629, v2655, v2661)
                        let v2666 : string = "futures_lite::future::block_on($0)"
                        let v2667 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v2665 v2666
                        let (a, b) = v2667
                        let v2668 : int32 = a
                        let v2669 : string = b
                        struct (v2668, v2669)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v2670 : int32, v2671 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2670, v2671)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2672 : int32, v2673 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2672, v2673)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2674 : Async<struct (int32 * string)> option = None
                        let v2675 : bool = true in let mutable _v2674 = v2674
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2676 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2676
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2677 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2677
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2678 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2678
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2679 : Async<struct (int32 * string)> option = None
                        let v2680 : bool = true in let mutable _v2679 = v2679
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2681 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2681
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2682 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2682
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2683 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2683
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2684 : Async<struct (int32 * string)> option = None
                        let mutable _v2684 = v2684
                        async {
                        let struct (v2685 : string, v2686 : string) = method34()
                        let v2687 : int32 = v2633.Length
                        let v2688 : (char []) = Array.zeroCreate<char> (v2687)
                        let v2689 : Mut5 = {l0 = 0} : Mut5
                        while method21(v2687, v2689) do
                            let v2691 : int32 = v2689.l0
                            let v2692 : char = v2633.[int v2691]
                            v2688.[int v2691] <- v2692
                            let v2693 : int32 = v2691 + 1
                            v2689.l0 <- v2693
                            ()
                        let v2694 : ((char []) -> char list) = Array.toList
                        let v2695 : char list = v2694 v2688
                        let v2696 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2697 : (char -> (UH0 -> UH0)) = method35()
                        let v2698 : (char list -> (UH0 -> UH0)) = v2696 v2697
                        let v2699 : (UH0 -> UH0) = v2698 v2695
                        let v2700 : UH0 = UH0_0
                        let v2701 : UH0 = v2699 v2700
                        let v2702 : US8 = US8_0
                        let struct (v2703 : string, v2704 : string) = method36(v2686, v2685, v2701, v2702)
                        let v2705 : (string -> US7) = method38()
                        let v2706 : US7 = US7_1
                        let v2707 : US7 = v2629 |> Option.map v2705 |> Option.defaultValue v2706 
                        let v2710 : string =
                            match v2707 with
                            | US7_1 -> (* None *)
                                v233
                            | US7_0(v2708) -> (* Some *)
                                v2708
                        let v2711 : US0 = US0_1
                        let v2712 : (unit -> string) = closure44(v2630, v2633, v2631, v2632, v2629)
                        let v2713 : (unit -> string) = method43()
                        method3(v2711, v2712, v2713)
                        let v2714 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v2715 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v2704, StandardOutputEncoding = v2714, WorkingDirectory = v2710, FileName = v2703, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v2716 : int32 = v2631.Length
                        let v2717 : Mut5 = {l0 = 0} : Mut5
                        while method21(v2716, v2717) do
                            let v2719 : int32 = v2717.l0
                            let struct (v2720 : string, v2721 : string) = v2631.[int v2719]
                            v2715.EnvironmentVariables.[v2720] <- v2721 
                            let v2722 : int32 = v2719 + 1
                            v2717.l0 <- v2722
                            ()
                        let v2723 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v2715)
                        use v2723 = v2723 
                        let v2724 : System.Diagnostics.Process = v2723 
                        let v2725 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v2726 : System.Collections.Concurrent.ConcurrentStack<string> = v2725 ()
                        let v2727 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v2630, v2633, v2631, v2632, v2629, v2724, v2726)
                        v2724.OutputDataReceived.Add v2727 
                        let v2728 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v2630, v2633, v2631, v2632, v2629, v2724, v2726)
                        v2724.ErrorDataReceived.Add v2728 
                        let v2729 : (unit -> bool) = v2724.Start
                        let v2730 : bool = v2729 ()
                        let v2731 : bool = v2730 = false
                        if v2731 then
                            let v2732 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v2732
                        let v2733 : (unit -> unit) = v2724.BeginErrorReadLine
                        v2733 ()
                        let v2734 : (unit -> unit) = v2724.BeginOutputReadLine
                        v2734 ()
                        let v2735 : (System.Threading.CancellationToken -> US16) = method61()
                        let v2736 : US16 = US16_1
                        let v2737 : US16 = v2630 |> Option.map v2735 |> Option.defaultValue v2736 
                        let v2741 : System.Threading.CancellationToken =
                            match v2737 with
                            | US16_1 -> (* None *)
                                let v2739 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v2739
                            | US16_0(v2738) -> (* Some *)
                                v2738
                        let v2742 : Async<System.Threading.CancellationToken> option = None
                        let v2743 : bool = true in let mutable _v2742 = v2742
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2744 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2744
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2745 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2745
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2746 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2746
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2747 : Async<System.Threading.CancellationToken> option = None
                        let v2748 : bool = true in let mutable _v2747 = v2747
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2749 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2749
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2750 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2750
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2751 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2751
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2752 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v2752 = v2752
                        async {
                        let v2753 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v2753 = v2753 
                        let v2754 : System.Threading.CancellationToken = v2753 
                        let v2755 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v2756 : (System.Threading.CancellationToken []) = [|v2754; v2755; v2741|]
                        let v2757 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v2758 : System.Threading.CancellationTokenSource = v2757 v2756
                        let v2759 : System.Threading.CancellationToken = v2758.Token
                        return v2759 
                        }
                        |> fun x -> _v2752 <- Some x
                        let v2760 : Async<System.Threading.CancellationToken> = _v2752 |> Option.get
                        v2760
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2761 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2761
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2762 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2762
#endif
                        |> fun x -> _v2747 <- Some x
                        let v2763 : Async<System.Threading.CancellationToken> = _v2747.Value
                        v2763
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2764 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2764
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2765 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2765
#endif
                        |> fun x -> _v2742 <- Some x
                        let v2766 : Async<System.Threading.CancellationToken> = _v2742.Value
                        let! v2766 = v2766 
                        let v2767 : System.Threading.CancellationToken = v2766 
                        let v2768 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v2767.Register
                        let v2769 : (unit -> unit) = closure50(v2724)
                        let v2770 : System.Threading.CancellationTokenRegistration = v2768 v2769
                        use v2770 = v2770 
                        let v2771 : System.Threading.CancellationTokenRegistration = v2770 
                        let v2772 : Async<int32> option = None
                        let v2773 : bool = true in let mutable _v2772 = v2772
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2774 : Async<int32> = null |> unbox<Async<int32>>
                        v2774
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2775 : Async<int32> = null |> unbox<Async<int32>>
                        v2775
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2776 : Async<int32> = null |> unbox<Async<int32>>
                        v2776
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2777 : Async<int32> option = None
                        let mutable _v2777 = v2777
                        async {
                        try
                        let v2778 : System.Threading.Tasks.Task = v2724.WaitForExitAsync v2767 
                        let v2779 : Async<unit> option = None
                        let v2780 : bool = true in let mutable _v2779 = v2779
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2781 : Async<unit> = null |> unbox<Async<unit>>
                        v2781
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2782 : Async<unit> = null |> unbox<Async<unit>>
                        v2782
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2783 : Async<unit> = null |> unbox<Async<unit>>
                        v2783
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2784 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v2785 : Async<unit> = v2784 v2778
                        v2785
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2786 : Async<unit> = null |> unbox<Async<unit>>
                        v2786
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2787 : Async<unit> = null |> unbox<Async<unit>>
                        v2787
#endif
                        |> fun x -> _v2779 <- Some x
                        let v2788 : Async<unit> = _v2779.Value
                        do! v2788 
                        let v2789 : int32 = v2724.ExitCode
                        return v2789 
                        with ex ->
                        let v2790 : exn = ex
                        let v2791 : string option = None
                        let v2792 : bool = true in let mutable _v2791 = v2791
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2793 : string = $"%A{v2790}"
                        v2793
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2794 : string = $"%A{v2790}"
                        v2794
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2795 : string = $"%A{v2790}"
                        v2795
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2796 : string = $"{v2790.GetType ()}: {v2790.Message}"
                        v2796
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2797 : string = $"%A{v2790}"
                        v2797
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2798 : string = $"%A{v2790}"
                        v2798
#endif
                        |> fun x -> _v2791 <- Some x
                        let v2799 : string = _v2791.Value
                        let v2800 : (string -> unit) = v2726.Push
                        v2800 v2799
                        let v2801 : System.Threading.Tasks.TaskCanceledException = v2790 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v2802 : US0 = US0_3
                        let v2803 : (unit -> string) = closure51(v2801)
                        let v2804 : (unit -> string) = method43()
                        method3(v2802, v2803, v2804)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v2777 <- Some x
                        let v2805 : Async<int32> = _v2777 |> Option.get
                        v2805
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2806 : Async<int32> = null |> unbox<Async<int32>>
                        v2806
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2807 : Async<int32> = null |> unbox<Async<int32>>
                        v2807
#endif
                        |> fun x -> _v2772 <- Some x
                        let v2808 : Async<int32> = _v2772.Value
                        let! v2808 = v2808 
                        let v2809 : int32 = v2808 
                        let v2810 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v2811 : string seq = v2810 v2726
                        let v2812 : string = method62()
                        let v2813 : (string -> (string seq -> string)) = String.concat
                        let v2814 : (string seq -> string) = v2813 v2812
                        let v2815 : string = v2814 v2811
                        let v2816 : US0 = US0_1
                        let v2817 : (unit -> string) = closure52(v2809, v2815)
                        let v2818 : (unit -> string) = method43()
                        method3(v2816, v2817, v2818)
                        return struct (v2809, v2815) 
                        }
                        |> fun x -> _v2684 <- Some x
                        let v2819 : Async<struct (int32 * string)> = _v2684 |> Option.get
                        v2819
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2820 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2820
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2821 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2821
#endif
                        |> fun x -> _v2679 <- Some x
                        let v2822 : Async<struct (int32 * string)> = _v2679.Value
                        v2822
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2823 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2823
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2824 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2824
#endif
                        |> fun x -> _v2674 <- Some x
                        let v2825 : Async<struct (int32 * string)> = _v2674.Value
                        let v2826 : struct (int32 * string) option = None
                        let v2827 : bool = true in let mutable _v2826 = v2826
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v2828 : int32, v2829 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2828, v2829)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v2830 : int32, v2831 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2830, v2831)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2832 : int32, v2833 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2832, v2833)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2834 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v2835 : int32, v2836 : string) = v2834 v2825
                        struct (v2835, v2836)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2837 : int32, v2838 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2837, v2838)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v2839 : int32, v2840 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2839, v2840)
#endif
                        |> fun x -> _v2826 <- Some x
                        let struct (v2841 : int32, v2842 : string) = _v2826.Value
                        struct (v2841, v2842)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2843 : int32, v2844 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2843, v2844)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v2845 : int32, v2846 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2845, v2846)
#endif
                        |> fun x -> _v2634 <- Some x
                        let struct (v2847 : int32, v2848 : string) = _v2634.Value
                        let v2849 : bool = v2594 = v2848
                        v2849
                    else
                        false
                let v2851 : bool = v2850 = false
                let v3094 : US17 =
                    if v2851 then
                        let v2852 : string = $"crowbook --single \"{v647}\" --output \"{v2292}\" --to {v2291} --set rendering.num_depth 6 html.css.add \\\"''' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} '''\\\""
                        let v2853 : string option = None
                        let v2854 : System.Threading.CancellationToken option = None
                        let v2855 : (struct (string * string) []) = [||]
                        let v2856 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v2857 : string option = Some v1 
                        let v2858 : struct (int32 * string) option = None
                        let v2859 : bool = true in let mutable _v2858 = v2858
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2860 : string = method33(v2854, v2852, v2855, v2856, v2857)
                        let struct (v2861 : string, v2862 : string) = method34()
                        let v2863 : int32 = v2860.Length
                        let v2864 : (char []) = Array.zeroCreate<char> (v2863)
                        let v2865 : Mut5 = {l0 = 0} : Mut5
                        while method21(v2863, v2865) do
                            let v2867 : int32 = v2865.l0
                            let v2868 : char = v2860.[int v2867]
                            v2864.[int v2867] <- v2868
                            let v2869 : int32 = v2867 + 1
                            v2865.l0 <- v2869
                            ()
                        let v2870 : ((char []) -> char list) = Array.toList
                        let v2871 : char list = v2870 v2864
                        let v2872 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2873 : (char -> (UH0 -> UH0)) = method35()
                        let v2874 : (char list -> (UH0 -> UH0)) = v2872 v2873
                        let v2875 : (UH0 -> UH0) = v2874 v2871
                        let v2876 : UH0 = UH0_0
                        let v2877 : UH0 = v2875 v2876
                        let v2878 : US8 = US8_0
                        let struct (v2879 : string, v2880 : string) = method36(v2862, v2861, v2877, v2878)
                        let v2881 : (string []) = method37(v2880)
                        let v2882 : string = "$0.to_vec()"
                        let v2883 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v2881 v2882
                        let v2884 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v2885 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2883, v383) v2884
                        let v2886 : US0 = US0_1
                        let v2887 : (unit -> string) = closure28(v2854, v2852, v2855, v2856, v2857, v2879, v2885)
                        let v2888 : (unit -> string) = method43()
                        method3(v2886, v2887, v2888)
                        let v2889 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method44(v2854, v2852, v2855, v2856, v2857, v2879, v2885)
                        let v2890 : string = "futures_lite::future::block_on($0)"
                        let v2891 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v2889 v2890
                        let (a, b) = v2891
                        let v2892 : int32 = a
                        let v2893 : string = b
                        struct (v2892, v2893)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v2894 : int32, v2895 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2894, v2895)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2896 : int32, v2897 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2896, v2897)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2898 : Async<struct (int32 * string)> option = None
                        let v2899 : bool = true in let mutable _v2898 = v2898
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2900 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2900
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2901 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2901
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2902 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2902
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2903 : Async<struct (int32 * string)> option = None
                        let v2904 : bool = true in let mutable _v2903 = v2903
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2905 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2905
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2906 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2906
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2907 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2907
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2908 : Async<struct (int32 * string)> option = None
                        let mutable _v2908 = v2908
                        async {
                        let struct (v2909 : string, v2910 : string) = method34()
                        let v2911 : int32 = v2852.Length
                        let v2912 : (char []) = Array.zeroCreate<char> (v2911)
                        let v2913 : Mut5 = {l0 = 0} : Mut5
                        while method21(v2911, v2913) do
                            let v2915 : int32 = v2913.l0
                            let v2916 : char = v2852.[int v2915]
                            v2912.[int v2915] <- v2916
                            let v2917 : int32 = v2915 + 1
                            v2913.l0 <- v2917
                            ()
                        let v2918 : ((char []) -> char list) = Array.toList
                        let v2919 : char list = v2918 v2912
                        let v2920 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2921 : (char -> (UH0 -> UH0)) = method35()
                        let v2922 : (char list -> (UH0 -> UH0)) = v2920 v2921
                        let v2923 : (UH0 -> UH0) = v2922 v2919
                        let v2924 : UH0 = UH0_0
                        let v2925 : UH0 = v2923 v2924
                        let v2926 : US8 = US8_0
                        let struct (v2927 : string, v2928 : string) = method36(v2910, v2909, v2925, v2926)
                        let v2929 : (string -> US7) = method38()
                        let v2930 : US7 = US7_1
                        let v2931 : US7 = v2857 |> Option.map v2929 |> Option.defaultValue v2930 
                        let v2934 : string =
                            match v2931 with
                            | US7_1 -> (* None *)
                                v233
                            | US7_0(v2932) -> (* Some *)
                                v2932
                        let v2935 : US0 = US0_1
                        let v2936 : (unit -> string) = closure44(v2854, v2852, v2855, v2856, v2857)
                        let v2937 : (unit -> string) = method43()
                        method3(v2935, v2936, v2937)
                        let v2938 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v2939 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v2928, StandardOutputEncoding = v2938, WorkingDirectory = v2934, FileName = v2927, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v2940 : int32 = v2855.Length
                        let v2941 : Mut5 = {l0 = 0} : Mut5
                        while method21(v2940, v2941) do
                            let v2943 : int32 = v2941.l0
                            let struct (v2944 : string, v2945 : string) = v2855.[int v2943]
                            v2939.EnvironmentVariables.[v2944] <- v2945 
                            let v2946 : int32 = v2943 + 1
                            v2941.l0 <- v2946
                            ()
                        let v2947 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v2939)
                        use v2947 = v2947 
                        let v2948 : System.Diagnostics.Process = v2947 
                        let v2949 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v2950 : System.Collections.Concurrent.ConcurrentStack<string> = v2949 ()
                        let v2951 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v2854, v2852, v2855, v2856, v2857, v2948, v2950)
                        v2948.OutputDataReceived.Add v2951 
                        let v2952 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v2854, v2852, v2855, v2856, v2857, v2948, v2950)
                        v2948.ErrorDataReceived.Add v2952 
                        let v2953 : (unit -> bool) = v2948.Start
                        let v2954 : bool = v2953 ()
                        let v2955 : bool = v2954 = false
                        if v2955 then
                            let v2956 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v2956
                        let v2957 : (unit -> unit) = v2948.BeginErrorReadLine
                        v2957 ()
                        let v2958 : (unit -> unit) = v2948.BeginOutputReadLine
                        v2958 ()
                        let v2959 : (System.Threading.CancellationToken -> US16) = method61()
                        let v2960 : US16 = US16_1
                        let v2961 : US16 = v2854 |> Option.map v2959 |> Option.defaultValue v2960 
                        let v2965 : System.Threading.CancellationToken =
                            match v2961 with
                            | US16_1 -> (* None *)
                                let v2963 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v2963
                            | US16_0(v2962) -> (* Some *)
                                v2962
                        let v2966 : Async<System.Threading.CancellationToken> option = None
                        let v2967 : bool = true in let mutable _v2966 = v2966
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2968 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2968
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2969 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2969
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2970 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2970
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2971 : Async<System.Threading.CancellationToken> option = None
                        let v2972 : bool = true in let mutable _v2971 = v2971
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2973 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2973
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2974 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2974
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2975 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2975
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2976 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v2976 = v2976
                        async {
                        let v2977 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v2977 = v2977 
                        let v2978 : System.Threading.CancellationToken = v2977 
                        let v2979 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v2980 : (System.Threading.CancellationToken []) = [|v2978; v2979; v2965|]
                        let v2981 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v2982 : System.Threading.CancellationTokenSource = v2981 v2980
                        let v2983 : System.Threading.CancellationToken = v2982.Token
                        return v2983 
                        }
                        |> fun x -> _v2976 <- Some x
                        let v2984 : Async<System.Threading.CancellationToken> = _v2976 |> Option.get
                        v2984
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2985 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2985
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2986 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2986
#endif
                        |> fun x -> _v2971 <- Some x
                        let v2987 : Async<System.Threading.CancellationToken> = _v2971.Value
                        v2987
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2988 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2988
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2989 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2989
#endif
                        |> fun x -> _v2966 <- Some x
                        let v2990 : Async<System.Threading.CancellationToken> = _v2966.Value
                        let! v2990 = v2990 
                        let v2991 : System.Threading.CancellationToken = v2990 
                        let v2992 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v2991.Register
                        let v2993 : (unit -> unit) = closure50(v2948)
                        let v2994 : System.Threading.CancellationTokenRegistration = v2992 v2993
                        use v2994 = v2994 
                        let v2995 : System.Threading.CancellationTokenRegistration = v2994 
                        let v2996 : Async<int32> option = None
                        let v2997 : bool = true in let mutable _v2996 = v2996
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2998 : Async<int32> = null |> unbox<Async<int32>>
                        v2998
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2999 : Async<int32> = null |> unbox<Async<int32>>
                        v2999
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3000 : Async<int32> = null |> unbox<Async<int32>>
                        v3000
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3001 : Async<int32> option = None
                        let mutable _v3001 = v3001
                        async {
                        try
                        let v3002 : System.Threading.Tasks.Task = v2948.WaitForExitAsync v2991 
                        let v3003 : Async<unit> option = None
                        let v3004 : bool = true in let mutable _v3003 = v3003
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3005 : Async<unit> = null |> unbox<Async<unit>>
                        v3005
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3006 : Async<unit> = null |> unbox<Async<unit>>
                        v3006
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3007 : Async<unit> = null |> unbox<Async<unit>>
                        v3007
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3008 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v3009 : Async<unit> = v3008 v3002
                        v3009
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3010 : Async<unit> = null |> unbox<Async<unit>>
                        v3010
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3011 : Async<unit> = null |> unbox<Async<unit>>
                        v3011
#endif
                        |> fun x -> _v3003 <- Some x
                        let v3012 : Async<unit> = _v3003.Value
                        do! v3012 
                        let v3013 : int32 = v2948.ExitCode
                        return v3013 
                        with ex ->
                        let v3014 : exn = ex
                        let v3015 : string option = None
                        let v3016 : bool = true in let mutable _v3015 = v3015
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3017 : string = $"%A{v3014}"
                        v3017
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3018 : string = $"%A{v3014}"
                        v3018
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3019 : string = $"%A{v3014}"
                        v3019
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3020 : string = $"{v3014.GetType ()}: {v3014.Message}"
                        v3020
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3021 : string = $"%A{v3014}"
                        v3021
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3022 : string = $"%A{v3014}"
                        v3022
#endif
                        |> fun x -> _v3015 <- Some x
                        let v3023 : string = _v3015.Value
                        let v3024 : (string -> unit) = v2950.Push
                        v3024 v3023
                        let v3025 : System.Threading.Tasks.TaskCanceledException = v3014 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v3026 : US0 = US0_3
                        let v3027 : (unit -> string) = closure51(v3025)
                        let v3028 : (unit -> string) = method43()
                        method3(v3026, v3027, v3028)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v3001 <- Some x
                        let v3029 : Async<int32> = _v3001 |> Option.get
                        v3029
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3030 : Async<int32> = null |> unbox<Async<int32>>
                        v3030
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3031 : Async<int32> = null |> unbox<Async<int32>>
                        v3031
#endif
                        |> fun x -> _v2996 <- Some x
                        let v3032 : Async<int32> = _v2996.Value
                        let! v3032 = v3032 
                        let v3033 : int32 = v3032 
                        let v3034 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v3035 : string seq = v3034 v2950
                        let v3036 : string = method62()
                        let v3037 : (string -> (string seq -> string)) = String.concat
                        let v3038 : (string seq -> string) = v3037 v3036
                        let v3039 : string = v3038 v3035
                        let v3040 : US0 = US0_1
                        let v3041 : (unit -> string) = closure52(v3033, v3039)
                        let v3042 : (unit -> string) = method43()
                        method3(v3040, v3041, v3042)
                        return struct (v3033, v3039) 
                        }
                        |> fun x -> _v2908 <- Some x
                        let v3043 : Async<struct (int32 * string)> = _v2908 |> Option.get
                        v3043
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3044 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3044
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3045 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3045
#endif
                        |> fun x -> _v2903 <- Some x
                        let v3046 : Async<struct (int32 * string)> = _v2903.Value
                        v3046
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3047 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3047
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3048 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3048
#endif
                        |> fun x -> _v2898 <- Some x
                        let v3049 : Async<struct (int32 * string)> = _v2898.Value
                        let v3050 : struct (int32 * string) option = None
                        let v3051 : bool = true in let mutable _v3050 = v3050
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v3052 : int32, v3053 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3052, v3053)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v3054 : int32, v3055 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3054, v3055)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v3056 : int32, v3057 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3056, v3057)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3058 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v3059 : int32, v3060 : string) = v3058 v3049
                        struct (v3059, v3060)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v3061 : int32, v3062 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3061, v3062)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v3063 : int32, v3064 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3063, v3064)
#endif
                        |> fun x -> _v3050 <- Some x
                        let struct (v3065 : int32, v3066 : string) = _v3050.Value
                        struct (v3065, v3066)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v3067 : int32, v3068 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3067, v3068)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v3069 : int32, v3070 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3069, v3070)
#endif
                        |> fun x -> _v2858 <- Some x
                        let struct (v3071 : int32, v3072 : string) = _v2858.Value
                        let v3073 : bool = v3071 <> 0
                        let v3076 : bool =
                            if v3073 then
                                true
                            else
                                let v3074 : string = "ERROR"
                                let v3075 : bool = v3072.Contains v3074
                                v3075
                        if v3076 then
                            let v3077 : US0 = US0_2
                            let v3078 : (unit -> string) = closure53()
                            let v3079 : (unit -> string) = closure54(v3072, v3071)
                            method3(v3077, v3078, v3079)
                            let v3080 : (string * string) = v2292, v3072
                            let v3081 : Result<string, (string * string)> = Error v3080
                            US17_0(v3081)
                        else
                            let v3083 : unit option = None
                            let v3084 : bool = true in let mutable _v3083 = v3083
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v3085 : string = method63(v2293)
                            let v3086 : string = "std::fs::copy(&*v2292, &*v3085)"
                            let v3087 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v3086
                            let v3088 : string = "$0.unwrap()"
                            let v3089 : uint64 = Fable.Core.RustInterop.emitRustExpr v3087 v3088
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
                            
#if !FABLE_COMPILER && !WASM && !CONTRACT
                            System.IO.File.Copy (v2292, v2293, true)
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
                            |> fun x -> _v3083 <- Some x
                            _v3083.Value
                            let v3090 : Result<string, (string * string)> = Ok v2292
                            US17_0(v3090)
                    else
                        US17_1
                let v3099 : Result<string, (string * string)> option =
                    match v3094 with
                    | US17_1 -> (* None *)
                        let v3097 : Result<string, (string * string)> option = None
                        v3097
                    | US17_0(v3095) -> (* Some *)
                        let v3096 : Result<string, (string * string)> option = Some v3095 
                        v3096
                let v3100 : string = "html"
                let v3101 : string = $"{v647}.{v3100}"
                let v3102 : string = $"{v1200}.{v3100}"
                let v3103 : bool option = None
                let v3104 : bool = true in let mutable _v3103 = v3103
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3105 : string = method14(v3101)
                let v3106 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                let v3107 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3105 v3106
                let v3108 : string = "String::from($0)"
                let v3109 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3107 v3108
                let v3110 : string = "std::path::PathBuf::from($0)"
                let v3111 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v3109 v3110
                let v3112 : string = "$0.exists()"
                let v3113 : bool = Fable.Core.RustInterop.emitRustExpr v3111 v3112
                let v3116 : bool =
                    if v3113 then
                        let v3114 : string = "$0.is_file()"
                        let v3115 : bool = Fable.Core.RustInterop.emitRustExpr v3111 v3114
                        v3115
                    else
                        false
                v3116
#endif
                
#if FABLE_COMPILER_RUST && WASM
                let v3117 : bool = null |> unbox<bool>
                v3117
#endif
                
#if FABLE_COMPILER_RUST && CONTRACT
                let v3118 : bool = null |> unbox<bool>
                v3118
#endif
                
#if !FABLE_COMPILER && !WASM && !CONTRACT
                let v3119 : (string -> bool) = System.IO.File.Exists
                let v3120 : bool = v3119 v3101
                v3120
#endif
                
#if FABLE_COMPILER_TYPESCRIPT
                let v3121 : IFsExistsSync = Fable.Core.JsInterop.importAll v1219
                let v3122 : string = "v3121.existsSync($0)"
                let v3123 : bool = Fable.Core.JsInterop.emitJsExpr v3101 v3122
                v3123
#endif
                
#if FABLE_COMPILER_PYTHON
                let v3124 : bool = null |> unbox<bool>
                v3124
#endif
                |> fun x -> _v3103 <- Some x
                let v3125 : bool = _v3103.Value
                let v3149 : bool =
                    if v3125 then
                        let v3126 : bool option = None
                        let v3127 : bool = true in let mutable _v3126 = v3126
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3128 : string = method14(v3102)
                        let v3129 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                        let v3130 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3128 v3129
                        let v3131 : string = "String::from($0)"
                        let v3132 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3130 v3131
                        let v3133 : string = "std::path::PathBuf::from($0)"
                        let v3134 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v3132 v3133
                        let v3135 : string = "$0.exists()"
                        let v3136 : bool = Fable.Core.RustInterop.emitRustExpr v3134 v3135
                        let v3139 : bool =
                            if v3136 then
                                let v3137 : string = "$0.is_file()"
                                let v3138 : bool = Fable.Core.RustInterop.emitRustExpr v3134 v3137
                                v3138
                            else
                                false
                        v3139
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3140 : bool = null |> unbox<bool>
                        v3140
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3141 : bool = null |> unbox<bool>
                        v3141
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3142 : (string -> bool) = System.IO.File.Exists
                        let v3143 : bool = v3142 v3102
                        v3143
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3144 : IFsExistsSync = Fable.Core.JsInterop.importAll v1219
                        let v3145 : string = "v3144.existsSync($0)"
                        let v3146 : bool = Fable.Core.JsInterop.emitJsExpr v3102 v3145
                        v3146
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3147 : bool = null |> unbox<bool>
                        v3147
#endif
                        |> fun x -> _v3126 <- Some x
                        let v3148 : bool = _v3126.Value
                        v3148
                    else
                        false
                let v3659 : bool =
                    if v3149 then
                        let v3150 : bool option = None
                        let v3151 : bool = true in let mutable _v3150 = v3150
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3152 : string = "cfg!(windows)"
                        let v3153 : bool = Fable.Core.RustInterop.emitRustExpr () v3152
                        v3153
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3154 : bool = null |> unbox<bool>
                        v3154
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3155 : bool = null |> unbox<bool>
                        v3155
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3156 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                        let v3157 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                        let v3158 : bool = v3157 v3156
                        v3158
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3159 : bool = null |> unbox<bool>
                        v3159
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3160 : bool = null |> unbox<bool>
                        v3160
#endif
                        |> fun x -> _v3150 <- Some x
                        let v3161 : bool = _v3150.Value
                        let v3162 : bool = v3161 = false
                        let v3183 : string =
                            if v3162 then
                                v3101
                            else
                                let v3163 : string option = None
                                let v3164 : bool = true in let mutable _v3163 = v3163
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v3165 : string = method17()
                                let v3166 : string = method18(v3101)
                                let v3167 : string = method19()
                                let v3168 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                                let v3169 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v3165, v3166, v3167) v3168
                                let v3170 : string = "String::from($0)"
                                let v3171 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3169 v3170
                                let v3172 : string = "fable_library_rust::String_::fromString($0)"
                                let v3173 : string = Fable.Core.RustInterop.emitRustExpr v3171 v3172
                                v3173
#endif
                                
#if FABLE_COMPILER_RUST && WASM
                                let v3174 : string = null |> unbox<string>
                                v3174
#endif
                                
#if FABLE_COMPILER_RUST && CONTRACT
                                let v3175 : string = null |> unbox<string>
                                v3175
#endif
                                
#if !FABLE_COMPILER && !WASM && !CONTRACT
                                let v3176 : string = "^\\\\\\\\\\?\\\\"
                                let v3177 : string = System.Text.RegularExpressions.Regex.Replace (v3101, v3176, v233)
                                v3177
#endif
                                
#if FABLE_COMPILER_TYPESCRIPT
                                let v3178 : string = null |> unbox<string>
                                v3178
#endif
                                
#if FABLE_COMPILER_PYTHON
                                let v3179 : string = null |> unbox<string>
                                v3179
#endif
                                |> fun x -> _v3163 <- Some x
                                let v3180 : string = _v3163.Value
                                let v3181 : string = $"{v3180.[0] |> string |> _.ToLower()}{v3180.[1..]}"
                                let v3182 : string = v3181.Replace (v235, v236)
                                v3182
                        let v3184 : string option = None
                        let v3185 : System.Threading.CancellationToken option = None
                        let v3186 : (struct (string * string) []) = [||]
                        let v3187 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v3188 : string = $"pwsh -c \"(Get-FileHash \\\"{v3183}\\\" -Algorithm SHA256).Hash\""
                        let v3189 : struct (int32 * string) option = None
                        let v3190 : bool = true in let mutable _v3189 = v3189
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3191 : string = method33(v3185, v3188, v3186, v3187, v3184)
                        let struct (v3192 : string, v3193 : string) = method34()
                        let v3194 : int32 = v3191.Length
                        let v3195 : (char []) = Array.zeroCreate<char> (v3194)
                        let v3196 : Mut5 = {l0 = 0} : Mut5
                        while method21(v3194, v3196) do
                            let v3198 : int32 = v3196.l0
                            let v3199 : char = v3191.[int v3198]
                            v3195.[int v3198] <- v3199
                            let v3200 : int32 = v3198 + 1
                            v3196.l0 <- v3200
                            ()
                        let v3201 : ((char []) -> char list) = Array.toList
                        let v3202 : char list = v3201 v3195
                        let v3203 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v3204 : (char -> (UH0 -> UH0)) = method35()
                        let v3205 : (char list -> (UH0 -> UH0)) = v3203 v3204
                        let v3206 : (UH0 -> UH0) = v3205 v3202
                        let v3207 : UH0 = UH0_0
                        let v3208 : UH0 = v3206 v3207
                        let v3209 : US8 = US8_0
                        let struct (v3210 : string, v3211 : string) = method36(v3193, v3192, v3208, v3209)
                        let v3212 : (string []) = method37(v3211)
                        let v3213 : string = "$0.to_vec()"
                        let v3214 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v3212 v3213
                        let v3215 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v3216 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3214, v383) v3215
                        let v3217 : US0 = US0_1
                        let v3218 : (unit -> string) = closure28(v3185, v3188, v3186, v3187, v3184, v3210, v3216)
                        let v3219 : (unit -> string) = method43()
                        method3(v3217, v3218, v3219)
                        let v3220 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method44(v3185, v3188, v3186, v3187, v3184, v3210, v3216)
                        let v3221 : string = "futures_lite::future::block_on($0)"
                        let v3222 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v3220 v3221
                        let (a, b) = v3222
                        let v3223 : int32 = a
                        let v3224 : string = b
                        struct (v3223, v3224)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v3225 : int32, v3226 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3225, v3226)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v3227 : int32, v3228 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3227, v3228)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3229 : Async<struct (int32 * string)> option = None
                        let v3230 : bool = true in let mutable _v3229 = v3229
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3231 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3231
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3232 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3232
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3233 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3233
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3234 : Async<struct (int32 * string)> option = None
                        let v3235 : bool = true in let mutable _v3234 = v3234
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3236 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3236
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3237 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3237
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3238 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3238
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3239 : Async<struct (int32 * string)> option = None
                        let mutable _v3239 = v3239
                        async {
                        let struct (v3240 : string, v3241 : string) = method34()
                        let v3242 : int32 = v3188.Length
                        let v3243 : (char []) = Array.zeroCreate<char> (v3242)
                        let v3244 : Mut5 = {l0 = 0} : Mut5
                        while method21(v3242, v3244) do
                            let v3246 : int32 = v3244.l0
                            let v3247 : char = v3188.[int v3246]
                            v3243.[int v3246] <- v3247
                            let v3248 : int32 = v3246 + 1
                            v3244.l0 <- v3248
                            ()
                        let v3249 : ((char []) -> char list) = Array.toList
                        let v3250 : char list = v3249 v3243
                        let v3251 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v3252 : (char -> (UH0 -> UH0)) = method35()
                        let v3253 : (char list -> (UH0 -> UH0)) = v3251 v3252
                        let v3254 : (UH0 -> UH0) = v3253 v3250
                        let v3255 : UH0 = UH0_0
                        let v3256 : UH0 = v3254 v3255
                        let v3257 : US8 = US8_0
                        let struct (v3258 : string, v3259 : string) = method36(v3241, v3240, v3256, v3257)
                        let v3260 : (string -> US7) = method38()
                        let v3261 : US7 = US7_1
                        let v3262 : US7 = v3184 |> Option.map v3260 |> Option.defaultValue v3261 
                        let v3265 : string =
                            match v3262 with
                            | US7_1 -> (* None *)
                                v233
                            | US7_0(v3263) -> (* Some *)
                                v3263
                        let v3266 : US0 = US0_1
                        let v3267 : (unit -> string) = closure44(v3185, v3188, v3186, v3187, v3184)
                        let v3268 : (unit -> string) = method43()
                        method3(v3266, v3267, v3268)
                        let v3269 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v3270 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v3259, StandardOutputEncoding = v3269, WorkingDirectory = v3265, FileName = v3258, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v3271 : int32 = v3186.Length
                        let v3272 : Mut5 = {l0 = 0} : Mut5
                        while method21(v3271, v3272) do
                            let v3274 : int32 = v3272.l0
                            let struct (v3275 : string, v3276 : string) = v3186.[int v3274]
                            v3270.EnvironmentVariables.[v3275] <- v3276 
                            let v3277 : int32 = v3274 + 1
                            v3272.l0 <- v3277
                            ()
                        let v3278 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v3270)
                        use v3278 = v3278 
                        let v3279 : System.Diagnostics.Process = v3278 
                        let v3280 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v3281 : System.Collections.Concurrent.ConcurrentStack<string> = v3280 ()
                        let v3282 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v3185, v3188, v3186, v3187, v3184, v3279, v3281)
                        v3279.OutputDataReceived.Add v3282 
                        let v3283 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v3185, v3188, v3186, v3187, v3184, v3279, v3281)
                        v3279.ErrorDataReceived.Add v3283 
                        let v3284 : (unit -> bool) = v3279.Start
                        let v3285 : bool = v3284 ()
                        let v3286 : bool = v3285 = false
                        if v3286 then
                            let v3287 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v3287
                        let v3288 : (unit -> unit) = v3279.BeginErrorReadLine
                        v3288 ()
                        let v3289 : (unit -> unit) = v3279.BeginOutputReadLine
                        v3289 ()
                        let v3290 : (System.Threading.CancellationToken -> US16) = method61()
                        let v3291 : US16 = US16_1
                        let v3292 : US16 = v3185 |> Option.map v3290 |> Option.defaultValue v3291 
                        let v3296 : System.Threading.CancellationToken =
                            match v3292 with
                            | US16_1 -> (* None *)
                                let v3294 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v3294
                            | US16_0(v3293) -> (* Some *)
                                v3293
                        let v3297 : Async<System.Threading.CancellationToken> option = None
                        let v3298 : bool = true in let mutable _v3297 = v3297
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3299 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3299
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3300 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3300
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3301 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3301
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3302 : Async<System.Threading.CancellationToken> option = None
                        let v3303 : bool = true in let mutable _v3302 = v3302
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3304 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3304
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3305 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3305
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3306 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3306
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3307 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v3307 = v3307
                        async {
                        let v3308 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v3308 = v3308 
                        let v3309 : System.Threading.CancellationToken = v3308 
                        let v3310 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v3311 : (System.Threading.CancellationToken []) = [|v3309; v3310; v3296|]
                        let v3312 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v3313 : System.Threading.CancellationTokenSource = v3312 v3311
                        let v3314 : System.Threading.CancellationToken = v3313.Token
                        return v3314 
                        }
                        |> fun x -> _v3307 <- Some x
                        let v3315 : Async<System.Threading.CancellationToken> = _v3307 |> Option.get
                        v3315
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3316 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3316
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3317 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3317
#endif
                        |> fun x -> _v3302 <- Some x
                        let v3318 : Async<System.Threading.CancellationToken> = _v3302.Value
                        v3318
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3319 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3319
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3320 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3320
#endif
                        |> fun x -> _v3297 <- Some x
                        let v3321 : Async<System.Threading.CancellationToken> = _v3297.Value
                        let! v3321 = v3321 
                        let v3322 : System.Threading.CancellationToken = v3321 
                        let v3323 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v3322.Register
                        let v3324 : (unit -> unit) = closure50(v3279)
                        let v3325 : System.Threading.CancellationTokenRegistration = v3323 v3324
                        use v3325 = v3325 
                        let v3326 : System.Threading.CancellationTokenRegistration = v3325 
                        let v3327 : Async<int32> option = None
                        let v3328 : bool = true in let mutable _v3327 = v3327
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3329 : Async<int32> = null |> unbox<Async<int32>>
                        v3329
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3330 : Async<int32> = null |> unbox<Async<int32>>
                        v3330
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3331 : Async<int32> = null |> unbox<Async<int32>>
                        v3331
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3332 : Async<int32> option = None
                        let mutable _v3332 = v3332
                        async {
                        try
                        let v3333 : System.Threading.Tasks.Task = v3279.WaitForExitAsync v3322 
                        let v3334 : Async<unit> option = None
                        let v3335 : bool = true in let mutable _v3334 = v3334
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3336 : Async<unit> = null |> unbox<Async<unit>>
                        v3336
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3337 : Async<unit> = null |> unbox<Async<unit>>
                        v3337
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3338 : Async<unit> = null |> unbox<Async<unit>>
                        v3338
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3339 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v3340 : Async<unit> = v3339 v3333
                        v3340
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3341 : Async<unit> = null |> unbox<Async<unit>>
                        v3341
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3342 : Async<unit> = null |> unbox<Async<unit>>
                        v3342
#endif
                        |> fun x -> _v3334 <- Some x
                        let v3343 : Async<unit> = _v3334.Value
                        do! v3343 
                        let v3344 : int32 = v3279.ExitCode
                        return v3344 
                        with ex ->
                        let v3345 : exn = ex
                        let v3346 : string option = None
                        let v3347 : bool = true in let mutable _v3346 = v3346
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3348 : string = $"%A{v3345}"
                        v3348
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3349 : string = $"%A{v3345}"
                        v3349
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3350 : string = $"%A{v3345}"
                        v3350
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3351 : string = $"{v3345.GetType ()}: {v3345.Message}"
                        v3351
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3352 : string = $"%A{v3345}"
                        v3352
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3353 : string = $"%A{v3345}"
                        v3353
#endif
                        |> fun x -> _v3346 <- Some x
                        let v3354 : string = _v3346.Value
                        let v3355 : (string -> unit) = v3281.Push
                        v3355 v3354
                        let v3356 : System.Threading.Tasks.TaskCanceledException = v3345 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v3357 : US0 = US0_3
                        let v3358 : (unit -> string) = closure51(v3356)
                        let v3359 : (unit -> string) = method43()
                        method3(v3357, v3358, v3359)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v3332 <- Some x
                        let v3360 : Async<int32> = _v3332 |> Option.get
                        v3360
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3361 : Async<int32> = null |> unbox<Async<int32>>
                        v3361
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3362 : Async<int32> = null |> unbox<Async<int32>>
                        v3362
#endif
                        |> fun x -> _v3327 <- Some x
                        let v3363 : Async<int32> = _v3327.Value
                        let! v3363 = v3363 
                        let v3364 : int32 = v3363 
                        let v3365 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v3366 : string seq = v3365 v3281
                        let v3367 : string = method62()
                        let v3368 : (string -> (string seq -> string)) = String.concat
                        let v3369 : (string seq -> string) = v3368 v3367
                        let v3370 : string = v3369 v3366
                        let v3371 : US0 = US0_1
                        let v3372 : (unit -> string) = closure52(v3364, v3370)
                        let v3373 : (unit -> string) = method43()
                        method3(v3371, v3372, v3373)
                        return struct (v3364, v3370) 
                        }
                        |> fun x -> _v3239 <- Some x
                        let v3374 : Async<struct (int32 * string)> = _v3239 |> Option.get
                        v3374
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3375 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3375
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3376 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3376
#endif
                        |> fun x -> _v3234 <- Some x
                        let v3377 : Async<struct (int32 * string)> = _v3234.Value
                        v3377
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3378 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3378
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3379 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3379
#endif
                        |> fun x -> _v3229 <- Some x
                        let v3380 : Async<struct (int32 * string)> = _v3229.Value
                        let v3381 : struct (int32 * string) option = None
                        let v3382 : bool = true in let mutable _v3381 = v3381
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v3383 : int32, v3384 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3383, v3384)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v3385 : int32, v3386 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3385, v3386)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v3387 : int32, v3388 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3387, v3388)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3389 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v3390 : int32, v3391 : string) = v3389 v3380
                        struct (v3390, v3391)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v3392 : int32, v3393 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3392, v3393)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v3394 : int32, v3395 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3394, v3395)
#endif
                        |> fun x -> _v3381 <- Some x
                        let struct (v3396 : int32, v3397 : string) = _v3381.Value
                        struct (v3396, v3397)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v3398 : int32, v3399 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3398, v3399)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v3400 : int32, v3401 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3400, v3401)
#endif
                        |> fun x -> _v3189 <- Some x
                        let struct (v3402 : int32, v3403 : string) = _v3189.Value
                        let v3404 : bool option = None
                        let v3405 : bool = true in let mutable _v3404 = v3404
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3406 : string = "cfg!(windows)"
                        let v3407 : bool = Fable.Core.RustInterop.emitRustExpr () v3406
                        v3407
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3408 : bool = null |> unbox<bool>
                        v3408
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3409 : bool = null |> unbox<bool>
                        v3409
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3410 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                        let v3411 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                        let v3412 : bool = v3411 v3410
                        v3412
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3413 : bool = null |> unbox<bool>
                        v3413
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3414 : bool = null |> unbox<bool>
                        v3414
#endif
                        |> fun x -> _v3404 <- Some x
                        let v3415 : bool = _v3404.Value
                        let v3416 : bool = v3415 = false
                        let v3437 : string =
                            if v3416 then
                                v3102
                            else
                                let v3417 : string option = None
                                let v3418 : bool = true in let mutable _v3417 = v3417
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v3419 : string = method17()
                                let v3420 : string = method18(v3102)
                                let v3421 : string = method19()
                                let v3422 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                                let v3423 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v3419, v3420, v3421) v3422
                                let v3424 : string = "String::from($0)"
                                let v3425 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3423 v3424
                                let v3426 : string = "fable_library_rust::String_::fromString($0)"
                                let v3427 : string = Fable.Core.RustInterop.emitRustExpr v3425 v3426
                                v3427
#endif
                                
#if FABLE_COMPILER_RUST && WASM
                                let v3428 : string = null |> unbox<string>
                                v3428
#endif
                                
#if FABLE_COMPILER_RUST && CONTRACT
                                let v3429 : string = null |> unbox<string>
                                v3429
#endif
                                
#if !FABLE_COMPILER && !WASM && !CONTRACT
                                let v3430 : string = "^\\\\\\\\\\?\\\\"
                                let v3431 : string = System.Text.RegularExpressions.Regex.Replace (v3102, v3430, v233)
                                v3431
#endif
                                
#if FABLE_COMPILER_TYPESCRIPT
                                let v3432 : string = null |> unbox<string>
                                v3432
#endif
                                
#if FABLE_COMPILER_PYTHON
                                let v3433 : string = null |> unbox<string>
                                v3433
#endif
                                |> fun x -> _v3417 <- Some x
                                let v3434 : string = _v3417.Value
                                let v3435 : string = $"{v3434.[0] |> string |> _.ToLower()}{v3434.[1..]}"
                                let v3436 : string = v3435.Replace (v235, v236)
                                v3436
                        let v3438 : string option = None
                        let v3439 : System.Threading.CancellationToken option = None
                        let v3440 : (struct (string * string) []) = [||]
                        let v3441 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v3442 : string = $"pwsh -c \"(Get-FileHash \\\"{v3437}\\\" -Algorithm SHA256).Hash\""
                        let v3443 : struct (int32 * string) option = None
                        let v3444 : bool = true in let mutable _v3443 = v3443
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3445 : string = method33(v3439, v3442, v3440, v3441, v3438)
                        let struct (v3446 : string, v3447 : string) = method34()
                        let v3448 : int32 = v3445.Length
                        let v3449 : (char []) = Array.zeroCreate<char> (v3448)
                        let v3450 : Mut5 = {l0 = 0} : Mut5
                        while method21(v3448, v3450) do
                            let v3452 : int32 = v3450.l0
                            let v3453 : char = v3445.[int v3452]
                            v3449.[int v3452] <- v3453
                            let v3454 : int32 = v3452 + 1
                            v3450.l0 <- v3454
                            ()
                        let v3455 : ((char []) -> char list) = Array.toList
                        let v3456 : char list = v3455 v3449
                        let v3457 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v3458 : (char -> (UH0 -> UH0)) = method35()
                        let v3459 : (char list -> (UH0 -> UH0)) = v3457 v3458
                        let v3460 : (UH0 -> UH0) = v3459 v3456
                        let v3461 : UH0 = UH0_0
                        let v3462 : UH0 = v3460 v3461
                        let v3463 : US8 = US8_0
                        let struct (v3464 : string, v3465 : string) = method36(v3447, v3446, v3462, v3463)
                        let v3466 : (string []) = method37(v3465)
                        let v3467 : string = "$0.to_vec()"
                        let v3468 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v3466 v3467
                        let v3469 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v3470 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3468, v383) v3469
                        let v3471 : US0 = US0_1
                        let v3472 : (unit -> string) = closure28(v3439, v3442, v3440, v3441, v3438, v3464, v3470)
                        let v3473 : (unit -> string) = method43()
                        method3(v3471, v3472, v3473)
                        let v3474 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method44(v3439, v3442, v3440, v3441, v3438, v3464, v3470)
                        let v3475 : string = "futures_lite::future::block_on($0)"
                        let v3476 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v3474 v3475
                        let (a, b) = v3476
                        let v3477 : int32 = a
                        let v3478 : string = b
                        struct (v3477, v3478)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v3479 : int32, v3480 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3479, v3480)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v3481 : int32, v3482 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3481, v3482)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3483 : Async<struct (int32 * string)> option = None
                        let v3484 : bool = true in let mutable _v3483 = v3483
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3485 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3485
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3486 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3486
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3487 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3487
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3488 : Async<struct (int32 * string)> option = None
                        let v3489 : bool = true in let mutable _v3488 = v3488
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3490 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3490
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3491 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3491
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3492 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3492
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3493 : Async<struct (int32 * string)> option = None
                        let mutable _v3493 = v3493
                        async {
                        let struct (v3494 : string, v3495 : string) = method34()
                        let v3496 : int32 = v3442.Length
                        let v3497 : (char []) = Array.zeroCreate<char> (v3496)
                        let v3498 : Mut5 = {l0 = 0} : Mut5
                        while method21(v3496, v3498) do
                            let v3500 : int32 = v3498.l0
                            let v3501 : char = v3442.[int v3500]
                            v3497.[int v3500] <- v3501
                            let v3502 : int32 = v3500 + 1
                            v3498.l0 <- v3502
                            ()
                        let v3503 : ((char []) -> char list) = Array.toList
                        let v3504 : char list = v3503 v3497
                        let v3505 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v3506 : (char -> (UH0 -> UH0)) = method35()
                        let v3507 : (char list -> (UH0 -> UH0)) = v3505 v3506
                        let v3508 : (UH0 -> UH0) = v3507 v3504
                        let v3509 : UH0 = UH0_0
                        let v3510 : UH0 = v3508 v3509
                        let v3511 : US8 = US8_0
                        let struct (v3512 : string, v3513 : string) = method36(v3495, v3494, v3510, v3511)
                        let v3514 : (string -> US7) = method38()
                        let v3515 : US7 = US7_1
                        let v3516 : US7 = v3438 |> Option.map v3514 |> Option.defaultValue v3515 
                        let v3519 : string =
                            match v3516 with
                            | US7_1 -> (* None *)
                                v233
                            | US7_0(v3517) -> (* Some *)
                                v3517
                        let v3520 : US0 = US0_1
                        let v3521 : (unit -> string) = closure44(v3439, v3442, v3440, v3441, v3438)
                        let v3522 : (unit -> string) = method43()
                        method3(v3520, v3521, v3522)
                        let v3523 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v3524 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v3513, StandardOutputEncoding = v3523, WorkingDirectory = v3519, FileName = v3512, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v3525 : int32 = v3440.Length
                        let v3526 : Mut5 = {l0 = 0} : Mut5
                        while method21(v3525, v3526) do
                            let v3528 : int32 = v3526.l0
                            let struct (v3529 : string, v3530 : string) = v3440.[int v3528]
                            v3524.EnvironmentVariables.[v3529] <- v3530 
                            let v3531 : int32 = v3528 + 1
                            v3526.l0 <- v3531
                            ()
                        let v3532 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v3524)
                        use v3532 = v3532 
                        let v3533 : System.Diagnostics.Process = v3532 
                        let v3534 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v3535 : System.Collections.Concurrent.ConcurrentStack<string> = v3534 ()
                        let v3536 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v3439, v3442, v3440, v3441, v3438, v3533, v3535)
                        v3533.OutputDataReceived.Add v3536 
                        let v3537 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v3439, v3442, v3440, v3441, v3438, v3533, v3535)
                        v3533.ErrorDataReceived.Add v3537 
                        let v3538 : (unit -> bool) = v3533.Start
                        let v3539 : bool = v3538 ()
                        let v3540 : bool = v3539 = false
                        if v3540 then
                            let v3541 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v3541
                        let v3542 : (unit -> unit) = v3533.BeginErrorReadLine
                        v3542 ()
                        let v3543 : (unit -> unit) = v3533.BeginOutputReadLine
                        v3543 ()
                        let v3544 : (System.Threading.CancellationToken -> US16) = method61()
                        let v3545 : US16 = US16_1
                        let v3546 : US16 = v3439 |> Option.map v3544 |> Option.defaultValue v3545 
                        let v3550 : System.Threading.CancellationToken =
                            match v3546 with
                            | US16_1 -> (* None *)
                                let v3548 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v3548
                            | US16_0(v3547) -> (* Some *)
                                v3547
                        let v3551 : Async<System.Threading.CancellationToken> option = None
                        let v3552 : bool = true in let mutable _v3551 = v3551
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3553 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3553
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3554 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3554
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3555 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3555
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3556 : Async<System.Threading.CancellationToken> option = None
                        let v3557 : bool = true in let mutable _v3556 = v3556
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3558 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3558
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3559 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3559
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3560 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3560
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3561 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v3561 = v3561
                        async {
                        let v3562 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v3562 = v3562 
                        let v3563 : System.Threading.CancellationToken = v3562 
                        let v3564 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v3565 : (System.Threading.CancellationToken []) = [|v3563; v3564; v3550|]
                        let v3566 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v3567 : System.Threading.CancellationTokenSource = v3566 v3565
                        let v3568 : System.Threading.CancellationToken = v3567.Token
                        return v3568 
                        }
                        |> fun x -> _v3561 <- Some x
                        let v3569 : Async<System.Threading.CancellationToken> = _v3561 |> Option.get
                        v3569
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3570 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3570
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3571 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3571
#endif
                        |> fun x -> _v3556 <- Some x
                        let v3572 : Async<System.Threading.CancellationToken> = _v3556.Value
                        v3572
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3573 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3573
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3574 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3574
#endif
                        |> fun x -> _v3551 <- Some x
                        let v3575 : Async<System.Threading.CancellationToken> = _v3551.Value
                        let! v3575 = v3575 
                        let v3576 : System.Threading.CancellationToken = v3575 
                        let v3577 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v3576.Register
                        let v3578 : (unit -> unit) = closure50(v3533)
                        let v3579 : System.Threading.CancellationTokenRegistration = v3577 v3578
                        use v3579 = v3579 
                        let v3580 : System.Threading.CancellationTokenRegistration = v3579 
                        let v3581 : Async<int32> option = None
                        let v3582 : bool = true in let mutable _v3581 = v3581
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3583 : Async<int32> = null |> unbox<Async<int32>>
                        v3583
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3584 : Async<int32> = null |> unbox<Async<int32>>
                        v3584
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3585 : Async<int32> = null |> unbox<Async<int32>>
                        v3585
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3586 : Async<int32> option = None
                        let mutable _v3586 = v3586
                        async {
                        try
                        let v3587 : System.Threading.Tasks.Task = v3533.WaitForExitAsync v3576 
                        let v3588 : Async<unit> option = None
                        let v3589 : bool = true in let mutable _v3588 = v3588
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3590 : Async<unit> = null |> unbox<Async<unit>>
                        v3590
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3591 : Async<unit> = null |> unbox<Async<unit>>
                        v3591
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3592 : Async<unit> = null |> unbox<Async<unit>>
                        v3592
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3593 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v3594 : Async<unit> = v3593 v3587
                        v3594
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3595 : Async<unit> = null |> unbox<Async<unit>>
                        v3595
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3596 : Async<unit> = null |> unbox<Async<unit>>
                        v3596
#endif
                        |> fun x -> _v3588 <- Some x
                        let v3597 : Async<unit> = _v3588.Value
                        do! v3597 
                        let v3598 : int32 = v3533.ExitCode
                        return v3598 
                        with ex ->
                        let v3599 : exn = ex
                        let v3600 : string option = None
                        let v3601 : bool = true in let mutable _v3600 = v3600
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3602 : string = $"%A{v3599}"
                        v3602
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3603 : string = $"%A{v3599}"
                        v3603
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3604 : string = $"%A{v3599}"
                        v3604
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3605 : string = $"{v3599.GetType ()}: {v3599.Message}"
                        v3605
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3606 : string = $"%A{v3599}"
                        v3606
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3607 : string = $"%A{v3599}"
                        v3607
#endif
                        |> fun x -> _v3600 <- Some x
                        let v3608 : string = _v3600.Value
                        let v3609 : (string -> unit) = v3535.Push
                        v3609 v3608
                        let v3610 : System.Threading.Tasks.TaskCanceledException = v3599 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v3611 : US0 = US0_3
                        let v3612 : (unit -> string) = closure51(v3610)
                        let v3613 : (unit -> string) = method43()
                        method3(v3611, v3612, v3613)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v3586 <- Some x
                        let v3614 : Async<int32> = _v3586 |> Option.get
                        v3614
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3615 : Async<int32> = null |> unbox<Async<int32>>
                        v3615
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3616 : Async<int32> = null |> unbox<Async<int32>>
                        v3616
#endif
                        |> fun x -> _v3581 <- Some x
                        let v3617 : Async<int32> = _v3581.Value
                        let! v3617 = v3617 
                        let v3618 : int32 = v3617 
                        let v3619 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v3620 : string seq = v3619 v3535
                        let v3621 : string = method62()
                        let v3622 : (string -> (string seq -> string)) = String.concat
                        let v3623 : (string seq -> string) = v3622 v3621
                        let v3624 : string = v3623 v3620
                        let v3625 : US0 = US0_1
                        let v3626 : (unit -> string) = closure52(v3618, v3624)
                        let v3627 : (unit -> string) = method43()
                        method3(v3625, v3626, v3627)
                        return struct (v3618, v3624) 
                        }
                        |> fun x -> _v3493 <- Some x
                        let v3628 : Async<struct (int32 * string)> = _v3493 |> Option.get
                        v3628
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3629 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3629
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3630 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3630
#endif
                        |> fun x -> _v3488 <- Some x
                        let v3631 : Async<struct (int32 * string)> = _v3488.Value
                        v3631
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3632 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3632
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3633 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3633
#endif
                        |> fun x -> _v3483 <- Some x
                        let v3634 : Async<struct (int32 * string)> = _v3483.Value
                        let v3635 : struct (int32 * string) option = None
                        let v3636 : bool = true in let mutable _v3635 = v3635
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v3637 : int32, v3638 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3637, v3638)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v3639 : int32, v3640 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3639, v3640)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v3641 : int32, v3642 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3641, v3642)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3643 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v3644 : int32, v3645 : string) = v3643 v3634
                        struct (v3644, v3645)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v3646 : int32, v3647 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3646, v3647)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v3648 : int32, v3649 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3648, v3649)
#endif
                        |> fun x -> _v3635 <- Some x
                        let struct (v3650 : int32, v3651 : string) = _v3635.Value
                        struct (v3650, v3651)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v3652 : int32, v3653 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3652, v3653)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v3654 : int32, v3655 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3654, v3655)
#endif
                        |> fun x -> _v3443 <- Some x
                        let struct (v3656 : int32, v3657 : string) = _v3443.Value
                        let v3658 : bool = v3403 = v3657
                        v3658
                    else
                        false
                let v3660 : bool = v3659 = false
                let v3903 : US17 =
                    if v3660 then
                        let v3661 : string = $"crowbook --single \"{v647}\" --output \"{v3101}\" --to {v3100} --set rendering.num_depth 6 html.css.add \\\"''' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} '''\\\""
                        let v3662 : string option = None
                        let v3663 : System.Threading.CancellationToken option = None
                        let v3664 : (struct (string * string) []) = [||]
                        let v3665 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v3666 : string option = Some v1 
                        let v3667 : struct (int32 * string) option = None
                        let v3668 : bool = true in let mutable _v3667 = v3667
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3669 : string = method33(v3663, v3661, v3664, v3665, v3666)
                        let struct (v3670 : string, v3671 : string) = method34()
                        let v3672 : int32 = v3669.Length
                        let v3673 : (char []) = Array.zeroCreate<char> (v3672)
                        let v3674 : Mut5 = {l0 = 0} : Mut5
                        while method21(v3672, v3674) do
                            let v3676 : int32 = v3674.l0
                            let v3677 : char = v3669.[int v3676]
                            v3673.[int v3676] <- v3677
                            let v3678 : int32 = v3676 + 1
                            v3674.l0 <- v3678
                            ()
                        let v3679 : ((char []) -> char list) = Array.toList
                        let v3680 : char list = v3679 v3673
                        let v3681 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v3682 : (char -> (UH0 -> UH0)) = method35()
                        let v3683 : (char list -> (UH0 -> UH0)) = v3681 v3682
                        let v3684 : (UH0 -> UH0) = v3683 v3680
                        let v3685 : UH0 = UH0_0
                        let v3686 : UH0 = v3684 v3685
                        let v3687 : US8 = US8_0
                        let struct (v3688 : string, v3689 : string) = method36(v3671, v3670, v3686, v3687)
                        let v3690 : (string []) = method37(v3689)
                        let v3691 : string = "$0.to_vec()"
                        let v3692 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v3690 v3691
                        let v3693 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v3694 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3692, v383) v3693
                        let v3695 : US0 = US0_1
                        let v3696 : (unit -> string) = closure28(v3663, v3661, v3664, v3665, v3666, v3688, v3694)
                        let v3697 : (unit -> string) = method43()
                        method3(v3695, v3696, v3697)
                        let v3698 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method44(v3663, v3661, v3664, v3665, v3666, v3688, v3694)
                        let v3699 : string = "futures_lite::future::block_on($0)"
                        let v3700 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v3698 v3699
                        let (a, b) = v3700
                        let v3701 : int32 = a
                        let v3702 : string = b
                        struct (v3701, v3702)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v3703 : int32, v3704 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3703, v3704)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v3705 : int32, v3706 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3705, v3706)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3707 : Async<struct (int32 * string)> option = None
                        let v3708 : bool = true in let mutable _v3707 = v3707
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3709 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3709
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3710 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3710
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3711 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3711
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3712 : Async<struct (int32 * string)> option = None
                        let v3713 : bool = true in let mutable _v3712 = v3712
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3714 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3714
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3715 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3715
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3716 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3716
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3717 : Async<struct (int32 * string)> option = None
                        let mutable _v3717 = v3717
                        async {
                        let struct (v3718 : string, v3719 : string) = method34()
                        let v3720 : int32 = v3661.Length
                        let v3721 : (char []) = Array.zeroCreate<char> (v3720)
                        let v3722 : Mut5 = {l0 = 0} : Mut5
                        while method21(v3720, v3722) do
                            let v3724 : int32 = v3722.l0
                            let v3725 : char = v3661.[int v3724]
                            v3721.[int v3724] <- v3725
                            let v3726 : int32 = v3724 + 1
                            v3722.l0 <- v3726
                            ()
                        let v3727 : ((char []) -> char list) = Array.toList
                        let v3728 : char list = v3727 v3721
                        let v3729 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v3730 : (char -> (UH0 -> UH0)) = method35()
                        let v3731 : (char list -> (UH0 -> UH0)) = v3729 v3730
                        let v3732 : (UH0 -> UH0) = v3731 v3728
                        let v3733 : UH0 = UH0_0
                        let v3734 : UH0 = v3732 v3733
                        let v3735 : US8 = US8_0
                        let struct (v3736 : string, v3737 : string) = method36(v3719, v3718, v3734, v3735)
                        let v3738 : (string -> US7) = method38()
                        let v3739 : US7 = US7_1
                        let v3740 : US7 = v3666 |> Option.map v3738 |> Option.defaultValue v3739 
                        let v3743 : string =
                            match v3740 with
                            | US7_1 -> (* None *)
                                v233
                            | US7_0(v3741) -> (* Some *)
                                v3741
                        let v3744 : US0 = US0_1
                        let v3745 : (unit -> string) = closure44(v3663, v3661, v3664, v3665, v3666)
                        let v3746 : (unit -> string) = method43()
                        method3(v3744, v3745, v3746)
                        let v3747 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v3748 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v3737, StandardOutputEncoding = v3747, WorkingDirectory = v3743, FileName = v3736, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v3749 : int32 = v3664.Length
                        let v3750 : Mut5 = {l0 = 0} : Mut5
                        while method21(v3749, v3750) do
                            let v3752 : int32 = v3750.l0
                            let struct (v3753 : string, v3754 : string) = v3664.[int v3752]
                            v3748.EnvironmentVariables.[v3753] <- v3754 
                            let v3755 : int32 = v3752 + 1
                            v3750.l0 <- v3755
                            ()
                        let v3756 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v3748)
                        use v3756 = v3756 
                        let v3757 : System.Diagnostics.Process = v3756 
                        let v3758 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v3759 : System.Collections.Concurrent.ConcurrentStack<string> = v3758 ()
                        let v3760 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v3663, v3661, v3664, v3665, v3666, v3757, v3759)
                        v3757.OutputDataReceived.Add v3760 
                        let v3761 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v3663, v3661, v3664, v3665, v3666, v3757, v3759)
                        v3757.ErrorDataReceived.Add v3761 
                        let v3762 : (unit -> bool) = v3757.Start
                        let v3763 : bool = v3762 ()
                        let v3764 : bool = v3763 = false
                        if v3764 then
                            let v3765 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v3765
                        let v3766 : (unit -> unit) = v3757.BeginErrorReadLine
                        v3766 ()
                        let v3767 : (unit -> unit) = v3757.BeginOutputReadLine
                        v3767 ()
                        let v3768 : (System.Threading.CancellationToken -> US16) = method61()
                        let v3769 : US16 = US16_1
                        let v3770 : US16 = v3663 |> Option.map v3768 |> Option.defaultValue v3769 
                        let v3774 : System.Threading.CancellationToken =
                            match v3770 with
                            | US16_1 -> (* None *)
                                let v3772 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v3772
                            | US16_0(v3771) -> (* Some *)
                                v3771
                        let v3775 : Async<System.Threading.CancellationToken> option = None
                        let v3776 : bool = true in let mutable _v3775 = v3775
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3777 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3777
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3778 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3778
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3779 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3779
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3780 : Async<System.Threading.CancellationToken> option = None
                        let v3781 : bool = true in let mutable _v3780 = v3780
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3782 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3782
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3783 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3783
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3784 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3784
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3785 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v3785 = v3785
                        async {
                        let v3786 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v3786 = v3786 
                        let v3787 : System.Threading.CancellationToken = v3786 
                        let v3788 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v3789 : (System.Threading.CancellationToken []) = [|v3787; v3788; v3774|]
                        let v3790 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v3791 : System.Threading.CancellationTokenSource = v3790 v3789
                        let v3792 : System.Threading.CancellationToken = v3791.Token
                        return v3792 
                        }
                        |> fun x -> _v3785 <- Some x
                        let v3793 : Async<System.Threading.CancellationToken> = _v3785 |> Option.get
                        v3793
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3794 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3794
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3795 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3795
#endif
                        |> fun x -> _v3780 <- Some x
                        let v3796 : Async<System.Threading.CancellationToken> = _v3780.Value
                        v3796
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3797 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3797
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3798 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3798
#endif
                        |> fun x -> _v3775 <- Some x
                        let v3799 : Async<System.Threading.CancellationToken> = _v3775.Value
                        let! v3799 = v3799 
                        let v3800 : System.Threading.CancellationToken = v3799 
                        let v3801 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v3800.Register
                        let v3802 : (unit -> unit) = closure50(v3757)
                        let v3803 : System.Threading.CancellationTokenRegistration = v3801 v3802
                        use v3803 = v3803 
                        let v3804 : System.Threading.CancellationTokenRegistration = v3803 
                        let v3805 : Async<int32> option = None
                        let v3806 : bool = true in let mutable _v3805 = v3805
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3807 : Async<int32> = null |> unbox<Async<int32>>
                        v3807
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3808 : Async<int32> = null |> unbox<Async<int32>>
                        v3808
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3809 : Async<int32> = null |> unbox<Async<int32>>
                        v3809
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3810 : Async<int32> option = None
                        let mutable _v3810 = v3810
                        async {
                        try
                        let v3811 : System.Threading.Tasks.Task = v3757.WaitForExitAsync v3800 
                        let v3812 : Async<unit> option = None
                        let v3813 : bool = true in let mutable _v3812 = v3812
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3814 : Async<unit> = null |> unbox<Async<unit>>
                        v3814
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3815 : Async<unit> = null |> unbox<Async<unit>>
                        v3815
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3816 : Async<unit> = null |> unbox<Async<unit>>
                        v3816
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3817 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v3818 : Async<unit> = v3817 v3811
                        v3818
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3819 : Async<unit> = null |> unbox<Async<unit>>
                        v3819
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3820 : Async<unit> = null |> unbox<Async<unit>>
                        v3820
#endif
                        |> fun x -> _v3812 <- Some x
                        let v3821 : Async<unit> = _v3812.Value
                        do! v3821 
                        let v3822 : int32 = v3757.ExitCode
                        return v3822 
                        with ex ->
                        let v3823 : exn = ex
                        let v3824 : string option = None
                        let v3825 : bool = true in let mutable _v3824 = v3824
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3826 : string = $"%A{v3823}"
                        v3826
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3827 : string = $"%A{v3823}"
                        v3827
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3828 : string = $"%A{v3823}"
                        v3828
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3829 : string = $"{v3823.GetType ()}: {v3823.Message}"
                        v3829
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3830 : string = $"%A{v3823}"
                        v3830
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3831 : string = $"%A{v3823}"
                        v3831
#endif
                        |> fun x -> _v3824 <- Some x
                        let v3832 : string = _v3824.Value
                        let v3833 : (string -> unit) = v3759.Push
                        v3833 v3832
                        let v3834 : System.Threading.Tasks.TaskCanceledException = v3823 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v3835 : US0 = US0_3
                        let v3836 : (unit -> string) = closure51(v3834)
                        let v3837 : (unit -> string) = method43()
                        method3(v3835, v3836, v3837)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v3810 <- Some x
                        let v3838 : Async<int32> = _v3810 |> Option.get
                        v3838
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3839 : Async<int32> = null |> unbox<Async<int32>>
                        v3839
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3840 : Async<int32> = null |> unbox<Async<int32>>
                        v3840
#endif
                        |> fun x -> _v3805 <- Some x
                        let v3841 : Async<int32> = _v3805.Value
                        let! v3841 = v3841 
                        let v3842 : int32 = v3841 
                        let v3843 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v3844 : string seq = v3843 v3759
                        let v3845 : string = method62()
                        let v3846 : (string -> (string seq -> string)) = String.concat
                        let v3847 : (string seq -> string) = v3846 v3845
                        let v3848 : string = v3847 v3844
                        let v3849 : US0 = US0_1
                        let v3850 : (unit -> string) = closure52(v3842, v3848)
                        let v3851 : (unit -> string) = method43()
                        method3(v3849, v3850, v3851)
                        return struct (v3842, v3848) 
                        }
                        |> fun x -> _v3717 <- Some x
                        let v3852 : Async<struct (int32 * string)> = _v3717 |> Option.get
                        v3852
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3853 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3853
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3854 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3854
#endif
                        |> fun x -> _v3712 <- Some x
                        let v3855 : Async<struct (int32 * string)> = _v3712.Value
                        v3855
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3856 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3856
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3857 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3857
#endif
                        |> fun x -> _v3707 <- Some x
                        let v3858 : Async<struct (int32 * string)> = _v3707.Value
                        let v3859 : struct (int32 * string) option = None
                        let v3860 : bool = true in let mutable _v3859 = v3859
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v3861 : int32, v3862 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3861, v3862)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v3863 : int32, v3864 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3863, v3864)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v3865 : int32, v3866 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3865, v3866)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3867 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v3868 : int32, v3869 : string) = v3867 v3858
                        struct (v3868, v3869)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v3870 : int32, v3871 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3870, v3871)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v3872 : int32, v3873 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3872, v3873)
#endif
                        |> fun x -> _v3859 <- Some x
                        let struct (v3874 : int32, v3875 : string) = _v3859.Value
                        struct (v3874, v3875)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v3876 : int32, v3877 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3876, v3877)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v3878 : int32, v3879 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3878, v3879)
#endif
                        |> fun x -> _v3667 <- Some x
                        let struct (v3880 : int32, v3881 : string) = _v3667.Value
                        let v3882 : bool = v3880 <> 0
                        let v3885 : bool =
                            if v3882 then
                                true
                            else
                                let v3883 : string = "ERROR"
                                let v3884 : bool = v3881.Contains v3883
                                v3884
                        if v3885 then
                            let v3886 : US0 = US0_2
                            let v3887 : (unit -> string) = closure53()
                            let v3888 : (unit -> string) = closure54(v3881, v3880)
                            method3(v3886, v3887, v3888)
                            let v3889 : (string * string) = v3101, v3881
                            let v3890 : Result<string, (string * string)> = Error v3889
                            US17_0(v3890)
                        else
                            let v3892 : unit option = None
                            let v3893 : bool = true in let mutable _v3892 = v3892
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v3894 : string = method63(v3102)
                            let v3895 : string = "std::fs::copy(&*v3101, &*v3894)"
                            let v3896 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v3895
                            let v3897 : string = "$0.unwrap()"
                            let v3898 : uint64 = Fable.Core.RustInterop.emitRustExpr v3896 v3897
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
                            
#if !FABLE_COMPILER && !WASM && !CONTRACT
                            System.IO.File.Copy (v3101, v3102, true)
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
                            |> fun x -> _v3892 <- Some x
                            _v3892.Value
                            let v3899 : Result<string, (string * string)> = Ok v3101
                            US17_0(v3899)
                    else
                        US17_1
                let v3908 : Result<string, (string * string)> option =
                    match v3903 with
                    | US17_1 -> (* None *)
                        let v3906 : Result<string, (string * string)> option = None
                        v3906
                    | US17_0(v3904) -> (* Some *)
                        let v3905 : Result<string, (string * string)> option = Some v3904 
                        v3905
                let v3909 : Result<string, (string * string)> option list = []
                let v3910 : Result<string, (string * string)> option list = v1481 :: v3909 
                let v3911 : Result<string, (string * string)> option list = v2290 :: v3910 
                let v3912 : Result<string, (string * string)> option list = v3099 :: v3911 
                let v3913 : Result<string, (string * string)> option list = v3908 :: v3912 
                let v3914 : (Result<string, (string * string)> option list -> (Result<string, (string * string)> option [])) = List.toArray
                let v3915 : (Result<string, (string * string)> option []) = v3914 v3913
                let v3916 : US0 = US0_2
                let v3917 : (unit -> string) = closure55()
                let v3918 : (unit -> string) = closure56(v238, v272, v349, v571, v570, v868, v867, v1124, v1479, v3915)
                method3(v3916, v3917, v3918)
                let v3919 : unit option = None
                let v3920 : bool = true in let mutable _v3919 = v3919
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3921 : string = method63(v1200)
                let v3922 : string = "std::fs::copy(&*v647, &*v3921)"
                let v3923 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v3922
                let v3924 : string = "$0.unwrap()"
                let v3925 : uint64 = Fable.Core.RustInterop.emitRustExpr v3923 v3924
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
                
#if !FABLE_COMPILER && !WASM && !CONTRACT
                System.IO.File.Copy (v647, v1200, true)
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
                |> fun x -> _v3919 <- Some x
                _v3919.Value
                v3915
            else
                let v3926 : (Result<string, (string * string)> option []) = [||]
                v3926
        else
            let v3928 : (Result<string, (string * string)> option []) = [||]
            v3928
    let v3930 : string = "$0.to_vec()"
    let v3931 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v3929 v3930
    let v3932 : (string * Vec<Result<string, (string * string)> option>) = v272, v3931
    let v3933 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v3932
    v3933
and closure57 () () : string =
    let v0 : string = "documents.run"
    v0
and closure58 (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) () : string =
    let v1 : string = "$0.len()"
    let v2 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"result_len: {v2} / {v3 ()}"
    v4
and method64 (v0 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>) : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> =
    v0
and method24 (v0 : string, v1 : string, v2 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> =
    let v3 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v3
    let v4 : string = "async_walkdir::WalkDir::new(&*$0)"
    let v5 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr v1 v4
    let v6 : string = "async_walkdir::WalkDir::filter($0, |x| $1(x))"
    let v7 : (async_walkdir_DirEntry -> std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>) = closure12()
    let v8 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6
    let v9 : (Result<async_walkdir_DirEntry, std_io_Error> -> string option) = method32()
    let v10 : string = "futures_lite::stream::StreamExt::collect(futures_lite::stream::StreamExt::filter_map(v8, |x| v9(x))).await"
    let v11 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : US0 = US0_1
    let v13 : (unit -> string) = closure21()
    let v14 : (unit -> string) = closure22(v11)
    method3(v12, v13, v14)
    let v15 : string = "rayon::iter::IntoParallelIterator::into_par_iter(v11)"
    let v16 : rayon_vec_IntoIter<string> = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
    let v18 : (string -> Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>) = closure23(v0, v1, v2)
    let v19 : rayon_iter_Map<rayon_vec_IntoIter<string>> = Fable.Core.RustInterop.emitRustExpr struct (v16, v18) v17
    let v20 : string = "rayon::iter::ParallelIterator::collect($0)"
    let v21 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : US0 = US0_1
    let v23 : (unit -> string) = closure57()
    let v24 : (unit -> string) = closure58(v21)
    method3(v22, v23, v24)
    let v25 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Ok v21
    let v26 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = method64(v25)
    let v27 : string = "v26 }}}})"
    Fable.Core.RustInterop.emitRustExpr () v27
    let v28 : string = "{{{ //"
    Fable.Core.RustInterop.emitRustExpr () v28
    let v29 : string = "__result"
    let v30 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v29
    v30
and method12 (v0 : string, v1 : string, v2 : string, v3 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> =
    let v4 : string option = None
    let v5 : bool = true in let mutable _v4 = v4
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = method13(v3)
    let v7 : string = method14(v6)
    let v8 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "String::from($0)"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = "std::path::PathBuf::from($0)"
    let v13 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "$0.exists()"
    let v15 : bool = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : bool = v15 = false
    let v201 : string =
        if v16 then
            let v17 : string option = None
            let v18 : bool = true in let mutable _v17 = v17
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v19 : string = "std::env::current_dir()"
            let v20 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v19
            let v21 : string = "$0.unwrap()"
            let v22 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v20 v21
            let v23 : string = "$0.display()"
            let v24 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v22 v23
            let v25 : std_string_String option = None
            let v26 : bool = true in let mutable _v25 = v25
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v27 : string = @$"format!(""{{}}"", $0)"
            let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v24 v27
            v28
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v29 : string = @$"format!(""{{}}"", $0)"
            let v30 : std_string_String = Fable.Core.RustInterop.emitRustExpr v24 v29
            v30
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v31 : string = @$"format!(""{{}}"", $0)"
            let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v24 v31
            v32
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v33 : std_string_String = null |> unbox<std_string_String>
            v33
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v34 : std_string_String = null |> unbox<std_string_String>
            v34
#endif
            
#if FABLE_COMPILER_PYTHON
            let v35 : std_string_String = null |> unbox<std_string_String>
            v35
#endif
            |> fun x -> _v25 <- Some x
            let v36 : std_string_String = _v25.Value
            let v37 : string = "fable_library_rust::String_::fromString($0)"
            let v38 : string = Fable.Core.RustInterop.emitRustExpr v36 v37
            v38
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v39 : string = null |> unbox<string>
            v39
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v40 : string = null |> unbox<string>
            v40
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v41 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v42 : string = v41 ()
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
            |> fun x -> _v17 <- Some x
            let v45 : string = _v17.Value
            let v46 : string option = None
            let v47 : bool = true in let mutable _v46 = v46
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v48 : string = method14(v45)
            let v49 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v48 v49
            let v51 : string = "String::from($0)"
            let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr v50 v51
            let v53 : string = "std::path::PathBuf::from($0)"
            let v54 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v52 v53
            let v55 : string = method14(v6)
            let v56 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v57 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v55 v56
            let v58 : string = "String::from($0)"
            let v59 : std_string_String = Fable.Core.RustInterop.emitRustExpr v57 v58
            let v60 : string = "$0.join($1)"
            let v61 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v54, v59) v60
            let v62 : string = "$0.display()"
            let v63 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v61 v62
            let v64 : std_string_String option = None
            let v65 : bool = true in let mutable _v64 = v64
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v66 : string = @$"format!(""{{}}"", $0)"
            let v67 : std_string_String = Fable.Core.RustInterop.emitRustExpr v63 v66
            v67
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v68 : string = @$"format!(""{{}}"", $0)"
            let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr v63 v68
            v69
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v70 : string = @$"format!(""{{}}"", $0)"
            let v71 : std_string_String = Fable.Core.RustInterop.emitRustExpr v63 v70
            v71
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v72 : std_string_String = null |> unbox<std_string_String>
            v72
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v73 : std_string_String = null |> unbox<std_string_String>
            v73
#endif
            
#if FABLE_COMPILER_PYTHON
            let v74 : std_string_String = null |> unbox<std_string_String>
            v74
#endif
            |> fun x -> _v64 <- Some x
            let v75 : std_string_String = _v64.Value
            let v76 : string = "fable_library_rust::String_::fromString($0)"
            let v77 : string = Fable.Core.RustInterop.emitRustExpr v75 v76
            v77
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v78 : string = null |> unbox<string>
            v78
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v79 : string = null |> unbox<string>
            v79
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v80 : string = System.IO.Path.Combine (v45, v6)
            v80
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v81 : string = "path"
            let v82 : IPathJoin = Fable.Core.JsInterop.importAll v81
            let v83 : string = method15(v45)
            let v84 : string = method16(v6)
            let v85 : string = "v82.join(v83, v84)"
            let v86 : string = Fable.Core.JsInterop.emitJsExpr () v85
            v86
#endif
            
#if FABLE_COMPILER_PYTHON
            let v87 : string = null |> unbox<string>
            v87
#endif
            |> fun x -> _v46 <- Some x
            let v88 : string = _v46.Value
            let v89 : bool option = None
            let v90 : bool = true in let mutable _v89 = v89
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v91 : string = "cfg!(windows)"
            let v92 : bool = Fable.Core.RustInterop.emitRustExpr () v91
            v92
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v93 : bool = null |> unbox<bool>
            v93
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v94 : bool = null |> unbox<bool>
            v94
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v95 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v96 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v97 : bool = v96 v95
            v97
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v98 : bool = null |> unbox<bool>
            v98
#endif
            
#if FABLE_COMPILER_PYTHON
            let v99 : bool = null |> unbox<bool>
            v99
#endif
            |> fun x -> _v89 <- Some x
            let v100 : bool = _v89.Value
            let v101 : bool = v100 = false
            let v125 : string =
                if v101 then
                    v88
                else
                    let v102 : string option = None
                    let v103 : bool = true in let mutable _v102 = v102
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v104 : string = method17()
                    let v105 : string = method18(v88)
                    let v106 : string = method19()
                    let v107 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v108 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v104, v105, v106) v107
                    let v109 : string = "String::from($0)"
                    let v110 : std_string_String = Fable.Core.RustInterop.emitRustExpr v108 v109
                    let v111 : string = "fable_library_rust::String_::fromString($0)"
                    let v112 : string = Fable.Core.RustInterop.emitRustExpr v110 v111
                    v112
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v113 : string = null |> unbox<string>
                    v113
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v114 : string = null |> unbox<string>
                    v114
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v115 : string = "^\\\\\\\\\\?\\\\"
                    let v116 : string = ""
                    let v117 : string = System.Text.RegularExpressions.Regex.Replace (v88, v115, v116)
                    v117
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v118 : string = null |> unbox<string>
                    v118
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v119 : string = null |> unbox<string>
                    v119
#endif
                    |> fun x -> _v102 <- Some x
                    let v120 : string = _v102.Value
                    let v121 : string = $"{v120.[0] |> string |> _.ToLower()}{v120.[1..]}"
                    let v122 : string = "\\"
                    let v123 : string = "/"
                    let v124 : string = v121.Replace (v122, v123)
                    v124
            let v126 : string = "/"
            let v127 : (string []) = v125.Split v126
            let v128 : (string []) = [||]
            let v129 : int32 = v127.Length
            let v130 : Mut4 = {l0 = 0; l1 = 0; l2 = v128} : Mut4
            while method20(v129, v130) do
                let v132 : int32 = v130.l0
                let v133 : int32 =  -v132
                let v134 : int32 = v133 + v129
                let v135 : int32 = v134 - 1
                let struct (v136 : int32, v137 : (string [])) = v130.l1, v130.l2
                let v138 : string = v127.[int v135]
                let v139 : bool = ".." = v138
                let struct (v159 : int32, v160 : (string [])) =
                    if v139 then
                        let v140 : int32 = v136 + 1
                        struct (v140, v137)
                    else
                        let v141 : bool = 0 = v136
                        if v141 then
                            let v142 : (string []) = [|v138|]
                            let v143 : int32 = v142.Length
                            let v144 : int32 = v137.Length
                            let v145 : int32 = v143 + v144
                            let v146 : (string []) = Array.zeroCreate<string> (v145)
                            let v147 : Mut5 = {l0 = 0} : Mut5
                            while method21(v145, v147) do
                                let v149 : int32 = v147.l0
                                let v150 : bool = v149 < v143
                                let v154 : string =
                                    if v150 then
                                        let v151 : string = v142.[int v149]
                                        v151
                                    else
                                        let v152 : int32 = v149 - v143
                                        let v153 : string = v137.[int v152]
                                        v153
                                v146.[int v149] <- v154
                                let v155 : int32 = v149 + 1
                                v147.l0 <- v155
                                ()
                            struct (0, v146)
                        else
                            let v156 : int32 = v136 - 1
                            struct (v156, v137)
                let v161 : int32 = v132 + 1
                v130.l0 <- v161
                v130.l1 <- v159
                v130.l2 <- v160
                ()
            let struct (v162 : int32, v163 : (string [])) = v130.l1, v130.l2
            let v164 : string seq = seq { for i = 0 to v163.Length - 1 do yield v163.[i] }
            let v165 : char option = None
            let v166 : bool = true in let mutable _v165 = v165
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v167 : string = "std::path::MAIN_SEPARATOR"
            let v168 : char = Fable.Core.RustInterop.emitRustExpr () v167
            v168
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v169 : char = null |> unbox<char>
            v169
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v170 : char = null |> unbox<char>
            v170
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v171 : char = System.IO.Path.DirectorySeparatorChar
            v171
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v172 : char = null |> unbox<char>
            v172
#endif
            
#if FABLE_COMPILER_PYTHON
            let v173 : char = null |> unbox<char>
            v173
#endif
            |> fun x -> _v165 <- Some x
            let v174 : char = _v165.Value
            let v175 : (char -> string) = _.ToString()
            let v176 : string = v175 v174
            let v177 : string = method22(v176)
            let v178 : (string -> (string seq -> string)) = String.concat
            let v179 : (string seq -> string) = v178 v177
            v179 v164
        else
            let v181 : string = "std::fs::canonicalize(&*$0)"
            let v182 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v6 v181
            let v183 : string = "$0.unwrap()"
            let v184 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v182 v183
            let v185 : string = "$0.display()"
            let v186 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v184 v185
            let v187 : std_string_String option = None
            let v188 : bool = true in let mutable _v187 = v187
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v189 : string = @$"format!(""{{}}"", $0)"
            let v190 : std_string_String = Fable.Core.RustInterop.emitRustExpr v186 v189
            v190
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v191 : string = @$"format!(""{{}}"", $0)"
            let v192 : std_string_String = Fable.Core.RustInterop.emitRustExpr v186 v191
            v192
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v193 : string = @$"format!(""{{}}"", $0)"
            let v194 : std_string_String = Fable.Core.RustInterop.emitRustExpr v186 v193
            v194
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v195 : std_string_String = null |> unbox<std_string_String>
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
            |> fun x -> _v187 <- Some x
            let v198 : std_string_String = _v187.Value
            let v199 : string = "fable_library_rust::String_::fromString($0)"
            let v200 : string = Fable.Core.RustInterop.emitRustExpr v198 v199
            v200
    v201
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v202 : string = null |> unbox<string>
    v202
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v203 : string = null |> unbox<string>
    v203
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v204 : string = method23(v3)
    let v205 : (string -> string) = System.IO.Path.GetFullPath
    let v206 : string = v205 v204
    v206
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v207 : string = null |> unbox<string>
    v207
#endif
    
#if FABLE_COMPILER_PYTHON
    let v208 : string = null |> unbox<string>
    v208
#endif
    |> fun x -> _v4 <- Some x
    let v209 : string = _v4.Value
    let v210 : string option = None
    let v211 : bool = true in let mutable _v210 = v210
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v212 : string = method13(v2)
    let v213 : string = method14(v212)
    let v214 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v215 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v213 v214
    let v216 : string = "String::from($0)"
    let v217 : std_string_String = Fable.Core.RustInterop.emitRustExpr v215 v216
    let v218 : string = "std::path::PathBuf::from($0)"
    let v219 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v217 v218
    let v220 : string = "$0.exists()"
    let v221 : bool = Fable.Core.RustInterop.emitRustExpr v219 v220
    let v222 : bool = v221 = false
    let v407 : string =
        if v222 then
            let v223 : string option = None
            let v224 : bool = true in let mutable _v223 = v223
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v225 : string = "std::env::current_dir()"
            let v226 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v225
            let v227 : string = "$0.unwrap()"
            let v228 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v226 v227
            let v229 : string = "$0.display()"
            let v230 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v228 v229
            let v231 : std_string_String option = None
            let v232 : bool = true in let mutable _v231 = v231
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v233 : string = @$"format!(""{{}}"", $0)"
            let v234 : std_string_String = Fable.Core.RustInterop.emitRustExpr v230 v233
            v234
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v235 : string = @$"format!(""{{}}"", $0)"
            let v236 : std_string_String = Fable.Core.RustInterop.emitRustExpr v230 v235
            v236
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v237 : string = @$"format!(""{{}}"", $0)"
            let v238 : std_string_String = Fable.Core.RustInterop.emitRustExpr v230 v237
            v238
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v239 : std_string_String = null |> unbox<std_string_String>
            v239
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v240 : std_string_String = null |> unbox<std_string_String>
            v240
#endif
            
#if FABLE_COMPILER_PYTHON
            let v241 : std_string_String = null |> unbox<std_string_String>
            v241
#endif
            |> fun x -> _v231 <- Some x
            let v242 : std_string_String = _v231.Value
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
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v247 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v248 : string = v247 ()
            v248
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v249 : string = null |> unbox<string>
            v249
#endif
            
#if FABLE_COMPILER_PYTHON
            let v250 : string = null |> unbox<string>
            v250
#endif
            |> fun x -> _v223 <- Some x
            let v251 : string = _v223.Value
            let v252 : string option = None
            let v253 : bool = true in let mutable _v252 = v252
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v254 : string = method14(v251)
            let v255 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v256 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v254 v255
            let v257 : string = "String::from($0)"
            let v258 : std_string_String = Fable.Core.RustInterop.emitRustExpr v256 v257
            let v259 : string = "std::path::PathBuf::from($0)"
            let v260 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v258 v259
            let v261 : string = method14(v212)
            let v262 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v263 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v261 v262
            let v264 : string = "String::from($0)"
            let v265 : std_string_String = Fable.Core.RustInterop.emitRustExpr v263 v264
            let v266 : string = "$0.join($1)"
            let v267 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v260, v265) v266
            let v268 : string = "$0.display()"
            let v269 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v267 v268
            let v270 : std_string_String option = None
            let v271 : bool = true in let mutable _v270 = v270
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v272 : string = @$"format!(""{{}}"", $0)"
            let v273 : std_string_String = Fable.Core.RustInterop.emitRustExpr v269 v272
            v273
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v274 : string = @$"format!(""{{}}"", $0)"
            let v275 : std_string_String = Fable.Core.RustInterop.emitRustExpr v269 v274
            v275
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v276 : string = @$"format!(""{{}}"", $0)"
            let v277 : std_string_String = Fable.Core.RustInterop.emitRustExpr v269 v276
            v277
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v278 : std_string_String = null |> unbox<std_string_String>
            v278
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v279 : std_string_String = null |> unbox<std_string_String>
            v279
#endif
            
#if FABLE_COMPILER_PYTHON
            let v280 : std_string_String = null |> unbox<std_string_String>
            v280
#endif
            |> fun x -> _v270 <- Some x
            let v281 : std_string_String = _v270.Value
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
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v286 : string = System.IO.Path.Combine (v251, v212)
            v286
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v287 : string = "path"
            let v288 : IPathJoin = Fable.Core.JsInterop.importAll v287
            let v289 : string = method15(v251)
            let v290 : string = method16(v212)
            let v291 : string = "v288.join(v289, v290)"
            let v292 : string = Fable.Core.JsInterop.emitJsExpr () v291
            v292
#endif
            
#if FABLE_COMPILER_PYTHON
            let v293 : string = null |> unbox<string>
            v293
#endif
            |> fun x -> _v252 <- Some x
            let v294 : string = _v252.Value
            let v295 : bool option = None
            let v296 : bool = true in let mutable _v295 = v295
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v297 : string = "cfg!(windows)"
            let v298 : bool = Fable.Core.RustInterop.emitRustExpr () v297
            v298
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v299 : bool = null |> unbox<bool>
            v299
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v300 : bool = null |> unbox<bool>
            v300
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v301 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v302 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v303 : bool = v302 v301
            v303
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v304 : bool = null |> unbox<bool>
            v304
#endif
            
#if FABLE_COMPILER_PYTHON
            let v305 : bool = null |> unbox<bool>
            v305
#endif
            |> fun x -> _v295 <- Some x
            let v306 : bool = _v295.Value
            let v307 : bool = v306 = false
            let v331 : string =
                if v307 then
                    v294
                else
                    let v308 : string option = None
                    let v309 : bool = true in let mutable _v308 = v308
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v310 : string = method17()
                    let v311 : string = method18(v294)
                    let v312 : string = method19()
                    let v313 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v314 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v310, v311, v312) v313
                    let v315 : string = "String::from($0)"
                    let v316 : std_string_String = Fable.Core.RustInterop.emitRustExpr v314 v315
                    let v317 : string = "fable_library_rust::String_::fromString($0)"
                    let v318 : string = Fable.Core.RustInterop.emitRustExpr v316 v317
                    v318
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v319 : string = null |> unbox<string>
                    v319
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v320 : string = null |> unbox<string>
                    v320
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v321 : string = "^\\\\\\\\\\?\\\\"
                    let v322 : string = ""
                    let v323 : string = System.Text.RegularExpressions.Regex.Replace (v294, v321, v322)
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
                    |> fun x -> _v308 <- Some x
                    let v326 : string = _v308.Value
                    let v327 : string = $"{v326.[0] |> string |> _.ToLower()}{v326.[1..]}"
                    let v328 : string = "\\"
                    let v329 : string = "/"
                    let v330 : string = v327.Replace (v328, v329)
                    v330
            let v332 : string = "/"
            let v333 : (string []) = v331.Split v332
            let v334 : (string []) = [||]
            let v335 : int32 = v333.Length
            let v336 : Mut4 = {l0 = 0; l1 = 0; l2 = v334} : Mut4
            while method20(v335, v336) do
                let v338 : int32 = v336.l0
                let v339 : int32 =  -v338
                let v340 : int32 = v339 + v335
                let v341 : int32 = v340 - 1
                let struct (v342 : int32, v343 : (string [])) = v336.l1, v336.l2
                let v344 : string = v333.[int v341]
                let v345 : bool = ".." = v344
                let struct (v365 : int32, v366 : (string [])) =
                    if v345 then
                        let v346 : int32 = v342 + 1
                        struct (v346, v343)
                    else
                        let v347 : bool = 0 = v342
                        if v347 then
                            let v348 : (string []) = [|v344|]
                            let v349 : int32 = v348.Length
                            let v350 : int32 = v343.Length
                            let v351 : int32 = v349 + v350
                            let v352 : (string []) = Array.zeroCreate<string> (v351)
                            let v353 : Mut5 = {l0 = 0} : Mut5
                            while method21(v351, v353) do
                                let v355 : int32 = v353.l0
                                let v356 : bool = v355 < v349
                                let v360 : string =
                                    if v356 then
                                        let v357 : string = v348.[int v355]
                                        v357
                                    else
                                        let v358 : int32 = v355 - v349
                                        let v359 : string = v343.[int v358]
                                        v359
                                v352.[int v355] <- v360
                                let v361 : int32 = v355 + 1
                                v353.l0 <- v361
                                ()
                            struct (0, v352)
                        else
                            let v362 : int32 = v342 - 1
                            struct (v362, v343)
                let v367 : int32 = v338 + 1
                v336.l0 <- v367
                v336.l1 <- v365
                v336.l2 <- v366
                ()
            let struct (v368 : int32, v369 : (string [])) = v336.l1, v336.l2
            let v370 : string seq = seq { for i = 0 to v369.Length - 1 do yield v369.[i] }
            let v371 : char option = None
            let v372 : bool = true in let mutable _v371 = v371
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v373 : string = "std::path::MAIN_SEPARATOR"
            let v374 : char = Fable.Core.RustInterop.emitRustExpr () v373
            v374
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v375 : char = null |> unbox<char>
            v375
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v376 : char = null |> unbox<char>
            v376
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v377 : char = System.IO.Path.DirectorySeparatorChar
            v377
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v378 : char = null |> unbox<char>
            v378
#endif
            
#if FABLE_COMPILER_PYTHON
            let v379 : char = null |> unbox<char>
            v379
#endif
            |> fun x -> _v371 <- Some x
            let v380 : char = _v371.Value
            let v381 : (char -> string) = _.ToString()
            let v382 : string = v381 v380
            let v383 : string = method22(v382)
            let v384 : (string -> (string seq -> string)) = String.concat
            let v385 : (string seq -> string) = v384 v383
            v385 v370
        else
            let v387 : string = "std::fs::canonicalize(&*$0)"
            let v388 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v212 v387
            let v389 : string = "$0.unwrap()"
            let v390 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v388 v389
            let v391 : string = "$0.display()"
            let v392 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v390 v391
            let v393 : std_string_String option = None
            let v394 : bool = true in let mutable _v393 = v393
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v395 : string = @$"format!(""{{}}"", $0)"
            let v396 : std_string_String = Fable.Core.RustInterop.emitRustExpr v392 v395
            v396
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v397 : string = @$"format!(""{{}}"", $0)"
            let v398 : std_string_String = Fable.Core.RustInterop.emitRustExpr v392 v397
            v398
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v399 : string = @$"format!(""{{}}"", $0)"
            let v400 : std_string_String = Fable.Core.RustInterop.emitRustExpr v392 v399
            v400
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v401 : std_string_String = null |> unbox<std_string_String>
            v401
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v402 : std_string_String = null |> unbox<std_string_String>
            v402
#endif
            
#if FABLE_COMPILER_PYTHON
            let v403 : std_string_String = null |> unbox<std_string_String>
            v403
#endif
            |> fun x -> _v393 <- Some x
            let v404 : std_string_String = _v393.Value
            let v405 : string = "fable_library_rust::String_::fromString($0)"
            let v406 : string = Fable.Core.RustInterop.emitRustExpr v404 v405
            v406
    v407
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v408 : string = null |> unbox<string>
    v408
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v409 : string = null |> unbox<string>
    v409
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v410 : string = method23(v2)
    let v411 : (string -> string) = System.IO.Path.GetFullPath
    let v412 : string = v411 v410
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
    |> fun x -> _v210 <- Some x
    let v415 : string = _v210.Value
    let v416 : string option = None
    let v417 : bool = true in let mutable _v416 = v416
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v418 : string = method13(v1)
    let v419 : string = method14(v418)
    let v420 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v421 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v419 v420
    let v422 : string = "String::from($0)"
    let v423 : std_string_String = Fable.Core.RustInterop.emitRustExpr v421 v422
    let v424 : string = "std::path::PathBuf::from($0)"
    let v425 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v423 v424
    let v426 : string = "$0.exists()"
    let v427 : bool = Fable.Core.RustInterop.emitRustExpr v425 v426
    let v428 : bool = v427 = false
    let v613 : string =
        if v428 then
            let v429 : string option = None
            let v430 : bool = true in let mutable _v429 = v429
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v431 : string = "std::env::current_dir()"
            let v432 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v431
            let v433 : string = "$0.unwrap()"
            let v434 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v432 v433
            let v435 : string = "$0.display()"
            let v436 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v434 v435
            let v437 : std_string_String option = None
            let v438 : bool = true in let mutable _v437 = v437
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v439 : string = @$"format!(""{{}}"", $0)"
            let v440 : std_string_String = Fable.Core.RustInterop.emitRustExpr v436 v439
            v440
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v441 : string = @$"format!(""{{}}"", $0)"
            let v442 : std_string_String = Fable.Core.RustInterop.emitRustExpr v436 v441
            v442
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v443 : string = @$"format!(""{{}}"", $0)"
            let v444 : std_string_String = Fable.Core.RustInterop.emitRustExpr v436 v443
            v444
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v445 : std_string_String = null |> unbox<std_string_String>
            v445
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v446 : std_string_String = null |> unbox<std_string_String>
            v446
#endif
            
#if FABLE_COMPILER_PYTHON
            let v447 : std_string_String = null |> unbox<std_string_String>
            v447
#endif
            |> fun x -> _v437 <- Some x
            let v448 : std_string_String = _v437.Value
            let v449 : string = "fable_library_rust::String_::fromString($0)"
            let v450 : string = Fable.Core.RustInterop.emitRustExpr v448 v449
            v450
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v451 : string = null |> unbox<string>
            v451
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v452 : string = null |> unbox<string>
            v452
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v453 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v454 : string = v453 ()
            v454
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v455 : string = null |> unbox<string>
            v455
#endif
            
#if FABLE_COMPILER_PYTHON
            let v456 : string = null |> unbox<string>
            v456
#endif
            |> fun x -> _v429 <- Some x
            let v457 : string = _v429.Value
            let v458 : string option = None
            let v459 : bool = true in let mutable _v458 = v458
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v460 : string = method14(v457)
            let v461 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v462 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v460 v461
            let v463 : string = "String::from($0)"
            let v464 : std_string_String = Fable.Core.RustInterop.emitRustExpr v462 v463
            let v465 : string = "std::path::PathBuf::from($0)"
            let v466 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v464 v465
            let v467 : string = method14(v418)
            let v468 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v469 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v467 v468
            let v470 : string = "String::from($0)"
            let v471 : std_string_String = Fable.Core.RustInterop.emitRustExpr v469 v470
            let v472 : string = "$0.join($1)"
            let v473 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v466, v471) v472
            let v474 : string = "$0.display()"
            let v475 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v473 v474
            let v476 : std_string_String option = None
            let v477 : bool = true in let mutable _v476 = v476
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v478 : string = @$"format!(""{{}}"", $0)"
            let v479 : std_string_String = Fable.Core.RustInterop.emitRustExpr v475 v478
            v479
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v480 : string = @$"format!(""{{}}"", $0)"
            let v481 : std_string_String = Fable.Core.RustInterop.emitRustExpr v475 v480
            v481
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v482 : string = @$"format!(""{{}}"", $0)"
            let v483 : std_string_String = Fable.Core.RustInterop.emitRustExpr v475 v482
            v483
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v484 : std_string_String = null |> unbox<std_string_String>
            v484
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v485 : std_string_String = null |> unbox<std_string_String>
            v485
#endif
            
#if FABLE_COMPILER_PYTHON
            let v486 : std_string_String = null |> unbox<std_string_String>
            v486
#endif
            |> fun x -> _v476 <- Some x
            let v487 : std_string_String = _v476.Value
            let v488 : string = "fable_library_rust::String_::fromString($0)"
            let v489 : string = Fable.Core.RustInterop.emitRustExpr v487 v488
            v489
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v490 : string = null |> unbox<string>
            v490
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v491 : string = null |> unbox<string>
            v491
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v492 : string = System.IO.Path.Combine (v457, v418)
            v492
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v493 : string = "path"
            let v494 : IPathJoin = Fable.Core.JsInterop.importAll v493
            let v495 : string = method15(v457)
            let v496 : string = method16(v418)
            let v497 : string = "v494.join(v495, v496)"
            let v498 : string = Fable.Core.JsInterop.emitJsExpr () v497
            v498
#endif
            
#if FABLE_COMPILER_PYTHON
            let v499 : string = null |> unbox<string>
            v499
#endif
            |> fun x -> _v458 <- Some x
            let v500 : string = _v458.Value
            let v501 : bool option = None
            let v502 : bool = true in let mutable _v501 = v501
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v503 : string = "cfg!(windows)"
            let v504 : bool = Fable.Core.RustInterop.emitRustExpr () v503
            v504
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v505 : bool = null |> unbox<bool>
            v505
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v506 : bool = null |> unbox<bool>
            v506
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v507 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v508 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v509 : bool = v508 v507
            v509
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v510 : bool = null |> unbox<bool>
            v510
#endif
            
#if FABLE_COMPILER_PYTHON
            let v511 : bool = null |> unbox<bool>
            v511
#endif
            |> fun x -> _v501 <- Some x
            let v512 : bool = _v501.Value
            let v513 : bool = v512 = false
            let v537 : string =
                if v513 then
                    v500
                else
                    let v514 : string option = None
                    let v515 : bool = true in let mutable _v514 = v514
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v516 : string = method17()
                    let v517 : string = method18(v500)
                    let v518 : string = method19()
                    let v519 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v520 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v516, v517, v518) v519
                    let v521 : string = "String::from($0)"
                    let v522 : std_string_String = Fable.Core.RustInterop.emitRustExpr v520 v521
                    let v523 : string = "fable_library_rust::String_::fromString($0)"
                    let v524 : string = Fable.Core.RustInterop.emitRustExpr v522 v523
                    v524
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v525 : string = null |> unbox<string>
                    v525
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v526 : string = null |> unbox<string>
                    v526
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v527 : string = "^\\\\\\\\\\?\\\\"
                    let v528 : string = ""
                    let v529 : string = System.Text.RegularExpressions.Regex.Replace (v500, v527, v528)
                    v529
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v530 : string = null |> unbox<string>
                    v530
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v531 : string = null |> unbox<string>
                    v531
#endif
                    |> fun x -> _v514 <- Some x
                    let v532 : string = _v514.Value
                    let v533 : string = $"{v532.[0] |> string |> _.ToLower()}{v532.[1..]}"
                    let v534 : string = "\\"
                    let v535 : string = "/"
                    let v536 : string = v533.Replace (v534, v535)
                    v536
            let v538 : string = "/"
            let v539 : (string []) = v537.Split v538
            let v540 : (string []) = [||]
            let v541 : int32 = v539.Length
            let v542 : Mut4 = {l0 = 0; l1 = 0; l2 = v540} : Mut4
            while method20(v541, v542) do
                let v544 : int32 = v542.l0
                let v545 : int32 =  -v544
                let v546 : int32 = v545 + v541
                let v547 : int32 = v546 - 1
                let struct (v548 : int32, v549 : (string [])) = v542.l1, v542.l2
                let v550 : string = v539.[int v547]
                let v551 : bool = ".." = v550
                let struct (v571 : int32, v572 : (string [])) =
                    if v551 then
                        let v552 : int32 = v548 + 1
                        struct (v552, v549)
                    else
                        let v553 : bool = 0 = v548
                        if v553 then
                            let v554 : (string []) = [|v550|]
                            let v555 : int32 = v554.Length
                            let v556 : int32 = v549.Length
                            let v557 : int32 = v555 + v556
                            let v558 : (string []) = Array.zeroCreate<string> (v557)
                            let v559 : Mut5 = {l0 = 0} : Mut5
                            while method21(v557, v559) do
                                let v561 : int32 = v559.l0
                                let v562 : bool = v561 < v555
                                let v566 : string =
                                    if v562 then
                                        let v563 : string = v554.[int v561]
                                        v563
                                    else
                                        let v564 : int32 = v561 - v555
                                        let v565 : string = v549.[int v564]
                                        v565
                                v558.[int v561] <- v566
                                let v567 : int32 = v561 + 1
                                v559.l0 <- v567
                                ()
                            struct (0, v558)
                        else
                            let v568 : int32 = v548 - 1
                            struct (v568, v549)
                let v573 : int32 = v544 + 1
                v542.l0 <- v573
                v542.l1 <- v571
                v542.l2 <- v572
                ()
            let struct (v574 : int32, v575 : (string [])) = v542.l1, v542.l2
            let v576 : string seq = seq { for i = 0 to v575.Length - 1 do yield v575.[i] }
            let v577 : char option = None
            let v578 : bool = true in let mutable _v577 = v577
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v579 : string = "std::path::MAIN_SEPARATOR"
            let v580 : char = Fable.Core.RustInterop.emitRustExpr () v579
            v580
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v581 : char = null |> unbox<char>
            v581
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v582 : char = null |> unbox<char>
            v582
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v583 : char = System.IO.Path.DirectorySeparatorChar
            v583
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v584 : char = null |> unbox<char>
            v584
#endif
            
#if FABLE_COMPILER_PYTHON
            let v585 : char = null |> unbox<char>
            v585
#endif
            |> fun x -> _v577 <- Some x
            let v586 : char = _v577.Value
            let v587 : (char -> string) = _.ToString()
            let v588 : string = v587 v586
            let v589 : string = method22(v588)
            let v590 : (string -> (string seq -> string)) = String.concat
            let v591 : (string seq -> string) = v590 v589
            v591 v576
        else
            let v593 : string = "std::fs::canonicalize(&*$0)"
            let v594 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v418 v593
            let v595 : string = "$0.unwrap()"
            let v596 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v594 v595
            let v597 : string = "$0.display()"
            let v598 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v596 v597
            let v599 : std_string_String option = None
            let v600 : bool = true in let mutable _v599 = v599
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v601 : string = @$"format!(""{{}}"", $0)"
            let v602 : std_string_String = Fable.Core.RustInterop.emitRustExpr v598 v601
            v602
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v603 : string = @$"format!(""{{}}"", $0)"
            let v604 : std_string_String = Fable.Core.RustInterop.emitRustExpr v598 v603
            v604
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v605 : string = @$"format!(""{{}}"", $0)"
            let v606 : std_string_String = Fable.Core.RustInterop.emitRustExpr v598 v605
            v606
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v607 : std_string_String = null |> unbox<std_string_String>
            v607
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v608 : std_string_String = null |> unbox<std_string_String>
            v608
#endif
            
#if FABLE_COMPILER_PYTHON
            let v609 : std_string_String = null |> unbox<std_string_String>
            v609
#endif
            |> fun x -> _v599 <- Some x
            let v610 : std_string_String = _v599.Value
            let v611 : string = "fable_library_rust::String_::fromString($0)"
            let v612 : string = Fable.Core.RustInterop.emitRustExpr v610 v611
            v612
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v616 : string = method23(v1)
    let v617 : (string -> string) = System.IO.Path.GetFullPath
    let v618 : string = v617 v616
    v618
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v619 : string = null |> unbox<string>
    v619
#endif
    
#if FABLE_COMPILER_PYTHON
    let v620 : string = null |> unbox<string>
    v620
#endif
    |> fun x -> _v416 <- Some x
    let v621 : string = _v416.Value
    let v622 : US0 = US0_1
    let v623 : (unit -> string) = closure10()
    let v624 : (unit -> string) = closure11(v0, v209, v415, v621)
    method3(v622, v623, v624)
    method24(v209, v415, v621)
and closure1 () (v0 : (string [])) : int32 =
    let v1 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure2()
    if State.trace_state.IsNone then State.trace_state <- v1 () |> Some
    let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : int64 option, v6 : Mut3) = State.trace_state.Value
    let v7 : US0 = US0_2
    v4.l0 <- v7
    let v8 : string option = None
    let v9 : bool = true in let mutable _v8 = v8
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : string = "std::env::current_dir()"
    let v11 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : string = "$0.unwrap()"
    let v13 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "$0.display()"
    let v15 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : std_string_String option = None
    let v17 : bool = true in let mutable _v16 = v16
    
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v24 : std_string_String = null |> unbox<std_string_String>
    v24
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v25 : std_string_String = null |> unbox<std_string_String>
    v25
#endif
    
#if FABLE_COMPILER_PYTHON
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v32 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v33 : string = v32 ()
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
