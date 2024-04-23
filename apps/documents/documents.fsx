[<Fable.Core.Erase; Fable.Core.Emit("Func0<$0>")>] type Func0<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Func1<$0, $1>")>] type Func0<'T, 'U> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>] type Box<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>] type Dyn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("$0 + Send")>] type Send<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn() -> $0")>] type Fn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn()")>] type FnUnit = class end
[<Fable.Core.Erase; Fable.Core.Emit("FnOnce() -> $0")>] type FnOnce<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn($0)")>] type ActionFn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn($0, $1)")>] type ActionFn2<'T, 'U> = class end
[<Fable.Core.Erase; Fable.Core.Emit("impl $0")>] type Impl<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>] type Mut<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>] type Ref<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("&'static $0")>] type StaticRef<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("MutCell<$0>")>] type MutCell<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::any::Any")>] type std_any_Any = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::cell::RefCell<$0>")>] type std_cell_RefCell<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::pin::Pin<$0>")>] type std_pin_Pin<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Rc<$0>")>] type std_rc_Rc<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Weak<$0>")>] type std_rc_Weak<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Arc<$0>")>] type std_sync_Arc<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>] type Slice<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("[$0; $1]")>] type Slice'<'T, 'U> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>] type Vec<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("str")>] type Str = class end
[<Fable.Core.Erase; Fable.Core.Emit("base64::DecodeError")>] type base64_DecodeError = class end
[<Fable.Core.Erase; Fable.Core.Emit("borsh::io::Error")>] type borsh_io_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("js_sys::JsString")>] type js_sys_JsString = class end
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Error")>] type serde_json_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Value")>] type serde_json_Value = class end
[<Fable.Core.Erase; Fable.Core.Emit("serde_wasm_bindgen::Error")>] type serde_wasm_bindgen_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsStr")>] type std_ffi_OsStr = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsString")>] type std_ffi_OsString = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::str::Utf8Error")>] type std_str_Utf8Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>] type std_string_String = class end
#if FABLE_COMPILER // file_system.types
[<Fable.Core.Erase; Fable.Core.Emit("std::fs::FileType")>] type std_fs_FileType = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Error")>] type std_io_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::path::Path")>] type std_path_Path = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::path::PathBuf")>] type std_path_PathBuf = class end
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::DirEntry")>] type async_walkdir_DirEntry = class end
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::Filtering")>] type async_walkdir_Filtering = class end
[<Fable.Core.Erase; Fable.Core.Emit("async_walkdir::WalkDir")>] type async_walkdir_WalkDir = class end
#endif // file_system.types
#if FABLE_COMPILER // runtime.types
[<Fable.Core.Erase; Fable.Core.Emit("clap::Arg")>] type clap_Arg = class end
[<Fable.Core.Erase; Fable.Core.Emit("clap::Command")>] type clap_Command = class end
[<Fable.Core.Erase; Fable.Core.Emit("clap::ArgMatches")>] type clap_ArgMatches = class end
#endif // runtime.types
#if FABLE_COMPILER // async.types
[<Fable.Core.Erase; Fable.Core.Emit("std::future::Future<Output = $0>")>] type std_future_Future<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("futures::future::TryJoinAll<$0>")>] type futures_future_TryJoinAll<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("rayon::vec::IntoIter<$0>")>] type rayon_vec_IntoIter<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("rayon::iter::Map<$0, _>")>] type rayon_iter_Map<'T> = class end
#endif // async.types
type IPathJoin = abstract join: [<System.ParamArray>] paths: string[] -> string
type IFsExistsSync = abstract existsSync: path: string -> bool
type IPathDirname = abstract dirname: path: string -> string
module State = let mutable trace_state = None
type [<Struct>] US0 =
    | US0_0 of f0_0 : string
    | US0_1
and [<Struct>] US1 =
    | US1_0
    | US1_1
    | US1_2
    | US1_3
    | US1_4
and Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : bool}
and Mut2 = {mutable l0 : US1}
and Mut3 = {mutable l0 : (string -> unit)}
and [<Struct>] US2 =
    | US2_0 of f0_0 : int64
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : int64
    | US3_1
