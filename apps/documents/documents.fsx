#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
type Ref<'T> = class end
#else
type Ref<'T> = 'T
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::Command")>]
#endif
type clap_Command = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::Arg")>]
#endif
type clap_Arg = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
type std_string_String = class end
#else
type std_string_String = string
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::ArgMatches")>]
#endif
type clap_ArgMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::path::PathBuf")>]
type std_path_PathBuf = class end
#else
type std_path_PathBuf = string
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::path::Display")>]
type std_path_Display = class end
#else
type std_path_Display = string
#endif

#if FABLE_COMPILER
type System_IO_DirectoryInfo = unit
#else
type System_IO_DirectoryInfo = System.IO.DirectoryInfo
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Error")>]
type std_io_Error = class end
#else
type std_io_Error = string
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsString")>]
#endif
type std_ffi_OsString = class end
#if FABLE_COMPILER
type System_IO_FileInfo = unit
#else
type System_IO_FileInfo = System.IO.FileInfo
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Regex")>]
#endif
type regex_Regex = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::borrow::Cow<$0>")>]
#endif
type std_borrow_Cow<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::WalkDir")>]
#endif
type async_walkdir_WalkDir = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::DirEntry")>]
#endif
type async_walkdir_DirEntry = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::pin::Pin<$0>")>]
#endif
type std_pin_Pin<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::fs::FileType")>]
#endif
type std_fs_FileType = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::Filtering")>]
#endif
type async_walkdir_Filtering = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::Error")>]
#endif
type async_walkdir_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::vec::IntoIter<$0>")>]
#endif
type rayon_vec_IntoIter<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Command")>]
#endif
type std_process_Command = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Stdio")>]
#endif
type std_process_Stdio = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Child")>]
#endif
type std_process_Child = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Mutex<$0>")>]
#endif
type std_sync_Mutex<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Arc<$0>")>]
#endif
type std_sync_Arc<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::MutexGuard<$0>")>]
#endif
type std_sync_MutexGuard<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ChildStdout")>]
#endif
type std_process_ChildStdout = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ChildStderr")>]
#endif
type std_process_ChildStderr = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ChildStdin")>]
#endif
type std_process_ChildStdin = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Sender<$0>")>]
#endif
type std_sync_mpsc_Sender<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("encoding_rs_io::DecodeReaderBytes<$0, $1>")>]
#endif
type encoding_rs_io_DecodeReaderBytes<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::BufReader<$0>")>]
#endif
type std_io_BufReader<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Lines<$0>")>]
#endif
type std_io_Lines<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::SendError<$0>")>]
#endif
type std_sync_mpsc_SendError<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type core_ops_Try<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::thread::JoinHandle<$0>")>]
#endif
type std_thread_JoinHandle<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Output")>]
#endif
type std_process_Output = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ExitStatus")>]
#endif
type std_process_ExitStatus = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::fs::File")>]
#endif
type std_fs_File = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("sha2::Sha256")>]
#endif
type sha2_Sha256 = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type Slice'<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::iter::Map<$0, _>")>]
#endif
type rayon_iter_Map<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 $1")>]
#endif
type Lifetime<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("'static")>]
#endif
type StaticLifetime = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
type Str = class end
#else
type Str = string
#endif

module TraceState = let mutable trace_state = None
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
type IOsEnviron = abstract environ: x: unit -> obj
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>]
#endif
type Box<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>]
#endif
type Dyn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::future::Future<Output = $0>")>]
#endif
type std_future_Future<'T> = class end
type IPathJoin = abstract join: [<System.ParamArray>] paths: string[] -> string
type IFsExistsSync = abstract existsSync: path: string -> bool
type IPathDirname = abstract dirname: path: string -> string
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsStr")>]
#endif
type std_ffi_OsStr = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Error")>]
#endif
type regex_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Send")>]
#endif
type Send<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 + $1")>]
#endif
type LifetimeJoin<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Receiver<$0>")>]
#endif
type std_sync_mpsc_Receiver<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::PoisonError<$0>")>]
#endif
type std_sync_PoisonError<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("encoding_rs::Encoding")>]
#endif
type encoding_rs_Encoding = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::str::Utf8Error")>]
#endif
type std_str_Utf8Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0")>]
#endif
type LifetimeRef<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("core::any::Any")>]
type core_any_Any = class end
#else
type core_any_Any = obj
#endif

#if FABLE_COMPILER
[<CompilationRepresentation (CompilationRepresentationFlags.ModuleSuffix)>]
module System =
 module Diagnostics =
  type Process = unit
  type DataReceivedEventArgs = unit
#endif
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::FromUtf8Error")>]
#endif
type std_string_FromUtf8Error = class end
type [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
    | US0_4
and Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : (string -> unit)}
and Mut2 = {mutable l0 : bool}
and Mut3 = {mutable l0 : string}
and Mut4 = {mutable l0 : US0}
and [<Struct>] US1 =
    | US1_0 of f0_0 : US0
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : int64
    | US2_1
and [<Struct>] US3 =
    | US3_0
    | US3_1
    | US3_2
and [<Struct>] US4 =
    | US4_0 of f0_0 : US3
    | US4_1 of f1_0 : US3
    | US4_2 of f2_0 : US3
    | US4_3 of f3_0 : US3
    | US4_4 of f4_0 : US3
and [<Struct>] US5 =
    | US5_0 of f0_0 : string
    | US5_1
and [<Struct>] US6 =
    | US6_0 of f0_0 : std_string_String
    | US6_1
and [<Struct>] US7 =
    | US7_0 of f0_0 : string
    | US7_1 of f1_0 : string
and [<Struct>] US8 =
    | US8_0 of f0_0 : std_path_PathBuf
    | US8_1 of f1_0 : string
and [<Struct>] US9 =
    | US9_0 of f0_0 : std_path_PathBuf
    | US9_1
and Mut5 = {mutable l0 : int32; mutable l1 : int32; mutable l2 : (string [])}
and Mut6 = {mutable l0 : int32}
and [<Struct>] US10 =
    | US10_0 of f0_0 : std_fs_FileType
    | US10_1 of f1_0 : std_string_String
and [<Struct>] US11 =
    | US11_0
    | US11_1
    | US11_2
and [<Struct>] US12 =
    | US12_0 of f0_0 : async_walkdir_DirEntry
    | US12_1 of f1_0 : std_string_String
and [<Struct>] US13 =
    | US13_0 of f0_0 : string * f0_1 : US5
    | US13_1 of f1_0 : string
and [<Struct>] US14 =
    | US14_0 of f0_0 : char * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US14_1 of f1_0 : string
and UH0 =
    | UH0_0
    | UH0_1 of char * UH0
and UH1 =
    | UH1_0
    | UH1_1 of (struct (string * System.Text.StringBuilder * int32 * int32) -> US14) * UH1
and [<Struct>] US15 =
    | US15_0 of f0_0 : string * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US15_1 of f1_0 : string
and [<Struct>] US16 =
    | US16_0 of f0_0 : char
    | US16_1
and [<Struct>] US17 =
    | US17_0 of f0_0 : string * f0_1 : System.Text.StringBuilder * f0_2 : int32 * f0_3 : int32
    | US17_1 of f1_0 : string
and [<Struct>] US18 =
    | US18_0 of f0_0 : string * f0_1 : US5 * f0_2 : string * f0_3 : System.Text.StringBuilder * f0_4 : int32 * f0_5 : int32
    | US18_1 of f1_0 : string
and [<Struct>] US19 =
    | US19_0 of f0_0 : US16 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US19_1 of f1_0 : string
and [<Struct>] US20 =
    | US20_0 of f0_0 : US5 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US20_1 of f1_0 : string
and [<Struct>] US21 =
    | US21_0 of f0_0 : (string [])
    | US21_1 of f1_0 : string
and UH2 =
    | UH2_0
    | UH2_1 of string * UH2
and [<Struct>] US22 =
    | US22_0 of f0_0 : UH2 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US22_1 of f1_0 : string
and UH3 =
    | UH3_0
    | UH3_1 of (struct (string * System.Text.StringBuilder * int32 * int32) -> US15) * UH3
and [<Struct>] US23 =
    | US23_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>
    | US23_1 of f1_0 : std_string_String
and [<Struct>] US24 =
    | US24_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>
    | US24_1
and [<Struct>] US25 =
    | US25_0 of f0_0 : std_string_String
    | US25_1 of f1_0 : std_string_String
and [<Struct>] US26 =
    | US26_0 of f0_0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)
    | US26_1
and [<Struct>] US27 =
    | US27_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>
    | US27_1
and [<Struct>] US28 =
    | US28_0 of f0_0 : std_process_Output
    | US28_1 of f1_0 : std_string_String
and [<Struct>] US29 =
    | US29_0 of f0_0 : int32
    | US29_1
and [<Struct>] US30 =
    | US30_0 of f0_0 : (struct (int32 * string * bool) -> Async<unit>)
    | US30_1
and [<Struct>] US31 =
    | US31_0 of f0_0 : System.Threading.CancellationToken
    | US31_1
and [<Struct>] US32 =
    | US32_0 of f0_0 : Result<string, (string * string)>
    | US32_1
and UH5 =
    | UH5_0
    | UH5_1 of string * string * (string -> (string -> US32)) * UH5
and UH4 =
    | UH4_0
    | UH4_1 of UH5 * UH4
and [<Struct>] US33 =
    | US33_0 of f0_0 : string
    | US33_1 of f1_0 : std_string_String
and [<Struct>] US34 =
    | US34_0 of f0_0 : uint64
    | US34_1 of f1_0 : std_string_String
and [<Struct>] US35 =
    | US35_0 of f0_0 : int32 * f0_1 : string
    | US35_1 of f1_0 : int32 * f1_1 : string
and Mut7 = {mutable l0 : int32; mutable l1 : int32}
and Mut8 = {mutable l0 : int32; mutable l1 : string; mutable l2 : int32; mutable l3 : int32}
and Mut9 = {mutable l0 : int32; mutable l1 : Vec<Result<string, (string * string)> option>}
and [<Struct>] US36 =
    | US36_0 of f0_0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>
    | US36_1 of f1_0 : std_string_String
let rec method0 () : clap_Command =
    let v0 : string = "command"
    let v1 : string = "r#\"" + v0 + "\"#"
    let v2 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = "clap::Command::new($0)"
    let v4 : clap_Command = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "source-dir"
    let v6 : string = "r#\"" + v5 + "\"#"
    let v7 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v6 
    let v8 : string = "clap::Arg::new($0)"
    let v9 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "$0.short($1)"
    let v11 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v9, 's') v10 
    let v12 : string = "r#\"" + v5 + "\"#"
    let v13 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "$0.long($1)"
    let v15 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v11, v13) v14 
    let v16 : string = "$0.required($1)"
    let v17 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v15, true) v16 
    let v18 : string = "clap::Command::arg($0, $1)"
    let v19 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v4, v17) v18 
    let v20 : string = "dist-dir"
    let v21 : string = "r#\"" + v20 + "\"#"
    let v22 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v21 
    let v23 : string = "clap::Arg::new($0)"
    let v24 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "$0.short($1)"
    let v26 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v24, 'd') v25 
    let v27 : string = "r#\"" + v20 + "\"#"
    let v28 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "$0.long($1)"
    let v30 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v26, v28) v29 
    let v31 : string = "$0.required($1)"
    let v32 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v30, true) v31 
    let v33 : string = "clap::Command::arg($0, $1)"
    let v34 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v19, v32) v33 
    let v35 : string = "cache-dir"
    let v36 : string = "r#\"" + v35 + "\"#"
    let v37 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "clap::Arg::new($0)"
    let v39 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let v40 : string = "$0.short($1)"
    let v41 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v39, 'c') v40 
    let v42 : string = "r#\"" + v35 + "\"#"
    let v43 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : string = "$0.long($1)"
    let v45 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v41, v43) v44 
    let v46 : string = "$0.required($1)"
    let v47 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v45, true) v46 
    let v48 : string = "clap::Command::arg($0, $1)"
    let v49 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v34, v47) v48 
    let v50 : string = "hangul-spec"
    let v51 : string = "r#\"" + v50 + "\"#"
    let v52 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v51 
    let v53 : string = "clap::Arg::new($0)"
    let v54 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v52 v53 
    let v55 : string = "$0.short($1)"
    let v56 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v54, 'h') v55 
    let v57 : string = "r#\"" + v50 + "\"#"
    let v58 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v57 
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
and method4 (v0 : string) : string =
    v0
and method5 () : string =
    let v0 : string = ""
    v0
and closure3 () (v0 : string) : US5 =
    US5_0(v0)
and method6 () : (string -> US5) =
    closure3()
and method3 (v0 : string) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method4(v0)
    let v3 : string = "std::env::var(&*$0)"
    let v4 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "x"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v7 
    let v9 : string = "fable_library_rust::String_::fromString($0)"
    let v10 : string = Fable.Core.RustInterop.emitRustExpr v8 v9 
    let v11 : string = "true; $0 })"
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : string = "_result_map_"
    let v14 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : string = method5()
    let v16 : string = "$0.unwrap_or($1)"
    let v17 : string = Fable.Core.RustInterop.emitRustExpr struct (v14, v15) v16 
    let _v1 = v17 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v18 : US3 = US3_1
    let v19 : US4 = US4_2(v18)
    let v20 : string = $"env.get_environment_variable / target: {v19} / var: {v0}"
    let v21 : string = failwith<string> v20
    let _v1 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : US3 = US3_2
    let v23 : US4 = US4_2(v22)
    let v24 : string = $"env.get_environment_variable / target: {v23} / var: {v0}"
    let v25 : string = failwith<string> v24
    let _v1 = v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v26 : string = "process.env[$0] ?? \"\""
    let v27 : string = Fable.Core.JsInterop.emitJsExpr v0 v26 
    let _v1 = v27 
    #endif
#if FABLE_COMPILER_PYTHON
    let v28 : string = "os"
    let v29 : IOsEnviron = Fable.Core.PyInterop.importAll v28 
    let v30 : string = "v29.environ"
    let v31 : obj = Fable.Core.PyInterop.emitPyExpr () v30 
    let v34 : string = "v31.get($0)"
    let v35 : string = Fable.Core.PyInterop.emitPyExpr v0 v34 
    let mutable _v35 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v38 : (string -> string option) = Option.ofObj
    let v39 : string option = v38 v35
    v39 
    #else
    Some v35 
    #endif
    |> fun x -> _v35 <- Some x
    let v40 : string option = match _v35 with Some x -> x | None -> failwith "optionm'.of_obj / _v35=None"
    let v43 : (string -> US5) = method6()
    let v44 : US5 option = v40 |> Option.map v43 
    let v55 : US5 = US5_1
    let v56 : US5 = v44 |> Option.defaultValue v55 
    let v63 : string =
        match v56 with
        | US5_1 -> (* None *)
            let v61 : string = ""
            v61
        | US5_0(v60) -> (* Some *)
            v60
    let _v1 = v63 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v64 : US3 = US3_1
    let v65 : US4 = US4_0(v64)
    let v66 : string = $"env.get_environment_variable / target: {v65} / var: {v0}"
    let v67 : string = failwith<string> v66
    let _v1 = v67 
    #endif
#else
    let v68 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v69 : string = v68 v0
    let mutable _v69 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v70 : (string -> string option) = Option.ofObj
    let v71 : string option = v70 v69
    v71 
    #else
    Some v69 
    #endif
    |> fun x -> _v69 <- Some x
    let v72 : string option = match _v69 with Some x -> x | None -> failwith "optionm'.of_obj / _v69=None"
    let v75 : (string -> US5) = method6()
    let v76 : US5 option = v72 |> Option.map v75 
    let v87 : US5 = US5_1
    let v88 : US5 = v76 |> Option.defaultValue v87 
    let v95 : string =
        match v88 with
        | US5_1 -> (* None *)
            let v93 : string = ""
            v93
        | US5_0(v92) -> (* Some *)
            v92
    let _v1 = v95 
    #endif
    let v96 : string = _v1 
    v96
and method2 () : struct (US1 * US2) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method3(v0)
    
    
    
    
    
    let v2 : bool = "Verbose" = v1
    let v6 : US1 =
        if v2 then
            let v3 : US0 = US0_0
            US1_0(v3)
        else
            US1_1
    let v47 : US1 =
        match v6 with
        | US1_1 -> (* None *)
            let v9 : bool = "Debug" = v1
            let v13 : US1 =
                if v9 then
                    let v10 : US0 = US0_1
                    US1_0(v10)
                else
                    US1_1
            match v13 with
            | US1_1 -> (* None *)
                let v16 : bool = "Info" = v1
                let v20 : US1 =
                    if v16 then
                        let v17 : US0 = US0_2
                        US1_0(v17)
                    else
                        US1_1
                match v20 with
                | US1_1 -> (* None *)
                    let v23 : bool = "Warning" = v1
                    let v27 : US1 =
                        if v23 then
                            let v24 : US0 = US0_3
                            US1_0(v24)
                        else
                            US1_1
                    match v27 with
                    | US1_1 -> (* None *)
                        let v30 : bool = "Critical" = v1
                        let v34 : US1 =
                            if v30 then
                                let v31 : US0 = US0_4
                                US1_0(v31)
                            else
                                US1_1
                        match v34 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v35) -> (* Some *)
                            US1_0(v35)
                    | US1_0(v28) -> (* Some *)
                        US1_0(v28)
                | US1_0(v21) -> (* Some *)
                    US1_0(v21)
            | US1_0(v14) -> (* Some *)
                US1_0(v14)
        | US1_0(v7) -> (* Some *)
            US1_0(v7)
    let v48 : string = "AUTOMATION"
    let v49 : string = method3(v48)
    let v50 : string = "True"
    let v51 : bool = v49 <> v50 
    let v107 : US2 =
        if v51 then
            US2_1
        else
            let v55 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v56 : System.DateTime = System.DateTime.Now
            let _v55 = v56 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v57 : System.DateTime = System.DateTime.Now
            let _v55 = v57 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v58 : System.DateTime = null |> unbox<System.DateTime>
            let _v55 = v58 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v61 : System.DateTime = System.DateTime.Now
            let _v55 = v61 
            #endif
#if FABLE_COMPILER_PYTHON
            let v62 : System.DateTime = System.DateTime.Now
            let _v55 = v62 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v63 : System.DateTime = System.DateTime.Now
            let _v55 = v63 
            #endif
#else
            let v64 : System.DateTime = System.DateTime.Now
            let _v55 = v64 
            #endif
            let v65 : System.DateTime = _v55 
            let v70 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v71 : (System.DateTime -> int64) = _.Ticks
            let v72 : int64 = v71 v65
            let _v70 = v72 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v73 : (System.DateTime -> int64) = _.Ticks
            let v74 : int64 = v73 v65
            let _v70 = v74 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v75 : int64 = null |> unbox<int64>
            let _v70 = v75 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v78 : (System.DateTime -> int64) = _.Ticks
            let v79 : int64 = v78 v65
            let _v70 = v79 
            #endif
#if FABLE_COMPILER_PYTHON
            let v80 : (System.DateTime -> int64) = _.Ticks
            let v81 : int64 = v80 v65
            let _v70 = v81 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v82 : (System.DateTime -> int64) = _.Ticks
            let v83 : int64 = v82 v65
            let _v70 = v83 
            #endif
#else
            let v84 : (System.DateTime -> int64) = _.Ticks
            let v85 : int64 = v84 v65
            let _v70 = v85 
            #endif
            let v86 : int64 = _v70 
            let v103 : int64 = v86 |> int64 
            US2_0(v103)
    struct (v47, v107)
and closure4 () (v0 : string) : unit =
    ()
and method1 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v2 : US1, v3 : US2) = method2()
    let _v1 = struct (v2, v3) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : US1 = US1_1
    let v5 : US2 = US2_1
    let _v1 = struct (v4, v5) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "AUTOMATION"
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "option_env!(\"" + v6 + "\").unwrap_or(\"\")"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "String::from($0)"
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v11 
    let _v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "String::from($0)"
    let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v13 
    let _v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "String::from($0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v15 
    let _v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : std_string_String = v9 |> unbox<std_string_String>
    let _v10 = v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : std_string_String = v9 |> unbox<std_string_String>
    let _v10 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : std_string_String = v9 |> unbox<std_string_String>
    let _v10 = v23 
    #endif
#else
    let v26 : std_string_String = v9 |> unbox<std_string_String>
    let _v10 = v26 
    #endif
    let v29 : std_string_String = _v10 
    let v34 : string = "fable_library_rust::String_::fromString($0)"
    let v35 : string = Fable.Core.RustInterop.emitRustExpr v29 v34 
    let _v7 = v35 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = "option_env!(\"" + v6 + "\").unwrap_or(\"\")"
    let v37 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v39 : string = "String::from($0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v39 
    let _v38 = v40 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v41 : string = "String::from($0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v41 
    let _v38 = v42 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v43 : string = "String::from($0)"
    let v44 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v43 
    let _v38 = v44 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v45 : std_string_String = v37 |> unbox<std_string_String>
    let _v38 = v45 
    #endif
#if FABLE_COMPILER_PYTHON
    let v48 : std_string_String = v37 |> unbox<std_string_String>
    let _v38 = v48 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v51 : std_string_String = v37 |> unbox<std_string_String>
    let _v38 = v51 
    #endif
#else
    let v54 : std_string_String = v37 |> unbox<std_string_String>
    let _v38 = v54 
    #endif
    let v57 : std_string_String = _v38 
    let v62 : string = "fable_library_rust::String_::fromString($0)"
    let v63 : string = Fable.Core.RustInterop.emitRustExpr v57 v62 
    let _v7 = v63 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v64 : string = "option_env!(\"" + v6 + "\").unwrap_or(\"\")"
    let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v64 
    let v66 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v67 : string = "String::from($0)"
    let v68 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v67 
    let _v66 = v68 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v69 : string = "String::from($0)"
    let v70 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v69 
    let _v66 = v70 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v71 : string = "String::from($0)"
    let v72 : std_string_String = Fable.Core.RustInterop.emitRustExpr v65 v71 
    let _v66 = v72 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v73 : std_string_String = v65 |> unbox<std_string_String>
    let _v66 = v73 
    #endif
#if FABLE_COMPILER_PYTHON
    let v76 : std_string_String = v65 |> unbox<std_string_String>
    let _v66 = v76 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v79 : std_string_String = v65 |> unbox<std_string_String>
    let _v66 = v79 
    #endif
#else
    let v82 : std_string_String = v65 |> unbox<std_string_String>
    let _v66 = v82 
    #endif
    let v85 : std_string_String = _v66 
    let v90 : string = "fable_library_rust::String_::fromString($0)"
    let v91 : string = Fable.Core.RustInterop.emitRustExpr v85 v90 
    let _v7 = v91 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v92 : string = null |> unbox<string>
    let _v7 = v92 
    #endif
#if FABLE_COMPILER_PYTHON
    let v95 : string = null |> unbox<string>
    let _v7 = v95 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v98 : string = null |> unbox<string>
    let _v7 = v98 
    #endif
#else
    let v101 : string = null |> unbox<string>
    let _v7 = v101 
    #endif
    let v104 : string = _v7 
    let v109 : string = "True"
    let v110 : bool = v104 <> v109 
    let v121 : US2 =
        if v110 then
            US2_1
        else
            let v114 : string = $"near_sdk::env::block_timestamp()"
            let v115 : uint64 = Fable.Core.RustInterop.emitRustExpr () v114 
            let v116 : (uint64 -> int64) = int64
            let v117 : int64 = v116 v115
            US2_0(v117)
    let v122 : US1 = US1_1
    let _v1 = struct (v122, v121) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v123 : US1, v124 : US2) = method2()
    let _v1 = struct (v123, v124) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v125 : US1, v126 : US2) = method2()
    let _v1 = struct (v125, v126) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v127 : US1, v128 : US2) = method2()
    let _v1 = struct (v127, v128) 
    #endif
#else
    let struct (v129 : US1, v130 : US2) = method2()
    let _v1 = struct (v129, v130) 
    #endif
    let struct (v131 : US1, v132 : US2) = _v1 
    let v137 : Mut0 = {l0 = 1L} : Mut0
    let v138 : (string -> unit) = closure4()
    let v139 : Mut1 = {l0 = v138} : Mut1
    let v140 : Mut2 = {l0 = true} : Mut2
    let v141 : string = ""
    let v142 : Mut3 = {l0 = v141} : Mut3
    let v145 : US0 =
        match v131 with
        | US1_1 -> (* None *)
            v0
        | US1_0(v143) -> (* Some *)
            v143
    let v146 : Mut4 = {l0 = v145} : Mut4
    let v153 : int64 option =
        match v132 with
        | US2_1 -> (* None *)
            let v151 : int64 option = None
            v151
        | US2_0(v147) -> (* Some *)
            let v148 : int64 option = Some v147 
            v148
    struct (v137, v139, v140, v142, v146, v153)
and closure2 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_2
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method1(v1)
        let v8 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v8 
        ()
and closure6 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method1(v1)
        let v8 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v8 
        ()
and method7 (v0 : US0) : bool =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US0 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    if v37 then
        false
    else
        let v38 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
        let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v35
        let v40 : bool = v38 >= v39
        v40
and closure7 () (v0 : int64) : US2 =
    US2_0(v0)
and method9 () : (int64 -> US2) =
    closure7()
and method10 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method11 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method8 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US2) = method9()
    let v8 : US2 option = v5 |> Option.map v7 
    let v19 : US2 = US2_1
    let v20 : US2 = v8 |> Option.defaultValue v19 
    let v117 : System.DateTime =
        match v20 with
        | US2_1 -> (* None *)
            let v101 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v102 : System.DateTime = System.DateTime.Now
            let _v101 = v102 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v103 : System.DateTime = System.DateTime.Now
            let _v101 = v103 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v104 : System.DateTime = null |> unbox<System.DateTime>
            let _v101 = v104 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v107 : System.DateTime = System.DateTime.Now
            let _v101 = v107 
            #endif
#if FABLE_COMPILER_PYTHON
            let v108 : System.DateTime = System.DateTime.Now
            let _v101 = v108 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v109 : System.DateTime = System.DateTime.Now
            let _v101 = v109 
            #endif
#else
            let v110 : System.DateTime = System.DateTime.Now
            let _v101 = v110 
            #endif
            let v111 : System.DateTime = _v101 
            v111
        | US2_0(v24) -> (* Some *)
            let v25 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v26 : System.DateTime = System.DateTime.Now
            let _v25 = v26 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v27 : System.DateTime = System.DateTime.Now
            let _v25 = v27 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v28 : System.DateTime = null |> unbox<System.DateTime>
            let _v25 = v28 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v31 : System.DateTime = System.DateTime.Now
            let _v25 = v31 
            #endif
#if FABLE_COMPILER_PYTHON
            let v32 : System.DateTime = System.DateTime.Now
            let _v25 = v32 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v33 : System.DateTime = System.DateTime.Now
            let _v25 = v33 
            #endif
#else
            let v34 : System.DateTime = System.DateTime.Now
            let _v25 = v34 
            #endif
            let v35 : System.DateTime = _v25 
            let v40 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v41 : (System.DateTime -> int64) = _.Ticks
            let v42 : int64 = v41 v35
            let _v40 = v42 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v43 : (System.DateTime -> int64) = _.Ticks
            let v44 : int64 = v43 v35
            let _v40 = v44 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v45 : int64 = null |> unbox<int64>
            let _v40 = v45 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v48 : (System.DateTime -> int64) = _.Ticks
            let v49 : int64 = v48 v35
            let _v40 = v49 
            #endif
#if FABLE_COMPILER_PYTHON
            let v50 : (System.DateTime -> int64) = _.Ticks
            let v51 : int64 = v50 v35
            let _v40 = v51 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v52 : (System.DateTime -> int64) = _.Ticks
            let v53 : int64 = v52 v35
            let _v40 = v53 
            #endif
#else
            let v54 : (System.DateTime -> int64) = _.Ticks
            let v55 : int64 = v54 v35
            let _v40 = v55 
            #endif
            let v56 : int64 = _v40 
            let v73 : int64 = v56 |> int64 
            let v76 : int64 = v73 - v24
            let v77 : System.TimeSpan = v76 |> System.TimeSpan 
            let v82 : (System.TimeSpan -> int32) = _.Hours
            let v83 : int32 = v82 v77
            let v86 : (System.TimeSpan -> int32) = _.Minutes
            let v87 : int32 = v86 v77
            let v90 : (System.TimeSpan -> int32) = _.Seconds
            let v91 : int32 = v90 v77
            let v94 : (System.TimeSpan -> int32) = _.Milliseconds
            let v95 : int32 = v94 v77
            let v98 : System.DateTime = System.DateTime (1, 1, 1, v83, v87, v91, v95)
            v98
    let v118 : string = method10()
    let v121 : bool = v118 = ""
    let v123 : string =
        if v121 then
            let v122 : string = "M-d-y hh:mm:ss tt"
            v122
        else
            v118
    let v124 : (string -> string) = v117.ToString
    let v125 : string = v124 v123
    let _v6 = v125 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v139 : (int64 -> US2) = method9()
    let v140 : US2 option = v5 |> Option.map v139 
    let v151 : US2 = US2_1
    let v152 : US2 = v140 |> Option.defaultValue v151 
    let v249 : System.DateTime =
        match v152 with
        | US2_1 -> (* None *)
            let v233 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v234 : System.DateTime = System.DateTime.Now
            let _v233 = v234 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v235 : System.DateTime = System.DateTime.Now
            let _v233 = v235 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v236 : System.DateTime = null |> unbox<System.DateTime>
            let _v233 = v236 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v239 : System.DateTime = System.DateTime.Now
            let _v233 = v239 
            #endif
#if FABLE_COMPILER_PYTHON
            let v240 : System.DateTime = System.DateTime.Now
            let _v233 = v240 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v241 : System.DateTime = System.DateTime.Now
            let _v233 = v241 
            #endif
#else
            let v242 : System.DateTime = System.DateTime.Now
            let _v233 = v242 
            #endif
            let v243 : System.DateTime = _v233 
            v243
        | US2_0(v156) -> (* Some *)
            let v157 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v158 : System.DateTime = System.DateTime.Now
            let _v157 = v158 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v159 : System.DateTime = System.DateTime.Now
            let _v157 = v159 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v160 : System.DateTime = null |> unbox<System.DateTime>
            let _v157 = v160 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v163 : System.DateTime = System.DateTime.Now
            let _v157 = v163 
            #endif
#if FABLE_COMPILER_PYTHON
            let v164 : System.DateTime = System.DateTime.Now
            let _v157 = v164 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v165 : System.DateTime = System.DateTime.Now
            let _v157 = v165 
            #endif
#else
            let v166 : System.DateTime = System.DateTime.Now
            let _v157 = v166 
            #endif
            let v167 : System.DateTime = _v157 
            let v172 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v173 : (System.DateTime -> int64) = _.Ticks
            let v174 : int64 = v173 v167
            let _v172 = v174 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v175 : (System.DateTime -> int64) = _.Ticks
            let v176 : int64 = v175 v167
            let _v172 = v176 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v177 : int64 = null |> unbox<int64>
            let _v172 = v177 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v180 : (System.DateTime -> int64) = _.Ticks
            let v181 : int64 = v180 v167
            let _v172 = v181 
            #endif
#if FABLE_COMPILER_PYTHON
            let v182 : (System.DateTime -> int64) = _.Ticks
            let v183 : int64 = v182 v167
            let _v172 = v183 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v184 : (System.DateTime -> int64) = _.Ticks
            let v185 : int64 = v184 v167
            let _v172 = v185 
            #endif
#else
            let v186 : (System.DateTime -> int64) = _.Ticks
            let v187 : int64 = v186 v167
            let _v172 = v187 
            #endif
            let v188 : int64 = _v172 
            let v205 : int64 = v188 |> int64 
            let v208 : int64 = v205 - v156
            let v209 : System.TimeSpan = v208 |> System.TimeSpan 
            let v214 : (System.TimeSpan -> int32) = _.Hours
            let v215 : int32 = v214 v209
            let v218 : (System.TimeSpan -> int32) = _.Minutes
            let v219 : int32 = v218 v209
            let v222 : (System.TimeSpan -> int32) = _.Seconds
            let v223 : int32 = v222 v209
            let v226 : (System.TimeSpan -> int32) = _.Milliseconds
            let v227 : int32 = v226 v209
            let v230 : System.DateTime = System.DateTime (1, 1, 1, v215, v219, v223, v227)
            v230
    let v250 : string = method10()
    let v253 : bool = v250 = ""
    let v255 : string =
        if v253 then
            let v254 : string = "M-d-y hh:mm:ss tt"
            v254
        else
            v250
    let v256 : (string -> string) = v249.ToString
    let v257 : string = v256 v255
    let _v6 = v257 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v271 : string = $"near_sdk::env::block_timestamp()"
    let v272 : uint64 = Fable.Core.RustInterop.emitRustExpr () v271 
    let v273 : (int64 -> US2) = method9()
    let v274 : US2 option = v5 |> Option.map v273 
    let v285 : US2 = US2_1
    let v286 : US2 = v274 |> Option.defaultValue v285 
    let v297 : uint64 =
        match v286 with
        | US2_1 -> (* None *)
            v272
        | US2_0(v290) -> (* Some *)
            let v291 : (int64 -> uint64) = uint64
            let v292 : uint64 = v291 v290
            let v295 : uint64 = v272 - v292
            v295
    let v298 : uint64 = v297 / 1000000000UL
    let v299 : uint64 = v298 % 60UL
    let v300 : uint64 = v298 / 60UL
    let v301 : uint64 = v300 % 60UL
    let v302 : uint64 = v298 / 3600UL
    let v303 : uint64 = v302 % 24UL
    let v304 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v305 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v303, v301, v299) v304 
    let v306 : string = "fable_library_rust::String_::fromString($0)"
    let v307 : string = Fable.Core.RustInterop.emitRustExpr v305 v306 
    let _v6 = v307 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v308 : (int64 -> US2) = method9()
    let v309 : US2 option = v5 |> Option.map v308 
    let v320 : US2 = US2_1
    let v321 : US2 = v309 |> Option.defaultValue v320 
    let v418 : System.DateTime =
        match v321 with
        | US2_1 -> (* None *)
            let v402 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v403 : System.DateTime = System.DateTime.Now
            let _v402 = v403 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v404 : System.DateTime = System.DateTime.Now
            let _v402 = v404 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v405 : System.DateTime = null |> unbox<System.DateTime>
            let _v402 = v405 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v408 : System.DateTime = System.DateTime.Now
            let _v402 = v408 
            #endif
#if FABLE_COMPILER_PYTHON
            let v409 : System.DateTime = System.DateTime.Now
            let _v402 = v409 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v410 : System.DateTime = System.DateTime.Now
            let _v402 = v410 
            #endif
#else
            let v411 : System.DateTime = System.DateTime.Now
            let _v402 = v411 
            #endif
            let v412 : System.DateTime = _v402 
            v412
        | US2_0(v325) -> (* Some *)
            let v326 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v327 : System.DateTime = System.DateTime.Now
            let _v326 = v327 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v328 : System.DateTime = System.DateTime.Now
            let _v326 = v328 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v329 : System.DateTime = null |> unbox<System.DateTime>
            let _v326 = v329 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v332 : System.DateTime = System.DateTime.Now
            let _v326 = v332 
            #endif
#if FABLE_COMPILER_PYTHON
            let v333 : System.DateTime = System.DateTime.Now
            let _v326 = v333 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v334 : System.DateTime = System.DateTime.Now
            let _v326 = v334 
            #endif
#else
            let v335 : System.DateTime = System.DateTime.Now
            let _v326 = v335 
            #endif
            let v336 : System.DateTime = _v326 
            let v341 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v342 : (System.DateTime -> int64) = _.Ticks
            let v343 : int64 = v342 v336
            let _v341 = v343 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v344 : (System.DateTime -> int64) = _.Ticks
            let v345 : int64 = v344 v336
            let _v341 = v345 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v346 : int64 = null |> unbox<int64>
            let _v341 = v346 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v349 : (System.DateTime -> int64) = _.Ticks
            let v350 : int64 = v349 v336
            let _v341 = v350 
            #endif
#if FABLE_COMPILER_PYTHON
            let v351 : (System.DateTime -> int64) = _.Ticks
            let v352 : int64 = v351 v336
            let _v341 = v352 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v353 : (System.DateTime -> int64) = _.Ticks
            let v354 : int64 = v353 v336
            let _v341 = v354 
            #endif
#else
            let v355 : (System.DateTime -> int64) = _.Ticks
            let v356 : int64 = v355 v336
            let _v341 = v356 
            #endif
            let v357 : int64 = _v341 
            let v374 : int64 = v357 |> int64 
            let v377 : int64 = v374 - v325
            let v378 : System.TimeSpan = v377 |> System.TimeSpan 
            let v383 : (System.TimeSpan -> int32) = _.Hours
            let v384 : int32 = v383 v378
            let v387 : (System.TimeSpan -> int32) = _.Minutes
            let v388 : int32 = v387 v378
            let v391 : (System.TimeSpan -> int32) = _.Seconds
            let v392 : int32 = v391 v378
            let v395 : (System.TimeSpan -> int32) = _.Milliseconds
            let v396 : int32 = v395 v378
            let v399 : System.DateTime = System.DateTime (1, 1, 1, v384, v388, v392, v396)
            v399
    let v419 : string = method11()
    let v422 : bool = v419 = ""
    let v424 : string =
        if v422 then
            let v423 : string = "M-d-y hh:mm:ss tt"
            v423
        else
            v419
    let v425 : (string -> string) = v418.ToString
    let v426 : string = v425 v424
    let _v6 = v426 
    #endif
#if FABLE_COMPILER_PYTHON
    let v440 : (int64 -> US2) = method9()
    let v441 : US2 option = v5 |> Option.map v440 
    let v452 : US2 = US2_1
    let v453 : US2 = v441 |> Option.defaultValue v452 
    let v550 : System.DateTime =
        match v453 with
        | US2_1 -> (* None *)
            let v534 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v535 : System.DateTime = System.DateTime.Now
            let _v534 = v535 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v536 : System.DateTime = System.DateTime.Now
            let _v534 = v536 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v537 : System.DateTime = null |> unbox<System.DateTime>
            let _v534 = v537 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v540 : System.DateTime = System.DateTime.Now
            let _v534 = v540 
            #endif
#if FABLE_COMPILER_PYTHON
            let v541 : System.DateTime = System.DateTime.Now
            let _v534 = v541 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v542 : System.DateTime = System.DateTime.Now
            let _v534 = v542 
            #endif
#else
            let v543 : System.DateTime = System.DateTime.Now
            let _v534 = v543 
            #endif
            let v544 : System.DateTime = _v534 
            v544
        | US2_0(v457) -> (* Some *)
            let v458 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v459 : System.DateTime = System.DateTime.Now
            let _v458 = v459 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v460 : System.DateTime = System.DateTime.Now
            let _v458 = v460 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v461 : System.DateTime = null |> unbox<System.DateTime>
            let _v458 = v461 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v464 : System.DateTime = System.DateTime.Now
            let _v458 = v464 
            #endif
#if FABLE_COMPILER_PYTHON
            let v465 : System.DateTime = System.DateTime.Now
            let _v458 = v465 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v466 : System.DateTime = System.DateTime.Now
            let _v458 = v466 
            #endif
#else
            let v467 : System.DateTime = System.DateTime.Now
            let _v458 = v467 
            #endif
            let v468 : System.DateTime = _v458 
            let v473 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v474 : (System.DateTime -> int64) = _.Ticks
            let v475 : int64 = v474 v468
            let _v473 = v475 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v476 : (System.DateTime -> int64) = _.Ticks
            let v477 : int64 = v476 v468
            let _v473 = v477 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v478 : int64 = null |> unbox<int64>
            let _v473 = v478 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v481 : (System.DateTime -> int64) = _.Ticks
            let v482 : int64 = v481 v468
            let _v473 = v482 
            #endif
#if FABLE_COMPILER_PYTHON
            let v483 : (System.DateTime -> int64) = _.Ticks
            let v484 : int64 = v483 v468
            let _v473 = v484 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v485 : (System.DateTime -> int64) = _.Ticks
            let v486 : int64 = v485 v468
            let _v473 = v486 
            #endif
#else
            let v487 : (System.DateTime -> int64) = _.Ticks
            let v488 : int64 = v487 v468
            let _v473 = v488 
            #endif
            let v489 : int64 = _v473 
            let v506 : int64 = v489 |> int64 
            let v509 : int64 = v506 - v457
            let v510 : System.TimeSpan = v509 |> System.TimeSpan 
            let v515 : (System.TimeSpan -> int32) = _.Hours
            let v516 : int32 = v515 v510
            let v519 : (System.TimeSpan -> int32) = _.Minutes
            let v520 : int32 = v519 v510
            let v523 : (System.TimeSpan -> int32) = _.Seconds
            let v524 : int32 = v523 v510
            let v527 : (System.TimeSpan -> int32) = _.Milliseconds
            let v528 : int32 = v527 v510
            let v531 : System.DateTime = System.DateTime (1, 1, 1, v516, v520, v524, v528)
            v531
    let v551 : string = method11()
    let v554 : bool = v551 = ""
    let v556 : string =
        if v554 then
            let v555 : string = "M-d-y hh:mm:ss tt"
            v555
        else
            v551
    let v557 : (string -> string) = v550.ToString
    let v558 : string = v557 v556
    let _v6 = v558 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v572 : (int64 -> US2) = method9()
    let v573 : US2 option = v5 |> Option.map v572 
    let v584 : US2 = US2_1
    let v585 : US2 = v573 |> Option.defaultValue v584 
    let v682 : System.DateTime =
        match v585 with
        | US2_1 -> (* None *)
            let v666 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v667 : System.DateTime = System.DateTime.Now
            let _v666 = v667 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v668 : System.DateTime = System.DateTime.Now
            let _v666 = v668 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v669 : System.DateTime = null |> unbox<System.DateTime>
            let _v666 = v669 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v672 : System.DateTime = System.DateTime.Now
            let _v666 = v672 
            #endif
#if FABLE_COMPILER_PYTHON
            let v673 : System.DateTime = System.DateTime.Now
            let _v666 = v673 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v674 : System.DateTime = System.DateTime.Now
            let _v666 = v674 
            #endif
#else
            let v675 : System.DateTime = System.DateTime.Now
            let _v666 = v675 
            #endif
            let v676 : System.DateTime = _v666 
            v676
        | US2_0(v589) -> (* Some *)
            let v590 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v591 : System.DateTime = System.DateTime.Now
            let _v590 = v591 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v592 : System.DateTime = System.DateTime.Now
            let _v590 = v592 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v593 : System.DateTime = null |> unbox<System.DateTime>
            let _v590 = v593 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v596 : System.DateTime = System.DateTime.Now
            let _v590 = v596 
            #endif
#if FABLE_COMPILER_PYTHON
            let v597 : System.DateTime = System.DateTime.Now
            let _v590 = v597 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v598 : System.DateTime = System.DateTime.Now
            let _v590 = v598 
            #endif
#else
            let v599 : System.DateTime = System.DateTime.Now
            let _v590 = v599 
            #endif
            let v600 : System.DateTime = _v590 
            let v605 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v606 : (System.DateTime -> int64) = _.Ticks
            let v607 : int64 = v606 v600
            let _v605 = v607 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v608 : (System.DateTime -> int64) = _.Ticks
            let v609 : int64 = v608 v600
            let _v605 = v609 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v610 : int64 = null |> unbox<int64>
            let _v605 = v610 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v613 : (System.DateTime -> int64) = _.Ticks
            let v614 : int64 = v613 v600
            let _v605 = v614 
            #endif
#if FABLE_COMPILER_PYTHON
            let v615 : (System.DateTime -> int64) = _.Ticks
            let v616 : int64 = v615 v600
            let _v605 = v616 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v617 : (System.DateTime -> int64) = _.Ticks
            let v618 : int64 = v617 v600
            let _v605 = v618 
            #endif
#else
            let v619 : (System.DateTime -> int64) = _.Ticks
            let v620 : int64 = v619 v600
            let _v605 = v620 
            #endif
            let v621 : int64 = _v605 
            let v638 : int64 = v621 |> int64 
            let v641 : int64 = v638 - v589
            let v642 : System.TimeSpan = v641 |> System.TimeSpan 
            let v647 : (System.TimeSpan -> int32) = _.Hours
            let v648 : int32 = v647 v642
            let v651 : (System.TimeSpan -> int32) = _.Minutes
            let v652 : int32 = v651 v642
            let v655 : (System.TimeSpan -> int32) = _.Seconds
            let v656 : int32 = v655 v642
            let v659 : (System.TimeSpan -> int32) = _.Milliseconds
            let v660 : int32 = v659 v642
            let v663 : System.DateTime = System.DateTime (1, 1, 1, v648, v652, v656, v660)
            v663
    let v683 : string = method11()
    let v686 : bool = v683 = ""
    let v688 : string =
        if v686 then
            let v687 : string = "M-d-y hh:mm:ss tt"
            v687
        else
            v683
    let v689 : (string -> string) = v682.ToString
    let v690 : string = v689 v688
    let _v6 = v690 
    #endif
#else
    let v704 : (int64 -> US2) = method9()
    let v705 : US2 option = v5 |> Option.map v704 
    let v716 : US2 = US2_1
    let v717 : US2 = v705 |> Option.defaultValue v716 
    let v814 : System.DateTime =
        match v717 with
        | US2_1 -> (* None *)
            let v798 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v799 : System.DateTime = System.DateTime.Now
            let _v798 = v799 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v800 : System.DateTime = System.DateTime.Now
            let _v798 = v800 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v801 : System.DateTime = null |> unbox<System.DateTime>
            let _v798 = v801 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v804 : System.DateTime = System.DateTime.Now
            let _v798 = v804 
            #endif
#if FABLE_COMPILER_PYTHON
            let v805 : System.DateTime = System.DateTime.Now
            let _v798 = v805 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v806 : System.DateTime = System.DateTime.Now
            let _v798 = v806 
            #endif
#else
            let v807 : System.DateTime = System.DateTime.Now
            let _v798 = v807 
            #endif
            let v808 : System.DateTime = _v798 
            v808
        | US2_0(v721) -> (* Some *)
            let v722 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v723 : System.DateTime = System.DateTime.Now
            let _v722 = v723 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v724 : System.DateTime = System.DateTime.Now
            let _v722 = v724 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v725 : System.DateTime = null |> unbox<System.DateTime>
            let _v722 = v725 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v728 : System.DateTime = System.DateTime.Now
            let _v722 = v728 
            #endif
#if FABLE_COMPILER_PYTHON
            let v729 : System.DateTime = System.DateTime.Now
            let _v722 = v729 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v730 : System.DateTime = System.DateTime.Now
            let _v722 = v730 
            #endif
#else
            let v731 : System.DateTime = System.DateTime.Now
            let _v722 = v731 
            #endif
            let v732 : System.DateTime = _v722 
            let v737 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v738 : (System.DateTime -> int64) = _.Ticks
            let v739 : int64 = v738 v732
            let _v737 = v739 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v740 : (System.DateTime -> int64) = _.Ticks
            let v741 : int64 = v740 v732
            let _v737 = v741 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v742 : int64 = null |> unbox<int64>
            let _v737 = v742 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v745 : (System.DateTime -> int64) = _.Ticks
            let v746 : int64 = v745 v732
            let _v737 = v746 
            #endif
#if FABLE_COMPILER_PYTHON
            let v747 : (System.DateTime -> int64) = _.Ticks
            let v748 : int64 = v747 v732
            let _v737 = v748 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v749 : (System.DateTime -> int64) = _.Ticks
            let v750 : int64 = v749 v732
            let _v737 = v750 
            #endif
#else
            let v751 : (System.DateTime -> int64) = _.Ticks
            let v752 : int64 = v751 v732
            let _v737 = v752 
            #endif
            let v753 : int64 = _v737 
            let v770 : int64 = v753 |> int64 
            let v773 : int64 = v770 - v721
            let v774 : System.TimeSpan = v773 |> System.TimeSpan 
            let v779 : (System.TimeSpan -> int32) = _.Hours
            let v780 : int32 = v779 v774
            let v783 : (System.TimeSpan -> int32) = _.Minutes
            let v784 : int32 = v783 v774
            let v787 : (System.TimeSpan -> int32) = _.Seconds
            let v788 : int32 = v787 v774
            let v791 : (System.TimeSpan -> int32) = _.Milliseconds
            let v792 : int32 = v791 v774
            let v795 : System.DateTime = System.DateTime (1, 1, 1, v780, v784, v788, v792)
            v795
    let v815 : string = method11()
    let v818 : bool = v815 = ""
    let v820 : string =
        if v818 then
            let v819 : string = "M-d-y hh:mm:ss tt"
            v819
        else
            v815
    let v821 : (string -> string) = v814.ToString
    let v822 : string = v821 v820
    let _v6 = v822 
    #endif
    let v836 : string = _v6 
    v836
and method14 () : string =
    let v0 : string = ""
    v0
and closure8 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method13 (v0 : char) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure8(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method15 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method12 () : string =
    
    
    
    
    
    let v0 : string = "Info"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method13(v5)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "inline_colorization::color_bright_green"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v11 
    let _v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v13 
    let _v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v15 
    let _v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v23 
    #endif
#else
    let v26 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v26 
    #endif
    let v29 : Ref<Str> = _v10 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9, v29, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v7 = v39 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v40 : string = "inline_colorization::color_bright_green"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v43 : string = "&*$0"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v43 
    let _v42 = v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : string = "&*$0"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v45 
    let _v42 = v46 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v47 : string = "&*$0"
    let v48 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v47 
    let _v42 = v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v49 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v49 
    #endif
#if FABLE_COMPILER_PYTHON
    let v52 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v52 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v55 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v55 
    #endif
#else
    let v58 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v58 
    #endif
    let v61 : Ref<Str> = _v42 
    let v66 : string = "inline_colorization::color_reset"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v61, v67) v68 
    let v70 : string = "fable_library_rust::String_::fromString($0)"
    let v71 : string = Fable.Core.RustInterop.emitRustExpr v69 v70 
    let _v7 = v71 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v72 : string = "inline_colorization::color_bright_green"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v75 : string = "&*$0"
    let v76 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v75 
    let _v74 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "&*$0"
    let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v77 
    let _v74 = v78 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : string = "&*$0"
    let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v79 
    let _v74 = v80 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v81 
    #endif
#if FABLE_COMPILER_PYTHON
    let v84 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v84 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v87 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v87 
    #endif
#else
    let v90 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v90 
    #endif
    let v93 : Ref<Str> = _v74 
    let v98 : string = "inline_colorization::color_reset"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v98 
    let v100 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v73, v93, v99) v100 
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let _v7 = v103 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v104 : string = "\u001b[92m"
    let v105 : string = method15()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[92m"
    let v109 : string = method15()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[92m"
    let v113 : string = method15()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[92m"
    let v117 : string = method15()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method17 (v0 : (string [])) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure8(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "args"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure8(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure8(v2, v22)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : string = $"%A{v0}"
    let v33 : string = $"{v30}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure8(v2, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v41 : string = " }"
    let v42 : string = $"{v41}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure8(v2, v42)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v50 : string = v2.l0
    v50
and method18 (v0 : string) : string =
    let v1 : char list = []
    let v2 : (char list -> (char [])) = List.toArray
    let v3 : (char []) = v2 v1
    let v6 : string = v0.TrimStart v3 
    let v30 : char list = []
    let v31 : char list = '/' :: v30 
    let v34 : char list = ' ' :: v31 
    let v37 : (char list -> (char [])) = List.toArray
    let v38 : (char []) = v37 v34
    let v41 : string = v6.TrimEnd v38 
    v41
and method16 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : (string [])) : string =
    let v9 : string = method17(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "documents.main"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method18(v12)
and closure9 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure11 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure10 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure11(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and method19 (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure9(v17)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : (string -> unit) = closure10()
    let v41 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v42 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v42 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v43 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v43 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v44 : string = v20.l0
    let v45 : bool = v44 = ""
    let v53 : string =
        if v45 then
            v0
        else
            let v46 : bool = v0 = ""
            if v46 then
                let v47 : string = v20.l0
                v47
            else
                let v48 : string = v20.l0
                let v49 : string = "\n"
                let v50 : string = v48 + v49 
                let v51 : string = v50 + v0 
                v51
    let v54 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v55 : string = "&*$0"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v55 
    let _v54 = v56 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v57 : string = "&*$0"
    let v58 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v57 
    let _v54 = v58 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v59 : string = "&*$0"
    let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v59 
    let _v54 = v60 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v61 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v61 
    #endif
#if FABLE_COMPILER_PYTHON
    let v64 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v64 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v67 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v67 
    #endif
#else
    let v70 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v70 
    #endif
    let v73 : Ref<Str> = _v54 
    let v78 : string = $"$0.chars()"
    let v79 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v73 v78 
    let v80 : string = "$0"
    let v81 : _ = Fable.Core.RustInterop.emitRustExpr v79 v80 
    let v82 : string = "$0.collect::<Vec<_>>()"
    let v83 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v81 v82 
    let v84 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v85 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v83 v84 
    let v86 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v87 : bool = Fable.Core.RustInterop.emitRustExpr v85 v86 
    let v88 : string = "x"
    let v89 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v88 
    let v90 : string = "String::from_iter($0)"
    let v91 : std_string_String = Fable.Core.RustInterop.emitRustExpr v89 v90 
    let v92 : string = "true; $0 }).collect::<Vec<_>>()"
    let v93 : bool = Fable.Core.RustInterop.emitRustExpr v91 v92 
    let v94 : string = "_vec_map"
    let v95 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v94 
    let v96 : string = "$0.len()"
    let v97 : unativeint = Fable.Core.RustInterop.emitRustExpr v95 v96 
    let v98 : int32 = v97 |> int32 
    let v105 : string = ""
    let v106 : bool = v0 <> v105 
    let v110 : bool =
        if v106 then
            let v109 : bool = v98 <= 1
            v109
        else
            false
    if v110 then
        v20.l0 <- v53
        ()
    else
        v20.l0 <- v105
        let v111 : string = "true; $0.into_iter().for_each(|x| { //"
        let v112 : bool = Fable.Core.RustInterop.emitRustExpr v95 v111 
        let v113 : string = "x"
        let v114 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v113 
        let v115 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v116 : bool = Fable.Core.RustInterop.emitRustExpr v114 v115 
        let v117 : string = $"true"
        let v118 : bool = Fable.Core.RustInterop.emitRustExpr () v117 
        let v119 : string = "true; }); //"
        let v120 : bool = Fable.Core.RustInterop.emitRustExpr () v119 
        ()
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v40 v0
    #endif
#if FABLE_COMPILER_PYTHON
    v40 v0
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v40 v0
    #endif
#else
    v40 v0
    #endif
    // run_target_args' is_unit
    let v121 : (string -> unit) = v18.l0
    v121 v0
and closure5 (v0 : (string [])) () : unit =
    let v1 : US0 = US0_2
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method8(v19, v20, v21, v22, v23, v24)
        let v38 : string = method12()
        let v39 : string = method16(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method19(v39)
and method20 () : string =
    let v0 : string = "source-dir"
    v0
and closure12 () (v0 : std_string_String) : US6 =
    US6_0(v0)
and method21 () : (std_string_String -> US6) =
    closure12()
and method22 () : string =
    let v0 : string = "dist-dir"
    v0
and method23 () : string =
    let v0 : string = "cache-dir"
    v0
and method24 () : string =
    let v0 : string = "hangul-spec"
    v0
and method26 (v0 : string, v1 : string) : string =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let _v3 = v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "&*$0"
    let v7 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v6 
    let _v3 = v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "&*$0"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v8 
    let _v3 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v10 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v3 = v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v13 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v3 = v13 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v16 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v3 = v16 
    #endif
#else
    let v19 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v3 = v19 
    #endif
    let v22 : Ref<Str> = _v3 
    let v27 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = "String::from($0)"
    let v29 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v28 
    let _v27 = v29 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = "String::from($0)"
    let v31 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v30 
    let _v27 = v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "String::from($0)"
    let v33 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v32 
    let _v27 = v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v34 : std_string_String = v22 |> unbox<std_string_String>
    let _v27 = v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v37 : std_string_String = v22 |> unbox<std_string_String>
    let _v27 = v37 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v40 : std_string_String = v22 |> unbox<std_string_String>
    let _v27 = v40 
    #endif
#else
    let v43 : std_string_String = v22 |> unbox<std_string_String>
    let _v27 = v43 
    #endif
    let v46 : std_string_String = _v27 
    let v51 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v52 : string = "std::path::PathBuf::from($0)"
    let v53 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v46 v52 
    let _v51 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "std::path::PathBuf::from($0)"
    let v55 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v46 v54 
    let _v51 = v55 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v56 : string = "std::path::PathBuf::from($0)"
    let v57 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v46 v56 
    let _v51 = v57 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v58 : std_path_PathBuf = v46 |> unbox<std_path_PathBuf>
    let _v51 = v58 
    #endif
#if FABLE_COMPILER_PYTHON
    let v61 : std_path_PathBuf = v46 |> unbox<std_path_PathBuf>
    let _v51 = v61 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v64 : std_path_PathBuf = v46 |> unbox<std_path_PathBuf>
    let _v51 = v64 
    #endif
#else
    let v67 : std_path_PathBuf = v46 |> unbox<std_path_PathBuf>
    let _v51 = v67 
    #endif
    let v70 : std_path_PathBuf = _v51 
    let v75 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v76 : string = "&*$0"
    let v77 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v76 
    let _v75 = v77 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v78 : string = "&*$0"
    let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v78 
    let _v75 = v79 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v80 : string = "&*$0"
    let v81 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v80 
    let _v75 = v81 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v82 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let _v75 = v82 
    #endif
#if FABLE_COMPILER_PYTHON
    let v85 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let _v75 = v85 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v88 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let _v75 = v88 
    #endif
#else
    let v91 : Ref<Str> = v1 |> unbox<Ref<Str>>
    let _v75 = v91 
    #endif
    let v94 : Ref<Str> = _v75 
    let v99 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v100 : string = "String::from($0)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr v94 v100 
    let _v99 = v101 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v102 : string = "String::from($0)"
    let v103 : std_string_String = Fable.Core.RustInterop.emitRustExpr v94 v102 
    let _v99 = v103 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v104 : string = "String::from($0)"
    let v105 : std_string_String = Fable.Core.RustInterop.emitRustExpr v94 v104 
    let _v99 = v105 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v106 : std_string_String = v94 |> unbox<std_string_String>
    let _v99 = v106 
    #endif
#if FABLE_COMPILER_PYTHON
    let v109 : std_string_String = v94 |> unbox<std_string_String>
    let _v99 = v109 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : std_string_String = v94 |> unbox<std_string_String>
    let _v99 = v112 
    #endif
#else
    let v115 : std_string_String = v94 |> unbox<std_string_String>
    let _v99 = v115 
    #endif
    let v118 : std_string_String = _v99 
    let v123 : string = "$0.join($1)"
    let v124 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v70, v118) v123 
    let v125 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v126 : string = "$0.display()"
    let v127 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v124 v126 
    let _v125 = v127 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v128 : string = "$0.display()"
    let v129 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v124 v128 
    let _v125 = v129 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v130 : string = "$0.display()"
    let v131 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v124 v130 
    let _v125 = v131 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v132 : std_path_Display = v124 |> unbox<std_path_Display>
    let _v125 = v132 
    #endif
#if FABLE_COMPILER_PYTHON
    let v135 : std_path_Display = v124 |> unbox<std_path_Display>
    let _v125 = v135 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v138 : std_path_Display = v124 |> unbox<std_path_Display>
    let _v125 = v138 
    #endif
#else
    let v141 : std_path_Display = v124 |> unbox<std_path_Display>
    let _v125 = v141 
    #endif
    let v144 : std_path_Display = _v125 
    let v149 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v150 : string = "format!(\"{}\", $0)"
    let v151 : std_string_String = Fable.Core.RustInterop.emitRustExpr v144 v150 
    let _v149 = v151 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v152 : string = "format!(\"{}\", $0)"
    let v153 : std_string_String = Fable.Core.RustInterop.emitRustExpr v144 v152 
    let _v149 = v153 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v154 : string = "format!(\"{}\", $0)"
    let v155 : std_string_String = Fable.Core.RustInterop.emitRustExpr v144 v154 
    let _v149 = v155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v156 : std_string_String = null |> unbox<std_string_String>
    let _v149 = v156 
    #endif
#if FABLE_COMPILER_PYTHON
    let v159 : std_string_String = null |> unbox<std_string_String>
    let _v149 = v159 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v162 : std_string_String = null |> unbox<std_string_String>
    let _v149 = v162 
    #endif
#else
    let v165 : std_string_String = null |> unbox<std_string_String>
    let _v149 = v165 
    #endif
    let v168 : std_string_String = _v149 
    let v173 : string = "fable_library_rust::String_::fromString($0)"
    let v174 : string = Fable.Core.RustInterop.emitRustExpr v168 v173 
    let _v2 = v174 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v175 : US3 = US3_1
    let v176 : US4 = US4_2(v175)
    let v177 : string = $"file_system.(</>) / target: {v176} / a: {v0} / b: {v1}"
    let v178 : string = failwith<string> v177
    let _v2 = v178 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v179 : string = null |> unbox<string>
    let _v2 = v179 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v182 : string = "path"
    let v183 : IPathJoin = Fable.Core.JsInterop.importAll v182 
    let v184 : string = "v183.join($0, $1)"
    let v185 : string = Fable.Core.JsInterop.emitJsExpr struct (v0, v1) v184 
    let _v2 = v185 
    #endif
#if FABLE_COMPILER_PYTHON
    let v186 : US3 = US3_0
    let v187 : US4 = US4_4(v186)
    let v188 : string = $"file_system.(</>) / target: {v187} / a: {v0} / b: {v1}"
    let v189 : string = failwith<string> v188
    let _v2 = v189 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v190 : US3 = US3_1
    let v191 : US4 = US4_0(v190)
    let v192 : string = $"file_system.(</>) / target: {v191} / a: {v0} / b: {v1}"
    let v193 : string = failwith<string> v192
    let _v2 = v193 
    #endif
#else
    let v194 : string = System.IO.Path.Combine (v0, v1)
    let _v2 = v194 
    #endif
    let v195 : string = _v2 
    v195
and method28 (v0 : string) : bool =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "&*$0"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let _v2 = v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = "&*$0"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v5 
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = "&*$0"
    let v8 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v7 
    let _v2 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v12 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v12 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v15 
    #endif
#else
    let v18 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v18 
    #endif
    let v21 : Ref<Str> = _v2 
    let v26 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = "String::from($0)"
    let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v27 
    let _v26 = v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "String::from($0)"
    let v30 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v29 
    let _v26 = v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = "String::from($0)"
    let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v31 
    let _v26 = v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v36 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v36 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v39 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v39 
    #endif
#else
    let v42 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v42 
    #endif
    let v45 : std_string_String = _v26 
    let v50 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v51 : string = "std::path::PathBuf::from($0)"
    let v52 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v51 
    let _v50 = v52 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v53 : string = "std::path::PathBuf::from($0)"
    let v54 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v53 
    let _v50 = v54 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v55 : string = "std::path::PathBuf::from($0)"
    let v56 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v55 
    let _v50 = v56 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v57 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v57 
    #endif
#if FABLE_COMPILER_PYTHON
    let v60 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v60 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v63 
    #endif
#else
    let v66 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v66 
    #endif
    let v69 : std_path_PathBuf = _v50 
    let v74 : string = "$0.exists()"
    let v75 : bool = Fable.Core.RustInterop.emitRustExpr v69 v74 
    let v78 : bool =
        if v75 then
            let v76 : string = "$0.is_dir()"
            let v77 : bool = Fable.Core.RustInterop.emitRustExpr v69 v76 
            v77
        else
            false
    let _v1 = v78 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v79 : bool = null |> unbox<bool>
    let _v1 = v79 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v82 : bool = null |> unbox<bool>
    let _v1 = v82 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v85 : string = "fs"
    let v86 : IFsExistsSync = Fable.Core.JsInterop.importAll v85 
    let v87 : string = "$0.existsSync($1)"
    let v88 : bool = Fable.Core.JsInterop.emitJsExpr struct (v86, v0) v87 
    let _v1 = v88 
    #endif
#if FABLE_COMPILER_PYTHON
    let v89 : bool = null |> unbox<bool>
    let _v1 = v89 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v92 : bool = null |> unbox<bool>
    let _v1 = v92 
    #endif
#else
    let v95 : (string -> bool) = System.IO.Directory.Exists
    let v96 : bool = v95 v0
    let _v1 = v96 
    #endif
    let v97 : bool = _v1 
    v97
and method29 (v0 : string) : string option =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "&*$0"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let _v2 = v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = "&*$0"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v5 
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = "&*$0"
    let v8 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v7 
    let _v2 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v12 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v12 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v15 
    #endif
#else
    let v18 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v18 
    #endif
    let v21 : Ref<Str> = _v2 
    let v26 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = "String::from($0)"
    let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v27 
    let _v26 = v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "String::from($0)"
    let v30 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v29 
    let _v26 = v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = "String::from($0)"
    let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v31 
    let _v26 = v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v36 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v36 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v39 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v39 
    #endif
#else
    let v42 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v42 
    #endif
    let v45 : std_string_String = _v26 
    let v50 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v51 : string = "std::path::PathBuf::from($0)"
    let v52 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v51 
    let _v50 = v52 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v53 : string = "std::path::PathBuf::from($0)"
    let v54 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v53 
    let _v50 = v54 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v55 : string = "std::path::PathBuf::from($0)"
    let v56 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v55 
    let _v50 = v56 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v57 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v57 
    #endif
#if FABLE_COMPILER_PYTHON
    let v60 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v60 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v63 
    #endif
#else
    let v66 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v66 
    #endif
    let v69 : std_path_PathBuf = _v50 
    let v74 : string = "$0.parent().map(std::path::PathBuf::from)"
    let v75 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v69 v74 
    let v76 : string = "true; let _optionm_map_ = $0.map(|x| { //"
    let v77 : bool = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let v78 : string = "x"
    let v79 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr () v78 
    let v80 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v81 : string = "$0.display()"
    let v82 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v79 v81 
    let _v80 = v82 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v83 : string = "$0.display()"
    let v84 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v79 v83 
    let _v80 = v84 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v85 : string = "$0.display()"
    let v86 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v79 v85 
    let _v80 = v86 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v87 : std_path_Display = v79 |> unbox<std_path_Display>
    let _v80 = v87 
    #endif
#if FABLE_COMPILER_PYTHON
    let v90 : std_path_Display = v79 |> unbox<std_path_Display>
    let _v80 = v90 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v93 : std_path_Display = v79 |> unbox<std_path_Display>
    let _v80 = v93 
    #endif
#else
    let v96 : std_path_Display = v79 |> unbox<std_path_Display>
    let _v80 = v96 
    #endif
    let v99 : std_path_Display = _v80 
    let v104 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v105 : string = "format!(\"{}\", $0)"
    let v106 : std_string_String = Fable.Core.RustInterop.emitRustExpr v99 v105 
    let _v104 = v106 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v107 : string = "format!(\"{}\", $0)"
    let v108 : std_string_String = Fable.Core.RustInterop.emitRustExpr v99 v107 
    let _v104 = v108 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v109 : string = "format!(\"{}\", $0)"
    let v110 : std_string_String = Fable.Core.RustInterop.emitRustExpr v99 v109 
    let _v104 = v110 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v111 : std_string_String = null |> unbox<std_string_String>
    let _v104 = v111 
    #endif
#if FABLE_COMPILER_PYTHON
    let v114 : std_string_String = null |> unbox<std_string_String>
    let _v104 = v114 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v117 : std_string_String = null |> unbox<std_string_String>
    let _v104 = v117 
    #endif
#else
    let v120 : std_string_String = null |> unbox<std_string_String>
    let _v104 = v120 
    #endif
    let v123 : std_string_String = _v104 
    let v128 : string = "fable_library_rust::String_::fromString($0)"
    let v129 : string = Fable.Core.RustInterop.emitRustExpr v123 v128 
    let v130 : string = "true; $0 })"
    let v131 : bool = Fable.Core.RustInterop.emitRustExpr v129 v130 
    let v132 : string = "_optionm_map_"
    let v133 : string option = Fable.Core.RustInterop.emitRustExpr () v132 
    let _v1 = v133 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v134 : string option = null |> unbox<string option>
    let _v1 = v134 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v137 : string option = null |> unbox<string option>
    let _v1 = v137 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v140 : string = "path"
    let v141 : IPathDirname = Fable.Core.JsInterop.importAll v140 
    let v142 : string = "v141.dirname($0)"
    let v143 : string = Fable.Core.JsInterop.emitJsExpr v0 v142 
    let v144 : string option = Some v143 
    let _v1 = v144 
    #endif
#if FABLE_COMPILER_PYTHON
    let v147 : string option = null |> unbox<string option>
    let _v1 = v147 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v150 : string option = null |> unbox<string option>
    let _v1 = v150 
    #endif
#else
    let v153 : (string -> System_IO_DirectoryInfo) = System.IO.Directory.GetParent
    let v154 : System_IO_DirectoryInfo = v153 v0
    let v155 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let v158 : bool = v154 = v155 
    let v189 : US5 =
        if v158 then
            US5_1
        else
            let v162 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v163 : string = null |> unbox<string>
            let _v162 = v163 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v166 : string = null |> unbox<string>
            let _v162 = v166 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v169 : string = null |> unbox<string>
            let _v162 = v169 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v172 : string = null |> unbox<string>
            let _v162 = v172 
            #endif
#if FABLE_COMPILER_PYTHON
            let v175 : string = null |> unbox<string>
            let _v162 = v175 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v178 : string = null |> unbox<string>
            let _v162 = v178 
            #endif
#else
            let v181 : (System_IO_DirectoryInfo -> string) = _.FullName
            let v182 : string = v181 v154
            let _v162 = v182 
            #endif
            let v183 : string = _v162 
            US5_0(v183)
    let v196 : string option =
        match v189 with
        | US5_1 -> (* None *)
            let v194 : string option = None
            v194
        | US5_0(v190) -> (* Some *)
            let v191 : string option = Some v190 
            v191
    let _v1 = v196 
    #endif
    let v197 : string option = _v1 
    v197
and method30 (v0 : string, v1 : string, v2 : string) : US7 =
    let v3 : string = method26(v2, v0)
    let v4 : bool = method28(v3)
    if v4 then
        US7_0(v2)
    else
        let v6 : string option = method29(v2)
        let v7 : (string -> US5) = method6()
        let v8 : US5 option = v6 |> Option.map v7 
        let v19 : US5 = US5_1
        let v20 : US5 = v8 |> Option.defaultValue v19 
        match v20 with
        | US5_1 -> (* None *)
            let v26 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            US7_1(v26)
        | US5_0(v24) -> (* Some *)
            method30(v0, v1, v24)
and method27 (v0 : string, v1 : string) : US7 =
    let v2 : string = method26(v1, v0)
    let v3 : bool = method28(v2)
    if v3 then
        US7_0(v1)
    else
        let v5 : string option = method29(v1)
        let v6 : (string -> US5) = method6()
        let v7 : US5 option = v5 |> Option.map v6 
        let v18 : US5 = US5_1
        let v19 : US5 = v7 |> Option.defaultValue v18 
        match v19 with
        | US5_1 -> (* None *)
            let v25 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            US7_1(v25)
        | US5_0(v23) -> (* Some *)
            method30(v0, v1, v23)
and method31 () : string =
    
    
    
    
    
    let v0 : string = "Warning"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method13(v5)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "inline_colorization::color_yellow"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v11 
    let _v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v13 
    let _v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v15 
    let _v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v23 
    #endif
#else
    let v26 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v26 
    #endif
    let v29 : Ref<Str> = _v10 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9, v29, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v7 = v39 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v40 : string = "inline_colorization::color_yellow"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v43 : string = "&*$0"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v43 
    let _v42 = v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : string = "&*$0"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v45 
    let _v42 = v46 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v47 : string = "&*$0"
    let v48 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v47 
    let _v42 = v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v49 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v49 
    #endif
#if FABLE_COMPILER_PYTHON
    let v52 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v52 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v55 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v55 
    #endif
#else
    let v58 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v58 
    #endif
    let v61 : Ref<Str> = _v42 
    let v66 : string = "inline_colorization::color_reset"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v61, v67) v68 
    let v70 : string = "fable_library_rust::String_::fromString($0)"
    let v71 : string = Fable.Core.RustInterop.emitRustExpr v69 v70 
    let _v7 = v71 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v72 : string = "inline_colorization::color_yellow"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v75 : string = "&*$0"
    let v76 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v75 
    let _v74 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "&*$0"
    let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v77 
    let _v74 = v78 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : string = "&*$0"
    let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v79 
    let _v74 = v80 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v81 
    #endif
#if FABLE_COMPILER_PYTHON
    let v84 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v84 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v87 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v87 
    #endif
#else
    let v90 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v90 
    #endif
    let v93 : Ref<Str> = _v74 
    let v98 : string = "inline_colorization::color_reset"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v98 
    let v100 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v73, v93, v99) v100 
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let _v7 = v103 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v104 : string = "\u001b[93m"
    let v105 : string = method15()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[93m"
    let v109 : string = method15()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[93m"
    let v113 : string = method15()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[93m"
    let v117 : string = method15()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method33 (v0 : string) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure8(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "error"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure8(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure8(v2, v22)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : string = $"{v0}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure8(v2, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v38 : string = " }"
    let v39 : string = $"{v38}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure8(v2, v39)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v47 : string = v2.l0
    v47
and method32 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method33(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "file_system.get_workspace_root"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method18(v12)
and closure13 (v0 : string) () : unit =
    let v1 : US0 = US0_3
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method8(v19, v20, v21, v22, v23, v24)
        let v38 : string = method31()
        let v39 : string = method32(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method19(v39)
and method34 () : string =
    let v0 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = "std::env::current_dir()"
    let v2 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "$0.unwrap()"
    let v5 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v2 v4 
    let _v3 = v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "$0.unwrap()"
    let v7 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v2 v6 
    let _v3 = v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "$0.unwrap()"
    let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v2 v8 
    let _v3 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v10 : std_path_PathBuf = match v2 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v3 = v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : std_path_PathBuf = match v2 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v3 = v11 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v12 : std_path_PathBuf = match v2 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v3 = v12 
    #endif
#else
    let v13 : std_path_PathBuf = match v2 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v3 = v13 
    #endif
    let v14 : std_path_PathBuf = _v3 
    let v17 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = "$0.display()"
    let v19 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v14 v18 
    let _v17 = v19 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = "$0.display()"
    let v21 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v14 v20 
    let _v17 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = "$0.display()"
    let v23 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v14 v22 
    let _v17 = v23 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v24 : std_path_Display = v14 |> unbox<std_path_Display>
    let _v17 = v24 
    #endif
#if FABLE_COMPILER_PYTHON
    let v27 : std_path_Display = v14 |> unbox<std_path_Display>
    let _v17 = v27 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v30 : std_path_Display = v14 |> unbox<std_path_Display>
    let _v17 = v30 
    #endif
#else
    let v33 : std_path_Display = v14 |> unbox<std_path_Display>
    let _v17 = v33 
    #endif
    let v36 : std_path_Display = _v17 
    let v41 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v42 : string = "format!(\"{}\", $0)"
    let v43 : std_string_String = Fable.Core.RustInterop.emitRustExpr v36 v42 
    let _v41 = v43 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v44 : string = "format!(\"{}\", $0)"
    let v45 : std_string_String = Fable.Core.RustInterop.emitRustExpr v36 v44 
    let _v41 = v45 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v46 : string = "format!(\"{}\", $0)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr v36 v46 
    let _v41 = v47 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v48 : std_string_String = null |> unbox<std_string_String>
    let _v41 = v48 
    #endif
#if FABLE_COMPILER_PYTHON
    let v51 : std_string_String = null |> unbox<std_string_String>
    let _v41 = v51 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v54 : std_string_String = null |> unbox<std_string_String>
    let _v41 = v54 
    #endif
#else
    let v57 : std_string_String = null |> unbox<std_string_String>
    let _v41 = v57 
    #endif
    let v60 : std_string_String = _v41 
    let v65 : string = "fable_library_rust::String_::fromString($0)"
    let v66 : string = Fable.Core.RustInterop.emitRustExpr v60 v65 
    let _v0 = v66 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v67 : string = null |> unbox<string>
    let _v0 = v67 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v70 : string = null |> unbox<string>
    let _v0 = v70 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v73 : string = null |> unbox<string>
    let _v0 = v73 
    #endif
#if FABLE_COMPILER_PYTHON
    let v76 : string = null |> unbox<string>
    let _v0 = v76 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v79 : string = null |> unbox<string>
    let _v0 = v79 
    #endif
#else
    let v82 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v83 : string = v82 ()
    let _v0 = v83 
    #endif
    let v84 : string = _v0 
    v84
and method40 (v0 : std_io_Error) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "format!(\"{:#?}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let v6 : string = "fable_library_rust::String_::fromString($0)"
    let v7 : string = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let _v3 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : string = "format!(\"{:#?}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    let v10 : string = "fable_library_rust::String_::fromString($0)"
    let v11 : string = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let _v3 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = "format!(\"{:#?}\", $0)"
    let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v12 
    let v14 : string = "fable_library_rust::String_::fromString($0)"
    let v15 : string = Fable.Core.RustInterop.emitRustExpr v13 v14 
    let _v3 = v15 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v16 : string = $"%A{v0}"
    let _v3 = v16 
    #endif
#if FABLE_COMPILER_PYTHON
    let v19 : string = $"%A{v0}"
    let _v3 = v19 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v22 : string = $"%A{v0}"
    let _v3 = v22 
    #endif
#else
    let v25 : string = $"%A{v0}"
    let _v3 = v25 
    #endif
    let v28 : string = _v3 
    let v33 : string = $"{v28}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure8(v2, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v41 : string = v2.l0
    v41
and closure14 () (v0 : std_io_Error) : string =
    method40(v0)
and method39 () : (std_io_Error -> string) =
    closure14()
and closure15 () (v0 : std_path_PathBuf) : US8 =
    US8_0(v0)
and method41 () : (std_path_PathBuf -> US8) =
    closure15()
and closure16 () (v0 : string) : US8 =
    US8_1(v0)
and method42 () : (string -> US8) =
    closure16()
and method45 (v0 : string) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "&*$0"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let _v2 = v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = "&*$0"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v5 
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = "&*$0"
    let v8 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v7 
    let _v2 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v12 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v12 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v15 
    #endif
#else
    let v18 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v18 
    #endif
    let v21 : Ref<Str> = _v2 
    let v26 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = "String::from($0)"
    let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v27 
    let _v26 = v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "String::from($0)"
    let v30 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v29 
    let _v26 = v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = "String::from($0)"
    let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v31 
    let _v26 = v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v36 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v36 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v39 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v39 
    #endif
#else
    let v42 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v42 
    #endif
    let v45 : std_string_String = _v26 
    let v50 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v51 : string = "std::path::PathBuf::from($0)"
    let v52 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v51 
    let _v50 = v52 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v53 : string = "std::path::PathBuf::from($0)"
    let v54 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v53 
    let _v50 = v54 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v55 : string = "std::path::PathBuf::from($0)"
    let v56 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v55 
    let _v50 = v56 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v57 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v57 
    #endif
#if FABLE_COMPILER_PYTHON
    let v60 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v60 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v63 
    #endif
#else
    let v66 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v66 
    #endif
    let v69 : std_path_PathBuf = _v50 
    let v74 : string = "$0.file_name()"
    let v75 : Ref<std_ffi_OsStr> option = Fable.Core.RustInterop.emitRustExpr v69 v74 
    let v76 : string = "true; let _optionm_map_ = $0.map(|x| { //"
    let v77 : bool = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let v78 : string = "x"
    let v79 : Ref<std_ffi_OsStr> = Fable.Core.RustInterop.emitRustExpr () v78 
    let v80 : string = "$0.to_os_string()"
    let v81 : std_ffi_OsString = Fable.Core.RustInterop.emitRustExpr v79 v80 
    let v82 : string = "$0.to_str()"
    let v83 : Ref<Str> option = Fable.Core.RustInterop.emitRustExpr v81 v82 
    let v84 : string = "$0.unwrap()"
    let v85 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v83 v84 
    let v86 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v87 : string = "String::from($0)"
    let v88 : std_string_String = Fable.Core.RustInterop.emitRustExpr v85 v87 
    let _v86 = v88 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v89 : string = "String::from($0)"
    let v90 : std_string_String = Fable.Core.RustInterop.emitRustExpr v85 v89 
    let _v86 = v90 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v91 : string = "String::from($0)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr v85 v91 
    let _v86 = v92 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v93 : std_string_String = v85 |> unbox<std_string_String>
    let _v86 = v93 
    #endif
#if FABLE_COMPILER_PYTHON
    let v96 : std_string_String = v85 |> unbox<std_string_String>
    let _v86 = v96 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v99 : std_string_String = v85 |> unbox<std_string_String>
    let _v86 = v99 
    #endif
#else
    let v102 : std_string_String = v85 |> unbox<std_string_String>
    let _v86 = v102 
    #endif
    let v105 : std_string_String = _v86 
    let v110 : string = "fable_library_rust::String_::fromString($0)"
    let v111 : string = Fable.Core.RustInterop.emitRustExpr v105 v110 
    let v112 : string = "true; $0 })"
    let v113 : bool = Fable.Core.RustInterop.emitRustExpr v111 v112 
    let v114 : string = "_optionm_map_"
    let v115 : string option = Fable.Core.RustInterop.emitRustExpr () v114 
    let v116 : (string -> US5) = method6()
    let v117 : US5 option = v115 |> Option.map v116 
    let v128 : US5 = US5_1
    let v129 : US5 = v117 |> Option.defaultValue v128 
    let v136 : string =
        match v129 with
        | US5_1 -> (* None *)
            let v134 : string = ""
            v134
        | US5_0(v133) -> (* Some *)
            v133
    let _v1 = v136 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v137 : US3 = US3_1
    let v138 : US4 = US4_2(v137)
    let v139 : string = $"file_system.get_file_name / target: {v138} / path: {v0}"
    let v140 : string = failwith<string> v139
    let _v1 = v140 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v141 : string = null |> unbox<string>
    let _v1 = v141 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v144 : US3 = US3_0
    let v145 : US4 = US4_3(v144)
    let v146 : string = $"file_system.get_file_name / target: {v145} / path: {v0}"
    let v147 : string = failwith<string> v146
    let _v1 = v147 
    #endif
#if FABLE_COMPILER_PYTHON
    let v148 : US3 = US3_0
    let v149 : US4 = US4_4(v148)
    let v150 : string = $"file_system.get_file_name / target: {v149} / path: {v0}"
    let v151 : string = failwith<string> v150
    let _v1 = v151 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v152 : US3 = US3_1
    let v153 : US4 = US4_0(v152)
    let v154 : string = $"file_system.get_file_name / target: {v153} / path: {v0}"
    let v155 : string = failwith<string> v154
    let _v1 = v155 
    #endif
#else
    let v156 : (string -> string) = System.IO.Path.GetFileName
    let v157 : string = v156 v0
    let _v1 = v157 
    #endif
    let v158 : string = _v1 
    v158
and method46 (v0 : string) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure8(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method44 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : string, v4 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v5 : string = method45(v4)
    let v6 : string option = method29(v4)
    let v7 : (string -> US5) = method6()
    let v8 : US5 option = v6 |> Option.map v7 
    let v19 : US5 = US5_1
    let v20 : US5 = v8 |> Option.defaultValue v19 
    let v24 : string = method46(v3)
    let v25 : bool = v2 >= 11uy
    if v25 then
        let v26 : string = $"file_system.read_link / path: {v0} / n: {v2} / path': {v4} / name: {v5}"
        let v27 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v28 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v29 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v26 v28 
        let _v27 = v29 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v30 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v31 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v26 v30 
        let _v27 = v31 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v32 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v33 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v26 v32 
        let _v27 = v33 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v34 : std_io_Error = v26 |> unbox<std_io_Error>
        let _v27 = v34 
        #endif
#if FABLE_COMPILER_PYTHON
        let v37 : std_io_Error = v26 |> unbox<std_io_Error>
        let _v27 = v37 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v40 : std_io_Error = v26 |> unbox<std_io_Error>
        let _v27 = v40 
        #endif
#else
        let v43 : std_io_Error = v26 |> unbox<std_io_Error>
        let _v27 = v43 
        #endif
        let v46 : std_io_Error = _v27 
        let v51 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v52 : string = "Err($0)"
        let v53 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v46 v52 
        let _v51 = v53 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v54 : string = "Err($0)"
        let v55 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v46 v54 
        let _v51 = v55 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v56 : string = "Err($0)"
        let v57 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v46 v56 
        let _v51 = v57 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v58 : Result<std_path_PathBuf, std_io_Error> = v46 |> Error
        let _v51 = v58 
        #endif
#if FABLE_COMPILER_PYTHON
        let v59 : Result<std_path_PathBuf, std_io_Error> = v46 |> Error
        let _v51 = v59 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v60 : Result<std_path_PathBuf, std_io_Error> = v46 |> Error
        let _v51 = v60 
        #endif
#else
        let v61 : Result<std_path_PathBuf, std_io_Error> = v46 |> Error
        let _v51 = v61 
        #endif
        let v62 : Result<std_path_PathBuf, std_io_Error> = _v51 
        v62
    else
        match v20 with
        | US5_0(v65) -> (* Some *)
            let v66 : string = ""
            let v67 : bool = v4 <> v66 
            if v67 then
                let v70 : uint8 = v2 + 1uy
                let v71 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v70
                let v72 : Result<std_path_PathBuf, std_io_Error> = v71 v65
                let v73 : (std_io_Error -> string) = method39()
                let v74 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v75 : string = "$0.map_err(|x| $1(x))"
                let v76 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v72, v73) v75 
                let _v74 = v76 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v77 : string = "$0.map_err(|x| $1(x))"
                let v78 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v72, v73) v77 
                let _v74 = v78 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v79 : string = "$0.map_err(|x| $1(x))"
                let v80 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v72, v73) v79 
                let _v74 = v80 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v81 : Result<std_path_PathBuf, string> = match v72 with Ok x -> Ok x | Error x -> Error (v73 x)
                let _v74 = v81 
                #endif
#if FABLE_COMPILER_PYTHON
                let v82 : Result<std_path_PathBuf, string> = match v72 with Ok x -> Ok x | Error x -> Error (v73 x)
                let _v74 = v82 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v83 : Result<std_path_PathBuf, string> = match v72 with Ok x -> Ok x | Error x -> Error (v73 x)
                let _v74 = v83 
                #endif
#else
                let v84 : Result<std_path_PathBuf, string> = match v72 with Ok x -> Ok x | Error x -> Error (v73 x)
                let _v74 = v84 
                #endif
                let v85 : Result<std_path_PathBuf, string> = _v74 
                let v88 : (std_path_PathBuf -> US8) = method41()
                let v89 : (string -> US8) = method42()
                let v90 : US8 = match v85 with Ok x -> v88 x | Error x -> v89 x
                match v90 with
                | US8_1(v206) -> (* Error *)
                    let v207 : string = $"file_system.read_link / error': {v206} / error: {v24} / name: {v5}"
                    let v208 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v209 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v210 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v207 v209 
                    let _v208 = v210 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v211 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v212 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v207 v211 
                    let _v208 = v212 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v213 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v214 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v207 v213 
                    let _v208 = v214 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v215 : std_io_Error = v207 |> unbox<std_io_Error>
                    let _v208 = v215 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v218 : std_io_Error = v207 |> unbox<std_io_Error>
                    let _v208 = v218 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v221 : std_io_Error = v207 |> unbox<std_io_Error>
                    let _v208 = v221 
                    #endif
#else
                    let v224 : std_io_Error = v207 |> unbox<std_io_Error>
                    let _v208 = v224 
                    #endif
                    let v227 : std_io_Error = _v208 
                    let v232 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v233 : string = "Err($0)"
                    let v234 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v227 v233 
                    let _v232 = v234 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v235 : string = "Err($0)"
                    let v236 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v227 v235 
                    let _v232 = v236 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v237 : string = "Err($0)"
                    let v238 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v227 v237 
                    let _v232 = v238 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v239 : Result<std_path_PathBuf, std_io_Error> = v227 |> Error
                    let _v232 = v239 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v240 : Result<std_path_PathBuf, std_io_Error> = v227 |> Error
                    let _v232 = v240 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v241 : Result<std_path_PathBuf, std_io_Error> = v227 |> Error
                    let _v232 = v241 
                    #endif
#else
                    let v242 : Result<std_path_PathBuf, std_io_Error> = v227 |> Error
                    let _v232 = v242 
                    #endif
                    let v243 : Result<std_path_PathBuf, std_io_Error> = _v232 
                    v243
                | US8_0(v91) -> (* Ok *)
                    let v92 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v93 : string = "$0.display()"
                    let v94 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v91 v93 
                    let _v92 = v94 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v95 : string = "$0.display()"
                    let v96 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v91 v95 
                    let _v92 = v96 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v97 : string = "$0.display()"
                    let v98 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v91 v97 
                    let _v92 = v98 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v99 : std_path_Display = v91 |> unbox<std_path_Display>
                    let _v92 = v99 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v102 : std_path_Display = v91 |> unbox<std_path_Display>
                    let _v92 = v102 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v105 : std_path_Display = v91 |> unbox<std_path_Display>
                    let _v92 = v105 
                    #endif
#else
                    let v108 : std_path_Display = v91 |> unbox<std_path_Display>
                    let _v92 = v108 
                    #endif
                    let v111 : std_path_Display = _v92 
                    let v116 : string = v111 |> string 
                    let v119 : string = method26(v116, v5)
                    let v120 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v121 : string = "&*$0"
                    let v122 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v119 v121 
                    let _v120 = v122 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v123 : string = "&*$0"
                    let v124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v119 v123 
                    let _v120 = v124 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v125 : string = "&*$0"
                    let v126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v119 v125 
                    let _v120 = v126 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v127 : Ref<Str> = v119 |> unbox<Ref<Str>>
                    let _v120 = v127 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v130 : Ref<Str> = v119 |> unbox<Ref<Str>>
                    let _v120 = v130 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v133 : Ref<Str> = v119 |> unbox<Ref<Str>>
                    let _v120 = v133 
                    #endif
#else
                    let v136 : Ref<Str> = v119 |> unbox<Ref<Str>>
                    let _v120 = v136 
                    #endif
                    let v139 : Ref<Str> = _v120 
                    let v144 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v145 : string = "String::from($0)"
                    let v146 : std_string_String = Fable.Core.RustInterop.emitRustExpr v139 v145 
                    let _v144 = v146 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v147 : string = "String::from($0)"
                    let v148 : std_string_String = Fable.Core.RustInterop.emitRustExpr v139 v147 
                    let _v144 = v148 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v149 : string = "String::from($0)"
                    let v150 : std_string_String = Fable.Core.RustInterop.emitRustExpr v139 v149 
                    let _v144 = v150 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v151 : std_string_String = v139 |> unbox<std_string_String>
                    let _v144 = v151 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v154 : std_string_String = v139 |> unbox<std_string_String>
                    let _v144 = v154 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v157 : std_string_String = v139 |> unbox<std_string_String>
                    let _v144 = v157 
                    #endif
#else
                    let v160 : std_string_String = v139 |> unbox<std_string_String>
                    let _v144 = v160 
                    #endif
                    let v163 : std_string_String = _v144 
                    let v168 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v169 : string = "std::path::PathBuf::from($0)"
                    let v170 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v163 v169 
                    let _v168 = v170 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v171 : string = "std::path::PathBuf::from($0)"
                    let v172 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v163 v171 
                    let _v168 = v172 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v173 : string = "std::path::PathBuf::from($0)"
                    let v174 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v163 v173 
                    let _v168 = v174 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v175 : std_path_PathBuf = v163 |> unbox<std_path_PathBuf>
                    let _v168 = v175 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v178 : std_path_PathBuf = v163 |> unbox<std_path_PathBuf>
                    let _v168 = v178 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v181 : std_path_PathBuf = v163 |> unbox<std_path_PathBuf>
                    let _v168 = v181 
                    #endif
#else
                    let v184 : std_path_PathBuf = v163 |> unbox<std_path_PathBuf>
                    let _v168 = v184 
                    #endif
                    let v187 : std_path_PathBuf = _v168 
                    let v192 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v193 : string = "Ok($0)"
                    let v194 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v187 v193 
                    let _v192 = v194 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v195 : string = "Ok($0)"
                    let v196 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v187 v195 
                    let _v192 = v196 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v197 : string = "Ok($0)"
                    let v198 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v187 v197 
                    let _v192 = v198 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v199 : Result<std_path_PathBuf, std_io_Error> = v187 |> Ok
                    let _v192 = v199 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v200 : Result<std_path_PathBuf, std_io_Error> = v187 |> Ok
                    let _v192 = v200 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v201 : Result<std_path_PathBuf, std_io_Error> = v187 |> Ok
                    let _v192 = v201 
                    #endif
#else
                    let v202 : Result<std_path_PathBuf, std_io_Error> = v187 |> Ok
                    let _v192 = v202 
                    #endif
                    let v203 : Result<std_path_PathBuf, std_io_Error> = _v192 
                    v203
            else
                let v248 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / path: {v0} / error: {v24} / path': {v4} / name: {v5}"
                let v249 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v250 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v251 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v248 v250 
                let _v249 = v251 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v252 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v253 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v248 v252 
                let _v249 = v253 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v254 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v255 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v248 v254 
                let _v249 = v255 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v256 : std_io_Error = v248 |> unbox<std_io_Error>
                let _v249 = v256 
                #endif
#if FABLE_COMPILER_PYTHON
                let v259 : std_io_Error = v248 |> unbox<std_io_Error>
                let _v249 = v259 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v262 : std_io_Error = v248 |> unbox<std_io_Error>
                let _v249 = v262 
                #endif
#else
                let v265 : std_io_Error = v248 |> unbox<std_io_Error>
                let _v249 = v265 
                #endif
                let v268 : std_io_Error = _v249 
                let v273 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v274 : string = "Err($0)"
                let v275 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v268 v274 
                let _v273 = v275 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v276 : string = "Err($0)"
                let v277 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v268 v276 
                let _v273 = v277 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v278 : string = "Err($0)"
                let v279 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v268 v278 
                let _v273 = v279 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v280 : Result<std_path_PathBuf, std_io_Error> = v268 |> Error
                let _v273 = v280 
                #endif
#if FABLE_COMPILER_PYTHON
                let v281 : Result<std_path_PathBuf, std_io_Error> = v268 |> Error
                let _v273 = v281 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v282 : Result<std_path_PathBuf, std_io_Error> = v268 |> Error
                let _v273 = v282 
                #endif
#else
                let v283 : Result<std_path_PathBuf, std_io_Error> = v268 |> Error
                let _v273 = v283 
                #endif
                let v284 : Result<std_path_PathBuf, std_io_Error> = _v273 
                v284
        | _ ->
            let v288 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / path: {v0} / error: {v24} / path': {v4} / name: {v5}"
            let v289 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v290 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v291 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v288 v290 
            let _v289 = v291 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v292 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v293 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v288 v292 
            let _v289 = v293 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v294 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v295 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v288 v294 
            let _v289 = v295 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v296 : std_io_Error = v288 |> unbox<std_io_Error>
            let _v289 = v296 
            #endif
#if FABLE_COMPILER_PYTHON
            let v299 : std_io_Error = v288 |> unbox<std_io_Error>
            let _v289 = v299 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v302 : std_io_Error = v288 |> unbox<std_io_Error>
            let _v289 = v302 
            #endif
#else
            let v305 : std_io_Error = v288 |> unbox<std_io_Error>
            let _v289 = v305 
            #endif
            let v308 : std_io_Error = _v289 
            let v313 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v314 : string = "Err($0)"
            let v315 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v308 v314 
            let _v313 = v315 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v316 : string = "Err($0)"
            let v317 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v308 v316 
            let _v313 = v317 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v318 : string = "Err($0)"
            let v319 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v308 v318 
            let _v313 = v319 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v320 : Result<std_path_PathBuf, std_io_Error> = v308 |> Error
            let _v313 = v320 
            #endif
#if FABLE_COMPILER_PYTHON
            let v321 : Result<std_path_PathBuf, std_io_Error> = v308 |> Error
            let _v313 = v321 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v322 : Result<std_path_PathBuf, std_io_Error> = v308 |> Error
            let _v313 = v322 
            #endif
#else
            let v323 : Result<std_path_PathBuf, std_io_Error> = v308 |> Error
            let _v313 = v323 
            #endif
            let v324 : Result<std_path_PathBuf, std_io_Error> = _v313 
            v324
and method43 (v0 : string, v1 : uint8, v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "std::fs::read_link(&*$0)"
    let v5 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v4 
    let v6 : (std_io_Error -> string) = method39()
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "$0.map_err(|x| $1(x))"
    let v9 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v5, v6) v8 
    let _v7 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : string = "$0.map_err(|x| $1(x))"
    let v11 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v5, v6) v10 
    let _v7 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = "$0.map_err(|x| $1(x))"
    let v13 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v5, v6) v12 
    let _v7 = v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : Result<std_path_PathBuf, string> = match v5 with Ok x -> Ok x | Error x -> Error (v6 x)
    let _v7 = v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : Result<std_path_PathBuf, string> = match v5 with Ok x -> Ok x | Error x -> Error (v6 x)
    let _v7 = v15 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v16 : Result<std_path_PathBuf, string> = match v5 with Ok x -> Ok x | Error x -> Error (v6 x)
    let _v7 = v16 
    #endif
#else
    let v17 : Result<std_path_PathBuf, string> = match v5 with Ok x -> Ok x | Error x -> Error (v6 x)
    let _v7 = v17 
    #endif
    let v18 : Result<std_path_PathBuf, string> = _v7 
    let v21 : (std_path_PathBuf -> US8) = method41()
    let v22 : (string -> US8) = method42()
    let v23 : US8 = match v18 with Ok x -> v21 x | Error x -> v22 x
    let v43 : Result<std_path_PathBuf, std_io_Error> =
        match v23 with
        | US8_1(v39) -> (* Error *)
            let v40 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure17(v0)
            method44(v0, v40, v1, v39, v2)
        | US8_0(v24) -> (* Ok *)
            let v25 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v26 : string = "Ok($0)"
            let v27 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v24 v26 
            let _v25 = v27 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v28 : string = "Ok($0)"
            let v29 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v24 v28 
            let _v25 = v29 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v30 : string = "Ok($0)"
            let v31 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v24 v30 
            let _v25 = v31 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v32 : Result<std_path_PathBuf, std_io_Error> = v24 |> Ok
            let _v25 = v32 
            #endif
#if FABLE_COMPILER_PYTHON
            let v33 : Result<std_path_PathBuf, std_io_Error> = v24 |> Ok
            let _v25 = v33 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v34 : Result<std_path_PathBuf, std_io_Error> = v24 |> Ok
            let _v25 = v34 
            #endif
#else
            let v35 : Result<std_path_PathBuf, std_io_Error> = v24 |> Ok
            let _v25 = v35 
            #endif
            let v36 : Result<std_path_PathBuf, std_io_Error> = _v25 
            v36
    let _v3 = v43 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v44 : string = "std::fs::read_link(&*$0)"
    let v45 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v44 
    let v46 : (std_io_Error -> string) = method39()
    let v47 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v48 : string = "$0.map_err(|x| $1(x))"
    let v49 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v45, v46) v48 
    let _v47 = v49 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v50 : string = "$0.map_err(|x| $1(x))"
    let v51 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v45, v46) v50 
    let _v47 = v51 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v52 : string = "$0.map_err(|x| $1(x))"
    let v53 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v45, v46) v52 
    let _v47 = v53 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v54 : Result<std_path_PathBuf, string> = match v45 with Ok x -> Ok x | Error x -> Error (v46 x)
    let _v47 = v54 
    #endif
#if FABLE_COMPILER_PYTHON
    let v55 : Result<std_path_PathBuf, string> = match v45 with Ok x -> Ok x | Error x -> Error (v46 x)
    let _v47 = v55 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v56 : Result<std_path_PathBuf, string> = match v45 with Ok x -> Ok x | Error x -> Error (v46 x)
    let _v47 = v56 
    #endif
#else
    let v57 : Result<std_path_PathBuf, string> = match v45 with Ok x -> Ok x | Error x -> Error (v46 x)
    let _v47 = v57 
    #endif
    let v58 : Result<std_path_PathBuf, string> = _v47 
    let v61 : (std_path_PathBuf -> US8) = method41()
    let v62 : (string -> US8) = method42()
    let v63 : US8 = match v58 with Ok x -> v61 x | Error x -> v62 x
    let v83 : Result<std_path_PathBuf, std_io_Error> =
        match v63 with
        | US8_1(v79) -> (* Error *)
            let v80 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure17(v0)
            method44(v0, v80, v1, v79, v2)
        | US8_0(v64) -> (* Ok *)
            let v65 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v66 : string = "Ok($0)"
            let v67 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v64 v66 
            let _v65 = v67 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v68 : string = "Ok($0)"
            let v69 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v64 v68 
            let _v65 = v69 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v70 : string = "Ok($0)"
            let v71 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v64 v70 
            let _v65 = v71 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v72 : Result<std_path_PathBuf, std_io_Error> = v64 |> Ok
            let _v65 = v72 
            #endif
#if FABLE_COMPILER_PYTHON
            let v73 : Result<std_path_PathBuf, std_io_Error> = v64 |> Ok
            let _v65 = v73 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v74 : Result<std_path_PathBuf, std_io_Error> = v64 |> Ok
            let _v65 = v74 
            #endif
#else
            let v75 : Result<std_path_PathBuf, std_io_Error> = v64 |> Ok
            let _v65 = v75 
            #endif
            let v76 : Result<std_path_PathBuf, std_io_Error> = _v65 
            v76
    let _v3 = v83 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v84 : string = "std::fs::read_link(&*$0)"
    let v85 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v84 
    let v86 : (std_io_Error -> string) = method39()
    let v87 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v88 : string = "$0.map_err(|x| $1(x))"
    let v89 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v85, v86) v88 
    let _v87 = v89 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v90 : string = "$0.map_err(|x| $1(x))"
    let v91 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v85, v86) v90 
    let _v87 = v91 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v92 : string = "$0.map_err(|x| $1(x))"
    let v93 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v85, v86) v92 
    let _v87 = v93 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v94 : Result<std_path_PathBuf, string> = match v85 with Ok x -> Ok x | Error x -> Error (v86 x)
    let _v87 = v94 
    #endif
#if FABLE_COMPILER_PYTHON
    let v95 : Result<std_path_PathBuf, string> = match v85 with Ok x -> Ok x | Error x -> Error (v86 x)
    let _v87 = v95 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v96 : Result<std_path_PathBuf, string> = match v85 with Ok x -> Ok x | Error x -> Error (v86 x)
    let _v87 = v96 
    #endif
#else
    let v97 : Result<std_path_PathBuf, string> = match v85 with Ok x -> Ok x | Error x -> Error (v86 x)
    let _v87 = v97 
    #endif
    let v98 : Result<std_path_PathBuf, string> = _v87 
    let v101 : (std_path_PathBuf -> US8) = method41()
    let v102 : (string -> US8) = method42()
    let v103 : US8 = match v98 with Ok x -> v101 x | Error x -> v102 x
    let v123 : Result<std_path_PathBuf, std_io_Error> =
        match v103 with
        | US8_1(v119) -> (* Error *)
            let v120 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure17(v0)
            method44(v0, v120, v1, v119, v2)
        | US8_0(v104) -> (* Ok *)
            let v105 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v106 : string = "Ok($0)"
            let v107 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v104 v106 
            let _v105 = v107 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v108 : string = "Ok($0)"
            let v109 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v104 v108 
            let _v105 = v109 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v110 : string = "Ok($0)"
            let v111 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v104 v110 
            let _v105 = v111 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v112 : Result<std_path_PathBuf, std_io_Error> = v104 |> Ok
            let _v105 = v112 
            #endif
#if FABLE_COMPILER_PYTHON
            let v113 : Result<std_path_PathBuf, std_io_Error> = v104 |> Ok
            let _v105 = v113 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v114 : Result<std_path_PathBuf, std_io_Error> = v104 |> Ok
            let _v105 = v114 
            #endif
#else
            let v115 : Result<std_path_PathBuf, std_io_Error> = v104 |> Ok
            let _v105 = v115 
            #endif
            let v116 : Result<std_path_PathBuf, std_io_Error> = _v105 
            v116
    let _v3 = v123 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v124 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _v3 = v124 
    #endif
#if FABLE_COMPILER_PYTHON
    let v127 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _v3 = v127 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v130 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _v3 = v130 
    #endif
#else
    let v133 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _v3 = v133 
    #endif
    let v136 : Result<std_path_PathBuf, std_io_Error> = _v3 
    v136
and closure18 (v0 : string, v1 : uint8) (v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    method43(v0, v1, v2)
and closure17 (v0 : string) (v1 : uint8) : (string -> Result<std_path_PathBuf, std_io_Error>) =
    closure18(v0, v1)
and method47 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v4 : string = method45(v0)
    let v5 : string option = method29(v0)
    let v6 : (string -> US5) = method6()
    let v7 : US5 option = v5 |> Option.map v6 
    let v18 : US5 = US5_1
    let v19 : US5 = v7 |> Option.defaultValue v18 
    let v23 : string = method46(v3)
    let v24 : bool = v2 >= 11uy
    if v24 then
        let v25 : string = $"file_system.read_link / path: {v0} / n: {v2} / path': {v0} / name: {v4}"
        let v26 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v27 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v28 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v25 v27 
        let _v26 = v28 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v29 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v30 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v25 v29 
        let _v26 = v30 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v31 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v32 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v25 v31 
        let _v26 = v32 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v33 : std_io_Error = v25 |> unbox<std_io_Error>
        let _v26 = v33 
        #endif
#if FABLE_COMPILER_PYTHON
        let v36 : std_io_Error = v25 |> unbox<std_io_Error>
        let _v26 = v36 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v39 : std_io_Error = v25 |> unbox<std_io_Error>
        let _v26 = v39 
        #endif
#else
        let v42 : std_io_Error = v25 |> unbox<std_io_Error>
        let _v26 = v42 
        #endif
        let v45 : std_io_Error = _v26 
        let v50 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v51 : string = "Err($0)"
        let v52 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v45 v51 
        let _v50 = v52 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v53 : string = "Err($0)"
        let v54 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v45 v53 
        let _v50 = v54 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v55 : string = "Err($0)"
        let v56 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v45 v55 
        let _v50 = v56 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v57 : Result<std_path_PathBuf, std_io_Error> = v45 |> Error
        let _v50 = v57 
        #endif
#if FABLE_COMPILER_PYTHON
        let v58 : Result<std_path_PathBuf, std_io_Error> = v45 |> Error
        let _v50 = v58 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v59 : Result<std_path_PathBuf, std_io_Error> = v45 |> Error
        let _v50 = v59 
        #endif
#else
        let v60 : Result<std_path_PathBuf, std_io_Error> = v45 |> Error
        let _v50 = v60 
        #endif
        let v61 : Result<std_path_PathBuf, std_io_Error> = _v50 
        v61
    else
        match v19 with
        | US5_0(v64) -> (* Some *)
            let v65 : string = ""
            let v66 : bool = v0 <> v65 
            if v66 then
                let v69 : uint8 = v2 + 1uy
                let v70 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v69
                let v71 : Result<std_path_PathBuf, std_io_Error> = v70 v64
                let v72 : (std_io_Error -> string) = method39()
                let v73 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v74 : string = "$0.map_err(|x| $1(x))"
                let v75 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v71, v72) v74 
                let _v73 = v75 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v76 : string = "$0.map_err(|x| $1(x))"
                let v77 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v71, v72) v76 
                let _v73 = v77 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v78 : string = "$0.map_err(|x| $1(x))"
                let v79 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v71, v72) v78 
                let _v73 = v79 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v80 : Result<std_path_PathBuf, string> = match v71 with Ok x -> Ok x | Error x -> Error (v72 x)
                let _v73 = v80 
                #endif
#if FABLE_COMPILER_PYTHON
                let v81 : Result<std_path_PathBuf, string> = match v71 with Ok x -> Ok x | Error x -> Error (v72 x)
                let _v73 = v81 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v82 : Result<std_path_PathBuf, string> = match v71 with Ok x -> Ok x | Error x -> Error (v72 x)
                let _v73 = v82 
                #endif
#else
                let v83 : Result<std_path_PathBuf, string> = match v71 with Ok x -> Ok x | Error x -> Error (v72 x)
                let _v73 = v83 
                #endif
                let v84 : Result<std_path_PathBuf, string> = _v73 
                let v87 : (std_path_PathBuf -> US8) = method41()
                let v88 : (string -> US8) = method42()
                let v89 : US8 = match v84 with Ok x -> v87 x | Error x -> v88 x
                match v89 with
                | US8_1(v205) -> (* Error *)
                    let v206 : string = $"file_system.read_link / error': {v205} / error: {v23} / name: {v4}"
                    let v207 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v208 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v209 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v206 v208 
                    let _v207 = v209 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v210 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v211 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v206 v210 
                    let _v207 = v211 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v212 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v213 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v206 v212 
                    let _v207 = v213 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v214 : std_io_Error = v206 |> unbox<std_io_Error>
                    let _v207 = v214 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v217 : std_io_Error = v206 |> unbox<std_io_Error>
                    let _v207 = v217 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v220 : std_io_Error = v206 |> unbox<std_io_Error>
                    let _v207 = v220 
                    #endif
#else
                    let v223 : std_io_Error = v206 |> unbox<std_io_Error>
                    let _v207 = v223 
                    #endif
                    let v226 : std_io_Error = _v207 
                    let v231 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v232 : string = "Err($0)"
                    let v233 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v226 v232 
                    let _v231 = v233 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v234 : string = "Err($0)"
                    let v235 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v226 v234 
                    let _v231 = v235 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v236 : string = "Err($0)"
                    let v237 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v226 v236 
                    let _v231 = v237 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v238 : Result<std_path_PathBuf, std_io_Error> = v226 |> Error
                    let _v231 = v238 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v239 : Result<std_path_PathBuf, std_io_Error> = v226 |> Error
                    let _v231 = v239 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v240 : Result<std_path_PathBuf, std_io_Error> = v226 |> Error
                    let _v231 = v240 
                    #endif
#else
                    let v241 : Result<std_path_PathBuf, std_io_Error> = v226 |> Error
                    let _v231 = v241 
                    #endif
                    let v242 : Result<std_path_PathBuf, std_io_Error> = _v231 
                    v242
                | US8_0(v90) -> (* Ok *)
                    let v91 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v92 : string = "$0.display()"
                    let v93 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v90 v92 
                    let _v91 = v93 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v94 : string = "$0.display()"
                    let v95 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v90 v94 
                    let _v91 = v95 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v96 : string = "$0.display()"
                    let v97 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v90 v96 
                    let _v91 = v97 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v98 : std_path_Display = v90 |> unbox<std_path_Display>
                    let _v91 = v98 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v101 : std_path_Display = v90 |> unbox<std_path_Display>
                    let _v91 = v101 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v104 : std_path_Display = v90 |> unbox<std_path_Display>
                    let _v91 = v104 
                    #endif
#else
                    let v107 : std_path_Display = v90 |> unbox<std_path_Display>
                    let _v91 = v107 
                    #endif
                    let v110 : std_path_Display = _v91 
                    let v115 : string = v110 |> string 
                    let v118 : string = method26(v115, v4)
                    let v119 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v120 : string = "&*$0"
                    let v121 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v118 v120 
                    let _v119 = v121 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v122 : string = "&*$0"
                    let v123 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v118 v122 
                    let _v119 = v123 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v124 : string = "&*$0"
                    let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v118 v124 
                    let _v119 = v125 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v126 : Ref<Str> = v118 |> unbox<Ref<Str>>
                    let _v119 = v126 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v129 : Ref<Str> = v118 |> unbox<Ref<Str>>
                    let _v119 = v129 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v132 : Ref<Str> = v118 |> unbox<Ref<Str>>
                    let _v119 = v132 
                    #endif
#else
                    let v135 : Ref<Str> = v118 |> unbox<Ref<Str>>
                    let _v119 = v135 
                    #endif
                    let v138 : Ref<Str> = _v119 
                    let v143 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v144 : string = "String::from($0)"
                    let v145 : std_string_String = Fable.Core.RustInterop.emitRustExpr v138 v144 
                    let _v143 = v145 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v146 : string = "String::from($0)"
                    let v147 : std_string_String = Fable.Core.RustInterop.emitRustExpr v138 v146 
                    let _v143 = v147 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v148 : string = "String::from($0)"
                    let v149 : std_string_String = Fable.Core.RustInterop.emitRustExpr v138 v148 
                    let _v143 = v149 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v150 : std_string_String = v138 |> unbox<std_string_String>
                    let _v143 = v150 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v153 : std_string_String = v138 |> unbox<std_string_String>
                    let _v143 = v153 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v156 : std_string_String = v138 |> unbox<std_string_String>
                    let _v143 = v156 
                    #endif
#else
                    let v159 : std_string_String = v138 |> unbox<std_string_String>
                    let _v143 = v159 
                    #endif
                    let v162 : std_string_String = _v143 
                    let v167 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v168 : string = "std::path::PathBuf::from($0)"
                    let v169 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v162 v168 
                    let _v167 = v169 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v170 : string = "std::path::PathBuf::from($0)"
                    let v171 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v162 v170 
                    let _v167 = v171 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v172 : string = "std::path::PathBuf::from($0)"
                    let v173 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v162 v172 
                    let _v167 = v173 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v174 : std_path_PathBuf = v162 |> unbox<std_path_PathBuf>
                    let _v167 = v174 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v177 : std_path_PathBuf = v162 |> unbox<std_path_PathBuf>
                    let _v167 = v177 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v180 : std_path_PathBuf = v162 |> unbox<std_path_PathBuf>
                    let _v167 = v180 
                    #endif
#else
                    let v183 : std_path_PathBuf = v162 |> unbox<std_path_PathBuf>
                    let _v167 = v183 
                    #endif
                    let v186 : std_path_PathBuf = _v167 
                    let v191 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v192 : string = "Ok($0)"
                    let v193 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v186 v192 
                    let _v191 = v193 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v194 : string = "Ok($0)"
                    let v195 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v186 v194 
                    let _v191 = v195 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v196 : string = "Ok($0)"
                    let v197 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v186 v196 
                    let _v191 = v197 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v198 : Result<std_path_PathBuf, std_io_Error> = v186 |> Ok
                    let _v191 = v198 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v199 : Result<std_path_PathBuf, std_io_Error> = v186 |> Ok
                    let _v191 = v199 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v200 : Result<std_path_PathBuf, std_io_Error> = v186 |> Ok
                    let _v191 = v200 
                    #endif
#else
                    let v201 : Result<std_path_PathBuf, std_io_Error> = v186 |> Ok
                    let _v191 = v201 
                    #endif
                    let v202 : Result<std_path_PathBuf, std_io_Error> = _v191 
                    v202
            else
                let v247 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / path: {v0} / error: {v23} / path': {v0} / name: {v4}"
                let v248 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v249 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v250 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v247 v249 
                let _v248 = v250 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v251 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v252 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v247 v251 
                let _v248 = v252 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v253 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v254 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v247 v253 
                let _v248 = v254 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v255 : std_io_Error = v247 |> unbox<std_io_Error>
                let _v248 = v255 
                #endif
#if FABLE_COMPILER_PYTHON
                let v258 : std_io_Error = v247 |> unbox<std_io_Error>
                let _v248 = v258 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v261 : std_io_Error = v247 |> unbox<std_io_Error>
                let _v248 = v261 
                #endif
#else
                let v264 : std_io_Error = v247 |> unbox<std_io_Error>
                let _v248 = v264 
                #endif
                let v267 : std_io_Error = _v248 
                let v272 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v273 : string = "Err($0)"
                let v274 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v267 v273 
                let _v272 = v274 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v275 : string = "Err($0)"
                let v276 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v267 v275 
                let _v272 = v276 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v277 : string = "Err($0)"
                let v278 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v267 v277 
                let _v272 = v278 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v279 : Result<std_path_PathBuf, std_io_Error> = v267 |> Error
                let _v272 = v279 
                #endif
#if FABLE_COMPILER_PYTHON
                let v280 : Result<std_path_PathBuf, std_io_Error> = v267 |> Error
                let _v272 = v280 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v281 : Result<std_path_PathBuf, std_io_Error> = v267 |> Error
                let _v272 = v281 
                #endif
#else
                let v282 : Result<std_path_PathBuf, std_io_Error> = v267 |> Error
                let _v272 = v282 
                #endif
                let v283 : Result<std_path_PathBuf, std_io_Error> = _v272 
                v283
        | _ ->
            let v287 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / path: {v0} / error: {v23} / path': {v0} / name: {v4}"
            let v288 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v289 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v290 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v287 v289 
            let _v288 = v290 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v291 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v292 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v287 v291 
            let _v288 = v292 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v293 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v294 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v287 v293 
            let _v288 = v294 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v295 : std_io_Error = v287 |> unbox<std_io_Error>
            let _v288 = v295 
            #endif
#if FABLE_COMPILER_PYTHON
            let v298 : std_io_Error = v287 |> unbox<std_io_Error>
            let _v288 = v298 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v301 : std_io_Error = v287 |> unbox<std_io_Error>
            let _v288 = v301 
            #endif
#else
            let v304 : std_io_Error = v287 |> unbox<std_io_Error>
            let _v288 = v304 
            #endif
            let v307 : std_io_Error = _v288 
            let v312 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v313 : string = "Err($0)"
            let v314 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v307 v313 
            let _v312 = v314 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v315 : string = "Err($0)"
            let v316 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v307 v315 
            let _v312 = v316 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v317 : string = "Err($0)"
            let v318 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v307 v317 
            let _v312 = v318 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v319 : Result<std_path_PathBuf, std_io_Error> = v307 |> Error
            let _v312 = v319 
            #endif
#if FABLE_COMPILER_PYTHON
            let v320 : Result<std_path_PathBuf, std_io_Error> = v307 |> Error
            let _v312 = v320 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v321 : Result<std_path_PathBuf, std_io_Error> = v307 |> Error
            let _v312 = v321 
            #endif
#else
            let v322 : Result<std_path_PathBuf, std_io_Error> = v307 |> Error
            let _v312 = v322 
            #endif
            let v323 : Result<std_path_PathBuf, std_io_Error> = _v312 
            v323
and method38 (v0 : string, v1 : uint8) : Result<std_path_PathBuf, std_io_Error> =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "std::fs::read_link(&*$0)"
    let v4 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let v5 : (std_io_Error -> string) = method39()
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = "$0.map_err(|x| $1(x))"
    let v8 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v7 
    let _v6 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : string = "$0.map_err(|x| $1(x))"
    let v10 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v9 
    let _v6 = v10 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v11 : string = "$0.map_err(|x| $1(x))"
    let v12 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v11 
    let _v6 = v12 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : Result<std_path_PathBuf, string> = match v4 with Ok x -> Ok x | Error x -> Error (v5 x)
    let _v6 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : Result<std_path_PathBuf, string> = match v4 with Ok x -> Ok x | Error x -> Error (v5 x)
    let _v6 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : Result<std_path_PathBuf, string> = match v4 with Ok x -> Ok x | Error x -> Error (v5 x)
    let _v6 = v15 
    #endif
#else
    let v16 : Result<std_path_PathBuf, string> = match v4 with Ok x -> Ok x | Error x -> Error (v5 x)
    let _v6 = v16 
    #endif
    let v17 : Result<std_path_PathBuf, string> = _v6 
    let v20 : (std_path_PathBuf -> US8) = method41()
    let v21 : (string -> US8) = method42()
    let v22 : US8 = match v17 with Ok x -> v20 x | Error x -> v21 x
    let v42 : Result<std_path_PathBuf, std_io_Error> =
        match v22 with
        | US8_1(v38) -> (* Error *)
            let v39 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure17(v0)
            method47(v0, v39, v1, v38)
        | US8_0(v23) -> (* Ok *)
            let v24 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v25 : string = "Ok($0)"
            let v26 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v23 v25 
            let _v24 = v26 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v27 : string = "Ok($0)"
            let v28 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v23 v27 
            let _v24 = v28 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v29 : string = "Ok($0)"
            let v30 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v23 v29 
            let _v24 = v30 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v31 : Result<std_path_PathBuf, std_io_Error> = v23 |> Ok
            let _v24 = v31 
            #endif
#if FABLE_COMPILER_PYTHON
            let v32 : Result<std_path_PathBuf, std_io_Error> = v23 |> Ok
            let _v24 = v32 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v33 : Result<std_path_PathBuf, std_io_Error> = v23 |> Ok
            let _v24 = v33 
            #endif
#else
            let v34 : Result<std_path_PathBuf, std_io_Error> = v23 |> Ok
            let _v24 = v34 
            #endif
            let v35 : Result<std_path_PathBuf, std_io_Error> = _v24 
            v35
    let _v2 = v42 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v43 : string = "std::fs::read_link(&*$0)"
    let v44 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v43 
    let v45 : (std_io_Error -> string) = method39()
    let v46 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v47 : string = "$0.map_err(|x| $1(x))"
    let v48 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v44, v45) v47 
    let _v46 = v48 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v49 : string = "$0.map_err(|x| $1(x))"
    let v50 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v44, v45) v49 
    let _v46 = v50 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v51 : string = "$0.map_err(|x| $1(x))"
    let v52 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v44, v45) v51 
    let _v46 = v52 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v53 : Result<std_path_PathBuf, string> = match v44 with Ok x -> Ok x | Error x -> Error (v45 x)
    let _v46 = v53 
    #endif
#if FABLE_COMPILER_PYTHON
    let v54 : Result<std_path_PathBuf, string> = match v44 with Ok x -> Ok x | Error x -> Error (v45 x)
    let _v46 = v54 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v55 : Result<std_path_PathBuf, string> = match v44 with Ok x -> Ok x | Error x -> Error (v45 x)
    let _v46 = v55 
    #endif
#else
    let v56 : Result<std_path_PathBuf, string> = match v44 with Ok x -> Ok x | Error x -> Error (v45 x)
    let _v46 = v56 
    #endif
    let v57 : Result<std_path_PathBuf, string> = _v46 
    let v60 : (std_path_PathBuf -> US8) = method41()
    let v61 : (string -> US8) = method42()
    let v62 : US8 = match v57 with Ok x -> v60 x | Error x -> v61 x
    let v82 : Result<std_path_PathBuf, std_io_Error> =
        match v62 with
        | US8_1(v78) -> (* Error *)
            let v79 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure17(v0)
            method47(v0, v79, v1, v78)
        | US8_0(v63) -> (* Ok *)
            let v64 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v65 : string = "Ok($0)"
            let v66 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v63 v65 
            let _v64 = v66 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v67 : string = "Ok($0)"
            let v68 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v63 v67 
            let _v64 = v68 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v69 : string = "Ok($0)"
            let v70 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v63 v69 
            let _v64 = v70 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v71 : Result<std_path_PathBuf, std_io_Error> = v63 |> Ok
            let _v64 = v71 
            #endif
#if FABLE_COMPILER_PYTHON
            let v72 : Result<std_path_PathBuf, std_io_Error> = v63 |> Ok
            let _v64 = v72 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v73 : Result<std_path_PathBuf, std_io_Error> = v63 |> Ok
            let _v64 = v73 
            #endif
#else
            let v74 : Result<std_path_PathBuf, std_io_Error> = v63 |> Ok
            let _v64 = v74 
            #endif
            let v75 : Result<std_path_PathBuf, std_io_Error> = _v64 
            v75
    let _v2 = v82 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v83 : string = "std::fs::read_link(&*$0)"
    let v84 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v83 
    let v85 : (std_io_Error -> string) = method39()
    let v86 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v87 : string = "$0.map_err(|x| $1(x))"
    let v88 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v84, v85) v87 
    let _v86 = v88 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v89 : string = "$0.map_err(|x| $1(x))"
    let v90 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v84, v85) v89 
    let _v86 = v90 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v91 : string = "$0.map_err(|x| $1(x))"
    let v92 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v84, v85) v91 
    let _v86 = v92 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v93 : Result<std_path_PathBuf, string> = match v84 with Ok x -> Ok x | Error x -> Error (v85 x)
    let _v86 = v93 
    #endif
#if FABLE_COMPILER_PYTHON
    let v94 : Result<std_path_PathBuf, string> = match v84 with Ok x -> Ok x | Error x -> Error (v85 x)
    let _v86 = v94 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v95 : Result<std_path_PathBuf, string> = match v84 with Ok x -> Ok x | Error x -> Error (v85 x)
    let _v86 = v95 
    #endif
#else
    let v96 : Result<std_path_PathBuf, string> = match v84 with Ok x -> Ok x | Error x -> Error (v85 x)
    let _v86 = v96 
    #endif
    let v97 : Result<std_path_PathBuf, string> = _v86 
    let v100 : (std_path_PathBuf -> US8) = method41()
    let v101 : (string -> US8) = method42()
    let v102 : US8 = match v97 with Ok x -> v100 x | Error x -> v101 x
    let v122 : Result<std_path_PathBuf, std_io_Error> =
        match v102 with
        | US8_1(v118) -> (* Error *)
            let v119 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure17(v0)
            method47(v0, v119, v1, v118)
        | US8_0(v103) -> (* Ok *)
            let v104 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v105 : string = "Ok($0)"
            let v106 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v103 v105 
            let _v104 = v106 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v107 : string = "Ok($0)"
            let v108 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v103 v107 
            let _v104 = v108 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v109 : string = "Ok($0)"
            let v110 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v103 v109 
            let _v104 = v110 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v111 : Result<std_path_PathBuf, std_io_Error> = v103 |> Ok
            let _v104 = v111 
            #endif
#if FABLE_COMPILER_PYTHON
            let v112 : Result<std_path_PathBuf, std_io_Error> = v103 |> Ok
            let _v104 = v112 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v113 : Result<std_path_PathBuf, std_io_Error> = v103 |> Ok
            let _v104 = v113 
            #endif
#else
            let v114 : Result<std_path_PathBuf, std_io_Error> = v103 |> Ok
            let _v104 = v114 
            #endif
            let v115 : Result<std_path_PathBuf, std_io_Error> = _v104 
            v115
    let _v2 = v122 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v123 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _v2 = v123 
    #endif
#if FABLE_COMPILER_PYTHON
    let v126 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _v2 = v126 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v129 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _v2 = v129 
    #endif
#else
    let v132 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _v2 = v132 
    #endif
    let v135 : Result<std_path_PathBuf, std_io_Error> = _v2 
    v135
and method49 (v0 : System_IO_DirectoryInfo) : System.IO.FileAttributes =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v1 = v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v1 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v1 = v17 
    #endif
#else
    let v20 : (System_IO_DirectoryInfo -> System.IO.FileAttributes) = _.Attributes
    let v21 : System.IO.FileAttributes = v20 v0
    let _v1 = v21 
    #endif
    let v22 : System.IO.FileAttributes = _v1 
    v22
and method50 () : System.IO.FileAttributes =
    let v0 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v0 = v1 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v0 = v4 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v0 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v10 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v0 = v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v13 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v0 = v13 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v16 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v0 = v16 
    #endif
#else
    let v19 : System.IO.FileAttributes = System.IO.FileAttributes.ReparsePoint
    let _v0 = v19 
    #endif
    let v20 : System.IO.FileAttributes = _v0 
    v20
and method51 (v0 : System.IO.FileAttributes, v1 : System.IO.FileAttributes) : bool =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : bool = null |> unbox<bool>
    let _v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : bool = null |> unbox<bool>
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : bool = null |> unbox<bool>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : bool = null |> unbox<bool>
    let _v2 = v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : bool = null |> unbox<bool>
    let _v2 = v15 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v18 : bool = null |> unbox<bool>
    let _v2 = v18 
    #endif
#else
    let v21 : bool = v1.HasFlag v0 
    let _v2 = v21 
    #endif
    let v22 : bool = _v2 
    v22
and method53 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : std_io_Error, v4 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v5 : string = method45(v4)
    let v6 : string option = method29(v4)
    let v7 : (string -> US5) = method6()
    let v8 : US5 option = v6 |> Option.map v7 
    let v19 : US5 = US5_1
    let v20 : US5 = v8 |> Option.defaultValue v19 
    let v24 : string = method40(v3)
    let v25 : bool = v2 >= 11uy
    if v25 then
        let v26 : string = $"file_system.read_link / path: {v0} / n: {v2} / path': {v4} / name: {v5}"
        let v27 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v28 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v29 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v26 v28 
        let _v27 = v29 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v30 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v31 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v26 v30 
        let _v27 = v31 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v32 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v33 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v26 v32 
        let _v27 = v33 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v34 : std_io_Error = v26 |> unbox<std_io_Error>
        let _v27 = v34 
        #endif
#if FABLE_COMPILER_PYTHON
        let v37 : std_io_Error = v26 |> unbox<std_io_Error>
        let _v27 = v37 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v40 : std_io_Error = v26 |> unbox<std_io_Error>
        let _v27 = v40 
        #endif
#else
        let v43 : std_io_Error = v26 |> unbox<std_io_Error>
        let _v27 = v43 
        #endif
        let v46 : std_io_Error = _v27 
        let v51 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v52 : string = "Err($0)"
        let v53 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v46 v52 
        let _v51 = v53 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v54 : string = "Err($0)"
        let v55 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v46 v54 
        let _v51 = v55 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v56 : string = "Err($0)"
        let v57 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v46 v56 
        let _v51 = v57 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v58 : Result<std_path_PathBuf, std_io_Error> = v46 |> Error
        let _v51 = v58 
        #endif
#if FABLE_COMPILER_PYTHON
        let v59 : Result<std_path_PathBuf, std_io_Error> = v46 |> Error
        let _v51 = v59 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v60 : Result<std_path_PathBuf, std_io_Error> = v46 |> Error
        let _v51 = v60 
        #endif
#else
        let v61 : Result<std_path_PathBuf, std_io_Error> = v46 |> Error
        let _v51 = v61 
        #endif
        let v62 : Result<std_path_PathBuf, std_io_Error> = _v51 
        v62
    else
        match v20 with
        | US5_0(v65) -> (* Some *)
            let v66 : string = ""
            let v67 : bool = v4 <> v66 
            if v67 then
                let v70 : uint8 = v2 + 1uy
                let v71 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v70
                let v72 : Result<std_path_PathBuf, std_io_Error> = v71 v65
                let v73 : (std_io_Error -> string) = method39()
                let v74 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v75 : string = "$0.map_err(|x| $1(x))"
                let v76 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v72, v73) v75 
                let _v74 = v76 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v77 : string = "$0.map_err(|x| $1(x))"
                let v78 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v72, v73) v77 
                let _v74 = v78 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v79 : string = "$0.map_err(|x| $1(x))"
                let v80 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v72, v73) v79 
                let _v74 = v80 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v81 : Result<std_path_PathBuf, string> = match v72 with Ok x -> Ok x | Error x -> Error (v73 x)
                let _v74 = v81 
                #endif
#if FABLE_COMPILER_PYTHON
                let v82 : Result<std_path_PathBuf, string> = match v72 with Ok x -> Ok x | Error x -> Error (v73 x)
                let _v74 = v82 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v83 : Result<std_path_PathBuf, string> = match v72 with Ok x -> Ok x | Error x -> Error (v73 x)
                let _v74 = v83 
                #endif
#else
                let v84 : Result<std_path_PathBuf, string> = match v72 with Ok x -> Ok x | Error x -> Error (v73 x)
                let _v74 = v84 
                #endif
                let v85 : Result<std_path_PathBuf, string> = _v74 
                let v88 : (std_path_PathBuf -> US8) = method41()
                let v89 : (string -> US8) = method42()
                let v90 : US8 = match v85 with Ok x -> v88 x | Error x -> v89 x
                match v90 with
                | US8_1(v206) -> (* Error *)
                    let v207 : string = $"file_system.read_link / error': {v206} / error: {v24} / name: {v5}"
                    let v208 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v209 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v210 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v207 v209 
                    let _v208 = v210 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v211 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v212 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v207 v211 
                    let _v208 = v212 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v213 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v214 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v207 v213 
                    let _v208 = v214 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v215 : std_io_Error = v207 |> unbox<std_io_Error>
                    let _v208 = v215 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v218 : std_io_Error = v207 |> unbox<std_io_Error>
                    let _v208 = v218 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v221 : std_io_Error = v207 |> unbox<std_io_Error>
                    let _v208 = v221 
                    #endif
#else
                    let v224 : std_io_Error = v207 |> unbox<std_io_Error>
                    let _v208 = v224 
                    #endif
                    let v227 : std_io_Error = _v208 
                    let v232 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v233 : string = "Err($0)"
                    let v234 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v227 v233 
                    let _v232 = v234 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v235 : string = "Err($0)"
                    let v236 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v227 v235 
                    let _v232 = v236 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v237 : string = "Err($0)"
                    let v238 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v227 v237 
                    let _v232 = v238 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v239 : Result<std_path_PathBuf, std_io_Error> = v227 |> Error
                    let _v232 = v239 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v240 : Result<std_path_PathBuf, std_io_Error> = v227 |> Error
                    let _v232 = v240 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v241 : Result<std_path_PathBuf, std_io_Error> = v227 |> Error
                    let _v232 = v241 
                    #endif
#else
                    let v242 : Result<std_path_PathBuf, std_io_Error> = v227 |> Error
                    let _v232 = v242 
                    #endif
                    let v243 : Result<std_path_PathBuf, std_io_Error> = _v232 
                    v243
                | US8_0(v91) -> (* Ok *)
                    let v92 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v93 : string = "$0.display()"
                    let v94 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v91 v93 
                    let _v92 = v94 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v95 : string = "$0.display()"
                    let v96 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v91 v95 
                    let _v92 = v96 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v97 : string = "$0.display()"
                    let v98 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v91 v97 
                    let _v92 = v98 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v99 : std_path_Display = v91 |> unbox<std_path_Display>
                    let _v92 = v99 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v102 : std_path_Display = v91 |> unbox<std_path_Display>
                    let _v92 = v102 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v105 : std_path_Display = v91 |> unbox<std_path_Display>
                    let _v92 = v105 
                    #endif
#else
                    let v108 : std_path_Display = v91 |> unbox<std_path_Display>
                    let _v92 = v108 
                    #endif
                    let v111 : std_path_Display = _v92 
                    let v116 : string = v111 |> string 
                    let v119 : string = method26(v116, v5)
                    let v120 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v121 : string = "&*$0"
                    let v122 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v119 v121 
                    let _v120 = v122 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v123 : string = "&*$0"
                    let v124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v119 v123 
                    let _v120 = v124 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v125 : string = "&*$0"
                    let v126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v119 v125 
                    let _v120 = v126 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v127 : Ref<Str> = v119 |> unbox<Ref<Str>>
                    let _v120 = v127 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v130 : Ref<Str> = v119 |> unbox<Ref<Str>>
                    let _v120 = v130 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v133 : Ref<Str> = v119 |> unbox<Ref<Str>>
                    let _v120 = v133 
                    #endif
#else
                    let v136 : Ref<Str> = v119 |> unbox<Ref<Str>>
                    let _v120 = v136 
                    #endif
                    let v139 : Ref<Str> = _v120 
                    let v144 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v145 : string = "String::from($0)"
                    let v146 : std_string_String = Fable.Core.RustInterop.emitRustExpr v139 v145 
                    let _v144 = v146 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v147 : string = "String::from($0)"
                    let v148 : std_string_String = Fable.Core.RustInterop.emitRustExpr v139 v147 
                    let _v144 = v148 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v149 : string = "String::from($0)"
                    let v150 : std_string_String = Fable.Core.RustInterop.emitRustExpr v139 v149 
                    let _v144 = v150 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v151 : std_string_String = v139 |> unbox<std_string_String>
                    let _v144 = v151 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v154 : std_string_String = v139 |> unbox<std_string_String>
                    let _v144 = v154 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v157 : std_string_String = v139 |> unbox<std_string_String>
                    let _v144 = v157 
                    #endif
#else
                    let v160 : std_string_String = v139 |> unbox<std_string_String>
                    let _v144 = v160 
                    #endif
                    let v163 : std_string_String = _v144 
                    let v168 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v169 : string = "std::path::PathBuf::from($0)"
                    let v170 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v163 v169 
                    let _v168 = v170 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v171 : string = "std::path::PathBuf::from($0)"
                    let v172 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v163 v171 
                    let _v168 = v172 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v173 : string = "std::path::PathBuf::from($0)"
                    let v174 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v163 v173 
                    let _v168 = v174 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v175 : std_path_PathBuf = v163 |> unbox<std_path_PathBuf>
                    let _v168 = v175 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v178 : std_path_PathBuf = v163 |> unbox<std_path_PathBuf>
                    let _v168 = v178 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v181 : std_path_PathBuf = v163 |> unbox<std_path_PathBuf>
                    let _v168 = v181 
                    #endif
#else
                    let v184 : std_path_PathBuf = v163 |> unbox<std_path_PathBuf>
                    let _v168 = v184 
                    #endif
                    let v187 : std_path_PathBuf = _v168 
                    let v192 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v193 : string = "Ok($0)"
                    let v194 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v187 v193 
                    let _v192 = v194 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v195 : string = "Ok($0)"
                    let v196 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v187 v195 
                    let _v192 = v196 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v197 : string = "Ok($0)"
                    let v198 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v187 v197 
                    let _v192 = v198 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v199 : Result<std_path_PathBuf, std_io_Error> = v187 |> Ok
                    let _v192 = v199 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v200 : Result<std_path_PathBuf, std_io_Error> = v187 |> Ok
                    let _v192 = v200 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v201 : Result<std_path_PathBuf, std_io_Error> = v187 |> Ok
                    let _v192 = v201 
                    #endif
#else
                    let v202 : Result<std_path_PathBuf, std_io_Error> = v187 |> Ok
                    let _v192 = v202 
                    #endif
                    let v203 : Result<std_path_PathBuf, std_io_Error> = _v192 
                    v203
            else
                let v248 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / path: {v0} / error: {v24} / path': {v4} / name: {v5}"
                let v249 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v250 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v251 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v248 v250 
                let _v249 = v251 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v252 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v253 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v248 v252 
                let _v249 = v253 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v254 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v255 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v248 v254 
                let _v249 = v255 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v256 : std_io_Error = v248 |> unbox<std_io_Error>
                let _v249 = v256 
                #endif
#if FABLE_COMPILER_PYTHON
                let v259 : std_io_Error = v248 |> unbox<std_io_Error>
                let _v249 = v259 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v262 : std_io_Error = v248 |> unbox<std_io_Error>
                let _v249 = v262 
                #endif
#else
                let v265 : std_io_Error = v248 |> unbox<std_io_Error>
                let _v249 = v265 
                #endif
                let v268 : std_io_Error = _v249 
                let v273 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v274 : string = "Err($0)"
                let v275 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v268 v274 
                let _v273 = v275 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v276 : string = "Err($0)"
                let v277 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v268 v276 
                let _v273 = v277 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v278 : string = "Err($0)"
                let v279 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v268 v278 
                let _v273 = v279 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v280 : Result<std_path_PathBuf, std_io_Error> = v268 |> Error
                let _v273 = v280 
                #endif
#if FABLE_COMPILER_PYTHON
                let v281 : Result<std_path_PathBuf, std_io_Error> = v268 |> Error
                let _v273 = v281 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v282 : Result<std_path_PathBuf, std_io_Error> = v268 |> Error
                let _v273 = v282 
                #endif
#else
                let v283 : Result<std_path_PathBuf, std_io_Error> = v268 |> Error
                let _v273 = v283 
                #endif
                let v284 : Result<std_path_PathBuf, std_io_Error> = _v273 
                v284
        | _ ->
            let v288 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / path: {v0} / error: {v24} / path': {v4} / name: {v5}"
            let v289 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v290 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v291 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v288 v290 
            let _v289 = v291 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v292 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v293 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v288 v292 
            let _v289 = v293 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v294 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v295 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v288 v294 
            let _v289 = v295 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v296 : std_io_Error = v288 |> unbox<std_io_Error>
            let _v289 = v296 
            #endif
#if FABLE_COMPILER_PYTHON
            let v299 : std_io_Error = v288 |> unbox<std_io_Error>
            let _v289 = v299 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v302 : std_io_Error = v288 |> unbox<std_io_Error>
            let _v289 = v302 
            #endif
#else
            let v305 : std_io_Error = v288 |> unbox<std_io_Error>
            let _v289 = v305 
            #endif
            let v308 : std_io_Error = _v289 
            let v313 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v314 : string = "Err($0)"
            let v315 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v308 v314 
            let _v313 = v315 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v316 : string = "Err($0)"
            let v317 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v308 v316 
            let _v313 = v317 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v318 : string = "Err($0)"
            let v319 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v308 v318 
            let _v313 = v319 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v320 : Result<std_path_PathBuf, std_io_Error> = v308 |> Error
            let _v313 = v320 
            #endif
#if FABLE_COMPILER_PYTHON
            let v321 : Result<std_path_PathBuf, std_io_Error> = v308 |> Error
            let _v313 = v321 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v322 : Result<std_path_PathBuf, std_io_Error> = v308 |> Error
            let _v313 = v322 
            #endif
#else
            let v323 : Result<std_path_PathBuf, std_io_Error> = v308 |> Error
            let _v313 = v323 
            #endif
            let v324 : Result<std_path_PathBuf, std_io_Error> = _v313 
            v324
and method52 (v0 : string, v1 : uint8, v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v3 = v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v7 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v3 = v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v3 = v10 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v3 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v16 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v3 = v16 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v19 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v3 = v19 
    #endif
#else
    let v22 : System_IO_DirectoryInfo = v2 |> System_IO_DirectoryInfo 
    let _v3 = v22 
    #endif
    let v25 : System_IO_DirectoryInfo = _v3 
    let v30 : System.IO.FileAttributes = method49(v25)
    let v31 : System.IO.FileAttributes = method50()
    let v32 : bool = method51(v31, v30)
    if v32 then
        let v33 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v34 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v33 = v34 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v37 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v33 = v37 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v40 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v33 = v40 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v43 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v33 = v43 
        #endif
#if FABLE_COMPILER_PYTHON
        let v46 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v33 = v46 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v49 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v33 = v49 
        #endif
#else
        let v52 : System_IO_FileInfo = v2 |> System_IO_FileInfo 
        let _v33 = v52 
        #endif
        let v55 : System_IO_FileInfo = _v33 
        let v60 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v61 : string = null |> unbox<string>
        let _v60 = v61 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v64 : string = null |> unbox<string>
        let _v60 = v64 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v67 : string = null |> unbox<string>
        let _v60 = v67 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v70 : string = null |> unbox<string>
        let _v60 = v70 
        #endif
#if FABLE_COMPILER_PYTHON
        let v73 : string = null |> unbox<string>
        let _v60 = v73 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v76 : string = null |> unbox<string>
        let _v60 = v76 
        #endif
#else
        let v79 : (System_IO_FileInfo -> string) = _.LinkTarget
        let v80 : string = v79 v55
        let _v60 = v80 
        #endif
        let v81 : string = _v60 
        let v86 : std_path_PathBuf = v81 |> unbox<std_path_PathBuf>
        let v89 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v90 : string = "Ok($0)"
        let v91 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v86 v90 
        let _v89 = v91 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v92 : string = "Ok($0)"
        let v93 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v86 v92 
        let _v89 = v93 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v94 : string = "Ok($0)"
        let v95 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v86 v94 
        let _v89 = v95 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v96 : Result<std_path_PathBuf, std_io_Error> = v86 |> Ok
        let _v89 = v96 
        #endif
#if FABLE_COMPILER_PYTHON
        let v97 : Result<std_path_PathBuf, std_io_Error> = v86 |> Ok
        let _v89 = v97 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v98 : Result<std_path_PathBuf, std_io_Error> = v86 |> Ok
        let _v89 = v98 
        #endif
#else
        let v99 : Result<std_path_PathBuf, std_io_Error> = v86 |> Ok
        let _v89 = v99 
        #endif
        let v100 : Result<std_path_PathBuf, std_io_Error> = _v89 
        v100
    else
        let v103 : string = $"file_system.read_link / Fsharp / The file or directory is not a reparse point. / path: {v0} / result: {v32} / path': {v2} / n: {v1}"
        let v104 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v105 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v106 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v103 v105 
        let _v104 = v106 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v107 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v108 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v103 v107 
        let _v104 = v108 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v109 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v110 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v103 v109 
        let _v104 = v110 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v111 : std_io_Error = v103 |> unbox<std_io_Error>
        let _v104 = v111 
        #endif
#if FABLE_COMPILER_PYTHON
        let v114 : std_io_Error = v103 |> unbox<std_io_Error>
        let _v104 = v114 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v117 : std_io_Error = v103 |> unbox<std_io_Error>
        let _v104 = v117 
        #endif
#else
        let v120 : std_io_Error = v103 |> unbox<std_io_Error>
        let _v104 = v120 
        #endif
        let v123 : std_io_Error = _v104 
        let v128 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
        method53(v0, v128, v1, v123, v2)
and closure20 (v0 : string, v1 : uint8) (v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    method52(v0, v1, v2)
and closure19 (v0 : string) (v1 : uint8) : (string -> Result<std_path_PathBuf, std_io_Error>) =
    closure20(v0, v1)
and method54 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : std_io_Error) : Result<std_path_PathBuf, std_io_Error> =
    let v4 : string = method45(v0)
    let v5 : string option = method29(v0)
    let v6 : (string -> US5) = method6()
    let v7 : US5 option = v5 |> Option.map v6 
    let v18 : US5 = US5_1
    let v19 : US5 = v7 |> Option.defaultValue v18 
    let v23 : string = method40(v3)
    let v24 : bool = v2 >= 11uy
    if v24 then
        let v25 : string = $"file_system.read_link / path: {v0} / n: {v2} / path': {v0} / name: {v4}"
        let v26 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v27 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v28 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v25 v27 
        let _v26 = v28 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v29 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v30 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v25 v29 
        let _v26 = v30 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v31 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v32 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v25 v31 
        let _v26 = v32 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v33 : std_io_Error = v25 |> unbox<std_io_Error>
        let _v26 = v33 
        #endif
#if FABLE_COMPILER_PYTHON
        let v36 : std_io_Error = v25 |> unbox<std_io_Error>
        let _v26 = v36 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v39 : std_io_Error = v25 |> unbox<std_io_Error>
        let _v26 = v39 
        #endif
#else
        let v42 : std_io_Error = v25 |> unbox<std_io_Error>
        let _v26 = v42 
        #endif
        let v45 : std_io_Error = _v26 
        let v50 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v51 : string = "Err($0)"
        let v52 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v45 v51 
        let _v50 = v52 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v53 : string = "Err($0)"
        let v54 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v45 v53 
        let _v50 = v54 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v55 : string = "Err($0)"
        let v56 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v45 v55 
        let _v50 = v56 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v57 : Result<std_path_PathBuf, std_io_Error> = v45 |> Error
        let _v50 = v57 
        #endif
#if FABLE_COMPILER_PYTHON
        let v58 : Result<std_path_PathBuf, std_io_Error> = v45 |> Error
        let _v50 = v58 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v59 : Result<std_path_PathBuf, std_io_Error> = v45 |> Error
        let _v50 = v59 
        #endif
#else
        let v60 : Result<std_path_PathBuf, std_io_Error> = v45 |> Error
        let _v50 = v60 
        #endif
        let v61 : Result<std_path_PathBuf, std_io_Error> = _v50 
        v61
    else
        match v19 with
        | US5_0(v64) -> (* Some *)
            let v65 : string = ""
            let v66 : bool = v0 <> v65 
            if v66 then
                let v69 : uint8 = v2 + 1uy
                let v70 : (string -> Result<std_path_PathBuf, std_io_Error>) = v1 v69
                let v71 : Result<std_path_PathBuf, std_io_Error> = v70 v64
                let v72 : (std_io_Error -> string) = method39()
                let v73 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v74 : string = "$0.map_err(|x| $1(x))"
                let v75 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v71, v72) v74 
                let _v73 = v75 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v76 : string = "$0.map_err(|x| $1(x))"
                let v77 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v71, v72) v76 
                let _v73 = v77 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v78 : string = "$0.map_err(|x| $1(x))"
                let v79 : Result<std_path_PathBuf, string> = Fable.Core.RustInterop.emitRustExpr struct (v71, v72) v78 
                let _v73 = v79 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v80 : Result<std_path_PathBuf, string> = match v71 with Ok x -> Ok x | Error x -> Error (v72 x)
                let _v73 = v80 
                #endif
#if FABLE_COMPILER_PYTHON
                let v81 : Result<std_path_PathBuf, string> = match v71 with Ok x -> Ok x | Error x -> Error (v72 x)
                let _v73 = v81 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v82 : Result<std_path_PathBuf, string> = match v71 with Ok x -> Ok x | Error x -> Error (v72 x)
                let _v73 = v82 
                #endif
#else
                let v83 : Result<std_path_PathBuf, string> = match v71 with Ok x -> Ok x | Error x -> Error (v72 x)
                let _v73 = v83 
                #endif
                let v84 : Result<std_path_PathBuf, string> = _v73 
                let v87 : (std_path_PathBuf -> US8) = method41()
                let v88 : (string -> US8) = method42()
                let v89 : US8 = match v84 with Ok x -> v87 x | Error x -> v88 x
                match v89 with
                | US8_1(v205) -> (* Error *)
                    let v206 : string = $"file_system.read_link / error': {v205} / error: {v23} / name: {v4}"
                    let v207 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v208 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v209 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v206 v208 
                    let _v207 = v209 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v210 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v211 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v206 v210 
                    let _v207 = v211 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v212 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                    let v213 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v206 v212 
                    let _v207 = v213 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v214 : std_io_Error = v206 |> unbox<std_io_Error>
                    let _v207 = v214 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v217 : std_io_Error = v206 |> unbox<std_io_Error>
                    let _v207 = v217 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v220 : std_io_Error = v206 |> unbox<std_io_Error>
                    let _v207 = v220 
                    #endif
#else
                    let v223 : std_io_Error = v206 |> unbox<std_io_Error>
                    let _v207 = v223 
                    #endif
                    let v226 : std_io_Error = _v207 
                    let v231 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v232 : string = "Err($0)"
                    let v233 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v226 v232 
                    let _v231 = v233 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v234 : string = "Err($0)"
                    let v235 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v226 v234 
                    let _v231 = v235 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v236 : string = "Err($0)"
                    let v237 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v226 v236 
                    let _v231 = v237 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v238 : Result<std_path_PathBuf, std_io_Error> = v226 |> Error
                    let _v231 = v238 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v239 : Result<std_path_PathBuf, std_io_Error> = v226 |> Error
                    let _v231 = v239 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v240 : Result<std_path_PathBuf, std_io_Error> = v226 |> Error
                    let _v231 = v240 
                    #endif
#else
                    let v241 : Result<std_path_PathBuf, std_io_Error> = v226 |> Error
                    let _v231 = v241 
                    #endif
                    let v242 : Result<std_path_PathBuf, std_io_Error> = _v231 
                    v242
                | US8_0(v90) -> (* Ok *)
                    let v91 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v92 : string = "$0.display()"
                    let v93 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v90 v92 
                    let _v91 = v93 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v94 : string = "$0.display()"
                    let v95 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v90 v94 
                    let _v91 = v95 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v96 : string = "$0.display()"
                    let v97 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v90 v96 
                    let _v91 = v97 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v98 : std_path_Display = v90 |> unbox<std_path_Display>
                    let _v91 = v98 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v101 : std_path_Display = v90 |> unbox<std_path_Display>
                    let _v91 = v101 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v104 : std_path_Display = v90 |> unbox<std_path_Display>
                    let _v91 = v104 
                    #endif
#else
                    let v107 : std_path_Display = v90 |> unbox<std_path_Display>
                    let _v91 = v107 
                    #endif
                    let v110 : std_path_Display = _v91 
                    let v115 : string = v110 |> string 
                    let v118 : string = method26(v115, v4)
                    let v119 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v120 : string = "&*$0"
                    let v121 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v118 v120 
                    let _v119 = v121 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v122 : string = "&*$0"
                    let v123 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v118 v122 
                    let _v119 = v123 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v124 : string = "&*$0"
                    let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v118 v124 
                    let _v119 = v125 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v126 : Ref<Str> = v118 |> unbox<Ref<Str>>
                    let _v119 = v126 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v129 : Ref<Str> = v118 |> unbox<Ref<Str>>
                    let _v119 = v129 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v132 : Ref<Str> = v118 |> unbox<Ref<Str>>
                    let _v119 = v132 
                    #endif
#else
                    let v135 : Ref<Str> = v118 |> unbox<Ref<Str>>
                    let _v119 = v135 
                    #endif
                    let v138 : Ref<Str> = _v119 
                    let v143 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v144 : string = "String::from($0)"
                    let v145 : std_string_String = Fable.Core.RustInterop.emitRustExpr v138 v144 
                    let _v143 = v145 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v146 : string = "String::from($0)"
                    let v147 : std_string_String = Fable.Core.RustInterop.emitRustExpr v138 v146 
                    let _v143 = v147 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v148 : string = "String::from($0)"
                    let v149 : std_string_String = Fable.Core.RustInterop.emitRustExpr v138 v148 
                    let _v143 = v149 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v150 : std_string_String = v138 |> unbox<std_string_String>
                    let _v143 = v150 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v153 : std_string_String = v138 |> unbox<std_string_String>
                    let _v143 = v153 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v156 : std_string_String = v138 |> unbox<std_string_String>
                    let _v143 = v156 
                    #endif
#else
                    let v159 : std_string_String = v138 |> unbox<std_string_String>
                    let _v143 = v159 
                    #endif
                    let v162 : std_string_String = _v143 
                    let v167 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v168 : string = "std::path::PathBuf::from($0)"
                    let v169 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v162 v168 
                    let _v167 = v169 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v170 : string = "std::path::PathBuf::from($0)"
                    let v171 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v162 v170 
                    let _v167 = v171 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v172 : string = "std::path::PathBuf::from($0)"
                    let v173 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v162 v172 
                    let _v167 = v173 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v174 : std_path_PathBuf = v162 |> unbox<std_path_PathBuf>
                    let _v167 = v174 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v177 : std_path_PathBuf = v162 |> unbox<std_path_PathBuf>
                    let _v167 = v177 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v180 : std_path_PathBuf = v162 |> unbox<std_path_PathBuf>
                    let _v167 = v180 
                    #endif
#else
                    let v183 : std_path_PathBuf = v162 |> unbox<std_path_PathBuf>
                    let _v167 = v183 
                    #endif
                    let v186 : std_path_PathBuf = _v167 
                    let v191 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v192 : string = "Ok($0)"
                    let v193 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v186 v192 
                    let _v191 = v193 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v194 : string = "Ok($0)"
                    let v195 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v186 v194 
                    let _v191 = v195 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v196 : string = "Ok($0)"
                    let v197 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v186 v196 
                    let _v191 = v197 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v198 : Result<std_path_PathBuf, std_io_Error> = v186 |> Ok
                    let _v191 = v198 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v199 : Result<std_path_PathBuf, std_io_Error> = v186 |> Ok
                    let _v191 = v199 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v200 : Result<std_path_PathBuf, std_io_Error> = v186 |> Ok
                    let _v191 = v200 
                    #endif
#else
                    let v201 : Result<std_path_PathBuf, std_io_Error> = v186 |> Ok
                    let _v191 = v201 
                    #endif
                    let v202 : Result<std_path_PathBuf, std_io_Error> = _v191 
                    v202
            else
                let v247 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / path: {v0} / error: {v23} / path': {v0} / name: {v4}"
                let v248 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v249 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v250 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v247 v249 
                let _v248 = v250 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v251 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v252 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v247 v251 
                let _v248 = v252 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v253 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
                let v254 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v247 v253 
                let _v248 = v254 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v255 : std_io_Error = v247 |> unbox<std_io_Error>
                let _v248 = v255 
                #endif
#if FABLE_COMPILER_PYTHON
                let v258 : std_io_Error = v247 |> unbox<std_io_Error>
                let _v248 = v258 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v261 : std_io_Error = v247 |> unbox<std_io_Error>
                let _v248 = v261 
                #endif
#else
                let v264 : std_io_Error = v247 |> unbox<std_io_Error>
                let _v248 = v264 
                #endif
                let v267 : std_io_Error = _v248 
                let v272 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v273 : string = "Err($0)"
                let v274 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v267 v273 
                let _v272 = v274 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v275 : string = "Err($0)"
                let v276 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v267 v275 
                let _v272 = v276 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v277 : string = "Err($0)"
                let v278 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v267 v277 
                let _v272 = v278 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v279 : Result<std_path_PathBuf, std_io_Error> = v267 |> Error
                let _v272 = v279 
                #endif
#if FABLE_COMPILER_PYTHON
                let v280 : Result<std_path_PathBuf, std_io_Error> = v267 |> Error
                let _v272 = v280 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v281 : Result<std_path_PathBuf, std_io_Error> = v267 |> Error
                let _v272 = v281 
                #endif
#else
                let v282 : Result<std_path_PathBuf, std_io_Error> = v267 |> Error
                let _v272 = v282 
                #endif
                let v283 : Result<std_path_PathBuf, std_io_Error> = _v272 
                v283
        | _ ->
            let v287 : string = $"file_system.read_link / run / The file or directory is not a reparse point. / path: {v0} / error: {v23} / path': {v0} / name: {v4}"
            let v288 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v289 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v290 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v287 v289 
            let _v288 = v290 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v291 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v292 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v287 v291 
            let _v288 = v292 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v293 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
            let v294 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v287 v293 
            let _v288 = v294 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v295 : std_io_Error = v287 |> unbox<std_io_Error>
            let _v288 = v295 
            #endif
#if FABLE_COMPILER_PYTHON
            let v298 : std_io_Error = v287 |> unbox<std_io_Error>
            let _v288 = v298 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v301 : std_io_Error = v287 |> unbox<std_io_Error>
            let _v288 = v301 
            #endif
#else
            let v304 : std_io_Error = v287 |> unbox<std_io_Error>
            let _v288 = v304 
            #endif
            let v307 : std_io_Error = _v288 
            let v312 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v313 : string = "Err($0)"
            let v314 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v307 v313 
            let _v312 = v314 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v315 : string = "Err($0)"
            let v316 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v307 v315 
            let _v312 = v316 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v317 : string = "Err($0)"
            let v318 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v307 v317 
            let _v312 = v318 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v319 : Result<std_path_PathBuf, std_io_Error> = v307 |> Error
            let _v312 = v319 
            #endif
#if FABLE_COMPILER_PYTHON
            let v320 : Result<std_path_PathBuf, std_io_Error> = v307 |> Error
            let _v312 = v320 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v321 : Result<std_path_PathBuf, std_io_Error> = v307 |> Error
            let _v312 = v321 
            #endif
#else
            let v322 : Result<std_path_PathBuf, std_io_Error> = v307 |> Error
            let _v312 = v322 
            #endif
            let v323 : Result<std_path_PathBuf, std_io_Error> = _v312 
            v323
and method48 (v0 : string, v1 : uint8) : Result<std_path_PathBuf, std_io_Error> =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v2 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v2 = v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v2 = v15 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v18 : System_IO_DirectoryInfo = null |> unbox<System_IO_DirectoryInfo>
    let _v2 = v18 
    #endif
#else
    let v21 : System_IO_DirectoryInfo = v0 |> System_IO_DirectoryInfo 
    let _v2 = v21 
    #endif
    let v24 : System_IO_DirectoryInfo = _v2 
    let v29 : System.IO.FileAttributes = method49(v24)
    let v30 : System.IO.FileAttributes = method50()
    let v31 : bool = method51(v30, v29)
    if v31 then
        let v32 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v33 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v32 = v33 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v36 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v32 = v36 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v39 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v32 = v39 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v42 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v32 = v42 
        #endif
#if FABLE_COMPILER_PYTHON
        let v45 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v32 = v45 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v48 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v32 = v48 
        #endif
#else
        let v51 : System_IO_FileInfo = v0 |> System_IO_FileInfo 
        let _v32 = v51 
        #endif
        let v54 : System_IO_FileInfo = _v32 
        let v59 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v60 : string = null |> unbox<string>
        let _v59 = v60 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v63 : string = null |> unbox<string>
        let _v59 = v63 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v66 : string = null |> unbox<string>
        let _v59 = v66 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v69 : string = null |> unbox<string>
        let _v59 = v69 
        #endif
#if FABLE_COMPILER_PYTHON
        let v72 : string = null |> unbox<string>
        let _v59 = v72 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v75 : string = null |> unbox<string>
        let _v59 = v75 
        #endif
#else
        let v78 : (System_IO_FileInfo -> string) = _.LinkTarget
        let v79 : string = v78 v54
        let _v59 = v79 
        #endif
        let v80 : string = _v59 
        let v85 : std_path_PathBuf = v80 |> unbox<std_path_PathBuf>
        let v88 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v89 : string = "Ok($0)"
        let v90 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v85 v89 
        let _v88 = v90 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v91 : string = "Ok($0)"
        let v92 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v85 v91 
        let _v88 = v92 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v93 : string = "Ok($0)"
        let v94 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v85 v93 
        let _v88 = v94 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v95 : Result<std_path_PathBuf, std_io_Error> = v85 |> Ok
        let _v88 = v95 
        #endif
#if FABLE_COMPILER_PYTHON
        let v96 : Result<std_path_PathBuf, std_io_Error> = v85 |> Ok
        let _v88 = v96 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v97 : Result<std_path_PathBuf, std_io_Error> = v85 |> Ok
        let _v88 = v97 
        #endif
#else
        let v98 : Result<std_path_PathBuf, std_io_Error> = v85 |> Ok
        let _v88 = v98 
        #endif
        let v99 : Result<std_path_PathBuf, std_io_Error> = _v88 
        v99
    else
        let v102 : string = $"file_system.read_link / Fsharp / The file or directory is not a reparse point. / path: {v0} / result: {v31} / path': {v0} / n: {v1}"
        let v103 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v104 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v105 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v102 v104 
        let _v103 = v105 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v106 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v107 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v102 v106 
        let _v103 = v107 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v108 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v109 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v102 v108 
        let _v103 = v109 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v110 : std_io_Error = v102 |> unbox<std_io_Error>
        let _v103 = v110 
        #endif
#if FABLE_COMPILER_PYTHON
        let v113 : std_io_Error = v102 |> unbox<std_io_Error>
        let _v103 = v113 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v116 : std_io_Error = v102 |> unbox<std_io_Error>
        let _v103 = v116 
        #endif
#else
        let v119 : std_io_Error = v102 |> unbox<std_io_Error>
        let _v103 = v119 
        #endif
        let v122 : std_io_Error = _v103 
        let v127 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure19(v0)
        method54(v0, v127, v1, v122)
and method37 (v0 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : bool = method28(v0)
    let v7 : Result<std_path_PathBuf, std_io_Error> =
        if v2 then
            let v3 : string = "std::fs::read_link(&*$0)"
            let v4 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v3 
            v4
        else
            let v5 : uint8 = 0uy
            method38(v0, v5)
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : bool = method28(v0)
    let v13 : Result<std_path_PathBuf, std_io_Error> =
        if v8 then
            let v9 : string = "std::fs::read_link(&*$0)"
            let v10 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v9 
            v10
        else
            let v11 : uint8 = 0uy
            method38(v0, v11)
    let _v1 = v13 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v14 : bool = method28(v0)
    let v19 : Result<std_path_PathBuf, std_io_Error> =
        if v14 then
            let v15 : string = "std::fs::read_link(&*$0)"
            let v16 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v15 
            v16
        else
            let v17 : uint8 = 0uy
            method38(v0, v17)
    let _v1 = v19 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : Result<std_path_PathBuf, std_io_Error> = null |> unbox<Result<std_path_PathBuf, std_io_Error>>
    let _v1 = v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : Result<std_path_PathBuf, std_io_Error> = Unchecked.defaultof<_>
    let _v1 = v23 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v24 : uint8 = 0uy
    let v25 : Result<std_path_PathBuf, std_io_Error> = method48(v0, v24)
    let _v1 = v25 
    #endif
#else
    let v26 : uint8 = 0uy
    let v27 : Result<std_path_PathBuf, std_io_Error> = method48(v0, v26)
    let _v1 = v27 
    #endif
    let v28 : Result<std_path_PathBuf, std_io_Error> = _v1 
    v28
and closure21 () (v0 : std_path_PathBuf) : US9 =
    US9_0(v0)
and method55 () : (std_path_PathBuf -> US9) =
    closure21()
and method57 (v0 : string) : string =
    v0
and method56 (v0 : string, v1 : string, v2 : string) : string =
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = $"regex::Regex::new(&$0)"
    let v5 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = "$0.unwrap()"
    let v8 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v5 v7 
    let _v6 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : string = "$0.unwrap()"
    let v10 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v5 v9 
    let _v6 = v10 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v11 : string = "$0.unwrap()"
    let v12 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v5 v11 
    let _v6 = v12 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : regex_Regex = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v6 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : regex_Regex = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v6 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : regex_Regex = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v6 = v15 
    #endif
#else
    let v16 : regex_Regex = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v6 = v16 
    #endif
    let v17 : regex_Regex = _v6 
    let v20 : string = method57(v2)
    let v21 : string = $"$0.replace_all(&*$1, &*$2)"
    let v22 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v17, v20, v1) v21 
    let v23 : string = "String::from($0)"
    let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "fable_library_rust::String_::fromString($0)"
    let v26 : string = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let _v3 = v26 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v27 : string = null |> unbox<string>
    let _v3 = v27 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : string = null |> unbox<string>
    let _v3 = v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : string = null |> unbox<string>
    let _v3 = v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v36 : string = null |> unbox<string>
    let _v3 = v36 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v39 : string = null |> unbox<string>
    let _v3 = v39 
    #endif
#else
    let v42 : string = System.Text.RegularExpressions.Regex.Replace (v2, v0, v1)
    let _v3 = v42 
    #endif
    let v43 : string = _v3 
    v43
and method36 (v0 : string) : string =
    let v1 : bool = v0 = ""
    if v1 then
        let v2 : string = ""
        v2
    else
        let v3 : Result<std_path_PathBuf, std_io_Error> = method37(v0)
        let v4 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v5 : string = "$0.ok()"
        let v6 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v3 v5 
        let _v4 = v6 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v7 : string = "$0.ok()"
        let v8 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v3 v7 
        let _v4 = v8 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v9 : string = "$0.ok()"
        let v10 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v3 v9 
        let _v4 = v10 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v11 : std_path_PathBuf option = match v3 with Ok x -> Some x | Error _ -> None
        let _v4 = v11 
        #endif
#if FABLE_COMPILER_PYTHON
        let v12 : std_path_PathBuf option = match v3 with Ok x -> Some x | Error _ -> None
        let _v4 = v12 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v13 : std_path_PathBuf option = match v3 with Ok x -> Some x | Error _ -> None
        let _v4 = v13 
        #endif
#else
        let v14 : std_path_PathBuf option = match v3 with Ok x -> Some x | Error _ -> None
        let _v4 = v14 
        #endif
        let v15 : std_path_PathBuf option = _v4 
        let v18 : (std_path_PathBuf -> US9) = method55()
        let v19 : US9 option = v15 |> Option.map v18 
        let v30 : US9 = US9_1
        let v31 : US9 = v19 |> Option.defaultValue v30 
        let v66 : string =
            match v31 with
            | US9_1 -> (* None *)
                v0
            | US9_0(v35) -> (* Some *)
                let v36 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v37 : string = "$0.display()"
                let v38 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v35 v37 
                let _v36 = v38 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v39 : string = "$0.display()"
                let v40 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v35 v39 
                let _v36 = v40 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v41 : string = "$0.display()"
                let v42 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v35 v41 
                let _v36 = v42 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v43 : std_path_Display = v35 |> unbox<std_path_Display>
                let _v36 = v43 
                #endif
#if FABLE_COMPILER_PYTHON
                let v46 : std_path_Display = v35 |> unbox<std_path_Display>
                let _v36 = v46 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v49 : std_path_Display = v35 |> unbox<std_path_Display>
                let _v36 = v49 
                #endif
#else
                let v52 : std_path_Display = v35 |> unbox<std_path_Display>
                let _v36 = v52 
                #endif
                let v55 : std_path_Display = _v36 
                let v60 : string = v55 |> string 
                let v63 : bool = v60 = ""
                if v63 then
                    v0
                else
                    v60
        let v67 : bool = v66 = ""
        if v67 then
            let v68 : string = ""
            v68
        else
            let v69 : string = "^\\\\\\\\\\?\\\\"
            let v70 : string = ""
            let v71 : string = method56(v69, v70, v66)
            let v72 : string = $"{v71.[0] |> string |> _.ToLower()}{v71.[1..]}"
            let v73 : string = "\\"
            let v74 : string = "/"
            let v75 : string = v72.Replace (v73, v74)
            v75
and method58 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method59 (v0 : int32, v1 : Mut6) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method60 () : char =
    let v0 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = "std::path::MAIN_SEPARATOR"
    let v2 : char = Fable.Core.RustInterop.emitRustExpr () v1 
    let _v0 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : char = System.IO.Path.DirectorySeparatorChar
    let _v0 = v3 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v4 : char = System.IO.Path.DirectorySeparatorChar
    let _v0 = v4 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v5 : char = System.IO.Path.DirectorySeparatorChar
    let _v0 = v5 
    #endif
#if FABLE_COMPILER_PYTHON
    let v6 : char = System.IO.Path.DirectorySeparatorChar
    let _v0 = v6 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v7 : char = System.IO.Path.DirectorySeparatorChar
    let _v0 = v7 
    #endif
#else
    let v8 : char = System.IO.Path.DirectorySeparatorChar
    let _v0 = v8 
    #endif
    let v9 : char = _v0 
    v9
and method61 (v0 : string) : string =
    v0
and method35 (v0 : string) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "&*$0"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let _v2 = v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = "&*$0"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v5 
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = "&*$0"
    let v8 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v7 
    let _v2 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v12 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v12 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v15 
    #endif
#else
    let v18 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v18 
    #endif
    let v21 : Ref<Str> = _v2 
    let v26 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = "String::from($0)"
    let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v27 
    let _v26 = v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "String::from($0)"
    let v30 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v29 
    let _v26 = v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = "String::from($0)"
    let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v31 
    let _v26 = v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v36 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v36 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v39 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v39 
    #endif
#else
    let v42 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v42 
    #endif
    let v45 : std_string_String = _v26 
    let v50 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v51 : string = "std::path::PathBuf::from($0)"
    let v52 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v51 
    let _v50 = v52 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v53 : string = "std::path::PathBuf::from($0)"
    let v54 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v53 
    let _v50 = v54 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v55 : string = "std::path::PathBuf::from($0)"
    let v56 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v55 
    let _v50 = v56 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v57 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v57 
    #endif
#if FABLE_COMPILER_PYTHON
    let v60 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v60 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v63 
    #endif
#else
    let v66 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v66 
    #endif
    let v69 : std_path_PathBuf = _v50 
    let v74 : string = "$0.exists()"
    let v75 : bool = Fable.Core.RustInterop.emitRustExpr v69 v74 
    let v76 : bool = v75 = false
    let v232 : string =
        if v76 then
            let v77 : string = method34()
            let v78 : string = method26(v77, v0)
            let v79 : string = method36(v78)
            let v80 : string = "/"
            let v81 : (string []) = v79.Split v80 
            let v84 : (string []) = [||]
            let v85 : int32 = v81.Length
            let v86 : Mut5 = {l0 = 0; l1 = 0; l2 = v84} : Mut5
            while method58(v85, v86) do
                let v88 : int32 = v86.l0
                let v89 : int32 =  -v88
                let v90 : int32 = v89 + v85
                let v91 : int32 = v90 - 1
                let struct (v92 : int32, v93 : (string [])) = v86.l1, v86.l2
                let v94 : string = v81.[int v91]
                let v95 : bool = ".." = v94
                let struct (v139 : int32, v140 : (string [])) =
                    if v95 then
                        let v96 : int32 = v92 + 1
                        struct (v96, v93)
                    else
                        let v97 : bool = "." = v94
                        if v97 then
                            struct (v92, v93)
                        else
                            let v98 : bool = 0 = v92
                            if v98 then
                                let v99 : string = ":"
                                let v100 : bool = v94.EndsWith (v99, false, null)
                                if v100 then
                                    let v103 : string = $"{v77.[0]}:"
                                    let v104 : (string []) = [|v103|]
                                    let v105 : int32 = v104.Length
                                    let v106 : int32 = v93.Length
                                    let v107 : int32 = v105 + v106
                                    let v108 : (string []) = Array.zeroCreate<string> (v107)
                                    let v109 : Mut6 = {l0 = 0} : Mut6
                                    while method59(v107, v109) do
                                        let v111 : int32 = v109.l0
                                        let v112 : bool = v111 < v105
                                        let v116 : string =
                                            if v112 then
                                                let v113 : string = v104.[int v111]
                                                v113
                                            else
                                                let v114 : int32 = v111 - v105
                                                let v115 : string = v93.[int v114]
                                                v115
                                        v108.[int v111] <- v116
                                        let v117 : int32 = v111 + 1
                                        v109.l0 <- v117
                                        ()
                                    struct (0, v108)
                                else
                                    let v118 : (string []) = [|v94|]
                                    let v119 : int32 = v118.Length
                                    let v120 : int32 = v93.Length
                                    let v121 : int32 = v119 + v120
                                    let v122 : (string []) = Array.zeroCreate<string> (v121)
                                    let v123 : Mut6 = {l0 = 0} : Mut6
                                    while method59(v121, v123) do
                                        let v125 : int32 = v123.l0
                                        let v126 : bool = v125 < v119
                                        let v130 : string =
                                            if v126 then
                                                let v127 : string = v118.[int v125]
                                                v127
                                            else
                                                let v128 : int32 = v125 - v119
                                                let v129 : string = v93.[int v128]
                                                v129
                                        v122.[int v125] <- v130
                                        let v131 : int32 = v125 + 1
                                        v123.l0 <- v131
                                        ()
                                    struct (0, v122)
                            else
                                let v134 : int32 = v92 - 1
                                struct (v134, v93)
                let v141 : int32 = v88 + 1
                v86.l0 <- v141
                v86.l1 <- v139
                v86.l2 <- v140
                ()
            let struct (v142 : int32, v143 : (string [])) = v86.l1, v86.l2
            let v144 : unit = ()
            let _v144 =
                seq {
                    for i = 0 to v143.Length - 1 do yield v143.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v147 : string seq = _v144 
            let v153 : char = method60()
            let v154 : (char -> string) = _.ToString()
            let v155 : string = v154 v153
            let v158 : bool = v155 = "\n"
            let v160 : string =
                if v158 then
                    method61(v155)
                else
                    v155
            let v161 : (string -> (string seq -> string)) = String.concat
            let v162 : (string seq -> string) = v161 v160
            v162 v147
        else
            let v166 : string = "std::fs::canonicalize(&*$0)"
            let v167 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v166 
            let v168 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v169 : string = "$0.unwrap()"
            let v170 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v167 v169 
            let _v168 = v170 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v171 : string = "$0.unwrap()"
            let v172 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v167 v171 
            let _v168 = v172 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v173 : string = "$0.unwrap()"
            let v174 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v167 v173 
            let _v168 = v174 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v175 : std_path_PathBuf = match v167 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v168 = v175 
            #endif
#if FABLE_COMPILER_PYTHON
            let v176 : std_path_PathBuf = match v167 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v168 = v176 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v177 : std_path_PathBuf = match v167 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v168 = v177 
            #endif
#else
            let v178 : std_path_PathBuf = match v167 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v168 = v178 
            #endif
            let v179 : std_path_PathBuf = _v168 
            let v182 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v183 : string = "$0.display()"
            let v184 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v179 v183 
            let _v182 = v184 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v185 : string = "$0.display()"
            let v186 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v179 v185 
            let _v182 = v186 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v187 : string = "$0.display()"
            let v188 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v179 v187 
            let _v182 = v188 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v189 : std_path_Display = v179 |> unbox<std_path_Display>
            let _v182 = v189 
            #endif
#if FABLE_COMPILER_PYTHON
            let v192 : std_path_Display = v179 |> unbox<std_path_Display>
            let _v182 = v192 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v195 : std_path_Display = v179 |> unbox<std_path_Display>
            let _v182 = v195 
            #endif
#else
            let v198 : std_path_Display = v179 |> unbox<std_path_Display>
            let _v182 = v198 
            #endif
            let v201 : std_path_Display = _v182 
            let v206 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v207 : string = "format!(\"{}\", $0)"
            let v208 : std_string_String = Fable.Core.RustInterop.emitRustExpr v201 v207 
            let _v206 = v208 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v209 : string = "format!(\"{}\", $0)"
            let v210 : std_string_String = Fable.Core.RustInterop.emitRustExpr v201 v209 
            let _v206 = v210 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v211 : string = "format!(\"{}\", $0)"
            let v212 : std_string_String = Fable.Core.RustInterop.emitRustExpr v201 v211 
            let _v206 = v212 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v213 : std_string_String = null |> unbox<std_string_String>
            let _v206 = v213 
            #endif
#if FABLE_COMPILER_PYTHON
            let v216 : std_string_String = null |> unbox<std_string_String>
            let _v206 = v216 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v219 : std_string_String = null |> unbox<std_string_String>
            let _v206 = v219 
            #endif
#else
            let v222 : std_string_String = null |> unbox<std_string_String>
            let _v206 = v222 
            #endif
            let v225 : std_string_String = _v206 
            let v230 : string = "fable_library_rust::String_::fromString($0)"
            let v231 : string = Fable.Core.RustInterop.emitRustExpr v225 v230 
            v231
    let _v1 = v232 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v233 : string = null |> unbox<string>
    let _v1 = v233 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v236 : string = null |> unbox<string>
    let _v1 = v236 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v239 : string = null |> unbox<string>
    let _v1 = v239 
    #endif
#if FABLE_COMPILER_PYTHON
    let v242 : string = null |> unbox<string>
    let _v1 = v242 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v245 : string = null |> unbox<string>
    let _v1 = v245 
    #endif
#else
    let v248 : (string -> string) = System.IO.Path.GetFullPath
    let v249 : string = v248 v0
    let _v1 = v249 
    #endif
    let v250 : string = _v1 
    v250
and method62 () : string =
    
    
    
    
    
    let v0 : string = "Debug"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method13(v5)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "inline_colorization::color_bright_blue"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v11 
    let _v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v13 
    let _v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v15 
    let _v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v23 
    #endif
#else
    let v26 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v26 
    #endif
    let v29 : Ref<Str> = _v10 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9, v29, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v7 = v39 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v40 : string = "inline_colorization::color_bright_blue"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v43 : string = "&*$0"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v43 
    let _v42 = v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : string = "&*$0"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v45 
    let _v42 = v46 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v47 : string = "&*$0"
    let v48 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v47 
    let _v42 = v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v49 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v49 
    #endif
#if FABLE_COMPILER_PYTHON
    let v52 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v52 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v55 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v55 
    #endif
#else
    let v58 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v58 
    #endif
    let v61 : Ref<Str> = _v42 
    let v66 : string = "inline_colorization::color_reset"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v61, v67) v68 
    let v70 : string = "fable_library_rust::String_::fromString($0)"
    let v71 : string = Fable.Core.RustInterop.emitRustExpr v69 v70 
    let _v7 = v71 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v72 : string = "inline_colorization::color_bright_blue"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v75 : string = "&*$0"
    let v76 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v75 
    let _v74 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "&*$0"
    let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v77 
    let _v74 = v78 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : string = "&*$0"
    let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v79 
    let _v74 = v80 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v81 
    #endif
#if FABLE_COMPILER_PYTHON
    let v84 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v84 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v87 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v87 
    #endif
#else
    let v90 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v90 
    #endif
    let v93 : Ref<Str> = _v74 
    let v98 : string = "inline_colorization::color_reset"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v98 
    let v100 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v73, v93, v99) v100 
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let _v7 = v103 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v104 : string = "\u001b[94m"
    let v105 : string = method15()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[94m"
    let v109 : string = method15()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[94m"
    let v113 : string = method15()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[94m"
    let v117 : string = method15()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method64 (v0 : string, v1 : string, v2 : string, v3 : string) : string =
    let v4 : string = method14()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure8(v5, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v15 : string = "source_dir"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure8(v5, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure8(v5, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v33 : string = $"{v0}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure8(v5, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v41 : string = "; "
    let v42 : string = $"{v41}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure8(v5, v42)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v50 : string = "dist_dir"
    let v51 : string = $"{v50}"
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure8(v5, v51)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v59 : string = $"{v24}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure8(v5, v59)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v67 : string = $"{v1}"
    let v70 : unit = ()
    let v71 : (unit -> unit) = closure8(v5, v67)
    let v72 : unit = (fun () -> v71 (); v70) ()
    let v75 : string = $"{v41}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure8(v5, v75)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v83 : string = "cache_dir"
    let v84 : string = $"{v83}"
    let v87 : unit = ()
    let v88 : (unit -> unit) = closure8(v5, v84)
    let v89 : unit = (fun () -> v88 (); v87) ()
    let v92 : string = $"{v24}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure8(v5, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : string = $"{v2}"
    let v103 : unit = ()
    let v104 : (unit -> unit) = closure8(v5, v100)
    let v105 : unit = (fun () -> v104 (); v103) ()
    let v108 : string = $"{v41}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure8(v5, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = "hangul_spec"
    let v117 : string = $"{v116}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure8(v5, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v125 : string = $"{v24}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure8(v5, v125)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v133 : string = $"{v3}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure8(v5, v133)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v141 : string = " }"
    let v142 : string = $"{v141}"
    let v145 : unit = ()
    let v146 : (unit -> unit) = closure8(v5, v142)
    let v147 : unit = (fun () -> v146 (); v145) ()
    let v150 : string = v5.l0
    v150
and method63 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : string) : string =
    let v12 : string = method64(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v14 : string = "documents.run"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method18(v15)
and closure22 (v0 : string, v1 : string, v2 : string, v3 : string) () : unit =
    let v4 : US0 = US0_1
    let v5 : bool = method7(v4)
    if v5 then
        let v6 : unit = ()
        let v7 : (unit -> unit) = closure6()
        let v8 : unit = (fun () -> v7 (); v6) ()
        let struct (v22 : Mut0, v23 : Mut1, v24 : Mut2, v25 : Mut3, v26 : Mut4, v27 : int64 option) = TraceState.trace_state.Value
        let v40 : string = method8(v22, v23, v24, v25, v26, v27)
        let v41 : string = method62()
        let v42 : string = method63(v22, v23, v24, v25, v26, v27, v40, v41, v1, v2, v3, v0)
        method19(v42)
and closure24 () (v0 : std_io_Error) : std_string_String =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let _v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v11 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v14 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v14 
    #endif
#else
    let v17 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v17 
    #endif
    let v20 : std_string_String = _v1 
    v20
and method65 () : (std_io_Error -> std_string_String) =
    closure24()
and closure25 () (v0 : std_fs_FileType) : US10 =
    US10_0(v0)
and method66 () : (std_fs_FileType -> US10) =
    closure25()
and closure26 () (v0 : std_string_String) : US10 =
    US10_1(v0)
and method67 () : (std_string_String -> US10) =
    closure26()
and method68 (v0 : US11) : US11 =
    v0
and method69 (v0 : async_walkdir_Filtering) : async_walkdir_Filtering =
    v0
and closure23 () (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> =
    let v1 : string = "true; let __future_init = Box::pin(async { //"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = "true; let __future_init = Box::pin(async move { //"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr () v3 
    let v5 : string = "$0"
    let v6 : async_walkdir_DirEntry = Fable.Core.RustInterop.emitRustExpr v0 v5 
    let v7 : string = "Box::pin(async_walkdir::DirEntry::file_type(&v6))"
    let v8 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>, Send<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>>>>> = Fable.Core.RustInterop.emitRustExpr () v7 
    let v9 : string = "v8.await"
    let v10 : Result<std_fs_FileType, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v9 
    let v11 : (std_io_Error -> std_string_String) = method65()
    let v12 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : string = "$0.map_err(|x| $1(x))"
    let v14 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v10, v11) v13 
    let _v12 = v14 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : string = "$0.map_err(|x| $1(x))"
    let v16 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v10, v11) v15 
    let _v12 = v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17 : string = "$0.map_err(|x| $1(x))"
    let v18 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v10, v11) v17 
    let _v12 = v18 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : Result<std_fs_FileType, std_string_String> = match v10 with Ok x -> Ok x | Error x -> Error (v11 x)
    let _v12 = v19 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : Result<std_fs_FileType, std_string_String> = match v10 with Ok x -> Ok x | Error x -> Error (v11 x)
    let _v12 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v21 : Result<std_fs_FileType, std_string_String> = match v10 with Ok x -> Ok x | Error x -> Error (v11 x)
    let _v12 = v21 
    #endif
#else
    let v22 : Result<std_fs_FileType, std_string_String> = match v10 with Ok x -> Ok x | Error x -> Error (v11 x)
    let _v12 = v22 
    #endif
    let v23 : Result<std_fs_FileType, std_string_String> = _v12 
    let v26 : (std_fs_FileType -> US10) = method66()
    let v27 : (std_string_String -> US10) = method67()
    let v28 : US10 = match v23 with Ok x -> v26 x | Error x -> v27 x
    let v164 : US11 =
        match v28 with
        | US10_0(v29) -> (* Ok *)
            let v30 : string = "std::fs::FileType::is_dir(&$0)"
            let v31 : bool = Fable.Core.RustInterop.emitRustExpr v29 v30 
            if v31 then
                US11_0
            else
                let v33 : string = "async_walkdir::DirEntry::path(&$0)"
                let v34 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v0 v33 
                let v35 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v36 : string = "$0.display()"
                let v37 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v34 v36 
                let _v35 = v37 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v38 : string = "$0.display()"
                let v39 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v34 v38 
                let _v35 = v39 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v40 : string = "$0.display()"
                let v41 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v34 v40 
                let _v35 = v41 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v42 : std_path_Display = v34 |> unbox<std_path_Display>
                let _v35 = v42 
                #endif
#if FABLE_COMPILER_PYTHON
                let v45 : std_path_Display = v34 |> unbox<std_path_Display>
                let _v35 = v45 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v48 : std_path_Display = v34 |> unbox<std_path_Display>
                let _v35 = v48 
                #endif
#else
                let v51 : std_path_Display = v34 |> unbox<std_path_Display>
                let _v35 = v51 
                #endif
                let v54 : std_path_Display = _v35 
                let v59 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v60 : string = "format!(\"{}\", $0)"
                let v61 : std_string_String = Fable.Core.RustInterop.emitRustExpr v54 v60 
                let _v59 = v61 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v62 : string = "format!(\"{}\", $0)"
                let v63 : std_string_String = Fable.Core.RustInterop.emitRustExpr v54 v62 
                let _v59 = v63 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v64 : string = "format!(\"{}\", $0)"
                let v65 : std_string_String = Fable.Core.RustInterop.emitRustExpr v54 v64 
                let _v59 = v65 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v66 : std_string_String = null |> unbox<std_string_String>
                let _v59 = v66 
                #endif
#if FABLE_COMPILER_PYTHON
                let v69 : std_string_String = null |> unbox<std_string_String>
                let _v59 = v69 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v72 : std_string_String = null |> unbox<std_string_String>
                let _v59 = v72 
                #endif
#else
                let v75 : std_string_String = null |> unbox<std_string_String>
                let _v59 = v75 
                #endif
                let v78 : std_string_String = _v59 
                let v83 : string = "fable_library_rust::String_::fromString($0)"
                let v84 : string = Fable.Core.RustInterop.emitRustExpr v78 v83 
                let v85 : string = ".md"
                let v86 : bool = v84.EndsWith (v85, false, null)
                let v89 : bool = v86 = false
                let v94 : bool =
                    if v89 then
                        true
                    else
                        let v90 : string = ".hangul.md"
                        let v91 : bool = v84.EndsWith (v90, false, null)
                        v91
                if v94 then
                    US11_0
                else
                    US11_2
        | _ ->
            let v99 : string = "async_walkdir::DirEntry::path(&$0)"
            let v100 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v0 v99 
            let v101 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v102 : string = "$0.display()"
            let v103 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v100 v102 
            let _v101 = v103 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v104 : string = "$0.display()"
            let v105 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v100 v104 
            let _v101 = v105 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v106 : string = "$0.display()"
            let v107 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v100 v106 
            let _v101 = v107 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v108 : std_path_Display = v100 |> unbox<std_path_Display>
            let _v101 = v108 
            #endif
#if FABLE_COMPILER_PYTHON
            let v111 : std_path_Display = v100 |> unbox<std_path_Display>
            let _v101 = v111 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v114 : std_path_Display = v100 |> unbox<std_path_Display>
            let _v101 = v114 
            #endif
#else
            let v117 : std_path_Display = v100 |> unbox<std_path_Display>
            let _v101 = v117 
            #endif
            let v120 : std_path_Display = _v101 
            let v125 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v126 : string = "format!(\"{}\", $0)"
            let v127 : std_string_String = Fable.Core.RustInterop.emitRustExpr v120 v126 
            let _v125 = v127 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v128 : string = "format!(\"{}\", $0)"
            let v129 : std_string_String = Fable.Core.RustInterop.emitRustExpr v120 v128 
            let _v125 = v129 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v130 : string = "format!(\"{}\", $0)"
            let v131 : std_string_String = Fable.Core.RustInterop.emitRustExpr v120 v130 
            let _v125 = v131 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v132 : std_string_String = null |> unbox<std_string_String>
            let _v125 = v132 
            #endif
#if FABLE_COMPILER_PYTHON
            let v135 : std_string_String = null |> unbox<std_string_String>
            let _v125 = v135 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v138 : std_string_String = null |> unbox<std_string_String>
            let _v125 = v138 
            #endif
#else
            let v141 : std_string_String = null |> unbox<std_string_String>
            let _v125 = v141 
            #endif
            let v144 : std_string_String = _v125 
            let v149 : string = "fable_library_rust::String_::fromString($0)"
            let v150 : string = Fable.Core.RustInterop.emitRustExpr v144 v149 
            let v151 : string = ".md"
            let v152 : bool = v150.EndsWith (v151, false, null)
            let v155 : bool = v152 = false
            let v160 : bool =
                if v155 then
                    true
                else
                    let v156 : string = ".hangul.md"
                    let v157 : bool = v150.EndsWith (v156, false, null)
                    v157
            if v160 then
                US11_0
            else
                US11_2
    let v165 : US11 = method68(v164)
    let v166 : string = ""
    let v167 : string = "}"
    let v168 : string = v166 + v167 
    let v169 : _ = v165 
    let v170 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v171 : string = $"true; let v169 = $0"
    let v172 : bool = Fable.Core.RustInterop.emitRustExpr v169 v171 
    let _v170 = v172 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v173 : string = $"true; let v169 = $0"
    let v174 : bool = Fable.Core.RustInterop.emitRustExpr v169 v173 
    let _v170 = v174 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v175 : string = $"true; let v169 = $0"
    let v176 : bool = Fable.Core.RustInterop.emitRustExpr v169 v175 
    let _v170 = v176 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v177 : bool = true
    let _v170 = v177 
    #endif
#if FABLE_COMPILER_PYTHON
    let v178 : bool = true
    let _v170 = v178 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v179 : bool = true
    let _v170 = v179 
    #endif
#else
    let v180 : bool = true
    let _v170 = v180 
    #endif
    let v181 : bool = _v170 
    let v184 : string = $"true; v169 " + v168 + "); " + v166 + " // rust.fix_closure'"
    let v185 : bool = Fable.Core.RustInterop.emitRustExpr () v184 
    let v186 : string = "__future_init"
    let v187 : _ = Fable.Core.RustInterop.emitRustExpr () v186 
    let v188 : string = "v187"
    let v189 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US11>>, Send<Dyn<std_future_Future<US11>>>>>> = Fable.Core.RustInterop.emitRustExpr () v188 
    let v190 : string = "v189.await"
    let v191 : US11 = Fable.Core.RustInterop.emitRustExpr () v190 
    let v200 : async_walkdir_Filtering =
        match v191 with
        | US11_2 -> (* Continue *)
            let v196 : string = "async_walkdir::Filtering::Continue"
            let v197 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v196 
            v197
        | US11_0 -> (* Ignore *)
            let v192 : string = "async_walkdir::Filtering::Ignore"
            let v193 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v192 
            v193
        | US11_1 -> (* IgnoreDir *)
            let v194 : string = "async_walkdir::Filtering::IgnoreDir"
            let v195 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v194 
            v195
    let v201 : async_walkdir_Filtering = method69(v200)
    let v202 : string = v166 + v167 
    let v203 : _ = v201 
    let v204 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v205 : string = $"true; let v203 = $0"
    let v206 : bool = Fable.Core.RustInterop.emitRustExpr v203 v205 
    let _v204 = v206 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v207 : string = $"true; let v203 = $0"
    let v208 : bool = Fable.Core.RustInterop.emitRustExpr v203 v207 
    let _v204 = v208 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v209 : string = $"true; let v203 = $0"
    let v210 : bool = Fable.Core.RustInterop.emitRustExpr v203 v209 
    let _v204 = v210 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v211 : bool = true
    let _v204 = v211 
    #endif
#if FABLE_COMPILER_PYTHON
    let v212 : bool = true
    let _v204 = v212 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v213 : bool = true
    let _v204 = v213 
    #endif
#else
    let v214 : bool = true
    let _v204 = v214 
    #endif
    let v215 : bool = _v204 
    let v218 : string = $"true; v203 " + v202 + "); " + v166 + " // rust.fix_closure'"
    let v219 : bool = Fable.Core.RustInterop.emitRustExpr () v218 
    let v220 : string = "__future_init"
    let v221 : _ = Fable.Core.RustInterop.emitRustExpr () v220 
    let v222 : string = "v221"
    let v223 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> = Fable.Core.RustInterop.emitRustExpr () v222 
    v223
and closure28 () (v0 : async_walkdir_Error) : std_string_String =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let _v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v11 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v14 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v14 
    #endif
#else
    let v17 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v17 
    #endif
    let v20 : std_string_String = _v1 
    v20
and method71 () : (async_walkdir_Error -> std_string_String) =
    closure28()
and closure29 () (v0 : async_walkdir_DirEntry) : US12 =
    US12_0(v0)
and method72 () : (async_walkdir_DirEntry -> US12) =
    closure29()
and closure30 () (v0 : std_string_String) : US12 =
    US12_1(v0)
and method73 () : (std_string_String -> US12) =
    closure30()
and method74 () : string =
    
    
    
    
    
    let v0 : string = "Critical"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method13(v5)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "inline_colorization::color_bright_red"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v11 
    let _v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v13 
    let _v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v15 
    let _v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v23 
    #endif
#else
    let v26 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v26 
    #endif
    let v29 : Ref<Str> = _v10 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9, v29, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v7 = v39 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v40 : string = "inline_colorization::color_bright_red"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v43 : string = "&*$0"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v43 
    let _v42 = v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : string = "&*$0"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v45 
    let _v42 = v46 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v47 : string = "&*$0"
    let v48 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v47 
    let _v42 = v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v49 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v49 
    #endif
#if FABLE_COMPILER_PYTHON
    let v52 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v52 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v55 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v55 
    #endif
#else
    let v58 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v58 
    #endif
    let v61 : Ref<Str> = _v42 
    let v66 : string = "inline_colorization::color_reset"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v61, v67) v68 
    let v70 : string = "fable_library_rust::String_::fromString($0)"
    let v71 : string = Fable.Core.RustInterop.emitRustExpr v69 v70 
    let _v7 = v71 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v72 : string = "inline_colorization::color_bright_red"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v75 : string = "&*$0"
    let v76 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v75 
    let _v74 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "&*$0"
    let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v77 
    let _v74 = v78 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : string = "&*$0"
    let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v79 
    let _v74 = v80 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v81 
    #endif
#if FABLE_COMPILER_PYTHON
    let v84 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v84 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v87 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v87 
    #endif
#else
    let v90 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v90 
    #endif
    let v93 : Ref<Str> = _v74 
    let v98 : string = "inline_colorization::color_reset"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v98 
    let v100 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v73, v93, v99) v100 
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let _v7 = v103 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v104 : string = "\u001b[91m"
    let v105 : string = method15()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[91m"
    let v109 : string = method15()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[91m"
    let v113 : string = method15()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[91m"
    let v117 : string = method15()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method76 (v0 : std_string_String) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure8(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "error"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure8(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure8(v2, v22)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "format!(\"{:#?}\", $0)"
    let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v31 
    let v33 : string = "fable_library_rust::String_::fromString($0)"
    let v34 : string = Fable.Core.RustInterop.emitRustExpr v32 v33 
    let _v30 = v34 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v35 : string = "format!(\"{:#?}\", $0)"
    let v36 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v35 
    let v37 : string = "fable_library_rust::String_::fromString($0)"
    let v38 : string = Fable.Core.RustInterop.emitRustExpr v36 v37 
    let _v30 = v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : string = "format!(\"{:#?}\", $0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v39 
    let v41 : string = "fable_library_rust::String_::fromString($0)"
    let v42 : string = Fable.Core.RustInterop.emitRustExpr v40 v41 
    let _v30 = v42 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v43 : string = $"%A{v0}"
    let _v30 = v43 
    #endif
#if FABLE_COMPILER_PYTHON
    let v46 : string = $"%A{v0}"
    let _v30 = v46 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v49 : string = $"%A{v0}"
    let _v30 = v49 
    #endif
#else
    let v52 : string = $"%A{v0}"
    let _v30 = v52 
    #endif
    let v55 : string = _v30 
    let v60 : string = $"{v55}"
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure8(v2, v60)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v68 : string = " }"
    let v69 : string = $"{v68}"
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure8(v2, v69)
    let v74 : unit = (fun () -> v73 (); v72) ()
    let v77 : string = v2.l0
    v77
and method75 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method76(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "documents.run / stream_filter_map"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method18(v12)
and closure31 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_4
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method8(v19, v20, v21, v22, v23, v24)
        let v38 : string = method74()
        let v39 : string = method75(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method19(v39)
and closure27 () (v0 : Result<async_walkdir_DirEntry, async_walkdir_Error>) : string option =
    let v1 : (async_walkdir_Error -> std_string_String) = method71()
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "$0.map_err(|x| $1(x))"
    let v4 : Result<async_walkdir_DirEntry, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v3 
    let _v2 = v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = "$0.map_err(|x| $1(x))"
    let v6 : Result<async_walkdir_DirEntry, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v5 
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = "$0.map_err(|x| $1(x))"
    let v8 : Result<async_walkdir_DirEntry, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v7 
    let _v2 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : Result<async_walkdir_DirEntry, std_string_String> = match v0 with Ok x -> Ok x | Error x -> Error (v1 x)
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v10 : Result<async_walkdir_DirEntry, std_string_String> = match v0 with Ok x -> Ok x | Error x -> Error (v1 x)
    let _v2 = v10 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v11 : Result<async_walkdir_DirEntry, std_string_String> = match v0 with Ok x -> Ok x | Error x -> Error (v1 x)
    let _v2 = v11 
    #endif
#else
    let v12 : Result<async_walkdir_DirEntry, std_string_String> = match v0 with Ok x -> Ok x | Error x -> Error (v1 x)
    let _v2 = v12 
    #endif
    let v13 : Result<async_walkdir_DirEntry, std_string_String> = _v2 
    let v16 : (async_walkdir_DirEntry -> US12) = method72()
    let v17 : (std_string_String -> US12) = method73()
    let v18 : US12 = match v13 with Ok x -> v16 x | Error x -> v17 x
    let v118 : US5 =
        match v18 with
        | US12_1(v73) -> (* Error *)
            let v74 : unit = ()
            let v75 : (unit -> unit) = closure31(v73)
            let v76 : unit = (fun () -> v75 (); v74) ()
            US5_1
        | US12_0(v19) -> (* Ok *)
            let v20 : string = "async_walkdir::DirEntry::path(&$0)"
            let v21 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v19 v20 
            let v22 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v23 : string = "$0.display()"
            let v24 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v21 v23 
            let _v22 = v24 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v25 : string = "$0.display()"
            let v26 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v21 v25 
            let _v22 = v26 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v27 : string = "$0.display()"
            let v28 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v21 v27 
            let _v22 = v28 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v29 : std_path_Display = v21 |> unbox<std_path_Display>
            let _v22 = v29 
            #endif
#if FABLE_COMPILER_PYTHON
            let v32 : std_path_Display = v21 |> unbox<std_path_Display>
            let _v22 = v32 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v35 : std_path_Display = v21 |> unbox<std_path_Display>
            let _v22 = v35 
            #endif
#else
            let v38 : std_path_Display = v21 |> unbox<std_path_Display>
            let _v22 = v38 
            #endif
            let v41 : std_path_Display = _v22 
            let v46 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v47 : string = "format!(\"{}\", $0)"
            let v48 : std_string_String = Fable.Core.RustInterop.emitRustExpr v41 v47 
            let _v46 = v48 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v49 : string = "format!(\"{}\", $0)"
            let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr v41 v49 
            let _v46 = v50 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v51 : string = "format!(\"{}\", $0)"
            let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr v41 v51 
            let _v46 = v52 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v53 : std_string_String = null |> unbox<std_string_String>
            let _v46 = v53 
            #endif
#if FABLE_COMPILER_PYTHON
            let v56 : std_string_String = null |> unbox<std_string_String>
            let _v46 = v56 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v59 : std_string_String = null |> unbox<std_string_String>
            let _v46 = v59 
            #endif
#else
            let v62 : std_string_String = null |> unbox<std_string_String>
            let _v46 = v62 
            #endif
            let v65 : std_string_String = _v46 
            let v70 : string = "fable_library_rust::String_::fromString($0)"
            let v71 : string = Fable.Core.RustInterop.emitRustExpr v65 v70 
            US5_0(v71)
    match v118 with
    | US5_1 -> (* None *)
        let v123 : string option = None
        v123
    | US5_0(v119) -> (* Some *)
        let v120 : string option = Some v119 
        v120
and method70 () : (Result<async_walkdir_DirEntry, async_walkdir_Error> -> string option) =
    closure27()
and method78 (v0 : unativeint) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure8(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "files_len"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure8(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure8(v2, v22)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "format!(\"{:#?}\", $0)"
    let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v31 
    let v33 : string = "fable_library_rust::String_::fromString($0)"
    let v34 : string = Fable.Core.RustInterop.emitRustExpr v32 v33 
    let _v30 = v34 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v35 : string = "format!(\"{:#?}\", $0)"
    let v36 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v35 
    let v37 : string = "fable_library_rust::String_::fromString($0)"
    let v38 : string = Fable.Core.RustInterop.emitRustExpr v36 v37 
    let _v30 = v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : string = "format!(\"{:#?}\", $0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v39 
    let v41 : string = "fable_library_rust::String_::fromString($0)"
    let v42 : string = Fable.Core.RustInterop.emitRustExpr v40 v41 
    let _v30 = v42 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v43 : string = $"%A{v0}"
    let _v30 = v43 
    #endif
#if FABLE_COMPILER_PYTHON
    let v46 : string = $"%A{v0}"
    let _v30 = v46 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v49 : string = $"%A{v0}"
    let _v30 = v49 
    #endif
#else
    let v52 : string = $"%A{v0}"
    let _v30 = v52 
    #endif
    let v55 : string = _v30 
    let v60 : string = $"{v55}"
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure8(v2, v60)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v68 : string = " }"
    let v69 : string = $"{v68}"
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure8(v2, v69)
    let v74 : unit = (fun () -> v73 (); v72) ()
    let v77 : string = v2.l0
    v77
and method77 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : unativeint) : string =
    let v9 : string = method78(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "documents.run"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method18(v12)
and closure32 (v0 : Vec<string>) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method8(v19, v20, v21, v22, v23, v24)
        let v38 : string = method62()
        let v39 : string = "$0.len()"
        let v40 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v39 
        let v41 : string = method77(v19, v20, v21, v22, v23, v24, v37, v38, v40)
        method19(v41)
and method79 () : string =
    let v0 : string = ""
    v0
and method80 (v0 : string) : string =
    let v1 : string = method35(v0)
    method36(v1)
and method82 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : string =
    v0
and method84 () : string =
    let v0 : string = ""
    v0
and closure36 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure35 () (v0 : char) : (UH0 -> UH0) =
    closure36(v0)
and method85 () : (char -> (UH0 -> UH0)) =
    closure35()
and method86 (v0 : UH0, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : struct (System.Text.StringBuilder * int32 * int32) =
    match v0 with
    | UH0_1(v4, v5) -> (* Cons *)
        let v6 : bool = '\n' = v4
        let struct (v9 : int32, v10 : int32) =
            if v6 then
                let v7 : int32 = v2 + 1
                struct (v7, 1)
            else
                let v8 : int32 = v3 + 1
                struct (v2, v8)
        let v24 : System.Text.StringBuilder =
            if v6 then
                let v11 : (unit -> System.Text.StringBuilder) = v1.Clear
                let v12 : System.Text.StringBuilder = v11 ()
                v1
            else
                let v16 : (char -> string) = _.ToString()
                let v17 : string = v16 v4
                let v20 : (string -> System.Text.StringBuilder) = v1.Append
                let v21 : System.Text.StringBuilder = v20 v17
                v1
        method86(v5, v24, v9, v10)
    | UH0_0 -> (* Nil *)
        struct (v1, v2, v3)
and closure34 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US14 =
    let v4 : bool = "" = v0
    if v4 then
        let v5 : string = $"parsing.p_char / unexpected end of input / c: '{'"'}' / s: %A{struct (v1, v2, v3)}"
        US14_1(v5)
    else
        let v9 : char = v0.[int 0]
        let v10 : bool = v9 = '"'
        if v10 then
            let v11 : (string -> int32) = String.length
            let v12 : int32 = v11 v0
            let v15 : int32 = 1 |> int32 
            let v22 : int32 = v12 |> int32 
            let v29 : int32 = v22 - 1
            let v30 : string = v0.[int v15..int v29]
            let v34 : (char -> string) = _.ToString()
            let v35 : string = v34 v9
            let v38 : int32 = v35.Length
            let v39 : (char []) = Array.zeroCreate<char> (v38)
            let v40 : Mut6 = {l0 = 0} : Mut6
            while method59(v38, v40) do
                let v42 : int32 = v40.l0
                let v43 : char = v35.[int v42]
                v39.[int v42] <- v43
                let v44 : int32 = v42 + 1
                v40.l0 <- v44
                ()
            let v45 : char list = v39 |> Array.toList
            let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v49 : (char -> (UH0 -> UH0)) = method85()
            let v50 : (char list -> (UH0 -> UH0)) = v48 v49
            let v51 : (UH0 -> UH0) = v50 v45
            let v52 : UH0 = UH0_0
            let v53 : UH0 = v51 v52
            let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method86(v53, v1, v2, v3)
            US14_0(v9, v30, v75, v76, v77)
        else
            let v79 : string = "\n"
            let v80 : int32 = v0.IndexOf v79 
            let v83 : int32 = v80 - 1
            let v84 : bool = -2 = v83
            let v91 : int32 =
                if v84 then
                    let v85 : (string -> int32) = String.length
                    let v86 : int32 = v85 v0
                    let v89 : int32 = v86 + 1
                    v89
                else
                    let v90 : int32 = v83 + 1
                    v90
            let v92 : int32 = 0 |> int32 
            let v99 : int32 = v91 |> int32 
            let v106 : int32 = v99 - 1
            let v107 : string = v0.[int v92..int v106]
            let v111 : string = $"parsing.p_char / expected: '{'"'}' / line: {v2} / col: {v3}
{v1}{v107}"
            let v114 : int32 = v3 - 1
            let v115 : (int32 -> (string -> string)) = String.replicate
            let v116 : (string -> string) = v115 v114
            let v117 : string = " "
            let v118 : string = v116 v117
            let v121 : string = "^"
            let v122 : string = v118 + v121 
            let v123 : string = $"{v111}
{v122}
"
            US14_1(v123)
and closure37 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US14 =
    let v4 : bool = "" = v0
    if v4 then
        let v5 : string = $"parsing.p_char / unexpected end of input / c: '{'''}' / s: %A{struct (v1, v2, v3)}"
        US14_1(v5)
    else
        let v9 : char = v0.[int 0]
        let v10 : bool = v9 = '''
        if v10 then
            let v11 : (string -> int32) = String.length
            let v12 : int32 = v11 v0
            let v15 : int32 = 1 |> int32 
            let v22 : int32 = v12 |> int32 
            let v29 : int32 = v22 - 1
            let v30 : string = v0.[int v15..int v29]
            let v34 : (char -> string) = _.ToString()
            let v35 : string = v34 v9
            let v38 : int32 = v35.Length
            let v39 : (char []) = Array.zeroCreate<char> (v38)
            let v40 : Mut6 = {l0 = 0} : Mut6
            while method59(v38, v40) do
                let v42 : int32 = v40.l0
                let v43 : char = v35.[int v42]
                v39.[int v42] <- v43
                let v44 : int32 = v42 + 1
                v40.l0 <- v44
                ()
            let v45 : char list = v39 |> Array.toList
            let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v49 : (char -> (UH0 -> UH0)) = method85()
            let v50 : (char list -> (UH0 -> UH0)) = v48 v49
            let v51 : (UH0 -> UH0) = v50 v45
            let v52 : UH0 = UH0_0
            let v53 : UH0 = v51 v52
            let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method86(v53, v1, v2, v3)
            US14_0(v9, v30, v75, v76, v77)
        else
            let v79 : string = "\n"
            let v80 : int32 = v0.IndexOf v79 
            let v83 : int32 = v80 - 1
            let v84 : bool = -2 = v83
            let v91 : int32 =
                if v84 then
                    let v85 : (string -> int32) = String.length
                    let v86 : int32 = v85 v0
                    let v89 : int32 = v86 + 1
                    v89
                else
                    let v90 : int32 = v83 + 1
                    v90
            let v92 : int32 = 0 |> int32 
            let v99 : int32 = v91 |> int32 
            let v106 : int32 = v99 - 1
            let v107 : string = v0.[int v92..int v106]
            let v111 : string = $"parsing.p_char / expected: '{'''}' / line: {v2} / col: {v3}
{v1}{v107}"
            let v114 : int32 = v3 - 1
            let v115 : (int32 -> (string -> string)) = String.replicate
            let v116 : (string -> string) = v115 v114
            let v117 : string = " "
            let v118 : string = v116 v117
            let v121 : string = "^"
            let v122 : string = v118 + v121 
            let v123 : string = $"{v111}
{v122}
"
            US14_1(v123)
and method87 (v0 : string, v1 : System.Text.StringBuilder, v2 : UH1) : US14 =
    match v2 with
    | UH1_1(v5, v6) -> (* Cons *)
        let v7 : US14 = v5 struct (v0, v1, 1, 1)
        match v7 with
        | US14_1(v13) -> (* Error *)
            method87(v0, v1, v6)
        | US14_0(v8, v9, v10, v11, v12) -> (* Ok *)
            v7
    | UH1_0 -> (* Nil *)
        let v3 : string = "parsing.choice / no parsers succeeded"
        US14_1(v3)
and method88 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 2L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v11 : US16 =
            if v3 then
                US16_0('"')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US16_0(''')
                else
                    let v8 : int64 = v5 - 1L
                    US16_1
        let v15 : char =
            match v11 with
            | US16_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US16_0(v12) -> (* Some *)
                v12
        let v16 : bool = v0 = v15
        if v16 then
            true
        else
            let v17 : int64 = v1 + 1L
            method88(v0, v17)
and method89 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
    let v5 : bool = "" = v1
    let v109 : US14 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = ''' :: v6 
            let v10 : char list = '"' :: v7 
            let v13 : (char list -> (char [])) = List.toArray
            let v14 : (char []) = v13 v10
            let v17 : string = $"parsing.none_of / unexpected end of input / chars: %A{v14} / s: %A{struct (v2, v3, v4)}"
            US14_1(v17)
        else
            let v21 : char = v1.[int 0]
            let v22 : int64 = 0L
            let v23 : bool = method88(v21, v22)
            let v24 : bool = v23 = false
            if v24 then
                let v25 : (string -> int32) = String.length
                let v26 : int32 = v25 v1
                let v29 : int32 = 1 |> int32 
                let v36 : int32 = v26 |> int32 
                let v43 : int32 = v36 - 1
                let v44 : string = v1.[int v29..int v43]
                let v48 : (char -> string) = _.ToString()
                let v49 : string = v48 v21
                let v52 : int32 = v49.Length
                let v53 : (char []) = Array.zeroCreate<char> (v52)
                let v54 : Mut6 = {l0 = 0} : Mut6
                while method59(v52, v54) do
                    let v56 : int32 = v54.l0
                    let v57 : char = v49.[int v56]
                    v53.[int v56] <- v57
                    let v58 : int32 = v56 + 1
                    v54.l0 <- v58
                    ()
                let v59 : char list = v53 |> Array.toList
                let v62 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v63 : (char -> (UH0 -> UH0)) = method85()
                let v64 : (char list -> (UH0 -> UH0)) = v62 v63
                let v65 : (UH0 -> UH0) = v64 v59
                let v66 : UH0 = UH0_0
                let v67 : UH0 = v65 v66
                let struct (v89 : System.Text.StringBuilder, v90 : int32, v91 : int32) = method86(v67, v2, v3, v4)
                US14_0(v21, v44, v89, v90, v91)
            else
                let v93 : char list = []
                let v94 : char list = ''' :: v93 
                let v97 : char list = '"' :: v94 
                let v100 : (char list -> (char [])) = List.toArray
                let v101 : (char []) = v100 v97
                let v104 : string = $"parsing.none_of / unexpected char: '{v21}' / chars: %A{v101} / s: %A{struct (v2, v3, v4)}"
                US14_1(v104)
    let v121 : US14 =
        match v109 with
        | US14_1(v118) -> (* Error *)
            US14_1(v118)
        | US14_0(v110, v111, v112, v113, v114) -> (* Ok *)
            let v115 : bool = '\\' = v110
            let v116 : char =
                if v115 then
                    '/'
                else
                    v110
            US14_0(v116, v111, v112, v113, v114)
    match v121 with
    | US14_1(v137) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US14_0(v122, v123, v124, v125, v126) -> (* Ok *)
        let v127 : (char -> string) = _.ToString()
        let v128 : string = v127 v122
        let v131 : string = v0 + v128 
        method89(v131, v123, v124, v125, v126)
and method90 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH1) : US14 =
    match v4 with
    | UH1_1(v7, v8) -> (* Cons *)
        let v9 : US14 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US14_1(v15) -> (* Error *)
            method90(v0, v1, v2, v3, v8)
        | US14_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH1_0 -> (* Nil *)
        let v5 : string = "parsing.choice / no parsers succeeded"
        US14_1(v5)
and method91 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 3L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v15 : US16 =
            if v3 then
                US16_0('"')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US16_0(''')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US16_0(' ')
                    else
                        let v11 : int64 = v8 - 1L
                        US16_1
        let v19 : char =
            match v15 with
            | US16_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US16_0(v16) -> (* Some *)
                v16
        let v20 : bool = v0 = v19
        if v20 then
            true
        else
            let v21 : int64 = v1 + 1L
            method91(v0, v21)
and method92 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
    let v5 : bool = "" = v1
    let v115 : US14 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = ' ' :: v6 
            let v10 : char list = ''' :: v7 
            let v13 : char list = '"' :: v10 
            let v16 : (char list -> (char [])) = List.toArray
            let v17 : (char []) = v16 v13
            let v20 : string = $"parsing.none_of / unexpected end of input / chars: %A{v17} / s: %A{struct (v2, v3, v4)}"
            US14_1(v20)
        else
            let v24 : char = v1.[int 0]
            let v25 : int64 = 0L
            let v26 : bool = method91(v24, v25)
            let v27 : bool = v26 = false
            if v27 then
                let v28 : (string -> int32) = String.length
                let v29 : int32 = v28 v1
                let v32 : int32 = 1 |> int32 
                let v39 : int32 = v29 |> int32 
                let v46 : int32 = v39 - 1
                let v47 : string = v1.[int v32..int v46]
                let v51 : (char -> string) = _.ToString()
                let v52 : string = v51 v24
                let v55 : int32 = v52.Length
                let v56 : (char []) = Array.zeroCreate<char> (v55)
                let v57 : Mut6 = {l0 = 0} : Mut6
                while method59(v55, v57) do
                    let v59 : int32 = v57.l0
                    let v60 : char = v52.[int v59]
                    v56.[int v59] <- v60
                    let v61 : int32 = v59 + 1
                    v57.l0 <- v61
                    ()
                let v62 : char list = v56 |> Array.toList
                let v65 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v66 : (char -> (UH0 -> UH0)) = method85()
                let v67 : (char list -> (UH0 -> UH0)) = v65 v66
                let v68 : (UH0 -> UH0) = v67 v62
                let v69 : UH0 = UH0_0
                let v70 : UH0 = v68 v69
                let struct (v92 : System.Text.StringBuilder, v93 : int32, v94 : int32) = method86(v70, v2, v3, v4)
                US14_0(v24, v47, v92, v93, v94)
            else
                let v96 : char list = []
                let v97 : char list = ' ' :: v96 
                let v100 : char list = ''' :: v97 
                let v103 : char list = '"' :: v100 
                let v106 : (char list -> (char [])) = List.toArray
                let v107 : (char []) = v106 v103
                let v110 : string = $"parsing.none_of / unexpected char: '{v24}' / chars: %A{v107} / s: %A{struct (v2, v3, v4)}"
                US14_1(v110)
    let v127 : US14 =
        match v115 with
        | US14_1(v124) -> (* Error *)
            US14_1(v124)
        | US14_0(v116, v117, v118, v119, v120) -> (* Ok *)
            let v121 : bool = '\\' = v116
            let v122 : char =
                if v121 then
                    '/'
                else
                    v116
            US14_0(v122, v117, v118, v119, v120)
    match v127 with
    | US14_1(v143) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US14_0(v128, v129, v130, v131, v132) -> (* Ok *)
        let v133 : (char -> string) = _.ToString()
        let v134 : string = v133 v128
        let v137 : string = v0 + v134 
        method92(v137, v129, v130, v131, v132)
and method93 (v0 : string, v1 : int32) : int32 =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 >= v2
    if v3 then
        v1
    else
        let v4 : char = v0.[int v1]
        let v5 : bool = ' ' = v4
        if v5 then
            let v6 : int32 = v1 + 1
            method93(v0, v6)
        else
            v1
and method94 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
    let v5 : bool = "" = v1
    let v79 : US14 =
        if v5 then
            let v6 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v2, v3, v4)}"
            US14_1(v6)
        else
            let v10 : char = v1.[int 0]
            let v11 : (string -> int32) = String.length
            let v12 : int32 = v11 v1
            let v15 : int32 = 1 |> int32 
            let v22 : int32 = v12 |> int32 
            let v29 : int32 = v22 - 1
            let v30 : string = v1.[int v15..int v29]
            let v34 : (char -> string) = _.ToString()
            let v35 : string = v34 v10
            let v38 : int32 = v35.Length
            let v39 : (char []) = Array.zeroCreate<char> (v38)
            let v40 : Mut6 = {l0 = 0} : Mut6
            while method59(v38, v40) do
                let v42 : int32 = v40.l0
                let v43 : char = v35.[int v42]
                v39.[int v42] <- v43
                let v44 : int32 = v42 + 1
                v40.l0 <- v44
                ()
            let v45 : char list = v39 |> Array.toList
            let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v49 : (char -> (UH0 -> UH0)) = method85()
            let v50 : (char list -> (UH0 -> UH0)) = v48 v49
            let v51 : (UH0 -> UH0) = v50 v45
            let v52 : UH0 = UH0_0
            let v53 : UH0 = v51 v52
            let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method86(v53, v2, v3, v4)
            US14_0(v10, v30, v75, v76, v77)
    match v79 with
    | US14_1(v95) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US14_0(v80, v81, v82, v83, v84) -> (* Ok *)
        let v85 : (char -> string) = _.ToString()
        let v86 : string = v85 v80
        let v89 : string = v0 + v86 
        method94(v89, v81, v82, v83, v84)
and method83 (v0 : string) : US13 =
    let mutable _v0 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v1 : (string -> string option) = Option.ofObj
    let v2 : string option = v1 v0
    v2 
    #else
    Some v0 
    #endif
    |> fun x -> _v0 <- Some x
    let v3 : string option = match _v0 with Some x -> x | None -> failwith "optionm'.of_obj / _v0=None"
    let v6 : string = ""
    let v7 : string = v3 |> Option.defaultValue v6 
    let v10 : string = method84()
    let v11 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v12 : System.Text.StringBuilder = v11 v10
    let v15 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US14) = closure34()
    let v16 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US14) = closure37()
    let v17 : UH1 = UH1_0
    let v18 : UH1 = UH1_1(v16, v17)
    let v19 : UH1 = UH1_1(v15, v18)
    let v20 : US14 = method87(v7, v12, v19)
    let v202 : US15 =
        match v20 with
        | US14_1(v199) -> (* Error *)
            US15_1(v199)
        | US14_0(v21, v22, v23, v24, v25) -> (* Ok *)
            let v26 : bool = "" = v22
            let v130 : US14 =
                if v26 then
                    let v27 : char list = []
                    let v28 : char list = ''' :: v27 
                    let v31 : char list = '"' :: v28 
                    let v34 : (char list -> (char [])) = List.toArray
                    let v35 : (char []) = v34 v31
                    let v38 : string = $"parsing.none_of / unexpected end of input / chars: %A{v35} / s: %A{struct (v23, v24, v25)}"
                    US14_1(v38)
                else
                    let v42 : char = v22.[int 0]
                    let v43 : int64 = 0L
                    let v44 : bool = method88(v42, v43)
                    let v45 : bool = v44 = false
                    if v45 then
                        let v46 : (string -> int32) = String.length
                        let v47 : int32 = v46 v22
                        let v50 : int32 = 1 |> int32 
                        let v57 : int32 = v47 |> int32 
                        let v64 : int32 = v57 - 1
                        let v65 : string = v22.[int v50..int v64]
                        let v69 : (char -> string) = _.ToString()
                        let v70 : string = v69 v42
                        let v73 : int32 = v70.Length
                        let v74 : (char []) = Array.zeroCreate<char> (v73)
                        let v75 : Mut6 = {l0 = 0} : Mut6
                        while method59(v73, v75) do
                            let v77 : int32 = v75.l0
                            let v78 : char = v70.[int v77]
                            v74.[int v77] <- v78
                            let v79 : int32 = v77 + 1
                            v75.l0 <- v79
                            ()
                        let v80 : char list = v74 |> Array.toList
                        let v83 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v84 : (char -> (UH0 -> UH0)) = method85()
                        let v85 : (char list -> (UH0 -> UH0)) = v83 v84
                        let v86 : (UH0 -> UH0) = v85 v80
                        let v87 : UH0 = UH0_0
                        let v88 : UH0 = v86 v87
                        let struct (v110 : System.Text.StringBuilder, v111 : int32, v112 : int32) = method86(v88, v23, v24, v25)
                        US14_0(v42, v65, v110, v111, v112)
                    else
                        let v114 : char list = []
                        let v115 : char list = ''' :: v114 
                        let v118 : char list = '"' :: v115 
                        let v121 : (char list -> (char [])) = List.toArray
                        let v122 : (char []) = v121 v118
                        let v125 : string = $"parsing.none_of / unexpected char: '{v42}' / chars: %A{v122} / s: %A{struct (v23, v24, v25)}"
                        US14_1(v125)
            let v142 : US14 =
                match v130 with
                | US14_1(v139) -> (* Error *)
                    US14_1(v139)
                | US14_0(v131, v132, v133, v134, v135) -> (* Ok *)
                    let v136 : bool = '\\' = v131
                    let v137 : char =
                        if v136 then
                            '/'
                        else
                            v131
                    US14_0(v137, v132, v133, v134, v135)
            let v161 : US15 =
                match v142 with
                | US14_1(v158) -> (* Error *)
                    US15_1(v158)
                | US14_0(v143, v144, v145, v146, v147) -> (* Ok *)
                    let v148 : (char -> string) = _.ToString()
                    let v149 : string = v148 v143
                    let struct (v152 : string, v153 : string, v154 : System.Text.StringBuilder, v155 : int32, v156 : int32) = method89(v149, v144, v145, v146, v147)
                    US15_0(v152, v153, v154, v155, v156)
            let v171 : US15 =
                match v161 with
                | US15_1(v168) -> (* Error *)
                    US15_0(v6, v22, v23, v24, v25)
                | US15_0(v162, v163, v164, v165, v166) -> (* Ok *)
                    US15_0(v162, v163, v164, v165, v166)
            match v171 with
            | US15_1(v194) -> (* Error *)
                let v195 : string = "parsing.between / expected content"
                US15_1(v195)
            | US15_0(v172, v173, v174, v175, v176) -> (* Ok *)
                let v177 : UH1 = UH1_0
                let v178 : UH1 = UH1_1(v16, v177)
                let v179 : UH1 = UH1_1(v15, v178)
                let v180 : US14 = method90(v173, v174, v175, v176, v179)
                match v180 with
                | US14_1(v187) -> (* Error *)
                    let v188 : string = $"parsing.between / expected closing delimiter / e: %A{v187} / input: %A{struct (v7, v12, 1, 1)} / rest1: %A{struct (v22, v23, v24, v25)} / rest2: %A{struct (v173, v174, v175, v176)}"
                    US15_1(v188)
                | US14_0(v181, v182, v183, v184, v185) -> (* Ok *)
                    US15_0(v172, v182, v183, v184, v185)
    let v414 : US15 =
        match v202 with
        | US15_1(v208) -> (* Error *)
            let v209 : bool = "" = v7
            let v321 : US14 =
                if v209 then
                    let v210 : char list = []
                    let v211 : char list = ' ' :: v210 
                    let v214 : char list = ''' :: v211 
                    let v217 : char list = '"' :: v214 
                    let v220 : (char list -> (char [])) = List.toArray
                    let v221 : (char []) = v220 v217
                    let v224 : string = $"parsing.none_of / unexpected end of input / chars: %A{v221} / s: %A{struct (v12, 1, 1)}"
                    US14_1(v224)
                else
                    let v228 : char = v7.[int 0]
                    let v229 : int64 = 0L
                    let v230 : bool = method91(v228, v229)
                    let v231 : bool = v230 = false
                    if v231 then
                        let v232 : (string -> int32) = String.length
                        let v233 : int32 = v232 v7
                        let v236 : int32 = 1 |> int32 
                        let v243 : int32 = v233 |> int32 
                        let v250 : int32 = v243 - 1
                        let v251 : string = v7.[int v236..int v250]
                        let v255 : (char -> string) = _.ToString()
                        let v256 : string = v255 v228
                        let v259 : int32 = v256.Length
                        let v260 : (char []) = Array.zeroCreate<char> (v259)
                        let v261 : Mut6 = {l0 = 0} : Mut6
                        while method59(v259, v261) do
                            let v263 : int32 = v261.l0
                            let v264 : char = v256.[int v263]
                            v260.[int v263] <- v264
                            let v265 : int32 = v263 + 1
                            v261.l0 <- v265
                            ()
                        let v266 : char list = v260 |> Array.toList
                        let v269 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v270 : (char -> (UH0 -> UH0)) = method85()
                        let v271 : (char list -> (UH0 -> UH0)) = v269 v270
                        let v272 : (UH0 -> UH0) = v271 v266
                        let v273 : UH0 = UH0_0
                        let v274 : UH0 = v272 v273
                        let v296 : int32 = 1
                        let v297 : int32 = 1
                        let struct (v298 : System.Text.StringBuilder, v299 : int32, v300 : int32) = method86(v274, v12, v296, v297)
                        US14_0(v228, v251, v298, v299, v300)
                    else
                        let v302 : char list = []
                        let v303 : char list = ' ' :: v302 
                        let v306 : char list = ''' :: v303 
                        let v309 : char list = '"' :: v306 
                        let v312 : (char list -> (char [])) = List.toArray
                        let v313 : (char []) = v312 v309
                        let v316 : string = $"parsing.none_of / unexpected char: '{v228}' / chars: %A{v313} / s: %A{struct (v12, 1, 1)}"
                        US14_1(v316)
            let v333 : US14 =
                match v321 with
                | US14_1(v330) -> (* Error *)
                    US14_1(v330)
                | US14_0(v322, v323, v324, v325, v326) -> (* Ok *)
                    let v327 : bool = '\\' = v322
                    let v328 : char =
                        if v327 then
                            '/'
                        else
                            v322
                    US14_0(v328, v323, v324, v325, v326)
            let v352 : US15 =
                match v333 with
                | US14_1(v349) -> (* Error *)
                    US15_1(v349)
                | US14_0(v334, v335, v336, v337, v338) -> (* Ok *)
                    let v339 : (char -> string) = _.ToString()
                    let v340 : string = v339 v334
                    let struct (v343 : string, v344 : string, v345 : System.Text.StringBuilder, v346 : int32, v347 : int32) = method92(v340, v335, v336, v337, v338)
                    US15_0(v343, v344, v345, v346, v347)
            match v352 with
            | US15_1(v358) -> (* Error *)
                let v359 : int32 = v7.Length
                let v360 : bool = v359 = 0
                let v366 : US17 =
                    if v360 then
                        US17_0(v7, v12, 1, 1)
                    else
                        let v362 : string = $"parsing.eof / expected end of input / input: %A{v7}"
                        US17_1(v362)
                let v375 : US15 =
                    match v366 with
                    | US17_1(v372) -> (* Error *)
                        US15_1(v372)
                    | US17_0(v367, v368, v369, v370) -> (* Ok *)
                        US15_0(v6, v367, v368, v369, v370)
                match v375 with
                | US15_1(v407) -> (* Error *)
                    US15_1(v407)
                | US15_0(v376, v377, v378, v379, v380) -> (* Ok *)
                    let v381 : int32 = 0
                    let v382 : int32 = method93(v377, v381)
                    let v383 : (string -> int32) = String.length
                    let v384 : int32 = v383 v377
                    let v387 : int32 = v382 |> int32 
                    let v394 : int32 = v384 |> int32 
                    let v401 : int32 = v394 - 1
                    let v402 : string = v377.[int v387..int v401]
                    US15_0(v376, v402, v378, v379, v380)
            | US15_0(v353, v354, v355, v356, v357) -> (* Ok *)
                v352
        | US15_0(v203, v204, v205, v206, v207) -> (* Ok *)
            v202
    let v685 : US18 =
        match v414 with
        | US15_1(v682) -> (* Error *)
            US18_1(v682)
        | US15_0(v415, v416, v417, v418, v419) -> (* Ok *)
            let v420 : bool = "" = v416
            let v544 : US14 =
                if v420 then
                    let v421 : string = $"parsing.p_char / unexpected end of input / c: '{' '}' / s: %A{struct (v417, v418, v419)}"
                    US14_1(v421)
                else
                    let v425 : char = v416.[int 0]
                    let v426 : bool = v425 = ' '
                    if v426 then
                        let v427 : (string -> int32) = String.length
                        let v428 : int32 = v427 v416
                        let v431 : int32 = 1 |> int32 
                        let v438 : int32 = v428 |> int32 
                        let v445 : int32 = v438 - 1
                        let v446 : string = v416.[int v431..int v445]
                        let v450 : (char -> string) = _.ToString()
                        let v451 : string = v450 v425
                        let v454 : int32 = v451.Length
                        let v455 : (char []) = Array.zeroCreate<char> (v454)
                        let v456 : Mut6 = {l0 = 0} : Mut6
                        while method59(v454, v456) do
                            let v458 : int32 = v456.l0
                            let v459 : char = v451.[int v458]
                            v455.[int v458] <- v459
                            let v460 : int32 = v458 + 1
                            v456.l0 <- v460
                            ()
                        let v461 : char list = v455 |> Array.toList
                        let v464 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v465 : (char -> (UH0 -> UH0)) = method85()
                        let v466 : (char list -> (UH0 -> UH0)) = v464 v465
                        let v467 : (UH0 -> UH0) = v466 v461
                        let v468 : UH0 = UH0_0
                        let v469 : UH0 = v467 v468
                        let struct (v491 : System.Text.StringBuilder, v492 : int32, v493 : int32) = method86(v469, v417, v418, v419)
                        US14_0(v425, v446, v491, v492, v493)
                    else
                        let v495 : string = "\n"
                        let v496 : int32 = v416.IndexOf v495 
                        let v499 : int32 = v496 - 1
                        let v500 : bool = -2 = v499
                        let v507 : int32 =
                            if v500 then
                                let v501 : (string -> int32) = String.length
                                let v502 : int32 = v501 v416
                                let v505 : int32 = v502 + 1
                                v505
                            else
                                let v506 : int32 = v499 + 1
                                v506
                        let v508 : int32 = 0 |> int32 
                        let v515 : int32 = v507 |> int32 
                        let v522 : int32 = v515 - 1
                        let v523 : string = v416.[int v508..int v522]
                        let v527 : string = $"parsing.p_char / expected: '{' '}' / line: {v418} / col: {v419}
{v417}{v523}"
                        let v530 : int32 = v419 - 1
                        let v531 : (int32 -> (string -> string)) = String.replicate
                        let v532 : (string -> string) = v531 v530
                        let v533 : string = " "
                        let v534 : string = v532 v533
                        let v537 : string = "^"
                        let v538 : string = v534 + v537 
                        let v539 : string = $"{v527}
{v538}
"
                        US14_1(v539)
            let v556 : US19 =
                match v544 with
                | US14_1(v552) -> (* Error *)
                    let v553 : US16 = US16_1
                    US19_0(v553, v416, v417, v418, v419)
                | US14_0(v545, v546, v547, v548, v549) -> (* Ok *)
                    let v550 : US16 = US16_0(v545)
                    US19_0(v550, v546, v547, v548, v549)
            let v659 : US15 =
                match v556 with
                | US19_1(v656) -> (* Error *)
                    US15_1(v656)
                | US19_0(v557, v558, v559, v560, v561) -> (* Ok *)
                    let v562 : bool = "" = v558
                    let v636 : US14 =
                        if v562 then
                            let v563 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v559, v560, v561)}"
                            US14_1(v563)
                        else
                            let v567 : char = v558.[int 0]
                            let v568 : (string -> int32) = String.length
                            let v569 : int32 = v568 v558
                            let v572 : int32 = 1 |> int32 
                            let v579 : int32 = v569 |> int32 
                            let v586 : int32 = v579 - 1
                            let v587 : string = v558.[int v572..int v586]
                            let v591 : (char -> string) = _.ToString()
                            let v592 : string = v591 v567
                            let v595 : int32 = v592.Length
                            let v596 : (char []) = Array.zeroCreate<char> (v595)
                            let v597 : Mut6 = {l0 = 0} : Mut6
                            while method59(v595, v597) do
                                let v599 : int32 = v597.l0
                                let v600 : char = v592.[int v599]
                                v596.[int v599] <- v600
                                let v601 : int32 = v599 + 1
                                v597.l0 <- v601
                                ()
                            let v602 : char list = v596 |> Array.toList
                            let v605 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                            let v606 : (char -> (UH0 -> UH0)) = method85()
                            let v607 : (char list -> (UH0 -> UH0)) = v605 v606
                            let v608 : (UH0 -> UH0) = v607 v602
                            let v609 : UH0 = UH0_0
                            let v610 : UH0 = v608 v609
                            let struct (v632 : System.Text.StringBuilder, v633 : int32, v634 : int32) = method86(v610, v559, v560, v561)
                            US14_0(v567, v587, v632, v633, v634)
                    match v636 with
                    | US14_1(v652) -> (* Error *)
                        US15_1(v652)
                    | US14_0(v637, v638, v639, v640, v641) -> (* Ok *)
                        let v642 : (char -> string) = _.ToString()
                        let v643 : string = v642 v637
                        let struct (v646 : string, v647 : string, v648 : System.Text.StringBuilder, v649 : int32, v650 : int32) = method94(v643, v638, v639, v640, v641)
                        US15_0(v646, v647, v648, v649, v650)
            let v671 : US20 =
                match v659 with
                | US15_1(v667) -> (* Error *)
                    let v668 : US5 = US5_1
                    US20_0(v668, v416, v417, v418, v419)
                | US15_0(v660, v661, v662, v663, v664) -> (* Ok *)
                    let v665 : US5 = US5_0(v660)
                    US20_0(v665, v661, v662, v663, v664)
            match v671 with
            | US20_1(v678) -> (* Error *)
                US18_1(v678)
            | US20_0(v672, v673, v674, v675, v676) -> (* Ok *)
                US18_0(v415, v672, v673, v674, v675, v676)
    match v685 with
    | US18_1(v693) -> (* Error *)
        US13_1(v693)
    | US18_0(v686, v687, v688, v689, v690, v691) -> (* Ok *)
        US13_0(v686, v687)
and method97 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 4L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v19 : US16 =
            if v3 then
                US16_0('\\')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US16_0('`')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US16_0('"')
                    else
                        let v11 : int64 = v8 - 1L
                        let v12 : bool = v11 = 0L
                        if v12 then
                            US16_0(' ')
                        else
                            let v14 : int64 = v11 - 1L
                            US16_1
        let v23 : char =
            match v19 with
            | US16_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US16_0(v20) -> (* Some *)
                v20
        let v24 : bool = v0 = v23
        if v24 then
            true
        else
            let v25 : int64 = v1 + 1L
            method97(v0, v25)
and method98 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
    let v5 : bool = "" = v1
    let v121 : US14 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = ' ' :: v6 
            let v10 : char list = '"' :: v7 
            let v13 : char list = '`' :: v10 
            let v16 : char list = '\\' :: v13 
            let v19 : (char list -> (char [])) = List.toArray
            let v20 : (char []) = v19 v16
            let v23 : string = $"parsing.none_of / unexpected end of input / chars: %A{v20} / s: %A{struct (v2, v3, v4)}"
            US14_1(v23)
        else
            let v27 : char = v1.[int 0]
            let v28 : int64 = 0L
            let v29 : bool = method97(v27, v28)
            let v30 : bool = v29 = false
            if v30 then
                let v31 : (string -> int32) = String.length
                let v32 : int32 = v31 v1
                let v35 : int32 = 1 |> int32 
                let v42 : int32 = v32 |> int32 
                let v49 : int32 = v42 - 1
                let v50 : string = v1.[int v35..int v49]
                let v54 : (char -> string) = _.ToString()
                let v55 : string = v54 v27
                let v58 : int32 = v55.Length
                let v59 : (char []) = Array.zeroCreate<char> (v58)
                let v60 : Mut6 = {l0 = 0} : Mut6
                while method59(v58, v60) do
                    let v62 : int32 = v60.l0
                    let v63 : char = v55.[int v62]
                    v59.[int v62] <- v63
                    let v64 : int32 = v62 + 1
                    v60.l0 <- v64
                    ()
                let v65 : char list = v59 |> Array.toList
                let v68 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v69 : (char -> (UH0 -> UH0)) = method85()
                let v70 : (char list -> (UH0 -> UH0)) = v68 v69
                let v71 : (UH0 -> UH0) = v70 v65
                let v72 : UH0 = UH0_0
                let v73 : UH0 = v71 v72
                let struct (v95 : System.Text.StringBuilder, v96 : int32, v97 : int32) = method86(v73, v2, v3, v4)
                US14_0(v27, v50, v95, v96, v97)
            else
                let v99 : char list = []
                let v100 : char list = ' ' :: v99 
                let v103 : char list = '"' :: v100 
                let v106 : char list = '`' :: v103 
                let v109 : char list = '\\' :: v106 
                let v112 : (char list -> (char [])) = List.toArray
                let v113 : (char []) = v112 v109
                let v116 : string = $"parsing.none_of / unexpected char: '{v27}' / chars: %A{v113} / s: %A{struct (v2, v3, v4)}"
                US14_1(v116)
    match v121 with
    | US14_1(v137) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US14_0(v122, v123, v124, v125, v126) -> (* Ok *)
        let v127 : (char -> string) = _.ToString()
        let v128 : string = v127 v122
        let v131 : string = v0 + v128 
        method98(v131, v123, v124, v125, v126)
and method100 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 3L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v15 : US16 =
            if v3 then
                US16_0('\\')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US16_0('`')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US16_0('"')
                    else
                        let v11 : int64 = v8 - 1L
                        US16_1
        let v19 : char =
            match v15 with
            | US16_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US16_0(v16) -> (* Some *)
                v16
        let v20 : bool = v0 = v19
        if v20 then
            true
        else
            let v21 : int64 = v1 + 1L
            method100(v0, v21)
and closure38 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US15 =
    let v4 : bool = "" = v0
    let v128 : US14 =
        if v4 then
            let v5 : string = $"parsing.p_char / unexpected end of input / c: '{'\\'}' / s: %A{struct (v1, v2, v3)}"
            US14_1(v5)
        else
            let v9 : char = v0.[int 0]
            let v10 : bool = v9 = '\\'
            if v10 then
                let v11 : (string -> int32) = String.length
                let v12 : int32 = v11 v0
                let v15 : int32 = 1 |> int32 
                let v22 : int32 = v12 |> int32 
                let v29 : int32 = v22 - 1
                let v30 : string = v0.[int v15..int v29]
                let v34 : (char -> string) = _.ToString()
                let v35 : string = v34 v9
                let v38 : int32 = v35.Length
                let v39 : (char []) = Array.zeroCreate<char> (v38)
                let v40 : Mut6 = {l0 = 0} : Mut6
                while method59(v38, v40) do
                    let v42 : int32 = v40.l0
                    let v43 : char = v35.[int v42]
                    v39.[int v42] <- v43
                    let v44 : int32 = v42 + 1
                    v40.l0 <- v44
                    ()
                let v45 : char list = v39 |> Array.toList
                let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v49 : (char -> (UH0 -> UH0)) = method85()
                let v50 : (char list -> (UH0 -> UH0)) = v48 v49
                let v51 : (UH0 -> UH0) = v50 v45
                let v52 : UH0 = UH0_0
                let v53 : UH0 = v51 v52
                let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method86(v53, v1, v2, v3)
                US14_0(v9, v30, v75, v76, v77)
            else
                let v79 : string = "\n"
                let v80 : int32 = v0.IndexOf v79 
                let v83 : int32 = v80 - 1
                let v84 : bool = -2 = v83
                let v91 : int32 =
                    if v84 then
                        let v85 : (string -> int32) = String.length
                        let v86 : int32 = v85 v0
                        let v89 : int32 = v86 + 1
                        v89
                    else
                        let v90 : int32 = v83 + 1
                        v90
                let v92 : int32 = 0 |> int32 
                let v99 : int32 = v91 |> int32 
                let v106 : int32 = v99 - 1
                let v107 : string = v0.[int v92..int v106]
                let v111 : string = $"parsing.p_char / expected: '{'\\'}' / line: {v2} / col: {v3}
{v1}{v107}"
                let v114 : int32 = v3 - 1
                let v115 : (int32 -> (string -> string)) = String.replicate
                let v116 : (string -> string) = v115 v114
                let v117 : string = " "
                let v118 : string = v116 v117
                let v121 : string = "^"
                let v122 : string = v118 + v121 
                let v123 : string = $"{v111}
{v122}
"
                US14_1(v123)
    let v212 : US14 =
        match v128 with
        | US14_1(v209) -> (* Error *)
            US14_1(v209)
        | US14_0(v129, v130, v131, v132, v133) -> (* Ok *)
            let v134 : bool = "" = v130
            if v134 then
                let v135 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v131, v132, v133)}"
                US14_1(v135)
            else
                let v139 : char = v130.[int 0]
                let v140 : (string -> int32) = String.length
                let v141 : int32 = v140 v130
                let v144 : int32 = 1 |> int32 
                let v151 : int32 = v141 |> int32 
                let v158 : int32 = v151 - 1
                let v159 : string = v130.[int v144..int v158]
                let v163 : (char -> string) = _.ToString()
                let v164 : string = v163 v139
                let v167 : int32 = v164.Length
                let v168 : (char []) = Array.zeroCreate<char> (v167)
                let v169 : Mut6 = {l0 = 0} : Mut6
                while method59(v167, v169) do
                    let v171 : int32 = v169.l0
                    let v172 : char = v164.[int v171]
                    v168.[int v171] <- v172
                    let v173 : int32 = v171 + 1
                    v169.l0 <- v173
                    ()
                let v174 : char list = v168 |> Array.toList
                let v177 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v178 : (char -> (UH0 -> UH0)) = method85()
                let v179 : (char list -> (UH0 -> UH0)) = v177 v178
                let v180 : (UH0 -> UH0) = v179 v174
                let v181 : UH0 = UH0_0
                let v182 : UH0 = v180 v181
                let struct (v204 : System.Text.StringBuilder, v205 : int32, v206 : int32) = method86(v182, v131, v132, v133)
                US14_0(v139, v159, v204, v205, v206)
    match v212 with
    | US14_1(v228) -> (* Error *)
        US15_1(v228)
    | US14_0(v213, v214, v215, v216, v217) -> (* Ok *)
        let v218 : (char -> string) = _.ToString()
        let v219 : string = v218 '\\'
        let v222 : (char -> string) = _.ToString()
        let v223 : string = v222 v213
        let v226 : string = v219 + v223 
        US15_0(v226, v214, v215, v216, v217)
and closure39 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US15 =
    let v4 : bool = "" = v0
    let v128 : US14 =
        if v4 then
            let v5 : string = $"parsing.p_char / unexpected end of input / c: '{'`'}' / s: %A{struct (v1, v2, v3)}"
            US14_1(v5)
        else
            let v9 : char = v0.[int 0]
            let v10 : bool = v9 = '`'
            if v10 then
                let v11 : (string -> int32) = String.length
                let v12 : int32 = v11 v0
                let v15 : int32 = 1 |> int32 
                let v22 : int32 = v12 |> int32 
                let v29 : int32 = v22 - 1
                let v30 : string = v0.[int v15..int v29]
                let v34 : (char -> string) = _.ToString()
                let v35 : string = v34 v9
                let v38 : int32 = v35.Length
                let v39 : (char []) = Array.zeroCreate<char> (v38)
                let v40 : Mut6 = {l0 = 0} : Mut6
                while method59(v38, v40) do
                    let v42 : int32 = v40.l0
                    let v43 : char = v35.[int v42]
                    v39.[int v42] <- v43
                    let v44 : int32 = v42 + 1
                    v40.l0 <- v44
                    ()
                let v45 : char list = v39 |> Array.toList
                let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v49 : (char -> (UH0 -> UH0)) = method85()
                let v50 : (char list -> (UH0 -> UH0)) = v48 v49
                let v51 : (UH0 -> UH0) = v50 v45
                let v52 : UH0 = UH0_0
                let v53 : UH0 = v51 v52
                let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method86(v53, v1, v2, v3)
                US14_0(v9, v30, v75, v76, v77)
            else
                let v79 : string = "\n"
                let v80 : int32 = v0.IndexOf v79 
                let v83 : int32 = v80 - 1
                let v84 : bool = -2 = v83
                let v91 : int32 =
                    if v84 then
                        let v85 : (string -> int32) = String.length
                        let v86 : int32 = v85 v0
                        let v89 : int32 = v86 + 1
                        v89
                    else
                        let v90 : int32 = v83 + 1
                        v90
                let v92 : int32 = 0 |> int32 
                let v99 : int32 = v91 |> int32 
                let v106 : int32 = v99 - 1
                let v107 : string = v0.[int v92..int v106]
                let v111 : string = $"parsing.p_char / expected: '{'`'}' / line: {v2} / col: {v3}
{v1}{v107}"
                let v114 : int32 = v3 - 1
                let v115 : (int32 -> (string -> string)) = String.replicate
                let v116 : (string -> string) = v115 v114
                let v117 : string = " "
                let v118 : string = v116 v117
                let v121 : string = "^"
                let v122 : string = v118 + v121 
                let v123 : string = $"{v111}
{v122}
"
                US14_1(v123)
    let v212 : US14 =
        match v128 with
        | US14_1(v209) -> (* Error *)
            US14_1(v209)
        | US14_0(v129, v130, v131, v132, v133) -> (* Ok *)
            let v134 : bool = "" = v130
            if v134 then
                let v135 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v131, v132, v133)}"
                US14_1(v135)
            else
                let v139 : char = v130.[int 0]
                let v140 : (string -> int32) = String.length
                let v141 : int32 = v140 v130
                let v144 : int32 = 1 |> int32 
                let v151 : int32 = v141 |> int32 
                let v158 : int32 = v151 - 1
                let v159 : string = v130.[int v144..int v158]
                let v163 : (char -> string) = _.ToString()
                let v164 : string = v163 v139
                let v167 : int32 = v164.Length
                let v168 : (char []) = Array.zeroCreate<char> (v167)
                let v169 : Mut6 = {l0 = 0} : Mut6
                while method59(v167, v169) do
                    let v171 : int32 = v169.l0
                    let v172 : char = v164.[int v171]
                    v168.[int v171] <- v172
                    let v173 : int32 = v171 + 1
                    v169.l0 <- v173
                    ()
                let v174 : char list = v168 |> Array.toList
                let v177 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v178 : (char -> (UH0 -> UH0)) = method85()
                let v179 : (char list -> (UH0 -> UH0)) = v177 v178
                let v180 : (UH0 -> UH0) = v179 v174
                let v181 : UH0 = UH0_0
                let v182 : UH0 = v180 v181
                let struct (v204 : System.Text.StringBuilder, v205 : int32, v206 : int32) = method86(v182, v131, v132, v133)
                US14_0(v139, v159, v204, v205, v206)
    match v212 with
    | US14_1(v228) -> (* Error *)
        US15_1(v228)
    | US14_0(v213, v214, v215, v216, v217) -> (* Ok *)
        let v218 : (char -> string) = _.ToString()
        let v219 : string = v218 '`'
        let v222 : (char -> string) = _.ToString()
        let v223 : string = v222 v213
        let v226 : string = v219 + v223 
        US15_0(v226, v214, v215, v216, v217)
and method101 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH3) : US15 =
    match v4 with
    | UH3_1(v7, v8) -> (* Cons *)
        let v9 : US15 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US15_1(v15) -> (* Error *)
            method101(v0, v1, v2, v3, v8)
        | US15_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH3_0 -> (* Nil *)
        let v5 : string = "parsing.choice / no parsers succeeded"
        US15_1(v5)
and method102 (v0 : UH2, v1 : UH2) : UH2 =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : UH2 = UH2_1(v2, v1)
        method102(v3, v4)
    | UH2_0 -> (* Nil *)
        v1
and method99 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US22 =
    let v5 : bool = "" = v1
    let v115 : US14 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = '"' :: v6 
            let v10 : char list = '`' :: v7 
            let v13 : char list = '\\' :: v10 
            let v16 : (char list -> (char [])) = List.toArray
            let v17 : (char []) = v16 v13
            let v20 : string = $"parsing.none_of / unexpected end of input / chars: %A{v17} / s: %A{struct (v2, v3, v4)}"
            US14_1(v20)
        else
            let v24 : char = v1.[int 0]
            let v25 : int64 = 0L
            let v26 : bool = method100(v24, v25)
            let v27 : bool = v26 = false
            if v27 then
                let v28 : (string -> int32) = String.length
                let v29 : int32 = v28 v1
                let v32 : int32 = 1 |> int32 
                let v39 : int32 = v29 |> int32 
                let v46 : int32 = v39 - 1
                let v47 : string = v1.[int v32..int v46]
                let v51 : (char -> string) = _.ToString()
                let v52 : string = v51 v24
                let v55 : int32 = v52.Length
                let v56 : (char []) = Array.zeroCreate<char> (v55)
                let v57 : Mut6 = {l0 = 0} : Mut6
                while method59(v55, v57) do
                    let v59 : int32 = v57.l0
                    let v60 : char = v52.[int v59]
                    v56.[int v59] <- v60
                    let v61 : int32 = v59 + 1
                    v57.l0 <- v61
                    ()
                let v62 : char list = v56 |> Array.toList
                let v65 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v66 : (char -> (UH0 -> UH0)) = method85()
                let v67 : (char list -> (UH0 -> UH0)) = v65 v66
                let v68 : (UH0 -> UH0) = v67 v62
                let v69 : UH0 = UH0_0
                let v70 : UH0 = v68 v69
                let struct (v92 : System.Text.StringBuilder, v93 : int32, v94 : int32) = method86(v70, v2, v3, v4)
                US14_0(v24, v47, v92, v93, v94)
            else
                let v96 : char list = []
                let v97 : char list = '"' :: v96 
                let v100 : char list = '`' :: v97 
                let v103 : char list = '\\' :: v100 
                let v106 : (char list -> (char [])) = List.toArray
                let v107 : (char []) = v106 v103
                let v110 : string = $"parsing.none_of / unexpected char: '{v24}' / chars: %A{v107} / s: %A{struct (v2, v3, v4)}"
                US14_1(v110)
    let v129 : US15 =
        match v115 with
        | US14_1(v126) -> (* Error *)
            US15_1(v126)
        | US14_0(v116, v117, v118, v119, v120) -> (* Ok *)
            let v121 : (char -> string) = _.ToString()
            let v122 : string = v121 v116
            US15_0(v122, v117, v118, v119, v120)
    let v143 : US15 =
        match v129 with
        | US15_1(v135) -> (* Error *)
            let v136 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US15) = closure38()
            let v137 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US15) = closure39()
            let v138 : UH3 = UH3_0
            let v139 : UH3 = UH3_1(v137, v138)
            let v140 : UH3 = UH3_1(v136, v139)
            method101(v1, v2, v3, v4, v140)
        | US15_0(v130, v131, v132, v133, v134) -> (* Ok *)
            v129
    match v143 with
    | US15_1(v151) -> (* Error *)
        let v152 : UH2 = UH2_0
        let v153 : UH2 = method102(v0, v152)
        US22_0(v153, v1, v2, v3, v4)
    | US15_0(v144, v145, v146, v147, v148) -> (* Ok *)
        let v149 : UH2 = UH2_1(v144, v0)
        method99(v149, v145, v146, v147, v148)
and method103 (v0 : UH2, v1 : string list) : string list =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : string list = method103(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH2_0 -> (* Nil *)
        v1
and method104 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US22 =
    let v5 : bool = "" = v1
    let v115 : US14 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = '"' :: v6 
            let v10 : char list = '`' :: v7 
            let v13 : char list = '\\' :: v10 
            let v16 : (char list -> (char [])) = List.toArray
            let v17 : (char []) = v16 v13
            let v20 : string = $"parsing.none_of / unexpected end of input / chars: %A{v17} / s: %A{struct (v2, v3, v4)}"
            US14_1(v20)
        else
            let v24 : char = v1.[int 0]
            let v25 : int64 = 0L
            let v26 : bool = method100(v24, v25)
            let v27 : bool = v26 = false
            if v27 then
                let v28 : (string -> int32) = String.length
                let v29 : int32 = v28 v1
                let v32 : int32 = 1 |> int32 
                let v39 : int32 = v29 |> int32 
                let v46 : int32 = v39 - 1
                let v47 : string = v1.[int v32..int v46]
                let v51 : (char -> string) = _.ToString()
                let v52 : string = v51 v24
                let v55 : int32 = v52.Length
                let v56 : (char []) = Array.zeroCreate<char> (v55)
                let v57 : Mut6 = {l0 = 0} : Mut6
                while method59(v55, v57) do
                    let v59 : int32 = v57.l0
                    let v60 : char = v52.[int v59]
                    v56.[int v59] <- v60
                    let v61 : int32 = v59 + 1
                    v57.l0 <- v61
                    ()
                let v62 : char list = v56 |> Array.toList
                let v65 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v66 : (char -> (UH0 -> UH0)) = method85()
                let v67 : (char list -> (UH0 -> UH0)) = v65 v66
                let v68 : (UH0 -> UH0) = v67 v62
                let v69 : UH0 = UH0_0
                let v70 : UH0 = v68 v69
                let struct (v92 : System.Text.StringBuilder, v93 : int32, v94 : int32) = method86(v70, v2, v3, v4)
                US14_0(v24, v47, v92, v93, v94)
            else
                let v96 : char list = []
                let v97 : char list = '"' :: v96 
                let v100 : char list = '`' :: v97 
                let v103 : char list = '\\' :: v100 
                let v106 : (char list -> (char [])) = List.toArray
                let v107 : (char []) = v106 v103
                let v110 : string = $"parsing.none_of / unexpected char: '{v24}' / chars: %A{v107} / s: %A{struct (v2, v3, v4)}"
                US14_1(v110)
    let v129 : US15 =
        match v115 with
        | US14_1(v126) -> (* Error *)
            US15_1(v126)
        | US14_0(v116, v117, v118, v119, v120) -> (* Ok *)
            let v121 : (char -> string) = _.ToString()
            let v122 : string = v121 v116
            US15_0(v122, v117, v118, v119, v120)
    match v129 with
    | US15_1(v137) -> (* Error *)
        let v138 : UH2 = UH2_0
        let v139 : UH2 = method102(v0, v138)
        US22_0(v139, v1, v2, v3, v4)
    | US15_0(v130, v131, v132, v133, v134) -> (* Ok *)
        let v135 : UH2 = UH2_1(v130, v0)
        method104(v135, v131, v132, v133, v134)
and method96 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US22 =
    let v5 : bool = "" = v1
    let v121 : US14 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = ' ' :: v6 
            let v10 : char list = '"' :: v7 
            let v13 : char list = '`' :: v10 
            let v16 : char list = '\\' :: v13 
            let v19 : (char list -> (char [])) = List.toArray
            let v20 : (char []) = v19 v16
            let v23 : string = $"parsing.none_of / unexpected end of input / chars: %A{v20} / s: %A{struct (v2, v3, v4)}"
            US14_1(v23)
        else
            let v27 : char = v1.[int 0]
            let v28 : int64 = 0L
            let v29 : bool = method97(v27, v28)
            let v30 : bool = v29 = false
            if v30 then
                let v31 : (string -> int32) = String.length
                let v32 : int32 = v31 v1
                let v35 : int32 = 1 |> int32 
                let v42 : int32 = v32 |> int32 
                let v49 : int32 = v42 - 1
                let v50 : string = v1.[int v35..int v49]
                let v54 : (char -> string) = _.ToString()
                let v55 : string = v54 v27
                let v58 : int32 = v55.Length
                let v59 : (char []) = Array.zeroCreate<char> (v58)
                let v60 : Mut6 = {l0 = 0} : Mut6
                while method59(v58, v60) do
                    let v62 : int32 = v60.l0
                    let v63 : char = v55.[int v62]
                    v59.[int v62] <- v63
                    let v64 : int32 = v62 + 1
                    v60.l0 <- v64
                    ()
                let v65 : char list = v59 |> Array.toList
                let v68 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v69 : (char -> (UH0 -> UH0)) = method85()
                let v70 : (char list -> (UH0 -> UH0)) = v68 v69
                let v71 : (UH0 -> UH0) = v70 v65
                let v72 : UH0 = UH0_0
                let v73 : UH0 = v71 v72
                let struct (v95 : System.Text.StringBuilder, v96 : int32, v97 : int32) = method86(v73, v2, v3, v4)
                US14_0(v27, v50, v95, v96, v97)
            else
                let v99 : char list = []
                let v100 : char list = ' ' :: v99 
                let v103 : char list = '"' :: v100 
                let v106 : char list = '`' :: v103 
                let v109 : char list = '\\' :: v106 
                let v112 : (char list -> (char [])) = List.toArray
                let v113 : (char []) = v112 v109
                let v116 : string = $"parsing.none_of / unexpected char: '{v27}' / chars: %A{v113} / s: %A{struct (v2, v3, v4)}"
                US14_1(v116)
    let v140 : US15 =
        match v121 with
        | US14_1(v137) -> (* Error *)
            US15_1(v137)
        | US14_0(v122, v123, v124, v125, v126) -> (* Ok *)
            let v127 : (char -> string) = _.ToString()
            let v128 : string = v127 v122
            let struct (v131 : string, v132 : string, v133 : System.Text.StringBuilder, v134 : int32, v135 : int32) = method98(v128, v123, v124, v125, v126)
            US15_0(v131, v132, v133, v134, v135)
    let v521 : US15 =
        match v140 with
        | US15_1(v146) -> (* Error *)
            let v270 : US14 =
                if v5 then
                    let v147 : string = $"parsing.p_char / unexpected end of input / c: '{'"'}' / s: %A{struct (v2, v3, v4)}"
                    US14_1(v147)
                else
                    let v151 : char = v1.[int 0]
                    let v152 : bool = v151 = '"'
                    if v152 then
                        let v153 : (string -> int32) = String.length
                        let v154 : int32 = v153 v1
                        let v157 : int32 = 1 |> int32 
                        let v164 : int32 = v154 |> int32 
                        let v171 : int32 = v164 - 1
                        let v172 : string = v1.[int v157..int v171]
                        let v176 : (char -> string) = _.ToString()
                        let v177 : string = v176 v151
                        let v180 : int32 = v177.Length
                        let v181 : (char []) = Array.zeroCreate<char> (v180)
                        let v182 : Mut6 = {l0 = 0} : Mut6
                        while method59(v180, v182) do
                            let v184 : int32 = v182.l0
                            let v185 : char = v177.[int v184]
                            v181.[int v184] <- v185
                            let v186 : int32 = v184 + 1
                            v182.l0 <- v186
                            ()
                        let v187 : char list = v181 |> Array.toList
                        let v190 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v191 : (char -> (UH0 -> UH0)) = method85()
                        let v192 : (char list -> (UH0 -> UH0)) = v190 v191
                        let v193 : (UH0 -> UH0) = v192 v187
                        let v194 : UH0 = UH0_0
                        let v195 : UH0 = v193 v194
                        let struct (v217 : System.Text.StringBuilder, v218 : int32, v219 : int32) = method86(v195, v2, v3, v4)
                        US14_0(v151, v172, v217, v218, v219)
                    else
                        let v221 : string = "\n"
                        let v222 : int32 = v1.IndexOf v221 
                        let v225 : int32 = v222 - 1
                        let v226 : bool = -2 = v225
                        let v233 : int32 =
                            if v226 then
                                let v227 : (string -> int32) = String.length
                                let v228 : int32 = v227 v1
                                let v231 : int32 = v228 + 1
                                v231
                            else
                                let v232 : int32 = v225 + 1
                                v232
                        let v234 : int32 = 0 |> int32 
                        let v241 : int32 = v233 |> int32 
                        let v248 : int32 = v241 - 1
                        let v249 : string = v1.[int v234..int v248]
                        let v253 : string = $"parsing.p_char / expected: '{'"'}' / line: {v3} / col: {v4}
{v2}{v249}"
                        let v256 : int32 = v4 - 1
                        let v257 : (int32 -> (string -> string)) = String.replicate
                        let v258 : (string -> string) = v257 v256
                        let v259 : string = " "
                        let v260 : string = v258 v259
                        let v263 : string = "^"
                        let v264 : string = v260 + v263 
                        let v265 : string = $"{v253}
{v264}
"
                        US14_1(v265)
            let v456 : US15 =
                match v270 with
                | US14_1(v453) -> (* Error *)
                    US15_1(v453)
                | US14_0(v271, v272, v273, v274, v275) -> (* Ok *)
                    let v276 : UH2 = UH2_0
                    let v277 : US22 = method99(v276, v272, v273, v274, v275)
                    let v304 : US15 =
                        match v277 with
                        | US22_1(v301) -> (* Error *)
                            US15_1(v301)
                        | US22_0(v278, v279, v280, v281, v282) -> (* Ok *)
                            let v283 : string list = []
                            let v284 : string list = method103(v278, v283)
                            let v285 : unit = ()
                            let _v285 =
                                seq {
                                    for i = 0 to v284.Length - 1 do yield v284.[i]
                                    (* indent
                                    ()
                                indent *)
                                }
                                (* indent
                                ()
                            indent *)
                            let v288 : string seq = _v285 
                            let v294 : (string -> (string seq -> string)) = String.concat
                            let v295 : string = ""
                            let v296 : (string seq -> string) = v294 v295
                            let v297 : string = v296 v288
                            US15_0(v297, v279, v280, v281, v282)
                    match v304 with
                    | US15_1(v448) -> (* Error *)
                        let v449 : string = "parsing.between / expected content"
                        US15_1(v449)
                    | US15_0(v305, v306, v307, v308, v309) -> (* Ok *)
                        let v310 : bool = "" = v306
                        let v434 : US14 =
                            if v310 then
                                let v311 : string = $"parsing.p_char / unexpected end of input / c: '{'"'}' / s: %A{struct (v307, v308, v309)}"
                                US14_1(v311)
                            else
                                let v315 : char = v306.[int 0]
                                let v316 : bool = v315 = '"'
                                if v316 then
                                    let v317 : (string -> int32) = String.length
                                    let v318 : int32 = v317 v306
                                    let v321 : int32 = 1 |> int32 
                                    let v328 : int32 = v318 |> int32 
                                    let v335 : int32 = v328 - 1
                                    let v336 : string = v306.[int v321..int v335]
                                    let v340 : (char -> string) = _.ToString()
                                    let v341 : string = v340 v315
                                    let v344 : int32 = v341.Length
                                    let v345 : (char []) = Array.zeroCreate<char> (v344)
                                    let v346 : Mut6 = {l0 = 0} : Mut6
                                    while method59(v344, v346) do
                                        let v348 : int32 = v346.l0
                                        let v349 : char = v341.[int v348]
                                        v345.[int v348] <- v349
                                        let v350 : int32 = v348 + 1
                                        v346.l0 <- v350
                                        ()
                                    let v351 : char list = v345 |> Array.toList
                                    let v354 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                                    let v355 : (char -> (UH0 -> UH0)) = method85()
                                    let v356 : (char list -> (UH0 -> UH0)) = v354 v355
                                    let v357 : (UH0 -> UH0) = v356 v351
                                    let v358 : UH0 = UH0_0
                                    let v359 : UH0 = v357 v358
                                    let struct (v381 : System.Text.StringBuilder, v382 : int32, v383 : int32) = method86(v359, v307, v308, v309)
                                    US14_0(v315, v336, v381, v382, v383)
                                else
                                    let v385 : string = "\n"
                                    let v386 : int32 = v306.IndexOf v385 
                                    let v389 : int32 = v386 - 1
                                    let v390 : bool = -2 = v389
                                    let v397 : int32 =
                                        if v390 then
                                            let v391 : (string -> int32) = String.length
                                            let v392 : int32 = v391 v306
                                            let v395 : int32 = v392 + 1
                                            v395
                                        else
                                            let v396 : int32 = v389 + 1
                                            v396
                                    let v398 : int32 = 0 |> int32 
                                    let v405 : int32 = v397 |> int32 
                                    let v412 : int32 = v405 - 1
                                    let v413 : string = v306.[int v398..int v412]
                                    let v417 : string = $"parsing.p_char / expected: '{'"'}' / line: {v308} / col: {v309}
{v307}{v413}"
                                    let v420 : int32 = v309 - 1
                                    let v421 : (int32 -> (string -> string)) = String.replicate
                                    let v422 : (string -> string) = v421 v420
                                    let v423 : string = " "
                                    let v424 : string = v422 v423
                                    let v427 : string = "^"
                                    let v428 : string = v424 + v427 
                                    let v429 : string = $"{v417}
{v428}
"
                                    US14_1(v429)
                        match v434 with
                        | US14_1(v441) -> (* Error *)
                            let v442 : string = $"parsing.between / expected closing delimiter / e: %A{v441} / input: %A{struct (v1, v2, v3, v4)} / rest1: %A{struct (v272, v273, v274, v275)} / rest2: %A{struct (v306, v307, v308, v309)}"
                            US15_1(v442)
                        | US14_0(v435, v436, v437, v438, v439) -> (* Ok *)
                            US15_0(v305, v436, v437, v438, v439)
            match v456 with
            | US15_1(v462) -> (* Error *)
                let v463 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US15) = closure38()
                let v464 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US15) = closure39()
                let v465 : UH3 = UH3_0
                let v466 : UH3 = UH3_1(v464, v465)
                let v467 : UH3 = UH3_1(v463, v466)
                let v468 : US15 = method101(v1, v2, v3, v4, v467)
                let v479 : US15 =
                    match v468 with
                    | US15_1(v476) -> (* Error *)
                        US15_1(v476)
                    | US15_0(v469, v470, v471, v472, v473) -> (* Ok *)
                        let v474 : string = ""
                        US15_0(v474, v470, v471, v472, v473)
                let v490 : US22 =
                    match v479 with
                    | US15_1(v487) -> (* Error *)
                        US22_1(v487)
                    | US15_0(v480, v481, v482, v483, v484) -> (* Ok *)
                        let v485 : UH2 = UH2_0
                        method104(v485, v481, v482, v483, v484)
                match v490 with
                | US22_1(v514) -> (* Error *)
                    US15_1(v514)
                | US22_0(v491, v492, v493, v494, v495) -> (* Ok *)
                    let v496 : string list = []
                    let v497 : string list = method103(v491, v496)
                    let v498 : unit = ()
                    let _v498 =
                        seq {
                            for i = 0 to v497.Length - 1 do yield v497.[i]
                            (* indent
                            ()
                        indent *)
                        }
                        (* indent
                        ()
                    indent *)
                    let v501 : string seq = _v498 
                    let v507 : (string -> (string seq -> string)) = String.concat
                    let v508 : string = ""
                    let v509 : (string seq -> string) = v507 v508
                    let v510 : string = v509 v501
                    US15_0(v510, v492, v493, v494, v495)
            | US15_0(v457, v458, v459, v460, v461) -> (* Ok *)
                v456
        | US15_0(v141, v142, v143, v144, v145) -> (* Ok *)
            v140
    match v521 with
    | US15_1(v570) -> (* Error *)
        let v571 : UH2 = UH2_0
        let v572 : UH2 = method102(v0, v571)
        US22_0(v572, v1, v2, v3, v4)
    | US15_0(v522, v523, v524, v525, v526) -> (* Ok *)
        let v527 : int32 = 0
        let v528 : int32 = method93(v523, v527)
        let v529 : bool = 0 = v528
        let v556 : US17 =
            if v529 then
                let v530 : string = "parsing.spaces1 / expected at least one space"
                US17_1(v530)
            else
                let v532 : (string -> int32) = String.length
                let v533 : int32 = v532 v523
                let v536 : int32 = v528 |> int32 
                let v543 : int32 = v533 |> int32 
                let v550 : int32 = v543 - 1
                let v551 : string = v523.[int v536..int v550]
                US17_0(v551, v524, v525, v526)
        match v556 with
        | US17_1(v563) -> (* Error *)
            let v564 : UH2 = UH2_0
            let v565 : UH2 = UH2_1(v522, v564)
            let v566 : UH2 = method102(v0, v565)
            US22_0(v566, v523, v524, v525, v526)
        | US17_0(v557, v558, v559, v560) -> (* Ok *)
            let v561 : UH2 = UH2_1(v522, v0)
            method96(v561, v557, v558, v559, v560)
and method95 (v0 : string) : US21 =
    let mutable _v0 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v1 : (string -> string option) = Option.ofObj
    let v2 : string option = v1 v0
    v2 
    #else
    Some v0 
    #endif
    |> fun x -> _v0 <- Some x
    let v3 : string option = match _v0 with Some x -> x | None -> failwith "optionm'.of_obj / _v0=None"
    let v6 : string = ""
    let v7 : string = v3 |> Option.defaultValue v6 
    let v10 : string = method84()
    let v11 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v12 : System.Text.StringBuilder = v11 v10
    let v15 : UH2 = UH2_0
    let v16 : int32 = 1
    let v17 : int32 = 1
    let v18 : US22 = method96(v15, v7, v12, v16, v17)
    match v18 with
    | US22_1(v31) -> (* Error *)
        US21_1(v31)
    | US22_0(v19, v20, v21, v22, v23) -> (* Ok *)
        let v24 : string list = []
        let v25 : string list = method103(v19, v24)
        let v26 : (string list -> (string [])) = List.toArray
        let v27 : (string []) = v26 v25
        US21_0(v27)
and method106 (v0 : string, v1 : string, v2 : string, v3 : System.Threading.CancellationToken option, v4 : (struct (string * string) []), v5 : (struct (int32 * string * bool) -> Async<unit>) option, v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v7 : bool, v8 : string option) : string =
    let v9 : string = method14()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v11 : string = "{ "
    let v12 : string = $"{v11}"
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure8(v10, v12)
    let v17 : unit = (fun () -> v16 (); v15) ()
    let v20 : string = "file_name"
    let v21 : string = $"{v20}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure8(v10, v21)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v29 : string = " = "
    let v30 : string = $"{v29}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure8(v10, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v38 : string = $"{v0}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure8(v10, v38)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v46 : string = "; "
    let v47 : string = $"{v46}"
    let v50 : unit = ()
    let v51 : (unit -> unit) = closure8(v10, v47)
    let v52 : unit = (fun () -> v51 (); v50) ()
    let v55 : string = "arguments"
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure8(v10, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v64 : string = $"{v29}"
    let v67 : unit = ()
    let v68 : (unit -> unit) = closure8(v10, v64)
    let v69 : unit = (fun () -> v68 (); v67) ()
    let v72 : string = $"{v1}"
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure8(v10, v72)
    let v77 : unit = (fun () -> v76 (); v75) ()
    let v80 : string = $"{v46}"
    let v83 : unit = ()
    let v84 : (unit -> unit) = closure8(v10, v80)
    let v85 : unit = (fun () -> v84 (); v83) ()
    let v88 : string = "options"
    let v89 : string = $"{v88}"
    let v92 : unit = ()
    let v93 : (unit -> unit) = closure8(v10, v89)
    let v94 : unit = (fun () -> v93 (); v92) ()
    let v97 : string = $"{v29}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure8(v10, v97)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v105 : string = $"{v11}"
    let v108 : unit = ()
    let v109 : (unit -> unit) = closure8(v10, v105)
    let v110 : unit = (fun () -> v109 (); v108) ()
    let v113 : string = "command"
    let v114 : string = $"{v113}"
    let v117 : unit = ()
    let v118 : (unit -> unit) = closure8(v10, v114)
    let v119 : unit = (fun () -> v118 (); v117) ()
    let v122 : string = $"{v29}"
    let v125 : unit = ()
    let v126 : (unit -> unit) = closure8(v10, v122)
    let v127 : unit = (fun () -> v126 (); v125) ()
    let v130 : string = $"{v2}"
    let v133 : unit = ()
    let v134 : (unit -> unit) = closure8(v10, v130)
    let v135 : unit = (fun () -> v134 (); v133) ()
    let v138 : string = $"{v46}"
    let v141 : unit = ()
    let v142 : (unit -> unit) = closure8(v10, v138)
    let v143 : unit = (fun () -> v142 (); v141) ()
    let v146 : string = "cancellation_token"
    let v147 : string = $"{v146}"
    let v150 : unit = ()
    let v151 : (unit -> unit) = closure8(v10, v147)
    let v152 : unit = (fun () -> v151 (); v150) ()
    let v155 : string = $"{v29}"
    let v158 : unit = ()
    let v159 : (unit -> unit) = closure8(v10, v155)
    let v160 : unit = (fun () -> v159 (); v158) ()
    let v163 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v164 : string = "format!(\"{:#?}\", $0)"
    let v165 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v164 
    let v166 : string = "fable_library_rust::String_::fromString($0)"
    let v167 : string = Fable.Core.RustInterop.emitRustExpr v165 v166 
    let _v163 = v167 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v168 : string = "format!(\"{:#?}\", $0)"
    let v169 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v168 
    let v170 : string = "fable_library_rust::String_::fromString($0)"
    let v171 : string = Fable.Core.RustInterop.emitRustExpr v169 v170 
    let _v163 = v171 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v172 : string = "format!(\"{:#?}\", $0)"
    let v173 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v172 
    let v174 : string = "fable_library_rust::String_::fromString($0)"
    let v175 : string = Fable.Core.RustInterop.emitRustExpr v173 v174 
    let _v163 = v175 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v176 : string = $"%A{v3}"
    let _v163 = v176 
    #endif
#if FABLE_COMPILER_PYTHON
    let v179 : string = $"%A{v3}"
    let _v163 = v179 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v182 : string = $"%A{v3}"
    let _v163 = v182 
    #endif
#else
    let v185 : string = $"%A{v3}"
    let _v163 = v185 
    #endif
    let v188 : string = _v163 
    let v193 : string = $"{v188}"
    let v196 : unit = ()
    let v197 : (unit -> unit) = closure8(v10, v193)
    let v198 : unit = (fun () -> v197 (); v196) ()
    let v201 : string = $"{v46}"
    let v204 : unit = ()
    let v205 : (unit -> unit) = closure8(v10, v201)
    let v206 : unit = (fun () -> v205 (); v204) ()
    let v209 : string = "environment_variables"
    let v210 : string = $"{v209}"
    let v213 : unit = ()
    let v214 : (unit -> unit) = closure8(v10, v210)
    let v215 : unit = (fun () -> v214 (); v213) ()
    let v218 : string = $"{v29}"
    let v221 : unit = ()
    let v222 : (unit -> unit) = closure8(v10, v218)
    let v223 : unit = (fun () -> v222 (); v221) ()
    let v226 : string = $"%A{v4}"
    let v229 : string = $"{v226}"
    let v232 : unit = ()
    let v233 : (unit -> unit) = closure8(v10, v229)
    let v234 : unit = (fun () -> v233 (); v232) ()
    let v237 : string = $"{v46}"
    let v240 : unit = ()
    let v241 : (unit -> unit) = closure8(v10, v237)
    let v242 : unit = (fun () -> v241 (); v240) ()
    let v245 : string = "on_line"
    let v246 : string = $"{v245}"
    let v249 : unit = ()
    let v250 : (unit -> unit) = closure8(v10, v246)
    let v251 : unit = (fun () -> v250 (); v249) ()
    let v254 : string = $"{v29}"
    let v257 : unit = ()
    let v258 : (unit -> unit) = closure8(v10, v254)
    let v259 : unit = (fun () -> v258 (); v257) ()
    let v262 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v263 : string = "format!(\"{:#?}\", $0)"
    let v264 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v263 
    let v265 : string = "fable_library_rust::String_::fromString($0)"
    let v266 : string = Fable.Core.RustInterop.emitRustExpr v264 v265 
    let _v262 = v266 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v267 : string = "format!(\"{:#?}\", $0)"
    let v268 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v267 
    let v269 : string = "fable_library_rust::String_::fromString($0)"
    let v270 : string = Fable.Core.RustInterop.emitRustExpr v268 v269 
    let _v262 = v270 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v271 : string = "format!(\"{:#?}\", $0)"
    let v272 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v271 
    let v273 : string = "fable_library_rust::String_::fromString($0)"
    let v274 : string = Fable.Core.RustInterop.emitRustExpr v272 v273 
    let _v262 = v274 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v275 : string = $"%A{v5}"
    let _v262 = v275 
    #endif
#if FABLE_COMPILER_PYTHON
    let v278 : string = $"%A{v5}"
    let _v262 = v278 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v281 : string = $"%A{v5}"
    let _v262 = v281 
    #endif
#else
    let v284 : string = $"%A{v5}"
    let _v262 = v284 
    #endif
    let v287 : string = _v262 
    let v292 : string = $"{v287}"
    let v295 : unit = ()
    let v296 : (unit -> unit) = closure8(v10, v292)
    let v297 : unit = (fun () -> v296 (); v295) ()
    let v300 : string = $"{v46}"
    let v303 : unit = ()
    let v304 : (unit -> unit) = closure8(v10, v300)
    let v305 : unit = (fun () -> v304 (); v303) ()
    let v308 : string = "stdin"
    let v309 : string = $"{v308}"
    let v312 : unit = ()
    let v313 : (unit -> unit) = closure8(v10, v309)
    let v314 : unit = (fun () -> v313 (); v312) ()
    let v317 : string = $"{v29}"
    let v320 : unit = ()
    let v321 : (unit -> unit) = closure8(v10, v317)
    let v322 : unit = (fun () -> v321 (); v320) ()
    let v325 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v326 : string = "format!(\"{:#?}\", $0)"
    let v327 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v326 
    let v328 : string = "fable_library_rust::String_::fromString($0)"
    let v329 : string = Fable.Core.RustInterop.emitRustExpr v327 v328 
    let _v325 = v329 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v330 : string = "format!(\"{:#?}\", $0)"
    let v331 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v330 
    let v332 : string = "fable_library_rust::String_::fromString($0)"
    let v333 : string = Fable.Core.RustInterop.emitRustExpr v331 v332 
    let _v325 = v333 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v334 : string = "format!(\"{:#?}\", $0)"
    let v335 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v334 
    let v336 : string = "fable_library_rust::String_::fromString($0)"
    let v337 : string = Fable.Core.RustInterop.emitRustExpr v335 v336 
    let _v325 = v337 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v338 : string = $"%A{v6}"
    let _v325 = v338 
    #endif
#if FABLE_COMPILER_PYTHON
    let v341 : string = $"%A{v6}"
    let _v325 = v341 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v344 : string = $"%A{v6}"
    let _v325 = v344 
    #endif
#else
    let v347 : string = $"%A{v6}"
    let _v325 = v347 
    #endif
    let v350 : string = _v325 
    let v355 : string = $"{v350}"
    let v358 : unit = ()
    let v359 : (unit -> unit) = closure8(v10, v355)
    let v360 : unit = (fun () -> v359 (); v358) ()
    let v363 : string = $"{v46}"
    let v366 : unit = ()
    let v367 : (unit -> unit) = closure8(v10, v363)
    let v368 : unit = (fun () -> v367 (); v366) ()
    let v371 : string = "trace"
    let v372 : string = $"{v371}"
    let v375 : unit = ()
    let v376 : (unit -> unit) = closure8(v10, v372)
    let v377 : unit = (fun () -> v376 (); v375) ()
    let v380 : string = $"{v29}"
    let v383 : unit = ()
    let v384 : (unit -> unit) = closure8(v10, v380)
    let v385 : unit = (fun () -> v384 (); v383) ()
    let v390 : string =
        if v7 then
            let v388 : string = "true"
            v388
        else
            let v389 : string = "false"
            v389
    let v391 : string = $"{v390}"
    let v394 : unit = ()
    let v395 : (unit -> unit) = closure8(v10, v391)
    let v396 : unit = (fun () -> v395 (); v394) ()
    let v399 : string = $"{v46}"
    let v402 : unit = ()
    let v403 : (unit -> unit) = closure8(v10, v399)
    let v404 : unit = (fun () -> v403 (); v402) ()
    let v407 : string = "working_directory"
    let v408 : string = $"{v407}"
    let v411 : unit = ()
    let v412 : (unit -> unit) = closure8(v10, v408)
    let v413 : unit = (fun () -> v412 (); v411) ()
    let v416 : string = $"{v29}"
    let v419 : unit = ()
    let v420 : (unit -> unit) = closure8(v10, v416)
    let v421 : unit = (fun () -> v420 (); v419) ()
    let v424 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v425 : string = "format!(\"{:#?}\", $0)"
    let v426 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v425 
    let v427 : string = "fable_library_rust::String_::fromString($0)"
    let v428 : string = Fable.Core.RustInterop.emitRustExpr v426 v427 
    let _v424 = v428 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v429 : string = "format!(\"{:#?}\", $0)"
    let v430 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v429 
    let v431 : string = "fable_library_rust::String_::fromString($0)"
    let v432 : string = Fable.Core.RustInterop.emitRustExpr v430 v431 
    let _v424 = v432 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v433 : string = "format!(\"{:#?}\", $0)"
    let v434 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v433 
    let v435 : string = "fable_library_rust::String_::fromString($0)"
    let v436 : string = Fable.Core.RustInterop.emitRustExpr v434 v435 
    let _v424 = v436 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v437 : string = $"%A{v8}"
    let _v424 = v437 
    #endif
#if FABLE_COMPILER_PYTHON
    let v440 : string = $"%A{v8}"
    let _v424 = v440 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v443 : string = $"%A{v8}"
    let _v424 = v443 
    #endif
#else
    let v446 : string = $"%A{v8}"
    let _v424 = v446 
    #endif
    let v449 : string = _v424 
    let v454 : string = $"{v449}"
    let v457 : unit = ()
    let v458 : (unit -> unit) = closure8(v10, v454)
    let v459 : unit = (fun () -> v458 (); v457) ()
    let v462 : string = " }"
    let v463 : string = $"{v462}"
    let v466 : unit = ()
    let v467 : (unit -> unit) = closure8(v10, v463)
    let v468 : unit = (fun () -> v467 (); v466) ()
    let v471 : string = $"{v462}"
    let v474 : unit = ()
    let v475 : (unit -> unit) = closure8(v10, v471)
    let v476 : unit = (fun () -> v475 (); v474) ()
    let v479 : string = v10.l0
    v479
and method105 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option) : string =
    let v17 : string = method106(v8, v9, v10, v11, v12, v13, v14, v15, v16)
    let v18 : int64 = v0.l0
    let v19 : string = "runtime.execute_with_options"
    let v20 : string = $"{v6} {v7} #{v18} %s{v19} / {v17}"
    method18(v20)
and closure40 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : string, v8 : Vec<std_string_String>) () : unit =
    let v9 : US0 = US0_1
    let v10 : bool = method7(v9)
    if v10 then
        let v11 : unit = ()
        let v12 : (unit -> unit) = closure6()
        let v13 : unit = (fun () -> v12 (); v11) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method8(v27, v28, v29, v30, v31, v32)
        let v46 : string = method62()
        let v47 : string = $"%A{v8}"
        let v50 : string = method105(v27, v28, v29, v30, v31, v32, v45, v46, v7, v47, v0, v1, v2, v3, v4, v5, v6)
        method19(v50)
and closure41 () (v0 : std_process_Child option) : std_process_Child option =
    v0
and method107 () : (std_process_Child option -> std_process_Child option) =
    closure41()
and closure42 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : US23 =
    US23_0(v0)
and method108 () : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US23) =
    closure42()
and closure43 () (v0 : std_string_String) : US23 =
    US23_1(v0)
and method109 () : (std_string_String -> US23) =
    closure43()
and method110 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method76(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "runtime.execute_with_options / child error"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method18(v12)
and closure44 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_4
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method8(v19, v20, v21, v22, v23, v24)
        let v38 : string = method74()
        let v39 : string = method110(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method19(v39)
and method111 (v0 : std_sync_MutexGuard<std_process_Child option>) : std_sync_MutexGuard<std_process_Child option> =
    v0
and closure45 () (v0 : std_process_ChildStdin option) : std_process_ChildStdin option =
    v0
and method112 () : (std_process_ChildStdin option -> std_process_ChildStdin option) =
    closure45()
and closure46 () (v0 : std_sync_mpsc_Sender<std_string_String>) : std_sync_mpsc_Sender<std_string_String> =
    v0
and method113 () : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) =
    closure46()
and method114 () : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) =
    closure46()
and closure47 () (v0 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> =
    v0
and method115 () : (std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> -> std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) =
    closure47()
and closure48 () (v0 : std_string_String) : US25 =
    US25_0(v0)
and method116 () : (std_string_String -> US25) =
    closure48()
and closure49 () (v0 : std_string_String) : US25 =
    US25_1(v0)
and method117 () : (std_string_String -> US25) =
    closure49()
and method119 (v0 : bool, v1 : std_string_String) : string =
    let v2 : string = method14()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "trace'"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure8(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure8(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v33 : string =
        if v0 then
            let v31 : string = "true"
            v31
        else
            let v32 : string = "false"
            v32
    let v34 : string = $"{v33}"
    let v37 : unit = ()
    let v38 : (unit -> unit) = closure8(v3, v34)
    let v39 : unit = (fun () -> v38 (); v37) ()
    let v42 : string = "; "
    let v43 : string = $"{v42}"
    let v46 : unit = ()
    let v47 : (unit -> unit) = closure8(v3, v43)
    let v48 : unit = (fun () -> v47 (); v46) ()
    let v51 : string = "e"
    let v52 : string = $"{v51}"
    let v55 : unit = ()
    let v56 : (unit -> unit) = closure8(v3, v52)
    let v57 : unit = (fun () -> v56 (); v55) ()
    let v60 : string = $"{v22}"
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure8(v3, v60)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v68 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v69 : string = "format!(\"{:#?}\", $0)"
    let v70 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v69 
    let v71 : string = "fable_library_rust::String_::fromString($0)"
    let v72 : string = Fable.Core.RustInterop.emitRustExpr v70 v71 
    let _v68 = v72 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v73 : string = "format!(\"{:#?}\", $0)"
    let v74 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v73 
    let v75 : string = "fable_library_rust::String_::fromString($0)"
    let v76 : string = Fable.Core.RustInterop.emitRustExpr v74 v75 
    let _v68 = v76 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v77 : string = "format!(\"{:#?}\", $0)"
    let v78 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v77 
    let v79 : string = "fable_library_rust::String_::fromString($0)"
    let v80 : string = Fable.Core.RustInterop.emitRustExpr v78 v79 
    let _v68 = v80 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : string = $"%A{v1}"
    let _v68 = v81 
    #endif
#if FABLE_COMPILER_PYTHON
    let v84 : string = $"%A{v1}"
    let _v68 = v84 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v87 : string = $"%A{v1}"
    let _v68 = v87 
    #endif
#else
    let v90 : string = $"%A{v1}"
    let _v68 = v90 
    #endif
    let v93 : string = _v68 
    let v98 : string = $"{v93}"
    let v101 : unit = ()
    let v102 : (unit -> unit) = closure8(v3, v98)
    let v103 : unit = (fun () -> v102 (); v101) ()
    let v106 : string = " }"
    let v107 : string = $"{v106}"
    let v110 : unit = ()
    let v111 : (unit -> unit) = closure8(v3, v107)
    let v112 : unit = (fun () -> v111 (); v110) ()
    let v115 : string = v3.l0
    v115
and method118 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : bool, v9 : std_string_String) : string =
    let v10 : string = method119(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "runtime.stdio_line"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method18(v13)
and closure50 (v0 : bool, v1 : std_string_String) () : unit =
    let v2 : US0 = US0_4
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method8(v20, v21, v22, v23, v24, v25)
        let v39 : string = method74()
        let v40 : string = method118(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method19(v40)
and method120 () : string =
    
    
    
    
    
    let v0 : string = "Verbose"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method13(v5)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "inline_colorization::color_bright_black"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v11 
    let _v10 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v13 
    let _v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v15 : string = "&*$0"
    let v16 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v15 
    let _v10 = v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v23 
    #endif
#else
    let v26 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v26 
    #endif
    let v29 : Ref<Str> = _v10 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9, v29, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v7 = v39 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v40 : string = "inline_colorization::color_bright_black"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v43 : string = "&*$0"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v43 
    let _v42 = v44 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v45 : string = "&*$0"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v45 
    let _v42 = v46 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v47 : string = "&*$0"
    let v48 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v47 
    let _v42 = v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v49 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v49 
    #endif
#if FABLE_COMPILER_PYTHON
    let v52 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v52 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v55 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v55 
    #endif
#else
    let v58 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v42 = v58 
    #endif
    let v61 : Ref<Str> = _v42 
    let v66 : string = "inline_colorization::color_reset"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v61, v67) v68 
    let v70 : string = "fable_library_rust::String_::fromString($0)"
    let v71 : string = Fable.Core.RustInterop.emitRustExpr v69 v70 
    let _v7 = v71 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v72 : string = "inline_colorization::color_bright_black"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v75 : string = "&*$0"
    let v76 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v75 
    let _v74 = v76 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v77 : string = "&*$0"
    let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v77 
    let _v74 = v78 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : string = "&*$0"
    let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v79 
    let _v74 = v80 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v81 
    #endif
#if FABLE_COMPILER_PYTHON
    let v84 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v84 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v87 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v87 
    #endif
#else
    let v90 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v74 = v90 
    #endif
    let v93 : Ref<Str> = _v74 
    let v98 : string = "inline_colorization::color_reset"
    let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v98 
    let v100 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v73, v93, v99) v100 
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let _v7 = v103 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v104 : string = "\u001b[90m"
    let v105 : string = method15()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[90m"
    let v109 : string = method15()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[90m"
    let v113 : string = method15()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[90m"
    let v117 : string = method15()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method122 () : string =
    let v0 : string = method14()
    let v1 : Mut3 = {l0 = v0} : Mut3
    let v2 : string = v1.l0
    v2
and method121 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method122()
    let v10 : int64 = v0.l0
    let v11 : string = $"{v6} {v7} #{v10} %s{v8} / {v9}"
    method18(v11)
and closure51 (v0 : string) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method8(v19, v20, v21, v22, v23, v24)
        let v38 : string = method120()
        let v39 : bool = v0 = ""
        let v42 : string =
            if v39 then
                let v40 : string = ""
                v40
            else
                method121(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method19(v42)
and closure52 () (v0 : std_sync_mpsc_SendError<std_string_String>) : std_string_String =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let _v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v11 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v14 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v14 
    #endif
#else
    let v17 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v17 
    #endif
    let v20 : std_string_String = _v1 
    v20
and method123 () : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) =
    closure52()
and method124 (v0 : Result<unit, string>) : Result<unit, string> =
    v0
and closure53 () (v0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)) : US26 =
    US26_0(v0)
and method125 () : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US26) =
    closure53()
and method126 (v0 : std_sync_MutexGuard<std_process_ChildStdin option>) : std_sync_MutexGuard<std_process_ChildStdin option> =
    v0
and closure54 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : US27 =
    US27_0(v0)
and method127 () : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US27) =
    closure54()
and method128 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and method129 (v0 : std_thread_JoinHandle<Result<unit, string>>) : std_thread_JoinHandle<Result<unit, string>> =
    v0
and closure55 () (v0 : std_process_Output) : US28 =
    US28_0(v0)
and method130 () : (std_process_Output -> US28) =
    closure55()
and closure56 () (v0 : std_string_String) : US28 =
    US28_1(v0)
and method131 () : (std_string_String -> US28) =
    closure56()
and method132 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method76(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "runtime.execute_with_options / output error"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method18(v12)
and closure57 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_4
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method8(v19, v20, v21, v22, v23, v24)
        let v38 : string = method74()
        let v39 : string = method132(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method19(v39)
and closure58 () (v0 : int32) : US29 =
    US29_0(v0)
and method133 () : (int32 -> US29) =
    closure58()
and method134 () : string =
    let v0 : string = "\n"
    v0
and method136 (v0 : int32, v1 : int32) : string =
    let v2 : string = method14()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "exit_code"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure8(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure8(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure8(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure8(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "std_trace_length"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure8(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v3, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : string = $"{v1}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure8(v3, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v73 : string = " }"
    let v74 : string = $"{v73}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure8(v3, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = v3.l0
    v82
and method135 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32) : string =
    let v10 : string = method136(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "runtime.execute_with_options / result"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method18(v13)
and closure59 (v0 : int32, v1 : string) () : unit =
    let v2 : US0 = US0_0
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method8(v20, v21, v22, v23, v24, v25)
        let v39 : string = method120()
        let v40 : int32 = v1.Length
        let v41 : string = method135(v20, v21, v22, v23, v24, v25, v38, v39, v0, v40)
        method19(v41)
and method140 (v0 : string, v1 : US5, v2 : string, v3 : System.Threading.CancellationToken option, v4 : (struct (string * string) []), v5 : (struct (int32 * string * bool) -> Async<unit>) option, v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v7 : bool, v8 : string option) : string =
    let v9 : string = method14()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v11 : string = "{ "
    let v12 : string = $"{v11}"
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure8(v10, v12)
    let v17 : unit = (fun () -> v16 (); v15) ()
    let v20 : string = "file_name"
    let v21 : string = $"{v20}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure8(v10, v21)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v29 : string = " = "
    let v30 : string = $"{v29}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure8(v10, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v38 : string = $"{v0}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure8(v10, v38)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v46 : string = "; "
    let v47 : string = $"{v46}"
    let v50 : unit = ()
    let v51 : (unit -> unit) = closure8(v10, v47)
    let v52 : unit = (fun () -> v51 (); v50) ()
    let v55 : string = "arguments"
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure8(v10, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v64 : string = $"{v29}"
    let v67 : unit = ()
    let v68 : (unit -> unit) = closure8(v10, v64)
    let v69 : unit = (fun () -> v68 (); v67) ()
    let v72 : string = $"%A{v1}"
    let v75 : string = $"{v72}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure8(v10, v75)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v83 : string = $"{v46}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v10, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = "options"
    let v92 : string = $"{v91}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure8(v10, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : string = $"{v29}"
    let v103 : unit = ()
    let v104 : (unit -> unit) = closure8(v10, v100)
    let v105 : unit = (fun () -> v104 (); v103) ()
    let v108 : string = $"{v11}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure8(v10, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = "command"
    let v117 : string = $"{v116}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure8(v10, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v125 : string = $"{v29}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure8(v10, v125)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v133 : string = $"{v2}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure8(v10, v133)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v141 : string = $"{v46}"
    let v144 : unit = ()
    let v145 : (unit -> unit) = closure8(v10, v141)
    let v146 : unit = (fun () -> v145 (); v144) ()
    let v149 : string = "cancellation_token"
    let v150 : string = $"{v149}"
    let v153 : unit = ()
    let v154 : (unit -> unit) = closure8(v10, v150)
    let v155 : unit = (fun () -> v154 (); v153) ()
    let v158 : string = $"{v29}"
    let v161 : unit = ()
    let v162 : (unit -> unit) = closure8(v10, v158)
    let v163 : unit = (fun () -> v162 (); v161) ()
    let v166 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v167 : string = "format!(\"{:#?}\", $0)"
    let v168 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v167 
    let v169 : string = "fable_library_rust::String_::fromString($0)"
    let v170 : string = Fable.Core.RustInterop.emitRustExpr v168 v169 
    let _v166 = v170 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v171 : string = "format!(\"{:#?}\", $0)"
    let v172 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v171 
    let v173 : string = "fable_library_rust::String_::fromString($0)"
    let v174 : string = Fable.Core.RustInterop.emitRustExpr v172 v173 
    let _v166 = v174 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v175 : string = "format!(\"{:#?}\", $0)"
    let v176 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v175 
    let v177 : string = "fable_library_rust::String_::fromString($0)"
    let v178 : string = Fable.Core.RustInterop.emitRustExpr v176 v177 
    let _v166 = v178 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v179 : string = $"%A{v3}"
    let _v166 = v179 
    #endif
#if FABLE_COMPILER_PYTHON
    let v182 : string = $"%A{v3}"
    let _v166 = v182 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v185 : string = $"%A{v3}"
    let _v166 = v185 
    #endif
#else
    let v188 : string = $"%A{v3}"
    let _v166 = v188 
    #endif
    let v191 : string = _v166 
    let v196 : string = $"{v191}"
    let v199 : unit = ()
    let v200 : (unit -> unit) = closure8(v10, v196)
    let v201 : unit = (fun () -> v200 (); v199) ()
    let v204 : string = $"{v46}"
    let v207 : unit = ()
    let v208 : (unit -> unit) = closure8(v10, v204)
    let v209 : unit = (fun () -> v208 (); v207) ()
    let v212 : string = "environment_variables"
    let v213 : string = $"{v212}"
    let v216 : unit = ()
    let v217 : (unit -> unit) = closure8(v10, v213)
    let v218 : unit = (fun () -> v217 (); v216) ()
    let v221 : string = $"{v29}"
    let v224 : unit = ()
    let v225 : (unit -> unit) = closure8(v10, v221)
    let v226 : unit = (fun () -> v225 (); v224) ()
    let v229 : string = $"%A{v4}"
    let v232 : string = $"{v229}"
    let v235 : unit = ()
    let v236 : (unit -> unit) = closure8(v10, v232)
    let v237 : unit = (fun () -> v236 (); v235) ()
    let v240 : string = $"{v46}"
    let v243 : unit = ()
    let v244 : (unit -> unit) = closure8(v10, v240)
    let v245 : unit = (fun () -> v244 (); v243) ()
    let v248 : string = "on_line"
    let v249 : string = $"{v248}"
    let v252 : unit = ()
    let v253 : (unit -> unit) = closure8(v10, v249)
    let v254 : unit = (fun () -> v253 (); v252) ()
    let v257 : string = $"{v29}"
    let v260 : unit = ()
    let v261 : (unit -> unit) = closure8(v10, v257)
    let v262 : unit = (fun () -> v261 (); v260) ()
    let v265 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v266 : string = "format!(\"{:#?}\", $0)"
    let v267 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v266 
    let v268 : string = "fable_library_rust::String_::fromString($0)"
    let v269 : string = Fable.Core.RustInterop.emitRustExpr v267 v268 
    let _v265 = v269 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v270 : string = "format!(\"{:#?}\", $0)"
    let v271 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v270 
    let v272 : string = "fable_library_rust::String_::fromString($0)"
    let v273 : string = Fable.Core.RustInterop.emitRustExpr v271 v272 
    let _v265 = v273 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v274 : string = "format!(\"{:#?}\", $0)"
    let v275 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v274 
    let v276 : string = "fable_library_rust::String_::fromString($0)"
    let v277 : string = Fable.Core.RustInterop.emitRustExpr v275 v276 
    let _v265 = v277 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v278 : string = $"%A{v5}"
    let _v265 = v278 
    #endif
#if FABLE_COMPILER_PYTHON
    let v281 : string = $"%A{v5}"
    let _v265 = v281 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v284 : string = $"%A{v5}"
    let _v265 = v284 
    #endif
#else
    let v287 : string = $"%A{v5}"
    let _v265 = v287 
    #endif
    let v290 : string = _v265 
    let v295 : string = $"{v290}"
    let v298 : unit = ()
    let v299 : (unit -> unit) = closure8(v10, v295)
    let v300 : unit = (fun () -> v299 (); v298) ()
    let v303 : string = $"{v46}"
    let v306 : unit = ()
    let v307 : (unit -> unit) = closure8(v10, v303)
    let v308 : unit = (fun () -> v307 (); v306) ()
    let v311 : string = "stdin"
    let v312 : string = $"{v311}"
    let v315 : unit = ()
    let v316 : (unit -> unit) = closure8(v10, v312)
    let v317 : unit = (fun () -> v316 (); v315) ()
    let v320 : string = $"{v29}"
    let v323 : unit = ()
    let v324 : (unit -> unit) = closure8(v10, v320)
    let v325 : unit = (fun () -> v324 (); v323) ()
    let v328 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v329 : string = "format!(\"{:#?}\", $0)"
    let v330 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v329 
    let v331 : string = "fable_library_rust::String_::fromString($0)"
    let v332 : string = Fable.Core.RustInterop.emitRustExpr v330 v331 
    let _v328 = v332 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v333 : string = "format!(\"{:#?}\", $0)"
    let v334 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v333 
    let v335 : string = "fable_library_rust::String_::fromString($0)"
    let v336 : string = Fable.Core.RustInterop.emitRustExpr v334 v335 
    let _v328 = v336 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v337 : string = "format!(\"{:#?}\", $0)"
    let v338 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v337 
    let v339 : string = "fable_library_rust::String_::fromString($0)"
    let v340 : string = Fable.Core.RustInterop.emitRustExpr v338 v339 
    let _v328 = v340 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v341 : string = $"%A{v6}"
    let _v328 = v341 
    #endif
#if FABLE_COMPILER_PYTHON
    let v344 : string = $"%A{v6}"
    let _v328 = v344 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v347 : string = $"%A{v6}"
    let _v328 = v347 
    #endif
#else
    let v350 : string = $"%A{v6}"
    let _v328 = v350 
    #endif
    let v353 : string = _v328 
    let v358 : string = $"{v353}"
    let v361 : unit = ()
    let v362 : (unit -> unit) = closure8(v10, v358)
    let v363 : unit = (fun () -> v362 (); v361) ()
    let v366 : string = $"{v46}"
    let v369 : unit = ()
    let v370 : (unit -> unit) = closure8(v10, v366)
    let v371 : unit = (fun () -> v370 (); v369) ()
    let v374 : string = "trace"
    let v375 : string = $"{v374}"
    let v378 : unit = ()
    let v379 : (unit -> unit) = closure8(v10, v375)
    let v380 : unit = (fun () -> v379 (); v378) ()
    let v383 : string = $"{v29}"
    let v386 : unit = ()
    let v387 : (unit -> unit) = closure8(v10, v383)
    let v388 : unit = (fun () -> v387 (); v386) ()
    let v393 : string =
        if v7 then
            let v391 : string = "true"
            v391
        else
            let v392 : string = "false"
            v392
    let v394 : string = $"{v393}"
    let v397 : unit = ()
    let v398 : (unit -> unit) = closure8(v10, v394)
    let v399 : unit = (fun () -> v398 (); v397) ()
    let v402 : string = $"{v46}"
    let v405 : unit = ()
    let v406 : (unit -> unit) = closure8(v10, v402)
    let v407 : unit = (fun () -> v406 (); v405) ()
    let v410 : string = "working_directory"
    let v411 : string = $"{v410}"
    let v414 : unit = ()
    let v415 : (unit -> unit) = closure8(v10, v411)
    let v416 : unit = (fun () -> v415 (); v414) ()
    let v419 : string = $"{v29}"
    let v422 : unit = ()
    let v423 : (unit -> unit) = closure8(v10, v419)
    let v424 : unit = (fun () -> v423 (); v422) ()
    let v427 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v428 : string = "format!(\"{:#?}\", $0)"
    let v429 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v428 
    let v430 : string = "fable_library_rust::String_::fromString($0)"
    let v431 : string = Fable.Core.RustInterop.emitRustExpr v429 v430 
    let _v427 = v431 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v432 : string = "format!(\"{:#?}\", $0)"
    let v433 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v432 
    let v434 : string = "fable_library_rust::String_::fromString($0)"
    let v435 : string = Fable.Core.RustInterop.emitRustExpr v433 v434 
    let _v427 = v435 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v436 : string = "format!(\"{:#?}\", $0)"
    let v437 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v436 
    let v438 : string = "fable_library_rust::String_::fromString($0)"
    let v439 : string = Fable.Core.RustInterop.emitRustExpr v437 v438 
    let _v427 = v439 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v440 : string = $"%A{v8}"
    let _v427 = v440 
    #endif
#if FABLE_COMPILER_PYTHON
    let v443 : string = $"%A{v8}"
    let _v427 = v443 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v446 : string = $"%A{v8}"
    let _v427 = v446 
    #endif
#else
    let v449 : string = $"%A{v8}"
    let _v427 = v449 
    #endif
    let v452 : string = _v427 
    let v457 : string = $"{v452}"
    let v460 : unit = ()
    let v461 : (unit -> unit) = closure8(v10, v457)
    let v462 : unit = (fun () -> v461 (); v460) ()
    let v465 : string = " }"
    let v466 : string = $"{v465}"
    let v469 : unit = ()
    let v470 : (unit -> unit) = closure8(v10, v466)
    let v471 : unit = (fun () -> v470 (); v469) ()
    let v474 : string = $"{v465}"
    let v477 : unit = ()
    let v478 : (unit -> unit) = closure8(v10, v474)
    let v479 : unit = (fun () -> v478 (); v477) ()
    let v482 : string = v10.l0
    v482
and method139 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : US5, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option) : string =
    let v17 : string = method140(v8, v9, v10, v11, v12, v13, v14, v15, v16)
    let v18 : int64 = v0.l0
    let v19 : string = "runtime.execute_with_options_async"
    let v20 : string = $"{v6} {v7} #{v18} %s{v19} / {v17}"
    method18(v20)
and closure60 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : US5, v8 : string) () : unit =
    let v9 : US0 = US0_1
    let v10 : bool = method7(v9)
    if v10 then
        let v11 : unit = ()
        let v12 : (unit -> unit) = closure6()
        let v13 : unit = (fun () -> v12 (); v11) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method8(v27, v28, v29, v30, v31, v32)
        let v46 : string = method62()
        let v47 : string = method139(v27, v28, v29, v30, v31, v32, v45, v46, v8, v7, v0, v1, v2, v3, v4, v5, v6)
        method19(v47)
and method141 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : (struct (string * string) []) =
    v2
and method144 (v0 : System.Diagnostics.DataReceivedEventArgs) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = null |> unbox<string>
    let _v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = null |> unbox<string>
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = null |> unbox<string>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : string = null |> unbox<string>
    let _v1 = v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : string = null |> unbox<string>
    let _v1 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : string = null |> unbox<string>
    let _v1 = v17 
    #endif
#else
    let v20 : (System.Diagnostics.DataReceivedEventArgs -> string) = _.Data
    let v21 : string = v20 v0
    let _v1 = v21 
    #endif
    let v22 : string = _v1 
    v22
and closure62 () (v0 : (struct (int32 * string * bool) -> Async<unit>)) : US30 =
    US30_0(v0)
and method145 () : ((struct (int32 * string * bool) -> Async<unit>) -> US30) =
    closure62()
and method146 (v0 : System.Diagnostics.Process) : int32 =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : int32 = null |> unbox<int32>
    let _v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : int32 = null |> unbox<int32>
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : int32 = null |> unbox<int32>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : int32 = null |> unbox<int32>
    let _v1 = v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : int32 = null |> unbox<int32>
    let _v1 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : int32 = null |> unbox<int32>
    let _v1 = v17 
    #endif
#else
    let v20 : (System.Diagnostics.Process -> int32) = _.Id
    let v21 : int32 = v20 v0
    let _v1 = v21 
    #endif
    let v22 : int32 = _v1 
    v22
and closure63 (v0 : string) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method8(v19, v20, v21, v22, v23, v24)
        let v38 : string = method120()
        let v39 : bool = v0 = ""
        let v42 : string =
            if v39 then
                let v40 : string = ""
                v40
            else
                method121(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method19(v42)
and method143 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>, v9 : bool, v10 : System.Diagnostics.DataReceivedEventArgs) : Async<unit> =
    let v11 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : Async<unit> = null |> unbox<Async<unit>>
    let _v11 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : Async<unit> = null |> unbox<Async<unit>>
    let _v11 = v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v18 : Async<unit> = null |> unbox<Async<unit>>
    let _v11 = v18 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : unit = ()
    let _v21 =
        async {
            let v24 : string = method144(v10)
            let v25 : string = null |> unbox<string>
            let v28 : bool = v24 = v25
            let v29 : bool = v28 <> true
            if v29 then
                let v30 : ((struct (int32 * string * bool) -> Async<unit>) -> US30) = method145()
                let v31 : US30 option = v3 |> Option.map v30 
                let v42 : US30 = US30_1
                let v43 : US30 = v31 |> Option.defaultValue v42 
                match v43 with
                | US30_1 -> (* None *)
                    ()
                | US30_0(v47) -> (* Some *)
                    let v48 : int32 = method146(v7)
                    let v49 : Async<unit> = v47 struct (v48, v24, v9)
                    do! v49 
                    ()
                let v52 : string =
                    if v9 then
                        let v50 : string = $"! {v24}"
                        v50
                    else
                        let v51 : string = $"> {v24}"
                        v51
                if v5 then
                    let v53 : unit = ()
                    let v54 : (unit -> unit) = closure63(v52)
                    let v55 : unit = (fun () -> v54 (); v53) ()
                    ()
                else
                    let v98 : unit = ()
                    let v99 : (unit -> unit) = closure11(v52)
                    let v100 : unit = (fun () -> v99 (); v98) ()
                    ()
                let v104 : string =
                    if v9 then
                        let v102 : string = "\u001b[7;4m"
                        v102
                    else
                        let v103 : string = ""
                        v103
                let v107 : string =
                    if v9 then
                        let v105 : string = "\u001b[0m"
                        v105
                    else
                        let v106 : string = ""
                        v106
                let v108 : string = $"{v104}{v24}{v107}"
                let v109 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v110 : (string -> unit) = v8.Push
                v110 v108
                #endif
                // run_target_args' is_unit
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v720 : Async<unit> = _v21 
    let _v11 = v720 
    #endif
#if FABLE_COMPILER_PYTHON
    let v721 : unit = ()
    let _v721 =
        async {
            let v724 : string = method144(v10)
            let v725 : string = null |> unbox<string>
            let v728 : bool = v724 = v725
            let v729 : bool = v728 <> true
            if v729 then
                let v730 : ((struct (int32 * string * bool) -> Async<unit>) -> US30) = method145()
                let v731 : US30 option = v3 |> Option.map v730 
                let v742 : US30 = US30_1
                let v743 : US30 = v731 |> Option.defaultValue v742 
                match v743 with
                | US30_1 -> (* None *)
                    ()
                | US30_0(v747) -> (* Some *)
                    let v748 : int32 = method146(v7)
                    let v749 : Async<unit> = v747 struct (v748, v724, v9)
                    do! v749 
                    ()
                let v752 : string =
                    if v9 then
                        let v750 : string = $"! {v724}"
                        v750
                    else
                        let v751 : string = $"> {v724}"
                        v751
                if v5 then
                    let v753 : unit = ()
                    let v754 : (unit -> unit) = closure63(v752)
                    let v755 : unit = (fun () -> v754 (); v753) ()
                    ()
                else
                    let v798 : unit = ()
                    let v799 : (unit -> unit) = closure11(v752)
                    let v800 : unit = (fun () -> v799 (); v798) ()
                    ()
                let v804 : string =
                    if v9 then
                        let v802 : string = "\u001b[7;4m"
                        v802
                    else
                        let v803 : string = ""
                        v803
                let v807 : string =
                    if v9 then
                        let v805 : string = "\u001b[0m"
                        v805
                    else
                        let v806 : string = ""
                        v806
                let v808 : string = $"{v804}{v724}{v807}"
                let v809 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v810 : (string -> unit) = v8.Push
                v810 v808
                #endif
                // run_target_args' is_unit
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1420 : Async<unit> = _v721 
    let _v11 = v1420 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1421 : unit = ()
    let _v1421 =
        async {
            let v1424 : string = method144(v10)
            let v1425 : string = null |> unbox<string>
            let v1428 : bool = v1424 = v1425
            let v1429 : bool = v1428 <> true
            if v1429 then
                let v1430 : ((struct (int32 * string * bool) -> Async<unit>) -> US30) = method145()
                let v1431 : US30 option = v3 |> Option.map v1430 
                let v1442 : US30 = US30_1
                let v1443 : US30 = v1431 |> Option.defaultValue v1442 
                match v1443 with
                | US30_1 -> (* None *)
                    ()
                | US30_0(v1447) -> (* Some *)
                    let v1448 : int32 = method146(v7)
                    let v1449 : Async<unit> = v1447 struct (v1448, v1424, v9)
                    do! v1449 
                    ()
                let v1452 : string =
                    if v9 then
                        let v1450 : string = $"! {v1424}"
                        v1450
                    else
                        let v1451 : string = $"> {v1424}"
                        v1451
                if v5 then
                    let v1453 : unit = ()
                    let v1454 : (unit -> unit) = closure63(v1452)
                    let v1455 : unit = (fun () -> v1454 (); v1453) ()
                    ()
                else
                    let v1498 : unit = ()
                    let v1499 : (unit -> unit) = closure11(v1452)
                    let v1500 : unit = (fun () -> v1499 (); v1498) ()
                    ()
                let v1504 : string =
                    if v9 then
                        let v1502 : string = "\u001b[7;4m"
                        v1502
                    else
                        let v1503 : string = ""
                        v1503
                let v1507 : string =
                    if v9 then
                        let v1505 : string = "\u001b[0m"
                        v1505
                    else
                        let v1506 : string = ""
                        v1506
                let v1508 : string = $"{v1504}{v1424}{v1507}"
                let v1509 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v1510 : (string -> unit) = v8.Push
                v1510 v1508
                #endif
                // run_target_args' is_unit
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2120 : Async<unit> = _v1421 
    let _v11 = v2120 
    #endif
#else
    let v2121 : unit = ()
    let _v2121 =
        async {
            let v2124 : string = method144(v10)
            let v2125 : string = null |> unbox<string>
            let v2128 : bool = v2124 = v2125
            let v2129 : bool = v2128 <> true
            if v2129 then
                let v2130 : ((struct (int32 * string * bool) -> Async<unit>) -> US30) = method145()
                let v2131 : US30 option = v3 |> Option.map v2130 
                let v2142 : US30 = US30_1
                let v2143 : US30 = v2131 |> Option.defaultValue v2142 
                match v2143 with
                | US30_1 -> (* None *)
                    ()
                | US30_0(v2147) -> (* Some *)
                    let v2148 : int32 = method146(v7)
                    let v2149 : Async<unit> = v2147 struct (v2148, v2124, v9)
                    do! v2149 
                    ()
                let v2152 : string =
                    if v9 then
                        let v2150 : string = $"! {v2124}"
                        v2150
                    else
                        let v2151 : string = $"> {v2124}"
                        v2151
                if v5 then
                    let v2153 : unit = ()
                    let v2154 : (unit -> unit) = closure63(v2152)
                    let v2155 : unit = (fun () -> v2154 (); v2153) ()
                    ()
                else
                    let v2198 : unit = ()
                    let v2199 : (unit -> unit) = closure11(v2152)
                    let v2200 : unit = (fun () -> v2199 (); v2198) ()
                    ()
                let v2204 : string =
                    if v9 then
                        let v2202 : string = "\u001b[7;4m"
                        v2202
                    else
                        let v2203 : string = ""
                        v2203
                let v2207 : string =
                    if v9 then
                        let v2205 : string = "\u001b[0m"
                        v2205
                    else
                        let v2206 : string = ""
                        v2206
                let v2208 : string = $"{v2204}{v2124}{v2207}"
                let v2209 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v2210 : (string -> unit) = v8.Push
                v2210 v2208
                #endif
                // run_target_args' is_unit
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2820 : Async<unit> = _v2121 
    let _v11 = v2820 
    #endif
    let v2821 : Async<unit> = _v11 
    v2821
and method142 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>, v9 : bool, v10 : System.Diagnostics.DataReceivedEventArgs) : Async<unit> =
    method143(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
and closure61 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>, v9 : bool) (v10 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v11 : Async<unit> = method142(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
    let v12 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : (Async<unit> -> unit) = Async.StartImmediate
    v13 v11
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : (Async<unit> -> unit) = Async.StartImmediate
    v14 v11
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : (Async<unit> -> unit) = Async.StartImmediate
    v15 v11
    #endif
#else
    let v16 : (Async<unit> -> unit) = Async.StartImmediate
    v16 v11
    #endif
    // run_target_args' is_unit
    ()
and closure64 () (v0 : System.Threading.CancellationToken) : US31 =
    US31_0(v0)
and method147 () : (System.Threading.CancellationToken -> US31) =
    closure64()
and method148 (v0 : System.Threading.CancellationToken) : Async<System.Threading.CancellationToken> =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : unit = ()
    let _v11 =
        async {
            let v14 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v15 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v18 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v21 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v21 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v24 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v24 
            #endif
#if FABLE_COMPILER_PYTHON
            let v27 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v27 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v30 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v30 
            #endif
#else
            let v33 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v33 = v33 
            let v34 : System.Threading.CancellationToken = v33 
            let v35 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v36 : (System.Threading.CancellationToken []) = [|v34; v35; v0|]
            let v37 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v38 : System.Threading.CancellationTokenSource = v37 v36
            let v39 : System.Threading.CancellationToken = v38.Token
            return v39 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v246 : Async<System.Threading.CancellationToken> = _v11 
    let _v1 = v246 
    #endif
#if FABLE_COMPILER_PYTHON
    let v247 : unit = ()
    let _v247 =
        async {
            let v250 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v251 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v251 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v254 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v254 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v257 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v257 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v260 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v260 
            #endif
#if FABLE_COMPILER_PYTHON
            let v263 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v263 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v266 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v266 
            #endif
#else
            let v269 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v269 = v269 
            let v270 : System.Threading.CancellationToken = v269 
            let v271 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v272 : (System.Threading.CancellationToken []) = [|v270; v271; v0|]
            let v273 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v274 : System.Threading.CancellationTokenSource = v273 v272
            let v275 : System.Threading.CancellationToken = v274.Token
            return v275 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v482 : Async<System.Threading.CancellationToken> = _v247 
    let _v1 = v482 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v483 : unit = ()
    let _v483 =
        async {
            let v486 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v487 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v487 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v490 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v490 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v493 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v493 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v496 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v496 
            #endif
#if FABLE_COMPILER_PYTHON
            let v499 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v499 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v502 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v502 
            #endif
#else
            let v505 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v505 = v505 
            let v506 : System.Threading.CancellationToken = v505 
            let v507 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v508 : (System.Threading.CancellationToken []) = [|v506; v507; v0|]
            let v509 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v510 : System.Threading.CancellationTokenSource = v509 v508
            let v511 : System.Threading.CancellationToken = v510.Token
            return v511 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v718 : Async<System.Threading.CancellationToken> = _v483 
    let _v1 = v718 
    #endif
#else
    let v719 : unit = ()
    let _v719 =
        async {
            let v722 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v723 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v723 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v726 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v726 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v729 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v729 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v732 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v732 
            #endif
#if FABLE_COMPILER_PYTHON
            let v735 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v735 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v738 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v738 
            #endif
#else
            let v741 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v741 = v741 
            let v742 : System.Threading.CancellationToken = v741 
            let v743 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v744 : (System.Threading.CancellationToken []) = [|v742; v743; v0|]
            let v745 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v746 : System.Threading.CancellationTokenSource = v745 v744
            let v747 : System.Threading.CancellationToken = v746.Token
            return v747 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v954 : Async<System.Threading.CancellationToken> = _v719 
    let _v1 = v954 
    #endif
    let v955 : Async<System.Threading.CancellationToken> = _v1 
    v955
and method149 (v0 : System.Diagnostics.Process) : bool =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : bool = null |> unbox<bool>
    let _v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : bool = null |> unbox<bool>
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : bool = null |> unbox<bool>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : bool = null |> unbox<bool>
    let _v1 = v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : bool = null |> unbox<bool>
    let _v1 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : bool = null |> unbox<bool>
    let _v1 = v17 
    #endif
#else
    let v20 : (System.Diagnostics.Process -> bool) = _.HasExited
    let v21 : bool = v20 v0
    let _v1 = v21 
    #endif
    let v22 : bool = _v1 
    v22
and method150 (v0 : System.Diagnostics.Process) : unit =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    #endif
#if FABLE_COMPILER_RUST && WASM
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    #endif
#if FABLE_COMPILER_PYTHON
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    #endif
#else
    let v2 : (System.Diagnostics.Process -> unit) = _.Kill()
    v2 v0
    #endif
    // run_target_args' is_unit
    ()
and closure65 (v0 : System.Diagnostics.Process) () : unit =
    let v1 : bool = method149(v0)
    let v2 : bool = v1 = false
    if v2 then
        method150(v0)
and closure66 (v0 : exn) () : exn =
    v0
and method153 (v0 : System.Threading.Tasks.TaskCanceledException) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure8(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "ex"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure8(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure8(v2, v22)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "format!(\"{:#?}\", $0)"
    let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v31 
    let v33 : string = "fable_library_rust::String_::fromString($0)"
    let v34 : string = Fable.Core.RustInterop.emitRustExpr v32 v33 
    let _v30 = v34 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v35 : string = "format!(\"{:#?}\", $0)"
    let v36 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v35 
    let v37 : string = "fable_library_rust::String_::fromString($0)"
    let v38 : string = Fable.Core.RustInterop.emitRustExpr v36 v37 
    let _v30 = v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : string = "format!(\"{:#?}\", $0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v39 
    let v41 : string = "fable_library_rust::String_::fromString($0)"
    let v42 : string = Fable.Core.RustInterop.emitRustExpr v40 v41 
    let _v30 = v42 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v43 : string = $"%A{v0}"
    let _v30 = v43 
    #endif
#if FABLE_COMPILER_PYTHON
    let v46 : string = $"%A{v0}"
    let _v30 = v46 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v49 : string = $"%A{v0}"
    let _v30 = v49 
    #endif
#else
    let v52 : string = $"%A{v0}"
    let _v30 = v52 
    #endif
    let v55 : string = _v30 
    let v60 : string = $"{v55}"
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure8(v2, v60)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v68 : string = " }"
    let v69 : string = $"{v68}"
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure8(v2, v69)
    let v74 : unit = (fun () -> v73 (); v72) ()
    let v77 : string = v2.l0
    v77
and method152 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : System.Threading.Tasks.TaskCanceledException) : string =
    let v9 : string = method153(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "runtime.execute_with_options_async / WaitForExitAsync"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method18(v12)
and closure67 (v0 : System.Threading.Tasks.TaskCanceledException) () : unit =
    let v1 : US0 = US0_3
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method8(v19, v20, v21, v22, v23, v24)
        let v38 : string = method31()
        let v39 : string = method152(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method19(v39)
and method151 (v0 : System.Diagnostics.Process, v1 : System.Collections.Concurrent.ConcurrentStack<string>, v2 : System.Threading.CancellationToken) : Async<int32> =
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : Async<int32> = null |> unbox<Async<int32>>
    let _v3 = v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v7 : Async<int32> = null |> unbox<Async<int32>>
    let _v3 = v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : Async<int32> = null |> unbox<Async<int32>>
    let _v3 = v10 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : unit = ()
    let _v13 =
        async {
            try
                let v16 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v17 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v16 = v17 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v20 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v16 = v20 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v23 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v16 = v23 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v26 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v16 = v26 
                #endif
#if FABLE_COMPILER_PYTHON
                let v29 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v16 = v29 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v32 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v16 = v32 
                #endif
#else
                let v35 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _v16 = v35 
                #endif
                let v36 : System.Threading.Tasks.Task = _v16 
                let v41 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v42 : Async<unit> = null |> unbox<Async<unit>>
                let _v41 = v42 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v45 : Async<unit> = null |> unbox<Async<unit>>
                let _v41 = v45 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v48 : Async<unit> = null |> unbox<Async<unit>>
                let _v41 = v48 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v51 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v52 : Async<unit> = v51 v36
                let _v41 = v52 
                #endif
#if FABLE_COMPILER_PYTHON
                let v53 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v54 : Async<unit> = v53 v36
                let _v41 = v54 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v55 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v56 : Async<unit> = v55 v36
                let _v41 = v56 
                #endif
#else
                let v57 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v58 : Async<unit> = v57 v36
                let _v41 = v58 
                #endif
                let v59 : Async<unit> = _v41 
                do! v59 
                let v64 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v65 : int32 = null |> unbox<int32>
                let _v64 = v65 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v68 : int32 = null |> unbox<int32>
                let _v64 = v68 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v71 : int32 = null |> unbox<int32>
                let _v64 = v71 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v74 : int32 = null |> unbox<int32>
                let _v64 = v74 
                #endif
#if FABLE_COMPILER_PYTHON
                let v77 : int32 = null |> unbox<int32>
                let _v64 = v77 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v80 : int32 = null |> unbox<int32>
                let _v64 = v80 
                #endif
#else
                let v83 : int32 = v0.ExitCode
                let _v64 = v83 
                #endif
                let v84 : int32 = _v64 
                return v84 
                (* indent
                ()
            indent *)
            with ex ->
                let v162 : exn = ex
                let v163 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v164 : string = $"%A{v162}"
                let _v163 = v164 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v167 : string = $"%A{v162}"
                let _v163 = v167 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v170 : string = $"%A{v162}"
                let _v163 = v170 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v173 : string = $"%A{v162}"
                let _v163 = v173 
                #endif
#if FABLE_COMPILER_PYTHON
                let v176 : string = $"%A{v162}"
                let _v163 = v176 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v179 : string = $"%A{v162}"
                let _v163 = v179 
                #endif
#else
                let v182 : string = $"{v162.GetType ()}: {v162.Message}"
                let _v163 = v182 
                #endif
                let v183 : string = _v163 
                let v188 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v189 : (string -> unit) = v1.Push
                v189 v183
                #endif
                // run_target_args' is_unit
                let v190 : (unit -> exn) = closure66(v162)
                let v191 : System.Threading.Tasks.TaskCanceledException = v190 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v194 : unit = ()
                let v195 : (unit -> unit) = closure67(v191)
                let v196 : unit = (fun () -> v195 (); v194) ()
                return -2147483648 
                (* indent
                ()
            indent *)
            (* try_unit
            try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2368 : Async<int32> = _v13 
    let _v3 = v2368 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2369 : unit = ()
    let _v2369 =
        async {
            try
                let v2372 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v2373 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v2372 = v2373 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v2376 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v2372 = v2376 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v2379 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v2372 = v2379 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v2382 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v2372 = v2382 
                #endif
#if FABLE_COMPILER_PYTHON
                let v2385 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v2372 = v2385 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v2388 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v2372 = v2388 
                #endif
#else
                let v2391 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _v2372 = v2391 
                #endif
                let v2392 : System.Threading.Tasks.Task = _v2372 
                let v2397 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v2398 : Async<unit> = null |> unbox<Async<unit>>
                let _v2397 = v2398 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v2401 : Async<unit> = null |> unbox<Async<unit>>
                let _v2397 = v2401 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v2404 : Async<unit> = null |> unbox<Async<unit>>
                let _v2397 = v2404 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v2407 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v2408 : Async<unit> = v2407 v2392
                let _v2397 = v2408 
                #endif
#if FABLE_COMPILER_PYTHON
                let v2409 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v2410 : Async<unit> = v2409 v2392
                let _v2397 = v2410 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v2411 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v2412 : Async<unit> = v2411 v2392
                let _v2397 = v2412 
                #endif
#else
                let v2413 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v2414 : Async<unit> = v2413 v2392
                let _v2397 = v2414 
                #endif
                let v2415 : Async<unit> = _v2397 
                do! v2415 
                let v2420 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v2421 : int32 = null |> unbox<int32>
                let _v2420 = v2421 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v2424 : int32 = null |> unbox<int32>
                let _v2420 = v2424 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v2427 : int32 = null |> unbox<int32>
                let _v2420 = v2427 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v2430 : int32 = null |> unbox<int32>
                let _v2420 = v2430 
                #endif
#if FABLE_COMPILER_PYTHON
                let v2433 : int32 = null |> unbox<int32>
                let _v2420 = v2433 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v2436 : int32 = null |> unbox<int32>
                let _v2420 = v2436 
                #endif
#else
                let v2439 : int32 = v0.ExitCode
                let _v2420 = v2439 
                #endif
                let v2440 : int32 = _v2420 
                return v2440 
                (* indent
                ()
            indent *)
            with ex ->
                let v2518 : exn = ex
                let v2519 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v2520 : string = $"%A{v2518}"
                let _v2519 = v2520 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v2523 : string = $"%A{v2518}"
                let _v2519 = v2523 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v2526 : string = $"%A{v2518}"
                let _v2519 = v2526 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v2529 : string = $"%A{v2518}"
                let _v2519 = v2529 
                #endif
#if FABLE_COMPILER_PYTHON
                let v2532 : string = $"%A{v2518}"
                let _v2519 = v2532 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v2535 : string = $"%A{v2518}"
                let _v2519 = v2535 
                #endif
#else
                let v2538 : string = $"{v2518.GetType ()}: {v2518.Message}"
                let _v2519 = v2538 
                #endif
                let v2539 : string = _v2519 
                let v2544 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v2545 : (string -> unit) = v1.Push
                v2545 v2539
                #endif
                // run_target_args' is_unit
                let v2546 : (unit -> exn) = closure66(v2518)
                let v2547 : System.Threading.Tasks.TaskCanceledException = v2546 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v2550 : unit = ()
                let v2551 : (unit -> unit) = closure67(v2547)
                let v2552 : unit = (fun () -> v2551 (); v2550) ()
                return -2147483648 
                (* indent
                ()
            indent *)
            (* try_unit
            try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v4724 : Async<int32> = _v2369 
    let _v3 = v4724 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v4725 : unit = ()
    let _v4725 =
        async {
            try
                let v4728 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v4729 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v4728 = v4729 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v4732 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v4728 = v4732 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v4735 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v4728 = v4735 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v4738 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v4728 = v4738 
                #endif
#if FABLE_COMPILER_PYTHON
                let v4741 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v4728 = v4741 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v4744 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v4728 = v4744 
                #endif
#else
                let v4747 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _v4728 = v4747 
                #endif
                let v4748 : System.Threading.Tasks.Task = _v4728 
                let v4753 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v4754 : Async<unit> = null |> unbox<Async<unit>>
                let _v4753 = v4754 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v4757 : Async<unit> = null |> unbox<Async<unit>>
                let _v4753 = v4757 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v4760 : Async<unit> = null |> unbox<Async<unit>>
                let _v4753 = v4760 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v4763 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v4764 : Async<unit> = v4763 v4748
                let _v4753 = v4764 
                #endif
#if FABLE_COMPILER_PYTHON
                let v4765 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v4766 : Async<unit> = v4765 v4748
                let _v4753 = v4766 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v4767 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v4768 : Async<unit> = v4767 v4748
                let _v4753 = v4768 
                #endif
#else
                let v4769 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v4770 : Async<unit> = v4769 v4748
                let _v4753 = v4770 
                #endif
                let v4771 : Async<unit> = _v4753 
                do! v4771 
                let v4776 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v4777 : int32 = null |> unbox<int32>
                let _v4776 = v4777 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v4780 : int32 = null |> unbox<int32>
                let _v4776 = v4780 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v4783 : int32 = null |> unbox<int32>
                let _v4776 = v4783 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v4786 : int32 = null |> unbox<int32>
                let _v4776 = v4786 
                #endif
#if FABLE_COMPILER_PYTHON
                let v4789 : int32 = null |> unbox<int32>
                let _v4776 = v4789 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v4792 : int32 = null |> unbox<int32>
                let _v4776 = v4792 
                #endif
#else
                let v4795 : int32 = v0.ExitCode
                let _v4776 = v4795 
                #endif
                let v4796 : int32 = _v4776 
                return v4796 
                (* indent
                ()
            indent *)
            with ex ->
                let v4874 : exn = ex
                let v4875 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v4876 : string = $"%A{v4874}"
                let _v4875 = v4876 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v4879 : string = $"%A{v4874}"
                let _v4875 = v4879 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v4882 : string = $"%A{v4874}"
                let _v4875 = v4882 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v4885 : string = $"%A{v4874}"
                let _v4875 = v4885 
                #endif
#if FABLE_COMPILER_PYTHON
                let v4888 : string = $"%A{v4874}"
                let _v4875 = v4888 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v4891 : string = $"%A{v4874}"
                let _v4875 = v4891 
                #endif
#else
                let v4894 : string = $"{v4874.GetType ()}: {v4874.Message}"
                let _v4875 = v4894 
                #endif
                let v4895 : string = _v4875 
                let v4900 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v4901 : (string -> unit) = v1.Push
                v4901 v4895
                #endif
                // run_target_args' is_unit
                let v4902 : (unit -> exn) = closure66(v4874)
                let v4903 : System.Threading.Tasks.TaskCanceledException = v4902 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v4906 : unit = ()
                let v4907 : (unit -> unit) = closure67(v4903)
                let v4908 : unit = (fun () -> v4907 (); v4906) ()
                return -2147483648 
                (* indent
                ()
            indent *)
            (* try_unit
            try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v7080 : Async<int32> = _v4725 
    let _v3 = v7080 
    #endif
#else
    let v7081 : unit = ()
    let _v7081 =
        async {
            try
                let v7084 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v7085 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v7084 = v7085 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v7088 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v7084 = v7088 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v7091 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v7084 = v7091 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v7094 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v7084 = v7094 
                #endif
#if FABLE_COMPILER_PYTHON
                let v7097 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v7084 = v7097 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v7100 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _v7084 = v7100 
                #endif
#else
                let v7103 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _v7084 = v7103 
                #endif
                let v7104 : System.Threading.Tasks.Task = _v7084 
                let v7109 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v7110 : Async<unit> = null |> unbox<Async<unit>>
                let _v7109 = v7110 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v7113 : Async<unit> = null |> unbox<Async<unit>>
                let _v7109 = v7113 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v7116 : Async<unit> = null |> unbox<Async<unit>>
                let _v7109 = v7116 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v7119 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v7120 : Async<unit> = v7119 v7104
                let _v7109 = v7120 
                #endif
#if FABLE_COMPILER_PYTHON
                let v7121 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v7122 : Async<unit> = v7121 v7104
                let _v7109 = v7122 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v7123 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v7124 : Async<unit> = v7123 v7104
                let _v7109 = v7124 
                #endif
#else
                let v7125 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v7126 : Async<unit> = v7125 v7104
                let _v7109 = v7126 
                #endif
                let v7127 : Async<unit> = _v7109 
                do! v7127 
                let v7132 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v7133 : int32 = null |> unbox<int32>
                let _v7132 = v7133 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v7136 : int32 = null |> unbox<int32>
                let _v7132 = v7136 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v7139 : int32 = null |> unbox<int32>
                let _v7132 = v7139 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v7142 : int32 = null |> unbox<int32>
                let _v7132 = v7142 
                #endif
#if FABLE_COMPILER_PYTHON
                let v7145 : int32 = null |> unbox<int32>
                let _v7132 = v7145 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v7148 : int32 = null |> unbox<int32>
                let _v7132 = v7148 
                #endif
#else
                let v7151 : int32 = v0.ExitCode
                let _v7132 = v7151 
                #endif
                let v7152 : int32 = _v7132 
                return v7152 
                (* indent
                ()
            indent *)
            with ex ->
                let v7230 : exn = ex
                let v7231 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v7232 : string = $"%A{v7230}"
                let _v7231 = v7232 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v7235 : string = $"%A{v7230}"
                let _v7231 = v7235 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v7238 : string = $"%A{v7230}"
                let _v7231 = v7238 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v7241 : string = $"%A{v7230}"
                let _v7231 = v7241 
                #endif
#if FABLE_COMPILER_PYTHON
                let v7244 : string = $"%A{v7230}"
                let _v7231 = v7244 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v7247 : string = $"%A{v7230}"
                let _v7231 = v7247 
                #endif
#else
                let v7250 : string = $"{v7230.GetType ()}: {v7230.Message}"
                let _v7231 = v7250 
                #endif
                let v7251 : string = _v7231 
                let v7256 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v7257 : (string -> unit) = v1.Push
                v7257 v7251
                #endif
                // run_target_args' is_unit
                let v7258 : (unit -> exn) = closure66(v7230)
                let v7259 : System.Threading.Tasks.TaskCanceledException = v7258 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v7262 : unit = ()
                let v7263 : (unit -> unit) = closure67(v7259)
                let v7264 : unit = (fun () -> v7263 (); v7262) ()
                return -2147483648 
                (* indent
                ()
            indent *)
            (* try_unit
            try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v9436 : Async<int32> = _v7081 
    let _v3 = v9436 
    #endif
    let v9437 : Async<int32> = _v3 
    v9437
and method155 (v0 : int32, v1 : int32) : string =
    let v2 : string = method14()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "exit_code"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure8(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure8(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure8(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure8(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "output_length"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure8(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v3, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : string = $"{v1}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure8(v3, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v73 : string = " }"
    let v74 : string = $"{v73}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure8(v3, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = v3.l0
    v82
and method154 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32) : string =
    let v10 : string = method155(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "runtime.execute_with_options_async"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method18(v13)
and closure68 (v0 : int32, v1 : string) () : unit =
    let v2 : US0 = US0_1
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method8(v20, v21, v22, v23, v24, v25)
        let v39 : string = method62()
        let v40 : int32 = v1.Length
        let v41 : string = method154(v20, v21, v22, v23, v24, v25, v38, v39, v0, v40)
        method19(v41)
and method138 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v7 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v7 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v14 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v7 = v14 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : unit = ()
    let _v17 =
        async {
            let v20 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v21 : int32, v22 : string) = null |> unbox<struct (int32 * string)>
            return struct (v21, v22) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v27 : int32, v28 : string) = null |> unbox<struct (int32 * string)>
            return struct (v27, v28) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v33 : int32, v34 : string) = null |> unbox<struct (int32 * string)>
            return struct (v33, v34) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v39 : int32, v40 : string) = null |> unbox<struct (int32 * string)>
            return struct (v39, v40) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v45 : int32, v46 : string) = null |> unbox<struct (int32 * string)>
            return struct (v45, v46) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v51 : int32, v52 : string) = null |> unbox<struct (int32 * string)>
            return struct (v51, v52) 
            #endif
#else
            let v57 : US13 = method83(v0)
            let struct (v68 : string, v69 : US5) =
                match v57 with
                | US13_1(v60) -> (* Error *)
                    let v61 : string = $"resultm.get / Result value was Error: {v60}"
                    failwith<struct (string * US5)> v61
                | US13_0(v58, v59) -> (* Ok *)
                    struct (v58, v59)
            let v70 : (string -> US5) = method6()
            let v71 : US5 option = v6 |> Option.map v70 
            let v82 : US5 = US5_1
            let v83 : US5 = v71 |> Option.defaultValue v82 
            let v90 : string =
                match v83 with
                | US5_1 -> (* None *)
                    let v88 : string = ""
                    v88
                | US5_0(v87) -> (* Some *)
                    v87
            let v91 : unit = ()
            let v92 : (unit -> unit) = closure60(v0, v1, v2, v3, v4, v5, v6, v69, v68)
            let v93 : unit = (fun () -> v92 (); v91) ()
            let v133 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v137 : string =
                match v69 with
                | US5_1 -> (* None *)
                    let v135 : string = ""
                    v135
                | US5_0(v134) -> (* Some *)
                    v134
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v137,
              StandardOutputEncoding = v133,
              WorkingDirectory = v90,
              FileName = v68,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v138 : System.Diagnostics.ProcessStartInfo = start_info
            let v139 : (struct (string * string) []) = method141(v0, v1, v2, v3, v4, v5, v6)
            let v140 : int32 = v139.Length
            let v141 : Mut6 = {l0 = 0} : Mut6
            while method59(v140, v141) do
                let v143 : int32 = v141.l0
                let struct (v144 : string, v145 : string) = v139.[int v143]
                v138.EnvironmentVariables.[v144] <- v145 
                let v146 : int32 = v143 + 1
                v141.l0 <- v146
                ()
            let v147 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v138)
            use v147 = v147 
            let v148 : System.Diagnostics.Process = v147 
            let v149 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v150 : System.Collections.Concurrent.ConcurrentStack<string> = v149 ()
            let v151 : bool = false
            let v152 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v148, v150, v151)
            v148.OutputDataReceived.Add v152 
            let v153 : bool = true
            let v154 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v148, v150, v153)
            v148.ErrorDataReceived.Add v154 
            let v155 : (unit -> bool) = v148.Start
            let v156 : bool = v155 ()
            let v157 : bool = v156 = false
            if v157 then
                let v158 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v158
            let v159 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v159 v148
            let v160 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v160 v148
            let v161 : (System.Threading.CancellationToken -> US31) = method147()
            let v162 : US31 option = v1 |> Option.map v161 
            let v173 : US31 = US31_1
            let v174 : US31 = v162 |> Option.defaultValue v173 
            let v181 : System.Threading.CancellationToken =
                match v174 with
                | US31_1 -> (* None *)
                    let v179 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v179
                | US31_0(v178) -> (* Some *)
                    v178
            let v182 : Async<System.Threading.CancellationToken> = method148(v181)
            let! v182 = v182 
            let v183 : System.Threading.CancellationToken = v182 
            let v184 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v183.Register
            let v185 : (unit -> unit) = closure65(v148)
            let v186 : System.Threading.CancellationTokenRegistration = v184 v185
            use v186 = v186 
            let v187 : System.Threading.CancellationTokenRegistration = v186 
            let v188 : Async<int32> = method151(v148, v150, v183)
            let! v188 = v188 
            let v189 : int32 = v188 
            let v190 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v191 : string seq = v190 v150
            let v194 : (string seq -> string seq) = Seq.rev
            let v195 : string seq = v194 v191
            let v198 : string = method134()
            let v199 : (string -> (string seq -> string)) = String.concat
            let v200 : (string seq -> string) = v199 v198
            let v201 : string = v200 v195
            let v205 : unit = ()
            let v206 : (unit -> unit) = closure68(v189, v201)
            let v207 : unit = (fun () -> v206 (); v205) ()
            return struct (v189, v201) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1892 : Async<struct (int32 * string)> = _v17 
    let _v7 = v1892 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1893 : unit = ()
    let _v1893 =
        async {
            let v1896 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v1897 : int32, v1898 : string) = null |> unbox<struct (int32 * string)>
            return struct (v1897, v1898) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v1903 : int32, v1904 : string) = null |> unbox<struct (int32 * string)>
            return struct (v1903, v1904) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v1909 : int32, v1910 : string) = null |> unbox<struct (int32 * string)>
            return struct (v1909, v1910) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v1915 : int32, v1916 : string) = null |> unbox<struct (int32 * string)>
            return struct (v1915, v1916) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v1921 : int32, v1922 : string) = null |> unbox<struct (int32 * string)>
            return struct (v1921, v1922) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v1927 : int32, v1928 : string) = null |> unbox<struct (int32 * string)>
            return struct (v1927, v1928) 
            #endif
#else
            let v1933 : US13 = method83(v0)
            let struct (v1944 : string, v1945 : US5) =
                match v1933 with
                | US13_1(v1936) -> (* Error *)
                    let v1937 : string = $"resultm.get / Result value was Error: {v1936}"
                    failwith<struct (string * US5)> v1937
                | US13_0(v1934, v1935) -> (* Ok *)
                    struct (v1934, v1935)
            let v1946 : (string -> US5) = method6()
            let v1947 : US5 option = v6 |> Option.map v1946 
            let v1958 : US5 = US5_1
            let v1959 : US5 = v1947 |> Option.defaultValue v1958 
            let v1966 : string =
                match v1959 with
                | US5_1 -> (* None *)
                    let v1964 : string = ""
                    v1964
                | US5_0(v1963) -> (* Some *)
                    v1963
            let v1967 : unit = ()
            let v1968 : (unit -> unit) = closure60(v0, v1, v2, v3, v4, v5, v6, v1945, v1944)
            let v1969 : unit = (fun () -> v1968 (); v1967) ()
            let v2009 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v2013 : string =
                match v1945 with
                | US5_1 -> (* None *)
                    let v2011 : string = ""
                    v2011
                | US5_0(v2010) -> (* Some *)
                    v2010
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v2013,
              StandardOutputEncoding = v2009,
              WorkingDirectory = v1966,
              FileName = v1944,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v2014 : System.Diagnostics.ProcessStartInfo = start_info
            let v2015 : (struct (string * string) []) = method141(v0, v1, v2, v3, v4, v5, v6)
            let v2016 : int32 = v2015.Length
            let v2017 : Mut6 = {l0 = 0} : Mut6
            while method59(v2016, v2017) do
                let v2019 : int32 = v2017.l0
                let struct (v2020 : string, v2021 : string) = v2015.[int v2019]
                v2014.EnvironmentVariables.[v2020] <- v2021 
                let v2022 : int32 = v2019 + 1
                v2017.l0 <- v2022
                ()
            let v2023 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v2014)
            use v2023 = v2023 
            let v2024 : System.Diagnostics.Process = v2023 
            let v2025 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v2026 : System.Collections.Concurrent.ConcurrentStack<string> = v2025 ()
            let v2027 : bool = false
            let v2028 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v2024, v2026, v2027)
            v2024.OutputDataReceived.Add v2028 
            let v2029 : bool = true
            let v2030 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v2024, v2026, v2029)
            v2024.ErrorDataReceived.Add v2030 
            let v2031 : (unit -> bool) = v2024.Start
            let v2032 : bool = v2031 ()
            let v2033 : bool = v2032 = false
            if v2033 then
                let v2034 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v2034
            let v2035 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v2035 v2024
            let v2036 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v2036 v2024
            let v2037 : (System.Threading.CancellationToken -> US31) = method147()
            let v2038 : US31 option = v1 |> Option.map v2037 
            let v2049 : US31 = US31_1
            let v2050 : US31 = v2038 |> Option.defaultValue v2049 
            let v2057 : System.Threading.CancellationToken =
                match v2050 with
                | US31_1 -> (* None *)
                    let v2055 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v2055
                | US31_0(v2054) -> (* Some *)
                    v2054
            let v2058 : Async<System.Threading.CancellationToken> = method148(v2057)
            let! v2058 = v2058 
            let v2059 : System.Threading.CancellationToken = v2058 
            let v2060 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v2059.Register
            let v2061 : (unit -> unit) = closure65(v2024)
            let v2062 : System.Threading.CancellationTokenRegistration = v2060 v2061
            use v2062 = v2062 
            let v2063 : System.Threading.CancellationTokenRegistration = v2062 
            let v2064 : Async<int32> = method151(v2024, v2026, v2059)
            let! v2064 = v2064 
            let v2065 : int32 = v2064 
            let v2066 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v2067 : string seq = v2066 v2026
            let v2070 : (string seq -> string seq) = Seq.rev
            let v2071 : string seq = v2070 v2067
            let v2074 : string = method134()
            let v2075 : (string -> (string seq -> string)) = String.concat
            let v2076 : (string seq -> string) = v2075 v2074
            let v2077 : string = v2076 v2071
            let v2081 : unit = ()
            let v2082 : (unit -> unit) = closure68(v2065, v2077)
            let v2083 : unit = (fun () -> v2082 (); v2081) ()
            return struct (v2065, v2077) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v3768 : Async<struct (int32 * string)> = _v1893 
    let _v7 = v3768 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v3769 : unit = ()
    let _v3769 =
        async {
            let v3772 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v3773 : int32, v3774 : string) = null |> unbox<struct (int32 * string)>
            return struct (v3773, v3774) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v3779 : int32, v3780 : string) = null |> unbox<struct (int32 * string)>
            return struct (v3779, v3780) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v3785 : int32, v3786 : string) = null |> unbox<struct (int32 * string)>
            return struct (v3785, v3786) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v3791 : int32, v3792 : string) = null |> unbox<struct (int32 * string)>
            return struct (v3791, v3792) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v3797 : int32, v3798 : string) = null |> unbox<struct (int32 * string)>
            return struct (v3797, v3798) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v3803 : int32, v3804 : string) = null |> unbox<struct (int32 * string)>
            return struct (v3803, v3804) 
            #endif
#else
            let v3809 : US13 = method83(v0)
            let struct (v3820 : string, v3821 : US5) =
                match v3809 with
                | US13_1(v3812) -> (* Error *)
                    let v3813 : string = $"resultm.get / Result value was Error: {v3812}"
                    failwith<struct (string * US5)> v3813
                | US13_0(v3810, v3811) -> (* Ok *)
                    struct (v3810, v3811)
            let v3822 : (string -> US5) = method6()
            let v3823 : US5 option = v6 |> Option.map v3822 
            let v3834 : US5 = US5_1
            let v3835 : US5 = v3823 |> Option.defaultValue v3834 
            let v3842 : string =
                match v3835 with
                | US5_1 -> (* None *)
                    let v3840 : string = ""
                    v3840
                | US5_0(v3839) -> (* Some *)
                    v3839
            let v3843 : unit = ()
            let v3844 : (unit -> unit) = closure60(v0, v1, v2, v3, v4, v5, v6, v3821, v3820)
            let v3845 : unit = (fun () -> v3844 (); v3843) ()
            let v3885 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v3889 : string =
                match v3821 with
                | US5_1 -> (* None *)
                    let v3887 : string = ""
                    v3887
                | US5_0(v3886) -> (* Some *)
                    v3886
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v3889,
              StandardOutputEncoding = v3885,
              WorkingDirectory = v3842,
              FileName = v3820,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v3890 : System.Diagnostics.ProcessStartInfo = start_info
            let v3891 : (struct (string * string) []) = method141(v0, v1, v2, v3, v4, v5, v6)
            let v3892 : int32 = v3891.Length
            let v3893 : Mut6 = {l0 = 0} : Mut6
            while method59(v3892, v3893) do
                let v3895 : int32 = v3893.l0
                let struct (v3896 : string, v3897 : string) = v3891.[int v3895]
                v3890.EnvironmentVariables.[v3896] <- v3897 
                let v3898 : int32 = v3895 + 1
                v3893.l0 <- v3898
                ()
            let v3899 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v3890)
            use v3899 = v3899 
            let v3900 : System.Diagnostics.Process = v3899 
            let v3901 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v3902 : System.Collections.Concurrent.ConcurrentStack<string> = v3901 ()
            let v3903 : bool = false
            let v3904 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v3900, v3902, v3903)
            v3900.OutputDataReceived.Add v3904 
            let v3905 : bool = true
            let v3906 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v3900, v3902, v3905)
            v3900.ErrorDataReceived.Add v3906 
            let v3907 : (unit -> bool) = v3900.Start
            let v3908 : bool = v3907 ()
            let v3909 : bool = v3908 = false
            if v3909 then
                let v3910 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v3910
            let v3911 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v3911 v3900
            let v3912 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v3912 v3900
            let v3913 : (System.Threading.CancellationToken -> US31) = method147()
            let v3914 : US31 option = v1 |> Option.map v3913 
            let v3925 : US31 = US31_1
            let v3926 : US31 = v3914 |> Option.defaultValue v3925 
            let v3933 : System.Threading.CancellationToken =
                match v3926 with
                | US31_1 -> (* None *)
                    let v3931 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v3931
                | US31_0(v3930) -> (* Some *)
                    v3930
            let v3934 : Async<System.Threading.CancellationToken> = method148(v3933)
            let! v3934 = v3934 
            let v3935 : System.Threading.CancellationToken = v3934 
            let v3936 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v3935.Register
            let v3937 : (unit -> unit) = closure65(v3900)
            let v3938 : System.Threading.CancellationTokenRegistration = v3936 v3937
            use v3938 = v3938 
            let v3939 : System.Threading.CancellationTokenRegistration = v3938 
            let v3940 : Async<int32> = method151(v3900, v3902, v3935)
            let! v3940 = v3940 
            let v3941 : int32 = v3940 
            let v3942 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v3943 : string seq = v3942 v3902
            let v3946 : (string seq -> string seq) = Seq.rev
            let v3947 : string seq = v3946 v3943
            let v3950 : string = method134()
            let v3951 : (string -> (string seq -> string)) = String.concat
            let v3952 : (string seq -> string) = v3951 v3950
            let v3953 : string = v3952 v3947
            let v3957 : unit = ()
            let v3958 : (unit -> unit) = closure68(v3941, v3953)
            let v3959 : unit = (fun () -> v3958 (); v3957) ()
            return struct (v3941, v3953) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v5644 : Async<struct (int32 * string)> = _v3769 
    let _v7 = v5644 
    #endif
#else
    let v5645 : unit = ()
    let _v5645 =
        async {
            let v5648 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v5649 : int32, v5650 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5649, v5650) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v5655 : int32, v5656 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5655, v5656) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v5661 : int32, v5662 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5661, v5662) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v5667 : int32, v5668 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5667, v5668) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v5673 : int32, v5674 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5673, v5674) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v5679 : int32, v5680 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5679, v5680) 
            #endif
#else
            let v5685 : US13 = method83(v0)
            let struct (v5696 : string, v5697 : US5) =
                match v5685 with
                | US13_1(v5688) -> (* Error *)
                    let v5689 : string = $"resultm.get / Result value was Error: {v5688}"
                    failwith<struct (string * US5)> v5689
                | US13_0(v5686, v5687) -> (* Ok *)
                    struct (v5686, v5687)
            let v5698 : (string -> US5) = method6()
            let v5699 : US5 option = v6 |> Option.map v5698 
            let v5710 : US5 = US5_1
            let v5711 : US5 = v5699 |> Option.defaultValue v5710 
            let v5718 : string =
                match v5711 with
                | US5_1 -> (* None *)
                    let v5716 : string = ""
                    v5716
                | US5_0(v5715) -> (* Some *)
                    v5715
            let v5719 : unit = ()
            let v5720 : (unit -> unit) = closure60(v0, v1, v2, v3, v4, v5, v6, v5697, v5696)
            let v5721 : unit = (fun () -> v5720 (); v5719) ()
            let v5761 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v5765 : string =
                match v5697 with
                | US5_1 -> (* None *)
                    let v5763 : string = ""
                    v5763
                | US5_0(v5762) -> (* Some *)
                    v5762
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v5765,
              StandardOutputEncoding = v5761,
              WorkingDirectory = v5718,
              FileName = v5696,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v5766 : System.Diagnostics.ProcessStartInfo = start_info
            let v5767 : (struct (string * string) []) = method141(v0, v1, v2, v3, v4, v5, v6)
            let v5768 : int32 = v5767.Length
            let v5769 : Mut6 = {l0 = 0} : Mut6
            while method59(v5768, v5769) do
                let v5771 : int32 = v5769.l0
                let struct (v5772 : string, v5773 : string) = v5767.[int v5771]
                v5766.EnvironmentVariables.[v5772] <- v5773 
                let v5774 : int32 = v5771 + 1
                v5769.l0 <- v5774
                ()
            let v5775 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v5766)
            use v5775 = v5775 
            let v5776 : System.Diagnostics.Process = v5775 
            let v5777 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v5778 : System.Collections.Concurrent.ConcurrentStack<string> = v5777 ()
            let v5779 : bool = false
            let v5780 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v5776, v5778, v5779)
            v5776.OutputDataReceived.Add v5780 
            let v5781 : bool = true
            let v5782 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v5776, v5778, v5781)
            v5776.ErrorDataReceived.Add v5782 
            let v5783 : (unit -> bool) = v5776.Start
            let v5784 : bool = v5783 ()
            let v5785 : bool = v5784 = false
            if v5785 then
                let v5786 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v5786
            let v5787 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v5787 v5776
            let v5788 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v5788 v5776
            let v5789 : (System.Threading.CancellationToken -> US31) = method147()
            let v5790 : US31 option = v1 |> Option.map v5789 
            let v5801 : US31 = US31_1
            let v5802 : US31 = v5790 |> Option.defaultValue v5801 
            let v5809 : System.Threading.CancellationToken =
                match v5802 with
                | US31_1 -> (* None *)
                    let v5807 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v5807
                | US31_0(v5806) -> (* Some *)
                    v5806
            let v5810 : Async<System.Threading.CancellationToken> = method148(v5809)
            let! v5810 = v5810 
            let v5811 : System.Threading.CancellationToken = v5810 
            let v5812 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v5811.Register
            let v5813 : (unit -> unit) = closure65(v5776)
            let v5814 : System.Threading.CancellationTokenRegistration = v5812 v5813
            use v5814 = v5814 
            let v5815 : System.Threading.CancellationTokenRegistration = v5814 
            let v5816 : Async<int32> = method151(v5776, v5778, v5811)
            let! v5816 = v5816 
            let v5817 : int32 = v5816 
            let v5818 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v5819 : string seq = v5818 v5778
            let v5822 : (string seq -> string seq) = Seq.rev
            let v5823 : string seq = v5822 v5819
            let v5826 : string = method134()
            let v5827 : (string -> (string seq -> string)) = String.concat
            let v5828 : (string seq -> string) = v5827 v5826
            let v5829 : string = v5828 v5823
            let v5833 : unit = ()
            let v5834 : (unit -> unit) = closure68(v5817, v5829)
            let v5835 : unit = (fun () -> v5834 (); v5833) ()
            return struct (v5817, v5829) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v7520 : Async<struct (int32 * string)> = _v5645 
    let _v7 = v7520 
    #endif
    let v7521 : Async<struct (int32 * string)> = _v7 
    v7521
and method137 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    method138(v0, v1, v2, v3, v4, v5, v6)
and method81 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : struct (int32 * string) =
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = method82(v0, v1, v2, v3, v4, v5, v6)
    let v9 : US13 = method83(v8)
    let struct (v20 : string, v21 : US5) =
        match v9 with
        | US13_1(v12) -> (* Error *)
            let v13 : string = $"resultm.get / Result value was Error: {v12}"
            failwith<struct (string * US5)> v13
        | US13_0(v10, v11) -> (* Ok *)
            struct (v10, v11)
    let v25 : string =
        match v21 with
        | US5_1 -> (* None *)
            let v23 : string = ""
            v23
        | US5_0(v22) -> (* Some *)
            v22
    let v26 : US21 = method95(v25)
    let v34 : (string []) =
        match v26 with
        | US21_1(v28) -> (* Error *)
            let v29 : string = $"resultm.get / Result value was Error: {v28}"
            failwith<(string [])> v29
        | US21_0(v27) -> (* Ok *)
            v27
    let v35 : string = "$0.to_vec()"
    let v36 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v34 v35 
    let v37 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v38 : bool = Fable.Core.RustInterop.emitRustExpr v36 v37 
    let v39 : string = "x"
    let v40 : string = Fable.Core.RustInterop.emitRustExpr () v39 
    let v41 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v42 : string = "&*$0"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v40 v42 
    let _v41 = v43 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v44 : string = "&*$0"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v40 v44 
    let _v41 = v45 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v46 : string = "&*$0"
    let v47 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v40 v46 
    let _v41 = v47 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v48 : Ref<Str> = v40 |> unbox<Ref<Str>>
    let _v41 = v48 
    #endif
#if FABLE_COMPILER_PYTHON
    let v51 : Ref<Str> = v40 |> unbox<Ref<Str>>
    let _v41 = v51 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v54 : Ref<Str> = v40 |> unbox<Ref<Str>>
    let _v41 = v54 
    #endif
#else
    let v57 : Ref<Str> = v40 |> unbox<Ref<Str>>
    let _v41 = v57 
    #endif
    let v60 : Ref<Str> = _v41 
    let v65 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v66 : string = "String::from($0)"
    let v67 : std_string_String = Fable.Core.RustInterop.emitRustExpr v60 v66 
    let _v65 = v67 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : string = "String::from($0)"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr v60 v68 
    let _v65 = v69 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v70 : string = "String::from($0)"
    let v71 : std_string_String = Fable.Core.RustInterop.emitRustExpr v60 v70 
    let _v65 = v71 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v72 : std_string_String = v60 |> unbox<std_string_String>
    let _v65 = v72 
    #endif
#if FABLE_COMPILER_PYTHON
    let v75 : std_string_String = v60 |> unbox<std_string_String>
    let _v65 = v75 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v78 : std_string_String = v60 |> unbox<std_string_String>
    let _v65 = v78 
    #endif
#else
    let v81 : std_string_String = v60 |> unbox<std_string_String>
    let _v65 = v81 
    #endif
    let v84 : std_string_String = _v65 
    let v89 : string = "true; $0 }).collect::<Vec<_>>()"
    let v90 : bool = Fable.Core.RustInterop.emitRustExpr v84 v89 
    let v91 : string = "_vec_map"
    let v92 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v91 
    let v93 : unit = ()
    let v94 : (unit -> unit) = closure40(v0, v1, v2, v3, v4, v5, v6, v20, v92)
    let v95 : unit = (fun () -> v94 (); v93) ()
    let v138 : bool = true
    let mutable _v138 : (int32 * string) option = None 
    (
    (fun () ->
    (fun () ->
    let v139 : string = "std::process::Command::new(&*$0)"
    let v140 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v20 v139 
    let v141 : string = "true; let mut v140 = v140"
    let v142 : bool = Fable.Core.RustInterop.emitRustExpr () v141 
    let v143 : string = "true; std::process::Command::args(&mut v140, &*$0)"
    let v144 : bool = Fable.Core.RustInterop.emitRustExpr v92 v143 
    let v145 : string = "$0"
    let v146 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v140 v145 
    let v147 : string = "std::process::Stdio::piped()"
    let v148 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v147 
    let v149 : string = "true; let mut v146 = v146"
    let v150 : bool = Fable.Core.RustInterop.emitRustExpr () v149 
    let v151 : string = "true; std::process::Command::stdout(&mut v146, std::process::Stdio::piped())"
    let v152 : bool = Fable.Core.RustInterop.emitRustExpr () v151 
    let v153 : string = "$0"
    let v154 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v146 v153 
    let v155 : string = "std::process::Stdio::piped()"
    let v156 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v155 
    let v157 : string = "true; let mut v154 = v154"
    let v158 : bool = Fable.Core.RustInterop.emitRustExpr () v157 
    let v159 : string = "true; std::process::Command::stderr(&mut v154, std::process::Stdio::piped())"
    let v160 : bool = Fable.Core.RustInterop.emitRustExpr () v159 
    let v161 : string = "$0"
    let v162 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v154 v161 
    let v163 : string = "std::process::Stdio::piped()"
    let v164 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v163 
    let v165 : string = "true; let mut v162 = v162"
    let v166 : bool = Fable.Core.RustInterop.emitRustExpr () v165 
    let v167 : string = "true; std::process::Command::stdin(&mut v162, std::process::Stdio::piped())"
    let v168 : bool = Fable.Core.RustInterop.emitRustExpr () v167 
    let v169 : string = "$0"
    let v170 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v162 v169 
    let v171 : (string -> US5) = method6()
    let v172 : US5 option = v6 |> Option.map v171 
    let v183 : US5 = US5_1
    let v184 : US5 = v172 |> Option.defaultValue v183 
    let v198 : std_process_Command =
        match v184 with
        | US5_1 -> (* None *)
            let v195 : string = $"v170"
            let v196 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v195 
            v196
        | US5_0(v188) -> (* Some *)
            let v189 : string = "true; let mut v170 = v170"
            let v190 : bool = Fable.Core.RustInterop.emitRustExpr () v189 
            let v191 : string = "true; std::process::Command::current_dir(&mut v170, &*$0)"
            let v192 : bool = Fable.Core.RustInterop.emitRustExpr v188 v191 
            let v193 : string = $"v170"
            let v194 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v193 
            v194
    let v199 : uint64 = System.Convert.ToUInt64 v2.Length
    let v200 : bool = v199 = 0UL
    let v220 : std_process_Command =
        if v200 then
            v198
        else
            let v201 : string = "$0.to_vec()"
            let v202 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr v2 v201 
            let v203 : string = "true; let _vec_fold_ = $0.into_iter().fold(v198, |acc, x| { //"
            let v204 : bool = Fable.Core.RustInterop.emitRustExpr v202 v203 
            let v205 : string = "acc"
            let v206 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v205 
            let v207 : string = "x"
            let struct (v208 : string, v209 : string) = Fable.Core.RustInterop.emitRustExpr () v207 
            let v210 : string = "true; let mut v206 = v206"
            let v211 : bool = Fable.Core.RustInterop.emitRustExpr () v210 
            let v212 : string = "true; std::process::Command::env(&mut v206, &*$0, &*$1)"
            let v213 : bool = Fable.Core.RustInterop.emitRustExpr struct (v208, v209) v212 
            let v214 : string = "$0"
            let v215 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v206 v214 
            let v216 : string = "true; $0 })"
            let v217 : bool = Fable.Core.RustInterop.emitRustExpr v215 v216 
            let v218 : string = "_vec_fold_"
            let v219 : std_process_Command = Fable.Core.RustInterop.emitRustExpr () v218 
            v219
    let v221 : string = "true; let mut v220 = v220"
    let v222 : bool = Fable.Core.RustInterop.emitRustExpr () v221 
    let v223 : string = "std::process::Command::spawn(&mut v220)"
    let v224 : Result<std_process_Child, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v223 
    let v225 : (std_io_Error -> std_string_String) = method65()
    let v226 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v227 : string = "$0.map_err(|x| $1(x))"
    let v228 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v224, v225) v227 
    let _v226 = v228 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v229 : string = "$0.map_err(|x| $1(x))"
    let v230 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v224, v225) v229 
    let _v226 = v230 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v231 : string = "$0.map_err(|x| $1(x))"
    let v232 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v224, v225) v231 
    let _v226 = v232 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v233 : Result<std_process_Child, std_string_String> = match v224 with Ok x -> Ok x | Error x -> Error (v225 x)
    let _v226 = v233 
    #endif
#if FABLE_COMPILER_PYTHON
    let v234 : Result<std_process_Child, std_string_String> = match v224 with Ok x -> Ok x | Error x -> Error (v225 x)
    let _v226 = v234 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v235 : Result<std_process_Child, std_string_String> = match v224 with Ok x -> Ok x | Error x -> Error (v225 x)
    let _v226 = v235 
    #endif
#else
    let v236 : Result<std_process_Child, std_string_String> = match v224 with Ok x -> Ok x | Error x -> Error (v225 x)
    let _v226 = v236 
    #endif
    let v237 : Result<std_process_Child, std_string_String> = _v226 
    let v240 : (std_process_Child option -> std_process_Child option) = method107()
    let v241 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v242 : bool = Fable.Core.RustInterop.emitRustExpr v237 v241 
    let v243 : string = "x"
    let v244 : std_process_Child = Fable.Core.RustInterop.emitRustExpr () v243 
    let v245 : std_process_Child option = Some v244 
    let v248 : std_process_Child option = v240 v245
    let v249 : string = "std::sync::Mutex::new(v248)"
    let v250 : std_sync_Mutex<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr () v249 
    let v251 : string = "std::sync::Arc::new(v250)"
    let v252 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr () v251 
    let v253 : string = "true; $0 })"
    let v254 : bool = Fable.Core.RustInterop.emitRustExpr v252 v253 
    let v255 : string = "_result_map_"
    let v256 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v255 
    let v257 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US23) = method108()
    let v258 : (std_string_String -> US23) = method109()
    let v259 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
    let v260 : US23 = Fable.Core.RustInterop.emitRustExpr struct (v257, v258, v256) v259 
    let struct (v1406 : int32, v1407 : US6, v1408 : US24) =
        match v260 with
        | US23_1(v1358) -> (* Error *)
            let v1359 : unit = ()
            let v1360 : (unit -> unit) = closure44(v1358)
            let v1361 : unit = (fun () -> v1360 (); v1359) ()
            let v1401 : US6 = US6_0(v1358)
            let v1402 : US24 = US24_1
            struct (-1, v1401, v1402)
        | US23_0(v261) -> (* Ok *)
            let v262 : string = "true; let _capture = (|| { //"
            let v263 : bool = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "$0"
            let v265 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v261 v264 
            let v266 : string = "v265.lock()"
            let v267 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v266 
            let v268 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v269 : string = "$0.unwrap()"
            let v270 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v267 v269 
            let _v268 = v270 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v271 : string = "$0.unwrap()"
            let v272 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v267 v271 
            let _v268 = v272 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v273 : string = "$0.unwrap()"
            let v274 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v267 v273 
            let _v268 = v274 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v275 : std_sync_MutexGuard<std_process_Child option> = match v267 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v268 = v275 
            #endif
#if FABLE_COMPILER_PYTHON
            let v276 : std_sync_MutexGuard<std_process_Child option> = match v267 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v268 = v276 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v277 : std_sync_MutexGuard<std_process_Child option> = match v267 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v268 = v277 
            #endif
#else
            let v278 : std_sync_MutexGuard<std_process_Child option> = match v267 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v268 = v278 
            #endif
            let v279 : std_sync_MutexGuard<std_process_Child option> = _v268 
            let v282 : std_sync_MutexGuard<std_process_Child option> = method111(v279)
            let v283 : string = "true; let mut v282 = v282"
            let v284 : bool = Fable.Core.RustInterop.emitRustExpr () v283 
            let v285 : string = "&mut $0"
            let v286 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v282 v285 
            let v287 : string = "$0.as_mut()"
            let v288 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v286 v287 
            let v289 : string = "$0.unwrap()"
            let v290 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v288 v289 
            let v291 : string = "&mut $0.stdout"
            let v292 : Ref<Mut<std_process_ChildStdout option>> = Fable.Core.RustInterop.emitRustExpr v290 v291 
            let v293 : string = "Option::take($0)"
            let v294 : std_process_ChildStdout option = Fable.Core.RustInterop.emitRustExpr v292 v293 
            let v295 : string = "$0.unwrap()"
            let v296 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr v294 v295 
            let v297 : string = "true; $0 })()"
            let v298 : bool = Fable.Core.RustInterop.emitRustExpr v296 v297 
            let v299 : string = "_capture"
            let v300 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr () v299 
            let v301 : string = "true; let _capture = (|| { //"
            let v302 : bool = Fable.Core.RustInterop.emitRustExpr () v301 
            let v303 : string = "$0"
            let v304 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v261 v303 
            let v305 : string = "v304.lock()"
            let v306 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v305 
            let v307 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v308 : string = "$0.unwrap()"
            let v309 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v306 v308 
            let _v307 = v309 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v310 : string = "$0.unwrap()"
            let v311 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v306 v310 
            let _v307 = v311 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v312 : string = "$0.unwrap()"
            let v313 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v306 v312 
            let _v307 = v313 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v314 : std_sync_MutexGuard<std_process_Child option> = match v306 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v307 = v314 
            #endif
#if FABLE_COMPILER_PYTHON
            let v315 : std_sync_MutexGuard<std_process_Child option> = match v306 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v307 = v315 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v316 : std_sync_MutexGuard<std_process_Child option> = match v306 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v307 = v316 
            #endif
#else
            let v317 : std_sync_MutexGuard<std_process_Child option> = match v306 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v307 = v317 
            #endif
            let v318 : std_sync_MutexGuard<std_process_Child option> = _v307 
            let v321 : std_sync_MutexGuard<std_process_Child option> = method111(v318)
            let v322 : string = "true; let mut v321 = v321"
            let v323 : bool = Fable.Core.RustInterop.emitRustExpr () v322 
            let v324 : string = "&mut $0"
            let v325 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v321 v324 
            let v326 : string = "$0.as_mut()"
            let v327 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v325 v326 
            let v328 : string = "$0.unwrap()"
            let v329 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v327 v328 
            let v330 : string = "&mut $0.stderr"
            let v331 : Ref<Mut<std_process_ChildStderr option>> = Fable.Core.RustInterop.emitRustExpr v329 v330 
            let v332 : string = "Option::take($0)"
            let v333 : std_process_ChildStderr option = Fable.Core.RustInterop.emitRustExpr v331 v332 
            let v334 : string = "$0.unwrap()"
            let v335 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr v333 v334 
            let v336 : string = "true; $0 })()"
            let v337 : bool = Fable.Core.RustInterop.emitRustExpr v335 v336 
            let v338 : string = "_capture"
            let v339 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr () v338 
            let v340 : string = "true; let _capture = (|| { //"
            let v341 : bool = Fable.Core.RustInterop.emitRustExpr () v340 
            let v342 : string = "$0"
            let v343 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v261 v342 
            let v344 : string = "v343.lock()"
            let v345 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v344 
            let v346 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v347 : string = "$0.unwrap()"
            let v348 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v345 v347 
            let _v346 = v348 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v349 : string = "$0.unwrap()"
            let v350 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v345 v349 
            let _v346 = v350 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v351 : string = "$0.unwrap()"
            let v352 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v345 v351 
            let _v346 = v352 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v353 : std_sync_MutexGuard<std_process_Child option> = match v345 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v346 = v353 
            #endif
#if FABLE_COMPILER_PYTHON
            let v354 : std_sync_MutexGuard<std_process_Child option> = match v345 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v346 = v354 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v355 : std_sync_MutexGuard<std_process_Child option> = match v345 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v346 = v355 
            #endif
#else
            let v356 : std_sync_MutexGuard<std_process_Child option> = match v345 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v346 = v356 
            #endif
            let v357 : std_sync_MutexGuard<std_process_Child option> = _v346 
            let v360 : std_sync_MutexGuard<std_process_Child option> = method111(v357)
            let v361 : string = "true; let mut v360 = v360"
            let v362 : bool = Fable.Core.RustInterop.emitRustExpr () v361 
            let v363 : string = "&mut $0"
            let v364 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v360 v363 
            let v365 : string = "$0.as_mut()"
            let v366 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v364 v365 
            let v367 : string = "$0.unwrap()"
            let v368 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v366 v367 
            let v369 : string = "&mut $0.stdin"
            let v370 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v368 v369 
            let v371 : string = "Option::take($0)"
            let v372 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v370 v371 
            let v373 : string = "$0.unwrap()"
            let v374 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr v372 v373 
            let v375 : std_process_ChildStdin option = Some v374 
            let v378 : (std_process_ChildStdin option -> std_process_ChildStdin option) = method112()
            let v379 : std_process_ChildStdin option = v378 v375
            let v380 : string = "std::sync::Mutex::new(v379)"
            let v381 : std_sync_Mutex<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr () v380 
            let v382 : string = "std::sync::Arc::new(v381)"
            let v383 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v382 
            let v384 : string = "true; $0 })()"
            let v385 : bool = Fable.Core.RustInterop.emitRustExpr v383 v384 
            let v386 : string = "_capture"
            let v387 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v386 
            let v388 : string = "{ let (sender, receiver) = std::sync::mpsc::channel(); (sender, std::sync::Arc::new(receiver)) }"
            let struct (v389 : std_sync_mpsc_Sender<std_string_String>, v390 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = Fable.Core.RustInterop.emitRustExpr () v388 
            let v391 : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) = method113()
            let v392 : std_sync_mpsc_Sender<std_string_String> = v391 v389
            let v393 : string = "std::sync::Mutex::new(v392)"
            let v394 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v393 
            let v395 : string = "std::sync::Arc::new(v394)"
            let v396 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v395 
            let v397 : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) = method114()
            let v398 : std_sync_mpsc_Sender<std_string_String> = v397 v389
            let v399 : string = "std::sync::Mutex::new(v398)"
            let v400 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v399 
            let v401 : string = "std::sync::Arc::new(v400)"
            let v402 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v401 
            let v403 : (std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> -> std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = method115()
            let v404 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> = v403 v390
            let v405 : string = "std::sync::Mutex::new(v404)"
            let v406 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v405 
            let v407 : string = "std::sync::Arc::new(v406)"
            let v408 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v407 
            let v409 : string = "true; let __spawn = std::thread::spawn(move || { //"
            let v410 : bool = Fable.Core.RustInterop.emitRustExpr () v409 
            let v411 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v412 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v300 v411 
            let v413 : string = "std::io::BufReader::new($0)"
            let v414 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr v412 v413 
            let v415 : string = "std::io::BufRead::lines(v414)"
            let v416 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v415 
            let v417 : string = "true; let mut v416 = v416; let _iter_try_for_each = v416.try_for_each(|x| { //"
            let v418 : bool = Fable.Core.RustInterop.emitRustExpr () v417 
            let v419 : string = "x"
            let v420 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v419 
            let v421 : string = "$0.clone()"
            let v422 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v396 v421 
            let v423 : (std_io_Error -> std_string_String) = method65()
            let v424 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v425 : string = "$0.map_err(|x| $1(x))"
            let v426 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v420, v423) v425 
            let _v424 = v426 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v427 : string = "$0.map_err(|x| $1(x))"
            let v428 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v420, v423) v427 
            let _v424 = v428 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v429 : string = "$0.map_err(|x| $1(x))"
            let v430 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v420, v423) v429 
            let _v424 = v430 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v431 : Result<std_string_String, std_string_String> = match v420 with Ok x -> Ok x | Error x -> Error (v423 x)
            let _v424 = v431 
            #endif
#if FABLE_COMPILER_PYTHON
            let v432 : Result<std_string_String, std_string_String> = match v420 with Ok x -> Ok x | Error x -> Error (v423 x)
            let _v424 = v432 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v433 : Result<std_string_String, std_string_String> = match v420 with Ok x -> Ok x | Error x -> Error (v423 x)
            let _v424 = v433 
            #endif
#else
            let v434 : Result<std_string_String, std_string_String> = match v420 with Ok x -> Ok x | Error x -> Error (v423 x)
            let _v424 = v434 
            #endif
            let v435 : Result<std_string_String, std_string_String> = _v424 
            let v438 : (std_string_String -> US25) = method116()
            let v439 : (std_string_String -> US25) = method117()
            let v440 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v441 : US25 = Fable.Core.RustInterop.emitRustExpr struct (v438, v439, v435) v440 
            let v636 : std_string_String =
                match v441 with
                | US25_1(v543) -> (* Error *)
                    let v544 : unit = ()
                    let v545 : (unit -> unit) = closure50(v5, v543)
                    let v546 : unit = (fun () -> v545 (); v544) ()
                    let v586 : string = $"\u001b[4;7m{v543}\u001b[0m"
                    let v587 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v588 : string = "&*$0"
                    let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v586 v588 
                    let _v587 = v589 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v590 : string = "&*$0"
                    let v591 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v586 v590 
                    let _v587 = v591 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v592 : string = "&*$0"
                    let v593 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v586 v592 
                    let _v587 = v593 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v594 : Ref<Str> = v586 |> unbox<Ref<Str>>
                    let _v587 = v594 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v597 : Ref<Str> = v586 |> unbox<Ref<Str>>
                    let _v587 = v597 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v600 : Ref<Str> = v586 |> unbox<Ref<Str>>
                    let _v587 = v600 
                    #endif
#else
                    let v603 : Ref<Str> = v586 |> unbox<Ref<Str>>
                    let _v587 = v603 
                    #endif
                    let v606 : Ref<Str> = _v587 
                    let v611 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v612 : string = "String::from($0)"
                    let v613 : std_string_String = Fable.Core.RustInterop.emitRustExpr v606 v612 
                    let _v611 = v613 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v614 : string = "String::from($0)"
                    let v615 : std_string_String = Fable.Core.RustInterop.emitRustExpr v606 v614 
                    let _v611 = v615 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v616 : string = "String::from($0)"
                    let v617 : std_string_String = Fable.Core.RustInterop.emitRustExpr v606 v616 
                    let _v611 = v617 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v618 : std_string_String = v606 |> unbox<std_string_String>
                    let _v611 = v618 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v621 : std_string_String = v606 |> unbox<std_string_String>
                    let _v611 = v621 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v624 : std_string_String = v606 |> unbox<std_string_String>
                    let _v611 = v624 
                    #endif
#else
                    let v627 : std_string_String = v606 |> unbox<std_string_String>
                    let _v611 = v627 
                    #endif
                    let v630 : std_string_String = _v611 
                    v630
                | US25_0(v442) -> (* Ok *)
                    let v443 : string = "fable_library_rust::String_::fromString($0)"
                    let v444 : string = Fable.Core.RustInterop.emitRustExpr v442 v443 
                    let v445 : string = "encoding_rs::UTF_8"
                    let v446 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v445 
                    let v447 : string = "$0.encode(&*$1).0"
                    let v448 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v446, v444) v447 
                    let v449 : string = "$0.as_ref()"
                    let v450 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v448 v449 
                    let v451 : string = "std::str::from_utf8($0)"
                    let v452 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr v450 v451 
                    let v453 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v454 : string = "$0.unwrap()"
                    let v455 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v452 v454 
                    let _v453 = v455 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v456 : string = "$0.unwrap()"
                    let v457 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v452 v456 
                    let _v453 = v457 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v458 : string = "$0.unwrap()"
                    let v459 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v452 v458 
                    let _v453 = v459 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v460 : Ref<Str> = match v452 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v453 = v460 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v461 : Ref<Str> = match v452 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v453 = v461 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v462 : Ref<Str> = match v452 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v453 = v462 
                    #endif
#else
                    let v463 : Ref<Str> = match v452 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v453 = v463 
                    #endif
                    let v464 : Ref<Str> = _v453 
                    let v467 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v468 : string = "String::from($0)"
                    let v469 : std_string_String = Fable.Core.RustInterop.emitRustExpr v464 v468 
                    let _v467 = v469 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v470 : string = "String::from($0)"
                    let v471 : std_string_String = Fable.Core.RustInterop.emitRustExpr v464 v470 
                    let _v467 = v471 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v472 : string = "String::from($0)"
                    let v473 : std_string_String = Fable.Core.RustInterop.emitRustExpr v464 v472 
                    let _v467 = v473 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v474 : std_string_String = v464 |> unbox<std_string_String>
                    let _v467 = v474 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v477 : std_string_String = v464 |> unbox<std_string_String>
                    let _v467 = v477 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v480 : std_string_String = v464 |> unbox<std_string_String>
                    let _v467 = v480 
                    #endif
#else
                    let v483 : std_string_String = v464 |> unbox<std_string_String>
                    let _v467 = v483 
                    #endif
                    let v486 : std_string_String = _v467 
                    let v491 : string = "fable_library_rust::String_::fromString($0)"
                    let v492 : string = Fable.Core.RustInterop.emitRustExpr v486 v491 
                    let v493 : string = $"> {v492}"
                    if v5 then
                        let v494 : unit = ()
                        let v495 : (unit -> unit) = closure51(v493)
                        let v496 : unit = (fun () -> v495 (); v494) ()
                        ()
                    else
                        let v539 : unit = ()
                        let v540 : (unit -> unit) = closure11(v493)
                        let v541 : unit = (fun () -> v540 (); v539) ()
                        ()
                    v486
            let v637 : string = "$0"
            let v638 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v422 v637 
            let v639 : string = "v638.lock()"
            let v640 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v639 
            let v641 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v642 : string = "$0.unwrap()"
            let v643 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v640 v642 
            let _v641 = v643 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v644 : string = "$0.unwrap()"
            let v645 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v640 v644 
            let _v641 = v645 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v646 : string = "$0.unwrap()"
            let v647 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v640 v646 
            let _v641 = v647 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v648 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v640 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v641 = v648 
            #endif
#if FABLE_COMPILER_PYTHON
            let v649 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v640 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v641 = v649 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v650 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v640 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v641 = v650 
            #endif
#else
            let v651 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v640 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v641 = v651 
            #endif
            let v652 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = _v641 
            let v655 : string = "&$0"
            let v656 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v652 v655 
            let v657 : string = "$0.send($1)"
            let v658 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v656, v636) v657 
            let v659 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method123()
            let v660 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v661 : string = "$0.map_err(|x| $1(x))"
            let v662 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v658, v659) v661 
            let _v660 = v662 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v663 : string = "$0.map_err(|x| $1(x))"
            let v664 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v658, v659) v663 
            let _v660 = v664 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v665 : string = "$0.map_err(|x| $1(x))"
            let v666 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v658, v659) v665 
            let _v660 = v666 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v667 : Result<unit, std_string_String> = match v658 with Ok x -> Ok x | Error x -> Error (v659 x)
            let _v660 = v667 
            #endif
#if FABLE_COMPILER_PYTHON
            let v668 : Result<unit, std_string_String> = match v658 with Ok x -> Ok x | Error x -> Error (v659 x)
            let _v660 = v668 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v669 : Result<unit, std_string_String> = match v658 with Ok x -> Ok x | Error x -> Error (v659 x)
            let _v660 = v669 
            #endif
#else
            let v670 : Result<unit, std_string_String> = match v658 with Ok x -> Ok x | Error x -> Error (v659 x)
            let _v660 = v670 
            #endif
            let v671 : Result<unit, std_string_String> = _v660 
            let v674 : string = "$0"
            let v675 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v671 v674 
            let v676 : string = "true; $0 }); //"
            let v677 : bool = Fable.Core.RustInterop.emitRustExpr v675 v676 
            let v678 : string = "_iter_try_for_each.map_err(|x| x.into())"
            let v679 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v678 
            let v680 : Result<unit, string> = method124(v679)
            let v681 : string = ""
            let v682 : string = "}"
            let v683 : string = v681 + v682 
            let v684 : _ = v680 
            let v685 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v686 : string = $"true; let v684 = $0"
            let v687 : bool = Fable.Core.RustInterop.emitRustExpr v684 v686 
            let _v685 = v687 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v688 : string = $"true; let v684 = $0"
            let v689 : bool = Fable.Core.RustInterop.emitRustExpr v684 v688 
            let _v685 = v689 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v690 : string = $"true; let v684 = $0"
            let v691 : bool = Fable.Core.RustInterop.emitRustExpr v684 v690 
            let _v685 = v691 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v692 : bool = true
            let _v685 = v692 
            #endif
#if FABLE_COMPILER_PYTHON
            let v693 : bool = true
            let _v685 = v693 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v694 : bool = true
            let _v685 = v694 
            #endif
#else
            let v695 : bool = true
            let _v685 = v695 
            #endif
            let v696 : bool = _v685 
            let v699 : string = $"true; v684 " + v683 + "); " + v681 + " // rust.fix_closure'"
            let v700 : bool = Fable.Core.RustInterop.emitRustExpr () v699 
            let v701 : string = "__spawn"
            let v702 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v701 
            let v703 : string = "true; let __spawn = std::thread::spawn(move || { //"
            let v704 : bool = Fable.Core.RustInterop.emitRustExpr () v703 
            let v705 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v706 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v339 v705 
            let v707 : string = "std::io::BufReader::new($0)"
            let v708 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr v706 v707 
            let v709 : string = "std::io::BufRead::lines(v708)"
            let v710 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v709 
            let v711 : string = "true; let mut v710 = v710; let _iter_try_for_each = v710.try_for_each(|x| { //"
            let v712 : bool = Fable.Core.RustInterop.emitRustExpr () v711 
            let v713 : string = "x"
            let v714 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v713 
            let v715 : string = "$0.clone()"
            let v716 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v402 v715 
            let v717 : (std_io_Error -> std_string_String) = method65()
            let v718 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v719 : string = "$0.map_err(|x| $1(x))"
            let v720 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v714, v717) v719 
            let _v718 = v720 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v721 : string = "$0.map_err(|x| $1(x))"
            let v722 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v714, v717) v721 
            let _v718 = v722 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v723 : string = "$0.map_err(|x| $1(x))"
            let v724 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v714, v717) v723 
            let _v718 = v724 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v725 : Result<std_string_String, std_string_String> = match v714 with Ok x -> Ok x | Error x -> Error (v717 x)
            let _v718 = v725 
            #endif
#if FABLE_COMPILER_PYTHON
            let v726 : Result<std_string_String, std_string_String> = match v714 with Ok x -> Ok x | Error x -> Error (v717 x)
            let _v718 = v726 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v727 : Result<std_string_String, std_string_String> = match v714 with Ok x -> Ok x | Error x -> Error (v717 x)
            let _v718 = v727 
            #endif
#else
            let v728 : Result<std_string_String, std_string_String> = match v714 with Ok x -> Ok x | Error x -> Error (v717 x)
            let _v718 = v728 
            #endif
            let v729 : Result<std_string_String, std_string_String> = _v718 
            let v732 : (std_string_String -> US25) = method116()
            let v733 : (std_string_String -> US25) = method117()
            let v734 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v735 : US25 = Fable.Core.RustInterop.emitRustExpr struct (v732, v733, v729) v734 
            let v978 : std_string_String =
                match v735 with
                | US25_1(v885) -> (* Error *)
                    let v886 : unit = ()
                    let v887 : (unit -> unit) = closure50(v5, v885)
                    let v888 : unit = (fun () -> v887 (); v886) ()
                    let v928 : string = $"\u001b[4;7m{v885}\u001b[0m"
                    let v929 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v930 : string = "&*$0"
                    let v931 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v928 v930 
                    let _v929 = v931 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v932 : string = "&*$0"
                    let v933 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v928 v932 
                    let _v929 = v933 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v934 : string = "&*$0"
                    let v935 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v928 v934 
                    let _v929 = v935 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v936 : Ref<Str> = v928 |> unbox<Ref<Str>>
                    let _v929 = v936 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v939 : Ref<Str> = v928 |> unbox<Ref<Str>>
                    let _v929 = v939 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v942 : Ref<Str> = v928 |> unbox<Ref<Str>>
                    let _v929 = v942 
                    #endif
#else
                    let v945 : Ref<Str> = v928 |> unbox<Ref<Str>>
                    let _v929 = v945 
                    #endif
                    let v948 : Ref<Str> = _v929 
                    let v953 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v954 : string = "String::from($0)"
                    let v955 : std_string_String = Fable.Core.RustInterop.emitRustExpr v948 v954 
                    let _v953 = v955 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v956 : string = "String::from($0)"
                    let v957 : std_string_String = Fable.Core.RustInterop.emitRustExpr v948 v956 
                    let _v953 = v957 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v958 : string = "String::from($0)"
                    let v959 : std_string_String = Fable.Core.RustInterop.emitRustExpr v948 v958 
                    let _v953 = v959 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v960 : std_string_String = v948 |> unbox<std_string_String>
                    let _v953 = v960 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v963 : std_string_String = v948 |> unbox<std_string_String>
                    let _v953 = v963 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v966 : std_string_String = v948 |> unbox<std_string_String>
                    let _v953 = v966 
                    #endif
#else
                    let v969 : std_string_String = v948 |> unbox<std_string_String>
                    let _v953 = v969 
                    #endif
                    let v972 : std_string_String = _v953 
                    v972
                | US25_0(v736) -> (* Ok *)
                    let v737 : string = "fable_library_rust::String_::fromString($0)"
                    let v738 : string = Fable.Core.RustInterop.emitRustExpr v736 v737 
                    let v739 : string = "encoding_rs::UTF_8"
                    let v740 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v739 
                    let v741 : string = "$0.encode(&*$1).0"
                    let v742 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v740, v738) v741 
                    let v743 : string = "$0.as_ref()"
                    let v744 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v742 v743 
                    let v745 : string = "std::str::from_utf8($0)"
                    let v746 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr v744 v745 
                    let v747 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v748 : string = "$0.unwrap()"
                    let v749 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v746 v748 
                    let _v747 = v749 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v750 : string = "$0.unwrap()"
                    let v751 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v746 v750 
                    let _v747 = v751 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v752 : string = "$0.unwrap()"
                    let v753 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v746 v752 
                    let _v747 = v753 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v754 : Ref<Str> = match v746 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v747 = v754 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v755 : Ref<Str> = match v746 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v747 = v755 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v756 : Ref<Str> = match v746 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v747 = v756 
                    #endif
#else
                    let v757 : Ref<Str> = match v746 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v747 = v757 
                    #endif
                    let v758 : Ref<Str> = _v747 
                    let v761 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v762 : string = "String::from($0)"
                    let v763 : std_string_String = Fable.Core.RustInterop.emitRustExpr v758 v762 
                    let _v761 = v763 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v764 : string = "String::from($0)"
                    let v765 : std_string_String = Fable.Core.RustInterop.emitRustExpr v758 v764 
                    let _v761 = v765 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v766 : string = "String::from($0)"
                    let v767 : std_string_String = Fable.Core.RustInterop.emitRustExpr v758 v766 
                    let _v761 = v767 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v768 : std_string_String = v758 |> unbox<std_string_String>
                    let _v761 = v768 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v771 : std_string_String = v758 |> unbox<std_string_String>
                    let _v761 = v771 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v774 : std_string_String = v758 |> unbox<std_string_String>
                    let _v761 = v774 
                    #endif
#else
                    let v777 : std_string_String = v758 |> unbox<std_string_String>
                    let _v761 = v777 
                    #endif
                    let v780 : std_string_String = _v761 
                    let v785 : string = "fable_library_rust::String_::fromString($0)"
                    let v786 : string = Fable.Core.RustInterop.emitRustExpr v780 v785 
                    let v787 : string = $"! {v786}"
                    if v5 then
                        let v788 : unit = ()
                        let v789 : (unit -> unit) = closure51(v787)
                        let v790 : unit = (fun () -> v789 (); v788) ()
                        ()
                    else
                        let v832 : unit = ()
                        let v833 : (unit -> unit) = closure11(v787)
                        let v834 : unit = (fun () -> v833 (); v832) ()
                        ()
                    let v836 : string = $"\u001b[4;7m{v780}\u001b[0m"
                    let v837 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v838 : string = "&*$0"
                    let v839 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v836 v838 
                    let _v837 = v839 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v840 : string = "&*$0"
                    let v841 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v836 v840 
                    let _v837 = v841 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v842 : string = "&*$0"
                    let v843 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v836 v842 
                    let _v837 = v843 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v844 : Ref<Str> = v836 |> unbox<Ref<Str>>
                    let _v837 = v844 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v847 : Ref<Str> = v836 |> unbox<Ref<Str>>
                    let _v837 = v847 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v850 : Ref<Str> = v836 |> unbox<Ref<Str>>
                    let _v837 = v850 
                    #endif
#else
                    let v853 : Ref<Str> = v836 |> unbox<Ref<Str>>
                    let _v837 = v853 
                    #endif
                    let v856 : Ref<Str> = _v837 
                    let v861 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v862 : string = "String::from($0)"
                    let v863 : std_string_String = Fable.Core.RustInterop.emitRustExpr v856 v862 
                    let _v861 = v863 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v864 : string = "String::from($0)"
                    let v865 : std_string_String = Fable.Core.RustInterop.emitRustExpr v856 v864 
                    let _v861 = v865 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v866 : string = "String::from($0)"
                    let v867 : std_string_String = Fable.Core.RustInterop.emitRustExpr v856 v866 
                    let _v861 = v867 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v868 : std_string_String = v856 |> unbox<std_string_String>
                    let _v861 = v868 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v871 : std_string_String = v856 |> unbox<std_string_String>
                    let _v861 = v871 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v874 : std_string_String = v856 |> unbox<std_string_String>
                    let _v861 = v874 
                    #endif
#else
                    let v877 : std_string_String = v856 |> unbox<std_string_String>
                    let _v861 = v877 
                    #endif
                    let v880 : std_string_String = _v861 
                    v880
            let v979 : string = "$0"
            let v980 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v716 v979 
            let v981 : string = "v980.lock()"
            let v982 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v981 
            let v983 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v984 : string = "$0.unwrap()"
            let v985 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v982 v984 
            let _v983 = v985 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v986 : string = "$0.unwrap()"
            let v987 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v982 v986 
            let _v983 = v987 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v988 : string = "$0.unwrap()"
            let v989 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v982 v988 
            let _v983 = v989 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v990 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v982 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v983 = v990 
            #endif
#if FABLE_COMPILER_PYTHON
            let v991 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v982 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v983 = v991 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v992 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v982 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v983 = v992 
            #endif
#else
            let v993 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v982 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v983 = v993 
            #endif
            let v994 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = _v983 
            let v997 : string = "&$0"
            let v998 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v994 v997 
            let v999 : string = "$0.send($1)"
            let v1000 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v998, v978) v999 
            let v1001 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method123()
            let v1002 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1003 : string = "$0.map_err(|x| $1(x))"
            let v1004 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1000, v1001) v1003 
            let _v1002 = v1004 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1005 : string = "$0.map_err(|x| $1(x))"
            let v1006 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1000, v1001) v1005 
            let _v1002 = v1006 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1007 : string = "$0.map_err(|x| $1(x))"
            let v1008 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1000, v1001) v1007 
            let _v1002 = v1008 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1009 : Result<unit, std_string_String> = match v1000 with Ok x -> Ok x | Error x -> Error (v1001 x)
            let _v1002 = v1009 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1010 : Result<unit, std_string_String> = match v1000 with Ok x -> Ok x | Error x -> Error (v1001 x)
            let _v1002 = v1010 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1011 : Result<unit, std_string_String> = match v1000 with Ok x -> Ok x | Error x -> Error (v1001 x)
            let _v1002 = v1011 
            #endif
#else
            let v1012 : Result<unit, std_string_String> = match v1000 with Ok x -> Ok x | Error x -> Error (v1001 x)
            let _v1002 = v1012 
            #endif
            let v1013 : Result<unit, std_string_String> = _v1002 
            let v1016 : string = "$0"
            let v1017 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v1013 v1016 
            let v1018 : string = "true; $0 }); //"
            let v1019 : bool = Fable.Core.RustInterop.emitRustExpr v1017 v1018 
            let v1020 : string = "_iter_try_for_each.map_err(|x| x.into())"
            let v1021 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v1020 
            let v1022 : Result<unit, string> = method124(v1021)
            let v1023 : string = v681 + v682 
            let v1024 : _ = v1022 
            let v1025 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1026 : string = $"true; let v1024 = $0"
            let v1027 : bool = Fable.Core.RustInterop.emitRustExpr v1024 v1026 
            let _v1025 = v1027 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1028 : string = $"true; let v1024 = $0"
            let v1029 : bool = Fable.Core.RustInterop.emitRustExpr v1024 v1028 
            let _v1025 = v1029 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1030 : string = $"true; let v1024 = $0"
            let v1031 : bool = Fable.Core.RustInterop.emitRustExpr v1024 v1030 
            let _v1025 = v1031 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1032 : bool = true
            let _v1025 = v1032 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1033 : bool = true
            let _v1025 = v1033 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1034 : bool = true
            let _v1025 = v1034 
            #endif
#else
            let v1035 : bool = true
            let _v1025 = v1035 
            #endif
            let v1036 : bool = _v1025 
            let v1039 : string = $"true; v1024 " + v1023 + "); " + v681 + " // rust.fix_closure'"
            let v1040 : bool = Fable.Core.RustInterop.emitRustExpr () v1039 
            let v1041 : string = "__spawn"
            let v1042 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v1041 
            let v1043 : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US26) = method125()
            let v1044 : US26 option = v4 |> Option.map v1043 
            let v1055 : US26 = US26_1
            let v1056 : US26 = v1044 |> Option.defaultValue v1055 
            match v1056 with
            | US26_1 -> (* None *)
                ()
            | US26_0(v1060) -> (* Some *)
                let v1061 : string = "$0"
                let v1062 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v387 v1061 
                let v1063 : string = "v1062.lock()"
                let v1064 : Result<std_sync_MutexGuard<std_process_ChildStdin option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin option>>> = Fable.Core.RustInterop.emitRustExpr () v1063 
                let v1065 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1066 : string = "$0.unwrap()"
                let v1067 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1064 v1066 
                let _v1065 = v1067 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1068 : string = "$0.unwrap()"
                let v1069 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1064 v1068 
                let _v1065 = v1069 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1070 : string = "$0.unwrap()"
                let v1071 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1064 v1070 
                let _v1065 = v1071 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1072 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1064 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _v1065 = v1072 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1073 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1064 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _v1065 = v1073 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v1074 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1064 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _v1065 = v1074 
                #endif
#else
                let v1075 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1064 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _v1065 = v1075 
                #endif
                let v1076 : std_sync_MutexGuard<std_process_ChildStdin option> = _v1065 
                let v1079 : std_sync_MutexGuard<std_process_ChildStdin option> = method126(v1076)
                let v1080 : string = "true; let mut v1079 = v1079"
                let v1081 : bool = Fable.Core.RustInterop.emitRustExpr () v1080 
                let v1082 : string = "&mut $0"
                let v1083 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v1079 v1082 
                let v1084 : string = "Option::take($0)"
                let v1085 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v1083 v1084 
                let v1086 : string = "true; let _optionm_map_ = $0.map(|x| { //"
                let v1087 : bool = Fable.Core.RustInterop.emitRustExpr v1085 v1086 
                let v1088 : string = "x"
                let v1089 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr () v1088 
                let v1090 : string = "std::sync::Mutex::new(v1089)"
                let v1091 : std_sync_Mutex<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr () v1090 
                let v1092 : string = "std::sync::Arc::new(v1091)"
                let v1093 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr () v1092 
                let v1094 : string = "true; $0 })"
                let v1095 : bool = Fable.Core.RustInterop.emitRustExpr v1093 v1094 
                let v1096 : string = "_optionm_map_"
                let v1097 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> option = Fable.Core.RustInterop.emitRustExpr () v1096 
                let v1098 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US27) = method127()
                let v1099 : US27 option = v1097 |> Option.map v1098 
                let v1110 : US27 = US27_1
                let v1111 : US27 = v1099 |> Option.defaultValue v1110 
                match v1111 with
                | US27_1 -> (* None *)
                    ()
                | US27_0(v1115) -> (* Some *)
                    v1060 v1115
                    let v1116 : string = "$0"
                    let v1117 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr v1115 v1116 
                    let v1118 : string = "v1117.lock()"
                    let v1119 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr () v1118 
                    let v1120 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1121 : string = "$0.unwrap()"
                    let v1122 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1119 v1121 
                    let _v1120 = v1122 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1123 : string = "$0.unwrap()"
                    let v1124 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1119 v1123 
                    let _v1120 = v1124 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1125 : string = "$0.unwrap()"
                    let v1126 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1119 v1125 
                    let _v1120 = v1126 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1127 : std_sync_MutexGuard<std_process_ChildStdin> = match v1119 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v1120 = v1127 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1128 : std_sync_MutexGuard<std_process_ChildStdin> = match v1119 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v1120 = v1128 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1129 : std_sync_MutexGuard<std_process_ChildStdin> = match v1119 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v1120 = v1129 
                    #endif
#else
                    let v1130 : std_sync_MutexGuard<std_process_ChildStdin> = match v1119 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v1120 = v1130 
                    #endif
                    let v1131 : std_sync_MutexGuard<std_process_ChildStdin> = _v1120 
                    let v1134 : std_sync_MutexGuard<std_process_ChildStdin> = method128(v1131)
                    let v1135 : string = "true; let mut v1134 = v1134"
                    let v1136 : bool = Fable.Core.RustInterop.emitRustExpr () v1135 
                    let v1137 : string = "true; std::io::Write::flush(&mut *$0).unwrap()"
                    let v1138 : bool = Fable.Core.RustInterop.emitRustExpr v1134 v1137 
                    ()
            let v1139 : string = "$0"
            let v1140 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v261 v1139 
            let v1141 : string = "v1140.lock()"
            let v1142 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v1141 
            let v1143 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1144 : string = "$0.unwrap()"
            let v1145 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1142 v1144 
            let _v1143 = v1145 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1146 : string = "$0.unwrap()"
            let v1147 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1142 v1146 
            let _v1143 = v1147 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1148 : string = "$0.unwrap()"
            let v1149 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1142 v1148 
            let _v1143 = v1149 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1150 : std_sync_MutexGuard<std_process_Child option> = match v1142 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v1143 = v1150 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1151 : std_sync_MutexGuard<std_process_Child option> = match v1142 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v1143 = v1151 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1152 : std_sync_MutexGuard<std_process_Child option> = match v1142 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v1143 = v1152 
            #endif
#else
            let v1153 : std_sync_MutexGuard<std_process_Child option> = match v1142 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v1143 = v1153 
            #endif
            let v1154 : std_sync_MutexGuard<std_process_Child option> = _v1143 
            let v1157 : std_sync_MutexGuard<std_process_Child option> = method111(v1154)
            let v1158 : string = "true; let mut v1157 = v1157"
            let v1159 : bool = Fable.Core.RustInterop.emitRustExpr () v1158 
            let v1160 : string = "&mut $0"
            let v1161 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v1157 v1160 
            let v1162 : string = "Option::take($0)"
            let v1163 : std_process_Child option = Fable.Core.RustInterop.emitRustExpr v1161 v1162 
            let v1164 : string = "$0.unwrap()"
            let v1165 : std_process_Child = Fable.Core.RustInterop.emitRustExpr v1163 v1164 
            let v1166 : string = "$0.wait_with_output()"
            let v1167 : Result<std_process_Output, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1165 v1166 
            let v1168 : (std_io_Error -> std_string_String) = method65()
            let v1169 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1170 : string = "$0.map_err(|x| $1(x))"
            let v1171 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1167, v1168) v1170 
            let _v1169 = v1171 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1172 : string = "$0.map_err(|x| $1(x))"
            let v1173 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1167, v1168) v1172 
            let _v1169 = v1173 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1174 : string = "$0.map_err(|x| $1(x))"
            let v1175 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1167, v1168) v1174 
            let _v1169 = v1175 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1176 : Result<std_process_Output, std_string_String> = match v1167 with Ok x -> Ok x | Error x -> Error (v1168 x)
            let _v1169 = v1176 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1177 : Result<std_process_Output, std_string_String> = match v1167 with Ok x -> Ok x | Error x -> Error (v1168 x)
            let _v1169 = v1177 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1178 : Result<std_process_Output, std_string_String> = match v1167 with Ok x -> Ok x | Error x -> Error (v1168 x)
            let _v1169 = v1178 
            #endif
#else
            let v1179 : Result<std_process_Output, std_string_String> = match v1167 with Ok x -> Ok x | Error x -> Error (v1168 x)
            let _v1169 = v1179 
            #endif
            let v1180 : Result<std_process_Output, std_string_String> = _v1169 
            let v1183 : std_thread_JoinHandle<Result<unit, string>> = method129(v1042)
            let v1184 : string = "v1183"
            let v1185 : string = v1184 + v681 
            let v1186 : string = v1185 + v681 
            let v1187 : std_thread_JoinHandle<Result<unit, string>> = method129(v702)
            let v1188 : string = "v1187"
            let v1189 : string = ", "
            let v1190 : string = v1188 + v1189 
            let v1191 : string = v1190 + v1186 
            let v1192 : string = "vec![" + v1191 + "]"
            let v1193 : Vec<std_thread_JoinHandle<Result<unit, string>>> = Fable.Core.RustInterop.emitRustExpr () v1192 
            let v1194 : string = "true; $0.into_iter().for_each(|x| { //"
            let v1195 : bool = Fable.Core.RustInterop.emitRustExpr v1193 v1194 
            let v1196 : string = "x"
            let v1197 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v1196 
            let v1198 : string = "std::thread::JoinHandle::join($0)"
            let v1199 : Result<Result<unit, string>, Box<LifetimeRef<Dyn<LifetimeJoin<core_any_Any, LifetimeRef<LifetimeJoin<StaticLifetime, Send<StaticLifetime>>>>>>>> = Fable.Core.RustInterop.emitRustExpr v1197 v1198 
            let v1200 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1201 : string = "$0.unwrap()"
            let v1202 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1199 v1201 
            let _v1200 = v1202 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1203 : string = "$0.unwrap()"
            let v1204 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1199 v1203 
            let _v1200 = v1204 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1205 : string = "$0.unwrap()"
            let v1206 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1199 v1205 
            let _v1200 = v1206 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1207 : Result<unit, string> = match v1199 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v1200 = v1207 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1208 : Result<unit, string> = match v1199 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v1200 = v1208 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1209 : Result<unit, string> = match v1199 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v1200 = v1209 
            #endif
#else
            let v1210 : Result<unit, string> = match v1199 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v1200 = v1210 
            #endif
            let v1211 : Result<unit, string> = _v1200 
            let v1214 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1215 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1211 v1215 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1216 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1211 v1216 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1217 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1211 v1217 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            match v1211 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#if FABLE_COMPILER_PYTHON
            match v1211 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            match v1211 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#else
            match v1211 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
            // run_target_args' is_unit
            let v1218 : string = $"true"
            let v1219 : bool = Fable.Core.RustInterop.emitRustExpr () v1218 
            let v1220 : string = "true; }}); { //"
            let v1221 : bool = Fable.Core.RustInterop.emitRustExpr () v1220 
            let v1222 : (std_process_Output -> US28) = method130()
            let v1223 : (std_string_String -> US28) = method131()
            let v1224 : US28 = match v1180 with Ok x -> v1222 x | Error x -> v1223 x
            match v1224 with
            | US28_1(v1307) -> (* Error *)
                let v1308 : unit = ()
                let v1309 : (unit -> unit) = closure57(v1307)
                let v1310 : unit = (fun () -> v1309 (); v1308) ()
                let v1350 : US6 = US6_0(v1307)
                let v1351 : US24 = US24_1
                struct (-2, v1350, v1351)
            | US28_0(v1225) -> (* Ok *)
                let v1226 : string = "$0.status"
                let v1227 : std_process_ExitStatus = Fable.Core.RustInterop.emitRustExpr v1225 v1226 
                let v1228 : string = "$0.code()"
                let v1229 : int32 option = Fable.Core.RustInterop.emitRustExpr v1227 v1228 
                let v1230 : (int32 -> US29) = method133()
                let v1231 : US29 option = v1229 |> Option.map v1230 
                let v1242 : US29 = US29_1
                let v1243 : US29 = v1231 |> Option.defaultValue v1242 
                match v1243 with
                | US29_1 -> (* None *)
                    let v1250 : string = "runtime.execute_with_options / exit_code=None"
                    let v1251 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1252 : string = "&*$0"
                    let v1253 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1250 v1252 
                    let _v1251 = v1253 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1254 : string = "&*$0"
                    let v1255 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1250 v1254 
                    let _v1251 = v1255 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1256 : string = "&*$0"
                    let v1257 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1250 v1256 
                    let _v1251 = v1257 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1258 : Ref<Str> = v1250 |> unbox<Ref<Str>>
                    let _v1251 = v1258 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1261 : Ref<Str> = v1250 |> unbox<Ref<Str>>
                    let _v1251 = v1261 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1264 : Ref<Str> = v1250 |> unbox<Ref<Str>>
                    let _v1251 = v1264 
                    #endif
#else
                    let v1267 : Ref<Str> = v1250 |> unbox<Ref<Str>>
                    let _v1251 = v1267 
                    #endif
                    let v1270 : Ref<Str> = _v1251 
                    let v1275 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1276 : string = "String::from($0)"
                    let v1277 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1270 v1276 
                    let _v1275 = v1277 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1278 : string = "String::from($0)"
                    let v1279 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1270 v1278 
                    let _v1275 = v1279 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1280 : string = "String::from($0)"
                    let v1281 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1270 v1280 
                    let _v1275 = v1281 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1282 : std_string_String = v1270 |> unbox<std_string_String>
                    let _v1275 = v1282 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1285 : std_string_String = v1270 |> unbox<std_string_String>
                    let _v1275 = v1285 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1288 : std_string_String = v1270 |> unbox<std_string_String>
                    let _v1275 = v1288 
                    #endif
#else
                    let v1291 : std_string_String = v1270 |> unbox<std_string_String>
                    let _v1275 = v1291 
                    #endif
                    let v1294 : std_string_String = _v1275 
                    let v1299 : US6 = US6_0(v1294)
                    let v1300 : US24 = US24_0(v408)
                    struct (-1, v1299, v1300)
                | US29_0(v1247) -> (* Some *)
                    let v1248 : US6 = US6_1
                    let v1249 : US24 = US24_0(v408)
                    struct (v1247, v1248, v1249)
    let v1415 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option =
        match v1408 with
        | US24_1 -> (* None *)
            let v1413 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = None
            v1413
        | US24_0(v1409) -> (* Some *)
            let v1410 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = Some v1409 
            v1410
    let v1416 : string = "true; let _optionm_map_ = $0.map(|x| { //"
    let v1417 : bool = Fable.Core.RustInterop.emitRustExpr v1415 v1416 
    let v1418 : string = "x"
    let v1419 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v1418 
    let v1420 : string = "$0"
    let v1421 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr v1419 v1420 
    let v1422 : string = "v1421.lock()"
    let v1423 : Result<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v1422 
    let v1424 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1425 : string = "$0.unwrap()"
    let v1426 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v1423 v1425 
    let _v1424 = v1426 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1427 : string = "$0.unwrap()"
    let v1428 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v1423 v1427 
    let _v1424 = v1428 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1429 : string = "$0.unwrap()"
    let v1430 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v1423 v1429 
    let _v1424 = v1430 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1431 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1423 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v1424 = v1431 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1432 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1423 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v1424 = v1432 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1433 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1423 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v1424 = v1433 
    #endif
#else
    let v1434 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1423 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v1424 = v1434 
    #endif
    let v1435 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = _v1424 
    let v1438 : string = "$0.iter()"
    let v1439 : _ = Fable.Core.RustInterop.emitRustExpr v1435 v1438 
    let v1440 : string = "$0.collect::<Vec<_>>()"
    let v1441 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v1439 v1440 
    let v1442 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v1443 : bool = Fable.Core.RustInterop.emitRustExpr v1441 v1442 
    let v1444 : string = "x"
    let v1445 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1444 
    let v1446 : string = "fable_library_rust::String_::fromString($0)"
    let v1447 : string = Fable.Core.RustInterop.emitRustExpr v1445 v1446 
    let v1448 : string = "true; $0 }).collect::<Vec<_>>()"
    let v1449 : bool = Fable.Core.RustInterop.emitRustExpr v1447 v1448 
    let v1450 : string = "_vec_map"
    let v1451 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v1450 
    let v1452 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v1453 : (string []) = Fable.Core.RustInterop.emitRustExpr v1451 v1452 
    let v1454 : string seq = v1453 |> Seq.ofArray
    let v1457 : string = method134()
    let v1458 : (string -> (string seq -> string)) = String.concat
    let v1459 : (string seq -> string) = v1458 v1457
    let v1460 : string = v1459 v1454
    let v1464 : string = "true; $0 })"
    let v1465 : bool = Fable.Core.RustInterop.emitRustExpr v1460 v1464 
    let v1466 : string = "_optionm_map_"
    let v1467 : string option = Fable.Core.RustInterop.emitRustExpr () v1466 
    let v1474 : US5 =
        match v1407 with
        | US6_1 -> (* None *)
            US5_1
        | US6_0(v1468) -> (* Some *)
            let v1469 : string = "fable_library_rust::String_::fromString($0)"
            let v1470 : string = Fable.Core.RustInterop.emitRustExpr v1468 v1469 
            US5_0(v1470)
    let v1478 : string =
        match v1474 with
        | US5_1 -> (* None *)
            let v1476 : string = ""
            v1476
        | US5_0(v1475) -> (* Some *)
            v1475
    let v1479 : string = v1467 |> Option.defaultValue v1478 
    let v1482 : unit = ()
    let v1483 : (unit -> unit) = closure59(v1406, v1479)
    let v1484 : unit = (fun () -> v1483 (); v1482) ()
    let v1525 : (int32 * string) = v1406, v1479 
    v1525 
    )
    |> fun x -> x ()
    ) () )
    |> fun x -> _v138 <- Some x
    let v1526 : (int32 * string) = match _v138 with Some x -> x | None -> failwith "base.capture / _v138=None"
    let (a, b) = v1526 
    let v2913 : int32 = a
    let v2914 : string = b
    let _v7 = struct (v2913, v2914) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v2919 : int32, v2920 : string) = null |> unbox<struct (int32 * string)>
    let _v7 = struct (v2919, v2920) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v2925 : int32, v2926 : string) = null |> unbox<struct (int32 * string)>
    let _v7 = struct (v2925, v2926) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v2931 : int32, v2932 : string) = null |> unbox<struct (int32 * string)>
    let _v7 = struct (v2931, v2932) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v2937 : int32, v2938 : string) = null |> unbox<struct (int32 * string)>
    let _v7 = struct (v2937, v2938) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v2943 : int32, v2944 : string) = null |> unbox<struct (int32 * string)>
    let _v7 = struct (v2943, v2944) 
    #endif
#else
    let v2949 : Async<struct (int32 * string)> = method137(v0, v1, v2, v3, v4, v5, v6)
    let v2950 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v2951 : int32, v2952 : string) = null |> unbox<struct (int32 * string)>
    let _v2950 = struct (v2951, v2952) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v2957 : int32, v2958 : string) = null |> unbox<struct (int32 * string)>
    let _v2950 = struct (v2957, v2958) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v2963 : int32, v2964 : string) = null |> unbox<struct (int32 * string)>
    let _v2950 = struct (v2963, v2964) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v2969 : int32, v2970 : string) = null |> unbox<struct (int32 * string)>
    let _v2950 = struct (v2969, v2970) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2975 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v2976 : int32, v2977 : string) = v2975 v2949
    let _v2950 = struct (v2976, v2977) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v2978 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v2979 : int32, v2980 : string) = v2978 v2949
    let _v2950 = struct (v2979, v2980) 
    #endif
#else
    let v2981 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v2982 : int32, v2983 : string) = v2981 v2949
    let _v2950 = struct (v2982, v2983) 
    #endif
    let struct (v2984 : int32, v2985 : string) = _v2950 
    let _v7 = struct (v2984, v2985) 
    #endif
    let struct (v2994 : int32, v2995 : string) = _v7 
    struct (v2994, v2995)
and method156 (v0 : string, v1 : string, v2 : string) : struct (string * string) =
    let v3 : string = method45(v1)
    let v4 : string = method26(v2, v3)
    let v5 : string = "."
    let v6 : int32 = v1.LastIndexOf v5 
    let v7 : int32 = v6 - 1
    let v8 : string = v1.[int 0..int v7]
    let v12 : int32 = v4.LastIndexOf v5 
    let v13 : int32 = v12 - 1
    let v14 : string = v4.[int 0..int v13]
    let v18 : string = ".md"
    let v19 : bool = v0.EndsWith (v18, false, null)
    let v22 : bool = v19 = false
    let v25 : string =
        if v22 then
            let v23 : string = $"{v1}.{v0}"
            v23
        else
            let v24 : string = $"{v8}.{v0}"
            v24
    let v28 : string =
        if v22 then
            let v26 : string = $"{v4}.{v0}"
            v26
        else
            let v27 : string = $"{v14}.{v0}"
            v27
    struct (v25, v28)
and method157 () : string =
    let v0 : string = ""
    v0
and closure69 () (v0 : string) : US33 =
    US33_0(v0)
and method158 () : (string -> US33) =
    closure69()
and closure70 () (v0 : std_string_String) : US33 =
    US33_1(v0)
and method159 () : (std_string_String -> US33) =
    closure70()
and method160 (v0 : string) : bool =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "&*$0"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let _v2 = v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = "&*$0"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v5 
    let _v2 = v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = "&*$0"
    let v8 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v7 
    let _v2 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v12 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v12 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v15 
    #endif
#else
    let v18 : Ref<Str> = v0 |> unbox<Ref<Str>>
    let _v2 = v18 
    #endif
    let v21 : Ref<Str> = _v2 
    let v26 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = "String::from($0)"
    let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v27 
    let _v26 = v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "String::from($0)"
    let v30 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v29 
    let _v26 = v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = "String::from($0)"
    let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v31 
    let _v26 = v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v36 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v36 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v39 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v39 
    #endif
#else
    let v42 : std_string_String = v21 |> unbox<std_string_String>
    let _v26 = v42 
    #endif
    let v45 : std_string_String = _v26 
    let v50 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v51 : string = "std::path::PathBuf::from($0)"
    let v52 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v51 
    let _v50 = v52 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v53 : string = "std::path::PathBuf::from($0)"
    let v54 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v53 
    let _v50 = v54 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v55 : string = "std::path::PathBuf::from($0)"
    let v56 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v45 v55 
    let _v50 = v56 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v57 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v57 
    #endif
#if FABLE_COMPILER_PYTHON
    let v60 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v60 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v63 
    #endif
#else
    let v66 : std_path_PathBuf = v45 |> unbox<std_path_PathBuf>
    let _v50 = v66 
    #endif
    let v69 : std_path_PathBuf = _v50 
    let v74 : string = "$0.exists()"
    let v75 : bool = Fable.Core.RustInterop.emitRustExpr v69 v74 
    let v78 : bool =
        if v75 then
            let v76 : string = "$0.is_file()"
            let v77 : bool = Fable.Core.RustInterop.emitRustExpr v69 v76 
            v77
        else
            false
    let _v1 = v78 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v79 : bool = null |> unbox<bool>
    let _v1 = v79 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v82 : bool = null |> unbox<bool>
    let _v1 = v82 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v85 : string = "fs"
    let v86 : IFsExistsSync = Fable.Core.JsInterop.importAll v85 
    let v87 : string = "$0.existsSync($1)"
    let v88 : bool = Fable.Core.JsInterop.emitJsExpr struct (v86, v0) v87 
    let _v1 = v88 
    #endif
#if FABLE_COMPILER_PYTHON
    let v89 : bool = null |> unbox<bool>
    let _v1 = v89 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v92 : bool = null |> unbox<bool>
    let _v1 = v92 
    #endif
#else
    let v95 : (string -> bool) = System.IO.File.Exists
    let v96 : bool = v95 v0
    let _v1 = v96 
    #endif
    let v97 : bool = _v1 
    v97
and method162 (v0 : string, v1 : string, v2 : string, v3 : int32, v4 : string, v5 : int32, v6 : string, v7 : string, v8 : US5, v9 : string, v10 : string) : string =
    let v11 : string = method14()
    let v12 : Mut3 = {l0 = v11} : Mut3
    let v13 : string = "{ "
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure8(v12, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = "file"
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure8(v12, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = " = "
    let v32 : string = $"{v31}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure8(v12, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = $"{v0}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure8(v12, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "; "
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure8(v12, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = "real_path"
    let v58 : string = $"{v57}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure8(v12, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v31}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure8(v12, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v1}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure8(v12, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = $"{v48}"
    let v85 : unit = ()
    let v86 : (unit -> unit) = closure8(v12, v82)
    let v87 : unit = (fun () -> v86 (); v85) ()
    let v90 : string = "relative_path"
    let v91 : string = $"{v90}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure8(v12, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v31}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure8(v12, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = $"{v2}"
    let v110 : unit = ()
    let v111 : (unit -> unit) = closure8(v12, v107)
    let v112 : unit = (fun () -> v111 (); v110) ()
    let v115 : string = $"{v48}"
    let v118 : unit = ()
    let v119 : (unit -> unit) = closure8(v12, v115)
    let v120 : unit = (fun () -> v119 (); v118) ()
    let v123 : string = "origin_hash_exit_code"
    let v124 : string = $"{v123}"
    let v127 : unit = ()
    let v128 : (unit -> unit) = closure8(v12, v124)
    let v129 : unit = (fun () -> v128 (); v127) ()
    let v132 : string = $"{v31}"
    let v135 : unit = ()
    let v136 : (unit -> unit) = closure8(v12, v132)
    let v137 : unit = (fun () -> v136 (); v135) ()
    let v140 : string = $"{v3}"
    let v143 : unit = ()
    let v144 : (unit -> unit) = closure8(v12, v140)
    let v145 : unit = (fun () -> v144 (); v143) ()
    let v148 : string = $"{v48}"
    let v151 : unit = ()
    let v152 : (unit -> unit) = closure8(v12, v148)
    let v153 : unit = (fun () -> v152 (); v151) ()
    let v156 : string = "origin_hash"
    let v157 : string = $"{v156}"
    let v160 : unit = ()
    let v161 : (unit -> unit) = closure8(v12, v157)
    let v162 : unit = (fun () -> v161 (); v160) ()
    let v165 : string = $"{v31}"
    let v168 : unit = ()
    let v169 : (unit -> unit) = closure8(v12, v165)
    let v170 : unit = (fun () -> v169 (); v168) ()
    let v173 : string = $"{v4}"
    let v176 : unit = ()
    let v177 : (unit -> unit) = closure8(v12, v173)
    let v178 : unit = (fun () -> v177 (); v176) ()
    let v181 : string = $"{v48}"
    let v184 : unit = ()
    let v185 : (unit -> unit) = closure8(v12, v181)
    let v186 : unit = (fun () -> v185 (); v184) ()
    let v189 : string = "local_git_hash_exit_code"
    let v190 : string = $"{v189}"
    let v193 : unit = ()
    let v194 : (unit -> unit) = closure8(v12, v190)
    let v195 : unit = (fun () -> v194 (); v193) ()
    let v198 : string = $"{v31}"
    let v201 : unit = ()
    let v202 : (unit -> unit) = closure8(v12, v198)
    let v203 : unit = (fun () -> v202 (); v201) ()
    let v206 : string = $"{v5}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure8(v12, v206)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v214 : string = $"{v48}"
    let v217 : unit = ()
    let v218 : (unit -> unit) = closure8(v12, v214)
    let v219 : unit = (fun () -> v218 (); v217) ()
    let v222 : string = "local_git_hash"
    let v223 : string = $"{v222}"
    let v226 : unit = ()
    let v227 : (unit -> unit) = closure8(v12, v223)
    let v228 : unit = (fun () -> v227 (); v226) ()
    let v231 : string = $"{v31}"
    let v234 : unit = ()
    let v235 : (unit -> unit) = closure8(v12, v231)
    let v236 : unit = (fun () -> v235 (); v234) ()
    let v239 : string = $"{v6}"
    let v242 : unit = ()
    let v243 : (unit -> unit) = closure8(v12, v239)
    let v244 : unit = (fun () -> v243 (); v242) ()
    let v247 : string = $"{v48}"
    let v250 : unit = ()
    let v251 : (unit -> unit) = closure8(v12, v247)
    let v252 : unit = (fun () -> v251 (); v250) ()
    let v255 : string = "hash1"
    let v256 : string = $"{v255}"
    let v259 : unit = ()
    let v260 : (unit -> unit) = closure8(v12, v256)
    let v261 : unit = (fun () -> v260 (); v259) ()
    let v264 : string = $"{v31}"
    let v267 : unit = ()
    let v268 : (unit -> unit) = closure8(v12, v264)
    let v269 : unit = (fun () -> v268 (); v267) ()
    let v272 : string = $"{v7}"
    let v275 : unit = ()
    let v276 : (unit -> unit) = closure8(v12, v272)
    let v277 : unit = (fun () -> v276 (); v275) ()
    let v280 : string = $"{v48}"
    let v283 : unit = ()
    let v284 : (unit -> unit) = closure8(v12, v280)
    let v285 : unit = (fun () -> v284 (); v283) ()
    let v288 : string = "hash2"
    let v289 : string = $"{v288}"
    let v292 : unit = ()
    let v293 : (unit -> unit) = closure8(v12, v289)
    let v294 : unit = (fun () -> v293 (); v292) ()
    let v297 : string = $"{v31}"
    let v300 : unit = ()
    let v301 : (unit -> unit) = closure8(v12, v297)
    let v302 : unit = (fun () -> v301 (); v300) ()
    let v305 : string = $"%A{v8}"
    let v308 : string = $"{v305}"
    let v311 : unit = ()
    let v312 : (unit -> unit) = closure8(v12, v308)
    let v313 : unit = (fun () -> v312 (); v311) ()
    let v316 : string = $"{v48}"
    let v319 : unit = ()
    let v320 : (unit -> unit) = closure8(v12, v316)
    let v321 : unit = (fun () -> v320 (); v319) ()
    let v324 : string = "dist_path"
    let v325 : string = $"{v324}"
    let v328 : unit = ()
    let v329 : (unit -> unit) = closure8(v12, v325)
    let v330 : unit = (fun () -> v329 (); v328) ()
    let v333 : string = $"{v31}"
    let v336 : unit = ()
    let v337 : (unit -> unit) = closure8(v12, v333)
    let v338 : unit = (fun () -> v337 (); v336) ()
    let v341 : string = $"{v9}"
    let v344 : unit = ()
    let v345 : (unit -> unit) = closure8(v12, v341)
    let v346 : unit = (fun () -> v345 (); v344) ()
    let v349 : string = $"{v48}"
    let v352 : unit = ()
    let v353 : (unit -> unit) = closure8(v12, v349)
    let v354 : unit = (fun () -> v353 (); v352) ()
    let v357 : string = "cache_path"
    let v358 : string = $"{v357}"
    let v361 : unit = ()
    let v362 : (unit -> unit) = closure8(v12, v358)
    let v363 : unit = (fun () -> v362 (); v361) ()
    let v366 : string = $"{v31}"
    let v369 : unit = ()
    let v370 : (unit -> unit) = closure8(v12, v366)
    let v371 : unit = (fun () -> v370 (); v369) ()
    let v374 : string = $"{v10}"
    let v377 : unit = ()
    let v378 : (unit -> unit) = closure8(v12, v374)
    let v379 : unit = (fun () -> v378 (); v377) ()
    let v382 : string = " }"
    let v383 : string = $"{v382}"
    let v386 : unit = ()
    let v387 : (unit -> unit) = closure8(v12, v383)
    let v388 : unit = (fun () -> v387 (); v386) ()
    let v391 : string = v12.l0
    v391
and method161 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : string, v12 : int32, v13 : string, v14 : int32, v15 : string, v16 : string, v17 : US5, v18 : string, v19 : string) : string =
    let v20 : string = method162(v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19)
    let v21 : int64 = v0.l0
    let v22 : string = $"{v6} {v7} #{v21} %s{v8} / {v20}"
    method18(v22)
and closure71 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : int32, v5 : string, v6 : string, v7 : int32, v8 : string, v9 : string, v10 : US5) () : unit =
    let v11 : US0 = US0_2
    let v12 : bool = method7(v11)
    if v12 then
        let v13 : unit = ()
        let v14 : (unit -> unit) = closure6()
        let v15 : unit = (fun () -> v14 (); v13) ()
        let struct (v29 : Mut0, v30 : Mut1, v31 : Mut2, v32 : Mut3, v33 : Mut4, v34 : int64 option) = TraceState.trace_state.Value
        let v47 : string = method8(v29, v30, v31, v32, v33, v34)
        let v48 : string = method12()
        let v49 : string = "documents.run / par_map"
        let v50 : string = " / origin_hash |> sm'.contains local_git_hash |> not"
        let v51 : string = v49 + v50 
        let v52 : string = " / Some hash2 when hash1 = hash2"
        let v53 : string = v51 + v52 
        let v54 : bool = v53 = ""
        let v57 : string =
            if v54 then
                let v55 : string = ""
                v55
            else
                method161(v29, v30, v31, v32, v33, v34, v47, v48, v53, v1, v2, v0, v4, v3, v7, v6, v9, v10, v5, v8)
        method19(v57)
and closure72 () (v0 : uint64) : US34 =
    US34_0(v0)
and method164 () : (uint64 -> US34) =
    closure72()
and closure73 () (v0 : std_string_String) : US34 =
    US34_1(v0)
and method165 () : (std_string_String -> US34) =
    closure73()
and method167 (v0 : string, v1 : string, v2 : std_string_String) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "old_path"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure8(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure8(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure8(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure8(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "new_path"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure8(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure8(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure8(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure8(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "error"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure8(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v100 : string = "format!(\"{:#?}\", $0)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v100 
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let _v99 = v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : string = "format!(\"{:#?}\", $0)"
    let v105 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v104 
    let v106 : string = "fable_library_rust::String_::fromString($0)"
    let v107 : string = Fable.Core.RustInterop.emitRustExpr v105 v106 
    let _v99 = v107 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v108 : string = "format!(\"{:#?}\", $0)"
    let v109 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v108 
    let v110 : string = "fable_library_rust::String_::fromString($0)"
    let v111 : string = Fable.Core.RustInterop.emitRustExpr v109 v110 
    let _v99 = v111 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v112 : string = $"%A{v2}"
    let _v99 = v112 
    #endif
#if FABLE_COMPILER_PYTHON
    let v115 : string = $"%A{v2}"
    let _v99 = v115 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v118 : string = $"%A{v2}"
    let _v99 = v118 
    #endif
#else
    let v121 : string = $"%A{v2}"
    let _v99 = v121 
    #endif
    let v124 : string = _v99 
    let v129 : string = $"{v124}"
    let v132 : unit = ()
    let v133 : (unit -> unit) = closure8(v4, v129)
    let v134 : unit = (fun () -> v133 (); v132) ()
    let v137 : string = " }"
    let v138 : string = $"{v137}"
    let v141 : unit = ()
    let v142 : (unit -> unit) = closure8(v4, v138)
    let v143 : unit = (fun () -> v142 (); v141) ()
    let v146 : string = v4.l0
    v146
and method166 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : std_string_String) : string =
    let v11 : string = method167(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "file_system.file_copy"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method18(v14)
and closure74 (v0 : string, v1 : string, v2 : std_string_String) () : unit =
    let v3 : US0 = US0_3
    let v4 : bool = method7(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method8(v21, v22, v23, v24, v25, v26)
        let v40 : string = method31()
        let v41 : string = method166(v21, v22, v23, v24, v25, v26, v39, v40, v1, v0, v2)
        method19(v41)
and method169 (v0 : string, v1 : string, v2 : uint64) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "old_path"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure8(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure8(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure8(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure8(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "new_path"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure8(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure8(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure8(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure8(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "result"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure8(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure8(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure8(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and method168 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : uint64) : string =
    let v11 : string = method169(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "file_system.file_copy"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method18(v14)
and closure75 (v0 : string, v1 : string, v2 : uint64) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method7(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method8(v21, v22, v23, v24, v25, v26)
        let v40 : string = method62()
        let v41 : string = method168(v21, v22, v23, v24, v25, v26, v39, v40, v1, v0, v2)
        method19(v41)
and method163 (v0 : string, v1 : string) : unit =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "std::fs::copy(&*$0, &*$1)"
    let v4 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr struct (v1, v0) v3 
    let v5 : (std_io_Error -> std_string_String) = method65()
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = "$0.map_err(|x| $1(x))"
    let v8 : Result<uint64, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v7 
    let _v6 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : string = "$0.map_err(|x| $1(x))"
    let v10 : Result<uint64, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v9 
    let _v6 = v10 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v11 : string = "$0.map_err(|x| $1(x))"
    let v12 : Result<uint64, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4, v5) v11 
    let _v6 = v12 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : Result<uint64, std_string_String> = match v4 with Ok x -> Ok x | Error x -> Error (v5 x)
    let _v6 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : Result<uint64, std_string_String> = match v4 with Ok x -> Ok x | Error x -> Error (v5 x)
    let _v6 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : Result<uint64, std_string_String> = match v4 with Ok x -> Ok x | Error x -> Error (v5 x)
    let _v6 = v15 
    #endif
#else
    let v16 : Result<uint64, std_string_String> = match v4 with Ok x -> Ok x | Error x -> Error (v5 x)
    let _v6 = v16 
    #endif
    let v17 : Result<uint64, std_string_String> = _v6 
    let v20 : (uint64 -> US34) = method164()
    let v21 : (std_string_String -> US34) = method165()
    let v22 : US34 = match v17 with Ok x -> v20 x | Error x -> v21 x
    match v22 with
    | US34_1(v66) -> (* Error *)
        let v67 : unit = ()
        let v68 : (unit -> unit) = closure74(v0, v1, v66)
        let v69 : unit = (fun () -> v68 (); v67) ()
        ()
    | US34_0(v23) -> (* Ok *)
        let v24 : unit = ()
        let v25 : (unit -> unit) = closure75(v0, v1, v23)
        let v26 : unit = (fun () -> v25 (); v24) ()
        ()
    #endif
#if FABLE_COMPILER_RUST && WASM
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    #endif
#if FABLE_COMPILER_PYTHON
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    #endif
#else
    System.IO.File.Copy (v1, v0, true)
    #endif
    // run_target_args' is_unit
    ()
and method171 (v0 : Vec<uint8>) : Vec<uint8> =
    v0
and method172 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method173 (v0 : string) : string =
    v0
and method174 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure78 (v0 : string) (v1 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : unit =
    let v2 : string = "$0"
    let v3 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : string = "v3.lock()"
    let v5 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr () v4 
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = "$0.unwrap()"
    let v8 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v5 v7 
    let _v6 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : string = "$0.unwrap()"
    let v10 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v5 v9 
    let _v6 = v10 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v11 : string = "$0.unwrap()"
    let v12 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v5 v11 
    let _v6 = v12 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : std_sync_MutexGuard<std_process_ChildStdin> = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v6 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : std_sync_MutexGuard<std_process_ChildStdin> = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v6 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : std_sync_MutexGuard<std_process_ChildStdin> = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v6 = v15 
    #endif
#else
    let v16 : std_sync_MutexGuard<std_process_ChildStdin> = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v6 = v16 
    #endif
    let v17 : std_sync_MutexGuard<std_process_ChildStdin> = _v6 
    let v20 : string = method173(v0)
    let v21 : string = "v20.as_bytes()"
    let v22 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v21 
    let v23 : std_sync_MutexGuard<std_process_ChildStdin> = method174(v17)
    let v24 : string = "true; let mut v23 = v23"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = "true; std::io::Write::write_all(&mut *$0, v22).unwrap()"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr v23 v26 
    ()
and method175 (v0 : int32, v1 : Mut8) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method177 (v0 : int32, v1 : int32, v2 : string) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "exit_code"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure8(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure8(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure8(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure8(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "result_len"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure8(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure8(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure8(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure8(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "output_path"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure8(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure8(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure8(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and method176 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32, v10 : string) : string =
    let v11 : string = method177(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "documents.hangul"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method18(v14)
and closure79 (v0 : string, v1 : int32, v2 : string) () : unit =
    let v3 : US0 = US0_2
    let v4 : bool = method7(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method8(v21, v22, v23, v24, v25, v26)
        let v40 : string = method12()
        let v41 : int32 = v2.Length
        let v42 : string = method176(v21, v22, v23, v24, v25, v26, v39, v40, v1, v41, v0)
        method19(v42)
and method170 (v0 : string, v1 : string, v2 : string, v3 : string) : US35 =
    let v4 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = "std::fs::read(&*$0)"
    let v7 : Result<Vec<uint8>, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v3 v6 
    let v8 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : string = "$0.unwrap()"
    let v10 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v7 v9 
    let _v8 = v10 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : string = "$0.unwrap()"
    let v12 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v7 v11 
    let _v8 = v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v13 : string = "$0.unwrap()"
    let v14 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v7 v13 
    let _v8 = v14 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : Vec<uint8> = match v7 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v8 = v15 
    #endif
#if FABLE_COMPILER_PYTHON
    let v16 : Vec<uint8> = match v7 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v8 = v16 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : Vec<uint8> = match v7 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v8 = v17 
    #endif
#else
    let v18 : Vec<uint8> = match v7 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v8 = v18 
    #endif
    let v19 : Vec<uint8> = _v8 
    let _v5 = v19 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : Vec<uint8> = null |> unbox<Vec<uint8>>
    let _v5 = v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : Vec<uint8> = null |> unbox<Vec<uint8>>
    let _v5 = v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : Vec<uint8> = null |> unbox<Vec<uint8>>
    let _v5 = v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : Vec<uint8> = null |> unbox<Vec<uint8>>
    let _v5 = v31 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v34 : Vec<uint8> = null |> unbox<Vec<uint8>>
    let _v5 = v34 
    #endif
#else
    let v37 : (uint8 []) = v3 |> System.IO.File.ReadAllBytes
    let v38 : string = "$0.to_vec()"
    let v39 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v5 = v39 
    #endif
    let v40 : Vec<uint8> = _v5 
    let v45 : Vec<uint8> = method171(v40)
    let v46 : string = "std::string::String::from_utf8($0)"
    let v47 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr v45 v46 
    let v48 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v49 : string = "$0.unwrap()"
    let v50 : std_string_String = Fable.Core.RustInterop.emitRustExpr v47 v49 
    let _v48 = v50 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v51 : string = "$0.unwrap()"
    let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr v47 v51 
    let _v48 = v52 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v53 : string = "$0.unwrap()"
    let v54 : std_string_String = Fable.Core.RustInterop.emitRustExpr v47 v53 
    let _v48 = v54 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v55 : std_string_String = match v47 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v48 = v55 
    #endif
#if FABLE_COMPILER_PYTHON
    let v56 : std_string_String = match v47 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v48 = v56 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v57 : std_string_String = match v47 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v48 = v57 
    #endif
#else
    let v58 : std_string_String = match v47 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v48 = v58 
    #endif
    let v59 : std_string_String = _v48 
    let v62 : string = "fable_library_rust::String_::fromString($0)"
    let v63 : string = Fable.Core.RustInterop.emitRustExpr v59 v62 
    let _v4 = v63 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v64 : string = null |> unbox<string>
    let _v4 = v64 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : string = null |> unbox<string>
    let _v4 = v67 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v70 : string = null |> unbox<string>
    let _v4 = v70 
    #endif
#if FABLE_COMPILER_PYTHON
    let v73 : string = null |> unbox<string>
    let _v4 = v73 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v76 : string = null |> unbox<string>
    let _v4 = v76 
    #endif
#else
    let v79 : string = v3 |> System.IO.File.ReadAllText
    let _v4 = v79 
    #endif
    let v80 : string = _v4 
    let v85 : string = "\n"
    let v86 : (string []) = v80.Split v85 
    let v89 : int32 = v86.Length
    let v90 : (string []) = Array.zeroCreate<string> (v89)
    let v91 : Mut6 = {l0 = 0} : Mut6
    while method59(v89, v91) do
        let v93 : int32 = v91.l0
        let v94 : string = v86.[int v93]
        let v95 : (unit -> string) = v94.Trim
        let v96 : string = v95 ()
        v90.[int v93] <- v96
        let v99 : int32 = v93 + 1
        v91.l0 <- v99
        ()
    let v100 : int32 = v90.Length
    let v101 : (string []) = Array.zeroCreate<string> (v100)
    let v102 : Mut7 = {l0 = 0; l1 = 0} : Mut7
    while method172(v100, v102) do
        let v104 : int32 = v102.l0
        let v105 : int32 = v102.l1
        let v106 : string = v90.[int v104]
        let v107 : string = ""
        let v108 : bool = v107 <> v106 
        let v112 : int32 =
            if v108 then
                v101.[int v105] <- v106
                let v111 : int32 = v105 + 1
                v111
            else
                v105
        let v113 : int32 = v104 + 1
        v102.l0 <- v113
        v102.l1 <- v112
        ()
    let v114 : int32 = v102.l1
    let v115 : (string []) = Array.zeroCreate<string> (v114)
    let v116 : Mut6 = {l0 = 0} : Mut6
    while method59(v114, v116) do
        let v118 : int32 = v116.l0
        let v119 : string = v101.[int v118]
        v115.[int v118] <- v119
        let v120 : int32 = v118 + 1
        v116.l0 <- v120
        ()
    let v121 : unit = ()
    let _v121 =
        seq {
            for i = 0 to v115.Length - 1 do yield v115.[i]
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v124 : string seq = _v121 
    let v130 : string = method134()
    let v131 : (string -> (string seq -> string)) = String.concat
    let v132 : (string seq -> string) = v131 v130
    let v133 : string = v132 v124
    let v136 : string = $"{v133}

"
    let v137 : System.Threading.CancellationToken option = None
    let v138 : (struct (string * string) []) = [||]
    let v139 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v140 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v141 : string option = None
    let v142 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v143 : string = "cfg!(windows)"
    let v144 : bool = Fable.Core.RustInterop.emitRustExpr () v143 
    let _v142 = v144 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v145 : string = "cfg!(windows)"
    let v146 : bool = Fable.Core.RustInterop.emitRustExpr () v145 
    let _v142 = v146 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v147 : string = "cfg!(windows)"
    let v148 : bool = Fable.Core.RustInterop.emitRustExpr () v147 
    let _v142 = v148 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v149 : US3 = US3_0
    let v150 : US4 = US4_3(v149)
    let v151 : string = $"platform.is_windows / target: {v150}"
    let v152 : bool = failwith<bool> v151
    let _v142 = v152 
    #endif
#if FABLE_COMPILER_PYTHON
    let v153 : US3 = US3_0
    let v154 : US4 = US4_4(v153)
    let v155 : string = $"platform.is_windows / target: {v154}"
    let v156 : bool = failwith<bool> v155
    let _v142 = v156 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v157 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v158 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v159 : bool = v158 v157
    let _v142 = v159 
    #endif
#else
    let v160 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v161 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v162 : bool = v161 v160
    let _v142 = v162 
    #endif
    let v163 : bool = _v142 
    let v171 : string =
        if v163 then
            let v169 : string = ".exe"
            v169
        else
            let v170 : string = ""
            v170
    let v172 : string = $"../vault/deps/hangulize/cmd/hangulize/hangulize{v171}"
    let v173 : string = method26(v0, v172)
    let v174 : string = $"{v173} {v1}"
    let v175 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = closure78(v136)
    let v176 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = Some v175 
    let v179 : bool = true
    let struct (v180 : int32, v181 : string) = method81(v174, v137, v138, v139, v176, v179, v141)
    let v182 : (string []) = v181.Split v85 
    let v185 : int32 = v182.Length
    let v186 : string = ""
    let v187 : Mut8 = {l0 = 0; l1 = v186; l2 = 0; l3 = 0} : Mut8
    while method175(v100, v187) do
        let v189 : int32 = v187.l0
        let struct (v190 : string, v191 : int32, v192 : int32) = v187.l1, v187.l2, v187.l3
        let v193 : string = v90.[int v189]
        let v194 : bool = v193 = ""
        let struct (v210 : string, v211 : int32, v212 : int32) =
            if v194 then
                let v195 : string = $"{v190}
"
                let v196 : int32 = v191 + 1
                let v197 : int32 = v192 + 1
                struct (v195, v196, v197)
            else
                let v198 : int32 = v191 - v192
                let v199 : bool = v198 >= v185
                let v208 : string =
                    if v199 then
                        v190
                    else
                        let v200 : string = v182.[int v198]
                        let v203 : int32 = v185 - 1
                        let v204 : bool = v198 = v203
                        if v204 then
                            let v205 : string = $"{v190}{v200}"
                            v205
                        else
                            let v206 : string = $"{v190}{v200}
"
                            v206
                let v209 : int32 = v191 + 1
                struct (v208, v209, v192)
        let v213 : int32 = v189 + 1
        v187.l0 <- v213
        v187.l1 <- v210
        v187.l2 <- v211
        v187.l3 <- v212
        ()
    let struct (v214 : string, v215 : int32, v216 : int32) = v187.l1, v187.l2, v187.l3
    let v217 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v218 : string = "std::fs::write(&*$0, &*$1).unwrap()"
    Fable.Core.RustInterop.emitRustExpr struct (v2, v214) v218 
    #endif
#if FABLE_COMPILER_RUST && WASM
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    #endif
#if FABLE_COMPILER_PYTHON
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    #endif
#else
    System.IO.File.WriteAllText (v2, v214)
    #endif
    // run_target_args' is_unit
    let v219 : unit = ()
    let v220 : (unit -> unit) = closure79(v2, v180, v214)
    let v221 : unit = (fun () -> v220 (); v219) ()
    US35_0(v180, v214)
and method179 (v0 : int32, v1 : string) : string =
    let v2 : string = method14()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "exit_code"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure8(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure8(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure8(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure8(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "result"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure8(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v3, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : string = $"{v1}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure8(v3, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v73 : string = " }"
    let v74 : string = $"{v73}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure8(v3, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = v3.l0
    v82
and method178 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method179(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "documents.files_fn / error"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method18(v13)
and closure80 (v0 : string, v1 : int32) () : unit =
    let v2 : US0 = US0_2
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method8(v20, v21, v22, v23, v24, v25)
        let v39 : string = method12()
        let v40 : string = method178(v20, v21, v22, v23, v24, v25, v38, v39, v1, v0)
        method19(v40)
and closure77 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : US32 =
    let struct (v6 : string, v7 : string) = method156(v5, v4, v0)
    let v8 : bool = method160(v6)
    let v9 : bool = v8 = false
    let v12 : bool =
        if v9 then
            true
        else
            let v10 : bool = method160(v7)
            let v11 : bool = v10 = false
            v11
    let v312 : bool =
        if v12 then
            false
        else
            let v13 : string = method36(v6)
            let v14 : string = "std::fs::File::open(&*v13)"
            let v15 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v14 
            let v16 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17 : string = "$0.unwrap()"
            let v18 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v15 v17 
            let _v16 = v18 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v19 : string = "$0.unwrap()"
            let v20 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v15 v19 
            let _v16 = v20 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v21 : string = "$0.unwrap()"
            let v22 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v15 v21 
            let _v16 = v22 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v23 : std_fs_File = match v15 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v16 = v23 
            #endif
#if FABLE_COMPILER_PYTHON
            let v24 : std_fs_File = match v15 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v16 = v24 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v25 : std_fs_File = match v15 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v16 = v25 
            #endif
#else
            let v26 : std_fs_File = match v15 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v16 = v26 
            #endif
            let v27 : std_fs_File = _v16 
            let v30 : string = "std::io::BufReader::new($0)"
            let v31 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v27 v30 
            let v32 : string = "std::io::BufReader::new($0)"
            let v33 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v31 v32 
            let v34 : string = "true; let mut v33 = v33"
            let v35 : bool = Fable.Core.RustInterop.emitRustExpr () v34 
            let v36 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v36 
            let v37 : string = "result"
            let v38 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v37 
            let v39 : string = "true; let mut v38 = v38"
            let v40 : bool = Fable.Core.RustInterop.emitRustExpr () v39 
            let v41 : unativeint = 0 |> unativeint 
            let v44 : string = "[$0; 1024]"
            let v45 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v44 
            let v46 : string = "true; loop { // rust.loop"
            let v47 : bool = Fable.Core.RustInterop.emitRustExpr () v46 
            let v48 : string = "true; let mut v45 = v45"
            let v49 : bool = Fable.Core.RustInterop.emitRustExpr () v48 
            let v50 : string = "std::io::Read::read(&mut v33, &mut v45)"
            let v51 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v50 
            let v52 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v53 : string = "$0.unwrap()"
            let v54 : unativeint = Fable.Core.RustInterop.emitRustExpr v51 v53 
            let _v52 = v54 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v55 : string = "$0.unwrap()"
            let v56 : unativeint = Fable.Core.RustInterop.emitRustExpr v51 v55 
            let _v52 = v56 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v57 : string = "$0.unwrap()"
            let v58 : unativeint = Fable.Core.RustInterop.emitRustExpr v51 v57 
            let _v52 = v58 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v59 : unativeint = match v51 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v52 = v59 
            #endif
#if FABLE_COMPILER_PYTHON
            let v60 : unativeint = match v51 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v52 = v60 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v61 : unativeint = match v51 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v52 = v61 
            #endif
#else
            let v62 : unativeint = match v51 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v52 = v62 
            #endif
            let v63 : unativeint = _v52 
            let v66 : bool = v63 = v41 
            if v66 then
                let v69 : string = "true; break"
                let v70 : bool = Fable.Core.RustInterop.emitRustExpr () v69 
                ()
            let v71 : unativeint = v63 |> unativeint 
            let v74 : unativeint = v71 |> unbox<unativeint>
            let v77 : string = "v45.len()"
            let v78 : unativeint = Fable.Core.RustInterop.emitRustExpr () v77 
            let v79 : bool = v74 = v78 
            let v86 : Ref<Slice'<uint8>> =
                if v79 then
                    let v82 : string = "&v45[v41..]"
                    let v83 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v82 
                    v83
                else
                    let v84 : string = "&v45[$0..$1]"
                    let v85 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v41, v71) v84 
                    v85
            let v87 : string = "sha2::Digest::update(&mut v38, v86)"
            Fable.Core.RustInterop.emitRustExpr () v87 
            let v88 : string = "true; } // rust.loop"
            let v89 : bool = Fable.Core.RustInterop.emitRustExpr () v88 
            let v90 : string = "true; } // rust.loop"
            let v91 : bool = Fable.Core.RustInterop.emitRustExpr () v90 
            let v92 : string = "true; } // rust.loop"
            let v93 : bool = Fable.Core.RustInterop.emitRustExpr () v92 
            let v94 : string = "true; { // rust.loop"
            let v95 : bool = Fable.Core.RustInterop.emitRustExpr () v94 
            let v96 : string = "true; { // rust.loop"
            let v97 : bool = Fable.Core.RustInterop.emitRustExpr () v96 
            let v98 : string = "&sha2::Digest::finalize(v38)"
            let v99 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v98 
            let v100 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v101 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v99 v100 
            let v102 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v103 : bool = Fable.Core.RustInterop.emitRustExpr v101 v102 
            let v104 : string = "x"
            let v105 : uint8 = Fable.Core.RustInterop.emitRustExpr () v104 
            let v106 : string = "format!(\"{:02x}\", $0)"
            let v107 : std_string_String = Fable.Core.RustInterop.emitRustExpr v105 v106 
            let v108 : string = "fable_library_rust::String_::fromString($0)"
            let v109 : string = Fable.Core.RustInterop.emitRustExpr v107 v108 
            let v110 : string = "true; $0 }).collect::<Vec<_>>()"
            let v111 : bool = Fable.Core.RustInterop.emitRustExpr v109 v110 
            let v112 : string = "_vec_map"
            let v113 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v112 
            let v114 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v115 : (string []) = Fable.Core.RustInterop.emitRustExpr v113 v114 
            let v116 : unit = ()
            let _v116 =
                seq {
                    for i = 0 to v115.Length - 1 do yield v115.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v119 : string seq = _v116 
            let v125 : string = method157()
            let v126 : bool = v125 = "\n"
            let v128 : string =
                if v126 then
                    method61(v125)
                else
                    v125
            let v129 : (string -> (string seq -> string)) = String.concat
            let v130 : (string seq -> string) = v129 v128
            let v131 : string = v130 v119
            let v134 : Result<string, std_io_Error> = Ok v131 
            let v135 : (std_io_Error -> std_string_String) = method65()
            let v136 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v137 : string = "$0.map_err(|x| $1(x))"
            let v138 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v134, v135) v137 
            let _v136 = v138 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v139 : string = "$0.map_err(|x| $1(x))"
            let v140 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v134, v135) v139 
            let _v136 = v140 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v141 : string = "$0.map_err(|x| $1(x))"
            let v142 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v134, v135) v141 
            let _v136 = v142 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v143 : Result<string, std_string_String> = match v134 with Ok x -> Ok x | Error x -> Error (v135 x)
            let _v136 = v143 
            #endif
#if FABLE_COMPILER_PYTHON
            let v144 : Result<string, std_string_String> = match v134 with Ok x -> Ok x | Error x -> Error (v135 x)
            let _v136 = v144 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v145 : Result<string, std_string_String> = match v134 with Ok x -> Ok x | Error x -> Error (v135 x)
            let _v136 = v145 
            #endif
#else
            let v146 : Result<string, std_string_String> = match v134 with Ok x -> Ok x | Error x -> Error (v135 x)
            let _v136 = v146 
            #endif
            let v147 : Result<string, std_string_String> = _v136 
            let v150 : (string -> US33) = method158()
            let v151 : (std_string_String -> US33) = method159()
            let v152 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v153 : US33 = Fable.Core.RustInterop.emitRustExpr struct (v150, v151, v147) v152 
            let v161 : string =
                match v153 with
                | US33_1(v155) -> (* Error *)
                    let v156 : string = $"resultm.get / Result value was Error: {v155}"
                    failwith<string> v156
                | US33_0(v154) -> (* Ok *)
                    v154
            let v162 : string = method36(v7)
            let v163 : string = "std::fs::File::open(&*v162)"
            let v164 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v163 
            let v165 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v166 : string = "$0.unwrap()"
            let v167 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v164 v166 
            let _v165 = v167 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v168 : string = "$0.unwrap()"
            let v169 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v164 v168 
            let _v165 = v169 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v170 : string = "$0.unwrap()"
            let v171 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v164 v170 
            let _v165 = v171 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v172 : std_fs_File = match v164 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v165 = v172 
            #endif
#if FABLE_COMPILER_PYTHON
            let v173 : std_fs_File = match v164 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v165 = v173 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v174 : std_fs_File = match v164 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v165 = v174 
            #endif
#else
            let v175 : std_fs_File = match v164 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v165 = v175 
            #endif
            let v176 : std_fs_File = _v165 
            let v179 : string = "std::io::BufReader::new($0)"
            let v180 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v176 v179 
            let v181 : string = "std::io::BufReader::new($0)"
            let v182 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v180 v181 
            let v183 : string = "true; let mut v182 = v182"
            let v184 : bool = Fable.Core.RustInterop.emitRustExpr () v183 
            let v185 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v185 
            let v186 : string = "result"
            let v187 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v186 
            let v188 : string = "true; let mut v187 = v187"
            let v189 : bool = Fable.Core.RustInterop.emitRustExpr () v188 
            let v190 : unativeint = 0 |> unativeint 
            let v193 : string = "[$0; 1024]"
            let v194 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v193 
            let v195 : string = "true; loop { // rust.loop"
            let v196 : bool = Fable.Core.RustInterop.emitRustExpr () v195 
            let v197 : string = "true; let mut v194 = v194"
            let v198 : bool = Fable.Core.RustInterop.emitRustExpr () v197 
            let v199 : string = "std::io::Read::read(&mut v182, &mut v194)"
            let v200 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v199 
            let v201 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v202 : string = "$0.unwrap()"
            let v203 : unativeint = Fable.Core.RustInterop.emitRustExpr v200 v202 
            let _v201 = v203 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v204 : string = "$0.unwrap()"
            let v205 : unativeint = Fable.Core.RustInterop.emitRustExpr v200 v204 
            let _v201 = v205 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v206 : string = "$0.unwrap()"
            let v207 : unativeint = Fable.Core.RustInterop.emitRustExpr v200 v206 
            let _v201 = v207 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v208 : unativeint = match v200 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v201 = v208 
            #endif
#if FABLE_COMPILER_PYTHON
            let v209 : unativeint = match v200 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v201 = v209 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v210 : unativeint = match v200 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v201 = v210 
            #endif
#else
            let v211 : unativeint = match v200 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v201 = v211 
            #endif
            let v212 : unativeint = _v201 
            let v215 : bool = v212 = v190 
            if v215 then
                let v218 : string = "true; break"
                let v219 : bool = Fable.Core.RustInterop.emitRustExpr () v218 
                ()
            let v220 : unativeint = v212 |> unativeint 
            let v223 : unativeint = v220 |> unbox<unativeint>
            let v226 : string = "v194.len()"
            let v227 : unativeint = Fable.Core.RustInterop.emitRustExpr () v226 
            let v228 : bool = v223 = v227 
            let v235 : Ref<Slice'<uint8>> =
                if v228 then
                    let v231 : string = "&v194[v190..]"
                    let v232 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v231 
                    v232
                else
                    let v233 : string = "&v194[$0..$1]"
                    let v234 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v190, v220) v233 
                    v234
            let v236 : string = "sha2::Digest::update(&mut v187, v235)"
            Fable.Core.RustInterop.emitRustExpr () v236 
            let v237 : string = "true; } // rust.loop"
            let v238 : bool = Fable.Core.RustInterop.emitRustExpr () v237 
            let v239 : string = "true; } // rust.loop"
            let v240 : bool = Fable.Core.RustInterop.emitRustExpr () v239 
            let v241 : string = "true; } // rust.loop"
            let v242 : bool = Fable.Core.RustInterop.emitRustExpr () v241 
            let v243 : string = "true; { // rust.loop"
            let v244 : bool = Fable.Core.RustInterop.emitRustExpr () v243 
            let v245 : string = "true; { // rust.loop"
            let v246 : bool = Fable.Core.RustInterop.emitRustExpr () v245 
            let v247 : string = "&sha2::Digest::finalize(v187)"
            let v248 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v247 
            let v249 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v250 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v248 v249 
            let v251 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v252 : bool = Fable.Core.RustInterop.emitRustExpr v250 v251 
            let v253 : string = "x"
            let v254 : uint8 = Fable.Core.RustInterop.emitRustExpr () v253 
            let v255 : string = "format!(\"{:02x}\", $0)"
            let v256 : std_string_String = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "fable_library_rust::String_::fromString($0)"
            let v258 : string = Fable.Core.RustInterop.emitRustExpr v256 v257 
            let v259 : string = "true; $0 }).collect::<Vec<_>>()"
            let v260 : bool = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "_vec_map"
            let v262 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v261 
            let v263 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v264 : (string []) = Fable.Core.RustInterop.emitRustExpr v262 v263 
            let v265 : unit = ()
            let _v265 =
                seq {
                    for i = 0 to v264.Length - 1 do yield v264.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v268 : string seq = _v265 
            let v274 : string = method157()
            let v275 : bool = v274 = "\n"
            let v277 : string =
                if v275 then
                    method61(v274)
                else
                    v274
            let v278 : (string -> (string seq -> string)) = String.concat
            let v279 : (string seq -> string) = v278 v277
            let v280 : string = v279 v268
            let v283 : Result<string, std_io_Error> = Ok v280 
            let v284 : (std_io_Error -> std_string_String) = method65()
            let v285 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v286 : string = "$0.map_err(|x| $1(x))"
            let v287 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v283, v284) v286 
            let _v285 = v287 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v288 : string = "$0.map_err(|x| $1(x))"
            let v289 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v283, v284) v288 
            let _v285 = v289 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v290 : string = "$0.map_err(|x| $1(x))"
            let v291 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v283, v284) v290 
            let _v285 = v291 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v292 : Result<string, std_string_String> = match v283 with Ok x -> Ok x | Error x -> Error (v284 x)
            let _v285 = v292 
            #endif
#if FABLE_COMPILER_PYTHON
            let v293 : Result<string, std_string_String> = match v283 with Ok x -> Ok x | Error x -> Error (v284 x)
            let _v285 = v293 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v294 : Result<string, std_string_String> = match v283 with Ok x -> Ok x | Error x -> Error (v284 x)
            let _v285 = v294 
            #endif
#else
            let v295 : Result<string, std_string_String> = match v283 with Ok x -> Ok x | Error x -> Error (v284 x)
            let _v285 = v295 
            #endif
            let v296 : Result<string, std_string_String> = _v285 
            let v299 : (string -> US33) = method158()
            let v300 : (std_string_String -> US33) = method159()
            let v301 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v302 : US33 = Fable.Core.RustInterop.emitRustExpr struct (v299, v300, v296) v301 
            let v310 : string =
                match v302 with
                | US33_1(v304) -> (* Error *)
                    let v305 : string = $"resultm.get / Result value was Error: {v304}"
                    failwith<string> v305
                | US33_0(v303) -> (* Ok *)
                    v303
            let v311 : bool = v161 = v310
            v311
    if v312 then
        US32_1
    else
        let v314 : US35 = method170(v2, v3, v6, v4)
        match v314 with
        | US35_1(v370, v371) -> (* Error *)
            let v372 : (string * string) = v6, v371 
            let v373 : Result<string, (string * string)> = Error v372 
            US32_0(v373)
        | US35_0(v315, v316) -> (* Ok *)
            let v317 : bool = v315 <> 0 
            if v317 then
                let v320 : unit = ()
                let v321 : (unit -> unit) = closure80(v316, v315)
                let v322 : unit = (fun () -> v321 (); v320) ()
                let v362 : (string * string) = v6, v316 
                let v363 : Result<string, (string * string)> = Error v362 
                US32_0(v363)
            else
                let v365 : bool = method160(v6)
                if v365 then
                    method163(v7, v6)
                else
                    let v366 : string = $"documents.files_fn / {v6} should exist"
                    failwith<unit> v366
                let v367 : Result<string, (string * string)> = Ok v6 
                US32_0(v367)
and closure76 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : string) : (string -> US32) =
    closure77(v0, v1, v2, v3, v4)
and method182 (v0 : int32, v1 : string, v2 : string) : string =
    let v3 : string = method14()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "exit_code"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure8(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure8(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure8(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure8(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "output_path"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure8(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure8(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure8(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure8(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "result"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure8(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure8(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure8(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and method181 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string, v10 : string) : string =
    let v11 : string = method182(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "documents.crowbook / result contains ERROR"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method18(v14)
and closure83 (v0 : string, v1 : string, v2 : int32) () : unit =
    let v3 : US0 = US0_3
    let v4 : bool = method7(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method8(v21, v22, v23, v24, v25, v26)
        let v40 : string = method31()
        let v41 : string = method181(v21, v22, v23, v24, v25, v26, v39, v40, v2, v0, v1)
        method19(v41)
and method180 (v0 : bool, v1 : string, v2 : string, v3 : string, v4 : string) : US35 =
    let v5 : bool = "html" = v4
    let v61 : string =
        if v5 then
            let v6 : string = $"--set"
            let v7 : string = $" html.css.add \\\"'"
            let v8 : string = v6 + v7 
            let v9 : string = $" body {{ color: #e8e6e3; background-color: #202324; }}"
            let v10 : string = v8 + v9 
            let v11 : string = $" a {{ color: #989693; }}"
            let v12 : string = v10 + v11 
            let v13 : string = $" pre {{ background-color: #1b1b1b; padding: 10px; }}"
            let v14 : string = v12 + v13 
            let v15 : string = $" '\\\""
            let v16 : string = v14 + v15 
            let v17 : string = $" rendering.num_depth 6"
            let v18 : string = $" rendering.highlight.theme \\\"Solarized (dark)\\\""
            let v19 : string = v17 + v18 
            let v20 : string = v16 + v19 
            v20
        else
            let v21 : bool = "pdf" = v4
            if v21 then
                let v22 : string = $"--set"
                let v23 : string = $" tex.paper.size a4paper"
                let v24 : string = v22 + v23 
                let v25 : string = $" tex.template.add \"\\pagenumbering{{gobble}}\""
                let v26 : string = v24 + v25 
                let v27 : bool = v0 = false
                let v36 : string =
                    if v27 then
                        let v28 : string = ""
                        v28
                    else
                        let v29 : string = $" tex.template.add \"\\usepackage{{polyglossia}}\""
                        let v30 : string = $" tex.template.add \"\\setmainlanguage{{korean}}\""
                        let v31 : string = v29 + v30 
                        let v32 : string = $" tex.template.add \"\\setmainfont{{NanumGothicCoding}}\""
                        let v33 : string = v31 + v32 
                        let v34 : string = $" tex.font.size 13"
                        let v35 : string = v33 + v34 
                        v35
                let v37 : string = v26 + v36 
                let v38 : string = $" rendering.num_depth 6"
                let v39 : string = $" rendering.highlight.theme \\\"Solarized (dark)\\\""
                let v40 : string = v38 + v39 
                let v41 : string = v37 + v40 
                v41
            else
                let v42 : bool = "epub" = v4
                if v42 then
                    let v43 : string = $"--set"
                    let v44 : string = $" epub.version 3"
                    let v45 : string = v43 + v44 
                    let v46 : string = $" html.css.add \\\"' "
                    let v47 : string = v45 + v46 
                    let v48 : string = $" body {{ color: #e8e6e3; background-color: #202324; }} "
                    let v49 : string = v47 + v48 
                    let v50 : string = $" a {{ color: #989693; }} "
                    let v51 : string = v49 + v50 
                    let v52 : string = $" '\\\""
                    let v53 : string = v51 + v52 
                    let v54 : string = $" rendering.num_depth 6"
                    let v55 : string = $" rendering.highlight.theme \\\"Solarized (dark)\\\""
                    let v56 : string = v54 + v55 
                    let v57 : string = v53 + v56 
                    v57
                else
                    let v58 : string = ""
                    v58
    let v62 : System.Threading.CancellationToken option = None
    let v63 : (struct (string * string) []) = [||]
    let v64 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v65 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v66 : string option = None
    let v67 : string = $"crowbook --verbose --to {v4}"
    let v68 : string = $" --single \"{v2}\" --output \"{v1}\" {v61}"
    let v69 : string = v67 + v68 
    let v70 : string option = Some v3 
    let v73 : bool = true
    let struct (v74 : int32, v75 : string) = method81(v69, v62, v63, v64, v65, v73, v70)
    let v76 : string = "ERROR"
    let v77 : bool = v75.Contains v76 
    let v80 : bool = v77 = false
    if v80 then
        US35_0(v74, v75)
    else
        let v82 : unit = ()
        let v83 : (unit -> unit) = closure83(v1, v75, v74)
        let v84 : unit = (fun () -> v83 (); v82) ()
        US35_1(v74, v75)
and closure82 (v0 : string, v1 : string, v2 : bool, v3 : string) (v4 : string) : US32 =
    let struct (v5 : string, v6 : string) = method156(v4, v3, v0)
    let v7 : bool = method160(v5)
    let v8 : bool = v7 = false
    let v11 : bool =
        if v8 then
            true
        else
            let v9 : bool = method160(v6)
            let v10 : bool = v9 = false
            v10
    let v311 : bool =
        if v11 then
            false
        else
            let v12 : string = method36(v5)
            let v13 : string = "std::fs::File::open(&*v12)"
            let v14 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v13 
            let v15 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16 : string = "$0.unwrap()"
            let v17 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v14 v16 
            let _v15 = v17 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18 : string = "$0.unwrap()"
            let v19 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v14 v18 
            let _v15 = v19 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v20 : string = "$0.unwrap()"
            let v21 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v14 v20 
            let _v15 = v21 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v22 : std_fs_File = match v14 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v15 = v22 
            #endif
#if FABLE_COMPILER_PYTHON
            let v23 : std_fs_File = match v14 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v15 = v23 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v24 : std_fs_File = match v14 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v15 = v24 
            #endif
#else
            let v25 : std_fs_File = match v14 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v15 = v25 
            #endif
            let v26 : std_fs_File = _v15 
            let v29 : string = "std::io::BufReader::new($0)"
            let v30 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v26 v29 
            let v31 : string = "std::io::BufReader::new($0)"
            let v32 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v30 v31 
            let v33 : string = "true; let mut v32 = v32"
            let v34 : bool = Fable.Core.RustInterop.emitRustExpr () v33 
            let v35 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v35 
            let v36 : string = "result"
            let v37 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v36 
            let v38 : string = "true; let mut v37 = v37"
            let v39 : bool = Fable.Core.RustInterop.emitRustExpr () v38 
            let v40 : unativeint = 0 |> unativeint 
            let v43 : string = "[$0; 1024]"
            let v44 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v43 
            let v45 : string = "true; loop { // rust.loop"
            let v46 : bool = Fable.Core.RustInterop.emitRustExpr () v45 
            let v47 : string = "true; let mut v44 = v44"
            let v48 : bool = Fable.Core.RustInterop.emitRustExpr () v47 
            let v49 : string = "std::io::Read::read(&mut v32, &mut v44)"
            let v50 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v49 
            let v51 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v52 : string = "$0.unwrap()"
            let v53 : unativeint = Fable.Core.RustInterop.emitRustExpr v50 v52 
            let _v51 = v53 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v54 : string = "$0.unwrap()"
            let v55 : unativeint = Fable.Core.RustInterop.emitRustExpr v50 v54 
            let _v51 = v55 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v56 : string = "$0.unwrap()"
            let v57 : unativeint = Fable.Core.RustInterop.emitRustExpr v50 v56 
            let _v51 = v57 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v58 : unativeint = match v50 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v51 = v58 
            #endif
#if FABLE_COMPILER_PYTHON
            let v59 : unativeint = match v50 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v51 = v59 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v60 : unativeint = match v50 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v51 = v60 
            #endif
#else
            let v61 : unativeint = match v50 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v51 = v61 
            #endif
            let v62 : unativeint = _v51 
            let v65 : bool = v62 = v40 
            if v65 then
                let v68 : string = "true; break"
                let v69 : bool = Fable.Core.RustInterop.emitRustExpr () v68 
                ()
            let v70 : unativeint = v62 |> unativeint 
            let v73 : unativeint = v70 |> unbox<unativeint>
            let v76 : string = "v44.len()"
            let v77 : unativeint = Fable.Core.RustInterop.emitRustExpr () v76 
            let v78 : bool = v73 = v77 
            let v85 : Ref<Slice'<uint8>> =
                if v78 then
                    let v81 : string = "&v44[v40..]"
                    let v82 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v81 
                    v82
                else
                    let v83 : string = "&v44[$0..$1]"
                    let v84 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v40, v70) v83 
                    v84
            let v86 : string = "sha2::Digest::update(&mut v37, v85)"
            Fable.Core.RustInterop.emitRustExpr () v86 
            let v87 : string = "true; } // rust.loop"
            let v88 : bool = Fable.Core.RustInterop.emitRustExpr () v87 
            let v89 : string = "true; } // rust.loop"
            let v90 : bool = Fable.Core.RustInterop.emitRustExpr () v89 
            let v91 : string = "true; } // rust.loop"
            let v92 : bool = Fable.Core.RustInterop.emitRustExpr () v91 
            let v93 : string = "true; { // rust.loop"
            let v94 : bool = Fable.Core.RustInterop.emitRustExpr () v93 
            let v95 : string = "true; { // rust.loop"
            let v96 : bool = Fable.Core.RustInterop.emitRustExpr () v95 
            let v97 : string = "&sha2::Digest::finalize(v37)"
            let v98 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v97 
            let v99 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v100 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v98 v99 
            let v101 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v102 : bool = Fable.Core.RustInterop.emitRustExpr v100 v101 
            let v103 : string = "x"
            let v104 : uint8 = Fable.Core.RustInterop.emitRustExpr () v103 
            let v105 : string = "format!(\"{:02x}\", $0)"
            let v106 : std_string_String = Fable.Core.RustInterop.emitRustExpr v104 v105 
            let v107 : string = "fable_library_rust::String_::fromString($0)"
            let v108 : string = Fable.Core.RustInterop.emitRustExpr v106 v107 
            let v109 : string = "true; $0 }).collect::<Vec<_>>()"
            let v110 : bool = Fable.Core.RustInterop.emitRustExpr v108 v109 
            let v111 : string = "_vec_map"
            let v112 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v111 
            let v113 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v114 : (string []) = Fable.Core.RustInterop.emitRustExpr v112 v113 
            let v115 : unit = ()
            let _v115 =
                seq {
                    for i = 0 to v114.Length - 1 do yield v114.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v118 : string seq = _v115 
            let v124 : string = method157()
            let v125 : bool = v124 = "\n"
            let v127 : string =
                if v125 then
                    method61(v124)
                else
                    v124
            let v128 : (string -> (string seq -> string)) = String.concat
            let v129 : (string seq -> string) = v128 v127
            let v130 : string = v129 v118
            let v133 : Result<string, std_io_Error> = Ok v130 
            let v134 : (std_io_Error -> std_string_String) = method65()
            let v135 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v136 : string = "$0.map_err(|x| $1(x))"
            let v137 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v133, v134) v136 
            let _v135 = v137 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v138 : string = "$0.map_err(|x| $1(x))"
            let v139 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v133, v134) v138 
            let _v135 = v139 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v140 : string = "$0.map_err(|x| $1(x))"
            let v141 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v133, v134) v140 
            let _v135 = v141 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v142 : Result<string, std_string_String> = match v133 with Ok x -> Ok x | Error x -> Error (v134 x)
            let _v135 = v142 
            #endif
#if FABLE_COMPILER_PYTHON
            let v143 : Result<string, std_string_String> = match v133 with Ok x -> Ok x | Error x -> Error (v134 x)
            let _v135 = v143 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v144 : Result<string, std_string_String> = match v133 with Ok x -> Ok x | Error x -> Error (v134 x)
            let _v135 = v144 
            #endif
#else
            let v145 : Result<string, std_string_String> = match v133 with Ok x -> Ok x | Error x -> Error (v134 x)
            let _v135 = v145 
            #endif
            let v146 : Result<string, std_string_String> = _v135 
            let v149 : (string -> US33) = method158()
            let v150 : (std_string_String -> US33) = method159()
            let v151 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v152 : US33 = Fable.Core.RustInterop.emitRustExpr struct (v149, v150, v146) v151 
            let v160 : string =
                match v152 with
                | US33_1(v154) -> (* Error *)
                    let v155 : string = $"resultm.get / Result value was Error: {v154}"
                    failwith<string> v155
                | US33_0(v153) -> (* Ok *)
                    v153
            let v161 : string = method36(v6)
            let v162 : string = "std::fs::File::open(&*v161)"
            let v163 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v162 
            let v164 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v165 : string = "$0.unwrap()"
            let v166 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v163 v165 
            let _v164 = v166 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v167 : string = "$0.unwrap()"
            let v168 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v163 v167 
            let _v164 = v168 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v169 : string = "$0.unwrap()"
            let v170 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v163 v169 
            let _v164 = v170 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v171 : std_fs_File = match v163 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v164 = v171 
            #endif
#if FABLE_COMPILER_PYTHON
            let v172 : std_fs_File = match v163 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v164 = v172 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v173 : std_fs_File = match v163 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v164 = v173 
            #endif
#else
            let v174 : std_fs_File = match v163 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v164 = v174 
            #endif
            let v175 : std_fs_File = _v164 
            let v178 : string = "std::io::BufReader::new($0)"
            let v179 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v175 v178 
            let v180 : string = "std::io::BufReader::new($0)"
            let v181 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v179 v180 
            let v182 : string = "true; let mut v181 = v181"
            let v183 : bool = Fable.Core.RustInterop.emitRustExpr () v182 
            let v184 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v184 
            let v185 : string = "result"
            let v186 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v185 
            let v187 : string = "true; let mut v186 = v186"
            let v188 : bool = Fable.Core.RustInterop.emitRustExpr () v187 
            let v189 : unativeint = 0 |> unativeint 
            let v192 : string = "[$0; 1024]"
            let v193 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v192 
            let v194 : string = "true; loop { // rust.loop"
            let v195 : bool = Fable.Core.RustInterop.emitRustExpr () v194 
            let v196 : string = "true; let mut v193 = v193"
            let v197 : bool = Fable.Core.RustInterop.emitRustExpr () v196 
            let v198 : string = "std::io::Read::read(&mut v181, &mut v193)"
            let v199 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v198 
            let v200 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v201 : string = "$0.unwrap()"
            let v202 : unativeint = Fable.Core.RustInterop.emitRustExpr v199 v201 
            let _v200 = v202 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v203 : string = "$0.unwrap()"
            let v204 : unativeint = Fable.Core.RustInterop.emitRustExpr v199 v203 
            let _v200 = v204 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v205 : string = "$0.unwrap()"
            let v206 : unativeint = Fable.Core.RustInterop.emitRustExpr v199 v205 
            let _v200 = v206 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v207 : unativeint = match v199 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v200 = v207 
            #endif
#if FABLE_COMPILER_PYTHON
            let v208 : unativeint = match v199 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v200 = v208 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v209 : unativeint = match v199 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v200 = v209 
            #endif
#else
            let v210 : unativeint = match v199 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v200 = v210 
            #endif
            let v211 : unativeint = _v200 
            let v214 : bool = v211 = v189 
            if v214 then
                let v217 : string = "true; break"
                let v218 : bool = Fable.Core.RustInterop.emitRustExpr () v217 
                ()
            let v219 : unativeint = v211 |> unativeint 
            let v222 : unativeint = v219 |> unbox<unativeint>
            let v225 : string = "v193.len()"
            let v226 : unativeint = Fable.Core.RustInterop.emitRustExpr () v225 
            let v227 : bool = v222 = v226 
            let v234 : Ref<Slice'<uint8>> =
                if v227 then
                    let v230 : string = "&v193[v189..]"
                    let v231 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v230 
                    v231
                else
                    let v232 : string = "&v193[$0..$1]"
                    let v233 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v189, v219) v232 
                    v233
            let v235 : string = "sha2::Digest::update(&mut v186, v234)"
            Fable.Core.RustInterop.emitRustExpr () v235 
            let v236 : string = "true; } // rust.loop"
            let v237 : bool = Fable.Core.RustInterop.emitRustExpr () v236 
            let v238 : string = "true; } // rust.loop"
            let v239 : bool = Fable.Core.RustInterop.emitRustExpr () v238 
            let v240 : string = "true; } // rust.loop"
            let v241 : bool = Fable.Core.RustInterop.emitRustExpr () v240 
            let v242 : string = "true; { // rust.loop"
            let v243 : bool = Fable.Core.RustInterop.emitRustExpr () v242 
            let v244 : string = "true; { // rust.loop"
            let v245 : bool = Fable.Core.RustInterop.emitRustExpr () v244 
            let v246 : string = "&sha2::Digest::finalize(v186)"
            let v247 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v246 
            let v248 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v249 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v247 v248 
            let v250 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v251 : bool = Fable.Core.RustInterop.emitRustExpr v249 v250 
            let v252 : string = "x"
            let v253 : uint8 = Fable.Core.RustInterop.emitRustExpr () v252 
            let v254 : string = "format!(\"{:02x}\", $0)"
            let v255 : std_string_String = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "fable_library_rust::String_::fromString($0)"
            let v257 : string = Fable.Core.RustInterop.emitRustExpr v255 v256 
            let v258 : string = "true; $0 }).collect::<Vec<_>>()"
            let v259 : bool = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "_vec_map"
            let v261 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v260 
            let v262 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v263 : (string []) = Fable.Core.RustInterop.emitRustExpr v261 v262 
            let v264 : unit = ()
            let _v264 =
                seq {
                    for i = 0 to v263.Length - 1 do yield v263.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v267 : string seq = _v264 
            let v273 : string = method157()
            let v274 : bool = v273 = "\n"
            let v276 : string =
                if v274 then
                    method61(v273)
                else
                    v273
            let v277 : (string -> (string seq -> string)) = String.concat
            let v278 : (string seq -> string) = v277 v276
            let v279 : string = v278 v267
            let v282 : Result<string, std_io_Error> = Ok v279 
            let v283 : (std_io_Error -> std_string_String) = method65()
            let v284 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v285 : string = "$0.map_err(|x| $1(x))"
            let v286 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v282, v283) v285 
            let _v284 = v286 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v287 : string = "$0.map_err(|x| $1(x))"
            let v288 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v282, v283) v287 
            let _v284 = v288 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v289 : string = "$0.map_err(|x| $1(x))"
            let v290 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v282, v283) v289 
            let _v284 = v290 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v291 : Result<string, std_string_String> = match v282 with Ok x -> Ok x | Error x -> Error (v283 x)
            let _v284 = v291 
            #endif
#if FABLE_COMPILER_PYTHON
            let v292 : Result<string, std_string_String> = match v282 with Ok x -> Ok x | Error x -> Error (v283 x)
            let _v284 = v292 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v293 : Result<string, std_string_String> = match v282 with Ok x -> Ok x | Error x -> Error (v283 x)
            let _v284 = v293 
            #endif
#else
            let v294 : Result<string, std_string_String> = match v282 with Ok x -> Ok x | Error x -> Error (v283 x)
            let _v284 = v294 
            #endif
            let v295 : Result<string, std_string_String> = _v284 
            let v298 : (string -> US33) = method158()
            let v299 : (std_string_String -> US33) = method159()
            let v300 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v301 : US33 = Fable.Core.RustInterop.emitRustExpr struct (v298, v299, v295) v300 
            let v309 : string =
                match v301 with
                | US33_1(v303) -> (* Error *)
                    let v304 : string = $"resultm.get / Result value was Error: {v303}"
                    failwith<string> v304
                | US33_0(v302) -> (* Ok *)
                    v302
            let v310 : bool = v160 = v309
            v310
    if v311 then
        US32_1
    else
        let v313 : US35 = method180(v2, v5, v3, v1, v4)
        match v313 with
        | US35_1(v369, v370) -> (* Error *)
            let v371 : (string * string) = v5, v370 
            let v372 : Result<string, (string * string)> = Error v371 
            US32_0(v372)
        | US35_0(v314, v315) -> (* Ok *)
            let v316 : bool = v314 <> 0 
            if v316 then
                let v319 : unit = ()
                let v320 : (unit -> unit) = closure80(v315, v314)
                let v321 : unit = (fun () -> v320 (); v319) ()
                let v361 : (string * string) = v5, v315 
                let v362 : Result<string, (string * string)> = Error v361 
                US32_0(v362)
            else
                let v364 : bool = method160(v5)
                if v364 then
                    method163(v6, v5)
                else
                    let v365 : string = $"documents.files_fn / {v5} should exist"
                    failwith<unit> v365
                let v366 : Result<string, (string * string)> = Ok v5 
                US32_0(v366)
and closure81 (v0 : string, v1 : string, v2 : bool) (v3 : string) : (string -> US32) =
    closure82(v0, v1, v2, v3)
and method184 (v0 : string, v1 : string) : string =
    let v2 : string = method14()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "output_path"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure8(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure8(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure8(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure8(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "output_cache_path"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure8(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v3, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : string = $"{v1}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure8(v3, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v73 : string = " }"
    let v74 : string = $"{v73}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure8(v3, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = v3.l0
    v82
and method183 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : string = method184(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "documents.run / par_map / files' = [] / listm.iter"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method18(v13)
and closure84 (v0 : string, v1 : string) () : unit =
    let v2 : US0 = US0_2
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method8(v20, v21, v22, v23, v24, v25)
        let v39 : string = method12()
        let v40 : string = method183(v20, v21, v22, v23, v24, v25, v38, v39, v1, v0)
        method19(v40)
and method185 (v0 : UH4, v1 : UH5 list) : UH5 list =
    match v0 with
    | UH4_1(v2, v3) -> (* Cons *)
        let v4 : UH5 list = method185(v3, v1)
        let v5 : UH5 list = v2 :: v4 
        v5
    | UH4_0 -> (* Nil *)
        v1
and method186 (v0 : int32, v1 : Mut9) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method187 (v0 : UH5, v1 : struct (string * string * (string -> (string -> US32))) list) : struct (string * string * (string -> (string -> US32))) list =
    match v0 with
    | UH5_1(v2, v3, v4, v5) -> (* Cons *)
        let v6 : struct (string * string * (string -> (string -> US32))) list = method187(v5, v1)
        let v7 : struct (string * string * (string -> (string -> US32))) list = struct (v2, v3, v4) :: v6 
        v7
    | UH5_0 -> (* Nil *)
        v1
and closure85 () struct (v0 : string, v1 : string, v2 : (string -> (string -> US32))) : Result<string, (string * string)> option =
    let v3 : (string -> US32) = v2 v1
    let v4 : US32 = v3 v0
    match v4 with
    | US32_1 -> (* None *)
        let v9 : Result<string, (string * string)> option = None
        v9
    | US32_0(v5) -> (* Some *)
        let v6 : Result<string, (string * string)> option = Some v5 
        v6
and method188 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method189 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and closure33 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> =
    let v6 : string = method35(v5)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "&*$0"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v8 
    let _v7 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : string = "&*$0"
    let v11 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v10 
    let _v7 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = "&*$0"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v12 
    let _v7 = v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v7 = v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v17 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v7 = v17 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v20 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v7 = v20 
    #endif
#else
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v7 = v23 
    #endif
    let v26 : Ref<Str> = _v7 
    let v31 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v32 : string = "String::from($0)"
    let v33 : std_string_String = Fable.Core.RustInterop.emitRustExpr v26 v32 
    let _v31 = v33 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v34 : string = "String::from($0)"
    let v35 : std_string_String = Fable.Core.RustInterop.emitRustExpr v26 v34 
    let _v31 = v35 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v36 : string = "String::from($0)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr v26 v36 
    let _v31 = v37 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v38 : std_string_String = v26 |> unbox<std_string_String>
    let _v31 = v38 
    #endif
#if FABLE_COMPILER_PYTHON
    let v41 : std_string_String = v26 |> unbox<std_string_String>
    let _v31 = v41 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v44 : std_string_String = v26 |> unbox<std_string_String>
    let _v31 = v44 
    #endif
#else
    let v47 : std_string_String = v26 |> unbox<std_string_String>
    let _v31 = v47 
    #endif
    let v50 : std_string_String = _v31 
    let v55 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v56 : string = "std::path::PathBuf::from($0)"
    let v57 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v50 v56 
    let _v55 = v57 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v58 : string = "std::path::PathBuf::from($0)"
    let v59 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v50 v58 
    let _v55 = v59 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v60 : string = "std::path::PathBuf::from($0)"
    let v61 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v50 v60 
    let _v55 = v61 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v62 : std_path_PathBuf = v50 |> unbox<std_path_PathBuf>
    let _v55 = v62 
    #endif
#if FABLE_COMPILER_PYTHON
    let v65 : std_path_PathBuf = v50 |> unbox<std_path_PathBuf>
    let _v55 = v65 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v68 : std_path_PathBuf = v50 |> unbox<std_path_PathBuf>
    let _v55 = v68 
    #endif
#else
    let v71 : std_path_PathBuf = v50 |> unbox<std_path_PathBuf>
    let _v55 = v71 
    #endif
    let v74 : std_path_PathBuf = _v55 
    let v79 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v80 : string = "$0.display()"
    let v81 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v74 v80 
    let _v79 = v81 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v82 : string = "$0.display()"
    let v83 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v74 v82 
    let _v79 = v83 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v84 : string = "$0.display()"
    let v85 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v74 v84 
    let _v79 = v85 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v86 : std_path_Display = v74 |> unbox<std_path_Display>
    let _v79 = v86 
    #endif
#if FABLE_COMPILER_PYTHON
    let v89 : std_path_Display = v74 |> unbox<std_path_Display>
    let _v79 = v89 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v92 : std_path_Display = v74 |> unbox<std_path_Display>
    let _v79 = v92 
    #endif
#else
    let v95 : std_path_Display = v74 |> unbox<std_path_Display>
    let _v79 = v95 
    #endif
    let v98 : std_path_Display = _v79 
    let v103 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v104 : string = "format!(\"{}\", $0)"
    let v105 : std_string_String = Fable.Core.RustInterop.emitRustExpr v98 v104 
    let _v103 = v105 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v106 : string = "format!(\"{}\", $0)"
    let v107 : std_string_String = Fable.Core.RustInterop.emitRustExpr v98 v106 
    let _v103 = v107 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v108 : string = "format!(\"{}\", $0)"
    let v109 : std_string_String = Fable.Core.RustInterop.emitRustExpr v98 v108 
    let _v103 = v109 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v110 : std_string_String = null |> unbox<std_string_String>
    let _v103 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v113 : std_string_String = null |> unbox<std_string_String>
    let _v103 = v113 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v116 : std_string_String = null |> unbox<std_string_String>
    let _v103 = v116 
    #endif
#else
    let v119 : std_string_String = null |> unbox<std_string_String>
    let _v103 = v119 
    #endif
    let v122 : std_string_String = _v103 
    let v127 : string = "fable_library_rust::String_::fromString($0)"
    let v128 : string = Fable.Core.RustInterop.emitRustExpr v122 v127 
    let v129 : string = method79()
    let v130 : string = v128.Replace (v3, v129)
    let v131 : string = "\\"
    let v132 : string = "/"
    let v133 : string = v130.Replace (v131, v132)
    let v134 : string = $".{v133}"
    let v135 : string = method36(v6)
    let v136 : string = method26(v2, v134)
    let v137 : string = method80(v136)
    let v138 : System.Threading.CancellationToken option = None
    let v139 : (struct (string * string) []) = [||]
    let v140 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v141 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v142 : string option = None
    let v143 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v137}\""
    let v144 : string option = Some v2 
    let v147 : bool = true
    let struct (v148 : int32, v149 : string) = method81(v143, v138, v139, v140, v141, v147, v144)
    let v150 : string = method26(v3, v134)
    let v151 : string = method80(v150)
    let v152 : System.Threading.CancellationToken option = None
    let v153 : (struct (string * string) []) = [||]
    let v154 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v155 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v156 : string option = None
    let v157 : string = $"git hash-object \"{v151}\""
    let v158 : string option = Some v3 
    let v161 : bool = true
    let struct (v162 : int32, v163 : string) = method81(v157, v152, v153, v154, v155, v161, v158)
    let v164 : string = method26(v4, v134)
    let v165 : string = method80(v164)
    let v166 : string = "hangul.md"
    let struct (v167 : string, v168 : string) = method156(v166, v151, v4)
    let v169 : bool = false
    let v170 : bool = false
    let v171 : bool = false
    let v172 : bool = true
    let v173 : bool = true
    let v174 : bool = true
    let v175 : bool = v149.Contains v163 
    let v628 : UH4 =
        if v175 then
            UH4_0
        else
            let v179 : string = method36(v151)
            let v180 : string = "std::fs::File::open(&*v179)"
            let v181 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v180 
            let v182 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v183 : string = "$0.unwrap()"
            let v184 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v181 v183 
            let _v182 = v184 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v185 : string = "$0.unwrap()"
            let v186 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v181 v185 
            let _v182 = v186 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v187 : string = "$0.unwrap()"
            let v188 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v181 v187 
            let _v182 = v188 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v189 : std_fs_File = match v181 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v182 = v189 
            #endif
#if FABLE_COMPILER_PYTHON
            let v190 : std_fs_File = match v181 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v182 = v190 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v191 : std_fs_File = match v181 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v182 = v191 
            #endif
#else
            let v192 : std_fs_File = match v181 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v182 = v192 
            #endif
            let v193 : std_fs_File = _v182 
            let v196 : string = "std::io::BufReader::new($0)"
            let v197 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v193 v196 
            let v198 : string = "std::io::BufReader::new($0)"
            let v199 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v197 v198 
            let v200 : string = "true; let mut v199 = v199"
            let v201 : bool = Fable.Core.RustInterop.emitRustExpr () v200 
            let v202 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v202 
            let v203 : string = "result"
            let v204 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v203 
            let v205 : string = "true; let mut v204 = v204"
            let v206 : bool = Fable.Core.RustInterop.emitRustExpr () v205 
            let v207 : unativeint = 0 |> unativeint 
            let v210 : string = "[$0; 1024]"
            let v211 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v210 
            let v212 : string = "true; loop { // rust.loop"
            let v213 : bool = Fable.Core.RustInterop.emitRustExpr () v212 
            let v214 : string = "true; let mut v211 = v211"
            let v215 : bool = Fable.Core.RustInterop.emitRustExpr () v214 
            let v216 : string = "std::io::Read::read(&mut v199, &mut v211)"
            let v217 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v216 
            let v218 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v219 : string = "$0.unwrap()"
            let v220 : unativeint = Fable.Core.RustInterop.emitRustExpr v217 v219 
            let _v218 = v220 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v221 : string = "$0.unwrap()"
            let v222 : unativeint = Fable.Core.RustInterop.emitRustExpr v217 v221 
            let _v218 = v222 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v223 : string = "$0.unwrap()"
            let v224 : unativeint = Fable.Core.RustInterop.emitRustExpr v217 v223 
            let _v218 = v224 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v225 : unativeint = match v217 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v218 = v225 
            #endif
#if FABLE_COMPILER_PYTHON
            let v226 : unativeint = match v217 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v218 = v226 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v227 : unativeint = match v217 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v218 = v227 
            #endif
#else
            let v228 : unativeint = match v217 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v218 = v228 
            #endif
            let v229 : unativeint = _v218 
            let v232 : bool = v229 = v207 
            if v232 then
                let v235 : string = "true; break"
                let v236 : bool = Fable.Core.RustInterop.emitRustExpr () v235 
                ()
            let v237 : unativeint = v229 |> unativeint 
            let v240 : unativeint = v237 |> unbox<unativeint>
            let v243 : string = "v211.len()"
            let v244 : unativeint = Fable.Core.RustInterop.emitRustExpr () v243 
            let v245 : bool = v240 = v244 
            let v252 : Ref<Slice'<uint8>> =
                if v245 then
                    let v248 : string = "&v211[v207..]"
                    let v249 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v248 
                    v249
                else
                    let v250 : string = "&v211[$0..$1]"
                    let v251 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v207, v237) v250 
                    v251
            let v253 : string = "sha2::Digest::update(&mut v204, v252)"
            Fable.Core.RustInterop.emitRustExpr () v253 
            let v254 : string = "true; } // rust.loop"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr () v254 
            let v256 : string = "true; } // rust.loop"
            let v257 : bool = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "true; } // rust.loop"
            let v259 : bool = Fable.Core.RustInterop.emitRustExpr () v258 
            let v260 : string = "true; { // rust.loop"
            let v261 : bool = Fable.Core.RustInterop.emitRustExpr () v260 
            let v262 : string = "true; { // rust.loop"
            let v263 : bool = Fable.Core.RustInterop.emitRustExpr () v262 
            let v264 : string = "&sha2::Digest::finalize(v204)"
            let v265 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v264 
            let v266 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v267 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v265 v266 
            let v268 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v269 : bool = Fable.Core.RustInterop.emitRustExpr v267 v268 
            let v270 : string = "x"
            let v271 : uint8 = Fable.Core.RustInterop.emitRustExpr () v270 
            let v272 : string = "format!(\"{:02x}\", $0)"
            let v273 : std_string_String = Fable.Core.RustInterop.emitRustExpr v271 v272 
            let v274 : string = "fable_library_rust::String_::fromString($0)"
            let v275 : string = Fable.Core.RustInterop.emitRustExpr v273 v274 
            let v276 : string = "true; $0 }).collect::<Vec<_>>()"
            let v277 : bool = Fable.Core.RustInterop.emitRustExpr v275 v276 
            let v278 : string = "_vec_map"
            let v279 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v278 
            let v280 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v281 : (string []) = Fable.Core.RustInterop.emitRustExpr v279 v280 
            let v282 : unit = ()
            let _v282 =
                seq {
                    for i = 0 to v281.Length - 1 do yield v281.[i]
                    (* indent
                    ()
                indent *)
                }
                (* indent
                ()
            indent *)
            let v285 : string seq = _v282 
            let v291 : string = method157()
            let v292 : bool = v291 = "\n"
            let v294 : string =
                if v292 then
                    method61(v291)
                else
                    v291
            let v295 : (string -> (string seq -> string)) = String.concat
            let v296 : (string seq -> string) = v295 v294
            let v297 : string = v296 v285
            let v300 : Result<string, std_io_Error> = Ok v297 
            let v301 : (std_io_Error -> std_string_String) = method65()
            let v302 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v303 : string = "$0.map_err(|x| $1(x))"
            let v304 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v300, v301) v303 
            let _v302 = v304 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v305 : string = "$0.map_err(|x| $1(x))"
            let v306 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v300, v301) v305 
            let _v302 = v306 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v307 : string = "$0.map_err(|x| $1(x))"
            let v308 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v300, v301) v307 
            let _v302 = v308 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v309 : Result<string, std_string_String> = match v300 with Ok x -> Ok x | Error x -> Error (v301 x)
            let _v302 = v309 
            #endif
#if FABLE_COMPILER_PYTHON
            let v310 : Result<string, std_string_String> = match v300 with Ok x -> Ok x | Error x -> Error (v301 x)
            let _v302 = v310 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v311 : Result<string, std_string_String> = match v300 with Ok x -> Ok x | Error x -> Error (v301 x)
            let _v302 = v311 
            #endif
#else
            let v312 : Result<string, std_string_String> = match v300 with Ok x -> Ok x | Error x -> Error (v301 x)
            let _v302 = v312 
            #endif
            let v313 : Result<string, std_string_String> = _v302 
            let v316 : (string -> US33) = method158()
            let v317 : (std_string_String -> US33) = method159()
            let v318 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v319 : US33 = Fable.Core.RustInterop.emitRustExpr struct (v316, v317, v313) v318 
            let v327 : string =
                match v319 with
                | US33_1(v321) -> (* Error *)
                    let v322 : string = $"resultm.get / Result value was Error: {v321}"
                    failwith<string> v322
                | US33_0(v320) -> (* Ok *)
                    v320
            let v328 : bool = method160(v165)
            let v329 : bool = v328 = false
            let v478 : US5 =
                if v329 then
                    US5_1
                else
                    let v331 : string = method36(v165)
                    let v332 : string = "std::fs::File::open(&*v331)"
                    let v333 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v332 
                    let v334 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v335 : string = "$0.unwrap()"
                    let v336 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v333 v335 
                    let _v334 = v336 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v337 : string = "$0.unwrap()"
                    let v338 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v333 v337 
                    let _v334 = v338 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v339 : string = "$0.unwrap()"
                    let v340 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v333 v339 
                    let _v334 = v340 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v341 : std_fs_File = match v333 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v334 = v341 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v342 : std_fs_File = match v333 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v334 = v342 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v343 : std_fs_File = match v333 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v334 = v343 
                    #endif
#else
                    let v344 : std_fs_File = match v333 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v334 = v344 
                    #endif
                    let v345 : std_fs_File = _v334 
                    let v348 : string = "std::io::BufReader::new($0)"
                    let v349 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v345 v348 
                    let v350 : string = "std::io::BufReader::new($0)"
                    let v351 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v349 v350 
                    let v352 : string = "true; let mut v351 = v351"
                    let v353 : bool = Fable.Core.RustInterop.emitRustExpr () v352 
                    let v354 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
                    Fable.Core.RustInterop.emitRustExpr () v354 
                    let v355 : string = "result"
                    let v356 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v355 
                    let v357 : string = "true; let mut v356 = v356"
                    let v358 : bool = Fable.Core.RustInterop.emitRustExpr () v357 
                    let v359 : unativeint = 0 |> unativeint 
                    let v362 : string = "[$0; 1024]"
                    let v363 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v362 
                    let v364 : string = "true; loop { // rust.loop"
                    let v365 : bool = Fable.Core.RustInterop.emitRustExpr () v364 
                    let v366 : string = "true; let mut v363 = v363"
                    let v367 : bool = Fable.Core.RustInterop.emitRustExpr () v366 
                    let v368 : string = "std::io::Read::read(&mut v351, &mut v363)"
                    let v369 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v368 
                    let v370 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v371 : string = "$0.unwrap()"
                    let v372 : unativeint = Fable.Core.RustInterop.emitRustExpr v369 v371 
                    let _v370 = v372 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v373 : string = "$0.unwrap()"
                    let v374 : unativeint = Fable.Core.RustInterop.emitRustExpr v369 v373 
                    let _v370 = v374 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v375 : string = "$0.unwrap()"
                    let v376 : unativeint = Fable.Core.RustInterop.emitRustExpr v369 v375 
                    let _v370 = v376 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v377 : unativeint = match v369 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v370 = v377 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v378 : unativeint = match v369 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v370 = v378 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v379 : unativeint = match v369 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v370 = v379 
                    #endif
#else
                    let v380 : unativeint = match v369 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v370 = v380 
                    #endif
                    let v381 : unativeint = _v370 
                    let v384 : bool = v381 = v359 
                    if v384 then
                        let v387 : string = "true; break"
                        let v388 : bool = Fable.Core.RustInterop.emitRustExpr () v387 
                        ()
                    let v389 : unativeint = v381 |> unativeint 
                    let v392 : unativeint = v389 |> unbox<unativeint>
                    let v395 : string = "v363.len()"
                    let v396 : unativeint = Fable.Core.RustInterop.emitRustExpr () v395 
                    let v397 : bool = v392 = v396 
                    let v404 : Ref<Slice'<uint8>> =
                        if v397 then
                            let v400 : string = "&v363[v359..]"
                            let v401 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v400 
                            v401
                        else
                            let v402 : string = "&v363[$0..$1]"
                            let v403 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v359, v389) v402 
                            v403
                    let v405 : string = "sha2::Digest::update(&mut v356, v404)"
                    Fable.Core.RustInterop.emitRustExpr () v405 
                    let v406 : string = "true; } // rust.loop"
                    let v407 : bool = Fable.Core.RustInterop.emitRustExpr () v406 
                    let v408 : string = "true; } // rust.loop"
                    let v409 : bool = Fable.Core.RustInterop.emitRustExpr () v408 
                    let v410 : string = "true; } // rust.loop"
                    let v411 : bool = Fable.Core.RustInterop.emitRustExpr () v410 
                    let v412 : string = "true; { // rust.loop"
                    let v413 : bool = Fable.Core.RustInterop.emitRustExpr () v412 
                    let v414 : string = "true; { // rust.loop"
                    let v415 : bool = Fable.Core.RustInterop.emitRustExpr () v414 
                    let v416 : string = "&sha2::Digest::finalize(v356)"
                    let v417 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v416 
                    let v418 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
                    let v419 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v417 v418 
                    let v420 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
                    let v421 : bool = Fable.Core.RustInterop.emitRustExpr v419 v420 
                    let v422 : string = "x"
                    let v423 : uint8 = Fable.Core.RustInterop.emitRustExpr () v422 
                    let v424 : string = "format!(\"{:02x}\", $0)"
                    let v425 : std_string_String = Fable.Core.RustInterop.emitRustExpr v423 v424 
                    let v426 : string = "fable_library_rust::String_::fromString($0)"
                    let v427 : string = Fable.Core.RustInterop.emitRustExpr v425 v426 
                    let v428 : string = "true; $0 }).collect::<Vec<_>>()"
                    let v429 : bool = Fable.Core.RustInterop.emitRustExpr v427 v428 
                    let v430 : string = "_vec_map"
                    let v431 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v430 
                    let v432 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v433 : (string []) = Fable.Core.RustInterop.emitRustExpr v431 v432 
                    let v434 : unit = ()
                    let _v434 =
                        seq {
                            for i = 0 to v433.Length - 1 do yield v433.[i]
                            (* indent
                            ()
                        indent *)
                        }
                        (* indent
                        ()
                    indent *)
                    let v437 : string seq = _v434 
                    let v443 : string = method157()
                    let v444 : bool = v443 = "\n"
                    let v446 : string =
                        if v444 then
                            method61(v443)
                        else
                            v443
                    let v447 : (string -> (string seq -> string)) = String.concat
                    let v448 : (string seq -> string) = v447 v446
                    let v449 : string = v448 v437
                    let v452 : Result<string, std_io_Error> = Ok v449 
                    let v453 : (std_io_Error -> std_string_String) = method65()
                    let v454 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v455 : string = "$0.map_err(|x| $1(x))"
                    let v456 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v452, v453) v455 
                    let _v454 = v456 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v457 : string = "$0.map_err(|x| $1(x))"
                    let v458 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v452, v453) v457 
                    let _v454 = v458 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v459 : string = "$0.map_err(|x| $1(x))"
                    let v460 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v452, v453) v459 
                    let _v454 = v460 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v461 : Result<string, std_string_String> = match v452 with Ok x -> Ok x | Error x -> Error (v453 x)
                    let _v454 = v461 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v462 : Result<string, std_string_String> = match v452 with Ok x -> Ok x | Error x -> Error (v453 x)
                    let _v454 = v462 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v463 : Result<string, std_string_String> = match v452 with Ok x -> Ok x | Error x -> Error (v453 x)
                    let _v454 = v463 
                    #endif
#else
                    let v464 : Result<string, std_string_String> = match v452 with Ok x -> Ok x | Error x -> Error (v453 x)
                    let _v454 = v464 
                    #endif
                    let v465 : Result<string, std_string_String> = _v454 
                    let v468 : (string -> US33) = method158()
                    let v469 : (std_string_String -> US33) = method159()
                    let v470 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
                    let v471 : US33 = Fable.Core.RustInterop.emitRustExpr struct (v468, v469, v465) v470 
                    match v471 with
                    | US33_1(v474) -> (* Error *)
                        US5_1
                    | US33_0(v472) -> (* Ok *)
                        US5_0(v472)
            match v478 with
            | US5_0(v479) -> (* Some *)
                let v480 : bool = v327 = v479
                if v480 then
                    UH4_0
                else
                    let v482 : unit = ()
                    let v483 : (unit -> unit) = closure71(v134, v135, v137, v149, v148, v151, v163, v162, v165, v327, v478)
                    let v484 : unit = (fun () -> v483 (); v482) ()
                    method163(v165, v151)
                    let v532 : (string -> (string -> US32)) = closure76(v4, v3, v1, v0)
                    let v533 : UH5 = UH5_0
                    let v534 : UH5 = UH5_1(v166, v151, v532, v533)
                    let v535 : string = "html"
                    let v536 : (string -> (string -> US32)) = closure81(v4, v3, v169)
                    let v537 : string = "pdf"
                    let v538 : (string -> (string -> US32)) = closure81(v4, v3, v170)
                    let v539 : string = "epub"
                    let v540 : (string -> (string -> US32)) = closure81(v4, v3, v171)
                    let v541 : (string -> (string -> US32)) = closure81(v4, v3, v172)
                    let v542 : (string -> (string -> US32)) = closure81(v4, v3, v173)
                    let v543 : (string -> (string -> US32)) = closure81(v4, v3, v174)
                    let v544 : UH5 = UH5_0
                    let v545 : UH5 = UH5_1(v539, v167, v543, v544)
                    let v546 : UH5 = UH5_1(v537, v167, v542, v545)
                    let v547 : UH5 = UH5_1(v535, v167, v541, v546)
                    let v548 : UH5 = UH5_1(v539, v151, v540, v547)
                    let v549 : UH5 = UH5_1(v537, v151, v538, v548)
                    let v550 : UH5 = UH5_1(v535, v151, v536, v549)
                    let v551 : UH4 = UH4_0
                    let v552 : UH4 = UH4_1(v550, v551)
                    UH4_1(v534, v552)
            | _ ->
                let v555 : unit = ()
                let v556 : (unit -> unit) = closure71(v134, v135, v137, v149, v148, v151, v163, v162, v165, v327, v478)
                let v557 : unit = (fun () -> v556 (); v555) ()
                method163(v165, v151)
                let v605 : (string -> (string -> US32)) = closure76(v4, v3, v1, v0)
                let v606 : UH5 = UH5_0
                let v607 : UH5 = UH5_1(v166, v151, v605, v606)
                let v608 : string = "html"
                let v609 : (string -> (string -> US32)) = closure81(v4, v3, v169)
                let v610 : string = "pdf"
                let v611 : (string -> (string -> US32)) = closure81(v4, v3, v170)
                let v612 : string = "epub"
                let v613 : (string -> (string -> US32)) = closure81(v4, v3, v171)
                let v614 : (string -> (string -> US32)) = closure81(v4, v3, v172)
                let v615 : (string -> (string -> US32)) = closure81(v4, v3, v173)
                let v616 : (string -> (string -> US32)) = closure81(v4, v3, v174)
                let v617 : UH5 = UH5_0
                let v618 : UH5 = UH5_1(v612, v167, v616, v617)
                let v619 : UH5 = UH5_1(v610, v167, v615, v618)
                let v620 : UH5 = UH5_1(v608, v167, v614, v619)
                let v621 : UH5 = UH5_1(v612, v151, v613, v620)
                let v622 : UH5 = UH5_1(v610, v151, v611, v621)
                let v623 : UH5 = UH5_1(v608, v151, v609, v622)
                let v624 : UH4 = UH4_0
                let v625 : UH4 = UH4_1(v623, v624)
                UH4_1(v607, v625)
    let v629 : bool =
        match v628 with
        | UH4_0 -> (* Nil *)
            true
        | _ ->
            false
    let v630 : bool = v629 <> true
    let v1005 : UH4 =
        if v630 then
            v628
        else
            let v631 : string = "epub"
            let struct (v632 : string, v633 : string) = method156(v631, v167, v4)
            let v634 : bool = method160(v632)
            let v680 : bool =
                if v634 then
                    true
                else
                    let v635 : bool = method160(v633)
                    let v636 : bool = v635 = false
                    if v636 then
                        true
                    else
                        let v637 : unit = ()
                        let v638 : (unit -> unit) = closure84(v633, v632)
                        let v639 : unit = (fun () -> v638 (); v637) ()
                        method163(v632, v633)
                        false
            let v685 : UH5 =
                if v680 then
                    let v681 : (string -> (string -> US32)) = closure81(v4, v3, v174)
                    let v682 : UH5 = UH5_0
                    UH5_1(v631, v167, v681, v682)
                else
                    UH5_0
            let v686 : string = "pdf"
            let struct (v687 : string, v688 : string) = method156(v686, v167, v4)
            let v689 : bool = method160(v687)
            let v735 : bool =
                if v689 then
                    true
                else
                    let v690 : bool = method160(v688)
                    let v691 : bool = v690 = false
                    if v691 then
                        true
                    else
                        let v692 : unit = ()
                        let v693 : (unit -> unit) = closure84(v688, v687)
                        let v694 : unit = (fun () -> v693 (); v692) ()
                        method163(v687, v688)
                        false
            let v738 : UH5 =
                if v735 then
                    let v736 : (string -> (string -> US32)) = closure81(v4, v3, v173)
                    UH5_1(v686, v167, v736, v685)
                else
                    v685
            let v739 : string = "html"
            let struct (v740 : string, v741 : string) = method156(v739, v167, v4)
            let v742 : bool = method160(v740)
            let v788 : bool =
                if v742 then
                    true
                else
                    let v743 : bool = method160(v741)
                    let v744 : bool = v743 = false
                    if v744 then
                        true
                    else
                        let v745 : unit = ()
                        let v746 : (unit -> unit) = closure84(v741, v740)
                        let v747 : unit = (fun () -> v746 (); v745) ()
                        method163(v740, v741)
                        false
            let v791 : UH5 =
                if v788 then
                    let v789 : (string -> (string -> US32)) = closure81(v4, v3, v172)
                    UH5_1(v739, v167, v789, v738)
                else
                    v738
            let struct (v792 : string, v793 : string) = method156(v631, v151, v4)
            let v794 : bool = method160(v792)
            let v840 : bool =
                if v794 then
                    true
                else
                    let v795 : bool = method160(v793)
                    let v796 : bool = v795 = false
                    if v796 then
                        true
                    else
                        let v797 : unit = ()
                        let v798 : (unit -> unit) = closure84(v793, v792)
                        let v799 : unit = (fun () -> v798 (); v797) ()
                        method163(v792, v793)
                        false
            let v843 : UH5 =
                if v840 then
                    let v841 : (string -> (string -> US32)) = closure81(v4, v3, v171)
                    UH5_1(v631, v151, v841, v791)
                else
                    v791
            let struct (v844 : string, v845 : string) = method156(v686, v151, v4)
            let v846 : bool = method160(v844)
            let v892 : bool =
                if v846 then
                    true
                else
                    let v847 : bool = method160(v845)
                    let v848 : bool = v847 = false
                    if v848 then
                        true
                    else
                        let v849 : unit = ()
                        let v850 : (unit -> unit) = closure84(v845, v844)
                        let v851 : unit = (fun () -> v850 (); v849) ()
                        method163(v844, v845)
                        false
            let v895 : UH5 =
                if v892 then
                    let v893 : (string -> (string -> US32)) = closure81(v4, v3, v170)
                    UH5_1(v686, v151, v893, v843)
                else
                    v843
            let struct (v896 : string, v897 : string) = method156(v739, v151, v4)
            let v898 : bool = method160(v896)
            let v944 : bool =
                if v898 then
                    true
                else
                    let v899 : bool = method160(v897)
                    let v900 : bool = v899 = false
                    if v900 then
                        true
                    else
                        let v901 : unit = ()
                        let v902 : (unit -> unit) = closure84(v897, v896)
                        let v903 : unit = (fun () -> v902 (); v901) ()
                        method163(v896, v897)
                        false
            let v947 : UH5 =
                if v944 then
                    let v945 : (string -> (string -> US32)) = closure81(v4, v3, v169)
                    UH5_1(v739, v151, v945, v895)
                else
                    v895
            let struct (v948 : string, v949 : string) = method156(v166, v151, v4)
            let v950 : bool = method160(v948)
            let v996 : bool =
                if v950 then
                    true
                else
                    let v951 : bool = method160(v949)
                    let v952 : bool = v951 = false
                    if v952 then
                        true
                    else
                        let v953 : unit = ()
                        let v954 : (unit -> unit) = closure84(v949, v948)
                        let v955 : unit = (fun () -> v954 (); v953) ()
                        method163(v948, v949)
                        false
            let v1001 : UH5 =
                if v996 then
                    let v997 : (string -> (string -> US32)) = closure76(v4, v3, v1, v0)
                    let v998 : UH5 = UH5_0
                    UH5_1(v166, v151, v997, v998)
                else
                    UH5_0
            let v1002 : UH4 = UH4_0
            let v1003 : UH4 = UH4_1(v947, v1002)
            UH4_1(v1001, v1003)
    let v1006 : UH5 list = []
    let v1007 : UH5 list = method185(v1005, v1006)
    let v1008 : (UH5 list -> (UH5 [])) = List.toArray
    let v1009 : (UH5 []) = v1008 v1007
    let v1012 : string = "$0.to_vec()"
    let v1013 : Vec<UH5> = Fable.Core.RustInterop.emitRustExpr v1009 v1012 
    let v1014 : (Result<string, (string * string)> option []) = [||]
    let v1015 : string = "$0.to_vec()"
    let v1016 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1014 v1015 
    let v1017 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v1018 : (UH5 []) = Fable.Core.RustInterop.emitRustExpr v1013 v1017 
    let v1019 : int32 = v1018.Length
    let v1020 : Mut9 = {l0 = 0; l1 = v1016} : Mut9
    while method186(v1019, v1020) do
        let v1022 : int32 = v1020.l0
        let v1023 : Vec<Result<string, (string * string)> option> = v1020.l1
        let v1024 : UH5 = v1018.[int v1022]
        let v1025 : struct (string * string * (string -> (string -> US32))) list = []
        let v1026 : struct (string * string * (string -> (string -> US32))) list = method187(v1024, v1025)
        let v1027 : (struct (string * string * (string -> (string -> US32))) list -> (struct (string * string * (string -> (string -> US32))) [])) = List.toArray
        let v1028 : (struct (string * string * (string -> (string -> US32))) []) = v1027 v1026
        let v1031 : string = "$0.to_vec()"
        let v1032 : Vec<struct (string * string * (string -> (string -> US32)))> = Fable.Core.RustInterop.emitRustExpr v1028 v1031 
        let v1033 : string = "rayon::iter::IntoParallelIterator::into_par_iter($0)"
        let v1034 : rayon_vec_IntoIter<struct (string * string * (string -> (string -> US32)))> = Fable.Core.RustInterop.emitRustExpr v1032 v1033 
        let v1035 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
        let v1036 : (struct (string * string * (string -> (string -> US32))) -> Result<string, (string * string)> option) = closure85()
        let v1037 : rayon_iter_Map<rayon_vec_IntoIter<struct (string * string * (string -> (string -> US32)))>> = Fable.Core.RustInterop.emitRustExpr struct (v1034, v1036) v1035 
        let v1038 : string = "rayon::iter::ParallelIterator::collect($0)"
        let v1039 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1037 v1038 
        let v1040 : Vec<Result<string, (string * string)> option> = method188(v1039)
        let v1041 : Vec<Result<string, (string * string)> option> = method189(v1023)
        let v1042 : string = "true; let mut v1041 = v1041"
        let v1043 : bool = Fable.Core.RustInterop.emitRustExpr () v1042 
        let v1044 : string = "true; v1041.extend(v1040)"
        let v1045 : bool = Fable.Core.RustInterop.emitRustExpr () v1044 
        let v1046 : string = "v1041"
        let v1047 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr () v1046 
        let v1048 : int32 = v1022 + 1
        v1020.l0 <- v1048
        v1020.l1 <- v1047
        ()
    let v1049 : Vec<Result<string, (string * string)> option> = v1020.l1
    let v1050 : (string * Vec<Result<string, (string * string)> option>) = v135, v1049 
    let v1051 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v1050 
    v1051
and method190 (v0 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>) : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> =
    v0
and method25 (v0 : string, v1 : string, v2 : string, v3 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> =
    let v4 : string = __SOURCE_DIRECTORY__
    let v5 : string = "polyglot"
    let v6 : string = ".devcontainer"
    let v7 : string = method26(v5, v6)
    let v8 : US7 = method27(v7, v4)
    let v56 : US5 =
        match v8 with
        | US7_1(v11) -> (* Error *)
            let v12 : unit = ()
            let v13 : (unit -> unit) = closure13(v11)
            let v14 : unit = (fun () -> v13 (); v12) ()
            US5_1
        | US7_0(v9) -> (* Ok *)
            US5_0(v9)
    let v111 : US5 =
        match v56 with
        | US5_1 -> (* None *)
            let v59 : string = method34()
            let v60 : string = method26(v5, v6)
            let v61 : US7 = method27(v60, v59)
            match v61 with
            | US7_1(v64) -> (* Error *)
                let v65 : unit = ()
                let v66 : (unit -> unit) = closure13(v64)
                let v67 : unit = (fun () -> v66 (); v65) ()
                US5_1
            | US7_0(v62) -> (* Ok *)
                US5_0(v62)
        | US5_0(v57) -> (* Some *)
            US5_0(v57)
    let v115 : string =
        match v111 with
        | US5_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US5_0(v112) -> (* Some *)
            v112
    let v116 : string = method26(v115, v5)
    let v117 : string = method35(v3)
    let v118 : string = method35(v2)
    let v119 : string = method35(v1)
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure22(v0, v117, v118, v119)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v162 : string = "true; let __future_init = Box::pin(async move { //"
    let v163 : bool = Fable.Core.RustInterop.emitRustExpr () v162 
    let v164 : string = "async_walkdir::WalkDir::new(&*$0)"
    let v165 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr v118 v164 
    let v166 : string = "async_walkdir::WalkDir::filter($0, move |x| $1(x))"
    let v167 : (async_walkdir_DirEntry -> std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>>) = closure23()
    let v168 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr struct (v165, v167) v166 
    let v169 : (Result<async_walkdir_DirEntry, async_walkdir_Error> -> string option) = method70()
    let v170 : string = "futures::stream::StreamExt::filter_map(v168, |x| async { v169(x) })"
    let v171 : _ = Fable.Core.RustInterop.emitRustExpr () v170 
    let v172 : string = "Box::pin(futures::stream::StreamExt::collect(v171))"
    let v173 : std_pin_Pin<Box<Dyn<std_future_Future<Vec<string>>>>> = Fable.Core.RustInterop.emitRustExpr () v172 
    let v174 : string = "v173.await"
    let v175 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v174 
    let v176 : unit = ()
    let v177 : (unit -> unit) = closure32(v175)
    let v178 : unit = (fun () -> v177 (); v176) ()
    let v220 : string = "rayon::iter::IntoParallelIterator::into_par_iter($0)"
    let v221 : rayon_vec_IntoIter<string> = Fable.Core.RustInterop.emitRustExpr v175 v220 
    let v222 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
    let v223 : (string -> Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>) = closure33(v0, v116, v117, v118, v119)
    let v224 : rayon_iter_Map<rayon_vec_IntoIter<string>> = Fable.Core.RustInterop.emitRustExpr struct (v221, v223) v222 
    let v225 : string = "rayon::iter::ParallelIterator::collect($0)"
    let v226 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = Fable.Core.RustInterop.emitRustExpr v224 v225 
    let v227 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Ok v226 
    let v228 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = method190(v227)
    let v229 : string = ""
    let v230 : string = "}"
    let v231 : string = v229 + v230 
    let v232 : _ = v228 
    let v233 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v234 : string = $"true; let v232 = $0"
    let v235 : bool = Fable.Core.RustInterop.emitRustExpr v232 v234 
    let _v233 = v235 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v236 : string = $"true; let v232 = $0"
    let v237 : bool = Fable.Core.RustInterop.emitRustExpr v232 v236 
    let _v233 = v237 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v238 : string = $"true; let v232 = $0"
    let v239 : bool = Fable.Core.RustInterop.emitRustExpr v232 v238 
    let _v233 = v239 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v240 : bool = true
    let _v233 = v240 
    #endif
#if FABLE_COMPILER_PYTHON
    let v241 : bool = true
    let _v233 = v241 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v242 : bool = true
    let _v233 = v242 
    #endif
#else
    let v243 : bool = true
    let _v233 = v243 
    #endif
    let v244 : bool = _v233 
    let v247 : string = $"true; v232 " + v231 + "); " + v229 + " // rust.fix_closure'"
    let v248 : bool = Fable.Core.RustInterop.emitRustExpr () v247 
    let v249 : string = "__future_init"
    let v250 : _ = Fable.Core.RustInterop.emitRustExpr () v249 
    let v251 : string = "v250"
    let v252 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v251 
    v252
and closure86 () (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) : US36 =
    US36_0(v0)
and method191 () : (Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> -> US36) =
    closure86()
and closure87 () (v0 : std_string_String) : US36 =
    US36_1(v0)
and method192 () : (std_string_String -> US36) =
    closure87()
and method193 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method76(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "documents.main"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method18(v12)
and closure88 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_4
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method8(v19, v20, v21, v22, v23, v24)
        let v38 : string = method74()
        let v39 : string = method193(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method19(v39)
and method195 (v0 : unativeint) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure8(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "result_len"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure8(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure8(v2, v22)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "format!(\"{:#?}\", $0)"
    let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v31 
    let v33 : string = "fable_library_rust::String_::fromString($0)"
    let v34 : string = Fable.Core.RustInterop.emitRustExpr v32 v33 
    let _v30 = v34 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v35 : string = "format!(\"{:#?}\", $0)"
    let v36 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v35 
    let v37 : string = "fable_library_rust::String_::fromString($0)"
    let v38 : string = Fable.Core.RustInterop.emitRustExpr v36 v37 
    let _v30 = v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : string = "format!(\"{:#?}\", $0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v39 
    let v41 : string = "fable_library_rust::String_::fromString($0)"
    let v42 : string = Fable.Core.RustInterop.emitRustExpr v40 v41 
    let _v30 = v42 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v43 : string = $"%A{v0}"
    let _v30 = v43 
    #endif
#if FABLE_COMPILER_PYTHON
    let v46 : string = $"%A{v0}"
    let _v30 = v46 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v49 : string = $"%A{v0}"
    let _v30 = v49 
    #endif
#else
    let v52 : string = $"%A{v0}"
    let _v30 = v52 
    #endif
    let v55 : string = _v30 
    let v60 : string = $"{v55}"
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure8(v2, v60)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v68 : string = " }"
    let v69 : string = $"{v68}"
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure8(v2, v69)
    let v74 : unit = (fun () -> v73 (); v72) ()
    let v77 : string = v2.l0
    v77
and method194 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : unativeint) : string =
    let v9 : string = method195(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "documents.main"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method18(v12)
and closure89 (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) () : unit =
    let v1 : US0 = US0_2
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method8(v19, v20, v21, v22, v23, v24)
        let v38 : string = method12()
        let v39 : string = "$0.len()"
        let v40 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v39 
        let v41 : string = method194(v19, v20, v21, v22, v23, v24, v37, v38, v40)
        method19(v41)
and closure1 () (v0 : (string [])) : int32 =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure2()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure5(v0)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v59 : clap_Command = method0()
    let v60 : string = "clap::Command::get_matches($0)"
    let v61 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v59 v60 
    let v62 : string = method20()
    let v63 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v64 : string = "&*$0"
    let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v62 v64 
    let _v63 = v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v66 : string = "&*$0"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v62 v66 
    let _v63 = v67 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v68 : string = "&*$0"
    let v69 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v62 v68 
    let _v63 = v69 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v70 : Ref<Str> = v62 |> unbox<Ref<Str>>
    let _v63 = v70 
    #endif
#if FABLE_COMPILER_PYTHON
    let v73 : Ref<Str> = v62 |> unbox<Ref<Str>>
    let _v63 = v73 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v76 : Ref<Str> = v62 |> unbox<Ref<Str>>
    let _v63 = v76 
    #endif
#else
    let v79 : Ref<Str> = v62 |> unbox<Ref<Str>>
    let _v63 = v79 
    #endif
    let v82 : Ref<Str> = _v63 
    let v87 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v88 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v61, v82) v87 
    let v89 : (std_string_String -> US6) = method21()
    let v90 : US6 option = v88 |> Option.map v89 
    let v101 : US6 = US6_1
    let v102 : US6 = v90 |> Option.defaultValue v101 
    let v109 : std_string_String =
        match v102 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v106) -> (* Some *)
            v106
    let v110 : string = "fable_library_rust::String_::fromString($0)"
    let v111 : string = Fable.Core.RustInterop.emitRustExpr v109 v110 
    let v112 : string = method22()
    let v113 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v114 : string = "&*$0"
    let v115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v112 v114 
    let _v113 = v115 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v116 : string = "&*$0"
    let v117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v112 v116 
    let _v113 = v117 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v118 : string = "&*$0"
    let v119 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v112 v118 
    let _v113 = v119 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v120 : Ref<Str> = v112 |> unbox<Ref<Str>>
    let _v113 = v120 
    #endif
#if FABLE_COMPILER_PYTHON
    let v123 : Ref<Str> = v112 |> unbox<Ref<Str>>
    let _v113 = v123 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v126 : Ref<Str> = v112 |> unbox<Ref<Str>>
    let _v113 = v126 
    #endif
#else
    let v129 : Ref<Str> = v112 |> unbox<Ref<Str>>
    let _v113 = v129 
    #endif
    let v132 : Ref<Str> = _v113 
    let v137 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v138 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v61, v132) v137 
    let v139 : (std_string_String -> US6) = method21()
    let v140 : US6 option = v138 |> Option.map v139 
    let v151 : US6 = US6_1
    let v152 : US6 = v140 |> Option.defaultValue v151 
    let v159 : std_string_String =
        match v152 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v156) -> (* Some *)
            v156
    let v160 : string = "fable_library_rust::String_::fromString($0)"
    let v161 : string = Fable.Core.RustInterop.emitRustExpr v159 v160 
    let v162 : string = method23()
    let v163 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v164 : string = "&*$0"
    let v165 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v162 v164 
    let _v163 = v165 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v166 : string = "&*$0"
    let v167 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v162 v166 
    let _v163 = v167 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v168 : string = "&*$0"
    let v169 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v162 v168 
    let _v163 = v169 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v170 : Ref<Str> = v162 |> unbox<Ref<Str>>
    let _v163 = v170 
    #endif
#if FABLE_COMPILER_PYTHON
    let v173 : Ref<Str> = v162 |> unbox<Ref<Str>>
    let _v163 = v173 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v176 : Ref<Str> = v162 |> unbox<Ref<Str>>
    let _v163 = v176 
    #endif
#else
    let v179 : Ref<Str> = v162 |> unbox<Ref<Str>>
    let _v163 = v179 
    #endif
    let v182 : Ref<Str> = _v163 
    let v187 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v188 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v61, v182) v187 
    let v189 : (std_string_String -> US6) = method21()
    let v190 : US6 option = v188 |> Option.map v189 
    let v201 : US6 = US6_1
    let v202 : US6 = v190 |> Option.defaultValue v201 
    let v209 : std_string_String =
        match v202 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v206) -> (* Some *)
            v206
    let v210 : string = "fable_library_rust::String_::fromString($0)"
    let v211 : string = Fable.Core.RustInterop.emitRustExpr v209 v210 
    let v212 : string = method24()
    let v213 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v214 : string = "&*$0"
    let v215 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v212 v214 
    let _v213 = v215 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v216 : string = "&*$0"
    let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v212 v216 
    let _v213 = v217 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v218 : string = "&*$0"
    let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v212 v218 
    let _v213 = v219 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v220 : Ref<Str> = v212 |> unbox<Ref<Str>>
    let _v213 = v220 
    #endif
#if FABLE_COMPILER_PYTHON
    let v223 : Ref<Str> = v212 |> unbox<Ref<Str>>
    let _v213 = v223 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v226 : Ref<Str> = v212 |> unbox<Ref<Str>>
    let _v213 = v226 
    #endif
#else
    let v229 : Ref<Str> = v212 |> unbox<Ref<Str>>
    let _v213 = v229 
    #endif
    let v232 : Ref<Str> = _v213 
    let v237 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v238 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v61, v232) v237 
    let v239 : (std_string_String -> US6) = method21()
    let v240 : US6 option = v238 |> Option.map v239 
    let v251 : US6 = US6_1
    let v252 : US6 = v240 |> Option.defaultValue v251 
    let v259 : std_string_String =
        match v252 with
        | US6_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US6_0(v256) -> (* Some *)
            v256
    let v260 : string = "fable_library_rust::String_::fromString($0)"
    let v261 : string = Fable.Core.RustInterop.emitRustExpr v259 v260 
    let v262 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = method25(v261, v211, v161, v111)
    let v263 : string = "futures::executor::block_on($0)"
    let v264 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr v262 v263 
    let v265 : (Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> -> US36) = method191()
    let v266 : (std_string_String -> US36) = method192()
    let v267 : US36 = match v264 with Ok x -> v265 x | Error x -> v266 x
    match v267 with
    | US36_1(v313) -> (* Error *)
        let v314 : unit = ()
        let v315 : (unit -> unit) = closure88(v313)
        let v316 : unit = (fun () -> v315 (); v314) ()
        1
    | US36_0(v268) -> (* Ok *)
        let v269 : unit = ()
        let v270 : (unit -> unit) = closure89(v268)
        let v271 : unit = (fun () -> v270 (); v269) ()
        0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
