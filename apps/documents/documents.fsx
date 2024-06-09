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
    | US6_4 of f4_0 : US5
and [<Struct>] US7 =
    | US7_0 of f0_0 : string
    | US7_1 of f1_0 : string
and Mut4 = {mutable l0 : int32; mutable l1 : int32; mutable l2 : (string [])}
and Mut5 = {mutable l0 : int32}
and [<Struct>] US8 =
    | US8_0
    | US8_1
    | US8_2
and [<Struct>] US9 =
    | US9_0 of f0_0 : std_fs_FileType
    | US9_1 of f1_0 : std_string_String
and [<Struct>] US10 =
    | US10_0 of f0_0 : async_walkdir_DirEntry
    | US10_1 of f1_0 : std_string_String
and UH0 =
    | UH0_0
    | UH0_1 of char * UH0
and [<Struct>] US12 =
    | US12_0
    | US12_1
and [<Struct>] US11 =
    | US11_0
    | US11_1 of f1_0 : US12
    | US11_2
and [<Struct>] US13 =
    | US13_0 of f0_0 : (string [])
    | US13_1 of f1_0 : string
and UH1 =
    | UH1_0
    | UH1_1 of string * UH1
and [<Struct>] US14 =
    | US14_0 of f0_0 : UH1 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US14_1 of f1_0 : string
and [<Struct>] US15 =
    | US15_0 of f0_0 : char * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US15_1 of f1_0 : string
and [<Struct>] US16 =
    | US16_0 of f0_0 : char
    | US16_1
and [<Struct>] US17 =
    | US17_0 of f0_0 : string * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US17_1 of f1_0 : string
and UH2 =
    | UH2_0
    | UH2_1 of (struct (string * System.Text.StringBuilder * int32 * int32) -> US17) * UH2
and [<Struct>] US18 =
    | US18_0 of f0_0 : string * f0_1 : System.Text.StringBuilder * f0_2 : int32 * f0_3 : int32
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
    | US25_0 of f0_0 : int32
    | US25_1
and [<Struct>] US26 =
    | US26_0 of f0_0 : (struct (bool * string * int32) -> Async<unit>)
    | US26_1
and [<Struct>] US27 =
    | US27_0 of f0_0 : System.Threading.CancellationToken
    | US27_1
and [<Struct>] US28 =
    | US28_0 of f0_0 : Result<string, (string * string)>
    | US28_1
and UH4 =
    | UH4_0
    | UH4_1 of string * string * (string -> (string -> US28)) * UH4
and UH3 =
    | UH3_0
    | UH3_1 of UH4 * UH3
and [<Struct>] US29 =
    | US29_0 of f0_0 : string
    | US29_1 of f1_0 : std_string_String
and [<Struct>] US30 =
    | US30_0 of f0_0 : int32 * f0_1 : string
    | US30_1 of f1_0 : int32 * f1_1 : string
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
    let v47 : string = "process.env[$0] ?? \"\""
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
    let v5 : bool = "Verbose" = v3
    let v9 : US2 =
        if v5 then
            let v6 : US0 = US0_0
            US2_0(v6)
        else
            US2_1
    let v54 : US2 =
        match v9 with
        | US2_1 -> (* None *)
            let v13 : bool = "Debug" = v3
            let v17 : US2 =
                if v13 then
                    let v14 : US0 = US0_1
                    US2_0(v14)
                else
                    US2_1
            match v17 with
            | US2_1 -> (* None *)
                let v21 : bool = "Info" = v3
                let v25 : US2 =
                    if v21 then
                        let v22 : US0 = US0_2
                        US2_0(v22)
                    else
                        US2_1
                match v25 with
                | US2_1 -> (* None *)
                    let v29 : bool = "Warning" = v3
                    let v33 : US2 =
                        if v29 then
                            let v30 : US0 = US0_3
                            US2_0(v30)
                        else
                            US2_1
                    match v33 with
                    | US2_1 -> (* None *)
                        let v37 : bool = "Critical" = v3
                        let v41 : US2 =
                            if v37 then
                                let v38 : US0 = US0_4
                                US2_0(v38)
                            else
                                US2_1
                        match v41 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v42) -> (* Some *)
                            US2_0(v42)
                    | US2_0(v34) -> (* Some *)
                        US2_0(v34)
                | US2_0(v26) -> (* Some *)
                    US2_0(v26)
            | US2_0(v18) -> (* Some *)
                US2_0(v18)
        | US2_0(v10) -> (* Some *)
            US2_0(v10)
    let v55 : string = method4()
    let v56 : string = method2(v55)
    let v58 : bool = v56 = "True"
    let v64 : US1 =
        if v58 then
            let v59 : System.DateTime = System.DateTime.Now
            let v60 : (System.DateTime -> int64) = _.Ticks
            let v61 : int64 = v60 v59
            US1_0(v61)
        else
            US1_1
    struct (v64, v54) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v65 : US1 = US1_1
    let v66 : US2 = US2_1
    struct (v65, v66) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v67 : US1 = US1_1
    let v68 : US2 = US2_1
    struct (v67, v68) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v69 : string = method1()
    let v70 : string = method2(v69)
    let v72 : bool = "Verbose" = v70
    let v76 : US2 =
        if v72 then
            let v73 : US0 = US0_0
            US2_0(v73)
        else
            US2_1
    let v121 : US2 =
        match v76 with
        | US2_1 -> (* None *)
            let v80 : bool = "Debug" = v70
            let v84 : US2 =
                if v80 then
                    let v81 : US0 = US0_1
                    US2_0(v81)
                else
                    US2_1
            match v84 with
            | US2_1 -> (* None *)
                let v88 : bool = "Info" = v70
                let v92 : US2 =
                    if v88 then
                        let v89 : US0 = US0_2
                        US2_0(v89)
                    else
                        US2_1
                match v92 with
                | US2_1 -> (* None *)
                    let v96 : bool = "Warning" = v70
                    let v100 : US2 =
                        if v96 then
                            let v97 : US0 = US0_3
                            US2_0(v97)
                        else
                            US2_1
                    match v100 with
                    | US2_1 -> (* None *)
                        let v104 : bool = "Critical" = v70
                        let v108 : US2 =
                            if v104 then
                                let v105 : US0 = US0_4
                                US2_0(v105)
                            else
                                US2_1
                        match v108 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v109) -> (* Some *)
                            US2_0(v109)
                    | US2_0(v101) -> (* Some *)
                        US2_0(v101)
                | US2_0(v93) -> (* Some *)
                    US2_0(v93)
            | US2_0(v85) -> (* Some *)
                US2_0(v85)
        | US2_0(v77) -> (* Some *)
            US2_0(v77)
    let v122 : string = method4()
    let v123 : string = method2(v122)
    let v125 : bool = v123 = "True"
    let v131 : US1 =
        if v125 then
            let v126 : System.DateTime = System.DateTime.Now
            let v127 : (System.DateTime -> int64) = _.Ticks
            let v128 : int64 = v127 v126
            US1_0(v128)
        else
            US1_1
    struct (v131, v121) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v132 : string = method1()
    let v133 : string = method2(v132)
    let v135 : bool = "Verbose" = v133
    let v139 : US2 =
        if v135 then
            let v136 : US0 = US0_0
            US2_0(v136)
        else
            US2_1
    let v184 : US2 =
        match v139 with
        | US2_1 -> (* None *)
            let v143 : bool = "Debug" = v133
            let v147 : US2 =
                if v143 then
                    let v144 : US0 = US0_1
                    US2_0(v144)
                else
                    US2_1
            match v147 with
            | US2_1 -> (* None *)
                let v151 : bool = "Info" = v133
                let v155 : US2 =
                    if v151 then
                        let v152 : US0 = US0_2
                        US2_0(v152)
                    else
                        US2_1
                match v155 with
                | US2_1 -> (* None *)
                    let v159 : bool = "Warning" = v133
                    let v163 : US2 =
                        if v159 then
                            let v160 : US0 = US0_3
                            US2_0(v160)
                        else
                            US2_1
                    match v163 with
                    | US2_1 -> (* None *)
                        let v167 : bool = "Critical" = v133
                        let v171 : US2 =
                            if v167 then
                                let v168 : US0 = US0_4
                                US2_0(v168)
                            else
                                US2_1
                        match v171 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v172) -> (* Some *)
                            US2_0(v172)
                    | US2_0(v164) -> (* Some *)
                        US2_0(v164)
                | US2_0(v156) -> (* Some *)
                    US2_0(v156)
            | US2_0(v148) -> (* Some *)
                US2_0(v148)
        | US2_0(v140) -> (* Some *)
            US2_0(v140)
    let v185 : string = method4()
    let v186 : string = method2(v185)
    let v188 : bool = v186 = "True"
    let v194 : US1 =
        if v188 then
            let v189 : System.DateTime = System.DateTime.Now
            let v190 : (System.DateTime -> int64) = _.Ticks
            let v191 : int64 = v190 v189
            US1_0(v191)
        else
            US1_1
    struct (v194, v184) 
    #endif
#else
    let v195 : string = method1()
    let v196 : string = method2(v195)
    let v198 : bool = "Verbose" = v196
    let v202 : US2 =
        if v198 then
            let v199 : US0 = US0_0
            US2_0(v199)
        else
            US2_1
    let v247 : US2 =
        match v202 with
        | US2_1 -> (* None *)
            let v206 : bool = "Debug" = v196
            let v210 : US2 =
                if v206 then
                    let v207 : US0 = US0_1
                    US2_0(v207)
                else
                    US2_1
            match v210 with
            | US2_1 -> (* None *)
                let v214 : bool = "Info" = v196
                let v218 : US2 =
                    if v214 then
                        let v215 : US0 = US0_2
                        US2_0(v215)
                    else
                        US2_1
                match v218 with
                | US2_1 -> (* None *)
                    let v222 : bool = "Warning" = v196
                    let v226 : US2 =
                        if v222 then
                            let v223 : US0 = US0_3
                            US2_0(v223)
                        else
                            US2_1
                    match v226 with
                    | US2_1 -> (* None *)
                        let v230 : bool = "Critical" = v196
                        let v234 : US2 =
                            if v230 then
                                let v231 : US0 = US0_4
                                US2_0(v231)
                            else
                                US2_1
                        match v234 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v235) -> (* Some *)
                            US2_0(v235)
                    | US2_0(v227) -> (* Some *)
                        US2_0(v227)
                | US2_0(v219) -> (* Some *)
                    US2_0(v219)
            | US2_0(v211) -> (* Some *)
                US2_0(v211)
        | US2_0(v203) -> (* Some *)
            US2_0(v203)
    let v248 : string = method4()
    let v249 : string = method2(v248)
    let v251 : bool = v249 = "True"
    let v257 : US1 =
        if v251 then
            let v252 : System.DateTime = System.DateTime.Now
            let v253 : (System.DateTime -> int64) = _.Ticks
            let v254 : int64 = v253 v252
            US1_0(v254)
        else
            US1_1
    struct (v257, v247) 
    #endif
    |> fun x -> _v1 <- Some x
    let struct (v258 : US1, v259 : US2) = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    let v260 : Mut1 = {l0 = true} : Mut1
    let v261 : Mut0 = {l0 = 0L} : Mut0
    let v264 : US0 =
        match v259 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v262) -> (* Some *)
            v262
    let v265 : Mut2 = {l0 = v264} : Mut2
    let v266 : (string -> unit) = closure3()
    let v267 : Mut3 = {l0 = v266} : Mut3
    let v272 : int64 option =
        match v258 with
        | US1_1 -> (* None *)
            let v270 : int64 option = None
            v270
        | US1_0(v268) -> (* Some *)
            let v269 : int64 option = Some v268 
            v269
    struct (v261, v260, v265, v272, v267)
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
    let v150 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v154 : US3 =
        if v150 then
            let v151 : string = "Verbose"
            US3_0(v151)
        else
            US3_1
    let v203 : US3 =
        match v154 with
        | US3_1 -> (* None *)
            let v159 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v163 : US3 =
                if v159 then
                    let v160 : string = "Debug"
                    US3_0(v160)
                else
                    US3_1
            match v163 with
            | US3_1 -> (* None *)
                let v168 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v172 : US3 =
                    if v168 then
                        let v169 : string = "Info"
                        US3_0(v169)
                    else
                        US3_1
                match v172 with
                | US3_1 -> (* None *)
                    let v177 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v181 : US3 =
                        if v177 then
                            let v178 : string = "Warning"
                            US3_0(v178)
                        else
                            US3_1
                    match v181 with
                    | US3_1 -> (* None *)
                        let v186 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v190 : US3 =
                            if v186 then
                                let v187 : string = "Critical"
                                US3_0(v187)
                            else
                                US3_1
                        match v190 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v191) -> (* Some *)
                            US3_0(v191)
                    | US3_0(v182) -> (* Some *)
                        US3_0(v182)
                | US3_0(v173) -> (* Some *)
                    US3_0(v173)
            | US3_0(v164) -> (* Some *)
                US3_0(v164)
        | US3_0(v155) -> (* Some *)
            US3_0(v155)
    let v207 : string =
        match v203 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v204) -> (* Some *)
            v204
    let v208 : (unit -> string) = v207.ToLower
    let v209 : string = v208 ()
    let v210 : string = v209.PadLeft (7, ' ')
    let v211 : bool = true
    let mutable _v211 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v226 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v220 : string = "inline_colorization::color_bright_red"
            let v221 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v220 
            v221
        | US0_1 -> (* Debug *)
            let v214 : string = "inline_colorization::color_bright_blue"
            let v215 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v214 
            v215
        | US0_2 -> (* Info *)
            let v216 : string = "inline_colorization::color_bright_green"
            let v217 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v216 
            v217
        | US0_0 -> (* Verbose *)
            let v212 : string = "inline_colorization::color_bright_black"
            let v213 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v212 
            v213
        | US0_3 -> (* Warning *)
            let v218 : string = "inline_colorization::color_yellow"
            let v219 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v218 
            v219
    let v227 : string = "&*$0"
    let v228 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v227 
    let v229 : string = "inline_colorization::color_reset"
    let v230 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v229 
    let v231 : string = "\"{v226}{v228}{v230}\""
    let v232 : string = @$"format!(" + v231 + ")"
    let v233 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v232 
    let v234 : string = "fable_library_rust::String_::fromString($0)"
    let v235 : string = Fable.Core.RustInterop.emitRustExpr v233 v234 
    v235 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v250 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v244 : string = "inline_colorization::color_bright_red"
            let v245 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v244 
            v245
        | US0_1 -> (* Debug *)
            let v238 : string = "inline_colorization::color_bright_blue"
            let v239 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v238 
            v239
        | US0_2 -> (* Info *)
            let v240 : string = "inline_colorization::color_bright_green"
            let v241 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v240 
            v241
        | US0_0 -> (* Verbose *)
            let v236 : string = "inline_colorization::color_bright_black"
            let v237 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v236 
            v237
        | US0_3 -> (* Warning *)
            let v242 : string = "inline_colorization::color_yellow"
            let v243 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v242 
            v243
    let v251 : string = "&*$0"
    let v252 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v251 
    let v253 : string = "inline_colorization::color_reset"
    let v254 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v253 
    let v255 : string = "\"{v250}{v252}{v254}\""
    let v256 : string = @$"format!(" + v255 + ")"
    let v257 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v256 
    let v258 : string = "fable_library_rust::String_::fromString($0)"
    let v259 : string = Fable.Core.RustInterop.emitRustExpr v257 v258 
    v259 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v274 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v268 : string = "inline_colorization::color_bright_red"
            let v269 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v268 
            v269
        | US0_1 -> (* Debug *)
            let v262 : string = "inline_colorization::color_bright_blue"
            let v263 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v262 
            v263
        | US0_2 -> (* Info *)
            let v264 : string = "inline_colorization::color_bright_green"
            let v265 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v264 
            v265
        | US0_0 -> (* Verbose *)
            let v260 : string = "inline_colorization::color_bright_black"
            let v261 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v260 
            v261
        | US0_3 -> (* Warning *)
            let v266 : string = "inline_colorization::color_yellow"
            let v267 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v266 
            v267
    let v275 : string = "&*$0"
    let v276 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v210 v275 
    let v277 : string = "inline_colorization::color_reset"
    let v278 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v277 
    let v279 : string = "\"{v274}{v276}{v278}\""
    let v280 : string = @$"format!(" + v279 + ")"
    let v281 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v280 
    let v282 : string = "fable_library_rust::String_::fromString($0)"
    let v283 : string = Fable.Core.RustInterop.emitRustExpr v281 v282 
    v283 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v210 
    #endif
#if FABLE_COMPILER_PYTHON
    v210 
    #endif
#else
    v210 
    #endif
    |> fun x -> _v211 <- Some x
    let v284 : string = match _v211 with Some x -> x | None -> failwith "base.run_target / _v211=None"
    let v285 : int64 = v5.l0
    let v286 : string = $"{v147} {v284} #{v285} %s{v1 ()} / %s{v2 ()}"
    let v287 : (char []) = [||]
    let v288 : string = v286.TrimStart v287 
    let v289 : (char []) = [|' '; '/'|]
    let v290 : string = v288.TrimEnd v289 
    v290
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
    let v31 : US6 = US6_2(v30)
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
    let v42 : US6 = US6_4(v41)
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
and method22 (v0 : string, v1 : string, v2 : string) : US7 =
    let v3 : string = method15(v2, v0)
    let v4 : bool = method19(v3)
    if v4 then
        US7_0(v2)
    else
        let v6 : (string -> string option) = method20()
        let v7 : string option = v6 v2
        let v8 : US3 option = None
        let _v8 = ref v8 
        match v7 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v9 : string = x
        let v10 : US3 = US3_0(v9)
        v10 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v8.Value <- x
        let v11 : US3 option = _v8.Value 
        let v12 : US3 = US3_1
        let v13 : US3 = v11 |> Option.defaultValue v12 
        match v13 with
        | US3_1 -> (* None *)
            let v16 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            US7_1(v16)
        | US3_0(v14) -> (* Some *)
            method22(v0, v1, v14)
and method18 (v0 : string, v1 : string) : US7 =
    let v2 : string = method15(v1, v0)
    let v3 : bool = method19(v2)
    if v3 then
        US7_0(v1)
    else
        let v5 : (string -> string option) = method20()
        let v6 : string option = v5 v1
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
            let v15 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            US7_1(v15)
        | US3_0(v13) -> (* Some *)
            method22(v0, v1, v13)
and closure9 () () : string =
    let v0 : string = "file_system.get_workspace_root"
    v0