and [<Struct>] US4 =
    | US4_0 of f0_0 : std_string_String
    | US4_1
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
let rec method0 () : clap_Command =
    let v0 : string = "command"
    let v1 : string = "r#\"" + v0 + "\"#"
    let v2 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v1
    let v3 : string = "clap::Command::new($0)"
    let v4 : clap_Command = Fable.Core.RustInterop.emitRustExpr v2 v3
    let v5 : string = "dir"
    let v6 : string = "r#\"" + v5 + "\"#"
    let v7 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v6
    let v8 : string = "clap::Arg::new($0)"
    let v9 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "$0.short($1)"
    let v11 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v9, 'd') v10
    let v12 : string = "r#\"" + v5 + "\"#"
    let v13 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : string = "$0.long($1)"
    let v15 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v11, v13) v14
    let v16 : string = "$0.required($1)"
    let v17 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v15, true) v16
    let v18 : string = "clap::Command::arg($0, $1)"
    let v19 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v4, v17) v18
    let v20 : string = "hangul-spec"
    let v21 : string = "r#\"" + v20 + "\"#"
    let v22 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : string = "clap::Arg::new($0)"
    let v24 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v22 v23
    let v25 : string = "$0.short($1)"
    let v26 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v24, 's') v25
    let v27 : string = "r#\"" + v20 + "\"#"
    let v28 : StaticRef<Str> = Fable.Core.RustInterop.emitRustExpr () v27
    let v29 : string = "$0.long($1)"
    let v30 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v26, v28) v29
    let v31 : string = "$0.required($1)"
    let v32 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v30, true) v31
    let v33 : string = "clap::Command::arg($0, $1)"
    let v34 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v19, v32) v33
    v34
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
    let v0 : string = "polyglot"
    v0
and method2 () : string =
    let v0 : string = ".paket"
    v0
and method3 () : string =
    let v0 : string = "polyglot"
    v0
and method4 () : string =
    let v0 : string = ".paket"
    v0
and method6 (v0 : string) : string =
    v0
and method7 (v0 : string) : string =
    v0
and method8 (v0 : string) : string =
    v0
and closure2 () (v0 : string) : string option =
    let v1 : US0 option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method6(v0)
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
    let v14 : string = "$0.display().to_string()"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "fable_library_rust::String_::fromString($0)"
    let v17 : string = Fable.Core.RustInterop.emitRustExpr v15 v16
    let v18 : US0 = US0_0(v17)
    v18
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v19 : US0 = null |> unbox<US0>
    v19
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v20 : US0 = null |> unbox<US0>
    v20
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v21 : (string -> System.IO.DirectoryInfo) = System.IO.Directory.GetParent
    let v22 : System.IO.DirectoryInfo = v21 v0
    let v23 : System.IO.DirectoryInfo = null |> unbox<System.IO.DirectoryInfo>
    let v24 : bool = v22 = v23
    let v36 : US0 =
        if v24 then
            US0_1
        else
            let v26 : string option = None
            let v27 : bool = true in let mutable _v26 = v26
            #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v28 : string = null |> unbox<string>
            v28
#endif
            #if FABLE_COMPILER_RUST && WASM
            let v29 : string = null |> unbox<string>
            v29
#endif
            #if FABLE_COMPILER_RUST && CONTRACT
            let v30 : string = null |> unbox<string>
            v30
#endif
            #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
            let v31 : string = v22.FullName
            v31
#endif
            #if FABLE_COMPILER_TYPESCRIPT
            let v32 : string = null |> unbox<string>
            v32
#endif
            #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
            let v33 : string = Unchecked.defaultof<string>
            v33
#endif
            |> fun x -> _v26 <- Some x
            let v34 : string = _v26.Value
            US0_0(v34)
    v36
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v37 : string = "path"
    let v38 : IPathDirname = Fable.Core.JsInterop.importAll v37
    let v39 : string = "v38.dirname($0)"
    let v40 : string = Fable.Core.JsInterop.emitJsExpr v0 v39
    let v41 : US0 = US0_0(v40)
    v41
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v42 : US0 = Unchecked.defaultof<US0>
    v42
#endif
    |> fun x -> _v1 <- Some x
    let v43 : US0 = _v1.Value
    match v43 with
    | US0_1 -> (* None *)
        let v46 : string option = None
        v46
    | US0_0(v44) -> (* Some *)
        let v45 : string option = Some v44 
        v45
and method9 () : (string -> string option) =
    closure2()
and closure3 () (v0 : string) : US0 =
    US0_0(v0)
and method10 () : (string -> US0) =
    closure3()
and method11 (v0 : string, v1 : string, v2 : string) : string =
    let v3 : string option = None
    let v4 : bool = true in let mutable _v3 = v3
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = method6(v2)
    let v6 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v7 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v6
    let v8 : string = "String::from($0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7 v8
    let v10 : string = "std::path::PathBuf::from($0)"
    let v11 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v9 v10
    let v12 : string = method6(v0)
    let v13 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v12 v13
    let v15 : string = "String::from($0)"
    let v16 : std_string_String = Fable.Core.RustInterop.emitRustExpr v14 v15
    let v17 : string = "$0.join($1)"
    let v18 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v11, v16) v17
    let v19 : string = "$0.display().to_string()"
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v25 : string = System.IO.Path.Combine (v2, v0)
    v25
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v26 : string = "path"
    let v27 : IPathJoin = Fable.Core.JsInterop.importAll v26
    let v28 : string = method7(v2)
    let v29 : string = method8(v0)
    let v30 : string = "v27.join(v28, v29)"
    let v31 : string = Fable.Core.JsInterop.emitJsExpr () v30
    v31
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v32 : string = Unchecked.defaultof<string>
    v32
