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
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Arc<$0>")>]
#endif
type std_sync_Arc<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Mutex<$0>")>]
#endif
type std_sync_Mutex<'T> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
#endif
type std_string_String = class end
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
and method12 (v0 : string) : string =
    v0
and method13 (v0 : string) : string =
    v0
and method14 (v0 : string) : string =
    v0
and method15 (v0 : string) : string =
    v0
and method16 () : string =
    let v0 : string = "^\\\\\\\\\\?\\\\"
    v0
and method17 (v0 : string) : string =
    v0
and method18 () : string =
    let v0 : string = ""
    v0
and method19 (v0 : int32, v1 : Mut4) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method20 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method21 (v0 : string) : string =
    v0
and method22 (v0 : string) : string =
    v0
and closure10 () () : string =
    let v0 : string = "documents.run"
    v0
and closure11 (v0 : string, v1 : string, v2 : string, v3 : string) () : string =
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"source_dir: {v1} / dist_dir: {v2} / cache_dir: {v3} / hangul_spec: %A{v0} / {v4 ()}"
    v5
and method26 (v0 : async_walkdir_DirEntry) : async_walkdir_DirEntry =
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
and method27 () : (std_io_Error -> std_string_String) =
    closure13()
and closure14 () (v0 : std_fs_FileType) : US5 =
    US5_0(v0)
and closure15 () (v0 : std_string_String) : US5 =
    US5_1(v0)
and method28 (v0 : std_fs_FileType) : std_fs_FileType =
    v0
and method29 (v0 : US4) : US4 =
    v0
and method25 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<Send<Dyn<std_future_Future<US4>>>>> =
    let v1 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : async_walkdir_DirEntry = method26(v0)
    let v3 : string = "Box::pin(async_walkdir::DirEntry::file_type(&v2))"
    let v4 : std_pin_Pin<Box<Send<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>>>> = Fable.Core.RustInterop.emitRustExpr () v3
    let v5 : string = "v4.await"
    let v6 : Result<std_fs_FileType, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v5
    let v7 : (std_io_Error -> std_string_String) = method27()
    let v8 : string = "$0.map_err(|x| $1(x))"
    let v9 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6, v7) v8
    let v10 : (std_fs_FileType -> US5) = closure14()
    let v11 : (std_string_String -> US5) = closure15()
    let v12 : US5 = match v9 with Ok x -> v10 x | Error x -> v11 x
    let v73 : US4 =
        match v12 with
        | US5_0(v13) -> (* Ok *)
            let v14 : std_fs_FileType = method28(v13)
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
    let v74 : US4 = method29(v73)
    let v75 : string = "v74 }})"
    Fable.Core.RustInterop.emitRustExpr () v75
    let v76 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v76
    let v77 : string = "__result"
    let v78 : std_pin_Pin<Box<Send<Dyn<std_future_Future<US4>>>>> = Fable.Core.RustInterop.emitRustExpr () v77
    v78
and method30 (v0 : async_walkdir_Filtering) : async_walkdir_Filtering =
    v0
and method24 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>> =
    let v1 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : std_pin_Pin<Box<Send<Dyn<std_future_Future<US4>>>>> = method25(v0)
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
    let v14 : async_walkdir_Filtering = method30(v13)
    let v15 : string = "v14 }})"
    Fable.Core.RustInterop.emitRustExpr () v15
    let v16 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v16
    let v17 : string = "__result"
    let v18 : std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>> = Fable.Core.RustInterop.emitRustExpr () v17
    v18
