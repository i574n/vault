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
and method4 () : string =
    let v0 : string = ""
    v0
and closure3 () (v0 : string) : US5 =
    US5_0(v0)
and method5 () : (string -> US5) =
    closure3()
and method3 (v0 : string) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "std::env::var(&*$0)"
    let v3 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "x"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v6 
    let v8 : string = "fable_library_rust::String_::fromString($0)"
    let v9 : string = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "true; $0 })"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "_result_map_"
    let v13 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = method4()
    let v15 : string = "$0.unwrap_or($1)"
    let v16 : string = Fable.Core.RustInterop.emitRustExpr struct (v13, v14) v15 
    let _v1 = v16 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : US3 = US3_1
    let v18 : US4 = US4_2(v17)
    let v19 : string = $"env.get_environment_variable / target: {v18} / var: {v0}"
    let v20 : string = failwith<string> v19
    let _v1 = v20 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v21 : US3 = US3_2
    let v22 : US4 = US4_2(v21)
    let v23 : string = $"env.get_environment_variable / target: {v22} / var: {v0}"
    let v24 : string = failwith<string> v23
    let _v1 = v24 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v25 : string = "process.env[$0] ?? \"\""
    let v26 : string = Fable.Core.JsInterop.emitJsExpr v0 v25 
    let _v1 = v26 
    #endif
#if FABLE_COMPILER_PYTHON
    let v27 : string = "os"
    let v28 : IOsEnviron = Fable.Core.PyInterop.importAll v27 
    let v29 : string = "v28.environ"
    let v30 : obj = Fable.Core.PyInterop.emitPyExpr () v29 
    let v33 : string = "v30.get($0)"
    let v34 : string = Fable.Core.PyInterop.emitPyExpr v0 v33 
    let mutable _v34 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v37 : (string -> string option) = Option.ofObj
    let v38 : string option = v37 v34
    v38 
    #else
    Some v34 
    #endif
    |> fun x -> _v34 <- Some x
    let v39 : string option = match _v34 with Some x -> x | None -> failwith "optionm'.of_obj / _v34=None"
    let v42 : (string -> US5) = method5()
    let v43 : US5 option = v39 |> Option.map v42 
    let v54 : US5 = US5_1
    let v55 : US5 = v43 |> Option.defaultValue v54 
    let v62 : string =
        match v55 with
        | US5_1 -> (* None *)
            let v60 : string = ""
            v60
        | US5_0(v59) -> (* Some *)
            v59
    let _v1 = v62 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : US3 = US3_1
    let v64 : US4 = US4_0(v63)
    let v65 : string = $"env.get_environment_variable / target: {v64} / var: {v0}"
    let v66 : string = failwith<string> v65
    let _v1 = v66 
    #endif
#else
    let v67 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v68 : string = v67 v0
    let mutable _v68 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v69 : (string -> string option) = Option.ofObj
    let v70 : string option = v69 v68
    v70 
    #else
    Some v68 
    #endif
    |> fun x -> _v68 <- Some x
    let v71 : string option = match _v68 with Some x -> x | None -> failwith "optionm'.of_obj / _v68=None"
    let v74 : (string -> US5) = method5()
    let v75 : US5 option = v71 |> Option.map v74 
    let v86 : US5 = US5_1
    let v87 : US5 = v75 |> Option.defaultValue v86 
    let v94 : string =
        match v87 with
        | US5_1 -> (* None *)
            let v92 : string = ""
            v92
        | US5_0(v91) -> (* Some *)
            v91
    let _v1 = v94 
    #endif
    let v95 : string = _v1 
    v95
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
    let v8 : string = "env!(\"" + v6 + "\")"
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
    let v36 : string = "env!(\"" + v6 + "\")"
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
    let v64 : string = "env!(\"" + v6 + "\")"
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
and method6 (v0 : US0) : bool =
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
and method8 () : (int64 -> US2) =
    closure7()
and method9 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method10 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method7 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US2) = method8()
    let v8 : US2 option = v5 |> Option.map v7 
    let v19 : US2 = US2_1
    let v20 : US2 = v8 |> Option.defaultValue v19 
    let v116 : System.DateTime =
        match v20 with
        | US2_1 -> (* None *)
            let v100 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v101 : System.DateTime = System.DateTime.Now
            let _v100 = v101 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v102 : System.DateTime = System.DateTime.Now
            let _v100 = v102 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v103 : System.DateTime = null |> unbox<System.DateTime>
            let _v100 = v103 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v106 : System.DateTime = System.DateTime.Now
            let _v100 = v106 
            #endif
#if FABLE_COMPILER_PYTHON
            let v107 : System.DateTime = System.DateTime.Now
            let _v100 = v107 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v108 : System.DateTime = System.DateTime.Now
            let _v100 = v108 
            #endif
#else
            let v109 : System.DateTime = System.DateTime.Now
            let _v100 = v109 
            #endif
            let v110 : System.DateTime = _v100 
            v110
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
            let v77 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v78 : System.TimeSpan = v77 v76
            let v81 : (System.TimeSpan -> int32) = _.Hours
            let v82 : int32 = v81 v78
            let v85 : (System.TimeSpan -> int32) = _.Minutes
            let v86 : int32 = v85 v78
            let v89 : (System.TimeSpan -> int32) = _.Seconds
            let v90 : int32 = v89 v78
            let v93 : (System.TimeSpan -> int32) = _.Milliseconds
            let v94 : int32 = v93 v78
            let v97 : System.DateTime = System.DateTime (1, 1, 1, v82, v86, v90, v94)
            v97
    let v117 : string = method9()
    let v120 : (string -> string) = v116.ToString
    let v121 : string = v120 v117
    let _v6 = v121 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v124 : (int64 -> US2) = method8()
    let v125 : US2 option = v5 |> Option.map v124 
    let v136 : US2 = US2_1
    let v137 : US2 = v125 |> Option.defaultValue v136 
    let v233 : System.DateTime =
        match v137 with
        | US2_1 -> (* None *)
            let v217 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v218 : System.DateTime = System.DateTime.Now
            let _v217 = v218 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v219 : System.DateTime = System.DateTime.Now
            let _v217 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : System.DateTime = null |> unbox<System.DateTime>
            let _v217 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : System.DateTime = System.DateTime.Now
            let _v217 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v224 : System.DateTime = System.DateTime.Now
            let _v217 = v224 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v225 : System.DateTime = System.DateTime.Now
            let _v217 = v225 
            #endif
#else
            let v226 : System.DateTime = System.DateTime.Now
            let _v217 = v226 
            #endif
            let v227 : System.DateTime = _v217 
            v227
        | US2_0(v141) -> (* Some *)
            let v142 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v143 : System.DateTime = System.DateTime.Now
            let _v142 = v143 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v144 : System.DateTime = System.DateTime.Now
            let _v142 = v144 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v145 : System.DateTime = null |> unbox<System.DateTime>
            let _v142 = v145 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v148 : System.DateTime = System.DateTime.Now
            let _v142 = v148 
            #endif
#if FABLE_COMPILER_PYTHON
            let v149 : System.DateTime = System.DateTime.Now
            let _v142 = v149 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v150 : System.DateTime = System.DateTime.Now
            let _v142 = v150 
            #endif
#else
            let v151 : System.DateTime = System.DateTime.Now
            let _v142 = v151 
            #endif
            let v152 : System.DateTime = _v142 
            let v157 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v158 : (System.DateTime -> int64) = _.Ticks
            let v159 : int64 = v158 v152
            let _v157 = v159 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v160 : (System.DateTime -> int64) = _.Ticks
            let v161 : int64 = v160 v152
            let _v157 = v161 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v162 : int64 = null |> unbox<int64>
            let _v157 = v162 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v165 : (System.DateTime -> int64) = _.Ticks
            let v166 : int64 = v165 v152
            let _v157 = v166 
            #endif
#if FABLE_COMPILER_PYTHON
            let v167 : (System.DateTime -> int64) = _.Ticks
            let v168 : int64 = v167 v152
            let _v157 = v168 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v169 : (System.DateTime -> int64) = _.Ticks
            let v170 : int64 = v169 v152
            let _v157 = v170 
            #endif
#else
            let v171 : (System.DateTime -> int64) = _.Ticks
            let v172 : int64 = v171 v152
            let _v157 = v172 
            #endif
            let v173 : int64 = _v157 
            let v190 : int64 = v173 |> int64 
            let v193 : int64 = v190 - v141
            let v194 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v195 : System.TimeSpan = v194 v193
            let v198 : (System.TimeSpan -> int32) = _.Hours
            let v199 : int32 = v198 v195
            let v202 : (System.TimeSpan -> int32) = _.Minutes
            let v203 : int32 = v202 v195
            let v206 : (System.TimeSpan -> int32) = _.Seconds
            let v207 : int32 = v206 v195
            let v210 : (System.TimeSpan -> int32) = _.Milliseconds
            let v211 : int32 = v210 v195
            let v214 : System.DateTime = System.DateTime (1, 1, 1, v199, v203, v207, v211)
            v214
    let v234 : string = method9()
    let v237 : (string -> string) = v233.ToString
    let v238 : string = v237 v234
    let _v6 = v238 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v241 : string = $"near_sdk::env::block_timestamp()"
    let v242 : uint64 = Fable.Core.RustInterop.emitRustExpr () v241 
    let v243 : (int64 -> US2) = method8()
    let v244 : US2 option = v5 |> Option.map v243 
    let v255 : US2 = US2_1
    let v256 : US2 = v244 |> Option.defaultValue v255 
    let v267 : uint64 =
        match v256 with
        | US2_1 -> (* None *)
            v242
        | US2_0(v260) -> (* Some *)
            let v261 : (int64 -> uint64) = uint64
            let v262 : uint64 = v261 v260
            let v265 : uint64 = v242 - v262
            v265
    let v268 : uint64 = v267 / 1000000000UL
    let v269 : uint64 = v268 % 60UL
    let v270 : uint64 = v268 / 60UL
    let v271 : uint64 = v270 % 60UL
    let v272 : uint64 = v268 / 3600UL
    let v273 : uint64 = v272 % 24UL
    let v274 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v275 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v273, v271, v269) v274 
    let v276 : string = "fable_library_rust::String_::fromString($0)"
    let v277 : string = Fable.Core.RustInterop.emitRustExpr v275 v276 
    let _v6 = v277 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v278 : (int64 -> US2) = method8()
    let v279 : US2 option = v5 |> Option.map v278 
    let v290 : US2 = US2_1
    let v291 : US2 = v279 |> Option.defaultValue v290 
    let v387 : System.DateTime =
        match v291 with
        | US2_1 -> (* None *)
            let v371 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v372 : System.DateTime = System.DateTime.Now
            let _v371 = v372 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v373 : System.DateTime = System.DateTime.Now
            let _v371 = v373 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v374 : System.DateTime = null |> unbox<System.DateTime>
            let _v371 = v374 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v377 : System.DateTime = System.DateTime.Now
            let _v371 = v377 
            #endif
#if FABLE_COMPILER_PYTHON
            let v378 : System.DateTime = System.DateTime.Now
            let _v371 = v378 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v379 : System.DateTime = System.DateTime.Now
            let _v371 = v379 
            #endif
#else
            let v380 : System.DateTime = System.DateTime.Now
            let _v371 = v380 
            #endif
            let v381 : System.DateTime = _v371 
            v381
        | US2_0(v295) -> (* Some *)
            let v296 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v297 : System.DateTime = System.DateTime.Now
            let _v296 = v297 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v298 : System.DateTime = System.DateTime.Now
            let _v296 = v298 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v299 : System.DateTime = null |> unbox<System.DateTime>
            let _v296 = v299 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v302 : System.DateTime = System.DateTime.Now
            let _v296 = v302 
            #endif
#if FABLE_COMPILER_PYTHON
            let v303 : System.DateTime = System.DateTime.Now
            let _v296 = v303 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v304 : System.DateTime = System.DateTime.Now
            let _v296 = v304 
            #endif
#else
            let v305 : System.DateTime = System.DateTime.Now
            let _v296 = v305 
            #endif
            let v306 : System.DateTime = _v296 
            let v311 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v312 : (System.DateTime -> int64) = _.Ticks
            let v313 : int64 = v312 v306
            let _v311 = v313 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v314 : (System.DateTime -> int64) = _.Ticks
            let v315 : int64 = v314 v306
            let _v311 = v315 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v316 : int64 = null |> unbox<int64>
            let _v311 = v316 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v319 : (System.DateTime -> int64) = _.Ticks
            let v320 : int64 = v319 v306
            let _v311 = v320 
            #endif
#if FABLE_COMPILER_PYTHON
            let v321 : (System.DateTime -> int64) = _.Ticks
            let v322 : int64 = v321 v306
            let _v311 = v322 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v323 : (System.DateTime -> int64) = _.Ticks
            let v324 : int64 = v323 v306
            let _v311 = v324 
            #endif
#else
            let v325 : (System.DateTime -> int64) = _.Ticks
            let v326 : int64 = v325 v306
            let _v311 = v326 
            #endif
            let v327 : int64 = _v311 
            let v344 : int64 = v327 |> int64 
            let v347 : int64 = v344 - v295
            let v348 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v349 : System.TimeSpan = v348 v347
            let v352 : (System.TimeSpan -> int32) = _.Hours
            let v353 : int32 = v352 v349
            let v356 : (System.TimeSpan -> int32) = _.Minutes
            let v357 : int32 = v356 v349
            let v360 : (System.TimeSpan -> int32) = _.Seconds
            let v361 : int32 = v360 v349
            let v364 : (System.TimeSpan -> int32) = _.Milliseconds
            let v365 : int32 = v364 v349
            let v368 : System.DateTime = System.DateTime (1, 1, 1, v353, v357, v361, v365)
            v368
    let v388 : string = method10()
    let v391 : (string -> string) = v387.ToString
    let v392 : string = v391 v388
    let _v6 = v392 
    #endif
#if FABLE_COMPILER_PYTHON
    let v395 : (int64 -> US2) = method8()
    let v396 : US2 option = v5 |> Option.map v395 
    let v407 : US2 = US2_1
    let v408 : US2 = v396 |> Option.defaultValue v407 
    let v504 : System.DateTime =
        match v408 with
        | US2_1 -> (* None *)
            let v488 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v489 : System.DateTime = System.DateTime.Now
            let _v488 = v489 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v490 : System.DateTime = System.DateTime.Now
            let _v488 = v490 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v491 : System.DateTime = null |> unbox<System.DateTime>
            let _v488 = v491 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v494 : System.DateTime = System.DateTime.Now
            let _v488 = v494 
            #endif
#if FABLE_COMPILER_PYTHON
            let v495 : System.DateTime = System.DateTime.Now
            let _v488 = v495 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v496 : System.DateTime = System.DateTime.Now
            let _v488 = v496 
            #endif
#else
            let v497 : System.DateTime = System.DateTime.Now
            let _v488 = v497 
            #endif
            let v498 : System.DateTime = _v488 
            v498
        | US2_0(v412) -> (* Some *)
            let v413 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v414 : System.DateTime = System.DateTime.Now
            let _v413 = v414 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v415 : System.DateTime = System.DateTime.Now
            let _v413 = v415 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v416 : System.DateTime = null |> unbox<System.DateTime>
            let _v413 = v416 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v419 : System.DateTime = System.DateTime.Now
            let _v413 = v419 
            #endif
#if FABLE_COMPILER_PYTHON
            let v420 : System.DateTime = System.DateTime.Now
            let _v413 = v420 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v421 : System.DateTime = System.DateTime.Now
            let _v413 = v421 
            #endif
#else
            let v422 : System.DateTime = System.DateTime.Now
            let _v413 = v422 
            #endif
            let v423 : System.DateTime = _v413 
            let v428 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v429 : (System.DateTime -> int64) = _.Ticks
            let v430 : int64 = v429 v423
            let _v428 = v430 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v431 : (System.DateTime -> int64) = _.Ticks
            let v432 : int64 = v431 v423
            let _v428 = v432 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v433 : int64 = null |> unbox<int64>
            let _v428 = v433 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v436 : (System.DateTime -> int64) = _.Ticks
            let v437 : int64 = v436 v423
            let _v428 = v437 
            #endif
#if FABLE_COMPILER_PYTHON
            let v438 : (System.DateTime -> int64) = _.Ticks
            let v439 : int64 = v438 v423
            let _v428 = v439 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v440 : (System.DateTime -> int64) = _.Ticks
            let v441 : int64 = v440 v423
            let _v428 = v441 
            #endif
#else
            let v442 : (System.DateTime -> int64) = _.Ticks
            let v443 : int64 = v442 v423
            let _v428 = v443 
            #endif
            let v444 : int64 = _v428 
            let v461 : int64 = v444 |> int64 
            let v464 : int64 = v461 - v412
            let v465 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v466 : System.TimeSpan = v465 v464
            let v469 : (System.TimeSpan -> int32) = _.Hours
            let v470 : int32 = v469 v466
            let v473 : (System.TimeSpan -> int32) = _.Minutes
            let v474 : int32 = v473 v466
            let v477 : (System.TimeSpan -> int32) = _.Seconds
            let v478 : int32 = v477 v466
            let v481 : (System.TimeSpan -> int32) = _.Milliseconds
            let v482 : int32 = v481 v466
            let v485 : System.DateTime = System.DateTime (1, 1, 1, v470, v474, v478, v482)
            v485
    let v505 : string = method10()
    let v508 : (string -> string) = v504.ToString
    let v509 : string = v508 v505
    let _v6 = v509 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v512 : (int64 -> US2) = method8()
    let v513 : US2 option = v5 |> Option.map v512 
    let v524 : US2 = US2_1
    let v525 : US2 = v513 |> Option.defaultValue v524 
    let v621 : System.DateTime =
        match v525 with
        | US2_1 -> (* None *)
            let v605 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v606 : System.DateTime = System.DateTime.Now
            let _v605 = v606 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v607 : System.DateTime = System.DateTime.Now
            let _v605 = v607 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v608 : System.DateTime = null |> unbox<System.DateTime>
            let _v605 = v608 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v611 : System.DateTime = System.DateTime.Now
            let _v605 = v611 
            #endif
#if FABLE_COMPILER_PYTHON
            let v612 : System.DateTime = System.DateTime.Now
            let _v605 = v612 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v613 : System.DateTime = System.DateTime.Now
            let _v605 = v613 
            #endif
#else
            let v614 : System.DateTime = System.DateTime.Now
            let _v605 = v614 
            #endif
            let v615 : System.DateTime = _v605 
            v615
        | US2_0(v529) -> (* Some *)
            let v530 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v531 : System.DateTime = System.DateTime.Now
            let _v530 = v531 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v532 : System.DateTime = System.DateTime.Now
            let _v530 = v532 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v533 : System.DateTime = null |> unbox<System.DateTime>
            let _v530 = v533 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v536 : System.DateTime = System.DateTime.Now
            let _v530 = v536 
            #endif
#if FABLE_COMPILER_PYTHON
            let v537 : System.DateTime = System.DateTime.Now
            let _v530 = v537 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v538 : System.DateTime = System.DateTime.Now
            let _v530 = v538 
            #endif
#else
            let v539 : System.DateTime = System.DateTime.Now
            let _v530 = v539 
            #endif
            let v540 : System.DateTime = _v530 
            let v545 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v546 : (System.DateTime -> int64) = _.Ticks
            let v547 : int64 = v546 v540
            let _v545 = v547 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v548 : (System.DateTime -> int64) = _.Ticks
            let v549 : int64 = v548 v540
            let _v545 = v549 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v550 : int64 = null |> unbox<int64>
            let _v545 = v550 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v553 : (System.DateTime -> int64) = _.Ticks
            let v554 : int64 = v553 v540
            let _v545 = v554 
            #endif
#if FABLE_COMPILER_PYTHON
            let v555 : (System.DateTime -> int64) = _.Ticks
            let v556 : int64 = v555 v540
            let _v545 = v556 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v557 : (System.DateTime -> int64) = _.Ticks
            let v558 : int64 = v557 v540
            let _v545 = v558 
            #endif
#else
            let v559 : (System.DateTime -> int64) = _.Ticks
            let v560 : int64 = v559 v540
            let _v545 = v560 
            #endif
            let v561 : int64 = _v545 
            let v578 : int64 = v561 |> int64 
            let v581 : int64 = v578 - v529
            let v582 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v583 : System.TimeSpan = v582 v581
            let v586 : (System.TimeSpan -> int32) = _.Hours
            let v587 : int32 = v586 v583
            let v590 : (System.TimeSpan -> int32) = _.Minutes
            let v591 : int32 = v590 v583
            let v594 : (System.TimeSpan -> int32) = _.Seconds
            let v595 : int32 = v594 v583
            let v598 : (System.TimeSpan -> int32) = _.Milliseconds
            let v599 : int32 = v598 v583
            let v602 : System.DateTime = System.DateTime (1, 1, 1, v587, v591, v595, v599)
            v602
    let v622 : string = method10()
    let v625 : (string -> string) = v621.ToString
    let v626 : string = v625 v622
    let _v6 = v626 
    #endif
#else
    let v629 : (int64 -> US2) = method8()
    let v630 : US2 option = v5 |> Option.map v629 
    let v641 : US2 = US2_1
    let v642 : US2 = v630 |> Option.defaultValue v641 
    let v738 : System.DateTime =
        match v642 with
        | US2_1 -> (* None *)
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
            v732
        | US2_0(v646) -> (* Some *)
            let v647 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v648 : System.DateTime = System.DateTime.Now
            let _v647 = v648 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v649 : System.DateTime = System.DateTime.Now
            let _v647 = v649 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v650 : System.DateTime = null |> unbox<System.DateTime>
            let _v647 = v650 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v653 : System.DateTime = System.DateTime.Now
            let _v647 = v653 
            #endif
#if FABLE_COMPILER_PYTHON
            let v654 : System.DateTime = System.DateTime.Now
            let _v647 = v654 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v655 : System.DateTime = System.DateTime.Now
            let _v647 = v655 
            #endif
#else
            let v656 : System.DateTime = System.DateTime.Now
            let _v647 = v656 
            #endif
            let v657 : System.DateTime = _v647 
            let v662 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v663 : (System.DateTime -> int64) = _.Ticks
            let v664 : int64 = v663 v657
            let _v662 = v664 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v665 : (System.DateTime -> int64) = _.Ticks
            let v666 : int64 = v665 v657
            let _v662 = v666 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v667 : int64 = null |> unbox<int64>
            let _v662 = v667 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v670 : (System.DateTime -> int64) = _.Ticks
            let v671 : int64 = v670 v657
            let _v662 = v671 
            #endif
#if FABLE_COMPILER_PYTHON
            let v672 : (System.DateTime -> int64) = _.Ticks
            let v673 : int64 = v672 v657
            let _v662 = v673 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v674 : (System.DateTime -> int64) = _.Ticks
            let v675 : int64 = v674 v657
            let _v662 = v675 
            #endif
#else
            let v676 : (System.DateTime -> int64) = _.Ticks
            let v677 : int64 = v676 v657
            let _v662 = v677 
            #endif
            let v678 : int64 = _v662 
            let v695 : int64 = v678 |> int64 
            let v698 : int64 = v695 - v646
            let v699 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v700 : System.TimeSpan = v699 v698
            let v703 : (System.TimeSpan -> int32) = _.Hours
            let v704 : int32 = v703 v700
            let v707 : (System.TimeSpan -> int32) = _.Minutes
            let v708 : int32 = v707 v700
            let v711 : (System.TimeSpan -> int32) = _.Seconds
            let v712 : int32 = v711 v700
            let v715 : (System.TimeSpan -> int32) = _.Milliseconds
            let v716 : int32 = v715 v700
            let v719 : System.DateTime = System.DateTime (1, 1, 1, v704, v708, v712, v716)
            v719
    let v739 : string = method10()
    let v742 : (string -> string) = v738.ToString
    let v743 : string = v742 v739
    let _v6 = v743 
    #endif
    let v746 : string = _v6 
    v746
and method13 () : string =
    let v0 : string = ""
    v0
and closure8 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method12 (v0 : char) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure8(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method14 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method11 () : string =
    
    
    
    
    
    let v0 : string = "Info"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method12(v5)
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
    let v105 : string = method14()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[92m"
    let v109 : string = method14()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[92m"
    let v113 : string = method14()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[92m"
    let v117 : string = method14()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method16 (v0 : (string [])) : string =
    let v1 : string = method13()
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
and method17 (v0 : string) : string =
    let v1 : char list = []
    let v2 : (char list -> (char [])) = List.toArray
    let v3 : (char []) = v2 v1
    let v6 : string = v0.TrimStart v3 
    let v28 : char list = []
    let v29 : char list = '/' :: v28 
    let v32 : char list = ' ' :: v29 
    let v35 : (char list -> (char [])) = List.toArray
    let v36 : (char []) = v35 v32
    let v39 : string = v6.TrimEnd v36 
    v39
and method15 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : (string [])) : string =
    let v9 : string = method16(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "documents.main"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method17(v12)
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
and method18 (v0 : string) : unit =
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
    let _v41 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v43 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v43 
    let _v41 = () 
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
    let _v41 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v40 v0
    let _v41 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    v40 v0
    let _v41 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v40 v0
    let _v41 = () 
    #endif
#else
    v40 v0
    let _v41 = () 
    #endif
    _v41 
    let v121 : (string -> unit) = v18.l0
    v121 v0
and closure5 (v0 : (string [])) () : unit =
    let v1 : US0 = US0_2
    let v2 : bool = method6(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method11()
        let v39 : string = method15(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method18(v39)
and method19 () : string =
    let v0 : string = "source-dir"
    v0
and closure12 () (v0 : std_string_String) : US6 =
    US6_0(v0)
and method20 () : (std_string_String -> US6) =
    closure12()
and method21 () : string =
    let v0 : string = "dist-dir"
    v0
and method22 () : string =
    let v0 : string = "cache-dir"
    v0
and method23 () : string =
    let v0 : string = "hangul-spec"
    v0
and method27 (v0 : string) : string =
    v0
and method26 (v0 : string, v1 : string) : struct (string * string) =
    let v2 : string = method27(v0)
    struct (v1, v2)
and method25 (v0 : string, v1 : string) : string =
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
    let struct (v184 : string, v185 : string) = method26(v1, v0)
    let v186 : string = "v183.join($0, $1)"
    let v187 : string = Fable.Core.JsInterop.emitJsExpr struct (v184, v185) v186 
    let _v2 = v187 
    #endif
#if FABLE_COMPILER_PYTHON
    let v188 : US3 = US3_0
    let v189 : US4 = US4_4(v188)
    let v190 : string = $"file_system.(</>) / target: {v189} / a: {v0} / b: {v1}"
    let v191 : string = failwith<string> v190
    let _v2 = v191 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v192 : US3 = US3_1
    let v193 : US4 = US4_0(v192)
    let v194 : string = $"file_system.(</>) / target: {v193} / a: {v0} / b: {v1}"
    let v195 : string = failwith<string> v194
    let _v2 = v195 
    #endif
#else
    let v196 : string = System.IO.Path.Combine (v0, v1)
    let _v2 = v196 
    #endif
    let v197 : string = _v2 
    v197
and method29 (v0 : string) : bool =
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
and method31 (v0 : string) : string option =
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
    let v188 : US5 =
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
            let v181 : string = v154.FullName
            let _v162 = v181 
            #endif
            let v182 : string = _v162 
            US5_0(v182)
    let v195 : string option =
        match v188 with
        | US5_1 -> (* None *)
            let v193 : string option = None
            v193
        | US5_0(v189) -> (* Some *)
            let v190 : string option = Some v189 
            v190
    let _v1 = v195 
    #endif
    let v196 : string option = _v1 
    v196
and closure13 () (v0 : string) : string option =
    method31(v0)
and method30 () : (string -> string option) =
    closure13()
and method32 (v0 : string, v1 : string, v2 : string) : US7 =
    let v3 : string = method25(v2, v0)
    let v4 : bool = method29(v3)
    if v4 then
        US7_0(v2)
    else
        let v6 : (string -> string option) = method30()
        let v7 : string option = v6 v2
        let v8 : (string -> US5) = method5()
        let v9 : US5 option = v7 |> Option.map v8 
        let v20 : US5 = US5_1
        let v21 : US5 = v9 |> Option.defaultValue v20 
        match v21 with
        | US5_1 -> (* None *)
            let v27 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            US7_1(v27)
        | US5_0(v25) -> (* Some *)
            method32(v0, v1, v25)
and method28 (v0 : string, v1 : string) : US7 =
    let v2 : string = method25(v1, v0)
    let v3 : bool = method29(v2)
    if v3 then
        US7_0(v1)
    else
        let v5 : (string -> string option) = method30()
        let v6 : string option = v5 v1
        let v7 : (string -> US5) = method5()
        let v8 : US5 option = v6 |> Option.map v7 
        let v19 : US5 = US5_1
        let v20 : US5 = v8 |> Option.defaultValue v19 
        match v20 with
        | US5_1 -> (* None *)
            let v26 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            US7_1(v26)
        | US5_0(v24) -> (* Some *)
            method32(v0, v1, v24)
and method33 () : string =
    
    
    
    
    
    let v0 : string = "Warning"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method12(v5)
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
    let v105 : string = method14()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[93m"
    let v109 : string = method14()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[93m"
    let v113 : string = method14()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[93m"
    let v117 : string = method14()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method35 (v0 : string) : string =
    let v1 : string = method13()
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
and method34 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method35(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "file_system.get_workspace_root"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method17(v12)
and closure14 (v0 : string) () : unit =
    let v1 : US0 = US0_3
    let v2 : bool = method6(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method33()
        let v39 : string = method34(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method18(v39)
and method36 () : string =
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
and method42 (v0 : std_io_Error) : string =
    let v1 : string = method13()
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
and closure15 () (v0 : std_io_Error) : string =
    method42(v0)
and method41 () : (std_io_Error -> string) =
    closure15()
and closure16 () (v0 : std_path_PathBuf) : US8 =
    US8_0(v0)
and method43 () : (std_path_PathBuf -> US8) =
    closure16()
and closure17 () (v0 : string) : US8 =
    US8_1(v0)
and method44 () : (string -> US8) =
    closure17()
and method47 (v0 : string) : string =
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
    let v116 : (string -> US5) = method5()
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
and method48 (v0 : string) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure8(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method46 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : string, v4 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v5 : string = method47(v4)
    let v6 : string option = method31(v4)
    let v7 : (string -> US5) = method5()
    let v8 : US5 option = v6 |> Option.map v7 
    let v19 : US5 = US5_1
    let v20 : US5 = v8 |> Option.defaultValue v19 
    let v24 : string = method48(v3)
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
                let v73 : (std_io_Error -> string) = method41()
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
                let v88 : (std_path_PathBuf -> US8) = method43()
                let v89 : (string -> US8) = method44()
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
                    let v119 : string = method25(v116, v5)
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
and method45 (v0 : string, v1 : uint8, v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "std::fs::read_link(&*$0)"
    let v5 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v4 
    let v6 : (std_io_Error -> string) = method41()
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
    let v21 : (std_path_PathBuf -> US8) = method43()
    let v22 : (string -> US8) = method44()
    let v23 : US8 = match v18 with Ok x -> v21 x | Error x -> v22 x
    let v43 : Result<std_path_PathBuf, std_io_Error> =
        match v23 with
        | US8_1(v39) -> (* Error *)
            let v40 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure18(v0)
            method46(v0, v40, v1, v39, v2)
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
    let v46 : (std_io_Error -> string) = method41()
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
    let v61 : (std_path_PathBuf -> US8) = method43()
    let v62 : (string -> US8) = method44()
    let v63 : US8 = match v58 with Ok x -> v61 x | Error x -> v62 x
    let v83 : Result<std_path_PathBuf, std_io_Error> =
        match v63 with
        | US8_1(v79) -> (* Error *)
            let v80 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure18(v0)
            method46(v0, v80, v1, v79, v2)
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
    let v86 : (std_io_Error -> string) = method41()
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
    let v101 : (std_path_PathBuf -> US8) = method43()
    let v102 : (string -> US8) = method44()
    let v103 : US8 = match v98 with Ok x -> v101 x | Error x -> v102 x
    let v123 : Result<std_path_PathBuf, std_io_Error> =
        match v103 with
        | US8_1(v119) -> (* Error *)
            let v120 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure18(v0)
            method46(v0, v120, v1, v119, v2)
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
and closure19 (v0 : string, v1 : uint8) (v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    method45(v0, v1, v2)
and closure18 (v0 : string) (v1 : uint8) : (string -> Result<std_path_PathBuf, std_io_Error>) =
    closure19(v0, v1)
and method49 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v4 : string = method47(v0)
    let v5 : string option = method31(v0)
    let v6 : (string -> US5) = method5()
    let v7 : US5 option = v5 |> Option.map v6 
    let v18 : US5 = US5_1
    let v19 : US5 = v7 |> Option.defaultValue v18 
    let v23 : string = method48(v3)
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
                let v72 : (std_io_Error -> string) = method41()
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
                let v87 : (std_path_PathBuf -> US8) = method43()
                let v88 : (string -> US8) = method44()
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
                    let v118 : string = method25(v115, v4)
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
and method40 (v0 : string, v1 : uint8) : Result<std_path_PathBuf, std_io_Error> =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "std::fs::read_link(&*$0)"
    let v4 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let v5 : (std_io_Error -> string) = method41()
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
    let v20 : (std_path_PathBuf -> US8) = method43()
    let v21 : (string -> US8) = method44()
    let v22 : US8 = match v17 with Ok x -> v20 x | Error x -> v21 x
    let v42 : Result<std_path_PathBuf, std_io_Error> =
        match v22 with
        | US8_1(v38) -> (* Error *)
            let v39 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure18(v0)
            method49(v0, v39, v1, v38)
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
    let v45 : (std_io_Error -> string) = method41()
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
    let v60 : (std_path_PathBuf -> US8) = method43()
    let v61 : (string -> US8) = method44()
    let v62 : US8 = match v57 with Ok x -> v60 x | Error x -> v61 x
    let v82 : Result<std_path_PathBuf, std_io_Error> =
        match v62 with
        | US8_1(v78) -> (* Error *)
            let v79 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure18(v0)
            method49(v0, v79, v1, v78)
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
    let v85 : (std_io_Error -> string) = method41()
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
    let v100 : (std_path_PathBuf -> US8) = method43()
    let v101 : (string -> US8) = method44()
    let v102 : US8 = match v97 with Ok x -> v100 x | Error x -> v101 x
    let v122 : Result<std_path_PathBuf, std_io_Error> =
        match v102 with
        | US8_1(v118) -> (* Error *)
            let v119 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure18(v0)
            method49(v0, v119, v1, v118)
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
and method52 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : std_io_Error, v4 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v5 : string = method47(v4)
    let v6 : string option = method31(v4)
    let v7 : (string -> US5) = method5()
    let v8 : US5 option = v6 |> Option.map v7 
    let v19 : US5 = US5_1
    let v20 : US5 = v8 |> Option.defaultValue v19 
    let v24 : string = method42(v3)
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
                let v73 : (std_io_Error -> string) = method41()
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
                let v88 : (std_path_PathBuf -> US8) = method43()
                let v89 : (string -> US8) = method44()
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
                    let v119 : string = method25(v116, v5)
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
and method51 (v0 : string, v1 : uint8, v2 : string) : Result<std_path_PathBuf, std_io_Error> =
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
    let v22 : (string -> System_IO_DirectoryInfo) = System_IO_DirectoryInfo 
    let v23 : System_IO_DirectoryInfo = v22 v2
    let _v3 = v23 
    #endif
    let v24 : System_IO_DirectoryInfo = _v3 
    let v29 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v30 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v29 = v30 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v33 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v29 = v33 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v36 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v29 = v36 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v39 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v29 = v39 
    #endif
#if FABLE_COMPILER_PYTHON
    let v42 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v29 = v42 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v45 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v29 = v45 
    #endif
#else
    let v48 : System.IO.FileAttributes = v24.Attributes
    let _v29 = v48 
    #endif
    let v49 : System.IO.FileAttributes = _v29 
    let v54 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v55 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v54 = v55 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v58 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v54 = v58 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v61 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v54 = v61 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v64 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v54 = v64 
    #endif
#if FABLE_COMPILER_PYTHON
    let v67 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v54 = v67 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v70 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v54 = v70 
    #endif
#else
    let v73 : System.IO.FileAttributes = System.IO.FileAttributes.ReparsePoint
    let _v54 = v73 
    #endif
    let v74 : System.IO.FileAttributes = _v54 
    let v79 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v80 : bool = null |> unbox<bool>
    let _v79 = v80 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v83 : bool = null |> unbox<bool>
    let _v79 = v83 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v86 : bool = null |> unbox<bool>
    let _v79 = v86 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v89 : bool = null |> unbox<bool>
    let _v79 = v89 
    #endif
#if FABLE_COMPILER_PYTHON
    let v92 : bool = null |> unbox<bool>
    let _v79 = v92 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v95 : bool = null |> unbox<bool>
    let _v79 = v95 
    #endif
#else
    let v98 : bool = v49.HasFlag v74 
    let _v79 = v98 
    #endif
    let v99 : bool = _v79 
    if v99 then
        let v104 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v105 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v104 = v105 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v108 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v104 = v108 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v111 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v104 = v111 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v114 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v104 = v114 
        #endif
#if FABLE_COMPILER_PYTHON
        let v117 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v104 = v117 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v120 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v104 = v120 
        #endif
#else
        let v123 : (string -> System_IO_FileInfo) = System_IO_FileInfo 
        let v124 : System_IO_FileInfo = v123 v2
        let _v104 = v124 
        #endif
        let v125 : System_IO_FileInfo = _v104 
        let v130 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v131 : string = null |> unbox<string>
        let _v130 = v131 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v134 : string = null |> unbox<string>
        let _v130 = v134 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v137 : string = null |> unbox<string>
        let _v130 = v137 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v140 : string = null |> unbox<string>
        let _v130 = v140 
        #endif
#if FABLE_COMPILER_PYTHON
        let v143 : string = null |> unbox<string>
        let _v130 = v143 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v146 : string = null |> unbox<string>
        let _v130 = v146 
        #endif
#else
        let v149 : string = v125.LinkTarget
        let _v130 = v149 
        #endif
        let v150 : string = _v130 
        let v155 : std_path_PathBuf = v150 |> unbox<std_path_PathBuf>
        let v158 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v159 : string = "Ok($0)"
        let v160 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v155 v159 
        let _v158 = v160 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v161 : string = "Ok($0)"
        let v162 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v155 v161 
        let _v158 = v162 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v163 : string = "Ok($0)"
        let v164 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v155 v163 
        let _v158 = v164 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v165 : Result<std_path_PathBuf, std_io_Error> = v155 |> Ok
        let _v158 = v165 
        #endif
#if FABLE_COMPILER_PYTHON
        let v166 : Result<std_path_PathBuf, std_io_Error> = v155 |> Ok
        let _v158 = v166 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v167 : Result<std_path_PathBuf, std_io_Error> = v155 |> Ok
        let _v158 = v167 
        #endif
#else
        let v168 : Result<std_path_PathBuf, std_io_Error> = v155 |> Ok
        let _v158 = v168 
        #endif
        let v169 : Result<std_path_PathBuf, std_io_Error> = _v158 
        v169
    else
        let v172 : string = $"file_system.read_link / Fsharp / The file or directory is not a reparse point. / path: {v0} / result: {v99} / path': {v2} / n: {v1}"
        let v173 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v174 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v175 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v172 v174 
        let _v173 = v175 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v176 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v177 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v172 v176 
        let _v173 = v177 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v178 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v179 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v172 v178 
        let _v173 = v179 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v180 : std_io_Error = v172 |> unbox<std_io_Error>
        let _v173 = v180 
        #endif
#if FABLE_COMPILER_PYTHON
        let v183 : std_io_Error = v172 |> unbox<std_io_Error>
        let _v173 = v183 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v186 : std_io_Error = v172 |> unbox<std_io_Error>
        let _v173 = v186 
        #endif
#else
        let v189 : std_io_Error = v172 |> unbox<std_io_Error>
        let _v173 = v189 
        #endif
        let v192 : std_io_Error = _v173 
        let v197 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure20(v0)
        method52(v0, v197, v1, v192, v2)
and closure21 (v0 : string, v1 : uint8) (v2 : string) : Result<std_path_PathBuf, std_io_Error> =
    method51(v0, v1, v2)
and closure20 (v0 : string) (v1 : uint8) : (string -> Result<std_path_PathBuf, std_io_Error>) =
    closure21(v0, v1)
and method53 (v0 : string, v1 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)), v2 : uint8, v3 : std_io_Error) : Result<std_path_PathBuf, std_io_Error> =
    let v4 : string = method47(v0)
    let v5 : string option = method31(v0)
    let v6 : (string -> US5) = method5()
    let v7 : US5 option = v5 |> Option.map v6 
    let v18 : US5 = US5_1
    let v19 : US5 = v7 |> Option.defaultValue v18 
    let v23 : string = method42(v3)
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
                let v72 : (std_io_Error -> string) = method41()
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
                let v87 : (std_path_PathBuf -> US8) = method43()
                let v88 : (string -> US8) = method44()
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
                    let v118 : string = method25(v115, v4)
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
and method50 (v0 : string, v1 : uint8) : Result<std_path_PathBuf, std_io_Error> =
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
    let v21 : (string -> System_IO_DirectoryInfo) = System_IO_DirectoryInfo 
    let v22 : System_IO_DirectoryInfo = v21 v0
    let _v2 = v22 
    #endif
    let v23 : System_IO_DirectoryInfo = _v2 
    let v28 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v29 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v28 = v29 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v28 = v32 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v35 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v28 = v35 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v38 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v28 = v38 
    #endif
#if FABLE_COMPILER_PYTHON
    let v41 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v28 = v41 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v44 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v28 = v44 
    #endif
#else
    let v47 : System.IO.FileAttributes = v23.Attributes
    let _v28 = v47 
    #endif
    let v48 : System.IO.FileAttributes = _v28 
    let v53 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v54 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v53 = v54 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v57 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v53 = v57 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v60 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v53 = v60 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v63 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v53 = v63 
    #endif
#if FABLE_COMPILER_PYTHON
    let v66 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v53 = v66 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v69 : System.IO.FileAttributes = null |> unbox<System.IO.FileAttributes>
    let _v53 = v69 
    #endif
#else
    let v72 : System.IO.FileAttributes = System.IO.FileAttributes.ReparsePoint
    let _v53 = v72 
    #endif
    let v73 : System.IO.FileAttributes = _v53 
    let v78 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v79 : bool = null |> unbox<bool>
    let _v78 = v79 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v82 : bool = null |> unbox<bool>
    let _v78 = v82 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v85 : bool = null |> unbox<bool>
    let _v78 = v85 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v88 : bool = null |> unbox<bool>
    let _v78 = v88 
    #endif
#if FABLE_COMPILER_PYTHON
    let v91 : bool = null |> unbox<bool>
    let _v78 = v91 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v94 : bool = null |> unbox<bool>
    let _v78 = v94 
    #endif
#else
    let v97 : bool = v48.HasFlag v73 
    let _v78 = v97 
    #endif
    let v98 : bool = _v78 
    if v98 then
        let v103 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v104 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v103 = v104 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v107 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v103 = v107 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v110 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v103 = v110 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v113 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v103 = v113 
        #endif
#if FABLE_COMPILER_PYTHON
        let v116 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v103 = v116 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v119 : System_IO_FileInfo = null |> unbox<System_IO_FileInfo>
        let _v103 = v119 
        #endif
#else
        let v122 : (string -> System_IO_FileInfo) = System_IO_FileInfo 
        let v123 : System_IO_FileInfo = v122 v0
        let _v103 = v123 
        #endif
        let v124 : System_IO_FileInfo = _v103 
        let v129 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v130 : string = null |> unbox<string>
        let _v129 = v130 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v133 : string = null |> unbox<string>
        let _v129 = v133 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v136 : string = null |> unbox<string>
        let _v129 = v136 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v139 : string = null |> unbox<string>
        let _v129 = v139 
        #endif
#if FABLE_COMPILER_PYTHON
        let v142 : string = null |> unbox<string>
        let _v129 = v142 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v145 : string = null |> unbox<string>
        let _v129 = v145 
        #endif
#else
        let v148 : string = v124.LinkTarget
        let _v129 = v148 
        #endif
        let v149 : string = _v129 
        let v154 : std_path_PathBuf = v149 |> unbox<std_path_PathBuf>
        let v157 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v158 : string = "Ok($0)"
        let v159 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v154 v158 
        let _v157 = v159 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v160 : string = "Ok($0)"
        let v161 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v154 v160 
        let _v157 = v161 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v162 : string = "Ok($0)"
        let v163 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v154 v162 
        let _v157 = v163 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v164 : Result<std_path_PathBuf, std_io_Error> = v154 |> Ok
        let _v157 = v164 
        #endif
#if FABLE_COMPILER_PYTHON
        let v165 : Result<std_path_PathBuf, std_io_Error> = v154 |> Ok
        let _v157 = v165 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v166 : Result<std_path_PathBuf, std_io_Error> = v154 |> Ok
        let _v157 = v166 
        #endif
#else
        let v167 : Result<std_path_PathBuf, std_io_Error> = v154 |> Ok
        let _v157 = v167 
        #endif
        let v168 : Result<std_path_PathBuf, std_io_Error> = _v157 
        v168
    else
        let v171 : string = $"file_system.read_link / Fsharp / The file or directory is not a reparse point. / path: {v0} / result: {v98} / path': {v0} / n: {v1}"
        let v172 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v173 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v174 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v171 v173 
        let _v172 = v174 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v175 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v176 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v171 v175 
        let _v172 = v176 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v177 : string = "std::io::Error::new(std::io::ErrorKind::Other, &*$0)"
        let v178 : std_io_Error = Fable.Core.RustInterop.emitRustExpr v171 v177 
        let _v172 = v178 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v179 : std_io_Error = v171 |> unbox<std_io_Error>
        let _v172 = v179 
        #endif
#if FABLE_COMPILER_PYTHON
        let v182 : std_io_Error = v171 |> unbox<std_io_Error>
        let _v172 = v182 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v185 : std_io_Error = v171 |> unbox<std_io_Error>
        let _v172 = v185 
        #endif
#else
        let v188 : std_io_Error = v171 |> unbox<std_io_Error>
        let _v172 = v188 
        #endif
        let v191 : std_io_Error = _v172 
        let v196 : (uint8 -> (string -> Result<std_path_PathBuf, std_io_Error>)) = closure20(v0)
        method53(v0, v196, v1, v191)
and method39 (v0 : string) : Result<std_path_PathBuf, std_io_Error> =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : bool = method29(v0)
    let v7 : Result<std_path_PathBuf, std_io_Error> =
        if v2 then
            let v3 : string = "std::fs::read_link(&*$0)"
            let v4 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v3 
            v4
        else
            let v5 : uint8 = 0uy
            method40(v0, v5)
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : bool = method29(v0)
    let v13 : Result<std_path_PathBuf, std_io_Error> =
        if v8 then
            let v9 : string = "std::fs::read_link(&*$0)"
            let v10 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v9 
            v10
        else
            let v11 : uint8 = 0uy
            method40(v0, v11)
    let _v1 = v13 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v14 : bool = method29(v0)
    let v19 : Result<std_path_PathBuf, std_io_Error> =
        if v14 then
            let v15 : string = "std::fs::read_link(&*$0)"
            let v16 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v15 
            v16
        else
            let v17 : uint8 = 0uy
            method40(v0, v17)
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
    let v25 : Result<std_path_PathBuf, std_io_Error> = method50(v0, v24)
    let _v1 = v25 
    #endif
#else
    let v26 : uint8 = 0uy
    let v27 : Result<std_path_PathBuf, std_io_Error> = method50(v0, v26)
    let _v1 = v27 
    #endif
    let v28 : Result<std_path_PathBuf, std_io_Error> = _v1 
    v28
and closure22 () (v0 : std_path_PathBuf) : US9 =
    US9_0(v0)
and method54 () : (std_path_PathBuf -> US9) =
    closure22()
and method56 (v0 : string) : string =
    v0
and method55 (v0 : string, v1 : string, v2 : string) : string =
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
    let v20 : string = method56(v2)
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
and method38 (v0 : string) : string =
    let v1 : bool = v0 = ""
    if v1 then
        let v2 : string = ""
        v2
    else
        let v3 : Result<std_path_PathBuf, std_io_Error> = method39(v0)
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
        let v18 : (std_path_PathBuf -> US9) = method54()
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
            let v71 : string = method55(v69, v70, v66)
            let v72 : string = $"{v71.[0] |> string |> _.ToLower()}{v71.[1..]}"
            let v73 : string = "\\"
            let v74 : string = "/"
            let v75 : string = v72.Replace (v73, v74)
            v75
and method57 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method58 (v0 : int32, v1 : Mut6) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method59 () : char =
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
and method60 (v0 : string) : string =
    v0
and method37 (v0 : string) : string =
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
    let v228 : string =
        if v76 then
            let v77 : string = method36()
            let v78 : string = method25(v77, v0)
            let v79 : string = method38(v78)
            let v80 : string = "/"
            let v81 : (string []) = v79.Split v80 
            let v84 : (string []) = [||]
            let v85 : int32 = v81.Length
            let v86 : Mut5 = {l0 = 0; l1 = 0; l2 = v84} : Mut5
            while method57(v85, v86) do
                let v88 : int32 = v86.l0
                let v89 : int32 =  -v88
                let v90 : int32 = v89 + v85
                let v91 : int32 = v90 - 1
                let struct (v92 : int32, v93 : (string [])) = v86.l1, v86.l2
                let v94 : string = v81.[int v91]
                let v95 : bool = ".." = v94
                let struct (v137 : int32, v138 : (string [])) =
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
                                let v100 : bool = v94.EndsWith v99 
                                if v100 then
                                    let v101 : string = $"{v77.[0]}:"
                                    let v102 : (string []) = [|v101|]
                                    let v103 : int32 = v102.Length
                                    let v104 : int32 = v93.Length
                                    let v105 : int32 = v103 + v104
                                    let v106 : (string []) = Array.zeroCreate<string> (v105)
                                    let v107 : Mut6 = {l0 = 0} : Mut6
                                    while method58(v105, v107) do
                                        let v109 : int32 = v107.l0
                                        let v110 : bool = v109 < v103
                                        let v114 : string =
                                            if v110 then
                                                let v111 : string = v102.[int v109]
                                                v111
                                            else
                                                let v112 : int32 = v109 - v103
                                                let v113 : string = v93.[int v112]
                                                v113
                                        v106.[int v109] <- v114
                                        let v115 : int32 = v109 + 1
                                        v107.l0 <- v115
                                        ()
                                    struct (0, v106)
                                else
                                    let v116 : (string []) = [|v94|]
                                    let v117 : int32 = v116.Length
                                    let v118 : int32 = v93.Length
                                    let v119 : int32 = v117 + v118
                                    let v120 : (string []) = Array.zeroCreate<string> (v119)
                                    let v121 : Mut6 = {l0 = 0} : Mut6
                                    while method58(v119, v121) do
                                        let v123 : int32 = v121.l0
                                        let v124 : bool = v123 < v117
                                        let v128 : string =
                                            if v124 then
                                                let v125 : string = v116.[int v123]
                                                v125
                                            else
                                                let v126 : int32 = v123 - v117
                                                let v127 : string = v93.[int v126]
                                                v127
                                        v120.[int v123] <- v128
                                        let v129 : int32 = v123 + 1
                                        v121.l0 <- v129
                                        ()
                                    struct (0, v120)
                            else
                                let v132 : int32 = v92 - 1
                                struct (v132, v93)
                let v139 : int32 = v88 + 1
                v86.l0 <- v139
                v86.l1 <- v137
                v86.l2 <- v138
                ()
            let struct (v140 : int32, v141 : (string [])) = v86.l1, v86.l2
            let v142 : unit = ()
            let _v142 =
                seq {
                    for i = 0 to v141.Length - 1 do yield v141.[i]
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v143 : string seq = _v142 
            let v149 : char = method59()
            let v150 : (char -> string) = _.ToString()
            let v151 : string = v150 v149
            let v154 : bool = v151 = "\n"
            let v156 : string =
                if v154 then
                    method60(v151)
                else
                    v151
            let v157 : (string -> (string seq -> string)) = String.concat
            let v158 : (string seq -> string) = v157 v156
            v158 v143
        else
            let v162 : string = "std::fs::canonicalize(&*$0)"
            let v163 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v0 v162 
            let v164 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v165 : string = "$0.unwrap()"
            let v166 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v163 v165 
            let _v164 = v166 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v167 : string = "$0.unwrap()"
            let v168 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v163 v167 
            let _v164 = v168 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v169 : string = "$0.unwrap()"
            let v170 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v163 v169 
            let _v164 = v170 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v171 : std_path_PathBuf = match v163 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v164 = v171 
            #endif
#if FABLE_COMPILER_PYTHON
            let v172 : std_path_PathBuf = match v163 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v164 = v172 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v173 : std_path_PathBuf = match v163 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v164 = v173 
            #endif
#else
            let v174 : std_path_PathBuf = match v163 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v164 = v174 
            #endif
            let v175 : std_path_PathBuf = _v164 
            let v178 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v179 : string = "$0.display()"
            let v180 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v175 v179 
            let _v178 = v180 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v181 : string = "$0.display()"
            let v182 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v175 v181 
            let _v178 = v182 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v183 : string = "$0.display()"
            let v184 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v175 v183 
            let _v178 = v184 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v185 : std_path_Display = v175 |> unbox<std_path_Display>
            let _v178 = v185 
            #endif
#if FABLE_COMPILER_PYTHON
            let v188 : std_path_Display = v175 |> unbox<std_path_Display>
            let _v178 = v188 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v191 : std_path_Display = v175 |> unbox<std_path_Display>
            let _v178 = v191 
            #endif
#else
            let v194 : std_path_Display = v175 |> unbox<std_path_Display>
            let _v178 = v194 
            #endif
            let v197 : std_path_Display = _v178 
            let v202 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v203 : string = "format!(\"{}\", $0)"
            let v204 : std_string_String = Fable.Core.RustInterop.emitRustExpr v197 v203 
            let _v202 = v204 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v205 : string = "format!(\"{}\", $0)"
            let v206 : std_string_String = Fable.Core.RustInterop.emitRustExpr v197 v205 
            let _v202 = v206 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v207 : string = "format!(\"{}\", $0)"
            let v208 : std_string_String = Fable.Core.RustInterop.emitRustExpr v197 v207 
            let _v202 = v208 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v209 : std_string_String = null |> unbox<std_string_String>
            let _v202 = v209 
            #endif
#if FABLE_COMPILER_PYTHON
            let v212 : std_string_String = null |> unbox<std_string_String>
            let _v202 = v212 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v215 : std_string_String = null |> unbox<std_string_String>
            let _v202 = v215 
            #endif
#else
            let v218 : std_string_String = null |> unbox<std_string_String>
            let _v202 = v218 
            #endif
            let v221 : std_string_String = _v202 
            let v226 : string = "fable_library_rust::String_::fromString($0)"
            let v227 : string = Fable.Core.RustInterop.emitRustExpr v221 v226 
            v227
    let _v1 = v228 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v229 : string = null |> unbox<string>
    let _v1 = v229 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v232 : string = null |> unbox<string>
    let _v1 = v232 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v235 : string = null |> unbox<string>
    let _v1 = v235 
    #endif
#if FABLE_COMPILER_PYTHON
    let v238 : string = null |> unbox<string>
    let _v1 = v238 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v241 : string = null |> unbox<string>
    let _v1 = v241 
    #endif
#else
    let v244 : (string -> string) = System.IO.Path.GetFullPath
    let v245 : string = v244 v0
    let _v1 = v245 
    #endif
    let v246 : string = _v1 
    v246
and method61 () : string =
    
    
    
    
    
    let v0 : string = "Debug"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method12(v5)
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
    let v105 : string = method14()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[94m"
    let v109 : string = method14()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[94m"
    let v113 : string = method14()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[94m"
    let v117 : string = method14()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method63 (v0 : string, v1 : string, v2 : string, v3 : string) : string =
    let v4 : string = method13()
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
and method62 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : string) : string =
    let v12 : string = method63(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v14 : string = "documents.run"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method17(v15)
and closure23 (v0 : string, v1 : string, v2 : string, v3 : string) () : unit =
    let v4 : US0 = US0_1
    let v5 : bool = method6(v4)
    if v5 then
        let v6 : unit = ()
        let v7 : (unit -> unit) = closure6()
        let v8 : unit = (fun () -> v7 (); v6) ()
        let struct (v22 : Mut0, v23 : Mut1, v24 : Mut2, v25 : Mut3, v26 : Mut4, v27 : int64 option) = TraceState.trace_state.Value
        let v40 : string = method7(v22, v23, v24, v25, v26, v27)
        let v41 : string = method61()
        let v42 : string = method62(v22, v23, v24, v25, v26, v27, v40, v41, v1, v2, v3, v0)
        method18(v42)
and method64 (v0 : async_walkdir_DirEntry) : async_walkdir_DirEntry =
    v0
and closure25 () (v0 : std_io_Error) : std_string_String =
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
    closure25()
and closure26 () (v0 : std_fs_FileType) : US10 =
    US10_0(v0)
and method66 () : (std_fs_FileType -> US10) =
    closure26()
and closure27 () (v0 : std_string_String) : US10 =
    US10_1(v0)
and method67 () : (std_string_String -> US10) =
    closure27()
and method68 (v0 : std_fs_FileType) : std_fs_FileType =
    v0
and method69 (v0 : US11) : US11 =
    v0
and method70 (v0 : async_walkdir_Filtering) : async_walkdir_Filtering =
    v0
and closure24 () (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> =
    let v1 : string = "true; let __future_init = Box::pin(async { //"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = "true; let __future_init = Box::pin(async move { //"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr () v3 
    let v5 : async_walkdir_DirEntry = method64(v0)
    let v6 : string = "Box::pin(async_walkdir::DirEntry::file_type(&v5))"
    let v7 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>, Send<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>>>>> = Fable.Core.RustInterop.emitRustExpr () v6 
    let v8 : string = "v7.await"
    let v9 : Result<std_fs_FileType, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : (std_io_Error -> std_string_String) = method65()
    let v11 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : string = "$0.map_err(|x| $1(x))"
    let v13 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v9, v10) v12 
    let _v11 = v13 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v14 : string = "$0.map_err(|x| $1(x))"
    let v15 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v9, v10) v14 
    let _v11 = v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = "$0.map_err(|x| $1(x))"
    let v17 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v9, v10) v16 
    let _v11 = v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : Result<std_fs_FileType, std_string_String> = match v9 with Ok x -> Ok x | Error x -> Error (v10 x)
    let _v11 = v18 
    #endif
#if FABLE_COMPILER_PYTHON
    let v19 : Result<std_fs_FileType, std_string_String> = match v9 with Ok x -> Ok x | Error x -> Error (v10 x)
    let _v11 = v19 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v20 : Result<std_fs_FileType, std_string_String> = match v9 with Ok x -> Ok x | Error x -> Error (v10 x)
    let _v11 = v20 
    #endif
#else
    let v21 : Result<std_fs_FileType, std_string_String> = match v9 with Ok x -> Ok x | Error x -> Error (v10 x)
    let _v11 = v21 
    #endif
    let v22 : Result<std_fs_FileType, std_string_String> = _v11 
    let v25 : (std_fs_FileType -> US10) = method66()
    let v26 : (std_string_String -> US10) = method67()
    let v27 : US10 = match v22 with Ok x -> v25 x | Error x -> v26 x
    let v156 : US11 =
        match v27 with
        | US10_0(v28) -> (* Ok *)
            let v29 : std_fs_FileType = method68(v28)
            let v30 : string = "std::fs::FileType::is_dir(&v29)"
            let v31 : bool = Fable.Core.RustInterop.emitRustExpr () v30 
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
                let v86 : bool = v84.EndsWith v85 
                let v87 : bool = v86 = false
                let v90 : bool =
                    if v87 then
                        true
                    else
                        let v88 : string = ".hangul.md"
                        let v89 : bool = v84.EndsWith v88 
                        v89
                if v90 then
                    US11_0
                else
                    US11_2
        | _ ->
            let v95 : string = "async_walkdir::DirEntry::path(&$0)"
            let v96 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v0 v95 
            let v97 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v98 : string = "$0.display()"
            let v99 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v96 v98 
            let _v97 = v99 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v100 : string = "$0.display()"
            let v101 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v96 v100 
            let _v97 = v101 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v102 : string = "$0.display()"
            let v103 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v96 v102 
            let _v97 = v103 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v104 : std_path_Display = v96 |> unbox<std_path_Display>
            let _v97 = v104 
            #endif
#if FABLE_COMPILER_PYTHON
            let v107 : std_path_Display = v96 |> unbox<std_path_Display>
            let _v97 = v107 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v110 : std_path_Display = v96 |> unbox<std_path_Display>
            let _v97 = v110 
            #endif
#else
            let v113 : std_path_Display = v96 |> unbox<std_path_Display>
            let _v97 = v113 
            #endif
            let v116 : std_path_Display = _v97 
            let v121 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v122 : string = "format!(\"{}\", $0)"
            let v123 : std_string_String = Fable.Core.RustInterop.emitRustExpr v116 v122 
            let _v121 = v123 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v124 : string = "format!(\"{}\", $0)"
            let v125 : std_string_String = Fable.Core.RustInterop.emitRustExpr v116 v124 
            let _v121 = v125 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v126 : string = "format!(\"{}\", $0)"
            let v127 : std_string_String = Fable.Core.RustInterop.emitRustExpr v116 v126 
            let _v121 = v127 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v128 : std_string_String = null |> unbox<std_string_String>
            let _v121 = v128 
            #endif
#if FABLE_COMPILER_PYTHON
            let v131 : std_string_String = null |> unbox<std_string_String>
            let _v121 = v131 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v134 : std_string_String = null |> unbox<std_string_String>
            let _v121 = v134 
            #endif
#else
            let v137 : std_string_String = null |> unbox<std_string_String>
            let _v121 = v137 
            #endif
            let v140 : std_string_String = _v121 
            let v145 : string = "fable_library_rust::String_::fromString($0)"
            let v146 : string = Fable.Core.RustInterop.emitRustExpr v140 v145 
            let v147 : string = ".md"
            let v148 : bool = v146.EndsWith v147 
            let v149 : bool = v148 = false
            let v152 : bool =
                if v149 then
                    true
                else
                    let v150 : string = ".hangul.md"
                    let v151 : bool = v146.EndsWith v150 
                    v151
            if v152 then
                US11_0
            else
                US11_2
    let v157 : US11 = method69(v156)
    let v158 : string = ""
    let v159 : string = "}"
    let v160 : string = v158 + v159 
    let v161 : _ = v157 
    let v162 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v163 : string = $"true; let v161 = $0"
    let v164 : bool = Fable.Core.RustInterop.emitRustExpr v161 v163 
    let _v162 = v164 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v165 : string = $"true; let v161 = $0"
    let v166 : bool = Fable.Core.RustInterop.emitRustExpr v161 v165 
    let _v162 = v166 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v167 : string = $"true; let v161 = $0"
    let v168 : bool = Fable.Core.RustInterop.emitRustExpr v161 v167 
    let _v162 = v168 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v169 : bool = true
    let _v162 = v169 
    #endif
#if FABLE_COMPILER_PYTHON
    let v170 : bool = true
    let _v162 = v170 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v171 : bool = true
    let _v162 = v171 
    #endif
#else
    let v172 : bool = true
    let _v162 = v172 
    #endif
    let v173 : bool = _v162 
    let v176 : string = $"true; v161 " + v160 + "); " + v158 + " // rust.fix_closure'"
    let v177 : bool = Fable.Core.RustInterop.emitRustExpr () v176 
    let v178 : string = "__future_init"
    let v179 : _ = Fable.Core.RustInterop.emitRustExpr () v178 
    let v180 : string = "v179"
    let v181 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US11>>, Send<Dyn<std_future_Future<US11>>>>>> = Fable.Core.RustInterop.emitRustExpr () v180 
    let v182 : string = "v181.await"
    let v183 : US11 = Fable.Core.RustInterop.emitRustExpr () v182 
    let v192 : async_walkdir_Filtering =
        match v183 with
        | US11_2 -> (* Continue *)
            let v188 : string = "async_walkdir::Filtering::Continue"
            let v189 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v188 
            v189
        | US11_0 -> (* Ignore *)
            let v184 : string = "async_walkdir::Filtering::Ignore"
            let v185 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v184 
            v185
        | US11_1 -> (* IgnoreDir *)
            let v186 : string = "async_walkdir::Filtering::IgnoreDir"
            let v187 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v186 
            v187
    let v193 : async_walkdir_Filtering = method70(v192)
    let v194 : string = v158 + v159 
    let v195 : _ = v193 
    let v196 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v197 : string = $"true; let v195 = $0"
    let v198 : bool = Fable.Core.RustInterop.emitRustExpr v195 v197 
    let _v196 = v198 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v199 : string = $"true; let v195 = $0"
    let v200 : bool = Fable.Core.RustInterop.emitRustExpr v195 v199 
    let _v196 = v200 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v201 : string = $"true; let v195 = $0"
    let v202 : bool = Fable.Core.RustInterop.emitRustExpr v195 v201 
    let _v196 = v202 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v203 : bool = true
    let _v196 = v203 
    #endif
#if FABLE_COMPILER_PYTHON
    let v204 : bool = true
    let _v196 = v204 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v205 : bool = true
    let _v196 = v205 
    #endif
#else
    let v206 : bool = true
    let _v196 = v206 
    #endif
    let v207 : bool = _v196 
    let v210 : string = $"true; v195 " + v194 + "); " + v158 + " // rust.fix_closure'"
    let v211 : bool = Fable.Core.RustInterop.emitRustExpr () v210 
    let v212 : string = "__future_init"
    let v213 : _ = Fable.Core.RustInterop.emitRustExpr () v212 
    let v214 : string = "v213"
    let v215 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> = Fable.Core.RustInterop.emitRustExpr () v214 
    v215
and closure29 () (v0 : async_walkdir_Error) : std_string_String =
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
and method72 () : (async_walkdir_Error -> std_string_String) =
    closure29()
and closure30 () (v0 : async_walkdir_DirEntry) : US12 =
    US12_0(v0)
and method73 () : (async_walkdir_DirEntry -> US12) =
    closure30()
and closure31 () (v0 : std_string_String) : US12 =
    US12_1(v0)
and method74 () : (std_string_String -> US12) =
    closure31()
and method75 () : string =
    
    
    
    
    
    let v0 : string = "Critical"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method12(v5)
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
    let v105 : string = method14()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[91m"
    let v109 : string = method14()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[91m"
    let v113 : string = method14()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[91m"
    let v117 : string = method14()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method77 (v0 : std_string_String) : string =
    let v1 : string = method13()
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
and method76 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method77(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "documents.run / stream_filter_map"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method17(v12)
and closure32 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_4
    let v2 : bool = method6(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method75()
        let v39 : string = method76(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method18(v39)
and closure28 () (v0 : Result<async_walkdir_DirEntry, async_walkdir_Error>) : string option =
    let v1 : (async_walkdir_Error -> std_string_String) = method72()
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
    let v16 : (async_walkdir_DirEntry -> US12) = method73()
    let v17 : (std_string_String -> US12) = method74()
    let v18 : US12 = match v13 with Ok x -> v16 x | Error x -> v17 x
    let v118 : US5 =
        match v18 with
        | US12_1(v73) -> (* Error *)
            let v74 : unit = ()
            let v75 : (unit -> unit) = closure32(v73)
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
and method71 () : (Result<async_walkdir_DirEntry, async_walkdir_Error> -> string option) =
    closure28()
and method79 (v0 : unativeint) : string =
    let v1 : string = method13()
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
and method78 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : unativeint) : string =
    let v9 : string = method79(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "documents.run"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method17(v12)
and closure33 (v0 : Vec<string>) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method6(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method61()
        let v39 : string = "$0.len()"
        let v40 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v39 
        let v41 : string = method78(v19, v20, v21, v22, v23, v24, v37, v38, v40)
        method18(v41)
and method80 () : string =
    let v0 : string = ""
    v0
and method81 (v0 : string) : string =
    let v1 : string = method37(v0)
    method38(v1)
and method83 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : string =
    v0
and method85 () : string =
    let v0 : string = ""
    v0
and closure37 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure36 () (v0 : char) : (UH0 -> UH0) =
    closure37(v0)
and method86 () : (char -> (UH0 -> UH0)) =
    closure36()
and method87 (v0 : UH0, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : struct (System.Text.StringBuilder * int32 * int32) =
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
        method87(v5, v24, v9, v10)
    | UH0_0 -> (* Nil *)
        struct (v1, v2, v3)
and closure35 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US14 =
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
            while method58(v38, v40) do
                let v42 : int32 = v40.l0
                let v43 : char = v35.[int v42]
                v39.[int v42] <- v43
                let v44 : int32 = v42 + 1
                v40.l0 <- v44
                ()
            let v45 : char list = v39 |> Array.toList
            let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v49 : (char -> (UH0 -> UH0)) = method86()
            let v50 : (char list -> (UH0 -> UH0)) = v48 v49
            let v51 : (UH0 -> UH0) = v50 v45
            let v52 : UH0 = UH0_0
            let v53 : UH0 = v51 v52
            let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method87(v53, v1, v2, v3)
            US14_0(v9, v30, v75, v76, v77)
        else
            let v79 : (string -> int32) = String.length
            let v80 : int32 = v79 v0
            let v83 : string = "\n"
            let v84 : int32 = v0.IndexOf v83 
            let v87 : int32 = v84 - 1
            let v88 : bool = -2 = v87
            let v91 : int32 =
                if v88 then
                    let v89 : int32 = v80 + 1
                    v89
                else
                    let v90 : int32 = v87 + 1
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
and closure38 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US14 =
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
            while method58(v38, v40) do
                let v42 : int32 = v40.l0
                let v43 : char = v35.[int v42]
                v39.[int v42] <- v43
                let v44 : int32 = v42 + 1
                v40.l0 <- v44
                ()
            let v45 : char list = v39 |> Array.toList
            let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v49 : (char -> (UH0 -> UH0)) = method86()
            let v50 : (char list -> (UH0 -> UH0)) = v48 v49
            let v51 : (UH0 -> UH0) = v50 v45
            let v52 : UH0 = UH0_0
            let v53 : UH0 = v51 v52
            let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method87(v53, v1, v2, v3)
            US14_0(v9, v30, v75, v76, v77)
        else
            let v79 : (string -> int32) = String.length
            let v80 : int32 = v79 v0
            let v83 : string = "\n"
            let v84 : int32 = v0.IndexOf v83 
            let v87 : int32 = v84 - 1
            let v88 : bool = -2 = v87
            let v91 : int32 =
                if v88 then
                    let v89 : int32 = v80 + 1
                    v89
                else
                    let v90 : int32 = v87 + 1
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
and method88 (v0 : string, v1 : System.Text.StringBuilder, v2 : UH1) : US14 =
    match v2 with
    | UH1_1(v5, v6) -> (* Cons *)
        let v7 : US14 = v5 struct (v0, v1, 1, 1)
        match v7 with
        | US14_1(v13) -> (* Error *)
            method88(v0, v1, v6)
        | US14_0(v8, v9, v10, v11, v12) -> (* Ok *)
            v7
    | UH1_0 -> (* Nil *)
        let v3 : string = "parsing.choice / no parsers succeeded"
        US14_1(v3)
and method89 (v0 : char, v1 : int64) : bool =
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
            method89(v0, v17)
and method90 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
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
            let v23 : bool = method89(v21, v22)
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
                while method58(v52, v54) do
                    let v56 : int32 = v54.l0
                    let v57 : char = v49.[int v56]
                    v53.[int v56] <- v57
                    let v58 : int32 = v56 + 1
                    v54.l0 <- v58
                    ()
                let v59 : char list = v53 |> Array.toList
                let v62 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v63 : (char -> (UH0 -> UH0)) = method86()
                let v64 : (char list -> (UH0 -> UH0)) = v62 v63
                let v65 : (UH0 -> UH0) = v64 v59
                let v66 : UH0 = UH0_0
                let v67 : UH0 = v65 v66
                let struct (v89 : System.Text.StringBuilder, v90 : int32, v91 : int32) = method87(v67, v2, v3, v4)
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
        method90(v131, v123, v124, v125, v126)
and method91 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH1) : US14 =
    match v4 with
    | UH1_1(v7, v8) -> (* Cons *)
        let v9 : US14 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US14_1(v15) -> (* Error *)
            method91(v0, v1, v2, v3, v8)
        | US14_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH1_0 -> (* Nil *)
        let v5 : string = "parsing.choice / no parsers succeeded"
        US14_1(v5)
and method92 (v0 : char, v1 : int64) : bool =
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
            method92(v0, v21)
and method93 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
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
            let v26 : bool = method92(v24, v25)
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
                while method58(v55, v57) do
                    let v59 : int32 = v57.l0
                    let v60 : char = v52.[int v59]
                    v56.[int v59] <- v60
                    let v61 : int32 = v59 + 1
                    v57.l0 <- v61
                    ()
                let v62 : char list = v56 |> Array.toList
                let v65 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v66 : (char -> (UH0 -> UH0)) = method86()
                let v67 : (char list -> (UH0 -> UH0)) = v65 v66
                let v68 : (UH0 -> UH0) = v67 v62
                let v69 : UH0 = UH0_0
                let v70 : UH0 = v68 v69
                let struct (v92 : System.Text.StringBuilder, v93 : int32, v94 : int32) = method87(v70, v2, v3, v4)
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
        method93(v137, v129, v130, v131, v132)
and method94 (v0 : string, v1 : int32) : int32 =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 >= v2
    if v3 then
        v1
    else
        let v4 : char = v0.[int v1]
        let v5 : bool = ' ' = v4
        if v5 then
            let v6 : int32 = v1 + 1
            method94(v0, v6)
        else
            v1
and method95 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
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
            while method58(v38, v40) do
                let v42 : int32 = v40.l0
                let v43 : char = v35.[int v42]
                v39.[int v42] <- v43
                let v44 : int32 = v42 + 1
                v40.l0 <- v44
                ()
            let v45 : char list = v39 |> Array.toList
            let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v49 : (char -> (UH0 -> UH0)) = method86()
            let v50 : (char list -> (UH0 -> UH0)) = v48 v49
            let v51 : (UH0 -> UH0) = v50 v45
            let v52 : UH0 = UH0_0
            let v53 : UH0 = v51 v52
            let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method87(v53, v2, v3, v4)
            US14_0(v10, v30, v75, v76, v77)
    match v79 with
    | US14_1(v95) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US14_0(v80, v81, v82, v83, v84) -> (* Ok *)
        let v85 : (char -> string) = _.ToString()
        let v86 : string = v85 v80
        let v89 : string = v0 + v86 
        method95(v89, v81, v82, v83, v84)
and method84 (v0 : string) : US13 =
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
    let v10 : string = method85()
    let v11 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v12 : System.Text.StringBuilder = v11 v10
    let v15 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US14) = closure35()
    let v16 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US14) = closure38()
    let v17 : UH1 = UH1_0
    let v18 : UH1 = UH1_1(v16, v17)
    let v19 : UH1 = UH1_1(v15, v18)
    let v20 : US14 = method88(v7, v12, v19)
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
                    let v44 : bool = method89(v42, v43)
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
                        while method58(v73, v75) do
                            let v77 : int32 = v75.l0
                            let v78 : char = v70.[int v77]
                            v74.[int v77] <- v78
                            let v79 : int32 = v77 + 1
                            v75.l0 <- v79
                            ()
                        let v80 : char list = v74 |> Array.toList
                        let v83 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v84 : (char -> (UH0 -> UH0)) = method86()
                        let v85 : (char list -> (UH0 -> UH0)) = v83 v84
                        let v86 : (UH0 -> UH0) = v85 v80
                        let v87 : UH0 = UH0_0
                        let v88 : UH0 = v86 v87
                        let struct (v110 : System.Text.StringBuilder, v111 : int32, v112 : int32) = method87(v88, v23, v24, v25)
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
                    let struct (v152 : string, v153 : string, v154 : System.Text.StringBuilder, v155 : int32, v156 : int32) = method90(v149, v144, v145, v146, v147)
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
                let v180 : US14 = method91(v173, v174, v175, v176, v179)
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
                    let v230 : bool = method92(v228, v229)
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
                        while method58(v259, v261) do
                            let v263 : int32 = v261.l0
                            let v264 : char = v256.[int v263]
                            v260.[int v263] <- v264
                            let v265 : int32 = v263 + 1
                            v261.l0 <- v265
                            ()
                        let v266 : char list = v260 |> Array.toList
                        let v269 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v270 : (char -> (UH0 -> UH0)) = method86()
                        let v271 : (char list -> (UH0 -> UH0)) = v269 v270
                        let v272 : (UH0 -> UH0) = v271 v266
                        let v273 : UH0 = UH0_0
                        let v274 : UH0 = v272 v273
                        let v296 : int32 = 1
                        let v297 : int32 = 1
                        let struct (v298 : System.Text.StringBuilder, v299 : int32, v300 : int32) = method87(v274, v12, v296, v297)
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
                    let struct (v343 : string, v344 : string, v345 : System.Text.StringBuilder, v346 : int32, v347 : int32) = method93(v340, v335, v336, v337, v338)
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
                    let v382 : int32 = method94(v377, v381)
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
                        while method58(v454, v456) do
                            let v458 : int32 = v456.l0
                            let v459 : char = v451.[int v458]
                            v455.[int v458] <- v459
                            let v460 : int32 = v458 + 1
                            v456.l0 <- v460
                            ()
                        let v461 : char list = v455 |> Array.toList
                        let v464 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v465 : (char -> (UH0 -> UH0)) = method86()
                        let v466 : (char list -> (UH0 -> UH0)) = v464 v465
                        let v467 : (UH0 -> UH0) = v466 v461
                        let v468 : UH0 = UH0_0
                        let v469 : UH0 = v467 v468
                        let struct (v491 : System.Text.StringBuilder, v492 : int32, v493 : int32) = method87(v469, v417, v418, v419)
                        US14_0(v425, v446, v491, v492, v493)
                    else
                        let v495 : (string -> int32) = String.length
                        let v496 : int32 = v495 v416
                        let v499 : string = "\n"
                        let v500 : int32 = v416.IndexOf v499 
                        let v503 : int32 = v500 - 1
                        let v504 : bool = -2 = v503
                        let v507 : int32 =
                            if v504 then
                                let v505 : int32 = v496 + 1
                                v505
                            else
                                let v506 : int32 = v503 + 1
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
                            while method58(v595, v597) do
                                let v599 : int32 = v597.l0
                                let v600 : char = v592.[int v599]
                                v596.[int v599] <- v600
                                let v601 : int32 = v599 + 1
                                v597.l0 <- v601
                                ()
                            let v602 : char list = v596 |> Array.toList
                            let v605 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                            let v606 : (char -> (UH0 -> UH0)) = method86()
                            let v607 : (char list -> (UH0 -> UH0)) = v605 v606
                            let v608 : (UH0 -> UH0) = v607 v602
                            let v609 : UH0 = UH0_0
                            let v610 : UH0 = v608 v609
                            let struct (v632 : System.Text.StringBuilder, v633 : int32, v634 : int32) = method87(v610, v559, v560, v561)
                            US14_0(v567, v587, v632, v633, v634)
                    match v636 with
                    | US14_1(v652) -> (* Error *)
                        US15_1(v652)
                    | US14_0(v637, v638, v639, v640, v641) -> (* Ok *)
                        let v642 : (char -> string) = _.ToString()
                        let v643 : string = v642 v637
                        let struct (v646 : string, v647 : string, v648 : System.Text.StringBuilder, v649 : int32, v650 : int32) = method95(v643, v638, v639, v640, v641)
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
and method98 (v0 : char, v1 : int64) : bool =
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
            method98(v0, v25)
and method99 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
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
            let v29 : bool = method98(v27, v28)
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
                while method58(v58, v60) do
                    let v62 : int32 = v60.l0
                    let v63 : char = v55.[int v62]
                    v59.[int v62] <- v63
                    let v64 : int32 = v62 + 1
                    v60.l0 <- v64
                    ()
                let v65 : char list = v59 |> Array.toList
                let v68 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v69 : (char -> (UH0 -> UH0)) = method86()
                let v70 : (char list -> (UH0 -> UH0)) = v68 v69
                let v71 : (UH0 -> UH0) = v70 v65
                let v72 : UH0 = UH0_0
                let v73 : UH0 = v71 v72
                let struct (v95 : System.Text.StringBuilder, v96 : int32, v97 : int32) = method87(v73, v2, v3, v4)
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
        method99(v131, v123, v124, v125, v126)
and method101 (v0 : char, v1 : int64) : bool =
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
            method101(v0, v21)
and closure39 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US15 =
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
                while method58(v38, v40) do
                    let v42 : int32 = v40.l0
                    let v43 : char = v35.[int v42]
                    v39.[int v42] <- v43
                    let v44 : int32 = v42 + 1
                    v40.l0 <- v44
                    ()
                let v45 : char list = v39 |> Array.toList
                let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v49 : (char -> (UH0 -> UH0)) = method86()
                let v50 : (char list -> (UH0 -> UH0)) = v48 v49
                let v51 : (UH0 -> UH0) = v50 v45
                let v52 : UH0 = UH0_0
                let v53 : UH0 = v51 v52
                let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method87(v53, v1, v2, v3)
                US14_0(v9, v30, v75, v76, v77)
            else
                let v79 : (string -> int32) = String.length
                let v80 : int32 = v79 v0
                let v83 : string = "\n"
                let v84 : int32 = v0.IndexOf v83 
                let v87 : int32 = v84 - 1
                let v88 : bool = -2 = v87
                let v91 : int32 =
                    if v88 then
                        let v89 : int32 = v80 + 1
                        v89
                    else
                        let v90 : int32 = v87 + 1
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
                while method58(v167, v169) do
                    let v171 : int32 = v169.l0
                    let v172 : char = v164.[int v171]
                    v168.[int v171] <- v172
                    let v173 : int32 = v171 + 1
                    v169.l0 <- v173
                    ()
                let v174 : char list = v168 |> Array.toList
                let v177 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v178 : (char -> (UH0 -> UH0)) = method86()
                let v179 : (char list -> (UH0 -> UH0)) = v177 v178
                let v180 : (UH0 -> UH0) = v179 v174
                let v181 : UH0 = UH0_0
                let v182 : UH0 = v180 v181
                let struct (v204 : System.Text.StringBuilder, v205 : int32, v206 : int32) = method87(v182, v131, v132, v133)
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
and closure40 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US15 =
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
                while method58(v38, v40) do
                    let v42 : int32 = v40.l0
                    let v43 : char = v35.[int v42]
                    v39.[int v42] <- v43
                    let v44 : int32 = v42 + 1
                    v40.l0 <- v44
                    ()
                let v45 : char list = v39 |> Array.toList
                let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v49 : (char -> (UH0 -> UH0)) = method86()
                let v50 : (char list -> (UH0 -> UH0)) = v48 v49
                let v51 : (UH0 -> UH0) = v50 v45
                let v52 : UH0 = UH0_0
                let v53 : UH0 = v51 v52
                let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method87(v53, v1, v2, v3)
                US14_0(v9, v30, v75, v76, v77)
            else
                let v79 : (string -> int32) = String.length
                let v80 : int32 = v79 v0
                let v83 : string = "\n"
                let v84 : int32 = v0.IndexOf v83 
                let v87 : int32 = v84 - 1
                let v88 : bool = -2 = v87
                let v91 : int32 =
                    if v88 then
                        let v89 : int32 = v80 + 1
                        v89
                    else
                        let v90 : int32 = v87 + 1
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
                while method58(v167, v169) do
                    let v171 : int32 = v169.l0
                    let v172 : char = v164.[int v171]
                    v168.[int v171] <- v172
                    let v173 : int32 = v171 + 1
                    v169.l0 <- v173
                    ()
                let v174 : char list = v168 |> Array.toList
                let v177 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v178 : (char -> (UH0 -> UH0)) = method86()
                let v179 : (char list -> (UH0 -> UH0)) = v177 v178
                let v180 : (UH0 -> UH0) = v179 v174
                let v181 : UH0 = UH0_0
                let v182 : UH0 = v180 v181
                let struct (v204 : System.Text.StringBuilder, v205 : int32, v206 : int32) = method87(v182, v131, v132, v133)
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
and method102 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH3) : US15 =
    match v4 with
    | UH3_1(v7, v8) -> (* Cons *)
        let v9 : US15 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US15_1(v15) -> (* Error *)
            method102(v0, v1, v2, v3, v8)
        | US15_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH3_0 -> (* Nil *)
        let v5 : string = "parsing.choice / no parsers succeeded"
        US15_1(v5)
and method103 (v0 : UH2, v1 : UH2) : UH2 =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : UH2 = UH2_1(v2, v1)
        method103(v3, v4)
    | UH2_0 -> (* Nil *)
        v1
and method100 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US22 =
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
            let v26 : bool = method101(v24, v25)
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
                while method58(v55, v57) do
                    let v59 : int32 = v57.l0
                    let v60 : char = v52.[int v59]
                    v56.[int v59] <- v60
                    let v61 : int32 = v59 + 1
                    v57.l0 <- v61
                    ()
                let v62 : char list = v56 |> Array.toList
                let v65 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v66 : (char -> (UH0 -> UH0)) = method86()
                let v67 : (char list -> (UH0 -> UH0)) = v65 v66
                let v68 : (UH0 -> UH0) = v67 v62
                let v69 : UH0 = UH0_0
                let v70 : UH0 = v68 v69
                let struct (v92 : System.Text.StringBuilder, v93 : int32, v94 : int32) = method87(v70, v2, v3, v4)
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
            let v136 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US15) = closure39()
            let v137 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US15) = closure40()
            let v138 : UH3 = UH3_0
            let v139 : UH3 = UH3_1(v137, v138)
            let v140 : UH3 = UH3_1(v136, v139)
            method102(v1, v2, v3, v4, v140)
        | US15_0(v130, v131, v132, v133, v134) -> (* Ok *)
            v129
    match v143 with
    | US15_1(v151) -> (* Error *)
        let v152 : UH2 = UH2_0
        let v153 : UH2 = method103(v0, v152)
        US22_0(v153, v1, v2, v3, v4)
    | US15_0(v144, v145, v146, v147, v148) -> (* Ok *)
        let v149 : UH2 = UH2_1(v144, v0)
        method100(v149, v145, v146, v147, v148)
and method104 (v0 : UH2, v1 : string list) : string list =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : string list = method104(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH2_0 -> (* Nil *)
        v1
and method105 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US22 =
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
            let v26 : bool = method101(v24, v25)
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
                while method58(v55, v57) do
                    let v59 : int32 = v57.l0
                    let v60 : char = v52.[int v59]
                    v56.[int v59] <- v60
                    let v61 : int32 = v59 + 1
                    v57.l0 <- v61
                    ()
                let v62 : char list = v56 |> Array.toList
                let v65 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v66 : (char -> (UH0 -> UH0)) = method86()
                let v67 : (char list -> (UH0 -> UH0)) = v65 v66
                let v68 : (UH0 -> UH0) = v67 v62
                let v69 : UH0 = UH0_0
                let v70 : UH0 = v68 v69
                let struct (v92 : System.Text.StringBuilder, v93 : int32, v94 : int32) = method87(v70, v2, v3, v4)
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
        let v139 : UH2 = method103(v0, v138)
        US22_0(v139, v1, v2, v3, v4)
    | US15_0(v130, v131, v132, v133, v134) -> (* Ok *)
        let v135 : UH2 = UH2_1(v130, v0)
        method105(v135, v131, v132, v133, v134)
and method97 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US22 =
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
            let v29 : bool = method98(v27, v28)
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
                while method58(v58, v60) do
                    let v62 : int32 = v60.l0
                    let v63 : char = v55.[int v62]
                    v59.[int v62] <- v63
                    let v64 : int32 = v62 + 1
                    v60.l0 <- v64
                    ()
                let v65 : char list = v59 |> Array.toList
                let v68 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v69 : (char -> (UH0 -> UH0)) = method86()
                let v70 : (char list -> (UH0 -> UH0)) = v68 v69
                let v71 : (UH0 -> UH0) = v70 v65
                let v72 : UH0 = UH0_0
                let v73 : UH0 = v71 v72
                let struct (v95 : System.Text.StringBuilder, v96 : int32, v97 : int32) = method87(v73, v2, v3, v4)
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
            let struct (v131 : string, v132 : string, v133 : System.Text.StringBuilder, v134 : int32, v135 : int32) = method99(v128, v123, v124, v125, v126)
            US15_0(v131, v132, v133, v134, v135)
    let v517 : US15 =
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
                        while method58(v180, v182) do
                            let v184 : int32 = v182.l0
                            let v185 : char = v177.[int v184]
                            v181.[int v184] <- v185
                            let v186 : int32 = v184 + 1
                            v182.l0 <- v186
                            ()
                        let v187 : char list = v181 |> Array.toList
                        let v190 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v191 : (char -> (UH0 -> UH0)) = method86()
                        let v192 : (char list -> (UH0 -> UH0)) = v190 v191
                        let v193 : (UH0 -> UH0) = v192 v187
                        let v194 : UH0 = UH0_0
                        let v195 : UH0 = v193 v194
                        let struct (v217 : System.Text.StringBuilder, v218 : int32, v219 : int32) = method87(v195, v2, v3, v4)
                        US14_0(v151, v172, v217, v218, v219)
                    else
                        let v221 : (string -> int32) = String.length
                        let v222 : int32 = v221 v1
                        let v225 : string = "\n"
                        let v226 : int32 = v1.IndexOf v225 
                        let v229 : int32 = v226 - 1
                        let v230 : bool = -2 = v229
                        let v233 : int32 =
                            if v230 then
                                let v231 : int32 = v222 + 1
                                v231
                            else
                                let v232 : int32 = v229 + 1
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
            let v454 : US15 =
                match v270 with
                | US14_1(v451) -> (* Error *)
                    US15_1(v451)
                | US14_0(v271, v272, v273, v274, v275) -> (* Ok *)
                    let v276 : UH2 = UH2_0
                    let v277 : US22 = method100(v276, v272, v273, v274, v275)
                    let v302 : US15 =
                        match v277 with
                        | US22_1(v299) -> (* Error *)
                            US15_1(v299)
                        | US22_0(v278, v279, v280, v281, v282) -> (* Ok *)
                            let v283 : string list = []
                            let v284 : string list = method104(v278, v283)
                            let v285 : unit = ()
                            let _v285 =
                                seq {
                                    for i = 0 to v284.Length - 1 do yield v284.[i]
                                    (*
                                    ()
                                *)
                                }
                                (*
                                ()
                            *)
                            let v286 : string seq = _v285 
                            let v292 : (string -> (string seq -> string)) = String.concat
                            let v293 : string = ""
                            let v294 : (string seq -> string) = v292 v293
                            let v295 : string = v294 v286
                            US15_0(v295, v279, v280, v281, v282)
                    match v302 with
                    | US15_1(v446) -> (* Error *)
                        let v447 : string = "parsing.between / expected content"
                        US15_1(v447)
                    | US15_0(v303, v304, v305, v306, v307) -> (* Ok *)
                        let v308 : bool = "" = v304
                        let v432 : US14 =
                            if v308 then
                                let v309 : string = $"parsing.p_char / unexpected end of input / c: '{'"'}' / s: %A{struct (v305, v306, v307)}"
                                US14_1(v309)
                            else
                                let v313 : char = v304.[int 0]
                                let v314 : bool = v313 = '"'
                                if v314 then
                                    let v315 : (string -> int32) = String.length
                                    let v316 : int32 = v315 v304
                                    let v319 : int32 = 1 |> int32 
                                    let v326 : int32 = v316 |> int32 
                                    let v333 : int32 = v326 - 1
                                    let v334 : string = v304.[int v319..int v333]
                                    let v338 : (char -> string) = _.ToString()
                                    let v339 : string = v338 v313
                                    let v342 : int32 = v339.Length
                                    let v343 : (char []) = Array.zeroCreate<char> (v342)
                                    let v344 : Mut6 = {l0 = 0} : Mut6
                                    while method58(v342, v344) do
                                        let v346 : int32 = v344.l0
                                        let v347 : char = v339.[int v346]
                                        v343.[int v346] <- v347
                                        let v348 : int32 = v346 + 1
                                        v344.l0 <- v348
                                        ()
                                    let v349 : char list = v343 |> Array.toList
                                    let v352 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                                    let v353 : (char -> (UH0 -> UH0)) = method86()
                                    let v354 : (char list -> (UH0 -> UH0)) = v352 v353
                                    let v355 : (UH0 -> UH0) = v354 v349
                                    let v356 : UH0 = UH0_0
                                    let v357 : UH0 = v355 v356
                                    let struct (v379 : System.Text.StringBuilder, v380 : int32, v381 : int32) = method87(v357, v305, v306, v307)
                                    US14_0(v313, v334, v379, v380, v381)
                                else
                                    let v383 : (string -> int32) = String.length
                                    let v384 : int32 = v383 v304
                                    let v387 : string = "\n"
                                    let v388 : int32 = v304.IndexOf v387 
                                    let v391 : int32 = v388 - 1
                                    let v392 : bool = -2 = v391
                                    let v395 : int32 =
                                        if v392 then
                                            let v393 : int32 = v384 + 1
                                            v393
                                        else
                                            let v394 : int32 = v391 + 1
                                            v394
                                    let v396 : int32 = 0 |> int32 
                                    let v403 : int32 = v395 |> int32 
                                    let v410 : int32 = v403 - 1
                                    let v411 : string = v304.[int v396..int v410]
                                    let v415 : string = $"parsing.p_char / expected: '{'"'}' / line: {v306} / col: {v307}
{v305}{v411}"
                                    let v418 : int32 = v307 - 1
                                    let v419 : (int32 -> (string -> string)) = String.replicate
                                    let v420 : (string -> string) = v419 v418
                                    let v421 : string = " "
                                    let v422 : string = v420 v421
                                    let v425 : string = "^"
                                    let v426 : string = v422 + v425 
                                    let v427 : string = $"{v415}
{v426}
"
                                    US14_1(v427)
                        match v432 with
                        | US14_1(v439) -> (* Error *)
                            let v440 : string = $"parsing.between / expected closing delimiter / e: %A{v439} / input: %A{struct (v1, v2, v3, v4)} / rest1: %A{struct (v272, v273, v274, v275)} / rest2: %A{struct (v304, v305, v306, v307)}"
                            US15_1(v440)
                        | US14_0(v433, v434, v435, v436, v437) -> (* Ok *)
                            US15_0(v303, v434, v435, v436, v437)
            match v454 with
            | US15_1(v460) -> (* Error *)
                let v461 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US15) = closure39()
                let v462 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US15) = closure40()
                let v463 : UH3 = UH3_0
                let v464 : UH3 = UH3_1(v462, v463)
                let v465 : UH3 = UH3_1(v461, v464)
                let v466 : US15 = method102(v1, v2, v3, v4, v465)
                let v477 : US15 =
                    match v466 with
                    | US15_1(v474) -> (* Error *)
                        US15_1(v474)
                    | US15_0(v467, v468, v469, v470, v471) -> (* Ok *)
                        let v472 : string = ""
                        US15_0(v472, v468, v469, v470, v471)
                let v488 : US22 =
                    match v477 with
                    | US15_1(v485) -> (* Error *)
                        US22_1(v485)
                    | US15_0(v478, v479, v480, v481, v482) -> (* Ok *)
                        let v483 : UH2 = UH2_0
                        method105(v483, v479, v480, v481, v482)
                match v488 with
                | US22_1(v510) -> (* Error *)
                    US15_1(v510)
                | US22_0(v489, v490, v491, v492, v493) -> (* Ok *)
                    let v494 : string list = []
                    let v495 : string list = method104(v489, v494)
                    let v496 : unit = ()
                    let _v496 =
                        seq {
                            for i = 0 to v495.Length - 1 do yield v495.[i]
                            (*
                            ()
                        *)
                        }
                        (*
                        ()
                    *)
                    let v497 : string seq = _v496 
                    let v503 : (string -> (string seq -> string)) = String.concat
                    let v504 : string = ""
                    let v505 : (string seq -> string) = v503 v504
                    let v506 : string = v505 v497
                    US15_0(v506, v490, v491, v492, v493)
            | US15_0(v455, v456, v457, v458, v459) -> (* Ok *)
                v454
        | US15_0(v141, v142, v143, v144, v145) -> (* Ok *)
            v140
    match v517 with
    | US15_1(v566) -> (* Error *)
        let v567 : UH2 = UH2_0
        let v568 : UH2 = method103(v0, v567)
        US22_0(v568, v1, v2, v3, v4)
    | US15_0(v518, v519, v520, v521, v522) -> (* Ok *)
        let v523 : int32 = 0
        let v524 : int32 = method94(v519, v523)
        let v525 : bool = 0 = v524
        let v552 : US17 =
            if v525 then
                let v526 : string = "parsing.spaces1 / expected at least one space"
                US17_1(v526)
            else
                let v528 : (string -> int32) = String.length
                let v529 : int32 = v528 v519
                let v532 : int32 = v524 |> int32 
                let v539 : int32 = v529 |> int32 
                let v546 : int32 = v539 - 1
                let v547 : string = v519.[int v532..int v546]
                US17_0(v547, v520, v521, v522)
        match v552 with
        | US17_1(v559) -> (* Error *)
            let v560 : UH2 = UH2_0
            let v561 : UH2 = UH2_1(v518, v560)
            let v562 : UH2 = method103(v0, v561)
            US22_0(v562, v519, v520, v521, v522)
        | US17_0(v553, v554, v555, v556) -> (* Ok *)
            let v557 : UH2 = UH2_1(v518, v0)
            method97(v557, v553, v554, v555, v556)
and method96 (v0 : string) : US21 =
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
    let v10 : string = method85()
    let v11 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v12 : System.Text.StringBuilder = v11 v10
    let v15 : UH2 = UH2_0
    let v16 : int32 = 1
    let v17 : int32 = 1
    let v18 : US22 = method97(v15, v7, v12, v16, v17)
    match v18 with
    | US22_1(v31) -> (* Error *)
        US21_1(v31)
    | US22_0(v19, v20, v21, v22, v23) -> (* Ok *)
        let v24 : string list = []
        let v25 : string list = method104(v19, v24)
        let v26 : (string list -> (string [])) = List.toArray
        let v27 : (string []) = v26 v25
        US21_0(v27)
and method107 (v0 : string, v1 : string, v2 : string, v3 : System.Threading.CancellationToken option, v4 : (struct (string * string) []), v5 : (struct (int32 * string * bool) -> Async<unit>) option, v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v7 : bool, v8 : string option) : string =
    let v9 : string = method13()
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
and method106 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option) : string =
    let v17 : string = method107(v8, v9, v10, v11, v12, v13, v14, v15, v16)
    let v18 : int64 = v0.l0
    let v19 : string = "runtime.execute_with_options"
    let v20 : string = $"{v6} {v7} #{v18} %s{v19} / {v17}"
    method17(v20)
and closure41 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : string, v8 : Vec<std_string_String>) () : unit =
    let v9 : US0 = US0_1
    let v10 : bool = method6(v9)
    if v10 then
        let v11 : unit = ()
        let v12 : (unit -> unit) = closure6()
        let v13 : unit = (fun () -> v12 (); v11) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method7(v27, v28, v29, v30, v31, v32)
        let v46 : string = method61()
        let v47 : string = $"%A{v8}"
        let v50 : string = method106(v27, v28, v29, v30, v31, v32, v45, v46, v7, v47, v0, v1, v2, v3, v4, v5, v6)
        method18(v50)
and closure42 () (v0 : std_process_Child option) : std_process_Child option =
    v0
and method108 () : (std_process_Child option -> std_process_Child option) =
    closure42()
and closure43 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : US23 =
    US23_0(v0)
and method109 () : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US23) =
    closure43()
and closure44 () (v0 : std_string_String) : US23 =
    US23_1(v0)
and method110 () : (std_string_String -> US23) =
    closure44()
and method111 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method77(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "runtime.execute_with_options / child error"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method17(v12)
and closure45 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_4
    let v2 : bool = method6(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method75()
        let v39 : string = method111(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method18(v39)
and method112 (v0 : std_sync_MutexGuard<std_process_Child option>) : std_sync_MutexGuard<std_process_Child option> =
    v0
and closure46 () (v0 : std_process_ChildStdin option) : std_process_ChildStdin option =
    v0
and method113 () : (std_process_ChildStdin option -> std_process_ChildStdin option) =
    closure46()
and closure47 () (v0 : std_sync_mpsc_Sender<std_string_String>) : std_sync_mpsc_Sender<std_string_String> =
    v0
and method114 () : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) =
    closure47()
and method115 () : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) =
    closure47()
and closure48 () (v0 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> =
    v0
and method116 () : (std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> -> std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) =
    closure48()
and closure49 () (v0 : std_string_String) : US25 =
    US25_0(v0)
and method117 () : (std_string_String -> US25) =
    closure49()
and closure50 () (v0 : std_string_String) : US25 =
    US25_1(v0)
and method118 () : (std_string_String -> US25) =
    closure50()
and method120 (v0 : bool, v1 : std_string_String) : string =
    let v2 : string = method13()
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
and method119 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : bool, v9 : std_string_String) : string =
    let v10 : string = method120(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "runtime.stdio_line"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method17(v13)
and closure51 (v0 : bool, v1 : std_string_String) () : unit =
    let v2 : US0 = US0_4
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method7(v20, v21, v22, v23, v24, v25)
        let v39 : string = method75()
        let v40 : string = method119(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method18(v40)
and method121 () : string =
    
    
    
    
    
    let v0 : string = "Verbose"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method12(v5)
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
    let v105 : string = method14()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[90m"
    let v109 : string = method14()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[90m"
    let v113 : string = method14()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[90m"
    let v117 : string = method14()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method123 () : string =
    let v0 : string = method13()
    let v1 : Mut3 = {l0 = v0} : Mut3
    let v2 : string = v1.l0
    v2
and method122 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method123()
    let v10 : int64 = v0.l0
    let v11 : string = $"{v6} {v7} #{v10} %s{v8} / {v9}"
    method17(v11)
and closure52 (v0 : string) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method6(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method121()
        let v39 : bool = v0 = ""
        let v42 : string =
            if v39 then
                let v40 : string = ""
                v40
            else
                method122(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method18(v42)
and closure53 () (v0 : std_sync_mpsc_SendError<std_string_String>) : std_string_String =
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
and method124 () : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) =
    closure53()
and method125 (v0 : Result<unit, string>) : Result<unit, string> =
    v0
and closure54 () (v0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)) : US26 =
    US26_0(v0)
and method126 () : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US26) =
    closure54()
and method127 (v0 : std_sync_MutexGuard<std_process_ChildStdin option>) : std_sync_MutexGuard<std_process_ChildStdin option> =
    v0
and closure55 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : US27 =
    US27_0(v0)
and method128 () : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US27) =
    closure55()
and method129 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and method130 (v0 : std_thread_JoinHandle<Result<unit, string>>) : std_thread_JoinHandle<Result<unit, string>> =
    v0
and closure56 () (v0 : std_process_Output) : US28 =
    US28_0(v0)
and method131 () : (std_process_Output -> US28) =
    closure56()
and closure57 () (v0 : std_string_String) : US28 =
    US28_1(v0)
and method132 () : (std_string_String -> US28) =
    closure57()
and method133 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method77(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "runtime.execute_with_options / output error"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method17(v12)
and closure58 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_4
    let v2 : bool = method6(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method75()
        let v39 : string = method133(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method18(v39)
and closure59 () (v0 : int32) : US29 =
    US29_0(v0)
and method134 () : (int32 -> US29) =
    closure59()
and method135 () : string =
    let v0 : string = "\n"
    v0
and method137 (v0 : int32, v1 : int32) : string =
    let v2 : string = method13()
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
and method136 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32) : string =
    let v10 : string = method137(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "runtime.execute_with_options / result"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method17(v13)
and closure60 (v0 : int32, v1 : string) () : unit =
    let v2 : US0 = US0_0
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method7(v20, v21, v22, v23, v24, v25)
        let v39 : string = method121()
        let v40 : int32 = v1.Length
        let v41 : string = method136(v20, v21, v22, v23, v24, v25, v38, v39, v0, v40)
        method18(v41)
and method140 (v0 : string, v1 : US5, v2 : string, v3 : System.Threading.CancellationToken option, v4 : (struct (string * string) []), v5 : (struct (int32 * string * bool) -> Async<unit>) option, v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v7 : bool, v8 : string option) : string =
    let v9 : string = method13()
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
    method17(v20)
and closure61 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : US5, v8 : string) () : unit =
    let v9 : US0 = US0_1
    let v10 : bool = method6(v9)
    if v10 then
        let v11 : unit = ()
        let v12 : (unit -> unit) = closure6()
        let v13 : unit = (fun () -> v12 (); v11) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method7(v27, v28, v29, v30, v31, v32)
        let v46 : string = method61()
        let v47 : string = method139(v27, v28, v29, v30, v31, v32, v45, v46, v8, v7, v0, v1, v2, v3, v4, v5, v6)
        method18(v47)
and method141 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : (struct (string * string) []) =
    v2
and closure63 () (v0 : (struct (int32 * string * bool) -> Async<unit>)) : US30 =
    US30_0(v0)
and method142 () : ((struct (int32 * string * bool) -> Async<unit>) -> US30) =
    closure63()
and closure64 (v0 : string) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method6(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method121()
        let v39 : bool = v0 = ""
        let v42 : string =
            if v39 then
                let v40 : string = ""
                v40
            else
                method122(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method18(v42)
and closure62 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>) (v9 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v10 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : Async<unit> = null |> unbox<Async<unit>>
    let _v10 = v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v14 : Async<unit> = null |> unbox<Async<unit>>
    let _v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17 : Async<unit> = null |> unbox<Async<unit>>
    let _v10 = v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : unit = ()
    let _v20 =
        async {
            let v21 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v22 : string = null |> unbox<string>
            let _v21 = v22 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v25 : string = null |> unbox<string>
            let _v21 = v25 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v28 : string = null |> unbox<string>
            let _v21 = v28 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v31 : string = null |> unbox<string>
            let _v21 = v31 
            #endif
#if FABLE_COMPILER_PYTHON
            let v34 : string = null |> unbox<string>
            let _v21 = v34 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v37 : string = null |> unbox<string>
            let _v21 = v37 
            #endif
#else
            let v40 : string = v9.Data
            let _v21 = v40 
            #endif
            let v41 : string = _v21 
            let v46 : string = null |> unbox<string>
            let v49 : bool = v41 = v46
            let v50 : bool = v49 <> true
            if v50 then
                let v51 : ((struct (int32 * string * bool) -> Async<unit>) -> US30) = method142()
                let v52 : US30 option = v3 |> Option.map v51 
                let v63 : US30 = US30_1
                let v64 : US30 = v52 |> Option.defaultValue v63 
                match v64 with
                | US30_1 -> (* None *)
                    ()
                | US30_0(v68) -> (* Some *)
                    let v69 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v70 : int32 = null |> unbox<int32>
                    let _v69 = v70 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v73 : int32 = null |> unbox<int32>
                    let _v69 = v73 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v76 : int32 = null |> unbox<int32>
                    let _v69 = v76 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v79 : int32 = null |> unbox<int32>
                    let _v69 = v79 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v82 : int32 = null |> unbox<int32>
                    let _v69 = v82 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v85 : int32 = null |> unbox<int32>
                    let _v69 = v85 
                    #endif
#else
                    let v88 : int32 = v7.Id
                    let _v69 = v88 
                    #endif
                    let v89 : int32 = _v69 
                    let v94 : Async<unit> = v68 struct (v89, v41, false)
                    do! v94 
                    ()
                let v95 : string = $"> {v41}"
                if v5 then
                    let v96 : unit = ()
                    let v97 : (unit -> unit) = closure64(v95)
                    let v98 : unit = (fun () -> v97 (); v96) ()
                    ()
                else
                    let v141 : unit = ()
                    let v142 : (unit -> unit) = closure11(v95)
                    let v143 : unit = (fun () -> v142 (); v141) ()
                    ()
                let v145 : string = ""
                let v146 : string = $"{v145}{v41}{v145}"
                let v147 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v147 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v147 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v147 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v147 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v147 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v147 = () 
                #endif
#else
                let v148 : (string -> unit) = v8.Push
                v148 v146
                let _v147 = () 
                #endif
                _v147 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v149 : Async<unit> = _v20 
    let _v10 = v149 
    #endif
#if FABLE_COMPILER_PYTHON
    let v150 : unit = ()
    let _v150 =
        async {
            let v151 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v152 : string = null |> unbox<string>
            let _v151 = v152 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v155 : string = null |> unbox<string>
            let _v151 = v155 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v158 : string = null |> unbox<string>
            let _v151 = v158 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v161 : string = null |> unbox<string>
            let _v151 = v161 
            #endif
#if FABLE_COMPILER_PYTHON
            let v164 : string = null |> unbox<string>
            let _v151 = v164 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v167 : string = null |> unbox<string>
            let _v151 = v167 
            #endif
#else
            let v170 : string = v9.Data
            let _v151 = v170 
            #endif
            let v171 : string = _v151 
            let v176 : string = null |> unbox<string>
            let v179 : bool = v171 = v176
            let v180 : bool = v179 <> true
            if v180 then
                let v181 : ((struct (int32 * string * bool) -> Async<unit>) -> US30) = method142()
                let v182 : US30 option = v3 |> Option.map v181 
                let v193 : US30 = US30_1
                let v194 : US30 = v182 |> Option.defaultValue v193 
                match v194 with
                | US30_1 -> (* None *)
                    ()
                | US30_0(v198) -> (* Some *)
                    let v199 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v200 : int32 = null |> unbox<int32>
                    let _v199 = v200 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v203 : int32 = null |> unbox<int32>
                    let _v199 = v203 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v206 : int32 = null |> unbox<int32>
                    let _v199 = v206 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v209 : int32 = null |> unbox<int32>
                    let _v199 = v209 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v212 : int32 = null |> unbox<int32>
                    let _v199 = v212 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v215 : int32 = null |> unbox<int32>
                    let _v199 = v215 
                    #endif
#else
                    let v218 : int32 = v7.Id
                    let _v199 = v218 
                    #endif
                    let v219 : int32 = _v199 
                    let v224 : Async<unit> = v198 struct (v219, v171, false)
                    do! v224 
                    ()
                let v225 : string = $"> {v171}"
                if v5 then
                    let v226 : unit = ()
                    let v227 : (unit -> unit) = closure64(v225)
                    let v228 : unit = (fun () -> v227 (); v226) ()
                    ()
                else
                    let v271 : unit = ()
                    let v272 : (unit -> unit) = closure11(v225)
                    let v273 : unit = (fun () -> v272 (); v271) ()
                    ()
                let v275 : string = ""
                let v276 : string = $"{v275}{v171}{v275}"
                let v277 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v277 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v277 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v277 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v277 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v277 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v277 = () 
                #endif
#else
                let v278 : (string -> unit) = v8.Push
                v278 v276
                let _v277 = () 
                #endif
                _v277 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v279 : Async<unit> = _v150 
    let _v10 = v279 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v280 : unit = ()
    let _v280 =
        async {
            let v281 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v282 : string = null |> unbox<string>
            let _v281 = v282 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v285 : string = null |> unbox<string>
            let _v281 = v285 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v288 : string = null |> unbox<string>
            let _v281 = v288 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v291 : string = null |> unbox<string>
            let _v281 = v291 
            #endif
#if FABLE_COMPILER_PYTHON
            let v294 : string = null |> unbox<string>
            let _v281 = v294 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v297 : string = null |> unbox<string>
            let _v281 = v297 
            #endif
#else
            let v300 : string = v9.Data
            let _v281 = v300 
            #endif
            let v301 : string = _v281 
            let v306 : string = null |> unbox<string>
            let v309 : bool = v301 = v306
            let v310 : bool = v309 <> true
            if v310 then
                let v311 : ((struct (int32 * string * bool) -> Async<unit>) -> US30) = method142()
                let v312 : US30 option = v3 |> Option.map v311 
                let v323 : US30 = US30_1
                let v324 : US30 = v312 |> Option.defaultValue v323 
                match v324 with
                | US30_1 -> (* None *)
                    ()
                | US30_0(v328) -> (* Some *)
                    let v329 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v330 : int32 = null |> unbox<int32>
                    let _v329 = v330 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v333 : int32 = null |> unbox<int32>
                    let _v329 = v333 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v336 : int32 = null |> unbox<int32>
                    let _v329 = v336 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v339 : int32 = null |> unbox<int32>
                    let _v329 = v339 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v342 : int32 = null |> unbox<int32>
                    let _v329 = v342 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v345 : int32 = null |> unbox<int32>
                    let _v329 = v345 
                    #endif
#else
                    let v348 : int32 = v7.Id
                    let _v329 = v348 
                    #endif
                    let v349 : int32 = _v329 
                    let v354 : Async<unit> = v328 struct (v349, v301, false)
                    do! v354 
                    ()
                let v355 : string = $"> {v301}"
                if v5 then
                    let v356 : unit = ()
                    let v357 : (unit -> unit) = closure64(v355)
                    let v358 : unit = (fun () -> v357 (); v356) ()
                    ()
                else
                    let v401 : unit = ()
                    let v402 : (unit -> unit) = closure11(v355)
                    let v403 : unit = (fun () -> v402 (); v401) ()
                    ()
                let v405 : string = ""
                let v406 : string = $"{v405}{v301}{v405}"
                let v407 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v407 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v407 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v407 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v407 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v407 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v407 = () 
                #endif
#else
                let v408 : (string -> unit) = v8.Push
                v408 v406
                let _v407 = () 
                #endif
                _v407 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v409 : Async<unit> = _v280 
    let _v10 = v409 
    #endif
#else
    let v410 : unit = ()
    let _v410 =
        async {
            let v411 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v412 : string = null |> unbox<string>
            let _v411 = v412 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v415 : string = null |> unbox<string>
            let _v411 = v415 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v418 : string = null |> unbox<string>
            let _v411 = v418 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v421 : string = null |> unbox<string>
            let _v411 = v421 
            #endif
#if FABLE_COMPILER_PYTHON
            let v424 : string = null |> unbox<string>
            let _v411 = v424 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v427 : string = null |> unbox<string>
            let _v411 = v427 
            #endif
#else
            let v430 : string = v9.Data
            let _v411 = v430 
            #endif
            let v431 : string = _v411 
            let v436 : string = null |> unbox<string>
            let v439 : bool = v431 = v436
            let v440 : bool = v439 <> true
            if v440 then
                let v441 : ((struct (int32 * string * bool) -> Async<unit>) -> US30) = method142()
                let v442 : US30 option = v3 |> Option.map v441 
                let v453 : US30 = US30_1
                let v454 : US30 = v442 |> Option.defaultValue v453 
                match v454 with
                | US30_1 -> (* None *)
                    ()
                | US30_0(v458) -> (* Some *)
                    let v459 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v460 : int32 = null |> unbox<int32>
                    let _v459 = v460 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v463 : int32 = null |> unbox<int32>
                    let _v459 = v463 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v466 : int32 = null |> unbox<int32>
                    let _v459 = v466 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v469 : int32 = null |> unbox<int32>
                    let _v459 = v469 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v472 : int32 = null |> unbox<int32>
                    let _v459 = v472 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v475 : int32 = null |> unbox<int32>
                    let _v459 = v475 
                    #endif
#else
                    let v478 : int32 = v7.Id
                    let _v459 = v478 
                    #endif
                    let v479 : int32 = _v459 
                    let v484 : Async<unit> = v458 struct (v479, v431, false)
                    do! v484 
                    ()
                let v485 : string = $"> {v431}"
                if v5 then
                    let v486 : unit = ()
                    let v487 : (unit -> unit) = closure64(v485)
                    let v488 : unit = (fun () -> v487 (); v486) ()
                    ()
                else
                    let v531 : unit = ()
                    let v532 : (unit -> unit) = closure11(v485)
                    let v533 : unit = (fun () -> v532 (); v531) ()
                    ()
                let v535 : string = ""
                let v536 : string = $"{v535}{v431}{v535}"
                let v537 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v537 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v537 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v537 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v537 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v537 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v537 = () 
                #endif
#else
                let v538 : (string -> unit) = v8.Push
                v538 v536
                let _v537 = () 
                #endif
                _v537 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v539 : Async<unit> = _v410 
    let _v10 = v539 
    #endif
    let v540 : Async<unit> = _v10 
    let v545 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v545 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v545 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v545 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v546 : (Async<unit> -> unit) = Async.StartImmediate
    v546 v540
    let _v545 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    let v547 : (Async<unit> -> unit) = Async.StartImmediate
    v547 v540
    let _v545 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v548 : (Async<unit> -> unit) = Async.StartImmediate
    v548 v540
    let _v545 = () 
    #endif
#else
    let v549 : (Async<unit> -> unit) = Async.StartImmediate
    v549 v540
    let _v545 = () 
    #endif
    _v545 
    ()
and closure65 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>) (v9 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v10 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : Async<unit> = null |> unbox<Async<unit>>
    let _v10 = v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v14 : Async<unit> = null |> unbox<Async<unit>>
    let _v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17 : Async<unit> = null |> unbox<Async<unit>>
    let _v10 = v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : unit = ()
    let _v20 =
        async {
            let v21 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v22 : string = null |> unbox<string>
            let _v21 = v22 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v25 : string = null |> unbox<string>
            let _v21 = v25 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v28 : string = null |> unbox<string>
            let _v21 = v28 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v31 : string = null |> unbox<string>
            let _v21 = v31 
            #endif
#if FABLE_COMPILER_PYTHON
            let v34 : string = null |> unbox<string>
            let _v21 = v34 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v37 : string = null |> unbox<string>
            let _v21 = v37 
            #endif
#else
            let v40 : string = v9.Data
            let _v21 = v40 
            #endif
            let v41 : string = _v21 
            let v46 : string = null |> unbox<string>
            let v49 : bool = v41 = v46
            let v50 : bool = v49 <> true
            if v50 then
                let v51 : ((struct (int32 * string * bool) -> Async<unit>) -> US30) = method142()
                let v52 : US30 option = v3 |> Option.map v51 
                let v63 : US30 = US30_1
                let v64 : US30 = v52 |> Option.defaultValue v63 
                match v64 with
                | US30_1 -> (* None *)
                    ()
                | US30_0(v68) -> (* Some *)
                    let v69 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v70 : int32 = null |> unbox<int32>
                    let _v69 = v70 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v73 : int32 = null |> unbox<int32>
                    let _v69 = v73 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v76 : int32 = null |> unbox<int32>
                    let _v69 = v76 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v79 : int32 = null |> unbox<int32>
                    let _v69 = v79 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v82 : int32 = null |> unbox<int32>
                    let _v69 = v82 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v85 : int32 = null |> unbox<int32>
                    let _v69 = v85 
                    #endif
#else
                    let v88 : int32 = v7.Id
                    let _v69 = v88 
                    #endif
                    let v89 : int32 = _v69 
                    let v94 : Async<unit> = v68 struct (v89, v41, true)
                    do! v94 
                    ()
                let v95 : string = $"! {v41}"
                if v5 then
                    let v96 : unit = ()
                    let v97 : (unit -> unit) = closure64(v95)
                    let v98 : unit = (fun () -> v97 (); v96) ()
                    ()
                else
                    let v141 : unit = ()
                    let v142 : (unit -> unit) = closure11(v95)
                    let v143 : unit = (fun () -> v142 (); v141) ()
                    ()
                let v145 : string = "\u001b[7;4m"
                let v146 : string = "\u001b[0m"
                let v147 : string = $"{v145}{v41}{v146}"
                let v148 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v148 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v148 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v148 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v148 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v148 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v148 = () 
                #endif
#else
                let v149 : (string -> unit) = v8.Push
                v149 v147
                let _v148 = () 
                #endif
                _v148 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v150 : Async<unit> = _v20 
    let _v10 = v150 
    #endif
#if FABLE_COMPILER_PYTHON
    let v151 : unit = ()
    let _v151 =
        async {
            let v152 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v153 : string = null |> unbox<string>
            let _v152 = v153 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v156 : string = null |> unbox<string>
            let _v152 = v156 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v159 : string = null |> unbox<string>
            let _v152 = v159 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v162 : string = null |> unbox<string>
            let _v152 = v162 
            #endif
#if FABLE_COMPILER_PYTHON
            let v165 : string = null |> unbox<string>
            let _v152 = v165 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v168 : string = null |> unbox<string>
            let _v152 = v168 
            #endif
#else
            let v171 : string = v9.Data
            let _v152 = v171 
            #endif
            let v172 : string = _v152 
            let v177 : string = null |> unbox<string>
            let v180 : bool = v172 = v177
            let v181 : bool = v180 <> true
            if v181 then
                let v182 : ((struct (int32 * string * bool) -> Async<unit>) -> US30) = method142()
                let v183 : US30 option = v3 |> Option.map v182 
                let v194 : US30 = US30_1
                let v195 : US30 = v183 |> Option.defaultValue v194 
                match v195 with
                | US30_1 -> (* None *)
                    ()
                | US30_0(v199) -> (* Some *)
                    let v200 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v201 : int32 = null |> unbox<int32>
                    let _v200 = v201 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v204 : int32 = null |> unbox<int32>
                    let _v200 = v204 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v207 : int32 = null |> unbox<int32>
                    let _v200 = v207 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v210 : int32 = null |> unbox<int32>
                    let _v200 = v210 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v213 : int32 = null |> unbox<int32>
                    let _v200 = v213 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v216 : int32 = null |> unbox<int32>
                    let _v200 = v216 
                    #endif
#else
                    let v219 : int32 = v7.Id
                    let _v200 = v219 
                    #endif
                    let v220 : int32 = _v200 
                    let v225 : Async<unit> = v199 struct (v220, v172, true)
                    do! v225 
                    ()
                let v226 : string = $"! {v172}"
                if v5 then
                    let v227 : unit = ()
                    let v228 : (unit -> unit) = closure64(v226)
                    let v229 : unit = (fun () -> v228 (); v227) ()
                    ()
                else
                    let v272 : unit = ()
                    let v273 : (unit -> unit) = closure11(v226)
                    let v274 : unit = (fun () -> v273 (); v272) ()
                    ()
                let v276 : string = "\u001b[7;4m"
                let v277 : string = "\u001b[0m"
                let v278 : string = $"{v276}{v172}{v277}"
                let v279 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v279 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v279 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v279 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v279 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v279 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v279 = () 
                #endif
#else
                let v280 : (string -> unit) = v8.Push
                v280 v278
                let _v279 = () 
                #endif
                _v279 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v281 : Async<unit> = _v151 
    let _v10 = v281 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v282 : unit = ()
    let _v282 =
        async {
            let v283 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v284 : string = null |> unbox<string>
            let _v283 = v284 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v287 : string = null |> unbox<string>
            let _v283 = v287 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v290 : string = null |> unbox<string>
            let _v283 = v290 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v293 : string = null |> unbox<string>
            let _v283 = v293 
            #endif
#if FABLE_COMPILER_PYTHON
            let v296 : string = null |> unbox<string>
            let _v283 = v296 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v299 : string = null |> unbox<string>
            let _v283 = v299 
            #endif
#else
            let v302 : string = v9.Data
            let _v283 = v302 
            #endif
            let v303 : string = _v283 
            let v308 : string = null |> unbox<string>
            let v311 : bool = v303 = v308
            let v312 : bool = v311 <> true
            if v312 then
                let v313 : ((struct (int32 * string * bool) -> Async<unit>) -> US30) = method142()
                let v314 : US30 option = v3 |> Option.map v313 
                let v325 : US30 = US30_1
                let v326 : US30 = v314 |> Option.defaultValue v325 
                match v326 with
                | US30_1 -> (* None *)
                    ()
                | US30_0(v330) -> (* Some *)
                    let v331 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v332 : int32 = null |> unbox<int32>
                    let _v331 = v332 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v335 : int32 = null |> unbox<int32>
                    let _v331 = v335 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v338 : int32 = null |> unbox<int32>
                    let _v331 = v338 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v341 : int32 = null |> unbox<int32>
                    let _v331 = v341 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v344 : int32 = null |> unbox<int32>
                    let _v331 = v344 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v347 : int32 = null |> unbox<int32>
                    let _v331 = v347 
                    #endif
#else
                    let v350 : int32 = v7.Id
                    let _v331 = v350 
                    #endif
                    let v351 : int32 = _v331 
                    let v356 : Async<unit> = v330 struct (v351, v303, true)
                    do! v356 
                    ()
                let v357 : string = $"! {v303}"
                if v5 then
                    let v358 : unit = ()
                    let v359 : (unit -> unit) = closure64(v357)
                    let v360 : unit = (fun () -> v359 (); v358) ()
                    ()
                else
                    let v403 : unit = ()
                    let v404 : (unit -> unit) = closure11(v357)
                    let v405 : unit = (fun () -> v404 (); v403) ()
                    ()
                let v407 : string = "\u001b[7;4m"
                let v408 : string = "\u001b[0m"
                let v409 : string = $"{v407}{v303}{v408}"
                let v410 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v410 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v410 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v410 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v410 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v410 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v410 = () 
                #endif
#else
                let v411 : (string -> unit) = v8.Push
                v411 v409
                let _v410 = () 
                #endif
                _v410 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v412 : Async<unit> = _v282 
    let _v10 = v412 
    #endif
#else
    let v413 : unit = ()
    let _v413 =
        async {
            let v414 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v415 : string = null |> unbox<string>
            let _v414 = v415 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v418 : string = null |> unbox<string>
            let _v414 = v418 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v421 : string = null |> unbox<string>
            let _v414 = v421 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v424 : string = null |> unbox<string>
            let _v414 = v424 
            #endif
#if FABLE_COMPILER_PYTHON
            let v427 : string = null |> unbox<string>
            let _v414 = v427 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v430 : string = null |> unbox<string>
            let _v414 = v430 
            #endif
#else
            let v433 : string = v9.Data
            let _v414 = v433 
            #endif
            let v434 : string = _v414 
            let v439 : string = null |> unbox<string>
            let v442 : bool = v434 = v439
            let v443 : bool = v442 <> true
            if v443 then
                let v444 : ((struct (int32 * string * bool) -> Async<unit>) -> US30) = method142()
                let v445 : US30 option = v3 |> Option.map v444 
                let v456 : US30 = US30_1
                let v457 : US30 = v445 |> Option.defaultValue v456 
                match v457 with
                | US30_1 -> (* None *)
                    ()
                | US30_0(v461) -> (* Some *)
                    let v462 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v463 : int32 = null |> unbox<int32>
                    let _v462 = v463 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v466 : int32 = null |> unbox<int32>
                    let _v462 = v466 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v469 : int32 = null |> unbox<int32>
                    let _v462 = v469 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v472 : int32 = null |> unbox<int32>
                    let _v462 = v472 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v475 : int32 = null |> unbox<int32>
                    let _v462 = v475 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v478 : int32 = null |> unbox<int32>
                    let _v462 = v478 
                    #endif
#else
                    let v481 : int32 = v7.Id
                    let _v462 = v481 
                    #endif
                    let v482 : int32 = _v462 
                    let v487 : Async<unit> = v461 struct (v482, v434, true)
                    do! v487 
                    ()
                let v488 : string = $"! {v434}"
                if v5 then
                    let v489 : unit = ()
                    let v490 : (unit -> unit) = closure64(v488)
                    let v491 : unit = (fun () -> v490 (); v489) ()
                    ()
                else
                    let v534 : unit = ()
                    let v535 : (unit -> unit) = closure11(v488)
                    let v536 : unit = (fun () -> v535 (); v534) ()
                    ()
                let v538 : string = "\u001b[7;4m"
                let v539 : string = "\u001b[0m"
                let v540 : string = $"{v538}{v434}{v539}"
                let v541 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v541 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v541 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v541 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v541 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v541 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v541 = () 
                #endif
#else
                let v542 : (string -> unit) = v8.Push
                v542 v540
                let _v541 = () 
                #endif
                _v541 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v543 : Async<unit> = _v413 
    let _v10 = v543 
    #endif
    let v544 : Async<unit> = _v10 
    let v549 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v549 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v549 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v549 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v550 : (Async<unit> -> unit) = Async.StartImmediate
    v550 v544
    let _v549 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    let v551 : (Async<unit> -> unit) = Async.StartImmediate
    v551 v544
    let _v549 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v552 : (Async<unit> -> unit) = Async.StartImmediate
    v552 v544
    let _v549 = () 
    #endif
#else
    let v553 : (Async<unit> -> unit) = Async.StartImmediate
    v553 v544
    let _v549 = () 
    #endif
    _v549 
    ()
and closure66 () (v0 : System.Threading.CancellationToken) : US31 =
    US31_0(v0)
and method143 () : (System.Threading.CancellationToken -> US31) =
    closure66()
and closure67 (v0 : System.Diagnostics.Process) () : unit =
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
    let v20 : bool = v0.HasExited
    let _v1 = v20 
    #endif
    let v21 : bool = _v1 
    let v26 : bool = v21 = false
    if v26 then
        let v27 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let _v27 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let _v27 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let _v27 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let _v27 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        let _v27 = () 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let _v27 = () 
        #endif
#else
        let v28 : (unit -> unit) = v0.Kill
        v28 ()
        let _v27 = () 
        #endif
        _v27 
        ()
and method145 (v0 : System.Threading.Tasks.TaskCanceledException) : string =
    let v1 : string = method13()
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
and method144 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : System.Threading.Tasks.TaskCanceledException) : string =
    let v9 : string = method145(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "runtime.execute_with_options_async / WaitForExitAsync"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method17(v12)
and closure68 (v0 : System.Threading.Tasks.TaskCanceledException) () : unit =
    let v1 : US0 = US0_3
    let v2 : bool = method6(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method33()
        let v39 : string = method144(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method18(v39)
and method147 (v0 : int32, v1 : int32) : string =
    let v2 : string = method13()
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
and method146 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32) : string =
    let v10 : string = method147(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "runtime.execute_with_options_async"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method17(v13)
and closure69 (v0 : int32, v1 : string) () : unit =
    let v2 : US0 = US0_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method7(v20, v21, v22, v23, v24, v25)
        let v39 : string = method61()
        let v40 : int32 = v1.Length
        let v41 : string = method146(v20, v21, v22, v23, v24, v25, v38, v39, v0, v40)
        method18(v41)
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
    let v17 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v7 = v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v7 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v7 = v23 
    #endif
#else
    let v26 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v26 = v27 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v26 = v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v26 = v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v36 : unit = ()
    let _v36 =
        async {
            let v37 : US13 = method84(v0)
            let struct (v48 : string, v49 : US5) =
                match v37 with
                | US13_1(v40) -> (* Error *)
                    let v41 : string = $"resultm.get / Result value was Error: {v40}"
                    failwith<struct (string * US5)> v41
                | US13_0(v38, v39) -> (* Ok *)
                    struct (v38, v39)
            let v50 : (string -> US5) = method5()
            let v51 : US5 option = v6 |> Option.map v50 
            let v62 : US5 = US5_1
            let v63 : US5 = v51 |> Option.defaultValue v62 
            let v70 : string =
                match v63 with
                | US5_1 -> (* None *)
                    let v68 : string = ""
                    v68
                | US5_0(v67) -> (* Some *)
                    v67
            let v71 : unit = ()
            let v72 : (unit -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v49, v48)
            let v73 : unit = (fun () -> v72 (); v71) ()
            let v113 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v117 : string =
                match v49 with
                | US5_1 -> (* None *)
                    let v115 : string = ""
                    v115
                | US5_0(v114) -> (* Some *)
                    v114
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v117,
              StandardOutputEncoding = v113,
              WorkingDirectory = v70,
              FileName = v48,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v118 : System.Diagnostics.ProcessStartInfo = start_info
            let v119 : (struct (string * string) []) = method141(v0, v1, v2, v3, v4, v5, v6)
            let v120 : int32 = v119.Length
            let v121 : Mut6 = {l0 = 0} : Mut6
            while method58(v120, v121) do
                let v123 : int32 = v121.l0
                let struct (v124 : string, v125 : string) = v119.[int v123]
                v118.EnvironmentVariables.[v124] <- v125 
                let v126 : int32 = v123 + 1
                v121.l0 <- v126
                ()
            let v127 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v118)
            use v127 = v127 
            let v128 : System.Diagnostics.Process = v127 
            let v129 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v130 : System.Collections.Concurrent.ConcurrentStack<string> = v129 ()
            let v131 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v128, v130)
            v128.OutputDataReceived.Add v131 
            let v132 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure65(v0, v1, v2, v3, v4, v5, v6, v128, v130)
            v128.ErrorDataReceived.Add v132 
            let v133 : (unit -> bool) = v128.Start
            let v134 : bool = v133 ()
            let v135 : bool = v134 = false
            if v135 then
                let v136 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v136
            let v137 : (unit -> unit) = v128.BeginErrorReadLine
            v137 ()
            let v138 : (unit -> unit) = v128.BeginOutputReadLine
            v138 ()
            let v139 : (System.Threading.CancellationToken -> US31) = method143()
            let v140 : US31 option = v1 |> Option.map v139 
            let v151 : US31 = US31_1
            let v152 : US31 = v140 |> Option.defaultValue v151 
            let v159 : System.Threading.CancellationToken =
                match v152 with
                | US31_1 -> (* None *)
                    let v157 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v157
                | US31_0(v156) -> (* Some *)
                    v156
            let v160 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v161 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v160 = v161 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v164 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v160 = v164 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v167 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v160 = v167 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v170 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v160 = v170 
            #endif
#if FABLE_COMPILER_PYTHON
            let v173 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v160 = v173 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v176 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v160 = v176 
            #endif
#else
            let v179 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v180 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v179 = v180 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v183 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v179 = v183 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v186 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v179 = v186 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v189 : unit = ()
            let _v189 =
                async {
                    let v190 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v190 = v190 
                    let v191 : System.Threading.CancellationToken = v190 
                    let v192 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v193 : (System.Threading.CancellationToken []) = [|v191; v192; v159|]
                    let v194 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v195 : System.Threading.CancellationTokenSource = v194 v193
                    let v196 : System.Threading.CancellationToken = v195.Token
                    return v196 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v197 : Async<System.Threading.CancellationToken> = _v189 
            let _v179 = v197 
            #endif
#if FABLE_COMPILER_PYTHON
            let v198 : unit = ()
            let _v198 =
                async {
                    let v199 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v199 = v199 
                    let v200 : System.Threading.CancellationToken = v199 
                    let v201 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v202 : (System.Threading.CancellationToken []) = [|v200; v201; v159|]
                    let v203 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v204 : System.Threading.CancellationTokenSource = v203 v202
                    let v205 : System.Threading.CancellationToken = v204.Token
                    return v205 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v206 : Async<System.Threading.CancellationToken> = _v198 
            let _v179 = v206 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v207 : unit = ()
            let _v207 =
                async {
                    let v208 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v208 = v208 
                    let v209 : System.Threading.CancellationToken = v208 
                    let v210 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v211 : (System.Threading.CancellationToken []) = [|v209; v210; v159|]
                    let v212 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v213 : System.Threading.CancellationTokenSource = v212 v211
                    let v214 : System.Threading.CancellationToken = v213.Token
                    return v214 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v215 : Async<System.Threading.CancellationToken> = _v207 
            let _v179 = v215 
            #endif
#else
            let v216 : unit = ()
            let _v216 =
                async {
                    let v217 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v217 = v217 
                    let v218 : System.Threading.CancellationToken = v217 
                    let v219 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v220 : (System.Threading.CancellationToken []) = [|v218; v219; v159|]
                    let v221 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v222 : System.Threading.CancellationTokenSource = v221 v220
                    let v223 : System.Threading.CancellationToken = v222.Token
                    return v223 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v224 : Async<System.Threading.CancellationToken> = _v216 
            let _v179 = v224 
            #endif
            let v225 : Async<System.Threading.CancellationToken> = _v179 
            let _v160 = v225 
            #endif
            let v230 : Async<System.Threading.CancellationToken> = _v160 
            let! v230 = v230 
            let v235 : System.Threading.CancellationToken = v230 
            let v236 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v235.Register
            let v237 : (unit -> unit) = closure67(v128)
            let v238 : System.Threading.CancellationTokenRegistration = v236 v237
            use v238 = v238 
            let v239 : System.Threading.CancellationTokenRegistration = v238 
            let v240 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v241 : Async<int32> = null |> unbox<Async<int32>>
            let _v240 = v241 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v244 : Async<int32> = null |> unbox<Async<int32>>
            let _v240 = v244 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v247 : Async<int32> = null |> unbox<Async<int32>>
            let _v240 = v247 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v250 : unit = ()
            let _v250 =
                async {
                    try
                    let v251 : System.Threading.Tasks.Task = v128.WaitForExitAsync v235 
                    let v252 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v253 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v254 : Async<unit> = v253 v251
                    let _v252 = v254 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v255 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v256 : Async<unit> = v255 v251
                    let _v252 = v256 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v257 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v258 : Async<unit> = v257 v251
                    let _v252 = v258 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v259 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v260 : Async<unit> = v259 v251
                    let _v252 = v260 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v261 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v262 : Async<unit> = v261 v251
                    let _v252 = v262 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v263 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v264 : Async<unit> = v263 v251
                    let _v252 = v264 
                    #endif
#else
                    let v265 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v266 : Async<unit> = v265 v251
                    let _v252 = v266 
                    #endif
                    let v267 : Async<unit> = _v252 
                    do! v267 
                    let v272 : int32 = v128.ExitCode
                    return v272 
                    with ex ->
                        let v273 : exn = ex
                        let v274 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v275 : string = $"%A{v273}"
                        let _v274 = v275 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v278 : string = $"%A{v273}"
                        let _v274 = v278 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v281 : string = $"%A{v273}"
                        let _v274 = v281 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v284 : string = $"%A{v273}"
                        let _v274 = v284 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v287 : string = $"%A{v273}"
                        let _v274 = v287 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v290 : string = $"%A{v273}"
                        let _v274 = v290 
                        #endif
#else
                        let v293 : string = $"{v273.GetType ()}: {v273.Message}"
                        let _v274 = v293 
                        #endif
                        let v294 : string = _v274 
                        let v299 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v299 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v299 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v299 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v299 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v299 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v299 = () 
                        #endif
#else
                        let v300 : (string -> unit) = v130.Push
                        v300 v294
                        let _v299 = () 
                        #endif
                        _v299 
                        let v301 : System.Threading.Tasks.TaskCanceledException = v273 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v304 : unit = ()
                        let v305 : (unit -> unit) = closure68(v301)
                        let v306 : unit = (fun () -> v305 (); v304) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v346 : Async<int32> = _v250 
            let _v240 = v346 
            #endif
#if FABLE_COMPILER_PYTHON
            let v347 : unit = ()
            let _v347 =
                async {
                    try
                    let v348 : System.Threading.Tasks.Task = v128.WaitForExitAsync v235 
                    let v349 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v350 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v351 : Async<unit> = v350 v348
                    let _v349 = v351 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v352 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v353 : Async<unit> = v352 v348
                    let _v349 = v353 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v354 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v355 : Async<unit> = v354 v348
                    let _v349 = v355 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v356 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v357 : Async<unit> = v356 v348
                    let _v349 = v357 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v358 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v359 : Async<unit> = v358 v348
                    let _v349 = v359 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v360 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v361 : Async<unit> = v360 v348
                    let _v349 = v361 
                    #endif
#else
                    let v362 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v363 : Async<unit> = v362 v348
                    let _v349 = v363 
                    #endif
                    let v364 : Async<unit> = _v349 
                    do! v364 
                    let v369 : int32 = v128.ExitCode
                    return v369 
                    with ex ->
                        let v370 : exn = ex
                        let v371 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v372 : string = $"%A{v370}"
                        let _v371 = v372 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v375 : string = $"%A{v370}"
                        let _v371 = v375 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v378 : string = $"%A{v370}"
                        let _v371 = v378 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v381 : string = $"%A{v370}"
                        let _v371 = v381 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v384 : string = $"%A{v370}"
                        let _v371 = v384 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v387 : string = $"%A{v370}"
                        let _v371 = v387 
                        #endif
#else
                        let v390 : string = $"{v370.GetType ()}: {v370.Message}"
                        let _v371 = v390 
                        #endif
                        let v391 : string = _v371 
                        let v396 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v396 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v396 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v396 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v396 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v396 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v396 = () 
                        #endif
#else
                        let v397 : (string -> unit) = v130.Push
                        v397 v391
                        let _v396 = () 
                        #endif
                        _v396 
                        let v398 : System.Threading.Tasks.TaskCanceledException = v370 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v401 : unit = ()
                        let v402 : (unit -> unit) = closure68(v398)
                        let v403 : unit = (fun () -> v402 (); v401) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v443 : Async<int32> = _v347 
            let _v240 = v443 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v444 : unit = ()
            let _v444 =
                async {
                    try
                    let v445 : System.Threading.Tasks.Task = v128.WaitForExitAsync v235 
                    let v446 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v447 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v448 : Async<unit> = v447 v445
                    let _v446 = v448 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v449 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v450 : Async<unit> = v449 v445
                    let _v446 = v450 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v451 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v452 : Async<unit> = v451 v445
                    let _v446 = v452 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v453 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v454 : Async<unit> = v453 v445
                    let _v446 = v454 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v455 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v456 : Async<unit> = v455 v445
                    let _v446 = v456 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v457 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v458 : Async<unit> = v457 v445
                    let _v446 = v458 
                    #endif
#else
                    let v459 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v460 : Async<unit> = v459 v445
                    let _v446 = v460 
                    #endif
                    let v461 : Async<unit> = _v446 
                    do! v461 
                    let v466 : int32 = v128.ExitCode
                    return v466 
                    with ex ->
                        let v467 : exn = ex
                        let v468 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v469 : string = $"%A{v467}"
                        let _v468 = v469 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v472 : string = $"%A{v467}"
                        let _v468 = v472 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v475 : string = $"%A{v467}"
                        let _v468 = v475 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v478 : string = $"%A{v467}"
                        let _v468 = v478 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v481 : string = $"%A{v467}"
                        let _v468 = v481 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v484 : string = $"%A{v467}"
                        let _v468 = v484 
                        #endif
#else
                        let v487 : string = $"{v467.GetType ()}: {v467.Message}"
                        let _v468 = v487 
                        #endif
                        let v488 : string = _v468 
                        let v493 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v493 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v493 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v493 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v493 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v493 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v493 = () 
                        #endif
#else
                        let v494 : (string -> unit) = v130.Push
                        v494 v488
                        let _v493 = () 
                        #endif
                        _v493 
                        let v495 : System.Threading.Tasks.TaskCanceledException = v467 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v498 : unit = ()
                        let v499 : (unit -> unit) = closure68(v495)
                        let v500 : unit = (fun () -> v499 (); v498) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v540 : Async<int32> = _v444 
            let _v240 = v540 
            #endif
#else
            let v541 : unit = ()
            let _v541 =
                async {
                    try
                    let v542 : System.Threading.Tasks.Task = v128.WaitForExitAsync v235 
                    let v543 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v544 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v545 : Async<unit> = v544 v542
                    let _v543 = v545 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v546 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v547 : Async<unit> = v546 v542
                    let _v543 = v547 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v548 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v549 : Async<unit> = v548 v542
                    let _v543 = v549 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v550 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v551 : Async<unit> = v550 v542
                    let _v543 = v551 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v552 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v553 : Async<unit> = v552 v542
                    let _v543 = v553 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v554 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v555 : Async<unit> = v554 v542
                    let _v543 = v555 
                    #endif
#else
                    let v556 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v557 : Async<unit> = v556 v542
                    let _v543 = v557 
                    #endif
                    let v558 : Async<unit> = _v543 
                    do! v558 
                    let v563 : int32 = v128.ExitCode
                    return v563 
                    with ex ->
                        let v564 : exn = ex
                        let v565 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v566 : string = $"%A{v564}"
                        let _v565 = v566 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v569 : string = $"%A{v564}"
                        let _v565 = v569 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v572 : string = $"%A{v564}"
                        let _v565 = v572 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v575 : string = $"%A{v564}"
                        let _v565 = v575 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v578 : string = $"%A{v564}"
                        let _v565 = v578 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v581 : string = $"%A{v564}"
                        let _v565 = v581 
                        #endif
#else
                        let v584 : string = $"{v564.GetType ()}: {v564.Message}"
                        let _v565 = v584 
                        #endif
                        let v585 : string = _v565 
                        let v590 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v590 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v590 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v590 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v590 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v590 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v590 = () 
                        #endif
#else
                        let v591 : (string -> unit) = v130.Push
                        v591 v585
                        let _v590 = () 
                        #endif
                        _v590 
                        let v592 : System.Threading.Tasks.TaskCanceledException = v564 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v595 : unit = ()
                        let v596 : (unit -> unit) = closure68(v592)
                        let v597 : unit = (fun () -> v596 (); v595) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v637 : Async<int32> = _v541 
            let _v240 = v637 
            #endif
            let v638 : Async<int32> = _v240 
            let! v638 = v638 
            let v643 : int32 = v638 
            let v644 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v645 : string seq = v644 v130
            let v648 : (string seq -> string seq) = Seq.rev
            let v649 : string seq = v648 v645
            let v652 : string = method135()
            let v653 : (string -> (string seq -> string)) = String.concat
            let v654 : (string seq -> string) = v653 v652
            let v655 : string = v654 v649
            let v659 : unit = ()
            let v660 : (unit -> unit) = closure69(v643, v655)
            let v661 : unit = (fun () -> v660 (); v659) ()
            return struct (v643, v655) 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v702 : Async<struct (int32 * string)> = _v36 
    let _v26 = v702 
    #endif
#if FABLE_COMPILER_PYTHON
    let v703 : unit = ()
    let _v703 =
        async {
            let v704 : US13 = method84(v0)
            let struct (v715 : string, v716 : US5) =
                match v704 with
                | US13_1(v707) -> (* Error *)
                    let v708 : string = $"resultm.get / Result value was Error: {v707}"
                    failwith<struct (string * US5)> v708
                | US13_0(v705, v706) -> (* Ok *)
                    struct (v705, v706)
            let v717 : (string -> US5) = method5()
            let v718 : US5 option = v6 |> Option.map v717 
            let v729 : US5 = US5_1
            let v730 : US5 = v718 |> Option.defaultValue v729 
            let v737 : string =
                match v730 with
                | US5_1 -> (* None *)
                    let v735 : string = ""
                    v735
                | US5_0(v734) -> (* Some *)
                    v734
            let v738 : unit = ()
            let v739 : (unit -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v716, v715)
            let v740 : unit = (fun () -> v739 (); v738) ()
            let v780 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v784 : string =
                match v716 with
                | US5_1 -> (* None *)
                    let v782 : string = ""
                    v782
                | US5_0(v781) -> (* Some *)
                    v781
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v784,
              StandardOutputEncoding = v780,
              WorkingDirectory = v737,
              FileName = v715,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v785 : System.Diagnostics.ProcessStartInfo = start_info
            let v786 : (struct (string * string) []) = method141(v0, v1, v2, v3, v4, v5, v6)
            let v787 : int32 = v786.Length
            let v788 : Mut6 = {l0 = 0} : Mut6
            while method58(v787, v788) do
                let v790 : int32 = v788.l0
                let struct (v791 : string, v792 : string) = v786.[int v790]
                v785.EnvironmentVariables.[v791] <- v792 
                let v793 : int32 = v790 + 1
                v788.l0 <- v793
                ()
            let v794 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v785)
            use v794 = v794 
            let v795 : System.Diagnostics.Process = v794 
            let v796 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v797 : System.Collections.Concurrent.ConcurrentStack<string> = v796 ()
            let v798 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v795, v797)
            v795.OutputDataReceived.Add v798 
            let v799 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure65(v0, v1, v2, v3, v4, v5, v6, v795, v797)
            v795.ErrorDataReceived.Add v799 
            let v800 : (unit -> bool) = v795.Start
            let v801 : bool = v800 ()
            let v802 : bool = v801 = false
            if v802 then
                let v803 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v803
            let v804 : (unit -> unit) = v795.BeginErrorReadLine
            v804 ()
            let v805 : (unit -> unit) = v795.BeginOutputReadLine
            v805 ()
            let v806 : (System.Threading.CancellationToken -> US31) = method143()
            let v807 : US31 option = v1 |> Option.map v806 
            let v818 : US31 = US31_1
            let v819 : US31 = v807 |> Option.defaultValue v818 
            let v826 : System.Threading.CancellationToken =
                match v819 with
                | US31_1 -> (* None *)
                    let v824 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v824
                | US31_0(v823) -> (* Some *)
                    v823
            let v827 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v828 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v827 = v828 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v831 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v827 = v831 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v834 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v827 = v834 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v837 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v827 = v837 
            #endif
#if FABLE_COMPILER_PYTHON
            let v840 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v827 = v840 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v843 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v827 = v843 
            #endif
#else
            let v846 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v847 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v846 = v847 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v850 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v846 = v850 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v853 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v846 = v853 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v856 : unit = ()
            let _v856 =
                async {
                    let v857 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v857 = v857 
                    let v858 : System.Threading.CancellationToken = v857 
                    let v859 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v860 : (System.Threading.CancellationToken []) = [|v858; v859; v826|]
                    let v861 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v862 : System.Threading.CancellationTokenSource = v861 v860
                    let v863 : System.Threading.CancellationToken = v862.Token
                    return v863 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v864 : Async<System.Threading.CancellationToken> = _v856 
            let _v846 = v864 
            #endif
#if FABLE_COMPILER_PYTHON
            let v865 : unit = ()
            let _v865 =
                async {
                    let v866 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v866 = v866 
                    let v867 : System.Threading.CancellationToken = v866 
                    let v868 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v869 : (System.Threading.CancellationToken []) = [|v867; v868; v826|]
                    let v870 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v871 : System.Threading.CancellationTokenSource = v870 v869
                    let v872 : System.Threading.CancellationToken = v871.Token
                    return v872 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v873 : Async<System.Threading.CancellationToken> = _v865 
            let _v846 = v873 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v874 : unit = ()
            let _v874 =
                async {
                    let v875 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v875 = v875 
                    let v876 : System.Threading.CancellationToken = v875 
                    let v877 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v878 : (System.Threading.CancellationToken []) = [|v876; v877; v826|]
                    let v879 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v880 : System.Threading.CancellationTokenSource = v879 v878
                    let v881 : System.Threading.CancellationToken = v880.Token
                    return v881 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v882 : Async<System.Threading.CancellationToken> = _v874 
            let _v846 = v882 
            #endif
#else
            let v883 : unit = ()
            let _v883 =
                async {
                    let v884 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v884 = v884 
                    let v885 : System.Threading.CancellationToken = v884 
                    let v886 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v887 : (System.Threading.CancellationToken []) = [|v885; v886; v826|]
                    let v888 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v889 : System.Threading.CancellationTokenSource = v888 v887
                    let v890 : System.Threading.CancellationToken = v889.Token
                    return v890 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v891 : Async<System.Threading.CancellationToken> = _v883 
            let _v846 = v891 
            #endif
            let v892 : Async<System.Threading.CancellationToken> = _v846 
            let _v827 = v892 
            #endif
            let v897 : Async<System.Threading.CancellationToken> = _v827 
            let! v897 = v897 
            let v902 : System.Threading.CancellationToken = v897 
            let v903 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v902.Register
            let v904 : (unit -> unit) = closure67(v795)
            let v905 : System.Threading.CancellationTokenRegistration = v903 v904
            use v905 = v905 
            let v906 : System.Threading.CancellationTokenRegistration = v905 
            let v907 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v908 : Async<int32> = null |> unbox<Async<int32>>
            let _v907 = v908 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v911 : Async<int32> = null |> unbox<Async<int32>>
            let _v907 = v911 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v914 : Async<int32> = null |> unbox<Async<int32>>
            let _v907 = v914 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v917 : unit = ()
            let _v917 =
                async {
                    try
                    let v918 : System.Threading.Tasks.Task = v795.WaitForExitAsync v902 
                    let v919 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v920 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v921 : Async<unit> = v920 v918
                    let _v919 = v921 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v922 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v923 : Async<unit> = v922 v918
                    let _v919 = v923 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v924 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v925 : Async<unit> = v924 v918
                    let _v919 = v925 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v926 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v927 : Async<unit> = v926 v918
                    let _v919 = v927 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v928 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v929 : Async<unit> = v928 v918
                    let _v919 = v929 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v930 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v931 : Async<unit> = v930 v918
                    let _v919 = v931 
                    #endif
#else
                    let v932 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v933 : Async<unit> = v932 v918
                    let _v919 = v933 
                    #endif
                    let v934 : Async<unit> = _v919 
                    do! v934 
                    let v939 : int32 = v795.ExitCode
                    return v939 
                    with ex ->
                        let v940 : exn = ex
                        let v941 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v942 : string = $"%A{v940}"
                        let _v941 = v942 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v945 : string = $"%A{v940}"
                        let _v941 = v945 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v948 : string = $"%A{v940}"
                        let _v941 = v948 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v951 : string = $"%A{v940}"
                        let _v941 = v951 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v954 : string = $"%A{v940}"
                        let _v941 = v954 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v957 : string = $"%A{v940}"
                        let _v941 = v957 
                        #endif
#else
                        let v960 : string = $"{v940.GetType ()}: {v940.Message}"
                        let _v941 = v960 
                        #endif
                        let v961 : string = _v941 
                        let v966 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v966 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v966 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v966 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v966 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v966 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v966 = () 
                        #endif
#else
                        let v967 : (string -> unit) = v797.Push
                        v967 v961
                        let _v966 = () 
                        #endif
                        _v966 
                        let v968 : System.Threading.Tasks.TaskCanceledException = v940 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v971 : unit = ()
                        let v972 : (unit -> unit) = closure68(v968)
                        let v973 : unit = (fun () -> v972 (); v971) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1013 : Async<int32> = _v917 
            let _v907 = v1013 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1014 : unit = ()
            let _v1014 =
                async {
                    try
                    let v1015 : System.Threading.Tasks.Task = v795.WaitForExitAsync v902 
                    let v1016 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1017 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1018 : Async<unit> = v1017 v1015
                    let _v1016 = v1018 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1019 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1020 : Async<unit> = v1019 v1015
                    let _v1016 = v1020 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1021 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1022 : Async<unit> = v1021 v1015
                    let _v1016 = v1022 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1023 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1024 : Async<unit> = v1023 v1015
                    let _v1016 = v1024 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1025 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1026 : Async<unit> = v1025 v1015
                    let _v1016 = v1026 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1027 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1028 : Async<unit> = v1027 v1015
                    let _v1016 = v1028 
                    #endif
#else
                    let v1029 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1030 : Async<unit> = v1029 v1015
                    let _v1016 = v1030 
                    #endif
                    let v1031 : Async<unit> = _v1016 
                    do! v1031 
                    let v1036 : int32 = v795.ExitCode
                    return v1036 
                    with ex ->
                        let v1037 : exn = ex
                        let v1038 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1039 : string = $"%A{v1037}"
                        let _v1038 = v1039 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v1042 : string = $"%A{v1037}"
                        let _v1038 = v1042 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1045 : string = $"%A{v1037}"
                        let _v1038 = v1045 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v1048 : string = $"%A{v1037}"
                        let _v1038 = v1048 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v1051 : string = $"%A{v1037}"
                        let _v1038 = v1051 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v1054 : string = $"%A{v1037}"
                        let _v1038 = v1054 
                        #endif
#else
                        let v1057 : string = $"{v1037.GetType ()}: {v1037.Message}"
                        let _v1038 = v1057 
                        #endif
                        let v1058 : string = _v1038 
                        let v1063 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v1063 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v1063 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v1063 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v1063 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v1063 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v1063 = () 
                        #endif
#else
                        let v1064 : (string -> unit) = v797.Push
                        v1064 v1058
                        let _v1063 = () 
                        #endif
                        _v1063 
                        let v1065 : System.Threading.Tasks.TaskCanceledException = v1037 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v1068 : unit = ()
                        let v1069 : (unit -> unit) = closure68(v1065)
                        let v1070 : unit = (fun () -> v1069 (); v1068) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1110 : Async<int32> = _v1014 
            let _v907 = v1110 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1111 : unit = ()
            let _v1111 =
                async {
                    try
                    let v1112 : System.Threading.Tasks.Task = v795.WaitForExitAsync v902 
                    let v1113 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1114 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1115 : Async<unit> = v1114 v1112
                    let _v1113 = v1115 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1116 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1117 : Async<unit> = v1116 v1112
                    let _v1113 = v1117 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1118 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1119 : Async<unit> = v1118 v1112
                    let _v1113 = v1119 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1120 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1121 : Async<unit> = v1120 v1112
                    let _v1113 = v1121 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1122 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1123 : Async<unit> = v1122 v1112
                    let _v1113 = v1123 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1124 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1125 : Async<unit> = v1124 v1112
                    let _v1113 = v1125 
                    #endif
#else
                    let v1126 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1127 : Async<unit> = v1126 v1112
                    let _v1113 = v1127 
                    #endif
                    let v1128 : Async<unit> = _v1113 
                    do! v1128 
                    let v1133 : int32 = v795.ExitCode
                    return v1133 
                    with ex ->
                        let v1134 : exn = ex
                        let v1135 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1136 : string = $"%A{v1134}"
                        let _v1135 = v1136 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v1139 : string = $"%A{v1134}"
                        let _v1135 = v1139 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1142 : string = $"%A{v1134}"
                        let _v1135 = v1142 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v1145 : string = $"%A{v1134}"
                        let _v1135 = v1145 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v1148 : string = $"%A{v1134}"
                        let _v1135 = v1148 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v1151 : string = $"%A{v1134}"
                        let _v1135 = v1151 
                        #endif
#else
                        let v1154 : string = $"{v1134.GetType ()}: {v1134.Message}"
                        let _v1135 = v1154 
                        #endif
                        let v1155 : string = _v1135 
                        let v1160 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v1160 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v1160 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v1160 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v1160 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v1160 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v1160 = () 
                        #endif
#else
                        let v1161 : (string -> unit) = v797.Push
                        v1161 v1155
                        let _v1160 = () 
                        #endif
                        _v1160 
                        let v1162 : System.Threading.Tasks.TaskCanceledException = v1134 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v1165 : unit = ()
                        let v1166 : (unit -> unit) = closure68(v1162)
                        let v1167 : unit = (fun () -> v1166 (); v1165) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1207 : Async<int32> = _v1111 
            let _v907 = v1207 
            #endif
#else
            let v1208 : unit = ()
            let _v1208 =
                async {
                    try
                    let v1209 : System.Threading.Tasks.Task = v795.WaitForExitAsync v902 
                    let v1210 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1211 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1212 : Async<unit> = v1211 v1209
                    let _v1210 = v1212 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1213 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1214 : Async<unit> = v1213 v1209
                    let _v1210 = v1214 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1215 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1216 : Async<unit> = v1215 v1209
                    let _v1210 = v1216 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1217 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1218 : Async<unit> = v1217 v1209
                    let _v1210 = v1218 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1219 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1220 : Async<unit> = v1219 v1209
                    let _v1210 = v1220 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1221 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1222 : Async<unit> = v1221 v1209
                    let _v1210 = v1222 
                    #endif
#else
                    let v1223 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1224 : Async<unit> = v1223 v1209
                    let _v1210 = v1224 
                    #endif
                    let v1225 : Async<unit> = _v1210 
                    do! v1225 
                    let v1230 : int32 = v795.ExitCode
                    return v1230 
                    with ex ->
                        let v1231 : exn = ex
                        let v1232 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1233 : string = $"%A{v1231}"
                        let _v1232 = v1233 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v1236 : string = $"%A{v1231}"
                        let _v1232 = v1236 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1239 : string = $"%A{v1231}"
                        let _v1232 = v1239 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v1242 : string = $"%A{v1231}"
                        let _v1232 = v1242 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v1245 : string = $"%A{v1231}"
                        let _v1232 = v1245 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v1248 : string = $"%A{v1231}"
                        let _v1232 = v1248 
                        #endif
#else
                        let v1251 : string = $"{v1231.GetType ()}: {v1231.Message}"
                        let _v1232 = v1251 
                        #endif
                        let v1252 : string = _v1232 
                        let v1257 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v1257 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v1257 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v1257 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v1257 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v1257 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v1257 = () 
                        #endif
#else
                        let v1258 : (string -> unit) = v797.Push
                        v1258 v1252
                        let _v1257 = () 
                        #endif
                        _v1257 
                        let v1259 : System.Threading.Tasks.TaskCanceledException = v1231 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v1262 : unit = ()
                        let v1263 : (unit -> unit) = closure68(v1259)
                        let v1264 : unit = (fun () -> v1263 (); v1262) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1304 : Async<int32> = _v1208 
            let _v907 = v1304 
            #endif
            let v1305 : Async<int32> = _v907 
            let! v1305 = v1305 
            let v1310 : int32 = v1305 
            let v1311 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v1312 : string seq = v1311 v797
            let v1315 : (string seq -> string seq) = Seq.rev
            let v1316 : string seq = v1315 v1312
            let v1319 : string = method135()
            let v1320 : (string -> (string seq -> string)) = String.concat
            let v1321 : (string seq -> string) = v1320 v1319
            let v1322 : string = v1321 v1316
            let v1326 : unit = ()
            let v1327 : (unit -> unit) = closure69(v1310, v1322)
            let v1328 : unit = (fun () -> v1327 (); v1326) ()
            return struct (v1310, v1322) 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1369 : Async<struct (int32 * string)> = _v703 
    let _v26 = v1369 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1370 : unit = ()
    let _v1370 =
        async {
            let v1371 : US13 = method84(v0)
            let struct (v1382 : string, v1383 : US5) =
                match v1371 with
                | US13_1(v1374) -> (* Error *)
                    let v1375 : string = $"resultm.get / Result value was Error: {v1374}"
                    failwith<struct (string * US5)> v1375
                | US13_0(v1372, v1373) -> (* Ok *)
                    struct (v1372, v1373)
            let v1384 : (string -> US5) = method5()
            let v1385 : US5 option = v6 |> Option.map v1384 
            let v1396 : US5 = US5_1
            let v1397 : US5 = v1385 |> Option.defaultValue v1396 
            let v1404 : string =
                match v1397 with
                | US5_1 -> (* None *)
                    let v1402 : string = ""
                    v1402
                | US5_0(v1401) -> (* Some *)
                    v1401
            let v1405 : unit = ()
            let v1406 : (unit -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v1383, v1382)
            let v1407 : unit = (fun () -> v1406 (); v1405) ()
            let v1447 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v1451 : string =
                match v1383 with
                | US5_1 -> (* None *)
                    let v1449 : string = ""
                    v1449
                | US5_0(v1448) -> (* Some *)
                    v1448
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v1451,
              StandardOutputEncoding = v1447,
              WorkingDirectory = v1404,
              FileName = v1382,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v1452 : System.Diagnostics.ProcessStartInfo = start_info
            let v1453 : (struct (string * string) []) = method141(v0, v1, v2, v3, v4, v5, v6)
            let v1454 : int32 = v1453.Length
            let v1455 : Mut6 = {l0 = 0} : Mut6
            while method58(v1454, v1455) do
                let v1457 : int32 = v1455.l0
                let struct (v1458 : string, v1459 : string) = v1453.[int v1457]
                v1452.EnvironmentVariables.[v1458] <- v1459 
                let v1460 : int32 = v1457 + 1
                v1455.l0 <- v1460
                ()
            let v1461 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1452)
            use v1461 = v1461 
            let v1462 : System.Diagnostics.Process = v1461 
            let v1463 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v1464 : System.Collections.Concurrent.ConcurrentStack<string> = v1463 ()
            let v1465 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v1462, v1464)
            v1462.OutputDataReceived.Add v1465 
            let v1466 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure65(v0, v1, v2, v3, v4, v5, v6, v1462, v1464)
            v1462.ErrorDataReceived.Add v1466 
            let v1467 : (unit -> bool) = v1462.Start
            let v1468 : bool = v1467 ()
            let v1469 : bool = v1468 = false
            if v1469 then
                let v1470 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v1470
            let v1471 : (unit -> unit) = v1462.BeginErrorReadLine
            v1471 ()
            let v1472 : (unit -> unit) = v1462.BeginOutputReadLine
            v1472 ()
            let v1473 : (System.Threading.CancellationToken -> US31) = method143()
            let v1474 : US31 option = v1 |> Option.map v1473 
            let v1485 : US31 = US31_1
            let v1486 : US31 = v1474 |> Option.defaultValue v1485 
            let v1493 : System.Threading.CancellationToken =
                match v1486 with
                | US31_1 -> (* None *)
                    let v1491 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v1491
                | US31_0(v1490) -> (* Some *)
                    v1490
            let v1494 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1495 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v1494 = v1495 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1498 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v1494 = v1498 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1501 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v1494 = v1501 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1504 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v1494 = v1504 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1507 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v1494 = v1507 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1510 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v1494 = v1510 
            #endif
#else
            let v1513 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1514 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v1513 = v1514 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1517 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v1513 = v1517 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1520 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v1513 = v1520 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1523 : unit = ()
            let _v1523 =
                async {
                    let v1524 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v1524 = v1524 
                    let v1525 : System.Threading.CancellationToken = v1524 
                    let v1526 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v1527 : (System.Threading.CancellationToken []) = [|v1525; v1526; v1493|]
                    let v1528 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v1529 : System.Threading.CancellationTokenSource = v1528 v1527
                    let v1530 : System.Threading.CancellationToken = v1529.Token
                    return v1530 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1531 : Async<System.Threading.CancellationToken> = _v1523 
            let _v1513 = v1531 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1532 : unit = ()
            let _v1532 =
                async {
                    let v1533 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v1533 = v1533 
                    let v1534 : System.Threading.CancellationToken = v1533 
                    let v1535 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v1536 : (System.Threading.CancellationToken []) = [|v1534; v1535; v1493|]
                    let v1537 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v1538 : System.Threading.CancellationTokenSource = v1537 v1536
                    let v1539 : System.Threading.CancellationToken = v1538.Token
                    return v1539 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1540 : Async<System.Threading.CancellationToken> = _v1532 
            let _v1513 = v1540 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1541 : unit = ()
            let _v1541 =
                async {
                    let v1542 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v1542 = v1542 
                    let v1543 : System.Threading.CancellationToken = v1542 
                    let v1544 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v1545 : (System.Threading.CancellationToken []) = [|v1543; v1544; v1493|]
                    let v1546 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v1547 : System.Threading.CancellationTokenSource = v1546 v1545
                    let v1548 : System.Threading.CancellationToken = v1547.Token
                    return v1548 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1549 : Async<System.Threading.CancellationToken> = _v1541 
            let _v1513 = v1549 
            #endif
#else
            let v1550 : unit = ()
            let _v1550 =
                async {
                    let v1551 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v1551 = v1551 
                    let v1552 : System.Threading.CancellationToken = v1551 
                    let v1553 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v1554 : (System.Threading.CancellationToken []) = [|v1552; v1553; v1493|]
                    let v1555 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v1556 : System.Threading.CancellationTokenSource = v1555 v1554
                    let v1557 : System.Threading.CancellationToken = v1556.Token
                    return v1557 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1558 : Async<System.Threading.CancellationToken> = _v1550 
            let _v1513 = v1558 
            #endif
            let v1559 : Async<System.Threading.CancellationToken> = _v1513 
            let _v1494 = v1559 
            #endif
            let v1564 : Async<System.Threading.CancellationToken> = _v1494 
            let! v1564 = v1564 
            let v1569 : System.Threading.CancellationToken = v1564 
            let v1570 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1569.Register
            let v1571 : (unit -> unit) = closure67(v1462)
            let v1572 : System.Threading.CancellationTokenRegistration = v1570 v1571
            use v1572 = v1572 
            let v1573 : System.Threading.CancellationTokenRegistration = v1572 
            let v1574 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1575 : Async<int32> = null |> unbox<Async<int32>>
            let _v1574 = v1575 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1578 : Async<int32> = null |> unbox<Async<int32>>
            let _v1574 = v1578 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1581 : Async<int32> = null |> unbox<Async<int32>>
            let _v1574 = v1581 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1584 : unit = ()
            let _v1584 =
                async {
                    try
                    let v1585 : System.Threading.Tasks.Task = v1462.WaitForExitAsync v1569 
                    let v1586 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1587 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1588 : Async<unit> = v1587 v1585
                    let _v1586 = v1588 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1589 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1590 : Async<unit> = v1589 v1585
                    let _v1586 = v1590 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1591 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1592 : Async<unit> = v1591 v1585
                    let _v1586 = v1592 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1593 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1594 : Async<unit> = v1593 v1585
                    let _v1586 = v1594 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1595 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1596 : Async<unit> = v1595 v1585
                    let _v1586 = v1596 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1597 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1598 : Async<unit> = v1597 v1585
                    let _v1586 = v1598 
                    #endif
#else
                    let v1599 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1600 : Async<unit> = v1599 v1585
                    let _v1586 = v1600 
                    #endif
                    let v1601 : Async<unit> = _v1586 
                    do! v1601 
                    let v1606 : int32 = v1462.ExitCode
                    return v1606 
                    with ex ->
                        let v1607 : exn = ex
                        let v1608 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1609 : string = $"%A{v1607}"
                        let _v1608 = v1609 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v1612 : string = $"%A{v1607}"
                        let _v1608 = v1612 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1615 : string = $"%A{v1607}"
                        let _v1608 = v1615 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v1618 : string = $"%A{v1607}"
                        let _v1608 = v1618 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v1621 : string = $"%A{v1607}"
                        let _v1608 = v1621 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v1624 : string = $"%A{v1607}"
                        let _v1608 = v1624 
                        #endif
#else
                        let v1627 : string = $"{v1607.GetType ()}: {v1607.Message}"
                        let _v1608 = v1627 
                        #endif
                        let v1628 : string = _v1608 
                        let v1633 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v1633 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v1633 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v1633 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v1633 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v1633 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v1633 = () 
                        #endif
#else
                        let v1634 : (string -> unit) = v1464.Push
                        v1634 v1628
                        let _v1633 = () 
                        #endif
                        _v1633 
                        let v1635 : System.Threading.Tasks.TaskCanceledException = v1607 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v1638 : unit = ()
                        let v1639 : (unit -> unit) = closure68(v1635)
                        let v1640 : unit = (fun () -> v1639 (); v1638) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1680 : Async<int32> = _v1584 
            let _v1574 = v1680 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1681 : unit = ()
            let _v1681 =
                async {
                    try
                    let v1682 : System.Threading.Tasks.Task = v1462.WaitForExitAsync v1569 
                    let v1683 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1684 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1685 : Async<unit> = v1684 v1682
                    let _v1683 = v1685 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1686 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1687 : Async<unit> = v1686 v1682
                    let _v1683 = v1687 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1688 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1689 : Async<unit> = v1688 v1682
                    let _v1683 = v1689 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1690 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1691 : Async<unit> = v1690 v1682
                    let _v1683 = v1691 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1692 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1693 : Async<unit> = v1692 v1682
                    let _v1683 = v1693 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1694 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1695 : Async<unit> = v1694 v1682
                    let _v1683 = v1695 
                    #endif
#else
                    let v1696 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1697 : Async<unit> = v1696 v1682
                    let _v1683 = v1697 
                    #endif
                    let v1698 : Async<unit> = _v1683 
                    do! v1698 
                    let v1703 : int32 = v1462.ExitCode
                    return v1703 
                    with ex ->
                        let v1704 : exn = ex
                        let v1705 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1706 : string = $"%A{v1704}"
                        let _v1705 = v1706 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v1709 : string = $"%A{v1704}"
                        let _v1705 = v1709 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1712 : string = $"%A{v1704}"
                        let _v1705 = v1712 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v1715 : string = $"%A{v1704}"
                        let _v1705 = v1715 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v1718 : string = $"%A{v1704}"
                        let _v1705 = v1718 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v1721 : string = $"%A{v1704}"
                        let _v1705 = v1721 
                        #endif
#else
                        let v1724 : string = $"{v1704.GetType ()}: {v1704.Message}"
                        let _v1705 = v1724 
                        #endif
                        let v1725 : string = _v1705 
                        let v1730 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v1730 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v1730 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v1730 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v1730 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v1730 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v1730 = () 
                        #endif
#else
                        let v1731 : (string -> unit) = v1464.Push
                        v1731 v1725
                        let _v1730 = () 
                        #endif
                        _v1730 
                        let v1732 : System.Threading.Tasks.TaskCanceledException = v1704 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v1735 : unit = ()
                        let v1736 : (unit -> unit) = closure68(v1732)
                        let v1737 : unit = (fun () -> v1736 (); v1735) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1777 : Async<int32> = _v1681 
            let _v1574 = v1777 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1778 : unit = ()
            let _v1778 =
                async {
                    try
                    let v1779 : System.Threading.Tasks.Task = v1462.WaitForExitAsync v1569 
                    let v1780 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1781 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1782 : Async<unit> = v1781 v1779
                    let _v1780 = v1782 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1783 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1784 : Async<unit> = v1783 v1779
                    let _v1780 = v1784 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1785 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1786 : Async<unit> = v1785 v1779
                    let _v1780 = v1786 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1787 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1788 : Async<unit> = v1787 v1779
                    let _v1780 = v1788 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1789 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1790 : Async<unit> = v1789 v1779
                    let _v1780 = v1790 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1791 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1792 : Async<unit> = v1791 v1779
                    let _v1780 = v1792 
                    #endif
#else
                    let v1793 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1794 : Async<unit> = v1793 v1779
                    let _v1780 = v1794 
                    #endif
                    let v1795 : Async<unit> = _v1780 
                    do! v1795 
                    let v1800 : int32 = v1462.ExitCode
                    return v1800 
                    with ex ->
                        let v1801 : exn = ex
                        let v1802 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1803 : string = $"%A{v1801}"
                        let _v1802 = v1803 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v1806 : string = $"%A{v1801}"
                        let _v1802 = v1806 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1809 : string = $"%A{v1801}"
                        let _v1802 = v1809 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v1812 : string = $"%A{v1801}"
                        let _v1802 = v1812 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v1815 : string = $"%A{v1801}"
                        let _v1802 = v1815 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v1818 : string = $"%A{v1801}"
                        let _v1802 = v1818 
                        #endif
#else
                        let v1821 : string = $"{v1801.GetType ()}: {v1801.Message}"
                        let _v1802 = v1821 
                        #endif
                        let v1822 : string = _v1802 
                        let v1827 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v1827 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v1827 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v1827 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v1827 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v1827 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v1827 = () 
                        #endif
#else
                        let v1828 : (string -> unit) = v1464.Push
                        v1828 v1822
                        let _v1827 = () 
                        #endif
                        _v1827 
                        let v1829 : System.Threading.Tasks.TaskCanceledException = v1801 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v1832 : unit = ()
                        let v1833 : (unit -> unit) = closure68(v1829)
                        let v1834 : unit = (fun () -> v1833 (); v1832) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1874 : Async<int32> = _v1778 
            let _v1574 = v1874 
            #endif
#else
            let v1875 : unit = ()
            let _v1875 =
                async {
                    try
                    let v1876 : System.Threading.Tasks.Task = v1462.WaitForExitAsync v1569 
                    let v1877 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1878 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1879 : Async<unit> = v1878 v1876
                    let _v1877 = v1879 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1880 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1881 : Async<unit> = v1880 v1876
                    let _v1877 = v1881 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1882 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1883 : Async<unit> = v1882 v1876
                    let _v1877 = v1883 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1884 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1885 : Async<unit> = v1884 v1876
                    let _v1877 = v1885 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1886 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1887 : Async<unit> = v1886 v1876
                    let _v1877 = v1887 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1888 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1889 : Async<unit> = v1888 v1876
                    let _v1877 = v1889 
                    #endif
#else
                    let v1890 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1891 : Async<unit> = v1890 v1876
                    let _v1877 = v1891 
                    #endif
                    let v1892 : Async<unit> = _v1877 
                    do! v1892 
                    let v1897 : int32 = v1462.ExitCode
                    return v1897 
                    with ex ->
                        let v1898 : exn = ex
                        let v1899 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1900 : string = $"%A{v1898}"
                        let _v1899 = v1900 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v1903 : string = $"%A{v1898}"
                        let _v1899 = v1903 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1906 : string = $"%A{v1898}"
                        let _v1899 = v1906 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v1909 : string = $"%A{v1898}"
                        let _v1899 = v1909 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v1912 : string = $"%A{v1898}"
                        let _v1899 = v1912 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v1915 : string = $"%A{v1898}"
                        let _v1899 = v1915 
                        #endif
#else
                        let v1918 : string = $"{v1898.GetType ()}: {v1898.Message}"
                        let _v1899 = v1918 
                        #endif
                        let v1919 : string = _v1899 
                        let v1924 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v1924 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v1924 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v1924 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v1924 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v1924 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v1924 = () 
                        #endif
#else
                        let v1925 : (string -> unit) = v1464.Push
                        v1925 v1919
                        let _v1924 = () 
                        #endif
                        _v1924 
                        let v1926 : System.Threading.Tasks.TaskCanceledException = v1898 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v1929 : unit = ()
                        let v1930 : (unit -> unit) = closure68(v1926)
                        let v1931 : unit = (fun () -> v1930 (); v1929) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1971 : Async<int32> = _v1875 
            let _v1574 = v1971 
            #endif
            let v1972 : Async<int32> = _v1574 
            let! v1972 = v1972 
            let v1977 : int32 = v1972 
            let v1978 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v1979 : string seq = v1978 v1464
            let v1982 : (string seq -> string seq) = Seq.rev
            let v1983 : string seq = v1982 v1979
            let v1986 : string = method135()
            let v1987 : (string -> (string seq -> string)) = String.concat
            let v1988 : (string seq -> string) = v1987 v1986
            let v1989 : string = v1988 v1983
            let v1993 : unit = ()
            let v1994 : (unit -> unit) = closure69(v1977, v1989)
            let v1995 : unit = (fun () -> v1994 (); v1993) ()
            return struct (v1977, v1989) 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v2036 : Async<struct (int32 * string)> = _v1370 
    let _v26 = v2036 
    #endif
#else
    let v2037 : unit = ()
    let _v2037 =
        async {
            let v2038 : US13 = method84(v0)
            let struct (v2049 : string, v2050 : US5) =
                match v2038 with
                | US13_1(v2041) -> (* Error *)
                    let v2042 : string = $"resultm.get / Result value was Error: {v2041}"
                    failwith<struct (string * US5)> v2042
                | US13_0(v2039, v2040) -> (* Ok *)
                    struct (v2039, v2040)
            let v2051 : (string -> US5) = method5()
            let v2052 : US5 option = v6 |> Option.map v2051 
            let v2063 : US5 = US5_1
            let v2064 : US5 = v2052 |> Option.defaultValue v2063 
            let v2071 : string =
                match v2064 with
                | US5_1 -> (* None *)
                    let v2069 : string = ""
                    v2069
                | US5_0(v2068) -> (* Some *)
                    v2068
            let v2072 : unit = ()
            let v2073 : (unit -> unit) = closure61(v0, v1, v2, v3, v4, v5, v6, v2050, v2049)
            let v2074 : unit = (fun () -> v2073 (); v2072) ()
            let v2114 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v2118 : string =
                match v2050 with
                | US5_1 -> (* None *)
                    let v2116 : string = ""
                    v2116
                | US5_0(v2115) -> (* Some *)
                    v2115
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v2118,
              StandardOutputEncoding = v2114,
              WorkingDirectory = v2071,
              FileName = v2049,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v2119 : System.Diagnostics.ProcessStartInfo = start_info
            let v2120 : (struct (string * string) []) = method141(v0, v1, v2, v3, v4, v5, v6)
            let v2121 : int32 = v2120.Length
            let v2122 : Mut6 = {l0 = 0} : Mut6
            while method58(v2121, v2122) do
                let v2124 : int32 = v2122.l0
                let struct (v2125 : string, v2126 : string) = v2120.[int v2124]
                v2119.EnvironmentVariables.[v2125] <- v2126 
                let v2127 : int32 = v2124 + 1
                v2122.l0 <- v2127
                ()
            let v2128 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v2119)
            use v2128 = v2128 
            let v2129 : System.Diagnostics.Process = v2128 
            let v2130 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v2131 : System.Collections.Concurrent.ConcurrentStack<string> = v2130 ()
            let v2132 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure62(v0, v1, v2, v3, v4, v5, v6, v2129, v2131)
            v2129.OutputDataReceived.Add v2132 
            let v2133 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure65(v0, v1, v2, v3, v4, v5, v6, v2129, v2131)
            v2129.ErrorDataReceived.Add v2133 
            let v2134 : (unit -> bool) = v2129.Start
            let v2135 : bool = v2134 ()
            let v2136 : bool = v2135 = false
            if v2136 then
                let v2137 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v2137
            let v2138 : (unit -> unit) = v2129.BeginErrorReadLine
            v2138 ()
            let v2139 : (unit -> unit) = v2129.BeginOutputReadLine
            v2139 ()
            let v2140 : (System.Threading.CancellationToken -> US31) = method143()
            let v2141 : US31 option = v1 |> Option.map v2140 
            let v2152 : US31 = US31_1
            let v2153 : US31 = v2141 |> Option.defaultValue v2152 
            let v2160 : System.Threading.CancellationToken =
                match v2153 with
                | US31_1 -> (* None *)
                    let v2158 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v2158
                | US31_0(v2157) -> (* Some *)
                    v2157
            let v2161 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2162 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v2161 = v2162 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2165 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v2161 = v2165 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2168 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v2161 = v2168 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2171 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v2161 = v2171 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2174 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v2161 = v2174 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2177 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v2161 = v2177 
            #endif
#else
            let v2180 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2181 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v2180 = v2181 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2184 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v2180 = v2184 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2187 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v2180 = v2187 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2190 : unit = ()
            let _v2190 =
                async {
                    let v2191 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v2191 = v2191 
                    let v2192 : System.Threading.CancellationToken = v2191 
                    let v2193 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v2194 : (System.Threading.CancellationToken []) = [|v2192; v2193; v2160|]
                    let v2195 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v2196 : System.Threading.CancellationTokenSource = v2195 v2194
                    let v2197 : System.Threading.CancellationToken = v2196.Token
                    return v2197 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2198 : Async<System.Threading.CancellationToken> = _v2190 
            let _v2180 = v2198 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2199 : unit = ()
            let _v2199 =
                async {
                    let v2200 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v2200 = v2200 
                    let v2201 : System.Threading.CancellationToken = v2200 
                    let v2202 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v2203 : (System.Threading.CancellationToken []) = [|v2201; v2202; v2160|]
                    let v2204 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v2205 : System.Threading.CancellationTokenSource = v2204 v2203
                    let v2206 : System.Threading.CancellationToken = v2205.Token
                    return v2206 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2207 : Async<System.Threading.CancellationToken> = _v2199 
            let _v2180 = v2207 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2208 : unit = ()
            let _v2208 =
                async {
                    let v2209 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v2209 = v2209 
                    let v2210 : System.Threading.CancellationToken = v2209 
                    let v2211 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v2212 : (System.Threading.CancellationToken []) = [|v2210; v2211; v2160|]
                    let v2213 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v2214 : System.Threading.CancellationTokenSource = v2213 v2212
                    let v2215 : System.Threading.CancellationToken = v2214.Token
                    return v2215 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2216 : Async<System.Threading.CancellationToken> = _v2208 
            let _v2180 = v2216 
            #endif
#else
            let v2217 : unit = ()
            let _v2217 =
                async {
                    let v2218 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v2218 = v2218 
                    let v2219 : System.Threading.CancellationToken = v2218 
                    let v2220 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v2221 : (System.Threading.CancellationToken []) = [|v2219; v2220; v2160|]
                    let v2222 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v2223 : System.Threading.CancellationTokenSource = v2222 v2221
                    let v2224 : System.Threading.CancellationToken = v2223.Token
                    return v2224 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2225 : Async<System.Threading.CancellationToken> = _v2217 
            let _v2180 = v2225 
            #endif
            let v2226 : Async<System.Threading.CancellationToken> = _v2180 
            let _v2161 = v2226 
            #endif
            let v2231 : Async<System.Threading.CancellationToken> = _v2161 
            let! v2231 = v2231 
            let v2236 : System.Threading.CancellationToken = v2231 
            let v2237 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v2236.Register
            let v2238 : (unit -> unit) = closure67(v2129)
            let v2239 : System.Threading.CancellationTokenRegistration = v2237 v2238
            use v2239 = v2239 
            let v2240 : System.Threading.CancellationTokenRegistration = v2239 
            let v2241 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2242 : Async<int32> = null |> unbox<Async<int32>>
            let _v2241 = v2242 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2245 : Async<int32> = null |> unbox<Async<int32>>
            let _v2241 = v2245 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2248 : Async<int32> = null |> unbox<Async<int32>>
            let _v2241 = v2248 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2251 : unit = ()
            let _v2251 =
                async {
                    try
                    let v2252 : System.Threading.Tasks.Task = v2129.WaitForExitAsync v2236 
                    let v2253 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2254 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2255 : Async<unit> = v2254 v2252
                    let _v2253 = v2255 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2256 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2257 : Async<unit> = v2256 v2252
                    let _v2253 = v2257 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2258 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2259 : Async<unit> = v2258 v2252
                    let _v2253 = v2259 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2260 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2261 : Async<unit> = v2260 v2252
                    let _v2253 = v2261 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2262 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2263 : Async<unit> = v2262 v2252
                    let _v2253 = v2263 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v2264 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2265 : Async<unit> = v2264 v2252
                    let _v2253 = v2265 
                    #endif
#else
                    let v2266 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2267 : Async<unit> = v2266 v2252
                    let _v2253 = v2267 
                    #endif
                    let v2268 : Async<unit> = _v2253 
                    do! v2268 
                    let v2273 : int32 = v2129.ExitCode
                    return v2273 
                    with ex ->
                        let v2274 : exn = ex
                        let v2275 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2276 : string = $"%A{v2274}"
                        let _v2275 = v2276 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v2279 : string = $"%A{v2274}"
                        let _v2275 = v2279 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2282 : string = $"%A{v2274}"
                        let _v2275 = v2282 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v2285 : string = $"%A{v2274}"
                        let _v2275 = v2285 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v2288 : string = $"%A{v2274}"
                        let _v2275 = v2288 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v2291 : string = $"%A{v2274}"
                        let _v2275 = v2291 
                        #endif
#else
                        let v2294 : string = $"{v2274.GetType ()}: {v2274.Message}"
                        let _v2275 = v2294 
                        #endif
                        let v2295 : string = _v2275 
                        let v2300 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v2300 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v2300 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v2300 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v2300 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v2300 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v2300 = () 
                        #endif
#else
                        let v2301 : (string -> unit) = v2131.Push
                        v2301 v2295
                        let _v2300 = () 
                        #endif
                        _v2300 
                        let v2302 : System.Threading.Tasks.TaskCanceledException = v2274 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v2305 : unit = ()
                        let v2306 : (unit -> unit) = closure68(v2302)
                        let v2307 : unit = (fun () -> v2306 (); v2305) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2347 : Async<int32> = _v2251 
            let _v2241 = v2347 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2348 : unit = ()
            let _v2348 =
                async {
                    try
                    let v2349 : System.Threading.Tasks.Task = v2129.WaitForExitAsync v2236 
                    let v2350 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2351 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2352 : Async<unit> = v2351 v2349
                    let _v2350 = v2352 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2353 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2354 : Async<unit> = v2353 v2349
                    let _v2350 = v2354 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2355 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2356 : Async<unit> = v2355 v2349
                    let _v2350 = v2356 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2357 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2358 : Async<unit> = v2357 v2349
                    let _v2350 = v2358 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2359 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2360 : Async<unit> = v2359 v2349
                    let _v2350 = v2360 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v2361 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2362 : Async<unit> = v2361 v2349
                    let _v2350 = v2362 
                    #endif
#else
                    let v2363 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2364 : Async<unit> = v2363 v2349
                    let _v2350 = v2364 
                    #endif
                    let v2365 : Async<unit> = _v2350 
                    do! v2365 
                    let v2370 : int32 = v2129.ExitCode
                    return v2370 
                    with ex ->
                        let v2371 : exn = ex
                        let v2372 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2373 : string = $"%A{v2371}"
                        let _v2372 = v2373 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v2376 : string = $"%A{v2371}"
                        let _v2372 = v2376 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2379 : string = $"%A{v2371}"
                        let _v2372 = v2379 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v2382 : string = $"%A{v2371}"
                        let _v2372 = v2382 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v2385 : string = $"%A{v2371}"
                        let _v2372 = v2385 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v2388 : string = $"%A{v2371}"
                        let _v2372 = v2388 
                        #endif
#else
                        let v2391 : string = $"{v2371.GetType ()}: {v2371.Message}"
                        let _v2372 = v2391 
                        #endif
                        let v2392 : string = _v2372 
                        let v2397 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v2397 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v2397 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v2397 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v2397 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v2397 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v2397 = () 
                        #endif
#else
                        let v2398 : (string -> unit) = v2131.Push
                        v2398 v2392
                        let _v2397 = () 
                        #endif
                        _v2397 
                        let v2399 : System.Threading.Tasks.TaskCanceledException = v2371 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v2402 : unit = ()
                        let v2403 : (unit -> unit) = closure68(v2399)
                        let v2404 : unit = (fun () -> v2403 (); v2402) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2444 : Async<int32> = _v2348 
            let _v2241 = v2444 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2445 : unit = ()
            let _v2445 =
                async {
                    try
                    let v2446 : System.Threading.Tasks.Task = v2129.WaitForExitAsync v2236 
                    let v2447 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2448 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2449 : Async<unit> = v2448 v2446
                    let _v2447 = v2449 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2450 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2451 : Async<unit> = v2450 v2446
                    let _v2447 = v2451 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2452 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2453 : Async<unit> = v2452 v2446
                    let _v2447 = v2453 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2454 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2455 : Async<unit> = v2454 v2446
                    let _v2447 = v2455 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2456 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2457 : Async<unit> = v2456 v2446
                    let _v2447 = v2457 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v2458 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2459 : Async<unit> = v2458 v2446
                    let _v2447 = v2459 
                    #endif
#else
                    let v2460 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2461 : Async<unit> = v2460 v2446
                    let _v2447 = v2461 
                    #endif
                    let v2462 : Async<unit> = _v2447 
                    do! v2462 
                    let v2467 : int32 = v2129.ExitCode
                    return v2467 
                    with ex ->
                        let v2468 : exn = ex
                        let v2469 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2470 : string = $"%A{v2468}"
                        let _v2469 = v2470 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v2473 : string = $"%A{v2468}"
                        let _v2469 = v2473 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2476 : string = $"%A{v2468}"
                        let _v2469 = v2476 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v2479 : string = $"%A{v2468}"
                        let _v2469 = v2479 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v2482 : string = $"%A{v2468}"
                        let _v2469 = v2482 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v2485 : string = $"%A{v2468}"
                        let _v2469 = v2485 
                        #endif
#else
                        let v2488 : string = $"{v2468.GetType ()}: {v2468.Message}"
                        let _v2469 = v2488 
                        #endif
                        let v2489 : string = _v2469 
                        let v2494 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v2494 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v2494 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v2494 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v2494 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v2494 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v2494 = () 
                        #endif
#else
                        let v2495 : (string -> unit) = v2131.Push
                        v2495 v2489
                        let _v2494 = () 
                        #endif
                        _v2494 
                        let v2496 : System.Threading.Tasks.TaskCanceledException = v2468 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v2499 : unit = ()
                        let v2500 : (unit -> unit) = closure68(v2496)
                        let v2501 : unit = (fun () -> v2500 (); v2499) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2541 : Async<int32> = _v2445 
            let _v2241 = v2541 
            #endif
#else
            let v2542 : unit = ()
            let _v2542 =
                async {
                    try
                    let v2543 : System.Threading.Tasks.Task = v2129.WaitForExitAsync v2236 
                    let v2544 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2545 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2546 : Async<unit> = v2545 v2543
                    let _v2544 = v2546 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2547 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2548 : Async<unit> = v2547 v2543
                    let _v2544 = v2548 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2549 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2550 : Async<unit> = v2549 v2543
                    let _v2544 = v2550 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2551 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2552 : Async<unit> = v2551 v2543
                    let _v2544 = v2552 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2553 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2554 : Async<unit> = v2553 v2543
                    let _v2544 = v2554 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v2555 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2556 : Async<unit> = v2555 v2543
                    let _v2544 = v2556 
                    #endif
#else
                    let v2557 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2558 : Async<unit> = v2557 v2543
                    let _v2544 = v2558 
                    #endif
                    let v2559 : Async<unit> = _v2544 
                    do! v2559 
                    let v2564 : int32 = v2129.ExitCode
                    return v2564 
                    with ex ->
                        let v2565 : exn = ex
                        let v2566 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2567 : string = $"%A{v2565}"
                        let _v2566 = v2567 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v2570 : string = $"%A{v2565}"
                        let _v2566 = v2570 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2573 : string = $"%A{v2565}"
                        let _v2566 = v2573 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v2576 : string = $"%A{v2565}"
                        let _v2566 = v2576 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v2579 : string = $"%A{v2565}"
                        let _v2566 = v2579 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v2582 : string = $"%A{v2565}"
                        let _v2566 = v2582 
                        #endif
#else
                        let v2585 : string = $"{v2565.GetType ()}: {v2565.Message}"
                        let _v2566 = v2585 
                        #endif
                        let v2586 : string = _v2566 
                        let v2591 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v2591 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v2591 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v2591 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v2591 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v2591 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v2591 = () 
                        #endif
#else
                        let v2592 : (string -> unit) = v2131.Push
                        v2592 v2586
                        let _v2591 = () 
                        #endif
                        _v2591 
                        let v2593 : System.Threading.Tasks.TaskCanceledException = v2565 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v2596 : unit = ()
                        let v2597 : (unit -> unit) = closure68(v2593)
                        let v2598 : unit = (fun () -> v2597 (); v2596) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2638 : Async<int32> = _v2542 
            let _v2241 = v2638 
            #endif
            let v2639 : Async<int32> = _v2241 
            let! v2639 = v2639 
            let v2644 : int32 = v2639 
            let v2645 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v2646 : string seq = v2645 v2131
            let v2649 : (string seq -> string seq) = Seq.rev
            let v2650 : string seq = v2649 v2646
            let v2653 : string = method135()
            let v2654 : (string -> (string seq -> string)) = String.concat
            let v2655 : (string seq -> string) = v2654 v2653
            let v2656 : string = v2655 v2650
            let v2660 : unit = ()
            let v2661 : (unit -> unit) = closure69(v2644, v2656)
            let v2662 : unit = (fun () -> v2661 (); v2660) ()
            return struct (v2644, v2656) 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v2703 : Async<struct (int32 * string)> = _v2037 
    let _v26 = v2703 
    #endif
    let v2704 : Async<struct (int32 * string)> = _v26 
    let _v7 = v2704 
    #endif
    let v2709 : Async<struct (int32 * string)> = _v7 
    v2709
and method82 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : struct (int32 * string) =
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = method83(v0, v1, v2, v3, v4, v5, v6)
    let v9 : US13 = method84(v8)
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
    let v26 : US21 = method96(v25)
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
    let v94 : (unit -> unit) = closure41(v0, v1, v2, v3, v4, v5, v6, v20, v92)
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
    let v143 : string = "std::process::Command::args(&mut $0, &*$1)"
    let v144 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr struct (v140, v92) v143 
    let v145 : string = "std::process::Stdio::piped()"
    let v146 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v145 
    let v147 : string = "std::process::Command::stdout($0, std::process::Stdio::piped())"
    let v148 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v144 v147 
    let v149 : string = "std::process::Stdio::piped()"
    let v150 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v149 
    let v151 : string = "std::process::Command::stderr($0, std::process::Stdio::piped())"
    let v152 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v148 v151 
    let v153 : string = "std::process::Stdio::piped()"
    let v154 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v153 
    let v155 : string = "std::process::Command::stdin($0, std::process::Stdio::piped())"
    let v156 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v152 v155 
    let v157 : (string -> US5) = method5()
    let v158 : US5 option = v6 |> Option.map v157 
    let v169 : US5 = US5_1
    let v170 : US5 = v158 |> Option.defaultValue v169 
    let v178 : Ref<Mut<std_process_Command>> =
        match v170 with
        | US5_1 -> (* None *)
            v156
        | US5_0(v174) -> (* Some *)
            let v175 : string = "std::process::Command::current_dir(v156, &*$0)"
            let v176 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v174 v175 
            v176
    let v179 : uint64 = System.Convert.ToUInt64 v2.Length
    let v180 : bool = v179 = 0UL
    let v196 : Ref<Mut<std_process_Command>> =
        if v180 then
            v178
        else
            let v181 : string = "$0.to_vec()"
            let v182 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr v2 v181 
            let v183 : string = "true; let _vec_fold_ = $0.into_iter().fold(v178, |acc, x| { //"
            let v184 : bool = Fable.Core.RustInterop.emitRustExpr v182 v183 
            let v185 : string = "acc"
            let v186 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr () v185 
            let v187 : string = "x"
            let struct (v188 : string, v189 : string) = Fable.Core.RustInterop.emitRustExpr () v187 
            let v190 : string = "std::process::Command::env(v186, &*$0, &*$1)"
            let v191 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr struct (v188, v189) v190 
            let v192 : string = "true; $0 })"
            let v193 : bool = Fable.Core.RustInterop.emitRustExpr v191 v192 
            let v194 : string = "_vec_fold_"
            let v195 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr () v194 
            v195
    let v197 : string = "std::process::Command::spawn($0)"
    let v198 : Result<std_process_Child, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v196 v197 
    let v199 : (std_io_Error -> std_string_String) = method65()
    let v200 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v201 : string = "$0.map_err(|x| $1(x))"
    let v202 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v198, v199) v201 
    let _v200 = v202 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v203 : string = "$0.map_err(|x| $1(x))"
    let v204 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v198, v199) v203 
    let _v200 = v204 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v205 : string = "$0.map_err(|x| $1(x))"
    let v206 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v198, v199) v205 
    let _v200 = v206 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v207 : Result<std_process_Child, std_string_String> = match v198 with Ok x -> Ok x | Error x -> Error (v199 x)
    let _v200 = v207 
    #endif
#if FABLE_COMPILER_PYTHON
    let v208 : Result<std_process_Child, std_string_String> = match v198 with Ok x -> Ok x | Error x -> Error (v199 x)
    let _v200 = v208 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v209 : Result<std_process_Child, std_string_String> = match v198 with Ok x -> Ok x | Error x -> Error (v199 x)
    let _v200 = v209 
    #endif
#else
    let v210 : Result<std_process_Child, std_string_String> = match v198 with Ok x -> Ok x | Error x -> Error (v199 x)
    let _v200 = v210 
    #endif
    let v211 : Result<std_process_Child, std_string_String> = _v200 
    let v214 : (std_process_Child option -> std_process_Child option) = method108()
    let v215 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v216 : bool = Fable.Core.RustInterop.emitRustExpr v211 v215 
    let v217 : string = "x"
    let v218 : std_process_Child = Fable.Core.RustInterop.emitRustExpr () v217 
    let v219 : std_process_Child option = Some v218 
    let v222 : std_process_Child option = v214 v219
    let v223 : string = "std::sync::Mutex::new(v222)"
    let v224 : std_sync_Mutex<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr () v223 
    let v225 : string = "std::sync::Arc::new(v224)"
    let v226 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr () v225 
    let v227 : string = "true; $0 })"
    let v228 : bool = Fable.Core.RustInterop.emitRustExpr v226 v227 
    let v229 : string = "_result_map_"
    let v230 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v229 
    let v231 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US23) = method109()
    let v232 : (std_string_String -> US23) = method110()
    let v233 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
    let v234 : US23 = Fable.Core.RustInterop.emitRustExpr struct (v231, v232, v230) v233 
    let struct (v1380 : int32, v1381 : US6, v1382 : US24) =
        match v234 with
        | US23_1(v1332) -> (* Error *)
            let v1333 : unit = ()
            let v1334 : (unit -> unit) = closure45(v1332)
            let v1335 : unit = (fun () -> v1334 (); v1333) ()
            let v1375 : US6 = US6_0(v1332)
            let v1376 : US24 = US24_1
            struct (-1, v1375, v1376)
        | US23_0(v235) -> (* Ok *)
            let v236 : string = "true; let _capture = (|| { //"
            let v237 : bool = Fable.Core.RustInterop.emitRustExpr () v236 
            let v238 : string = "$0"
            let v239 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v235 v238 
            let v240 : string = "v239.lock()"
            let v241 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v240 
            let v242 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v243 : string = "$0.unwrap()"
            let v244 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v241 v243 
            let _v242 = v244 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v245 : string = "$0.unwrap()"
            let v246 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v241 v245 
            let _v242 = v246 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v247 : string = "$0.unwrap()"
            let v248 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v241 v247 
            let _v242 = v248 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v249 : std_sync_MutexGuard<std_process_Child option> = match v241 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v242 = v249 
            #endif
#if FABLE_COMPILER_PYTHON
            let v250 : std_sync_MutexGuard<std_process_Child option> = match v241 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v242 = v250 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v251 : std_sync_MutexGuard<std_process_Child option> = match v241 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v242 = v251 
            #endif
#else
            let v252 : std_sync_MutexGuard<std_process_Child option> = match v241 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v242 = v252 
            #endif
            let v253 : std_sync_MutexGuard<std_process_Child option> = _v242 
            let v256 : std_sync_MutexGuard<std_process_Child option> = method112(v253)
            let v257 : string = "true; let mut v256 = v256"
            let v258 : bool = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "&mut $0"
            let v260 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v256 v259 
            let v261 : string = "$0.as_mut()"
            let v262 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "$0.unwrap()"
            let v264 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v262 v263 
            let v265 : string = "&mut $0.stdout"
            let v266 : Ref<Mut<std_process_ChildStdout option>> = Fable.Core.RustInterop.emitRustExpr v264 v265 
            let v267 : string = "Option::take($0)"
            let v268 : std_process_ChildStdout option = Fable.Core.RustInterop.emitRustExpr v266 v267 
            let v269 : string = "$0.unwrap()"
            let v270 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr v268 v269 
            let v271 : string = "true; $0 })()"
            let v272 : bool = Fable.Core.RustInterop.emitRustExpr v270 v271 
            let v273 : string = "_capture"
            let v274 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr () v273 
            let v275 : string = "true; let _capture = (|| { //"
            let v276 : bool = Fable.Core.RustInterop.emitRustExpr () v275 
            let v277 : string = "$0"
            let v278 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v235 v277 
            let v279 : string = "v278.lock()"
            let v280 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v279 
            let v281 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v282 : string = "$0.unwrap()"
            let v283 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v280 v282 
            let _v281 = v283 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v284 : string = "$0.unwrap()"
            let v285 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v280 v284 
            let _v281 = v285 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v286 : string = "$0.unwrap()"
            let v287 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v280 v286 
            let _v281 = v287 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v288 : std_sync_MutexGuard<std_process_Child option> = match v280 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v281 = v288 
            #endif
#if FABLE_COMPILER_PYTHON
            let v289 : std_sync_MutexGuard<std_process_Child option> = match v280 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v281 = v289 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v290 : std_sync_MutexGuard<std_process_Child option> = match v280 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v281 = v290 
            #endif
#else
            let v291 : std_sync_MutexGuard<std_process_Child option> = match v280 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v281 = v291 
            #endif
            let v292 : std_sync_MutexGuard<std_process_Child option> = _v281 
            let v295 : std_sync_MutexGuard<std_process_Child option> = method112(v292)
            let v296 : string = "true; let mut v295 = v295"
            let v297 : bool = Fable.Core.RustInterop.emitRustExpr () v296 
            let v298 : string = "&mut $0"
            let v299 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v295 v298 
            let v300 : string = "$0.as_mut()"
            let v301 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v299 v300 
            let v302 : string = "$0.unwrap()"
            let v303 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v301 v302 
            let v304 : string = "&mut $0.stderr"
            let v305 : Ref<Mut<std_process_ChildStderr option>> = Fable.Core.RustInterop.emitRustExpr v303 v304 
            let v306 : string = "Option::take($0)"
            let v307 : std_process_ChildStderr option = Fable.Core.RustInterop.emitRustExpr v305 v306 
            let v308 : string = "$0.unwrap()"
            let v309 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr v307 v308 
            let v310 : string = "true; $0 })()"
            let v311 : bool = Fable.Core.RustInterop.emitRustExpr v309 v310 
            let v312 : string = "_capture"
            let v313 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr () v312 
            let v314 : string = "true; let _capture = (|| { //"
            let v315 : bool = Fable.Core.RustInterop.emitRustExpr () v314 
            let v316 : string = "$0"
            let v317 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v235 v316 
            let v318 : string = "v317.lock()"
            let v319 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v318 
            let v320 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v321 : string = "$0.unwrap()"
            let v322 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v319 v321 
            let _v320 = v322 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v323 : string = "$0.unwrap()"
            let v324 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v319 v323 
            let _v320 = v324 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v325 : string = "$0.unwrap()"
            let v326 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v319 v325 
            let _v320 = v326 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v327 : std_sync_MutexGuard<std_process_Child option> = match v319 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v320 = v327 
            #endif
#if FABLE_COMPILER_PYTHON
            let v328 : std_sync_MutexGuard<std_process_Child option> = match v319 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v320 = v328 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v329 : std_sync_MutexGuard<std_process_Child option> = match v319 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v320 = v329 
            #endif
#else
            let v330 : std_sync_MutexGuard<std_process_Child option> = match v319 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v320 = v330 
            #endif
            let v331 : std_sync_MutexGuard<std_process_Child option> = _v320 
            let v334 : std_sync_MutexGuard<std_process_Child option> = method112(v331)
            let v335 : string = "true; let mut v334 = v334"
            let v336 : bool = Fable.Core.RustInterop.emitRustExpr () v335 
            let v337 : string = "&mut $0"
            let v338 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v334 v337 
            let v339 : string = "$0.as_mut()"
            let v340 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v338 v339 
            let v341 : string = "$0.unwrap()"
            let v342 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v340 v341 
            let v343 : string = "&mut $0.stdin"
            let v344 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v342 v343 
            let v345 : string = "Option::take($0)"
            let v346 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v344 v345 
            let v347 : string = "$0.unwrap()"
            let v348 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr v346 v347 
            let v349 : std_process_ChildStdin option = Some v348 
            let v352 : (std_process_ChildStdin option -> std_process_ChildStdin option) = method113()
            let v353 : std_process_ChildStdin option = v352 v349
            let v354 : string = "std::sync::Mutex::new(v353)"
            let v355 : std_sync_Mutex<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr () v354 
            let v356 : string = "std::sync::Arc::new(v355)"
            let v357 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v356 
            let v358 : string = "true; $0 })()"
            let v359 : bool = Fable.Core.RustInterop.emitRustExpr v357 v358 
            let v360 : string = "_capture"
            let v361 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v360 
            let v362 : string = "{ let (sender, receiver) = std::sync::mpsc::channel(); (sender, std::sync::Arc::new(receiver)) }"
            let struct (v363 : std_sync_mpsc_Sender<std_string_String>, v364 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = Fable.Core.RustInterop.emitRustExpr () v362 
            let v365 : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) = method114()
            let v366 : std_sync_mpsc_Sender<std_string_String> = v365 v363
            let v367 : string = "std::sync::Mutex::new(v366)"
            let v368 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v367 
            let v369 : string = "std::sync::Arc::new(v368)"
            let v370 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v369 
            let v371 : (std_sync_mpsc_Sender<std_string_String> -> std_sync_mpsc_Sender<std_string_String>) = method115()
            let v372 : std_sync_mpsc_Sender<std_string_String> = v371 v363
            let v373 : string = "std::sync::Mutex::new(v372)"
            let v374 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v373 
            let v375 : string = "std::sync::Arc::new(v374)"
            let v376 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v375 
            let v377 : (std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> -> std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = method116()
            let v378 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>> = v377 v364
            let v379 : string = "std::sync::Mutex::new(v378)"
            let v380 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v379 
            let v381 : string = "std::sync::Arc::new(v380)"
            let v382 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v381 
            let v383 : string = "true; let __spawn = std::thread::spawn(move || { //"
            let v384 : bool = Fable.Core.RustInterop.emitRustExpr () v383 
            let v385 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v386 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v274 v385 
            let v387 : string = "std::io::BufReader::new($0)"
            let v388 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr v386 v387 
            let v389 : string = "std::io::BufRead::lines(v388)"
            let v390 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v389 
            let v391 : string = "true; let mut v390 = v390; let _iter_try_for_each = v390.try_for_each(|x| { //"
            let v392 : bool = Fable.Core.RustInterop.emitRustExpr () v391 
            let v393 : string = "x"
            let v394 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v393 
            let v395 : string = "$0.clone()"
            let v396 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v370 v395 
            let v397 : (std_io_Error -> std_string_String) = method65()
            let v398 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v399 : string = "$0.map_err(|x| $1(x))"
            let v400 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v394, v397) v399 
            let _v398 = v400 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v401 : string = "$0.map_err(|x| $1(x))"
            let v402 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v394, v397) v401 
            let _v398 = v402 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v403 : string = "$0.map_err(|x| $1(x))"
            let v404 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v394, v397) v403 
            let _v398 = v404 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v405 : Result<std_string_String, std_string_String> = match v394 with Ok x -> Ok x | Error x -> Error (v397 x)
            let _v398 = v405 
            #endif
#if FABLE_COMPILER_PYTHON
            let v406 : Result<std_string_String, std_string_String> = match v394 with Ok x -> Ok x | Error x -> Error (v397 x)
            let _v398 = v406 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v407 : Result<std_string_String, std_string_String> = match v394 with Ok x -> Ok x | Error x -> Error (v397 x)
            let _v398 = v407 
            #endif
#else
            let v408 : Result<std_string_String, std_string_String> = match v394 with Ok x -> Ok x | Error x -> Error (v397 x)
            let _v398 = v408 
            #endif
            let v409 : Result<std_string_String, std_string_String> = _v398 
            let v412 : (std_string_String -> US25) = method117()
            let v413 : (std_string_String -> US25) = method118()
            let v414 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v415 : US25 = Fable.Core.RustInterop.emitRustExpr struct (v412, v413, v409) v414 
            let v610 : std_string_String =
                match v415 with
                | US25_1(v517) -> (* Error *)
                    let v518 : unit = ()
                    let v519 : (unit -> unit) = closure51(v5, v517)
                    let v520 : unit = (fun () -> v519 (); v518) ()
                    let v560 : string = $"\u001b[4;7m{v517}\u001b[0m"
                    let v561 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v562 : string = "&*$0"
                    let v563 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v560 v562 
                    let _v561 = v563 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v564 : string = "&*$0"
                    let v565 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v560 v564 
                    let _v561 = v565 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v566 : string = "&*$0"
                    let v567 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v560 v566 
                    let _v561 = v567 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v568 : Ref<Str> = v560 |> unbox<Ref<Str>>
                    let _v561 = v568 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v571 : Ref<Str> = v560 |> unbox<Ref<Str>>
                    let _v561 = v571 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v574 : Ref<Str> = v560 |> unbox<Ref<Str>>
                    let _v561 = v574 
                    #endif
#else
                    let v577 : Ref<Str> = v560 |> unbox<Ref<Str>>
                    let _v561 = v577 
                    #endif
                    let v580 : Ref<Str> = _v561 
                    let v585 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v586 : string = "String::from($0)"
                    let v587 : std_string_String = Fable.Core.RustInterop.emitRustExpr v580 v586 
                    let _v585 = v587 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v588 : string = "String::from($0)"
                    let v589 : std_string_String = Fable.Core.RustInterop.emitRustExpr v580 v588 
                    let _v585 = v589 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v590 : string = "String::from($0)"
                    let v591 : std_string_String = Fable.Core.RustInterop.emitRustExpr v580 v590 
                    let _v585 = v591 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v592 : std_string_String = v580 |> unbox<std_string_String>
                    let _v585 = v592 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v595 : std_string_String = v580 |> unbox<std_string_String>
                    let _v585 = v595 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v598 : std_string_String = v580 |> unbox<std_string_String>
                    let _v585 = v598 
                    #endif
#else
                    let v601 : std_string_String = v580 |> unbox<std_string_String>
                    let _v585 = v601 
                    #endif
                    let v604 : std_string_String = _v585 
                    v604
                | US25_0(v416) -> (* Ok *)
                    let v417 : string = "fable_library_rust::String_::fromString($0)"
                    let v418 : string = Fable.Core.RustInterop.emitRustExpr v416 v417 
                    let v419 : string = "encoding_rs::UTF_8"
                    let v420 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v419 
                    let v421 : string = "$0.encode(&*$1).0"
                    let v422 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v420, v418) v421 
                    let v423 : string = "$0.as_ref()"
                    let v424 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v422 v423 
                    let v425 : string = "std::str::from_utf8($0)"
                    let v426 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr v424 v425 
                    let v427 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v428 : string = "$0.unwrap()"
                    let v429 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v426 v428 
                    let _v427 = v429 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v430 : string = "$0.unwrap()"
                    let v431 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v426 v430 
                    let _v427 = v431 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v432 : string = "$0.unwrap()"
                    let v433 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v426 v432 
                    let _v427 = v433 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v434 : Ref<Str> = match v426 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v427 = v434 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v435 : Ref<Str> = match v426 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v427 = v435 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v436 : Ref<Str> = match v426 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v427 = v436 
                    #endif
#else
                    let v437 : Ref<Str> = match v426 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v427 = v437 
                    #endif
                    let v438 : Ref<Str> = _v427 
                    let v441 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v442 : string = "String::from($0)"
                    let v443 : std_string_String = Fable.Core.RustInterop.emitRustExpr v438 v442 
                    let _v441 = v443 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v444 : string = "String::from($0)"
                    let v445 : std_string_String = Fable.Core.RustInterop.emitRustExpr v438 v444 
                    let _v441 = v445 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v446 : string = "String::from($0)"
                    let v447 : std_string_String = Fable.Core.RustInterop.emitRustExpr v438 v446 
                    let _v441 = v447 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v448 : std_string_String = v438 |> unbox<std_string_String>
                    let _v441 = v448 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v451 : std_string_String = v438 |> unbox<std_string_String>
                    let _v441 = v451 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v454 : std_string_String = v438 |> unbox<std_string_String>
                    let _v441 = v454 
                    #endif
#else
                    let v457 : std_string_String = v438 |> unbox<std_string_String>
                    let _v441 = v457 
                    #endif
                    let v460 : std_string_String = _v441 
                    let v465 : string = "fable_library_rust::String_::fromString($0)"
                    let v466 : string = Fable.Core.RustInterop.emitRustExpr v460 v465 
                    let v467 : string = $"> {v466}"
                    if v5 then
                        let v468 : unit = ()
                        let v469 : (unit -> unit) = closure52(v467)
                        let v470 : unit = (fun () -> v469 (); v468) ()
                        ()
                    else
                        let v513 : unit = ()
                        let v514 : (unit -> unit) = closure11(v467)
                        let v515 : unit = (fun () -> v514 (); v513) ()
                        ()
                    v460
            let v611 : string = "$0"
            let v612 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v396 v611 
            let v613 : string = "v612.lock()"
            let v614 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v613 
            let v615 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v616 : string = "$0.unwrap()"
            let v617 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v614 v616 
            let _v615 = v617 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v618 : string = "$0.unwrap()"
            let v619 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v614 v618 
            let _v615 = v619 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v620 : string = "$0.unwrap()"
            let v621 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v614 v620 
            let _v615 = v621 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v622 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v614 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v615 = v622 
            #endif
#if FABLE_COMPILER_PYTHON
            let v623 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v614 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v615 = v623 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v624 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v614 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v615 = v624 
            #endif
#else
            let v625 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v614 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v615 = v625 
            #endif
            let v626 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = _v615 
            let v629 : string = "&$0"
            let v630 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v626 v629 
            let v631 : string = "$0.send($1)"
            let v632 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v630, v610) v631 
            let v633 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method124()
            let v634 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v635 : string = "$0.map_err(|x| $1(x))"
            let v636 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v632, v633) v635 
            let _v634 = v636 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v637 : string = "$0.map_err(|x| $1(x))"
            let v638 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v632, v633) v637 
            let _v634 = v638 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v639 : string = "$0.map_err(|x| $1(x))"
            let v640 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v632, v633) v639 
            let _v634 = v640 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v641 : Result<unit, std_string_String> = match v632 with Ok x -> Ok x | Error x -> Error (v633 x)
            let _v634 = v641 
            #endif
#if FABLE_COMPILER_PYTHON
            let v642 : Result<unit, std_string_String> = match v632 with Ok x -> Ok x | Error x -> Error (v633 x)
            let _v634 = v642 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v643 : Result<unit, std_string_String> = match v632 with Ok x -> Ok x | Error x -> Error (v633 x)
            let _v634 = v643 
            #endif
#else
            let v644 : Result<unit, std_string_String> = match v632 with Ok x -> Ok x | Error x -> Error (v633 x)
            let _v634 = v644 
            #endif
            let v645 : Result<unit, std_string_String> = _v634 
            let v648 : string = "$0"
            let v649 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v645 v648 
            let v650 : string = "true; $0 }); //"
            let v651 : bool = Fable.Core.RustInterop.emitRustExpr v649 v650 
            let v652 : string = "_iter_try_for_each.map_err(|x| x.into())"
            let v653 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v652 
            let v654 : Result<unit, string> = method125(v653)
            let v655 : string = ""
            let v656 : string = "}"
            let v657 : string = v655 + v656 
            let v658 : _ = v654 
            let v659 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v660 : string = $"true; let v658 = $0"
            let v661 : bool = Fable.Core.RustInterop.emitRustExpr v658 v660 
            let _v659 = v661 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v662 : string = $"true; let v658 = $0"
            let v663 : bool = Fable.Core.RustInterop.emitRustExpr v658 v662 
            let _v659 = v663 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v664 : string = $"true; let v658 = $0"
            let v665 : bool = Fable.Core.RustInterop.emitRustExpr v658 v664 
            let _v659 = v665 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v666 : bool = true
            let _v659 = v666 
            #endif
#if FABLE_COMPILER_PYTHON
            let v667 : bool = true
            let _v659 = v667 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v668 : bool = true
            let _v659 = v668 
            #endif
#else
            let v669 : bool = true
            let _v659 = v669 
            #endif
            let v670 : bool = _v659 
            let v673 : string = $"true; v658 " + v657 + "); " + v655 + " // rust.fix_closure'"
            let v674 : bool = Fable.Core.RustInterop.emitRustExpr () v673 
            let v675 : string = "__spawn"
            let v676 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v675 
            let v677 : string = "true; let __spawn = std::thread::spawn(move || { //"
            let v678 : bool = Fable.Core.RustInterop.emitRustExpr () v677 
            let v679 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v680 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v313 v679 
            let v681 : string = "std::io::BufReader::new($0)"
            let v682 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr v680 v681 
            let v683 : string = "std::io::BufRead::lines(v682)"
            let v684 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v683 
            let v685 : string = "true; let mut v684 = v684; let _iter_try_for_each = v684.try_for_each(|x| { //"
            let v686 : bool = Fable.Core.RustInterop.emitRustExpr () v685 
            let v687 : string = "x"
            let v688 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v687 
            let v689 : string = "$0.clone()"
            let v690 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v376 v689 
            let v691 : (std_io_Error -> std_string_String) = method65()
            let v692 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v693 : string = "$0.map_err(|x| $1(x))"
            let v694 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v688, v691) v693 
            let _v692 = v694 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v695 : string = "$0.map_err(|x| $1(x))"
            let v696 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v688, v691) v695 
            let _v692 = v696 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v697 : string = "$0.map_err(|x| $1(x))"
            let v698 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v688, v691) v697 
            let _v692 = v698 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v699 : Result<std_string_String, std_string_String> = match v688 with Ok x -> Ok x | Error x -> Error (v691 x)
            let _v692 = v699 
            #endif
#if FABLE_COMPILER_PYTHON
            let v700 : Result<std_string_String, std_string_String> = match v688 with Ok x -> Ok x | Error x -> Error (v691 x)
            let _v692 = v700 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v701 : Result<std_string_String, std_string_String> = match v688 with Ok x -> Ok x | Error x -> Error (v691 x)
            let _v692 = v701 
            #endif
#else
            let v702 : Result<std_string_String, std_string_String> = match v688 with Ok x -> Ok x | Error x -> Error (v691 x)
            let _v692 = v702 
            #endif
            let v703 : Result<std_string_String, std_string_String> = _v692 
            let v706 : (std_string_String -> US25) = method117()
            let v707 : (std_string_String -> US25) = method118()
            let v708 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v709 : US25 = Fable.Core.RustInterop.emitRustExpr struct (v706, v707, v703) v708 
            let v952 : std_string_String =
                match v709 with
                | US25_1(v859) -> (* Error *)
                    let v860 : unit = ()
                    let v861 : (unit -> unit) = closure51(v5, v859)
                    let v862 : unit = (fun () -> v861 (); v860) ()
                    let v902 : string = $"\u001b[4;7m{v859}\u001b[0m"
                    let v903 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v904 : string = "&*$0"
                    let v905 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v902 v904 
                    let _v903 = v905 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v906 : string = "&*$0"
                    let v907 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v902 v906 
                    let _v903 = v907 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v908 : string = "&*$0"
                    let v909 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v902 v908 
                    let _v903 = v909 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v910 : Ref<Str> = v902 |> unbox<Ref<Str>>
                    let _v903 = v910 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v913 : Ref<Str> = v902 |> unbox<Ref<Str>>
                    let _v903 = v913 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v916 : Ref<Str> = v902 |> unbox<Ref<Str>>
                    let _v903 = v916 
                    #endif
#else
                    let v919 : Ref<Str> = v902 |> unbox<Ref<Str>>
                    let _v903 = v919 
                    #endif
                    let v922 : Ref<Str> = _v903 
                    let v927 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v928 : string = "String::from($0)"
                    let v929 : std_string_String = Fable.Core.RustInterop.emitRustExpr v922 v928 
                    let _v927 = v929 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v930 : string = "String::from($0)"
                    let v931 : std_string_String = Fable.Core.RustInterop.emitRustExpr v922 v930 
                    let _v927 = v931 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v932 : string = "String::from($0)"
                    let v933 : std_string_String = Fable.Core.RustInterop.emitRustExpr v922 v932 
                    let _v927 = v933 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v934 : std_string_String = v922 |> unbox<std_string_String>
                    let _v927 = v934 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v937 : std_string_String = v922 |> unbox<std_string_String>
                    let _v927 = v937 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v940 : std_string_String = v922 |> unbox<std_string_String>
                    let _v927 = v940 
                    #endif
#else
                    let v943 : std_string_String = v922 |> unbox<std_string_String>
                    let _v927 = v943 
                    #endif
                    let v946 : std_string_String = _v927 
                    v946
                | US25_0(v710) -> (* Ok *)
                    let v711 : string = "fable_library_rust::String_::fromString($0)"
                    let v712 : string = Fable.Core.RustInterop.emitRustExpr v710 v711 
                    let v713 : string = "encoding_rs::UTF_8"
                    let v714 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v713 
                    let v715 : string = "$0.encode(&*$1).0"
                    let v716 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v714, v712) v715 
                    let v717 : string = "$0.as_ref()"
                    let v718 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v716 v717 
                    let v719 : string = "std::str::from_utf8($0)"
                    let v720 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr v718 v719 
                    let v721 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v722 : string = "$0.unwrap()"
                    let v723 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v720 v722 
                    let _v721 = v723 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v724 : string = "$0.unwrap()"
                    let v725 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v720 v724 
                    let _v721 = v725 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v726 : string = "$0.unwrap()"
                    let v727 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v720 v726 
                    let _v721 = v727 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v728 : Ref<Str> = match v720 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v721 = v728 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v729 : Ref<Str> = match v720 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v721 = v729 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v730 : Ref<Str> = match v720 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v721 = v730 
                    #endif
#else
                    let v731 : Ref<Str> = match v720 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v721 = v731 
                    #endif
                    let v732 : Ref<Str> = _v721 
                    let v735 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v736 : string = "String::from($0)"
                    let v737 : std_string_String = Fable.Core.RustInterop.emitRustExpr v732 v736 
                    let _v735 = v737 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v738 : string = "String::from($0)"
                    let v739 : std_string_String = Fable.Core.RustInterop.emitRustExpr v732 v738 
                    let _v735 = v739 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v740 : string = "String::from($0)"
                    let v741 : std_string_String = Fable.Core.RustInterop.emitRustExpr v732 v740 
                    let _v735 = v741 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v742 : std_string_String = v732 |> unbox<std_string_String>
                    let _v735 = v742 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v745 : std_string_String = v732 |> unbox<std_string_String>
                    let _v735 = v745 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v748 : std_string_String = v732 |> unbox<std_string_String>
                    let _v735 = v748 
                    #endif
#else
                    let v751 : std_string_String = v732 |> unbox<std_string_String>
                    let _v735 = v751 
                    #endif
                    let v754 : std_string_String = _v735 
                    let v759 : string = "fable_library_rust::String_::fromString($0)"
                    let v760 : string = Fable.Core.RustInterop.emitRustExpr v754 v759 
                    let v761 : string = $"! {v760}"
                    if v5 then
                        let v762 : unit = ()
                        let v763 : (unit -> unit) = closure52(v761)
                        let v764 : unit = (fun () -> v763 (); v762) ()
                        ()
                    else
                        let v806 : unit = ()
                        let v807 : (unit -> unit) = closure11(v761)
                        let v808 : unit = (fun () -> v807 (); v806) ()
                        ()
                    let v810 : string = $"\u001b[4;7m{v754}\u001b[0m"
                    let v811 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v812 : string = "&*$0"
                    let v813 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v810 v812 
                    let _v811 = v813 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v814 : string = "&*$0"
                    let v815 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v810 v814 
                    let _v811 = v815 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v816 : string = "&*$0"
                    let v817 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v810 v816 
                    let _v811 = v817 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v818 : Ref<Str> = v810 |> unbox<Ref<Str>>
                    let _v811 = v818 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v821 : Ref<Str> = v810 |> unbox<Ref<Str>>
                    let _v811 = v821 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v824 : Ref<Str> = v810 |> unbox<Ref<Str>>
                    let _v811 = v824 
                    #endif
#else
                    let v827 : Ref<Str> = v810 |> unbox<Ref<Str>>
                    let _v811 = v827 
                    #endif
                    let v830 : Ref<Str> = _v811 
                    let v835 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v836 : string = "String::from($0)"
                    let v837 : std_string_String = Fable.Core.RustInterop.emitRustExpr v830 v836 
                    let _v835 = v837 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v838 : string = "String::from($0)"
                    let v839 : std_string_String = Fable.Core.RustInterop.emitRustExpr v830 v838 
                    let _v835 = v839 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v840 : string = "String::from($0)"
                    let v841 : std_string_String = Fable.Core.RustInterop.emitRustExpr v830 v840 
                    let _v835 = v841 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v842 : std_string_String = v830 |> unbox<std_string_String>
                    let _v835 = v842 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v845 : std_string_String = v830 |> unbox<std_string_String>
                    let _v835 = v845 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v848 : std_string_String = v830 |> unbox<std_string_String>
                    let _v835 = v848 
                    #endif
#else
                    let v851 : std_string_String = v830 |> unbox<std_string_String>
                    let _v835 = v851 
                    #endif
                    let v854 : std_string_String = _v835 
                    v854
            let v953 : string = "$0"
            let v954 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v690 v953 
            let v955 : string = "v954.lock()"
            let v956 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v955 
            let v957 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v958 : string = "$0.unwrap()"
            let v959 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v956 v958 
            let _v957 = v959 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v960 : string = "$0.unwrap()"
            let v961 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v956 v960 
            let _v957 = v961 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v962 : string = "$0.unwrap()"
            let v963 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v956 v962 
            let _v957 = v963 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v964 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v956 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v957 = v964 
            #endif
#if FABLE_COMPILER_PYTHON
            let v965 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v956 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v957 = v965 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v966 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v956 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v957 = v966 
            #endif
#else
            let v967 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = match v956 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v957 = v967 
            #endif
            let v968 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = _v957 
            let v971 : string = "&$0"
            let v972 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v968 v971 
            let v973 : string = "$0.send($1)"
            let v974 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v972, v952) v973 
            let v975 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method124()
            let v976 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v977 : string = "$0.map_err(|x| $1(x))"
            let v978 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v974, v975) v977 
            let _v976 = v978 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v979 : string = "$0.map_err(|x| $1(x))"
            let v980 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v974, v975) v979 
            let _v976 = v980 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v981 : string = "$0.map_err(|x| $1(x))"
            let v982 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v974, v975) v981 
            let _v976 = v982 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v983 : Result<unit, std_string_String> = match v974 with Ok x -> Ok x | Error x -> Error (v975 x)
            let _v976 = v983 
            #endif
#if FABLE_COMPILER_PYTHON
            let v984 : Result<unit, std_string_String> = match v974 with Ok x -> Ok x | Error x -> Error (v975 x)
            let _v976 = v984 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v985 : Result<unit, std_string_String> = match v974 with Ok x -> Ok x | Error x -> Error (v975 x)
            let _v976 = v985 
            #endif
#else
            let v986 : Result<unit, std_string_String> = match v974 with Ok x -> Ok x | Error x -> Error (v975 x)
            let _v976 = v986 
            #endif
            let v987 : Result<unit, std_string_String> = _v976 
            let v990 : string = "$0"
            let v991 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v987 v990 
            let v992 : string = "true; $0 }); //"
            let v993 : bool = Fable.Core.RustInterop.emitRustExpr v991 v992 
            let v994 : string = "_iter_try_for_each.map_err(|x| x.into())"
            let v995 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v994 
            let v996 : Result<unit, string> = method125(v995)
            let v997 : string = v655 + v656 
            let v998 : _ = v996 
            let v999 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1000 : string = $"true; let v998 = $0"
            let v1001 : bool = Fable.Core.RustInterop.emitRustExpr v998 v1000 
            let _v999 = v1001 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1002 : string = $"true; let v998 = $0"
            let v1003 : bool = Fable.Core.RustInterop.emitRustExpr v998 v1002 
            let _v999 = v1003 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1004 : string = $"true; let v998 = $0"
            let v1005 : bool = Fable.Core.RustInterop.emitRustExpr v998 v1004 
            let _v999 = v1005 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1006 : bool = true
            let _v999 = v1006 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1007 : bool = true
            let _v999 = v1007 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1008 : bool = true
            let _v999 = v1008 
            #endif
#else
            let v1009 : bool = true
            let _v999 = v1009 
            #endif
            let v1010 : bool = _v999 
            let v1013 : string = $"true; v998 " + v997 + "); " + v655 + " // rust.fix_closure'"
            let v1014 : bool = Fable.Core.RustInterop.emitRustExpr () v1013 
            let v1015 : string = "__spawn"
            let v1016 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v1015 
            let v1017 : ((std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) -> US26) = method126()
            let v1018 : US26 option = v4 |> Option.map v1017 
            let v1029 : US26 = US26_1
            let v1030 : US26 = v1018 |> Option.defaultValue v1029 
            match v1030 with
            | US26_1 -> (* None *)
                ()
            | US26_0(v1034) -> (* Some *)
                let v1035 : string = "$0"
                let v1036 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v361 v1035 
                let v1037 : string = "v1036.lock()"
                let v1038 : Result<std_sync_MutexGuard<std_process_ChildStdin option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin option>>> = Fable.Core.RustInterop.emitRustExpr () v1037 
                let v1039 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1040 : string = "$0.unwrap()"
                let v1041 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1038 v1040 
                let _v1039 = v1041 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1042 : string = "$0.unwrap()"
                let v1043 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1038 v1042 
                let _v1039 = v1043 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1044 : string = "$0.unwrap()"
                let v1045 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v1038 v1044 
                let _v1039 = v1045 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1046 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1038 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _v1039 = v1046 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1047 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1038 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _v1039 = v1047 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v1048 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1038 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _v1039 = v1048 
                #endif
#else
                let v1049 : std_sync_MutexGuard<std_process_ChildStdin option> = match v1038 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                let _v1039 = v1049 
                #endif
                let v1050 : std_sync_MutexGuard<std_process_ChildStdin option> = _v1039 
                let v1053 : std_sync_MutexGuard<std_process_ChildStdin option> = method127(v1050)
                let v1054 : string = "true; let mut v1053 = v1053"
                let v1055 : bool = Fable.Core.RustInterop.emitRustExpr () v1054 
                let v1056 : string = "&mut $0"
                let v1057 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v1053 v1056 
                let v1058 : string = "Option::take($0)"
                let v1059 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v1057 v1058 
                let v1060 : string = "true; let _optionm_map_ = $0.map(|x| { //"
                let v1061 : bool = Fable.Core.RustInterop.emitRustExpr v1059 v1060 
                let v1062 : string = "x"
                let v1063 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr () v1062 
                let v1064 : string = "std::sync::Mutex::new(v1063)"
                let v1065 : std_sync_Mutex<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr () v1064 
                let v1066 : string = "std::sync::Arc::new(v1065)"
                let v1067 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr () v1066 
                let v1068 : string = "true; $0 })"
                let v1069 : bool = Fable.Core.RustInterop.emitRustExpr v1067 v1068 
                let v1070 : string = "_optionm_map_"
                let v1071 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> option = Fable.Core.RustInterop.emitRustExpr () v1070 
                let v1072 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> US27) = method128()
                let v1073 : US27 option = v1071 |> Option.map v1072 
                let v1084 : US27 = US27_1
                let v1085 : US27 = v1073 |> Option.defaultValue v1084 
                match v1085 with
                | US27_1 -> (* None *)
                    ()
                | US27_0(v1089) -> (* Some *)
                    v1034 v1089
                    let v1090 : string = "$0"
                    let v1091 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr v1089 v1090 
                    let v1092 : string = "v1091.lock()"
                    let v1093 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr () v1092 
                    let v1094 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1095 : string = "$0.unwrap()"
                    let v1096 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1093 v1095 
                    let _v1094 = v1096 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1097 : string = "$0.unwrap()"
                    let v1098 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1093 v1097 
                    let _v1094 = v1098 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1099 : string = "$0.unwrap()"
                    let v1100 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v1093 v1099 
                    let _v1094 = v1100 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1101 : std_sync_MutexGuard<std_process_ChildStdin> = match v1093 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v1094 = v1101 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1102 : std_sync_MutexGuard<std_process_ChildStdin> = match v1093 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v1094 = v1102 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1103 : std_sync_MutexGuard<std_process_ChildStdin> = match v1093 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v1094 = v1103 
                    #endif
#else
                    let v1104 : std_sync_MutexGuard<std_process_ChildStdin> = match v1093 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v1094 = v1104 
                    #endif
                    let v1105 : std_sync_MutexGuard<std_process_ChildStdin> = _v1094 
                    let v1108 : std_sync_MutexGuard<std_process_ChildStdin> = method129(v1105)
                    let v1109 : string = "true; let mut v1108 = v1108"
                    let v1110 : bool = Fable.Core.RustInterop.emitRustExpr () v1109 
                    let v1111 : string = "true; std::io::Write::flush(&mut *$0).unwrap()"
                    let v1112 : bool = Fable.Core.RustInterop.emitRustExpr v1108 v1111 
                    ()
            let v1113 : string = "$0"
            let v1114 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v235 v1113 
            let v1115 : string = "v1114.lock()"
            let v1116 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v1115 
            let v1117 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1118 : string = "$0.unwrap()"
            let v1119 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1116 v1118 
            let _v1117 = v1119 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1120 : string = "$0.unwrap()"
            let v1121 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1116 v1120 
            let _v1117 = v1121 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1122 : string = "$0.unwrap()"
            let v1123 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v1116 v1122 
            let _v1117 = v1123 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1124 : std_sync_MutexGuard<std_process_Child option> = match v1116 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v1117 = v1124 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1125 : std_sync_MutexGuard<std_process_Child option> = match v1116 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v1117 = v1125 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1126 : std_sync_MutexGuard<std_process_Child option> = match v1116 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v1117 = v1126 
            #endif
#else
            let v1127 : std_sync_MutexGuard<std_process_Child option> = match v1116 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v1117 = v1127 
            #endif
            let v1128 : std_sync_MutexGuard<std_process_Child option> = _v1117 
            let v1131 : std_sync_MutexGuard<std_process_Child option> = method112(v1128)
            let v1132 : string = "true; let mut v1131 = v1131"
            let v1133 : bool = Fable.Core.RustInterop.emitRustExpr () v1132 
            let v1134 : string = "&mut $0"
            let v1135 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v1131 v1134 
            let v1136 : string = "Option::take($0)"
            let v1137 : std_process_Child option = Fable.Core.RustInterop.emitRustExpr v1135 v1136 
            let v1138 : string = "$0.unwrap()"
            let v1139 : std_process_Child = Fable.Core.RustInterop.emitRustExpr v1137 v1138 
            let v1140 : string = "$0.wait_with_output()"
            let v1141 : Result<std_process_Output, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1139 v1140 
            let v1142 : (std_io_Error -> std_string_String) = method65()
            let v1143 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1144 : string = "$0.map_err(|x| $1(x))"
            let v1145 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1141, v1142) v1144 
            let _v1143 = v1145 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1146 : string = "$0.map_err(|x| $1(x))"
            let v1147 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1141, v1142) v1146 
            let _v1143 = v1147 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1148 : string = "$0.map_err(|x| $1(x))"
            let v1149 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1141, v1142) v1148 
            let _v1143 = v1149 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1150 : Result<std_process_Output, std_string_String> = match v1141 with Ok x -> Ok x | Error x -> Error (v1142 x)
            let _v1143 = v1150 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1151 : Result<std_process_Output, std_string_String> = match v1141 with Ok x -> Ok x | Error x -> Error (v1142 x)
            let _v1143 = v1151 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1152 : Result<std_process_Output, std_string_String> = match v1141 with Ok x -> Ok x | Error x -> Error (v1142 x)
            let _v1143 = v1152 
            #endif
#else
            let v1153 : Result<std_process_Output, std_string_String> = match v1141 with Ok x -> Ok x | Error x -> Error (v1142 x)
            let _v1143 = v1153 
            #endif
            let v1154 : Result<std_process_Output, std_string_String> = _v1143 
            let v1157 : std_thread_JoinHandle<Result<unit, string>> = method130(v1016)
            let v1158 : string = "v1157"
            let v1159 : string = v1158 + v655 
            let v1160 : string = v1159 + v655 
            let v1161 : std_thread_JoinHandle<Result<unit, string>> = method130(v676)
            let v1162 : string = "v1161"
            let v1163 : string = ", "
            let v1164 : string = v1162 + v1163 
            let v1165 : string = v1164 + v1160 
            let v1166 : string = "vec![" + v1165 + "]"
            let v1167 : Vec<std_thread_JoinHandle<Result<unit, string>>> = Fable.Core.RustInterop.emitRustExpr () v1166 
            let v1168 : string = "true; $0.into_iter().for_each(|x| { //"
            let v1169 : bool = Fable.Core.RustInterop.emitRustExpr v1167 v1168 
            let v1170 : string = "x"
            let v1171 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v1170 
            let v1172 : string = "std::thread::JoinHandle::join($0)"
            let v1173 : Result<Result<unit, string>, Box<LifetimeRef<Dyn<LifetimeJoin<core_any_Any, LifetimeRef<LifetimeJoin<StaticLifetime, Send<StaticLifetime>>>>>>>> = Fable.Core.RustInterop.emitRustExpr v1171 v1172 
            let v1174 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1175 : string = "$0.unwrap()"
            let v1176 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1173 v1175 
            let _v1174 = v1176 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1177 : string = "$0.unwrap()"
            let v1178 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1173 v1177 
            let _v1174 = v1178 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1179 : string = "$0.unwrap()"
            let v1180 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v1173 v1179 
            let _v1174 = v1180 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1181 : Result<unit, string> = match v1173 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v1174 = v1181 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1182 : Result<unit, string> = match v1173 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v1174 = v1182 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1183 : Result<unit, string> = match v1173 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v1174 = v1183 
            #endif
#else
            let v1184 : Result<unit, string> = match v1173 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v1174 = v1184 
            #endif
            let v1185 : Result<unit, string> = _v1174 
            let v1188 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1189 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1185 v1189 
            let _v1188 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1190 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1185 v1190 
            let _v1188 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1191 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v1185 v1191 
            let _v1188 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            match v1185 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v1188 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            match v1185 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v1188 = () 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            match v1185 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v1188 = () 
            #endif
#else
            match v1185 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v1188 = () 
            #endif
            _v1188 
            let v1192 : string = $"true"
            let v1193 : bool = Fable.Core.RustInterop.emitRustExpr () v1192 
            let v1194 : string = "true; }}); { //"
            let v1195 : bool = Fable.Core.RustInterop.emitRustExpr () v1194 
            let v1196 : (std_process_Output -> US28) = method131()
            let v1197 : (std_string_String -> US28) = method132()
            let v1198 : US28 = match v1154 with Ok x -> v1196 x | Error x -> v1197 x
            match v1198 with
            | US28_1(v1281) -> (* Error *)
                let v1282 : unit = ()
                let v1283 : (unit -> unit) = closure58(v1281)
                let v1284 : unit = (fun () -> v1283 (); v1282) ()
                let v1324 : US6 = US6_0(v1281)
                let v1325 : US24 = US24_1
                struct (-2, v1324, v1325)
            | US28_0(v1199) -> (* Ok *)
                let v1200 : string = "$0.status"
                let v1201 : std_process_ExitStatus = Fable.Core.RustInterop.emitRustExpr v1199 v1200 
                let v1202 : string = "$0.code()"
                let v1203 : int32 option = Fable.Core.RustInterop.emitRustExpr v1201 v1202 
                let v1204 : (int32 -> US29) = method134()
                let v1205 : US29 option = v1203 |> Option.map v1204 
                let v1216 : US29 = US29_1
                let v1217 : US29 = v1205 |> Option.defaultValue v1216 
                match v1217 with
                | US29_1 -> (* None *)
                    let v1224 : string = "runtime.execute_with_options / exit_code=None"
                    let v1225 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1226 : string = "&*$0"
                    let v1227 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1224 v1226 
                    let _v1225 = v1227 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1228 : string = "&*$0"
                    let v1229 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1224 v1228 
                    let _v1225 = v1229 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1230 : string = "&*$0"
                    let v1231 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1224 v1230 
                    let _v1225 = v1231 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1232 : Ref<Str> = v1224 |> unbox<Ref<Str>>
                    let _v1225 = v1232 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1235 : Ref<Str> = v1224 |> unbox<Ref<Str>>
                    let _v1225 = v1235 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1238 : Ref<Str> = v1224 |> unbox<Ref<Str>>
                    let _v1225 = v1238 
                    #endif
#else
                    let v1241 : Ref<Str> = v1224 |> unbox<Ref<Str>>
                    let _v1225 = v1241 
                    #endif
                    let v1244 : Ref<Str> = _v1225 
                    let v1249 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1250 : string = "String::from($0)"
                    let v1251 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1244 v1250 
                    let _v1249 = v1251 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1252 : string = "String::from($0)"
                    let v1253 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1244 v1252 
                    let _v1249 = v1253 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1254 : string = "String::from($0)"
                    let v1255 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1244 v1254 
                    let _v1249 = v1255 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1256 : std_string_String = v1244 |> unbox<std_string_String>
                    let _v1249 = v1256 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1259 : std_string_String = v1244 |> unbox<std_string_String>
                    let _v1249 = v1259 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1262 : std_string_String = v1244 |> unbox<std_string_String>
                    let _v1249 = v1262 
                    #endif
#else
                    let v1265 : std_string_String = v1244 |> unbox<std_string_String>
                    let _v1249 = v1265 
                    #endif
                    let v1268 : std_string_String = _v1249 
                    let v1273 : US6 = US6_0(v1268)
                    let v1274 : US24 = US24_0(v382)
                    struct (-1, v1273, v1274)
                | US29_0(v1221) -> (* Some *)
                    let v1222 : US6 = US6_1
                    let v1223 : US24 = US24_0(v382)
                    struct (v1221, v1222, v1223)
    let v1389 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option =
        match v1382 with
        | US24_1 -> (* None *)
            let v1387 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = None
            v1387
        | US24_0(v1383) -> (* Some *)
            let v1384 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = Some v1383 
            v1384
    let v1390 : string = "true; let _optionm_map_ = $0.map(|x| { //"
    let v1391 : bool = Fable.Core.RustInterop.emitRustExpr v1389 v1390 
    let v1392 : string = "x"
    let v1393 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v1392 
    let v1394 : string = "$0"
    let v1395 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr v1393 v1394 
    let v1396 : string = "v1395.lock()"
    let v1397 : Result<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v1396 
    let v1398 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1399 : string = "$0.unwrap()"
    let v1400 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v1397 v1399 
    let _v1398 = v1400 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1401 : string = "$0.unwrap()"
    let v1402 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v1397 v1401 
    let _v1398 = v1402 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1403 : string = "$0.unwrap()"
    let v1404 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v1397 v1403 
    let _v1398 = v1404 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1405 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1397 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v1398 = v1405 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1406 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1397 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v1398 = v1406 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1407 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1397 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v1398 = v1407 
    #endif
#else
    let v1408 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = match v1397 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v1398 = v1408 
    #endif
    let v1409 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = _v1398 
    let v1412 : string = "$0.iter()"
    let v1413 : _ = Fable.Core.RustInterop.emitRustExpr v1409 v1412 
    let v1414 : string = "$0.collect::<Vec<_>>()"
    let v1415 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr v1413 v1414 
    let v1416 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v1417 : bool = Fable.Core.RustInterop.emitRustExpr v1415 v1416 
    let v1418 : string = "x"
    let v1419 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1418 
    let v1420 : string = "fable_library_rust::String_::fromString($0)"
    let v1421 : string = Fable.Core.RustInterop.emitRustExpr v1419 v1420 
    let v1422 : string = "true; $0 }).collect::<Vec<_>>()"
    let v1423 : bool = Fable.Core.RustInterop.emitRustExpr v1421 v1422 
    let v1424 : string = "_vec_map"
    let v1425 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v1424 
    let v1426 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v1427 : (string []) = Fable.Core.RustInterop.emitRustExpr v1425 v1426 
    let v1428 : string seq = v1427 |> Seq.ofArray
    let v1431 : string = method135()
    let v1432 : (string -> (string seq -> string)) = String.concat
    let v1433 : (string seq -> string) = v1432 v1431
    let v1434 : string = v1433 v1428
    let v1438 : string = "true; $0 })"
    let v1439 : bool = Fable.Core.RustInterop.emitRustExpr v1434 v1438 
    let v1440 : string = "_optionm_map_"
    let v1441 : string option = Fable.Core.RustInterop.emitRustExpr () v1440 
    let v1448 : US5 =
        match v1381 with
        | US6_1 -> (* None *)
            US5_1
        | US6_0(v1442) -> (* Some *)
            let v1443 : string = "fable_library_rust::String_::fromString($0)"
            let v1444 : string = Fable.Core.RustInterop.emitRustExpr v1442 v1443 
            US5_0(v1444)
    let v1452 : string =
        match v1448 with
        | US5_1 -> (* None *)
            let v1450 : string = ""
            v1450
        | US5_0(v1449) -> (* Some *)
            v1449
    let v1453 : string = v1441 |> Option.defaultValue v1452 
    let v1456 : unit = ()
    let v1457 : (unit -> unit) = closure60(v1380, v1453)
    let v1458 : unit = (fun () -> v1457 (); v1456) ()
    let v1499 : (int32 * string) = v1380, v1453 
    v1499 
    )
    |> fun x -> x ()
    ) () )
    |> fun x -> _v138 <- Some x
    let v1500 : (int32 * string) = match _v138 with Some x -> x | None -> failwith "base.capture / _v138=None"
    let (a, b) = v1500 
    let v2861 : int32 = a
    let v2862 : string = b
    let _v7 = struct (v2861, v2862) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v2867 : int32, v2868 : string) = null |> unbox<struct (int32 * string)>
    let _v7 = struct (v2867, v2868) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v2873 : int32, v2874 : string) = null |> unbox<struct (int32 * string)>
    let _v7 = struct (v2873, v2874) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v2879 : int32, v2880 : string) = null |> unbox<struct (int32 * string)>
    let _v7 = struct (v2879, v2880) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v2885 : int32, v2886 : string) = null |> unbox<struct (int32 * string)>
    let _v7 = struct (v2885, v2886) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v2891 : int32, v2892 : string) = null |> unbox<struct (int32 * string)>
    let _v7 = struct (v2891, v2892) 
    #endif
#else
    let v2897 : Async<struct (int32 * string)> = method138(v0, v1, v2, v3, v4, v5, v6)
    let v2898 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v2899 : int32, v2900 : string) = null |> unbox<struct (int32 * string)>
    let _v2898 = struct (v2899, v2900) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v2905 : int32, v2906 : string) = null |> unbox<struct (int32 * string)>
    let _v2898 = struct (v2905, v2906) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v2911 : int32, v2912 : string) = null |> unbox<struct (int32 * string)>
    let _v2898 = struct (v2911, v2912) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v2917 : int32, v2918 : string) = null |> unbox<struct (int32 * string)>
    let _v2898 = struct (v2917, v2918) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2923 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v2924 : int32, v2925 : string) = v2923 v2897
    let _v2898 = struct (v2924, v2925) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v2926 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v2927 : int32, v2928 : string) = v2926 v2897
    let _v2898 = struct (v2927, v2928) 
    #endif
#else
    let v2929 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v2930 : int32, v2931 : string) = v2929 v2897
    let _v2898 = struct (v2930, v2931) 
    #endif
    let struct (v2932 : int32, v2933 : string) = _v2898 
    let _v7 = struct (v2932, v2933) 
    #endif
    let struct (v2942 : int32, v2943 : string) = _v7 
    struct (v2942, v2943)
and method148 (v0 : string, v1 : string, v2 : string) : struct (string * string) =
    let v3 : string = method47(v1)
    let v4 : string = method25(v2, v3)
    let v5 : string = "."
    let v6 : int32 = v1.LastIndexOf v5 
    let v7 : int32 = v6 - 1
    let v8 : string = v1.[int 0..int v7]
    let v12 : int32 = v4.LastIndexOf v5 
    let v13 : int32 = v12 - 1
    let v14 : string = v4.[int 0..int v13]
    let v18 : string = ".md"
    let v19 : bool = v0.EndsWith v18 
    let v20 : bool = v19 = false
    let v23 : string =
        if v20 then
            let v21 : string = $"{v1}.{v0}"
            v21
        else
            let v22 : string = $"{v8}.{v0}"
            v22
    let v26 : string =
        if v20 then
            let v24 : string = $"{v4}.{v0}"
            v24
        else
            let v25 : string = $"{v14}.{v0}"
            v25
    struct (v23, v26)
and method149 () : string =
    let v0 : string = ""
    v0
and closure70 () (v0 : string) : US33 =
    US33_0(v0)
and method150 () : (string -> US33) =
    closure70()
and closure71 () (v0 : std_string_String) : US33 =
    US33_1(v0)
and method151 () : (std_string_String -> US33) =
    closure71()
and method152 (v0 : string) : bool =
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
and method154 (v0 : string, v1 : string, v2 : string, v3 : int32, v4 : string, v5 : int32, v6 : string, v7 : string, v8 : US5, v9 : string, v10 : string) : string =
    let v11 : string = method13()
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
and method153 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : string, v11 : string, v12 : int32, v13 : string, v14 : int32, v15 : string, v16 : string, v17 : US5, v18 : string, v19 : string) : string =
    let v20 : string = method154(v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19)
    let v21 : int64 = v0.l0
    let v22 : string = $"{v6} {v7} #{v21} %s{v8} / {v20}"
    method17(v22)
and closure72 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : int32, v5 : string, v6 : string, v7 : int32, v8 : string, v9 : string, v10 : US5) () : unit =
    let v11 : US0 = US0_2
    let v12 : bool = method6(v11)
    if v12 then
        let v13 : unit = ()
        let v14 : (unit -> unit) = closure6()
        let v15 : unit = (fun () -> v14 (); v13) ()
        let struct (v29 : Mut0, v30 : Mut1, v31 : Mut2, v32 : Mut3, v33 : Mut4, v34 : int64 option) = TraceState.trace_state.Value
        let v47 : string = method7(v29, v30, v31, v32, v33, v34)
        let v48 : string = method11()
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
                method153(v29, v30, v31, v32, v33, v34, v47, v48, v53, v1, v2, v0, v4, v3, v7, v6, v9, v10, v5, v8)
        method18(v57)
and method156 (v0 : string) : string =
    v0
and closure73 () (v0 : uint64) : US34 =
    US34_0(v0)
and method157 () : (uint64 -> US34) =
    closure73()
and closure74 () (v0 : std_string_String) : US34 =
    US34_1(v0)
and method158 () : (std_string_String -> US34) =
    closure74()
and method160 (v0 : string, v1 : string, v2 : std_string_String) : string =
    let v3 : string = method13()
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
and method159 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : std_string_String) : string =
    let v11 : string = method160(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "file_system.file_copy"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method17(v14)
and closure75 (v0 : string, v1 : string, v2 : std_string_String) () : unit =
    let v3 : US0 = US0_3
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method7(v21, v22, v23, v24, v25, v26)
        let v40 : string = method33()
        let v41 : string = method159(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method18(v41)
and method162 (v0 : string, v1 : string, v2 : uint64) : string =
    let v3 : string = method13()
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
and method161 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string, v10 : uint64) : string =
    let v11 : string = method162(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "file_system.file_copy"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method17(v14)
and closure76 (v0 : string, v1 : string, v2 : uint64) () : unit =
    let v3 : US0 = US0_1
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method7(v21, v22, v23, v24, v25, v26)
        let v40 : string = method61()
        let v41 : string = method161(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method18(v41)
and method155 (v0 : string, v1 : string) : unit =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method156(v0)
    let v4 : string = "std::fs::copy(&*$0, &*v3)"
    let v5 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1 v4 
    let v6 : (std_io_Error -> std_string_String) = method65()
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "$0.map_err(|x| $1(x))"
    let v9 : Result<uint64, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v5, v6) v8 
    let _v7 = v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : string = "$0.map_err(|x| $1(x))"
    let v11 : Result<uint64, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v5, v6) v10 
    let _v7 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = "$0.map_err(|x| $1(x))"
    let v13 : Result<uint64, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v5, v6) v12 
    let _v7 = v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : Result<uint64, std_string_String> = match v5 with Ok x -> Ok x | Error x -> Error (v6 x)
    let _v7 = v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : Result<uint64, std_string_String> = match v5 with Ok x -> Ok x | Error x -> Error (v6 x)
    let _v7 = v15 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v16 : Result<uint64, std_string_String> = match v5 with Ok x -> Ok x | Error x -> Error (v6 x)
    let _v7 = v16 
    #endif
#else
    let v17 : Result<uint64, std_string_String> = match v5 with Ok x -> Ok x | Error x -> Error (v6 x)
    let _v7 = v17 
    #endif
    let v18 : Result<uint64, std_string_String> = _v7 
    let v21 : (uint64 -> US34) = method157()
    let v22 : (std_string_String -> US34) = method158()
    let v23 : US34 = match v18 with Ok x -> v21 x | Error x -> v22 x
    match v23 with
    | US34_1(v67) -> (* Error *)
        let v68 : unit = ()
        let v69 : (unit -> unit) = closure75(v1, v3, v67)
        let v70 : unit = (fun () -> v69 (); v68) ()
        ()
    | US34_0(v24) -> (* Ok *)
        let v25 : unit = ()
        let v26 : (unit -> unit) = closure76(v1, v3, v24)
        let v27 : unit = (fun () -> v26 (); v25) ()
        ()
    let _v2 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let _v2 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let _v2 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _v2 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    let _v2 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _v2 = () 
    #endif
#else
    System.IO.File.Copy (v1, v0, true)
    let _v2 = () 
    #endif
    _v2 
    ()
and method164 (v0 : Vec<uint8>) : Vec<uint8> =
    v0
and method165 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method166 (v0 : string) : string =
    v0
and method167 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure79 (v0 : string) (v1 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : unit =
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
    let v20 : string = method166(v0)
    let v21 : string = "v20.as_bytes()"
    let v22 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v21 
    let v23 : std_sync_MutexGuard<std_process_ChildStdin> = method167(v17)
    let v24 : string = "true; let mut v23 = v23"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = "true; std::io::Write::write_all(&mut *$0, v22).unwrap()"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr v23 v26 
    ()
and method168 (v0 : int32, v1 : Mut8) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method169 (v0 : string) : string =
    v0
and method171 (v0 : int32, v1 : int32, v2 : string) : string =
    let v3 : string = method13()
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
and method170 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32, v10 : string) : string =
    let v11 : string = method171(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "documents.hangul"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method17(v14)
and closure80 (v0 : string, v1 : int32, v2 : string) () : unit =
    let v3 : US0 = US0_2
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method7(v21, v22, v23, v24, v25, v26)
        let v40 : string = method11()
        let v41 : int32 = v2.Length
        let v42 : string = method170(v21, v22, v23, v24, v25, v26, v39, v40, v1, v41, v0)
        method18(v42)
and method163 (v0 : string, v1 : string, v2 : string, v3 : string) : US35 =
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
    let v45 : Vec<uint8> = method164(v40)
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
    while method58(v89, v91) do
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
    while method165(v100, v102) do
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
    while method58(v114, v116) do
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
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v122 : string seq = _v121 
    let v128 : string = method135()
    let v129 : (string -> (string seq -> string)) = String.concat
    let v130 : (string seq -> string) = v129 v128
    let v131 : string = v130 v122
    let v134 : string = $"{v131}

"
    let v135 : System.Threading.CancellationToken option = None
    let v136 : (struct (string * string) []) = [||]
    let v137 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v138 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v139 : string option = None
    let v140 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v141 : string = "cfg!(windows)"
    let v142 : bool = Fable.Core.RustInterop.emitRustExpr () v141 
    let _v140 = v142 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v143 : string = "cfg!(windows)"
    let v144 : bool = Fable.Core.RustInterop.emitRustExpr () v143 
    let _v140 = v144 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v145 : string = "cfg!(windows)"
    let v146 : bool = Fable.Core.RustInterop.emitRustExpr () v145 
    let _v140 = v146 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v147 : US3 = US3_0
    let v148 : US4 = US4_3(v147)
    let v149 : string = $"platform.is_windows / target: {v148}"
    let v150 : bool = failwith<bool> v149
    let _v140 = v150 
    #endif
#if FABLE_COMPILER_PYTHON
    let v151 : US3 = US3_0
    let v152 : US4 = US4_4(v151)
    let v153 : string = $"platform.is_windows / target: {v152}"
    let v154 : bool = failwith<bool> v153
    let _v140 = v154 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v155 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v156 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v157 : bool = v156 v155
    let _v140 = v157 
    #endif
#else
    let v158 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v159 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v160 : bool = v159 v158
    let _v140 = v160 
    #endif
    let v161 : bool = _v140 
    let v169 : string =
        if v161 then
            let v167 : string = ".exe"
            v167
        else
            let v168 : string = ""
            v168
    let v170 : string = $"../vault/deps/hangulize/cmd/hangulize/hangulize{v169}"
    let v171 : string = method25(v0, v170)
    let v172 : string = $"{v171} {v1}"
    let v173 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = closure79(v134)
    let v174 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = Some v173 
    let v177 : bool = true
    let struct (v178 : int32, v179 : string) = method82(v172, v135, v136, v137, v174, v177, v139)
    let v180 : (string []) = v179.Split v85 
    let v183 : int32 = v180.Length
    let v184 : string = ""
    let v185 : Mut8 = {l0 = 0; l1 = v184; l2 = 0; l3 = 0} : Mut8
    while method168(v100, v185) do
        let v187 : int32 = v185.l0
        let struct (v188 : string, v189 : int32, v190 : int32) = v185.l1, v185.l2, v185.l3
        let v191 : string = v90.[int v187]
        let v192 : bool = v191 = ""
        let struct (v208 : string, v209 : int32, v210 : int32) =
            if v192 then
                let v193 : string = $"{v188}
"
                let v194 : int32 = v189 + 1
                let v195 : int32 = v190 + 1
                struct (v193, v194, v195)
            else
                let v196 : int32 = v189 - v190
                let v197 : bool = v196 >= v183
                let v206 : string =
                    if v197 then
                        v188
                    else
                        let v198 : string = v180.[int v196]
                        let v201 : int32 = v183 - 1
                        let v202 : bool = v196 = v201
                        if v202 then
                            let v203 : string = $"{v188}{v198}"
                            v203
                        else
                            let v204 : string = $"{v188}{v198}
"
                            v204
                let v207 : int32 = v189 + 1
                struct (v206, v207, v190)
        let v211 : int32 = v187 + 1
        v185.l0 <- v211
        v185.l1 <- v208
        v185.l2 <- v209
        v185.l3 <- v210
        ()
    let struct (v212 : string, v213 : int32, v214 : int32) = v185.l1, v185.l2, v185.l3
    let v215 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v216 : string = "std::fs::write(&*$0, &*$1).unwrap()"
    Fable.Core.RustInterop.emitRustExpr struct (v2, v212) v216 
    let _v215 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let _v215 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let _v215 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _v215 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    let _v215 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _v215 = () 
    #endif
#else
    let v217 : string = method169(v212)
    System.IO.File.WriteAllText (v2, v217)
    let _v215 = () 
    #endif
    _v215 
    let v218 : unit = ()
    let v219 : (unit -> unit) = closure80(v2, v178, v212)
    let v220 : unit = (fun () -> v219 (); v218) ()
    US35_0(v178, v212)
and method173 (v0 : int32, v1 : string) : string =
    let v2 : string = method13()
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
and method172 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method173(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "documents.files_fn / error"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method17(v13)
and closure81 (v0 : string, v1 : int32) () : unit =
    let v2 : US0 = US0_2
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method7(v20, v21, v22, v23, v24, v25)
        let v39 : string = method11()
        let v40 : string = method172(v20, v21, v22, v23, v24, v25, v38, v39, v1, v0)
        method18(v40)
and closure78 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : US32 =
    let struct (v6 : string, v7 : string) = method148(v5, v4, v0)
    let v8 : bool = method152(v6)
    let v9 : bool = v8 = false
    let v12 : bool =
        if v9 then
            true
        else
            let v10 : bool = method152(v7)
            let v11 : bool = v10 = false
            v11
    let v314 : bool =
        if v12 then
            false
        else
            let v13 : string = method38(v6)
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
            let v71 : string = "v45.len()"
            let v72 : unativeint = Fable.Core.RustInterop.emitRustExpr () v71 
            let v73 : uint8 = v72 |> uint8 
            let v76 : unativeint = v63 |> unativeint 
            let v79 : unativeint = v76 |> unbox<unativeint>
            let v82 : bool = v79 = v72 
            let v89 : Ref<Slice'<uint8>> =
                if v82 then
                    let v85 : string = "&v45[v41..]"
                    let v86 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v85 
                    v86
                else
                    let v87 : string = "&v45[$0..$1]"
                    let v88 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v41, v76) v87 
                    v88
            let v90 : string = "sha2::Digest::update(&mut v38, v89)"
            Fable.Core.RustInterop.emitRustExpr () v90 
            let v91 : string = "true; } // rust.loop"
            let v92 : bool = Fable.Core.RustInterop.emitRustExpr () v91 
            let v93 : string = "true; } // rust.loop"
            let v94 : bool = Fable.Core.RustInterop.emitRustExpr () v93 
            let v95 : string = "true; } // rust.loop"
            let v96 : bool = Fable.Core.RustInterop.emitRustExpr () v95 
            let v97 : string = "true; { // rust.loop"
            let v98 : bool = Fable.Core.RustInterop.emitRustExpr () v97 
            let v99 : string = "true; { // rust.loop"
            let v100 : bool = Fable.Core.RustInterop.emitRustExpr () v99 
            let v101 : string = "&sha2::Digest::finalize(v38)"
            let v102 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v101 
            let v103 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v104 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v102 v103 
            let v105 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v106 : bool = Fable.Core.RustInterop.emitRustExpr v104 v105 
            let v107 : string = "x"
            let v108 : uint8 = Fable.Core.RustInterop.emitRustExpr () v107 
            let v109 : string = "format!(\"{:02x}\", $0)"
            let v110 : std_string_String = Fable.Core.RustInterop.emitRustExpr v108 v109 
            let v111 : string = "fable_library_rust::String_::fromString($0)"
            let v112 : string = Fable.Core.RustInterop.emitRustExpr v110 v111 
            let v113 : string = "true; $0 }).collect::<Vec<_>>()"
            let v114 : bool = Fable.Core.RustInterop.emitRustExpr v112 v113 
            let v115 : string = "_vec_map"
            let v116 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v115 
            let v117 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v118 : (string []) = Fable.Core.RustInterop.emitRustExpr v116 v117 
            let v119 : unit = ()
            let _v119 =
                seq {
                    for i = 0 to v118.Length - 1 do yield v118.[i]
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v120 : string seq = _v119 
            let v126 : string = method149()
            let v127 : bool = v126 = "\n"
            let v129 : string =
                if v127 then
                    method60(v126)
                else
                    v126
            let v130 : (string -> (string seq -> string)) = String.concat
            let v131 : (string seq -> string) = v130 v129
            let v132 : string = v131 v120
            let v135 : Result<string, std_io_Error> = Ok v132 
            let v136 : (std_io_Error -> std_string_String) = method65()
            let v137 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v138 : string = "$0.map_err(|x| $1(x))"
            let v139 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v135, v136) v138 
            let _v137 = v139 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v140 : string = "$0.map_err(|x| $1(x))"
            let v141 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v135, v136) v140 
            let _v137 = v141 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v142 : string = "$0.map_err(|x| $1(x))"
            let v143 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v135, v136) v142 
            let _v137 = v143 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v144 : Result<string, std_string_String> = match v135 with Ok x -> Ok x | Error x -> Error (v136 x)
            let _v137 = v144 
            #endif
#if FABLE_COMPILER_PYTHON
            let v145 : Result<string, std_string_String> = match v135 with Ok x -> Ok x | Error x -> Error (v136 x)
            let _v137 = v145 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v146 : Result<string, std_string_String> = match v135 with Ok x -> Ok x | Error x -> Error (v136 x)
            let _v137 = v146 
            #endif
#else
            let v147 : Result<string, std_string_String> = match v135 with Ok x -> Ok x | Error x -> Error (v136 x)
            let _v137 = v147 
            #endif
            let v148 : Result<string, std_string_String> = _v137 
            let v151 : (string -> US33) = method150()
            let v152 : (std_string_String -> US33) = method151()
            let v153 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v154 : US33 = Fable.Core.RustInterop.emitRustExpr struct (v151, v152, v148) v153 
            let v162 : string =
                match v154 with
                | US33_1(v156) -> (* Error *)
                    let v157 : string = $"resultm.get / Result value was Error: {v156}"
                    failwith<string> v157
                | US33_0(v155) -> (* Ok *)
                    v155
            let v163 : string = method38(v7)
            let v164 : string = "std::fs::File::open(&*v163)"
            let v165 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v164 
            let v166 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v167 : string = "$0.unwrap()"
            let v168 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v165 v167 
            let _v166 = v168 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v169 : string = "$0.unwrap()"
            let v170 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v165 v169 
            let _v166 = v170 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v171 : string = "$0.unwrap()"
            let v172 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v165 v171 
            let _v166 = v172 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v173 : std_fs_File = match v165 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v166 = v173 
            #endif
#if FABLE_COMPILER_PYTHON
            let v174 : std_fs_File = match v165 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v166 = v174 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v175 : std_fs_File = match v165 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v166 = v175 
            #endif
#else
            let v176 : std_fs_File = match v165 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v166 = v176 
            #endif
            let v177 : std_fs_File = _v166 
            let v180 : string = "std::io::BufReader::new($0)"
            let v181 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v177 v180 
            let v182 : string = "std::io::BufReader::new($0)"
            let v183 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v181 v182 
            let v184 : string = "true; let mut v183 = v183"
            let v185 : bool = Fable.Core.RustInterop.emitRustExpr () v184 
            let v186 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v186 
            let v187 : string = "result"
            let v188 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v187 
            let v189 : string = "true; let mut v188 = v188"
            let v190 : bool = Fable.Core.RustInterop.emitRustExpr () v189 
            let v191 : unativeint = 0 |> unativeint 
            let v194 : string = "[$0; 1024]"
            let v195 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v194 
            let v196 : string = "true; loop { // rust.loop"
            let v197 : bool = Fable.Core.RustInterop.emitRustExpr () v196 
            let v198 : string = "true; let mut v195 = v195"
            let v199 : bool = Fable.Core.RustInterop.emitRustExpr () v198 
            let v200 : string = "std::io::Read::read(&mut v183, &mut v195)"
            let v201 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v200 
            let v202 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v203 : string = "$0.unwrap()"
            let v204 : unativeint = Fable.Core.RustInterop.emitRustExpr v201 v203 
            let _v202 = v204 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v205 : string = "$0.unwrap()"
            let v206 : unativeint = Fable.Core.RustInterop.emitRustExpr v201 v205 
            let _v202 = v206 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v207 : string = "$0.unwrap()"
            let v208 : unativeint = Fable.Core.RustInterop.emitRustExpr v201 v207 
            let _v202 = v208 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v209 : unativeint = match v201 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v202 = v209 
            #endif
#if FABLE_COMPILER_PYTHON
            let v210 : unativeint = match v201 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v202 = v210 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v211 : unativeint = match v201 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v202 = v211 
            #endif
#else
            let v212 : unativeint = match v201 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v202 = v212 
            #endif
            let v213 : unativeint = _v202 
            let v216 : bool = v213 = v191 
            if v216 then
                let v219 : string = "true; break"
                let v220 : bool = Fable.Core.RustInterop.emitRustExpr () v219 
                ()
            let v221 : string = "v195.len()"
            let v222 : unativeint = Fable.Core.RustInterop.emitRustExpr () v221 
            let v223 : uint8 = v222 |> uint8 
            let v226 : unativeint = v213 |> unativeint 
            let v229 : unativeint = v226 |> unbox<unativeint>
            let v232 : bool = v229 = v222 
            let v239 : Ref<Slice'<uint8>> =
                if v232 then
                    let v235 : string = "&v195[v191..]"
                    let v236 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v235 
                    v236
                else
                    let v237 : string = "&v195[$0..$1]"
                    let v238 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v191, v226) v237 
                    v238
            let v240 : string = "sha2::Digest::update(&mut v188, v239)"
            Fable.Core.RustInterop.emitRustExpr () v240 
            let v241 : string = "true; } // rust.loop"
            let v242 : bool = Fable.Core.RustInterop.emitRustExpr () v241 
            let v243 : string = "true; } // rust.loop"
            let v244 : bool = Fable.Core.RustInterop.emitRustExpr () v243 
            let v245 : string = "true; } // rust.loop"
            let v246 : bool = Fable.Core.RustInterop.emitRustExpr () v245 
            let v247 : string = "true; { // rust.loop"
            let v248 : bool = Fable.Core.RustInterop.emitRustExpr () v247 
            let v249 : string = "true; { // rust.loop"
            let v250 : bool = Fable.Core.RustInterop.emitRustExpr () v249 
            let v251 : string = "&sha2::Digest::finalize(v188)"
            let v252 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v251 
            let v253 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v254 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v252 v253 
            let v255 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v256 : bool = Fable.Core.RustInterop.emitRustExpr v254 v255 
            let v257 : string = "x"
            let v258 : uint8 = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "format!(\"{:02x}\", $0)"
            let v260 : std_string_String = Fable.Core.RustInterop.emitRustExpr v258 v259 
            let v261 : string = "fable_library_rust::String_::fromString($0)"
            let v262 : string = Fable.Core.RustInterop.emitRustExpr v260 v261 
            let v263 : string = "true; $0 }).collect::<Vec<_>>()"
            let v264 : bool = Fable.Core.RustInterop.emitRustExpr v262 v263 
            let v265 : string = "_vec_map"
            let v266 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v265 
            let v267 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v268 : (string []) = Fable.Core.RustInterop.emitRustExpr v266 v267 
            let v269 : unit = ()
            let _v269 =
                seq {
                    for i = 0 to v268.Length - 1 do yield v268.[i]
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v270 : string seq = _v269 
            let v276 : string = method149()
            let v277 : bool = v276 = "\n"
            let v279 : string =
                if v277 then
                    method60(v276)
                else
                    v276
            let v280 : (string -> (string seq -> string)) = String.concat
            let v281 : (string seq -> string) = v280 v279
            let v282 : string = v281 v270
            let v285 : Result<string, std_io_Error> = Ok v282 
            let v286 : (std_io_Error -> std_string_String) = method65()
            let v287 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v288 : string = "$0.map_err(|x| $1(x))"
            let v289 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v285, v286) v288 
            let _v287 = v289 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v290 : string = "$0.map_err(|x| $1(x))"
            let v291 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v285, v286) v290 
            let _v287 = v291 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v292 : string = "$0.map_err(|x| $1(x))"
            let v293 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v285, v286) v292 
            let _v287 = v293 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v294 : Result<string, std_string_String> = match v285 with Ok x -> Ok x | Error x -> Error (v286 x)
            let _v287 = v294 
            #endif
#if FABLE_COMPILER_PYTHON
            let v295 : Result<string, std_string_String> = match v285 with Ok x -> Ok x | Error x -> Error (v286 x)
            let _v287 = v295 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v296 : Result<string, std_string_String> = match v285 with Ok x -> Ok x | Error x -> Error (v286 x)
            let _v287 = v296 
            #endif
#else
            let v297 : Result<string, std_string_String> = match v285 with Ok x -> Ok x | Error x -> Error (v286 x)
            let _v287 = v297 
            #endif
            let v298 : Result<string, std_string_String> = _v287 
            let v301 : (string -> US33) = method150()
            let v302 : (std_string_String -> US33) = method151()
            let v303 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v304 : US33 = Fable.Core.RustInterop.emitRustExpr struct (v301, v302, v298) v303 
            let v312 : string =
                match v304 with
                | US33_1(v306) -> (* Error *)
                    let v307 : string = $"resultm.get / Result value was Error: {v306}"
                    failwith<string> v307
                | US33_0(v305) -> (* Ok *)
                    v305
            let v313 : bool = v162 = v312
            v313
    if v314 then
        US32_1
    else
        let v316 : US35 = method163(v2, v3, v6, v4)
        match v316 with
        | US35_1(v372, v373) -> (* Error *)
            let v374 : (string * string) = v6, v373 
            let v375 : Result<string, (string * string)> = Error v374 
            US32_0(v375)
        | US35_0(v317, v318) -> (* Ok *)
            let v319 : bool = v317 <> 0 
            if v319 then
                let v322 : unit = ()
                let v323 : (unit -> unit) = closure81(v318, v317)
                let v324 : unit = (fun () -> v323 (); v322) ()
                let v364 : (string * string) = v6, v318 
                let v365 : Result<string, (string * string)> = Error v364 
                US32_0(v365)
            else
                let v367 : bool = method152(v6)
                if v367 then
                    method155(v7, v6)
                else
                    let v368 : string = $"documents.files_fn / {v6} should exist"
                    failwith<unit> v368
                let v369 : Result<string, (string * string)> = Ok v6 
                US32_0(v369)
and closure77 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : string) : (string -> US32) =
    closure78(v0, v1, v2, v3, v4)
and method176 (v0 : int32, v1 : string, v2 : string) : string =
    let v3 : string = method13()
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
and method175 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string, v10 : string) : string =
    let v11 : string = method176(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "documents.crowbook / result contains ERROR"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method17(v14)
and closure84 (v0 : string, v1 : string, v2 : int32) () : unit =
    let v3 : US0 = US0_3
    let v4 : bool = method6(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method7(v21, v22, v23, v24, v25, v26)
        let v40 : string = method33()
        let v41 : string = method175(v21, v22, v23, v24, v25, v26, v39, v40, v2, v0, v1)
        method18(v41)
and method174 (v0 : bool, v1 : string, v2 : string, v3 : string, v4 : string) : US35 =
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
    let struct (v74 : int32, v75 : string) = method82(v69, v62, v63, v64, v65, v73, v70)
    let v76 : string = "ERROR"
    let v77 : bool = v75.Contains v76 
    let v80 : bool = v77 = false
    if v80 then
        US35_0(v74, v75)
    else
        let v82 : unit = ()
        let v83 : (unit -> unit) = closure84(v1, v75, v74)
        let v84 : unit = (fun () -> v83 (); v82) ()
        US35_1(v74, v75)
and closure83 (v0 : string, v1 : string, v2 : bool, v3 : string) (v4 : string) : US32 =
    let struct (v5 : string, v6 : string) = method148(v4, v3, v0)
    let v7 : bool = method152(v5)
    let v8 : bool = v7 = false
    let v11 : bool =
        if v8 then
            true
        else
            let v9 : bool = method152(v6)
            let v10 : bool = v9 = false
            v10
    let v313 : bool =
        if v11 then
            false
        else
            let v12 : string = method38(v5)
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
            let v70 : string = "v44.len()"
            let v71 : unativeint = Fable.Core.RustInterop.emitRustExpr () v70 
            let v72 : uint8 = v71 |> uint8 
            let v75 : unativeint = v62 |> unativeint 
            let v78 : unativeint = v75 |> unbox<unativeint>
            let v81 : bool = v78 = v71 
            let v88 : Ref<Slice'<uint8>> =
                if v81 then
                    let v84 : string = "&v44[v40..]"
                    let v85 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v84 
                    v85
                else
                    let v86 : string = "&v44[$0..$1]"
                    let v87 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v40, v75) v86 
                    v87
            let v89 : string = "sha2::Digest::update(&mut v37, v88)"
            Fable.Core.RustInterop.emitRustExpr () v89 
            let v90 : string = "true; } // rust.loop"
            let v91 : bool = Fable.Core.RustInterop.emitRustExpr () v90 
            let v92 : string = "true; } // rust.loop"
            let v93 : bool = Fable.Core.RustInterop.emitRustExpr () v92 
            let v94 : string = "true; } // rust.loop"
            let v95 : bool = Fable.Core.RustInterop.emitRustExpr () v94 
            let v96 : string = "true; { // rust.loop"
            let v97 : bool = Fable.Core.RustInterop.emitRustExpr () v96 
            let v98 : string = "true; { // rust.loop"
            let v99 : bool = Fable.Core.RustInterop.emitRustExpr () v98 
            let v100 : string = "&sha2::Digest::finalize(v37)"
            let v101 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v100 
            let v102 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v103 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v101 v102 
            let v104 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v105 : bool = Fable.Core.RustInterop.emitRustExpr v103 v104 
            let v106 : string = "x"
            let v107 : uint8 = Fable.Core.RustInterop.emitRustExpr () v106 
            let v108 : string = "format!(\"{:02x}\", $0)"
            let v109 : std_string_String = Fable.Core.RustInterop.emitRustExpr v107 v108 
            let v110 : string = "fable_library_rust::String_::fromString($0)"
            let v111 : string = Fable.Core.RustInterop.emitRustExpr v109 v110 
            let v112 : string = "true; $0 }).collect::<Vec<_>>()"
            let v113 : bool = Fable.Core.RustInterop.emitRustExpr v111 v112 
            let v114 : string = "_vec_map"
            let v115 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v114 
            let v116 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v117 : (string []) = Fable.Core.RustInterop.emitRustExpr v115 v116 
            let v118 : unit = ()
            let _v118 =
                seq {
                    for i = 0 to v117.Length - 1 do yield v117.[i]
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v119 : string seq = _v118 
            let v125 : string = method149()
            let v126 : bool = v125 = "\n"
            let v128 : string =
                if v126 then
                    method60(v125)
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
            let v150 : (string -> US33) = method150()
            let v151 : (std_string_String -> US33) = method151()
            let v152 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v153 : US33 = Fable.Core.RustInterop.emitRustExpr struct (v150, v151, v147) v152 
            let v161 : string =
                match v153 with
                | US33_1(v155) -> (* Error *)
                    let v156 : string = $"resultm.get / Result value was Error: {v155}"
                    failwith<string> v156
                | US33_0(v154) -> (* Ok *)
                    v154
            let v162 : string = method38(v6)
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
            let v220 : string = "v194.len()"
            let v221 : unativeint = Fable.Core.RustInterop.emitRustExpr () v220 
            let v222 : uint8 = v221 |> uint8 
            let v225 : unativeint = v212 |> unativeint 
            let v228 : unativeint = v225 |> unbox<unativeint>
            let v231 : bool = v228 = v221 
            let v238 : Ref<Slice'<uint8>> =
                if v231 then
                    let v234 : string = "&v194[v190..]"
                    let v235 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v234 
                    v235
                else
                    let v236 : string = "&v194[$0..$1]"
                    let v237 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v190, v225) v236 
                    v237
            let v239 : string = "sha2::Digest::update(&mut v187, v238)"
            Fable.Core.RustInterop.emitRustExpr () v239 
            let v240 : string = "true; } // rust.loop"
            let v241 : bool = Fable.Core.RustInterop.emitRustExpr () v240 
            let v242 : string = "true; } // rust.loop"
            let v243 : bool = Fable.Core.RustInterop.emitRustExpr () v242 
            let v244 : string = "true; } // rust.loop"
            let v245 : bool = Fable.Core.RustInterop.emitRustExpr () v244 
            let v246 : string = "true; { // rust.loop"
            let v247 : bool = Fable.Core.RustInterop.emitRustExpr () v246 
            let v248 : string = "true; { // rust.loop"
            let v249 : bool = Fable.Core.RustInterop.emitRustExpr () v248 
            let v250 : string = "&sha2::Digest::finalize(v187)"
            let v251 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v250 
            let v252 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v253 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v251 v252 
            let v254 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v255 : bool = Fable.Core.RustInterop.emitRustExpr v253 v254 
            let v256 : string = "x"
            let v257 : uint8 = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "format!(\"{:02x}\", $0)"
            let v259 : std_string_String = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "fable_library_rust::String_::fromString($0)"
            let v261 : string = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "true; $0 }).collect::<Vec<_>>()"
            let v263 : bool = Fable.Core.RustInterop.emitRustExpr v261 v262 
            let v264 : string = "_vec_map"
            let v265 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v264 
            let v266 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v267 : (string []) = Fable.Core.RustInterop.emitRustExpr v265 v266 
            let v268 : unit = ()
            let _v268 =
                seq {
                    for i = 0 to v267.Length - 1 do yield v267.[i]
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v269 : string seq = _v268 
            let v275 : string = method149()
            let v276 : bool = v275 = "\n"
            let v278 : string =
                if v276 then
                    method60(v275)
                else
                    v275
            let v279 : (string -> (string seq -> string)) = String.concat
            let v280 : (string seq -> string) = v279 v278
            let v281 : string = v280 v269
            let v284 : Result<string, std_io_Error> = Ok v281 
            let v285 : (std_io_Error -> std_string_String) = method65()
            let v286 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v287 : string = "$0.map_err(|x| $1(x))"
            let v288 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v284, v285) v287 
            let _v286 = v288 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v289 : string = "$0.map_err(|x| $1(x))"
            let v290 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v284, v285) v289 
            let _v286 = v290 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v291 : string = "$0.map_err(|x| $1(x))"
            let v292 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v284, v285) v291 
            let _v286 = v292 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v293 : Result<string, std_string_String> = match v284 with Ok x -> Ok x | Error x -> Error (v285 x)
            let _v286 = v293 
            #endif
#if FABLE_COMPILER_PYTHON
            let v294 : Result<string, std_string_String> = match v284 with Ok x -> Ok x | Error x -> Error (v285 x)
            let _v286 = v294 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v295 : Result<string, std_string_String> = match v284 with Ok x -> Ok x | Error x -> Error (v285 x)
            let _v286 = v295 
            #endif
#else
            let v296 : Result<string, std_string_String> = match v284 with Ok x -> Ok x | Error x -> Error (v285 x)
            let _v286 = v296 
            #endif
            let v297 : Result<string, std_string_String> = _v286 
            let v300 : (string -> US33) = method150()
            let v301 : (std_string_String -> US33) = method151()
            let v302 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v303 : US33 = Fable.Core.RustInterop.emitRustExpr struct (v300, v301, v297) v302 
            let v311 : string =
                match v303 with
                | US33_1(v305) -> (* Error *)
                    let v306 : string = $"resultm.get / Result value was Error: {v305}"
                    failwith<string> v306
                | US33_0(v304) -> (* Ok *)
                    v304
            let v312 : bool = v161 = v311
            v312
    if v313 then
        US32_1
    else
        let v315 : US35 = method174(v2, v5, v3, v1, v4)
        match v315 with
        | US35_1(v371, v372) -> (* Error *)
            let v373 : (string * string) = v5, v372 
            let v374 : Result<string, (string * string)> = Error v373 
            US32_0(v374)
        | US35_0(v316, v317) -> (* Ok *)
            let v318 : bool = v316 <> 0 
            if v318 then
                let v321 : unit = ()
                let v322 : (unit -> unit) = closure81(v317, v316)
                let v323 : unit = (fun () -> v322 (); v321) ()
                let v363 : (string * string) = v5, v317 
                let v364 : Result<string, (string * string)> = Error v363 
                US32_0(v364)
            else
                let v366 : bool = method152(v5)
                if v366 then
                    method155(v6, v5)
                else
                    let v367 : string = $"documents.files_fn / {v5} should exist"
                    failwith<unit> v367
                let v368 : Result<string, (string * string)> = Ok v5 
                US32_0(v368)
and closure82 (v0 : string, v1 : string, v2 : bool) (v3 : string) : (string -> US32) =
    closure83(v0, v1, v2, v3)
and method178 (v0 : string, v1 : string) : string =
    let v2 : string = method13()
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
and method177 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : string = method178(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "documents.run / par_map / files' = [] / listm.iter"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method17(v13)
and closure85 (v0 : string, v1 : string) () : unit =
    let v2 : US0 = US0_2
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method7(v20, v21, v22, v23, v24, v25)
        let v39 : string = method11()
        let v40 : string = method177(v20, v21, v22, v23, v24, v25, v38, v39, v1, v0)
        method18(v40)
and method179 (v0 : UH4, v1 : UH5 list) : UH5 list =
    match v0 with
    | UH4_1(v2, v3) -> (* Cons *)
        let v4 : UH5 list = method179(v3, v1)
        let v5 : UH5 list = v2 :: v4 
        v5
    | UH4_0 -> (* Nil *)
        v1
and method180 (v0 : int32, v1 : Mut9) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method181 (v0 : UH5, v1 : struct (string * string * (string -> (string -> US32))) list) : struct (string * string * (string -> (string -> US32))) list =
    match v0 with
    | UH5_1(v2, v3, v4, v5) -> (* Cons *)
        let v6 : struct (string * string * (string -> (string -> US32))) list = method181(v5, v1)
        let v7 : struct (string * string * (string -> (string -> US32))) list = struct (v2, v3, v4) :: v6 
        v7
    | UH5_0 -> (* Nil *)
        v1
and closure86 () struct (v0 : string, v1 : string, v2 : (string -> (string -> US32))) : Result<string, (string * string)> option =
    let v3 : (string -> US32) = v2 v1
    let v4 : US32 = v3 v0
    match v4 with
    | US32_1 -> (* None *)
        let v9 : Result<string, (string * string)> option = None
        v9
    | US32_0(v5) -> (* Some *)
        let v6 : Result<string, (string * string)> option = Some v5 
        v6
and method182 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method183 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and closure34 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> =
    let v6 : string = method37(v5)
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
    let v129 : string = method80()
    let v130 : string = v128.Replace (v3, v129)
    let v131 : string = "\\"
    let v132 : string = "/"
    let v133 : string = v130.Replace (v131, v132)
    let v134 : string = $".{v133}"
    let v135 : string = method38(v6)
    let v136 : string = method25(v2, v134)
    let v137 : string = method81(v136)
    let v138 : System.Threading.CancellationToken option = None
    let v139 : (struct (string * string) []) = [||]
    let v140 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v141 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v142 : string option = None
    let v143 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v137}\""
    let v144 : string option = Some v2 
    let v147 : bool = true
    let struct (v148 : int32, v149 : string) = method82(v143, v138, v139, v140, v141, v147, v144)
    let v150 : string = method25(v3, v134)
    let v151 : string = method81(v150)
    let v152 : System.Threading.CancellationToken option = None
    let v153 : (struct (string * string) []) = [||]
    let v154 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v155 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v156 : string option = None
    let v157 : string = $"git hash-object \"{v151}\""
    let v158 : string option = Some v3 
    let v161 : bool = true
    let struct (v162 : int32, v163 : string) = method82(v157, v152, v153, v154, v155, v161, v158)
    let v164 : string = method25(v4, v134)
    let v165 : string = method81(v164)
    let v166 : string = "hangul.md"
    let struct (v167 : string, v168 : string) = method148(v166, v151, v4)
    let v169 : bool = false
    let v170 : bool = false
    let v171 : bool = false
    let v172 : bool = true
    let v173 : bool = true
    let v174 : bool = true
    let v175 : bool = v149.Contains v163 
    let v630 : UH4 =
        if v175 then
            UH4_0
        else
            let v179 : string = method38(v151)
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
            let v237 : string = "v211.len()"
            let v238 : unativeint = Fable.Core.RustInterop.emitRustExpr () v237 
            let v239 : uint8 = v238 |> uint8 
            let v242 : unativeint = v229 |> unativeint 
            let v245 : unativeint = v242 |> unbox<unativeint>
            let v248 : bool = v245 = v238 
            let v255 : Ref<Slice'<uint8>> =
                if v248 then
                    let v251 : string = "&v211[v207..]"
                    let v252 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v251 
                    v252
                else
                    let v253 : string = "&v211[$0..$1]"
                    let v254 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v207, v242) v253 
                    v254
            let v256 : string = "sha2::Digest::update(&mut v204, v255)"
            Fable.Core.RustInterop.emitRustExpr () v256 
            let v257 : string = "true; } // rust.loop"
            let v258 : bool = Fable.Core.RustInterop.emitRustExpr () v257 
            let v259 : string = "true; } // rust.loop"
            let v260 : bool = Fable.Core.RustInterop.emitRustExpr () v259 
            let v261 : string = "true; } // rust.loop"
            let v262 : bool = Fable.Core.RustInterop.emitRustExpr () v261 
            let v263 : string = "true; { // rust.loop"
            let v264 : bool = Fable.Core.RustInterop.emitRustExpr () v263 
            let v265 : string = "true; { // rust.loop"
            let v266 : bool = Fable.Core.RustInterop.emitRustExpr () v265 
            let v267 : string = "&sha2::Digest::finalize(v204)"
            let v268 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v267 
            let v269 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v270 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v268 v269 
            let v271 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
            let v272 : bool = Fable.Core.RustInterop.emitRustExpr v270 v271 
            let v273 : string = "x"
            let v274 : uint8 = Fable.Core.RustInterop.emitRustExpr () v273 
            let v275 : string = "format!(\"{:02x}\", $0)"
            let v276 : std_string_String = Fable.Core.RustInterop.emitRustExpr v274 v275 
            let v277 : string = "fable_library_rust::String_::fromString($0)"
            let v278 : string = Fable.Core.RustInterop.emitRustExpr v276 v277 
            let v279 : string = "true; $0 }).collect::<Vec<_>>()"
            let v280 : bool = Fable.Core.RustInterop.emitRustExpr v278 v279 
            let v281 : string = "_vec_map"
            let v282 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v281 
            let v283 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v284 : (string []) = Fable.Core.RustInterop.emitRustExpr v282 v283 
            let v285 : unit = ()
            let _v285 =
                seq {
                    for i = 0 to v284.Length - 1 do yield v284.[i]
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v286 : string seq = _v285 
            let v292 : string = method149()
            let v293 : bool = v292 = "\n"
            let v295 : string =
                if v293 then
                    method60(v292)
                else
                    v292
            let v296 : (string -> (string seq -> string)) = String.concat
            let v297 : (string seq -> string) = v296 v295
            let v298 : string = v297 v286
            let v301 : Result<string, std_io_Error> = Ok v298 
            let v302 : (std_io_Error -> std_string_String) = method65()
            let v303 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v304 : string = "$0.map_err(|x| $1(x))"
            let v305 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v301, v302) v304 
            let _v303 = v305 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v306 : string = "$0.map_err(|x| $1(x))"
            let v307 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v301, v302) v306 
            let _v303 = v307 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v308 : string = "$0.map_err(|x| $1(x))"
            let v309 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v301, v302) v308 
            let _v303 = v309 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v310 : Result<string, std_string_String> = match v301 with Ok x -> Ok x | Error x -> Error (v302 x)
            let _v303 = v310 
            #endif
#if FABLE_COMPILER_PYTHON
            let v311 : Result<string, std_string_String> = match v301 with Ok x -> Ok x | Error x -> Error (v302 x)
            let _v303 = v311 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v312 : Result<string, std_string_String> = match v301 with Ok x -> Ok x | Error x -> Error (v302 x)
            let _v303 = v312 
            #endif
#else
            let v313 : Result<string, std_string_String> = match v301 with Ok x -> Ok x | Error x -> Error (v302 x)
            let _v303 = v313 
            #endif
            let v314 : Result<string, std_string_String> = _v303 
            let v317 : (string -> US33) = method150()
            let v318 : (std_string_String -> US33) = method151()
            let v319 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v320 : US33 = Fable.Core.RustInterop.emitRustExpr struct (v317, v318, v314) v319 
            let v328 : string =
                match v320 with
                | US33_1(v322) -> (* Error *)
                    let v323 : string = $"resultm.get / Result value was Error: {v322}"
                    failwith<string> v323
                | US33_0(v321) -> (* Ok *)
                    v321
            let v329 : bool = method152(v165)
            let v330 : bool = v329 = false
            let v480 : US5 =
                if v330 then
                    US5_1
                else
                    let v332 : string = method38(v165)
                    let v333 : string = "std::fs::File::open(&*v332)"
                    let v334 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v333 
                    let v335 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v336 : string = "$0.unwrap()"
                    let v337 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v334 v336 
                    let _v335 = v337 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v338 : string = "$0.unwrap()"
                    let v339 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v334 v338 
                    let _v335 = v339 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v340 : string = "$0.unwrap()"
                    let v341 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v334 v340 
                    let _v335 = v341 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v342 : std_fs_File = match v334 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v335 = v342 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v343 : std_fs_File = match v334 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v335 = v343 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v344 : std_fs_File = match v334 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v335 = v344 
                    #endif
#else
                    let v345 : std_fs_File = match v334 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v335 = v345 
                    #endif
                    let v346 : std_fs_File = _v335 
                    let v349 : string = "std::io::BufReader::new($0)"
                    let v350 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr v346 v349 
                    let v351 : string = "std::io::BufReader::new($0)"
                    let v352 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr v350 v351 
                    let v353 : string = "true; let mut v352 = v352"
                    let v354 : bool = Fable.Core.RustInterop.emitRustExpr () v353 
                    let v355 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
                    Fable.Core.RustInterop.emitRustExpr () v355 
                    let v356 : string = "result"
                    let v357 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v356 
                    let v358 : string = "true; let mut v357 = v357"
                    let v359 : bool = Fable.Core.RustInterop.emitRustExpr () v358 
                    let v360 : unativeint = 0 |> unativeint 
                    let v363 : string = "[$0; 1024]"
                    let v364 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v363 
                    let v365 : string = "true; loop { // rust.loop"
                    let v366 : bool = Fable.Core.RustInterop.emitRustExpr () v365 
                    let v367 : string = "true; let mut v364 = v364"
                    let v368 : bool = Fable.Core.RustInterop.emitRustExpr () v367 
                    let v369 : string = "std::io::Read::read(&mut v352, &mut v364)"
                    let v370 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v369 
                    let v371 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v372 : string = "$0.unwrap()"
                    let v373 : unativeint = Fable.Core.RustInterop.emitRustExpr v370 v372 
                    let _v371 = v373 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v374 : string = "$0.unwrap()"
                    let v375 : unativeint = Fable.Core.RustInterop.emitRustExpr v370 v374 
                    let _v371 = v375 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v376 : string = "$0.unwrap()"
                    let v377 : unativeint = Fable.Core.RustInterop.emitRustExpr v370 v376 
                    let _v371 = v377 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v378 : unativeint = match v370 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v371 = v378 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v379 : unativeint = match v370 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v371 = v379 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v380 : unativeint = match v370 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v371 = v380 
                    #endif
#else
                    let v381 : unativeint = match v370 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v371 = v381 
                    #endif
                    let v382 : unativeint = _v371 
                    let v385 : bool = v382 = v360 
                    if v385 then
                        let v388 : string = "true; break"
                        let v389 : bool = Fable.Core.RustInterop.emitRustExpr () v388 
                        ()
                    let v390 : string = "v364.len()"
                    let v391 : unativeint = Fable.Core.RustInterop.emitRustExpr () v390 
                    let v392 : uint8 = v391 |> uint8 
                    let v395 : unativeint = v382 |> unativeint 
                    let v398 : unativeint = v395 |> unbox<unativeint>
                    let v401 : bool = v398 = v391 
                    let v408 : Ref<Slice'<uint8>> =
                        if v401 then
                            let v404 : string = "&v364[v360..]"
                            let v405 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v404 
                            v405
                        else
                            let v406 : string = "&v364[$0..$1]"
                            let v407 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v360, v395) v406 
                            v407
                    let v409 : string = "sha2::Digest::update(&mut v357, v408)"
                    Fable.Core.RustInterop.emitRustExpr () v409 
                    let v410 : string = "true; } // rust.loop"
                    let v411 : bool = Fable.Core.RustInterop.emitRustExpr () v410 
                    let v412 : string = "true; } // rust.loop"
                    let v413 : bool = Fable.Core.RustInterop.emitRustExpr () v412 
                    let v414 : string = "true; } // rust.loop"
                    let v415 : bool = Fable.Core.RustInterop.emitRustExpr () v414 
                    let v416 : string = "true; { // rust.loop"
                    let v417 : bool = Fable.Core.RustInterop.emitRustExpr () v416 
                    let v418 : string = "true; { // rust.loop"
                    let v419 : bool = Fable.Core.RustInterop.emitRustExpr () v418 
                    let v420 : string = "&sha2::Digest::finalize(v357)"
                    let v421 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v420 
                    let v422 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
                    let v423 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v421 v422 
                    let v424 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
                    let v425 : bool = Fable.Core.RustInterop.emitRustExpr v423 v424 
                    let v426 : string = "x"
                    let v427 : uint8 = Fable.Core.RustInterop.emitRustExpr () v426 
                    let v428 : string = "format!(\"{:02x}\", $0)"
                    let v429 : std_string_String = Fable.Core.RustInterop.emitRustExpr v427 v428 
                    let v430 : string = "fable_library_rust::String_::fromString($0)"
                    let v431 : string = Fable.Core.RustInterop.emitRustExpr v429 v430 
                    let v432 : string = "true; $0 }).collect::<Vec<_>>()"
                    let v433 : bool = Fable.Core.RustInterop.emitRustExpr v431 v432 
                    let v434 : string = "_vec_map"
                    let v435 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v434 
                    let v436 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v437 : (string []) = Fable.Core.RustInterop.emitRustExpr v435 v436 
                    let v438 : unit = ()
                    let _v438 =
                        seq {
                            for i = 0 to v437.Length - 1 do yield v437.[i]
                            (*
                            ()
                        *)
                        }
                        (*
                        ()
                    *)
                    let v439 : string seq = _v438 
                    let v445 : string = method149()
                    let v446 : bool = v445 = "\n"
                    let v448 : string =
                        if v446 then
                            method60(v445)
                        else
                            v445
                    let v449 : (string -> (string seq -> string)) = String.concat
                    let v450 : (string seq -> string) = v449 v448
                    let v451 : string = v450 v439
                    let v454 : Result<string, std_io_Error> = Ok v451 
                    let v455 : (std_io_Error -> std_string_String) = method65()
                    let v456 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v457 : string = "$0.map_err(|x| $1(x))"
                    let v458 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v454, v455) v457 
                    let _v456 = v458 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v459 : string = "$0.map_err(|x| $1(x))"
                    let v460 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v454, v455) v459 
                    let _v456 = v460 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v461 : string = "$0.map_err(|x| $1(x))"
                    let v462 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v454, v455) v461 
                    let _v456 = v462 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v463 : Result<string, std_string_String> = match v454 with Ok x -> Ok x | Error x -> Error (v455 x)
                    let _v456 = v463 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v464 : Result<string, std_string_String> = match v454 with Ok x -> Ok x | Error x -> Error (v455 x)
                    let _v456 = v464 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v465 : Result<string, std_string_String> = match v454 with Ok x -> Ok x | Error x -> Error (v455 x)
                    let _v456 = v465 
                    #endif
#else
                    let v466 : Result<string, std_string_String> = match v454 with Ok x -> Ok x | Error x -> Error (v455 x)
                    let _v456 = v466 
                    #endif
                    let v467 : Result<string, std_string_String> = _v456 
                    let v470 : (string -> US33) = method150()
                    let v471 : (std_string_String -> US33) = method151()
                    let v472 : string = "match $2 { Ok(x) => $0(x), Err(e) => $1(e) }"
                    let v473 : US33 = Fable.Core.RustInterop.emitRustExpr struct (v470, v471, v467) v472 
                    match v473 with
                    | US33_1(v476) -> (* Error *)
                        US5_1
                    | US33_0(v474) -> (* Ok *)
                        US5_0(v474)
            match v480 with
            | US5_0(v481) -> (* Some *)
                let v482 : bool = v328 = v481
                if v482 then
                    UH4_0
                else
                    let v484 : unit = ()
                    let v485 : (unit -> unit) = closure72(v134, v135, v137, v149, v148, v151, v163, v162, v165, v328, v480)
                    let v486 : unit = (fun () -> v485 (); v484) ()
                    method155(v165, v151)
                    let v534 : (string -> (string -> US32)) = closure77(v4, v3, v1, v0)
                    let v535 : UH5 = UH5_0
                    let v536 : UH5 = UH5_1(v166, v151, v534, v535)
                    let v537 : string = "html"
                    let v538 : (string -> (string -> US32)) = closure82(v4, v3, v169)
                    let v539 : string = "pdf"
                    let v540 : (string -> (string -> US32)) = closure82(v4, v3, v170)
                    let v541 : string = "epub"
                    let v542 : (string -> (string -> US32)) = closure82(v4, v3, v171)
                    let v543 : (string -> (string -> US32)) = closure82(v4, v3, v172)
                    let v544 : (string -> (string -> US32)) = closure82(v4, v3, v173)
                    let v545 : (string -> (string -> US32)) = closure82(v4, v3, v174)
                    let v546 : UH5 = UH5_0
                    let v547 : UH5 = UH5_1(v541, v167, v545, v546)
                    let v548 : UH5 = UH5_1(v539, v167, v544, v547)
                    let v549 : UH5 = UH5_1(v537, v167, v543, v548)
                    let v550 : UH5 = UH5_1(v541, v151, v542, v549)
                    let v551 : UH5 = UH5_1(v539, v151, v540, v550)
                    let v552 : UH5 = UH5_1(v537, v151, v538, v551)
                    let v553 : UH4 = UH4_0
                    let v554 : UH4 = UH4_1(v552, v553)
                    UH4_1(v536, v554)
            | _ ->
                let v557 : unit = ()
                let v558 : (unit -> unit) = closure72(v134, v135, v137, v149, v148, v151, v163, v162, v165, v328, v480)
                let v559 : unit = (fun () -> v558 (); v557) ()
                method155(v165, v151)
                let v607 : (string -> (string -> US32)) = closure77(v4, v3, v1, v0)
                let v608 : UH5 = UH5_0
                let v609 : UH5 = UH5_1(v166, v151, v607, v608)
                let v610 : string = "html"
                let v611 : (string -> (string -> US32)) = closure82(v4, v3, v169)
                let v612 : string = "pdf"
                let v613 : (string -> (string -> US32)) = closure82(v4, v3, v170)
                let v614 : string = "epub"
                let v615 : (string -> (string -> US32)) = closure82(v4, v3, v171)
                let v616 : (string -> (string -> US32)) = closure82(v4, v3, v172)
                let v617 : (string -> (string -> US32)) = closure82(v4, v3, v173)
                let v618 : (string -> (string -> US32)) = closure82(v4, v3, v174)
                let v619 : UH5 = UH5_0
                let v620 : UH5 = UH5_1(v614, v167, v618, v619)
                let v621 : UH5 = UH5_1(v612, v167, v617, v620)
                let v622 : UH5 = UH5_1(v610, v167, v616, v621)
                let v623 : UH5 = UH5_1(v614, v151, v615, v622)
                let v624 : UH5 = UH5_1(v612, v151, v613, v623)
                let v625 : UH5 = UH5_1(v610, v151, v611, v624)
                let v626 : UH4 = UH4_0
                let v627 : UH4 = UH4_1(v625, v626)
                UH4_1(v609, v627)
    let v631 : bool =
        match v630 with
        | UH4_0 -> (* Nil *)
            true
        | _ ->
            false
    let v632 : bool = v631 <> true
    let v1007 : UH4 =
        if v632 then
            v630
        else
            let v633 : string = "epub"
            let struct (v634 : string, v635 : string) = method148(v633, v167, v4)
            let v636 : bool = method152(v634)
            let v682 : bool =
                if v636 then
                    true
                else
                    let v637 : bool = method152(v635)
                    let v638 : bool = v637 = false
                    if v638 then
                        true
                    else
                        let v639 : unit = ()
                        let v640 : (unit -> unit) = closure85(v635, v634)
                        let v641 : unit = (fun () -> v640 (); v639) ()
                        method155(v634, v635)
                        false
            let v687 : UH5 =
                if v682 then
                    let v683 : (string -> (string -> US32)) = closure82(v4, v3, v174)
                    let v684 : UH5 = UH5_0
                    UH5_1(v633, v167, v683, v684)
                else
                    UH5_0
            let v688 : string = "pdf"
            let struct (v689 : string, v690 : string) = method148(v688, v167, v4)
            let v691 : bool = method152(v689)
            let v737 : bool =
                if v691 then
                    true
                else
                    let v692 : bool = method152(v690)
                    let v693 : bool = v692 = false
                    if v693 then
                        true
                    else
                        let v694 : unit = ()
                        let v695 : (unit -> unit) = closure85(v690, v689)
                        let v696 : unit = (fun () -> v695 (); v694) ()
                        method155(v689, v690)
                        false
            let v740 : UH5 =
                if v737 then
                    let v738 : (string -> (string -> US32)) = closure82(v4, v3, v173)
                    UH5_1(v688, v167, v738, v687)
                else
                    v687
            let v741 : string = "html"
            let struct (v742 : string, v743 : string) = method148(v741, v167, v4)
            let v744 : bool = method152(v742)
            let v790 : bool =
                if v744 then
                    true
                else
                    let v745 : bool = method152(v743)
                    let v746 : bool = v745 = false
                    if v746 then
                        true
                    else
                        let v747 : unit = ()
                        let v748 : (unit -> unit) = closure85(v743, v742)
                        let v749 : unit = (fun () -> v748 (); v747) ()
                        method155(v742, v743)
                        false
            let v793 : UH5 =
                if v790 then
                    let v791 : (string -> (string -> US32)) = closure82(v4, v3, v172)
                    UH5_1(v741, v167, v791, v740)
                else
                    v740
            let struct (v794 : string, v795 : string) = method148(v633, v151, v4)
            let v796 : bool = method152(v794)
            let v842 : bool =
                if v796 then
                    true
                else
                    let v797 : bool = method152(v795)
                    let v798 : bool = v797 = false
                    if v798 then
                        true
                    else
                        let v799 : unit = ()
                        let v800 : (unit -> unit) = closure85(v795, v794)
                        let v801 : unit = (fun () -> v800 (); v799) ()
                        method155(v794, v795)
                        false
            let v845 : UH5 =
                if v842 then
                    let v843 : (string -> (string -> US32)) = closure82(v4, v3, v171)
                    UH5_1(v633, v151, v843, v793)
                else
                    v793
            let struct (v846 : string, v847 : string) = method148(v688, v151, v4)
            let v848 : bool = method152(v846)
            let v894 : bool =
                if v848 then
                    true
                else
                    let v849 : bool = method152(v847)
                    let v850 : bool = v849 = false
                    if v850 then
                        true
                    else
                        let v851 : unit = ()
                        let v852 : (unit -> unit) = closure85(v847, v846)
                        let v853 : unit = (fun () -> v852 (); v851) ()
                        method155(v846, v847)
                        false
            let v897 : UH5 =
                if v894 then
                    let v895 : (string -> (string -> US32)) = closure82(v4, v3, v170)
                    UH5_1(v688, v151, v895, v845)
                else
                    v845
            let struct (v898 : string, v899 : string) = method148(v741, v151, v4)
            let v900 : bool = method152(v898)
            let v946 : bool =
                if v900 then
                    true
                else
                    let v901 : bool = method152(v899)
                    let v902 : bool = v901 = false
                    if v902 then
                        true
                    else
                        let v903 : unit = ()
                        let v904 : (unit -> unit) = closure85(v899, v898)
                        let v905 : unit = (fun () -> v904 (); v903) ()
                        method155(v898, v899)
                        false
            let v949 : UH5 =
                if v946 then
                    let v947 : (string -> (string -> US32)) = closure82(v4, v3, v169)
                    UH5_1(v741, v151, v947, v897)
                else
                    v897
            let struct (v950 : string, v951 : string) = method148(v166, v151, v4)
            let v952 : bool = method152(v950)
            let v998 : bool =
                if v952 then
                    true
                else
                    let v953 : bool = method152(v951)
                    let v954 : bool = v953 = false
                    if v954 then
                        true
                    else
                        let v955 : unit = ()
                        let v956 : (unit -> unit) = closure85(v951, v950)
                        let v957 : unit = (fun () -> v956 (); v955) ()
                        method155(v950, v951)
                        false
            let v1003 : UH5 =
                if v998 then
                    let v999 : (string -> (string -> US32)) = closure77(v4, v3, v1, v0)
                    let v1000 : UH5 = UH5_0
                    UH5_1(v166, v151, v999, v1000)
                else
                    UH5_0
            let v1004 : UH4 = UH4_0
            let v1005 : UH4 = UH4_1(v949, v1004)
            UH4_1(v1003, v1005)
    let v1008 : UH5 list = []
    let v1009 : UH5 list = method179(v1007, v1008)
    let v1010 : (UH5 list -> (UH5 [])) = List.toArray
    let v1011 : (UH5 []) = v1010 v1009
    let v1014 : string = "$0.to_vec()"
    let v1015 : Vec<UH5> = Fable.Core.RustInterop.emitRustExpr v1011 v1014 
    let v1016 : (Result<string, (string * string)> option []) = [||]
    let v1017 : string = "$0.to_vec()"
    let v1018 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1016 v1017 
    let v1019 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v1020 : (UH5 []) = Fable.Core.RustInterop.emitRustExpr v1015 v1019 
    let v1021 : int32 = v1020.Length
    let v1022 : Mut9 = {l0 = 0; l1 = v1018} : Mut9
    while method180(v1021, v1022) do
        let v1024 : int32 = v1022.l0
        let v1025 : Vec<Result<string, (string * string)> option> = v1022.l1
        let v1026 : UH5 = v1020.[int v1024]
        let v1027 : struct (string * string * (string -> (string -> US32))) list = []
        let v1028 : struct (string * string * (string -> (string -> US32))) list = method181(v1026, v1027)
        let v1029 : (struct (string * string * (string -> (string -> US32))) list -> (struct (string * string * (string -> (string -> US32))) [])) = List.toArray
        let v1030 : (struct (string * string * (string -> (string -> US32))) []) = v1029 v1028
        let v1033 : string = "$0.to_vec()"
        let v1034 : Vec<struct (string * string * (string -> (string -> US32)))> = Fable.Core.RustInterop.emitRustExpr v1030 v1033 
        let v1035 : string = "rayon::iter::IntoParallelIterator::into_par_iter($0)"
        let v1036 : rayon_vec_IntoIter<struct (string * string * (string -> (string -> US32)))> = Fable.Core.RustInterop.emitRustExpr v1034 v1035 
        let v1037 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
        let v1038 : (struct (string * string * (string -> (string -> US32))) -> Result<string, (string * string)> option) = closure86()
        let v1039 : rayon_iter_Map<rayon_vec_IntoIter<struct (string * string * (string -> (string -> US32)))>> = Fable.Core.RustInterop.emitRustExpr struct (v1036, v1038) v1037 
        let v1040 : string = "rayon::iter::ParallelIterator::collect($0)"
        let v1041 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v1039 v1040 
        let v1042 : Vec<Result<string, (string * string)> option> = method182(v1041)
        let v1043 : Vec<Result<string, (string * string)> option> = method183(v1025)
        let v1044 : string = "true; let mut v1043 = v1043"
        let v1045 : bool = Fable.Core.RustInterop.emitRustExpr () v1044 
        let v1046 : string = "true; v1043.extend(v1042)"
        let v1047 : bool = Fable.Core.RustInterop.emitRustExpr () v1046 
        let v1048 : string = "v1043"
        let v1049 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr () v1048 
        let v1050 : int32 = v1024 + 1
        v1022.l0 <- v1050
        v1022.l1 <- v1049
        ()
    let v1051 : Vec<Result<string, (string * string)> option> = v1022.l1
    let v1052 : (string * Vec<Result<string, (string * string)> option>) = v135, v1051 
    let v1053 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v1052 
    v1053
and method184 (v0 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>) : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> =
    v0
and method24 (v0 : string, v1 : string, v2 : string, v3 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> =
    let v4 : string = __SOURCE_DIRECTORY__
    let v5 : string = "polyglot"
    let v6 : string = ".devcontainer"
    let v7 : string = method25(v5, v6)
    let v8 : US7 = method28(v7, v4)
    let v56 : US5 =
        match v8 with
        | US7_1(v11) -> (* Error *)
            let v12 : unit = ()
            let v13 : (unit -> unit) = closure14(v11)
            let v14 : unit = (fun () -> v13 (); v12) ()
            US5_1
        | US7_0(v9) -> (* Ok *)
            US5_0(v9)
    let v111 : US5 =
        match v56 with
        | US5_1 -> (* None *)
            let v59 : string = method36()
            let v60 : string = method25(v5, v6)
            let v61 : US7 = method28(v60, v59)
            match v61 with
            | US7_1(v64) -> (* Error *)
                let v65 : unit = ()
                let v66 : (unit -> unit) = closure14(v64)
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
    let v116 : string = method25(v115, v5)
    let v117 : string = method37(v3)
    let v118 : string = method37(v2)
    let v119 : string = method37(v1)
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure23(v0, v117, v118, v119)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v162 : string = "true; let __future_init = Box::pin(async move { //"
    let v163 : bool = Fable.Core.RustInterop.emitRustExpr () v162 
    let v164 : string = "async_walkdir::WalkDir::new(&*$0)"
    let v165 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr v118 v164 
    let v166 : string = "async_walkdir::WalkDir::filter($0, move |x| $1(x))"
    let v167 : (async_walkdir_DirEntry -> std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>>) = closure24()
    let v168 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr struct (v165, v167) v166 
    let v169 : (Result<async_walkdir_DirEntry, async_walkdir_Error> -> string option) = method71()
    let v170 : string = "futures::stream::StreamExt::filter_map(v168, |x| async { v169(x) })"
    let v171 : _ = Fable.Core.RustInterop.emitRustExpr () v170 
    let v172 : string = "Box::pin(futures::stream::StreamExt::collect(v171))"
    let v173 : std_pin_Pin<Box<Dyn<std_future_Future<Vec<string>>>>> = Fable.Core.RustInterop.emitRustExpr () v172 
    let v174 : string = "v173.await"
    let v175 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v174 
    let v176 : unit = ()
    let v177 : (unit -> unit) = closure33(v175)
    let v178 : unit = (fun () -> v177 (); v176) ()
    let v220 : string = "rayon::iter::IntoParallelIterator::into_par_iter($0)"
    let v221 : rayon_vec_IntoIter<string> = Fable.Core.RustInterop.emitRustExpr v175 v220 
    let v222 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
    let v223 : (string -> Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>) = closure34(v0, v116, v117, v118, v119)
    let v224 : rayon_iter_Map<rayon_vec_IntoIter<string>> = Fable.Core.RustInterop.emitRustExpr struct (v221, v223) v222 
    let v225 : string = "rayon::iter::ParallelIterator::collect($0)"
    let v226 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = Fable.Core.RustInterop.emitRustExpr v224 v225 
    let v227 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Ok v226 
    let v228 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = method184(v227)
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
and closure87 () (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) : US36 =
    US36_0(v0)
and method185 () : (Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> -> US36) =
    closure87()
and closure88 () (v0 : std_string_String) : US36 =
    US36_1(v0)
and method186 () : (std_string_String -> US36) =
    closure88()
and method187 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method77(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "documents.main"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method17(v12)
and closure89 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_4
    let v2 : bool = method6(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method75()
        let v39 : string = method187(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method18(v39)
and method189 (v0 : unativeint) : string =
    let v1 : string = method13()
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
and method188 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : unativeint) : string =
    let v9 : string = method189(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "documents.main"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method17(v12)
and closure90 (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) () : unit =
    let v1 : US0 = US0_2
    let v2 : bool = method6(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method11()
        let v39 : string = "$0.len()"
        let v40 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v39 
        let v41 : string = method188(v19, v20, v21, v22, v23, v24, v37, v38, v40)
        method18(v41)
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
    let v62 : string = method19()
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
    let v89 : (std_string_String -> US6) = method20()
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
    let v112 : string = method21()
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
    let v139 : (std_string_String -> US6) = method20()
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
    let v162 : string = method22()
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
    let v189 : (std_string_String -> US6) = method20()
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
    let v212 : string = method23()
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
    let v239 : (std_string_String -> US6) = method20()
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
    let v262 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = method24(v261, v211, v161, v111)
    let v263 : string = "futures::executor::block_on($0)"
    let v264 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr v262 v263 
    let v265 : (Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> -> US36) = method185()
    let v266 : (std_string_String -> US36) = method186()
    let v267 : US36 = match v264 with Ok x -> v265 x | Error x -> v266 x
    match v267 with
    | US36_1(v313) -> (* Error *)
        let v314 : unit = ()
        let v315 : (unit -> unit) = closure89(v313)
        let v316 : unit = (fun () -> v315 (); v314) ()
        1
    | US36_0(v268) -> (* Ok *)
        let v269 : unit = ()
        let v270 : (unit -> unit) = closure90(v268)
        let v271 : unit = (fun () -> v270 (); v269) ()
        0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