#endif
    |> fun x -> _v3 <- Some x
    let v33 : string = _v3.Value
    let v34 : bool option = None
    let v35 : bool = true in let mutable _v34 = v34
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v36 : string = method6(v33)
    let v37 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v38 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v37
    let v39 : string = "String::from($0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v38 v39
    let v41 : string = "std::path::PathBuf::from($0)"
    let v42 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v40 v41
    let v43 : string = "$0.exists()"
    let v44 : bool = Fable.Core.RustInterop.emitRustExpr v42 v43
    let v47 : bool =
        if v44 then
            let v45 : string = "$0.is_dir()"
            let v46 : bool = Fable.Core.RustInterop.emitRustExpr v42 v45
            v46
        else
            false
    v47
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v48 : bool = null |> unbox<bool>
    v48
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v49 : bool = null |> unbox<bool>
    v49
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v50 : (string -> bool) = System.IO.Directory.Exists
    let v51 : bool = v50 v33
    v51
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v52 : string = "fs"
    let v53 : IFsExistsSync = Fable.Core.JsInterop.importAll v52
    let v54 : string = "v53.existsSync($0)"
    let v55 : bool = Fable.Core.JsInterop.emitJsExpr v33 v54
    v55
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v56 : bool = Unchecked.defaultof<bool>
    v56
#endif
    |> fun x -> _v34 <- Some x
    let v57 : bool = _v34.Value
    if v57 then
        v2
    else
        let v58 : (string -> string option) = method9()
        let v59 : string option = v58 v2
        let v60 : (string -> US0) = method10()
        let v61 : US0 = US0_1
        let v62 : US0 = v59 |> Option.map v60 |> Option.defaultValue v61 
        match v62 with
        | US0_1 -> (* None *)
            let v65 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v2}')"""
            failwith<string> v65
        | US0_0(v63) -> (* Some *)
            method11(v0, v1, v63)
and method5 (v0 : string, v1 : string) : string =
    let v2 : string option = None
    let v3 : bool = true in let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method6(v1)
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "std::path::PathBuf::from($0)"
    let v10 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = method6(v0)
    let v12 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "String::from($0)"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "$0.join($1)"
    let v17 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v10, v15) v16
    let v18 : string = "$0.display().to_string()"
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v24 : string = System.IO.Path.Combine (v1, v0)
    v24
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v25 : string = "path"
    let v26 : IPathJoin = Fable.Core.JsInterop.importAll v25
    let v27 : string = method7(v1)
    let v28 : string = method8(v0)
    let v29 : string = "v26.join(v27, v28)"
    let v30 : string = Fable.Core.JsInterop.emitJsExpr () v29
    v30
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v31 : string = Unchecked.defaultof<string>
    v31
#endif
    |> fun x -> _v2 <- Some x
    let v32 : string = _v2.Value
    let v33 : bool option = None
    let v34 : bool = true in let mutable _v33 = v33
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v35 : string = method6(v32)
    let v36 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v37 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v35 v36
    let v38 : string = "String::from($0)"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr v37 v38
    let v40 : string = "std::path::PathBuf::from($0)"
    let v41 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v39 v40
    let v42 : string = "$0.exists()"
    let v43 : bool = Fable.Core.RustInterop.emitRustExpr v41 v42
    let v46 : bool =
        if v43 then
            let v44 : string = "$0.is_dir()"
            let v45 : bool = Fable.Core.RustInterop.emitRustExpr v41 v44
            v45
        else
            false
    v46
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v47 : bool = null |> unbox<bool>
    v47
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v48 : bool = null |> unbox<bool>
    v48
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v49 : (string -> bool) = System.IO.Directory.Exists
    let v50 : bool = v49 v32
    v50
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v51 : string = "fs"
    let v52 : IFsExistsSync = Fable.Core.JsInterop.importAll v51
    let v53 : string = "v52.existsSync($0)"
    let v54 : bool = Fable.Core.JsInterop.emitJsExpr v32 v53
    v54
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v55 : bool = Unchecked.defaultof<bool>
    v55
#endif
    |> fun x -> _v33 <- Some x
    let v56 : bool = _v33.Value
    if v56 then
        v1
    else
        let v57 : (string -> string option) = method9()
        let v58 : string option = v57 v1
        let v59 : (string -> US0) = method10()
        let v60 : US0 = US0_1
        let v61 : US0 = v58 |> Option.map v59 |> Option.defaultValue v60 
        match v61 with
        | US0_1 -> (* None *)
            let v64 : string = $"""No parent for {if false then "file" else "dir"} '{v0}' at '{v1}' (until '{v1}')"""
            failwith<string> v64
        | US0_0(v62) -> (* Some *)
            method11(v0, v1, v62)
