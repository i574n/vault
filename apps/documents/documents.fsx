#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type Slice'<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("futures::future::JoinAll<$0>")>]
#endif
type futures_future_JoinAll<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("futures::future::TryJoinAll<$0>")>]
#endif
type futures_future_TryJoinAll<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::iter::Map<$0, _>")>]
#endif
type rayon_iter_Map<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::vec::IntoIter<$0>")>]
#endif
type rayon_vec_IntoIter<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::future::Future<Output = $0>")>]
#endif
type std_future_Future<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("tokio::prelude::stream::Fuse<$0>")>]
#endif
type futures_future_Fuse<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("tokio::task::JoinHandle<$0>")>]
#endif
type tokio_task_JoinHandle<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("tokio_stream::StreamExt")>]
#endif
type tokio_stream_StreamExt = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("core::any::Any")>]
#endif
type core_any_Any = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type core_ops_Try<'T> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("Send")>]
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
[<Fable.Core.Erase; Fable.Core.Emit("$0 + $1")>]
#endif
type LifetimeJoin<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("'static")>]
#endif
type StaticLifetime = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0")>]
#endif
type LifetimeRef<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 $1")>]
#endif
type Lifetime<'T, 'U> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("std::collections::HashMap<$0, $1>")>]
#endif
type std_collections_HashMap<'K, 'V> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::collections::BTreeMap<$0, $1>")>]
#endif
type std_collections_BTreeMap<'K, 'V> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("encoding_rs::Encoding")>]
#endif
type encoding_rs_Encoding = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("regex::Regex")>]
#endif
type regex_Regex = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Captures<$0>")>]
#endif
type regex_Captures<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureMatches")>]
#endif
type regex_CaptureMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureNames")>]
#endif
type regex_CaptureNames = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Match")>]
#endif
type regex_Match = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Error")>]
#endif
type regex_Error = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Receiver<$0>")>]
#endif
type std_sync_mpsc_Receiver<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::SendError<$0>")>]
#endif
type std_sync_mpsc_SendError<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Sender<$0>")>]
#endif
type std_sync_mpsc_Sender<'T> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("encoding_rs_io::DecodeReaderBytes<$0, $1>")>]
#endif
type encoding_rs_io_DecodeReaderBytes<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::BufReader<$0>")>]
#endif
type std_io_BufReader<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Cursor<$0>")>]
#endif
type std_io_Cursor<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Error")>]
#endif
type std_io_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Lines<$0>")>]
#endif
type std_io_Lines<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("tokio::io::BufReader<$0>")>]
#endif
type tokio_io_BufReader<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::Arg")>]
#endif
type clap_Arg = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::ArgAction")>]
#endif
type clap_ArgAction = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::Command")>]
#endif
type clap_Command = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::ArgMatches")>]
#endif
type clap_ArgMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::builder::ValueRange")>]
#endif
type clap_builder_ValueRange = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::builder::ValueParser")>]
#endif
type clap_builder_ValueParser = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::builder::PossibleValue")>]
#endif
type clap_builder_PossibleValue = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ExitStatus")>]
#endif
type std_process_ExitStatus = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Output")>]
#endif
type std_process_Output = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Stdio")>]
#endif
type std_process_Stdio = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("core::iter::Fuse<$0>")>]
#endif
type core_iter_Fuse<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("sha2::Sha256")>]
#endif
type sha2_Sha256 = class end
module State = let mutable trace_state = None
type IOsEnviron = abstract environ: x: unit -> obj
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
type [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
    | US0_4
and Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : bool}
and Mut2 = {mutable l0 : US0}
and Mut3 = {mutable l0 : (string -> unit)}
and [<Struct>] US1 =
    | US1_0 of f0_0 : int64
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : US0
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : string
    | US3_1
and [<Struct>] US4 =
    | US4_0 of f0_0 : std_string_String
    | US4_1
and [<Struct>] US5 =
    | US5_0
    | US5_1
    | US5_2
and [<Struct>] US6 =
    | US6_0 of f0_0 : US5
    | US6_1 of f1_0 : US5
    | US6_2 of f2_0 : US5
    | US6_3 of f3_0 : US5
and Mut4 = {mutable l0 : int32; mutable l1 : int32; mutable l2 : (string [])}
and Mut5 = {mutable l0 : int32}
and [<Struct>] US7 =
    | US7_0
    | US7_1
    | US7_2
and [<Struct>] US8 =
    | US8_0 of f0_0 : std_fs_FileType
    | US8_1 of f1_0 : std_string_String
and [<Struct>] US9 =
    | US9_0 of f0_0 : async_walkdir_DirEntry
    | US9_1 of f1_0 : std_string_String
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
and [<Struct>] US12 =
    | US12_0 of f0_0 : (string [])
    | US12_1 of f1_0 : string
and UH1 =
    | UH1_0
    | UH1_1 of string * UH1
and [<Struct>] US13 =
    | US13_0 of f0_0 : UH1 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US13_1 of f1_0 : string
and [<Struct>] US14 =
    | US14_0 of f0_0 : char * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US14_1 of f1_0 : string
and [<Struct>] US15 =
    | US15_0 of f0_0 : char
    | US15_1
and [<Struct>] US16 =
    | US16_0 of f0_0 : string * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US16_1 of f1_0 : string
and UH2 =
    | UH2_0
    | UH2_1 of (struct (string * System.Text.StringBuilder * int32 * int32) -> US16) * UH2
and [<Struct>] US17 =
    | US17_0 of f0_0 : string * f0_1 : System.Text.StringBuilder * f0_2 : int32 * f0_3 : int32
    | US17_1 of f1_0 : string
and [<Struct>] US18 =
    | US18_0 of f0_0 : (string [])
    | US18_1 of f1_0 : string
and [<Struct>] US19 =
    | US19_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>
    | US19_1 of f1_0 : std_string_String
and [<Struct>] US20 =
    | US20_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>
    | US20_1
and [<Struct>] US21 =
    | US21_0 of f0_0 : std_string_String
    | US21_1 of f1_0 : std_string_String
and [<Struct>] US22 =
    | US22_0 of f0_0 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit)
    | US22_1
and [<Struct>] US23 =
    | US23_0 of f0_0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>
    | US23_1
and [<Struct>] US24 =
    | US24_0 of f0_0 : std_process_Output
    | US24_1 of f1_0 : std_string_String
and [<Struct>] US25 =
    | US25_0 of f0_0 : (struct (bool * string * int32) -> Async<unit>)
    | US25_1
and [<Struct>] US26 =
    | US26_0 of f0_0 : System.Threading.CancellationToken
    | US26_1
and [<Struct>] US27 =
    | US27_0 of f0_0 : Result<string, (string * string)>
    | US27_1
and UH4 =
    | UH4_0
    | UH4_1 of string * string * (string -> (string -> US27)) * UH4
and UH3 =
    | UH3_0
    | UH3_1 of UH4 * UH3
and [<Struct>] US28 =
    | US28_0 of f0_0 : string
    | US28_1 of f1_0 : std_string_String
and [<Struct>] US29 =
    | US29_0 of f0_0 : int32 * f0_1 : string
    | US29_1 of f1_0 : int32 * f1_1 : string
and Mut6 = {mutable l0 : int32; mutable l1 : int32}
and Mut7 = {mutable l0 : int32; mutable l1 : string; mutable l2 : int32; mutable l3 : int32}
and Mut8 = {mutable l0 : int32; mutable l1 : Vec<Result<string, (string * string)> option>}
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
    let v56 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v54, 's') v55 
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
and method1 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method3 () : string =
    let v0 : string = ""
    v0
and method2 (v0 : string) : string =
    let v1 : bool = true
    let mutable _v1 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "std::env::var(&*$0)"
    let v3 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "true; let _result = $0.map(|x| { //"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "x"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v6 
    let v8 : string = "fable_library_rust::String_::fromString($0)"
    let v9 : string = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "true; $0 })"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "_result"
    let v13 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = method3()
    let v15 : string = "$0.unwrap_or($1)"
    let v16 : string = Fable.Core.RustInterop.emitRustExpr struct (v13, v14) v15 
    v16 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = "std::env::var(&*$0)"
    let v18 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v17 
    let v19 : string = "true; let _result = $0.map(|x| { //"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "x"
    let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v21 
    let v23 : string = "fable_library_rust::String_::fromString($0)"
    let v24 : string = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "true; $0 })"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let v27 : string = "_result"
    let v28 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = method3()
    let v30 : string = "$0.unwrap_or($1)"
    let v31 : string = Fable.Core.RustInterop.emitRustExpr struct (v28, v29) v30 
    v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "std::env::var(&*$0)"
    let v33 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v32 
    let v34 : string = "true; let _result = $0.map(|x| { //"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let v36 : string = "x"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let v40 : string = "true; $0 })"
    let v41 : bool = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "_result"
    let v43 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : string = method3()
    let v45 : string = "$0.unwrap_or($1)"
    let v46 : string = Fable.Core.RustInterop.emitRustExpr struct (v43, v44) v45 
    v46 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v47 : string = "process.env[$0]"
    let v48 : string = Fable.Core.JsInterop.emitJsExpr v0 v47 
    v48 
    #endif
#if FABLE_COMPILER_PYTHON
    let v49 : string = "os"
    let v50 : IOsEnviron = Fable.Core.PyInterop.importAll v49 
    let v51 : string = "v50.environ"
    let v52 : obj = Fable.Core.PyInterop.emitPyExpr () v51 
    let v53 : string = "v52.get($0)"
    let v54 : string = Fable.Core.PyInterop.emitPyExpr v0 v53 
    v54 
    #endif
#else
    let v55 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v56 : string = v55 v0
    let mutable _v56 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v57 : (string -> string option) = Option.ofObj
    let v58 : string option = v57 v56
    v58 
    #else
    Some v56 
    #endif
    |> fun x -> _v56 <- Some x
    let v59 : string option = match _v56 with Some x -> x | None -> failwith "optionm'.of_obj / _v56=None"
    let v60 : US3 option = None
    let _v60 = ref v60 
    match v59 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v61 : string = x
    let v62 : US3 = US3_0(v61)
    v62 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v60.Value <- x
    let v63 : US3 option = _v60.Value 
    let v64 : US3 = US3_1
    let v65 : US3 = v63 |> Option.defaultValue v64 
    let v69 : string =
        match v65 with
        | US3_1 -> (* None *)
            let v67 : string = ""
            v67
        | US3_0(v66) -> (* Some *)
            v66
    v69 
    #endif
    |> fun x -> _v1 <- Some x
    let v70 : string = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v70
and method4 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure3 () (v0 : string) : unit =
    ()
and closure2 () (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3) =
    let v1 : bool = true
    let mutable _v1 : struct (US1 * US2) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method1()
    let v3 : string = method2(v2)
    let v4 : bool = "Verbose" = v3
    let v24 : US2 =
        if v4 then
            let v5 : US0 = US0_0
            US2_0(v5)
        else
            let v7 : bool = "Debug" = v3
            if v7 then
                let v8 : US0 = US0_1
                US2_0(v8)
            else
                let v10 : bool = "Info" = v3
                if v10 then
                    let v11 : US0 = US0_2
                    US2_0(v11)
                else
                    let v13 : bool = "Warning" = v3
                    if v13 then
                        let v14 : US0 = US0_3
                        US2_0(v14)
                    else
                        let v16 : bool = "Critical" = v3
                        if v16 then
                            let v17 : US0 = US0_4
                            US2_0(v17)
                        else
                            US2_1
    let v25 : string = method4()
    let v26 : string = method2(v25)
    let v28 : bool = v26 = "True"
    let v34 : US1 =
        if v28 then
            let v29 : System.DateTime = System.DateTime.Now
            let v30 : (System.DateTime -> int64) = _.Ticks
            let v31 : int64 = v30 v29
            US1_0(v31)
        else
            US1_1
    struct (v34, v24) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v35 : US1 = US1_1
    let v36 : US2 = US2_1
    struct (v35, v36) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v37 : US1 = US1_1
    let v38 : US2 = US2_1
    struct (v37, v38) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v39 : string = method1()
    let v40 : string = method2(v39)
    let v41 : bool = "Verbose" = v40
    let v61 : US2 =
        if v41 then
            let v42 : US0 = US0_0
            US2_0(v42)
        else
            let v44 : bool = "Debug" = v40
            if v44 then
                let v45 : US0 = US0_1
                US2_0(v45)
            else
                let v47 : bool = "Info" = v40
                if v47 then
                    let v48 : US0 = US0_2
                    US2_0(v48)
                else
                    let v50 : bool = "Warning" = v40
                    if v50 then
                        let v51 : US0 = US0_3
                        US2_0(v51)
                    else
                        let v53 : bool = "Critical" = v40
                        if v53 then
                            let v54 : US0 = US0_4
                            US2_0(v54)
                        else
                            US2_1
    let v62 : string = method4()
    let v63 : string = method2(v62)
    let v65 : bool = v63 = "True"
    let v71 : US1 =
        if v65 then
            let v66 : System.DateTime = System.DateTime.Now
            let v67 : (System.DateTime -> int64) = _.Ticks
            let v68 : int64 = v67 v66
            US1_0(v68)
        else
            US1_1
    struct (v71, v61) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v72 : string = method1()
    let v73 : string = method2(v72)
    let v74 : bool = "Verbose" = v73
    let v94 : US2 =
        if v74 then
            let v75 : US0 = US0_0
            US2_0(v75)
        else
            let v77 : bool = "Debug" = v73
            if v77 then
                let v78 : US0 = US0_1
                US2_0(v78)
            else
                let v80 : bool = "Info" = v73
                if v80 then
                    let v81 : US0 = US0_2
                    US2_0(v81)
                else
                    let v83 : bool = "Warning" = v73
                    if v83 then
                        let v84 : US0 = US0_3
                        US2_0(v84)
                    else
                        let v86 : bool = "Critical" = v73
                        if v86 then
                            let v87 : US0 = US0_4
                            US2_0(v87)
                        else
                            US2_1
    let v95 : string = method4()
    let v96 : string = method2(v95)
    let v98 : bool = v96 = "True"
    let v104 : US1 =
        if v98 then
            let v99 : System.DateTime = System.DateTime.Now
            let v100 : (System.DateTime -> int64) = _.Ticks
            let v101 : int64 = v100 v99
            US1_0(v101)
        else
            US1_1
    struct (v104, v94) 
    #endif
#else
    let v105 : string = method1()
    let v106 : string = method2(v105)
    let v107 : bool = "Verbose" = v106
    let v127 : US2 =
        if v107 then
            let v108 : US0 = US0_0
            US2_0(v108)
        else
            let v110 : bool = "Debug" = v106
            if v110 then
                let v111 : US0 = US0_1
                US2_0(v111)
            else
                let v113 : bool = "Info" = v106
                if v113 then
                    let v114 : US0 = US0_2
                    US2_0(v114)
                else
                    let v116 : bool = "Warning" = v106
                    if v116 then
                        let v117 : US0 = US0_3
                        US2_0(v117)
                    else
                        let v119 : bool = "Critical" = v106
                        if v119 then
                            let v120 : US0 = US0_4
                            US2_0(v120)
                        else
                            US2_1
    let v128 : string = method4()
    let v129 : string = method2(v128)
    let v131 : bool = v129 = "True"
    let v137 : US1 =
        if v131 then
            let v132 : System.DateTime = System.DateTime.Now
            let v133 : (System.DateTime -> int64) = _.Ticks
            let v134 : int64 = v133 v132
            US1_0(v134)
        else
            US1_1
    struct (v137, v127) 
    #endif
    |> fun x -> _v1 <- Some x
    let struct (v138 : US1, v139 : US2) = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    let v140 : Mut1 = {l0 = true} : Mut1
    let v141 : Mut0 = {l0 = 0L} : Mut0
    let v144 : US0 =
        match v139 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v142) -> (* Some *)
            v142
    let v145 : Mut2 = {l0 = v144} : Mut2
    let v146 : (string -> unit) = closure3()
    let v147 : Mut3 = {l0 = v146} : Mut3
    let v152 : int64 option =
        match v138 with
        | US1_1 -> (* None *)
            let v150 : int64 option = None
            v150
        | US1_0(v148) -> (* Some *)
            let v149 : int64 option = Some v148 
            v149
    struct (v141, v140, v145, v152, v147)
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
and method6 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method7 () : string =
    let v0 : string = ""
    v0
and method8 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and closure7 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (US0 -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure2()
    let v4 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v3 v4 |> Some
    let struct (v5 : Mut0, v6 : Mut1, v7 : Mut2, v8 : int64 option, v9 : Mut3) = State.trace_state.Value
    let v10 : bool = true
    let mutable _v10 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : US1 option = None
    let _v11 = ref v11 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v12 : int64 = x
    let v13 : US1 = US1_0(v12)
    v13 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v11.Value <- x
    let v14 : US1 option = _v11.Value 
    let v15 : US1 = US1_1
    let v16 : US1 = v14 |> Option.defaultValue v15 
    let v35 : System.DateTime =
        match v16 with
        | US1_1 -> (* None *)
            let v33 : System.DateTime = System.DateTime.Now
            v33
        | US1_0(v17) -> (* Some *)
            let v18 : System.DateTime = System.DateTime.Now
            let v19 : (System.DateTime -> int64) = _.Ticks
            let v20 : int64 = v19 v18
            let v21 : int64 = v20 - v17
            let v22 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v23 : System.TimeSpan = v22 v21
            let v24 : (System.TimeSpan -> int32) = _.Hours
            let v25 : int32 = v24 v23
            let v26 : (System.TimeSpan -> int32) = _.Minutes
            let v27 : int32 = v26 v23
            let v28 : (System.TimeSpan -> int32) = _.Seconds
            let v29 : int32 = v28 v23
            let v30 : (System.TimeSpan -> int32) = _.Milliseconds
            let v31 : int32 = v30 v23
            let v32 : System.DateTime = System.DateTime (1, 1, 1, v25, v27, v29, v31)
            v32
    let v36 : string = method6()
    let v37 : string = v35.ToString v36 
    v37 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v38 : US1 option = None
    let _v38 = ref v38 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US1 = US1_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US1 option = _v38.Value 
    let v42 : US1 = US1_1
    let v43 : US1 = v41 |> Option.defaultValue v42 
    let v62 : System.DateTime =
        match v43 with
        | US1_1 -> (* None *)
            let v60 : System.DateTime = System.DateTime.Now
            v60
        | US1_0(v44) -> (* Some *)
            let v45 : System.DateTime = System.DateTime.Now
            let v46 : (System.DateTime -> int64) = _.Ticks
            let v47 : int64 = v46 v45
            let v48 : int64 = v47 - v44
            let v49 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v50 : System.TimeSpan = v49 v48
            let v51 : (System.TimeSpan -> int32) = _.Hours
            let v52 : int32 = v51 v50
            let v53 : (System.TimeSpan -> int32) = _.Minutes
            let v54 : int32 = v53 v50
            let v55 : (System.TimeSpan -> int32) = _.Seconds
            let v56 : int32 = v55 v50
            let v57 : (System.TimeSpan -> int32) = _.Milliseconds
            let v58 : int32 = v57 v50
            let v59 : System.DateTime = System.DateTime (1, 1, 1, v52, v54, v56, v58)
            v59
    let v63 : string = method6()
    let v64 : string = v62.ToString v63 
    v64 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = method7()
    v65 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v66 : US1 option = None
    let _v66 = ref v66 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v67 : int64 = x
    let v68 : US1 = US1_0(v67)
    v68 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v66.Value <- x
    let v69 : US1 option = _v66.Value 
    let v70 : US1 = US1_1
    let v71 : US1 = v69 |> Option.defaultValue v70 
    let v90 : System.DateTime =
        match v71 with
        | US1_1 -> (* None *)
            let v88 : System.DateTime = System.DateTime.Now
            v88
        | US1_0(v72) -> (* Some *)
            let v73 : System.DateTime = System.DateTime.Now
            let v74 : (System.DateTime -> int64) = _.Ticks
            let v75 : int64 = v74 v73
            let v76 : int64 = v75 - v72
            let v77 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v78 : System.TimeSpan = v77 v76
            let v79 : (System.TimeSpan -> int32) = _.Hours
            let v80 : int32 = v79 v78
            let v81 : (System.TimeSpan -> int32) = _.Minutes
            let v82 : int32 = v81 v78
            let v83 : (System.TimeSpan -> int32) = _.Seconds
            let v84 : int32 = v83 v78
            let v85 : (System.TimeSpan -> int32) = _.Milliseconds
            let v86 : int32 = v85 v78
            let v87 : System.DateTime = System.DateTime (1, 1, 1, v80, v82, v84, v86)
            v87
    let v91 : string = method8()
    let v92 : string = v90.ToString v91 
    v92 
    #endif
#if FABLE_COMPILER_PYTHON
    let v93 : US1 option = None
    let _v93 = ref v93 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v94 : int64 = x
    let v95 : US1 = US1_0(v94)
    v95 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v93.Value <- x
    let v96 : US1 option = _v93.Value 
    let v97 : US1 = US1_1
    let v98 : US1 = v96 |> Option.defaultValue v97 
    let v117 : System.DateTime =
        match v98 with
        | US1_1 -> (* None *)
            let v115 : System.DateTime = System.DateTime.Now
            v115
        | US1_0(v99) -> (* Some *)
            let v100 : System.DateTime = System.DateTime.Now
            let v101 : (System.DateTime -> int64) = _.Ticks
            let v102 : int64 = v101 v100
            let v103 : int64 = v102 - v99
            let v104 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v105 : System.TimeSpan = v104 v103
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v105
            let v108 : (System.TimeSpan -> int32) = _.Minutes
            let v109 : int32 = v108 v105
            let v110 : (System.TimeSpan -> int32) = _.Seconds
            let v111 : int32 = v110 v105
            let v112 : (System.TimeSpan -> int32) = _.Milliseconds
            let v113 : int32 = v112 v105
            let v114 : System.DateTime = System.DateTime (1, 1, 1, v107, v109, v111, v113)
            v114
    let v118 : string = method8()
    let v119 : string = v117.ToString v118 
    v119 
    #endif
#else
    let v120 : US1 option = None
    let _v120 = ref v120 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v121 : int64 = x
    let v122 : US1 = US1_0(v121)
    v122 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v120.Value <- x
    let v123 : US1 option = _v120.Value 
    let v124 : US1 = US1_1
    let v125 : US1 = v123 |> Option.defaultValue v124 
    let v144 : System.DateTime =
        match v125 with
        | US1_1 -> (* None *)
            let v142 : System.DateTime = System.DateTime.Now
            v142
        | US1_0(v126) -> (* Some *)
            let v127 : System.DateTime = System.DateTime.Now
            let v128 : (System.DateTime -> int64) = _.Ticks
            let v129 : int64 = v128 v127
            let v130 : int64 = v129 - v126
            let v131 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v132 : System.TimeSpan = v131 v130
            let v133 : (System.TimeSpan -> int32) = _.Hours
            let v134 : int32 = v133 v132
            let v135 : (System.TimeSpan -> int32) = _.Minutes
            let v136 : int32 = v135 v132
            let v137 : (System.TimeSpan -> int32) = _.Seconds
            let v138 : int32 = v137 v132
            let v139 : (System.TimeSpan -> int32) = _.Milliseconds
            let v140 : int32 = v139 v132
            let v141 : System.DateTime = System.DateTime (1, 1, 1, v134, v136, v138, v140)
            v141
    let v145 : string = method8()
    let v146 : string = v144.ToString v145 
    v146 
    #endif
    |> fun x -> _v10 <- Some x
    let v147 : string = match _v10 with Some x -> x | None -> failwith "base.run_target / _v10=None"
    let v157 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v152 : string = "Critical"
            v152
        | US0_1 -> (* Debug *)
            let v149 : string = "Debug"
            v149
        | US0_2 -> (* Info *)
            let v150 : string = "Info"
            v150
        | US0_0 -> (* Verbose *)
            let v148 : string = "Verbose"
            v148
        | US0_3 -> (* Warning *)
            let v151 : string = "Warning"
            v151
    let v158 : (unit -> string) = v157.ToLower
    let v159 : string = v158 ()
    let v160 : string = v159.PadLeft (7, ' ')
    let v161 : bool = true
    let mutable _v161 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v176 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v170 : string = "inline_colorization::color_bright_red"
            let v171 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v170 
            v171
        | US0_1 -> (* Debug *)
            let v164 : string = "inline_colorization::color_bright_blue"
            let v165 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v164 
            v165
        | US0_2 -> (* Info *)
            let v166 : string = "inline_colorization::color_bright_green"
            let v167 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v166 
            v167
        | US0_0 -> (* Verbose *)
            let v162 : string = "inline_colorization::color_bright_black"
            let v163 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v162 
            v163
        | US0_3 -> (* Warning *)
            let v168 : string = "inline_colorization::color_yellow"
            let v169 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v168 
            v169
    let v177 : string = "&*$0"
    let v178 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v160 v177 
    let v179 : string = "inline_colorization::color_reset"
    let v180 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v179 
    let v181 : string = "\"{v176}{v178}{v180}\""
    let v182 : string = @$"format!(" + v181 + ")"
    let v183 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v182 
    let v184 : string = "fable_library_rust::String_::fromString($0)"
    let v185 : string = Fable.Core.RustInterop.emitRustExpr v183 v184 
    v185 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v200 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v194 : string = "inline_colorization::color_bright_red"
            let v195 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v194 
            v195
        | US0_1 -> (* Debug *)
            let v188 : string = "inline_colorization::color_bright_blue"
            let v189 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v188 
            v189
        | US0_2 -> (* Info *)
            let v190 : string = "inline_colorization::color_bright_green"
            let v191 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v190 
            v191
        | US0_0 -> (* Verbose *)
            let v186 : string = "inline_colorization::color_bright_black"
            let v187 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v186 
            v187
        | US0_3 -> (* Warning *)
            let v192 : string = "inline_colorization::color_yellow"
            let v193 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v192 
            v193
    let v201 : string = "&*$0"
    let v202 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v160 v201 
    let v203 : string = "inline_colorization::color_reset"
    let v204 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v203 
    let v205 : string = "\"{v200}{v202}{v204}\""
    let v206 : string = @$"format!(" + v205 + ")"
    let v207 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v206 
    let v208 : string = "fable_library_rust::String_::fromString($0)"
    let v209 : string = Fable.Core.RustInterop.emitRustExpr v207 v208 
    v209 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v224 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v218 : string = "inline_colorization::color_bright_red"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v218 
            v219
        | US0_1 -> (* Debug *)
            let v212 : string = "inline_colorization::color_bright_blue"
            let v213 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v212 
            v213
        | US0_2 -> (* Info *)
            let v214 : string = "inline_colorization::color_bright_green"
            let v215 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v214 
            v215
        | US0_0 -> (* Verbose *)
            let v210 : string = "inline_colorization::color_bright_black"
            let v211 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v210 
            v211
        | US0_3 -> (* Warning *)
            let v216 : string = "inline_colorization::color_yellow"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v216 
            v217
    let v225 : string = "&*$0"
    let v226 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v160 v225 
    let v227 : string = "inline_colorization::color_reset"
    let v228 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v227 
    let v229 : string = "\"{v224}{v226}{v228}\""
    let v230 : string = @$"format!(" + v229 + ")"
    let v231 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v230 
    let v232 : string = "fable_library_rust::String_::fromString($0)"
    let v233 : string = Fable.Core.RustInterop.emitRustExpr v231 v232 
    v233 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v160 
    #endif
#if FABLE_COMPILER_PYTHON
    v160 
    #endif
#else
    v160 
    #endif
    |> fun x -> _v161 <- Some x
    let v234 : string = match _v161 with Some x -> x | None -> failwith "base.run_target / _v161=None"
    let v235 : int64 = v5.l0
    let v236 : string = $"{v147} {v234} #{v235} %s{v1 ()} / %s{v2 ()}"
    let v237 : (char []) = [||]
    let v238 : string = v236.TrimStart v237 
    let v239 : (char []) = [|' '; '/'|]
    let v240 : string = v238.TrimEnd v239 
    v240
and method9 (v0 : US0, v1 : (unit -> string)) : unit =
    let v2 : (US0 -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure2()
    let v3 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v2 v3 |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut2, v7 : int64 option, v8 : Mut3) = State.trace_state.Value
    let v9 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v2 v9 |> Some
    let struct (v10 : Mut0, v11 : Mut1, v12 : Mut2, v13 : int64 option, v14 : Mut3) = State.trace_state.Value
    let v15 : US0 = v12.l0
    let v16 : bool = v11.l0
    let v17 : bool = v16 = false
    let v21 : bool =
        if v17 then
            false
        else
            let v18 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
            let v19 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v15
            let v20 : bool = v18 >= v19
            v20
    if v21 then
        let v22 : int64 = v4.l0
        let v23 : int64 = v22 + 1L
        v4.l0 <- v23
        let v24 : string = $"%s{v1 ()}"
        let v25 : bool = true
        let mutable _v25 : unit option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v26 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v24 v26 
        () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v27 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v24 v27 
        () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v28 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v24 v28 
        () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v24 
        () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v24 
        () 
        #endif
#else
        System.Console.WriteLine v24 
        () 
        #endif
        |> fun x -> _v25 <- Some x
        match _v25 with Some x -> x | None -> failwith "base.run_target / _v25=None"
        let v29 : (string -> unit) = v8.l0
        v29 v24
and method5 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> string) = closure7(v0, v1, v2)
    method9(v0, v3)