and closure10 (v0 : string) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and method23 () : string =
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
    let v20 : string = null |> unbox<string>
    v20 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v21 : string = null |> unbox<string>
    v21 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v22 : string = null |> unbox<string>
    v22 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : string = null |> unbox<string>
    v23 
    #endif
#else
    let v24 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v25 : string = v24 ()
    v25 
    #endif
    |> fun x -> _v0 <- Some x
    let v26 : string = match _v0 with Some x -> x | None -> failwith "base.run_target / _v0=None"
    v26
and method25 (v0 : string) : string =
    v0
and method27 () : string =
    let v0 : string = ""
    v0
and method28 (v0 : string) : string =
    v0
and method29 () : string =
    let v0 : string = "^\\\\\\\\\\?\\\\"
    v0
and method26 (v0 : string) : string =
    let v1 : string = method27()
    let v2 : bool = true
    let mutable _v2 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method28(v0)
    let v4 : string = $"regex::Regex::new(&$0)"
    let v5 : string = "^\\\\\\\\\\?\\\\"
    let v6 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v5 v4 
    let v7 : string = "$0.unwrap()"
    let v8 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : string = $"$0.replace_all(&$1, &*$2)"
    let v10 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v8, v3, v1) v9 
    let v11 : string = "String::from($0)"
    let v12 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : string = "fable_library_rust::String_::fromString($0)"
    let v14 : string = Fable.Core.RustInterop.emitRustExpr v12 v13 
    v14 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : string = null |> unbox<string>
    v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = null |> unbox<string>
    v16 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : string = null |> unbox<string>
    v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v18 : string = null |> unbox<string>
    v18 
    #endif
#else
    let v19 : string = method29()
    let v20 : string = System.Text.RegularExpressions.Regex.Replace (v0, v19, v1)
    v20 
    #endif
    |> fun x -> _v2 <- Some x
    let v21 : string = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    let v22 : string = $"{v21.[0] |> string |> _.ToLower()}{v21.[1..]}"
    let v23 : string = "\\"
    let v24 : string = "/"
    let v25 : string = v22.Replace (v23, v24)
    v25
and method30 (v0 : int32, v1 : Mut4) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method31 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method32 () : char =
    let v0 : bool = true
    let mutable _v0 : char option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = "std::path::MAIN_SEPARATOR"
    let v2 : char = Fable.Core.RustInterop.emitRustExpr () v1 
    v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : char = System.IO.Path.DirectorySeparatorChar
    v3 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v4 : char = System.IO.Path.DirectorySeparatorChar
    v4 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v5 : char = System.IO.Path.DirectorySeparatorChar
    v5 
    #endif
#if FABLE_COMPILER_PYTHON
    let v6 : char = System.IO.Path.DirectorySeparatorChar
    v6 
    #endif
#else
    let v7 : char = System.IO.Path.DirectorySeparatorChar
    v7 
    #endif
    |> fun x -> _v0 <- Some x
    let v8 : char = match _v0 with Some x -> x | None -> failwith "base.run_target / _v0=None"
    v8
and method33 (v0 : string) : string =
    v0
and method24 (v0 : string) : string =
    let v1 : bool = true
    let mutable _v1 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method25(v0)
    let v3 : string = "&*$0"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "String::from($0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "std::path::PathBuf::from($0)"
    let v8 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v7 
    let v9 : string = "$0.exists()"
    let v10 : bool = Fable.Core.RustInterop.emitRustExpr v8 v9 
    let v11 : bool = v10 = false
    let v101 : string =
        if v11 then
            let v12 : string = method23()
            let v13 : string = method15(v12, v2)
            let v14 : string = method26(v13)
            let v15 : string = "/"
            let v16 : (string []) = v14.Split v15 
            let v17 : (string []) = [||]
            let v18 : int32 = v16.Length
            let v19 : Mut4 = {l0 = 0; l1 = 0; l2 = v17} : Mut4
            while method30(v18, v19) do
                let v21 : int32 = v19.l0
                let v22 : int32 =  -v21
                let v23 : int32 = v22 + v18
                let v24 : int32 = v23 - 1
                let struct (v25 : int32, v26 : (string [])) = v19.l1, v19.l2
                let v27 : string = v16.[int v24]
                let v28 : bool = ".." = v27
                let struct (v70 : int32, v71 : (string [])) =
                    if v28 then
                        let v29 : int32 = v25 + 1
                        struct (v29, v26)
                    else
                        let v30 : bool = "." = v27
                        if v30 then
                            struct (v25, v26)
                        else
                            let v31 : bool = 0 = v25
                            if v31 then
                                let v32 : string = ":"
                                let v33 : bool = v27.EndsWith v32 
                                if v33 then
                                    let v34 : string = $"{v12.[0]}:"
                                    let v35 : (string []) = [|v34|]
                                    let v36 : int32 = v35.Length
                                    let v37 : int32 = v26.Length
                                    let v38 : int32 = v36 + v37
                                    let v39 : (string []) = Array.zeroCreate<string> (v38)
                                    let v40 : Mut5 = {l0 = 0} : Mut5
                                    while method31(v38, v40) do
                                        let v42 : int32 = v40.l0
                                        let v43 : bool = v42 < v36
                                        let v47 : string =
                                            if v43 then
                                                let v44 : string = v35.[int v42]
                                                v44
                                            else
                                                let v45 : int32 = v42 - v36
                                                let v46 : string = v26.[int v45]
                                                v46
                                        v39.[int v42] <- v47
                                        let v48 : int32 = v42 + 1
                                        v40.l0 <- v48
                                        ()
                                    struct (0, v39)
                                else
                                    let v49 : (string []) = [|v27|]
                                    let v50 : int32 = v49.Length
                                    let v51 : int32 = v26.Length
                                    let v52 : int32 = v50 + v51
                                    let v53 : (string []) = Array.zeroCreate<string> (v52)
                                    let v54 : Mut5 = {l0 = 0} : Mut5
                                    while method31(v52, v54) do
                                        let v56 : int32 = v54.l0
                                        let v57 : bool = v56 < v50
                                        let v61 : string =
                                            if v57 then
                                                let v58 : string = v49.[int v56]
                                                v58
                                            else
                                                let v59 : int32 = v56 - v50
                                                let v60 : string = v26.[int v59]
                                                v60
                                        v53.[int v56] <- v61
                                        let v62 : int32 = v56 + 1
                                        v54.l0 <- v62
                                        ()
                                    struct (0, v53)
                            else
                                let v65 : int32 = v25 - 1
                                struct (v65, v26)
                let v72 : int32 = v21 + 1
                v19.l0 <- v72
                v19.l1 <- v70
                v19.l2 <- v71
                ()
            let struct (v73 : int32, v74 : (string [])) = v19.l1, v19.l2
            let v75 : string seq = seq { for i = 0 to v74.Length - 1 do yield v74.[i] }
            let v76 : char = method32()
            let v77 : (char -> string) = _.ToString()
            let v78 : string = v77 v76
            let v79 : (string -> (string seq -> string)) = String.concat
            let v80 : (string seq -> string) = v79 v78
            v80 v75
        else
            let v82 : string = "std::fs::canonicalize(&*$0)"
            let v83 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v2 v82 
            let v84 : string = "$0.unwrap()"
            let v85 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v83 v84 
            let v86 : string = "$0.display()"
            let v87 : std_path_Display = Fable.Core.RustInterop.emitRustExpr v85 v86 
            let v88 : bool = true
            let mutable _v88 : std_string_String option = None 
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v89 : string = "format!(\"{}\", $0)"
            let v90 : std_string_String = Fable.Core.RustInterop.emitRustExpr v87 v89 
            v90 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v91 : string = "format!(\"{}\", $0)"
            let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr v87 v91 
            v92 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v93 : string = "format!(\"{}\", $0)"
            let v94 : std_string_String = Fable.Core.RustInterop.emitRustExpr v87 v93 
            v94 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v95 : std_string_String = null |> unbox<std_string_String>
            v95 
            #endif
#if FABLE_COMPILER_PYTHON
            let v96 : std_string_String = null |> unbox<std_string_String>
            v96 
            #endif
#else
            let v97 : std_string_String = null |> unbox<std_string_String>
            v97 
            #endif
            |> fun x -> _v88 <- Some x
            let v98 : std_string_String = match _v88 with Some x -> x | None -> failwith "base.run_target / _v88=None"
            let v99 : string = "fable_library_rust::String_::fromString($0)"
            let v100 : string = Fable.Core.RustInterop.emitRustExpr v98 v99 
            v100
    v101 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v102 : string = null |> unbox<string>
    v102 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v103 : string = null |> unbox<string>
    v103 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v104 : string = null |> unbox<string>
    v104 
    #endif
#if FABLE_COMPILER_PYTHON
    let v105 : string = null |> unbox<string>
    v105 
    #endif
#else
    let v106 : string = method33(v0)
    let v107 : (string -> string) = System.IO.Path.GetFullPath
    let v108 : string = v107 v106
    v108 
    #endif
    |> fun x -> _v1 <- Some x
    let v109 : string = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v109
and closure11 () () : string =
    let v0 : string = "documents.run"
    v0
and closure12 (v0 : string, v1 : string, v2 : string, v3 : string) () : string =
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"source_dir: {v1} / dist_dir: {v2} / cache_dir: {v3} / hangul_spec: %A{v0} / {v4 ()}"
    v5
and method36 (v0 : async_walkdir_DirEntry) : async_walkdir_DirEntry =
    v0
and closure14 () (v0 : std_io_Error) : std_string_String =
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
and method37 () : (std_io_Error -> std_string_String) =
    closure14()
and closure15 () (v0 : std_fs_FileType) : US9 =
    US9_0(v0)
and closure16 () (v0 : std_string_String) : US9 =
    US9_1(v0)
and method38 (v0 : std_fs_FileType) : std_fs_FileType =
    v0
and method39 (v0 : US8) : US8 =
    v0
and method35 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US8>>, Send<Dyn<std_future_Future<US8>>>>>> =
    let v1 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : async_walkdir_DirEntry = method36(v0)
    let v3 : string = "Box::pin(async_walkdir::DirEntry::file_type(&v2))"
    let v4 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>, Send<Dyn<std_future_Future<Result<std_fs_FileType, std_io_Error>>>>>>> = Fable.Core.RustInterop.emitRustExpr () v3 
    let v5 : string = "v4.await"
    let v6 : Result<std_fs_FileType, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v5 
    let v7 : (std_io_Error -> std_string_String) = method37()
    let v8 : string = "$0.map_err(|x| $1(x))"
    let v9 : Result<std_fs_FileType, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6, v7) v8 
    let v10 : (std_fs_FileType -> US9) = closure15()
    let v11 : (std_string_String -> US9) = closure16()
    let v12 : US9 = match v9 with Ok x -> v10 x | Error x -> v11 x
    let v71 : US8 =
        match v12 with
        | US9_0(v13) -> (* Ok *)
            let v14 : std_fs_FileType = method38(v13)
            let v15 : string = "std::fs::FileType::is_dir(&v14)"
            let v16 : bool = Fable.Core.RustInterop.emitRustExpr () v15 
            if v16 then
                US8_0
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
                    US8_0
                else
                    US8_2
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
                US8_0
            else
                US8_2
    let v72 : US8 = method39(v71)
    let v73 : string = ""
    let v74 : string = "}"
    let v75 : string = v73 + v74 
    let v76 : string = v75 + v74 
    let v77 : string = "{"
    let v78 : string = v73 + v77 
    let v79 : string = "v72 " + v76 + "); " + v78 + " //"
    Fable.Core.RustInterop.emitRustExpr () v79 
    let v80 : string = "__result"
    let v81 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US8>>, Send<Dyn<std_future_Future<US8>>>>>> = Fable.Core.RustInterop.emitRustExpr () v80 
    v81
and method40 (v0 : async_walkdir_Filtering) : async_walkdir_Filtering =
    v0