and method12 () : string =
    let v0 : string = "polyglot"
    v0
and closure4 () () : string =
    let v0 : string = $"documents.main"
    v0
and closure6 () () : string =
    let v0 : string = ""
    v0
and closure5 (v0 : (string []), v1 : string, v2 : string) () : string =
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"args: {v0} / current_dir: {v2} / repository_root: {v1} / {v3 ()}"
    v4
and closure9 () (v0 : string) : unit =
    ()
and method14 (v0 : int64 option) : int64 option =
    v0
and method15 (v0 : int64 option) : int64 option =
    v0
and closure8 () () : struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3) =
    let v0 : Mut1 = {l0 = true} : Mut1
    let v1 : Mut0 = {l0 = 0L} : Mut0
    let v2 : US1 = US1_0
    let v3 : Mut2 = {l0 = v2} : Mut2
    let v4 : (string -> unit) = closure9()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v6 : int64 option option = None
    let mutable _v6 = v6
    #if INTERACTIVE || !FABLE_COMPILER
    let v7 : string option = None
    let v8 : bool = true in let mutable _v7 = v7
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : string = null |> unbox<string>
    v9
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v10 : string = null |> unbox<string>
    v10
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v11 : string = null |> unbox<string>
    v11
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v12 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v12
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v13 : string = null |> unbox<string>
    v13
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v14 : string = Unchecked.defaultof<string>
    v14
#endif
    |> fun x -> _v7 <- Some x
    let v15 : string = _v7.Value
    let v17 : bool = v15 = "Microsoft.DotNet.Interactive.App"
    let v18 : bool = v17 <> true
    let v24 : US2 =
        if v18 then
            let v19 : System.DateTime = System.DateTime.Now
            let v20 : (System.DateTime -> int64) = _.Ticks
            let v21 : int64 = v20 v19
            US2_0(v21)
        else
            US2_1
    let v29 : int64 option =
        match v24 with
        | US2_1 -> (* None *)
            let v27 : int64 option = None
            v27
        | US2_0(v25) -> (* Some *)
            let v26 : int64 option = Some v25 
            v26
    let v30 : int64 option = method14(v29)
    v30 
    #else
    let v31 : int64 option = None
    let v32 : int64 option = method15(v31)
    v32 
    #endif
    |> fun x -> _v6 <- Some x
    let v33 : int64 option = _v6.Value
    struct (v1, v0, v3, v33, v5)
and closure10 () (v0 : int64) : US3 =
    US3_0(v0)
and method16 () : (int64 -> US3) =
    closure10()
and method17 () : string =
    let v0 : string = ""
    v0
and closure7 (v0 : US1, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure8()
    if State.trace_state.IsNone then State.trace_state <- v3 () |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut2, v7 : int64 option, v8 : Mut3) = State.trace_state.Value
    let v9 : string option = None
    let v10 : bool = true in let mutable _v9 = v9
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : (int64 -> US3) = method16()
    let v12 : US3 = US3_1
    let v13 : US3 = v7 |> Option.map v11 |> Option.defaultValue v12 
    let v31 : System.DateTime =
        match v13 with
        | US3_1 -> (* None *)
            let v29 : System.DateTime = System.DateTime.Now
            v29
        | US3_0(v14) -> (* Some *)
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
    let v34 : string = method17()
    v34
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v35 : string = method17()
    v35
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v36 : (int64 -> US3) = method16()
    let v37 : US3 = US3_1
    let v38 : US3 = v7 |> Option.map v36 |> Option.defaultValue v37 
    let v56 : System.DateTime =
        match v38 with
        | US3_1 -> (* None *)
            let v54 : System.DateTime = System.DateTime.Now
            v54
        | US3_0(v39) -> (* Some *)
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
    let v59 : string = method17()
    v59
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v60 : string = Unchecked.defaultof<string>
    v60
