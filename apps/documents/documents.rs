#![allow(dead_code)]
#![allow(non_camel_case_types)]
#![allow(non_snake_case)]
#![allow(non_upper_case_globals)]
#![allow(unreachable_code)]
#![allow(unused_attributes)]
#![allow(unused_imports)]
#![allow(unused_macros)]
#![allow(unused_parens)]
#![allow(unused_variables)]
use fable_library_rust::NativeArray_::array_from;
use fable_library_rust::String_::fromString;
mod module_2555ccf7 {
    pub mod Documents {
        use super::*;
        use fable_library_rust::DateTime_::DateTime;
        use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_empty;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::getValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::String_::endsWith;
        use fable_library_rust::String_::padRight;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toLower;
        use fable_library_rust::String_::trimEndChars;
        use fable_library_rust::String_::trimStartChars;
        use fable_library_rust::TimeSpan_::TimeSpan;
        pub trait IPathJoin {
            fn join(&self, paths: Array<string>) -> string;
        }
        impl<V: IPathJoin + Clone + 'static> IPathJoin for LrcPtr<V> {
            #[inline]
            fn join(&self, paths: Array<string>) -> string {
                (**self).join(paths)
            }
        }
        pub trait IFsExistsSync {
            fn existsSync(&self, path: string) -> bool;
        }
        impl<V: IFsExistsSync + Clone + 'static> IFsExistsSync for LrcPtr<V> {
            #[inline]
            fn existsSync(&self, path: string) -> bool {
                (**self).existsSync(path)
            }
        }
        pub trait IPathDirname {
            fn dirname(&self, path: string) -> string;
        }
        impl<V: IPathDirname + Clone + 'static> IPathDirname for LrcPtr<V> {
            #[inline]
            fn dirname(&self, path: string) -> string {
                (**self).dirname(path)
            }
        }
        pub mod State {
            use super::*;
            pub fn trace_state() -> LrcPtr<
                MutCell<
                    Option<(
                        LrcPtr<Documents::Mut0>,
                        LrcPtr<Documents::Mut1>,
                        LrcPtr<Documents::Mut2>,
                        Option<i64>,
                        LrcPtr<Documents::Mut3>,
                    )>,
                >,
            > {
                static trace_state: OnceInit<
                    LrcPtr<
                        MutCell<
                            Option<(
                                LrcPtr<Documents::Mut0>,
                                LrcPtr<Documents::Mut1>,
                                LrcPtr<Documents::Mut2>,
                                Option<i64>,
                                LrcPtr<Documents::Mut3>,
                            )>,
                        >,
                    >,
                > = OnceInit::new();
                trace_state
                    .get_or_init(|| {
                        LrcPtr::new(MutCell::new(
                            None::<(
                                LrcPtr<Documents::Mut0>,
                                LrcPtr<Documents::Mut1>,
                                LrcPtr<Documents::Mut2>,
                                Option<i64>,
                                LrcPtr<Documents::Mut3>,
                            )>,
                        ))
                    })
                    .clone()
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US0 {
            US0_0(string),
            US0_1,
        }
        impl Documents::US0 {
            pub fn get_IsUS0_0(this_: &MutCell<Documents::US0>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS0_1(this_: &MutCell<Documents::US0>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US1 {
            US1_0,
            US1_1,
            US1_2,
            US1_3,
            US1_4,
        }
        impl Documents::US1 {
            pub fn get_IsUS1_0(this_: &MutCell<Documents::US1>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS1_1(this_: &MutCell<Documents::US1>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS1_2(this_: &MutCell<Documents::US1>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS1_3(this_: &MutCell<Documents::US1>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS1_4(this_: &MutCell<Documents::US1>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut0 {
            pub l0: MutCell<i64>,
        }
        impl core::fmt::Display for Documents::Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut1 {
            pub l0: MutCell<bool>,
        }
        impl core::fmt::Display for Documents::Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut2 {
            pub l0: MutCell<Documents::US1>,
        }
        impl core::fmt::Display for Documents::Mut2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut3 {
            pub l0: MutCell<Func1<string, ()>>,
        }
        impl core::fmt::Display for Documents::Mut3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US2 {
            US2_0(i64),
            US2_1,
        }
        impl Documents::US2 {
            pub fn get_IsUS2_0(this_: &MutCell<Documents::US2>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS2_1(this_: &MutCell<Documents::US2>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US3 {
            US3_0(i64),
            US3_1,
        }
        impl Documents::US3 {
            pub fn get_IsUS3_0(this_: &MutCell<Documents::US3>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS3_1(this_: &MutCell<Documents::US3>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US4 {
            US4_0(std::string::String),
            US4_1,
        }
        impl Documents::US4 {
            pub fn get_IsUS4_0(this_: &MutCell<Documents::US4>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS4_1(this_: &MutCell<Documents::US4>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US5 {
            US5_0,
            US5_1,
            US5_2,
        }
        impl Documents::US5 {
            pub fn get_IsUS5_0(this_: &MutCell<Documents::US5>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS5_1(this_: &MutCell<Documents::US5>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS5_2(this_: &MutCell<Documents::US5>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US6 {
            US6_0(std::fs::FileType),
            US6_1(std::string::String),
        }
        impl Documents::US6 {
            pub fn get_IsUS6_0(this_: &MutCell<Documents::US6>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS6_1(this_: &MutCell<Documents::US6>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US7 {
            US7_0(async_walkdir::DirEntry),
            US7_1(std::string::String),
        }
        impl Documents::US7 {
            pub fn get_IsUS7_0(this_: &MutCell<Documents::US7>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS7_1(this_: &MutCell<Documents::US7>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn method0() -> clap::Command {
            let v1_1: string = string("r#\"command\"#");
            let v2: &'static str = r#"command"#;
            let v4: clap::Command = clap::Command::new(v2);
            let v6: string = string("r#\"dir\"#");
            let v7: &'static str = r#"dir"#;
            let v9: clap::Arg = clap::Arg::new(v7);
            let v11: clap::Arg = v9.short('d');
            let v12: string = string("r#\"dir\"#");
            let v13: &'static str = r#"dir"#;
            let v15: clap::Arg = v11.long(v13);
            let v17: clap::Arg = v15.required(true);
            let v19: clap::Command = clap::Command::arg(v4, v17);
            let v21: string = string("r#\"hangul-spec\"#");
            let v22: &'static str = r#"hangul-spec"#;
            let v24: clap::Arg = clap::Arg::new(v22);
            let v26: clap::Arg = v24.short('s');
            let v27: string = string("r#\"hangul-spec\"#");
            let v28: &'static str = r#"hangul-spec"#;
            let v30: clap::Arg = v26.long(v28);
            let v32: clap::Arg = v30.required(true);
            clap::Command::arg(v19, v32)
        }
        pub fn closure0(unitVar: (), unitVar_1: ()) {
            let v1_1: bool = true;
            () //;
        } /* /*;
          {
              let v4: string = string("*/ #[test] fn verify_app() { //");
              let v5: bool = */
        #[test]
        fn verify_app() {
            //;
            let v6: clap::Command = Documents::method0();
            clap::Command::debug_assert(v6);
            {
                //;
                ()
            }
        }
        pub fn method1() -> string {
            string("polyglot")
        }
        pub fn method2() -> string {
            string(".paket")
        }
        pub fn method3() -> string {
            string("polyglot")
        }
        pub fn method4() -> string {
            string(".paket")
        }
        pub fn method6(v0_1: string) -> string {
            v0_1
        }
        pub fn method7(v0_1: string) -> string {
            v0_1
        }
        pub fn method8(v0_1: string) -> string {
            v0_1
        }
        pub fn closure2(unitVar: (), v0_1: string) -> Option<string> {
            let _v1: MutCell<Option<Documents::US0>> = MutCell::new(None::<Documents::US0>);
            let v3: string = Documents::method6(v0_1);
            let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
            let v7: std::string::String = String::from(v5);
            let v9: std::path::PathBuf = std::path::PathBuf::from(v7);
            let v11: Option<std::path::PathBuf> = v9.parent().map(std::path::PathBuf::from);
            let v13: std::path::PathBuf = v11?;
            let v15: std::string::String = v13.display().to_string();
            {
                let x: Documents::US0 =
                    Documents::US0::US0_0(fable_library_rust::String_::fromString(v15));
                _v1.set(Some(x))
            }
            {
                let v43: Documents::US0 = getValue(_v1.get().clone());
                match &v43 {
                    Documents::US0::US0_0(v43_0_0) => Some(match &v43 {
                        Documents::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<string>,
                }
            }
        }
        pub fn method9() -> Func1<string, Option<string>> {
            Func1::new(move |v: string| Documents::closure2((), v))
        }
        pub fn closure3(unitVar: (), v0_1: string) -> Documents::US0 {
            Documents::US0::US0_0(v0_1)
        }
        pub fn method10() -> Func1<string, Documents::US0> {
            Func1::new(move |v: string| Documents::closure3((), v))
        }
        pub fn method11(v0_1: string, v1_1: string, v2: string) -> string {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<string> = MutCell::new(v2.clone());
            '_method11: loop {
                break '_method11 ({
                    let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v5: string = Documents::method6(v2.get().clone());
                    let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
                    let v9: std::string::String = String::from(v7);
                    let v11: std::path::PathBuf = std::path::PathBuf::from(v9);
                    let v12: string = Documents::method6(v0_1.get().clone());
                    let v14: &str = fable_library_rust::String_::LrcStr::as_str(&v12);
                    let v16: std::string::String = String::from(v14);
                    let v18: std::path::PathBuf = v11.join(v16);
                    let v20: std::string::String = v18.display().to_string();
                    {
                        let x: string = fable_library_rust::String_::fromString(v20);
                        _v3.set(Some(x))
                    }
                    {
                        let _v34: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                        let v36: string = Documents::method6(getValue(_v3.get().clone()));
                        let v38: &str = fable_library_rust::String_::LrcStr::as_str(&v36);
                        let v40: std::string::String = String::from(v38);
                        let v42: std::path::PathBuf = std::path::PathBuf::from(v40);
                        {
                            let x_1: bool = if v42.clone().exists() {
                                v42.is_dir()
                            } else {
                                false
                            };
                            _v34.set(Some(x_1))
                        }
                        if getValue(_v34.get().clone()) {
                            v2.get().clone()
                        } else {
                            let v59: Option<string> = (Documents::method9())(v2.get().clone());
                            let v62: Documents::US0 = defaultValue(
                                Documents::US0::US0_1,
                                map(Documents::method10(), v59),
                            );
                            match &v62 {
                                Documents::US0::US0_0(v62_0_0) => {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_temp: string = match &v62 {
                                        Documents::US0::US0_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    continue '_method11;
                                }
                                _ => panic!(
                                    "{}",
                                    sprintf!(
                                        "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                                        string("dir"),
                                        v0_1.get().clone(),
                                        v1_1.get().clone(),
                                        v2.get().clone()
                                    ),
                                ),
                            }
                        }
                    }
                });
            }
        }
        pub fn method5(v0_1: string, v1_1: string) -> string {
            let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v4: string = Documents::method6(v1_1.clone());
            let v6: &str = fable_library_rust::String_::LrcStr::as_str(&v4);
            let v8: std::string::String = String::from(v6);
            let v10: std::path::PathBuf = std::path::PathBuf::from(v8);
            let v11: string = Documents::method6(v0_1.clone());
            let v13: &str = fable_library_rust::String_::LrcStr::as_str(&v11);
            let v15: std::string::String = String::from(v13);
            let v17: std::path::PathBuf = v10.join(v15);
            let v19: std::string::String = v17.display().to_string();
            {
                let x: string = fable_library_rust::String_::fromString(v19);
                _v2.set(Some(x))
            }
            {
                let _v33: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                let v35: string = Documents::method6(getValue(_v2.get().clone()));
                let v37: &str = fable_library_rust::String_::LrcStr::as_str(&v35);
                let v39: std::string::String = String::from(v37);
                let v41: std::path::PathBuf = std::path::PathBuf::from(v39);
                {
                    let x_1: bool = if v41.clone().exists() {
                        v41.is_dir()
                    } else {
                        false
                    };
                    _v33.set(Some(x_1))
                }
                if getValue(_v33.get().clone()) {
                    v1_1.clone()
                } else {
                    let v58: Option<string> = (Documents::method9())(v1_1.clone());
                    let v61: Documents::US0 =
                        defaultValue(Documents::US0::US0_1, map(Documents::method10(), v58));
                    match &v61 {
                        Documents::US0::US0_0(v61_0_0) => Documents::method11(
                            v0_1.clone(),
                            v1_1.clone(),
                            match &v61 {
                                Documents::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        ),
                        _ => panic!(
                            "{}",
                            sprintf!(
                                "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                                string("dir"),
                                v0_1.clone(),
                                v1_1.clone(),
                                v1_1.clone()
                            ),
                        ),
                    }
                }
            }
        }
        pub fn method12() -> string {
            string("polyglot")
        }
        pub fn closure4(unitVar: (), unitVar_1: ()) -> string {
            string("documents.main")
        }
        pub fn closure6(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn closure5(v0_1: Array<string>, v1_1: string, v2: string, unitVar: ()) -> string {
            sprintf!(
                "args: {} / current_dir: {} / repository_root: {} / {}",
                v0_1,
                v2,
                v1_1,
                Documents::closure6((), ())
            )
        }
        pub fn closure9(unitVar: (), v0_1: string) {
            ();
        }
        pub fn method14(v0_1: Option<i64>) -> Option<i64> {
            v0_1
        }
        pub fn method15(v0_1: Option<i64>) -> Option<i64> {
            v0_1
        }
        pub fn closure8(
            unitVar: (),
            unitVar_1: (),
        ) -> (
            LrcPtr<Documents::Mut0>,
            LrcPtr<Documents::Mut1>,
            LrcPtr<Documents::Mut2>,
            Option<i64>,
            LrcPtr<Documents::Mut3>,
        ) {
            let v0_1: LrcPtr<Documents::Mut1> = LrcPtr::new(Documents::Mut1 {
                l0: MutCell::new(true),
            });
            let v1_1: LrcPtr<Documents::Mut0> = LrcPtr::new(Documents::Mut0 {
                l0: MutCell::new(0_i64),
            });
            let v3: LrcPtr<Documents::Mut2> = LrcPtr::new(Documents::Mut2 {
                l0: MutCell::new(Documents::US1::US1_0),
            });
            let v5: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Func1::new(move |v: string| Documents::closure9((), v))),
            });
            let _v6: MutCell<Option<Option<i64>>> = MutCell::new(None::<Option<i64>>);
            {
                let x: Option<i64> = Documents::method15(None::<i64>);
                _v6.set(Some(x))
            }
            (v1_1, v0_1, v3, getValue(_v6.get().clone()), v5)
        }
        pub fn closure10(unitVar: (), v0_1: i64) -> Documents::US3 {
            Documents::US3::US3_0(v0_1)
        }
        pub fn method16() -> Func1<i64, Documents::US3> {
            Func1::new(move |v: i64| Documents::closure10((), v))
        }
        pub fn method17() -> string {
            string("")
        }
        pub fn closure7(
            v0_1: Documents::US1,
            v1_1: Func0<string>,
            v2: Func0<string>,
            unitVar: (),
        ) -> string {
            if Documents::State::trace_state().get().clone().is_none() {
                Documents::State::trace_state().set(Some(Documents::closure8((), ())));
            }
            {
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    Option<i64>,
                    LrcPtr<Documents::Mut3>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let _v9: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v13: Documents::US3 = defaultValue(
                    Documents::US3::US3_1,
                    map(Documents::method16(), patternInput.3.clone()),
                );
                let v31: DateTime = match &v13 {
                    Documents::US3::US3_0(v13_0_0) => {
                        let v19: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v13 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v19.hours(),
                            v19.minutes(),
                            v19.seconds(),
                            v19.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x: string = v31.toString(string("hh:mm:ss"));
                    _v9.set(Some(x))
                }
                {
                    let v61: string = getValue(_v9.get().clone());
                    let v62: i64 = (patternInput.0.clone()).l0.get().clone();
                    let v74: string = padRight(
                        toLower(match &v0_1 {
                            Documents::US1::US1_1 => string("Debug"),
                            Documents::US1::US1_2 => string("Info"),
                            Documents::US1::US1_0 => string("Verbose"),
                            Documents::US1::US1_3 => string("Warning"),
                            _ => string("Critical"),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v75: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v91: &str = match &v0_1 {
                        Documents::US1::US1_1 => inline_colorization::color_bright_blue,
                        Documents::US1::US1_2 => inline_colorization::color_bright_green,
                        Documents::US1::US1_0 => inline_colorization::color_bright_black,
                        Documents::US1::US1_3 => inline_colorization::color_bright_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v93: &str = fable_library_rust::String_::LrcStr::as_str(&v74);
                    let v95: &str = inline_colorization::color_reset;
                    let v97: string = string("format!(\"{v91}{v93}{v95}\")");
                    let v98: std::string::String = format!("{v91}{v93}{v95}");
                    {
                        let x_1: string = fable_library_rust::String_::fromString(v98);
                        _v75.set(Some(x_1))
                    }
                    trimEndChars(
                        trimStartChars(
                            sprintf!(
                                "{} {} #{} {} / {}",
                                v61,
                                getValue(_v75.get().clone()),
                                v62,
                                v1_1(),
                                v2()
                            ),
                            new_empty::<char>(),
                        ),
                        new_array(&[' ', '/']),
                    )
                }
            }
        }
        pub fn method18(v0_1: Documents::US1, v1_1: Func0<string>) {
            let v2 = Func0::new(move || Documents::closure8((), ()));
            if Documents::State::trace_state().get().clone().is_none() {
                Documents::State::trace_state().set(Some(v2()));
            }
            {
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    Option<i64>,
                    LrcPtr<Documents::Mut3>,
                ) = getValue(Documents::State::trace_state().get().clone());
                let v3: LrcPtr<Documents::Mut0> = patternInput.0.clone();
                if Documents::State::trace_state().get().clone().is_none() {
                    Documents::State::trace_state().set(Some(v2()));
                }
                {
                    let patternInput_1: (
                        LrcPtr<Documents::Mut0>,
                        LrcPtr<Documents::Mut1>,
                        LrcPtr<Documents::Mut2>,
                        Option<i64>,
                        LrcPtr<Documents::Mut3>,
                    ) = getValue(Documents::State::trace_state().get().clone());
                    let v13: Documents::US1 = (patternInput_1.2.clone()).l0.get().clone();
                    if if (patternInput_1.1.clone()).l0.get().clone() == false {
                        false
                    } else {
                        find(
                            v0_1,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Documents::US1::US1_0, 0_i32)),
                                LrcPtr::new((Documents::US1::US1_1, 1_i32)),
                                LrcPtr::new((Documents::US1::US1_2, 2_i32)),
                                LrcPtr::new((Documents::US1::US1_3, 3_i32)),
                                LrcPtr::new((Documents::US1::US1_4, 4_i32)),
                            ])))),
                        ) >= find(
                            v13,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Documents::US1::US1_0, 0_i32)),
                                LrcPtr::new((Documents::US1::US1_1, 1_i32)),
                                LrcPtr::new((Documents::US1::US1_2, 2_i32)),
                                LrcPtr::new((Documents::US1::US1_3, 3_i32)),
                                LrcPtr::new((Documents::US1::US1_4, 4_i32)),
                            ])))),
                        )
                    } {
                        let v21: i64 = v3.l0.get().clone() + 1_i64;
                        v3.l0.set(v21);
                        {
                            let v22: string = sprintf!("{}", v1_1());
                            let _v23: MutCell<Option<()>> = MutCell::new(None::<()>);
                            println!("{}", v22.clone());
                            _v23.set(Some(()));
                            getValue(_v23.get().clone());
                            ((patternInput.4.clone()).l0.get().clone())(v22)
                        }
                    }
                }
            }
        }
        pub fn method13(v0_1: Documents::US1, v1_1: Func0<string>, v2: Func0<string>) {
            Documents::method18(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure7(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method19() -> string {
            string("dir")
        }
        pub fn closure11(unitVar: (), v0_1: std::string::String) -> Documents::US4 {
            Documents::US4::US4_0(v0_1)
        }
        pub fn method20() -> Func1<std::string::String, Documents::US4> {
            Func1::new(move |v: std::string::String| Documents::closure11((), v))
        }
        pub fn method21() -> string {
            string("hangul-spec")
        }
        pub fn method23(v0_1: string) -> string {
            v0_1
        }
        pub fn closure12(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure13(v0_1: string, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "dir: {:?} / hangul_spec: {:?} / {}",
                v1_1,
                v0_1,
                Documents::closure6((), ())
            )
        }
        pub fn method26(v0_1: async_walkdir::DirEntry) -> async_walkdir::DirEntry {
            v0_1
        }
        pub fn closure15(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method27() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure15((), v))
        }
        pub fn closure16(unitVar: (), v0_1: std::fs::FileType) -> Documents::US6 {
            Documents::US6::US6_0(v0_1)
        }
        pub fn closure17(unitVar: (), v0_1: std::string::String) -> Documents::US6 {
            Documents::US6::US6_1(v0_1)
        }
        pub fn method28(v0_1: std::fs::FileType) -> std::fs::FileType {
            v0_1
        }
        pub fn method29(v0_1: Documents::US5) -> Documents::US5 {
            v0_1
        }
        pub fn method25(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Documents::US5> + Send>> {
            let __result = Box::pin(async move {
                //;
                {
                    let v2: async_walkdir::DirEntry = Documents::method26(v0_1.clone());
                    let v4: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                    Output = Result<std::fs::FileType, std::io::Error>,
                                > + Send,
                        >,
                    > = Box::pin(async_walkdir::DirEntry::file_type(&v2));
                    let v6: Result<std::fs::FileType, std::io::Error> = v4.await;
                    let v7 = Documents::method27();
                    let v9: Result<std::fs::FileType, std::string::String> = v6.map_err(|x| v7(x));
                    let v12: Documents::US6 = match &v9 {
                        Err(v9_1_0) => Documents::closure17((), v9_1_0.clone()),
                        Ok(v9_0_0) => Documents::closure16((), v9_0_0.clone()),
                    };
                    let v50: Documents::US5 =
                        Documents::method29(if let Documents::US6::US6_0(v12_0_0) = &v12 {
                            let v14: std::fs::FileType = Documents::method28(match &v12 {
                                Documents::US6::US6_0(x) => x.clone(),
                                _ => unreachable!(),
                            });
                            if std::fs::FileType::is_dir(&v14) {
                                Documents::US5::US5_0
                            } else {
                                let v19: std::path::PathBuf =
                                    async_walkdir::DirEntry::path(&v0_1.clone());
                                let v21: std::string::String = v19.display().to_string();
                                let v23: string = fable_library_rust::String_::fromString(v21);
                                if if endsWith(v23.clone(), string(".md"), false) == false {
                                    true
                                } else {
                                    endsWith(v23, string(".hangul.md"), false)
                                } {
                                    Documents::US5::US5_0
                                } else {
                                    Documents::US5::US5_2
                                }
                            }
                        } else {
                            let v35: std::path::PathBuf = async_walkdir::DirEntry::path(&v0_1);
                            let v37: std::string::String = v35.display().to_string();
                            let v39: string = fable_library_rust::String_::fromString(v37);
                            if if endsWith(v39.clone(), string(".md"), false) == false {
                                true
                            } else {
                                endsWith(v39, string(".hangul.md"), false)
                            } {
                                Documents::US5::US5_0
                            } else {
                                Documents::US5::US5_2
                            }
                        });
                    v50
                }
            });
            {
                //;
                __result
            }
        }
        pub fn method30(v0_1: async_walkdir::Filtering) -> async_walkdir::Filtering {
            v0_1
        }
        pub fn method24(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            let __result = Box::pin(async {
                //;
                {
                    let v2: std::pin::Pin<
                        Box<dyn std::future::Future<Output = Documents::US5> + Send>,
                    > = Documents::method25(v0_1);
                    let v4: Documents::US5 = v2.await;
                    let v14: async_walkdir::Filtering = Documents::method30(match &v4 {
                        Documents::US5::US5_0 => async_walkdir::Filtering::Ignore,
                        Documents::US5::US5_1 => async_walkdir::Filtering::IgnoreDir,
                        _ => async_walkdir::Filtering::Continue,
                    });
                    v14
                }
            });
            {
                //;
                __result
            }
        }
        pub fn closure14(
            unitVar: (),
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            Documents::method24(v0_1)
        }
        pub fn closure19(unitVar: (), v0_1: async_walkdir::DirEntry) -> Documents::US7 {
            Documents::US7::US7_0(v0_1)
        }
        pub fn closure20(unitVar: (), v0_1: std::string::String) -> Documents::US7 {
            Documents::US7::US7_1(v0_1)
        }
        pub fn closure21(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / stream_filter_map")
        }
        pub fn closure22(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("error: {} / {}", v0_1, Documents::closure6((), ()))
        }
        pub fn closure18(
            unitVar: (),
            v0_1: Result<async_walkdir::DirEntry, std::io::Error>,
        ) -> Option<std::string::String> {
            let v1_1 = Documents::method27();
            let v3: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v6: Documents::US7 = match &v3 {
                Err(v3_1_0) => Documents::closure20((), v3_1_0.clone()),
                Ok(v3_0_0) => Documents::closure19((), v3_0_0.clone()),
            };
            let v19: Documents::US4 = match &v6 {
                Documents::US7::US7_0(v6_0_0) => {
                    let v9: std::path::PathBuf = async_walkdir::DirEntry::path(&v6_0_0.clone());
                    Documents::US4::US4_0(v9.display().to_string())
                }
                Documents::US7::US7_1(v6_1_0) => {
                    Documents::method13(
                        Documents::US1::US1_4,
                        Func0::new(move || Documents::closure21((), ())),
                        Func0::new({
                            let v6 = v6.clone();
                            move || {
                                Documents::closure22(
                                    match &v6 {
                                        Documents::US7::US7_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    (),
                                )
                            }
                        }),
                    );
                    Documents::US4::US4_1
                }
            };
            match &v19 {
                Documents::US4::US4_0(v19_0_0) => Some(match &v19 {
                    Documents::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<std::string::String>,
            }
        }
        pub fn method31(
        ) -> Func1<Result<async_walkdir::DirEntry, std::io::Error>, Option<std::string::String>>
        {
            Func1::new(move |v: Result<async_walkdir::DirEntry, std::io::Error>| {
                Documents::closure18((), v)
            })
        }
        pub fn closure23(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure24(v0_1: Vec<std::string::String>, unitVar: ()) -> string {
            sprintf!(
                "files_len: {} / {}",
                v0_1.len(),
                Documents::closure6((), ())
            )
        }
        pub fn closure26(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / vec_map")
        }
        pub fn closure27(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("file: {} / {}", v0_1, Documents::closure6((), ()))
        }
        pub fn closure25(
            unitVar: (),
            v0_1: std::string::String,
        ) -> Result<std::string::String, std::string::String> {
            Documents::method13(
                Documents::US1::US1_0,
                Func0::new(move || Documents::closure26((), ())),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    move || Documents::closure27(v0_1.clone(), ())
                }),
            );
            Ok::<std::string::String, std::string::String>(v0_1.clone())
        }
        pub fn closure28(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure29(
            v0_1: Vec<Result<std::string::String, std::string::String>>,
            unitVar: (),
        ) -> string {
            sprintf!(
                "result: {} / {}",
                format!("{:#?}", v0_1),
                Documents::closure6((), ())
            )
        }
        pub fn method32(v0_1: Result<(), std::string::String>) -> Result<(), std::string::String> {
            v0_1
        }
        pub fn method22(
            v0_1: string,
            v1_1: string,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<(), std::string::String>>>>
        {
            let __result = Box::pin(async move {
                //;
                {
                    let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v6: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::canonicalize(&*v1_1);
                    let v8: std::path::PathBuf = v6.unwrap();
                    let v10: std::string::String = v8.display().to_string();
                    {
                        let x: string = fable_library_rust::String_::fromString(v10);
                        _v3.set(Some(x))
                    }
                    {
                        let v20: string = getValue(_v3.get().clone());
                        Documents::method13(
                            Documents::US1::US1_0,
                            Func0::new(move || Documents::closure12((), ())),
                            Func0::new({
                                let v0_1 = v0_1.clone();
                                let v20 = v20.clone();
                                move || Documents::closure13(v0_1.clone(), v20.clone(), ())
                            }),
                        );
                        {
                            let v25: async_walkdir::WalkDir =
                                async_walkdir::WalkDir::new(&*v20.clone());
                            let v28: async_walkdir::WalkDir =
                                async_walkdir::WalkDir::filter(v25, |x| {
                                    Func1::new(move |v: async_walkdir::DirEntry| {
                                        Documents::closure14((), v)
                                    })(x)
                                });
                            let v29 = Documents::method31();
                            let v30: string =
                            string("futures_lite::stream::StreamExt::collect(futures_lite::stream::StreamExt::filter_map(v28, |x| v29(x))).await");
                            let v31: Vec<std::string::String> =
                                futures_lite::stream::StreamExt::collect(
                                    futures_lite::stream::StreamExt::filter_map(v28, |x| v29(x)),
                                )
                                .await;
                            Documents::method13(
                                Documents::US1::US1_0,
                                Func0::new(move || Documents::closure23((), ())),
                                Func0::new({
                                    let v31 = v31.clone();
                                    move || Documents::closure24(v31.clone(), ())
                                }),
                            );
                            {
                                let v36: rayon::vec::IntoIter<std::string::String> =
                                    rayon::iter::IntoParallelIterator::into_par_iter(v31);
                                let v39: rayon::iter::Map<
                                    rayon::vec::IntoIter<std::string::String>,
                                    _,
                                > = rayon::iter::ParallelIterator::map(v36, |x| {
                                    Func1::new(move |v_1: std::string::String| {
                                        Documents::closure25((), v_1)
                                    })(x)
                                });
                                let v41: Vec<Result<std::string::String, std::string::String>> =
                                    rayon::iter::ParallelIterator::collect(v39);
                                Documents::method13(
                                    Documents::US1::US1_0,
                                    Func0::new(move || Documents::closure28((), ())),
                                    Func0::new({
                                        let v41 = v41.clone();
                                        move || Documents::closure29(v41.clone(), ())
                                    }),
                                );
                                {
                                    let v46: Result<(), std::string::String> =
                                        Documents::method32(Ok::<(), std::string::String>(()));
                                    v46
                                }
                            }
                        }
                    }
                }
            });
            {
                {
                    {
                        {
                            {
                                //;
                                __result
                            }
                        }
                    }
                }
            }
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
            let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v4: string = Documents::method1();
            let v6: &str = fable_library_rust::String_::LrcStr::as_str(&v4);
            let v8: std::string::String = String::from(v6);
            let v10: std::path::PathBuf = std::path::PathBuf::from(v8);
            let v11: string = Documents::method2();
            let v13: &str = fable_library_rust::String_::LrcStr::as_str(&v11);
            let v15: std::string::String = String::from(v13);
            let v17: std::path::PathBuf = v10.join(v15);
            let v19: std::string::String = v17.display().to_string();
            {
                let x: string = fable_library_rust::String_::fromString(v19);
                _v2.set(Some(x))
            }
            {
                let _v36: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v38: string = Documents::method6(Documents::method5(
                    getValue(_v2.get().clone()),
                    string("C:\\home\\git\\polyglot\\target\\polyglot\\builder\\documents"),
                ));
                let v40: &str = fable_library_rust::String_::LrcStr::as_str(&v38);
                let v42: std::string::String = String::from(v40);
                let v44: std::path::PathBuf = std::path::PathBuf::from(v42);
                let v45: string = Documents::method1();
                let v47: &str = fable_library_rust::String_::LrcStr::as_str(&v45);
                let v49: std::string::String = String::from(v47);
                let v51: std::path::PathBuf = v44.join(v49);
                let v53: std::string::String = v51.display().to_string();
                {
                    let x_1: string = fable_library_rust::String_::fromString(v53);
                    _v36.set(Some(x_1))
                }
                {
                    let v65: string = getValue(_v36.get().clone());
                    let _v66: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v69: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
                    let v71: std::path::PathBuf = v69.unwrap();
                    let v73: std::string::String = v71.display().to_string();
                    {
                        let x_2: string = fable_library_rust::String_::fromString(v73);
                        _v66.set(Some(x_2))
                    }
                    {
                        let v82: string = getValue(_v66.get().clone());
                        Documents::method13(
                            Documents::US1::US1_2,
                            Func0::new(move || Documents::closure4((), ())),
                            Func0::new({
                                let v0_1 = v0_1.clone();
                                let v65 = v65.clone();
                                let v82 = v82.clone();
                                move || {
                                    Documents::closure5(v0_1.clone(), v65.clone(), v82.clone(), ())
                                }
                            }),
                        );
                        {
                            let v86: clap::Command = Documents::method0();
                            let v88: clap::ArgMatches = clap::Command::get_matches(v86);
                            let v89: string = Documents::method19();
                            let v91: &str = fable_library_rust::String_::LrcStr::as_str(&v89);
                            let v93: Option<std::string::String> =
                                clap::ArgMatches::get_one(&v88, v91).cloned();
                            let v96: Documents::US4 = defaultValue(
                                Documents::US4::US4_1,
                                map(Documents::method20(), v93),
                            );
                            let v100: std::string::String = match &v96 {
                                Documents::US4::US4_0(v96_0_0) => match &v96 {
                                    Documents::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            };
                            let v102: string = fable_library_rust::String_::fromString(v100);
                            let v103: string = Documents::method21();
                            let v105: &str = fable_library_rust::String_::LrcStr::as_str(&v103);
                            let v107: Option<std::string::String> =
                                clap::ArgMatches::get_one(&v88, v105).cloned();
                            let v110: Documents::US4 = defaultValue(
                                Documents::US4::US4_1,
                                map(Documents::method20(), v107),
                            );
                            let v114: std::string::String = match &v110 {
                                Documents::US4::US4_0(v110_0_0) => match &v110 {
                                    Documents::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            };
                            let v117: std::pin::Pin<
                                Box<
                                    dyn std::future::Future<
                                        Output = Result<(), std::string::String>,
                                    >,
                                >,
                            > = Documents::method22(
                                fable_library_rust::String_::fromString(v114),
                                v102,
                            );
                            let v119: Result<(), std::string::String> =
                                futures_lite::future::block_on(v117);
                            v119.unwrap();
                            0_i32
                        }
                    }
                }
            }
        }
        pub fn v0() -> Func0<()> {
            static v0: OnceInit<Func0<()>> = OnceInit::new();
            v0.get_or_init(|| Func0::new(move || Documents::closure0((), ())))
                .clone()
        }
        pub fn tests() {
            (Documents::v0())();
        }
        pub fn v1() -> Func1<Array<string>, i32> {
            static v1: OnceInit<Func1<Array<string>, i32>> = OnceInit::new();
            v1.get_or_init(|| Func1::new(move |v: Array<string>| Documents::closure1((), v)))
                .clone()
        }
        pub fn main(args: Array<string>) -> i32 {
            (Documents::v1())(args)
        }
    }
}
pub use module_2555ccf7::*;
#[path = "../../../polyglot/lib/fsharp/Common.rs"]
mod module_8cb3e09e;
pub use module_8cb3e09e::*;
#[path = "../../../polyglot/lib/spiral/async_.rs"]
mod module_62d8b4ed;
pub use module_62d8b4ed::*;
#[path = "../../../polyglot/lib/spiral/common.rs"]
mod module_e7e93d99;
pub use module_e7e93d99::*;
#[path = "../../../polyglot/lib/spiral/crypto.rs"]
mod module_981523f7;
pub use module_981523f7::*;
#[path = "../../../polyglot/lib/spiral/date_time.rs"]
mod module_d18105aa;
pub use module_d18105aa::*;
#[path = "../../../polyglot/lib/spiral/file_system.rs"]
mod module_c5eb79e8;
pub use module_c5eb79e8::*;
#[path = "../../../polyglot/lib/spiral/lib.rs"]
mod module_8d8b0653;
pub use module_8d8b0653::*;
#[path = "../../../polyglot/lib/spiral/networking.rs"]
mod module_2612ff6a;
pub use module_2612ff6a::*;
#[path = "../../../polyglot/lib/spiral/runtime.rs"]
mod module_3a43928;
pub use module_3a43928::*;
#[path = "../../../polyglot/lib/spiral/sm.rs"]
mod module_2aeb754a;
pub use module_2aeb754a::*;
#[path = "../../../polyglot/lib/spiral/threading.rs"]
mod module_444ab8da;
pub use module_444ab8da::*;
#[path = "../../../polyglot/lib/spiral/trace.rs"]
mod module_e61b6515;
pub use module_e61b6515::*;
pub mod Polyglot {
    pub use crate::module_8cb3e09e::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Documents::main(array_from(args));
}