and method34 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> =
    let v1 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<US8>>, Send<Dyn<std_future_Future<US8>>>>>> = method35(v0)
    let v3 : string = "v2.await"
    let v4 : US8 = Fable.Core.RustInterop.emitRustExpr () v3 
    let v13 : async_walkdir_Filtering =
        match v4 with
        | US8_2 -> (* Continue *)
            let v9 : string = "async_walkdir::Filtering::Continue"
            let v10 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v9 
            v10
        | US8_0 -> (* Ignore *)
            let v5 : string = "async_walkdir::Filtering::Ignore"
            let v6 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v5 
            v6
        | US8_1 -> (* IgnoreDir *)
            let v7 : string = "async_walkdir::Filtering::IgnoreDir"
            let v8 : async_walkdir_Filtering = Fable.Core.RustInterop.emitRustExpr () v7 
            v8
    let v14 : async_walkdir_Filtering = method40(v13)
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
and closure13 () (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>> =
    method34(v0)
and closure18 () (v0 : async_walkdir_DirEntry) : US10 =
    US10_0(v0)
and closure19 () (v0 : std_string_String) : US10 =
    US10_1(v0)
and closure20 () () : string =
    let v0 : string = "documents.run / stream_filter_map"
    v0
and closure21 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and closure17 () (v0 : Result<async_walkdir_DirEntry, std_io_Error>) : string option =
    let v1 : (std_io_Error -> std_string_String) = method37()
    let v2 : string = "$0.map_err(|x| $1(x))"
    let v3 : Result<async_walkdir_DirEntry, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v2 
    let v4 : (async_walkdir_DirEntry -> US10) = closure18()
    let v5 : (std_string_String -> US10) = closure19()
    let v6 : US10 = match v3 with Ok x -> v4 x | Error x -> v5 x
    let v32 : US3 =
        match v6 with
        | US10_1(v26) -> (* Error *)
            let v27 : US0 = US0_4
            let v28 : (unit -> string) = closure20()
            let v29 : (unit -> string) = closure21(v26)
            method5(v27, v28, v29)
            US3_1
        | US10_0(v7) -> (* Ok *)
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
and method41 () : (Result<async_walkdir_DirEntry, std_io_Error> -> string option) =
    closure17()
and closure22 () () : string =
    let v0 : string = "documents.run"
    v0
and closure23 (v0 : Vec<string>) () : string =
    let v1 : string = "$0.len()"
    let v2 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"files_len: {v2} / {v3 ()}"
    v4
and method42 (v0 : string) : string =
    let v1 : string = method24(v0)
    method26(v1)
and method44 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : string =
    v1
and method46 () : struct (string * string) =
    let v0 : string = ""
    struct (v0, v0)
and closure26 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure25 () (v0 : char) : (UH0 -> UH0) =
    closure26(v0)
and method47 () : (char -> (UH0 -> UH0)) =
    closure25()
and method48 (v0 : string, v1 : string, v2 : UH0, v3 : US11) : struct (string * string) =
    match v2 with
    | UH0_1(v4, v5) -> (* Cons *)
        let v6 : bool = '"' = v4
        if v6 then
            let v8 : bool = v1 = ""
            if v8 then
                let v9 : US12 = US12_0
                let v10 : US11 = US11_1(v9)
                method48(v0, v1, v5, v10)
            else
                match v3 with
                | US11_2 -> (* Arguments *)
                    let v38 : string = $"{v0}{v4}"
                    let v39 : US11 = US11_2
                    method48(v38, v1, v5, v39)
                | US11_1(v13) -> (* Path *)
                    match v13 with
                    | US12_0 -> (* Quoted *)
                        let v14 : US12 = US12_1
                        let v15 : US11 = US11_1(v14)
                        method48(v0, v1, v5, v15)
                    | _ ->
                        let v18 : bool = ' ' = v4
                        if v18 then
                            let v19 : US11 = US11_2
                            method48(v0, v1, v5, v19)
                        else
                            let v22 : string = $"{v1}{v4}"
                            method48(v0, v22, v5, v3)
                | US11_0 -> (* Start *)
                    let v29 : bool = ' ' = v4
                    if v29 then
                        let v30 : US11 = US11_2
                        method48(v0, v1, v5, v30)
                    else
                        let v33 : string = $"{v1}{v4}"
                        method48(v0, v33, v5, v3)
        else
            let v50 : bool = ''' = v4
            if v50 then
                let v52 : bool = v1 = ""
                if v52 then
                    let v53 : US12 = US12_0
                    let v54 : US11 = US11_1(v53)
                    method48(v0, v1, v5, v54)
                else
                    match v3 with
                    | US11_2 -> (* Arguments *)
                        let v82 : string = $"{v0}{v4}"
                        let v83 : US11 = US11_2
                        method48(v82, v1, v5, v83)
                    | US11_1(v57) -> (* Path *)
                        match v57 with
                        | US12_0 -> (* Quoted *)
                            let v58 : US12 = US12_1
                            let v59 : US11 = US11_1(v58)
                            method48(v0, v1, v5, v59)
                        | _ ->
                            let v62 : bool = ' ' = v4
                            if v62 then
                                let v63 : US11 = US11_2
                                method48(v0, v1, v5, v63)
                            else
                                let v66 : string = $"{v1}{v4}"
                                method48(v0, v66, v5, v3)
                    | US11_0 -> (* Start *)
                        let v73 : bool = ' ' = v4
                        if v73 then
                            let v74 : US11 = US11_2
                            method48(v0, v1, v5, v74)
                        else
                            let v77 : string = $"{v1}{v4}"
                            method48(v0, v77, v5, v3)
            else
                match v3 with
                | US11_2 -> (* Arguments *)
                    let v126 : string = $"{v0}{v4}"
                    let v127 : US11 = US11_2
                    method48(v126, v1, v5, v127)
                | US11_1(v94) -> (* Path *)
                    match v94 with
                    | US12_0 -> (* Quoted *)
                        let v95 : bool = ' ' = v4
                        if v95 then
                            let v96 : string = $"{v1} "
                            let v97 : US12 = US12_0
                            let v98 : US11 = US11_1(v97)
                            method48(v0, v96, v5, v98)
                        else
                            let v101 : string = $"{v1}{v4}"
                            method48(v0, v101, v5, v3)
                    | _ ->
                        let v106 : bool = ' ' = v4
                        if v106 then
                            let v107 : US11 = US11_2
                            method48(v0, v1, v5, v107)
                        else
                            let v110 : string = $"{v1}{v4}"
                            method48(v0, v110, v5, v3)
                | US11_0 -> (* Start *)
                    let v117 : bool = ' ' = v4
                    if v117 then
                        let v118 : US11 = US11_2
                        method48(v0, v1, v5, v118)
                    else
                        let v121 : string = $"{v1}{v4}"
                        method48(v0, v121, v5, v3)
    | _ ->
        match v3 with
        | US11_2 -> (* Arguments *)
            let v152 : string = "\\"
            let v153 : string = "/"
            let v154 : string = v1.Replace (v152, v153)
            struct (v154, v0)
        | US11_1(v140) -> (* Path *)
            match v140 with
            | US12_0 -> (* Quoted *)
                let v141 : string = "\\"
                let v142 : string = "/"
                let v143 : string = v1.Replace (v141, v142)
                struct (v143, v0)
            | _ ->
                let v144 : string = "\\"
                let v145 : string = "/"
                let v146 : string = v1.Replace (v144, v145)
                struct (v146, v0)
        | US11_0 -> (* Start *)
            let v149 : string = "\\"
            let v150 : string = "/"
            let v151 : string = v1.Replace (v149, v150)
            struct (v151, v0)
and method45 (v0 : string) : struct (string * string) =
    let struct (v1 : string, v2 : string) = method46()
    let v3 : int32 = v0.Length
    let v4 : (char []) = Array.zeroCreate<char> (v3)
    let v5 : Mut5 = {l0 = 0} : Mut5
    while method31(v3, v5) do
        let v7 : int32 = v5.l0
        let v8 : char = v0.[int v7]
        v4.[int v7] <- v8
        let v9 : int32 = v7 + 1
        v5.l0 <- v9
        ()
    let v10 : ((char []) -> char list) = Array.toList
    let v11 : char list = v10 v4
    let v12 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v13 : (char -> (UH0 -> UH0)) = method47()
    let v14 : (char list -> (UH0 -> UH0)) = v12 v13
    let v15 : (UH0 -> UH0) = v14 v11
    let v16 : UH0 = UH0_0
    let v17 : UH0 = v15 v16
    let v18 : US11 = US11_0
    method48(v2, v1, v17, v18)
and method51 (v0 : char, v1 : int64) : bool =
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
            method51(v0, v25)
and method52 (v0 : UH0, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : struct (System.Text.StringBuilder * int32 * int32) =
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
        method52(v5, v17, v9, v10)
    | UH0_0 -> (* Nil *)
        struct (v1, v2, v3)
and method53 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US17 =
    let v5 : bool = "" = v1
    let v57 : US15 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = ' ' :: v6 
            let v8 : char list = '"' :: v7 
            let v9 : char list = '`' :: v8 
            let v10 : char list = '\\' :: v9 
            let v11 : (char list -> (char [])) = List.toArray
            let v12 : (char []) = v11 v10
            let v13 : string = $"parsing.none_of / unexpected end of input / chars: %A{v12} / s: %A{struct (v2, v3, v4)}"
            US15_1(v13)
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
            let v24 : bool = method51(v15, v23)
            let v25 : bool = v24 = false
            if v25 then
                let v26 : (char -> string) = _.ToString()
                let v27 : string = v26 v15
                let v28 : int32 = v27.Length
                let v29 : (char []) = Array.zeroCreate<char> (v28)
                let v30 : Mut5 = {l0 = 0} : Mut5
                while method31(v28, v30) do
                    let v32 : int32 = v30.l0
                    let v33 : char = v27.[int v32]
                    v29.[int v32] <- v33
                    let v34 : int32 = v32 + 1
                    v30.l0 <- v34
                    ()
                let v35 : ((char []) -> char list) = Array.toList
                let v36 : char list = v35 v29
                let v37 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v38 : (char -> (UH0 -> UH0)) = method47()
                let v39 : (char list -> (UH0 -> UH0)) = v37 v38
                let v40 : (UH0 -> UH0) = v39 v36
                let v41 : UH0 = UH0_0
                let v42 : UH0 = v40 v41
                let struct (v43 : System.Text.StringBuilder, v44 : int32, v45 : int32) = method52(v42, v2, v3, v4)
                US15_0(v15, v22, v43, v44, v45)
            else
                let v47 : char list = []
                let v48 : char list = ' ' :: v47 
                let v49 : char list = '"' :: v48 
                let v50 : char list = '`' :: v49 
                let v51 : char list = '\\' :: v50 
                let v52 : (char list -> (char [])) = List.toArray
                let v53 : (char []) = v52 v51
                let v54 : string = $"parsing.none_of / unexpected char: '{v15}' / chars: %A{v53} / s: %A{struct (v2, v3, v4)}"
                US15_1(v54)
    match v57 with
    | US15_1(v67) -> (* Error *)
        US17_0(v0, v1, v2, v3, v4)
    | US15_0(v58, v59, v60, v61, v62) -> (* Ok *)
        let v63 : (char -> string) = _.ToString()
        let v64 : string = v63 v58
        let v65 : string = v0 + v64 
        method53(v65, v59, v60, v61, v62)
and method55 (v0 : char, v1 : int64) : bool =
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
            method55(v0, v21)
and closure27 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US17 =
    let v4 : bool = "" = v0
    let v60 : US15 =
        if v4 then
            let v5 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v1, v2, v3)}"
            US15_1(v5)
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
                while method31(v18, v20) do
                    let v22 : int32 = v20.l0
                    let v23 : char = v17.[int v22]
                    v19.[int v22] <- v23
                    let v24 : int32 = v22 + 1
                    v20.l0 <- v24
                    ()
                let v25 : ((char []) -> char list) = Array.toList
                let v26 : char list = v25 v19
                let v27 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v28 : (char -> (UH0 -> UH0)) = method47()
                let v29 : (char list -> (UH0 -> UH0)) = v27 v28
                let v30 : (UH0 -> UH0) = v29 v26
                let v31 : UH0 = UH0_0
                let v32 : UH0 = v30 v31
                let struct (v33 : System.Text.StringBuilder, v34 : int32, v35 : int32) = method52(v32, v1, v2, v3)
                US15_0(v7, v15, v33, v34, v35)
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
                US15_1(v57)
    let v102 : US15 =
        match v60 with
        | US15_1(v99) -> (* Error *)
            US15_1(v99)
        | US15_0(v61, v62, v63, v64, v65) -> (* Ok *)
            let v66 : bool = "" = v62
            if v66 then
                let v67 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v63, v64, v65)}"
                US15_1(v67)
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
                while method31(v79, v81) do
                    let v83 : int32 = v81.l0
                    let v84 : char = v78.[int v83]
                    v80.[int v83] <- v84
                    let v85 : int32 = v83 + 1
                    v81.l0 <- v85
                    ()
                let v86 : ((char []) -> char list) = Array.toList
                let v87 : char list = v86 v80
                let v88 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v89 : (char -> (UH0 -> UH0)) = method47()
                let v90 : (char list -> (UH0 -> UH0)) = v88 v89
                let v91 : (UH0 -> UH0) = v90 v87
                let v92 : UH0 = UH0_0
                let v93 : UH0 = v91 v92
                let struct (v94 : System.Text.StringBuilder, v95 : int32, v96 : int32) = method52(v93, v63, v64, v65)
                US15_0(v69, v76, v94, v95, v96)
    match v102 with
    | US15_1(v110) -> (* Error *)
        US17_1(v110)
    | US15_0(v103, v104, v105, v106, v107) -> (* Ok *)
        let v108 : string = $"{'\\'}{v103}"
        US17_0(v108, v104, v105, v106, v107)
and closure28 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US17 =
    let v4 : bool = "" = v0
    let v60 : US15 =
        if v4 then
            let v5 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v1, v2, v3)}"
            US15_1(v5)
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
                while method31(v18, v20) do
                    let v22 : int32 = v20.l0
                    let v23 : char = v17.[int v22]
                    v19.[int v22] <- v23
                    let v24 : int32 = v22 + 1
                    v20.l0 <- v24
                    ()
                let v25 : ((char []) -> char list) = Array.toList
                let v26 : char list = v25 v19
                let v27 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v28 : (char -> (UH0 -> UH0)) = method47()
                let v29 : (char list -> (UH0 -> UH0)) = v27 v28
                let v30 : (UH0 -> UH0) = v29 v26
                let v31 : UH0 = UH0_0
                let v32 : UH0 = v30 v31
                let struct (v33 : System.Text.StringBuilder, v34 : int32, v35 : int32) = method52(v32, v1, v2, v3)
                US15_0(v7, v15, v33, v34, v35)
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
                US15_1(v57)
    let v102 : US15 =
        match v60 with
        | US15_1(v99) -> (* Error *)
            US15_1(v99)
        | US15_0(v61, v62, v63, v64, v65) -> (* Ok *)
            let v66 : bool = "" = v62
            if v66 then
                let v67 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v63, v64, v65)}"
                US15_1(v67)
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
                while method31(v79, v81) do
                    let v83 : int32 = v81.l0
                    let v84 : char = v78.[int v83]
                    v80.[int v83] <- v84
                    let v85 : int32 = v83 + 1
                    v81.l0 <- v85
                    ()
                let v86 : ((char []) -> char list) = Array.toList
                let v87 : char list = v86 v80
                let v88 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v89 : (char -> (UH0 -> UH0)) = method47()
                let v90 : (char list -> (UH0 -> UH0)) = v88 v89
                let v91 : (UH0 -> UH0) = v90 v87
                let v92 : UH0 = UH0_0
                let v93 : UH0 = v91 v92
                let struct (v94 : System.Text.StringBuilder, v95 : int32, v96 : int32) = method52(v93, v63, v64, v65)
                US15_0(v69, v76, v94, v95, v96)
    match v102 with
    | US15_1(v110) -> (* Error *)
        US17_1(v110)
    | US15_0(v103, v104, v105, v106, v107) -> (* Ok *)
        let v108 : string = $"{'`'}{v103}"
        US17_0(v108, v104, v105, v106, v107)
and method56 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH2) : US17 =
    match v4 with
    | UH2_1(v7, v8) -> (* Cons *)
        let v9 : US17 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US17_1(v15) -> (* Error *)
            method56(v0, v1, v2, v3, v8)
        | US17_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH2_0 -> (* Nil *)
        let v5 : string = "choice / no parsers succeeded"
        US17_1(v5)
and method57 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = UH1_1(v2, v1)
        method57(v3, v4)
    | UH1_0 -> (* Nil *)
        v1
and method54 (v0 : UH1, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US14 =
    let v5 : bool = "" = v1
    let v55 : US15 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = '"' :: v6 
            let v8 : char list = '`' :: v7 
            let v9 : char list = '\\' :: v8 
            let v10 : (char list -> (char [])) = List.toArray
            let v11 : (char []) = v10 v9
            let v12 : string = $"parsing.none_of / unexpected end of input / chars: %A{v11} / s: %A{struct (v2, v3, v4)}"
            US15_1(v12)
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
            let v23 : bool = method55(v14, v22)
            let v24 : bool = v23 = false
            if v24 then
                let v25 : (char -> string) = _.ToString()
                let v26 : string = v25 v14
                let v27 : int32 = v26.Length
                let v28 : (char []) = Array.zeroCreate<char> (v27)
                let v29 : Mut5 = {l0 = 0} : Mut5
                while method31(v27, v29) do
                    let v31 : int32 = v29.l0
                    let v32 : char = v26.[int v31]
                    v28.[int v31] <- v32
                    let v33 : int32 = v31 + 1
                    v29.l0 <- v33
                    ()
                let v34 : ((char []) -> char list) = Array.toList
                let v35 : char list = v34 v28
                let v36 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v37 : (char -> (UH0 -> UH0)) = method47()
                let v38 : (char list -> (UH0 -> UH0)) = v36 v37
                let v39 : (UH0 -> UH0) = v38 v35
                let v40 : UH0 = UH0_0
                let v41 : UH0 = v39 v40
                let struct (v42 : System.Text.StringBuilder, v43 : int32, v44 : int32) = method52(v41, v2, v3, v4)
                US15_0(v14, v21, v42, v43, v44)
            else
                let v46 : char list = []
                let v47 : char list = '"' :: v46 
                let v48 : char list = '`' :: v47 
                let v49 : char list = '\\' :: v48 
                let v50 : (char list -> (char [])) = List.toArray
                let v51 : (char []) = v50 v49
                let v52 : string = $"parsing.none_of / unexpected char: '{v14}' / chars: %A{v51} / s: %A{struct (v2, v3, v4)}"
                US15_1(v52)
    let v67 : US17 =
        match v55 with
        | US15_1(v64) -> (* Error *)
            US17_1(v64)
        | US15_0(v56, v57, v58, v59, v60) -> (* Ok *)
            let v61 : (char -> string) = _.ToString()
            let v62 : string = v61 v56
            US17_0(v62, v57, v58, v59, v60)
    let v81 : US17 =
        match v67 with
        | US17_1(v73) -> (* Error *)
            let v74 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US17) = closure27()
            let v75 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US17) = closure28()
            let v76 : UH2 = UH2_0
            let v77 : UH2 = UH2_1(v75, v76)
            let v78 : UH2 = UH2_1(v74, v77)
            method56(v1, v2, v3, v4, v78)
        | US17_0(v68, v69, v70, v71, v72) -> (* Ok *)
            v67
    match v81 with
    | US17_1(v89) -> (* Error *)
        let v90 : UH1 = UH1_0
        let v91 : UH1 = method57(v0, v90)
        US14_0(v91, v1, v2, v3, v4)
    | US17_0(v82, v83, v84, v85, v86) -> (* Ok *)
        let v87 : UH1 = UH1_1(v82, v0)
        method54(v87, v83, v84, v85, v86)
and method58 (v0 : UH1, v1 : string list) : string list =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : string list = method58(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH1_0 -> (* Nil *)
        v1
and method59 (v0 : UH1, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US14 =
    let v5 : bool = "" = v1
    let v55 : US15 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = '"' :: v6 
            let v8 : char list = '`' :: v7 
            let v9 : char list = '\\' :: v8 
            let v10 : (char list -> (char [])) = List.toArray
            let v11 : (char []) = v10 v9
            let v12 : string = $"parsing.none_of / unexpected end of input / chars: %A{v11} / s: %A{struct (v2, v3, v4)}"
            US15_1(v12)
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
            let v23 : bool = method55(v14, v22)
            let v24 : bool = v23 = false
            if v24 then
                let v25 : (char -> string) = _.ToString()
                let v26 : string = v25 v14
                let v27 : int32 = v26.Length
                let v28 : (char []) = Array.zeroCreate<char> (v27)
                let v29 : Mut5 = {l0 = 0} : Mut5
                while method31(v27, v29) do
                    let v31 : int32 = v29.l0
                    let v32 : char = v26.[int v31]
                    v28.[int v31] <- v32
                    let v33 : int32 = v31 + 1
                    v29.l0 <- v33
                    ()
                let v34 : ((char []) -> char list) = Array.toList
                let v35 : char list = v34 v28
                let v36 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v37 : (char -> (UH0 -> UH0)) = method47()
                let v38 : (char list -> (UH0 -> UH0)) = v36 v37
                let v39 : (UH0 -> UH0) = v38 v35
                let v40 : UH0 = UH0_0
                let v41 : UH0 = v39 v40
                let struct (v42 : System.Text.StringBuilder, v43 : int32, v44 : int32) = method52(v41, v2, v3, v4)
                US15_0(v14, v21, v42, v43, v44)
            else
                let v46 : char list = []
                let v47 : char list = '"' :: v46 
                let v48 : char list = '`' :: v47 
                let v49 : char list = '\\' :: v48 
                let v50 : (char list -> (char [])) = List.toArray
                let v51 : (char []) = v50 v49
                let v52 : string = $"parsing.none_of / unexpected char: '{v14}' / chars: %A{v51} / s: %A{struct (v2, v3, v4)}"
                US15_1(v52)
    let v67 : US17 =
        match v55 with
        | US15_1(v64) -> (* Error *)
            US17_1(v64)
        | US15_0(v56, v57, v58, v59, v60) -> (* Ok *)
            let v61 : (char -> string) = _.ToString()
            let v62 : string = v61 v56
            US17_0(v62, v57, v58, v59, v60)
    match v67 with
    | US17_1(v75) -> (* Error *)
        let v76 : UH1 = UH1_0
        let v77 : UH1 = method57(v0, v76)
        US14_0(v77, v1, v2, v3, v4)
    | US17_0(v68, v69, v70, v71, v72) -> (* Ok *)
        let v73 : UH1 = UH1_1(v68, v0)
        method59(v73, v69, v70, v71, v72)
and method60 (v0 : string, v1 : int32) : int32 =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 >= v2
    if v3 then
        v1
    else
        let v4 : char = v0.[int v1]
        let v5 : bool = v4 = ' '
        if v5 then
            let v6 : int32 = v1 + 1
            method60(v0, v6)
        else
            v1
and method50 (v0 : UH1, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US14 =
    let v5 : bool = "" = v1
    let v57 : US15 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = ' ' :: v6 
            let v8 : char list = '"' :: v7 
            let v9 : char list = '`' :: v8 
            let v10 : char list = '\\' :: v9 
            let v11 : (char list -> (char [])) = List.toArray
            let v12 : (char []) = v11 v10
            let v13 : string = $"parsing.none_of / unexpected end of input / chars: %A{v12} / s: %A{struct (v2, v3, v4)}"
            US15_1(v13)
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
            let v24 : bool = method51(v15, v23)
            let v25 : bool = v24 = false
            if v25 then
                let v26 : (char -> string) = _.ToString()
                let v27 : string = v26 v15
                let v28 : int32 = v27.Length
                let v29 : (char []) = Array.zeroCreate<char> (v28)
                let v30 : Mut5 = {l0 = 0} : Mut5
                while method31(v28, v30) do
                    let v32 : int32 = v30.l0
                    let v33 : char = v27.[int v32]
                    v29.[int v32] <- v33
                    let v34 : int32 = v32 + 1
                    v30.l0 <- v34
                    ()
                let v35 : ((char []) -> char list) = Array.toList
                let v36 : char list = v35 v29
                let v37 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v38 : (char -> (UH0 -> UH0)) = method47()
                let v39 : (char list -> (UH0 -> UH0)) = v37 v38
                let v40 : (UH0 -> UH0) = v39 v36
                let v41 : UH0 = UH0_0
                let v42 : UH0 = v40 v41
                let struct (v43 : System.Text.StringBuilder, v44 : int32, v45 : int32) = method52(v42, v2, v3, v4)
                US15_0(v15, v22, v43, v44, v45)
            else
                let v47 : char list = []
                let v48 : char list = ' ' :: v47 
                let v49 : char list = '"' :: v48 
                let v50 : char list = '`' :: v49 
                let v51 : char list = '\\' :: v50 
                let v52 : (char list -> (char [])) = List.toArray
                let v53 : (char []) = v52 v51
                let v54 : string = $"parsing.none_of / unexpected char: '{v15}' / chars: %A{v53} / s: %A{struct (v2, v3, v4)}"
                US15_1(v54)
    let v69 : US17 =
        match v57 with
        | US15_1(v58) -> (* Error *)
            US17_1(v58)
        | US15_0(v60, v61, v62, v63, v64) -> (* Ok *)
            let v65 : (char -> string) = _.ToString()
            let v66 : string = v65 v60
            method53(v66, v61, v62, v63, v64)
    let v292 : US17 =
        match v69 with
        | US17_1(v75) -> (* Error *)
            let v131 : US15 =
                if v5 then
                    let v76 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v2, v3, v4)}"
                    US15_1(v76)
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
                        while method31(v89, v91) do
                            let v93 : int32 = v91.l0
                            let v94 : char = v88.[int v93]
                            v90.[int v93] <- v94
                            let v95 : int32 = v93 + 1
                            v91.l0 <- v95
                            ()
                        let v96 : ((char []) -> char list) = Array.toList
                        let v97 : char list = v96 v90
                        let v98 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v99 : (char -> (UH0 -> UH0)) = method47()
                        let v100 : (char list -> (UH0 -> UH0)) = v98 v99
                        let v101 : (UH0 -> UH0) = v100 v97
                        let v102 : UH0 = UH0_0
                        let v103 : UH0 = v101 v102
                        let struct (v104 : System.Text.StringBuilder, v105 : int32, v106 : int32) = method52(v103, v2, v3, v4)
                        US15_0(v78, v86, v104, v105, v106)
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
                        US15_1(v128)
            let v237 : US17 =
                match v131 with
                | US15_1(v234) -> (* Error *)
                    US17_1(v234)
                | US15_0(v132, v133, v134, v135, v136) -> (* Ok *)
                    let v137 : UH1 = UH1_0
                    let v138 : US14 = method54(v137, v133, v134, v135, v136)
                    let v155 : US17 =
                        match v138 with
                        | US14_1(v152) -> (* Error *)
                            US17_1(v152)
                        | US14_0(v139, v140, v141, v142, v143) -> (* Ok *)
                            let v144 : string list = []
                            let v145 : string list = method58(v139, v144)
                            let v146 : string seq = seq { for i = 0 to v145.Length - 1 do yield v145.[i] }
                            let v147 : (string -> (string seq -> string)) = String.concat
                            let v148 : string = ""
                            let v149 : (string seq -> string) = v147 v148
                            let v150 : string = v149 v146
                            US17_0(v150, v140, v141, v142, v143)
                    match v155 with
                    | US17_1(v229) -> (* Error *)
                        let v230 : string = "between / expected content"
                        US17_1(v230)
                    | US17_0(v156, v157, v158, v159, v160) -> (* Ok *)
                        let v161 : bool = "" = v157
                        let v217 : US15 =
                            if v161 then
                                let v162 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v158, v159, v160)}"
                                US15_1(v162)
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
                                    while method31(v175, v177) do
                                        let v179 : int32 = v177.l0
                                        let v180 : char = v174.[int v179]
                                        v176.[int v179] <- v180
                                        let v181 : int32 = v179 + 1
                                        v177.l0 <- v181
                                        ()
                                    let v182 : ((char []) -> char list) = Array.toList
                                    let v183 : char list = v182 v176
                                    let v184 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                                    let v185 : (char -> (UH0 -> UH0)) = method47()
                                    let v186 : (char list -> (UH0 -> UH0)) = v184 v185
                                    let v187 : (UH0 -> UH0) = v186 v183
                                    let v188 : UH0 = UH0_0
                                    let v189 : UH0 = v187 v188
                                    let struct (v190 : System.Text.StringBuilder, v191 : int32, v192 : int32) = method52(v189, v158, v159, v160)
                                    US15_0(v164, v172, v190, v191, v192)
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
                                    US15_1(v214)
                        match v217 with
                        | US15_1(v224) -> (* Error *)
                            let v225 : string = $"between / expected closing delimiter / e: %A{v224} / input: %A{struct (v1, v2, v3, v4)} / rest1: %A{struct (v133, v134, v135, v136)} / rest2: %A{struct (v157, v158, v159, v160)}"
                            US17_1(v225)
                        | US15_0(v218, v219, v220, v221, v222) -> (* Ok *)
                            US17_0(v156, v219, v220, v221, v222)
            match v237 with
            | US17_1(v243) -> (* Error *)
                let v244 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US17) = closure27()
                let v245 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US17) = closure28()
                let v246 : UH2 = UH2_0
                let v247 : UH2 = UH2_1(v245, v246)
                let v248 : UH2 = UH2_1(v244, v247)
                let v249 : US17 = method56(v1, v2, v3, v4, v248)
                let v260 : US17 =
                    match v249 with
                    | US17_1(v257) -> (* Error *)
                        US17_1(v257)
                    | US17_0(v250, v251, v252, v253, v254) -> (* Ok *)
                        let v255 : string = ""
                        US17_0(v255, v251, v252, v253, v254)
                let v271 : US14 =
                    match v260 with
                    | US17_1(v268) -> (* Error *)
                        US14_1(v268)
                    | US17_0(v261, v262, v263, v264, v265) -> (* Ok *)
                        let v266 : UH1 = UH1_0
                        method59(v266, v262, v263, v264, v265)
                match v271 with
                | US14_1(v285) -> (* Error *)
                    US17_1(v285)
                | US14_0(v272, v273, v274, v275, v276) -> (* Ok *)
                    let v277 : string list = []
                    let v278 : string list = method58(v272, v277)
                    let v279 : string seq = seq { for i = 0 to v278.Length - 1 do yield v278.[i] }
                    let v280 : (string -> (string seq -> string)) = String.concat
                    let v281 : string = ""
                    let v282 : (string seq -> string) = v280 v281
                    let v283 : string = v282 v279
                    US17_0(v283, v273, v274, v275, v276)
            | US17_0(v238, v239, v240, v241, v242) -> (* Ok *)
                v237
        | US17_0(v70, v71, v72, v73, v74) -> (* Ok *)
            v69
    match v292 with
    | US17_1(v293) -> (* Error *)
        let v294 : UH1 = UH1_0
        let v295 : UH1 = method57(v0, v294)
        US14_0(v295, v1, v2, v3, v4)
    | US17_0(v297, v298, v299, v300, v301) -> (* Ok *)
        let v302 : int32 = 0
        let v303 : int32 = method60(v298, v302)
        let v304 : bool = 0 = v303
        let v315 : US18 =
            if v304 then
                let v305 : string = "spaces1 / expected at least one space"
                US18_1(v305)
            else
                let v307 : (string -> int32) = String.length
                let v308 : int32 = v307 v298
                let v309 : (int32 -> int32) = int32
                let v310 : int32 = v309 v303
                let v311 : (int32 -> int32) = int32
                let v312 : int32 = v311 v308
                let v313 : string = v298.[int v310..int v312]
                US18_0(v313, v299, v300, v301)
        match v315 with
        | US18_1(v316) -> (* Error *)
            let v317 : UH1 = UH1_0
            let v318 : UH1 = UH1_1(v297, v317)
            let v319 : UH1 = method57(v0, v318)
            US14_0(v319, v298, v299, v300, v301)
        | US18_0(v321, v322, v323, v324) -> (* Ok *)
            let v325 : UH1 = UH1_1(v297, v0)
            method50(v325, v321, v322, v323, v324)
and method49 (v0 : string) : US13 =
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
    let v11 : US14 = method50(v8, v5, v7, v9, v10)
    match v11 with
    | US14_1(v22) -> (* Error *)
        US13_1(v22)
    | US14_0(v12, v13, v14, v15, v16) -> (* Ok *)
        let v17 : string list = []
        let v18 : string list = method58(v12, v17)
        let v19 : (string list -> (string [])) = List.toArray
        let v20 : (string []) = v19 v18
        US13_0(v20)
and closure29 () () : string =
    let v0 : string = $"runtime.execute_with_options"
    v0
and closure30 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : string, v8 : Vec<std_string_String>) () : string =
    let v9 : string = $"file_name: {v7} / arguments: %A{v8}"
    let v10 : (unit -> string) = closure6()
    let v11 : string = $" / options: %A{struct (v0, v1, v2, v3, v4, v5, v6)} / {v10 ()}"
    let v12 : string = v9 + v11 
    v12
and closure31 () (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : US19 =
    US19_0(v0)
and method61 () : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US19) =
    closure31()
and closure32 () (v0 : std_string_String) : US19 =
    US19_1(v0)
and method62 () : (std_string_String -> US19) =
    closure32()
and closure33 () () : string =
    let v0 : string = $"runtime.execute_with_options / child error"
    v0
and closure34 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and method63 (v0 : std_sync_Arc<std_sync_Mutex<std_process_Child option>>) : std_sync_Arc<std_sync_Mutex<std_process_Child option>> =
    v0
and closure35 () (v0 : std_string_String) : US21 =
    US21_0(v0)
and method64 () : (std_string_String -> US21) =
    closure35()
and closure36 () (v0 : std_string_String) : US21 =
    US21_1(v0)
and method65 () : (std_string_String -> US21) =
    closure36()
and closure37 () () : string =
    let v0 : string = $"runtime.stdio_line"
    v0
and closure38 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"e: {v0} / {v1 ()}"
    v2
and closure39 (v0 : string) () : string =
    v0
and method66 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>>) : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> =
    v0
and closure40 () (v0 : std_sync_mpsc_SendError<std_string_String>) : std_string_String =
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
and method67 () : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) =
    closure40()
and method68 (v0 : Result<unit, string>) : Result<unit, string> =
    v0
and method69 (v0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>>) : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> =
    v0
and method70 (v0 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> =
    v0
and method71 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and method72 (v0 : std_thread_JoinHandle<Result<unit, string>>) : std_thread_JoinHandle<Result<unit, string>> =
    v0
and closure41 () (v0 : std_process_Output) : US24 =
    US24_0(v0)
and closure42 () (v0 : std_string_String) : US24 =
    US24_1(v0)
and closure43 () () : string =
    let v0 : string = $"runtime.execute_with_options / output error"
    v0
and closure44 (v0 : std_string_String) () : string =
    let v1 : (unit -> string) = closure6()
    let v2 : string = $"error: {v0} / {v1 ()}"
    v2
and method73 (v0 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>) : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> =
    v0
and closure45 () () : string =
    let v0 : string = $"runtime.execute_with_options / result"
    v0
and closure46 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"exit_code: {v0}"
    let v3 : (unit -> string) = closure6()
    let v4 : string = $" / std_trace.Length: {v1.Length} / {v3 ()}"
    let v5 : string = v2 + v4 
    v5
and closure47 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) () : string =
    let v7 : string = $"runtime.execute_with_options_async / options: %A{struct (v0, v1, v2, v3, v4, v5, v6)}"
    v7
and method75 () : (unit -> string) =
    closure6()
and closure49 (v0 : string) () : string =
    v0
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
        let v21 : US26 option = None
        let _v21 = ref v21 
        match v3 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v22 : (struct (bool * string * int32) -> Async<unit>) = x
        let v23 : US26 = US26_0(v22)
        v23 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v21.Value <- x
        let v24 : US26 option = _v21.Value 
        let v25 : US26 = US26_1
        let v26 : US26 = v24 |> Option.defaultValue v25 
        match v26 with
        | US26_1 -> (* None *)
            ()
        | US26_0(v27) -> (* Some *)
            let v28 : int32 = v7.Id
            let v29 : Async<unit> = v27 struct (false, v17, v28)
            do! v29 
            ()
        let v30 : string = $"> {v17}"
        if v5 then
            let v31 : US0 = US0_0
            let v32 : (unit -> string) = closure49(v30)
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
and closure50 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>) (v9 : System.Diagnostics.DataReceivedEventArgs) : unit =
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
        let v21 : US26 option = None
        let _v21 = ref v21 
        match v3 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v22 : (struct (bool * string * int32) -> Async<unit>) = x
        let v23 : US26 = US26_0(v22)
        v23 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v21.Value <- x
        let v24 : US26 option = _v21.Value 
        let v25 : US26 = US26_1
        let v26 : US26 = v24 |> Option.defaultValue v25 
        match v26 with
        | US26_1 -> (* None *)
            ()
        | US26_0(v27) -> (* Some *)
            let v28 : int32 = v7.Id
            let v29 : Async<unit> = v27 struct (true, v17, v28)
            do! v29 
            ()
        let v30 : string = $"! {v17}"
        if v5 then
            let v31 : US0 = US0_0
            let v32 : (unit -> string) = closure49(v30)
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
and closure51 (v0 : System.Diagnostics.Process) () : unit =
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
and closure52 (v0 : System.Threading.Tasks.TaskCanceledException) () : string =
    let v1 : string = $"runtime.execute_with_options_async / WaitForExitAsync / ex: %A{v0}"
    v1
and closure53 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"runtime.execute_with_options_async / exit_code: {v0} / output.Length: {v1.Length}"
    v2
and method74 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
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
    let struct (v20 : string, v21 : string) = method45(v1)
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
    let v33 : (unit -> string) = closure47(v0, v1, v2, v3, v4, v5, v6)
    let v34 : (unit -> string) = method75()
    method5(v32, v33, v34)
    let v35 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v36 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v21, StandardOutputEncoding = v35, WorkingDirectory = v31, FileName = v20, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v37 : int32 = v2.Length
    let v38 : Mut5 = {l0 = 0} : Mut5
    while method31(v37, v38) do
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
    let v48 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure48(v0, v1, v2, v3, v4, v5, v6, v45, v47)
    v45.OutputDataReceived.Add v48 
    let v49 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure50(v0, v1, v2, v3, v4, v5, v6, v45, v47)
    v45.ErrorDataReceived.Add v49 
    let v50 : (unit -> bool) = v45.Start
    let v51 : bool = v50 ()
    let v52 : bool = v51 = false
    if v52 then
        let v53 : string = $"runtime.execute_with_options_async / process_start error"
        failwith<unit> v53
    let v54 : (unit -> unit) = v45.BeginErrorReadLine
    v54 ()
    let v55 : (unit -> unit) = v45.BeginOutputReadLine
    v55 ()
    let v56 : US27 option = None
    let _v56 = ref v56 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v57 : System.Threading.CancellationToken = x
    let v58 : US27 = US27_0(v57)
    v58 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v56.Value <- x
    let v59 : US27 option = _v56.Value 
    let v60 : US27 = US27_1
    let v61 : US27 = v59 |> Option.defaultValue v60 
    let v65 : System.Threading.CancellationToken =
        match v61 with
        | US27_1 -> (* None *)
            let v63 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v63
        | US27_0(v62) -> (* Some *)
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
    let v91 : (unit -> unit) = closure51(v45)
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
    let v124 : (unit -> string) = closure52(v122)
    let v125 : (unit -> string) = method75()
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
    let v136 : (unit -> string) = closure53(v128, v134)
    let v137 : (unit -> string) = method75()
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
and method43 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (string * string) []), v3 : (struct (bool * string * int32) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : struct (int32 * string) =
    let v7 : bool = true
    let mutable _v7 : struct (int32 * string) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = method44(v0, v1, v2, v3, v4, v5, v6)
    let struct (v9 : string, v10 : string) = method45(v8)
    let v11 : US13 = method49(v10)
    let v17 : (string []) =
        match v11 with
        | US13_1(v13) -> (* Error *)
            let v14 : string = $"resultm.get / Result value was Error: {v13}"
            failwith<(string [])> v14
        | US13_0(v12) -> (* Ok *)
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
    let v33 : (unit -> string) = closure29()
    let v34 : (unit -> string) = closure30(v0, v1, v2, v3, v4, v5, v6, v9, v31)
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
    let v85 : (std_io_Error -> std_string_String) = method37()
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
    let v101 : (std_sync_Arc<std_sync_Mutex<std_process_Child option>> -> US19) = method61()
    let v102 : (std_string_String -> US19) = method62()
    let v103 : string = "match v100 { Ok(x) => $0(x), Err(e) => $1(e) }"
    let v104 : US19 = Fable.Core.RustInterop.emitRustExpr struct (v101, v102) v103 
    let struct (v500 : int32, v501 : US4, v502 : US20) =
        match v104 with
        | US19_1(v491) -> (* Error *)
            let v492 : US0 = US0_4
            let v493 : (unit -> string) = closure33()
            let v494 : (unit -> string) = closure34(v491)
            method5(v492, v493, v494)
            let v495 : US4 = US4_0(v491)
            let v496 : US20 = US20_1
            struct (-1, v495, v496)
        | US19_0(v105) -> (* Ok *)
            let v106 : string = "true; let _result = (|| { //"
            let v107 : bool = Fable.Core.RustInterop.emitRustExpr () v106 
            let v108 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method63(v105)
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
            let v133 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method63(v105)
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
            let v158 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method63(v105)
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
            let v215 : (std_io_Error -> std_string_String) = method37()
            let v216 : string = "$0.map_err(|x| $1(x))"
            let v217 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v212, v215) v216 
            let v218 : (std_string_String -> US21) = method64()
            let v219 : (std_string_String -> US21) = method65()
            let v220 : string = "match v217 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v221 : US21 = Fable.Core.RustInterop.emitRustExpr struct (v218, v219) v220 
            let v254 : std_string_String =
                match v221 with
                | US21_1(v244) -> (* Error *)
                    let v245 : US0 = US0_4
                    let v246 : (unit -> string) = closure37()
                    let v247 : (unit -> string) = closure38(v244)
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
                    let v231 : string = "std::str::from_utf8($0)"
                    let v232 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr v230 v231 
                    let v233 : string = "$0.unwrap()"
                    let v234 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v232 v233 
                    let v235 : string = "String::from($0)"
                    let v236 : std_string_String = Fable.Core.RustInterop.emitRustExpr v234 v235 
                    let v237 : string = "fable_library_rust::String_::fromString($0)"
                    let v238 : string = Fable.Core.RustInterop.emitRustExpr v236 v237 
                    let v239 : string = $"> {v238}"
                    if v5 then
                        let v240 : US0 = US0_0
                        let v241 : (unit -> string) = closure39(v239)
                        let v242 : (unit -> string) = closure6()
                        method5(v240, v241, v242)
                    else
                        let v243 : (string -> unit) = System.Console.WriteLine
                        v243 v239
                    v236
            let v255 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = method66(v214)
            let v256 : string = "v255.lock()"
            let v257 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v256 
            let v258 : string = "$0.unwrap()"
            let v259 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v257 v258 
            let v260 : string = "&$0"
            let v261 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v259 v260 
            let v262 : string = "$0.send($1)"
            let v263 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v261, v254) v262 
            let v264 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method67()
            let v265 : string = "$0.map_err(|x| $1(x))"
            let v266 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v263, v264) v265 
            let v267 : string = "$0"
            let v268 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v266 v267 
            let v269 : string = "true; $0 }); //"
            let v270 : bool = Fable.Core.RustInterop.emitRustExpr v268 v269 
            let v271 : string = "_result.map_err(|x| x.into())"
            let v272 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v271 
            let v273 : Result<unit, string> = method68(v272)
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
            let v294 : (std_io_Error -> std_string_String) = method37()
            let v295 : string = "$0.map_err(|x| $1(x))"
            let v296 : Result<std_string_String, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v291, v294) v295 
            let v297 : (std_string_String -> US21) = method64()
            let v298 : (std_string_String -> US21) = method65()
            let v299 : string = "match v296 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v300 : US21 = Fable.Core.RustInterop.emitRustExpr struct (v297, v298) v299 
            let v338 : std_string_String =
                match v300 with
                | US21_1(v328) -> (* Error *)
                    let v329 : US0 = US0_4
                    let v330 : (unit -> string) = closure37()
                    let v331 : (unit -> string) = closure38(v328)
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
                    let v310 : string = "std::str::from_utf8($0)"
                    let v311 : Result<Ref<Str>, std_str_Utf8Error> = Fable.Core.RustInterop.emitRustExpr v309 v310 
                    let v312 : string = "$0.unwrap()"
                    let v313 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v311 v312 
                    let v314 : string = "String::from($0)"
                    let v315 : std_string_String = Fable.Core.RustInterop.emitRustExpr v313 v314 
                    let v316 : string = "fable_library_rust::String_::fromString($0)"
                    let v317 : string = Fable.Core.RustInterop.emitRustExpr v315 v316 
                    let v318 : string = $"! {v317}"
                    if v5 then
                        let v319 : US0 = US0_0
                        let v320 : (unit -> string) = closure39(v318)
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
            let v339 : std_sync_Arc<std_sync_Mutex<std_sync_mpsc_Sender<std_string_String>>> = method66(v293)
            let v340 : string = "v339.lock()"
            let v341 : Result<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v340 
            let v342 : string = "$0.unwrap()"
            let v343 : std_sync_MutexGuard<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v341 v342 
            let v344 : string = "&$0"
            let v345 : Ref<std_sync_mpsc_Sender<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v343 v344 
            let v346 : string = "$0.send($1)"
            let v347 : Result<unit, std_sync_mpsc_SendError<std_string_String>> = Fable.Core.RustInterop.emitRustExpr struct (v345, v338) v346 
            let v348 : (std_sync_mpsc_SendError<std_string_String> -> std_string_String) = method67()
            let v349 : string = "$0.map_err(|x| $1(x))"
            let v350 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v347, v348) v349 
            let v351 : string = "$0"
            let v352 : core_ops_Try<unit> = Fable.Core.RustInterop.emitRustExpr v350 v351 
            let v353 : string = "true; $0 }); //"
            let v354 : bool = Fable.Core.RustInterop.emitRustExpr v352 v353 
            let v355 : string = "_result.map_err(|x| x.into())"
            let v356 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr () v355 
            let v357 : Result<unit, string> = method68(v356)
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
                let v369 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin option>> = method69(v185)
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
                    let v399 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = method70(v398)
                    let v400 : string = "v399.lock()"
                    let v401 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr () v400 
                    let v402 : string = "$0.unwrap()"
                    let v403 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v401 v402 
                    let v404 : std_sync_MutexGuard<std_process_ChildStdin> = method71(v403)
                    let v405 : string = "true; let mut v404 = v404"
                    let v406 : bool = Fable.Core.RustInterop.emitRustExpr () v405 
                    let v407 : string = "true; std::io::Write::flush(&mut *$0).unwrap()"
                    let v408 : bool = Fable.Core.RustInterop.emitRustExpr v404 v407 
                    ()
            let v409 : std_sync_Arc<std_sync_Mutex<std_process_Child option>> = method63(v105)
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
            let v424 : (std_io_Error -> std_string_String) = method37()
            let v425 : string = "$0.map_err(|x| $1(x))"
            let v426 : Result<std_process_Output, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v423, v424) v425 
            let v427 : std_thread_JoinHandle<Result<unit, string>> = method72(v361)
            let v428 : string = "v427"
            let v429 : string = v428 + v274 
            let v430 : string = v429 + v274 
            let v431 : std_thread_JoinHandle<Result<unit, string>> = method72(v279)
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
            let v449 : (std_process_Output -> US24) = closure41()
            let v450 : (std_string_String -> US24) = closure42()
            let v451 : US24 = match v426 with Ok x -> v449 x | Error x -> v450 x
            match v451 with
            | US24_1(v479) -> (* Error *)
                let v480 : US0 = US0_4
                let v481 : (unit -> string) = closure43()
                let v482 : (unit -> string) = closure44(v479)
                method5(v480, v481, v482)
                let v483 : US4 = US4_0(v479)
                let v484 : US20 = US20_1
                struct (-2, v483, v484)
            | US24_0(v452) -> (* Ok *)
                let v453 : string = "$0.status"
                let v454 : std_process_ExitStatus = Fable.Core.RustInterop.emitRustExpr v452 v453 
                let v455 : string = "$0.code()"
                let v456 : int32 option = Fable.Core.RustInterop.emitRustExpr v454 v455 
                let v457 : US25 option = None
                let _v457 = ref v457 
                match v456 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v458 : int32 = x
                let v459 : US25 = US25_0(v458)
                v459 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v457.Value <- x
                let v460 : US25 option = _v457.Value 
                let v461 : US25 = US25_1
                let v462 : US25 = v460 |> Option.defaultValue v461 
                match v462 with
                | US25_1 -> (* None *)
                    let v466 : string = "&*$0"
                    let v467 : string = "runtime.execute_with_options / exit_code=None"
                    let v468 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v467 v466 
                    let v469 : string = "String::from($0)"
                    let v470 : std_string_String = Fable.Core.RustInterop.emitRustExpr v468 v469 
                    let v471 : US4 = US4_0(v470)
                    let v472 : US20 = US20_0(v200)
                    struct (-1, v471, v472)
                | US25_0(v463) -> (* Some *)
                    let v464 : US4 = US4_1
                    let v465 : US20 = US20_0(v200)
                    struct (v463, v464, v465)
    let v507 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option =
        match v502 with
        | US20_1 -> (* None *)
            let v505 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = None
            v505
        | US20_0(v503) -> (* Some *)
            let v504 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> option = Some v503 
            v504
    let v508 : string = "true; let _result = v507.map(|x| { //"
    let v509 : bool = Fable.Core.RustInterop.emitRustExpr () v508 
    let v510 : string = "x"
    let v511 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = Fable.Core.RustInterop.emitRustExpr () v510 
    let v512 : std_sync_Arc<std_sync_Mutex<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>> = method73(v511)
    let v513 : string = "v512.lock()"
    let v514 : Result<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>, std_sync_PoisonError<std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v513 
    let v515 : string = "$0.unwrap()"
    let v516 : std_sync_MutexGuard<std_sync_Arc<std_sync_mpsc_Receiver<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v514 v515 
    let v517 : string = "v516.iter()"
    let v518 : _ = Fable.Core.RustInterop.emitRustExpr () v517 
    let v519 : string = "v518.collect::<Vec<_>>()"
    let v520 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v519 
    let v521 : string = "true; let _result : Vec<_> = v520.into_iter().map(|x| { //"
    let v522 : bool = Fable.Core.RustInterop.emitRustExpr () v521 
    let v523 : string = "x"
    let v524 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v523 
    let v525 : string = "fable_library_rust::String_::fromString($0)"
    let v526 : string = Fable.Core.RustInterop.emitRustExpr v524 v525 
    let v527 : string = "true; $0 }).collect::<Vec<_>>()"
    let v528 : bool = Fable.Core.RustInterop.emitRustExpr v526 v527 
    let v529 : string = "_result"
    let v530 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v529 
    let v531 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v532 : (string []) = Fable.Core.RustInterop.emitRustExpr v530 v531 
    let v533 : ((string []) -> string seq) = Seq.ofArray
    let v534 : string seq = v533 v532
    let v535 : (string -> (string seq -> string)) = String.concat
    let v536 : string = "\n"
    let v537 : (string seq -> string) = v535 v536
    let v538 : string = v537 v534
    let v539 : string = "true; $0 })"
    let v540 : bool = Fable.Core.RustInterop.emitRustExpr v538 v539 
    let v541 : string = "_result"
    let v542 : string option = Fable.Core.RustInterop.emitRustExpr () v541 
    let v549 : US3 =
        match v501 with
        | US4_1 -> (* None *)
            US3_1
        | US4_0(v543) -> (* Some *)
            let v544 : string = "fable_library_rust::String_::fromString($0)"
            let v545 : string = Fable.Core.RustInterop.emitRustExpr v543 v544 
            US3_0(v545)
    let v553 : string =
        match v549 with
        | US3_1 -> (* None *)
            let v551 : string = ""
            v551
        | US3_0(v550) -> (* Some *)
            v550
    let v554 : string = v542 |> Option.defaultValue v553 
    let v555 : US0 = US0_0
    let v556 : (unit -> string) = closure45()
    let v557 : (unit -> string) = closure46(v500, v554)
    method5(v555, v556, v557)
    let v558 : (int32 * string) = v500, v554 
    v558 
    )
    |> fun x -> x ()
    ) () )
    |> fun x -> _v35 <- Some x
    let v559 : (int32 * string) = match _v35 with Some x -> x | None -> failwith "base.capture / _v35=None"
    let (a, b) = v559 
    let v560 : int32 = a
    let v561 : string = b
    struct (v560, v561) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v562 : int32, v563 : string) = null |> unbox<struct (int32 * string)>
    struct (v562, v563) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v564 : int32, v565 : string) = null |> unbox<struct (int32 * string)>
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
#else
    let v570 : Async<struct (int32 * string)> = method74(v0, v1, v2, v3, v4, v5, v6)
    let v571 : bool = true
    let mutable _v571 : struct (int32 * string) option = None 
    
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
    let struct (v583 : int32, v584 : string) = v582 v570
    struct (v583, v584) 
    #endif
    |> fun x -> _v571 <- Some x
    let struct (v585 : int32, v586 : string) = match _v571 with Some x -> x | None -> failwith "base.run_target / _v571=None"
    struct (v585, v586) 
    #endif
    |> fun x -> _v7 <- Some x
    let struct (v587 : int32, v588 : string) = match _v7 with Some x -> x | None -> failwith "base.run_target / _v7=None"
    struct (v587, v588)
and method77 (v0 : string) : string =
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
    let v23 : US6 = US6_2(v22)
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
    let v28 : US6 = US6_3(v27)
    let v29 : string = $"file_system.get_file_name / target: {v28} / path: {v0}"
    let v30 : string = failwith<string> v29
    v30 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : US5 = US5_0
    let v32 : US6 = US6_4(v31)
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
and method76 (v0 : string, v1 : string, v2 : string) : struct (string * string) =
    let v3 : string = method77(v1)
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
and closure54 () (v0 : string) : US29 =
    US29_0(v0)
and method78 () : (string -> US29) =
    closure54()
and closure55 () (v0 : std_string_String) : US29 =
    US29_1(v0)
and method79 () : (std_string_String -> US29) =
    closure55()
and method80 (v0 : string) : bool =
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
and closure56 () () : string =
    let v0 : string = "documents.run / par_map / origin_hash |> sm'.contains local_git_hash |> not / hash2 = None || hash1 <>. (hash2 |> optionm.value)"
    v0
and closure57 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : int32, v5 : string, v6 : string, v7 : int32, v8 : string, v9 : string, v10 : US3) () : string =
    let v11 : (unit -> string) = closure6()
    let v12 : string = $"file: {v1} / real_path: {v2} / relative_path: {v0} / origin_hash_exit_code: {v4} / origin_hash: {v3} / local_git_hash_exit_code: {v7} / local_git_hash: {v6} / hash1: {v9} / hash2: %A{v10} / dist_path: {v5} / cache_path: {v8} / {v11 ()}"
    v12
and method82 (v0 : string) : string =
    v0
and method81 (v0 : string, v1 : string) : unit =
    let v2 : bool = true
    let mutable _v2 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method82(v0)
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
and method84 (v0 : Vec<uint8>) : Vec<uint8> =
    v0
and method85 (v0 : int32, v1 : Mut6) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method86 (v0 : string) : string =
    v0
and method87 (v0 : std_sync_MutexGuard<std_process_ChildStdin>) : std_sync_MutexGuard<std_process_ChildStdin> =
    v0
and closure60 (v0 : string) (v1 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>>) : unit =
    let v2 : std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> = method70(v1)
    let v3 : string = "v2.lock()"
    let v4 : Result<std_sync_MutexGuard<std_process_ChildStdin>, std_sync_PoisonError<std_sync_MutexGuard<std_process_ChildStdin>>> = Fable.Core.RustInterop.emitRustExpr () v3 
    let v5 : string = "$0.unwrap()"
    let v6 : std_sync_MutexGuard<std_process_ChildStdin> = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = method86(v0)
    let v8 : string = "v7.as_bytes()"
    let v9 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : std_sync_MutexGuard<std_process_ChildStdin> = method87(v6)
    let v11 : string = "true; let mut v10 = v10"
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr () v11 
    let v13 : string = "true; std::io::Write::write_all(&mut *$0, v9).unwrap()"
    let v14 : bool = Fable.Core.RustInterop.emitRustExpr v10 v13 
    ()
and method88 (v0 : int32, v1 : Mut7) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method89 (v0 : string) : string =
    v0
and closure61 () () : string =
    let v0 : string = "documents.hangul"
    v0
and closure62 (v0 : string, v1 : int32, v2 : string) () : string =
    let v3 : int32 = v2.Length
    let v4 : (unit -> string) = closure6()
    let v5 : string = $"exit_code: %A{v1} / result_len: {v3} / output_path: {v0} / {v4 ()}"
    v5
and method83 (v0 : string, v1 : string, v2 : string, v3 : string) : US30 =
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
    let v16 : Vec<uint8> = method84(v15)
    let v17 : string = "std::string::String::from_utf8($0)"
    let v18 : Result<std_string_String, std_string_FromUtf8Error> = Fable.Core.RustInterop.emitRustExpr v16 v17 
    let v19 : string = "$0.unwrap()"
    let v20 : std_string_String = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "fable_library_rust::String_::fromString($0)"
    let v22 : string = Fable.Core.RustInterop.emitRustExpr v20 v21 
    v22 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v23 : string = null |> unbox<string>
    v23 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : string = null |> unbox<string>
    v24 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v25 : string = null |> unbox<string>
    v25 
    #endif
#if FABLE_COMPILER_PYTHON
    let v26 : string = null |> unbox<string>
    v26 
    #endif
#else
    let v27 : string = v3 |> System.IO.File.ReadAllText
    v27 
    #endif
    |> fun x -> _v4 <- Some x
    let v28 : string = match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
    let v29 : string = "\n"
    let v30 : (string []) = v28.Split v29 
    let v31 : int32 = v30.Length
    let v32 : (string []) = Array.zeroCreate<string> (v31)
    let v33 : Mut5 = {l0 = 0} : Mut5
    while method31(v31, v33) do
        let v35 : int32 = v33.l0
        let v36 : string = v30.[int v35]
        let v37 : (unit -> string) = v36.Trim
        let v38 : string = v37 ()
        v32.[int v35] <- v38
        let v39 : int32 = v35 + 1
        v33.l0 <- v39
        ()
    let v40 : int32 = v32.Length
    let v41 : (string []) = Array.zeroCreate<string> (v40)
    let v42 : Mut6 = {l0 = 0; l1 = 0} : Mut6
    while method85(v40, v42) do
        let v44 : int32 = v42.l0
        let v45 : int32 = v42.l1
        let v46 : string = v32.[int v44]
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
    while method31(v52, v54) do
        let v56 : int32 = v54.l0
        let v57 : string = v41.[int v56]
        v53.[int v56] <- v57
        let v58 : int32 = v56 + 1
        v54.l0 <- v58
        ()
    let v59 : string seq = seq { for i = 0 to v53.Length - 1 do yield v53.[i] }
    let v60 : (string -> (string seq -> string)) = String.concat
    let v61 : (string seq -> string) = v60 v29
    let v62 : string = v61 v59
    let v63 : string = $"{v62}

"
    let v64 : System.Threading.CancellationToken option = None
    let v65 : (struct (string * string) []) = [||]
    let v66 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v67 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v68 : string option = None
    let v69 : bool = true
    let mutable _v69 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v70 : string = "cfg!(windows)"
    let v71 : bool = Fable.Core.RustInterop.emitRustExpr () v70 
    v71 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v72 : string = "cfg!(windows)"
    let v73 : bool = Fable.Core.RustInterop.emitRustExpr () v72 
    v73 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : string = "cfg!(windows)"
    let v75 : bool = Fable.Core.RustInterop.emitRustExpr () v74 
    v75 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v76 : US5 = US5_0
    let v77 : US6 = US6_3(v76)
    let v78 : string = $"platform.is_windows / target: {v77}"
    let v79 : bool = failwith<bool> v78
    v79 
    #endif
#if FABLE_COMPILER_PYTHON
    let v80 : US5 = US5_0
    let v81 : US6 = US6_4(v80)
    let v82 : string = $"platform.is_windows / target: {v81}"
    let v83 : bool = failwith<bool> v82
    v83 
    #endif
#else
    let v84 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v85 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v86 : bool = v85 v84
    v86 
    #endif
    |> fun x -> _v69 <- Some x
    let v87 : bool = match _v69 with Some x -> x | None -> failwith "base.run_target / _v69=None"
    let v90 : string =
        if v87 then
            let v88 : string = ".exe"
            v88
        else
            let v89 : string = ""
            v89
    let v91 : string = $"../vault/deps/hangulize/cmd/hangulize/hangulize{v90}"
    let v92 : string = method15(v0, v91)
    let v93 : string = $"{v92} {v1}"
    let v94 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) = closure60(v63)
    let v95 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = Some v94 
    let v96 : bool = true
    let struct (v97 : int32, v98 : string) = method43(v64, v93, v65, v66, v95, v96, v68)
    let v99 : (string []) = v98.Split v29 
    let v100 : int32 = v99.Length
    let v101 : string = ""
    let v102 : Mut7 = {l0 = 0; l1 = v101; l2 = 0; l3 = 0} : Mut7
    while method88(v40, v102) do
        let v104 : int32 = v102.l0
        let struct (v105 : string, v106 : int32, v107 : int32) = v102.l1, v102.l2, v102.l3
        let v108 : string = v32.[int v104]
        let v109 : bool = v108 = ""
        let struct (v123 : string, v124 : int32, v125 : int32) =
            if v109 then
                let v110 : string = $"{v105}
"
                let v111 : int32 = v106 + 1
                let v112 : int32 = v107 + 1
                struct (v110, v111, v112)
            else
                let v113 : int32 = v106 - v107
                let v114 : bool = v113 >= v100
                let v121 : string =
                    if v114 then
                        v105
                    else
                        let v115 : string = v99.[int v113]
                        let v116 : int32 = v100 - 1
                        let v117 : bool = v113 = v116
                        if v117 then
                            let v118 : string = $"{v105}{v115}"
                            v118
                        else
                            let v119 : string = $"{v105}{v115}
"
                            v119
                let v122 : int32 = v106 + 1
                struct (v121, v122, v107)
        let v126 : int32 = v104 + 1
        v102.l0 <- v126
        v102.l1 <- v123
        v102.l2 <- v124
        v102.l3 <- v125
        ()
    let struct (v127 : string, v128 : int32, v129 : int32) = v102.l1, v102.l2, v102.l3
    let v130 : bool = true
    let mutable _v130 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v131 : string = "std::fs::write(&*$0, &*$1).unwrap()"
    Fable.Core.RustInterop.emitRustExpr struct (v2, v127) v131 
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
    let v132 : string = method89(v127)
    System.IO.File.WriteAllText (v2, v132)
    () 
    #endif
    |> fun x -> _v130 <- Some x
    match _v130 with Some x -> x | None -> failwith "base.run_target / _v130=None"
    let v133 : US0 = US0_2
    let v134 : (unit -> string) = closure61()
    let v135 : (unit -> string) = closure62(v2, v97, v127)
    method5(v133, v134, v135)
    US30_0(v97, v127)
and closure63 () () : string =
    let v0 : string = "documents.files_fn / error"
    v0
and closure64 (v0 : string, v1 : int32) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"exit_code: %A{v1} / result: {v0} / {v2 ()}"
    v3
and closure59 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : US28 =
    let struct (v6 : string, v7 : string) = method76(v5, v4, v0)
    let v8 : bool = method80(v7)
    let v10 : bool =
        if v8 then
            method80(v6)
        else
            false
    let v189 : bool =
        if v10 then
            let v11 : string = method26(v7)
            let v12 : string = "std::fs::File::open(&*v11)"
            let v13 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v12 
            let v14 : string = "$0.unwrap()"
            let v15 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v13 v14 
            let v16 : string = "std::io::BufReader::new(v15)"
            let v17 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v16 
            let v18 : string = "std::io::BufReader::new(v17)"
            let v19 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr () v18 
            let v20 : string = "true; let mut v19 = v19"
            let v21 : bool = Fable.Core.RustInterop.emitRustExpr () v20 
            let v22 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v22 
            let v23 : string = "result"
            let v24 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v23 
            let v25 : string = "true; let mut v24 = v24"
            let v26 : bool = Fable.Core.RustInterop.emitRustExpr () v25 
            let v27 : unativeint = 0 |> unativeint 
            let v28 : string = "[$0; 1024]"
            let v29 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v28 
            let v30 : string = "true; loop { // rust.loop"
            let v31 : bool = Fable.Core.RustInterop.emitRustExpr () v30 
            let v32 : string = "true; let mut v29 = v29"
            let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32 
            let v34 : string = "std::io::Read::read(&mut v19, &mut v29)"
            let v35 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v34 
            let v36 : string = "$0.unwrap()"
            let v37 : unativeint = Fable.Core.RustInterop.emitRustExpr v35 v36 
            let v38 : bool = v37 = v27 
            if v38 then
                let v39 : string = "true; break"
                let v40 : bool = Fable.Core.RustInterop.emitRustExpr () v39 
                ()
            let v41 : string = "v29.len()"
            let v42 : unativeint = Fable.Core.RustInterop.emitRustExpr () v41 
            let v43 : uint8 = v42 |> uint8 
            let v44 : unativeint = v37 |> unativeint 
            let v45 : unativeint = v44 |> unbox<unativeint>
            let v46 : bool = v45 = v42 
            let v51 : Ref<Slice'<uint8>> =
                if v46 then
                    let v47 : string = "&v29[v27..]"
                    let v48 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v47 
                    v48
                else
                    let v49 : string = "&v29[$0..$1]"
                    let v50 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v27, v44) v49 
                    v50
            let v52 : string = "sha2::Digest::update(&mut v24, v51)"
            Fable.Core.RustInterop.emitRustExpr () v52 
            let v53 : string = "true; } // rust.loop"
            let v54 : bool = Fable.Core.RustInterop.emitRustExpr () v53 
            let v55 : string = "true; } // rust.loop"
            let v56 : bool = Fable.Core.RustInterop.emitRustExpr () v55 
            let v57 : string = "true; } // rust.loop"
            let v58 : bool = Fable.Core.RustInterop.emitRustExpr () v57 
            let v59 : string = "true; { // rust.loop"
            let v60 : bool = Fable.Core.RustInterop.emitRustExpr () v59 
            let v61 : string = "true; { // rust.loop"
            let v62 : bool = Fable.Core.RustInterop.emitRustExpr () v61 
            let v63 : string = "&sha2::Digest::finalize(v24)"
            let v64 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v63 
            let v65 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v66 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v64 v65 
            let v67 : string = "true; let _result : Vec<_> = v66.into_iter().map(|x| { //"
            let v68 : bool = Fable.Core.RustInterop.emitRustExpr () v67 
            let v69 : string = "x"
            let v70 : uint8 = Fable.Core.RustInterop.emitRustExpr () v69 
            let v71 : string = "format!(\"{:02x}\", $0)"
            let v72 : std_string_String = Fable.Core.RustInterop.emitRustExpr v70 v71 
            let v73 : string = "fable_library_rust::String_::fromString($0)"
            let v74 : string = Fable.Core.RustInterop.emitRustExpr v72 v73 
            let v75 : string = "true; $0 }).collect::<Vec<_>>()"
            let v76 : bool = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "_result"
            let v78 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v77 
            let v79 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v80 : (string []) = Fable.Core.RustInterop.emitRustExpr v78 v79 
            let v81 : string seq = seq { for i = 0 to v80.Length - 1 do yield v80.[i] }
            let v82 : (string -> (string seq -> string)) = String.concat
            let v83 : string = ""
            let v84 : (string seq -> string) = v82 v83
            let v85 : string = v84 v81
            let v86 : Result<string, std_io_Error> = Ok v85 
            let v87 : (std_io_Error -> std_string_String) = method37()
            let v88 : string = "$0.map_err(|x| $1(x))"
            let v89 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v86, v87) v88 
            let v90 : (string -> US29) = method78()
            let v91 : (std_string_String -> US29) = method79()
            let v92 : string = "match v89 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v93 : US29 = Fable.Core.RustInterop.emitRustExpr struct (v90, v91) v92 
            let v99 : string =
                match v93 with
                | US29_1(v95) -> (* Error *)
                    let v96 : string = $"resultm.get / Result value was Error: {v95}"
                    failwith<string> v96
                | US29_0(v94) -> (* Ok *)
                    v94
            let v100 : string = method26(v6)
            let v101 : string = "std::fs::File::open(&*v100)"
            let v102 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v101 
            let v103 : string = "$0.unwrap()"
            let v104 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v102 v103 
            let v105 : string = "std::io::BufReader::new(v104)"
            let v106 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v105 
            let v107 : string = "std::io::BufReader::new(v106)"
            let v108 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr () v107 
            let v109 : string = "true; let mut v108 = v108"
            let v110 : bool = Fable.Core.RustInterop.emitRustExpr () v109 
            let v111 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v111 
            let v112 : string = "result"
            let v113 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v112 
            let v114 : string = "true; let mut v113 = v113"
            let v115 : bool = Fable.Core.RustInterop.emitRustExpr () v114 
            let v116 : unativeint = 0 |> unativeint 
            let v117 : string = "[$0; 1024]"
            let v118 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v117 
            let v119 : string = "true; loop { // rust.loop"
            let v120 : bool = Fable.Core.RustInterop.emitRustExpr () v119 
            let v121 : string = "true; let mut v118 = v118"
            let v122 : bool = Fable.Core.RustInterop.emitRustExpr () v121 
            let v123 : string = "std::io::Read::read(&mut v108, &mut v118)"
            let v124 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v123 
            let v125 : string = "$0.unwrap()"
            let v126 : unativeint = Fable.Core.RustInterop.emitRustExpr v124 v125 
            let v127 : bool = v126 = v116 
            if v127 then
                let v128 : string = "true; break"
                let v129 : bool = Fable.Core.RustInterop.emitRustExpr () v128 
                ()
            let v130 : string = "v118.len()"
            let v131 : unativeint = Fable.Core.RustInterop.emitRustExpr () v130 
            let v132 : uint8 = v131 |> uint8 
            let v133 : unativeint = v126 |> unativeint 
            let v134 : unativeint = v133 |> unbox<unativeint>
            let v135 : bool = v134 = v131 
            let v140 : Ref<Slice'<uint8>> =
                if v135 then
                    let v136 : string = "&v118[v116..]"
                    let v137 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v136 
                    v137
                else
                    let v138 : string = "&v118[$0..$1]"
                    let v139 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v116, v133) v138 
                    v139
            let v141 : string = "sha2::Digest::update(&mut v113, v140)"
            Fable.Core.RustInterop.emitRustExpr () v141 
            let v142 : string = "true; } // rust.loop"
            let v143 : bool = Fable.Core.RustInterop.emitRustExpr () v142 
            let v144 : string = "true; } // rust.loop"
            let v145 : bool = Fable.Core.RustInterop.emitRustExpr () v144 
            let v146 : string = "true; } // rust.loop"
            let v147 : bool = Fable.Core.RustInterop.emitRustExpr () v146 
            let v148 : string = "true; { // rust.loop"
            let v149 : bool = Fable.Core.RustInterop.emitRustExpr () v148 
            let v150 : string = "true; { // rust.loop"
            let v151 : bool = Fable.Core.RustInterop.emitRustExpr () v150 
            let v152 : string = "&sha2::Digest::finalize(v113)"
            let v153 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v152 
            let v154 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v155 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v153 v154 
            let v156 : string = "true; let _result : Vec<_> = v155.into_iter().map(|x| { //"
            let v157 : bool = Fable.Core.RustInterop.emitRustExpr () v156 
            let v158 : string = "x"
            let v159 : uint8 = Fable.Core.RustInterop.emitRustExpr () v158 
            let v160 : string = "format!(\"{:02x}\", $0)"
            let v161 : std_string_String = Fable.Core.RustInterop.emitRustExpr v159 v160 
            let v162 : string = "fable_library_rust::String_::fromString($0)"
            let v163 : string = Fable.Core.RustInterop.emitRustExpr v161 v162 
            let v164 : string = "true; $0 }).collect::<Vec<_>>()"
            let v165 : bool = Fable.Core.RustInterop.emitRustExpr v163 v164 
            let v166 : string = "_result"
            let v167 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v166 
            let v168 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v169 : (string []) = Fable.Core.RustInterop.emitRustExpr v167 v168 
            let v170 : string seq = seq { for i = 0 to v169.Length - 1 do yield v169.[i] }
            let v171 : (string -> (string seq -> string)) = String.concat
            let v172 : (string seq -> string) = v171 v83
            let v173 : string = v172 v170
            let v174 : Result<string, std_io_Error> = Ok v173 
            let v175 : (std_io_Error -> std_string_String) = method37()
            let v176 : string = "$0.map_err(|x| $1(x))"
            let v177 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v174, v175) v176 
            let v178 : (string -> US29) = method78()
            let v179 : (std_string_String -> US29) = method79()
            let v180 : string = "match v177 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v181 : US29 = Fable.Core.RustInterop.emitRustExpr struct (v178, v179) v180 
            let v187 : string =
                match v181 with
                | US29_1(v183) -> (* Error *)
                    let v184 : string = $"resultm.get / Result value was Error: {v183}"
                    failwith<string> v184
                | US29_0(v182) -> (* Ok *)
                    v182
            let v188 : bool = v99 = v187
            v188
        else
            false
    let v190 : bool = v189 = false
    if v190 then
        let v191 : US30 = method83(v2, v3, v7, v4)
        match v191 with
        | US30_1(v206, v207) -> (* Error *)
            let v208 : (string * string) = v7, v207 
            let v209 : Result<string, (string * string)> = Error v208 
            US28_0(v209)
        | US30_0(v192, v193) -> (* Ok *)
            let v194 : bool = v192 <> 0 
            if v194 then
                let v195 : US0 = US0_2
                let v196 : (unit -> string) = closure63()
                let v197 : (unit -> string) = closure64(v193, v192)
                method5(v195, v196, v197)
                let v198 : (string * string) = v7, v193 
                let v199 : Result<string, (string * string)> = Error v198 
                US28_0(v199)
            else
                let v201 : bool = method80(v7)
                if v201 then
                    method81(v6, v7)
                else
                    let v202 : string = $"documents.files_fn / {v7} should exist"
                    failwith<unit> v202
                let v203 : Result<string, (string * string)> = Ok v7 
                US28_0(v203)
    else
        US28_1
and closure58 (v0 : string, v1 : string, v2 : string, v3 : string) (v4 : string) : (string -> US28) =
    closure59(v0, v1, v2, v3, v4)
and closure67 () () : string =
    let v0 : string = "documents.crowbook / result contains ERROR"
    v0
and closure68 (v0 : string, v1 : string, v2 : int32) () : string =
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"exit_code: %A{v2} / output_path: {v0} / result: {v1} / {v3 ()}"
    v4
and method90 (v0 : bool, v1 : string, v2 : string, v3 : string, v4 : string) : US30 =
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
    let struct (v58 : int32, v59 : string) = method43(v48, v55, v49, v50, v51, v57, v56)
    let v60 : string = "ERROR"
    let v61 : bool = v59.Contains v60 
    if v61 then
        let v62 : US0 = US0_3
        let v63 : (unit -> string) = closure67()
        let v64 : (unit -> string) = closure68(v1, v59, v58)
        method5(v62, v63, v64)
        US30_1(v58, v59)
    else
        US30_0(v58, v59)
and closure66 (v0 : string, v1 : string, v2 : bool, v3 : string) (v4 : string) : US28 =
    let struct (v5 : string, v6 : string) = method76(v4, v3, v0)
    let v7 : bool = method80(v6)
    let v9 : bool =
        if v7 then
            method80(v5)
        else
            false
    let v188 : bool =
        if v9 then
            let v10 : string = method26(v6)
            let v11 : string = "std::fs::File::open(&*v10)"
            let v12 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v11 
            let v13 : string = "$0.unwrap()"
            let v14 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v12 v13 
            let v15 : string = "std::io::BufReader::new(v14)"
            let v16 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v15 
            let v17 : string = "std::io::BufReader::new(v16)"
            let v18 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr () v17 
            let v19 : string = "true; let mut v18 = v18"
            let v20 : bool = Fable.Core.RustInterop.emitRustExpr () v19 
            let v21 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v21 
            let v22 : string = "result"
            let v23 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v22 
            let v24 : string = "true; let mut v23 = v23"
            let v25 : bool = Fable.Core.RustInterop.emitRustExpr () v24 
            let v26 : unativeint = 0 |> unativeint 
            let v27 : string = "[$0; 1024]"
            let v28 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v27 
            let v29 : string = "true; loop { // rust.loop"
            let v30 : bool = Fable.Core.RustInterop.emitRustExpr () v29 
            let v31 : string = "true; let mut v28 = v28"
            let v32 : bool = Fable.Core.RustInterop.emitRustExpr () v31 
            let v33 : string = "std::io::Read::read(&mut v18, &mut v28)"
            let v34 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v33 
            let v35 : string = "$0.unwrap()"
            let v36 : unativeint = Fable.Core.RustInterop.emitRustExpr v34 v35 
            let v37 : bool = v36 = v26 
            if v37 then
                let v38 : string = "true; break"
                let v39 : bool = Fable.Core.RustInterop.emitRustExpr () v38 
                ()
            let v40 : string = "v28.len()"
            let v41 : unativeint = Fable.Core.RustInterop.emitRustExpr () v40 
            let v42 : uint8 = v41 |> uint8 
            let v43 : unativeint = v36 |> unativeint 
            let v44 : unativeint = v43 |> unbox<unativeint>
            let v45 : bool = v44 = v41 
            let v50 : Ref<Slice'<uint8>> =
                if v45 then
                    let v46 : string = "&v28[v26..]"
                    let v47 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v46 
                    v47
                else
                    let v48 : string = "&v28[$0..$1]"
                    let v49 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v26, v43) v48 
                    v49
            let v51 : string = "sha2::Digest::update(&mut v23, v50)"
            Fable.Core.RustInterop.emitRustExpr () v51 
            let v52 : string = "true; } // rust.loop"
            let v53 : bool = Fable.Core.RustInterop.emitRustExpr () v52 
            let v54 : string = "true; } // rust.loop"
            let v55 : bool = Fable.Core.RustInterop.emitRustExpr () v54 
            let v56 : string = "true; } // rust.loop"
            let v57 : bool = Fable.Core.RustInterop.emitRustExpr () v56 
            let v58 : string = "true; { // rust.loop"
            let v59 : bool = Fable.Core.RustInterop.emitRustExpr () v58 
            let v60 : string = "true; { // rust.loop"
            let v61 : bool = Fable.Core.RustInterop.emitRustExpr () v60 
            let v62 : string = "&sha2::Digest::finalize(v23)"
            let v63 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v62 
            let v64 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v65 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v63 v64 
            let v66 : string = "true; let _result : Vec<_> = v65.into_iter().map(|x| { //"
            let v67 : bool = Fable.Core.RustInterop.emitRustExpr () v66 
            let v68 : string = "x"
            let v69 : uint8 = Fable.Core.RustInterop.emitRustExpr () v68 
            let v70 : string = "format!(\"{:02x}\", $0)"
            let v71 : std_string_String = Fable.Core.RustInterop.emitRustExpr v69 v70 
            let v72 : string = "fable_library_rust::String_::fromString($0)"
            let v73 : string = Fable.Core.RustInterop.emitRustExpr v71 v72 
            let v74 : string = "true; $0 }).collect::<Vec<_>>()"
            let v75 : bool = Fable.Core.RustInterop.emitRustExpr v73 v74 
            let v76 : string = "_result"
            let v77 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v76 
            let v78 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v79 : (string []) = Fable.Core.RustInterop.emitRustExpr v77 v78 
            let v80 : string seq = seq { for i = 0 to v79.Length - 1 do yield v79.[i] }
            let v81 : (string -> (string seq -> string)) = String.concat
            let v82 : string = ""
            let v83 : (string seq -> string) = v81 v82
            let v84 : string = v83 v80
            let v85 : Result<string, std_io_Error> = Ok v84 
            let v86 : (std_io_Error -> std_string_String) = method37()
            let v87 : string = "$0.map_err(|x| $1(x))"
            let v88 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v85, v86) v87 
            let v89 : (string -> US29) = method78()
            let v90 : (std_string_String -> US29) = method79()
            let v91 : string = "match v88 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v92 : US29 = Fable.Core.RustInterop.emitRustExpr struct (v89, v90) v91 
            let v98 : string =
                match v92 with
                | US29_1(v94) -> (* Error *)
                    let v95 : string = $"resultm.get / Result value was Error: {v94}"
                    failwith<string> v95
                | US29_0(v93) -> (* Ok *)
                    v93
            let v99 : string = method26(v5)
            let v100 : string = "std::fs::File::open(&*v99)"
            let v101 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v100 
            let v102 : string = "$0.unwrap()"
            let v103 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v101 v102 
            let v104 : string = "std::io::BufReader::new(v103)"
            let v105 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v104 
            let v106 : string = "std::io::BufReader::new(v105)"
            let v107 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr () v106 
            let v108 : string = "true; let mut v107 = v107"
            let v109 : bool = Fable.Core.RustInterop.emitRustExpr () v108 
            let v110 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v110 
            let v111 : string = "result"
            let v112 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v111 
            let v113 : string = "true; let mut v112 = v112"
            let v114 : bool = Fable.Core.RustInterop.emitRustExpr () v113 
            let v115 : unativeint = 0 |> unativeint 
            let v116 : string = "[$0; 1024]"
            let v117 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v116 
            let v118 : string = "true; loop { // rust.loop"
            let v119 : bool = Fable.Core.RustInterop.emitRustExpr () v118 
            let v120 : string = "true; let mut v117 = v117"
            let v121 : bool = Fable.Core.RustInterop.emitRustExpr () v120 
            let v122 : string = "std::io::Read::read(&mut v107, &mut v117)"
            let v123 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v122 
            let v124 : string = "$0.unwrap()"
            let v125 : unativeint = Fable.Core.RustInterop.emitRustExpr v123 v124 
            let v126 : bool = v125 = v115 
            if v126 then
                let v127 : string = "true; break"
                let v128 : bool = Fable.Core.RustInterop.emitRustExpr () v127 
                ()
            let v129 : string = "v117.len()"
            let v130 : unativeint = Fable.Core.RustInterop.emitRustExpr () v129 
            let v131 : uint8 = v130 |> uint8 
            let v132 : unativeint = v125 |> unativeint 
            let v133 : unativeint = v132 |> unbox<unativeint>
            let v134 : bool = v133 = v130 
            let v139 : Ref<Slice'<uint8>> =
                if v134 then
                    let v135 : string = "&v117[v115..]"
                    let v136 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v135 
                    v136
                else
                    let v137 : string = "&v117[$0..$1]"
                    let v138 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v115, v132) v137 
                    v138
            let v140 : string = "sha2::Digest::update(&mut v112, v139)"
            Fable.Core.RustInterop.emitRustExpr () v140 
            let v141 : string = "true; } // rust.loop"
            let v142 : bool = Fable.Core.RustInterop.emitRustExpr () v141 
            let v143 : string = "true; } // rust.loop"
            let v144 : bool = Fable.Core.RustInterop.emitRustExpr () v143 
            let v145 : string = "true; } // rust.loop"
            let v146 : bool = Fable.Core.RustInterop.emitRustExpr () v145 
            let v147 : string = "true; { // rust.loop"
            let v148 : bool = Fable.Core.RustInterop.emitRustExpr () v147 
            let v149 : string = "true; { // rust.loop"
            let v150 : bool = Fable.Core.RustInterop.emitRustExpr () v149 
            let v151 : string = "&sha2::Digest::finalize(v112)"
            let v152 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v151 
            let v153 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v154 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v152 v153 
            let v155 : string = "true; let _result : Vec<_> = v154.into_iter().map(|x| { //"
            let v156 : bool = Fable.Core.RustInterop.emitRustExpr () v155 
            let v157 : string = "x"
            let v158 : uint8 = Fable.Core.RustInterop.emitRustExpr () v157 
            let v159 : string = "format!(\"{:02x}\", $0)"
            let v160 : std_string_String = Fable.Core.RustInterop.emitRustExpr v158 v159 
            let v161 : string = "fable_library_rust::String_::fromString($0)"
            let v162 : string = Fable.Core.RustInterop.emitRustExpr v160 v161 
            let v163 : string = "true; $0 }).collect::<Vec<_>>()"
            let v164 : bool = Fable.Core.RustInterop.emitRustExpr v162 v163 
            let v165 : string = "_result"
            let v166 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v165 
            let v167 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v168 : (string []) = Fable.Core.RustInterop.emitRustExpr v166 v167 
            let v169 : string seq = seq { for i = 0 to v168.Length - 1 do yield v168.[i] }
            let v170 : (string -> (string seq -> string)) = String.concat
            let v171 : (string seq -> string) = v170 v82
            let v172 : string = v171 v169
            let v173 : Result<string, std_io_Error> = Ok v172 
            let v174 : (std_io_Error -> std_string_String) = method37()
            let v175 : string = "$0.map_err(|x| $1(x))"
            let v176 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v173, v174) v175 
            let v177 : (string -> US29) = method78()
            let v178 : (std_string_String -> US29) = method79()
            let v179 : string = "match v176 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v180 : US29 = Fable.Core.RustInterop.emitRustExpr struct (v177, v178) v179 
            let v186 : string =
                match v180 with
                | US29_1(v182) -> (* Error *)
                    let v183 : string = $"resultm.get / Result value was Error: {v182}"
                    failwith<string> v183
                | US29_0(v181) -> (* Ok *)
                    v181
            let v187 : bool = v98 = v186
            v187
        else
            false
    let v189 : bool = v188 = false
    if v189 then
        let v190 : US30 = method90(v2, v6, v3, v1, v4)
        match v190 with
        | US30_1(v205, v206) -> (* Error *)
            let v207 : (string * string) = v6, v206 
            let v208 : Result<string, (string * string)> = Error v207 
            US28_0(v208)
        | US30_0(v191, v192) -> (* Ok *)
            let v193 : bool = v191 <> 0 
            if v193 then
                let v194 : US0 = US0_2
                let v195 : (unit -> string) = closure63()
                let v196 : (unit -> string) = closure64(v192, v191)
                method5(v194, v195, v196)
                let v197 : (string * string) = v6, v192 
                let v198 : Result<string, (string * string)> = Error v197 
                US28_0(v198)
            else
                let v200 : bool = method80(v6)
                if v200 then
                    method81(v5, v6)
                else
                    let v201 : string = $"documents.files_fn / {v6} should exist"
                    failwith<unit> v201
                let v202 : Result<string, (string * string)> = Ok v6 
                US28_0(v202)
    else
        US28_1
and closure65 (v0 : string, v1 : string, v2 : bool) (v3 : string) : (string -> US28) =
    closure66(v0, v1, v2, v3)
and closure69 () () : string =
    let v0 : string = "documents.run / par_map / files' = [] / listm.iter"
    v0
and closure70 (v0 : string, v1 : string) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"output_path: %A{v1} / output_cache_path: {v0} / {v2 ()}"
    v3
and method91 (v0 : UH3, v1 : UH4 list) : UH4 list =
    match v0 with
    | UH3_1(v2, v3) -> (* Cons *)
        let v4 : UH4 list = method91(v3, v1)
        let v5 : UH4 list = v2 :: v4 
        v5
    | UH3_0 -> (* Nil *)
        v1
and method92 (v0 : int32, v1 : Mut8) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method93 (v0 : UH4, v1 : struct (string * string * (string -> (string -> US28))) list) : struct (string * string * (string -> (string -> US28))) list =
    match v0 with
    | UH4_1(v2, v3, v4, v5) -> (* Cons *)
        let v6 : struct (string * string * (string -> (string -> US28))) list = method93(v5, v1)
        let v7 : struct (string * string * (string -> (string -> US28))) list = struct (v2, v3, v4) :: v6 
        v7
    | UH4_0 -> (* Nil *)
        v1
and closure71 () struct (v0 : string, v1 : string, v2 : (string -> (string -> US28))) : Result<string, (string * string)> option =
    let v3 : (string -> US28) = v2 v1
    let v4 : US28 = v3 v0
    match v4 with
    | US28_1 -> (* None *)
        let v7 : Result<string, (string * string)> option = None
        v7
    | US28_0(v5) -> (* Some *)
        let v6 : Result<string, (string * string)> option = Some v5 
        v6
and method94 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and method95 (v0 : Vec<Result<string, (string * string)> option>) : Vec<Result<string, (string * string)> option> =
    v0
and closure24 (v0 : string, v1 : string, v2 : string, v3 : string, v4 : string) (v5 : string) : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> =
    let v6 : string = method24(v5)
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
    let v34 : string = method26(v6)
    let v35 : string = method15(v2, v33)
    let v36 : string = method42(v35)
    let v37 : System.Threading.CancellationToken option = None
    let v38 : (struct (string * string) []) = [||]
    let v39 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v40 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v41 : string option = None
    let v42 : string = $"git ls-tree --format='%%(objectname)' origin/gh-pages \"{v36}\""
    let v43 : string option = Some v2 
    let v44 : bool = true
    let struct (v45 : int32, v46 : string) = method43(v37, v42, v38, v39, v40, v44, v43)
    let v47 : string = method15(v3, v33)
    let v48 : string = method42(v47)
    let v49 : System.Threading.CancellationToken option = None
    let v50 : (struct (string * string) []) = [||]
    let v51 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v52 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v53 : string option = None
    let v54 : string = $"git hash-object \"{v48}\""
    let v55 : string option = Some v3 
    let v56 : bool = true
    let struct (v57 : int32, v58 : string) = method43(v49, v54, v50, v51, v52, v56, v55)
    let v59 : string = method15(v4, v33)
    let v60 : string = method42(v59)
    let v61 : string = "hangul.md"
    let struct (v62 : string, v63 : string) = method76(v61, v48, v4)
    let v64 : bool = false
    let v65 : bool = false
    let v66 : bool = false
    let v67 : bool = true
    let v68 : bool = true
    let v69 : bool = true
    let v70 : bool = v46.Contains v58 
    let v71 : bool = v70 = false
    let v288 : UH3 =
        if v71 then
            let v72 : string = method26(v48)
            let v73 : string = "std::fs::File::open(&*v72)"
            let v74 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v73 
            let v75 : string = "$0.unwrap()"
            let v76 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v74 v75 
            let v77 : string = "std::io::BufReader::new(v76)"
            let v78 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v77 
            let v79 : string = "std::io::BufReader::new(v78)"
            let v80 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr () v79 
            let v81 : string = "true; let mut v80 = v80"
            let v82 : bool = Fable.Core.RustInterop.emitRustExpr () v81 
            let v83 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
            Fable.Core.RustInterop.emitRustExpr () v83 
            let v84 : string = "result"
            let v85 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v84 
            let v86 : string = "true; let mut v85 = v85"
            let v87 : bool = Fable.Core.RustInterop.emitRustExpr () v86 
            let v88 : unativeint = 0 |> unativeint 
            let v89 : string = "[$0; 1024]"
            let v90 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v89 
            let v91 : string = "true; loop { // rust.loop"
            let v92 : bool = Fable.Core.RustInterop.emitRustExpr () v91 
            let v93 : string = "true; let mut v90 = v90"
            let v94 : bool = Fable.Core.RustInterop.emitRustExpr () v93 
            let v95 : string = "std::io::Read::read(&mut v80, &mut v90)"
            let v96 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v95 
            let v97 : string = "$0.unwrap()"
            let v98 : unativeint = Fable.Core.RustInterop.emitRustExpr v96 v97 
            let v99 : bool = v98 = v88 
            if v99 then
                let v100 : string = "true; break"
                let v101 : bool = Fable.Core.RustInterop.emitRustExpr () v100 
                ()
            let v102 : string = "v90.len()"
            let v103 : unativeint = Fable.Core.RustInterop.emitRustExpr () v102 
            let v104 : uint8 = v103 |> uint8 
            let v105 : unativeint = v98 |> unativeint 
            let v106 : unativeint = v105 |> unbox<unativeint>
            let v107 : bool = v106 = v103 
            let v112 : Ref<Slice'<uint8>> =
                if v107 then
                    let v108 : string = "&v90[v88..]"
                    let v109 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v108 
                    v109
                else
                    let v110 : string = "&v90[$0..$1]"
                    let v111 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v88, v105) v110 
                    v111
            let v113 : string = "sha2::Digest::update(&mut v85, v112)"
            Fable.Core.RustInterop.emitRustExpr () v113 
            let v114 : string = "true; } // rust.loop"
            let v115 : bool = Fable.Core.RustInterop.emitRustExpr () v114 
            let v116 : string = "true; } // rust.loop"
            let v117 : bool = Fable.Core.RustInterop.emitRustExpr () v116 
            let v118 : string = "true; } // rust.loop"
            let v119 : bool = Fable.Core.RustInterop.emitRustExpr () v118 
            let v120 : string = "true; { // rust.loop"
            let v121 : bool = Fable.Core.RustInterop.emitRustExpr () v120 
            let v122 : string = "true; { // rust.loop"
            let v123 : bool = Fable.Core.RustInterop.emitRustExpr () v122 
            let v124 : string = "&sha2::Digest::finalize(v85)"
            let v125 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v124 
            let v126 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
            let v127 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v125 v126 
            let v128 : string = "true; let _result : Vec<_> = v127.into_iter().map(|x| { //"
            let v129 : bool = Fable.Core.RustInterop.emitRustExpr () v128 
            let v130 : string = "x"
            let v131 : uint8 = Fable.Core.RustInterop.emitRustExpr () v130 
            let v132 : string = "format!(\"{:02x}\", $0)"
            let v133 : std_string_String = Fable.Core.RustInterop.emitRustExpr v131 v132 
            let v134 : string = "fable_library_rust::String_::fromString($0)"
            let v135 : string = Fable.Core.RustInterop.emitRustExpr v133 v134 
            let v136 : string = "true; $0 }).collect::<Vec<_>>()"
            let v137 : bool = Fable.Core.RustInterop.emitRustExpr v135 v136 
            let v138 : string = "_result"
            let v139 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v138 
            let v140 : string = "fable_library_rust::NativeArray_::array_from($0)"
            let v141 : (string []) = Fable.Core.RustInterop.emitRustExpr v139 v140 
            let v142 : string seq = seq { for i = 0 to v141.Length - 1 do yield v141.[i] }
            let v143 : (string -> (string seq -> string)) = String.concat
            let v144 : (string seq -> string) = v143 v28
            let v145 : string = v144 v142
            let v146 : Result<string, std_io_Error> = Ok v145 
            let v147 : (std_io_Error -> std_string_String) = method37()
            let v148 : string = "$0.map_err(|x| $1(x))"
            let v149 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v146, v147) v148 
            let v150 : (string -> US29) = method78()
            let v151 : (std_string_String -> US29) = method79()
            let v152 : string = "match v149 { Ok(x) => $0(x), Err(e) => $1(e) }"
            let v153 : US29 = Fable.Core.RustInterop.emitRustExpr struct (v150, v151) v152 
            let v159 : string =
                match v153 with
                | US29_1(v155) -> (* Error *)
                    let v156 : string = $"resultm.get / Result value was Error: {v155}"
                    failwith<string> v156
                | US29_0(v154) -> (* Ok *)
                    v154
            let v160 : bool = method80(v60)
            let v161 : bool = v160 = false
            let v251 : US3 =
                if v161 then
                    US3_1
                else
                    let v163 : string = method26(v60)
                    let v164 : string = "std::fs::File::open(&*v163)"
                    let v165 : Result<std_fs_File, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v164 
                    let v166 : string = "$0.unwrap()"
                    let v167 : std_fs_File = Fable.Core.RustInterop.emitRustExpr v165 v166 
                    let v168 : string = "std::io::BufReader::new(v167)"
                    let v169 : std_io_BufReader<std_fs_File> = Fable.Core.RustInterop.emitRustExpr () v168 
                    let v170 : string = "std::io::BufReader::new(v169)"
                    let v171 : std_io_BufReader<std_io_BufReader<std_fs_File>> = Fable.Core.RustInterop.emitRustExpr () v170 
                    let v172 : string = "true; let mut v171 = v171"
                    let v173 : bool = Fable.Core.RustInterop.emitRustExpr () v172 
                    let v174 : string = "let result : sha2::Sha256 = sha2::Digest::new()"
                    Fable.Core.RustInterop.emitRustExpr () v174 
                    let v175 : string = "result"
                    let v176 : sha2_Sha256 = Fable.Core.RustInterop.emitRustExpr () v175 
                    let v177 : string = "true; let mut v176 = v176"
                    let v178 : bool = Fable.Core.RustInterop.emitRustExpr () v177 
                    let v179 : unativeint = 0 |> unativeint 
                    let v180 : string = "[$0; 1024]"
                    let v181 : Slice'<uint8> = Fable.Core.RustInterop.emitRustExpr 0uy v180 
                    let v182 : string = "true; loop { // rust.loop"
                    let v183 : bool = Fable.Core.RustInterop.emitRustExpr () v182 
                    let v184 : string = "true; let mut v181 = v181"
                    let v185 : bool = Fable.Core.RustInterop.emitRustExpr () v184 
                    let v186 : string = "std::io::Read::read(&mut v171, &mut v181)"
                    let v187 : Result<unativeint, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v186 
                    let v188 : string = "$0.unwrap()"
                    let v189 : unativeint = Fable.Core.RustInterop.emitRustExpr v187 v188 
                    let v190 : bool = v189 = v179 
                    if v190 then
                        let v191 : string = "true; break"
                        let v192 : bool = Fable.Core.RustInterop.emitRustExpr () v191 
                        ()
                    let v193 : string = "v181.len()"
                    let v194 : unativeint = Fable.Core.RustInterop.emitRustExpr () v193 
                    let v195 : uint8 = v194 |> uint8 
                    let v196 : unativeint = v189 |> unativeint 
                    let v197 : unativeint = v196 |> unbox<unativeint>
                    let v198 : bool = v197 = v194 
                    let v203 : Ref<Slice'<uint8>> =
                        if v198 then
                            let v199 : string = "&v181[v179..]"
                            let v200 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr () v199 
                            v200
                        else
                            let v201 : string = "&v181[$0..$1]"
                            let v202 : Ref<Slice'<uint8>> = Fable.Core.RustInterop.emitRustExpr struct (v179, v196) v201 
                            v202
                    let v204 : string = "sha2::Digest::update(&mut v176, v203)"
                    Fable.Core.RustInterop.emitRustExpr () v204 
                    let v205 : string = "true; } // rust.loop"
                    let v206 : bool = Fable.Core.RustInterop.emitRustExpr () v205 
                    let v207 : string = "true; } // rust.loop"
                    let v208 : bool = Fable.Core.RustInterop.emitRustExpr () v207 
                    let v209 : string = "true; } // rust.loop"
                    let v210 : bool = Fable.Core.RustInterop.emitRustExpr () v209 
                    let v211 : string = "true; { // rust.loop"
                    let v212 : bool = Fable.Core.RustInterop.emitRustExpr () v211 
                    let v213 : string = "true; { // rust.loop"
                    let v214 : bool = Fable.Core.RustInterop.emitRustExpr () v213 
                    let v215 : string = "&sha2::Digest::finalize(v176)"
                    let v216 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v215 
                    let v217 : string = "$0.iter().map(|x| *x).collect::<Vec<_>>()"
                    let v218 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v216 v217 
                    let v219 : string = "true; let _result : Vec<_> = v218.into_iter().map(|x| { //"
                    let v220 : bool = Fable.Core.RustInterop.emitRustExpr () v219 
                    let v221 : string = "x"
                    let v222 : uint8 = Fable.Core.RustInterop.emitRustExpr () v221 
                    let v223 : string = "format!(\"{:02x}\", $0)"
                    let v224 : std_string_String = Fable.Core.RustInterop.emitRustExpr v222 v223 
                    let v225 : string = "fable_library_rust::String_::fromString($0)"
                    let v226 : string = Fable.Core.RustInterop.emitRustExpr v224 v225 
                    let v227 : string = "true; $0 }).collect::<Vec<_>>()"
                    let v228 : bool = Fable.Core.RustInterop.emitRustExpr v226 v227 
                    let v229 : string = "_result"
                    let v230 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v229 
                    let v231 : string = "fable_library_rust::NativeArray_::array_from($0)"
                    let v232 : (string []) = Fable.Core.RustInterop.emitRustExpr v230 v231 
                    let v233 : string seq = seq { for i = 0 to v232.Length - 1 do yield v232.[i] }
                    let v234 : (string -> (string seq -> string)) = String.concat
                    let v235 : (string seq -> string) = v234 v28
                    let v236 : string = v235 v233
                    let v237 : Result<string, std_io_Error> = Ok v236 
                    let v238 : (std_io_Error -> std_string_String) = method37()
                    let v239 : string = "$0.map_err(|x| $1(x))"
                    let v240 : Result<string, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v237, v238) v239 
                    let v241 : (string -> US29) = method78()
                    let v242 : (std_string_String -> US29) = method79()
                    let v243 : string = "match v240 { Ok(x) => $0(x), Err(e) => $1(e) }"
                    let v244 : US29 = Fable.Core.RustInterop.emitRustExpr struct (v241, v242) v243 
                    match v244 with
                    | US29_1(v247) -> (* Error *)
                        US3_1
                    | US29_0(v245) -> (* Ok *)
                        US3_0(v245)
            let v253 : bool =
                match v251 with
                | US3_1 -> (* None *)
                    true
                | _ ->
                    false
            let v259 : bool =
                if v253 then
                    true
                else
                    let v257 : string =
                        match v251 with
                        | US3_1 -> (* None *)
                            failwith<string> "Option does not have a value."
                        | US3_0(v254) -> (* Some *)
                            v254
                    let v258 : bool = v159 <> v257 
                    v258
            if v259 then
                let v260 : US0 = US0_2
                let v261 : (unit -> string) = closure56()
                let v262 : (unit -> string) = closure57(v33, v34, v36, v46, v45, v48, v58, v57, v60, v159, v251)
                method5(v260, v261, v262)
                method81(v60, v48)
                let v263 : (string -> (string -> US28)) = closure58(v4, v3, v1, v0)
                let v264 : UH4 = UH4_0
                let v265 : UH4 = UH4_1(v61, v48, v263, v264)
                let v266 : string = "html"
                let v267 : (string -> (string -> US28)) = closure65(v4, v3, v64)
                let v268 : string = "pdf"
                let v269 : (string -> (string -> US28)) = closure65(v4, v3, v65)
                let v270 : string = "epub"
                let v271 : (string -> (string -> US28)) = closure65(v4, v3, v66)
                let v272 : (string -> (string -> US28)) = closure65(v4, v3, v67)
                let v273 : (string -> (string -> US28)) = closure65(v4, v3, v68)
                let v274 : (string -> (string -> US28)) = closure65(v4, v3, v69)
                let v275 : UH4 = UH4_0
                let v276 : UH4 = UH4_1(v270, v63, v274, v275)
                let v277 : UH4 = UH4_1(v268, v63, v273, v276)
                let v278 : UH4 = UH4_1(v266, v63, v272, v277)
                let v279 : UH4 = UH4_1(v270, v48, v271, v278)
                let v280 : UH4 = UH4_1(v268, v48, v269, v279)
                let v281 : UH4 = UH4_1(v266, v48, v267, v280)
                let v282 : UH3 = UH3_0
                let v283 : UH3 = UH3_1(v281, v282)
                UH3_1(v265, v283)
            else
                UH3_0
        else
            UH3_0
    let v290 : bool =
        match v288 with
        | UH3_0 -> (* Nil *)
            true
        | _ ->
            false
    let v291 : bool = v290 <> true
    let v393 : UH3 =
        if v291 then
            v288
        else
            let v292 : string = "epub"
            let struct (v293 : string, v294 : string) = method76(v292, v63, v4)
            let v295 : bool = method80(v294)
            let v296 : bool = v295 = false
            let v302 : bool =
                if v296 then
                    let v297 : bool = method80(v293)
                    if v297 then
                        let v298 : US0 = US0_2
                        let v299 : (unit -> string) = closure69()
                        let v300 : (unit -> string) = closure70(v293, v294)
                        method5(v298, v299, v300)
                        method81(v294, v293)
                        false
                    else
                        true
                else
                    true
            let v307 : UH4 =
                if v302 then
                    let v303 : (string -> (string -> US28)) = closure65(v4, v3, v69)
                    let v304 : UH4 = UH4_0
                    UH4_1(v292, v63, v303, v304)
                else
                    UH4_0
            let v308 : string = "pdf"
            let struct (v309 : string, v310 : string) = method76(v308, v63, v4)
            let v311 : bool = method80(v310)
            let v312 : bool = v311 = false
            let v318 : bool =
                if v312 then
                    let v313 : bool = method80(v309)
                    if v313 then
                        let v314 : US0 = US0_2
                        let v315 : (unit -> string) = closure69()
                        let v316 : (unit -> string) = closure70(v309, v310)
                        method5(v314, v315, v316)
                        method81(v310, v309)
                        false
                    else
                        true
                else
                    true
            let v321 : UH4 =
                if v318 then
                    let v319 : (string -> (string -> US28)) = closure65(v4, v3, v68)
                    UH4_1(v308, v63, v319, v307)
                else
                    v307
            let v322 : string = "html"
            let struct (v323 : string, v324 : string) = method76(v322, v63, v4)
            let v325 : bool = method80(v324)
            let v326 : bool = v325 = false
            let v332 : bool =
                if v326 then
                    let v327 : bool = method80(v323)
                    if v327 then
                        let v328 : US0 = US0_2
                        let v329 : (unit -> string) = closure69()
                        let v330 : (unit -> string) = closure70(v323, v324)
                        method5(v328, v329, v330)
                        method81(v324, v323)
                        false
                    else
                        true
                else
                    true
            let v335 : UH4 =
                if v332 then
                    let v333 : (string -> (string -> US28)) = closure65(v4, v3, v67)
                    UH4_1(v322, v63, v333, v321)
                else
                    v321
            let struct (v336 : string, v337 : string) = method76(v292, v48, v4)
            let v338 : bool = method80(v337)
            let v339 : bool = v338 = false
            let v345 : bool =
                if v339 then
                    let v340 : bool = method80(v336)
                    if v340 then
                        let v341 : US0 = US0_2
                        let v342 : (unit -> string) = closure69()
                        let v343 : (unit -> string) = closure70(v336, v337)
                        method5(v341, v342, v343)
                        method81(v337, v336)
                        false
                    else
                        true
                else
                    true
            let v348 : UH4 =
                if v345 then
                    let v346 : (string -> (string -> US28)) = closure65(v4, v3, v66)
                    UH4_1(v292, v48, v346, v335)
                else
                    v335
            let struct (v349 : string, v350 : string) = method76(v308, v48, v4)
            let v351 : bool = method80(v350)
            let v352 : bool = v351 = false
            let v358 : bool =
                if v352 then
                    let v353 : bool = method80(v349)
                    if v353 then
                        let v354 : US0 = US0_2
                        let v355 : (unit -> string) = closure69()
                        let v356 : (unit -> string) = closure70(v349, v350)
                        method5(v354, v355, v356)
                        method81(v350, v349)
                        false
                    else
                        true
                else
                    true
            let v361 : UH4 =
                if v358 then
                    let v359 : (string -> (string -> US28)) = closure65(v4, v3, v65)
                    UH4_1(v308, v48, v359, v348)
                else
                    v348
            let struct (v362 : string, v363 : string) = method76(v322, v48, v4)
            let v364 : bool = method80(v363)
            let v365 : bool = v364 = false
            let v371 : bool =
                if v365 then
                    let v366 : bool = method80(v362)
                    if v366 then
                        let v367 : US0 = US0_2
                        let v368 : (unit -> string) = closure69()
                        let v369 : (unit -> string) = closure70(v362, v363)
                        method5(v367, v368, v369)
                        method81(v363, v362)
                        false
                    else
                        true
                else
                    true
            let v374 : UH4 =
                if v371 then
                    let v372 : (string -> (string -> US28)) = closure65(v4, v3, v64)
                    UH4_1(v322, v48, v372, v361)
                else
                    v361
            let struct (v375 : string, v376 : string) = method76(v61, v48, v4)
            let v377 : bool = method80(v376)
            let v378 : bool = v377 = false
            let v384 : bool =
                if v378 then
                    let v379 : bool = method80(v375)
                    if v379 then
                        let v380 : US0 = US0_2
                        let v381 : (unit -> string) = closure69()
                        let v382 : (unit -> string) = closure70(v375, v376)
                        method5(v380, v381, v382)
                        method81(v376, v375)
                        false
                    else
                        true
                else
                    true
            let v389 : UH4 =
                if v384 then
                    let v385 : (string -> (string -> US28)) = closure58(v4, v3, v1, v0)
                    let v386 : UH4 = UH4_0
                    UH4_1(v61, v48, v385, v386)
                else
                    UH4_0
            let v390 : UH3 = UH3_0
            let v391 : UH3 = UH3_1(v374, v390)
            UH3_1(v389, v391)
    let v394 : UH4 list = []
    let v395 : UH4 list = method91(v393, v394)
    let v396 : (UH4 list -> (UH4 [])) = List.toArray
    let v397 : (UH4 []) = v396 v395
    let v398 : string = "$0.to_vec()"
    let v399 : Vec<UH4> = Fable.Core.RustInterop.emitRustExpr v397 v398 
    let v400 : (Result<string, (string * string)> option []) = [||]
    let v401 : string = "$0.to_vec()"
    let v402 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v400 v401 
    let v403 : string = "fable_library_rust::NativeArray_::array_from($0)"
    let v404 : (UH4 []) = Fable.Core.RustInterop.emitRustExpr v399 v403 
    let v405 : int32 = v404.Length
    let v406 : Mut8 = {l0 = 0; l1 = v402} : Mut8
    while method92(v405, v406) do
        let v408 : int32 = v406.l0
        let v409 : Vec<Result<string, (string * string)> option> = v406.l1
        let v410 : UH4 = v404.[int v408]
        let v411 : struct (string * string * (string -> (string -> US28))) list = []
        let v412 : struct (string * string * (string -> (string -> US28))) list = method93(v410, v411)
        let v413 : (struct (string * string * (string -> (string -> US28))) list -> (struct (string * string * (string -> (string -> US28))) [])) = List.toArray
        let v414 : (struct (string * string * (string -> (string -> US28))) []) = v413 v412
        let v415 : string = "$0.to_vec()"
        let v416 : Vec<struct (string * string * (string -> (string -> US28)))> = Fable.Core.RustInterop.emitRustExpr v414 v415 
        let v417 : string = "rayon::iter::IntoParallelIterator::into_par_iter(v416)"
        let v418 : rayon_vec_IntoIter<struct (string * string * (string -> (string -> US28)))> = Fable.Core.RustInterop.emitRustExpr () v417 
        let v419 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
        let v420 : (struct (string * string * (string -> (string -> US28))) -> Result<string, (string * string)> option) = closure71()
        let v421 : rayon_iter_Map<rayon_vec_IntoIter<struct (string * string * (string -> (string -> US28)))>> = Fable.Core.RustInterop.emitRustExpr struct (v418, v420) v419 
        let v422 : string = "rayon::iter::ParallelIterator::collect($0)"
        let v423 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr v421 v422 
        let v424 : Vec<Result<string, (string * string)> option> = method94(v423)
        let v425 : Vec<Result<string, (string * string)> option> = method95(v409)
        let v426 : string = "true; let mut v425 = v425"
        let v427 : bool = Fable.Core.RustInterop.emitRustExpr () v426 
        let v428 : string = "true; v425.extend(v424)"
        let v429 : bool = Fable.Core.RustInterop.emitRustExpr () v428 
        let v430 : string = "v425"
        let v431 : Vec<Result<string, (string * string)> option> = Fable.Core.RustInterop.emitRustExpr () v430 
        let v432 : int32 = v408 + 1
        v406.l0 <- v432
        v406.l1 <- v431
        ()
    let v433 : Vec<Result<string, (string * string)> option> = v406.l1
    let v434 : (string * Vec<Result<string, (string * string)> option>) = v34, v433 
    let v435 : Result<(string * Vec<Result<string, (string * string)> option>), std_string_String> = Ok v434 
    v435
and closure72 () () : string =
    let v0 : string = "documents.run"
    v0
and closure73 (v0 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>) () : string =
    let v1 : string = "$0.len()"
    let v2 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"result_len: {v2} / {v3 ()}"
    v4
and method96 (v0 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>) : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> =
    v0
and method14 (v0 : string, v1 : string, v2 : string, v3 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> =
    let v4 : string = __SOURCE_DIRECTORY__
    let v5 : string = "polyglot"
    let v6 : string = ".paket"
    let v7 : string = method15(v5, v6)
    let v8 : US7 = method18(v7, v4)
    let v17 : US3 =
        match v8 with
        | US7_1(v11) -> (* Error *)
            let v12 : US0 = US0_3
            let v13 : (unit -> string) = closure9()
            let v14 : (unit -> string) = closure10(v11)
            method5(v12, v13, v14)
            US3_1
        | US7_0(v9) -> (* Ok *)
            US3_0(v9)
    let v33 : US3 =
        match v17 with
        | US3_1 -> (* None *)
            let v20 : string = method23()
            let v21 : string = method15(v5, v6)
            let v22 : US7 = method18(v21, v20)
            match v22 with
            | US7_1(v25) -> (* Error *)
                let v26 : US0 = US0_3
                let v27 : (unit -> string) = closure9()
                let v28 : (unit -> string) = closure10(v25)
                method5(v26, v27, v28)
                US3_1
            | US7_0(v23) -> (* Ok *)
                US3_0(v23)
        | US3_0(v18) -> (* Some *)
            US3_0(v18)
    let v37 : string =
        match v33 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v34) -> (* Some *)
            v34
    let v38 : string = method15(v37, v5)
    let v39 : string = method24(v3)
    let v40 : string = method24(v2)
    let v41 : string = method24(v1)
    let v42 : US0 = US0_1
    let v43 : (unit -> string) = closure11()
    let v44 : (unit -> string) = closure12(v0, v39, v40, v41)
    method5(v42, v43, v44)
    let v45 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v45 
    let v46 : string = "async_walkdir::WalkDir::new(&*$0)"
    let v47 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr v40 v46 
    let v48 : string = "async_walkdir::WalkDir::filter($0, |x| $1(x))"
    let v49 : (async_walkdir_DirEntry -> std_pin_Pin<Box<LifetimeJoin<Dyn<std_future_Future<async_walkdir_Filtering>>, Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>>) = closure13()
    let v50 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr struct (v47, v49) v48 
    let v51 : (Result<async_walkdir_DirEntry, std_io_Error> -> string option) = method41()
    let v52 : string = "tokio_stream::StreamExt::collect(tokio_stream::StreamExt::filter_map(v50, |x| v51(x))).await"
    let v53 : Vec<string> = Fable.Core.RustInterop.emitRustExpr () v52 
    let v54 : US0 = US0_1
    let v55 : (unit -> string) = closure22()
    let v56 : (unit -> string) = closure23(v53)
    method5(v54, v55, v56)
    let v57 : string = "rayon::iter::IntoParallelIterator::into_par_iter(v53)"
    let v58 : rayon_vec_IntoIter<string> = Fable.Core.RustInterop.emitRustExpr () v57 
    let v59 : string = "rayon::iter::ParallelIterator::map($0, |x| $1(x))"
    let v60 : (string -> Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>) = closure24(v0, v38, v39, v40, v41)
    let v61 : rayon_iter_Map<rayon_vec_IntoIter<string>> = Fable.Core.RustInterop.emitRustExpr struct (v58, v60) v59 
    let v62 : string = "rayon::iter::ParallelIterator::collect($0)"
    let v63 : Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>> = Fable.Core.RustInterop.emitRustExpr v61 v62 
    let v64 : US0 = US0_2
    let v65 : (unit -> string) = closure72()
    let v66 : (unit -> string) = closure73(v63)
    method5(v64, v65, v66)
    let v67 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = Ok v63 
    let v68 : Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String> = method96(v67)
    let v69 : string = ""
    let v70 : string = "}"
    let v71 : string = v69 + v70 
    let v72 : string = v71 + v70 
    let v73 : string = v72 + v70 
    let v74 : string = v73 + v70 
    let v75 : string = "{"
    let v76 : string = v69 + v75 
    let v77 : string = v76 + v75 
    let v78 : string = v77 + v75 
    let v79 : string = "v68 " + v74 + "); " + v78 + " //"
    Fable.Core.RustInterop.emitRustExpr () v79 
    let v80 : string = "__result"
    let v81 : std_pin_Pin<Box<Dyn<std_future_Future<Result<Vec<Result<(string * Vec<Result<string, (string * string)> option>), std_string_String>>, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v80 
    v81
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