#endif
    |> fun x -> _v9 <- Some x
    let v61 : string = _v9.Value
    let v62 : int64 = v4.l0
    let v72 : string =
        match v0 with
        | US1_4 -> (* Critical *)
            let v67 : string = "Critical"
            v67
        | US1_1 -> (* Debug *)
            let v64 : string = "Debug"
            v64
        | US1_2 -> (* Info *)
            let v65 : string = "Info"
            v65
        | US1_0 -> (* Verbose *)
            let v63 : string = "Verbose"
            v63
        | US1_3 -> (* Warning *)
            let v66 : string = "Warning"
            v66
    let v73 : string = v72.ToLower ()
    let v74 : string = v73.PadRight (7, ' ')
    let v75 : string option = None
    let v76 : bool = true in let mutable _v75 = v75
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v91 : Ref<Str> =
        match v0 with
        | US1_4 -> (* Critical *)
            let v85 : string = "inline_colorization::color_bright_red"
            let v86 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v85
            v86
        | US1_1 -> (* Debug *)
            let v79 : string = "inline_colorization::color_bright_blue"
            let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v79
            v80
        | US1_2 -> (* Info *)
            let v81 : string = "inline_colorization::color_bright_green"
            let v82 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v81
            v82
        | US1_0 -> (* Verbose *)
            let v77 : string = "inline_colorization::color_bright_black"
            let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v77
            v78
        | US1_3 -> (* Warning *)
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
        | US1_4 -> (* Critical *)
            let v109 : string = "inline_colorization::color_bright_red"
            let v110 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v109
            v110
        | US1_1 -> (* Debug *)
            let v103 : string = "inline_colorization::color_bright_blue"
            let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v103
            v104
        | US1_2 -> (* Info *)
            let v105 : string = "inline_colorization::color_bright_green"
            let v106 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v105
            v106
        | US1_0 -> (* Verbose *)
            let v101 : string = "inline_colorization::color_bright_black"
            let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v101
            v102
        | US1_3 -> (* Warning *)
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
        | US1_4 -> (* Critical *)
            let v133 : string = "inline_colorization::color_bright_red"
            let v134 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v133
            v134
        | US1_1 -> (* Debug *)
            let v127 : string = "inline_colorization::color_bright_blue"
            let v128 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v127
            v128
        | US1_2 -> (* Info *)
            let v129 : string = "inline_colorization::color_bright_green"
            let v130 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v129
            v130
        | US1_0 -> (* Verbose *)
            let v125 : string = "inline_colorization::color_bright_black"
            let v126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v125
            v126
        | US1_3 -> (* Warning *)
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
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v149 : string = Unchecked.defaultof<string>
    v149
#endif
    |> fun x -> _v75 <- Some x
    let v150 : string = _v75.Value
    let v151 : string = $"{v61} {v150} #{v62} %s{v1 ()} / %s{v2 ()}"
    let v152 : (char []) = [||]
    let v153 : string = v151.TrimStart v152
    let v154 : (char []) = [|' '; '/'|]
    let v155 : string = v153.TrimEnd v154
    v155
and method18 (v0 : US1, v1 : (unit -> string)) : unit =
    let v2 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure8()
    if State.trace_state.IsNone then State.trace_state <- v2 () |> Some
    let struct (v3 : Mut0, v4 : Mut1, v5 : Mut2, v6 : int64 option, v7 : Mut3) = State.trace_state.Value
    if State.trace_state.IsNone then State.trace_state <- v2 () |> Some
    let struct (v8 : Mut0, v9 : Mut1, v10 : Mut2, v11 : int64 option, v12 : Mut3) = State.trace_state.Value
    let v13 : US1 = v10.l0
    let v14 : bool = v9.l0
    let v15 : bool = v14 = false
    let v19 : bool =
        if v15 then
            false
        else
            let v16 : int32 = [ US1_0, 0; US1_1, 1; US1_2, 2; US1_3, 3; US1_4, 4 ] |> Map |> Map.find v0
            let v17 : int32 = [ US1_0, 0; US1_1, 1; US1_2, 2; US1_3, 3; US1_4, 4 ] |> Map |> Map.find v13
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
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<unit>
        ()
#endif
        |> fun x -> _v23 <- Some x
        _v23.Value
        let v28 : (string -> unit) = v7.l0
        v28 v22
and method13 (v0 : US1, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> string) = closure7(v0, v1, v2)
    method18(v0, v3)
and method19 () : string =
    let v0 : string = "dir"
    v0
and closure11 () (v0 : std_string_String) : US4 =
    US4_0(v0)
and method20 () : (std_string_String -> US4) =
    closure11()
and method21 () : string =
    let v0 : string = "hangul-spec"
    v0
and method23 (v0 : string) : string =
    v0
and closure12 () () : string =
    let v0 : string = "documents.run"
    v0
and closure13 (v0 : string, v1 : string) () : string =
    let v2 : (unit -> string) = closure6()
    let v3 : string = $"dir: %A{v1} / hangul_spec: %A{v0} / {v2 ()}"
    v3
and method26 (v0 : async_walkdir_DirEntry) : async_walkdir_DirEntry =
    v0
and closure15 () (v0 : std_io_Error) : std_string_String =
    let v1 : string = @$"format!(""{{}}"", $0)"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and method27 () : (std_io_Error -> std_string_String) =
    closure15()
and closure16 () (v0 : std_fs_FileType) : US6 =
    US6_0(v0)
and closure17 () (v0 : std_string_String) : US6 =
    US6_1(v0)
and method28 (v0 : std_fs_FileType) : std_fs_FileType =
    v0
and method29 (v0 : US5) : US5 =
    v0