and method10 () : string =
    let v0 : string = "source-dir"
    v0
and method11 () : string =
    let v0 : string = "dist-dir"
    v0
and method12 () : string =
    let v0 : string = "cache-dir"
    v0
and method13 () : string =
    let v0 : string = "hangul-spec"
    v0
and method17 (v0 : string) : string =
    v0
and method16 (v0 : string, v1 : string) : struct (string * string) =
    let v2 : string = method17(v0)
    struct (v1, v2)
and method15 (v0 : string, v1 : string) : string =
    let v2 : bool = true
    let mutable _v2 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "&*$0"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let v5 : string = "String::from($0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "std::path::PathBuf::from($0)"
    let v8 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : string = "&*$0"
    let v10 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1 v9 
    let v11 : string = "String::from($0)"
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : string = "$0.join($1)"
    let v14 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v8, v12) v13 
    let v15 : string = "$0.display()"
    let v16 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v14 v15 
    let v17 : bool = true
    let mutable _v17 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = "format!(\"{}\", $0)"
    let v19 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v18 
    v19 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = "format!(\"{}\", $0)"
    let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v20 
    v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = "format!(\"{}\", $0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v16 v22 
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
    |> fun x -> _v17 <- Some x
    let v27 : std_string_String = match _v17 with Some x -> x | None -> failwith "base.run_target / _v17=None"
    let v28 : string = "fable_library_rust::String_::fromString($0)"
    let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28 
    v29 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : US5 = US5_1
    let v31 : US6 = US6_0(v30)
    let v32 : string = $"file_system.(</>) / target: {v31} / a: {v0} / b: {v1}"
    let v33 : string = failwith<string> v32
    v33 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = null |> unbox<string>
    v34 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v35 : string = "path"
    let v36 : IPathJoin = Fable.Core.JsInterop.importAll v35 
    let struct (v37 : string, v38 : string) = method16(v1, v0)
    let v39 : string = "v36.join($0, $1)"
    let v40 : string = Fable.Core.JsInterop.emitJsExpr struct (v37, v38) v39 
    v40 
    #endif
#if FABLE_COMPILER_PYTHON
    let v41 : US5 = US5_0
    let v42 : US6 = US6_3(v41)
    let v43 : string = $"file_system.(</>) / target: {v42} / a: {v0} / b: {v1}"
    let v44 : string = failwith<string> v43
    v44 
    #endif
#else
    let v45 : string = System.IO.Path.Combine (v0, v1)
    v45 
    #endif
    |> fun x -> _v2 <- Some x
    let v46 : string = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v46
and method19 (v0 : string) : bool =
    let v1 : bool = true
    let mutable _v1 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "&*$0"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "std::path::PathBuf::from($0)"
    let v7 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "$0.exists()"
    let v9 : bool = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v15 : bool =
        if v9 then
            true
        else
            let v10 : string = "$0.is_dir()"
            let v11 : bool = Fable.Core.RustInterop.emitRustExpr v7 v10 
            if v11 then
                true
            else
                let v12 : string = "$0.is_symlink()"
                let v13 : bool = Fable.Core.RustInterop.emitRustExpr v7 v12 
                v13
    v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : bool = null |> unbox<bool>
    v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17 : bool = null |> unbox<bool>
    v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : string = "fs"
    let v19 : IFsExistsSync = Fable.Core.JsInterop.importAll v18 
    let v20 : string = "$0.existsSync($1)"
    let v21 : bool = Fable.Core.JsInterop.emitJsExpr struct (v19, v0) v20 
    v21 
    #endif
#if FABLE_COMPILER_PYTHON
    let v22 : bool = null |> unbox<bool>
    v22 
    #endif
#else
    let v23 : (string -> bool) = System.IO.Directory.Exists
    let v24 : bool = v23 v0
    v24 
    #endif
    |> fun x -> _v1 <- Some x
    let v25 : bool = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v25
and method21 (v0 : string) : string option =
    let v1 : bool = true
    let mutable _v1 : US3 option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "&*$0"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "std::path::PathBuf::from($0)"
    let v7 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "$0.parent().map(std::path::PathBuf::from)"
    let v9 : std_path_PathBuf option = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "$0?"
    let v11 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "$0.display()"
    let v13 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : bool = true
    let mutable _v14 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = "format!(\"{}\", $0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v15 
    v16 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = "format!(\"{}\", $0)"
    let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v17 
    v18 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : string = "format!(\"{}\", $0)"
    let v20 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v19 
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
#else
    let v23 : std_string_String = null |> unbox<std_string_String>
    v23 
    #endif
    |> fun x -> _v14 <- Some x
    let v24 : std_string_String = match _v14 with Some x -> x | None -> failwith "base.run_target / _v14=None"
    let v25 : string = "fable_library_rust::String_::fromString($0)"
    let v26 : string = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let v27 : US3 = US3_0(v26)
    v27 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v28 : US3 = null |> unbox<US3>
    v28 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : US3 = null |> unbox<US3>
    v29 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v30 : string = "path"
    let v31 : IPathDirname = Fable.Core.JsInterop.importAll v30 
    let v32 : string = "v31.dirname($0)"
    let v33 : string = Fable.Core.JsInterop.emitJsExpr v0 v32 
    let v34 : US3 = US3_0(v33)
    v34 
    #endif
#if FABLE_COMPILER_PYTHON
    let v35 : US3 = null |> unbox<US3>
    v35 
    #endif
#else
    let v36 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.GetParent
    let v37 : System.IO.DirectoryInfo = v36 v0
    let v38 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let v39 : bool = v37 = v38 
    let v50 : US3 =
        if v39 then
            US3_1
        else
            let v41 : bool = true
            let mutable _v41 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v42 : string = null |> unbox<string>
            v42 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v43 : string = null |> unbox<string>
            v43 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v44 : string = null |> unbox<string>
            v44 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v45 : string = null |> unbox<string>
            v45 
            #endif
#if FABLE_COMPILER_PYTHON
            let v46 : string = null |> unbox<string>
            v46 
            #endif
#else
            let v47 : string = v37.FullName
            v47 
            #endif
            |> fun x -> _v41 <- Some x
            let v48 : string = match _v41 with Some x -> x | None -> failwith "base.run_target / _v41=None"
            US3_0(v48)
    v50 
    #endif
    |> fun x -> _v1 <- Some x
    let v51 : US3 = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    match v51 with
    | US3_1 -> (* None *)
        let v54 : string option = None
        v54
    | US3_0(v52) -> (* Some *)
        let v53 : string option = Some v52 
        v53
and closure8 () (v0 : string) : string option =
    method21(v0)
and method20 () : (string -> string option) =
    closure8()
and method22 (v0 : string, v1 : string, v2 : string) : string =
    let v3 : string = method15(v2, v0)
    let v4 : bool = method19(v3)
    if v4 then
        v2
    else
        let v5 : (string -> string option) = method20()
        let v6 : string option = v5 v2
        let v7 : US3 option = None
        let _v7 = ref v7 
        match v6 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v8 : string = x
        let v9 : US3 = US3_0(v8)
        v9 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v7.Value <- x
        let v10 : US3 option = _v7.Value 
        let v11 : US3 = US3_1
        let v12 : US3 = v10 |> Option.defaultValue v11 
        match v12 with
        | US3_1 -> (* None *)
            let v15 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            failwith<string> v15
        | US3_0(v13) -> (* Some *)
            method22(v0, v1, v13)
and method18 (v0 : string, v1 : string) : string =
    let v2 : string = method15(v1, v0)
    let v3 : bool = method19(v2)
    if v3 then
        v1
    else
        let v4 : (string -> string option) = method20()
        let v5 : string option = v4 v1
        let v6 : US3 option = None
        let _v6 = ref v6 
        match v5 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v7 : string = x
        let v8 : US3 = US3_0(v7)
        v8 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v6.Value <- x
        let v9 : US3 option = _v6.Value 
        let v10 : US3 = US3_1
        let v11 : US3 = v9 |> Option.defaultValue v10 
        match v11 with
        | US3_1 -> (* None *)
            let v14 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            failwith<string> v14
        | US3_0(v12) -> (* Some *)
            method22(v0, v1, v12)
and method24 (v0 : string) : string =
    v0
and method25 () : string =
    let v0 : bool = true
    let mutable _v0 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = "std::env::current_dir()"
    let v2 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = "$0.unwrap()"
    let v4 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "$0.display()"
    let v6 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : bool = true
    let mutable _v7 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v8 
    v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : string = "format!(\"{}\", $0)"
    let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v10 
    v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = "format!(\"{}\", $0)"
    let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v12 
    v13 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : std_string_String = null |> unbox<std_string_String>
    v14 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : std_string_String = null |> unbox<std_string_String>
    v15 
    #endif
#else
    let v16 : std_string_String = null |> unbox<std_string_String>
    v16 
    #endif
    |> fun x -> _v7 <- Some x
    let v17 : std_string_String = match _v7 with Some x -> x | None -> failwith "base.run_target / _v7=None"
    let v18 : string = "fable_library_rust::String_::fromString($0)"
    let v19 : string = Fable.Core.RustInterop.emitRustExpr v17 v18 
    v19 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v21 : string = v20 ()
    v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = null |> unbox<string>
    v22 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v23 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v24 : string = v23 ()
    v24 
    #endif
#if FABLE_COMPILER_PYTHON
    let v25 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v26 : string = v25 ()
    v26 
    #endif
#else
    let v27 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v28 : string = v27 ()
    v28 
    #endif
    |> fun x -> _v0 <- Some x
    let v29 : string = match _v0 with Some x -> x | None -> failwith "base.run_target / _v0=None"
    v29
and method26 () : string =
    let v0 : string = ""
    v0
and method27 (v0 : string) : string =
    v0
and method28 () : string =
    let v0 : string = "^\\\\\\\\\\?\\\\"
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
and method23 (v0 : string) : string =
    let v1 : bool = true
    let mutable _v1 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method24(v0)
    let v3 : string = "&*$0"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "String::from($0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "std::path::PathBuf::from($0)"
    let v8 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : string = "$0.exists()"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr v8 v9 
    let v11 : bool = v10 = false
    let v132 : string =
        if v11 then
            let v12 : string = method25()
            let v13 : string = method15(v12, v2)
            let v14 : string = method26()
            let v15 : bool = true
            let mutable _v15 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16 : string = method27(v13)
            let v17 : string = $"regex::Regex::new(&$0)"
            let v18 : string = "^\\\\\\\\\\?\\\\"
            let v19 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v18 v17 
            let v20 : string = "$0.unwrap()"
            let v21 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v19 v20 
            let v22 : string = $"$0.replace_all(&$1, &*$2)"
            let v23 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v21, v16, v14) v22 
            let v24 : string = "String::from($0)"
            let v25 : std_string_String = Fable.Core.RustInterop.emitRustExpr v23 v24 
            let v26 : string = "fable_library_rust::String_::fromString($0)"
            let v27 : string = Fable.Core.RustInterop.emitRustExpr v25 v26 
            v27 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v28 : string = null |> unbox<string>
            v28 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v29 : string = null |> unbox<string>
            v29 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v30 : string = null |> unbox<string>
            v30 
            #endif
#if FABLE_COMPILER_PYTHON
            let v31 : string = null |> unbox<string>
            v31 
            #endif
#else
            let v32 : string = method28()
            let v33 : string = System.Text.RegularExpressions.Regex.Replace (v13, v32, v14)
            v33 
            #endif
            |> fun x -> _v15 <- Some x
            let v34 : string = match _v15 with Some x -> x | None -> failwith "base.run_target / _v15=None"
            let v35 : string = $"{v34.[0] |> string |> _.ToLower()}{v34.[1..]}"
            let v36 : string = "\\"
            let v37 : string = "/"
            let v38 : string = v35.Replace (v36, v37)
            let v39 : (string []) = v38.Split v37 
            let v40 : (string []) = [||]
            let v41 : int32 = v39.Length
            let v42 : Mut4 = {l0 = 0; l1 = 0; l2 = v40} : Mut4
            while method29(v41, v42) do
                let v44 : int32 = v42.l0
                let v45 : int32 =  -v44
                let v46 : int32 = v45 + v41
                let v47 : int32 = v46 - 1
                let struct (v48 : int32, v49 : (string [])) = v42.l1, v42.l2
                let v50 : string = v39.[int v47]
                let v51 : bool = ".." = v50
                let struct (v93 : int32, v94 : (string [])) =
                    if v51 then
                        let v52 : int32 = v48 + 1
                        struct (v52, v49)
                    else
                        let v53 : bool = "." = v50
                        if v53 then
                            struct (v48, v49)
                        else
                            let v54 : bool = 0 = v48
                            if v54 then
                                let v55 : string = ":"
                                let v56 : bool = v50.EndsWith v55 
                                if v56 then
                                    let v57 : string = $"{v12.[0]}:"
                                    let v58 : (string []) = [|v57|]
                                    let v59 : int32 = v58.Length
                                    let v60 : int32 = v49.Length
                                    let v61 : int32 = v59 + v60
                                    let v62 : (string []) = Array.zeroCreate<string> (v61)
                                    let v63 : Mut5 = {l0 = 0} : Mut5
                                    while method30(v61, v63) do
                                        let v65 : int32 = v63.l0
                                        let v66 : bool = v65 < v59
                                        let v70 : string =
                                            if v66 then
                                                let v67 : string = v58.[int v65]
                                                v67
                                            else
                                                let v68 : int32 = v65 - v59
                                                let v69 : string = v49.[int v68]
                                                v69
                                        v62.[int v65] <- v70
                                        let v71 : int32 = v65 + 1
                                        v63.l0 <- v71
                                        ()
                                    struct (0, v62)
                                else
                                    let v72 : (string []) = [|v50|]
                                    let v73 : int32 = v72.Length
                                    let v74 : int32 = v49.Length
                                    let v75 : int32 = v73 + v74
                                    let v76 : (string []) = Array.zeroCreate<string> (v75)
                                    let v77 : Mut5 = {l0 = 0} : Mut5
                                    while method30(v75, v77) do
                                        let v79 : int32 = v77.l0
                                        let v80 : bool = v79 < v73
                                        let v84 : string =
                                            if v80 then
                                                let v81 : string = v72.[int v79]
                                                v81
                                            else
                                                let v82 : int32 = v79 - v73
                                                let v83 : string = v49.[int v82]
                                                v83
                                        v76.[int v79] <- v84
                                        let v85 : int32 = v79 + 1
                                        v77.l0 <- v85
                                        ()
                                    struct (0, v76)
                            else
                                let v88 : int32 = v48 - 1
                                struct (v88, v49)
                let v95 : int32 = v44 + 1
                v42.l0 <- v95
                v42.l1 <- v93
                v42.l2 <- v94
                ()
            let struct (v96 : int32, v97 : (string [])) = v42.l1, v42.l2
            let v98 : string seq = seq { for i = 0 to v97.Length - 1 do yield v97.[i] }
            let v99 : bool = true
            let mutable _v99 : char option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v100 : string = "std::path::MAIN_SEPARATOR"
            let v101 : char = Fable.Core.RustInterop.emitRustExpr () v100 
            v101 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v102 : char = System.IO.Path.DirectorySeparatorChar
            v102 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v103 : char = System.IO.Path.DirectorySeparatorChar
            v103 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v104 : char = System.IO.Path.DirectorySeparatorChar
            v104 
            #endif
#if FABLE_COMPILER_PYTHON
            let v105 : char = System.IO.Path.DirectorySeparatorChar
            v105 
            #endif
#else
            let v106 : char = System.IO.Path.DirectorySeparatorChar
            v106 
            #endif
            |> fun x -> _v99 <- Some x
            let v107 : char = match _v99 with Some x -> x | None -> failwith "base.run_target / _v99=None"
            let v108 : (char -> string) = _.ToString()
            let v109 : string = v108 v107
            let v110 : (string -> (string seq -> string)) = String.concat
            let v111 : (string seq -> string) = v110 v109
            v111 v98
        else
            let v113 : string = "std::fs::canonicalize(&*$0)"
            let v114 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v113 
            let v115 : string = "$0.unwrap()"
            let v116 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v114 v115 
            let v117 : string = "$0.display()"
            let v118 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v116 v117 
            let v119 : bool = true
            let mutable _v119 : std_string_String option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v120 : string = "format!(\"{}\", $0)"
            let v121 : std_string_String = Fable.Core.RustInterop.emitRustExpr v118 v120 
            v121 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v122 : string = "format!(\"{}\", $0)"
            let v123 : std_string_String = Fable.Core.RustInterop.emitRustExpr v118 v122 
            v123 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v124 : string = "format!(\"{}\", $0)"
            let v125 : std_string_String = Fable.Core.RustInterop.emitRustExpr v118 v124 
            v125 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v126 : std_string_String = null |> unbox<std_string_String>
            v126 
            #endif
#if FABLE_COMPILER_PYTHON
            let v127 : std_string_String = null |> unbox<std_string_String>
            v127 
            #endif
#else
            let v128 : std_string_String = null |> unbox<std_string_String>
            v128 
            #endif
            |> fun x -> _v119 <- Some x
            let v129 : std_string_String = match _v119 with Some x -> x | None -> failwith "base.run_target / _v119=None"
            let v130 : string = "fable_library_rust::String_::fromString($0)"
            let v131 : string = Fable.Core.RustInterop.emitRustExpr v129 v130 
            v131
    v132 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v133 : string = null |> unbox<string>
    v133 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v134 : string = null |> unbox<string>
    v134 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v135 : string = null |> unbox<string>
    v135 
    #endif
#if FABLE_COMPILER_PYTHON
    let v136 : string = null |> unbox<string>
    v136 
    #endif
#else
    let v137 : string = method31(v0)
    let v138 : (string -> string) = System.IO.Path.GetFullPath
    let v139 : string = v138 v137
    v139 
    #endif
    |> fun x -> _v1 <- Some x
    let v140 : string = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v140
and closure9 () () : string =
    let v0 : string = "documents.run"
    v0
and closure10 (v0 : string, v1 : string, v2 : string, v3 : string) () : string =
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"source_dir: {v1} / dist_dir: {v2} / cache_dir: {v3} / hangul_spec: %A{v0} / {v4 ()}"
    v5
and method34 (v0 : async_walkdir_DirEntry) : async_walkdir_DirEntry =
    v0
and closure12 () (v0 : std_io_Error) : std_string_String =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2 
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v11
and method35 () : (std_io_Error -> std_string_String) =
    closure12()
and closure13 () (v0 : std_fs_FileType) : US8 =
    US8_0(v0)
and closure14 () (v0 : std_string_String) : US8 =
    US8_1(v0)
and method36 (v0 : std_fs_FileType) : std_fs_FileType =
    v0
and method37 (v0 : US7) : US7 =
    v0
and method33 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US7>>, Send<Dyn<std_future_Future<US7>>>>>> =
    let v1 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : async_walkdir_DirEntry = method34(v0)
    let v3 : string = "Box::pin(async_walkdir::DirEntry::file_type(&v2))"
    let v4 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>, Send<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>>>>> = Fable.Core.RustInterop.emitRustExpr () v3 
    let v5 : string = "v4.await"
    let v6 : Result<std_fs_FileType, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v5 
    let v7 : (std_io_Error -> std_string_String) = method35()
    let v8 : string = "$0.map_err(|x| $1(x))"
    let v9 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6, v7) v8 
    let v10 : (std_fs_FileType -> US8) = closure13()
    let v11 : (std_string_String -> US8) = closure14()
    let v12 : US8 = match v9 with Ok x -> v10 x | Error x -> v11 x
    let v71 : US7 =
        match v12 with
        | US8_0(v13) -> (* Ok *)
            let v14 : std_fs_FileType = method36(v13)
            let v15 : string = "std::fs::FileType::is_dir(&v14)"
            let v16 : bool = Fable.Core.RustInterop.emitRustExpr () v15 
            if v16 then
                US7_0
            else
                let v18 : string = "async_walkdir::DirEntry::path(&$0)"
                let v19 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v0 v18 
                let v20 : string = "$0.display()"
                let v21 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v19 v20 
                let v22 : bool = true
                let mutable _v22 : std_string_String option = None 
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v23 : string = "format!(\"{}\", $0)"
                let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v23 
                v24 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v25 : string = "format!(\"{}\", $0)"
                let v26 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v25 
                v26 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v27 : string = "format!(\"{}\", $0)"
                let v28 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v27 
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
                |> fun x -> _v22 <- Some x
                let v32 : std_string_String = match _v22 with Some x -> x | None -> failwith "base.run_target / _v22=None"
                let v33 : string = "fable_library_rust::String_::fromString($0)"
                let v34 : string = Fable.Core.RustInterop.emitRustExpr v32 v33 
                let v35 : string = ".md"
                let v36 : bool = v34.EndsWith v35 
                let v37 : bool = v36 = false
                let v40 : bool =
                    if v37 then
                        true
                    else
                        let v38 : string = ".hangul.md"
                        let v39 : bool = v34.EndsWith v38 
                        v39
                if v40 then
                    US7_0
                else
                    US7_2
        | _ ->
            let v45 : string = "async_walkdir::DirEntry::path(&$0)"
            let v46 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v0 v45 
            let v47 : string = "$0.display()"
            let v48 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v46 v47 
            let v49 : bool = true
            let mutable _v49 : std_string_String option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v50 : string = "format!(\"{}\", $0)"
            let v51 : std_string_String = Fable.Core.RustInterop.emitRustExpr v48 v50 
            v51 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v52 : string = "format!(\"{}\", $0)"
            let v53 : std_string_String = Fable.Core.RustInterop.emitRustExpr v48 v52 
            v53 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v54 : string = "format!(\"{}\", $0)"
            let v55 : std_string_String = Fable.Core.RustInterop.emitRustExpr v48 v54 
            v55 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v56 : std_string_String = null |> unbox<std_string_String>
            v56 
            #endif
#if FABLE_COMPILER_PYTHON
            let v57 : std_string_String = null |> unbox<std_string_String>
            v57 
            #endif
#else
            let v58 : std_string_String = null |> unbox<std_string_String>
            v58 
            #endif
            |> fun x -> _v49 <- Some x
            let v59 : std_string_String = match _v49 with Some x -> x | None -> failwith "base.run_target / _v49=None"
            let v60 : string = "fable_library_rust::String_::fromString($0)"
            let v61 : string = Fable.Core.RustInterop.emitRustExpr v59 v60 
            let v62 : string = ".md"
            let v63 : bool = v61.EndsWith v62 
            let v64 : bool = v63 = false
            let v67 : bool =
                if v64 then
                    true
                else
                    let v65 : string = ".hangul.md"
                    let v66 : bool = v61.EndsWith v65 
                    v66
            if v67 then
                US7_0
            else
                US7_2
    let v72 : US7 = method37(v71)
    let v73 : string = ""
    let v74 : string = "}"
    let v75 : string = v73 + v74 
    let v76 : string = v75 + v74 
    let v77 : string = "{"
    let v78 : string = v73 + v77 
    let v79 : string = "v72 " + v76 + "); " + v78 + " //"
    Fable.Core.RustInterop.emitRustExpr () v79 
    let v80 : string = "__result"
    let v81 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US7>>, Send<Dyn<std_future_Future<US7>>>>>> = Fable.Core.RustInterop.emitRustExpr () v80 
    v81
and method38 (v0 : async_walkdir_Filtering) : async_walkdir_Filtering =
    v0
and method32 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> =
    let v1 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US7>>, Send<Dyn<std_future_Future<US7>>>>>> = method33(v0)
    let v3 : string = "v2.await"
    let v4 : US7 = Fable.Core.RustInterop.emitRustExpr () v3 
    let v13 : async_walkdir_Filtering =
        match v4 with
        | US7_2 -> (* Continue *)
            let v9 : string = "async_walkdir::Filtering::Continue"
            let v10 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v9 
            v10
        | US7_0 -> (* Ignore *)
            let v5 : string = "async_walkdir::Filtering::Ignore"
            let v6 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v5 
            v6
        | US7_1 -> (* IgnoreDir *)
            let v7 : string = "async_walkdir::Filtering::IgnoreDir"
            let v8 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v7 
            v8
    let v14 : async_walkdir_Filtering = method38(v13)
    let v15 : string = ""
    let v16 : string = "}"
    let v17 : string = v15 + v16 
    let v18 : string = v17 + v16 
    let v19 : string = "{"
    let v20 : string = v15 + v19 
    let v21 : string = "v14 " + v18 + "); " + v20 + " //"
    Fable.Core.RustInterop.emitRustExpr () v21 
    let v22 : string = "__result"
    let v23 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> = Fable.Core.RustInterop.emitRustExpr () v22 
    v23
and closure11 () (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> =
    method32(v0)
and closure16 () (v0 : async_walkdir_DirEntry) : US9 =
    US9_0(v0)
and closure17 () (v0 : std_string_String) : US9 =
    US9_1(v0)
and closure18 () () : string =
    let v0 : string = "documents.run / stream_filter_map"
    v0
and closure19 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and closure15 () (v0 : Result<async_walkdir_DirEntry, std_io_Error>) : string option =
    let v1 : (std_io_Error -> std_string_String) = method35()
    let v2 : string = "$0.map_err(|x| $1(x))"
    let v3 : Result<async_walkdir_DirEntry, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v2 
    let v4 : (async_walkdir_DirEntry -> US9) = closure16()
    let v5 : (std_string_String -> US9) = closure17()
    let v6 : US9 = match v3 with Ok x -> v4 x | Error x -> v5 x
    let v32 : US3 =
        match v6 with
        | US9_1(v26) -> (* Error *)
            let v27 : US0 = US0_4
            let v28 : (unit -> string) = closure18()
            let v29 : (unit -> string) = closure19(v26)
            method5(v27, v28, v29)
            US3_1
        | US9_0(v7) -> (* Ok *)
            let v8 : string = "async_walkdir::DirEntry::path(&$0)"
            let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8 
            let v10 : string = "$0.display()"
            let v11 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v9 v10 
            let v12 : bool = true
            let mutable _v12 : std_string_String option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v13 : string = "format!(\"{}\", $0)"
            let v14 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v13 
            v14 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v15 : string = "format!(\"{}\", $0)"
            let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v15 
            v16 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v17 : string = "format!(\"{}\", $0)"
            let v18 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v17 
            v18 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v19 : std_string_String = null |> unbox<std_string_String>
            v19 
            #endif
#if FABLE_COMPILER_PYTHON
            let v20 : std_string_String = null |> unbox<std_string_String>
            v20 
            #endif
#else
            let v21 : std_string_String = null |> unbox<std_string_String>
            v21 
            #endif
            |> fun x -> _v12 <- Some x
            let v22 : std_string_String = match _v12 with Some x -> x | None -> failwith "base.run_target / _v12=None"
            let v23 : string = "fable_library_rust::String_::fromString($0)"
            let v24 : string = Fable.Core.RustInterop.emitRustExpr v22 v23 
            US3_0(v24)
    match v32 with
    | US3_1 -> (* None *)
        let v35 : string option = None
        v35
    | US3_0(v33) -> (* Some *)
        let v34 : string option = Some v33 
        v34
and method39 () : (Result<async_walkdir_DirEntry, std_io_Error> -> string option) =
    closure15()
and closure20 () () : string =
    let v0 : string = "documents.run"
    v0
and closure21 (v0 : Vec<string>) () : string =
    let v1 : string = "$0.len()"
    let v2 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"files_len: {v2} / {v3 ()}"
    v4
and method40 (v0 : string) : string =
    let v1 : string = method23(v0)
    let v2 : string = method26()
    let v3 : bool = true
    let mutable _v3 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method27(v1)
    let v5 : string = $"regex::Regex::new(&$0)"
    let v6 : string = "^\\\\\\\\\\?\\\\"
    let v7 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v6 v5 
    let v8 : string = "$0.unwrap()"
    let v9 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = $"$0.replace_all(&$1, &*$2)"
    let v11 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v9, v4, v2) v10 
    let v12 : string = "String::from($0)"
    let v13 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "fable_library_rust::String_::fromString($0)"
    let v15 : string = Fable.Core.RustInterop.emitRustExpr v13 v14 
    v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v16 : string = null |> unbox<string>
    v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17 : string = null |> unbox<string>
    v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v18 : string = null |> unbox<string>
    v18 
    #endif
