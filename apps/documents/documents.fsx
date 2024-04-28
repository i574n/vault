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
and [<Struct>] US9 =
    | US9_0 of f0_0 : string
    | US9_1 of f1_0 : string * f1_1 : string
and [<Struct>] US8 =
    | US8_0 of f0_0 : US9
    | US8_1
and Mut4 = {mutable l0 : int32}
and UH0 =
    | UH0_0
    | UH0_1 of char * UH0
and [<Struct>] US11 =
    | US11_0
    | US11_1
and [<Struct>] US10 =
    | US10_0
    | US10_1 of f1_0 : US11
    | US10_2
and UH1 =
    | UH1_0
    | UH1_1 of string * UH1
and [<Struct>] US12 =
    | US12_0
    | US12_1 of f1_0 : char
    | US12_2 of f2_0 : uint8
and [<Struct>] US13 =
    | US13_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>
    | US13_1 of f1_0 : std_string_String
and [<Struct>] US14 =
    | US14_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>
    | US14_1
and [<Struct>] US15 =
    | US15_0 of f0_0 : std_string_String
    | US15_1 of f1_0 : std_string_String
and [<Struct>] US16 =
    | US16_0 of f0_0 : std_process_Output
    | US16_1 of f1_0 : std_string_String
and [<Struct>] US17 =
    | US17_0 of f0_0 : (struct (bool * string * int32) -> Async<unit>)
    | US17_1
and [<Struct>] US18 =
    | US18_0 of f0_0 : System.Threading.CancellationToken
    | US18_1
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
and method16 (v0 : string) : string =
    v0
and closure10 () () : string =
    let v0 : string = "documents.run"
    v0
and closure11 (v0 : string, v1 : string, v2 : string, v3 : string) () : string =
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"source_dir: {v1} / dist_dir: {v2} / cache_dir: {v3} / hangul_spec: %A{v0} / {v4 ()}"
    v5
and method20 (v0 : async_walkdir_DirEntry) : async_walkdir_DirEntry =
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
and method21 () : (std_io_Error -> std_string_String) =
    closure13()
and closure14 () (v0 : std_fs_FileType) : US5 =
    US5_0(v0)
and closure15 () (v0 : std_string_String) : US5 =
    US5_1(v0)
and method22 (v0 : std_fs_FileType) : std_fs_FileType =
    v0
and method23 (v0 : US4) : US4 =
    v0
and method19 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<Send<Dyn<std_future_Future<US4>>>>> =
    let v1 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : async_walkdir_DirEntry = method20(v0)
    let v3 : string = "Box::pin(async_walkdir::DirEntry::file_type(&v2))"
    let v4 : std_pin_Pin<Box<Send<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>>>> = Fable.Core.RustInterop.emitRustExpr () v3
    let v5 : string = "v4.await"
    let v6 : Result<std_fs_FileType, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v5
    let v7 : (std_io_Error -> std_string_String) = method21()
    let v8 : string = "$0.map_err(|x| $1(x))"
    let v9 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6, v7) v8
    let v10 : (std_fs_FileType -> US5) = closure14()
    let v11 : (std_string_String -> US5) = closure15()
    let v12 : US5 = match v9 with Ok x -> v10 x | Error x -> v11 x
    let v73 : US4 =
        match v12 with
        | US5_0(v13) -> (* Ok *)
            let v14 : std_fs_FileType = method22(v13)
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
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
    let v74 : US4 = method23(v73)
    let v75 : string = "v74 }})"
    Fable.Core.RustInterop.emitRustExpr () v75
    let v76 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v76
    let v77 : string = "__result"
    let v78 : std_pin_Pin<Box<Send<Dyn<std_future_Future<US4>>>>> = Fable.Core.RustInterop.emitRustExpr () v77
    v78
and method24 (v0 : async_walkdir_Filtering) : async_walkdir_Filtering =
    v0
and method18 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>> =
    let v1 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : std_pin_Pin<Box<Send<Dyn<std_future_Future<US4>>>>> = method19(v0)
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
    let v14 : async_walkdir_Filtering = method24(v13)
    let v15 : string = "v14 }})"
    Fable.Core.RustInterop.emitRustExpr () v15
    let v16 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v16
    let v17 : string = "__result"
    let v18 : std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>> = Fable.Core.RustInterop.emitRustExpr () v17
    v18