and method25 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<Send<Dyn<std_future_Future<US5>>>>> =
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
    let v10 : (std_fs_FileType -> US6) = closure16()
    let v11 : (std_string_String -> US6) = closure17()
    let v12 : US6 = match v9 with Ok x -> v10 x | Error x -> v11 x
    let v49 : US5 =
        match v12 with
        | US6_0(v13) -> (* Ok *)
            let v14 : std_fs_FileType = method28(v13)
            let v15 : string = "std::fs::FileType::is_dir(&v14)"
            let v16 : bool = Fable.Core.RustInterop.emitRustExpr () v15
            if v16 then
                US5_0
            else
                let v18 : string = "async_walkdir::DirEntry::path(&$0)"
                let v19 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v0 v18
                let v20 : string = "$0.display().to_string()"
                let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v20
                let v22 : string = "fable_library_rust::String_::fromString($0)"
                let v23 : string = Fable.Core.RustInterop.emitRustExpr v21 v22
                let v24 : string = ".md"
                let v25 : bool = v23.EndsWith v24
                let v26 : bool = v25 = false
                let v29 : bool =
                    if v26 then
                        true
                    else
                        let v27 : string = ".hangul.md"
                        let v28 : bool = v23.EndsWith v27
                        v28
                if v29 then
                    US5_0
                else
                    US5_2
        | _ ->
            let v34 : string = "async_walkdir::DirEntry::path(&$0)"
            let v35 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v0 v34
            let v36 : string = "$0.display().to_string()"
            let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr v35 v36
            let v38 : string = "fable_library_rust::String_::fromString($0)"
            let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38
            let v40 : string = ".md"
            let v41 : bool = v39.EndsWith v40
            let v42 : bool = v41 = false
            let v45 : bool =
                if v42 then
                    true
                else
                    let v43 : string = ".hangul.md"
                    let v44 : bool = v39.EndsWith v43
                    v44
            if v45 then
                US5_0
            else
                US5_2
    let v50 : US5 = method29(v49)
    let v51 : string = "v50 }})"
    Fable.Core.RustInterop.emitRustExpr () v51
    let v52 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v52
    let v53 : string = "__result"
    let v54 : std_pin_Pin<Box<Send<Dyn<std_future_Future<US5>>>>> = Fable.Core.RustInterop.emitRustExpr () v53
    v54
and method30 (v0 : async_walkdir_Filtering) : async_walkdir_Filtering =
    v0
and method24 (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>> =
    let v1 : string = "let __result = Box::pin(async { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : std_pin_Pin<Box<Send<Dyn<std_future_Future<US5>>>>> = method25(v0)
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
    let v14 : async_walkdir_Filtering = method30(v13)
    let v15 : string = "v14 }})"
    Fable.Core.RustInterop.emitRustExpr () v15
    let v16 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v16
    let v17 : string = "__result"
    let v18 : std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>> = Fable.Core.RustInterop.emitRustExpr () v17
    v18
and closure14 () (v0 : async_walkdir_DirEntry) : std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>> =
    method24(v0)
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
and closure18 () (v0 : Result<async_walkdir_DirEntry, std_io_Error>) : std_string_String option =
    let v1 : (std_io_Error -> std_string_String) = method27()
    let v2 : string = "$0.map_err(|x| $1(x))"
    let v3 : Result<async_walkdir_DirEntry, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v0, v1) v2
    let v4 : (async_walkdir_DirEntry -> US7) = closure19()
    let v5 : (std_string_String -> US7) = closure20()
    let v6 : US7 = match v3 with Ok x -> v4 x | Error x -> v5 x
    let v19 : US4 =
        match v6 with
        | US7_1(v13) -> (* Error *)
            let v14 : US1 = US1_4
            let v15 : (unit -> string) = closure21()
            let v16 : (unit -> string) = closure22(v13)
            method13(v14, v15, v16)
            US4_1
        | US7_0(v7) -> (* Ok *)
            let v8 : string = "async_walkdir::DirEntry::path(&$0)"
            let v9 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v7 v8
            let v10 : string = "$0.display().to_string()"
            let v11 : std_string_String = Fable.Core.RustInterop.emitRustExpr v9 v10
            US4_0(v11)
    match v19 with
    | US4_1 -> (* None *)
        let v22 : std_string_String option = None
        v22
    | US4_0(v20) -> (* Some *)
        let v21 : std_string_String option = Some v20 
        v21
and method31 () : (Result<async_walkdir_DirEntry, std_io_Error> -> std_string_String option) =
    closure18()
and closure23 () () : string =
    let v0 : string = "documents.run"
    v0
and closure24 (v0 : Vec<std_string_String>) () : string =
    let v1 : string = "$0.len()"
    let v2 : unativeint = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"files_len: {v2} / {v3 ()}"
    v4
and closure25 () (v0 : std_string_String) : Result<std_string_String, std_string_String> =
    let v1 : Result<std_string_String, std_string_String> = Ok v0
    v1
