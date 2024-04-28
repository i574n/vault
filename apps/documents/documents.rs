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
        use fable_library_rust::Async_::Async;
        use fable_library_rust::DateTime_::DateTime;
        use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::List_::cons;
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::foldBack;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::toArray;
        use fable_library_rust::List_::List;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_empty;
        use fable_library_rust::NativeArray_::new_init;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::defaultOf;
        use fable_library_rust::Native_::unbox;
        use fable_library_rust::Native_::Arc;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::Func2;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::getValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::String_::contains;
        use fable_library_rust::String_::endsWith;
        use fable_library_rust::String_::getCharAt;
        use fable_library_rust::String_::getSlice;
        use fable_library_rust::String_::length;
        use fable_library_rust::String_::padRight;
        use fable_library_rust::String_::replace;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toLower;
        use fable_library_rust::String_::toLowerChar;
        use fable_library_rust::String_::trimEndChars;
        use fable_library_rust::String_::trimStartChars;
        use fable_library_rust::TimeSpan_::TimeSpan;
        type ConcurrentStack_1<T> = T;
        type CancellationToken = ();
        type TaskCanceledException = ();
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US0 {
            US0_0,
            US0_1,
            US0_2,
            US0_3,
            US0_4,
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
            pub fn get_IsUS0_2(this_: &MutCell<Documents::US0>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS0_3(this_: &MutCell<Documents::US0>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS0_4(this_: &MutCell<Documents::US0>, unitArg: ()) -> bool {
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut2 {
            pub l0: MutCell<Documents::US0>,
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
        pub enum US1 {
            US1_0(i64),
            US1_1,
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
        }
        impl core::fmt::Display for Documents::US1 {
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
        #[derive(Clone, Debug)]
        pub enum US3 {
            US3_0(std::string::String),
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US4 {
            US4_0,
            US4_1,
            US4_2,
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
            pub fn get_IsUS4_2(this_: &MutCell<Documents::US4>, unitArg: ()) -> bool {
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
        #[derive(Clone, Debug)]
        pub enum US5 {
            US5_0(std::fs::FileType),
            US5_1(std::string::String),
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
        }
        impl core::fmt::Display for Documents::US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US6 {
            US6_0(async_walkdir::DirEntry),
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US7 {
            US7_0(string),
            US7_1,
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US9 {
            US9_0(string),
            US9_1(string, string),
        }
        impl Documents::US9 {
            pub fn get_IsUS9_0(this_: &MutCell<Documents::US9>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS9_1(this_: &MutCell<Documents::US9>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US8 {
            US8_0(Documents::US9),
            US8_1,
        }
        impl Documents::US8 {
            pub fn get_IsUS8_0(this_: &MutCell<Documents::US8>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS8_1(this_: &MutCell<Documents::US8>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut4 {
            pub l0: MutCell<i32>,
        }
        impl core::fmt::Display for Documents::Mut4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum UH0 {
            UH0_0,
            UH0_1(char, LrcPtr<Documents::UH0>),
        }
        impl Documents::UH0 {
            pub fn get_IsUH0_0(this_: LrcPtr<Documents::UH0>, unitArg: ()) -> bool {
                if let Documents::UH0::UH0_0 = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUH0_1(this_: LrcPtr<Documents::UH0>, unitArg: ()) -> bool {
                if let Documents::UH0::UH0_1(this__1_0, this__1_1) = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::UH0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US11 {
            US11_0,
            US11_1,
        }
        impl Documents::US11 {
            pub fn get_IsUS11_0(this_: &MutCell<Documents::US11>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS11_1(this_: &MutCell<Documents::US11>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US11 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US10 {
            US10_0,
            US10_1(Documents::US11),
            US10_2,
        }
        impl Documents::US10 {
            pub fn get_IsUS10_0(this_: &MutCell<Documents::US10>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS10_1(this_: &MutCell<Documents::US10>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS10_2(this_: &MutCell<Documents::US10>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum UH1 {
            UH1_0,
            UH1_1(string, LrcPtr<Documents::UH1>),
        }
        impl Documents::UH1 {
            pub fn get_IsUH1_0(this_: LrcPtr<Documents::UH1>, unitArg: ()) -> bool {
                if let Documents::UH1::UH1_0 = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUH1_1(this_: LrcPtr<Documents::UH1>, unitArg: ()) -> bool {
                if let Documents::UH1::UH1_1(this__1_0, this__1_1) = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US12 {
            US12_0,
            US12_1(char),
            US12_2(u8),
        }
        impl Documents::US12 {
            pub fn get_IsUS12_0(this_: &MutCell<Documents::US12>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS12_1(this_: &MutCell<Documents::US12>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS12_2(this_: &MutCell<Documents::US12>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US12 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US13 {
            US13_0(std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>),
            US13_1(std::string::String),
        }
        impl Documents::US13 {
            pub fn get_IsUS13_0(this_: &MutCell<Documents::US13>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS13_1(this_: &MutCell<Documents::US13>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US13 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US14 {
            US14_0(
                std::sync::Arc<
                    std::sync::Mutex<
                        std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                    >,
                >,
            ),
            US14_1,
        }
        impl Documents::US14 {
            pub fn get_IsUS14_0(this_: &MutCell<Documents::US14>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS14_1(this_: &MutCell<Documents::US14>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US14 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US15 {
            US15_0(std::string::String),
            US15_1(std::string::String),
        }
        impl Documents::US15 {
            pub fn get_IsUS15_0(this_: &MutCell<Documents::US15>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS15_1(this_: &MutCell<Documents::US15>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US15 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US16 {
            US16_0(std::process::Output),
            US16_1(std::string::String),
        }
        impl Documents::US16 {
            pub fn get_IsUS16_0(this_: &MutCell<Documents::US16>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS16_1(this_: &MutCell<Documents::US16>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US16 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US17 {
            US17_0(Func1<(bool, string, i32), Arc<Async<()>>>),
            US17_1,
        }
        impl Documents::US17 {
            pub fn get_IsUS17_0(this_: &MutCell<Documents::US17>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS17_1(this_: &MutCell<Documents::US17>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US17 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US18 {
            US18_0(CancellationToken),
            US18_1,
        }
        impl Documents::US18 {
            pub fn get_IsUS18_0(this_: &MutCell<Documents::US18>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS18_1(this_: &MutCell<Documents::US18>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Documents::US18 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn method0() -> clap::Command {
            let v1_1: string = string("r#\"command\"#");
            let v2: &'static str = r#"command"#;
            let v4: clap::Command = clap::Command::new(v2);
            let v6: string = string("r#\"source-dir\"#");
            let v7: &'static str = r#"source-dir"#;
            let v9: clap::Arg = clap::Arg::new(v7);
            let v11: clap::Arg = v9.short('s');
            let v12: string = string("r#\"source-dir\"#");
            let v13: &'static str = r#"source-dir"#;
            let v15: clap::Arg = v11.long(v13);
            let v17: clap::Arg = v15.required(true);
            let v19: clap::Command = clap::Command::arg(v4, v17);
            let v21: string = string("r#\"dist-dir\"#");
            let v22: &'static str = r#"dist-dir"#;
            let v24: clap::Arg = clap::Arg::new(v22);
            let v26: clap::Arg = v24.short('d');
            let v27: string = string("r#\"dist-dir\"#");
            let v28: &'static str = r#"dist-dir"#;
            let v30: clap::Arg = v26.long(v28);
            let v32: clap::Arg = v30.required(true);
            let v34: clap::Command = clap::Command::arg(v19, v32);
            let v36: string = string("r#\"cache-dir\"#");
            let v37: &'static str = r#"cache-dir"#;
            let v39: clap::Arg = clap::Arg::new(v37);
            let v41: clap::Arg = v39.short('c');
            let v42: string = string("r#\"cache-dir\"#");
            let v43: &'static str = r#"cache-dir"#;
            let v45: clap::Arg = v41.long(v43);
            let v47: clap::Arg = v45.required(true);
            let v49: clap::Command = clap::Command::arg(v34, v47);
            let v51: string = string("r#\"hangul-spec\"#");
            let v52: &'static str = r#"hangul-spec"#;
            let v54: clap::Arg = clap::Arg::new(v52);
            let v56: clap::Arg = v54.short('s');
            let v57: string = string("r#\"hangul-spec\"#");
            let v58: &'static str = r#"hangul-spec"#;
            let v60: clap::Arg = v56.long(v58);
            let v62: clap::Arg = v60.required(true);
            clap::Command::arg(v49, v62)
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
        pub fn closure3(unitVar: (), v0_1: string) {
            ();
        }
        pub fn method1(v0_1: Option<i64>) -> Option<i64> {
            v0_1
        }
        pub fn method2(v0_1: Option<i64>) -> Option<i64> {
            v0_1
        }
        pub fn closure2(
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
                l0: MutCell::new(Documents::US0::US0_0),
            });
            let v5: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Func1::new(move |v: string| Documents::closure3((), v))),
            });
            let _v6: MutCell<Option<Option<i64>>> = MutCell::new(None::<Option<i64>>);
            {
                let x: Option<i64> = Documents::method2(None::<i64>);
                _v6.set(Some(x))
            }
            (v1_1, v0_1, v3, getValue(_v6.get().clone()), v5)
        }
        pub fn closure4(unitVar: (), unitVar_1: ()) -> string {
            string("documents.main")
        }
        pub fn closure6(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn closure5(v0_1: Array<string>, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "args: {} / current_dir: {} / {}",
                v0_1,
                v1_1,
                Documents::closure6((), ())
            )
        }
        pub fn closure8(unitVar: (), v0_1: i64) -> Documents::US2 {
            Documents::US2::US2_0(v0_1)
        }
        pub fn method4() -> Func1<i64, Documents::US2> {
            Func1::new(move |v: i64| Documents::closure8((), v))
        }
        pub fn method5() -> string {
            string("")
        }
        pub fn closure7(
            v0_1: Documents::US0,
            v1_1: Func0<string>,
            v2: Func0<string>,
            unitVar: (),
        ) -> string {
            if Documents::State::trace_state().get().clone().is_none() {
                Documents::State::trace_state().set(Some(Documents::closure2((), ())));
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
                let v13: Documents::US2 = defaultValue(
                    Documents::US2::US2_1,
                    map(Documents::method4(), patternInput.3.clone()),
                );
                let v31: DateTime = match &v13 {
                    Documents::US2::US2_0(v13_0_0) => {
                        let v19: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v13 {
                                Documents::US2::US2_0(x) => x.clone(),
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
                            Documents::US0::US0_1 => string("Debug"),
                            Documents::US0::US0_2 => string("Info"),
                            Documents::US0::US0_0 => string("Verbose"),
                            Documents::US0::US0_3 => string("Warning"),
                            _ => string("Critical"),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v75: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v91: &str = match &v0_1 {
                        Documents::US0::US0_1 => inline_colorization::color_bright_blue,
                        Documents::US0::US0_2 => inline_colorization::color_bright_green,
                        Documents::US0::US0_0 => inline_colorization::color_bright_black,
                        Documents::US0::US0_3 => inline_colorization::color_bright_yellow,
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
        pub fn method6(v0_1: Documents::US0, v1_1: Func0<string>) {
            let v2 = Func0::new(move || Documents::closure2((), ()));
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
                    let v13: Documents::US0 = (patternInput_1.2.clone()).l0.get().clone();
                    if if (patternInput_1.1.clone()).l0.get().clone() == false {
                        false
                    } else {
                        find(
                            v0_1,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                                LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                                LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                                LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                                LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                            ])))),
                        ) >= find(
                            v13,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                                LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                                LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                                LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                                LrcPtr::new((Documents::US0::US0_4, 4_i32)),
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
        pub fn method3(v0_1: Documents::US0, v1_1: Func0<string>, v2: Func0<string>) {
            Documents::method6(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Documents::closure7(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method7() -> string {
            string("source-dir")
        }
        pub fn closure9(unitVar: (), v0_1: std::string::String) -> Documents::US3 {
            Documents::US3::US3_0(v0_1)
        }
        pub fn method8() -> Func1<std::string::String, Documents::US3> {
            Func1::new(move |v: std::string::String| Documents::closure9((), v))
        }
        pub fn method9() -> string {
            string("dist-dir")
        }
        pub fn method10() -> string {
            string("cache-dir")
        }
        pub fn method11() -> string {
            string("hangul-spec")
        }
        pub fn method12(v0_1: string) -> string {
            v0_1
        }
        pub fn method13(v0_1: string) -> string {
            v0_1
        }
        pub fn method14(v0_1: string) -> string {
            v0_1
        }
        pub fn method15(v0_1: string) -> string {
            v0_1
        }
        pub fn method16(v0_1: string) -> string {
            v0_1
        }
        pub fn closure10(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure11(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            unitVar: (),
        ) -> string {
            sprintf!(
                "source_dir: {} / dist_dir: {} / cache_dir: {} / hangul_spec: {:?} / {}",
                v1_1,
                v2,
                v3,
                v0_1,
                Documents::closure6((), ())
            )
        }
        pub fn method20(v0_1: async_walkdir::DirEntry) -> async_walkdir::DirEntry {
            v0_1
        }
        pub fn closure13(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            let _v1: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v1.set(Some(x))
            }
            getValue(_v1.get().clone())
        }
        pub fn method21() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure13((), v))
        }
        pub fn closure14(unitVar: (), v0_1: std::fs::FileType) -> Documents::US5 {
            Documents::US5::US5_0(v0_1)
        }
        pub fn closure15(unitVar: (), v0_1: std::string::String) -> Documents::US5 {
            Documents::US5::US5_1(v0_1)
        }
        pub fn method22(v0_1: std::fs::FileType) -> std::fs::FileType {
            v0_1
        }
        pub fn method23(v0_1: Documents::US4) -> Documents::US4 {
            v0_1
        }
        pub fn method19(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Documents::US4> + Send>> {
            let __result = Box::pin(async move {
                //;
                {
                    let v2: async_walkdir::DirEntry = Documents::method20(v0_1.clone());
                    let v4: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                    Output = Result<std::fs::FileType, std::io::Error>,
                                > + Send,
                        >,
                    > = Box::pin(async_walkdir::DirEntry::file_type(&v2));
                    let v6: Result<std::fs::FileType, std::io::Error> = v4.await;
                    let v7 = Documents::method21();
                    let v9: Result<std::fs::FileType, std::string::String> = v6.map_err(|x| v7(x));
                    let v12: Documents::US5 = match &v9 {
                        Err(v9_1_0) => Documents::closure15((), v9_1_0.clone()),
                        Ok(v9_0_0) => Documents::closure14((), v9_0_0.clone()),
                    };
                    let v74: Documents::US4 =
                        Documents::method23(if let Documents::US5::US5_0(v12_0_0) = &v12 {
                            let v14: std::fs::FileType = Documents::method22(match &v12 {
                                Documents::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            });
                            if std::fs::FileType::is_dir(&v14) {
                                Documents::US4::US4_0
                            } else {
                                let v19: std::path::PathBuf =
                                    async_walkdir::DirEntry::path(&v0_1.clone());
                                let v21: std::path::Display = v19.display();
                                let _v22: MutCell<Option<std::string::String>> =
                                    MutCell::new(None::<std::string::String>);
                                {
                                    let x_2: std::string::String = format!("{}", v21);
                                    _v22.set(Some(x_2))
                                }
                                {
                                    let v33: std::string::String = getValue(_v22.get().clone());
                                    let v35: string = fable_library_rust::String_::fromString(v33);
                                    if if endsWith(v35.clone(), string(".md"), false) == false {
                                        true
                                    } else {
                                        endsWith(v35, string(".hangul.md"), false)
                                    } {
                                        Documents::US4::US4_0
                                    } else {
                                        Documents::US4::US4_2
                                    }
                                }
                            }
                        } else {
                            let v47: std::path::PathBuf = async_walkdir::DirEntry::path(&v0_1);
                            let v49: std::path::Display = v47.display();
                            let _v50: MutCell<Option<std::string::String>> =
                                MutCell::new(None::<std::string::String>);
                            {
                                let x_3: std::string::String = format!("{}", v49);
                                _v50.set(Some(x_3))
                            }
                            {
                                let v61: std::string::String = getValue(_v50.get().clone());
                                let v63: string = fable_library_rust::String_::fromString(v61);
                                if if endsWith(v63.clone(), string(".md"), false) == false {
                                    true
                                } else {
                                    endsWith(v63, string(".hangul.md"), false)
                                } {
                                    Documents::US4::US4_0
                                } else {
                                    Documents::US4::US4_2
                                }
                            }
                        });
                    v74
                }
            });
            {
                //;
                __result
            }
        }
        pub fn method24(v0_1: async_walkdir::Filtering) -> async_walkdir::Filtering {
            v0_1
        }
        pub fn method18(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            let __result = Box::pin(async {
                //;
                {
                    let v2: std::pin::Pin<
                        Box<dyn std::future::Future<Output = Documents::US4> + Send>,
                    > = Documents::method19(v0_1);
                    let v4: Documents::US4 = v2.await;
                    let v14: async_walkdir::Filtering = Documents::method24(match &v4 {
                        Documents::US4::US4_0 => async_walkdir::Filtering::Ignore,
                        Documents::US4::US4_1 => async_walkdir::Filtering::IgnoreDir,
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
        pub fn closure12(
            unitVar: (),
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            Documents::method18(v0_1)
        }
        pub fn closure17(unitVar: (), v0_1: async_walkdir::DirEntry) -> Documents::US6 {
            Documents::US6::US6_0(v0_1)
        }
        pub fn closure18(unitVar: (), v0_1: std::string::String) -> Documents::US6 {
            Documents::US6::US6_1(v0_1)
        }
        pub fn closure19(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / stream_filter_map")
        }
        pub fn closure20(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("error: {} / {}", v0_1, Documents::closure6((), ()))
        }
        pub fn closure16(
            unitVar: (),
            v0_1: Result<async_walkdir::DirEntry, std::io::Error>,
        ) -> Option<string> {
            let v1_1 = Documents::method21();
            let v3: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v6: Documents::US6 = match &v3 {
                Err(v3_1_0) => Documents::closure18((), v3_1_0.clone()),
                Ok(v3_0_0) => Documents::closure17((), v3_0_0.clone()),
            };
            let v33: Documents::US7 = match &v6 {
                Documents::US6::US6_0(v6_0_0) => {
                    let v9: std::path::PathBuf = async_walkdir::DirEntry::path(&v6_0_0.clone());
                    let v11: std::path::Display = v9.display();
                    let _v12: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_2: std::string::String = format!("{}", v11);
                        _v12.set(Some(x_2))
                    }
                    {
                        let v23: std::string::String = getValue(_v12.get().clone());
                        Documents::US7::US7_0(fable_library_rust::String_::fromString(v23))
                    }
                }
                Documents::US6::US6_1(v6_1_0) => {
                    Documents::method3(
                        Documents::US0::US0_4,
                        Func0::new(move || Documents::closure19((), ())),
                        Func0::new({
                            let v6 = v6.clone();
                            move || {
                                Documents::closure20(
                                    match &v6 {
                                        Documents::US6::US6_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    (),
                                )
                            }
                        }),
                    );
                    Documents::US7::US7_1
                }
            };
            match &v33 {
                Documents::US7::US7_0(v33_0_0) => Some(match &v33 {
                    Documents::US7::US7_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<string>,
            }
        }
        pub fn method25() -> Func1<Result<async_walkdir::DirEntry, std::io::Error>, Option<string>>
        {
            Func1::new(move |v: Result<async_walkdir::DirEntry, std::io::Error>| {
                Documents::closure16((), v)
            })
        }
        pub fn closure21(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure22(v0_1: Vec<string>, unitVar: ()) -> string {
            sprintf!(
                "files_len: {} / {}",
                v0_1.len(),
                Documents::closure6((), ())
            )
        }
        pub fn method26() -> string {
            string("^\\\\\\\\\\?\\\\")
        }
        pub fn method27(v0_1: string) -> string {
            v0_1
        }
        pub fn method28() -> string {
            string("")
        }
        pub fn method29() -> (string, string) {
            (string(""), string(""))
        }
        pub fn method30(v0_1: i32, v1_1: LrcPtr<Documents::Mut4>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn closure25(v0_1: char, v1_1: LrcPtr<Documents::UH0>) -> LrcPtr<Documents::UH0> {
            LrcPtr::new(Documents::UH0::UH0_1(v0_1, v1_1))
        }
        pub fn closure24(
            unitVar: (),
            v0_1: char,
        ) -> Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Documents::UH0>| Documents::closure25(v0_1, v)
            })
        }
        pub fn method31() -> Func1<char, Func1<LrcPtr<Documents::UH0>, LrcPtr<Documents::UH0>>> {
            Func1::new(move |v: char| Documents::closure24((), v))
        }
        pub fn method32(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<Documents::UH0>,
            v3: Documents::US10,
        ) -> (string, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v2.clone());
            let v3: MutCell<Documents::US10> = MutCell::new(v3.clone());
            '_method32: loop {
                break '_method32 (if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) =
                    v2.get().clone().as_ref()
                {
                    let v5: LrcPtr<Documents::UH0> = match v2.get().clone().as_ref() {
                        Documents::UH0::UH0_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v4: char = match v2.get().clone().as_ref() {
                        Documents::UH0::UH0_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if '\"' == v4 {
                        if v1_1.get().clone() == string("") {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                            let v3_temp: Documents::US10 =
                                Documents::US10::US10_1(Documents::US11::US11_0);
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            continue '_method32;
                        } else {
                            match &v3.get().clone() {
                                Documents::US10::US10_1(v3_1_0) => {
                                    if let Documents::US11::US11_0 = v3_1_0 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                        let v3_temp: Documents::US10 =
                                            Documents::US10::US10_1(Documents::US11::US11_1);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method32;
                                    } else {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US10 = Documents::US10::US10_2;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method32;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US10 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method32;
                                        }
                                    }
                                }
                                Documents::US10::US10_0 => {
                                    if ' ' == v4 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                        let v3_temp: Documents::US10 = Documents::US10::US10_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method32;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4);
                                        let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                        let v3_temp: Documents::US10 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method32;
                                    }
                                }
                                _ => {
                                    let v0_1_temp: string =
                                        sprintf!("{}{}", v0_1.get().clone(), v4);
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                    let v3_temp: Documents::US10 = Documents::US10::US10_2;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    continue '_method32;
                                }
                            }
                        }
                    } else {
                        if '\'' == v4 {
                            if v1_1.get().clone() == string("") {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                let v3_temp: Documents::US10 =
                                    Documents::US10::US10_1(Documents::US11::US11_0);
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                continue '_method32;
                            } else {
                                match &v3.get().clone() {
                                    Documents::US10::US10_1(v3_1_0) => {
                                        if let Documents::US11::US11_0 = v3_1_0 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US10 =
                                                Documents::US10::US10_1(Documents::US11::US11_1);
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method32;
                                        } else {
                                            if ' ' == v4 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: string = v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                                let v3_temp: Documents::US10 =
                                                    Documents::US10::US10_2;
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method32;
                                            } else {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: string =
                                                    sprintf!("{}{}", v1_1.get().clone(), v4);
                                                let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                                let v3_temp: Documents::US10 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method32;
                                            }
                                        }
                                    }
                                    Documents::US10::US10_0 => {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US10 = Documents::US10::US10_2;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method32;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US10 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method32;
                                        }
                                    }
                                    _ => {
                                        let v0_1_temp: string =
                                            sprintf!("{}{}", v0_1.get().clone(), v4);
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                        let v3_temp: Documents::US10 = Documents::US10::US10_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method32;
                                    }
                                }
                            }
                        } else {
                            match &v3.get().clone() {
                                Documents::US10::US10_1(v3_1_0) => {
                                    if let Documents::US11::US11_0 = v3_1_0 {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{} ", v1_1.get().clone());
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US10 =
                                                Documents::US10::US10_1(Documents::US11::US11_0);
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method32;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US10 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method32;
                                        }
                                    } else {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US10 = Documents::US10::US10_2;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method32;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                            let v3_temp: Documents::US10 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method32;
                                        }
                                    }
                                }
                                Documents::US10::US10_0 => {
                                    if ' ' == v4 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                        let v3_temp: Documents::US10 = Documents::US10::US10_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method32;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4);
                                        let v2_temp: LrcPtr<Documents::UH0> = v5;
                                        let v3_temp: Documents::US10 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method32;
                                    }
                                }
                                _ => {
                                    let v0_1_temp: string =
                                        sprintf!("{}{}", v0_1.get().clone(), v4);
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                    let v3_temp: Documents::US10 = Documents::US10::US10_2;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    continue '_method32;
                                }
                            }
                        }
                    }
                } else {
                    match &v3.get().clone() {
                        Documents::US10::US10_1(v3_1_0) => {
                            if let Documents::US11::US11_0 = v3_1_0 {
                                (
                                    replace(v1_1.get().clone(), string("\\"), string("/")),
                                    v0_1.get().clone(),
                                )
                            } else {
                                (
                                    replace(v1_1.get().clone(), string("\\"), string("/")),
                                    v0_1.get().clone(),
                                )
                            }
                        }
                        Documents::US10::US10_0 => (
                            replace(v1_1.get().clone(), string("\\"), string("/")),
                            v0_1.get().clone(),
                        ),
                        _ => (
                            replace(v1_1.get().clone(), string("\\"), string("/")),
                            v0_1.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method36(
            v0_1: LrcPtr<Documents::UH1>,
            v1_1: LrcPtr<Documents::UH1>,
        ) -> LrcPtr<Documents::UH1> {
            match v0_1.as_ref() {
                Documents::UH1::UH1_0 => v1_1.clone(),
                Documents::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => LrcPtr::new(Documents::UH1::UH1_1(
                    match v0_1.as_ref() {
                        Documents::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Documents::method36(
                        match v0_1.as_ref() {
                            Documents::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                )),
            }
        }
        pub fn method35(
            v0_1: string,
            v1_1: LrcPtr<Documents::UH1>,
            v2: LrcPtr<Documents::UH0>,
            v3: Documents::US12,
        ) -> (LrcPtr<Documents::UH1>, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v2.clone());
            let v3: MutCell<Documents::US12> = MutCell::new(v3.clone());
            '_method35: loop {
                break '_method35 (match &v3.get().clone() {
                    Documents::US12::US12_1(v3_1_0) => {
                        let v105: char = v3_1_0.clone();
                        if '\"' == v105 {
                            if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) = v2.get().clone().as_ref()
                            {
                                let v108: LrcPtr<Documents::UH0> = match v2.get().clone().as_ref() {
                                    Documents::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                let v107: char = match v2.get().clone().as_ref() {
                                    Documents::UH0::UH0_1(x, _) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if '\"' == v107 {
                                    if v3.get().clone() == Documents::US12::US12_1('\\') {
                                        Documents::method34(
                                            v0_1.get().clone(),
                                            v1_1.get().clone(),
                                            v108.clone(),
                                            v3.get().clone(),
                                            Documents::US12::US12_0,
                                        )
                                    } else {
                                        if '\\' == v105 {
                                            if !(v3.get().clone() == Documents::US12::US12_2(0_u8))
                                            {
                                                Documents::method34(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v108.clone(),
                                                    v3.get().clone(),
                                                    Documents::US12::US12_1('\"'),
                                                )
                                            } else {
                                                if v3.get().clone() == Documents::US12::US12_1('\\')
                                                {
                                                    Documents::method34(
                                                        sprintf!("{}\"", v0_1.get().clone()),
                                                        v1_1.get().clone(),
                                                        v108.clone(),
                                                        v3.get().clone(),
                                                        Documents::US12::US12_1('\"'),
                                                    )
                                                } else {
                                                    Documents::method34(
                                                        v0_1.get().clone(),
                                                        v1_1.get().clone(),
                                                        v108.clone(),
                                                        v3.get().clone(),
                                                        Documents::US12::US12_0,
                                                    )
                                                }
                                            }
                                        } else {
                                            if '\\' == v107 {
                                                Documents::method34(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v108.clone(),
                                                    v3.get().clone(),
                                                    Documents::US12::US12_2(1_u8),
                                                )
                                            } else {
                                                if v3.get().clone() == Documents::US12::US12_2(0_u8)
                                                {
                                                    Documents::method34(
                                                        sprintf!("{}\"", v0_1.get().clone()),
                                                        v1_1.get().clone(),
                                                        v108.clone(),
                                                        v3.get().clone(),
                                                        Documents::US12::US12_1('\"'),
                                                    )
                                                } else {
                                                    Documents::method34(
                                                        string(""),
                                                        Documents::method36(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(Documents::UH1::UH1_1(
                                                                v0_1.get().clone(),
                                                                LrcPtr::new(Documents::UH1::UH1_0),
                                                            )),
                                                        ),
                                                        v108.clone(),
                                                        v3.get().clone(),
                                                        Documents::US12::US12_0,
                                                    )
                                                }
                                            }
                                        }
                                    }
                                } else {
                                    if '\\' == v105 {
                                        if '\\' == v107 {
                                            Documents::method34(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v108.clone(),
                                                v3.get().clone(),
                                                Documents::US12::US12_2(1_u8),
                                            )
                                        } else {
                                            if ' ' == v107 {
                                                let v0_1_temp: string =
                                                    sprintf!("{} ", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v108.clone();
                                                let v3_temp: Documents::US12 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method35;
                                            } else {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}", v0_1.get().clone(), v107);
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v108.clone();
                                                let v3_temp: Documents::US12 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method35;
                                            }
                                        }
                                    } else {
                                        if '\\' == v107 {
                                            Documents::method34(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v108,
                                                v3.get().clone(),
                                                Documents::US12::US12_2(1_u8),
                                            )
                                        } else {
                                            if ' ' == v107 {
                                                let v0_1_temp: string =
                                                    sprintf!("{} ", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v108.clone();
                                                let v3_temp: Documents::US12 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method35;
                                            } else {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}", v0_1.get().clone(), v107);
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v108.clone();
                                                let v3_temp: Documents::US12 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method35;
                                            }
                                        }
                                    }
                                }
                            } else {
                                if '\\' == v105 {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Documents::method36(
                                                v1_1.get().clone(),
                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Documents::UH1::UH1_0),
                                                )),
                                            )
                                        },
                                        v0_1.get().clone(),
                                    )
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Documents::method36(
                                                v1_1.get().clone(),
                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Documents::UH1::UH1_0),
                                                )),
                                            )
                                        },
                                        v0_1.get().clone(),
                                    )
                                }
                            }
                        } else {
                            if '\\' == v105 {
                                if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) =
                                    v2.get().clone().as_ref()
                                {
                                    let v220: LrcPtr<Documents::UH0> =
                                        match v2.get().clone().as_ref() {
                                            Documents::UH0::UH0_1(_, x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                    let v219: char = match v2.get().clone().as_ref() {
                                        Documents::UH0::UH0_1(x, _) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if '\"' == v219 {
                                        if !(v3.get().clone() == Documents::US12::US12_2(0_u8)) {
                                            Documents::method34(
                                                sprintf!("{}\"", v0_1.get().clone()),
                                                v1_1.get().clone(),
                                                v220.clone(),
                                                v3.get().clone(),
                                                Documents::US12::US12_1('\"'),
                                            )
                                        } else {
                                            if v3.get().clone() == Documents::US12::US12_1('\\') {
                                                Documents::method34(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v220.clone(),
                                                    v3.get().clone(),
                                                    Documents::US12::US12_1('\"'),
                                                )
                                            } else {
                                                Documents::method34(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v220.clone(),
                                                    v3.get().clone(),
                                                    Documents::US12::US12_0,
                                                )
                                            }
                                        }
                                    } else {
                                        if '\\' == v219 {
                                            Documents::method34(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v220.clone(),
                                                v3.get().clone(),
                                                Documents::US12::US12_2(1_u8),
                                            )
                                        } else {
                                            if ' ' == v219 {
                                                let v0_1_temp: string =
                                                    sprintf!("{} ", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v220;
                                                let v3_temp: Documents::US12 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method35;
                                            } else {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}", v0_1.get().clone(), v219);
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v220.clone();
                                                let v3_temp: Documents::US12 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method35;
                                            }
                                        }
                                    }
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Documents::method36(
                                                v1_1.get().clone(),
                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Documents::UH1::UH1_0),
                                                )),
                                            )
                                        },
                                        v0_1.get().clone(),
                                    )
                                }
                            } else {
                                if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) =
                                    v2.get().clone().as_ref()
                                {
                                    let v270: LrcPtr<Documents::UH0> =
                                        match v2.get().clone().as_ref() {
                                            Documents::UH0::UH0_1(_, x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                    let v269: char = match v2.get().clone().as_ref() {
                                        Documents::UH0::UH0_1(x, _) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if '\\' == v269 {
                                        Documents::method34(
                                            v0_1.get().clone(),
                                            v1_1.get().clone(),
                                            v270.clone(),
                                            v3.get().clone(),
                                            Documents::US12::US12_2(1_u8),
                                        )
                                    } else {
                                        if '\"' == v269 {
                                            if v3.get().clone() == Documents::US12::US12_2(0_u8) {
                                                Documents::method34(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v270.clone(),
                                                    v3.get().clone(),
                                                    Documents::US12::US12_1('\"'),
                                                )
                                            } else {
                                                Documents::method34(
                                                    string(""),
                                                    Documents::method36(
                                                        v1_1.get().clone(),
                                                        LrcPtr::new(Documents::UH1::UH1_1(
                                                            v0_1.get().clone(),
                                                            LrcPtr::new(Documents::UH1::UH1_0),
                                                        )),
                                                    ),
                                                    v270.clone(),
                                                    v3.get().clone(),
                                                    Documents::US12::US12_0,
                                                )
                                            }
                                        } else {
                                            if ' ' == v269 {
                                                let v0_1_temp: string =
                                                    sprintf!("{} ", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v270;
                                                let v3_temp: Documents::US12 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method35;
                                            } else {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}", v0_1.get().clone(), v269);
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v270.clone();
                                                let v3_temp: Documents::US12 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method35;
                                            }
                                        }
                                    }
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Documents::method36(
                                                v1_1.get().clone(),
                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Documents::UH1::UH1_0),
                                                )),
                                            )
                                        },
                                        v0_1.get().clone(),
                                    )
                                }
                            }
                        }
                    }
                    Documents::US12::US12_0 => {
                        if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) = v2.get().clone().as_ref() {
                            let v5: LrcPtr<Documents::UH0> = match v2.get().clone().as_ref() {
                                Documents::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v4: char = match v2.get().clone().as_ref() {
                                Documents::UH0::UH0_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if '\"' == v4 {
                                Documents::method34(
                                    string(""),
                                    v1_1.get().clone(),
                                    v5.clone(),
                                    v3.get().clone(),
                                    Documents::US12::US12_1('\"'),
                                )
                            } else {
                                if '\\' == v4 {
                                    Documents::method34(
                                        v0_1.get().clone(),
                                        v1_1.get().clone(),
                                        v5.clone(),
                                        v3.get().clone(),
                                        Documents::US12::US12_2(0_u8),
                                    )
                                } else {
                                    if ' ' == v4 {
                                        let v0_1_temp: string = string("");
                                        let v1_1_temp: LrcPtr<Documents::UH1> =
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Documents::method36(
                                                    v1_1.get().clone(),
                                                    LrcPtr::new(Documents::UH1::UH1_1(
                                                        v0_1.get().clone(),
                                                        LrcPtr::new(Documents::UH1::UH1_0),
                                                    )),
                                                )
                                            };
                                        let v2_temp: LrcPtr<Documents::UH0> = v5;
                                        let v3_temp: Documents::US12 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method35;
                                    } else {
                                        let v0_1_temp: string =
                                            sprintf!("{}{}", v0_1.get().clone(), v4);
                                        let v1_1_temp: LrcPtr<Documents::UH1> = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v5.clone();
                                        let v3_temp: Documents::US12 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method35;
                                    }
                                }
                            }
                        } else {
                            (
                                if v0_1.get().clone() == string("") {
                                    v1_1.get().clone()
                                } else {
                                    Documents::method36(
                                        v1_1.get().clone(),
                                        LrcPtr::new(Documents::UH1::UH1_1(
                                            v0_1.get().clone(),
                                            LrcPtr::new(Documents::UH1::UH1_0),
                                        )),
                                    )
                                },
                                v0_1.get().clone(),
                            )
                        }
                    }
                    Documents::US12::US12_2(v3_2_0) => {
                        let v44: u8 = match &v3.get().clone() {
                            Documents::US12::US12_2(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) = v2.get().clone().as_ref() {
                            let v46: LrcPtr<Documents::UH0> = match v2.get().clone().as_ref() {
                                Documents::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v45: char = match v2.get().clone().as_ref() {
                                Documents::UH0::UH0_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if '\\' == v45 {
                                Documents::method34(
                                    v0_1.get().clone(),
                                    v1_1.get().clone(),
                                    v46.clone(),
                                    v3.get().clone(),
                                    Documents::US12::US12_1('\\'),
                                )
                            } else {
                                if '\"' == v45 {
                                    if if let Documents::US12::US12_0 = &v3.get().clone() {
                                        true
                                    } else {
                                        false
                                    } {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: LrcPtr<Documents::UH1> = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v46.clone();
                                        let v3_temp: Documents::US12 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method35;
                                    } else {
                                        Documents::method34(
                                            sprintf!("{}\"", v0_1.get().clone()),
                                            v1_1.get().clone(),
                                            v46.clone(),
                                            v3.get().clone(),
                                            Documents::US12::US12_2(v44),
                                        )
                                    }
                                } else {
                                    if ' ' == v45 {
                                        let v0_1_temp: string = sprintf!("{} ", v0_1.get().clone());
                                        let v1_1_temp: LrcPtr<Documents::UH1> = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v46.clone();
                                        let v3_temp: Documents::US12 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method35;
                                    } else {
                                        if 1_u8 == v44 {
                                            if !(v3.get().clone() == v3.get().clone()) {
                                                let v0_1_temp: string =
                                                    sprintf!("{}\\{}", v0_1.get().clone(), v45);
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v46.clone();
                                                let v3_temp: Documents::US12 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method35;
                                            } else {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}", v0_1.get().clone(), v45);
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v46.clone();
                                                let v3_temp: Documents::US12 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method35;
                                            }
                                        } else {
                                            let v0_1_temp: string =
                                                sprintf!("{}{}", v0_1.get().clone(), v45);
                                            let v1_1_temp: LrcPtr<Documents::UH1> =
                                                v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v46.clone();
                                            let v3_temp: Documents::US12 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method35;
                                        }
                                    }
                                }
                            }
                        } else {
                            if 1_u8 == v44 {
                                (
                                    if v0_1.get().clone() == string("") {
                                        v1_1.get().clone()
                                    } else {
                                        Documents::method36(
                                            v1_1.get().clone(),
                                            LrcPtr::new(Documents::UH1::UH1_1(
                                                v0_1.get().clone(),
                                                LrcPtr::new(Documents::UH1::UH1_0),
                                            )),
                                        )
                                    },
                                    v0_1.get().clone(),
                                )
                            } else {
                                (
                                    if v0_1.get().clone() == string("") {
                                        v1_1.get().clone()
                                    } else {
                                        Documents::method36(
                                            v1_1.get().clone(),
                                            LrcPtr::new(Documents::UH1::UH1_1(
                                                v0_1.get().clone(),
                                                LrcPtr::new(Documents::UH1::UH1_0),
                                            )),
                                        )
                                    },
                                    v0_1.get().clone(),
                                )
                            }
                        }
                    }
                });
            }
        }
        pub fn method34(
            v0_1: string,
            v1_1: LrcPtr<Documents::UH1>,
            v2: LrcPtr<Documents::UH0>,
            v3: Documents::US12,
            v4: Documents::US12,
        ) -> (LrcPtr<Documents::UH1>, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v2.clone());
            let v3: MutCell<Documents::US12> = MutCell::new(v3.clone());
            let v4: MutCell<Documents::US12> = MutCell::new(v4.clone());
            '_method34: loop {
                break '_method34 (match &v4.get().clone() {
                    Documents::US12::US12_1(v4_1_0) => {
                        let v106: char = v4_1_0.clone();
                        if '\"' == v106 {
                            if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) = v2.get().clone().as_ref()
                            {
                                let v109: LrcPtr<Documents::UH0> = match v2.get().clone().as_ref() {
                                    Documents::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                let v108: char = match v2.get().clone().as_ref() {
                                    Documents::UH0::UH0_1(x, _) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if '\"' == v108 {
                                    if v3.get().clone() == Documents::US12::US12_1('\\') {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: LrcPtr<Documents::UH1> = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v109.clone();
                                        let v3_temp: Documents::US12 = v4.get().clone();
                                        let v4_temp: Documents::US12 = Documents::US12::US12_0;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        v4.set(v4_temp);
                                        continue '_method34;
                                    } else {
                                        if '\\' == v106 {
                                            if !(v3.get().clone() == Documents::US12::US12_2(0_u8))
                                            {
                                                let v0_1_temp: string =
                                                    sprintf!("{}\"", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v109.clone();
                                                let v3_temp: Documents::US12 = v4.get().clone();
                                                let v4_temp: Documents::US12 =
                                                    Documents::US12::US12_1('\"');
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method34;
                                            } else {
                                                if v3.get().clone() == Documents::US12::US12_1('\\')
                                                {
                                                    let v0_1_temp: string =
                                                        sprintf!("{}\"", v0_1.get().clone());
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v109.clone();
                                                    let v3_temp: Documents::US12 = v4.get().clone();
                                                    let v4_temp: Documents::US12 =
                                                        Documents::US12::US12_1('\"');
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method34;
                                                } else {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v109.clone();
                                                    let v3_temp: Documents::US12 = v4.get().clone();
                                                    let v4_temp: Documents::US12 =
                                                        Documents::US12::US12_0;
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method34;
                                                }
                                            }
                                        } else {
                                            if '\\' == v108 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v109.clone();
                                                let v3_temp: Documents::US12 = v4.get().clone();
                                                let v4_temp: Documents::US12 =
                                                    Documents::US12::US12_2(1_u8);
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method34;
                                            } else {
                                                if v3.get().clone() == Documents::US12::US12_2(0_u8)
                                                {
                                                    let v0_1_temp: string =
                                                        sprintf!("{}\"", v0_1.get().clone());
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v109.clone();
                                                    let v3_temp: Documents::US12 = v4.get().clone();
                                                    let v4_temp: Documents::US12 =
                                                        Documents::US12::US12_1('\"');
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method34;
                                                } else {
                                                    let v0_1_temp: string = string("");
                                                    let v1_1_temp: LrcPtr<Documents::UH1> =
                                                        Documents::method36(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(Documents::UH1::UH1_1(
                                                                v0_1.get().clone(),
                                                                LrcPtr::new(Documents::UH1::UH1_0),
                                                            )),
                                                        );
                                                    let v2_temp: LrcPtr<Documents::UH0> =
                                                        v109.clone();
                                                    let v3_temp: Documents::US12 = v4.get().clone();
                                                    let v4_temp: Documents::US12 =
                                                        Documents::US12::US12_0;
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method34;
                                                }
                                            }
                                        }
                                    }
                                } else {
                                    if '\\' == v106 {
                                        if '\\' == v108 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: LrcPtr<Documents::UH1> =
                                                v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v109.clone();
                                            let v3_temp: Documents::US12 = v4.get().clone();
                                            let v4_temp: Documents::US12 =
                                                Documents::US12::US12_2(1_u8);
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            v4.set(v4_temp);
                                            continue '_method34;
                                        } else {
                                            if ' ' == v108 {
                                                Documents::method35(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v109.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Documents::method35(
                                                    sprintf!("{}{}", v0_1.get().clone(), v108),
                                                    v1_1.get().clone(),
                                                    v109.clone(),
                                                    v4.get().clone(),
                                                )
                                            }
                                        }
                                    } else {
                                        if '\\' == v108 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: LrcPtr<Documents::UH1> =
                                                v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v109.clone();
                                            let v3_temp: Documents::US12 = v4.get().clone();
                                            let v4_temp: Documents::US12 =
                                                Documents::US12::US12_2(1_u8);
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            v4.set(v4_temp);
                                            continue '_method34;
                                        } else {
                                            if ' ' == v108 {
                                                Documents::method35(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v109.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Documents::method35(
                                                    sprintf!("{}{}", v0_1.get().clone(), v108),
                                                    v1_1.get().clone(),
                                                    v109.clone(),
                                                    v4.get().clone(),
                                                )
                                            }
                                        }
                                    }
                                }
                            } else {
                                if '\\' == v106 {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Documents::method36(
                                                v1_1.get().clone(),
                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Documents::UH1::UH1_0),
                                                )),
                                            )
                                        },
                                        v0_1.get().clone(),
                                    )
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Documents::method36(
                                                v1_1.get().clone(),
                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Documents::UH1::UH1_0),
                                                )),
                                            )
                                        },
                                        v0_1.get().clone(),
                                    )
                                }
                            }
                        } else {
                            if '\\' == v106 {
                                if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) =
                                    v2.get().clone().as_ref()
                                {
                                    let v221: LrcPtr<Documents::UH0> =
                                        match v2.get().clone().as_ref() {
                                            Documents::UH0::UH0_1(_, x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                    let v220: char = match v2.get().clone().as_ref() {
                                        Documents::UH0::UH0_1(x, _) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if '\"' == v220 {
                                        if !(v3.get().clone() == Documents::US12::US12_2(0_u8)) {
                                            let v0_1_temp: string =
                                                sprintf!("{}\"", v0_1.get().clone());
                                            let v1_1_temp: LrcPtr<Documents::UH1> =
                                                v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v221.clone();
                                            let v3_temp: Documents::US12 = v4.get().clone();
                                            let v4_temp: Documents::US12 =
                                                Documents::US12::US12_1('\"');
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            v4.set(v4_temp);
                                            continue '_method34;
                                        } else {
                                            if v3.get().clone() == Documents::US12::US12_1('\\') {
                                                let v0_1_temp: string =
                                                    sprintf!("{}\"", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v221.clone();
                                                let v3_temp: Documents::US12 = v4.get().clone();
                                                let v4_temp: Documents::US12 =
                                                    Documents::US12::US12_1('\"');
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method34;
                                            } else {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v221;
                                                let v3_temp: Documents::US12 = v4.get().clone();
                                                let v4_temp: Documents::US12 =
                                                    Documents::US12::US12_0;
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method34;
                                            }
                                        }
                                    } else {
                                        if '\\' == v220 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: LrcPtr<Documents::UH1> =
                                                v1_1.get().clone();
                                            let v2_temp: LrcPtr<Documents::UH0> = v221.clone();
                                            let v3_temp: Documents::US12 = v4.get().clone();
                                            let v4_temp: Documents::US12 =
                                                Documents::US12::US12_2(1_u8);
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            v4.set(v4_temp);
                                            continue '_method34;
                                        } else {
                                            if ' ' == v220 {
                                                Documents::method35(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v221.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Documents::method35(
                                                    sprintf!("{}{}", v0_1.get().clone(), v220),
                                                    v1_1.get().clone(),
                                                    v221.clone(),
                                                    v4.get().clone(),
                                                )
                                            }
                                        }
                                    }
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Documents::method36(
                                                v1_1.get().clone(),
                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Documents::UH1::UH1_0),
                                                )),
                                            )
                                        },
                                        v0_1.get().clone(),
                                    )
                                }
                            } else {
                                if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) =
                                    v2.get().clone().as_ref()
                                {
                                    let v271: LrcPtr<Documents::UH0> =
                                        match v2.get().clone().as_ref() {
                                            Documents::UH0::UH0_1(_, x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                    let v270: char = match v2.get().clone().as_ref() {
                                        Documents::UH0::UH0_1(x, _) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if '\\' == v270 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: LrcPtr<Documents::UH1> = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v271.clone();
                                        let v3_temp: Documents::US12 = v4.get().clone();
                                        let v4_temp: Documents::US12 =
                                            Documents::US12::US12_2(1_u8);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        v4.set(v4_temp);
                                        continue '_method34;
                                    } else {
                                        if '\"' == v270 {
                                            if v3.get().clone() == Documents::US12::US12_2(0_u8) {
                                                let v0_1_temp: string =
                                                    sprintf!("{}\"", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v271.clone();
                                                let v3_temp: Documents::US12 = v4.get().clone();
                                                let v4_temp: Documents::US12 =
                                                    Documents::US12::US12_1('\"');
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method34;
                                            } else {
                                                let v0_1_temp: string = string("");
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    Documents::method36(
                                                        v1_1.get().clone(),
                                                        LrcPtr::new(Documents::UH1::UH1_1(
                                                            v0_1.get().clone(),
                                                            LrcPtr::new(Documents::UH1::UH1_0),
                                                        )),
                                                    );
                                                let v2_temp: LrcPtr<Documents::UH0> = v271.clone();
                                                let v3_temp: Documents::US12 = v4.get().clone();
                                                let v4_temp: Documents::US12 =
                                                    Documents::US12::US12_0;
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method34;
                                            }
                                        } else {
                                            if ' ' == v270 {
                                                Documents::method35(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v271.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Documents::method35(
                                                    sprintf!("{}{}", v0_1.get().clone(), v270),
                                                    v1_1.get().clone(),
                                                    v271.clone(),
                                                    v4.get().clone(),
                                                )
                                            }
                                        }
                                    }
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Documents::method36(
                                                v1_1.get().clone(),
                                                LrcPtr::new(Documents::UH1::UH1_1(
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Documents::UH1::UH1_0),
                                                )),
                                            )
                                        },
                                        v0_1.get().clone(),
                                    )
                                }
                            }
                        }
                    }
                    Documents::US12::US12_0 => {
                        if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) = v2.get().clone().as_ref() {
                            let v6: LrcPtr<Documents::UH0> = match v2.get().clone().as_ref() {
                                Documents::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v5: char = match v2.get().clone().as_ref() {
                                Documents::UH0::UH0_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if '\"' == v5 {
                                let v0_1_temp: string = string("");
                                let v1_1_temp: LrcPtr<Documents::UH1> = v1_1.get().clone();
                                let v2_temp: LrcPtr<Documents::UH0> = v6.clone();
                                let v3_temp: Documents::US12 = v4.get().clone();
                                let v4_temp: Documents::US12 = Documents::US12::US12_1('\"');
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method34;
                            } else {
                                if '\\' == v5 {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: LrcPtr<Documents::UH1> = v1_1.get().clone();
                                    let v2_temp: LrcPtr<Documents::UH0> = v6;
                                    let v3_temp: Documents::US12 = v4.get().clone();
                                    let v4_temp: Documents::US12 = Documents::US12::US12_2(0_u8);
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    v4.set(v4_temp);
                                    continue '_method34;
                                } else {
                                    if ' ' == v5 {
                                        Documents::method35(
                                            string(""),
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Documents::method36(
                                                    v1_1.get().clone(),
                                                    LrcPtr::new(Documents::UH1::UH1_1(
                                                        v0_1.get().clone(),
                                                        LrcPtr::new(Documents::UH1::UH1_0),
                                                    )),
                                                )
                                            },
                                            v6.clone(),
                                            v4.get().clone(),
                                        )
                                    } else {
                                        Documents::method35(
                                            sprintf!("{}{}", v0_1.get().clone(), v5),
                                            v1_1.get().clone(),
                                            v6.clone(),
                                            v4.get().clone(),
                                        )
                                    }
                                }
                            }
                        } else {
                            (
                                if v0_1.get().clone() == string("") {
                                    v1_1.get().clone()
                                } else {
                                    Documents::method36(
                                        v1_1.get().clone(),
                                        LrcPtr::new(Documents::UH1::UH1_1(
                                            v0_1.get().clone(),
                                            LrcPtr::new(Documents::UH1::UH1_0),
                                        )),
                                    )
                                },
                                v0_1.get().clone(),
                            )
                        }
                    }
                    Documents::US12::US12_2(v4_2_0) => {
                        let v45: u8 = match &v4.get().clone() {
                            Documents::US12::US12_2(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        if let Documents::UH0::UH0_1(v2_1_0, v2_1_1) = v2.get().clone().as_ref() {
                            let v47: LrcPtr<Documents::UH0> = match v2.get().clone().as_ref() {
                                Documents::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v46: char = match v2.get().clone().as_ref() {
                                Documents::UH0::UH0_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if '\\' == v46 {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Documents::UH1> = v1_1.get().clone();
                                let v2_temp: LrcPtr<Documents::UH0> = v47.clone();
                                let v3_temp: Documents::US12 = v4.get().clone();
                                let v4_temp: Documents::US12 = Documents::US12::US12_1('\\');
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method34;
                            } else {
                                if '\"' == v46 {
                                    if if let Documents::US12::US12_0 = &v3.get().clone() {
                                        true
                                    } else {
                                        false
                                    } {
                                        Documents::method35(
                                            v0_1.get().clone(),
                                            v1_1.get().clone(),
                                            v47.clone(),
                                            v4.get().clone(),
                                        )
                                    } else {
                                        let v0_1_temp: string =
                                            sprintf!("{}\"", v0_1.get().clone());
                                        let v1_1_temp: LrcPtr<Documents::UH1> = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Documents::UH0> = v47.clone();
                                        let v3_temp: Documents::US12 = v4.get().clone();
                                        let v4_temp: Documents::US12 = Documents::US12::US12_2(v45);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        v4.set(v4_temp);
                                        continue '_method34;
                                    }
                                } else {
                                    if ' ' == v46 {
                                        Documents::method35(
                                            sprintf!("{} ", v0_1.get().clone()),
                                            v1_1.get().clone(),
                                            v47.clone(),
                                            v4.get().clone(),
                                        )
                                    } else {
                                        if 1_u8 == v45 {
                                            if !(v3.get().clone() == v4.get().clone()) {
                                                let v0_1_temp: string =
                                                    sprintf!("{}\\{}", v0_1.get().clone(), v46);
                                                let v1_1_temp: LrcPtr<Documents::UH1> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Documents::UH0> = v47.clone();
                                                let v3_temp: Documents::US12 = v4.get().clone();
                                                let v4_temp: Documents::US12 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method34;
                                            } else {
                                                Documents::method35(
                                                    sprintf!("{}{}", v0_1.get().clone(), v46),
                                                    v1_1.get().clone(),
                                                    v47.clone(),
                                                    v4.get().clone(),
                                                )
                                            }
                                        } else {
                                            Documents::method35(
                                                sprintf!("{}{}", v0_1.get().clone(), v46),
                                                v1_1.get().clone(),
                                                v47.clone(),
                                                v4.get().clone(),
                                            )
                                        }
                                    }
                                }
                            }
                        } else {
                            if 1_u8 == v45 {
                                (
                                    if v0_1.get().clone() == string("") {
                                        v1_1.get().clone()
                                    } else {
                                        Documents::method36(
                                            v1_1.get().clone(),
                                            LrcPtr::new(Documents::UH1::UH1_1(
                                                v0_1.get().clone(),
                                                LrcPtr::new(Documents::UH1::UH1_0),
                                            )),
                                        )
                                    },
                                    v0_1.get().clone(),
                                )
                            } else {
                                (
                                    if v0_1.get().clone() == string("") {
                                        v1_1.get().clone()
                                    } else {
                                        Documents::method36(
                                            v1_1.get().clone(),
                                            LrcPtr::new(Documents::UH1::UH1_1(
                                                v0_1.get().clone(),
                                                LrcPtr::new(Documents::UH1::UH1_0),
                                            )),
                                        )
                                    },
                                    v0_1.get().clone(),
                                )
                            }
                        }
                    }
                });
            }
        }
        pub fn method37(v0_1: LrcPtr<Documents::UH1>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Documents::UH1::UH1_0 => v1_1.clone(),
                Documents::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Documents::method37(
                        match v0_1.as_ref() {
                            Documents::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method33(v0_1: string) -> Array<string> {
            let v3: i32 = length(v0_1.clone());
            let v4: Array<char> = new_init(&'\u{0000}', v3);
            let v5: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                l0: MutCell::new(0_i32),
            });
            while Documents::method30(v3, v5.clone()) {
                let v7: i32 = v5.l0.get().clone();
                let v8: char = getCharAt(v0_1.clone(), v7);
                v4.get_mut()[v7 as usize] = v8;
                {
                    let v9: i32 = v7 + 1_i32;
                    v5.l0.set(v9);
                    ()
                }
            }
            {
                let v11: List<char> = ofArray(v4.clone());
                toArray(Documents::method37(
                    (Documents::method34(
                        string(""),
                        LrcPtr::new(Documents::UH1::UH1_0),
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                (Documents::method31())(b0)(b1)
                            }),
                            v11,
                            LrcPtr::new(Documents::UH0::UH0_0),
                        ),
                        Documents::US12::US12_0,
                        Documents::US12::US12_0,
                    ))
                    .0
                    .clone(),
                    empty::<string>(),
                ))
            }
        }
        pub fn closure26(unitVar: (), v0_1: string) -> std::string::String {
            let v1_1: string = Documents::method13(v0_1);
            let v3: &str = fable_library_rust::String_::LrcStr::as_str(&v1_1);
            String::from(v3)
        }
        pub fn closure27(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v3: Option<string>,
            v4: string,
            v5: Vec<std::string::String>,
            unitVar: (),
        ) -> string {
            sprintf!(
                "execute_with_options / file_name: {} / arguments: {:?} / options: {:?}",
                v4,
                v5,
                (v0_1, v1_1, v2, v3)
            )
        }
        pub fn method38() -> Func0<string> {
            Func0::new(move || Documents::closure6((), ()))
        }
        pub fn closure28(unitVar: (), v0_1: string) -> Documents::US7 {
            Documents::US7::US7_0(v0_1)
        }
        pub fn method40() -> Func1<string, Documents::US7> {
            Func1::new(move |v: string| Documents::closure28((), v))
        }
        pub fn method41(v0_1: string) -> string {
            v0_1
        }
        pub fn method43(
            v0_1: std::sync::Mutex<Option<std::process::Child>>,
        ) -> std::sync::Mutex<Option<std::process::Child>> {
            v0_1
        }
        pub fn closure29(
            unitVar: (),
            v0_1: std::process::Child,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> {
            let v4: std::sync::Mutex<Option<std::process::Child>> =
                Documents::method43(std::sync::Mutex::new(Some(v0_1)));
            std::sync::Arc::new(v4)
        }
        pub fn method42(
        ) -> Func1<std::process::Child, std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>>
        {
            Func1::new(move |v: std::process::Child| Documents::closure29((), v))
        }
        pub fn method44(
            v0_1: Result<std::process::Child, std::io::Error>,
        ) -> Result<std::process::Child, std::io::Error> {
            v0_1
        }
        pub fn closure30(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Documents::US13 {
            Documents::US13::US13_0(v0_1)
        }
        pub fn closure31(unitVar: (), v0_1: std::string::String) -> Documents::US13 {
            Documents::US13::US13_1(v0_1)
        }
        pub fn closure32(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("execute_with_options -1 / error: {}", v0_1)
        }
        pub fn method45(
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> {
            v0_1
        }
        pub fn method46(
            v0_1: std::sync::Mutex<Option<std::process::ChildStdout>>,
        ) -> std::sync::Mutex<Option<std::process::ChildStdout>> {
            v0_1
        }
        pub fn method47(
            v0_1: std::sync::Mutex<Option<std::process::ChildStderr>>,
        ) -> std::sync::Mutex<Option<std::process::ChildStderr>> {
            v0_1
        }
        pub fn method48(
            v0_1: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        ) -> std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>> {
            v0_1
        }
        pub fn method49(
            v0_1: std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
        ) -> std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>> {
            v0_1
        }
        pub fn method50(
            v0_1: std::sync::Mutex<std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>>,
        ) -> std::sync::Mutex<std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>>
        {
            v0_1
        }
        pub fn method51(
            v0_1: std::sync::Mutex<std::io::Lines<std::io::BufReader<std::process::ChildStdout>>>,
        ) -> std::sync::Mutex<std::io::Lines<std::io::BufReader<std::process::ChildStdout>>>
        {
            v0_1
        }
        pub fn closure34(unitVar: (), v0_1: std::string::String) -> Documents::US15 {
            Documents::US15::US15_0(v0_1)
        }
        pub fn closure35(unitVar: (), v0_1: std::string::String) -> Documents::US15 {
            Documents::US15::US15_1(v0_1)
        }
        pub fn closure36(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options / stdout_line / stdout: {} / e: {}",
                true,
                v0_1
            )
        }
        pub fn closure37(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("> {}", v0_1)
        }
        pub fn closure33(
            v0_1: std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>,
            v1_1: Result<std::string::String, std::io::Error>,
        ) {
            let v2 = Documents::method21();
            let v4: Result<std::string::String, std::string::String> = v1_1.map_err(|x| v2(x));
            let v7: Documents::US15 = match &v4 {
                Err(v4_1_0) => Documents::closure35((), v4_1_0.clone()),
                Ok(v4_0_0) => Documents::closure34((), v4_0_0.clone()),
            };
            let v23: std::string::String = match &v7 {
                Documents::US15::US15_0(v7_0_0) => {
                    let v8: std::string::String = v7_0_0.clone();
                    Documents::method3(
                        Documents::US0::US0_0,
                        Func0::new({
                            let v8 = v8.clone();
                            move || Documents::closure37(v8.clone(), ())
                        }),
                        Func0::new(move || Documents::closure6((), ())),
                    );
                    v8.clone()
                }
                Documents::US15::US15_1(v7_1_0) => {
                    let v12: std::string::String = v7_1_0.clone();
                    Documents::method3(
                        Documents::US0::US0_4,
                        Func0::new({
                            let v12 = v12.clone();
                            move || Documents::closure36(v12.clone(), ())
                        }),
                        Func0::new(move || Documents::closure6((), ())),
                    );
                    {
                        let v17: string = Documents::method13(sprintf!("[{}]", v12.clone()));
                        let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
                        String::from(v19)
                    }
                }
            };
            let v25: bool = true;
            v0_1.lock().unwrap().send(v23).unwrap();
            ()
        }
        pub fn method52(
            v0_1: std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>,
        ) -> Func1<Result<std::string::String, std::io::Error>, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Result<std::string::String, std::io::Error>| {
                    Documents::closure33(v0_1.clone(), v)
                }
            })
        }
        pub fn method53(
            v0_1: std::sync::Mutex<std::io::Lines<std::io::BufReader<std::process::ChildStderr>>>,
        ) -> std::sync::Mutex<std::io::Lines<std::io::BufReader<std::process::ChildStderr>>>
        {
            v0_1
        }
        pub fn closure39(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options / stdout_line / stdout: {} / e: {}",
                false,
                v0_1
            )
        }
        pub fn closure38(
            v0_1: std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>,
            v1_1: Result<std::string::String, std::io::Error>,
        ) {
            let v2 = Documents::method21();
            let v4: Result<std::string::String, std::string::String> = v1_1.map_err(|x| v2(x));
            let v7: Documents::US15 = match &v4 {
                Err(v4_1_0) => Documents::closure35((), v4_1_0.clone()),
                Ok(v4_0_0) => Documents::closure34((), v4_0_0.clone()),
            };
            let v23: std::string::String = match &v7 {
                Documents::US15::US15_0(v7_0_0) => {
                    let v8: std::string::String = v7_0_0.clone();
                    Documents::method3(
                        Documents::US0::US0_0,
                        Func0::new({
                            let v8 = v8.clone();
                            move || Documents::closure37(v8.clone(), ())
                        }),
                        Func0::new(move || Documents::closure6((), ())),
                    );
                    v8.clone()
                }
                Documents::US15::US15_1(v7_1_0) => {
                    let v12: std::string::String = v7_1_0.clone();
                    Documents::method3(
                        Documents::US0::US0_4,
                        Func0::new({
                            let v12 = v12.clone();
                            move || Documents::closure39(v12.clone(), ())
                        }),
                        Func0::new(move || Documents::closure6((), ())),
                    );
                    {
                        let v17: string = Documents::method13(sprintf!("[{}]", v12.clone()));
                        let v19: &str = fable_library_rust::String_::LrcStr::as_str(&v17);
                        String::from(v19)
                    }
                }
            };
            let v25: bool = true;
            v0_1.lock().unwrap().send(v23).unwrap();
            ()
        }
        pub fn method54(
            v0_1: std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>,
        ) -> Func1<Result<std::string::String, std::io::Error>, ()> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Result<std::string::String, std::io::Error>| {
                    Documents::closure38(v0_1.clone(), v)
                }
            })
        }
        pub fn closure40(unitVar: (), v0_1: std::process::Output) -> Documents::US16 {
            Documents::US16::US16_0(v0_1)
        }
        pub fn closure41(unitVar: (), v0_1: std::string::String) -> Documents::US16 {
            Documents::US16::US16_1(v0_1)
        }
        pub fn closure42(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("execute_with_options -2 / error: {}", v0_1)
        }
        pub fn closure43(v0_1: i32, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options / exit_code: {} / std_trace.Length: {}",
                v0_1,
                length(v1_1)
            )
        }
        pub fn method55(v0_: i32, v0__1: string) -> LrcPtr<(i32, string)> {
            LrcPtr::new((v0_, v0__1))
        }
        pub fn method39(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v3: Option<string>,
            v4: string,
            v5: Vec<std::string::String>,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32, string)>>>> {
            let __result = Box::pin(async move {
                //;
                {
                    let v8: std::process::Command = std::process::Command::new(&*v4);
                    let v10: bool = true;
                    let mut v8 = v8;
                    let v12: &mut std::process::Command =
                        std::process::Command::args(&mut v8, &*v5);
                    let v14: bool = true;
                    let mut v12 = v12;
                    let v16: &mut std::process::Command =
                        std::process::Command::stdout(&mut v12, std::process::Stdio::piped());
                    let v18: bool = true;
                    let mut v16 = v16;
                    let v20: &mut std::process::Command =
                        std::process::Command::stderr(&mut v16, std::process::Stdio::piped());
                    let v23: Documents::US7 =
                        defaultValue(Documents::US7::US7_1, map(Documents::method40(), v3));
                    let v29: &mut std::process::Command = match &v23 {
                        Documents::US7::US7_0(v23_0_0) => {
                            let v25: string = Documents::method41(match &v23 {
                                Documents::US7::US7_0(x) => x.clone(),
                                _ => unreachable!(),
                            });
                            std::process::Command::current_dir(v20, &*v25)
                        }
                        _ => v20,
                    };
                    let v31: bool = true;
                    let mut v29 = v29;
                    let v33: Result<std::process::Child, std::io::Error> =
                        std::process::Command::spawn(&mut v29);
                    let v34 = Documents::method42();
                    let v35: Result<std::process::Child, std::io::Error> = Documents::method44(v33);
                    let v37: Result<
                        std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                        std::io::Error,
                    > = v35.map(|x| v34(x));
                    let v38 = Documents::method21();
                    let v40: Result<
                        std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                        std::string::String,
                    > = v37.map_err(|x| v38(x));
                    let v43: Documents::US13 = match &v40 {
                        Err(v40_1_0) => Documents::closure31((), v40_1_0.clone()),
                        Ok(v40_0_0) => Documents::closure30((), v40_0_0.clone()),
                    };
                    let patternInput_1: (i32, Documents::US3, Documents::US14) = match &v43 {
                        Documents::US13::US13_0(v43_0_0) => {
                            let v45: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> =
                                Documents::method45(v43_0_0.clone());
                            let v47: std::process::ChildStdout =
                                v45.lock().unwrap().as_mut().unwrap().stdout.take().unwrap();
                            let v49: std::process::ChildStderr =
                                v45.lock().unwrap().as_mut().unwrap().stderr.take().unwrap();
                            let v53: std::sync::Mutex<Option<std::process::ChildStdout>> =
                                Documents::method46(std::sync::Mutex::new(Some(v47)));
                            let v55: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::ChildStdout>>,
                            > = std::sync::Arc::new(v53);
                            let v59: std::sync::Mutex<Option<std::process::ChildStderr>> =
                                Documents::method47(std::sync::Mutex::new(Some(v49)));
                            let v61: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::ChildStderr>>,
                            > = std::sync::Arc::new(v59);
                            let patternInput: (
                                std::sync::mpsc::Sender<std::string::String>,
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            ) = {
                                let (sender, receiver) = std::sync::mpsc::channel();
                                (sender, std::sync::Arc::new(receiver))
                            };
                            let v65: std::sync::Arc<
                                std::sync::mpsc::Receiver<std::string::String>,
                            > = Documents::method48(patternInput.1.clone());
                            let v67: bool = true;
                            let v65 = v65;
                            let v70: std::sync::Mutex<
                                std::sync::mpsc::Sender<std::string::String>,
                            > = Documents::method49(std::sync::Mutex::new(patternInput.0.clone()));
                            let v72: std::sync::Arc<
                                std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                            > = std::sync::Arc::new(v70);
                            let v74: std::sync::Arc<
                                std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                            > = v72.clone();
                            let v76: std::sync::Arc<
                                std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                            > = v72.clone();
                            let v79: std::sync::Mutex<
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            > = Documents::method50(std::sync::Mutex::new(v65));
                            let v81: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = std::sync::Arc::new(v79);
                            let v83: std::thread::JoinHandle<()> = std::thread::spawn(move || {
                                //;
                                let v85: std::io::Lines<
                                    std::io::BufReader<std::process::ChildStdout>,
                                > = std::io::BufRead::lines(std::io::BufReader::new(
                                    v55.lock().unwrap().take().unwrap(),
                                ));
                                let v88: std::sync::Mutex<
                                    std::io::Lines<std::io::BufReader<std::process::ChildStdout>>,
                                > = Documents::method51(std::sync::Mutex::new(v85));
                                let v90: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::io::Lines<
                                            std::io::BufReader<std::process::ChildStdout>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v88);
                                let v91 = Documents::method52(v74);
                                let v93: bool = true;
                                for line in v90.lock().unwrap().by_ref() {
                                    v91(line)
                                }
                                let v95: bool = true;
                            });
                            let v97: std::thread::JoinHandle<()> = std::thread::spawn(move || {
                                //;
                                let v99: std::io::Lines<
                                    std::io::BufReader<std::process::ChildStderr>,
                                > = std::io::BufRead::lines(std::io::BufReader::new(
                                    v61.lock().unwrap().take().unwrap(),
                                ));
                                let v102: std::sync::Mutex<
                                    std::io::Lines<std::io::BufReader<std::process::ChildStderr>>,
                                > = Documents::method53(std::sync::Mutex::new(v99));
                                let v104: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::io::Lines<
                                            std::io::BufReader<std::process::ChildStderr>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v102);
                                let v105 = Documents::method54(v72);
                                let v107: bool = true;
                                for line in v104.lock().unwrap().by_ref() {
                                    v105(line)
                                }
                                let v109: bool = true;
                            });
                            let v111: Result<std::process::Output, std::io::Error> =
                                v45.lock().unwrap().take().unwrap().wait_with_output();
                            let v112 = Documents::method21();
                            let v114: Result<std::process::Output, std::string::String> =
                                v111.map_err(|x| v112(x));
                            let v116: bool = true;
                            v83.join().unwrap();
                            let v118: bool = true;
                            v97.join().unwrap();
                            let v121: Documents::US16 = match &v114 {
                                Err(v114_1_0) => Documents::closure41((), v114_1_0.clone()),
                                Ok(v114_0_0) => Documents::closure40((), v114_0_0.clone()),
                            };
                            match &v121 {
                                Documents::US16::US16_0(v121_0_0) => (
                                    v121_0_0.clone().status.code().unwrap(),
                                    Documents::US3::US3_1,
                                    Documents::US14::US14_0(v81),
                                ),
                                Documents::US16::US16_1(v121_1_0) => {
                                    let v127: std::string::String = v121_1_0.clone();
                                    Documents::method3(
                                        Documents::US0::US0_4,
                                        Func0::new({
                                            let v127 = v127.clone();
                                            move || Documents::closure42(v127.clone(), ())
                                        }),
                                        Func0::new(move || Documents::closure6((), ())),
                                    );
                                    (
                                        -2_i32,
                                        Documents::US3::US3_0(v127.clone()),
                                        Documents::US14::US14_1,
                                    )
                                }
                            }
                        }
                        Documents::US13::US13_1(v43_1_0) => {
                            let v139: std::string::String = v43_1_0.clone();
                            Documents::method3(
                                Documents::US0::US0_4,
                                Func0::new({
                                    let v139 = v139.clone();
                                    move || Documents::closure32(v139.clone(), ())
                                }),
                                Func0::new(move || Documents::closure6((), ())),
                            );
                            (
                                -1_i32,
                                Documents::US3::US3_0(v139.clone()),
                                Documents::US14::US14_1,
                            )
                        }
                    };
                    let v150: Documents::US14 = patternInput_1.2.clone();
                    let v149: Documents::US3 = patternInput_1.1.clone();
                    let v148: i32 = patternInput_1.0.clone();
                    let v157: Documents::US3 = match &v150 {
                        Documents::US14::US14_0(v150_0_0) => Documents::US3::US3_0(
                            match &v150 {
                                Documents::US14::US14_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .lock()
                            .unwrap()
                            .iter()
                            .collect::<Vec<String>>()
                            .join("\n"),
                        ),
                        _ => Documents::US3::US3_1,
                    };
                    let v164: Documents::US7 = match &v157 {
                        Documents::US3::US3_0(v157_0_0) => Documents::US7::US7_0(
                            fable_library_rust::String_::fromString(match &v157 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                        ),
                        _ => Documents::US7::US7_1,
                    };
                    let v171: Documents::US7 = match &v149 {
                        Documents::US3::US3_0(v149_0_0) => Documents::US7::US7_0(
                            fable_library_rust::String_::fromString(match &v149 {
                                Documents::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                        ),
                        _ => Documents::US7::US7_1,
                    };
                    let v175: string = match &v171 {
                        Documents::US7::US7_0(v171_0_0) => match &v171 {
                            Documents::US7::US7_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => string(""),
                    };
                    let v178: string = match &v164 {
                        Documents::US7::US7_0(v164_0_0) => match &v164 {
                            Documents::US7::US7_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v175,
                    };
                    Documents::method3(
                        Documents::US0::US0_0,
                        Func0::new({
                            let v148 = v148.clone();
                            let v178 = v178.clone();
                            move || Documents::closure43(v148, v178.clone(), ())
                        }),
                        Func0::new(move || Documents::closure6((), ())),
                    );
                    {
                        let v182: LrcPtr<(i32, string)> = LrcPtr::new((v148, v178.clone()));
                        let v183: LrcPtr<(i32, string)> =
                            Documents::method55(v182.0.clone(), v182.1.clone());
                        v183
                    }
                }
            });
            {
                {
                    //;
                    __result
                }
            }
        }
        pub fn closure44(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v3: Option<string>,
            unitVar: (),
        ) -> string {
            sprintf!(
                "execute_with_options_async / options: {:?}",
                (v0_1, v1_1, v2, v3)
            )
        }
        pub fn closure46(
            unitVar: (),
            v0_1: Func1<(bool, string, i32), Arc<Async<()>>>,
        ) -> Documents::US17 {
            Documents::US17::US17_0(v0_1)
        }
        pub fn method56() -> Func1<Func1<(bool, string, i32), Arc<Async<()>>>, Documents::US17> {
            Func1::new(move |v: Func1<(bool, string, i32), Arc<Async<()>>>| {
                Documents::closure46((), v)
            })
        }
        pub fn closure47(v0_1: string, unitVar: ()) -> string {
            sprintf!("> {}", v0_1)
        }
        pub fn closure45(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v3: Option<string>,
            v4: (),
            v5: LrcPtr<ConcurrentStack_1<string>>,
            v6: (),
        ) {
            let _v7: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
            {
                let x: Arc<Async<()>> = defaultOf();
                _v7.set(Some(x))
            }
            {
                let v32: Arc<Async<()>> = getValue(_v7.get().clone());
                let _v33: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v33.set(Some(()));
                getValue(_v33.get().clone());
                ()
            }
        }
        pub fn closure48(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v3: Option<string>,
            v4: (),
            v5: LrcPtr<ConcurrentStack_1<string>>,
            v6: (),
        ) {
            let _v7: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
            {
                let x: Arc<Async<()>> = defaultOf();
                _v7.set(Some(x))
            }
            {
                let v33: Arc<Async<()>> = getValue(_v7.get().clone());
                let _v34: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v34.set(Some(()));
                getValue(_v34.get().clone());
                ()
            }
        }
        pub fn closure49(unitVar: (), v0_1: CancellationToken) -> Documents::US18 {
            Documents::US18::US18_0(v0_1)
        }
        pub fn method57() -> Func1<CancellationToken, Documents::US18> {
            Func1::new(move |v: CancellationToken| Documents::closure49((), v))
        }
        pub fn closure50(v0_1: (), unitVar: ()) {
            let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            {
                let x: bool = unbox::<bool>(&defaultOf());
                _v1.set(Some(x))
            }
            if getValue(_v1.get().clone()) == false {
                let _v11: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v11.set(Some(()));
                getValue(_v11.get().clone());
                ()
            }
        }
        pub fn closure51(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options_async / WaitForExitAsync / ex: {:?}",
                v0_1
            )
        }
        pub fn method58() -> string {
            string("\n")
        }
        pub fn closure52(v0_1: i32, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options_async / exit_code: {} / output.Length: {}",
                v0_1,
                length(v1_1)
            )
        }
        pub fn closure53(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / par_map")
        }
        pub fn closure54(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: i32,
            v5: string,
            v6: i32,
            v7: string,
            v8: string,
            unitVar: (),
        ) -> string {
            sprintf!("file: {} / real_path: {} / relative_path: {} / origin_hash_exit_code: {} / origin_hash: {} / local_git_hash_exit_code: {} / local_git_hash: {} / hash1: {} / hash2: {:?} / {}",
                     v0_1, v2, v1_1, v4, v3, v6, v5, v7, v8,
                     Documents::closure6((), ()))
        }
        pub fn closure55(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / par_map / crowbook")
        }
        pub fn closure56(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {:?} / result: {} / {}",
                v1_1,
                v0_1,
                Documents::closure6((), ())
            )
        }
        pub fn method59(v0_1: string) -> string {
            v0_1
        }
        pub fn closure57(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run / par_map / files")
        }
        pub fn closure58(v0_1: Array<Documents::US8>, unitVar: ()) -> string {
            sprintf!("files: {:?} / {}", v0_1, Documents::closure6((), ()))
        }
        pub fn closure23(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
        ) -> Result<(string, Array<Documents::US8>), std::string::String> {
            let _v4: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v6: string = Documents::method12(v3);
            let v7: string = Documents::method13(v6.clone());
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: std::path::PathBuf = std::path::PathBuf::from(v11);
            {
                let x_5: string = if v13.exists() == false {
                    let _v17: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v20: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
                    let v22: std::path::PathBuf = v20.unwrap();
                    let v24: std::path::Display = v22.display();
                    let _v25: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x: std::string::String = format!("{}", v24);
                        _v25.set(Some(x))
                    }
                    {
                        let v36: std::string::String = getValue(_v25.get().clone());
                        {
                            let x_1: string = fable_library_rust::String_::fromString(v36);
                            _v17.set(Some(x_1))
                        }
                        {
                            let _v46: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v48: string = Documents::method13(getValue(_v17.get().clone()));
                            let v50: &str = fable_library_rust::String_::LrcStr::as_str(&v48);
                            let v52: std::string::String = String::from(v50);
                            let v54: std::path::PathBuf = std::path::PathBuf::from(v52);
                            let v55: string = Documents::method13(v6.clone());
                            let v57: &str = fable_library_rust::String_::LrcStr::as_str(&v55);
                            let v59: std::string::String = String::from(v57);
                            let v61: std::path::PathBuf = v54.join(v59);
                            let v63: std::path::Display = v61.display();
                            let _v64: MutCell<Option<std::string::String>> =
                                MutCell::new(None::<std::string::String>);
                            {
                                let x_2: std::string::String = format!("{}", v63);
                                _v64.set(Some(x_2))
                            }
                            {
                                let v75: std::string::String = getValue(_v64.get().clone());
                                {
                                    let x_3: string = fable_library_rust::String_::fromString(v75);
                                    _v46.set(Some(x_3))
                                }
                                getValue(_v46.get().clone())
                            }
                        }
                    }
                } else {
                    let v90: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::canonicalize(&*v6);
                    let v92: std::path::PathBuf = v90.unwrap();
                    let v94: std::path::Display = v92.display();
                    let _v95: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_4: std::string::String = format!("{}", v94);
                        _v95.set(Some(x_4))
                    }
                    {
                        let v106: std::string::String = getValue(_v95.get().clone());
                        fable_library_rust::String_::fromString(v106)
                    }
                };
                _v4.set(Some(x_5))
            }
            {
                let v117: string = getValue(_v4.get().clone());
                let v118: string = Documents::method13(v117.clone());
                let v120: &str = fable_library_rust::String_::LrcStr::as_str(&v118);
                let v122: std::string::String = String::from(v120);
                let v124: std::path::PathBuf = std::path::PathBuf::from(v122);
                let v126: std::path::Display = v124.display();
                let _v127: MutCell<Option<std::string::String>> =
                    MutCell::new(None::<std::string::String>);
                {
                    let x_6: std::string::String = format!("{}", v126);
                    _v127.set(Some(x_6))
                }
                {
                    let v138: std::string::String = getValue(_v127.get().clone());
                    let v146: string = sprintf!(
                        ".{}",
                        replace(
                            replace(
                                fable_library_rust::String_::fromString(v138),
                                v1_1.clone(),
                                string("")
                            ),
                            string("\\"),
                            string("/")
                        )
                    );
                    let _v147: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v149: string = Documents::method13(v0_1.clone());
                    let v151: &str = fable_library_rust::String_::LrcStr::as_str(&v149);
                    let v153: std::string::String = String::from(v151);
                    let v155: std::path::PathBuf = std::path::PathBuf::from(v153);
                    let v156: string = Documents::method13(v146.clone());
                    let v158: &str = fable_library_rust::String_::LrcStr::as_str(&v156);
                    let v160: std::string::String = String::from(v158);
                    let v162: std::path::PathBuf = v155.join(v160);
                    let v164: std::path::Display = v162.display();
                    let _v165: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_7: std::string::String = format!("{}", v164);
                        _v165.set(Some(x_7))
                    }
                    {
                        let v176: std::string::String = getValue(_v165.get().clone());
                        {
                            let x_8: string = fable_library_rust::String_::fromString(v176);
                            _v147.set(Some(x_8))
                        }
                        {
                            let v189: string = getValue(_v147.get().clone());
                            let _v190: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                            {
                                let x_9: bool = cfg!(windows);
                                _v190.set(Some(x_9))
                            }
                            {
                                let v223: string = if getValue(_v190.get().clone()) == false {
                                    v189.clone()
                                } else {
                                    let _v203: MutCell<Option<string>> =
                                        MutCell::new(None::<string>);
                                    let v205: string = Documents::method26();
                                    let v206: string = Documents::method27(v189);
                                    let v207: string = Documents::method28();
                                    let v209: &str = &regex::Regex::new(&v205)
                                        .unwrap()
                                        .replace_all(&v206, &*v207);
                                    let v211: std::string::String = String::from(v209);
                                    {
                                        let x_10: string =
                                            fable_library_rust::String_::fromString(v211);
                                        _v203.set(Some(x_10))
                                    }
                                    {
                                        let v220: string = getValue(_v203.get().clone());
                                        replace(
                                            sprintf!(
                                                "{}{}",
                                                toLowerChar(getCharAt(v220.clone(), 0_i32)),
                                                getSlice(v220, Some(1_i32), None::<i32>)
                                            ),
                                            string("\\"),
                                            string("/"),
                                        )
                                    }
                                };
                                let v224: Option<CancellationToken> = None::<CancellationToken>;
                                let v225 = None::<Func1<(bool, string, i32), Arc<Async<()>>>>;
                                let v227: string = sprintf!(
                                    "git ls-tree --format=\'%(objectname)\' origin/gh-pages \"{}\"",
                                    v223.clone()
                                );
                                let v228: Option<string> = Some(v0_1);
                                let _v229: MutCell<Option<(i32, string)>> =
                                    MutCell::new(None::<(i32, string)>);
                                let patternInput: (string, string) = Documents::method29();
                                let v233: i32 = length(v227.clone());
                                let v234: Array<char> = new_init(&'\u{0000}', v233);
                                let v235: LrcPtr<Documents::Mut4> = LrcPtr::new(Documents::Mut4 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Documents::method30(v233, v235.clone()) {
                                    let v237: i32 = v235.l0.get().clone();
                                    let v238: char = getCharAt(v227.clone(), v237);
                                    v234.get_mut()[v237 as usize] = v238;
                                    {
                                        let v239: i32 = v237 + 1_i32;
                                        v235.l0.set(v239);
                                        ()
                                    }
                                }
                                {
                                    let v241: List<char> = ofArray(v234.clone());
                                    let patternInput_1: (string, string) = Documents::method32(
                                        patternInput.1.clone(),
                                        patternInput.0.clone(),
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Documents::UH0>| {
                                                    (Documents::method31())(b0)(b1)
                                                },
                                            ),
                                            v241,
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        ),
                                        Documents::US10::US10_0,
                                    );
                                    let v249: string = patternInput_1.0.clone();
                                    let v251: Array<string> =
                                        Documents::method33(patternInput_1.1.clone());
                                    let v253: Vec<string> = v251.to_vec();
                                    let v255 =
                                        Func1::new(move |v: string| Documents::closure26((), v));
                                    let v256: Vec<std::string::String> =
                                        v253.iter().map(|x| v255.clone()(x.clone())).collect();
                                    Documents::method3(
                                        Documents::US0::US0_1,
                                        Func0::new({
                                            let v224 = v224.clone();
                                            let v225 = v225.clone();
                                            let v227 = v227.clone();
                                            let v228 = v228.clone();
                                            let v249 = v249.clone();
                                            let v256 = v256.clone();
                                            move || {
                                                Documents::closure27(
                                                    v224.clone(),
                                                    v227.clone(),
                                                    v225.clone(),
                                                    v228.clone(),
                                                    v249.clone(),
                                                    v256.clone(),
                                                    (),
                                                )
                                            }
                                        }),
                                        Documents::method38(),
                                    );
                                    {
                                        let v260: std::pin::Pin<
                                            Box<
                                                dyn std::future::Future<
                                                    Output = LrcPtr<(i32, string)>,
                                                >,
                                            >,
                                        > = Documents::method39(
                                            v224.clone(),
                                            v227.clone(),
                                            v225.clone(),
                                            v228.clone(),
                                            v249.clone(),
                                            v256.clone(),
                                        );
                                        let v262: LrcPtr<(i32, string)> =
                                            futures_lite::future::block_on(v260);
                                        _v229.set(Some((v262.0.clone(), v262.1.clone())));
                                        {
                                            let patternInput_2: (i32, string) =
                                                getValue(_v229.get().clone());
                                            let v435: string = patternInput_2.1.clone();
                                            let _v436: MutCell<Option<string>> =
                                                MutCell::new(None::<string>);
                                            let v438: string = Documents::method13(v1_1.clone());
                                            let v440: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v438);
                                            let v442: std::string::String = String::from(v440);
                                            let v444: std::path::PathBuf =
                                                std::path::PathBuf::from(v442);
                                            let v445: string = Documents::method13(v146.clone());
                                            let v447: &str =
                                                fable_library_rust::String_::LrcStr::as_str(&v445);
                                            let v449: std::string::String = String::from(v447);
                                            let v451: std::path::PathBuf = v444.join(v449);
                                            let v453: std::path::Display = v451.display();
                                            let _v454: MutCell<Option<std::string::String>> =
                                                MutCell::new(None::<std::string::String>);
                                            {
                                                let x_12: std::string::String = format!("{}", v453);
                                                _v454.set(Some(x_12))
                                            }
                                            {
                                                let v465: std::string::String =
                                                    getValue(_v454.get().clone());
                                                {
                                                    let x_13: string =
                                                        fable_library_rust::String_::fromString(
                                                            v465,
                                                        );
                                                    _v436.set(Some(x_13))
                                                }
                                                {
                                                    let v477: string =
                                                        getValue(_v436.get().clone());
                                                    let _v478: MutCell<Option<bool>> =
                                                        MutCell::new(None::<bool>);
                                                    {
                                                        let x_14: bool = cfg!(windows);
                                                        _v478.set(Some(x_14))
                                                    }
                                                    {
                                                        let v511: string = if getValue(
                                                            _v478.get().clone(),
                                                        ) == false
                                                        {
                                                            v477.clone()
                                                        } else {
                                                            let _v491: MutCell<Option<string>> =
                                                                MutCell::new(None::<string>);
                                                            let v493: string =
                                                                Documents::method26();
                                                            let v494: string =
                                                                Documents::method27(v477);
                                                            let v495: string =
                                                                Documents::method28();
                                                            let v497: &str =
                                                                &regex::Regex::new(&v493)
                                                                    .unwrap()
                                                                    .replace_all(&v494, &*v495);
                                                            let v499: std::string::String =
                                                                String::from(v497);
                                                            {
                                                                let x_15:
                                                                            string =
                                                                        fable_library_rust::String_::fromString(v499);
                                                                _v491.set(Some(x_15))
                                                            }
                                                            {
                                                                let v508: string =
                                                                    getValue(_v491.get().clone());
                                                                replace(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        toLowerChar(getCharAt(
                                                                            v508.clone(),
                                                                            0_i32
                                                                        )),
                                                                        getSlice(
                                                                            v508,
                                                                            Some(1_i32),
                                                                            None::<i32>
                                                                        )
                                                                    ),
                                                                    string("\\"),
                                                                    string("/"),
                                                                )
                                                            }
                                                        };
                                                        let v512: Option<CancellationToken> =
                                                            None::<CancellationToken>;
                                                        let v513 = None::<
                                                            Func1<
                                                                (bool, string, i32),
                                                                Arc<Async<()>>,
                                                            >,
                                                        >;
                                                        let v515: string = sprintf!(
                                                            "git hash-object \"{}\"",
                                                            v511.clone()
                                                        );
                                                        let v516: Option<string> =
                                                            Some(v1_1.clone());
                                                        let _v517: MutCell<Option<(i32, string)>> =
                                                            MutCell::new(None::<(i32, string)>);
                                                        let patternInput_3: (string, string) =
                                                            Documents::method29();
                                                        let v521: i32 = length(v515.clone());
                                                        let v522: Array<char> =
                                                            new_init(&'\u{0000}', v521);
                                                        let v523: LrcPtr<Documents::Mut4> =
                                                            LrcPtr::new(Documents::Mut4 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                        while Documents::method30(
                                                            v521,
                                                            v523.clone(),
                                                        ) {
                                                            let v525: i32 = v523.l0.get().clone();
                                                            let v526: char =
                                                                getCharAt(v515.clone(), v525);
                                                            v522.get_mut()[v525 as usize] = v526;
                                                            {
                                                                let v527: i32 = v525 + 1_i32;
                                                                v523.l0.set(v527);
                                                                ()
                                                            }
                                                        }
                                                        {
                                                            let v529: List<char> =
                                                                ofArray(v522.clone());
                                                            let patternInput_4:
                                                                    (string,
                                                                     string) =
                                                                Documents::method32(patternInput_3.1.clone(),
                                                                                    patternInput_3.0.clone(),
                                                                                    foldBack(Func2::new(move
                                                                                                            |b0:
                                                                                                                 char,
                                                                                                             b1:
                                                                                                                 LrcPtr<Documents::UH0>|
                                                                                                            (Documents::method31())(b0)(b1)),
                                                                                             v529,
                                                                                             LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                    Documents::US10::US10_0);
                                                            let v537: string =
                                                                patternInput_4.0.clone();
                                                            let v539: Array<string> =
                                                                Documents::method33(
                                                                    patternInput_4.1.clone(),
                                                                );
                                                            let v541: Vec<string> = v539.to_vec();
                                                            let v543: Vec<std::string::String> =
                                                                v541.iter()
                                                                    .map(|x| {
                                                                        v255.clone()(x.clone())
                                                                    })
                                                                    .collect();
                                                            Documents::method3(
                                                                Documents::US0::US0_1,
                                                                Func0::new({
                                                                    let v512 = v512.clone();
                                                                    let v513 = v513.clone();
                                                                    let v515 = v515.clone();
                                                                    let v516 = v516.clone();
                                                                    let v537 = v537.clone();
                                                                    let v543 = v543.clone();
                                                                    move || {
                                                                        Documents::closure27(
                                                                            v512.clone(),
                                                                            v515.clone(),
                                                                            v513.clone(),
                                                                            v516.clone(),
                                                                            v537.clone(),
                                                                            v543.clone(),
                                                                            (),
                                                                        )
                                                                    }
                                                                }),
                                                                Documents::method38(),
                                                            );
                                                            {
                                                                let v547: std::pin::Pin<
                                                                    Box<
                                                                        dyn std::future::Future<
                                                                            Output = LrcPtr<(
                                                                                i32,
                                                                                string,
                                                                            )>,
                                                                        >,
                                                                    >,
                                                                > = Documents::method39(
                                                                    v512.clone(),
                                                                    v515.clone(),
                                                                    v513.clone(),
                                                                    v516.clone(),
                                                                    v537.clone(),
                                                                    v543.clone(),
                                                                );
                                                                let v549: LrcPtr<(i32, string)> =
                                                                    futures_lite::future::block_on(
                                                                        v547,
                                                                    );
                                                                _v517.set(Some((
                                                                    v549.0.clone(),
                                                                    v549.1.clone(),
                                                                )));
                                                                {
                                                                    let patternInput_5: (
                                                                        i32,
                                                                        string,
                                                                    ) = getValue(
                                                                        _v517.get().clone(),
                                                                    );
                                                                    let v722: string =
                                                                        patternInput_5.1.clone();
                                                                    Ok::<
                                                                        (
                                                                            string,
                                                                            Array<Documents::US8>,
                                                                        ),
                                                                        std::string::String,
                                                                    >(
                                                                        (
                                                                        v117.clone(),
                                                                        if contains(
                                                                            v435.clone(),
                                                                            v722.clone(),
                                                                        ) == false
                                                                        {
                                                                            let _v725: MutCell<
                                                                                Option<bool>,
                                                                            > = MutCell::new(
                                                                                None::<bool>,
                                                                            );
                                                                            {
                                                                                let x_17: bool =
                                                                                    cfg!(windows);
                                                                                _v725
                                                                                    .set(Some(x_17))
                                                                            }
                                                                            {
                                                                                let v759:
                                                                                                               Option<CancellationToken> =
                                                                                                           None::<CancellationToken>;
                                                                                let v760 = None::<
                                                                                    Func1<
                                                                                        (
                                                                                            bool,
                                                                                            string,
                                                                                            i32,
                                                                                        ),
                                                                                        Arc<
                                                                                            Async<
                                                                                                (),
                                                                                            >,
                                                                                        >,
                                                                                    >,
                                                                                >;
                                                                                let v761: Option<
                                                                                    string,
                                                                                > = None::<string>;
                                                                                let v762:
                                                                                                               string =
                                                                                                           sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                    if getValue(_v725.get().clone())
                                                                                                                           ==
                                                                                                                           false
                                                                                                                       {
                                                                                                                        v511.clone()
                                                                                                                    } else {
                                                                                                                        let _v738:
                                                                                                                                MutCell<Option<string>> =
                                                                                                                            MutCell::new(None::<string>);
                                                                                                                        let v740:
                                                                                                                                string =
                                                                                                                            Documents::method26();
                                                                                                                        let v741:
                                                                                                                                string =
                                                                                                                            Documents::method27(v511.clone());
                                                                                                                        let v742:
                                                                                                                                string =
                                                                                                                            Documents::method28();
                                                                                                                        let v744:
                                                                                                                                &str =
                                                                                                                            &regex::Regex::new(&v740).unwrap().replace_all(&v741, &*v742);
                                                                                                                        let v746:
                                                                                                                                std::string::String =
                                                                                                                            String::from(v744);
                                                                                                                        {
                                                                                                                            let x_18:
                                                                                                                                    string =
                                                                                                                                fable_library_rust::String_::fromString(v746);
                                                                                                                            _v738.set(Some(x_18))
                                                                                                                        }
                                                                                                                        {
                                                                                                                            let v755:
                                                                                                                                    string =
                                                                                                                                getValue(_v738.get().clone());
                                                                                                                            replace(sprintf!("{}{}",
                                                                                                                                             toLowerChar(getCharAt(v755.clone(),
                                                                                                                                                                   0_i32)),
                                                                                                                                             getSlice(v755,
                                                                                                                                                      Some(1_i32),
                                                                                                                                                      None::<i32>)),
                                                                                                                                    string("\\"),
                                                                                                                                    string("/"))
                                                                                                                        }
                                                                                                                    });
                                                                                let _v763: MutCell<
                                                                                    Option<(
                                                                                        i32,
                                                                                        string,
                                                                                    )>,
                                                                                > = MutCell::new(
                                                                                    None::<(
                                                                                        i32,
                                                                                        string,
                                                                                    )>,
                                                                                );
                                                                                let patternInput_6:
                                                                                                               (string,
                                                                                                                string) =
                                                                                                           Documents::method29();
                                                                                let v767: i32 =
                                                                                    length(
                                                                                        v762.clone(
                                                                                        ),
                                                                                    );
                                                                                let v768: Array<
                                                                                    char,
                                                                                > = new_init(
                                                                                    &'\u{0000}',
                                                                                    v767,
                                                                                );
                                                                                let v769:
                                                                                                               LrcPtr<Documents::Mut4> =
                                                                                                           LrcPtr::new(Documents::Mut4{l0:
                                                                                                                                           MutCell::new(0_i32),});
                                                                                while Documents::method30(v767,
                                                                                                                                 v769.clone())
                                                                                                             {
                                                                                                           let v771:
                                                                                                                   i32 =
                                                                                                               v769.l0.get().clone();
                                                                                                           let v772:
                                                                                                                   char =
                                                                                                               getCharAt(v762.clone(),
                                                                                                                         v771);
                                                                                                           v768.get_mut()[v771
                                                                                                                              as
                                                                                                                              usize]
                                                                                                               =
                                                                                                               v772;
                                                                                                           {
                                                                                                               let v773:
                                                                                                                       i32 =
                                                                                                                   v771
                                                                                                                       +
                                                                                                                       1_i32;
                                                                                                               v769.l0.set(v773);
                                                                                                               ()
                                                                                                           }
                                                                                                       }
                                                                                {
                                                                                    let v775: List<
                                                                                        char,
                                                                                    > = ofArray(
                                                                                        v768.clone(
                                                                                        ),
                                                                                    );
                                                                                    let patternInput_7:
                                                                                                                   (string,
                                                                                                                    string) =
                                                                                                               Documents::method32(patternInput_6.1.clone(),
                                                                                                                                   patternInput_6.0.clone(),
                                                                                                                                   foldBack(Func2::new(move
                                                                                                                                                           |b0:
                                                                                                                                                                char,
                                                                                                                                                            b1:
                                                                                                                                                                LrcPtr<Documents::UH0>|
                                                                                                                                                           (Documents::method31())(b0)(b1)),
                                                                                                                                            v775,
                                                                                                                                            LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                   Documents::US10::US10_0);
                                                                                    let v783:
                                                                                                                   string =
                                                                                                               patternInput_7.0.clone();
                                                                                    let v785:
                                                                                                                   Array<string> =
                                                                                                               Documents::method33(patternInput_7.1.clone());
                                                                                    let v787: Vec<
                                                                                        string,
                                                                                    > = v785
                                                                                        .to_vec();
                                                                                    let v789:
                                                                                                                   Vec<std::string::String> =
                                                                                                               v787.iter().map(|x| v255.clone()(x.clone())).collect();
                                                                                    Documents::method3(Documents::US0::US0_1,
                                                                                                                              Func0::new({
                                                                                                                                             let v759
                                                                                                                                                 =
                                                                                                                                                 v759.clone();
                                                                                                                                             let v760
                                                                                                                                                 =
                                                                                                                                                 v760.clone();
                                                                                                                                             let v761
                                                                                                                                                 =
                                                                                                                                                 v761.clone();
                                                                                                                                             let v762
                                                                                                                                                 =
                                                                                                                                                 v762.clone();
                                                                                                                                             let v783
                                                                                                                                                 =
                                                                                                                                                 v783.clone();
                                                                                                                                             let v789
                                                                                                                                                 =
                                                                                                                                                 v789.clone();
                                                                                                                                             move
                                                                                                                                                 ||
                                                                                                                                                 Documents::closure27(v759.clone(),
                                                                                                                                                                      v762.clone(),
                                                                                                                                                                      v760.clone(),
                                                                                                                                                                      v761.clone(),
                                                                                                                                                                      v783.clone(),
                                                                                                                                                                      v789.clone(),
                                                                                                                                                                      ())
                                                                                                                                         }),
                                                                                                                              Documents::method38());
                                                                                    {
                                                                                        let v793:
                                                                                                                       std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                  string)>>>> =
                                                                                                                   Documents::method39(v759.clone(),
                                                                                                                                       v762.clone(),
                                                                                                                                       v760.clone(),
                                                                                                                                       v761.clone(),
                                                                                                                                       v783.clone(),
                                                                                                                                       v789.clone());
                                                                                        let v795:
                                                                                                                       LrcPtr<(i32,
                                                                                                                               string)> =
                                                                                                                   futures_lite::future::block_on(v793);
                                                                                        _v763.set(Some((v795.0.clone(),
                                                                                                                               v795.1.clone())));
                                                                                        {
                                                                                            let v968:
                                                                                                                           string =
                                                                                                                       (getValue(_v763.get().clone())).1.clone();
                                                                                            let _v969:
                                                                                                                           MutCell<Option<string>> =
                                                                                                                       MutCell::new(None::<string>);
                                                                                            let v971:
                                                                                                                           string =
                                                                                                                       Documents::method13(v2);
                                                                                            let v973:
                                                                                                                           &str =
                                                                                                                       fable_library_rust::String_::LrcStr::as_str(&v971);
                                                                                            let v975:
                                                                                                                           std::string::String =
                                                                                                                       String::from(v973);
                                                                                            let v977:
                                                                                                                           std::path::PathBuf =
                                                                                                                       std::path::PathBuf::from(v975);
                                                                                            let v978:
                                                                                                                           string =
                                                                                                                       Documents::method13(v146.clone());
                                                                                            let v980:
                                                                                                                           &str =
                                                                                                                       fable_library_rust::String_::LrcStr::as_str(&v978);
                                                                                            let v982:
                                                                                                                           std::string::String =
                                                                                                                       String::from(v980);
                                                                                            let v984:
                                                                                                                           std::path::PathBuf =
                                                                                                                       v977.join(v982);
                                                                                            let v986:
                                                                                                                           std::path::Display =
                                                                                                                       v984.display();
                                                                                            let _v987:
                                                                                                                           MutCell<Option<std::string::String>> =
                                                                                                                       MutCell::new(None::<std::string::String>);
                                                                                            {
                                                                                                let x_20:
                                                                                                                               std::string::String =
                                                                                                                           format!("{}", v986);
                                                                                                _v987.set(Some(x_20))
                                                                                            }
                                                                                            {
                                                                                                let v998:
                                                                                                                               std::string::String =
                                                                                                                           getValue(_v987.get().clone());
                                                                                                {
                                                                                                    let x_21:
                                                                                                                                   string =
                                                                                                                               fable_library_rust::String_::fromString(v998);
                                                                                                    _v969.set(Some(x_21))
                                                                                                }
                                                                                                {
                                                                                                    let v1010:
                                                                                                                                   string =
                                                                                                                               getValue(_v969.get().clone());
                                                                                                    let _v1011:
                                                                                                                                   MutCell<Option<bool>> =
                                                                                                                               MutCell::new(None::<bool>);
                                                                                                    {
                                                                                                        let x_22:
                                                                                                                                       bool =
                                                                                                                                   cfg!(windows);
                                                                                                        _v1011.set(Some(x_22))
                                                                                                    }
                                                                                                    {
                                                                                                        let v1044:
                                                                                                                                       string =
                                                                                                                                   if getValue(_v1011.get().clone())
                                                                                                                                          ==
                                                                                                                                          false
                                                                                                                                      {
                                                                                                                                       v1010.clone()
                                                                                                                                   } else {
                                                                                                                                       let _v1024:
                                                                                                                                               MutCell<Option<string>> =
                                                                                                                                           MutCell::new(None::<string>);
                                                                                                                                       let v1026:
                                                                                                                                               string =
                                                                                                                                           Documents::method26();
                                                                                                                                       let v1027:
                                                                                                                                               string =
                                                                                                                                           Documents::method27(v1010);
                                                                                                                                       let v1028:
                                                                                                                                               string =
                                                                                                                                           Documents::method28();
                                                                                                                                       let v1030:
                                                                                                                                               &str =
                                                                                                                                           &regex::Regex::new(&v1026).unwrap().replace_all(&v1027, &*v1028);
                                                                                                                                       let v1032:
                                                                                                                                               std::string::String =
                                                                                                                                           String::from(v1030);
                                                                                                                                       {
                                                                                                                                           let x_23:
                                                                                                                                                   string =
                                                                                                                                               fable_library_rust::String_::fromString(v1032);
                                                                                                                                           _v1024.set(Some(x_23))
                                                                                                                                       }
                                                                                                                                       {
                                                                                                                                           let v1041:
                                                                                                                                                   string =
                                                                                                                                               getValue(_v1024.get().clone());
                                                                                                                                           replace(sprintf!("{}{}",
                                                                                                                                                            toLowerChar(getCharAt(v1041.clone(),
                                                                                                                                                                                  0_i32)),
                                                                                                                                                            getSlice(v1041,
                                                                                                                                                                     Some(1_i32),
                                                                                                                                                                     None::<i32>)),
                                                                                                                                                   string("\\"),
                                                                                                                                                   string("/"))
                                                                                                                                       }
                                                                                                                                   };
                                                                                                        let _v1045:
                                                                                                                                       MutCell<Option<bool>> =
                                                                                                                                   MutCell::new(None::<bool>);
                                                                                                        let v1047:
                                                                                                                                       string =
                                                                                                                                   Documents::method13(v1044.clone());
                                                                                                        let v1049:
                                                                                                                                       &str =
                                                                                                                                   fable_library_rust::String_::LrcStr::as_str(&v1047);
                                                                                                        let v1051:
                                                                                                                                       std::string::String =
                                                                                                                                   String::from(v1049);
                                                                                                        let v1053:
                                                                                                                                       std::path::PathBuf =
                                                                                                                                   std::path::PathBuf::from(v1051);
                                                                                                        {
                                                                                                            let x_24:
                                                                                                                                           bool =
                                                                                                                                       if v1053.clone().exists()
                                                                                                                                          {
                                                                                                                                           v1053.is_file()
                                                                                                                                       } else {
                                                                                                                                           false
                                                                                                                                       };
                                                                                                            _v1045.set(Some(x_24))
                                                                                                        }
                                                                                                        {
                                                                                                            let v1313:
                                                                                                                                           string =
                                                                                                                                       if getValue(_v1045.get().clone())
                                                                                                                                          {
                                                                                                                                           let _v1069:
                                                                                                                                                   MutCell<Option<bool>> =
                                                                                                                                               MutCell::new(None::<bool>);
                                                                                                                                           {
                                                                                                                                               let x_25:
                                                                                                                                                       bool =
                                                                                                                                                   cfg!(windows);
                                                                                                                                               _v1069.set(Some(x_25))
                                                                                                                                           }
                                                                                                                                           {
                                                                                                                                               let v1103:
                                                                                                                                                       Option<CancellationToken> =
                                                                                                                                                   None::<CancellationToken>;
                                                                                                                                               let v1104 =
                                                                                                                                                   None::<Func1<(bool,
                                                                                                                                                                 string,
                                                                                                                                                                 i32),
                                                                                                                                                                Arc<Async<()>>>>;
                                                                                                                                               let v1105:
                                                                                                                                                       Option<string> =
                                                                                                                                                   None::<string>;
                                                                                                                                               let v1106:
                                                                                                                                                       string =
                                                                                                                                                   sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                            if getValue(_v1069.get().clone())
                                                                                                                                                                   ==
                                                                                                                                                                   false
                                                                                                                                                               {
                                                                                                                                                                v1044.clone()
                                                                                                                                                            } else {
                                                                                                                                                                let _v1082:
                                                                                                                                                                        MutCell<Option<string>> =
                                                                                                                                                                    MutCell::new(None::<string>);
                                                                                                                                                                let v1084:
                                                                                                                                                                        string =
                                                                                                                                                                    Documents::method26();
                                                                                                                                                                let v1085:
                                                                                                                                                                        string =
                                                                                                                                                                    Documents::method27(v1044.clone());
                                                                                                                                                                let v1086:
                                                                                                                                                                        string =
                                                                                                                                                                    Documents::method28();
                                                                                                                                                                let v1088:
                                                                                                                                                                        &str =
                                                                                                                                                                    &regex::Regex::new(&v1084).unwrap().replace_all(&v1085, &*v1086);
                                                                                                                                                                let v1090:
                                                                                                                                                                        std::string::String =
                                                                                                                                                                    String::from(v1088);
                                                                                                                                                                {
                                                                                                                                                                    let x_26:
                                                                                                                                                                            string =
                                                                                                                                                                        fable_library_rust::String_::fromString(v1090);
                                                                                                                                                                    _v1082.set(Some(x_26))
                                                                                                                                                                }
                                                                                                                                                                {
                                                                                                                                                                    let v1099:
                                                                                                                                                                            string =
                                                                                                                                                                        getValue(_v1082.get().clone());
                                                                                                                                                                    replace(sprintf!("{}{}",
                                                                                                                                                                                     toLowerChar(getCharAt(v1099.clone(),
                                                                                                                                                                                                           0_i32)),
                                                                                                                                                                                     getSlice(v1099,
                                                                                                                                                                                              Some(1_i32),
                                                                                                                                                                                              None::<i32>)),
                                                                                                                                                                            string("\\"),
                                                                                                                                                                            string("/"))
                                                                                                                                                                }
                                                                                                                                                            });
                                                                                                                                               let _v1107:
                                                                                                                                                       MutCell<Option<(i32,
                                                                                                                                                                       string)>> =
                                                                                                                                                   MutCell::new(None::<(i32,
                                                                                                                                                                        string)>);
                                                                                                                                               let patternInput_9:
                                                                                                                                                       (string,
                                                                                                                                                        string) =
                                                                                                                                                   Documents::method29();
                                                                                                                                               let v1111:
                                                                                                                                                       i32 =
                                                                                                                                                   length(v1106.clone());
                                                                                                                                               let v1112:
                                                                                                                                                       Array<char> =
                                                                                                                                                   new_init(&'\u{0000}',
                                                                                                                                                            v1111);
                                                                                                                                               let v1113:
                                                                                                                                                       LrcPtr<Documents::Mut4> =
                                                                                                                                                   LrcPtr::new(Documents::Mut4{l0:
                                                                                                                                                                                   MutCell::new(0_i32),});
                                                                                                                                               while Documents::method30(v1111,
                                                                                                                                                                         v1113.clone())
                                                                                                                                                     {
                                                                                                                                                   let v1115:
                                                                                                                                                           i32 =
                                                                                                                                                       v1113.l0.get().clone();
                                                                                                                                                   let v1116:
                                                                                                                                                           char =
                                                                                                                                                       getCharAt(v1106.clone(),
                                                                                                                                                                 v1115);
                                                                                                                                                   v1112.get_mut()[v1115
                                                                                                                                                                       as
                                                                                                                                                                       usize]
                                                                                                                                                       =
                                                                                                                                                       v1116;
                                                                                                                                                   {
                                                                                                                                                       let v1117:
                                                                                                                                                               i32 =
                                                                                                                                                           v1115
                                                                                                                                                               +
                                                                                                                                                               1_i32;
                                                                                                                                                       v1113.l0.set(v1117);
                                                                                                                                                       ()
                                                                                                                                                   }
                                                                                                                                               }
                                                                                                                                               {
                                                                                                                                                   let v1119:
                                                                                                                                                           List<char> =
                                                                                                                                                       ofArray(v1112.clone());
                                                                                                                                                   let patternInput_10:
                                                                                                                                                           (string,
                                                                                                                                                            string) =
                                                                                                                                                       Documents::method32(patternInput_9.1.clone(),
                                                                                                                                                                           patternInput_9.0.clone(),
                                                                                                                                                                           foldBack(Func2::new(move
                                                                                                                                                                                                   |b0:
                                                                                                                                                                                                        char,
                                                                                                                                                                                                    b1:
                                                                                                                                                                                                        LrcPtr<Documents::UH0>|
                                                                                                                                                                                                   (Documents::method31())(b0)(b1)),
                                                                                                                                                                                    v1119,
                                                                                                                                                                                    LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                           Documents::US10::US10_0);
                                                                                                                                                   let v1127:
                                                                                                                                                           string =
                                                                                                                                                       patternInput_10.0.clone();
                                                                                                                                                   let v1129:
                                                                                                                                                           Array<string> =
                                                                                                                                                       Documents::method33(patternInput_10.1.clone());
                                                                                                                                                   let v1131:
                                                                                                                                                           Vec<string> =
                                                                                                                                                       v1129.to_vec();
                                                                                                                                                   let v1133:
                                                                                                                                                           Vec<std::string::String> =
                                                                                                                                                       v1131.iter().map(|x| v255.clone()(x.clone())).collect();
                                                                                                                                                   Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                      Func0::new({
                                                                                                                                                                                     let v1103
                                                                                                                                                                                         =
                                                                                                                                                                                         v1103.clone();
                                                                                                                                                                                     let v1104
                                                                                                                                                                                         =
                                                                                                                                                                                         v1104.clone();
                                                                                                                                                                                     let v1105
                                                                                                                                                                                         =
                                                                                                                                                                                         v1105.clone();
                                                                                                                                                                                     let v1106
                                                                                                                                                                                         =
                                                                                                                                                                                         v1106.clone();
                                                                                                                                                                                     let v1127
                                                                                                                                                                                         =
                                                                                                                                                                                         v1127.clone();
                                                                                                                                                                                     let v1133
                                                                                                                                                                                         =
                                                                                                                                                                                         v1133.clone();
                                                                                                                                                                                     move
                                                                                                                                                                                         ||
                                                                                                                                                                                         Documents::closure27(v1103.clone(),
                                                                                                                                                                                                              v1106.clone(),
                                                                                                                                                                                                              v1104.clone(),
                                                                                                                                                                                                              v1105.clone(),
                                                                                                                                                                                                              v1127.clone(),
                                                                                                                                                                                                              v1133.clone(),
                                                                                                                                                                                                              ())
                                                                                                                                                                                 }),
                                                                                                                                                                      Documents::method38());
                                                                                                                                                   {
                                                                                                                                                       let v1137:
                                                                                                                                                               std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                          string)>>>> =
                                                                                                                                                           Documents::method39(v1103.clone(),
                                                                                                                                                                               v1106.clone(),
                                                                                                                                                                               v1104.clone(),
                                                                                                                                                                               v1105.clone(),
                                                                                                                                                                               v1127.clone(),
                                                                                                                                                                               v1133.clone());
                                                                                                                                                       let v1139:
                                                                                                                                                               LrcPtr<(i32,
                                                                                                                                                                       string)> =
                                                                                                                                                           futures_lite::future::block_on(v1137);
                                                                                                                                                       _v1107.set(Some((v1139.0.clone(),
                                                                                                                                                                        v1139.1.clone())));
                                                                                                                                                       (getValue(_v1107.get().clone())).1.clone()
                                                                                                                                                   }
                                                                                                                                               }
                                                                                                                                           }
                                                                                                                                       } else {
                                                                                                                                           string("")
                                                                                                                                       };
                                                                                                            Documents::method3(Documents::US0::US0_2,
                                                                                                                                                      Func0::new(move
                                                                                                                                                                     ||
                                                                                                                                                                     Documents::closure53((),
                                                                                                                                                                                          ())),
                                                                                                                                                      Func0::new({
                                                                                                                                                                     let patternInput_2
                                                                                                                                                                         =
                                                                                                                                                                         patternInput_2.clone();
                                                                                                                                                                     let patternInput_5
                                                                                                                                                                         =
                                                                                                                                                                         patternInput_5.clone();
                                                                                                                                                                     let v117
                                                                                                                                                                         =
                                                                                                                                                                         v117.clone();
                                                                                                                                                                     let v1313
                                                                                                                                                                         =
                                                                                                                                                                         v1313.clone();
                                                                                                                                                                     let v146
                                                                                                                                                                         =
                                                                                                                                                                         v146.clone();
                                                                                                                                                                     let v223
                                                                                                                                                                         =
                                                                                                                                                                         v223.clone();
                                                                                                                                                                     let v435
                                                                                                                                                                         =
                                                                                                                                                                         v435.clone();
                                                                                                                                                                     let v722
                                                                                                                                                                         =
                                                                                                                                                                         v722.clone();
                                                                                                                                                                     let v968
                                                                                                                                                                         =
                                                                                                                                                                         v968.clone();
                                                                                                                                                                     move
                                                                                                                                                                         ||
                                                                                                                                                                         Documents::closure54(v117.clone(),
                                                                                                                                                                                              v146.clone(),
                                                                                                                                                                                              v223.clone(),
                                                                                                                                                                                              v435.clone(),
                                                                                                                                                                                              patternInput_2.0.clone(),
                                                                                                                                                                                              v722.clone(),
                                                                                                                                                                                              patternInput_5.0.clone(),
                                                                                                                                                                                              v968.clone(),
                                                                                                                                                                                              v1313.clone(),
                                                                                                                                                                                              ())
                                                                                                                                                                 }));
                                                                                                            if v968.clone()
                                                                                                                                          !=
                                                                                                                                          v1313.clone()
                                                                                                                                      {
                                                                                                                                       let v1319:
                                                                                                                                               string =
                                                                                                                                           sprintf!("{}.{}",
                                                                                                                                                    v511.clone(),
                                                                                                                                                    string("epub"));
                                                                                                                                       let v1320:
                                                                                                                                               string =
                                                                                                                                           sprintf!("{}.{}",
                                                                                                                                                    v1044.clone(),
                                                                                                                                                    string("epub"));
                                                                                                                                       let _v1321:
                                                                                                                                               MutCell<Option<bool>> =
                                                                                                                                           MutCell::new(None::<bool>);
                                                                                                                                       let v1323:
                                                                                                                                               string =
                                                                                                                                           Documents::method13(v1319.clone());
                                                                                                                                       let v1325:
                                                                                                                                               &str =
                                                                                                                                           fable_library_rust::String_::LrcStr::as_str(&v1323);
                                                                                                                                       let v1327:
                                                                                                                                               std::string::String =
                                                                                                                                           String::from(v1325);
                                                                                                                                       let v1329:
                                                                                                                                               std::path::PathBuf =
                                                                                                                                           std::path::PathBuf::from(v1327);
                                                                                                                                       {
                                                                                                                                           let x_28:
                                                                                                                                                   bool =
                                                                                                                                               if v1329.clone().exists()
                                                                                                                                                  {
                                                                                                                                                   v1329.is_file()
                                                                                                                                               } else {
                                                                                                                                                   false
                                                                                                                                               };
                                                                                                                                           _v1321.set(Some(x_28))
                                                                                                                                       }
                                                                                                                                       {
                                                                                                                                           let v2090:
                                                                                                                                                   Documents::US8 =
                                                                                                                                               if (if if getValue(_v1321.get().clone())
                                                                                                                                                         {
                                                                                                                                                          let _v1344:
                                                                                                                                                                  MutCell<Option<bool>> =
                                                                                                                                                              MutCell::new(None::<bool>);
                                                                                                                                                          let v1346:
                                                                                                                                                                  string =
                                                                                                                                                              Documents::method13(v1320.clone());
                                                                                                                                                          let v1348:
                                                                                                                                                                  &str =
                                                                                                                                                              fable_library_rust::String_::LrcStr::as_str(&v1346);
                                                                                                                                                          let v1350:
                                                                                                                                                                  std::string::String =
                                                                                                                                                              String::from(v1348);
                                                                                                                                                          let v1352:
                                                                                                                                                                  std::path::PathBuf =
                                                                                                                                                              std::path::PathBuf::from(v1350);
                                                                                                                                                          {
                                                                                                                                                              let x_29:
                                                                                                                                                                      bool =
                                                                                                                                                                  if v1352.clone().exists()
                                                                                                                                                                     {
                                                                                                                                                                      v1352.is_file()
                                                                                                                                                                  } else {
                                                                                                                                                                      false
                                                                                                                                                                  };
                                                                                                                                                              _v1344.set(Some(x_29))
                                                                                                                                                          }
                                                                                                                                                          getValue(_v1344.get().clone())
                                                                                                                                                      } else {
                                                                                                                                                          false
                                                                                                                                                      }
                                                                                                                                                      {
                                                                                                                                                       let _v1368:
                                                                                                                                                               MutCell<Option<bool>> =
                                                                                                                                                           MutCell::new(None::<bool>);
                                                                                                                                                       {
                                                                                                                                                           let x_30:
                                                                                                                                                                   bool =
                                                                                                                                                               cfg!(windows);
                                                                                                                                                           _v1368.set(Some(x_30))
                                                                                                                                                       }
                                                                                                                                                       {
                                                                                                                                                           let v1402:
                                                                                                                                                                   Option<CancellationToken> =
                                                                                                                                                               None::<CancellationToken>;
                                                                                                                                                           let v1403 =
                                                                                                                                                               None::<Func1<(bool,
                                                                                                                                                                             string,
                                                                                                                                                                             i32),
                                                                                                                                                                            Arc<Async<()>>>>;
                                                                                                                                                           let v1404:
                                                                                                                                                                   Option<string> =
                                                                                                                                                               None::<string>;
                                                                                                                                                           let v1405:
                                                                                                                                                                   string =
                                                                                                                                                               sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                                        if getValue(_v1368.get().clone())
                                                                                                                                                                               ==
                                                                                                                                                                               false
                                                                                                                                                                           {
                                                                                                                                                                            v1319.clone()
                                                                                                                                                                        } else {
                                                                                                                                                                            let _v1381:
                                                                                                                                                                                    MutCell<Option<string>> =
                                                                                                                                                                                MutCell::new(None::<string>);
                                                                                                                                                                            let v1383:
                                                                                                                                                                                    string =
                                                                                                                                                                                Documents::method26();
                                                                                                                                                                            let v1384:
                                                                                                                                                                                    string =
                                                                                                                                                                                Documents::method27(v1319.clone());
                                                                                                                                                                            let v1385:
                                                                                                                                                                                    string =
                                                                                                                                                                                Documents::method28();
                                                                                                                                                                            let v1387:
                                                                                                                                                                                    &str =
                                                                                                                                                                                &regex::Regex::new(&v1383).unwrap().replace_all(&v1384, &*v1385);
                                                                                                                                                                            let v1389:
                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                String::from(v1387);
                                                                                                                                                                            {
                                                                                                                                                                                let x_31:
                                                                                                                                                                                        string =
                                                                                                                                                                                    fable_library_rust::String_::fromString(v1389);
                                                                                                                                                                                _v1381.set(Some(x_31))
                                                                                                                                                                            }
                                                                                                                                                                            {
                                                                                                                                                                                let v1398:
                                                                                                                                                                                        string =
                                                                                                                                                                                    getValue(_v1381.get().clone());
                                                                                                                                                                                replace(sprintf!("{}{}",
                                                                                                                                                                                                 toLowerChar(getCharAt(v1398.clone(),
                                                                                                                                                                                                                       0_i32)),
                                                                                                                                                                                                 getSlice(v1398,
                                                                                                                                                                                                          Some(1_i32),
                                                                                                                                                                                                          None::<i32>)),
                                                                                                                                                                                        string("\\"),
                                                                                                                                                                                        string("/"))
                                                                                                                                                                            }
                                                                                                                                                                        });
                                                                                                                                                           let _v1406:
                                                                                                                                                                   MutCell<Option<(i32,
                                                                                                                                                                                   string)>> =
                                                                                                                                                               MutCell::new(None::<(i32,
                                                                                                                                                                                    string)>);
                                                                                                                                                           let patternInput_12:
                                                                                                                                                                   (string,
                                                                                                                                                                    string) =
                                                                                                                                                               Documents::method29();
                                                                                                                                                           let v1410:
                                                                                                                                                                   i32 =
                                                                                                                                                               length(v1405.clone());
                                                                                                                                                           let v1411:
                                                                                                                                                                   Array<char> =
                                                                                                                                                               new_init(&'\u{0000}',
                                                                                                                                                                        v1410);
                                                                                                                                                           let v1412:
                                                                                                                                                                   LrcPtr<Documents::Mut4> =
                                                                                                                                                               LrcPtr::new(Documents::Mut4{l0:
                                                                                                                                                                                               MutCell::new(0_i32),});
                                                                                                                                                           while Documents::method30(v1410,
                                                                                                                                                                                     v1412.clone())
                                                                                                                                                                 {
                                                                                                                                                               let v1414:
                                                                                                                                                                       i32 =
                                                                                                                                                                   v1412.l0.get().clone();
                                                                                                                                                               let v1415:
                                                                                                                                                                       char =
                                                                                                                                                                   getCharAt(v1405.clone(),
                                                                                                                                                                             v1414);
                                                                                                                                                               v1411.get_mut()[v1414
                                                                                                                                                                                   as
                                                                                                                                                                                   usize]
                                                                                                                                                                   =
                                                                                                                                                                   v1415;
                                                                                                                                                               {
                                                                                                                                                                   let v1416:
                                                                                                                                                                           i32 =
                                                                                                                                                                       v1414
                                                                                                                                                                           +
                                                                                                                                                                           1_i32;
                                                                                                                                                                   v1412.l0.set(v1416);
                                                                                                                                                                   ()
                                                                                                                                                               }
                                                                                                                                                           }
                                                                                                                                                           {
                                                                                                                                                               let v1418:
                                                                                                                                                                       List<char> =
                                                                                                                                                                   ofArray(v1411.clone());
                                                                                                                                                               let patternInput_13:
                                                                                                                                                                       (string,
                                                                                                                                                                        string) =
                                                                                                                                                                   Documents::method32(patternInput_12.1.clone(),
                                                                                                                                                                                       patternInput_12.0.clone(),
                                                                                                                                                                                       foldBack(Func2::new(move
                                                                                                                                                                                                               |b0:
                                                                                                                                                                                                                    char,
                                                                                                                                                                                                                b1:
                                                                                                                                                                                                                    LrcPtr<Documents::UH0>|
                                                                                                                                                                                                               (Documents::method31())(b0)(b1)),
                                                                                                                                                                                                v1418,
                                                                                                                                                                                                LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                                       Documents::US10::US10_0);
                                                                                                                                                               let v1426:
                                                                                                                                                                       string =
                                                                                                                                                                   patternInput_13.0.clone();
                                                                                                                                                               let v1428:
                                                                                                                                                                       Array<string> =
                                                                                                                                                                   Documents::method33(patternInput_13.1.clone());
                                                                                                                                                               let v1430:
                                                                                                                                                                       Vec<string> =
                                                                                                                                                                   v1428.to_vec();
                                                                                                                                                               let v1432:
                                                                                                                                                                       Vec<std::string::String> =
                                                                                                                                                                   v1430.iter().map(|x| v255.clone()(x.clone())).collect();
                                                                                                                                                               Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                                  Func0::new({
                                                                                                                                                                                                 let v1402
                                                                                                                                                                                                     =
                                                                                                                                                                                                     v1402.clone();
                                                                                                                                                                                                 let v1403
                                                                                                                                                                                                     =
                                                                                                                                                                                                     v1403.clone();
                                                                                                                                                                                                 let v1404
                                                                                                                                                                                                     =
                                                                                                                                                                                                     v1404.clone();
                                                                                                                                                                                                 let v1405
                                                                                                                                                                                                     =
                                                                                                                                                                                                     v1405.clone();
                                                                                                                                                                                                 let v1426
                                                                                                                                                                                                     =
                                                                                                                                                                                                     v1426.clone();
                                                                                                                                                                                                 let v1432
                                                                                                                                                                                                     =
                                                                                                                                                                                                     v1432.clone();
                                                                                                                                                                                                 move
                                                                                                                                                                                                     ||
                                                                                                                                                                                                     Documents::closure27(v1402.clone(),
                                                                                                                                                                                                                          v1405.clone(),
                                                                                                                                                                                                                          v1403.clone(),
                                                                                                                                                                                                                          v1404.clone(),
                                                                                                                                                                                                                          v1426.clone(),
                                                                                                                                                                                                                          v1432.clone(),
                                                                                                                                                                                                                          ())
                                                                                                                                                                                             }),
                                                                                                                                                                                  Documents::method38());
                                                                                                                                                               {
                                                                                                                                                                   let v1436:
                                                                                                                                                                           std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                                      string)>>>> =
                                                                                                                                                                       Documents::method39(v1402.clone(),
                                                                                                                                                                                           v1405.clone(),
                                                                                                                                                                                           v1403.clone(),
                                                                                                                                                                                           v1404.clone(),
                                                                                                                                                                                           v1426.clone(),
                                                                                                                                                                                           v1432.clone());
                                                                                                                                                                   let v1438:
                                                                                                                                                                           LrcPtr<(i32,
                                                                                                                                                                                   string)> =
                                                                                                                                                                       futures_lite::future::block_on(v1436);
                                                                                                                                                                   _v1406.set(Some((v1438.0.clone(),
                                                                                                                                                                                    v1438.1.clone())));
                                                                                                                                                                   {
                                                                                                                                                                       let patternInput_14:
                                                                                                                                                                               (i32,
                                                                                                                                                                                string) =
                                                                                                                                                                           getValue(_v1406.get().clone());
                                                                                                                                                                       let _v1612:
                                                                                                                                                                               MutCell<Option<bool>> =
                                                                                                                                                                           MutCell::new(None::<bool>);
                                                                                                                                                                       {
                                                                                                                                                                           let x_33:
                                                                                                                                                                                   bool =
                                                                                                                                                                               cfg!(windows);
                                                                                                                                                                           _v1612.set(Some(x_33))
                                                                                                                                                                       }
                                                                                                                                                                       {
                                                                                                                                                                           let v1646:
                                                                                                                                                                                   Option<CancellationToken> =
                                                                                                                                                                               None::<CancellationToken>;
                                                                                                                                                                           let v1647 =
                                                                                                                                                                               None::<Func1<(bool,
                                                                                                                                                                                             string,
                                                                                                                                                                                             i32),
                                                                                                                                                                                            Arc<Async<()>>>>;
                                                                                                                                                                           let v1648:
                                                                                                                                                                                   Option<string> =
                                                                                                                                                                               None::<string>;
                                                                                                                                                                           let v1649:
                                                                                                                                                                                   string =
                                                                                                                                                                               sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                                                        if getValue(_v1612.get().clone())
                                                                                                                                                                                               ==
                                                                                                                                                                                               false
                                                                                                                                                                                           {
                                                                                                                                                                                            v1320.clone()
                                                                                                                                                                                        } else {
                                                                                                                                                                                            let _v1625:
                                                                                                                                                                                                    MutCell<Option<string>> =
                                                                                                                                                                                                MutCell::new(None::<string>);
                                                                                                                                                                                            let v1627:
                                                                                                                                                                                                    string =
                                                                                                                                                                                                Documents::method26();
                                                                                                                                                                                            let v1628:
                                                                                                                                                                                                    string =
                                                                                                                                                                                                Documents::method27(v1320.clone());
                                                                                                                                                                                            let v1629:
                                                                                                                                                                                                    string =
                                                                                                                                                                                                Documents::method28();
                                                                                                                                                                                            let v1631:
                                                                                                                                                                                                    &str =
                                                                                                                                                                                                &regex::Regex::new(&v1627).unwrap().replace_all(&v1628, &*v1629);
                                                                                                                                                                                            let v1633:
                                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                                String::from(v1631);
                                                                                                                                                                                            {
                                                                                                                                                                                                let x_34:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    fable_library_rust::String_::fromString(v1633);
                                                                                                                                                                                                _v1625.set(Some(x_34))
                                                                                                                                                                                            }
                                                                                                                                                                                            {
                                                                                                                                                                                                let v1642:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    getValue(_v1625.get().clone());
                                                                                                                                                                                                replace(sprintf!("{}{}",
                                                                                                                                                                                                                 toLowerChar(getCharAt(v1642.clone(),
                                                                                                                                                                                                                                       0_i32)),
                                                                                                                                                                                                                 getSlice(v1642,
                                                                                                                                                                                                                          Some(1_i32),
                                                                                                                                                                                                                          None::<i32>)),
                                                                                                                                                                                                        string("\\"),
                                                                                                                                                                                                        string("/"))
                                                                                                                                                                                            }
                                                                                                                                                                                        });
                                                                                                                                                                           let _v1650:
                                                                                                                                                                                   MutCell<Option<(i32,
                                                                                                                                                                                                   string)>> =
                                                                                                                                                                               MutCell::new(None::<(i32,
                                                                                                                                                                                                    string)>);
                                                                                                                                                                           let patternInput_15:
                                                                                                                                                                                   (string,
                                                                                                                                                                                    string) =
                                                                                                                                                                               Documents::method29();
                                                                                                                                                                           let v1654:
                                                                                                                                                                                   i32 =
                                                                                                                                                                               length(v1649.clone());
                                                                                                                                                                           let v1655:
                                                                                                                                                                                   Array<char> =
                                                                                                                                                                               new_init(&'\u{0000}',
                                                                                                                                                                                        v1654);
                                                                                                                                                                           let v1656:
                                                                                                                                                                                   LrcPtr<Documents::Mut4> =
                                                                                                                                                                               LrcPtr::new(Documents::Mut4{l0:
                                                                                                                                                                                                               MutCell::new(0_i32),});
                                                                                                                                                                           while Documents::method30(v1654,
                                                                                                                                                                                                     v1656.clone())
                                                                                                                                                                                 {
                                                                                                                                                                               let v1658:
                                                                                                                                                                                       i32 =
                                                                                                                                                                                   v1656.l0.get().clone();
                                                                                                                                                                               let v1659:
                                                                                                                                                                                       char =
                                                                                                                                                                                   getCharAt(v1649.clone(),
                                                                                                                                                                                             v1658);
                                                                                                                                                                               v1655.get_mut()[v1658
                                                                                                                                                                                                   as
                                                                                                                                                                                                   usize]
                                                                                                                                                                                   =
                                                                                                                                                                                   v1659;
                                                                                                                                                                               {
                                                                                                                                                                                   let v1660:
                                                                                                                                                                                           i32 =
                                                                                                                                                                                       v1658
                                                                                                                                                                                           +
                                                                                                                                                                                           1_i32;
                                                                                                                                                                                   v1656.l0.set(v1660);
                                                                                                                                                                                   ()
                                                                                                                                                                               }
                                                                                                                                                                           }
                                                                                                                                                                           {
                                                                                                                                                                               let v1662:
                                                                                                                                                                                       List<char> =
                                                                                                                                                                                   ofArray(v1655.clone());
                                                                                                                                                                               let patternInput_16:
                                                                                                                                                                                       (string,
                                                                                                                                                                                        string) =
                                                                                                                                                                                   Documents::method32(patternInput_15.1.clone(),
                                                                                                                                                                                                       patternInput_15.0.clone(),
                                                                                                                                                                                                       foldBack(Func2::new(move
                                                                                                                                                                                                                               |b0:
                                                                                                                                                                                                                                    char,
                                                                                                                                                                                                                                b1:
                                                                                                                                                                                                                                    LrcPtr<Documents::UH0>|
                                                                                                                                                                                                                               (Documents::method31())(b0)(b1)),
                                                                                                                                                                                                                v1662,
                                                                                                                                                                                                                LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                                                       Documents::US10::US10_0);
                                                                                                                                                                               let v1670:
                                                                                                                                                                                       string =
                                                                                                                                                                                   patternInput_16.0.clone();
                                                                                                                                                                               let v1672:
                                                                                                                                                                                       Array<string> =
                                                                                                                                                                                   Documents::method33(patternInput_16.1.clone());
                                                                                                                                                                               let v1674:
                                                                                                                                                                                       Vec<string> =
                                                                                                                                                                                   v1672.to_vec();
                                                                                                                                                                               let v1676:
                                                                                                                                                                                       Vec<std::string::String> =
                                                                                                                                                                                   v1674.iter().map(|x| v255.clone()(x.clone())).collect();
                                                                                                                                                                               Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                                                  Func0::new({
                                                                                                                                                                                                                 let v1646
                                                                                                                                                                                                                     =
                                                                                                                                                                                                                     v1646.clone();
                                                                                                                                                                                                                 let v1647
                                                                                                                                                                                                                     =
                                                                                                                                                                                                                     v1647.clone();
                                                                                                                                                                                                                 let v1648
                                                                                                                                                                                                                     =
                                                                                                                                                                                                                     v1648.clone();
                                                                                                                                                                                                                 let v1649
                                                                                                                                                                                                                     =
                                                                                                                                                                                                                     v1649.clone();
                                                                                                                                                                                                                 let v1670
                                                                                                                                                                                                                     =
                                                                                                                                                                                                                     v1670.clone();
                                                                                                                                                                                                                 let v1676
                                                                                                                                                                                                                     =
                                                                                                                                                                                                                     v1676.clone();
                                                                                                                                                                                                                 move
                                                                                                                                                                                                                     ||
                                                                                                                                                                                                                     Documents::closure27(v1646.clone(),
                                                                                                                                                                                                                                          v1649.clone(),
                                                                                                                                                                                                                                          v1647.clone(),
                                                                                                                                                                                                                                          v1648.clone(),
                                                                                                                                                                                                                                          v1670.clone(),
                                                                                                                                                                                                                                          v1676.clone(),
                                                                                                                                                                                                                                          ())
                                                                                                                                                                                                             }),
                                                                                                                                                                                                  Documents::method38());
                                                                                                                                                                               {
                                                                                                                                                                                   let v1680:
                                                                                                                                                                                           std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                                                      string)>>>> =
                                                                                                                                                                                       Documents::method39(v1646.clone(),
                                                                                                                                                                                                           v1649.clone(),
                                                                                                                                                                                                           v1647.clone(),
                                                                                                                                                                                                           v1648.clone(),
                                                                                                                                                                                                           v1670.clone(),
                                                                                                                                                                                                           v1676.clone());
                                                                                                                                                                                   let v1682:
                                                                                                                                                                                           LrcPtr<(i32,
                                                                                                                                                                                                   string)> =
                                                                                                                                                                                       futures_lite::future::block_on(v1680);
                                                                                                                                                                                   _v1650.set(Some((v1682.0.clone(),
                                                                                                                                                                                                    v1682.1.clone())));
                                                                                                                                                                                   patternInput_14.1.clone()
                                                                                                                                                                                       ==
                                                                                                                                                                                       (getValue(_v1650.get().clone())).1.clone()
                                                                                                                                                                               }
                                                                                                                                                                           }
                                                                                                                                                                       }
                                                                                                                                                                   }
                                                                                                                                                               }
                                                                                                                                                           }
                                                                                                                                                       }
                                                                                                                                                   } else {
                                                                                                                                                       false
                                                                                                                                                   })
                                                                                                                                                      ==
                                                                                                                                                      false
                                                                                                                                                  {
                                                                                                                                                   let v1859:
                                                                                                                                                           string =
                                                                                                                                                       sprintf!("crowbook --single \"{}\" --output \"{}\" --to {} --set rendering.num_depth 6 html.css.add \\\"\'\'\' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} \'\'\'\\\"",
                                                                                                                                                                v511.clone(),
                                                                                                                                                                v1319.clone(),
                                                                                                                                                                string("epub"));
                                                                                                                                                   let v1860:
                                                                                                                                                           Option<CancellationToken> =
                                                                                                                                                       None::<CancellationToken>;
                                                                                                                                                   let v1861 =
                                                                                                                                                       None::<Func1<(bool,
                                                                                                                                                                     string,
                                                                                                                                                                     i32),
                                                                                                                                                                    Arc<Async<()>>>>;
                                                                                                                                                   let v1863:
                                                                                                                                                           Option<string> =
                                                                                                                                                       Some(v1_1.clone());
                                                                                                                                                   let _v1864:
                                                                                                                                                           MutCell<Option<(i32,
                                                                                                                                                                           string)>> =
                                                                                                                                                       MutCell::new(None::<(i32,
                                                                                                                                                                            string)>);
                                                                                                                                                   let patternInput_18:
                                                                                                                                                           (string,
                                                                                                                                                            string) =
                                                                                                                                                       Documents::method29();
                                                                                                                                                   let v1868:
                                                                                                                                                           i32 =
                                                                                                                                                       length(v1859.clone());
                                                                                                                                                   let v1869:
                                                                                                                                                           Array<char> =
                                                                                                                                                       new_init(&'\u{0000}',
                                                                                                                                                                v1868);
                                                                                                                                                   let v1870:
                                                                                                                                                           LrcPtr<Documents::Mut4> =
                                                                                                                                                       LrcPtr::new(Documents::Mut4{l0:
                                                                                                                                                                                       MutCell::new(0_i32),});
                                                                                                                                                   while Documents::method30(v1868,
                                                                                                                                                                             v1870.clone())
                                                                                                                                                         {
                                                                                                                                                       let v1872:
                                                                                                                                                               i32 =
                                                                                                                                                           v1870.l0.get().clone();
                                                                                                                                                       let v1873:
                                                                                                                                                               char =
                                                                                                                                                           getCharAt(v1859.clone(),
                                                                                                                                                                     v1872);
                                                                                                                                                       v1869.get_mut()[v1872
                                                                                                                                                                           as
                                                                                                                                                                           usize]
                                                                                                                                                           =
                                                                                                                                                           v1873;
                                                                                                                                                       {
                                                                                                                                                           let v1874:
                                                                                                                                                                   i32 =
                                                                                                                                                               v1872
                                                                                                                                                                   +
                                                                                                                                                                   1_i32;
                                                                                                                                                           v1870.l0.set(v1874);
                                                                                                                                                           ()
                                                                                                                                                       }
                                                                                                                                                   }
                                                                                                                                                   {
                                                                                                                                                       let v1876:
                                                                                                                                                               List<char> =
                                                                                                                                                           ofArray(v1869.clone());
                                                                                                                                                       let patternInput_19:
                                                                                                                                                               (string,
                                                                                                                                                                string) =
                                                                                                                                                           Documents::method32(patternInput_18.1.clone(),
                                                                                                                                                                               patternInput_18.0.clone(),
                                                                                                                                                                               foldBack(Func2::new(move
                                                                                                                                                                                                       |b0:
                                                                                                                                                                                                            char,
                                                                                                                                                                                                        b1:
                                                                                                                                                                                                            LrcPtr<Documents::UH0>|
                                                                                                                                                                                                       (Documents::method31())(b0)(b1)),
                                                                                                                                                                                        v1876,
                                                                                                                                                                                        LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                               Documents::US10::US10_0);
                                                                                                                                                       let v1884:
                                                                                                                                                               string =
                                                                                                                                                           patternInput_19.0.clone();
                                                                                                                                                       let v1886:
                                                                                                                                                               Array<string> =
                                                                                                                                                           Documents::method33(patternInput_19.1.clone());
                                                                                                                                                       let v1888:
                                                                                                                                                               Vec<string> =
                                                                                                                                                           v1886.to_vec();
                                                                                                                                                       let v1890:
                                                                                                                                                               Vec<std::string::String> =
                                                                                                                                                           v1888.iter().map(|x| v255.clone()(x.clone())).collect();
                                                                                                                                                       Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                          Func0::new({
                                                                                                                                                                                         let v1859
                                                                                                                                                                                             =
                                                                                                                                                                                             v1859.clone();
                                                                                                                                                                                         let v1860
                                                                                                                                                                                             =
                                                                                                                                                                                             v1860.clone();
                                                                                                                                                                                         let v1861
                                                                                                                                                                                             =
                                                                                                                                                                                             v1861.clone();
                                                                                                                                                                                         let v1863
                                                                                                                                                                                             =
                                                                                                                                                                                             v1863.clone();
                                                                                                                                                                                         let v1884
                                                                                                                                                                                             =
                                                                                                                                                                                             v1884.clone();
                                                                                                                                                                                         let v1890
                                                                                                                                                                                             =
                                                                                                                                                                                             v1890.clone();
                                                                                                                                                                                         move
                                                                                                                                                                                             ||
                                                                                                                                                                                             Documents::closure27(v1860.clone(),
                                                                                                                                                                                                                  v1859.clone(),
                                                                                                                                                                                                                  v1861.clone(),
                                                                                                                                                                                                                  v1863.clone(),
                                                                                                                                                                                                                  v1884.clone(),
                                                                                                                                                                                                                  v1890.clone(),
                                                                                                                                                                                                                  ())
                                                                                                                                                                                     }),
                                                                                                                                                                          Documents::method38());
                                                                                                                                                       {
                                                                                                                                                           let v1894:
                                                                                                                                                                   std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                              string)>>>> =
                                                                                                                                                               Documents::method39(v1860.clone(),
                                                                                                                                                                                   v1859.clone(),
                                                                                                                                                                                   v1861.clone(),
                                                                                                                                                                                   v1863.clone(),
                                                                                                                                                                                   v1884.clone(),
                                                                                                                                                                                   v1890.clone());
                                                                                                                                                           let v1896:
                                                                                                                                                                   LrcPtr<(i32,
                                                                                                                                                                           string)> =
                                                                                                                                                               futures_lite::future::block_on(v1894);
                                                                                                                                                           _v1864.set(Some((v1896.0.clone(),
                                                                                                                                                                            v1896.1.clone())));
                                                                                                                                                           {
                                                                                                                                                               let patternInput_20:
                                                                                                                                                                       (i32,
                                                                                                                                                                        string) =
                                                                                                                                                                   getValue(_v1864.get().clone());
                                                                                                                                                               let v2069:
                                                                                                                                                                       string =
                                                                                                                                                                   patternInput_20.1.clone();
                                                                                                                                                               let v2068:
                                                                                                                                                                       i32 =
                                                                                                                                                                   patternInput_20.0.clone();
                                                                                                                                                               Documents::method3(Documents::US0::US0_2,
                                                                                                                                                                                  Func0::new(move
                                                                                                                                                                                                 ||
                                                                                                                                                                                                 Documents::closure55((),
                                                                                                                                                                                                                      ())),
                                                                                                                                                                                  Func0::new({
                                                                                                                                                                                                 let v2068
                                                                                                                                                                                                     =
                                                                                                                                                                                                     v2068.clone();
                                                                                                                                                                                                 let v2069
                                                                                                                                                                                                     =
                                                                                                                                                                                                     v2069.clone();
                                                                                                                                                                                                 move
                                                                                                                                                                                                     ||
                                                                                                                                                                                                     Documents::closure56(v2069.clone(),
                                                                                                                                                                                                                          v2068,
                                                                                                                                                                                                                          ())
                                                                                                                                                                                             }));
                                                                                                                                                               if if v2068
                                                                                                                                                                         !=
                                                                                                                                                                         0_i32
                                                                                                                                                                     {
                                                                                                                                                                      true
                                                                                                                                                                  } else {
                                                                                                                                                                      contains(v2069.clone(),
                                                                                                                                                                               string("ERROR"))
                                                                                                                                                                  }
                                                                                                                                                                  {
                                                                                                                                                                   Documents::US8::US8_0(Documents::US9::US9_1(v1319.clone(),
                                                                                                                                                                                                               v2069.clone()))
                                                                                                                                                               } else {
                                                                                                                                                                   let _v2079:
                                                                                                                                                                           MutCell<Option<()>> =
                                                                                                                                                                       MutCell::new(None::<()>);
                                                                                                                                                                   let v2081:
                                                                                                                                                                           string =
                                                                                                                                                                       Documents::method59(v1320);
                                                                                                                                                                   let v2083:
                                                                                                                                                                           Result<u64,
                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                       std::fs::copy(&*v1319, &*v2081);
                                                                                                                                                                   let v2085:
                                                                                                                                                                           u64 =
                                                                                                                                                                       v2083.unwrap();
                                                                                                                                                                   _v2079.set(Some(()));
                                                                                                                                                                   getValue(_v2079.get().clone());
                                                                                                                                                                   Documents::US8::US8_0(Documents::US9::US9_0(v1319))
                                                                                                                                                               }
                                                                                                                                                           }
                                                                                                                                                       }
                                                                                                                                                   }
                                                                                                                                               } else {
                                                                                                                                                   Documents::US8::US8_1
                                                                                                                                               };
                                                                                                                                           let v2092:
                                                                                                                                                   string =
                                                                                                                                               sprintf!("{}.{}",
                                                                                                                                                        v511.clone(),
                                                                                                                                                        string("pdf"));
                                                                                                                                           let v2093:
                                                                                                                                                   string =
                                                                                                                                               sprintf!("{}.{}",
                                                                                                                                                        v1044.clone(),
                                                                                                                                                        string("pdf"));
                                                                                                                                           let _v2094:
                                                                                                                                                   MutCell<Option<bool>> =
                                                                                                                                               MutCell::new(None::<bool>);
                                                                                                                                           let v2096:
                                                                                                                                                   string =
                                                                                                                                               Documents::method13(v2092.clone());
                                                                                                                                           let v2098:
                                                                                                                                                   &str =
                                                                                                                                               fable_library_rust::String_::LrcStr::as_str(&v2096);
                                                                                                                                           let v2100:
                                                                                                                                                   std::string::String =
                                                                                                                                               String::from(v2098);
                                                                                                                                           let v2102:
                                                                                                                                                   std::path::PathBuf =
                                                                                                                                               std::path::PathBuf::from(v2100);
                                                                                                                                           {
                                                                                                                                               let x_38:
                                                                                                                                                       bool =
                                                                                                                                                   if v2102.clone().exists()
                                                                                                                                                      {
                                                                                                                                                       v2102.is_file()
                                                                                                                                                   } else {
                                                                                                                                                       false
                                                                                                                                                   };
                                                                                                                                               _v2094.set(Some(x_38))
                                                                                                                                           }
                                                                                                                                           {
                                                                                                                                               let v2863:
                                                                                                                                                       Documents::US8 =
                                                                                                                                                   if (if if getValue(_v2094.get().clone())
                                                                                                                                                             {
                                                                                                                                                              let _v2117:
                                                                                                                                                                      MutCell<Option<bool>> =
                                                                                                                                                                  MutCell::new(None::<bool>);
                                                                                                                                                              let v2119:
                                                                                                                                                                      string =
                                                                                                                                                                  Documents::method13(v2093.clone());
                                                                                                                                                              let v2121:
                                                                                                                                                                      &str =
                                                                                                                                                                  fable_library_rust::String_::LrcStr::as_str(&v2119);
                                                                                                                                                              let v2123:
                                                                                                                                                                      std::string::String =
                                                                                                                                                                  String::from(v2121);
                                                                                                                                                              let v2125:
                                                                                                                                                                      std::path::PathBuf =
                                                                                                                                                                  std::path::PathBuf::from(v2123);
                                                                                                                                                              {
                                                                                                                                                                  let x_39:
                                                                                                                                                                          bool =
                                                                                                                                                                      if v2125.clone().exists()
                                                                                                                                                                         {
                                                                                                                                                                          v2125.is_file()
                                                                                                                                                                      } else {
                                                                                                                                                                          false
                                                                                                                                                                      };
                                                                                                                                                                  _v2117.set(Some(x_39))
                                                                                                                                                              }
                                                                                                                                                              getValue(_v2117.get().clone())
                                                                                                                                                          } else {
                                                                                                                                                              false
                                                                                                                                                          }
                                                                                                                                                          {
                                                                                                                                                           let _v2141:
                                                                                                                                                                   MutCell<Option<bool>> =
                                                                                                                                                               MutCell::new(None::<bool>);
                                                                                                                                                           {
                                                                                                                                                               let x_40:
                                                                                                                                                                       bool =
                                                                                                                                                                   cfg!(windows);
                                                                                                                                                               _v2141.set(Some(x_40))
                                                                                                                                                           }
                                                                                                                                                           {
                                                                                                                                                               let v2175:
                                                                                                                                                                       Option<CancellationToken> =
                                                                                                                                                                   None::<CancellationToken>;
                                                                                                                                                               let v2176 =
                                                                                                                                                                   None::<Func1<(bool,
                                                                                                                                                                                 string,
                                                                                                                                                                                 i32),
                                                                                                                                                                                Arc<Async<()>>>>;
                                                                                                                                                               let v2177:
                                                                                                                                                                       Option<string> =
                                                                                                                                                                   None::<string>;
                                                                                                                                                               let v2178:
                                                                                                                                                                       string =
                                                                                                                                                                   sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                                            if getValue(_v2141.get().clone())
                                                                                                                                                                                   ==
                                                                                                                                                                                   false
                                                                                                                                                                               {
                                                                                                                                                                                v2092.clone()
                                                                                                                                                                            } else {
                                                                                                                                                                                let _v2154:
                                                                                                                                                                                        MutCell<Option<string>> =
                                                                                                                                                                                    MutCell::new(None::<string>);
                                                                                                                                                                                let v2156:
                                                                                                                                                                                        string =
                                                                                                                                                                                    Documents::method26();
                                                                                                                                                                                let v2157:
                                                                                                                                                                                        string =
                                                                                                                                                                                    Documents::method27(v2092.clone());
                                                                                                                                                                                let v2158:
                                                                                                                                                                                        string =
                                                                                                                                                                                    Documents::method28();
                                                                                                                                                                                let v2160:
                                                                                                                                                                                        &str =
                                                                                                                                                                                    &regex::Regex::new(&v2156).unwrap().replace_all(&v2157, &*v2158);
                                                                                                                                                                                let v2162:
                                                                                                                                                                                        std::string::String =
                                                                                                                                                                                    String::from(v2160);
                                                                                                                                                                                {
                                                                                                                                                                                    let x_41:
                                                                                                                                                                                            string =
                                                                                                                                                                                        fable_library_rust::String_::fromString(v2162);
                                                                                                                                                                                    _v2154.set(Some(x_41))
                                                                                                                                                                                }
                                                                                                                                                                                {
                                                                                                                                                                                    let v2171:
                                                                                                                                                                                            string =
                                                                                                                                                                                        getValue(_v2154.get().clone());
                                                                                                                                                                                    replace(sprintf!("{}{}",
                                                                                                                                                                                                     toLowerChar(getCharAt(v2171.clone(),
                                                                                                                                                                                                                           0_i32)),
                                                                                                                                                                                                     getSlice(v2171,
                                                                                                                                                                                                              Some(1_i32),
                                                                                                                                                                                                              None::<i32>)),
                                                                                                                                                                                            string("\\"),
                                                                                                                                                                                            string("/"))
                                                                                                                                                                                }
                                                                                                                                                                            });
                                                                                                                                                               let _v2179:
                                                                                                                                                                       MutCell<Option<(i32,
                                                                                                                                                                                       string)>> =
                                                                                                                                                                   MutCell::new(None::<(i32,
                                                                                                                                                                                        string)>);
                                                                                                                                                               let patternInput_21:
                                                                                                                                                                       (string,
                                                                                                                                                                        string) =
                                                                                                                                                                   Documents::method29();
                                                                                                                                                               let v2183:
                                                                                                                                                                       i32 =
                                                                                                                                                                   length(v2178.clone());
                                                                                                                                                               let v2184:
                                                                                                                                                                       Array<char> =
                                                                                                                                                                   new_init(&'\u{0000}',
                                                                                                                                                                            v2183);
                                                                                                                                                               let v2185:
                                                                                                                                                                       LrcPtr<Documents::Mut4> =
                                                                                                                                                                   LrcPtr::new(Documents::Mut4{l0:
                                                                                                                                                                                                   MutCell::new(0_i32),});
                                                                                                                                                               while Documents::method30(v2183,
                                                                                                                                                                                         v2185.clone())
                                                                                                                                                                     {
                                                                                                                                                                   let v2187:
                                                                                                                                                                           i32 =
                                                                                                                                                                       v2185.l0.get().clone();
                                                                                                                                                                   let v2188:
                                                                                                                                                                           char =
                                                                                                                                                                       getCharAt(v2178.clone(),
                                                                                                                                                                                 v2187);
                                                                                                                                                                   v2184.get_mut()[v2187
                                                                                                                                                                                       as
                                                                                                                                                                                       usize]
                                                                                                                                                                       =
                                                                                                                                                                       v2188;
                                                                                                                                                                   {
                                                                                                                                                                       let v2189:
                                                                                                                                                                               i32 =
                                                                                                                                                                           v2187
                                                                                                                                                                               +
                                                                                                                                                                               1_i32;
                                                                                                                                                                       v2185.l0.set(v2189);
                                                                                                                                                                       ()
                                                                                                                                                                   }
                                                                                                                                                               }
                                                                                                                                                               {
                                                                                                                                                                   let v2191:
                                                                                                                                                                           List<char> =
                                                                                                                                                                       ofArray(v2184.clone());
                                                                                                                                                                   let patternInput_22:
                                                                                                                                                                           (string,
                                                                                                                                                                            string) =
                                                                                                                                                                       Documents::method32(patternInput_21.1.clone(),
                                                                                                                                                                                           patternInput_21.0.clone(),
                                                                                                                                                                                           foldBack(Func2::new(move
                                                                                                                                                                                                                   |b0:
                                                                                                                                                                                                                        char,
                                                                                                                                                                                                                    b1:
                                                                                                                                                                                                                        LrcPtr<Documents::UH0>|
                                                                                                                                                                                                                   (Documents::method31())(b0)(b1)),
                                                                                                                                                                                                    v2191,
                                                                                                                                                                                                    LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                                           Documents::US10::US10_0);
                                                                                                                                                                   let v2199:
                                                                                                                                                                           string =
                                                                                                                                                                       patternInput_22.0.clone();
                                                                                                                                                                   let v2201:
                                                                                                                                                                           Array<string> =
                                                                                                                                                                       Documents::method33(patternInput_22.1.clone());
                                                                                                                                                                   let v2203:
                                                                                                                                                                           Vec<string> =
                                                                                                                                                                       v2201.to_vec();
                                                                                                                                                                   let v2205:
                                                                                                                                                                           Vec<std::string::String> =
                                                                                                                                                                       v2203.iter().map(|x| v255.clone()(x.clone())).collect();
                                                                                                                                                                   Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                                      Func0::new({
                                                                                                                                                                                                     let v2175
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v2175.clone();
                                                                                                                                                                                                     let v2176
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v2176.clone();
                                                                                                                                                                                                     let v2177
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v2177.clone();
                                                                                                                                                                                                     let v2178
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v2178.clone();
                                                                                                                                                                                                     let v2199
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v2199.clone();
                                                                                                                                                                                                     let v2205
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v2205.clone();
                                                                                                                                                                                                     move
                                                                                                                                                                                                         ||
                                                                                                                                                                                                         Documents::closure27(v2175.clone(),
                                                                                                                                                                                                                              v2178.clone(),
                                                                                                                                                                                                                              v2176.clone(),
                                                                                                                                                                                                                              v2177.clone(),
                                                                                                                                                                                                                              v2199.clone(),
                                                                                                                                                                                                                              v2205.clone(),
                                                                                                                                                                                                                              ())
                                                                                                                                                                                                 }),
                                                                                                                                                                                      Documents::method38());
                                                                                                                                                                   {
                                                                                                                                                                       let v2209:
                                                                                                                                                                               std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                                          string)>>>> =
                                                                                                                                                                           Documents::method39(v2175.clone(),
                                                                                                                                                                                               v2178.clone(),
                                                                                                                                                                                               v2176.clone(),
                                                                                                                                                                                               v2177.clone(),
                                                                                                                                                                                               v2199.clone(),
                                                                                                                                                                                               v2205.clone());
                                                                                                                                                                       let v2211:
                                                                                                                                                                               LrcPtr<(i32,
                                                                                                                                                                                       string)> =
                                                                                                                                                                           futures_lite::future::block_on(v2209);
                                                                                                                                                                       _v2179.set(Some((v2211.0.clone(),
                                                                                                                                                                                        v2211.1.clone())));
                                                                                                                                                                       {
                                                                                                                                                                           let patternInput_23:
                                                                                                                                                                                   (i32,
                                                                                                                                                                                    string) =
                                                                                                                                                                               getValue(_v2179.get().clone());
                                                                                                                                                                           let _v2385:
                                                                                                                                                                                   MutCell<Option<bool>> =
                                                                                                                                                                               MutCell::new(None::<bool>);
                                                                                                                                                                           {
                                                                                                                                                                               let x_43:
                                                                                                                                                                                       bool =
                                                                                                                                                                                   cfg!(windows);
                                                                                                                                                                               _v2385.set(Some(x_43))
                                                                                                                                                                           }
                                                                                                                                                                           {
                                                                                                                                                                               let v2419:
                                                                                                                                                                                       Option<CancellationToken> =
                                                                                                                                                                                   None::<CancellationToken>;
                                                                                                                                                                               let v2420 =
                                                                                                                                                                                   None::<Func1<(bool,
                                                                                                                                                                                                 string,
                                                                                                                                                                                                 i32),
                                                                                                                                                                                                Arc<Async<()>>>>;
                                                                                                                                                                               let v2421:
                                                                                                                                                                                       Option<string> =
                                                                                                                                                                                   None::<string>;
                                                                                                                                                                               let v2422:
                                                                                                                                                                                       string =
                                                                                                                                                                                   sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                                                            if getValue(_v2385.get().clone())
                                                                                                                                                                                                   ==
                                                                                                                                                                                                   false
                                                                                                                                                                                               {
                                                                                                                                                                                                v2093.clone()
                                                                                                                                                                                            } else {
                                                                                                                                                                                                let _v2398:
                                                                                                                                                                                                        MutCell<Option<string>> =
                                                                                                                                                                                                    MutCell::new(None::<string>);
                                                                                                                                                                                                let v2400:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    Documents::method26();
                                                                                                                                                                                                let v2401:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    Documents::method27(v2093.clone());
                                                                                                                                                                                                let v2402:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    Documents::method28();
                                                                                                                                                                                                let v2404:
                                                                                                                                                                                                        &str =
                                                                                                                                                                                                    &regex::Regex::new(&v2400).unwrap().replace_all(&v2401, &*v2402);
                                                                                                                                                                                                let v2406:
                                                                                                                                                                                                        std::string::String =
                                                                                                                                                                                                    String::from(v2404);
                                                                                                                                                                                                {
                                                                                                                                                                                                    let x_44:
                                                                                                                                                                                                            string =
                                                                                                                                                                                                        fable_library_rust::String_::fromString(v2406);
                                                                                                                                                                                                    _v2398.set(Some(x_44))
                                                                                                                                                                                                }
                                                                                                                                                                                                {
                                                                                                                                                                                                    let v2415:
                                                                                                                                                                                                            string =
                                                                                                                                                                                                        getValue(_v2398.get().clone());
                                                                                                                                                                                                    replace(sprintf!("{}{}",
                                                                                                                                                                                                                     toLowerChar(getCharAt(v2415.clone(),
                                                                                                                                                                                                                                           0_i32)),
                                                                                                                                                                                                                     getSlice(v2415,
                                                                                                                                                                                                                              Some(1_i32),
                                                                                                                                                                                                                              None::<i32>)),
                                                                                                                                                                                                            string("\\"),
                                                                                                                                                                                                            string("/"))
                                                                                                                                                                                                }
                                                                                                                                                                                            });
                                                                                                                                                                               let _v2423:
                                                                                                                                                                                       MutCell<Option<(i32,
                                                                                                                                                                                                       string)>> =
                                                                                                                                                                                   MutCell::new(None::<(i32,
                                                                                                                                                                                                        string)>);
                                                                                                                                                                               let patternInput_24:
                                                                                                                                                                                       (string,
                                                                                                                                                                                        string) =
                                                                                                                                                                                   Documents::method29();
                                                                                                                                                                               let v2427:
                                                                                                                                                                                       i32 =
                                                                                                                                                                                   length(v2422.clone());
                                                                                                                                                                               let v2428:
                                                                                                                                                                                       Array<char> =
                                                                                                                                                                                   new_init(&'\u{0000}',
                                                                                                                                                                                            v2427);
                                                                                                                                                                               let v2429:
                                                                                                                                                                                       LrcPtr<Documents::Mut4> =
                                                                                                                                                                                   LrcPtr::new(Documents::Mut4{l0:
                                                                                                                                                                                                                   MutCell::new(0_i32),});
                                                                                                                                                                               while Documents::method30(v2427,
                                                                                                                                                                                                         v2429.clone())
                                                                                                                                                                                     {
                                                                                                                                                                                   let v2431:
                                                                                                                                                                                           i32 =
                                                                                                                                                                                       v2429.l0.get().clone();
                                                                                                                                                                                   let v2432:
                                                                                                                                                                                           char =
                                                                                                                                                                                       getCharAt(v2422.clone(),
                                                                                                                                                                                                 v2431);
                                                                                                                                                                                   v2428.get_mut()[v2431
                                                                                                                                                                                                       as
                                                                                                                                                                                                       usize]
                                                                                                                                                                                       =
                                                                                                                                                                                       v2432;
                                                                                                                                                                                   {
                                                                                                                                                                                       let v2433:
                                                                                                                                                                                               i32 =
                                                                                                                                                                                           v2431
                                                                                                                                                                                               +
                                                                                                                                                                                               1_i32;
                                                                                                                                                                                       v2429.l0.set(v2433);
                                                                                                                                                                                       ()
                                                                                                                                                                                   }
                                                                                                                                                                               }
                                                                                                                                                                               {
                                                                                                                                                                                   let v2435:
                                                                                                                                                                                           List<char> =
                                                                                                                                                                                       ofArray(v2428.clone());
                                                                                                                                                                                   let patternInput_25:
                                                                                                                                                                                           (string,
                                                                                                                                                                                            string) =
                                                                                                                                                                                       Documents::method32(patternInput_24.1.clone(),
                                                                                                                                                                                                           patternInput_24.0.clone(),
                                                                                                                                                                                                           foldBack(Func2::new(move
                                                                                                                                                                                                                                   |b0:
                                                                                                                                                                                                                                        char,
                                                                                                                                                                                                                                    b1:
                                                                                                                                                                                                                                        LrcPtr<Documents::UH0>|
                                                                                                                                                                                                                                   (Documents::method31())(b0)(b1)),
                                                                                                                                                                                                                    v2435,
                                                                                                                                                                                                                    LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                                                           Documents::US10::US10_0);
                                                                                                                                                                                   let v2443:
                                                                                                                                                                                           string =
                                                                                                                                                                                       patternInput_25.0.clone();
                                                                                                                                                                                   let v2445:
                                                                                                                                                                                           Array<string> =
                                                                                                                                                                                       Documents::method33(patternInput_25.1.clone());
                                                                                                                                                                                   let v2447:
                                                                                                                                                                                           Vec<string> =
                                                                                                                                                                                       v2445.to_vec();
                                                                                                                                                                                   let v2449:
                                                                                                                                                                                           Vec<std::string::String> =
                                                                                                                                                                                       v2447.iter().map(|x| v255.clone()(x.clone())).collect();
                                                                                                                                                                                   Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                                                      Func0::new({
                                                                                                                                                                                                                     let v2419
                                                                                                                                                                                                                         =
                                                                                                                                                                                                                         v2419.clone();
                                                                                                                                                                                                                     let v2420
                                                                                                                                                                                                                         =
                                                                                                                                                                                                                         v2420.clone();
                                                                                                                                                                                                                     let v2421
                                                                                                                                                                                                                         =
                                                                                                                                                                                                                         v2421.clone();
                                                                                                                                                                                                                     let v2422
                                                                                                                                                                                                                         =
                                                                                                                                                                                                                         v2422.clone();
                                                                                                                                                                                                                     let v2443
                                                                                                                                                                                                                         =
                                                                                                                                                                                                                         v2443.clone();
                                                                                                                                                                                                                     let v2449
                                                                                                                                                                                                                         =
                                                                                                                                                                                                                         v2449.clone();
                                                                                                                                                                                                                     move
                                                                                                                                                                                                                         ||
                                                                                                                                                                                                                         Documents::closure27(v2419.clone(),
                                                                                                                                                                                                                                              v2422.clone(),
                                                                                                                                                                                                                                              v2420.clone(),
                                                                                                                                                                                                                                              v2421.clone(),
                                                                                                                                                                                                                                              v2443.clone(),
                                                                                                                                                                                                                                              v2449.clone(),
                                                                                                                                                                                                                                              ())
                                                                                                                                                                                                                 }),
                                                                                                                                                                                                      Documents::method38());
                                                                                                                                                                                   {
                                                                                                                                                                                       let v2453:
                                                                                                                                                                                               std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                                                          string)>>>> =
                                                                                                                                                                                           Documents::method39(v2419.clone(),
                                                                                                                                                                                                               v2422.clone(),
                                                                                                                                                                                                               v2420.clone(),
                                                                                                                                                                                                               v2421.clone(),
                                                                                                                                                                                                               v2443.clone(),
                                                                                                                                                                                                               v2449.clone());
                                                                                                                                                                                       let v2455:
                                                                                                                                                                                               LrcPtr<(i32,
                                                                                                                                                                                                       string)> =
                                                                                                                                                                                           futures_lite::future::block_on(v2453);
                                                                                                                                                                                       _v2423.set(Some((v2455.0.clone(),
                                                                                                                                                                                                        v2455.1.clone())));
                                                                                                                                                                                       patternInput_23.1.clone()
                                                                                                                                                                                           ==
                                                                                                                                                                                           (getValue(_v2423.get().clone())).1.clone()
                                                                                                                                                                                   }
                                                                                                                                                                               }
                                                                                                                                                                           }
                                                                                                                                                                       }
                                                                                                                                                                   }
                                                                                                                                                               }
                                                                                                                                                           }
                                                                                                                                                       } else {
                                                                                                                                                           false
                                                                                                                                                       })
                                                                                                                                                          ==
                                                                                                                                                          false
                                                                                                                                                      {
                                                                                                                                                       let v2632:
                                                                                                                                                               string =
                                                                                                                                                           sprintf!("crowbook --single \"{}\" --output \"{}\" --to {} --set rendering.num_depth 6 html.css.add \\\"\'\'\' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} \'\'\'\\\"",
                                                                                                                                                                    v511.clone(),
                                                                                                                                                                    v2092.clone(),
                                                                                                                                                                    string("pdf"));
                                                                                                                                                       let v2633:
                                                                                                                                                               Option<CancellationToken> =
                                                                                                                                                           None::<CancellationToken>;
                                                                                                                                                       let v2634 =
                                                                                                                                                           None::<Func1<(bool,
                                                                                                                                                                         string,
                                                                                                                                                                         i32),
                                                                                                                                                                        Arc<Async<()>>>>;
                                                                                                                                                       let v2636:
                                                                                                                                                               Option<string> =
                                                                                                                                                           Some(v1_1.clone());
                                                                                                                                                       let _v2637:
                                                                                                                                                               MutCell<Option<(i32,
                                                                                                                                                                               string)>> =
                                                                                                                                                           MutCell::new(None::<(i32,
                                                                                                                                                                                string)>);
                                                                                                                                                       let patternInput_27:
                                                                                                                                                               (string,
                                                                                                                                                                string) =
                                                                                                                                                           Documents::method29();
                                                                                                                                                       let v2641:
                                                                                                                                                               i32 =
                                                                                                                                                           length(v2632.clone());
                                                                                                                                                       let v2642:
                                                                                                                                                               Array<char> =
                                                                                                                                                           new_init(&'\u{0000}',
                                                                                                                                                                    v2641);
                                                                                                                                                       let v2643:
                                                                                                                                                               LrcPtr<Documents::Mut4> =
                                                                                                                                                           LrcPtr::new(Documents::Mut4{l0:
                                                                                                                                                                                           MutCell::new(0_i32),});
                                                                                                                                                       while Documents::method30(v2641,
                                                                                                                                                                                 v2643.clone())
                                                                                                                                                             {
                                                                                                                                                           let v2645:
                                                                                                                                                                   i32 =
                                                                                                                                                               v2643.l0.get().clone();
                                                                                                                                                           let v2646:
                                                                                                                                                                   char =
                                                                                                                                                               getCharAt(v2632.clone(),
                                                                                                                                                                         v2645);
                                                                                                                                                           v2642.get_mut()[v2645
                                                                                                                                                                               as
                                                                                                                                                                               usize]
                                                                                                                                                               =
                                                                                                                                                               v2646;
                                                                                                                                                           {
                                                                                                                                                               let v2647:
                                                                                                                                                                       i32 =
                                                                                                                                                                   v2645
                                                                                                                                                                       +
                                                                                                                                                                       1_i32;
                                                                                                                                                               v2643.l0.set(v2647);
                                                                                                                                                               ()
                                                                                                                                                           }
                                                                                                                                                       }
                                                                                                                                                       {
                                                                                                                                                           let v2649:
                                                                                                                                                                   List<char> =
                                                                                                                                                               ofArray(v2642.clone());
                                                                                                                                                           let patternInput_28:
                                                                                                                                                                   (string,
                                                                                                                                                                    string) =
                                                                                                                                                               Documents::method32(patternInput_27.1.clone(),
                                                                                                                                                                                   patternInput_27.0.clone(),
                                                                                                                                                                                   foldBack(Func2::new(move
                                                                                                                                                                                                           |b0:
                                                                                                                                                                                                                char,
                                                                                                                                                                                                            b1:
                                                                                                                                                                                                                LrcPtr<Documents::UH0>|
                                                                                                                                                                                                           (Documents::method31())(b0)(b1)),
                                                                                                                                                                                            v2649,
                                                                                                                                                                                            LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                                   Documents::US10::US10_0);
                                                                                                                                                           let v2657:
                                                                                                                                                                   string =
                                                                                                                                                               patternInput_28.0.clone();
                                                                                                                                                           let v2659:
                                                                                                                                                                   Array<string> =
                                                                                                                                                               Documents::method33(patternInput_28.1.clone());
                                                                                                                                                           let v2661:
                                                                                                                                                                   Vec<string> =
                                                                                                                                                               v2659.to_vec();
                                                                                                                                                           let v2663:
                                                                                                                                                                   Vec<std::string::String> =
                                                                                                                                                               v2661.iter().map(|x| v255.clone()(x.clone())).collect();
                                                                                                                                                           Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                              Func0::new({
                                                                                                                                                                                             let v2632
                                                                                                                                                                                                 =
                                                                                                                                                                                                 v2632.clone();
                                                                                                                                                                                             let v2633
                                                                                                                                                                                                 =
                                                                                                                                                                                                 v2633.clone();
                                                                                                                                                                                             let v2634
                                                                                                                                                                                                 =
                                                                                                                                                                                                 v2634.clone();
                                                                                                                                                                                             let v2636
                                                                                                                                                                                                 =
                                                                                                                                                                                                 v2636.clone();
                                                                                                                                                                                             let v2657
                                                                                                                                                                                                 =
                                                                                                                                                                                                 v2657.clone();
                                                                                                                                                                                             let v2663
                                                                                                                                                                                                 =
                                                                                                                                                                                                 v2663.clone();
                                                                                                                                                                                             move
                                                                                                                                                                                                 ||
                                                                                                                                                                                                 Documents::closure27(v2633.clone(),
                                                                                                                                                                                                                      v2632.clone(),
                                                                                                                                                                                                                      v2634.clone(),
                                                                                                                                                                                                                      v2636.clone(),
                                                                                                                                                                                                                      v2657.clone(),
                                                                                                                                                                                                                      v2663.clone(),
                                                                                                                                                                                                                      ())
                                                                                                                                                                                         }),
                                                                                                                                                                              Documents::method38());
                                                                                                                                                           {
                                                                                                                                                               let v2667:
                                                                                                                                                                       std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                                  string)>>>> =
                                                                                                                                                                   Documents::method39(v2633.clone(),
                                                                                                                                                                                       v2632.clone(),
                                                                                                                                                                                       v2634.clone(),
                                                                                                                                                                                       v2636.clone(),
                                                                                                                                                                                       v2657.clone(),
                                                                                                                                                                                       v2663.clone());
                                                                                                                                                               let v2669:
                                                                                                                                                                       LrcPtr<(i32,
                                                                                                                                                                               string)> =
                                                                                                                                                                   futures_lite::future::block_on(v2667);
                                                                                                                                                               _v2637.set(Some((v2669.0.clone(),
                                                                                                                                                                                v2669.1.clone())));
                                                                                                                                                               {
                                                                                                                                                                   let patternInput_29:
                                                                                                                                                                           (i32,
                                                                                                                                                                            string) =
                                                                                                                                                                       getValue(_v2637.get().clone());
                                                                                                                                                                   let v2842:
                                                                                                                                                                           string =
                                                                                                                                                                       patternInput_29.1.clone();
                                                                                                                                                                   let v2841:
                                                                                                                                                                           i32 =
                                                                                                                                                                       patternInput_29.0.clone();
                                                                                                                                                                   Documents::method3(Documents::US0::US0_2,
                                                                                                                                                                                      Func0::new(move
                                                                                                                                                                                                     ||
                                                                                                                                                                                                     Documents::closure55((),
                                                                                                                                                                                                                          ())),
                                                                                                                                                                                      Func0::new({
                                                                                                                                                                                                     let v2841
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v2841.clone();
                                                                                                                                                                                                     let v2842
                                                                                                                                                                                                         =
                                                                                                                                                                                                         v2842.clone();
                                                                                                                                                                                                     move
                                                                                                                                                                                                         ||
                                                                                                                                                                                                         Documents::closure56(v2842.clone(),
                                                                                                                                                                                                                              v2841,
                                                                                                                                                                                                                              ())
                                                                                                                                                                                                 }));
                                                                                                                                                                   if if v2841
                                                                                                                                                                             !=
                                                                                                                                                                             0_i32
                                                                                                                                                                         {
                                                                                                                                                                          true
                                                                                                                                                                      } else {
                                                                                                                                                                          contains(v2842.clone(),
                                                                                                                                                                                   string("ERROR"))
                                                                                                                                                                      }
                                                                                                                                                                      {
                                                                                                                                                                       Documents::US8::US8_0(Documents::US9::US9_1(v2092.clone(),
                                                                                                                                                                                                                   v2842.clone()))
                                                                                                                                                                   } else {
                                                                                                                                                                       let _v2852:
                                                                                                                                                                               MutCell<Option<()>> =
                                                                                                                                                                           MutCell::new(None::<()>);
                                                                                                                                                                       let v2854:
                                                                                                                                                                               string =
                                                                                                                                                                           Documents::method59(v2093);
                                                                                                                                                                       let v2856:
                                                                                                                                                                               Result<u64,
                                                                                                                                                                                      std::io::Error> =
                                                                                                                                                                           std::fs::copy(&*v2092, &*v2854);
                                                                                                                                                                       let v2858:
                                                                                                                                                                               u64 =
                                                                                                                                                                           v2856.unwrap();
                                                                                                                                                                       _v2852.set(Some(()));
                                                                                                                                                                       getValue(_v2852.get().clone());
                                                                                                                                                                       Documents::US8::US8_0(Documents::US9::US9_0(v2092))
                                                                                                                                                                   }
                                                                                                                                                               }
                                                                                                                                                           }
                                                                                                                                                       }
                                                                                                                                                   } else {
                                                                                                                                                       Documents::US8::US8_1
                                                                                                                                                   };
                                                                                                                                               let v2865:
                                                                                                                                                       string =
                                                                                                                                                   sprintf!("{}.{}",
                                                                                                                                                            v511.clone(),
                                                                                                                                                            string("html"));
                                                                                                                                               let v2866:
                                                                                                                                                       string =
                                                                                                                                                   sprintf!("{}.{}",
                                                                                                                                                            v1044.clone(),
                                                                                                                                                            string("html"));
                                                                                                                                               let _v2867:
                                                                                                                                                       MutCell<Option<bool>> =
                                                                                                                                                   MutCell::new(None::<bool>);
                                                                                                                                               let v2869:
                                                                                                                                                       string =
                                                                                                                                                   Documents::method13(v2865.clone());
                                                                                                                                               let v2871:
                                                                                                                                                       &str =
                                                                                                                                                   fable_library_rust::String_::LrcStr::as_str(&v2869);
                                                                                                                                               let v2873:
                                                                                                                                                       std::string::String =
                                                                                                                                                   String::from(v2871);
                                                                                                                                               let v2875:
                                                                                                                                                       std::path::PathBuf =
                                                                                                                                                   std::path::PathBuf::from(v2873);
                                                                                                                                               {
                                                                                                                                                   let x_48:
                                                                                                                                                           bool =
                                                                                                                                                       if v2875.clone().exists()
                                                                                                                                                          {
                                                                                                                                                           v2875.is_file()
                                                                                                                                                       } else {
                                                                                                                                                           false
                                                                                                                                                       };
                                                                                                                                                   _v2867.set(Some(x_48))
                                                                                                                                               }
                                                                                                                                               {
                                                                                                                                                   let v3644:
                                                                                                                                                           Array<Documents::US8> =
                                                                                                                                                       toArray(ofArray(new_array(&[if (if if getValue(_v2867.get().clone())
                                                                                                                                                                                             {
                                                                                                                                                                                              let _v2890:
                                                                                                                                                                                                      MutCell<Option<bool>> =
                                                                                                                                                                                                  MutCell::new(None::<bool>);
                                                                                                                                                                                              let v2892:
                                                                                                                                                                                                      string =
                                                                                                                                                                                                  Documents::method13(v2866.clone());
                                                                                                                                                                                              let v2894:
                                                                                                                                                                                                      &str =
                                                                                                                                                                                                  fable_library_rust::String_::LrcStr::as_str(&v2892);
                                                                                                                                                                                              let v2896:
                                                                                                                                                                                                      std::string::String =
                                                                                                                                                                                                  String::from(v2894);
                                                                                                                                                                                              let v2898:
                                                                                                                                                                                                      std::path::PathBuf =
                                                                                                                                                                                                  std::path::PathBuf::from(v2896);
                                                                                                                                                                                              {
                                                                                                                                                                                                  let x_49:
                                                                                                                                                                                                          bool =
                                                                                                                                                                                                      if v2898.clone().exists()
                                                                                                                                                                                                         {
                                                                                                                                                                                                          v2898.is_file()
                                                                                                                                                                                                      } else {
                                                                                                                                                                                                          false
                                                                                                                                                                                                      };
                                                                                                                                                                                                  _v2890.set(Some(x_49))
                                                                                                                                                                                              }
                                                                                                                                                                                              getValue(_v2890.get().clone())
                                                                                                                                                                                          } else {
                                                                                                                                                                                              false
                                                                                                                                                                                          }
                                                                                                                                                                                          {
                                                                                                                                                                                           let _v2914:
                                                                                                                                                                                                   MutCell<Option<bool>> =
                                                                                                                                                                                               MutCell::new(None::<bool>);
                                                                                                                                                                                           {
                                                                                                                                                                                               let x_50:
                                                                                                                                                                                                       bool =
                                                                                                                                                                                                   cfg!(windows);
                                                                                                                                                                                               _v2914.set(Some(x_50))
                                                                                                                                                                                           }
                                                                                                                                                                                           {
                                                                                                                                                                                               let v2948:
                                                                                                                                                                                                       Option<CancellationToken> =
                                                                                                                                                                                                   None::<CancellationToken>;
                                                                                                                                                                                               let v2949 =
                                                                                                                                                                                                   None::<Func1<(bool,
                                                                                                                                                                                                                 string,
                                                                                                                                                                                                                 i32),
                                                                                                                                                                                                                Arc<Async<()>>>>;
                                                                                                                                                                                               let v2950:
                                                                                                                                                                                                       Option<string> =
                                                                                                                                                                                                   None::<string>;
                                                                                                                                                                                               let v2951:
                                                                                                                                                                                                       string =
                                                                                                                                                                                                   sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                                                                            if getValue(_v2914.get().clone())
                                                                                                                                                                                                                   ==
                                                                                                                                                                                                                   false
                                                                                                                                                                                                               {
                                                                                                                                                                                                                v2865.clone()
                                                                                                                                                                                                            } else {
                                                                                                                                                                                                                let _v2927:
                                                                                                                                                                                                                        MutCell<Option<string>> =
                                                                                                                                                                                                                    MutCell::new(None::<string>);
                                                                                                                                                                                                                let v2929:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    Documents::method26();
                                                                                                                                                                                                                let v2930:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    Documents::method27(v2865.clone());
                                                                                                                                                                                                                let v2931:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    Documents::method28();
                                                                                                                                                                                                                let v2933:
                                                                                                                                                                                                                        &str =
                                                                                                                                                                                                                    &regex::Regex::new(&v2929).unwrap().replace_all(&v2930, &*v2931);
                                                                                                                                                                                                                let v2935:
                                                                                                                                                                                                                        std::string::String =
                                                                                                                                                                                                                    String::from(v2933);
                                                                                                                                                                                                                {
                                                                                                                                                                                                                    let x_51:
                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                        fable_library_rust::String_::fromString(v2935);
                                                                                                                                                                                                                    _v2927.set(Some(x_51))
                                                                                                                                                                                                                }
                                                                                                                                                                                                                {
                                                                                                                                                                                                                    let v2944:
                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                        getValue(_v2927.get().clone());
                                                                                                                                                                                                                    replace(sprintf!("{}{}",
                                                                                                                                                                                                                                     toLowerChar(getCharAt(v2944.clone(),
                                                                                                                                                                                                                                                           0_i32)),
                                                                                                                                                                                                                                     getSlice(v2944,
                                                                                                                                                                                                                                              Some(1_i32),
                                                                                                                                                                                                                                              None::<i32>)),
                                                                                                                                                                                                                            string("\\"),
                                                                                                                                                                                                                            string("/"))
                                                                                                                                                                                                                }
                                                                                                                                                                                                            });
                                                                                                                                                                                               let _v2952:
                                                                                                                                                                                                       MutCell<Option<(i32,
                                                                                                                                                                                                                       string)>> =
                                                                                                                                                                                                   MutCell::new(None::<(i32,
                                                                                                                                                                                                                        string)>);
                                                                                                                                                                                               let patternInput_30:
                                                                                                                                                                                                       (string,
                                                                                                                                                                                                        string) =
                                                                                                                                                                                                   Documents::method29();
                                                                                                                                                                                               let v2956:
                                                                                                                                                                                                       i32 =
                                                                                                                                                                                                   length(v2951.clone());
                                                                                                                                                                                               let v2957:
                                                                                                                                                                                                       Array<char> =
                                                                                                                                                                                                   new_init(&'\u{0000}',
                                                                                                                                                                                                            v2956);
                                                                                                                                                                                               let v2958:
                                                                                                                                                                                                       LrcPtr<Documents::Mut4> =
                                                                                                                                                                                                   LrcPtr::new(Documents::Mut4{l0:
                                                                                                                                                                                                                                   MutCell::new(0_i32),});
                                                                                                                                                                                               while Documents::method30(v2956,
                                                                                                                                                                                                                         v2958.clone())
                                                                                                                                                                                                     {
                                                                                                                                                                                                   let v2960:
                                                                                                                                                                                                           i32 =
                                                                                                                                                                                                       v2958.l0.get().clone();
                                                                                                                                                                                                   let v2961:
                                                                                                                                                                                                           char =
                                                                                                                                                                                                       getCharAt(v2951.clone(),
                                                                                                                                                                                                                 v2960);
                                                                                                                                                                                                   v2957.get_mut()[v2960
                                                                                                                                                                                                                       as
                                                                                                                                                                                                                       usize]
                                                                                                                                                                                                       =
                                                                                                                                                                                                       v2961;
                                                                                                                                                                                                   {
                                                                                                                                                                                                       let v2962:
                                                                                                                                                                                                               i32 =
                                                                                                                                                                                                           v2960
                                                                                                                                                                                                               +
                                                                                                                                                                                                               1_i32;
                                                                                                                                                                                                       v2958.l0.set(v2962);
                                                                                                                                                                                                       ()
                                                                                                                                                                                                   }
                                                                                                                                                                                               }
                                                                                                                                                                                               {
                                                                                                                                                                                                   let v2964:
                                                                                                                                                                                                           List<char> =
                                                                                                                                                                                                       ofArray(v2957.clone());
                                                                                                                                                                                                   let patternInput_31:
                                                                                                                                                                                                           (string,
                                                                                                                                                                                                            string) =
                                                                                                                                                                                                       Documents::method32(patternInput_30.1.clone(),
                                                                                                                                                                                                                           patternInput_30.0.clone(),
                                                                                                                                                                                                                           foldBack(Func2::new(move
                                                                                                                                                                                                                                                   |b0:
                                                                                                                                                                                                                                                        char,
                                                                                                                                                                                                                                                    b1:
                                                                                                                                                                                                                                                        LrcPtr<Documents::UH0>|
                                                                                                                                                                                                                                                   (Documents::method31())(b0)(b1)),
                                                                                                                                                                                                                                    v2964,
                                                                                                                                                                                                                                    LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                                                                           Documents::US10::US10_0);
                                                                                                                                                                                                   let v2972:
                                                                                                                                                                                                           string =
                                                                                                                                                                                                       patternInput_31.0.clone();
                                                                                                                                                                                                   let v2974:
                                                                                                                                                                                                           Array<string> =
                                                                                                                                                                                                       Documents::method33(patternInput_31.1.clone());
                                                                                                                                                                                                   let v2976:
                                                                                                                                                                                                           Vec<string> =
                                                                                                                                                                                                       v2974.to_vec();
                                                                                                                                                                                                   let v2978:
                                                                                                                                                                                                           Vec<std::string::String> =
                                                                                                                                                                                                       v2976.iter().map(|x| v255.clone()(x.clone())).collect();
                                                                                                                                                                                                   Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                                                                      Func0::new({
                                                                                                                                                                                                                                     let v2948
                                                                                                                                                                                                                                         =
                                                                                                                                                                                                                                         v2948.clone();
                                                                                                                                                                                                                                     let v2949
                                                                                                                                                                                                                                         =
                                                                                                                                                                                                                                         v2949.clone();
                                                                                                                                                                                                                                     let v2950
                                                                                                                                                                                                                                         =
                                                                                                                                                                                                                                         v2950.clone();
                                                                                                                                                                                                                                     let v2951
                                                                                                                                                                                                                                         =
                                                                                                                                                                                                                                         v2951.clone();
                                                                                                                                                                                                                                     let v2972
                                                                                                                                                                                                                                         =
                                                                                                                                                                                                                                         v2972.clone();
                                                                                                                                                                                                                                     let v2978
                                                                                                                                                                                                                                         =
                                                                                                                                                                                                                                         v2978.clone();
                                                                                                                                                                                                                                     move
                                                                                                                                                                                                                                         ||
                                                                                                                                                                                                                                         Documents::closure27(v2948.clone(),
                                                                                                                                                                                                                                                              v2951.clone(),
                                                                                                                                                                                                                                                              v2949.clone(),
                                                                                                                                                                                                                                                              v2950.clone(),
                                                                                                                                                                                                                                                              v2972.clone(),
                                                                                                                                                                                                                                                              v2978.clone(),
                                                                                                                                                                                                                                                              ())
                                                                                                                                                                                                                                 }),
                                                                                                                                                                                                                      Documents::method38());
                                                                                                                                                                                                   {
                                                                                                                                                                                                       let v2982:
                                                                                                                                                                                                               std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                                                                          string)>>>> =
                                                                                                                                                                                                           Documents::method39(v2948.clone(),
                                                                                                                                                                                                                               v2951.clone(),
                                                                                                                                                                                                                               v2949.clone(),
                                                                                                                                                                                                                               v2950.clone(),
                                                                                                                                                                                                                               v2972.clone(),
                                                                                                                                                                                                                               v2978.clone());
                                                                                                                                                                                                       let v2984:
                                                                                                                                                                                                               LrcPtr<(i32,
                                                                                                                                                                                                                       string)> =
                                                                                                                                                                                                           futures_lite::future::block_on(v2982);
                                                                                                                                                                                                       _v2952.set(Some((v2984.0.clone(),
                                                                                                                                                                                                                        v2984.1.clone())));
                                                                                                                                                                                                       {
                                                                                                                                                                                                           let patternInput_32:
                                                                                                                                                                                                                   (i32,
                                                                                                                                                                                                                    string) =
                                                                                                                                                                                                               getValue(_v2952.get().clone());
                                                                                                                                                                                                           let _v3158:
                                                                                                                                                                                                                   MutCell<Option<bool>> =
                                                                                                                                                                                                               MutCell::new(None::<bool>);
                                                                                                                                                                                                           {
                                                                                                                                                                                                               let x_53:
                                                                                                                                                                                                                       bool =
                                                                                                                                                                                                                   cfg!(windows);
                                                                                                                                                                                                               _v3158.set(Some(x_53))
                                                                                                                                                                                                           }
                                                                                                                                                                                                           {
                                                                                                                                                                                                               let v3192:
                                                                                                                                                                                                                       Option<CancellationToken> =
                                                                                                                                                                                                                   None::<CancellationToken>;
                                                                                                                                                                                                               let v3193 =
                                                                                                                                                                                                                   None::<Func1<(bool,
                                                                                                                                                                                                                                 string,
                                                                                                                                                                                                                                 i32),
                                                                                                                                                                                                                                Arc<Async<()>>>>;
                                                                                                                                                                                                               let v3194:
                                                                                                                                                                                                                       Option<string> =
                                                                                                                                                                                                                   None::<string>;
                                                                                                                                                                                                               let v3195:
                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                   sprintf!("pwsh -c \"(Get-FileHash \\\"{}\\\" -Algorithm SHA256).Hash\"",
                                                                                                                                                                                                                            if getValue(_v3158.get().clone())
                                                                                                                                                                                                                                   ==
                                                                                                                                                                                                                                   false
                                                                                                                                                                                                                               {
                                                                                                                                                                                                                                v2866.clone()
                                                                                                                                                                                                                            } else {
                                                                                                                                                                                                                                let _v3171:
                                                                                                                                                                                                                                        MutCell<Option<string>> =
                                                                                                                                                                                                                                    MutCell::new(None::<string>);
                                                                                                                                                                                                                                let v3173:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    Documents::method26();
                                                                                                                                                                                                                                let v3174:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    Documents::method27(v2866.clone());
                                                                                                                                                                                                                                let v3175:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    Documents::method28();
                                                                                                                                                                                                                                let v3177:
                                                                                                                                                                                                                                        &str =
                                                                                                                                                                                                                                    &regex::Regex::new(&v3173).unwrap().replace_all(&v3174, &*v3175);
                                                                                                                                                                                                                                let v3179:
                                                                                                                                                                                                                                        std::string::String =
                                                                                                                                                                                                                                    String::from(v3177);
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    let x_54:
                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                        fable_library_rust::String_::fromString(v3179);
                                                                                                                                                                                                                                    _v3171.set(Some(x_54))
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    let v3188:
                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                        getValue(_v3171.get().clone());
                                                                                                                                                                                                                                    replace(sprintf!("{}{}",
                                                                                                                                                                                                                                                     toLowerChar(getCharAt(v3188.clone(),
                                                                                                                                                                                                                                                                           0_i32)),
                                                                                                                                                                                                                                                     getSlice(v3188,
                                                                                                                                                                                                                                                              Some(1_i32),
                                                                                                                                                                                                                                                              None::<i32>)),
                                                                                                                                                                                                                                            string("\\"),
                                                                                                                                                                                                                                            string("/"))
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                            });
                                                                                                                                                                                                               let _v3196:
                                                                                                                                                                                                                       MutCell<Option<(i32,
                                                                                                                                                                                                                                       string)>> =
                                                                                                                                                                                                                   MutCell::new(None::<(i32,
                                                                                                                                                                                                                                        string)>);
                                                                                                                                                                                                               let patternInput_33:
                                                                                                                                                                                                                       (string,
                                                                                                                                                                                                                        string) =
                                                                                                                                                                                                                   Documents::method29();
                                                                                                                                                                                                               let v3200:
                                                                                                                                                                                                                       i32 =
                                                                                                                                                                                                                   length(v3195.clone());
                                                                                                                                                                                                               let v3201:
                                                                                                                                                                                                                       Array<char> =
                                                                                                                                                                                                                   new_init(&'\u{0000}',
                                                                                                                                                                                                                            v3200);
                                                                                                                                                                                                               let v3202:
                                                                                                                                                                                                                       LrcPtr<Documents::Mut4> =
                                                                                                                                                                                                                   LrcPtr::new(Documents::Mut4{l0:
                                                                                                                                                                                                                                                   MutCell::new(0_i32),});
                                                                                                                                                                                                               while Documents::method30(v3200,
                                                                                                                                                                                                                                         v3202.clone())
                                                                                                                                                                                                                     {
                                                                                                                                                                                                                   let v3204:
                                                                                                                                                                                                                           i32 =
                                                                                                                                                                                                                       v3202.l0.get().clone();
                                                                                                                                                                                                                   let v3205:
                                                                                                                                                                                                                           char =
                                                                                                                                                                                                                       getCharAt(v3195.clone(),
                                                                                                                                                                                                                                 v3204);
                                                                                                                                                                                                                   v3201.get_mut()[v3204
                                                                                                                                                                                                                                       as
                                                                                                                                                                                                                                       usize]
                                                                                                                                                                                                                       =
                                                                                                                                                                                                                       v3205;
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                       let v3206:
                                                                                                                                                                                                                               i32 =
                                                                                                                                                                                                                           v3204
                                                                                                                                                                                                                               +
                                                                                                                                                                                                                               1_i32;
                                                                                                                                                                                                                       v3202.l0.set(v3206);
                                                                                                                                                                                                                       ()
                                                                                                                                                                                                                   }
                                                                                                                                                                                                               }
                                                                                                                                                                                                               {
                                                                                                                                                                                                                   let v3208:
                                                                                                                                                                                                                           List<char> =
                                                                                                                                                                                                                       ofArray(v3201.clone());
                                                                                                                                                                                                                   let patternInput_34:
                                                                                                                                                                                                                           (string,
                                                                                                                                                                                                                            string) =
                                                                                                                                                                                                                       Documents::method32(patternInput_33.1.clone(),
                                                                                                                                                                                                                                           patternInput_33.0.clone(),
                                                                                                                                                                                                                                           foldBack(Func2::new(move
                                                                                                                                                                                                                                                                   |b0:
                                                                                                                                                                                                                                                                        char,
                                                                                                                                                                                                                                                                    b1:
                                                                                                                                                                                                                                                                        LrcPtr<Documents::UH0>|
                                                                                                                                                                                                                                                                   (Documents::method31())(b0)(b1)),
                                                                                                                                                                                                                                                    v3208,
                                                                                                                                                                                                                                                    LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                                                                                           Documents::US10::US10_0);
                                                                                                                                                                                                                   let v3216:
                                                                                                                                                                                                                           string =
                                                                                                                                                                                                                       patternInput_34.0.clone();
                                                                                                                                                                                                                   let v3218:
                                                                                                                                                                                                                           Array<string> =
                                                                                                                                                                                                                       Documents::method33(patternInput_34.1.clone());
                                                                                                                                                                                                                   let v3220:
                                                                                                                                                                                                                           Vec<string> =
                                                                                                                                                                                                                       v3218.to_vec();
                                                                                                                                                                                                                   let v3222:
                                                                                                                                                                                                                           Vec<std::string::String> =
                                                                                                                                                                                                                       v3220.iter().map(|x| v255.clone()(x.clone())).collect();
                                                                                                                                                                                                                   Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                                                                                      Func0::new({
                                                                                                                                                                                                                                                     let v3192
                                                                                                                                                                                                                                                         =
                                                                                                                                                                                                                                                         v3192.clone();
                                                                                                                                                                                                                                                     let v3193
                                                                                                                                                                                                                                                         =
                                                                                                                                                                                                                                                         v3193.clone();
                                                                                                                                                                                                                                                     let v3194
                                                                                                                                                                                                                                                         =
                                                                                                                                                                                                                                                         v3194.clone();
                                                                                                                                                                                                                                                     let v3195
                                                                                                                                                                                                                                                         =
                                                                                                                                                                                                                                                         v3195.clone();
                                                                                                                                                                                                                                                     let v3216
                                                                                                                                                                                                                                                         =
                                                                                                                                                                                                                                                         v3216.clone();
                                                                                                                                                                                                                                                     let v3222
                                                                                                                                                                                                                                                         =
                                                                                                                                                                                                                                                         v3222.clone();
                                                                                                                                                                                                                                                     move
                                                                                                                                                                                                                                                         ||
                                                                                                                                                                                                                                                         Documents::closure27(v3192.clone(),
                                                                                                                                                                                                                                                                              v3195.clone(),
                                                                                                                                                                                                                                                                              v3193.clone(),
                                                                                                                                                                                                                                                                              v3194.clone(),
                                                                                                                                                                                                                                                                              v3216.clone(),
                                                                                                                                                                                                                                                                              v3222.clone(),
                                                                                                                                                                                                                                                                              ())
                                                                                                                                                                                                                                                 }),
                                                                                                                                                                                                                                      Documents::method38());
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                       let v3226:
                                                                                                                                                                                                                               std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                                                                                          string)>>>> =
                                                                                                                                                                                                                           Documents::method39(v3192.clone(),
                                                                                                                                                                                                                                               v3195.clone(),
                                                                                                                                                                                                                                               v3193.clone(),
                                                                                                                                                                                                                                               v3194.clone(),
                                                                                                                                                                                                                                               v3216.clone(),
                                                                                                                                                                                                                                               v3222.clone());
                                                                                                                                                                                                                       let v3228:
                                                                                                                                                                                                                               LrcPtr<(i32,
                                                                                                                                                                                                                                       string)> =
                                                                                                                                                                                                                           futures_lite::future::block_on(v3226);
                                                                                                                                                                                                                       _v3196.set(Some((v3228.0.clone(),
                                                                                                                                                                                                                                        v3228.1.clone())));
                                                                                                                                                                                                                       patternInput_32.1.clone()
                                                                                                                                                                                                                           ==
                                                                                                                                                                                                                           (getValue(_v3196.get().clone())).1.clone()
                                                                                                                                                                                                                   }
                                                                                                                                                                                                               }
                                                                                                                                                                                                           }
                                                                                                                                                                                                       }
                                                                                                                                                                                                   }
                                                                                                                                                                                               }
                                                                                                                                                                                           }
                                                                                                                                                                                       } else {
                                                                                                                                                                                           false
                                                                                                                                                                                       })
                                                                                                                                                                                          ==
                                                                                                                                                                                          false
                                                                                                                                                                                      {
                                                                                                                                                                                       let v3405:
                                                                                                                                                                                               string =
                                                                                                                                                                                           sprintf!("crowbook --single \"{}\" --output \"{}\" --to {} --set rendering.num_depth 6 html.css.add \\\"\'\'\' body {{ color: #e8e6e3; background-color: #202324; }} a {{ color: #989693; }} \'\'\'\\\"",
                                                                                                                                                                                                    v511,
                                                                                                                                                                                                    v2865.clone(),
                                                                                                                                                                                                    string("html"));
                                                                                                                                                                                       let v3406:
                                                                                                                                                                                               Option<CancellationToken> =
                                                                                                                                                                                           None::<CancellationToken>;
                                                                                                                                                                                       let v3407 =
                                                                                                                                                                                           None::<Func1<(bool,
                                                                                                                                                                                                         string,
                                                                                                                                                                                                         i32),
                                                                                                                                                                                                        Arc<Async<()>>>>;
                                                                                                                                                                                       let v3409:
                                                                                                                                                                                               Option<string> =
                                                                                                                                                                                           Some(v1_1);
                                                                                                                                                                                       let _v3410:
                                                                                                                                                                                               MutCell<Option<(i32,
                                                                                                                                                                                                               string)>> =
                                                                                                                                                                                           MutCell::new(None::<(i32,
                                                                                                                                                                                                                string)>);
                                                                                                                                                                                       let patternInput_36:
                                                                                                                                                                                               (string,
                                                                                                                                                                                                string) =
                                                                                                                                                                                           Documents::method29();
                                                                                                                                                                                       let v3414:
                                                                                                                                                                                               i32 =
                                                                                                                                                                                           length(v3405.clone());
                                                                                                                                                                                       let v3415:
                                                                                                                                                                                               Array<char> =
                                                                                                                                                                                           new_init(&'\u{0000}',
                                                                                                                                                                                                    v3414);
                                                                                                                                                                                       let v3416:
                                                                                                                                                                                               LrcPtr<Documents::Mut4> =
                                                                                                                                                                                           LrcPtr::new(Documents::Mut4{l0:
                                                                                                                                                                                                                           MutCell::new(0_i32),});
                                                                                                                                                                                       while Documents::method30(v3414,
                                                                                                                                                                                                                 v3416.clone())
                                                                                                                                                                                             {
                                                                                                                                                                                           let v3418:
                                                                                                                                                                                                   i32 =
                                                                                                                                                                                               v3416.l0.get().clone();
                                                                                                                                                                                           let v3419:
                                                                                                                                                                                                   char =
                                                                                                                                                                                               getCharAt(v3405.clone(),
                                                                                                                                                                                                         v3418);
                                                                                                                                                                                           v3415.get_mut()[v3418
                                                                                                                                                                                                               as
                                                                                                                                                                                                               usize]
                                                                                                                                                                                               =
                                                                                                                                                                                               v3419;
                                                                                                                                                                                           {
                                                                                                                                                                                               let v3420:
                                                                                                                                                                                                       i32 =
                                                                                                                                                                                                   v3418
                                                                                                                                                                                                       +
                                                                                                                                                                                                       1_i32;
                                                                                                                                                                                               v3416.l0.set(v3420);
                                                                                                                                                                                               ()
                                                                                                                                                                                           }
                                                                                                                                                                                       }
                                                                                                                                                                                       {
                                                                                                                                                                                           let v3422:
                                                                                                                                                                                                   List<char> =
                                                                                                                                                                                               ofArray(v3415.clone());
                                                                                                                                                                                           let patternInput_37:
                                                                                                                                                                                                   (string,
                                                                                                                                                                                                    string) =
                                                                                                                                                                                               Documents::method32(patternInput_36.1.clone(),
                                                                                                                                                                                                                   patternInput_36.0.clone(),
                                                                                                                                                                                                                   foldBack(Func2::new(move
                                                                                                                                                                                                                                           |b0:
                                                                                                                                                                                                                                                char,
                                                                                                                                                                                                                                            b1:
                                                                                                                                                                                                                                                LrcPtr<Documents::UH0>|
                                                                                                                                                                                                                                           (Documents::method31())(b0)(b1)),
                                                                                                                                                                                                                            v3422,
                                                                                                                                                                                                                            LrcPtr::new(Documents::UH0::UH0_0)),
                                                                                                                                                                                                                   Documents::US10::US10_0);
                                                                                                                                                                                           let v3430:
                                                                                                                                                                                                   string =
                                                                                                                                                                                               patternInput_37.0.clone();
                                                                                                                                                                                           let v3432:
                                                                                                                                                                                                   Array<string> =
                                                                                                                                                                                               Documents::method33(patternInput_37.1.clone());
                                                                                                                                                                                           let v3434:
                                                                                                                                                                                                   Vec<string> =
                                                                                                                                                                                               v3432.to_vec();
                                                                                                                                                                                           let v3436:
                                                                                                                                                                                                   Vec<std::string::String> =
                                                                                                                                                                                               v3434.iter().map(|x| v255(x.clone())).collect();
                                                                                                                                                                                           Documents::method3(Documents::US0::US0_1,
                                                                                                                                                                                                              Func0::new({
                                                                                                                                                                                                                             let v3405
                                                                                                                                                                                                                                 =
                                                                                                                                                                                                                                 v3405.clone();
                                                                                                                                                                                                                             let v3406
                                                                                                                                                                                                                                 =
                                                                                                                                                                                                                                 v3406.clone();
                                                                                                                                                                                                                             let v3407
                                                                                                                                                                                                                                 =
                                                                                                                                                                                                                                 v3407.clone();
                                                                                                                                                                                                                             let v3409
                                                                                                                                                                                                                                 =
                                                                                                                                                                                                                                 v3409.clone();
                                                                                                                                                                                                                             let v3430
                                                                                                                                                                                                                                 =
                                                                                                                                                                                                                                 v3430.clone();
                                                                                                                                                                                                                             let v3436
                                                                                                                                                                                                                                 =
                                                                                                                                                                                                                                 v3436.clone();
                                                                                                                                                                                                                             move
                                                                                                                                                                                                                                 ||
                                                                                                                                                                                                                                 Documents::closure27(v3406.clone(),
                                                                                                                                                                                                                                                      v3405.clone(),
                                                                                                                                                                                                                                                      v3407.clone(),
                                                                                                                                                                                                                                                      v3409.clone(),
                                                                                                                                                                                                                                                      v3430.clone(),
                                                                                                                                                                                                                                                      v3436.clone(),
                                                                                                                                                                                                                                                      ())
                                                                                                                                                                                                                         }),
                                                                                                                                                                                                              Documents::method38());
                                                                                                                                                                                           {
                                                                                                                                                                                               let v3440:
                                                                                                                                                                                                       std::pin::Pin<Box<dyn std::future::Future<Output = LrcPtr<(i32,
                                                                                                                                                                                                                                                                  string)>>>> =
                                                                                                                                                                                                   Documents::method39(v3406.clone(),
                                                                                                                                                                                                                       v3405.clone(),
                                                                                                                                                                                                                       v3407.clone(),
                                                                                                                                                                                                                       v3409.clone(),
                                                                                                                                                                                                                       v3430.clone(),
                                                                                                                                                                                                                       v3436.clone());
                                                                                                                                                                                               let v3442:
                                                                                                                                                                                                       LrcPtr<(i32,
                                                                                                                                                                                                               string)> =
                                                                                                                                                                                                   futures_lite::future::block_on(v3440);
                                                                                                                                                                                               _v3410.set(Some((v3442.0.clone(),
                                                                                                                                                                                                                v3442.1.clone())));
                                                                                                                                                                                               {
                                                                                                                                                                                                   let patternInput_38:
                                                                                                                                                                                                           (i32,
                                                                                                                                                                                                            string) =
                                                                                                                                                                                                       getValue(_v3410.get().clone());
                                                                                                                                                                                                   let v3615:
                                                                                                                                                                                                           string =
                                                                                                                                                                                                       patternInput_38.1.clone();
                                                                                                                                                                                                   let v3614:
                                                                                                                                                                                                           i32 =
                                                                                                                                                                                                       patternInput_38.0.clone();
                                                                                                                                                                                                   Documents::method3(Documents::US0::US0_2,
                                                                                                                                                                                                                      Func0::new(move
                                                                                                                                                                                                                                     ||
                                                                                                                                                                                                                                     Documents::closure55((),
                                                                                                                                                                                                                                                          ())),
                                                                                                                                                                                                                      Func0::new({
                                                                                                                                                                                                                                     let v3614
                                                                                                                                                                                                                                         =
                                                                                                                                                                                                                                         v3614.clone();
                                                                                                                                                                                                                                     let v3615
                                                                                                                                                                                                                                         =
                                                                                                                                                                                                                                         v3615.clone();
                                                                                                                                                                                                                                     move
                                                                                                                                                                                                                                         ||
                                                                                                                                                                                                                                         Documents::closure56(v3615.clone(),
                                                                                                                                                                                                                                                              v3614,
                                                                                                                                                                                                                                                              ())
                                                                                                                                                                                                                                 }));
                                                                                                                                                                                                   if if v3614
                                                                                                                                                                                                             !=
                                                                                                                                                                                                             0_i32
                                                                                                                                                                                                         {
                                                                                                                                                                                                          true
                                                                                                                                                                                                      } else {
                                                                                                                                                                                                          contains(v3615.clone(),
                                                                                                                                                                                                                   string("ERROR"))
                                                                                                                                                                                                      }
                                                                                                                                                                                                      {
                                                                                                                                                                                                       Documents::US8::US8_0(Documents::US9::US9_1(v2865.clone(),
                                                                                                                                                                                                                                                   v3615.clone()))
                                                                                                                                                                                                   } else {
                                                                                                                                                                                                       let _v3625:
                                                                                                                                                                                                               MutCell<Option<()>> =
                                                                                                                                                                                                           MutCell::new(None::<()>);
                                                                                                                                                                                                       let v3627:
                                                                                                                                                                                                               string =
                                                                                                                                                                                                           Documents::method59(v2866);
                                                                                                                                                                                                       let v3629:
                                                                                                                                                                                                               Result<u64,
                                                                                                                                                                                                                      std::io::Error> =
                                                                                                                                                                                                           std::fs::copy(&*v2865, &*v3627);
                                                                                                                                                                                                       let v3631:
                                                                                                                                                                                                               u64 =
                                                                                                                                                                                                           v3629.unwrap();
                                                                                                                                                                                                       _v3625.set(Some(()));
                                                                                                                                                                                                       getValue(_v3625.get().clone());
                                                                                                                                                                                                       Documents::US8::US8_0(Documents::US9::US9_0(v2865))
                                                                                                                                                                                                   }
                                                                                                                                                                                               }
                                                                                                                                                                                           }
                                                                                                                                                                                       }
                                                                                                                                                                                   } else {
                                                                                                                                                                                       Documents::US8::US8_1
                                                                                                                                                                                   },
                                                                                                                                                                                   v2863,
                                                                                                                                                                                   v2090,
                                                                                                                                                                                   Documents::US8::US8_1])));
                                                                                                                                                   Documents::method3(Documents::US0::US0_2,
                                                                                                                                                                      Func0::new(move
                                                                                                                                                                                     ||
                                                                                                                                                                                     Documents::closure57((),
                                                                                                                                                                                                          ())),
                                                                                                                                                                      Func0::new({
                                                                                                                                                                                     let v3644
                                                                                                                                                                                         =
                                                                                                                                                                                         v3644.clone();
                                                                                                                                                                                     move
                                                                                                                                                                                         ||
                                                                                                                                                                                         Documents::closure58(v3644.clone(),
                                                                                                                                                                                                              ())
                                                                                                                                                                                 }));
                                                                                                                                                   {
                                                                                                                                                       let _v3648:
                                                                                                                                                               MutCell<Option<()>> =
                                                                                                                                                           MutCell::new(None::<()>);
                                                                                                                                                       let v3650:
                                                                                                                                                               string =
                                                                                                                                                           Documents::method59(v1044);
                                                                                                                                                       let v3652:
                                                                                                                                                               Result<u64,
                                                                                                                                                                      std::io::Error> =
                                                                                                                                                           std::fs::copy(&*v511, &*v3650);
                                                                                                                                                       let v3654:
                                                                                                                                                               u64 =
                                                                                                                                                           v3652.unwrap();
                                                                                                                                                       _v3648.set(Some(()));
                                                                                                                                                       getValue(_v3648.get().clone());
                                                                                                                                                       v3644.clone()
                                                                                                                                                   }
                                                                                                                                               }
                                                                                                                                           }
                                                                                                                                       }
                                                                                                                                   } else {
                                                                                                                                       new_empty::<Documents::US8>()
                                                                                                                                   }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        } else {
                                                                            new_empty::<
                                                                                Documents::US8,
                                                                            >(
                                                                            )
                                                                        },
                                                                    )
                                                                    )
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        pub fn closure59(unitVar: (), unitVar_1: ()) -> string {
            string("documents.run")
        }
        pub fn closure60(
            v0_1: Vec<Result<(string, Array<Documents::US8>), std::string::String>>,
            unitVar: (),
        ) -> string {
            sprintf!(
                "result_len: {} / {}",
                v0_1.len(),
                Documents::closure6((), ())
            )
        }
        pub fn method60(v0_1: Result<(), std::string::String>) -> Result<(), std::string::String> {
            v0_1
        }
        pub fn method17(
            v0_1: string,
            v1_1: string,
            v2: string,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<(), std::string::String>>>>
        {
            let __result = Box::pin(async move {
                //;
                {
                    let v5: async_walkdir::WalkDir = async_walkdir::WalkDir::new(&*v1_1.clone());
                    let v8: async_walkdir::WalkDir = async_walkdir::WalkDir::filter(v5, |x| {
                        Func1::new(move |v: async_walkdir::DirEntry| Documents::closure12((), v))(x)
                    });
                    let v9 = Documents::method25();
                    let v10: string =
                    string("futures_lite::stream::StreamExt::collect(futures_lite::stream::StreamExt::filter_map(v8, |x| v9(x))).await");
                    let v11: Vec<string> = futures_lite::stream::StreamExt::collect(
                        futures_lite::stream::StreamExt::filter_map(v8, |x| v9(x)),
                    )
                    .await;
                    Documents::method3(
                        Documents::US0::US0_1,
                        Func0::new(move || Documents::closure21((), ())),
                        Func0::new({
                            let v11 = v11.clone();
                            move || Documents::closure22(v11.clone(), ())
                        }),
                    );
                    {
                        let v16: rayon::vec::IntoIter<string> =
                            rayon::iter::IntoParallelIterator::into_par_iter(v11);
                        let v19: rayon::iter::Map<rayon::vec::IntoIter<string>, _> =
                            rayon::iter::ParallelIterator::map(v16, |x| {
                                Func1::new({
                                    let v0_1 = v0_1.clone();
                                    let v1_1 = v1_1.clone();
                                    let v2 = v2.clone();
                                    move |v_1: string| {
                                        Documents::closure23(
                                            v0_1.clone(),
                                            v1_1.clone(),
                                            v2.clone(),
                                            v_1,
                                        )
                                    }
                                })(x)
                            });
                        let v21: Vec<Result<(string, Array<Documents::US8>), std::string::String>> =
                            rayon::iter::ParallelIterator::collect(v19);
                        Documents::method3(
                            Documents::US0::US0_1,
                            Func0::new(move || Documents::closure59((), ())),
                            Func0::new({
                                let v21 = v21.clone();
                                move || Documents::closure60(v21.clone(), ())
                            }),
                        );
                        {
                            let v26: Result<(), std::string::String> =
                                Documents::method60(Ok::<(), std::string::String>(()));
                            v26
                        }
                    }
                }
            });
            {
                {
                    {
                        //;
                        __result
                    }
                }
            }
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
            if Documents::State::trace_state().get().clone().is_none() {
                Documents::State::trace_state().set(Some(Documents::closure2((), ())));
            }
            {
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    Option<i64>,
                    LrcPtr<Documents::Mut3>,
                ) = getValue(Documents::State::trace_state().get().clone());
                (patternInput.2.clone()).l0.set(Documents::US0::US0_2);
                {
                    let _v8: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v11: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
                    let v13: std::path::PathBuf = v11.unwrap();
                    let v15: std::path::Display = v13.display();
                    let _v16: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x: std::string::String = format!("{}", v15);
                        _v16.set(Some(x))
                    }
                    {
                        let v27: std::string::String = getValue(_v16.get().clone());
                        {
                            let x_1: string = fable_library_rust::String_::fromString(v27);
                            _v8.set(Some(x_1))
                        }
                        {
                            let v36: string = getValue(_v8.get().clone());
                            Documents::method3(
                                Documents::US0::US0_2,
                                Func0::new(move || Documents::closure4((), ())),
                                Func0::new({
                                    let v0_1 = v0_1.clone();
                                    let v36 = v36.clone();
                                    move || Documents::closure5(v0_1.clone(), v36.clone(), ())
                                }),
                            );
                            {
                                let v40: clap::Command = Documents::method0();
                                let v42: clap::ArgMatches = clap::Command::get_matches(v40);
                                let v43: string = Documents::method7();
                                let v45: &str = fable_library_rust::String_::LrcStr::as_str(&v43);
                                let v47: Option<std::string::String> =
                                    clap::ArgMatches::get_one(&v42, v45).cloned();
                                let v50: Documents::US3 = defaultValue(
                                    Documents::US3::US3_1,
                                    map(Documents::method8(), v47),
                                );
                                let v54: std::string::String = match &v50 {
                                    Documents::US3::US3_0(v50_0_0) => match &v50 {
                                        Documents::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => panic!("{}", string("Option does not have a value."),),
                                };
                                let v56: string = fable_library_rust::String_::fromString(v54);
                                let v57: string = Documents::method9();
                                let v59: &str = fable_library_rust::String_::LrcStr::as_str(&v57);
                                let v61: Option<std::string::String> =
                                    clap::ArgMatches::get_one(&v42, v59).cloned();
                                let v64: Documents::US3 = defaultValue(
                                    Documents::US3::US3_1,
                                    map(Documents::method8(), v61),
                                );
                                let v68: std::string::String = match &v64 {
                                    Documents::US3::US3_0(v64_0_0) => match &v64 {
                                        Documents::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => panic!("{}", string("Option does not have a value."),),
                                };
                                let v70: string = fable_library_rust::String_::fromString(v68);
                                let v71: string = Documents::method10();
                                let v73: &str = fable_library_rust::String_::LrcStr::as_str(&v71);
                                let v75: Option<std::string::String> =
                                    clap::ArgMatches::get_one(&v42, v73).cloned();
                                let v78: Documents::US3 = defaultValue(
                                    Documents::US3::US3_1,
                                    map(Documents::method8(), v75),
                                );
                                let v82: std::string::String = match &v78 {
                                    Documents::US3::US3_0(v78_0_0) => match &v78 {
                                        Documents::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => panic!("{}", string("Option does not have a value."),),
                                };
                                let v84: string = fable_library_rust::String_::fromString(v82);
                                let v85: string = Documents::method11();
                                let v87: &str = fable_library_rust::String_::LrcStr::as_str(&v85);
                                let v89: Option<std::string::String> =
                                    clap::ArgMatches::get_one(&v42, v87).cloned();
                                let v92: Documents::US3 = defaultValue(
                                    Documents::US3::US3_1,
                                    map(Documents::method8(), v89),
                                );
                                let v96: std::string::String = match &v92 {
                                    Documents::US3::US3_0(v92_0_0) => match &v92 {
                                        Documents::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => panic!("{}", string("Option does not have a value."),),
                                };
                                let v98: string = fable_library_rust::String_::fromString(v96);
                                let _v99: MutCell<Option<string>> = MutCell::new(None::<string>);
                                let v101: string = Documents::method12(v56);
                                let v102: string = Documents::method13(v101.clone());
                                let v104: &str = fable_library_rust::String_::LrcStr::as_str(&v102);
                                let v106: std::string::String = String::from(v104);
                                let v108: std::path::PathBuf = std::path::PathBuf::from(v106);
                                {
                                    let x_7: string = if v108.exists() == false {
                                        let _v112: MutCell<Option<string>> =
                                            MutCell::new(None::<string>);
                                        let v115: Result<std::path::PathBuf, std::io::Error> =
                                            std::env::current_dir();
                                        let v117: std::path::PathBuf = v115.unwrap();
                                        let v119: std::path::Display = v117.display();
                                        let _v120: MutCell<Option<std::string::String>> =
                                            MutCell::new(None::<std::string::String>);
                                        {
                                            let x_2: std::string::String = format!("{}", v119);
                                            _v120.set(Some(x_2))
                                        }
                                        {
                                            let v131: std::string::String =
                                                getValue(_v120.get().clone());
                                            {
                                                let x_3: string =
                                                    fable_library_rust::String_::fromString(v131);
                                                _v112.set(Some(x_3))
                                            }
                                            {
                                                let _v141: MutCell<Option<string>> =
                                                    MutCell::new(None::<string>);
                                                let v143: string = Documents::method13(getValue(
                                                    _v112.get().clone(),
                                                ));
                                                let v145: &str =
                                                    fable_library_rust::String_::LrcStr::as_str(
                                                        &v143,
                                                    );
                                                let v147: std::string::String = String::from(v145);
                                                let v149: std::path::PathBuf =
                                                    std::path::PathBuf::from(v147);
                                                let v150: string =
                                                    Documents::method13(v101.clone());
                                                let v152: &str =
                                                    fable_library_rust::String_::LrcStr::as_str(
                                                        &v150,
                                                    );
                                                let v154: std::string::String = String::from(v152);
                                                let v156: std::path::PathBuf = v149.join(v154);
                                                let v158: std::path::Display = v156.display();
                                                let _v159: MutCell<Option<std::string::String>> =
                                                    MutCell::new(None::<std::string::String>);
                                                {
                                                    let x_4: std::string::String =
                                                        format!("{}", v158);
                                                    _v159.set(Some(x_4))
                                                }
                                                {
                                                    let v170: std::string::String =
                                                        getValue(_v159.get().clone());
                                                    {
                                                        let x_5: string =
                                                            fable_library_rust::String_::fromString(
                                                                v170,
                                                            );
                                                        _v141.set(Some(x_5))
                                                    }
                                                    getValue(_v141.get().clone())
                                                }
                                            }
                                        }
                                    } else {
                                        let v185: Result<std::path::PathBuf, std::io::Error> =
                                            std::fs::canonicalize(&*v101);
                                        let v187: std::path::PathBuf = v185.unwrap();
                                        let v189: std::path::Display = v187.display();
                                        let _v190: MutCell<Option<std::string::String>> =
                                            MutCell::new(None::<std::string::String>);
                                        {
                                            let x_6: std::string::String = format!("{}", v189);
                                            _v190.set(Some(x_6))
                                        }
                                        {
                                            let v201: std::string::String =
                                                getValue(_v190.get().clone());
                                            fable_library_rust::String_::fromString(v201)
                                        }
                                    };
                                    _v99.set(Some(x_7))
                                }
                                {
                                    let v212: string = getValue(_v99.get().clone());
                                    let _v213: MutCell<Option<string>> =
                                        MutCell::new(None::<string>);
                                    let v215: string = Documents::method12(v70);
                                    let v216: string = Documents::method13(v215.clone());
                                    let v218: &str =
                                        fable_library_rust::String_::LrcStr::as_str(&v216);
                                    let v220: std::string::String = String::from(v218);
                                    let v222: std::path::PathBuf = std::path::PathBuf::from(v220);
                                    {
                                        let x_13: string = if v222.exists() == false {
                                            let _v226: MutCell<Option<string>> =
                                                MutCell::new(None::<string>);
                                            let v229: Result<std::path::PathBuf, std::io::Error> =
                                                std::env::current_dir();
                                            let v231: std::path::PathBuf = v229.unwrap();
                                            let v233: std::path::Display = v231.display();
                                            let _v234: MutCell<Option<std::string::String>> =
                                                MutCell::new(None::<std::string::String>);
                                            {
                                                let x_8: std::string::String = format!("{}", v233);
                                                _v234.set(Some(x_8))
                                            }
                                            {
                                                let v245: std::string::String =
                                                    getValue(_v234.get().clone());
                                                {
                                                    let x_9: string =
                                                        fable_library_rust::String_::fromString(
                                                            v245,
                                                        );
                                                    _v226.set(Some(x_9))
                                                }
                                                {
                                                    let _v255: MutCell<Option<string>> =
                                                        MutCell::new(None::<string>);
                                                    let v257: string = Documents::method13(
                                                        getValue(_v226.get().clone()),
                                                    );
                                                    let v259: &str =
                                                        fable_library_rust::String_::LrcStr::as_str(
                                                            &v257,
                                                        );
                                                    let v261: std::string::String =
                                                        String::from(v259);
                                                    let v263: std::path::PathBuf =
                                                        std::path::PathBuf::from(v261);
                                                    let v264: string =
                                                        Documents::method13(v215.clone());
                                                    let v266: &str =
                                                        fable_library_rust::String_::LrcStr::as_str(
                                                            &v264,
                                                        );
                                                    let v268: std::string::String =
                                                        String::from(v266);
                                                    let v270: std::path::PathBuf = v263.join(v268);
                                                    let v272: std::path::Display = v270.display();
                                                    let _v273: MutCell<
                                                        Option<std::string::String>,
                                                    > = MutCell::new(None::<std::string::String>);
                                                    {
                                                        let x_10: std::string::String =
                                                            format!("{}", v272);
                                                        _v273.set(Some(x_10))
                                                    }
                                                    {
                                                        let v284: std::string::String =
                                                            getValue(_v273.get().clone());
                                                        {
                                                            let x_11:
                                                                        string =
                                                                    fable_library_rust::String_::fromString(v284);
                                                            _v255.set(Some(x_11))
                                                        }
                                                        getValue(_v255.get().clone())
                                                    }
                                                }
                                            }
                                        } else {
                                            let v299: Result<std::path::PathBuf, std::io::Error> =
                                                std::fs::canonicalize(&*v215);
                                            let v301: std::path::PathBuf = v299.unwrap();
                                            let v303: std::path::Display = v301.display();
                                            let _v304: MutCell<Option<std::string::String>> =
                                                MutCell::new(None::<std::string::String>);
                                            {
                                                let x_12: std::string::String = format!("{}", v303);
                                                _v304.set(Some(x_12))
                                            }
                                            {
                                                let v315: std::string::String =
                                                    getValue(_v304.get().clone());
                                                fable_library_rust::String_::fromString(v315)
                                            }
                                        };
                                        _v213.set(Some(x_13))
                                    }
                                    {
                                        let v326: string = getValue(_v213.get().clone());
                                        let _v327: MutCell<Option<string>> =
                                            MutCell::new(None::<string>);
                                        let v329: string = Documents::method12(v84);
                                        let v330: string = Documents::method13(v329.clone());
                                        let v332: &str =
                                            fable_library_rust::String_::LrcStr::as_str(&v330);
                                        let v334: std::string::String = String::from(v332);
                                        let v336: std::path::PathBuf =
                                            std::path::PathBuf::from(v334);
                                        {
                                            let x_19: string = if v336.exists() == false {
                                                let _v340: MutCell<Option<string>> =
                                                    MutCell::new(None::<string>);
                                                let v343: Result<
                                                    std::path::PathBuf,
                                                    std::io::Error,
                                                > = std::env::current_dir();
                                                let v345: std::path::PathBuf = v343.unwrap();
                                                let v347: std::path::Display = v345.display();
                                                let _v348: MutCell<Option<std::string::String>> =
                                                    MutCell::new(None::<std::string::String>);
                                                {
                                                    let x_14: std::string::String =
                                                        format!("{}", v347);
                                                    _v348.set(Some(x_14))
                                                }
                                                {
                                                    let v359: std::string::String =
                                                        getValue(_v348.get().clone());
                                                    {
                                                        let x_15: string =
                                                            fable_library_rust::String_::fromString(
                                                                v359,
                                                            );
                                                        _v340.set(Some(x_15))
                                                    }
                                                    {
                                                        let _v369: MutCell<Option<string>> =
                                                            MutCell::new(None::<string>);
                                                        let v371: string = Documents::method13(
                                                            getValue(_v340.get().clone()),
                                                        );
                                                        let v373: &str =
                                                                fable_library_rust::String_::LrcStr::as_str(&v371);
                                                        let v375: std::string::String =
                                                            String::from(v373);
                                                        let v377: std::path::PathBuf =
                                                            std::path::PathBuf::from(v375);
                                                        let v378: string =
                                                            Documents::method13(v329.clone());
                                                        let v380: &str =
                                                                fable_library_rust::String_::LrcStr::as_str(&v378);
                                                        let v382: std::string::String =
                                                            String::from(v380);
                                                        let v384: std::path::PathBuf =
                                                            v377.join(v382);
                                                        let v386: std::path::Display =
                                                            v384.display();
                                                        let _v387: MutCell<
                                                            Option<std::string::String>,
                                                        > = MutCell::new(
                                                            None::<std::string::String>,
                                                        );
                                                        {
                                                            let x_16: std::string::String =
                                                                format!("{}", v386);
                                                            _v387.set(Some(x_16))
                                                        }
                                                        {
                                                            let v398: std::string::String =
                                                                getValue(_v387.get().clone());
                                                            {
                                                                let x_17:
                                                                            string =
                                                                        fable_library_rust::String_::fromString(v398);
                                                                _v369.set(Some(x_17))
                                                            }
                                                            getValue(_v369.get().clone())
                                                        }
                                                    }
                                                }
                                            } else {
                                                let v413: Result<
                                                    std::path::PathBuf,
                                                    std::io::Error,
                                                > = std::fs::canonicalize(&*v329);
                                                let v415: std::path::PathBuf = v413.unwrap();
                                                let v417: std::path::Display = v415.display();
                                                let _v418: MutCell<Option<std::string::String>> =
                                                    MutCell::new(None::<std::string::String>);
                                                {
                                                    let x_18: std::string::String =
                                                        format!("{}", v417);
                                                    _v418.set(Some(x_18))
                                                }
                                                {
                                                    let v429: std::string::String =
                                                        getValue(_v418.get().clone());
                                                    fable_library_rust::String_::fromString(v429)
                                                }
                                            };
                                            _v327.set(Some(x_19))
                                        }
                                        {
                                            let v440: string = getValue(_v327.get().clone());
                                            Documents::method3(
                                                Documents::US0::US0_1,
                                                Func0::new(move || Documents::closure10((), ())),
                                                Func0::new({
                                                    let v212 = v212.clone();
                                                    let v326 = v326.clone();
                                                    let v440 = v440.clone();
                                                    let v98 = v98.clone();
                                                    move || {
                                                        Documents::closure11(
                                                            v98.clone(),
                                                            v212.clone(),
                                                            v326.clone(),
                                                            v440.clone(),
                                                            (),
                                                        )
                                                    }
                                                }),
                                            );
                                            {
                                                let v444: std::pin::Pin<
                                                    Box<
                                                        dyn std::future::Future<
                                                            Output = Result<
                                                                (),
                                                                std::string::String,
                                                            >,
                                                        >,
                                                    >,
                                                > = Documents::method17(
                                                    v212.clone(),
                                                    v326.clone(),
                                                    v440.clone(),
                                                );
                                                let v446: Result<(), std::string::String> =
                                                    futures_lite::future::block_on(v444);
                                                v446.unwrap();
                                                0_i32
                                            }
                                        }
                                    }
                                }
                            }
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