and closure12 () (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>> =
    method24(v0)
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
    let v1 : (std_io_Error -> std_string_String) = method27()
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
and method31 () : (Result<async_walkdir_DirEntry, std_io_Error> -> string option) =
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
and method32 () : struct (string * string) =
    let v0 : string = ""
    struct (v0, v0)
and closure25 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure24 () (v0 : char) : (UH0 -> UH0) =
    closure25(v0)
and method33 () : (char -> (UH0 -> UH0)) =
    closure24()
and method34 (v0 : string, v1 : string, v2 : UH0, v3 : US8) : struct (string * string) =
    match v2 with
    | UH0_1(v4, v5) -> (* Cons *)
        let v6 : bool = '"' = v4
        if v6 then
            let v8 : bool = v1 = ""
            if v8 then
                let v9 : US9 = US9_0
                let v10 : US8 = US8_1(v9)
                method34(v0, v1, v5, v10)
            else
                match v3 with
                | US8_2 -> (* Arguments *)
                    let v38 : string = $"{v0}{v4}"
                    let v39 : US8 = US8_2
                    method34(v38, v1, v5, v39)
                | US8_1(v13) -> (* Path *)
                    match v13 with
                    | US9_0 -> (* Quoted *)
                        let v14 : US9 = US9_1
                        let v15 : US8 = US8_1(v14)
                        method34(v0, v1, v5, v15)
                    | _ ->
                        let v18 : bool = ' ' = v4
                        if v18 then
                            let v19 : US8 = US8_2
                            method34(v0, v1, v5, v19)
                        else
                            let v22 : string = $"{v1}{v4}"
                            method34(v0, v22, v5, v3)
                | US8_0 -> (* Start *)
                    let v29 : bool = ' ' = v4
                    if v29 then
                        let v30 : US8 = US8_2
                        method34(v0, v1, v5, v30)
                    else
                        let v33 : string = $"{v1}{v4}"
                        method34(v0, v33, v5, v3)
        else
            let v50 : bool = ''' = v4
            if v50 then
                let v52 : bool = v1 = ""
                if v52 then
                    let v53 : US9 = US9_0
                    let v54 : US8 = US8_1(v53)
                    method34(v0, v1, v5, v54)
                else
                    match v3 with
                    | US8_2 -> (* Arguments *)
                        let v82 : string = $"{v0}{v4}"
                        let v83 : US8 = US8_2
                        method34(v82, v1, v5, v83)
                    | US8_1(v57) -> (* Path *)
                        match v57 with
                        | US9_0 -> (* Quoted *)
                            let v58 : US9 = US9_1
                            let v59 : US8 = US8_1(v58)
                            method34(v0, v1, v5, v59)
                        | _ ->
                            let v62 : bool = ' ' = v4
                            if v62 then
                                let v63 : US8 = US8_2
                                method34(v0, v1, v5, v63)
                            else
                                let v66 : string = $"{v1}{v4}"
                                method34(v0, v66, v5, v3)
                    | US8_0 -> (* Start *)
                        let v73 : bool = ' ' = v4
                        if v73 then
                            let v74 : US8 = US8_2
                            method34(v0, v1, v5, v74)
                        else
                            let v77 : string = $"{v1}{v4}"
                            method34(v0, v77, v5, v3)
            else
                match v3 with
                | US8_2 -> (* Arguments *)
                    let v126 : string = $"{v0}{v4}"
                    let v127 : US8 = US8_2
                    method34(v126, v1, v5, v127)
                | US8_1(v94) -> (* Path *)
                    match v94 with
                    | US9_0 -> (* Quoted *)
                        let v95 : bool = ' ' = v4
                        if v95 then
                            let v96 : string = $"{v1} "
                            let v97 : US9 = US9_0
                            let v98 : US8 = US8_1(v97)
                            method34(v0, v96, v5, v98)
                        else
                            let v101 : string = $"{v1}{v4}"
                            method34(v0, v101, v5, v3)
                    | _ ->
                        let v106 : bool = ' ' = v4
                        if v106 then
                            let v107 : US8 = US8_2
                            method34(v0, v1, v5, v107)
                        else
                            let v110 : string = $"{v1}{v4}"
                            method34(v0, v110, v5, v3)
                | US8_0 -> (* Start *)
                    let v117 : bool = ' ' = v4
                    if v117 then
                        let v118 : US8 = US8_2
                        method34(v0, v1, v5, v118)
                    else
                        let v121 : string = $"{v1}{v4}"
                        method34(v0, v121, v5, v3)
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
and method36 () : (string -> US7) =
    closure26()
and method39 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = method39(v3, v1)
        UH1_1(v2, v4)
    | UH1_0 -> (* Nil *)
        v1
and method38 (v0 : string, v1 : UH1, v2 : UH0, v3 : US10) : struct (UH1 * string) =
    match v3 with
    | US10_2(v44) -> (* Escaped *)
        match v2 with
        | UH0_1(v45, v46) -> (* Cons *)
            let v47 : bool = '\\' = v45
            if v47 then
                let v48 : char = '\\'
                let v49 : US10 = US10_1(v48)
                method37(v0, v1, v46, v3, v49)
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
                        method38(v0, v1, v46, v3)
                    else
                        let v57 : string = $"{v0}\""
                        let v58 : US10 = US10_2(v44)
                        method37(v57, v1, v46, v3, v58)
                else
                    let v63 : bool = ' ' = v45
                    if v63 then
                        let v64 : string = $"{v0} "
                        method38(v64, v1, v46, v3)
                    else
                        let v67 : bool = 1uy = v44
                        if v67 then
                            let v68 : bool = v3 <> v3
                            if v68 then
                                let v69 : string = $"{v0}\{v45}"
                                method38(v69, v1, v46, v3)
                            else
                                let v72 : string = $"{v0}{v45}"
                                method38(v72, v1, v46, v3)
                        else
                            let v77 : string = $"{v0}{v45}"
                            method38(v77, v1, v46, v3)
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
                        method39(v1, v92)
                struct (v94, v0)
            else
                let v96 : bool = v0 = ""
                let v100 : UH1 =
                    if v96 then
                        v1
                    else
                        let v97 : UH1 = UH1_0
                        let v98 : UH1 = UH1_1(v0, v97)
                        method39(v1, v98)
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
                        method37(v0, v1, v108, v3, v112)
                    else
                        let v115 : bool = '\\' = v105
                        if v115 then
                            let v116 : US10 = US10_2(0uy)
                            let v117 : bool = v3 <> v116
                            if v117 then
                                let v118 : string = $"{v0}\""
                                let v119 : char = '"'
                                let v120 : US10 = US10_1(v119)
                                method37(v118, v1, v108, v3, v120)
                            else
                                let v123 : US10 = US10_1('\\')
                                let v124 : bool = v3 = v123
                                if v124 then
                                    let v125 : string = $"{v0}\""
                                    let v126 : char = '"'
                                    let v127 : US10 = US10_1(v126)
                                    method37(v125, v1, v108, v3, v127)
                                else
                                    let v130 : US10 = US10_0
                                    method37(v0, v1, v108, v3, v130)
                        else
                            let v137 : bool = '\\' = v107
                            if v137 then
                                let v138 : uint8 = 1uy
                                let v139 : US10 = US10_2(v138)
                                method37(v0, v1, v108, v3, v139)
                            else
                                let v142 : US10 = US10_2(0uy)
                                let v143 : bool = v3 = v142
                                if v143 then
                                    let v144 : string = $"{v0}\""
                                    let v145 : char = '"'
                                    let v146 : US10 = US10_1(v145)
                                    method37(v144, v1, v108, v3, v146)
                                else
                                    let v149 : UH1 = UH1_0
                                    let v150 : UH1 = UH1_1(v0, v149)
                                    let v151 : UH1 = method39(v1, v150)
                                    let v152 : string = ""
                                    let v153 : US10 = US10_0
                                    method37(v152, v151, v108, v3, v153)
                else
                    let v164 : bool = '\\' = v105
                    if v164 then
                        let v165 : bool = '\\' = v107
                        if v165 then
                            let v166 : uint8 = 1uy
                            let v167 : US10 = US10_2(v166)
                            method37(v0, v1, v108, v3, v167)
                        else
                            let v170 : bool = ' ' = v107
                            if v170 then
                                let v171 : string = $"{v0} "
                                method38(v171, v1, v108, v3)
                            else
                                let v174 : string = $"{v0}{v107}"
                                method38(v174, v1, v108, v3)
                    else
                        let v181 : bool = '\\' = v107
                        if v181 then
                            let v182 : uint8 = 1uy
                            let v183 : US10 = US10_2(v182)
                            method37(v0, v1, v108, v3, v183)
                        else
                            let v186 : bool = ' ' = v107
                            if v186 then
                                let v187 : string = $"{v0} "
                                method38(v187, v1, v108, v3)
                            else
                                let v190 : string = $"{v0}{v107}"
                                method38(v190, v1, v108, v3)
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
                            method39(v1, v205)
                    struct (v207, v0)
                else
                    let v209 : bool = v0 = ""
                    let v213 : UH1 =
                        if v209 then
                            v1
                        else
                            let v210 : UH1 = UH1_0
                            let v211 : UH1 = UH1_1(v0, v210)
                            method39(v1, v211)
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
                            method37(v224, v1, v220, v3, v226)
                        else
                            let v229 : US10 = US10_1('\\')
                            let v230 : bool = v3 = v229
                            if v230 then
                                let v231 : string = $"{v0}\""
                                let v232 : char = '"'
                                let v233 : US10 = US10_1(v232)
                                method37(v231, v1, v220, v3, v233)
                            else
                                let v236 : US10 = US10_0
                                method37(v0, v1, v220, v3, v236)
                    else
                        let v243 : bool = '\\' = v219
                        if v243 then
                            let v244 : uint8 = 1uy
                            let v245 : US10 = US10_2(v244)
                            method37(v0, v1, v220, v3, v245)
                        else
                            let v248 : bool = ' ' = v219
                            if v248 then
                                let v249 : string = $"{v0} "
                                method38(v249, v1, v220, v3)
                            else
                                let v252 : string = $"{v0}{v219}"
                                method38(v252, v1, v220, v3)
                | _ ->
                    let v262 : bool = v0 = ""
                    let v266 : UH1 =
                        if v262 then
                            v1
                        else
                            let v263 : UH1 = UH1_0
                            let v264 : UH1 = UH1_1(v0, v263)
                            method39(v1, v264)
                    struct (v266, v0)
            else
                match v2 with
                | UH0_1(v269, v270) -> (* Cons *)
                    let v271 : bool = '\\' = v269
                    if v271 then
                        let v272 : uint8 = 1uy
                        let v273 : US10 = US10_2(v272)
                        method37(v0, v1, v270, v3, v273)
                    else
                        let v276 : bool = '"' = v269
                        if v276 then
                            let v277 : US10 = US10_2(0uy)
                            let v278 : bool = v3 = v277
                            if v278 then
                                let v279 : string = $"{v0}\""
                                let v280 : char = '"'
                                let v281 : US10 = US10_1(v280)
                                method37(v279, v1, v270, v3, v281)
                            else
                                let v284 : UH1 = UH1_0
                                let v285 : UH1 = UH1_1(v0, v284)
                                let v286 : UH1 = method39(v1, v285)
                                let v287 : string = ""
                                let v288 : US10 = US10_0
                                method37(v287, v286, v270, v3, v288)
                        else
                            let v293 : bool = ' ' = v269
                            if v293 then
                                let v294 : string = $"{v0} "
                                method38(v294, v1, v270, v3)
                            else
                                let v297 : string = $"{v0}{v269}"
                                method38(v297, v1, v270, v3)
                | _ ->
                    let v307 : bool = v0 = ""
                    let v311 : UH1 =
                        if v307 then
                            v1
                        else
                            let v308 : UH1 = UH1_0
                            let v309 : UH1 = UH1_1(v0, v308)
                            method39(v1, v309)
                    struct (v311, v0)
    | US10_0 -> (* Start *)
        match v2 with
        | UH0_1(v4, v5) -> (* Cons *)
            let v6 : bool = '"' = v4
            if v6 then
                let v7 : string = ""
                let v8 : char = '"'
                let v9 : US10 = US10_1(v8)
                method37(v7, v1, v5, v3, v9)
            else
                let v12 : bool = '\\' = v4
                if v12 then
                    let v13 : uint8 = 0uy
                    let v14 : US10 = US10_2(v13)
                    method37(v0, v1, v5, v3, v14)
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
                                method39(v1, v21)
                        let v24 : string = ""
                        method38(v24, v23, v5, v3)
                    else
                        let v27 : string = $"{v0}{v4}"
                        method38(v27, v1, v5, v3)
        | _ ->
            let v37 : bool = v0 = ""
            let v41 : UH1 =
                if v37 then
                    v1
                else
                    let v38 : UH1 = UH1_0
                    let v39 : UH1 = UH1_1(v0, v38)
                    method39(v1, v39)
            struct (v41, v0)
and method37 (v0 : string, v1 : UH1, v2 : UH0, v3 : US10, v4 : US10) : struct (UH1 * string) =
    match v4 with
    | US10_2(v45) -> (* Escaped *)
        match v2 with
        | UH0_1(v46, v47) -> (* Cons *)
            let v48 : bool = '\\' = v46
            if v48 then
                let v49 : char = '\\'
                let v50 : US10 = US10_1(v49)
                method37(v0, v1, v47, v4, v50)
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
                        method38(v0, v1, v47, v4)
                    else
                        let v58 : string = $"{v0}\""
                        let v59 : US10 = US10_2(v45)
                        method37(v58, v1, v47, v4, v59)
                else
                    let v64 : bool = ' ' = v46
                    if v64 then
                        let v65 : string = $"{v0} "
                        method38(v65, v1, v47, v4)
                    else
                        let v68 : bool = 1uy = v45
                        if v68 then
                            let v69 : bool = v3 <> v4
                            if v69 then
                                let v70 : string = $"{v0}\{v46}"
                                method37(v70, v1, v47, v4, v3)
                            else
                                let v73 : string = $"{v0}{v46}"
                                method38(v73, v1, v47, v4)
                        else
                            let v78 : string = $"{v0}{v46}"
                            method38(v78, v1, v47, v4)
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
                        method39(v1, v93)
                struct (v95, v0)
            else
                let v97 : bool = v0 = ""
                let v101 : UH1 =
                    if v97 then
                        v1
                    else
                        let v98 : UH1 = UH1_0
                        let v99 : UH1 = UH1_1(v0, v98)
                        method39(v1, v99)
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
                        method37(v0, v1, v109, v4, v113)
                    else
                        let v116 : bool = '\\' = v106
                        if v116 then
                            let v117 : US10 = US10_2(0uy)
                            let v118 : bool = v3 <> v117
                            if v118 then
                                let v119 : string = $"{v0}\""
                                let v120 : char = '"'
                                let v121 : US10 = US10_1(v120)
                                method37(v119, v1, v109, v4, v121)
                            else
                                let v124 : US10 = US10_1('\\')
                                let v125 : bool = v3 = v124
                                if v125 then
                                    let v126 : string = $"{v0}\""
                                    let v127 : char = '"'
                                    let v128 : US10 = US10_1(v127)
                                    method37(v126, v1, v109, v4, v128)
                                else
                                    let v131 : US10 = US10_0
                                    method37(v0, v1, v109, v4, v131)
                        else
                            let v138 : bool = '\\' = v108
                            if v138 then
                                let v139 : uint8 = 1uy
                                let v140 : US10 = US10_2(v139)
                                method37(v0, v1, v109, v4, v140)
                            else
                                let v143 : US10 = US10_2(0uy)
                                let v144 : bool = v3 = v143
                                if v144 then
                                    let v145 : string = $"{v0}\""
                                    let v146 : char = '"'
                                    let v147 : US10 = US10_1(v146)
                                    method37(v145, v1, v109, v4, v147)
                                else
                                    let v150 : UH1 = UH1_0
                                    let v151 : UH1 = UH1_1(v0, v150)
                                    let v152 : UH1 = method39(v1, v151)
                                    let v153 : string = ""
                                    let v154 : US10 = US10_0
                                    method37(v153, v152, v109, v4, v154)
                else
                    let v165 : bool = '\\' = v106
                    if v165 then
                        let v166 : bool = '\\' = v108
                        if v166 then
                            let v167 : uint8 = 1uy
                            let v168 : US10 = US10_2(v167)
                            method37(v0, v1, v109, v4, v168)
                        else
                            let v171 : bool = ' ' = v108
                            if v171 then
                                let v172 : string = $"{v0} "
                                method38(v172, v1, v109, v4)
                            else
                                let v175 : string = $"{v0}{v108}"
                                method38(v175, v1, v109, v4)
                    else
                        let v182 : bool = '\\' = v108
                        if v182 then
                            let v183 : uint8 = 1uy
                            let v184 : US10 = US10_2(v183)
                            method37(v0, v1, v109, v4, v184)
                        else
                            let v187 : bool = ' ' = v108
                            if v187 then
                                let v188 : string = $"{v0} "
                                method38(v188, v1, v109, v4)
                            else
                                let v191 : string = $"{v0}{v108}"
                                method38(v191, v1, v109, v4)
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
                            method39(v1, v206)
                    struct (v208, v0)
                else
                    let v210 : bool = v0 = ""
                    let v214 : UH1 =
                        if v210 then
                            v1
                        else
                            let v211 : UH1 = UH1_0
                            let v212 : UH1 = UH1_1(v0, v211)
                            method39(v1, v212)
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
                            method37(v225, v1, v221, v4, v227)
                        else
                            let v230 : US10 = US10_1('\\')
                            let v231 : bool = v3 = v230
                            if v231 then
                                let v232 : string = $"{v0}\""
                                let v233 : char = '"'
                                let v234 : US10 = US10_1(v233)
                                method37(v232, v1, v221, v4, v234)
                            else
                                let v237 : US10 = US10_0
                                method37(v0, v1, v221, v4, v237)
                    else
                        let v244 : bool = '\\' = v220
                        if v244 then
                            let v245 : uint8 = 1uy
                            let v246 : US10 = US10_2(v245)
                            method37(v0, v1, v221, v4, v246)
                        else
                            let v249 : bool = ' ' = v220
                            if v249 then
                                let v250 : string = $"{v0} "
                                method38(v250, v1, v221, v4)
                            else
                                let v253 : string = $"{v0}{v220}"
                                method38(v253, v1, v221, v4)
                | _ ->
                    let v263 : bool = v0 = ""
                    let v267 : UH1 =
                        if v263 then
                            v1
                        else
                            let v264 : UH1 = UH1_0
                            let v265 : UH1 = UH1_1(v0, v264)
                            method39(v1, v265)
                    struct (v267, v0)
            else
                match v2 with
                | UH0_1(v270, v271) -> (* Cons *)
                    let v272 : bool = '\\' = v270
                    if v272 then
                        let v273 : uint8 = 1uy
                        let v274 : US10 = US10_2(v273)
                        method37(v0, v1, v271, v4, v274)
                    else
                        let v277 : bool = '"' = v270
                        if v277 then
                            let v278 : US10 = US10_2(0uy)
                            let v279 : bool = v3 = v278
                            if v279 then
                                let v280 : string = $"{v0}\""
                                let v281 : char = '"'
                                let v282 : US10 = US10_1(v281)
                                method37(v280, v1, v271, v4, v282)
                            else
                                let v285 : UH1 = UH1_0
                                let v286 : UH1 = UH1_1(v0, v285)
                                let v287 : UH1 = method39(v1, v286)
                                let v288 : string = ""
                                let v289 : US10 = US10_0
                                method37(v288, v287, v271, v4, v289)
                        else
                            let v294 : bool = ' ' = v270
                            if v294 then
                                let v295 : string = $"{v0} "
                                method38(v295, v1, v271, v4)
                            else
                                let v298 : string = $"{v0}{v270}"
                                method38(v298, v1, v271, v4)
                | _ ->
                    let v308 : bool = v0 = ""
                    let v312 : UH1 =
                        if v308 then
                            v1
                        else
                            let v309 : UH1 = UH1_0
                            let v310 : UH1 = UH1_1(v0, v309)
                            method39(v1, v310)
                    struct (v312, v0)
    | US10_0 -> (* Start *)
        match v2 with
        | UH0_1(v5, v6) -> (* Cons *)
            let v7 : bool = '"' = v5
            if v7 then
                let v8 : string = ""
                let v9 : char = '"'
                let v10 : US10 = US10_1(v9)
                method37(v8, v1, v6, v4, v10)
            else
                let v13 : bool = '\\' = v5
                if v13 then
                    let v14 : uint8 = 0uy
                    let v15 : US10 = US10_2(v14)
                    method37(v0, v1, v6, v4, v15)
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
                                method39(v1, v22)
                        let v25 : string = ""
                        method38(v25, v24, v6, v4)
                    else
                        let v28 : string = $"{v0}{v5}"
                        method38(v28, v1, v6, v4)
        | _ ->
            let v38 : bool = v0 = ""
            let v42 : UH1 =
                if v38 then
                    v1
                else
                    let v39 : UH1 = UH1_0
                    let v40 : UH1 = UH1_1(v0, v39)
                    method39(v1, v40)
            struct (v42, v0)
and method40 (v0 : UH1, v1 : string list) : string list =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : string list = method40(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH1_0 -> (* Nil *)
        v1
and method35 (v0 : string) : (string []) =
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
    let v7 : (string -> US7) = method36()
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
    while method20(v13, v15) do
        let v17 : int32 = v15.l0
        let v18 : char = v12.[int v17]
        v14.[int v17] <- v18
        let v19 : int32 = v17 + 1
        v15.l0 <- v19
        ()
    let v20 : ((char []) -> char list) = Array.toList
    let v21 : char list = v20 v14
    let v22 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v23 : (char -> (UH0 -> UH0)) = method33()
    let v24 : (char list -> (UH0 -> UH0)) = v22 v23
    let v25 : (UH0 -> UH0) = v24 v21
    let v26 : UH0 = UH0_0
    let v27 : UH0 = v25 v26
    let v28 : US10 = US10_0
    let v29 : US10 = US10_0
    let struct (v30 : UH1, v31 : string) = method37(v2, v1, v27, v29, v28)
    let v32 : string list = []
    let v33 : string list = method40(v30, v32)
    let v34 : (string list -> (string [])) = List.toArray
    let v35 : (string []) = v34 v33
    v35
and closure27 () (v0 : string) : std_string_String =
    let v1 : string = method13(v0)
    let v2 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    v5
and closure28 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (bool * string * int32) -> Async<unit>) option, v3 : string option, v4 : string, v5 : Vec<std_string_String>) () : string =
    let v6 : string = $"execute_with_options / file_name: {v4} / arguments: %A{v5} / options: %A{struct (v0, v1, v2, v3)}"
    v6
and method41 () : (unit -> string) =
    closure6()
and method43 (v0 : string) : string =
    v0
and method45 (v0 : std_sync_Mutex<std_process_Child option>) : std_sync_Mutex<std_process_Child option> =
    v0
and closure29 () (v0 : std_process_Child) : std_sync_Arc<std_sync_Mutex<std_process_Child option>> =
    let v1 : std_process_Child option = Some v0 
    let v2 : string = "std::sync::Mutex::new($0)"
    let v3 : std_sync_Mutex<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : std_sync_Mutex<std_process_Child option> = method45(v3)
    let v5 : string = "std::sync::Arc::new(v4)"
    let v6 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr () v5
    v6
and method44 () : (std_process_Child -> std_sync_Arc<std_sync_Mutex<std_process_Child option>>) =
    closure29()
and method46 (v0 : Result<std_process_Child, std_io_Error>) : Result<std_process_Child, std_io_Error> =
    v0
and closure30 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : US11 =
    US11_0(v0)
and closure31 () (v0 : std_string_String) : US11 =
    US11_1(v0)
and closure32 (v0 : std_string_String) () : string =
    let v1 : string = $"execute_with_options -1 / error: {v0}"
    v1
and method47 (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : std_sync_Arc<std_sync_Mutex<std_process_Child option>> =
    v0
and method48 (v0 : std_sync_Mutex<std_process_ChildStdout option>) : std_sync_Mutex<std_process_ChildStdout option> =
    v0
and method49 (v0 : std_sync_Mutex<std_process_ChildStderr option>) : std_sync_Mutex<std_process_ChildStderr option> =
    v0
and method50 (v0 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> =
    v0
and method51 (v0 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>) : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> =
    v0
and method52 (v0 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>) : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> =
    v0
and method53 (v0 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>>) : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> =
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
    let v2 : (std_io_Error -> std_string_String) = method27()
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
            let v17 : string = method13(v16)
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
and method54 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) : (Result<std_string_String, std_io_Error> -> unit) =
    closure33(v0)
and method55 (v0 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>>) : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>> =
    v0
and closure39 (v0 : std_string_String) () : string =
    let v1 : string = $"execute_with_options / stdout_line / stdout: {false} / e: {v0}"
    v1
and closure38 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) (v1 : Result<std_string_String, std_io_Error>) : unit =
    let v2 : (std_io_Error -> std_string_String) = method27()
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
            let v17 : string = method13(v16)
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
and method57 (v0 : (int32 * string)) : (int32 * string) =
    v0
and method42 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (bool * string * int32) -> Async<unit>) option, v3 : string option, v4 : string, v5 : Vec<std_string_String>) : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> =
    let v6 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "std::process::Command::new(&*$0)"
    let v8 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v4 v7
    let v9 : string = "true; let mut v8 = v8"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : string = "std::process::Command::args(&mut $0, &*$1)"
    let v12 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr struct (v8, v5) v11
    let v13 : string = "true; let mut v12 = v12"
    let v14 : bool = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = "std::process::Command::stdout(&mut $0, std::process::Stdio::piped())"
    let v16 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v12 v15
    let v17 : string = "true; let mut v16 = v16"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : string = "std::process::Command::stderr(&mut $0, std::process::Stdio::piped())"
    let v20 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v16 v19
    let v21 : (string -> US7) = method36()
    let v22 : US7 = US7_1
    let v23 : US7 = v3 |> Option.map v21 |> Option.defaultValue v22 
    let v29 : Ref<Mut<std_process_Command>> =
        match v23 with
        | US7_1 -> (* None *)
            v20
        | US7_0(v24) -> (* Some *)
            let v25 : string = method43(v24)
            let v26 : string = "std::process::Command::current_dir(v20, &*v25)"
            let v27 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr () v26
            v27
    let v30 : string = "true; let mut v29 = v29"
    let v31 : bool = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : string = "std::process::Command::spawn(&mut $0)"
    let v33 : Result<std_process_Child, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v29 v32
    let v34 : (std_process_Child -> std_sync_Arc<std_sync_Mutex<std_process_Child option>>) = method44()
    let v35 : Result<std_process_Child, std_io_Error> = method46(v33)
    let v36 : string = "v35.map(|x| v34(x))"
    let v37 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : (std_io_Error -> std_string_String) = method27()
    let v39 : string = "$0.map_err(|x| $1(x))"
    let v40 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v37, v38) v39
    let v41 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US11) = closure30()
    let v42 : (std_string_String -> US11) = closure31()
    let v43 : US11 = match v40 with Ok x -> v41 x | Error x -> v42 x
    let struct (v148 : int32, v149 : US3, v150 : US12) =
        match v43 with
        | US11_1(v139) -> (* Error *)
            let v140 : US0 = US0_4
            let v141 : (unit -> string) = closure32(v139)
            let v142 : (unit -> string) = closure6()
            method3(v140, v141, v142)
            let v143 : US3 = US3_0(v139)
            let v144 : US12 = US12_1
            struct (-1, v143, v144)
        | US11_0(v44) -> (* Ok *)
            let v45 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method47(v44)
            let v46 : string = "v45.lock().unwrap().as_mut().unwrap().stdout.take().unwrap()"
            let v47 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr () v46
            let v48 : string = "v45.lock().unwrap().as_mut().unwrap().stderr.take().unwrap()"
            let v49 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr () v48
            let v50 : std_process_ChildStdout option = Some v47 
            let v51 : string = "std::sync::Mutex::new($0)"
            let v52 : std_sync_Mutex<std_process_ChildStdout option> = Fable.Core.RustInterop.emitRustExpr v50 v51
            let v53 : std_sync_Mutex<std_process_ChildStdout option> = method48(v52)
            let v54 : string = "std::sync::Arc::new(v53)"
            let v55 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdout option>> = Fable.Core.RustInterop.emitRustExpr () v54
            let v56 : std_process_ChildStderr option = Some v49 
            let v57 : string = "std::sync::Mutex::new($0)"
            let v58 : std_sync_Mutex<std_process_ChildStderr option> = Fable.Core.RustInterop.emitRustExpr v56 v57
            let v59 : std_sync_Mutex<std_process_ChildStderr option> = method49(v58)
            let v60 : string = "std::sync::Arc::new(v59)"
            let v61 : std_sync_Arc<std_sync_Mutex<std_process_ChildStderr option>> = Fable.Core.RustInterop.emitRustExpr () v60
            let v62 : string = "{ let (sender, receiver) = std::sync::mpsc::channel(); (sender, std::sync::Arc::new(receiver)) }"
            let struct (v63 : std_sync_mpsc_Sender<std_string_String>, v64 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = Fable.Core.RustInterop.emitRustExpr () v62
            let v65 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> = method50(v64)
            let v66 : string = "true; let v65 = v65"
            let v67 : bool = Fable.Core.RustInterop.emitRustExpr v65 v66
            let v68 : string = "std::sync::Mutex::new($0)"
            let v69 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v63 v68
            let v70 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = method51(v69)
            let v71 : string = "std::sync::Arc::new(v70)"
            let v72 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v71
            let v73 : string = "v72.clone()"
            let v74 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v73
            let v75 : string = "v72.clone()"
            let v76 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v75
            let v77 : string = "std::sync::Mutex::new($0)"
            let v78 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v65 v77
            let v79 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = method52(v78)
            let v80 : string = "std::sync::Arc::new(v79)"
            let v81 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v80
            let v82 : string = "std::thread::spawn(move || { //"
            let v83 : std_thread_JoinHandle<unit> = Fable.Core.RustInterop.emitRustExpr () v82
            let v84 : string = "std::io::BufRead::lines(std::io::BufReader::new(v55.lock().unwrap().take().unwrap()))"
            let v85 : std_io_Lines<std_io_BufReader<std_process_ChildStdout>> = Fable.Core.RustInterop.emitRustExpr () v84
            let v86 : string = "std::sync::Mutex::new($0)"
            let v87 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> = Fable.Core.RustInterop.emitRustExpr v85 v86
            let v88 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> = method53(v87)
            let v89 : string = "std::sync::Arc::new(v88)"
            let v90 : std_sync_Arc<std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>>> = Fable.Core.RustInterop.emitRustExpr () v89
            let v91 : (Result<std_string_String, std_io_Error> -> unit) = method54(v74)
            let v92 : string = "true; for line in $0.lock().unwrap().by_ref() { v91(line) }"
            let v93 : bool = Fable.Core.RustInterop.emitRustExpr v90 v92
            let v94 : string = "true; })"
            let v95 : bool = Fable.Core.RustInterop.emitRustExpr () v94
            let v96 : string = "std::thread::spawn(move || { //"
            let v97 : std_thread_JoinHandle<unit> = Fable.Core.RustInterop.emitRustExpr () v96
            let v98 : string = "std::io::BufRead::lines(std::io::BufReader::new(v61.lock().unwrap().take().unwrap()))"
            let v99 : std_io_Lines<std_io_BufReader<std_process_ChildStderr>> = Fable.Core.RustInterop.emitRustExpr () v98
            let v100 : string = "std::sync::Mutex::new($0)"
            let v101 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>> = Fable.Core.RustInterop.emitRustExpr v99 v100
            let v102 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>> = method55(v101)
            let v103 : string = "std::sync::Arc::new(v102)"
            let v104 : std_sync_Arc<std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>>> = Fable.Core.RustInterop.emitRustExpr () v103
            let v105 : (Result<std_string_String, std_io_Error> -> unit) = method56(v72)
            let v106 : string = "true; for line in $0.lock().unwrap().by_ref() { v105(line) }"
            let v107 : bool = Fable.Core.RustInterop.emitRustExpr v104 v106
            let v108 : string = "true; })"
            let v109 : bool = Fable.Core.RustInterop.emitRustExpr () v108
            let v110 : string = "v45.lock().unwrap().take().unwrap().wait_with_output()"
            let v111 : Result<std_process_Output, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v110
            let v112 : (std_io_Error -> std_string_String) = method27()
            let v113 : string = "$0.map_err(|x| $1(x))"
            let v114 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v111, v112) v113
            let v115 : string = "true; v83.join().unwrap()"
            let v116 : bool = Fable.Core.RustInterop.emitRustExpr () v115
            let v117 : string = "true; v97.join().unwrap()"
            let v118 : bool = Fable.Core.RustInterop.emitRustExpr () v117
            let v119 : (std_process_Output -> US14) = closure40()
            let v120 : (std_string_String -> US14) = closure41()
            let v121 : US14 = match v114 with Ok x -> v119 x | Error x -> v120 x
            match v121 with
            | US14_1(v127) -> (* Error *)
                let v128 : US0 = US0_4
                let v129 : (unit -> string) = closure42(v127)
                let v130 : (unit -> string) = closure6()
                method3(v128, v129, v130)
                let v131 : US3 = US3_0(v127)
                let v132 : US12 = US12_1
                struct (-2, v131, v132)
            | US14_0(v122) -> (* Ok *)
                let v123 : string = "$0.status.code().unwrap()"
                let v124 : int32 = Fable.Core.RustInterop.emitRustExpr v122 v123
                let v125 : US3 = US3_1
                let v126 : US12 = US12_0(v81)
                struct (v124, v125, v126)
    let v157 : US3 =
        match v150 with
        | US12_1 -> (* None *)
            US3_1
        | US12_0(v151) -> (* Some *)
            let v152 : string = "$0.lock().unwrap().iter().collect::<Vec<String>>().join(\"\\n\")"
            let v153 : std_string_String = Fable.Core.RustInterop.emitRustExpr v151 v152
            US3_0(v153)
    let v164 : US7 =
        match v157 with
        | US3_1 -> (* None *)
            US7_1
        | US3_0(v158) -> (* Some *)
            let v159 : string = "fable_library_rust::String_::fromString($0)"
            let v160 : string = Fable.Core.RustInterop.emitRustExpr v158 v159
            US7_0(v160)
    let v171 : US7 =
        match v149 with
        | US3_1 -> (* None *)
            US7_1
        | US3_0(v165) -> (* Some *)
            let v166 : string = "fable_library_rust::String_::fromString($0)"
            let v167 : string = Fable.Core.RustInterop.emitRustExpr v165 v166
            US7_0(v167)
    let v175 : string =
        match v171 with
        | US7_1 -> (* None *)
            let v173 : string = ""
            v173
        | US7_0(v172) -> (* Some *)
            v172
    let v178 : string =
        match v164 with
        | US7_1 -> (* None *)
            v175
        | US7_0(v176) -> (* Some *)
            v176
    let v179 : US0 = US0_0
    let v180 : (unit -> string) = closure43(v148, v178)
    let v181 : (unit -> string) = closure6()
    method3(v179, v180, v181)
    let v182 : (int32 * string) = v148, v178
    let v183 : (int32 * string) = method57(v182)
    let v184 : string = "v183 }}})"
    Fable.Core.RustInterop.emitRustExpr () v184
    let v185 : string = "{{ //"
    Fable.Core.RustInterop.emitRustExpr () v185
    let v186 : string = "__result"
    let v187 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = Fable.Core.RustInterop.emitRustExpr () v186
    v187
and closure44 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (bool * string * int32) -> Async<unit>) option, v3 : string option) () : string =
    let v4 : string = $"execute_with_options_async / options: %A{struct (v0, v1, v2, v3)}"
    v4
and closure46 () (v0 : (struct (bool * string * int32) -> Async<unit>)) : US15 =
    US15_0(v0)
and method58 () : ((struct (bool * string * int32) -> Async<unit>) -> US15) =
    closure46()
and closure47 (v0 : string) () : string =
    let v1 : string = $"> {v0}"
    v1
and closure45 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (bool * string * int32) -> Async<unit>) option, v3 : string option, v4 : System.Diagnostics.Process, v5 : System.Collections.Concurrent.ConcurrentStack<string>) (v6 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v7 : Async<unit> option = None
    let v8 : bool = true in let mutable _v7 = v7
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : Async<unit> = null |> unbox<Async<unit>>
    v9
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v10 : Async<unit> = null |> unbox<Async<unit>>
    v10
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v11 : Async<unit> = null |> unbox<Async<unit>>
    v11
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v12 : Async<unit> option = None
    let mutable _v12 = v12
    async {
    let v13 : string = v6.Data
    let v14 : string = null |> unbox<string>
    let v15 : bool = v13 = v14
    let v16 : bool = v15 <> true
    if v16 then
        let v17 : ((struct (bool * string * int32) -> Async<unit>) -> US15) = method58()
        let v18 : US15 = US15_1
        let v19 : US15 = v2 |> Option.map v17 |> Option.defaultValue v18 
        match v19 with
        | US15_1 -> (* None *)
            ()
        | US15_0(v20) -> (* Some *)
            let v21 : int32 = v4.Id
            let v22 : Async<unit> = v20 struct (false, v13, v21)
            do! v22 
            ()
        let v23 : US0 = US0_0
        let v24 : (unit -> string) = closure47(v13)
        let v25 : (unit -> string) = closure6()
        method3(v23, v24, v25)
        let v26 : string = ""
        let v27 : string = $"{v26}{v13}{v26}"
        let v28 : (string -> unit) = v5.Push
        v28 v27
    }
    |> fun x -> _v12 <- Some x
    let v29 : Async<unit> = _v12 |> Option.get
    v29
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v30 : Async<unit> = null |> unbox<Async<unit>>
    v30
#endif
    
#if FABLE_COMPILER_PYTHON
    let v31 : Async<unit> = null |> unbox<Async<unit>>
    v31
#endif
    |> fun x -> _v7 <- Some x
    let v32 : Async<unit> = _v7.Value
    let v33 : unit option = None
    let v34 : bool = true in let mutable _v33 = v33
    
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
    let v35 : (Async<unit> -> unit) = Async.StartImmediate
    v35 v32
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
    |> fun x -> _v33 <- Some x
    _v33.Value
    ()
and closure48 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (bool * string * int32) -> Async<unit>) option, v3 : string option, v4 : System.Diagnostics.Process, v5 : System.Collections.Concurrent.ConcurrentStack<string>) (v6 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v7 : Async<unit> option = None
    let v8 : bool = true in let mutable _v7 = v7
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : Async<unit> = null |> unbox<Async<unit>>
    v9
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v10 : Async<unit> = null |> unbox<Async<unit>>
    v10
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v11 : Async<unit> = null |> unbox<Async<unit>>
    v11
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v12 : Async<unit> option = None
    let mutable _v12 = v12
    async {
    let v13 : string = v6.Data
    let v14 : string = null |> unbox<string>
    let v15 : bool = v13 = v14
    let v16 : bool = v15 <> true
    if v16 then
        let v17 : ((struct (bool * string * int32) -> Async<unit>) -> US15) = method58()
        let v18 : US15 = US15_1
        let v19 : US15 = v2 |> Option.map v17 |> Option.defaultValue v18 
        match v19 with
        | US15_1 -> (* None *)
            ()
        | US15_0(v20) -> (* Some *)
            let v21 : int32 = v4.Id
            let v22 : Async<unit> = v20 struct (true, v13, v21)
            do! v22 
            ()
        let v23 : US0 = US0_0
        let v24 : (unit -> string) = closure47(v13)
        let v25 : (unit -> string) = closure6()
        method3(v23, v24, v25)
        let v26 : string = "["
        let v27 : string = "]"
        let v28 : string = $"{v26}{v13}{v27}"
        let v29 : (string -> unit) = v5.Push
        v29 v28
    }
    |> fun x -> _v12 <- Some x
    let v30 : Async<unit> = _v12 |> Option.get
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
    |> fun x -> _v7 <- Some x
    let v33 : Async<unit> = _v7.Value
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
and closure49 () (v0 : System.Threading.CancellationToken) : US16 =
    US16_0(v0)
and method59 () : (System.Threading.CancellationToken -> US16) =
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
and method60 () : string =
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
and method61 (v0 : string) : string =
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
    let v6 : string = method12(v3)
    let v7 : string = method13(v6)
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
            let v48 : string = method13(v45)
            let v49 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v48 v49
            let v51 : string = "String::from($0)"
            let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr v50 v51
            let v53 : string = "std::path::PathBuf::from($0)"
            let v54 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v52 v53
            let v55 : string = method13(v6)
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
            let v83 : string = method14(v45)
            let v84 : string = method15(v6)
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
                    let v104 : string = method16()
                    let v105 : string = method17(v88)
                    let v106 : string = method18()
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
            while method19(v129, v130) do
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
                            while method20(v145, v147) do
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
                            struct (v136, v146)
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
            let v177 : string = method21(v176)
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
    let v204 : string = method22(v3)
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
    let v210 : string = method13(v209)
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
            let v254 : string = method16()
            let v255 : string = method17(v209)
            let v256 : string = method18()
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
    let v275 : string = method13(v0)
    let v276 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v277 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v275 v276
    let v278 : string = "String::from($0)"
    let v279 : std_string_String = Fable.Core.RustInterop.emitRustExpr v277 v278
    let v280 : string = "std::path::PathBuf::from($0)"
    let v281 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v279 v280
    let v282 : string = method13(v238)
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
    let v310 : string = method14(v0)
    let v311 : string = method15(v238)
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
            let v331 : string = method16()
            let v332 : string = method17(v315)
            let v333 : string = method18()
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
    let v350 : System.Threading.CancellationToken option = None
    let v351 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v352 : string option = None
    let v353 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v349}\""
    let v354 : string option = Some v0 
    let v355 : struct (int32 * string) option = None
    let v356 : bool = true in let mutable _v355 = v355
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v357 : string, v358 : string) = method32()
    let v359 : int32 = v353.Length
    let v360 : (char []) = Array.zeroCreate<char> (v359)
    let v361 : Mut5 = {l0 = 0} : Mut5
    while method20(v359, v361) do
        let v363 : int32 = v361.l0
        let v364 : char = v353.[int v363]
        v360.[int v363] <- v364
        let v365 : int32 = v363 + 1
        v361.l0 <- v365
        ()
    let v366 : ((char []) -> char list) = Array.toList
    let v367 : char list = v366 v360
    let v368 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v369 : (char -> (UH0 -> UH0)) = method33()
    let v370 : (char list -> (UH0 -> UH0)) = v368 v369
    let v371 : (UH0 -> UH0) = v370 v367
    let v372 : UH0 = UH0_0
    let v373 : UH0 = v371 v372
    let v374 : US8 = US8_0
    let struct (v375 : string, v376 : string) = method34(v358, v357, v373, v374)
    let v377 : (string []) = method35(v376)
    let v378 : string = "$0.to_vec()"
    let v379 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v377 v378
    let v380 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v381 : (string -> std_string_String) = closure27()
    let v382 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v379, v381) v380
    let v383 : US0 = US0_1
    let v384 : (unit -> string) = closure28(v350, v353, v351, v354, v375, v382)
    let v385 : (unit -> string) = method41()
    method3(v383, v384, v385)
    let v386 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method42(v350, v353, v351, v354, v375, v382)
    let v387 : string = "futures_lite::future::block_on($0)"
    let v388 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v386 v387
    let (a, b) = v388
    let v389 : int32 = a
    let v390 : string = b
    struct (v389, v390)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v391 : int32, v392 : string) = null |> unbox<struct (int32 * string)>
    struct (v391, v392)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v393 : int32, v394 : string) = null |> unbox<struct (int32 * string)>
    struct (v393, v394)
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v395 : Async<struct (int32 * string)> option = None
    let v396 : bool = true in let mutable _v395 = v395
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v397 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v397
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v398 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v398
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v399 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v399
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v400 : Async<struct (int32 * string)> option = None
    let v401 : bool = true in let mutable _v400 = v400
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v402 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v402
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v403 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v403
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v404 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v404
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v405 : Async<struct (int32 * string)> option = None
    let mutable _v405 = v405
    async {
    let struct (v406 : string, v407 : string) = method32()
    let v408 : (char []) = Array.zeroCreate<char> (v359)
    let v409 : Mut5 = {l0 = 0} : Mut5
    while method20(v359, v409) do
        let v411 : int32 = v409.l0
        let v412 : char = v353.[int v411]
        v408.[int v411] <- v412
        let v413 : int32 = v411 + 1
        v409.l0 <- v413
        ()
    let v414 : ((char []) -> char list) = Array.toList
    let v415 : char list = v414 v408
    let v416 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v417 : (char -> (UH0 -> UH0)) = method33()
    let v418 : (char list -> (UH0 -> UH0)) = v416 v417
    let v419 : (UH0 -> UH0) = v418 v415
    let v420 : UH0 = UH0_0
    let v421 : UH0 = v419 v420
    let v422 : US8 = US8_0
    let struct (v423 : string, v424 : string) = method34(v407, v406, v421, v422)
    let v425 : (string -> US7) = method36()
    let v426 : US7 = US7_1
    let v427 : US7 = v354 |> Option.map v425 |> Option.defaultValue v426 
    let v430 : string =
        match v427 with
        | US7_1 -> (* None *)
            v233
        | US7_0(v428) -> (* Some *)
            v428
    let v431 : US0 = US0_1
    let v432 : (unit -> string) = closure44(v350, v353, v351, v354)
    let v433 : (unit -> string) = method41()
    method3(v431, v432, v433)
    let v434 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v435 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v424, StandardOutputEncoding = v434, WorkingDirectory = v430, FileName = v423, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v436 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v435)
    use v436 = v436 
    let v437 : System.Diagnostics.Process = v436 
    let v438 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v439 : System.Collections.Concurrent.ConcurrentStack<string> = v438 ()
    let v440 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v350, v353, v351, v354, v437, v439)
    v437.OutputDataReceived.Add v440 
    let v441 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v350, v353, v351, v354, v437, v439)
    v437.ErrorDataReceived.Add v441 
    let v442 : (unit -> bool) = v437.Start
    let v443 : bool = v442 ()
    let v444 : bool = v443 = false
    if v444 then
        let v445 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v445
    let v446 : (unit -> unit) = v437.BeginErrorReadLine
    v446 ()
    let v447 : (unit -> unit) = v437.BeginOutputReadLine
    v447 ()
    let v448 : (System.Threading.CancellationToken -> US16) = method59()
    let v449 : US16 = US16_1
    let v450 : US16 = v350 |> Option.map v448 |> Option.defaultValue v449 
    let v454 : System.Threading.CancellationToken =
        match v450 with
        | US16_1 -> (* None *)
            let v452 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v452
        | US16_0(v451) -> (* Some *)
            v451
    let v455 : Async<System.Threading.CancellationToken> option = None
    let v456 : bool = true in let mutable _v455 = v455
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v457 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v457
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v458 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v458
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v459 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v459
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v460 : Async<System.Threading.CancellationToken> option = None
    let v461 : bool = true in let mutable _v460 = v460
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v462 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v462
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v463 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v463
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v464 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v464
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v465 : Async<System.Threading.CancellationToken> option = None
    let mutable _v465 = v465
    async {
    let v466 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v466 = v466 
    let v467 : System.Threading.CancellationToken = v466 
    let v468 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v469 : (System.Threading.CancellationToken []) = [|v467; v468; v454|]
    let v470 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v471 : System.Threading.CancellationTokenSource = v470 v469
    let v472 : System.Threading.CancellationToken = v471.Token
    return v472 
    }
    |> fun x -> _v465 <- Some x
    let v473 : Async<System.Threading.CancellationToken> = _v465 |> Option.get
    v473
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v474 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v474
#endif
    
#if FABLE_COMPILER_PYTHON
    let v475 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v475
#endif
    |> fun x -> _v460 <- Some x
    let v476 : Async<System.Threading.CancellationToken> = _v460.Value
    v476
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v477 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v477
#endif
    
#if FABLE_COMPILER_PYTHON
    let v478 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v478
#endif
    |> fun x -> _v455 <- Some x
    let v479 : Async<System.Threading.CancellationToken> = _v455.Value
    let! v479 = v479 
    let v480 : System.Threading.CancellationToken = v479 
    let v481 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v480.Register
    let v482 : (unit -> unit) = closure50(v437)
    let v483 : System.Threading.CancellationTokenRegistration = v481 v482
    use v483 = v483 
    let v484 : System.Threading.CancellationTokenRegistration = v483 
    let v485 : Async<int32> option = None
    let v486 : bool = true in let mutable _v485 = v485
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v487 : Async<int32> = null |> unbox<Async<int32>>
    v487
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v488 : Async<int32> = null |> unbox<Async<int32>>
    v488
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v489 : Async<int32> = null |> unbox<Async<int32>>
    v489
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v490 : Async<int32> option = None
    let mutable _v490 = v490
    async {
    try
    let v491 : System.Threading.Tasks.Task = v437.WaitForExitAsync v480 
    let v492 : Async<unit> option = None
    let v493 : bool = true in let mutable _v492 = v492
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v494 : Async<unit> = null |> unbox<Async<unit>>
    v494
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v495 : Async<unit> = null |> unbox<Async<unit>>
    v495
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v496 : Async<unit> = null |> unbox<Async<unit>>
    v496
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v497 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v498 : Async<unit> = v497 v491
    v498
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v499 : Async<unit> = null |> unbox<Async<unit>>
    v499
#endif
    
#if FABLE_COMPILER_PYTHON
    let v500 : Async<unit> = null |> unbox<Async<unit>>
    v500
#endif
    |> fun x -> _v492 <- Some x
    let v501 : Async<unit> = _v492.Value
    do! v501 
    let v502 : int32 = v437.ExitCode
    return v502 
    with ex ->
    let v503 : exn = ex
    let v504 : string option = None
    let v505 : bool = true in let mutable _v504 = v504
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v506 : string = $"%A{v503}"
    v506
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v507 : string = $"%A{v503}"
    v507
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v508 : string = $"%A{v503}"
    v508
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v509 : string = $"{v503.GetType ()}: {v503.Message}"
    v509
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v510 : string = $"%A{v503}"
    v510
#endif
    
#if FABLE_COMPILER_PYTHON
    let v511 : string = $"%A{v503}"
    v511
#endif
    |> fun x -> _v504 <- Some x
    let v512 : string = _v504.Value
    let v513 : (string -> unit) = v439.Push
    v513 v512
    let v514 : System.Threading.Tasks.TaskCanceledException = v503 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v515 : US0 = US0_3
    let v516 : (unit -> string) = closure51(v514)
    let v517 : (unit -> string) = method41()
    method3(v515, v516, v517)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v490 <- Some x
    let v518 : Async<int32> = _v490 |> Option.get
    v518
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v519 : Async<int32> = null |> unbox<Async<int32>>
    v519
#endif
    
#if FABLE_COMPILER_PYTHON
    let v520 : Async<int32> = null |> unbox<Async<int32>>
    v520
#endif
    |> fun x -> _v485 <- Some x
    let v521 : Async<int32> = _v485.Value
    let! v521 = v521 
    let v522 : int32 = v521 
    let v523 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v524 : string seq = v523 v439
    let v525 : string = method60()
    let v526 : (string -> (string seq -> string)) = String.concat
    let v527 : (string seq -> string) = v526 v525
    let v528 : string = v527 v524
    let v529 : US0 = US0_1
    let v530 : (unit -> string) = closure52(v522, v528)
    let v531 : (unit -> string) = method41()
    method3(v529, v530, v531)
    return struct (v522, v528) 
    }
    |> fun x -> _v405 <- Some x
    let v532 : Async<struct (int32 * string)> = _v405 |> Option.get
    v532
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v533 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v533
#endif
    
#if FABLE_COMPILER_PYTHON
    let v534 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v534
#endif
    |> fun x -> _v400 <- Some x
    let v535 : Async<struct (int32 * string)> = _v400.Value
    v535
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v536 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v536
#endif
    
#if FABLE_COMPILER_PYTHON
    let v537 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v537
#endif
    |> fun x -> _v395 <- Some x
    let v538 : Async<struct (int32 * string)> = _v395.Value
    let v539 : struct (int32 * string) option = None
    let v540 : bool = true in let mutable _v539 = v539
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v541 : int32, v542 : string) = null |> unbox<struct (int32 * string)>
    struct (v541, v542)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v543 : int32, v544 : string) = null |> unbox<struct (int32 * string)>
    struct (v543, v544)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v545 : int32, v546 : string) = null |> unbox<struct (int32 * string)>
    struct (v545, v546)
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v547 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v548 : int32, v549 : string) = v547 v538
    struct (v548, v549)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v550 : int32, v551 : string) = null |> unbox<struct (int32 * string)>
    struct (v550, v551)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v552 : int32, v553 : string) = null |> unbox<struct (int32 * string)>
    struct (v552, v553)
#endif
    |> fun x -> _v539 <- Some x
    let struct (v554 : int32, v555 : string) = _v539.Value
    struct (v554, v555)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v556 : int32, v557 : string) = null |> unbox<struct (int32 * string)>
    struct (v556, v557)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v558 : int32, v559 : string) = null |> unbox<struct (int32 * string)>
    struct (v558, v559)
#endif
    |> fun x -> _v355 <- Some x
    let struct (v560 : int32, v561 : string) = _v355.Value
    let v562 : string option = None
    let v563 : bool = true in let mutable _v562 = v562
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v564 : string = method13(v1)
    let v565 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v566 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v564 v565
    let v567 : string = "String::from($0)"
    let v568 : std_string_String = Fable.Core.RustInterop.emitRustExpr v566 v567
    let v569 : string = "std::path::PathBuf::from($0)"
    let v570 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v568 v569
    let v571 : string = method13(v238)
    let v572 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v572
    let v574 : string = "String::from($0)"
    let v575 : std_string_String = Fable.Core.RustInterop.emitRustExpr v573 v574
    let v576 : string = "$0.join($1)"
    let v577 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v570, v575) v576
    let v578 : string = "$0.display()"
    let v579 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v577 v578
    let v580 : std_string_String option = None
    let v581 : bool = true in let mutable _v580 = v580
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v582 : string = @$"format!(""{{}}"", $0)"
    let v583 : std_string_String = Fable.Core.RustInterop.emitRustExpr v579 v582
    v583
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v584 : string = @$"format!(""{{}}"", $0)"
    let v585 : std_string_String = Fable.Core.RustInterop.emitRustExpr v579 v584
    v585
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v586 : string = @$"format!(""{{}}"", $0)"
    let v587 : std_string_String = Fable.Core.RustInterop.emitRustExpr v579 v586
    v587
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v588 : std_string_String = null |> unbox<std_string_String>
    v588
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v589 : std_string_String = null |> unbox<std_string_String>
    v589
#endif
    
#if FABLE_COMPILER_PYTHON
    let v590 : std_string_String = null |> unbox<std_string_String>
    v590
#endif
    |> fun x -> _v580 <- Some x
    let v591 : std_string_String = _v580.Value
    let v592 : string = "fable_library_rust::String_::fromString($0)"
    let v593 : string = Fable.Core.RustInterop.emitRustExpr v591 v592
    v593
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v594 : string = null |> unbox<string>
    v594
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v595 : string = null |> unbox<string>
    v595
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v596 : string = System.IO.Path.Combine (v1, v238)
    v596
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v597 : IPathJoin = Fable.Core.JsInterop.importAll v308
    let v598 : string = method14(v1)
    let v599 : string = method15(v238)
    let v600 : string = "v597.join(v598, v599)"
    let v601 : string = Fable.Core.JsInterop.emitJsExpr () v600
    v601
#endif
    
#if FABLE_COMPILER_PYTHON
    let v602 : string = null |> unbox<string>
    v602
#endif
    |> fun x -> _v562 <- Some x
    let v603 : string = _v562.Value
    let v604 : bool option = None
    let v605 : bool = true in let mutable _v604 = v604
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v606 : string = "cfg!(windows)"
    let v607 : bool = Fable.Core.RustInterop.emitRustExpr () v606
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v610 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v611 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v612 : bool = v611 v610
    v612
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v613 : bool = null |> unbox<bool>
    v613
#endif
    
#if FABLE_COMPILER_PYTHON
    let v614 : bool = null |> unbox<bool>
    v614
#endif
    |> fun x -> _v604 <- Some x
    let v615 : bool = _v604.Value
    let v616 : bool = v615 = false
    let v637 : string =
        if v616 then
            v603
        else
            let v617 : string option = None
            let v618 : bool = true in let mutable _v617 = v617
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v619 : string = method16()
            let v620 : string = method17(v603)
            let v621 : string = method18()
            let v622 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v623 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v619, v620, v621) v622
            let v624 : string = "String::from($0)"
            let v625 : std_string_String = Fable.Core.RustInterop.emitRustExpr v623 v624
            let v626 : string = "fable_library_rust::String_::fromString($0)"
            let v627 : string = Fable.Core.RustInterop.emitRustExpr v625 v626
            v627
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v628 : string = null |> unbox<string>
            v628
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v629 : string = null |> unbox<string>
            v629
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v630 : string = "^\\\\\\\\\\?\\\\"
            let v631 : string = System.Text.RegularExpressions.Regex.Replace (v603, v630, v233)
            v631
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v632 : string = null |> unbox<string>
            v632
#endif
            
#if FABLE_COMPILER_PYTHON
            let v633 : string = null |> unbox<string>
            v633
#endif
            |> fun x -> _v617 <- Some x
            let v634 : string = _v617.Value
            let v635 : string = $"{v634.[0] |> string |> _.ToLower()}{v634.[1..]}"
            let v636 : string = v635.Replace (v235, v236)
            v636
    let v638 : System.Threading.CancellationToken option = None
    let v639 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v640 : string option = None
    let v641 : string = $"git hash-object \"{v637}\""
    let v642 : string option = Some v1 
    let v643 : struct (int32 * string) option = None
    let v644 : bool = true in let mutable _v643 = v643
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v645 : string, v646 : string) = method32()
    let v647 : int32 = v641.Length
    let v648 : (char []) = Array.zeroCreate<char> (v647)
    let v649 : Mut5 = {l0 = 0} : Mut5
    while method20(v647, v649) do
        let v651 : int32 = v649.l0
        let v652 : char = v641.[int v651]
        v648.[int v651] <- v652
        let v653 : int32 = v651 + 1
        v649.l0 <- v653
        ()
    let v654 : ((char []) -> char list) = Array.toList
    let v655 : char list = v654 v648
    let v656 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v657 : (char -> (UH0 -> UH0)) = method33()
    let v658 : (char list -> (UH0 -> UH0)) = v656 v657
    let v659 : (UH0 -> UH0) = v658 v655
    let v660 : UH0 = UH0_0
    let v661 : UH0 = v659 v660
    let v662 : US8 = US8_0
    let struct (v663 : string, v664 : string) = method34(v646, v645, v661, v662)
    let v665 : (string []) = method35(v664)
    let v666 : string = "$0.to_vec()"
    let v667 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v665 v666
    let v668 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v669 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v667, v381) v668
    let v670 : US0 = US0_1
    let v671 : (unit -> string) = closure28(v638, v641, v639, v642, v663, v669)
    let v672 : (unit -> string) = method41()
    method3(v670, v671, v672)
    let v673 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method42(v638, v641, v639, v642, v663, v669)
    let v674 : string = "futures_lite::future::block_on($0)"
    let v675 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v673 v674
    let (a, b) = v675
    let v676 : int32 = a
    let v677 : string = b
    struct (v676, v677)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v678 : int32, v679 : string) = null |> unbox<struct (int32 * string)>
    struct (v678, v679)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v680 : int32, v681 : string) = null |> unbox<struct (int32 * string)>
    struct (v680, v681)
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v682 : Async<struct (int32 * string)> option = None
    let v683 : bool = true in let mutable _v682 = v682
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v684 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v684
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v685 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v685
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v686 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v686
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v687 : Async<struct (int32 * string)> option = None
    let v688 : bool = true in let mutable _v687 = v687
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v689 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v689
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v690 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v690
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v691 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v691
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v692 : Async<struct (int32 * string)> option = None
    let mutable _v692 = v692
    async {
    let struct (v693 : string, v694 : string) = method32()
    let v695 : (char []) = Array.zeroCreate<char> (v647)
    let v696 : Mut5 = {l0 = 0} : Mut5
    while method20(v647, v696) do
        let v698 : int32 = v696.l0
        let v699 : char = v641.[int v698]
        v695.[int v698] <- v699
        let v700 : int32 = v698 + 1
        v696.l0 <- v700
        ()
    let v701 : ((char []) -> char list) = Array.toList
    let v702 : char list = v701 v695
    let v703 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v704 : (char -> (UH0 -> UH0)) = method33()
    let v705 : (char list -> (UH0 -> UH0)) = v703 v704
    let v706 : (UH0 -> UH0) = v705 v702
    let v707 : UH0 = UH0_0
    let v708 : UH0 = v706 v707
    let v709 : US8 = US8_0
    let struct (v710 : string, v711 : string) = method34(v694, v693, v708, v709)
    let v712 : (string -> US7) = method36()
    let v713 : US7 = US7_1
    let v714 : US7 = v642 |> Option.map v712 |> Option.defaultValue v713 
    let v717 : string =
        match v714 with
        | US7_1 -> (* None *)
            v233
        | US7_0(v715) -> (* Some *)
            v715
    let v718 : US0 = US0_1
    let v719 : (unit -> string) = closure44(v638, v641, v639, v642)
    let v720 : (unit -> string) = method41()
    method3(v718, v719, v720)
    let v721 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v722 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v711, StandardOutputEncoding = v721, WorkingDirectory = v717, FileName = v710, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v723 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v722)
    use v723 = v723 
    let v724 : System.Diagnostics.Process = v723 
    let v725 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v726 : System.Collections.Concurrent.ConcurrentStack<string> = v725 ()
    let v727 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v638, v641, v639, v642, v724, v726)
    v724.OutputDataReceived.Add v727 
    let v728 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v638, v641, v639, v642, v724, v726)
    v724.ErrorDataReceived.Add v728 
    let v729 : (unit -> bool) = v724.Start
    let v730 : bool = v729 ()
    let v731 : bool = v730 = false
    if v731 then
        let v732 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v732
    let v733 : (unit -> unit) = v724.BeginErrorReadLine
    v733 ()
    let v734 : (unit -> unit) = v724.BeginOutputReadLine
    v734 ()
    let v735 : (System.Threading.CancellationToken -> US16) = method59()
    let v736 : US16 = US16_1
    let v737 : US16 = v638 |> Option.map v735 |> Option.defaultValue v736 
    let v741 : System.Threading.CancellationToken =
        match v737 with
        | US16_1 -> (* None *)
            let v739 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v739
        | US16_0(v738) -> (* Some *)
            v738
    let v742 : Async<System.Threading.CancellationToken> option = None
    let v743 : bool = true in let mutable _v742 = v742
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v744 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v744
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v745 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v745
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v746 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v746
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v747 : Async<System.Threading.CancellationToken> option = None
    let v748 : bool = true in let mutable _v747 = v747
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v749 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v749
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v750 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v750
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v751 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v751
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v752 : Async<System.Threading.CancellationToken> option = None
    let mutable _v752 = v752
    async {
    let v753 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v753 = v753 
    let v754 : System.Threading.CancellationToken = v753 
    let v755 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v756 : (System.Threading.CancellationToken []) = [|v754; v755; v741|]
    let v757 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v758 : System.Threading.CancellationTokenSource = v757 v756
    let v759 : System.Threading.CancellationToken = v758.Token
    return v759 
    }
    |> fun x -> _v752 <- Some x
    let v760 : Async<System.Threading.CancellationToken> = _v752 |> Option.get
    v760
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v761 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v761
#endif
    
#if FABLE_COMPILER_PYTHON
    let v762 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v762
#endif
    |> fun x -> _v747 <- Some x
    let v763 : Async<System.Threading.CancellationToken> = _v747.Value
    v763
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v764 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v764
#endif
    
#if FABLE_COMPILER_PYTHON
    let v765 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v765
#endif
    |> fun x -> _v742 <- Some x
    let v766 : Async<System.Threading.CancellationToken> = _v742.Value
    let! v766 = v766 
    let v767 : System.Threading.CancellationToken = v766 
    let v768 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v767.Register
    let v769 : (unit -> unit) = closure50(v724)
    let v770 : System.Threading.CancellationTokenRegistration = v768 v769
    use v770 = v770 
    let v771 : System.Threading.CancellationTokenRegistration = v770 
    let v772 : Async<int32> option = None
    let v773 : bool = true in let mutable _v772 = v772
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v774 : Async<int32> = null |> unbox<Async<int32>>
    v774
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v775 : Async<int32> = null |> unbox<Async<int32>>
    v775
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v776 : Async<int32> = null |> unbox<Async<int32>>
    v776
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v777 : Async<int32> option = None
    let mutable _v777 = v777
    async {
    try
    let v778 : System.Threading.Tasks.Task = v724.WaitForExitAsync v767 
    let v779 : Async<unit> option = None
    let v780 : bool = true in let mutable _v779 = v779
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v781 : Async<unit> = null |> unbox<Async<unit>>
    v781
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v782 : Async<unit> = null |> unbox<Async<unit>>
    v782
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v783 : Async<unit> = null |> unbox<Async<unit>>
    v783
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v784 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v785 : Async<unit> = v784 v778
    v785
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v786 : Async<unit> = null |> unbox<Async<unit>>
    v786
#endif
    
#if FABLE_COMPILER_PYTHON
    let v787 : Async<unit> = null |> unbox<Async<unit>>
    v787
#endif
    |> fun x -> _v779 <- Some x
    let v788 : Async<unit> = _v779.Value
    do! v788 
    let v789 : int32 = v724.ExitCode
    return v789 
    with ex ->
    let v790 : exn = ex
    let v791 : string option = None
    let v792 : bool = true in let mutable _v791 = v791
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v793 : string = $"%A{v790}"
    v793
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v794 : string = $"%A{v790}"
    v794
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v795 : string = $"%A{v790}"
    v795
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v796 : string = $"{v790.GetType ()}: {v790.Message}"
    v796
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v797 : string = $"%A{v790}"
    v797
#endif
    
#if FABLE_COMPILER_PYTHON
    let v798 : string = $"%A{v790}"
    v798
#endif
    |> fun x -> _v791 <- Some x
    let v799 : string = _v791.Value
    let v800 : (string -> unit) = v726.Push
    v800 v799
    let v801 : System.Threading.Tasks.TaskCanceledException = v790 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v802 : US0 = US0_3
    let v803 : (unit -> string) = closure51(v801)
    let v804 : (unit -> string) = method41()
    method3(v802, v803, v804)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v777 <- Some x
    let v805 : Async<int32> = _v777 |> Option.get
    v805
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v806 : Async<int32> = null |> unbox<Async<int32>>
    v806
#endif
    
#if FABLE_COMPILER_PYTHON
    let v807 : Async<int32> = null |> unbox<Async<int32>>
    v807
#endif
    |> fun x -> _v772 <- Some x
    let v808 : Async<int32> = _v772.Value
    let! v808 = v808 
    let v809 : int32 = v808 
    let v810 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v811 : string seq = v810 v726
    let v812 : string = method60()
    let v813 : (string -> (string seq -> string)) = String.concat
    let v814 : (string seq -> string) = v813 v812
    let v815 : string = v814 v811
    let v816 : US0 = US0_1
    let v817 : (unit -> string) = closure52(v809, v815)
    let v818 : (unit -> string) = method41()
    method3(v816, v817, v818)
    return struct (v809, v815) 
    }
    |> fun x -> _v692 <- Some x
    let v819 : Async<struct (int32 * string)> = _v692 |> Option.get
    v819
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v820 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v820
#endif
    
#if FABLE_COMPILER_PYTHON
    let v821 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v821
#endif
    |> fun x -> _v687 <- Some x
    let v822 : Async<struct (int32 * string)> = _v687.Value
    v822
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v823 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v823
#endif
    
#if FABLE_COMPILER_PYTHON
    let v824 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v824
#endif
    |> fun x -> _v682 <- Some x
    let v825 : Async<struct (int32 * string)> = _v682.Value
    let v826 : struct (int32 * string) option = None
    let v827 : bool = true in let mutable _v826 = v826
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v828 : int32, v829 : string) = null |> unbox<struct (int32 * string)>
    struct (v828, v829)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v830 : int32, v831 : string) = null |> unbox<struct (int32 * string)>
    struct (v830, v831)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v832 : int32, v833 : string) = null |> unbox<struct (int32 * string)>
    struct (v832, v833)
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v834 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v835 : int32, v836 : string) = v834 v825
    struct (v835, v836)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v837 : int32, v838 : string) = null |> unbox<struct (int32 * string)>
    struct (v837, v838)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v839 : int32, v840 : string) = null |> unbox<struct (int32 * string)>
    struct (v839, v840)
#endif
    |> fun x -> _v826 <- Some x
    let struct (v841 : int32, v842 : string) = _v826.Value
    struct (v841, v842)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v843 : int32, v844 : string) = null |> unbox<struct (int32 * string)>
    struct (v843, v844)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v845 : int32, v846 : string) = null |> unbox<struct (int32 * string)>
    struct (v845, v846)
#endif
    |> fun x -> _v643 <- Some x
    let struct (v847 : int32, v848 : string) = _v643.Value
    let v849 : bool = v561.Contains v848
    let v850 : bool = v849 = false
    let v3799 : (Result<string, (string * string)> option []) =
        if v850 then
            let v851 : bool option = None
            let v852 : bool = true in let mutable _v851 = v851
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v853 : string = "cfg!(windows)"
            let v854 : bool = Fable.Core.RustInterop.emitRustExpr () v853
            v854
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v855 : bool = null |> unbox<bool>
            v855
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v856 : bool = null |> unbox<bool>
            v856
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v857 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v858 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v859 : bool = v858 v857
            v859
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v860 : bool = null |> unbox<bool>
            v860
#endif
            
#if FABLE_COMPILER_PYTHON
            let v861 : bool = null |> unbox<bool>
            v861
#endif
            |> fun x -> _v851 <- Some x
            let v862 : bool = _v851.Value
            let v863 : bool = v862 = false
            let v884 : string =
                if v863 then
                    v637
                else
                    let v864 : string option = None
                    let v865 : bool = true in let mutable _v864 = v864
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v866 : string = method16()
                    let v867 : string = method17(v637)
                    let v868 : string = method18()
                    let v869 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v870 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v866, v867, v868) v869
                    let v871 : string = "String::from($0)"
                    let v872 : std_string_String = Fable.Core.RustInterop.emitRustExpr v870 v871
                    let v873 : string = "fable_library_rust::String_::fromString($0)"
                    let v874 : string = Fable.Core.RustInterop.emitRustExpr v872 v873
                    v874
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v875 : string = null |> unbox<string>
                    v875
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v876 : string = null |> unbox<string>
                    v876
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v877 : string = "^\\\\\\\\\\?\\\\"
                    let v878 : string = System.Text.RegularExpressions.Regex.Replace (v637, v877, v233)
                    v878
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v879 : string = null |> unbox<string>
                    v879
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v880 : string = null |> unbox<string>
                    v880
#endif
                    |> fun x -> _v864 <- Some x
                    let v881 : string = _v864.Value
                    let v882 : string = $"{v881.[0] |> string |> _.ToLower()}{v881.[1..]}"
                    let v883 : string = v882.Replace (v235, v236)
                    v883
            let v885 : System.Threading.CancellationToken option = None
            let v886 : (struct (bool * string * int32) -> Async<unit>) option = None
            let v887 : string option = None
            let v888 : string = $"pwsh -c \"(Get-FileHash \\\"{v884}\\\" -Algorithm SHA256).Hash\""
            let v889 : struct (int32 * string) option = None
            let v890 : bool = true in let mutable _v889 = v889
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v891 : string, v892 : string) = method32()
            let v893 : int32 = v888.Length
            let v894 : (char []) = Array.zeroCreate<char> (v893)
            let v895 : Mut5 = {l0 = 0} : Mut5
            while method20(v893, v895) do
                let v897 : int32 = v895.l0
                let v898 : char = v888.[int v897]
                v894.[int v897] <- v898
                let v899 : int32 = v897 + 1
                v895.l0 <- v899
                ()
            let v900 : ((char []) -> char list) = Array.toList
            let v901 : char list = v900 v894
            let v902 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v903 : (char -> (UH0 -> UH0)) = method33()
            let v904 : (char list -> (UH0 -> UH0)) = v902 v903
            let v905 : (UH0 -> UH0) = v904 v901
            let v906 : UH0 = UH0_0
            let v907 : UH0 = v905 v906
            let v908 : US8 = US8_0
            let struct (v909 : string, v910 : string) = method34(v892, v891, v907, v908)
            let v911 : (string []) = method35(v910)
            let v912 : string = "$0.to_vec()"
            let v913 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v911 v912
            let v914 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v915 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v913, v381) v914
            let v916 : US0 = US0_1
            let v917 : (unit -> string) = closure28(v885, v888, v886, v887, v909, v915)
            let v918 : (unit -> string) = method41()
            method3(v916, v917, v918)
            let v919 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method42(v885, v888, v886, v887, v909, v915)
            let v920 : string = "futures_lite::future::block_on($0)"
            let v921 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v919 v920
            let (a, b) = v921
            let v922 : int32 = a
            let v923 : string = b
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
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v928 : Async<struct (int32 * string)> option = None
            let v929 : bool = true in let mutable _v928 = v928
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v930 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v930
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v931 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v931
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v932 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v932
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v933 : Async<struct (int32 * string)> option = None
            let v934 : bool = true in let mutable _v933 = v933
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v935 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v935
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v936 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v936
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v937 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v937
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v938 : Async<struct (int32 * string)> option = None
            let mutable _v938 = v938
            async {
            let struct (v939 : string, v940 : string) = method32()
            let v941 : (char []) = Array.zeroCreate<char> (v893)
            let v942 : Mut5 = {l0 = 0} : Mut5
            while method20(v893, v942) do
                let v944 : int32 = v942.l0
                let v945 : char = v888.[int v944]
                v941.[int v944] <- v945
                let v946 : int32 = v944 + 1
                v942.l0 <- v946
                ()
            let v947 : ((char []) -> char list) = Array.toList
            let v948 : char list = v947 v941
            let v949 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v950 : (char -> (UH0 -> UH0)) = method33()
            let v951 : (char list -> (UH0 -> UH0)) = v949 v950
            let v952 : (UH0 -> UH0) = v951 v948
            let v953 : UH0 = UH0_0
            let v954 : UH0 = v952 v953
            let v955 : US8 = US8_0
            let struct (v956 : string, v957 : string) = method34(v940, v939, v954, v955)
            let v958 : (string -> US7) = method36()
            let v959 : US7 = US7_1
            let v960 : US7 = v887 |> Option.map v958 |> Option.defaultValue v959 
            let v963 : string =
                match v960 with
                | US7_1 -> (* None *)
                    v233
                | US7_0(v961) -> (* Some *)
                    v961
            let v964 : US0 = US0_1
            let v965 : (unit -> string) = closure44(v885, v888, v886, v887)
            let v966 : (unit -> string) = method41()
            method3(v964, v965, v966)
            let v967 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v968 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v957, StandardOutputEncoding = v967, WorkingDirectory = v963, FileName = v956, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v969 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v968)
            use v969 = v969 
            let v970 : System.Diagnostics.Process = v969 
            let v971 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v972 : System.Collections.Concurrent.ConcurrentStack<string> = v971 ()
            let v973 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v885, v888, v886, v887, v970, v972)
            v970.OutputDataReceived.Add v973 
            let v974 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v885, v888, v886, v887, v970, v972)
            v970.ErrorDataReceived.Add v974 
            let v975 : (unit -> bool) = v970.Start
            let v976 : bool = v975 ()
            let v977 : bool = v976 = false
            if v977 then
                let v978 : string = $"execute_with_options_async / process_start error"
                failwith<unit> v978
            let v979 : (unit -> unit) = v970.BeginErrorReadLine
            v979 ()
            let v980 : (unit -> unit) = v970.BeginOutputReadLine
            v980 ()
            let v981 : (System.Threading.CancellationToken -> US16) = method59()
            let v982 : US16 = US16_1
            let v983 : US16 = v885 |> Option.map v981 |> Option.defaultValue v982 
            let v987 : System.Threading.CancellationToken =
                match v983 with
                | US16_1 -> (* None *)
                    let v985 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v985
                | US16_0(v984) -> (* Some *)
                    v984
            let v988 : Async<System.Threading.CancellationToken> option = None
            let v989 : bool = true in let mutable _v988 = v988
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v990 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v990
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v991 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v991
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v992 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v992
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v993 : Async<System.Threading.CancellationToken> option = None
            let v994 : bool = true in let mutable _v993 = v993
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v995 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v995
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v996 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v996
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v997 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v997
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v998 : Async<System.Threading.CancellationToken> option = None
            let mutable _v998 = v998
            async {
            let v999 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v999 = v999 
            let v1000 : System.Threading.CancellationToken = v999 
            let v1001 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v1002 : (System.Threading.CancellationToken []) = [|v1000; v1001; v987|]
            let v1003 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v1004 : System.Threading.CancellationTokenSource = v1003 v1002
            let v1005 : System.Threading.CancellationToken = v1004.Token
            return v1005 
            }
            |> fun x -> _v998 <- Some x
            let v1006 : Async<System.Threading.CancellationToken> = _v998 |> Option.get
            v1006
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1007 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1007
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1008 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1008
#endif
            |> fun x -> _v993 <- Some x
            let v1009 : Async<System.Threading.CancellationToken> = _v993.Value
            v1009
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1010 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1010
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1011 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v1011
#endif
            |> fun x -> _v988 <- Some x
            let v1012 : Async<System.Threading.CancellationToken> = _v988.Value
            let! v1012 = v1012 
            let v1013 : System.Threading.CancellationToken = v1012 
            let v1014 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1013.Register
            let v1015 : (unit -> unit) = closure50(v970)
            let v1016 : System.Threading.CancellationTokenRegistration = v1014 v1015
            use v1016 = v1016 
            let v1017 : System.Threading.CancellationTokenRegistration = v1016 
            let v1018 : Async<int32> option = None
            let v1019 : bool = true in let mutable _v1018 = v1018
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1020 : Async<int32> = null |> unbox<Async<int32>>
            v1020
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1021 : Async<int32> = null |> unbox<Async<int32>>
            v1021
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1022 : Async<int32> = null |> unbox<Async<int32>>
            v1022
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v1023 : Async<int32> option = None
            let mutable _v1023 = v1023
            async {
            try
            let v1024 : System.Threading.Tasks.Task = v970.WaitForExitAsync v1013 
            let v1025 : Async<unit> option = None
            let v1026 : bool = true in let mutable _v1025 = v1025
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1027 : Async<unit> = null |> unbox<Async<unit>>
            v1027
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1028 : Async<unit> = null |> unbox<Async<unit>>
            v1028
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1029 : Async<unit> = null |> unbox<Async<unit>>
            v1029
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v1030 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v1031 : Async<unit> = v1030 v1024
            v1031
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1032 : Async<unit> = null |> unbox<Async<unit>>
            v1032
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1033 : Async<unit> = null |> unbox<Async<unit>>
            v1033
#endif
            |> fun x -> _v1025 <- Some x
            let v1034 : Async<unit> = _v1025.Value
            do! v1034 
            let v1035 : int32 = v970.ExitCode
            return v1035 
            with ex ->
            let v1036 : exn = ex
            let v1037 : string option = None
            let v1038 : bool = true in let mutable _v1037 = v1037
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1039 : string = $"%A{v1036}"
            v1039
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1040 : string = $"%A{v1036}"
            v1040
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1041 : string = $"%A{v1036}"
            v1041
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v1042 : string = $"{v1036.GetType ()}: {v1036.Message}"
            v1042
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1043 : string = $"%A{v1036}"
            v1043
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1044 : string = $"%A{v1036}"
            v1044
#endif
            |> fun x -> _v1037 <- Some x
            let v1045 : string = _v1037.Value
            let v1046 : (string -> unit) = v972.Push
            v1046 v1045
            let v1047 : System.Threading.Tasks.TaskCanceledException = v1036 |> unbox<System.Threading.Tasks.TaskCanceledException>
            let v1048 : US0 = US0_3
            let v1049 : (unit -> string) = closure51(v1047)
            let v1050 : (unit -> string) = method41()
            method3(v1048, v1049, v1050)
            return -2147483648 
            (*
            *)
            }
            |> fun x -> _v1023 <- Some x
            let v1051 : Async<int32> = _v1023 |> Option.get
            v1051
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1052 : Async<int32> = null |> unbox<Async<int32>>
            v1052
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1053 : Async<int32> = null |> unbox<Async<int32>>
            v1053
#endif
            |> fun x -> _v1018 <- Some x
            let v1054 : Async<int32> = _v1018.Value
            let! v1054 = v1054 
            let v1055 : int32 = v1054 
            let v1056 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v1057 : string seq = v1056 v972
            let v1058 : string = method60()
            let v1059 : (string -> (string seq -> string)) = String.concat
            let v1060 : (string seq -> string) = v1059 v1058
            let v1061 : string = v1060 v1057
            let v1062 : US0 = US0_1
            let v1063 : (unit -> string) = closure52(v1055, v1061)
            let v1064 : (unit -> string) = method41()
            method3(v1062, v1063, v1064)
            return struct (v1055, v1061) 
            }
            |> fun x -> _v938 <- Some x
            let v1065 : Async<struct (int32 * string)> = _v938 |> Option.get
            v1065
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1066 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v1066
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1067 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v1067
#endif
            |> fun x -> _v933 <- Some x
            let v1068 : Async<struct (int32 * string)> = _v933.Value
            v1068
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1069 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v1069
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1070 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v1070
#endif
            |> fun x -> _v928 <- Some x
            let v1071 : Async<struct (int32 * string)> = _v928.Value
            let v1072 : struct (int32 * string) option = None
            let v1073 : bool = true in let mutable _v1072 = v1072
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v1074 : int32, v1075 : string) = null |> unbox<struct (int32 * string)>
            struct (v1074, v1075)
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let struct (v1076 : int32, v1077 : string) = null |> unbox<struct (int32 * string)>
            struct (v1076, v1077)
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v1078 : int32, v1079 : string) = null |> unbox<struct (int32 * string)>
            struct (v1078, v1079)
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v1080 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
            let struct (v1081 : int32, v1082 : string) = v1080 v1071
            struct (v1081, v1082)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v1083 : int32, v1084 : string) = null |> unbox<struct (int32 * string)>
            struct (v1083, v1084)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v1085 : int32, v1086 : string) = null |> unbox<struct (int32 * string)>
            struct (v1085, v1086)
#endif
            |> fun x -> _v1072 <- Some x
            let struct (v1087 : int32, v1088 : string) = _v1072.Value
            struct (v1087, v1088)
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v1089 : int32, v1090 : string) = null |> unbox<struct (int32 * string)>
            struct (v1089, v1090)
#endif
            
#if FABLE_COMPILER_PYTHON
            let struct (v1091 : int32, v1092 : string) = null |> unbox<struct (int32 * string)>
            struct (v1091, v1092)
#endif
            |> fun x -> _v889 <- Some x
            let struct (v1093 : int32, v1094 : string) = _v889.Value
            let v1095 : string option = None
            let v1096 : bool = true in let mutable _v1095 = v1095
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1097 : string = method13(v2)
            let v1098 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1099 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1097 v1098
            let v1100 : string = "String::from($0)"
            let v1101 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1099 v1100
            let v1102 : string = "std::path::PathBuf::from($0)"
            let v1103 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1101 v1102
            let v1104 : string = method13(v238)
            let v1105 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1106 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1104 v1105
            let v1107 : string = "String::from($0)"
            let v1108 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1106 v1107
            let v1109 : string = "$0.join($1)"
            let v1110 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v1103, v1108) v1109
            let v1111 : string = "$0.display()"
            let v1112 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v1110 v1111
            let v1113 : std_string_String option = None
            let v1114 : bool = true in let mutable _v1113 = v1113
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1115 : string = @$"format!(""{{}}"", $0)"
            let v1116 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1112 v1115
            v1116
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1117 : string = @$"format!(""{{}}"", $0)"
            let v1118 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1112 v1117
            v1118
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1119 : string = @$"format!(""{{}}"", $0)"
            let v1120 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1112 v1119
            v1120
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v1121 : std_string_String = null |> unbox<std_string_String>
            v1121
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1122 : std_string_String = null |> unbox<std_string_String>
            v1122
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1123 : std_string_String = null |> unbox<std_string_String>
            v1123
#endif
            |> fun x -> _v1113 <- Some x
            let v1124 : std_string_String = _v1113.Value
            let v1125 : string = "fable_library_rust::String_::fromString($0)"
            let v1126 : string = Fable.Core.RustInterop.emitRustExpr v1124 v1125
            v1126
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1127 : string = null |> unbox<string>
            v1127
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1128 : string = null |> unbox<string>
            v1128
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v1129 : string = System.IO.Path.Combine (v2, v238)
            v1129
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1130 : IPathJoin = Fable.Core.JsInterop.importAll v308
            let v1131 : string = method14(v2)
            let v1132 : string = method15(v238)
            let v1133 : string = "v1130.join(v1131, v1132)"
            let v1134 : string = Fable.Core.JsInterop.emitJsExpr () v1133
            v1134
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1135 : string = null |> unbox<string>
            v1135
#endif
            |> fun x -> _v1095 <- Some x
            let v1136 : string = _v1095.Value
            let v1137 : bool option = None
            let v1138 : bool = true in let mutable _v1137 = v1137
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1139 : string = "cfg!(windows)"
            let v1140 : bool = Fable.Core.RustInterop.emitRustExpr () v1139
            v1140
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1141 : bool = null |> unbox<bool>
            v1141
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1142 : bool = null |> unbox<bool>
            v1142
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v1143 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v1144 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v1145 : bool = v1144 v1143
            v1145
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1146 : bool = null |> unbox<bool>
            v1146
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1147 : bool = null |> unbox<bool>
            v1147
#endif
            |> fun x -> _v1137 <- Some x
            let v1148 : bool = _v1137.Value
            let v1149 : bool = v1148 = false
            let v1170 : string =
                if v1149 then
                    v1136
                else
                    let v1150 : string option = None
                    let v1151 : bool = true in let mutable _v1150 = v1150
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1152 : string = method16()
                    let v1153 : string = method17(v1136)
                    let v1154 : string = method18()
                    let v1155 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v1156 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1152, v1153, v1154) v1155
                    let v1157 : string = "String::from($0)"
                    let v1158 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1156 v1157
                    let v1159 : string = "fable_library_rust::String_::fromString($0)"
                    let v1160 : string = Fable.Core.RustInterop.emitRustExpr v1158 v1159
                    v1160
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1161 : string = null |> unbox<string>
                    v1161
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1162 : string = null |> unbox<string>
                    v1162
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1163 : string = "^\\\\\\\\\\?\\\\"
                    let v1164 : string = System.Text.RegularExpressions.Regex.Replace (v1136, v1163, v233)
                    v1164
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1165 : string = null |> unbox<string>
                    v1165
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1166 : string = null |> unbox<string>
                    v1166
#endif
                    |> fun x -> _v1150 <- Some x
                    let v1167 : string = _v1150.Value
                    let v1168 : string = $"{v1167.[0] |> string |> _.ToLower()}{v1167.[1..]}"
                    let v1169 : string = v1168.Replace (v235, v236)
                    v1169
            let v1171 : bool option = None
            let v1172 : bool = true in let mutable _v1171 = v1171
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1173 : string = method13(v1170)
            let v1174 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1175 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1173 v1174
            let v1176 : string = "String::from($0)"
            let v1177 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1175 v1176
            let v1178 : string = "std::path::PathBuf::from($0)"
            let v1179 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1177 v1178
            let v1180 : string = "$0.exists()"
            let v1181 : bool = Fable.Core.RustInterop.emitRustExpr v1179 v1180
            let v1184 : bool =
                if v1181 then
                    let v1182 : string = "$0.is_file()"
                    let v1183 : bool = Fable.Core.RustInterop.emitRustExpr v1179 v1182
                    v1183
                else
                    false
            v1184
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v1185 : bool = null |> unbox<bool>
            v1185
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v1186 : bool = null |> unbox<bool>
            v1186
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v1187 : (string -> bool) = System.IO.File.Exists
            let v1188 : bool = v1187 v1170
            v1188
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v1189 : string = "fs"
            let v1190 : IFsExistsSync = Fable.Core.JsInterop.importAll v1189
            let v1191 : string = "v1190.existsSync($0)"
            let v1192 : bool = Fable.Core.JsInterop.emitJsExpr v1170 v1191
            v1192
#endif
            
#if FABLE_COMPILER_PYTHON
            let v1193 : bool = null |> unbox<bool>
            v1193
#endif
            |> fun x -> _v1171 <- Some x
            let v1194 : bool = _v1171.Value
            let v1439 : string =
                if v1194 then
                    let v1195 : bool option = None
                    let v1196 : bool = true in let mutable _v1195 = v1195
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1197 : string = "cfg!(windows)"
                    let v1198 : bool = Fable.Core.RustInterop.emitRustExpr () v1197
                    v1198
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1199 : bool = null |> unbox<bool>
                    v1199
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1200 : bool = null |> unbox<bool>
                    v1200
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1201 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                    let v1202 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                    let v1203 : bool = v1202 v1201
                    v1203
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1204 : bool = null |> unbox<bool>
                    v1204
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1205 : bool = null |> unbox<bool>
                    v1205
#endif
                    |> fun x -> _v1195 <- Some x
                    let v1206 : bool = _v1195.Value
                    let v1207 : bool = v1206 = false
                    let v1228 : string =
                        if v1207 then
                            v1170
                        else
                            let v1208 : string option = None
                            let v1209 : bool = true in let mutable _v1208 = v1208
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v1210 : string = method16()
                            let v1211 : string = method17(v1170)
                            let v1212 : string = method18()
                            let v1213 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                            let v1214 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1210, v1211, v1212) v1213
                            let v1215 : string = "String::from($0)"
                            let v1216 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1214 v1215
                            let v1217 : string = "fable_library_rust::String_::fromString($0)"
                            let v1218 : string = Fable.Core.RustInterop.emitRustExpr v1216 v1217
                            v1218
#endif
                            
#if FABLE_COMPILER_RUST && WASM
                            let v1219 : string = null |> unbox<string>
                            v1219
#endif
                            
#if FABLE_COMPILER_RUST && CONTRACT
                            let v1220 : string = null |> unbox<string>
                            v1220
#endif
                            
#if !FABLE_COMPILER && !WASM && !CONTRACT
                            let v1221 : string = "^\\\\\\\\\\?\\\\"
                            let v1222 : string = System.Text.RegularExpressions.Regex.Replace (v1170, v1221, v233)
                            v1222
#endif
                            
#if FABLE_COMPILER_TYPESCRIPT
                            let v1223 : string = null |> unbox<string>
                            v1223
#endif
                            
#if FABLE_COMPILER_PYTHON
                            let v1224 : string = null |> unbox<string>
                            v1224
#endif
                            |> fun x -> _v1208 <- Some x
                            let v1225 : string = _v1208.Value
                            let v1226 : string = $"{v1225.[0] |> string |> _.ToLower()}{v1225.[1..]}"
                            let v1227 : string = v1226.Replace (v235, v236)
                            v1227
                    let v1229 : System.Threading.CancellationToken option = None
                    let v1230 : (struct (bool * string * int32) -> Async<unit>) option = None
                    let v1231 : string option = None
                    let v1232 : string = $"pwsh -c \"(Get-FileHash \\\"{v1228}\\\" -Algorithm SHA256).Hash\""
                    let v1233 : struct (int32 * string) option = None
                    let v1234 : bool = true in let mutable _v1233 = v1233
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let struct (v1235 : string, v1236 : string) = method32()
                    let v1237 : int32 = v1232.Length
                    let v1238 : (char []) = Array.zeroCreate<char> (v1237)
                    let v1239 : Mut5 = {l0 = 0} : Mut5
                    while method20(v1237, v1239) do
                        let v1241 : int32 = v1239.l0
                        let v1242 : char = v1232.[int v1241]
                        v1238.[int v1241] <- v1242
                        let v1243 : int32 = v1241 + 1
                        v1239.l0 <- v1243
                        ()
                    let v1244 : ((char []) -> char list) = Array.toList
                    let v1245 : char list = v1244 v1238
                    let v1246 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                    let v1247 : (char -> (UH0 -> UH0)) = method33()
                    let v1248 : (char list -> (UH0 -> UH0)) = v1246 v1247
                    let v1249 : (UH0 -> UH0) = v1248 v1245
                    let v1250 : UH0 = UH0_0
                    let v1251 : UH0 = v1249 v1250
                    let v1252 : US8 = US8_0
                    let struct (v1253 : string, v1254 : string) = method34(v1236, v1235, v1251, v1252)
                    let v1255 : (string []) = method35(v1254)
                    let v1256 : string = "$0.to_vec()"
                    let v1257 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v1255 v1256
                    let v1258 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                    let v1259 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1257, v381) v1258
                    let v1260 : US0 = US0_1
                    let v1261 : (unit -> string) = closure28(v1229, v1232, v1230, v1231, v1253, v1259)
                    let v1262 : (unit -> string) = method41()
                    method3(v1260, v1261, v1262)
                    let v1263 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method42(v1229, v1232, v1230, v1231, v1253, v1259)
                    let v1264 : string = "futures_lite::future::block_on($0)"
                    let v1265 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v1263 v1264
                    let (a, b) = v1265
                    let v1266 : int32 = a
                    let v1267 : string = b
                    struct (v1266, v1267)
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let struct (v1268 : int32, v1269 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1268, v1269)
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let struct (v1270 : int32, v1271 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1270, v1271)
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1272 : Async<struct (int32 * string)> option = None
                    let v1273 : bool = true in let mutable _v1272 = v1272
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1274 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1274
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1275 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1275
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1276 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1276
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1277 : Async<struct (int32 * string)> option = None
                    let v1278 : bool = true in let mutable _v1277 = v1277
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1279 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1279
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1280 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1280
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1281 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1281
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1282 : Async<struct (int32 * string)> option = None
                    let mutable _v1282 = v1282
                    async {
                    let struct (v1283 : string, v1284 : string) = method32()
                    let v1285 : (char []) = Array.zeroCreate<char> (v1237)
                    let v1286 : Mut5 = {l0 = 0} : Mut5
                    while method20(v1237, v1286) do
                        let v1288 : int32 = v1286.l0
                        let v1289 : char = v1232.[int v1288]
                        v1285.[int v1288] <- v1289
                        let v1290 : int32 = v1288 + 1
                        v1286.l0 <- v1290
                        ()
                    let v1291 : ((char []) -> char list) = Array.toList
                    let v1292 : char list = v1291 v1285
                    let v1293 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                    let v1294 : (char -> (UH0 -> UH0)) = method33()
                    let v1295 : (char list -> (UH0 -> UH0)) = v1293 v1294
                    let v1296 : (UH0 -> UH0) = v1295 v1292
                    let v1297 : UH0 = UH0_0
                    let v1298 : UH0 = v1296 v1297
                    let v1299 : US8 = US8_0
                    let struct (v1300 : string, v1301 : string) = method34(v1284, v1283, v1298, v1299)
                    let v1302 : (string -> US7) = method36()
                    let v1303 : US7 = US7_1
                    let v1304 : US7 = v1231 |> Option.map v1302 |> Option.defaultValue v1303 
                    let v1307 : string =
                        match v1304 with
                        | US7_1 -> (* None *)
                            v233
                        | US7_0(v1305) -> (* Some *)
                            v1305
                    let v1308 : US0 = US0_1
                    let v1309 : (unit -> string) = closure44(v1229, v1232, v1230, v1231)
                    let v1310 : (unit -> string) = method41()
                    method3(v1308, v1309, v1310)
                    let v1311 : System.Text.Encoding = System.Text.Encoding.UTF8
                    let v1312 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v1301, StandardOutputEncoding = v1311, WorkingDirectory = v1307, FileName = v1300, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                    let v1313 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1312)
                    use v1313 = v1313 
                    let v1314 : System.Diagnostics.Process = v1313 
                    let v1315 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                    let v1316 : System.Collections.Concurrent.ConcurrentStack<string> = v1315 ()
                    let v1317 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v1229, v1232, v1230, v1231, v1314, v1316)
                    v1314.OutputDataReceived.Add v1317 
                    let v1318 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v1229, v1232, v1230, v1231, v1314, v1316)
                    v1314.ErrorDataReceived.Add v1318 
                    let v1319 : (unit -> bool) = v1314.Start
                    let v1320 : bool = v1319 ()
                    let v1321 : bool = v1320 = false
                    if v1321 then
                        let v1322 : string = $"execute_with_options_async / process_start error"
                        failwith<unit> v1322
                    let v1323 : (unit -> unit) = v1314.BeginErrorReadLine
                    v1323 ()
                    let v1324 : (unit -> unit) = v1314.BeginOutputReadLine
                    v1324 ()
                    let v1325 : (System.Threading.CancellationToken -> US16) = method59()
                    let v1326 : US16 = US16_1
                    let v1327 : US16 = v1229 |> Option.map v1325 |> Option.defaultValue v1326 
                    let v1331 : System.Threading.CancellationToken =
                        match v1327 with
                        | US16_1 -> (* None *)
                            let v1329 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                            v1329
                        | US16_0(v1328) -> (* Some *)
                            v1328
                    let v1332 : Async<System.Threading.CancellationToken> option = None
                    let v1333 : bool = true in let mutable _v1332 = v1332
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1334 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1334
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1335 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1335
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1336 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1336
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1337 : Async<System.Threading.CancellationToken> option = None
                    let v1338 : bool = true in let mutable _v1337 = v1337
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1339 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1339
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1340 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1340
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1341 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1341
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1342 : Async<System.Threading.CancellationToken> option = None
                    let mutable _v1342 = v1342
                    async {
                    let v1343 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v1343 = v1343 
                    let v1344 : System.Threading.CancellationToken = v1343 
                    let v1345 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v1346 : (System.Threading.CancellationToken []) = [|v1344; v1345; v1331|]
                    let v1347 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v1348 : System.Threading.CancellationTokenSource = v1347 v1346
                    let v1349 : System.Threading.CancellationToken = v1348.Token
                    return v1349 
                    }
                    |> fun x -> _v1342 <- Some x
                    let v1350 : Async<System.Threading.CancellationToken> = _v1342 |> Option.get
                    v1350
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1351 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1351
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1352 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1352
#endif
                    |> fun x -> _v1337 <- Some x
                    let v1353 : Async<System.Threading.CancellationToken> = _v1337.Value
                    v1353
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1354 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1354
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1355 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1355
#endif
                    |> fun x -> _v1332 <- Some x
                    let v1356 : Async<System.Threading.CancellationToken> = _v1332.Value
                    let! v1356 = v1356 
                    let v1357 : System.Threading.CancellationToken = v1356 
                    let v1358 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1357.Register
                    let v1359 : (unit -> unit) = closure50(v1314)
                    let v1360 : System.Threading.CancellationTokenRegistration = v1358 v1359
                    use v1360 = v1360 
                    let v1361 : System.Threading.CancellationTokenRegistration = v1360 
                    let v1362 : Async<int32> option = None
                    let v1363 : bool = true in let mutable _v1362 = v1362
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1364 : Async<int32> = null |> unbox<Async<int32>>
                    v1364
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1365 : Async<int32> = null |> unbox<Async<int32>>
                    v1365
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1366 : Async<int32> = null |> unbox<Async<int32>>
                    v1366
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1367 : Async<int32> option = None
                    let mutable _v1367 = v1367
                    async {
                    try
                    let v1368 : System.Threading.Tasks.Task = v1314.WaitForExitAsync v1357 
                    let v1369 : Async<unit> option = None
                    let v1370 : bool = true in let mutable _v1369 = v1369
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1371 : Async<unit> = null |> unbox<Async<unit>>
                    v1371
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1372 : Async<unit> = null |> unbox<Async<unit>>
                    v1372
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1373 : Async<unit> = null |> unbox<Async<unit>>
                    v1373
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1374 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1375 : Async<unit> = v1374 v1368
                    v1375
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1376 : Async<unit> = null |> unbox<Async<unit>>
                    v1376
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1377 : Async<unit> = null |> unbox<Async<unit>>
                    v1377
#endif
                    |> fun x -> _v1369 <- Some x
                    let v1378 : Async<unit> = _v1369.Value
                    do! v1378 
                    let v1379 : int32 = v1314.ExitCode
                    return v1379 
                    with ex ->
                    let v1380 : exn = ex
                    let v1381 : string option = None
                    let v1382 : bool = true in let mutable _v1381 = v1381
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1383 : string = $"%A{v1380}"
                    v1383
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v1384 : string = $"%A{v1380}"
                    v1384
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1385 : string = $"%A{v1380}"
                    v1385
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1386 : string = $"{v1380.GetType ()}: {v1380.Message}"
                    v1386
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1387 : string = $"%A{v1380}"
                    v1387
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1388 : string = $"%A{v1380}"
                    v1388
#endif
                    |> fun x -> _v1381 <- Some x
                    let v1389 : string = _v1381.Value
                    let v1390 : (string -> unit) = v1316.Push
                    v1390 v1389
                    let v1391 : System.Threading.Tasks.TaskCanceledException = v1380 |> unbox<System.Threading.Tasks.TaskCanceledException>
                    let v1392 : US0 = US0_3
                    let v1393 : (unit -> string) = closure51(v1391)
                    let v1394 : (unit -> string) = method41()
                    method3(v1392, v1393, v1394)
                    return -2147483648 
                    (*
                    *)
                    }
                    |> fun x -> _v1367 <- Some x
                    let v1395 : Async<int32> = _v1367 |> Option.get
                    v1395
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1396 : Async<int32> = null |> unbox<Async<int32>>
                    v1396
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1397 : Async<int32> = null |> unbox<Async<int32>>
                    v1397
#endif
                    |> fun x -> _v1362 <- Some x
                    let v1398 : Async<int32> = _v1362.Value
                    let! v1398 = v1398 
                    let v1399 : int32 = v1398 
                    let v1400 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                    let v1401 : string seq = v1400 v1316
                    let v1402 : string = method60()
                    let v1403 : (string -> (string seq -> string)) = String.concat
                    let v1404 : (string seq -> string) = v1403 v1402
                    let v1405 : string = v1404 v1401
                    let v1406 : US0 = US0_1
                    let v1407 : (unit -> string) = closure52(v1399, v1405)
                    let v1408 : (unit -> string) = method41()
                    method3(v1406, v1407, v1408)
                    return struct (v1399, v1405) 
                    }
                    |> fun x -> _v1282 <- Some x
                    let v1409 : Async<struct (int32 * string)> = _v1282 |> Option.get
                    v1409
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1410 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1410
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1411 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1411
#endif
                    |> fun x -> _v1277 <- Some x
                    let v1412 : Async<struct (int32 * string)> = _v1277.Value
                    v1412
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v1413 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1413
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v1414 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1414
#endif
                    |> fun x -> _v1272 <- Some x
                    let v1415 : Async<struct (int32 * string)> = _v1272.Value
                    let v1416 : struct (int32 * string) option = None
                    let v1417 : bool = true in let mutable _v1416 = v1416
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let struct (v1418 : int32, v1419 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1418, v1419)
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let struct (v1420 : int32, v1421 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1420, v1421)
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let struct (v1422 : int32, v1423 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1422, v1423)
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v1424 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                    let struct (v1425 : int32, v1426 : string) = v1424 v1415
                    struct (v1425, v1426)
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let struct (v1427 : int32, v1428 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1427, v1428)
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let struct (v1429 : int32, v1430 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1429, v1430)
#endif
                    |> fun x -> _v1416 <- Some x
                    let struct (v1431 : int32, v1432 : string) = _v1416.Value
                    struct (v1431, v1432)
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let struct (v1433 : int32, v1434 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1433, v1434)
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let struct (v1435 : int32, v1436 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1435, v1436)
#endif
                    |> fun x -> _v1233 <- Some x
                    let struct (v1437 : int32, v1438 : string) = _v1233.Value
                    v1438
                else
                    v233
            let v1440 : bool = v1094 <> v1439
            if v1440 then
                let v1441 : Result<string, (string * string)> option = None
                let v1442 : string = "epub"
                let v1443 : string = $"{v637}.{v1442}"
                let v1444 : string = $"{v1170}.{v1442}"
                let v1445 : bool option = None
                let v1446 : bool = true in let mutable _v1445 = v1445
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1447 : string = method13(v1443)
                let v1448 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                let v1449 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1447 v1448
                let v1450 : string = "String::from($0)"
                let v1451 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1449 v1450
                let v1452 : string = "std::path::PathBuf::from($0)"
                let v1453 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1451 v1452
                let v1454 : string = "$0.exists()"
                let v1455 : bool = Fable.Core.RustInterop.emitRustExpr v1453 v1454
                let v1458 : bool =
                    if v1455 then
                        let v1456 : string = "$0.is_file()"
                        let v1457 : bool = Fable.Core.RustInterop.emitRustExpr v1453 v1456
                        v1457
                    else
                        false
                v1458
#endif
                
#if FABLE_COMPILER_RUST && WASM
                let v1459 : bool = null |> unbox<bool>
                v1459
#endif
                
#if FABLE_COMPILER_RUST && CONTRACT
                let v1460 : bool = null |> unbox<bool>
                v1460
#endif
                
#if !FABLE_COMPILER && !WASM && !CONTRACT
                let v1461 : (string -> bool) = System.IO.File.Exists
                let v1462 : bool = v1461 v1443
                v1462
#endif
                
#if FABLE_COMPILER_TYPESCRIPT
                let v1463 : IFsExistsSync = Fable.Core.JsInterop.importAll v1189
                let v1464 : string = "v1463.existsSync($0)"
                let v1465 : bool = Fable.Core.JsInterop.emitJsExpr v1443 v1464
                v1465
#endif
                
#if FABLE_COMPILER_PYTHON
                let v1466 : bool = null |> unbox<bool>
                v1466
#endif
                |> fun x -> _v1445 <- Some x
                let v1467 : bool = _v1445.Value
                let v1491 : bool =
                    if v1467 then
                        let v1468 : bool option = None
                        let v1469 : bool = true in let mutable _v1468 = v1468
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1470 : string = method13(v1444)
                        let v1471 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                        let v1472 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1470 v1471
                        let v1473 : string = "String::from($0)"
                        let v1474 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1472 v1473
                        let v1475 : string = "std::path::PathBuf::from($0)"
                        let v1476 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1474 v1475
                        let v1477 : string = "$0.exists()"
                        let v1478 : bool = Fable.Core.RustInterop.emitRustExpr v1476 v1477
                        let v1481 : bool =
                            if v1478 then
                                let v1479 : string = "$0.is_file()"
                                let v1480 : bool = Fable.Core.RustInterop.emitRustExpr v1476 v1479
                                v1480
                            else
                                false
                        v1481
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1482 : bool = null |> unbox<bool>
                        v1482
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1483 : bool = null |> unbox<bool>
                        v1483
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1484 : (string -> bool) = System.IO.File.Exists
                        let v1485 : bool = v1484 v1444
                        v1485
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1486 : IFsExistsSync = Fable.Core.JsInterop.importAll v1189
                        let v1487 : string = "v1486.existsSync($0)"
                        let v1488 : bool = Fable.Core.JsInterop.emitJsExpr v1444 v1487
                        v1488
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1489 : bool = null |> unbox<bool>
                        v1489
#endif
                        |> fun x -> _v1468 <- Some x
                        let v1490 : bool = _v1468.Value
                        v1490
                    else
                        false
                let v1981 : bool =
                    if v1491 then
                        let v1492 : bool option = None
                        let v1493 : bool = true in let mutable _v1492 = v1492
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1494 : string = "cfg!(windows)"
                        let v1495 : bool = Fable.Core.RustInterop.emitRustExpr () v1494
                        v1495
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1496 : bool = null |> unbox<bool>
                        v1496
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1497 : bool = null |> unbox<bool>
                        v1497
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1498 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                        let v1499 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                        let v1500 : bool = v1499 v1498
                        v1500
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1501 : bool = null |> unbox<bool>
                        v1501
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1502 : bool = null |> unbox<bool>
                        v1502
#endif
                        |> fun x -> _v1492 <- Some x
                        let v1503 : bool = _v1492.Value
                        let v1504 : bool = v1503 = false
                        let v1525 : string =
                            if v1504 then
                                v1443
                            else
                                let v1505 : string option = None
                                let v1506 : bool = true in let mutable _v1505 = v1505
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v1507 : string = method16()
                                let v1508 : string = method17(v1443)
                                let v1509 : string = method18()
                                let v1510 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                                let v1511 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1507, v1508, v1509) v1510
                                let v1512 : string = "String::from($0)"
                                let v1513 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1511 v1512
                                let v1514 : string = "fable_library_rust::String_::fromString($0)"
                                let v1515 : string = Fable.Core.RustInterop.emitRustExpr v1513 v1514
                                v1515
#endif
                                
#if FABLE_COMPILER_RUST && WASM
                                let v1516 : string = null |> unbox<string>
                                v1516
#endif
                                
#if FABLE_COMPILER_RUST && CONTRACT
                                let v1517 : string = null |> unbox<string>
                                v1517
#endif
                                
#if !FABLE_COMPILER && !WASM && !CONTRACT
                                let v1518 : string = "^\\\\\\\\\\?\\\\"
                                let v1519 : string = System.Text.RegularExpressions.Regex.Replace (v1443, v1518, v233)
                                v1519
#endif
                                
#if FABLE_COMPILER_TYPESCRIPT
                                let v1520 : string = null |> unbox<string>
                                v1520
#endif
                                
#if FABLE_COMPILER_PYTHON
                                let v1521 : string = null |> unbox<string>
                                v1521
#endif
                                |> fun x -> _v1505 <- Some x
                                let v1522 : string = _v1505.Value
                                let v1523 : string = $"{v1522.[0] |> string |> _.ToLower()}{v1522.[1..]}"
                                let v1524 : string = v1523.Replace (v235, v236)
                                v1524
                        let v1526 : System.Threading.CancellationToken option = None
                        let v1527 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v1528 : string option = None
                        let v1529 : string = $"pwsh -c \"(Get-FileHash \\\"{v1525}\\\" -Algorithm SHA256).Hash\""
                        let v1530 : struct (int32 * string) option = None
                        let v1531 : bool = true in let mutable _v1530 = v1530
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v1532 : string, v1533 : string) = method32()
                        let v1534 : int32 = v1529.Length
                        let v1535 : (char []) = Array.zeroCreate<char> (v1534)
                        let v1536 : Mut5 = {l0 = 0} : Mut5
                        while method20(v1534, v1536) do
                            let v1538 : int32 = v1536.l0
                            let v1539 : char = v1529.[int v1538]
                            v1535.[int v1538] <- v1539
                            let v1540 : int32 = v1538 + 1
                            v1536.l0 <- v1540
                            ()
                        let v1541 : ((char []) -> char list) = Array.toList
                        let v1542 : char list = v1541 v1535
                        let v1543 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v1544 : (char -> (UH0 -> UH0)) = method33()
                        let v1545 : (char list -> (UH0 -> UH0)) = v1543 v1544
                        let v1546 : (UH0 -> UH0) = v1545 v1542
                        let v1547 : UH0 = UH0_0
                        let v1548 : UH0 = v1546 v1547
                        let v1549 : US8 = US8_0
                        let struct (v1550 : string, v1551 : string) = method34(v1533, v1532, v1548, v1549)
                        let v1552 : (string []) = method35(v1551)
                        let v1553 : string = "$0.to_vec()"
                        let v1554 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v1552 v1553
                        let v1555 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v1556 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1554, v381) v1555
                        let v1557 : US0 = US0_1
                        let v1558 : (unit -> string) = closure28(v1526, v1529, v1527, v1528, v1550, v1556)
                        let v1559 : (unit -> string) = method41()
                        method3(v1557, v1558, v1559)
                        let v1560 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method42(v1526, v1529, v1527, v1528, v1550, v1556)
                        let v1561 : string = "futures_lite::future::block_on($0)"
                        let v1562 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v1560 v1561
                        let (a, b) = v1562
                        let v1563 : int32 = a
                        let v1564 : string = b
                        struct (v1563, v1564)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v1565 : int32, v1566 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1565, v1566)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v1567 : int32, v1568 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1567, v1568)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1569 : Async<struct (int32 * string)> option = None
                        let v1570 : bool = true in let mutable _v1569 = v1569
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1571 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1571
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1572 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1572
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1573 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1573
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1574 : Async<struct (int32 * string)> option = None
                        let v1575 : bool = true in let mutable _v1574 = v1574
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1576 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1576
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1577 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1577
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1578 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1578
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1579 : Async<struct (int32 * string)> option = None
                        let mutable _v1579 = v1579
                        async {
                        let struct (v1580 : string, v1581 : string) = method32()
                        let v1582 : (char []) = Array.zeroCreate<char> (v1534)
                        let v1583 : Mut5 = {l0 = 0} : Mut5
                        while method20(v1534, v1583) do
                            let v1585 : int32 = v1583.l0
                            let v1586 : char = v1529.[int v1585]
                            v1582.[int v1585] <- v1586
                            let v1587 : int32 = v1585 + 1
                            v1583.l0 <- v1587
                            ()
                        let v1588 : ((char []) -> char list) = Array.toList
                        let v1589 : char list = v1588 v1582
                        let v1590 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v1591 : (char -> (UH0 -> UH0)) = method33()
                        let v1592 : (char list -> (UH0 -> UH0)) = v1590 v1591
                        let v1593 : (UH0 -> UH0) = v1592 v1589
                        let v1594 : UH0 = UH0_0
                        let v1595 : UH0 = v1593 v1594
                        let v1596 : US8 = US8_0
                        let struct (v1597 : string, v1598 : string) = method34(v1581, v1580, v1595, v1596)
                        let v1599 : (string -> US7) = method36()
                        let v1600 : US7 = US7_1
                        let v1601 : US7 = v1528 |> Option.map v1599 |> Option.defaultValue v1600 
                        let v1604 : string =
                            match v1601 with
                            | US7_1 -> (* None *)
                                v233
                            | US7_0(v1602) -> (* Some *)
                                v1602
                        let v1605 : US0 = US0_1
                        let v1606 : (unit -> string) = closure44(v1526, v1529, v1527, v1528)
                        let v1607 : (unit -> string) = method41()
                        method3(v1605, v1606, v1607)
                        let v1608 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v1609 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v1598, StandardOutputEncoding = v1608, WorkingDirectory = v1604, FileName = v1597, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v1610 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1609)
                        use v1610 = v1610 
                        let v1611 : System.Diagnostics.Process = v1610 
                        let v1612 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v1613 : System.Collections.Concurrent.ConcurrentStack<string> = v1612 ()
                        let v1614 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v1526, v1529, v1527, v1528, v1611, v1613)
                        v1611.OutputDataReceived.Add v1614 
                        let v1615 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v1526, v1529, v1527, v1528, v1611, v1613)
                        v1611.ErrorDataReceived.Add v1615 
                        let v1616 : (unit -> bool) = v1611.Start
                        let v1617 : bool = v1616 ()
                        let v1618 : bool = v1617 = false
                        if v1618 then
                            let v1619 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v1619
                        let v1620 : (unit -> unit) = v1611.BeginErrorReadLine
                        v1620 ()
                        let v1621 : (unit -> unit) = v1611.BeginOutputReadLine
                        v1621 ()
                        let v1622 : (System.Threading.CancellationToken -> US16) = method59()
                        let v1623 : US16 = US16_1
                        let v1624 : US16 = v1526 |> Option.map v1622 |> Option.defaultValue v1623 
                        let v1628 : System.Threading.CancellationToken =
                            match v1624 with
                            | US16_1 -> (* None *)
                                let v1626 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v1626
                            | US16_0(v1625) -> (* Some *)
                                v1625
                        let v1629 : Async<System.Threading.CancellationToken> option = None
                        let v1630 : bool = true in let mutable _v1629 = v1629
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1631 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1631
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1632 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1632
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1633 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1633
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1634 : Async<System.Threading.CancellationToken> option = None
                        let v1635 : bool = true in let mutable _v1634 = v1634
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1636 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1636
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1637 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1637
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1638 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1638
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1639 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v1639 = v1639
                        async {
                        let v1640 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v1640 = v1640 
                        let v1641 : System.Threading.CancellationToken = v1640 
                        let v1642 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v1643 : (System.Threading.CancellationToken []) = [|v1641; v1642; v1628|]
                        let v1644 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v1645 : System.Threading.CancellationTokenSource = v1644 v1643
                        let v1646 : System.Threading.CancellationToken = v1645.Token
                        return v1646 
                        }
                        |> fun x -> _v1639 <- Some x
                        let v1647 : Async<System.Threading.CancellationToken> = _v1639 |> Option.get
                        v1647
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1648 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1648
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1649 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1649
#endif
                        |> fun x -> _v1634 <- Some x
                        let v1650 : Async<System.Threading.CancellationToken> = _v1634.Value
                        v1650
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1651 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1651
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1652 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1652
#endif
                        |> fun x -> _v1629 <- Some x
                        let v1653 : Async<System.Threading.CancellationToken> = _v1629.Value
                        let! v1653 = v1653 
                        let v1654 : System.Threading.CancellationToken = v1653 
                        let v1655 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1654.Register
                        let v1656 : (unit -> unit) = closure50(v1611)
                        let v1657 : System.Threading.CancellationTokenRegistration = v1655 v1656
                        use v1657 = v1657 
                        let v1658 : System.Threading.CancellationTokenRegistration = v1657 
                        let v1659 : Async<int32> option = None
                        let v1660 : bool = true in let mutable _v1659 = v1659
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1661 : Async<int32> = null |> unbox<Async<int32>>
                        v1661
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1662 : Async<int32> = null |> unbox<Async<int32>>
                        v1662
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1663 : Async<int32> = null |> unbox<Async<int32>>
                        v1663
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1664 : Async<int32> option = None
                        let mutable _v1664 = v1664
                        async {
                        try
                        let v1665 : System.Threading.Tasks.Task = v1611.WaitForExitAsync v1654 
                        let v1666 : Async<unit> option = None
                        let v1667 : bool = true in let mutable _v1666 = v1666
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1668 : Async<unit> = null |> unbox<Async<unit>>
                        v1668
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1669 : Async<unit> = null |> unbox<Async<unit>>
                        v1669
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1670 : Async<unit> = null |> unbox<Async<unit>>
                        v1670
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1671 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v1672 : Async<unit> = v1671 v1665
                        v1672
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1673 : Async<unit> = null |> unbox<Async<unit>>
                        v1673
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1674 : Async<unit> = null |> unbox<Async<unit>>
                        v1674
#endif
                        |> fun x -> _v1666 <- Some x
                        let v1675 : Async<unit> = _v1666.Value
                        do! v1675 
                        let v1676 : int32 = v1611.ExitCode
                        return v1676 
                        with ex ->
                        let v1677 : exn = ex
                        let v1678 : string option = None
                        let v1679 : bool = true in let mutable _v1678 = v1678
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1680 : string = $"%A{v1677}"
                        v1680
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1681 : string = $"%A{v1677}"
                        v1681
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1682 : string = $"%A{v1677}"
                        v1682
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1683 : string = $"{v1677.GetType ()}: {v1677.Message}"
                        v1683
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1684 : string = $"%A{v1677}"
                        v1684
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1685 : string = $"%A{v1677}"
                        v1685
#endif
                        |> fun x -> _v1678 <- Some x
                        let v1686 : string = _v1678.Value
                        let v1687 : (string -> unit) = v1613.Push
                        v1687 v1686
                        let v1688 : System.Threading.Tasks.TaskCanceledException = v1677 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v1689 : US0 = US0_3
                        let v1690 : (unit -> string) = closure51(v1688)
                        let v1691 : (unit -> string) = method41()
                        method3(v1689, v1690, v1691)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v1664 <- Some x
                        let v1692 : Async<int32> = _v1664 |> Option.get
                        v1692
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1693 : Async<int32> = null |> unbox<Async<int32>>
                        v1693
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1694 : Async<int32> = null |> unbox<Async<int32>>
                        v1694
#endif
                        |> fun x -> _v1659 <- Some x
                        let v1695 : Async<int32> = _v1659.Value
                        let! v1695 = v1695 
                        let v1696 : int32 = v1695 
                        let v1697 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v1698 : string seq = v1697 v1613
                        let v1699 : string = method60()
                        let v1700 : (string -> (string seq -> string)) = String.concat
                        let v1701 : (string seq -> string) = v1700 v1699
                        let v1702 : string = v1701 v1698
                        let v1703 : US0 = US0_1
                        let v1704 : (unit -> string) = closure52(v1696, v1702)
                        let v1705 : (unit -> string) = method41()
                        method3(v1703, v1704, v1705)
                        return struct (v1696, v1702) 
                        }
                        |> fun x -> _v1579 <- Some x
                        let v1706 : Async<struct (int32 * string)> = _v1579 |> Option.get
                        v1706
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1707 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1707
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1708 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1708
#endif
                        |> fun x -> _v1574 <- Some x
                        let v1709 : Async<struct (int32 * string)> = _v1574.Value
                        v1709
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1710 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1710
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1711 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1711
#endif
                        |> fun x -> _v1569 <- Some x
                        let v1712 : Async<struct (int32 * string)> = _v1569.Value
                        let v1713 : struct (int32 * string) option = None
                        let v1714 : bool = true in let mutable _v1713 = v1713
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v1715 : int32, v1716 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1715, v1716)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v1717 : int32, v1718 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1717, v1718)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v1719 : int32, v1720 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1719, v1720)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1721 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v1722 : int32, v1723 : string) = v1721 v1712
                        struct (v1722, v1723)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v1724 : int32, v1725 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1724, v1725)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v1726 : int32, v1727 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1726, v1727)
#endif
                        |> fun x -> _v1713 <- Some x
                        let struct (v1728 : int32, v1729 : string) = _v1713.Value
                        struct (v1728, v1729)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v1730 : int32, v1731 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1730, v1731)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v1732 : int32, v1733 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1732, v1733)
#endif
                        |> fun x -> _v1530 <- Some x
                        let struct (v1734 : int32, v1735 : string) = _v1530.Value
                        let v1736 : bool option = None
                        let v1737 : bool = true in let mutable _v1736 = v1736
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1738 : string = "cfg!(windows)"
                        let v1739 : bool = Fable.Core.RustInterop.emitRustExpr () v1738
                        v1739
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1740 : bool = null |> unbox<bool>
                        v1740
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1741 : bool = null |> unbox<bool>
                        v1741
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1742 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                        let v1743 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                        let v1744 : bool = v1743 v1742
                        v1744
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1745 : bool = null |> unbox<bool>
                        v1745
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1746 : bool = null |> unbox<bool>
                        v1746
#endif
                        |> fun x -> _v1736 <- Some x
                        let v1747 : bool = _v1736.Value
                        let v1748 : bool = v1747 = false
                        let v1769 : string =
                            if v1748 then
                                v1444
                            else
                                let v1749 : string option = None
                                let v1750 : bool = true in let mutable _v1749 = v1749
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v1751 : string = method16()
                                let v1752 : string = method17(v1444)
                                let v1753 : string = method18()
                                let v1754 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                                let v1755 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1751, v1752, v1753) v1754
                                let v1756 : string = "String::from($0)"
                                let v1757 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1755 v1756
                                let v1758 : string = "fable_library_rust::String_::fromString($0)"
                                let v1759 : string = Fable.Core.RustInterop.emitRustExpr v1757 v1758
                                v1759
#endif
                                
#if FABLE_COMPILER_RUST && WASM
                                let v1760 : string = null |> unbox<string>
                                v1760
#endif
                                
#if FABLE_COMPILER_RUST && CONTRACT
                                let v1761 : string = null |> unbox<string>
                                v1761
#endif
                                
#if !FABLE_COMPILER && !WASM && !CONTRACT
                                let v1762 : string = "^\\\\\\\\\\?\\\\"
                                let v1763 : string = System.Text.RegularExpressions.Regex.Replace (v1444, v1762, v233)
                                v1763
#endif
                                
#if FABLE_COMPILER_TYPESCRIPT
                                let v1764 : string = null |> unbox<string>
                                v1764
#endif
                                
#if FABLE_COMPILER_PYTHON
                                let v1765 : string = null |> unbox<string>
                                v1765
#endif
                                |> fun x -> _v1749 <- Some x
                                let v1766 : string = _v1749.Value
                                let v1767 : string = $"{v1766.[0] |> string |> _.ToLower()}{v1766.[1..]}"
                                let v1768 : string = v1767.Replace (v235, v236)
                                v1768
                        let v1770 : System.Threading.CancellationToken option = None
                        let v1771 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v1772 : string option = None
                        let v1773 : string = $"pwsh -c \"(Get-FileHash \\\"{v1769}\\\" -Algorithm SHA256).Hash\""
                        let v1774 : struct (int32 * string) option = None
                        let v1775 : bool = true in let mutable _v1774 = v1774
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v1776 : string, v1777 : string) = method32()
                        let v1778 : int32 = v1773.Length
                        let v1779 : (char []) = Array.zeroCreate<char> (v1778)
                        let v1780 : Mut5 = {l0 = 0} : Mut5
                        while method20(v1778, v1780) do
                            let v1782 : int32 = v1780.l0
                            let v1783 : char = v1773.[int v1782]
                            v1779.[int v1782] <- v1783
                            let v1784 : int32 = v1782 + 1
                            v1780.l0 <- v1784
                            ()
                        let v1785 : ((char []) -> char list) = Array.toList
                        let v1786 : char list = v1785 v1779
                        let v1787 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v1788 : (char -> (UH0 -> UH0)) = method33()
                        let v1789 : (char list -> (UH0 -> UH0)) = v1787 v1788
                        let v1790 : (UH0 -> UH0) = v1789 v1786
                        let v1791 : UH0 = UH0_0
                        let v1792 : UH0 = v1790 v1791
                        let v1793 : US8 = US8_0
                        let struct (v1794 : string, v1795 : string) = method34(v1777, v1776, v1792, v1793)
                        let v1796 : (string []) = method35(v1795)
                        let v1797 : string = "$0.to_vec()"
                        let v1798 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v1796 v1797
                        let v1799 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v1800 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1798, v381) v1799
                        let v1801 : US0 = US0_1
                        let v1802 : (unit -> string) = closure28(v1770, v1773, v1771, v1772, v1794, v1800)
                        let v1803 : (unit -> string) = method41()
                        method3(v1801, v1802, v1803)
                        let v1804 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method42(v1770, v1773, v1771, v1772, v1794, v1800)
                        let v1805 : string = "futures_lite::future::block_on($0)"
                        let v1806 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v1804 v1805
                        let (a, b) = v1806
                        let v1807 : int32 = a
                        let v1808 : string = b
                        struct (v1807, v1808)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v1809 : int32, v1810 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1809, v1810)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v1811 : int32, v1812 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1811, v1812)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1813 : Async<struct (int32 * string)> option = None
                        let v1814 : bool = true in let mutable _v1813 = v1813
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1815 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1815
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1816 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1816
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1817 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1817
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1818 : Async<struct (int32 * string)> option = None
                        let v1819 : bool = true in let mutable _v1818 = v1818
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1820 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1820
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1821 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1821
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1822 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1822
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1823 : Async<struct (int32 * string)> option = None
                        let mutable _v1823 = v1823
                        async {
                        let struct (v1824 : string, v1825 : string) = method32()
                        let v1826 : (char []) = Array.zeroCreate<char> (v1778)
                        let v1827 : Mut5 = {l0 = 0} : Mut5
                        while method20(v1778, v1827) do
                            let v1829 : int32 = v1827.l0
                            let v1830 : char = v1773.[int v1829]
                            v1826.[int v1829] <- v1830
                            let v1831 : int32 = v1829 + 1
                            v1827.l0 <- v1831
                            ()
                        let v1832 : ((char []) -> char list) = Array.toList
                        let v1833 : char list = v1832 v1826
                        let v1834 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v1835 : (char -> (UH0 -> UH0)) = method33()
                        let v1836 : (char list -> (UH0 -> UH0)) = v1834 v1835
                        let v1837 : (UH0 -> UH0) = v1836 v1833
                        let v1838 : UH0 = UH0_0
                        let v1839 : UH0 = v1837 v1838
                        let v1840 : US8 = US8_0
                        let struct (v1841 : string, v1842 : string) = method34(v1825, v1824, v1839, v1840)
                        let v1843 : (string -> US7) = method36()
                        let v1844 : US7 = US7_1
                        let v1845 : US7 = v1772 |> Option.map v1843 |> Option.defaultValue v1844 
                        let v1848 : string =
                            match v1845 with
                            | US7_1 -> (* None *)
                                v233
                            | US7_0(v1846) -> (* Some *)
                                v1846
                        let v1849 : US0 = US0_1
                        let v1850 : (unit -> string) = closure44(v1770, v1773, v1771, v1772)
                        let v1851 : (unit -> string) = method41()
                        method3(v1849, v1850, v1851)
                        let v1852 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v1853 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v1842, StandardOutputEncoding = v1852, WorkingDirectory = v1848, FileName = v1841, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v1854 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1853)
                        use v1854 = v1854 
                        let v1855 : System.Diagnostics.Process = v1854 
                        let v1856 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v1857 : System.Collections.Concurrent.ConcurrentStack<string> = v1856 ()
                        let v1858 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v1770, v1773, v1771, v1772, v1855, v1857)
                        v1855.OutputDataReceived.Add v1858 
                        let v1859 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v1770, v1773, v1771, v1772, v1855, v1857)
                        v1855.ErrorDataReceived.Add v1859 
                        let v1860 : (unit -> bool) = v1855.Start
                        let v1861 : bool = v1860 ()
                        let v1862 : bool = v1861 = false
                        if v1862 then
                            let v1863 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v1863
                        let v1864 : (unit -> unit) = v1855.BeginErrorReadLine
                        v1864 ()
                        let v1865 : (unit -> unit) = v1855.BeginOutputReadLine
                        v1865 ()
                        let v1866 : (System.Threading.CancellationToken -> US16) = method59()
                        let v1867 : US16 = US16_1
                        let v1868 : US16 = v1770 |> Option.map v1866 |> Option.defaultValue v1867 
                        let v1872 : System.Threading.CancellationToken =
                            match v1868 with
                            | US16_1 -> (* None *)
                                let v1870 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v1870
                            | US16_0(v1869) -> (* Some *)
                                v1869
                        let v1873 : Async<System.Threading.CancellationToken> option = None
                        let v1874 : bool = true in let mutable _v1873 = v1873
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1875 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1875
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1876 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1876
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1877 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1877
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1878 : Async<System.Threading.CancellationToken> option = None
                        let v1879 : bool = true in let mutable _v1878 = v1878
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1880 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1880
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1881 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1881
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1882 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1882
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1883 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v1883 = v1883
                        async {
                        let v1884 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v1884 = v1884 
                        let v1885 : System.Threading.CancellationToken = v1884 
                        let v1886 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v1887 : (System.Threading.CancellationToken []) = [|v1885; v1886; v1872|]
                        let v1888 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v1889 : System.Threading.CancellationTokenSource = v1888 v1887
                        let v1890 : System.Threading.CancellationToken = v1889.Token
                        return v1890 
                        }
                        |> fun x -> _v1883 <- Some x
                        let v1891 : Async<System.Threading.CancellationToken> = _v1883 |> Option.get
                        v1891
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1892 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1892
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1893 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1893
#endif
                        |> fun x -> _v1878 <- Some x
                        let v1894 : Async<System.Threading.CancellationToken> = _v1878.Value
                        v1894
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1895 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1895
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1896 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1896
#endif
                        |> fun x -> _v1873 <- Some x
                        let v1897 : Async<System.Threading.CancellationToken> = _v1873.Value
                        let! v1897 = v1897 
                        let v1898 : System.Threading.CancellationToken = v1897 
                        let v1899 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1898.Register
                        let v1900 : (unit -> unit) = closure50(v1855)
                        let v1901 : System.Threading.CancellationTokenRegistration = v1899 v1900
                        use v1901 = v1901 
                        let v1902 : System.Threading.CancellationTokenRegistration = v1901 
                        let v1903 : Async<int32> option = None
                        let v1904 : bool = true in let mutable _v1903 = v1903
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1905 : Async<int32> = null |> unbox<Async<int32>>
                        v1905
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1906 : Async<int32> = null |> unbox<Async<int32>>
                        v1906
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1907 : Async<int32> = null |> unbox<Async<int32>>
                        v1907
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1908 : Async<int32> option = None
                        let mutable _v1908 = v1908
                        async {
                        try
                        let v1909 : System.Threading.Tasks.Task = v1855.WaitForExitAsync v1898 
                        let v1910 : Async<unit> option = None
                        let v1911 : bool = true in let mutable _v1910 = v1910
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1912 : Async<unit> = null |> unbox<Async<unit>>
                        v1912
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1913 : Async<unit> = null |> unbox<Async<unit>>
                        v1913
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1914 : Async<unit> = null |> unbox<Async<unit>>
                        v1914
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1915 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v1916 : Async<unit> = v1915 v1909
                        v1916
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1917 : Async<unit> = null |> unbox<Async<unit>>
                        v1917
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1918 : Async<unit> = null |> unbox<Async<unit>>
                        v1918
#endif
                        |> fun x -> _v1910 <- Some x
                        let v1919 : Async<unit> = _v1910.Value
                        do! v1919 
                        let v1920 : int32 = v1855.ExitCode
                        return v1920 
                        with ex ->
                        let v1921 : exn = ex
                        let v1922 : string option = None
                        let v1923 : bool = true in let mutable _v1922 = v1922
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1924 : string = $"%A{v1921}"
                        v1924
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v1925 : string = $"%A{v1921}"
                        v1925
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1926 : string = $"%A{v1921}"
                        v1926
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1927 : string = $"{v1921.GetType ()}: {v1921.Message}"
                        v1927
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1928 : string = $"%A{v1921}"
                        v1928
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1929 : string = $"%A{v1921}"
                        v1929
#endif
                        |> fun x -> _v1922 <- Some x
                        let v1930 : string = _v1922.Value
                        let v1931 : (string -> unit) = v1857.Push
                        v1931 v1930
                        let v1932 : System.Threading.Tasks.TaskCanceledException = v1921 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v1933 : US0 = US0_3
                        let v1934 : (unit -> string) = closure51(v1932)
                        let v1935 : (unit -> string) = method41()
                        method3(v1933, v1934, v1935)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v1908 <- Some x
                        let v1936 : Async<int32> = _v1908 |> Option.get
                        v1936
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1937 : Async<int32> = null |> unbox<Async<int32>>
                        v1937
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1938 : Async<int32> = null |> unbox<Async<int32>>
                        v1938
#endif
                        |> fun x -> _v1903 <- Some x
                        let v1939 : Async<int32> = _v1903.Value
                        let! v1939 = v1939 
                        let v1940 : int32 = v1939 
                        let v1941 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v1942 : string seq = v1941 v1857
                        let v1943 : string = method60()
                        let v1944 : (string -> (string seq -> string)) = String.concat
                        let v1945 : (string seq -> string) = v1944 v1943
                        let v1946 : string = v1945 v1942
                        let v1947 : US0 = US0_1
                        let v1948 : (unit -> string) = closure52(v1940, v1946)
                        let v1949 : (unit -> string) = method41()
                        method3(v1947, v1948, v1949)
                        return struct (v1940, v1946) 
                        }
                        |> fun x -> _v1823 <- Some x
                        let v1950 : Async<struct (int32 * string)> = _v1823 |> Option.get
                        v1950
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1951 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1951
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1952 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1952
#endif
                        |> fun x -> _v1818 <- Some x
                        let v1953 : Async<struct (int32 * string)> = _v1818.Value
                        v1953
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v1954 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1954
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v1955 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1955
#endif
                        |> fun x -> _v1813 <- Some x
                        let v1956 : Async<struct (int32 * string)> = _v1813.Value
                        let v1957 : struct (int32 * string) option = None
                        let v1958 : bool = true in let mutable _v1957 = v1957
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v1959 : int32, v1960 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1959, v1960)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v1961 : int32, v1962 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1961, v1962)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v1963 : int32, v1964 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1963, v1964)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v1965 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v1966 : int32, v1967 : string) = v1965 v1956
                        struct (v1966, v1967)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v1968 : int32, v1969 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1968, v1969)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v1970 : int32, v1971 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1970, v1971)
#endif
                        |> fun x -> _v1957 <- Some x
                        let struct (v1972 : int32, v1973 : string) = _v1957.Value
                        struct (v1972, v1973)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v1974 : int32, v1975 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1974, v1975)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v1976 : int32, v1977 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1976, v1977)
#endif
                        |> fun x -> _v1774 <- Some x
                        let struct (v1978 : int32, v1979 : string) = _v1774.Value
                        let v1980 : bool = v1735 = v1979
                        v1980
                    else
                        false
                let v1982 : bool = v1981 = false
                let v2215 : US17 =
                    if v1982 then
                        let v1983 : string = $"crowbook --single \"{v637}\" --output \"{v1443}\" --to {v1442} --set rendering.num_depth 6 html.css.add \\\"''' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} '''\\\""
                        let v1984 : System.Threading.CancellationToken option = None
                        let v1985 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v1986 : string option = None
                        let v1987 : string option = Some v1 
                        let v1988 : struct (int32 * string) option = None
                        let v1989 : bool = true in let mutable _v1988 = v1988
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v1990 : string, v1991 : string) = method32()
                        let v1992 : int32 = v1983.Length
                        let v1993 : (char []) = Array.zeroCreate<char> (v1992)
                        let v1994 : Mut5 = {l0 = 0} : Mut5
                        while method20(v1992, v1994) do
                            let v1996 : int32 = v1994.l0
                            let v1997 : char = v1983.[int v1996]
                            v1993.[int v1996] <- v1997
                            let v1998 : int32 = v1996 + 1
                            v1994.l0 <- v1998
                            ()
                        let v1999 : ((char []) -> char list) = Array.toList
                        let v2000 : char list = v1999 v1993
                        let v2001 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2002 : (char -> (UH0 -> UH0)) = method33()
                        let v2003 : (char list -> (UH0 -> UH0)) = v2001 v2002
                        let v2004 : (UH0 -> UH0) = v2003 v2000
                        let v2005 : UH0 = UH0_0
                        let v2006 : UH0 = v2004 v2005
                        let v2007 : US8 = US8_0
                        let struct (v2008 : string, v2009 : string) = method34(v1991, v1990, v2006, v2007)
                        let v2010 : (string []) = method35(v2009)
                        let v2011 : string = "$0.to_vec()"
                        let v2012 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v2010 v2011
                        let v2013 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v2014 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2012, v381) v2013
                        let v2015 : US0 = US0_1
                        let v2016 : (unit -> string) = closure28(v1984, v1983, v1985, v1987, v2008, v2014)
                        let v2017 : (unit -> string) = method41()
                        method3(v2015, v2016, v2017)
                        let v2018 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method42(v1984, v1983, v1985, v1987, v2008, v2014)
                        let v2019 : string = "futures_lite::future::block_on($0)"
                        let v2020 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v2018 v2019
                        let (a, b) = v2020
                        let v2021 : int32 = a
                        let v2022 : string = b
                        struct (v2021, v2022)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v2023 : int32, v2024 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2023, v2024)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2025 : int32, v2026 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2025, v2026)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2027 : Async<struct (int32 * string)> option = None
                        let v2028 : bool = true in let mutable _v2027 = v2027
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2029 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2029
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2030 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2030
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2031 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2031
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2032 : Async<struct (int32 * string)> option = None
                        let v2033 : bool = true in let mutable _v2032 = v2032
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2034 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2034
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2035 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2035
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2036 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2036
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2037 : Async<struct (int32 * string)> option = None
                        let mutable _v2037 = v2037
                        async {
                        let struct (v2038 : string, v2039 : string) = method32()
                        let v2040 : (char []) = Array.zeroCreate<char> (v1992)
                        let v2041 : Mut5 = {l0 = 0} : Mut5
                        while method20(v1992, v2041) do
                            let v2043 : int32 = v2041.l0
                            let v2044 : char = v1983.[int v2043]
                            v2040.[int v2043] <- v2044
                            let v2045 : int32 = v2043 + 1
                            v2041.l0 <- v2045
                            ()
                        let v2046 : ((char []) -> char list) = Array.toList
                        let v2047 : char list = v2046 v2040
                        let v2048 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2049 : (char -> (UH0 -> UH0)) = method33()
                        let v2050 : (char list -> (UH0 -> UH0)) = v2048 v2049
                        let v2051 : (UH0 -> UH0) = v2050 v2047
                        let v2052 : UH0 = UH0_0
                        let v2053 : UH0 = v2051 v2052
                        let v2054 : US8 = US8_0
                        let struct (v2055 : string, v2056 : string) = method34(v2039, v2038, v2053, v2054)
                        let v2057 : (string -> US7) = method36()
                        let v2058 : US7 = US7_1
                        let v2059 : US7 = v1987 |> Option.map v2057 |> Option.defaultValue v2058 
                        let v2062 : string =
                            match v2059 with
                            | US7_1 -> (* None *)
                                v233
                            | US7_0(v2060) -> (* Some *)
                                v2060
                        let v2063 : US0 = US0_1
                        let v2064 : (unit -> string) = closure44(v1984, v1983, v1985, v1987)
                        let v2065 : (unit -> string) = method41()
                        method3(v2063, v2064, v2065)
                        let v2066 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v2067 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v2056, StandardOutputEncoding = v2066, WorkingDirectory = v2062, FileName = v2055, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v2068 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v2067)
                        use v2068 = v2068 
                        let v2069 : System.Diagnostics.Process = v2068 
                        let v2070 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v2071 : System.Collections.Concurrent.ConcurrentStack<string> = v2070 ()
                        let v2072 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v1984, v1983, v1985, v1987, v2069, v2071)
                        v2069.OutputDataReceived.Add v2072 
                        let v2073 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v1984, v1983, v1985, v1987, v2069, v2071)
                        v2069.ErrorDataReceived.Add v2073 
                        let v2074 : (unit -> bool) = v2069.Start
                        let v2075 : bool = v2074 ()
                        let v2076 : bool = v2075 = false
                        if v2076 then
                            let v2077 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v2077
                        let v2078 : (unit -> unit) = v2069.BeginErrorReadLine
                        v2078 ()
                        let v2079 : (unit -> unit) = v2069.BeginOutputReadLine
                        v2079 ()
                        let v2080 : (System.Threading.CancellationToken -> US16) = method59()
                        let v2081 : US16 = US16_1
                        let v2082 : US16 = v1984 |> Option.map v2080 |> Option.defaultValue v2081 
                        let v2086 : System.Threading.CancellationToken =
                            match v2082 with
                            | US16_1 -> (* None *)
                                let v2084 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v2084
                            | US16_0(v2083) -> (* Some *)
                                v2083
                        let v2087 : Async<System.Threading.CancellationToken> option = None
                        let v2088 : bool = true in let mutable _v2087 = v2087
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2089 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2089
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2090 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2090
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2091 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2091
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2092 : Async<System.Threading.CancellationToken> option = None
                        let v2093 : bool = true in let mutable _v2092 = v2092
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2094 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2094
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2095 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2095
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2096 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2096
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2097 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v2097 = v2097
                        async {
                        let v2098 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v2098 = v2098 
                        let v2099 : System.Threading.CancellationToken = v2098 
                        let v2100 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v2101 : (System.Threading.CancellationToken []) = [|v2099; v2100; v2086|]
                        let v2102 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v2103 : System.Threading.CancellationTokenSource = v2102 v2101
                        let v2104 : System.Threading.CancellationToken = v2103.Token
                        return v2104 
                        }
                        |> fun x -> _v2097 <- Some x
                        let v2105 : Async<System.Threading.CancellationToken> = _v2097 |> Option.get
                        v2105
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2106 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2106
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2107 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2107
#endif
                        |> fun x -> _v2092 <- Some x
                        let v2108 : Async<System.Threading.CancellationToken> = _v2092.Value
                        v2108
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2109 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2109
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2110 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2110
#endif
                        |> fun x -> _v2087 <- Some x
                        let v2111 : Async<System.Threading.CancellationToken> = _v2087.Value
                        let! v2111 = v2111 
                        let v2112 : System.Threading.CancellationToken = v2111 
                        let v2113 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v2112.Register
                        let v2114 : (unit -> unit) = closure50(v2069)
                        let v2115 : System.Threading.CancellationTokenRegistration = v2113 v2114
                        use v2115 = v2115 
                        let v2116 : System.Threading.CancellationTokenRegistration = v2115 
                        let v2117 : Async<int32> option = None
                        let v2118 : bool = true in let mutable _v2117 = v2117
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2119 : Async<int32> = null |> unbox<Async<int32>>
                        v2119
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2120 : Async<int32> = null |> unbox<Async<int32>>
                        v2120
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2121 : Async<int32> = null |> unbox<Async<int32>>
                        v2121
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2122 : Async<int32> option = None
                        let mutable _v2122 = v2122
                        async {
                        try
                        let v2123 : System.Threading.Tasks.Task = v2069.WaitForExitAsync v2112 
                        let v2124 : Async<unit> option = None
                        let v2125 : bool = true in let mutable _v2124 = v2124
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2126 : Async<unit> = null |> unbox<Async<unit>>
                        v2126
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2127 : Async<unit> = null |> unbox<Async<unit>>
                        v2127
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2128 : Async<unit> = null |> unbox<Async<unit>>
                        v2128
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2129 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v2130 : Async<unit> = v2129 v2123
                        v2130
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2131 : Async<unit> = null |> unbox<Async<unit>>
                        v2131
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2132 : Async<unit> = null |> unbox<Async<unit>>
                        v2132
#endif
                        |> fun x -> _v2124 <- Some x
                        let v2133 : Async<unit> = _v2124.Value
                        do! v2133 
                        let v2134 : int32 = v2069.ExitCode
                        return v2134 
                        with ex ->
                        let v2135 : exn = ex
                        let v2136 : string option = None
                        let v2137 : bool = true in let mutable _v2136 = v2136
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2138 : string = $"%A{v2135}"
                        v2138
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2139 : string = $"%A{v2135}"
                        v2139
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2140 : string = $"%A{v2135}"
                        v2140
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2141 : string = $"{v2135.GetType ()}: {v2135.Message}"
                        v2141
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2142 : string = $"%A{v2135}"
                        v2142
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2143 : string = $"%A{v2135}"
                        v2143
#endif
                        |> fun x -> _v2136 <- Some x
                        let v2144 : string = _v2136.Value
                        let v2145 : (string -> unit) = v2071.Push
                        v2145 v2144
                        let v2146 : System.Threading.Tasks.TaskCanceledException = v2135 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v2147 : US0 = US0_3
                        let v2148 : (unit -> string) = closure51(v2146)
                        let v2149 : (unit -> string) = method41()
                        method3(v2147, v2148, v2149)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v2122 <- Some x
                        let v2150 : Async<int32> = _v2122 |> Option.get
                        v2150
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2151 : Async<int32> = null |> unbox<Async<int32>>
                        v2151
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2152 : Async<int32> = null |> unbox<Async<int32>>
                        v2152
#endif
                        |> fun x -> _v2117 <- Some x
                        let v2153 : Async<int32> = _v2117.Value
                        let! v2153 = v2153 
                        let v2154 : int32 = v2153 
                        let v2155 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v2156 : string seq = v2155 v2071
                        let v2157 : string = method60()
                        let v2158 : (string -> (string seq -> string)) = String.concat
                        let v2159 : (string seq -> string) = v2158 v2157
                        let v2160 : string = v2159 v2156
                        let v2161 : US0 = US0_1
                        let v2162 : (unit -> string) = closure52(v2154, v2160)
                        let v2163 : (unit -> string) = method41()
                        method3(v2161, v2162, v2163)
                        return struct (v2154, v2160) 
                        }
                        |> fun x -> _v2037 <- Some x
                        let v2164 : Async<struct (int32 * string)> = _v2037 |> Option.get
                        v2164
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2165 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2165
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2166 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2166
#endif
                        |> fun x -> _v2032 <- Some x
                        let v2167 : Async<struct (int32 * string)> = _v2032.Value
                        v2167
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2168 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2168
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2169 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2169
#endif
                        |> fun x -> _v2027 <- Some x
                        let v2170 : Async<struct (int32 * string)> = _v2027.Value
                        let v2171 : struct (int32 * string) option = None
                        let v2172 : bool = true in let mutable _v2171 = v2171
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v2173 : int32, v2174 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2173, v2174)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v2175 : int32, v2176 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2175, v2176)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2177 : int32, v2178 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2177, v2178)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2179 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v2180 : int32, v2181 : string) = v2179 v2170
                        struct (v2180, v2181)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2182 : int32, v2183 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2182, v2183)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v2184 : int32, v2185 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2184, v2185)
#endif
                        |> fun x -> _v2171 <- Some x
                        let struct (v2186 : int32, v2187 : string) = _v2171.Value
                        struct (v2186, v2187)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2188 : int32, v2189 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2188, v2189)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v2190 : int32, v2191 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2190, v2191)
#endif
                        |> fun x -> _v1988 <- Some x
                        let struct (v2192 : int32, v2193 : string) = _v1988.Value
                        let v2194 : bool = v2192 <> 0
                        let v2197 : bool =
                            if v2194 then
                                true
                            else
                                let v2195 : string = "ERROR"
                                let v2196 : bool = v2193.Contains v2195
                                v2196
                        if v2197 then
                            let v2198 : US0 = US0_2
                            let v2199 : (unit -> string) = closure53()
                            let v2200 : (unit -> string) = closure54(v2193, v2192)
                            method3(v2198, v2199, v2200)
                            let v2201 : (string * string) = v1443, v2193
                            let v2202 : Result<string, (string * string)> = Error v2201
                            US17_0(v2202)
                        else
                            let v2204 : unit option = None
                            let v2205 : bool = true in let mutable _v2204 = v2204
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v2206 : string = method61(v1444)
                            let v2207 : string = "std::fs::copy(&*v1443, &*v2206)"
                            let v2208 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v2207
                            let v2209 : string = "$0.unwrap()"
                            let v2210 : uint64 = Fable.Core.RustInterop.emitRustExpr v2208 v2209
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
                            System.IO.File.Copy (v1443, v1444, true)
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
                            |> fun x -> _v2204 <- Some x
                            _v2204.Value
                            let v2211 : Result<string, (string * string)> = Ok v1443
                            US17_0(v2211)
                    else
                        US17_1
                let v2220 : Result<string, (string * string)> option =
                    match v2215 with
                    | US17_1 -> (* None *)
                        let v2218 : Result<string, (string * string)> option = None
                        v2218
                    | US17_0(v2216) -> (* Some *)
                        let v2217 : Result<string, (string * string)> option = Some v2216 
                        v2217
                let v2221 : string = "pdf"
                let v2222 : string = $"{v637}.{v2221}"
                let v2223 : string = $"{v1170}.{v2221}"
                let v2224 : bool option = None
                let v2225 : bool = true in let mutable _v2224 = v2224
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v2226 : string = method13(v2222)
                let v2227 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                let v2228 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2226 v2227
                let v2229 : string = "String::from($0)"
                let v2230 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2228 v2229
                let v2231 : string = "std::path::PathBuf::from($0)"
                let v2232 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v2230 v2231
                let v2233 : string = "$0.exists()"
                let v2234 : bool = Fable.Core.RustInterop.emitRustExpr v2232 v2233
                let v2237 : bool =
                    if v2234 then
                        let v2235 : string = "$0.is_file()"
                        let v2236 : bool = Fable.Core.RustInterop.emitRustExpr v2232 v2235
                        v2236
                    else
                        false
                v2237
#endif
                
#if FABLE_COMPILER_RUST && WASM
                let v2238 : bool = null |> unbox<bool>
                v2238
#endif
                
#if FABLE_COMPILER_RUST && CONTRACT
                let v2239 : bool = null |> unbox<bool>
                v2239
#endif
                
#if !FABLE_COMPILER && !WASM && !CONTRACT
                let v2240 : (string -> bool) = System.IO.File.Exists
                let v2241 : bool = v2240 v2222
                v2241
#endif
                
#if FABLE_COMPILER_TYPESCRIPT
                let v2242 : IFsExistsSync = Fable.Core.JsInterop.importAll v1189
                let v2243 : string = "v2242.existsSync($0)"
                let v2244 : bool = Fable.Core.JsInterop.emitJsExpr v2222 v2243
                v2244
#endif
                
#if FABLE_COMPILER_PYTHON
                let v2245 : bool = null |> unbox<bool>
                v2245
#endif
                |> fun x -> _v2224 <- Some x
                let v2246 : bool = _v2224.Value
                let v2270 : bool =
                    if v2246 then
                        let v2247 : bool option = None
                        let v2248 : bool = true in let mutable _v2247 = v2247
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2249 : string = method13(v2223)
                        let v2250 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                        let v2251 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2249 v2250
                        let v2252 : string = "String::from($0)"
                        let v2253 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2251 v2252
                        let v2254 : string = "std::path::PathBuf::from($0)"
                        let v2255 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v2253 v2254
                        let v2256 : string = "$0.exists()"
                        let v2257 : bool = Fable.Core.RustInterop.emitRustExpr v2255 v2256
                        let v2260 : bool =
                            if v2257 then
                                let v2258 : string = "$0.is_file()"
                                let v2259 : bool = Fable.Core.RustInterop.emitRustExpr v2255 v2258
                                v2259
                            else
                                false
                        v2260
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2261 : bool = null |> unbox<bool>
                        v2261
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2262 : bool = null |> unbox<bool>
                        v2262
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2263 : (string -> bool) = System.IO.File.Exists
                        let v2264 : bool = v2263 v2223
                        v2264
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2265 : IFsExistsSync = Fable.Core.JsInterop.importAll v1189
                        let v2266 : string = "v2265.existsSync($0)"
                        let v2267 : bool = Fable.Core.JsInterop.emitJsExpr v2223 v2266
                        v2267
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2268 : bool = null |> unbox<bool>
                        v2268
#endif
                        |> fun x -> _v2247 <- Some x
                        let v2269 : bool = _v2247.Value
                        v2269
                    else
                        false
                let v2760 : bool =
                    if v2270 then
                        let v2271 : bool option = None
                        let v2272 : bool = true in let mutable _v2271 = v2271
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2273 : string = "cfg!(windows)"
                        let v2274 : bool = Fable.Core.RustInterop.emitRustExpr () v2273
                        v2274
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2275 : bool = null |> unbox<bool>
                        v2275
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2276 : bool = null |> unbox<bool>
                        v2276
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2277 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                        let v2278 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                        let v2279 : bool = v2278 v2277
                        v2279
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2280 : bool = null |> unbox<bool>
                        v2280
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2281 : bool = null |> unbox<bool>
                        v2281
#endif
                        |> fun x -> _v2271 <- Some x
                        let v2282 : bool = _v2271.Value
                        let v2283 : bool = v2282 = false
                        let v2304 : string =
                            if v2283 then
                                v2222
                            else
                                let v2284 : string option = None
                                let v2285 : bool = true in let mutable _v2284 = v2284
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v2286 : string = method16()
                                let v2287 : string = method17(v2222)
                                let v2288 : string = method18()
                                let v2289 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                                let v2290 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v2286, v2287, v2288) v2289
                                let v2291 : string = "String::from($0)"
                                let v2292 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2290 v2291
                                let v2293 : string = "fable_library_rust::String_::fromString($0)"
                                let v2294 : string = Fable.Core.RustInterop.emitRustExpr v2292 v2293
                                v2294
#endif
                                
#if FABLE_COMPILER_RUST && WASM
                                let v2295 : string = null |> unbox<string>
                                v2295
#endif
                                
#if FABLE_COMPILER_RUST && CONTRACT
                                let v2296 : string = null |> unbox<string>
                                v2296
#endif
                                
#if !FABLE_COMPILER && !WASM && !CONTRACT
                                let v2297 : string = "^\\\\\\\\\\?\\\\"
                                let v2298 : string = System.Text.RegularExpressions.Regex.Replace (v2222, v2297, v233)
                                v2298
#endif
                                
#if FABLE_COMPILER_TYPESCRIPT
                                let v2299 : string = null |> unbox<string>
                                v2299
#endif
                                
#if FABLE_COMPILER_PYTHON
                                let v2300 : string = null |> unbox<string>
                                v2300
#endif
                                |> fun x -> _v2284 <- Some x
                                let v2301 : string = _v2284.Value
                                let v2302 : string = $"{v2301.[0] |> string |> _.ToLower()}{v2301.[1..]}"
                                let v2303 : string = v2302.Replace (v235, v236)
                                v2303
                        let v2305 : System.Threading.CancellationToken option = None
                        let v2306 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v2307 : string option = None
                        let v2308 : string = $"pwsh -c \"(Get-FileHash \\\"{v2304}\\\" -Algorithm SHA256).Hash\""
                        let v2309 : struct (int32 * string) option = None
                        let v2310 : bool = true in let mutable _v2309 = v2309
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v2311 : string, v2312 : string) = method32()
                        let v2313 : int32 = v2308.Length
                        let v2314 : (char []) = Array.zeroCreate<char> (v2313)
                        let v2315 : Mut5 = {l0 = 0} : Mut5
                        while method20(v2313, v2315) do
                            let v2317 : int32 = v2315.l0
                            let v2318 : char = v2308.[int v2317]
                            v2314.[int v2317] <- v2318
                            let v2319 : int32 = v2317 + 1
                            v2315.l0 <- v2319
                            ()
                        let v2320 : ((char []) -> char list) = Array.toList
                        let v2321 : char list = v2320 v2314
                        let v2322 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2323 : (char -> (UH0 -> UH0)) = method33()
                        let v2324 : (char list -> (UH0 -> UH0)) = v2322 v2323
                        let v2325 : (UH0 -> UH0) = v2324 v2321
                        let v2326 : UH0 = UH0_0
                        let v2327 : UH0 = v2325 v2326
                        let v2328 : US8 = US8_0
                        let struct (v2329 : string, v2330 : string) = method34(v2312, v2311, v2327, v2328)
                        let v2331 : (string []) = method35(v2330)
                        let v2332 : string = "$0.to_vec()"
                        let v2333 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v2331 v2332
                        let v2334 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v2335 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2333, v381) v2334
                        let v2336 : US0 = US0_1
                        let v2337 : (unit -> string) = closure28(v2305, v2308, v2306, v2307, v2329, v2335)
                        let v2338 : (unit -> string) = method41()
                        method3(v2336, v2337, v2338)
                        let v2339 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method42(v2305, v2308, v2306, v2307, v2329, v2335)
                        let v2340 : string = "futures_lite::future::block_on($0)"
                        let v2341 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v2339 v2340
                        let (a, b) = v2341
                        let v2342 : int32 = a
                        let v2343 : string = b
                        struct (v2342, v2343)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v2344 : int32, v2345 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2344, v2345)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2346 : int32, v2347 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2346, v2347)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2348 : Async<struct (int32 * string)> option = None
                        let v2349 : bool = true in let mutable _v2348 = v2348
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2350 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2350
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2351 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2351
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2352 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2352
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2353 : Async<struct (int32 * string)> option = None
                        let v2354 : bool = true in let mutable _v2353 = v2353
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2355 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2355
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2356 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2356
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2357 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2357
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2358 : Async<struct (int32 * string)> option = None
                        let mutable _v2358 = v2358
                        async {
                        let struct (v2359 : string, v2360 : string) = method32()
                        let v2361 : (char []) = Array.zeroCreate<char> (v2313)
                        let v2362 : Mut5 = {l0 = 0} : Mut5
                        while method20(v2313, v2362) do
                            let v2364 : int32 = v2362.l0
                            let v2365 : char = v2308.[int v2364]
                            v2361.[int v2364] <- v2365
                            let v2366 : int32 = v2364 + 1
                            v2362.l0 <- v2366
                            ()
                        let v2367 : ((char []) -> char list) = Array.toList
                        let v2368 : char list = v2367 v2361
                        let v2369 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2370 : (char -> (UH0 -> UH0)) = method33()
                        let v2371 : (char list -> (UH0 -> UH0)) = v2369 v2370
                        let v2372 : (UH0 -> UH0) = v2371 v2368
                        let v2373 : UH0 = UH0_0
                        let v2374 : UH0 = v2372 v2373
                        let v2375 : US8 = US8_0
                        let struct (v2376 : string, v2377 : string) = method34(v2360, v2359, v2374, v2375)
                        let v2378 : (string -> US7) = method36()
                        let v2379 : US7 = US7_1
                        let v2380 : US7 = v2307 |> Option.map v2378 |> Option.defaultValue v2379 
                        let v2383 : string =
                            match v2380 with
                            | US7_1 -> (* None *)
                                v233
                            | US7_0(v2381) -> (* Some *)
                                v2381
                        let v2384 : US0 = US0_1
                        let v2385 : (unit -> string) = closure44(v2305, v2308, v2306, v2307)
                        let v2386 : (unit -> string) = method41()
                        method3(v2384, v2385, v2386)
                        let v2387 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v2388 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v2377, StandardOutputEncoding = v2387, WorkingDirectory = v2383, FileName = v2376, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v2389 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v2388)
                        use v2389 = v2389 
                        let v2390 : System.Diagnostics.Process = v2389 
                        let v2391 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v2392 : System.Collections.Concurrent.ConcurrentStack<string> = v2391 ()
                        let v2393 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v2305, v2308, v2306, v2307, v2390, v2392)
                        v2390.OutputDataReceived.Add v2393 
                        let v2394 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v2305, v2308, v2306, v2307, v2390, v2392)
                        v2390.ErrorDataReceived.Add v2394 
                        let v2395 : (unit -> bool) = v2390.Start
                        let v2396 : bool = v2395 ()
                        let v2397 : bool = v2396 = false
                        if v2397 then
                            let v2398 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v2398
                        let v2399 : (unit -> unit) = v2390.BeginErrorReadLine
                        v2399 ()
                        let v2400 : (unit -> unit) = v2390.BeginOutputReadLine
                        v2400 ()
                        let v2401 : (System.Threading.CancellationToken -> US16) = method59()
                        let v2402 : US16 = US16_1
                        let v2403 : US16 = v2305 |> Option.map v2401 |> Option.defaultValue v2402 
                        let v2407 : System.Threading.CancellationToken =
                            match v2403 with
                            | US16_1 -> (* None *)
                                let v2405 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v2405
                            | US16_0(v2404) -> (* Some *)
                                v2404
                        let v2408 : Async<System.Threading.CancellationToken> option = None
                        let v2409 : bool = true in let mutable _v2408 = v2408
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2410 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2410
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2411 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2411
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2412 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2412
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2413 : Async<System.Threading.CancellationToken> option = None
                        let v2414 : bool = true in let mutable _v2413 = v2413
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2415 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2415
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2416 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2416
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2417 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2417
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2418 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v2418 = v2418
                        async {
                        let v2419 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v2419 = v2419 
                        let v2420 : System.Threading.CancellationToken = v2419 
                        let v2421 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v2422 : (System.Threading.CancellationToken []) = [|v2420; v2421; v2407|]
                        let v2423 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v2424 : System.Threading.CancellationTokenSource = v2423 v2422
                        let v2425 : System.Threading.CancellationToken = v2424.Token
                        return v2425 
                        }
                        |> fun x -> _v2418 <- Some x
                        let v2426 : Async<System.Threading.CancellationToken> = _v2418 |> Option.get
                        v2426
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2427 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2427
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2428 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2428
#endif
                        |> fun x -> _v2413 <- Some x
                        let v2429 : Async<System.Threading.CancellationToken> = _v2413.Value
                        v2429
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2430 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2430
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2431 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2431
#endif
                        |> fun x -> _v2408 <- Some x
                        let v2432 : Async<System.Threading.CancellationToken> = _v2408.Value
                        let! v2432 = v2432 
                        let v2433 : System.Threading.CancellationToken = v2432 
                        let v2434 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v2433.Register
                        let v2435 : (unit -> unit) = closure50(v2390)
                        let v2436 : System.Threading.CancellationTokenRegistration = v2434 v2435
                        use v2436 = v2436 
                        let v2437 : System.Threading.CancellationTokenRegistration = v2436 
                        let v2438 : Async<int32> option = None
                        let v2439 : bool = true in let mutable _v2438 = v2438
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2440 : Async<int32> = null |> unbox<Async<int32>>
                        v2440
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2441 : Async<int32> = null |> unbox<Async<int32>>
                        v2441
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2442 : Async<int32> = null |> unbox<Async<int32>>
                        v2442
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2443 : Async<int32> option = None
                        let mutable _v2443 = v2443
                        async {
                        try
                        let v2444 : System.Threading.Tasks.Task = v2390.WaitForExitAsync v2433 
                        let v2445 : Async<unit> option = None
                        let v2446 : bool = true in let mutable _v2445 = v2445
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2447 : Async<unit> = null |> unbox<Async<unit>>
                        v2447
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2448 : Async<unit> = null |> unbox<Async<unit>>
                        v2448
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2449 : Async<unit> = null |> unbox<Async<unit>>
                        v2449
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2450 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v2451 : Async<unit> = v2450 v2444
                        v2451
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2452 : Async<unit> = null |> unbox<Async<unit>>
                        v2452
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2453 : Async<unit> = null |> unbox<Async<unit>>
                        v2453
#endif
                        |> fun x -> _v2445 <- Some x
                        let v2454 : Async<unit> = _v2445.Value
                        do! v2454 
                        let v2455 : int32 = v2390.ExitCode
                        return v2455 
                        with ex ->
                        let v2456 : exn = ex
                        let v2457 : string option = None
                        let v2458 : bool = true in let mutable _v2457 = v2457
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2459 : string = $"%A{v2456}"
                        v2459
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2460 : string = $"%A{v2456}"
                        v2460
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2461 : string = $"%A{v2456}"
                        v2461
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2462 : string = $"{v2456.GetType ()}: {v2456.Message}"
                        v2462
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2463 : string = $"%A{v2456}"
                        v2463
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2464 : string = $"%A{v2456}"
                        v2464
#endif
                        |> fun x -> _v2457 <- Some x
                        let v2465 : string = _v2457.Value
                        let v2466 : (string -> unit) = v2392.Push
                        v2466 v2465
                        let v2467 : System.Threading.Tasks.TaskCanceledException = v2456 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v2468 : US0 = US0_3
                        let v2469 : (unit -> string) = closure51(v2467)
                        let v2470 : (unit -> string) = method41()
                        method3(v2468, v2469, v2470)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v2443 <- Some x
                        let v2471 : Async<int32> = _v2443 |> Option.get
                        v2471
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2472 : Async<int32> = null |> unbox<Async<int32>>
                        v2472
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2473 : Async<int32> = null |> unbox<Async<int32>>
                        v2473
#endif
                        |> fun x -> _v2438 <- Some x
                        let v2474 : Async<int32> = _v2438.Value
                        let! v2474 = v2474 
                        let v2475 : int32 = v2474 
                        let v2476 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v2477 : string seq = v2476 v2392
                        let v2478 : string = method60()
                        let v2479 : (string -> (string seq -> string)) = String.concat
                        let v2480 : (string seq -> string) = v2479 v2478
                        let v2481 : string = v2480 v2477
                        let v2482 : US0 = US0_1
                        let v2483 : (unit -> string) = closure52(v2475, v2481)
                        let v2484 : (unit -> string) = method41()
                        method3(v2482, v2483, v2484)
                        return struct (v2475, v2481) 
                        }
                        |> fun x -> _v2358 <- Some x
                        let v2485 : Async<struct (int32 * string)> = _v2358 |> Option.get
                        v2485
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2486 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2486
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2487 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2487
#endif
                        |> fun x -> _v2353 <- Some x
                        let v2488 : Async<struct (int32 * string)> = _v2353.Value
                        v2488
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2489 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2489
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2490 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2490
#endif
                        |> fun x -> _v2348 <- Some x
                        let v2491 : Async<struct (int32 * string)> = _v2348.Value
                        let v2492 : struct (int32 * string) option = None
                        let v2493 : bool = true in let mutable _v2492 = v2492
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v2494 : int32, v2495 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2494, v2495)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v2496 : int32, v2497 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2496, v2497)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2498 : int32, v2499 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2498, v2499)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2500 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v2501 : int32, v2502 : string) = v2500 v2491
                        struct (v2501, v2502)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2503 : int32, v2504 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2503, v2504)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v2505 : int32, v2506 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2505, v2506)
#endif
                        |> fun x -> _v2492 <- Some x
                        let struct (v2507 : int32, v2508 : string) = _v2492.Value
                        struct (v2507, v2508)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2509 : int32, v2510 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2509, v2510)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v2511 : int32, v2512 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2511, v2512)
#endif
                        |> fun x -> _v2309 <- Some x
                        let struct (v2513 : int32, v2514 : string) = _v2309.Value
                        let v2515 : bool option = None
                        let v2516 : bool = true in let mutable _v2515 = v2515
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2517 : string = "cfg!(windows)"
                        let v2518 : bool = Fable.Core.RustInterop.emitRustExpr () v2517
                        v2518
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2519 : bool = null |> unbox<bool>
                        v2519
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2520 : bool = null |> unbox<bool>
                        v2520
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2521 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                        let v2522 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                        let v2523 : bool = v2522 v2521
                        v2523
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2524 : bool = null |> unbox<bool>
                        v2524
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2525 : bool = null |> unbox<bool>
                        v2525
#endif
                        |> fun x -> _v2515 <- Some x
                        let v2526 : bool = _v2515.Value
                        let v2527 : bool = v2526 = false
                        let v2548 : string =
                            if v2527 then
                                v2223
                            else
                                let v2528 : string option = None
                                let v2529 : bool = true in let mutable _v2528 = v2528
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v2530 : string = method16()
                                let v2531 : string = method17(v2223)
                                let v2532 : string = method18()
                                let v2533 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                                let v2534 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v2530, v2531, v2532) v2533
                                let v2535 : string = "String::from($0)"
                                let v2536 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2534 v2535
                                let v2537 : string = "fable_library_rust::String_::fromString($0)"
                                let v2538 : string = Fable.Core.RustInterop.emitRustExpr v2536 v2537
                                v2538
#endif
                                
#if FABLE_COMPILER_RUST && WASM
                                let v2539 : string = null |> unbox<string>
                                v2539
#endif
                                
#if FABLE_COMPILER_RUST && CONTRACT
                                let v2540 : string = null |> unbox<string>
                                v2540
#endif
                                
#if !FABLE_COMPILER && !WASM && !CONTRACT
                                let v2541 : string = "^\\\\\\\\\\?\\\\"
                                let v2542 : string = System.Text.RegularExpressions.Regex.Replace (v2223, v2541, v233)
                                v2542
#endif
                                
#if FABLE_COMPILER_TYPESCRIPT
                                let v2543 : string = null |> unbox<string>
                                v2543
#endif
                                
#if FABLE_COMPILER_PYTHON
                                let v2544 : string = null |> unbox<string>
                                v2544
#endif
                                |> fun x -> _v2528 <- Some x
                                let v2545 : string = _v2528.Value
                                let v2546 : string = $"{v2545.[0] |> string |> _.ToLower()}{v2545.[1..]}"
                                let v2547 : string = v2546.Replace (v235, v236)
                                v2547
                        let v2549 : System.Threading.CancellationToken option = None
                        let v2550 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v2551 : string option = None
                        let v2552 : string = $"pwsh -c \"(Get-FileHash \\\"{v2548}\\\" -Algorithm SHA256).Hash\""
                        let v2553 : struct (int32 * string) option = None
                        let v2554 : bool = true in let mutable _v2553 = v2553
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v2555 : string, v2556 : string) = method32()
                        let v2557 : int32 = v2552.Length
                        let v2558 : (char []) = Array.zeroCreate<char> (v2557)
                        let v2559 : Mut5 = {l0 = 0} : Mut5
                        while method20(v2557, v2559) do
                            let v2561 : int32 = v2559.l0
                            let v2562 : char = v2552.[int v2561]
                            v2558.[int v2561] <- v2562
                            let v2563 : int32 = v2561 + 1
                            v2559.l0 <- v2563
                            ()
                        let v2564 : ((char []) -> char list) = Array.toList
                        let v2565 : char list = v2564 v2558
                        let v2566 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2567 : (char -> (UH0 -> UH0)) = method33()
                        let v2568 : (char list -> (UH0 -> UH0)) = v2566 v2567
                        let v2569 : (UH0 -> UH0) = v2568 v2565
                        let v2570 : UH0 = UH0_0
                        let v2571 : UH0 = v2569 v2570
                        let v2572 : US8 = US8_0
                        let struct (v2573 : string, v2574 : string) = method34(v2556, v2555, v2571, v2572)
                        let v2575 : (string []) = method35(v2574)
                        let v2576 : string = "$0.to_vec()"
                        let v2577 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v2575 v2576
                        let v2578 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v2579 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2577, v381) v2578
                        let v2580 : US0 = US0_1
                        let v2581 : (unit -> string) = closure28(v2549, v2552, v2550, v2551, v2573, v2579)
                        let v2582 : (unit -> string) = method41()
                        method3(v2580, v2581, v2582)
                        let v2583 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method42(v2549, v2552, v2550, v2551, v2573, v2579)
                        let v2584 : string = "futures_lite::future::block_on($0)"
                        let v2585 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v2583 v2584
                        let (a, b) = v2585
                        let v2586 : int32 = a
                        let v2587 : string = b
                        struct (v2586, v2587)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v2588 : int32, v2589 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2588, v2589)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2590 : int32, v2591 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2590, v2591)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2592 : Async<struct (int32 * string)> option = None
                        let v2593 : bool = true in let mutable _v2592 = v2592
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2594 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2594
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2595 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2595
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2596 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2596
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2597 : Async<struct (int32 * string)> option = None
                        let v2598 : bool = true in let mutable _v2597 = v2597
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2599 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2599
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2600 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2600
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2601 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2601
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2602 : Async<struct (int32 * string)> option = None
                        let mutable _v2602 = v2602
                        async {
                        let struct (v2603 : string, v2604 : string) = method32()
                        let v2605 : (char []) = Array.zeroCreate<char> (v2557)
                        let v2606 : Mut5 = {l0 = 0} : Mut5
                        while method20(v2557, v2606) do
                            let v2608 : int32 = v2606.l0
                            let v2609 : char = v2552.[int v2608]
                            v2605.[int v2608] <- v2609
                            let v2610 : int32 = v2608 + 1
                            v2606.l0 <- v2610
                            ()
                        let v2611 : ((char []) -> char list) = Array.toList
                        let v2612 : char list = v2611 v2605
                        let v2613 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2614 : (char -> (UH0 -> UH0)) = method33()
                        let v2615 : (char list -> (UH0 -> UH0)) = v2613 v2614
                        let v2616 : (UH0 -> UH0) = v2615 v2612
                        let v2617 : UH0 = UH0_0
                        let v2618 : UH0 = v2616 v2617
                        let v2619 : US8 = US8_0
                        let struct (v2620 : string, v2621 : string) = method34(v2604, v2603, v2618, v2619)
                        let v2622 : (string -> US7) = method36()
                        let v2623 : US7 = US7_1
                        let v2624 : US7 = v2551 |> Option.map v2622 |> Option.defaultValue v2623 
                        let v2627 : string =
                            match v2624 with
                            | US7_1 -> (* None *)
                                v233
                            | US7_0(v2625) -> (* Some *)
                                v2625
                        let v2628 : US0 = US0_1
                        let v2629 : (unit -> string) = closure44(v2549, v2552, v2550, v2551)
                        let v2630 : (unit -> string) = method41()
                        method3(v2628, v2629, v2630)
                        let v2631 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v2632 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v2621, StandardOutputEncoding = v2631, WorkingDirectory = v2627, FileName = v2620, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v2633 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v2632)
                        use v2633 = v2633 
                        let v2634 : System.Diagnostics.Process = v2633 
                        let v2635 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v2636 : System.Collections.Concurrent.ConcurrentStack<string> = v2635 ()
                        let v2637 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v2549, v2552, v2550, v2551, v2634, v2636)
                        v2634.OutputDataReceived.Add v2637 
                        let v2638 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v2549, v2552, v2550, v2551, v2634, v2636)
                        v2634.ErrorDataReceived.Add v2638 
                        let v2639 : (unit -> bool) = v2634.Start
                        let v2640 : bool = v2639 ()
                        let v2641 : bool = v2640 = false
                        if v2641 then
                            let v2642 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v2642
                        let v2643 : (unit -> unit) = v2634.BeginErrorReadLine
                        v2643 ()
                        let v2644 : (unit -> unit) = v2634.BeginOutputReadLine
                        v2644 ()
                        let v2645 : (System.Threading.CancellationToken -> US16) = method59()
                        let v2646 : US16 = US16_1
                        let v2647 : US16 = v2549 |> Option.map v2645 |> Option.defaultValue v2646 
                        let v2651 : System.Threading.CancellationToken =
                            match v2647 with
                            | US16_1 -> (* None *)
                                let v2649 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v2649
                            | US16_0(v2648) -> (* Some *)
                                v2648
                        let v2652 : Async<System.Threading.CancellationToken> option = None
                        let v2653 : bool = true in let mutable _v2652 = v2652
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2654 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2654
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2655 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2655
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2656 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2656
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2657 : Async<System.Threading.CancellationToken> option = None
                        let v2658 : bool = true in let mutable _v2657 = v2657
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2659 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2659
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2660 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2660
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2661 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2661
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2662 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v2662 = v2662
                        async {
                        let v2663 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v2663 = v2663 
                        let v2664 : System.Threading.CancellationToken = v2663 
                        let v2665 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v2666 : (System.Threading.CancellationToken []) = [|v2664; v2665; v2651|]
                        let v2667 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v2668 : System.Threading.CancellationTokenSource = v2667 v2666
                        let v2669 : System.Threading.CancellationToken = v2668.Token
                        return v2669 
                        }
                        |> fun x -> _v2662 <- Some x
                        let v2670 : Async<System.Threading.CancellationToken> = _v2662 |> Option.get
                        v2670
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2671 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2671
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2672 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2672
#endif
                        |> fun x -> _v2657 <- Some x
                        let v2673 : Async<System.Threading.CancellationToken> = _v2657.Value
                        v2673
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2674 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2674
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2675 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2675
#endif
                        |> fun x -> _v2652 <- Some x
                        let v2676 : Async<System.Threading.CancellationToken> = _v2652.Value
                        let! v2676 = v2676 
                        let v2677 : System.Threading.CancellationToken = v2676 
                        let v2678 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v2677.Register
                        let v2679 : (unit -> unit) = closure50(v2634)
                        let v2680 : System.Threading.CancellationTokenRegistration = v2678 v2679
                        use v2680 = v2680 
                        let v2681 : System.Threading.CancellationTokenRegistration = v2680 
                        let v2682 : Async<int32> option = None
                        let v2683 : bool = true in let mutable _v2682 = v2682
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2684 : Async<int32> = null |> unbox<Async<int32>>
                        v2684
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2685 : Async<int32> = null |> unbox<Async<int32>>
                        v2685
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2686 : Async<int32> = null |> unbox<Async<int32>>
                        v2686
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2687 : Async<int32> option = None
                        let mutable _v2687 = v2687
                        async {
                        try
                        let v2688 : System.Threading.Tasks.Task = v2634.WaitForExitAsync v2677 
                        let v2689 : Async<unit> option = None
                        let v2690 : bool = true in let mutable _v2689 = v2689
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2691 : Async<unit> = null |> unbox<Async<unit>>
                        v2691
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2692 : Async<unit> = null |> unbox<Async<unit>>
                        v2692
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2693 : Async<unit> = null |> unbox<Async<unit>>
                        v2693
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2694 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v2695 : Async<unit> = v2694 v2688
                        v2695
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2696 : Async<unit> = null |> unbox<Async<unit>>
                        v2696
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2697 : Async<unit> = null |> unbox<Async<unit>>
                        v2697
#endif
                        |> fun x -> _v2689 <- Some x
                        let v2698 : Async<unit> = _v2689.Value
                        do! v2698 
                        let v2699 : int32 = v2634.ExitCode
                        return v2699 
                        with ex ->
                        let v2700 : exn = ex
                        let v2701 : string option = None
                        let v2702 : bool = true in let mutable _v2701 = v2701
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2703 : string = $"%A{v2700}"
                        v2703
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2704 : string = $"%A{v2700}"
                        v2704
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2705 : string = $"%A{v2700}"
                        v2705
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2706 : string = $"{v2700.GetType ()}: {v2700.Message}"
                        v2706
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2707 : string = $"%A{v2700}"
                        v2707
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2708 : string = $"%A{v2700}"
                        v2708
#endif
                        |> fun x -> _v2701 <- Some x
                        let v2709 : string = _v2701.Value
                        let v2710 : (string -> unit) = v2636.Push
                        v2710 v2709
                        let v2711 : System.Threading.Tasks.TaskCanceledException = v2700 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v2712 : US0 = US0_3
                        let v2713 : (unit -> string) = closure51(v2711)
                        let v2714 : (unit -> string) = method41()
                        method3(v2712, v2713, v2714)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v2687 <- Some x
                        let v2715 : Async<int32> = _v2687 |> Option.get
                        v2715
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2716 : Async<int32> = null |> unbox<Async<int32>>
                        v2716
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2717 : Async<int32> = null |> unbox<Async<int32>>
                        v2717
#endif
                        |> fun x -> _v2682 <- Some x
                        let v2718 : Async<int32> = _v2682.Value
                        let! v2718 = v2718 
                        let v2719 : int32 = v2718 
                        let v2720 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v2721 : string seq = v2720 v2636
                        let v2722 : string = method60()
                        let v2723 : (string -> (string seq -> string)) = String.concat
                        let v2724 : (string seq -> string) = v2723 v2722
                        let v2725 : string = v2724 v2721
                        let v2726 : US0 = US0_1
                        let v2727 : (unit -> string) = closure52(v2719, v2725)
                        let v2728 : (unit -> string) = method41()
                        method3(v2726, v2727, v2728)
                        return struct (v2719, v2725) 
                        }
                        |> fun x -> _v2602 <- Some x
                        let v2729 : Async<struct (int32 * string)> = _v2602 |> Option.get
                        v2729
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2730 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2730
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2731 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2731
#endif
                        |> fun x -> _v2597 <- Some x
                        let v2732 : Async<struct (int32 * string)> = _v2597.Value
                        v2732
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2733 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2733
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2734 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2734
#endif
                        |> fun x -> _v2592 <- Some x
                        let v2735 : Async<struct (int32 * string)> = _v2592.Value
                        let v2736 : struct (int32 * string) option = None
                        let v2737 : bool = true in let mutable _v2736 = v2736
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v2738 : int32, v2739 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2738, v2739)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v2740 : int32, v2741 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2740, v2741)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2742 : int32, v2743 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2742, v2743)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2744 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v2745 : int32, v2746 : string) = v2744 v2735
                        struct (v2745, v2746)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2747 : int32, v2748 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2747, v2748)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v2749 : int32, v2750 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2749, v2750)
#endif
                        |> fun x -> _v2736 <- Some x
                        let struct (v2751 : int32, v2752 : string) = _v2736.Value
                        struct (v2751, v2752)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2753 : int32, v2754 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2753, v2754)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v2755 : int32, v2756 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2755, v2756)
#endif
                        |> fun x -> _v2553 <- Some x
                        let struct (v2757 : int32, v2758 : string) = _v2553.Value
                        let v2759 : bool = v2514 = v2758
                        v2759
                    else
                        false
                let v2761 : bool = v2760 = false
                let v2994 : US17 =
                    if v2761 then
                        let v2762 : string = $"crowbook --single \"{v637}\" --output \"{v2222}\" --to {v2221} --set rendering.num_depth 6 html.css.add \\\"''' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} '''\\\""
                        let v2763 : System.Threading.CancellationToken option = None
                        let v2764 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v2765 : string option = None
                        let v2766 : string option = Some v1 
                        let v2767 : struct (int32 * string) option = None
                        let v2768 : bool = true in let mutable _v2767 = v2767
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v2769 : string, v2770 : string) = method32()
                        let v2771 : int32 = v2762.Length
                        let v2772 : (char []) = Array.zeroCreate<char> (v2771)
                        let v2773 : Mut5 = {l0 = 0} : Mut5
                        while method20(v2771, v2773) do
                            let v2775 : int32 = v2773.l0
                            let v2776 : char = v2762.[int v2775]
                            v2772.[int v2775] <- v2776
                            let v2777 : int32 = v2775 + 1
                            v2773.l0 <- v2777
                            ()
                        let v2778 : ((char []) -> char list) = Array.toList
                        let v2779 : char list = v2778 v2772
                        let v2780 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2781 : (char -> (UH0 -> UH0)) = method33()
                        let v2782 : (char list -> (UH0 -> UH0)) = v2780 v2781
                        let v2783 : (UH0 -> UH0) = v2782 v2779
                        let v2784 : UH0 = UH0_0
                        let v2785 : UH0 = v2783 v2784
                        let v2786 : US8 = US8_0
                        let struct (v2787 : string, v2788 : string) = method34(v2770, v2769, v2785, v2786)
                        let v2789 : (string []) = method35(v2788)
                        let v2790 : string = "$0.to_vec()"
                        let v2791 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v2789 v2790
                        let v2792 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v2793 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2791, v381) v2792
                        let v2794 : US0 = US0_1
                        let v2795 : (unit -> string) = closure28(v2763, v2762, v2764, v2766, v2787, v2793)
                        let v2796 : (unit -> string) = method41()
                        method3(v2794, v2795, v2796)
                        let v2797 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method42(v2763, v2762, v2764, v2766, v2787, v2793)
                        let v2798 : string = "futures_lite::future::block_on($0)"
                        let v2799 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v2797 v2798
                        let (a, b) = v2799
                        let v2800 : int32 = a
                        let v2801 : string = b
                        struct (v2800, v2801)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v2802 : int32, v2803 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2802, v2803)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2804 : int32, v2805 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2804, v2805)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2806 : Async<struct (int32 * string)> option = None
                        let v2807 : bool = true in let mutable _v2806 = v2806
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2808 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2808
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2809 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2809
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2810 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2810
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2811 : Async<struct (int32 * string)> option = None
                        let v2812 : bool = true in let mutable _v2811 = v2811
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2813 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2813
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2814 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2814
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2815 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2815
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2816 : Async<struct (int32 * string)> option = None
                        let mutable _v2816 = v2816
                        async {
                        let struct (v2817 : string, v2818 : string) = method32()
                        let v2819 : (char []) = Array.zeroCreate<char> (v2771)
                        let v2820 : Mut5 = {l0 = 0} : Mut5
                        while method20(v2771, v2820) do
                            let v2822 : int32 = v2820.l0
                            let v2823 : char = v2762.[int v2822]
                            v2819.[int v2822] <- v2823
                            let v2824 : int32 = v2822 + 1
                            v2820.l0 <- v2824
                            ()
                        let v2825 : ((char []) -> char list) = Array.toList
                        let v2826 : char list = v2825 v2819
                        let v2827 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2828 : (char -> (UH0 -> UH0)) = method33()
                        let v2829 : (char list -> (UH0 -> UH0)) = v2827 v2828
                        let v2830 : (UH0 -> UH0) = v2829 v2826
                        let v2831 : UH0 = UH0_0
                        let v2832 : UH0 = v2830 v2831
                        let v2833 : US8 = US8_0
                        let struct (v2834 : string, v2835 : string) = method34(v2818, v2817, v2832, v2833)
                        let v2836 : (string -> US7) = method36()
                        let v2837 : US7 = US7_1
                        let v2838 : US7 = v2766 |> Option.map v2836 |> Option.defaultValue v2837 
                        let v2841 : string =
                            match v2838 with
                            | US7_1 -> (* None *)
                                v233
                            | US7_0(v2839) -> (* Some *)
                                v2839
                        let v2842 : US0 = US0_1
                        let v2843 : (unit -> string) = closure44(v2763, v2762, v2764, v2766)
                        let v2844 : (unit -> string) = method41()
                        method3(v2842, v2843, v2844)
                        let v2845 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v2846 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v2835, StandardOutputEncoding = v2845, WorkingDirectory = v2841, FileName = v2834, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v2847 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v2846)
                        use v2847 = v2847 
                        let v2848 : System.Diagnostics.Process = v2847 
                        let v2849 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v2850 : System.Collections.Concurrent.ConcurrentStack<string> = v2849 ()
                        let v2851 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v2763, v2762, v2764, v2766, v2848, v2850)
                        v2848.OutputDataReceived.Add v2851 
                        let v2852 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v2763, v2762, v2764, v2766, v2848, v2850)
                        v2848.ErrorDataReceived.Add v2852 
                        let v2853 : (unit -> bool) = v2848.Start
                        let v2854 : bool = v2853 ()
                        let v2855 : bool = v2854 = false
                        if v2855 then
                            let v2856 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v2856
                        let v2857 : (unit -> unit) = v2848.BeginErrorReadLine
                        v2857 ()
                        let v2858 : (unit -> unit) = v2848.BeginOutputReadLine
                        v2858 ()
                        let v2859 : (System.Threading.CancellationToken -> US16) = method59()
                        let v2860 : US16 = US16_1
                        let v2861 : US16 = v2763 |> Option.map v2859 |> Option.defaultValue v2860 
                        let v2865 : System.Threading.CancellationToken =
                            match v2861 with
                            | US16_1 -> (* None *)
                                let v2863 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v2863
                            | US16_0(v2862) -> (* Some *)
                                v2862
                        let v2866 : Async<System.Threading.CancellationToken> option = None
                        let v2867 : bool = true in let mutable _v2866 = v2866
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2868 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2868
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2869 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2869
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2870 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2870
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2871 : Async<System.Threading.CancellationToken> option = None
                        let v2872 : bool = true in let mutable _v2871 = v2871
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2873 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2873
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2874 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2874
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2875 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2875
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2876 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v2876 = v2876
                        async {
                        let v2877 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v2877 = v2877 
                        let v2878 : System.Threading.CancellationToken = v2877 
                        let v2879 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v2880 : (System.Threading.CancellationToken []) = [|v2878; v2879; v2865|]
                        let v2881 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v2882 : System.Threading.CancellationTokenSource = v2881 v2880
                        let v2883 : System.Threading.CancellationToken = v2882.Token
                        return v2883 
                        }
                        |> fun x -> _v2876 <- Some x
                        let v2884 : Async<System.Threading.CancellationToken> = _v2876 |> Option.get
                        v2884
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2885 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2885
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2886 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2886
#endif
                        |> fun x -> _v2871 <- Some x
                        let v2887 : Async<System.Threading.CancellationToken> = _v2871.Value
                        v2887
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2888 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2888
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2889 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2889
#endif
                        |> fun x -> _v2866 <- Some x
                        let v2890 : Async<System.Threading.CancellationToken> = _v2866.Value
                        let! v2890 = v2890 
                        let v2891 : System.Threading.CancellationToken = v2890 
                        let v2892 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v2891.Register
                        let v2893 : (unit -> unit) = closure50(v2848)
                        let v2894 : System.Threading.CancellationTokenRegistration = v2892 v2893
                        use v2894 = v2894 
                        let v2895 : System.Threading.CancellationTokenRegistration = v2894 
                        let v2896 : Async<int32> option = None
                        let v2897 : bool = true in let mutable _v2896 = v2896
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2898 : Async<int32> = null |> unbox<Async<int32>>
                        v2898
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2899 : Async<int32> = null |> unbox<Async<int32>>
                        v2899
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2900 : Async<int32> = null |> unbox<Async<int32>>
                        v2900
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2901 : Async<int32> option = None
                        let mutable _v2901 = v2901
                        async {
                        try
                        let v2902 : System.Threading.Tasks.Task = v2848.WaitForExitAsync v2891 
                        let v2903 : Async<unit> option = None
                        let v2904 : bool = true in let mutable _v2903 = v2903
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2905 : Async<unit> = null |> unbox<Async<unit>>
                        v2905
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2906 : Async<unit> = null |> unbox<Async<unit>>
                        v2906
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2907 : Async<unit> = null |> unbox<Async<unit>>
                        v2907
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2908 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v2909 : Async<unit> = v2908 v2902
                        v2909
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2910 : Async<unit> = null |> unbox<Async<unit>>
                        v2910
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2911 : Async<unit> = null |> unbox<Async<unit>>
                        v2911
#endif
                        |> fun x -> _v2903 <- Some x
                        let v2912 : Async<unit> = _v2903.Value
                        do! v2912 
                        let v2913 : int32 = v2848.ExitCode
                        return v2913 
                        with ex ->
                        let v2914 : exn = ex
                        let v2915 : string option = None
                        let v2916 : bool = true in let mutable _v2915 = v2915
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2917 : string = $"%A{v2914}"
                        v2917
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v2918 : string = $"%A{v2914}"
                        v2918
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2919 : string = $"%A{v2914}"
                        v2919
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2920 : string = $"{v2914.GetType ()}: {v2914.Message}"
                        v2920
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2921 : string = $"%A{v2914}"
                        v2921
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2922 : string = $"%A{v2914}"
                        v2922
#endif
                        |> fun x -> _v2915 <- Some x
                        let v2923 : string = _v2915.Value
                        let v2924 : (string -> unit) = v2850.Push
                        v2924 v2923
                        let v2925 : System.Threading.Tasks.TaskCanceledException = v2914 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v2926 : US0 = US0_3
                        let v2927 : (unit -> string) = closure51(v2925)
                        let v2928 : (unit -> string) = method41()
                        method3(v2926, v2927, v2928)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v2901 <- Some x
                        let v2929 : Async<int32> = _v2901 |> Option.get
                        v2929
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2930 : Async<int32> = null |> unbox<Async<int32>>
                        v2930
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2931 : Async<int32> = null |> unbox<Async<int32>>
                        v2931
#endif
                        |> fun x -> _v2896 <- Some x
                        let v2932 : Async<int32> = _v2896.Value
                        let! v2932 = v2932 
                        let v2933 : int32 = v2932 
                        let v2934 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v2935 : string seq = v2934 v2850
                        let v2936 : string = method60()
                        let v2937 : (string -> (string seq -> string)) = String.concat
                        let v2938 : (string seq -> string) = v2937 v2936
                        let v2939 : string = v2938 v2935
                        let v2940 : US0 = US0_1
                        let v2941 : (unit -> string) = closure52(v2933, v2939)
                        let v2942 : (unit -> string) = method41()
                        method3(v2940, v2941, v2942)
                        return struct (v2933, v2939) 
                        }
                        |> fun x -> _v2816 <- Some x
                        let v2943 : Async<struct (int32 * string)> = _v2816 |> Option.get
                        v2943
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2944 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2944
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2945 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2945
#endif
                        |> fun x -> _v2811 <- Some x
                        let v2946 : Async<struct (int32 * string)> = _v2811.Value
                        v2946
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v2947 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2947
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v2948 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2948
#endif
                        |> fun x -> _v2806 <- Some x
                        let v2949 : Async<struct (int32 * string)> = _v2806.Value
                        let v2950 : struct (int32 * string) option = None
                        let v2951 : bool = true in let mutable _v2950 = v2950
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v2952 : int32, v2953 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2952, v2953)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v2954 : int32, v2955 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2954, v2955)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2956 : int32, v2957 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2956, v2957)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v2958 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v2959 : int32, v2960 : string) = v2958 v2949
                        struct (v2959, v2960)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2961 : int32, v2962 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2961, v2962)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v2963 : int32, v2964 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2963, v2964)
#endif
                        |> fun x -> _v2950 <- Some x
                        let struct (v2965 : int32, v2966 : string) = _v2950.Value
                        struct (v2965, v2966)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2967 : int32, v2968 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2967, v2968)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v2969 : int32, v2970 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2969, v2970)
#endif
                        |> fun x -> _v2767 <- Some x
                        let struct (v2971 : int32, v2972 : string) = _v2767.Value
                        let v2973 : bool = v2971 <> 0
                        let v2976 : bool =
                            if v2973 then
                                true
                            else
                                let v2974 : string = "ERROR"
                                let v2975 : bool = v2972.Contains v2974
                                v2975
                        if v2976 then
                            let v2977 : US0 = US0_2
                            let v2978 : (unit -> string) = closure53()
                            let v2979 : (unit -> string) = closure54(v2972, v2971)
                            method3(v2977, v2978, v2979)
                            let v2980 : (string * string) = v2222, v2972
                            let v2981 : Result<string, (string * string)> = Error v2980
                            US17_0(v2981)
                        else
                            let v2983 : unit option = None
                            let v2984 : bool = true in let mutable _v2983 = v2983
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v2985 : string = method61(v2223)
                            let v2986 : string = "std::fs::copy(&*v2222, &*v2985)"
                            let v2987 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v2986
                            let v2988 : string = "$0.unwrap()"
                            let v2989 : uint64 = Fable.Core.RustInterop.emitRustExpr v2987 v2988
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
                            System.IO.File.Copy (v2222, v2223, true)
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
                            |> fun x -> _v2983 <- Some x
                            _v2983.Value
                            let v2990 : Result<string, (string * string)> = Ok v2222
                            US17_0(v2990)
                    else
                        US17_1
                let v2999 : Result<string, (string * string)> option =
                    match v2994 with
                    | US17_1 -> (* None *)
                        let v2997 : Result<string, (string * string)> option = None
                        v2997
                    | US17_0(v2995) -> (* Some *)
                        let v2996 : Result<string, (string * string)> option = Some v2995 
                        v2996
                let v3000 : string = "html"
                let v3001 : string = $"{v637}.{v3000}"
                let v3002 : string = $"{v1170}.{v3000}"
                let v3003 : bool option = None
                let v3004 : bool = true in let mutable _v3003 = v3003
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3005 : string = method13(v3001)
                let v3006 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                let v3007 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3005 v3006
                let v3008 : string = "String::from($0)"
                let v3009 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3007 v3008
                let v3010 : string = "std::path::PathBuf::from($0)"
                let v3011 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v3009 v3010
                let v3012 : string = "$0.exists()"
                let v3013 : bool = Fable.Core.RustInterop.emitRustExpr v3011 v3012
                let v3016 : bool =
                    if v3013 then
                        let v3014 : string = "$0.is_file()"
                        let v3015 : bool = Fable.Core.RustInterop.emitRustExpr v3011 v3014
                        v3015
                    else
                        false
                v3016
#endif
                
#if FABLE_COMPILER_RUST && WASM
                let v3017 : bool = null |> unbox<bool>
                v3017
#endif
                
#if FABLE_COMPILER_RUST && CONTRACT
                let v3018 : bool = null |> unbox<bool>
                v3018
#endif
                
#if !FABLE_COMPILER && !WASM && !CONTRACT
                let v3019 : (string -> bool) = System.IO.File.Exists
                let v3020 : bool = v3019 v3001
                v3020
#endif
                
#if FABLE_COMPILER_TYPESCRIPT
                let v3021 : IFsExistsSync = Fable.Core.JsInterop.importAll v1189
                let v3022 : string = "v3021.existsSync($0)"
                let v3023 : bool = Fable.Core.JsInterop.emitJsExpr v3001 v3022
                v3023
#endif
                
#if FABLE_COMPILER_PYTHON
                let v3024 : bool = null |> unbox<bool>
                v3024
#endif
                |> fun x -> _v3003 <- Some x
                let v3025 : bool = _v3003.Value
                let v3049 : bool =
                    if v3025 then
                        let v3026 : bool option = None
                        let v3027 : bool = true in let mutable _v3026 = v3026
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3028 : string = method13(v3002)
                        let v3029 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                        let v3030 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3028 v3029
                        let v3031 : string = "String::from($0)"
                        let v3032 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3030 v3031
                        let v3033 : string = "std::path::PathBuf::from($0)"
                        let v3034 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v3032 v3033
                        let v3035 : string = "$0.exists()"
                        let v3036 : bool = Fable.Core.RustInterop.emitRustExpr v3034 v3035
                        let v3039 : bool =
                            if v3036 then
                                let v3037 : string = "$0.is_file()"
                                let v3038 : bool = Fable.Core.RustInterop.emitRustExpr v3034 v3037
                                v3038
                            else
                                false
                        v3039
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3040 : bool = null |> unbox<bool>
                        v3040
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3041 : bool = null |> unbox<bool>
                        v3041
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3042 : (string -> bool) = System.IO.File.Exists
                        let v3043 : bool = v3042 v3002
                        v3043
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3044 : IFsExistsSync = Fable.Core.JsInterop.importAll v1189
                        let v3045 : string = "v3044.existsSync($0)"
                        let v3046 : bool = Fable.Core.JsInterop.emitJsExpr v3002 v3045
                        v3046
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3047 : bool = null |> unbox<bool>
                        v3047
#endif
                        |> fun x -> _v3026 <- Some x
                        let v3048 : bool = _v3026.Value
                        v3048
                    else
                        false
                let v3539 : bool =
                    if v3049 then
                        let v3050 : bool option = None
                        let v3051 : bool = true in let mutable _v3050 = v3050
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3052 : string = "cfg!(windows)"
                        let v3053 : bool = Fable.Core.RustInterop.emitRustExpr () v3052
                        v3053
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3054 : bool = null |> unbox<bool>
                        v3054
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3055 : bool = null |> unbox<bool>
                        v3055
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3056 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                        let v3057 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                        let v3058 : bool = v3057 v3056
                        v3058
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3059 : bool = null |> unbox<bool>
                        v3059
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3060 : bool = null |> unbox<bool>
                        v3060
#endif
                        |> fun x -> _v3050 <- Some x
                        let v3061 : bool = _v3050.Value
                        let v3062 : bool = v3061 = false
                        let v3083 : string =
                            if v3062 then
                                v3001
                            else
                                let v3063 : string option = None
                                let v3064 : bool = true in let mutable _v3063 = v3063
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v3065 : string = method16()
                                let v3066 : string = method17(v3001)
                                let v3067 : string = method18()
                                let v3068 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                                let v3069 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v3065, v3066, v3067) v3068
                                let v3070 : string = "String::from($0)"
                                let v3071 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3069 v3070
                                let v3072 : string = "fable_library_rust::String_::fromString($0)"
                                let v3073 : string = Fable.Core.RustInterop.emitRustExpr v3071 v3072
                                v3073
#endif
                                
#if FABLE_COMPILER_RUST && WASM
                                let v3074 : string = null |> unbox<string>
                                v3074
#endif
                                
#if FABLE_COMPILER_RUST && CONTRACT
                                let v3075 : string = null |> unbox<string>
                                v3075
#endif
                                
#if !FABLE_COMPILER && !WASM && !CONTRACT
                                let v3076 : string = "^\\\\\\\\\\?\\\\"
                                let v3077 : string = System.Text.RegularExpressions.Regex.Replace (v3001, v3076, v233)
                                v3077
#endif
                                
#if FABLE_COMPILER_TYPESCRIPT
                                let v3078 : string = null |> unbox<string>
                                v3078
#endif
                                
#if FABLE_COMPILER_PYTHON
                                let v3079 : string = null |> unbox<string>
                                v3079
#endif
                                |> fun x -> _v3063 <- Some x
                                let v3080 : string = _v3063.Value
                                let v3081 : string = $"{v3080.[0] |> string |> _.ToLower()}{v3080.[1..]}"
                                let v3082 : string = v3081.Replace (v235, v236)
                                v3082
                        let v3084 : System.Threading.CancellationToken option = None
                        let v3085 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v3086 : string option = None
                        let v3087 : string = $"pwsh -c \"(Get-FileHash \\\"{v3083}\\\" -Algorithm SHA256).Hash\""
                        let v3088 : struct (int32 * string) option = None
                        let v3089 : bool = true in let mutable _v3088 = v3088
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v3090 : string, v3091 : string) = method32()
                        let v3092 : int32 = v3087.Length
                        let v3093 : (char []) = Array.zeroCreate<char> (v3092)
                        let v3094 : Mut5 = {l0 = 0} : Mut5
                        while method20(v3092, v3094) do
                            let v3096 : int32 = v3094.l0
                            let v3097 : char = v3087.[int v3096]
                            v3093.[int v3096] <- v3097
                            let v3098 : int32 = v3096 + 1
                            v3094.l0 <- v3098
                            ()
                        let v3099 : ((char []) -> char list) = Array.toList
                        let v3100 : char list = v3099 v3093
                        let v3101 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v3102 : (char -> (UH0 -> UH0)) = method33()
                        let v3103 : (char list -> (UH0 -> UH0)) = v3101 v3102
                        let v3104 : (UH0 -> UH0) = v3103 v3100
                        let v3105 : UH0 = UH0_0
                        let v3106 : UH0 = v3104 v3105
                        let v3107 : US8 = US8_0
                        let struct (v3108 : string, v3109 : string) = method34(v3091, v3090, v3106, v3107)
                        let v3110 : (string []) = method35(v3109)
                        let v3111 : string = "$0.to_vec()"
                        let v3112 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v3110 v3111
                        let v3113 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v3114 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3112, v381) v3113
                        let v3115 : US0 = US0_1
                        let v3116 : (unit -> string) = closure28(v3084, v3087, v3085, v3086, v3108, v3114)
                        let v3117 : (unit -> string) = method41()
                        method3(v3115, v3116, v3117)
                        let v3118 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method42(v3084, v3087, v3085, v3086, v3108, v3114)
                        let v3119 : string = "futures_lite::future::block_on($0)"
                        let v3120 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v3118 v3119
                        let (a, b) = v3120
                        let v3121 : int32 = a
                        let v3122 : string = b
                        struct (v3121, v3122)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v3123 : int32, v3124 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3123, v3124)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v3125 : int32, v3126 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3125, v3126)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3127 : Async<struct (int32 * string)> option = None
                        let v3128 : bool = true in let mutable _v3127 = v3127
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3129 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3129
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3130 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3130
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3131 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3131
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3132 : Async<struct (int32 * string)> option = None
                        let v3133 : bool = true in let mutable _v3132 = v3132
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3134 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3134
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3135 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3135
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3136 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3136
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3137 : Async<struct (int32 * string)> option = None
                        let mutable _v3137 = v3137
                        async {
                        let struct (v3138 : string, v3139 : string) = method32()
                        let v3140 : (char []) = Array.zeroCreate<char> (v3092)
                        let v3141 : Mut5 = {l0 = 0} : Mut5
                        while method20(v3092, v3141) do
                            let v3143 : int32 = v3141.l0
                            let v3144 : char = v3087.[int v3143]
                            v3140.[int v3143] <- v3144
                            let v3145 : int32 = v3143 + 1
                            v3141.l0 <- v3145
                            ()
                        let v3146 : ((char []) -> char list) = Array.toList
                        let v3147 : char list = v3146 v3140
                        let v3148 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v3149 : (char -> (UH0 -> UH0)) = method33()
                        let v3150 : (char list -> (UH0 -> UH0)) = v3148 v3149
                        let v3151 : (UH0 -> UH0) = v3150 v3147
                        let v3152 : UH0 = UH0_0
                        let v3153 : UH0 = v3151 v3152
                        let v3154 : US8 = US8_0
                        let struct (v3155 : string, v3156 : string) = method34(v3139, v3138, v3153, v3154)
                        let v3157 : (string -> US7) = method36()
                        let v3158 : US7 = US7_1
                        let v3159 : US7 = v3086 |> Option.map v3157 |> Option.defaultValue v3158 
                        let v3162 : string =
                            match v3159 with
                            | US7_1 -> (* None *)
                                v233
                            | US7_0(v3160) -> (* Some *)
                                v3160
                        let v3163 : US0 = US0_1
                        let v3164 : (unit -> string) = closure44(v3084, v3087, v3085, v3086)
                        let v3165 : (unit -> string) = method41()
                        method3(v3163, v3164, v3165)
                        let v3166 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v3167 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v3156, StandardOutputEncoding = v3166, WorkingDirectory = v3162, FileName = v3155, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v3168 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v3167)
                        use v3168 = v3168 
                        let v3169 : System.Diagnostics.Process = v3168 
                        let v3170 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v3171 : System.Collections.Concurrent.ConcurrentStack<string> = v3170 ()
                        let v3172 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v3084, v3087, v3085, v3086, v3169, v3171)
                        v3169.OutputDataReceived.Add v3172 
                        let v3173 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v3084, v3087, v3085, v3086, v3169, v3171)
                        v3169.ErrorDataReceived.Add v3173 
                        let v3174 : (unit -> bool) = v3169.Start
                        let v3175 : bool = v3174 ()
                        let v3176 : bool = v3175 = false
                        if v3176 then
                            let v3177 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v3177
                        let v3178 : (unit -> unit) = v3169.BeginErrorReadLine
                        v3178 ()
                        let v3179 : (unit -> unit) = v3169.BeginOutputReadLine
                        v3179 ()
                        let v3180 : (System.Threading.CancellationToken -> US16) = method59()
                        let v3181 : US16 = US16_1
                        let v3182 : US16 = v3084 |> Option.map v3180 |> Option.defaultValue v3181 
                        let v3186 : System.Threading.CancellationToken =
                            match v3182 with
                            | US16_1 -> (* None *)
                                let v3184 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v3184
                            | US16_0(v3183) -> (* Some *)
                                v3183
                        let v3187 : Async<System.Threading.CancellationToken> option = None
                        let v3188 : bool = true in let mutable _v3187 = v3187
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3189 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3189
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3190 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3190
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3191 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3191
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3192 : Async<System.Threading.CancellationToken> option = None
                        let v3193 : bool = true in let mutable _v3192 = v3192
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3194 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3194
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3195 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3195
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3196 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3196
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3197 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v3197 = v3197
                        async {
                        let v3198 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v3198 = v3198 
                        let v3199 : System.Threading.CancellationToken = v3198 
                        let v3200 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v3201 : (System.Threading.CancellationToken []) = [|v3199; v3200; v3186|]
                        let v3202 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v3203 : System.Threading.CancellationTokenSource = v3202 v3201
                        let v3204 : System.Threading.CancellationToken = v3203.Token
                        return v3204 
                        }
                        |> fun x -> _v3197 <- Some x
                        let v3205 : Async<System.Threading.CancellationToken> = _v3197 |> Option.get
                        v3205
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3206 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3206
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3207 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3207
#endif
                        |> fun x -> _v3192 <- Some x
                        let v3208 : Async<System.Threading.CancellationToken> = _v3192.Value
                        v3208
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3209 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3209
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3210 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3210
#endif
                        |> fun x -> _v3187 <- Some x
                        let v3211 : Async<System.Threading.CancellationToken> = _v3187.Value
                        let! v3211 = v3211 
                        let v3212 : System.Threading.CancellationToken = v3211 
                        let v3213 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v3212.Register
                        let v3214 : (unit -> unit) = closure50(v3169)
                        let v3215 : System.Threading.CancellationTokenRegistration = v3213 v3214
                        use v3215 = v3215 
                        let v3216 : System.Threading.CancellationTokenRegistration = v3215 
                        let v3217 : Async<int32> option = None
                        let v3218 : bool = true in let mutable _v3217 = v3217
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3219 : Async<int32> = null |> unbox<Async<int32>>
                        v3219
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3220 : Async<int32> = null |> unbox<Async<int32>>
                        v3220
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3221 : Async<int32> = null |> unbox<Async<int32>>
                        v3221
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3222 : Async<int32> option = None
                        let mutable _v3222 = v3222
                        async {
                        try
                        let v3223 : System.Threading.Tasks.Task = v3169.WaitForExitAsync v3212 
                        let v3224 : Async<unit> option = None
                        let v3225 : bool = true in let mutable _v3224 = v3224
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3226 : Async<unit> = null |> unbox<Async<unit>>
                        v3226
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3227 : Async<unit> = null |> unbox<Async<unit>>
                        v3227
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3228 : Async<unit> = null |> unbox<Async<unit>>
                        v3228
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3229 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v3230 : Async<unit> = v3229 v3223
                        v3230
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3231 : Async<unit> = null |> unbox<Async<unit>>
                        v3231
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3232 : Async<unit> = null |> unbox<Async<unit>>
                        v3232
#endif
                        |> fun x -> _v3224 <- Some x
                        let v3233 : Async<unit> = _v3224.Value
                        do! v3233 
                        let v3234 : int32 = v3169.ExitCode
                        return v3234 
                        with ex ->
                        let v3235 : exn = ex
                        let v3236 : string option = None
                        let v3237 : bool = true in let mutable _v3236 = v3236
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3238 : string = $"%A{v3235}"
                        v3238
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3239 : string = $"%A{v3235}"
                        v3239
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3240 : string = $"%A{v3235}"
                        v3240
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3241 : string = $"{v3235.GetType ()}: {v3235.Message}"
                        v3241
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3242 : string = $"%A{v3235}"
                        v3242
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3243 : string = $"%A{v3235}"
                        v3243
#endif
                        |> fun x -> _v3236 <- Some x
                        let v3244 : string = _v3236.Value
                        let v3245 : (string -> unit) = v3171.Push
                        v3245 v3244
                        let v3246 : System.Threading.Tasks.TaskCanceledException = v3235 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v3247 : US0 = US0_3
                        let v3248 : (unit -> string) = closure51(v3246)
                        let v3249 : (unit -> string) = method41()
                        method3(v3247, v3248, v3249)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v3222 <- Some x
                        let v3250 : Async<int32> = _v3222 |> Option.get
                        v3250
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3251 : Async<int32> = null |> unbox<Async<int32>>
                        v3251
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3252 : Async<int32> = null |> unbox<Async<int32>>
                        v3252
#endif
                        |> fun x -> _v3217 <- Some x
                        let v3253 : Async<int32> = _v3217.Value
                        let! v3253 = v3253 
                        let v3254 : int32 = v3253 
                        let v3255 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v3256 : string seq = v3255 v3171
                        let v3257 : string = method60()
                        let v3258 : (string -> (string seq -> string)) = String.concat
                        let v3259 : (string seq -> string) = v3258 v3257
                        let v3260 : string = v3259 v3256
                        let v3261 : US0 = US0_1
                        let v3262 : (unit -> string) = closure52(v3254, v3260)
                        let v3263 : (unit -> string) = method41()
                        method3(v3261, v3262, v3263)
                        return struct (v3254, v3260) 
                        }
                        |> fun x -> _v3137 <- Some x
                        let v3264 : Async<struct (int32 * string)> = _v3137 |> Option.get
                        v3264
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3265 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3265
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3266 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3266
#endif
                        |> fun x -> _v3132 <- Some x
                        let v3267 : Async<struct (int32 * string)> = _v3132.Value
                        v3267
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3268 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3268
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3269 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3269
#endif
                        |> fun x -> _v3127 <- Some x
                        let v3270 : Async<struct (int32 * string)> = _v3127.Value
                        let v3271 : struct (int32 * string) option = None
                        let v3272 : bool = true in let mutable _v3271 = v3271
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v3273 : int32, v3274 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3273, v3274)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v3275 : int32, v3276 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3275, v3276)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v3277 : int32, v3278 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3277, v3278)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3279 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v3280 : int32, v3281 : string) = v3279 v3270
                        struct (v3280, v3281)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v3282 : int32, v3283 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3282, v3283)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v3284 : int32, v3285 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3284, v3285)
#endif
                        |> fun x -> _v3271 <- Some x
                        let struct (v3286 : int32, v3287 : string) = _v3271.Value
                        struct (v3286, v3287)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v3288 : int32, v3289 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3288, v3289)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v3290 : int32, v3291 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3290, v3291)
#endif
                        |> fun x -> _v3088 <- Some x
                        let struct (v3292 : int32, v3293 : string) = _v3088.Value
                        let v3294 : bool option = None
                        let v3295 : bool = true in let mutable _v3294 = v3294
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3296 : string = "cfg!(windows)"
                        let v3297 : bool = Fable.Core.RustInterop.emitRustExpr () v3296
                        v3297
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3298 : bool = null |> unbox<bool>
                        v3298
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3299 : bool = null |> unbox<bool>
                        v3299
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3300 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                        let v3301 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                        let v3302 : bool = v3301 v3300
                        v3302
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3303 : bool = null |> unbox<bool>
                        v3303
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3304 : bool = null |> unbox<bool>
                        v3304
#endif
                        |> fun x -> _v3294 <- Some x
                        let v3305 : bool = _v3294.Value
                        let v3306 : bool = v3305 = false
                        let v3327 : string =
                            if v3306 then
                                v3002
                            else
                                let v3307 : string option = None
                                let v3308 : bool = true in let mutable _v3307 = v3307
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v3309 : string = method16()
                                let v3310 : string = method17(v3002)
                                let v3311 : string = method18()
                                let v3312 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                                let v3313 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v3309, v3310, v3311) v3312
                                let v3314 : string = "String::from($0)"
                                let v3315 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3313 v3314
                                let v3316 : string = "fable_library_rust::String_::fromString($0)"
                                let v3317 : string = Fable.Core.RustInterop.emitRustExpr v3315 v3316
                                v3317
#endif
                                
#if FABLE_COMPILER_RUST && WASM
                                let v3318 : string = null |> unbox<string>
                                v3318
#endif
                                
#if FABLE_COMPILER_RUST && CONTRACT
                                let v3319 : string = null |> unbox<string>
                                v3319
#endif
                                
#if !FABLE_COMPILER && !WASM && !CONTRACT
                                let v3320 : string = "^\\\\\\\\\\?\\\\"
                                let v3321 : string = System.Text.RegularExpressions.Regex.Replace (v3002, v3320, v233)
                                v3321
#endif
                                
#if FABLE_COMPILER_TYPESCRIPT
                                let v3322 : string = null |> unbox<string>
                                v3322
#endif
                                
#if FABLE_COMPILER_PYTHON
                                let v3323 : string = null |> unbox<string>
                                v3323
#endif
                                |> fun x -> _v3307 <- Some x
                                let v3324 : string = _v3307.Value
                                let v3325 : string = $"{v3324.[0] |> string |> _.ToLower()}{v3324.[1..]}"
                                let v3326 : string = v3325.Replace (v235, v236)
                                v3326
                        let v3328 : System.Threading.CancellationToken option = None
                        let v3329 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v3330 : string option = None
                        let v3331 : string = $"pwsh -c \"(Get-FileHash \\\"{v3327}\\\" -Algorithm SHA256).Hash\""
                        let v3332 : struct (int32 * string) option = None
                        let v3333 : bool = true in let mutable _v3332 = v3332
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v3334 : string, v3335 : string) = method32()
                        let v3336 : int32 = v3331.Length
                        let v3337 : (char []) = Array.zeroCreate<char> (v3336)
                        let v3338 : Mut5 = {l0 = 0} : Mut5
                        while method20(v3336, v3338) do
                            let v3340 : int32 = v3338.l0
                            let v3341 : char = v3331.[int v3340]
                            v3337.[int v3340] <- v3341
                            let v3342 : int32 = v3340 + 1
                            v3338.l0 <- v3342
                            ()
                        let v3343 : ((char []) -> char list) = Array.toList
                        let v3344 : char list = v3343 v3337
                        let v3345 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v3346 : (char -> (UH0 -> UH0)) = method33()
                        let v3347 : (char list -> (UH0 -> UH0)) = v3345 v3346
                        let v3348 : (UH0 -> UH0) = v3347 v3344
                        let v3349 : UH0 = UH0_0
                        let v3350 : UH0 = v3348 v3349
                        let v3351 : US8 = US8_0
                        let struct (v3352 : string, v3353 : string) = method34(v3335, v3334, v3350, v3351)
                        let v3354 : (string []) = method35(v3353)
                        let v3355 : string = "$0.to_vec()"
                        let v3356 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v3354 v3355
                        let v3357 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v3358 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3356, v381) v3357
                        let v3359 : US0 = US0_1
                        let v3360 : (unit -> string) = closure28(v3328, v3331, v3329, v3330, v3352, v3358)
                        let v3361 : (unit -> string) = method41()
                        method3(v3359, v3360, v3361)
                        let v3362 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method42(v3328, v3331, v3329, v3330, v3352, v3358)
                        let v3363 : string = "futures_lite::future::block_on($0)"
                        let v3364 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v3362 v3363
                        let (a, b) = v3364
                        let v3365 : int32 = a
                        let v3366 : string = b
                        struct (v3365, v3366)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v3367 : int32, v3368 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3367, v3368)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v3369 : int32, v3370 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3369, v3370)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3371 : Async<struct (int32 * string)> option = None
                        let v3372 : bool = true in let mutable _v3371 = v3371
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3373 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3373
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3374 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3374
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3375 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3375
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3376 : Async<struct (int32 * string)> option = None
                        let v3377 : bool = true in let mutable _v3376 = v3376
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3378 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3378
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3379 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3379
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3380 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3380
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3381 : Async<struct (int32 * string)> option = None
                        let mutable _v3381 = v3381
                        async {
                        let struct (v3382 : string, v3383 : string) = method32()
                        let v3384 : (char []) = Array.zeroCreate<char> (v3336)
                        let v3385 : Mut5 = {l0 = 0} : Mut5
                        while method20(v3336, v3385) do
                            let v3387 : int32 = v3385.l0
                            let v3388 : char = v3331.[int v3387]
                            v3384.[int v3387] <- v3388
                            let v3389 : int32 = v3387 + 1
                            v3385.l0 <- v3389
                            ()
                        let v3390 : ((char []) -> char list) = Array.toList
                        let v3391 : char list = v3390 v3384
                        let v3392 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v3393 : (char -> (UH0 -> UH0)) = method33()
                        let v3394 : (char list -> (UH0 -> UH0)) = v3392 v3393
                        let v3395 : (UH0 -> UH0) = v3394 v3391
                        let v3396 : UH0 = UH0_0
                        let v3397 : UH0 = v3395 v3396
                        let v3398 : US8 = US8_0
                        let struct (v3399 : string, v3400 : string) = method34(v3383, v3382, v3397, v3398)
                        let v3401 : (string -> US7) = method36()
                        let v3402 : US7 = US7_1
                        let v3403 : US7 = v3330 |> Option.map v3401 |> Option.defaultValue v3402 
                        let v3406 : string =
                            match v3403 with
                            | US7_1 -> (* None *)
                                v233
                            | US7_0(v3404) -> (* Some *)
                                v3404
                        let v3407 : US0 = US0_1
                        let v3408 : (unit -> string) = closure44(v3328, v3331, v3329, v3330)
                        let v3409 : (unit -> string) = method41()
                        method3(v3407, v3408, v3409)
                        let v3410 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v3411 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v3400, StandardOutputEncoding = v3410, WorkingDirectory = v3406, FileName = v3399, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v3412 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v3411)
                        use v3412 = v3412 
                        let v3413 : System.Diagnostics.Process = v3412 
                        let v3414 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v3415 : System.Collections.Concurrent.ConcurrentStack<string> = v3414 ()
                        let v3416 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v3328, v3331, v3329, v3330, v3413, v3415)
                        v3413.OutputDataReceived.Add v3416 
                        let v3417 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v3328, v3331, v3329, v3330, v3413, v3415)
                        v3413.ErrorDataReceived.Add v3417 
                        let v3418 : (unit -> bool) = v3413.Start
                        let v3419 : bool = v3418 ()
                        let v3420 : bool = v3419 = false
                        if v3420 then
                            let v3421 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v3421
                        let v3422 : (unit -> unit) = v3413.BeginErrorReadLine
                        v3422 ()
                        let v3423 : (unit -> unit) = v3413.BeginOutputReadLine
                        v3423 ()
                        let v3424 : (System.Threading.CancellationToken -> US16) = method59()
                        let v3425 : US16 = US16_1
                        let v3426 : US16 = v3328 |> Option.map v3424 |> Option.defaultValue v3425 
                        let v3430 : System.Threading.CancellationToken =
                            match v3426 with
                            | US16_1 -> (* None *)
                                let v3428 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v3428
                            | US16_0(v3427) -> (* Some *)
                                v3427
                        let v3431 : Async<System.Threading.CancellationToken> option = None
                        let v3432 : bool = true in let mutable _v3431 = v3431
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3433 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3433
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3434 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3434
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3435 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3435
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3436 : Async<System.Threading.CancellationToken> option = None
                        let v3437 : bool = true in let mutable _v3436 = v3436
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3438 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3438
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3439 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3439
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3440 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3440
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3441 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v3441 = v3441
                        async {
                        let v3442 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v3442 = v3442 
                        let v3443 : System.Threading.CancellationToken = v3442 
                        let v3444 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v3445 : (System.Threading.CancellationToken []) = [|v3443; v3444; v3430|]
                        let v3446 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v3447 : System.Threading.CancellationTokenSource = v3446 v3445
                        let v3448 : System.Threading.CancellationToken = v3447.Token
                        return v3448 
                        }
                        |> fun x -> _v3441 <- Some x
                        let v3449 : Async<System.Threading.CancellationToken> = _v3441 |> Option.get
                        v3449
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3450 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3450
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3451 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3451
#endif
                        |> fun x -> _v3436 <- Some x
                        let v3452 : Async<System.Threading.CancellationToken> = _v3436.Value
                        v3452
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3453 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3453
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3454 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3454
#endif
                        |> fun x -> _v3431 <- Some x
                        let v3455 : Async<System.Threading.CancellationToken> = _v3431.Value
                        let! v3455 = v3455 
                        let v3456 : System.Threading.CancellationToken = v3455 
                        let v3457 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v3456.Register
                        let v3458 : (unit -> unit) = closure50(v3413)
                        let v3459 : System.Threading.CancellationTokenRegistration = v3457 v3458
                        use v3459 = v3459 
                        let v3460 : System.Threading.CancellationTokenRegistration = v3459 
                        let v3461 : Async<int32> option = None
                        let v3462 : bool = true in let mutable _v3461 = v3461
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3463 : Async<int32> = null |> unbox<Async<int32>>
                        v3463
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3464 : Async<int32> = null |> unbox<Async<int32>>
                        v3464
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3465 : Async<int32> = null |> unbox<Async<int32>>
                        v3465
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3466 : Async<int32> option = None
                        let mutable _v3466 = v3466
                        async {
                        try
                        let v3467 : System.Threading.Tasks.Task = v3413.WaitForExitAsync v3456 
                        let v3468 : Async<unit> option = None
                        let v3469 : bool = true in let mutable _v3468 = v3468
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3470 : Async<unit> = null |> unbox<Async<unit>>
                        v3470
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3471 : Async<unit> = null |> unbox<Async<unit>>
                        v3471
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3472 : Async<unit> = null |> unbox<Async<unit>>
                        v3472
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3473 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v3474 : Async<unit> = v3473 v3467
                        v3474
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3475 : Async<unit> = null |> unbox<Async<unit>>
                        v3475
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3476 : Async<unit> = null |> unbox<Async<unit>>
                        v3476
#endif
                        |> fun x -> _v3468 <- Some x
                        let v3477 : Async<unit> = _v3468.Value
                        do! v3477 
                        let v3478 : int32 = v3413.ExitCode
                        return v3478 
                        with ex ->
                        let v3479 : exn = ex
                        let v3480 : string option = None
                        let v3481 : bool = true in let mutable _v3480 = v3480
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3482 : string = $"%A{v3479}"
                        v3482
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3483 : string = $"%A{v3479}"
                        v3483
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3484 : string = $"%A{v3479}"
                        v3484
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3485 : string = $"{v3479.GetType ()}: {v3479.Message}"
                        v3485
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3486 : string = $"%A{v3479}"
                        v3486
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3487 : string = $"%A{v3479}"
                        v3487
#endif
                        |> fun x -> _v3480 <- Some x
                        let v3488 : string = _v3480.Value
                        let v3489 : (string -> unit) = v3415.Push
                        v3489 v3488
                        let v3490 : System.Threading.Tasks.TaskCanceledException = v3479 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v3491 : US0 = US0_3
                        let v3492 : (unit -> string) = closure51(v3490)
                        let v3493 : (unit -> string) = method41()
                        method3(v3491, v3492, v3493)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v3466 <- Some x
                        let v3494 : Async<int32> = _v3466 |> Option.get
                        v3494
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3495 : Async<int32> = null |> unbox<Async<int32>>
                        v3495
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3496 : Async<int32> = null |> unbox<Async<int32>>
                        v3496
#endif
                        |> fun x -> _v3461 <- Some x
                        let v3497 : Async<int32> = _v3461.Value
                        let! v3497 = v3497 
                        let v3498 : int32 = v3497 
                        let v3499 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v3500 : string seq = v3499 v3415
                        let v3501 : string = method60()
                        let v3502 : (string -> (string seq -> string)) = String.concat
                        let v3503 : (string seq -> string) = v3502 v3501
                        let v3504 : string = v3503 v3500
                        let v3505 : US0 = US0_1
                        let v3506 : (unit -> string) = closure52(v3498, v3504)
                        let v3507 : (unit -> string) = method41()
                        method3(v3505, v3506, v3507)
                        return struct (v3498, v3504) 
                        }
                        |> fun x -> _v3381 <- Some x
                        let v3508 : Async<struct (int32 * string)> = _v3381 |> Option.get
                        v3508
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3509 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3509
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3510 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3510
#endif
                        |> fun x -> _v3376 <- Some x
                        let v3511 : Async<struct (int32 * string)> = _v3376.Value
                        v3511
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3512 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3512
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3513 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3513
#endif
                        |> fun x -> _v3371 <- Some x
                        let v3514 : Async<struct (int32 * string)> = _v3371.Value
                        let v3515 : struct (int32 * string) option = None
                        let v3516 : bool = true in let mutable _v3515 = v3515
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v3517 : int32, v3518 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3517, v3518)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v3519 : int32, v3520 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3519, v3520)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v3521 : int32, v3522 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3521, v3522)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3523 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v3524 : int32, v3525 : string) = v3523 v3514
                        struct (v3524, v3525)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v3526 : int32, v3527 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3526, v3527)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v3528 : int32, v3529 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3528, v3529)
#endif
                        |> fun x -> _v3515 <- Some x
                        let struct (v3530 : int32, v3531 : string) = _v3515.Value
                        struct (v3530, v3531)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v3532 : int32, v3533 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3532, v3533)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v3534 : int32, v3535 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3534, v3535)
#endif
                        |> fun x -> _v3332 <- Some x
                        let struct (v3536 : int32, v3537 : string) = _v3332.Value
                        let v3538 : bool = v3293 = v3537
                        v3538
                    else
                        false
                let v3540 : bool = v3539 = false
                let v3773 : US17 =
                    if v3540 then
                        let v3541 : string = $"crowbook --single \"{v637}\" --output \"{v3001}\" --to {v3000} --set rendering.num_depth 6 html.css.add \\\"''' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} '''\\\""
                        let v3542 : System.Threading.CancellationToken option = None
                        let v3543 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v3544 : string option = None
                        let v3545 : string option = Some v1 
                        let v3546 : struct (int32 * string) option = None
                        let v3547 : bool = true in let mutable _v3546 = v3546
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v3548 : string, v3549 : string) = method32()
                        let v3550 : int32 = v3541.Length
                        let v3551 : (char []) = Array.zeroCreate<char> (v3550)
                        let v3552 : Mut5 = {l0 = 0} : Mut5
                        while method20(v3550, v3552) do
                            let v3554 : int32 = v3552.l0
                            let v3555 : char = v3541.[int v3554]
                            v3551.[int v3554] <- v3555
                            let v3556 : int32 = v3554 + 1
                            v3552.l0 <- v3556
                            ()
                        let v3557 : ((char []) -> char list) = Array.toList
                        let v3558 : char list = v3557 v3551
                        let v3559 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v3560 : (char -> (UH0 -> UH0)) = method33()
                        let v3561 : (char list -> (UH0 -> UH0)) = v3559 v3560
                        let v3562 : (UH0 -> UH0) = v3561 v3558
                        let v3563 : UH0 = UH0_0
                        let v3564 : UH0 = v3562 v3563
                        let v3565 : US8 = US8_0
                        let struct (v3566 : string, v3567 : string) = method34(v3549, v3548, v3564, v3565)
                        let v3568 : (string []) = method35(v3567)
                        let v3569 : string = "$0.to_vec()"
                        let v3570 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v3568 v3569
                        let v3571 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v3572 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3570, v381) v3571
                        let v3573 : US0 = US0_1
                        let v3574 : (unit -> string) = closure28(v3542, v3541, v3543, v3545, v3566, v3572)
                        let v3575 : (unit -> string) = method41()
                        method3(v3573, v3574, v3575)
                        let v3576 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method42(v3542, v3541, v3543, v3545, v3566, v3572)
                        let v3577 : string = "futures_lite::future::block_on($0)"
                        let v3578 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v3576 v3577
                        let (a, b) = v3578
                        let v3579 : int32 = a
                        let v3580 : string = b
                        struct (v3579, v3580)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v3581 : int32, v3582 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3581, v3582)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v3583 : int32, v3584 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3583, v3584)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3585 : Async<struct (int32 * string)> option = None
                        let v3586 : bool = true in let mutable _v3585 = v3585
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3587 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3587
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3588 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3588
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3589 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3589
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3590 : Async<struct (int32 * string)> option = None
                        let v3591 : bool = true in let mutable _v3590 = v3590
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3592 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3592
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3593 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3593
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3594 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3594
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3595 : Async<struct (int32 * string)> option = None
                        let mutable _v3595 = v3595
                        async {
                        let struct (v3596 : string, v3597 : string) = method32()
                        let v3598 : (char []) = Array.zeroCreate<char> (v3550)
                        let v3599 : Mut5 = {l0 = 0} : Mut5
                        while method20(v3550, v3599) do
                            let v3601 : int32 = v3599.l0
                            let v3602 : char = v3541.[int v3601]
                            v3598.[int v3601] <- v3602
                            let v3603 : int32 = v3601 + 1
                            v3599.l0 <- v3603
                            ()
                        let v3604 : ((char []) -> char list) = Array.toList
                        let v3605 : char list = v3604 v3598
                        let v3606 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v3607 : (char -> (UH0 -> UH0)) = method33()
                        let v3608 : (char list -> (UH0 -> UH0)) = v3606 v3607
                        let v3609 : (UH0 -> UH0) = v3608 v3605
                        let v3610 : UH0 = UH0_0
                        let v3611 : UH0 = v3609 v3610
                        let v3612 : US8 = US8_0
                        let struct (v3613 : string, v3614 : string) = method34(v3597, v3596, v3611, v3612)
                        let v3615 : (string -> US7) = method36()
                        let v3616 : US7 = US7_1
                        let v3617 : US7 = v3545 |> Option.map v3615 |> Option.defaultValue v3616 
                        let v3620 : string =
                            match v3617 with
                            | US7_1 -> (* None *)
                                v233
                            | US7_0(v3618) -> (* Some *)
                                v3618
                        let v3621 : US0 = US0_1
                        let v3622 : (unit -> string) = closure44(v3542, v3541, v3543, v3545)
                        let v3623 : (unit -> string) = method41()
                        method3(v3621, v3622, v3623)
                        let v3624 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v3625 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v3614, StandardOutputEncoding = v3624, WorkingDirectory = v3620, FileName = v3613, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v3626 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v3625)
                        use v3626 = v3626 
                        let v3627 : System.Diagnostics.Process = v3626 
                        let v3628 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v3629 : System.Collections.Concurrent.ConcurrentStack<string> = v3628 ()
                        let v3630 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v3542, v3541, v3543, v3545, v3627, v3629)
                        v3627.OutputDataReceived.Add v3630 
                        let v3631 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v3542, v3541, v3543, v3545, v3627, v3629)
                        v3627.ErrorDataReceived.Add v3631 
                        let v3632 : (unit -> bool) = v3627.Start
                        let v3633 : bool = v3632 ()
                        let v3634 : bool = v3633 = false
                        if v3634 then
                            let v3635 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v3635
                        let v3636 : (unit -> unit) = v3627.BeginErrorReadLine
                        v3636 ()
                        let v3637 : (unit -> unit) = v3627.BeginOutputReadLine
                        v3637 ()
                        let v3638 : (System.Threading.CancellationToken -> US16) = method59()
                        let v3639 : US16 = US16_1
                        let v3640 : US16 = v3542 |> Option.map v3638 |> Option.defaultValue v3639 
                        let v3644 : System.Threading.CancellationToken =
                            match v3640 with
                            | US16_1 -> (* None *)
                                let v3642 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v3642
                            | US16_0(v3641) -> (* Some *)
                                v3641
                        let v3645 : Async<System.Threading.CancellationToken> option = None
                        let v3646 : bool = true in let mutable _v3645 = v3645
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3647 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3647
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3648 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3648
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3649 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3649
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3650 : Async<System.Threading.CancellationToken> option = None
                        let v3651 : bool = true in let mutable _v3650 = v3650
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3652 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3652
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3653 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3653
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3654 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3654
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3655 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v3655 = v3655
                        async {
                        let v3656 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v3656 = v3656 
                        let v3657 : System.Threading.CancellationToken = v3656 
                        let v3658 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v3659 : (System.Threading.CancellationToken []) = [|v3657; v3658; v3644|]
                        let v3660 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v3661 : System.Threading.CancellationTokenSource = v3660 v3659
                        let v3662 : System.Threading.CancellationToken = v3661.Token
                        return v3662 
                        }
                        |> fun x -> _v3655 <- Some x
                        let v3663 : Async<System.Threading.CancellationToken> = _v3655 |> Option.get
                        v3663
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3664 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3664
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3665 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3665
#endif
                        |> fun x -> _v3650 <- Some x
                        let v3666 : Async<System.Threading.CancellationToken> = _v3650.Value
                        v3666
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3667 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3667
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3668 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3668
#endif
                        |> fun x -> _v3645 <- Some x
                        let v3669 : Async<System.Threading.CancellationToken> = _v3645.Value
                        let! v3669 = v3669 
                        let v3670 : System.Threading.CancellationToken = v3669 
                        let v3671 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v3670.Register
                        let v3672 : (unit -> unit) = closure50(v3627)
                        let v3673 : System.Threading.CancellationTokenRegistration = v3671 v3672
                        use v3673 = v3673 
                        let v3674 : System.Threading.CancellationTokenRegistration = v3673 
                        let v3675 : Async<int32> option = None
                        let v3676 : bool = true in let mutable _v3675 = v3675
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3677 : Async<int32> = null |> unbox<Async<int32>>
                        v3677
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3678 : Async<int32> = null |> unbox<Async<int32>>
                        v3678
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3679 : Async<int32> = null |> unbox<Async<int32>>
                        v3679
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3680 : Async<int32> option = None
                        let mutable _v3680 = v3680
                        async {
                        try
                        let v3681 : System.Threading.Tasks.Task = v3627.WaitForExitAsync v3670 
                        let v3682 : Async<unit> option = None
                        let v3683 : bool = true in let mutable _v3682 = v3682
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3684 : Async<unit> = null |> unbox<Async<unit>>
                        v3684
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3685 : Async<unit> = null |> unbox<Async<unit>>
                        v3685
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3686 : Async<unit> = null |> unbox<Async<unit>>
                        v3686
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3687 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v3688 : Async<unit> = v3687 v3681
                        v3688
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3689 : Async<unit> = null |> unbox<Async<unit>>
                        v3689
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3690 : Async<unit> = null |> unbox<Async<unit>>
                        v3690
#endif
                        |> fun x -> _v3682 <- Some x
                        let v3691 : Async<unit> = _v3682.Value
                        do! v3691 
                        let v3692 : int32 = v3627.ExitCode
                        return v3692 
                        with ex ->
                        let v3693 : exn = ex
                        let v3694 : string option = None
                        let v3695 : bool = true in let mutable _v3694 = v3694
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3696 : string = $"%A{v3693}"
                        v3696
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let v3697 : string = $"%A{v3693}"
                        v3697
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3698 : string = $"%A{v3693}"
                        v3698
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3699 : string = $"{v3693.GetType ()}: {v3693.Message}"
                        v3699
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3700 : string = $"%A{v3693}"
                        v3700
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3701 : string = $"%A{v3693}"
                        v3701
#endif
                        |> fun x -> _v3694 <- Some x
                        let v3702 : string = _v3694.Value
                        let v3703 : (string -> unit) = v3629.Push
                        v3703 v3702
                        let v3704 : System.Threading.Tasks.TaskCanceledException = v3693 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v3705 : US0 = US0_3
                        let v3706 : (unit -> string) = closure51(v3704)
                        let v3707 : (unit -> string) = method41()
                        method3(v3705, v3706, v3707)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v3680 <- Some x
                        let v3708 : Async<int32> = _v3680 |> Option.get
                        v3708
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3709 : Async<int32> = null |> unbox<Async<int32>>
                        v3709
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3710 : Async<int32> = null |> unbox<Async<int32>>
                        v3710
#endif
                        |> fun x -> _v3675 <- Some x
                        let v3711 : Async<int32> = _v3675.Value
                        let! v3711 = v3711 
                        let v3712 : int32 = v3711 
                        let v3713 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v3714 : string seq = v3713 v3629
                        let v3715 : string = method60()
                        let v3716 : (string -> (string seq -> string)) = String.concat
                        let v3717 : (string seq -> string) = v3716 v3715
                        let v3718 : string = v3717 v3714
                        let v3719 : US0 = US0_1
                        let v3720 : (unit -> string) = closure52(v3712, v3718)
                        let v3721 : (unit -> string) = method41()
                        method3(v3719, v3720, v3721)
                        return struct (v3712, v3718) 
                        }
                        |> fun x -> _v3595 <- Some x
                        let v3722 : Async<struct (int32 * string)> = _v3595 |> Option.get
                        v3722
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3723 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3723
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3724 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3724
#endif
                        |> fun x -> _v3590 <- Some x
                        let v3725 : Async<struct (int32 * string)> = _v3590.Value
                        v3725
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let v3726 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3726
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let v3727 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3727
#endif
                        |> fun x -> _v3585 <- Some x
                        let v3728 : Async<struct (int32 * string)> = _v3585.Value
                        let v3729 : struct (int32 * string) option = None
                        let v3730 : bool = true in let mutable _v3729 = v3729
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v3731 : int32, v3732 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3731, v3732)
#endif
                        
#if FABLE_COMPILER_RUST && WASM
                        let struct (v3733 : int32, v3734 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3733, v3734)
#endif
                        
#if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v3735 : int32, v3736 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3735, v3736)
#endif
                        
#if !FABLE_COMPILER && !WASM && !CONTRACT
                        let v3737 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v3738 : int32, v3739 : string) = v3737 v3728
                        struct (v3738, v3739)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v3740 : int32, v3741 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3740, v3741)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v3742 : int32, v3743 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3742, v3743)
#endif
                        |> fun x -> _v3729 <- Some x
                        let struct (v3744 : int32, v3745 : string) = _v3729.Value
                        struct (v3744, v3745)
#endif
                        
#if FABLE_COMPILER_TYPESCRIPT
                        let struct (v3746 : int32, v3747 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3746, v3747)
#endif
                        
#if FABLE_COMPILER_PYTHON
                        let struct (v3748 : int32, v3749 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3748, v3749)
#endif
                        |> fun x -> _v3546 <- Some x
                        let struct (v3750 : int32, v3751 : string) = _v3546.Value
                        let v3752 : bool = v3750 <> 0
                        let v3755 : bool =
                            if v3752 then
                                true
                            else
                                let v3753 : string = "ERROR"
                                let v3754 : bool = v3751.Contains v3753
                                v3754
                        if v3755 then
                            let v3756 : US0 = US0_2
                            let v3757 : (unit -> string) = closure53()
                            let v3758 : (unit -> string) = closure54(v3751, v3750)
                            method3(v3756, v3757, v3758)
                            let v3759 : (string * string) = v3001, v3751
                            let v3760 : Result<string, (string * string)> = Error v3759
                            US17_0(v3760)
                        else
                            let v3762 : unit option = None
                            let v3763 : bool = true in let mutable _v3762 = v3762
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v3764 : string = method61(v3002)
                            let v3765 : string = "std::fs::copy(&*v3001, &*v3764)"
                            let v3766 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v3765
                            let v3767 : string = "$0.unwrap()"
                            let v3768 : uint64 = Fable.Core.RustInterop.emitRustExpr v3766 v3767
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
                            System.IO.File.Copy (v3001, v3002, true)
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
                            |> fun x -> _v3762 <- Some x
                            _v3762.Value
                            let v3769 : Result<string, (string * string)> = Ok v3001
                            US17_0(v3769)
                    else
                        US17_1
                let v3778 : Result<string, (string * string)> option =
                    match v3773 with
                    | US17_1 -> (* None *)
                        let v3776 : Result<string, (string * string)> option = None
                        v3776
                    | US17_0(v3774) -> (* Some *)
                        let v3775 : Result<string, (string * string)> option = Some v3774 
                        v3775
                let v3779 : Result<string, (string * string)> option list = []
                let v3780 : Result<string, (string * string)> option list = v1441 :: v3779 
                let v3781 : Result<string, (string * string)> option list = v2220 :: v3780 
                let v3782 : Result<string, (string * string)> option list = v2999 :: v3781 
                let v3783 : Result<string, (string * string)> option list = v3778 :: v3782 
                let v3784 : (Result<string, (string * string)> option list -> (Result<string, (string * string)> option [])) = List.toArray
                let v3785 : (Result<string, (string * string)> option []) = v3784 v3783
                let v3786 : US0 = US0_2
                let v3787 : (unit -> string) = closure55()
                let v3788 : (unit -> string) = closure56(v238, v272, v349, v561, v560, v848, v847, v1094, v1439, v3785)
                method3(v3786, v3787, v3788)
                let v3789 : unit option = None
                let v3790 : bool = true in let mutable _v3789 = v3789
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3791 : string = method61(v1170)
                let v3792 : string = "std::fs::copy(&*v637, &*v3791)"
                let v3793 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v3792
                let v3794 : string = "$0.unwrap()"
                let v3795 : uint64 = Fable.Core.RustInterop.emitRustExpr v3793 v3794
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
                System.IO.File.Copy (v637, v1170, true)
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
                |> fun x -> _v3789 <- Some x
                _v3789.Value
                v3785
            else
                let v3796 : (Result<string, (string * string)> option []) = [||]
                v3796
        else
            let v3798 : (Result<string, (string * string)> option []) = [||]
            v3798
    let v3800 : string = "$0.to_vec()"
    let v3801 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v3799 v3800
    let v3802 : (string * Vec<Result<string, (string * string)> option>) = v272, v3801
    let v3803 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v3802
    v3803
and closure57 () () : string =
    let v0 : string = "documents.run"
    v0
and closure58 (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) () : string =
    let v1 : string = "$0.len()"
    let v2 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"result_len: {v2} / {v3 ()}"
    v4
and method62 (v0 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>) : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> =
    v0
and method23 (v0 : string, v1 : string, v2 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> =
    let v3 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v3
    let v4 : string = "async_walkdir::WalkDir::new(&*$0)"
    let v5 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr v1 v4
    let v6 : string = "async_walkdir::WalkDir::filter($0, |x| $1(x))"
    let v7 : (async_walkdir_DirEntry -> std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>) = closure12()
    let v8 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6
    let v9 : (Result<async_walkdir_DirEntry, std_io_Error> -> string option) = method31()
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
    let v26 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = method62(v25)
    let v27 : string = "v26 }}}})"
    Fable.Core.RustInterop.emitRustExpr () v27
    let v28 : string = "{{{ //"
    Fable.Core.RustInterop.emitRustExpr () v28
    let v29 : string = "__result"
    let v30 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v29
    v30
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
    let v99 : string option = None
    let v100 : bool = true in let mutable _v99 = v99
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v101 : string = method12(v56)
    let v102 : string = method13(v101)
    let v103 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v102 v103
    let v105 : string = "String::from($0)"
    let v106 : std_string_String = Fable.Core.RustInterop.emitRustExpr v104 v105
    let v107 : string = "std::path::PathBuf::from($0)"
    let v108 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v106 v107
    let v109 : string = "$0.exists()"
    let v110 : bool = Fable.Core.RustInterop.emitRustExpr v108 v109
    let v111 : bool = v110 = false
    let v296 : string =
        if v111 then
            let v112 : string option = None
            let v113 : bool = true in let mutable _v112 = v112
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v114 : string = "std::env::current_dir()"
            let v115 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v114
            let v116 : string = "$0.unwrap()"
            let v117 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v115 v116
            let v118 : string = "$0.display()"
            let v119 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v117 v118
            let v120 : std_string_String option = None
            let v121 : bool = true in let mutable _v120 = v120
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v122 : string = @$"format!(""{{}}"", $0)"
            let v123 : std_string_String = Fable.Core.RustInterop.emitRustExpr v119 v122
            v123
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v124 : string = @$"format!(""{{}}"", $0)"
            let v125 : std_string_String = Fable.Core.RustInterop.emitRustExpr v119 v124
            v125
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v126 : string = @$"format!(""{{}}"", $0)"
            let v127 : std_string_String = Fable.Core.RustInterop.emitRustExpr v119 v126
            v127
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v128 : std_string_String = null |> unbox<std_string_String>
            v128
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v129 : std_string_String = null |> unbox<std_string_String>
            v129
#endif
            
#if FABLE_COMPILER_PYTHON
            let v130 : std_string_String = null |> unbox<std_string_String>
            v130
#endif
            |> fun x -> _v120 <- Some x
            let v131 : std_string_String = _v120.Value
            let v132 : string = "fable_library_rust::String_::fromString($0)"
            let v133 : string = Fable.Core.RustInterop.emitRustExpr v131 v132
            v133
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v134 : string = null |> unbox<string>
            v134
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v135 : string = null |> unbox<string>
            v135
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v136 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v137 : string = v136 ()
            v137
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v138 : string = null |> unbox<string>
            v138
#endif
            
#if FABLE_COMPILER_PYTHON
            let v139 : string = null |> unbox<string>
            v139
#endif
            |> fun x -> _v112 <- Some x
            let v140 : string = _v112.Value
            let v141 : string option = None
            let v142 : bool = true in let mutable _v141 = v141
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v143 : string = method13(v140)
            let v144 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v145 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v143 v144
            let v146 : string = "String::from($0)"
            let v147 : std_string_String = Fable.Core.RustInterop.emitRustExpr v145 v146
            let v148 : string = "std::path::PathBuf::from($0)"
            let v149 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v147 v148
            let v150 : string = method13(v101)
            let v151 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v152 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v150 v151
            let v153 : string = "String::from($0)"
            let v154 : std_string_String = Fable.Core.RustInterop.emitRustExpr v152 v153
            let v155 : string = "$0.join($1)"
            let v156 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v149, v154) v155
            let v157 : string = "$0.display()"
            let v158 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v156 v157
            let v159 : std_string_String option = None
            let v160 : bool = true in let mutable _v159 = v159
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v161 : string = @$"format!(""{{}}"", $0)"
            let v162 : std_string_String = Fable.Core.RustInterop.emitRustExpr v158 v161
            v162
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v163 : string = @$"format!(""{{}}"", $0)"
            let v164 : std_string_String = Fable.Core.RustInterop.emitRustExpr v158 v163
            v164
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v165 : string = @$"format!(""{{}}"", $0)"
            let v166 : std_string_String = Fable.Core.RustInterop.emitRustExpr v158 v165
            v166
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v167 : std_string_String = null |> unbox<std_string_String>
            v167
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v168 : std_string_String = null |> unbox<std_string_String>
            v168
#endif
            
#if FABLE_COMPILER_PYTHON
            let v169 : std_string_String = null |> unbox<std_string_String>
            v169
#endif
            |> fun x -> _v159 <- Some x
            let v170 : std_string_String = _v159.Value
            let v171 : string = "fable_library_rust::String_::fromString($0)"
            let v172 : string = Fable.Core.RustInterop.emitRustExpr v170 v171
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
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v175 : string = System.IO.Path.Combine (v140, v101)
            v175
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v176 : string = "path"
            let v177 : IPathJoin = Fable.Core.JsInterop.importAll v176
            let v178 : string = method14(v140)
            let v179 : string = method15(v101)
            let v180 : string = "v177.join(v178, v179)"
            let v181 : string = Fable.Core.JsInterop.emitJsExpr () v180
            v181
#endif
            
#if FABLE_COMPILER_PYTHON
            let v182 : string = null |> unbox<string>
            v182
#endif
            |> fun x -> _v141 <- Some x
            let v183 : string = _v141.Value
            let v184 : bool option = None
            let v185 : bool = true in let mutable _v184 = v184
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v186 : string = "cfg!(windows)"
            let v187 : bool = Fable.Core.RustInterop.emitRustExpr () v186
            v187
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v188 : bool = null |> unbox<bool>
            v188
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v189 : bool = null |> unbox<bool>
            v189
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v190 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v191 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v192 : bool = v191 v190
            v192
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v193 : bool = null |> unbox<bool>
            v193
#endif
            
#if FABLE_COMPILER_PYTHON
            let v194 : bool = null |> unbox<bool>
            v194
#endif
            |> fun x -> _v184 <- Some x
            let v195 : bool = _v184.Value
            let v196 : bool = v195 = false
            let v220 : string =
                if v196 then
                    v183
                else
                    let v197 : string option = None
                    let v198 : bool = true in let mutable _v197 = v197
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v199 : string = method16()
                    let v200 : string = method17(v183)
                    let v201 : string = method18()
                    let v202 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v203 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v199, v200, v201) v202
                    let v204 : string = "String::from($0)"
                    let v205 : std_string_String = Fable.Core.RustInterop.emitRustExpr v203 v204
                    let v206 : string = "fable_library_rust::String_::fromString($0)"
                    let v207 : string = Fable.Core.RustInterop.emitRustExpr v205 v206
                    v207
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v208 : string = null |> unbox<string>
                    v208
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v209 : string = null |> unbox<string>
                    v209
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v210 : string = "^\\\\\\\\\\?\\\\"
                    let v211 : string = ""
                    let v212 : string = System.Text.RegularExpressions.Regex.Replace (v183, v210, v211)
                    v212
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v213 : string = null |> unbox<string>
                    v213
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v214 : string = null |> unbox<string>
                    v214
#endif
                    |> fun x -> _v197 <- Some x
                    let v215 : string = _v197.Value
                    let v216 : string = $"{v215.[0] |> string |> _.ToLower()}{v215.[1..]}"
                    let v217 : string = "\\"
                    let v218 : string = "/"
                    let v219 : string = v216.Replace (v217, v218)
                    v219
            let v221 : string = "/"
            let v222 : (string []) = v220.Split v221
            let v223 : (string []) = [||]
            let v224 : int32 = v222.Length
            let v225 : Mut4 = {l0 = 0; l1 = 0; l2 = v223} : Mut4
            while method19(v224, v225) do
                let v227 : int32 = v225.l0
                let v228 : int32 =  -v227
                let v229 : int32 = v228 + v224
                let v230 : int32 = v229 - 1
                let struct (v231 : int32, v232 : (string [])) = v225.l1, v225.l2
                let v233 : string = v222.[int v230]
                let v234 : bool = ".." = v233
                let struct (v254 : int32, v255 : (string [])) =
                    if v234 then
                        let v235 : int32 = v231 + 1
                        struct (v235, v232)
                    else
                        let v236 : bool = 0 = v231
                        if v236 then
                            let v237 : (string []) = [|v233|]
                            let v238 : int32 = v237.Length
                            let v239 : int32 = v232.Length
                            let v240 : int32 = v238 + v239
                            let v241 : (string []) = Array.zeroCreate<string> (v240)
                            let v242 : Mut5 = {l0 = 0} : Mut5
                            while method20(v240, v242) do
                                let v244 : int32 = v242.l0
                                let v245 : bool = v244 < v238
                                let v249 : string =
                                    if v245 then
                                        let v246 : string = v237.[int v244]
                                        v246
                                    else
                                        let v247 : int32 = v244 - v238
                                        let v248 : string = v232.[int v247]
                                        v248
                                v241.[int v244] <- v249
                                let v250 : int32 = v244 + 1
                                v242.l0 <- v250
                                ()
                            struct (v231, v241)
                        else
                            let v251 : int32 = v231 - 1
                            struct (v251, v232)
                let v256 : int32 = v227 + 1
                v225.l0 <- v256
                v225.l1 <- v254
                v225.l2 <- v255
                ()
            let struct (v257 : int32, v258 : (string [])) = v225.l1, v225.l2
            let v259 : string seq = seq { for i = 0 to v258.Length - 1 do yield v258.[i] }
            let v260 : char option = None
            let v261 : bool = true in let mutable _v260 = v260
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v262 : string = "std::path::MAIN_SEPARATOR"
            let v263 : char = Fable.Core.RustInterop.emitRustExpr () v262
            v263
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v264 : char = null |> unbox<char>
            v264
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v265 : char = null |> unbox<char>
            v265
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v266 : char = System.IO.Path.DirectorySeparatorChar
            v266
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v267 : char = null |> unbox<char>
            v267
#endif
            
#if FABLE_COMPILER_PYTHON
            let v268 : char = null |> unbox<char>
            v268
#endif
            |> fun x -> _v260 <- Some x
            let v269 : char = _v260.Value
            let v270 : (char -> string) = _.ToString()
            let v271 : string = v270 v269
            let v272 : string = method21(v271)
            let v273 : (string -> (string seq -> string)) = String.concat
            let v274 : (string seq -> string) = v273 v272
            v274 v259
        else
            let v276 : string = "std::fs::canonicalize(&*$0)"
            let v277 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v101 v276
            let v278 : string = "$0.unwrap()"
            let v279 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v277 v278
            let v280 : string = "$0.display()"
            let v281 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v279 v280
            let v282 : std_string_String option = None
            let v283 : bool = true in let mutable _v282 = v282
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v284 : string = @$"format!(""{{}}"", $0)"
            let v285 : std_string_String = Fable.Core.RustInterop.emitRustExpr v281 v284
            v285
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v286 : string = @$"format!(""{{}}"", $0)"
            let v287 : std_string_String = Fable.Core.RustInterop.emitRustExpr v281 v286
            v287
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v288 : string = @$"format!(""{{}}"", $0)"
            let v289 : std_string_String = Fable.Core.RustInterop.emitRustExpr v281 v288
            v289
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v290 : std_string_String = null |> unbox<std_string_String>
            v290
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v291 : std_string_String = null |> unbox<std_string_String>
            v291
#endif
            
#if FABLE_COMPILER_PYTHON
            let v292 : std_string_String = null |> unbox<std_string_String>
            v292
#endif
            |> fun x -> _v282 <- Some x
            let v293 : std_string_String = _v282.Value
            let v294 : string = "fable_library_rust::String_::fromString($0)"
            let v295 : string = Fable.Core.RustInterop.emitRustExpr v293 v294
            v295
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v299 : string = method22(v56)
    let v300 : (string -> string) = System.IO.Path.GetFullPath
    let v301 : string = v300 v299
    v301
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v302 : string = null |> unbox<string>
    v302
#endif
    
#if FABLE_COMPILER_PYTHON
    let v303 : string = null |> unbox<string>
    v303
#endif
    |> fun x -> _v99 <- Some x
    let v304 : string = _v99.Value
    let v305 : string option = None
    let v306 : bool = true in let mutable _v305 = v305
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v307 : string = method12(v70)
    let v308 : string = method13(v307)
    let v309 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v310 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v308 v309
    let v311 : string = "String::from($0)"
    let v312 : std_string_String = Fable.Core.RustInterop.emitRustExpr v310 v311
    let v313 : string = "std::path::PathBuf::from($0)"
    let v314 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v312 v313
    let v315 : string = "$0.exists()"
    let v316 : bool = Fable.Core.RustInterop.emitRustExpr v314 v315
    let v317 : bool = v316 = false
    let v502 : string =
        if v317 then
            let v318 : string option = None
            let v319 : bool = true in let mutable _v318 = v318
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v320 : string = "std::env::current_dir()"
            let v321 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v320
            let v322 : string = "$0.unwrap()"
            let v323 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v321 v322
            let v324 : string = "$0.display()"
            let v325 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v323 v324
            let v326 : std_string_String option = None
            let v327 : bool = true in let mutable _v326 = v326
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v328 : string = @$"format!(""{{}}"", $0)"
            let v329 : std_string_String = Fable.Core.RustInterop.emitRustExpr v325 v328
            v329
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v330 : string = @$"format!(""{{}}"", $0)"
            let v331 : std_string_String = Fable.Core.RustInterop.emitRustExpr v325 v330
            v331
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v332 : string = @$"format!(""{{}}"", $0)"
            let v333 : std_string_String = Fable.Core.RustInterop.emitRustExpr v325 v332
            v333
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v334 : std_string_String = null |> unbox<std_string_String>
            v334
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v335 : std_string_String = null |> unbox<std_string_String>
            v335
#endif
            
#if FABLE_COMPILER_PYTHON
            let v336 : std_string_String = null |> unbox<std_string_String>
            v336
#endif
            |> fun x -> _v326 <- Some x
            let v337 : std_string_String = _v326.Value
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
            let v342 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v343 : string = v342 ()
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
            |> fun x -> _v318 <- Some x
            let v346 : string = _v318.Value
            let v347 : string option = None
            let v348 : bool = true in let mutable _v347 = v347
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v349 : string = method13(v346)
            let v350 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v351 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v349 v350
            let v352 : string = "String::from($0)"
            let v353 : std_string_String = Fable.Core.RustInterop.emitRustExpr v351 v352
            let v354 : string = "std::path::PathBuf::from($0)"
            let v355 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v353 v354
            let v356 : string = method13(v307)
            let v357 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v358 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v356 v357
            let v359 : string = "String::from($0)"
            let v360 : std_string_String = Fable.Core.RustInterop.emitRustExpr v358 v359
            let v361 : string = "$0.join($1)"
            let v362 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v355, v360) v361
            let v363 : string = "$0.display()"
            let v364 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v362 v363
            let v365 : std_string_String option = None
            let v366 : bool = true in let mutable _v365 = v365
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v367 : string = @$"format!(""{{}}"", $0)"
            let v368 : std_string_String = Fable.Core.RustInterop.emitRustExpr v364 v367
            v368
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v369 : string = @$"format!(""{{}}"", $0)"
            let v370 : std_string_String = Fable.Core.RustInterop.emitRustExpr v364 v369
            v370
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v371 : string = @$"format!(""{{}}"", $0)"
            let v372 : std_string_String = Fable.Core.RustInterop.emitRustExpr v364 v371
            v372
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v373 : std_string_String = null |> unbox<std_string_String>
            v373
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v374 : std_string_String = null |> unbox<std_string_String>
            v374
#endif
            
#if FABLE_COMPILER_PYTHON
            let v375 : std_string_String = null |> unbox<std_string_String>
            v375
#endif
            |> fun x -> _v365 <- Some x
            let v376 : std_string_String = _v365.Value
            let v377 : string = "fable_library_rust::String_::fromString($0)"
            let v378 : string = Fable.Core.RustInterop.emitRustExpr v376 v377
            v378
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v379 : string = null |> unbox<string>
            v379
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v380 : string = null |> unbox<string>
            v380
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v381 : string = System.IO.Path.Combine (v346, v307)
            v381
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v382 : string = "path"
            let v383 : IPathJoin = Fable.Core.JsInterop.importAll v382
            let v384 : string = method14(v346)
            let v385 : string = method15(v307)
            let v386 : string = "v383.join(v384, v385)"
            let v387 : string = Fable.Core.JsInterop.emitJsExpr () v386
            v387
#endif
            
#if FABLE_COMPILER_PYTHON
            let v388 : string = null |> unbox<string>
            v388
#endif
            |> fun x -> _v347 <- Some x
            let v389 : string = _v347.Value
            let v390 : bool option = None
            let v391 : bool = true in let mutable _v390 = v390
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v392 : string = "cfg!(windows)"
            let v393 : bool = Fable.Core.RustInterop.emitRustExpr () v392
            v393
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v394 : bool = null |> unbox<bool>
            v394
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v395 : bool = null |> unbox<bool>
            v395
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v396 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v397 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v398 : bool = v397 v396
            v398
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v399 : bool = null |> unbox<bool>
            v399
#endif
            
#if FABLE_COMPILER_PYTHON
            let v400 : bool = null |> unbox<bool>
            v400
#endif
            |> fun x -> _v390 <- Some x
            let v401 : bool = _v390.Value
            let v402 : bool = v401 = false
            let v426 : string =
                if v402 then
                    v389
                else
                    let v403 : string option = None
                    let v404 : bool = true in let mutable _v403 = v403
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v405 : string = method16()
                    let v406 : string = method17(v389)
                    let v407 : string = method18()
                    let v408 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v409 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v405, v406, v407) v408
                    let v410 : string = "String::from($0)"
                    let v411 : std_string_String = Fable.Core.RustInterop.emitRustExpr v409 v410
                    let v412 : string = "fable_library_rust::String_::fromString($0)"
                    let v413 : string = Fable.Core.RustInterop.emitRustExpr v411 v412
                    v413
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v414 : string = null |> unbox<string>
                    v414
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v415 : string = null |> unbox<string>
                    v415
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v416 : string = "^\\\\\\\\\\?\\\\"
                    let v417 : string = ""
                    let v418 : string = System.Text.RegularExpressions.Regex.Replace (v389, v416, v417)
                    v418
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v419 : string = null |> unbox<string>
                    v419
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v420 : string = null |> unbox<string>
                    v420
#endif
                    |> fun x -> _v403 <- Some x
                    let v421 : string = _v403.Value
                    let v422 : string = $"{v421.[0] |> string |> _.ToLower()}{v421.[1..]}"
                    let v423 : string = "\\"
                    let v424 : string = "/"
                    let v425 : string = v422.Replace (v423, v424)
                    v425
            let v427 : string = "/"
            let v428 : (string []) = v426.Split v427
            let v429 : (string []) = [||]
            let v430 : int32 = v428.Length
            let v431 : Mut4 = {l0 = 0; l1 = 0; l2 = v429} : Mut4
            while method19(v430, v431) do
                let v433 : int32 = v431.l0
                let v434 : int32 =  -v433
                let v435 : int32 = v434 + v430
                let v436 : int32 = v435 - 1
                let struct (v437 : int32, v438 : (string [])) = v431.l1, v431.l2
                let v439 : string = v428.[int v436]
                let v440 : bool = ".." = v439
                let struct (v460 : int32, v461 : (string [])) =
                    if v440 then
                        let v441 : int32 = v437 + 1
                        struct (v441, v438)
                    else
                        let v442 : bool = 0 = v437
                        if v442 then
                            let v443 : (string []) = [|v439|]
                            let v444 : int32 = v443.Length
                            let v445 : int32 = v438.Length
                            let v446 : int32 = v444 + v445
                            let v447 : (string []) = Array.zeroCreate<string> (v446)
                            let v448 : Mut5 = {l0 = 0} : Mut5
                            while method20(v446, v448) do
                                let v450 : int32 = v448.l0
                                let v451 : bool = v450 < v444
                                let v455 : string =
                                    if v451 then
                                        let v452 : string = v443.[int v450]
                                        v452
                                    else
                                        let v453 : int32 = v450 - v444
                                        let v454 : string = v438.[int v453]
                                        v454
                                v447.[int v450] <- v455
                                let v456 : int32 = v450 + 1
                                v448.l0 <- v456
                                ()
                            struct (v437, v447)
                        else
                            let v457 : int32 = v437 - 1
                            struct (v457, v438)
                let v462 : int32 = v433 + 1
                v431.l0 <- v462
                v431.l1 <- v460
                v431.l2 <- v461
                ()
            let struct (v463 : int32, v464 : (string [])) = v431.l1, v431.l2
            let v465 : string seq = seq { for i = 0 to v464.Length - 1 do yield v464.[i] }
            let v466 : char option = None
            let v467 : bool = true in let mutable _v466 = v466
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v468 : string = "std::path::MAIN_SEPARATOR"
            let v469 : char = Fable.Core.RustInterop.emitRustExpr () v468
            v469
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v470 : char = null |> unbox<char>
            v470
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v471 : char = null |> unbox<char>
            v471
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v472 : char = System.IO.Path.DirectorySeparatorChar
            v472
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v473 : char = null |> unbox<char>
            v473
#endif
            
#if FABLE_COMPILER_PYTHON
            let v474 : char = null |> unbox<char>
            v474
#endif
            |> fun x -> _v466 <- Some x
            let v475 : char = _v466.Value
            let v476 : (char -> string) = _.ToString()
            let v477 : string = v476 v475
            let v478 : string = method21(v477)
            let v479 : (string -> (string seq -> string)) = String.concat
            let v480 : (string seq -> string) = v479 v478
            v480 v465
        else
            let v482 : string = "std::fs::canonicalize(&*$0)"
            let v483 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v307 v482
            let v484 : string = "$0.unwrap()"
            let v485 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v483 v484
            let v486 : string = "$0.display()"
            let v487 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v485 v486
            let v488 : std_string_String option = None
            let v489 : bool = true in let mutable _v488 = v488
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v490 : string = @$"format!(""{{}}"", $0)"
            let v491 : std_string_String = Fable.Core.RustInterop.emitRustExpr v487 v490
            v491
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v492 : string = @$"format!(""{{}}"", $0)"
            let v493 : std_string_String = Fable.Core.RustInterop.emitRustExpr v487 v492
            v493
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v494 : string = @$"format!(""{{}}"", $0)"
            let v495 : std_string_String = Fable.Core.RustInterop.emitRustExpr v487 v494
            v495
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v496 : std_string_String = null |> unbox<std_string_String>
            v496
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v497 : std_string_String = null |> unbox<std_string_String>
            v497
#endif
            
#if FABLE_COMPILER_PYTHON
            let v498 : std_string_String = null |> unbox<std_string_String>
            v498
#endif
            |> fun x -> _v488 <- Some x
            let v499 : std_string_String = _v488.Value
            let v500 : string = "fable_library_rust::String_::fromString($0)"
            let v501 : string = Fable.Core.RustInterop.emitRustExpr v499 v500
            v501
    v502
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v503 : string = null |> unbox<string>
    v503
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v504 : string = null |> unbox<string>
    v504
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v505 : string = method22(v70)
    let v506 : (string -> string) = System.IO.Path.GetFullPath
    let v507 : string = v506 v505
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
    |> fun x -> _v305 <- Some x
    let v510 : string = _v305.Value
    let v511 : string option = None
    let v512 : bool = true in let mutable _v511 = v511
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v513 : string = method12(v84)
    let v514 : string = method13(v513)
    let v515 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v516 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v514 v515
    let v517 : string = "String::from($0)"
    let v518 : std_string_String = Fable.Core.RustInterop.emitRustExpr v516 v517
    let v519 : string = "std::path::PathBuf::from($0)"
    let v520 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v518 v519
    let v521 : string = "$0.exists()"
    let v522 : bool = Fable.Core.RustInterop.emitRustExpr v520 v521
    let v523 : bool = v522 = false
    let v708 : string =
        if v523 then
            let v524 : string option = None
            let v525 : bool = true in let mutable _v524 = v524
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v526 : string = "std::env::current_dir()"
            let v527 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v526
            let v528 : string = "$0.unwrap()"
            let v529 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v527 v528
            let v530 : string = "$0.display()"
            let v531 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v529 v530
            let v532 : std_string_String option = None
            let v533 : bool = true in let mutable _v532 = v532
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v534 : string = @$"format!(""{{}}"", $0)"
            let v535 : std_string_String = Fable.Core.RustInterop.emitRustExpr v531 v534
            v535
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v536 : string = @$"format!(""{{}}"", $0)"
            let v537 : std_string_String = Fable.Core.RustInterop.emitRustExpr v531 v536
            v537
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v538 : string = @$"format!(""{{}}"", $0)"
            let v539 : std_string_String = Fable.Core.RustInterop.emitRustExpr v531 v538
            v539
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v540 : std_string_String = null |> unbox<std_string_String>
            v540
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v541 : std_string_String = null |> unbox<std_string_String>
            v541
#endif
            
#if FABLE_COMPILER_PYTHON
            let v542 : std_string_String = null |> unbox<std_string_String>
            v542
#endif
            |> fun x -> _v532 <- Some x
            let v543 : std_string_String = _v532.Value
            let v544 : string = "fable_library_rust::String_::fromString($0)"
            let v545 : string = Fable.Core.RustInterop.emitRustExpr v543 v544
            v545
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v546 : string = null |> unbox<string>
            v546
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v547 : string = null |> unbox<string>
            v547
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v548 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v549 : string = v548 ()
            v549
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v550 : string = null |> unbox<string>
            v550
#endif
            
#if FABLE_COMPILER_PYTHON
            let v551 : string = null |> unbox<string>
            v551
#endif
            |> fun x -> _v524 <- Some x
            let v552 : string = _v524.Value
            let v553 : string option = None
            let v554 : bool = true in let mutable _v553 = v553
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v555 : string = method13(v552)
            let v556 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v557 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v555 v556
            let v558 : string = "String::from($0)"
            let v559 : std_string_String = Fable.Core.RustInterop.emitRustExpr v557 v558
            let v560 : string = "std::path::PathBuf::from($0)"
            let v561 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v559 v560
            let v562 : string = method13(v513)
            let v563 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v564 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v562 v563
            let v565 : string = "String::from($0)"
            let v566 : std_string_String = Fable.Core.RustInterop.emitRustExpr v564 v565
            let v567 : string = "$0.join($1)"
            let v568 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v561, v566) v567
            let v569 : string = "$0.display()"
            let v570 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v568 v569
            let v571 : std_string_String option = None
            let v572 : bool = true in let mutable _v571 = v571
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v573 : string = @$"format!(""{{}}"", $0)"
            let v574 : std_string_String = Fable.Core.RustInterop.emitRustExpr v570 v573
            v574
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v575 : string = @$"format!(""{{}}"", $0)"
            let v576 : std_string_String = Fable.Core.RustInterop.emitRustExpr v570 v575
            v576
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v577 : string = @$"format!(""{{}}"", $0)"
            let v578 : std_string_String = Fable.Core.RustInterop.emitRustExpr v570 v577
            v578
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v579 : std_string_String = null |> unbox<std_string_String>
            v579
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v580 : std_string_String = null |> unbox<std_string_String>
            v580
#endif
            
#if FABLE_COMPILER_PYTHON
            let v581 : std_string_String = null |> unbox<std_string_String>
            v581
#endif
            |> fun x -> _v571 <- Some x
            let v582 : std_string_String = _v571.Value
            let v583 : string = "fable_library_rust::String_::fromString($0)"
            let v584 : string = Fable.Core.RustInterop.emitRustExpr v582 v583
            v584
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v585 : string = null |> unbox<string>
            v585
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v586 : string = null |> unbox<string>
            v586
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v587 : string = System.IO.Path.Combine (v552, v513)
            v587
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v588 : string = "path"
            let v589 : IPathJoin = Fable.Core.JsInterop.importAll v588
            let v590 : string = method14(v552)
            let v591 : string = method15(v513)
            let v592 : string = "v589.join(v590, v591)"
            let v593 : string = Fable.Core.JsInterop.emitJsExpr () v592
            v593
#endif
            
#if FABLE_COMPILER_PYTHON
            let v594 : string = null |> unbox<string>
            v594
#endif
            |> fun x -> _v553 <- Some x
            let v595 : string = _v553.Value
            let v596 : bool option = None
            let v597 : bool = true in let mutable _v596 = v596
            
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
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v602 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v603 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v604 : bool = v603 v602
            v604
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v605 : bool = null |> unbox<bool>
            v605
#endif
            
#if FABLE_COMPILER_PYTHON
            let v606 : bool = null |> unbox<bool>
            v606
#endif
            |> fun x -> _v596 <- Some x
            let v607 : bool = _v596.Value
            let v608 : bool = v607 = false
            let v632 : string =
                if v608 then
                    v595
                else
                    let v609 : string option = None
                    let v610 : bool = true in let mutable _v609 = v609
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v611 : string = method16()
                    let v612 : string = method17(v595)
                    let v613 : string = method18()
                    let v614 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v615 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v611, v612, v613) v614
                    let v616 : string = "String::from($0)"
                    let v617 : std_string_String = Fable.Core.RustInterop.emitRustExpr v615 v616
                    let v618 : string = "fable_library_rust::String_::fromString($0)"
                    let v619 : string = Fable.Core.RustInterop.emitRustExpr v617 v618
                    v619
#endif
                    
#if FABLE_COMPILER_RUST && WASM
                    let v620 : string = null |> unbox<string>
                    v620
#endif
                    
#if FABLE_COMPILER_RUST && CONTRACT
                    let v621 : string = null |> unbox<string>
                    v621
#endif
                    
#if !FABLE_COMPILER && !WASM && !CONTRACT
                    let v622 : string = "^\\\\\\\\\\?\\\\"
                    let v623 : string = ""
                    let v624 : string = System.Text.RegularExpressions.Regex.Replace (v595, v622, v623)
                    v624
#endif
                    
#if FABLE_COMPILER_TYPESCRIPT
                    let v625 : string = null |> unbox<string>
                    v625
#endif
                    
#if FABLE_COMPILER_PYTHON
                    let v626 : string = null |> unbox<string>
                    v626
#endif
                    |> fun x -> _v609 <- Some x
                    let v627 : string = _v609.Value
                    let v628 : string = $"{v627.[0] |> string |> _.ToLower()}{v627.[1..]}"
                    let v629 : string = "\\"
                    let v630 : string = "/"
                    let v631 : string = v628.Replace (v629, v630)
                    v631
            let v633 : string = "/"
            let v634 : (string []) = v632.Split v633
            let v635 : (string []) = [||]
            let v636 : int32 = v634.Length
            let v637 : Mut4 = {l0 = 0; l1 = 0; l2 = v635} : Mut4
            while method19(v636, v637) do
                let v639 : int32 = v637.l0
                let v640 : int32 =  -v639
                let v641 : int32 = v640 + v636
                let v642 : int32 = v641 - 1
                let struct (v643 : int32, v644 : (string [])) = v637.l1, v637.l2
                let v645 : string = v634.[int v642]
                let v646 : bool = ".." = v645
                let struct (v666 : int32, v667 : (string [])) =
                    if v646 then
                        let v647 : int32 = v643 + 1
                        struct (v647, v644)
                    else
                        let v648 : bool = 0 = v643
                        if v648 then
                            let v649 : (string []) = [|v645|]
                            let v650 : int32 = v649.Length
                            let v651 : int32 = v644.Length
                            let v652 : int32 = v650 + v651
                            let v653 : (string []) = Array.zeroCreate<string> (v652)
                            let v654 : Mut5 = {l0 = 0} : Mut5
                            while method20(v652, v654) do
                                let v656 : int32 = v654.l0
                                let v657 : bool = v656 < v650
                                let v661 : string =
                                    if v657 then
                                        let v658 : string = v649.[int v656]
                                        v658
                                    else
                                        let v659 : int32 = v656 - v650
                                        let v660 : string = v644.[int v659]
                                        v660
                                v653.[int v656] <- v661
                                let v662 : int32 = v656 + 1
                                v654.l0 <- v662
                                ()
                            struct (v643, v653)
                        else
                            let v663 : int32 = v643 - 1
                            struct (v663, v644)
                let v668 : int32 = v639 + 1
                v637.l0 <- v668
                v637.l1 <- v666
                v637.l2 <- v667
                ()
            let struct (v669 : int32, v670 : (string [])) = v637.l1, v637.l2
            let v671 : string seq = seq { for i = 0 to v670.Length - 1 do yield v670.[i] }
            let v672 : char option = None
            let v673 : bool = true in let mutable _v672 = v672
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v674 : string = "std::path::MAIN_SEPARATOR"
            let v675 : char = Fable.Core.RustInterop.emitRustExpr () v674
            v675
#endif
            
#if FABLE_COMPILER_RUST && WASM
            let v676 : char = null |> unbox<char>
            v676
#endif
            
#if FABLE_COMPILER_RUST && CONTRACT
            let v677 : char = null |> unbox<char>
            v677
#endif
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v678 : char = System.IO.Path.DirectorySeparatorChar
            v678
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v679 : char = null |> unbox<char>
            v679
#endif
            
#if FABLE_COMPILER_PYTHON
            let v680 : char = null |> unbox<char>
            v680
#endif
            |> fun x -> _v672 <- Some x
            let v681 : char = _v672.Value
            let v682 : (char -> string) = _.ToString()
            let v683 : string = v682 v681
            let v684 : string = method21(v683)
            let v685 : (string -> (string seq -> string)) = String.concat
            let v686 : (string seq -> string) = v685 v684
            v686 v671
        else
            let v688 : string = "std::fs::canonicalize(&*$0)"
            let v689 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v513 v688
            let v690 : string = "$0.unwrap()"
            let v691 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v689 v690
            let v692 : string = "$0.display()"
            let v693 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v691 v692
            let v694 : std_string_String option = None
            let v695 : bool = true in let mutable _v694 = v694
            
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
            
#if !FABLE_COMPILER && !WASM && !CONTRACT
            let v702 : std_string_String = null |> unbox<std_string_String>
            v702
#endif
            
#if FABLE_COMPILER_TYPESCRIPT
            let v703 : std_string_String = null |> unbox<std_string_String>
            v703
#endif
            
#if FABLE_COMPILER_PYTHON
            let v704 : std_string_String = null |> unbox<std_string_String>
            v704
#endif
            |> fun x -> _v694 <- Some x
            let v705 : std_string_String = _v694.Value
            let v706 : string = "fable_library_rust::String_::fromString($0)"
            let v707 : string = Fable.Core.RustInterop.emitRustExpr v705 v706
            v707
    v708
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v709 : string = null |> unbox<string>
    v709
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v710 : string = null |> unbox<string>
    v710
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v711 : string = method22(v84)
    let v712 : (string -> string) = System.IO.Path.GetFullPath
    let v713 : string = v712 v711
    v713
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v714 : string = null |> unbox<string>
    v714
#endif
    
#if FABLE_COMPILER_PYTHON
    let v715 : string = null |> unbox<string>
    v715
#endif
    |> fun x -> _v511 <- Some x
    let v716 : string = _v511.Value
    let v717 : US0 = US0_1
    let v718 : (unit -> string) = closure10()
    let v719 : (unit -> string) = closure11(v98, v304, v510, v716)
    method3(v717, v718, v719)
    let v720 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = method23(v304, v510, v716)
    let v721 : string = "futures_lite::future::block_on($0)"
    let v722 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr v720 v721
    let v723 : string = "$0.unwrap()"
    let v724 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = Fable.Core.RustInterop.emitRustExpr v722 v723
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