and closure26 () () : string =
    let v0 : string = "documents.run"
    v0
and closure27 (v0 : Vec<Result<std_string_String, std_string_String>>) () : string =
    let v1 : string = @$"format!(""{{:#?}}"", $0)"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    let v3 : (unit -> string) = closure6()
    let v4 : string = $"result: {v2} / {v3 ()}"
    v4
and method32 (v0 : Result<unit, std_string_String>) : Result<unit, std_string_String> =
    v0
and method22 (v0 : string, v1 : string) : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>> =
    let v2 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v2
    let v3 : string option = None
    let v4 : bool = true in let mutable _v3 = v3
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = "std::fs::canonicalize(&*$0)"
    let v6 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v1 v5
    let v7 : string = "$0.unwrap()"
    let v8 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "$0.display().to_string()"
    let v10 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = "fable_library_rust::String_::fromString($0)"
    let v12 : string = Fable.Core.RustInterop.emitRustExpr v10 v11
    v12
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v13 : string = null |> unbox<string>
    v13
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v14 : string = null |> unbox<string>
    v14
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v15 : string = method23(v1)
    let v16 : (string -> string) = System.IO.Path.GetFullPath
    let v17 : string = v16 v15
    v17
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v18 : string = null |> unbox<string>
    v18
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v19 : string = Unchecked.defaultof<string>
    v19
#endif
    |> fun x -> _v3 <- Some x
    let v20 : string = _v3.Value
    let v21 : US1 = US1_0
    let v22 : (unit -> string) = closure12()
    let v23 : (unit -> string) = closure13(v0, v20)
    method13(v21, v22, v23)
    let v24 : string = "async_walkdir::WalkDir::new(&*$0)"
    let v25 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr v20 v24
    let v26 : string = "async_walkdir::WalkDir::filter($0, |x| $1(x))"
    let v27 : (async_walkdir_DirEntry -> std_pin_Pin<Box<Send<Dyn<std_future_Future<async_walkdir_Filtering>>>>>) = closure14()
    let v28 : async_walkdir_WalkDir = Fable.Core.RustInterop.emitRustExpr struct (v25, v27) v26
    let v29 : (Result<async_walkdir_DirEntry, std_io_Error> -> std_string_String option) = method31()
    let v30 : string = "futures_lite::stream::StreamExt::collect(futures_lite::stream::StreamExt::filter_map(v28, |x| v29(x))).await"
    let v31 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : US1 = US1_0
    let v33 : (unit -> string) = closure23()
    let v34 : (unit -> string) = closure24(v31)
    method13(v32, v33, v34)
    let v35 : string = "rayon::iter::IntoParallelIterator::into_par_iter(v31)"
    let v36 : rayon_vec_IntoIter<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v35
    let v37 : string = "rayon::iter::ParallelIterator::map(v36, |x| $0(x))"
    let v38 : (std_string_String -> Result<std_string_String, std_string_String>) = closure25()
    let v39 : rayon_iter_Map<rayon_vec_IntoIter<std_string_String>> = Fable.Core.RustInterop.emitRustExpr v38 v37
    let v40 : string = "rayon::iter::ParallelIterator::collect(v39)"
    let v41 : Vec<Result<std_string_String, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v40
    let v42 : US1 = US1_0
    let v43 : (unit -> string) = closure26()
    let v44 : (unit -> string) = closure27(v41)
    method13(v42, v43, v44)
    let v45 : Result<unit, std_string_String> = Ok ()
    let v46 : Result<unit, std_string_String> = method32(v45)
    let v47 : string = "v46 }}}}}})"
    Fable.Core.RustInterop.emitRustExpr () v47
    let v48 : string = "{{{{{ //"
    Fable.Core.RustInterop.emitRustExpr () v48
    let v49 : string = "__result"
    let v50 : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>> = Fable.Core.RustInterop.emitRustExpr () v49
    v50
and closure1 () (v0 : (string [])) : int32 =
    let v1 : string = __SOURCE_DIRECTORY__
    let v2 : string option = None
    let v3 : bool = true in let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method1()
    let v5 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5
    let v7 : string = "String::from($0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v7
    let v9 : string = "std::path::PathBuf::from($0)"
    let v10 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v8 v9
    let v11 : string = method2()
    let v12 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v13 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v11 v12
    let v14 : string = "String::from($0)"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v14
    let v16 : string = "$0.join($1)"
    let v17 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v10, v15) v16
    let v18 : string = "$0.display().to_string()"
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v24 : string = "polyglot"
    let v25 : string = ".paket"
    let v26 : string = System.IO.Path.Combine (v24, v25)
    v26
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v27 : string = "path"
    let v28 : IPathJoin = Fable.Core.JsInterop.importAll v27
    let v29 : string = method3()
    let v30 : string = method4()
    let v31 : string = "v28.join(v29, v30)"
    let v32 : string = Fable.Core.JsInterop.emitJsExpr () v31
    v32
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v33 : string = Unchecked.defaultof<string>
    v33