#if FABLE_COMPILER_PYTHON
    let v19 : string = null |> unbox<string>
    v19 
    #endif
#else
    let v20 : string = method28()
    let v21 : string = System.Text.RegularExpressions.Regex.Replace (v1, v20, v2)
    v21 
    #endif
    |> fun x -> _v3 <- Some x
    let v22 : string = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    let v23 : string = $"{v22.[0] |> string |> _.ToLower()}{v22.[1..]}"
    let v24 : string = "\\"
    let v25 : string = "/"
    let v26 : string = v23.Replace (v24, v25)
    v26
and method42 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : string =
    v1
and method44 () : struct (string * string) =
    let v0 : string = ""
    struct (v0, v0)
and closure24 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure23 () (v0 : char) : (UH0 -> UH0) =
    closure24(v0)
and method45 () : (char -> (UH0 -> UH0)) =
    closure23()
and method46 (v0 : string, v1 : string, v2 : UH0, v3 : US10) : struct (string * string) =
    match v2 with
    | UH0_1(v4, v5) -> (* Cons *)
        let v6 : bool = '"' = v4
        if v6 then
            let v8 : bool = v1 = ""
            if v8 then
                let v9 : US11 = US11_0
                let v10 : US10 = US10_1(v9)
                method46(v0, v1, v5, v10)
            else
                match v3 with
                | US10_2 -> (* Arguments *)
                    let v38 : string = $"{v0}{v4}"
                    let v39 : US10 = US10_2
                    method46(v38, v1, v5, v39)
                | US10_1(v13) -> (* Path *)
                    match v13 with
                    | US11_0 -> (* Quoted *)
                        let v14 : US11 = US11_1
                        let v15 : US10 = US10_1(v14)
                        method46(v0, v1, v5, v15)
                    | _ ->
                        let v18 : bool = ' ' = v4
                        if v18 then
                            let v19 : US10 = US10_2
                            method46(v0, v1, v5, v19)
                        else
                            let v22 : string = $"{v1}{v4}"
                            method46(v0, v22, v5, v3)
                | US10_0 -> (* Start *)
                    let v29 : bool = ' ' = v4
                    if v29 then
                        let v30 : US10 = US10_2
                        method46(v0, v1, v5, v30)
                    else
                        let v33 : string = $"{v1}{v4}"
                        method46(v0, v33, v5, v3)
        else
            let v50 : bool = ''' = v4
            if v50 then
                let v52 : bool = v1 = ""
                if v52 then
                    let v53 : US11 = US11_0
                    let v54 : US10 = US10_1(v53)
                    method46(v0, v1, v5, v54)
                else
                    match v3 with
                    | US10_2 -> (* Arguments *)
                        let v82 : string = $"{v0}{v4}"
                        let v83 : US10 = US10_2
                        method46(v82, v1, v5, v83)
                    | US10_1(v57) -> (* Path *)
                        match v57 with
                        | US11_0 -> (* Quoted *)
                            let v58 : US11 = US11_1
                            let v59 : US10 = US10_1(v58)
                            method46(v0, v1, v5, v59)
                        | _ ->
                            let v62 : bool = ' ' = v4
                            if v62 then
                                let v63 : US10 = US10_2
                                method46(v0, v1, v5, v63)
                            else
                                let v66 : string = $"{v1}{v4}"
                                method46(v0, v66, v5, v3)
                    | US10_0 -> (* Start *)
                        let v73 : bool = ' ' = v4
                        if v73 then
                            let v74 : US10 = US10_2
                            method46(v0, v1, v5, v74)
                        else
                            let v77 : string = $"{v1}{v4}"
                            method46(v0, v77, v5, v3)
            else
                match v3 with
                | US10_2 -> (* Arguments *)
                    let v126 : string = $"{v0}{v4}"
                    let v127 : US10 = US10_2
                    method46(v126, v1, v5, v127)
                | US10_1(v94) -> (* Path *)
                    match v94 with
                    | US11_0 -> (* Quoted *)
                        let v95 : bool = ' ' = v4
                        if v95 then
                            let v96 : string = $"{v1} "
                            let v97 : US11 = US11_0
                            let v98 : US10 = US10_1(v97)
                            method46(v0, v96, v5, v98)
                        else
                            let v101 : string = $"{v1}{v4}"
                            method46(v0, v101, v5, v3)
                    | _ ->
                        let v106 : bool = ' ' = v4
                        if v106 then
                            let v107 : US10 = US10_2
                            method46(v0, v1, v5, v107)
                        else
                            let v110 : string = $"{v1}{v4}"
                            method46(v0, v110, v5, v3)
                | US10_0 -> (* Start *)
                    let v117 : bool = ' ' = v4
                    if v117 then
                        let v118 : US10 = US10_2
                        method46(v0, v1, v5, v118)
                    else
                        let v121 : string = $"{v1}{v4}"
                        method46(v0, v121, v5, v3)
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
and method43 (v0 : string) : struct (string * string) =
    let struct (v1 : string, v2 : string) = method44()
    let v3 : int32 = v0.Length
    let v4 : (char []) = Array.zeroCreate<char> (v3)
    let v5 : Mut5 = {l0 = 0} : Mut5
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
    let v13 : (char -> (UH0 -> UH0)) = method45()
    let v14 : (char list -> (UH0 -> UH0)) = v12 v13
    let v15 : (UH0 -> UH0) = v14 v11
    let v16 : UH0 = UH0_0
    let v17 : UH0 = v15 v16
    let v18 : US10 = US10_0
    method46(v2, v1, v17, v18)
and method49 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 4L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v19 : US15 =
            if v3 then
                US15_0('\\')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US15_0('`')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US15_0('"')
                    else
                        let v11 : int64 = v8 - 1L
                        let v12 : bool = v11 = 0L
                        if v12 then
                            US15_0(' ')
                        else
                            let v14 : int64 = v11 - 1L
                            US15_1
        let v23 : char =
            match v19 with
            | US15_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US15_0(v20) -> (* Some *)
                v20
        let v24 : bool = v0 = v23
        if v24 then
            true
        else
            let v25 : int64 = v1 + 1L
            method49(v0, v25)
and method50 (v0 : UH0, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : struct (System.Text.StringBuilder * int32 * int32) =
    match v0 with
    | UH0_1(v4, v5) -> (* Cons *)
        let v6 : bool = '\n' = v4
        let struct (v9 : int32, v10 : int32) =
            if v6 then
                let v7 : int32 = v3 + 1
                struct (1, v7)
            else
                let v8 : int32 = v2 + 1
                struct (v8, v3)
        let v17 : System.Text.StringBuilder =
            if v6 then
                let v11 : (unit -> System.Text.StringBuilder) = v1.Clear
                let v12 : System.Text.StringBuilder = v11 ()
                v1
            else
                let v13 : (char -> string) = _.ToString()
                let v14 : string = v13 v4
                let v15 : (string -> System.Text.StringBuilder) = v1.Append
                let v16 : System.Text.StringBuilder = v15 v14
                v1
        method50(v5, v17, v9, v10)
    | UH0_0 -> (* Nil *)
        struct (v1, v2, v3)
and method51 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US16 =
    let v5 : bool = "" = v1
    let v57 : US14 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = ' ' :: v6 
            let v8 : char list = '"' :: v7 
            let v9 : char list = '`' :: v8 
            let v10 : char list = '\\' :: v9 
            let v11 : (char list -> (char [])) = List.toArray
            let v12 : (char []) = v11 v10
            let v13 : string = $"parsing.none_of / unexpected end of input / chars: %A{v12} / s: %A{struct (v2, v3, v4)}"
            US14_1(v13)
        else
            let v15 : char = v1.[int 0]
            let v16 : (string -> int32) = String.length
            let v17 : int32 = v16 v1
            let v18 : (int32 -> int32) = int32
            let v19 : int32 = v18 1
            let v20 : (int32 -> int32) = int32
            let v21 : int32 = v20 v17
            let v22 : string = v1.[int v19..int v21]
            let v23 : int64 = 0L
            let v24 : bool = method49(v15, v23)
            let v25 : bool = v24 = false
            if v25 then
                let v26 : (char -> string) = _.ToString()
                let v27 : string = v26 v15
                let v28 : int32 = v27.Length
                let v29 : (char []) = Array.zeroCreate<char> (v28)
                let v30 : Mut5 = {l0 = 0} : Mut5
                while method30(v28, v30) do
                    let v32 : int32 = v30.l0
                    let v33 : char = v27.[int v32]
                    v29.[int v32] <- v33
                    let v34 : int32 = v32 + 1
                    v30.l0 <- v34
                    ()
                let v35 : ((char []) -> char list) = Array.toList
                let v36 : char list = v35 v29
                let v37 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v38 : (char -> (UH0 -> UH0)) = method45()
                let v39 : (char list -> (UH0 -> UH0)) = v37 v38
                let v40 : (UH0 -> UH0) = v39 v36
                let v41 : UH0 = UH0_0
                let v42 : UH0 = v40 v41
                let struct (v43 : System.Text.StringBuilder, v44 : int32, v45 : int32) = method50(v42, v2, v3, v4)
                US14_0(v15, v22, v43, v44, v45)
            else
                let v47 : char list = []
                let v48 : char list = ' ' :: v47 
                let v49 : char list = '"' :: v48 
                let v50 : char list = '`' :: v49 
                let v51 : char list = '\\' :: v50 
                let v52 : (char list -> (char [])) = List.toArray
                let v53 : (char []) = v52 v51
                let v54 : string = $"parsing.none_of / unexpected char: '{v15}' / chars: %A{v53} / s: %A{struct (v2, v3, v4)}"
                US14_1(v54)
    match v57 with
    | US14_1(v67) -> (* Error *)
        US16_0(v0, v1, v2, v3, v4)
    | US14_0(v58, v59, v60, v61, v62) -> (* Ok *)
        let v63 : (char -> string) = _.ToString()
        let v64 : string = v63 v58
        let v65 : string = v0 + v64 
        method51(v65, v59, v60, v61, v62)
and method53 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 3L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v15 : US15 =
            if v3 then
                US15_0('\\')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US15_0('`')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US15_0('"')
                    else
                        let v11 : int64 = v8 - 1L
                        US15_1
        let v19 : char =
            match v15 with
            | US15_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US15_0(v16) -> (* Some *)
                v16
        let v20 : bool = v0 = v19
        if v20 then
            true
        else
            let v21 : int64 = v1 + 1L
            method53(v0, v21)
and closure25 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US16 =
    let v4 : bool = "" = v0
    let v60 : US14 =
        if v4 then
            let v5 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v1, v2, v3)}"
            US14_1(v5)
        else
            let v7 : char = v0.[int 0]
            let v8 : bool = v7 = '\\'
            if v8 then
                let v9 : (string -> int32) = String.length
                let v10 : int32 = v9 v0
                let v11 : (int32 -> int32) = int32
                let v12 : int32 = v11 1
                let v13 : (int32 -> int32) = int32
                let v14 : int32 = v13 v10
                let v15 : string = v0.[int v12..int v14]
                let v16 : (char -> string) = _.ToString()
                let v17 : string = v16 v7
                let v18 : int32 = v17.Length
                let v19 : (char []) = Array.zeroCreate<char> (v18)
                let v20 : Mut5 = {l0 = 0} : Mut5
                while method30(v18, v20) do
                    let v22 : int32 = v20.l0
                    let v23 : char = v17.[int v22]
                    v19.[int v22] <- v23
                    let v24 : int32 = v22 + 1
                    v20.l0 <- v24
                    ()
                let v25 : ((char []) -> char list) = Array.toList
                let v26 : char list = v25 v19
                let v27 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v28 : (char -> (UH0 -> UH0)) = method45()
                let v29 : (char list -> (UH0 -> UH0)) = v27 v28
                let v30 : (UH0 -> UH0) = v29 v26
                let v31 : UH0 = UH0_0
                let v32 : UH0 = v30 v31
                let struct (v33 : System.Text.StringBuilder, v34 : int32, v35 : int32) = method50(v32, v1, v2, v3)
                US14_0(v7, v15, v33, v34, v35)
            else
                let v37 : (string -> int32) = String.length
                let v38 : int32 = v37 v0
                let v39 : string = "\n"
                let v40 : int32 = v0.IndexOf v39 
                let v41 : int32 = v40 - 1
                let v42 : bool = -2 = v41
                let v43 : int32 =
                    if v42 then
                        v38
                    else
                        v41
                let v44 : (int32 -> int32) = int32
                let v45 : int32 = v44 0
                let v46 : (int32 -> int32) = int32
                let v47 : int32 = v46 v43
                let v48 : string = v0.[int v45..int v47]
                let v49 : string = $"parsing.p_char / expected: '{'\\'}' / line: {v3} / col: {v2}
{v1}{v48}"
                let v50 : int32 = v2 - 1
                let v51 : (int32 -> (string -> string)) = String.replicate
                let v52 : (string -> string) = v51 v50
                let v53 : string = " "
                let v54 : string = v52 v53
                let v55 : string = "^"
                let v56 : string = v54 + v55 
                let v57 : string = $"{v49}
{v56}
"
                US14_1(v57)
    let v102 : US14 =
        match v60 with
        | US14_1(v99) -> (* Error *)
            US14_1(v99)
        | US14_0(v61, v62, v63, v64, v65) -> (* Ok *)
            let v66 : bool = "" = v62
            if v66 then
                let v67 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v63, v64, v65)}"
                US14_1(v67)
            else
                let v69 : char = v62.[int 0]
                let v70 : (string -> int32) = String.length
                let v71 : int32 = v70 v62
                let v72 : (int32 -> int32) = int32
                let v73 : int32 = v72 1
                let v74 : (int32 -> int32) = int32
                let v75 : int32 = v74 v71
                let v76 : string = v62.[int v73..int v75]
                let v77 : (char -> string) = _.ToString()
                let v78 : string = v77 v69
                let v79 : int32 = v78.Length
                let v80 : (char []) = Array.zeroCreate<char> (v79)
                let v81 : Mut5 = {l0 = 0} : Mut5
                while method30(v79, v81) do
                    let v83 : int32 = v81.l0
                    let v84 : char = v78.[int v83]
                    v80.[int v83] <- v84
                    let v85 : int32 = v83 + 1
                    v81.l0 <- v85
                    ()
                let v86 : ((char []) -> char list) = Array.toList
                let v87 : char list = v86 v80
                let v88 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v89 : (char -> (UH0 -> UH0)) = method45()
                let v90 : (char list -> (UH0 -> UH0)) = v88 v89
                let v91 : (UH0 -> UH0) = v90 v87
                let v92 : UH0 = UH0_0
                let v93 : UH0 = v91 v92
                let struct (v94 : System.Text.StringBuilder, v95 : int32, v96 : int32) = method50(v93, v63, v64, v65)
                US14_0(v69, v76, v94, v95, v96)
    match v102 with
    | US14_1(v110) -> (* Error *)
        US16_1(v110)
    | US14_0(v103, v104, v105, v106, v107) -> (* Ok *)
        let v108 : string = $"{'\\'}{v103}"
        US16_0(v108, v104, v105, v106, v107)
and closure26 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US16 =
    let v4 : bool = "" = v0
    let v60 : US14 =
        if v4 then
            let v5 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v1, v2, v3)}"
            US14_1(v5)
        else
            let v7 : char = v0.[int 0]
            let v8 : bool = v7 = '`'
            if v8 then
                let v9 : (string -> int32) = String.length
                let v10 : int32 = v9 v0
                let v11 : (int32 -> int32) = int32
                let v12 : int32 = v11 1
                let v13 : (int32 -> int32) = int32
                let v14 : int32 = v13 v10
                let v15 : string = v0.[int v12..int v14]
                let v16 : (char -> string) = _.ToString()
                let v17 : string = v16 v7
                let v18 : int32 = v17.Length
                let v19 : (char []) = Array.zeroCreate<char> (v18)
                let v20 : Mut5 = {l0 = 0} : Mut5
                while method30(v18, v20) do
                    let v22 : int32 = v20.l0
                    let v23 : char = v17.[int v22]
                    v19.[int v22] <- v23
                    let v24 : int32 = v22 + 1
                    v20.l0 <- v24
                    ()
                let v25 : ((char []) -> char list) = Array.toList
                let v26 : char list = v25 v19
                let v27 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v28 : (char -> (UH0 -> UH0)) = method45()
                let v29 : (char list -> (UH0 -> UH0)) = v27 v28
                let v30 : (UH0 -> UH0) = v29 v26
                let v31 : UH0 = UH0_0
                let v32 : UH0 = v30 v31
                let struct (v33 : System.Text.StringBuilder, v34 : int32, v35 : int32) = method50(v32, v1, v2, v3)
                US14_0(v7, v15, v33, v34, v35)
            else
                let v37 : (string -> int32) = String.length
                let v38 : int32 = v37 v0
                let v39 : string = "\n"
                let v40 : int32 = v0.IndexOf v39 
                let v41 : int32 = v40 - 1
                let v42 : bool = -2 = v41
                let v43 : int32 =
                    if v42 then
                        v38
                    else
                        v41
                let v44 : (int32 -> int32) = int32
                let v45 : int32 = v44 0
                let v46 : (int32 -> int32) = int32
                let v47 : int32 = v46 v43
                let v48 : string = v0.[int v45..int v47]
                let v49 : string = $"parsing.p_char / expected: '{'`'}' / line: {v3} / col: {v2}
{v1}{v48}"
                let v50 : int32 = v2 - 1
                let v51 : (int32 -> (string -> string)) = String.replicate
                let v52 : (string -> string) = v51 v50
                let v53 : string = " "
                let v54 : string = v52 v53
                let v55 : string = "^"
                let v56 : string = v54 + v55 
                let v57 : string = $"{v49}
{v56}
"
                US14_1(v57)
    let v102 : US14 =
        match v60 with
        | US14_1(v99) -> (* Error *)
            US14_1(v99)
        | US14_0(v61, v62, v63, v64, v65) -> (* Ok *)
            let v66 : bool = "" = v62
            if v66 then
                let v67 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v63, v64, v65)}"
                US14_1(v67)
            else
                let v69 : char = v62.[int 0]
                let v70 : (string -> int32) = String.length
                let v71 : int32 = v70 v62
                let v72 : (int32 -> int32) = int32
                let v73 : int32 = v72 1
                let v74 : (int32 -> int32) = int32
                let v75 : int32 = v74 v71
                let v76 : string = v62.[int v73..int v75]
                let v77 : (char -> string) = _.ToString()
                let v78 : string = v77 v69
                let v79 : int32 = v78.Length
                let v80 : (char []) = Array.zeroCreate<char> (v79)
                let v81 : Mut5 = {l0 = 0} : Mut5
                while method30(v79, v81) do
                    let v83 : int32 = v81.l0
                    let v84 : char = v78.[int v83]
                    v80.[int v83] <- v84
                    let v85 : int32 = v83 + 1
                    v81.l0 <- v85
                    ()
                let v86 : ((char []) -> char list) = Array.toList
                let v87 : char list = v86 v80
                let v88 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v89 : (char -> (UH0 -> UH0)) = method45()
                let v90 : (char list -> (UH0 -> UH0)) = v88 v89
                let v91 : (UH0 -> UH0) = v90 v87
                let v92 : UH0 = UH0_0
                let v93 : UH0 = v91 v92
                let struct (v94 : System.Text.StringBuilder, v95 : int32, v96 : int32) = method50(v93, v63, v64, v65)
                US14_0(v69, v76, v94, v95, v96)
    match v102 with
    | US14_1(v110) -> (* Error *)
        US16_1(v110)
    | US14_0(v103, v104, v105, v106, v107) -> (* Ok *)
        let v108 : string = $"{'`'}{v103}"
        US16_0(v108, v104, v105, v106, v107)
and method54 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH2) : US16 =
    match v4 with
    | UH2_1(v7, v8) -> (* Cons *)
        let v9 : US16 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US16_1(v15) -> (* Error *)
            method54(v0, v1, v2, v3, v8)
        | US16_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH2_0 -> (* Nil *)
        let v5 : string = "choice / no parsers succeeded"
        US16_1(v5)
and method55 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = UH1_1(v2, v1)
        method55(v3, v4)
    | UH1_0 -> (* Nil *)
        v1
and method52 (v0 : UH1, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US13 =
    let v5 : bool = "" = v1
    let v55 : US14 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = '"' :: v6 
            let v8 : char list = '`' :: v7 
            let v9 : char list = '\\' :: v8 
            let v10 : (char list -> (char [])) = List.toArray
            let v11 : (char []) = v10 v9
            let v12 : string = $"parsing.none_of / unexpected end of input / chars: %A{v11} / s: %A{struct (v2, v3, v4)}"
            US14_1(v12)
        else
            let v14 : char = v1.[int 0]
            let v15 : (string -> int32) = String.length
            let v16 : int32 = v15 v1
            let v17 : (int32 -> int32) = int32
            let v18 : int32 = v17 1
            let v19 : (int32 -> int32) = int32
            let v20 : int32 = v19 v16
            let v21 : string = v1.[int v18..int v20]
            let v22 : int64 = 0L
            let v23 : bool = method53(v14, v22)
            let v24 : bool = v23 = false
            if v24 then
                let v25 : (char -> string) = _.ToString()
                let v26 : string = v25 v14
                let v27 : int32 = v26.Length
                let v28 : (char []) = Array.zeroCreate<char> (v27)
                let v29 : Mut5 = {l0 = 0} : Mut5
                while method30(v27, v29) do
                    let v31 : int32 = v29.l0
                    let v32 : char = v26.[int v31]
                    v28.[int v31] <- v32
                    let v33 : int32 = v31 + 1
                    v29.l0 <- v33
                    ()
                let v34 : ((char []) -> char list) = Array.toList
                let v35 : char list = v34 v28
                let v36 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v37 : (char -> (UH0 -> UH0)) = method45()
                let v38 : (char list -> (UH0 -> UH0)) = v36 v37
                let v39 : (UH0 -> UH0) = v38 v35
                let v40 : UH0 = UH0_0
                let v41 : UH0 = v39 v40
                let struct (v42 : System.Text.StringBuilder, v43 : int32, v44 : int32) = method50(v41, v2, v3, v4)
                US14_0(v14, v21, v42, v43, v44)
            else
                let v46 : char list = []
                let v47 : char list = '"' :: v46 
                let v48 : char list = '`' :: v47 
                let v49 : char list = '\\' :: v48 
                let v50 : (char list -> (char [])) = List.toArray
                let v51 : (char []) = v50 v49
                let v52 : string = $"parsing.none_of / unexpected char: '{v14}' / chars: %A{v51} / s: %A{struct (v2, v3, v4)}"
                US14_1(v52)
    let v67 : US16 =
        match v55 with
        | US14_1(v64) -> (* Error *)
            US16_1(v64)
        | US14_0(v56, v57, v58, v59, v60) -> (* Ok *)
            let v61 : (char -> string) = _.ToString()
            let v62 : string = v61 v56
            US16_0(v62, v57, v58, v59, v60)
    let v81 : US16 =
        match v67 with
        | US16_1(v73) -> (* Error *)
            let v74 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US16) = closure25()
            let v75 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US16) = closure26()
            let v76 : UH2 = UH2_0
            let v77 : UH2 = UH2_1(v75, v76)
            let v78 : UH2 = UH2_1(v74, v77)
            method54(v1, v2, v3, v4, v78)
        | US16_0(v68, v69, v70, v71, v72) -> (* Ok *)
            v67
    match v81 with
    | US16_1(v89) -> (* Error *)
        let v90 : UH1 = UH1_0
        let v91 : UH1 = method55(v0, v90)
        US13_0(v91, v1, v2, v3, v4)
    | US16_0(v82, v83, v84, v85, v86) -> (* Ok *)
        let v87 : UH1 = UH1_1(v82, v0)
        method52(v87, v83, v84, v85, v86)
and method56 (v0 : UH1, v1 : string list) : string list =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : string list = method56(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH1_0 -> (* Nil *)
        v1
and method57 (v0 : UH1, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US13 =
    let v5 : bool = "" = v1
    let v55 : US14 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = '"' :: v6 
            let v8 : char list = '`' :: v7 
            let v9 : char list = '\\' :: v8 
            let v10 : (char list -> (char [])) = List.toArray
            let v11 : (char []) = v10 v9
            let v12 : string = $"parsing.none_of / unexpected end of input / chars: %A{v11} / s: %A{struct (v2, v3, v4)}"
            US14_1(v12)
        else
            let v14 : char = v1.[int 0]
            let v15 : (string -> int32) = String.length
            let v16 : int32 = v15 v1
            let v17 : (int32 -> int32) = int32
            let v18 : int32 = v17 1
            let v19 : (int32 -> int32) = int32
            let v20 : int32 = v19 v16
            let v21 : string = v1.[int v18..int v20]
            let v22 : int64 = 0L
            let v23 : bool = method53(v14, v22)
            let v24 : bool = v23 = false
            if v24 then
                let v25 : (char -> string) = _.ToString()
                let v26 : string = v25 v14
                let v27 : int32 = v26.Length
                let v28 : (char []) = Array.zeroCreate<char> (v27)
                let v29 : Mut5 = {l0 = 0} : Mut5
                while method30(v27, v29) do
                    let v31 : int32 = v29.l0
                    let v32 : char = v26.[int v31]
                    v28.[int v31] <- v32
                    let v33 : int32 = v31 + 1
                    v29.l0 <- v33
                    ()
                let v34 : ((char []) -> char list) = Array.toList
                let v35 : char list = v34 v28
                let v36 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v37 : (char -> (UH0 -> UH0)) = method45()
                let v38 : (char list -> (UH0 -> UH0)) = v36 v37
                let v39 : (UH0 -> UH0) = v38 v35
                let v40 : UH0 = UH0_0
                let v41 : UH0 = v39 v40
                let struct (v42 : System.Text.StringBuilder, v43 : int32, v44 : int32) = method50(v41, v2, v3, v4)
                US14_0(v14, v21, v42, v43, v44)
            else
                let v46 : char list = []
                let v47 : char list = '"' :: v46 
                let v48 : char list = '`' :: v47 
                let v49 : char list = '\\' :: v48 
                let v50 : (char list -> (char [])) = List.toArray
                let v51 : (char []) = v50 v49
                let v52 : string = $"parsing.none_of / unexpected char: '{v14}' / chars: %A{v51} / s: %A{struct (v2, v3, v4)}"
                US14_1(v52)
    let v67 : US16 =
        match v55 with
        | US14_1(v64) -> (* Error *)
            US16_1(v64)
        | US14_0(v56, v57, v58, v59, v60) -> (* Ok *)
            let v61 : (char -> string) = _.ToString()
            let v62 : string = v61 v56
            US16_0(v62, v57, v58, v59, v60)
    match v67 with
    | US16_1(v75) -> (* Error *)
        let v76 : UH1 = UH1_0
        let v77 : UH1 = method55(v0, v76)
        US13_0(v77, v1, v2, v3, v4)
    | US16_0(v68, v69, v70, v71, v72) -> (* Ok *)
        let v73 : UH1 = UH1_1(v68, v0)
        method57(v73, v69, v70, v71, v72)
and method58 (v0 : string, v1 : int32) : int32 =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 >= v2
    if v3 then
        v1
    else
        let v4 : char = v0.[int v1]
        let v5 : bool = v4 = ' '
        if v5 then
            let v6 : int32 = v1 + 1
            method58(v0, v6)
        else
            v1
and method48 (v0 : UH1, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US13 =
    let v5 : bool = "" = v1
    let v57 : US14 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = ' ' :: v6 
            let v8 : char list = '"' :: v7 
            let v9 : char list = '`' :: v8 
            let v10 : char list = '\\' :: v9 
            let v11 : (char list -> (char [])) = List.toArray
            let v12 : (char []) = v11 v10
            let v13 : string = $"parsing.none_of / unexpected end of input / chars: %A{v12} / s: %A{struct (v2, v3, v4)}"
            US14_1(v13)
        else
            let v15 : char = v1.[int 0]
            let v16 : (string -> int32) = String.length
            let v17 : int32 = v16 v1
            let v18 : (int32 -> int32) = int32
            let v19 : int32 = v18 1
            let v20 : (int32 -> int32) = int32
            let v21 : int32 = v20 v17
            let v22 : string = v1.[int v19..int v21]
            let v23 : int64 = 0L
            let v24 : bool = method49(v15, v23)
            let v25 : bool = v24 = false
            if v25 then
                let v26 : (char -> string) = _.ToString()
                let v27 : string = v26 v15
                let v28 : int32 = v27.Length
                let v29 : (char []) = Array.zeroCreate<char> (v28)
                let v30 : Mut5 = {l0 = 0} : Mut5
                while method30(v28, v30) do
                    let v32 : int32 = v30.l0
                    let v33 : char = v27.[int v32]
                    v29.[int v32] <- v33
                    let v34 : int32 = v32 + 1
                    v30.l0 <- v34
                    ()
                let v35 : ((char []) -> char list) = Array.toList
                let v36 : char list = v35 v29
                let v37 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v38 : (char -> (UH0 -> UH0)) = method45()
                let v39 : (char list -> (UH0 -> UH0)) = v37 v38
                let v40 : (UH0 -> UH0) = v39 v36
                let v41 : UH0 = UH0_0
                let v42 : UH0 = v40 v41
                let struct (v43 : System.Text.StringBuilder, v44 : int32, v45 : int32) = method50(v42, v2, v3, v4)
                US14_0(v15, v22, v43, v44, v45)
            else
                let v47 : char list = []
                let v48 : char list = ' ' :: v47 
                let v49 : char list = '"' :: v48 
                let v50 : char list = '`' :: v49 
                let v51 : char list = '\\' :: v50 
                let v52 : (char list -> (char [])) = List.toArray
                let v53 : (char []) = v52 v51
                let v54 : string = $"parsing.none_of / unexpected char: '{v15}' / chars: %A{v53} / s: %A{struct (v2, v3, v4)}"
                US14_1(v54)
    let v69 : US16 =
        match v57 with
        | US14_1(v58) -> (* Error *)
            US16_1(v58)
        | US14_0(v60, v61, v62, v63, v64) -> (* Ok *)
            let v65 : (char -> string) = _.ToString()
            let v66 : string = v65 v60
            method51(v66, v61, v62, v63, v64)
    let v292 : US16 =
        match v69 with
        | US16_1(v75) -> (* Error *)
            let v131 : US14 =
                if v5 then
                    let v76 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v2, v3, v4)}"
                    US14_1(v76)
                else
                    let v78 : char = v1.[int 0]
                    let v79 : bool = v78 = '"'
                    if v79 then
                        let v80 : (string -> int32) = String.length
                        let v81 : int32 = v80 v1
                        let v82 : (int32 -> int32) = int32
                        let v83 : int32 = v82 1
                        let v84 : (int32 -> int32) = int32
                        let v85 : int32 = v84 v81
                        let v86 : string = v1.[int v83..int v85]
                        let v87 : (char -> string) = _.ToString()
                        let v88 : string = v87 v78
                        let v89 : int32 = v88.Length
                        let v90 : (char []) = Array.zeroCreate<char> (v89)
                        let v91 : Mut5 = {l0 = 0} : Mut5
                        while method30(v89, v91) do
                            let v93 : int32 = v91.l0
                            let v94 : char = v88.[int v93]
                            v90.[int v93] <- v94
                            let v95 : int32 = v93 + 1
                            v91.l0 <- v95
                            ()
                        let v96 : ((char []) -> char list) = Array.toList
                        let v97 : char list = v96 v90
                        let v98 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v99 : (char -> (UH0 -> UH0)) = method45()
                        let v100 : (char list -> (UH0 -> UH0)) = v98 v99
                        let v101 : (UH0 -> UH0) = v100 v97
                        let v102 : UH0 = UH0_0
                        let v103 : UH0 = v101 v102
                        let struct (v104 : System.Text.StringBuilder, v105 : int32, v106 : int32) = method50(v103, v2, v3, v4)
                        US14_0(v78, v86, v104, v105, v106)
                    else
                        let v108 : (string -> int32) = String.length
                        let v109 : int32 = v108 v1
                        let v110 : string = "\n"
                        let v111 : int32 = v1.IndexOf v110 
                        let v112 : int32 = v111 - 1
                        let v113 : bool = -2 = v112
                        let v114 : int32 =
                            if v113 then
                                v109
                            else
                                v112
                        let v115 : (int32 -> int32) = int32
                        let v116 : int32 = v115 0
                        let v117 : (int32 -> int32) = int32
                        let v118 : int32 = v117 v114
                        let v119 : string = v1.[int v116..int v118]
                        let v120 : string = $"parsing.p_char / expected: '{'"'}' / line: {v4} / col: {v3}
{v2}{v119}"
                        let v121 : int32 = v3 - 1
                        let v122 : (int32 -> (string -> string)) = String.replicate
                        let v123 : (string -> string) = v122 v121
                        let v124 : string = " "
                        let v125 : string = v123 v124
                        let v126 : string = "^"
                        let v127 : string = v125 + v126 
                        let v128 : string = $"{v120}
{v127}
"
                        US14_1(v128)
            let v237 : US16 =
                match v131 with
                | US14_1(v234) -> (* Error *)
                    US16_1(v234)
                | US14_0(v132, v133, v134, v135, v136) -> (* Ok *)
                    let v137 : UH1 = UH1_0
                    let v138 : US13 = method52(v137, v133, v134, v135, v136)
                    let v155 : US16 =
                        match v138 with
                        | US13_1(v152) -> (* Error *)
                            US16_1(v152)
                        | US13_0(v139, v140, v141, v142, v143) -> (* Ok *)
                            let v144 : string list = []
                            let v145 : string list = method56(v139, v144)
                            let v146 : string seq = seq { for i = 0 to v145.Length - 1 do yield v145.[i] }
                            let v147 : (string -> (string seq -> string)) = String.concat
                            let v148 : string = ""
                            let v149 : (string seq -> string) = v147 v148
                            let v150 : string = v149 v146
                            US16_0(v150, v140, v141, v142, v143)
                    match v155 with
                    | US16_1(v229) -> (* Error *)
                        let v230 : string = "between / expected content"
                        US16_1(v230)
                    | US16_0(v156, v157, v158, v159, v160) -> (* Ok *)
                        let v161 : bool = "" = v157
                        let v217 : US14 =
                            if v161 then
                                let v162 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v158, v159, v160)}"
                                US14_1(v162)
                            else
                                let v164 : char = v157.[int 0]
                                let v165 : bool = v164 = '"'
                                if v165 then
                                    let v166 : (string -> int32) = String.length
                                    let v167 : int32 = v166 v157
                                    let v168 : (int32 -> int32) = int32
                                    let v169 : int32 = v168 1
                                    let v170 : (int32 -> int32) = int32
                                    let v171 : int32 = v170 v167
                                    let v172 : string = v157.[int v169..int v171]
                                    let v173 : (char -> string) = _.ToString()
                                    let v174 : string = v173 v164
                                    let v175 : int32 = v174.Length
                                    let v176 : (char []) = Array.zeroCreate<char> (v175)
                                    let v177 : Mut5 = {l0 = 0} : Mut5
                                    while method30(v175, v177) do
                                        let v179 : int32 = v177.l0
                                        let v180 : char = v174.[int v179]
                                        v176.[int v179] <- v180
                                        let v181 : int32 = v179 + 1
                                        v177.l0 <- v181
                                        ()
                                    let v182 : ((char []) -> char list) = Array.toList
                                    let v183 : char list = v182 v176
                                    let v184 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                                    let v185 : (char -> (UH0 -> UH0)) = method45()
                                    let v186 : (char list -> (UH0 -> UH0)) = v184 v185
                                    let v187 : (UH0 -> UH0) = v186 v183
                                    let v188 : UH0 = UH0_0
                                    let v189 : UH0 = v187 v188
                                    let struct (v190 : System.Text.StringBuilder, v191 : int32, v192 : int32) = method50(v189, v158, v159, v160)
                                    US14_0(v164, v172, v190, v191, v192)
                                else
                                    let v194 : (string -> int32) = String.length
                                    let v195 : int32 = v194 v157
                                    let v196 : string = "\n"
                                    let v197 : int32 = v157.IndexOf v196 
                                    let v198 : int32 = v197 - 1
                                    let v199 : bool = -2 = v198
                                    let v200 : int32 =
                                        if v199 then
                                            v195
                                        else
                                            v198
                                    let v201 : (int32 -> int32) = int32
                                    let v202 : int32 = v201 0
                                    let v203 : (int32 -> int32) = int32
                                    let v204 : int32 = v203 v200
                                    let v205 : string = v157.[int v202..int v204]
                                    let v206 : string = $"parsing.p_char / expected: '{'"'}' / line: {v160} / col: {v159}
{v158}{v205}"
                                    let v207 : int32 = v159 - 1
                                    let v208 : (int32 -> (string -> string)) = String.replicate
                                    let v209 : (string -> string) = v208 v207
                                    let v210 : string = " "
                                    let v211 : string = v209 v210
                                    let v212 : string = "^"
                                    let v213 : string = v211 + v212 
                                    let v214 : string = $"{v206}
{v213}
"
                                    US14_1(v214)
                        match v217 with
                        | US14_1(v224) -> (* Error *)
                            let v225 : string = $"between / expected closing delimiter / e: %A{v224} / input: %A{struct (v1, v2, v3, v4)} / rest1: %A{struct (v133, v134, v135, v136)} / rest2: %A{struct (v157, v158, v159, v160)}"
                            US16_1(v225)
                        | US14_0(v218, v219, v220, v221, v222) -> (* Ok *)
                            US16_0(v156, v219, v220, v221, v222)
            match v237 with
            | US16_1(v243) -> (* Error *)
                let v244 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US16) = closure25()
                let v245 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US16) = closure26()
                let v246 : UH2 = UH2_0
                let v247 : UH2 = UH2_1(v245, v246)
                let v248 : UH2 = UH2_1(v244, v247)
                let v249 : US16 = method54(v1, v2, v3, v4, v248)
                let v260 : US16 =
                    match v249 with
                    | US16_1(v257) -> (* Error *)
                        US16_1(v257)
                    | US16_0(v250, v251, v252, v253, v254) -> (* Ok *)
                        let v255 : string = ""
                        US16_0(v255, v251, v252, v253, v254)
                let v271 : US13 =
                    match v260 with
                    | US16_1(v268) -> (* Error *)
                        US13_1(v268)
                    | US16_0(v261, v262, v263, v264, v265) -> (* Ok *)
                        let v266 : UH1 = UH1_0
                        method57(v266, v262, v263, v264, v265)
                match v271 with
                | US13_1(v285) -> (* Error *)
                    US16_1(v285)
                | US13_0(v272, v273, v274, v275, v276) -> (* Ok *)
                    let v277 : string list = []
                    let v278 : string list = method56(v272, v277)
                    let v279 : string seq = seq { for i = 0 to v278.Length - 1 do yield v278.[i] }
                    let v280 : (string -> (string seq -> string)) = String.concat
                    let v281 : string = ""
                    let v282 : (string seq -> string) = v280 v281
                    let v283 : string = v282 v279
                    US16_0(v283, v273, v274, v275, v276)
            | US16_0(v238, v239, v240, v241, v242) -> (* Ok *)
                v237
        | US16_0(v70, v71, v72, v73, v74) -> (* Ok *)
            v69
    match v292 with
    | US16_1(v293) -> (* Error *)
        let v294 : UH1 = UH1_0
        let v295 : UH1 = method55(v0, v294)
        US13_0(v295, v1, v2, v3, v4)
    | US16_0(v297, v298, v299, v300, v301) -> (* Ok *)
        let v302 : int32 = 0
        let v303 : int32 = method58(v298, v302)
        let v304 : bool = 0 = v303
        let v315 : US17 =
            if v304 then
                let v305 : string = "spaces1 / expected at least one space"
                US17_1(v305)
            else
                let v307 : (string -> int32) = String.length
                let v308 : int32 = v307 v298
                let v309 : (int32 -> int32) = int32
                let v310 : int32 = v309 v303
                let v311 : (int32 -> int32) = int32
                let v312 : int32 = v311 v308
                let v313 : string = v298.[int v310..int v312]
                US17_0(v313, v299, v300, v301)
        match v315 with
        | US17_1(v316) -> (* Error *)
            let v317 : UH1 = UH1_0
            let v318 : UH1 = UH1_1(v297, v317)
            let v319 : UH1 = method55(v0, v318)
            US13_0(v319, v298, v299, v300, v301)
        | US17_0(v321, v322, v323, v324) -> (* Ok *)
            let v325 : UH1 = UH1_1(v297, v0)
            method48(v325, v321, v322, v323, v324)
and method47 (v0 : string) : US12 =
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
    let v4 : string = ""
    let v5 : string = v3 |> Option.defaultValue v4 
    let v6 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v7 : System.Text.StringBuilder = v6 v4
    let v8 : UH1 = UH1_0
    let v9 : int32 = 1
    let v10 : int32 = 1
    let v11 : US13 = method48(v8, v5, v7, v9, v10)
    let v25 : US18 =
        match v11 with
        | US13_1(v22) -> (* Error *)
            US18_1(v22)
        | US13_0(v12, v13, v14, v15, v16) -> (* Ok *)
            let v17 : string list = []
            let v18 : string list = method56(v12, v17)
            let v19 : (string list -> (string [])) = List.toArray
            let v20 : (string []) = v19 v18
            US18_0(v20)
    match v25 with
    | US18_1(v28) -> (* Error *)
        US12_1(v28)
    | US18_0(v26) -> (* Ok *)
        US12_0(v26)
and closure27 () () : string =
    let v0 : string = $"runtime.execute_with_options"
    v0
and closure28 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : string, v8 : Vec<std_string_String>) () : string =
    let v9 : string = $"file_name: {v7} / arguments: %A{v8}"
    let v10 : (unit -> string) = closure6()
    let v11 : string = $" / options: %A{struct (v0, v1, v2, v3, v4, v5, v6)} / {v10 ()}"
    let v12 : string = v9 + v11 
    v12
and closure29 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : US19 =
    US19_0(v0)
and method59 () : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US19) =
    closure29()
and closure30 () (v0 : std_string_String) : US19 =
    US19_1(v0)
and method60 () : (std_string_String -> US19) =
    closure30()
and closure31 () () : string =
    let v0 : string = $"runtime.execute_with_options / child error"
    v0
and closure32 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and method61 (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : std_sync_Arc<std_sync_Mutex<std_process_Child option>> =
    v0
and closure33 () (v0 : std_string_String) : US21 =
    US21_0(v0)
and method62 () : (std_string_String -> US21) =
    closure33()
and closure34 () (v0 : std_string_String) : US21 =
    US21_1(v0)
and method63 () : (std_string_String -> US21) =
    closure34()
and closure35 () () : string =
    let v0 : string = $"runtime.stdio_line"
    v0
and closure36 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"e: {v0} / {v1 ()}"
    v2
and closure37 (v0 : string) () : string =
    v0
and method64 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> =
    v0
and closure38 () (v0 : std_sync_mpsc_SendError<std_string_String>) : std_string_String =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2 
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v11
and method65 () : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) =
    closure38()
and method66 (v0 : Result<unit, string>) : Result<unit, string> =
    v0
and method67 (v0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>>) : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> =
    v0
and method68 (v0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> =
    v0
and method69 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and method70 (v0 : std_thread_JoinHandle<Result<unit, string>>) : std_thread_JoinHandle<Result<unit, string>> =
    v0
and closure39 () (v0 : std_process_Output) : US24 =
    US24_0(v0)
and closure40 () (v0 : std_string_String) : US24 =
    US24_1(v0)
and closure41 () () : string =
    let v0 : string = $"runtime.execute_with_options / output error"
    v0
and closure42 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and method71 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>) : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> =
    v0
and closure43 () () : string =
    let v0 : string = $"runtime.execute_with_options / result"
    v0
and closure44 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"exit_code: {v0}"
    let v3 : (unit -> string) = closure6()
    let v4 : string = $" / std_trace.Length: {v1.Length} / {v3 ()}"
    let v5 : string = v2 + v4 
    v5
and closure45 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) () : string =
    let v7 : string = $"execute_with_options_async / options: %A{struct (v0, v1, v2, v3, v4, v5, v6)}"
    v7
and method73 () : (unit -> string) =
    closure6()
and closure47 (v0 : string) () : string =
    v0
and closure46 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>) (v9 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v10 : bool = true
    let mutable _v10 : Async<unit> option = None 
    
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
    let v17 : string = v9.Data
    let v18 : string = null |> unbox<string>
    let v19 : bool = v17 = v18
    let v20 : bool = v19 <> true
    if v20 then
        let v21 : US25 option = None
        let _v21 = ref v21 
        match v3 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v22 : (struct (bool * string * int32) -> Async<unit>) = x
        let v23 : US25 = US25_0(v22)
        v23 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v21.Value <- x
        let v24 : US25 option = _v21.Value 
        let v25 : US25 = US25_1
        let v26 : US25 = v24 |> Option.defaultValue v25 
        match v26 with
        | US25_1 -> (* None *)
            ()
        | US25_0(v27) -> (* Some *)
            let v28 : int32 = v7.Id
            let v29 : Async<unit> = v27 struct (false, v17, v28)
            do! v29 
            ()
        let v30 : string = $"> {v17}"
        if v5 then
            let v31 : US0 = US0_0
            let v32 : (unit -> string) = closure47(v30)
            let v33 : (unit -> string) = closure6()
            method5(v31, v32, v33)
        else
            let v34 : (string -> unit) = System.Console.WriteLine
            v34 v30
        let v35 : string = ""
        let v36 : string = $"{v35}{v17}{v35}"
        let v37 : (string -> unit) = v8.Push
        v37 v36
    }
    |> fun x -> _v16 <- Some x
    let v38 : Async<unit> = match _v16 with Some x -> x | None -> failwith "async.new_async_unit / _v16=None"
    v38 
    #endif
    |> fun x -> _v10 <- Some x
    let v39 : Async<unit> = match _v10 with Some x -> x | None -> failwith "base.run_target / _v10=None"
    let v40 : bool = true
    let mutable _v40 : unit option = None 
    
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
    let v41 : (Async<unit> -> unit) = Async.StartImmediate
    v41 v39
    () 
    #endif
    |> fun x -> _v40 <- Some x
    match _v40 with Some x -> x | None -> failwith "base.run_target / _v40=None"
    ()
and closure48 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>) (v9 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v10 : bool = true
    let mutable _v10 : Async<unit> option = None 
    
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
    let v17 : string = v9.Data
    let v18 : string = null |> unbox<string>
    let v19 : bool = v17 = v18
    let v20 : bool = v19 <> true
    if v20 then
        let v21 : US25 option = None
        let _v21 = ref v21 
        match v3 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v22 : (struct (bool * string * int32) -> Async<unit>) = x
        let v23 : US25 = US25_0(v22)
        v23 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v21.Value <- x
        let v24 : US25 option = _v21.Value 
        let v25 : US25 = US25_1
        let v26 : US25 = v24 |> Option.defaultValue v25 
        match v26 with
        | US25_1 -> (* None *)
            ()
        | US25_0(v27) -> (* Some *)
            let v28 : int32 = v7.Id
            let v29 : Async<unit> = v27 struct (true, v17, v28)
            do! v29 
            ()
        let v30 : string = $"! {v17}"
        if v5 then
            let v31 : US0 = US0_0
            let v32 : (unit -> string) = closure47(v30)
            let v33 : (unit -> string) = closure6()
            method5(v31, v32, v33)
        else
            let v34 : (string -> unit) = System.Console.WriteLine
            v34 v30
        let v35 : string = "\u001b[7;4m"
        let v36 : string = "\u001b[0m"
        let v37 : string = $"{v35}{v17}{v36}"
        let v38 : (string -> unit) = v8.Push
        v38 v37
    }
    |> fun x -> _v16 <- Some x
    let v39 : Async<unit> = match _v16 with Some x -> x | None -> failwith "async.new_async_unit / _v16=None"
    v39 
    #endif
    |> fun x -> _v10 <- Some x
    let v40 : Async<unit> = match _v10 with Some x -> x | None -> failwith "base.run_target / _v10=None"
    let v41 : bool = true
    let mutable _v41 : unit option = None 
    
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
    let v42 : (Async<unit> -> unit) = Async.StartImmediate
    v42 v40
    () 
    #endif
    |> fun x -> _v41 <- Some x
    match _v41 with Some x -> x | None -> failwith "base.run_target / _v41=None"
    ()
and closure49 (v0 : System.Diagnostics.Process) () : unit =
    let v1 : bool = true
    let mutable _v1 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : bool = null |> unbox<bool>
    v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : bool = null |> unbox<bool>
    v3 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v4 : bool = null |> unbox<bool>
    v4 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v5 : bool = null |> unbox<bool>
    v5 
    #endif
#if FABLE_COMPILER_PYTHON
    let v6 : bool = null |> unbox<bool>
    v6 
    #endif
#else
    let v7 : bool = v0.HasExited
    v7 
    #endif
    |> fun x -> _v1 <- Some x
    let v8 : bool = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    let v9 : bool = v8 = false
    if v9 then
        let v10 : bool = true
        let mutable _v10 : unit option = None 
        
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
        let v11 : (unit -> unit) = v0.Kill
        v11 ()
        () 
        #endif
        |> fun x -> _v10 <- Some x
        match _v10 with Some x -> x | None -> failwith "base.run_target / _v10=None"
        ()
and closure50 (v0 : System.Threading.Tasks.TaskCanceledException) () : string =
    let v1 : string = $"execute_with_options_async / WaitForExitAsync / ex: %A{v0}"
    v1
and closure51 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"execute_with_options_async / exit_code: {v0} / output.Length: {v1.Length}"
    v2
and method72 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    let v7 : bool = true
    let mutable _v7 : Async<struct (int32 * string)> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v9 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v10 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v12 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v12 
    #endif
#else
    let v13 : bool = true
    let mutable _v13 : Async<struct (int32 * string)> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v14 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v18 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v18 
    #endif
#else
    let v19 : Async<struct (int32 * string)> option = None
    let mutable _v19 = v19 
    async {
    let struct (v20 : string, v21 : string) = method43(v1)
    let v22 : US3 option = None
    let _v22 = ref v22 
    match v6 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v23 : string = x
    let v24 : US3 = US3_0(v23)
    v24 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v22.Value <- x
    let v25 : US3 option = _v22.Value 
    let v26 : US3 = US3_1
    let v27 : US3 = v25 |> Option.defaultValue v26 
    let v31 : string =
        match v27 with
        | US3_1 -> (* None *)
            let v29 : string = ""
            v29
        | US3_0(v28) -> (* Some *)
            v28
    let v32 : US0 = US0_1
    let v33 : (unit -> string) = closure45(v0, v1, v2, v3, v4, v5, v6)
    let v34 : (unit -> string) = method73()
    method5(v32, v33, v34)
    let v35 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v36 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v21, StandardOutputEncoding = v35, WorkingDirectory = v31, FileName = v20, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v37 : int32 = v2.Length
    let v38 : Mut5 = {l0 = 0} : Mut5
    while method30(v37, v38) do
        let v40 : int32 = v38.l0
        let struct (v41 : string, v42 : string) = v2.[int v40]
        v36.EnvironmentVariables.[v41] <- v42 
        let v43 : int32 = v40 + 1
        v38.l0 <- v43
        ()
    let v44 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v36)
    use v44 = v44 
    let v45 : System.Diagnostics.Process = v44 
    let v46 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v47 : System.Collections.Concurrent.ConcurrentStack<string> = v46 ()
    let v48 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure46(v0, v1, v2, v3, v4, v5, v6, v45, v47)
    v45.OutputDataReceived.Add v48 
    let v49 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v0, v1, v2, v3, v4, v5, v6, v45, v47)
    v45.ErrorDataReceived.Add v49 
    let v50 : (unit -> bool) = v45.Start
    let v51 : bool = v50 ()
    let v52 : bool = v51 = false
    if v52 then
        let v53 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v53
    let v54 : (unit -> unit) = v45.BeginErrorReadLine
    v54 ()
    let v55 : (unit -> unit) = v45.BeginOutputReadLine
    v55 ()
    let v56 : US26 option = None
    let _v56 = ref v56 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v57 : System.Threading.CancellationToken = x
    let v58 : US26 = US26_0(v57)
    v58 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v56.Value <- x
    let v59 : US26 option = _v56.Value 
    let v60 : US26 = US26_1
    let v61 : US26 = v59 |> Option.defaultValue v60 
    let v65 : System.Threading.CancellationToken =
        match v61 with
        | US26_1 -> (* None *)
            let v63 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v63
        | US26_0(v62) -> (* Some *)
            v62
    let v66 : bool = true
    let mutable _v66 : Async<System.Threading.CancellationToken> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v67 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v67 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v68 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v69 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v69 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v70 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v70 
    #endif
#if FABLE_COMPILER_PYTHON
    let v71 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v71 
    #endif
#else
    let v72 : bool = true
    let mutable _v72 : Async<System.Threading.CancellationToken> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v73 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v73 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v74 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v74 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v75 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v75 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v76 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v76 
    #endif
#if FABLE_COMPILER_PYTHON
    let v77 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v77 
    #endif
#else
    let v78 : Async<System.Threading.CancellationToken> option = None
    let mutable _v78 = v78 
    async {
    let v79 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v79 = v79 
    let v80 : System.Threading.CancellationToken = v79 
    let v81 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v82 : (System.Threading.CancellationToken []) = [|v80; v81; v65|]
    let v83 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v84 : System.Threading.CancellationTokenSource = v83 v82
    let v85 : System.Threading.CancellationToken = v84.Token
    return v85 
    }
    |> fun x -> _v78 <- Some x
    let v86 : Async<System.Threading.CancellationToken> = match _v78 with Some x -> x | None -> failwith "async.new_async_unit / _v78=None"
    v86 
    #endif
    |> fun x -> _v72 <- Some x
    let v87 : Async<System.Threading.CancellationToken> = match _v72 with Some x -> x | None -> failwith "base.run_target / _v72=None"
    v87 
    #endif
    |> fun x -> _v66 <- Some x
    let v88 : Async<System.Threading.CancellationToken> = match _v66 with Some x -> x | None -> failwith "base.run_target / _v66=None"
    let! v88 = v88 
    let v89 : System.Threading.CancellationToken = v88 
    let v90 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v89.Register
    let v91 : (unit -> unit) = closure49(v45)
    let v92 : System.Threading.CancellationTokenRegistration = v90 v91
    use v92 = v92 
    let v93 : System.Threading.CancellationTokenRegistration = v92 
    let v94 : bool = true
    let mutable _v94 : Async<int32> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v95 : Async<int32> = null |> unbox<Async<int32>>
    v95 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v96 : Async<int32> = null |> unbox<Async<int32>>
    v96 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v97 : Async<int32> = null |> unbox<Async<int32>>
    v97 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v98 : Async<int32> = null |> unbox<Async<int32>>
    v98 
    #endif
#if FABLE_COMPILER_PYTHON
    let v99 : Async<int32> = null |> unbox<Async<int32>>
    v99 
    #endif
#else
    let v100 : Async<int32> option = None
    let mutable _v100 = v100 
    async {
    try
    let v101 : System.Threading.Tasks.Task = v45.WaitForExitAsync v89 
    let v102 : bool = true
    let mutable _v102 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v103 : Async<unit> = null |> unbox<Async<unit>>
    v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : Async<unit> = null |> unbox<Async<unit>>
    v104 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v105 : Async<unit> = null |> unbox<Async<unit>>
    v105 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v106 : Async<unit> = null |> unbox<Async<unit>>
    v106 
    #endif
#if FABLE_COMPILER_PYTHON
    let v107 : Async<unit> = null |> unbox<Async<unit>>
    v107 
    #endif
#else
    let v108 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v109 : Async<unit> = v108 v101
    v109 
    #endif
    |> fun x -> _v102 <- Some x
    let v110 : Async<unit> = match _v102 with Some x -> x | None -> failwith "base.run_target / _v102=None"
    do! v110 
    let v111 : int32 = v45.ExitCode
    return v111 
    with ex ->
    let v112 : exn = ex
    let v113 : bool = true
    let mutable _v113 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v114 : string = $"%A{v112}"
    v114 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v115 : string = $"%A{v112}"
    v115 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v116 : string = $"%A{v112}"
    v116 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v117 : string = $"%A{v112}"
    v117 
    #endif
#if FABLE_COMPILER_PYTHON
    let v118 : string = $"%A{v112}"
    v118 
    #endif
#else
    let v119 : string = $"{v112.GetType ()}: {v112.Message}"
    v119 
    #endif
    |> fun x -> _v113 <- Some x
    let v120 : string = match _v113 with Some x -> x | None -> failwith "base.run_target / _v113=None"
    let v121 : (string -> unit) = v47.Push
    v121 v120
    let v122 : System.Threading.Tasks.TaskCanceledException = v112 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v123 : US0 = US0_3
    let v124 : (unit -> string) = closure50(v122)
    let v125 : (unit -> string) = method73()
    method5(v123, v124, v125)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v100 <- Some x
    let v126 : Async<int32> = match _v100 with Some x -> x | None -> failwith "async.new_async_unit / _v100=None"
    v126 
    #endif
    |> fun x -> _v94 <- Some x
    let v127 : Async<int32> = match _v94 with Some x -> x | None -> failwith "base.run_target / _v94=None"
    let! v127 = v127 
    let v128 : int32 = v127 
    let v129 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v130 : string seq = v129 v47
    let v131 : (string -> (string seq -> string)) = String.concat
    let v132 : string = "\n"
    let v133 : (string seq -> string) = v131 v132
    let v134 : string = v133 v130
    let v135 : US0 = US0_1
    let v136 : (unit -> string) = closure51(v128, v134)
    let v137 : (unit -> string) = method73()
    method5(v135, v136, v137)
    return struct (v128, v134) 
    }
    |> fun x -> _v19 <- Some x
    let v138 : Async<struct (int32 * string)> = match _v19 with Some x -> x | None -> failwith "async.new_async_unit / _v19=None"
    v138 
    #endif
    |> fun x -> _v13 <- Some x
    let v139 : Async<struct (int32 * string)> = match _v13 with Some x -> x | None -> failwith "base.run_target / _v13=None"
    v139 
    #endif
    |> fun x -> _v7 <- Some x
    let v140 : Async<struct (int32 * string)> = match _v7 with Some x -> x | None -> failwith "base.run_target / _v7=None"
    v140
and method41 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : struct (int32 * string) =
    let v7 : bool = true
    let mutable _v7 : struct (int32 * string) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = method42(v0, v1, v2, v3, v4, v5, v6)
    let struct (v9 : string, v10 : string) = method43(v8)
    let v11 : US12 = method47(v10)
    let v17 : (string []) =
        match v11 with
        | US12_1(v13) -> (* Error *)
            let v14 : string = $"resultm.get / Result value was Error: {v13}"
            failwith<(string [])> v14
        | US12_0(v12) -> (* Ok *)
            v12
    let v18 : string = "$0.to_vec()"
    let v19 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v17 v18 
    let v20 : string = "true; let _result : Vec<_> = v19.into_iter().map(|x| { //"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : string = "x"
    let v23 : string = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "&*$0"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v23 v24 
    let v26 : string = "String::from($0)"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr v25 v26 
    let v28 : string = "true; $0 }).collect::<Vec<_>>()"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let v30 : string = "_result"
    let v31 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : US0 = US0_1
    let v33 : (unit -> string) = closure27()
    let v34 : (unit -> string) = closure28(v0, v1, v2, v3, v4, v5, v6, v9, v31)
    method5(v32, v33, v34)
    let v35 : bool = true
    let mutable _v35 : (int32 * string) option = None 
    (
    (fun () ->
    (fun () ->
    let v36 : string = "std::process::Command::new(&*$0)"
    let v37 : std_process_Command = Fable.Core.RustInterop.emitRustExpr v9 v36 
    let v38 : string = "true; let mut v37 = v37"
    let v39 : bool = Fable.Core.RustInterop.emitRustExpr () v38 
    let v40 : string = "std::process::Command::args(&mut $0, &*$1)"
    let v41 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr struct (v37, v31) v40 
    let v42 : string = "std::process::Stdio::piped()"
    let v43 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : string = "std::process::Command::stdout($0, std::process::Stdio::piped())"
    let v45 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v41 v44 
    let v46 : string = "std::process::Stdio::piped()"
    let v47 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v46 
    let v48 : string = "std::process::Command::stderr($0, std::process::Stdio::piped())"
    let v49 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v45 v48 
    let v50 : string = "std::process::Stdio::piped()"
    let v51 : std_process_Stdio = Fable.Core.RustInterop.emitRustExpr () v50 
    let v52 : string = "std::process::Command::stdin($0, std::process::Stdio::piped())"
    let v53 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v49 v52 
    let v54 : US3 option = None
    let _v54 = ref v54 
    match v6 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v55 : string = x
    let v56 : US3 = US3_0(v55)
    v56 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v54.Value <- x
    let v57 : US3 option = _v54.Value 
    let v58 : US3 = US3_1
    let v59 : US3 = v57 |> Option.defaultValue v58 
    let v64 : Ref<Mut<std_process_Command>> =
        match v59 with
        | US3_1 -> (* None *)
            v53
        | US3_0(v60) -> (* Some *)
            let v61 : string = "std::process::Command::current_dir(v53, &*$0)"
            let v62 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr v60 v61 
            v62
    let v65 : uint64 = System.Convert.ToUInt64 v2.Length
    let v66 : bool = v65 = 0UL
    let v82 : Ref<Mut<std_process_Command>> =
        if v66 then
            v64
        else
            let v67 : string = "$0.to_vec()"
            let v68 : Vec<struct (string * string)> = Fable.Core.RustInterop.emitRustExpr v2 v67 
            let v69 : string = "true; let _result = $0.into_iter().fold(v64, |acc, x| { //"
            let v70 : bool = Fable.Core.RustInterop.emitRustExpr v68 v69 
            let v71 : string = "acc"
            let v72 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr () v71 
            let v73 : string = "x"
            let struct (v74 : string, v75 : string) = Fable.Core.RustInterop.emitRustExpr () v73 
            let v76 : string = "std::process::Command::env(v72, &*$0, &*$1)"
            let v77 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr struct (v74, v75) v76 
            let v78 : string = "true; $0 })"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string = "_result"
            let v81 : Ref<Mut<std_process_Command>> = Fable.Core.RustInterop.emitRustExpr () v80 
            v81
    let v83 : string = "std::process::Command::spawn($0)"
    let v84 : Result<std_process_Child, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let v85 : (std_io_Error -> std_string_String) = method35()
    let v86 : string = "$0.map_err(|x| $1(x))"
    let v87 : Result<std_process_Child, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v84, v85) v86 
    let v88 : string = "true; let _result = $0.map(|x| { //"
    let v89 : bool = Fable.Core.RustInterop.emitRustExpr v87 v88 
    let v90 : string = "x"
    let v91 : std_process_Child = Fable.Core.RustInterop.emitRustExpr () v90 
    let v92 : std_process_Child option = Some v91 
    let v93 : string = "std::sync::Mutex::new($0)"
    let v94 : std_sync_Mutex<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let v95 : string = "std::sync::Arc::new($0)"
    let v96 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v94 v95 
    let v97 : string = "true; $0 })"
    let v98 : bool = Fable.Core.RustInterop.emitRustExpr v96 v97 
    let v99 : string = "_result"
    let v100 : Result<std_sync_Arc<std_sync_Mutex<std_process_Child option>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v99 
    let v101 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US19) = method59()
    let v102 : (std_string_String -> US19) = method60()
    let v103 : string = "match v100 { Ok(x) => $0(x), Err(e) => $1(e) }"
    let v104 : US19 = Fable.Core.RustInterop.emitRustExpr struct (v101, v102) v103 
    let struct (v482 : int32, v483 : US4, v484 : US20) =
        match v104 with
        | US19_1(v473) -> (* Error *)
            let v474 : US0 = US0_4
            let v475 : (unit -> string) = closure31()
            let v476 : (unit -> string) = closure32(v473)
            method5(v474, v475, v476)
            let v477 : US4 = US4_0(v473)
            let v478 : US20 = US20_1
            struct (-1, v477, v478)
        | US19_0(v105) -> (* Ok *)
            let v106 : string = "true; let _result = (|| { //"
            let v107 : bool = Fable.Core.RustInterop.emitRustExpr () v106 
            let v108 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method61(v105)
            let v109 : string = "v108.lock()"
            let v110 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v109 
            let v111 : string = "$0.unwrap()"
            let v112 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v110 v111 
            let v113 : string = "true; let mut v112 = v112"
            let v114 : bool = Fable.Core.RustInterop.emitRustExpr () v113 
            let v115 : string = "&mut $0"
            let v116 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v112 v115 
            let v117 : string = "$0.as_mut()"
            let v118 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v116 v117 
            let v119 : string = "$0.unwrap()"
            let v120 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v118 v119 
            let v121 : string = "&mut v120.stdout"
            let v122 : Ref<Mut<std_process_ChildStdout option>> = Fable.Core.RustInterop.emitRustExpr () v121 
            let v123 : string = "Option::take($0)"
            let v124 : std_process_ChildStdout option = Fable.Core.RustInterop.emitRustExpr v122 v123 
            let v125 : string = "$0.unwrap()"
            let v126 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr v124 v125 
            let v127 : string = "true; $0 })()"
            let v128 : bool = Fable.Core.RustInterop.emitRustExpr v126 v127 
            let v129 : string = "_result"
            let v130 : std_process_ChildStdout = Fable.Core.RustInterop.emitRustExpr () v129 
            let v131 : string = "true; let _result = (|| { //"
            let v132 : bool = Fable.Core.RustInterop.emitRustExpr () v131 
            let v133 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method61(v105)
            let v134 : string = "v133.lock()"
            let v135 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v134 
            let v136 : string = "$0.unwrap()"
            let v137 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v135 v136 
            let v138 : string = "true; let mut v137 = v137"
            let v139 : bool = Fable.Core.RustInterop.emitRustExpr () v138 
            let v140 : string = "&mut $0"
            let v141 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v137 v140 
            let v142 : string = "$0.as_mut()"
            let v143 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v141 v142 
            let v144 : string = "$0.unwrap()"
            let v145 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v143 v144 
            let v146 : string = "&mut v145.stderr"
            let v147 : Ref<Mut<std_process_ChildStderr option>> = Fable.Core.RustInterop.emitRustExpr () v146 
            let v148 : string = "Option::take($0)"
            let v149 : std_process_ChildStderr option = Fable.Core.RustInterop.emitRustExpr v147 v148 
            let v150 : string = "$0.unwrap()"
            let v151 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr v149 v150 
            let v152 : string = "true; $0 })()"
            let v153 : bool = Fable.Core.RustInterop.emitRustExpr v151 v152 
            let v154 : string = "_result"
            let v155 : std_process_ChildStderr = Fable.Core.RustInterop.emitRustExpr () v154 
            let v156 : string = "true; let _result = (|| { //"
            let v157 : bool = Fable.Core.RustInterop.emitRustExpr () v156 
            let v158 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method61(v105)
            let v159 : string = "v158.lock()"
            let v160 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v159 
            let v161 : string = "$0.unwrap()"
            let v162 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v160 v161 
            let v163 : string = "true; let mut v162 = v162"
            let v164 : bool = Fable.Core.RustInterop.emitRustExpr () v163 
            let v165 : string = "&mut $0"
            let v166 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v162 v165 
            let v167 : string = "$0.as_mut()"
            let v168 : Ref<Mut<std_process_Child>> option = Fable.Core.RustInterop.emitRustExpr v166 v167 
            let v169 : string = "$0.unwrap()"
            let v170 : Ref<Mut<std_process_Child>> = Fable.Core.RustInterop.emitRustExpr v168 v169 
            let v171 : string = "&mut $0.stdin"
            let v172 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v170 v171 
            let v173 : string = "Option::take($0)"
            let v174 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v172 v173 
            let v175 : string = "$0.unwrap()"
            let v176 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr v174 v175 
            let v177 : std_process_ChildStdin option = Some v176 
            let v178 : string = "std::sync::Mutex::new($0)"
            let v179 : std_sync_Mutex<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v177 v178 
            let v180 : string = "std::sync::Arc::new($0)"
            let v181 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v179 v180 
            let v182 : string = "true; $0 })()"
            let v183 : bool = Fable.Core.RustInterop.emitRustExpr v181 v182 
            let v184 : string = "_result"
            let v185 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr () v184 
            let v186 : string = "{ let (sender, receiver) = std::sync::mpsc::channel(); (sender, std::sync::Arc::new(receiver)) }"
            let struct (v187 : std_sync_mpsc_Sender<std_string_String>, v188 : std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>) = Fable.Core.RustInterop.emitRustExpr () v186 
            let v189 : string = "std::sync::Mutex::new($0)"
            let v190 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v187 v189 
            let v191 : string = "std::sync::Arc::new($0)"
            let v192 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v190 v191 
            let v193 : string = "std::sync::Mutex::new($0)"
            let v194 : std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v187 v193 
            let v195 : string = "std::sync::Arc::new($0)"
            let v196 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v194 v195 
            let v197 : string = "std::sync::Mutex::new($0)"
            let v198 : std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v188 v197 
            let v199 : string = "std::sync::Arc::new($0)"
            let v200 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr v198 v199 
            let v201 : string = "true; let __result = std::thread::spawn(move || { //"
            let v202 : bool = Fable.Core.RustInterop.emitRustExpr () v201 
            let v203 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v204 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v130 v203 
            let v205 : string = "std::io::BufReader::new(v204)"
            let v206 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v205 
            let v207 : string = "std::io::BufRead::lines(v206)"
            let v208 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStdout, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v207 
            let v209 : string = "true; let mut v208 = v208; let _result = v208.try_for_each(|x| { //"
            let v210 : bool = Fable.Core.RustInterop.emitRustExpr () v209 
            let v211 : string = "x"
            let v212 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v211 
            let v213 : string = "$0.clone()"
            let v214 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v192 v213 
            let v215 : (std_io_Error -> std_string_String) = method35()
            let v216 : string = "$0.map_err(|x| $1(x))"
            let v217 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v212, v215) v216 
            let v218 : (std_string_String -> US21) = method62()
            let v219 : (std_string_String -> US21) = method63()
            let v220 : string = "match v217 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v221 : US21 = Fable.Core.RustInterop.emitRustExpr struct (v218, v219) v220 
            let v254 : std_string_String =
                match v221 with
                | US21_1(v244) -> (* Error *)
                    let v245 : US0 = US0_4
                    let v246 : (unit -> string) = closure35()
                    let v247 : (unit -> string) = closure36(v244)
                    method5(v245, v246, v247)
                    let v248 : string = $"\u001b[4;7m{v244}\u001b[0m"
                    let v249 : string = "&*$0"
                    let v250 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v248 v249 
                    let v251 : string = "String::from($0)"
                    let v252 : std_string_String = Fable.Core.RustInterop.emitRustExpr v250 v251 
                    v252
                | US21_0(v222) -> (* Ok *)
                    let v223 : string = "fable_library_rust::String_::fromString($0)"
                    let v224 : string = Fable.Core.RustInterop.emitRustExpr v222 v223 
                    let v225 : string = "encoding_rs::UTF_8"
                    let v226 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v225 
                    let v227 : string = "$0.encode(&*$1).0"
                    let v228 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v226, v224) v227 
                    let v229 : string = "$0.as_ref()"
                    let v230 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v228 v229 
                    let v231 : string = "std::str::from_utf8(v230)"
                    let v232 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr () v231 
                    let v233 : string = "$0.unwrap()"
                    let v234 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v232 v233 
                    let v235 : string = "String::from($0)"
                    let v236 : std_string_String = Fable.Core.RustInterop.emitRustExpr v234 v235 
                    let v237 : string = "fable_library_rust::String_::fromString($0)"
                    let v238 : string = Fable.Core.RustInterop.emitRustExpr v236 v237 
                    let v239 : string = $"> {v238}"
                    if v5 then
                        let v240 : US0 = US0_0
                        let v241 : (unit -> string) = closure37(v239)
                        let v242 : (unit -> string) = closure6()
                        method5(v240, v241, v242)
                    else
                        let v243 : (string -> unit) = System.Console.WriteLine
                        v243 v239
                    v236
            let v255 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = method64(v214)
            let v256 : string = "v255.lock()"
            let v257 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "$0.unwrap()"
            let v259 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "&$0"
            let v261 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "$0.send($1)"
            let v263 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v261, v254) v262 
            let v264 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method65()
            let v265 : string = "$0.map_err(|x| $1(x))"
            let v266 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v263, v264) v265 
            let v267 : string = "$0"
            let v268 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v266 v267 
            let v269 : string = "true; $0 }); //"
            let v270 : bool = Fable.Core.RustInterop.emitRustExpr v268 v269 
            let v271 : string = "_result.map_err(|x| x.into())"
            let v272 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v271 
            let v273 : Result<unit, string> = method66(v272)
            let v274 : string = ""
            let v275 : string = "}"
            let v276 : string = v274 + v275 
            let v277 : string = "v273 " + v276 + "); " + v274 + " //"
            Fable.Core.RustInterop.emitRustExpr () v277 
            let v278 : string = "__result"
            let v279 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v278 
            let v280 : string = "true; let __result = std::thread::spawn(move || { //"
            let v281 : bool = Fable.Core.RustInterop.emitRustExpr () v280 
            let v282 : string = "encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build($0)"
            let v283 : encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>> = Fable.Core.RustInterop.emitRustExpr v155 v282 
            let v284 : string = "std::io::BufReader::new(v283)"
            let v285 : std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v284 
            let v286 : string = "std::io::BufRead::lines(v285)"
            let v287 : std_io_Lines<std_io_BufReader<encoding_rs_io_DecodeReaderBytes<std_process_ChildStderr, Vec<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v286 
            let v288 : string = "true; let mut v287 = v287; let _result = v287.try_for_each(|x| { //"
            let v289 : bool = Fable.Core.RustInterop.emitRustExpr () v288 
            let v290 : string = "x"
            let v291 : Result<std_string_String, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v290 
            let v292 : string = "$0.clone()"
            let v293 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v196 v292 
            let v294 : (std_io_Error -> std_string_String) = method35()
            let v295 : string = "$0.map_err(|x| $1(x))"
            let v296 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v291, v294) v295 
            let v297 : (std_string_String -> US21) = method62()
            let v298 : (std_string_String -> US21) = method63()
            let v299 : string = "match v296 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v300 : US21 = Fable.Core.RustInterop.emitRustExpr struct (v297, v298) v299 
            let v338 : std_string_String =
                match v300 with
                | US21_1(v328) -> (* Error *)
                    let v329 : US0 = US0_4
                    let v330 : (unit -> string) = closure35()
                    let v331 : (unit -> string) = closure36(v328)
                    method5(v329, v330, v331)
                    let v332 : string = $"\u001b[4;7m{v328}\u001b[0m"
                    let v333 : string = "&*$0"
                    let v334 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v332 v333 
                    let v335 : string = "String::from($0)"
                    let v336 : std_string_String = Fable.Core.RustInterop.emitRustExpr v334 v335 
                    v336
                | US21_0(v301) -> (* Ok *)
                    let v302 : string = "fable_library_rust::String_::fromString($0)"
                    let v303 : string = Fable.Core.RustInterop.emitRustExpr v301 v302 
                    let v304 : string = "encoding_rs::UTF_8"
                    let v305 : Ref<encoding_rs_Encoding> = Fable.Core.RustInterop.emitRustExpr () v304 
                    let v306 : string = "$0.encode(&*$1).0"
                    let v307 : std_borrow_Cow<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v305, v303) v306 
                    let v308 : string = "$0.as_ref()"
                    let v309 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr v307 v308 
                    let v310 : string = "std::str::from_utf8(v309)"
                    let v311 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr () v310 
                    let v312 : string = "$0.unwrap()"
                    let v313 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v311 v312 
                    let v314 : string = "String::from($0)"
                    let v315 : std_string_String = Fable.Core.RustInterop.emitRustExpr v313 v314 
                    let v316 : string = "fable_library_rust::String_::fromString($0)"
                    let v317 : string = Fable.Core.RustInterop.emitRustExpr v315 v316 
                    let v318 : string = $"! {v317}"
                    if v5 then
                        let v319 : US0 = US0_0
                        let v320 : (unit -> string) = closure37(v318)
                        let v321 : (unit -> string) = closure6()
                        method5(v319, v320, v321)
                    else
                        let v322 : (string -> unit) = System.Console.WriteLine
                        v322 v318
                    let v323 : string = $"\u001b[4;7m{v315}\u001b[0m"
                    let v324 : string = "&*$0"
                    let v325 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v323 v324 
                    let v326 : string = "String::from($0)"
                    let v327 : std_string_String = Fable.Core.RustInterop.emitRustExpr v325 v326 
                    v327
            let v339 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = method64(v293)
            let v340 : string = "v339.lock()"
            let v341 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v340 
            let v342 : string = "$0.unwrap()"
            let v343 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v341 v342 
            let v344 : string = "&$0"
            let v345 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v343 v344 
            let v346 : string = "$0.send($1)"
            let v347 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v345, v338) v346 
            let v348 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method65()
            let v349 : string = "$0.map_err(|x| $1(x))"
            let v350 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v347, v348) v349 
            let v351 : string = "$0"
            let v352 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v350 v351 
            let v353 : string = "true; $0 }); //"
            let v354 : bool = Fable.Core.RustInterop.emitRustExpr v352 v353 
            let v355 : string = "_result.map_err(|x| x.into())"
            let v356 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v355 
            let v357 : Result<unit, string> = method66(v356)
            let v358 : string = v274 + v275 
            let v359 : string = "v357 " + v358 + "); " + v274 + " //"
            Fable.Core.RustInterop.emitRustExpr () v359 
            let v360 : string = "__result"
            let v361 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v360 
            let v362 : US22 option = None
            let _v362 = ref v362 
            match v4 with
            | Some x -> (
            (fun () ->
            (fun () ->
            let v363 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = x
            let v364 : US22 = US22_0(v363)
            v364 
            )
            |> fun x -> x () |> Some
            ) () ) | None -> None
            |> fun x -> _v362.Value <- x
            let v365 : US22 option = _v362.Value 
            let v366 : US22 = US22_1
            let v367 : US22 = v365 |> Option.defaultValue v366 
            match v367 with
            | US22_1 -> (* None *)
                ()
            | US22_0(v368) -> (* Some *)
                let v369 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = method67(v185)
                let v370 : string = "v369.lock()"
                let v371 : Result<std_sync_MutexGuard<std_process_ChildStdin option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin option>>> = Fable.Core.RustInterop.emitRustExpr () v370 
                let v372 : string = "$0.unwrap()"
                let v373 : std_sync_MutexGuard<std_process_ChildStdin option> = Fable.Core.RustInterop.emitRustExpr v371 v372 
                let v374 : string = "true; let mut v373 = v373"
                let v375 : bool = Fable.Core.RustInterop.emitRustExpr () v374 
                let v376 : string = "&mut $0"
                let v377 : Ref<Mut<std_process_ChildStdin option>> = Fable.Core.RustInterop.emitRustExpr v373 v376 
                let v378 : string = "Option::take($0)"
                let v379 : std_process_ChildStdin option = Fable.Core.RustInterop.emitRustExpr v377 v378 
                let v380 : string = "true; let _result = v379.map(|x| { //"
                let v381 : bool = Fable.Core.RustInterop.emitRustExpr () v380 
                let v382 : string = "x"
                let v383 : std_process_ChildStdin = Fable.Core.RustInterop.emitRustExpr () v382 
                let v384 : string = "std::sync::Mutex::new($0)"
                let v385 : std_sync_Mutex<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v383 v384 
                let v386 : string = "std::sync::Arc::new($0)"
                let v387 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = Fable.Core.RustInterop.emitRustExpr v385 v386 
                let v388 : string = "true; $0 })"
                let v389 : bool = Fable.Core.RustInterop.emitRustExpr v387 v388 
                let v390 : string = "_result"
                let v391 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> option = Fable.Core.RustInterop.emitRustExpr () v390 
                let v392 : US23 option = None
                let _v392 = ref v392 
                match v391 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v393 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = x
                let v394 : US23 = US23_0(v393)
                v394 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v392.Value <- x
                let v395 : US23 option = _v392.Value 
                let v396 : US23 = US23_1
                let v397 : US23 = v395 |> Option.defaultValue v396 
                match v397 with
                | US23_1 -> (* None *)
                    ()
                | US23_0(v398) -> (* Some *)
                    v368 v398
                    let v399 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = method68(v398)
                    let v400 : string = "v399.lock()"
                    let v401 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr () v400 
                    let v402 : string = "$0.unwrap()"
                    let v403 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v401 v402 
                    let v404 : std_sync_MutexGuard<std_process_ChildStdin> = method69(v403)
                    let v405 : string = "true; let mut v404 = v404"
                    let v406 : bool = Fable.Core.RustInterop.emitRustExpr () v405 
                    let v407 : string = "true; std::io::Write::flush(&mut *$0).unwrap()"
                    let v408 : bool = Fable.Core.RustInterop.emitRustExpr v404 v407 
                    ()
            let v409 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method61(v105)
            let v410 : string = "v409.lock()"
            let v411 : Result<std_sync_MutexGuard<std_process_Child option>, std_sync_PoisonError<std_sync_MutexGuard<std_process_Child option>>> = Fable.Core.RustInterop.emitRustExpr () v410 
            let v412 : string = "$0.unwrap()"
            let v413 : std_sync_MutexGuard<std_process_Child option> = Fable.Core.RustInterop.emitRustExpr v411 v412 
            let v414 : string = "true; let mut v413 = v413"
            let v415 : bool = Fable.Core.RustInterop.emitRustExpr () v414 
            let v416 : string = "&mut $0"
            let v417 : Ref<Mut<std_process_Child option>> = Fable.Core.RustInterop.emitRustExpr v413 v416 
            let v418 : string = "Option::take($0)"
            let v419 : std_process_Child option = Fable.Core.RustInterop.emitRustExpr v417 v418 
            let v420 : string = "$0.unwrap()"
            let v421 : std_process_Child = Fable.Core.RustInterop.emitRustExpr v419 v420 
            let v422 : string = "$0.wait_with_output()"
            let v423 : Result<std_process_Output, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v421 v422 
            let v424 : (std_io_Error -> std_string_String) = method35()
            let v425 : string = "$0.map_err(|x| $1(x))"
            let v426 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v423, v424) v425 
            let v427 : std_thread_JoinHandle<Result<unit, string>> = method70(v361)
            let v428 : string = "v427"
            let v429 : string = v428 + v274 
            let v430 : string = v429 + v274 
            let v431 : std_thread_JoinHandle<Result<unit, string>> = method70(v279)
            let v432 : string = "v431"
            let v433 : string = ", "
            let v434 : string = v432 + v433 
            let v435 : string = v434 + v430 
            let v436 : string = "vec![" + v435 + "]"
            let v437 : Vec<std_thread_JoinHandle<Result<unit, string>>> = Fable.Core.RustInterop.emitRustExpr () v436 
            let v438 : string = "true; v437.into_iter().for_each(|x| { //"
            let v439 : bool = Fable.Core.RustInterop.emitRustExpr () v438 
            let v440 : string = "x"
            let v441 : std_thread_JoinHandle<Result<unit, string>> = Fable.Core.RustInterop.emitRustExpr () v440 
            let v442 : string = "std::thread::JoinHandle::join($0)"
            let v443 : Result<Result<unit, string>, Box<LifetimeRef<Dyn<LifetimeJoin<core_any_Any, LifetimeRef<LifetimeJoin<StaticLifetime, Send<StaticLifetime>>>>>>>> = Fable.Core.RustInterop.emitRustExpr v441 v442 
            let v444 : string = "$0.unwrap()"
            let v445 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v443 v444 
            let v446 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v445 v446 
            let v447 : string = "true; () }}); { //"
            let v448 : bool = Fable.Core.RustInterop.emitRustExpr () v447 
            let v449 : (std_process_Output -> US24) = closure39()
            let v450 : (std_string_String -> US24) = closure40()
            let v451 : US24 = match v426 with Ok x -> v449 x | Error x -> v450 x
            match v451 with
            | US24_1(v461) -> (* Error *)
                let v462 : US0 = US0_4
                let v463 : (unit -> string) = closure41()
                let v464 : (unit -> string) = closure42(v461)
                method5(v462, v463, v464)
                let v465 : US4 = US4_0(v461)
                let v466 : US20 = US20_1
                struct (-2, v465, v466)
            | US24_0(v452) -> (* Ok *)
                let v453 : string = "$0.status"
                let v454 : std_process_ExitStatus = Fable.Core.RustInterop.emitRustExpr v452 v453 
                let v455 : string = "$0.code()"
                let v456 : int32 option = Fable.Core.RustInterop.emitRustExpr v454 v455 
                let v457 : string = "$0.unwrap()"
                let v458 : int32 = Fable.Core.RustInterop.emitRustExpr v456 v457 
                let v459 : US4 = US4_1
                let v460 : US20 = US20_0(v200)
                struct (v458, v459, v460)
    let v489 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option =
        match v484 with
        | US20_1 -> (* None *)
            let v487 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = None
            v487
        | US20_0(v485) -> (* Some *)
            let v486 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = Some v485 
            v486
    let v490 : string = "true; let _result = v489.map(|x| { //"
    let v491 : bool = Fable.Core.RustInterop.emitRustExpr () v490 
    let v492 : string = "x"
    let v493 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v492 
    let v494 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = method71(v493)
    let v495 : string = "v494.lock()"
    let v496 : Result<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v495 
    let v497 : string = "$0.unwrap()"
    let v498 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v496 v497 
    let v499 : string = "v498.iter()"
    let v500 : _ = Fable.Core.RustInterop.emitRustExpr () v499 
    let v501 : string = "v500.collect::<Vec<_>>()"
    let v502 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v501 
    let v503 : string = "true; let _result : Vec<_> = v502.into_iter().map(|x| { //"
    let v504 : bool = Fable.Core.RustInterop.emitRustExpr () v503 
    let v505 : string = "x"
    let v506 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v505 
    let v507 : string = "fable_library_rust::String_::fromString($0)"
    let v508 : string = Fable.Core.RustInterop.emitRustExpr v506 v507 
    let v509 : string = "true; $0 }).collect::<Vec<_>>()"
    let v510 : bool = Fable.Core.RustInterop.emitRustExpr v508 v509 
    let v511 : string = "_result"
    let v512 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v511 
    let v513 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v514 : (string []) = Fable.Core.RustInterop.emitRustExpr v512 v513 
    let v515 : ((string []) -> string seq) = Seq.ofArray
    let v516 : string seq = v515 v514
    let v517 : (string -> (string seq -> string)) = String.concat
    let v518 : string = "\n"
    let v519 : (string seq -> string) = v517 v518
    let v520 : string = v519 v516
    let v521 : string = "true; $0 })"
    let v522 : bool = Fable.Core.RustInterop.emitRustExpr v520 v521 
    let v523 : string = "_result"
    let v524 : string option = Fable.Core.RustInterop.emitRustExpr () v523 
    let v531 : US3 =
        match v483 with
        | US4_1 -> (* None *)
            US3_1
        | US4_0(v525) -> (* Some *)
            let v526 : string = "fable_library_rust::String_::fromString($0)"
            let v527 : string = Fable.Core.RustInterop.emitRustExpr v525 v526 
            US3_0(v527)
    let v535 : string =
        match v531 with
        | US3_1 -> (* None *)
            let v533 : string = ""
            v533
        | US3_0(v532) -> (* Some *)
            v532
    let v536 : string = v524 |> Option.defaultValue v535 
    let v537 : US0 = US0_0
    let v538 : (unit -> string) = closure43()
    let v539 : (unit -> string) = closure44(v482, v536)
    method5(v537, v538, v539)
    let v540 : (int32 * string) = v482, v536 
    v540 
    )
    |> fun x -> x ()
    ) () )
    |> fun x -> _v35 <- Some x
    let v541 : (int32 * string) = match _v35 with Some x -> x | None -> failwith "base.capture / _v35=None"
    let (a, b) = v541 
    let v542 : int32 = a
    let v543 : string = b
    struct (v542, v543) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v544 : int32, v545 : string) = null |> unbox<struct (int32 * string)>
    struct (v544, v545) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v546 : int32, v547 : string) = null |> unbox<struct (int32 * string)>
    struct (v546, v547) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v548 : int32, v549 : string) = null |> unbox<struct (int32 * string)>
    struct (v548, v549) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v550 : int32, v551 : string) = null |> unbox<struct (int32 * string)>
    struct (v550, v551) 
    #endif
#else
    let v552 : Async<struct (int32 * string)> = method72(v0, v1, v2, v3, v4, v5, v6)
    let v553 : bool = true
    let mutable _v553 : struct (int32 * string) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v554 : int32, v555 : string) = null |> unbox<struct (int32 * string)>
    struct (v554, v555) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v556 : int32, v557 : string) = null |> unbox<struct (int32 * string)>
    struct (v556, v557) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v558 : int32, v559 : string) = null |> unbox<struct (int32 * string)>
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
#else
    let v564 : (Async<struct (int32 * string)> -> struct (int32 * string)) = Async.RunSynchronously
    let struct (v565 : int32, v566 : string) = v564 v552
    struct (v565, v566) 
    #endif
    |> fun x -> _v553 <- Some x
    let struct (v567 : int32, v568 : string) = match _v553 with Some x -> x | None -> failwith "base.run_target / _v553=None"
    struct (v567, v568) 
    #endif
    |> fun x -> _v7 <- Some x
    let struct (v569 : int32, v570 : string) = match _v7 with Some x -> x | None -> failwith "base.run_target / _v7=None"
    struct (v569, v570)
and method75 (v0 : string) : string =
    let v1 : bool = true
    let mutable _v1 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "&*$0"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "std::path::PathBuf::from($0)"
    let v7 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "$0.file_name()"
    let v9 : Ref<std_ffi_OsStr> option = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "$0.unwrap()"
    let v11 : Ref<std_ffi_OsStr> = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "$0.to_os_string()"
    let v13 : std_ffi_OsString = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "$0.to_str()"
    let v15 : Ref<Str> option = Fable.Core.RustInterop.emitRustExpr v13 v14 
    let v16 : string = "$0.unwrap()"
    let v17 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = "String::from($0)"
    let v19 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v18 
    let v20 : string = "fable_library_rust::String_::fromString($0)"
    let v21 : string = Fable.Core.RustInterop.emitRustExpr v19 v20 
    v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : US5 = US5_1
    let v23 : US6 = US6_0(v22)
    let v24 : string = $"file_system.get_file_name / target: {v23} / path: {v0}"
    let v25 : string = failwith<string> v24
    v25 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v26 : string = null |> unbox<string>
    v26 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : US5 = US5_0
    let v28 : US6 = US6_2(v27)
    let v29 : string = $"file_system.get_file_name / target: {v28} / path: {v0}"
    let v30 : string = failwith<string> v29
    v30 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : US5 = US5_0
    let v32 : US6 = US6_3(v31)
    let v33 : string = $"file_system.get_file_name / target: {v32} / path: {v0}"
    let v34 : string = failwith<string> v33
    v34 
    #endif
#else
    let v35 : (string -> string) = System.IO.Path.GetFileName
    let v36 : string = v35 v0
    v36 
    #endif
    |> fun x -> _v1 <- Some x
    let v37 : string = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v37
and method74 (v0 : string, v1 : string, v2 : string) : struct (string * string) =
    let v3 : string = method75(v1)
    let v4 : string = method15(v2, v3)
    let v5 : string = "."
    let v6 : int32 = v1.LastIndexOf v5 
    let v7 : int32 = v6 - 1
    let v8 : string = v1.[int 0..int v7]
    let v9 : int32 = v4.LastIndexOf v5 
    let v10 : int32 = v9 - 1
    let v11 : string = v4.[int 0..int v10]
    let v12 : string = ".md"
    let v13 : bool = v0.EndsWith v12 
    let v14 : bool = v13 = false
    let v17 : string =
        if v14 then
            let v15 : string = $"{v1}.{v0}"
            v15
        else
            let v16 : string = $"{v8}.{v0}"
            v16
    let v20 : string =
        if v14 then
            let v18 : string = $"{v4}.{v0}"
            v18
        else
            let v19 : string = $"{v11}.{v0}"
            v19
    struct (v20, v17)
and closure52 () (v0 : string) : US28 =
    US28_0(v0)
and method76 () : (string -> US28) =
    closure52()
and closure53 () (v0 : std_string_String) : US28 =
    US28_1(v0)
and method77 () : (std_string_String -> US28) =
    closure53()
and method78 (v0 : string) : bool =
    let v1 : bool = true
    let mutable _v1 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "&*$0"
    let v3 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "String::from($0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "std::path::PathBuf::from($0)"
    let v7 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "$0.exists()"
    let v9 : bool = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v12 : bool =
        if v9 then
            let v10 : string = "$0.is_file()"
            let v11 : bool = Fable.Core.RustInterop.emitRustExpr v7 v10 
            v11
        else
            false
    v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v13 : bool = null |> unbox<bool>
    v13 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v14 : bool = null |> unbox<bool>
    v14 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : string = "fs"
    let v16 : IFsExistsSync = Fable.Core.JsInterop.importAll v15 
    let v17 : string = "$0.existsSync($1)"
    let v18 : bool = Fable.Core.JsInterop.emitJsExpr struct (v16, v0) v17 
    v18 
    #endif
#if FABLE_COMPILER_PYTHON
    let v19 : bool = null |> unbox<bool>
    v19 
    #endif
#else
    let v20 : (string -> bool) = System.IO.File.Exists
    let v21 : bool = v20 v0
    v21 
    #endif
    |> fun x -> _v1 <- Some x
    let v22 : bool = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v22
and closure54 () () : string =
    let v0 : string = "documents.run / par_map / origin_hash |> sm'.contains local_git_hash |> not / hash2 = None || hash1 <>. (hash2 |> optionm.value)"
    v0
and closure55 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : int32, v5 : string, v6 : string, v7 : int32, v8 : string, v9 : string, v10 : US3) () : string =
    let v11 : (unit -> string) = closure6()
    let v12 : string = $"file: {v1} / real_path: {v2} / relative_path: {v0} / origin_hash_exit_code: {v4} / origin_hash: {v3} / local_git_hash_exit_code: {v7} / local_git_hash: {v6} / hash1: {v9} / hash2: %A{v10} / dist_path: {v5} / cache_path: {v8} / {v11 ()}"
    v12
and method80 (v0 : string) : string =
    v0
and method79 (v0 : string, v1 : string) : unit =
    let v2 : bool = true
    let mutable _v2 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method80(v0)
    let v4 : string = "std::fs::copy(&*$0, &*v3)"
    let v5 : Result<uint64, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1 v4 
    let v6 : string = "$0.unwrap()"
    let v7 : uint64 = Fable.Core.RustInterop.emitRustExpr v5 v6 
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
    System.IO.File.Copy (v1, v0, true)
    () 
    #endif
    |> fun x -> _v2 <- Some x
    match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    ()
and method82 (v0 : int32, v1 : Mut6) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method83 (v0 : string) : string =
    v0
and method84 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure58 (v0 : string) (v1 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : unit =
    let v2 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = method68(v1)
    let v3 : string = "v2.lock()"
    let v4 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr () v3 
    let v5 : string = "$0.unwrap()"
    let v6 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = method83(v0)
    let v8 : string = "v7.as_bytes()"
    let v9 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : std_sync_MutexGuard<std_process_ChildStdin> = method84(v6)
    let v11 : string = "true; let mut v10 = v10"
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr () v11 
    let v13 : string = "true; std::io::Write::write_all(&mut *$0, v9).unwrap()"
    let v14 : bool = Fable.Core.RustInterop.emitRustExpr v10 v13 
    ()
and method85 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method86 (v0 : string) : string =
    v0
and closure59 () () : string =
    let v0 : string = "documents.hangul"
    v0
and closure60 (v0 : string, v1 : int32, v2 : string) () : string =
    let v3 : int32 = v2.Length
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"exit_code: %A{v1} / result_len: {v3} / output_path: {v0} / {v4 ()}"
    v5
and method81 (v0 : string, v1 : string, v2 : string, v3 : string) : US29 =
    let v4 : bool = true
    let mutable _v4 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : bool = true
    let mutable _v5 : Vec<uint8> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = "std::fs::read(&*$0).unwrap()"
    let v7 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v3 v6 
    v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : Vec<uint8> = null |> unbox<Vec<uint8>>
    v8 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : Vec<uint8> = null |> unbox<Vec<uint8>>
    v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v10 : Vec<uint8> = null |> unbox<Vec<uint8>>
    v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : Vec<uint8> = null |> unbox<Vec<uint8>>
    v11 
    #endif
#else
    let v12 : (uint8 []) = v3 |> System.IO.File.ReadAllBytes
    let v13 : string = "$0.to_vec()"
    let v14 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v12 v13 
    v14 
    #endif
    |> fun x -> _v5 <- Some x
    let v15 : Vec<uint8> = match _v5 with Some x -> x | None -> failwith "base.run_target / _v5=None"
    let v16 : string = "std::string::String::from_utf8(v15)"
    let v17 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr () v16 
    let v18 : string = "$0.unwrap()"
    let v19 : std_string_String = Fable.Core.RustInterop.emitRustExpr v17 v18 
    let v20 : string = "fable_library_rust::String_::fromString($0)"
    let v21 : string = Fable.Core.RustInterop.emitRustExpr v19 v20 
    v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : string = null |> unbox<string>
    v22 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v23 : string = null |> unbox<string>
    v23 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v24 : string = null |> unbox<string>
    v24 
    #endif
#if FABLE_COMPILER_PYTHON
    let v25 : string = null |> unbox<string>
    v25 
    #endif
#else
    let v26 : string = v3 |> System.IO.File.ReadAllText
    v26 
    #endif
    |> fun x -> _v4 <- Some x
    let v27 : string = match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
    let v28 : string = "\n"
    let v29 : (string []) = v27.Split v28 
    let v30 : int32 = v29.Length
    let v31 : (string []) = Array.zeroCreate<string> (v30)
    let v32 : Mut5 = {l0 = 0} : Mut5
    while method30(v30, v32) do
        let v34 : int32 = v32.l0
        let v35 : string = v29.[int v34]
        let v36 : (unit -> string) = v35.Trim
        let v37 : string = v36 ()
        v31.[int v34] <- v37
        let v38 : int32 = v34 + 1
        v32.l0 <- v38
        ()
    let v39 : int32 = v31.Length
    let v40 : (string []) = Array.zeroCreate<string> (v39)
    let v41 : Mut6 = {l0 = 0; l1 = 0} : Mut6
    while method82(v39, v41) do
        let v43 : int32 = v41.l0
        let v44 : int32 = v41.l1
        let v45 : string = v31.[int v43]
        let v46 : string = ""
        let v47 : bool = v46 <> v45 
        let v49 : int32 =
            if v47 then
                v40.[int v44] <- v45
                let v48 : int32 = v44 + 1
                v48
            else
                v44
        let v50 : int32 = v43 + 1
        v41.l0 <- v50
        v41.l1 <- v49
        ()
    let v51 : int32 = v41.l1
    let v52 : (string []) = Array.zeroCreate<string> (v51)
    let v53 : Mut5 = {l0 = 0} : Mut5
    while method30(v51, v53) do
        let v55 : int32 = v53.l0
        let v56 : string = v40.[int v55]
        v52.[int v55] <- v56
        let v57 : int32 = v55 + 1
        v53.l0 <- v57
        ()
    let v58 : string seq = seq { for i = 0 to v52.Length - 1 do yield v52.[i] }
    let v59 : (string -> (string seq -> string)) = String.concat
    let v60 : (string seq -> string) = v59 v28
    let v61 : string = v60 v58
    let v62 : string = $"{v61}

"
    let v63 : System.Threading.CancellationToken option = None
    let v64 : (struct (string * string) []) = [||]
    let v65 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v66 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v67 : string option = None
    let v68 : bool = true
    let mutable _v68 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v69 : string = "cfg!(windows)"
    let v70 : bool = Fable.Core.RustInterop.emitRustExpr () v69 
    v70 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v71 : string = "cfg!(windows)"
    let v72 : bool = Fable.Core.RustInterop.emitRustExpr () v71 
    v72 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v73 : string = "cfg!(windows)"
    let v74 : bool = Fable.Core.RustInterop.emitRustExpr () v73 
    v74 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v75 : US5 = US5_0
    let v76 : US6 = US6_2(v75)
    let v77 : string = $"runtime.is_windows / target: {v76}"
    let v78 : bool = failwith<bool> v77
    v78 
    #endif
#if FABLE_COMPILER_PYTHON
    let v79 : US5 = US5_0
    let v80 : US6 = US6_3(v79)
    let v81 : string = $"runtime.is_windows / target: {v80}"
    let v82 : bool = failwith<bool> v81
    v82 
    #endif
#else
    let v83 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v84 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v85 : bool = v84 v83
    v85 
    #endif
    |> fun x -> _v68 <- Some x
    let v86 : bool = match _v68 with Some x -> x | None -> failwith "base.run_target / _v68=None"
    let v89 : string =
        if v86 then
            let v87 : string = ".exe"
            v87
        else
            let v88 : string = ""
            v88
    let v90 : string = $"../vault/deps/hangulize/cmd/hangulize/hangulize{v89}"
    let v91 : string = method15(v0, v90)
    let v92 : string = $"{v91} {v1}"
    let v93 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = closure58(v62)
    let v94 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = Some v93 
    let v95 : bool = true
    let struct (v96 : int32, v97 : string) = method41(v63, v92, v64, v65, v94, v95, v67)
    let v98 : (string []) = v97.Split v28 
    let v99 : int32 = v98.Length
    let v100 : string = ""
    let v101 : Mut7 = {l0 = 0; l1 = v100; l2 = 0; l3 = 0} : Mut7
    while method85(v39, v101) do
        let v103 : int32 = v101.l0
        let struct (v104 : string, v105 : int32, v106 : int32) = v101.l1, v101.l2, v101.l3
        let v107 : string = v31.[int v103]
        let v108 : bool = v107 = ""
        let struct (v122 : string, v123 : int32, v124 : int32) =
            if v108 then
                let v109 : string = $"{v104}
"
                let v110 : int32 = v105 + 1
                let v111 : int32 = v106 + 1
                struct (v109, v110, v111)
            else
                let v112 : int32 = v105 - v106
                let v113 : bool = v112 >= v99
                let v120 : string =
                    if v113 then
                        v104
                    else
                        let v114 : string = v98.[int v112]
                        let v115 : int32 = v99 - 1
                        let v116 : bool = v112 = v115
                        if v116 then
                            let v117 : string = $"{v104}{v114}"
                            v117
                        else
                            let v118 : string = $"{v104}{v114}
"
                            v118
                let v121 : int32 = v105 + 1
                struct (v120, v121, v106)
        let v125 : int32 = v103 + 1
        v101.l0 <- v125
        v101.l1 <- v122
        v101.l2 <- v123
        v101.l3 <- v124
        ()
    let struct (v126 : string, v127 : int32, v128 : int32) = v101.l1, v101.l2, v101.l3
    let v129 : bool = true
    let mutable _v129 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v130 : string = "std::fs::write(&*$0, &*$1).unwrap()"
    Fable.Core.RustInterop.emitRustExpr struct (v2, v126) v130 
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
    let v131 : string = method86(v126)
    System.IO.File.WriteAllText (v2, v131)
    () 
    #endif
    |> fun x -> _v129 <- Some x
    match _v129 with Some x -> x | None -> failwith "base.run_target / _v129=None"
    let v132 : US0 = US0_2
    let v133 : (unit -> string) = closure59()
    let v134 : (unit -> string) = closure60(v2, v96, v126)
    method5(v132, v133, v134)
    US29_0(v96, v126)
and closure61 () () : string =
    let v0 : string = "documents.files_fn / error"
    v0
and closure62 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: %A{v1} / result: {v0} / {v2 ()}"
    v3
and closure57 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : US27 =
    let struct (v6 : string, v7 : string) = method74(v5, v4, v0)
    let v8 : bool = method78(v7)
    let v10 : bool =
        if v8 then
            method78(v6)
        else
            false
    let v234 : bool =
        if v10 then
            let v11 : string = method26()
            let v12 : bool = true
            let mutable _v12 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v13 : string = method27(v7)
            let v14 : string = $"regex::Regex::new(&$0)"
            let v15 : string = "^\\\\\\\\\\?\\\\"
            let v16 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v15 v14 
            let v17 : string = "$0.unwrap()"
            let v18 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v16 v17 
            let v19 : string = $"$0.replace_all(&$1, &*$2)"
            let v20 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v18, v13, v11) v19 
            let v21 : string = "String::from($0)"
            let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr v20 v21 
            let v23 : string = "fable_library_rust::String_::fromString($0)"
            let v24 : string = Fable.Core.RustInterop.emitRustExpr v22 v23 
            v24 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v25 : string = null |> unbox<string>
            v25 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v26 : string = null |> unbox<string>
            v26 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v27 : string = null |> unbox<string>
            v27 
            #endif
#if FABLE_COMPILER_PYTHON
            let v28 : string = null |> unbox<string>
            v28 
            #endif
#else
            let v29 : string = method28()
            let v30 : string = System.Text.RegularExpressions.Regex.Replace (v7, v29, v11)
            v30 
            #endif
            |> fun x -> _v12 <- Some x
            let v31 : string = match _v12 with Some x -> x | None -> failwith "base.run_target / _v12=None"
            let v32 : string = $"{v31.[0] |> string |> _.ToLower()}{v31.[1..]}"
            let v33 : string = "\\"
            let v34 : string = "/"
            let v35 : string = v32.Replace (v33, v34)
            let v36 : string = "std::fs::File::open(&*v35)"
            let v37 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v36 
            let v38 : string = "$0.unwrap()"
            let v39 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v37 v38 
            let v40 : string = "std::io::BufReader::new(v39)"
            let v41 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v40 
            let v42 : string = "std::io::BufReader::new(v41)"
            let v43 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr () v42 
            let v44 : string = "true; let mut v43 = v43"
            let v45 : bool = Fable.Core.RustInterop.emitRustExpr () v44 
            let v46 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v46 
            let v47 : string = "result"
            let v48 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v47 
            let v49 : string = "true; let mut v48 = v48"
            let v50 : bool = Fable.Core.RustInterop.emitRustExpr () v49 
            let v51 : unativeint = 0 |> unativeint 
            let v52 : string = "[$0; 1024]"
            let v53 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v52 
            let v54 : string = "true; loop { // rust.loop"
            let v55 : bool = Fable.Core.RustInterop.emitRustExpr () v54 
            let v56 : string = "true; let mut v53 = v53"
            let v57 : bool = Fable.Core.RustInterop.emitRustExpr () v56 
            let v58 : string = "std::io::Read::read(&mut v43, &mut v53)"
            let v59 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v58 
            let v60 : string = "$0.unwrap()"
            let v61 : unativeint = Fable.Core.RustInterop.emitRustExpr v59 v60 
            let v62 : bool = v61 = v51 
            if v62 then
                let v63 : string = "true; break"
                let v64 : bool = Fable.Core.RustInterop.emitRustExpr () v63 
                ()
            let v65 : string = "v53.len()"
            let v66 : unativeint = Fable.Core.RustInterop.emitRustExpr () v65 
            let v67 : uint8 = v66 |> uint8 
            let v68 : unativeint = v61 |> unativeint 
            let v69 : unativeint = v68 |> unbox<unativeint>
            let v70 : bool = v69 = v66 
            let v75 : Ref<Slice'<uint8>> =
                if v70 then
                    let v71 : string = "&v53[v51..]"
                    let v72 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v71 
                    v72
                else
                    let v73 : string = "&v53[$0..$1]"
                    let v74 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v51, v68) v73 
                    v74
            let v76 : string = "sha2::Digest::update(&mut v48, v75)"
            Fable.Core.RustInterop.emitRustExpr () v76 
            let v77 : string = "true; } // rust.loop"
            let v78 : bool = Fable.Core.RustInterop.emitRustExpr () v77 
            let v79 : string = "true; } // rust.loop"
            let v80 : bool = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "true; } // rust.loop"
            let v82 : bool = Fable.Core.RustInterop.emitRustExpr () v81 
            let v83 : string = "true; { // rust.loop"
            let v84 : bool = Fable.Core.RustInterop.emitRustExpr () v83 
            let v85 : string = "true; { // rust.loop"
            let v86 : bool = Fable.Core.RustInterop.emitRustExpr () v85 
            let v87 : string = "&sha2::Digest::finalize(v48)"
            let v88 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v87 
            let v89 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v90 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v88 v89 
            let v91 : string = "true; let _result : Vec<_> = v90.into_iter().map(|x| { //"
            let v92 : bool = Fable.Core.RustInterop.emitRustExpr () v91 
            let v93 : string = "x"
            let v94 : uint8 = Fable.Core.RustInterop.emitRustExpr () v93 
            let v95 : string = "format!(\"{:02x}\", $0)"
            let v96 : std_string_String = Fable.Core.RustInterop.emitRustExpr v94 v95 
            let v97 : string = "fable_library_rust::String_::fromString($0)"
            let v98 : string = Fable.Core.RustInterop.emitRustExpr v96 v97 
            let v99 : string = "true; $0 }).collect::<Vec<_>>()"
            let v100 : bool = Fable.Core.RustInterop.emitRustExpr v98 v99 
            let v101 : string = "_result"
            let v102 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v101 
            let v103 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v104 : (string []) = Fable.Core.RustInterop.emitRustExpr v102 v103 
            let v105 : string seq = seq { for i = 0 to v104.Length - 1 do yield v104.[i] }
            let v106 : (string -> (string seq -> string)) = String.concat
            let v107 : string = ""
            let v108 : (string seq -> string) = v106 v107
            let v109 : string = v108 v105
            let v110 : Result<string, std_io_Error> = Ok v109 
            let v111 : (std_io_Error -> std_string_String) = method35()
            let v112 : string = "$0.map_err(|x| $1(x))"
            let v113 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v110, v111) v112 
            let v114 : (string -> US28) = method76()
            let v115 : (std_string_String -> US28) = method77()
            let v116 : string = "match v113 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v117 : US28 = Fable.Core.RustInterop.emitRustExpr struct (v114, v115) v116 
            let v123 : string =
                match v117 with
                | US28_1(v119) -> (* Error *)
                    let v120 : string = $"resultm.get / Result value was Error: {v119}"
                    failwith<string> v120
                | US28_0(v118) -> (* Ok *)
                    v118
            let v124 : string = method26()
            let v125 : bool = true
            let mutable _v125 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v126 : string = method27(v6)
            let v127 : string = $"regex::Regex::new(&$0)"
            let v128 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v15 v127 
            let v129 : string = "$0.unwrap()"
            let v130 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v128 v129 
            let v131 : string = $"$0.replace_all(&$1, &*$2)"
            let v132 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v130, v126, v124) v131 
            let v133 : string = "String::from($0)"
            let v134 : std_string_String = Fable.Core.RustInterop.emitRustExpr v132 v133 
            let v135 : string = "fable_library_rust::String_::fromString($0)"
            let v136 : string = Fable.Core.RustInterop.emitRustExpr v134 v135 
            v136 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v137 : string = null |> unbox<string>
            v137 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v138 : string = null |> unbox<string>
            v138 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v139 : string = null |> unbox<string>
            v139 
            #endif
#if FABLE_COMPILER_PYTHON
            let v140 : string = null |> unbox<string>
            v140 
            #endif
#else
            let v141 : string = method28()
            let v142 : string = System.Text.RegularExpressions.Regex.Replace (v6, v141, v124)
            v142 
            #endif
            |> fun x -> _v125 <- Some x
            let v143 : string = match _v125 with Some x -> x | None -> failwith "base.run_target / _v125=None"
            let v144 : string = $"{v143.[0] |> string |> _.ToLower()}{v143.[1..]}"
            let v145 : string = v144.Replace (v33, v34)
            let v146 : string = "std::fs::File::open(&*v145)"
            let v147 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v146 
            let v148 : string = "$0.unwrap()"
            let v149 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v147 v148 
            let v150 : string = "std::io::BufReader::new(v149)"
            let v151 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v150 
            let v152 : string = "std::io::BufReader::new(v151)"
            let v153 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr () v152 
            let v154 : string = "true; let mut v153 = v153"
            let v155 : bool = Fable.Core.RustInterop.emitRustExpr () v154 
            let v156 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v156 
            let v157 : string = "result"
            let v158 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v157 
            let v159 : string = "true; let mut v158 = v158"
            let v160 : bool = Fable.Core.RustInterop.emitRustExpr () v159 
            let v161 : unativeint = 0 |> unativeint 
            let v162 : string = "[$0; 1024]"
            let v163 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v162 
            let v164 : string = "true; loop { // rust.loop"
            let v165 : bool = Fable.Core.RustInterop.emitRustExpr () v164 
            let v166 : string = "true; let mut v163 = v163"
            let v167 : bool = Fable.Core.RustInterop.emitRustExpr () v166 
            let v168 : string = "std::io::Read::read(&mut v153, &mut v163)"
            let v169 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v168 
            let v170 : string = "$0.unwrap()"
            let v171 : unativeint = Fable.Core.RustInterop.emitRustExpr v169 v170 
            let v172 : bool = v171 = v161 
            if v172 then
                let v173 : string = "true; break"
                let v174 : bool = Fable.Core.RustInterop.emitRustExpr () v173 
                ()
            let v175 : string = "v163.len()"
            let v176 : unativeint = Fable.Core.RustInterop.emitRustExpr () v175 
            let v177 : uint8 = v176 |> uint8 
            let v178 : unativeint = v171 |> unativeint 
            let v179 : unativeint = v178 |> unbox<unativeint>
            let v180 : bool = v179 = v176 
            let v185 : Ref<Slice'<uint8>> =
                if v180 then
                    let v181 : string = "&v163[v161..]"
                    let v182 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v181 
                    v182
                else
                    let v183 : string = "&v163[$0..$1]"
                    let v184 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v161, v178) v183 
                    v184
            let v186 : string = "sha2::Digest::update(&mut v158, v185)"
            Fable.Core.RustInterop.emitRustExpr () v186 
            let v187 : string = "true; } // rust.loop"
            let v188 : bool = Fable.Core.RustInterop.emitRustExpr () v187 
            let v189 : string = "true; } // rust.loop"
            let v190 : bool = Fable.Core.RustInterop.emitRustExpr () v189 
            let v191 : string = "true; } // rust.loop"
            let v192 : bool = Fable.Core.RustInterop.emitRustExpr () v191 
            let v193 : string = "true; { // rust.loop"
            let v194 : bool = Fable.Core.RustInterop.emitRustExpr () v193 
            let v195 : string = "true; { // rust.loop"
            let v196 : bool = Fable.Core.RustInterop.emitRustExpr () v195 
            let v197 : string = "&sha2::Digest::finalize(v158)"
            let v198 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v197 
            let v199 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v200 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v198 v199 
            let v201 : string = "true; let _result : Vec<_> = v200.into_iter().map(|x| { //"
            let v202 : bool = Fable.Core.RustInterop.emitRustExpr () v201 
            let v203 : string = "x"
            let v204 : uint8 = Fable.Core.RustInterop.emitRustExpr () v203 
            let v205 : string = "format!(\"{:02x}\", $0)"
            let v206 : std_string_String = Fable.Core.RustInterop.emitRustExpr v204 v205 
            let v207 : string = "fable_library_rust::String_::fromString($0)"
            let v208 : string = Fable.Core.RustInterop.emitRustExpr v206 v207 
            let v209 : string = "true; $0 }).collect::<Vec<_>>()"
            let v210 : bool = Fable.Core.RustInterop.emitRustExpr v208 v209 
            let v211 : string = "_result"
            let v212 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v211 
            let v213 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v214 : (string []) = Fable.Core.RustInterop.emitRustExpr v212 v213 
            let v215 : string seq = seq { for i = 0 to v214.Length - 1 do yield v214.[i] }
            let v216 : (string -> (string seq -> string)) = String.concat
            let v217 : (string seq -> string) = v216 v107
            let v218 : string = v217 v215
            let v219 : Result<string, std_io_Error> = Ok v218 
            let v220 : (std_io_Error -> std_string_String) = method35()
            let v221 : string = "$0.map_err(|x| $1(x))"
            let v222 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v219, v220) v221 
            let v223 : (string -> US28) = method76()
            let v224 : (std_string_String -> US28) = method77()
            let v225 : string = "match v222 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v226 : US28 = Fable.Core.RustInterop.emitRustExpr struct (v223, v224) v225 
            let v232 : string =
                match v226 with
                | US28_1(v228) -> (* Error *)
                    let v229 : string = $"resultm.get / Result value was Error: {v228}"
                    failwith<string> v229
                | US28_0(v227) -> (* Ok *)
                    v227
            let v233 : bool = v123 = v232
            v233
        else
            false
    let v235 : bool = v234 = false
    if v235 then
        let v236 : US29 = method81(v2, v3, v7, v4)
        match v236 with
        | US29_1(v251, v252) -> (* Error *)
            let v253 : (string * string) = v7, v252 
            let v254 : Result<string, (string * string)> = Error v253 
            US27_0(v254)
        | US29_0(v237, v238) -> (* Ok *)
            let v239 : bool = v237 <> 0 
            if v239 then
                let v240 : US0 = US0_2
                let v241 : (unit -> string) = closure61()
                let v242 : (unit -> string) = closure62(v238, v237)
                method5(v240, v241, v242)
                let v243 : (string * string) = v7, v238 
                let v244 : Result<string, (string * string)> = Error v243 
                US27_0(v244)
            else
                let v246 : bool = method78(v7)
                if v246 then
                    method79(v6, v7)
                else
                    let v247 : string = $"documents.files_fn / {v7} should exist"
                    failwith<unit> v247
                let v248 : Result<string, (string * string)> = Ok v7 
                US27_0(v248)
    else
        US27_1
and closure56 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : string) : (string -> US27) =
    closure57(v0, v1, v2, v3, v4)
and closure65 () () : string =
    let v0 : string = "documents.crowbook / result contains ERROR"
    v0
and closure66 (v0 : string, v1 : string, v2 : int32) () : string =
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"exit_code: %A{v2} / output_path: {v0} / result: {v1} / {v3 ()}"
    v4
and method87 (v0 : bool, v1 : string, v2 : string, v3 : string, v4 : string) : US29 =
    let v5 : bool = "html" = v4
    let v47 : string =
        if v5 then
            let v6 : string = $"--set"
            let v7 : string = $" html.css.add \\\"' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} pre {{ background-color: #1b1b1b; padding: 10px; }} '\\\""
            let v8 : string = v6 + v7 
            let v9 : string = $" rendering.num_depth 6"
            let v10 : string = $" rendering.highlight.theme \\\"Solarized (dark)\\\""
            let v11 : string = v9 + v10 
            let v12 : string = v8 + v11 
            v12
        else
            let v13 : bool = "pdf" = v4
            if v13 then
                let v14 : string = $"--set"
                let v15 : string = $" tex.paper.size a4paper"
                let v16 : string = v14 + v15 
                let v17 : string = $" tex.template.add \"\\pagenumbering{{gobble}}\""
                let v18 : string = v16 + v17 
                let v19 : bool = v0 = false
                let v28 : string =
                    if v19 then
                        let v20 : string = ""
                        v20
                    else
                        let v21 : string = $" tex.template.add \"\\usepackage{{polyglossia}}\""
                        let v22 : string = $" tex.template.add \"\\setmainlanguage{{korean}}\""
                        let v23 : string = v21 + v22 
                        let v24 : string = $" tex.template.add \"\\setmainfont{{NanumGothicCoding}}\""
                        let v25 : string = v23 + v24 
                        let v26 : string = $" tex.font.size 12"
                        let v27 : string = v25 + v26 
                        v27
                let v29 : string = v18 + v28 
                let v30 : string = $" rendering.num_depth 6"
                let v31 : string = $" rendering.highlight.theme \\\"Solarized (dark)\\\""
                let v32 : string = v30 + v31 
                let v33 : string = v29 + v32 
                v33
            else
                let v34 : bool = "epub" = v4
                if v34 then
                    let v35 : string = $"--set"
                    let v36 : string = $" epub.version 3"
                    let v37 : string = v35 + v36 
                    let v38 : string = $" html.css.add \\\"' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} '\\\""
                    let v39 : string = v37 + v38 
                    let v40 : string = $" rendering.num_depth 6"
                    let v41 : string = $" rendering.highlight.theme \\\"Solarized (dark)\\\""
                    let v42 : string = v40 + v41 
                    let v43 : string = v39 + v42 
                    v43
                else
                    let v44 : string = ""
                    v44
    let v48 : System.Threading.CancellationToken option = None
    let v49 : (struct (string * string) []) = [||]
    let v50 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v51 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v52 : string option = None
    let v53 : string = $"crowbook --verbose --to {v4}"
    let v54 : string = $" --single \"{v2}\" --output \"{v1}\" {v47}"
    let v55 : string = v53 + v54 
    let v56 : string option = Some v3 
    let v57 : bool = true
    let struct (v58 : int32, v59 : string) = method41(v48, v55, v49, v50, v51, v57, v56)
    let v60 : string = "ERROR"
    let v61 : bool = v59.Contains v60 
    if v61 then
        let v62 : US0 = US0_3
        let v63 : (unit -> string) = closure65()
        let v64 : (unit -> string) = closure66(v1, v59, v58)
        method5(v62, v63, v64)
        US29_1(v58, v59)
    else
        US29_0(v58, v59)
and closure64 (v0 : string, v1 : string, v2 : bool, v3 : string) (v4 : string) : US27 =
    let struct (v5 : string, v6 : string) = method74(v4, v3, v0)
    let v7 : bool = method78(v6)
    let v9 : bool =
        if v7 then
            method78(v5)
        else
            false
    let v233 : bool =
        if v9 then
            let v10 : string = method26()
            let v11 : bool = true
            let mutable _v11 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v12 : string = method27(v6)
            let v13 : string = $"regex::Regex::new(&$0)"
            let v14 : string = "^\\\\\\\\\\?\\\\"
            let v15 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v14 v13 
            let v16 : string = "$0.unwrap()"
            let v17 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v15 v16 
            let v18 : string = $"$0.replace_all(&$1, &*$2)"
            let v19 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v17, v12, v10) v18 
            let v20 : string = "String::from($0)"
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
            let v28 : string = method28()
            let v29 : string = System.Text.RegularExpressions.Regex.Replace (v6, v28, v10)
            v29 
            #endif
            |> fun x -> _v11 <- Some x
            let v30 : string = match _v11 with Some x -> x | None -> failwith "base.run_target / _v11=None"
            let v31 : string = $"{v30.[0] |> string |> _.ToLower()}{v30.[1..]}"
            let v32 : string = "\\"
            let v33 : string = "/"
            let v34 : string = v31.Replace (v32, v33)
            let v35 : string = "std::fs::File::open(&*v34)"
            let v36 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v35 
            let v37 : string = "$0.unwrap()"
            let v38 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v36 v37 
            let v39 : string = "std::io::BufReader::new(v38)"
            let v40 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v39 
            let v41 : string = "std::io::BufReader::new(v40)"
            let v42 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr () v41 
            let v43 : string = "true; let mut v42 = v42"
            let v44 : bool = Fable.Core.RustInterop.emitRustExpr () v43 
            let v45 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v45 
            let v46 : string = "result"
            let v47 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v46 
            let v48 : string = "true; let mut v47 = v47"
            let v49 : bool = Fable.Core.RustInterop.emitRustExpr () v48 
            let v50 : unativeint = 0 |> unativeint 
            let v51 : string = "[$0; 1024]"
            let v52 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v51 
            let v53 : string = "true; loop { // rust.loop"
            let v54 : bool = Fable.Core.RustInterop.emitRustExpr () v53 
            let v55 : string = "true; let mut v52 = v52"
            let v56 : bool = Fable.Core.RustInterop.emitRustExpr () v55 
            let v57 : string = "std::io::Read::read(&mut v42, &mut v52)"
            let v58 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v57 
            let v59 : string = "$0.unwrap()"
            let v60 : unativeint = Fable.Core.RustInterop.emitRustExpr v58 v59 
            let v61 : bool = v60 = v50 
            if v61 then
                let v62 : string = "true; break"
                let v63 : bool = Fable.Core.RustInterop.emitRustExpr () v62 
                ()
            let v64 : string = "v52.len()"
            let v65 : unativeint = Fable.Core.RustInterop.emitRustExpr () v64 
            let v66 : uint8 = v65 |> uint8 
            let v67 : unativeint = v60 |> unativeint 
            let v68 : unativeint = v67 |> unbox<unativeint>
            let v69 : bool = v68 = v65 
            let v74 : Ref<Slice'<uint8>> =
                if v69 then
                    let v70 : string = "&v52[v50..]"
                    let v71 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v70 
                    v71
                else
                    let v72 : string = "&v52[$0..$1]"
                    let v73 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v50, v67) v72 
                    v73
            let v75 : string = "sha2::Digest::update(&mut v47, v74)"
            Fable.Core.RustInterop.emitRustExpr () v75 
            let v76 : string = "true; } // rust.loop"
            let v77 : bool = Fable.Core.RustInterop.emitRustExpr () v76 
            let v78 : string = "true; } // rust.loop"
            let v79 : bool = Fable.Core.RustInterop.emitRustExpr () v78 
            let v80 : string = "true; } // rust.loop"
            let v81 : bool = Fable.Core.RustInterop.emitRustExpr () v80 
            let v82 : string = "true; { // rust.loop"
            let v83 : bool = Fable.Core.RustInterop.emitRustExpr () v82 
            let v84 : string = "true; { // rust.loop"
            let v85 : bool = Fable.Core.RustInterop.emitRustExpr () v84 
            let v86 : string = "&sha2::Digest::finalize(v47)"
            let v87 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v89 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v87 v88 
            let v90 : string = "true; let _result : Vec<_> = v89.into_iter().map(|x| { //"
            let v91 : bool = Fable.Core.RustInterop.emitRustExpr () v90 
            let v92 : string = "x"
            let v93 : uint8 = Fable.Core.RustInterop.emitRustExpr () v92 
            let v94 : string = "format!(\"{:02x}\", $0)"
            let v95 : std_string_String = Fable.Core.RustInterop.emitRustExpr v93 v94 
            let v96 : string = "fable_library_rust::String_::fromString($0)"
            let v97 : string = Fable.Core.RustInterop.emitRustExpr v95 v96 
            let v98 : string = "true; $0 }).collect::<Vec<_>>()"
            let v99 : bool = Fable.Core.RustInterop.emitRustExpr v97 v98 
            let v100 : string = "_result"
            let v101 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v100 
            let v102 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v103 : (string []) = Fable.Core.RustInterop.emitRustExpr v101 v102 
            let v104 : string seq = seq { for i = 0 to v103.Length - 1 do yield v103.[i] }
            let v105 : (string -> (string seq -> string)) = String.concat
            let v106 : string = ""
            let v107 : (string seq -> string) = v105 v106
            let v108 : string = v107 v104
            let v109 : Result<string, std_io_Error> = Ok v108 
            let v110 : (std_io_Error -> std_string_String) = method35()
            let v111 : string = "$0.map_err(|x| $1(x))"
            let v112 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v109, v110) v111 
            let v113 : (string -> US28) = method76()
            let v114 : (std_string_String -> US28) = method77()
            let v115 : string = "match v112 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v116 : US28 = Fable.Core.RustInterop.emitRustExpr struct (v113, v114) v115 
            let v122 : string =
                match v116 with
                | US28_1(v118) -> (* Error *)
                    let v119 : string = $"resultm.get / Result value was Error: {v118}"
                    failwith<string> v119
                | US28_0(v117) -> (* Ok *)
                    v117
            let v123 : string = method26()
            let v124 : bool = true
            let mutable _v124 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v125 : string = method27(v5)
            let v126 : string = $"regex::Regex::new(&$0)"
            let v127 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v14 v126 
            let v128 : string = "$0.unwrap()"
            let v129 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v127 v128 
            let v130 : string = $"$0.replace_all(&$1, &*$2)"
            let v131 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v129, v125, v123) v130 
            let v132 : string = "String::from($0)"
            let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr v131 v132 
            let v134 : string = "fable_library_rust::String_::fromString($0)"
            let v135 : string = Fable.Core.RustInterop.emitRustExpr v133 v134 
            v135 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v136 : string = null |> unbox<string>
            v136 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v137 : string = null |> unbox<string>
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
#else
            let v140 : string = method28()
            let v141 : string = System.Text.RegularExpressions.Regex.Replace (v5, v140, v123)
            v141 
            #endif
            |> fun x -> _v124 <- Some x
            let v142 : string = match _v124 with Some x -> x | None -> failwith "base.run_target / _v124=None"
            let v143 : string = $"{v142.[0] |> string |> _.ToLower()}{v142.[1..]}"
            let v144 : string = v143.Replace (v32, v33)
            let v145 : string = "std::fs::File::open(&*v144)"
            let v146 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v145 
            let v147 : string = "$0.unwrap()"
            let v148 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v146 v147 
            let v149 : string = "std::io::BufReader::new(v148)"
            let v150 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v149 
            let v151 : string = "std::io::BufReader::new(v150)"
            let v152 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr () v151 
            let v153 : string = "true; let mut v152 = v152"
            let v154 : bool = Fable.Core.RustInterop.emitRustExpr () v153 
            let v155 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v155 
            let v156 : string = "result"
            let v157 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v156 
            let v158 : string = "true; let mut v157 = v157"
            let v159 : bool = Fable.Core.RustInterop.emitRustExpr () v158 
            let v160 : unativeint = 0 |> unativeint 
            let v161 : string = "[$0; 1024]"
            let v162 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v161 
            let v163 : string = "true; loop { // rust.loop"
            let v164 : bool = Fable.Core.RustInterop.emitRustExpr () v163 
            let v165 : string = "true; let mut v162 = v162"
            let v166 : bool = Fable.Core.RustInterop.emitRustExpr () v165 
            let v167 : string = "std::io::Read::read(&mut v152, &mut v162)"
            let v168 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v167 
            let v169 : string = "$0.unwrap()"
            let v170 : unativeint = Fable.Core.RustInterop.emitRustExpr v168 v169 
            let v171 : bool = v170 = v160 
            if v171 then
                let v172 : string = "true; break"
                let v173 : bool = Fable.Core.RustInterop.emitRustExpr () v172 
                ()
            let v174 : string = "v162.len()"
            let v175 : unativeint = Fable.Core.RustInterop.emitRustExpr () v174 
            let v176 : uint8 = v175 |> uint8 
            let v177 : unativeint = v170 |> unativeint 
            let v178 : unativeint = v177 |> unbox<unativeint>
            let v179 : bool = v178 = v175 
            let v184 : Ref<Slice'<uint8>> =
                if v179 then
                    let v180 : string = "&v162[v160..]"
                    let v181 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v180 
                    v181
                else
                    let v182 : string = "&v162[$0..$1]"
                    let v183 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v160, v177) v182 
                    v183
            let v185 : string = "sha2::Digest::update(&mut v157, v184)"
            Fable.Core.RustInterop.emitRustExpr () v185 
            let v186 : string = "true; } // rust.loop"
            let v187 : bool = Fable.Core.RustInterop.emitRustExpr () v186 
            let v188 : string = "true; } // rust.loop"
            let v189 : bool = Fable.Core.RustInterop.emitRustExpr () v188 
            let v190 : string = "true; } // rust.loop"
            let v191 : bool = Fable.Core.RustInterop.emitRustExpr () v190 
            let v192 : string = "true; { // rust.loop"
            let v193 : bool = Fable.Core.RustInterop.emitRustExpr () v192 
            let v194 : string = "true; { // rust.loop"
            let v195 : bool = Fable.Core.RustInterop.emitRustExpr () v194 
            let v196 : string = "&sha2::Digest::finalize(v157)"
            let v197 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v196 
            let v198 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v199 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v197 v198 
            let v200 : string = "true; let _result : Vec<_> = v199.into_iter().map(|x| { //"
            let v201 : bool = Fable.Core.RustInterop.emitRustExpr () v200 
            let v202 : string = "x"
            let v203 : uint8 = Fable.Core.RustInterop.emitRustExpr () v202 
            let v204 : string = "format!(\"{:02x}\", $0)"
            let v205 : std_string_String = Fable.Core.RustInterop.emitRustExpr v203 v204 
            let v206 : string = "fable_library_rust::String_::fromString($0)"
            let v207 : string = Fable.Core.RustInterop.emitRustExpr v205 v206 
            let v208 : string = "true; $0 }).collect::<Vec<_>>()"
            let v209 : bool = Fable.Core.RustInterop.emitRustExpr v207 v208 
            let v210 : string = "_result"
            let v211 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v210 
            let v212 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v213 : (string []) = Fable.Core.RustInterop.emitRustExpr v211 v212 
            let v214 : string seq = seq { for i = 0 to v213.Length - 1 do yield v213.[i] }
            let v215 : (string -> (string seq -> string)) = String.concat
            let v216 : (string seq -> string) = v215 v106
            let v217 : string = v216 v214
            let v218 : Result<string, std_io_Error> = Ok v217 
            let v219 : (std_io_Error -> std_string_String) = method35()
            let v220 : string = "$0.map_err(|x| $1(x))"
            let v221 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v218, v219) v220 
            let v222 : (string -> US28) = method76()
            let v223 : (std_string_String -> US28) = method77()
            let v224 : string = "match v221 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v225 : US28 = Fable.Core.RustInterop.emitRustExpr struct (v222, v223) v224 
            let v231 : string =
                match v225 with
                | US28_1(v227) -> (* Error *)
                    let v228 : string = $"resultm.get / Result value was Error: {v227}"
                    failwith<string> v228
                | US28_0(v226) -> (* Ok *)
                    v226
            let v232 : bool = v122 = v231
            v232
        else
            false
    let v234 : bool = v233 = false
    if v234 then
        let v235 : US29 = method87(v2, v6, v3, v1, v4)
        match v235 with
        | US29_1(v250, v251) -> (* Error *)
            let v252 : (string * string) = v6, v251 
            let v253 : Result<string, (string * string)> = Error v252 
            US27_0(v253)
        | US29_0(v236, v237) -> (* Ok *)
            let v238 : bool = v236 <> 0 
            if v238 then
                let v239 : US0 = US0_2
                let v240 : (unit -> string) = closure61()
                let v241 : (unit -> string) = closure62(v237, v236)
                method5(v239, v240, v241)
                let v242 : (string * string) = v6, v237 
                let v243 : Result<string, (string * string)> = Error v242 
                US27_0(v243)
            else
                let v245 : bool = method78(v6)
                if v245 then
                    method79(v5, v6)
                else
                    let v246 : string = $"documents.files_fn / {v6} should exist"
                    failwith<unit> v246
                let v247 : Result<string, (string * string)> = Ok v6 
                US27_0(v247)
    else
        US27_1
and closure63 (v0 : string, v1 : string, v2 : bool) (v3 : string) : (string -> US27) =
    closure64(v0, v1, v2, v3)
and closure67 () () : string =
    let v0 : string = "documents.run / par_map / files' = [] / listm.iter"
    v0
and closure68 (v0 : string, v1 : string) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"output_path: %A{v1} / output_cache_path: {v0} / {v2 ()}"
    v3
and method88 (v0 : UH3, v1 : UH4 list) : UH4 list =
    match v0 with
    | UH3_1(v2, v3) -> (* Cons *)
        let v4 : UH4 list = method88(v3, v1)
        let v5 : UH4 list = v2 :: v4 
        v5
    | UH3_0 -> (* Nil *)
        v1
and method89 (v0 : int32, v1 : Mut8) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method90 (v0 : UH4, v1 : struct (string * string * (string -> (string -> US27))) list) : struct (string * string * (string -> (string -> US27))) list =
    match v0 with
    | UH4_1(v2, v3, v4, v5) -> (* Cons *)
        let v6 : struct (string * string * (string -> (string -> US27))) list = method90(v5, v1)
        let v7 : struct (string * string * (string -> (string -> US27))) list = struct (v2, v3, v4) :: v6 
        v7
    | UH4_0 -> (* Nil *)
        v1
and closure69 () struct (v0 : string, v1 : string, v2 : (string -> (string -> US27))) : Result<string, (string * string)> option =
    let v3 : (string -> US27) = v2 v1
    let v4 : US27 = v3 v0
    match v4 with
    | US27_1 -> (* None *)
        let v7 : Result<string, (string * string)> option = None
        v7
    | US27_0(v5) -> (* Some *)
        let v6 : Result<string, (string * string)> option = Some v5 
        v6
and method91 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method92 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and closure22 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> =
    let v6 : string = method23(v5)
    let v7 : string = "&*$0"
    let v8 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : string = "String::from($0)"
    let v10 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v9 
    let v11 : string = "std::path::PathBuf::from($0)"
    let v12 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : string = "$0.display()"
    let v14 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v12 v13 
    let v15 : bool = true
    let mutable _v15 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v16 : string = "format!(\"{}\", $0)"
    let v17 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v16 
    v17 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v18 : string = "format!(\"{}\", $0)"
    let v19 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v18 
    v19 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v20 : string = "format!(\"{}\", $0)"
    let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v20 
    v21 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v22 : std_string_String = null |> unbox<std_string_String>
    v22 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : std_string_String = null |> unbox<std_string_String>
    v23 
    #endif
#else
    let v24 : std_string_String = null |> unbox<std_string_String>
    v24 
    #endif
    |> fun x -> _v15 <- Some x
    let v25 : std_string_String = match _v15 with Some x -> x | None -> failwith "base.run_target / _v15=None"
    let v26 : string = "fable_library_rust::String_::fromString($0)"
    let v27 : string = Fable.Core.RustInterop.emitRustExpr v25 v26 
    let v28 : string = ""
    let v29 : string = v27.Replace (v3, v28)
    let v30 : string = "\\"
    let v31 : string = "/"
    let v32 : string = v29.Replace (v30, v31)
    let v33 : string = $".{v32}"
    let v34 : string = method26()
    let v35 : bool = true
    let mutable _v35 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v36 : string = method27(v6)
    let v37 : string = $"regex::Regex::new(&$0)"
    let v38 : string = "^\\\\\\\\\\?\\\\"
    let v39 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v38 v37 
    let v40 : string = "$0.unwrap()"
    let v41 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = $"$0.replace_all(&$1, &*$2)"
    let v43 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v41, v36, v34) v42 
    let v44 : string = "String::from($0)"
    let v45 : std_string_String = Fable.Core.RustInterop.emitRustExpr v43 v44 
    let v46 : string = "fable_library_rust::String_::fromString($0)"
    let v47 : string = Fable.Core.RustInterop.emitRustExpr v45 v46 
    v47 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v48 : string = null |> unbox<string>
    v48 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v49 : string = null |> unbox<string>
    v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v50 : string = null |> unbox<string>
    v50 
    #endif
#if FABLE_COMPILER_PYTHON
    let v51 : string = null |> unbox<string>
    v51 
    #endif
#else
    let v52 : string = method28()
    let v53 : string = System.Text.RegularExpressions.Regex.Replace (v6, v52, v34)
    v53 
    #endif
    |> fun x -> _v35 <- Some x
    let v54 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v55 : string = $"{v54.[0] |> string |> _.ToLower()}{v54.[1..]}"
    let v56 : string = v55.Replace (v30, v31)
    let v57 : string = method15(v2, v33)
    let v58 : string = method40(v57)
    let v59 : System.Threading.CancellationToken option = None
    let v60 : (struct (string * string) []) = [||]
    let v61 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v62 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v63 : string option = None
    let v64 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v58}\""
    let v65 : string option = Some v2 
    let v66 : bool = true
    let struct (v67 : int32, v68 : string) = method41(v59, v64, v60, v61, v62, v66, v65)
    let v69 : string = method15(v3, v33)
    let v70 : string = method40(v69)
    let v71 : System.Threading.CancellationToken option = None
    let v72 : (struct (string * string) []) = [||]
    let v73 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v74 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v75 : string option = None
    let v76 : string = $"git hash-object \"{v70}\""
    let v77 : string option = Some v3 
    let v78 : bool = true
    let struct (v79 : int32, v80 : string) = method41(v71, v76, v72, v73, v74, v78, v77)
    let v81 : string = method15(v4, v33)
    let v82 : string = method40(v81)
    let v83 : string = "hangul.md"
    let struct (v84 : string, v85 : string) = method74(v83, v70, v4)
    let v86 : bool = false
    let v87 : bool = false
    let v88 : bool = false
    let v89 : bool = true
    let v90 : bool = true
    let v91 : bool = true
    let v92 : bool = v68.Contains v80 
    let v93 : bool = v92 = false
    let v352 : UH3 =
        if v93 then
            let v94 : string = method26()
            let v95 : bool = true
            let mutable _v95 : string option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v96 : string = method27(v70)
            let v97 : string = $"regex::Regex::new(&$0)"
            let v98 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v38 v97 
            let v99 : string = "$0.unwrap()"
            let v100 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v98 v99 
            let v101 : string = $"$0.replace_all(&$1, &*$2)"
            let v102 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v100, v96, v94) v101 
            let v103 : string = "String::from($0)"
            let v104 : std_string_String = Fable.Core.RustInterop.emitRustExpr v102 v103 
            let v105 : string = "fable_library_rust::String_::fromString($0)"
            let v106 : string = Fable.Core.RustInterop.emitRustExpr v104 v105 
            v106 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v107 : string = null |> unbox<string>
            v107 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v108 : string = null |> unbox<string>
            v108 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v109 : string = null |> unbox<string>
            v109 
            #endif
#if FABLE_COMPILER_PYTHON
            let v110 : string = null |> unbox<string>
            v110 
            #endif
#else
            let v111 : string = method28()
            let v112 : string = System.Text.RegularExpressions.Regex.Replace (v70, v111, v94)
            v112 
            #endif
            |> fun x -> _v95 <- Some x
            let v113 : string = match _v95 with Some x -> x | None -> failwith "base.run_target / _v95=None"
            let v114 : string = $"{v113.[0] |> string |> _.ToLower()}{v113.[1..]}"
            let v115 : string = v114.Replace (v30, v31)
            let v116 : string = "std::fs::File::open(&*v115)"
            let v117 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v116 
            let v118 : string = "$0.unwrap()"
            let v119 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v117 v118 
            let v120 : string = "std::io::BufReader::new(v119)"
            let v121 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v120 
            let v122 : string = "std::io::BufReader::new(v121)"
            let v123 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr () v122 
            let v124 : string = "true; let mut v123 = v123"
            let v125 : bool = Fable.Core.RustInterop.emitRustExpr () v124 
            let v126 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v126 
            let v127 : string = "result"
            let v128 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v127 
            let v129 : string = "true; let mut v128 = v128"
            let v130 : bool = Fable.Core.RustInterop.emitRustExpr () v129 
            let v131 : unativeint = 0 |> unativeint 
            let v132 : string = "[$0; 1024]"
            let v133 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v132 
            let v134 : string = "true; loop { // rust.loop"
            let v135 : bool = Fable.Core.RustInterop.emitRustExpr () v134 
            let v136 : string = "true; let mut v133 = v133"
            let v137 : bool = Fable.Core.RustInterop.emitRustExpr () v136 
            let v138 : string = "std::io::Read::read(&mut v123, &mut v133)"
            let v139 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v138 
            let v140 : string = "$0.unwrap()"
            let v141 : unativeint = Fable.Core.RustInterop.emitRustExpr v139 v140 
            let v142 : bool = v141 = v131 
            if v142 then
                let v143 : string = "true; break"
                let v144 : bool = Fable.Core.RustInterop.emitRustExpr () v143 
                ()
            let v145 : string = "v133.len()"
            let v146 : unativeint = Fable.Core.RustInterop.emitRustExpr () v145 
            let v147 : uint8 = v146 |> uint8 
            let v148 : unativeint = v141 |> unativeint 
            let v149 : unativeint = v148 |> unbox<unativeint>
            let v150 : bool = v149 = v146 
            let v155 : Ref<Slice'<uint8>> =
                if v150 then
                    let v151 : string = "&v133[v131..]"
                    let v152 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v151 
                    v152
                else
                    let v153 : string = "&v133[$0..$1]"
                    let v154 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v131, v148) v153 
                    v154
            let v156 : string = "sha2::Digest::update(&mut v128, v155)"
            Fable.Core.RustInterop.emitRustExpr () v156 
            let v157 : string = "true; } // rust.loop"
            let v158 : bool = Fable.Core.RustInterop.emitRustExpr () v157 
            let v159 : string = "true; } // rust.loop"
            let v160 : bool = Fable.Core.RustInterop.emitRustExpr () v159 
            let v161 : string = "true; } // rust.loop"
            let v162 : bool = Fable.Core.RustInterop.emitRustExpr () v161 
            let v163 : string = "true; { // rust.loop"
            let v164 : bool = Fable.Core.RustInterop.emitRustExpr () v163 
            let v165 : string = "true; { // rust.loop"
            let v166 : bool = Fable.Core.RustInterop.emitRustExpr () v165 
            let v167 : string = "&sha2::Digest::finalize(v128)"
            let v168 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v167 
            let v169 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v170 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v168 v169 
            let v171 : string = "true; let _result : Vec<_> = v170.into_iter().map(|x| { //"
            let v172 : bool = Fable.Core.RustInterop.emitRustExpr () v171 
            let v173 : string = "x"
            let v174 : uint8 = Fable.Core.RustInterop.emitRustExpr () v173 
            let v175 : string = "format!(\"{:02x}\", $0)"
            let v176 : std_string_String = Fable.Core.RustInterop.emitRustExpr v174 v175 
            let v177 : string = "fable_library_rust::String_::fromString($0)"
            let v178 : string = Fable.Core.RustInterop.emitRustExpr v176 v177 
            let v179 : string = "true; $0 }).collect::<Vec<_>>()"
            let v180 : bool = Fable.Core.RustInterop.emitRustExpr v178 v179 
            let v181 : string = "_result"
            let v182 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v181 
            let v183 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v184 : (string []) = Fable.Core.RustInterop.emitRustExpr v182 v183 
            let v185 : string seq = seq { for i = 0 to v184.Length - 1 do yield v184.[i] }
            let v186 : (string -> (string seq -> string)) = String.concat
            let v187 : (string seq -> string) = v186 v28
            let v188 : string = v187 v185
            let v189 : Result<string, std_io_Error> = Ok v188 
            let v190 : (std_io_Error -> std_string_String) = method35()
            let v191 : string = "$0.map_err(|x| $1(x))"
            let v192 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v189, v190) v191 
            let v193 : (string -> US28) = method76()
            let v194 : (std_string_String -> US28) = method77()
            let v195 : string = "match v192 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v196 : US28 = Fable.Core.RustInterop.emitRustExpr struct (v193, v194) v195 
            let v202 : string =
                match v196 with
                | US28_1(v198) -> (* Error *)
                    let v199 : string = $"resultm.get / Result value was Error: {v198}"
                    failwith<string> v199
                | US28_0(v197) -> (* Ok *)
                    v197
            let v203 : bool = method78(v82)
            let v204 : bool = v203 = false
            let v315 : US3 =
                if v204 then
                    US3_1
                else
                    let v206 : string = method26()
                    let v207 : bool = true
                    let mutable _v207 : string option = None 
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v208 : string = method27(v82)
                    let v209 : string = $"regex::Regex::new(&$0)"
                    let v210 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v38 v209 
                    let v211 : string = "$0.unwrap()"
                    let v212 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v210 v211 
                    let v213 : string = $"$0.replace_all(&$1, &*$2)"
                    let v214 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v212, v208, v206) v213 
                    let v215 : string = "String::from($0)"
                    let v216 : std_string_String = Fable.Core.RustInterop.emitRustExpr v214 v215 
                    let v217 : string = "fable_library_rust::String_::fromString($0)"
                    let v218 : string = Fable.Core.RustInterop.emitRustExpr v216 v217 
                    v218 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v219 : string = null |> unbox<string>
                    v219 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v220 : string = null |> unbox<string>
                    v220 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v221 : string = null |> unbox<string>
                    v221 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v222 : string = null |> unbox<string>
                    v222 
                    #endif
#else
                    let v223 : string = method28()
                    let v224 : string = System.Text.RegularExpressions.Regex.Replace (v82, v223, v206)
                    v224 
                    #endif
                    |> fun x -> _v207 <- Some x
                    let v225 : string = match _v207 with Some x -> x | None -> failwith "base.run_target / _v207=None"
                    let v226 : string = $"{v225.[0] |> string |> _.ToLower()}{v225.[1..]}"
                    let v227 : string = v226.Replace (v30, v31)
                    let v228 : string = "std::fs::File::open(&*v227)"
                    let v229 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v228 
                    let v230 : string = "$0.unwrap()"
                    let v231 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v229 v230 
                    let v232 : string = "std::io::BufReader::new(v231)"
                    let v233 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v232 
                    let v234 : string = "std::io::BufReader::new(v233)"
                    let v235 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr () v234 
                    let v236 : string = "true; let mut v235 = v235"
                    let v237 : bool = Fable.Core.RustInterop.emitRustExpr () v236 
                    let v238 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
                    Fable.Core.RustInterop.emitRustExpr () v238 
                    let v239 : string = "result"
                    let v240 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v239 
                    let v241 : string = "true; let mut v240 = v240"
                    let v242 : bool = Fable.Core.RustInterop.emitRustExpr () v241 
                    let v243 : unativeint = 0 |> unativeint 
                    let v244 : string = "[$0; 1024]"
                    let v245 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v244 
                    let v246 : string = "true; loop { // rust.loop"
                    let v247 : bool = Fable.Core.RustInterop.emitRustExpr () v246 
                    let v248 : string = "true; let mut v245 = v245"
                    let v249 : bool = Fable.Core.RustInterop.emitRustExpr () v248 
                    let v250 : string = "std::io::Read::read(&mut v235, &mut v245)"
                    let v251 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v250 
                    let v252 : string = "$0.unwrap()"
                    let v253 : unativeint = Fable.Core.RustInterop.emitRustExpr v251 v252 
                    let v254 : bool = v253 = v243 
                    if v254 then
                        let v255 : string = "true; break"
                        let v256 : bool = Fable.Core.RustInterop.emitRustExpr () v255 
                        ()
                    let v257 : string = "v245.len()"
                    let v258 : unativeint = Fable.Core.RustInterop.emitRustExpr () v257 
                    let v259 : uint8 = v258 |> uint8 
                    let v260 : unativeint = v253 |> unativeint 
                    let v261 : unativeint = v260 |> unbox<unativeint>
                    let v262 : bool = v261 = v258 
                    let v267 : Ref<Slice'<uint8>> =
                        if v262 then
                            let v263 : string = "&v245[v243..]"
                            let v264 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v263 
                            v264
                        else
                            let v265 : string = "&v245[$0..$1]"
                            let v266 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v243, v260) v265 
                            v266
                    let v268 : string = "sha2::Digest::update(&mut v240, v267)"
                    Fable.Core.RustInterop.emitRustExpr () v268 
                    let v269 : string = "true; } // rust.loop"
                    let v270 : bool = Fable.Core.RustInterop.emitRustExpr () v269 
                    let v271 : string = "true; } // rust.loop"
                    let v272 : bool = Fable.Core.RustInterop.emitRustExpr () v271 
                    let v273 : string = "true; } // rust.loop"
                    let v274 : bool = Fable.Core.RustInterop.emitRustExpr () v273 
                    let v275 : string = "true; { // rust.loop"
                    let v276 : bool = Fable.Core.RustInterop.emitRustExpr () v275 
                    let v277 : string = "true; { // rust.loop"
                    let v278 : bool = Fable.Core.RustInterop.emitRustExpr () v277 
                    let v279 : string = "&sha2::Digest::finalize(v240)"
                    let v280 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v279 
                    let v281 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
                    let v282 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v280 v281 
                    let v283 : string = "true; let _result : Vec<_> = v282.into_iter().map(|x| { //"
                    let v284 : bool = Fable.Core.RustInterop.emitRustExpr () v283 
                    let v285 : string = "x"
                    let v286 : uint8 = Fable.Core.RustInterop.emitRustExpr () v285 
                    let v287 : string = "format!(\"{:02x}\", $0)"
                    let v288 : std_string_String = Fable.Core.RustInterop.emitRustExpr v286 v287 
                    let v289 : string = "fable_library_rust::String_::fromString($0)"
                    let v290 : string = Fable.Core.RustInterop.emitRustExpr v288 v289 
                    let v291 : string = "true; $0 }).collect::<Vec<_>>()"
                    let v292 : bool = Fable.Core.RustInterop.emitRustExpr v290 v291 
                    let v293 : string = "_result"
                    let v294 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v293 
                    let v295 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v296 : (string []) = Fable.Core.RustInterop.emitRustExpr v294 v295 
                    let v297 : string seq = seq { for i = 0 to v296.Length - 1 do yield v296.[i] }
                    let v298 : (string -> (string seq -> string)) = String.concat
                    let v299 : (string seq -> string) = v298 v28
                    let v300 : string = v299 v297
                    let v301 : Result<string, std_io_Error> = Ok v300 
                    let v302 : (std_io_Error -> std_string_String) = method35()
                    let v303 : string = "$0.map_err(|x| $1(x))"
                    let v304 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v301, v302) v303 
                    let v305 : (string -> US28) = method76()
                    let v306 : (std_string_String -> US28) = method77()
                    let v307 : string = "match v304 { Ok(x) => $0(x), Err(e) => $1(e) }"
                    let v308 : US28 = Fable.Core.RustInterop.emitRustExpr struct (v305, v306) v307 
                    match v308 with
                    | US28_1(v311) -> (* Error *)
                        US3_1
                    | US28_0(v309) -> (* Ok *)
                        US3_0(v309)
            let v317 : bool =
                match v315 with
                | US3_1 -> (* None *)
                    true
                | _ ->
                    false
            let v323 : bool =
                if v317 then
                    true
                else
                    let v321 : string =
                        match v315 with
                        | US3_1 -> (* None *)
                            failwith<string> "Option does not have a value."
                        | US3_0(v318) -> (* Some *)
                            v318
                    let v322 : bool = v202 <> v321 
                    v322
            if v323 then
                let v324 : US0 = US0_2
                let v325 : (unit -> string) = closure54()
                let v326 : (unit -> string) = closure55(v33, v56, v58, v68, v67, v70, v80, v79, v82, v202, v315)
                method5(v324, v325, v326)
                method79(v82, v70)
                let v327 : (string -> (string -> US27)) = closure56(v4, v3, v1, v0)
                let v328 : UH4 = UH4_0
                let v329 : UH4 = UH4_1(v83, v70, v327, v328)
                let v330 : string = "html"
                let v331 : (string -> (string -> US27)) = closure63(v4, v3, v86)
                let v332 : string = "pdf"
                let v333 : (string -> (string -> US27)) = closure63(v4, v3, v87)
                let v334 : string = "epub"
                let v335 : (string -> (string -> US27)) = closure63(v4, v3, v88)
                let v336 : (string -> (string -> US27)) = closure63(v4, v3, v89)
                let v337 : (string -> (string -> US27)) = closure63(v4, v3, v90)
                let v338 : (string -> (string -> US27)) = closure63(v4, v3, v91)
                let v339 : UH4 = UH4_0
                let v340 : UH4 = UH4_1(v334, v85, v338, v339)
                let v341 : UH4 = UH4_1(v332, v85, v337, v340)
                let v342 : UH4 = UH4_1(v330, v85, v336, v341)
                let v343 : UH4 = UH4_1(v334, v70, v335, v342)
                let v344 : UH4 = UH4_1(v332, v70, v333, v343)
                let v345 : UH4 = UH4_1(v330, v70, v331, v344)
                let v346 : UH3 = UH3_0
                let v347 : UH3 = UH3_1(v345, v346)
                UH3_1(v329, v347)
            else
                UH3_0
        else
            UH3_0
    let v354 : bool =
        match v352 with
        | UH3_0 -> (* Nil *)
            true
        | _ ->
            false
    let v355 : bool = v354 <> true
    let v457 : UH3 =
        if v355 then
            v352
        else
            let v356 : string = "epub"
            let struct (v357 : string, v358 : string) = method74(v356, v85, v4)
            let v359 : bool = method78(v358)
            let v360 : bool = v359 = false
            let v366 : bool =
                if v360 then
                    let v361 : bool = method78(v357)
                    if v361 then
                        let v362 : US0 = US0_2
                        let v363 : (unit -> string) = closure67()
                        let v364 : (unit -> string) = closure68(v357, v358)
                        method5(v362, v363, v364)
                        method79(v358, v357)
                        false
                    else
                        true
                else
                    true
            let v371 : UH4 =
                if v366 then
                    let v367 : (string -> (string -> US27)) = closure63(v4, v3, v91)
                    let v368 : UH4 = UH4_0
                    UH4_1(v356, v85, v367, v368)
                else
                    UH4_0
            let v372 : string = "pdf"
            let struct (v373 : string, v374 : string) = method74(v372, v85, v4)
            let v375 : bool = method78(v374)
            let v376 : bool = v375 = false
            let v382 : bool =
                if v376 then
                    let v377 : bool = method78(v373)
                    if v377 then
                        let v378 : US0 = US0_2
                        let v379 : (unit -> string) = closure67()
                        let v380 : (unit -> string) = closure68(v373, v374)
                        method5(v378, v379, v380)
                        method79(v374, v373)
                        false
                    else
                        true
                else
                    true
            let v385 : UH4 =
                if v382 then
                    let v383 : (string -> (string -> US27)) = closure63(v4, v3, v90)
                    UH4_1(v372, v85, v383, v371)
                else
                    v371
            let v386 : string = "html"
            let struct (v387 : string, v388 : string) = method74(v386, v85, v4)
            let v389 : bool = method78(v388)
            let v390 : bool = v389 = false
            let v396 : bool =
                if v390 then
                    let v391 : bool = method78(v387)
                    if v391 then
                        let v392 : US0 = US0_2
                        let v393 : (unit -> string) = closure67()
                        let v394 : (unit -> string) = closure68(v387, v388)
                        method5(v392, v393, v394)
                        method79(v388, v387)
                        false
                    else
                        true
                else
                    true
            let v399 : UH4 =
                if v396 then
                    let v397 : (string -> (string -> US27)) = closure63(v4, v3, v89)
                    UH4_1(v386, v85, v397, v385)
                else
                    v385
            let struct (v400 : string, v401 : string) = method74(v356, v70, v4)
            let v402 : bool = method78(v401)
            let v403 : bool = v402 = false
            let v409 : bool =
                if v403 then
                    let v404 : bool = method78(v400)
                    if v404 then
                        let v405 : US0 = US0_2
                        let v406 : (unit -> string) = closure67()
                        let v407 : (unit -> string) = closure68(v400, v401)
                        method5(v405, v406, v407)
                        method79(v401, v400)
                        false
                    else
                        true
                else
                    true
            let v412 : UH4 =
                if v409 then
                    let v410 : (string -> (string -> US27)) = closure63(v4, v3, v88)
                    UH4_1(v356, v70, v410, v399)
                else
                    v399
            let struct (v413 : string, v414 : string) = method74(v372, v70, v4)
            let v415 : bool = method78(v414)
            let v416 : bool = v415 = false
            let v422 : bool =
                if v416 then
                    let v417 : bool = method78(v413)
                    if v417 then
                        let v418 : US0 = US0_2
                        let v419 : (unit -> string) = closure67()
                        let v420 : (unit -> string) = closure68(v413, v414)
                        method5(v418, v419, v420)
                        method79(v414, v413)
                        false
                    else
                        true
                else
                    true
            let v425 : UH4 =
                if v422 then
                    let v423 : (string -> (string -> US27)) = closure63(v4, v3, v87)
                    UH4_1(v372, v70, v423, v412)
                else
                    v412
            let struct (v426 : string, v427 : string) = method74(v386, v70, v4)
            let v428 : bool = method78(v427)
            let v429 : bool = v428 = false
            let v435 : bool =
                if v429 then
                    let v430 : bool = method78(v426)
                    if v430 then
                        let v431 : US0 = US0_2
                        let v432 : (unit -> string) = closure67()
                        let v433 : (unit -> string) = closure68(v426, v427)
                        method5(v431, v432, v433)
                        method79(v427, v426)
                        false
                    else
                        true
                else
                    true
            let v438 : UH4 =
                if v435 then
                    let v436 : (string -> (string -> US27)) = closure63(v4, v3, v86)
                    UH4_1(v386, v70, v436, v425)
                else
                    v425
            let struct (v439 : string, v440 : string) = method74(v83, v70, v4)
            let v441 : bool = method78(v440)
            let v442 : bool = v441 = false
            let v448 : bool =
                if v442 then
                    let v443 : bool = method78(v439)
                    if v443 then
                        let v444 : US0 = US0_2
                        let v445 : (unit -> string) = closure67()
                        let v446 : (unit -> string) = closure68(v439, v440)
                        method5(v444, v445, v446)
                        method79(v440, v439)
                        false
                    else
                        true
                else
                    true
            let v453 : UH4 =
                if v448 then
                    let v449 : (string -> (string -> US27)) = closure56(v4, v3, v1, v0)
                    let v450 : UH4 = UH4_0
                    UH4_1(v83, v70, v449, v450)
                else
                    UH4_0
            let v454 : UH3 = UH3_0
            let v455 : UH3 = UH3_1(v438, v454)
            UH3_1(v453, v455)
    let v458 : UH4 list = []
    let v459 : UH4 list = method88(v457, v458)
    let v460 : (UH4 list -> (UH4 [])) = List.toArray
    let v461 : (UH4 []) = v460 v459
    let v462 : string = "$0.to_vec()"
    let v463 : Vec<UH4> = Fable.Core.RustInterop.emitRustExpr v461 v462 
    let v464 : (Result<string, (string * string)> option []) = [||]
    let v465 : string = "$0.to_vec()"
    let v466 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v464 v465 
    let v467 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v468 : (UH4 []) = Fable.Core.RustInterop.emitRustExpr v463 v467 
    let v469 : int32 = v468.Length
    let v470 : Mut8 = {l0 = 0; l1 = v466} : Mut8
    while method89(v469, v470) do
        let v472 : int32 = v470.l0
        let v473 : Vec<Result<string, (string * string)> option> = v470.l1
        let v474 : UH4 = v468.[int v472]
        let v475 : struct (string * string * (string -> (string -> US27))) list = []
        let v476 : struct (string * string * (string -> (string -> US27))) list = method90(v474, v475)
        let v477 : (struct (string * string * (string -> (string -> US27))) list -> (struct (string * string * (string -> (string -> US27))) [])) = List.toArray
        let v478 : (struct (string * string * (string -> (string -> US27))) []) = v477 v476
        let v479 : string = "$0.to_vec()"
        let v480 : Vec<struct (string * string * (string -> (string -> US27)))> = Fable.Core.RustInterop.emitRustExpr v478 v479 
        let v481 : string = "rayon::iter::IntoParallelIterator::into_par_iter(v480)"
        let v482 : rayon_vec_IntoIter<struct (string * string * (string -> (string -> US27)))> = Fable.Core.RustInterop.emitRustExpr () v481 
        let v483 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
        let v484 : (struct (string * string * (string -> (string -> US27))) -> Result<string, (string * string)> option) = closure69()
        let v485 : rayon_iter_Map<rayon_vec_IntoIter<struct (string * string * (string -> (string -> US27)))>> = Fable.Core.RustInterop.emitRustExpr struct (v482, v484) v483 
        let v486 : string = "rayon::iter::ParallelIterator::collect($0)"
        let v487 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v485 v486 
        let v488 : Vec<Result<string, (string * string)> option> = method91(v487)
        let v489 : Vec<Result<string, (string * string)> option> = method92(v473)
        let v490 : string = "true; let mut v489 = v489"
        let v491 : bool = Fable.Core.RustInterop.emitRustExpr () v490 
        let v492 : string = "true; v489.extend(v488)"
        let v493 : bool = Fable.Core.RustInterop.emitRustExpr () v492 
        let v494 : string = "v489"
        let v495 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr () v494 
        let v496 : int32 = v472 + 1
        v470.l0 <- v496
        v470.l1 <- v495
        ()
    let v497 : Vec<Result<string, (string * string)> option> = v470.l1
    let v498 : (string * Vec<Result<string, (string * string)> option>) = v56, v497 
    let v499 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v498 
    v499
and closure70 () () : string =
    let v0 : string = "documents.run"
    v0
and closure71 (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) () : string =
    let v1 : string = "$0.len()"
    let v2 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"result_len: {v2} / {v3 ()}"
    v4
and method93 (v0 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>) : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> =
    v0
and method14 (v0 : string, v1 : string, v2 : string, v3 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> =
    let v4 : string = __SOURCE_DIRECTORY__
    let v5 : string = "polyglot"
    let v6 : string = ".paket"
    let v7 : string = method15(v5, v6)
    let v8 : string = method18(v7, v4)
    let v9 : string = method15(v8, v5)
    let v10 : string = method23(v3)
    let v11 : string = method23(v2)
    let v12 : string = method23(v1)
    let v13 : US0 = US0_1
    let v14 : (unit -> string) = closure9()
    let v15 : (unit -> string) = closure10(v0, v10, v11, v12)
    method5(v13, v14, v15)
    let v16 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v16 
    let v17 : string = "async_walkdir::WalkDir::new(&*$0)"
    let v18 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr v11 v17 
    let v19 : string = "async_walkdir::WalkDir::filter($0, |x| $1(x))"
    let v20 : (async_walkdir_DirEntry -> std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>>) = closure11()
    let v21 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr struct (v18, v20) v19 
    let v22 : (Result<async_walkdir_DirEntry, std_io_Error> -> string option) = method39()
    let v23 : string = "tokio_stream::StreamExt::collect(tokio_stream::StreamExt::filter_map(v21, |x| v22(x))).await"
    let v24 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v23 
    let v25 : US0 = US0_1
    let v26 : (unit -> string) = closure20()
    let v27 : (unit -> string) = closure21(v24)
    method5(v25, v26, v27)
    let v28 : string = "rayon::iter::IntoParallelIterator::into_par_iter(v24)"
    let v29 : rayon_vec_IntoIter<string> = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
    let v31 : (string -> Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>) = closure22(v0, v9, v10, v11, v12)
    let v32 : rayon_iter_Map<rayon_vec_IntoIter<string>> = Fable.Core.RustInterop.emitRustExpr struct (v29, v31) v30 
    let v33 : string = "rayon::iter::ParallelIterator::collect($0)"
    let v34 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = Fable.Core.RustInterop.emitRustExpr v32 v33 
    let v35 : US0 = US0_2
    let v36 : (unit -> string) = closure70()
    let v37 : (unit -> string) = closure71(v34)
    method5(v35, v36, v37)
    let v38 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Ok v34 
    let v39 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = method93(v38)
    let v40 : string = ""
    let v41 : string = "}"
    let v42 : string = v40 + v41 
    let v43 : string = v42 + v41 
    let v44 : string = v43 + v41 
    let v45 : string = v44 + v41 
    let v46 : string = "{"
    let v47 : string = v40 + v46 
    let v48 : string = v47 + v46 
    let v49 : string = v48 + v46 
    let v50 : string = "v39 " + v45 + "); " + v49 + " //"
    Fable.Core.RustInterop.emitRustExpr () v50 
    let v51 : string = "__result"
    let v52 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v51 
    v52
and closure1 () (v0 : (string [])) : int32 =
    let v1 : (US0 -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure2()
    let v2 : US0 = US0_2
    if State.trace_state.IsNone then State.trace_state <- v1 v2 |> Some
    let v3 : US0 = US0_2
    let v4 : (unit -> string) = closure4()
    let v5 : (unit -> string) = closure5(v0)
    method5(v3, v4, v5)
    let v6 : clap_Command = method0()
    let v7 : string = "clap::Command::get_matches($0)"
    let v8 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : string = method10()
    let v10 : string = "&*$0"
    let v11 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "clap::ArgMatches::get_one(&$0, v11).cloned()"
    let v13 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v8 v12 
    let v14 : US4 option = None
    let _v14 = ref v14 
    match v13 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v15 : std_string_String = x
    let v16 : US4 = US4_0(v15)
    v16 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v14.Value <- x
    let v17 : US4 option = _v14.Value 
    let v18 : US4 = US4_1
    let v19 : US4 = v17 |> Option.defaultValue v18 
    let v23 : std_string_String =
        match v19 with
        | US4_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US4_0(v20) -> (* Some *)
            v20
    let v24 : string = "fable_library_rust::String_::fromString($0)"
    let v25 : string = Fable.Core.RustInterop.emitRustExpr v23 v24 
    let v26 : string = method11()
    let v27 : string = "&*$0"
    let v28 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v26 v27 
    let v29 : string = "clap::ArgMatches::get_one(&$0, v28).cloned()"
    let v30 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v8 v29 
    let v31 : US4 option = None
    let _v31 = ref v31 
    match v30 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v32 : std_string_String = x
    let v33 : US4 = US4_0(v32)
    v33 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v31.Value <- x
    let v34 : US4 option = _v31.Value 
    let v35 : US4 = US4_1
    let v36 : US4 = v34 |> Option.defaultValue v35 
    let v40 : std_string_String =
        match v36 with
        | US4_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US4_0(v37) -> (* Some *)
            v37
    let v41 : string = "fable_library_rust::String_::fromString($0)"
    let v42 : string = Fable.Core.RustInterop.emitRustExpr v40 v41 
    let v43 : string = method12()
    let v44 : string = "&*$0"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v43 v44 
    let v46 : string = "clap::ArgMatches::get_one(&$0, v45).cloned()"
    let v47 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v8 v46 
    let v48 : US4 option = None
    let _v48 = ref v48 
    match v47 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v49 : std_string_String = x
    let v50 : US4 = US4_0(v49)
    v50 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v48.Value <- x
    let v51 : US4 option = _v48.Value 
    let v52 : US4 = US4_1
    let v53 : US4 = v51 |> Option.defaultValue v52 
    let v57 : std_string_String =
        match v53 with
        | US4_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US4_0(v54) -> (* Some *)
            v54
    let v58 : string = "fable_library_rust::String_::fromString($0)"
    let v59 : string = Fable.Core.RustInterop.emitRustExpr v57 v58 
    let v60 : string = method13()
    let v61 : string = "&*$0"
    let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v60 v61 
    let v63 : string = "clap::ArgMatches::get_one(&$0, v62).cloned()"
    let v64 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v8 v63 
    let v65 : US4 option = None
    let _v65 = ref v65 
    match v64 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v66 : std_string_String = x
    let v67 : US4 = US4_0(v66)
    v67 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v65.Value <- x
    let v68 : US4 option = _v65.Value 
    let v69 : US4 = US4_1
    let v70 : US4 = v68 |> Option.defaultValue v69 
    let v74 : std_string_String =
        match v70 with
        | US4_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US4_0(v71) -> (* Some *)
            v71
    let v75 : string = "fable_library_rust::String_::fromString($0)"
    let v76 : string = Fable.Core.RustInterop.emitRustExpr v74 v75 
    let v77 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = method14(v76, v59, v42, v25)
    let v78 : string = $"tokio::runtime::Builder::new_multi_thread().enable_all().build().unwrap()"
    let v79 : _ = Fable.Core.RustInterop.emitRustExpr () v78 
    let v80 : string = "v79.handle().block_on($0)"
    let v81 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Fable.Core.RustInterop.emitRustExpr v77 v80 
    let v82 : string = "$0.unwrap()"
    let v83 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = Fable.Core.RustInterop.emitRustExpr v81 v82 
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