and closure12 () (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>> =
    method18(v0)
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
    let v1 : (std_io_Error -> std_string_String) = method21()
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
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
and method25 () : (Result<async_walkdir_DirEntry, std_io_Error> -> string option) =
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
and method26 () : string =
    let v0 : string = "^\\\\\\\\\\?\\\\"
    v0
and method27 (v0 : string) : string =
    v0
and method28 () : string =
    let v0 : string = ""
    v0
and method29 () : struct (string * string) =
    let v0 : string = ""
    struct (v0, v0)
and method30 (v0 : int32, v1 : Mut4) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure25 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure24 () (v0 : char) : (UH0 -> UH0) =
    closure25(v0)
and method31 () : (char -> (UH0 -> UH0)) =
    closure24()
and method32 (v0 : string, v1 : string, v2 : UH0, v3 : US10) : struct (string * string) =
    match v2 with
    | UH0_1(v4, v5) -> (* Cons *)
        let v6 : bool = '"' = v4
        if v6 then
            let v8 : bool = v1 = ""
            if v8 then
                let v9 : US11 = US11_0
                let v10 : US10 = US10_1(v9)
                method32(v0, v1, v5, v10)
            else
                match v3 with
                | US10_2 -> (* Arguments *)
                    let v38 : string = $"{v0}{v4}"
                    let v39 : US10 = US10_2
                    method32(v38, v1, v5, v39)
                | US10_1(v13) -> (* Path *)
                    match v13 with
                    | US11_0 -> (* Quoted *)
                        let v14 : US11 = US11_1
                        let v15 : US10 = US10_1(v14)
                        method32(v0, v1, v5, v15)
                    | _ ->
                        let v18 : bool = ' ' = v4
                        if v18 then
                            let v19 : US10 = US10_2
                            method32(v0, v1, v5, v19)
                        else
                            let v22 : string = $"{v1}{v4}"
                            method32(v0, v22, v5, v3)
                | US10_0 -> (* Start *)
                    let v29 : bool = ' ' = v4
                    if v29 then
                        let v30 : US10 = US10_2
                        method32(v0, v1, v5, v30)
                    else
                        let v33 : string = $"{v1}{v4}"
                        method32(v0, v33, v5, v3)
        else
            let v50 : bool = ''' = v4
            if v50 then
                let v52 : bool = v1 = ""
                if v52 then
                    let v53 : US11 = US11_0
                    let v54 : US10 = US10_1(v53)
                    method32(v0, v1, v5, v54)
                else
                    match v3 with
                    | US10_2 -> (* Arguments *)
                        let v82 : string = $"{v0}{v4}"
                        let v83 : US10 = US10_2
                        method32(v82, v1, v5, v83)
                    | US10_1(v57) -> (* Path *)
                        match v57 with
                        | US11_0 -> (* Quoted *)
                            let v58 : US11 = US11_1
                            let v59 : US10 = US10_1(v58)
                            method32(v0, v1, v5, v59)
                        | _ ->
                            let v62 : bool = ' ' = v4
                            if v62 then
                                let v63 : US10 = US10_2
                                method32(v0, v1, v5, v63)
                            else
                                let v66 : string = $"{v1}{v4}"
                                method32(v0, v66, v5, v3)
                    | US10_0 -> (* Start *)
                        let v73 : bool = ' ' = v4
                        if v73 then
                            let v74 : US10 = US10_2
                            method32(v0, v1, v5, v74)
                        else
                            let v77 : string = $"{v1}{v4}"
                            method32(v0, v77, v5, v3)
            else
                match v3 with
                | US10_2 -> (* Arguments *)
                    let v126 : string = $"{v0}{v4}"
                    let v127 : US10 = US10_2
                    method32(v126, v1, v5, v127)
                | US10_1(v94) -> (* Path *)
                    match v94 with
                    | US11_0 -> (* Quoted *)
                        let v95 : bool = ' ' = v4
                        if v95 then
                            let v96 : string = $"{v1} "
                            let v97 : US11 = US11_0
                            let v98 : US10 = US10_1(v97)
                            method32(v0, v96, v5, v98)
                        else
                            let v101 : string = $"{v1}{v4}"
                            method32(v0, v101, v5, v3)
                    | _ ->
                        let v106 : bool = ' ' = v4
                        if v106 then
                            let v107 : US10 = US10_2
                            method32(v0, v1, v5, v107)
                        else
                            let v110 : string = $"{v1}{v4}"
                            method32(v0, v110, v5, v3)
                | US10_0 -> (* Start *)
                    let v117 : bool = ' ' = v4
                    if v117 then
                        let v118 : US10 = US10_2
                        method32(v0, v1, v5, v118)
                    else
                        let v121 : string = $"{v1}{v4}"
                        method32(v0, v121, v5, v3)
    | _ ->
        match v3 with
        | US10_2 -> (* Arguments *)
            let v152 : string = "\\"
            let v153 : string = "/"
            let v154 : string = v1.Replace (v152, v153)
            struct (v154, v0)
        | US10_1(v140) -> (* Path *)
            match v140 with
            | US11_0 -> (* Quoted *)
                let v141 : string = "\\"
                let v142 : string = "/"
                let v143 : string = v1.Replace (v141, v142)
                struct (v143, v0)
            | _ ->
                let v144 : string = "\\"
                let v145 : string = "/"
                let v146 : string = v1.Replace (v144, v145)
                struct (v146, v0)
        | US10_0 -> (* Start *)
            let v149 : string = "\\"
            let v150 : string = "/"
            let v151 : string = v1.Replace (v149, v150)
            struct (v151, v0)
and method36 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = method36(v3, v1)
        UH1_1(v2, v4)
    | UH1_0 -> (* Nil *)
        v1
and method35 (v0 : string, v1 : UH1, v2 : UH0, v3 : US12) : struct (UH1 * string) =
    match v3 with
    | US12_2(v44) -> (* Escaped *)
        match v2 with
        | UH0_1(v45, v46) -> (* Cons *)
            let v47 : bool = '\\' = v45
            if v47 then
                let v48 : char = '\\'
                let v49 : US12 = US12_1(v48)
                method34(v0, v1, v46, v3, v49)
            else
                let v52 : bool = '"' = v45
                if v52 then
                    let v54 : bool =
                        match v3 with
                        | US12_0 -> (* Start *)
                            true
                        | _ ->
                            false
                    if v54 then
                        method35(v0, v1, v46, v3)
                    else
                        let v57 : string = $"{v0}\""
                        let v58 : US12 = US12_2(v44)
                        method34(v57, v1, v46, v3, v58)
                else
                    let v63 : bool = ' ' = v45
                    if v63 then
                        let v64 : string = $"{v0} "
                        method35(v64, v1, v46, v3)
                    else
                        let v67 : bool = 1uy = v44
                        if v67 then
                            let v68 : bool = v3 <> v3
                            if v68 then
                                let v69 : string = $"{v0}\{v45}"
                                method35(v69, v1, v46, v3)
                            else
                                let v72 : string = $"{v0}{v45}"
                                method35(v72, v1, v46, v3)
                        else
                            let v77 : string = $"{v0}{v45}"
                            method35(v77, v1, v46, v3)
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
                        method36(v1, v92)
                struct (v94, v0)
            else
                let v96 : bool = v0 = ""
                let v100 : UH1 =
                    if v96 then
                        v1
                    else
                        let v97 : UH1 = UH1_0
                        let v98 : UH1 = UH1_1(v0, v97)
                        method36(v1, v98)
                struct (v100, v0)
    | US12_1(v105) -> (* Quoted *)
        let v106 : bool = '"' = v105
        if v106 then
            match v2 with
            | UH0_1(v107, v108) -> (* Cons *)
                let v109 : bool = '"' = v107
                if v109 then
                    let v110 : US12 = US12_1('\\')
                    let v111 : bool = v3 = v110
                    if v111 then
                        let v112 : US12 = US12_0
                        method34(v0, v1, v108, v3, v112)
                    else
                        let v115 : bool = '\\' = v105
                        if v115 then
                            let v116 : US12 = US12_2(0uy)
                            let v117 : bool = v3 <> v116
                            if v117 then
                                let v118 : string = $"{v0}\""
                                let v119 : char = '"'
                                let v120 : US12 = US12_1(v119)
                                method34(v118, v1, v108, v3, v120)
                            else
                                let v123 : US12 = US12_1('\\')
                                let v124 : bool = v3 = v123
                                if v124 then
                                    let v125 : string = $"{v0}\""
                                    let v126 : char = '"'
                                    let v127 : US12 = US12_1(v126)
                                    method34(v125, v1, v108, v3, v127)
                                else
                                    let v130 : US12 = US12_0
                                    method34(v0, v1, v108, v3, v130)
                        else
                            let v137 : bool = '\\' = v107
                            if v137 then
                                let v138 : uint8 = 1uy
                                let v139 : US12 = US12_2(v138)
                                method34(v0, v1, v108, v3, v139)
                            else
                                let v142 : US12 = US12_2(0uy)
                                let v143 : bool = v3 = v142
                                if v143 then
                                    let v144 : string = $"{v0}\""
                                    let v145 : char = '"'
                                    let v146 : US12 = US12_1(v145)
                                    method34(v144, v1, v108, v3, v146)
                                else
                                    let v149 : UH1 = UH1_0
                                    let v150 : UH1 = UH1_1(v0, v149)
                                    let v151 : UH1 = method36(v1, v150)
                                    let v152 : string = ""
                                    let v153 : US12 = US12_0
                                    method34(v152, v151, v108, v3, v153)
                else
                    let v164 : bool = '\\' = v105
                    if v164 then
                        let v165 : bool = '\\' = v107
                        if v165 then
                            let v166 : uint8 = 1uy
                            let v167 : US12 = US12_2(v166)
                            method34(v0, v1, v108, v3, v167)
                        else
                            let v170 : bool = ' ' = v107
                            if v170 then
                                let v171 : string = $"{v0} "
                                method35(v171, v1, v108, v3)
                            else
                                let v174 : string = $"{v0}{v107}"
                                method35(v174, v1, v108, v3)
                    else
                        let v181 : bool = '\\' = v107
                        if v181 then
                            let v182 : uint8 = 1uy
                            let v183 : US12 = US12_2(v182)
                            method34(v0, v1, v108, v3, v183)
                        else
                            let v186 : bool = ' ' = v107
                            if v186 then
                                let v187 : string = $"{v0} "
                                method35(v187, v1, v108, v3)
                            else
                                let v190 : string = $"{v0}{v107}"
                                method35(v190, v1, v108, v3)
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
                            method36(v1, v205)
                    struct (v207, v0)
                else
                    let v209 : bool = v0 = ""
                    let v213 : UH1 =
                        if v209 then
                            v1
                        else
                            let v210 : UH1 = UH1_0
                            let v211 : UH1 = UH1_1(v0, v210)
                            method36(v1, v211)
                    struct (v213, v0)
        else
            let v218 : bool = '\\' = v105
            if v218 then
                match v2 with
                | UH0_1(v219, v220) -> (* Cons *)
                    let v221 : bool = '"' = v219
                    if v221 then
                        let v222 : US12 = US12_2(0uy)
                        let v223 : bool = v3 <> v222
                        if v223 then
                            let v224 : string = $"{v0}\""
                            let v225 : char = '"'
                            let v226 : US12 = US12_1(v225)
                            method34(v224, v1, v220, v3, v226)
                        else
                            let v229 : US12 = US12_1('\\')
                            let v230 : bool = v3 = v229
                            if v230 then
                                let v231 : string = $"{v0}\""
                                let v232 : char = '"'
                                let v233 : US12 = US12_1(v232)
                                method34(v231, v1, v220, v3, v233)
                            else
                                let v236 : US12 = US12_0
                                method34(v0, v1, v220, v3, v236)
                    else
                        let v243 : bool = '\\' = v219
                        if v243 then
                            let v244 : uint8 = 1uy
                            let v245 : US12 = US12_2(v244)
                            method34(v0, v1, v220, v3, v245)
                        else
                            let v248 : bool = ' ' = v219
                            if v248 then
                                let v249 : string = $"{v0} "
                                method35(v249, v1, v220, v3)
                            else
                                let v252 : string = $"{v0}{v219}"
                                method35(v252, v1, v220, v3)
                | _ ->
                    let v262 : bool = v0 = ""
                    let v266 : UH1 =
                        if v262 then
                            v1
                        else
                            let v263 : UH1 = UH1_0
                            let v264 : UH1 = UH1_1(v0, v263)
                            method36(v1, v264)
                    struct (v266, v0)
            else
                match v2 with
                | UH0_1(v269, v270) -> (* Cons *)
                    let v271 : bool = '\\' = v269
                    if v271 then
                        let v272 : uint8 = 1uy
                        let v273 : US12 = US12_2(v272)
                        method34(v0, v1, v270, v3, v273)
                    else
                        let v276 : bool = '"' = v269
                        if v276 then
                            let v277 : US12 = US12_2(0uy)
                            let v278 : bool = v3 = v277
                            if v278 then
                                let v279 : string = $"{v0}\""
                                let v280 : char = '"'
                                let v281 : US12 = US12_1(v280)
                                method34(v279, v1, v270, v3, v281)
                            else
                                let v284 : UH1 = UH1_0
                                let v285 : UH1 = UH1_1(v0, v284)
                                let v286 : UH1 = method36(v1, v285)
                                let v287 : string = ""
                                let v288 : US12 = US12_0
                                method34(v287, v286, v270, v3, v288)
                        else
                            let v293 : bool = ' ' = v269
                            if v293 then
                                let v294 : string = $"{v0} "
                                method35(v294, v1, v270, v3)
                            else
                                let v297 : string = $"{v0}{v269}"
                                method35(v297, v1, v270, v3)
                | _ ->
                    let v307 : bool = v0 = ""
                    let v311 : UH1 =
                        if v307 then
                            v1
                        else
                            let v308 : UH1 = UH1_0
                            let v309 : UH1 = UH1_1(v0, v308)
                            method36(v1, v309)
                    struct (v311, v0)
    | US12_0 -> (* Start *)
        match v2 with
        | UH0_1(v4, v5) -> (* Cons *)
            let v6 : bool = '"' = v4
            if v6 then
                let v7 : string = ""
                let v8 : char = '"'
                let v9 : US12 = US12_1(v8)
                method34(v7, v1, v5, v3, v9)
            else
                let v12 : bool = '\\' = v4
                if v12 then
                    let v13 : uint8 = 0uy
                    let v14 : US12 = US12_2(v13)
                    method34(v0, v1, v5, v3, v14)
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
                                method36(v1, v21)
                        let v24 : string = ""
                        method35(v24, v23, v5, v3)
                    else
                        let v27 : string = $"{v0}{v4}"
                        method35(v27, v1, v5, v3)
        | _ ->
            let v37 : bool = v0 = ""
            let v41 : UH1 =
                if v37 then
                    v1
                else
                    let v38 : UH1 = UH1_0
                    let v39 : UH1 = UH1_1(v0, v38)
                    method36(v1, v39)
            struct (v41, v0)
and method34 (v0 : string, v1 : UH1, v2 : UH0, v3 : US12, v4 : US12) : struct (UH1 * string) =
    match v4 with
    | US12_2(v45) -> (* Escaped *)
        match v2 with
        | UH0_1(v46, v47) -> (* Cons *)
            let v48 : bool = '\\' = v46
            if v48 then
                let v49 : char = '\\'
                let v50 : US12 = US12_1(v49)
                method34(v0, v1, v47, v4, v50)
            else
                let v53 : bool = '"' = v46
                if v53 then
                    let v55 : bool =
                        match v3 with
                        | US12_0 -> (* Start *)
                            true
                        | _ ->
                            false
                    if v55 then
                        method35(v0, v1, v47, v4)
                    else
                        let v58 : string = $"{v0}\""
                        let v59 : US12 = US12_2(v45)
                        method34(v58, v1, v47, v4, v59)
                else
                    let v64 : bool = ' ' = v46
                    if v64 then
                        let v65 : string = $"{v0} "
                        method35(v65, v1, v47, v4)
                    else
                        let v68 : bool = 1uy = v45
                        if v68 then
                            let v69 : bool = v3 <> v4
                            if v69 then
                                let v70 : string = $"{v0}\{v46}"
                                method34(v70, v1, v47, v4, v3)
                            else
                                let v73 : string = $"{v0}{v46}"
                                method35(v73, v1, v47, v4)
                        else
                            let v78 : string = $"{v0}{v46}"
                            method35(v78, v1, v47, v4)
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
                        method36(v1, v93)
                struct (v95, v0)
            else
                let v97 : bool = v0 = ""
                let v101 : UH1 =
                    if v97 then
                        v1
                    else
                        let v98 : UH1 = UH1_0
                        let v99 : UH1 = UH1_1(v0, v98)
                        method36(v1, v99)
                struct (v101, v0)
    | US12_1(v106) -> (* Quoted *)
        let v107 : bool = '"' = v106
        if v107 then
            match v2 with
            | UH0_1(v108, v109) -> (* Cons *)
                let v110 : bool = '"' = v108
                if v110 then
                    let v111 : US12 = US12_1('\\')
                    let v112 : bool = v3 = v111
                    if v112 then
                        let v113 : US12 = US12_0
                        method34(v0, v1, v109, v4, v113)
                    else
                        let v116 : bool = '\\' = v106
                        if v116 then
                            let v117 : US12 = US12_2(0uy)
                            let v118 : bool = v3 <> v117
                            if v118 then
                                let v119 : string = $"{v0}\""
                                let v120 : char = '"'
                                let v121 : US12 = US12_1(v120)
                                method34(v119, v1, v109, v4, v121)
                            else
                                let v124 : US12 = US12_1('\\')
                                let v125 : bool = v3 = v124
                                if v125 then
                                    let v126 : string = $"{v0}\""
                                    let v127 : char = '"'
                                    let v128 : US12 = US12_1(v127)
                                    method34(v126, v1, v109, v4, v128)
                                else
                                    let v131 : US12 = US12_0
                                    method34(v0, v1, v109, v4, v131)
                        else
                            let v138 : bool = '\\' = v108
                            if v138 then
                                let v139 : uint8 = 1uy
                                let v140 : US12 = US12_2(v139)
                                method34(v0, v1, v109, v4, v140)
                            else
                                let v143 : US12 = US12_2(0uy)
                                let v144 : bool = v3 = v143
                                if v144 then
                                    let v145 : string = $"{v0}\""
                                    let v146 : char = '"'
                                    let v147 : US12 = US12_1(v146)
                                    method34(v145, v1, v109, v4, v147)
                                else
                                    let v150 : UH1 = UH1_0
                                    let v151 : UH1 = UH1_1(v0, v150)
                                    let v152 : UH1 = method36(v1, v151)
                                    let v153 : string = ""
                                    let v154 : US12 = US12_0
                                    method34(v153, v152, v109, v4, v154)
                else
                    let v165 : bool = '\\' = v106
                    if v165 then
                        let v166 : bool = '\\' = v108
                        if v166 then
                            let v167 : uint8 = 1uy
                            let v168 : US12 = US12_2(v167)
                            method34(v0, v1, v109, v4, v168)
                        else
                            let v171 : bool = ' ' = v108
                            if v171 then
                                let v172 : string = $"{v0} "
                                method35(v172, v1, v109, v4)
                            else
                                let v175 : string = $"{v0}{v108}"
                                method35(v175, v1, v109, v4)
                    else
                        let v182 : bool = '\\' = v108
                        if v182 then
                            let v183 : uint8 = 1uy
                            let v184 : US12 = US12_2(v183)
                            method34(v0, v1, v109, v4, v184)
                        else
                            let v187 : bool = ' ' = v108
                            if v187 then
                                let v188 : string = $"{v0} "
                                method35(v188, v1, v109, v4)
                            else
                                let v191 : string = $"{v0}{v108}"
                                method35(v191, v1, v109, v4)
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
                            method36(v1, v206)
                    struct (v208, v0)
                else
                    let v210 : bool = v0 = ""
                    let v214 : UH1 =
                        if v210 then
                            v1
                        else
                            let v211 : UH1 = UH1_0
                            let v212 : UH1 = UH1_1(v0, v211)
                            method36(v1, v212)
                    struct (v214, v0)
        else
            let v219 : bool = '\\' = v106
            if v219 then
                match v2 with
                | UH0_1(v220, v221) -> (* Cons *)
                    let v222 : bool = '"' = v220
                    if v222 then
                        let v223 : US12 = US12_2(0uy)
                        let v224 : bool = v3 <> v223
                        if v224 then
                            let v225 : string = $"{v0}\""
                            let v226 : char = '"'
                            let v227 : US12 = US12_1(v226)
                            method34(v225, v1, v221, v4, v227)
                        else
                            let v230 : US12 = US12_1('\\')
                            let v231 : bool = v3 = v230
                            if v231 then
                                let v232 : string = $"{v0}\""
                                let v233 : char = '"'
                                let v234 : US12 = US12_1(v233)
                                method34(v232, v1, v221, v4, v234)
                            else
                                let v237 : US12 = US12_0
                                method34(v0, v1, v221, v4, v237)
                    else
                        let v244 : bool = '\\' = v220
                        if v244 then
                            let v245 : uint8 = 1uy
                            let v246 : US12 = US12_2(v245)
                            method34(v0, v1, v221, v4, v246)
                        else
                            let v249 : bool = ' ' = v220
                            if v249 then
                                let v250 : string = $"{v0} "
                                method35(v250, v1, v221, v4)
                            else
                                let v253 : string = $"{v0}{v220}"
                                method35(v253, v1, v221, v4)
                | _ ->
                    let v263 : bool = v0 = ""
                    let v267 : UH1 =
                        if v263 then
                            v1
                        else
                            let v264 : UH1 = UH1_0
                            let v265 : UH1 = UH1_1(v0, v264)
                            method36(v1, v265)
                    struct (v267, v0)
            else
                match v2 with
                | UH0_1(v270, v271) -> (* Cons *)
                    let v272 : bool = '\\' = v270
                    if v272 then
                        let v273 : uint8 = 1uy
                        let v274 : US12 = US12_2(v273)
                        method34(v0, v1, v271, v4, v274)
                    else
                        let v277 : bool = '"' = v270
                        if v277 then
                            let v278 : US12 = US12_2(0uy)
                            let v279 : bool = v3 = v278
                            if v279 then
                                let v280 : string = $"{v0}\""
                                let v281 : char = '"'
                                let v282 : US12 = US12_1(v281)
                                method34(v280, v1, v271, v4, v282)
                            else
                                let v285 : UH1 = UH1_0
                                let v286 : UH1 = UH1_1(v0, v285)
                                let v287 : UH1 = method36(v1, v286)
                                let v288 : string = ""
                                let v289 : US12 = US12_0
                                method34(v288, v287, v271, v4, v289)
                        else
                            let v294 : bool = ' ' = v270
                            if v294 then
                                let v295 : string = $"{v0} "
                                method35(v295, v1, v271, v4)
                            else
                                let v298 : string = $"{v0}{v270}"
                                method35(v298, v1, v271, v4)
                | _ ->
                    let v308 : bool = v0 = ""
                    let v312 : UH1 =
                        if v308 then
                            v1
                        else
                            let v309 : UH1 = UH1_0
                            let v310 : UH1 = UH1_1(v0, v309)
                            method36(v1, v310)
                    struct (v312, v0)
    | US12_0 -> (* Start *)
        match v2 with
        | UH0_1(v5, v6) -> (* Cons *)
            let v7 : bool = '"' = v5
            if v7 then
                let v8 : string = ""
                let v9 : char = '"'
                let v10 : US12 = US12_1(v9)
                method34(v8, v1, v6, v4, v10)
            else
                let v13 : bool = '\\' = v5
                if v13 then
                    let v14 : uint8 = 0uy
                    let v15 : US12 = US12_2(v14)
                    method34(v0, v1, v6, v4, v15)
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
                                method36(v1, v22)
                        let v25 : string = ""
                        method35(v25, v24, v6, v4)
                    else
                        let v28 : string = $"{v0}{v5}"
                        method35(v28, v1, v6, v4)
        | _ ->
            let v38 : bool = v0 = ""
            let v42 : UH1 =
                if v38 then
                    v1
                else
                    let v39 : UH1 = UH1_0
                    let v40 : UH1 = UH1_1(v0, v39)
                    method36(v1, v40)
            struct (v42, v0)
and method37 (v0 : UH1, v1 : string list) : string list =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : string list = method37(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH1_0 -> (* Nil *)
        v1
and method33 (v0 : string) : (string []) =
    let v1 : UH1 = UH1_0
    let v2 : string = ""
    let v3 : int32 = v0.Length
    let v4 : (char []) = Array.zeroCreate<char> (v3)
    let v5 : Mut4 = {l0 = 0} : Mut4
    while method30(v3, v5) do
        let v7 : int32 = v5.l0
        let v8 : char = v0.[int v7]
        v4.[int v7] <- v8
        let v9 : int32 = v7 + 1
        v5.l0 <- v9
        ()
    let v10 : ((char []) -> char list) = Array.toList
    let v11 : char list = v10 v4
    let v12 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v13 : (char -> (UH0 -> UH0)) = method31()
    let v14 : (char list -> (UH0 -> UH0)) = v12 v13
    let v15 : (UH0 -> UH0) = v14 v11
    let v16 : UH0 = UH0_0
    let v17 : UH0 = v15 v16
    let v18 : US12 = US12_0
    let v19 : US12 = US12_0
    let struct (v20 : UH1, v21 : string) = method34(v2, v1, v17, v19, v18)
    let v22 : string list = []
    let v23 : string list = method37(v20, v22)
    let v24 : (string list -> (string [])) = List.toArray
    v24 v23
and closure26 () (v0 : string) : std_string_String =
    let v1 : string = method13(v0)
    let v2 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4
    v5
and closure27 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (bool * string * int32) -> Async<unit>) option, v3 : string option, v4 : string, v5 : Vec<std_string_String>) () : string =
    let v6 : string = $"execute_with_options / file_name: {v4} / arguments: %A{v5} / options: %A{struct (v0, v1, v2, v3)}"
    v6
and method38 () : (unit -> string) =
    closure6()
and closure28 () (v0 : string) : US7 =
    US7_0(v0)
and method40 () : (string -> US7) =
    closure28()
and method41 (v0 : string) : string =
    v0
and method43 (v0 : std_sync_Mutex<std_process_Child option>) : std_sync_Mutex<std_process_Child option> =
    v0
and closure29 () (v0 : std_process_Child) : std_sync_Arc<std_sync_Mutex<std_process_Child option>> =
    let v1 : std_process_Child option = Some v0 
    let v2 : string = "std::sync::Mutex::new($0)"
    let v3 : std_sync_Mutex<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1 v2
    let v4 : std_sync_Mutex<std_process_Child option> = method43(v3)
    let v5 : string = "std::sync::Arc::new(v4)"
    let v6 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr () v5
    v6
and method42 () : (std_process_Child -> std_sync_Arc<std_sync_Mutex<std_process_Child option>>) =
    closure29()
and method44 (v0 : Result<std_process_Child, std_io_Error>) : Result<std_process_Child, std_io_Error> =
    v0
and closure30 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : US13 =
    US13_0(v0)
and closure31 () (v0 : std_string_String) : US13 =
    US13_1(v0)
and closure32 (v0 : std_string_String) () : string =
    let v1 : string = $"execute_with_options -1 / error: {v0}"
    v1
and method45 (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : std_sync_Arc<std_sync_Mutex<std_process_Child option>> =
    v0
and method46 (v0 : std_sync_Mutex<std_process_ChildStdout option>) : std_sync_Mutex<std_process_ChildStdout option> =
    v0
and method47 (v0 : std_sync_Mutex<std_process_ChildStderr option>) : std_sync_Mutex<std_process_ChildStderr option> =
    v0
and method48 (v0 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> =
    v0
and method49 (v0 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>) : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> =
    v0
and method50 (v0 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>) : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> =
    v0
and method51 (v0 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>>) : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> =
    v0
and closure34 () (v0 : std_string_String) : US15 =
    US15_0(v0)
and closure35 () (v0 : std_string_String) : US15 =
    US15_1(v0)
and closure36 (v0 : std_string_String) () : string =
    let v1 : string = $"execute_with_options / stdout_line / stdout: {true} / e: {v0}"
    v1
and closure37 (v0 : std_string_String) () : string =
    let v1 : string = $"> {v0}"
    v1
and closure33 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) (v1 : Result<std_string_String, std_io_Error>) : unit =
    let v2 : (std_io_Error -> std_string_String) = method21()
    let v3 : string = "$0.map_err(|x| $1(x))"
    let v4 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1, v2) v3
    let v5 : (std_string_String -> US15) = closure34()
    let v6 : (std_string_String -> US15) = closure35()
    let v7 : US15 = match v4 with Ok x -> v5 x | Error x -> v6 x
    let v23 : std_string_String =
        match v7 with
        | US15_1(v12) -> (* Error *)
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
        | US15_0(v8) -> (* Ok *)
            let v9 : US0 = US0_0
            let v10 : (unit -> string) = closure37(v8)
            let v11 : (unit -> string) = closure6()
            method3(v9, v10, v11)
            v8
    let v24 : string = "true; $0.lock().unwrap().send($1).unwrap()"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr struct (v0, v23) v24
    ()
and method52 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) : (Result<std_string_String, std_io_Error> -> unit) =
    closure33(v0)
and method53 (v0 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>>) : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>> =
    v0
and closure39 (v0 : std_string_String) () : string =
    let v1 : string = $"execute_with_options / stdout_line / stdout: {false} / e: {v0}"
    v1
and closure38 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) (v1 : Result<std_string_String, std_io_Error>) : unit =
    let v2 : (std_io_Error -> std_string_String) = method21()
    let v3 : string = "$0.map_err(|x| $1(x))"
    let v4 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1, v2) v3
    let v5 : (std_string_String -> US15) = closure34()
    let v6 : (std_string_String -> US15) = closure35()
    let v7 : US15 = match v4 with Ok x -> v5 x | Error x -> v6 x
    let v23 : std_string_String =
        match v7 with
        | US15_1(v12) -> (* Error *)
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
        | US15_0(v8) -> (* Ok *)
            let v9 : US0 = US0_0
            let v10 : (unit -> string) = closure37(v8)
            let v11 : (unit -> string) = closure6()
            method3(v9, v10, v11)
            v8
    let v24 : string = "true; $0.lock().unwrap().send($1).unwrap()"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr struct (v0, v23) v24
    ()
and method54 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) : (Result<std_string_String, std_io_Error> -> unit) =
    closure38(v0)
and closure40 () (v0 : std_process_Output) : US16 =
    US16_0(v0)
and closure41 () (v0 : std_string_String) : US16 =
    US16_1(v0)
and closure42 (v0 : std_string_String) () : string =
    let v1 : string = $"execute_with_options -2 / error: {v0}"
    v1
and closure43 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"execute_with_options / exit_code: {v0} / std_trace.Length: {v1.Length}"
    v2
and method55 (v0 : (int32 * string)) : (int32 * string) =
    v0
and method39 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (bool * string * int32) -> Async<unit>) option, v3 : string option, v4 : string, v5 : Vec<std_string_String>) : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> =
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
    let v21 : (string -> US7) = method40()
    let v22 : US7 = US7_1
    let v23 : US7 = v3 |> Option.map v21 |> Option.defaultValue v22 
    let v29 : Ref<Mut<std_process_Command>> =
        match v23 with
        | US7_1 -> (* None *)
            v20
        | US7_0(v24) -> (* Some *)
            let v25 : string = method41(v24)
            let v26 : string = "std::process::Command::current_dir(v20, &*v25)"
            let v27 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr () v26
            v27
    let v30 : string = "true; let mut v29 = v29"
    let v31 : bool = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : string = "std::process::Command::spawn(&mut $0)"
    let v33 : Result<std_process_Child, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v29 v32
    let v34 : (std_process_Child -> std_sync_Arc<std_sync_Mutex<std_process_Child option>>) = method42()
    let v35 : Result<std_process_Child, std_io_Error> = method44(v33)
    let v36 : string = "v35.map(|x| v34(x))"
    let v37 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : (std_io_Error -> std_string_String) = method21()
    let v39 : string = "$0.map_err(|x| $1(x))"
    let v40 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v37, v38) v39
    let v41 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US13) = closure30()
    let v42 : (std_string_String -> US13) = closure31()
    let v43 : US13 = match v40 with Ok x -> v41 x | Error x -> v42 x
    let struct (v148 : int32, v149 : US3, v150 : US14) =
        match v43 with
        | US13_1(v139) -> (* Error *)
            let v140 : US0 = US0_4
            let v141 : (unit -> string) = closure32(v139)
            let v142 : (unit -> string) = closure6()
            method3(v140, v141, v142)
            let v143 : US3 = US3_0(v139)
            let v144 : US14 = US14_1
            struct (-1, v143, v144)
        | US13_0(v44) -> (* Ok *)
            let v45 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method45(v44)
            let v46 : string = "v45.lock().unwrap().as_mut().unwrap().stdout.take().unwrap()"
            let v47 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr () v46
            let v48 : string = "v45.lock().unwrap().as_mut().unwrap().stderr.take().unwrap()"
            let v49 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr () v48
            let v50 : std_process_ChildStdout option = Some v47 
            let v51 : string = "std::sync::Mutex::new($0)"
            let v52 : std_sync_Mutex<std_process_ChildStdout option> = Fable.Core.RustInterop.emitRustExpr v50 v51
            let v53 : std_sync_Mutex<std_process_ChildStdout option> = method46(v52)
            let v54 : string = "std::sync::Arc::new(v53)"
            let v55 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdout option>> = Fable.Core.RustInterop.emitRustExpr () v54
            let v56 : std_process_ChildStderr option = Some v49 
            let v57 : string = "std::sync::Mutex::new($0)"
            let v58 : std_sync_Mutex<std_process_ChildStderr option> = Fable.Core.RustInterop.emitRustExpr v56 v57
            let v59 : std_sync_Mutex<std_process_ChildStderr option> = method47(v58)
            let v60 : string = "std::sync::Arc::new(v59)"
            let v61 : std_sync_Arc<std_sync_Mutex<std_process_ChildStderr option>> = Fable.Core.RustInterop.emitRustExpr () v60
            let v62 : string = "{ let (sender, receiver) = std::sync::mpsc::channel(); (sender, std::sync::Arc::new(receiver)) }"
            let struct (v63 : std_sync_mpsc_Sender<std_string_String>, v64 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = Fable.Core.RustInterop.emitRustExpr () v62
            let v65 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> = method48(v64)
            let v66 : string = "true; let v65 = v65"
            let v67 : bool = Fable.Core.RustInterop.emitRustExpr v65 v66
            let v68 : string = "std::sync::Mutex::new($0)"
            let v69 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v63 v68
            let v70 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = method49(v69)
            let v71 : string = "std::sync::Arc::new(v70)"
            let v72 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v71
            let v73 : string = "v72.clone()"
            let v74 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v73
            let v75 : string = "v72.clone()"
            let v76 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v75
            let v77 : string = "std::sync::Mutex::new($0)"
            let v78 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v65 v77
            let v79 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = method50(v78)
            let v80 : string = "std::sync::Arc::new(v79)"
            let v81 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v80
            let v82 : string = "std::thread::spawn(move || { //"
            let v83 : std_thread_JoinHandle<unit> = Fable.Core.RustInterop.emitRustExpr () v82
            let v84 : string = "std::io::BufRead::lines(std::io::BufReader::new(v55.lock().unwrap().take().unwrap()))"
            let v85 : std_io_Lines<std_io_BufReader<std_process_ChildStdout>> = Fable.Core.RustInterop.emitRustExpr () v84
            let v86 : string = "std::sync::Mutex::new($0)"
            let v87 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> = Fable.Core.RustInterop.emitRustExpr v85 v86
            let v88 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>> = method51(v87)
            let v89 : string = "std::sync::Arc::new(v88)"
            let v90 : std_sync_Arc<std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStdout>>>> = Fable.Core.RustInterop.emitRustExpr () v89
            let v91 : (Result<std_string_String, std_io_Error> -> unit) = method52(v74)
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
            let v102 : std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>> = method53(v101)
            let v103 : string = "std::sync::Arc::new(v102)"
            let v104 : std_sync_Arc<std_sync_Mutex<std_io_Lines<std_io_BufReader<std_process_ChildStderr>>>> = Fable.Core.RustInterop.emitRustExpr () v103
            let v105 : (Result<std_string_String, std_io_Error> -> unit) = method54(v72)
            let v106 : string = "true; for line in $0.lock().unwrap().by_ref() { v105(line) }"
            let v107 : bool = Fable.Core.RustInterop.emitRustExpr v104 v106
            let v108 : string = "true; })"
            let v109 : bool = Fable.Core.RustInterop.emitRustExpr () v108
            let v110 : string = "v45.lock().unwrap().take().unwrap().wait_with_output()"
            let v111 : Result<std_process_Output, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v110
            let v112 : (std_io_Error -> std_string_String) = method21()
            let v113 : string = "$0.map_err(|x| $1(x))"
            let v114 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v111, v112) v113
            let v115 : string = "true; v83.join().unwrap()"
            let v116 : bool = Fable.Core.RustInterop.emitRustExpr () v115
            let v117 : string = "true; v97.join().unwrap()"
            let v118 : bool = Fable.Core.RustInterop.emitRustExpr () v117
            let v119 : (std_process_Output -> US16) = closure40()
            let v120 : (std_string_String -> US16) = closure41()
            let v121 : US16 = match v114 with Ok x -> v119 x | Error x -> v120 x
            match v121 with
            | US16_1(v127) -> (* Error *)
                let v128 : US0 = US0_4
                let v129 : (unit -> string) = closure42(v127)
                let v130 : (unit -> string) = closure6()
                method3(v128, v129, v130)
                let v131 : US3 = US3_0(v127)
                let v132 : US14 = US14_1
                struct (-2, v131, v132)
            | US16_0(v122) -> (* Ok *)
                let v123 : string = "$0.status.code().unwrap()"
                let v124 : int32 = Fable.Core.RustInterop.emitRustExpr v122 v123
                let v125 : US3 = US3_1
                let v126 : US14 = US14_0(v81)
                struct (v124, v125, v126)
    let v157 : US3 =
        match v150 with
        | US14_1 -> (* None *)
            US3_1
        | US14_0(v151) -> (* Some *)
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
    let v183 : (int32 * string) = method55(v182)
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
and closure46 () (v0 : (struct (bool * string * int32) -> Async<unit>)) : US17 =
    US17_0(v0)
and method56 () : ((struct (bool * string * int32) -> Async<unit>) -> US17) =
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v12 : Async<unit> option = None
    let mutable _v12 = v12
    async {
    let v13 : string = v6.Data
    let v14 : string = null |> unbox<string>
    let v15 : bool = v13 = v14
    let v16 : bool = v15 <> true
    if v16 then
        let v17 : ((struct (bool * string * int32) -> Async<unit>) -> US17) = method56()
        let v18 : US17 = US17_1
        let v19 : US17 = v2 |> Option.map v17 |> Option.defaultValue v18 
        match v19 with
        | US17_1 -> (* None *)
            ()
        | US17_0(v20) -> (* Some *)
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v12 : Async<unit> option = None
    let mutable _v12 = v12
    async {
    let v13 : string = v6.Data
    let v14 : string = null |> unbox<string>
    let v15 : bool = v13 = v14
    let v16 : bool = v15 <> true
    if v16 then
        let v17 : ((struct (bool * string * int32) -> Async<unit>) -> US17) = method56()
        let v18 : US17 = US17_1
        let v19 : US17 = v2 |> Option.map v17 |> Option.defaultValue v18 
        match v19 with
        | US17_1 -> (* None *)
            ()
        | US17_0(v20) -> (* Some *)
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
and closure49 () (v0 : System.Threading.CancellationToken) : US18 =
    US18_0(v0)
and method57 () : (System.Threading.CancellationToken -> US18) =
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
and method58 () : string =
    let v0 : string = "\n"
    v0
and closure52 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"execute_with_options_async / exit_code: {v0} / output.Length: {v1.Length}"
    v2
and closure53 () () : string =
    let v0 : string = "documents.run / par_map"
    v0
and closure54 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : int32, v5 : string, v6 : int32, v7 : string, v8 : string) () : string =
    let v9 : (unit -> string) = closure6()
    let v10 : string = $"file: {v0} / real_path: {v2} / relative_path: {v1} / origin_hash_exit_code: {v4} / origin_hash: {v3} / local_git_hash_exit_code: {v6} / local_git_hash: {v5} / hash1: {v7} / hash2: %A{v8} / {v9 ()}"
    v10
and closure55 () () : string =
    let v0 : string = "documents.run / par_map / crowbook"
    v0
and closure56 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: %A{v1} / result: {v0} / {v2 ()}"
    v3
and method59 (v0 : string) : string =
    v0
and closure57 () () : string =
    let v0 : string = "documents.run / par_map / files"
    v0
and closure58 (v0 : (US8 [])) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"files: %A{v0} / {v1 ()}"
    v2
and closure23 (v0 : string, v1 : string, v2 : string) (v3 : string) : Result<struct (string * (US8 [])), std_string_String> =
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
    let v109 : string =
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
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
            v88
        else
            let v89 : string = "std::fs::canonicalize(&*$0)"
            let v90 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v6 v89
            let v91 : string = "$0.unwrap()"
            let v92 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v90 v91
            let v93 : string = "$0.display()"
            let v94 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v92 v93
            let v95 : std_string_String option = None
            let v96 : bool = true in let mutable _v95 = v95
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v97 : string = @$"format!(""{{}}"", $0)"
            let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr v94 v97
            v98
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v99 : string = @$"format!(""{{}}"", $0)"
            let v100 : std_string_String = Fable.Core.RustInterop.emitRustExpr v94 v99
            v100
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v101 : string = @$"format!(""{{}}"", $0)"
            let v102 : std_string_String = Fable.Core.RustInterop.emitRustExpr v94 v101
            v102
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v103 : std_string_String = null |> unbox<std_string_String>
            v103
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v104 : std_string_String = null |> unbox<std_string_String>
            v104
#endif
            #if FABLE_COMPILER_PYTHON
            let v105 : std_string_String = null |> unbox<std_string_String>
            v105
#endif
            |> fun x -> _v95 <- Some x
            let v106 : std_string_String = _v95.Value
            let v107 : string = "fable_library_rust::String_::fromString($0)"
            let v108 : string = Fable.Core.RustInterop.emitRustExpr v106 v107
            v108
    v109
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v110 : string = null |> unbox<string>
    v110
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v111 : string = null |> unbox<string>
    v111
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v112 : string = method16(v3)
    let v113 : (string -> string) = System.IO.Path.GetFullPath
    let v114 : string = v113 v112
    v114
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v115 : string = null |> unbox<string>
    v115
#endif
    #if FABLE_COMPILER_PYTHON
    let v116 : string = null |> unbox<string>
    v116
#endif
    |> fun x -> _v4 <- Some x
    let v117 : string = _v4.Value
    let v118 : string = method13(v117)
    let v119 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v120 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v118 v119
    let v121 : string = "String::from($0)"
    let v122 : std_string_String = Fable.Core.RustInterop.emitRustExpr v120 v121
    let v123 : string = "std::path::PathBuf::from($0)"
    let v124 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v122 v123
    let v125 : string = "$0.display()"
    let v126 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v124 v125
    let v127 : std_string_String option = None
    let v128 : bool = true in let mutable _v127 = v127
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v129 : string = @$"format!(""{{}}"", $0)"
    let v130 : std_string_String = Fable.Core.RustInterop.emitRustExpr v126 v129
    v130
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v131 : string = @$"format!(""{{}}"", $0)"
    let v132 : std_string_String = Fable.Core.RustInterop.emitRustExpr v126 v131
    v132
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v133 : string = @$"format!(""{{}}"", $0)"
    let v134 : std_string_String = Fable.Core.RustInterop.emitRustExpr v126 v133
    v134
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v135 : std_string_String = null |> unbox<std_string_String>
    v135
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v136 : std_string_String = null |> unbox<std_string_String>
    v136
#endif
    #if FABLE_COMPILER_PYTHON
    let v137 : std_string_String = null |> unbox<std_string_String>
    v137
#endif
    |> fun x -> _v127 <- Some x
    let v138 : std_string_String = _v127.Value
    let v139 : string = "fable_library_rust::String_::fromString($0)"
    let v140 : string = Fable.Core.RustInterop.emitRustExpr v138 v139
    let v141 : string = ""
    let v142 : string = v140.Replace (v1, v141)
    let v143 : string = "\\"
    let v144 : string = "/"
    let v145 : string = v142.Replace (v143, v144)
    let v146 : string = $".{v145}"
    let v147 : string option = None
    let v148 : bool = true in let mutable _v147 = v147
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v149 : string = method13(v0)
    let v150 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v151 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v149 v150
    let v152 : string = "String::from($0)"
    let v153 : std_string_String = Fable.Core.RustInterop.emitRustExpr v151 v152
    let v154 : string = "std::path::PathBuf::from($0)"
    let v155 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v153 v154
    let v156 : string = method13(v146)
    let v157 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v158 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v156 v157
    let v159 : string = "String::from($0)"
    let v160 : std_string_String = Fable.Core.RustInterop.emitRustExpr v158 v159
    let v161 : string = "$0.join($1)"
    let v162 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v155, v160) v161
    let v163 : string = "$0.display()"
    let v164 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v162 v163
    let v165 : std_string_String option = None
    let v166 : bool = true in let mutable _v165 = v165
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v167 : string = @$"format!(""{{}}"", $0)"
    let v168 : std_string_String = Fable.Core.RustInterop.emitRustExpr v164 v167
    v168
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v169 : string = @$"format!(""{{}}"", $0)"
    let v170 : std_string_String = Fable.Core.RustInterop.emitRustExpr v164 v169
    v170
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v171 : string = @$"format!(""{{}}"", $0)"
    let v172 : std_string_String = Fable.Core.RustInterop.emitRustExpr v164 v171
    v172
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v173 : std_string_String = null |> unbox<std_string_String>
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
    |> fun x -> _v165 <- Some x
    let v176 : std_string_String = _v165.Value
    let v177 : string = "fable_library_rust::String_::fromString($0)"
    let v178 : string = Fable.Core.RustInterop.emitRustExpr v176 v177
    v178
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v179 : string = null |> unbox<string>
    v179
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v180 : string = null |> unbox<string>
    v180
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v181 : string = System.IO.Path.Combine (v0, v146)
    v181
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v182 : string = "path"
    let v183 : IPathJoin = Fable.Core.JsInterop.importAll v182
    let v184 : string = method14(v0)
    let v185 : string = method15(v146)
    let v186 : string = "v183.join(v184, v185)"
    let v187 : string = Fable.Core.JsInterop.emitJsExpr () v186
    v187
#endif
    #if FABLE_COMPILER_PYTHON
    let v188 : string = null |> unbox<string>
    v188
#endif
    |> fun x -> _v147 <- Some x
    let v189 : string = _v147.Value
    let v190 : bool option = None
    let v191 : bool = true in let mutable _v190 = v190
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v192 : string = "cfg!(windows)"
    let v193 : bool = Fable.Core.RustInterop.emitRustExpr () v192
    v193
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v194 : bool = null |> unbox<bool>
    v194
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v195 : bool = null |> unbox<bool>
    v195
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v196 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v197 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v198 : bool = v197 v196
    v198
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v199 : bool = null |> unbox<bool>
    v199
#endif
    #if FABLE_COMPILER_PYTHON
    let v200 : bool = null |> unbox<bool>
    v200
#endif
    |> fun x -> _v190 <- Some x
    let v201 : bool = _v190.Value
    let v202 : bool = v201 = false
    let v223 : string =
        if v202 then
            v189
        else
            let v203 : string option = None
            let v204 : bool = true in let mutable _v203 = v203
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v205 : string = method26()
            let v206 : string = method27(v189)
            let v207 : string = method28()
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
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v216 : string = "^\\\\\\\\\\?\\\\"
            let v217 : string = System.Text.RegularExpressions.Regex.Replace (v189, v216, v141)
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
            |> fun x -> _v203 <- Some x
            let v220 : string = _v203.Value
            let v221 : string = $"{v220.[0] |> System.Char.ToLower}{v220.[1..]}"
            let v222 : string = v221.Replace (v143, v144)
            v222
    let v224 : System.Threading.CancellationToken option = None
    let v225 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v226 : string option = None
    let v227 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v223}\""
    let v228 : string option = Some v0 
    let v229 : struct (int32 * string) option = None
    let v230 : bool = true in let mutable _v229 = v229
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v231 : string, v232 : string) = method29()
    let v233 : int32 = v227.Length
    let v234 : (char []) = Array.zeroCreate<char> (v233)
    let v235 : Mut4 = {l0 = 0} : Mut4
    while method30(v233, v235) do
        let v237 : int32 = v235.l0
        let v238 : char = v227.[int v237]
        v234.[int v237] <- v238
        let v239 : int32 = v237 + 1
        v235.l0 <- v239
        ()
    let v240 : ((char []) -> char list) = Array.toList
    let v241 : char list = v240 v234
    let v242 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v243 : (char -> (UH0 -> UH0)) = method31()
    let v244 : (char list -> (UH0 -> UH0)) = v242 v243
    let v245 : (UH0 -> UH0) = v244 v241
    let v246 : UH0 = UH0_0
    let v247 : UH0 = v245 v246
    let v248 : US10 = US10_0
    let struct (v249 : string, v250 : string) = method32(v232, v231, v247, v248)
    let v251 : (string []) = method33(v250)
    let v252 : string = "$0.to_vec()"
    let v253 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v251 v252
    let v254 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v255 : (string -> std_string_String) = closure26()
    let v256 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v253, v255) v254
    let v257 : US0 = US0_1
    let v258 : (unit -> string) = closure27(v224, v227, v225, v228, v249, v256)
    let v259 : (unit -> string) = method38()
    method3(v257, v258, v259)
    let v260 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method39(v224, v227, v225, v228, v249, v256)
    let v261 : string = "futures_lite::future::block_on($0)"
    let v262 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v260 v261
    let (a, b) = v262
    let v263 : int32 = a
    let v264 : string = b
    struct (v263, v264)
#endif
    #if FABLE_COMPILER_RUST && WASM
    let struct (v265 : int32, v266 : string) = null |> unbox<struct (int32 * string)>
    struct (v265, v266)
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let struct (v267 : int32, v268 : string) = null |> unbox<struct (int32 * string)>
    struct (v267, v268)
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v269 : Async<struct (int32 * string)> option = None
    let v270 : bool = true in let mutable _v269 = v269
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v271 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v271
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v272 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v272
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v273 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v273
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v274 : Async<struct (int32 * string)> option = None
    let v275 : bool = true in let mutable _v274 = v274
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v276 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v276
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v277 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v277
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v278 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v278
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v279 : Async<struct (int32 * string)> option = None
    let mutable _v279 = v279
    async {
    let struct (v280 : string, v281 : string) = method29()
    let v282 : (char []) = Array.zeroCreate<char> (v233)
    let v283 : Mut4 = {l0 = 0} : Mut4
    while method30(v233, v283) do
        let v285 : int32 = v283.l0
        let v286 : char = v227.[int v285]
        v282.[int v285] <- v286
        let v287 : int32 = v285 + 1
        v283.l0 <- v287
        ()
    let v288 : ((char []) -> char list) = Array.toList
    let v289 : char list = v288 v282
    let v290 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v291 : (char -> (UH0 -> UH0)) = method31()
    let v292 : (char list -> (UH0 -> UH0)) = v290 v291
    let v293 : (UH0 -> UH0) = v292 v289
    let v294 : UH0 = UH0_0
    let v295 : UH0 = v293 v294
    let v296 : US10 = US10_0
    let struct (v297 : string, v298 : string) = method32(v281, v280, v295, v296)
    let v299 : (string -> US7) = method40()
    let v300 : US7 = US7_1
    let v301 : US7 = v228 |> Option.map v299 |> Option.defaultValue v300 
    let v304 : string =
        match v301 with
        | US7_1 -> (* None *)
            v141
        | US7_0(v302) -> (* Some *)
            v302
    let v305 : US0 = US0_1
    let v306 : (unit -> string) = closure44(v224, v227, v225, v228)
    let v307 : (unit -> string) = method38()
    method3(v305, v306, v307)
    let v308 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v309 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v298, StandardOutputEncoding = v308, WorkingDirectory = v304, FileName = v297, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v310 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v309)
    use v310 = v310 
    let v311 : System.Diagnostics.Process = v310 
    let v312 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v313 : System.Collections.Concurrent.ConcurrentStack<string> = v312 ()
    let v314 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v224, v227, v225, v228, v311, v313)
    v311.OutputDataReceived.Add v314 
    let v315 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v224, v227, v225, v228, v311, v313)
    v311.ErrorDataReceived.Add v315 
    let v316 : (unit -> bool) = v311.Start
    let v317 : bool = v316 ()
    let v318 : bool = v317 = false
    if v318 then
        let v319 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v319
    let v320 : (unit -> unit) = v311.BeginErrorReadLine
    v320 ()
    let v321 : (unit -> unit) = v311.BeginOutputReadLine
    v321 ()
    let v322 : (System.Threading.CancellationToken -> US18) = method57()
    let v323 : US18 = US18_1
    let v324 : US18 = v224 |> Option.map v322 |> Option.defaultValue v323 
    let v328 : System.Threading.CancellationToken =
        match v324 with
        | US18_1 -> (* None *)
            let v326 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v326
        | US18_0(v325) -> (* Some *)
            v325
    let v329 : Async<System.Threading.CancellationToken> option = None
    let v330 : bool = true in let mutable _v329 = v329
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v331 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v331
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v332 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v332
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v333 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v333
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v334 : Async<System.Threading.CancellationToken> option = None
    let v335 : bool = true in let mutable _v334 = v334
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v336 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v336
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v337 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v337
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v338 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v338
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v339 : Async<System.Threading.CancellationToken> option = None
    let mutable _v339 = v339
    async {
    let v340 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v340 = v340 
    let v341 : System.Threading.CancellationToken = v340 
    let v342 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v343 : (System.Threading.CancellationToken []) = [|v341; v342; v328|]
    let v344 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v345 : System.Threading.CancellationTokenSource = v344 v343
    let v346 : System.Threading.CancellationToken = v345.Token
    return v346 
    }
    |> fun x -> _v339 <- Some x
    let v347 : Async<System.Threading.CancellationToken> = _v339 |> Option.get
    v347
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v348 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v348
#endif
    #if FABLE_COMPILER_PYTHON
    let v349 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v349
#endif
    |> fun x -> _v334 <- Some x
    let v350 : Async<System.Threading.CancellationToken> = _v334.Value
    v350
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v351 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v351
#endif
    #if FABLE_COMPILER_PYTHON
    let v352 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v352
#endif
    |> fun x -> _v329 <- Some x
    let v353 : Async<System.Threading.CancellationToken> = _v329.Value
    let! v353 = v353 
    let v354 : System.Threading.CancellationToken = v353 
    let v355 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v354.Register
    let v356 : (unit -> unit) = closure50(v311)
    let v357 : System.Threading.CancellationTokenRegistration = v355 v356
    use v357 = v357 
    let v358 : System.Threading.CancellationTokenRegistration = v357 
    let v359 : Async<int32> option = None
    let v360 : bool = true in let mutable _v359 = v359
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v361 : Async<int32> = null |> unbox<Async<int32>>
    v361
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v362 : Async<int32> = null |> unbox<Async<int32>>
    v362
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v363 : Async<int32> = null |> unbox<Async<int32>>
    v363
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v364 : Async<int32> option = None
    let mutable _v364 = v364
    async {
    try
    let v365 : System.Threading.Tasks.Task = v311.WaitForExitAsync v354 
    let v366 : Async<unit> option = None
    let v367 : bool = true in let mutable _v366 = v366
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v368 : Async<unit> = null |> unbox<Async<unit>>
    v368
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v369 : Async<unit> = null |> unbox<Async<unit>>
    v369
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v370 : Async<unit> = null |> unbox<Async<unit>>
    v370
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v371 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v372 : Async<unit> = v371 v365
    v372
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v373 : Async<unit> = null |> unbox<Async<unit>>
    v373
#endif
    #if FABLE_COMPILER_PYTHON
    let v374 : Async<unit> = null |> unbox<Async<unit>>
    v374
#endif
    |> fun x -> _v366 <- Some x
    let v375 : Async<unit> = _v366.Value
    do! v375 
    let v376 : int32 = v311.ExitCode
    return v376 
    with ex ->
    let v377 : exn = ex
    let v378 : string option = None
    let v379 : bool = true in let mutable _v378 = v378
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v380 : string = $"%A{v377}"
    v380
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v381 : string = $"%A{v377}"
    v381
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v382 : string = $"%A{v377}"
    v382
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v383 : string = $"{v377.GetType ()}: {v377.Message}"
    v383
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v384 : string = $"%A{v377}"
    v384
#endif
    #if FABLE_COMPILER_PYTHON
    let v385 : string = $"%A{v377}"
    v385
#endif
    |> fun x -> _v378 <- Some x
    let v386 : string = _v378.Value
    let v387 : (string -> unit) = v313.Push
    v387 v386
    let v388 : System.Threading.Tasks.TaskCanceledException = v377 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v389 : US0 = US0_3
    let v390 : (unit -> string) = closure51(v388)
    let v391 : (unit -> string) = method38()
    method3(v389, v390, v391)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v364 <- Some x
    let v392 : Async<int32> = _v364 |> Option.get
    v392
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v393 : Async<int32> = null |> unbox<Async<int32>>
    v393
#endif
    #if FABLE_COMPILER_PYTHON
    let v394 : Async<int32> = null |> unbox<Async<int32>>
    v394
#endif
    |> fun x -> _v359 <- Some x
    let v395 : Async<int32> = _v359.Value
    let! v395 = v395 
    let v396 : int32 = v395 
    let v397 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v398 : string seq = v397 v313
    let v399 : string = method58()
    let v400 : (string -> (string seq -> string)) = String.concat
    let v401 : (string seq -> string) = v400 v399
    let v402 : string = v401 v398
    let v403 : US0 = US0_1
    let v404 : (unit -> string) = closure52(v396, v402)
    let v405 : (unit -> string) = method38()
    method3(v403, v404, v405)
    return struct (v396, v402) 
    }
    |> fun x -> _v279 <- Some x
    let v406 : Async<struct (int32 * string)> = _v279 |> Option.get
    v406
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v407 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v407
#endif
    #if FABLE_COMPILER_PYTHON
    let v408 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v408
#endif
    |> fun x -> _v274 <- Some x
    let v409 : Async<struct (int32 * string)> = _v274.Value
    v409
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v410 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v410
#endif
    #if FABLE_COMPILER_PYTHON
    let v411 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v411
#endif
    |> fun x -> _v269 <- Some x
    let v412 : Async<struct (int32 * string)> = _v269.Value
    let v413 : struct (int32 * string) option = None
    let v414 : bool = true in let mutable _v413 = v413
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v415 : int32, v416 : string) = null |> unbox<struct (int32 * string)>
    struct (v415, v416)
#endif
    #if FABLE_COMPILER_RUST && WASM
    let struct (v417 : int32, v418 : string) = null |> unbox<struct (int32 * string)>
    struct (v417, v418)
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let struct (v419 : int32, v420 : string) = null |> unbox<struct (int32 * string)>
    struct (v419, v420)
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v421 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v422 : int32, v423 : string) = v421 v412
    struct (v422, v423)
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let struct (v424 : int32, v425 : string) = null |> unbox<struct (int32 * string)>
    struct (v424, v425)
#endif
    #if FABLE_COMPILER_PYTHON
    let struct (v426 : int32, v427 : string) = null |> unbox<struct (int32 * string)>
    struct (v426, v427)
#endif
    |> fun x -> _v413 <- Some x
    let struct (v428 : int32, v429 : string) = _v413.Value
    struct (v428, v429)
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let struct (v430 : int32, v431 : string) = null |> unbox<struct (int32 * string)>
    struct (v430, v431)
#endif
    #if FABLE_COMPILER_PYTHON
    let struct (v432 : int32, v433 : string) = null |> unbox<struct (int32 * string)>
    struct (v432, v433)
#endif
    |> fun x -> _v229 <- Some x
    let struct (v434 : int32, v435 : string) = _v229.Value
    let v436 : string option = None
    let v437 : bool = true in let mutable _v436 = v436
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v438 : string = method13(v1)
    let v439 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v440 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v438 v439
    let v441 : string = "String::from($0)"
    let v442 : std_string_String = Fable.Core.RustInterop.emitRustExpr v440 v441
    let v443 : string = "std::path::PathBuf::from($0)"
    let v444 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v442 v443
    let v445 : string = method13(v146)
    let v446 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v447 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v445 v446
    let v448 : string = "String::from($0)"
    let v449 : std_string_String = Fable.Core.RustInterop.emitRustExpr v447 v448
    let v450 : string = "$0.join($1)"
    let v451 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v444, v449) v450
    let v452 : string = "$0.display()"
    let v453 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v451 v452
    let v454 : std_string_String option = None
    let v455 : bool = true in let mutable _v454 = v454
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v456 : string = @$"format!(""{{}}"", $0)"
    let v457 : std_string_String = Fable.Core.RustInterop.emitRustExpr v453 v456
    v457
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v458 : string = @$"format!(""{{}}"", $0)"
    let v459 : std_string_String = Fable.Core.RustInterop.emitRustExpr v453 v458
    v459
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v460 : string = @$"format!(""{{}}"", $0)"
    let v461 : std_string_String = Fable.Core.RustInterop.emitRustExpr v453 v460
    v461
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v462 : std_string_String = null |> unbox<std_string_String>
    v462
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v463 : std_string_String = null |> unbox<std_string_String>
    v463
#endif
    #if FABLE_COMPILER_PYTHON
    let v464 : std_string_String = null |> unbox<std_string_String>
    v464
#endif
    |> fun x -> _v454 <- Some x
    let v465 : std_string_String = _v454.Value
    let v466 : string = "fable_library_rust::String_::fromString($0)"
    let v467 : string = Fable.Core.RustInterop.emitRustExpr v465 v466
    v467
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v468 : string = null |> unbox<string>
    v468
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v469 : string = null |> unbox<string>
    v469
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v470 : string = System.IO.Path.Combine (v1, v146)
    v470
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v471 : IPathJoin = Fable.Core.JsInterop.importAll v182
    let v472 : string = method14(v1)
    let v473 : string = method15(v146)
    let v474 : string = "v471.join(v472, v473)"
    let v475 : string = Fable.Core.JsInterop.emitJsExpr () v474
    v475
#endif
    #if FABLE_COMPILER_PYTHON
    let v476 : string = null |> unbox<string>
    v476
#endif
    |> fun x -> _v436 <- Some x
    let v477 : string = _v436.Value
    let v478 : bool option = None
    let v479 : bool = true in let mutable _v478 = v478
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v480 : string = "cfg!(windows)"
    let v481 : bool = Fable.Core.RustInterop.emitRustExpr () v480
    v481
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v482 : bool = null |> unbox<bool>
    v482
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v483 : bool = null |> unbox<bool>
    v483
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v484 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v485 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v486 : bool = v485 v484
    v486
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v487 : bool = null |> unbox<bool>
    v487
#endif
    #if FABLE_COMPILER_PYTHON
    let v488 : bool = null |> unbox<bool>
    v488
#endif
    |> fun x -> _v478 <- Some x
    let v489 : bool = _v478.Value
    let v490 : bool = v489 = false
    let v511 : string =
        if v490 then
            v477
        else
            let v491 : string option = None
            let v492 : bool = true in let mutable _v491 = v491
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v493 : string = method26()
            let v494 : string = method27(v477)
            let v495 : string = method28()
            let v496 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
            let v497 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v493, v494, v495) v496
            let v498 : string = "String::from($0)"
            let v499 : std_string_String = Fable.Core.RustInterop.emitRustExpr v497 v498
            let v500 : string = "fable_library_rust::String_::fromString($0)"
            let v501 : string = Fable.Core.RustInterop.emitRustExpr v499 v500
            v501
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v502 : string = null |> unbox<string>
            v502
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v503 : string = null |> unbox<string>
            v503
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v504 : string = "^\\\\\\\\\\?\\\\"
            let v505 : string = System.Text.RegularExpressions.Regex.Replace (v477, v504, v141)
            v505
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v506 : string = null |> unbox<string>
            v506
#endif
            #if FABLE_COMPILER_PYTHON
            let v507 : string = null |> unbox<string>
            v507
#endif
            |> fun x -> _v491 <- Some x
            let v508 : string = _v491.Value
            let v509 : string = $"{v508.[0] |> System.Char.ToLower}{v508.[1..]}"
            let v510 : string = v509.Replace (v143, v144)
            v510
    let v512 : System.Threading.CancellationToken option = None
    let v513 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v514 : string option = None
    let v515 : string = $"git hash-object \"{v511}\""
    let v516 : string option = Some v1 
    let v517 : struct (int32 * string) option = None
    let v518 : bool = true in let mutable _v517 = v517
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v519 : string, v520 : string) = method29()
    let v521 : int32 = v515.Length
    let v522 : (char []) = Array.zeroCreate<char> (v521)
    let v523 : Mut4 = {l0 = 0} : Mut4
    while method30(v521, v523) do
        let v525 : int32 = v523.l0
        let v526 : char = v515.[int v525]
        v522.[int v525] <- v526
        let v527 : int32 = v525 + 1
        v523.l0 <- v527
        ()
    let v528 : ((char []) -> char list) = Array.toList
    let v529 : char list = v528 v522
    let v530 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v531 : (char -> (UH0 -> UH0)) = method31()
    let v532 : (char list -> (UH0 -> UH0)) = v530 v531
    let v533 : (UH0 -> UH0) = v532 v529
    let v534 : UH0 = UH0_0
    let v535 : UH0 = v533 v534
    let v536 : US10 = US10_0
    let struct (v537 : string, v538 : string) = method32(v520, v519, v535, v536)
    let v539 : (string []) = method33(v538)
    let v540 : string = "$0.to_vec()"
    let v541 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v539 v540
    let v542 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
    let v543 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v541, v255) v542
    let v544 : US0 = US0_1
    let v545 : (unit -> string) = closure27(v512, v515, v513, v516, v537, v543)
    let v546 : (unit -> string) = method38()
    method3(v544, v545, v546)
    let v547 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method39(v512, v515, v513, v516, v537, v543)
    let v548 : string = "futures_lite::future::block_on($0)"
    let v549 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v547 v548
    let (a, b) = v549
    let v550 : int32 = a
    let v551 : string = b
    struct (v550, v551)
#endif
    #if FABLE_COMPILER_RUST && WASM
    let struct (v552 : int32, v553 : string) = null |> unbox<struct (int32 * string)>
    struct (v552, v553)
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let struct (v554 : int32, v555 : string) = null |> unbox<struct (int32 * string)>
    struct (v554, v555)
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v556 : Async<struct (int32 * string)> option = None
    let v557 : bool = true in let mutable _v556 = v556
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v558 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v558
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v559 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v559
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v560 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v560
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v561 : Async<struct (int32 * string)> option = None
    let v562 : bool = true in let mutable _v561 = v561
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v563 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v563
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v564 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v564
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v565 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v565
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v566 : Async<struct (int32 * string)> option = None
    let mutable _v566 = v566
    async {
    let struct (v567 : string, v568 : string) = method29()
    let v569 : (char []) = Array.zeroCreate<char> (v521)
    let v570 : Mut4 = {l0 = 0} : Mut4
    while method30(v521, v570) do
        let v572 : int32 = v570.l0
        let v573 : char = v515.[int v572]
        v569.[int v572] <- v573
        let v574 : int32 = v572 + 1
        v570.l0 <- v574
        ()
    let v575 : ((char []) -> char list) = Array.toList
    let v576 : char list = v575 v569
    let v577 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v578 : (char -> (UH0 -> UH0)) = method31()
    let v579 : (char list -> (UH0 -> UH0)) = v577 v578
    let v580 : (UH0 -> UH0) = v579 v576
    let v581 : UH0 = UH0_0
    let v582 : UH0 = v580 v581
    let v583 : US10 = US10_0
    let struct (v584 : string, v585 : string) = method32(v568, v567, v582, v583)
    let v586 : (string -> US7) = method40()
    let v587 : US7 = US7_1
    let v588 : US7 = v516 |> Option.map v586 |> Option.defaultValue v587 
    let v591 : string =
        match v588 with
        | US7_1 -> (* None *)
            v141
        | US7_0(v589) -> (* Some *)
            v589
    let v592 : US0 = US0_1
    let v593 : (unit -> string) = closure44(v512, v515, v513, v516)
    let v594 : (unit -> string) = method38()
    method3(v592, v593, v594)
    let v595 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v596 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v585, StandardOutputEncoding = v595, WorkingDirectory = v591, FileName = v584, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v597 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v596)
    use v597 = v597 
    let v598 : System.Diagnostics.Process = v597 
    let v599 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v600 : System.Collections.Concurrent.ConcurrentStack<string> = v599 ()
    let v601 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v512, v515, v513, v516, v598, v600)
    v598.OutputDataReceived.Add v601 
    let v602 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v512, v515, v513, v516, v598, v600)
    v598.ErrorDataReceived.Add v602 
    let v603 : (unit -> bool) = v598.Start
    let v604 : bool = v603 ()
    let v605 : bool = v604 = false
    if v605 then
        let v606 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v606
    let v607 : (unit -> unit) = v598.BeginErrorReadLine
    v607 ()
    let v608 : (unit -> unit) = v598.BeginOutputReadLine
    v608 ()
    let v609 : (System.Threading.CancellationToken -> US18) = method57()
    let v610 : US18 = US18_1
    let v611 : US18 = v512 |> Option.map v609 |> Option.defaultValue v610 
    let v615 : System.Threading.CancellationToken =
        match v611 with
        | US18_1 -> (* None *)
            let v613 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v613
        | US18_0(v612) -> (* Some *)
            v612
    let v616 : Async<System.Threading.CancellationToken> option = None
    let v617 : bool = true in let mutable _v616 = v616
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v621 : Async<System.Threading.CancellationToken> option = None
    let v622 : bool = true in let mutable _v621 = v621
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v623 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v623
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v624 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v624
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v625 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v625
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v626 : Async<System.Threading.CancellationToken> option = None
    let mutable _v626 = v626
    async {
    let v627 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v627 = v627 
    let v628 : System.Threading.CancellationToken = v627 
    let v629 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v630 : (System.Threading.CancellationToken []) = [|v628; v629; v615|]
    let v631 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v632 : System.Threading.CancellationTokenSource = v631 v630
    let v633 : System.Threading.CancellationToken = v632.Token
    return v633 
    }
    |> fun x -> _v626 <- Some x
    let v634 : Async<System.Threading.CancellationToken> = _v626 |> Option.get
    v634
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v635 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v635
#endif
    #if FABLE_COMPILER_PYTHON
    let v636 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v636
#endif
    |> fun x -> _v621 <- Some x
    let v637 : Async<System.Threading.CancellationToken> = _v621.Value
    v637
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v638 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v638
#endif
    #if FABLE_COMPILER_PYTHON
    let v639 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v639
#endif
    |> fun x -> _v616 <- Some x
    let v640 : Async<System.Threading.CancellationToken> = _v616.Value
    let! v640 = v640 
    let v641 : System.Threading.CancellationToken = v640 
    let v642 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v641.Register
    let v643 : (unit -> unit) = closure50(v598)
    let v644 : System.Threading.CancellationTokenRegistration = v642 v643
    use v644 = v644 
    let v645 : System.Threading.CancellationTokenRegistration = v644 
    let v646 : Async<int32> option = None
    let v647 : bool = true in let mutable _v646 = v646
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v648 : Async<int32> = null |> unbox<Async<int32>>
    v648
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v649 : Async<int32> = null |> unbox<Async<int32>>
    v649
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v650 : Async<int32> = null |> unbox<Async<int32>>
    v650
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v651 : Async<int32> option = None
    let mutable _v651 = v651
    async {
    try
    let v652 : System.Threading.Tasks.Task = v598.WaitForExitAsync v641 
    let v653 : Async<unit> option = None
    let v654 : bool = true in let mutable _v653 = v653
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v655 : Async<unit> = null |> unbox<Async<unit>>
    v655
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v656 : Async<unit> = null |> unbox<Async<unit>>
    v656
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v657 : Async<unit> = null |> unbox<Async<unit>>
    v657
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v658 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v659 : Async<unit> = v658 v652
    v659
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v660 : Async<unit> = null |> unbox<Async<unit>>
    v660
#endif
    #if FABLE_COMPILER_PYTHON
    let v661 : Async<unit> = null |> unbox<Async<unit>>
    v661
#endif
    |> fun x -> _v653 <- Some x
    let v662 : Async<unit> = _v653.Value
    do! v662 
    let v663 : int32 = v598.ExitCode
    return v663 
    with ex ->
    let v664 : exn = ex
    let v665 : string option = None
    let v666 : bool = true in let mutable _v665 = v665
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v667 : string = $"%A{v664}"
    v667
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v668 : string = $"%A{v664}"
    v668
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v669 : string = $"%A{v664}"
    v669
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v670 : string = $"{v664.GetType ()}: {v664.Message}"
    v670
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v671 : string = $"%A{v664}"
    v671
#endif
    #if FABLE_COMPILER_PYTHON
    let v672 : string = $"%A{v664}"
    v672
#endif
    |> fun x -> _v665 <- Some x
    let v673 : string = _v665.Value
    let v674 : (string -> unit) = v600.Push
    v674 v673
    let v675 : System.Threading.Tasks.TaskCanceledException = v664 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v676 : US0 = US0_3
    let v677 : (unit -> string) = closure51(v675)
    let v678 : (unit -> string) = method38()
    method3(v676, v677, v678)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v651 <- Some x
    let v679 : Async<int32> = _v651 |> Option.get
    v679
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v680 : Async<int32> = null |> unbox<Async<int32>>
    v680
#endif
    #if FABLE_COMPILER_PYTHON
    let v681 : Async<int32> = null |> unbox<Async<int32>>
    v681
#endif
    |> fun x -> _v646 <- Some x
    let v682 : Async<int32> = _v646.Value
    let! v682 = v682 
    let v683 : int32 = v682 
    let v684 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v685 : string seq = v684 v600
    let v686 : string = method58()
    let v687 : (string -> (string seq -> string)) = String.concat
    let v688 : (string seq -> string) = v687 v686
    let v689 : string = v688 v685
    let v690 : US0 = US0_1
    let v691 : (unit -> string) = closure52(v683, v689)
    let v692 : (unit -> string) = method38()
    method3(v690, v691, v692)
    return struct (v683, v689) 
    }
    |> fun x -> _v566 <- Some x
    let v693 : Async<struct (int32 * string)> = _v566 |> Option.get
    v693
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v694 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v694
#endif
    #if FABLE_COMPILER_PYTHON
    let v695 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v695
#endif
    |> fun x -> _v561 <- Some x
    let v696 : Async<struct (int32 * string)> = _v561.Value
    v696
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v697 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v697
#endif
    #if FABLE_COMPILER_PYTHON
    let v698 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v698
#endif
    |> fun x -> _v556 <- Some x
    let v699 : Async<struct (int32 * string)> = _v556.Value
    let v700 : struct (int32 * string) option = None
    let v701 : bool = true in let mutable _v700 = v700
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v702 : int32, v703 : string) = null |> unbox<struct (int32 * string)>
    struct (v702, v703)
#endif
    #if FABLE_COMPILER_RUST && WASM
    let struct (v704 : int32, v705 : string) = null |> unbox<struct (int32 * string)>
    struct (v704, v705)
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let struct (v706 : int32, v707 : string) = null |> unbox<struct (int32 * string)>
    struct (v706, v707)
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v708 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v709 : int32, v710 : string) = v708 v699
    struct (v709, v710)
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let struct (v711 : int32, v712 : string) = null |> unbox<struct (int32 * string)>
    struct (v711, v712)
#endif
    #if FABLE_COMPILER_PYTHON
    let struct (v713 : int32, v714 : string) = null |> unbox<struct (int32 * string)>
    struct (v713, v714)
#endif
    |> fun x -> _v700 <- Some x
    let struct (v715 : int32, v716 : string) = _v700.Value
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
    |> fun x -> _v517 <- Some x
    let struct (v721 : int32, v722 : string) = _v517.Value
    let v723 : bool = v435.Contains v722
    let v724 : bool = v723 = false
    let v3658 : (US8 []) =
        if v724 then
            let v725 : bool option = None
            let v726 : bool = true in let mutable _v725 = v725
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v727 : string = "cfg!(windows)"
            let v728 : bool = Fable.Core.RustInterop.emitRustExpr () v727
            v728
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v729 : bool = null |> unbox<bool>
            v729
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v730 : bool = null |> unbox<bool>
            v730
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v731 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v732 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v733 : bool = v732 v731
            v733
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v734 : bool = null |> unbox<bool>
            v734
#endif
            #if FABLE_COMPILER_PYTHON
            let v735 : bool = null |> unbox<bool>
            v735
#endif
            |> fun x -> _v725 <- Some x
            let v736 : bool = _v725.Value
            let v737 : bool = v736 = false
            let v758 : string =
                if v737 then
                    v511
                else
                    let v738 : string option = None
                    let v739 : bool = true in let mutable _v738 = v738
                    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v740 : string = method26()
                    let v741 : string = method27(v511)
                    let v742 : string = method28()
                    let v743 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v744 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v740, v741, v742) v743
                    let v745 : string = "String::from($0)"
                    let v746 : std_string_String = Fable.Core.RustInterop.emitRustExpr v744 v745
                    let v747 : string = "fable_library_rust::String_::fromString($0)"
                    let v748 : string = Fable.Core.RustInterop.emitRustExpr v746 v747
                    v748
#endif
                    #if FABLE_COMPILER_RUST && WASM
                    let v749 : string = null |> unbox<string>
                    v749
#endif
                    #if FABLE_COMPILER_RUST && CONTRACT
                    let v750 : string = null |> unbox<string>
                    v750
#endif
                    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                    let v751 : string = "^\\\\\\\\\\?\\\\"
                    let v752 : string = System.Text.RegularExpressions.Regex.Replace (v511, v751, v141)
                    v752
#endif
                    #if FABLE_COMPILER_TYPESCRIPT
                    let v753 : string = null |> unbox<string>
                    v753
#endif
                    #if FABLE_COMPILER_PYTHON
                    let v754 : string = null |> unbox<string>
                    v754
#endif
                    |> fun x -> _v738 <- Some x
                    let v755 : string = _v738.Value
                    let v756 : string = $"{v755.[0] |> System.Char.ToLower}{v755.[1..]}"
                    let v757 : string = v756.Replace (v143, v144)
                    v757
            let v759 : System.Threading.CancellationToken option = None
            let v760 : (struct (bool * string * int32) -> Async<unit>) option = None
            let v761 : string option = None
            let v762 : string = $"pwsh -c \"(Get-FileHash \\\"{v758}\\\" -Algorithm SHA256).Hash\""
            let v763 : struct (int32 * string) option = None
            let v764 : bool = true in let mutable _v763 = v763
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v765 : string, v766 : string) = method29()
            let v767 : int32 = v762.Length
            let v768 : (char []) = Array.zeroCreate<char> (v767)
            let v769 : Mut4 = {l0 = 0} : Mut4
            while method30(v767, v769) do
                let v771 : int32 = v769.l0
                let v772 : char = v762.[int v771]
                v768.[int v771] <- v772
                let v773 : int32 = v771 + 1
                v769.l0 <- v773
                ()
            let v774 : ((char []) -> char list) = Array.toList
            let v775 : char list = v774 v768
            let v776 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v777 : (char -> (UH0 -> UH0)) = method31()
            let v778 : (char list -> (UH0 -> UH0)) = v776 v777
            let v779 : (UH0 -> UH0) = v778 v775
            let v780 : UH0 = UH0_0
            let v781 : UH0 = v779 v780
            let v782 : US10 = US10_0
            let struct (v783 : string, v784 : string) = method32(v766, v765, v781, v782)
            let v785 : (string []) = method33(v784)
            let v786 : string = "$0.to_vec()"
            let v787 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v785 v786
            let v788 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
            let v789 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v787, v255) v788
            let v790 : US0 = US0_1
            let v791 : (unit -> string) = closure27(v759, v762, v760, v761, v783, v789)
            let v792 : (unit -> string) = method38()
            method3(v790, v791, v792)
            let v793 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method39(v759, v762, v760, v761, v783, v789)
            let v794 : string = "futures_lite::future::block_on($0)"
            let v795 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v793 v794
            let (a, b) = v795
            let v796 : int32 = a
            let v797 : string = b
            struct (v796, v797)
#endif
            #if FABLE_COMPILER_RUST && WASM
            let struct (v798 : int32, v799 : string) = null |> unbox<struct (int32 * string)>
            struct (v798, v799)
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let struct (v800 : int32, v801 : string) = null |> unbox<struct (int32 * string)>
            struct (v800, v801)
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v802 : Async<struct (int32 * string)> option = None
            let v803 : bool = true in let mutable _v802 = v802
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
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v807 : Async<struct (int32 * string)> option = None
            let v808 : bool = true in let mutable _v807 = v807
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v809 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v809
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v810 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v810
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v811 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v811
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v812 : Async<struct (int32 * string)> option = None
            let mutable _v812 = v812
            async {
            let struct (v813 : string, v814 : string) = method29()
            let v815 : (char []) = Array.zeroCreate<char> (v767)
            let v816 : Mut4 = {l0 = 0} : Mut4
            while method30(v767, v816) do
                let v818 : int32 = v816.l0
                let v819 : char = v762.[int v818]
                v815.[int v818] <- v819
                let v820 : int32 = v818 + 1
                v816.l0 <- v820
                ()
            let v821 : ((char []) -> char list) = Array.toList
            let v822 : char list = v821 v815
            let v823 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v824 : (char -> (UH0 -> UH0)) = method31()
            let v825 : (char list -> (UH0 -> UH0)) = v823 v824
            let v826 : (UH0 -> UH0) = v825 v822
            let v827 : UH0 = UH0_0
            let v828 : UH0 = v826 v827
            let v829 : US10 = US10_0
            let struct (v830 : string, v831 : string) = method32(v814, v813, v828, v829)
            let v832 : (string -> US7) = method40()
            let v833 : US7 = US7_1
            let v834 : US7 = v761 |> Option.map v832 |> Option.defaultValue v833 
            let v837 : string =
                match v834 with
                | US7_1 -> (* None *)
                    v141
                | US7_0(v835) -> (* Some *)
                    v835
            let v838 : US0 = US0_1
            let v839 : (unit -> string) = closure44(v759, v762, v760, v761)
            let v840 : (unit -> string) = method38()
            method3(v838, v839, v840)
            let v841 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v842 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v831, StandardOutputEncoding = v841, WorkingDirectory = v837, FileName = v830, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
            let v843 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v842)
            use v843 = v843 
            let v844 : System.Diagnostics.Process = v843 
            let v845 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v846 : System.Collections.Concurrent.ConcurrentStack<string> = v845 ()
            let v847 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v759, v762, v760, v761, v844, v846)
            v844.OutputDataReceived.Add v847 
            let v848 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v759, v762, v760, v761, v844, v846)
            v844.ErrorDataReceived.Add v848 
            let v849 : (unit -> bool) = v844.Start
            let v850 : bool = v849 ()
            let v851 : bool = v850 = false
            if v851 then
                let v852 : string = $"execute_with_options_async / process_start error"
                failwith<unit> v852
            let v853 : (unit -> unit) = v844.BeginErrorReadLine
            v853 ()
            let v854 : (unit -> unit) = v844.BeginOutputReadLine
            v854 ()
            let v855 : (System.Threading.CancellationToken -> US18) = method57()
            let v856 : US18 = US18_1
            let v857 : US18 = v759 |> Option.map v855 |> Option.defaultValue v856 
            let v861 : System.Threading.CancellationToken =
                match v857 with
                | US18_1 -> (* None *)
                    let v859 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v859
                | US18_0(v858) -> (* Some *)
                    v858
            let v862 : Async<System.Threading.CancellationToken> option = None
            let v863 : bool = true in let mutable _v862 = v862
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v864 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v864
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v865 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v865
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v866 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v866
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v867 : Async<System.Threading.CancellationToken> option = None
            let v868 : bool = true in let mutable _v867 = v867
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v869 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v869
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v870 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v870
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v871 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v871
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v872 : Async<System.Threading.CancellationToken> option = None
            let mutable _v872 = v872
            async {
            let v873 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v873 = v873 
            let v874 : System.Threading.CancellationToken = v873 
            let v875 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v876 : (System.Threading.CancellationToken []) = [|v874; v875; v861|]
            let v877 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v878 : System.Threading.CancellationTokenSource = v877 v876
            let v879 : System.Threading.CancellationToken = v878.Token
            return v879 
            }
            |> fun x -> _v872 <- Some x
            let v880 : Async<System.Threading.CancellationToken> = _v872 |> Option.get
            v880
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v881 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v881
#endif
            #if FABLE_COMPILER_PYTHON
            let v882 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v882
#endif
            |> fun x -> _v867 <- Some x
            let v883 : Async<System.Threading.CancellationToken> = _v867.Value
            v883
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v884 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v884
#endif
            #if FABLE_COMPILER_PYTHON
            let v885 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            v885
#endif
            |> fun x -> _v862 <- Some x
            let v886 : Async<System.Threading.CancellationToken> = _v862.Value
            let! v886 = v886 
            let v887 : System.Threading.CancellationToken = v886 
            let v888 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v887.Register
            let v889 : (unit -> unit) = closure50(v844)
            let v890 : System.Threading.CancellationTokenRegistration = v888 v889
            use v890 = v890 
            let v891 : System.Threading.CancellationTokenRegistration = v890 
            let v892 : Async<int32> option = None
            let v893 : bool = true in let mutable _v892 = v892
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v894 : Async<int32> = null |> unbox<Async<int32>>
            v894
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v895 : Async<int32> = null |> unbox<Async<int32>>
            v895
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v896 : Async<int32> = null |> unbox<Async<int32>>
            v896
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v897 : Async<int32> option = None
            let mutable _v897 = v897
            async {
            try
            let v898 : System.Threading.Tasks.Task = v844.WaitForExitAsync v887 
            let v899 : Async<unit> option = None
            let v900 : bool = true in let mutable _v899 = v899
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v901 : Async<unit> = null |> unbox<Async<unit>>
            v901
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v902 : Async<unit> = null |> unbox<Async<unit>>
            v902
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v903 : Async<unit> = null |> unbox<Async<unit>>
            v903
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v904 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v905 : Async<unit> = v904 v898
            v905
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v906 : Async<unit> = null |> unbox<Async<unit>>
            v906
#endif
            #if FABLE_COMPILER_PYTHON
            let v907 : Async<unit> = null |> unbox<Async<unit>>
            v907
#endif
            |> fun x -> _v899 <- Some x
            let v908 : Async<unit> = _v899.Value
            do! v908 
            let v909 : int32 = v844.ExitCode
            return v909 
            with ex ->
            let v910 : exn = ex
            let v911 : string option = None
            let v912 : bool = true in let mutable _v911 = v911
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v913 : string = $"%A{v910}"
            v913
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v914 : string = $"%A{v910}"
            v914
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v915 : string = $"%A{v910}"
            v915
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v916 : string = $"{v910.GetType ()}: {v910.Message}"
            v916
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v917 : string = $"%A{v910}"
            v917
#endif
            #if FABLE_COMPILER_PYTHON
            let v918 : string = $"%A{v910}"
            v918
#endif
            |> fun x -> _v911 <- Some x
            let v919 : string = _v911.Value
            let v920 : (string -> unit) = v846.Push
            v920 v919
            let v921 : System.Threading.Tasks.TaskCanceledException = v910 |> unbox<System.Threading.Tasks.TaskCanceledException>
            let v922 : US0 = US0_3
            let v923 : (unit -> string) = closure51(v921)
            let v924 : (unit -> string) = method38()
            method3(v922, v923, v924)
            return -2147483648 
            (*
            *)
            }
            |> fun x -> _v897 <- Some x
            let v925 : Async<int32> = _v897 |> Option.get
            v925
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v926 : Async<int32> = null |> unbox<Async<int32>>
            v926
#endif
            #if FABLE_COMPILER_PYTHON
            let v927 : Async<int32> = null |> unbox<Async<int32>>
            v927
#endif
            |> fun x -> _v892 <- Some x
            let v928 : Async<int32> = _v892.Value
            let! v928 = v928 
            let v929 : int32 = v928 
            let v930 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v931 : string seq = v930 v846
            let v932 : string = method58()
            let v933 : (string -> (string seq -> string)) = String.concat
            let v934 : (string seq -> string) = v933 v932
            let v935 : string = v934 v931
            let v936 : US0 = US0_1
            let v937 : (unit -> string) = closure52(v929, v935)
            let v938 : (unit -> string) = method38()
            method3(v936, v937, v938)
            return struct (v929, v935) 
            }
            |> fun x -> _v812 <- Some x
            let v939 : Async<struct (int32 * string)> = _v812 |> Option.get
            v939
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v940 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v940
#endif
            #if FABLE_COMPILER_PYTHON
            let v941 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v941
#endif
            |> fun x -> _v807 <- Some x
            let v942 : Async<struct (int32 * string)> = _v807.Value
            v942
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v943 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v943
#endif
            #if FABLE_COMPILER_PYTHON
            let v944 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
            v944
#endif
            |> fun x -> _v802 <- Some x
            let v945 : Async<struct (int32 * string)> = _v802.Value
            let v946 : struct (int32 * string) option = None
            let v947 : bool = true in let mutable _v946 = v946
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v948 : int32, v949 : string) = null |> unbox<struct (int32 * string)>
            struct (v948, v949)
#endif
            #if FABLE_COMPILER_RUST && WASM
            let struct (v950 : int32, v951 : string) = null |> unbox<struct (int32 * string)>
            struct (v950, v951)
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let struct (v952 : int32, v953 : string) = null |> unbox<struct (int32 * string)>
            struct (v952, v953)
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v954 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
            let struct (v955 : int32, v956 : string) = v954 v945
            struct (v955, v956)
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let struct (v957 : int32, v958 : string) = null |> unbox<struct (int32 * string)>
            struct (v957, v958)
#endif
            #if FABLE_COMPILER_PYTHON
            let struct (v959 : int32, v960 : string) = null |> unbox<struct (int32 * string)>
            struct (v959, v960)
#endif
            |> fun x -> _v946 <- Some x
            let struct (v961 : int32, v962 : string) = _v946.Value
            struct (v961, v962)
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let struct (v963 : int32, v964 : string) = null |> unbox<struct (int32 * string)>
            struct (v963, v964)
#endif
            #if FABLE_COMPILER_PYTHON
            let struct (v965 : int32, v966 : string) = null |> unbox<struct (int32 * string)>
            struct (v965, v966)
#endif
            |> fun x -> _v763 <- Some x
            let struct (v967 : int32, v968 : string) = _v763.Value
            let v969 : string option = None
            let v970 : bool = true in let mutable _v969 = v969
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v971 : string = method13(v2)
            let v972 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v973 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v971 v972
            let v974 : string = "String::from($0)"
            let v975 : std_string_String = Fable.Core.RustInterop.emitRustExpr v973 v974
            let v976 : string = "std::path::PathBuf::from($0)"
            let v977 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v975 v976
            let v978 : string = method13(v146)
            let v979 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v980 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v978 v979
            let v981 : string = "String::from($0)"
            let v982 : std_string_String = Fable.Core.RustInterop.emitRustExpr v980 v981
            let v983 : string = "$0.join($1)"
            let v984 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v977, v982) v983
            let v985 : string = "$0.display()"
            let v986 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v984 v985
            let v987 : std_string_String option = None
            let v988 : bool = true in let mutable _v987 = v987
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v989 : string = @$"format!(""{{}}"", $0)"
            let v990 : std_string_String = Fable.Core.RustInterop.emitRustExpr v986 v989
            v990
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v991 : string = @$"format!(""{{}}"", $0)"
            let v992 : std_string_String = Fable.Core.RustInterop.emitRustExpr v986 v991
            v992
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v993 : string = @$"format!(""{{}}"", $0)"
            let v994 : std_string_String = Fable.Core.RustInterop.emitRustExpr v986 v993
            v994
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v995 : std_string_String = null |> unbox<std_string_String>
            v995
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v996 : std_string_String = null |> unbox<std_string_String>
            v996
#endif
            #if FABLE_COMPILER_PYTHON
            let v997 : std_string_String = null |> unbox<std_string_String>
            v997
#endif
            |> fun x -> _v987 <- Some x
            let v998 : std_string_String = _v987.Value
            let v999 : string = "fable_library_rust::String_::fromString($0)"
            let v1000 : string = Fable.Core.RustInterop.emitRustExpr v998 v999
            v1000
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v1001 : string = null |> unbox<string>
            v1001
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v1002 : string = null |> unbox<string>
            v1002
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v1003 : string = System.IO.Path.Combine (v2, v146)
            v1003
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v1004 : IPathJoin = Fable.Core.JsInterop.importAll v182
            let v1005 : string = method14(v2)
            let v1006 : string = method15(v146)
            let v1007 : string = "v1004.join(v1005, v1006)"
            let v1008 : string = Fable.Core.JsInterop.emitJsExpr () v1007
            v1008
#endif
            #if FABLE_COMPILER_PYTHON
            let v1009 : string = null |> unbox<string>
            v1009
#endif
            |> fun x -> _v969 <- Some x
            let v1010 : string = _v969.Value
            let v1011 : bool option = None
            let v1012 : bool = true in let mutable _v1011 = v1011
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1013 : string = "cfg!(windows)"
            let v1014 : bool = Fable.Core.RustInterop.emitRustExpr () v1013
            v1014
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v1015 : bool = null |> unbox<bool>
            v1015
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v1016 : bool = null |> unbox<bool>
            v1016
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v1017 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
            let v1018 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            let v1019 : bool = v1018 v1017
            v1019
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v1020 : bool = null |> unbox<bool>
            v1020
#endif
            #if FABLE_COMPILER_PYTHON
            let v1021 : bool = null |> unbox<bool>
            v1021
#endif
            |> fun x -> _v1011 <- Some x
            let v1022 : bool = _v1011.Value
            let v1023 : bool = v1022 = false
            let v1044 : string =
                if v1023 then
                    v1010
                else
                    let v1024 : string option = None
                    let v1025 : bool = true in let mutable _v1024 = v1024
                    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1026 : string = method26()
                    let v1027 : string = method27(v1010)
                    let v1028 : string = method28()
                    let v1029 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                    let v1030 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1026, v1027, v1028) v1029
                    let v1031 : string = "String::from($0)"
                    let v1032 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1030 v1031
                    let v1033 : string = "fable_library_rust::String_::fromString($0)"
                    let v1034 : string = Fable.Core.RustInterop.emitRustExpr v1032 v1033
                    v1034
#endif
                    #if FABLE_COMPILER_RUST && WASM
                    let v1035 : string = null |> unbox<string>
                    v1035
#endif
                    #if FABLE_COMPILER_RUST && CONTRACT
                    let v1036 : string = null |> unbox<string>
                    v1036
#endif
                    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                    let v1037 : string = "^\\\\\\\\\\?\\\\"
                    let v1038 : string = System.Text.RegularExpressions.Regex.Replace (v1010, v1037, v141)
                    v1038
#endif
                    #if FABLE_COMPILER_TYPESCRIPT
                    let v1039 : string = null |> unbox<string>
                    v1039
#endif
                    #if FABLE_COMPILER_PYTHON
                    let v1040 : string = null |> unbox<string>
                    v1040
#endif
                    |> fun x -> _v1024 <- Some x
                    let v1041 : string = _v1024.Value
                    let v1042 : string = $"{v1041.[0] |> System.Char.ToLower}{v1041.[1..]}"
                    let v1043 : string = v1042.Replace (v143, v144)
                    v1043
            let v1045 : bool option = None
            let v1046 : bool = true in let mutable _v1045 = v1045
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1047 : string = method13(v1044)
            let v1048 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v1049 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1047 v1048
            let v1050 : string = "String::from($0)"
            let v1051 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1049 v1050
            let v1052 : string = "std::path::PathBuf::from($0)"
            let v1053 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1051 v1052
            let v1054 : string = "$0.exists()"
            let v1055 : bool = Fable.Core.RustInterop.emitRustExpr v1053 v1054
            let v1058 : bool =
                if v1055 then
                    let v1056 : string = "$0.is_file()"
                    let v1057 : bool = Fable.Core.RustInterop.emitRustExpr v1053 v1056
                    v1057
                else
                    false
            v1058
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v1059 : bool = null |> unbox<bool>
            v1059
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v1060 : bool = null |> unbox<bool>
            v1060
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v1061 : (string -> bool) = System.IO.File.Exists
            let v1062 : bool = v1061 v1044
            v1062
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v1063 : string = "fs"
            let v1064 : IFsExistsSync = Fable.Core.JsInterop.importAll v1063
            let v1065 : string = "v1064.existsSync($0)"
            let v1066 : bool = Fable.Core.JsInterop.emitJsExpr v1044 v1065
            v1066
#endif
            #if FABLE_COMPILER_PYTHON
            let v1067 : bool = null |> unbox<bool>
            v1067
#endif
            |> fun x -> _v1045 <- Some x
            let v1068 : bool = _v1045.Value
            let v1313 : string =
                if v1068 then
                    let v1069 : bool option = None
                    let v1070 : bool = true in let mutable _v1069 = v1069
                    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1071 : string = "cfg!(windows)"
                    let v1072 : bool = Fable.Core.RustInterop.emitRustExpr () v1071
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
                    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                    let v1075 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                    let v1076 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                    let v1077 : bool = v1076 v1075
                    v1077
#endif
                    #if FABLE_COMPILER_TYPESCRIPT
                    let v1078 : bool = null |> unbox<bool>
                    v1078
#endif
                    #if FABLE_COMPILER_PYTHON
                    let v1079 : bool = null |> unbox<bool>
                    v1079
#endif
                    |> fun x -> _v1069 <- Some x
                    let v1080 : bool = _v1069.Value
                    let v1081 : bool = v1080 = false
                    let v1102 : string =
                        if v1081 then
                            v1044
                        else
                            let v1082 : string option = None
                            let v1083 : bool = true in let mutable _v1082 = v1082
                            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v1084 : string = method26()
                            let v1085 : string = method27(v1044)
                            let v1086 : string = method28()
                            let v1087 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                            let v1088 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1084, v1085, v1086) v1087
                            let v1089 : string = "String::from($0)"
                            let v1090 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1088 v1089
                            let v1091 : string = "fable_library_rust::String_::fromString($0)"
                            let v1092 : string = Fable.Core.RustInterop.emitRustExpr v1090 v1091
                            v1092
#endif
                            #if FABLE_COMPILER_RUST && WASM
                            let v1093 : string = null |> unbox<string>
                            v1093
#endif
                            #if FABLE_COMPILER_RUST && CONTRACT
                            let v1094 : string = null |> unbox<string>
                            v1094
#endif
                            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                            let v1095 : string = "^\\\\\\\\\\?\\\\"
                            let v1096 : string = System.Text.RegularExpressions.Regex.Replace (v1044, v1095, v141)
                            v1096
#endif
                            #if FABLE_COMPILER_TYPESCRIPT
                            let v1097 : string = null |> unbox<string>
                            v1097
#endif
                            #if FABLE_COMPILER_PYTHON
                            let v1098 : string = null |> unbox<string>
                            v1098
#endif
                            |> fun x -> _v1082 <- Some x
                            let v1099 : string = _v1082.Value
                            let v1100 : string = $"{v1099.[0] |> System.Char.ToLower}{v1099.[1..]}"
                            let v1101 : string = v1100.Replace (v143, v144)
                            v1101
                    let v1103 : System.Threading.CancellationToken option = None
                    let v1104 : (struct (bool * string * int32) -> Async<unit>) option = None
                    let v1105 : string option = None
                    let v1106 : string = $"pwsh -c \"(Get-FileHash \\\"{v1102}\\\" -Algorithm SHA256).Hash\""
                    let v1107 : struct (int32 * string) option = None
                    let v1108 : bool = true in let mutable _v1107 = v1107
                    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let struct (v1109 : string, v1110 : string) = method29()
                    let v1111 : int32 = v1106.Length
                    let v1112 : (char []) = Array.zeroCreate<char> (v1111)
                    let v1113 : Mut4 = {l0 = 0} : Mut4
                    while method30(v1111, v1113) do
                        let v1115 : int32 = v1113.l0
                        let v1116 : char = v1106.[int v1115]
                        v1112.[int v1115] <- v1116
                        let v1117 : int32 = v1115 + 1
                        v1113.l0 <- v1117
                        ()
                    let v1118 : ((char []) -> char list) = Array.toList
                    let v1119 : char list = v1118 v1112
                    let v1120 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                    let v1121 : (char -> (UH0 -> UH0)) = method31()
                    let v1122 : (char list -> (UH0 -> UH0)) = v1120 v1121
                    let v1123 : (UH0 -> UH0) = v1122 v1119
                    let v1124 : UH0 = UH0_0
                    let v1125 : UH0 = v1123 v1124
                    let v1126 : US10 = US10_0
                    let struct (v1127 : string, v1128 : string) = method32(v1110, v1109, v1125, v1126)
                    let v1129 : (string []) = method33(v1128)
                    let v1130 : string = "$0.to_vec()"
                    let v1131 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v1129 v1130
                    let v1132 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                    let v1133 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1131, v255) v1132
                    let v1134 : US0 = US0_1
                    let v1135 : (unit -> string) = closure27(v1103, v1106, v1104, v1105, v1127, v1133)
                    let v1136 : (unit -> string) = method38()
                    method3(v1134, v1135, v1136)
                    let v1137 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method39(v1103, v1106, v1104, v1105, v1127, v1133)
                    let v1138 : string = "futures_lite::future::block_on($0)"
                    let v1139 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v1137 v1138
                    let (a, b) = v1139
                    let v1140 : int32 = a
                    let v1141 : string = b
                    struct (v1140, v1141)
#endif
                    #if FABLE_COMPILER_RUST && WASM
                    let struct (v1142 : int32, v1143 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1142, v1143)
#endif
                    #if FABLE_COMPILER_RUST && CONTRACT
                    let struct (v1144 : int32, v1145 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1144, v1145)
#endif
                    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                    let v1146 : Async<struct (int32 * string)> option = None
                    let v1147 : bool = true in let mutable _v1146 = v1146
                    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1148 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1148
#endif
                    #if FABLE_COMPILER_RUST && WASM
                    let v1149 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1149
#endif
                    #if FABLE_COMPILER_RUST && CONTRACT
                    let v1150 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1150
#endif
                    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                    let v1151 : Async<struct (int32 * string)> option = None
                    let v1152 : bool = true in let mutable _v1151 = v1151
                    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1153 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1153
#endif
                    #if FABLE_COMPILER_RUST && WASM
                    let v1154 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1154
#endif
                    #if FABLE_COMPILER_RUST && CONTRACT
                    let v1155 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1155
#endif
                    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                    let v1156 : Async<struct (int32 * string)> option = None
                    let mutable _v1156 = v1156
                    async {
                    let struct (v1157 : string, v1158 : string) = method29()
                    let v1159 : (char []) = Array.zeroCreate<char> (v1111)
                    let v1160 : Mut4 = {l0 = 0} : Mut4
                    while method30(v1111, v1160) do
                        let v1162 : int32 = v1160.l0
                        let v1163 : char = v1106.[int v1162]
                        v1159.[int v1162] <- v1163
                        let v1164 : int32 = v1162 + 1
                        v1160.l0 <- v1164
                        ()
                    let v1165 : ((char []) -> char list) = Array.toList
                    let v1166 : char list = v1165 v1159
                    let v1167 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                    let v1168 : (char -> (UH0 -> UH0)) = method31()
                    let v1169 : (char list -> (UH0 -> UH0)) = v1167 v1168
                    let v1170 : (UH0 -> UH0) = v1169 v1166
                    let v1171 : UH0 = UH0_0
                    let v1172 : UH0 = v1170 v1171
                    let v1173 : US10 = US10_0
                    let struct (v1174 : string, v1175 : string) = method32(v1158, v1157, v1172, v1173)
                    let v1176 : (string -> US7) = method40()
                    let v1177 : US7 = US7_1
                    let v1178 : US7 = v1105 |> Option.map v1176 |> Option.defaultValue v1177 
                    let v1181 : string =
                        match v1178 with
                        | US7_1 -> (* None *)
                            v141
                        | US7_0(v1179) -> (* Some *)
                            v1179
                    let v1182 : US0 = US0_1
                    let v1183 : (unit -> string) = closure44(v1103, v1106, v1104, v1105)
                    let v1184 : (unit -> string) = method38()
                    method3(v1182, v1183, v1184)
                    let v1185 : System.Text.Encoding = System.Text.Encoding.UTF8
                    let v1186 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v1175, StandardOutputEncoding = v1185, WorkingDirectory = v1181, FileName = v1174, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                    let v1187 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1186)
                    use v1187 = v1187 
                    let v1188 : System.Diagnostics.Process = v1187 
                    let v1189 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                    let v1190 : System.Collections.Concurrent.ConcurrentStack<string> = v1189 ()
                    let v1191 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v1103, v1106, v1104, v1105, v1188, v1190)
                    v1188.OutputDataReceived.Add v1191 
                    let v1192 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v1103, v1106, v1104, v1105, v1188, v1190)
                    v1188.ErrorDataReceived.Add v1192 
                    let v1193 : (unit -> bool) = v1188.Start
                    let v1194 : bool = v1193 ()
                    let v1195 : bool = v1194 = false
                    if v1195 then
                        let v1196 : string = $"execute_with_options_async / process_start error"
                        failwith<unit> v1196
                    let v1197 : (unit -> unit) = v1188.BeginErrorReadLine
                    v1197 ()
                    let v1198 : (unit -> unit) = v1188.BeginOutputReadLine
                    v1198 ()
                    let v1199 : (System.Threading.CancellationToken -> US18) = method57()
                    let v1200 : US18 = US18_1
                    let v1201 : US18 = v1103 |> Option.map v1199 |> Option.defaultValue v1200 
                    let v1205 : System.Threading.CancellationToken =
                        match v1201 with
                        | US18_1 -> (* None *)
                            let v1203 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                            v1203
                        | US18_0(v1202) -> (* Some *)
                            v1202
                    let v1206 : Async<System.Threading.CancellationToken> option = None
                    let v1207 : bool = true in let mutable _v1206 = v1206
                    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1208 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1208
#endif
                    #if FABLE_COMPILER_RUST && WASM
                    let v1209 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1209
#endif
                    #if FABLE_COMPILER_RUST && CONTRACT
                    let v1210 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1210
#endif
                    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                    let v1211 : Async<System.Threading.CancellationToken> option = None
                    let v1212 : bool = true in let mutable _v1211 = v1211
                    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1213 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1213
#endif
                    #if FABLE_COMPILER_RUST && WASM
                    let v1214 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1214
#endif
                    #if FABLE_COMPILER_RUST && CONTRACT
                    let v1215 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1215
#endif
                    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                    let v1216 : Async<System.Threading.CancellationToken> option = None
                    let mutable _v1216 = v1216
                    async {
                    let v1217 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v1217 = v1217 
                    let v1218 : System.Threading.CancellationToken = v1217 
                    let v1219 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v1220 : (System.Threading.CancellationToken []) = [|v1218; v1219; v1205|]
                    let v1221 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v1222 : System.Threading.CancellationTokenSource = v1221 v1220
                    let v1223 : System.Threading.CancellationToken = v1222.Token
                    return v1223 
                    }
                    |> fun x -> _v1216 <- Some x
                    let v1224 : Async<System.Threading.CancellationToken> = _v1216 |> Option.get
                    v1224
#endif
                    #if FABLE_COMPILER_TYPESCRIPT
                    let v1225 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1225
#endif
                    #if FABLE_COMPILER_PYTHON
                    let v1226 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1226
#endif
                    |> fun x -> _v1211 <- Some x
                    let v1227 : Async<System.Threading.CancellationToken> = _v1211.Value
                    v1227
#endif
                    #if FABLE_COMPILER_TYPESCRIPT
                    let v1228 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1228
#endif
                    #if FABLE_COMPILER_PYTHON
                    let v1229 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                    v1229
#endif
                    |> fun x -> _v1206 <- Some x
                    let v1230 : Async<System.Threading.CancellationToken> = _v1206.Value
                    let! v1230 = v1230 
                    let v1231 : System.Threading.CancellationToken = v1230 
                    let v1232 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1231.Register
                    let v1233 : (unit -> unit) = closure50(v1188)
                    let v1234 : System.Threading.CancellationTokenRegistration = v1232 v1233
                    use v1234 = v1234 
                    let v1235 : System.Threading.CancellationTokenRegistration = v1234 
                    let v1236 : Async<int32> option = None
                    let v1237 : bool = true in let mutable _v1236 = v1236
                    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1238 : Async<int32> = null |> unbox<Async<int32>>
                    v1238
#endif
                    #if FABLE_COMPILER_RUST && WASM
                    let v1239 : Async<int32> = null |> unbox<Async<int32>>
                    v1239
#endif
                    #if FABLE_COMPILER_RUST && CONTRACT
                    let v1240 : Async<int32> = null |> unbox<Async<int32>>
                    v1240
#endif
                    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                    let v1241 : Async<int32> option = None
                    let mutable _v1241 = v1241
                    async {
                    try
                    let v1242 : System.Threading.Tasks.Task = v1188.WaitForExitAsync v1231 
                    let v1243 : Async<unit> option = None
                    let v1244 : bool = true in let mutable _v1243 = v1243
                    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1245 : Async<unit> = null |> unbox<Async<unit>>
                    v1245
#endif
                    #if FABLE_COMPILER_RUST && WASM
                    let v1246 : Async<unit> = null |> unbox<Async<unit>>
                    v1246
#endif
                    #if FABLE_COMPILER_RUST && CONTRACT
                    let v1247 : Async<unit> = null |> unbox<Async<unit>>
                    v1247
#endif
                    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                    let v1248 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1249 : Async<unit> = v1248 v1242
                    v1249
#endif
                    #if FABLE_COMPILER_TYPESCRIPT
                    let v1250 : Async<unit> = null |> unbox<Async<unit>>
                    v1250
#endif
                    #if FABLE_COMPILER_PYTHON
                    let v1251 : Async<unit> = null |> unbox<Async<unit>>
                    v1251
#endif
                    |> fun x -> _v1243 <- Some x
                    let v1252 : Async<unit> = _v1243.Value
                    do! v1252 
                    let v1253 : int32 = v1188.ExitCode
                    return v1253 
                    with ex ->
                    let v1254 : exn = ex
                    let v1255 : string option = None
                    let v1256 : bool = true in let mutable _v1255 = v1255
                    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1257 : string = $"%A{v1254}"
                    v1257
#endif
                    #if FABLE_COMPILER_RUST && WASM
                    let v1258 : string = $"%A{v1254}"
                    v1258
#endif
                    #if FABLE_COMPILER_RUST && CONTRACT
                    let v1259 : string = $"%A{v1254}"
                    v1259
#endif
                    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                    let v1260 : string = $"{v1254.GetType ()}: {v1254.Message}"
                    v1260
#endif
                    #if FABLE_COMPILER_TYPESCRIPT
                    let v1261 : string = $"%A{v1254}"
                    v1261
#endif
                    #if FABLE_COMPILER_PYTHON
                    let v1262 : string = $"%A{v1254}"
                    v1262
#endif
                    |> fun x -> _v1255 <- Some x
                    let v1263 : string = _v1255.Value
                    let v1264 : (string -> unit) = v1190.Push
                    v1264 v1263
                    let v1265 : System.Threading.Tasks.TaskCanceledException = v1254 |> unbox<System.Threading.Tasks.TaskCanceledException>
                    let v1266 : US0 = US0_3
                    let v1267 : (unit -> string) = closure51(v1265)
                    let v1268 : (unit -> string) = method38()
                    method3(v1266, v1267, v1268)
                    return -2147483648 
                    (*
                    *)
                    }
                    |> fun x -> _v1241 <- Some x
                    let v1269 : Async<int32> = _v1241 |> Option.get
                    v1269
#endif
                    #if FABLE_COMPILER_TYPESCRIPT
                    let v1270 : Async<int32> = null |> unbox<Async<int32>>
                    v1270
#endif
                    #if FABLE_COMPILER_PYTHON
                    let v1271 : Async<int32> = null |> unbox<Async<int32>>
                    v1271
#endif
                    |> fun x -> _v1236 <- Some x
                    let v1272 : Async<int32> = _v1236.Value
                    let! v1272 = v1272 
                    let v1273 : int32 = v1272 
                    let v1274 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                    let v1275 : string seq = v1274 v1190
                    let v1276 : string = method58()
                    let v1277 : (string -> (string seq -> string)) = String.concat
                    let v1278 : (string seq -> string) = v1277 v1276
                    let v1279 : string = v1278 v1275
                    let v1280 : US0 = US0_1
                    let v1281 : (unit -> string) = closure52(v1273, v1279)
                    let v1282 : (unit -> string) = method38()
                    method3(v1280, v1281, v1282)
                    return struct (v1273, v1279) 
                    }
                    |> fun x -> _v1156 <- Some x
                    let v1283 : Async<struct (int32 * string)> = _v1156 |> Option.get
                    v1283
#endif
                    #if FABLE_COMPILER_TYPESCRIPT
                    let v1284 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1284
#endif
                    #if FABLE_COMPILER_PYTHON
                    let v1285 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1285
#endif
                    |> fun x -> _v1151 <- Some x
                    let v1286 : Async<struct (int32 * string)> = _v1151.Value
                    v1286
#endif
                    #if FABLE_COMPILER_TYPESCRIPT
                    let v1287 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1287
#endif
                    #if FABLE_COMPILER_PYTHON
                    let v1288 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                    v1288
#endif
                    |> fun x -> _v1146 <- Some x
                    let v1289 : Async<struct (int32 * string)> = _v1146.Value
                    let v1290 : struct (int32 * string) option = None
                    let v1291 : bool = true in let mutable _v1290 = v1290
                    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let struct (v1292 : int32, v1293 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1292, v1293)
#endif
                    #if FABLE_COMPILER_RUST && WASM
                    let struct (v1294 : int32, v1295 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1294, v1295)
#endif
                    #if FABLE_COMPILER_RUST && CONTRACT
                    let struct (v1296 : int32, v1297 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1296, v1297)
#endif
                    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                    let v1298 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                    let struct (v1299 : int32, v1300 : string) = v1298 v1289
                    struct (v1299, v1300)
#endif
                    #if FABLE_COMPILER_TYPESCRIPT
                    let struct (v1301 : int32, v1302 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1301, v1302)
#endif
                    #if FABLE_COMPILER_PYTHON
                    let struct (v1303 : int32, v1304 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1303, v1304)
#endif
                    |> fun x -> _v1290 <- Some x
                    let struct (v1305 : int32, v1306 : string) = _v1290.Value
                    struct (v1305, v1306)
#endif
                    #if FABLE_COMPILER_TYPESCRIPT
                    let struct (v1307 : int32, v1308 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1307, v1308)
#endif
                    #if FABLE_COMPILER_PYTHON
                    let struct (v1309 : int32, v1310 : string) = null |> unbox<struct (int32 * string)>
                    struct (v1309, v1310)
#endif
                    |> fun x -> _v1107 <- Some x
                    let struct (v1311 : int32, v1312 : string) = _v1107.Value
                    v1312
                else
                    v141
            let v1314 : US0 = US0_2
            let v1315 : (unit -> string) = closure53()
            let v1316 : (unit -> string) = closure54(v117, v146, v223, v435, v434, v722, v721, v968, v1313)
            method3(v1314, v1315, v1316)
            let v1317 : bool = v968 <> v1313
            if v1317 then
                let v1318 : string = "epub"
                let v1319 : string = $"{v511}.{v1318}"
                let v1320 : string = $"{v1044}.{v1318}"
                let v1321 : bool option = None
                let v1322 : bool = true in let mutable _v1321 = v1321
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1323 : string = method13(v1319)
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
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v1337 : (string -> bool) = System.IO.File.Exists
                let v1338 : bool = v1337 v1319
                v1338
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v1339 : IFsExistsSync = Fable.Core.JsInterop.importAll v1063
                let v1340 : string = "v1339.existsSync($0)"
                let v1341 : bool = Fable.Core.JsInterop.emitJsExpr v1319 v1340
                v1341
#endif
                #if FABLE_COMPILER_PYTHON
                let v1342 : bool = null |> unbox<bool>
                v1342
#endif
                |> fun x -> _v1321 <- Some x
                let v1343 : bool = _v1321.Value
                let v1367 : bool =
                    if v1343 then
                        let v1344 : bool option = None
                        let v1345 : bool = true in let mutable _v1344 = v1344
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1346 : string = method13(v1320)
                        let v1347 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                        let v1348 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1346 v1347
                        let v1349 : string = "String::from($0)"
                        let v1350 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1348 v1349
                        let v1351 : string = "std::path::PathBuf::from($0)"
                        let v1352 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v1350 v1351
                        let v1353 : string = "$0.exists()"
                        let v1354 : bool = Fable.Core.RustInterop.emitRustExpr v1352 v1353
                        let v1357 : bool =
                            if v1354 then
                                let v1355 : string = "$0.is_file()"
                                let v1356 : bool = Fable.Core.RustInterop.emitRustExpr v1352 v1355
                                v1356
                            else
                                false
                        v1357
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v1358 : bool = null |> unbox<bool>
                        v1358
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v1359 : bool = null |> unbox<bool>
                        v1359
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1360 : (string -> bool) = System.IO.File.Exists
                        let v1361 : bool = v1360 v1320
                        v1361
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v1362 : IFsExistsSync = Fable.Core.JsInterop.importAll v1063
                        let v1363 : string = "v1362.existsSync($0)"
                        let v1364 : bool = Fable.Core.JsInterop.emitJsExpr v1320 v1363
                        v1364
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v1365 : bool = null |> unbox<bool>
                        v1365
#endif
                        |> fun x -> _v1344 <- Some x
                        let v1366 : bool = _v1344.Value
                        v1366
                    else
                        false
                let v1857 : bool =
                    if v1367 then
                        let v1368 : bool option = None
                        let v1369 : bool = true in let mutable _v1368 = v1368
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1370 : string = "cfg!(windows)"
                        let v1371 : bool = Fable.Core.RustInterop.emitRustExpr () v1370
                        v1371
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v1372 : bool = null |> unbox<bool>
                        v1372
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v1373 : bool = null |> unbox<bool>
                        v1373
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1374 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                        let v1375 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                        let v1376 : bool = v1375 v1374
                        v1376
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v1377 : bool = null |> unbox<bool>
                        v1377
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v1378 : bool = null |> unbox<bool>
                        v1378
#endif
                        |> fun x -> _v1368 <- Some x
                        let v1379 : bool = _v1368.Value
                        let v1380 : bool = v1379 = false
                        let v1401 : string =
                            if v1380 then
                                v1319
                            else
                                let v1381 : string option = None
                                let v1382 : bool = true in let mutable _v1381 = v1381
                                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v1383 : string = method26()
                                let v1384 : string = method27(v1319)
                                let v1385 : string = method28()
                                let v1386 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                                let v1387 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1383, v1384, v1385) v1386
                                let v1388 : string = "String::from($0)"
                                let v1389 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1387 v1388
                                let v1390 : string = "fable_library_rust::String_::fromString($0)"
                                let v1391 : string = Fable.Core.RustInterop.emitRustExpr v1389 v1390
                                v1391
#endif
                                #if FABLE_COMPILER_RUST && WASM
                                let v1392 : string = null |> unbox<string>
                                v1392
#endif
                                #if FABLE_COMPILER_RUST && CONTRACT
                                let v1393 : string = null |> unbox<string>
                                v1393
#endif
                                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                                let v1394 : string = "^\\\\\\\\\\?\\\\"
                                let v1395 : string = System.Text.RegularExpressions.Regex.Replace (v1319, v1394, v141)
                                v1395
#endif
                                #if FABLE_COMPILER_TYPESCRIPT
                                let v1396 : string = null |> unbox<string>
                                v1396
#endif
                                #if FABLE_COMPILER_PYTHON
                                let v1397 : string = null |> unbox<string>
                                v1397
#endif
                                |> fun x -> _v1381 <- Some x
                                let v1398 : string = _v1381.Value
                                let v1399 : string = $"{v1398.[0] |> System.Char.ToLower}{v1398.[1..]}"
                                let v1400 : string = v1399.Replace (v143, v144)
                                v1400
                        let v1402 : System.Threading.CancellationToken option = None
                        let v1403 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v1404 : string option = None
                        let v1405 : string = $"pwsh -c \"(Get-FileHash \\\"{v1401}\\\" -Algorithm SHA256).Hash\""
                        let v1406 : struct (int32 * string) option = None
                        let v1407 : bool = true in let mutable _v1406 = v1406
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v1408 : string, v1409 : string) = method29()
                        let v1410 : int32 = v1405.Length
                        let v1411 : (char []) = Array.zeroCreate<char> (v1410)
                        let v1412 : Mut4 = {l0 = 0} : Mut4
                        while method30(v1410, v1412) do
                            let v1414 : int32 = v1412.l0
                            let v1415 : char = v1405.[int v1414]
                            v1411.[int v1414] <- v1415
                            let v1416 : int32 = v1414 + 1
                            v1412.l0 <- v1416
                            ()
                        let v1417 : ((char []) -> char list) = Array.toList
                        let v1418 : char list = v1417 v1411
                        let v1419 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v1420 : (char -> (UH0 -> UH0)) = method31()
                        let v1421 : (char list -> (UH0 -> UH0)) = v1419 v1420
                        let v1422 : (UH0 -> UH0) = v1421 v1418
                        let v1423 : UH0 = UH0_0
                        let v1424 : UH0 = v1422 v1423
                        let v1425 : US10 = US10_0
                        let struct (v1426 : string, v1427 : string) = method32(v1409, v1408, v1424, v1425)
                        let v1428 : (string []) = method33(v1427)
                        let v1429 : string = "$0.to_vec()"
                        let v1430 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v1428 v1429
                        let v1431 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v1432 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1430, v255) v1431
                        let v1433 : US0 = US0_1
                        let v1434 : (unit -> string) = closure27(v1402, v1405, v1403, v1404, v1426, v1432)
                        let v1435 : (unit -> string) = method38()
                        method3(v1433, v1434, v1435)
                        let v1436 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method39(v1402, v1405, v1403, v1404, v1426, v1432)
                        let v1437 : string = "futures_lite::future::block_on($0)"
                        let v1438 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v1436 v1437
                        let (a, b) = v1438
                        let v1439 : int32 = a
                        let v1440 : string = b
                        struct (v1439, v1440)
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let struct (v1441 : int32, v1442 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1441, v1442)
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v1443 : int32, v1444 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1443, v1444)
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1445 : Async<struct (int32 * string)> option = None
                        let v1446 : bool = true in let mutable _v1445 = v1445
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1447 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1447
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v1448 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1448
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v1449 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1449
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1450 : Async<struct (int32 * string)> option = None
                        let v1451 : bool = true in let mutable _v1450 = v1450
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1452 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1452
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v1453 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1453
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v1454 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1454
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1455 : Async<struct (int32 * string)> option = None
                        let mutable _v1455 = v1455
                        async {
                        let struct (v1456 : string, v1457 : string) = method29()
                        let v1458 : (char []) = Array.zeroCreate<char> (v1410)
                        let v1459 : Mut4 = {l0 = 0} : Mut4
                        while method30(v1410, v1459) do
                            let v1461 : int32 = v1459.l0
                            let v1462 : char = v1405.[int v1461]
                            v1458.[int v1461] <- v1462
                            let v1463 : int32 = v1461 + 1
                            v1459.l0 <- v1463
                            ()
                        let v1464 : ((char []) -> char list) = Array.toList
                        let v1465 : char list = v1464 v1458
                        let v1466 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v1467 : (char -> (UH0 -> UH0)) = method31()
                        let v1468 : (char list -> (UH0 -> UH0)) = v1466 v1467
                        let v1469 : (UH0 -> UH0) = v1468 v1465
                        let v1470 : UH0 = UH0_0
                        let v1471 : UH0 = v1469 v1470
                        let v1472 : US10 = US10_0
                        let struct (v1473 : string, v1474 : string) = method32(v1457, v1456, v1471, v1472)
                        let v1475 : (string -> US7) = method40()
                        let v1476 : US7 = US7_1
                        let v1477 : US7 = v1404 |> Option.map v1475 |> Option.defaultValue v1476 
                        let v1480 : string =
                            match v1477 with
                            | US7_1 -> (* None *)
                                v141
                            | US7_0(v1478) -> (* Some *)
                                v1478
                        let v1481 : US0 = US0_1
                        let v1482 : (unit -> string) = closure44(v1402, v1405, v1403, v1404)
                        let v1483 : (unit -> string) = method38()
                        method3(v1481, v1482, v1483)
                        let v1484 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v1485 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v1474, StandardOutputEncoding = v1484, WorkingDirectory = v1480, FileName = v1473, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v1486 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1485)
                        use v1486 = v1486 
                        let v1487 : System.Diagnostics.Process = v1486 
                        let v1488 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v1489 : System.Collections.Concurrent.ConcurrentStack<string> = v1488 ()
                        let v1490 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v1402, v1405, v1403, v1404, v1487, v1489)
                        v1487.OutputDataReceived.Add v1490 
                        let v1491 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v1402, v1405, v1403, v1404, v1487, v1489)
                        v1487.ErrorDataReceived.Add v1491 
                        let v1492 : (unit -> bool) = v1487.Start
                        let v1493 : bool = v1492 ()
                        let v1494 : bool = v1493 = false
                        if v1494 then
                            let v1495 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v1495
                        let v1496 : (unit -> unit) = v1487.BeginErrorReadLine
                        v1496 ()
                        let v1497 : (unit -> unit) = v1487.BeginOutputReadLine
                        v1497 ()
                        let v1498 : (System.Threading.CancellationToken -> US18) = method57()
                        let v1499 : US18 = US18_1
                        let v1500 : US18 = v1402 |> Option.map v1498 |> Option.defaultValue v1499 
                        let v1504 : System.Threading.CancellationToken =
                            match v1500 with
                            | US18_1 -> (* None *)
                                let v1502 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v1502
                            | US18_0(v1501) -> (* Some *)
                                v1501
                        let v1505 : Async<System.Threading.CancellationToken> option = None
                        let v1506 : bool = true in let mutable _v1505 = v1505
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1507 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1507
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v1508 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1508
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v1509 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1509
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1510 : Async<System.Threading.CancellationToken> option = None
                        let v1511 : bool = true in let mutable _v1510 = v1510
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1512 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1512
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v1513 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1513
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v1514 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1514
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1515 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v1515 = v1515
                        async {
                        let v1516 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v1516 = v1516 
                        let v1517 : System.Threading.CancellationToken = v1516 
                        let v1518 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v1519 : (System.Threading.CancellationToken []) = [|v1517; v1518; v1504|]
                        let v1520 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v1521 : System.Threading.CancellationTokenSource = v1520 v1519
                        let v1522 : System.Threading.CancellationToken = v1521.Token
                        return v1522 
                        }
                        |> fun x -> _v1515 <- Some x
                        let v1523 : Async<System.Threading.CancellationToken> = _v1515 |> Option.get
                        v1523
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v1524 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1524
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v1525 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1525
#endif
                        |> fun x -> _v1510 <- Some x
                        let v1526 : Async<System.Threading.CancellationToken> = _v1510.Value
                        v1526
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v1527 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1527
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v1528 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1528
#endif
                        |> fun x -> _v1505 <- Some x
                        let v1529 : Async<System.Threading.CancellationToken> = _v1505.Value
                        let! v1529 = v1529 
                        let v1530 : System.Threading.CancellationToken = v1529 
                        let v1531 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1530.Register
                        let v1532 : (unit -> unit) = closure50(v1487)
                        let v1533 : System.Threading.CancellationTokenRegistration = v1531 v1532
                        use v1533 = v1533 
                        let v1534 : System.Threading.CancellationTokenRegistration = v1533 
                        let v1535 : Async<int32> option = None
                        let v1536 : bool = true in let mutable _v1535 = v1535
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1537 : Async<int32> = null |> unbox<Async<int32>>
                        v1537
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v1538 : Async<int32> = null |> unbox<Async<int32>>
                        v1538
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v1539 : Async<int32> = null |> unbox<Async<int32>>
                        v1539
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1540 : Async<int32> option = None
                        let mutable _v1540 = v1540
                        async {
                        try
                        let v1541 : System.Threading.Tasks.Task = v1487.WaitForExitAsync v1530 
                        let v1542 : Async<unit> option = None
                        let v1543 : bool = true in let mutable _v1542 = v1542
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1544 : Async<unit> = null |> unbox<Async<unit>>
                        v1544
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v1545 : Async<unit> = null |> unbox<Async<unit>>
                        v1545
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v1546 : Async<unit> = null |> unbox<Async<unit>>
                        v1546
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1547 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v1548 : Async<unit> = v1547 v1541
                        v1548
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v1549 : Async<unit> = null |> unbox<Async<unit>>
                        v1549
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v1550 : Async<unit> = null |> unbox<Async<unit>>
                        v1550
#endif
                        |> fun x -> _v1542 <- Some x
                        let v1551 : Async<unit> = _v1542.Value
                        do! v1551 
                        let v1552 : int32 = v1487.ExitCode
                        return v1552 
                        with ex ->
                        let v1553 : exn = ex
                        let v1554 : string option = None
                        let v1555 : bool = true in let mutable _v1554 = v1554
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1556 : string = $"%A{v1553}"
                        v1556
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v1557 : string = $"%A{v1553}"
                        v1557
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v1558 : string = $"%A{v1553}"
                        v1558
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1559 : string = $"{v1553.GetType ()}: {v1553.Message}"
                        v1559
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v1560 : string = $"%A{v1553}"
                        v1560
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v1561 : string = $"%A{v1553}"
                        v1561
#endif
                        |> fun x -> _v1554 <- Some x
                        let v1562 : string = _v1554.Value
                        let v1563 : (string -> unit) = v1489.Push
                        v1563 v1562
                        let v1564 : System.Threading.Tasks.TaskCanceledException = v1553 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v1565 : US0 = US0_3
                        let v1566 : (unit -> string) = closure51(v1564)
                        let v1567 : (unit -> string) = method38()
                        method3(v1565, v1566, v1567)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v1540 <- Some x
                        let v1568 : Async<int32> = _v1540 |> Option.get
                        v1568
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v1569 : Async<int32> = null |> unbox<Async<int32>>
                        v1569
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v1570 : Async<int32> = null |> unbox<Async<int32>>
                        v1570
#endif
                        |> fun x -> _v1535 <- Some x
                        let v1571 : Async<int32> = _v1535.Value
                        let! v1571 = v1571 
                        let v1572 : int32 = v1571 
                        let v1573 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v1574 : string seq = v1573 v1489
                        let v1575 : string = method58()
                        let v1576 : (string -> (string seq -> string)) = String.concat
                        let v1577 : (string seq -> string) = v1576 v1575
                        let v1578 : string = v1577 v1574
                        let v1579 : US0 = US0_1
                        let v1580 : (unit -> string) = closure52(v1572, v1578)
                        let v1581 : (unit -> string) = method38()
                        method3(v1579, v1580, v1581)
                        return struct (v1572, v1578) 
                        }
                        |> fun x -> _v1455 <- Some x
                        let v1582 : Async<struct (int32 * string)> = _v1455 |> Option.get
                        v1582
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v1583 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1583
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v1584 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1584
#endif
                        |> fun x -> _v1450 <- Some x
                        let v1585 : Async<struct (int32 * string)> = _v1450.Value
                        v1585
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v1586 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1586
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v1587 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1587
#endif
                        |> fun x -> _v1445 <- Some x
                        let v1588 : Async<struct (int32 * string)> = _v1445.Value
                        let v1589 : struct (int32 * string) option = None
                        let v1590 : bool = true in let mutable _v1589 = v1589
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v1591 : int32, v1592 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1591, v1592)
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let struct (v1593 : int32, v1594 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1593, v1594)
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v1595 : int32, v1596 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1595, v1596)
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1597 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v1598 : int32, v1599 : string) = v1597 v1588
                        struct (v1598, v1599)
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let struct (v1600 : int32, v1601 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1600, v1601)
#endif
                        #if FABLE_COMPILER_PYTHON
                        let struct (v1602 : int32, v1603 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1602, v1603)
#endif
                        |> fun x -> _v1589 <- Some x
                        let struct (v1604 : int32, v1605 : string) = _v1589.Value
                        struct (v1604, v1605)
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let struct (v1606 : int32, v1607 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1606, v1607)
#endif
                        #if FABLE_COMPILER_PYTHON
                        let struct (v1608 : int32, v1609 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1608, v1609)
#endif
                        |> fun x -> _v1406 <- Some x
                        let struct (v1610 : int32, v1611 : string) = _v1406.Value
                        let v1612 : bool option = None
                        let v1613 : bool = true in let mutable _v1612 = v1612
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1614 : string = "cfg!(windows)"
                        let v1615 : bool = Fable.Core.RustInterop.emitRustExpr () v1614
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
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1618 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                        let v1619 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                        let v1620 : bool = v1619 v1618
                        v1620
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v1621 : bool = null |> unbox<bool>
                        v1621
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v1622 : bool = null |> unbox<bool>
                        v1622
#endif
                        |> fun x -> _v1612 <- Some x
                        let v1623 : bool = _v1612.Value
                        let v1624 : bool = v1623 = false
                        let v1645 : string =
                            if v1624 then
                                v1320
                            else
                                let v1625 : string option = None
                                let v1626 : bool = true in let mutable _v1625 = v1625
                                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v1627 : string = method26()
                                let v1628 : string = method27(v1320)
                                let v1629 : string = method28()
                                let v1630 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                                let v1631 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v1627, v1628, v1629) v1630
                                let v1632 : string = "String::from($0)"
                                let v1633 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1631 v1632
                                let v1634 : string = "fable_library_rust::String_::fromString($0)"
                                let v1635 : string = Fable.Core.RustInterop.emitRustExpr v1633 v1634
                                v1635
#endif
                                #if FABLE_COMPILER_RUST && WASM
                                let v1636 : string = null |> unbox<string>
                                v1636
#endif
                                #if FABLE_COMPILER_RUST && CONTRACT
                                let v1637 : string = null |> unbox<string>
                                v1637
#endif
                                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                                let v1638 : string = "^\\\\\\\\\\?\\\\"
                                let v1639 : string = System.Text.RegularExpressions.Regex.Replace (v1320, v1638, v141)
                                v1639
#endif
                                #if FABLE_COMPILER_TYPESCRIPT
                                let v1640 : string = null |> unbox<string>
                                v1640
#endif
                                #if FABLE_COMPILER_PYTHON
                                let v1641 : string = null |> unbox<string>
                                v1641
#endif
                                |> fun x -> _v1625 <- Some x
                                let v1642 : string = _v1625.Value
                                let v1643 : string = $"{v1642.[0] |> System.Char.ToLower}{v1642.[1..]}"
                                let v1644 : string = v1643.Replace (v143, v144)
                                v1644
                        let v1646 : System.Threading.CancellationToken option = None
                        let v1647 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v1648 : string option = None
                        let v1649 : string = $"pwsh -c \"(Get-FileHash \\\"{v1645}\\\" -Algorithm SHA256).Hash\""
                        let v1650 : struct (int32 * string) option = None
                        let v1651 : bool = true in let mutable _v1650 = v1650
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v1652 : string, v1653 : string) = method29()
                        let v1654 : int32 = v1649.Length
                        let v1655 : (char []) = Array.zeroCreate<char> (v1654)
                        let v1656 : Mut4 = {l0 = 0} : Mut4
                        while method30(v1654, v1656) do
                            let v1658 : int32 = v1656.l0
                            let v1659 : char = v1649.[int v1658]
                            v1655.[int v1658] <- v1659
                            let v1660 : int32 = v1658 + 1
                            v1656.l0 <- v1660
                            ()
                        let v1661 : ((char []) -> char list) = Array.toList
                        let v1662 : char list = v1661 v1655
                        let v1663 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v1664 : (char -> (UH0 -> UH0)) = method31()
                        let v1665 : (char list -> (UH0 -> UH0)) = v1663 v1664
                        let v1666 : (UH0 -> UH0) = v1665 v1662
                        let v1667 : UH0 = UH0_0
                        let v1668 : UH0 = v1666 v1667
                        let v1669 : US10 = US10_0
                        let struct (v1670 : string, v1671 : string) = method32(v1653, v1652, v1668, v1669)
                        let v1672 : (string []) = method33(v1671)
                        let v1673 : string = "$0.to_vec()"
                        let v1674 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v1672 v1673
                        let v1675 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v1676 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1674, v255) v1675
                        let v1677 : US0 = US0_1
                        let v1678 : (unit -> string) = closure27(v1646, v1649, v1647, v1648, v1670, v1676)
                        let v1679 : (unit -> string) = method38()
                        method3(v1677, v1678, v1679)
                        let v1680 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method39(v1646, v1649, v1647, v1648, v1670, v1676)
                        let v1681 : string = "futures_lite::future::block_on($0)"
                        let v1682 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v1680 v1681
                        let (a, b) = v1682
                        let v1683 : int32 = a
                        let v1684 : string = b
                        struct (v1683, v1684)
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let struct (v1685 : int32, v1686 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1685, v1686)
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v1687 : int32, v1688 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1687, v1688)
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1689 : Async<struct (int32 * string)> option = None
                        let v1690 : bool = true in let mutable _v1689 = v1689
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1691 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1691
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v1692 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1692
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v1693 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1693
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1694 : Async<struct (int32 * string)> option = None
                        let v1695 : bool = true in let mutable _v1694 = v1694
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1696 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1696
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v1697 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1697
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v1698 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1698
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1699 : Async<struct (int32 * string)> option = None
                        let mutable _v1699 = v1699
                        async {
                        let struct (v1700 : string, v1701 : string) = method29()
                        let v1702 : (char []) = Array.zeroCreate<char> (v1654)
                        let v1703 : Mut4 = {l0 = 0} : Mut4
                        while method30(v1654, v1703) do
                            let v1705 : int32 = v1703.l0
                            let v1706 : char = v1649.[int v1705]
                            v1702.[int v1705] <- v1706
                            let v1707 : int32 = v1705 + 1
                            v1703.l0 <- v1707
                            ()
                        let v1708 : ((char []) -> char list) = Array.toList
                        let v1709 : char list = v1708 v1702
                        let v1710 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v1711 : (char -> (UH0 -> UH0)) = method31()
                        let v1712 : (char list -> (UH0 -> UH0)) = v1710 v1711
                        let v1713 : (UH0 -> UH0) = v1712 v1709
                        let v1714 : UH0 = UH0_0
                        let v1715 : UH0 = v1713 v1714
                        let v1716 : US10 = US10_0
                        let struct (v1717 : string, v1718 : string) = method32(v1701, v1700, v1715, v1716)
                        let v1719 : (string -> US7) = method40()
                        let v1720 : US7 = US7_1
                        let v1721 : US7 = v1648 |> Option.map v1719 |> Option.defaultValue v1720 
                        let v1724 : string =
                            match v1721 with
                            | US7_1 -> (* None *)
                                v141
                            | US7_0(v1722) -> (* Some *)
                                v1722
                        let v1725 : US0 = US0_1
                        let v1726 : (unit -> string) = closure44(v1646, v1649, v1647, v1648)
                        let v1727 : (unit -> string) = method38()
                        method3(v1725, v1726, v1727)
                        let v1728 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v1729 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v1718, StandardOutputEncoding = v1728, WorkingDirectory = v1724, FileName = v1717, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v1730 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1729)
                        use v1730 = v1730 
                        let v1731 : System.Diagnostics.Process = v1730 
                        let v1732 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v1733 : System.Collections.Concurrent.ConcurrentStack<string> = v1732 ()
                        let v1734 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v1646, v1649, v1647, v1648, v1731, v1733)
                        v1731.OutputDataReceived.Add v1734 
                        let v1735 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v1646, v1649, v1647, v1648, v1731, v1733)
                        v1731.ErrorDataReceived.Add v1735 
                        let v1736 : (unit -> bool) = v1731.Start
                        let v1737 : bool = v1736 ()
                        let v1738 : bool = v1737 = false
                        if v1738 then
                            let v1739 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v1739
                        let v1740 : (unit -> unit) = v1731.BeginErrorReadLine
                        v1740 ()
                        let v1741 : (unit -> unit) = v1731.BeginOutputReadLine
                        v1741 ()
                        let v1742 : (System.Threading.CancellationToken -> US18) = method57()
                        let v1743 : US18 = US18_1
                        let v1744 : US18 = v1646 |> Option.map v1742 |> Option.defaultValue v1743 
                        let v1748 : System.Threading.CancellationToken =
                            match v1744 with
                            | US18_1 -> (* None *)
                                let v1746 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v1746
                            | US18_0(v1745) -> (* Some *)
                                v1745
                        let v1749 : Async<System.Threading.CancellationToken> option = None
                        let v1750 : bool = true in let mutable _v1749 = v1749
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1751 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1751
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v1752 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1752
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v1753 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1753
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1754 : Async<System.Threading.CancellationToken> option = None
                        let v1755 : bool = true in let mutable _v1754 = v1754
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1756 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1756
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v1757 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1757
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v1758 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1758
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1759 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v1759 = v1759
                        async {
                        let v1760 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v1760 = v1760 
                        let v1761 : System.Threading.CancellationToken = v1760 
                        let v1762 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v1763 : (System.Threading.CancellationToken []) = [|v1761; v1762; v1748|]
                        let v1764 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v1765 : System.Threading.CancellationTokenSource = v1764 v1763
                        let v1766 : System.Threading.CancellationToken = v1765.Token
                        return v1766 
                        }
                        |> fun x -> _v1759 <- Some x
                        let v1767 : Async<System.Threading.CancellationToken> = _v1759 |> Option.get
                        v1767
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v1768 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1768
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v1769 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1769
#endif
                        |> fun x -> _v1754 <- Some x
                        let v1770 : Async<System.Threading.CancellationToken> = _v1754.Value
                        v1770
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v1771 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1771
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v1772 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1772
#endif
                        |> fun x -> _v1749 <- Some x
                        let v1773 : Async<System.Threading.CancellationToken> = _v1749.Value
                        let! v1773 = v1773 
                        let v1774 : System.Threading.CancellationToken = v1773 
                        let v1775 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1774.Register
                        let v1776 : (unit -> unit) = closure50(v1731)
                        let v1777 : System.Threading.CancellationTokenRegistration = v1775 v1776
                        use v1777 = v1777 
                        let v1778 : System.Threading.CancellationTokenRegistration = v1777 
                        let v1779 : Async<int32> option = None
                        let v1780 : bool = true in let mutable _v1779 = v1779
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1781 : Async<int32> = null |> unbox<Async<int32>>
                        v1781
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v1782 : Async<int32> = null |> unbox<Async<int32>>
                        v1782
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v1783 : Async<int32> = null |> unbox<Async<int32>>
                        v1783
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1784 : Async<int32> option = None
                        let mutable _v1784 = v1784
                        async {
                        try
                        let v1785 : System.Threading.Tasks.Task = v1731.WaitForExitAsync v1774 
                        let v1786 : Async<unit> option = None
                        let v1787 : bool = true in let mutable _v1786 = v1786
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1788 : Async<unit> = null |> unbox<Async<unit>>
                        v1788
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v1789 : Async<unit> = null |> unbox<Async<unit>>
                        v1789
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v1790 : Async<unit> = null |> unbox<Async<unit>>
                        v1790
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1791 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v1792 : Async<unit> = v1791 v1785
                        v1792
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v1793 : Async<unit> = null |> unbox<Async<unit>>
                        v1793
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v1794 : Async<unit> = null |> unbox<Async<unit>>
                        v1794
#endif
                        |> fun x -> _v1786 <- Some x
                        let v1795 : Async<unit> = _v1786.Value
                        do! v1795 
                        let v1796 : int32 = v1731.ExitCode
                        return v1796 
                        with ex ->
                        let v1797 : exn = ex
                        let v1798 : string option = None
                        let v1799 : bool = true in let mutable _v1798 = v1798
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1800 : string = $"%A{v1797}"
                        v1800
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v1801 : string = $"%A{v1797}"
                        v1801
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v1802 : string = $"%A{v1797}"
                        v1802
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1803 : string = $"{v1797.GetType ()}: {v1797.Message}"
                        v1803
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v1804 : string = $"%A{v1797}"
                        v1804
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v1805 : string = $"%A{v1797}"
                        v1805
#endif
                        |> fun x -> _v1798 <- Some x
                        let v1806 : string = _v1798.Value
                        let v1807 : (string -> unit) = v1733.Push
                        v1807 v1806
                        let v1808 : System.Threading.Tasks.TaskCanceledException = v1797 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v1809 : US0 = US0_3
                        let v1810 : (unit -> string) = closure51(v1808)
                        let v1811 : (unit -> string) = method38()
                        method3(v1809, v1810, v1811)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v1784 <- Some x
                        let v1812 : Async<int32> = _v1784 |> Option.get
                        v1812
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v1813 : Async<int32> = null |> unbox<Async<int32>>
                        v1813
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v1814 : Async<int32> = null |> unbox<Async<int32>>
                        v1814
#endif
                        |> fun x -> _v1779 <- Some x
                        let v1815 : Async<int32> = _v1779.Value
                        let! v1815 = v1815 
                        let v1816 : int32 = v1815 
                        let v1817 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v1818 : string seq = v1817 v1733
                        let v1819 : string = method58()
                        let v1820 : (string -> (string seq -> string)) = String.concat
                        let v1821 : (string seq -> string) = v1820 v1819
                        let v1822 : string = v1821 v1818
                        let v1823 : US0 = US0_1
                        let v1824 : (unit -> string) = closure52(v1816, v1822)
                        let v1825 : (unit -> string) = method38()
                        method3(v1823, v1824, v1825)
                        return struct (v1816, v1822) 
                        }
                        |> fun x -> _v1699 <- Some x
                        let v1826 : Async<struct (int32 * string)> = _v1699 |> Option.get
                        v1826
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v1827 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1827
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v1828 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1828
#endif
                        |> fun x -> _v1694 <- Some x
                        let v1829 : Async<struct (int32 * string)> = _v1694.Value
                        v1829
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v1830 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1830
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v1831 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1831
#endif
                        |> fun x -> _v1689 <- Some x
                        let v1832 : Async<struct (int32 * string)> = _v1689.Value
                        let v1833 : struct (int32 * string) option = None
                        let v1834 : bool = true in let mutable _v1833 = v1833
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v1835 : int32, v1836 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1835, v1836)
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let struct (v1837 : int32, v1838 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1837, v1838)
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v1839 : int32, v1840 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1839, v1840)
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1841 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v1842 : int32, v1843 : string) = v1841 v1832
                        struct (v1842, v1843)
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let struct (v1844 : int32, v1845 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1844, v1845)
#endif
                        #if FABLE_COMPILER_PYTHON
                        let struct (v1846 : int32, v1847 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1846, v1847)
#endif
                        |> fun x -> _v1833 <- Some x
                        let struct (v1848 : int32, v1849 : string) = _v1833.Value
                        struct (v1848, v1849)
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let struct (v1850 : int32, v1851 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1850, v1851)
#endif
                        #if FABLE_COMPILER_PYTHON
                        let struct (v1852 : int32, v1853 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1852, v1853)
#endif
                        |> fun x -> _v1650 <- Some x
                        let struct (v1854 : int32, v1855 : string) = _v1650.Value
                        let v1856 : bool = v1611 = v1855
                        v1856
                    else
                        false
                let v1858 : bool = v1857 = false
                let v2090 : US8 =
                    if v1858 then
                        let v1859 : string = $"crowbook --single \"{v511}\" --output \"{v1319}\" --to {v1318} --set rendering.num_depth 6 html.css.add \\\"''' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} '''\\\""
                        let v1860 : System.Threading.CancellationToken option = None
                        let v1861 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v1862 : string option = None
                        let v1863 : string option = Some v1 
                        let v1864 : struct (int32 * string) option = None
                        let v1865 : bool = true in let mutable _v1864 = v1864
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v1866 : string, v1867 : string) = method29()
                        let v1868 : int32 = v1859.Length
                        let v1869 : (char []) = Array.zeroCreate<char> (v1868)
                        let v1870 : Mut4 = {l0 = 0} : Mut4
                        while method30(v1868, v1870) do
                            let v1872 : int32 = v1870.l0
                            let v1873 : char = v1859.[int v1872]
                            v1869.[int v1872] <- v1873
                            let v1874 : int32 = v1872 + 1
                            v1870.l0 <- v1874
                            ()
                        let v1875 : ((char []) -> char list) = Array.toList
                        let v1876 : char list = v1875 v1869
                        let v1877 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v1878 : (char -> (UH0 -> UH0)) = method31()
                        let v1879 : (char list -> (UH0 -> UH0)) = v1877 v1878
                        let v1880 : (UH0 -> UH0) = v1879 v1876
                        let v1881 : UH0 = UH0_0
                        let v1882 : UH0 = v1880 v1881
                        let v1883 : US10 = US10_0
                        let struct (v1884 : string, v1885 : string) = method32(v1867, v1866, v1882, v1883)
                        let v1886 : (string []) = method33(v1885)
                        let v1887 : string = "$0.to_vec()"
                        let v1888 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v1886 v1887
                        let v1889 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v1890 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1888, v255) v1889
                        let v1891 : US0 = US0_1
                        let v1892 : (unit -> string) = closure27(v1860, v1859, v1861, v1863, v1884, v1890)
                        let v1893 : (unit -> string) = method38()
                        method3(v1891, v1892, v1893)
                        let v1894 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method39(v1860, v1859, v1861, v1863, v1884, v1890)
                        let v1895 : string = "futures_lite::future::block_on($0)"
                        let v1896 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v1894 v1895
                        let (a, b) = v1896
                        let v1897 : int32 = a
                        let v1898 : string = b
                        struct (v1897, v1898)
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let struct (v1899 : int32, v1900 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1899, v1900)
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v1901 : int32, v1902 : string) = null |> unbox<struct (int32 * string)>
                        struct (v1901, v1902)
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1903 : Async<struct (int32 * string)> option = None
                        let v1904 : bool = true in let mutable _v1903 = v1903
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1905 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1905
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v1906 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1906
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v1907 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1907
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1908 : Async<struct (int32 * string)> option = None
                        let v1909 : bool = true in let mutable _v1908 = v1908
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1910 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1910
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v1911 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1911
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v1912 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v1912
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1913 : Async<struct (int32 * string)> option = None
                        let mutable _v1913 = v1913
                        async {
                        let struct (v1914 : string, v1915 : string) = method29()
                        let v1916 : (char []) = Array.zeroCreate<char> (v1868)
                        let v1917 : Mut4 = {l0 = 0} : Mut4
                        while method30(v1868, v1917) do
                            let v1919 : int32 = v1917.l0
                            let v1920 : char = v1859.[int v1919]
                            v1916.[int v1919] <- v1920
                            let v1921 : int32 = v1919 + 1
                            v1917.l0 <- v1921
                            ()
                        let v1922 : ((char []) -> char list) = Array.toList
                        let v1923 : char list = v1922 v1916
                        let v1924 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v1925 : (char -> (UH0 -> UH0)) = method31()
                        let v1926 : (char list -> (UH0 -> UH0)) = v1924 v1925
                        let v1927 : (UH0 -> UH0) = v1926 v1923
                        let v1928 : UH0 = UH0_0
                        let v1929 : UH0 = v1927 v1928
                        let v1930 : US10 = US10_0
                        let struct (v1931 : string, v1932 : string) = method32(v1915, v1914, v1929, v1930)
                        let v1933 : (string -> US7) = method40()
                        let v1934 : US7 = US7_1
                        let v1935 : US7 = v1863 |> Option.map v1933 |> Option.defaultValue v1934 
                        let v1938 : string =
                            match v1935 with
                            | US7_1 -> (* None *)
                                v141
                            | US7_0(v1936) -> (* Some *)
                                v1936
                        let v1939 : US0 = US0_1
                        let v1940 : (unit -> string) = closure44(v1860, v1859, v1861, v1863)
                        let v1941 : (unit -> string) = method38()
                        method3(v1939, v1940, v1941)
                        let v1942 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v1943 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v1932, StandardOutputEncoding = v1942, WorkingDirectory = v1938, FileName = v1931, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v1944 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1943)
                        use v1944 = v1944 
                        let v1945 : System.Diagnostics.Process = v1944 
                        let v1946 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v1947 : System.Collections.Concurrent.ConcurrentStack<string> = v1946 ()
                        let v1948 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v1860, v1859, v1861, v1863, v1945, v1947)
                        v1945.OutputDataReceived.Add v1948 
                        let v1949 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v1860, v1859, v1861, v1863, v1945, v1947)
                        v1945.ErrorDataReceived.Add v1949 
                        let v1950 : (unit -> bool) = v1945.Start
                        let v1951 : bool = v1950 ()
                        let v1952 : bool = v1951 = false
                        if v1952 then
                            let v1953 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v1953
                        let v1954 : (unit -> unit) = v1945.BeginErrorReadLine
                        v1954 ()
                        let v1955 : (unit -> unit) = v1945.BeginOutputReadLine
                        v1955 ()
                        let v1956 : (System.Threading.CancellationToken -> US18) = method57()
                        let v1957 : US18 = US18_1
                        let v1958 : US18 = v1860 |> Option.map v1956 |> Option.defaultValue v1957 
                        let v1962 : System.Threading.CancellationToken =
                            match v1958 with
                            | US18_1 -> (* None *)
                                let v1960 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v1960
                            | US18_0(v1959) -> (* Some *)
                                v1959
                        let v1963 : Async<System.Threading.CancellationToken> option = None
                        let v1964 : bool = true in let mutable _v1963 = v1963
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1965 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1965
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v1966 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1966
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v1967 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1967
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1968 : Async<System.Threading.CancellationToken> option = None
                        let v1969 : bool = true in let mutable _v1968 = v1968
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1970 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1970
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v1971 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1971
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v1972 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1972
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1973 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v1973 = v1973
                        async {
                        let v1974 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v1974 = v1974 
                        let v1975 : System.Threading.CancellationToken = v1974 
                        let v1976 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v1977 : (System.Threading.CancellationToken []) = [|v1975; v1976; v1962|]
                        let v1978 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v1979 : System.Threading.CancellationTokenSource = v1978 v1977
                        let v1980 : System.Threading.CancellationToken = v1979.Token
                        return v1980 
                        }
                        |> fun x -> _v1973 <- Some x
                        let v1981 : Async<System.Threading.CancellationToken> = _v1973 |> Option.get
                        v1981
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v1982 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1982
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v1983 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1983
#endif
                        |> fun x -> _v1968 <- Some x
                        let v1984 : Async<System.Threading.CancellationToken> = _v1968.Value
                        v1984
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v1985 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1985
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v1986 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v1986
#endif
                        |> fun x -> _v1963 <- Some x
                        let v1987 : Async<System.Threading.CancellationToken> = _v1963.Value
                        let! v1987 = v1987 
                        let v1988 : System.Threading.CancellationToken = v1987 
                        let v1989 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1988.Register
                        let v1990 : (unit -> unit) = closure50(v1945)
                        let v1991 : System.Threading.CancellationTokenRegistration = v1989 v1990
                        use v1991 = v1991 
                        let v1992 : System.Threading.CancellationTokenRegistration = v1991 
                        let v1993 : Async<int32> option = None
                        let v1994 : bool = true in let mutable _v1993 = v1993
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1995 : Async<int32> = null |> unbox<Async<int32>>
                        v1995
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v1996 : Async<int32> = null |> unbox<Async<int32>>
                        v1996
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v1997 : Async<int32> = null |> unbox<Async<int32>>
                        v1997
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v1998 : Async<int32> option = None
                        let mutable _v1998 = v1998
                        async {
                        try
                        let v1999 : System.Threading.Tasks.Task = v1945.WaitForExitAsync v1988 
                        let v2000 : Async<unit> option = None
                        let v2001 : bool = true in let mutable _v2000 = v2000
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2002 : Async<unit> = null |> unbox<Async<unit>>
                        v2002
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2003 : Async<unit> = null |> unbox<Async<unit>>
                        v2003
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2004 : Async<unit> = null |> unbox<Async<unit>>
                        v2004
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2005 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v2006 : Async<unit> = v2005 v1999
                        v2006
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2007 : Async<unit> = null |> unbox<Async<unit>>
                        v2007
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2008 : Async<unit> = null |> unbox<Async<unit>>
                        v2008
#endif
                        |> fun x -> _v2000 <- Some x
                        let v2009 : Async<unit> = _v2000.Value
                        do! v2009 
                        let v2010 : int32 = v1945.ExitCode
                        return v2010 
                        with ex ->
                        let v2011 : exn = ex
                        let v2012 : string option = None
                        let v2013 : bool = true in let mutable _v2012 = v2012
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2014 : string = $"%A{v2011}"
                        v2014
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2015 : string = $"%A{v2011}"
                        v2015
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2016 : string = $"%A{v2011}"
                        v2016
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2017 : string = $"{v2011.GetType ()}: {v2011.Message}"
                        v2017
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2018 : string = $"%A{v2011}"
                        v2018
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2019 : string = $"%A{v2011}"
                        v2019
#endif
                        |> fun x -> _v2012 <- Some x
                        let v2020 : string = _v2012.Value
                        let v2021 : (string -> unit) = v1947.Push
                        v2021 v2020
                        let v2022 : System.Threading.Tasks.TaskCanceledException = v2011 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v2023 : US0 = US0_3
                        let v2024 : (unit -> string) = closure51(v2022)
                        let v2025 : (unit -> string) = method38()
                        method3(v2023, v2024, v2025)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v1998 <- Some x
                        let v2026 : Async<int32> = _v1998 |> Option.get
                        v2026
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2027 : Async<int32> = null |> unbox<Async<int32>>
                        v2027
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2028 : Async<int32> = null |> unbox<Async<int32>>
                        v2028
#endif
                        |> fun x -> _v1993 <- Some x
                        let v2029 : Async<int32> = _v1993.Value
                        let! v2029 = v2029 
                        let v2030 : int32 = v2029 
                        let v2031 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v2032 : string seq = v2031 v1947
                        let v2033 : string = method58()
                        let v2034 : (string -> (string seq -> string)) = String.concat
                        let v2035 : (string seq -> string) = v2034 v2033
                        let v2036 : string = v2035 v2032
                        let v2037 : US0 = US0_1
                        let v2038 : (unit -> string) = closure52(v2030, v2036)
                        let v2039 : (unit -> string) = method38()
                        method3(v2037, v2038, v2039)
                        return struct (v2030, v2036) 
                        }
                        |> fun x -> _v1913 <- Some x
                        let v2040 : Async<struct (int32 * string)> = _v1913 |> Option.get
                        v2040
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2041 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2041
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2042 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2042
#endif
                        |> fun x -> _v1908 <- Some x
                        let v2043 : Async<struct (int32 * string)> = _v1908.Value
                        v2043
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2044 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2044
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2045 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2045
#endif
                        |> fun x -> _v1903 <- Some x
                        let v2046 : Async<struct (int32 * string)> = _v1903.Value
                        let v2047 : struct (int32 * string) option = None
                        let v2048 : bool = true in let mutable _v2047 = v2047
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v2049 : int32, v2050 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2049, v2050)
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let struct (v2051 : int32, v2052 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2051, v2052)
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2053 : int32, v2054 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2053, v2054)
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2055 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v2056 : int32, v2057 : string) = v2055 v2046
                        struct (v2056, v2057)
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2058 : int32, v2059 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2058, v2059)
#endif
                        #if FABLE_COMPILER_PYTHON
                        let struct (v2060 : int32, v2061 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2060, v2061)
#endif
                        |> fun x -> _v2047 <- Some x
                        let struct (v2062 : int32, v2063 : string) = _v2047.Value
                        struct (v2062, v2063)
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2064 : int32, v2065 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2064, v2065)
#endif
                        #if FABLE_COMPILER_PYTHON
                        let struct (v2066 : int32, v2067 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2066, v2067)
#endif
                        |> fun x -> _v1864 <- Some x
                        let struct (v2068 : int32, v2069 : string) = _v1864.Value
                        let v2070 : US0 = US0_2
                        let v2071 : (unit -> string) = closure55()
                        let v2072 : (unit -> string) = closure56(v2069, v2068)
                        method3(v2070, v2071, v2072)
                        let v2073 : bool = v2068 <> 0
                        let v2076 : bool =
                            if v2073 then
                                true
                            else
                                let v2074 : string = "ERROR"
                                let v2075 : bool = v2069.Contains v2074
                                v2075
                        if v2076 then
                            let v2077 : US9 = US9_1(v1319, v2069)
                            US8_0(v2077)
                        else
                            let v2079 : unit option = None
                            let v2080 : bool = true in let mutable _v2079 = v2079
                            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v2081 : string = method59(v1320)
                            let v2082 : string = "std::fs::copy(&*v1319, &*v2081)"
                            let v2083 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v2082
                            let v2084 : string = "$0.unwrap()"
                            let v2085 : uint64 = Fable.Core.RustInterop.emitRustExpr v2083 v2084
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
                            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                            System.IO.File.Copy (v1319, v1320, true)
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
                            |> fun x -> _v2079 <- Some x
                            _v2079.Value
                            let v2086 : US9 = US9_0(v1319)
                            US8_0(v2086)
                    else
                        US8_1
                let v2091 : string = "pdf"
                let v2092 : string = $"{v511}.{v2091}"
                let v2093 : string = $"{v1044}.{v2091}"
                let v2094 : bool option = None
                let v2095 : bool = true in let mutable _v2094 = v2094
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v2096 : string = method13(v2092)
                let v2097 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                let v2098 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2096 v2097
                let v2099 : string = "String::from($0)"
                let v2100 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2098 v2099
                let v2101 : string = "std::path::PathBuf::from($0)"
                let v2102 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v2100 v2101
                let v2103 : string = "$0.exists()"
                let v2104 : bool = Fable.Core.RustInterop.emitRustExpr v2102 v2103
                let v2107 : bool =
                    if v2104 then
                        let v2105 : string = "$0.is_file()"
                        let v2106 : bool = Fable.Core.RustInterop.emitRustExpr v2102 v2105
                        v2106
                    else
                        false
                v2107
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v2108 : bool = null |> unbox<bool>
                v2108
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v2109 : bool = null |> unbox<bool>
                v2109
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v2110 : (string -> bool) = System.IO.File.Exists
                let v2111 : bool = v2110 v2092
                v2111
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v2112 : IFsExistsSync = Fable.Core.JsInterop.importAll v1063
                let v2113 : string = "v2112.existsSync($0)"
                let v2114 : bool = Fable.Core.JsInterop.emitJsExpr v2092 v2113
                v2114
#endif
                #if FABLE_COMPILER_PYTHON
                let v2115 : bool = null |> unbox<bool>
                v2115
#endif
                |> fun x -> _v2094 <- Some x
                let v2116 : bool = _v2094.Value
                let v2140 : bool =
                    if v2116 then
                        let v2117 : bool option = None
                        let v2118 : bool = true in let mutable _v2117 = v2117
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2119 : string = method13(v2093)
                        let v2120 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                        let v2121 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2119 v2120
                        let v2122 : string = "String::from($0)"
                        let v2123 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2121 v2122
                        let v2124 : string = "std::path::PathBuf::from($0)"
                        let v2125 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v2123 v2124
                        let v2126 : string = "$0.exists()"
                        let v2127 : bool = Fable.Core.RustInterop.emitRustExpr v2125 v2126
                        let v2130 : bool =
                            if v2127 then
                                let v2128 : string = "$0.is_file()"
                                let v2129 : bool = Fable.Core.RustInterop.emitRustExpr v2125 v2128
                                v2129
                            else
                                false
                        v2130
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2131 : bool = null |> unbox<bool>
                        v2131
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2132 : bool = null |> unbox<bool>
                        v2132
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2133 : (string -> bool) = System.IO.File.Exists
                        let v2134 : bool = v2133 v2093
                        v2134
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2135 : IFsExistsSync = Fable.Core.JsInterop.importAll v1063
                        let v2136 : string = "v2135.existsSync($0)"
                        let v2137 : bool = Fable.Core.JsInterop.emitJsExpr v2093 v2136
                        v2137
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2138 : bool = null |> unbox<bool>
                        v2138
#endif
                        |> fun x -> _v2117 <- Some x
                        let v2139 : bool = _v2117.Value
                        v2139
                    else
                        false
                let v2630 : bool =
                    if v2140 then
                        let v2141 : bool option = None
                        let v2142 : bool = true in let mutable _v2141 = v2141
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2143 : string = "cfg!(windows)"
                        let v2144 : bool = Fable.Core.RustInterop.emitRustExpr () v2143
                        v2144
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2145 : bool = null |> unbox<bool>
                        v2145
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2146 : bool = null |> unbox<bool>
                        v2146
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2147 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                        let v2148 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                        let v2149 : bool = v2148 v2147
                        v2149
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2150 : bool = null |> unbox<bool>
                        v2150
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2151 : bool = null |> unbox<bool>
                        v2151
#endif
                        |> fun x -> _v2141 <- Some x
                        let v2152 : bool = _v2141.Value
                        let v2153 : bool = v2152 = false
                        let v2174 : string =
                            if v2153 then
                                v2092
                            else
                                let v2154 : string option = None
                                let v2155 : bool = true in let mutable _v2154 = v2154
                                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v2156 : string = method26()
                                let v2157 : string = method27(v2092)
                                let v2158 : string = method28()
                                let v2159 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                                let v2160 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v2156, v2157, v2158) v2159
                                let v2161 : string = "String::from($0)"
                                let v2162 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2160 v2161
                                let v2163 : string = "fable_library_rust::String_::fromString($0)"
                                let v2164 : string = Fable.Core.RustInterop.emitRustExpr v2162 v2163
                                v2164
#endif
                                #if FABLE_COMPILER_RUST && WASM
                                let v2165 : string = null |> unbox<string>
                                v2165
#endif
                                #if FABLE_COMPILER_RUST && CONTRACT
                                let v2166 : string = null |> unbox<string>
                                v2166
#endif
                                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                                let v2167 : string = "^\\\\\\\\\\?\\\\"
                                let v2168 : string = System.Text.RegularExpressions.Regex.Replace (v2092, v2167, v141)
                                v2168
#endif
                                #if FABLE_COMPILER_TYPESCRIPT
                                let v2169 : string = null |> unbox<string>
                                v2169
#endif
                                #if FABLE_COMPILER_PYTHON
                                let v2170 : string = null |> unbox<string>
                                v2170
#endif
                                |> fun x -> _v2154 <- Some x
                                let v2171 : string = _v2154.Value
                                let v2172 : string = $"{v2171.[0] |> System.Char.ToLower}{v2171.[1..]}"
                                let v2173 : string = v2172.Replace (v143, v144)
                                v2173
                        let v2175 : System.Threading.CancellationToken option = None
                        let v2176 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v2177 : string option = None
                        let v2178 : string = $"pwsh -c \"(Get-FileHash \\\"{v2174}\\\" -Algorithm SHA256).Hash\""
                        let v2179 : struct (int32 * string) option = None
                        let v2180 : bool = true in let mutable _v2179 = v2179
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v2181 : string, v2182 : string) = method29()
                        let v2183 : int32 = v2178.Length
                        let v2184 : (char []) = Array.zeroCreate<char> (v2183)
                        let v2185 : Mut4 = {l0 = 0} : Mut4
                        while method30(v2183, v2185) do
                            let v2187 : int32 = v2185.l0
                            let v2188 : char = v2178.[int v2187]
                            v2184.[int v2187] <- v2188
                            let v2189 : int32 = v2187 + 1
                            v2185.l0 <- v2189
                            ()
                        let v2190 : ((char []) -> char list) = Array.toList
                        let v2191 : char list = v2190 v2184
                        let v2192 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2193 : (char -> (UH0 -> UH0)) = method31()
                        let v2194 : (char list -> (UH0 -> UH0)) = v2192 v2193
                        let v2195 : (UH0 -> UH0) = v2194 v2191
                        let v2196 : UH0 = UH0_0
                        let v2197 : UH0 = v2195 v2196
                        let v2198 : US10 = US10_0
                        let struct (v2199 : string, v2200 : string) = method32(v2182, v2181, v2197, v2198)
                        let v2201 : (string []) = method33(v2200)
                        let v2202 : string = "$0.to_vec()"
                        let v2203 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v2201 v2202
                        let v2204 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v2205 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2203, v255) v2204
                        let v2206 : US0 = US0_1
                        let v2207 : (unit -> string) = closure27(v2175, v2178, v2176, v2177, v2199, v2205)
                        let v2208 : (unit -> string) = method38()
                        method3(v2206, v2207, v2208)
                        let v2209 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method39(v2175, v2178, v2176, v2177, v2199, v2205)
                        let v2210 : string = "futures_lite::future::block_on($0)"
                        let v2211 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v2209 v2210
                        let (a, b) = v2211
                        let v2212 : int32 = a
                        let v2213 : string = b
                        struct (v2212, v2213)
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let struct (v2214 : int32, v2215 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2214, v2215)
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2216 : int32, v2217 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2216, v2217)
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2218 : Async<struct (int32 * string)> option = None
                        let v2219 : bool = true in let mutable _v2218 = v2218
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2220 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2220
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2221 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2221
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2222 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2222
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2223 : Async<struct (int32 * string)> option = None
                        let v2224 : bool = true in let mutable _v2223 = v2223
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2225 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2225
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2226 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2226
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2227 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2227
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2228 : Async<struct (int32 * string)> option = None
                        let mutable _v2228 = v2228
                        async {
                        let struct (v2229 : string, v2230 : string) = method29()
                        let v2231 : (char []) = Array.zeroCreate<char> (v2183)
                        let v2232 : Mut4 = {l0 = 0} : Mut4
                        while method30(v2183, v2232) do
                            let v2234 : int32 = v2232.l0
                            let v2235 : char = v2178.[int v2234]
                            v2231.[int v2234] <- v2235
                            let v2236 : int32 = v2234 + 1
                            v2232.l0 <- v2236
                            ()
                        let v2237 : ((char []) -> char list) = Array.toList
                        let v2238 : char list = v2237 v2231
                        let v2239 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2240 : (char -> (UH0 -> UH0)) = method31()
                        let v2241 : (char list -> (UH0 -> UH0)) = v2239 v2240
                        let v2242 : (UH0 -> UH0) = v2241 v2238
                        let v2243 : UH0 = UH0_0
                        let v2244 : UH0 = v2242 v2243
                        let v2245 : US10 = US10_0
                        let struct (v2246 : string, v2247 : string) = method32(v2230, v2229, v2244, v2245)
                        let v2248 : (string -> US7) = method40()
                        let v2249 : US7 = US7_1
                        let v2250 : US7 = v2177 |> Option.map v2248 |> Option.defaultValue v2249 
                        let v2253 : string =
                            match v2250 with
                            | US7_1 -> (* None *)
                                v141
                            | US7_0(v2251) -> (* Some *)
                                v2251
                        let v2254 : US0 = US0_1
                        let v2255 : (unit -> string) = closure44(v2175, v2178, v2176, v2177)
                        let v2256 : (unit -> string) = method38()
                        method3(v2254, v2255, v2256)
                        let v2257 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v2258 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v2247, StandardOutputEncoding = v2257, WorkingDirectory = v2253, FileName = v2246, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v2259 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v2258)
                        use v2259 = v2259 
                        let v2260 : System.Diagnostics.Process = v2259 
                        let v2261 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v2262 : System.Collections.Concurrent.ConcurrentStack<string> = v2261 ()
                        let v2263 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v2175, v2178, v2176, v2177, v2260, v2262)
                        v2260.OutputDataReceived.Add v2263 
                        let v2264 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v2175, v2178, v2176, v2177, v2260, v2262)
                        v2260.ErrorDataReceived.Add v2264 
                        let v2265 : (unit -> bool) = v2260.Start
                        let v2266 : bool = v2265 ()
                        let v2267 : bool = v2266 = false
                        if v2267 then
                            let v2268 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v2268
                        let v2269 : (unit -> unit) = v2260.BeginErrorReadLine
                        v2269 ()
                        let v2270 : (unit -> unit) = v2260.BeginOutputReadLine
                        v2270 ()
                        let v2271 : (System.Threading.CancellationToken -> US18) = method57()
                        let v2272 : US18 = US18_1
                        let v2273 : US18 = v2175 |> Option.map v2271 |> Option.defaultValue v2272 
                        let v2277 : System.Threading.CancellationToken =
                            match v2273 with
                            | US18_1 -> (* None *)
                                let v2275 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v2275
                            | US18_0(v2274) -> (* Some *)
                                v2274
                        let v2278 : Async<System.Threading.CancellationToken> option = None
                        let v2279 : bool = true in let mutable _v2278 = v2278
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2280 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2280
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2281 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2281
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2282 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2282
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2283 : Async<System.Threading.CancellationToken> option = None
                        let v2284 : bool = true in let mutable _v2283 = v2283
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2285 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2285
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2286 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2286
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2287 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2287
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2288 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v2288 = v2288
                        async {
                        let v2289 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v2289 = v2289 
                        let v2290 : System.Threading.CancellationToken = v2289 
                        let v2291 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v2292 : (System.Threading.CancellationToken []) = [|v2290; v2291; v2277|]
                        let v2293 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v2294 : System.Threading.CancellationTokenSource = v2293 v2292
                        let v2295 : System.Threading.CancellationToken = v2294.Token
                        return v2295 
                        }
                        |> fun x -> _v2288 <- Some x
                        let v2296 : Async<System.Threading.CancellationToken> = _v2288 |> Option.get
                        v2296
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2297 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2297
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2298 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2298
#endif
                        |> fun x -> _v2283 <- Some x
                        let v2299 : Async<System.Threading.CancellationToken> = _v2283.Value
                        v2299
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2300 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2300
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2301 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2301
#endif
                        |> fun x -> _v2278 <- Some x
                        let v2302 : Async<System.Threading.CancellationToken> = _v2278.Value
                        let! v2302 = v2302 
                        let v2303 : System.Threading.CancellationToken = v2302 
                        let v2304 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v2303.Register
                        let v2305 : (unit -> unit) = closure50(v2260)
                        let v2306 : System.Threading.CancellationTokenRegistration = v2304 v2305
                        use v2306 = v2306 
                        let v2307 : System.Threading.CancellationTokenRegistration = v2306 
                        let v2308 : Async<int32> option = None
                        let v2309 : bool = true in let mutable _v2308 = v2308
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2310 : Async<int32> = null |> unbox<Async<int32>>
                        v2310
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2311 : Async<int32> = null |> unbox<Async<int32>>
                        v2311
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2312 : Async<int32> = null |> unbox<Async<int32>>
                        v2312
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2313 : Async<int32> option = None
                        let mutable _v2313 = v2313
                        async {
                        try
                        let v2314 : System.Threading.Tasks.Task = v2260.WaitForExitAsync v2303 
                        let v2315 : Async<unit> option = None
                        let v2316 : bool = true in let mutable _v2315 = v2315
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2317 : Async<unit> = null |> unbox<Async<unit>>
                        v2317
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2318 : Async<unit> = null |> unbox<Async<unit>>
                        v2318
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2319 : Async<unit> = null |> unbox<Async<unit>>
                        v2319
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2320 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v2321 : Async<unit> = v2320 v2314
                        v2321
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2322 : Async<unit> = null |> unbox<Async<unit>>
                        v2322
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2323 : Async<unit> = null |> unbox<Async<unit>>
                        v2323
#endif
                        |> fun x -> _v2315 <- Some x
                        let v2324 : Async<unit> = _v2315.Value
                        do! v2324 
                        let v2325 : int32 = v2260.ExitCode
                        return v2325 
                        with ex ->
                        let v2326 : exn = ex
                        let v2327 : string option = None
                        let v2328 : bool = true in let mutable _v2327 = v2327
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2329 : string = $"%A{v2326}"
                        v2329
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2330 : string = $"%A{v2326}"
                        v2330
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2331 : string = $"%A{v2326}"
                        v2331
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2332 : string = $"{v2326.GetType ()}: {v2326.Message}"
                        v2332
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2333 : string = $"%A{v2326}"
                        v2333
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2334 : string = $"%A{v2326}"
                        v2334
#endif
                        |> fun x -> _v2327 <- Some x
                        let v2335 : string = _v2327.Value
                        let v2336 : (string -> unit) = v2262.Push
                        v2336 v2335
                        let v2337 : System.Threading.Tasks.TaskCanceledException = v2326 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v2338 : US0 = US0_3
                        let v2339 : (unit -> string) = closure51(v2337)
                        let v2340 : (unit -> string) = method38()
                        method3(v2338, v2339, v2340)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v2313 <- Some x
                        let v2341 : Async<int32> = _v2313 |> Option.get
                        v2341
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2342 : Async<int32> = null |> unbox<Async<int32>>
                        v2342
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2343 : Async<int32> = null |> unbox<Async<int32>>
                        v2343
#endif
                        |> fun x -> _v2308 <- Some x
                        let v2344 : Async<int32> = _v2308.Value
                        let! v2344 = v2344 
                        let v2345 : int32 = v2344 
                        let v2346 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v2347 : string seq = v2346 v2262
                        let v2348 : string = method58()
                        let v2349 : (string -> (string seq -> string)) = String.concat
                        let v2350 : (string seq -> string) = v2349 v2348
                        let v2351 : string = v2350 v2347
                        let v2352 : US0 = US0_1
                        let v2353 : (unit -> string) = closure52(v2345, v2351)
                        let v2354 : (unit -> string) = method38()
                        method3(v2352, v2353, v2354)
                        return struct (v2345, v2351) 
                        }
                        |> fun x -> _v2228 <- Some x
                        let v2355 : Async<struct (int32 * string)> = _v2228 |> Option.get
                        v2355
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2356 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2356
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2357 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2357
#endif
                        |> fun x -> _v2223 <- Some x
                        let v2358 : Async<struct (int32 * string)> = _v2223.Value
                        v2358
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2359 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2359
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2360 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2360
#endif
                        |> fun x -> _v2218 <- Some x
                        let v2361 : Async<struct (int32 * string)> = _v2218.Value
                        let v2362 : struct (int32 * string) option = None
                        let v2363 : bool = true in let mutable _v2362 = v2362
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v2364 : int32, v2365 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2364, v2365)
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let struct (v2366 : int32, v2367 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2366, v2367)
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2368 : int32, v2369 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2368, v2369)
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2370 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v2371 : int32, v2372 : string) = v2370 v2361
                        struct (v2371, v2372)
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2373 : int32, v2374 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2373, v2374)
#endif
                        #if FABLE_COMPILER_PYTHON
                        let struct (v2375 : int32, v2376 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2375, v2376)
#endif
                        |> fun x -> _v2362 <- Some x
                        let struct (v2377 : int32, v2378 : string) = _v2362.Value
                        struct (v2377, v2378)
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2379 : int32, v2380 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2379, v2380)
#endif
                        #if FABLE_COMPILER_PYTHON
                        let struct (v2381 : int32, v2382 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2381, v2382)
#endif
                        |> fun x -> _v2179 <- Some x
                        let struct (v2383 : int32, v2384 : string) = _v2179.Value
                        let v2385 : bool option = None
                        let v2386 : bool = true in let mutable _v2385 = v2385
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2387 : string = "cfg!(windows)"
                        let v2388 : bool = Fable.Core.RustInterop.emitRustExpr () v2387
                        v2388
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2389 : bool = null |> unbox<bool>
                        v2389
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2390 : bool = null |> unbox<bool>
                        v2390
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2391 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                        let v2392 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                        let v2393 : bool = v2392 v2391
                        v2393
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2394 : bool = null |> unbox<bool>
                        v2394
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2395 : bool = null |> unbox<bool>
                        v2395
#endif
                        |> fun x -> _v2385 <- Some x
                        let v2396 : bool = _v2385.Value
                        let v2397 : bool = v2396 = false
                        let v2418 : string =
                            if v2397 then
                                v2093
                            else
                                let v2398 : string option = None
                                let v2399 : bool = true in let mutable _v2398 = v2398
                                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v2400 : string = method26()
                                let v2401 : string = method27(v2093)
                                let v2402 : string = method28()
                                let v2403 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                                let v2404 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v2400, v2401, v2402) v2403
                                let v2405 : string = "String::from($0)"
                                let v2406 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2404 v2405
                                let v2407 : string = "fable_library_rust::String_::fromString($0)"
                                let v2408 : string = Fable.Core.RustInterop.emitRustExpr v2406 v2407
                                v2408
#endif
                                #if FABLE_COMPILER_RUST && WASM
                                let v2409 : string = null |> unbox<string>
                                v2409
#endif
                                #if FABLE_COMPILER_RUST && CONTRACT
                                let v2410 : string = null |> unbox<string>
                                v2410
#endif
                                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                                let v2411 : string = "^\\\\\\\\\\?\\\\"
                                let v2412 : string = System.Text.RegularExpressions.Regex.Replace (v2093, v2411, v141)
                                v2412
#endif
                                #if FABLE_COMPILER_TYPESCRIPT
                                let v2413 : string = null |> unbox<string>
                                v2413
#endif
                                #if FABLE_COMPILER_PYTHON
                                let v2414 : string = null |> unbox<string>
                                v2414
#endif
                                |> fun x -> _v2398 <- Some x
                                let v2415 : string = _v2398.Value
                                let v2416 : string = $"{v2415.[0] |> System.Char.ToLower}{v2415.[1..]}"
                                let v2417 : string = v2416.Replace (v143, v144)
                                v2417
                        let v2419 : System.Threading.CancellationToken option = None
                        let v2420 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v2421 : string option = None
                        let v2422 : string = $"pwsh -c \"(Get-FileHash \\\"{v2418}\\\" -Algorithm SHA256).Hash\""
                        let v2423 : struct (int32 * string) option = None
                        let v2424 : bool = true in let mutable _v2423 = v2423
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v2425 : string, v2426 : string) = method29()
                        let v2427 : int32 = v2422.Length
                        let v2428 : (char []) = Array.zeroCreate<char> (v2427)
                        let v2429 : Mut4 = {l0 = 0} : Mut4
                        while method30(v2427, v2429) do
                            let v2431 : int32 = v2429.l0
                            let v2432 : char = v2422.[int v2431]
                            v2428.[int v2431] <- v2432
                            let v2433 : int32 = v2431 + 1
                            v2429.l0 <- v2433
                            ()
                        let v2434 : ((char []) -> char list) = Array.toList
                        let v2435 : char list = v2434 v2428
                        let v2436 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2437 : (char -> (UH0 -> UH0)) = method31()
                        let v2438 : (char list -> (UH0 -> UH0)) = v2436 v2437
                        let v2439 : (UH0 -> UH0) = v2438 v2435
                        let v2440 : UH0 = UH0_0
                        let v2441 : UH0 = v2439 v2440
                        let v2442 : US10 = US10_0
                        let struct (v2443 : string, v2444 : string) = method32(v2426, v2425, v2441, v2442)
                        let v2445 : (string []) = method33(v2444)
                        let v2446 : string = "$0.to_vec()"
                        let v2447 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v2445 v2446
                        let v2448 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v2449 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2447, v255) v2448
                        let v2450 : US0 = US0_1
                        let v2451 : (unit -> string) = closure27(v2419, v2422, v2420, v2421, v2443, v2449)
                        let v2452 : (unit -> string) = method38()
                        method3(v2450, v2451, v2452)
                        let v2453 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method39(v2419, v2422, v2420, v2421, v2443, v2449)
                        let v2454 : string = "futures_lite::future::block_on($0)"
                        let v2455 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v2453 v2454
                        let (a, b) = v2455
                        let v2456 : int32 = a
                        let v2457 : string = b
                        struct (v2456, v2457)
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let struct (v2458 : int32, v2459 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2458, v2459)
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2460 : int32, v2461 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2460, v2461)
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2462 : Async<struct (int32 * string)> option = None
                        let v2463 : bool = true in let mutable _v2462 = v2462
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2464 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2464
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2465 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2465
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2466 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2466
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2467 : Async<struct (int32 * string)> option = None
                        let v2468 : bool = true in let mutable _v2467 = v2467
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2469 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2469
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2470 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2470
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2471 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2471
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2472 : Async<struct (int32 * string)> option = None
                        let mutable _v2472 = v2472
                        async {
                        let struct (v2473 : string, v2474 : string) = method29()
                        let v2475 : (char []) = Array.zeroCreate<char> (v2427)
                        let v2476 : Mut4 = {l0 = 0} : Mut4
                        while method30(v2427, v2476) do
                            let v2478 : int32 = v2476.l0
                            let v2479 : char = v2422.[int v2478]
                            v2475.[int v2478] <- v2479
                            let v2480 : int32 = v2478 + 1
                            v2476.l0 <- v2480
                            ()
                        let v2481 : ((char []) -> char list) = Array.toList
                        let v2482 : char list = v2481 v2475
                        let v2483 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2484 : (char -> (UH0 -> UH0)) = method31()
                        let v2485 : (char list -> (UH0 -> UH0)) = v2483 v2484
                        let v2486 : (UH0 -> UH0) = v2485 v2482
                        let v2487 : UH0 = UH0_0
                        let v2488 : UH0 = v2486 v2487
                        let v2489 : US10 = US10_0
                        let struct (v2490 : string, v2491 : string) = method32(v2474, v2473, v2488, v2489)
                        let v2492 : (string -> US7) = method40()
                        let v2493 : US7 = US7_1
                        let v2494 : US7 = v2421 |> Option.map v2492 |> Option.defaultValue v2493 
                        let v2497 : string =
                            match v2494 with
                            | US7_1 -> (* None *)
                                v141
                            | US7_0(v2495) -> (* Some *)
                                v2495
                        let v2498 : US0 = US0_1
                        let v2499 : (unit -> string) = closure44(v2419, v2422, v2420, v2421)
                        let v2500 : (unit -> string) = method38()
                        method3(v2498, v2499, v2500)
                        let v2501 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v2502 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v2491, StandardOutputEncoding = v2501, WorkingDirectory = v2497, FileName = v2490, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v2503 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v2502)
                        use v2503 = v2503 
                        let v2504 : System.Diagnostics.Process = v2503 
                        let v2505 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v2506 : System.Collections.Concurrent.ConcurrentStack<string> = v2505 ()
                        let v2507 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v2419, v2422, v2420, v2421, v2504, v2506)
                        v2504.OutputDataReceived.Add v2507 
                        let v2508 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v2419, v2422, v2420, v2421, v2504, v2506)
                        v2504.ErrorDataReceived.Add v2508 
                        let v2509 : (unit -> bool) = v2504.Start
                        let v2510 : bool = v2509 ()
                        let v2511 : bool = v2510 = false
                        if v2511 then
                            let v2512 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v2512
                        let v2513 : (unit -> unit) = v2504.BeginErrorReadLine
                        v2513 ()
                        let v2514 : (unit -> unit) = v2504.BeginOutputReadLine
                        v2514 ()
                        let v2515 : (System.Threading.CancellationToken -> US18) = method57()
                        let v2516 : US18 = US18_1
                        let v2517 : US18 = v2419 |> Option.map v2515 |> Option.defaultValue v2516 
                        let v2521 : System.Threading.CancellationToken =
                            match v2517 with
                            | US18_1 -> (* None *)
                                let v2519 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v2519
                            | US18_0(v2518) -> (* Some *)
                                v2518
                        let v2522 : Async<System.Threading.CancellationToken> option = None
                        let v2523 : bool = true in let mutable _v2522 = v2522
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2524 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2524
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2525 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2525
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2526 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2526
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2527 : Async<System.Threading.CancellationToken> option = None
                        let v2528 : bool = true in let mutable _v2527 = v2527
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2529 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2529
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2530 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2530
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2531 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2531
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2532 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v2532 = v2532
                        async {
                        let v2533 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v2533 = v2533 
                        let v2534 : System.Threading.CancellationToken = v2533 
                        let v2535 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v2536 : (System.Threading.CancellationToken []) = [|v2534; v2535; v2521|]
                        let v2537 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v2538 : System.Threading.CancellationTokenSource = v2537 v2536
                        let v2539 : System.Threading.CancellationToken = v2538.Token
                        return v2539 
                        }
                        |> fun x -> _v2532 <- Some x
                        let v2540 : Async<System.Threading.CancellationToken> = _v2532 |> Option.get
                        v2540
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2541 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2541
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2542 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2542
#endif
                        |> fun x -> _v2527 <- Some x
                        let v2543 : Async<System.Threading.CancellationToken> = _v2527.Value
                        v2543
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2544 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2544
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2545 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2545
#endif
                        |> fun x -> _v2522 <- Some x
                        let v2546 : Async<System.Threading.CancellationToken> = _v2522.Value
                        let! v2546 = v2546 
                        let v2547 : System.Threading.CancellationToken = v2546 
                        let v2548 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v2547.Register
                        let v2549 : (unit -> unit) = closure50(v2504)
                        let v2550 : System.Threading.CancellationTokenRegistration = v2548 v2549
                        use v2550 = v2550 
                        let v2551 : System.Threading.CancellationTokenRegistration = v2550 
                        let v2552 : Async<int32> option = None
                        let v2553 : bool = true in let mutable _v2552 = v2552
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2554 : Async<int32> = null |> unbox<Async<int32>>
                        v2554
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2555 : Async<int32> = null |> unbox<Async<int32>>
                        v2555
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2556 : Async<int32> = null |> unbox<Async<int32>>
                        v2556
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2557 : Async<int32> option = None
                        let mutable _v2557 = v2557
                        async {
                        try
                        let v2558 : System.Threading.Tasks.Task = v2504.WaitForExitAsync v2547 
                        let v2559 : Async<unit> option = None
                        let v2560 : bool = true in let mutable _v2559 = v2559
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2561 : Async<unit> = null |> unbox<Async<unit>>
                        v2561
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2562 : Async<unit> = null |> unbox<Async<unit>>
                        v2562
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2563 : Async<unit> = null |> unbox<Async<unit>>
                        v2563
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2564 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v2565 : Async<unit> = v2564 v2558
                        v2565
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2566 : Async<unit> = null |> unbox<Async<unit>>
                        v2566
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2567 : Async<unit> = null |> unbox<Async<unit>>
                        v2567
#endif
                        |> fun x -> _v2559 <- Some x
                        let v2568 : Async<unit> = _v2559.Value
                        do! v2568 
                        let v2569 : int32 = v2504.ExitCode
                        return v2569 
                        with ex ->
                        let v2570 : exn = ex
                        let v2571 : string option = None
                        let v2572 : bool = true in let mutable _v2571 = v2571
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2573 : string = $"%A{v2570}"
                        v2573
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2574 : string = $"%A{v2570}"
                        v2574
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2575 : string = $"%A{v2570}"
                        v2575
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2576 : string = $"{v2570.GetType ()}: {v2570.Message}"
                        v2576
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2577 : string = $"%A{v2570}"
                        v2577
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2578 : string = $"%A{v2570}"
                        v2578
#endif
                        |> fun x -> _v2571 <- Some x
                        let v2579 : string = _v2571.Value
                        let v2580 : (string -> unit) = v2506.Push
                        v2580 v2579
                        let v2581 : System.Threading.Tasks.TaskCanceledException = v2570 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v2582 : US0 = US0_3
                        let v2583 : (unit -> string) = closure51(v2581)
                        let v2584 : (unit -> string) = method38()
                        method3(v2582, v2583, v2584)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v2557 <- Some x
                        let v2585 : Async<int32> = _v2557 |> Option.get
                        v2585
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2586 : Async<int32> = null |> unbox<Async<int32>>
                        v2586
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2587 : Async<int32> = null |> unbox<Async<int32>>
                        v2587
#endif
                        |> fun x -> _v2552 <- Some x
                        let v2588 : Async<int32> = _v2552.Value
                        let! v2588 = v2588 
                        let v2589 : int32 = v2588 
                        let v2590 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v2591 : string seq = v2590 v2506
                        let v2592 : string = method58()
                        let v2593 : (string -> (string seq -> string)) = String.concat
                        let v2594 : (string seq -> string) = v2593 v2592
                        let v2595 : string = v2594 v2591
                        let v2596 : US0 = US0_1
                        let v2597 : (unit -> string) = closure52(v2589, v2595)
                        let v2598 : (unit -> string) = method38()
                        method3(v2596, v2597, v2598)
                        return struct (v2589, v2595) 
                        }
                        |> fun x -> _v2472 <- Some x
                        let v2599 : Async<struct (int32 * string)> = _v2472 |> Option.get
                        v2599
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2600 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2600
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2601 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2601
#endif
                        |> fun x -> _v2467 <- Some x
                        let v2602 : Async<struct (int32 * string)> = _v2467.Value
                        v2602
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2603 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2603
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2604 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2604
#endif
                        |> fun x -> _v2462 <- Some x
                        let v2605 : Async<struct (int32 * string)> = _v2462.Value
                        let v2606 : struct (int32 * string) option = None
                        let v2607 : bool = true in let mutable _v2606 = v2606
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v2608 : int32, v2609 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2608, v2609)
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let struct (v2610 : int32, v2611 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2610, v2611)
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2612 : int32, v2613 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2612, v2613)
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2614 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v2615 : int32, v2616 : string) = v2614 v2605
                        struct (v2615, v2616)
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2617 : int32, v2618 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2617, v2618)
#endif
                        #if FABLE_COMPILER_PYTHON
                        let struct (v2619 : int32, v2620 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2619, v2620)
#endif
                        |> fun x -> _v2606 <- Some x
                        let struct (v2621 : int32, v2622 : string) = _v2606.Value
                        struct (v2621, v2622)
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2623 : int32, v2624 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2623, v2624)
#endif
                        #if FABLE_COMPILER_PYTHON
                        let struct (v2625 : int32, v2626 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2625, v2626)
#endif
                        |> fun x -> _v2423 <- Some x
                        let struct (v2627 : int32, v2628 : string) = _v2423.Value
                        let v2629 : bool = v2384 = v2628
                        v2629
                    else
                        false
                let v2631 : bool = v2630 = false
                let v2863 : US8 =
                    if v2631 then
                        let v2632 : string = $"crowbook --single \"{v511}\" --output \"{v2092}\" --to {v2091} --set rendering.num_depth 6 html.css.add \\\"''' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} '''\\\""
                        let v2633 : System.Threading.CancellationToken option = None
                        let v2634 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v2635 : string option = None
                        let v2636 : string option = Some v1 
                        let v2637 : struct (int32 * string) option = None
                        let v2638 : bool = true in let mutable _v2637 = v2637
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v2639 : string, v2640 : string) = method29()
                        let v2641 : int32 = v2632.Length
                        let v2642 : (char []) = Array.zeroCreate<char> (v2641)
                        let v2643 : Mut4 = {l0 = 0} : Mut4
                        while method30(v2641, v2643) do
                            let v2645 : int32 = v2643.l0
                            let v2646 : char = v2632.[int v2645]
                            v2642.[int v2645] <- v2646
                            let v2647 : int32 = v2645 + 1
                            v2643.l0 <- v2647
                            ()
                        let v2648 : ((char []) -> char list) = Array.toList
                        let v2649 : char list = v2648 v2642
                        let v2650 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2651 : (char -> (UH0 -> UH0)) = method31()
                        let v2652 : (char list -> (UH0 -> UH0)) = v2650 v2651
                        let v2653 : (UH0 -> UH0) = v2652 v2649
                        let v2654 : UH0 = UH0_0
                        let v2655 : UH0 = v2653 v2654
                        let v2656 : US10 = US10_0
                        let struct (v2657 : string, v2658 : string) = method32(v2640, v2639, v2655, v2656)
                        let v2659 : (string []) = method33(v2658)
                        let v2660 : string = "$0.to_vec()"
                        let v2661 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v2659 v2660
                        let v2662 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v2663 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2661, v255) v2662
                        let v2664 : US0 = US0_1
                        let v2665 : (unit -> string) = closure27(v2633, v2632, v2634, v2636, v2657, v2663)
                        let v2666 : (unit -> string) = method38()
                        method3(v2664, v2665, v2666)
                        let v2667 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method39(v2633, v2632, v2634, v2636, v2657, v2663)
                        let v2668 : string = "futures_lite::future::block_on($0)"
                        let v2669 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v2667 v2668
                        let (a, b) = v2669
                        let v2670 : int32 = a
                        let v2671 : string = b
                        struct (v2670, v2671)
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let struct (v2672 : int32, v2673 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2672, v2673)
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2674 : int32, v2675 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2674, v2675)
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2676 : Async<struct (int32 * string)> option = None
                        let v2677 : bool = true in let mutable _v2676 = v2676
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2678 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2678
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2679 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2679
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2680 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2680
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2681 : Async<struct (int32 * string)> option = None
                        let v2682 : bool = true in let mutable _v2681 = v2681
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2683 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2683
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2684 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2684
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2685 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2685
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2686 : Async<struct (int32 * string)> option = None
                        let mutable _v2686 = v2686
                        async {
                        let struct (v2687 : string, v2688 : string) = method29()
                        let v2689 : (char []) = Array.zeroCreate<char> (v2641)
                        let v2690 : Mut4 = {l0 = 0} : Mut4
                        while method30(v2641, v2690) do
                            let v2692 : int32 = v2690.l0
                            let v2693 : char = v2632.[int v2692]
                            v2689.[int v2692] <- v2693
                            let v2694 : int32 = v2692 + 1
                            v2690.l0 <- v2694
                            ()
                        let v2695 : ((char []) -> char list) = Array.toList
                        let v2696 : char list = v2695 v2689
                        let v2697 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2698 : (char -> (UH0 -> UH0)) = method31()
                        let v2699 : (char list -> (UH0 -> UH0)) = v2697 v2698
                        let v2700 : (UH0 -> UH0) = v2699 v2696
                        let v2701 : UH0 = UH0_0
                        let v2702 : UH0 = v2700 v2701
                        let v2703 : US10 = US10_0
                        let struct (v2704 : string, v2705 : string) = method32(v2688, v2687, v2702, v2703)
                        let v2706 : (string -> US7) = method40()
                        let v2707 : US7 = US7_1
                        let v2708 : US7 = v2636 |> Option.map v2706 |> Option.defaultValue v2707 
                        let v2711 : string =
                            match v2708 with
                            | US7_1 -> (* None *)
                                v141
                            | US7_0(v2709) -> (* Some *)
                                v2709
                        let v2712 : US0 = US0_1
                        let v2713 : (unit -> string) = closure44(v2633, v2632, v2634, v2636)
                        let v2714 : (unit -> string) = method38()
                        method3(v2712, v2713, v2714)
                        let v2715 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v2716 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v2705, StandardOutputEncoding = v2715, WorkingDirectory = v2711, FileName = v2704, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v2717 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v2716)
                        use v2717 = v2717 
                        let v2718 : System.Diagnostics.Process = v2717 
                        let v2719 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v2720 : System.Collections.Concurrent.ConcurrentStack<string> = v2719 ()
                        let v2721 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v2633, v2632, v2634, v2636, v2718, v2720)
                        v2718.OutputDataReceived.Add v2721 
                        let v2722 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v2633, v2632, v2634, v2636, v2718, v2720)
                        v2718.ErrorDataReceived.Add v2722 
                        let v2723 : (unit -> bool) = v2718.Start
                        let v2724 : bool = v2723 ()
                        let v2725 : bool = v2724 = false
                        if v2725 then
                            let v2726 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v2726
                        let v2727 : (unit -> unit) = v2718.BeginErrorReadLine
                        v2727 ()
                        let v2728 : (unit -> unit) = v2718.BeginOutputReadLine
                        v2728 ()
                        let v2729 : (System.Threading.CancellationToken -> US18) = method57()
                        let v2730 : US18 = US18_1
                        let v2731 : US18 = v2633 |> Option.map v2729 |> Option.defaultValue v2730 
                        let v2735 : System.Threading.CancellationToken =
                            match v2731 with
                            | US18_1 -> (* None *)
                                let v2733 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v2733
                            | US18_0(v2732) -> (* Some *)
                                v2732
                        let v2736 : Async<System.Threading.CancellationToken> option = None
                        let v2737 : bool = true in let mutable _v2736 = v2736
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2738 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2738
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2739 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2739
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2740 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2740
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2741 : Async<System.Threading.CancellationToken> option = None
                        let v2742 : bool = true in let mutable _v2741 = v2741
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2743 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2743
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2744 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2744
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2745 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2745
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2746 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v2746 = v2746
                        async {
                        let v2747 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v2747 = v2747 
                        let v2748 : System.Threading.CancellationToken = v2747 
                        let v2749 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v2750 : (System.Threading.CancellationToken []) = [|v2748; v2749; v2735|]
                        let v2751 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v2752 : System.Threading.CancellationTokenSource = v2751 v2750
                        let v2753 : System.Threading.CancellationToken = v2752.Token
                        return v2753 
                        }
                        |> fun x -> _v2746 <- Some x
                        let v2754 : Async<System.Threading.CancellationToken> = _v2746 |> Option.get
                        v2754
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2755 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2755
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2756 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2756
#endif
                        |> fun x -> _v2741 <- Some x
                        let v2757 : Async<System.Threading.CancellationToken> = _v2741.Value
                        v2757
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2758 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2758
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2759 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v2759
#endif
                        |> fun x -> _v2736 <- Some x
                        let v2760 : Async<System.Threading.CancellationToken> = _v2736.Value
                        let! v2760 = v2760 
                        let v2761 : System.Threading.CancellationToken = v2760 
                        let v2762 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v2761.Register
                        let v2763 : (unit -> unit) = closure50(v2718)
                        let v2764 : System.Threading.CancellationTokenRegistration = v2762 v2763
                        use v2764 = v2764 
                        let v2765 : System.Threading.CancellationTokenRegistration = v2764 
                        let v2766 : Async<int32> option = None
                        let v2767 : bool = true in let mutable _v2766 = v2766
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2768 : Async<int32> = null |> unbox<Async<int32>>
                        v2768
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2769 : Async<int32> = null |> unbox<Async<int32>>
                        v2769
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2770 : Async<int32> = null |> unbox<Async<int32>>
                        v2770
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2771 : Async<int32> option = None
                        let mutable _v2771 = v2771
                        async {
                        try
                        let v2772 : System.Threading.Tasks.Task = v2718.WaitForExitAsync v2761 
                        let v2773 : Async<unit> option = None
                        let v2774 : bool = true in let mutable _v2773 = v2773
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2775 : Async<unit> = null |> unbox<Async<unit>>
                        v2775
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2776 : Async<unit> = null |> unbox<Async<unit>>
                        v2776
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2777 : Async<unit> = null |> unbox<Async<unit>>
                        v2777
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2778 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v2779 : Async<unit> = v2778 v2772
                        v2779
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2780 : Async<unit> = null |> unbox<Async<unit>>
                        v2780
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2781 : Async<unit> = null |> unbox<Async<unit>>
                        v2781
#endif
                        |> fun x -> _v2773 <- Some x
                        let v2782 : Async<unit> = _v2773.Value
                        do! v2782 
                        let v2783 : int32 = v2718.ExitCode
                        return v2783 
                        with ex ->
                        let v2784 : exn = ex
                        let v2785 : string option = None
                        let v2786 : bool = true in let mutable _v2785 = v2785
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2787 : string = $"%A{v2784}"
                        v2787
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2788 : string = $"%A{v2784}"
                        v2788
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2789 : string = $"%A{v2784}"
                        v2789
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2790 : string = $"{v2784.GetType ()}: {v2784.Message}"
                        v2790
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2791 : string = $"%A{v2784}"
                        v2791
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2792 : string = $"%A{v2784}"
                        v2792
#endif
                        |> fun x -> _v2785 <- Some x
                        let v2793 : string = _v2785.Value
                        let v2794 : (string -> unit) = v2720.Push
                        v2794 v2793
                        let v2795 : System.Threading.Tasks.TaskCanceledException = v2784 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v2796 : US0 = US0_3
                        let v2797 : (unit -> string) = closure51(v2795)
                        let v2798 : (unit -> string) = method38()
                        method3(v2796, v2797, v2798)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v2771 <- Some x
                        let v2799 : Async<int32> = _v2771 |> Option.get
                        v2799
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2800 : Async<int32> = null |> unbox<Async<int32>>
                        v2800
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2801 : Async<int32> = null |> unbox<Async<int32>>
                        v2801
#endif
                        |> fun x -> _v2766 <- Some x
                        let v2802 : Async<int32> = _v2766.Value
                        let! v2802 = v2802 
                        let v2803 : int32 = v2802 
                        let v2804 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v2805 : string seq = v2804 v2720
                        let v2806 : string = method58()
                        let v2807 : (string -> (string seq -> string)) = String.concat
                        let v2808 : (string seq -> string) = v2807 v2806
                        let v2809 : string = v2808 v2805
                        let v2810 : US0 = US0_1
                        let v2811 : (unit -> string) = closure52(v2803, v2809)
                        let v2812 : (unit -> string) = method38()
                        method3(v2810, v2811, v2812)
                        return struct (v2803, v2809) 
                        }
                        |> fun x -> _v2686 <- Some x
                        let v2813 : Async<struct (int32 * string)> = _v2686 |> Option.get
                        v2813
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2814 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2814
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2815 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2815
#endif
                        |> fun x -> _v2681 <- Some x
                        let v2816 : Async<struct (int32 * string)> = _v2681.Value
                        v2816
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2817 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2817
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2818 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2818
#endif
                        |> fun x -> _v2676 <- Some x
                        let v2819 : Async<struct (int32 * string)> = _v2676.Value
                        let v2820 : struct (int32 * string) option = None
                        let v2821 : bool = true in let mutable _v2820 = v2820
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v2822 : int32, v2823 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2822, v2823)
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let struct (v2824 : int32, v2825 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2824, v2825)
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2826 : int32, v2827 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2826, v2827)
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2828 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v2829 : int32, v2830 : string) = v2828 v2819
                        struct (v2829, v2830)
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let struct (v2831 : int32, v2832 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2831, v2832)
#endif
                        #if FABLE_COMPILER_PYTHON
                        let struct (v2833 : int32, v2834 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2833, v2834)
#endif
                        |> fun x -> _v2820 <- Some x
                        let struct (v2835 : int32, v2836 : string) = _v2820.Value
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
                        |> fun x -> _v2637 <- Some x
                        let struct (v2841 : int32, v2842 : string) = _v2637.Value
                        let v2843 : US0 = US0_2
                        let v2844 : (unit -> string) = closure55()
                        let v2845 : (unit -> string) = closure56(v2842, v2841)
                        method3(v2843, v2844, v2845)
                        let v2846 : bool = v2841 <> 0
                        let v2849 : bool =
                            if v2846 then
                                true
                            else
                                let v2847 : string = "ERROR"
                                let v2848 : bool = v2842.Contains v2847
                                v2848
                        if v2849 then
                            let v2850 : US9 = US9_1(v2092, v2842)
                            US8_0(v2850)
                        else
                            let v2852 : unit option = None
                            let v2853 : bool = true in let mutable _v2852 = v2852
                            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v2854 : string = method59(v2093)
                            let v2855 : string = "std::fs::copy(&*v2092, &*v2854)"
                            let v2856 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v2855
                            let v2857 : string = "$0.unwrap()"
                            let v2858 : uint64 = Fable.Core.RustInterop.emitRustExpr v2856 v2857
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
                            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                            System.IO.File.Copy (v2092, v2093, true)
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
                            |> fun x -> _v2852 <- Some x
                            _v2852.Value
                            let v2859 : US9 = US9_0(v2092)
                            US8_0(v2859)
                    else
                        US8_1
                let v2864 : string = "html"
                let v2865 : string = $"{v511}.{v2864}"
                let v2866 : string = $"{v1044}.{v2864}"
                let v2867 : bool option = None
                let v2868 : bool = true in let mutable _v2867 = v2867
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v2869 : string = method13(v2865)
                let v2870 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                let v2871 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2869 v2870
                let v2872 : string = "String::from($0)"
                let v2873 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2871 v2872
                let v2874 : string = "std::path::PathBuf::from($0)"
                let v2875 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v2873 v2874
                let v2876 : string = "$0.exists()"
                let v2877 : bool = Fable.Core.RustInterop.emitRustExpr v2875 v2876
                let v2880 : bool =
                    if v2877 then
                        let v2878 : string = "$0.is_file()"
                        let v2879 : bool = Fable.Core.RustInterop.emitRustExpr v2875 v2878
                        v2879
                    else
                        false
                v2880
#endif
                #if FABLE_COMPILER_RUST && WASM
                let v2881 : bool = null |> unbox<bool>
                v2881
#endif
                #if FABLE_COMPILER_RUST && CONTRACT
                let v2882 : bool = null |> unbox<bool>
                v2882
#endif
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                let v2883 : (string -> bool) = System.IO.File.Exists
                let v2884 : bool = v2883 v2865
                v2884
#endif
                #if FABLE_COMPILER_TYPESCRIPT
                let v2885 : IFsExistsSync = Fable.Core.JsInterop.importAll v1063
                let v2886 : string = "v2885.existsSync($0)"
                let v2887 : bool = Fable.Core.JsInterop.emitJsExpr v2865 v2886
                v2887
#endif
                #if FABLE_COMPILER_PYTHON
                let v2888 : bool = null |> unbox<bool>
                v2888
#endif
                |> fun x -> _v2867 <- Some x
                let v2889 : bool = _v2867.Value
                let v2913 : bool =
                    if v2889 then
                        let v2890 : bool option = None
                        let v2891 : bool = true in let mutable _v2890 = v2890
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2892 : string = method13(v2866)
                        let v2893 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
                        let v2894 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2892 v2893
                        let v2895 : string = "String::from($0)"
                        let v2896 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2894 v2895
                        let v2897 : string = "std::path::PathBuf::from($0)"
                        let v2898 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v2896 v2897
                        let v2899 : string = "$0.exists()"
                        let v2900 : bool = Fable.Core.RustInterop.emitRustExpr v2898 v2899
                        let v2903 : bool =
                            if v2900 then
                                let v2901 : string = "$0.is_file()"
                                let v2902 : bool = Fable.Core.RustInterop.emitRustExpr v2898 v2901
                                v2902
                            else
                                false
                        v2903
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2904 : bool = null |> unbox<bool>
                        v2904
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2905 : bool = null |> unbox<bool>
                        v2905
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2906 : (string -> bool) = System.IO.File.Exists
                        let v2907 : bool = v2906 v2866
                        v2907
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2908 : IFsExistsSync = Fable.Core.JsInterop.importAll v1063
                        let v2909 : string = "v2908.existsSync($0)"
                        let v2910 : bool = Fable.Core.JsInterop.emitJsExpr v2866 v2909
                        v2910
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2911 : bool = null |> unbox<bool>
                        v2911
#endif
                        |> fun x -> _v2890 <- Some x
                        let v2912 : bool = _v2890.Value
                        v2912
                    else
                        false
                let v3403 : bool =
                    if v2913 then
                        let v2914 : bool option = None
                        let v2915 : bool = true in let mutable _v2914 = v2914
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2916 : string = "cfg!(windows)"
                        let v2917 : bool = Fable.Core.RustInterop.emitRustExpr () v2916
                        v2917
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2918 : bool = null |> unbox<bool>
                        v2918
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2919 : bool = null |> unbox<bool>
                        v2919
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2920 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                        let v2921 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                        let v2922 : bool = v2921 v2920
                        v2922
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v2923 : bool = null |> unbox<bool>
                        v2923
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v2924 : bool = null |> unbox<bool>
                        v2924
#endif
                        |> fun x -> _v2914 <- Some x
                        let v2925 : bool = _v2914.Value
                        let v2926 : bool = v2925 = false
                        let v2947 : string =
                            if v2926 then
                                v2865
                            else
                                let v2927 : string option = None
                                let v2928 : bool = true in let mutable _v2927 = v2927
                                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v2929 : string = method26()
                                let v2930 : string = method27(v2865)
                                let v2931 : string = method28()
                                let v2932 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                                let v2933 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v2929, v2930, v2931) v2932
                                let v2934 : string = "String::from($0)"
                                let v2935 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2933 v2934
                                let v2936 : string = "fable_library_rust::String_::fromString($0)"
                                let v2937 : string = Fable.Core.RustInterop.emitRustExpr v2935 v2936
                                v2937
#endif
                                #if FABLE_COMPILER_RUST && WASM
                                let v2938 : string = null |> unbox<string>
                                v2938
#endif
                                #if FABLE_COMPILER_RUST && CONTRACT
                                let v2939 : string = null |> unbox<string>
                                v2939
#endif
                                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                                let v2940 : string = "^\\\\\\\\\\?\\\\"
                                let v2941 : string = System.Text.RegularExpressions.Regex.Replace (v2865, v2940, v141)
                                v2941
#endif
                                #if FABLE_COMPILER_TYPESCRIPT
                                let v2942 : string = null |> unbox<string>
                                v2942
#endif
                                #if FABLE_COMPILER_PYTHON
                                let v2943 : string = null |> unbox<string>
                                v2943
#endif
                                |> fun x -> _v2927 <- Some x
                                let v2944 : string = _v2927.Value
                                let v2945 : string = $"{v2944.[0] |> System.Char.ToLower}{v2944.[1..]}"
                                let v2946 : string = v2945.Replace (v143, v144)
                                v2946
                        let v2948 : System.Threading.CancellationToken option = None
                        let v2949 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v2950 : string option = None
                        let v2951 : string = $"pwsh -c \"(Get-FileHash \\\"{v2947}\\\" -Algorithm SHA256).Hash\""
                        let v2952 : struct (int32 * string) option = None
                        let v2953 : bool = true in let mutable _v2952 = v2952
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v2954 : string, v2955 : string) = method29()
                        let v2956 : int32 = v2951.Length
                        let v2957 : (char []) = Array.zeroCreate<char> (v2956)
                        let v2958 : Mut4 = {l0 = 0} : Mut4
                        while method30(v2956, v2958) do
                            let v2960 : int32 = v2958.l0
                            let v2961 : char = v2951.[int v2960]
                            v2957.[int v2960] <- v2961
                            let v2962 : int32 = v2960 + 1
                            v2958.l0 <- v2962
                            ()
                        let v2963 : ((char []) -> char list) = Array.toList
                        let v2964 : char list = v2963 v2957
                        let v2965 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v2966 : (char -> (UH0 -> UH0)) = method31()
                        let v2967 : (char list -> (UH0 -> UH0)) = v2965 v2966
                        let v2968 : (UH0 -> UH0) = v2967 v2964
                        let v2969 : UH0 = UH0_0
                        let v2970 : UH0 = v2968 v2969
                        let v2971 : US10 = US10_0
                        let struct (v2972 : string, v2973 : string) = method32(v2955, v2954, v2970, v2971)
                        let v2974 : (string []) = method33(v2973)
                        let v2975 : string = "$0.to_vec()"
                        let v2976 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v2974 v2975
                        let v2977 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v2978 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2976, v255) v2977
                        let v2979 : US0 = US0_1
                        let v2980 : (unit -> string) = closure27(v2948, v2951, v2949, v2950, v2972, v2978)
                        let v2981 : (unit -> string) = method38()
                        method3(v2979, v2980, v2981)
                        let v2982 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method39(v2948, v2951, v2949, v2950, v2972, v2978)
                        let v2983 : string = "futures_lite::future::block_on($0)"
                        let v2984 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v2982 v2983
                        let (a, b) = v2984
                        let v2985 : int32 = a
                        let v2986 : string = b
                        struct (v2985, v2986)
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let struct (v2987 : int32, v2988 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2987, v2988)
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v2989 : int32, v2990 : string) = null |> unbox<struct (int32 * string)>
                        struct (v2989, v2990)
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2991 : Async<struct (int32 * string)> option = None
                        let v2992 : bool = true in let mutable _v2991 = v2991
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2993 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2993
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2994 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2994
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v2995 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2995
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v2996 : Async<struct (int32 * string)> option = None
                        let v2997 : bool = true in let mutable _v2996 = v2996
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2998 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2998
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v2999 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v2999
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v3000 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3000
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3001 : Async<struct (int32 * string)> option = None
                        let mutable _v3001 = v3001
                        async {
                        let struct (v3002 : string, v3003 : string) = method29()
                        let v3004 : (char []) = Array.zeroCreate<char> (v2956)
                        let v3005 : Mut4 = {l0 = 0} : Mut4
                        while method30(v2956, v3005) do
                            let v3007 : int32 = v3005.l0
                            let v3008 : char = v2951.[int v3007]
                            v3004.[int v3007] <- v3008
                            let v3009 : int32 = v3007 + 1
                            v3005.l0 <- v3009
                            ()
                        let v3010 : ((char []) -> char list) = Array.toList
                        let v3011 : char list = v3010 v3004
                        let v3012 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v3013 : (char -> (UH0 -> UH0)) = method31()
                        let v3014 : (char list -> (UH0 -> UH0)) = v3012 v3013
                        let v3015 : (UH0 -> UH0) = v3014 v3011
                        let v3016 : UH0 = UH0_0
                        let v3017 : UH0 = v3015 v3016
                        let v3018 : US10 = US10_0
                        let struct (v3019 : string, v3020 : string) = method32(v3003, v3002, v3017, v3018)
                        let v3021 : (string -> US7) = method40()
                        let v3022 : US7 = US7_1
                        let v3023 : US7 = v2950 |> Option.map v3021 |> Option.defaultValue v3022 
                        let v3026 : string =
                            match v3023 with
                            | US7_1 -> (* None *)
                                v141
                            | US7_0(v3024) -> (* Some *)
                                v3024
                        let v3027 : US0 = US0_1
                        let v3028 : (unit -> string) = closure44(v2948, v2951, v2949, v2950)
                        let v3029 : (unit -> string) = method38()
                        method3(v3027, v3028, v3029)
                        let v3030 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v3031 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v3020, StandardOutputEncoding = v3030, WorkingDirectory = v3026, FileName = v3019, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v3032 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v3031)
                        use v3032 = v3032 
                        let v3033 : System.Diagnostics.Process = v3032 
                        let v3034 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v3035 : System.Collections.Concurrent.ConcurrentStack<string> = v3034 ()
                        let v3036 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v2948, v2951, v2949, v2950, v3033, v3035)
                        v3033.OutputDataReceived.Add v3036 
                        let v3037 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v2948, v2951, v2949, v2950, v3033, v3035)
                        v3033.ErrorDataReceived.Add v3037 
                        let v3038 : (unit -> bool) = v3033.Start
                        let v3039 : bool = v3038 ()
                        let v3040 : bool = v3039 = false
                        if v3040 then
                            let v3041 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v3041
                        let v3042 : (unit -> unit) = v3033.BeginErrorReadLine
                        v3042 ()
                        let v3043 : (unit -> unit) = v3033.BeginOutputReadLine
                        v3043 ()
                        let v3044 : (System.Threading.CancellationToken -> US18) = method57()
                        let v3045 : US18 = US18_1
                        let v3046 : US18 = v2948 |> Option.map v3044 |> Option.defaultValue v3045 
                        let v3050 : System.Threading.CancellationToken =
                            match v3046 with
                            | US18_1 -> (* None *)
                                let v3048 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v3048
                            | US18_0(v3047) -> (* Some *)
                                v3047
                        let v3051 : Async<System.Threading.CancellationToken> option = None
                        let v3052 : bool = true in let mutable _v3051 = v3051
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3053 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3053
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v3054 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3054
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v3055 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3055
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3056 : Async<System.Threading.CancellationToken> option = None
                        let v3057 : bool = true in let mutable _v3056 = v3056
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3058 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3058
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v3059 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3059
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v3060 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3060
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3061 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v3061 = v3061
                        async {
                        let v3062 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v3062 = v3062 
                        let v3063 : System.Threading.CancellationToken = v3062 
                        let v3064 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v3065 : (System.Threading.CancellationToken []) = [|v3063; v3064; v3050|]
                        let v3066 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v3067 : System.Threading.CancellationTokenSource = v3066 v3065
                        let v3068 : System.Threading.CancellationToken = v3067.Token
                        return v3068 
                        }
                        |> fun x -> _v3061 <- Some x
                        let v3069 : Async<System.Threading.CancellationToken> = _v3061 |> Option.get
                        v3069
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3070 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3070
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3071 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3071
#endif
                        |> fun x -> _v3056 <- Some x
                        let v3072 : Async<System.Threading.CancellationToken> = _v3056.Value
                        v3072
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3073 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3073
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3074 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3074
#endif
                        |> fun x -> _v3051 <- Some x
                        let v3075 : Async<System.Threading.CancellationToken> = _v3051.Value
                        let! v3075 = v3075 
                        let v3076 : System.Threading.CancellationToken = v3075 
                        let v3077 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v3076.Register
                        let v3078 : (unit -> unit) = closure50(v3033)
                        let v3079 : System.Threading.CancellationTokenRegistration = v3077 v3078
                        use v3079 = v3079 
                        let v3080 : System.Threading.CancellationTokenRegistration = v3079 
                        let v3081 : Async<int32> option = None
                        let v3082 : bool = true in let mutable _v3081 = v3081
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3083 : Async<int32> = null |> unbox<Async<int32>>
                        v3083
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v3084 : Async<int32> = null |> unbox<Async<int32>>
                        v3084
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v3085 : Async<int32> = null |> unbox<Async<int32>>
                        v3085
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3086 : Async<int32> option = None
                        let mutable _v3086 = v3086
                        async {
                        try
                        let v3087 : System.Threading.Tasks.Task = v3033.WaitForExitAsync v3076 
                        let v3088 : Async<unit> option = None
                        let v3089 : bool = true in let mutable _v3088 = v3088
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3090 : Async<unit> = null |> unbox<Async<unit>>
                        v3090
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v3091 : Async<unit> = null |> unbox<Async<unit>>
                        v3091
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v3092 : Async<unit> = null |> unbox<Async<unit>>
                        v3092
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3093 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v3094 : Async<unit> = v3093 v3087
                        v3094
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3095 : Async<unit> = null |> unbox<Async<unit>>
                        v3095
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3096 : Async<unit> = null |> unbox<Async<unit>>
                        v3096
#endif
                        |> fun x -> _v3088 <- Some x
                        let v3097 : Async<unit> = _v3088.Value
                        do! v3097 
                        let v3098 : int32 = v3033.ExitCode
                        return v3098 
                        with ex ->
                        let v3099 : exn = ex
                        let v3100 : string option = None
                        let v3101 : bool = true in let mutable _v3100 = v3100
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3102 : string = $"%A{v3099}"
                        v3102
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v3103 : string = $"%A{v3099}"
                        v3103
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v3104 : string = $"%A{v3099}"
                        v3104
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3105 : string = $"{v3099.GetType ()}: {v3099.Message}"
                        v3105
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3106 : string = $"%A{v3099}"
                        v3106
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3107 : string = $"%A{v3099}"
                        v3107
#endif
                        |> fun x -> _v3100 <- Some x
                        let v3108 : string = _v3100.Value
                        let v3109 : (string -> unit) = v3035.Push
                        v3109 v3108
                        let v3110 : System.Threading.Tasks.TaskCanceledException = v3099 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v3111 : US0 = US0_3
                        let v3112 : (unit -> string) = closure51(v3110)
                        let v3113 : (unit -> string) = method38()
                        method3(v3111, v3112, v3113)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v3086 <- Some x
                        let v3114 : Async<int32> = _v3086 |> Option.get
                        v3114
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3115 : Async<int32> = null |> unbox<Async<int32>>
                        v3115
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3116 : Async<int32> = null |> unbox<Async<int32>>
                        v3116
#endif
                        |> fun x -> _v3081 <- Some x
                        let v3117 : Async<int32> = _v3081.Value
                        let! v3117 = v3117 
                        let v3118 : int32 = v3117 
                        let v3119 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v3120 : string seq = v3119 v3035
                        let v3121 : string = method58()
                        let v3122 : (string -> (string seq -> string)) = String.concat
                        let v3123 : (string seq -> string) = v3122 v3121
                        let v3124 : string = v3123 v3120
                        let v3125 : US0 = US0_1
                        let v3126 : (unit -> string) = closure52(v3118, v3124)
                        let v3127 : (unit -> string) = method38()
                        method3(v3125, v3126, v3127)
                        return struct (v3118, v3124) 
                        }
                        |> fun x -> _v3001 <- Some x
                        let v3128 : Async<struct (int32 * string)> = _v3001 |> Option.get
                        v3128
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3129 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3129
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3130 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3130
#endif
                        |> fun x -> _v2996 <- Some x
                        let v3131 : Async<struct (int32 * string)> = _v2996.Value
                        v3131
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3132 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3132
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3133 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3133
#endif
                        |> fun x -> _v2991 <- Some x
                        let v3134 : Async<struct (int32 * string)> = _v2991.Value
                        let v3135 : struct (int32 * string) option = None
                        let v3136 : bool = true in let mutable _v3135 = v3135
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v3137 : int32, v3138 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3137, v3138)
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let struct (v3139 : int32, v3140 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3139, v3140)
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v3141 : int32, v3142 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3141, v3142)
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3143 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v3144 : int32, v3145 : string) = v3143 v3134
                        struct (v3144, v3145)
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let struct (v3146 : int32, v3147 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3146, v3147)
#endif
                        #if FABLE_COMPILER_PYTHON
                        let struct (v3148 : int32, v3149 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3148, v3149)
#endif
                        |> fun x -> _v3135 <- Some x
                        let struct (v3150 : int32, v3151 : string) = _v3135.Value
                        struct (v3150, v3151)
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let struct (v3152 : int32, v3153 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3152, v3153)
#endif
                        #if FABLE_COMPILER_PYTHON
                        let struct (v3154 : int32, v3155 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3154, v3155)
#endif
                        |> fun x -> _v2952 <- Some x
                        let struct (v3156 : int32, v3157 : string) = _v2952.Value
                        let v3158 : bool option = None
                        let v3159 : bool = true in let mutable _v3158 = v3158
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3160 : string = "cfg!(windows)"
                        let v3161 : bool = Fable.Core.RustInterop.emitRustExpr () v3160
                        v3161
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v3162 : bool = null |> unbox<bool>
                        v3162
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v3163 : bool = null |> unbox<bool>
                        v3163
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3164 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
                        let v3165 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
                        let v3166 : bool = v3165 v3164
                        v3166
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3167 : bool = null |> unbox<bool>
                        v3167
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3168 : bool = null |> unbox<bool>
                        v3168
#endif
                        |> fun x -> _v3158 <- Some x
                        let v3169 : bool = _v3158.Value
                        let v3170 : bool = v3169 = false
                        let v3191 : string =
                            if v3170 then
                                v2866
                            else
                                let v3171 : string option = None
                                let v3172 : bool = true in let mutable _v3171 = v3171
                                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v3173 : string = method26()
                                let v3174 : string = method27(v2866)
                                let v3175 : string = method28()
                                let v3176 : string = $"&regex::Regex::new(&$0).unwrap().replace_all(&$1, &*$2)"
                                let v3177 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr struct (v3173, v3174, v3175) v3176
                                let v3178 : string = "String::from($0)"
                                let v3179 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3177 v3178
                                let v3180 : string = "fable_library_rust::String_::fromString($0)"
                                let v3181 : string = Fable.Core.RustInterop.emitRustExpr v3179 v3180
                                v3181
#endif
                                #if FABLE_COMPILER_RUST && WASM
                                let v3182 : string = null |> unbox<string>
                                v3182
#endif
                                #if FABLE_COMPILER_RUST && CONTRACT
                                let v3183 : string = null |> unbox<string>
                                v3183
#endif
                                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                                let v3184 : string = "^\\\\\\\\\\?\\\\"
                                let v3185 : string = System.Text.RegularExpressions.Regex.Replace (v2866, v3184, v141)
                                v3185
#endif
                                #if FABLE_COMPILER_TYPESCRIPT
                                let v3186 : string = null |> unbox<string>
                                v3186
#endif
                                #if FABLE_COMPILER_PYTHON
                                let v3187 : string = null |> unbox<string>
                                v3187
#endif
                                |> fun x -> _v3171 <- Some x
                                let v3188 : string = _v3171.Value
                                let v3189 : string = $"{v3188.[0] |> System.Char.ToLower}{v3188.[1..]}"
                                let v3190 : string = v3189.Replace (v143, v144)
                                v3190
                        let v3192 : System.Threading.CancellationToken option = None
                        let v3193 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v3194 : string option = None
                        let v3195 : string = $"pwsh -c \"(Get-FileHash \\\"{v3191}\\\" -Algorithm SHA256).Hash\""
                        let v3196 : struct (int32 * string) option = None
                        let v3197 : bool = true in let mutable _v3196 = v3196
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v3198 : string, v3199 : string) = method29()
                        let v3200 : int32 = v3195.Length
                        let v3201 : (char []) = Array.zeroCreate<char> (v3200)
                        let v3202 : Mut4 = {l0 = 0} : Mut4
                        while method30(v3200, v3202) do
                            let v3204 : int32 = v3202.l0
                            let v3205 : char = v3195.[int v3204]
                            v3201.[int v3204] <- v3205
                            let v3206 : int32 = v3204 + 1
                            v3202.l0 <- v3206
                            ()
                        let v3207 : ((char []) -> char list) = Array.toList
                        let v3208 : char list = v3207 v3201
                        let v3209 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v3210 : (char -> (UH0 -> UH0)) = method31()
                        let v3211 : (char list -> (UH0 -> UH0)) = v3209 v3210
                        let v3212 : (UH0 -> UH0) = v3211 v3208
                        let v3213 : UH0 = UH0_0
                        let v3214 : UH0 = v3212 v3213
                        let v3215 : US10 = US10_0
                        let struct (v3216 : string, v3217 : string) = method32(v3199, v3198, v3214, v3215)
                        let v3218 : (string []) = method33(v3217)
                        let v3219 : string = "$0.to_vec()"
                        let v3220 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v3218 v3219
                        let v3221 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v3222 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3220, v255) v3221
                        let v3223 : US0 = US0_1
                        let v3224 : (unit -> string) = closure27(v3192, v3195, v3193, v3194, v3216, v3222)
                        let v3225 : (unit -> string) = method38()
                        method3(v3223, v3224, v3225)
                        let v3226 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method39(v3192, v3195, v3193, v3194, v3216, v3222)
                        let v3227 : string = "futures_lite::future::block_on($0)"
                        let v3228 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v3226 v3227
                        let (a, b) = v3228
                        let v3229 : int32 = a
                        let v3230 : string = b
                        struct (v3229, v3230)
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let struct (v3231 : int32, v3232 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3231, v3232)
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v3233 : int32, v3234 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3233, v3234)
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3235 : Async<struct (int32 * string)> option = None
                        let v3236 : bool = true in let mutable _v3235 = v3235
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3237 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3237
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v3238 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3238
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v3239 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3239
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3240 : Async<struct (int32 * string)> option = None
                        let v3241 : bool = true in let mutable _v3240 = v3240
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3242 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3242
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v3243 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3243
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v3244 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3244
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3245 : Async<struct (int32 * string)> option = None
                        let mutable _v3245 = v3245
                        async {
                        let struct (v3246 : string, v3247 : string) = method29()
                        let v3248 : (char []) = Array.zeroCreate<char> (v3200)
                        let v3249 : Mut4 = {l0 = 0} : Mut4
                        while method30(v3200, v3249) do
                            let v3251 : int32 = v3249.l0
                            let v3252 : char = v3195.[int v3251]
                            v3248.[int v3251] <- v3252
                            let v3253 : int32 = v3251 + 1
                            v3249.l0 <- v3253
                            ()
                        let v3254 : ((char []) -> char list) = Array.toList
                        let v3255 : char list = v3254 v3248
                        let v3256 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v3257 : (char -> (UH0 -> UH0)) = method31()
                        let v3258 : (char list -> (UH0 -> UH0)) = v3256 v3257
                        let v3259 : (UH0 -> UH0) = v3258 v3255
                        let v3260 : UH0 = UH0_0
                        let v3261 : UH0 = v3259 v3260
                        let v3262 : US10 = US10_0
                        let struct (v3263 : string, v3264 : string) = method32(v3247, v3246, v3261, v3262)
                        let v3265 : (string -> US7) = method40()
                        let v3266 : US7 = US7_1
                        let v3267 : US7 = v3194 |> Option.map v3265 |> Option.defaultValue v3266 
                        let v3270 : string =
                            match v3267 with
                            | US7_1 -> (* None *)
                                v141
                            | US7_0(v3268) -> (* Some *)
                                v3268
                        let v3271 : US0 = US0_1
                        let v3272 : (unit -> string) = closure44(v3192, v3195, v3193, v3194)
                        let v3273 : (unit -> string) = method38()
                        method3(v3271, v3272, v3273)
                        let v3274 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v3275 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v3264, StandardOutputEncoding = v3274, WorkingDirectory = v3270, FileName = v3263, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v3276 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v3275)
                        use v3276 = v3276 
                        let v3277 : System.Diagnostics.Process = v3276 
                        let v3278 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v3279 : System.Collections.Concurrent.ConcurrentStack<string> = v3278 ()
                        let v3280 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v3192, v3195, v3193, v3194, v3277, v3279)
                        v3277.OutputDataReceived.Add v3280 
                        let v3281 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v3192, v3195, v3193, v3194, v3277, v3279)
                        v3277.ErrorDataReceived.Add v3281 
                        let v3282 : (unit -> bool) = v3277.Start
                        let v3283 : bool = v3282 ()
                        let v3284 : bool = v3283 = false
                        if v3284 then
                            let v3285 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v3285
                        let v3286 : (unit -> unit) = v3277.BeginErrorReadLine
                        v3286 ()
                        let v3287 : (unit -> unit) = v3277.BeginOutputReadLine
                        v3287 ()
                        let v3288 : (System.Threading.CancellationToken -> US18) = method57()
                        let v3289 : US18 = US18_1
                        let v3290 : US18 = v3192 |> Option.map v3288 |> Option.defaultValue v3289 
                        let v3294 : System.Threading.CancellationToken =
                            match v3290 with
                            | US18_1 -> (* None *)
                                let v3292 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v3292
                            | US18_0(v3291) -> (* Some *)
                                v3291
                        let v3295 : Async<System.Threading.CancellationToken> option = None
                        let v3296 : bool = true in let mutable _v3295 = v3295
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3297 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3297
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v3298 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3298
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v3299 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3299
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3300 : Async<System.Threading.CancellationToken> option = None
                        let v3301 : bool = true in let mutable _v3300 = v3300
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3302 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3302
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v3303 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3303
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v3304 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3304
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3305 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v3305 = v3305
                        async {
                        let v3306 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v3306 = v3306 
                        let v3307 : System.Threading.CancellationToken = v3306 
                        let v3308 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v3309 : (System.Threading.CancellationToken []) = [|v3307; v3308; v3294|]
                        let v3310 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v3311 : System.Threading.CancellationTokenSource = v3310 v3309
                        let v3312 : System.Threading.CancellationToken = v3311.Token
                        return v3312 
                        }
                        |> fun x -> _v3305 <- Some x
                        let v3313 : Async<System.Threading.CancellationToken> = _v3305 |> Option.get
                        v3313
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3314 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3314
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3315 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3315
#endif
                        |> fun x -> _v3300 <- Some x
                        let v3316 : Async<System.Threading.CancellationToken> = _v3300.Value
                        v3316
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3317 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3317
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3318 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3318
#endif
                        |> fun x -> _v3295 <- Some x
                        let v3319 : Async<System.Threading.CancellationToken> = _v3295.Value
                        let! v3319 = v3319 
                        let v3320 : System.Threading.CancellationToken = v3319 
                        let v3321 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v3320.Register
                        let v3322 : (unit -> unit) = closure50(v3277)
                        let v3323 : System.Threading.CancellationTokenRegistration = v3321 v3322
                        use v3323 = v3323 
                        let v3324 : System.Threading.CancellationTokenRegistration = v3323 
                        let v3325 : Async<int32> option = None
                        let v3326 : bool = true in let mutable _v3325 = v3325
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3327 : Async<int32> = null |> unbox<Async<int32>>
                        v3327
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v3328 : Async<int32> = null |> unbox<Async<int32>>
                        v3328
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v3329 : Async<int32> = null |> unbox<Async<int32>>
                        v3329
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3330 : Async<int32> option = None
                        let mutable _v3330 = v3330
                        async {
                        try
                        let v3331 : System.Threading.Tasks.Task = v3277.WaitForExitAsync v3320 
                        let v3332 : Async<unit> option = None
                        let v3333 : bool = true in let mutable _v3332 = v3332
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3334 : Async<unit> = null |> unbox<Async<unit>>
                        v3334
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v3335 : Async<unit> = null |> unbox<Async<unit>>
                        v3335
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v3336 : Async<unit> = null |> unbox<Async<unit>>
                        v3336
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3337 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v3338 : Async<unit> = v3337 v3331
                        v3338
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3339 : Async<unit> = null |> unbox<Async<unit>>
                        v3339
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3340 : Async<unit> = null |> unbox<Async<unit>>
                        v3340
#endif
                        |> fun x -> _v3332 <- Some x
                        let v3341 : Async<unit> = _v3332.Value
                        do! v3341 
                        let v3342 : int32 = v3277.ExitCode
                        return v3342 
                        with ex ->
                        let v3343 : exn = ex
                        let v3344 : string option = None
                        let v3345 : bool = true in let mutable _v3344 = v3344
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3346 : string = $"%A{v3343}"
                        v3346
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v3347 : string = $"%A{v3343}"
                        v3347
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v3348 : string = $"%A{v3343}"
                        v3348
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3349 : string = $"{v3343.GetType ()}: {v3343.Message}"
                        v3349
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3350 : string = $"%A{v3343}"
                        v3350
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3351 : string = $"%A{v3343}"
                        v3351
#endif
                        |> fun x -> _v3344 <- Some x
                        let v3352 : string = _v3344.Value
                        let v3353 : (string -> unit) = v3279.Push
                        v3353 v3352
                        let v3354 : System.Threading.Tasks.TaskCanceledException = v3343 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v3355 : US0 = US0_3
                        let v3356 : (unit -> string) = closure51(v3354)
                        let v3357 : (unit -> string) = method38()
                        method3(v3355, v3356, v3357)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v3330 <- Some x
                        let v3358 : Async<int32> = _v3330 |> Option.get
                        v3358
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3359 : Async<int32> = null |> unbox<Async<int32>>
                        v3359
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3360 : Async<int32> = null |> unbox<Async<int32>>
                        v3360
#endif
                        |> fun x -> _v3325 <- Some x
                        let v3361 : Async<int32> = _v3325.Value
                        let! v3361 = v3361 
                        let v3362 : int32 = v3361 
                        let v3363 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v3364 : string seq = v3363 v3279
                        let v3365 : string = method58()
                        let v3366 : (string -> (string seq -> string)) = String.concat
                        let v3367 : (string seq -> string) = v3366 v3365
                        let v3368 : string = v3367 v3364
                        let v3369 : US0 = US0_1
                        let v3370 : (unit -> string) = closure52(v3362, v3368)
                        let v3371 : (unit -> string) = method38()
                        method3(v3369, v3370, v3371)
                        return struct (v3362, v3368) 
                        }
                        |> fun x -> _v3245 <- Some x
                        let v3372 : Async<struct (int32 * string)> = _v3245 |> Option.get
                        v3372
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3373 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3373
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3374 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3374
#endif
                        |> fun x -> _v3240 <- Some x
                        let v3375 : Async<struct (int32 * string)> = _v3240.Value
                        v3375
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3376 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3376
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3377 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3377
#endif
                        |> fun x -> _v3235 <- Some x
                        let v3378 : Async<struct (int32 * string)> = _v3235.Value
                        let v3379 : struct (int32 * string) option = None
                        let v3380 : bool = true in let mutable _v3379 = v3379
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v3381 : int32, v3382 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3381, v3382)
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let struct (v3383 : int32, v3384 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3383, v3384)
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v3385 : int32, v3386 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3385, v3386)
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3387 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v3388 : int32, v3389 : string) = v3387 v3378
                        struct (v3388, v3389)
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let struct (v3390 : int32, v3391 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3390, v3391)
#endif
                        #if FABLE_COMPILER_PYTHON
                        let struct (v3392 : int32, v3393 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3392, v3393)
#endif
                        |> fun x -> _v3379 <- Some x
                        let struct (v3394 : int32, v3395 : string) = _v3379.Value
                        struct (v3394, v3395)
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let struct (v3396 : int32, v3397 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3396, v3397)
#endif
                        #if FABLE_COMPILER_PYTHON
                        let struct (v3398 : int32, v3399 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3398, v3399)
#endif
                        |> fun x -> _v3196 <- Some x
                        let struct (v3400 : int32, v3401 : string) = _v3196.Value
                        let v3402 : bool = v3157 = v3401
                        v3402
                    else
                        false
                let v3404 : bool = v3403 = false
                let v3636 : US8 =
                    if v3404 then
                        let v3405 : string = $"crowbook --single \"{v511}\" --output \"{v2865}\" --to {v2864} --set rendering.num_depth 6 html.css.add \\\"''' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} '''\\\""
                        let v3406 : System.Threading.CancellationToken option = None
                        let v3407 : (struct (bool * string * int32) -> Async<unit>) option = None
                        let v3408 : string option = None
                        let v3409 : string option = Some v1 
                        let v3410 : struct (int32 * string) option = None
                        let v3411 : bool = true in let mutable _v3410 = v3410
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v3412 : string, v3413 : string) = method29()
                        let v3414 : int32 = v3405.Length
                        let v3415 : (char []) = Array.zeroCreate<char> (v3414)
                        let v3416 : Mut4 = {l0 = 0} : Mut4
                        while method30(v3414, v3416) do
                            let v3418 : int32 = v3416.l0
                            let v3419 : char = v3405.[int v3418]
                            v3415.[int v3418] <- v3419
                            let v3420 : int32 = v3418 + 1
                            v3416.l0 <- v3420
                            ()
                        let v3421 : ((char []) -> char list) = Array.toList
                        let v3422 : char list = v3421 v3415
                        let v3423 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v3424 : (char -> (UH0 -> UH0)) = method31()
                        let v3425 : (char list -> (UH0 -> UH0)) = v3423 v3424
                        let v3426 : (UH0 -> UH0) = v3425 v3422
                        let v3427 : UH0 = UH0_0
                        let v3428 : UH0 = v3426 v3427
                        let v3429 : US10 = US10_0
                        let struct (v3430 : string, v3431 : string) = method32(v3413, v3412, v3428, v3429)
                        let v3432 : (string []) = method33(v3431)
                        let v3433 : string = "$0.to_vec()"
                        let v3434 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v3432 v3433
                        let v3435 : string = "$0.iter().map(|x| $1(x.clone())).collect()"
                        let v3436 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3434, v255) v3435
                        let v3437 : US0 = US0_1
                        let v3438 : (unit -> string) = closure27(v3406, v3405, v3407, v3409, v3430, v3436)
                        let v3439 : (unit -> string) = method38()
                        method3(v3437, v3438, v3439)
                        let v3440 : std_pin_Pin<Box<Dyn<std_future_Future<(int32 * string)>>>> = method39(v3406, v3405, v3407, v3409, v3430, v3436)
                        let v3441 : string = "futures_lite::future::block_on($0)"
                        let v3442 : (int32 * string) = Fable.Core.RustInterop.emitRustExpr v3440 v3441
                        let (a, b) = v3442
                        let v3443 : int32 = a
                        let v3444 : string = b
                        struct (v3443, v3444)
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let struct (v3445 : int32, v3446 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3445, v3446)
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v3447 : int32, v3448 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3447, v3448)
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3449 : Async<struct (int32 * string)> option = None
                        let v3450 : bool = true in let mutable _v3449 = v3449
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3451 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3451
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v3452 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3452
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v3453 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3453
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3454 : Async<struct (int32 * string)> option = None
                        let v3455 : bool = true in let mutable _v3454 = v3454
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3456 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3456
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v3457 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3457
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v3458 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3458
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3459 : Async<struct (int32 * string)> option = None
                        let mutable _v3459 = v3459
                        async {
                        let struct (v3460 : string, v3461 : string) = method29()
                        let v3462 : (char []) = Array.zeroCreate<char> (v3414)
                        let v3463 : Mut4 = {l0 = 0} : Mut4
                        while method30(v3414, v3463) do
                            let v3465 : int32 = v3463.l0
                            let v3466 : char = v3405.[int v3465]
                            v3462.[int v3465] <- v3466
                            let v3467 : int32 = v3465 + 1
                            v3463.l0 <- v3467
                            ()
                        let v3468 : ((char []) -> char list) = Array.toList
                        let v3469 : char list = v3468 v3462
                        let v3470 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v3471 : (char -> (UH0 -> UH0)) = method31()
                        let v3472 : (char list -> (UH0 -> UH0)) = v3470 v3471
                        let v3473 : (UH0 -> UH0) = v3472 v3469
                        let v3474 : UH0 = UH0_0
                        let v3475 : UH0 = v3473 v3474
                        let v3476 : US10 = US10_0
                        let struct (v3477 : string, v3478 : string) = method32(v3461, v3460, v3475, v3476)
                        let v3479 : (string -> US7) = method40()
                        let v3480 : US7 = US7_1
                        let v3481 : US7 = v3409 |> Option.map v3479 |> Option.defaultValue v3480 
                        let v3484 : string =
                            match v3481 with
                            | US7_1 -> (* None *)
                                v141
                            | US7_0(v3482) -> (* Some *)
                                v3482
                        let v3485 : US0 = US0_1
                        let v3486 : (unit -> string) = closure44(v3406, v3405, v3407, v3409)
                        let v3487 : (unit -> string) = method38()
                        method3(v3485, v3486, v3487)
                        let v3488 : System.Text.Encoding = System.Text.Encoding.UTF8
                        let v3489 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v3478, StandardOutputEncoding = v3488, WorkingDirectory = v3484, FileName = v3477, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
                        let v3490 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v3489)
                        use v3490 = v3490 
                        let v3491 : System.Diagnostics.Process = v3490 
                        let v3492 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
                        let v3493 : System.Collections.Concurrent.ConcurrentStack<string> = v3492 ()
                        let v3494 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure45(v3406, v3405, v3407, v3409, v3491, v3493)
                        v3491.OutputDataReceived.Add v3494 
                        let v3495 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v3406, v3405, v3407, v3409, v3491, v3493)
                        v3491.ErrorDataReceived.Add v3495 
                        let v3496 : (unit -> bool) = v3491.Start
                        let v3497 : bool = v3496 ()
                        let v3498 : bool = v3497 = false
                        if v3498 then
                            let v3499 : string = $"execute_with_options_async / process_start error"
                            failwith<unit> v3499
                        let v3500 : (unit -> unit) = v3491.BeginErrorReadLine
                        v3500 ()
                        let v3501 : (unit -> unit) = v3491.BeginOutputReadLine
                        v3501 ()
                        let v3502 : (System.Threading.CancellationToken -> US18) = method57()
                        let v3503 : US18 = US18_1
                        let v3504 : US18 = v3406 |> Option.map v3502 |> Option.defaultValue v3503 
                        let v3508 : System.Threading.CancellationToken =
                            match v3504 with
                            | US18_1 -> (* None *)
                                let v3506 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                                v3506
                            | US18_0(v3505) -> (* Some *)
                                v3505
                        let v3509 : Async<System.Threading.CancellationToken> option = None
                        let v3510 : bool = true in let mutable _v3509 = v3509
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3511 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3511
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v3512 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3512
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v3513 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3513
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3514 : Async<System.Threading.CancellationToken> option = None
                        let v3515 : bool = true in let mutable _v3514 = v3514
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3516 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3516
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v3517 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3517
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v3518 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3518
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3519 : Async<System.Threading.CancellationToken> option = None
                        let mutable _v3519 = v3519
                        async {
                        let v3520 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                        let! v3520 = v3520 
                        let v3521 : System.Threading.CancellationToken = v3520 
                        let v3522 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                        let v3523 : (System.Threading.CancellationToken []) = [|v3521; v3522; v3508|]
                        let v3524 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                        let v3525 : System.Threading.CancellationTokenSource = v3524 v3523
                        let v3526 : System.Threading.CancellationToken = v3525.Token
                        return v3526 
                        }
                        |> fun x -> _v3519 <- Some x
                        let v3527 : Async<System.Threading.CancellationToken> = _v3519 |> Option.get
                        v3527
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3528 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3528
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3529 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3529
#endif
                        |> fun x -> _v3514 <- Some x
                        let v3530 : Async<System.Threading.CancellationToken> = _v3514.Value
                        v3530
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3531 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3531
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3532 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
                        v3532
#endif
                        |> fun x -> _v3509 <- Some x
                        let v3533 : Async<System.Threading.CancellationToken> = _v3509.Value
                        let! v3533 = v3533 
                        let v3534 : System.Threading.CancellationToken = v3533 
                        let v3535 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v3534.Register
                        let v3536 : (unit -> unit) = closure50(v3491)
                        let v3537 : System.Threading.CancellationTokenRegistration = v3535 v3536
                        use v3537 = v3537 
                        let v3538 : System.Threading.CancellationTokenRegistration = v3537 
                        let v3539 : Async<int32> option = None
                        let v3540 : bool = true in let mutable _v3539 = v3539
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3541 : Async<int32> = null |> unbox<Async<int32>>
                        v3541
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v3542 : Async<int32> = null |> unbox<Async<int32>>
                        v3542
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v3543 : Async<int32> = null |> unbox<Async<int32>>
                        v3543
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3544 : Async<int32> option = None
                        let mutable _v3544 = v3544
                        async {
                        try
                        let v3545 : System.Threading.Tasks.Task = v3491.WaitForExitAsync v3534 
                        let v3546 : Async<unit> option = None
                        let v3547 : bool = true in let mutable _v3546 = v3546
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3548 : Async<unit> = null |> unbox<Async<unit>>
                        v3548
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v3549 : Async<unit> = null |> unbox<Async<unit>>
                        v3549
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v3550 : Async<unit> = null |> unbox<Async<unit>>
                        v3550
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3551 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                        let v3552 : Async<unit> = v3551 v3545
                        v3552
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3553 : Async<unit> = null |> unbox<Async<unit>>
                        v3553
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3554 : Async<unit> = null |> unbox<Async<unit>>
                        v3554
#endif
                        |> fun x -> _v3546 <- Some x
                        let v3555 : Async<unit> = _v3546.Value
                        do! v3555 
                        let v3556 : int32 = v3491.ExitCode
                        return v3556 
                        with ex ->
                        let v3557 : exn = ex
                        let v3558 : string option = None
                        let v3559 : bool = true in let mutable _v3558 = v3558
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3560 : string = $"%A{v3557}"
                        v3560
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let v3561 : string = $"%A{v3557}"
                        v3561
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let v3562 : string = $"%A{v3557}"
                        v3562
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3563 : string = $"{v3557.GetType ()}: {v3557.Message}"
                        v3563
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3564 : string = $"%A{v3557}"
                        v3564
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3565 : string = $"%A{v3557}"
                        v3565
#endif
                        |> fun x -> _v3558 <- Some x
                        let v3566 : string = _v3558.Value
                        let v3567 : (string -> unit) = v3493.Push
                        v3567 v3566
                        let v3568 : System.Threading.Tasks.TaskCanceledException = v3557 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v3569 : US0 = US0_3
                        let v3570 : (unit -> string) = closure51(v3568)
                        let v3571 : (unit -> string) = method38()
                        method3(v3569, v3570, v3571)
                        return -2147483648 
                        (*
                        *)
                        }
                        |> fun x -> _v3544 <- Some x
                        let v3572 : Async<int32> = _v3544 |> Option.get
                        v3572
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3573 : Async<int32> = null |> unbox<Async<int32>>
                        v3573
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3574 : Async<int32> = null |> unbox<Async<int32>>
                        v3574
#endif
                        |> fun x -> _v3539 <- Some x
                        let v3575 : Async<int32> = _v3539.Value
                        let! v3575 = v3575 
                        let v3576 : int32 = v3575 
                        let v3577 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
                        let v3578 : string seq = v3577 v3493
                        let v3579 : string = method58()
                        let v3580 : (string -> (string seq -> string)) = String.concat
                        let v3581 : (string seq -> string) = v3580 v3579
                        let v3582 : string = v3581 v3578
                        let v3583 : US0 = US0_1
                        let v3584 : (unit -> string) = closure52(v3576, v3582)
                        let v3585 : (unit -> string) = method38()
                        method3(v3583, v3584, v3585)
                        return struct (v3576, v3582) 
                        }
                        |> fun x -> _v3459 <- Some x
                        let v3586 : Async<struct (int32 * string)> = _v3459 |> Option.get
                        v3586
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3587 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3587
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3588 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3588
#endif
                        |> fun x -> _v3454 <- Some x
                        let v3589 : Async<struct (int32 * string)> = _v3454.Value
                        v3589
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let v3590 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3590
#endif
                        #if FABLE_COMPILER_PYTHON
                        let v3591 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
                        v3591
#endif
                        |> fun x -> _v3449 <- Some x
                        let v3592 : Async<struct (int32 * string)> = _v3449.Value
                        let v3593 : struct (int32 * string) option = None
                        let v3594 : bool = true in let mutable _v3593 = v3593
                        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let struct (v3595 : int32, v3596 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3595, v3596)
#endif
                        #if FABLE_COMPILER_RUST && WASM
                        let struct (v3597 : int32, v3598 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3597, v3598)
#endif
                        #if FABLE_COMPILER_RUST && CONTRACT
                        let struct (v3599 : int32, v3600 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3599, v3600)
#endif
                        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                        let v3601 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
                        let struct (v3602 : int32, v3603 : string) = v3601 v3592
                        struct (v3602, v3603)
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let struct (v3604 : int32, v3605 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3604, v3605)
#endif
                        #if FABLE_COMPILER_PYTHON
                        let struct (v3606 : int32, v3607 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3606, v3607)
#endif
                        |> fun x -> _v3593 <- Some x
                        let struct (v3608 : int32, v3609 : string) = _v3593.Value
                        struct (v3608, v3609)
#endif
                        #if FABLE_COMPILER_TYPESCRIPT
                        let struct (v3610 : int32, v3611 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3610, v3611)
#endif
                        #if FABLE_COMPILER_PYTHON
                        let struct (v3612 : int32, v3613 : string) = null |> unbox<struct (int32 * string)>
                        struct (v3612, v3613)
#endif
                        |> fun x -> _v3410 <- Some x
                        let struct (v3614 : int32, v3615 : string) = _v3410.Value
                        let v3616 : US0 = US0_2
                        let v3617 : (unit -> string) = closure55()
                        let v3618 : (unit -> string) = closure56(v3615, v3614)
                        method3(v3616, v3617, v3618)
                        let v3619 : bool = v3614 <> 0
                        let v3622 : bool =
                            if v3619 then
                                true
                            else
                                let v3620 : string = "ERROR"
                                let v3621 : bool = v3615.Contains v3620
                                v3621
                        if v3622 then
                            let v3623 : US9 = US9_1(v2865, v3615)
                            US8_0(v3623)
                        else
                            let v3625 : unit option = None
                            let v3626 : bool = true in let mutable _v3625 = v3625
                            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v3627 : string = method59(v2866)
                            let v3628 : string = "std::fs::copy(&*v2865, &*v3627)"
                            let v3629 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v3628
                            let v3630 : string = "$0.unwrap()"
                            let v3631 : uint64 = Fable.Core.RustInterop.emitRustExpr v3629 v3630
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
                            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                            System.IO.File.Copy (v2865, v2866, true)
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
                            |> fun x -> _v3625 <- Some x
                            _v3625.Value
                            let v3632 : US9 = US9_0(v2865)
                            US8_0(v3632)
                    else
                        US8_1
                let v3637 : US8 list = []
                let v3638 : US8 = US8_1
                let v3639 : US8 list = v3638 :: v3637 
                let v3640 : US8 list = v2090 :: v3639 
                let v3641 : US8 list = v2863 :: v3640 
                let v3642 : US8 list = v3636 :: v3641 
                let v3643 : (US8 list -> (US8 [])) = List.toArray
                let v3644 : (US8 []) = v3643 v3642
                let v3645 : US0 = US0_2
                let v3646 : (unit -> string) = closure57()
                let v3647 : (unit -> string) = closure58(v3644)
                method3(v3645, v3646, v3647)
                let v3648 : unit option = None
                let v3649 : bool = true in let mutable _v3648 = v3648
                #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v3650 : string = method59(v1044)
                let v3651 : string = "std::fs::copy(&*v511, &*v3650)"
                let v3652 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v3651
                let v3653 : string = "$0.unwrap()"
                let v3654 : uint64 = Fable.Core.RustInterop.emitRustExpr v3652 v3653
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
                #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
                System.IO.File.Copy (v511, v1044, true)
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
                |> fun x -> _v3648 <- Some x
                _v3648.Value
                v3644
            else
                [||]
        else
            [||]
    let v3659 : Result<struct (string * (US8 [])), std_string_String> = Ok struct (v117, v3658)
    v3659
and closure59 () () : string =
    let v0 : string = "documents.run"
    v0
and closure60 (v0 : Vec<Result<struct (string * (US8 [])), std_string_String>>) () : string =
    let v1 : string = "$0.len()"
    let v2 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"result_len: {v2} / {v3 ()}"
    v4
and method60 (v0 : Result<unit, std_string_String>) : Result<unit, std_string_String> =
    v0
and method17 (v0 : string, v1 : string, v2 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>> =
    let v3 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v3
    let v4 : string = "async_walkdir::WalkDir::new(&*$0)"
    let v5 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr v1 v4
    let v6 : string = "async_walkdir::WalkDir::filter($0, |x| $1(x))"
    let v7 : (async_walkdir_DirEntry -> std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>) = closure12()
    let v8 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr struct (v5, v7) v6
    let v9 : (Result<async_walkdir_DirEntry, std_io_Error> -> string option) = method25()
    let v10 : string = "futures_lite::stream::StreamExt::collect(futures_lite::stream::StreamExt::filter_map(v8, |x| v9(x))).await"
    let v11 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : US0 = US0_1
    let v13 : (unit -> string) = closure21()
    let v14 : (unit -> string) = closure22(v11)
    method3(v12, v13, v14)
    let v15 : string = "rayon::iter::IntoParallelIterator::into_par_iter(v11)"
    let v16 : rayon_vec_IntoIter<string> = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
    let v18 : (string -> Result<struct (string * (US8 [])), std_string_String>) = closure23(v0, v1, v2)
    let v19 : rayon_iter_Map<rayon_vec_IntoIter<string>> = Fable.Core.RustInterop.emitRustExpr struct (v16, v18) v17
    let v20 : string = "rayon::iter::ParallelIterator::collect($0)"
    let v21 : Vec<Result<struct (string * (US8 [])), std_string_String>> = Fable.Core.RustInterop.emitRustExpr v19 v20
    let v22 : US0 = US0_1
    let v23 : (unit -> string) = closure59()
    let v24 : (unit -> string) = closure60(v21)
    method3(v22, v23, v24)
    let v25 : Result<unit, std_string_String> = Ok ()
    let v26 : Result<unit, std_string_String> = method60(v25)
    let v27 : string = "v26 }}}})"
    Fable.Core.RustInterop.emitRustExpr () v27
    let v28 : string = "{{{ //"
    Fable.Core.RustInterop.emitRustExpr () v28
    let v29 : string = "__result"
    let v30 : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v29
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
    let v204 : string =
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
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
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
            v183
        else
            let v184 : string = "std::fs::canonicalize(&*$0)"
            let v185 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v101 v184
            let v186 : string = "$0.unwrap()"
            let v187 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v185 v186
            let v188 : string = "$0.display()"
            let v189 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v187 v188
            let v190 : std_string_String option = None
            let v191 : bool = true in let mutable _v190 = v190
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v192 : string = @$"format!(""{{}}"", $0)"
            let v193 : std_string_String = Fable.Core.RustInterop.emitRustExpr v189 v192
            v193
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v194 : string = @$"format!(""{{}}"", $0)"
            let v195 : std_string_String = Fable.Core.RustInterop.emitRustExpr v189 v194
            v195
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v196 : string = @$"format!(""{{}}"", $0)"
            let v197 : std_string_String = Fable.Core.RustInterop.emitRustExpr v189 v196
            v197
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v198 : std_string_String = null |> unbox<std_string_String>
            v198
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v199 : std_string_String = null |> unbox<std_string_String>
            v199
#endif
            #if FABLE_COMPILER_PYTHON
            let v200 : std_string_String = null |> unbox<std_string_String>
            v200
#endif
            |> fun x -> _v190 <- Some x
            let v201 : std_string_String = _v190.Value
            let v202 : string = "fable_library_rust::String_::fromString($0)"
            let v203 : string = Fable.Core.RustInterop.emitRustExpr v201 v202
            v203
    v204
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v205 : string = null |> unbox<string>
    v205
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v206 : string = null |> unbox<string>
    v206
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v207 : string = method16(v56)
    let v208 : (string -> string) = System.IO.Path.GetFullPath
    let v209 : string = v208 v207
    v209
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v210 : string = null |> unbox<string>
    v210
#endif
    #if FABLE_COMPILER_PYTHON
    let v211 : string = null |> unbox<string>
    v211
#endif
    |> fun x -> _v99 <- Some x
    let v212 : string = _v99.Value
    let v213 : string option = None
    let v214 : bool = true in let mutable _v213 = v213
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v215 : string = method12(v70)
    let v216 : string = method13(v215)
    let v217 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v218 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v216 v217
    let v219 : string = "String::from($0)"
    let v220 : std_string_String = Fable.Core.RustInterop.emitRustExpr v218 v219
    let v221 : string = "std::path::PathBuf::from($0)"
    let v222 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v220 v221
    let v223 : string = "$0.exists()"
    let v224 : bool = Fable.Core.RustInterop.emitRustExpr v222 v223
    let v225 : bool = v224 = false
    let v318 : string =
        if v225 then
            let v226 : string option = None
            let v227 : bool = true in let mutable _v226 = v226
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v228 : string = "std::env::current_dir()"
            let v229 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v228
            let v230 : string = "$0.unwrap()"
            let v231 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v229 v230
            let v232 : string = "$0.display()"
            let v233 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v231 v232
            let v234 : std_string_String option = None
            let v235 : bool = true in let mutable _v234 = v234
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v236 : string = @$"format!(""{{}}"", $0)"
            let v237 : std_string_String = Fable.Core.RustInterop.emitRustExpr v233 v236
            v237
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v238 : string = @$"format!(""{{}}"", $0)"
            let v239 : std_string_String = Fable.Core.RustInterop.emitRustExpr v233 v238
            v239
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v240 : string = @$"format!(""{{}}"", $0)"
            let v241 : std_string_String = Fable.Core.RustInterop.emitRustExpr v233 v240
            v241
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v242 : std_string_String = null |> unbox<std_string_String>
            v242
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v243 : std_string_String = null |> unbox<std_string_String>
            v243
#endif
            #if FABLE_COMPILER_PYTHON
            let v244 : std_string_String = null |> unbox<std_string_String>
            v244
#endif
            |> fun x -> _v234 <- Some x
            let v245 : std_string_String = _v234.Value
            let v246 : string = "fable_library_rust::String_::fromString($0)"
            let v247 : string = Fable.Core.RustInterop.emitRustExpr v245 v246
            v247
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v248 : string = null |> unbox<string>
            v248
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v249 : string = null |> unbox<string>
            v249
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v250 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v251 : string = v250 ()
            v251
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v252 : string = null |> unbox<string>
            v252
#endif
            #if FABLE_COMPILER_PYTHON
            let v253 : string = null |> unbox<string>
            v253
#endif
            |> fun x -> _v226 <- Some x
            let v254 : string = _v226.Value
            let v255 : string option = None
            let v256 : bool = true in let mutable _v255 = v255
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v257 : string = method13(v254)
            let v258 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v259 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v257 v258
            let v260 : string = "String::from($0)"
            let v261 : std_string_String = Fable.Core.RustInterop.emitRustExpr v259 v260
            let v262 : string = "std::path::PathBuf::from($0)"
            let v263 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v261 v262
            let v264 : string = method13(v215)
            let v265 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v266 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v264 v265
            let v267 : string = "String::from($0)"
            let v268 : std_string_String = Fable.Core.RustInterop.emitRustExpr v266 v267
            let v269 : string = "$0.join($1)"
            let v270 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v263, v268) v269
            let v271 : string = "$0.display()"
            let v272 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v270 v271
            let v273 : std_string_String option = None
            let v274 : bool = true in let mutable _v273 = v273
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v275 : string = @$"format!(""{{}}"", $0)"
            let v276 : std_string_String = Fable.Core.RustInterop.emitRustExpr v272 v275
            v276
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v277 : string = @$"format!(""{{}}"", $0)"
            let v278 : std_string_String = Fable.Core.RustInterop.emitRustExpr v272 v277
            v278
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v279 : string = @$"format!(""{{}}"", $0)"
            let v280 : std_string_String = Fable.Core.RustInterop.emitRustExpr v272 v279
            v280
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v281 : std_string_String = null |> unbox<std_string_String>
            v281
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v282 : std_string_String = null |> unbox<std_string_String>
            v282
#endif
            #if FABLE_COMPILER_PYTHON
            let v283 : std_string_String = null |> unbox<std_string_String>
            v283
#endif
            |> fun x -> _v273 <- Some x
            let v284 : std_string_String = _v273.Value
            let v285 : string = "fable_library_rust::String_::fromString($0)"
            let v286 : string = Fable.Core.RustInterop.emitRustExpr v284 v285
            v286
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v287 : string = null |> unbox<string>
            v287
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v288 : string = null |> unbox<string>
            v288
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v289 : string = System.IO.Path.Combine (v254, v215)
            v289
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v290 : string = "path"
            let v291 : IPathJoin = Fable.Core.JsInterop.importAll v290
            let v292 : string = method14(v254)
            let v293 : string = method15(v215)
            let v294 : string = "v291.join(v292, v293)"
            let v295 : string = Fable.Core.JsInterop.emitJsExpr () v294
            v295
#endif
            #if FABLE_COMPILER_PYTHON
            let v296 : string = null |> unbox<string>
            v296
#endif
            |> fun x -> _v255 <- Some x
            let v297 : string = _v255.Value
            v297
        else
            let v298 : string = "std::fs::canonicalize(&*$0)"
            let v299 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v215 v298
            let v300 : string = "$0.unwrap()"
            let v301 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v299 v300
            let v302 : string = "$0.display()"
            let v303 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v301 v302
            let v304 : std_string_String option = None
            let v305 : bool = true in let mutable _v304 = v304
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v306 : string = @$"format!(""{{}}"", $0)"
            let v307 : std_string_String = Fable.Core.RustInterop.emitRustExpr v303 v306
            v307
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v308 : string = @$"format!(""{{}}"", $0)"
            let v309 : std_string_String = Fable.Core.RustInterop.emitRustExpr v303 v308
            v309
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v310 : string = @$"format!(""{{}}"", $0)"
            let v311 : std_string_String = Fable.Core.RustInterop.emitRustExpr v303 v310
            v311
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v312 : std_string_String = null |> unbox<std_string_String>
            v312
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v313 : std_string_String = null |> unbox<std_string_String>
            v313
#endif
            #if FABLE_COMPILER_PYTHON
            let v314 : std_string_String = null |> unbox<std_string_String>
            v314
#endif
            |> fun x -> _v304 <- Some x
            let v315 : std_string_String = _v304.Value
            let v316 : string = "fable_library_rust::String_::fromString($0)"
            let v317 : string = Fable.Core.RustInterop.emitRustExpr v315 v316
            v317
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v321 : string = method16(v70)
    let v322 : (string -> string) = System.IO.Path.GetFullPath
    let v323 : string = v322 v321
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
    |> fun x -> _v213 <- Some x
    let v326 : string = _v213.Value
    let v327 : string option = None
    let v328 : bool = true in let mutable _v327 = v327
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v329 : string = method12(v84)
    let v330 : string = method13(v329)
    let v331 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v332 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v330 v331
    let v333 : string = "String::from($0)"
    let v334 : std_string_String = Fable.Core.RustInterop.emitRustExpr v332 v333
    let v335 : string = "std::path::PathBuf::from($0)"
    let v336 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v334 v335
    let v337 : string = "$0.exists()"
    let v338 : bool = Fable.Core.RustInterop.emitRustExpr v336 v337
    let v339 : bool = v338 = false
    let v432 : string =
        if v339 then
            let v340 : string option = None
            let v341 : bool = true in let mutable _v340 = v340
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v342 : string = "std::env::current_dir()"
            let v343 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v342
            let v344 : string = "$0.unwrap()"
            let v345 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v343 v344
            let v346 : string = "$0.display()"
            let v347 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v345 v346
            let v348 : std_string_String option = None
            let v349 : bool = true in let mutable _v348 = v348
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v350 : string = @$"format!(""{{}}"", $0)"
            let v351 : std_string_String = Fable.Core.RustInterop.emitRustExpr v347 v350
            v351
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v352 : string = @$"format!(""{{}}"", $0)"
            let v353 : std_string_String = Fable.Core.RustInterop.emitRustExpr v347 v352
            v353
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v354 : string = @$"format!(""{{}}"", $0)"
            let v355 : std_string_String = Fable.Core.RustInterop.emitRustExpr v347 v354
            v355
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v356 : std_string_String = null |> unbox<std_string_String>
            v356
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v357 : std_string_String = null |> unbox<std_string_String>
            v357
#endif
            #if FABLE_COMPILER_PYTHON
            let v358 : std_string_String = null |> unbox<std_string_String>
            v358
#endif
            |> fun x -> _v348 <- Some x
            let v359 : std_string_String = _v348.Value
            let v360 : string = "fable_library_rust::String_::fromString($0)"
            let v361 : string = Fable.Core.RustInterop.emitRustExpr v359 v360
            v361
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v362 : string = null |> unbox<string>
            v362
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v363 : string = null |> unbox<string>
            v363
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v364 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
            let v365 : string = v364 ()
            v365
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v366 : string = null |> unbox<string>
            v366
#endif
            #if FABLE_COMPILER_PYTHON
            let v367 : string = null |> unbox<string>
            v367
#endif
            |> fun x -> _v340 <- Some x
            let v368 : string = _v340.Value
            let v369 : string option = None
            let v370 : bool = true in let mutable _v369 = v369
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v371 : string = method13(v368)
            let v372 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v373 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v371 v372
            let v374 : string = "String::from($0)"
            let v375 : std_string_String = Fable.Core.RustInterop.emitRustExpr v373 v374
            let v376 : string = "std::path::PathBuf::from($0)"
            let v377 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v375 v376
            let v378 : string = method13(v329)
            let v379 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
            let v380 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v378 v379
            let v381 : string = "String::from($0)"
            let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr v380 v381
            let v383 : string = "$0.join($1)"
            let v384 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v377, v382) v383
            let v385 : string = "$0.display()"
            let v386 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v384 v385
            let v387 : std_string_String option = None
            let v388 : bool = true in let mutable _v387 = v387
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v389 : string = @$"format!(""{{}}"", $0)"
            let v390 : std_string_String = Fable.Core.RustInterop.emitRustExpr v386 v389
            v390
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v391 : string = @$"format!(""{{}}"", $0)"
            let v392 : std_string_String = Fable.Core.RustInterop.emitRustExpr v386 v391
            v392
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v393 : string = @$"format!(""{{}}"", $0)"
            let v394 : std_string_String = Fable.Core.RustInterop.emitRustExpr v386 v393
            v394
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v395 : std_string_String = null |> unbox<std_string_String>
            v395
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v396 : std_string_String = null |> unbox<std_string_String>
            v396
#endif
            #if FABLE_COMPILER_PYTHON
            let v397 : std_string_String = null |> unbox<std_string_String>
            v397
#endif
            |> fun x -> _v387 <- Some x
            let v398 : std_string_String = _v387.Value
            let v399 : string = "fable_library_rust::String_::fromString($0)"
            let v400 : string = Fable.Core.RustInterop.emitRustExpr v398 v399
            v400
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v401 : string = null |> unbox<string>
            v401
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v402 : string = null |> unbox<string>
            v402
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v403 : string = System.IO.Path.Combine (v368, v329)
            v403
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v404 : string = "path"
            let v405 : IPathJoin = Fable.Core.JsInterop.importAll v404
            let v406 : string = method14(v368)
            let v407 : string = method15(v329)
            let v408 : string = "v405.join(v406, v407)"
            let v409 : string = Fable.Core.JsInterop.emitJsExpr () v408
            v409
#endif
            #if FABLE_COMPILER_PYTHON
            let v410 : string = null |> unbox<string>
            v410
#endif
            |> fun x -> _v369 <- Some x
            let v411 : string = _v369.Value
            v411
        else
            let v412 : string = "std::fs::canonicalize(&*$0)"
            let v413 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v329 v412
            let v414 : string = "$0.unwrap()"
            let v415 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v413 v414
            let v416 : string = "$0.display()"
            let v417 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v415 v416
            let v418 : std_string_String option = None
            let v419 : bool = true in let mutable _v418 = v418
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v420 : string = @$"format!(""{{}}"", $0)"
            let v421 : std_string_String = Fable.Core.RustInterop.emitRustExpr v417 v420
            v421
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v422 : string = @$"format!(""{{}}"", $0)"
            let v423 : std_string_String = Fable.Core.RustInterop.emitRustExpr v417 v422
            v423
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v424 : string = @$"format!(""{{}}"", $0)"
            let v425 : std_string_String = Fable.Core.RustInterop.emitRustExpr v417 v424
            v425
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v426 : std_string_String = null |> unbox<std_string_String>
            v426
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v427 : std_string_String = null |> unbox<std_string_String>
            v427
#endif
            #if FABLE_COMPILER_PYTHON
            let v428 : std_string_String = null |> unbox<std_string_String>
            v428
#endif
            |> fun x -> _v418 <- Some x
            let v429 : std_string_String = _v418.Value
            let v430 : string = "fable_library_rust::String_::fromString($0)"
            let v431 : string = Fable.Core.RustInterop.emitRustExpr v429 v430
            v431
    v432
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v433 : string = null |> unbox<string>
    v433
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v434 : string = null |> unbox<string>
    v434
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v435 : string = method16(v84)
    let v436 : (string -> string) = System.IO.Path.GetFullPath
    let v437 : string = v436 v435
    v437
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v438 : string = null |> unbox<string>
    v438
#endif
    #if FABLE_COMPILER_PYTHON
    let v439 : string = null |> unbox<string>
    v439
#endif
    |> fun x -> _v327 <- Some x
    let v440 : string = _v327.Value
    let v441 : US0 = US0_1
    let v442 : (unit -> string) = closure10()
    let v443 : (unit -> string) = closure11(v98, v212, v326, v440)
    method3(v441, v442, v443)
    let v444 : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>> = method17(v212, v326, v440)
    let v445 : string = "futures_lite::future::block_on($0)"
    let v446 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr v444 v445
    let v447 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v446 v447
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