#endif
    |> fun x -> _v2 <- Some x
    let v34 : string = _v2.Value
    let v35 : string = method5(v34, v1)
    let v36 : string option = None
    let v37 : bool = true in let mutable _v36 = v36
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : string = method6(v35)
    let v39 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v40 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v38 v39
    let v41 : string = "String::from($0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v40 v41
    let v43 : string = "std::path::PathBuf::from($0)"
    let v44 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v42 v43
    let v45 : string = method1()
    let v46 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v47 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v45 v46
    let v48 : string = "String::from($0)"
    let v49 : std_string_String = Fable.Core.RustInterop.emitRustExpr v47 v48
    let v50 : string = "$0.join($1)"
    let v51 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr struct (v44, v49) v50
    let v52 : string = "$0.display().to_string()"
    let v53 : std_string_String = Fable.Core.RustInterop.emitRustExpr v51 v52
    let v54 : string = "fable_library_rust::String_::fromString($0)"
    let v55 : string = Fable.Core.RustInterop.emitRustExpr v53 v54
    v55
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v56 : string = null |> unbox<string>
    v56
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v57 : string = null |> unbox<string>
    v57
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v58 : string = System.IO.Path.Combine (v35, v24)
    v58
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v59 : IPathJoin = Fable.Core.JsInterop.importAll v27
    let v60 : string = method7(v35)
    let v61 : string = method12()
    let v62 : string = "v59.join(v60, v61)"
    let v63 : string = Fable.Core.JsInterop.emitJsExpr () v62
    v63
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v64 : string = Unchecked.defaultof<string>
    v64
#endif
    |> fun x -> _v36 <- Some x
    let v65 : string = _v36.Value
    let v66 : string option = None
    let v67 : bool = true in let mutable _v66 = v66
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v68 : string = "std::env::current_dir()"
    let v69 : Result<std_path_PathBuf, std_io_Error> = Fable.Core.RustInterop.emitRustExpr () v68
    let v70 : string = "$0.unwrap()"
    let v71 : std_path_PathBuf = Fable.Core.RustInterop.emitRustExpr v69 v70
    let v72 : string = "$0.display().to_string()"
    let v73 : std_string_String = Fable.Core.RustInterop.emitRustExpr v71 v72
    let v74 : string = "fable_library_rust::String_::fromString($0)"
    let v75 : string = Fable.Core.RustInterop.emitRustExpr v73 v74
    v75
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v76 : string = null |> unbox<string>
    v76
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v77 : string = null |> unbox<string>
    v77
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v78 : (unit -> string) = System.IO.Directory.GetCurrentDirectory
    let v79 : string = v78 ()
    v79
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v80 : string = null |> unbox<string>
    v80
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v81 : string = Unchecked.defaultof<string>
    v81
#endif
    |> fun x -> _v66 <- Some x
    let v82 : string = _v66.Value
    let v83 : US1 = US1_2
    let v84 : (unit -> string) = closure4()
    let v85 : (unit -> string) = closure5(v0, v65, v82)
    method13(v83, v84, v85)
    let v86 : clap_Command = method0()
    let v87 : string = "clap::Command::get_matches($0)"
    let v88 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v86 v87
    let v89 : string = method19()
    let v90 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v91 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v89 v90
    let v92 : string = "clap::ArgMatches::get_one(&v88, v91).cloned()"
    let v93 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v92
    let v94 : (std_string_String -> US4) = method20()
    let v95 : US4 = US4_1
    let v96 : US4 = v93 |> Option.map v94 |> Option.defaultValue v95 
    let v100 : std_string_String =
        match v96 with
        | US4_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US4_0(v97) -> (* Some *)
            v97
    let v101 : string = "fable_library_rust::String_::fromString($0)"
    let v102 : string = Fable.Core.RustInterop.emitRustExpr v100 v101
    let v103 : string = method21()
    let v104 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v105 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v103 v104
    let v106 : string = "clap::ArgMatches::get_one(&v88, v105).cloned()"
    let v107 : std_string_String option = Fable.Core.RustInterop.emitRustExpr () v106
    let v108 : (std_string_String -> US4) = method20()
    let v109 : US4 = US4_1
    let v110 : US4 = v107 |> Option.map v108 |> Option.defaultValue v109 
    let v114 : std_string_String =
        match v110 with
        | US4_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US4_0(v111) -> (* Some *)
            v111
    let v115 : string = "fable_library_rust::String_::fromString($0)"
    let v116 : string = Fable.Core.RustInterop.emitRustExpr v114 v115
    let v117 : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, std_string_String>>>>> = method22(v116, v102)
    let v118 : string = "futures_lite::future::block_on(v117)"
    let v119 : Result<unit, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v118
    let v120 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v119 v120
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
